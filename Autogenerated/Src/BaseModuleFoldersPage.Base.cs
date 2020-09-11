namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TerrasoftWebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: BaseModuleFoldersPageSchema

	/// <exclude/>
	public class BaseModuleFoldersPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TreeGrid _treeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid TreeGrid {
			get {
				return _treeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _preloadMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem PreloadMenuItem {
			get {
				return _preloadMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _noActiveMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem NoActiveMenuItem {
			get {
				return _noActiveMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _addGeneralFolderMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AddGeneralFolderMenuItem {
			get {
				return _addGeneralFolderMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _addSearchFolderMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AddSearchFolderMenuItem {
			get {
				return _addSearchFolderMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _addSubEmailFolderMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AddSubEmailFolderMenuItem {
			get {
				return _addSubEmailFolderMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _editMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem EditMenuItem {
			get {
				return _editMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _removeMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem RemoveMenuItem {
			get {
				return _removeMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _adminRightMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AdminRightMenuItem {
			get {
				return _adminRightMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _configureDuplicatesMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem ConfigureDuplicatesMenuItem {
			get {
				return _configureDuplicatesMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _startDuplicatesSearchMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem StartDuplicatesSearchMenuItem {
			get {
				return _startDuplicatesSearchMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _dataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return _dataSource;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ImageList _groupImageList;
		public Terrasoft.UI.WebControls.Controls.ImageList GroupImageList {
			get {
				return _groupImageList;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseModuleFoldersPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseModuleFoldersPageSchema(BaseModuleFoldersPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			RealUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			Name = "BaseModuleFoldersPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UseProfile = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseModuleFoldersPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateTreeGrid());
			TreeGrid.InsertItem(0, CreatePreloadMenuItem());
			TreeGrid.InsertItem(1, CreateNoActiveMenuItem());
			TreeGrid.InsertItem(2, CreateAddGeneralFolderMenuItem());
			TreeGrid.InsertItem(3, CreateAddSearchFolderMenuItem());
			TreeGrid.InsertItem(4, CreateAddSubEmailFolderMenuItem());
			TreeGrid.InsertItem(5, CreateEditMenuItem());
			TreeGrid.InsertItem(6, CreateRemoveMenuItem());
			TreeGrid.InsertItem(7, CreateAdminRightMenuItem());
			TreeGrid.InsertItem(8, CreateConfigureDuplicatesMenuItem());
			TreeGrid.InsertItem(9, CreateStartDuplicatesSearchMenuItem());
			Controls.AddAt(1, CreateDataSource());
			UpdateDataSource();
			Controls.AddAt(2, CreateGroupImageList());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseModuleFoldersPageEventsProcessSchema() {
			var schema = new BaseModuleFoldersPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreatePreloadMenuItem() {
			_preloadMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_preloadMenuItem.UId = new Guid("00fa5da8-bc6c-4342-a2a4-42074237396b");
			_preloadMenuItem.Name = "PreloadMenuItem";
			_preloadMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_preloadMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_preloadMenuItem.CreatedInPackageId = new Guid("bcafd6c1-9bfc-460a-9d01-415f1e657707");
			_preloadMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_preloadMenuItem.Image = new ControlImage {};
			_preloadMenuItem.Tag = "";
			_preloadMenuItem.Enabled = false;
			return _preloadMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateNoActiveMenuItem() {
			_noActiveMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_noActiveMenuItem.UId = new Guid("448c9fce-a86a-46d1-baba-d006e16a2860");
			_noActiveMenuItem.Name = "NoActiveMenuItem";
			_noActiveMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_noActiveMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_noActiveMenuItem.CreatedInPackageId = new Guid("bcafd6c1-9bfc-460a-9d01-415f1e657707");
			_noActiveMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_noActiveMenuItem.Image = new ControlImage {};
			_noActiveMenuItem.Tag = "";
			return _noActiveMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddGeneralFolderMenuItem() {
			_addGeneralFolderMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_addGeneralFolderMenuItem.UId = new Guid("a0c9daef-c3a0-4198-8568-ebb3241f2ba5");
			_addGeneralFolderMenuItem.Name = "AddGeneralFolderMenuItem";
			_addGeneralFolderMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_addGeneralFolderMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_addGeneralFolderMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addGeneralFolderMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_addGeneralFolderMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addGeneralFolderMenuItem.Image = new ControlImage {};
			_addGeneralFolderMenuItem.Tag = "";
			return _addGeneralFolderMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddSearchFolderMenuItem() {
			_addSearchFolderMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_addSearchFolderMenuItem.UId = new Guid("aa9ac44c-9bac-427b-9bc0-4dde43c8648a");
			_addSearchFolderMenuItem.Name = "AddSearchFolderMenuItem";
			_addSearchFolderMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_addSearchFolderMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_addSearchFolderMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addSearchFolderMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_addSearchFolderMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addSearchFolderMenuItem.Image = new ControlImage {};
			_addSearchFolderMenuItem.Tag = "";
			return _addSearchFolderMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddSubEmailFolderMenuItem() {
			_addSubEmailFolderMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_addSubEmailFolderMenuItem.UId = new Guid("a57bcae3-262c-439c-8a00-65d179e2e60b");
			_addSubEmailFolderMenuItem.Name = "AddSubEmailFolderMenuItem";
			_addSubEmailFolderMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_addSubEmailFolderMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_addSubEmailFolderMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addSubEmailFolderMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_addSubEmailFolderMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addSubEmailFolderMenuItem.Image = new ControlImage {};
			_addSubEmailFolderMenuItem.Tag = "";
			return _addSubEmailFolderMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateEditMenuItem() {
			_editMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_editMenuItem.UId = new Guid("c995c8fa-5eed-4e44-b5cb-be8754697a47");
			_editMenuItem.Name = "EditMenuItem";
			_editMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_editMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_editMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_editMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_editMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_editMenuItem.Image = new ControlImage {};
			_editMenuItem.Tag = "";
			return _editMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateRemoveMenuItem() {
			_removeMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_removeMenuItem.UId = new Guid("cda4121b-1227-49da-9012-5716e8439cc6");
			_removeMenuItem.Name = "RemoveMenuItem";
			_removeMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_removeMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_removeMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_removeMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_removeMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_removeMenuItem.Image = new ControlImage {};
			_removeMenuItem.Tag = "";
			return _removeMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAdminRightMenuItem() {
			_adminRightMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_adminRightMenuItem.UId = new Guid("09ba45fe-6dd0-4405-a915-53957cc79dcf");
			_adminRightMenuItem.Name = "AdminRightMenuItem";
			_adminRightMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_adminRightMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_adminRightMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_adminRightMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_adminRightMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_adminRightMenuItem.Image = new ControlImage {};
			_adminRightMenuItem.Tag = "";
			return _adminRightMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateConfigureDuplicatesMenuItem() {
			_configureDuplicatesMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_configureDuplicatesMenuItem.UId = new Guid("5e206719-2476-48d6-8973-6cb4f864df42");
			_configureDuplicatesMenuItem.Name = "ConfigureDuplicatesMenuItem";
			_configureDuplicatesMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_configureDuplicatesMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_configureDuplicatesMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_configureDuplicatesMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_configureDuplicatesMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_configureDuplicatesMenuItem.Image = new ControlImage {};
			_configureDuplicatesMenuItem.Tag = "";
			return _configureDuplicatesMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateStartDuplicatesSearchMenuItem() {
			_startDuplicatesSearchMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_startDuplicatesSearchMenuItem.UId = new Guid("4f9e0b15-5143-4520-9418-d43983a3cb16");
			_startDuplicatesSearchMenuItem.Name = "StartDuplicatesSearchMenuItem";
			_startDuplicatesSearchMenuItem.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_startDuplicatesSearchMenuItem.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_startDuplicatesSearchMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_startDuplicatesSearchMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_startDuplicatesSearchMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_startDuplicatesSearchMenuItem.Image = new ControlImage {};
			_startDuplicatesSearchMenuItem.Tag = "";
			return _startDuplicatesSearchMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateTreeGrid() {
			_treeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_treeGrid.UId = new Guid("b7c0e074-47c7-4de4-bd35-cc8e8f0150d7");
			_treeGrid.Name = "TreeGrid";
			_treeGrid.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_treeGrid.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_treeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_treeGrid.AjaxEvents.SelectionChange.ShowLoadMask = true;
			_treeGrid.Tag = "";
			_treeGrid.DataSourceId = "DataSource";
			_treeGrid.Edges = "";
			_treeGrid.IsColumnAutowidth = true;
			_treeGrid.FooterVisible = false;
			_treeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_treeGrid.IsSummaryVisible = false;
			_treeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_treeGrid.EnableDragDrop = true;
			_treeGrid.HideHeaders = false;
			_treeGrid.DragDropMode = Terrasoft.UI.WebControls.Controls.TreeGridDragDropMode.Append;
			return _treeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateDataSource() {
			_dataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_dataSource.UId = new Guid("5c8419b8-da8d-4eb9-95e8-38ef4d3707f9");
			_dataSource.Name = "DataSource";
			_dataSource.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_dataSource.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_dataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataSource.Tag = "";
			_dataSource.EnableServerActiveRow = false;
			_dataSource.SchemaUId = Guid.Empty;
			_dataSource.HierarchicalDepth = -1;
			_dataSource.DefStructure.ID = "c" + _dataSource.DefStructure.UId.ToString("N");
			_dataSource.DefStructure.UId = new Guid("fbb3d05f-2fd9-417a-95e1-04e2e8894c20");
			_dataSource.DefStructure.Name = "DefStructure";
			_dataSource.DefStructure.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_dataSource.DefStructure.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			return _dataSource;
		}

		protected virtual void UpdateDataSource() {
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ImageList CreateGroupImageList() {
			_groupImageList = new Terrasoft.UI.WebControls.Controls.ImageList();
			_groupImageList.UId = new Guid("98384800-46dc-4b4e-90f6-5c94e9eccffd");
			_groupImageList.Name = "GroupImageList";
			_groupImageList.CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_groupImageList.ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_groupImageList.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_groupImageList.Tag = "";
			_groupImageList.InsertItem(0, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("12694e7f-d1d9-43d1-b0cd-93cf4926201d"),
					ID = @"c12694e7fd1d943d1b0cd93cf4926201d",
					Name = "GroupImage",
					CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0"),
					ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0")
				});
			_groupImageList.InsertItem(1, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("e44c0dff-34ef-4af6-8d3c-e2f4b2b6b81a"),
					ID = @"ce44c0dff34ef4af68d3ce2f4b2b6b81a",
					Name = "FilteredGroupImage",
					CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0"),
					ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0")
				});
			_groupImageList.InsertItem(2, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("eaa8d35d-7110-42a0-a62d-6b169783febe"),
					ID = @"ceaa8d35d711042a0a62d6b169783febe",
					Name = "RecentGroupImage",
					CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0"),
					ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0")
				});
			_groupImageList.InsertItem(3, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("a1dc01d7-c902-4411-ba28-0cd6eaa03113"),
					ID = @"ca1dc01d7c9024411ba280cd6eaa03113",
					Name = "DuplicatesGroupImage",
					CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0"),
					ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0")
				});
			_groupImageList.InsertItem(4, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("33057df5-588a-411a-a63a-7f5e8be8b3f2"),
					ID = @"c33057df5588a411aa63a7f5e8be8b3f2",
					Name = "EmailGroupImage",
					CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0"),
					ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0")
				});
			_groupImageList.InsertItem(5, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("3fae3b1c-9861-48e7-9595-29bece11255a"),
					ID = @"c3fae3b1c986148e7959529bece11255a",
					Name = "SubEmailGroupImage",
					CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0"),
					ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0")
				});
			_groupImageList.InsertItem(6, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("cca3aeff-c90f-4868-b3bd-0a3dfb5dc83e"),
					ID = @"ccca3aeffc90f4868b3bd0a3dfb5dc83e",
					Name = "MailBoxGroupImage",
					CreatedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0"),
					ModifiedInSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0")
				});
			return _groupImageList;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseModuleFoldersPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseModuleFoldersPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseModuleFoldersPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseModuleFoldersPageEventsProcess

	/// <exclude/>
	public class BaseModuleFoldersPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseModuleFoldersPageSchemaUserControl
	{

		#region Class: UserTaskAdminRightOpenWindowFlowElement

		/// <exclude/>
		public class UserTaskAdminRightOpenWindowFlowElement : OpenPageUserTask
		{

			public UserTaskAdminRightOpenWindowFlowElement(UserConnection userConnection, BaseModuleFoldersPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskAdminRightOpenWindow";
				IsLogging = false;
				SchemaElementUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskAddSearchFolderOpenWindowFlowElement

		/// <exclude/>
		public class UserTaskAddSearchFolderOpenWindowFlowElement : OpenPageUserTask
		{

			public UserTaskAddSearchFolderOpenWindowFlowElement(UserConnection userConnection, BaseModuleFoldersPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskAddSearchFolderOpenWindow";
				IsLogging = false;
				SchemaElementUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskAddGeneralFolderOpenWindowFlowElement

		/// <exclude/>
		public class UserTaskAddGeneralFolderOpenWindowFlowElement : OpenPageUserTask
		{

			public UserTaskAddGeneralFolderOpenWindowFlowElement(UserConnection userConnection, BaseModuleFoldersPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskAddGeneralFolderOpenWindow";
				IsLogging = false;
				SchemaElementUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskEditFolderOpenWindowFlowElement

		/// <exclude/>
		public class UserTaskEditFolderOpenWindowFlowElement : OpenPageUserTask
		{

			public UserTaskEditFolderOpenWindowFlowElement(UserConnection userConnection, BaseModuleFoldersPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskEditFolderOpenWindow";
				IsLogging = false;
				SchemaElementUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: AddSubEmailFolderUserTaskFlowElement

		/// <exclude/>
		public class AddSubEmailFolderUserTaskFlowElement : OpenPageUserTask
		{

			public AddSubEmailFolderUserTaskFlowElement(UserConnection userConnection, BaseModuleFoldersPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddSubEmailFolderUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserMessageFlowElement

		/// <exclude/>
		public class UserMessageFlowElement : QuestionUserTask
		{

			public UserMessageFlowElement(UserConnection userConnection, BaseModuleFoldersPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68");
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

		public BaseModuleFoldersPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseModuleFoldersPageEventsProcess";
			SchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
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

		public virtual string EntitySchemaManagerName {
			get;
			set;
		}

		public virtual Guid EditPageUId {
			get;
			set;
		}

		public virtual Object ListenerPage {
			get;
			set;
		}

		public virtual Guid DefValuesId {
			get;
			set;
		}

		public virtual string ListenerPageProcessUId {
			get;
			set;
		}

		public virtual string DropTags {
			get;
			set;
		}

		public virtual Guid DuplicatesFolderId {
			get;
			set;
		}

		public virtual bool IsMultiFolder {
			get;
			set;
		}

		public virtual bool IsAdministratedByRecords {
			get;
			set;
		}

		public virtual string CacheItemName {
			get;
			set;
		}

		public virtual Guid DefaultFolderId {
			get;
			set;
		}

		public virtual Object ProcessSchemaParameter1 {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess2999;
		public ProcessFlowElement EventSubProcess2999 {
			get {
				return _eventSubProcess2999 ?? (_eventSubProcess2999 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2999",
					SchemaElementUId = new Guid("a508a678-3792-401f-9fe8-069fdbadb470"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _prepareOpenRightsPageScriptTask;
		public ProcessScriptTask PrepareOpenRightsPageScriptTask {
			get {
				return _prepareOpenRightsPageScriptTask ?? (_prepareOpenRightsPageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareOpenRightsPageScriptTask",
					SchemaElementUId = new Guid("b9660650-7ef5-4d5e-a4e9-80c204291f49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareOpenRightsPageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _configureDuplicatesRightsMenuItemClickStartMessage;
		public ProcessFlowElement ConfigureDuplicatesRightsMenuItemClickStartMessage {
			get {
				return _configureDuplicatesRightsMenuItemClickStartMessage ?? (_configureDuplicatesRightsMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ConfigureDuplicatesRightsMenuItemClickStartMessage",
					SchemaElementUId = new Guid("250bb5ee-b9c0-4d00-bad1-d0c20dc48f86"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5999;
		public ProcessFlowElement EventSubProcess5999 {
			get {
				return _eventSubProcess5999 ?? (_eventSubProcess5999 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5999",
					SchemaElementUId = new Guid("b0e2a183-4619-409e-a533-14d1d7fccc06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startDuplicatesSearchMenuItemClickStartMessage;
		public ProcessFlowElement StartDuplicatesSearchMenuItemClickStartMessage {
			get {
				return _startDuplicatesSearchMenuItemClickStartMessage ?? (_startDuplicatesSearchMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartDuplicatesSearchMenuItemClickStartMessage",
					SchemaElementUId = new Guid("c63f1c5b-bb3d-4c1e-be5f-84836cda6863"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _startDuplicatesSearchMenuItemClickScriptTask;
		public ProcessScriptTask StartDuplicatesSearchMenuItemClickScriptTask {
			get {
				return _startDuplicatesSearchMenuItemClickScriptTask ?? (_startDuplicatesSearchMenuItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "StartDuplicatesSearchMenuItemClickScriptTask",
					SchemaElementUId = new Guid("a86d73e3-665a-41eb-afd0-c13f73a20373"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = StartDuplicatesSearchMenuItemClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6999;
		public ProcessFlowElement EventSubProcess6999 {
			get {
				return _eventSubProcess6999 ?? (_eventSubProcess6999 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6999",
					SchemaElementUId = new Guid("f8cfcc2c-3523-42d9-ab4e-7612cec2ec7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _configureDuplicatesMenuItemClickScriptTask;
		public ProcessScriptTask ConfigureDuplicatesMenuItemClickScriptTask {
			get {
				return _configureDuplicatesMenuItemClickScriptTask ?? (_configureDuplicatesMenuItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ConfigureDuplicatesMenuItemClickScriptTask",
					SchemaElementUId = new Guid("98a48d13-4b90-401b-8f46-2f4c826f9523"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ConfigureDuplicatesMenuItemClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _configureDuplicatesMenuItemClickStartMessage;
		public ProcessFlowElement ConfigureDuplicatesMenuItemClickStartMessage {
			get {
				return _configureDuplicatesMenuItemClickStartMessage ?? (_configureDuplicatesMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ConfigureDuplicatesMenuItemClickStartMessage",
					SchemaElementUId = new Guid("8e46837d-4bf7-4810-be0e-6affdcaf55d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _folderGridNodesDropSubProcess;
		public ProcessFlowElement FolderGridNodesDropSubProcess {
			get {
				return _folderGridNodesDropSubProcess ?? (_folderGridNodesDropSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "FolderGridNodesDropSubProcess",
					SchemaElementUId = new Guid("11c02834-8890-463e-9269-0c5619eb620f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _folderGridNodesDrop;
		public ProcessFlowElement FolderGridNodesDrop {
			get {
				return _folderGridNodesDrop ?? (_folderGridNodesDrop = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FolderGridNodesDrop",
					SchemaElementUId = new Guid("d9f30f06-cdaf-40c4-bcb7-1d2d37dc063e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _folderGridNodesDropScript;
		public ProcessScriptTask FolderGridNodesDropScript {
			get {
				return _folderGridNodesDropScript ?? (_folderGridNodesDropScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FolderGridNodesDropScript",
					SchemaElementUId = new Guid("51b7c399-dbe2-4c12-a455-c650e3bb1c2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FolderGridNodesDropScriptExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess3;
		public ProcessFlowElement SubProcess3 {
			get {
				return _subProcess3 ?? (_subProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess3",
					SchemaElementUId = new Guid("a36eaca1-c81e-4b08-b116-b1347e4762c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _adminRightMenuItemClick;
		public ProcessFlowElement AdminRightMenuItemClick {
			get {
				return _adminRightMenuItemClick ?? (_adminRightMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AdminRightMenuItemClick",
					SchemaElementUId = new Guid("c7f8ccc3-bdb5-4319-af46-8d7a249b29c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAdminRightMenuItemClick2;
		public ProcessScriptTask ScriptAdminRightMenuItemClick2 {
			get {
				return _scriptAdminRightMenuItemClick2 ?? (_scriptAdminRightMenuItemClick2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAdminRightMenuItemClick2",
					SchemaElementUId = new Guid("b7443b26-dc60-4d72-a6bb-74cb3a8d8b02"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAdminRightMenuItemClick2Execute,
				});
			}
		}

		private UserTaskAdminRightOpenWindowFlowElement _userTaskAdminRightOpenWindow;
		public UserTaskAdminRightOpenWindowFlowElement UserTaskAdminRightOpenWindow {
			get {
				return _userTaskAdminRightOpenWindow ?? (_userTaskAdminRightOpenWindow = new UserTaskAdminRightOpenWindowFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _subProcessAddSearchFolderMenuItemClick;
		public ProcessFlowElement SubProcessAddSearchFolderMenuItemClick {
			get {
				return _subProcessAddSearchFolderMenuItemClick ?? (_subProcessAddSearchFolderMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessAddSearchFolderMenuItemClick",
					SchemaElementUId = new Guid("57763886-6b82-49ed-ba97-1653b2fc1a17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addSearchFolderMenuItemClick;
		public ProcessFlowElement AddSearchFolderMenuItemClick {
			get {
				return _addSearchFolderMenuItemClick ?? (_addSearchFolderMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddSearchFolderMenuItemClick",
					SchemaElementUId = new Guid("65c6c34e-67f1-4588-a71d-bf1d1d3e1c5f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAddSearchFolderMenuItemClick;
		public ProcessScriptTask ScriptAddSearchFolderMenuItemClick {
			get {
				return _scriptAddSearchFolderMenuItemClick ?? (_scriptAddSearchFolderMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAddSearchFolderMenuItemClick",
					SchemaElementUId = new Guid("317f1bba-4367-4759-a955-ae37a5ebda2c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAddSearchFolderMenuItemClickExecute,
				});
			}
		}

		private UserTaskAddSearchFolderOpenWindowFlowElement _userTaskAddSearchFolderOpenWindow;
		public UserTaskAddSearchFolderOpenWindowFlowElement UserTaskAddSearchFolderOpenWindow {
			get {
				return _userTaskAddSearchFolderOpenWindow ?? (_userTaskAddSearchFolderOpenWindow = new UserTaskAddSearchFolderOpenWindowFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptPrepareAddSearchFolderWindowOpener;
		public ProcessScriptTask ScriptPrepareAddSearchFolderWindowOpener {
			get {
				return _scriptPrepareAddSearchFolderWindowOpener ?? (_scriptPrepareAddSearchFolderWindowOpener = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrepareAddSearchFolderWindowOpener",
					SchemaElementUId = new Guid("1ed6d5fe-5867-40d5-bfc2-f0bb25bbf2f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPrepareAddSearchFolderWindowOpenerExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessAddGeneralFolderMenuItemClick;
		public ProcessFlowElement SubProcessAddGeneralFolderMenuItemClick {
			get {
				return _subProcessAddGeneralFolderMenuItemClick ?? (_subProcessAddGeneralFolderMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessAddGeneralFolderMenuItemClick",
					SchemaElementUId = new Guid("612ce8dd-cd6f-4cbc-96f6-7d028a38d6dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addGeneralFolderMenuItemClick;
		public ProcessFlowElement AddGeneralFolderMenuItemClick {
			get {
				return _addGeneralFolderMenuItemClick ?? (_addGeneralFolderMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddGeneralFolderMenuItemClick",
					SchemaElementUId = new Guid("5f77193e-d1a6-42db-8741-9451e7c98807"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAddGeneralFolderMenuItemClick;
		public ProcessScriptTask ScriptAddGeneralFolderMenuItemClick {
			get {
				return _scriptAddGeneralFolderMenuItemClick ?? (_scriptAddGeneralFolderMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAddGeneralFolderMenuItemClick",
					SchemaElementUId = new Guid("3740380c-84d5-4a94-849b-806f9387f388"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAddGeneralFolderMenuItemClickExecute,
				});
			}
		}

		private ProcessScriptTask _scriptPrepareAddGeneralFolderWindowOpener;
		public ProcessScriptTask ScriptPrepareAddGeneralFolderWindowOpener {
			get {
				return _scriptPrepareAddGeneralFolderWindowOpener ?? (_scriptPrepareAddGeneralFolderWindowOpener = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrepareAddGeneralFolderWindowOpener",
					SchemaElementUId = new Guid("be40bd54-4041-412c-9384-a4afc3b9ab23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPrepareAddGeneralFolderWindowOpenerExecute,
				});
			}
		}

		private UserTaskAddGeneralFolderOpenWindowFlowElement _userTaskAddGeneralFolderOpenWindow;
		public UserTaskAddGeneralFolderOpenWindowFlowElement UserTaskAddGeneralFolderOpenWindow {
			get {
				return _userTaskAddGeneralFolderOpenWindow ?? (_userTaskAddGeneralFolderOpenWindow = new UserTaskAddGeneralFolderOpenWindowFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _subProcessEditMenuItemClick;
		public ProcessFlowElement SubProcessEditMenuItemClick {
			get {
				return _subProcessEditMenuItemClick ?? (_subProcessEditMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessEditMenuItemClick",
					SchemaElementUId = new Guid("de95c257-cb3a-4780-823c-8916c9f87fb5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _editMenuItemClick;
		public ProcessFlowElement EditMenuItemClick {
			get {
				return _editMenuItemClick ?? (_editMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EditMenuItemClick",
					SchemaElementUId = new Guid("bb5fa926-6eab-4345-a2e5-f57db3b51fb8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptEditMenuItemClick;
		public ProcessScriptTask ScriptEditMenuItemClick {
			get {
				return _scriptEditMenuItemClick ?? (_scriptEditMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptEditMenuItemClick",
					SchemaElementUId = new Guid("5b735056-cd06-40f7-bbdc-e2766f6e42da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptEditMenuItemClickExecute,
				});
			}
		}

		private UserTaskEditFolderOpenWindowFlowElement _userTaskEditFolderOpenWindow;
		public UserTaskEditFolderOpenWindowFlowElement UserTaskEditFolderOpenWindow {
			get {
				return _userTaskEditFolderOpenWindow ?? (_userTaskEditFolderOpenWindow = new UserTaskEditFolderOpenWindowFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _addSubEmailFolderMenuItemClickEventSubProcess;
		public ProcessFlowElement AddSubEmailFolderMenuItemClickEventSubProcess {
			get {
				return _addSubEmailFolderMenuItemClickEventSubProcess ?? (_addSubEmailFolderMenuItemClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AddSubEmailFolderMenuItemClickEventSubProcess",
					SchemaElementUId = new Guid("35cb30a9-9bfb-4651-b272-cfd370c4a3a8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addSubEmailFolderMenuItemClickStartMessage;
		public ProcessFlowElement AddSubEmailFolderMenuItemClickStartMessage {
			get {
				return _addSubEmailFolderMenuItemClickStartMessage ?? (_addSubEmailFolderMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddSubEmailFolderMenuItemClickStartMessage",
					SchemaElementUId = new Guid("a792b5a1-ca0f-4a49-88b4-33b6c7faa4d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addSubEmailFolderMenuItemClickScriptTask;
		public ProcessScriptTask AddSubEmailFolderMenuItemClickScriptTask {
			get {
				return _addSubEmailFolderMenuItemClickScriptTask ?? (_addSubEmailFolderMenuItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddSubEmailFolderMenuItemClickScriptTask",
					SchemaElementUId = new Guid("fe07fc28-9298-423c-a1e0-c682cda2eea8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddSubEmailFolderMenuItemClickScriptTaskExecute,
				});
			}
		}

		private AddSubEmailFolderUserTaskFlowElement _addSubEmailFolderUserTask;
		public AddSubEmailFolderUserTaskFlowElement AddSubEmailFolderUserTask {
			get {
				return _addSubEmailFolderUserTask ?? (_addSubEmailFolderUserTask = new AddSubEmailFolderUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _initializeEventSubProcess;
		public ProcessFlowElement InitializeEventSubProcess {
			get {
				return _initializeEventSubProcess ?? (_initializeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitializeEventSubProcess",
					SchemaElementUId = new Guid("c34616c9-37dd-476a-ac3d-968c884a65bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initialize;
		public ProcessFlowElement Initialize {
			get {
				return _initialize ?? (_initialize = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Initialize",
					SchemaElementUId = new Guid("012dfa4c-e543-44bd-abfd-f0828f1ff2ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInitialize;
		public ProcessScriptTask ScriptInitialize {
			get {
				return _scriptInitialize ?? (_scriptInitialize = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInitialize",
					SchemaElementUId = new Guid("a4568cf3-7a38-4050-8749-6514fcb6712a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitializeExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteSubProcess;
		public ProcessFlowElement PageLoadCompleteSubProcess {
			get {
				return _pageLoadCompleteSubProcess ?? (_pageLoadCompleteSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteSubProcess",
					SchemaElementUId = new Guid("3c5cf510-94ae-458e-9f0d-fac4626edf83"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadComplete;
		public ProcessScriptTask ScriptPageLoadComplete {
			get {
				return _scriptPageLoadComplete ?? (_scriptPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadComplete",
					SchemaElementUId = new Guid("20ca36b7-a82c-4fc8-a646-da0531fb57d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadComplete;
		public ProcessFlowElement PageLoadComplete {
			get {
				return _pageLoadComplete ?? (_pageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadComplete",
					SchemaElementUId = new Guid("656c3b3a-948f-49c3-96bb-8f2814b40359"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initSubProcess;
		public ProcessFlowElement InitSubProcess {
			get {
				return _initSubProcess ?? (_initSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitSubProcess",
					SchemaElementUId = new Guid("8f22a548-d6ab-4286-9bd6-2204076df9d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _init;
		public ProcessFlowElement Init {
			get {
				return _init ?? (_init = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Init",
					SchemaElementUId = new Guid("7c16b35b-a77d-4fc8-83c9-795e2cd0e73d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initScript;
		public ProcessScriptTask InitScript {
			get {
				return _initScript ?? (_initScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScript",
					SchemaElementUId = new Guid("819500cd-cad5-4a5f-b839-ba35e5ac2b28"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessRemoveMenuItemClick;
		public ProcessFlowElement SubProcessRemoveMenuItemClick {
			get {
				return _subProcessRemoveMenuItemClick ?? (_subProcessRemoveMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessRemoveMenuItemClick",
					SchemaElementUId = new Guid("8c4dd765-8e50-4da8-9d05-e24776dbc422"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _removeMenuItemClick;
		public ProcessFlowElement RemoveMenuItemClick {
			get {
				return _removeMenuItemClick ?? (_removeMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RemoveMenuItemClick",
					SchemaElementUId = new Guid("3feb751e-08ae-4ad2-8ab1-e80600f61a78"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptRemoveMenuItemClick;
		public ProcessScriptTask ScriptRemoveMenuItemClick {
			get {
				return _scriptRemoveMenuItemClick ?? (_scriptRemoveMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptRemoveMenuItemClick",
					SchemaElementUId = new Guid("2293c1e5-49f2-4d45-9907-8bc2106aa34e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptRemoveMenuItemClickExecute,
				});
			}
		}

		private UserMessageFlowElement _userMessage;
		public UserMessageFlowElement UserMessage {
			get {
				return _userMessage ?? (_userMessage = new UserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcessDeleteYesMessage;
		public ProcessFlowElement EventSubProcessDeleteYesMessage {
			get {
				return _eventSubProcessDeleteYesMessage ?? (_eventSubProcessDeleteYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDeleteYesMessage",
					SchemaElementUId = new Guid("1637cbaa-3d9f-4d92-ac5f-febb0fa8b521"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteYesMessage;
		public ProcessFlowElement DeleteYesMessage {
			get {
				return _deleteYesMessage ?? (_deleteYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteYesMessage",
					SchemaElementUId = new Guid("1cd729fa-cd46-4ebd-83a7-41680ff0825e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDeleteYesMessage;
		public ProcessScriptTask ScriptDeleteYesMessage {
			get {
				return _scriptDeleteYesMessage ?? (_scriptDeleteYesMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDeleteYesMessage",
					SchemaElementUId = new Guid("9a5f5233-a13f-40a2-aa6a-c3100b36f55e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteYesMessageExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDeleteNoMessage;
		public ProcessFlowElement EventSubProcessDeleteNoMessage {
			get {
				return _eventSubProcessDeleteNoMessage ?? (_eventSubProcessDeleteNoMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDeleteNoMessage",
					SchemaElementUId = new Guid("57b4e2ce-2ce9-4ef5-a16f-73fcfa23f001"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteNoMessage;
		public ProcessFlowElement DeleteNoMessage {
			get {
				return _deleteNoMessage ?? (_deleteNoMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteNoMessage",
					SchemaElementUId = new Guid("b8c56e8c-48bc-4776-87af-042947a70717"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDeleteNoMessage;
		public ProcessScriptTask ScriptDeleteNoMessage {
			get {
				return _scriptDeleteNoMessage ?? (_scriptDeleteNoMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDeleteNoMessage",
					SchemaElementUId = new Guid("5c891633-f17d-4d14-8b49-24d2010e8f6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteNoMessageExecute,
				});
			}
		}

		private ProcessFlowElement _abortDeleteRootFolderEventSubProcess;
		public ProcessFlowElement AbortDeleteRootFolderEventSubProcess {
			get {
				return _abortDeleteRootFolderEventSubProcess ?? (_abortDeleteRootFolderEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AbortDeleteRootFolderEventSubProcess",
					SchemaElementUId = new Guid("fd8cc239-63d2-4baa-9821-b00982d30637"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAbortDeleteRootFolder;
		public ProcessFlowElement StartMessageAbortDeleteRootFolder {
			get {
				return _startMessageAbortDeleteRootFolder ?? (_startMessageAbortDeleteRootFolder = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAbortDeleteRootFolder",
					SchemaElementUId = new Guid("fa09c88e-c5cc-4d82-a809-cb78724bf534"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAbortDeleteRootFolder;
		public ProcessScriptTask ScriptAbortDeleteRootFolder {
			get {
				return _scriptAbortDeleteRootFolder ?? (_scriptAbortDeleteRootFolder = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAbortDeleteRootFolder",
					SchemaElementUId = new Guid("66bc8d88-dd9a-4fb4-ab7f-79c523ffa08f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAbortDeleteRootFolderExecute,
				});
			}
		}

		private LocalizableString _deleteRecordMessage;
		public LocalizableString DeleteRecordMessage {
			get {
				return _deleteRecordMessage ?? (_deleteRecordMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteRecordMessage.Value"));
			}
		}

		private LocalizableString _warningMessage;
		public LocalizableString WarningMessage {
			get {
				return _warningMessage ?? (_warningMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WarningMessage.Value"));
			}
		}

		private LocalizableString _noDeleteRightsMessage;
		public LocalizableString NoDeleteRightsMessage {
			get {
				return _noDeleteRightsMessage ?? (_noDeleteRightsMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NoDeleteRightsMessage.Value"));
			}
		}

		private LocalizableString _warning;
		public LocalizableString Warning {
			get {
				return _warning ?? (_warning = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Warning.Value"));
			}
		}

		private LocalizableString _warningRootFolderMessage;
		public LocalizableString WarningRootFolderMessage {
			get {
				return _warningRootFolderMessage ?? (_warningRootFolderMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WarningRootFolderMessage.Value"));
			}
		}

		private LocalizableString _warningFolderNotEmptyMessage;
		public LocalizableString WarningFolderNotEmptyMessage {
			get {
				return _warningFolderNotEmptyMessage ?? (_warningFolderNotEmptyMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WarningFolderNotEmptyMessage.Value"));
			}
		}

		private LocalizableString _emailFolderRemoveMailBoxMenuItemCaption;
		public LocalizableString EmailFolderRemoveMailBoxMenuItemCaption {
			get {
				return _emailFolderRemoveMailBoxMenuItemCaption ?? (_emailFolderRemoveMailBoxMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EmailFolderRemoveMailBoxMenuItemCaption.Value"));
			}
		}

		private LocalizableString _removeFolderMenuItemCaption;
		public LocalizableString RemoveFolderMenuItemCaption {
			get {
				return _removeFolderMenuItemCaption ?? (_removeFolderMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RemoveFolderMenuItemCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2999.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2999 };
			FlowElements[PrepareOpenRightsPageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareOpenRightsPageScriptTask };
			FlowElements[ConfigureDuplicatesRightsMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ConfigureDuplicatesRightsMenuItemClickStartMessage };
			FlowElements[EventSubProcess5999.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5999 };
			FlowElements[StartDuplicatesSearchMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDuplicatesSearchMenuItemClickStartMessage };
			FlowElements[StartDuplicatesSearchMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDuplicatesSearchMenuItemClickScriptTask };
			FlowElements[EventSubProcess6999.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6999 };
			FlowElements[ConfigureDuplicatesMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ConfigureDuplicatesMenuItemClickScriptTask };
			FlowElements[ConfigureDuplicatesMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ConfigureDuplicatesMenuItemClickStartMessage };
			FlowElements[FolderGridNodesDropSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { FolderGridNodesDropSubProcess };
			FlowElements[FolderGridNodesDrop.SchemaElementUId] = new Collection<ProcessFlowElement> { FolderGridNodesDrop };
			FlowElements[FolderGridNodesDropScript.SchemaElementUId] = new Collection<ProcessFlowElement> { FolderGridNodesDropScript };
			FlowElements[SubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess3 };
			FlowElements[AdminRightMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { AdminRightMenuItemClick };
			FlowElements[ScriptAdminRightMenuItemClick2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAdminRightMenuItemClick2 };
			FlowElements[UserTaskAdminRightOpenWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskAdminRightOpenWindow };
			FlowElements[SubProcessAddSearchFolderMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessAddSearchFolderMenuItemClick };
			FlowElements[AddSearchFolderMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSearchFolderMenuItemClick };
			FlowElements[ScriptAddSearchFolderMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAddSearchFolderMenuItemClick };
			FlowElements[UserTaskAddSearchFolderOpenWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskAddSearchFolderOpenWindow };
			FlowElements[ScriptPrepareAddSearchFolderWindowOpener.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepareAddSearchFolderWindowOpener };
			FlowElements[SubProcessAddGeneralFolderMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessAddGeneralFolderMenuItemClick };
			FlowElements[AddGeneralFolderMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { AddGeneralFolderMenuItemClick };
			FlowElements[ScriptAddGeneralFolderMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAddGeneralFolderMenuItemClick };
			FlowElements[ScriptPrepareAddGeneralFolderWindowOpener.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepareAddGeneralFolderWindowOpener };
			FlowElements[UserTaskAddGeneralFolderOpenWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskAddGeneralFolderOpenWindow };
			FlowElements[SubProcessEditMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessEditMenuItemClick };
			FlowElements[EditMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EditMenuItemClick };
			FlowElements[ScriptEditMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptEditMenuItemClick };
			FlowElements[UserTaskEditFolderOpenWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskEditFolderOpenWindow };
			FlowElements[AddSubEmailFolderMenuItemClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSubEmailFolderMenuItemClickEventSubProcess };
			FlowElements[AddSubEmailFolderMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSubEmailFolderMenuItemClickStartMessage };
			FlowElements[AddSubEmailFolderMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSubEmailFolderMenuItemClickScriptTask };
			FlowElements[AddSubEmailFolderUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSubEmailFolderUserTask };
			FlowElements[InitializeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitializeEventSubProcess };
			FlowElements[Initialize.SchemaElementUId] = new Collection<ProcessFlowElement> { Initialize };
			FlowElements[ScriptInitialize.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInitialize };
			FlowElements[PageLoadCompleteSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteSubProcess };
			FlowElements[ScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadComplete };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[InitSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitSubProcess };
			FlowElements[Init.SchemaElementUId] = new Collection<ProcessFlowElement> { Init };
			FlowElements[InitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScript };
			FlowElements[SubProcessRemoveMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessRemoveMenuItemClick };
			FlowElements[RemoveMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { RemoveMenuItemClick };
			FlowElements[ScriptRemoveMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptRemoveMenuItemClick };
			FlowElements[UserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserMessage };
			FlowElements[EventSubProcessDeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDeleteYesMessage };
			FlowElements[DeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesMessage };
			FlowElements[ScriptDeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteYesMessage };
			FlowElements[EventSubProcessDeleteNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDeleteNoMessage };
			FlowElements[DeleteNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteNoMessage };
			FlowElements[ScriptDeleteNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteNoMessage };
			FlowElements[AbortDeleteRootFolderEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AbortDeleteRootFolderEventSubProcess };
			FlowElements[StartMessageAbortDeleteRootFolder.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAbortDeleteRootFolder };
			FlowElements[ScriptAbortDeleteRootFolder.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAbortDeleteRootFolder };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2999":
						break;
					case "PrepareOpenRightsPageScriptTask":
						break;
					case "ConfigureDuplicatesRightsMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("PrepareOpenRightsPageScriptTask");
						break;
					case "EventSubProcess5999":
						break;
					case "StartDuplicatesSearchMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("StartDuplicatesSearchMenuItemClickScriptTask");
						break;
					case "StartDuplicatesSearchMenuItemClickScriptTask":
						break;
					case "EventSubProcess6999":
						break;
					case "ConfigureDuplicatesMenuItemClickScriptTask":
						break;
					case "ConfigureDuplicatesMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("ConfigureDuplicatesMenuItemClickScriptTask");
						break;
					case "FolderGridNodesDropSubProcess":
						break;
					case "FolderGridNodesDrop":
						e.Context.QueueTasks.Enqueue("FolderGridNodesDropScript");
						break;
					case "FolderGridNodesDropScript":
						break;
					case "SubProcess3":
						break;
					case "AdminRightMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptAdminRightMenuItemClick2");
						break;
					case "ScriptAdminRightMenuItemClick2":
						e.Context.QueueTasks.Enqueue("UserTaskAdminRightOpenWindow");
						break;
					case "UserTaskAdminRightOpenWindow":
						break;
					case "SubProcessAddSearchFolderMenuItemClick":
						break;
					case "AddSearchFolderMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptAddSearchFolderMenuItemClick");
						break;
					case "ScriptAddSearchFolderMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptPrepareAddSearchFolderWindowOpener");
						break;
					case "UserTaskAddSearchFolderOpenWindow":
						break;
					case "ScriptPrepareAddSearchFolderWindowOpener":
						e.Context.QueueTasks.Enqueue("UserTaskAddSearchFolderOpenWindow");
						break;
					case "SubProcessAddGeneralFolderMenuItemClick":
						break;
					case "AddGeneralFolderMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptAddGeneralFolderMenuItemClick");
						break;
					case "ScriptAddGeneralFolderMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptPrepareAddGeneralFolderWindowOpener");
						break;
					case "ScriptPrepareAddGeneralFolderWindowOpener":
						e.Context.QueueTasks.Enqueue("UserTaskAddGeneralFolderOpenWindow");
						break;
					case "UserTaskAddGeneralFolderOpenWindow":
						break;
					case "SubProcessEditMenuItemClick":
						break;
					case "EditMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptEditMenuItemClick");
						break;
					case "ScriptEditMenuItemClick":
						e.Context.QueueTasks.Enqueue("UserTaskEditFolderOpenWindow");
						break;
					case "UserTaskEditFolderOpenWindow":
						break;
					case "AddSubEmailFolderMenuItemClickEventSubProcess":
						break;
					case "AddSubEmailFolderMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("AddSubEmailFolderMenuItemClickScriptTask");
						break;
					case "AddSubEmailFolderMenuItemClickScriptTask":
						e.Context.QueueTasks.Enqueue("AddSubEmailFolderUserTask");
						break;
					case "AddSubEmailFolderUserTask":
						break;
					case "InitializeEventSubProcess":
						break;
					case "Initialize":
						e.Context.QueueTasks.Enqueue("ScriptInitialize");
						break;
					case "ScriptInitialize":
						break;
					case "PageLoadCompleteSubProcess":
						break;
					case "ScriptPageLoadComplete":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadComplete");
						break;
					case "InitSubProcess":
						break;
					case "Init":
						e.Context.QueueTasks.Enqueue("InitScript");
						break;
					case "InitScript":
						break;
					case "SubProcessRemoveMenuItemClick":
						break;
					case "RemoveMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptRemoveMenuItemClick");
						break;
					case "ScriptRemoveMenuItemClick":
						e.Context.QueueTasks.Enqueue("UserMessage");
						break;
					case "UserMessage":
						break;
					case "EventSubProcessDeleteYesMessage":
						break;
					case "DeleteYesMessage":
						e.Context.QueueTasks.Enqueue("ScriptDeleteYesMessage");
						break;
					case "ScriptDeleteYesMessage":
						break;
					case "EventSubProcessDeleteNoMessage":
						break;
					case "DeleteNoMessage":
						e.Context.QueueTasks.Enqueue("ScriptDeleteNoMessage");
						break;
					case "ScriptDeleteNoMessage":
						break;
					case "AbortDeleteRootFolderEventSubProcess":
						break;
					case "StartMessageAbortDeleteRootFolder":
						e.Context.QueueTasks.Enqueue("ScriptAbortDeleteRootFolder");
						break;
					case "ScriptAbortDeleteRootFolder":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ConfigureDuplicatesRightsMenuItemClickStartMessage");
			ActivatedEventElements.Add("StartDuplicatesSearchMenuItemClickStartMessage");
			ActivatedEventElements.Add("ConfigureDuplicatesMenuItemClickStartMessage");
			ActivatedEventElements.Add("FolderGridNodesDrop");
			ActivatedEventElements.Add("AdminRightMenuItemClick");
			ActivatedEventElements.Add("AddSearchFolderMenuItemClick");
			ActivatedEventElements.Add("AddGeneralFolderMenuItemClick");
			ActivatedEventElements.Add("EditMenuItemClick");
			ActivatedEventElements.Add("AddSubEmailFolderMenuItemClickStartMessage");
			ActivatedEventElements.Add("Initialize");
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("Init");
			ActivatedEventElements.Add("RemoveMenuItemClick");
			ActivatedEventElements.Add("DeleteYesMessage");
			ActivatedEventElements.Add("DeleteNoMessage");
			ActivatedEventElements.Add("StartMessageAbortDeleteRootFolder");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2999":
					context.QueueTasks.Dequeue();
					break;
				case "PrepareOpenRightsPageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareOpenRightsPageScriptTask";
					result = PrepareOpenRightsPageScriptTask.Execute(context, PrepareOpenRightsPageScriptTaskExecute);
					break;
				case "ConfigureDuplicatesRightsMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ConfigureDuplicatesRightsMenuItemClickStartMessage";
					result = ConfigureDuplicatesRightsMenuItemClickStartMessage.Execute(context);
					break;
				case "EventSubProcess5999":
					context.QueueTasks.Dequeue();
					break;
				case "StartDuplicatesSearchMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDuplicatesSearchMenuItemClickStartMessage";
					result = StartDuplicatesSearchMenuItemClickStartMessage.Execute(context);
					break;
				case "StartDuplicatesSearchMenuItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDuplicatesSearchMenuItemClickScriptTask";
					result = StartDuplicatesSearchMenuItemClickScriptTask.Execute(context, StartDuplicatesSearchMenuItemClickScriptTaskExecute);
					break;
				case "EventSubProcess6999":
					context.QueueTasks.Dequeue();
					break;
				case "ConfigureDuplicatesMenuItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ConfigureDuplicatesMenuItemClickScriptTask";
					result = ConfigureDuplicatesMenuItemClickScriptTask.Execute(context, ConfigureDuplicatesMenuItemClickScriptTaskExecute);
					break;
				case "ConfigureDuplicatesMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ConfigureDuplicatesMenuItemClickStartMessage";
					result = ConfigureDuplicatesMenuItemClickStartMessage.Execute(context);
					break;
				case "FolderGridNodesDropSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "FolderGridNodesDrop":
					context.QueueTasks.Dequeue();
					context.SenderName = "FolderGridNodesDrop";
					result = FolderGridNodesDrop.Execute(context);
					break;
				case "FolderGridNodesDropScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "FolderGridNodesDropScript";
					result = FolderGridNodesDropScript.Execute(context, FolderGridNodesDropScriptExecute);
					break;
				case "SubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "AdminRightMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "AdminRightMenuItemClick";
					result = AdminRightMenuItemClick.Execute(context);
					break;
				case "ScriptAdminRightMenuItemClick2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAdminRightMenuItemClick2";
					result = ScriptAdminRightMenuItemClick2.Execute(context, ScriptAdminRightMenuItemClick2Execute);
					break;
				case "UserTaskAdminRightOpenWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskAdminRightOpenWindow";
					result = UserTaskAdminRightOpenWindow.Execute(context);
					break;
				case "SubProcessAddSearchFolderMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "AddSearchFolderMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddSearchFolderMenuItemClick";
					result = AddSearchFolderMenuItemClick.Execute(context);
					break;
				case "ScriptAddSearchFolderMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAddSearchFolderMenuItemClick";
					result = ScriptAddSearchFolderMenuItemClick.Execute(context, ScriptAddSearchFolderMenuItemClickExecute);
					break;
				case "UserTaskAddSearchFolderOpenWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskAddSearchFolderOpenWindow";
					result = UserTaskAddSearchFolderOpenWindow.Execute(context);
					break;
				case "ScriptPrepareAddSearchFolderWindowOpener":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPrepareAddSearchFolderWindowOpener";
					result = ScriptPrepareAddSearchFolderWindowOpener.Execute(context, ScriptPrepareAddSearchFolderWindowOpenerExecute);
					break;
				case "SubProcessAddGeneralFolderMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "AddGeneralFolderMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddGeneralFolderMenuItemClick";
					result = AddGeneralFolderMenuItemClick.Execute(context);
					break;
				case "ScriptAddGeneralFolderMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAddGeneralFolderMenuItemClick";
					result = ScriptAddGeneralFolderMenuItemClick.Execute(context, ScriptAddGeneralFolderMenuItemClickExecute);
					break;
				case "ScriptPrepareAddGeneralFolderWindowOpener":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPrepareAddGeneralFolderWindowOpener";
					result = ScriptPrepareAddGeneralFolderWindowOpener.Execute(context, ScriptPrepareAddGeneralFolderWindowOpenerExecute);
					break;
				case "UserTaskAddGeneralFolderOpenWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskAddGeneralFolderOpenWindow";
					result = UserTaskAddGeneralFolderOpenWindow.Execute(context);
					break;
				case "SubProcessEditMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "EditMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditMenuItemClick";
					result = EditMenuItemClick.Execute(context);
					break;
				case "ScriptEditMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptEditMenuItemClick";
					result = ScriptEditMenuItemClick.Execute(context, ScriptEditMenuItemClickExecute);
					break;
				case "UserTaskEditFolderOpenWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskEditFolderOpenWindow";
					result = UserTaskEditFolderOpenWindow.Execute(context);
					break;
				case "AddSubEmailFolderMenuItemClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AddSubEmailFolderMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddSubEmailFolderMenuItemClickStartMessage";
					result = AddSubEmailFolderMenuItemClickStartMessage.Execute(context);
					break;
				case "AddSubEmailFolderMenuItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddSubEmailFolderMenuItemClickScriptTask";
					result = AddSubEmailFolderMenuItemClickScriptTask.Execute(context, AddSubEmailFolderMenuItemClickScriptTaskExecute);
					break;
				case "AddSubEmailFolderUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddSubEmailFolderUserTask";
					result = AddSubEmailFolderUserTask.Execute(context);
					break;
				case "InitializeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "Initialize":
					context.QueueTasks.Dequeue();
					context.SenderName = "Initialize";
					result = Initialize.Execute(context);
					break;
				case "ScriptInitialize":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInitialize";
					result = ScriptInitialize.Execute(context, ScriptInitializeExecute);
					break;
				case "PageLoadCompleteSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadComplete";
					result = ScriptPageLoadComplete.Execute(context, ScriptPageLoadCompleteExecute);
					break;
				case "PageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete";
					result = PageLoadComplete.Execute(context);
					break;
				case "InitSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "Init":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init";
					result = Init.Execute(context);
					break;
				case "InitScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScript";
					result = InitScript.Execute(context, InitScriptExecute);
					break;
				case "SubProcessRemoveMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "RemoveMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemoveMenuItemClick";
					result = RemoveMenuItemClick.Execute(context);
					break;
				case "ScriptRemoveMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptRemoveMenuItemClick";
					result = ScriptRemoveMenuItemClick.Execute(context, ScriptRemoveMenuItemClickExecute);
					break;
				case "UserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserMessage";
					result = UserMessage.Execute(context);
					break;
				case "EventSubProcessDeleteYesMessage":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteYesMessage";
					result = DeleteYesMessage.Execute(context);
					break;
				case "ScriptDeleteYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDeleteYesMessage";
					result = ScriptDeleteYesMessage.Execute(context, ScriptDeleteYesMessageExecute);
					break;
				case "EventSubProcessDeleteNoMessage":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteNoMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteNoMessage";
					result = DeleteNoMessage.Execute(context);
					break;
				case "ScriptDeleteNoMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDeleteNoMessage";
					result = ScriptDeleteNoMessage.Execute(context, ScriptDeleteNoMessageExecute);
					break;
				case "AbortDeleteRootFolderEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAbortDeleteRootFolder":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAbortDeleteRootFolder";
					result = StartMessageAbortDeleteRootFolder.Execute(context);
					break;
				case "ScriptAbortDeleteRootFolder":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAbortDeleteRootFolder";
					result = ScriptAbortDeleteRootFolder.Execute(context, ScriptAbortDeleteRootFolderExecute);
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
				case "ProcessSchemaParameter1":
					ProcessSchemaParameter1 = reader.GetSerializableObjectValue();
				break;
				case "DefaultFolderId":
					DefaultFolderId = reader.GetValue<System.Guid>();
				break;
				case "CacheItemName":
					CacheItemName = reader.GetValue<System.String>();
				break;
				case "IsAdministratedByRecords":
					IsAdministratedByRecords = reader.GetValue<System.Boolean>();
				break;
				case "IsMultiFolder":
					IsMultiFolder = reader.GetValue<System.Boolean>();
				break;
				case "DuplicatesFolderId":
					DuplicatesFolderId = reader.GetValue<System.Guid>();
				break;
				case "DropTags":
					DropTags = reader.GetValue<System.String>();
				break;
				case "ListenerPageProcessUId":
					ListenerPageProcessUId = reader.GetValue<System.String>();
				break;
				case "DefValuesId":
					DefValuesId = reader.GetValue<System.Guid>();
				break;
				case "EditPageUId":
					EditPageUId = reader.GetValue<System.Guid>();
				break;
				case "EntitySchemaManagerName":
					EntitySchemaManagerName = reader.GetValue<System.String>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool PrepareOpenRightsPageScriptTaskExecute(ProcessExecutingContext context) {
			Page.ThrowEvent("AdminRightMenuItemClick");
			return true;
		}

		public virtual bool StartDuplicatesSearchMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			ListenerThrowEvent(ListenerPageProcessUId, "StartDuplicatesSearch");
			return true;
		}

		public virtual bool ConfigureDuplicatesMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			ListenerThrowEvent(ListenerPageProcessUId, "ConfigureSearch");
			return true;
		}

		public virtual bool FolderGridNodesDropScriptExecute(ProcessExecutingContext context) {
			var eventArgs = (Dictionary<string, object>)context.ThrowEventArgs;
			var rows = Json.Deserialize((string)eventArgs["rows"]) as JArray;
			
			if (rows.Count <= 0) return false;
			
			var targetRow = Json.Deserialize((string)eventArgs["targetRow"]) as JObject;
			var targetRowId = new Guid(targetRow.Value<string>("Id"));
			var schemaName = Page.DataSource.Schema.Name.Replace("Folder", String.Empty);
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as EntitySchemaManager;
			if (IsMultiFolder) {
				var folderEntrySchema = entitySchemaManager.GetInstanceByName(String.Concat(schemaName, "InFolder"));
				var currentUserContactId = Page.UserConnection.CurrentUser.ContactId;
				var now = DateTime.Now;
				
			    var entityParameterId = new QueryParameter("entityRef", targetRowId);
			    var parameterId = new QueryParameter(String.Concat(schemaName, "Id"), Guid.Empty);
			    var refEntityColumnValueName = folderEntrySchema.Columns.GetByName("Folder").ColumnValueName;
			    var refSchemaColumnName = schemaName != "VwSysProcess" ? String.Concat(schemaName, "Id") : "VwSysProcess";
				Select existingFoldersSelect = new Select(Page.UserConnection).Column(Func.Count("Id")).As("RecordsCount").
			      From(folderEntrySchema.Name).
			     Where(refEntityColumnValueName).IsEqual(entityParameterId).
			       And(refSchemaColumnName).IsEqual(parameterId) as Select;
			
			    foreach (var row in rows.Children()) {
					var recordId = new Guid(row.Value<string>("Id"));
			        parameterId.Value = recordId;
			        using (var dbExecutor = UserConnection.EnsureDBConnection())  {
			            using (IDataReader dataReader = existingFoldersSelect.ExecuteReader(dbExecutor)) {
			                dataReader.Read();
			                if (Page.UserConnection.DBTypeConverter.DBValueToInt(dataReader["RecordsCount"]) > 0)
			                   continue;
			            }
			        }
					var folderEntryEntity = folderEntrySchema.CreateEntity(UserConnection);		
					folderEntryEntity.SetDefColumnValues();
					folderEntryEntity.SetColumnValue(folderEntrySchema.PrimaryColumn.Name, Guid.NewGuid());
					folderEntryEntity.SetColumnValue("CreatedOn", now);
					folderEntryEntity.SetColumnValue("CreatedById", currentUserContactId);
					folderEntryEntity.SetColumnValue("ModifiedOn", now);
					folderEntryEntity.SetColumnValue("ModifiedById", currentUserContactId);
					folderEntryEntity.SetColumnValue("FolderId", targetRowId);
					folderEntryEntity.SetColumnValue(refSchemaColumnName, recordId);
					folderEntryEntity.Save();
				}
			} else {
				var moduleEntitySchema = entitySchemaManager.GetInstanceByName(schemaName);
				var folderColumnName = string.Empty;
				foreach (var column in moduleEntitySchema.Columns) {
					if (column.ReferenceSchemaUId == Page.DataSource.Schema.UId) {
						folderColumnName = column.Name;
						break;
					}
				}
				if (folderColumnName.Length > 0) {
					folderColumnName = String.Concat(folderColumnName,"Id");
				}
				foreach (var row in rows.Children()) {
					var recordId = new Guid(row.Value<string>("Id"));
					var moduleEntity = moduleEntitySchema.CreateEntity(UserConnection);
					if (moduleEntity.FetchFromDB(recordId)) {
						moduleEntity.SetColumnValue(folderColumnName, targetRowId);
						moduleEntity.Save();
					}
				}
			}
			var process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
				process.ThrowEvent(process.InternalContext, "RefreshDetails");//"FolderActiveRowChanged");
			return true;
		}

		public virtual bool ScriptAdminRightMenuItemClick2Execute(ProcessExecutingContext context) {
			PrepareAdminRightWindowOpener();
			return true;
		}

		public virtual bool ScriptAddSearchFolderMenuItemClickExecute(ProcessExecutingContext context) {
			var manager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(manager, "FolderType");
			var primaryColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName()).Name; 
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", "Search"));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count == 0) {
				return true;
			}
			Guid folderTypeId = entities[0].GetTypedColumnValue<Guid>(primaryColumnName);
			DefValuesId = AddFolder(folderTypeId, new Guid(Convert.ToString(Page.TreeGrid.SelectedNodes[0].Values["Id"])));
			return true;
		}

		public virtual bool ScriptPrepareAddSearchFolderWindowOpenerExecute(ProcessExecutingContext context) {
			PrepareAddSearchFolderWondowOpener();
			return true;
		}

		public virtual bool ScriptAddGeneralFolderMenuItemClickExecute(ProcessExecutingContext context) {
			var manager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(manager, "FolderType");
			var primaryColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName()).Name; 
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", "General"));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count == 0) {
				return true;
			}
			Guid folderTypeId = entities[0].GetTypedColumnValue<Guid>(primaryColumnName);
			DefValuesId = AddFolder(folderTypeId, new Guid(Convert.ToString(Page.TreeGrid.SelectedNodes[0].Values["Id"])));
			return true;
		}

		public virtual bool ScriptPrepareAddGeneralFolderWindowOpenerExecute(ProcessExecutingContext context) {
			PrepareAddGeneralFolderWondowOpener();
			return true;
		}

		public virtual bool ScriptEditMenuItemClickExecute(ProcessExecutingContext context) {
			PrepareEditFolderWindowOpener();
			return true;
			/*var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			var paramId = Guid.NewGuid().ToString();
			Dictionary<string,object> param = new Dictionary<string,object>();
			param.Add("treeGridId", Page.TreeGrid.ClientID);
			param.Add("recordId",Page.TreeGrid.SelectedNodes[0].Values[Page.DataSource.Schema.PrimaryColumn.Name]);
			param.Add("entitySchemaUId", EntitySchemaUId);
			Page.UserConnection.UserContext.Add(paramId,param);
			Page.TempUserContext.Add(paramId);
			Page.AddScript("var url = 'ht tp://' + window.location.host + '/ViewPage.aspx?id=' + '" + EditPageUId +
			"' + String.fromCharCode(38) + 'pageUserContextUId=' + '" + paramId + 
			"' + String.fromCharCode(38) + '" + 
			"';var edit = window.open(url, '', 'width=' + '" + editPageSchema.Width + "' + ',height=' + '" + editPageSchema.Height + "'); edit.DataSource = " + Page.DataSource.ClientID + ";" );
			return true;
			*/
		}

		public virtual bool AddSubEmailFolderMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "FolderType");
			entitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", "SubEmail"));
			Select select = entitySchemaQuery.GetSelectQuery(UserConnection);
			Guid folderTypeId = select.ExecuteScalar<Guid>();
			if (folderTypeId.IsEmpty()) {
				return true;
			}
			
			DefValuesId = AddFolder(folderTypeId, new Guid(Convert.ToString(Page.TreeGrid.SelectedNodes[0].Values["Id"])));
			
			
			// TODO: make a method:
			var recordId = Guid.Empty;
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			AddSubEmailFolderUserTask.OpenerInstanceId = InstanceUId;
			AddSubEmailFolderUserTask.UseCurrentActivePage = true;
			AddSubEmailFolderUserTask.PageUId = EditPageUId;
			var parameters =  
			      new Dictionary<string, string> {
			            {"recordId", recordId.ToString()},
			            {"entitySchemaUId", EntitySchemaUId.ToString()},
			            {"treeGridId", Page.TreeGrid.ClientID}
			      };
			if(DefValuesId != null && !DefValuesId.IsEmpty()) {
				parameters.Add("defValuesId", DefValuesId.ToString());
			}
			AddSubEmailFolderUserTask.PageParameters = parameters;
			AddSubEmailFolderUserTask.Centered = true;
			AddSubEmailFolderUserTask.CloseOpenerOnLoad = false;
			
			return true;
		}

		public virtual bool ScriptInitializeExecute(ProcessExecutingContext context) {
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			var dataSource = Page.DataSource;
			if (dataSource.Schema == null) {
				dataSource.SchemaUId = EntitySchemaUId;
			}
			dataSource.PageRowsCount = -1;
			EntityDataSourceUtilities.InitializeAutoDefStructure(dataSource);
			DuplicatesFolderId = GetDuplicatesFolderId();
			Page.AdminRightMenuItem.Enabled = IsAdministratedByRecords;
			Page.AdminRightMenuItem.Hidden = !IsAdministratedByRecords;
			Page.ConfigureDuplicatesMenuItem.Hidden = DuplicatesFolderId == Guid.Empty;
			Page.StartDuplicatesSearchMenuItem.Hidden = DuplicatesFolderId == Guid.Empty;
			var folderTypeColumn = dataSource.CurrentStructure.Columns.FindByName("FolderType");
			folderTypeColumn.IsAlwaysSelect = true;
			var currentStructure = dataSource.CurrentStructure;
			var orderColunmn = dataSource.CurrentStructure.AddColumnByPath("FolderType.Order");
			orderColunmn.IsAlwaysSelect = true;
			foreach (var column in dataSource.CurrentStructure.Columns) {	
				column.IsVisible = column.Name.Equals("Name");
				if(column.Name.Equals("FolderType_Order")) {
					column.OrderPosition = 1;
					column.OrderDirection = OrderDirection.Ascending;
				}
				if(column.Name.Equals(dataSource.Schema.PrimaryDisplayColumn.Name)) {		
					column.OrderPosition = 2;
					column.OrderDirection = OrderDirection.Ascending;
				}
			}
			if (!IsMultiFolder) {
				Page.AddSearchFolderMenuItem.Hidden = true;
			}
			dataSource.LoadRows();
			return true;
		}

		public virtual bool ScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			Page.TreeGrid.ShowSummariesMenu = false;
			Page.TreeGrid.ShowAutoWidthMenu = false;
			Page.TreeGrid.ShowMultiLineMenu = false;
			Page.TreeGrid.QuickViewMode = TreeGridQuickViewMode.None;
			
			Page.TreeGrid.StripeRows = false;
			Page.TreeGrid.HideRowBorders = true;
			Page.DataSource.EnableServerActiveRow = true;
			Page.DataSource.PageRowsCount = -1;
			IsAdministratedByRecords = false;
			if (!EntitySchemaUId.Equals(Guid.Empty) && Page.DataSource.Schema == null) {
				Page.DataSource.Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			}
			if (Page.DataSource.Schema != null) {
				IsAdministratedByRecords = Page.DataSource.Schema.AdministratedByRecords;
				EditPageUId = new Guid ("0622ef1c-1b6b-477b-9443-bd08b8e57236");
				Page.TreeGrid.HideHeaders = true;	
			}
			
			string scriptBody = "";
			foreach (var menuItem in Page.TreeGrid.Menu){	
				if(menuItem.ClientID == Page.TreeGrid.Menu[0].ClientID){
					scriptBody += @" "+menuItem.ClientID+".setVisible(true); ";
				} else {
					scriptBody += @" "+menuItem.ClientID+".setVisible(false); ";
				}
				
			}
			string rowChangedFunc = @"{0}.on('selectionchange', function(s, e) {{
				{1}
			}}, this);";
			
			// Row changed in week grid
			Page.AddScript(String.Format(rowChangedFunc, Page.TreeGrid.ClientID, scriptBody));
			
			return true;
		}

		public virtual bool InitScriptExecute(ProcessExecutingContext context) {
			Page.TreeGrid.GetRowConfigHandler = GetFolderRowConfig;
			Page.DataSource.BeforeRemoveRow += delegate(object sender, DataSourceEventArgs e) {
				var prcListenersColumnName = UserConnection.IProcessEngine.ProcessListenersColumnName;
				var structure = Page.DataSource.CurrentStructure;
				var prcListenersColumn = structure.Columns.FindByName(prcListenersColumnName);
				if (prcListenersColumn == null) {
					var column = structure.AddColumnByPath(prcListenersColumnName);
					column.IsVisible = false;
					column.IsAlwaysSelect = true;
				} else {
					prcListenersColumn.IsVisible = false;
					prcListenersColumn.IsAlwaysSelect = true;
				}
			};
			Page.DataSource.Loaded += Page.TreeGrid.DataLoaded;
			Page.DataSource.Loaded += delegate(object sender, DataSourceEventArgs e) {
				context.ThrowEventArgs = e;
				ThrowEvent(context, "DataSourceLoadRows");
			};
			Page.DataSource.AjaxEvents.ActiveRowChanged.Event += (sender, e) => {
				BaseActiveRowChangedHandler();
			};
			Page.DataSource.LoadRowsResponseRegistered += (sender, e) => {
				BaseLoadRowsResponseRegisteredHandler(sender, e);
			};
			Page.DataSource.PrepareFilters += delegate(object sender, DataSourceEventArgs e) {
				var userId = UserConnection.CurrentUser.Id;
				var contactId = UserConnection.CurrentUser.ContactId;
				var demoUsers = new Guid[] {
					new Guid("1B4B9325-66CC-DF11-9B2A-001D60E938C6"),
					new Guid("E19B3E68-F36B-1410-9693-20CF308CCEC3"),
					new Guid("64508C35-BC4B-E011-8617-00155D043204")
				};
				if (!demoUsers.Contains(userId)) {
					return;
				}
				var dataSource = Page.DataSource;
				var structure = dataSource.CurrentStructure;
				var demoFiltersName = "DemoFilters";
				var demoFilters = dataSource.FindFiltersGroupByName(demoFiltersName);
				if (demoFilters != null) {
					structure.Filters.Remove(demoFilters);
				}
				demoFilters = structure.CreateFiltersGroup(demoFiltersName, LogicalOperationStrict.Or);
				demoFilters.Add(structure.CreateFilterWithParameters(dataSource.Schema, FilterComparisonType.Equal, "CreatedBy", contactId));
				demoFilters.Add(structure.CreateFilterWithParameters(dataSource.Schema, FilterComparisonType.Equal, "CreatedBy", new Guid("22C5540C-D9B1-49EF-8EB7-72419B78E57C")));
				demoFilters.Add(structure.CreateIsNullFilter(dataSource.Schema, "CreatedBy"));
				structure.Filters.Add(demoFilters);
			};
			ComponentAjaxEvent OnFolderGridNodesDrop = Page.TreeGrid.AjaxEvents.NodesDrop;
			OnFolderGridNodesDrop.SignalName = "FolderGridNodesDrop";
			AddDragDropEventParams(OnFolderGridNodesDrop);
			return true;
		}

		public virtual bool ScriptRemoveMenuItemClickExecute(ProcessExecutingContext context) {
			UserMessage.Page = Page;
			UserMessage.MessageText = DeleteRecordMessage;
			UserMessage.Icon = "QUESTION";
			UserMessage.Buttons = "YESNO";
			UserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "DeleteYesMessage"},
				{"no", "DeleteNoMessage"},
			};
			return true;
		}

		public virtual bool ScriptDeleteYesMessageExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count > 0) {
				string primaryRecordValue;
				var dataSource = Page.DataSource;
				foreach (var node in selectedNodes) {
					primaryRecordValue = node.Values[Page.DataSource.Schema.PrimaryColumn.Name].ToString();
					var isRootFolder = !node.Values.ContainsKey(Page.DataSource.Schema.HierarchyColumn.ColumnValueName);
					if (isRootFolder) {
						Page.ThrowEvent("AbortDeleteRootFolder");
						break;
					}
					var rightSchema = Page.DataSource.Schema;
					var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
					var entitySchema = Page.DataSource.Schema;
					string schemaName = entitySchema.Name;
					var rightLevel = dbSecurityEngine.GetEntitySchemaRecordRightLevel(schemaName, new Guid(primaryRecordValue));
					var changeDelete = (rightLevel & Terrasoft.Core.DB.SchemaRecordRightLevels.CanChangeDeleteRight) == Terrasoft.Core.DB.SchemaRecordRightLevels.CanChangeDeleteRight;
					var delete = (rightLevel & Terrasoft.Core.DB.SchemaRecordRightLevels.CanDelete) == Terrasoft.Core.DB.SchemaRecordRightLevels.CanDelete;
					if (changeDelete || delete) {
						var folderId = new Guid(primaryRecordValue);
						var needTryDelete = true;
						
						if (!IsMultiFolder) {
							var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
							var moduleEntitySchemaName = dataSource.Schema.Name.Replace("Folder", string.Empty);
							var moduleEntitySchema = entitySchemaManager.GetInstanceByName(moduleEntitySchemaName);
							var folderColumnName = string.Empty;
							foreach (var column in moduleEntitySchema.Columns) {
								if (column.ReferenceSchemaUId == Page.DataSource.Schema.UId) {
									folderColumnName = column.Name;
									break;
								}
							}								
							var moduleEntitySchemaQuery = new EntitySchemaQuery(moduleEntitySchema);
							moduleEntitySchemaQuery.AddColumn("Id");							
							var folderIdFilter = moduleEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, folderColumnName, folderId);
							moduleEntitySchemaQuery.Filters.Add(folderIdFilter);	
							var moduleEntities = moduleEntitySchemaQuery.GetEntityCollection(UserConnection);
							if (moduleEntities.Count > 0) {
								needTryDelete = false;					
								var messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;								
								if (messagePanel != null) {
									messagePanel.AddMessage(Warning, WarningFolderNotEmptyMessage);
								}
							}
						}
						
						if (needTryDelete) {
							try {							
								dataSource.Remove(folderId);
							}
							catch (Exception) {
								var messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;								
								if (messagePanel != null) {
									messagePanel.AddMessage(Warning, WarningMessage);
								}
							}
						}
					} 
					else {
						MessagePanel messagePanel = ControlUtilities.FindControl(
							Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
						if (messagePanel != null) {
							messagePanel.AddMessage(Warning, NoDeleteRightsMessage);
						}
					}	
				}
			}
			return true;
		}

		public virtual bool ScriptDeleteNoMessageExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptAbortDeleteRootFolderExecute(ProcessExecutingContext context) {
			MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.AddMessage(Warning, WarningRootFolderMessage, MessageType.Warning);
			}
			return true;
		}

		public virtual Guid AddFolder(Guid FolderType, Guid ParentFolderId) {
			var defValues = new Dictionary <string, object>();
			defValues.Add(Page.DataSource.Schema.HierarchyColumn.Name, ParentFolderId);
			defValues.Add("FolderType",FolderType);
			var newGuid = Guid.NewGuid();
			Page.UserConnection.SessionData[newGuid.ToString()] = defValues;
			return newGuid;
		}

		public virtual void CheckRights(Guid selectedIem) {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaName = Page.DataSource.Schema.Name;
			var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
			var rightLevel = dbSecurityEngine.GetEntitySchemaRecordRightLevel(Page.UserConnection.CurrentUser.Id, entitySchemaName, selectedIem);
			if((rightLevel & Terrasoft.Core.DB.SchemaRecordRightLevels.CanDelete) == Terrasoft.Core.DB.SchemaRecordRightLevels.CanDelete) {
				((PageControl)Page.TreeGrid).FindPageControlByName("RemoveMenuItem").Enabled = true;
			} 
			if((rightLevel & Terrasoft.Core.DB.SchemaRecordRightLevels.CanEdit) == Terrasoft.Core.DB.SchemaRecordRightLevels.CanEdit) {
				((PageControl)Page.TreeGrid).FindPageControlByName("EditMenuItem").Enabled = true;
			} 
		}

		public virtual DataSourceRowConfig GetFolderRowConfig(Entity folder) {
			string primaryColumnName = folder.Schema.PrimaryColumn.Name;
			string primaryColumnValue = folder.GetColumnValue(primaryColumnName).ToString();
			var config = new DataSourceRowConfig(primaryColumnValue);
			Guid folderType = folder.GetTypedColumnValue<Guid>("FolderTypeId");
			ImageListItem icon = null;
			var staticFolderTypeUId = new Guid("9DC5F6E6-2A61-4DE8-A059-DE30F4E74F24");
			var searchFolderTypeUId = new Guid("65CA0946-0084-4874-B117-C13199AF3B95");
			var rootEmailFolderTypeUId = new Guid("6E23FA26-5BEE-E011-A86B-00155D04C01D");
			var mailBoxFolderTypeUId = new Guid("99c2351c-f0f8-e111-9dba-00155d051801");
			var subEmailFolderTypeUId = new Guid("B97A5836-1CD0-E111-90C6-00155D054C03");
			var recentGroupFolderTypeUId = new Guid("C01FFB44-7407-E011-A646-16D83CAB0980");
			
			if (folderType == searchFolderTypeUId) {
				icon = Page.GroupImageList.Items.FindByName("FilteredGroupImage");
			} else if (folderType == rootEmailFolderTypeUId) {
				icon = Page.GroupImageList.Items.FindByName("EmailGroupImage");
			} else if (folderType == mailBoxFolderTypeUId) {
				icon = Page.GroupImageList.Items.FindByName("MailBoxGroupImage");
			} else if (folderType == subEmailFolderTypeUId) {
				icon = Page.GroupImageList.Items.FindByName("SubEmailGroupImage");
			} else if (folderType.Equals(recentGroupFolderTypeUId)) {
				icon = Page.GroupImageList.Items.FindByName("RecentGroupImage");
			} else if (folderType.Equals(DuplicatesFolderId)) {
				icon = Page.GroupImageList.Items.FindByName("DuplicatesGroupImage");
			} else {
				icon = Page.GroupImageList.Items.FindByName("GroupImage");
			}
			var icons = new Dictionary<string, ImageConfigValue>();
			var controlImage = new ControlImage();
			controlImage.Source = ControlImageSource.ImageList;
			controlImage.ImageListUId = Page.GroupImageList.UId;
			controlImage.ImageUId = icon.UId;
			controlImage.SchemaUId = Page.Schema.UId;
			icons.Add("icon", new ImageConfigValue(controlImage));
			config.AddConfig(new DataSourceRowFirstColumnIconsConfigValue(icons));
			var schemaName = Page.DataSource.Schema.Name.Replace("Folder", String.Empty);
			if (folderType.Equals(staticFolderTypeUId)) {
				string[] dropTags = new string[] {schemaName}; 
				config.AddConfig(new DataSourceRowDropTagsConfigValue(dropTags));
			}
			Guid parent = folder.GetTypedColumnValue<Guid>("ParentId");
			if (parent == Guid.Empty) {
				config.AddConfig(new DataSourceRowExpandedConfigValue(true));
			}
			return config;
		}

		public virtual void AddDragDropEventParams(ComponentAjaxEvent DragDropEvent) {
			DragDropEvent.ExtraParameters.Add(new TerrasoftWebControls.Parameter("rows", "nodes", TerrasoftWebControls.ParameterMode.Raw));
			DragDropEvent.ExtraParameters.Add(new TerrasoftWebControls.Parameter("targetRow", "targetNode", TerrasoftWebControls.ParameterMode.Raw));
			DragDropEvent.ExtraParameters.Add(new TerrasoftWebControls.Parameter("parentRow", "parentNode", TerrasoftWebControls.ParameterMode.Raw));
			DragDropEvent.ExtraParameters.Add(new TerrasoftWebControls.Parameter("movePosition", "movePosition", TerrasoftWebControls.ParameterMode.Raw));
		}

		public virtual void PrepareAdminRightWindowOpener() {
			var recordId = Page.TreeGrid.SelectedNodes[0].Values[Page.DataSource.Schema.PrimaryColumn.Name].ToString();
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var rightGridPageUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(rightGridPageUId) as PageSchema;
			UserTaskAdminRightOpenWindow.OpenerInstanceId = InstanceUId;
			UserTaskAdminRightOpenWindow.UseCurrentActivePage = true;
			UserTaskAdminRightOpenWindow.PageUId = rightGridPageUId;
			var parameters = 
			      new Dictionary<string, string> {
			            {"recordId", recordId},
			            {"entitySchemaUId", EntitySchemaUId.ToString()},
			            {"treeGridId", Page.TreeGrid.ClientID}
			      };
			UserTaskAdminRightOpenWindow.PageParameters = parameters;
			UserTaskAdminRightOpenWindow.Width = editPageSchema.Width;
			UserTaskAdminRightOpenWindow.Height = editPageSchema.Height;
			UserTaskAdminRightOpenWindow.Centered = true;
			UserTaskAdminRightOpenWindow.CloseOpenerOnLoad = false;
		}

		public virtual void PrepareAddSearchFolderWondowOpener() {
			var recordId = Guid.Empty;
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			UserTaskAddSearchFolderOpenWindow.OpenerInstanceId = InstanceUId;
			UserTaskAddSearchFolderOpenWindow.UseCurrentActivePage = true;
			UserTaskAddSearchFolderOpenWindow.PageUId = EditPageUId;
			var parameters =  
			      new Dictionary<string, string> {
			            {"recordId", recordId.ToString()},
			            {"entitySchemaUId", EntitySchemaUId.ToString()},
			            {"treeGridId", Page.TreeGrid.ClientID}
			      };
			if (!string.IsNullOrEmpty(CacheItemName)) {
				parameters.Add("cacheItemName", CacheItemName);
			}
			if(DefValuesId != null && !DefValuesId.IsEmpty()) {
				parameters.Add("defValuesId", DefValuesId.ToString());
			}
			UserTaskAddSearchFolderOpenWindow.PageParameters = parameters;
			UserTaskAddSearchFolderOpenWindow.Centered = true;
			UserTaskAddSearchFolderOpenWindow.CloseOpenerOnLoad = false;
		}

		public virtual void PrepareAddGeneralFolderWondowOpener() {
			var recordId = Guid.Empty;
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			UserTaskAddGeneralFolderOpenWindow.OpenerInstanceId = InstanceUId;
			UserTaskAddGeneralFolderOpenWindow.UseCurrentActivePage = true;
			UserTaskAddGeneralFolderOpenWindow.PageUId = EditPageUId;
			var parameters =  
			      new Dictionary<string, string> {
			            {"recordId", recordId.ToString()},
			            {"entitySchemaUId", EntitySchemaUId.ToString()},
			            {"treeGridId", Page.TreeGrid.ClientID}
			      };
			if(DefValuesId != null && !DefValuesId.IsEmpty()) {
				parameters.Add("defValuesId", DefValuesId.ToString());
			}
			UserTaskAddGeneralFolderOpenWindow.PageParameters = parameters;
			UserTaskAddGeneralFolderOpenWindow.Centered = true;
			UserTaskAddGeneralFolderOpenWindow.CloseOpenerOnLoad = false;
		}

		public virtual void PrepareEditFolderWindowOpener() {
			var recordId = Page.TreeGrid.SelectedNodes[0].Values[Page.DataSource.Schema.PrimaryColumn.Name];
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			UserTaskEditFolderOpenWindow.OpenerInstanceId = InstanceUId;
			UserTaskEditFolderOpenWindow.UseCurrentActivePage = true;
			UserTaskEditFolderOpenWindow.PageUId = EditPageUId;
			var parameters =  
			      new Dictionary<string, string> {
			            {"recordId", recordId.ToString()},
			            {"entitySchemaUId", EntitySchemaUId.ToString()},
			            {"treeGridId", Page.TreeGrid.ClientID}
			      };
			UserTaskEditFolderOpenWindow.PageParameters = parameters;
			UserTaskEditFolderOpenWindow.Width = editPageSchema.Width;
			UserTaskEditFolderOpenWindow.Height = editPageSchema.Height;
			UserTaskEditFolderOpenWindow.Centered = true;
			UserTaskEditFolderOpenWindow.CloseOpenerOnLoad = false;
		}

		public virtual void BaseActiveRowChangedHandler() {
			var dataSource = Page.DataSource;
			var hierarchyColumn = dataSource.Schema.HierarchyColumn;
			if (String.IsNullOrEmpty(ListenerPageProcessUId) || hierarchyColumn == null) {
				return;
			}
			var process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
			if (Page.DataSource.ActiveRowPrimaryColumnValue != Guid.Empty) {
				var selectedValue = Page.DataSource.ActiveRowPrimaryColumnValue;
				CheckRights(selectedValue);
				if (Page.DataSource.Schema.Name == "BaseFolder") {
					process.SetPropertyValue("FolderId",
						(hierarchyColumn != null ? dataSource.ActiveRowPrimaryColumnValue : Guid.Empty));
				}
				process.SetPropertyValue("IsRootFolder",
					dataSource.ActiveRow.GetTypedColumnValue<Guid>(hierarchyColumn.ColumnValueName) == Guid.Empty);
			}
			process.ThrowEvent(process.InternalContext, "FolderActiveRowChanged");
			SetProfileData("LastSelectedFolder", dataSource.ActiveRowPrimaryColumnValue.ToString());
			var rootFolderTypeUId = new Guid("9DC5F6E6-2A61-4DE8-A059-DE30F4E74F24");
			Guid rootEmailFolderTypeUId = new Guid("6E23FA26-5BEE-E011-A86B-00155D04C01D");
			Guid subEmailFolderTypeUId = new Guid("B97A5836-1CD0-E111-90C6-00155D054C03");
			Guid recentFolderTypeUId = new Guid("C01FFB44-7407-E011-A646-16D83CAB0980");
			Guid mailboxFolderTypeUId = new Guid("99C2351C-F0F8-E111-9DBA-00155D051801");
			
			var duplicateMenuItems = new List<string> {
				Page.ConfigureDuplicatesMenuItem.ClientID,
				Page.StartDuplicatesSearchMenuItem.ClientID,
				//Page.ConfigureDuplicatesRightsMenuItem.ClientID
			};
			var folderTypeId = Guid.Empty;
			if (Page.DataSource.ActiveRow != null) {
				folderTypeId = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("FolderTypeId");
			}
			var isRoot = folderTypeId == rootFolderTypeUId;
			if (Page.DataSource.ActiveRow != null) {
				isRoot = isRoot && Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("ParentId") == Guid.Empty;
			}
			var isRootEmail = folderTypeId == rootEmailFolderTypeUId;
			var isMailBox = folderTypeId == mailboxFolderTypeUId;
			var isSubEmail = folderTypeId == subEmailFolderTypeUId;
			var isRecent = folderTypeId == recentFolderTypeUId;
			var isDuplicate = folderTypeId == DuplicatesFolderId;
			
			// Идентификаторы меню-айтемов групп раздела Активности
			var downloadEmailsClientId = Guid.Empty.ToString("N");
			var editMailBoxSettingsClientId = (new Guid("F568855E-5551-4124-ABB7-6802F8AF3698")).ToString("N");
			var emailAutoFillClientId = (new Guid("603305bd-df7f-4863-a127-412249bc5af0")).ToString("N");
			var changeProcessClientId = (new Guid("E6C5C556-1565-4A72-97FE-22A2E58D3B01")).ToString("N");
			var addEmailSubFolderClientId = (new Guid("03D5FCF2-1A82-4A62-9872-49B903D1FFC0")).ToString("N");
			
			
			int countActive = 0;
			foreach (var menuItem in Page.TreeGrid.Menu) {
				if (duplicateMenuItems.Contains(menuItem.ClientID)) {
					menuItem.Enabled = isDuplicate;		
				} else if (menuItem.ClientID == Page.AddSubEmailFolderMenuItem.ClientID) {
					menuItem.Enabled = isMailBox;
				} else if (menuItem.ClientID.Contains(downloadEmailsClientId) || menuItem.ClientID.Contains(editMailBoxSettingsClientId)) {
					menuItem.Enabled = isRootEmail || isMailBox;
				} else if (menuItem.ClientID == Page.AddGeneralFolderMenuItem.ClientID ||
					menuItem.ClientID == Page.AddSearchFolderMenuItem.ClientID) {
					menuItem.Enabled = !isSubEmail && !isRootEmail && !isMailBox;
				} else if (menuItem.ClientID.Contains(changeProcessClientId)) {
					menuItem.Enabled = (isSubEmail || isMailBox) && UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageProcessDesign");
				} else if (menuItem.ClientID == Page.AdminRightMenuItem.ClientID) {
					if(!isDuplicate) {
						menuItem.Enabled = !isRootEmail && (!isSubEmail || !isMailBox);
					} else {
						menuItem.Enabled = isDuplicate;
						Page.AdminRightMenuItem.Enabled = true;
					}
				} else if (menuItem.ClientID.Contains(addEmailSubFolderClientId)) {
					menuItem.Enabled = isMailBox;
				} else if (menuItem.ClientID.Contains(emailAutoFillClientId)) {
					menuItem.Enabled = (isSubEmail || isMailBox);
				} else if (menuItem.ClientID == Page.RemoveMenuItem.ClientID) {
					menuItem.Enabled = !isRootEmail;
				} else if (menuItem.ClientID == Page.EditMenuItem.ClientID) {
					menuItem.Enabled = !isMailBox;
				} else {
					menuItem.Enabled = !isRecent && !isRootEmail && !isDuplicate;// && !isMailBox;
				}	
				
				if(menuItem.ClientID==Page.PreloadMenuItem.ClientID 
				 	|| menuItem.ClientID==Page.NoActiveMenuItem.ClientID){
					menuItem.Enabled = false;	
				}
				
				if((isRecent||isRoot||isDuplicate)
					&&(menuItem.ClientID==Page.EditMenuItem.ClientID 
						|| menuItem.ClientID==Page.RemoveMenuItem.ClientID
						|| menuItem.ClientID==Page.AdminRightMenuItem.ClientID)){
					menuItem.Enabled = false;	
				}
				if((isRecent||isDuplicate)&&(menuItem.ClientID==Page.AddGeneralFolderMenuItem.ClientID
					||menuItem.ClientID==Page.AddSearchFolderMenuItem.ClientID)){
					menuItem.Enabled = false;
				}
				if(menuItem.Enabled){
					Page.AddScript(string.Format(" {0}.setVisible(true); ", menuItem.ClientID)); 
					countActive++;
				} else {
					Page.AddScript(string.Format(" {0}.setVisible(false); ", menuItem.ClientID));
				}	
			}
			if(countActive <= 0){
				Page.AddScript(string.Format(" {0}.setVisible(true); ", Page.NoActiveMenuItem.ClientID));
			}
			string parentMenuScript = string.Format(" if ({0}.parentMenu) {{ ", Page.PreloadMenuItem.ClientID);
			parentMenuScript += string.Format(" {0}.parentMenu.render(); ", Page.PreloadMenuItem.ClientID);
			parentMenuScript += string.Format(" {0}.parentMenu.restrictHeight(); ", Page.PreloadMenuItem.ClientID);
			parentMenuScript += string.Format(" {0}.parentMenu.restrictWidth(); }}", Page.PreloadMenuItem.ClientID);
			Page.AddScript(parentMenuScript);
		}

		public virtual void BaseLoadRowsResponseRegisteredHandler(object sender, DataSourceEventArgs e) {
			var dataSource = Page.DataSource;
			var dataSourceRowsCount = dataSource.Rows.Count;
			dataSource.SelectedItemPrimaryColumnValues.Clear();
			var activeRowUId = Guid.Empty;
			var lastFolderFromProfile = GetProfileData("LastSelectedFolder");
			if (lastFolderFromProfile == null) {
				if (DefaultFolderId != Guid.Empty) {
					activeRowUId = DefaultFolderId;
				}
			} else if (!Ext.IsAjaxRequest){
				activeRowUId = new Guid(lastFolderFromProfile.ToString());
			} 
			if (e.Request.AlreadyContainsRows) {
				dataSource.SetClientActiveRow(dataSource.ActiveRowPrimaryColumnValue, true);
				dataSource.SelectedItemPrimaryColumnValues.Add(dataSource.ActiveRowPrimaryColumnValue);
			} else {
				if (dataSourceRowsCount > 0) {
					if (activeRowUId == Guid.Empty) {
						if (e != null && e.Row != null) {
							activeRowUId = e.Row.PrimaryColumnValue;
						} else {
							activeRowUId = dataSource.Rows[0].PrimaryColumnValue;
						}
					}
					dataSource.SetClientActiveRow(activeRowUId, true);
					dataSource.SelectedItemPrimaryColumnValues.Add(
											dataSource.ActiveRowPrimaryColumnValue);
				} else {
					dataSource.SetClientActiveRow(activeRowUId, true);
				}
			}
			BaseActiveRowChangedHandler();
		}

		public virtual Guid GetDuplicatesFolderId() {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			if (Page.DataSource.Schema == null) {
				return Guid.Empty;
			}
			var query = new EntitySchemaQuery(entitySchemaManager, Page.DataSource.Schema.Name);
			var typeIdColumnName = query.AddColumn("FolderType.Id").Name;
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "FolderType.Code", "Duplicates"));
			var entities = query.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return entities[0].GetTypedColumnValue<Guid>(typeIdColumnName);
			} else {
				return Guid.Empty;
			}
		}

		public virtual bool IsDuplicatesFolder(Guid folderId) {
			var schema = Page.DataSource.Schema;
			var entity = schema.CreateEntity(UserConnection);
			if (entity.FetchFromDB("Id", folderId)) {
				return entity.GetTypedColumnValue<Guid>("FolderTypeId") == DuplicatesFolderId;
			}
			return false;
		}

		public virtual void ListenerThrowEvent(string listenerPageProcessUId, string eventName) {
			if (string.IsNullOrEmpty(listenerPageProcessUId)) {
				return;
			}
			var process = UserConnection.IProcessEngine.FindProcessByUId(listenerPageProcessUId);
			if (process != null) {
				process.ThrowEvent(process.InternalContext, eventName);
			}
		}

		public virtual void SetProfileData(string profileKey, string profileValue) {
			string script = "{0}.setProfileData({1},{2})";
			Page.ScriptManager.AddScript(string.Format(script, Page.TreeGrid.ClientID, "'" + profileKey + "'", "'" + profileValue + "'"));
		}

		public virtual object GetProfileData(string profileKey) {
			var page = Page.AspPage as Terrasoft.UI.WebControls.Page;
			object result = null;
			if (page.UseProfile) {
				var profileData = page.ProfileData;
				if (profileData != null) {
					var profileItem = profileData[Page.TreeGrid.ClientID];
					if (profileItem != null && profileItem.Values.ContainsKey(profileKey)) {
							result = profileItem.Values[profileKey];
					}
				}
			}
			return result;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ConfigureDuplicatesRightsMenuItemClick":
							if (ActivatedEventElements.Contains("ConfigureDuplicatesRightsMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("ConfigureDuplicatesRightsMenuItemClickStartMessage");
						}
						break;
					case "StartDuplicatesSearchMenuItemClick":
							if (ActivatedEventElements.Contains("StartDuplicatesSearchMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("StartDuplicatesSearchMenuItemClickStartMessage");
						}
						break;
					case "ConfigureDuplicatesMenuItemClick":
							if (ActivatedEventElements.Contains("ConfigureDuplicatesMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("ConfigureDuplicatesMenuItemClickStartMessage");
						}
						break;
					case "FolderGridNodesDrop":
							if (ActivatedEventElements.Contains("FolderGridNodesDrop")) {
							context.QueueTasks.Enqueue("FolderGridNodesDrop");
						}
						break;
					case "AdminRightMenuItemClick":
							if (ActivatedEventElements.Contains("AdminRightMenuItemClick")) {
							context.QueueTasks.Enqueue("AdminRightMenuItemClick");
						}
						break;
					case "AddSearchFolderMenuItemClick":
							if (ActivatedEventElements.Contains("AddSearchFolderMenuItemClick")) {
							context.QueueTasks.Enqueue("AddSearchFolderMenuItemClick");
						}
						break;
					case "AddGeneralFolderMenuItemClick":
							if (ActivatedEventElements.Contains("AddGeneralFolderMenuItemClick")) {
							context.QueueTasks.Enqueue("AddGeneralFolderMenuItemClick");
						}
						break;
					case "EditMenuItemClick":
							if (ActivatedEventElements.Contains("EditMenuItemClick")) {
							context.QueueTasks.Enqueue("EditMenuItemClick");
						}
						break;
					case "AddSubEmailFolderMenuItemClick":
							if (ActivatedEventElements.Contains("AddSubEmailFolderMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("AddSubEmailFolderMenuItemClickStartMessage");
						}
						break;
					case "Initialize":
							if (ActivatedEventElements.Contains("Initialize")) {
							context.QueueTasks.Enqueue("Initialize");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("Init")) {
							context.QueueTasks.Enqueue("Init");
						}
						break;
					case "RemoveMenuItemClick":
							if (ActivatedEventElements.Contains("RemoveMenuItemClick")) {
							context.QueueTasks.Enqueue("RemoveMenuItemClick");
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("DeleteYesMessage")) {
							context.QueueTasks.Enqueue("DeleteYesMessage");
						}
						break;
					case "DeleteNoMessage":
							if (ActivatedEventElements.Contains("DeleteNoMessage")) {
							context.QueueTasks.Enqueue("DeleteNoMessage");
						}
						break;
					case "AbortDeleteRootFolder":
							if (ActivatedEventElements.Contains("StartMessageAbortDeleteRootFolder")) {
							context.QueueTasks.Enqueue("StartMessageAbortDeleteRootFolder");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (ProcessSchemaParameter1 != null) {
				if (ProcessSchemaParameter1.GetType().IsSerializable ||
					ProcessSchemaParameter1.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ProcessSchemaParameter1", ProcessSchemaParameter1, null);
				}
			}
			if (!HasMapping("DefaultFolderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DefaultFolderId", DefaultFolderId, Guid.Empty);
			}
			if (!HasMapping("CacheItemName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CacheItemName", CacheItemName, null);
			}
			if (!HasMapping("IsAdministratedByRecords") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsAdministratedByRecords", IsAdministratedByRecords, false);
			}
			if (!HasMapping("IsMultiFolder") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsMultiFolder", IsMultiFolder, false);
			}
			if (!HasMapping("DuplicatesFolderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DuplicatesFolderId", DuplicatesFolderId, Guid.Empty);
			}
			if (!HasMapping("DropTags") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DropTags", DropTags, null);
			}
			if (!HasMapping("ListenerPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ListenerPageProcessUId", ListenerPageProcessUId, null);
			}
			if (!HasMapping("DefValuesId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DefValuesId", DefValuesId, Guid.Empty);
			}
			if (!HasMapping("EditPageUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditPageUId", EditPageUId, Guid.Empty);
			}
			if (!HasMapping("EntitySchemaManagerName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaManagerName", EntitySchemaManagerName, null);
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

	#region Class: BaseModuleFoldersPageEventsProcess

	/// <exclude/>
	public class BaseModuleFoldersPageEventsProcess : BaseModuleFoldersPageEventsProcess<Terrasoft.WebApp.BaseModuleFoldersPageSchemaUserControl>
	{

		public BaseModuleFoldersPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseModuleFoldersPageSchemaUserControl

	/// <exclude/>
	public partial class BaseModuleFoldersPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TreeGrid TreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("TreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem PreloadMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("PreloadMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem NoActiveMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("NoActiveMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AddGeneralFolderMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AddGeneralFolderMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AddSearchFolderMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AddSearchFolderMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AddSubEmailFolderMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AddSubEmailFolderMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem EditMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("EditMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem RemoveMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("RemoveMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AdminRightMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AdminRightMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem ConfigureDuplicatesMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("ConfigureDuplicatesMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem StartDuplicatesSearchMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("StartDuplicatesSearchMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("DataSource", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ImageList GroupImageList {
			get {
				return (Terrasoft.UI.WebControls.Controls.ImageList)PageContainer.FindPageControl("GroupImageList", true);
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
			AddGeneralFolderMenuItem.AjaxEvents.Click.Event += AddGeneralFolderMenuItemClick;
			AddSearchFolderMenuItem.AjaxEvents.Click.Event += AddSearchFolderMenuItemClick;
			AddSubEmailFolderMenuItem.AjaxEvents.Click.Event += AddSubEmailFolderMenuItemClick;
			EditMenuItem.AjaxEvents.Click.Event += EditMenuItemClick;
			RemoveMenuItem.AjaxEvents.Click.Event += RemoveMenuItemClick;
			AdminRightMenuItem.AjaxEvents.Click.Event += AdminRightMenuItemClick;
			ConfigureDuplicatesMenuItem.AjaxEvents.Click.Event += ConfigureDuplicatesMenuItemClick;
			StartDuplicatesSearchMenuItem.AjaxEvents.Click.Event += StartDuplicatesSearchMenuItemClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddGeneralFolderMenuItem.AjaxEvents.Click.Event -= AddGeneralFolderMenuItemClick;
			AddSearchFolderMenuItem.AjaxEvents.Click.Event -= AddSearchFolderMenuItemClick;
			AddSubEmailFolderMenuItem.AjaxEvents.Click.Event -= AddSubEmailFolderMenuItemClick;
			EditMenuItem.AjaxEvents.Click.Event -= EditMenuItemClick;
			RemoveMenuItem.AjaxEvents.Click.Event -= RemoveMenuItemClick;
			AdminRightMenuItem.AjaxEvents.Click.Event -= AdminRightMenuItemClick;
			ConfigureDuplicatesMenuItem.AjaxEvents.Click.Event -= ConfigureDuplicatesMenuItemClick;
			StartDuplicatesSearchMenuItem.AjaxEvents.Click.Event -= StartDuplicatesSearchMenuItemClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseModuleFoldersPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseModuleFoldersPageEventsProcess(UserConnection);
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

		public virtual void AddGeneralFolderMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddGeneralFolderMenuItemClick");
		}

		public virtual void AddSearchFolderMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddSearchFolderMenuItemClick");
		}

		public virtual void AddSubEmailFolderMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddSubEmailFolderMenuItemClick");
		}

		public virtual void EditMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("EditMenuItemClick");
		}

		public virtual void RemoveMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("RemoveMenuItemClick");
		}

		public virtual void AdminRightMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("AdminRightMenuItemClick");
		}

		public virtual void ConfigureDuplicatesMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("ConfigureDuplicatesMenuItemClick");
		}

		public virtual void StartDuplicatesSearchMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("StartDuplicatesSearchMenuItemClick");
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
			SchemaName = "BaseModuleFoldersPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseModuleFoldersPageEventsProcessSchema

	/// <exclude/>
	public class BaseModuleFoldersPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseModuleFoldersPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseModuleFoldersPageEventsProcessSchema(BaseModuleFoldersPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseModuleFoldersPageEventsProcess";
			UId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4");
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

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3b4f362f-fd49-408f-b26b-fe39365b7501"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1a187ee5-4f27-4b85-9905-f00c8e2711de"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"EntitySchemaManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2af15ba1-c1cb-4acc-a103-ed273e9755ed"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"EditPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a93b25de-fb1b-4942-9c61-12aac8c7f4d5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ListenerPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefValuesIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4f7dfa4e-25f3-4a8c-b184-d5907385ca2d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"DefValuesId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("108d87e5-5ec7-4af8-a96d-53f5161b1e3d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ListenerPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDropTagsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5ae37897-a69b-4cef-9c02-ab1e03af0690"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"DropTags",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDuplicatesFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("df894753-5a6e-426a-b216-205affefa985"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"DuplicatesFolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsMultiFolderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("928d3558-68f0-4731-8fa6-fc419808e99c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"IsMultiFolder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsAdministratedByRecordsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dea77cfe-1ed0-47f1-a88c-f9272c054ef7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"IsAdministratedByRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCacheItemNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("86a79d2c-b339-4205-9cae-aaa310f04b2d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"CacheItemName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("367f1e6a-fdd5-4893-92d7-5c362d2736e3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"DefaultFolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateProcessSchemaParameter1Parameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("53ad5544-c4b5-4e5b-be6a-617fce0a22f5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ProcessSchemaParameter1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateEntitySchemaManagerNameParameter());
			Parameters.Add(CreateEditPageUIdParameter());
			Parameters.Add(CreateListenerPageParameter());
			Parameters.Add(CreateDefValuesIdParameter());
			Parameters.Add(CreateListenerPageProcessUIdParameter());
			Parameters.Add(CreateDropTagsParameter());
			Parameters.Add(CreateDuplicatesFolderIdParameter());
			Parameters.Add(CreateIsMultiFolderParameter());
			Parameters.Add(CreateIsAdministratedByRecordsParameter());
			Parameters.Add(CreateCacheItemNameParameter());
			Parameters.Add(CreateDefaultFolderIdParameter());
			Parameters.Add(CreateProcessSchemaParameter1Parameter());
		}

		protected virtual void InitializeUserTaskAdminRightOpenWindowParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("48ed373d-1eca-4ab2-87b2-82fa0d4f616b"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("e60f3571-9d5b-4945-b2b9-5536bbe6557f"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("f4f4abae-f831-4d8f-a3c0-35b1b7503e44"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("f73368dd-1b52-406b-a923-fcad9e6c7ffa"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("1765aa9c-18d4-4b42-bcbb-523c4b0b7d04"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("f11caead-0a6b-479b-a5dd-f5c3c6ddb73e"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("effc8bc0-ec0e-4c1d-bb45-d2c36161f63e"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("d438a18b-d0aa-452a-a0d9-942e0f5c319b"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("584a8027-c2d1-4068-970a-ed2583442d10"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("fb733f20-c151-4981-a28c-284c063aa5b1"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("57f2a0e0-4a34-41f1-9c44-1810a2fd4e18"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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
				UId = new Guid("00d32be4-7715-4beb-8d9b-3a1357dba860"),
				ContainerUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
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

		protected virtual void InitializeUserTaskAddSearchFolderOpenWindowParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5d47408b-ac76-462c-9ba1-6c30eef74de5"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("73e4329d-f846-4805-ab37-2cf008257f3d"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("3462f3ff-6f03-4395-9253-a92e4895861d"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("0403461c-c559-4663-868c-0d80076cc877"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("9018455d-3fb2-4e54-925a-5e3628bca9b0"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("97290912-5673-471a-a876-cb71b48250aa"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("304b307b-d733-4fdf-bce9-33cb7fb0d47b"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("0fed8f03-5eba-4769-b6ff-9d24e854f336"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("40681e0c-588f-47d7-afd9-838688d3721c"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("dcfc7c09-3ca7-46fc-8c4a-08c4e54a18f5"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("f0d8c7ad-6bcb-464e-a8f6-178cfa83b372"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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
				UId = new Guid("0cb45a74-7d61-44ac-b618-e3a079c1415f"),
				ContainerUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
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

		protected virtual void InitializeUserTaskAddGeneralFolderOpenWindowParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("cb6c5af3-4323-48d9-82c7-3bd0224eee2f"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("19aaa178-7dde-4e35-9360-7272aa65c3be"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("e0bed24f-5894-4225-a35c-7bceba3bd769"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("08901f3c-2ae8-460d-91c6-88124215c4a5"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("7ec0f773-419d-4509-b01d-359646b87710"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("98d74a72-e8c2-4451-a1dc-71caf81042cb"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("04b9dd0a-8685-444e-b36d-e6bd8e1de07f"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("0a19312e-b6cd-48c5-862f-17e4785274b4"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("c137bbbc-d719-461a-bef0-a7b1f8f76d7d"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("861432d6-fffa-455d-b964-b9532a73486f"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("dc08b060-2436-462d-9656-8f6bd4be5b43"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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
				UId = new Guid("1bb009b5-9050-4523-9441-51e55e672db7"),
				ContainerUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
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

		protected virtual void InitializeUserTaskEditFolderOpenWindowParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("01b87d75-a88c-4659-9be6-6a3a23e6c1b0"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("f51aae6e-5f86-471b-a018-5ec01293c7a8"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("88a4c78f-9297-4c02-915e-d11c775fffbd"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("09fc85e9-50da-47d7-9072-c9c56d786e53"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("9625450e-30de-4b75-9afc-b4fbe0253462"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("fe41f0ad-8134-41b0-85c0-4c4e6e327012"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("6fdcdc2e-c86d-49d7-9265-78df613ea702"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("4305d4c9-1720-4947-934c-0edbe85bbd29"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("2f9a6e18-dc28-4de2-9dda-d737c671b540"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("e02835a3-f943-41a9-abdc-6b17ae1c02c1"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("91851ffc-12bf-4700-b70b-9e34cd89bcd3"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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
				UId = new Guid("bf23db42-d2aa-4ecf-815e-4ea204cc554e"),
				ContainerUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
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

		protected virtual void InitializeAddSubEmailFolderUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("46d350b7-9d4e-4de5-8d11-f348e5bde6e8"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("1b343dcf-d641-40aa-97aa-7cabcbfe35af"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("826bd786-90bd-4db9-979c-8011bef7ba46"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("e59b7bb8-3e0f-4381-a65d-2f931abab4e5"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("8940e8f9-8f4e-4f02-b583-3b2e374ba5c6"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("a03d2f6d-46c1-4f5f-a23a-0c86c8e09d43"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("d132ae65-8b36-4abb-a9c3-4fb7881d6e11"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("e3c8a8a6-02ac-45d5-bb06-886b32a0cb35"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("487b2ed8-8e26-417d-8717-bca219091640"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("3d2cdcee-9fb6-411c-8238-003e03871bad"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("8471182b-851c-494a-8163-e2313fe075a3"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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
				UId = new Guid("eaa3e9db-8c79-40ac-a95f-9855f59b8435"),
				ContainerUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
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

		protected virtual void InitializeUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7c370aa6-4d4a-4709-8a29-072833e88530"),
				ContainerUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
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
				UId = new Guid("3eb85cbe-fdf1-4923-8c1b-a6ee6abb3eda"),
				ContainerUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
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
				UId = new Guid("a60c2156-88b1-4217-90be-975ef2c6076c"),
				ContainerUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
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
				UId = new Guid("e0ef6794-9656-4697-baba-b97e5193b408"),
				ContainerUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
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
				UId = new Guid("b22873c0-68db-4c93-9b97-b94a1ad25dba"),
				ContainerUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
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
				UId = new Guid("57b9f594-e740-41f0-b5a3-ae0dc2bf9035"),
				ContainerUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
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
				UId = new Guid("7bed4e24-e9e6-4e25-8762-01c4113bd010"),
				ContainerUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
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
				UId = new Guid("97aba4da-9fdf-430a-b940-cd02b4b552dc"),
				ContainerUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
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
			ProcessSchemaLaneSet schemaLaneSet14 = CreateLaneSet14LaneSet();
			LaneSets.Add(schemaLaneSet14);
			ProcessSchemaLane schemaDuplicatesContextMenuLane = CreateDuplicatesContextMenuLaneLane();
			schemaLaneSet14.Lanes.Add(schemaDuplicatesContextMenuLane);
			ProcessSchemaEventSubProcess eventsubprocess2999 = CreateEventSubProcess2999EventSubProcess();
			FlowElements.Add(eventsubprocess2999);
			ProcessSchemaEventSubProcess eventsubprocess5999 = CreateEventSubProcess5999EventSubProcess();
			FlowElements.Add(eventsubprocess5999);
			ProcessSchemaEventSubProcess eventsubprocess6999 = CreateEventSubProcess6999EventSubProcess();
			FlowElements.Add(eventsubprocess6999);
			ProcessSchemaEventSubProcess foldergridnodesdropsubprocess = CreateFolderGridNodesDropSubProcessEventSubProcess();
			FlowElements.Add(foldergridnodesdropsubprocess);
			ProcessSchemaEventSubProcess subprocess3 = CreateSubProcess3EventSubProcess();
			FlowElements.Add(subprocess3);
			ProcessSchemaEventSubProcess subprocessaddsearchfoldermenuitemclick = CreateSubProcessAddSearchFolderMenuItemClickEventSubProcess();
			FlowElements.Add(subprocessaddsearchfoldermenuitemclick);
			ProcessSchemaEventSubProcess subprocessaddgeneralfoldermenuitemclick = CreateSubProcessAddGeneralFolderMenuItemClickEventSubProcess();
			FlowElements.Add(subprocessaddgeneralfoldermenuitemclick);
			ProcessSchemaEventSubProcess subprocesseditmenuitemclick = CreateSubProcessEditMenuItemClickEventSubProcess();
			FlowElements.Add(subprocesseditmenuitemclick);
			ProcessSchemaEventSubProcess addsubemailfoldermenuitemclickeventsubprocess = CreateAddSubEmailFolderMenuItemClickEventSubProcessEventSubProcess();
			FlowElements.Add(addsubemailfoldermenuitemclickeventsubprocess);
			ProcessSchemaEventSubProcess initializeeventsubprocess = CreateInitializeEventSubProcessEventSubProcess();
			FlowElements.Add(initializeeventsubprocess);
			ProcessSchemaEventSubProcess pageloadcompletesubprocess = CreatePageLoadCompleteSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompletesubprocess);
			ProcessSchemaEventSubProcess initsubprocess = CreateInitSubProcessEventSubProcess();
			FlowElements.Add(initsubprocess);
			ProcessSchemaEventSubProcess subprocessremovemenuitemclick = CreateSubProcessRemoveMenuItemClickEventSubProcess();
			FlowElements.Add(subprocessremovemenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessdeleteyesmessage = CreateEventSubProcessDeleteYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocessdeleteyesmessage);
			ProcessSchemaEventSubProcess eventsubprocessdeletenomessage = CreateEventSubProcessDeleteNoMessageEventSubProcess();
			FlowElements.Add(eventsubprocessdeletenomessage);
			ProcessSchemaEventSubProcess abortdeleterootfoldereventsubprocess = CreateAbortDeleteRootFolderEventSubProcessEventSubProcess();
			FlowElements.Add(abortdeleterootfoldereventsubprocess);
			ProcessSchemaScriptTask prepareopenrightspagescripttask = CreatePrepareOpenRightsPageScriptTaskScriptTask();
			eventsubprocess2999.FlowElements.Add(prepareopenrightspagescripttask);
			ProcessSchemaStartMessageEvent configureduplicatesrightsmenuitemclickstartmessage = CreateConfigureDuplicatesRightsMenuItemClickStartMessageStartMessageEvent();
			eventsubprocess2999.FlowElements.Add(configureduplicatesrightsmenuitemclickstartmessage);
			ProcessSchemaStartMessageEvent startduplicatessearchmenuitemclickstartmessage = CreateStartDuplicatesSearchMenuItemClickStartMessageStartMessageEvent();
			eventsubprocess5999.FlowElements.Add(startduplicatessearchmenuitemclickstartmessage);
			ProcessSchemaScriptTask startduplicatessearchmenuitemclickscripttask = CreateStartDuplicatesSearchMenuItemClickScriptTaskScriptTask();
			eventsubprocess5999.FlowElements.Add(startduplicatessearchmenuitemclickscripttask);
			ProcessSchemaScriptTask configureduplicatesmenuitemclickscripttask = CreateConfigureDuplicatesMenuItemClickScriptTaskScriptTask();
			eventsubprocess6999.FlowElements.Add(configureduplicatesmenuitemclickscripttask);
			ProcessSchemaStartMessageEvent configureduplicatesmenuitemclickstartmessage = CreateConfigureDuplicatesMenuItemClickStartMessageStartMessageEvent();
			eventsubprocess6999.FlowElements.Add(configureduplicatesmenuitemclickstartmessage);
			ProcessSchemaStartMessageEvent foldergridnodesdrop = CreateFolderGridNodesDropStartMessageEvent();
			foldergridnodesdropsubprocess.FlowElements.Add(foldergridnodesdrop);
			ProcessSchemaScriptTask foldergridnodesdropscript = CreateFolderGridNodesDropScriptScriptTask();
			foldergridnodesdropsubprocess.FlowElements.Add(foldergridnodesdropscript);
			ProcessSchemaStartMessageEvent adminrightmenuitemclick = CreateAdminRightMenuItemClickStartMessageEvent();
			subprocess3.FlowElements.Add(adminrightmenuitemclick);
			ProcessSchemaScriptTask scriptadminrightmenuitemclick2 = CreateScriptAdminRightMenuItemClick2ScriptTask();
			subprocess3.FlowElements.Add(scriptadminrightmenuitemclick2);
			ProcessSchemaUserTask usertaskadminrightopenwindow = CreateUserTaskAdminRightOpenWindowUserTask();
			subprocess3.FlowElements.Add(usertaskadminrightopenwindow);
			ProcessSchemaStartMessageEvent addsearchfoldermenuitemclick = CreateAddSearchFolderMenuItemClickStartMessageEvent();
			subprocessaddsearchfoldermenuitemclick.FlowElements.Add(addsearchfoldermenuitemclick);
			ProcessSchemaScriptTask scriptaddsearchfoldermenuitemclick = CreateScriptAddSearchFolderMenuItemClickScriptTask();
			subprocessaddsearchfoldermenuitemclick.FlowElements.Add(scriptaddsearchfoldermenuitemclick);
			ProcessSchemaUserTask usertaskaddsearchfolderopenwindow = CreateUserTaskAddSearchFolderOpenWindowUserTask();
			subprocessaddsearchfoldermenuitemclick.FlowElements.Add(usertaskaddsearchfolderopenwindow);
			ProcessSchemaScriptTask scriptprepareaddsearchfolderwindowopener = CreateScriptPrepareAddSearchFolderWindowOpenerScriptTask();
			subprocessaddsearchfoldermenuitemclick.FlowElements.Add(scriptprepareaddsearchfolderwindowopener);
			ProcessSchemaStartMessageEvent addgeneralfoldermenuitemclick = CreateAddGeneralFolderMenuItemClickStartMessageEvent();
			subprocessaddgeneralfoldermenuitemclick.FlowElements.Add(addgeneralfoldermenuitemclick);
			ProcessSchemaScriptTask scriptaddgeneralfoldermenuitemclick = CreateScriptAddGeneralFolderMenuItemClickScriptTask();
			subprocessaddgeneralfoldermenuitemclick.FlowElements.Add(scriptaddgeneralfoldermenuitemclick);
			ProcessSchemaScriptTask scriptprepareaddgeneralfolderwindowopener = CreateScriptPrepareAddGeneralFolderWindowOpenerScriptTask();
			subprocessaddgeneralfoldermenuitemclick.FlowElements.Add(scriptprepareaddgeneralfolderwindowopener);
			ProcessSchemaUserTask usertaskaddgeneralfolderopenwindow = CreateUserTaskAddGeneralFolderOpenWindowUserTask();
			subprocessaddgeneralfoldermenuitemclick.FlowElements.Add(usertaskaddgeneralfolderopenwindow);
			ProcessSchemaStartMessageEvent editmenuitemclick = CreateEditMenuItemClickStartMessageEvent();
			subprocesseditmenuitemclick.FlowElements.Add(editmenuitemclick);
			ProcessSchemaScriptTask scripteditmenuitemclick = CreateScriptEditMenuItemClickScriptTask();
			subprocesseditmenuitemclick.FlowElements.Add(scripteditmenuitemclick);
			ProcessSchemaUserTask usertaskeditfolderopenwindow = CreateUserTaskEditFolderOpenWindowUserTask();
			subprocesseditmenuitemclick.FlowElements.Add(usertaskeditfolderopenwindow);
			ProcessSchemaStartMessageEvent addsubemailfoldermenuitemclickstartmessage = CreateAddSubEmailFolderMenuItemClickStartMessageStartMessageEvent();
			addsubemailfoldermenuitemclickeventsubprocess.FlowElements.Add(addsubemailfoldermenuitemclickstartmessage);
			ProcessSchemaScriptTask addsubemailfoldermenuitemclickscripttask = CreateAddSubEmailFolderMenuItemClickScriptTaskScriptTask();
			addsubemailfoldermenuitemclickeventsubprocess.FlowElements.Add(addsubemailfoldermenuitemclickscripttask);
			ProcessSchemaUserTask addsubemailfolderusertask = CreateAddSubEmailFolderUserTaskUserTask();
			addsubemailfoldermenuitemclickeventsubprocess.FlowElements.Add(addsubemailfolderusertask);
			ProcessSchemaStartMessageEvent initialize = CreateInitializeStartMessageEvent();
			initializeeventsubprocess.FlowElements.Add(initialize);
			ProcessSchemaScriptTask scriptinitialize = CreateScriptInitializeScriptTask();
			initializeeventsubprocess.FlowElements.Add(scriptinitialize);
			ProcessSchemaScriptTask scriptpageloadcomplete = CreateScriptPageLoadCompleteScriptTask();
			pageloadcompletesubprocess.FlowElements.Add(scriptpageloadcomplete);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			pageloadcompletesubprocess.FlowElements.Add(pageloadcomplete);
			ProcessSchemaStartMessageEvent init = CreateInitStartMessageEvent();
			initsubprocess.FlowElements.Add(init);
			ProcessSchemaScriptTask initscript = CreateInitScriptScriptTask();
			initsubprocess.FlowElements.Add(initscript);
			ProcessSchemaStartMessageEvent removemenuitemclick = CreateRemoveMenuItemClickStartMessageEvent();
			subprocessremovemenuitemclick.FlowElements.Add(removemenuitemclick);
			ProcessSchemaScriptTask scriptremovemenuitemclick = CreateScriptRemoveMenuItemClickScriptTask();
			subprocessremovemenuitemclick.FlowElements.Add(scriptremovemenuitemclick);
			ProcessSchemaUserTask usermessage = CreateUserMessageUserTask();
			subprocessremovemenuitemclick.FlowElements.Add(usermessage);
			ProcessSchemaStartMessageEvent deleteyesmessage = CreateDeleteYesMessageStartMessageEvent();
			eventsubprocessdeleteyesmessage.FlowElements.Add(deleteyesmessage);
			ProcessSchemaScriptTask scriptdeleteyesmessage = CreateScriptDeleteYesMessageScriptTask();
			eventsubprocessdeleteyesmessage.FlowElements.Add(scriptdeleteyesmessage);
			ProcessSchemaStartMessageEvent deletenomessage = CreateDeleteNoMessageStartMessageEvent();
			eventsubprocessdeletenomessage.FlowElements.Add(deletenomessage);
			ProcessSchemaScriptTask scriptdeletenomessage = CreateScriptDeleteNoMessageScriptTask();
			eventsubprocessdeletenomessage.FlowElements.Add(scriptdeletenomessage);
			ProcessSchemaStartMessageEvent startmessageabortdeleterootfolder = CreateStartMessageAbortDeleteRootFolderStartMessageEvent();
			abortdeleterootfoldereventsubprocess.FlowElements.Add(startmessageabortdeleterootfolder);
			ProcessSchemaScriptTask scriptabortdeleterootfolder = CreateScriptAbortDeleteRootFolderScriptTask();
			abortdeleterootfoldereventsubprocess.FlowElements.Add(scriptabortdeleterootfolder);
			FlowElements.Add(CreateSequenceFlow145SequenceFlow());
			FlowElements.Add(CreateSequenceFlow147SequenceFlow());
			FlowElements.Add(CreateSequenceFlow148SequenceFlow());
			FlowElements.Add(CreateSequenceFlow149SequenceFlow());
			FlowElements.Add(CreateSequenceFlow150SequenceFlow());
			FlowElements.Add(CreateSequenceFlow151SequenceFlow());
			FlowElements.Add(CreateSequenceFlow152SequenceFlow());
			FlowElements.Add(CreateSequenceFlow153SequenceFlow());
			FlowElements.Add(CreateSequenceFlow154SequenceFlow());
			FlowElements.Add(CreateSequenceFlow155SequenceFlow());
			FlowElements.Add(CreateSequenceFlow156SequenceFlow());
			FlowElements.Add(CreateSequenceFlow157SequenceFlow());
			FlowElements.Add(CreateSequenceFlow158SequenceFlow());
			FlowElements.Add(CreateSequenceFlow159SequenceFlow());
			FlowElements.Add(CreateSequenceFlow160SequenceFlow());
			FlowElements.Add(CreateSequenceFlow161SequenceFlow());
			FlowElements.Add(CreateSequenceFlow162SequenceFlow());
			FlowElements.Add(CreateSequenceFlow163SequenceFlow());
			FlowElements.Add(CreateSequenceFlow165SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3999SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1999SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4999SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1444SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2555SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDeleteRecordMessageLocalizableString());
			LocalizableStrings.Add(CreateWarningMessageLocalizableString());
			LocalizableStrings.Add(CreateNoDeleteRightsMessageLocalizableString());
			LocalizableStrings.Add(CreateWarningLocalizableString());
			LocalizableStrings.Add(CreateWarningRootFolderMessageLocalizableString());
			LocalizableStrings.Add(CreateWarningFolderNotEmptyMessageLocalizableString());
			LocalizableStrings.Add(CreateEmailFolderRemoveMailBoxMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateRemoveFolderMenuItemCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDeleteRecordMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("36f4e126-d405-4d40-b66d-dc467afa51d5"),
				Name = "DeleteRecordMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bff07880-06b7-451b-adf5-f8210e5da053"),
				Name = "WarningMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoDeleteRightsMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a51a0ecd-cd00-462c-ba8a-94c03ce5ebb4"),
				Name = "NoDeleteRightsMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e5ecc9de-404a-43a5-8bd3-89ee3434fa7d"),
				Name = "Warning",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningRootFolderMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("689316c3-c986-40f1-8bb3-fc198778dfdd"),
				Name = "WarningRootFolderMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningFolderNotEmptyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("34190d8d-632c-4f4e-bd40-8d6d1e6b4423"),
				Name = "WarningFolderNotEmptyMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailFolderRemoveMailBoxMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b80c7a5d-7433-4a33-b450-72d9f5118192"),
				Name = "EmailFolderRemoveMailBoxMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRemoveFolderMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7418583f-e887-462a-9bca-2ec139076f86"),
				Name = "RemoveFolderMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow145SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow145",
				UId = new Guid("36a22c30-753e-44b5-a434-9bb18f5af6ae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(253, 165),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("012dfa4c-e543-44bd-abfd-f0828f1ff2ab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4568cf3-7a38-4050-8749-6514fcb6712a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow147SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow147",
				UId = new Guid("a0328762-e22d-4759-b6ee-e17b6b1b761a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(437, 242),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("656c3b3a-948f-49c3-96bb-8f2814b40359"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("20ca36b7-a82c-4fc8-a646-da0531fb57d6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow148SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow148",
				UId = new Guid("317dd3dc-9f5b-4e74-a1ff-ed790abb8947"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bb5fa926-6eab-4345-a2e5-f57db3b51fb8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b735056-cd06-40f7-bbdc-e2766f6e42da"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow149SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow149",
				UId = new Guid("3b0c3d1e-44ce-4add-973b-bcdfd548156a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3feb751e-08ae-4ad2-8ab1-e80600f61a78"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2293c1e5-49f2-4d45-9907-8bc2106aa34e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow150SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow150",
				UId = new Guid("c5f04589-507f-4180-b3c4-6f2e4213e1de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f77193e-d1a6-42db-8741-9451e7c98807"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3740380c-84d5-4a94-849b-806f9387f388"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow151SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow151",
				UId = new Guid("c80d13fd-e390-4d33-bb76-3c72fd5452c8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("65c6c34e-67f1-4588-a71d-bf1d1d3e1c5f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("317f1bba-4367-4759-a955-ae37a5ebda2c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow152SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow152",
				UId = new Guid("fcbc1ff3-c83a-4fab-a0dc-bf58e6118887"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7f8ccc3-bdb5-4319-af46-8d7a249b29c7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b7443b26-dc60-4d72-a6bb-74cb3a8d8b02"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow153SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow153",
				UId = new Guid("1920c3d1-f8e5-4419-930e-2d6841ade646"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(402, 1196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c16b35b-a77d-4fc8-83c9-795e2cd0e73d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("819500cd-cad5-4a5f-b839-ba35e5ac2b28"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow154SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow154",
				UId = new Guid("3360f888-5bc9-4ca5-9d5e-6b32e7abfe27"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(140, 1247),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d9f30f06-cdaf-40c4-bcb7-1d2d37dc063e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("51b7c399-dbe2-4c12-a455-c650e3bb1c2f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow155SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow155",
				UId = new Guid("cd0f94c4-ac7e-4423-88da-298387d5f125"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(271, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b7443b26-dc60-4d72-a6bb-74cb3a8d8b02"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow156SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow156",
				UId = new Guid("7b64b3e3-3282-4248-925e-f946b1c53d10"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(281, 238),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("317f1bba-4367-4759-a955-ae37a5ebda2c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1ed6d5fe-5867-40d5-bfc2-f0bb25bbf2f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow157SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow157",
				UId = new Guid("0666f881-6e65-4f7d-b78d-a4bf127b7d9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(412, 238),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ed6d5fe-5867-40d5-bfc2-f0bb25bbf2f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow158SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow158",
				UId = new Guid("ed99ce68-f5d2-46e9-98ae-cd0d8fe8b7cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(266, 417),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3740380c-84d5-4a94-849b-806f9387f388"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("be40bd54-4041-412c-9384-a4afc3b9ab23"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow159SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow159",
				UId = new Guid("d1259044-d878-4d47-84a5-0e0f16b156fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(404, 417),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("be40bd54-4041-412c-9384-a4afc3b9ab23"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow160SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow160",
				UId = new Guid("d8533ac3-4b10-4459-9718-96ae6a392835"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(340, 748),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b735056-cd06-40f7-bbdc-e2766f6e42da"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow161SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow161",
				UId = new Guid("f101ae13-04b9-4cc0-a860-96678f130aa7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(266, 581),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2293c1e5-49f2-4d45-9907-8bc2106aa34e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow162SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow162",
				UId = new Guid("515f5a90-1507-4476-bc2e-cad768ddb73e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(503, 592),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1cd729fa-cd46-4ebd-83a7-41680ff0825e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9a5f5233-a13f-40a2-aa6a-c3100b36f55e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow163SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow163",
				UId = new Guid("cf2c2b5f-2c88-40e7-9301-646dbb5f69cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(724, 588),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b8c56e8c-48bc-4776-87af-042947a70717"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c891633-f17d-4d14-8b49-24d2010e8f6e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow165SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow165",
				UId = new Guid("d7c7b07c-06ea-4182-81b6-7a234d0ad291"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(177, 99),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fa09c88e-c5cc-4d82-a809-cb78724bf534"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("66bc8d88-dd9a-4fb4-ab7f-79c523ffa08f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3999SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3999",
				UId = new Guid("87766a7f-a22b-46cd-90be-8856281c8abf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c63f1c5b-bb3d-4c1e-be5f-84836cda6863"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a86d73e3-665a-41eb-afd0-c13f73a20373"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1999SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1999",
				UId = new Guid("c18b2767-61c3-4d96-9e45-abb097b56ceb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(197, 101),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("250bb5ee-b9c0-4d00-bad1-d0c20dc48f86"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b9660650-7ef5-4d5e-a4e9-80c204291f49"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4999SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4999",
				UId = new Guid("0da2921a-1015-4a06-8b30-6dce1badac45"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(428, 298),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8e46837d-4bf7-4810-be0e-6affdcaf55d2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("98a48d13-4b90-401b-8f46-2f4c826f9523"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1444SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1444",
				UId = new Guid("19a66627-6d63-4562-bca0-174090e1e7d3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a792b5a1-ca0f-4a49-88b4-33b6c7faa4d2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe07fc28-9298-423c-a1e0-c682cda2eea8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2555SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2555",
				UId = new Guid("ac155033-ff56-4b6b-8e7d-5430566ef896"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CurveCenterPosition = new Point(332, 1660),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe07fc28-9298-423c-a1e0-c682cda2eea8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet14LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet14 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("56a7d37f-36e3-42a3-990f-cb7b718339af"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"LaneSet14",
				Position = new Point(5, 5),
				Size = new Size(789, 535),
				UseBackgroundMode = false
			};
			return schemaLaneSet14;
		}

		protected virtual ProcessSchemaLane CreateDuplicatesContextMenuLaneLane() {
			ProcessSchemaLane schemaDuplicatesContextMenuLane = new ProcessSchemaLane(this) {
				UId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("56a7d37f-36e3-42a3-990f-cb7b718339af"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"DuplicatesContextMenuLane",
				Position = new Point(29, 0),
				Size = new Size(760, 535),
				UseBackgroundMode = false
			};
			return schemaDuplicatesContextMenuLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2999EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2999 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a508a678-3792-401f-9fe8-069fdbadb470"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"EventSubProcess2999",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(458, 170),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2999;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareOpenRightsPageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b9660650-7ef5-4d5e-a4e9-80c204291f49"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a508a678-3792-401f-9fe8-069fdbadb470"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"PrepareOpenRightsPageScriptTask",
				Position = new Point(176, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,201,40,202,47,119,45,75,205,43,209,80,114,76,201,205,204,11,202,76,207,40,241,77,205,43,245,44,73,205,117,206,201,76,206,86,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,108,136,197,69,56,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateConfigureDuplicatesRightsMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("250bb5ee-b9c0-4d00-bad1-d0c20dc48f86"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a508a678-3792-401f-9fe8-069fdbadb470"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ConfigureDuplicatesRightsMenuItemClick",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ConfigureDuplicatesRightsMenuItemClickStartMessage",
				Position = new Point(50, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5999EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5999 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b0e2a183-4619-409e-a533-14d1d7fccc06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"EventSubProcess5999",
				Position = new Point(36, 184),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(459, 162),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5999;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartDuplicatesSearchMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c63f1c5b-bb3d-4c1e-be5f-84836cda6863"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b0e2a183-4619-409e-a533-14d1d7fccc06"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"StartDuplicatesSearchMenuItemClick",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"StartDuplicatesSearchMenuItemClickStartMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateStartDuplicatesSearchMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a86d73e3-665a-41eb-afd0-c13f73a20373"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b0e2a183-4619-409e-a533-14d1d7fccc06"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"StartDuplicatesSearchMenuItemClickScriptTask",
				Position = new Point(176, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,240,129,10,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,5,151,36,22,149,184,148,22,228,100,38,39,150,164,22,7,167,38,22,37,103,40,105,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,62,70,20,22,81,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6999EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6999 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f8cfcc2c-3523-42d9-ab4e-7612cec2ec7c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"EventSubProcess6999",
				Position = new Point(36, 352),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(459, 169),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6999;
		}

		protected virtual ProcessSchemaScriptTask CreateConfigureDuplicatesMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("98a48d13-4b90-401b-8f46-2f4c826f9523"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8cfcc2c-3523-42d9-ab4e-7612cec2ec7c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ConfigureDuplicatesMenuItemClickScriptTask",
				Position = new Point(176, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,240,129,10,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,57,231,231,165,101,166,151,22,165,6,167,38,22,37,103,40,105,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,182,236,193,94,75,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateConfigureDuplicatesMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8e46837d-4bf7-4810-be0e-6affdcaf55d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8cfcc2c-3523-42d9-ab4e-7612cec2ec7c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ConfigureDuplicatesMenuItemClick",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ConfigureDuplicatesMenuItemClickStartMessage",
				Position = new Point(43, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateFolderGridNodesDropSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaFolderGridNodesDropSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("11c02834-8890-463e-9269-0c5619eb620f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"FolderGridNodesDropSubProcess",
				Position = new Point(28, 547),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(230, 122),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaFolderGridNodesDropSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFolderGridNodesDropStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d9f30f06-cdaf-40c4-bcb7-1d2d37dc063e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11c02834-8890-463e-9269-0c5619eb620f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FolderGridNodesDrop",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"FolderGridNodesDrop",
				Position = new Point(29, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFolderGridNodesDropScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("51b7c399-dbe2-4c12-a455-c650e3bb1c2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11c02834-8890-463e-9269-0c5619eb620f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"FolderGridNodesDropScript",
				Position = new Point(120, 22),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,75,115,219,54,16,62,203,51,254,15,40,79,224,140,6,233,185,142,221,209,203,25,101,98,199,149,236,228,144,201,1,38,87,18,90,10,116,1,80,178,210,209,127,239,226,193,135,40,42,81,102,90,94,36,2,187,31,246,241,237,46,184,225,138,192,6,164,25,168,165,38,215,132,142,69,98,68,46,185,218,189,213,70,9,185,236,147,252,249,79,72,204,77,156,228,210,192,171,97,143,43,149,111,39,165,210,213,229,197,6,65,112,201,234,191,215,185,100,99,208,160,4,207,196,55,160,212,163,196,213,33,95,34,43,26,125,141,9,215,228,253,64,41,190,67,136,203,11,177,32,212,238,176,81,94,72,67,222,94,147,95,99,162,192,20,74,146,5,207,52,56,41,123,148,225,106,9,102,150,111,207,60,175,146,47,15,253,232,28,186,106,161,77,83,196,147,176,37,239,10,145,210,106,153,125,226,89,1,33,24,55,52,154,166,81,28,7,93,157,172,96,205,239,249,26,80,245,129,47,129,141,185,225,243,188,80,9,176,185,219,100,118,151,205,224,37,227,9,208,232,54,207,82,80,81,159,204,29,30,155,172,95,204,174,132,67,139,133,217,121,189,59,46,17,79,149,184,1,236,96,239,65,229,27,129,104,236,29,152,176,68,163,201,49,70,228,188,238,216,184,242,81,159,234,187,34,51,194,155,22,147,127,46,47,122,214,154,133,123,71,53,21,180,208,150,14,11,237,233,83,169,13,151,9,12,119,214,91,26,124,27,229,50,225,134,214,65,234,147,104,42,67,4,92,12,221,57,73,161,20,226,62,97,14,81,195,240,196,184,76,56,183,195,162,4,71,74,54,170,69,89,37,91,226,72,71,8,76,0,60,10,12,249,125,190,181,59,151,23,4,159,58,186,15,92,161,37,6,84,149,238,63,10,80,245,50,141,188,220,12,22,152,165,6,57,172,189,37,212,203,143,64,190,23,1,228,79,223,113,172,78,126,137,171,96,225,211,52,202,179,98,45,29,243,2,187,142,178,193,188,140,182,241,15,113,47,217,21,179,150,254,225,17,94,223,139,4,244,6,145,127,185,38,209,167,237,124,167,145,94,9,104,29,145,223,201,15,220,33,191,181,84,108,224,231,144,97,214,8,188,10,109,80,217,155,166,195,170,15,154,127,161,29,153,46,61,160,183,133,76,124,71,8,149,199,6,154,70,51,72,114,149,106,183,142,222,122,239,8,185,85,249,154,30,7,202,90,90,9,125,94,129,2,122,42,208,49,155,234,201,223,5,207,232,17,91,234,99,200,64,166,180,35,142,181,114,131,31,174,246,188,163,174,129,89,253,69,174,128,39,43,66,67,227,36,66,18,223,250,86,34,75,145,225,52,246,101,216,243,25,179,206,30,118,39,117,186,47,5,27,155,28,245,162,168,95,66,53,196,10,141,234,222,146,244,121,242,10,73,97,114,219,117,90,149,55,145,186,80,48,30,214,75,214,70,107,36,105,60,1,108,106,187,224,12,56,230,129,164,245,223,235,110,50,48,127,42,120,41,90,91,225,131,64,90,79,13,200,236,15,109,250,92,62,182,171,117,245,143,241,240,113,247,2,184,176,1,133,145,193,119,23,153,199,124,138,252,170,129,191,28,18,12,167,198,13,14,163,227,99,240,177,51,81,200,2,90,70,236,235,215,125,153,199,6,49,61,247,186,171,26,169,97,192,11,208,86,81,92,245,122,22,236,8,136,205,193,140,97,209,224,178,118,97,57,33,218,144,235,168,150,7,37,214,56,253,189,16,243,85,238,186,213,61,108,29,247,226,51,161,35,239,74,250,81,98,35,197,230,252,147,106,195,29,50,186,223,57,29,206,69,186,203,83,177,16,63,111,65,169,247,31,152,224,153,238,96,90,179,228,12,237,142,30,211,175,106,248,36,6,223,128,207,62,50,111,79,0,111,78,213,72,95,231,105,145,65,243,38,112,246,76,175,155,126,53,184,253,217,135,115,164,113,171,177,98,7,157,46,113,146,182,217,29,219,81,78,179,208,247,108,1,123,113,44,242,5,118,108,52,196,11,62,217,70,120,242,178,245,100,27,174,67,232,117,88,151,212,156,118,193,235,61,163,117,127,185,191,123,31,47,119,112,91,147,125,0,185,52,43,215,4,60,120,7,246,225,136,108,11,244,93,123,14,73,233,253,175,253,191,119,148,105,84,236,10,248,247,26,77,153,131,166,30,187,5,147,172,236,140,29,15,105,197,194,50,220,7,146,157,77,166,73,226,163,90,104,233,87,28,46,19,179,247,55,228,23,127,193,56,158,79,211,112,245,152,200,165,144,96,249,27,22,134,59,228,4,253,128,115,7,36,94,153,145,54,97,227,41,28,29,32,27,95,53,180,92,194,169,0,74,242,108,228,63,124,240,182,131,100,84,160,87,99,48,92,100,26,51,250,230,77,40,241,1,218,177,1,244,104,180,226,114,9,62,219,225,243,197,40,28,16,255,2,102,233,8,181,106,13,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a36eaca1-c81e-4b08-b116-b1347e4762c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"SubProcess3",
				Position = new Point(35, 695),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(369, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAdminRightMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c7f8ccc3-bdb5-4319-af46-8d7a249b29c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a36eaca1-c81e-4b08-b116-b1347e4762c3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AdminRightMenuItemClick",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"AdminRightMenuItemClick",
				Position = new Point(29, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAdminRightMenuItemClick2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b7443b26-dc60-4d72-a6bb-74cb3a8d8b02"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a36eaca1-c81e-4b08-b116-b1347e4762c3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptAdminRightMenuItemClick2",
				Position = new Point(127, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,74,45,72,44,74,117,76,201,205,204,11,202,76,207,40,9,207,204,75,201,47,247,47,72,205,75,45,210,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,149,9,46,229,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskAdminRightOpenWindowUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7471bea1-220a-4d86-a6c9-fc5e2abcdcd5"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a36eaca1-c81e-4b08-b116-b1347e4762c3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"UserTaskAdminRightOpenWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 36),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskAdminRightOpenWindowParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessAddSearchFolderMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessAddSearchFolderMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("57763886-6b82-49ed-ba97-1653b2fc1a17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"SubProcessAddSearchFolderMenuItemClick",
				Position = new Point(36, 842),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(468, 148),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessAddSearchFolderMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddSearchFolderMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("65c6c34e-67f1-4588-a71d-bf1d1d3e1c5f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57763886-6b82-49ed-ba97-1653b2fc1a17"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddSearchFolderMenuItemClick",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"AddSearchFolderMenuItemClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAddSearchFolderMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("317f1bba-4367-4759-a955-ae37a5ebda2c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57763886-6b82-49ed-ba97-1653b2fc1a17"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptAddSearchFolderMenuItemClick",
				Position = new Point(105, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,65,107,2,49,16,133,207,221,95,17,114,74,64,130,119,107,161,108,85,60,84,108,215,182,7,241,16,204,168,129,221,196,206,38,150,165,244,191,55,217,104,89,187,158,2,147,153,111,230,189,119,146,72,42,105,228,30,144,140,201,91,13,152,91,99,96,235,180,53,98,6,174,216,30,160,146,207,169,131,209,137,113,218,53,87,69,202,137,172,201,141,143,81,118,10,112,232,124,188,120,192,38,172,49,240,117,53,208,214,217,249,140,1,161,83,91,42,192,85,115,4,202,19,229,136,186,146,216,228,182,244,149,89,200,10,2,165,71,22,143,74,165,14,214,255,123,181,246,44,38,202,90,254,231,49,206,69,124,71,36,235,207,78,117,233,0,235,200,191,65,206,17,164,131,212,243,161,221,97,41,49,128,226,0,75,197,220,86,71,137,186,182,38,74,18,147,79,47,203,160,50,183,10,104,120,11,144,184,61,80,206,59,134,105,168,111,42,12,167,39,227,194,229,101,74,137,93,135,22,40,122,71,216,133,34,114,235,141,35,227,49,25,114,242,157,221,33,56,143,134,56,244,48,202,126,178,153,215,138,236,254,236,158,171,203,214,48,186,30,110,226,190,88,63,219,250,46,75,15,247,113,230,129,245,18,9,139,159,96,215,182,212,45,39,184,149,130,100,221,5,131,54,253,200,96,225,232,19,160,19,43,91,56,212,102,207,150,33,127,177,66,128,25,106,37,10,136,10,65,45,130,79,237,49,137,189,166,115,69,55,60,218,213,21,243,11,150,9,149,30,201,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskAddSearchFolderOpenWindowUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4f3be91f-987f-4367-9350-7636a95be591"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57763886-6b82-49ed-ba97-1653b2fc1a17"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"UserTaskAddSearchFolderOpenWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(358, 31),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskAddSearchFolderOpenWindowParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrepareAddSearchFolderWindowOpenerScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1ed6d5fe-5867-40d5-bfc2-f0bb25bbf2f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57763886-6b82-49ed-ba97-1653b2fc1a17"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptPrepareAddSearchFolderWindowOpener",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,74,45,72,44,74,117,76,73,9,78,77,44,74,206,112,203,207,73,73,45,10,207,207,75,201,47,247,47,72,205,75,45,210,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,205,140,229,223,50,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessAddGeneralFolderMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessAddGeneralFolderMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("612ce8dd-cd6f-4cbc-96f6-7d028a38d6dc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"SubProcessAddGeneralFolderMenuItemClick",
				Position = new Point(36, 996),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(474, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessAddGeneralFolderMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddGeneralFolderMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5f77193e-d1a6-42db-8741-9451e7c98807"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("612ce8dd-cd6f-4cbc-96f6-7d028a38d6dc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddGeneralFolderMenuItemClick",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"AddGeneralFolderMenuItemClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAddGeneralFolderMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3740380c-84d5-4a94-849b-806f9387f388"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("612ce8dd-cd6f-4cbc-96f6-7d028a38d6dc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptAddGeneralFolderMenuItemClick",
				Position = new Point(78, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,146,77,107,2,49,16,134,207,221,95,17,114,74,64,130,119,107,161,108,117,241,80,177,213,182,7,241,16,204,168,129,221,196,206,38,150,165,244,191,55,217,104,89,187,158,2,243,241,204,188,239,228,36,145,84,210,200,61,32,25,147,183,26,48,183,198,192,214,105,107,68,1,110,185,61,64,37,159,83,5,163,19,227,180,107,174,130,148,19,89,147,27,137,81,118,10,112,232,36,94,60,96,19,198,24,248,186,106,104,227,236,188,198,128,208,169,45,21,224,170,57,2,229,137,114,68,93,73,108,114,91,250,202,204,101,5,129,210,35,139,71,165,82,5,235,231,94,173,61,139,137,178,22,255,121,140,115,17,223,17,201,250,189,83,93,58,192,58,242,111,144,115,4,233,32,213,124,104,119,88,72,12,160,216,192,82,48,183,213,81,162,174,173,137,146,196,228,211,203,50,168,204,173,2,26,222,2,12,160,44,41,231,29,199,52,212,55,37,134,221,147,115,97,245,50,157,137,93,95,45,80,244,142,176,11,69,228,214,27,71,198,99,50,228,228,59,187,67,112,30,13,113,232,97,148,253,100,133,215,138,236,254,252,158,169,203,212,208,186,30,110,226,188,24,63,251,250,46,75,15,247,177,231,129,245,78,18,6,63,193,174,45,169,91,78,176,43,93,146,117,7,12,218,243,71,6,11,75,159,0,157,88,217,165,67,109,246,108,17,62,128,88,33,64,129,90,137,37,68,133,160,230,193,168,118,153,196,94,211,153,162,27,30,237,234,138,249,5,109,200,45,98,202,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrepareAddGeneralFolderWindowOpenerScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("be40bd54-4041-412c-9384-a4afc3b9ab23"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("612ce8dd-cd6f-4cbc-96f6-7d028a38d6dc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptPrepareAddGeneralFolderWindowOpener",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,74,45,72,44,74,117,76,73,113,79,205,75,45,74,204,113,203,207,73,73,45,10,207,207,75,201,47,247,47,0,137,105,104,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,185,96,56,114,51,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskAddGeneralFolderOpenWindowUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e3de504c-8550-45c9-83b6-2ddacaddb790"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("612ce8dd-cd6f-4cbc-96f6-7d028a38d6dc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"UserTaskAddGeneralFolderOpenWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(365, 39),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskAddGeneralFolderOpenWindowParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessEditMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessEditMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("de95c257-cb3a-4780-823c-8916c9f87fb5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"SubProcessEditMenuItemClick",
				Position = new Point(35, 1430),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(395, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessEditMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEditMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bb5fa926-6eab-4345-a2e5-f57db3b51fb8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de95c257-cb3a-4780-823c-8916c9f87fb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EditMenuItemClick",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"EditMenuItemClick",
				Position = new Point(28, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptEditMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5b735056-cd06-40f7-bbdc-e2766f6e42da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de95c257-cb3a-4780-823c-8916c9f87fb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptEditMenuItemClick",
				Position = new Point(147, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,205,142,155,48,16,190,231,41,44,46,144,77,228,84,234,165,42,221,86,109,146,166,57,52,69,34,217,61,172,246,224,226,105,112,5,54,26,204,178,121,251,142,13,40,33,85,180,7,176,153,249,126,102,204,56,65,168,4,194,90,42,251,221,20,18,240,81,105,105,218,95,21,104,192,104,26,79,16,108,131,154,89,108,32,158,44,238,94,4,178,74,28,33,205,114,40,197,79,161,105,143,236,158,37,180,242,149,176,34,53,13,102,192,187,60,31,193,18,52,47,138,44,248,6,108,31,138,130,228,90,44,32,83,231,2,84,210,57,73,22,255,217,58,157,173,174,173,208,25,124,59,29,182,50,90,247,28,218,79,153,168,217,153,223,105,82,171,162,220,74,18,219,52,74,242,29,180,110,141,166,124,111,82,139,74,31,93,199,43,149,89,101,180,192,211,167,218,7,231,230,247,95,200,236,231,142,78,100,13,45,187,137,114,18,30,200,191,74,25,5,22,1,54,168,228,86,6,243,238,148,246,125,132,47,11,5,218,110,87,99,2,66,102,208,195,199,232,20,10,146,7,185,51,18,234,167,119,207,252,65,20,13,237,110,156,124,130,170,164,226,150,166,104,74,205,119,162,132,231,177,15,89,43,123,234,208,7,95,221,122,28,33,184,215,62,212,128,75,163,53,248,134,135,79,11,175,214,11,245,103,58,247,235,192,217,67,89,221,0,14,16,10,165,25,170,202,70,129,251,53,13,22,116,178,97,110,153,173,62,46,22,33,155,177,214,143,34,47,76,38,188,115,110,106,75,225,112,241,160,160,245,26,162,174,94,191,40,121,239,208,97,64,175,139,1,96,179,73,224,226,221,143,229,127,208,148,203,92,80,69,18,162,247,31,166,142,225,38,234,162,74,34,157,149,134,81,153,177,55,101,130,14,20,15,83,75,125,244,165,27,186,70,17,117,54,103,97,72,79,171,164,205,207,22,227,9,231,143,46,75,97,111,23,206,115,80,199,220,222,68,255,240,105,15,159,198,62,121,49,4,84,129,163,92,143,198,48,112,142,21,7,236,250,118,223,45,254,1,198,46,105,148,14,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskEditFolderOpenWindowUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ff4e1cb7-3161-46af-a5eb-b85c5ba4b933"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de95c257-cb3a-4780-823c-8916c9f87fb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"UserTaskEditFolderOpenWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(287, 41),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskEditFolderOpenWindowParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAddSubEmailFolderMenuItemClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAddSubEmailFolderMenuItemClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("35cb30a9-9bfb-4651-b272-cfd370c4a3a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"AddSubEmailFolderMenuItemClickEventSubProcess",
				Position = new Point(35, 1584),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(398, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAddSubEmailFolderMenuItemClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddSubEmailFolderMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a792b5a1-ca0f-4a49-88b4-33b6c7faa4d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35cb30a9-9bfb-4651-b272-cfd370c4a3a8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddSubEmailFolderMenuItemClick",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"AddSubEmailFolderMenuItemClickStartMessage",
				Position = new Point(29, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddSubEmailFolderMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fe07fc28-9298-423c-a1e0-c682cda2eea8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35cb30a9-9bfb-4651-b272-cfd370c4a3a8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"AddSubEmailFolderMenuItemClickScriptTask",
				Position = new Point(148, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,81,79,219,48,16,126,94,165,254,7,147,7,148,72,149,217,51,48,36,150,22,84,105,91,139,90,182,7,196,131,23,95,193,194,177,187,179,83,86,161,254,247,157,157,134,164,45,160,37,15,113,124,247,125,119,190,251,206,43,129,12,140,87,126,61,43,30,161,20,55,21,224,154,125,97,6,158,217,104,127,63,189,117,128,185,53,6,10,175,172,225,93,135,239,194,136,7,192,1,75,174,172,150,128,243,245,18,146,236,172,223,59,96,231,83,84,165,192,117,252,201,173,174,74,195,199,238,82,63,139,181,155,129,38,110,138,239,177,130,55,193,87,74,123,64,199,47,165,76,15,173,57,130,240,80,251,252,82,254,113,42,80,148,16,0,105,189,153,219,114,41,80,57,107,66,130,124,244,167,18,154,114,206,173,132,132,190,179,234,247,168,20,74,39,89,72,125,155,141,107,146,58,140,119,13,190,118,122,171,62,129,226,186,82,146,45,94,43,50,150,68,83,243,241,209,95,40,42,15,179,66,104,129,231,193,241,34,13,16,181,96,105,23,65,197,25,149,75,191,78,179,140,189,244,123,159,16,124,133,166,169,208,166,223,235,247,134,176,248,41,116,5,46,242,83,105,234,30,236,208,12,98,79,67,152,148,82,92,1,122,62,183,51,143,202,60,164,83,106,29,159,35,192,53,42,201,235,19,129,252,65,69,113,119,159,239,121,205,125,151,140,101,114,159,197,202,132,247,228,132,205,39,195,201,41,43,197,19,48,193,168,206,143,86,158,246,123,43,210,20,66,97,81,198,116,66,72,30,79,64,192,174,100,110,163,57,198,30,10,47,102,182,194,2,248,171,237,172,102,90,146,125,71,98,239,98,248,142,219,20,237,74,209,233,67,143,182,91,105,50,221,39,139,18,13,97,64,42,223,90,41,198,65,220,64,52,54,206,11,83,192,215,53,37,152,142,182,24,90,103,76,56,214,226,137,148,186,208,168,169,238,70,16,199,92,184,39,62,89,130,1,108,168,98,17,154,159,250,216,239,67,105,145,87,136,36,196,75,146,216,10,66,196,118,90,222,199,109,179,36,215,78,206,175,5,110,102,132,204,172,223,99,241,9,98,25,170,168,99,154,213,115,23,133,50,96,245,247,34,8,145,117,158,151,164,105,56,77,81,179,108,245,149,109,6,251,254,176,43,4,130,237,73,227,67,180,223,106,53,2,119,213,155,107,69,220,227,225,166,193,108,226,76,165,221,25,57,162,11,174,210,154,29,31,179,163,206,254,254,164,181,149,137,215,77,34,91,87,10,219,5,182,185,102,245,76,126,220,138,105,183,228,109,148,15,91,152,211,169,0,65,254,79,187,115,109,29,212,50,155,152,111,86,4,208,66,104,7,113,116,187,23,200,63,158,227,134,105,0,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddSubEmailFolderUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("afd31d21-843c-4a0a-82e9-68b56028bc0b"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35cb30a9-9bfb-4651-b272-cfd370c4a3a8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"AddSubEmailFolderUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(288, 42),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeAddSubEmailFolderUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitializeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitializeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c34616c9-37dd-476a-ac3d-968c884a65bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"InitializeEventSubProcess",
				Position = new Point(273, 1871),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(176, 100),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitializeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitializeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("012dfa4c-e543-44bd-abfd-f0828f1ff2ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c34616c9-37dd-476a-ac3d-968c884a65bf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"Initialize",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"Initialize",
				Position = new Point(22, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitializeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a4568cf3-7a38-4050-8749-6514fcb6712a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c34616c9-37dd-476a-ac3d-968c884a65bf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptInitialize",
				Position = new Point(92, 14),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,77,111,219,48,12,61,39,64,254,131,151,147,123,152,128,237,58,228,144,230,163,11,208,110,65,146,118,199,65,181,232,132,128,44,121,250,88,225,13,249,239,163,44,39,113,234,54,29,182,147,97,146,239,241,241,73,212,146,111,129,109,12,192,141,65,193,22,5,253,222,162,117,201,40,25,110,192,24,110,117,238,216,55,120,28,151,229,240,211,160,255,147,155,68,112,199,215,218,155,12,168,106,25,240,211,99,132,74,48,79,210,83,9,91,103,59,40,120,50,26,37,202,75,121,149,252,30,244,123,157,244,253,66,16,215,76,57,116,213,49,66,92,251,65,191,85,27,122,173,244,147,157,104,175,130,194,247,31,168,36,130,78,10,238,29,74,116,8,150,45,20,125,185,196,95,48,246,78,79,33,95,59,227,51,231,13,180,244,93,17,197,212,151,18,51,238,192,206,181,20,96,106,49,55,224,186,241,52,148,215,35,143,69,129,106,133,219,157,187,3,229,23,14,10,54,83,252,81,66,192,46,108,157,38,31,13,161,197,117,181,130,76,27,97,47,128,63,163,16,160,8,251,238,45,240,68,171,28,183,52,197,73,94,151,229,165,145,104,38,79,103,60,43,74,87,29,200,214,142,155,214,156,107,224,38,219,253,19,93,184,25,121,157,220,84,37,76,180,244,69,64,182,142,111,226,141,1,229,142,167,192,98,145,101,115,84,52,230,23,94,64,58,156,31,41,134,193,235,231,140,140,220,145,79,188,34,165,18,178,112,9,136,13,154,246,217,179,6,151,219,55,32,178,22,76,32,87,111,234,29,11,17,85,92,87,75,238,118,109,177,236,107,160,169,37,183,9,95,149,155,107,3,60,219,37,105,173,59,154,133,234,111,220,162,13,234,209,10,101,7,59,30,208,34,93,59,162,110,66,193,71,54,251,225,185,180,233,48,252,212,170,122,152,167,47,21,156,70,248,222,140,16,87,244,208,160,14,46,181,165,85,210,193,159,176,114,231,201,41,26,26,45,102,207,3,108,108,51,80,2,213,54,128,246,175,138,232,60,7,108,105,176,224,166,154,162,45,37,175,38,39,72,80,215,235,93,208,247,241,127,244,237,227,235,69,43,120,231,165,195,232,77,244,163,217,91,17,55,36,102,186,123,210,156,238,249,179,117,171,185,8,207,86,253,120,24,160,195,84,177,240,15,187,21,34,186,124,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3c5cf510-94ae-458e-9f0d-fac4626edf83"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"PageLoadCompleteSubProcess",
				Position = new Point(35, 1871),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(229, 102),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("20ca36b7-a82c-4fc8-a646-da0531fb57d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3c5cf510-94ae-458e-9f0d-fac4626edf83"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptPageLoadComplete",
				Position = new Point(120, 14),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,79,79,219,64,16,197,207,70,226,59,12,62,128,45,18,147,0,5,42,20,169,73,8,16,169,169,40,46,244,80,245,176,241,78,146,21,246,46,221,63,137,162,40,223,189,179,14,137,2,33,84,234,193,7,219,191,153,247,102,246,237,29,27,98,242,67,35,222,104,193,147,116,164,38,169,43,10,166,5,154,30,74,7,13,24,176,220,224,229,238,206,221,6,217,116,86,253,20,220,142,254,73,246,92,110,197,87,33,241,67,242,187,19,217,211,163,192,73,79,113,36,106,249,227,213,247,228,155,146,190,116,67,198,106,241,140,247,106,98,182,246,191,21,220,3,45,165,57,106,143,89,237,86,212,21,179,44,85,78,103,152,116,36,235,231,152,162,30,163,110,102,86,140,125,213,118,220,191,123,221,182,114,210,18,86,173,19,212,53,77,94,8,41,140,213,204,34,111,77,239,49,35,221,117,115,98,0,209,94,71,90,97,167,105,54,194,130,61,116,121,210,249,227,232,119,116,227,200,111,167,120,182,211,24,246,247,225,173,228,130,135,70,3,164,203,243,24,102,187,59,193,54,6,30,12,234,182,146,18,105,20,37,147,117,197,30,147,84,165,147,27,180,93,105,44,147,25,182,166,100,35,122,99,43,38,187,243,133,227,45,50,123,235,86,62,24,254,253,242,228,125,158,84,131,14,23,214,23,145,11,42,151,56,1,191,27,136,194,218,217,241,49,14,234,89,181,222,63,235,87,79,207,207,251,213,207,167,167,39,213,62,175,93,244,47,240,211,249,241,201,89,232,141,7,155,41,184,69,182,30,129,160,156,110,119,135,244,133,28,130,201,40,74,182,165,248,148,128,48,164,22,3,165,145,101,35,136,198,76,67,65,25,238,90,44,64,72,120,221,218,167,59,158,81,183,64,12,162,37,150,180,115,129,210,118,175,252,113,109,242,191,106,191,87,68,236,151,23,172,201,31,54,224,75,8,225,225,70,175,195,48,49,104,31,133,17,148,212,200,15,17,95,130,119,26,204,1,41,94,240,159,157,202,108,174,90,209,83,110,230,101,47,90,77,218,35,38,135,200,175,157,204,192,119,156,213,230,137,146,209,129,193,124,17,175,172,4,14,42,48,32,196,127,136,76,5,144,98,225,13,205,234,212,108,62,175,128,29,9,19,95,134,229,53,62,58,2,127,189,22,133,220,47,117,130,248,4,67,90,208,203,93,107,114,158,150,147,68,105,105,36,185,86,186,96,54,122,237,167,242,102,185,203,1,43,107,231,25,199,165,164,70,235,180,92,156,253,95,46,56,93,74,1,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("656c3b3a-948f-49c3-96bb-8f2814b40359"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3c5cf510-94ae-458e-9f0d-fac4626edf83"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"PageLoadComplete",
				Position = new Point(29, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8f22a548-d6ab-4286-9bd6-2204076df9d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"InitSubProcess",
				Position = new Point(28, 1752),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(169, 107),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7c16b35b-a77d-4fc8-83c9-795e2cd0e73d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f22a548-d6ab-4286-9bd6-2204076df9d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"Init",
				Position = new Point(15, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("819500cd-cad5-4a5f-b839-ba35e5ac2b28"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f22a548-d6ab-4286-9bd6-2204076df9d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"InitScript",
				Position = new Point(85, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,77,143,155,72,16,61,103,126,69,135,19,214,26,4,6,99,91,35,175,100,48,158,88,26,205,88,227,73,114,88,237,161,3,53,152,8,119,123,187,97,38,163,85,254,123,170,249,48,216,102,146,221,189,236,209,93,175,94,189,238,170,122,120,67,19,48,31,5,192,141,72,99,243,6,242,7,254,18,112,246,148,38,31,40,139,51,16,100,78,240,116,197,179,24,196,49,118,125,181,81,121,75,154,211,45,47,68,4,166,15,79,92,192,3,236,249,51,32,140,252,54,39,49,100,144,208,28,116,254,229,43,68,57,145,192,144,99,72,218,172,240,25,88,190,16,137,36,48,32,127,95,189,123,166,130,28,68,116,155,202,28,24,8,25,240,172,216,179,59,186,7,84,241,81,130,192,234,12,169,82,206,204,245,70,240,8,164,12,89,146,50,48,235,95,61,169,215,21,175,204,69,17,229,133,80,84,231,226,131,66,8,84,178,109,32,215,111,73,193,220,35,143,89,29,73,115,149,178,216,127,85,165,244,126,241,3,228,75,159,72,79,148,204,231,132,21,89,86,222,190,172,25,93,214,89,196,113,133,246,95,55,52,223,253,164,200,187,42,219,92,203,79,169,76,191,100,234,174,79,52,147,112,18,91,100,47,244,85,110,177,59,216,148,57,193,58,42,254,157,0,2,75,29,151,5,250,25,123,113,111,176,95,125,191,156,153,91,78,99,136,213,168,108,78,166,80,65,170,216,207,114,254,253,120,69,156,229,240,45,55,31,119,130,191,180,193,57,81,10,219,67,189,198,13,137,214,114,169,186,56,215,82,195,119,238,185,202,226,43,253,86,38,75,115,129,243,89,238,64,176,163,44,129,216,44,207,149,98,189,145,136,114,230,191,43,69,62,149,112,142,175,247,78,239,47,212,232,120,0,121,224,76,226,198,37,170,5,162,122,147,254,10,111,231,52,181,218,180,222,162,27,1,7,42,96,149,102,152,37,255,251,110,23,184,194,235,248,114,151,235,253,83,167,230,58,174,183,79,117,129,70,249,175,240,65,3,171,211,98,180,32,21,80,125,101,240,66,110,138,52,254,227,207,114,174,155,159,186,102,251,174,63,115,70,99,195,243,130,192,88,174,108,219,152,249,163,133,97,89,246,210,179,194,153,51,13,60,109,48,60,201,9,237,153,239,132,222,212,88,57,158,111,216,174,109,25,51,111,230,24,35,43,88,57,214,52,8,194,192,57,207,241,220,49,70,156,177,225,7,174,111,132,22,214,153,122,246,68,213,25,143,151,150,235,140,44,87,27,224,122,212,14,241,254,168,190,186,87,202,164,94,61,218,160,178,8,1,104,9,172,92,168,234,182,199,247,190,180,181,30,227,139,127,233,121,74,64,221,231,218,119,181,101,123,164,93,162,78,89,149,23,214,129,27,193,139,67,237,139,103,172,141,33,118,105,222,119,157,176,53,191,58,108,86,95,150,110,198,160,122,133,83,41,29,119,22,128,243,217,213,114,174,98,72,110,121,146,70,52,187,63,128,160,106,176,240,49,210,40,55,239,133,226,238,160,149,5,235,253,212,159,211,124,183,161,2,233,20,80,239,60,197,54,218,193,158,14,73,133,11,248,30,87,40,149,156,61,190,30,192,12,255,42,104,134,6,83,81,225,231,67,27,182,3,63,248,95,202,183,83,59,26,5,227,177,107,225,98,204,124,219,112,103,225,202,152,134,254,196,152,140,92,220,129,201,52,28,79,2,109,240,143,84,174,229,29,54,181,66,244,169,235,40,40,249,46,27,175,88,79,187,142,203,162,174,195,153,50,152,198,119,201,61,171,254,163,168,47,200,29,143,65,46,5,63,144,243,79,75,199,167,143,160,235,171,222,92,115,155,38,140,102,205,22,244,32,112,27,80,221,82,208,68,253,42,105,203,94,72,189,151,16,165,87,235,91,125,20,127,0,204,115,22,25,122,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessRemoveMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessRemoveMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8c4dd765-8e50-4da8-9d05-e24776dbc422"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"SubProcessRemoveMenuItemClick",
				Position = new Point(44, 1159),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(316, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessRemoveMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRemoveMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3feb751e-08ae-4ad2-8ab1-e80600f61a78"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c4dd765-8e50-4da8-9d05-e24776dbc422"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RemoveMenuItemClick",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"RemoveMenuItemClick",
				Position = new Point(36, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptRemoveMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2293c1e5-49f2-4d45-9907-8bc2106aa34e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c4dd765-8e50-4da8-9d05-e24776dbc422"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptRemoveMenuItemClick",
				Position = new Point(99, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,207,187,10,131,64,16,5,208,58,126,197,176,181,228,7,242,40,130,22,22,209,196,71,97,41,102,16,33,236,134,153,145,68,196,127,207,46,46,68,211,236,101,57,119,96,166,98,164,43,50,55,29,238,111,246,129,19,184,56,4,213,10,124,150,248,17,235,17,62,81,48,199,214,208,195,203,182,158,180,70,219,158,186,87,113,81,38,89,170,182,124,25,68,140,102,215,168,227,34,205,254,56,71,126,89,70,255,119,61,141,111,136,250,86,122,163,27,26,143,44,212,235,46,132,37,207,48,5,187,73,141,200,42,4,181,44,87,35,251,113,53,135,78,181,249,97,106,86,54,31,2,66,25,72,131,208,96,239,248,2,106,177,45,95,16,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f223c513-1c64-40c8-87c4-e9fb59ce3f68"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c4dd765-8e50-4da8-9d05-e24776dbc422"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"UserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 35),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDeleteYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDeleteYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1637cbaa-3d9f-4d92-ac5f-febb0fa8b521"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"EventSubProcessDeleteYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(373, 1159),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 139),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDeleteYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteYesMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1cd729fa-cd46-4ebd-83a7-41680ff0825e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1637cbaa-3d9f-4d92-ac5f-febb0fa8b521"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"DeleteYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteYesMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9a5f5233-a13f-40a2-aa6a-c3100b36f55e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1637cbaa-3d9f-4d92-ac5f-febb0fa8b521"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptDeleteYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,86,223,111,218,48,16,126,14,127,133,203,195,100,36,20,245,29,117,82,75,105,87,109,173,58,160,235,67,213,7,55,57,192,90,176,153,237,176,161,173,255,251,206,63,18,28,2,237,166,245,105,72,36,96,159,191,251,238,238,187,75,214,76,17,13,5,100,6,242,27,153,131,38,39,228,150,205,33,157,42,128,75,197,243,116,18,239,14,58,124,70,104,227,64,58,148,165,48,228,61,57,238,145,159,157,68,27,197,197,156,172,20,95,50,181,25,67,38,85,254,133,21,37,12,58,201,26,157,229,204,176,137,44,85,6,149,167,243,122,5,77,102,82,1,203,22,132,90,91,129,248,132,139,38,65,231,37,105,227,35,156,181,79,221,31,253,176,3,157,78,178,5,44,89,122,235,207,13,101,81,46,69,122,195,150,240,152,78,229,196,145,166,61,36,224,72,114,61,150,210,92,200,34,7,133,184,71,17,48,134,43,12,227,66,127,132,13,61,224,228,3,7,197,84,182,168,220,248,155,59,111,61,58,55,54,143,177,27,31,86,226,115,191,80,242,251,104,13,194,208,238,233,147,84,230,28,19,96,96,107,220,117,16,201,19,230,234,171,253,245,28,120,43,62,95,24,79,162,157,221,192,174,138,49,127,154,64,86,42,110,54,35,49,231,162,46,199,157,6,133,49,10,204,56,151,34,61,63,107,154,85,199,145,28,174,253,129,175,32,8,237,22,108,248,104,29,31,118,69,24,196,1,124,130,53,20,104,181,203,48,189,4,51,138,78,250,226,143,235,35,116,235,163,79,4,124,39,151,37,207,105,91,41,189,186,206,217,130,137,57,248,236,162,67,26,185,127,71,166,160,20,211,114,102,176,126,10,131,59,75,247,187,69,73,48,49,140,144,220,86,143,156,156,252,35,68,93,169,55,224,231,97,255,158,148,63,87,9,182,145,175,95,191,2,179,32,93,75,117,230,228,121,149,219,102,124,161,0,131,202,94,0,228,83,181,169,43,96,148,27,20,73,98,191,214,227,209,149,190,46,11,195,27,77,210,18,224,53,19,168,63,219,170,59,234,69,197,52,44,104,119,212,62,214,237,17,166,201,158,141,65,237,108,41,243,178,128,216,36,40,57,111,53,191,221,72,199,176,42,88,6,180,27,250,181,79,124,27,164,163,229,202,108,122,47,1,239,180,71,160,98,35,185,18,218,48,145,193,217,198,250,160,251,57,69,216,190,24,126,248,4,186,49,11,111,216,24,184,153,179,181,35,183,13,30,166,152,174,106,224,5,225,7,220,24,102,160,0,169,121,211,59,43,128,67,51,33,197,221,26,35,217,195,49,219,206,230,65,176,170,7,93,226,103,29,94,147,240,121,33,147,159,75,80,155,160,196,214,250,158,244,133,212,29,0,74,79,243,220,243,164,221,171,28,39,240,46,129,74,251,23,188,48,78,139,135,128,134,24,141,1,111,118,207,205,226,150,41,140,21,255,104,234,23,135,114,185,98,138,107,41,166,155,21,164,163,111,37,43,250,173,114,246,107,143,175,16,247,160,218,6,64,155,36,49,136,125,249,227,238,53,224,16,92,61,133,145,74,225,251,140,54,219,46,240,177,2,105,162,238,188,43,216,207,238,4,152,177,66,195,96,155,89,207,13,180,70,49,221,50,225,30,12,246,17,172,100,113,103,120,225,97,47,184,200,195,162,127,38,159,234,149,187,135,69,253,112,252,216,39,221,51,166,225,58,130,194,182,180,3,199,181,127,188,62,104,136,203,199,17,51,56,66,77,149,69,177,85,113,188,107,211,28,192,232,61,83,2,251,173,79,194,15,63,13,110,164,113,13,24,172,122,77,97,119,170,75,53,2,27,25,170,124,26,84,246,207,6,203,104,18,141,97,41,215,64,119,228,225,241,51,102,108,183,143,126,100,176,114,181,170,130,248,159,242,252,114,102,159,9,94,240,249,6,30,55,102,244,87,25,112,168,111,145,134,206,31,4,255,106,232,55,50,122,117,208,141,12,184,160,49,201,207,157,231,142,2,83,42,17,30,180,191,1,70,210,49,13,254,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDeleteNoMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDeleteNoMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("57b4e2ce-2ce9-4ef5-a16f-73fcfa23f001"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"EventSubProcessDeleteNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 1298),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(197, 107),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDeleteNoMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteNoMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b8c56e8c-48bc-4776-87af-042947a70717"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57b4e2ce-2ce9-4ef5-a16f-73fcfa23f001"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteNoMessage",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"DeleteNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteNoMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5c891633-f17d-4d14-8b49-24d2010e8f6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57b4e2ce-2ce9-4ef5-a16f-73fcfa23f001"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptDeleteNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(91, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAbortDeleteRootFolderEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAbortDeleteRootFolderEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fd8cc239-63d2-4baa-9821-b00982d30637"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07373dda-4748-496c-b90f-3198370d0903"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"AbortDeleteRootFolderEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(44, 1299),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 108),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAbortDeleteRootFolderEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAbortDeleteRootFolderStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fa09c88e-c5cc-4d82-a809-cb78724bf534"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fd8cc239-63d2-4baa-9821-b00982d30637"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AbortDeleteRootFolder",
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"StartMessageAbortDeleteRootFolder",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAbortDeleteRootFolderScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("66bc8d88-dd9a-4fb4-ab7f-79c523ffa08f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fd8cc239-63d2-4baa-9821-b00982d30637"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Name = @"ScriptAbortDeleteRootFolder",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 22),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,65,11,194,48,12,133,207,246,87,196,157,54,40,197,251,216,97,10,187,13,134,40,30,196,67,161,113,20,106,58,154,246,32,226,127,87,70,133,122,74,242,229,229,189,140,200,172,103,156,52,161,131,71,57,116,112,240,20,131,119,231,104,157,141,22,89,13,150,76,134,245,244,21,170,158,151,181,102,200,215,221,77,66,181,215,140,99,97,85,73,136,33,97,3,154,161,228,173,176,119,168,255,66,183,29,80,114,174,129,151,216,148,11,213,27,147,79,235,139,14,100,105,150,144,155,163,247,113,240,206,96,200,10,249,75,57,61,23,84,89,213,180,226,45,2,198,20,104,253,166,253,0,191,218,105,254,250,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateAddFolderMethod());
			Methods.Add(CreateCheckRightsMethod());
			Methods.Add(CreateGetFolderRowConfigMethod());
			Methods.Add(CreateAddDragDropEventParamsMethod());
			Methods.Add(CreatePrepareAdminRightWindowOpenerMethod());
			Methods.Add(CreatePrepareAddSearchFolderWondowOpenerMethod());
			Methods.Add(CreatePrepareAddGeneralFolderWondowOpenerMethod());
			Methods.Add(CreatePrepareEditFolderWindowOpenerMethod());
			Methods.Add(CreateBaseActiveRowChangedHandlerMethod());
			Methods.Add(CreateBaseLoadRowsResponseRegisteredHandlerMethod());
			Methods.Add(CreateGetDuplicatesFolderIdMethod());
			Methods.Add(CreateIsDuplicatesFolderMethod());
			Methods.Add(CreateListenerThrowEventMethod());
			Methods.Add(CreateSetProfileDataMethod());
			Methods.Add(CreateGetProfileDataMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7f31a6a4-bc1c-4fe7-a868-46f41a751cae"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("280266a9-7e7c-426f-889a-c55022bf8dad"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "TerrasoftWebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e7d1a6da-33e5-422f-b521-99a7bd5db9e9"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d0f065b1-fb3f-4bde-97ea-4249e31725db"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateAddFolderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9679b473-f31f-4d63-a7e7-b355fb538a1c"),
				Name = "AddFolder",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b57edf6c-cd8d-4e54-8f36-637f1bf2f5aa"),
				Name = "FolderType",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fc7141ab-9eec-4cc0-a0dd-c63306f51447"),
				Name = "ParentFolderId",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,201,10,194,48,16,134,239,130,239,16,122,106,161,228,5,92,64,20,151,75,41,84,189,136,135,49,25,219,72,155,200,36,81,250,246,166,173,203,193,211,236,255,255,205,3,136,73,188,30,161,246,104,217,140,105,124,178,149,18,78,25,13,212,178,169,117,164,116,153,50,115,185,161,112,243,56,153,140,71,223,125,190,144,50,206,161,68,190,2,7,133,241,36,144,23,162,194,6,248,86,33,1,137,170,93,154,218,55,154,103,208,96,202,114,32,212,110,109,106,137,180,147,255,98,209,48,218,183,119,140,210,95,222,45,62,2,105,160,219,120,37,3,103,23,120,54,148,61,84,143,113,176,72,75,163,53,246,15,240,2,173,13,177,131,59,189,79,249,222,20,253,75,113,114,14,50,95,247,160,64,232,60,233,143,71,104,188,0,65,10,97,224,28,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0241a2df-41e1-4598-908f-4bf641d00376"),
				Name = "CheckRights",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ace74cad-fb13-479c-8edd-830dfbc84053"),
				Name = "selectedIem",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,145,77,106,195,48,16,70,215,13,228,14,194,139,98,67,208,5,138,55,177,211,96,104,74,112,210,3,40,214,23,71,96,75,48,146,13,161,244,238,149,18,55,228,15,74,211,149,97,102,222,232,123,227,94,16,131,118,202,237,87,213,14,173,88,8,45,106,16,75,217,210,127,249,177,200,47,122,75,50,189,146,32,62,135,27,74,113,52,187,221,17,37,76,88,182,6,145,176,102,235,120,102,8,252,48,167,96,249,29,224,101,60,234,175,226,188,139,22,63,89,114,225,196,202,116,84,157,98,133,238,0,201,205,10,85,71,30,156,233,90,233,19,244,97,65,153,209,26,149,83,70,243,124,122,57,54,208,164,234,157,123,67,143,198,115,215,171,130,231,121,218,18,149,33,89,158,144,248,222,67,89,71,228,69,66,149,23,114,114,35,53,97,22,141,159,133,44,208,38,62,134,218,198,241,89,140,231,235,195,229,83,126,255,121,203,51,161,115,191,204,33,97,105,250,24,247,57,30,61,197,7,17,239,224,200,52,201,65,106,77,192,156,148,76,248,171,210,242,172,61,221,7,137,56,42,209,154,30,11,232,174,112,104,163,196,255,86,177,105,32,253,25,29,117,225,188,95,236,191,110,51,169,220,223,205,142,212,163,94,129,254,205,234,27,140,42,93,158,59,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFolderRowConfigMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("38fa46a0-87cc-4d28-97fd-38bba31f1b9f"),
				Name = "GetFolderRowConfig",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceRowConfig"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c6a6fdb9-d01e-4139-ac40-03f8dca1b7a8"),
				Name = "folder",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,150,91,111,155,48,20,199,159,87,169,223,1,229,137,72,53,50,9,16,80,47,18,215,42,210,54,85,77,183,151,105,15,46,56,29,18,183,25,179,54,170,250,221,103,27,115,89,67,219,44,111,145,125,206,239,255,63,112,56,39,53,37,105,241,160,84,36,205,17,217,249,101,214,228,197,87,148,99,229,82,217,150,89,130,137,182,137,127,225,28,105,55,227,8,141,135,156,159,158,212,19,217,223,81,214,140,210,175,49,29,157,171,123,66,115,237,174,220,8,140,58,103,196,63,136,40,113,89,108,211,7,134,40,240,163,18,32,138,54,101,67,98,124,91,62,250,226,70,221,215,227,169,215,77,154,72,213,187,93,245,175,5,126,144,140,226,47,120,240,149,58,139,250,240,117,50,227,144,117,142,30,240,231,180,166,107,138,115,37,101,86,184,143,38,203,164,183,154,34,154,198,67,218,183,117,34,141,114,162,58,115,2,223,140,172,208,2,11,215,210,129,17,132,54,112,161,233,128,32,92,194,200,8,87,70,180,48,102,93,161,53,70,36,254,245,54,204,50,125,23,58,134,5,32,180,13,96,216,43,3,120,186,190,2,190,190,212,29,199,141,150,158,99,246,48,82,150,52,204,81,154,189,195,11,23,203,200,93,88,192,244,194,16,132,80,215,129,107,91,30,195,235,166,25,64,195,135,122,208,243,56,202,43,159,222,41,213,137,23,75,83,143,193,22,110,109,128,117,70,115,146,123,212,210,18,104,234,54,212,135,82,155,251,15,204,121,206,202,53,237,165,5,116,63,128,32,20,56,232,91,157,57,147,185,91,14,197,226,24,23,244,154,148,77,245,54,145,149,19,69,158,97,128,149,1,87,178,92,139,61,77,221,10,236,165,239,122,208,177,161,32,158,158,164,91,69,29,183,206,229,212,187,153,43,207,167,39,159,100,79,220,176,62,209,132,129,190,101,52,222,51,181,22,165,69,226,237,120,111,179,254,74,51,138,9,78,134,64,33,248,162,224,172,198,202,190,234,244,75,60,66,88,64,14,85,157,122,213,71,104,126,105,49,135,170,78,182,196,17,178,27,201,57,68,87,11,127,55,40,171,213,183,250,103,126,132,254,237,192,58,80,61,104,170,44,141,17,197,117,43,126,156,238,64,153,214,254,111,224,107,76,251,169,113,68,221,13,227,52,166,105,89,176,217,123,209,142,254,51,69,196,183,115,89,76,214,171,241,24,167,164,204,68,128,204,247,71,71,34,110,28,163,181,99,158,133,142,195,218,67,173,247,253,58,169,191,104,191,254,169,74,217,205,100,86,155,193,235,155,10,105,247,222,136,42,23,97,27,42,158,138,230,38,108,204,240,159,179,51,81,223,235,135,161,142,137,115,89,48,187,228,137,114,151,237,237,184,40,37,181,92,153,107,46,50,198,9,213,121,63,83,133,33,185,173,133,197,1,212,185,229,183,218,45,174,50,20,227,110,221,49,179,237,198,213,194,188,162,59,142,155,238,211,137,101,39,27,181,125,251,63,126,42,9,41,171,59,244,208,53,72,127,254,60,152,123,57,87,88,198,199,133,7,18,53,46,184,195,207,101,67,138,29,95,33,194,62,184,131,246,251,141,8,149,187,157,23,217,229,94,138,29,33,31,128,40,233,99,131,225,83,133,138,4,39,99,131,148,52,184,51,71,48,109,72,33,255,190,156,255,5,121,11,154,190,90,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddDragDropEventParamsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("666e8c98-83da-4933-9ffe-4d9a09920d63"),
				Name = "AddDragDropEventParams",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c267df5a-0d37-48c8-ba2c-60c932ca5650"),
				Name = "DragDropEvent",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ComponentAjaxEvent",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,142,49,10,194,64,16,69,123,79,17,82,37,32,123,1,43,113,83,42,33,8,214,35,59,134,128,217,9,127,135,172,199,119,151,136,133,133,88,8,233,230,193,27,254,179,160,222,66,166,102,102,175,166,121,40,168,37,208,200,202,8,102,239,92,229,57,22,103,6,40,200,77,47,124,61,136,87,200,61,152,183,87,149,144,24,202,109,81,122,113,156,143,239,254,49,89,166,163,88,215,187,141,253,203,190,18,122,214,78,98,142,88,224,148,70,86,40,153,8,233,253,85,178,192,74,37,163,204,220,74,24,116,16,159,99,62,248,231,156,39,62,164,92,60,34,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareAdminRightWindowOpenerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0dbd7764-93c3-4a0d-846b-9d7d741d60d1"),
				Name = "PrepareAdminRightWindowOpener",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,111,26,49,16,189,243,43,172,61,129,4,86,138,200,135,68,91,41,93,42,130,148,143,85,32,205,161,202,193,93,207,130,213,93,59,26,123,137,80,196,127,207,120,205,118,195,162,134,248,98,123,252,222,27,207,204,91,11,100,8,169,65,57,147,236,27,75,196,18,248,2,1,166,168,36,159,67,14,169,3,121,107,36,216,223,39,79,252,151,200,75,58,85,168,137,112,98,110,74,76,129,207,211,21,20,130,39,168,10,129,155,216,228,101,161,249,173,40,224,137,47,204,220,161,210,203,110,111,220,249,169,157,114,155,0,126,104,210,29,8,209,219,184,179,246,31,83,203,149,243,63,241,184,192,208,240,194,166,165,146,221,104,52,20,112,145,93,192,32,253,115,2,131,209,105,118,62,160,235,112,144,102,163,225,151,211,76,102,153,56,139,122,65,232,153,248,65,251,70,104,58,227,127,115,243,61,88,130,102,173,36,32,159,130,219,133,186,81,210,22,171,179,128,84,174,121,164,20,7,105,189,206,76,91,39,116,10,63,54,84,81,183,93,98,143,9,203,26,145,113,231,193,2,46,132,253,123,41,11,165,239,61,250,238,25,244,163,210,210,188,112,127,4,172,21,171,6,213,151,170,137,31,146,233,49,46,17,65,187,203,212,169,53,248,172,36,224,176,132,35,204,102,28,237,239,215,237,70,26,190,3,180,4,233,176,106,249,193,77,20,37,50,154,60,242,213,86,174,232,179,176,127,103,175,59,88,88,175,81,237,201,168,255,207,158,219,126,11,3,251,126,34,104,203,97,239,220,119,64,118,59,147,87,188,125,219,199,185,34,233,217,100,187,163,108,63,209,142,228,125,201,77,253,71,152,143,74,186,21,17,246,157,19,194,71,168,87,224,3,135,220,16,63,66,142,169,62,64,144,159,27,119,156,27,11,193,106,119,250,218,8,79,203,68,110,137,247,6,47,26,156,55,63,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareAddSearchFolderWondowOpenerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("171a377e-3fd3-4b18-a1b4-9b046a216088"),
				Name = "PrepareAddSearchFolderWondowOpener",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,219,110,194,48,12,125,94,191,34,244,1,181,18,202,15,116,76,218,10,67,149,54,64,2,182,231,168,49,16,173,36,200,73,65,8,241,239,51,109,161,133,221,88,94,154,218,62,231,216,206,217,8,100,8,169,65,153,72,214,101,131,92,73,222,95,173,221,46,242,250,218,41,183,155,164,75,88,137,89,145,29,139,5,240,158,112,98,98,114,76,129,159,115,145,183,33,158,53,165,203,208,171,208,116,199,31,33,252,162,108,140,102,163,36,32,31,128,171,66,129,63,190,38,243,195,82,5,164,114,117,146,36,190,200,30,121,18,109,157,208,41,60,237,168,189,160,95,97,232,30,50,97,89,141,143,188,153,5,156,10,251,241,40,229,4,4,166,203,103,147,81,51,163,53,232,119,165,165,217,242,227,21,240,196,88,108,226,244,83,204,254,55,3,85,196,57,34,104,247,152,58,181,129,163,62,177,56,204,225,22,120,213,58,33,26,131,156,118,142,98,5,14,208,82,150,121,172,56,26,182,172,167,72,201,104,129,187,123,235,80,233,69,135,149,223,7,182,175,202,202,179,247,79,239,239,119,206,86,224,83,51,41,170,131,240,208,185,42,135,75,95,16,234,202,41,191,129,29,2,12,80,149,106,133,57,166,85,132,199,153,34,234,164,119,168,32,135,200,83,115,22,180,202,182,121,98,135,121,150,141,176,112,103,16,11,82,75,28,172,134,52,126,24,210,76,119,245,42,56,173,50,240,211,102,9,169,93,66,34,239,64,244,65,15,230,111,34,203,193,210,122,91,93,166,73,130,181,219,172,213,136,147,114,169,249,189,140,172,43,73,164,137,171,215,80,168,221,246,206,227,230,131,214,90,183,216,36,166,245,1,130,252,135,179,226,204,88,40,253,61,210,47,70,28,177,115,145,89,2,127,2,165,162,129,246,26,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareAddGeneralFolderWondowOpenerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("116f6715-cd06-4e58-b95c-c58e5341fc91"),
				Name = "PrepareAddGeneralFolderWondowOpener",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,219,110,194,48,12,125,94,191,34,244,1,181,18,202,15,116,76,98,192,80,165,77,84,2,182,231,168,49,44,90,73,144,147,130,42,212,127,159,123,129,2,211,38,150,151,166,182,207,57,182,115,246,2,25,66,106,80,198,146,13,217,44,87,146,79,183,59,87,68,222,84,59,229,138,69,250,9,91,177,170,179,137,216,0,159,8,39,22,38,199,20,248,57,23,121,123,226,217,81,186,9,189,9,77,119,252,21,194,175,202,18,52,123,37,1,249,12,92,27,10,252,228,150,204,15,27,21,144,202,117,73,146,248,33,91,241,196,218,58,161,83,120,46,168,189,96,218,98,232,30,50,97,89,135,143,188,149,5,92,10,251,53,146,114,6,26,80,100,47,38,163,110,230,59,208,31,74,75,115,224,213,21,240,68,89,175,226,244,83,15,127,7,5,149,140,115,68,208,110,148,58,181,135,170,3,162,113,152,195,93,248,182,123,130,92,204,114,90,59,138,45,56,64,75,89,230,177,250,104,56,176,137,34,41,163,5,22,143,214,161,210,155,1,107,190,79,236,216,150,53,231,232,159,44,224,15,206,110,224,75,179,168,171,131,176,28,220,148,195,181,53,8,117,99,150,191,192,14,1,102,168,26,181,218,31,203,54,194,199,153,34,234,120,82,182,144,50,242,212,58,152,192,250,93,100,57,88,154,191,55,100,58,207,50,214,239,179,222,69,156,199,182,118,109,16,134,52,219,67,183,18,78,59,13,124,217,85,146,230,37,174,235,147,236,85,222,251,18,201,229,202,59,177,187,94,114,76,19,2,130,252,207,235,143,51,99,161,113,225,92,191,26,81,129,215,34,179,132,254,6,48,121,165,11,193,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareEditFolderWindowOpenerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cf1172dd-f3b9-431c-b7f9-af877dfa4361"),
				Name = "PrepareEditFolderWindowOpener",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,77,111,194,48,12,134,239,253,21,81,79,32,161,104,119,182,73,91,97,12,105,131,74,133,237,48,113,136,26,15,162,181,9,114,210,34,132,248,239,115,63,88,249,208,40,185,212,181,253,216,142,243,230,2,25,66,108,80,142,37,123,96,161,88,2,159,33,192,8,149,228,17,36,16,59,144,19,35,193,126,221,45,248,135,72,50,178,202,172,129,112,34,50,25,198,192,163,120,5,169,224,33,170,84,224,54,48,73,150,106,62,17,41,44,250,222,80,59,229,182,85,198,188,233,113,65,83,172,239,229,52,205,154,194,149,235,93,104,178,241,95,132,159,164,133,104,114,37,1,249,8,92,237,234,248,225,121,49,191,91,117,1,169,92,19,164,22,23,109,139,58,99,109,157,208,49,60,111,105,188,206,176,102,200,238,50,97,89,195,247,189,185,5,156,9,251,83,228,188,152,132,230,152,174,65,127,42,45,205,134,23,38,224,161,88,185,132,195,79,121,237,171,48,5,131,12,17,180,123,138,157,202,161,232,74,5,28,102,208,66,214,179,82,242,209,228,135,37,35,61,143,3,180,20,101,30,43,143,134,13,27,40,106,98,52,61,227,189,117,168,244,178,199,170,239,35,219,213,105,213,217,249,7,217,248,189,63,5,241,153,137,202,236,78,119,223,59,75,135,83,33,16,117,38,141,107,176,171,37,89,114,167,34,13,18,69,165,199,131,125,141,236,111,216,74,120,124,253,102,23,45,228,167,146,110,69,192,169,118,42,119,11,250,10,106,185,114,151,108,229,111,129,3,186,31,32,200,219,94,61,72,140,133,74,113,83,253,102,68,129,125,139,196,66,255,23,234,176,240,243,236,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseActiveRowChangedHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f2b167eb-7397-4bb6-8d48-1d6a56724339"),
				Name = "BaseActiveRowChangedHandler",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,203,110,219,70,20,93,75,95,65,107,97,80,72,200,80,15,82,84,21,183,144,40,210,17,144,56,134,229,164,235,49,57,178,136,82,164,65,142,252,64,108,32,125,236,10,20,93,246,51,130,180,65,211,180,73,126,129,254,163,222,25,146,34,37,62,44,7,237,202,50,57,247,220,115,207,220,123,56,115,142,124,206,66,4,77,189,165,111,98,110,143,59,68,167,88,28,175,158,12,234,231,176,98,110,99,31,249,230,252,74,243,156,229,194,133,101,105,140,56,53,231,120,129,196,39,235,107,6,117,123,198,241,83,226,219,238,169,56,9,14,150,142,243,220,215,23,103,228,138,127,106,7,4,187,216,167,169,14,125,207,196,65,240,98,98,53,185,235,235,124,162,61,206,133,200,38,247,170,94,243,49,89,250,128,123,195,40,157,69,129,64,229,69,128,125,205,115,93,108,18,219,115,197,73,12,169,187,167,182,139,197,125,76,226,7,163,43,200,82,150,60,162,187,81,188,56,4,200,115,124,228,93,28,250,246,2,249,49,171,151,200,89,98,110,103,143,219,95,218,150,200,106,98,4,41,173,0,59,192,3,91,209,154,156,156,85,136,131,122,77,155,99,243,187,35,251,116,78,2,126,13,9,248,213,138,8,198,218,31,160,5,166,90,53,70,40,192,134,231,88,216,111,48,74,181,88,38,113,202,100,56,195,62,185,98,128,124,35,90,54,177,26,15,97,89,141,223,84,126,39,82,158,251,38,187,213,85,122,124,149,149,131,242,189,169,87,100,159,4,71,158,71,98,170,148,65,81,22,186,121,199,87,103,216,202,228,121,76,179,124,189,73,87,204,172,160,98,52,169,26,25,62,180,107,18,50,199,115,223,187,208,207,177,75,248,228,209,196,37,216,119,145,3,109,68,240,37,121,200,197,234,172,152,104,115,228,158,98,171,1,64,81,45,51,219,193,116,31,248,198,83,20,144,105,188,87,73,61,91,106,38,30,123,209,128,240,84,48,218,62,254,74,20,90,55,52,38,180,144,139,47,88,41,124,163,63,214,100,67,209,21,161,61,84,90,66,119,172,171,194,80,146,251,194,88,239,72,70,87,239,117,141,118,151,82,164,171,25,148,190,64,182,83,142,167,232,237,142,49,108,43,130,60,210,117,65,151,90,45,97,168,42,35,65,146,90,178,60,150,186,154,212,26,175,240,130,229,201,29,112,163,126,111,40,171,29,69,104,105,99,73,208,91,0,215,151,52,37,129,147,1,175,147,210,195,38,236,64,57,24,228,54,140,81,183,43,244,186,82,47,230,166,116,1,91,25,171,29,109,56,146,250,170,180,2,163,188,78,188,203,10,229,250,90,187,35,183,52,193,144,12,53,166,54,30,13,87,212,90,170,212,162,104,108,19,172,229,153,99,155,136,224,103,216,93,78,8,94,4,49,22,245,142,199,1,219,177,175,233,116,177,105,132,158,153,217,167,75,31,143,147,176,32,137,19,53,199,134,34,39,227,135,241,218,41,65,62,73,215,77,49,109,225,162,213,143,30,149,97,71,238,144,139,169,223,68,13,52,91,73,192,20,72,71,224,14,131,75,230,157,185,198,6,72,105,80,197,124,54,140,12,70,163,153,184,182,205,198,30,48,215,83,236,229,27,255,62,124,87,168,241,143,221,221,47,227,124,136,124,42,38,240,93,183,143,117,246,108,10,74,74,200,79,200,32,142,124,6,47,70,222,101,65,92,81,243,38,81,211,120,232,10,194,10,231,49,137,59,98,211,85,68,50,63,118,73,204,170,199,10,194,210,254,75,62,27,48,43,143,30,113,225,111,225,31,225,187,240,227,237,15,225,251,219,159,194,247,225,135,240,13,252,254,116,251,250,246,103,46,252,135,189,250,69,8,223,132,127,193,211,119,240,224,83,248,150,11,127,135,215,63,134,159,195,207,220,237,107,120,247,39,195,248,59,124,195,133,191,134,31,40,84,248,54,252,8,32,223,211,223,209,72,122,23,174,227,33,139,85,28,196,77,191,222,224,169,153,54,14,26,177,157,98,203,38,177,240,96,219,4,94,102,99,249,212,31,12,89,81,85,89,214,5,89,150,193,89,91,237,174,48,28,141,122,130,162,74,109,67,29,26,29,165,175,54,154,205,194,28,148,210,112,73,60,195,118,156,98,116,69,234,116,36,249,196,18,172,89,111,38,116,85,165,35,160,86,187,71,243,180,187,253,19,83,70,51,169,4,221,100,31,158,248,160,82,140,174,43,154,172,201,50,88,163,172,200,66,119,216,107,11,253,158,161,11,237,246,176,173,203,234,184,51,162,222,86,136,142,172,72,81,104,179,104,95,139,51,72,157,177,108,104,70,91,104,13,213,54,100,80,32,131,10,105,186,253,81,31,222,129,81,107,69,252,235,117,27,122,208,244,150,46,137,198,15,80,165,65,125,230,249,24,153,115,142,167,12,22,177,145,113,182,27,205,236,177,143,241,190,15,155,74,45,46,154,110,240,129,188,37,83,111,36,200,118,3,126,177,233,133,205,232,232,179,122,174,187,232,196,193,22,243,135,85,35,15,106,53,56,162,112,216,9,48,71,51,228,80,104,219,51,70,67,203,154,174,205,90,206,124,43,242,197,221,55,168,206,149,22,83,220,232,236,108,92,17,85,209,231,85,98,164,110,6,240,219,114,205,234,178,79,79,210,168,76,22,64,205,102,46,20,150,125,1,239,43,235,78,198,24,193,235,119,178,149,68,255,223,87,246,194,49,43,151,142,207,16,200,74,215,164,233,55,238,35,227,209,20,155,75,223,38,87,233,141,68,67,174,126,9,79,9,126,14,135,98,68,215,193,137,7,185,207,144,155,94,75,198,56,176,79,221,70,115,251,253,88,216,46,59,30,148,40,105,207,248,157,204,4,68,15,75,244,93,19,148,223,89,175,55,21,152,146,75,216,149,161,101,135,142,46,41,35,155,70,16,159,221,134,232,13,98,187,237,43,245,177,170,238,191,111,143,20,26,253,23,244,200,182,251,121,132,23,222,57,190,215,84,172,118,109,219,28,58,53,142,251,100,200,137,86,65,38,58,131,20,15,104,218,18,112,138,200,205,44,88,51,245,253,60,241,189,61,70,251,208,199,212,36,243,142,83,175,113,181,34,171,140,227,14,188,232,67,148,47,185,164,140,25,130,26,7,53,118,153,101,140,248,164,174,235,235,168,40,250,55,29,41,64,217,221,45,165,93,168,54,71,103,162,130,115,73,27,220,17,85,101,6,219,20,187,89,106,90,98,69,125,119,126,17,234,148,115,69,116,245,231,160,154,119,66,123,115,1,139,90,37,48,125,251,140,240,209,29,78,52,60,127,129,8,223,224,94,73,55,98,128,201,75,59,176,33,132,167,254,211,28,112,112,143,47,56,91,12,232,134,101,14,53,15,30,172,15,195,253,82,49,238,229,185,216,44,220,192,85,136,207,30,163,30,195,57,170,153,220,63,191,160,170,59,102,129,221,214,34,48,238,140,93,137,232,154,40,9,200,189,153,134,58,12,77,149,46,5,3,121,181,202,83,54,171,144,37,7,254,32,143,190,142,44,194,15,232,13,62,83,199,127,141,79,23,152,228,9,166,179,243,255,231,249,214,182,200,156,166,185,185,217,34,209,198,134,111,230,109,14,254,5,142,252,19,120,207,21,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseLoadRowsResponseRegisteredHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("67b135ec-225e-49e5-8337-545daa76aed0"),
				Name = "BaseLoadRowsResponseRegisteredHandler",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("672f353e-de07-46ce-bd86-d7ea99f10485"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b6f9f758-be66-41c3-bc58-63426ddcfe86"),
				Name = "e",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,203,110,194,48,16,60,19,41,255,96,56,84,137,84,89,220,17,149,210,240,40,82,15,8,218,94,170,30,44,188,80,87,142,211,58,14,15,85,252,123,189,121,208,36,64,5,205,193,82,214,179,51,179,30,39,107,166,9,103,134,205,227,84,47,128,244,201,148,173,128,14,14,149,158,235,172,107,144,89,188,73,194,56,85,198,98,127,171,20,203,52,171,219,142,74,125,14,18,22,6,248,196,64,52,213,34,98,122,23,198,50,141,212,11,147,41,216,22,9,76,123,126,33,195,22,70,172,81,226,121,194,45,255,56,21,156,14,163,79,179,43,246,37,75,204,40,150,28,244,72,199,150,47,94,10,137,166,199,96,138,23,116,238,117,30,45,174,84,206,241,29,148,16,75,226,157,161,232,19,149,74,233,147,111,215,105,33,108,0,75,150,202,2,105,205,180,171,110,114,88,171,225,182,209,98,245,90,123,215,217,19,144,9,16,228,108,15,183,134,78,146,224,131,109,103,240,101,167,55,62,242,52,104,20,108,50,169,211,78,233,83,60,55,90,168,149,231,227,68,123,146,79,101,3,200,25,105,32,53,48,110,15,89,25,38,84,130,185,228,118,107,161,152,80,10,80,38,40,165,189,202,238,161,120,156,215,45,49,58,5,20,110,93,145,113,192,249,133,252,249,72,217,129,149,65,156,186,121,119,164,91,68,128,136,250,249,157,200,41,67,1,70,136,25,147,155,27,146,221,215,178,80,162,154,65,100,32,122,108,178,151,161,43,54,143,91,27,31,198,107,247,237,60,15,174,217,242,119,64,85,133,74,12,215,230,144,219,197,231,242,68,106,179,254,203,37,126,7,174,115,207,18,56,64,195,119,166,86,192,31,152,226,18,240,15,240,3,49,149,75,85,138,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDuplicatesFolderIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("01cfcfe7-9975-437f-b95f-0640b13ebee9"),
				Name = "GetDuplicatesFolderId",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,203,106,195,48,16,60,215,95,177,248,36,67,16,185,187,14,20,199,9,57,180,164,164,143,67,233,65,88,219,70,32,75,142,44,165,152,146,127,175,100,57,197,109,211,155,24,205,206,204,206,30,153,1,84,86,216,126,87,239,177,97,183,76,177,119,52,80,192,99,135,166,212,74,97,109,133,86,180,250,75,202,19,241,6,100,235,159,116,201,44,219,105,103,106,164,145,2,69,1,202,73,153,193,103,114,101,208,58,163,96,237,4,167,85,211,218,62,79,78,201,209,59,31,28,154,222,123,41,252,128,169,193,125,192,201,133,92,51,184,108,71,239,88,131,89,62,136,218,190,197,13,47,181,116,141,10,176,215,31,124,232,13,31,81,146,174,180,228,104,30,60,147,110,120,154,13,227,121,18,105,43,33,45,154,46,208,73,68,74,131,204,98,196,159,133,221,111,153,241,252,64,34,17,44,117,211,50,35,58,173,6,201,234,224,152,156,193,212,165,212,28,83,15,45,93,43,69,237,213,186,52,27,243,14,107,10,236,190,115,174,209,198,50,124,90,25,235,39,63,175,145,197,234,207,147,94,221,41,11,11,152,79,235,62,255,190,204,95,131,100,136,49,238,255,196,164,195,235,112,142,5,249,221,150,151,62,1,202,14,255,59,220,23,143,243,166,23,50,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsDuplicatesFolderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("34f33253-6792-44f7-bb76-f7491c58fc67"),
				Name = "IsDuplicatesFolder",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("933873ab-ed6b-47b2-af66-72473181e932"),
				Name = "folderId",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,142,203,10,131,48,16,69,215,21,252,135,224,42,129,146,31,176,118,81,109,196,93,193,182,251,144,140,53,16,19,201,67,144,210,127,111,106,221,206,61,231,222,89,184,67,94,140,48,113,84,161,27,127,1,109,120,224,189,141,78,0,237,183,160,204,179,37,81,96,130,10,107,162,254,56,173,29,240,0,215,237,138,31,30,92,109,141,1,17,148,53,36,41,106,64,248,175,80,6,65,140,204,217,169,185,224,162,147,197,17,13,86,75,112,157,36,4,189,243,236,224,32,68,103,246,5,218,66,184,175,51,200,218,234,56,153,39,215,17,78,109,84,242,140,11,182,121,191,52,213,16,84,85,168,137,179,86,34,61,226,217,222,153,182,63,121,182,87,14,92,123,40,191,107,245,152,52,229,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateListenerThrowEventMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a501b7aa-08ee-4b05-a037-8b7f2b818183"),
				Name = "ListenerThrowEvent",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("495f697c-33a8-4425-8948-668846836021"),
				Name = "listenerPageProcessUId",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c1d9557c-1da4-4acf-975b-2cff2a853e9a"),
				Name = "eventName",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,65,14,130,48,16,69,215,246,20,117,7,137,233,5,8,27,13,38,221,32,11,57,64,3,35,54,41,83,50,29,80,98,184,187,85,97,233,246,255,153,247,190,189,201,36,48,89,236,148,14,229,232,220,133,138,126,224,57,113,54,48,32,80,101,58,168,200,55,16,66,173,219,52,149,47,177,35,224,145,48,19,139,152,12,201,225,215,202,92,214,1,232,228,17,161,97,235,81,233,245,175,192,206,34,168,179,197,118,77,142,115,100,253,83,100,194,198,81,27,117,159,75,140,179,190,222,53,83,215,59,249,71,49,1,242,118,166,52,50,16,26,23,245,12,79,62,72,248,212,165,233,33,242,150,55,107,208,165,107,230,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetProfileDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("17b2b6f8-9c76-4fa1-8142-3511be6081a7"),
				Name = "SetProfileData",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c820d721-3c7a-4989-8200-751c05b49bd8"),
				Name = "profileKey",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("134ee540-9729-40e4-9c7f-8bff2a059f44"),
				Name = "profileValue",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,46,41,202,204,75,87,40,78,46,202,44,40,81,176,85,80,170,54,168,213,43,78,45,9,40,202,79,203,204,73,117,73,44,73,212,168,54,172,213,169,54,170,213,84,178,230,10,72,76,79,213,11,6,43,246,77,204,3,114,138,244,28,83,82,32,2,26,197,96,179,244,220,242,139,114,19,129,60,176,160,142,2,88,75,72,81,106,170,123,81,102,138,158,115,78,102,106,94,137,167,139,142,130,146,186,146,130,182,66,1,196,30,239,212,74,32,7,40,132,38,30,150,152,83,154,10,145,209,212,180,6,0,115,241,200,117,173,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetProfileDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2f5e7ed5-6b0c-4680-827e-cf2be6184353"),
				Name = "GetProfileData",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d377779d-338d-42f8-bde4-adb5ce92e50b"),
				Name = "profileKey",
				CreatedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				ModifiedInSchemaUId = new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,203,10,194,48,16,69,215,205,87,140,27,177,155,252,64,113,33,45,72,113,211,133,143,69,113,145,234,84,34,49,145,73,42,136,248,239,38,105,181,5,33,144,7,231,158,153,201,67,16,220,197,5,97,9,149,223,248,202,222,195,14,194,194,22,137,132,53,173,227,187,146,31,176,201,141,118,100,148,229,1,200,152,105,174,120,114,64,104,59,229,124,92,119,74,101,76,182,176,8,62,190,179,88,145,105,165,194,20,94,44,121,132,58,253,189,16,78,120,62,82,213,248,148,177,36,134,39,208,172,183,70,193,212,80,58,188,5,195,136,214,177,249,45,33,174,73,158,121,174,36,106,87,22,71,47,157,90,99,112,176,194,124,62,245,241,189,80,29,90,30,166,20,82,219,13,62,191,41,127,76,251,30,146,228,55,238,127,180,30,241,88,247,205,252,122,51,66,215,145,30,254,41,251,0,97,231,133,98,112,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseModuleFoldersPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3db55944-d9aa-4ec2-a23e-a1fa7370d9c4"));
		}

		#endregion

	}

	#endregion

}

