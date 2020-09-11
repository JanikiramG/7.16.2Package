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
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: BaseModulePageSchema

	/// <exclude/>
	public class BaseModulePageSchema : Terrasoft.UI.WebControls.PageSchema
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _leftControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout LeftControlLayout {
			get {
				return _leftControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _customSearchContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer CustomSearchContainer {
			get {
				return _customSearchContainer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _folderLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout FolderLayout {
			get {
				return _folderLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _baseFolder;
		public Terrasoft.UI.WebControls.Controls.PageContainer BaseFolder {
			get {
				return _baseFolder;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _filterEditLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterEditLayout {
			get {
				return _filterEditLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _filterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return _filterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _saveToolButton;
		public Terrasoft.UI.WebControls.Controls.Button SaveToolButton {
			get {
				return _saveToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _applyToolButton;
		public Terrasoft.UI.WebControls.Controls.Button ApplyToolButton {
			get {
				return _applyToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _rightControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout RightControlLayout {
			get {
				return _rightControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _gridTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel GridTabPanel {
			get {
				return _gridTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _gridTab;
		public Terrasoft.UI.WebControls.Controls.Tab GridTab {
			get {
				return _gridTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _grid;
		public Terrasoft.UI.WebControls.Controls.PageContainer Grid {
			get {
				return _grid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _detailsTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel DetailsTabPanel {
			get {
				return _detailsTabPanel;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseModulePageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseModulePageSchema(BaseModulePageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			RealUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			Name = "BaseModulePage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 700;
			Height = 600;
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseModulePageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateLeftControlLayout());
			LeftControlLayout.InsertItem(0, CreateCustomSearchContainer());
			LeftControlLayout.InsertItem(1, CreateFolderLayout());
			FolderLayout.InsertItem(0, CreateBaseFolder());
			LeftControlLayout.InsertItem(2, CreateFilterEditLayout());
			FilterEditLayout.InsertItem(0, CreateFilterEdit());
			FilterEdit.InsertItem(0, CreateSaveToolButton());
			FilterEdit.InsertItem(1, CreateApplyToolButton());
			MainControlLayout.InsertItem(1, CreateRightControlLayout());
			RightControlLayout.InsertItem(0, CreateGridTabPanel());
			GridTabPanel.InsertItem(0, CreateGridTab());
			GridTab.InsertItem(0, CreateGrid());
			RightControlLayout.InsertItem(1, CreateDetailsTabPanel());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseModulePageEventsProcessSchema() {
			var schema = new BaseModulePageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("4859ce24-7e57-428f-8de0-09a0529a076c");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateCustomSearchContainer() {
			_customSearchContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_customSearchContainer.UId = new Guid("9f6ae9c8-67d9-4ae1-9439-fba544dbf22c");
			_customSearchContainer.Name = "CustomSearchContainer";
			_customSearchContainer.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_customSearchContainer.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_customSearchContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customSearchContainer.Tag = "";
			_customSearchContainer.PageSchemaUId = Guid.Empty;
			_customSearchContainer.Height = System.Web.UI.WebControls.Unit.Pixel(90);
			_customSearchContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_customSearchContainer.StartNewAlignGroup = false;
			_customSearchContainer.Edges = "";
			_customSearchContainer.Hidden = true;
			return _customSearchContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateBaseFolder() {
			_baseFolder = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_baseFolder.UId = new Guid("bedca515-f25e-4642-8cf7-4868b620571d");
			_baseFolder.Name = "BaseFolder";
			_baseFolder.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_baseFolder.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_baseFolder.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseFolder.Tag = "";
			_baseFolder.PageSchemaUId = new Guid("a9ac04d9-f075-4f37-bf7e-2681cb858ed0");
			_baseFolder.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseFolder.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseFolder.StartNewAlignGroup = false;
			_baseFolder.Edges = "";
			return _baseFolder;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFolderLayout() {
			_folderLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_folderLayout.UId = new Guid("6bc1277c-8766-4f35-adcc-444f827157e7");
			_folderLayout.Name = "FolderLayout";
			_folderLayout.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_folderLayout.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_folderLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_folderLayout.Tag = "";
			_folderLayout.Height = System.Web.UI.WebControls.Unit.Percentage(70);
			_folderLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_folderLayout.StartNewAlignGroup = false;
			_folderLayout.Image = new ControlImage {};
			_folderLayout.Edges = "1 1 1 1";
			_folderLayout.HasSplitter = true;
			return _folderLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSaveToolButton() {
			_saveToolButton = new Terrasoft.UI.WebControls.Controls.Button();
			_saveToolButton.UId = new Guid("56859677-665a-48ba-b58b-3096247d0503");
			_saveToolButton.Name = "SaveToolButton";
			_saveToolButton.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_saveToolButton.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_saveToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_saveToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_saveToolButton.Tag = "";
			_saveToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			return _saveToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateApplyToolButton() {
			_applyToolButton = new Terrasoft.UI.WebControls.Controls.Button();
			_applyToolButton.UId = new Guid("6eb4dbe3-6d8d-4ef1-90f5-2e39bfac44ba");
			_applyToolButton.Name = "ApplyToolButton";
			_applyToolButton.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_applyToolButton.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_applyToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_applyToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_applyToolButton.Tag = "";
			_applyToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			return _applyToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("1444738b-1525-4565-8368-8f9fe5e58f48");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_filterEdit.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "DataSource";
			_filterEdit.Edges = "0 0 0 0";
			_filterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFilterEditLayout() {
			_filterEditLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_filterEditLayout.UId = new Guid("a3b8289b-2da4-4fa2-bb0f-7475f9037f52");
			_filterEditLayout.Name = "FilterEditLayout";
			_filterEditLayout.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_filterEditLayout.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_filterEditLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEditLayout.Tag = "";
			_filterEditLayout.Height = System.Web.UI.WebControls.Unit.Percentage(30);
			_filterEditLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEditLayout.StartNewAlignGroup = false;
			_filterEditLayout.Image = new ControlImage {};
			_filterEditLayout.Edges = "1 1 1 1";
			return _filterEditLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateLeftControlLayout() {
			_leftControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_leftControlLayout.UId = new Guid("6c048dd5-1457-40af-b448-730d81595a4c");
			_leftControlLayout.Name = "LeftControlLayout";
			_leftControlLayout.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_leftControlLayout.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_leftControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_leftControlLayout.Tag = "";
			_leftControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_leftControlLayout.Width = System.Web.UI.WebControls.Unit.Pixel(350);
			_leftControlLayout.StartNewAlignGroup = false;
			_leftControlLayout.Image = new ControlImage {};
			_leftControlLayout.Edges = "";
			_leftControlLayout.HasSplitter = true;
			return _leftControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateGrid() {
			_grid = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_grid.UId = new Guid("453b178f-495b-44d9-8d47-95f1781e4760");
			_grid.Name = "Grid";
			_grid.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_grid.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_grid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_grid.Tag = "";
			_grid.PageSchemaUId = Guid.Empty;
			_grid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_grid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_grid.StartNewAlignGroup = false;
			_grid.Edges = "";
			return _grid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateGridTab() {
			_gridTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_gridTab.UId = new Guid("22369bd9-43c2-427f-af11-2e913758ce10");
			_gridTab.Name = "GridTab";
			_gridTab.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_gridTab.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_gridTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_gridTab.Tag = "";
			_gridTab.Image = new ControlImage {};
			return _gridTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateGridTabPanel() {
			_gridTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_gridTabPanel.UId = new Guid("1927384b-6105-48e7-8f2d-8f15dd1e85a3");
			_gridTabPanel.Name = "GridTabPanel";
			_gridTabPanel.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_gridTabPanel.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_gridTabPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_gridTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			_gridTabPanel.Tag = "";
			_gridTabPanel.ActiveTabIndex = 0;
			_gridTabPanel.HasSplitter = true;
			_gridTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(70);
			_gridTabPanel.StartNewAlignGroup = false;
			_gridTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_gridTabPanel.Margins = "0 0 0 0";
			return _gridTabPanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateDetailsTabPanel() {
			_detailsTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_detailsTabPanel.UId = new Guid("bc9de577-072d-4206-a496-42e2da95f035");
			_detailsTabPanel.Name = "DetailsTabPanel";
			_detailsTabPanel.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_detailsTabPanel.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_detailsTabPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_detailsTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			_detailsTabPanel.AjaxEvents.TabChange.ShowLoadMask = true;
			_detailsTabPanel.Tag = "";
			_detailsTabPanel.Collapsed = true;
			_detailsTabPanel.StartNewAlignGroup = false;
			_detailsTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _detailsTabPanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateRightControlLayout() {
			_rightControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_rightControlLayout.UId = new Guid("b3689853-4081-483e-b512-454cac361128");
			_rightControlLayout.Name = "RightControlLayout";
			_rightControlLayout.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_rightControlLayout.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_rightControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_rightControlLayout.Tag = "";
			_rightControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_rightControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(75);
			_rightControlLayout.StartNewAlignGroup = false;
			_rightControlLayout.Image = new ControlImage {};
			_rightControlLayout.Edges = "";
			return _rightControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("c520dcf0-3292-493d-9b9e-163dd97e8ade");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Padding = "0 5 5 5";
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			return _mainControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseModulePageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseModulePageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseModulePageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseModulePageEventsProcess

	/// <exclude/>
	public class BaseModulePageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseModulePageSchemaUserControl
	{

		#region Class: SaveFiltersUserTaskFlowElement

		/// <exclude/>
		public class SaveFiltersUserTaskFlowElement : SaveDataSourceFilterUserTask
		{

			public SaveFiltersUserTaskFlowElement(UserConnection userConnection, BaseModulePageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveFiltersUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("c738dbb5-465f-45fa-b840-4d7bf0272597");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: MessageWindowUserTaskFlowElement

		/// <exclude/>
		public class MessageWindowUserTaskFlowElement : QuestionUserTask
		{

			public MessageWindowUserTaskFlowElement(UserConnection userConnection, BaseModulePageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "MessageWindowUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: SetDetailFilterFlowElement

		/// <exclude/>
		public class SetDetailFilterFlowElement : SetDetailFilter
		{

			public SetDetailFilterFlowElement(UserConnection userConnection, BaseModulePageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SetDetailFilter";
				IsLogging = false;
				SchemaElementUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: NewInitializeDetailsFlowElement

		/// <exclude/>
		public class NewInitializeDetailsFlowElement : InitializeDetails
		{

			public NewInitializeDetailsFlowElement(UserConnection userConnection, BaseModulePageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "NewInitializeDetails";
				IsLogging = false;
				SchemaElementUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ModuleInitializePrimaryGridsFlowElement

		/// <exclude/>
		public class ModuleInitializePrimaryGridsFlowElement : InitializePrimaryGrids
		{

			public ModuleInitializePrimaryGridsFlowElement(UserConnection userConnection, BaseModulePageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ModuleInitializePrimaryGrids";
				IsLogging = false;
				SchemaElementUId = new Guid("60c5d1fe-e493-48c6-bf06-1c6639fc9093");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: LoadDynamicFolderFilterUserTaskFlowElement

		/// <exclude/>
		public class LoadDynamicFolderFilterUserTaskFlowElement : LoadDataSourceFilterUserTask
		{

			public LoadDynamicFolderFilterUserTaskFlowElement(UserConnection userConnection, BaseModulePageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LoadDynamicFolderFilterUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("38152366-49b4-4937-ab64-1e8329d9205e");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: LoadRecentFolderFilterUserTaskFlowElement

		/// <exclude/>
		public class LoadRecentFolderFilterUserTaskFlowElement : LoadRecentFolderFilterUserTask
		{

			public LoadRecentFolderFilterUserTaskFlowElement(UserConnection userConnection, BaseModulePageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LoadRecentFolderFilterUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("315a9d2d-af50-404d-94f3-925ce81a0d8b");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: LoadDuplicatesFolderFilterUserTaskFlowElement

		/// <exclude/>
		public class LoadDuplicatesFolderFilterUserTaskFlowElement : LoadDuplicatesFolderFilter
		{

			public LoadDuplicatesFolderFilterUserTaskFlowElement(UserConnection userConnection, BaseModulePageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LoadDuplicatesFolderFilterUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("314ee1f8-9911-490a-b969-6d195cf8a333");
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

		public BaseModulePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseModulePageEventsProcess";
			SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
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

		public virtual Guid FolderEntitySchemaUId {
			get;
			set;
		}

		public virtual Guid FolderEntryEntitySchemaUId {
			get;
			set;
		}

		public virtual Guid FolderId {
			get;
			set;
		}

		public virtual bool IsRootFolder {
			get;
			set;
		}

		public virtual Guid SysModuleId {
			get;
			set;
		}

		public virtual Guid FilterColumnValue {
			get;
			set;
		}

		public virtual bool HasDetails {
			get;
			set;
		}

		public virtual string SearchPrimaryDisplayColumnValue {
			get;
			set;
		}

		public virtual Object ModuleProcesses {
			get;
			set;
		}

		public virtual bool IsModuleProcessesTuningMode {
			get;
			set;
		}

		public virtual Object ModuleProcessesCaption {
			get;
			set;
		}

		public virtual Guid GotoFolderId {
			get;
			set;
		}

		public virtual bool SearchFolder {
			get;
			set;
		}

		public virtual bool StaticFolder {
			get;
			set;
		}

		public virtual bool IgnoreSearchFilter {
			get;
			set;
		}

		public virtual Guid PCV {
			get;
			set;
		}

		public virtual string PDV {
			get;
			set;
		}

		public virtual bool HasAnalytics {
			get;
			set;
		}

		public virtual string ChartTabItemClientID {
			get;
			set;
		}

		public virtual string CurrentChartCaption {
			get;
			set;
		}

		public virtual string MainPageProcessUId {
			get;
			set;
		}

		public virtual bool _isHasAnalyticsInitialized {
			get;
			set;
		}

		public virtual bool ClearFilterEditFilters {
			get;
			set;
		}

		private string _analyticsTabName;
		public virtual string AnalyticsTabName {
			get {
				return _analyticsTabName ?? (_analyticsTabName = new LocalizableString(Storage, "f31761480d114c418da5d6e5e75151cf",
						 "EventsProcessSchema.Parameters.AnalyticsTabName.Value"));
			}
			set {
				_analyticsTabName = value;
			}
		}

		public virtual bool IsRecentFolder {
			get;
			set;
		}

		public virtual Guid RootFolderId {
			get;
			set;
		}

		public virtual string FoldersMode {
			get;
			set;
		}

		public virtual Guid SysEntitySchemaId {
			get;
			set;
		}

		public virtual Guid TypeColumnUId {
			get;
			set;
		}

		public virtual Guid CurrentReportSchemaUId {
			get;
			set;
		}

		public virtual Guid SysModuleProcessPrimaryColumnUId {
			get;
			set;
		}

		public virtual bool IsDuplicatesFolder {
			get;
			set;
		}

		public virtual Guid CurrentChartPropertyId {
			get;
			set;
		}

		public virtual string OldTabPanelClientId {
			get;
			set;
		}

		public virtual Object CustomChartIdList {
			get;
			set;
		}

		public virtual bool SearchFilterEnabled {
			get;
			set;
		}

		public virtual bool HasActions {
			get;
			set;
		}

		public virtual string AnalyticsChartPageContainerID {
			get;
			set;
		}

		private ProcessFlowElement _applyToolButtonSubProcess;
		public ProcessFlowElement ApplyToolButtonSubProcess {
			get {
				return _applyToolButtonSubProcess ?? (_applyToolButtonSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ApplyToolButtonSubProcess",
					SchemaElementUId = new Guid("00bc284c-f18b-446c-930d-1876e7530788"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _applyToolButtonClick;
		public ProcessFlowElement ApplyToolButtonClick {
			get {
				return _applyToolButtonClick ?? (_applyToolButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ApplyToolButtonClick",
					SchemaElementUId = new Guid("2c52edbd-39b4-42ce-8b04-c33c02ab6f50"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _applyFiltersToolButtonScript;
		public ProcessScriptTask ApplyFiltersToolButtonScript {
			get {
				return _applyFiltersToolButtonScript ?? (_applyFiltersToolButtonScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ApplyFiltersToolButtonScript",
					SchemaElementUId = new Guid("b226c629-a388-41b4-9090-d9cdd09b4dd6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ApplyFiltersToolButtonScriptExecute,
				});
			}
		}

		private ProcessFlowElement _saveToolButtonSubProcess;
		public ProcessFlowElement SaveToolButtonSubProcess {
			get {
				return _saveToolButtonSubProcess ?? (_saveToolButtonSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SaveToolButtonSubProcess",
					SchemaElementUId = new Guid("e0153415-eaf1-45c2-8ff5-d6ba7feddae8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _saveToolButtonClick;
		public ProcessFlowElement SaveToolButtonClick {
			get {
				return _saveToolButtonClick ?? (_saveToolButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SaveToolButtonClick",
					SchemaElementUId = new Guid("ad7d2ac8-5b7c-4e36-bef6-cc2ef83f74e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _saveFiltersToolButtonScript;
		public ProcessScriptTask SaveFiltersToolButtonScript {
			get {
				return _saveFiltersToolButtonScript ?? (_saveFiltersToolButtonScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveFiltersToolButtonScript",
					SchemaElementUId = new Guid("457708c1-540a-40e7-86f3-bc8fb92575fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveFiltersToolButtonScriptExecute,
				});
			}
		}

		private SaveFiltersUserTaskFlowElement _saveFiltersUserTask;
		public SaveFiltersUserTaskFlowElement SaveFiltersUserTask {
			get {
				return _saveFiltersUserTask ?? (_saveFiltersUserTask = new SaveFiltersUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _clearToolButtonSubProcess;
		public ProcessFlowElement ClearToolButtonSubProcess {
			get {
				return _clearToolButtonSubProcess ?? (_clearToolButtonSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ClearToolButtonSubProcess",
					SchemaElementUId = new Guid("c5ffbdd2-da8d-4ed5-8d6f-d76714230f0a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _clearToolButtonClick;
		public ProcessFlowElement ClearToolButtonClick {
			get {
				return _clearToolButtonClick ?? (_clearToolButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ClearToolButtonClick",
					SchemaElementUId = new Guid("f0bb923e-9234-42aa-bd2b-6a101e15ef3c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _clearFiltersToolButtonScript;
		public ProcessScriptTask ClearFiltersToolButtonScript {
			get {
				return _clearFiltersToolButtonScript ?? (_clearFiltersToolButtonScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClearFiltersToolButtonScript",
					SchemaElementUId = new Guid("5ffe421e-558d-406c-98da-ece403f4a12d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ClearFiltersToolButtonScriptExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessSelectFolder;
		public ProcessFlowElement SubProcessSelectFolder {
			get {
				return _subProcessSelectFolder ?? (_subProcessSelectFolder = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessSelectFolder",
					SchemaElementUId = new Guid("f7a8c8ec-c4f1-48cd-9c4d-7498600065af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _selectFolderMessage;
		public ProcessFlowElement SelectFolderMessage {
			get {
				return _selectFolderMessage ?? (_selectFolderMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SelectFolderMessage",
					SchemaElementUId = new Guid("75a788e7-919b-4834-ba3b-f715e9688bda"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSelectFolder;
		public ProcessScriptTask ScriptSelectFolder {
			get {
				return _scriptSelectFolder ?? (_scriptSelectFolder = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSelectFolder",
					SchemaElementUId = new Guid("dded46dc-0797-451f-837a-2b4231b73f51"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSelectFolderExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessActualPrimaryGridData;
		public ProcessFlowElement EventSubProcessActualPrimaryGridData {
			get {
				return _eventSubProcessActualPrimaryGridData ?? (_eventSubProcessActualPrimaryGridData = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessActualPrimaryGridData",
					SchemaElementUId = new Guid("d090adbb-712c-45ac-b56f-75a5ed557750"),
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
					SchemaElementUId = new Guid("2cb023d8-67fe-498a-9dc3-9ae59af648cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptActualizeGridData;
		public ProcessScriptTask ScriptActualizeGridData {
			get {
				return _scriptActualizeGridData ?? (_scriptActualizeGridData = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptActualizeGridData",
					SchemaElementUId = new Guid("c2f105df-9e79-45d7-a7e5-67f369785a9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptActualizeGridDataExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess7;
		public ProcessFlowElement SubProcess7 {
			get {
				return _subProcess7 ?? (_subProcess7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess7",
					SchemaElementUId = new Guid("75b58cfb-0882-46a5-a300-9ab6355324e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _tuningModeChangedEvent;
		public ProcessFlowElement TuningModeChangedEvent {
			get {
				return _tuningModeChangedEvent ?? (_tuningModeChangedEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TuningModeChangedEvent",
					SchemaElementUId = new Guid("01803384-c8e7-4383-8a05-e44e773e15de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSwitchProcessMode;
		public ProcessScriptTask ScriptSwitchProcessMode {
			get {
				return _scriptSwitchProcessMode ?? (_scriptSwitchProcessMode = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSwitchProcessMode",
					SchemaElementUId = new Guid("04ce925b-8e5e-4d7d-9058-bfcbd9baf135"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSwitchProcessModeExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess12;
		public ProcessFlowElement SubProcess12 {
			get {
				return _subProcess12 ?? (_subProcess12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess12",
					SchemaElementUId = new Guid("c62c3e45-a71d-4fc9-b97b-06cbaa3c5169"),
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
					SchemaElementUId = new Guid("28caa023-3287-47a8-811c-ef30a7270d0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private MessageWindowUserTaskFlowElement _messageWindowUserTask;
		public MessageWindowUserTaskFlowElement MessageWindowUserTask {
			get {
				return _messageWindowUserTask ?? (_messageWindowUserTask = new MessageWindowUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("17dccbfb-66fc-4800-9f25-fd13f1e4812a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageNonInterruptingEvent2;
		public ProcessFlowElement StartMessageNonInterruptingEvent2 {
			get {
				return _startMessageNonInterruptingEvent2 ?? (_startMessageNonInterruptingEvent2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageNonInterruptingEvent2",
					SchemaElementUId = new Guid("549776a8-4634-4e3b-9123-328efa3e02fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptFolderActiveRowChanged;
		public ProcessScriptTask ScriptFolderActiveRowChanged {
			get {
				return _scriptFolderActiveRowChanged ?? (_scriptFolderActiveRowChanged = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptFolderActiveRowChanged",
					SchemaElementUId = new Guid("80c70f71-81a8-45cb-baa8-534806e48922"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptFolderActiveRowChangedExecute,
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
					SchemaElementUId = new Guid("0df00d5a-c629-4f7c-9cf9-74718353a85e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("4028f0c6-c9d6-4ca4-9db8-386de44e27e8"),
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
					SchemaElementUId = new Guid("4e5c6dc3-113c-4004-84cb-6b14ccbb67e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteExecute,
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
					SchemaElementUId = new Guid("1757fe07-d165-4c16-accf-f5bb77eb1ead"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowRefreshDetails;
		public ProcessThrowMessageEvent IntermediateThrowRefreshDetails {
			get {
				return _intermediateThrowRefreshDetails ?? (_intermediateThrowRefreshDetails = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowRefreshDetails",
					SchemaElementUId = new Guid("3bbfaaaa-8b03-42fc-9094-eeeea2c490e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "RefreshDetails",
				});
			}
		}

		private ProcessFlowElement _startGridLoadRows;
		public ProcessFlowElement StartGridLoadRows {
			get {
				return _startGridLoadRows ?? (_startGridLoadRows = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartGridLoadRows",
					SchemaElementUId = new Guid("ce8b9cec-10e6-434c-9c98-f31a455bc40a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _gridActiveRowChanged;
		public ProcessFlowElement GridActiveRowChanged {
			get {
				return _gridActiveRowChanged ?? (_gridActiveRowChanged = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "GridActiveRowChanged",
					SchemaElementUId = new Guid("50a6fa73-a0a3-4045-ae8f-33620058ed18"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptGridActiveRowChanged;
		public ProcessScriptTask ScriptGridActiveRowChanged {
			get {
				return _scriptGridActiveRowChanged ?? (_scriptGridActiveRowChanged = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptGridActiveRowChanged",
					SchemaElementUId = new Guid("2f5f6e58-6d80-4c44-b0a0-da1e579f2418"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridActiveRowChangedExecute,
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
					SchemaElementUId = new Guid("a3dd999a-f1ff-4a8b-a940-ce74f46cf245"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private SetDetailFilterFlowElement _setDetailFilter;
		public SetDetailFilterFlowElement SetDetailFilter {
			get {
				return _setDetailFilter ?? (_setDetailFilter = new SetDetailFilterFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessEndEvent _end2;
		public ProcessEndEvent End2 {
			get {
				return _end2 ?? (_end2 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End2",
					SchemaElementUId = new Guid("68a90b1c-3aab-4b27-961e-7943f21ea886"),
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
					SchemaElementUId = new Guid("a01ad8dc-1909-4992-9095-64e4cad18e3d"),
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

		private ProcessFlowElement _refreshDetails;
		public ProcessFlowElement RefreshDetails {
			get {
				return _refreshDetails ?? (_refreshDetails = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RefreshDetails",
					SchemaElementUId = new Guid("e7d23ad1-afd7-4258-b13d-f4b25cf013e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptRefreshDetails;
		public ProcessScriptTask ScriptRefreshDetails {
			get {
				return _scriptRefreshDetails ?? (_scriptRefreshDetails = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptRefreshDetails",
					SchemaElementUId = new Guid("06b901c9-4ed9-47b8-aba2-ce4db41424aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptRefreshDetailsExecute,
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
					SchemaElementUId = new Guid("070340df-5e51-40d7-9043-6018dc983530"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _detailsTabPanelTabChange;
		public ProcessFlowElement DetailsTabPanelTabChange {
			get {
				return _detailsTabPanelTabChange ?? (_detailsTabPanelTabChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DetailsTabPanelTabChange",
					SchemaElementUId = new Guid("a44fc451-9a1e-41b7-a4fc-10bb00e6e2bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwGridActiveRowChanged;
		public ProcessThrowMessageEvent ThrowGridActiveRowChanged {
			get {
				return _throwGridActiveRowChanged ?? (_throwGridActiveRowChanged = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowGridActiveRowChanged",
					SchemaElementUId = new Guid("e3e0c8f4-e7c6-44c6-81bc-de6165a322f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "RefreshDetails",
				});
			}
		}

		private ProcessScriptTask _scriptDetailTabChanged;
		public ProcessScriptTask ScriptDetailTabChanged {
			get {
				return _scriptDetailTabChanged ?? (_scriptDetailTabChanged = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDetailTabChanged",
					SchemaElementUId = new Guid("3430111f-e0b0-4718-9569-56a642c6f0ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDetailTabChangedExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess1;
		public ProcessFlowElement SubProcess1 {
			get {
				return _subProcess1 ?? (_subProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess1",
					SchemaElementUId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseModuleInit;
		public ProcessFlowElement BaseModuleInit {
			get {
				return _baseModuleInit ?? (_baseModuleInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseModuleInit",
					SchemaElementUId = new Guid("7ac99924-e1ff-41b6-ac74-f88199101f4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptBaseGridPageInit;
		public ProcessScriptTask ScriptBaseGridPageInit {
			get {
				return _scriptBaseGridPageInit ?? (_scriptBaseGridPageInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptBaseGridPageInit",
					SchemaElementUId = new Guid("bf254f82-276a-43f5-811a-9754106a7fca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptBaseGridPageInitExecute,
				});
			}
		}

		private ProcessScriptTask _createAnalyticsTab;
		public ProcessScriptTask CreateAnalyticsTab {
			get {
				return _createAnalyticsTab ?? (_createAnalyticsTab = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateAnalyticsTab",
					SchemaElementUId = new Guid("e325b3bb-0aac-4c62-b8bb-247bcb0e3234"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateAnalyticsTabExecute,
				});
			}
		}

		private ProcessScriptTask _scriptPrepareInitializeDetails;
		public ProcessScriptTask ScriptPrepareInitializeDetails {
			get {
				return _scriptPrepareInitializeDetails ?? (_scriptPrepareInitializeDetails = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrepareInitializeDetails",
					SchemaElementUId = new Guid("bf162ea5-c8f1-46f8-a3d1-a427347ab298"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPrepareInitializeDetailsExecute,
				});
			}
		}

		private NewInitializeDetailsFlowElement _newInitializeDetails;
		public NewInitializeDetailsFlowElement NewInitializeDetails {
			get {
				return _newInitializeDetails ?? (_newInitializeDetails = new NewInitializeDetailsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptPrepareInitializePrimaryGrids;
		public ProcessScriptTask ScriptPrepareInitializePrimaryGrids {
			get {
				return _scriptPrepareInitializePrimaryGrids ?? (_scriptPrepareInitializePrimaryGrids = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrepareInitializePrimaryGrids",
					SchemaElementUId = new Guid("efe19fd4-ef4a-472a-a77f-23930ca8c5b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPrepareInitializePrimaryGridsExecute,
				});
			}
		}

		private ModuleInitializePrimaryGridsFlowElement _moduleInitializePrimaryGrids;
		public ModuleInitializePrimaryGridsFlowElement ModuleInitializePrimaryGrids {
			get {
				return _moduleInitializePrimaryGrids ?? (_moduleInitializePrimaryGrids = new ModuleInitializePrimaryGridsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _createChartTabScriptTask;
		public ProcessScriptTask CreateChartTabScriptTask {
			get {
				return _createChartTabScriptTask ?? (_createChartTabScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateChartTabScriptTask",
					SchemaElementUId = new Guid("1de8f7c8-5267-49f9-91cc-771f52be6d64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateChartTabScriptTaskExecute,
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
					SchemaElementUId = new Guid("82767992-6396-4833-87ba-39357ae0fb1a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _applySearchFilter;
		public ProcessFlowElement ApplySearchFilter {
			get {
				return _applySearchFilter ?? (_applySearchFilter = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ApplySearchFilter",
					SchemaElementUId = new Guid("e7cef7ce-590f-47bb-9edb-f76ed34c8462"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptApplySearchFilter;
		public ProcessScriptTask ScriptApplySearchFilter {
			get {
				return _scriptApplySearchFilter ?? (_scriptApplySearchFilter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptApplySearchFilter",
					SchemaElementUId = new Guid("110dcbb5-6faa-43fa-881e-e77579cef33e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptApplySearchFilterExecute,
				});
			}
		}

		private ProcessFlowElement _basePrepareFilterActiveDataSourceSubProcess;
		public ProcessFlowElement BasePrepareFilterActiveDataSourceSubProcess {
			get {
				return _basePrepareFilterActiveDataSourceSubProcess ?? (_basePrepareFilterActiveDataSourceSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BasePrepareFilterActiveDataSourceSubProcess",
					SchemaElementUId = new Guid("2ce54528-6241-4fba-a6c0-9b3a5fdadb7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _basePrepareActiveDataSourceFilterStartMessage;
		public ProcessFlowElement BasePrepareActiveDataSourceFilterStartMessage {
			get {
				return _basePrepareActiveDataSourceFilterStartMessage ?? (_basePrepareActiveDataSourceFilterStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BasePrepareActiveDataSourceFilterStartMessage",
					SchemaElementUId = new Guid("ac0bf2d1-368e-4214-a2ea-f254b638f8bd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptBasePrepareFilters;
		public ProcessScriptTask ScriptBasePrepareFilters {
			get {
				return _scriptBasePrepareFilters ?? (_scriptBasePrepareFilters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptBasePrepareFilters",
					SchemaElementUId = new Guid("d22eefbf-339a-4f62-a566-09366f91bbb8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptBasePrepareFiltersExecute,
				});
			}
		}

		private LoadDynamicFolderFilterUserTaskFlowElement _loadDynamicFolderFilterUserTask;
		public LoadDynamicFolderFilterUserTaskFlowElement LoadDynamicFolderFilterUserTask {
			get {
				return _loadDynamicFolderFilterUserTask ?? (_loadDynamicFolderFilterUserTask = new LoadDynamicFolderFilterUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTaskPrepeareAnalyticsChartFiltersParam;
		public ProcessScriptTask ScriptTaskPrepeareAnalyticsChartFiltersParam {
			get {
				return _scriptTaskPrepeareAnalyticsChartFiltersParam ?? (_scriptTaskPrepeareAnalyticsChartFiltersParam = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPrepeareAnalyticsChartFiltersParam",
					SchemaElementUId = new Guid("34a366df-57cc-4224-bf1e-b98b1c4e11e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPrepeareAnalyticsChartFiltersParamExecute,
				});
			}
		}

		private ProcessExclusiveGateway _loadFiltersExclusiveGateway;
		public ProcessExclusiveGateway LoadFiltersExclusiveGateway {
			get {
				return _loadFiltersExclusiveGateway ?? (_loadFiltersExclusiveGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "LoadFiltersExclusiveGateway",
					SchemaElementUId = new Guid("18390420-e227-43af-9614-1f417152eb6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.LoadFiltersExclusiveGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private LoadRecentFolderFilterUserTaskFlowElement _loadRecentFolderFilterUserTask;
		public LoadRecentFolderFilterUserTaskFlowElement LoadRecentFolderFilterUserTask {
			get {
				return _loadRecentFolderFilterUserTask ?? (_loadRecentFolderFilterUserTask = new LoadRecentFolderFilterUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private LoadDuplicatesFolderFilterUserTaskFlowElement _loadDuplicatesFolderFilterUserTask;
		public LoadDuplicatesFolderFilterUserTaskFlowElement LoadDuplicatesFolderFilterUserTask {
			get {
				return _loadDuplicatesFolderFilterUserTask ?? (_loadDuplicatesFolderFilterUserTask = new LoadDuplicatesFolderFilterUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _subProcessChartMenuItemClick;
		public ProcessFlowElement SubProcessChartMenuItemClick {
			get {
				return _subProcessChartMenuItemClick ?? (_subProcessChartMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChartMenuItemClick",
					SchemaElementUId = new Guid("e3222d9d-a8a6-4ded-babb-036f888b600a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChartMenuItemClick;
		public ProcessFlowElement StartMessageChartMenuItemClick {
			get {
				return _startMessageChartMenuItemClick ?? (_startMessageChartMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChartMenuItemClick",
					SchemaElementUId = new Guid("18357e04-bef8-4316-94b6-a41e9bc6380a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChartMenuItemClick;
		public ProcessScriptTask ScriptChartMenuItemClick {
			get {
				return _scriptChartMenuItemClick ?? (_scriptChartMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChartMenuItemClick",
					SchemaElementUId = new Guid("d61b9529-fb07-469e-ad8d-48fe768395ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChartMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _baseModulePageLoad;
		public ProcessFlowElement BaseModulePageLoad {
			get {
				return _baseModulePageLoad ?? (_baseModulePageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseModulePageLoad",
					SchemaElementUId = new Guid("9489c54c-18d1-4677-901d-e1717e919ba4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageBaseModulePageLoad;
		public ProcessFlowElement StartMessageBaseModulePageLoad {
			get {
				return _startMessageBaseModulePageLoad ?? (_startMessageBaseModulePageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageBaseModulePageLoad",
					SchemaElementUId = new Guid("2ec3cc6f-1752-42e1-9d98-2cda0a26c735"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskBaseModulePageLoad;
		public ProcessScriptTask ScriptTaskBaseModulePageLoad {
			get {
				return _scriptTaskBaseModulePageLoad ?? (_scriptTaskBaseModulePageLoad = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskBaseModulePageLoad",
					SchemaElementUId = new Guid("bfee0893-f2d6-46bc-bb5c-042b58079f4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskBaseModulePageLoadExecute,
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
					SchemaElementUId = new Guid("5fe7ab42-9378-4186-8838-83c8f9e10284"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _reportMenuItemClickEvent;
		public ProcessFlowElement ReportMenuItemClickEvent {
			get {
				return _reportMenuItemClickEvent ?? (_reportMenuItemClickEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ReportMenuItemClickEvent",
					SchemaElementUId = new Guid("cc7e71ef-202a-432b-baa0-dea8efd17219"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("2b598d0f-e35f-4bc2-b692-c6648f906d25"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow622;
		public ProcessConditionalFlow SequenceFlow622 {
			get {
				return _sequenceFlow622 ?? (_sequenceFlow622 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow622",
					SchemaElementUId = new Guid("ad6af38e-970c-4af2-b933-516641462231"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow44;
		public ProcessConditionalFlow ConditionalFlow44 {
			get {
				return _conditionalFlow44 ?? (_conditionalFlow44 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow44",
					SchemaElementUId = new Guid("2a084e94-cc89-44d3-94e8-6dd6d8d0fb00"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow45;
		public ProcessConditionalFlow ConditionalFlow45 {
			get {
				return _conditionalFlow45 ?? (_conditionalFlow45 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow45",
					SchemaElementUId = new Guid("17a592fc-49c1-4fa1-9e7c-dca30055fe08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow46;
		public ProcessConditionalFlow ConditionalFlow46 {
			get {
				return _conditionalFlow46 ?? (_conditionalFlow46 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow46",
					SchemaElementUId = new Guid("af35487b-b09e-4346-8e98-e00c1ade3a53"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _isDuplicatesFolderConditionalFlow;
		public ProcessConditionalFlow IsDuplicatesFolderConditionalFlow {
			get {
				return _isDuplicatesFolderConditionalFlow ?? (_isDuplicatesFolderConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsDuplicatesFolderConditionalFlow",
					SchemaElementUId = new Guid("c941b19f-7286-41fa-bda1-df3986f10a79"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _createNewProcessMenuItemCaption;
		public LocalizableString CreateNewProcessMenuItemCaption {
			get {
				return _createNewProcessMenuItemCaption ?? (_createNewProcessMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CreateNewProcessMenuItemCaption.Value"));
			}
		}

		private LocalizableString _editProcessMenuItemCaption;
		public LocalizableString EditProcessMenuItemCaption {
			get {
				return _editProcessMenuItemCaption ?? (_editProcessMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EditProcessMenuItemCaption.Value"));
			}
		}

		private LocalizableString _deleteProcessMenuItemCaption;
		public LocalizableString DeleteProcessMenuItemCaption {
			get {
				return _deleteProcessMenuItemCaption ?? (_deleteProcessMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteProcessMenuItemCaption.Value"));
			}
		}

		private LocalizableString _tuningModeCaption;
		public LocalizableString TuningModeCaption {
			get {
				return _tuningModeCaption ?? (_tuningModeCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TuningModeCaption.Value"));
			}
		}

		private LocalizableString _lunchModeCaption;
		public LocalizableString LunchModeCaption {
			get {
				return _lunchModeCaption ?? (_lunchModeCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LunchModeCaption.Value"));
			}
		}

		private LocalizableString _analyticsTabCaption;
		public LocalizableString AnalyticsTabCaption {
			get {
				return _analyticsTabCaption ?? (_analyticsTabCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AnalyticsTabCaption.Value"));
			}
		}

		private LocalizableString _openProcessDesignerCaption;
		public LocalizableString OpenProcessDesignerCaption {
			get {
				return _openProcessDesignerCaption ?? (_openProcessDesignerCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OpenProcessDesignerCaption.Value"));
			}
		}

		private LocalizableString _moduleProcessInstanceNotExistCaption;
		public LocalizableString ModuleProcessInstanceNotExistCaption {
			get {
				return _moduleProcessInstanceNotExistCaption ?? (_moduleProcessInstanceNotExistCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ModuleProcessInstanceNotExistCaption.Value"));
			}
		}

		private LocalizableString _moduleProcessInstanceNotExistMessage;
		public LocalizableString ModuleProcessInstanceNotExistMessage {
			get {
				return _moduleProcessInstanceNotExistMessage ?? (_moduleProcessInstanceNotExistMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ModuleProcessInstanceNotExistMessage.Value"));
			}
		}

		private LocalizableString _runFromModuleErrorCaption;
		public LocalizableString RunFromModuleErrorCaption {
			get {
				return _runFromModuleErrorCaption ?? (_runFromModuleErrorCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RunFromModuleErrorCaption.Value"));
			}
		}

		private LocalizableString _runFromModuleErrorMessage;
		public LocalizableString RunFromModuleErrorMessage {
			get {
				return _runFromModuleErrorMessage ?? (_runFromModuleErrorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RunFromModuleErrorMessage.Value"));
			}
		}

		private LocalizableString _chartStartTabCaption;
		public LocalizableString ChartStartTabCaption {
			get {
				return _chartStartTabCaption ?? (_chartStartTabCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChartStartTabCaption.Value"));
			}
		}

		private LocalizableString _deleteProcessMessage;
		public LocalizableString DeleteProcessMessage {
			get {
				return _deleteProcessMessage ?? (_deleteProcessMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteProcessMessage.Value"));
			}
		}

		private LocalizableString _warning;
		public LocalizableString Warning {
			get {
				return _warning ?? (_warning = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Warning.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ApplyToolButtonSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyToolButtonSubProcess };
			FlowElements[ApplyToolButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyToolButtonClick };
			FlowElements[ApplyFiltersToolButtonScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyFiltersToolButtonScript };
			FlowElements[SaveToolButtonSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveToolButtonSubProcess };
			FlowElements[SaveToolButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveToolButtonClick };
			FlowElements[SaveFiltersToolButtonScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveFiltersToolButtonScript };
			FlowElements[SaveFiltersUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveFiltersUserTask };
			FlowElements[ClearToolButtonSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearToolButtonSubProcess };
			FlowElements[ClearToolButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearToolButtonClick };
			FlowElements[ClearFiltersToolButtonScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearFiltersToolButtonScript };
			FlowElements[SubProcessSelectFolder.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSelectFolder };
			FlowElements[SelectFolderMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectFolderMessage };
			FlowElements[ScriptSelectFolder.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSelectFolder };
			FlowElements[EventSubProcessActualPrimaryGridData.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessActualPrimaryGridData };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptActualizeGridData.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptActualizeGridData };
			FlowElements[SubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess7 };
			FlowElements[TuningModeChangedEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { TuningModeChangedEvent };
			FlowElements[ScriptSwitchProcessMode.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSwitchProcessMode };
			FlowElements[SubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess12 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[MessageWindowUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MessageWindowUserTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessageNonInterruptingEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageNonInterruptingEvent2 };
			FlowElements[ScriptFolderActiveRowChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptFolderActiveRowChanged };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[ScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadComplete };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[IntermediateThrowRefreshDetails.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowRefreshDetails };
			FlowElements[StartGridLoadRows.SchemaElementUId] = new Collection<ProcessFlowElement> { StartGridLoadRows };
			FlowElements[GridActiveRowChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { GridActiveRowChanged };
			FlowElements[ScriptGridActiveRowChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridActiveRowChanged };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[SetDetailFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { SetDetailFilter };
			FlowElements[End2.SchemaElementUId] = new Collection<ProcessFlowElement> { End2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[RefreshDetails.SchemaElementUId] = new Collection<ProcessFlowElement> { RefreshDetails };
			FlowElements[ScriptRefreshDetails.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptRefreshDetails };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[DetailsTabPanelTabChange.SchemaElementUId] = new Collection<ProcessFlowElement> { DetailsTabPanelTabChange };
			FlowElements[ThrowGridActiveRowChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowGridActiveRowChanged };
			FlowElements[ScriptDetailTabChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDetailTabChanged };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[BaseModuleInit.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseModuleInit };
			FlowElements[ScriptBaseGridPageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptBaseGridPageInit };
			FlowElements[CreateAnalyticsTab.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateAnalyticsTab };
			FlowElements[ScriptPrepareInitializeDetails.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepareInitializeDetails };
			FlowElements[NewInitializeDetails.SchemaElementUId] = new Collection<ProcessFlowElement> { NewInitializeDetails };
			FlowElements[ScriptPrepareInitializePrimaryGrids.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepareInitializePrimaryGrids };
			FlowElements[ModuleInitializePrimaryGrids.SchemaElementUId] = new Collection<ProcessFlowElement> { ModuleInitializePrimaryGrids };
			FlowElements[CreateChartTabScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateChartTabScriptTask };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[ApplySearchFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplySearchFilter };
			FlowElements[ScriptApplySearchFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptApplySearchFilter };
			FlowElements[BasePrepareFilterActiveDataSourceSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePrepareFilterActiveDataSourceSubProcess };
			FlowElements[BasePrepareActiveDataSourceFilterStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePrepareActiveDataSourceFilterStartMessage };
			FlowElements[ScriptBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptBasePrepareFilters };
			FlowElements[LoadDynamicFolderFilterUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadDynamicFolderFilterUserTask };
			FlowElements[ScriptTaskPrepeareAnalyticsChartFiltersParam.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPrepeareAnalyticsChartFiltersParam };
			FlowElements[LoadFiltersExclusiveGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadFiltersExclusiveGateway };
			FlowElements[LoadRecentFolderFilterUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadRecentFolderFilterUserTask };
			FlowElements[LoadDuplicatesFolderFilterUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadDuplicatesFolderFilterUserTask };
			FlowElements[SubProcessChartMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChartMenuItemClick };
			FlowElements[StartMessageChartMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChartMenuItemClick };
			FlowElements[ScriptChartMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChartMenuItemClick };
			FlowElements[BaseModulePageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseModulePageLoad };
			FlowElements[StartMessageBaseModulePageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageBaseModulePageLoad };
			FlowElements[ScriptTaskBaseModulePageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskBaseModulePageLoad };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[ReportMenuItemClickEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ReportMenuItemClickEvent };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ApplyToolButtonSubProcess":
						break;
					case "ApplyToolButtonClick":
						e.Context.QueueTasks.Enqueue("ApplyFiltersToolButtonScript");
						break;
					case "ApplyFiltersToolButtonScript":
						break;
					case "SaveToolButtonSubProcess":
						break;
					case "SaveToolButtonClick":
						e.Context.QueueTasks.Enqueue("SaveFiltersToolButtonScript");
						break;
					case "SaveFiltersToolButtonScript":
						e.Context.QueueTasks.Enqueue("SaveFiltersUserTask");
						break;
					case "SaveFiltersUserTask":
						break;
					case "ClearToolButtonSubProcess":
						break;
					case "ClearToolButtonClick":
						e.Context.QueueTasks.Enqueue("ClearFiltersToolButtonScript");
						break;
					case "ClearFiltersToolButtonScript":
						break;
					case "SubProcessSelectFolder":
						break;
					case "SelectFolderMessage":
						e.Context.QueueTasks.Enqueue("ScriptSelectFolder");
						break;
					case "ScriptSelectFolder":
						break;
					case "EventSubProcessActualPrimaryGridData":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptActualizeGridData");
						break;
					case "ScriptActualizeGridData":
						break;
					case "SubProcess7":
						break;
					case "TuningModeChangedEvent":
						e.Context.QueueTasks.Enqueue("ScriptSwitchProcessMode");
						break;
					case "ScriptSwitchProcessMode":
						break;
					case "SubProcess12":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("MessageWindowUserTask");
						break;
					case "MessageWindowUserTask":
						break;
					case "EventSubProcess1":
						break;
					case "StartMessageNonInterruptingEvent2":
						e.Context.QueueTasks.Enqueue("ScriptFolderActiveRowChanged");
						break;
					case "ScriptFolderActiveRowChanged":
						break;
					case "EventSubProcess2":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadComplete");
						break;
					case "ScriptPageLoadComplete":
						break;
					case "EventSubProcess4":
						break;
					case "IntermediateThrowRefreshDetails":
						break;
					case "StartGridLoadRows":
						e.Context.QueueTasks.Enqueue("ScriptGridActiveRowChanged");
						break;
					case "GridActiveRowChanged":
						e.Context.QueueTasks.Enqueue("ScriptGridActiveRowChanged");
						break;
					case "ScriptGridActiveRowChanged":
						e.Context.QueueTasks.Enqueue("IntermediateThrowRefreshDetails");
						break;
					case "EventSubProcess6":
						break;
					case "SetDetailFilter":
						break;
					case "End2":
						break;
					case "ExclusiveGateway1":
						if (SequenceFlow622ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("SetDetailFilter");
							break;
						}
						e.Context.QueueTasks.Enqueue("End2");
						break;
					case "RefreshDetails":
						e.Context.QueueTasks.Enqueue("ScriptRefreshDetails");
						break;
					case "ScriptRefreshDetails":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "EventSubProcess7":
						break;
					case "DetailsTabPanelTabChange":
						e.Context.QueueTasks.Enqueue("ScriptDetailTabChanged");
						break;
					case "ThrowGridActiveRowChanged":
						break;
					case "ScriptDetailTabChanged":
						e.Context.QueueTasks.Enqueue("ThrowGridActiveRowChanged");
						break;
					case "SubProcess1":
						break;
					case "BaseModuleInit":
						e.Context.QueueTasks.Enqueue("ScriptBaseGridPageInit");
						e.Context.QueueTasks.Enqueue("ScriptPrepareInitializePrimaryGrids");
						e.Context.QueueTasks.Enqueue("ScriptPrepareInitializeDetails");
						break;
					case "ScriptBaseGridPageInit":
						break;
					case "CreateAnalyticsTab":
						e.Context.QueueTasks.Enqueue("CreateChartTabScriptTask");
						break;
					case "ScriptPrepareInitializeDetails":
						e.Context.QueueTasks.Enqueue("NewInitializeDetails");
						break;
					case "NewInitializeDetails":
						break;
					case "ScriptPrepareInitializePrimaryGrids":
						e.Context.QueueTasks.Enqueue("ModuleInitializePrimaryGrids");
						break;
					case "ModuleInitializePrimaryGrids":
							e.Context.QueueTasks.Enqueue("CreateAnalyticsTab");
						break;
					case "CreateChartTabScriptTask":
						break;
					case "SubProcess2":
						break;
					case "ApplySearchFilter":
						e.Context.QueueTasks.Enqueue("ScriptApplySearchFilter");
						break;
					case "ScriptApplySearchFilter":
						break;
					case "BasePrepareFilterActiveDataSourceSubProcess":
						break;
					case "BasePrepareActiveDataSourceFilterStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptBasePrepareFilters");
						break;
					case "ScriptBasePrepareFilters":
						e.Context.QueueTasks.Enqueue("ScriptTaskPrepeareAnalyticsChartFiltersParam");
						if (ConditionalFlow44ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("LoadFiltersExclusiveGateway");
							break;
						}
						break;
					case "LoadDynamicFolderFilterUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTaskPrepeareAnalyticsChartFiltersParam");
						break;
					case "ScriptTaskPrepeareAnalyticsChartFiltersParam":
						break;
					case "LoadFiltersExclusiveGateway":
						if (ConditionalFlow45ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("LoadDynamicFolderFilterUserTask");
							break;
						}
						if (ConditionalFlow46ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("LoadRecentFolderFilterUserTask");
							break;
						}
						if (IsDuplicatesFolderConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("LoadDuplicatesFolderFilterUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTaskPrepeareAnalyticsChartFiltersParam");
						break;
					case "LoadRecentFolderFilterUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTaskPrepeareAnalyticsChartFiltersParam");
						break;
					case "LoadDuplicatesFolderFilterUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTaskPrepeareAnalyticsChartFiltersParam");
						break;
					case "SubProcessChartMenuItemClick":
						break;
					case "StartMessageChartMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptChartMenuItemClick");
						break;
					case "ScriptChartMenuItemClick":
						break;
					case "BaseModulePageLoad":
						break;
					case "StartMessageBaseModulePageLoad":
						e.Context.QueueTasks.Enqueue("ScriptTaskBaseModulePageLoad");
						break;
					case "ScriptTaskBaseModulePageLoad":
						break;
					case "EventSubProcess5":
						break;
					case "ReportMenuItemClickEvent":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow622ExpressionExecute() {
			return Convert.ToBoolean(HasDetails);
		}

		private bool ConditionalFlow44ExpressionExecute() {
			return Convert.ToBoolean(!IgnoreSearchFilter);
		}

		private bool ConditionalFlow45ExpressionExecute() {
			return Convert.ToBoolean(SearchFolder);
		}

		private bool ConditionalFlow46ExpressionExecute() {
			return Convert.ToBoolean(IsRecentFolder);
		}

		private bool IsDuplicatesFolderConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(IsDuplicatesFolder);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ApplyToolButtonClick");
			ActivatedEventElements.Add("SaveToolButtonClick");
			ActivatedEventElements.Add("ClearToolButtonClick");
			ActivatedEventElements.Add("SelectFolderMessage");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("TuningModeChangedEvent");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessageNonInterruptingEvent2");
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("StartGridLoadRows");
			ActivatedEventElements.Add("GridActiveRowChanged");
			ActivatedEventElements.Add("RefreshDetails");
			ActivatedEventElements.Add("DetailsTabPanelTabChange");
			ActivatedEventElements.Add("BaseModuleInit");
			ActivatedEventElements.Add("ApplySearchFilter");
			ActivatedEventElements.Add("BasePrepareActiveDataSourceFilterStartMessage");
			ActivatedEventElements.Add("StartMessageChartMenuItemClick");
			ActivatedEventElements.Add("StartMessageBaseModulePageLoad");
			ActivatedEventElements.Add("ReportMenuItemClickEvent");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ApplyToolButtonSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ApplyToolButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyToolButtonClick";
					result = ApplyToolButtonClick.Execute(context);
					break;
				case "ApplyFiltersToolButtonScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyFiltersToolButtonScript";
					result = ApplyFiltersToolButtonScript.Execute(context, ApplyFiltersToolButtonScriptExecute);
					break;
				case "SaveToolButtonSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SaveToolButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveToolButtonClick";
					result = SaveToolButtonClick.Execute(context);
					break;
				case "SaveFiltersToolButtonScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveFiltersToolButtonScript";
					result = SaveFiltersToolButtonScript.Execute(context, SaveFiltersToolButtonScriptExecute);
					break;
				case "SaveFiltersUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveFiltersUserTask";
					result = SaveFiltersUserTask.Execute(context);
					break;
				case "ClearToolButtonSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ClearToolButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClearToolButtonClick";
					result = ClearToolButtonClick.Execute(context);
					break;
				case "ClearFiltersToolButtonScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClearFiltersToolButtonScript";
					result = ClearFiltersToolButtonScript.Execute(context, ClearFiltersToolButtonScriptExecute);
					break;
				case "SubProcessSelectFolder":
					context.QueueTasks.Dequeue();
					break;
				case "SelectFolderMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectFolderMessage";
					result = SelectFolderMessage.Execute(context);
					break;
				case "ScriptSelectFolder":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSelectFolder";
					result = ScriptSelectFolder.Execute(context, ScriptSelectFolderExecute);
					break;
				case "EventSubProcessActualPrimaryGridData":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptActualizeGridData":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptActualizeGridData";
					result = ScriptActualizeGridData.Execute(context, ScriptActualizeGridDataExecute);
					break;
				case "SubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "TuningModeChangedEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "TuningModeChangedEvent";
					result = TuningModeChangedEvent.Execute(context);
					break;
				case "ScriptSwitchProcessMode":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSwitchProcessMode";
					result = ScriptSwitchProcessMode.Execute(context, ScriptSwitchProcessModeExecute);
					break;
				case "SubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "MessageWindowUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MessageWindowUserTask";
					result = MessageWindowUserTask.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageNonInterruptingEvent2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageNonInterruptingEvent2";
					result = StartMessageNonInterruptingEvent2.Execute(context);
					break;
				case "ScriptFolderActiveRowChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptFolderActiveRowChanged";
					result = ScriptFolderActiveRowChanged.Execute(context, ScriptFolderActiveRowChangedExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete";
					result = PageLoadComplete.Execute(context);
					break;
				case "ScriptPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadComplete";
					result = ScriptPageLoadComplete.Execute(context, ScriptPageLoadCompleteExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "IntermediateThrowRefreshDetails":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowRefreshDetails.Execute(context);
					break;
				case "StartGridLoadRows":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartGridLoadRows";
					result = StartGridLoadRows.Execute(context);
					break;
				case "GridActiveRowChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "GridActiveRowChanged";
					result = GridActiveRowChanged.Execute(context);
					break;
				case "ScriptGridActiveRowChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGridActiveRowChanged";
					result = ScriptGridActiveRowChanged.Execute(context, ScriptGridActiveRowChangedExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "SetDetailFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetDetailFilter";
					result = SetDetailFilter.Execute(context);
					break;
				case "End2":
					context.QueueTasks.Dequeue();
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "RefreshDetails":
					context.QueueTasks.Dequeue();
					context.SenderName = "RefreshDetails";
					result = RefreshDetails.Execute(context);
					break;
				case "ScriptRefreshDetails":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptRefreshDetails";
					result = ScriptRefreshDetails.Execute(context, ScriptRefreshDetailsExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "DetailsTabPanelTabChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "DetailsTabPanelTabChange";
					result = DetailsTabPanelTabChange.Execute(context);
					break;
				case "ThrowGridActiveRowChanged":
					context.QueueTasks.Dequeue();
					result = ThrowGridActiveRowChanged.Execute(context);
					break;
				case "ScriptDetailTabChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDetailTabChanged";
					result = ScriptDetailTabChanged.Execute(context, ScriptDetailTabChangedExecute);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "BaseModuleInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseModuleInit";
					result = BaseModuleInit.Execute(context);
					break;
				case "ScriptBaseGridPageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptBaseGridPageInit";
					result = ScriptBaseGridPageInit.Execute(context, ScriptBaseGridPageInitExecute);
					break;
				case "CreateAnalyticsTab":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateAnalyticsTab";
					result = CreateAnalyticsTab.Execute(context, CreateAnalyticsTabExecute);
					break;
				case "ScriptPrepareInitializeDetails":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPrepareInitializeDetails";
					result = ScriptPrepareInitializeDetails.Execute(context, ScriptPrepareInitializeDetailsExecute);
					break;
				case "NewInitializeDetails":
					context.QueueTasks.Dequeue();
					context.SenderName = "NewInitializeDetails";
					result = NewInitializeDetails.Execute(context);
					break;
				case "ScriptPrepareInitializePrimaryGrids":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPrepareInitializePrimaryGrids";
					result = ScriptPrepareInitializePrimaryGrids.Execute(context, ScriptPrepareInitializePrimaryGridsExecute);
					break;
				case "ModuleInitializePrimaryGrids":
					context.QueueTasks.Dequeue();
					context.SenderName = "ModuleInitializePrimaryGrids";
					result = ModuleInitializePrimaryGrids.Execute(context);
					break;
				case "CreateChartTabScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateChartTabScriptTask";
					result = CreateChartTabScriptTask.Execute(context, CreateChartTabScriptTaskExecute);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ApplySearchFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplySearchFilter";
					result = ApplySearchFilter.Execute(context);
					break;
				case "ScriptApplySearchFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptApplySearchFilter";
					result = ScriptApplySearchFilter.Execute(context, ScriptApplySearchFilterExecute);
					break;
				case "BasePrepareFilterActiveDataSourceSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BasePrepareActiveDataSourceFilterStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BasePrepareActiveDataSourceFilterStartMessage";
					result = BasePrepareActiveDataSourceFilterStartMessage.Execute(context);
					break;
				case "ScriptBasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptBasePrepareFilters";
					result = ScriptBasePrepareFilters.Execute(context, ScriptBasePrepareFiltersExecute);
					break;
				case "LoadDynamicFolderFilterUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LoadDynamicFolderFilterUserTask";
					result = LoadDynamicFolderFilterUserTask.Execute(context);
					break;
				case "ScriptTaskPrepeareAnalyticsChartFiltersParam":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPrepeareAnalyticsChartFiltersParam";
					result = ScriptTaskPrepeareAnalyticsChartFiltersParam.Execute(context, ScriptTaskPrepeareAnalyticsChartFiltersParamExecute);
					break;
				case "LoadFiltersExclusiveGateway":
					context.QueueTasks.Dequeue();
					context.SenderName = "LoadFiltersExclusiveGateway";
					result = LoadFiltersExclusiveGateway.Execute(context);
					break;
				case "LoadRecentFolderFilterUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LoadRecentFolderFilterUserTask";
					result = LoadRecentFolderFilterUserTask.Execute(context);
					break;
				case "LoadDuplicatesFolderFilterUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LoadDuplicatesFolderFilterUserTask";
					result = LoadDuplicatesFolderFilterUserTask.Execute(context);
					break;
				case "SubProcessChartMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChartMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChartMenuItemClick";
					result = StartMessageChartMenuItemClick.Execute(context);
					break;
				case "ScriptChartMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChartMenuItemClick";
					result = ScriptChartMenuItemClick.Execute(context, ScriptChartMenuItemClickExecute);
					break;
				case "BaseModulePageLoad":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageBaseModulePageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageBaseModulePageLoad";
					result = StartMessageBaseModulePageLoad.Execute(context);
					break;
				case "ScriptTaskBaseModulePageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskBaseModulePageLoad";
					result = ScriptTaskBaseModulePageLoad.Execute(context, ScriptTaskBaseModulePageLoadExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "ReportMenuItemClickEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReportMenuItemClickEvent";
					result = ReportMenuItemClickEvent.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
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
				case "AnalyticsChartPageContainerID":
					AnalyticsChartPageContainerID = reader.GetValue<System.String>();
				break;
				case "HasActions":
					HasActions = reader.GetValue<System.Boolean>();
				break;
				case "SearchFilterEnabled":
					SearchFilterEnabled = reader.GetValue<System.Boolean>();
				break;
				case "CustomChartIdList":
					CustomChartIdList = reader.GetSerializableObjectValue();
				break;
				case "OldTabPanelClientId":
					OldTabPanelClientId = reader.GetValue<System.String>();
				break;
				case "CurrentChartPropertyId":
					CurrentChartPropertyId = reader.GetValue<System.Guid>();
				break;
				case "IsDuplicatesFolder":
					IsDuplicatesFolder = reader.GetValue<System.Boolean>();
				break;
				case "SysModuleProcessPrimaryColumnUId":
					SysModuleProcessPrimaryColumnUId = reader.GetValue<System.Guid>();
				break;
				case "CurrentReportSchemaUId":
					CurrentReportSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "TypeColumnUId":
					TypeColumnUId = reader.GetValue<System.Guid>();
				break;
				case "SysEntitySchemaId":
					SysEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "FoldersMode":
					FoldersMode = reader.GetValue<System.String>();
				break;
				case "RootFolderId":
					RootFolderId = reader.GetValue<System.Guid>();
				break;
				case "IsRecentFolder":
					IsRecentFolder = reader.GetValue<System.Boolean>();
				break;
				case "AnalyticsTabName":
					AnalyticsTabName = reader.GetValue<System.String>();
				break;
				case "ClearFilterEditFilters":
					ClearFilterEditFilters = reader.GetValue<System.Boolean>();
				break;
				case "_isHasAnalyticsInitialized":
					_isHasAnalyticsInitialized = reader.GetValue<System.Boolean>();
				break;
				case "MainPageProcessUId":
					MainPageProcessUId = reader.GetValue<System.String>();
				break;
				case "CurrentChartCaption":
					CurrentChartCaption = reader.GetValue<System.String>();
				break;
				case "ChartTabItemClientID":
					ChartTabItemClientID = reader.GetValue<System.String>();
				break;
				case "HasAnalytics":
					HasAnalytics = reader.GetValue<System.Boolean>();
				break;
				case "PDV":
					PDV = reader.GetValue<System.String>();
				break;
				case "PCV":
					PCV = reader.GetValue<System.Guid>();
				break;
				case "IgnoreSearchFilter":
					IgnoreSearchFilter = reader.GetValue<System.Boolean>();
				break;
				case "StaticFolder":
					StaticFolder = reader.GetValue<System.Boolean>();
				break;
				case "SearchFolder":
					SearchFolder = reader.GetValue<System.Boolean>();
				break;
				case "GotoFolderId":
					GotoFolderId = reader.GetValue<System.Guid>();
				break;
				case "ModuleProcessesCaption":
					ModuleProcessesCaption = reader.GetSerializableObjectValue();
				break;
				case "IsModuleProcessesTuningMode":
					IsModuleProcessesTuningMode = reader.GetValue<System.Boolean>();
				break;
				case "ModuleProcesses":
					ModuleProcesses = reader.GetSerializableObjectValue();
				break;
				case "SearchPrimaryDisplayColumnValue":
					SearchPrimaryDisplayColumnValue = reader.GetValue<System.String>();
				break;
				case "HasDetails":
					HasDetails = reader.GetValue<System.Boolean>();
				break;
				case "FilterColumnValue":
					FilterColumnValue = reader.GetValue<System.Guid>();
				break;
				case "SysModuleId":
					SysModuleId = reader.GetValue<System.Guid>();
				break;
				case "IsRootFolder":
					IsRootFolder = reader.GetValue<System.Boolean>();
				break;
				case "FolderId":
					FolderId = reader.GetValue<System.Guid>();
				break;
				case "FolderEntryEntitySchemaUId":
					FolderEntryEntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "FolderEntitySchemaUId":
					FolderEntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ApplyFiltersToolButtonScriptExecute(ProcessExecutingContext context) {
			IgnoreSearchFilter = true;
			ClearFilterEditFilters = false;
			ApplyFilters();
			ApplyFiltersForAnalitics();
			return true;
		}

		public virtual bool SaveFiltersToolButtonScriptExecute(ProcessExecutingContext context) {
			if (FolderId != Guid.Empty && SearchFolder){
				var folderInfo = GetFolderInfo();
				IgnoreSearchFilter = false;
				Guid dynamicFolderTypeId = new Guid("65CA0946-0084-4874-B117-C13199AF3B95");
				Guid emailFolderTypeId = new Guid("6E23FA26-5BEE-E011-A86B-00155D04C01D");
				if (folderInfo != null && folderInfo.Length.Equals(2)) {
					Guid folderTypeId = new Guid(folderInfo[0].ToString());
					if (folderTypeId.Equals(dynamicFolderTypeId) || folderTypeId.Equals(emailFolderTypeId)) {
						var folderSchema = (Page.BaseFolder.FindPageControlByName("DataSource") as DataSource).Schema;
						var columnUId = folderSchema.Columns.GetByName("SearchData").UId;
						SaveFiltersUserTask.DataSource = GetActiveDataSource();
						SaveFiltersUserTask.StoringEntitySchemaId = folderSchema.UId;
						SaveFiltersUserTask.StoringColumnUId = columnUId;
						SaveFiltersUserTask.StoringPrimaryColumnValue = FolderId;
						return true;
					}
				}
				SaveFiltersUserTask.StoringPrimaryColumnValue = Guid.Empty;
			}
			return true;
		}

		public virtual bool ClearFiltersToolButtonScriptExecute(ProcessExecutingContext context) {
			var dataSource = GetActiveDataSource();//Page.FilterEdit.Clear();
			var filterEditGroup = dataSource.CurrentStructure.Filters.FindByName("FilterEdit") 
									as Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection;
			if (filterEditGroup != null) {
				filterEditGroup.Clear();
			}
			IgnoreSearchFilter = true;
			ApplyFiltersForAnalitics();
			return true;
		}

		public virtual bool ScriptSelectFolderExecute(ProcessExecutingContext context) {
			string folderId = String.Empty;
			if (!GotoFolderId.Equals(Guid.Empty)) {
				folderId = GotoFolderId.ToString();
			}
			folderId = (context.ThrowEventArgs as List<object>)[0].ToString();
			(Page.BaseFolder.FindPageControlByName("TreeGrid") as TreeGrid).SelectNode(folderId);
			GotoFolderId = Guid.Empty;
			return true;
		}

		public virtual bool ScriptActualizeGridDataExecute(ProcessExecutingContext context) {
			if (!Page.CustomSearchContainer.Hidden && Page.CustomSearchContainer.PageInstance != null) {
				var dataSource = GetActiveDataSource();
				Page.CustomSearchContainer.PageInstance.Process.SetPropertyValue("TargetDataSource", dataSource);
			}
			var activeTab = Page.GridTabPanel.Tabs[Page.GridTabPanel.ActiveTabIndex];
			var isGridTab = activeTab.Name != AnalyticsTabName;
			if (!string.IsNullOrEmpty(ChartTabItemClientID)) {
				isGridTab = !activeTab.ClientID.Contains(ChartTabItemClientID);
			}
			if (isGridTab) {
				Page.FilterEdit.SetDataSource(GetActiveDataSource(), true);
				ApplyFilters();
				var activePage = (activeTab.Items[0] as PageContainer).PageInstance;
				activePage.Process.SetPropertyValue("IsModuleProcessesTuningMode", IsModuleProcessesTuningMode);
				activePage.ThrowEvent("TuningModeChanged");
			}
			return true;
		}

		public virtual bool ScriptSwitchProcessModeExecute(ProcessExecutingContext context) {
			IsModuleProcessesTuningMode = !IsModuleProcessesTuningMode;
			if (!string.IsNullOrEmpty(MainPageProcessUId)) {
				var process = UserConnection.IProcessEngine.GetProcessByUId(MainPageProcessUId);
				process.SetPropertyValue("TuningProcessMode", IsModuleProcessesTuningMode);
				process.SetPropertyValue("IsTuningModule", true);
			}
			var activeTab = Page.GridTabPanel.Tabs[Page.GridTabPanel.ActiveTabIndex];
			var isGridTab = activeTab.Name != AnalyticsTabName;
			if (isGridTab && !string.IsNullOrEmpty(ChartTabItemClientID)) {
				isGridTab = !activeTab.ClientID.Contains(ChartTabItemClientID);
			}
			if (!string.IsNullOrEmpty(AnalyticsTabName)) {
				Tab tab = ControlUtilities.FindControl(Page.PageContainer, AnalyticsTabName, true) as Tab;
				if (tab != null && tab.Items.Count > 0 && tab.Items[0] is PageContainer) {
					var analyticsPage = (tab.Items[0] as PageContainer).PageInstance;
					analyticsPage.Process.SetPropertyValue("IsModuleProcessesTuningMode", IsModuleProcessesTuningMode);
					analyticsPage.ThrowEvent("TuningModeChanged");
				}
			}
			if (isGridTab) {
				ApplyFilters();
				var activePage = (activeTab.Items[0] as PageContainer).PageInstance;
				activePage.Process.SetPropertyValue("IsModuleProcessesTuningMode", IsModuleProcessesTuningMode);
				activePage.ThrowEvent("TuningModeChanged");
			}
			
			var detailsTabPanel = Page.PageContainer.FindPageControlByName("DetailsTabPanel") as Terrasoft.UI.WebControls.Controls.TabPanel;
			foreach (var tab in detailsTabPanel.Tabs) {
				if (tab.Items.Count > 0) {
					var page = (tab.Items[0] as Terrasoft.UI.WebControls.Controls.PageContainer).PageInstance;
					page.Process.SetPropertyValue("IsModuleProcessesTuningMode", IsModuleProcessesTuningMode);
					page.ThrowEvent("SetDetailPrintButtonMenu");
				}
			}
			
			return true;
		}

		public virtual bool ScriptFolderActiveRowChangedExecute(ProcessExecutingContext context) {
			ClearFilterEditFilters = true;
			IgnoreSearchFilter = false;
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["SysModule_selectedFolderId"] = FolderId.ToString();
			if (string.IsNullOrEmpty(SearchPrimaryDisplayColumnValue) || !Ext.IsAjaxRequest) {
				ApplyFilters();
			} else if (!string.IsNullOrEmpty(MainPageProcessUId)) {
				var process = UserConnection.IProcessEngine.FindProcessByUId(MainPageProcessUId);
				if (process != null) {
					process.ThrowEvent(process.InternalContext, "ClearToolButtonClick");
				}
			}
			return true;
		}

		public virtual bool ScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			return OnPageLoadComlete();
		}

		public virtual bool ScriptGridActiveRowChangedExecute(ProcessExecutingContext context) {
			var dataSource = GetActiveDataSource();
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["SysModule_activeDataSource"] = dataSource.ClientID;
			if (dataSource.SelectedItemPrimaryColumnValues.Count > 0) {
				FilterColumnValue = dataSource.ActiveRowPrimaryColumnValue;
			}
			else {
				FilterColumnValue = Guid.Empty;
			}
			return true;
		}

		public virtual bool ScriptRefreshDetailsExecute(ProcessExecutingContext context) {
			HasDetails = false;
			var detailsTabPanel = Page.DetailsTabPanel;
			var page = Page.AspPage as Terrasoft.UI.WebControls.Page;
			bool detailCollapsed = detailsTabPanel.Collapsed;
			if (page.UseProfile && !Terrasoft.UI.WebControls.Ext.IsAjaxRequest) {
				var profileData = page.ProfileData;
				var profileItem = profileData[detailsTabPanel.ClientID];
				if (profileItem != null) {
					if (profileItem.Values.ContainsKey("collapsed")) {
						detailCollapsed = bool.Parse(profileItem.Values["collapsed"].ToString());
					}		
				}
			}
			if(detailsTabPanel.Tabs.Count == 0 ||  detailsTabPanel.Hidden) {	
				return true;
			}
			var detailsTab = detailsTabPanel.Tabs[detailsTabPanel.ActiveTabIndex];
			if (!Page.AspPage.IsPostBack) {
				for (int i = 0; i < detailsTabPanel.Tabs.Count; i++) {
					if (detailsTabPanel.Tabs[i].Items.Count > 0) {
						detailsTab = detailsTabPanel.Tabs[i];
						break;
					}
				}
			}
			if (detailsTab.Items.Count == 0) {
				return true;
			}
			var detailPageContainer = detailsTab.Items[0] as PageContainer;
			if (detailPageContainer == null) {
				return true;
			}
			HasDetails = true;
			var detailProcess = detailPageContainer.PageInstance.Process;
			var filterLeftExpression = detailProcess.GetPropertyValue("FilterLeftExpression") as Array;
			var parentColumnMetaPath = detailProcess.GetPropertyValue("ParentColumnMetaPath") == null ? 
				string.Empty : detailProcess.GetPropertyValue("ParentColumnMetaPath").ToString();
			detailProcess.SetPropertyValue("SelectedNodePrimaryColumnValue", FilterColumnValue);
			SetDetailFilter.FilterName = "DetailFilter";
			SetDetailFilter.SysEntitySchemaId = SysEntitySchemaId;
			SetDetailFilter.ParentColumnMetaPath = parentColumnMetaPath;
			SetDetailFilter.DetailPageContainer = detailPageContainer;
			SetDetailFilter.PageDataSource = Page.Grid.FindPageControlByName("DataSource");
			SetDetailFilter.DetailPageFilterName = "DataSourceFilter";
			SetDetailFilter.ThrowEventName = "GridPageRefreshRow";
			SetDetailFilter.FilterLeftExpressions = filterLeftExpression;
			SetDetailFilter.FilterRightValue = FilterColumnValue;
			return true;
		}

		public virtual bool ScriptDetailTabChangedExecute(ProcessExecutingContext context) {
			var detailsTabPanel = Page.PageContainer.FindPageControlByName("DetailsTabPanel") as Terrasoft.UI.WebControls.Controls.TabPanel;
			foreach (var tab in detailsTabPanel.Tabs) {
				if (tab.Items.Count > 0) {
					var pageContainer = tab.Items[0] as Terrasoft.UI.WebControls.Controls.PageContainer;
					var isTabActivated = Page.AspPage.Request.Form[tab.ClientID + "_TabActivated"] == "true";
					
					//if (!((Terrasoft.UI.WebControls.Controls.Button)pageContainer.FindPageControlByName("PrintButton")).Hidden){
						var activePage = pageContainer.PageInstance;
						activePage.Process.TrySetPropertyValue("IsModuleProcessesTuningMode", IsModuleProcessesTuningMode);
						activePage.ThrowEvent("SetDetailPrintButtonMenu");
					//}
					if (pageContainer == null || isTabActivated) {
						continue;
					}
					var sb = new System.Text.StringBuilder();
					var parent = (pageContainer.Parent as Terrasoft.UI.WebControls.WebControl);
					var ScriptManager = Page.AspPage.FindControl("ScriptManager") as Terrasoft.UI.WebControls.Controls.ScriptManager;
					parent.GenerateScript(sb, false, ScriptManager);
					if (parent is Terrasoft.UI.WebControls.Controls.Container) {
					    sb.AppendLine(string.Format("{0}.add({1});", parent.ClientID, pageContainer.ClientID));
					    sb.AppendLine(string.Format("{0}.doLayout();", parent.ClientID));
					}
					var script = sb.ToString();
					ScriptManager.RegisterBeforeClientInitByAjaxScript(script);
				}
			}
			return true;
		}

		public virtual bool ScriptBaseGridPageInitExecute(ProcessExecutingContext context) {
			if(!Ext.IsAjaxRequest) {
				SearchFilterEnabled = true;
				if (string.IsNullOrEmpty(FoldersMode)) {
					FoldersMode = "None";
				}
				SetDefaultModuleParameters();
				var gridInstance = Page.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
				if (gridInstance != null) {
					gridInstance.Process.SetPropertyValue("IsPrimaryGrid", true);
				}
				var dataSource = GetActiveDataSource();
				if (dataSource != null) {
					Page.FilterEdit.DataSourceId = dataSource.ClientID;
				}
				GetRequestStringParameters();
			}
			/*
			(Page.BaseFolder.FindPageControlByName("DataSource") as DataSource).SaveError +=
				delegate(object sender, DataSourceEventArgs e) {
					ShowErrorMessage(e.Exception.Message);
					e.IsHandled = true;
				};
			*/
			return true;
		}

		public virtual bool CreateAnalyticsTabExecute(ProcessExecutingContext context) {
			if (!_isHasAnalyticsInitialized) {
				var query = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModule");
				query.Cache = UserConnection.SessionCache.WithLocalCaching(string.Format(TSConfiguration.CacheUtilities.ModuleDataCacheGroup, SysModuleId));
				var hasAnalyticsColumnName = query.AddColumn("HasAnalytics").Name;
				query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", SysModuleId));
				query.CacheItemName = string.Format("SysModuleAnalytics_{0}", SysModuleId);
				var entities = query.GetEntityCollection(UserConnection);
				if (entities.Count > 0) {
					HasAnalytics = entities[0].GetTypedColumnValue<bool>(hasAnalyticsColumnName);
				} else {
					HasAnalytics = false;
				}
				_isHasAnalyticsInitialized = true;
			}
			CreateAnalytics(HasAnalytics);
			return true;
		}

		public virtual bool ScriptPrepareInitializeDetailsExecute(ProcessExecutingContext context) {
			NewInitializeDetails.SysModuleId = SysModuleId;
			NewInitializeDetails.DetailTabPanel = Page.DetailsTabPanel;
			NewInitializeDetails.InModuleEdit = false;
			NewInitializeDetails.ParentSysEntitySchemaId = SysEntitySchemaId;
			NewInitializeDetails.DefaultCollapsed = Page.DetailsTabPanel.Collapsed;
			return true;
		}

		public virtual bool ScriptPrepareInitializePrimaryGridsExecute(ProcessExecutingContext context) {
			ModuleInitializePrimaryGrids.SysModuleId = SysModuleId;
			ModuleInitializePrimaryGrids.PrimaryGridTabPanel = Page.GridTabPanel;
			var grid = Page.Grid;
			if (grid != null && grid.PageInstance != null && grid.PageInstance.Process != null) {
				grid.PageInstance.Process.SetPropertyValue("SysModuleId", SysModuleId);
			}
			return true;
		}

		public virtual bool CreateChartTabScriptTaskExecute(ProcessExecutingContext context) {
			if (GetActiveDataSource() == null || !Ext.IsAjaxRequest) {
				return true;
			}
			var isChartMenuItemClick = false;
			var formPostData = Page.AspPage.Request.Form;
			bool isUploadOrDownloadEvent = formPostData["__TerrasoftAjaxEventMarker"] == "delta=true";
			if(isUploadOrDownloadEvent || formPostData.AllKeys.Length <= 3) {
				return true;
			}
			string[] ajaxRequestParam = formPostData[3].ToString().Split('|');
			string senderName = ajaxRequestParam[0];
			string eventName = ajaxRequestParam[2];
			if (!string.IsNullOrEmpty(ChartTabItemClientID) && senderName.Contains(ChartTabItemClientID) && senderName.Contains("_ChartEdit")) {
				string chartSchemaId = formPostData[senderName + "_Value"];	
				if (!string.IsNullOrEmpty(chartSchemaId)) {
					var chartEditRequestParam = chartSchemaId.Split('|');
					CurrentChartPropertyId = new Guid(chartEditRequestParam[2]);
					UserConnection.RequestData["ChangeChart"] = true;
					CurrentChartCaption = formPostData[senderName];
					isChartMenuItemClick = true;
				}
			} else if (eventName == "ThrowEvent") {
				isChartMenuItemClick = senderName.Contains("ChartAnalyticsMenuItem");
				bool isReportMenuItemClick = senderName.Contains("ReportAnalyticsMenuItem");
				if (!isChartMenuItemClick && !isReportMenuItemClick) {
					return true;
				}
				var menuItemTag = JsonConvert.DeserializeXmlNode(ControlUtilities.HtmlDecode(formPostData[0])).
									SelectSingleNode("config/extraParams").
									SelectSingleNode("tag").InnerXml;
				var parameters = menuItemTag.Split('|');
				if (parameters.Length <= 2) {
					return true;
				}	
				if(isChartMenuItemClick) {
					CurrentChartPropertyId = new Guid(parameters[0]);
					CurrentChartCaption = parameters[3];
				} else if(isReportMenuItemClick) {
					CurrentReportSchemaUId = new Guid(parameters[0]);
				}
			}
			if (!string.IsNullOrEmpty(ChartTabItemClientID) || isChartMenuItemClick) {
				CreateOrRecreateChartTab(string.IsNullOrEmpty(ChartTabItemClientID));
			}
			return true;
		}

		public virtual bool ScriptApplySearchFilterExecute(ProcessExecutingContext context) {
			ApplyFilters();
			return true;
		}

		public virtual bool ScriptBasePrepareFiltersExecute(ProcessExecutingContext context) {
			bool currentStateSearchFilter = false;
			var enableSearchFilter = false;
			var dataSource = GetActiveDataSource();
			var structure = dataSource.CurrentStructure;
			Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filters = null;
			filters = dataSource.FindFiltersGroupByName("SearchFilter");
			if (filters != null) {
				currentStateSearchFilter = filters.IsEnabled;
				structure.Filters.Remove(filters);
			}
			if(!string.IsNullOrEmpty(SearchPrimaryDisplayColumnValue)) {
				enableSearchFilter = true;
				string activeDataSourceClientId = Page.FilterEdit.DataSourceId;
				Page.FilterEdit.SetDataSource(dataSource);
				filters = structure.CreateFiltersGroup("SearchFilter", LogicalOperationStrict.Or);
				var primaryDisplayColumnName = dataSource.Schema.PrimaryDisplayColumn.Name;
				FilterComparisonType comparisonTypeValue;
				string comparisonType = "StartWith";
					if (UserConnection != null) {
						object searchComparisonTypeValue;
						if (Terrasoft.Core.Configuration.SysSettings.TryGetValue(UserConnection,
								"StringColumnSearchComparisonType", out searchComparisonTypeValue) &&  searchComparisonTypeValue != null) {
							comparisonType = Enum.GetName(typeof(StringValueComparisonType), (int)searchComparisonTypeValue);
						}
					}
				comparisonTypeValue = (FilterComparisonType)Enum.Parse(typeof(FilterComparisonType), comparisonType);
				filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, 
					comparisonTypeValue, primaryDisplayColumnName, 
					SearchPrimaryDisplayColumnValue));
				structure.Filters.Add(filters);
			}
			bool currentState = false;
			var filterEditGroup = dataSource.FindFiltersGroupByName("FilterEdit");
			if (!currentStateSearchFilter && filterEditGroup != null) {
					currentState = filterEditGroup.IsEnabled;
			}
			bool stateChanged = !currentStateSearchFilter && (currentState != SearchFilterEnabled);
			if (stateChanged) {
				SearchFilterEnabled = currentState;
			}
			foreach (var filter in structure.Filters) {
				if((filter.Name != null) && filter.Name.Equals("SearchFilter")) {	
					filter.IsEnabled = enableSearchFilter;
				} else {
					filter.IsEnabled = !enableSearchFilter;
					if (filter.Name == "FilterEdit") {
						filter.IsEnabled = filter.IsEnabled && SearchFilterEnabled;
					}
				}
			}
			BasePrepeareFilters();
			return true;
		}

		public virtual bool ScriptTaskPrepeareAnalyticsChartFiltersParamExecute(ProcessExecutingContext context) {
			ApplyFiltersForAnalitics();
			if (!string.IsNullOrEmpty(AnalyticsChartPageContainerID)) {	
				var chartPageContainer = ControlUtilities.FindControl(Page.PageContainer, AnalyticsChartPageContainerID, true) as 
								PageContainer;
				if (chartPageContainer != null) {
					string serializedFilters = GetActiveDataSourceSerializedFilters();
					var chartContainerProcess = chartPageContainer.PageInstance.Process;
					chartContainerProcess.SetPropertyValue("SerializedModuleFilters", serializedFilters);
					if (CheckChartTabActive()) {
						chartContainerProcess.ThrowEvent(chartContainerProcess.InternalContext, "DrawChart");
					}
				}
			}
			return true;
		}

		public virtual bool ScriptChartMenuItemClickExecute(ProcessExecutingContext context) {
			bool isNewTab = UserConnection.RequestData["ChartTabCreated"] != null;
			if (!string.IsNullOrEmpty(ChartTabItemClientID) && (isNewTab || UserConnection.RequestData["ChangeChart"] != null)) {
				string tabCaption = GetTabCaption(CurrentChartCaption);
				var tabPanel = Page.GridTabPanel;
				var tab = tabPanel.Tabs[tabPanel.Tabs.Count-1];
				tab.Caption = tabCaption;
				var sb = new StringBuilder();
				var parent = tab;
				var ScriptManager = Page.AspPage.FindControl("ScriptManager") as Terrasoft.UI.WebControls.Controls.ScriptManager;
				if (isNewTab) {
					parent.GenerateScript(sb, false, ScriptManager);
				}
				if (parent is Terrasoft.UI.WebControls.Controls.Container) {		
					OldTabPanelClientId = tabPanel.ClientID;
					if(isNewTab) {
						var tabScript = tab.GetClientConstructor(false,true).Replace("_ClientInit", string.Empty).Replace("this.", "window.");	
						var activateTab = "true";
						sb.AppendLine(string.Format("{2}{0}.insert({3},{1},{4});", tabPanel.ClientID, parent.ClientID, tabScript, 
											tabPanel.ClientID + ".items.length", activateTab));
					}
					sb.AppendLine(string.Format("{0}.setCaption('{1}');", tab.ClientID, tabCaption));
					sb.AppendLine(string.Format("{0}.setActiveTab({1});",tabPanel.ClientID, tabPanel.Tabs.Count-1));
					sb.AppendLine(string.Format("{0}.doLayout();", parent.ClientID));
				}	
				string script = sb.ToString();
				ScriptManager.RegisterBeforeClientInitByAjaxScript(script.Replace("this.", "window."));
			}
			if (!string.IsNullOrEmpty(AnalyticsChartPageContainerID)) {
				string filters = GetActiveDataSourceSerializedFilters();
				var analyticsChartPageContainer = ControlUtilities.FindControl(Page.PageContainer, AnalyticsChartPageContainerID, true) as PageContainer;
				var analyticsChartProcess = analyticsChartPageContainer.PageInstance.Process;
				analyticsChartProcess.SetPropertyValue("SerializedModuleFilters", filters);
				analyticsChartProcess.SetPropertyValue("ModuleEntitySchemaId", SysEntitySchemaId);
				analyticsChartProcess.ThrowEvent(analyticsChartProcess.InternalContext, "DrawChart");
			}
			return true;
		}

		public virtual bool ScriptTaskBaseModulePageLoadExecute(ProcessExecutingContext context) {
			var dataSource = GetActiveDataSource();
			if (!Page.CustomSearchContainer.Hidden && Page.CustomSearchContainer.PageInstance != null) {
				Page.CustomSearchContainer.PageInstance.Process.SetPropertyValue("TargetDataSource", dataSource);
			}
			var treeGrid = Page.Grid.FindPageControlByName("TreeGrid") as TreeGrid;
			if (treeGrid == null) {
				return true;
			}
			if (dataSource != null && dataSource == treeGrid.DataSource) {
				treeGrid.GetRowConfigHandler = GetModuleRowConfig;
				dataSource.Loaded += treeGrid.DataLoaded;
			}
			var folderDataSource = Page.BaseFolder.FindPageControlByName("DataSource") as EntityDataSource;
			if (folderDataSource != null) {
				var folderSchema = folderDataSource.Schema;
				if (folderSchema == null) {
					SetDefaultModuleParameters();
					var process = Page.BaseFolder.PageInstance.Process;
					process.SetPropertyValue("EntitySchemaUId", FolderEntitySchemaUId);
					process.SetPropertyValue("CacheItemName", GetCacheItemName(SysModuleId));
				}
			}
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			if (CurrentReportSchemaUId == Guid.Empty) {
				return true;
			}
			var gridSelectedActiveRows = GetSelectedActiveRows() as List<Guid>;
			var selectedRows = new Dictionary<string, object> ();
			var dataSource = GetActiveDataSource();
			selectedRows.Add("Item1", dataSource.Schema.Name);
			selectedRows.Add("Item2", dataSource.Schema.GetPrimaryColumnName());
			selectedRows.Add("Item3", gridSelectedActiveRows);
			UserConnection.SessionData[CurrentReportSchemaUId.ToString() + "_SerializedFilters"] = GetSerializedFilters();
			UserConnection.SessionData[CurrentReportSchemaUId.ToString() + "_SelectedActiveRows"] = selectedRows;
			return true;
		}

		public virtual Terrasoft.UI.WebControls.Controls.Tab CreateAnalytiscGridPageTabItem() {
			var analyticsGridPageTabItem = new Terrasoft.UI.WebControls.Controls.Tab();
				analyticsGridPageTabItem.UId = Guid.NewGuid();
				analyticsGridPageTabItem.Name = AnalyticsTabName;
				analyticsGridPageTabItem.Edges = "";
				analyticsGridPageTabItem.Image = new ControlImage {};
				analyticsGridPageTabItem.Caption = AnalyticsTabCaption;
				return analyticsGridPageTabItem;
		}

		public virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateAnalyticsGridPageContainer() {
			var analyticsGridPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
				analyticsGridPageContainer.UId = Guid.NewGuid();
				analyticsGridPageContainer.Name = "analyticsGridPageContainer";
				analyticsGridPageContainer.Cls = "";
				analyticsGridPageContainer.PageSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
				analyticsGridPageContainer.Height = Unit.Percentage(100);
				analyticsGridPageContainer.Width = Unit.Percentage(100);
				analyticsGridPageContainer.Image = new ControlImage {};
				return analyticsGridPageContainer;
		}

		public virtual List<Guid> GetSelectedActiveRows() {
			var selectedActiveRows = new List<Guid>();
			DataSource dataSource = GetActiveDataSource();
			if (dataSource != null && dataSource.SelectedItemPrimaryColumnValues != null) {
				foreach (var itemPrimaryColumnValue in dataSource.SelectedItemPrimaryColumnValues) {
					selectedActiveRows.Add(itemPrimaryColumnValue);
				}
			}
			return selectedActiveRows;
		}

		public virtual DataSource GetActiveDataSource() {
			var page = Page.AspPage as Terrasoft.UI.WebControls.Page;
			int detailsTabPanelActiveTabIndex = Page.GridTabPanel.ActiveTabIndex;
			if (page.UseProfile && !Terrasoft.UI.WebControls.Ext.IsAjaxRequest) {
				var profileData = page.ProfileData;
				var profileItem = profileData[Page.GridTabPanel.ClientID];
				if (profileItem != null) {
					if (profileItem.Values.ContainsKey("activetabindex")) {
						detailsTabPanelActiveTabIndex = int.Parse(profileItem.Values["activetabindex"].ToString());
					}
				}
			}
			PageControl control = null;
			if (detailsTabPanelActiveTabIndex > -1 && detailsTabPanelActiveTabIndex < Page.GridTabPanel.Tabs.Count) {
				control = Page.GridTabPanel.Tabs[detailsTabPanelActiveTabIndex].FindPageControlByName("DataSource");
			} 
			if (control == null) {
				foreach (var tab in Page.GridTabPanel.Tabs) {
					control = tab.FindPageControlByName("DataSource");
					if (control != null) {
						break;
					}
				}
			}
			return control as DataSource;
		}

		public virtual object[] GetFolderInfo() {
			var folderSchema = (Page.BaseFolder.FindPageControlByName("DataSource") as DataSource).Schema;
			var manager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(manager, folderSchema.Name);
			var primaryColumn = entitySchemaQuery.AddColumn("Id");
			var folderTypeColumn = entitySchemaQuery.AddColumn("FolderType.Id");
			var searchDataColumn = entitySchemaQuery.AddColumn("SearchData");
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Equal, folderSchema.GetPrimaryColumnName(), FolderId));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return new object[] { entities[0].GetTypedColumnValue<Guid>(folderTypeColumn.Name), 
					entities[0].GetColumnValue(searchDataColumn.Name)};
			}
			return null;
		}

		public virtual void SelectFolder() {
			
			return;
		}

		public virtual void SaveFolderFilters() {
		}

		public virtual void LoadFolderFilters() {
		}

		public virtual void ApplyFilters() {
			var dataSource = GetActiveDataSource();
			if (dataSource == null) {
				return;
			}
			var pageContainer = dataSource.NamingContainer as PageContainer;
			if (pageContainer != null && pageContainer.PageInstance != null) {
				pageContainer.PageInstance.ThrowEvent("ClearData");
			}
			dataSource.LoadRows();
		}

		public virtual void BaseApplyModuleFilters() {
			switch (FoldersMode) {
				case "MultiFolderEntry" :
					ApplyMultiFolderEntryFilter();
					break;
				case "SingleFolderEntry" :
					ApplySingleFolderEntryFilter();
					break;
			}
		}

		public virtual void BaseApplyGlobalSearchFilter() {
			var dataSource = GetActiveDataSource();
			var primaryDisplayColumnName = dataSource.Schema.PrimaryDisplayColumn.Name;
			var structure = dataSource.CurrentStructure;
			Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filters = null;
			if(string.IsNullOrEmpty(SearchPrimaryDisplayColumnValue)) {
				filters = null;
			} else {
				var oldFilters = structure.Filters.FindByName("SearchFilter");
				if (oldFilters != null) {
					structure.Filters.Remove(oldFilters);
				}
				filters = structure.CreateFiltersGroup("SearchFilter", LogicalOperationStrict.Or);
				filters.Add(structure.CreateFilterWithParameters(dataSource.Schema, Terrasoft.Core.Entities.FilterComparisonType.Contain,
				 primaryDisplayColumnName, SearchPrimaryDisplayColumnValue));
			}
		}

		public virtual DataSourceRowConfig GetModuleRowConfig(Entity module) {
			string primaryColumnName = module.Schema.PrimaryColumn.Name;
			string primaryColumnValue = module.GetColumnValue(primaryColumnName).ToString();
			var config = new DataSourceRowConfig(primaryColumnValue);
			var dataSource = Page.Grid.FindPageControlByName("DataSource") as DataSource;
			var schemaName = dataSource.Schema.Name;
			string[] dragTags = new string[] {schemaName}; 
			config.AddConfig(new DataSourceRowDragTagsConfigValue(dragTags));
			return config;
		}

		public virtual void ApplyFiltersForAnalitics() {
			if (!HasAnalytics) {
				return;
			}
			var dataSource = GetActiveDataSource();
			var analyticsPageContainer = (Page as PageSchemaUserControl).PageContainer.FindPageControlByName("analyticsGridPageContainer") 
					as PageContainer;
			if (analyticsPageContainer != null) {
				analyticsPageContainer.PageInstance.Process.SetPropertyValue("SerializedFilters", GetSerialzedFilters());
				analyticsPageContainer.PageInstance.Process.SetPropertyValue("EntitySchemaUId", dataSource.Schema.UId);
			}
		}

		public virtual bool SetMoveToFilters() {
			if(PCV.Equals(Guid.Empty) || string.IsNullOrEmpty(PDV)) {
				return false;
			}
			PDV = web.HttpUtility.UrlDecode(PDV);
			var activeDataSource = GetActiveDataSource();
			var currentStructure = activeDataSource.CurrentStructure;
			var newFilter = currentStructure.CreateFilterWithParameters(activeDataSource.Schema, FilterComparisonType.Equal, activeDataSource.Schema.PrimaryColumn.Name, PCV); 
			var quickFilter = currentStructure.Filters.FindByName("QuickFilter");
			if(quickFilter == null) {
				DataSourceFilterCollection filters = null;
				filters = currentStructure.CreateFiltersGroup("QuickFilter", LogicalOperationStrict.And);	
				filters.Add(newFilter);
				currentStructure.Filters.Add((IDataSourceFilterItem) filters);
			}  else {
				(quickFilter as DataSourceFilterCollection).Clear();
				(quickFilter as DataSourceFilterCollection).Add(newFilter);
			}
			
			foreach (var filter in currentStructure.Filters) {
				if(string.IsNullOrEmpty(filter.Name) || !filter.Name.Equals("QuickFilter")) {	
					filter.IsEnabled = false;
				}
			}
			PCV = Guid.Empty;
			PDV = string.Empty;
			return true;
		}

		public virtual void GetRequestStringParameters() {
			if(PCV.Equals(Guid.Empty) &&  string.IsNullOrEmpty(PDV)) {
				PCV = Page.GetParameterValue("pcv") != null ? new Guid(Page.GetParameterValue("pcv").ToString()) : Guid.Empty;
				PDV = Page.GetParameterValue("pdv") != null ? Page.GetParameterValue("pdv").ToString() : String.Empty;
			}
		}

		public virtual void SetDefaultModuleParameters() {
			if (SysModuleId == Guid.Empty) {
				var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
				var	primaryColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName()).Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
						"SysPageSchemaUId", Page.Schema.UId));	
				var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entities.Count > 0) {
					SysModuleId = entities[0].GetTypedColumnValue<Guid>(primaryColumnName);
				}
			}
			if (Page.LeftControlLayout.Hidden) {
				return;
			}
			if (SysModuleId != Guid.Empty && (FolderEntryEntitySchemaUId == Guid.Empty || FolderEntitySchemaUId == Guid.Empty || SysEntitySchemaId == Guid.Empty)) {
				var folderCodeColumnName = "FolderMode.Code";
				var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
				entitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(string.Format(TSConfiguration.CacheUtilities.ModuleDataCacheGroup, SysModuleId));
				var entitySchemaIdColumn = entitySchemaQuery.AddColumn("SysModuleEntity.SysEntitySchemaUId");
				var folderCodeModeColumn = entitySchemaQuery.AddColumn(folderCodeColumnName);
				var hasActionsColumnName = entitySchemaQuery.AddColumn("HasActions").Name;
				EntitySchemaQueryFilterCollection filters = entitySchemaQuery.Filters;
				filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
													"Id", SysModuleId));
				entitySchemaQuery.CacheItemName = string.Format("SysModuleFolderInfo_{0}", SysModuleId);
				var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				string folderCode = "None";
				var entityName = String.Empty;
				if (entities.Count > 0) {
					SysEntitySchemaId = entities[0].GetTypedColumnValue<Guid>(entitySchemaIdColumn.Name);
					var entitySchemaItem = entitySchemaManager.GetItemByUId(
										entities[0].GetTypedColumnValue<Guid>(entitySchemaIdColumn.Name));
					entityName = entitySchemaItem.Name;
					folderCode = entities[0].GetTypedColumnValue<string>(folderCodeModeColumn.Name);
					HasActions = !entities[0].GetTypedColumnValue<bool>(hasActionsColumnName);
				}
				FoldersMode = folderCode;
				if (string.IsNullOrEmpty(entityName)) {
					return;
				}
				var folderSuffix = "Folder";
				var folderEntrySuffix = "InFolder";
				switch (folderCode) {
					case "SingleFolderEntry":
						if (FolderEntitySchemaUId == Guid.Empty) {
							FolderEntitySchemaUId = GetSchemaUIdByName(entityName + folderSuffix);
						}
						break;
					case "MultiFolderEntry":
						if (FolderEntitySchemaUId == Guid.Empty) {
							FolderEntitySchemaUId = GetSchemaUIdByName(entityName + folderSuffix);
						}
						if (FolderEntryEntitySchemaUId == Guid.Empty) {
							FolderEntryEntitySchemaUId = GetSchemaUIdByName(entityName + folderEntrySuffix);
						}	
						break;
					case "None":
						Page.LeftControlLayout.Hidden = true;
						break;
				}
			}
		}

		public virtual Guid GetSchemaUIdByName(string schemaName) {
			if (schemaName == String.Empty) {
				return Guid.Empty;
			}
			var schemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var schema = schemaManager.FindInstanceByName(schemaName);
			if (schema != null) {
				return schema.UId;
			}
			return Guid.Empty;
		}

		public virtual void BasePrepeareFilters() {
			if (SetMoveToFilters()) {
				return;
			}
			SearchFolder = false;
			IsRecentFolder = false;
			IsDuplicatesFolder = false;
			DataSource dataSource = GetActiveDataSource();
			var currentStructure = dataSource.CurrentStructure;
			bool isGlobalSearch = false;
			foreach(var filter in currentStructure.Filters) {
				if((filter.Name != null) && filter.Name.Equals("SearchFilter") && (filter.IsEnabled == true)) {
					isGlobalSearch = true;
				}
			}
			if(!isGlobalSearch) {
				BaseApplyModuleFilters();
				if (FolderId != Guid.Empty) {
					var folderInfo = GetFolderInfo();
					Guid dynamicFolderTypeId = new Guid("65CA0946-0084-4874-B117-C13199AF3B95");
					Guid recentFolderTypeId = new Guid("C01FFB44-7407-E011-A646-16D83CAB0980");
					Guid rootEmailFolderTypeUId = new Guid("6e23fa26-5bee-e011-a86b-00155d04c01d");
					Guid duplicatesFolderTypeId = new Guid("10794494-D2DD-E011-92C3-00155D04C01D");
					if (folderInfo != null && !DBNull.Value.Equals(folderInfo[0]) && folderInfo.Length.Equals(2)) {
						var folderTypeUId = new Guid(folderInfo[0].ToString());
						if ((folderTypeUId == dynamicFolderTypeId) || (folderTypeUId == rootEmailFolderTypeUId)) {			
							var folderSchema = (Page.BaseFolder.FindPageControlByName("DataSource") as DataSource).Schema;
							var columnUId = folderSchema.Columns.GetByName("SearchData").UId;
							LoadDynamicFolderFilterUserTask.DataSource = GetActiveDataSource();
							LoadDynamicFolderFilterUserTask.StoringEntitySchemaId = folderSchema.UId;
							LoadDynamicFolderFilterUserTask.StoringColumnUId = columnUId;
							LoadDynamicFolderFilterUserTask.StoringPrimaryColumnValue = FolderId;
							SearchFolder = true;
						} else if(folderTypeUId == recentFolderTypeId) {
							LoadRecentFolderFilterUserTask.DataSource = GetActiveDataSource();
							IsRecentFolder = true;
						} else if (folderTypeUId.Equals(duplicatesFolderTypeId)) {
							LoadDuplicatesFolderFilterUserTask.DataSource = GetActiveDataSource();
							LoadDuplicatesFolderFilterUserTask.DuplicatesTableName = GetDuplicatesSchemaName();
							IsDuplicatesFolder = true;
						}
					}
					else {
						LoadDynamicFolderFilterUserTask.StoringPrimaryColumnValue = Guid.Empty;
					}
				} else {
					LoadDynamicFolderFilterUserTask.StoringPrimaryColumnValue = Guid.Empty;
				}
			}
			if ((!SearchFolder && !StaticFolder) || (ClearFilterEditFilters && StaticFolder)) {
				var filterEditCollection = currentStructure.Filters.FindByName("FilterEdit") 
						as Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection;
				if (filterEditCollection != null) {
					filterEditCollection.LogicalOperation = LogicalOperationStrict.And;
					filterEditCollection.IsEnabled = true;
					filterEditCollection.IsNot = false;
					filterEditCollection.Clear();
				}
				StaticFolder = true;
			}
			if (!IsRecentFolder)
			{
				var recentFilterCollection = currentStructure.Filters.FindByName("FilterRecent") 
												as Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection;
				if(recentFilterCollection != null)
				{
					recentFilterCollection.Clear();
				}
			}
			if (!IsDuplicatesFolder) {
				var duplicatesCollection = currentStructure.Filters.FindByName("FilterDuplicates")
												as Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection;
				if(duplicatesCollection != null)
				{
					duplicatesCollection.Clear();
				}
			}
			if (SearchFolder) {
				StaticFolder = false;
				var filterFolderCollection = currentStructure.Filters.FindByName("FolderFilter") 
												as Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection;
				if (filterFolderCollection != null) {
					filterFolderCollection.Clear();
				}
			}
			var currentSchema = (Page.BaseFolder.FindPageControlByName("DataSource") as DataSource).Schema;
			bool canEditOrChangeEdit = false;
			if (currentSchema != null) {
				var rightLevel = UserConnection.DBSecurityEngine.GetEntitySchemaRecordRightLevel(UserConnection.CurrentUser.Id, currentSchema, FolderId);
				var changeEditRight = SchemaRecordRightLevels.CanEdit;
				bool canChangeEdit = rightLevel == changeEditRight;
				bool canEdit = (rightLevel & changeEditRight) == changeEditRight;
				canEditOrChangeEdit = (canEdit || canChangeEdit);
			}
			Page.SaveToolButton.Enabled = (canEditOrChangeEdit && !StaticFolder);
			ClearFilterEditFilters = false;
			
			
			
			
		}

		public virtual string GetTabCaption(string caption) {
			var tabCaption = caption;
			if (tabCaption.Length > 30) {
				var words = tabCaption.Substring(0, 27).Split(' ');
				tabCaption = String.Empty;
				for (int i=0; i<(words.Length-1); i++) {
					tabCaption += " " + words[i];
				}
				if (tabCaption == String.Empty) {
					tabCaption = words[0].Substring(0, 27);
				} 
				tabCaption += "...";
			}
			return ChartStartTabCaption + " " + tabCaption;
		}

		public virtual bool CheckChartTabActive() {
			var activeTabClientID = Page.GridTabPanel.Tabs[Page.GridTabPanel.ActiveTabIndex].ClientID;
			if (string.IsNullOrEmpty(activeTabClientID) || string.IsNullOrEmpty(ChartTabItemClientID)) {
				return false;
			} else {
			 	return activeTabClientID.Contains(ChartTabItemClientID);
			}
		}

		public virtual Guid GetGridSelectedValue() {
			var selectedValue = Page.Grid.PageInstance.Process.GetPropertyValue("SelectedNodePrimaryColumnValue") == null ? Guid.Empty : 
				(Guid)Page.Grid.PageInstance.Process.GetPropertyValue("SelectedNodePrimaryColumnValue");
			return selectedValue;
		}

		public virtual void DisplayDetailsTabPanel(bool show) {
			var detailsTabPanel = Page.DetailsTabPanel;
			if (detailsTabPanel.Tabs.Count > 0) {
				// detailsTabPanel.Hidden = !show;
			}
		}

		public virtual void OnTabPanelChanged(object sender, AjaxEventArgs e) {
			TabPanel tabPanel;
			if (!(sender is TabPanel)) {
				return;
			}
			tabPanel = sender as TabPanel;
			var tabName = tabPanel.Tabs[tabPanel.ActiveTabIndex].Name;
			DisplayDetailsTabPanel(!(tabName == AnalyticsTabName || CheckChartTabActive()));
		}

		public virtual string GetSerialzedFilters() {
			var dataSource = GetActiveDataSource();
			var filter = dataSource.CurrentStructure.Filters;
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, dataSource);
			return Json.Serialize(filter, jsonConverter);
		}

		public virtual void ApplyMultiFolderEntryFilter() {
			var dataSource = GetActiveDataSource();
			if (dataSource == null) {
				return;
			}
			var pageInstance = (dataSource.NamingContainer as PageContainer).PageInstance;
			if (!IsRootFolder && FolderId != Guid.Empty && FolderEntryEntitySchemaUId != Guid.Empty) {
				var folderInfo = GetFolderInfo();
				Guid dynamicFolderTypeId = new Guid("65CA0946-0084-4874-B117-C13199AF3B95");
				if (folderInfo == null || DBNull.Value.Equals(folderInfo[0]) || !folderInfo.Length.Equals(2) ||
					!(new Guid(folderInfo[0].ToString())).Equals(dynamicFolderTypeId)) {
					ISchemaManagerItem folderEntryEntitySchema =  Page.UserConnection.GetSchemaManager("EntitySchemaManager").
						GetItemByUId(FolderEntryEntitySchemaUId) as ISchemaManagerItem;
					var folderEntitySchema = dataSource.Schema;
					SetDetailFilter.FilterName = "FolderFilter";
					SetDetailFilter.FilterLeftExpressions = new  string[] 
						{string.Concat(new string[] { "[", folderEntryEntitySchema.Name, ":",  dataSource.Schema.Name, "].Folder.",
						folderEntitySchema.PrimaryColumn.Name})};
					SetDetailFilter.FilterRightValue = FolderId;
					var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
					if (oldDataSourceFolderFilter != null) {
						dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
					}	
					var filter = SetDetailFilter.CreateFilter(dataSource, Page.UserConnection.Workspace.Id, Page.UserConnection);
					dataSource.CurrentStructure.Filters.Add(filter);
					pageInstance.Process.SetPropertyValue("SelectedFolderId", FolderId);
				}
			}
			if (IsRootFolder) {
				pageInstance.Process.SetPropertyValue("SelectedFolderId", Guid.Empty);
				var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
				if (oldDataSourceFolderFilter != null) {
					dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
				}
			}
		}

		public virtual void ApplySingleFolderEntryFilter() {
			var dataSource = GetActiveDataSource();
			if (dataSource == null) {
				return;
			}
			var pageInstance = (dataSource.NamingContainer as PageContainer).PageInstance;
			if (!IsRootFolder && FolderId != Guid.Empty) {
				var folderInfo = GetFolderInfo();
				Guid dynamicFolderTypeId = new Guid("65CA0946-0084-4874-B117-C13199AF3B95");
				if (folderInfo == null || DBNull.Value.Equals(folderInfo[0]) || !folderInfo.Length.Equals(2) || !(new Guid(folderInfo[0].ToString())).Equals(dynamicFolderTypeId)) {
					string folderColumnName = string.Empty;
					foreach (var column in dataSource.Schema.Columns) {
						if (column.ReferenceSchemaUId == FolderEntitySchemaUId) {
							folderColumnName = column.Name;
						}
					}
					SetDetailFilter.FilterName = "FolderFilter";
					SetDetailFilter.FilterLeftExpressions = new  string[] {folderColumnName};
					SetDetailFilter.FilterRightValue = FolderId;
					var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
					if (oldDataSourceFolderFilter != null) {
						dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
					}
					var filter = SetDetailFilter.CreateFilter(dataSource, Page.UserConnection.Workspace.Id, Page.UserConnection);
					dataSource.CurrentStructure.Filters.Add(filter);
					pageInstance.Process.SetPropertyValue("SelectedFolderId", FolderId);
				}
			}
			if (IsRootFolder) {
				var oldDataSourceFolderFilter = dataSource.CurrentStructure.Filters.FindByName("FolderFilter");
				if (oldDataSourceFolderFilter != null) {
					dataSource.CurrentStructure.Filters.Remove(oldDataSourceFolderFilter);
				}
			}
		}

		public virtual string GetSerializedFilters() {
			var dataSource = GetActiveDataSource();
			var filter = dataSource.CurrentStructure.Filters;
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, dataSource);
			return Json.Serialize(filter, jsonConverter);
		}

		public virtual void SetProcessExtraParameters(Process moduleProcess, ProcessSchema processSchema) {
		}

		public virtual string GetDuplicatesSchemaName() {
			return string.Empty;
		}

		public virtual void SetPageKeyShortcuts(Terrasoft.WebApp.BaseGridPageSchemaUserControl gridInstance) {
			string addButtonClientID = gridInstance.AddButton.ClientID;
			string editButtonClientID = gridInstance.EditButton.ClientID;
			string deleteButtonClientID = gridInstance.DeleteButton.ClientID;
			StringBuilder sb = new StringBuilder();
				sb.AppendFormat(@"Ext.getDoc().on(Ext.isIE || Ext.isSafari3 ? 'keydown' : 'keypress', function(e) {{
						var addButton = {0};
						var editButton = {1};
						var deleteButton = {2};
						var key = e.getKey(); 
						if (e.altKey === true) {{
							switch (key) {{
								case e.INSERT:
									if(addButton.enabled && !addButton.hidden)  {{ addButton.fireEvent('click', addButton, e); }}
									break;
								case e.F2:
									if(editButton.enabled && !editButton.hidden)  {{ editButton.fireEvent('click', editButton, e); }}
									break;
								case e.DELETE:
									if(deleteButton.enabled && !deleteButton.hidden)  {{ deleteButton.fireEvent('click', deleteButton, e); }}
									break;
							}}
						}} 
					}});", addButtonClientID, editButtonClientID, deleteButtonClientID);
			Page.AddScript(sb.ToString());
		}

		public virtual string GetCacheItemName(Guid sysModuleId) {
			return string.Format("SysModuleFolderInfo_{0}", sysModuleId);
		}

		public virtual void SetCustomFilterDetails() {
			Page.CustomSearchContainer.PageInstance.Process.SetPropertyValue("ListenerPageUId", Page.Process.InstanceUId);
		}

		public virtual void CreateAnalyticsChartPageContainerInTab(Tab chartTab, bool createdByAjax) {
			var analyticsChartPageSchemaId = new Guid("48F94C50-8579-410F-AB76-3DC01820E2D3");
			var dataSource = GetActiveDataSource();
			var gridPageEntitySchemaQuery = new EntitySchemaQuery(dataSource.Schema);
			var gridPageEntitySchemaQueryFiltersCollection = dataSource.CurrentStructure.Filters.ToEntitySchemaQueryFilterCollection(gridPageEntitySchemaQuery);
			gridPageEntitySchemaQuery.Filters.Add(gridPageEntitySchemaQueryFiltersCollection);
			var newContainer = new PageContainer();
			newContainer.UId = Guid.NewGuid();
			newContainer.CreatedByAjax = createdByAjax;
			newContainer.PageSchemaUId = analyticsChartPageSchemaId;
			newContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			newContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			newContainer.Name = chartTab.ClientID + analyticsChartPageSchemaId.ToString().Replace("-", "").ToLower();
			AnalyticsChartPageContainerID = newContainer.Name;
			foreach(var control in newContainer.Controls) {
				if (control is Terrasoft.UI.WebControls.WebControl) {
					((Terrasoft.UI.WebControls.WebControl)control).CreatedByAjax = createdByAjax;
				}
			}
			chartTab.InsertItem(0, newContainer);
			var bottomLayout = newContainer.FindPageControlByName("BottomLayout") as ControlLayout;
			var process = newContainer.PageInstance.Process;
			process.SetPropertyValue("ChartPropertyId", CurrentChartPropertyId);
			process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			process.SetPropertyValue("SysModuleId", SysModuleId);
			newContainer.PageInstance.Process.SetPropertyValue("IsContextHelpButtonInitialized", false);
		}

		public virtual string GetActiveDataSourceSerializedFilters() {
			var dataSource = GetActiveDataSource();
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, dataSource);
			return Json.Serialize(dataSource.CurrentStructure.Filters, jsonConverter);
		}

		public virtual void CreateOrRecreateChartTab(bool createNew) {
			var tabPanel = Page.GridTabPanel;
			if (createNew) {
				ChartTabItemClientID = "t_" + tabPanel.ID + "_" + Guid.NewGuid().ToString("N");
				var chartTab = new Terrasoft.UI.WebControls.Controls.Tab(){	
					ID = ChartTabItemClientID,
					Caption = GetTabCaption(CurrentChartCaption)
				};
				tabPanel.Tabs.Add(chartTab);
				CreateAnalyticsChartPageContainerInTab(chartTab, true);
				if (UserConnection.RequestData["ChartTabCreated"] == null) {
					UserConnection.RequestData["ChartTabCreated"] = true;		
				}
			} else {
				var oldTab = new Terrasoft.UI.WebControls.Controls.Tab() {
					ID = ChartTabItemClientID,
					Caption = GetTabCaption(CurrentChartCaption)
				};
				tabPanel.Tabs.Add(oldTab);
				CreateAnalyticsChartPageContainerInTab(oldTab, false);
				UserConnection.RequestData["ChangeChart"] = true;
			}
		}

		public virtual void ShowErrorMessage(string errorMessage) {
			MessagePanel messagePanel = ControlUtilities.FindControl(
				Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.AddMessage(Warning, errorMessage, MessageType.Warning);
			}
		}

		public virtual bool OnPageLoadComlete() {
			if (!Page.CustomSearchContainer.Hidden) {
				SetCustomFilterDetails();
				Page.CustomSearchContainer.PageInstance.ThrowEvent("Initialize");
			}
			if (Ext.IsAjaxRequest) {
				return true;
			}
			if (Page.Grid.PageInstance == null) {
				Page.GridTab.Hidden = true;
			}
			var gridInstance = Page.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			var dataSource = GetActiveDataSource();
			if (gridInstance != null) {
				gridInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);	
				SetPageKeyShortcuts(gridInstance);
			}
			if (FoldersMode != "None") {
				var process = Page.BaseFolder.PageInstance.Process;
				process.SetPropertyValue("EntitySchemaUId", FolderEntitySchemaUId);
				process.SetPropertyValue("ListenerPage", Page);
				process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
				process.SetPropertyValue("IsMultiFolder", FoldersMode == "MultiFolderEntry");
				Page.BaseFolder.PageInstance.ThrowEvent("Initialize");
			} else if (dataSource != null) {
				dataSource.LoadRows();
			}
			var detailsTabPanel = Page.DetailsTabPanel;
			if(detailsTabPanel.Tabs.Count == 0) {
				detailsTabPanel.ActiveTabIndex = -1;
				if (Page.DetailsTabPanel.Hidden == false) {
					Page.DetailsTabPanel.Hidden = true;
				}		
			} else {
				if (Page.DetailsTabPanel.Hidden == true) {
					Page.DetailsTabPanel.Hidden = false;
				}
			}
			var activeTabIndex = Page.GridTab.Hidden ? 1 : 0;
			var profileData = ((Terrasoft.UI.WebControls.Page)Page.AspPage).ProfileData;
			if (profileData != null) {
				var profileTabPanelItem = profileData[Page.GridTabPanel.ClientID];	
				if (profileTabPanelItem != null) {
					if (profileTabPanelItem.Values.ContainsKey("activetabindex")) {
						activeTabIndex = (int)(long)(profileTabPanelItem.Values["activetabindex"]);
					}	
				}
			}
			var tabs = Page.GridTabPanel.Tabs;
			bool showDetails = true;
			if (activeTabIndex < tabs.Count) {
				showDetails = !(tabs[activeTabIndex].Name == AnalyticsTabName);
			}
			DisplayDetailsTabPanel(showDetails);
			return true;
		}

		public virtual void CreateAnalytics(bool hasAnalytics) {
			if (hasAnalytics) {
				var gridTabPanel = Page.GridTabPanel;
				var tab = CreateAnalytiscGridPageTabItem();
				var container = CreateAnalyticsGridPageContainer();
				tab.InsertItem(0,container);
				gridTabPanel.AjaxEvents.TabChange.Event += new AjaxEventHandler(OnTabPanelChanged);
				gridTabPanel.Tabs.Add(tab);
				container.PageInstance.Process.SetPropertyValue("SysModuleId", SysModuleId);
				container.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ApplyToolButtonClick":
							if (ActivatedEventElements.Contains("ApplyToolButtonClick")) {
							context.QueueTasks.Enqueue("ApplyToolButtonClick");
						}
						break;
					case "SaveToolButtonClick":
							if (ActivatedEventElements.Contains("SaveToolButtonClick")) {
							context.QueueTasks.Enqueue("SaveToolButtonClick");
						}
						break;
					case "ClearToolButtonClick":
							if (ActivatedEventElements.Contains("ClearToolButtonClick")) {
							context.QueueTasks.Enqueue("ClearToolButtonClick");
						}
						break;
					case "SelectFolder":
							if (ActivatedEventElements.Contains("SelectFolderMessage")) {
							context.QueueTasks.Enqueue("SelectFolderMessage");
						}
						break;
					case "GridTabPanelTabChange":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "TuningModeChanged":
							if (ActivatedEventElements.Contains("TuningModeChangedEvent")) {
							context.QueueTasks.Enqueue("TuningModeChangedEvent");
						}
						break;
					case "ShowMessage":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "FolderActiveRowChanged":
							if (ActivatedEventElements.Contains("StartMessageNonInterruptingEvent2")) {
							context.QueueTasks.Enqueue("StartMessageNonInterruptingEvent2");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
						}
						break;
					case "GridLoadRows":
							if (ActivatedEventElements.Contains("StartGridLoadRows")) {
							context.QueueTasks.Enqueue("StartGridLoadRows");
						}
						break;
					case "GridActiveRowChanged":
							if (ActivatedEventElements.Contains("GridActiveRowChanged")) {
							context.QueueTasks.Enqueue("GridActiveRowChanged");
						}
						break;
					case "RefreshDetails":
							if (ActivatedEventElements.Contains("RefreshDetails")) {
							context.QueueTasks.Enqueue("RefreshDetails");
						}
						break;
					case "DetailsTabPanelTabChange":
							if (ActivatedEventElements.Contains("DetailsTabPanelTabChange")) {
							context.QueueTasks.Enqueue("DetailsTabPanelTabChange");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("BaseModuleInit")) {
							context.QueueTasks.Enqueue("BaseModuleInit");
						}
						break;
					case "ApplySearchFilter":
							if (ActivatedEventElements.Contains("ApplySearchFilter")) {
							context.QueueTasks.Enqueue("ApplySearchFilter");
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("BasePrepareActiveDataSourceFilterStartMessage")) {
							context.QueueTasks.Enqueue("BasePrepareActiveDataSourceFilterStartMessage");
						}
						break;
					case "ChartMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageChartMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageChartMenuItemClick");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("StartMessageBaseModulePageLoad")) {
							context.QueueTasks.Enqueue("StartMessageBaseModulePageLoad");
						}
						break;
					case "ReportMenuItemClick":
							if (ActivatedEventElements.Contains("ReportMenuItemClickEvent")) {
							context.QueueTasks.Enqueue("ReportMenuItemClickEvent");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("AnalyticsChartPageContainerID") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AnalyticsChartPageContainerID", AnalyticsChartPageContainerID, null);
			}
			if (!HasMapping("HasActions") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HasActions", HasActions, false);
			}
			if (!HasMapping("SearchFilterEnabled") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SearchFilterEnabled", SearchFilterEnabled, false);
			}
			if (CustomChartIdList != null) {
				if (CustomChartIdList.GetType().IsSerializable ||
					CustomChartIdList.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("CustomChartIdList", CustomChartIdList, null);
				}
			}
			if (!HasMapping("OldTabPanelClientId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldTabPanelClientId", OldTabPanelClientId, null);
			}
			if (!HasMapping("CurrentChartPropertyId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentChartPropertyId", CurrentChartPropertyId, Guid.Empty);
			}
			if (!HasMapping("IsDuplicatesFolder") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDuplicatesFolder", IsDuplicatesFolder, false);
			}
			if (!HasMapping("SysModuleProcessPrimaryColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleProcessPrimaryColumnUId", SysModuleProcessPrimaryColumnUId, Guid.Empty);
			}
			if (!HasMapping("CurrentReportSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentReportSchemaUId", CurrentReportSchemaUId, Guid.Empty);
			}
			if (!HasMapping("TypeColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("TypeColumnUId", TypeColumnUId, Guid.Empty);
			}
			if (!HasMapping("SysEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysEntitySchemaId", SysEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("FoldersMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FoldersMode", FoldersMode, null);
			}
			if (!HasMapping("RootFolderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RootFolderId", RootFolderId, Guid.Empty);
			}
			if (!HasMapping("IsRecentFolder") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsRecentFolder", IsRecentFolder, false);
			}
			if (!HasMapping("AnalyticsTabName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AnalyticsTabName", AnalyticsTabName, null);
			}
			if (!HasMapping("ClearFilterEditFilters") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ClearFilterEditFilters", ClearFilterEditFilters, false);
			}
			if (!HasMapping("_isHasAnalyticsInitialized") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("_isHasAnalyticsInitialized", _isHasAnalyticsInitialized, false);
			}
			if (!HasMapping("MainPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MainPageProcessUId", MainPageProcessUId, null);
			}
			if (!HasMapping("CurrentChartCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentChartCaption", CurrentChartCaption, null);
			}
			if (!HasMapping("ChartTabItemClientID") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ChartTabItemClientID", ChartTabItemClientID, null);
			}
			if (!HasMapping("HasAnalytics") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HasAnalytics", HasAnalytics, false);
			}
			if (!HasMapping("PDV") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PDV", PDV, null);
			}
			if (!HasMapping("PCV") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PCV", PCV, Guid.Empty);
			}
			if (!HasMapping("IgnoreSearchFilter") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IgnoreSearchFilter", IgnoreSearchFilter, false);
			}
			if (!HasMapping("StaticFolder") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("StaticFolder", StaticFolder, false);
			}
			if (!HasMapping("SearchFolder") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SearchFolder", SearchFolder, false);
			}
			if (!HasMapping("GotoFolderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("GotoFolderId", GotoFolderId, Guid.Empty);
			}
			if (ModuleProcessesCaption != null) {
				if (ModuleProcessesCaption.GetType().IsSerializable ||
					ModuleProcessesCaption.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ModuleProcessesCaption", ModuleProcessesCaption, null);
				}
			}
			if (!HasMapping("IsModuleProcessesTuningMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsModuleProcessesTuningMode", IsModuleProcessesTuningMode, false);
			}
			if (ModuleProcesses != null) {
				if (ModuleProcesses.GetType().IsSerializable ||
					ModuleProcesses.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ModuleProcesses", ModuleProcesses, null);
				}
			}
			if (!HasMapping("SearchPrimaryDisplayColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SearchPrimaryDisplayColumnValue", SearchPrimaryDisplayColumnValue, null);
			}
			if (!HasMapping("HasDetails") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HasDetails", HasDetails, false);
			}
			if (!HasMapping("FilterColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FilterColumnValue", FilterColumnValue, Guid.Empty);
			}
			if (!HasMapping("SysModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
			}
			if (!HasMapping("IsRootFolder") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsRootFolder", IsRootFolder, false);
			}
			if (!HasMapping("FolderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FolderId", FolderId, Guid.Empty);
			}
			if (!HasMapping("FolderEntryEntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FolderEntryEntitySchemaUId", FolderEntryEntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("FolderEntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FolderEntitySchemaUId", FolderEntitySchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseModulePageEventsProcess

	/// <exclude/>
	public class BaseModulePageEventsProcess : BaseModulePageEventsProcess<Terrasoft.WebApp.BaseModulePageSchemaUserControl>
	{

		public BaseModulePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseModulePageSchemaUserControl

	/// <exclude/>
	public partial class BaseModulePageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout LeftControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("LeftControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer CustomSearchContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("CustomSearchContainer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout FolderLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("FolderLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer BaseFolder {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("BaseFolder", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterEditLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("FilterEditLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("FilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SaveToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SaveToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ApplyToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ApplyToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout RightControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("RightControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel GridTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("GridTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab GridTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("GridTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer Grid {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("Grid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel DetailsTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("DetailsTabPanel", true);
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
			SaveToolButton.AjaxEvents.Click.Event += SaveToolButtonClick;
			ApplyToolButton.AjaxEvents.Click.Event += ApplyToolButtonClick;
			GridTabPanel.AjaxEvents.TabChange.Event += GridTabPanelTabChange;
			DetailsTabPanel.AjaxEvents.TabChange.Event += DetailsTabPanelTabChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SaveToolButton.AjaxEvents.Click.Event -= SaveToolButtonClick;
			ApplyToolButton.AjaxEvents.Click.Event -= ApplyToolButtonClick;
			GridTabPanel.AjaxEvents.TabChange.Event -= GridTabPanelTabChange;
			DetailsTabPanel.AjaxEvents.TabChange.Event -= DetailsTabPanelTabChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseModulePageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseModulePageEventsProcess(UserConnection);
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

		public virtual void SaveToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SaveToolButtonClick");
		}

		public virtual void ApplyToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ApplyToolButtonClick");
		}

		public virtual void GridTabPanelTabChange(object sender, EventArgs e) {
			object result = ThrowEvent("GridTabPanelTabChange");
		}

		public virtual void DetailsTabPanelTabChange(object sender, EventArgs e) {
			object result = ThrowEvent("DetailsTabPanelTabChange");
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
			SchemaName = "BaseModulePage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseModulePageEventsProcessSchema

	/// <exclude/>
	public class BaseModulePageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseModulePageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseModulePageEventsProcessSchema(BaseModulePageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseModulePageEventsProcess";
			UId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b");
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

		protected virtual ProcessSchemaParameter CreateFolderEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ca41f223-2de8-43a5-8184-85149bbad677"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"FolderEntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFolderEntryEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dd0e6255-842c-48da-924f-558f8b24ec39"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"FolderEntryEntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4aed04f4-0625-48c8-8e81-99ce5dcc44bb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"FolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsRootFolderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f85b4983-c573-47d2-904d-317c5366889b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"IsRootFolder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b7d5c8b2-fea5-4193-bea9-596931dd8be6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SysModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("000a6a20-9b9a-4a79-9fad-73fd79419de9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"FilterColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHasDetailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c788f890-0431-4ceb-ac15-5c86e096d077"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"HasDetails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchPrimaryDisplayColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("100ee50a-9c05-4d76-a38f-4b52e2694679"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SearchPrimaryDisplayColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateModuleProcessesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6eee74e1-9383-4103-90c2-b457198b6c89"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ModuleProcesses",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsModuleProcessesTuningModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0955ee69-6fe5-411b-90a1-d3cfe4c0ea63"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"IsModuleProcessesTuningMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateModuleProcessesCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9c0d1cde-324e-450c-9570-8423aee9224f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ModuleProcessesCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateGotoFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be73414f-b0ff-41fa-936a-088d4798b339"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"GotoFolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchFolderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a02c303b-e4f9-469f-87d4-e56bbf8d3577"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SearchFolder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateStaticFolderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("82b431ae-3600-487a-ad4d-1bdadd4dca63"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"StaticFolder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIgnoreSearchFilterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1f261f8e-ca0e-48fa-8fba-10ca0a0fa9c9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"IgnoreSearchFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePCVParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("51291833-3d9b-4742-bbed-df2701a66398"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"PCV",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePDVParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba0dd39c-95fa-4c30-a105-68d0fa5b3761"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"PDV",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHasAnalyticsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("72f7e4cd-29ca-43d8-88c3-ee0703e69fbe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"HasAnalytics",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChartTabItemClientIDParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("541389ac-f1db-4c6c-bbf8-9c260bfde735"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ChartTabItemClientID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentChartCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d4fad2fd-8942-438b-853f-1e684f360abb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"CurrentChartCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMainPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d15da88f-e0b1-465f-af2a-7dcc78082810"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"MainPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter Create_isHasAnalyticsInitializedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3ab13b68-19dc-47b2-9e04-e07b13991b48"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"_isHasAnalyticsInitialized",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateClearFilterEditFiltersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e30f3d55-061e-4980-b0ee-f88ff8488d45"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ClearFilterEditFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAnalyticsTabNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0affe62f-06ab-4038-9a17-aa4136c9d808"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"AnalyticsTabName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsRecentFolderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("31fb3c0e-87e9-4b83-b114-36220b5b8298"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"IsRecentFolder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRootFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("39a9ad25-029a-4430-bc25-4ca3e89ab86f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"RootFolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFoldersModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dc51efc1-f662-4825-a8a6-ee5b08fdb57f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"FoldersMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b63e8a05-3b0d-400d-88df-9ee76ec0fc84"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SysEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTypeColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("40468aa8-5448-4aa1-a4bf-9767199425ba"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"TypeColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentReportSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8f949276-4a0c-4328-a404-d065b5b673aa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"CurrentReportSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleProcessPrimaryColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6a26b08e-2cc7-4f6d-9df9-29046a37b811"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SysModuleProcessPrimaryColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDuplicatesFolderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5439545a-65c6-4779-a3e7-70accaf1809a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"IsDuplicatesFolder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentChartPropertyIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6b4d2daa-645d-4d7e-a816-59813c16e5ec"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"CurrentChartPropertyId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldTabPanelClientIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("581af572-47dc-40b7-abb4-a5b176e53f55"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"OldTabPanelClientId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCustomChartIdListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("483fdada-55ab-4b8f-8410-3f675ab3c0bb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"CustomChartIdList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchFilterEnabledParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("38e30bb3-e29f-4c31-8f00-496b989ee082"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SearchFilterEnabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHasActionsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2b043bc6-7ba9-4044-8061-5f6936ac2a75"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"HasActions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAnalyticsChartPageContainerIDParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b98e78ce-2d17-45f1-83db-34d881e13c44"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"AnalyticsChartPageContainerID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFolderEntitySchemaUIdParameter());
			Parameters.Add(CreateFolderEntryEntitySchemaUIdParameter());
			Parameters.Add(CreateFolderIdParameter());
			Parameters.Add(CreateIsRootFolderParameter());
			Parameters.Add(CreateSysModuleIdParameter());
			Parameters.Add(CreateFilterColumnValueParameter());
			Parameters.Add(CreateHasDetailsParameter());
			Parameters.Add(CreateSearchPrimaryDisplayColumnValueParameter());
			Parameters.Add(CreateModuleProcessesParameter());
			Parameters.Add(CreateIsModuleProcessesTuningModeParameter());
			Parameters.Add(CreateModuleProcessesCaptionParameter());
			Parameters.Add(CreateGotoFolderIdParameter());
			Parameters.Add(CreateSearchFolderParameter());
			Parameters.Add(CreateStaticFolderParameter());
			Parameters.Add(CreateIgnoreSearchFilterParameter());
			Parameters.Add(CreatePCVParameter());
			Parameters.Add(CreatePDVParameter());
			Parameters.Add(CreateHasAnalyticsParameter());
			Parameters.Add(CreateChartTabItemClientIDParameter());
			Parameters.Add(CreateCurrentChartCaptionParameter());
			Parameters.Add(CreateMainPageProcessUIdParameter());
			Parameters.Add(Create_isHasAnalyticsInitializedParameter());
			Parameters.Add(CreateClearFilterEditFiltersParameter());
			Parameters.Add(CreateAnalyticsTabNameParameter());
			Parameters.Add(CreateIsRecentFolderParameter());
			Parameters.Add(CreateRootFolderIdParameter());
			Parameters.Add(CreateFoldersModeParameter());
			Parameters.Add(CreateSysEntitySchemaIdParameter());
			Parameters.Add(CreateTypeColumnUIdParameter());
			Parameters.Add(CreateCurrentReportSchemaUIdParameter());
			Parameters.Add(CreateSysModuleProcessPrimaryColumnUIdParameter());
			Parameters.Add(CreateIsDuplicatesFolderParameter());
			Parameters.Add(CreateCurrentChartPropertyIdParameter());
			Parameters.Add(CreateOldTabPanelClientIdParameter());
			Parameters.Add(CreateCustomChartIdListParameter());
			Parameters.Add(CreateSearchFilterEnabledParameter());
			Parameters.Add(CreateHasActionsParameter());
			Parameters.Add(CreateAnalyticsChartPageContainerIDParameter());
		}

		protected virtual void InitializeSaveFiltersUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("aee0bbbe-46f6-4cdb-850a-52d7208459e7"),
				ContainerUId = new Guid("c738dbb5-465f-45fa-b840-4d7bf0272597"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Name = @"DataSource",
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
				UId = new Guid("80ba0076-ba33-44ff-b2cd-bd2c0a675c9b"),
				ContainerUId = new Guid("c738dbb5-465f-45fa-b840-4d7bf0272597"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Name = @"FilterName",
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
				UId = new Guid("bc4cf44f-2d6f-4fac-b5e7-5170eafecc79"),
				ContainerUId = new Guid("c738dbb5-465f-45fa-b840-4d7bf0272597"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Name = @"StoringEntitySchemaId",
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
				UId = new Guid("1f2fb97c-764b-4d53-8fd3-c381de117213"),
				ContainerUId = new Guid("c738dbb5-465f-45fa-b840-4d7bf0272597"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Name = @"StoringColumnUId",
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
				UId = new Guid("d62d30c8-a92b-49b6-acd7-026c658ae0b2"),
				ContainerUId = new Guid("c738dbb5-465f-45fa-b840-4d7bf0272597"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				Name = @"StoringPrimaryColumnValue",
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
		}

		protected virtual void InitializeMessageWindowUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a2737c3d-133a-47a4-a445-d0644e685865"),
				ContainerUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
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
				UId = new Guid("6c5e3e16-4529-4e3a-9dd8-68395e38fc94"),
				ContainerUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
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
				UId = new Guid("660ecb56-de82-4909-a5b5-a5a380e253ff"),
				ContainerUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
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
				UId = new Guid("2156b64e-46d8-4bb2-857a-6e68b0d0e61c"),
				ContainerUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
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
				UId = new Guid("a3f4e429-c13f-4a88-871a-d0b6fe95b84a"),
				ContainerUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
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
				UId = new Guid("ad443bf0-84dd-4e00-aa93-41a37a53acc3"),
				ContainerUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
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
				UId = new Guid("1d5d93d5-19b9-4d58-bb1e-f3f34c420ca6"),
				ContainerUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
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
				UId = new Guid("1c57c72d-7e04-436a-bacb-cc87eb949ac8"),
				ContainerUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
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

		protected virtual void InitializeSetDetailFilterParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("86bfdea6-abeb-41b5-9215-60f13071c074"),
				ContainerUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Name = @"DetailPageContainer",
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
				UId = new Guid("7199a902-be72-42ed-b9de-19d3f046c24e"),
				ContainerUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Name = @"PageDataSource",
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
				UId = new Guid("a85feaa9-ae4c-4be4-bcd6-c39b8e042b0c"),
				ContainerUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Name = @"DetailPageFilterName",
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
				UId = new Guid("5f36024b-5c87-4a16-b6ab-7acb64b2e4bc"),
				ContainerUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Name = @"ThrowEventName",
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
				UId = new Guid("ce7104db-cab4-462f-b7ad-8dc51a0492e8"),
				ContainerUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Name = @"FilterLeftExpressions",
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
				UId = new Guid("d167f041-9fba-441b-ad0c-743b6beb766f"),
				ContainerUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Name = @"FilterRightValue",
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
				UId = new Guid("b312afe3-b7bd-45e2-889f-6d1bd68b13ca"),
				ContainerUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Name = @"FilterName",
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
				UId = new Guid("840b9e27-b0e8-4019-b929-9138cb1826e5"),
				ContainerUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Name = @"ParentColumnMetaPath",
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
				UId = new Guid("d14bd53c-5123-42ef-a8bc-e758b9289e01"),
				ContainerUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				Name = @"SysEntitySchemaId",
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
		}

		protected virtual void InitializeNewInitializeDetailsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("620fe206-1547-4a34-a76e-d46743da3bb9"),
				ContainerUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Name = @"SysModuleId",
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
				UId = new Guid("26af0d12-d757-44c5-9ca7-e0c765efa525"),
				ContainerUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Name = @"DetailTabPanel",
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
				UId = new Guid("6e2b6c14-c676-475a-9d07-998189533d30"),
				ContainerUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Name = @"SysModuleEditId",
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
				UId = new Guid("7e5539ef-1146-4893-a7c6-a9229b730a8b"),
				ContainerUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Name = @"InModuleEdit",
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
				UId = new Guid("66c3178f-3b64-45ac-9b1e-568515e8119e"),
				ContainerUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Name = @"ParentSysEntitySchemaId",
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
				UId = new Guid("c6ac9bef-457f-4695-9fab-72a9f37d2ca4"),
				ContainerUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Name = @"UseModuleDetails",
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
				UId = new Guid("9434f5eb-1976-41d1-9438-c663215bccb0"),
				ContainerUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Name = @"DefaultCollapsed",
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
				UId = new Guid("c98a48ad-fedc-4937-b972-8b804487e1d1"),
				ContainerUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Name = @"DetailFilter",
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
				UId = new Guid("c0e61ced-ea48-4936-af4e-66dc39352656"),
				ContainerUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Name = @"ActiveTabIndex",
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
		}

		protected virtual void InitializeModuleInitializePrimaryGridsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("bda4b2df-1cf6-4857-a08d-a43465940e19"),
				ContainerUId = new Guid("60c5d1fe-e493-48c6-bf06-1c6639fc9093"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Name = @"PrimaryGridTabPanel",
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
				UId = new Guid("07a573e6-593d-4d5e-a85f-35ad033d7cab"),
				ContainerUId = new Guid("60c5d1fe-e493-48c6-bf06-1c6639fc9093"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Name = @"SysModuleId",
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
		}

		protected virtual void InitializeLoadDynamicFolderFilterUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("502feba5-0399-493e-887f-0b5b83de50ac"),
				ContainerUId = new Guid("38152366-49b4-4937-ab64-1e8329d9205e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Name = @"StoringEntitySchemaId",
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
				UId = new Guid("e33a7fe4-27b6-4707-a6ca-42817b14f0bf"),
				ContainerUId = new Guid("38152366-49b4-4937-ab64-1e8329d9205e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Name = @"StoringColumnUId",
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
				UId = new Guid("e365ba5c-4770-40a2-9ece-dc0875170444"),
				ContainerUId = new Guid("38152366-49b4-4937-ab64-1e8329d9205e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Name = @"StoringPrimaryColumnValue",
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
				UId = new Guid("8a83f537-f57d-454a-871e-c9caa5f0bcc1"),
				ContainerUId = new Guid("38152366-49b4-4937-ab64-1e8329d9205e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Name = @"DataSource",
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
				UId = new Guid("9862c819-0350-4cf2-bc12-5269710035bb"),
				ContainerUId = new Guid("38152366-49b4-4937-ab64-1e8329d9205e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				Name = @"FilterName",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
		}

		protected virtual void InitializeLoadRecentFolderFilterUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d17bb7fd-4d7b-4867-9aae-4387e378d387"),
				ContainerUId = new Guid("315a9d2d-af50-404d-94f3-925ce81a0d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef"),
				Name = @"DataSource",
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

		protected virtual void InitializeLoadDuplicatesFolderFilterUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("eabea890-b843-43d0-871f-dfe2cb1cfc6f"),
				ContainerUId = new Guid("314ee1f8-9911-490a-b969-6d195cf8a333"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Name = @"DataSource",
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
				UId = new Guid("fa430703-f685-47b9-a805-8a26d5625ab2"),
				ContainerUId = new Guid("314ee1f8-9911-490a-b969-6d195cf8a333"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				Name = @"DuplicatesTableName",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet82 = CreateLaneSet82LaneSet();
			LaneSets.Add(schemaLaneSet82);
			ProcessSchemaLane schemaLane207 = CreateLane207Lane();
			schemaLaneSet82.Lanes.Add(schemaLane207);
			ProcessSchemaEventSubProcess applytoolbuttonsubprocess = CreateApplyToolButtonSubProcessEventSubProcess();
			FlowElements.Add(applytoolbuttonsubprocess);
			ProcessSchemaEventSubProcess savetoolbuttonsubprocess = CreateSaveToolButtonSubProcessEventSubProcess();
			FlowElements.Add(savetoolbuttonsubprocess);
			ProcessSchemaEventSubProcess cleartoolbuttonsubprocess = CreateClearToolButtonSubProcessEventSubProcess();
			FlowElements.Add(cleartoolbuttonsubprocess);
			ProcessSchemaEventSubProcess subprocessselectfolder = CreateSubProcessSelectFolderEventSubProcess();
			FlowElements.Add(subprocessselectfolder);
			ProcessSchemaEventSubProcess eventsubprocessactualprimarygriddata = CreateEventSubProcessActualPrimaryGridDataEventSubProcess();
			FlowElements.Add(eventsubprocessactualprimarygriddata);
			ProcessSchemaEventSubProcess subprocess7 = CreateSubProcess7EventSubProcess();
			FlowElements.Add(subprocess7);
			ProcessSchemaEventSubProcess subprocess12 = CreateSubProcess12EventSubProcess();
			FlowElements.Add(subprocess12);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaEventSubProcess basepreparefilteractivedatasourcesubprocess = CreateBasePrepareFilterActiveDataSourceSubProcessEventSubProcess();
			FlowElements.Add(basepreparefilteractivedatasourcesubprocess);
			ProcessSchemaEventSubProcess subprocesschartmenuitemclick = CreateSubProcessChartMenuItemClickEventSubProcess();
			FlowElements.Add(subprocesschartmenuitemclick);
			ProcessSchemaEventSubProcess basemodulepageload = CreateBaseModulePageLoadEventSubProcess();
			FlowElements.Add(basemodulepageload);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaStartMessageEvent applytoolbuttonclick = CreateApplyToolButtonClickStartMessageEvent();
			applytoolbuttonsubprocess.FlowElements.Add(applytoolbuttonclick);
			ProcessSchemaScriptTask applyfilterstoolbuttonscript = CreateApplyFiltersToolButtonScriptScriptTask();
			applytoolbuttonsubprocess.FlowElements.Add(applyfilterstoolbuttonscript);
			ProcessSchemaStartMessageEvent savetoolbuttonclick = CreateSaveToolButtonClickStartMessageEvent();
			savetoolbuttonsubprocess.FlowElements.Add(savetoolbuttonclick);
			ProcessSchemaScriptTask savefilterstoolbuttonscript = CreateSaveFiltersToolButtonScriptScriptTask();
			savetoolbuttonsubprocess.FlowElements.Add(savefilterstoolbuttonscript);
			ProcessSchemaUserTask savefiltersusertask = CreateSaveFiltersUserTaskUserTask();
			savetoolbuttonsubprocess.FlowElements.Add(savefiltersusertask);
			ProcessSchemaStartMessageEvent cleartoolbuttonclick = CreateClearToolButtonClickStartMessageEvent();
			cleartoolbuttonsubprocess.FlowElements.Add(cleartoolbuttonclick);
			ProcessSchemaScriptTask clearfilterstoolbuttonscript = CreateClearFiltersToolButtonScriptScriptTask();
			cleartoolbuttonsubprocess.FlowElements.Add(clearfilterstoolbuttonscript);
			ProcessSchemaStartMessageEvent selectfoldermessage = CreateSelectFolderMessageStartMessageEvent();
			subprocessselectfolder.FlowElements.Add(selectfoldermessage);
			ProcessSchemaScriptTask scriptselectfolder = CreateScriptSelectFolderScriptTask();
			subprocessselectfolder.FlowElements.Add(scriptselectfolder);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocessactualprimarygriddata.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scriptactualizegriddata = CreateScriptActualizeGridDataScriptTask();
			eventsubprocessactualprimarygriddata.FlowElements.Add(scriptactualizegriddata);
			ProcessSchemaStartMessageEvent tuningmodechangedevent = CreateTuningModeChangedEventStartMessageEvent();
			subprocess7.FlowElements.Add(tuningmodechangedevent);
			ProcessSchemaScriptTask scriptswitchprocessmode = CreateScriptSwitchProcessModeScriptTask();
			subprocess7.FlowElements.Add(scriptswitchprocessmode);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			subprocess12.FlowElements.Add(startmessage1);
			ProcessSchemaUserTask messagewindowusertask = CreateMessageWindowUserTaskUserTask();
			subprocess12.FlowElements.Add(messagewindowusertask);
			ProcessSchemaStartMessageEvent startmessagenoninterruptingevent2 = CreateStartMessageNonInterruptingEvent2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessagenoninterruptingevent2);
			ProcessSchemaScriptTask scriptfolderactiverowchanged = CreateScriptFolderActiveRowChangedScriptTask();
			eventsubprocess1.FlowElements.Add(scriptfolderactiverowchanged);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask scriptpageloadcomplete = CreateScriptPageLoadCompleteScriptTask();
			eventsubprocess2.FlowElements.Add(scriptpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowrefreshdetails = CreateIntermediateThrowRefreshDetailsIntermediateThrowMessageEvent();
			eventsubprocess4.FlowElements.Add(intermediatethrowrefreshdetails);
			ProcessSchemaStartMessageEvent startgridloadrows = CreateStartGridLoadRowsStartMessageEvent();
			eventsubprocess4.FlowElements.Add(startgridloadrows);
			ProcessSchemaStartMessageEvent gridactiverowchanged = CreateGridActiveRowChangedStartMessageEvent();
			eventsubprocess4.FlowElements.Add(gridactiverowchanged);
			ProcessSchemaScriptTask scriptgridactiverowchanged = CreateScriptGridActiveRowChangedScriptTask();
			eventsubprocess4.FlowElements.Add(scriptgridactiverowchanged);
			ProcessSchemaUserTask setdetailfilter = CreateSetDetailFilterUserTask();
			eventsubprocess6.FlowElements.Add(setdetailfilter);
			ProcessSchemaEndEvent end2 = CreateEnd2EndEvent();
			eventsubprocess6.FlowElements.Add(end2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess6.FlowElements.Add(exclusivegateway1);
			ProcessSchemaStartMessageEvent refreshdetails = CreateRefreshDetailsStartMessageEvent();
			eventsubprocess6.FlowElements.Add(refreshdetails);
			ProcessSchemaScriptTask scriptrefreshdetails = CreateScriptRefreshDetailsScriptTask();
			eventsubprocess6.FlowElements.Add(scriptrefreshdetails);
			ProcessSchemaStartMessageEvent detailstabpaneltabchange = CreateDetailsTabPanelTabChangeStartMessageEvent();
			eventsubprocess7.FlowElements.Add(detailstabpaneltabchange);
			ProcessSchemaIntermediateThrowMessageEvent throwgridactiverowchanged = CreateThrowGridActiveRowChangedIntermediateThrowMessageEvent();
			eventsubprocess7.FlowElements.Add(throwgridactiverowchanged);
			ProcessSchemaScriptTask scriptdetailtabchanged = CreateScriptDetailTabChangedScriptTask();
			eventsubprocess7.FlowElements.Add(scriptdetailtabchanged);
			ProcessSchemaStartMessageEvent basemoduleinit = CreateBaseModuleInitStartMessageEvent();
			subprocess1.FlowElements.Add(basemoduleinit);
			ProcessSchemaScriptTask scriptbasegridpageinit = CreateScriptBaseGridPageInitScriptTask();
			subprocess1.FlowElements.Add(scriptbasegridpageinit);
			ProcessSchemaScriptTask createanalyticstab = CreateCreateAnalyticsTabScriptTask();
			subprocess1.FlowElements.Add(createanalyticstab);
			ProcessSchemaScriptTask scriptprepareinitializedetails = CreateScriptPrepareInitializeDetailsScriptTask();
			subprocess1.FlowElements.Add(scriptprepareinitializedetails);
			ProcessSchemaUserTask newinitializedetails = CreateNewInitializeDetailsUserTask();
			subprocess1.FlowElements.Add(newinitializedetails);
			ProcessSchemaScriptTask scriptprepareinitializeprimarygrids = CreateScriptPrepareInitializePrimaryGridsScriptTask();
			subprocess1.FlowElements.Add(scriptprepareinitializeprimarygrids);
			ProcessSchemaUserTask moduleinitializeprimarygrids = CreateModuleInitializePrimaryGridsUserTask();
			subprocess1.FlowElements.Add(moduleinitializeprimarygrids);
			ProcessSchemaScriptTask createcharttabscripttask = CreateCreateChartTabScriptTaskScriptTask();
			subprocess1.FlowElements.Add(createcharttabscripttask);
			ProcessSchemaStartMessageEvent applysearchfilter = CreateApplySearchFilterStartMessageEvent();
			subprocess2.FlowElements.Add(applysearchfilter);
			ProcessSchemaScriptTask scriptapplysearchfilter = CreateScriptApplySearchFilterScriptTask();
			subprocess2.FlowElements.Add(scriptapplysearchfilter);
			ProcessSchemaStartMessageEvent baseprepareactivedatasourcefilterstartmessage = CreateBasePrepareActiveDataSourceFilterStartMessageStartMessageEvent();
			basepreparefilteractivedatasourcesubprocess.FlowElements.Add(baseprepareactivedatasourcefilterstartmessage);
			ProcessSchemaScriptTask scriptbasepreparefilters = CreateScriptBasePrepareFiltersScriptTask();
			basepreparefilteractivedatasourcesubprocess.FlowElements.Add(scriptbasepreparefilters);
			ProcessSchemaUserTask loaddynamicfolderfilterusertask = CreateLoadDynamicFolderFilterUserTaskUserTask();
			basepreparefilteractivedatasourcesubprocess.FlowElements.Add(loaddynamicfolderfilterusertask);
			ProcessSchemaScriptTask scripttaskprepeareanalyticschartfiltersparam = CreateScriptTaskPrepeareAnalyticsChartFiltersParamScriptTask();
			basepreparefilteractivedatasourcesubprocess.FlowElements.Add(scripttaskprepeareanalyticschartfiltersparam);
			ProcessSchemaExclusiveGateway loadfiltersexclusivegateway = CreateLoadFiltersExclusiveGatewayExclusiveGateway();
			basepreparefilteractivedatasourcesubprocess.FlowElements.Add(loadfiltersexclusivegateway);
			ProcessSchemaUserTask loadrecentfolderfilterusertask = CreateLoadRecentFolderFilterUserTaskUserTask();
			basepreparefilteractivedatasourcesubprocess.FlowElements.Add(loadrecentfolderfilterusertask);
			ProcessSchemaUserTask loadduplicatesfolderfilterusertask = CreateLoadDuplicatesFolderFilterUserTaskUserTask();
			basepreparefilteractivedatasourcesubprocess.FlowElements.Add(loadduplicatesfolderfilterusertask);
			ProcessSchemaStartMessageEvent startmessagechartmenuitemclick = CreateStartMessageChartMenuItemClickStartMessageEvent();
			subprocesschartmenuitemclick.FlowElements.Add(startmessagechartmenuitemclick);
			ProcessSchemaScriptTask scriptchartmenuitemclick = CreateScriptChartMenuItemClickScriptTask();
			subprocesschartmenuitemclick.FlowElements.Add(scriptchartmenuitemclick);
			ProcessSchemaStartMessageEvent startmessagebasemodulepageload = CreateStartMessageBaseModulePageLoadStartMessageEvent();
			basemodulepageload.FlowElements.Add(startmessagebasemodulepageload);
			ProcessSchemaScriptTask scripttaskbasemodulepageload = CreateScriptTaskBaseModulePageLoadScriptTask();
			basemodulepageload.FlowElements.Add(scripttaskbasemodulepageload);
			ProcessSchemaStartMessageEvent reportmenuitemclickevent = CreateReportMenuItemClickEventStartMessageEvent();
			eventsubprocess5.FlowElements.Add(reportmenuitemclickevent);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess5.FlowElements.Add(scripttask3);
			FlowElements.Add(CreateSequenceFlow618SequenceFlow());
			FlowElements.Add(CreateSequenceFlow619SequenceFlow());
			FlowElements.Add(CreateSequenceFlow620SequenceFlow());
			FlowElements.Add(CreateSequenceFlow621SequenceFlow());
			FlowElements.Add(CreateSequenceFlow622ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow623SequenceFlow());
			FlowElements.Add(CreateSequenceFlow626SequenceFlow());
			FlowElements.Add(CreateSequenceFlow627SequenceFlow());
			FlowElements.Add(CreateSequenceFlow634SequenceFlow());
			FlowElements.Add(CreateSequenceFlow636SequenceFlow());
			FlowElements.Add(CreateSequenceFlow637SequenceFlow());
			FlowElements.Add(CreateSequenceFlow638SequenceFlow());
			FlowElements.Add(CreateSequenceFlow639SequenceFlow());
			FlowElements.Add(CreateSequenceFlow642SequenceFlow());
			FlowElements.Add(CreateSequenceFlow644SequenceFlow());
			FlowElements.Add(CreateSequenceFlow645SequenceFlow());
			FlowElements.Add(CreateSequenceFlow646SequenceFlow());
			FlowElements.Add(CreateSequenceFlow647SequenceFlow());
			FlowElements.Add(CreateSequenceFlow648SequenceFlow());
			FlowElements.Add(CreateSequenceFlow653SequenceFlow());
			FlowElements.Add(CreateSequenceFlow655SequenceFlow());
			FlowElements.Add(CreateSequenceFlow656SequenceFlow());
			FlowElements.Add(CreateConditionalFlow44ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow45ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow46ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow661SequenceFlow());
			FlowElements.Add(CreateSequenceFlow662SequenceFlow());
			FlowElements.Add(CreateSequenceFlow663SequenceFlow());
			FlowElements.Add(CreateSequenceFlow664SequenceFlow());
			FlowElements.Add(CreateSequenceFlow665SequenceFlow());
			FlowElements.Add(CreateSequenceFlow666SequenceFlow());
			FlowElements.Add(CreateSequenceFlow667SequenceFlow());
			FlowElements.Add(CreateSequenceFlow668SequenceFlow());
			FlowElements.Add(CreateSequenceFlow669SequenceFlow());
			FlowElements.Add(CreateSequenceFlow670SequenceFlow());
			FlowElements.Add(CreateSequenceFlow672SequenceFlow());
			FlowElements.Add(CreateIsDuplicatesFolderConditionalFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlowbase1SequenceFlow());
			FlowElements.Add(CreateSequenceFlowbase2SequenceFlow());
			FlowElements.Add(CreateSequenceFlowbase3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCreateNewProcessMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateEditProcessMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateDeleteProcessMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateTuningModeCaptionLocalizableString());
			LocalizableStrings.Add(CreateLunchModeCaptionLocalizableString());
			LocalizableStrings.Add(CreateAnalyticsTabCaptionLocalizableString());
			LocalizableStrings.Add(CreateOpenProcessDesignerCaptionLocalizableString());
			LocalizableStrings.Add(CreateModuleProcessInstanceNotExistCaptionLocalizableString());
			LocalizableStrings.Add(CreateModuleProcessInstanceNotExistMessageLocalizableString());
			LocalizableStrings.Add(CreateRunFromModuleErrorCaptionLocalizableString());
			LocalizableStrings.Add(CreateRunFromModuleErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateChartStartTabCaptionLocalizableString());
			LocalizableStrings.Add(CreateDeleteProcessMessageLocalizableString());
			LocalizableStrings.Add(CreateWarningLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCreateNewProcessMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2a591787-5c4f-4cdc-99c0-497e24227c99"),
				Name = "CreateNewProcessMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEditProcessMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f9c1ba11-ee78-4a5e-9926-e0aa409ae9f3"),
				Name = "EditProcessMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteProcessMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1d7474eb-6295-46b1-83c2-afa3e3bb54cd"),
				Name = "DeleteProcessMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTuningModeCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("668c0bf7-8e0a-48f9-8df2-c404c6a6f9fd"),
				Name = "TuningModeCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLunchModeCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("38d1a7b8-1003-4563-af6f-e509db9993cc"),
				Name = "LunchModeCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAnalyticsTabCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("29dca9f3-20f4-4d4d-905a-9af0922efc6e"),
				Name = "AnalyticsTabCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOpenProcessDesignerCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("96ebeddf-a18c-40f3-9370-8cb20ff93ef2"),
				Name = "OpenProcessDesignerCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateModuleProcessInstanceNotExistCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f4c8e228-f27d-4a1a-a9d8-e1c1abf88315"),
				Name = "ModuleProcessInstanceNotExistCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateModuleProcessInstanceNotExistMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f0756088-3522-460e-8b60-2bdfbebc8d3c"),
				Name = "ModuleProcessInstanceNotExistMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRunFromModuleErrorCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("99cf8410-0905-4a8b-aada-1b51d98fcd05"),
				Name = "RunFromModuleErrorCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRunFromModuleErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9059d6ef-aeb7-4d87-b907-4a92ebceb253"),
				Name = "RunFromModuleErrorMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateChartStartTabCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7ef67877-3b53-4b7d-9c0d-d79a7bbb9cf2"),
				Name = "ChartStartTabCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteProcessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e09886fe-f2e0-4d6a-ad1b-2197cb95b1ce"),
				Name = "DeleteProcessMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("86832921-56ae-473e-ab88-6fffda6136d2"),
				Name = "Warning",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow618SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow618",
				UId = new Guid("10384bcb-83fe-40bb-8024-98335ecc2e2c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(498, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4028f0c6-c9d6-4ca4-9db8-386de44e27e8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4e5c6dc3-113c-4004-84cb-6b14ccbb67e6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow619SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow619",
				UId = new Guid("c554bb4e-b9a0-4e88-9998-5edc4059071f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(698, 148),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e7d23ad1-afd7-4258-b13d-f4b25cf013e2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("06b901c9-4ed9-47b8-aba2-ce4db41424aa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow620SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow620",
				UId = new Guid("a0725f73-2bdc-4c13-817d-516ceafc2fbb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(414, 478),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a44fc451-9a1e-41b7-a4fc-10bb00e6e2bc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3430111f-e0b0-4718-9569-56a642c6f0ce"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow621SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow621",
				UId = new Guid("3b93f928-04da-41ba-99af-5d59854fe974"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(130, 474),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ac99924-e1ff-41b6-ac74-f88199101f4b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bf254f82-276a-43f5-811a-9754106a7fca"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow622ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow622",
				UId = new Guid("ad6af38e-970c-4af2-b933-516641462231"),
				ConditionExpression = @"HasDetails",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(264, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a01ad8dc-1909-4992-9095-64e4cad18e3d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow623SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow623",
				UId = new Guid("79f36ed8-b8d5-49fe-9d8b-94d5bd1f4451"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(174, 552),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e7cef7ce-590f-47bb-9edb-f76ed34c8462"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("110dcbb5-6faa-43fa-881e-e77579cef33e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow626SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow626",
				UId = new Guid("77bbdccc-ce7d-4a1d-842f-4c8843c9f561"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01803384-c8e7-4383-8a05-e44e773e15de"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("04ce925b-8e5e-4d7d-9058-bfcbd9baf135"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow627SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow627",
				UId = new Guid("eb189cb2-1f07-4b27-b34c-93ffee363b25"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(420, 694),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60c5d1fe-e493-48c6-bf06-1c6639fc9093"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e325b3bb-0aac-4c62-b8bb-247bcb0e3234"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow634SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow634",
				UId = new Guid("f0d0074c-6b13-469c-9010-74cb6b905a91"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(346, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("28caa023-3287-47a8-811c-ef30a7270d0d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow636SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow636",
				UId = new Guid("35a819c0-38bc-4f09-b40a-84e3af4928af"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(162, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75a788e7-919b-4834-ba3b-f715e9688bda"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dded46dc-0797-451f-837a-2b4231b73f51"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow637SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow637",
				UId = new Guid("cc425a00-afb5-46d6-b64d-561463722115"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(397, 1734),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("549776a8-4634-4e3b-9123-328efa3e02fa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("80c70f71-81a8-45cb-baa8-534806e48922"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow638SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow638",
				UId = new Guid("e0a6a19b-20fd-4baa-9259-41feb507a6fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(152, 2377),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac0bf2d1-368e-4214-a2ea-f254b638f8bd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d22eefbf-339a-4f62-a566-09366f91bbb8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow639SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow639",
				UId = new Guid("04e28206-68c9-4c3b-99c6-39ea13f86bbb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(556, 2124),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18357e04-bef8-4316-94b6-a41e9bc6380a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d61b9529-fb07-469e-ad8d-48fe768395ca"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow642SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow642",
				UId = new Guid("8e746196-1d1d-4929-b3c0-7ea1d1796660"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(672, 1640),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2ec3cc6f-1752-42e1-9d98-2cda0a26c735"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bfee0893-f2d6-46bc-bb5c-042b58079f4f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow644SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow644",
				UId = new Guid("02e39ad3-3714-4583-b8a1-9652a2ca3c71"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(522, 1968),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3430111f-e0b0-4718-9569-56a642c6f0ce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3e0c8f4-e7c6-44c6-81bc-de6165a322f7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow645SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow645",
				UId = new Guid("e7041f8a-74b7-40c7-b4d6-9da999171b9c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2c52edbd-39b4-42ce-8b04-c33c02ab6f50"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b226c629-a388-41b4-9090-d9cdd09b4dd6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow646SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow646",
				UId = new Guid("8e9b2430-c690-403d-9657-9443d0372ba5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ad7d2ac8-5b7c-4e36-bef6-cc2ef83f74e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("457708c1-540a-40e7-86f3-bc8fb92575fa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow647SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow647",
				UId = new Guid("c68cae1a-53ef-428d-9df5-06d9bf8b6fdb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(538, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("457708c1-540a-40e7-86f3-bc8fb92575fa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c738dbb5-465f-45fa-b840-4d7bf0272597"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow648SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow648",
				UId = new Guid("d26a5017-7d5f-4b7f-bfd5-3b37facf42db"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f0bb923e-9234-42aa-bd2b-6a101e15ef3c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ffe421e-558d-406c-98da-ece403f4a12d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow653SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow653",
				UId = new Guid("edf52f69-56c8-4b8d-b2dc-afcb538c65cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(274, 2214),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d22eefbf-339a-4f62-a566-09366f91bbb8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("34a366df-57cc-4224-bf1e-b98b1c4e11e0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow655SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow655",
				UId = new Guid("4453b359-b511-4741-b0c5-d5ad8a305a82"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(316, 1770),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a01ad8dc-1909-4992-9095-64e4cad18e3d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68a90b1c-3aab-4b27-961e-7943f21ea886"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow656SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow656",
				UId = new Guid("c2b40566-09c1-4148-96e9-bd25f1318f24"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(240, 1744),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("06b901c9-4ed9-47b8-aba2-ce4db41424aa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a01ad8dc-1909-4992-9095-64e4cad18e3d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow44ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow44",
				UId = new Guid("2a084e94-cc89-44d3-94e8-6dd6d8d0fb00"),
				ConditionExpression = @"!IgnoreSearchFilter",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(328, 2226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d22eefbf-339a-4f62-a566-09366f91bbb8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18390420-e227-43af-9614-1f417152eb6b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow45ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow45",
				UId = new Guid("17a592fc-49c1-4fa1-9e7c-dca30055fe08"),
				ConditionExpression = @"SearchFolder",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(358, 2258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18390420-e227-43af-9614-1f417152eb6b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("38152366-49b4-4937-ab64-1e8329d9205e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow46ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow46",
				UId = new Guid("af35487b-b09e-4346-8e98-e00c1ade3a53"),
				ConditionExpression = @"IsRecentFolder",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(454, 2260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18390420-e227-43af-9614-1f417152eb6b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("315a9d2d-af50-404d-94f3-925ce81a0d8b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow661SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow661",
				UId = new Guid("0137a634-2829-44e2-b7f7-db207ad8dd40"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(408, 2336),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18390420-e227-43af-9614-1f417152eb6b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("34a366df-57cc-4224-bf1e-b98b1c4e11e0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow662SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow662",
				UId = new Guid("a75e4c9f-82d4-402c-bcef-551be1f08e69"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(563, 1848),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ac99924-e1ff-41b6-ac74-f88199101f4b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("efe19fd4-ef4a-472a-a77f-23930ca8c5b3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow663SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow663",
				UId = new Guid("cd0185a9-48ab-4d92-a65b-69c49e5339b6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(563, 1888),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ac99924-e1ff-41b6-ac74-f88199101f4b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bf162ea5-c8f1-46f8-a3d1-a427347ab298"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow664SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow664",
				UId = new Guid("528e26c4-1d1b-458c-9ced-e320ca355f02"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(720, 1948),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("efe19fd4-ef4a-472a-a77f-23930ca8c5b3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60c5d1fe-e493-48c6-bf06-1c6639fc9093"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow665SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow665",
				UId = new Guid("7deba3dc-6dc4-4515-bdb5-5dd73f1b9196"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(716, 2022),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf162ea5-c8f1-46f8-a3d1-a427347ab298"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow666SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow666",
				UId = new Guid("51eb8eb4-0ef3-486e-bfdf-bb35735d2bb0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2cb023d8-67fe-498a-9dc3-9ae59af648cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c2f105df-9e79-45d7-a7e5-67f369785a9e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow667SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow667",
				UId = new Guid("906f7f94-a352-443f-bc62-8d045ff46846"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(564, 1980),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e325b3bb-0aac-4c62-b8bb-247bcb0e3234"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1de8f7c8-5267-49f9-91cc-771f52be6d64"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow668SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow668",
				UId = new Guid("234c7a69-52d1-451e-84b5-a5f154c91a4c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(1236, 2095),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc7e71ef-202a-432b-baa0-dea8efd17219"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2b598d0f-e35f-4bc2-b692-c6648f906d25"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow669SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow669",
				UId = new Guid("d3552b80-1a9e-4714-89cc-16fd50ca1fe4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(1020, 1782),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("50a6fa73-a0a3-4045-ae8f-33620058ed18"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f5f6e58-6d80-4c44-b0a0-da1e579f2418"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow670SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow670",
				UId = new Guid("086ad8b9-7ce6-4f97-8770-3b1a73a74fc3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(1158, 1848),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f5f6e58-6d80-4c44-b0a0-da1e579f2418"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3bbfaaaa-8b03-42fc-9094-eeeea2c490e9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow672SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow672",
				UId = new Guid("a06c05aa-fd1c-4516-b46b-20c71d7a0455"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(1010, 1874),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ce8b9cec-10e6-434c-9c98-f31a455bc40a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f5f6e58-6d80-4c44-b0a0-da1e579f2418"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsDuplicatesFolderConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsDuplicatesFolderConditionalFlow",
				UId = new Guid("c941b19f-7286-41fa-bda1-df3986f10a79"),
				ConditionExpression = @"IsDuplicatesFolder",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(516, 2392),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18390420-e227-43af-9614-1f417152eb6b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("314ee1f8-9911-490a-b969-6d195cf8a333"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowbase1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowbase1",
				UId = new Guid("56d2a8c3-06a1-40e5-a0de-5d18bb3d9902"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(456, 2512),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("315a9d2d-af50-404d-94f3-925ce81a0d8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("34a366df-57cc-4224-bf1e-b98b1c4e11e0"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowbase2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowbase2",
				UId = new Guid("23716d54-235a-4a29-8d44-293ff2f07060"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(498, 2500),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("314ee1f8-9911-490a-b969-6d195cf8a333"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("34a366df-57cc-4224-bf1e-b98b1c4e11e0"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowbase3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowbase3",
				UId = new Guid("44e8322c-5fb7-42ea-ace7-92c1efcc0810"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CurveCenterPosition = new Point(551, 2498),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("38152366-49b4-4937-ab64-1e8329d9205e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("34a366df-57cc-4224-bf1e-b98b1c4e11e0"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet82LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet82 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d8ce2774-4c0b-490a-bca3-ed2483706575"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"LaneSet82",
				Position = new Point(5, 5),
				Size = new Size(1377, 1783),
				UseBackgroundMode = false
			};
			return schemaLaneSet82;
		}

		protected virtual ProcessSchemaLane CreateLane207Lane() {
			ProcessSchemaLane schemaLane207 = new ProcessSchemaLane(this) {
				UId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d8ce2774-4c0b-490a-bca3-ed2483706575"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"Lane207",
				Position = new Point(29, 0),
				Size = new Size(1348, 172),
				UseBackgroundMode = false
			};
			return schemaLane207;
		}

		protected virtual ProcessSchemaEventSubProcess CreateApplyToolButtonSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaApplyToolButtonSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("00bc284c-f18b-446c-930d-1876e7530788"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ApplyToolButtonSubProcess",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(237, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaApplyToolButtonSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateApplyToolButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2c52edbd-39b4-42ce-8b04-c33c02ab6f50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00bc284c-f18b-446c-930d-1876e7530788"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ApplyToolButtonClick",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ApplyToolButtonClick",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateApplyFiltersToolButtonScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b226c629-a388-41b4-9090-d9cdd09b4dd6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00bc284c-f18b-446c-930d-1876e7530788"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ApplyFiltersToolButtonScript",
				Position = new Point(119, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,207,203,47,74,13,78,77,44,74,206,112,203,204,41,73,45,82,176,85,40,41,42,77,181,230,114,206,1,138,66,196,92,83,50,75,32,172,98,160,116,90,98,78,49,80,222,177,160,32,167,18,42,170,161,137,202,119,203,47,114,204,75,204,201,44,201,76,6,203,21,165,150,148,22,229,65,12,6,0,119,185,204,203,115,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSaveToolButtonSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSaveToolButtonSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e0153415-eaf1-45c2-8ff5-d6ba7feddae8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SaveToolButtonSubProcess",
				Position = new Point(288, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(339, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSaveToolButtonSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSaveToolButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ad7d2ac8-5b7c-4e36-bef6-cc2ef83f74e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0153415-eaf1-45c2-8ff5-d6ba7feddae8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SaveToolButtonClick",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SaveToolButtonClick",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveFiltersToolButtonScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("457708c1-540a-40e7-86f3-bc8fb92575fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0153415-eaf1-45c2-8ff5-d6ba7feddae8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SaveFiltersToolButtonScript",
				Position = new Point(120, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,65,79,164,48,24,61,187,137,255,161,203,193,208,3,13,204,192,56,19,227,1,24,216,152,152,141,9,234,197,120,104,160,204,52,91,90,183,148,217,16,245,191,111,75,157,129,196,81,227,129,38,109,191,247,222,247,30,95,105,13,220,92,176,138,200,171,10,252,188,4,191,58,90,161,172,121,82,61,56,59,3,5,193,178,220,218,123,248,124,250,227,100,135,37,168,109,57,175,5,208,245,68,229,135,189,11,47,116,205,213,134,11,73,222,160,148,41,34,117,93,141,89,75,204,173,17,0,85,207,113,67,75,139,188,237,159,136,22,191,4,156,252,27,244,93,103,17,165,177,191,10,23,158,239,47,67,47,92,158,135,94,18,4,231,94,26,204,131,213,42,206,231,201,42,114,224,129,142,52,152,178,143,201,178,217,60,143,103,11,47,74,178,204,203,252,32,240,226,229,34,209,220,65,20,173,253,48,245,131,181,37,163,58,140,137,59,29,7,239,24,51,65,140,167,232,154,240,141,218,162,236,111,167,45,185,51,8,129,9,198,54,82,127,208,195,8,127,240,31,209,173,40,148,164,124,227,194,65,117,34,107,145,123,238,35,41,65,240,242,2,142,213,190,139,96,223,215,228,151,21,229,86,151,233,190,220,27,188,33,40,193,45,177,8,148,83,94,153,179,84,112,37,5,75,250,223,184,33,174,179,198,10,23,162,147,37,113,32,192,45,24,247,16,89,178,139,131,68,41,88,215,240,187,193,247,84,14,165,195,69,139,244,164,236,121,237,108,24,54,7,34,13,177,44,5,222,17,59,47,237,93,171,109,224,246,15,26,21,237,172,197,165,162,59,50,158,218,137,59,142,45,148,48,41,103,92,81,213,219,102,222,119,247,169,250,27,67,58,177,118,176,249,37,234,70,210,6,203,222,130,239,49,235,140,133,253,83,179,104,73,84,39,57,80,178,27,158,198,201,171,94,204,247,93,214,241,209,106,26,77,48,229,253,15,86,99,114,24,225,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSaveFiltersUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c738dbb5-465f-45fa-b840-4d7bf0272597"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0153415-eaf1-45c2-8ff5-d6ba7feddae8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SaveFiltersUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 37),
				SchemaUId = new Guid("15dcd24f-b49b-4c28-9c88-bbb615bcef56"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSaveFiltersUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateClearToolButtonSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaClearToolButtonSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c5ffbdd2-da8d-4ed5-8d6f-d76714230f0a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ClearToolButtonSubProcess",
				Position = new Point(637, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaClearToolButtonSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateClearToolButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f0bb923e-9234-42aa-bd2b-6a101e15ef3c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5ffbdd2-da8d-4ed5-8d6f-d76714230f0a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ClearToolButtonClick",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ClearToolButtonClick",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateClearFiltersToolButtonScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5ffe421e-558d-406c-98da-ece403f4a12d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5ffbdd2-da8d-4ed5-8d6f-d76714230f0a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ClearFiltersToolButtonScript",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,193,106,195,48,12,64,207,245,87,120,61,37,23,247,3,66,15,89,182,150,94,198,32,43,61,107,142,210,26,60,43,200,114,160,140,253,123,189,165,75,160,186,72,150,228,135,222,8,172,59,16,104,41,177,69,189,213,123,148,218,138,27,241,101,238,22,101,181,217,188,195,25,205,206,121,65,126,237,156,152,198,35,112,158,168,49,19,250,185,191,103,74,67,198,44,76,211,36,102,12,210,10,39,43,137,255,41,49,231,208,61,95,223,224,11,139,245,66,94,151,90,173,254,2,162,254,64,102,136,212,139,57,30,204,9,63,27,10,194,228,163,153,139,229,204,9,209,144,247,152,5,40,84,202,245,186,120,60,237,105,171,67,242,190,212,223,106,245,48,91,156,126,212,225,28,136,177,205,111,123,153,192,89,42,27,96,165,234,97,240,215,187,195,142,184,14,224,157,56,27,127,63,50,102,195,48,45,222,0,63,27,48,36,91,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessSelectFolderEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessSelectFolder = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f7a8c8ec-c4f1-48cd-9c4d-7498600065af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SubProcessSelectFolder",
				Position = new Point(36, 196),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(242, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessSelectFolder;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSelectFolderMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("75a788e7-919b-4834-ba3b-f715e9688bda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7a8c8ec-c4f1-48cd-9c4d-7498600065af"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SelectFolder",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SelectFolderMessage",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSelectFolderScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dded46dc-0797-451f-837a-2b4231b73f51"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7a8c8ec-c4f1-48cd-9c4d-7498600065af"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptSelectFolder",
				Position = new Point(134, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,143,65,139,194,48,16,133,207,155,95,17,61,37,151,224,189,174,176,74,45,130,136,96,111,226,33,107,198,26,169,25,157,76,117,69,252,239,182,219,117,169,199,121,124,124,243,94,100,242,161,144,59,44,29,208,204,201,79,185,250,77,76,122,60,241,45,17,126,39,85,47,67,198,233,31,97,210,115,101,203,168,178,202,187,22,210,90,222,197,71,199,240,134,231,216,10,149,78,196,67,116,40,181,197,192,240,195,38,223,19,94,211,11,4,254,162,34,74,27,229,220,71,30,226,247,1,182,60,210,235,193,230,77,162,150,182,0,51,182,17,218,31,102,234,131,107,178,73,237,35,44,199,183,133,61,130,234,231,4,144,145,119,125,221,40,95,151,54,43,40,107,239,2,29,168,87,155,218,218,237,220,76,248,95,151,8,2,174,40,72,166,10,146,39,65,168,31,58,47,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessActualPrimaryGridDataEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessActualPrimaryGridData = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d090adbb-712c-45ac-b56f-75a5ed557750"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"EventSubProcessActualPrimaryGridData",
				Position = new Point(295, 196),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(289, 193),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessActualPrimaryGridData;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2cb023d8-67fe-498a-9dc3-9ae59af648cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d090adbb-712c-45ac-b56f-75a5ed557750"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"GridTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"StartMessage2",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptActualizeGridDataScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c2f105df-9e79-45d7-a7e5-67f369785a9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d090adbb-712c-45ac-b56f-75a5ed557750"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptActualizeGridData",
				Position = new Point(175, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,49,111,194,48,16,133,231,34,241,31,12,3,74,36,100,117,71,12,40,80,154,161,20,137,168,11,98,112,227,107,176,228,56,145,125,166,141,170,254,247,218,73,72,104,139,80,55,231,238,252,222,249,123,17,111,36,24,109,89,6,52,178,6,139,124,7,76,167,199,168,80,200,132,2,77,31,5,231,160,200,100,66,110,12,249,86,172,12,50,149,2,25,205,137,178,82,134,228,115,56,184,59,49,77,56,67,182,43,172,118,189,57,89,3,46,82,20,39,88,118,213,32,156,185,201,127,202,211,173,46,82,48,134,238,0,221,177,4,141,213,11,147,22,130,113,194,116,6,216,235,142,167,23,214,222,227,107,56,240,251,176,218,63,97,175,110,157,218,117,173,5,119,159,91,166,64,82,119,48,251,191,229,197,249,82,172,56,124,28,102,141,148,48,237,144,147,234,100,233,134,229,53,134,133,98,178,66,145,26,87,244,53,119,73,120,220,6,181,80,25,141,205,198,113,122,214,171,188,196,42,136,142,76,163,215,71,200,35,41,64,97,188,12,27,136,151,46,163,222,230,60,69,91,82,230,186,70,243,112,111,220,233,52,178,245,35,31,132,68,208,43,46,208,19,189,8,229,106,80,83,130,218,214,44,239,22,101,41,171,230,182,105,18,236,217,122,101,183,107,208,239,234,55,50,251,251,3,97,166,102,222,133,27,254,72,215,203,244,18,55,178,142,205,83,193,173,132,118,2,76,98,149,99,234,138,62,246,27,221,240,151,69,114,212,197,251,234,228,80,185,31,168,155,114,32,85,6,124,220,194,211,128,86,171,250,237,179,111,105,134,145,98,49,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("75b58cfb-0882-46a5-a300-9ab6355324e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SubProcess7",
				Position = new Point(35, 422),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(207, 153),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTuningModeChangedEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("01803384-c8e7-4383-8a05-e44e773e15de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75b58cfb-0882-46a5-a300-9ab6355324e9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TuningModeChanged",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"TuningModeChangedEvent",
				Position = new Point(22, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSwitchProcessModeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("04ce925b-8e5e-4d7d-9058-bfcbd9baf135"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75b58cfb-0882-46a5-a300-9ab6355324e9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptSwitchProcessMode",
				Position = new Point(106, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,193,110,226,48,16,61,131,196,63,24,14,85,42,85,86,239,168,43,1,165,85,14,116,145,22,182,135,170,7,151,12,96,201,76,34,219,97,55,90,245,223,119,236,56,36,161,80,118,15,189,68,201,100,230,205,155,55,207,142,205,44,77,114,5,115,157,174,192,24,48,139,28,37,110,40,8,236,142,245,227,243,191,135,189,174,92,179,168,111,172,166,8,143,205,83,174,212,119,61,221,101,182,136,102,66,226,92,108,170,186,101,156,92,95,179,63,189,110,103,47,52,203,202,32,225,47,13,232,73,138,8,43,43,83,228,113,72,159,226,70,34,240,71,176,33,48,46,8,225,20,40,145,232,4,56,254,195,167,103,160,109,241,83,168,28,162,65,73,54,164,59,206,131,27,246,201,68,23,208,226,58,149,234,9,202,234,220,215,188,247,186,110,44,65,67,236,97,33,222,104,48,71,147,63,106,153,208,231,92,32,40,78,47,230,229,99,120,84,21,197,152,192,239,215,97,9,37,77,72,34,168,3,44,127,18,59,96,253,59,54,66,161,10,43,87,134,130,46,22,54,81,23,93,93,177,211,107,153,108,133,182,174,153,133,221,68,73,64,27,223,135,197,52,91,246,235,158,85,22,167,53,89,210,223,156,198,40,85,56,239,135,99,202,161,169,107,103,125,75,7,175,83,181,180,82,73,43,193,240,7,137,73,8,70,94,54,247,8,36,64,223,124,16,33,172,131,9,195,40,226,54,233,216,56,112,82,12,137,138,83,133,62,185,227,109,104,156,28,45,251,198,110,91,225,151,219,87,210,158,181,90,149,76,189,113,69,213,211,37,16,233,168,85,40,142,11,61,229,24,141,21,184,114,75,234,116,90,0,124,254,137,213,206,154,244,31,44,124,212,102,177,213,233,175,233,158,22,85,157,8,151,73,107,196,13,36,3,95,241,126,88,223,193,6,229,216,163,44,83,197,131,84,22,180,137,124,106,237,244,74,132,218,44,255,33,69,13,241,101,50,52,90,92,150,128,198,47,143,94,2,68,89,153,234,128,86,103,185,53,142,55,103,21,33,131,142,11,231,192,104,112,223,174,29,148,110,4,173,133,73,215,150,47,99,254,12,111,161,198,240,195,75,149,79,52,214,169,6,177,218,178,200,81,113,230,149,120,204,200,223,36,225,204,174,27,22,172,45,221,112,108,118,198,168,151,73,93,178,114,246,165,14,206,142,183,70,29,74,117,231,116,187,216,113,110,109,138,51,192,188,233,223,94,87,131,205,53,250,155,96,248,23,104,207,43,135,218,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c62c3e45-a71d-4fc9-b97b-06cbaa3c5169"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SubProcess12",
				Position = new Point(252, 429),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 145),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("28caa023-3287-47a8-811c-ef30a7270d0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c62c3e45-a71d-4fc9-b97b-06cbaa3c5169"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ShowMessage",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"StartMessage1",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateMessageWindowUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9704569d-40a7-45cb-9db0-c8f4027a161b"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c62c3e45-a71d-4fc9-b97b-06cbaa3c5169"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"MessageWindowUserTask",
				Position = new Point(147, 35),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeMessageWindowUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("17dccbfb-66fc-4800-9f25-fd13f1e4812a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"EventSubProcess1",
				Position = new Point(526, 607),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(263, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageNonInterruptingEvent2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("549776a8-4634-4e3b-9123-328efa3e02fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("17dccbfb-66fc-4800-9f25-fd13f1e4812a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FolderActiveRowChanged",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"StartMessageNonInterruptingEvent2",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptFolderActiveRowChangedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("80c70f71-81a8-45cb-baa8-534806e48922"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("17dccbfb-66fc-4800-9f25-fd13f1e4812a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptFolderActiveRowChanged",
				Position = new Point(154, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,193,110,194,48,12,61,131,196,63,4,78,84,154,242,3,19,7,40,69,234,129,13,141,178,29,166,105,202,168,129,108,105,210,57,14,163,26,251,247,57,180,220,56,37,126,182,223,243,115,146,26,80,184,208,134,0,179,82,83,123,243,98,34,8,3,220,15,250,249,222,58,132,53,23,109,15,109,146,115,59,101,124,76,30,21,10,229,235,149,218,3,163,241,144,211,46,84,94,20,128,168,188,219,145,220,228,242,5,62,82,103,9,157,241,50,22,112,119,215,41,211,224,201,85,115,69,234,117,180,110,252,210,149,193,192,187,7,3,91,130,114,225,76,9,152,151,163,55,150,184,6,178,112,107,66,109,247,227,132,137,244,78,140,253,37,148,185,127,8,198,60,98,86,213,212,140,219,177,87,168,43,133,205,92,251,218,168,38,117,38,84,246,89,153,0,137,56,159,197,48,59,17,183,77,63,213,233,9,190,3,120,74,196,239,160,223,155,214,181,105,186,117,92,84,254,4,176,107,17,197,134,55,213,150,74,219,104,104,133,110,11,222,111,242,50,105,169,226,154,234,22,100,15,27,15,200,171,176,236,78,59,43,243,174,60,179,123,109,65,46,180,45,59,100,214,48,197,45,86,30,166,23,199,184,114,14,39,194,242,28,173,88,175,67,101,113,64,247,147,29,193,210,181,80,230,150,221,88,101,226,75,192,137,238,196,40,141,207,95,56,103,102,129,200,217,212,232,237,215,232,34,240,199,142,7,125,4,10,104,219,207,240,15,51,231,229,191,43,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0df00d5a-c629-4f7c-9cf9-74718353a85e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"EventSubProcess2",
				Position = new Point(28, 607),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(272, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4028f0c6-c9d6-4ca4-9db8-386de44e27e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0df00d5a-c629-4f7c-9cf9-74718353a85e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"PageLoadComplete",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4e5c6dc3-113c-4004-84cb-6b14ccbb67e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0df00d5a-c629-4f7c-9cf9-74718353a85e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptPageLoadComplete",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,72,76,79,245,201,79,76,113,206,207,205,73,45,73,213,208,180,6,0,94,84,177,11,27,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1757fe07-d165-4c16-accf-f5bb77eb1ead"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"EventSubProcess4",
				Position = new Point(868, 761),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(388, 322),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowRefreshDetailsIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3bbfaaaa-8b03-42fc-9094-eeeea2c490e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1757fe07-d165-4c16-accf-f5bb77eb1ead"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"RefreshDetails",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"IntermediateThrowRefreshDetails",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(288, 154),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartGridLoadRowsStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ce8b9cec-10e6-434c-9c98-f31a455bc40a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1757fe07-d165-4c16-accf-f5bb77eb1ead"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridLoadRows",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"StartGridLoadRows",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 152),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGridActiveRowChangedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("50a6fa73-a0a3-4045-ae8f-33620058ed18"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1757fe07-d165-4c16-accf-f5bb77eb1ead"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"GridActiveRowChanged",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"GridActiveRowChanged",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridActiveRowChangedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2f5f6e58-6d80-4c44-b0a0-da1e579f2418"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1757fe07-d165-4c16-accf-f5bb77eb1ead"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptGridActiveRowChanged",
				Position = new Point(141, 140),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,79,75,3,65,12,197,207,46,236,119,8,61,181,151,193,187,40,148,169,150,61,8,197,245,207,65,68,226,110,42,3,51,147,146,201,172,44,226,119,119,150,22,173,138,167,144,228,247,222,75,6,20,232,81,177,229,44,29,193,57,172,73,151,157,186,129,86,95,211,249,226,172,174,134,2,98,218,109,240,117,162,166,98,150,135,22,19,220,146,8,38,222,170,185,107,204,3,189,88,142,42,236,147,153,128,162,62,40,141,205,73,57,76,214,143,179,118,76,215,220,103,79,207,248,43,112,246,84,34,190,175,50,214,59,138,218,172,138,145,219,194,252,104,211,146,167,78,169,111,148,194,70,92,64,25,45,251,28,226,61,250,76,201,88,206,81,225,2,78,23,240,94,87,39,87,206,43,201,17,241,51,103,255,248,13,191,253,181,42,209,31,117,69,62,209,191,70,235,236,122,115,25,118,58,238,97,33,205,18,65,165,168,63,1,245,246,30,56,103,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a3dd999a-f1ff-4a8b-a940-ce74f46cf245"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"EventSubProcess6",
				Position = new Point(29, 754),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(411, 198),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaUserTask CreateSetDetailFilterUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1f25f85d-ddff-4e6b-97e9-56df85779083"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3dd999a-f1ff-4a8b-a940-ce74f46cf245"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SetDetailFilter",
				Position = new Point(301, 19),
				SchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSetDetailFilterParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd2EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("68a90b1c-3aab-4b27-961e-7943f21ea886"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3dd999a-f1ff-4a8b-a940-ce74f46cf245"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"End2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(323, 140),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("a01ad8dc-1909-4992-9095-64e4cad18e3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3dd999a-f1ff-4a8b-a940-ce74f46cf245"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(182, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRefreshDetailsStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e7d23ad1-afd7-4258-b13d-f4b25cf013e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3dd999a-f1ff-4a8b-a940-ce74f46cf245"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RefreshDetails",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"RefreshDetails",
				Position = new Point(14, 84),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptRefreshDetailsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("06b901c9-4ed9-47b8-aba2-ce4db41424aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3dd999a-f1ff-4a8b-a940-ce74f46cf245"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptRefreshDetails",
				Position = new Point(77, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,223,111,218,48,16,126,78,165,254,15,110,30,166,160,78,17,207,99,108,162,133,181,209,182,42,2,186,61,84,60,152,228,2,94,131,205,108,167,37,90,249,223,119,78,2,56,63,90,77,123,50,220,221,247,221,221,231,59,231,150,170,49,104,202,82,69,134,36,161,169,130,193,249,217,19,149,36,46,173,115,186,12,41,135,20,189,33,93,129,63,174,155,171,224,45,186,14,17,35,181,53,39,161,138,204,65,74,170,68,162,253,251,192,255,9,203,107,193,181,20,169,242,77,0,66,151,66,164,85,162,107,145,166,116,171,32,70,154,70,106,255,232,67,8,75,136,103,178,249,247,10,66,41,18,150,2,121,247,142,92,188,154,106,178,211,126,160,70,191,232,110,10,191,51,80,186,71,254,156,159,57,69,213,37,126,76,53,197,172,5,107,120,50,13,234,81,129,134,141,137,58,5,60,180,234,76,25,112,29,140,23,6,90,20,106,65,47,134,132,103,105,90,102,111,122,253,31,52,197,218,124,83,53,101,92,125,133,220,115,163,67,219,110,175,66,57,109,173,140,132,40,167,84,208,193,247,96,113,44,252,185,152,105,201,248,202,235,245,76,129,206,222,113,240,216,159,159,237,141,172,94,179,27,252,97,10,202,184,38,195,33,233,147,151,23,210,186,153,91,22,199,192,177,58,195,36,65,103,146,19,45,51,115,183,251,230,24,117,92,172,73,209,82,113,20,105,246,4,248,55,224,49,236,22,213,157,95,216,179,133,23,26,10,165,175,104,244,88,42,147,8,73,60,134,149,50,204,210,31,224,241,177,51,89,217,15,250,47,47,173,139,232,44,139,45,124,163,228,65,130,79,164,95,191,132,183,90,98,197,4,56,206,82,2,125,44,181,182,148,182,19,214,114,24,153,203,36,111,72,105,250,175,198,4,100,173,128,146,235,161,191,48,171,87,11,27,216,105,27,4,246,88,182,210,222,218,175,67,101,182,74,145,34,2,165,142,69,212,152,139,29,15,184,210,148,71,197,94,153,208,10,142,99,170,65,126,131,68,79,118,91,137,118,38,248,137,165,12,245,111,64,227,207,45,72,157,23,211,236,185,95,58,96,110,207,116,59,194,229,207,143,111,145,196,45,196,29,201,54,252,59,50,134,84,175,255,129,60,236,128,33,121,165,15,249,76,80,31,85,236,143,63,217,108,117,78,62,252,39,165,181,135,88,113,157,99,214,226,152,65,10,145,134,248,78,196,248,222,177,13,149,121,73,88,248,221,247,164,20,197,178,25,86,228,41,239,173,244,250,229,113,71,55,230,149,118,109,151,219,17,61,203,213,132,107,166,243,89,180,134,13,13,204,59,211,178,117,224,186,250,45,30,214,182,185,3,61,126,99,188,155,211,220,206,188,42,158,228,153,200,100,116,252,18,221,72,22,99,235,60,62,192,241,131,112,149,27,21,60,247,20,237,118,9,118,42,166,33,221,17,246,186,124,243,181,20,207,147,39,236,249,128,50,133,24,174,41,36,56,182,235,169,120,238,194,117,141,119,241,85,238,176,191,10,159,178,213,90,23,115,128,200,214,108,32,204,222,241,191,145,5,54,153,253,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("070340df-5e51-40d7-9043-6018dc983530"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"EventSubProcess7",
				Position = new Point(869, 1543),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 119),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDetailsTabPanelTabChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a44fc451-9a1e-41b7-a4fc-10bb00e6e2bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("070340df-5e51-40d7-9043-6018dc983530"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DetailsTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"DetailsTabPanelTabChange",
				Position = new Point(29, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowGridActiveRowChangedIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e3e0c8f4-e7c6-44c6-81bc-de6165a322f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("070340df-5e51-40d7-9043-6018dc983530"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"RefreshDetails",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ThrowGridActiveRowChanged",
				Position = new Point(253, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDetailTabChangedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3430111f-e0b0-4718-9569-56a642c6f0ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("070340df-5e51-40d7-9043-6018dc983530"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptDetailTabChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 19),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,93,111,218,48,20,125,166,82,255,131,151,39,71,67,134,61,35,38,65,187,110,72,237,132,70,182,61,84,213,228,36,23,234,41,216,153,63,104,35,202,127,239,181,147,0,97,83,7,130,56,92,223,143,115,207,61,246,134,107,146,131,229,162,48,9,79,231,92,66,65,198,100,206,87,192,252,227,74,73,220,147,160,217,141,144,121,107,209,170,152,86,95,249,26,104,116,221,141,141,98,194,13,73,64,107,110,212,210,178,239,51,246,19,210,38,198,176,253,75,235,63,186,188,88,42,13,60,123,36,116,131,80,44,79,137,144,167,136,188,187,137,201,246,242,162,39,150,132,162,19,155,89,88,251,124,78,90,242,145,12,235,205,158,79,81,30,195,198,94,246,222,247,195,135,243,192,117,26,31,181,121,133,135,51,201,172,216,112,11,121,75,210,196,148,97,253,6,127,28,24,203,110,148,94,223,251,146,87,133,0,105,103,215,228,61,137,126,29,71,70,15,100,60,38,145,213,14,162,144,220,255,6,3,223,216,59,74,255,143,110,234,172,85,50,46,207,153,206,92,11,105,235,128,40,142,217,23,145,231,32,227,64,85,232,137,123,80,224,3,177,159,110,70,111,156,73,99,185,204,32,192,236,29,156,217,92,171,12,12,142,81,87,11,176,248,175,4,109,171,31,188,112,88,116,102,238,84,238,10,104,156,192,36,78,10,185,66,35,68,125,242,198,110,252,87,157,228,81,171,167,79,27,36,146,70,88,168,22,219,81,83,119,32,93,84,135,13,6,59,191,120,26,79,20,48,38,210,21,5,121,121,57,25,97,163,153,94,134,174,66,186,186,203,93,59,110,147,34,37,18,158,200,162,50,168,30,150,192,179,101,11,139,181,87,83,39,138,28,52,141,71,7,205,105,196,136,1,244,148,196,96,127,75,117,135,247,67,186,69,166,69,105,239,184,196,100,250,84,105,126,212,77,4,146,114,236,121,238,225,235,4,133,162,53,126,246,25,16,52,82,83,59,80,147,246,201,146,23,6,250,93,68,53,208,154,233,208,159,56,167,234,158,149,134,119,130,31,147,178,73,89,130,204,111,113,131,154,192,110,56,66,28,7,190,29,238,24,207,115,186,253,176,139,71,168,156,6,100,123,176,250,39,130,109,237,113,13,239,172,244,185,186,229,149,114,150,254,171,64,147,232,160,136,192,1,142,3,211,38,170,150,66,163,129,14,61,120,23,172,4,106,70,79,193,223,109,77,58,41,236,180,154,252,230,207,45,185,97,9,225,88,1,191,26,172,211,146,248,123,97,244,10,132,249,21,15,150,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SubProcess1",
				Position = new Point(449, 758),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(406, 471),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseModuleInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7ac99924-e1ff-41b6-ac74-f88199101f4b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"BaseModuleInit",
				Position = new Point(21, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptBaseGridPageInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bf254f82-276a-43f5-811a-9754106a7fca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptBaseGridPageInit",
				Position = new Point(119, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,82,205,114,218,48,16,62,195,12,239,160,248,100,39,25,229,1,58,28,72,112,18,31,66,153,186,63,231,197,94,140,50,66,114,87,107,10,211,201,187,119,101,76,128,94,60,242,106,247,251,91,153,117,122,147,239,89,23,97,246,14,251,111,248,187,195,192,153,250,59,25,143,74,4,170,54,207,198,50,82,238,96,101,177,86,83,197,212,225,23,185,53,107,149,6,38,227,26,153,93,116,214,126,165,124,219,242,33,125,246,182,70,10,111,190,198,236,8,52,186,40,9,66,178,240,14,147,136,241,209,179,240,28,215,208,89,150,235,206,226,18,8,182,40,148,33,205,98,207,14,72,53,100,234,194,5,6,87,69,128,37,52,168,95,164,166,227,233,243,2,130,250,142,68,16,252,154,245,47,92,205,218,86,63,66,192,216,25,27,203,106,131,91,248,17,144,158,188,99,242,246,100,227,10,254,102,170,156,184,25,148,95,94,233,37,249,10,67,208,34,89,142,45,18,31,126,130,237,48,77,138,176,36,179,5,58,68,174,228,190,15,41,59,57,140,14,106,96,40,125,71,189,254,23,228,89,197,102,135,243,207,234,209,107,20,115,209,121,45,165,119,61,108,163,54,172,207,195,69,220,203,121,78,63,89,131,142,139,249,73,128,240,13,139,45,251,133,253,23,177,180,60,220,78,198,105,79,16,3,59,174,75,184,92,159,219,144,214,227,97,33,83,105,114,230,77,178,152,249,249,63,211,37,236,48,39,242,164,238,166,66,92,163,197,6,24,83,191,122,199,138,85,64,39,192,247,23,35,249,78,148,206,168,9,10,7,155,229,198,255,233,33,222,36,106,97,79,81,231,251,10,91,54,222,233,161,214,135,53,66,121,120,175,224,234,235,119,249,33,159,219,135,201,152,144,59,114,199,242,63,218,229,174,148,229,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateAnalyticsTabScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e325b3bb-0aac-4c62-b8bb-247bcb0e3234"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"CreateAnalyticsTab",
				Position = new Point(273, 269),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,77,75,3,49,16,61,43,248,31,226,158,82,144,165,119,63,64,86,91,11,42,74,253,56,136,200,216,157,182,129,108,82,147,137,178,138,255,221,73,210,214,181,212,195,18,118,242,222,155,121,111,162,166,66,238,191,40,127,1,254,212,128,110,73,77,252,200,40,82,160,213,39,214,61,241,181,183,187,243,14,78,188,5,116,173,56,22,6,63,196,185,33,69,237,120,50,199,6,110,99,93,222,123,116,149,53,6,39,164,172,41,187,128,43,48,48,67,119,32,138,113,235,175,108,29,52,22,189,67,86,77,138,101,5,140,98,221,13,133,49,122,207,103,186,45,31,21,205,47,237,4,116,252,85,102,38,61,57,62,202,129,117,13,144,188,27,51,113,170,102,193,65,226,38,210,61,41,205,54,208,151,185,231,25,16,164,139,161,179,97,113,32,214,195,140,234,94,26,39,154,156,119,82,168,172,14,141,185,134,38,78,151,103,61,173,235,92,149,69,55,175,162,87,70,216,175,167,129,210,132,206,71,188,92,186,116,8,132,185,30,221,220,128,99,70,4,201,92,172,108,179,0,167,188,53,119,237,2,203,243,183,0,154,35,27,213,197,150,81,59,201,141,8,155,229,140,127,67,249,77,123,61,231,203,87,255,123,67,110,101,28,227,194,56,172,181,213,33,82,94,34,27,214,121,39,27,75,78,92,197,207,103,197,45,43,27,12,137,19,209,207,175,102,167,155,17,11,175,112,79,253,231,40,31,125,46,227,124,0,29,240,232,213,90,125,34,183,175,32,53,251,22,168,61,110,213,158,2,223,36,12,127,255,63,103,70,146,11,17,200,184,188,147,53,76,118,57,177,159,67,10,206,100,194,15,106,198,47,125,39,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrepareInitializeDetailsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bf162ea5-c8f1-46f8-a3d1-a427347ab298"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptPrepareInitializeDetails",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 371),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,77,10,194,48,16,133,247,61,69,78,208,11,20,87,218,69,22,150,64,189,192,104,166,58,48,78,37,153,80,234,233,13,244,7,5,179,26,222,227,123,195,215,225,100,133,148,128,233,141,39,84,32,142,117,63,199,243,232,19,163,245,230,96,190,82,83,117,255,248,229,94,224,234,64,144,243,196,193,29,215,54,110,117,97,107,101,121,222,122,210,188,28,128,35,22,80,7,1,69,179,78,43,74,58,247,183,7,62,97,83,252,237,138,162,3,36,214,227,200,12,175,136,190,160,90,239,64,83,5,212,20,196,104,72,89,235,3,136,1,194,36,46,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateNewInitializeDetailsUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7ee8d55b-3642-4e47-ba69-814fdc971182"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"NewInitializeDetails",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 371),
				SchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeNewInitializeDetailsParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrepareInitializePrimaryGridsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("efe19fd4-ef4a-472a-a77f-23930ca8c5b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptPrepareInitializePrimaryGrids",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,79,77,11,130,64,16,61,39,248,31,38,15,162,16,251,7,196,115,120,16,4,163,251,164,147,44,108,107,204,238,6,22,253,247,38,35,216,75,221,230,125,204,227,189,118,30,131,161,198,106,175,209,232,59,117,172,47,200,203,158,245,232,84,191,184,246,163,143,80,67,132,170,52,105,255,61,70,224,128,167,14,45,25,9,232,112,34,21,115,18,115,67,134,73,168,88,22,90,159,161,88,233,109,13,54,24,3,121,190,218,212,219,212,88,231,209,14,244,87,148,14,243,64,206,125,77,37,60,210,100,243,211,166,122,242,114,94,137,253,114,68,19,168,200,162,189,217,46,94,95,74,193,103,154,48,249,192,22,60,7,170,94,232,7,100,243,71,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateModuleInitializePrimaryGridsUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("60c5d1fe-e493-48c6-bf06-1c6639fc9093"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ModuleInitializePrimaryGrids",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 161),
				SchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeModuleInitializePrimaryGridsParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateChartTabScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1de8f7c8-5267-49f9-91cc-771f52be6d64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec87685-d967-4583-b0c5-d20b1eeee2fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"CreateChartTabScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 273),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,93,111,218,48,20,125,166,82,255,131,155,135,54,209,164,172,106,31,25,15,8,88,199,182,182,168,192,52,169,138,144,155,92,192,171,99,103,182,67,203,214,254,247,93,59,201,8,136,244,131,23,34,114,238,185,199,231,158,107,216,156,248,23,96,186,177,97,43,232,83,67,199,50,87,49,248,1,233,116,136,200,57,39,79,79,228,104,240,104,194,161,238,254,162,143,55,240,59,7,109,2,242,247,240,160,165,192,228,74,16,163,114,104,31,30,60,31,30,172,168,34,76,247,150,84,153,75,16,249,208,64,218,227,44,190,39,29,50,167,92,91,148,133,204,165,74,71,82,27,219,15,95,141,232,2,194,174,206,220,119,217,32,252,140,24,132,223,73,201,145,114,154,113,73,147,107,213,151,15,194,62,13,86,32,140,101,173,49,221,122,179,217,4,148,162,90,206,141,213,234,64,151,84,221,131,242,34,123,30,47,1,110,104,199,234,245,144,155,205,253,38,102,60,116,157,58,236,114,254,13,214,58,252,14,98,97,150,228,83,135,156,55,88,160,141,98,98,113,27,17,186,113,107,68,21,77,119,213,158,71,225,68,142,29,218,15,194,113,198,153,241,79,158,78,130,118,197,65,52,136,4,212,21,77,1,107,119,233,110,79,163,13,18,172,232,38,224,89,228,206,74,252,163,2,141,147,188,194,193,94,171,65,154,153,181,239,166,53,161,119,229,176,144,104,216,15,200,241,113,173,125,216,147,194,80,38,244,251,192,222,204,193,7,9,51,94,80,216,85,234,141,237,239,227,120,9,41,29,38,187,198,212,142,253,129,120,179,31,148,227,184,162,118,11,203,155,79,177,197,88,54,107,217,172,197,149,132,157,89,108,21,108,219,223,106,245,114,165,240,108,78,254,72,201,12,148,89,59,161,2,30,200,69,206,18,127,47,45,90,93,212,79,53,40,180,65,0,174,149,20,85,166,139,144,34,169,88,128,163,182,169,172,162,179,221,180,71,51,91,217,108,77,228,74,26,118,173,162,196,56,62,19,192,189,35,214,184,90,72,112,21,38,75,37,31,92,216,189,194,173,6,174,189,131,117,200,174,160,124,109,88,172,171,18,207,29,190,220,216,27,200,228,27,217,10,104,3,157,27,249,94,109,152,186,163,189,125,202,233,111,175,166,53,195,5,34,45,161,19,186,64,65,95,181,20,168,100,133,19,14,251,128,99,99,148,179,63,240,51,229,87,50,1,223,138,84,146,79,13,195,124,48,208,225,23,147,242,62,196,246,221,214,100,78,163,32,8,109,87,251,25,3,199,201,143,49,165,28,28,141,23,75,49,103,139,143,240,104,20,117,81,209,222,75,112,67,23,248,126,136,1,82,168,164,93,42,207,108,33,24,80,26,133,215,142,177,147,94,235,216,6,90,187,178,206,26,140,41,54,203,223,103,114,89,241,250,62,108,26,90,43,94,200,115,13,120,238,66,252,63,161,254,75,195,44,201,10,64,177,182,211,215,20,60,187,11,249,189,55,31,94,253,205,78,244,20,80,3,215,234,6,98,247,84,81,248,111,111,16,20,255,19,245,33,252,3,59,129,71,10,133,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("82767992-6396-4833-87ba-39357ae0fb1a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SubProcess2",
				Position = new Point(29, 971),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(232, 117),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateApplySearchFilterStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e7cef7ce-590f-47bb-9edb-f76ed34c8462"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82767992-6396-4833-87ba-39357ae0fb1a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ApplySearchFilter",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ApplySearchFilter",
				Position = new Point(28, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptApplySearchFilterScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("110dcbb5-6faa-43fa-881e-e77579cef33e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82767992-6396-4833-87ba-39357ae0fb1a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptApplySearchFilter",
				Position = new Point(126, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,44,40,200,169,116,203,204,41,73,45,42,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,212,13,199,246,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBasePrepareFilterActiveDataSourceSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBasePrepareFilterActiveDataSourceSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2ce54528-6241-4fba-a6c0-9b3a5fdadb7a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"BasePrepareFilterActiveDataSourceSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 1265),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(819, 504),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBasePrepareFilterActiveDataSourceSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBasePrepareActiveDataSourceFilterStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ac0bf2d1-368e-4214-a2ea-f254b638f8bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ce54528-6241-4fba-a6c0-9b3a5fdadb7a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"BasePrepareActiveDataSourceFilterStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptBasePrepareFiltersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d22eefbf-339a-4f62-a566-09366f91bbb8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ce54528-6241-4fba-a6c0-9b3a5fdadb7a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,77,111,227,32,16,61,187,82,255,3,201,161,178,165,136,63,80,245,208,186,105,21,105,213,68,235,118,123,38,54,78,88,217,224,5,92,201,90,229,191,239,0,254,14,73,247,18,37,48,188,247,230,205,48,100,47,68,129,210,90,74,202,117,162,137,166,9,37,50,61,190,176,66,83,137,30,80,78,10,69,239,111,111,190,136,68,148,147,125,113,45,32,35,154,36,162,150,41,133,141,87,170,31,83,205,190,232,115,191,26,70,109,160,210,178,78,117,45,77,220,112,8,199,157,142,118,23,162,223,169,148,68,137,92,227,143,13,254,164,251,88,112,45,69,161,112,255,101,128,119,154,98,81,20,20,136,5,71,185,93,80,64,194,235,162,0,180,97,97,196,250,194,120,230,142,170,87,41,234,234,169,121,35,37,13,151,227,68,151,70,57,203,81,216,33,44,28,102,132,254,222,222,4,215,252,115,241,120,163,214,214,189,12,112,130,62,125,220,242,226,159,180,20,95,180,67,55,100,39,195,23,46,32,148,241,3,28,127,3,182,173,92,151,149,110,66,199,177,147,172,36,178,121,102,170,42,72,3,105,215,37,255,69,138,154,70,78,149,183,92,192,76,91,9,128,139,200,172,66,113,193,32,145,77,6,145,59,114,232,244,173,51,166,71,62,111,108,18,243,253,132,234,81,165,7,127,77,50,193,96,252,144,123,44,41,248,53,118,126,230,249,10,253,16,7,150,146,98,91,81,73,76,69,161,51,88,170,241,86,90,80,211,73,149,199,4,83,190,105,137,147,244,72,75,130,125,142,97,19,109,208,186,238,41,43,34,153,18,252,189,169,40,74,39,63,173,187,35,247,166,187,64,185,132,22,144,250,147,233,227,210,132,5,166,99,62,148,65,229,188,237,201,73,227,4,129,216,255,134,13,164,108,222,177,159,205,225,12,55,33,22,198,61,193,115,118,168,157,47,56,105,20,248,175,65,148,194,239,178,129,187,103,79,207,200,87,22,44,8,150,137,213,239,12,72,60,212,96,189,168,175,168,138,208,221,29,186,188,61,79,50,56,51,106,205,235,18,131,74,123,211,52,172,137,60,116,162,44,192,20,51,90,161,144,113,29,93,150,227,92,58,153,79,243,225,169,26,112,134,190,10,71,86,201,142,72,213,235,240,134,173,102,197,30,119,53,126,204,178,208,223,215,166,21,0,28,178,52,129,225,89,75,174,144,209,236,209,187,186,216,217,238,200,183,35,192,63,103,140,210,233,144,217,207,31,128,217,76,207,251,27,110,175,232,255,141,206,97,44,244,131,115,113,113,72,66,43,205,73,166,253,51,87,55,13,158,140,214,46,33,101,98,227,35,225,7,106,102,217,85,242,112,130,15,212,227,128,22,186,203,98,140,235,212,121,130,129,112,12,233,100,229,112,105,73,122,68,225,96,42,98,28,157,149,200,161,194,232,111,235,100,231,211,96,72,111,150,93,199,235,63,53,212,106,254,86,1,70,96,140,107,35,123,131,64,216,249,163,96,26,229,132,40,84,220,185,237,57,180,240,159,10,134,7,209,169,124,128,9,56,46,125,123,253,61,136,103,75,144,151,199,201,251,238,70,159,172,135,79,68,209,157,164,21,4,118,239,134,253,75,33,41,56,200,221,219,246,15,24,64,160,101,209,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateLoadDynamicFolderFilterUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("38152366-49b4-4937-ab64-1e8329d9205e"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ce54528-6241-4fba-a6c0-9b3a5fdadb7a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"LoadDynamicFolderFilterUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(596, 215),
				SchemaUId = new Guid("a4208915-d4ec-42fb-933c-a23c511fe750"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeLoadDynamicFolderFilterUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPrepeareAnalyticsChartFiltersParamScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("34a366df-57cc-4224-bf1e-b98b1c4e11e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ce54528-6241-4fba-a6c0-9b3a5fdadb7a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptTaskPrepeareAnalyticsChartFiltersParam",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 322),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,75,110,194,48,16,93,7,137,59,152,172,28,41,202,5,16,11,196,167,202,162,45,18,180,123,215,76,193,170,107,71,227,9,52,173,122,247,142,147,168,136,2,181,108,203,178,223,204,251,120,90,85,182,89,26,75,128,97,233,113,234,148,53,100,116,144,217,120,56,48,175,66,142,2,161,113,187,162,12,15,181,181,143,184,120,175,168,145,17,215,68,220,108,175,144,86,106,7,51,239,72,25,7,88,206,179,76,124,37,195,65,114,80,40,244,197,187,152,136,120,70,111,159,200,68,50,8,197,210,184,109,127,41,35,184,56,171,200,197,191,116,185,32,172,33,19,42,8,38,141,227,12,192,62,146,104,228,138,146,209,68,56,54,197,114,99,97,103,84,4,64,195,33,124,194,182,143,133,5,223,1,77,53,153,3,204,21,169,181,175,81,195,250,47,172,77,44,57,153,254,165,89,161,215,16,98,155,75,9,173,209,210,5,82,78,179,235,14,217,246,185,218,163,88,3,241,177,2,164,230,89,217,26,100,122,210,113,239,183,181,133,94,77,154,95,26,233,4,198,44,102,123,208,111,109,150,27,245,210,57,147,89,31,195,13,230,205,30,253,113,113,0,71,242,58,160,116,204,193,255,20,31,224,131,114,145,206,81,29,91,146,180,99,254,230,141,23,79,4,170,209,181,255,54,254,1,26,147,160,227,130,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateLoadFiltersExclusiveGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("18390420-e227-43af-9614-1f417152eb6b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ce54528-6241-4fba-a6c0-9b3a5fdadb7a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"LoadFiltersExclusiveGateway",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(309, 105),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateLoadRecentFolderFilterUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("315a9d2d-af50-404d-94f3-925ce81a0d8b"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ce54528-6241-4fba-a6c0-9b3a5fdadb7a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"LoadRecentFolderFilterUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(371, 211),
				SchemaUId = new Guid("d45a14b3-7763-4005-9423-27a8bcebb6ef"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeLoadRecentFolderFilterUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateLoadDuplicatesFolderFilterUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("314ee1f8-9911-490a-b969-6d195cf8a333"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ce54528-6241-4fba-a6c0-9b3a5fdadb7a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"LoadDuplicatesFolderFilterUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(491, 215),
				SchemaUId = new Guid("1e3195d9-976c-421b-8570-5207023cf352"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeLoadDuplicatesFolderFilterUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChartMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChartMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e3222d9d-a8a6-4ded-babb-036f888b600a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"SubProcessChartMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(868, 1104),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChartMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChartMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("18357e04-bef8-4316-94b6-a41e9bc6380a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e3222d9d-a8a6-4ded-babb-036f888b600a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChartMenuItemClick",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"StartMessageChartMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChartMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d61b9529-fb07-469e-ad8d-48fe768395ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e3222d9d-a8a6-4ded-babb-036f888b600a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptChartMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,91,111,218,48,20,126,78,165,254,7,55,15,107,162,49,107,221,246,134,250,64,233,69,72,189,105,208,237,161,170,38,147,28,192,147,107,103,182,83,202,40,255,125,199,118,2,164,165,180,67,66,36,246,57,223,247,157,43,67,165,4,225,230,18,166,3,54,36,135,228,198,128,238,42,41,33,179,92,73,250,29,254,148,96,236,49,179,236,54,238,78,152,182,104,214,213,192,44,228,241,29,217,59,36,178,20,162,189,187,195,71,36,217,51,86,115,57,166,61,115,137,135,87,250,228,190,176,179,164,246,234,89,184,239,10,14,210,246,142,83,242,225,3,73,150,180,79,79,111,241,202,49,120,156,21,103,154,146,249,238,78,20,40,137,69,85,172,112,174,24,195,25,120,149,225,61,233,150,90,35,169,119,175,206,82,20,28,61,48,237,220,174,153,4,129,78,215,108,12,244,76,243,124,80,157,173,217,224,117,109,73,241,218,220,54,222,104,87,149,210,126,58,184,115,30,120,67,87,74,86,178,106,52,227,192,36,76,73,223,11,63,42,185,200,65,39,75,69,5,115,98,131,107,125,214,207,52,47,236,5,147,40,81,215,82,59,166,240,191,167,92,230,152,56,171,149,72,226,134,101,156,18,102,200,0,180,102,70,141,44,189,233,209,159,48,172,108,157,234,234,161,225,228,56,93,45,235,218,132,44,71,65,22,61,3,9,26,107,31,92,18,51,108,145,17,19,6,90,77,141,62,154,69,133,84,69,196,223,35,197,61,48,142,28,72,27,69,142,248,74,44,11,82,53,79,190,94,141,186,161,28,33,178,61,151,93,23,48,168,11,142,24,132,13,110,200,134,237,83,102,86,233,36,132,129,111,144,98,243,21,130,101,144,196,191,42,120,201,109,220,34,85,119,251,174,94,51,178,19,110,40,94,199,83,172,132,154,210,56,109,71,75,110,134,237,252,128,9,11,195,21,59,252,216,107,141,204,144,118,138,2,100,126,142,241,38,21,246,169,210,247,204,38,241,252,203,98,254,121,65,185,196,169,176,201,252,235,162,53,63,192,239,183,69,218,70,166,23,209,183,170,182,89,59,88,6,221,34,158,206,127,94,56,146,143,36,166,28,7,211,80,1,114,108,39,136,190,38,57,245,133,244,149,124,67,47,138,53,80,143,87,178,143,106,247,107,169,77,81,245,4,6,228,247,128,118,156,30,167,38,65,84,7,186,33,252,141,243,248,94,142,92,157,179,153,42,109,226,21,63,203,100,0,89,68,171,85,99,234,94,66,224,129,10,99,28,230,183,49,3,216,32,99,110,44,232,35,24,41,13,171,78,58,154,117,126,179,199,122,130,252,207,182,102,114,200,139,109,251,181,35,153,152,89,158,25,191,225,220,78,88,78,145,147,191,190,37,71,92,160,32,19,86,100,200,171,219,176,125,85,234,12,250,160,57,19,252,47,228,167,193,108,181,148,216,235,20,136,85,77,239,141,229,130,91,14,166,177,146,252,142,106,120,180,200,86,197,88,76,55,132,110,117,53,110,94,209,162,85,6,198,69,180,69,163,231,239,225,172,51,153,161,152,224,226,240,54,98,209,62,184,199,2,39,111,246,131,137,18,171,178,74,205,133,202,75,1,85,130,176,78,85,70,211,255,65,11,24,39,210,114,59,235,103,19,184,103,189,28,161,250,51,211,60,219,2,58,152,104,53,61,121,192,142,74,54,27,244,36,202,194,27,151,3,120,196,37,16,31,107,54,13,127,161,85,71,105,176,165,150,62,219,237,127,15,128,128,213,6,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseModulePageLoadEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseModulePageLoad = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9489c54c-18d1-4677-901d-e1717e919ba4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"BaseModulePageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(799, 607),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(243, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseModulePageLoad;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageBaseModulePageLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2ec3cc6f-1752-42e1-9d98-2cda0a26c735"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9489c54c-18d1-4677-901d-e1717e919ba4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"StartMessageBaseModulePageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskBaseModulePageLoadScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bfee0893-f2d6-46bc-bb5c-042b58079f4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9489c54c-18d1-4677-901d-e1717e919ba4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptTaskBaseModulePageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,110,194,48,16,60,131,196,63,24,14,85,162,86,249,129,138,67,129,242,144,218,10,53,109,239,171,120,3,145,28,27,57,54,85,84,241,239,245,35,36,134,66,219,155,189,187,158,217,25,207,30,36,161,160,32,21,90,102,72,198,100,129,234,33,83,197,30,103,109,53,138,239,7,253,34,39,209,112,13,27,76,166,186,82,162,76,17,100,182,157,10,174,160,224,40,147,101,65,41,114,114,115,67,126,25,178,173,21,175,20,112,195,53,28,19,174,25,139,201,215,160,223,251,231,163,100,45,69,134,85,149,164,168,204,113,135,82,213,31,192,52,70,163,55,144,27,84,221,214,163,187,64,152,85,112,24,244,247,70,173,146,136,11,89,80,163,213,145,218,115,50,47,56,181,55,203,42,5,155,212,47,80,90,204,102,118,20,19,168,200,241,214,184,209,1,133,66,36,42,45,185,97,209,232,57,237,104,224,112,163,218,26,21,250,62,110,247,74,58,9,30,177,109,152,175,121,21,159,102,197,188,216,44,129,83,134,210,127,216,179,160,154,97,219,51,188,189,14,59,121,18,64,145,146,219,51,10,95,238,124,201,5,163,40,103,97,22,156,63,19,168,112,238,122,215,92,10,60,119,62,61,114,85,168,186,171,54,126,253,32,56,9,64,183,66,154,109,177,4,67,127,254,32,241,29,43,175,195,59,78,135,88,61,147,142,25,230,160,89,99,205,26,164,217,84,161,172,92,150,123,142,109,231,163,116,65,231,165,196,185,103,187,171,233,243,154,253,50,239,43,106,194,231,177,206,234,241,31,48,83,48,147,43,133,165,117,214,128,152,207,61,41,69,105,93,121,73,6,203,129,29,220,7,134,169,251,6,187,96,86,214,211,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5fe7ab42-9378-4186-8838-83c8f9e10284"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("133407be-5b5b-4603-87ee-9d50ad492a96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1120, 1104),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(214, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateReportMenuItemClickEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cc7e71ef-202a-432b-baa0-dea8efd17219"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5fe7ab42-9378-4186-8838-83c8f9e10284"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ReportMenuItemClick",
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ReportMenuItemClickEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2b598d0f-e35f-4bc2-b692-c6648f906d25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5fe7ab42-9378-4186-8838-83c8f9e10284"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,79,75,195,64,16,197,207,230,83,12,57,37,88,22,212,99,255,64,73,85,10,34,210,181,39,41,178,102,199,186,146,236,150,217,73,75,21,191,187,155,164,74,168,233,205,211,194,236,252,222,219,55,179,230,21,146,172,34,66,203,11,220,56,98,153,191,97,169,150,115,13,227,49,220,86,70,139,235,114,195,251,20,62,163,51,66,174,200,2,83,133,195,232,43,218,42,130,53,25,45,177,192,156,81,79,115,54,91,92,184,157,135,128,34,255,173,39,41,40,15,119,198,243,168,150,158,12,27,13,127,232,59,144,22,119,48,51,129,113,86,209,126,228,153,140,93,15,192,189,188,135,174,9,36,105,75,105,197,74,186,138,114,108,221,90,151,217,111,181,238,235,42,139,169,214,73,60,103,44,47,226,65,135,22,109,98,113,175,74,60,137,92,246,34,193,245,129,76,25,94,153,185,162,42,109,45,145,164,39,69,174,130,72,255,188,2,178,244,72,153,179,22,155,224,66,162,247,225,172,227,60,245,239,71,60,58,217,140,38,12,245,28,226,103,137,100,84,97,62,80,223,152,130,145,124,188,250,89,195,209,69,242,63,118,199,33,26,191,110,242,97,212,253,48,223,233,29,196,200,106,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateAnalytiscGridPageTabItemMethod());
			Methods.Add(CreateCreateAnalyticsGridPageContainerMethod());
			Methods.Add(CreateGetSelectedActiveRowsMethod());
			Methods.Add(CreateGetActiveDataSourceMethod());
			Methods.Add(CreateGetFolderInfoMethod());
			Methods.Add(CreateSelectFolderMethod());
			Methods.Add(CreateSaveFolderFiltersMethod());
			Methods.Add(CreateLoadFolderFiltersMethod());
			Methods.Add(CreateApplyFiltersMethod());
			Methods.Add(CreateBaseApplyModuleFiltersMethod());
			Methods.Add(CreateBaseApplyGlobalSearchFilterMethod());
			Methods.Add(CreateGetModuleRowConfigMethod());
			Methods.Add(CreateApplyFiltersForAnaliticsMethod());
			Methods.Add(CreateSetMoveToFiltersMethod());
			Methods.Add(CreateGetRequestStringParametersMethod());
			Methods.Add(CreateSetDefaultModuleParametersMethod());
			Methods.Add(CreateGetSchemaUIdByNameMethod());
			Methods.Add(CreateBasePrepeareFiltersMethod());
			Methods.Add(CreateGetTabCaptionMethod());
			Methods.Add(CreateCheckChartTabActiveMethod());
			Methods.Add(CreateGetGridSelectedValueMethod());
			Methods.Add(CreateDisplayDetailsTabPanelMethod());
			Methods.Add(CreateOnTabPanelChangedMethod());
			Methods.Add(CreateGetSerialzedFiltersMethod());
			Methods.Add(CreateApplyMultiFolderEntryFilterMethod());
			Methods.Add(CreateApplySingleFolderEntryFilterMethod());
			Methods.Add(CreateGetSerializedFiltersMethod());
			Methods.Add(CreateSetProcessExtraParametersMethod());
			Methods.Add(CreateGetDuplicatesSchemaNameMethod());
			Methods.Add(CreateSetPageKeyShortcutsMethod());
			Methods.Add(CreateGetCacheItemNameMethod());
			Methods.Add(CreateSetCustomFilterDetailsMethod());
			Methods.Add(CreateCreateAnalyticsChartPageContainerInTabMethod());
			Methods.Add(CreateGetActiveDataSourceSerializedFiltersMethod());
			Methods.Add(CreateCreateOrRecreateChartTabMethod());
			Methods.Add(CreateShowErrorMessageMethod());
			Methods.Add(CreateOnPageLoadComleteMethod());
			Methods.Add(CreateCreateAnalyticsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a8d2abf8-07ab-4e55-8690-1a75dfa0f6da"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d6630e4d-7a19-48f1-9051-b7afb4319d94"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9eaf8c85-25b4-4106-b135-2ce7c11e0517"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80e9a624-774f-4aa9-bdc1-372108d985e1"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("66c04ada-c3e9-49ab-83a7-051f50d29d99"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f1f380c2-17a6-4748-871a-be4cb513b6b0"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cafacd03-d1a2-43da-8fb1-db3dc13351a7"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8a52f61f-eae7-4d4d-8095-62319ae446eb"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f54c9c05-732e-45af-939f-13fc737c792b"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdc1f75a-bdaa-4bb9-913e-3e80b88105af"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7e624e1a-9617-4102-957b-d7222d4aa9d1"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateCreateAnalytiscGridPageTabItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6b55b5b0-9983-4839-ac30-513892a11d39"),
				Name = "CreateAnalytiscGridPageTabItem",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.Tab"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,204,75,204,169,44,201,76,46,118,47,202,76,9,72,76,79,13,73,76,242,44,73,205,85,176,85,200,75,45,87,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,214,131,51,128,234,53,52,173,185,56,113,25,4,212,152,2,52,204,189,52,51,69,207,47,181,28,68,227,87,239,151,152,155,10,212,224,8,147,7,138,131,132,240,105,113,77,73,79,45,6,234,81,82,194,167,202,51,23,200,129,250,11,234,124,136,80,117,45,62,109,206,137,5,37,153,249,121,104,78,130,138,2,53,22,165,150,148,22,229,225,12,72,107,46,0,153,178,168,37,103,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAnalyticsGridPageContainerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5f30a815-379e-427f-bf5e-c36cb0e0be02"),
				Name = "CreateAnalyticsGridPageContainer",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.PageContainer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,61,11,194,48,16,134,103,253,21,165,147,14,13,74,43,86,196,201,65,93,68,80,113,190,230,46,109,160,77,225,26,21,17,255,187,137,138,224,160,5,167,203,125,60,47,247,146,59,1,7,96,160,188,88,45,155,5,107,220,64,78,243,218,88,208,134,56,152,5,134,206,193,142,152,161,169,149,21,251,149,56,80,230,251,92,151,141,120,63,62,168,94,127,218,237,124,23,117,34,232,132,23,71,141,98,77,103,31,219,136,53,84,228,144,240,251,72,248,91,96,94,54,158,111,153,242,217,86,22,84,193,115,69,239,253,177,94,152,37,99,24,97,60,137,38,41,97,148,160,146,81,170,18,25,101,9,142,80,41,136,83,25,135,45,38,150,164,243,194,58,217,189,209,86,108,136,37,185,86,78,189,225,96,208,130,30,52,218,226,47,114,85,185,244,101,229,245,91,207,210,245,230,64,38,123,100,243,227,0,166,221,59,229,163,182,15,33,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSelectedActiveRowsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5df39cd5-caf5-4867-847d-01c60ba74568"),
				Name = "GetSelectedActiveRows",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,205,10,194,48,16,132,207,205,83,172,151,146,94,250,2,181,66,81,40,130,7,177,224,61,36,43,6,210,4,54,73,139,72,223,221,250,71,11,246,226,109,15,243,205,236,76,39,8,60,26,148,1,85,37,131,238,240,228,122,15,37,88,236,225,160,125,88,215,81,171,13,207,10,182,19,65,52,46,146,68,80,211,89,66,141,225,77,78,130,167,92,95,128,207,116,171,209,50,26,3,105,58,163,243,230,19,189,15,216,30,73,183,130,110,91,103,98,107,207,194,68,244,95,42,131,59,75,46,142,80,200,43,240,110,252,89,47,2,160,237,31,238,47,215,228,183,125,94,41,197,151,3,198,94,201,192,6,70,24,34,217,133,229,138,7,246,112,62,191,81,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActiveDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a995fb0f-4fa3-41b7-acb0-3a287c68d80f"),
				Name = "GetActiveDataSource",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,77,79,194,64,16,61,151,132,255,176,244,64,218,131,155,120,70,76,16,212,52,38,166,17,208,3,225,48,45,83,92,45,91,220,221,18,136,225,191,187,67,11,5,4,52,105,187,253,120,51,239,189,121,219,5,40,54,135,41,178,54,11,237,194,59,122,78,43,3,205,6,168,20,232,44,49,124,24,240,55,140,186,153,52,42,75,53,39,64,171,94,19,210,176,9,26,16,169,30,64,20,130,196,180,19,27,177,64,251,20,200,9,46,183,61,31,149,152,108,17,252,16,66,109,18,230,145,2,62,212,24,170,44,17,41,178,102,147,53,206,210,223,47,13,15,116,231,3,150,47,248,149,163,54,62,251,174,215,156,5,57,41,234,123,96,192,146,111,186,134,213,171,214,33,42,48,56,35,84,5,24,253,150,219,77,5,74,19,244,198,84,188,145,186,87,220,104,51,153,167,105,193,127,252,149,191,66,106,213,113,210,13,66,234,39,92,121,46,108,220,27,136,4,185,119,253,178,212,249,107,142,118,214,118,236,74,227,9,134,209,113,215,49,31,100,125,163,132,156,122,190,79,186,157,181,189,216,211,30,228,176,156,36,139,203,181,112,81,70,113,89,201,45,187,186,166,116,46,163,110,78,228,110,111,104,22,185,44,227,170,200,79,99,71,23,41,198,252,193,122,221,51,115,183,122,134,25,122,46,197,216,207,114,21,163,75,214,215,172,112,181,99,219,79,44,201,20,66,252,206,60,218,20,118,122,118,202,103,196,148,49,85,154,45,250,159,10,138,125,177,173,60,220,49,78,100,5,124,30,37,164,208,228,74,238,194,177,63,98,213,177,245,3,172,39,241,170,175,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFolderInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4234e375-b3c7-433c-a0a1-540fc9b4ff83"),
				Name = "GetFolderInfo",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object[]"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,61,111,194,48,16,134,103,144,248,15,86,38,71,66,22,59,45,82,73,9,98,104,69,69,63,6,196,224,146,163,184,114,108,122,177,169,34,196,127,175,19,7,154,4,6,70,223,189,239,227,251,218,115,36,27,45,19,192,197,122,11,41,39,247,132,206,249,23,176,49,207,32,46,19,44,22,42,41,98,145,86,6,181,28,231,207,60,5,26,60,114,195,23,218,226,26,130,144,240,140,252,191,67,230,97,195,94,119,239,248,41,87,206,141,14,253,150,1,58,138,130,181,17,90,177,41,24,47,124,242,10,26,76,148,17,38,111,4,61,252,74,162,162,67,45,243,98,1,115,247,143,130,223,134,163,140,211,170,142,126,163,97,86,52,19,86,172,29,138,148,99,30,105,105,83,229,56,23,108,246,144,36,62,75,131,89,18,156,124,30,248,154,239,224,54,107,124,214,179,26,37,3,142,235,109,49,198,219,40,139,179,190,68,92,106,99,33,13,96,86,120,232,101,54,66,224,6,188,230,67,152,237,156,163,27,69,97,160,189,110,199,199,35,157,238,56,138,76,171,178,216,201,143,229,178,53,63,183,196,121,125,108,229,113,132,125,226,123,156,37,97,88,95,148,128,236,106,91,142,226,23,230,32,210,159,7,109,94,75,129,17,27,66,79,24,22,105,171,12,25,145,65,72,14,174,96,4,99,81,149,171,215,159,223,206,179,92,145,195,249,211,229,96,85,252,81,116,81,205,239,157,75,11,119,83,43,146,17,109,239,207,31,69,159,56,108,167,69,168,153,105,123,97,222,118,116,133,30,123,221,83,61,86,202,225,31,50,20,21,214,102,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSelectFolderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("466257f5-2a33-4280-82cd-5f8e20f21901"),
				Name = "SelectFolder",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,42,74,45,41,45,202,179,6,0,216,153,159,154,8,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveFolderFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("baaaf94c-ff25-4734-92c1-4a5e1816690e"),
				Name = "SaveFolderFilters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateLoadFolderFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3ee20b6b-958f-4dd8-befa-64e51f9ddb0c"),
				Name = "LoadFolderFilters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateApplyFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("848c24ab-7656-460e-b6c1-1bfbb75dfbd4"),
				Name = "ApplyFilters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,207,10,130,64,16,198,207,237,83,140,30,68,47,190,128,120,8,139,8,34,162,122,129,65,39,91,176,217,88,199,245,16,189,123,43,66,110,135,174,51,223,159,223,231,208,66,131,130,23,51,216,154,160,132,29,201,186,22,237,104,243,189,166,89,161,244,13,210,80,87,2,15,93,151,193,75,173,44,201,96,185,80,111,229,124,216,19,91,170,12,11,106,38,235,243,22,83,126,196,135,230,118,121,98,15,167,80,61,183,252,6,68,115,17,36,201,111,114,62,57,247,220,11,178,199,137,2,156,255,178,252,122,183,102,220,58,98,73,227,170,35,180,211,198,56,155,208,3,204,131,193,230,108,198,222,207,254,0,186,188,81,19,30,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseApplyModuleFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fa028ebf-0da1-46d5-9595-be14d055487a"),
				Name = "BaseApplyModuleFilters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,46,207,44,73,206,80,208,112,203,207,73,73,45,42,246,205,79,73,213,84,168,230,226,76,78,44,78,85,80,242,45,205,41,201,132,72,185,230,149,20,85,42,41,88,113,113,114,58,22,20,228,84,162,75,185,101,230,148,164,22,105,104,90,3,21,36,21,165,38,102,91,195,12,9,206,204,75,207,73,197,110,10,134,28,22,99,106,1,155,195,205,40,164,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseApplyGlobalSearchFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("92966fcb-0e00-415e-99c6-6a92494eb064"),
				Name = "BaseApplyGlobalSearchFilter",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,205,110,194,48,12,62,183,79,145,113,42,82,149,23,64,59,176,242,35,164,9,208,202,198,217,107,93,136,148,38,149,147,86,170,38,222,125,9,133,22,1,211,78,173,236,239,199,159,157,6,136,229,96,33,213,53,101,200,94,217,18,237,52,179,162,193,89,95,141,198,147,176,113,184,138,68,9,212,206,132,169,36,180,137,150,117,169,214,80,122,214,32,193,211,236,136,37,240,237,19,48,247,232,78,203,88,170,51,91,211,29,57,169,137,80,217,244,218,157,132,59,36,2,163,11,203,63,87,124,143,223,137,86,150,180,52,188,255,25,6,93,8,105,145,156,151,68,23,65,43,86,156,11,198,121,168,90,202,73,40,138,200,25,11,117,224,43,179,118,149,13,205,203,202,182,81,138,64,217,241,217,200,95,32,107,28,143,217,79,24,220,139,157,24,74,131,190,227,3,105,153,47,122,64,159,142,95,106,238,171,242,183,214,231,143,70,157,91,215,25,185,221,6,162,96,209,13,255,165,115,56,155,6,143,82,31,88,234,6,111,8,94,226,116,59,223,192,73,8,193,94,246,98,150,164,235,234,206,62,102,239,250,32,50,144,155,10,9,252,210,220,238,69,102,249,134,188,236,69,147,79,243,60,122,174,186,23,246,184,5,114,193,60,48,122,120,8,49,27,46,152,104,71,158,43,43,172,64,195,175,215,42,43,32,97,180,218,181,21,158,175,10,66,197,97,240,231,115,139,217,191,231,114,199,249,5,215,208,249,23,217,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModuleRowConfigMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("608ab1da-bcf8-445c-9b21-e984f2b7d029"),
				Name = "GetModuleRowConfig",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceRowConfig"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6c613368-497f-40de-a816-154745198a54"),
				Name = "module",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,205,14,194,32,16,132,239,125,10,226,169,189,240,2,141,7,127,162,55,211,88,227,197,120,216,20,68,146,2,102,1,141,49,190,187,180,69,75,82,143,236,238,124,195,140,117,40,181,32,55,148,10,240,185,50,173,87,122,7,138,147,57,81,134,249,150,211,186,185,114,5,180,74,47,104,119,82,102,246,143,248,8,173,79,212,91,238,146,121,62,241,41,232,193,212,61,38,47,202,236,14,72,26,163,47,82,4,130,230,15,178,6,7,181,241,216,240,189,121,172,250,77,62,181,139,74,246,59,14,234,10,68,112,71,201,232,70,106,214,189,130,220,161,105,151,207,206,55,159,141,232,89,65,192,38,86,3,205,246,185,99,23,35,250,219,71,218,192,233,76,24,130,56,128,176,241,223,191,249,107,196,188,75,146,13,225,232,130,177,24,102,18,114,29,65,195,126,104,237,11,47,66,80,228,206,163,142,45,149,31,96,109,98,197,191,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateApplyFiltersForAnaliticsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b1a408b2-bc8f-4d90-8c3c-8052beac43ac"),
				Name = "ApplyFiltersForAnalitics",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,145,207,106,195,48,12,198,207,241,83,184,57,197,48,252,2,161,135,238,79,187,94,74,33,108,119,97,107,171,192,117,134,172,20,210,209,119,159,147,182,41,133,237,180,147,205,207,159,190,79,146,233,67,87,179,87,72,139,8,161,23,114,201,232,111,85,48,74,199,177,86,39,117,0,214,30,4,154,182,99,135,122,174,87,40,11,39,116,192,231,137,86,166,30,117,112,245,216,194,39,62,181,81,128,34,114,174,169,6,160,33,233,225,108,220,14,247,240,150,144,7,9,183,193,216,59,189,93,82,244,87,146,159,31,251,13,236,177,42,39,247,21,147,191,171,40,141,86,69,113,177,159,104,173,40,207,246,71,79,179,185,142,93,8,227,176,191,75,198,166,214,49,9,68,135,118,203,173,195,148,108,131,146,175,95,200,210,191,67,232,114,91,13,50,65,160,35,250,37,5,65,78,229,195,176,163,51,190,209,202,228,37,253,51,234,37,10,73,127,217,223,218,231,160,219,207,216,51,182,153,231,160,211,15,252,238,196,254,215,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetMoveToFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d35a44c2-c0de-4cab-be14-bba7efa301a1"),
				Name = "SetMoveToFilters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,65,110,219,48,16,60,75,175,96,115,162,0,131,31,16,114,112,101,215,53,80,36,46,220,164,103,134,90,199,68,41,82,89,145,9,132,198,127,239,82,148,227,88,169,11,244,36,104,119,103,56,220,225,232,29,223,84,247,98,249,20,164,233,248,42,232,90,44,155,214,247,5,123,125,101,157,71,109,31,197,186,187,9,198,220,226,208,224,155,197,125,81,176,223,121,134,224,3,90,182,35,32,148,249,33,167,6,187,102,47,240,32,190,122,223,222,121,109,180,239,197,29,154,5,40,87,195,0,44,243,103,137,76,42,175,159,97,33,189,220,186,128,10,8,182,2,63,159,84,249,56,173,2,34,88,191,245,24,20,157,24,167,167,4,162,154,204,36,164,133,151,47,218,120,64,130,76,89,68,133,32,61,164,254,79,237,247,27,137,178,1,250,233,248,7,250,173,218,67,35,103,44,77,87,174,105,37,234,206,217,31,125,11,105,119,179,143,154,18,72,108,80,55,18,251,202,153,208,88,113,67,103,204,24,173,188,40,217,160,241,41,104,245,235,178,202,212,233,232,107,235,207,125,68,243,171,239,39,200,21,237,72,239,248,25,201,53,179,100,215,96,209,73,205,81,185,49,64,58,29,217,150,136,89,154,46,243,236,84,248,231,170,186,21,186,208,158,139,152,177,111,238,81,43,105,110,91,64,25,233,9,171,149,23,115,91,23,101,246,198,45,230,117,205,223,76,33,233,217,197,251,198,73,190,158,234,95,123,104,138,163,116,194,31,24,3,122,125,241,170,103,59,144,29,187,124,245,66,84,6,36,198,231,245,95,168,169,248,67,158,239,28,109,70,237,25,143,78,38,89,76,219,139,46,14,158,144,93,127,205,85,130,15,15,100,8,223,167,119,133,99,62,207,173,39,58,218,237,184,92,98,91,90,249,96,160,38,7,199,76,102,135,24,203,42,198,242,148,236,114,12,234,40,98,172,141,97,38,197,80,254,1,16,69,110,47,20,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRequestStringParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0649decc-a8f4-4fc5-9eba-be9a7bb5d159"),
				Name = "GetRequestStringParameters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,8,112,14,211,115,45,44,77,204,41,214,112,47,205,76,209,115,205,45,40,169,212,84,80,83,83,80,40,46,41,202,204,75,215,243,44,246,43,205,201,241,47,2,203,104,4,184,132,105,106,42,84,115,113,2,53,42,216,42,4,36,166,167,234,185,167,150,4,36,22,37,230,166,150,164,22,133,37,230,148,166,106,40,21,36,151,41,105,42,40,218,42,228,1,245,42,216,43,228,165,150,43,128,204,215,192,171,65,47,36,63,24,108,169,6,208,14,43,5,132,131,172,129,246,185,224,181,47,5,213,62,188,234,144,172,1,218,2,97,194,236,169,5,0,102,186,58,152,20,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetDefaultModuleParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3f3c008c-4cdb-4269-be63-4b480286df72"),
				Name = "SetDefaultModuleParameters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,109,107,219,48,16,254,236,66,255,131,234,15,67,102,193,244,243,178,6,218,172,47,129,166,203,150,102,251,48,198,80,99,185,17,179,173,76,146,219,153,182,255,125,39,201,241,171,218,4,246,194,66,192,88,58,61,247,220,221,115,39,179,24,225,121,33,167,60,202,19,58,137,208,209,17,58,207,89,20,158,166,107,85,4,232,97,127,207,187,35,2,209,76,49,85,204,151,43,154,146,41,201,200,45,21,232,8,205,224,25,218,197,176,181,55,19,252,142,69,84,132,231,84,149,75,216,63,237,99,248,1,34,18,93,83,33,136,228,177,10,199,92,208,208,216,49,42,67,199,129,161,131,207,135,156,138,2,216,100,244,30,157,118,215,177,131,249,0,249,85,200,126,80,66,122,107,193,82,34,138,49,79,242,52,187,34,41,5,200,158,155,240,56,138,172,5,238,239,125,228,92,149,217,128,184,103,93,60,28,4,161,126,106,135,253,195,103,44,81,84,72,237,192,1,61,22,148,40,106,109,62,51,181,154,17,1,72,250,0,182,139,99,158,174,137,96,146,103,215,197,26,114,248,35,39,201,0,28,121,158,142,85,23,202,194,45,38,145,63,104,21,14,86,130,96,232,53,19,11,201,119,6,15,81,217,4,67,80,9,93,42,198,51,188,144,218,121,150,217,87,147,77,6,154,218,224,64,73,243,76,161,17,58,180,98,242,90,98,171,220,125,57,252,170,209,53,247,50,191,159,72,146,211,183,90,139,35,220,43,141,113,243,180,191,7,127,237,204,132,115,73,99,5,68,148,224,201,37,41,120,174,194,11,22,69,52,179,126,5,85,185,200,134,213,145,38,141,131,166,230,209,171,87,8,159,241,4,212,11,177,138,162,169,168,69,183,65,208,227,35,170,108,95,54,3,135,77,155,94,171,213,189,22,27,192,49,143,104,75,139,190,117,4,172,105,168,55,125,87,47,212,189,217,174,139,78,110,203,226,133,118,252,119,109,231,208,57,129,151,62,251,57,149,18,158,102,55,212,250,191,228,75,146,232,87,150,221,98,169,4,60,194,51,46,82,162,240,245,28,14,198,236,54,23,196,156,53,135,22,138,37,86,143,214,255,59,162,136,217,56,23,60,95,15,80,67,14,65,224,138,118,82,202,114,203,80,168,35,180,41,9,59,101,215,237,87,225,215,133,158,86,197,222,130,239,210,70,133,183,34,242,216,228,75,238,60,196,252,139,234,140,95,79,167,94,57,55,51,102,211,245,40,182,211,202,137,94,78,50,13,20,255,173,161,86,254,124,51,205,122,197,123,70,87,19,69,211,50,39,109,201,212,85,179,61,54,201,98,254,237,225,240,169,131,61,252,131,51,210,18,104,72,64,119,248,21,207,186,109,93,242,157,91,190,102,84,236,50,98,187,163,102,199,65,235,82,124,88,105,172,223,20,144,208,78,18,202,94,215,62,244,238,73,1,138,199,85,201,126,151,133,165,209,202,76,151,79,37,98,175,149,219,109,158,109,61,70,216,213,147,141,12,212,237,2,152,7,219,64,111,56,79,70,216,213,150,155,11,204,179,130,211,26,211,44,107,239,155,34,151,66,157,200,171,60,73,222,11,35,0,92,39,160,188,54,234,235,205,128,214,195,101,158,199,49,251,89,223,30,126,123,246,152,27,174,182,153,100,13,43,121,207,212,114,133,26,25,41,125,45,137,164,48,202,129,214,166,95,12,140,255,198,148,89,147,222,225,74,44,177,60,239,25,91,84,93,88,240,122,98,98,109,132,141,94,183,226,179,181,49,161,123,222,13,76,149,239,195,154,232,52,79,20,251,15,121,182,8,108,249,206,232,179,112,28,216,145,74,163,230,27,62,158,51,113,102,26,217,100,189,248,129,5,158,149,200,109,207,213,32,250,235,236,23,185,74,142,114,93,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaUIdByNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9b796c6e-0cc9-4366-87dd-39c08bea9c8d"),
				Name = "GetSchemaUIdByName",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("470b475d-15de-4660-aabd-45fef83c8fbc"),
				Name = "schemaName",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,193,14,130,48,16,68,207,246,43,86,78,112,233,15,144,94,52,72,56,232,133,240,1,13,172,184,9,44,166,221,154,16,227,191,43,33,49,37,122,157,153,221,153,71,87,72,125,123,195,209,94,236,136,96,12,212,226,136,123,93,140,119,153,51,120,170,157,67,9,142,161,12,212,173,106,174,94,234,97,29,172,119,103,203,182,71,7,6,26,143,238,56,49,99,43,52,177,46,81,234,56,145,38,5,11,201,188,17,147,12,172,135,63,70,30,85,124,126,111,186,244,137,184,171,216,139,229,22,15,243,178,60,130,200,114,69,95,42,216,27,224,48,12,49,201,234,232,166,234,22,146,95,188,55,138,214,143,108,20,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBasePrepeareFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b1200f9e-9362-4b0e-b2ec-93e73183aada"),
				Name = "BasePrepeareFilters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,203,110,219,56,20,93,59,64,254,129,241,34,144,128,90,144,18,197,15,4,94,216,146,29,4,72,211,162,78,167,139,193,44,104,137,182,133,145,69,143,68,101,96,76,243,239,115,73,74,34,245,48,154,166,105,2,24,178,120,121,120,238,185,47,58,218,32,99,69,216,71,250,76,158,232,50,138,25,73,51,195,52,209,127,231,103,189,148,176,60,77,110,207,207,94,206,207,86,4,167,193,110,73,227,144,164,104,138,54,56,206,8,172,220,103,95,72,64,18,214,177,224,231,135,56,10,48,35,89,107,209,199,12,175,104,158,6,4,133,234,113,138,238,8,155,5,44,122,38,202,192,48,193,254,25,167,40,200,211,20,14,90,177,52,15,128,22,55,87,123,45,175,177,10,155,214,148,198,40,202,238,98,186,198,177,164,175,81,216,208,148,224,96,103,112,232,141,112,27,69,73,235,16,171,80,68,234,17,109,12,67,218,90,143,120,79,208,197,20,37,121,28,155,232,242,18,105,239,173,197,63,57,156,98,244,11,205,196,74,95,88,149,219,239,179,69,130,215,49,9,209,116,138,224,48,82,40,222,107,241,229,139,64,183,247,34,162,0,12,46,234,38,114,223,28,103,100,118,56,196,199,143,52,204,99,82,197,241,86,176,70,134,140,192,125,200,41,223,229,81,104,45,246,7,118,44,206,20,18,72,131,100,67,101,24,150,213,119,9,210,227,187,80,120,76,240,62,10,228,226,211,241,64,0,17,52,32,255,10,80,163,63,188,241,102,246,196,29,14,108,123,236,14,220,241,200,29,204,29,103,52,240,156,107,103,50,153,45,175,231,147,155,190,134,151,106,185,211,1,231,217,206,114,57,119,221,193,200,181,71,131,133,237,56,131,217,16,208,157,161,63,190,246,102,115,123,50,182,107,112,148,178,197,30,71,177,66,252,218,100,72,174,174,55,248,106,56,184,89,19,50,32,28,18,143,135,107,32,236,220,220,132,182,27,216,78,168,67,134,141,36,238,96,233,216,163,137,235,78,220,129,127,229,251,146,229,228,202,187,150,144,190,237,130,23,126,1,201,67,161,41,93,228,15,79,140,11,127,254,8,143,214,31,56,206,171,4,82,166,127,218,127,201,44,171,222,88,15,36,217,178,93,105,122,85,38,144,22,205,14,255,107,136,214,19,133,68,143,146,45,212,187,160,39,248,25,141,205,211,174,168,155,232,251,119,212,182,236,14,0,167,6,224,226,4,141,222,42,216,145,61,6,118,198,103,188,37,22,79,97,185,13,138,46,9,249,59,143,38,44,165,241,252,200,171,202,232,171,166,0,197,132,51,164,190,155,150,4,187,85,103,4,52,206,247,137,116,95,63,207,242,196,66,102,65,146,151,192,178,146,56,92,223,180,96,75,1,243,64,113,232,235,190,203,178,250,154,129,103,56,251,219,242,95,211,186,94,3,180,98,148,135,97,145,176,136,29,37,205,54,239,215,243,42,224,60,77,129,74,141,159,131,248,156,70,123,156,30,37,146,72,77,192,42,123,73,1,213,24,12,101,191,234,245,94,16,129,86,139,160,101,181,243,164,85,247,101,246,10,102,250,72,121,171,230,173,193,212,65,172,145,193,101,45,117,215,188,89,163,216,28,110,191,148,26,63,192,170,150,159,248,200,16,147,71,128,170,5,153,34,34,153,149,255,29,243,87,211,128,127,138,15,161,133,244,236,87,178,66,77,149,219,18,186,208,89,96,191,31,116,57,8,161,83,93,212,114,143,119,209,21,195,172,60,65,246,40,47,6,27,121,216,34,140,88,49,25,185,113,205,86,6,87,93,6,184,45,176,136,9,4,142,38,188,130,78,220,12,68,179,42,27,137,58,7,58,148,144,20,218,212,19,73,83,156,209,13,131,18,182,190,145,117,209,213,50,171,122,80,121,33,1,212,193,229,252,238,36,85,93,63,132,194,93,38,214,3,221,66,10,196,159,14,36,197,133,35,205,87,124,4,4,204,154,37,178,160,59,97,180,235,138,202,161,19,150,143,148,105,215,172,19,102,34,42,50,87,121,166,232,161,80,71,20,97,190,168,151,178,121,126,86,134,170,104,35,13,205,126,46,88,18,186,12,151,252,123,151,160,25,39,216,149,81,3,35,17,183,110,179,134,66,74,138,102,85,171,196,85,109,235,173,90,40,236,190,249,238,114,116,210,107,138,209,101,212,45,133,94,250,82,131,70,18,85,25,168,138,90,174,189,65,29,173,99,253,134,76,41,203,187,69,175,171,192,155,70,109,117,244,31,75,191,229,138,37,126,88,5,56,225,53,253,41,245,118,56,217,18,254,172,137,206,157,170,115,168,249,34,138,55,218,238,216,3,121,38,49,236,227,115,0,168,36,133,79,254,124,69,96,59,220,134,22,201,54,74,8,191,172,233,183,35,40,90,154,134,95,42,4,163,177,191,248,53,200,223,90,247,225,135,186,28,31,170,27,140,89,166,71,80,249,32,48,129,80,247,57,16,84,233,54,223,88,202,80,19,64,247,106,218,196,213,119,21,246,134,182,225,178,105,111,158,192,232,214,222,40,81,97,236,213,104,153,178,151,138,20,88,97,254,59,31,2,158,51,6,66,169,182,110,116,129,182,70,42,32,157,24,168,42,246,229,255,255,223,149,4,240,90,16,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetTabCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f07bfd74-4bbb-4e1b-acee-4ede6e18a3c0"),
				Name = "GetTabCaption",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b2a1b76d-fab4-43dc-9767-1ff129db04d2"),
				Name = "caption",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,189,14,130,48,20,133,103,250,20,55,44,148,84,27,212,193,161,214,133,184,185,225,102,28,80,249,105,162,133,148,11,198,24,222,221,10,36,130,166,73,211,220,123,206,119,78,155,216,0,198,231,48,46,81,21,26,36,92,250,151,32,42,5,250,221,240,125,162,51,204,97,11,171,192,135,23,113,26,107,124,20,230,90,89,207,72,22,213,231,10,141,210,25,13,102,176,92,251,60,42,111,10,169,7,158,47,136,51,73,138,58,29,223,221,75,124,218,93,90,24,160,74,35,40,25,8,80,27,218,209,135,220,249,194,183,51,198,186,232,49,134,73,112,237,97,125,151,163,58,89,82,75,156,105,121,144,211,180,63,138,28,236,193,233,239,3,31,30,144,223,72,206,185,43,72,75,76,130,181,209,16,230,177,193,8,237,117,24,233,134,102,95,171,120,3,48,100,71,174,110,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckChartTabActiveMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0719f99f-2385-49b4-9a19-f8c325a21e0a"),
				Name = "CheckChartTabActive",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,141,177,14,130,64,12,134,103,121,138,142,176,220,11,16,7,115,26,195,162,12,110,198,161,74,193,75,142,98,122,133,104,196,119,247,28,112,129,169,205,215,191,223,63,160,0,222,212,13,116,194,171,245,142,88,139,45,172,161,196,134,204,94,92,21,113,137,76,222,196,37,156,231,120,51,61,23,92,209,243,98,38,71,158,184,26,210,160,226,184,49,69,56,244,222,31,101,215,62,244,149,206,250,50,24,71,88,140,218,59,138,254,228,74,237,63,157,193,59,89,9,105,47,12,53,250,64,121,242,1,138,51,114,152,14,179,18,99,59,86,116,28,150,165,209,241,5,124,233,146,12,12,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetGridSelectedValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3f01a6a3-aeab-43c7-ad12-52c7215f623b"),
				Name = "GetGridSelectedValue",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,143,177,10,195,48,16,67,231,230,43,142,76,201,226,15,104,48,29,74,49,93,130,161,208,221,216,71,9,216,231,112,62,23,252,247,77,66,151,238,221,36,132,158,208,219,49,20,140,232,5,195,211,197,138,160,193,186,23,42,195,75,80,187,186,83,17,71,30,149,229,236,177,20,101,80,54,185,34,75,59,26,67,255,248,2,230,28,208,242,146,28,183,107,142,53,209,145,247,35,104,13,84,99,132,11,152,186,97,111,105,149,6,103,232,78,195,238,199,191,15,78,29,163,84,166,223,107,211,7,159,200,224,219,237,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisplayDetailsTabPanelMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fff99bdc-9ced-4a22-ac33-f3ec0f92ce07"),
				Name = "DisplayDetailsTabPanel",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bae0dc4c-e732-4c41-a7a9-7d8067500b20"),
				Name = "show",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,73,45,73,204,204,41,14,73,76,10,72,204,75,205,81,176,85,8,72,76,79,213,115,65,21,182,230,202,76,83,208,64,83,171,7,100,20,235,57,231,151,230,149,40,216,41,24,104,42,84,115,113,234,235,163,155,168,231,145,153,146,146,154,7,52,88,177,56,35,191,220,154,171,22,0,114,182,66,65,119,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnTabPanelChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aba1a4ce-04fd-416b-9f55-021a0c80cbe3"),
				Name = "OnTabPanelChanged",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("821c9a08-0972-4a2e-b90c-b10284abb262"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eff46d66-103f-4bd2-ba30-8a9e024b3cc5"),
				Name = "e",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,142,177,14,194,32,16,134,103,121,138,115,131,165,47,64,58,52,237,226,98,28,186,25,135,19,207,148,136,196,0,109,108,172,239,46,40,212,237,238,255,191,251,114,61,158,15,104,201,64,200,131,100,250,10,124,203,61,217,11,57,208,30,250,220,8,1,47,182,113,20,70,103,37,123,179,114,1,53,100,24,255,176,100,19,186,36,221,227,157,34,81,224,42,2,254,184,110,141,10,122,162,152,237,162,224,121,170,18,45,89,167,253,195,224,220,81,64,109,124,81,198,167,86,95,13,141,69,51,7,173,82,253,205,150,5,218,129,212,173,29,208,133,24,254,212,92,8,33,63,181,201,249,65,229,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSerialzedFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0b002498-b589-4e52-a941-47e028775c17"),
				Name = "GetSerialzedFilters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,65,10,194,48,16,69,247,158,34,203,20,74,46,80,92,72,69,193,109,241,0,33,126,33,82,38,48,153,164,224,233,29,141,216,186,156,225,189,255,127,245,108,110,94,252,148,10,7,152,189,57,67,14,65,98,197,241,247,181,221,176,171,202,221,227,44,96,101,86,193,141,133,25,36,147,112,9,82,24,238,244,129,114,51,30,57,209,152,168,130,155,72,88,204,154,251,69,47,91,200,94,51,88,47,130,142,72,212,111,186,116,5,67,59,200,188,13,55,129,163,159,227,19,182,237,234,255,219,186,225,5,15,197,190,73,219,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateApplyMultiFolderEntryFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1f6b2b38-0838-427a-a7e5-5d6016f2ada4"),
				Name = "ApplyMultiFolderEntryFilter",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,91,111,218,48,20,126,78,165,254,7,147,135,42,145,192,130,149,94,88,213,7,160,80,33,117,85,5,237,246,80,241,96,37,7,26,45,113,152,227,176,69,45,255,125,199,54,9,166,148,170,155,182,151,196,151,239,220,190,243,249,44,153,32,33,147,108,146,230,34,0,114,73,174,65,118,3,25,45,225,170,58,245,252,139,195,131,104,70,60,27,120,73,120,30,199,62,121,62,60,112,4,200,92,112,4,173,14,15,150,232,112,193,230,48,226,153,100,92,187,180,236,232,45,75,34,62,239,167,92,178,136,131,32,44,35,119,136,174,14,124,122,103,25,175,227,214,70,217,56,77,229,48,141,67,52,57,58,34,102,53,10,73,13,19,206,163,144,14,146,133,44,54,55,3,46,69,129,159,72,22,147,224,9,18,246,240,26,107,18,87,201,206,140,47,62,75,77,245,195,106,175,235,118,148,13,9,11,142,137,7,230,238,190,88,0,250,67,6,224,167,118,233,185,167,39,253,110,179,211,62,109,52,155,231,237,70,251,252,172,221,232,181,90,103,141,126,235,184,213,233,116,135,199,189,206,137,171,221,169,122,236,144,134,71,242,242,66,174,122,183,184,162,95,89,156,3,29,252,200,89,156,89,200,199,230,212,87,168,218,230,136,222,0,159,203,167,18,251,73,221,99,4,167,230,85,137,109,217,211,251,116,34,5,210,239,249,190,95,90,189,81,153,111,200,113,70,134,187,47,140,99,75,196,72,66,178,38,107,135,94,228,66,183,145,62,100,32,176,151,28,80,66,41,167,72,231,150,15,207,181,173,214,135,174,79,85,52,7,193,42,70,175,192,102,121,251,251,232,43,205,236,166,166,184,181,250,249,42,59,75,129,230,76,195,39,32,175,0,117,23,15,163,88,130,160,230,135,18,85,170,117,77,10,230,204,125,7,127,3,51,57,248,181,16,144,101,88,115,182,214,5,201,52,213,143,83,162,139,123,54,91,138,228,4,76,234,6,85,128,103,226,62,186,245,125,220,170,39,3,117,226,126,70,200,110,29,229,237,148,154,116,169,91,215,241,118,89,160,119,34,74,152,40,250,105,156,39,92,219,173,252,213,59,117,141,163,249,147,212,106,196,146,202,23,87,209,140,251,205,132,176,169,218,102,187,159,11,1,92,162,238,242,0,135,4,172,125,103,248,231,97,175,80,89,120,219,76,235,87,162,159,201,254,16,53,123,250,56,206,71,226,141,33,73,151,176,223,167,9,187,114,42,25,149,197,188,38,167,47,128,73,48,27,107,178,213,223,124,0,223,82,241,61,91,48,76,108,20,190,137,48,97,63,82,64,55,196,231,108,165,106,15,89,236,109,26,160,254,40,38,139,203,5,8,89,232,206,121,238,4,98,140,4,97,217,64,84,81,185,212,126,86,122,106,43,186,237,33,107,152,253,251,16,214,160,189,88,207,217,255,43,152,63,209,203,63,147,139,226,238,55,20,228,86,198,65,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateApplySingleFolderEntryFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4af9de19-29d1-4fb8-be20-39bb3a534ba1"),
				Name = "ApplySingleFolderEntryFilter",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,77,111,226,48,16,61,7,137,255,96,56,84,137,84,44,216,210,15,84,113,224,115,133,84,85,8,218,221,67,213,131,149,76,32,218,96,179,142,67,23,181,252,247,29,219,33,184,21,172,186,210,238,37,241,199,155,153,55,239,217,222,48,73,34,166,216,92,228,50,4,210,37,95,65,245,66,149,108,96,88,174,250,193,109,181,146,196,196,119,129,93,194,243,52,13,200,107,181,226,73,80,185,228,8,218,85,43,27,76,184,102,11,152,240,76,49,110,82,58,113,244,158,173,18,190,24,8,174,88,194,65,18,150,145,41,162,203,133,128,78,157,224,162,110,109,146,205,132,80,99,145,70,24,114,118,70,236,104,18,145,26,18,206,147,136,142,86,107,181,181,100,52,129,216,238,243,88,216,142,198,229,220,244,226,233,24,18,109,57,146,9,237,222,195,118,13,152,15,187,130,23,147,210,175,95,93,14,122,205,78,251,170,209,108,222,180,27,237,155,235,118,163,223,106,93,55,6,173,139,86,167,211,27,95,244,59,151,117,147,78,115,116,75,90,109,200,219,27,25,246,239,113,68,191,177,52,7,58,250,153,179,52,115,144,79,205,231,64,163,106,135,37,122,7,124,161,150,123,236,23,187,239,151,172,222,5,211,7,49,87,18,245,244,131,32,216,135,28,105,43,176,202,120,153,1,23,234,12,68,154,175,56,250,161,45,178,59,86,70,221,145,23,11,9,44,92,18,95,203,25,26,40,73,184,115,84,232,60,92,194,138,81,155,38,43,42,24,41,44,156,206,32,6,9,232,162,69,62,106,121,187,133,117,35,174,18,181,45,55,246,209,222,17,106,69,54,61,51,204,188,157,254,154,207,28,212,16,240,220,164,227,36,85,32,169,253,21,113,117,91,201,174,213,111,79,227,239,32,86,163,95,107,9,89,150,8,158,21,103,160,144,228,233,153,188,126,36,181,251,67,178,89,178,88,42,99,55,233,150,199,212,224,181,144,56,63,92,43,151,31,130,29,105,7,185,68,225,20,122,155,135,120,179,160,200,157,225,159,71,253,173,230,224,191,111,207,28,67,35,254,233,18,53,247,202,122,222,103,234,205,96,37,54,112,58,167,45,187,219,183,23,239,123,249,168,205,0,15,147,2,59,113,94,131,115,115,247,233,99,166,213,229,28,240,221,17,156,126,23,242,71,182,102,200,107,18,29,69,216,170,159,225,223,139,240,198,56,76,221,135,137,78,165,8,209,115,138,100,113,184,6,169,182,198,56,191,62,135,20,43,65,180,247,175,126,94,90,105,242,236,204,75,167,213,118,31,166,195,243,243,127,109,254,27,151,255,153,201,186,229,223,188,20,131,46,44,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSerializedFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("76468a43-5119-4628-9ca2-3bc324cf2365"),
				Name = "GetSerializedFilters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,77,10,194,48,16,133,247,130,119,200,50,133,146,11,148,46,164,162,224,54,120,128,16,159,16,41,19,152,76,34,120,122,211,31,108,93,206,240,125,239,189,226,88,61,156,56,27,51,123,168,94,93,33,39,47,161,224,252,251,234,166,59,30,74,5,159,97,20,112,133,54,195,12,153,25,36,86,56,123,201,12,115,153,161,180,42,175,20,105,136,84,192,139,73,120,171,45,121,101,111,123,72,223,19,184,94,132,58,35,82,187,43,155,118,48,106,11,169,73,49,22,28,220,24,62,208,203,178,246,191,174,233,190,171,202,203,76,222,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetProcessExtraParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f416c7fe-3124-4682-b276-872bd8602c4e"),
				Name = "SetProcessExtraParameters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c0946a8c-a6c8-42f7-a4e1-99ea21b2bded"),
				Name = "moduleProcess",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6a085512-7d42-47fc-8960-e18906b7f036"),
				Name = "processSchema",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateGetDuplicatesSchemaNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7ff8771f-4277-47db-9125-a132267a2a80"),
				Name = "GetDuplicatesSchemaName",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetPageKeyShortcutsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0feb1981-e01c-4f15-a948-aa2ac79121c1"),
				Name = "SetPageKeyShortcuts",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("07a01c8b-dc7e-406f-9f35-12ff97fefe66"),
				Name = "gridInstance",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.WebApp.BaseGridPageSchemaUserControl",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,147,81,79,194,48,16,199,159,199,167,56,121,128,46,89,22,197,55,22,162,32,35,33,26,99,132,47,208,173,7,52,204,110,105,11,72,96,223,221,142,201,214,5,196,183,246,255,191,187,254,122,237,41,45,185,88,2,101,108,180,209,58,21,47,9,71,161,167,99,24,192,82,114,54,21,74,83,17,163,63,60,7,248,231,136,160,165,202,92,100,92,223,78,14,171,136,203,108,134,9,106,188,157,63,182,98,172,10,179,83,133,209,134,39,12,37,168,200,164,9,220,65,67,38,110,208,114,84,228,15,179,12,5,155,164,242,139,106,242,220,14,191,181,191,68,61,78,99,226,250,169,32,197,158,171,105,8,199,35,148,235,25,93,80,201,31,225,9,186,107,220,179,116,39,186,208,63,173,51,137,74,117,61,88,108,68,172,185,73,70,23,14,135,150,227,56,91,42,235,78,26,154,195,125,30,156,245,186,75,133,241,80,27,118,3,10,171,87,91,230,48,163,96,65,250,138,123,115,21,40,28,190,0,130,62,77,10,13,6,131,1,104,185,169,16,28,181,227,58,94,1,49,185,149,230,196,84,161,169,51,125,159,133,159,243,126,169,153,58,164,130,245,81,208,40,65,6,157,14,220,213,234,138,51,134,194,5,83,168,190,152,191,224,18,195,173,121,4,210,141,19,30,175,77,47,42,211,3,52,152,121,254,123,70,36,145,174,131,6,196,164,103,1,212,93,105,16,88,178,141,96,201,87,24,106,247,127,136,113,248,22,206,67,11,196,126,133,6,74,195,176,97,26,198,21,28,219,255,27,168,212,242,188,120,217,60,119,131,182,119,57,139,222,149,17,243,174,14,142,249,236,31,116,121,154,214,89,44,121,166,137,249,250,243,180,156,8,226,186,193,15,219,30,148,179,239,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCacheItemNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7f091955-935d-4a72-88d2-893848a53873"),
				Name = "GetCacheItemName",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0a554223-5d0a-4b7e-89bc-e8a0d743e1ff"),
				Name = "sysModuleId",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,203,47,202,77,44,209,80,10,174,44,246,205,79,41,205,73,117,203,207,73,73,45,242,204,75,203,143,175,54,168,85,210,81,40,134,201,120,166,104,90,3,0,109,182,62,148,61,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetCustomFilterDetailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3a64e330-e6d3-40f0-84ca-567556f07ac0"),
				Name = "SetCustomFilterDetails",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,46,45,46,201,207,13,78,77,44,74,206,112,206,207,43,73,204,204,75,45,210,11,0,74,121,230,21,151,36,230,37,167,234,5,20,229,39,167,22,23,235,5,167,150,0,153,5,169,69,37,149,97,137,57,165,169,26,74,62,153,197,37,169,64,245,32,229,161,158,41,74,58,10,32,22,92,3,204,4,160,148,166,53,0,191,244,106,215,110,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAnalyticsChartPageContainerInTabMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bf5c8181-88f0-4ebf-b55d-5e00b7a03ab0"),
				Name = "CreateAnalyticsChartPageContainerInTab",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("24f0641b-b5c7-460c-acfa-a5dd94f9d8dd"),
				Name = "chartTab",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Tab",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d6a8aa2a-3a70-4e99-8497-6c79936163f1"),
				Name = "createdByAjax",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,193,110,218,64,16,61,195,87,172,124,178,213,96,153,132,52,68,40,7,48,33,177,68,35,90,160,57,47,246,0,91,153,93,180,30,147,184,85,254,189,179,216,24,98,66,168,212,19,120,246,205,123,111,223,140,189,225,154,113,201,227,12,69,152,248,75,174,113,196,23,48,14,151,176,226,65,196,238,152,132,23,246,144,138,200,182,90,237,193,109,203,191,246,26,237,235,155,219,70,171,233,13,26,221,222,205,215,198,85,223,247,154,237,75,239,254,178,127,101,57,157,250,134,40,35,142,124,172,82,29,2,81,60,0,118,67,20,27,232,151,85,187,192,45,180,136,140,224,189,68,129,89,46,251,61,5,157,21,202,71,117,123,207,236,230,229,115,76,3,17,35,232,196,87,113,12,228,66,73,162,62,32,241,83,173,65,226,24,117,26,98,170,193,45,240,238,68,157,160,218,51,217,39,69,201,212,201,179,82,161,27,69,167,25,142,108,23,247,164,84,124,37,145,11,9,186,8,201,244,151,53,147,236,33,198,157,110,199,104,70,232,62,193,203,118,148,85,136,175,129,35,68,189,172,251,139,191,18,56,60,124,174,96,247,235,145,19,159,94,158,74,227,35,136,197,18,169,99,156,37,8,43,247,25,102,228,205,252,24,140,86,113,226,78,165,64,119,4,52,22,106,90,128,221,244,188,170,213,103,17,225,242,127,73,158,248,202,236,101,104,28,79,248,204,245,99,65,224,160,207,190,124,114,29,90,8,90,18,33,23,182,227,254,128,117,204,105,139,173,134,117,193,44,203,161,179,161,122,201,195,239,30,49,148,194,164,112,199,142,156,116,234,115,69,129,135,75,219,204,55,204,239,193,132,124,143,220,221,207,97,127,234,53,49,103,118,9,76,216,4,180,230,137,154,99,53,139,253,255,109,91,205,182,255,5,90,48,59,231,246,162,246,86,127,171,151,33,6,50,1,141,1,77,197,246,46,222,121,47,54,119,166,16,213,106,200,51,149,98,53,135,129,144,209,46,42,146,238,101,38,24,219,234,29,180,88,14,227,9,43,0,121,41,231,93,107,21,66,146,84,41,13,29,121,66,46,233,45,31,229,152,78,189,0,187,99,64,170,173,201,113,246,147,199,41,105,229,227,42,106,65,68,131,45,62,13,149,3,231,51,146,161,160,181,36,117,35,94,104,78,183,92,166,176,115,225,238,108,77,207,176,209,146,127,83,81,26,195,150,226,224,169,186,208,31,221,245,3,190,32,49,45,240,138,143,16,175,123,41,101,43,3,122,91,4,143,197,111,48,18,115,30,39,224,116,254,2,141,61,30,78,21,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActiveDataSourceSerializedFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("253e8c3d-4eec-4bd8-9199-99ae9981e131"),
				Name = "GetActiveDataSourceSerializedFilters",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,206,65,10,2,49,12,5,208,189,167,200,178,3,67,47,48,184,144,17,5,183,197,3,148,250,23,149,33,133,52,173,48,167,55,130,56,227,50,159,151,159,244,40,244,136,26,67,105,146,64,71,186,66,79,73,115,199,249,151,186,97,58,116,115,207,90,120,46,220,33,10,49,202,120,209,166,46,121,177,184,222,246,200,221,43,196,38,134,85,22,30,119,167,172,83,160,77,152,62,27,62,64,114,92,242,10,183,17,63,55,17,176,6,149,150,140,194,127,111,140,255,175,12,211,27,74,161,76,6,198,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateOrRecreateChartTabMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5c06afdd-1f44-4dd1-9027-56e8aba6d98b"),
				Name = "CreateOrRecreateChartTab",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a6bfb423-7e24-4956-9266-64dcbe33ab5f"),
				Name = "createNew",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,144,65,107,194,64,16,133,207,17,252,15,203,158,18,148,253,3,226,65,34,132,92,68,218,72,15,165,148,53,25,237,194,118,211,206,78,148,34,249,239,157,221,68,123,41,20,47,61,37,153,188,247,230,205,119,210,40,72,239,183,218,129,21,75,177,213,71,80,5,154,166,26,103,139,233,196,28,68,90,35,104,130,13,156,51,113,153,78,146,252,77,35,177,164,36,120,207,173,1,71,229,154,221,146,94,165,152,221,242,20,15,103,66,198,89,209,153,70,177,63,60,211,76,85,237,35,161,113,199,84,110,100,198,59,146,19,247,168,199,84,78,114,112,22,21,32,106,223,30,72,237,74,245,4,251,188,117,132,173,245,234,246,194,218,52,187,36,108,79,226,254,223,106,205,195,223,92,127,144,105,29,75,10,8,130,241,59,205,59,68,86,69,223,56,203,88,223,135,70,183,43,88,239,213,170,105,210,107,191,88,56,143,68,86,78,219,47,50,181,143,17,129,94,40,167,141,3,44,93,168,119,245,204,5,97,7,209,25,120,238,60,32,43,29,212,97,167,122,128,207,14,60,173,53,233,103,121,189,98,216,208,200,23,177,100,32,157,181,3,251,228,78,111,92,188,72,2,165,126,58,233,5,88,15,49,40,32,111,109,115,55,240,161,197,127,0,31,218,221,131,123,112,204,197,65,243,149,209,248,7,45,199,17,33,235,135,20,51,250,6,219,149,213,181,21,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowErrorMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("46207f63-cf5e-471c-800c-d8b3b5fcb00c"),
				Name = "ShowErrorMessage",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ff83637d-19b3-4fe0-b188-da0498006cd1"),
				Name = "errorMessage",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,49,11,194,48,16,133,231,230,87,156,157,18,8,193,189,116,168,130,91,161,131,226,32,14,129,156,229,32,38,37,151,14,34,254,119,69,34,196,233,113,223,123,247,222,136,204,118,198,201,6,244,112,175,143,30,246,49,228,20,253,41,147,167,76,200,230,64,193,21,40,69,51,125,162,102,224,229,171,5,243,101,123,213,208,238,44,227,88,149,181,26,114,90,81,129,101,168,121,39,232,6,242,111,118,211,67,88,189,87,240,20,77,109,152,193,185,242,42,207,54,5,10,179,6,76,41,166,66,245,175,249,248,88,208,148,136,234,196,235,13,218,118,193,1,227,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnPageLoadComleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("58a92dad-7efb-4fcf-b6c6-74039e35774a"),
				Name = "OnPageLoadComlete",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("63b5aa6b-ea73-407a-9e76-ee28b436c854"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,77,111,219,48,12,61,59,191,66,245,201,6,54,163,189,46,11,134,44,105,59,99,109,81,52,233,118,40,122,80,108,166,209,160,72,153,68,183,205,138,254,247,233,195,118,100,111,9,114,139,69,242,145,143,124,100,216,146,36,39,183,244,9,178,73,165,81,174,103,64,85,177,154,72,129,148,9,80,217,55,86,150,32,82,242,54,136,102,128,222,231,130,113,4,53,5,227,194,117,146,14,7,209,1,0,107,202,133,70,42,10,200,230,43,37,95,206,159,65,96,18,231,130,33,163,156,253,129,216,64,188,15,152,169,228,252,21,179,92,143,127,209,215,59,248,93,129,70,151,88,1,86,74,16,84,21,52,142,46,225,165,98,101,7,159,140,70,68,84,156,187,168,214,101,78,23,53,13,50,106,65,158,169,34,79,198,184,11,37,123,48,169,38,115,80,138,106,185,196,236,39,44,198,155,77,246,149,106,176,158,214,113,86,172,96,77,239,53,40,75,90,73,62,116,224,37,69,58,147,149,114,208,151,128,227,2,217,51,76,219,87,219,55,203,164,83,196,73,80,127,104,200,110,149,44,64,235,204,204,192,252,220,128,194,237,15,202,43,72,226,43,166,17,76,163,109,41,181,215,125,94,198,31,60,157,38,174,1,50,166,116,24,185,89,90,251,119,216,206,86,82,97,81,161,238,84,210,78,228,66,242,18,148,190,150,165,171,46,190,145,194,204,203,214,103,73,110,60,124,211,60,219,22,31,208,29,123,93,133,17,202,102,47,143,115,129,12,183,117,51,29,1,143,212,123,79,15,130,132,205,168,91,112,124,192,145,221,59,4,151,235,235,138,35,243,149,183,20,124,247,140,54,227,192,106,120,169,109,220,46,207,190,214,29,216,24,2,92,3,177,67,10,180,22,42,104,247,156,93,73,90,222,201,23,183,173,94,252,165,95,95,179,28,183,84,0,111,70,56,237,62,91,141,38,61,215,204,252,208,217,68,86,2,45,169,83,159,171,231,227,229,110,62,115,81,194,171,65,255,120,102,168,182,171,219,75,211,238,231,136,44,169,97,229,32,163,131,158,245,38,71,239,81,212,180,226,237,168,4,54,238,24,124,87,136,77,80,55,140,246,25,253,239,192,124,33,103,228,19,57,245,39,192,232,100,201,184,219,121,227,158,36,187,51,114,159,219,75,82,223,11,237,38,158,58,184,177,222,184,15,43,189,38,214,223,137,16,44,28,114,144,168,225,144,35,172,77,194,32,226,33,172,213,243,156,112,102,68,149,79,31,237,57,8,18,116,64,194,68,251,156,50,167,125,43,8,119,242,181,185,41,73,236,155,133,116,193,108,179,226,212,35,68,255,244,48,97,2,211,132,75,241,148,30,192,126,232,227,61,218,189,49,163,223,77,199,152,116,111,38,59,177,14,7,11,41,57,209,43,249,82,143,187,213,143,37,213,171,234,179,3,243,2,119,117,119,227,78,18,107,126,232,6,61,102,55,116,237,118,124,44,40,223,34,43,172,162,236,155,91,184,41,211,27,78,183,61,173,37,1,176,113,11,255,230,254,2,130,44,152,42,151,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAnalyticsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1b27633d-2df4-47d1-ab69-fa075c3e7a31"),
				Name = "CreateAnalytics",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9db35bfb-a1e8-48c4-9261-63e87a8caada"),
				Name = "hasAnalytics",
				CreatedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				ModifiedInSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,193,74,196,48,16,134,207,10,190,67,216,83,23,151,224,93,246,80,138,104,65,177,176,174,247,217,100,220,141,196,169,100,178,171,69,124,119,167,105,83,138,222,188,37,51,223,255,229,135,184,23,85,28,128,75,2,223,69,103,120,169,190,46,206,207,78,16,212,62,56,251,4,187,6,8,189,90,171,6,246,168,111,103,179,235,145,139,176,147,117,21,16,34,142,26,54,61,216,39,4,174,35,190,21,203,76,155,150,34,56,194,240,59,99,56,103,170,140,12,41,241,235,154,24,67,76,166,171,213,164,72,235,121,77,93,190,194,231,205,9,41,178,150,89,117,0,146,210,105,160,46,215,138,240,67,77,196,29,144,245,242,198,35,229,244,128,219,191,86,57,176,46,173,45,164,74,218,78,13,116,223,87,202,69,32,131,186,9,173,65,102,189,193,40,199,119,105,220,61,131,63,98,177,216,116,252,208,218,163,199,218,46,86,106,118,251,159,238,222,113,68,225,123,124,164,182,201,156,62,41,231,178,104,59,60,243,253,3,56,223,241,95,235,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseModulePageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d43b969-e278-4e8a-932c-446176483d1b"));
		}

		#endregion

	}

	#endregion

}

