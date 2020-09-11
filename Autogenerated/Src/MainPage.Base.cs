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
	using System.IO;
	using System.Linq;
	using System.Net;
	using System.Text;
	using System.Web;
	using System.Web.UI.HtmlControls;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Sync;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: MainPage_Base_TerrasoftSchema

	/// <exclude/>
	public class MainPage_Base_TerrasoftSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _topControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TopControlLayout {
			get {
				return _topControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _topLeftControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TopLeftControlLayout {
			get {
				return _topLeftControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _logoControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout LogoControlLayout {
			get {
				return _logoControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ImageBox _imageBox1;
		public Terrasoft.UI.WebControls.Controls.ImageBox ImageBox1 {
			get {
				return _imageBox1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _navigationControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout NavigationControlLayout {
			get {
				return _navigationControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _navigationButtonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout NavigationButtonsControlLayout {
			get {
				return _navigationButtonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addButton;
		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return _addButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _unreadEmailCountButton;
		public Terrasoft.UI.WebControls.Controls.Button UnreadEmailCountButton {
			get {
				return _unreadEmailCountButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _newRemindingsCountButton;
		public Terrasoft.UI.WebControls.Controls.Button NewRemindingsCountButton {
			get {
				return _newRemindingsCountButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _runProcessButton;
		public Terrasoft.UI.WebControls.Controls.Button RunProcessButton {
			get {
				return _runProcessButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _topRightControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TopRightControlLayout {
			get {
				return _topRightControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MultiLevelTabs _multiLevelTabs;
		public Terrasoft.UI.WebControls.Controls.MultiLevelTabs MultiLevelTabs {
			get {
				return _multiLevelTabs;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _searchEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SearchEdit {
			get {
				return _searchEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _clearToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ClearToolButton {
			get {
				return _clearToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _modulesToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ModulesToolButton {
			get {
				return _modulesToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _searchToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton SearchToolButton {
			get {
				return _searchToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _settingsButton;
		public Terrasoft.UI.WebControls.Controls.Button SettingsButton {
			get {
				return _settingsButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _userSettingsButton;
		public Terrasoft.UI.WebControls.Controls.Button UserSettingsButton {
			get {
				return _userSettingsButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _openContextHelp;
		public Terrasoft.UI.WebControls.Controls.MenuItem OpenContextHelp {
			get {
				return _openContextHelp;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _openModuleHelp;
		public Terrasoft.UI.WebControls.Controls.MenuItem OpenModuleHelp {
			get {
				return _openModuleHelp;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _showWelcomeScreen;
		public Terrasoft.UI.WebControls.Controls.MenuItem ShowWelcomeScreen {
			get {
				return _showWelcomeScreen;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _exitButton;
		public Terrasoft.UI.WebControls.Controls.Button ExitButton {
			get {
				return _exitButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ImageList _navigationControlsImageList;
		public Terrasoft.UI.WebControls.Controls.ImageList NavigationControlsImageList {
			get {
				return _navigationControlsImageList;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _contentControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ContentControlLayout {
			get {
				return _contentControlLayout;
			}
		}

		#endregion

		#region Constructors: Public

		public MainPage_Base_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public MainPage_Base_TerrasoftSchema(MainPage_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			RealUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			Name = "MainPage_Base_Terrasoft";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Maximized = true;
			Width = 850;
			Height = 500;
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMainPage_Base_TerrasoftEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateTopControlLayout());
			TopControlLayout.InsertItem(0, CreateTopLeftControlLayout());
			TopLeftControlLayout.InsertItem(0, CreateLogoControlLayout());
			LogoControlLayout.InsertItem(0, CreateImageBox1());
			TopLeftControlLayout.InsertItem(1, CreateNavigationControlLayout());
			NavigationControlLayout.InsertItem(0, CreateNavigationButtonsControlLayout());
			NavigationButtonsControlLayout.InsertItem(0, CreateAddButton());
			NavigationButtonsControlLayout.InsertItem(1, CreateUnreadEmailCountButton());
			NavigationButtonsControlLayout.InsertItem(2, CreateNewRemindingsCountButton());
			NavigationButtonsControlLayout.InsertItem(3, CreateRunProcessButton());
			NavigationButtonsControlLayout.InsertItem(4, CreateSpacer1());
			NavigationButtonsControlLayout.InsertItem(5, CreateControlLayout1());
			TopControlLayout.InsertItem(1, CreateTopRightControlLayout());
			TopRightControlLayout.InsertItem(0, CreateMultiLevelTabs());
			MultiLevelTabs.InsertItem(0, CreateSearchEdit());
			SearchEdit.InsertItem(0, CreateClearToolButton());
			SearchEdit.InsertItem(1, CreateModulesToolButton());
			SearchEdit.InsertItem(2, CreateSearchToolButton());
			MultiLevelTabs.InsertItem(1, CreateSettingsButton());
			MultiLevelTabs.InsertItem(2, CreateUserSettingsButton());
			MultiLevelTabs.InsertItem(3, CreateContextHelpButton());
			ContextHelpButton.InsertItem(0, CreateOpenContextHelp());
			ContextHelpButton.InsertItem(1, CreateOpenModuleHelp());
			ContextHelpButton.InsertItem(2, CreateShowWelcomeScreen());
			MultiLevelTabs.InsertItem(4, CreateExitButton());
			Controls.AddAt(1, CreateBaseMessagePanel());
			Controls.AddAt(2, CreateNavigationControlsImageList());
			Controls.AddAt(3, CreateContentControlLayout());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateMainPage_Base_TerrasoftEventsProcessSchema() {
			var schema = new MainPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ImageBox CreateImageBox1() {
			_imageBox1 = new Terrasoft.UI.WebControls.Controls.ImageBox();
			_imageBox1.UId = new Guid("b3f9dc12-4d5d-4f25-aacb-6d12d1ffa95d");
			_imageBox1.Name = "ImageBox1";
			_imageBox1.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_imageBox1.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_imageBox1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_imageBox1.Tag = "";
			_imageBox1.Image = new ControlImage {};
			_imageBox1.Height = System.Web.UI.WebControls.Unit.Pixel(39);
			_imageBox1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_imageBox1.Edges = "";
			_imageBox1.Margins = "5 0 0 5";
			return _imageBox1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateLogoControlLayout() {
			_logoControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_logoControlLayout.UId = new Guid("d330d48f-5cc5-43fc-ad29-a6f4956bce2b");
			_logoControlLayout.Name = "LogoControlLayout";
			_logoControlLayout.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_logoControlLayout.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_logoControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_logoControlLayout.Tag = "";
			_logoControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(32);
			_logoControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_logoControlLayout.StartNewAlignGroup = false;
			_logoControlLayout.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"eecd27fb9c59102f31f7b17d2d3a9098"
			};
			_logoControlLayout.Edges = "";
			return _logoControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddButton() {
			_addButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addButton.UId = new Guid("eb89b852-e7ac-4652-a33a-836204a0e0e4");
			_addButton.Name = "AddButton";
			_addButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_addButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_addButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addButton.Tag = "";
			_addButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"732f25c71e8e82b8f33e9015fb2761c3"
			};
			_addButton.Margins = "0 2 0 0";
			_addButton.Hidden = true;
			return _addButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUnreadEmailCountButton() {
			_unreadEmailCountButton = new Terrasoft.UI.WebControls.Controls.Button();
			_unreadEmailCountButton.UId = new Guid("6e756e6c-756d-47ea-ac5d-c3b0a2ca5ff4");
			_unreadEmailCountButton.Name = "UnreadEmailCountButton";
			_unreadEmailCountButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_unreadEmailCountButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_unreadEmailCountButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_unreadEmailCountButton.Tag = "";
			_unreadEmailCountButton.ButtonStyle = Terrasoft.UI.WebControls.Controls.ButtonStyle.Yellow;
			_unreadEmailCountButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"d80456e7ae9ddcaaba5be150e40430f6"
			};
			_unreadEmailCountButton.Width = System.Web.UI.WebControls.Unit.Pixel(30);
			_unreadEmailCountButton.Margins = "0 2 0 0";
			_unreadEmailCountButton.Enabled = false;
			_unreadEmailCountButton.Hidden = true;
			return _unreadEmailCountButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateNewRemindingsCountButton() {
			_newRemindingsCountButton = new Terrasoft.UI.WebControls.Controls.Button();
			_newRemindingsCountButton.UId = new Guid("d7bdea61-095f-419c-8104-c172c667d67b");
			_newRemindingsCountButton.Name = "NewRemindingsCountButton";
			_newRemindingsCountButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_newRemindingsCountButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_newRemindingsCountButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_newRemindingsCountButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_newRemindingsCountButton.Tag = "";
			_newRemindingsCountButton.ButtonStyle = Terrasoft.UI.WebControls.Controls.ButtonStyle.Yellow;
			_newRemindingsCountButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"ffb30c2b39b9af8d378949afa88bf6fe"
			};
			_newRemindingsCountButton.Width = System.Web.UI.WebControls.Unit.Pixel(30);
			_newRemindingsCountButton.Margins = "0 2 0 0";
			_newRemindingsCountButton.Enabled = false;
			_newRemindingsCountButton.Hidden = true;
			return _newRemindingsCountButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateRunProcessButton() {
			_runProcessButton = new Terrasoft.UI.WebControls.Controls.Button();
			_runProcessButton.UId = new Guid("b76eb5d0-a5d4-437a-ab32-81c54356c66a");
			_runProcessButton.Name = "RunProcessButton";
			_runProcessButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_runProcessButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_runProcessButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_runProcessButton.Tag = "";
			_runProcessButton.ButtonStyle = Terrasoft.UI.WebControls.Controls.ButtonStyle.Orange;
			_runProcessButton.Image = new ControlImage {};
			_runProcessButton.Margins = "0 0 0 0";
			_runProcessButton.Hidden = true;
			return _runProcessButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("1c014db3-b66b-47df-b751-196d604f50f5");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_spacer1.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("f6496852-de87-43f1-a01a-4064381f36b5");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_controlLayout1.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Pixel(1);
			_controlLayout1.Padding = "";
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.DefaultMargins = "";
			_controlLayout1.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"eecd27fb9c59102f31f7b17d2d3a9098"
			};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNavigationButtonsControlLayout() {
			_navigationButtonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_navigationButtonsControlLayout.UId = new Guid("b5e7d936-1884-401e-b869-8619a363355d");
			_navigationButtonsControlLayout.Name = "NavigationButtonsControlLayout";
			_navigationButtonsControlLayout.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_navigationButtonsControlLayout.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_navigationButtonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_navigationButtonsControlLayout.Tag = "";
			_navigationButtonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(32);
			_navigationButtonsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_navigationButtonsControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_navigationButtonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_navigationButtonsControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_navigationButtonsControlLayout.Padding = "0 0 0 5";
			_navigationButtonsControlLayout.StartNewAlignGroup = false;
			_navigationButtonsControlLayout.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"eecd27fb9c59102f31f7b17d2d3a9098"
			};
			_navigationButtonsControlLayout.Edges = "";
			_navigationButtonsControlLayout.SplitterSize = 0;
			return _navigationButtonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNavigationControlLayout() {
			_navigationControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_navigationControlLayout.UId = new Guid("62b0ec64-f693-4f55-9338-019a9c85aff8");
			_navigationControlLayout.Name = "NavigationControlLayout";
			_navigationControlLayout.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_navigationControlLayout.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_navigationControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_navigationControlLayout.Tag = "";
			_navigationControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(33);
			_navigationControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_navigationControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_navigationControlLayout.StartNewAlignGroup = false;
			_navigationControlLayout.Image = new ControlImage {};
			_navigationControlLayout.Edges = "";
			return _navigationControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTopLeftControlLayout() {
			_topLeftControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_topLeftControlLayout.UId = new Guid("6a7a00d2-30c3-40cc-af84-00bf126d55c4");
			_topLeftControlLayout.Name = "TopLeftControlLayout";
			_topLeftControlLayout.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_topLeftControlLayout.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_topLeftControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_topLeftControlLayout.Tag = "";
			_topLeftControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_topLeftControlLayout.Width = System.Web.UI.WebControls.Unit.Pixel(170);
			_topLeftControlLayout.StartNewAlignGroup = false;
			_topLeftControlLayout.Image = new ControlImage {};
			_topLeftControlLayout.Edges = "";
			return _topLeftControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateClearToolButton() {
			_clearToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_clearToolButton.UId = new Guid("f2edc780-76e4-43b1-ad8c-4ac20d840c85");
			_clearToolButton.Name = "ClearToolButton";
			_clearToolButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_clearToolButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_clearToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_clearToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_clearToolButton.Tag = "";
			_clearToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"cfdf940c3b92339e9ae166ea4f337539"
			};
			_clearToolButton.Hidden = true;
			return _clearToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateModulesToolButton() {
			_modulesToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_modulesToolButton.UId = new Guid("e5aef9d9-1cdd-4956-8ba2-8d62a524377c");
			_modulesToolButton.Name = "ModulesToolButton";
			_modulesToolButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_modulesToolButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_modulesToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_modulesToolButton.Tag = "";
			_modulesToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"1a9fc7e6fb874b752a26daed50999694"
			};
			return _modulesToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateSearchToolButton() {
			_searchToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_searchToolButton.UId = new Guid("787c75ef-0585-4c9e-8a9c-87ba3d0cf978");
			_searchToolButton.Name = "SearchToolButton";
			_searchToolButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_searchToolButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_searchToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchToolButton.Tag = "";
			_searchToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"1a9fc7e6fb874b752a26daed50999694"
			};
			return _searchToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSearchEdit() {
			_searchEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_searchEdit.UId = new Guid("af7db981-9207-421d-996f-c5b6949a609a");
			_searchEdit.Name = "SearchEdit";
			_searchEdit.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_searchEdit.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_searchEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchEdit.Tag = "";
			_searchEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_searchEdit.Image = new ControlImage {};
			_searchEdit.Hidden = true;
			return _searchEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSettingsButton() {
			_settingsButton = new Terrasoft.UI.WebControls.Controls.Button();
			_settingsButton.UId = new Guid("a474835b-1dde-4b43-abcd-847d08f876ea");
			_settingsButton.Name = "SettingsButton";
			_settingsButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_settingsButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_settingsButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_settingsButton.Tag = "";
			_settingsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"1a9fc7e6fb874b752a26daed50999694"
			};
			return _settingsButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUserSettingsButton() {
			_userSettingsButton = new Terrasoft.UI.WebControls.Controls.Button();
			_userSettingsButton.UId = new Guid("7f828e43-8f0a-4cf6-b3b9-e90e323c251c");
			_userSettingsButton.Name = "UserSettingsButton";
			_userSettingsButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_userSettingsButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_userSettingsButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_userSettingsButton.Tag = "";
			_userSettingsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"1a9fc7e6fb874b752a26daed50999694"
			};
			_userSettingsButton.Hidden = true;
			return _userSettingsButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateOpenContextHelp() {
			_openContextHelp = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_openContextHelp.UId = new Guid("21c2be26-0e93-4e4e-8c72-76842911d31e");
			_openContextHelp.Name = "OpenContextHelp";
			_openContextHelp.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_openContextHelp.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_openContextHelp.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_openContextHelp.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_openContextHelp.Image = new ControlImage {};
			_openContextHelp.Tag = "";
			return _openContextHelp;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateOpenModuleHelp() {
			_openModuleHelp = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_openModuleHelp.UId = new Guid("2f144ede-d514-4454-81fc-e209731d8f13");
			_openModuleHelp.Name = "OpenModuleHelp";
			_openModuleHelp.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_openModuleHelp.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_openModuleHelp.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_openModuleHelp.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_openModuleHelp.Image = new ControlImage {};
			_openModuleHelp.Tag = "";
			return _openModuleHelp;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateShowWelcomeScreen() {
			_showWelcomeScreen = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_showWelcomeScreen.UId = new Guid("08d06862-31dd-4ea1-988a-736d53063285");
			_showWelcomeScreen.Name = "ShowWelcomeScreen";
			_showWelcomeScreen.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_showWelcomeScreen.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_showWelcomeScreen.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_showWelcomeScreen.AjaxEvents.Click.IsProcessEventHandler = true;
			_showWelcomeScreen.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showWelcomeScreen.Image = new ControlImage {};
			_showWelcomeScreen.Tag = "";
			_showWelcomeScreen.Hidden = true;
			return _showWelcomeScreen;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("3d80c512-94b0-4e7f-8895-f015ddba55ca");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateExitButton() {
			_exitButton = new Terrasoft.UI.WebControls.Controls.Button();
			_exitButton.UId = new Guid("aa548570-a2b8-4e5c-9dd4-8f64680880e9");
			_exitButton.Name = "ExitButton";
			_exitButton.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_exitButton.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_exitButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_exitButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_exitButton.Tag = "";
			_exitButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"ffaca02094dc513963a5b2bc892e55c8"
			};
			_exitButton.Hidden = true;
			return _exitButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MultiLevelTabs CreateMultiLevelTabs() {
			_multiLevelTabs = new Terrasoft.UI.WebControls.Controls.MultiLevelTabs();
			_multiLevelTabs.UId = new Guid("74b2e790-55c4-4cf2-8f56-5a9d0b3ac6bc");
			_multiLevelTabs.Name = "MultiLevelTabs";
			_multiLevelTabs.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_multiLevelTabs.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_multiLevelTabs.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_multiLevelTabs.AjaxEvents.TabChange.ShowLoadMask = true;
			_multiLevelTabs.Tag = "";
			_multiLevelTabs.ActiveTabId = "";
			_multiLevelTabs.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _multiLevelTabs;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTopRightControlLayout() {
			_topRightControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_topRightControlLayout.UId = new Guid("c719b608-eae1-49fb-8151-9061c49d860d");
			_topRightControlLayout.Name = "TopRightControlLayout";
			_topRightControlLayout.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_topRightControlLayout.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_topRightControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_topRightControlLayout.Tag = "";
			_topRightControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_topRightControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_topRightControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_topRightControlLayout.StartNewAlignGroup = false;
			_topRightControlLayout.Image = new ControlImage {};
			_topRightControlLayout.Edges = "";
			return _topRightControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTopControlLayout() {
			_topControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_topControlLayout.UId = new Guid("d48a4518-5e42-45ba-ac43-ac8844ad1034");
			_topControlLayout.Name = "TopControlLayout";
			_topControlLayout.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_topControlLayout.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_topControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_topControlLayout.Tag = "";
			_topControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(66);
			_topControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_topControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_topControlLayout.StartNewAlignGroup = false;
			_topControlLayout.Image = new ControlImage {};
			_topControlLayout.Edges = "";
			return _topControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("cf9463be-aecf-4af7-9432-5a029ec0e68c");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.Margins = "0 0 0 0";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ImageList CreateNavigationControlsImageList() {
			_navigationControlsImageList = new Terrasoft.UI.WebControls.Controls.ImageList();
			_navigationControlsImageList.UId = new Guid("adbc135a-225e-4037-b384-fb57c6e5d9ca");
			_navigationControlsImageList.Name = "NavigationControlsImageList";
			_navigationControlsImageList.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_navigationControlsImageList.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_navigationControlsImageList.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_navigationControlsImageList.Tag = "";
			_navigationControlsImageList.InsertItem(0, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("119cb018-92e5-46c3-be18-eafe3dc04e9f"),
					ID = @"c119cb01892e546c3be18eafe3dc04e9f",
					Name = "multileveltabs-bg-strip-multi-level",
					CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
					ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a")
				});
			_navigationControlsImageList.InsertItem(1, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("cbda301e-94b5-4aa0-a4e7-cbc0a98c9ed8"),
					ID = @"ccbda301e94b54aa0a4e7cbc0a98c9ed8",
					Name = "start-page-process",
					CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
					ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a")
				});
			_navigationControlsImageList.InsertItem(2, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("ffd3ed0c-7d0b-4461-a203-fc2bf1f32b6e"),
					ID = @"cffd3ed0c7d0b4461a203fc2bf1f32b6e",
					Name = "start-page-processa",
					CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
					ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a")
				});
			_navigationControlsImageList.InsertItem(3, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("95406dce-3a0b-4637-916c-aeffb656d154"),
					ID = @"c95406dce3a0b4637916caeffb656d154",
					Name = "start-page-processb",
					CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
					ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a")
				});
			_navigationControlsImageList.InsertItem(4, 
				new Terrasoft.UI.WebControls.Controls.ImageListItem(){
					UId = new Guid("64e16144-e92f-4be1-87eb-de2d7f44ac09"),
					ID = @"c64e16144e92f4be187ebde2d7f44ac09",
					Name = "ico-separator",
					CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
					ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a")
				});
			return _navigationControlsImageList;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateContentControlLayout() {
			_contentControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_contentControlLayout.UId = new Guid("bc3b780d-de89-445b-8828-c14cf5558214");
			_contentControlLayout.Name = "ContentControlLayout";
			_contentControlLayout.CreatedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_contentControlLayout.ModifiedInSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			_contentControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contentControlLayout.Tag = "";
			_contentControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_contentControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_contentControlLayout.Padding = "5 0 0 0";
			_contentControlLayout.StartNewAlignGroup = false;
			_contentControlLayout.Image = new ControlImage {};
			_contentControlLayout.Edges = "";
			return _contentControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new MainPage_Base_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new MainPage_Base_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new MainPage_Base_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: MainPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class MainPage_Base_TerrasoftEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.MainPage_Base_TerrasoftSchemaUserControl
	{

		#region Class: ShowRemindingsUserTaskFlowElement

		/// <exclude/>
		public class ShowRemindingsUserTaskFlowElement : OpenPageUserTask
		{

			public ShowRemindingsUserTaskFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowRemindingsUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenImapServersSettingsUserTaskFlowElement

		/// <exclude/>
		public class OpenImapServersSettingsUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenImapServersSettingsUserTaskFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenImapServersSettingsUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("91e34f72-437e-4615-bab2-4f981abed21f");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenSocialAccountGridPageFlowElement

		/// <exclude/>
		public class OpenSocialAccountGridPageFlowElement : OpenLookupUserTask
		{

			public OpenSocialAccountGridPageFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenSocialAccountGridPage";
				IsLogging = false;
				SchemaElementUId = new Guid("b98b0491-c901-4970-b579-b95360d1f5b9");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenLicPageFlowElement

		/// <exclude/>
		public class OpenLicPageFlowElement : OpenPageUserTask
		{

			public OpenLicPageFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLicPage";
				IsLogging = false;
				SchemaElementUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: SetMailChimpSettingsButtonMenuItemEventUserTaskFlowElement

		/// <exclude/>
		public class SetMailChimpSettingsButtonMenuItemEventUserTaskFlowElement : OpenPageUserTask
		{

			public SetMailChimpSettingsButtonMenuItemEventUserTaskFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SetMailChimpSettingsButtonMenuItemEventUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenIntegrationLogUserTaskFlowElement

		/// <exclude/>
		public class OpenIntegrationLogUserTaskFlowElement : OpenPageUserTask
		{

			public OpenIntegrationLogUserTaskFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenIntegrationLogUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenImportPageUserTaskFlowElement

		/// <exclude/>
		public class OpenImportPageUserTaskFlowElement : OpenPageUserTask
		{

			public OpenImportPageUserTaskFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenImportPageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenSelectDataUserTaskFlowElement

		/// <exclude/>
		public class OpenSelectDataUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenSelectDataUserTaskFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenSelectDataUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("8815c5ff-679e-4518-969e-22358826c8d4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: MessageWindowUserTaskFlowElement

		/// <exclude/>
		public class MessageWindowUserTaskFlowElement : QuestionUserTask
		{

			public MessageWindowUserTaskFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "MessageWindowUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowDefinedPageUserTaskFlowElement

		/// <exclude/>
		public class ShowDefinedPageUserTaskFlowElement : OpenPageUserTask
		{

			public ShowDefinedPageUserTaskFlowElement(UserConnection userConnection, MainPage_Base_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowDefinedPageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74");
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

		public MainPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MainPage_Base_TerrasoftEventsProcess";
			SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
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

		public virtual Guid PageSchemaUId {
			get;
			set;
		}

		public virtual Guid FirstPageSchemaIdToLoad {
			get;
			set;
		}

		public virtual Guid SelectedModuleId {
			get;
			set;
		}

		public virtual string GlobalSearchValue {
			get;
			set;
		}

		public virtual int CheckingRemindingsInterval {
			get;
			set;
		}

		public virtual string MessagePanelClickedLinkId {
			get;
			set;
		}

		public virtual Guid RemindingsPageUId {
			get;
			set;
		}

		public virtual Object MoveToParameters {
			get;
			set;
		}

		public virtual Guid FAQLinkId {
			get;
			set;
		}

		private string _communityLink;
		public virtual string CommunityLink {
			get {
				return _communityLink ?? (_communityLink = new LocalizableString(Storage, "5e5f9a9eaa7d407d9e1e1c24c3f9b59a",
						 "EventsProcessSchema.Parameters.CommunityLink.Value"));
			}
			set {
				_communityLink = value;
			}
		}

		private Guid _showLDAPMessageId = new Guid("{83A1E9EA-651D-4600-B027-886C6EFA6524}");
		public Guid ShowLDAPMessageId {
			get {
				return _showLDAPMessageId;
			}
			set {
				_showLDAPMessageId = value;
			}
		}

		private Guid _cancelLDAPMessageId = new Guid("{23BB9BEE-C97C-4715-AD69-9A6EC3191307}");
		public Guid CancelLDAPMessageId {
			get {
				return _cancelLDAPMessageId;
			}
			set {
				_cancelLDAPMessageId = value;
			}
		}

		public virtual bool IsTuningModule {
			get;
			set;
		}

		public virtual bool TuningProcessMode {
			get;
			set;
		}

		private Guid _settingsModeSettingsButtonMenuItemTag = new Guid("{FCC18473-5563-422B-A5A2-3E31FF6B7FA7}");
		public Guid SettingsModeSettingsButtonMenuItemTag {
			get {
				return _settingsModeSettingsButtonMenuItemTag;
			}
			set {
				_settingsModeSettingsButtonMenuItemTag = value;
			}
		}

		private Guid _imapServersSettingsSettingsButtonMenuItemTag = new Guid("{79C445FE-3360-4261-BD6C-3560BB4BA0A8}");
		public Guid ImapServersSettingsSettingsButtonMenuItemTag {
			get {
				return _imapServersSettingsSettingsButtonMenuItemTag;
			}
			set {
				_imapServersSettingsSettingsButtonMenuItemTag = value;
			}
		}

		private Guid _mailServerSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4");
		public Guid MailServerSchemaUId {
			get {
				return _mailServerSchemaUId;
			}
			set {
				_mailServerSchemaUId = value;
			}
		}

		public virtual string SettingsModeSettingsButtonMenuItemCaption {
			get;
			set;
		}

		public virtual bool CanChangeApplicationTuningMode {
			get;
			set;
		}

		public virtual bool CanManageMailServers {
			get;
			set;
		}

		private Guid _separatorMenuItemTag = new Guid("{C3254322-CA97-4B10-AC81-EB05AA7CF11E}");
		public Guid SeparatorMenuItemTag {
			get {
				return _separatorMenuItemTag;
			}
			set {
				_separatorMenuItemTag = value;
			}
		}

		private Guid _mailboxSynchronizationSettingsPageUId = new Guid("fce8864e-7b01-429e-921e-0563c725d563");
		public Guid MailboxSynchronizationSettingsPageUId {
			get {
				return _mailboxSynchronizationSettingsPageUId;
			}
			set {
				_mailboxSynchronizationSettingsPageUId = value;
			}
		}

		public virtual Guid EditSocialAccountsMenuItemTag {
			get;
			set;
		}

		public virtual Object MsgToolInstance {
			get;
			set;
		}

		public virtual bool CanManageLicUsers {
			get;
			set;
		}

		private Guid _licensesSettingsButtonMenuItemTag = new Guid("674E8D51-E36F-4598-A77E-374AA12AE96D");
		public Guid LicensesSettingsButtonMenuItemTag {
			get {
				return _licensesSettingsButtonMenuItemTag;
			}
			set {
				_licensesSettingsButtonMenuItemTag = value;
			}
		}

		public virtual bool IsDemoBuild {
			get;
			set;
		}

		public virtual string WelcomeScreenDataKey {
			get;
			set;
		}

		public virtual string SelectedModuleCode {
			get;
			set;
		}

		public virtual string SelectedModuleHelpContextId {
			get;
			set;
		}

		public virtual Object SelectedModuleCaption {
			get;
			set;
		}

		private Guid _editTelephonyButtonMenuItemTag = new Guid("{8230A862-115E-4B48-9393-9C8A7E9049BD}");
		public Guid EditTelephonyButtonMenuItemTag {
			get {
				return _editTelephonyButtonMenuItemTag;
			}
			set {
				_editTelephonyButtonMenuItemTag = value;
			}
		}

		public virtual bool CanUseMsgService {
			get;
			set;
		}

		public virtual Guid SearchModuleId {
			get;
			set;
		}

		public virtual bool IsDeveloperMode {
			get;
			set;
		}

		public virtual string CallSessionDataKey {
			get;
			set;
		}

		public virtual Guid SavedDataId {
			get;
			set;
		}

		private Guid _setMailChimpSettingsButtonMenuItemTag = new Guid("ed9c7081-81a9-4b54-8b2d-5ec50037eeed");
		public Guid SetMailChimpSettingsButtonMenuItemTag {
			get {
				return _setMailChimpSettingsButtonMenuItemTag;
			}
			set {
				_setMailChimpSettingsButtonMenuItemTag = value;
			}
		}

		private Guid _mailChimpSettingsPageSchemaUId = new Guid("D16B991C-05D9-440E-A39D-84EB840E0386");
		public Guid MailChimpSettingsPageSchemaUId {
			get {
				return _mailChimpSettingsPageSchemaUId;
			}
			set {
				_mailChimpSettingsPageSchemaUId = value;
			}
		}

		public virtual bool CanUseMailChimpIntegrationSettings {
			get;
			set;
		}

		public virtual string SysMainPageShellClientId {
			get;
			set;
		}

		private Guid _integrationLogPageSchemaUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
		public Guid IntegrationLogPageSchemaUId {
			get {
				return _integrationLogPageSchemaUId;
			}
			set {
				_integrationLogPageSchemaUId = value;
			}
		}

		private Guid _openIntegrationLogMenuItemTag = new Guid("A1E8B7AD-022E-48B0-99BD-CFF285F9743F");
		public Guid OpenIntegrationLogMenuItemTag {
			get {
				return _openIntegrationLogMenuItemTag;
			}
			set {
				_openIntegrationLogMenuItemTag = value;
			}
		}

		public virtual bool CanStartCommandGeneration {
			get;
			set;
		}

		private Guid _commandGenerationButtonMenuItemTag = new Guid("A7515339-D17B-400F-8458-F0E9F37B00B4");
		public Guid CommandGenerationButtonMenuItemTag {
			get {
				return _commandGenerationButtonMenuItemTag;
			}
			set {
				_commandGenerationButtonMenuItemTag = value;
			}
		}

		private Guid _importPageSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
		public Guid ImportPageSchemaUId {
			get {
				return _importPageSchemaUId;
			}
			set {
				_importPageSchemaUId = value;
			}
		}

		private Guid _importButtonMenuItemTag = new Guid("6A3B8248-D817-4049-9B10-87BC53041262");
		public Guid ImportButtonMenuItemTag {
			get {
				return _importButtonMenuItemTag;
			}
			set {
				_importButtonMenuItemTag = value;
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
					SchemaElementUId = new Guid("198430a9-d064-4731-b549-f925646c7dda"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _exitButtonClickStartMessage;
		public ProcessFlowElement ExitButtonClickStartMessage {
			get {
				return _exitButtonClickStartMessage ?? (_exitButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ExitButtonClickStartMessage",
					SchemaElementUId = new Guid("60b2eeae-40d2-4458-aed6-27631b179245"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _exitButtonClickScriptTask;
		public ProcessScriptTask ExitButtonClickScriptTask {
			get {
				return _exitButtonClickScriptTask ?? (_exitButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ExitButtonClickScriptTask",
					SchemaElementUId = new Guid("91362b05-9e57-4d57-933a-543b89de1176"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ExitButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _remindingsPageEventSubProcess;
		public ProcessFlowElement RemindingsPageEventSubProcess {
			get {
				return _remindingsPageEventSubProcess ?? (_remindingsPageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "RemindingsPageEventSubProcess",
					SchemaElementUId = new Guid("92c85eb3-52fe-4f08-87c8-4628e515b367"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2q;
		public ProcessFlowElement StartMessage2q {
			get {
				return _startMessage2q ?? (_startMessage2q = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2q",
					SchemaElementUId = new Guid("76d7400b-fe95-453c-9e91-c74c87b9a7b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _remindingsPageParamsScriptTask;
		public ProcessScriptTask RemindingsPageParamsScriptTask {
			get {
				return _remindingsPageParamsScriptTask ?? (_remindingsPageParamsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemindingsPageParamsScriptTask",
					SchemaElementUId = new Guid("bbe5807a-7140-46ce-9054-68a7349d6a5d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemindingsPageParamsScriptTaskExecute,
				});
			}
		}

		private ShowRemindingsUserTaskFlowElement _showRemindingsUserTask;
		public ShowRemindingsUserTaskFlowElement ShowRemindingsUserTask {
			get {
				return _showRemindingsUserTask ?? (_showRemindingsUserTask = new ShowRemindingsUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _settingsModeSettingsButtonMenuItemEventSubProcess;
		public ProcessFlowElement SettingsModeSettingsButtonMenuItemEventSubProcess {
			get {
				return _settingsModeSettingsButtonMenuItemEventSubProcess ?? (_settingsModeSettingsButtonMenuItemEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SettingsModeSettingsButtonMenuItemEventSubProcess",
					SchemaElementUId = new Guid("67086d1e-c4e1-4f11-affd-c57c23097333"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _settingsModeSettingsButtonMenuItemEvent;
		public ProcessFlowElement SettingsModeSettingsButtonMenuItemEvent {
			get {
				return _settingsModeSettingsButtonMenuItemEvent ?? (_settingsModeSettingsButtonMenuItemEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SettingsModeSettingsButtonMenuItemEvent",
					SchemaElementUId = new Guid("00bc3671-670b-471d-971a-2372f88386a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _settingsButtonClickScript;
		public ProcessScriptTask SettingsButtonClickScript {
			get {
				return _settingsButtonClickScript ?? (_settingsButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SettingsButtonClickScript",
					SchemaElementUId = new Guid("6b395840-0f8b-469c-9ba4-c3e4babc5a88"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SettingsButtonClickScriptExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPrepeareInformation;
		public ProcessScriptTask ScriptTaskPrepeareInformation {
			get {
				return _scriptTaskPrepeareInformation ?? (_scriptTaskPrepeareInformation = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPrepeareInformation",
					SchemaElementUId = new Guid("2ed4d1d8-8401-4a69-8ec4-abad6083bb69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPrepeareInformationExecute,
				});
			}
		}

		private ProcessFlowElement _imapServersSettingsSettingsButtonMenuItemEventEventSubProcess;
		public ProcessFlowElement ImapServersSettingsSettingsButtonMenuItemEventEventSubProcess {
			get {
				return _imapServersSettingsSettingsButtonMenuItemEventEventSubProcess ?? (_imapServersSettingsSettingsButtonMenuItemEventEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ImapServersSettingsSettingsButtonMenuItemEventEventSubProcess",
					SchemaElementUId = new Guid("738e401c-03a2-4e39-bd0c-90713dbf8b6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _imapServersSettingsSettingsButtonMenuItemEventStartMessage;
		public ProcessFlowElement ImapServersSettingsSettingsButtonMenuItemEventStartMessage {
			get {
				return _imapServersSettingsSettingsButtonMenuItemEventStartMessage ?? (_imapServersSettingsSettingsButtonMenuItemEventStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ImapServersSettingsSettingsButtonMenuItemEventStartMessage",
					SchemaElementUId = new Guid("47b626c6-56a0-4421-b728-deb5601e2cd9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _imapServersSettingsSettingsButtonMenuItemEventScriptTask;
		public ProcessScriptTask ImapServersSettingsSettingsButtonMenuItemEventScriptTask {
			get {
				return _imapServersSettingsSettingsButtonMenuItemEventScriptTask ?? (_imapServersSettingsSettingsButtonMenuItemEventScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ImapServersSettingsSettingsButtonMenuItemEventScriptTask",
					SchemaElementUId = new Guid("a4d0883c-8903-4cc9-ad9b-8f2f9494a593"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ImapServersSettingsSettingsButtonMenuItemEventScriptTaskExecute,
				});
			}
		}

		private OpenImapServersSettingsUserTaskFlowElement _openImapServersSettingsUserTask;
		public OpenImapServersSettingsUserTaskFlowElement OpenImapServersSettingsUserTask {
			get {
				return _openImapServersSettingsUserTask ?? (_openImapServersSettingsUserTask = new OpenImapServersSettingsUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("89186007-50dc-4dcb-afc8-858d4f155a1d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _editSocialAccountsButtonMenuItemEvent;
		public ProcessFlowElement EditSocialAccountsButtonMenuItemEvent {
			get {
				return _editSocialAccountsButtonMenuItemEvent ?? (_editSocialAccountsButtonMenuItemEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EditSocialAccountsButtonMenuItemEvent",
					SchemaElementUId = new Guid("6b030f99-a261-44c2-ba53-8713f5847b7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _openSocialAccountGridScriptTask;
		public ProcessScriptTask OpenSocialAccountGridScriptTask {
			get {
				return _openSocialAccountGridScriptTask ?? (_openSocialAccountGridScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpenSocialAccountGridScriptTask",
					SchemaElementUId = new Guid("f7bcdaf6-d2bd-4971-9cd1-5da7d95a10a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpenSocialAccountGridScriptTaskExecute,
				});
			}
		}

		private OpenSocialAccountGridPageFlowElement _openSocialAccountGridPage;
		public OpenSocialAccountGridPageFlowElement OpenSocialAccountGridPage {
			get {
				return _openSocialAccountGridPage ?? (_openSocialAccountGridPage = new OpenSocialAccountGridPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("77517f97-cb98-4864-ad3e-d1a00d859388"),
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
					SchemaElementUId = new Guid("18dbd9ac-8f5f-4f0d-8dca-0c6c5ee209a8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _licensesSettingsButtonMenuItemEventScriptTask;
		public ProcessScriptTask LicensesSettingsButtonMenuItemEventScriptTask {
			get {
				return _licensesSettingsButtonMenuItemEventScriptTask ?? (_licensesSettingsButtonMenuItemEventScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LicensesSettingsButtonMenuItemEventScriptTask",
					SchemaElementUId = new Guid("add703c4-da59-4675-8f8d-eb691e1c690a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LicensesSettingsButtonMenuItemEventScriptTaskExecute,
				});
			}
		}

		private OpenLicPageFlowElement _openLicPage;
		public OpenLicPageFlowElement OpenLicPage {
			get {
				return _openLicPage ?? (_openLicPage = new OpenLicPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _setMailChimpSettingsButtonMenuItemEventSubProcess;
		public ProcessFlowElement SetMailChimpSettingsButtonMenuItemEventSubProcess {
			get {
				return _setMailChimpSettingsButtonMenuItemEventSubProcess ?? (_setMailChimpSettingsButtonMenuItemEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SetMailChimpSettingsButtonMenuItemEventSubProcess",
					SchemaElementUId = new Guid("b33671fa-1eb2-41d3-8d8b-ba7415fd0505"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _setMailChimpSettingsButtonMenuItemEventStartMessage;
		public ProcessFlowElement SetMailChimpSettingsButtonMenuItemEventStartMessage {
			get {
				return _setMailChimpSettingsButtonMenuItemEventStartMessage ?? (_setMailChimpSettingsButtonMenuItemEventStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SetMailChimpSettingsButtonMenuItemEventStartMessage",
					SchemaElementUId = new Guid("46c0cf64-8ba5-40f5-9672-7cf91a66ed51"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private SetMailChimpSettingsButtonMenuItemEventUserTaskFlowElement _setMailChimpSettingsButtonMenuItemEventUserTask;
		public SetMailChimpSettingsButtonMenuItemEventUserTaskFlowElement SetMailChimpSettingsButtonMenuItemEventUserTask {
			get {
				return _setMailChimpSettingsButtonMenuItemEventUserTask ?? (_setMailChimpSettingsButtonMenuItemEventUserTask = new SetMailChimpSettingsButtonMenuItemEventUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _setMailChimpIntegrationSettingPrepareScriptTask;
		public ProcessScriptTask SetMailChimpIntegrationSettingPrepareScriptTask {
			get {
				return _setMailChimpIntegrationSettingPrepareScriptTask ?? (_setMailChimpIntegrationSettingPrepareScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetMailChimpIntegrationSettingPrepareScriptTask",
					SchemaElementUId = new Guid("a796e222-b7a7-4c51-9eaa-60e7f1e03ee9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetMailChimpIntegrationSettingPrepareScriptTaskExecute,
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
					SchemaElementUId = new Guid("05aeca4d-a7cd-4205-a4bd-03a692f41596"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _setIntegrationLogMenuItemEvent;
		public ProcessFlowElement SetIntegrationLogMenuItemEvent {
			get {
				return _setIntegrationLogMenuItemEvent ?? (_setIntegrationLogMenuItemEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SetIntegrationLogMenuItemEvent",
					SchemaElementUId = new Guid("b128ddba-b67a-4f02-a5ae-747c276d1788"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _preparePageParametersScriptTask;
		public ProcessScriptTask PreparePageParametersScriptTask {
			get {
				return _preparePageParametersScriptTask ?? (_preparePageParametersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PreparePageParametersScriptTask",
					SchemaElementUId = new Guid("cdd0ba6c-d857-4f7f-8ee9-650d4867e470"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PreparePageParametersScriptTaskExecute,
				});
			}
		}

		private OpenIntegrationLogUserTaskFlowElement _openIntegrationLogUserTask;
		public OpenIntegrationLogUserTaskFlowElement OpenIntegrationLogUserTask {
			get {
				return _openIntegrationLogUserTask ?? (_openIntegrationLogUserTask = new OpenIntegrationLogUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _importButtonMenuItemClickStartMessage;
		public ProcessFlowElement ImportButtonMenuItemClickStartMessage {
			get {
				return _importButtonMenuItemClickStartMessage ?? (_importButtonMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ImportButtonMenuItemClickStartMessage",
					SchemaElementUId = new Guid("4656174e-7a66-4415-9903-4605217de76e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("f0bbc3fc-c4ae-475d-8225-6b03220fb4a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private OpenImportPageUserTaskFlowElement _openImportPageUserTask;
		public OpenImportPageUserTaskFlowElement OpenImportPageUserTask {
			get {
				return _openImportPageUserTask ?? (_openImportPageUserTask = new OpenImportPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _commandGenerationButtonMenuItemEventSubProcess;
		public ProcessFlowElement CommandGenerationButtonMenuItemEventSubProcess {
			get {
				return _commandGenerationButtonMenuItemEventSubProcess ?? (_commandGenerationButtonMenuItemEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CommandGenerationButtonMenuItemEventSubProcess",
					SchemaElementUId = new Guid("fdf2f631-62ac-4d74-bec0-100febf98915"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _commandGenerationButtonMenuItemEventStartMessage;
		public ProcessFlowElement CommandGenerationButtonMenuItemEventStartMessage {
			get {
				return _commandGenerationButtonMenuItemEventStartMessage ?? (_commandGenerationButtonMenuItemEventStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CommandGenerationButtonMenuItemEventStartMessage",
					SchemaElementUId = new Guid("c14bb798-2674-4c1d-9535-32194f766373"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _commandGenerationButtonMenuItemScriptTask;
		public ProcessScriptTask CommandGenerationButtonMenuItemScriptTask {
			get {
				return _commandGenerationButtonMenuItemScriptTask ?? (_commandGenerationButtonMenuItemScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CommandGenerationButtonMenuItemScriptTask",
					SchemaElementUId = new Guid("4f299ce7-f675-4db9-80de-12d1baa15a84"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CommandGenerationButtonMenuItemScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _findSelectedModuleSubProcess;
		public ProcessFlowElement FindSelectedModuleSubProcess {
			get {
				return _findSelectedModuleSubProcess ?? (_findSelectedModuleSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "FindSelectedModuleSubProcess",
					SchemaElementUId = new Guid("69bde98c-7526-452c-a2d9-3ca70d571484"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _findSelectedModule;
		public ProcessFlowElement FindSelectedModule {
			get {
				return _findSelectedModule ?? (_findSelectedModule = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FindSelectedModule",
					SchemaElementUId = new Guid("ab094bca-c0f3-446c-8a96-5f83591ab308"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptFindSelectedModuleSubProcess;
		public ProcessScriptTask ScriptFindSelectedModuleSubProcess {
			get {
				return _scriptFindSelectedModuleSubProcess ?? (_scriptFindSelectedModuleSubProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptFindSelectedModuleSubProcess",
					SchemaElementUId = new Guid("42af6167-1d4b-4676-a975-c0557b3a30db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptFindSelectedModuleSubProcessExecute,
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
					SchemaElementUId = new Guid("113a32ea-67e0-4571-8fbe-8a0eb10ccf76"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _selectAndRunProcessEvent;
		public ProcessFlowElement SelectAndRunProcessEvent {
			get {
				return _selectAndRunProcessEvent ?? (_selectAndRunProcessEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SelectAndRunProcessEvent",
					SchemaElementUId = new Guid("94ce6734-d6d7-46a5-a797-d7c9f73022d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _selectAndRunProcessScript;
		public ProcessScriptTask SelectAndRunProcessScript {
			get {
				return _selectAndRunProcessScript ?? (_selectAndRunProcessScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SelectAndRunProcessScript",
					SchemaElementUId = new Guid("7c127c89-75ea-4cc1-a343-f19f36a77a6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SelectAndRunProcessScriptExecute,
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _lookupGridPageClosedEvent;
		public ProcessIntermediateCatchMessageEvent LookupGridPageClosedEvent {
			get {
				return _lookupGridPageClosedEvent ?? (_lookupGridPageClosedEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "LookupGridPageClosedEvent",
					SchemaElementUId = new Guid("2814422c-12dd-49d0-aa7b-0fd8795728a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _runProcessScript;
		public ProcessScriptTask RunProcessScript {
			get {
				return _runProcessScript ?? (_runProcessScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RunProcessScript",
					SchemaElementUId = new Guid("6770ea02-22ed-4c25-bdac-b0955709bb20"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RunProcessScriptExecute,
				});
			}
		}

		private OpenSelectDataUserTaskFlowElement _openSelectDataUserTask;
		public OpenSelectDataUserTaskFlowElement OpenSelectDataUserTask {
			get {
				return _openSelectDataUserTask ?? (_openSelectDataUserTask = new OpenSelectDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("b09c11e2-4be3-4f16-99a2-ddfa497fcc7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _showMessageEvent;
		public ProcessFlowElement ShowMessageEvent {
			get {
				return _showMessageEvent ?? (_showMessageEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ShowMessageEvent",
					SchemaElementUId = new Guid("82264521-65aa-43fd-bc03-f3b418a82775"),
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

		private ProcessFlowElement _subProcess3;
		public ProcessFlowElement SubProcess3 {
			get {
				return _subProcess3 ?? (_subProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess3",
					SchemaElementUId = new Guid("c54b2080-d64f-4dd9-9e29-77fab6d82904"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _settingsChangedEvent;
		public ProcessFlowElement SettingsChangedEvent {
			get {
				return _settingsChangedEvent ?? (_settingsChangedEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SettingsChangedEvent",
					SchemaElementUId = new Guid("b65bf503-18bd-448b-81e5-67fdb52482c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _settingsChangedScript;
		public ProcessScriptTask SettingsChangedScript {
			get {
				return _settingsChangedScript ?? (_settingsChangedScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SettingsChangedScript",
					SchemaElementUId = new Guid("131613ba-034f-430b-8049-a4bd3c82e1f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SettingsChangedScriptExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess4;
		public ProcessFlowElement SubProcess4 {
			get {
				return _subProcess4 ?? (_subProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess4",
					SchemaElementUId = new Guid("60a03026-2058-4b56-8c14-465137320417"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _messagePanelLinkClick;
		public ProcessFlowElement MessagePanelLinkClick {
			get {
				return _messagePanelLinkClick ?? (_messagePanelLinkClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MessagePanelLinkClick",
					SchemaElementUId = new Guid("c7921c78-2805-483d-8ab7-3dcbae70fffc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _linkClickScriptTask;
		public ProcessScriptTask LinkClickScriptTask {
			get {
				return _linkClickScriptTask ?? (_linkClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LinkClickScriptTask",
					SchemaElementUId = new Guid("7185ed34-513e-4ad8-9b4f-214adc322c7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LinkClickScriptTaskExecute,
				});
			}
		}

		private ShowDefinedPageUserTaskFlowElement _showDefinedPageUserTask;
		public ShowDefinedPageUserTaskFlowElement ShowDefinedPageUserTask {
			get {
				return _showDefinedPageUserTask ?? (_showDefinedPageUserTask = new ShowDefinedPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _showRemindingsUserTaskInit;
		public ProcessScriptTask ShowRemindingsUserTaskInit {
			get {
				return _showRemindingsUserTaskInit ?? (_showRemindingsUserTaskInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowRemindingsUserTaskInit",
					SchemaElementUId = new Guid("e14fa834-871c-4935-a8ad-ddf57bca0df5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowRemindingsUserTaskInitExecute,
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
					SchemaElementUId = new Guid("e6f68b51-1331-4be3-b775-39c7322638f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private ProcessScriptTask _mailboxSettingsScriptTask;
		public ProcessScriptTask MailboxSettingsScriptTask {
			get {
				return _mailboxSettingsScriptTask ?? (_mailboxSettingsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailboxSettingsScriptTask",
					SchemaElementUId = new Guid("4186fb24-821e-43f0-91f7-702ed83c1727"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailboxSettingsScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess5;
		public ProcessFlowElement SubProcess5 {
			get {
				return _subProcess5 ?? (_subProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess5",
					SchemaElementUId = new Guid("8651190b-f06d-428a-8888-00272b1042a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _moveToModule;
		public ProcessFlowElement MoveToModule {
			get {
				return _moveToModule ?? (_moveToModule = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MoveToModule",
					SchemaElementUId = new Guid("076bc514-7c3e-4f54-bdb5-5ebfd72b1e06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _moveToModuleScript;
		public ProcessScriptTask MoveToModuleScript {
			get {
				return _moveToModuleScript ?? (_moveToModuleScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MoveToModuleScript",
					SchemaElementUId = new Guid("63356494-85eb-4129-a50e-dd6835075a02"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MoveToModuleScriptExecute,
				});
			}
		}

		private ProcessFlowElement _helpCalledEventSubProcess;
		public ProcessFlowElement HelpCalledEventSubProcess {
			get {
				return _helpCalledEventSubProcess ?? (_helpCalledEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "HelpCalledEventSubProcess",
					SchemaElementUId = new Guid("14ab1d01-2b8d-41b9-9058-b3896a0293a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _helpCalledStartMessage;
		public ProcessFlowElement HelpCalledStartMessage {
			get {
				return _helpCalledStartMessage ?? (_helpCalledStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "HelpCalledStartMessage",
					SchemaElementUId = new Guid("f9de3122-2104-4e62-8c39-0fc4cdf8b23c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptHelpCalled;
		public ProcessScriptTask ScriptHelpCalled {
			get {
				return _scriptHelpCalled ?? (_scriptHelpCalled = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptHelpCalled",
					SchemaElementUId = new Guid("f4c06641-4593-4e6c-a444-ad29d48f9890"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptHelpCalledExecute,
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
					SchemaElementUId = new Guid("35f83dfc-214c-42e5-8471-f8a68bbd9eaf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _messagePanelMessageClosed;
		public ProcessFlowElement MessagePanelMessageClosed {
			get {
				return _messagePanelMessageClosed ?? (_messagePanelMessageClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MessagePanelMessageClosed",
					SchemaElementUId = new Guid("0d6e9f24-b409-438c-9cf5-20245ea7b961"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptMessagePanelMessageClosed;
		public ProcessScriptTask ScriptMessagePanelMessageClosed {
			get {
				return _scriptMessagePanelMessageClosed ?? (_scriptMessagePanelMessageClosed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptMessagePanelMessageClosed",
					SchemaElementUId = new Guid("7e2b288d-6948-44e7-9faa-449064be0d12"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptMessagePanelMessageClosedExecute,
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
					SchemaElementUId = new Guid("927acb97-15d2-4823-802a-af0a575ef6d1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _doShowLDAPMessage;
		public ProcessFlowElement DoShowLDAPMessage {
			get {
				return _doShowLDAPMessage ?? (_doShowLDAPMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DoShowLDAPMessage",
					SchemaElementUId = new Guid("452cc4ee-729d-4e71-9d52-4221fe0cf186"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDoShowLDAPMessage;
		public ProcessScriptTask ScriptDoShowLDAPMessage {
			get {
				return _scriptDoShowLDAPMessage ?? (_scriptDoShowLDAPMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDoShowLDAPMessage",
					SchemaElementUId = new Guid("6af27a8d-b97b-4599-85ad-128853c2ea30"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDoShowLDAPMessageExecute,
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
					SchemaElementUId = new Guid("cbc50e63-4006-4c5b-b729-3af3c6e5b46d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _showStartProcess;
		public ProcessFlowElement ShowStartProcess {
			get {
				return _showStartProcess ?? (_showStartProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ShowStartProcess",
					SchemaElementUId = new Guid("4f0614af-91f0-4f0b-9f0a-864cd28339cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptShowStartProcess;
		public ProcessScriptTask ScriptShowStartProcess {
			get {
				return _scriptShowStartProcess ?? (_scriptShowStartProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptShowStartProcess",
					SchemaElementUId = new Guid("e747b89d-d683-4c6e-a017-7650e52823b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptShowStartProcessExecute,
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
					SchemaElementUId = new Guid("524e66a4-a053-4ea8-898e-cb9361aba8fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _errorCheckRequiredLDAPSettings;
		public ProcessFlowElement ErrorCheckRequiredLDAPSettings {
			get {
				return _errorCheckRequiredLDAPSettings ?? (_errorCheckRequiredLDAPSettings = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ErrorCheckRequiredLDAPSettings",
					SchemaElementUId = new Guid("ca546d89-405a-447c-a00c-5af310cdd73e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptErrorCheckRequiredLDAPSettings;
		public ProcessScriptTask ScriptErrorCheckRequiredLDAPSettings {
			get {
				return _scriptErrorCheckRequiredLDAPSettings ?? (_scriptErrorCheckRequiredLDAPSettings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptErrorCheckRequiredLDAPSettings",
					SchemaElementUId = new Guid("fe930371-0739-4b82-ad7b-784a41697630"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptErrorCheckRequiredLDAPSettingsExecute,
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
					SchemaElementUId = new Guid("86fa20ce-4729-4217-abb1-08daaffb8b94"),
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
					SchemaElementUId = new Guid("753bba86-fa6f-4900-a025-e934caca069b"),
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
					SchemaElementUId = new Guid("8859912c-41a8-4eba-9b5e-db0a3c1d1ac5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
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
					SchemaElementUId = new Guid("5e6e5888-d8a7-48db-acc4-4d29ed2ce017"),
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
					SchemaElementUId = new Guid("1a88a3db-d2bd-485f-8849-fdec99dff48a"),
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
					SchemaElementUId = new Guid("2444c3b3-15a8-4d2e-b538-a14b8c25ce9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadEventSubProcess;
		public ProcessFlowElement PageLoadEventSubProcess {
			get {
				return _pageLoadEventSubProcess ?? (_pageLoadEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadEventSubProcess",
					SchemaElementUId = new Guid("790ebc80-b078-40fe-a09d-f1b3da2bf5e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageNonInterruptingEvent1;
		public ProcessFlowElement StartMessageNonInterruptingEvent1 {
			get {
				return _startMessageNonInterruptingEvent1 ?? (_startMessageNonInterruptingEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageNonInterruptingEvent1",
					SchemaElementUId = new Guid("a18309ca-d658-47cb-a6d3-c29ef17f5f19"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadScriptTask;
		public ProcessScriptTask PageLoadScriptTask {
			get {
				return _pageLoadScriptTask ?? (_pageLoadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadScriptTask",
					SchemaElementUId = new Guid("c51b2c11-6171-4ca9-94d7-e25ae4d55857"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessGlobalSearch;
		public ProcessFlowElement EventSubProcessGlobalSearch {
			get {
				return _eventSubProcessGlobalSearch ?? (_eventSubProcessGlobalSearch = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessGlobalSearch",
					SchemaElementUId = new Guid("f723cb40-789e-4273-918f-6aa27263aed4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startGlobalSearch;
		public ProcessFlowElement StartGlobalSearch {
			get {
				return _startGlobalSearch ?? (_startGlobalSearch = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartGlobalSearch",
					SchemaElementUId = new Guid("e8b65e17-88ed-4140-861c-a27b2fb0534b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptGlobalSearch;
		public ProcessScriptTask ScriptGlobalSearch {
			get {
				return _scriptGlobalSearch ?? (_scriptGlobalSearch = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptGlobalSearch",
					SchemaElementUId = new Guid("ee6a1214-b865-4559-9fd3-54e8c2bf59e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGlobalSearchExecute,
				});
			}
		}

		private ProcessFlowElement _startClearToolButtonClick;
		public ProcessFlowElement StartClearToolButtonClick {
			get {
				return _startClearToolButtonClick ?? (_startClearToolButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartClearToolButtonClick",
					SchemaElementUId = new Guid("cdace97d-c0e6-4826-a0c7-c5dc073ca749"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptClearToolButtonClick;
		public ProcessScriptTask ScriptClearToolButtonClick {
			get {
				return _scriptClearToolButtonClick ?? (_scriptClearToolButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptClearToolButtonClick",
					SchemaElementUId = new Guid("b361495a-2d74-46f4-b5f9-f6d0e76f6562"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptClearToolButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _startChangeSearchModule;
		public ProcessFlowElement StartChangeSearchModule {
			get {
				return _startChangeSearchModule ?? (_startChangeSearchModule = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartChangeSearchModule",
					SchemaElementUId = new Guid("6885e5fc-3f63-4e5e-a3f1-107daa1c2628"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChangeSearchModule;
		public ProcessScriptTask ScriptChangeSearchModule {
			get {
				return _scriptChangeSearchModule ?? (_scriptChangeSearchModule = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChangeSearchModule",
					SchemaElementUId = new Guid("c9f983a6-98c9-4715-8cd2-f95fdfd3e241"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChangeSearchModuleExecute,
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
					SchemaElementUId = new Guid("dcec21b9-a379-458d-be47-ef8ac4933082"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _welcomeScreenClosedScriptTask;
		public ProcessScriptTask WelcomeScreenClosedScriptTask {
			get {
				return _welcomeScreenClosedScriptTask ?? (_welcomeScreenClosedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "WelcomeScreenClosedScriptTask",
					SchemaElementUId = new Guid("2adf5ea1-6ddd-4a27-8781-f8c6e6672edf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = WelcomeScreenClosedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _welcomeScreenClosedStartMessage;
		public ProcessFlowElement WelcomeScreenClosedStartMessage {
			get {
				return _welcomeScreenClosedStartMessage ?? (_welcomeScreenClosedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WelcomeScreenClosedStartMessage",
					SchemaElementUId = new Guid("f59859f0-7215-44e4-a591-a96a5efa6039"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("ba9c1aa8-54e9-47b8-9b7b-5bc14ad6ca06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _showWelcomeScreenClickStartMessage;
		public ProcessFlowElement ShowWelcomeScreenClickStartMessage {
			get {
				return _showWelcomeScreenClickStartMessage ?? (_showWelcomeScreenClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ShowWelcomeScreenClickStartMessage",
					SchemaElementUId = new Guid("e00efa9c-3d00-4469-9aff-1bc42424bc34"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _showWelcomeScreenClickScriptTask;
		public ProcessScriptTask ShowWelcomeScreenClickScriptTask {
			get {
				return _showWelcomeScreenClickScriptTask ?? (_showWelcomeScreenClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowWelcomeScreenClickScriptTask",
					SchemaElementUId = new Guid("b366f944-3e81-43be-afa0-3a4905580191"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowWelcomeScreenClickScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow89;
		public ProcessConditionalFlow SequenceFlow89 {
			get {
				return _sequenceFlow89 ?? (_sequenceFlow89 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow89",
					SchemaElementUId = new Guid("845bec74-2d91-45bb-aa77-b2db046729e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _mailboxSettingsConditionalFlow;
		public ProcessConditionalFlow MailboxSettingsConditionalFlow {
			get {
				return _mailboxSettingsConditionalFlow ?? (_mailboxSettingsConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "MailboxSettingsConditionalFlow",
					SchemaElementUId = new Guid("9d2e8972-9675-4586-b15d-acdba447a457"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
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

		private LocalizableString _runFromRunProcessButtonErrorCaption;
		public LocalizableString RunFromRunProcessButtonErrorCaption {
			get {
				return _runFromRunProcessButtonErrorCaption ?? (_runFromRunProcessButtonErrorCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RunFromRunProcessButtonErrorCaption.Value"));
			}
		}

		private LocalizableString _runFromRunProcessButtonErrorMessage;
		public LocalizableString RunFromRunProcessButtonErrorMessage {
			get {
				return _runFromRunProcessButtonErrorMessage ?? (_runFromRunProcessButtonErrorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RunFromRunProcessButtonErrorMessage.Value"));
			}
		}

		private LocalizableString _messagePanelRemindingMessage;
		public LocalizableString MessagePanelRemindingMessage {
			get {
				return _messagePanelRemindingMessage ?? (_messagePanelRemindingMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.MessagePanelRemindingMessage.Value"));
			}
		}

		private LocalizableString _messagePanelShowLinkText;
		public LocalizableString MessagePanelShowLinkText {
			get {
				return _messagePanelShowLinkText ?? (_messagePanelShowLinkText = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.MessagePanelShowLinkText.Value"));
			}
		}

		private LocalizableString _popupInfoMessage;
		public LocalizableString PopupInfoMessage {
			get {
				return _popupInfoMessage ?? (_popupInfoMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PopupInfoMessage.Value"));
			}
		}

		private LocalizableString _attentionCaption;
		public LocalizableString AttentionCaption {
			get {
				return _attentionCaption ?? (_attentionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AttentionCaption.Value"));
			}
		}

		private LocalizableString _popupInfoMessageLinkCaption;
		public LocalizableString PopupInfoMessageLinkCaption {
			get {
				return _popupInfoMessageLinkCaption ?? (_popupInfoMessageLinkCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PopupInfoMessageLinkCaption.Value"));
			}
		}

		private LocalizableString _userGuideFileName;
		public LocalizableString UserGuideFileName {
			get {
				return _userGuideFileName ?? (_userGuideFileName = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UserGuideFileName.Value"));
			}
		}

		private LocalizableString _configGuideFileName;
		public LocalizableString ConfigGuideFileName {
			get {
				return _configGuideFileName ?? (_configGuideFileName = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ConfigGuideFileName.Value"));
			}
		}

		private LocalizableString _exitLinkCaption;
		public LocalizableString ExitLinkCaption {
			get {
				return _exitLinkCaption ?? (_exitLinkCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ExitLinkCaption.Value"));
			}
		}

		private LocalizableString _lDAPUsersWereAddedLS;
		public LocalizableString LDAPUsersWereAddedLS {
			get {
				return _lDAPUsersWereAddedLS ?? (_lDAPUsersWereAddedLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LDAPUsersWereAddedLS.Value"));
			}
		}

		private LocalizableString _processSynchWithLDAPLaunchedLS;
		public LocalizableString ProcessSynchWithLDAPLaunchedLS {
			get {
				return _processSynchWithLDAPLaunchedLS ?? (_processSynchWithLDAPLaunchedLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ProcessSynchWithLDAPLaunchedLS.Value"));
			}
		}

		private LocalizableString _openLDAPUsersListLS;
		public LocalizableString OpenLDAPUsersListLS {
			get {
				return _openLDAPUsersListLS ?? (_openLDAPUsersListLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OpenLDAPUsersListLS.Value"));
			}
		}

		private LocalizableString _errorCheckRequiredLDAPSettingsLS;
		public LocalizableString ErrorCheckRequiredLDAPSettingsLS {
			get {
				return _errorCheckRequiredLDAPSettingsLS ?? (_errorCheckRequiredLDAPSettingsLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ErrorCheckRequiredLDAPSettingsLS.Value"));
			}
		}

		private LocalizableString _chatLinkCaption;
		public LocalizableString ChatLinkCaption {
			get {
				return _chatLinkCaption ?? (_chatLinkCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChatLinkCaption.Value"));
			}
		}

		private LocalizableString _buyLinkCaption;
		public LocalizableString BuyLinkCaption {
			get {
				return _buyLinkCaption ?? (_buyLinkCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.BuyLinkCaption.Value"));
			}
		}

		private LocalizableString _buyLinkUrl;
		public LocalizableString BuyLinkUrl {
			get {
				return _buyLinkUrl ?? (_buyLinkUrl = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.BuyLinkUrl.Value"));
			}
		}

		private LocalizableString _startTuningModeMessage;
		public LocalizableString StartTuningModeMessage {
			get {
				return _startTuningModeMessage ?? (_startTuningModeMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.StartTuningModeMessage.Value"));
			}
		}

		private LocalizableString _schemaLocalizableString1;
		public LocalizableString SchemaLocalizableString1 {
			get {
				return _schemaLocalizableString1 ?? (_schemaLocalizableString1 = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SchemaLocalizableString1.Value"));
			}
		}

		private LocalizableString _endTuningModeMessage;
		public LocalizableString EndTuningModeMessage {
			get {
				return _endTuningModeMessage ?? (_endTuningModeMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EndTuningModeMessage.Value"));
			}
		}

		private LocalizableString _tuningModeIsNotImplementedMessage;
		public LocalizableString TuningModeIsNotImplementedMessage {
			get {
				return _tuningModeIsNotImplementedMessage ?? (_tuningModeIsNotImplementedMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TuningModeIsNotImplementedMessage.Value"));
			}
		}

		private LocalizableString _setOnSettingsModeSettingsButtonMenuItemCaption;
		public LocalizableString SetOnSettingsModeSettingsButtonMenuItemCaption {
			get {
				return _setOnSettingsModeSettingsButtonMenuItemCaption ?? (_setOnSettingsModeSettingsButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SetOnSettingsModeSettingsButtonMenuItemCaption.Value"));
			}
		}

		private LocalizableString _imapServersSettingsSettingsButtonMenuItemCaption;
		public LocalizableString ImapServersSettingsSettingsButtonMenuItemCaption {
			get {
				return _imapServersSettingsSettingsButtonMenuItemCaption ?? (_imapServersSettingsSettingsButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImapServersSettingsSettingsButtonMenuItemCaption.Value"));
			}
		}

		private LocalizableString _setOffSettingsModeSettingsButtonMenuItemCaption;
		public LocalizableString SetOffSettingsModeSettingsButtonMenuItemCaption {
			get {
				return _setOffSettingsModeSettingsButtonMenuItemCaption ?? (_setOffSettingsModeSettingsButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SetOffSettingsModeSettingsButtonMenuItemCaption.Value"));
			}
		}

		private LocalizableString _imapNewMails;
		public LocalizableString ImapNewMails {
			get {
				return _imapNewMails ?? (_imapNewMails = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImapNewMails.Value"));
			}
		}

		private LocalizableString _imapIncorrectNewMails;
		public LocalizableString ImapIncorrectNewMails {
			get {
				return _imapIncorrectNewMails ?? (_imapIncorrectNewMails = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImapIncorrectNewMails.Value"));
			}
		}

		private LocalizableString _messagePanelSetNowLinkText;
		public LocalizableString MessagePanelSetNowLinkText {
			get {
				return _messagePanelSetNowLinkText ?? (_messagePanelSetNowLinkText = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.MessagePanelSetNowLinkText.Value"));
			}
		}

		private LocalizableString _editSocialAccountsButtonMenuItemCaption;
		public LocalizableString EditSocialAccountsButtonMenuItemCaption {
			get {
				return _editSocialAccountsButtonMenuItemCaption ?? (_editSocialAccountsButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EditSocialAccountsButtonMenuItemCaption.Value"));
			}
		}

		private LocalizableString _chatLinkUrl;
		public LocalizableString ChatLinkUrl {
			get {
				return _chatLinkUrl ?? (_chatLinkUrl = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChatLinkUrl.Value"));
			}
		}

		private LocalizableString _licensesSettingsButtonMenuItemCaption;
		public LocalizableString LicensesSettingsButtonMenuItemCaption {
			get {
				return _licensesSettingsButtonMenuItemCaption ?? (_licensesSettingsButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LicensesSettingsButtonMenuItemCaption.Value"));
			}
		}

		private LocalizableString _dontShowCheckboxCaption;
		public LocalizableString DontShowCheckboxCaption {
			get {
				return _dontShowCheckboxCaption ?? (_dontShowCheckboxCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DontShowCheckboxCaption.Value"));
			}
		}

		private LocalizableString _closeInformationWindowCaption;
		public LocalizableString CloseInformationWindowCaption {
			get {
				return _closeInformationWindowCaption ?? (_closeInformationWindowCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CloseInformationWindowCaption.Value"));
			}
		}

		private LocalizableString _welcomeScreenCaption;
		public LocalizableString WelcomeScreenCaption {
			get {
				return _welcomeScreenCaption ?? (_welcomeScreenCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WelcomeScreenCaption.Value"));
			}
		}

		private LocalizableString _editTelephonyButtonMenuItemCaption;
		public LocalizableString EditTelephonyButtonMenuItemCaption {
			get {
				return _editTelephonyButtonMenuItemCaption ?? (_editTelephonyButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EditTelephonyButtonMenuItemCaption.Value"));
			}
		}

		private LocalizableString _cCSettingsOpenFailCaption;
		public LocalizableString CCSettingsOpenFailCaption {
			get {
				return _cCSettingsOpenFailCaption ?? (_cCSettingsOpenFailCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CCSettingsOpenFailCaption.Value"));
			}
		}

		private LocalizableString _cCSettingsOpenFailMsg;
		public LocalizableString CCSettingsOpenFailMsg {
			get {
				return _cCSettingsOpenFailMsg ?? (_cCSettingsOpenFailMsg = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CCSettingsOpenFailMsg.Value"));
			}
		}

		private LocalizableString _setMailChimpSettingsButtonMenuItemCaption;
		public LocalizableString SetMailChimpSettingsButtonMenuItemCaption {
			get {
				return _setMailChimpSettingsButtonMenuItemCaption ?? (_setMailChimpSettingsButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SetMailChimpSettingsButtonMenuItemCaption.Value"));
			}
		}

		private LocalizableString _openIntegrationLogButtonMenuItemCaption;
		public LocalizableString OpenIntegrationLogButtonMenuItemCaption {
			get {
				return _openIntegrationLogButtonMenuItemCaption ?? (_openIntegrationLogButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OpenIntegrationLogButtonMenuItemCaption.Value"));
			}
		}

		private LocalizableString _commandGenerationButtonMenuItemCaption;
		public LocalizableString CommandGenerationButtonMenuItemCaption {
			get {
				return _commandGenerationButtonMenuItemCaption ?? (_commandGenerationButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CommandGenerationButtonMenuItemCaption.Value"));
			}
		}

		private LocalizableString _importButtonMenuItemCaption;
		public LocalizableString ImportButtonMenuItemCaption {
			get {
				return _importButtonMenuItemCaption ?? (_importButtonMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImportButtonMenuItemCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[ExitButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ExitButtonClickStartMessage };
			FlowElements[ExitButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ExitButtonClickScriptTask };
			FlowElements[RemindingsPageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingsPageEventSubProcess };
			FlowElements[StartMessage2q.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2q };
			FlowElements[RemindingsPageParamsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindingsPageParamsScriptTask };
			FlowElements[ShowRemindingsUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowRemindingsUserTask };
			FlowElements[SettingsModeSettingsButtonMenuItemEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SettingsModeSettingsButtonMenuItemEventSubProcess };
			FlowElements[SettingsModeSettingsButtonMenuItemEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SettingsModeSettingsButtonMenuItemEvent };
			FlowElements[SettingsButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SettingsButtonClickScript };
			FlowElements[ScriptTaskPrepeareInformation.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPrepeareInformation };
			FlowElements[ImapServersSettingsSettingsButtonMenuItemEventEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ImapServersSettingsSettingsButtonMenuItemEventEventSubProcess };
			FlowElements[ImapServersSettingsSettingsButtonMenuItemEventStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ImapServersSettingsSettingsButtonMenuItemEventStartMessage };
			FlowElements[ImapServersSettingsSettingsButtonMenuItemEventScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ImapServersSettingsSettingsButtonMenuItemEventScriptTask };
			FlowElements[OpenImapServersSettingsUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenImapServersSettingsUserTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[EditSocialAccountsButtonMenuItemEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { EditSocialAccountsButtonMenuItemEvent };
			FlowElements[OpenSocialAccountGridScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenSocialAccountGridScriptTask };
			FlowElements[OpenSocialAccountGridPage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenSocialAccountGridPage };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[LicensesSettingsButtonMenuItemEventScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LicensesSettingsButtonMenuItemEventScriptTask };
			FlowElements[OpenLicPage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLicPage };
			FlowElements[SetMailChimpSettingsButtonMenuItemEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SetMailChimpSettingsButtonMenuItemEventSubProcess };
			FlowElements[SetMailChimpSettingsButtonMenuItemEventStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SetMailChimpSettingsButtonMenuItemEventStartMessage };
			FlowElements[SetMailChimpSettingsButtonMenuItemEventUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetMailChimpSettingsButtonMenuItemEventUserTask };
			FlowElements[SetMailChimpIntegrationSettingPrepareScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetMailChimpIntegrationSettingPrepareScriptTask };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[SetIntegrationLogMenuItemEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SetIntegrationLogMenuItemEvent };
			FlowElements[PreparePageParametersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PreparePageParametersScriptTask };
			FlowElements[OpenIntegrationLogUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenIntegrationLogUserTask };
			FlowElements[ImportButtonMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ImportButtonMenuItemClickStartMessage };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[OpenImportPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenImportPageUserTask };
			FlowElements[CommandGenerationButtonMenuItemEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CommandGenerationButtonMenuItemEventSubProcess };
			FlowElements[CommandGenerationButtonMenuItemEventStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CommandGenerationButtonMenuItemEventStartMessage };
			FlowElements[CommandGenerationButtonMenuItemScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CommandGenerationButtonMenuItemScriptTask };
			FlowElements[FindSelectedModuleSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { FindSelectedModuleSubProcess };
			FlowElements[FindSelectedModule.SchemaElementUId] = new Collection<ProcessFlowElement> { FindSelectedModule };
			FlowElements[ScriptFindSelectedModuleSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptFindSelectedModuleSubProcess };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[SelectAndRunProcessEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectAndRunProcessEvent };
			FlowElements[SelectAndRunProcessScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectAndRunProcessScript };
			FlowElements[LookupGridPageClosedEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosedEvent };
			FlowElements[RunProcessScript.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcessScript };
			FlowElements[OpenSelectDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenSelectDataUserTask };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[ShowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMessageEvent };
			FlowElements[MessageWindowUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MessageWindowUserTask };
			FlowElements[SubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess3 };
			FlowElements[SettingsChangedEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SettingsChangedEvent };
			FlowElements[SettingsChangedScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SettingsChangedScript };
			FlowElements[SubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess4 };
			FlowElements[MessagePanelLinkClick.SchemaElementUId] = new Collection<ProcessFlowElement> { MessagePanelLinkClick };
			FlowElements[LinkClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkClickScriptTask };
			FlowElements[ShowDefinedPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowDefinedPageUserTask };
			FlowElements[ShowRemindingsUserTaskInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowRemindingsUserTaskInit };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[MailboxSettingsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSettingsScriptTask };
			FlowElements[SubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess5 };
			FlowElements[MoveToModule.SchemaElementUId] = new Collection<ProcessFlowElement> { MoveToModule };
			FlowElements[MoveToModuleScript.SchemaElementUId] = new Collection<ProcessFlowElement> { MoveToModuleScript };
			FlowElements[HelpCalledEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { HelpCalledEventSubProcess };
			FlowElements[HelpCalledStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { HelpCalledStartMessage };
			FlowElements[ScriptHelpCalled.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptHelpCalled };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[MessagePanelMessageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { MessagePanelMessageClosed };
			FlowElements[ScriptMessagePanelMessageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptMessagePanelMessageClosed };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[DoShowLDAPMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DoShowLDAPMessage };
			FlowElements[ScriptDoShowLDAPMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDoShowLDAPMessage };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[ShowStartProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowStartProcess };
			FlowElements[ScriptShowStartProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptShowStartProcess };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[ErrorCheckRequiredLDAPSettings.SchemaElementUId] = new Collection<ProcessFlowElement> { ErrorCheckRequiredLDAPSettings };
			FlowElements[ScriptErrorCheckRequiredLDAPSettings.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptErrorCheckRequiredLDAPSettings };
			FlowElements[InitSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitSubProcess };
			FlowElements[Init.SchemaElementUId] = new Collection<ProcessFlowElement> { Init };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[PageLoadCompleteSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteSubProcess };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[PageLoadEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadEventSubProcess };
			FlowElements[StartMessageNonInterruptingEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageNonInterruptingEvent1 };
			FlowElements[PageLoadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadScriptTask };
			FlowElements[EventSubProcessGlobalSearch.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessGlobalSearch };
			FlowElements[StartGlobalSearch.SchemaElementUId] = new Collection<ProcessFlowElement> { StartGlobalSearch };
			FlowElements[ScriptGlobalSearch.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGlobalSearch };
			FlowElements[StartClearToolButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartClearToolButtonClick };
			FlowElements[ScriptClearToolButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptClearToolButtonClick };
			FlowElements[StartChangeSearchModule.SchemaElementUId] = new Collection<ProcessFlowElement> { StartChangeSearchModule };
			FlowElements[ScriptChangeSearchModule.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChangeSearchModule };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[WelcomeScreenClosedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { WelcomeScreenClosedScriptTask };
			FlowElements[WelcomeScreenClosedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { WelcomeScreenClosedStartMessage };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[ShowWelcomeScreenClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowWelcomeScreenClickStartMessage };
			FlowElements[ShowWelcomeScreenClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowWelcomeScreenClickScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess10":
						break;
					case "ExitButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ExitButtonClickScriptTask");
						break;
					case "ExitButtonClickScriptTask":
						break;
					case "RemindingsPageEventSubProcess":
						break;
					case "StartMessage2q":
						e.Context.QueueTasks.Enqueue("RemindingsPageParamsScriptTask");
						break;
					case "RemindingsPageParamsScriptTask":
						e.Context.QueueTasks.Enqueue("ShowRemindingsUserTask");
						break;
					case "ShowRemindingsUserTask":
						break;
					case "SettingsModeSettingsButtonMenuItemEventSubProcess":
						break;
					case "SettingsModeSettingsButtonMenuItemEvent":
						e.Context.QueueTasks.Enqueue("SettingsButtonClickScript");
						break;
					case "SettingsButtonClickScript":
						e.Context.QueueTasks.Enqueue("ScriptTaskPrepeareInformation");
						break;
					case "ScriptTaskPrepeareInformation":
						break;
					case "ImapServersSettingsSettingsButtonMenuItemEventEventSubProcess":
						break;
					case "ImapServersSettingsSettingsButtonMenuItemEventStartMessage":
						e.Context.QueueTasks.Enqueue("ImapServersSettingsSettingsButtonMenuItemEventScriptTask");
						break;
					case "ImapServersSettingsSettingsButtonMenuItemEventScriptTask":
						e.Context.QueueTasks.Enqueue("OpenImapServersSettingsUserTask");
						break;
					case "OpenImapServersSettingsUserTask":
						break;
					case "EventSubProcess1":
						break;
					case "EditSocialAccountsButtonMenuItemEvent":
						e.Context.QueueTasks.Enqueue("OpenSocialAccountGridScriptTask");
						break;
					case "OpenSocialAccountGridScriptTask":
						e.Context.QueueTasks.Enqueue("OpenSocialAccountGridPage");
						break;
					case "OpenSocialAccountGridPage":
						break;
					case "EventSubProcess5":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("LicensesSettingsButtonMenuItemEventScriptTask");
						break;
					case "LicensesSettingsButtonMenuItemEventScriptTask":
						e.Context.QueueTasks.Enqueue("OpenLicPage");
						break;
					case "OpenLicPage":
						break;
					case "SetMailChimpSettingsButtonMenuItemEventSubProcess":
						break;
					case "SetMailChimpSettingsButtonMenuItemEventStartMessage":
						e.Context.QueueTasks.Enqueue("SetMailChimpIntegrationSettingPrepareScriptTask");
						break;
					case "SetMailChimpSettingsButtonMenuItemEventUserTask":
						break;
					case "SetMailChimpIntegrationSettingPrepareScriptTask":
						e.Context.QueueTasks.Enqueue("SetMailChimpSettingsButtonMenuItemEventUserTask");
						break;
					case "EventSubProcess12":
						break;
					case "SetIntegrationLogMenuItemEvent":
						e.Context.QueueTasks.Enqueue("PreparePageParametersScriptTask");
						break;
					case "PreparePageParametersScriptTask":
						e.Context.QueueTasks.Enqueue("OpenIntegrationLogUserTask");
						break;
					case "OpenIntegrationLogUserTask":
						break;
					case "ImportButtonMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("OpenImportPageUserTask");
						break;
					case "OpenImportPageUserTask":
						break;
					case "CommandGenerationButtonMenuItemEventSubProcess":
						break;
					case "CommandGenerationButtonMenuItemEventStartMessage":
						e.Context.QueueTasks.Enqueue("CommandGenerationButtonMenuItemScriptTask");
						break;
					case "CommandGenerationButtonMenuItemScriptTask":
						break;
					case "FindSelectedModuleSubProcess":
						break;
					case "FindSelectedModule":
						e.Context.QueueTasks.Enqueue("ScriptFindSelectedModuleSubProcess");
						break;
					case "ScriptFindSelectedModuleSubProcess":
						break;
					case "SubProcess1":
						break;
					case "SelectAndRunProcessEvent":
						e.Context.QueueTasks.Enqueue("SelectAndRunProcessScript");
						break;
					case "SelectAndRunProcessScript":
						e.Context.QueueTasks.Enqueue("OpenSelectDataUserTask");
						break;
					case "LookupGridPageClosedEvent":
						e.Context.QueueTasks.Enqueue("RunProcessScript");
						break;
					case "RunProcessScript":
						break;
					case "OpenSelectDataUserTask":
						ActivatedEventElements.Add("LookupGridPageClosedEvent");
						break;
					case "SubProcess2":
						break;
					case "ShowMessageEvent":
						e.Context.QueueTasks.Enqueue("MessageWindowUserTask");
						break;
					case "MessageWindowUserTask":
						break;
					case "SubProcess3":
						break;
					case "SettingsChangedEvent":
						e.Context.QueueTasks.Enqueue("SettingsChangedScript");
						break;
					case "SettingsChangedScript":
						break;
					case "SubProcess4":
						break;
					case "MessagePanelLinkClick":
						e.Context.QueueTasks.Enqueue("LinkClickScriptTask");
						break;
					case "LinkClickScriptTask":
						if (SequenceFlow89ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("ShowRemindingsUserTaskInit");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						if (MailboxSettingsConditionalFlowExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("MailboxSettingsScriptTask");
							break;
						}
						break;
					case "ShowDefinedPageUserTask":
						break;
					case "ShowRemindingsUserTaskInit":
						e.Context.QueueTasks.Enqueue("ShowDefinedPageUserTask");
						break;
					case "ScriptTask3":
						break;
					case "MailboxSettingsScriptTask":
						e.Context.QueueTasks.Enqueue("ShowDefinedPageUserTask");
						break;
					case "SubProcess5":
						break;
					case "MoveToModule":
						e.Context.QueueTasks.Enqueue("MoveToModuleScript");
						break;
					case "MoveToModuleScript":
						break;
					case "HelpCalledEventSubProcess":
						break;
					case "HelpCalledStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptHelpCalled");
						break;
					case "ScriptHelpCalled":
						break;
					case "EventSubProcess6":
						break;
					case "MessagePanelMessageClosed":
						e.Context.QueueTasks.Enqueue("ScriptMessagePanelMessageClosed");
						break;
					case "ScriptMessagePanelMessageClosed":
						break;
					case "EventSubProcess2":
						break;
					case "DoShowLDAPMessage":
						e.Context.QueueTasks.Enqueue("ScriptDoShowLDAPMessage");
						break;
					case "ScriptDoShowLDAPMessage":
						break;
					case "EventSubProcess4":
						break;
					case "ShowStartProcess":
						e.Context.QueueTasks.Enqueue("ScriptShowStartProcess");
						break;
					case "ScriptShowStartProcess":
						break;
					case "EventSubProcess7":
						break;
					case "ErrorCheckRequiredLDAPSettings":
						e.Context.QueueTasks.Enqueue("ScriptErrorCheckRequiredLDAPSettings");
						break;
					case "ScriptErrorCheckRequiredLDAPSettings":
						break;
					case "InitSubProcess":
						break;
					case "Init":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "PageLoadCompleteSubProcess":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "PageLoadEventSubProcess":
						break;
					case "StartMessageNonInterruptingEvent1":
						e.Context.QueueTasks.Enqueue("PageLoadScriptTask");
						break;
					case "PageLoadScriptTask":
						break;
					case "EventSubProcessGlobalSearch":
						break;
					case "StartGlobalSearch":
						e.Context.QueueTasks.Enqueue("ScriptGlobalSearch");
						break;
					case "ScriptGlobalSearch":
						break;
					case "StartClearToolButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptClearToolButtonClick");
						break;
					case "ScriptClearToolButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptGlobalSearch");
						break;
					case "StartChangeSearchModule":
						e.Context.QueueTasks.Enqueue("ScriptChangeSearchModule");
						break;
					case "ScriptChangeSearchModule":
						break;
					case "EventSubProcess8":
						break;
					case "WelcomeScreenClosedScriptTask":
						break;
					case "WelcomeScreenClosedStartMessage":
						e.Context.QueueTasks.Enqueue("WelcomeScreenClosedScriptTask");
						break;
					case "EventSubProcess9":
						break;
					case "ShowWelcomeScreenClickStartMessage":
						e.Context.QueueTasks.Enqueue("ShowWelcomeScreenClickScriptTask");
						break;
					case "ShowWelcomeScreenClickScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow89ExpressionExecute() {
			return Convert.ToBoolean(MessagePanelClickedLinkId == RemindingsPageUId.ToString());
		}

		private bool MailboxSettingsConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(MessagePanelClickedLinkId == MailboxSynchronizationSettingsPageUId.ToString());
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ExitButtonClickStartMessage");
			ActivatedEventElements.Add("StartMessage2q");
			ActivatedEventElements.Add("SettingsModeSettingsButtonMenuItemEvent");
			ActivatedEventElements.Add("ImapServersSettingsSettingsButtonMenuItemEventStartMessage");
			ActivatedEventElements.Add("EditSocialAccountsButtonMenuItemEvent");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("SetMailChimpSettingsButtonMenuItemEventStartMessage");
			ActivatedEventElements.Add("SetIntegrationLogMenuItemEvent");
			ActivatedEventElements.Add("ImportButtonMenuItemClickStartMessage");
			ActivatedEventElements.Add("CommandGenerationButtonMenuItemEventStartMessage");
			ActivatedEventElements.Add("FindSelectedModule");
			ActivatedEventElements.Add("SelectAndRunProcessEvent");
			ActivatedEventElements.Add("ShowMessageEvent");
			ActivatedEventElements.Add("SettingsChangedEvent");
			ActivatedEventElements.Add("MessagePanelLinkClick");
			ActivatedEventElements.Add("MoveToModule");
			ActivatedEventElements.Add("HelpCalledStartMessage");
			ActivatedEventElements.Add("MessagePanelMessageClosed");
			ActivatedEventElements.Add("DoShowLDAPMessage");
			ActivatedEventElements.Add("ShowStartProcess");
			ActivatedEventElements.Add("ErrorCheckRequiredLDAPSettings");
			ActivatedEventElements.Add("Init");
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("StartMessageNonInterruptingEvent1");
			ActivatedEventElements.Add("StartGlobalSearch");
			ActivatedEventElements.Add("StartClearToolButtonClick");
			ActivatedEventElements.Add("StartChangeSearchModule");
			ActivatedEventElements.Add("WelcomeScreenClosedStartMessage");
			ActivatedEventElements.Add("ShowWelcomeScreenClickStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "ExitButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExitButtonClickStartMessage";
					result = ExitButtonClickStartMessage.Execute(context);
					break;
				case "ExitButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExitButtonClickScriptTask";
					result = ExitButtonClickScriptTask.Execute(context, ExitButtonClickScriptTaskExecute);
					break;
				case "RemindingsPageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2q":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2q";
					result = StartMessage2q.Execute(context);
					break;
				case "RemindingsPageParamsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemindingsPageParamsScriptTask";
					result = RemindingsPageParamsScriptTask.Execute(context, RemindingsPageParamsScriptTaskExecute);
					break;
				case "ShowRemindingsUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowRemindingsUserTask";
					result = ShowRemindingsUserTask.Execute(context);
					break;
				case "SettingsModeSettingsButtonMenuItemEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SettingsModeSettingsButtonMenuItemEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "SettingsModeSettingsButtonMenuItemEvent";
					result = SettingsModeSettingsButtonMenuItemEvent.Execute(context);
					break;
				case "SettingsButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SettingsButtonClickScript";
					result = SettingsButtonClickScript.Execute(context, SettingsButtonClickScriptExecute);
					break;
				case "ScriptTaskPrepeareInformation":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPrepeareInformation";
					result = ScriptTaskPrepeareInformation.Execute(context, ScriptTaskPrepeareInformationExecute);
					break;
				case "ImapServersSettingsSettingsButtonMenuItemEventEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ImapServersSettingsSettingsButtonMenuItemEventStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImapServersSettingsSettingsButtonMenuItemEventStartMessage";
					result = ImapServersSettingsSettingsButtonMenuItemEventStartMessage.Execute(context);
					break;
				case "ImapServersSettingsSettingsButtonMenuItemEventScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImapServersSettingsSettingsButtonMenuItemEventScriptTask";
					result = ImapServersSettingsSettingsButtonMenuItemEventScriptTask.Execute(context, ImapServersSettingsSettingsButtonMenuItemEventScriptTaskExecute);
					break;
				case "OpenImapServersSettingsUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenImapServersSettingsUserTask";
					result = OpenImapServersSettingsUserTask.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "EditSocialAccountsButtonMenuItemEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditSocialAccountsButtonMenuItemEvent";
					result = EditSocialAccountsButtonMenuItemEvent.Execute(context);
					break;
				case "OpenSocialAccountGridScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenSocialAccountGridScriptTask";
					result = OpenSocialAccountGridScriptTask.Execute(context, OpenSocialAccountGridScriptTaskExecute);
					break;
				case "OpenSocialAccountGridPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenSocialAccountGridPage";
					result = OpenSocialAccountGridPage.Execute(context);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "LicensesSettingsButtonMenuItemEventScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LicensesSettingsButtonMenuItemEventScriptTask";
					result = LicensesSettingsButtonMenuItemEventScriptTask.Execute(context, LicensesSettingsButtonMenuItemEventScriptTaskExecute);
					break;
				case "OpenLicPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLicPage";
					result = OpenLicPage.Execute(context);
					break;
				case "SetMailChimpSettingsButtonMenuItemEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SetMailChimpSettingsButtonMenuItemEventStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetMailChimpSettingsButtonMenuItemEventStartMessage";
					result = SetMailChimpSettingsButtonMenuItemEventStartMessage.Execute(context);
					break;
				case "SetMailChimpSettingsButtonMenuItemEventUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetMailChimpSettingsButtonMenuItemEventUserTask";
					result = SetMailChimpSettingsButtonMenuItemEventUserTask.Execute(context);
					break;
				case "SetMailChimpIntegrationSettingPrepareScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetMailChimpIntegrationSettingPrepareScriptTask";
					result = SetMailChimpIntegrationSettingPrepareScriptTask.Execute(context, SetMailChimpIntegrationSettingPrepareScriptTaskExecute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "SetIntegrationLogMenuItemEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetIntegrationLogMenuItemEvent";
					result = SetIntegrationLogMenuItemEvent.Execute(context);
					break;
				case "PreparePageParametersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PreparePageParametersScriptTask";
					result = PreparePageParametersScriptTask.Execute(context, PreparePageParametersScriptTaskExecute);
					break;
				case "OpenIntegrationLogUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenIntegrationLogUserTask";
					result = OpenIntegrationLogUserTask.Execute(context);
					break;
				case "ImportButtonMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImportButtonMenuItemClickStartMessage";
					result = ImportButtonMenuItemClickStartMessage.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "OpenImportPageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenImportPageUserTask";
					result = OpenImportPageUserTask.Execute(context);
					break;
				case "CommandGenerationButtonMenuItemEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CommandGenerationButtonMenuItemEventStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CommandGenerationButtonMenuItemEventStartMessage";
					result = CommandGenerationButtonMenuItemEventStartMessage.Execute(context);
					break;
				case "CommandGenerationButtonMenuItemScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CommandGenerationButtonMenuItemScriptTask";
					result = CommandGenerationButtonMenuItemScriptTask.Execute(context, CommandGenerationButtonMenuItemScriptTaskExecute);
					break;
				case "FindSelectedModuleSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "FindSelectedModule":
					context.QueueTasks.Dequeue();
					context.SenderName = "FindSelectedModule";
					result = FindSelectedModule.Execute(context);
					break;
				case "ScriptFindSelectedModuleSubProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptFindSelectedModuleSubProcess";
					result = ScriptFindSelectedModuleSubProcess.Execute(context, ScriptFindSelectedModuleSubProcessExecute);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SelectAndRunProcessEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectAndRunProcessEvent";
					result = SelectAndRunProcessEvent.Execute(context);
					break;
				case "SelectAndRunProcessScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectAndRunProcessScript";
					result = SelectAndRunProcessScript.Execute(context, SelectAndRunProcessScriptExecute);
					break;
				case "LookupGridPageClosedEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupGridPageClosedEvent";
					result = LookupGridPageClosedEvent.Execute(context);
					break;
				case "RunProcessScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "RunProcessScript";
					result = RunProcessScript.Execute(context, RunProcessScriptExecute);
					break;
				case "OpenSelectDataUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenSelectDataUserTask";
					result = OpenSelectDataUserTask.Execute(context);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ShowMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMessageEvent";
					result = ShowMessageEvent.Execute(context);
					break;
				case "MessageWindowUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MessageWindowUserTask";
					result = MessageWindowUserTask.Execute(context);
					break;
				case "SubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "SettingsChangedEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "SettingsChangedEvent";
					result = SettingsChangedEvent.Execute(context);
					break;
				case "SettingsChangedScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SettingsChangedScript";
					result = SettingsChangedScript.Execute(context, SettingsChangedScriptExecute);
					break;
				case "SubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "MessagePanelLinkClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "MessagePanelLinkClick";
					result = MessagePanelLinkClick.Execute(context);
					break;
				case "LinkClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LinkClickScriptTask";
					result = LinkClickScriptTask.Execute(context, LinkClickScriptTaskExecute);
					break;
				case "ShowDefinedPageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowDefinedPageUserTask";
					result = ShowDefinedPageUserTask.Execute(context);
					break;
				case "ShowRemindingsUserTaskInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowRemindingsUserTaskInit";
					result = ShowRemindingsUserTaskInit.Execute(context, ShowRemindingsUserTaskInitExecute);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "MailboxSettingsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSettingsScriptTask";
					result = MailboxSettingsScriptTask.Execute(context, MailboxSettingsScriptTaskExecute);
					break;
				case "SubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "MoveToModule":
					context.QueueTasks.Dequeue();
					context.SenderName = "MoveToModule";
					result = MoveToModule.Execute(context);
					break;
				case "MoveToModuleScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "MoveToModuleScript";
					result = MoveToModuleScript.Execute(context, MoveToModuleScriptExecute);
					break;
				case "HelpCalledEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "HelpCalledStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "HelpCalledStartMessage";
					result = HelpCalledStartMessage.Execute(context);
					break;
				case "ScriptHelpCalled":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptHelpCalled";
					result = ScriptHelpCalled.Execute(context, ScriptHelpCalledExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "MessagePanelMessageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "MessagePanelMessageClosed";
					result = MessagePanelMessageClosed.Execute(context);
					break;
				case "ScriptMessagePanelMessageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptMessagePanelMessageClosed";
					result = ScriptMessagePanelMessageClosed.Execute(context, ScriptMessagePanelMessageClosedExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "DoShowLDAPMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DoShowLDAPMessage";
					result = DoShowLDAPMessage.Execute(context);
					break;
				case "ScriptDoShowLDAPMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDoShowLDAPMessage";
					result = ScriptDoShowLDAPMessage.Execute(context, ScriptDoShowLDAPMessageExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "ShowStartProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowStartProcess";
					result = ShowStartProcess.Execute(context);
					break;
				case "ScriptShowStartProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptShowStartProcess";
					result = ScriptShowStartProcess.Execute(context, ScriptShowStartProcessExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "ErrorCheckRequiredLDAPSettings":
					context.QueueTasks.Dequeue();
					context.SenderName = "ErrorCheckRequiredLDAPSettings";
					result = ErrorCheckRequiredLDAPSettings.Execute(context);
					break;
				case "ScriptErrorCheckRequiredLDAPSettings":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptErrorCheckRequiredLDAPSettings";
					result = ScriptErrorCheckRequiredLDAPSettings.Execute(context, ScriptErrorCheckRequiredLDAPSettingsExecute);
					break;
				case "InitSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "Init":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init";
					result = Init.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "PageLoadCompleteSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete";
					result = PageLoadComplete.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "PageLoadEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageNonInterruptingEvent1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageNonInterruptingEvent1";
					result = StartMessageNonInterruptingEvent1.Execute(context);
					break;
				case "PageLoadScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadScriptTask";
					result = PageLoadScriptTask.Execute(context, PageLoadScriptTaskExecute);
					break;
				case "EventSubProcessGlobalSearch":
					context.QueueTasks.Dequeue();
					break;
				case "StartGlobalSearch":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartGlobalSearch";
					result = StartGlobalSearch.Execute(context);
					break;
				case "ScriptGlobalSearch":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGlobalSearch";
					result = ScriptGlobalSearch.Execute(context, ScriptGlobalSearchExecute);
					break;
				case "StartClearToolButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartClearToolButtonClick";
					result = StartClearToolButtonClick.Execute(context);
					break;
				case "ScriptClearToolButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptClearToolButtonClick";
					result = ScriptClearToolButtonClick.Execute(context, ScriptClearToolButtonClickExecute);
					break;
				case "StartChangeSearchModule":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartChangeSearchModule";
					result = StartChangeSearchModule.Execute(context);
					break;
				case "ScriptChangeSearchModule":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChangeSearchModule";
					result = ScriptChangeSearchModule.Execute(context, ScriptChangeSearchModuleExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "WelcomeScreenClosedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "WelcomeScreenClosedScriptTask";
					result = WelcomeScreenClosedScriptTask.Execute(context, WelcomeScreenClosedScriptTaskExecute);
					break;
				case "WelcomeScreenClosedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "WelcomeScreenClosedStartMessage";
					result = WelcomeScreenClosedStartMessage.Execute(context);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "ShowWelcomeScreenClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowWelcomeScreenClickStartMessage";
					result = ShowWelcomeScreenClickStartMessage.Execute(context);
					break;
				case "ShowWelcomeScreenClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowWelcomeScreenClickScriptTask";
					result = ShowWelcomeScreenClickScriptTask.Execute(context, ShowWelcomeScreenClickScriptTaskExecute);
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
				case "ImportButtonMenuItemTag":
					ImportButtonMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "ImportPageSchemaUId":
					ImportPageSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "CommandGenerationButtonMenuItemTag":
					CommandGenerationButtonMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "CanStartCommandGeneration":
					CanStartCommandGeneration = reader.GetValue<System.Boolean>();
				break;
				case "OpenIntegrationLogMenuItemTag":
					OpenIntegrationLogMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "IntegrationLogPageSchemaUId":
					IntegrationLogPageSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "SysMainPageShellClientId":
					SysMainPageShellClientId = reader.GetValue<System.String>();
				break;
				case "CanUseMailChimpIntegrationSettings":
					CanUseMailChimpIntegrationSettings = reader.GetValue<System.Boolean>();
				break;
				case "MailChimpSettingsPageSchemaUId":
					MailChimpSettingsPageSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "SetMailChimpSettingsButtonMenuItemTag":
					SetMailChimpSettingsButtonMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "SavedDataId":
					SavedDataId = reader.GetValue<System.Guid>();
				break;
				case "CallSessionDataKey":
					CallSessionDataKey = reader.GetValue<System.String>();
				break;
				case "IsDeveloperMode":
					IsDeveloperMode = reader.GetValue<System.Boolean>();
				break;
				case "SearchModuleId":
					SearchModuleId = reader.GetValue<System.Guid>();
				break;
				case "CanUseMsgService":
					CanUseMsgService = reader.GetValue<System.Boolean>();
				break;
				case "EditTelephonyButtonMenuItemTag":
					EditTelephonyButtonMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "SelectedModuleCaption":
					SelectedModuleCaption = reader.GetSerializableObjectValue();
				break;
				case "SelectedModuleHelpContextId":
					SelectedModuleHelpContextId = reader.GetValue<System.String>();
				break;
				case "SelectedModuleCode":
					SelectedModuleCode = reader.GetValue<System.String>();
				break;
				case "WelcomeScreenDataKey":
					WelcomeScreenDataKey = reader.GetValue<System.String>();
				break;
				case "IsDemoBuild":
					IsDemoBuild = reader.GetValue<System.Boolean>();
				break;
				case "LicensesSettingsButtonMenuItemTag":
					LicensesSettingsButtonMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "CanManageLicUsers":
					CanManageLicUsers = reader.GetValue<System.Boolean>();
				break;
				case "MsgToolInstance":
					MsgToolInstance = reader.GetSerializableObjectValue();
				break;
				case "EditSocialAccountsMenuItemTag":
					EditSocialAccountsMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "MailboxSynchronizationSettingsPageUId":
					MailboxSynchronizationSettingsPageUId = reader.GetValue<System.Guid>();
				break;
				case "SeparatorMenuItemTag":
					SeparatorMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "CanManageMailServers":
					CanManageMailServers = reader.GetValue<System.Boolean>();
				break;
				case "CanChangeApplicationTuningMode":
					CanChangeApplicationTuningMode = reader.GetValue<System.Boolean>();
				break;
				case "SettingsModeSettingsButtonMenuItemCaption":
					SettingsModeSettingsButtonMenuItemCaption = reader.GetValue<System.String>();
				break;
				case "MailServerSchemaUId":
					MailServerSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "ImapServersSettingsSettingsButtonMenuItemTag":
					ImapServersSettingsSettingsButtonMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "SettingsModeSettingsButtonMenuItemTag":
					SettingsModeSettingsButtonMenuItemTag = reader.GetValue<System.Guid>();
				break;
				case "TuningProcessMode":
					TuningProcessMode = reader.GetValue<System.Boolean>();
				break;
				case "IsTuningModule":
					IsTuningModule = reader.GetValue<System.Boolean>();
				break;
				case "CancelLDAPMessageId":
					CancelLDAPMessageId = reader.GetValue<System.Guid>();
				break;
				case "ShowLDAPMessageId":
					ShowLDAPMessageId = reader.GetValue<System.Guid>();
				break;
				case "CommunityLink":
					CommunityLink = reader.GetValue<System.String>();
				break;
				case "FAQLinkId":
					FAQLinkId = reader.GetValue<System.Guid>();
				break;
				case "MoveToParameters":
					MoveToParameters = reader.GetSerializableObjectValue();
				break;
				case "RemindingsPageUId":
					RemindingsPageUId = reader.GetValue<System.Guid>();
				break;
				case "MessagePanelClickedLinkId":
					MessagePanelClickedLinkId = reader.GetValue<System.String>();
				break;
				case "CheckingRemindingsInterval":
					CheckingRemindingsInterval = reader.GetValue<System.Int32>();
				break;
				case "GlobalSearchValue":
					GlobalSearchValue = reader.GetValue<System.String>();
				break;
				case "SelectedModuleId":
					SelectedModuleId = reader.GetValue<System.Guid>();
				break;
				case "FirstPageSchemaIdToLoad":
					FirstPageSchemaIdToLoad = reader.GetValue<System.Guid>();
				break;
				case "PageSchemaUId":
					PageSchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ExitButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool RemindingsPageParamsScriptTaskExecute(ProcessExecutingContext context) {
			RemindingsPageUId = new Guid("9d83cb5b-5aa3-4484-9d59-1c5e7b086a05");
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			string key = instanceId + Page.PageContainer.UniqueID;
			ShowRemindingsUserTask.OpenerInstanceId = key;
			ShowRemindingsUserTask.PageUId = RemindingsPageUId;
			ShowRemindingsUserTask.PageParameters = new Dictionary<string, string> {
				{"mainPageProcessUId", Page.Process.InstanceUId}
			};
			
			return true;
		}

		public virtual bool SettingsButtonClickScriptExecute(ProcessExecutingContext context) {
			//Page.AddScript("alert('', 'SettingsChanged')");
			var contentPageContainer = Page.ContentControlLayout.Items[0] as Terrasoft.UI.WebControls.Controls.PageContainer;
			var contentPage = contentPageContainer.PageInstance;
			contentPage.ThrowEvent("TuningModeChanged");
			return true;
		}

		public virtual bool ScriptTaskPrepeareInformationExecute(ProcessExecutingContext context) {
			string message = string.Empty;
			string moduleCaption = GetModuleCaption(SelectedModuleId);
			if (IsTuningModule) {
				message = TuningProcessMode ? string.Format(StartTuningModeMessage, moduleCaption) : EndTuningModeMessage.ToString();	
			} else {
				message = string.Format(TuningModeIsNotImplementedMessage, moduleCaption);	
			}
			if (TuningProcessMode) {
				SettingsModeSettingsButtonMenuItemCaption = SetOffSettingsModeSettingsButtonMenuItemCaption.ToString();
			} else {
				SettingsModeSettingsButtonMenuItemCaption = SetOnSettingsModeSettingsButtonMenuItemCaption.ToString();
			}
			CompleteSettingsButtonMenuItems();
			var messageId = "tuningModeMessage";
			Page.BaseMessagePanel.Remove(messageId);
			Page.BaseMessagePanel.AddMessage(messageId,
						ModuleProcessInstanceNotExistCaption, message, MessageType.Information);
			return true;
		}

		public virtual bool ImapServersSettingsSettingsButtonMenuItemEventScriptTaskExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenImapServersSettingsUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			OpenImapServersSettingsUserTask.PageParameters = new Dictionary <string, object>() {
					{"schemaUId", MailServerSchemaUId},
					{"lookupPageSchemaUId", "'e24018bf-4ef6-49ef-a331-4fdb6b742e4c'"},
					{"editMode", true},
					{"LookupFilters", new Collection<Dictionary<string, object>>()}
				};
			return true;
		}

		public virtual bool OpenSocialAccountGridScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchema socialAccountSchema = entitySchemaManager.GetInstanceByName("SocialAccount");
			string schemaUId = socialAccountSchema.UId.ToString();
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenSocialAccountGridPage.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			OpenSocialAccountGridPage.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)OpenSocialAccountGridPage.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			// 953eeaa2-d6ed-46a6-a673-5b8f6bf1d114
			pageParameters.Add("lookupPageSchemaUId", "'33cc4a3a-babb-464d-82a0-1b904d198d31'");
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			//// TODO change hardocde Guid of TSBpm on read from database
			if (!UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageLookups")) {
				filters.Add(new Dictionary<string, object> {
							 {"comparisonType", FilterComparisonType.Equal},
							 {"leftExpressionColumnPath", "User.Id"},
							 {"useDisplayValue", false },
							 {"rightExpressionParameterValues", new object[] {Page.UserConnection.CurrentUser.Id}}});
				pageParameters.Add("LookupFilters", filters);
			}
			pageParameters.Add("editMode", "true");	
			return true;
		}

		public virtual bool LicensesSettingsButtonMenuItemEventScriptTaskExecute(ProcessExecutingContext context) {
			OpenLicPage.OpenerInstanceId = InstanceUId;
			OpenLicPage.Width = 950;
			OpenLicPage.Height = 550;
			OpenLicPage.PageUrl = WebUtilities.GetUrlToLoaderPage(HttpContext.Current.Request, "/Lic/LicManager.aspx");
			return true;
		}

		public virtual bool SetMailChimpIntegrationSettingPrepareScriptTaskExecute(ProcessExecutingContext context) {
			SetMailChimpSettingsButtonMenuItemEventUserTask.OpenerInstanceId = InstanceUId;
			SetMailChimpSettingsButtonMenuItemEventUserTask.PageUId = MailChimpSettingsPageSchemaUId;
			return true;
		}

		public virtual bool PreparePageParametersScriptTaskExecute(ProcessExecutingContext context) {
			OpenIntegrationLogUserTask.OpenerInstanceId = InstanceUId;
			OpenIntegrationLogUserTask.PageUId = new Guid("49045869-5dc5-42d7-b93f-9e6e1d1027f7");
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			OpenImportPageUserTask.OpenerInstanceId = InstanceUId;
			OpenImportPageUserTask.PageUId = ImportPageSchemaUId;
			//if (SelectedModuleId != Guid.Empty) {
			//	var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModule");
			//	var schemaIdName = entitySchemaQuery.AddColumn("SysModuleEntity.SysEntitySchemaUId").Name;
			//	entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", SelectedModuleId));
			//	var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
			//	if (collection.Count > 0) {
			//		OpenImportPageUserTask.PageParameters = new Dictionary<string, string>() {
			//			{"SchemaId", collection[0].GetTypedColumnValue<Guid>(schemaIdName).ToString()}
			//		};
			//	}
			//}
			return true;
		}

		public virtual bool CommandGenerationButtonMenuItemScriptTaskExecute(ProcessExecutingContext context) {
			TSConfiguration.CommandLineUtility.CheckRegisteredSections(UserConnection);
			return true;
		}

		public virtual bool ScriptFindSelectedModuleSubProcessExecute(ProcessExecutingContext context) {
			var userConnection = Page.UserConnection;
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
			EntitySchemaQueryColumn pageColumn = entitySchemaQuery.AddColumn("SysPageSchemaUId");
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", SelectedModuleId.ToString()));
			var modulesCollection =	entitySchemaQuery.GetEntityCollection(userConnection);
			if (modulesCollection.Count > 0)
			{
				var selectedPageSchemaId = modulesCollection[0].GetColumnValue(pageColumn.Name);
				var workspaceId = Page.MultiLevelTabs.ActiveTab.Tag.Split('|')[0];
				var workspaceTab = FindTabHeaderByTag(Page.MultiLevelTabs.TabHeaders, workspaceId);
				var module = FindTabHeaderByTag(workspaceTab.TabHeaders, selectedPageSchemaId.ToString());
				if (module == null) {
					module = FindTabHeaderByTag(Page.MultiLevelTabs.TabHeaders, selectedPageSchemaId.ToString());
				}
				Page.MultiLevelTabs.ActiveTab = module;
				string redirectUrl = GetRedirectUrl();
				var AspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
				AspPage.Redirect(redirectUrl);
			}
			return true;
		}

		public virtual bool SelectAndRunProcessScriptExecute(ProcessExecutingContext context) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchema vwSysModuleProcess = entitySchemaManager.GetInstanceByName("VwSysProcess");
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenSelectDataUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			string schemaUId = vwSysModuleProcess.UId.ToString();
			//var entitySchemaManager_New = UserConnection.EntitySchemaManager_New;
			OpenSelectDataUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)OpenSelectDataUserTask.PageParameters;
				pageParameters.Add("schemaName", "VwSysProcess");
			pageParameters.Add("lookupPageSchemaUId", "'8504d3e3-191c-45e1-931c-910f90538dd4'");
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			//// TODO change hardocde Guid of TSBpm on read from database
			filters.Add(new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"useDisplayValue", false },
					{"leftExpressionColumnPath", "SysWorkspace"},
					{"rightExpressionParameterValues", new object[] { Page.UserConnection.Workspace.Id }}
				});
			pageParameters.Add("LookupFilters", filters);	
			pageParameters.Add("customClosedEvent", "LookupGridPageClosed");
			return true;
		}

		public virtual bool RunProcessScriptExecute(ProcessExecutingContext context) {
			var selectedValues = (Dictionary<string, object>)OpenSelectDataUserTask.GetSelectedValues(UserConnection);
			string recordId = string.Empty;
			string processCaption = string.Empty;
			foreach (KeyValuePair<string, object> item in selectedValues) {
				recordId = item.Key;
				var itemValue = (Dictionary<string, object>)item.Value;
				foreach(KeyValuePair<string, object> selecttedItem in itemValue) {
					processCaption = selecttedItem.Value.ToString();
					break;
				}
				break;
			}
			if (!string.IsNullOrEmpty(recordId)) {
				var processSchemaId = new Guid(recordId);
				var manager = UserConnection.ProcessSchemaManager;
			    var processSchemaManagerItem =  manager.GetItems().Find(item => item.Id == processSchemaId);
			    ProcessSchema processSchema = processSchemaManagerItem.Instance;
				if (processSchema == null) {
					MessageWindowUserTask.MessageText = string.Format(ModuleProcessInstanceNotExistMessage, processCaption);
					MessageWindowUserTask.Page = Page;
					Page.ThrowEvent("ShowMessage");
					return true;
				}
				var moduleProcess = processSchema.CreateProcess(UserConnection);
				if (processSchema.Parameters.ExistsByName("PageInstanceId")) {
					string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
					string pageInstanceId = instanceId + Page.PageContainer.UniqueID;
					moduleProcess.SetPropertyValue("PageInstanceId", pageInstanceId);
				}
				if (processSchema.Parameters.ExistsByName("Page")) {
					moduleProcess.SetPropertyValue("Page", Page);
				}
				moduleProcess.Execute(Page.UserConnection);
			}
			return true;
		}

		public virtual bool SettingsChangedScriptExecute(ProcessExecutingContext context) {
			//Page.AddScript("alert('', 'SettingsChanged')");
			var contentPageContainer = Page.ContentControlLayout.Items[0] as Terrasoft.UI.WebControls.Controls.PageContainer;
			var contentPage = contentPageContainer.PageInstance;
			contentPage.ThrowEvent("TuningModeChanged");
			return true;
		}

		public virtual bool LinkClickScriptTaskExecute(ProcessExecutingContext context) {
			var contextEventArgs = (Dictionary<string, object>)context.ThrowEventArgs;
			MessagePanelClickedLinkId = contextEventArgs["id"].ToString();
			return true;
		}

		public virtual bool ShowRemindingsUserTaskInitExecute(ProcessExecutingContext context) {
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager");
			RemindingsPageUId = new Guid("9d83cb5b-5aa3-4484-9d59-1c5e7b086a05");
			var remindingsPageSchema = pageSchemaManager.GetInstanceByUId(RemindingsPageUId) as PageSchema;
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			string key = instanceId + Page.PageContainer.UniqueID;
			ShowDefinedPageUserTask.OpenerInstanceId = key;
			ShowDefinedPageUserTask.PageUId = RemindingsPageUId;
			ShowDefinedPageUserTask.PageParameters = new Dictionary<string, string> {
				{"mainPageProcessUId", Page.Process.InstanceUId}
			};
			Page.BaseMessagePanel.Remove("messagePanelRemindingInfo");
			MessagePanelClickedLinkId = string.Empty;
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			MessagePanelClickedLinkId = string.Empty;
			var contextEventArgs = (Dictionary<string, object>)context.ThrowEventArgs;
			var linkId = contextEventArgs["id"].ToString();
			if (linkId == ShowLDAPMessageId.ToString()) {
				Page.BaseMessagePanel.Remove("LDAPUsersWereAdded");
				var manager = Page.UserConnection.ProcessSchemaManager;
				var processSchema =  (ProcessSchema)manager.FindInstanceByName("ShowNewLDAPUsersProcess");
				if (processSchema == null) {
					return true;
				}
				var moduleProcess = processSchema.CreateProcess(UserConnection);
				if (processSchema.Parameters.ExistsByName("PageInstanceId")) {
					string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
					string pageInstanceId = instanceId + Page.PageContainer.UniqueID;
					moduleProcess.SetPropertyValue("PageInstanceId", pageInstanceId);
				}
				if (processSchema.Parameters.ExistsByName("Page")) {
					moduleProcess.SetPropertyValue("Page", Page);
				}
				moduleProcess.Execute(Page.UserConnection);
			} 
			return true;
		}

		public virtual bool MailboxSettingsScriptTaskExecute(ProcessExecutingContext context) {
			/*var loadImapEmailsProcess = new LoadImapEmailsProcess(UserConnection);
			loadImapEmailsProcess.PrepareMailboxSynchronizationSettingsPageOpening(ShowDefinedPageUserTask);
			Page.BaseMessagePanel.Remove(loadImapEmailsProcess.NeedSetMailboxSynchronizationMessageUId.ToString("N"));
			MessagePanelClickedLinkId = string.Empty;*/
			return true;
		}

		public virtual bool MoveToModuleScriptExecute(ProcessExecutingContext context) {
			var moveToParameters = context.ThrowEventArgs as Dictionary<string, object>;
			if (moveToParameters == null) {
				moveToParameters = MoveToParameters as Dictionary<string, object>;
			} else {
				MoveToParameters = moveToParameters;
			}
			string[] identifiers = Page.MultiLevelTabs.ActiveTab.Tag.Split('|');
			var workspaceId = identifiers[0];
			var workspaceTab = FindTabHeaderByTag(Page.MultiLevelTabs.TabHeaders, workspaceId);
			var module = FindTabHeaderByTag(workspaceTab.TabHeaders, moveToParameters["Item1"].ToString());
			if (module == null) {
				module = FindTabHeaderByTag(Page.MultiLevelTabs.TabHeaders, moveToParameters["Item1"].ToString());
			}
			Page.MultiLevelTabs.ActiveTab = module;
			string redirectUrl = GetRedirectUrl();
			var AspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			AspPage.Redirect(redirectUrl);
			return true;
		}

		public virtual bool ScriptHelpCalledExecute(ProcessExecutingContext context) {
			var contentPageContainer = Page.ContentControlLayout.Items[0] as Terrasoft.UI.WebControls.Controls.PageContainer;
			var contentPage = contentPageContainer.PageInstance;
			string helpContextId = string.IsNullOrEmpty(contentPageContainer.HelpContextId) ? contentPage.Schema.HelpContextId : contentPageContainer.HelpContextId;
			string script = @"var helpContextId = " + (string.IsNullOrEmpty(helpContextId) ?  "null" : helpContextId) + @";
			Terrasoft.HelpContext.showHelp(helpContextId);";
			Page.AddScript(script);
			return true;
		}

		public virtual bool ScriptMessagePanelMessageClosedExecute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.Remove("LDAPUsersWereAdded");
			var delete = new Delete(UserConnection).
				From("SysLDAPSynchGroup");
			delete.Execute();
			return true;
		}

		public virtual bool ScriptDoShowLDAPMessageExecute(ProcessExecutingContext context) {
			ShowLDAPMessage();
			return true;
		}

		public virtual bool ScriptShowStartProcessExecute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.AddMessage("LDAPProcessStarted", String.Empty, ProcessSynchWithLDAPLaunchedLS);
			return true;
		}

		public virtual bool ScriptErrorCheckRequiredLDAPSettingsExecute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.AddMessage("LDAPProcessStarted", String.Empty, ErrorCheckRequiredLDAPSettingsLS);
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			bool isUnload = false;
			var AspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			var formData = Page.AspPage.Request.Form;
			if (formData.Count > 3) {
				isUnload = formData[3].Contains("WindowUnload");
			}
			var columnNames = new Dictionary<string, string>();
			BuildWorkspaces(null, Page.MultiLevelTabs.TabHeaders);
			var activeTabId = string.Empty;
			JObject tempData = null;
			string tempDataKey = "tempData";
			if (AspPage.CustomData.ContainsKey(tempDataKey)) {
				tempData = AspPage.CustomData[tempDataKey] as JObject;
				if (tempData["MainActiveTabId"] != null) {
					activeTabId = (tempData["MainActiveTabId"] as JValue).Value.ToString();
				}
			} else {
				tempData = new JObject();
				if (AspPage.Request.QueryString["ActiveTabId"] != null) {
					activeTabId = AspPage.Request.QueryString["ActiveTabId"];
					tempData["MainActiveTabId"] = new JValue(activeTabId);
				}
			}
			var ContentPage = new Terrasoft.UI.WebControls.Controls.PageContainer();
			ContentPage.UId = Guid.NewGuid();
			if (string.IsNullOrEmpty(activeTabId)) {
				if (FirstPageSchemaIdToLoad != Guid.Empty) {
					ContentPage.PageSchemaUId = FirstPageSchemaIdToLoad;
					PageSchema schema = ContentPage.PageSchemaManager.GetInstanceByUId(ContentPage.PageSchemaUId);
					ContentPage.Name = schema.Name;
					Page.MultiLevelTabs.ActiveTab = FindTabHeaderByTag(Page.MultiLevelTabs.TabHeaders, FirstPageSchemaIdToLoad.ToString());
					tempData["MainActiveTabId"] = new JValue(Page.MultiLevelTabs.ActiveTabId);
				}
				ContentPage.Height = System.Web.UI.WebControls.Unit.Percentage(100);
				ContentPage.Width = System.Web.UI.WebControls.Unit.Percentage(100);
				Page.ContentControlLayout.InsertItem(0, ContentPage);
			} else {
				if (!Ext.IsAjaxRequest) {
					UserConnection.SessionData["MainActiveTabId"] = activeTabId;
				}
				Page.MultiLevelTabs.ActiveTabId = activeTabId;
				ContentPage.PageSchemaUId = new Guid(Page.MultiLevelTabs.ActiveTab.Tag.Split('|')[2]);
				PageSchema schema = ContentPage.PageSchemaManager.GetInstanceByUId(ContentPage.PageSchemaUId);
				ContentPage.Name = schema.Name;
				ContentPage.Height = System.Web.UI.WebControls.Unit.Percentage(100);
				ContentPage.Width = System.Web.UI.WebControls.Unit.Percentage(100);
				Page.ContentControlLayout.InsertItem(0, ContentPage);
			}
			if (AspPage.UseProfile && ContentPage.PageSchemaUId == new Guid("0fc3e351-5a2e-4505-ade5-7ae7c0740f27")) {
				AspPage.UseProfile = false;
			}
			string scriptTemplate ="function() { debugger; window.logout = true; var parentWindow = window.parent || window; parentWindow.location.replace(" +
				Terrasoft.Common.Json.Json.Serialize(System.Web.Security.FormsAuthentication.LoginUrl) + ") }();";
			Page.ExitButton.AjaxEvents.Click.OnClientEvent = scriptTemplate;
			if (AspPage.UseProfile) {	
				List<System.Web.UI.Control> list = ControlUtilities.FindControls(Page.AspPage, "DetailsTabPanel");
				if (list.Count > 0) {
					foreach (Terrasoft.UI.WebControls.Controls.TabPanel tabPanel in list) {
						string collapsedFieldValue = Page.Request.Form[tabPanel.ClientID + "_Collapsed"];
						if (AspPage.IsPostBack) {
							if (string.IsNullOrEmpty(collapsedFieldValue)) {
								var tabCollapsed = tempData[tabPanel.ClientID + "_Collapsed"] as JValue;
								collapsedFieldValue = (tabCollapsed != null ? tabCollapsed.Value.ToString() : string.Empty);
							} else {
								tempData[tabPanel.ClientID + "_Collapsed"] = new JValue(collapsedFieldValue);
							}
						}
						string activeTabFieldValue = Page.Request.Form[tabPanel.ClientID + "_ActiveTab"];
						if (AspPage.IsPostBack) {
							if (string.IsNullOrEmpty(activeTabFieldValue)) {
								var activeTabIndex = tempData[tabPanel.ClientID + "_ActiveTab"] as JValue;
								activeTabFieldValue = (activeTabIndex != null ? activeTabIndex.Value.ToString() : "0");
							} else {
								tempData[tabPanel.ClientID + "_ActiveTab"] = new JValue(activeTabFieldValue);
							}
						}
					}
				}
			}
			
			object productName = null;
			if (!Terrasoft.Core.Configuration.SysSettings.TryGetValue(UserConnection, "ProductName", out productName)) {
				 productName = "bpm′online";
			}
			AspPage.Title = productName.ToString();
			
			if (!AspPage.CustomData.ContainsKey(tempDataKey)) {
				AspPage.CustomData[tempDataKey] = tempData;
			}
			if (AspPage.UseProfile && !AspPage.IsPostBack && Page.MultiLevelTabs.ActiveTab != null) {
				var args = new ProfileKeyEventArgs();
				AspPage.InitializeProfile(args);
			}
			MessagePanelClickedLinkId = string.Empty;
			var contentPage = Page.ContentControlLayout.Items[0] as Terrasoft.UI.WebControls.Controls.PageContainer;
			if (contentPage.PageInstance == null || contentPage.PageInstance.Process == null) {
				return true;
			}
			var contentPageProcess = contentPage.PageInstance.Process;
			SelectedModuleId = new Guid(Page.MultiLevelTabs.ActiveTab.Tag.Split('|')[1]);
			contentPageProcess.SetPropertyValue("SysModuleId", SelectedModuleId);
			contentPageProcess.SetPropertyValue("MainPageProcessUId", Page.Process.InstanceUId);
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			// Используйте этот параметр для тех опций, 
			// которые должны быть доступны разработчику 
			// в независимости от прав его учетной записи:
			IsDeveloperMode = System.Diagnostics.Debugger.IsAttached;
			
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var image16ColumnUId = entitySchemaManager.GetInstanceByName("SysModule").Columns.GetByName("Image16").UId;
			var schemaUId = entitySchemaManager.GetItemByName("SysModule").UId;
			var esq = new EntitySchemaQuery(entitySchemaManager, "SysSettingsValue");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysSettings.Code", "HeaderLogoImage"));
			var logoSettingEntities = esq.GetEntityCollection(Page.UserConnection);
			if (logoSettingEntities.Count > 0) {
				Guid settingsValueId = logoSettingEntities[0].PrimaryColumnValue;
				Page.ImageBox1.Image = new ControlImage {
					Source = ControlImageSource.EntityColumn,
					SchemaUId = esq.RootSchema.UId,
					EntityPrimaryColumnValue = settingsValueId,
					EntitySchemaColumnUId = esq.RootSchema.Columns.GetByName("BinaryValue").UId
				};
			}
			Page.SearchEdit.Image = new ControlImage() {
				Source = ControlImageSource.EntityColumn,
				SchemaUId = schemaUId,
				EntityPrimaryColumnValue = SelectedModuleId,
				EntitySchemaColumnUId = image16ColumnUId,
				UsePrimaryImageColumn = false
			};
			IsDemoBuild = Terrasoft.Configuration.CommonUtilities.IsDemoBuild(UserConnection);
			Tuple<string, string, string> moduleInfo = GetModuleInfoByUId(SelectedModuleId);
			SelectedModuleCode = moduleInfo.Item1;
			SelectedModuleHelpContextId = moduleInfo.Item2;
			SelectedModuleCaption = moduleInfo.Item3;
			var contentPage = Page.ContentControlLayout.Items[0] as Terrasoft.UI.WebControls.Controls.PageContainer;
			if (contentPage.PageInstance != null) {
				Terrasoft.Configuration.VideoHelpUtilities.SetWebControlHelpProperties(contentPage, SelectedModuleHelpContextId, UserConnection);
			}
			GetAdministrativeRights();
			CompleteSettingsButtonMenuItems();
			InitializeContextHelpButton();
			RemindingsPageUId = new Guid("65DF8E0C-8AD1-4844-A960-2672E3450FDE");
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
				LinkId = RemindingsPageUId.ToString(),
				Caption = MessagePanelShowLinkText
			});
			var newMailsUId = new Guid("419f0b07-24e5-4e46-bb4c-28b91c07321a");
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
			                Url = new Uri(Page.Request.Url, "ViewPage.aspx?Id=5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a&ActiveTabId=PageContainer_5ca0dabc8c894e1a9bb536407e1c4ef2_055063c98180e011afbc00155d04320c_830581929880e011afbc00155d04320c&action=viewunread").ToString(),
			                LinkId = newMailsUId.ToString(),
			                Caption = MessagePanelShowLinkText
			});
			
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
						LinkId = MailboxSynchronizationSettingsPageUId.ToString(),
						Caption = MessagePanelSetNowLinkText
					});
			
			Page.BaseMessagePanel.Links.Add(new LinkConfig() {
				Caption = OpenLDAPUsersListLS,
				LinkId = ShowLDAPMessageId.ToString()	
			});
			Page.BaseMessagePanel.AjaxEvents.LinkClick.SignalName = "MessagePanelLinkClick";
			Page.BaseMessagePanel.AjaxEvents.LinkClick.ExtraParameters.Add(
				new Terrasoft.UI.WebControls.Controls.Parameter(
					"id", "id",Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			/*if (IsDemoBuild) {
				RegisterDemoLinks();
			}
			if(IsDemoBuild || IsEnglishLocalization()) {
				RegisterChatLinks();
			}
			
			var messagePanelRemindingMessage = string.Format(MessagePanelRemindingMessage, RemindingsPageUId.ToString("B"));
			var remindingsCheckInterval = (int)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "RemindingsCheckInterval");
			var remindingTimerScript = @"
			var contactId = '" + UserConnection.CurrentUser.ContactId + @"';
			var messageId = 'messagePanelRemindingInfo';
			var imapMsgId = 'ImapSyncInfo';
			function checkRemindingExists() {  
			                var url = Terrasoft.getWebServiceUrl('Services/ContactCounterValuesService', 'GetContactCounterValues');
			                Ext.Ajax.request({
			                               url: url,
			                               scope: this,
			                               success: function(response, options) {                                                
			                                               var xmlData = response.responseXML;                                               
			                                               if (!xmlData) {
			                                                               return;
			                                               }              
			                                               var root = xmlData.documentElement || xmlData;
			                                               if (!root) {
			                                                               return;
			                                               } 
			                                               var data = root.text || root.textContent;                                           
			                                               eval('var result = ' + data);                                                                                         
			                                               updateRemindings(result);
			                               },
			                               failure: Ext.emptyFn,
			                               argument: {},
			                               params: 'contactId=' + contactId
			                });
			}
			function updateRemindings(userCounters) {
			       var messagePanel = Ext.FormValidator.getVMP();
			       if (!messagePanel) {
			                       return;
			       }                                                                             
			       var mi = Ext.get(messageId); 
			       var miIsEmpty = Ext.isEmpty(mi);      
			       PageContainer_NewRemindingsCountButton.setCaption(userCounters.newRemindingsCount.toString());
			       PageContainer_NewRemindingsCountButton.setEnabled(userCounters.newRemindingsCount > 0);
				   if (userCounters.newRemindingsCount && userCounters.newRemindingsCount > 0) {                                                                                                              
			                       PageContainer_NewRemindingsCountButton.setButtonStyle('yellow');											   
			       } else {
			                       PageContainer_NewRemindingsCountButton.setButtonStyle('blue');											   
			       }
			       PageContainer_UnreadEmailCountButton.setEnabled(userCounters.unreadEmailsCount > 0);											   
			       PageContainer_UnreadEmailCountButton.setCaption(userCounters.unreadEmailsCount.toString());
			       if (userCounters.unreadEmailsCount && userCounters.unreadEmailsCount > 0) { 
			                       PageContainer_UnreadEmailCountButton.setButtonStyle('yellow');
			       } else {
			                       PageContainer_UnreadEmailCountButton.setButtonStyle('blue');											   
				   }
			}
			updateRemindings( " + UserConnection.DBEngine.GetContactCounters(UserConnection.CurrentUser.ContactId).ExecuteScalar<string>() + @" );
			setInterval (checkRemindingExists, " + remindingsCheckInterval + @");
			";
			var scriptManager = Page.GetPropertyValue("ScriptManager") as ScriptManager;
			scriptManager.AddScript(remindingTimerScript);*/
			//Page.RunProcessButton.AjaxEvents.Click.SignalName = "SelectAndRunProcess";
			string script = string.Format("{0}.on('settingstoolclick', function() {{\nthis.callPageMethod('ThrowEvent', {{signalName: 'SettingsChanged'}});\n}}, {0});", Page.MultiLevelTabs.ClientID);
			script += string.Format("{0}.on('helptoolclick', function() {{\nthis.callPageMethod('ThrowEvent', {{signalName: 'HelpCalled'}});\n}}, {0});", Page.MultiLevelTabs.ClientID);
			//script += string.Format("{0}.on('click', function(el) {{\nlocation.replace('ViewPage.aspx?Id=5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a&ActiveTabId=PageContainer_5ca0dabc8c894e1a9bb536407e1c4ef2_055063c98180e011afbc00155d04320c_bfce999927724430bfbbd978236cab81&action=selectemailfolder')}}, this)", Page.UnreadEmailCountButton.ClientID);
			Page.AddScript(script);
			var AspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			SysMainPageShellClientId = AspPage.Request.QueryString["SysMainPageShellClientId"];
			string moduleId = AspPage.Request.QueryString["moduleId"];
			if (moduleId != null) {
				string pcv = AspPage.Request.QueryString["pcv"];
				string pdv = AspPage.Request.QueryString["pdv"];
				var moveToParameters = new Dictionary<string, object>();
				moveToParameters.Add("Item1", new Guid(moduleId));
				moveToParameters.Add("Item2", new Guid(pcv));
				moveToParameters.Add("Item3", pdv);
				MoveToParameters = moveToParameters;
				Page.ThrowEvent("MoveToModule");
			}
			OnMultiLeveTabsTabChange();
			SubscribeOnMessagePanelCloseEvent();
			
			bool useWelcomeScreen = (bool)SysSettings.GetValue(UserConnection, "UseWelcomeScreen");
			if (!useWelcomeScreen) {
				Page.ShowWelcomeScreen.SetVisible(false);
			}
			else {
				WelcomeScreenDataKey = "WelcomeScreen";
				if (!IsDemoBuild) {
					WelcomeScreenDataKey += SelectedModuleId.ToString();
				} else {
					WelcomeScreenDataKey += Page.AspPage.Request.UserHostAddress;
				}
				if (NeedShowWelcomeScreen()) {
					string informationWindowScript = GetWelcomeWindowScript();
					Page.AddScript(informationWindowScript);
				}
			}
			
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
			entitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			EntitySchemaQueryColumn entitySchemaColumn = entitySchemaQuery.AddColumn("SysModuleEntity.SysEntitySchemaUId");			
			EntitySchemaQueryColumn pageSchemaColumn = entitySchemaQuery.AddColumn("SysPageSchemaUId");
			entitySchemaQuery.CacheItemName = "window.modules";
			EntityCollection modulesCollection = entitySchemaQuery.GetEntityCollection(Page.UserConnection);
			var modules = new Dictionary<string, Guid>();
			foreach(var module in modulesCollection) {
				var pageSchemaId = entitySchemaQuery.GetTypedColumnValue<Guid>(module, pageSchemaColumn.Name);
				var schemaId = entitySchemaQuery.GetTypedColumnValue<Guid>(module, entitySchemaColumn.Name);
				string key = "'"+schemaId.ToString()+"'";
				if ((pageSchemaId != Guid.Empty) 
					&& (schemaId != Guid.Empty 
						&& schemaId != Terrasoft.Configuration.SchemaUIdConsts.VwSysAdminUnit
						&& schemaId != Terrasoft.Configuration.SchemaUIdConsts.SysModuleFolder) 
					&& (!modules.ContainsKey(key))) {
					modules.Add(key, pageSchemaId);
				}
			}
			string serializedData = Json.Serialize(modules, new DictionaryJsonConverter());
			//Page.AddScript(string.Format("window.modules=({0});", serializedData));
			//FillSearchModules();
			//FillAddButtonMenu();
			Page.ScriptManager.AddScript("this.parent.currentInnerProcessInstanceUId='" + InstanceUId + "';");
			return true;
		}

		public virtual bool PageLoadScriptTaskExecute(ProcessExecutingContext context) {
			Page.SettingsButton.AjaxEvents.MenuItemClick.Event += delegate(object sender, Terrasoft.UI.WebControls.Controls.AjaxEventArgs e) {		
				var clickedMenuItemCode = e.ExtraParameters[2].Value;											
				OnSettingsButtonMenuItemClick(new Guid(clickedMenuItemCode));
			};
			return true;
		}

		public virtual bool ScriptGlobalSearchExecute(ProcessExecutingContext context) {
			var searchText = Page.SearchEdit.Text;
			if (string.Empty.Equals(searchText)) {
				Page.ClearToolButton.Hide();	
			} else {
				Page.ClearToolButton.Show();
			}
			if (SelectedModuleId.Equals(SearchModuleId)) {
				var modulePageContainer = Page.ContentControlLayout.Items[0] as PageContainer;
				var modulePageProcess = modulePageContainer.PageInstance.Process;
				modulePageProcess.SetPropertyValue("SearchPrimaryDisplayColumnValue", Page.SearchEdit.Text);
				modulePageProcess.ThrowEvent(modulePageProcess.InternalContext, "ApplySearchFilter");
			} else {
				SelectedModuleId = SearchModuleId;
				GlobalSearchValue = Page.SearchEdit.Text;
				Page.Process.ThrowEvent(Page.Process.InternalContext, "FindSelectedModule");
			}
			return true;
		}

		public virtual bool ScriptClearToolButtonClickExecute(ProcessExecutingContext context) {
			Page.SearchEdit.Text = string.Empty;
			return true;
		}

		public virtual bool ScriptChangeSearchModuleExecute(ProcessExecutingContext context) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var imageColumnUId = entitySchemaManager.GetInstanceByName("SysModule").Columns.GetByName("Image16").UId;
			var schemaUId = entitySchemaManager.GetItemByName("SysModule").UId;
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			SearchModuleId = new Guid(extraParams["tag"].ToString());
			Page.SearchEdit.Image = new ControlImage() {
				Source = ControlImageSource.EntityColumn,
				SchemaUId = schemaUId,
				EntityPrimaryColumnValue = SearchModuleId,
				UsePrimaryImageColumn = false,
				EntitySchemaColumnUId = imageColumnUId							
			};
			return true;
		}

		public virtual bool WelcomeScreenClosedScriptTaskExecute(ProcessExecutingContext context) {
			var args = context.ThrowEventArgs as Dictionary<string, object>;
			bool neverShow = (bool)args["neverShow"];
			if (neverShow) {
				string moduleIdStr = SelectedModuleId.ToString();	
				if (IsDemoBuild) {		
					var cookie = new HttpCookie(WelcomeScreenDataKey);
					if (Page.AspPage.Request.Cookies[WelcomeScreenDataKey] != null) {
						foreach (var item in Page.AspPage.Request.Cookies[WelcomeScreenDataKey].Values) {
							cookie.Values[item.ToString()] = true.ToString();
						}
					}	
					cookie.Values[moduleIdStr] = true.ToString();		
					cookie.Expires = DateTime.Now.AddYears(50);
					Page.AspPage.Response.Cookies.Add(cookie);
				} else {
					/*string script = "{0}.setProfileData({1},{2});";
					Page.ScriptManager.AddScript(string.Format(script, Page.RunProcessButton.ClientID, Json.Serialize(WelcomeScreenDataKey), Json.Serialize(true)));*/
					Terrasoft.Configuration.CommonUtilities.WriteProfileData(UserConnection, (Page.AspPage as Terrasoft.UI.WebControls.Page).UId, WelcomeScreenDataKey, true);
				}
			}
			return true;
		}

		public virtual bool ShowWelcomeScreenClickScriptTaskExecute(ProcessExecutingContext context) {
			ResetWelcomeScreenSettings();
			string script = GetWelcomeWindowScript();
			Page.AddScript(script);
			return true;
		}

		public virtual Terrasoft.UI.WebControls.Controls.TabHeader FindTabHeaderByTag(Terrasoft.UI.WebControls.Controls.TabHeaderCollection TabHeaders, string Tag) {
			Terrasoft.UI.WebControls.Controls.TabHeader retValue = null;
			foreach(var item in TabHeaders) {
				if (item.Tag.Contains(Tag)) {
					return item;
				} else {
					if (item.TabHeaders.Count > 0) {
						retValue = FindTabHeaderByTag(item.TabHeaders,Tag);	 
						if (retValue != null) {
							return retValue;
						}
					}
				}
			}
			return retValue;
		}

		public virtual bool CheckModuleReadingRights(Guid entitySchemaId) {
			var securityEngine = Page .UserConnection.DBSecurityEngine;
			var entitySchemaManager =
				(EntitySchemaManager)Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager");
			var schemaName = entitySchemaManager.FindItemByUId(entitySchemaId).Name;
			var adminModuleList = new Dictionary<string, string> {
				{"VwSysAdminUnit", "CanManageAdministration"},
				{"VwAdministrativeObjects", "CanManageAdministration"},
				{"SysAdminOperation", "CanManageAdministration"},
				{"SysSettings", "CanManageAdministration"},
				{"SysSchema", "CanManageSolution"},
				{"SysLookup", "CanManageLookups"},
				//{"SysModuleFolder", "CanManageWorkspaces"},
				{"VwSysProcess", "CanManageProcessDesign"},
				{"ChangeLogEntity", "CanManageChangeLog"}
			};
			if (adminModuleList.Keys.Contains(schemaName)) {
				var adminRight = securityEngine.GetCanExecuteOperations(Page.UserConnection.CurrentUser.Id,
					adminModuleList[schemaName], "CanViewConfiguration");
				return adminRight;
			}
			return Page.UserConnection.DBSecurityEngine.GetIsEntitySchemaReadingAllowed(schemaName);
		}

		public virtual void OnMultiLeveTabsTabChange() {
			var sb = new StringBuilder();
			sb.Append(@"function (el, tab, tag) {
				var activeTabId = tab.id;
				var groupRegexp = /^[^_]*_[^_]*$/;
				if (groupRegexp.test(activeTabId)) {
					return;
				}
				var customDataFieldEl = Ext.get('customDataField');
					var customDataValue = '';
					if (customDataFieldEl) {
						customDataValue = Ext.decode(customDataFieldEl.dom.value);
						if (!customDataValue.tempData) {
							customDataValue.tempData = {};
						} else {
							customDataValue.tempData = Ext.decode(customDataValue.tempData);
						}
						customDataValue.tempData['MainActiveTabId'] = activeTabId;		
						customDataValue.tempData = Ext.encode(customDataValue.tempData);
						customDataFieldEl.dom.value = Ext.encode(customDataValue);
					}	
				var redirectUrl = window.location.protocol + '//' + window.location.host + window.location.pathname;
				var searchString = window.location.search.substring(1).split('&');
				var queryString = '';
				var queryItem;
				var re = /GlobalSearchValue|ActiveTabId|SysMainPageShellClientId|pcv|pdv|moduleId|action/gi;
				for (var i = 0; i < searchString.length ; i++) {
					queryItem = searchString[i];
					if (queryItem.search(re) != -1) {
						continue;
					}
					if (queryItem) {
						queryString += queryItem;
					}
				}
				if (queryString) {
					redirectUrl = redirectUrl + '?' + queryString;
				}
				redirectUrl += '&ActiveTabId=' + activeTabId;");
			if (string.IsNullOrEmpty(SysMainPageShellClientId)) {
				sb.AppendLine("window.location.replace(redirectUrl);");
			} else {
				sb.AppendLine("redirectUrl += '&SysMainPageShellClientId=' + window.top." + SysMainPageShellClientId + ".id;");
				sb.AppendLine("window.top." + SysMainPageShellClientId + ".setSourceUrl(redirectUrl);");
			}
			sb.AppendLine("} (el, tab, tag)");
			Page.MultiLevelTabs.AjaxEvents.TabChange.OnClientEvent = sb.ToString();
			Page.MultiLevelTabs.AjaxEvents.MenuItemClick.OnClientEvent = sb.ToString();
		}

		public virtual string GetRedirectUrl() {
			var AspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			string redirectUrl = AspPage.Request.Path; 
			List<string> ignoreQueryItems = new List<string>();
			ignoreQueryItems.Add("GlobalSearchValue");
			ignoreQueryItems.Add("ActiveTabId");
			ignoreQueryItems.Add("pcv");
			ignoreQueryItems.Add("pdv");
			ignoreQueryItems.Add("moduleId");
			ignoreQueryItems.Add("action");
			string queryString = string.Empty;
			foreach (string queryItem in AspPage.Request.QueryString) {
				if (ignoreQueryItems.Contains(queryItem)) {
					continue;
				} 
				if (!queryString.Equals(string.Empty)) {
					queryString += "&";
				}
				queryString += string.Concat(queryItem, "=", AspPage.Request.QueryString[queryItem]);
			}
			if (!queryString.Equals(string.Empty)) {
				redirectUrl = redirectUrl + "?" + queryString;
			}
			var searchText = string.Empty;
			if(MoveToParameters != null) {
				var moveToParameters = MoveToParameters as Dictionary<string, object>;
				searchText += "&pcv=" + moveToParameters["Item2"].ToString();
				searchText += "&pdv=" + System.Web.HttpUtility.UrlEncode(moveToParameters["Item3"].ToString());
			}
			if(!string.IsNullOrEmpty(GlobalSearchValue)) {
				searchText = "&GlobalSearchValue=" + GlobalSearchValue;
			}
			searchText += "&ActiveTabId=" + Page.MultiLevelTabs.ActiveTabId.ToString();
			return redirectUrl + searchText;
		}

		public virtual void AddOpenXmlDll() {
		}

		public virtual void ShowLDAPMessage() {
			Page.BaseMessagePanel.Remove("LDAPProcessStarted");
			if (!Page.UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageAdministration",Page.UserConnection.CurrentUser.Id)) {
				return;
			}
			var sel = new Select(UserConnection).
				Column("SysAdminUnit", "Id").
			From("SysLDAPSynchGroup").
				InnerJoin("SysAdminUnit").On("SysAdminUnit", "LDAPEntryId").IsEqual("SysLDAPSynchGroup", "Id") as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = sel.ExecuteReader(dbExecutor)) {
					if (!dr.Read()) {
						return;
					}
				}
			}
			var newLink = new LinkConfig();
			newLink.Caption = OpenLDAPUsersListLS;
			newLink.Url = "";
			newLink.LinkId = ShowLDAPMessageId.ToString();
			Page.BaseMessagePanel.Links.Add(newLink);
			
			/*newLink = new LinkConfig();
			newLink.Caption = CancelLDAPUsersListLS;
			newLink.Url = "";
			newLink.LinkId = CancelLDAPMessageId.ToString();
			Page.BaseMessagePanel.Links.Add(newLink);*/
			Page.BaseMessagePanel.Remove("LDAPUsersWereAdded");
			Page.BaseMessagePanel.AddMessage("LDAPUsersWereAdded", String.Empty, String.Format(LDAPUsersWereAddedLS, ShowLDAPMessageId.ToString("B")/*, CancelLDAPMessageId.ToString("B")*/));
		}

		public virtual string GetModuleCaption(Guid moduleId) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(entitySchemaManager, "SysModule");
			var captionColumnName = query.AddColumn("Caption").Name;
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"Id", moduleId));
			var entities = query.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return entities[0].GetTypedColumnValue<string>(captionColumnName);
			} else {
				return string.Empty;
			}
		}

		public virtual void InitializeContextHelpButton() {
			if (SysSettings.GetValue(UserConnection, "EnableContextHelp", false)) {
				var contextHelpButton = Page.ContextHelpButton;
				var openContextHelpButton = Page.OpenContextHelp;
				var openModuleHelpButton = Page.OpenModuleHelp;
				contextHelpButton.Hidden = false;
				contextHelpButton.Image.Source = ControlImageSource.ResourceManager;
				contextHelpButton.Image.ResourceManagerName = "Terrasoft.WebApp";
				contextHelpButton.Image.ResourceItemName = "help.png";
				if (!SelectedModuleHelpContextId.IsNullOrEmpty()) {
					var template = "Terrasoft.HelpContext.showHelp(null, null, '{0}')";
					string mainPageHelpUrl = TSConfiguration.VideoHelpUtilities.GetHelpUrl(contextHelpButton, string.Empty, UserConnection);
					string moduleHelpUrl = TSConfiguration.VideoHelpUtilities.GetHelpUrl(contextHelpButton, SelectedModuleHelpContextId, UserConnection);
					contextHelpButton.AjaxEvents.Click.OnClientEvent = string.Format(template, mainPageHelpUrl);
					openContextHelpButton.AjaxEvents.Click.OnClientEvent = string.Format(template, mainPageHelpUrl);
					openModuleHelpButton.AjaxEvents.Click.OnClientEvent = string.Format(template, moduleHelpUrl);
				} else {
					var contextHelpButtonClientId = contextHelpButton.ClientID;
					contextHelpButton.AjaxEvents.Click.OnClientEvent = "Terrasoft.HelpContext.showHelp(null, '" + contextHelpButtonClientId + "')";
					openContextHelpButton.AjaxEvents.Click.OnClientEvent = "Terrasoft.HelpContext.showHelp(null, '" + contextHelpButtonClientId + "')";
					openModuleHelpButton.AjaxEvents.Click.OnClientEvent = "Terrasoft.HelpContext.showHelp(" + Json.Serialize(SelectedModuleHelpContextId) + ", null)";
				}
				TSConfiguration.VideoHelpUtilities.SetWebControlHelpProperties(contextHelpButton, string.Empty, UserConnection);
			}
		}

		public virtual void AddOpenXmlDllReference() {
		}

		public virtual void AddWindowsBaseDllReference() {
		}

		public virtual Tuple<Guid, string>[] GetSettingsButtonMenuItemTagsAndCaptions() {
			var result = new List<Tuple<Guid, string>>();
			if (CanManageMailServers || IsDeveloperMode) {
				result.Add(Tuple.Create(ImapServersSettingsSettingsButtonMenuItemTag, ImapServersSettingsSettingsButtonMenuItemCaption.ToString()));
			}
			result.Add(Tuple.Create(EditSocialAccountsMenuItemTag, EditSocialAccountsButtonMenuItemCaption.ToString()));
			if ((CanManageLicUsers && !Terrasoft.Configuration.CommonUtilities.IsDemoBuild(UserConnection)) || IsDeveloperMode) {
				result.Add(Tuple.Create(LicensesSettingsButtonMenuItemTag, LicensesSettingsButtonMenuItemCaption.ToString()));
			}
			if (CanUseMsgService || IsDeveloperMode) {
				//result.Add(Tuple.Create(EditTelephonyButtonMenuItemTag, EditTelephonyButtonMenuItemCaption.ToString()));
			}
			if (CanStartCommandGeneration) {
				result.Add(Tuple.Create(CommandGenerationButtonMenuItemTag, CommandGenerationButtonMenuItemCaption.ToString()));
			}
			result.Add(Tuple.Create(OpenIntegrationLogMenuItemTag, OpenIntegrationLogButtonMenuItemCaption.ToString()));
			result.Add(Tuple.Create(ImportButtonMenuItemTag, ImportButtonMenuItemCaption.ToString()));
			/*if (CanChangeApplicationTuningMode || IsDeveloperMode) {	
				if (string.IsNullOrEmpty(SettingsModeSettingsButtonMenuItemCaption)
						|| (SettingsModeSettingsButtonMenuItemCaption == SetOffSettingsModeSettingsButtonMenuItemCaption)) {
					SettingsModeSettingsButtonMenuItemCaption = SetOnSettingsModeSettingsButtonMenuItemCaption.ToString();
				}
				result.Add(new Tuple<Guid, string>(SeparatorMenuItemTag, null));
				result.Add(Tuple.Create(SettingsModeSettingsButtonMenuItemTag, SettingsModeSettingsButtonMenuItemCaption.ToString()));
			}*/
			return result.ToArray();
		}

		public virtual void CompleteSettingsButtonMenuItems() {
			var settingsButton = Page.SettingsButton;
			var itemTagsAndCaptions = GetSettingsButtonMenuItemTagsAndCaptions();
			settingsButton.Hidden = (itemTagsAndCaptions.Length < 1);
			if (Terrasoft.UI.WebControls.Ext.IsAjaxRequest) {
				settingsButton.Menu.RemoveAll();
			}
			foreach (var itemTagAndCaption in itemTagsAndCaptions) {
				if (itemTagAndCaption.Item1 == SeparatorMenuItemTag) {
					var separator = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
					settingsButton.Menu.Add(separator);
					if (Terrasoft.UI.WebControls.Ext.IsAjaxRequest) {
						settingsButton.Menu.AddSeparator();
					}
					continue;
				}
				var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();	
				menuItem.UId = Guid.NewGuid();
				menuItem.Name = itemTagAndCaption.Item1.ToString("N");
				menuItem.Caption = itemTagAndCaption.Item2;	
				menuItem.Tag = itemTagAndCaption.Item1.ToString();
				menuItem.Image = new ControlImage {};
				settingsButton.Menu.Add(menuItem);
				if (Terrasoft.UI.WebControls.Ext.IsAjaxRequest) {
					settingsButton.Menu.AddCaptionItem(menuItem);
				}
			}
			if (itemTagsAndCaptions.Length > 0) {	
				var script = settingsButton.ClientID + ".onContentChanged();";
				Page.AddScript(script);
			}
		}

		public virtual void OnSettingsButtonMenuItemClick(Guid selectedTag) {
			if (selectedTag == SettingsModeSettingsButtonMenuItemTag) {
				Page.ThrowEvent("SettingsModeSettingsButtonMenuItemEvent");
			} else if (selectedTag == ImapServersSettingsSettingsButtonMenuItemTag) {
				Page.ThrowEvent("ImapServersSettingsSettingsButtonMenuItemEvent");
			} else if (selectedTag == EditSocialAccountsMenuItemTag) {
				Page.ThrowEvent("EditSocialAccountsButtonMenuItemEvent");
			} else if (selectedTag == LicensesSettingsButtonMenuItemTag) {
				Page.ThrowEvent("LicensesSettingsButtonMenuItemEvent");
			} else if (selectedTag == EditTelephonyButtonMenuItemTag) {
				Page.ThrowEvent("MsgServiceSettingsOpen");
			} else if (selectedTag == SetMailChimpSettingsButtonMenuItemTag) {
				Page.ThrowEvent("SetMailChimpSettingsButtonMenuItemEvent");
			} else if (selectedTag == CommandGenerationButtonMenuItemTag) {
				Page.ThrowEvent("CommandGenerationButtonMenuItemEvent");
			} else if (selectedTag == OpenIntegrationLogMenuItemTag) {
				Page.ThrowEvent("SetIntegrationLogMenuItemEvent");
			} else if (selectedTag == ImportButtonMenuItemTag) {
				Page.ThrowEvent("ImportButtonMenuItemClick");
			}
			return;
		}

		public virtual void GetAdministrativeRights() {
			var securityEngine = UserConnection.DBSecurityEngine;
			CanChangeApplicationTuningMode = securityEngine.GetCanExecuteOperation("CanChangeApplicationTuningMode");
			CanManageMailServers = securityEngine.GetCanExecuteOperation("CanManageMailServers");
			CanManageLicUsers = securityEngine.GetCanExecuteOperation("CanManageLicUsers");
			CanUseMsgService = true;//Terrasoft.Configuration.MsgServiceUtilities.CanUseMsgService(UserConnection);
			CanUseMailChimpIntegrationSettings = securityEngine.GetCanExecuteOperation("CanUseMailChimpIntegrationSettings");
			CanStartCommandGeneration = securityEngine.GetCanExecuteOperation("CanStartCommandGeneration");
		}

		public virtual void RegisterDemoLinks() {
			System.Web.UI.ClientScriptManager cs = Page.AspPage.ClientScript;
			UserConnection userConnection = Page.UserConnection;
			ImageListSchema imageListSchema = userConnection.ImageListSchemaManager.GetInstanceByName("DemoButtons");
			ControlImage controlImage = new ControlImage() {
				Source = ControlImageSource.ImageListSchema,
				SchemaUId = imageListSchema.UId,
				ItemUId = imageListSchema.Items.GetByName("BuyNowLeft").UId
			};
			string buyNowButtonLeftImage = controlImage.GetImageUrl();
			controlImage.ItemUId = imageListSchema.Items.GetByName("BuyNowCenter").UId;
			string buyNowButtonCenterImage = controlImage.GetImageUrl();
			controlImage.ItemUId = imageListSchema.Items.GetByName("BuyNowRight").UId;
			string buyNowButtonRightImage = controlImage.GetImageUrl();
			
			string cssScript = @"<style>
			.demo-buttonLayoutEl {
				top: 0px !important;
				z-index: 2;
			}
			.demo-table {
				height: 100%;
				width: 100%;
			}
			.demo-tb-tr-td-border {
				width: 5px;
			}
			.demo-tb-tr-left-buynowbutton {
				background: url(""" + buyNowButtonLeftImage + @""") no-repeat 0 0px;
			}
			.demo-tb-tr-center-buynowbutton {
				background: url(""" + buyNowButtonCenterImage + @""");
				border-spacing: 0px;
			}
			.demo-tb-tr-right-buynowbutton {
				background: url(""" + buyNowButtonRightImage + @""") no-repeat 0 0px;
			}
			
			.demo-link-wrap {
				padding: 0 10px 0 10px;
			}
			.demo-link {
				color: white;
				font-family: Tahoma;
				font-size: 11px;
				font-weight: bold;
				text-align: center;
				cursor: pointer;
				letter-spacing: normal;
				word-spacing: normal;
				line-height: normal;
				text-transform: none;
				text-indent: 0px;
				text-shadow: none;
				text-decoration: none;
			}	
			</style>";
			
			bool isEnglish = IsEnglishLocalization();
			string script = @"
			Terrasoft.DemoButtons = function() {
			var padding = 30;
			var buyNowButtonConfig = {
				caption: '" + BuyLinkCaption + @"',
				linkUrl: '" + BuyLinkUrl + @"',
				openInNewWindow: false,
				windwParameters: '',
				windowName: ''
			};
			
			function createButton(id, demoButtonConfig, img) {
				
				var padding = 30;
				var buttonLayout = new Terrasoft.ControlLayout({
					id: id,
					cls: 'demo-buttonLayoutEl',
					height: 27,
					margins: '0 0 0 7px',
					width: 1,
					demoButtonConfig: demoButtonConfig
				});
				buttonLayout.on('rendercomplete', function () {
					onControlLayoutRenderComplete(buttonLayout, img);
				}, this);
				return buttonLayout;
			};
			
			function createPreparedButton(id, el) {
				
				var buttonLayout = new Terrasoft.ControlLayout({
					id: id,
					cls: 'demo-buttonLayoutEl',
					height: 27,
					width: 1,
					margins: '0 0 0 7px'
				});
				buttonLayout.on('rendercomplete', function () {
					onControlLayoutRenderCompleteForPreparedElement(buttonLayout, el);
				}, this);
				return buttonLayout;
			};
			
			function onControlLayoutRenderComplete(buttonLayout, img) {
				
				var el = buttonLayout.el;
				var id = el.id;
				var template = new Ext.Template(
					'<table cellspacing=""0"" border=""0"" cellpadding=""0"" class=""demo-table"">',
						'<tr>',
							'<td class=""demo-tb-tr-td-border demo-tb-tr-left-{id}"">',
							'</ td>',
							'<td class=""demo-tb-tr-center-{id}"">',
							'<div id=""{id}_label_wrap"" class=""demo-link-wrap"">',
							'<a id=""{id}_link"" class=""demo-link"" href=""{demoButtonUrl}"">{caption}</ a>',
							'</ div>',
							'</ td>',
							'<td class=""demo-tb-tr-td-border demo-tb-tr-right-{id}"">',
							'</ td>',
						'</ tr>',
					'</ table>'
				);
				config = {
					caption: buttonLayout.demoButtonConfig.caption,
					id: id,
					demoButtonUrl: '#'
				};
				if (buttonLayout.demoButtonConfig.openInNewWindow == false) {
					config.demoButtonUrl = buttonLayout.demoButtonConfig.linkUrl
				}
				var html = template.apply(config);
				el.dom.innerHTML = html;
				if(img) {
					Ext.fly(id + '_link').dom.appendChild(img);
				}
				if (buttonLayout.demoButtonConfig.openInNewWindow == true) {
					var url = buttonLayout.demoButtonConfig.linkUrl;
					var windowName = buttonLayout.demoButtonConfig.windowName;
					var windwParameters = buttonLayout.demoButtonConfig.windwParameters;
					Ext.fly(id + '_link').on('click', function(event, el) {
						window.open(url, windowName, windwParameters);
						return false;
					}, this);
				} else {
					Ext.fly(id + '_link').on('click', function(event, el) {
						var parentWindow = window.parent || window;
						var url = buttonLayout.demoButtonConfig.linkUrl;
						event.preventDefault();
			    		parentWindow.location.replace(url);
						return false;
					}, this);
				}
			
			};
			
			function onControlLayoutRenderCompleteForPreparedElement(buttonLayout, elHtml) {
				
				var id = buttonLayout.el.id;
				var template = new Ext.Template(
					'<table cellspacing=""0"" border=""0"" cellpadding=""0"" class=""demo-table"">',
						'<tr>',
							'<td class=""demo-tb-tr-td-border demo-tb-tr-left-{id}"">',
							'</ td>',
							'<td class=""demo-tb-tr-center-{id}"">',
							'<div id=""{id}_label_wrap"" class=""demo-link-wrap"">',
							'{elHtml}',
							'</ div>',
							'</ td>',
							'<td class=""demo-tb-tr-td-border demo-tb-tr-right-{id}"">',
							'</ td>',
						'</ tr>',
					'</ table>'
				);
				var html = template.apply({id:id, elHtml:elHtml});
				buttonLayout.el.dom.innerHTML = html;
			}
			
			function setTextWidth(button) {
				var width = Ext.fly(button.id + '_link').getTextWidth() + padding + (Ext.isIE9 ? 1 : 0);
				button.setWidth(width);
			};
			
			function setImageWidth(button, img) {
				var width = img.width + padding;
				button.setWidth(width);
			};
			
			return {
				show: function(targetMultiLevelTabs) {
					
					var toolsLayout = targetMultiLevelTabs.toolsLayout;
					var buyNowButton = createButton('buynowbutton', buyNowButtonConfig, false);
					var spacer = new Ext.Spacer({size: '170px'});
					targetMultiLevelTabs.insert(0, spacer, true);
					targetMultiLevelTabs.insert(0, buyNowButton, true)
					setTextWidth(buyNowButton);
			
					var endLayout = function () {
						targetMultiLevelTabs.toolsLayout.doLayout();
						targetMultiLevelTabs.onToolsLayoutChange();
					}
				}
			}
			}();
			
			Ext.onReady(function() {
			
			Terrasoft.DemoButtons.show(PageContainer_MultiLevelTabs);
			});";
			cs.RegisterClientScriptBlock(Page.AspPage.GetType(), "demoButtonsCSs", cssScript);
			Page.AddScript(script);
		}

		public virtual void SubscribeOnMessagePanelCloseEvent() {
			var scr = string.Format(@"{0}.on('messageclosed', function(msgPanel, messageItem) {{
				//Terrasoft.AjaxMethods.ThrowClientEventWithParameters('{1}', 'MessagePanelMessageClosed', {{messageId: messageItem.id}});
				if (messageItem.id == '{2}') 
					this.callPageMethod('ThrowEvent', {{formProxyArg:'htmlForm',viewStateMode:'include',signalName:'MessagePanelMessageClosed', messageId: messageItem.id}},null);
				}},
				{0})", Page.BaseMessagePanel.ClientID, InstanceUId, "LDAPUsersWereAdded");
			Page.AddScript(scr);
		}

		public virtual string GetWelcomeWindowScript() {
			var sb = new StringBuilder();
			if (string.IsNullOrEmpty(SelectedModuleCode)) {
					return string.Empty;
			}
			Guid imageSchemaUId = Guid.Empty;
			Guid imageUId = Guid.Empty;
			
			var imageSchema = UserConnection.Workspace.SchemaManagerProvider.GetManager("ImageListSchemaManager")
								.GetInstanceByName("ModuleInformationImageListSchema") as ImageListSchema;
			
			var image = imageSchema.FindItemByName(SelectedModuleCode);
			if (image == null) {
				return string.Empty;
			}
			imageSchemaUId = imageSchema.UId;
			imageUId = image.UId;
			sb.Append(@"var moduleInfoWindow = new Terrasoft.Window({
						name: 'moduleInfoWindow',
						caption: %WELCOMESCREENCAPTION%,
						resizable: false,
						width: 800,
						frame: true,
						height: 600,
						modal: true,
						frameStyle: 'padding: 0 0 0 0',
						closeAction: 'hide'			
					});
					moduleInfoWindow.on('close', function() { window.Terrasoft.AjaxMethods.ThrowClientEventWithParameters(%PROCESSUID%, 'WelcomeScreenClosed', '{neverShow:' + dontShowCheckBox.checked + '}');});
					
					var imageLayout = new Terrasoft.ControlLayout({
						id: 'imageLayout',
						direction: 'horizontal',
						width: '100%',
						height: '100%'			
					});
					var informationImageBox = new Terrasoft.ImageBox({
						id: 'informationImageBox',
						center: true,
						width: '100%',
						height: '100%'
					});
					informationImageBox.setImage({
						source:'ImageListSchema',
						schemaUId: %IMAGESCHEMAUID%,
						itemUId: %IMAGEUID%
					});
					imageLayout.add(informationImageBox);
					
					var footerLayout = new Terrasoft.ControlLayout({
						width: '100%',			
						displayStyle: 'footer',
						edges: '1 0 0 0',
						align: 'bottom',
						fitHeightByContent: true
					});
					var leftSpacer = new Ext.Spacer({ size: '100%' });
					var rightSpacer = new Ext.Spacer({ size: '10px' });
					var closeButton = new Terrasoft.Button({
						id: 'closeButton',
						caption: %CLOSEBUTTONCAPTION%,
						handler: function() {
							moduleInfoWindow.close();
						}
					});
					var helpButton = new Terrasoft.Button({
						id: 'verySpecialHelpButtonId',
						imageConfig: {
							source: 'ResourceManager',
							resourceManagerName: 'Terrasoft.WebApp',
							resourceItemName: 'help.png'
						},
						handler: function() {
							Terrasoft.HelpContext.showHelp(%HELPCONTEXTID%, null);
						}
					});
					
					var dontShowCheckBox = new Terrasoft.CheckBox({
						id: 'dontShowCheckBox',
						caption: %DONTSHOWCHECKBOXCAPTION%,
						checked: true
					});
					
					footerLayout.add(helpButton);
					footerLayout.add(leftSpacer);
					footerLayout.add(dontShowCheckBox);
					footerLayout.add(rightSpacer);
					footerLayout.add(closeButton);
					
					moduleInfoWindow.add(imageLayout);
					moduleInfoWindow.add(footerLayout);		
					moduleInfoWindow.show();		
					");
			string result = sb.ToString();
			return result.Replace("%DONTSHOWCHECKBOXCAPTION%", Json.Serialize(DontShowCheckboxCaption))
				.Replace("%CLOSEBUTTONCAPTION%", Json.Serialize(CloseInformationWindowCaption))
				.Replace("%PROCESSUID%", Json.Serialize(InstanceUId))
				.Replace("%IMAGESCHEMAUID%", Json.Serialize(imageSchemaUId.ToString()))
				.Replace("%IMAGEUID%", Json.Serialize(imageUId.ToString()))
				.Replace("%HELPCONTEXTID%", Json.Serialize(SelectedModuleHelpContextId))
				.Replace("%WELCOMESCREENCAPTION%", Json.Serialize(string.Format(WelcomeScreenCaption, SelectedModuleCaption)));
		}

		public virtual object GetProfileData(string profileKey) {
			return Terrasoft.Configuration.CommonUtilities.ReadProfileData(UserConnection, (Page.AspPage as Terrasoft.UI.WebControls.Page).UId, profileKey);
		}

		public virtual bool NeedShowWelcomeScreen() {
			if (IsDemoBuild)
			{
				string moduleIdStr = SelectedModuleId.ToString();
				if(Page.AspPage.Request.Cookies[WelcomeScreenDataKey] != null) {
					object cookieData = Page.AspPage.Request.Cookies[WelcomeScreenDataKey][moduleIdStr];
					if (cookieData != null) {
						return !Boolean.Parse(cookieData as string);
					}
				}	
			} else {
				object profileData = GetProfileData(WelcomeScreenDataKey);
				if (profileData != null) {
					return !(bool)profileData;
				}	
			}
			return true;
		}

		public virtual Tuple<string, string, string> GetModuleInfoByUId(Guid UId) {
			Tuple<string, string, string> result = new Tuple<string, string, string>(string.Empty, string.Empty, string.Empty);
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(entitySchemaManager, "SysModule");
			query.Cache = UserConnection.SessionCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			var codeColumnName = query.AddColumn("Code").Name;
			var helpContextColumnName = query.AddColumn("HelpContextId").Name;
			var captionColumnName = query.AddColumn("Caption").Name;
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", UId));
			query.CacheItemName = string.Format("SysModuleInfo_{0}", UId);
			var entities = query.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				string code = entities[0].GetTypedColumnValue<string>(codeColumnName);
				string helpId = entities[0].GetTypedColumnValue<string>(helpContextColumnName);
				string caption = entities[0].GetTypedColumnValue<string>(captionColumnName);
				result = new Tuple<string, string, string>(code, helpId, caption);
			}
			return result;
		}

		public virtual void ResetWelcomeScreenSettings() {
			if (IsDemoBuild)
			 {
				if (Page.AspPage.Request.Cookies[WelcomeScreenDataKey] != null) {
			    	var cookie = new HttpCookie(WelcomeScreenDataKey);
			    	cookie.Expires = DateTime.Now.AddDays(-1d);
			    	Page.AspPage.Response.Cookies.Add(cookie);
				}
			} else {
				Terrasoft.Configuration.CommonUtilities.DeleteProfileData(UserConnection, (Page.AspPage as Terrasoft.UI.WebControls.Page).UId, "WelcomeScreen");
			}
		}

		public virtual void FillSearchModules() {
			Page.ClearToolButton.Hide();
			Page.ClearToolButton.Image.Source = Terrasoft.UI.WebControls.ControlImageSource.ResourceManager;
			Page.ClearToolButton.Image.ResourceManagerName = "Terrasoft.UI.WebControls";
			Page.ClearToolButton.Image.ResourceItemName = "toolbutton-close.gif";
			var appCache = UserConnection.ApplicationCache.WithLocalCaching();
			var modulesCollection = Terrasoft.Configuration.CommonUtilities.GetSelectData(UserConnection, Terrasoft.Configuration.CommonUtilities.GetGlobalSearchModuleSelect, appCache, Terrasoft.Configuration.CacheUtilities.GlobalSearchCacheGroup);
			var moduleCaptionColumn = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModule", "Caption");
			modulesCollection.Sort(delegate(Dictionary<string, object> module1, Dictionary<string, object> module2) {
						return module1[moduleCaptionColumn].ToString().CompareTo(module2[moduleCaptionColumn].ToString()); });
			var button = Page.ModulesToolButton;
			var menu = button.Menu;
			menu.RemoveAll();
			string menuScript = string.Empty;
			var moduleSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysModule");
			var imageColumnUId = moduleSchema.Columns.GetByName("Image16").UId;
			var schemaUId = moduleSchema.UId;
			var currentSearchModuleId = Guid.Empty;
			foreach(var module in modulesCollection) {
				var moduleId = module["sysModuleId"] == DBNull.Value ? Guid.Empty : new Guid(module["sysModuleId"].ToString());
				if (currentSearchModuleId == Guid.Empty) {
					currentSearchModuleId = moduleId;
				} else if (moduleId == SelectedModuleId) {
					currentSearchModuleId = moduleId;
				}
				var moduleCaption = module[moduleCaptionColumn].ToString();
				var menuItem = new WebControls.MenuItem();
				menuItem.Image = new ControlImage() {
					Source = ControlImageSource.EntityColumn,
					SchemaUId = schemaUId,
					EntityPrimaryColumnValue = moduleId,
					UsePrimaryImageColumn = false,
					EntitySchemaColumnUId = imageColumnUId							
				};
				menuItem.CreatedByAjax = true;
				menuItem.EnableViewState = false;
				menuItem.UId = Guid.NewGuid();
				menuItem.Name = string.Format("{0}_searchModules_{1}",button.ClientID, moduleId.ToString("N"));
				menuItem.Tag = moduleId.ToString();
				menuItem.Caption = moduleCaption;
				menuItem.AjaxEvents.Click.SignalName = "ChangeSearchModule";
				menuItem.AjaxEvents.Click.AjaxEventTargetControlID = button.ClientID;
				menu.Add(menuItem);
				menuScript = string.Format("window.{0} = {1};\n", menuItem.ClientID, menuItem.GenerateControlScript(true, null));
				menuScript += string.Format("{0}.getMenu().addItem(window.{1});\n", button.ClientID, menuItem.ClientID);
				Page.AddScript(menuScript);
			}
			menuScript += string.Format("{0}.onContentChanged();\n", button.ClientID);
			Page.AddScript(menuScript);
			var queryString = Page.Request.QueryString.ToString();
			if(queryString.Contains("GlobalSearchValue")) {
				Page.SearchEdit.Text = Page.Request.QueryString["GlobalSearchValue"];
				var searchText = Page.SearchEdit.Text;
				if (string.Empty.Equals(searchText)) {
					Page.ClearToolButton.Hide();	
				} else {
					Page.ClearToolButton.Show();
				}
				var modulePageContainer = Page.ContentControlLayout.Items[0] as PageContainer;
				if (modulePageContainer.PageInstance != null) {
					var modulePageProcess = modulePageContainer.PageInstance.Process;
					modulePageProcess.SetPropertyValue("SearchPrimaryDisplayColumnValue", Page.SearchEdit.Text);
				}
			}
			Page.SearchEdit.Focus();
			var script = new StringBuilder(@"function onSearchEditSpecialKey(el, e) {
				var key = e.getKey();
				switch (key) {
					case e.ENTER : ");
			script.AppendFormat("window.Terrasoft.AjaxMethods.ThrowClientEvent('{0}', '{1}');", 
				Page.Process.InstanceUId, "GlobalSearch");		
			script.Append("\nbreak;\ndefault :\nbreak;\n}\n}");
			script.Append(string.Format("{0}.on('specialkey', onSearchEditSpecialKey);", Page.SearchEdit.ClientID));
			Page.ScriptManager.AddScript(script.ToString());
			Page.SearchToolButton.AjaxEvents.Click.SignalName = "GlobalSearch";
			Page.SearchEdit.Image = new ControlImage() {
				Source = ControlImageSource.EntityColumn,
				SchemaUId = schemaUId,
				EntityPrimaryColumnValue = currentSearchModuleId,
				EntitySchemaColumnUId = imageColumnUId							
			};
			SearchModuleId = currentSearchModuleId;
		}

		public virtual void BuildWorkspaces(Dictionary<string, object> node, TabHeaderCollection tabHeaders) {
			var isWorkspace = node == null || node["sysModuleId"] == DBNull.Value;
			if (isWorkspace) {
				TabHeaderCollection subTabHeaders = null;
				TabHeader subTabHeader = null;
				var workspaceChildElements = GetWorkspaceChildElements(node);
				if (node != null && workspaceChildElements.Count > 0) {
					subTabHeader = CreateItemTabHeader(node, true);
					if (subTabHeader != null) {
						tabHeaders.Add(subTabHeader);
						subTabHeaders = subTabHeader.TabHeaders;
					}
				} else {
					subTabHeaders = tabHeaders;
				}
				if (subTabHeaders != null) {
					foreach (var childElement in workspaceChildElements) {
						BuildWorkspaces(childElement, subTabHeaders);
					}
					if (subTabHeader != null) {
						bool hidden = subTabHeaders.Count == 0;
						if (!hidden) {
							foreach (var tabHeader in subTabHeaders) {
								hidden = tabHeader.Hidden;
								if (!hidden) {
									break;
								}
							}
						}
						subTabHeader.Hidden = hidden;
					}
				}
			} else {
				var subTabHeader = CreateItemTabHeader(node, false);
				if (subTabHeader != null) {
					tabHeaders.Add(subTabHeader);
				}
			}
		}

		public virtual TabHeader CreateItemTabHeader(Dictionary<string, object> node, bool isSysModuleFolder) {
			var itemTab = new TabHeader();
			var sysModuleSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysModule");
			var sysModuleFolderId = node["subSysModuleFolderId"] == DBNull.Value ? Guid.Empty : new Guid(node["subSysModuleFolderId"].ToString());
			var pageSchemaId = node["sysModulePageSchemaId"] == DBNull.Value ? Guid.Empty : new Guid(node["sysModulePageSchemaId"].ToString());
			var sysModuleId = node["sysModuleId"] == DBNull.Value ? Guid.Empty : new Guid(node["sysModuleId"].ToString());
			itemTab.Tag = string.Format("{0}|{1}|{2}", sysModuleFolderId, sysModuleId, pageSchemaId);
			var image20ColumnUId = sysModuleSchema.Columns.GetByName("Image20").UId;
			if (isSysModuleFolder) {
				var url = string.Format(@"{0}://{1}{2}/",
											Page.Request.Url.Scheme,
											Page.Request.Url.Host,
											(Page.Request.Url.Port == 0 ? "" : ":" + Page.Request.Url.Port));
				itemTab.ShowMenuItemCaption = true;
				string sysModuleFolderCaptionColumnName = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleFolder", "Caption");
				itemTab.Caption = node[sysModuleFolderCaptionColumnName].ToString();
				itemTab.Name = "h" + sysModuleFolderId.ToString("N");
				if (sysModuleId != Guid.Empty) {
					itemTab.Image = new ControlImage {
						Source = ControlImageSource.EntityColumn,
						SchemaUId = sysModuleSchema.UId,
						EntityPrimaryColumnValue = sysModuleId,
						UsePrimaryImageColumn = false,
						EntitySchemaColumnUId = image20ColumnUId
					};
				}
			} else {
				var entitySchemaId = node["sysModuleEntitySchemaId"] == DBNull.Value ? Guid.Empty : new Guid(node["sysModuleEntitySchemaId"].ToString());
				if ((entitySchemaId != Guid.Empty && CheckModuleReadingRights(entitySchemaId))
						|| entitySchemaId == Guid.Empty) {
					var parentSysModuleFolderId = new Guid(node["sysModuleFolderId"].ToString());
					var itemId = new Guid(node["itemId"].ToString());
					itemTab.Name = string.Format("{0}_{1}_{2}",
						                            parentSysModuleFolderId.ToString("N"), sysModuleId.ToString("N"), itemId.ToString("N"));
					string sysModuleCaptionColumnName = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModule", "Caption");
					itemTab.Caption = node[sysModuleCaptionColumnName].ToString();
					if (FirstPageSchemaIdToLoad == Guid.Empty) {
						FirstPageSchemaIdToLoad = entitySchemaId != Guid.Empty
						                          	? pageSchemaId
						                          	: new Guid("bce16f0b-429d-4637-8c58-0dc7ebfec887");
					}
					if (sysModuleId != Guid.Empty) {
						itemTab.Image = new ControlImage {
							Source = ControlImageSource.EntityColumn,
							SchemaUId = sysModuleSchema.UId,
							EntityPrimaryColumnValue = sysModuleId,
							UsePrimaryImageColumn = false,
							EntitySchemaColumnUId = image20ColumnUId
						};
					}
				} else {
					return null;
				}
			}
			return itemTab;
		}

		public virtual List<Dictionary<string, object>> GetWorkspaceChildElements(Dictionary<string, object> node) {
			var collection = GetWorkspaceEntityCollection();
			var result = new List<Dictionary<string, object>>();
			if (node != null) {
				foreach (var item in collection) {
					Guid itemSysModuleFolderId = item["sysModuleFolderId"] == DBNull.Value ? Guid.Empty : new Guid(item["sysModuleFolderId"].ToString());
					Guid nodeSubSysModuleId = node["subSysModuleFolderId"] == DBNull.Value ? Guid.Empty : new Guid(node["subSysModuleFolderId"].ToString());
					if (itemSysModuleFolderId == nodeSubSysModuleId) {
						result.Add(item);
					}
				}
			} else {
				foreach (var item in collection) {
					if (item["sysModuleFolderId"] == DBNull.Value) {
						result.Add(item);
					}
				}
			}
			return result;
		}

		public virtual List<Dictionary<string, object>> GetModuleEdits() {
			var result = new List<Dictionary<string, object>>();
			var select = Terrasoft.Configuration.CommonUtilities.GetModuleEditsSelect(UserConnection);
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				 using (var dr = select.ExecuteReader(dbExecutor)) {
					while (dr.Read()) { 
						var item = new Dictionary<string, object>();
						var schemaUId = UserConnection.DBTypeConverter.DBValueToGuid(dr[0]==DBNull.Value?Guid.Empty:dr[0]);//0
						var typeColumnUId = UserConnection.DBTypeConverter.DBValueToGuid(dr[2]==DBNull.Value?Guid.Empty:dr[2]);//2
						var typeColumnValue = UserConnection.DBTypeConverter.DBValueToGuid(dr[3]==DBNull.Value?Guid.Empty:dr[3]);//3
						var sysModuleId = UserConnection.DBTypeConverter.DBValueToGuid(dr[5]==DBNull.Value?Guid.Empty:dr[5]);//5
						string caption = GetAddMenuItemCaption(schemaUId, typeColumnUId, typeColumnValue);
						item["caption"] = caption;
						item["sysModuleEditId"] = UserConnection.DBTypeConverter.DBValueToGuid(dr[1]==DBNull.Value?Guid.Empty:dr[1]);//1
						item["typeColumnUId"] = typeColumnUId;
						item["typeColumnValue"] = typeColumnValue;
						item["editPageUId"] = UserConnection.DBTypeConverter.DBValueToGuid(dr[4]==DBNull.Value?Guid.Empty:dr[4]);//4
						item["sysEntitySchemaUId"] = schemaUId;
						item["sysModuleId"] = sysModuleId;
						result.Add(item);
					}
				 }
			}
			result.Sort(delegate(Dictionary<string, object> p1, Dictionary<string, object> p2) { 
				return p1["caption"].ToString().CompareTo(p2["caption"].ToString());});
			return result;
		}

		public virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddMenuItem(string caption, Guid editPageUId, Guid sysModuleEditId, Guid typeColumnUId, Guid typeColumnValue) {
			var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			menuItem.CreatedByAjax = true;
			menuItem.EnableViewState = false;
			menuItem.UId = Guid.NewGuid();
			menuItem.Name = string.Format("AddMenuItem_{0}", sysModuleEditId.ToString("N"));
			menuItem.Tag = editPageUId.ToString();
			menuItem.Caption = caption;
			return menuItem;
		}

		public virtual void FillAddButtonMenu() {
			List<Dictionary<string, object>> moduleEdits = GetModuleEdits();
			string script = string.Empty;
			string formatString = "{0}.on('click', function(el) {{ {1} }}, this)";
			var sysModuleSchema = UserConnection.EntitySchemaManager.GetItemByName("SysModule");
			foreach (Dictionary<string, object> moduleEdit in moduleEdits) {
				var caption = moduleEdit["caption"].ToString();
				Guid editPageUId = new Guid(moduleEdit["editPageUId"].ToString());
				Guid sysEntitySchemaUId = new Guid(moduleEdit["sysEntitySchemaUId"].ToString());
				Guid sysModuleEditId = new Guid(moduleEdit["sysModuleEditId"].ToString());
				Guid typeColumnUId = new Guid(moduleEdit["typeColumnUId"].ToString());
				Guid typeColumnValue = new Guid(moduleEdit["typeColumnValue"].ToString());
				Guid sysModuleId = new Guid(moduleEdit["sysModuleId"].ToString());
				var menuItem = CreateAddMenuItem(caption, editPageUId, sysModuleEditId, typeColumnUId, typeColumnValue);
				menuItem.Image = new ControlImage {
						Source = ControlImageSource.EntityColumn,
						SchemaUId = sysModuleSchema.UId,
						EntityPrimaryColumnValue = sysModuleId,
						UsePrimaryImageColumn = true
				};
				script = string.Format("window.{0} = {1};\n", menuItem.ClientID, menuItem.GenerateControlScript(true, null));
				Page.AddButton.Menu.Add(menuItem);
				script += string.Format("{0}.getMenu().addItem(window.{1});\n", Page.AddButton.ClientID, menuItem.ClientID);
				var openPageParameters = new Dictionary<string, object>();
				openPageParameters["entitySchemaUId"] = sysEntitySchemaUId;
				openPageParameters["sysModuleEditId"] = sysModuleEditId;
				openPageParameters["parentModuleId"] = SelectedModuleId;
				if (typeColumnUId != Guid.Empty && typeColumnValue != Guid.Empty) {
					openPageParameters["typeColumnUId"] = typeColumnUId;
					openPageParameters["typeId"] = typeColumnValue;
				}
				script += string.Format(formatString, menuItem.ClientID, 
					Terrasoft.Configuration.ClientScriptUtilities.GetRegisterAddPageScript(editPageUId, openPageParameters));
				Page.AddScript(script);
			}
		}

		public virtual string GetAddMenuItemCaption(Guid schemaUId, Guid typeColumnUId, Guid typeId) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(schemaUId);
			var result = schema.Caption;
			if (typeColumnUId != Guid.Empty && typeId != Guid.Empty) {
				var typeColumn = schema.Columns.GetByUId(typeColumnUId);
				var typeSchema = typeColumn.ReferenceSchema;
				var query = new EntitySchemaQuery(typeSchema);
				query.Cache = UserConnection.SessionCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
				var displayColumnName = query.AddColumn(typeSchema.GetPrimaryDisplayColumnName()).Name;
				query.Filters.Add(query.CreateFilterWithParameters(
					FilterComparisonType.Equal, typeSchema.GetPrimaryColumnName(), typeId));
				query.CacheItemName = string.Format("TypeEditItemCaption_{0}", typeId);
				var entities = query.GetEntityCollection(UserConnection);
				result = string.Concat(result, ": ", entities[0].GetTypedColumnValue<string>(displayColumnName));
			}
			return result;
		}

		public virtual List<Dictionary<string, object>> GetWorkspaceEntityCollection() {
			var appCache = UserConnection.ApplicationCache.WithLocalCaching();
			List<Dictionary<string, object>> result = TSConfiguration.CommonUtilities.GetSelectData(
				UserConnection, TSConfiguration.CommonUtilities.GetModuleTabSelect, appCache, TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			return result;
		}

		public virtual void RunProcess(string processSchemaName) {
			var schema = ((ProcessSchema)UserConnection.ProcessSchemaManager.FindInstanceByName(processSchemaName));
			var process = schema.CreateProcess(UserConnection);
			if (schema.Parameters.ExistsByName("PageInstanceId")) {
				string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
				string pageInstanceId = instanceId + Page.PageContainer.UniqueID;
				process.SetPropertyValue("PageInstanceId", pageInstanceId);
			}
			process.Execute(UserConnection);
		}

		public virtual bool IsEnglishLocalization() {
			return (Guid)SysSettings.GetValue(UserConnection, "PrimaryCulture") == new Guid("A5420246-0A8E-E111-84A3-00155D054C03");
		}

		public virtual void RegisterChatLinks() {
			System.Web.UI.ClientScriptManager cs = Page.AspPage.ClientScript;
			ImageListSchema imageListSchema = UserConnection.ImageListSchemaManager.GetInstanceByName("DemoButtons");
			ControlImage controlImage = new ControlImage() {
			                Source = ControlImageSource.ImageListSchema,
			                SchemaUId = imageListSchema.UId,
			                ItemUId = imageListSchema.Items.GetByName("BuyNowLeft").UId
			};
			string buyNowButtonLeftImage = controlImage.GetImageUrl();
			controlImage.ItemUId = imageListSchema.Items.GetByName("BuyNowCenter").UId;
			string buyNowButtonCenterImage = controlImage.GetImageUrl();
			controlImage.ItemUId = imageListSchema.Items.GetByName("BuyNowRight").UId;
			string buyNowButtonRightImage = controlImage.GetImageUrl();
			
			string cssScript = @"<style>
			                .demo-buttonLayoutEl {
			                               top: 0px !important;
			                }
			                .demo-table {
			                               height: 100%;
			                               width: 100%;
			                }
			                .demo-tb-tr-td-border {
			                               width: 5px;
			                }
			                .demo-tb-tr-left-buynowbutton {
			                               background: url(""" + buyNowButtonLeftImage + @""") no-repeat 0 0px;
			                }
			                .demo-tb-tr-center-buynowbutton {
			                               background: url(""" + buyNowButtonCenterImage + @""");
			                               border-spacing: 0px;
			                }
			                .demo-tb-tr-right-buynowbutton {
			                               background: url(""" + buyNowButtonRightImage + @""") no-repeat 0 0px;
			                }
			                
			                .demo-link-wrap {
			                               padding: 0 10px 0 10px;
			                }
			                .demo-link {
			                               color: white;
			                               font-family: Tahoma;
			                               font-size: 11px;
			                               font-weight: bold;
			                               text-align: center;
			                               cursor: pointer;
			                               letter-spacing: normal;
			                               word-spacing: normal;
			                               line-height: normal;
			                               text-transform: none;
			                               text-indent: 0px;
			                               text-shadow: none;
			                               text-decoration: none;
			                }              
			                </style>";
			
			bool isEnglish = IsEnglishLocalization();
			string script = @"
			                Terrasoft.DemoButtons = function() {
			                var padding = 30;
			                var buyNowButtonConfig = {
			                               caption: '" + BuyLinkCaption + @"',
			                               linkUrl: '" + BuyLinkUrl + @"',
			                               openInNewWindow: false,
			                               windwParameters: '',
			                               windowName: ''
			                };
			
			                function createButton(id, demoButtonConfig, img) {
			                               var padding = 30;
			                               var buttonLayout = new Terrasoft.ControlLayout({
			                                               id: id,
			                                               cls: 'demo-buttonLayoutEl',
			                                               height: 27,
			                                               margins: '0 0 0 7px',
			                                               width: 1,
			                                               demoButtonConfig: demoButtonConfig
			                               });
			                               buttonLayout.on('rendercomplete', function () {
			                                               onControlLayoutRenderComplete(buttonLayout, img);
			                               }, this);
			                               return buttonLayout;
			                };
			
			                function createPreparedButton(id, el) {
			                               var buttonLayout = new Terrasoft.ControlLayout({
			                                               id: id,
			                                               cls: 'demo-buttonLayoutEl',
			                                               height: 27,
			                                               width: 1,
			                                               margins: '0 0 0 7px'
			                               });
			                               buttonLayout.on('rendercomplete', function () {
			                                               onControlLayoutRenderCompleteForPreparedElement(buttonLayout, el);
			                               }, this);
			                               return buttonLayout;
			                };
			
			                function onControlLayoutRenderComplete(buttonLayout, img) {
			                               var el = buttonLayout.el;
			                               var id = el.id;
			                               var template = new Ext.Template(
			                                               '<table cellspacing=""0"" border=""0"" cellpadding=""0"" class=""demo-table"">',
			                                                               '<tr>',
			                                                                              '<td class=""demo-tb-tr-td-border demo-tb-tr-left-{id}"">',
			                                                                              '</ td>',
			                                                                              '<td class=""demo-tb-tr-center-{id}"">',
			                                                                              '<div id=""{id}_label_wrap"" class=""demo-link-wrap"">',
			                                                                              '<a id=""{id}_link"" class=""demo-link"" href=""{demoButtonUrl}"">{caption}</ a>',
			                                                                              '</ div>',
			                                                                              '</ td>',
			                                                                              '<td class=""demo-tb-tr-td-border demo-tb-tr-right-{id}"">',
			                                                                              '</ td>',
			                                                               '</ tr>',
			                                               '</ table>'
			                               );
			                               config = {
			                                               caption: buttonLayout.demoButtonConfig.caption,
			                                               id: id,
			                                               demoButtonUrl: '#'
			                               };
			                               if (buttonLayout.demoButtonConfig.openInNewWindow == false) {
			                                               config.demoButtonUrl = buttonLayout.demoButtonConfig.linkUrl
			                               }
			                               var html = template.apply(config);
			                               el.dom.innerHTML = html;
			                               if(img) {
			                                               Ext.fly(id + '_link').dom.appendChild(img);
			                                }
			                               if (buttonLayout.demoButtonConfig.openInNewWindow == true) {
			                                               var url = buttonLayout.demoButtonConfig.linkUrl;
			                                               var windowName = buttonLayout.demoButtonConfig.windowName;
			                                               var windwParameters = buttonLayout.demoButtonConfig.windwParameters;
			                                               Ext.fly(id + '_link').on('click', function(event, el) {
			                                                               window.open(url, windowName, windwParameters);
			                                                               return false;
			                                               }, this);
			                               } else {
			                                               Ext.fly(id + '_link').on('click', function(event, el) {
			                                                               var parentWindow = window.parent || window;
			                                                               var url = buttonLayout.demoButtonConfig.linkUrl;
			                                                               event.preventDefault();
			                               parentWindow.location.replace(url);
			                                                               return false;
			                                               }, this);
			                               }
			                
			                };
			                
			                function onControlLayoutRenderCompleteForPreparedElement(buttonLayout, elHtml) {
			                               var id = buttonLayout.el.id;
			                               var template = new Ext.Template(
			                                               '<table cellspacing=""0"" border=""0"" cellpadding=""0"" class=""demo-table"">',
			                                                               '<tr>',
			                                                                              '<td class=""demo-tb-tr-td-border demo-tb-tr-left-{id}"">',
			                                                                              '</ td>',
			                                                                              '<td class=""demo-tb-tr-center-{id}"">',
			                                                                              '<div id=""{id}_label_wrap"" class=""demo-link-wrap"">',
			                                                                              '{elHtml}',
			                                                                              '</ div>',
			                                                                              '</ td>',
			                                                                              '<td class=""demo-tb-tr-td-border demo-tb-tr-right-{id}"">',
			                                                                              '</ td>',
			                                                               '</ tr>',
			                                               '</ table>'
			                               );
			                               var html = template.apply({id:id, elHtml:elHtml});
			                               buttonLayout.el.dom.innerHTML = html;
			                }
			                
			                function setTextWidth(button) {
			                               var width = Ext.fly(button.id + '_link').getTextWidth() + padding + (Ext.isIE9 ? 1 : 0);
			                               button.setWidth(width);
			                };
			                
			                function setImageWidth(button, img) {
			                               var width = img.width + padding;
			                               button.setWidth(width);
			                };
			                
			                return {
			                               show: function(targetMultiLevelTabs) {
			                                               var toolsLayout = targetMultiLevelTabs.toolsLayout;
			                                               var buyNowButton = createButton('buynowbutton', buyNowButtonConfig, false);
			                                               var spacer = new Ext.Spacer({size: '170px'});
			                                               targetMultiLevelTabs.insert(0, spacer, true);
			                                               targetMultiLevelTabs.insert(0, buyNowButton, true)
			                                               setTextWidth(buyNowButton);
			
			                                               var endLayout = function () {
			                                                               targetMultiLevelTabs.toolsLayout.doLayout();
			                                                               targetMultiLevelTabs.onToolsLayoutChange();
			                                               }
			                               }
			                }
			}();
			
			Ext.onReady(function() {
			Terrasoft.DemoButtons.show(PageContainer_MultiLevelTabs);
			});";
			cs.RegisterClientScriptBlock(Page.AspPage.GetType(), "demoButtonsCSs", cssScript);
			Page.AddScript(script);
		}

		public virtual bool IsRussianLocalization() {
			return (Guid)SysSettings.GetValue(UserConnection, "PrimaryCulture") == new Guid("1A778E3F-0A8E-E111-84A3-00155D054C03");
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ExitButtonClick":
							if (ActivatedEventElements.Contains("ExitButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("ExitButtonClickStartMessage");
						}
						break;
					case "NewRemindingsCountButtonClick":
							if (ActivatedEventElements.Contains("StartMessage2q")) {
							context.QueueTasks.Enqueue("StartMessage2q");
						}
						break;
					case "SettingsModeSettingsButtonMenuItemEvent":
							if (ActivatedEventElements.Contains("SettingsModeSettingsButtonMenuItemEvent")) {
							context.QueueTasks.Enqueue("SettingsModeSettingsButtonMenuItemEvent");
						}
						break;
					case "ImapServersSettingsSettingsButtonMenuItemEvent":
							if (ActivatedEventElements.Contains("ImapServersSettingsSettingsButtonMenuItemEventStartMessage")) {
							context.QueueTasks.Enqueue("ImapServersSettingsSettingsButtonMenuItemEventStartMessage");
						}
						break;
					case "EditSocialAccountsButtonMenuItemEvent":
							if (ActivatedEventElements.Contains("EditSocialAccountsButtonMenuItemEvent")) {
							context.QueueTasks.Enqueue("EditSocialAccountsButtonMenuItemEvent");
						}
						break;
					case "LicensesSettingsButtonMenuItemEvent":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "SetMailChimpSettingsButtonMenuItemEvent":
							if (ActivatedEventElements.Contains("SetMailChimpSettingsButtonMenuItemEventStartMessage")) {
							context.QueueTasks.Enqueue("SetMailChimpSettingsButtonMenuItemEventStartMessage");
						}
						break;
					case "SetIntegrationLogMenuItemEvent":
							if (ActivatedEventElements.Contains("SetIntegrationLogMenuItemEvent")) {
							context.QueueTasks.Enqueue("SetIntegrationLogMenuItemEvent");
						}
						break;
					case "ImportButtonMenuItemClick":
							if (ActivatedEventElements.Contains("ImportButtonMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("ImportButtonMenuItemClickStartMessage");
						}
						break;
					case "CommandGenerationButtonMenuItemEvent":
							if (ActivatedEventElements.Contains("CommandGenerationButtonMenuItemEventStartMessage")) {
							context.QueueTasks.Enqueue("CommandGenerationButtonMenuItemEventStartMessage");
						}
						break;
					case "FindSelectedModule":
							if (ActivatedEventElements.Contains("FindSelectedModule")) {
							context.QueueTasks.Enqueue("FindSelectedModule");
						}
						break;
					case "SelectAndRunProcess":
							if (ActivatedEventElements.Contains("SelectAndRunProcessEvent")) {
							context.QueueTasks.Enqueue("SelectAndRunProcessEvent");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("LookupGridPageClosedEvent")) {
						context.QueueTasks.Enqueue("LookupGridPageClosedEvent");
					}
					break;
					case "ShowMessage":
							if (ActivatedEventElements.Contains("ShowMessageEvent")) {
							context.QueueTasks.Enqueue("ShowMessageEvent");
						}
						break;
					case "SettingsChanged":
							if (ActivatedEventElements.Contains("SettingsChangedEvent")) {
							context.QueueTasks.Enqueue("SettingsChangedEvent");
						}
						break;
					case "MessagePanelLinkClick":
							if (ActivatedEventElements.Contains("MessagePanelLinkClick")) {
							context.QueueTasks.Enqueue("MessagePanelLinkClick");
						}
						break;
					case "MoveToModule":
							if (ActivatedEventElements.Contains("MoveToModule")) {
							context.QueueTasks.Enqueue("MoveToModule");
						}
						break;
					case "HelpCalled":
							if (ActivatedEventElements.Contains("HelpCalledStartMessage")) {
							context.QueueTasks.Enqueue("HelpCalledStartMessage");
						}
						break;
					case "MessagePanelMessageClosed":
							if (ActivatedEventElements.Contains("MessagePanelMessageClosed")) {
							context.QueueTasks.Enqueue("MessagePanelMessageClosed");
						}
						break;
					case "DoShowLDAPMessage":
							if (ActivatedEventElements.Contains("DoShowLDAPMessage")) {
							context.QueueTasks.Enqueue("DoShowLDAPMessage");
						}
						break;
					case "ShowStartProcess":
							if (ActivatedEventElements.Contains("ShowStartProcess")) {
							context.QueueTasks.Enqueue("ShowStartProcess");
						}
						break;
					case "ErrorCheckRequiredLDAPSettings":
							if (ActivatedEventElements.Contains("ErrorCheckRequiredLDAPSettings")) {
							context.QueueTasks.Enqueue("ErrorCheckRequiredLDAPSettings");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("Init")) {
							context.QueueTasks.Enqueue("Init");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("StartMessageNonInterruptingEvent1")) {
							context.QueueTasks.Enqueue("StartMessageNonInterruptingEvent1");
						}
						break;
					case "GlobalSearch":
							if (ActivatedEventElements.Contains("StartGlobalSearch")) {
							context.QueueTasks.Enqueue("StartGlobalSearch");
						}
						break;
					case "ClearToolButtonClick":
							if (ActivatedEventElements.Contains("StartClearToolButtonClick")) {
							context.QueueTasks.Enqueue("StartClearToolButtonClick");
						}
						break;
					case "ChangeSearchModule":
							if (ActivatedEventElements.Contains("StartChangeSearchModule")) {
							context.QueueTasks.Enqueue("StartChangeSearchModule");
						}
						break;
					case "WelcomeScreenClosed":
							if (ActivatedEventElements.Contains("WelcomeScreenClosedStartMessage")) {
							context.QueueTasks.Enqueue("WelcomeScreenClosedStartMessage");
						}
						break;
					case "ShowWelcomeScreenClick":
							if (ActivatedEventElements.Contains("ShowWelcomeScreenClickStartMessage")) {
							context.QueueTasks.Enqueue("ShowWelcomeScreenClickStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ImportButtonMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ImportButtonMenuItemTag", ImportButtonMenuItemTag, Guid.Empty);
			}
			if (!HasMapping("ImportPageSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ImportPageSchemaUId", ImportPageSchemaUId, Guid.Empty);
			}
			if (!HasMapping("CommandGenerationButtonMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CommandGenerationButtonMenuItemTag", CommandGenerationButtonMenuItemTag, Guid.Empty);
			}
			if (!HasMapping("CanStartCommandGeneration") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanStartCommandGeneration", CanStartCommandGeneration, false);
			}
			if (!HasMapping("OpenIntegrationLogMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OpenIntegrationLogMenuItemTag", OpenIntegrationLogMenuItemTag, Guid.Empty);
			}
			if (!HasMapping("IntegrationLogPageSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IntegrationLogPageSchemaUId", IntegrationLogPageSchemaUId, Guid.Empty);
			}
			if (!HasMapping("SysMainPageShellClientId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysMainPageShellClientId", SysMainPageShellClientId, null);
			}
			if (!HasMapping("CanUseMailChimpIntegrationSettings") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanUseMailChimpIntegrationSettings", CanUseMailChimpIntegrationSettings, false);
			}
			if (!HasMapping("MailChimpSettingsPageSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MailChimpSettingsPageSchemaUId", MailChimpSettingsPageSchemaUId, Guid.Empty);
			}
			if (!HasMapping("SetMailChimpSettingsButtonMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SetMailChimpSettingsButtonMenuItemTag", SetMailChimpSettingsButtonMenuItemTag, Guid.Empty);
			}
			if (!HasMapping("SavedDataId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SavedDataId", SavedDataId, Guid.Empty);
			}
			if (!HasMapping("CallSessionDataKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CallSessionDataKey", CallSessionDataKey, null);
			}
			if (!HasMapping("IsDeveloperMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDeveloperMode", IsDeveloperMode, false);
			}
			if (!HasMapping("SearchModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SearchModuleId", SearchModuleId, Guid.Empty);
			}
			if (!HasMapping("CanUseMsgService") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanUseMsgService", CanUseMsgService, false);
			}
			if (!HasMapping("EditTelephonyButtonMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditTelephonyButtonMenuItemTag", EditTelephonyButtonMenuItemTag, Guid.Empty);
			}
			if (SelectedModuleCaption != null) {
				if (SelectedModuleCaption.GetType().IsSerializable ||
					SelectedModuleCaption.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SelectedModuleCaption", SelectedModuleCaption, null);
				}
			}
			if (!HasMapping("SelectedModuleHelpContextId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedModuleHelpContextId", SelectedModuleHelpContextId, null);
			}
			if (!HasMapping("SelectedModuleCode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedModuleCode", SelectedModuleCode, null);
			}
			if (!HasMapping("WelcomeScreenDataKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("WelcomeScreenDataKey", WelcomeScreenDataKey, null);
			}
			if (!HasMapping("IsDemoBuild") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDemoBuild", IsDemoBuild, false);
			}
			if (!HasMapping("LicensesSettingsButtonMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LicensesSettingsButtonMenuItemTag", LicensesSettingsButtonMenuItemTag, Guid.Empty);
			}
			if (!HasMapping("CanManageLicUsers") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanManageLicUsers", CanManageLicUsers, false);
			}
			if (MsgToolInstance != null) {
				if (MsgToolInstance.GetType().IsSerializable ||
					MsgToolInstance.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("MsgToolInstance", MsgToolInstance, null);
				}
			}
			if (!HasMapping("EditSocialAccountsMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSocialAccountsMenuItemTag", EditSocialAccountsMenuItemTag, Guid.Empty);
			}
			if (!HasMapping("MailboxSynchronizationSettingsPageUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MailboxSynchronizationSettingsPageUId", MailboxSynchronizationSettingsPageUId, Guid.Empty);
			}
			if (!HasMapping("SeparatorMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SeparatorMenuItemTag", SeparatorMenuItemTag, Guid.Empty);
			}
			if (!HasMapping("CanManageMailServers") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanManageMailServers", CanManageMailServers, false);
			}
			if (!HasMapping("CanChangeApplicationTuningMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanChangeApplicationTuningMode", CanChangeApplicationTuningMode, false);
			}
			if (!HasMapping("SettingsModeSettingsButtonMenuItemCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SettingsModeSettingsButtonMenuItemCaption", SettingsModeSettingsButtonMenuItemCaption, null);
			}
			if (!HasMapping("MailServerSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MailServerSchemaUId", MailServerSchemaUId, Guid.Empty);
			}
			if (!HasMapping("ImapServersSettingsSettingsButtonMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ImapServersSettingsSettingsButtonMenuItemTag", ImapServersSettingsSettingsButtonMenuItemTag, Guid.Empty);
			}
			if (!HasMapping("SettingsModeSettingsButtonMenuItemTag") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SettingsModeSettingsButtonMenuItemTag", SettingsModeSettingsButtonMenuItemTag, Guid.Empty);
			}
			if (!HasMapping("TuningProcessMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("TuningProcessMode", TuningProcessMode, false);
			}
			if (!HasMapping("IsTuningModule") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsTuningModule", IsTuningModule, false);
			}
			if (!HasMapping("CancelLDAPMessageId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CancelLDAPMessageId", CancelLDAPMessageId, Guid.Empty);
			}
			if (!HasMapping("ShowLDAPMessageId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ShowLDAPMessageId", ShowLDAPMessageId, Guid.Empty);
			}
			if (!HasMapping("CommunityLink") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CommunityLink", CommunityLink, null);
			}
			if (!HasMapping("FAQLinkId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FAQLinkId", FAQLinkId, Guid.Empty);
			}
			if (MoveToParameters != null) {
				if (MoveToParameters.GetType().IsSerializable ||
					MoveToParameters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("MoveToParameters", MoveToParameters, null);
				}
			}
			if (!HasMapping("RemindingsPageUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RemindingsPageUId", RemindingsPageUId, Guid.Empty);
			}
			if (!HasMapping("MessagePanelClickedLinkId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MessagePanelClickedLinkId", MessagePanelClickedLinkId, null);
			}
			if (!HasMapping("CheckingRemindingsInterval") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CheckingRemindingsInterval", CheckingRemindingsInterval, 0);
			}
			if (!HasMapping("GlobalSearchValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("GlobalSearchValue", GlobalSearchValue, null);
			}
			if (!HasMapping("SelectedModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedModuleId", SelectedModuleId, Guid.Empty);
			}
			if (!HasMapping("FirstPageSchemaIdToLoad") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FirstPageSchemaIdToLoad", FirstPageSchemaIdToLoad, Guid.Empty);
			}
			if (!HasMapping("PageSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PageSchemaUId", PageSchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: MainPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class MainPage_Base_TerrasoftEventsProcess : MainPage_Base_TerrasoftEventsProcess<Terrasoft.WebApp.MainPage_Base_TerrasoftSchemaUserControl>
	{

		public MainPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MainPage_Base_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class MainPage_Base_TerrasoftSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout TopControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TopControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout TopLeftControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TopLeftControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout LogoControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("LogoControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ImageBox ImageBox1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ImageBox)PageContainer.FindPageControl("ImageBox1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout NavigationControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("NavigationControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout NavigationButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("NavigationButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button UnreadEmailCountButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UnreadEmailCountButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button NewRemindingsCountButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("NewRemindingsCountButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button RunProcessButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("RunProcessButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout TopRightControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TopRightControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MultiLevelTabs MultiLevelTabs {
			get {
				return (Terrasoft.UI.WebControls.Controls.MultiLevelTabs)PageContainer.FindPageControl("MultiLevelTabs", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SearchEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SearchEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ClearToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ClearToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ModulesToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ModulesToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton SearchToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("SearchToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SettingsButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SettingsButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button UserSettingsButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UserSettingsButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem OpenContextHelp {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("OpenContextHelp", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem OpenModuleHelp {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("OpenModuleHelp", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem ShowWelcomeScreen {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("ShowWelcomeScreen", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ExitButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ExitButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ImageList NavigationControlsImageList {
			get {
				return (Terrasoft.UI.WebControls.Controls.ImageList)PageContainer.FindPageControl("NavigationControlsImageList", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ContentControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ContentControlLayout", true);
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
			NewRemindingsCountButton.AjaxEvents.Click.Event += NewRemindingsCountButtonClick;
			ClearToolButton.AjaxEvents.Click.Event += ClearToolButtonClick;
			ShowWelcomeScreen.AjaxEvents.Click.Event += ShowWelcomeScreenClick;
			ExitButton.AjaxEvents.Click.Event += ExitButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			NewRemindingsCountButton.AjaxEvents.Click.Event -= NewRemindingsCountButtonClick;
			ClearToolButton.AjaxEvents.Click.Event -= ClearToolButtonClick;
			ShowWelcomeScreen.AjaxEvents.Click.Event -= ShowWelcomeScreenClick;
			ExitButton.AjaxEvents.Click.Event -= ExitButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (MainPage_Base_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new MainPage_Base_TerrasoftEventsProcess(UserConnection);
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

		public virtual void NewRemindingsCountButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("NewRemindingsCountButtonClick");
		}

		public virtual void ClearToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ClearToolButtonClick");
		}

		public virtual void ShowWelcomeScreenClick(object sender, EventArgs e) {
			object result = ThrowEvent("ShowWelcomeScreenClick");
		}

		public virtual void ExitButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ExitButtonClick");
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
			SchemaName = "MainPage_Base_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: MainPage_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class MainPage_Base_TerrasoftEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public MainPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MainPage_Base_TerrasoftEventsProcessSchema(MainPage_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MainPage_Base_TerrasoftEventsProcess";
			UId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4");
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

		protected virtual ProcessSchemaParameter CreatePageSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e688975a-51bd-495b-be97-1feb3a19a162"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"PageSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFirstPageSchemaIdToLoadParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("53301619-bca7-4ee3-bd29-4018383fffa5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"FirstPageSchemaIdToLoad",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d879cd59-d6de-4a90-8fb7-9c83502c98f6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SelectedModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateGlobalSearchValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bb2ba8df-e370-4831-b308-b09c5cd602e2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"GlobalSearchValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCheckingRemindingsIntervalParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8a162973-1651-4d25-98af-d55d0ce05c6e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CheckingRemindingsInterval",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessagePanelClickedLinkIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a18c881b-731a-4e32-bcbd-aa26a63d1a09"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MessagePanelClickedLinkId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRemindingsPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4c823587-bc6d-4330-9161-f465c79953f0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"RemindingsPageUId",
				SourceParameterUId = Guid.Empty,
				SourcePath = @"new Guid(""9D83CB5B-5AA3-4484-9D59-1C5E7B086A05"")",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMoveToParametersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0c6112b6-6a81-4a67-b247-5b212a6d211e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MoveToParameters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFAQLinkIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("81742163-0d73-4662-a76c-2947e3b2067d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"FAQLinkId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCommunityLinkParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6fa1f248-7c02-4786-80f3-6a035eff0060"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CommunityLink",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateShowLDAPMessageIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ea051c33-e5d9-4c26-b407-948d3461b109"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ShowLDAPMessageId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{83A1E9EA-651D-4600-B027-886C6EFA6524}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCancelLDAPMessageIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c5abeffb-0020-4a48-87c9-1d791f06bbbf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CancelLDAPMessageId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{23BB9BEE-C97C-4715-AD69-9A6EC3191307}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsTuningModuleParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b790abd3-d49b-4e2c-9d62-cabda9874cc0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"IsTuningModule",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTuningProcessModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3db75672-e311-468a-b6b4-a1c448ea1e2f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"TuningProcessMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSettingsModeSettingsButtonMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1f93fa86-b357-4164-943e-5e5e1e782f60"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SettingsModeSettingsButtonMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{FCC18473-5563-422B-A5A2-3E31FF6B7FA7}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateImapServersSettingsSettingsButtonMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3aee382a-2d7a-4efa-877e-472f856deb53"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ImapServersSettingsSettingsButtonMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{79C445FE-3360-4261-BD6C-3560BB4BA0A8}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMailServerSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0aacb0aa-b1bb-46f0-af6a-9b5dca8ce222"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MailServerSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSettingsModeSettingsButtonMenuItemCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f5333e90-ac96-47d5-8e6e-41e0febd5c8c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SettingsModeSettingsButtonMenuItemCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanChangeApplicationTuningModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f012367c-ad5e-4274-83e2-346682617e21"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CanChangeApplicationTuningMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanManageMailServersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e839f560-e39a-4ed1-9f5f-ceecc67ccb39"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CanManageMailServers",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSeparatorMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e1781689-8275-4729-89e3-7412f35dddd2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SeparatorMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{C3254322-CA97-4B10-AC81-EB05AA7CF11E}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMailboxSynchronizationSettingsPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4375c067-c23e-44a3-b757-548d1ffbea11"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MailboxSynchronizationSettingsPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"fce8864e-7b01-429e-921e-0563c725d563",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEditSocialAccountsMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f6268ff4-ee51-49d1-b5ef-97c8abc6805e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EditSocialAccountsMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMsgToolInstanceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("473777ed-d58d-4636-ad92-5c4e17f7019b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MsgToolInstance",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanManageLicUsersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("731d4ace-a7ff-4bd5-9f78-dab3bfe8c1e0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CanManageLicUsers",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLicensesSettingsButtonMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1e31296d-1947-41cb-8934-2f30e55d5df4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"LicensesSettingsButtonMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"674E8D51-E36F-4598-A77E-374AA12AE96D",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDemoBuildParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c4903ac8-4ac8-41e5-b695-4f7892935b30"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"IsDemoBuild",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateWelcomeScreenDataKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("53b63597-63ea-44e0-a182-6b973766ffaf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"WelcomeScreenDataKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedModuleCodeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ae0b9ed5-fbe1-4d14-89dc-6cfe47940431"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SelectedModuleCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedModuleHelpContextIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c1827921-c386-4e41-8cc0-1ed9af980d62"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SelectedModuleHelpContextId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedModuleCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9157fe78-8d49-439d-81be-279f67737a4a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SelectedModuleCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditTelephonyButtonMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cd0b77b-c9bf-4758-b213-f58f6115b058"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EditTelephonyButtonMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{8230A862-115E-4B48-9393-9C8A7E9049BD}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCanUseMsgServiceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6092494e-20a3-4ef3-8cc2-6a7dfc7ad523"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CanUseMsgService",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("37030e9a-9438-459f-af9c-d9b632b8f77e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SearchModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDeveloperModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("902066b1-012c-480f-8eee-3d22e71e5ce1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"IsDeveloperMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCallSessionDataKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4c59da88-ec2a-4a79-9435-c6375e883bd5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CallSessionDataKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSavedDataIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e8e328a1-75c5-4a32-9f18-754bbec141c7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SavedDataId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSetMailChimpSettingsButtonMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9b07b06b-bf6c-49c0-af90-14bc183b3e60"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SetMailChimpSettingsButtonMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"ed9c7081-81a9-4b54-8b2d-5ec50037eeed",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMailChimpSettingsPageSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b15e6a87-51b6-4c5e-a703-500f1e878dc7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MailChimpSettingsPageSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"D16B991C-05D9-440E-A39D-84EB840E0386",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCanUseMailChimpIntegrationSettingsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9615d220-a862-40eb-b1ff-8a74f3d9af92"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CanUseMailChimpIntegrationSettings",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysMainPageShellClientIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c673c2f6-189a-462f-b187-b017dfad706b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SysMainPageShellClientId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIntegrationLogPageSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("70dc3dc9-05cf-4d33-ab0b-c7f2d72cefe8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"IntegrationLogPageSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"49045869-5dc5-42d7-b93f-9e6e1d1027f7",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateOpenIntegrationLogMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5adfe4e7-ce24-4cf0-b7cc-ba21dd976e67"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"OpenIntegrationLogMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"A1E8B7AD-022E-48B0-99BD-CFF285F9743F",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCanStartCommandGenerationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dc5dfabe-2bd6-4afa-bd10-3fa213c3e336"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CanStartCommandGeneration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCommandGenerationButtonMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8d68d2c8-6510-4451-891f-07b629fd0f8b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CommandGenerationButtonMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"A7515339-D17B-400F-8458-F0E9F37B00B4",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateImportPageSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3ee17f73-8bf3-4014-8cbf-76ad9d00fa4e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ImportPageSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"c2af7f54-07df-4670-9c2b-af2497d3231f",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateImportButtonMenuItemTagParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("810815fd-94b1-4c32-842b-71803ee19c33"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ImportButtonMenuItemTag",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"6A3B8248-D817-4049-9B10-87BC53041262",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageSchemaUIdParameter());
			Parameters.Add(CreateFirstPageSchemaIdToLoadParameter());
			Parameters.Add(CreateSelectedModuleIdParameter());
			Parameters.Add(CreateGlobalSearchValueParameter());
			Parameters.Add(CreateCheckingRemindingsIntervalParameter());
			Parameters.Add(CreateMessagePanelClickedLinkIdParameter());
			Parameters.Add(CreateRemindingsPageUIdParameter());
			Parameters.Add(CreateMoveToParametersParameter());
			Parameters.Add(CreateFAQLinkIdParameter());
			Parameters.Add(CreateCommunityLinkParameter());
			Parameters.Add(CreateShowLDAPMessageIdParameter());
			Parameters.Add(CreateCancelLDAPMessageIdParameter());
			Parameters.Add(CreateIsTuningModuleParameter());
			Parameters.Add(CreateTuningProcessModeParameter());
			Parameters.Add(CreateSettingsModeSettingsButtonMenuItemTagParameter());
			Parameters.Add(CreateImapServersSettingsSettingsButtonMenuItemTagParameter());
			Parameters.Add(CreateMailServerSchemaUIdParameter());
			Parameters.Add(CreateSettingsModeSettingsButtonMenuItemCaptionParameter());
			Parameters.Add(CreateCanChangeApplicationTuningModeParameter());
			Parameters.Add(CreateCanManageMailServersParameter());
			Parameters.Add(CreateSeparatorMenuItemTagParameter());
			Parameters.Add(CreateMailboxSynchronizationSettingsPageUIdParameter());
			Parameters.Add(CreateEditSocialAccountsMenuItemTagParameter());
			Parameters.Add(CreateMsgToolInstanceParameter());
			Parameters.Add(CreateCanManageLicUsersParameter());
			Parameters.Add(CreateLicensesSettingsButtonMenuItemTagParameter());
			Parameters.Add(CreateIsDemoBuildParameter());
			Parameters.Add(CreateWelcomeScreenDataKeyParameter());
			Parameters.Add(CreateSelectedModuleCodeParameter());
			Parameters.Add(CreateSelectedModuleHelpContextIdParameter());
			Parameters.Add(CreateSelectedModuleCaptionParameter());
			Parameters.Add(CreateEditTelephonyButtonMenuItemTagParameter());
			Parameters.Add(CreateCanUseMsgServiceParameter());
			Parameters.Add(CreateSearchModuleIdParameter());
			Parameters.Add(CreateIsDeveloperModeParameter());
			Parameters.Add(CreateCallSessionDataKeyParameter());
			Parameters.Add(CreateSavedDataIdParameter());
			Parameters.Add(CreateSetMailChimpSettingsButtonMenuItemTagParameter());
			Parameters.Add(CreateMailChimpSettingsPageSchemaUIdParameter());
			Parameters.Add(CreateCanUseMailChimpIntegrationSettingsParameter());
			Parameters.Add(CreateSysMainPageShellClientIdParameter());
			Parameters.Add(CreateIntegrationLogPageSchemaUIdParameter());
			Parameters.Add(CreateOpenIntegrationLogMenuItemTagParameter());
			Parameters.Add(CreateCanStartCommandGenerationParameter());
			Parameters.Add(CreateCommandGenerationButtonMenuItemTagParameter());
			Parameters.Add(CreateImportPageSchemaUIdParameter());
			Parameters.Add(CreateImportButtonMenuItemTagParameter());
		}

		protected virtual void InitializeShowRemindingsUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("31646f62-874f-4f16-b9d8-7621d8dc5152"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("b2abb70e-606e-471b-a4ff-a58a0c562fca"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("c531651a-99b7-4718-8042-238973685933"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("62dde84f-1625-4daa-ac19-50125eb3ee0d"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("8b6ad6ac-ede5-415f-94e6-381473060f58"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("94155af9-97a2-47b6-bebe-8c3a83d21345"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("caecc30a-b132-4e3b-9c68-e9b9651faf15"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("ac84931c-09a3-4e74-978d-d18c89a1f32d"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("96a0d86a-3982-45d0-a0d8-dd5a49234668"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("4cf60f70-3eac-4407-80e8-775f57f05c30"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("24ac71c7-a8d0-40f1-b765-0b6807f94d3b"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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
				UId = new Guid("99c4bb0d-c9e5-416e-97fd-1d5f42ab8c74"),
				ContainerUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
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

		protected virtual void InitializeOpenImapServersSettingsUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("85b2284e-6417-4c88-97a0-ce6648a0d290"),
				ContainerUId = new Guid("91e34f72-437e-4615-bab2-4f981abed21f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
				UId = new Guid("aabc007e-9687-4906-aee0-984a03060ac5"),
				ContainerUId = new Guid("91e34f72-437e-4615-bab2-4f981abed21f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
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
				UId = new Guid("6ae6e539-8e51-44fb-be51-889b56bfc759"),
				ContainerUId = new Guid("91e34f72-437e-4615-bab2-4f981abed21f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
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
				UId = new Guid("91f57e3d-a487-4c42-b579-820c02ee7014"),
				ContainerUId = new Guid("91e34f72-437e-4615-bab2-4f981abed21f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
		}

		protected virtual void InitializeOpenSocialAccountGridPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a79c75cc-2b9b-44d9-bdbf-3aec93dae84e"),
				ContainerUId = new Guid("b98b0491-c901-4970-b579-b95360d1f5b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
				UId = new Guid("88d54f2f-8c7c-47bd-8c71-020d5cb8f62f"),
				ContainerUId = new Guid("b98b0491-c901-4970-b579-b95360d1f5b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
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
				UId = new Guid("b5adecbc-a823-4295-853c-4339a7a3559d"),
				ContainerUId = new Guid("b98b0491-c901-4970-b579-b95360d1f5b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
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
				UId = new Guid("6e43aab9-ee70-4856-a9eb-b13ce85222d9"),
				ContainerUId = new Guid("b98b0491-c901-4970-b579-b95360d1f5b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
		}

		protected virtual void InitializeOpenLicPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5c3faff2-3d56-448c-b2cb-3786cc47106b"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("96e4bf11-2ce6-4cf5-95f9-46b55837363d"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("aa96d653-c52c-45ff-b6db-f8e58291e4bc"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("707a7f99-3a34-4f8e-a3ff-901497a97994"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("f24fe0d9-280e-405a-9019-b8260eec51c9"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("0e29c9d4-c54f-4353-bd2b-b092a95f87d2"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("71fb74ba-e378-40d7-947c-dbdf68e44ab9"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("dadb2317-e1e9-4602-b3ec-2c5acb649a72"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("1fdb39dd-be08-47d3-8733-9bfcd03484af"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("404b3430-2b9b-4f46-8f49-27afc985c913"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("6c4a0516-1837-4ae6-a47b-f771113d30f9"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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
				UId = new Guid("890ce17a-9152-4acb-b95a-5eb1755e3b94"),
				ContainerUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
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

		protected virtual void InitializeSetMailChimpSettingsButtonMenuItemEventUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d12cc786-f83a-4306-b496-c0048e458eea"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("2b3bc6de-eb66-493e-919c-ceb4e5e4040c"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("32b333b0-5b2c-485f-b2d1-a03c6e46c98d"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("fcd12a46-9879-4255-adfa-95f8abefc907"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("760b47af-e9ad-43f7-8597-4e30f3f90cf1"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("2fc51244-e997-41b9-9315-876081c81335"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("e43aa3d8-8676-46b9-8e48-69e94c95fa7f"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("ddb1bc28-189d-4cd9-ae1b-c087321f7c4b"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("9eed9588-309c-476e-8f1d-f7dc176db460"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("3e2c9485-2d7e-4539-a54d-7666a55400c6"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("ae50a79c-fb9f-4052-a035-f819e678355b"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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
				UId = new Guid("69b03b49-f1a4-4931-84c1-3dc8fff74cbd"),
				ContainerUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
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

		protected virtual void InitializeOpenIntegrationLogUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a98119c0-fe74-46da-9fb9-97ee9b34f08e"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("ef36aaa1-2236-4ced-a905-546fb3e07737"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("d57531b4-b486-4e60-9c60-233b8d6e3540"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("a3cc4bf4-2073-4430-9c7d-d3eca4b3f19d"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("da40a908-0387-4a34-8b45-db590255b9c4"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("536e42c2-f57c-4938-8727-fec1854d155a"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("c33d4252-c412-4606-a2c1-6b0ccd391584"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("f60a2c3b-97bc-4cb2-adb3-5b285ed8aa27"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("1b954a13-60e8-45a4-a6a6-afa30d61c0f7"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("380ad4c2-0552-4546-a572-c94489671836"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("74ebe69b-3873-4a99-8201-622046bbac59"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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
				UId = new Guid("672372e7-c160-4bf2-8987-969e461eae5c"),
				ContainerUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
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

		protected virtual void InitializeOpenImportPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b8eaaf07-dad0-4db3-bc5b-0a8b59efd29d"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("1f6d0a91-cece-4b8e-94a4-586c112b552d"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("3cf7f34e-0682-4abe-8d77-a50b71cfe44f"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("93eeac9b-5491-4392-a6cc-c13ed334dd84"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("0fb85c95-00f2-4ba0-8d6b-31bb7a745b5c"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("f9b7ad06-9c87-4f49-9e48-975e23a1daf9"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("c649a520-63f0-41b0-bd27-3d96d9a4882a"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("ee2e9e90-4b77-455a-8330-54380399eb2a"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("af8540af-8064-45e1-b125-b66769a69366"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("c6fa72de-132d-46da-a35f-c7d5116a3e25"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("32df607e-aa9e-4070-ae30-ac558dfbbe28"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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
				UId = new Guid("1f18e05d-6966-4ffc-9140-09708a755086"),
				ContainerUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
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

		protected virtual void InitializeOpenSelectDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c4e00b1c-5cf3-450a-9a91-514c671da7c6"),
				ContainerUId = new Guid("8815c5ff-679e-4518-969e-22358826c8d4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
				UId = new Guid("0291ffa7-0aef-417f-95bf-64ac9807c437"),
				ContainerUId = new Guid("8815c5ff-679e-4518-969e-22358826c8d4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
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
				UId = new Guid("92effc68-352f-404d-ae35-49a48f74f7f6"),
				ContainerUId = new Guid("8815c5ff-679e-4518-969e-22358826c8d4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
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
				UId = new Guid("e23c2b2a-c5d4-4f61-b5de-f9678cb53769"),
				ContainerUId = new Guid("8815c5ff-679e-4518-969e-22358826c8d4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
		}

		protected virtual void InitializeMessageWindowUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("230366ab-048a-477c-a7ea-ed49a76d586c"),
				ContainerUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
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
				UId = new Guid("ef080313-5cb8-434c-b68a-ceae60832c27"),
				ContainerUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
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
				UId = new Guid("2df136ae-9e21-4e77-88b5-1356cfb96d31"),
				ContainerUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
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
				UId = new Guid("0a42a4ee-c471-4f9f-abcb-e70eb74aeeca"),
				ContainerUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
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
				UId = new Guid("d59b69c4-1496-4ae1-9417-2ba1ab6fd5b7"),
				ContainerUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
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
				UId = new Guid("208dc4ed-675b-4b28-b2d6-7acccff46c78"),
				ContainerUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
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
				UId = new Guid("8d495437-baa5-4565-9362-871246bea156"),
				ContainerUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
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
				UId = new Guid("01593ba4-a64f-4841-a8f6-8a5ee77f082b"),
				ContainerUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
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

		protected virtual void InitializeShowDefinedPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5f450136-9c03-4d6f-b20e-bc799d41c5b2"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("c06fda01-3ccf-44df-af05-e7e98805e880"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("d295e001-4966-4e44-a74a-caf8737604a9"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("bfdf007f-2e29-4467-baec-582bb01b49e1"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("0a9c0d44-1b59-41e2-ad4b-199d9c416a41"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("e352e3ae-1f81-4e25-9ed7-7b2d0f612b82"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("9f95faff-b566-480a-af40-d9ea25e2c306"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("3e3e3d0d-c6b6-43bd-9921-adaca7d03009"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("e98c052c-6e8a-404b-92b5-6c45dc79055e"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("7a706152-87c4-4cba-82b5-220093ee7110"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("e8693a76-427b-46db-bbf6-e38614f70a29"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
				UId = new Guid("6f6435c0-03c9-4f8f-80b7-b1d55f918411"),
				ContainerUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
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
			ProcessSchemaLaneSet schemaMyLaneSet = CreateMyLaneSetLaneSet();
			LaneSets.Add(schemaMyLaneSet);
			ProcessSchemaLane schemaExitButtonLane = CreateExitButtonLaneLane();
			schemaMyLaneSet.Lanes.Add(schemaExitButtonLane);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess remindingspageeventsubprocess = CreateRemindingsPageEventSubProcessEventSubProcess();
			FlowElements.Add(remindingspageeventsubprocess);
			ProcessSchemaEventSubProcess settingsmodesettingsbuttonmenuitemeventsubprocess = CreateSettingsModeSettingsButtonMenuItemEventSubProcessEventSubProcess();
			FlowElements.Add(settingsmodesettingsbuttonmenuitemeventsubprocess);
			ProcessSchemaEventSubProcess imapserverssettingssettingsbuttonmenuitemeventeventsubprocess = CreateImapServersSettingsSettingsButtonMenuItemEventEventSubProcessEventSubProcess();
			FlowElements.Add(imapserverssettingssettingsbuttonmenuitemeventeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess setmailchimpsettingsbuttonmenuitemeventsubprocess = CreateSetMailChimpSettingsButtonMenuItemEventSubProcessEventSubProcess();
			FlowElements.Add(setmailchimpsettingsbuttonmenuitemeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess commandgenerationbuttonmenuitemeventsubprocess = CreateCommandGenerationButtonMenuItemEventSubProcessEventSubProcess();
			FlowElements.Add(commandgenerationbuttonmenuitemeventsubprocess);
			ProcessSchemaEventSubProcess findselectedmodulesubprocess = CreateFindSelectedModuleSubProcessEventSubProcess();
			FlowElements.Add(findselectedmodulesubprocess);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaEventSubProcess subprocess3 = CreateSubProcess3EventSubProcess();
			FlowElements.Add(subprocess3);
			ProcessSchemaEventSubProcess subprocess4 = CreateSubProcess4EventSubProcess();
			FlowElements.Add(subprocess4);
			ProcessSchemaEventSubProcess subprocess5 = CreateSubProcess5EventSubProcess();
			FlowElements.Add(subprocess5);
			ProcessSchemaEventSubProcess helpcalledeventsubprocess = CreateHelpCalledEventSubProcessEventSubProcess();
			FlowElements.Add(helpcalledeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess initsubprocess = CreateInitSubProcessEventSubProcess();
			FlowElements.Add(initsubprocess);
			ProcessSchemaEventSubProcess pageloadcompletesubprocess = CreatePageLoadCompleteSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompletesubprocess);
			ProcessSchemaEventSubProcess pageloadeventsubprocess = CreatePageLoadEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocessglobalsearch = CreateEventSubProcessGlobalSearchEventSubProcess();
			FlowElements.Add(eventsubprocessglobalsearch);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaStartMessageEvent exitbuttonclickstartmessage = CreateExitButtonClickStartMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(exitbuttonclickstartmessage);
			ProcessSchemaScriptTask exitbuttonclickscripttask = CreateExitButtonClickScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(exitbuttonclickscripttask);
			ProcessSchemaStartMessageEvent startmessage2q = CreateStartMessage2qStartMessageEvent();
			remindingspageeventsubprocess.FlowElements.Add(startmessage2q);
			ProcessSchemaScriptTask remindingspageparamsscripttask = CreateRemindingsPageParamsScriptTaskScriptTask();
			remindingspageeventsubprocess.FlowElements.Add(remindingspageparamsscripttask);
			ProcessSchemaUserTask showremindingsusertask = CreateShowRemindingsUserTaskUserTask();
			remindingspageeventsubprocess.FlowElements.Add(showremindingsusertask);
			ProcessSchemaStartMessageEvent settingsmodesettingsbuttonmenuitemevent = CreateSettingsModeSettingsButtonMenuItemEventStartMessageEvent();
			settingsmodesettingsbuttonmenuitemeventsubprocess.FlowElements.Add(settingsmodesettingsbuttonmenuitemevent);
			ProcessSchemaScriptTask settingsbuttonclickscript = CreateSettingsButtonClickScriptScriptTask();
			settingsmodesettingsbuttonmenuitemeventsubprocess.FlowElements.Add(settingsbuttonclickscript);
			ProcessSchemaScriptTask scripttaskprepeareinformation = CreateScriptTaskPrepeareInformationScriptTask();
			settingsmodesettingsbuttonmenuitemeventsubprocess.FlowElements.Add(scripttaskprepeareinformation);
			ProcessSchemaStartMessageEvent imapserverssettingssettingsbuttonmenuitemeventstartmessage = CreateImapServersSettingsSettingsButtonMenuItemEventStartMessageStartMessageEvent();
			imapserverssettingssettingsbuttonmenuitemeventeventsubprocess.FlowElements.Add(imapserverssettingssettingsbuttonmenuitemeventstartmessage);
			ProcessSchemaScriptTask imapserverssettingssettingsbuttonmenuitemeventscripttask = CreateImapServersSettingsSettingsButtonMenuItemEventScriptTaskScriptTask();
			imapserverssettingssettingsbuttonmenuitemeventeventsubprocess.FlowElements.Add(imapserverssettingssettingsbuttonmenuitemeventscripttask);
			ProcessSchemaUserTask openimapserverssettingsusertask = CreateOpenImapServersSettingsUserTaskUserTask();
			imapserverssettingssettingsbuttonmenuitemeventeventsubprocess.FlowElements.Add(openimapserverssettingsusertask);
			ProcessSchemaStartMessageEvent editsocialaccountsbuttonmenuitemevent = CreateEditSocialAccountsButtonMenuItemEventStartMessageEvent();
			eventsubprocess1.FlowElements.Add(editsocialaccountsbuttonmenuitemevent);
			ProcessSchemaScriptTask opensocialaccountgridscripttask = CreateOpenSocialAccountGridScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(opensocialaccountgridscripttask);
			ProcessSchemaUserTask opensocialaccountgridpage = CreateOpenSocialAccountGridPageUserTask();
			eventsubprocess1.FlowElements.Add(opensocialaccountgridpage);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess5.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask licensessettingsbuttonmenuitemeventscripttask = CreateLicensesSettingsButtonMenuItemEventScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(licensessettingsbuttonmenuitemeventscripttask);
			ProcessSchemaUserTask openlicpage = CreateOpenLicPageUserTask();
			eventsubprocess5.FlowElements.Add(openlicpage);
			ProcessSchemaStartMessageEvent setmailchimpsettingsbuttonmenuitemeventstartmessage = CreateSetMailChimpSettingsButtonMenuItemEventStartMessageStartMessageEvent();
			setmailchimpsettingsbuttonmenuitemeventsubprocess.FlowElements.Add(setmailchimpsettingsbuttonmenuitemeventstartmessage);
			ProcessSchemaUserTask setmailchimpsettingsbuttonmenuitemeventusertask = CreateSetMailChimpSettingsButtonMenuItemEventUserTaskUserTask();
			setmailchimpsettingsbuttonmenuitemeventsubprocess.FlowElements.Add(setmailchimpsettingsbuttonmenuitemeventusertask);
			ProcessSchemaScriptTask setmailchimpintegrationsettingpreparescripttask = CreateSetMailChimpIntegrationSettingPrepareScriptTaskScriptTask();
			setmailchimpsettingsbuttonmenuitemeventsubprocess.FlowElements.Add(setmailchimpintegrationsettingpreparescripttask);
			ProcessSchemaStartMessageEvent setintegrationlogmenuitemevent = CreateSetIntegrationLogMenuItemEventStartMessageEvent();
			eventsubprocess12.FlowElements.Add(setintegrationlogmenuitemevent);
			ProcessSchemaScriptTask preparepageparametersscripttask = CreatePreparePageParametersScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(preparepageparametersscripttask);
			ProcessSchemaUserTask openintegrationlogusertask = CreateOpenIntegrationLogUserTaskUserTask();
			eventsubprocess12.FlowElements.Add(openintegrationlogusertask);
			ProcessSchemaStartMessageEvent importbuttonmenuitemclickstartmessage = CreateImportButtonMenuItemClickStartMessageStartMessageEvent();
			eventsubprocess12.FlowElements.Add(importbuttonmenuitemclickstartmessage);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess12.FlowElements.Add(scripttask2);
			ProcessSchemaUserTask openimportpageusertask = CreateOpenImportPageUserTaskUserTask();
			eventsubprocess12.FlowElements.Add(openimportpageusertask);
			ProcessSchemaStartMessageEvent commandgenerationbuttonmenuitemeventstartmessage = CreateCommandGenerationButtonMenuItemEventStartMessageStartMessageEvent();
			commandgenerationbuttonmenuitemeventsubprocess.FlowElements.Add(commandgenerationbuttonmenuitemeventstartmessage);
			ProcessSchemaScriptTask commandgenerationbuttonmenuitemscripttask = CreateCommandGenerationButtonMenuItemScriptTaskScriptTask();
			commandgenerationbuttonmenuitemeventsubprocess.FlowElements.Add(commandgenerationbuttonmenuitemscripttask);
			ProcessSchemaStartMessageEvent findselectedmodule = CreateFindSelectedModuleStartMessageEvent();
			findselectedmodulesubprocess.FlowElements.Add(findselectedmodule);
			ProcessSchemaScriptTask scriptfindselectedmodulesubprocess = CreateScriptFindSelectedModuleSubProcessScriptTask();
			findselectedmodulesubprocess.FlowElements.Add(scriptfindselectedmodulesubprocess);
			ProcessSchemaStartMessageEvent selectandrunprocessevent = CreateSelectAndRunProcessEventStartMessageEvent();
			subprocess1.FlowElements.Add(selectandrunprocessevent);
			ProcessSchemaScriptTask selectandrunprocessscript = CreateSelectAndRunProcessScriptScriptTask();
			subprocess1.FlowElements.Add(selectandrunprocessscript);
			ProcessSchemaIntermediateCatchMessageEvent lookupgridpageclosedevent = CreateLookupGridPageClosedEventIntermediateCatchMessageEvent();
			subprocess1.FlowElements.Add(lookupgridpageclosedevent);
			ProcessSchemaScriptTask runprocessscript = CreateRunProcessScriptScriptTask();
			subprocess1.FlowElements.Add(runprocessscript);
			ProcessSchemaUserTask openselectdatausertask = CreateOpenSelectDataUserTaskUserTask();
			subprocess1.FlowElements.Add(openselectdatausertask);
			ProcessSchemaStartMessageEvent showmessageevent = CreateShowMessageEventStartMessageEvent();
			subprocess2.FlowElements.Add(showmessageevent);
			ProcessSchemaUserTask messagewindowusertask = CreateMessageWindowUserTaskUserTask();
			subprocess2.FlowElements.Add(messagewindowusertask);
			ProcessSchemaStartMessageEvent settingschangedevent = CreateSettingsChangedEventStartMessageEvent();
			subprocess3.FlowElements.Add(settingschangedevent);
			ProcessSchemaScriptTask settingschangedscript = CreateSettingsChangedScriptScriptTask();
			subprocess3.FlowElements.Add(settingschangedscript);
			ProcessSchemaStartMessageEvent messagepanellinkclick = CreateMessagePanelLinkClickStartMessageEvent();
			subprocess4.FlowElements.Add(messagepanellinkclick);
			ProcessSchemaScriptTask linkclickscripttask = CreateLinkClickScriptTaskScriptTask();
			subprocess4.FlowElements.Add(linkclickscripttask);
			ProcessSchemaUserTask showdefinedpageusertask = CreateShowDefinedPageUserTaskUserTask();
			subprocess4.FlowElements.Add(showdefinedpageusertask);
			ProcessSchemaScriptTask showremindingsusertaskinit = CreateShowRemindingsUserTaskInitScriptTask();
			subprocess4.FlowElements.Add(showremindingsusertaskinit);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			subprocess4.FlowElements.Add(scripttask3);
			ProcessSchemaScriptTask mailboxsettingsscripttask = CreateMailboxSettingsScriptTaskScriptTask();
			subprocess4.FlowElements.Add(mailboxsettingsscripttask);
			ProcessSchemaStartMessageEvent movetomodule = CreateMoveToModuleStartMessageEvent();
			subprocess5.FlowElements.Add(movetomodule);
			ProcessSchemaScriptTask movetomodulescript = CreateMoveToModuleScriptScriptTask();
			subprocess5.FlowElements.Add(movetomodulescript);
			ProcessSchemaStartMessageEvent helpcalledstartmessage = CreateHelpCalledStartMessageStartMessageEvent();
			helpcalledeventsubprocess.FlowElements.Add(helpcalledstartmessage);
			ProcessSchemaScriptTask scripthelpcalled = CreateScriptHelpCalledScriptTask();
			helpcalledeventsubprocess.FlowElements.Add(scripthelpcalled);
			ProcessSchemaStartMessageEvent messagepanelmessageclosed = CreateMessagePanelMessageClosedStartMessageEvent();
			eventsubprocess6.FlowElements.Add(messagepanelmessageclosed);
			ProcessSchemaScriptTask scriptmessagepanelmessageclosed = CreateScriptMessagePanelMessageClosedScriptTask();
			eventsubprocess6.FlowElements.Add(scriptmessagepanelmessageclosed);
			ProcessSchemaStartMessageEvent doshowldapmessage = CreateDoShowLDAPMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(doshowldapmessage);
			ProcessSchemaScriptTask scriptdoshowldapmessage = CreateScriptDoShowLDAPMessageScriptTask();
			eventsubprocess2.FlowElements.Add(scriptdoshowldapmessage);
			ProcessSchemaStartMessageEvent showstartprocess = CreateShowStartProcessStartMessageEvent();
			eventsubprocess4.FlowElements.Add(showstartprocess);
			ProcessSchemaScriptTask scriptshowstartprocess = CreateScriptShowStartProcessScriptTask();
			eventsubprocess4.FlowElements.Add(scriptshowstartprocess);
			ProcessSchemaStartMessageEvent errorcheckrequiredldapsettings = CreateErrorCheckRequiredLDAPSettingsStartMessageEvent();
			eventsubprocess7.FlowElements.Add(errorcheckrequiredldapsettings);
			ProcessSchemaScriptTask scripterrorcheckrequiredldapsettings = CreateScriptErrorCheckRequiredLDAPSettingsScriptTask();
			eventsubprocess7.FlowElements.Add(scripterrorcheckrequiredldapsettings);
			ProcessSchemaStartMessageEvent init = CreateInitStartMessageEvent();
			initsubprocess.FlowElements.Add(init);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			initsubprocess.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			pageloadcompletesubprocess.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageloadcompletesubprocess.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent startmessagenoninterruptingevent1 = CreateStartMessageNonInterruptingEvent1StartMessageEvent();
			pageloadeventsubprocess.FlowElements.Add(startmessagenoninterruptingevent1);
			ProcessSchemaScriptTask pageloadscripttask = CreatePageLoadScriptTaskScriptTask();
			pageloadeventsubprocess.FlowElements.Add(pageloadscripttask);
			ProcessSchemaStartMessageEvent startglobalsearch = CreateStartGlobalSearchStartMessageEvent();
			eventsubprocessglobalsearch.FlowElements.Add(startglobalsearch);
			ProcessSchemaScriptTask scriptglobalsearch = CreateScriptGlobalSearchScriptTask();
			eventsubprocessglobalsearch.FlowElements.Add(scriptglobalsearch);
			ProcessSchemaStartMessageEvent startcleartoolbuttonclick = CreateStartClearToolButtonClickStartMessageEvent();
			eventsubprocessglobalsearch.FlowElements.Add(startcleartoolbuttonclick);
			ProcessSchemaScriptTask scriptcleartoolbuttonclick = CreateScriptClearToolButtonClickScriptTask();
			eventsubprocessglobalsearch.FlowElements.Add(scriptcleartoolbuttonclick);
			ProcessSchemaStartMessageEvent startchangesearchmodule = CreateStartChangeSearchModuleStartMessageEvent();
			eventsubprocessglobalsearch.FlowElements.Add(startchangesearchmodule);
			ProcessSchemaScriptTask scriptchangesearchmodule = CreateScriptChangeSearchModuleScriptTask();
			eventsubprocessglobalsearch.FlowElements.Add(scriptchangesearchmodule);
			ProcessSchemaScriptTask welcomescreenclosedscripttask = CreateWelcomeScreenClosedScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(welcomescreenclosedscripttask);
			ProcessSchemaStartMessageEvent welcomescreenclosedstartmessage = CreateWelcomeScreenClosedStartMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(welcomescreenclosedstartmessage);
			ProcessSchemaStartMessageEvent showwelcomescreenclickstartmessage = CreateShowWelcomeScreenClickStartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(showwelcomescreenclickstartmessage);
			ProcessSchemaScriptTask showwelcomescreenclickscripttask = CreateShowWelcomeScreenClickScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(showwelcomescreenclickscripttask);
			FlowElements.Add(CreateSequenceFlow78SequenceFlow());
			FlowElements.Add(CreateSequenceFlow79SequenceFlow());
			FlowElements.Add(CreateSequenceFlow80SequenceFlow());
			FlowElements.Add(CreateSequenceFlow81SequenceFlow());
			FlowElements.Add(CreateSequenceFlow82SequenceFlow());
			FlowElements.Add(CreateSequenceFlow83SequenceFlow());
			FlowElements.Add(CreateSequenceFlow84SequenceFlow());
			FlowElements.Add(CreateSequenceFlow85SequenceFlow());
			FlowElements.Add(CreateSequenceFlow86SequenceFlow());
			FlowElements.Add(CreateSequenceFlow87SequenceFlow());
			FlowElements.Add(CreateSequenceFlow88SequenceFlow());
			FlowElements.Add(CreateSequenceFlow89ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow90SequenceFlow());
			FlowElements.Add(CreateSequenceFlow91SequenceFlow());
			FlowElements.Add(CreateSequenceFlow92SequenceFlow());
			FlowElements.Add(CreateSequenceFlow93SequenceFlow());
			FlowElements.Add(CreateSequenceFlow94SequenceFlow());
			FlowElements.Add(CreateSequenceFlow95SequenceFlow());
			FlowElements.Add(CreateSequenceFlow96SequenceFlow());
			FlowElements.Add(CreateSequenceFlow97SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateMailboxSettingsConditionalFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10qSequenceFlow());
			FlowElements.Add(CreateSequenceFlow11qSequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlowClearToolButtonClickSequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16ChangeSearchModuleSequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateSequenceFlow30SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateModuleProcessInstanceNotExistCaptionLocalizableString());
			LocalizableStrings.Add(CreateModuleProcessInstanceNotExistMessageLocalizableString());
			LocalizableStrings.Add(CreateRunFromRunProcessButtonErrorCaptionLocalizableString());
			LocalizableStrings.Add(CreateRunFromRunProcessButtonErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateMessagePanelRemindingMessageLocalizableString());
			LocalizableStrings.Add(CreateMessagePanelShowLinkTextLocalizableString());
			LocalizableStrings.Add(CreatePopupInfoMessageLocalizableString());
			LocalizableStrings.Add(CreateAttentionCaptionLocalizableString());
			LocalizableStrings.Add(CreatePopupInfoMessageLinkCaptionLocalizableString());
			LocalizableStrings.Add(CreateUserGuideFileNameLocalizableString());
			LocalizableStrings.Add(CreateConfigGuideFileNameLocalizableString());
			LocalizableStrings.Add(CreateExitLinkCaptionLocalizableString());
			LocalizableStrings.Add(CreateLDAPUsersWereAddedLSLocalizableString());
			LocalizableStrings.Add(CreateProcessSynchWithLDAPLaunchedLSLocalizableString());
			LocalizableStrings.Add(CreateOpenLDAPUsersListLSLocalizableString());
			LocalizableStrings.Add(CreateErrorCheckRequiredLDAPSettingsLSLocalizableString());
			LocalizableStrings.Add(CreateChatLinkCaptionLocalizableString());
			LocalizableStrings.Add(CreateBuyLinkCaptionLocalizableString());
			LocalizableStrings.Add(CreateBuyLinkUrlLocalizableString());
			LocalizableStrings.Add(CreateStartTuningModeMessageLocalizableString());
			LocalizableStrings.Add(CreateSchemaLocalizableString1LocalizableString());
			LocalizableStrings.Add(CreateEndTuningModeMessageLocalizableString());
			LocalizableStrings.Add(CreateTuningModeIsNotImplementedMessageLocalizableString());
			LocalizableStrings.Add(CreateSetOnSettingsModeSettingsButtonMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateImapServersSettingsSettingsButtonMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateSetOffSettingsModeSettingsButtonMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateImapNewMailsLocalizableString());
			LocalizableStrings.Add(CreateImapIncorrectNewMailsLocalizableString());
			LocalizableStrings.Add(CreateMessagePanelSetNowLinkTextLocalizableString());
			LocalizableStrings.Add(CreateEditSocialAccountsButtonMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateChatLinkUrlLocalizableString());
			LocalizableStrings.Add(CreateLicensesSettingsButtonMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateDontShowCheckboxCaptionLocalizableString());
			LocalizableStrings.Add(CreateCloseInformationWindowCaptionLocalizableString());
			LocalizableStrings.Add(CreateWelcomeScreenCaptionLocalizableString());
			LocalizableStrings.Add(CreateEditTelephonyButtonMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateCCSettingsOpenFailCaptionLocalizableString());
			LocalizableStrings.Add(CreateCCSettingsOpenFailMsgLocalizableString());
			LocalizableStrings.Add(CreateSetMailChimpSettingsButtonMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateOpenIntegrationLogButtonMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateCommandGenerationButtonMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateImportButtonMenuItemCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateModuleProcessInstanceNotExistCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ba940627-749f-4d4b-a1b8-dad5bf81b3ff"),
				Name = "ModuleProcessInstanceNotExistCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateModuleProcessInstanceNotExistMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fe683fde-117b-4891-ba81-0ffee1a763c4"),
				Name = "ModuleProcessInstanceNotExistMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRunFromRunProcessButtonErrorCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("babd883a-45dd-4eb6-9340-81854549336c"),
				Name = "RunFromRunProcessButtonErrorCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRunFromRunProcessButtonErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("51e86568-bd1b-44ac-961d-e4af4bf002e0"),
				Name = "RunFromRunProcessButtonErrorMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMessagePanelRemindingMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6fefba3c-4909-4b9b-96a8-786da9d61326"),
				Name = "MessagePanelRemindingMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMessagePanelShowLinkTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8e17a428-f2a7-4118-be01-e39ae6377152"),
				Name = "MessagePanelShowLinkText",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePopupInfoMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bb0478de-d704-43b1-bf1e-56019501f030"),
				Name = "PopupInfoMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAttentionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ef1af57b-fe78-415e-a982-607ddc6ffcf6"),
				Name = "AttentionCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePopupInfoMessageLinkCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1c2df391-0e29-49f6-9b77-81c3d1f8c2b3"),
				Name = "PopupInfoMessageLinkCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUserGuideFileNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a523b44e-4139-40a3-8706-72542ef41d3c"),
				Name = "UserGuideFileName",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateConfigGuideFileNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0f3c64c7-60e4-4d1b-ba46-26237e286b09"),
				Name = "ConfigGuideFileName",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExitLinkCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("05cb4388-f69c-4e96-b040-912a72de97fd"),
				Name = "ExitLinkCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLDAPUsersWereAddedLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1b378cbe-ab11-48b3-95f4-0985d9e925e4"),
				Name = "LDAPUsersWereAddedLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateProcessSynchWithLDAPLaunchedLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("67d823fb-3957-4eeb-bdf5-6591ad068c4d"),
				Name = "ProcessSynchWithLDAPLaunchedLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOpenLDAPUsersListLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6d314636-da7e-4bed-95d2-4685cf53d46f"),
				Name = "OpenLDAPUsersListLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorCheckRequiredLDAPSettingsLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("22e18d4b-9956-4a5e-b499-4dc53bb14d9d"),
				Name = "ErrorCheckRequiredLDAPSettingsLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateChatLinkCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1c2a504c-f617-44e1-8095-5ced7ae2289c"),
				Name = "ChatLinkCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBuyLinkCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3a17f4f0-f9d1-42c8-a4ad-a3dd71100f59"),
				Name = "BuyLinkCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBuyLinkUrlLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9c6ec934-fa04-4561-a085-c459f39dd3ce"),
				Name = "BuyLinkUrl",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartTuningModeMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("db0a692e-1960-4c22-bf96-311543415fd8"),
				Name = "StartTuningModeMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSchemaLocalizableString1LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("534bcc4b-a052-46bf-86a5-927b9424c0e6"),
				Name = "SchemaLocalizableString1",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEndTuningModeMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("be28b6ea-8f83-45f5-864b-252980a430e4"),
				Name = "EndTuningModeMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTuningModeIsNotImplementedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("316c4cb7-29fe-482d-8151-20a262973312"),
				Name = "TuningModeIsNotImplementedMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSetOnSettingsModeSettingsButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("91ab5b16-27ca-483a-9061-8db437a87652"),
				Name = "SetOnSettingsModeSettingsButtonMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImapServersSettingsSettingsButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1650cc81-9909-4e6e-95be-4dbf6d4da6dc"),
				Name = "ImapServersSettingsSettingsButtonMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSetOffSettingsModeSettingsButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("34ef7dc5-b688-4b3f-8180-3547f8cbf527"),
				Name = "SetOffSettingsModeSettingsButtonMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImapNewMailsLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c65d1788-02a7-4a3f-9f14-1a8d29462825"),
				Name = "ImapNewMails",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImapIncorrectNewMailsLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5e6d6e2b-60a9-46e4-a279-b265b0dd162c"),
				Name = "ImapIncorrectNewMails",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMessagePanelSetNowLinkTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7d4aa447-a964-49b6-a140-041798bf1e18"),
				Name = "MessagePanelSetNowLinkText",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEditSocialAccountsButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d53f2bbd-43e4-40ed-876d-f3b40bad2b5e"),
				Name = "EditSocialAccountsButtonMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateChatLinkUrlLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bb532333-ac70-4ce4-b70d-ad2ec9f8cb69"),
				Name = "ChatLinkUrl",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLicensesSettingsButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c9e0fd12-f5d5-40df-844f-a93f1616b487"),
				Name = "LicensesSettingsButtonMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDontShowCheckboxCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a66882fc-b782-478b-b0ff-f0fbd6a49971"),
				Name = "DontShowCheckboxCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCloseInformationWindowCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ef5f7556-5596-497a-b21c-333338122941"),
				Name = "CloseInformationWindowCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWelcomeScreenCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e2db6d51-965e-4ab1-83a6-97cc1e087e07"),
				Name = "WelcomeScreenCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEditTelephonyButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f8ad4d3b-fca7-47b2-9b03-015d49a3016e"),
				Name = "EditTelephonyButtonMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCCSettingsOpenFailCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("296865eb-3050-43ee-acdf-f5c618f304f2"),
				Name = "CCSettingsOpenFailCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCCSettingsOpenFailMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7d581e3e-c831-440e-9171-cd0d056212be"),
				Name = "CCSettingsOpenFailMsg",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSetMailChimpSettingsButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0f64c691-fd21-4612-9d88-9e5448432720"),
				Name = "SetMailChimpSettingsButtonMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOpenIntegrationLogButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9e5a90d8-feab-45fa-91c0-fd5cd216bbab"),
				Name = "OpenIntegrationLogButtonMenuItemCaption",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCommandGenerationButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("875c3fed-f0a7-4980-8a6b-23cf8df4f630"),
				Name = "CommandGenerationButtonMenuItemCaption",
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImportButtonMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ed06aa4b-c91c-4aae-b024-ab1a30886c6f"),
				Name = "ImportButtonMenuItemCaption",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow78SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow78",
				UId = new Guid("cf434ac1-bda4-4c7a-ad20-a75935884fd6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(249, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a18309ca-d658-47cb-a6d3-c29ef17f5f19"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c51b2c11-6171-4ca9-94d7-e25ae4d55857"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow79SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow79",
				UId = new Guid("4a3cd03e-4bd8-4e4c-9293-62f39d45467d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(174, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1a88a3db-d2bd-485f-8849-fdec99dff48a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2444c3b3-15a8-4d2e-b538-a14b8c25ce9e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow80SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow80",
				UId = new Guid("426fa0d6-cf29-4f29-9319-f85525aacf5e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(308, 437),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("753bba86-fa6f-4900-a025-e934caca069b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8859912c-41a8-4eba-9b5e-db0a3c1d1ac5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow81SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow81",
				UId = new Guid("c1387146-1ddd-487d-b3d3-4c132b233dbd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab094bca-c0f3-446c-8a96-5f83591ab308"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("42af6167-1d4b-4676-a975-c0557b3a30db"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow82SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow82",
				UId = new Guid("e913f2e6-85bb-48b0-a686-00cc88a7ef8c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(424, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("94ce6734-d6d7-46a5-a797-d7c9f73022d6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7c127c89-75ea-4cc1-a343-f19f36a77a6a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow83SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow83",
				UId = new Guid("867e0df1-b97f-44af-a1b3-27e2b7ba740d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(494, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c127c89-75ea-4cc1-a343-f19f36a77a6a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8815c5ff-679e-4518-969e-22358826c8d4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow84SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow84",
				UId = new Guid("5871406d-106d-45af-9ba9-7834ae4d1360"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(570, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8815c5ff-679e-4518-969e-22358826c8d4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2814422c-12dd-49d0-aa7b-0fd8795728a2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow85SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow85",
				UId = new Guid("89c80248-605b-4969-b020-ea79611bf77d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(644, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2814422c-12dd-49d0-aa7b-0fd8795728a2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6770ea02-22ed-4c25-bdac-b0955709bb20"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow86SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow86",
				UId = new Guid("3e035a16-bd6c-42ed-bea5-9b6a59dbb147"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(578, 276),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("82264521-65aa-43fd-bc03-f3b418a82775"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow87SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow87",
				UId = new Guid("5d368e28-375c-480b-958a-b943abf96932"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(158, 455),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b65bf503-18bd-448b-81e5-67fdb52482c9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("131613ba-034f-430b-8049-a4bd3c82e1f7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow88SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow88",
				UId = new Guid("a3d73d3f-71ac-4b8b-8500-3c891a4564db"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(380, 402),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7921c78-2805-483d-8ab7-3dcbae70fffc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7185ed34-513e-4ad8-9b4f-214adc322c7a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow89ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow89",
				UId = new Guid("845bec74-2d91-45bb-aa77-b2db046729e6"),
				ConditionExpression = @"MessagePanelClickedLinkId == RemindingsPageUId.ToString()",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(440, 450),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7185ed34-513e-4ad8-9b4f-214adc322c7a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e14fa834-871c-4935-a8ad-ddf57bca0df5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow90SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow90",
				UId = new Guid("0b972a4d-293a-4c7f-bd5f-8a9c511e5372"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(274, 570),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7185ed34-513e-4ad8-9b4f-214adc322c7a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e6f68b51-1331-4be3-b775-39c7322638f1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow91SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow91",
				UId = new Guid("18f954ea-a82e-43c2-aeca-861d28ee3239"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(314, 672),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e14fa834-871c-4935-a8ad-ddf57bca0df5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow92SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow92",
				UId = new Guid("a2a1039a-dc03-4fa0-b5c0-cac0e2b6d73c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(586, 549),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("076bc514-7c3e-4f54-bdb5-5ebfd72b1e06"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63356494-85eb-4129-a50e-dd6835075a02"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow93SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow93",
				UId = new Guid("9b0341ad-305e-4e39-b714-a6612723c629"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(663, 532),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9de3122-2104-4e62-8c39-0fc4cdf8b23c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4c06641-4593-4e6c-a444-ad29d48f9890"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow94SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow94",
				UId = new Guid("a1b4ec93-1d25-438f-ae20-e2fe527fd73b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00bc3671-670b-471d-971a-2372f88386a3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6b395840-0f8b-469c-9ba4-c3e4babc5a88"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow95SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow95",
				UId = new Guid("d6afe2fe-b114-4a44-877e-554a3ff25581"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(144, 1132),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("452cc4ee-729d-4e71-9d52-4221fe0cf186"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6af27a8d-b97b-4599-85ad-128853c2ea30"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow96SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow96",
				UId = new Guid("28e666da-6923-4832-9ecf-270b9c88df95"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(540, 1122),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f0614af-91f0-4f0b-9f0a-864cd28339cf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e747b89d-d683-4c6e-a017-7650e52823b2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow97SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow97",
				UId = new Guid("023df5b7-cad2-4aec-9bd3-3c6edd7426f0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(256, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b395840-0f8b-469c-9ba4-c3e4babc5a88"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2ed4d1d8-8401-4a69-8ec4-abad6083bb69"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("0fc2c2ef-c581-415c-822e-7678cb209ab3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(190, 250),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("47b626c6-56a0-4421-b728-deb5601e2cd9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4d0883c-8903-4cc9-ad9b-8f2f9494a593"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("dd248bd7-9472-461b-bb05-28114ca2229c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(324, 253),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4d0883c-8903-4cc9-ad9b-8f2f9494a593"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("91e34f72-437e-4615-bab2-4f981abed21f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateMailboxSettingsConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "MailboxSettingsConditionalFlow",
				UId = new Guid("9d2e8972-9675-4586-b15d-acdba447a457"),
				ConditionExpression = @"MessagePanelClickedLinkId == MailboxSynchronizationSettingsPageUId.ToString()",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(296, 1010),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7185ed34-513e-4ad8-9b4f-214adc322c7a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4186fb24-821e-43f0-91f7-702ed83c1727"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("9abc3f78-ddaf-464f-9886-806d1edec56a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(344, 1059),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4186fb24-821e-43f0-91f7-702ed83c1727"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("7d006a29-0066-49b0-bf99-a029693f2e9b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(553, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b030f99-a261-44c2-ba53-8713f5847b7a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f7bcdaf6-d2bd-4971-9cd1-5da7d95a10a0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("bf46fbfc-1f34-4fa1-a65a-8720269b5bf0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(682, 73),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f7bcdaf6-d2bd-4971-9cd1-5da7d95a10a0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b98b0491-c901-4970-b579-b95360d1f5b9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("1309805f-f384-42de-9aa7-54422d1a0041"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(568, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18dbd9ac-8f5f-4f0d-8dca-0c6c5ee209a8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("add703c4-da59-4675-8f8d-eb691e1c690a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("27102971-4ab8-4df3-a984-a956a84bc95f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(704, 442),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("add703c4-da59-4675-8f8d-eb691e1c690a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10qSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10q",
				UId = new Guid("b2709ce5-0387-4ba3-99e8-0a5d5594fb60"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("76d7400b-fe95-453c-9e91-c74c87b9a7b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bbe5807a-7140-46ce-9054-68a7349d6a5d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11qSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11q",
				UId = new Guid("a687bf21-2867-4740-b462-698a48f03431"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(260, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bbe5807a-7140-46ce-9054-68a7349d6a5d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("5bce4f20-da56-4e7a-9f39-072f1f15dc46"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(622, 1492),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0d6e9f24-b409-438c-9cf5-20245ea7b961"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e2b288d-6948-44e7-9faa-449064be0d12"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("f2ddd7ba-00a0-43e7-8d2a-64b28fcb72bc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(544, 1682),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ca546d89-405a-447c-a00c-5af310cdd73e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe930371-0739-4b82-ad7b-784a41697630"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("bb2aba24-0e53-4b3a-a613-d1bb3eb7840b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(254, 782),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f59859f0-7215-44e4-a591-a96a5efa6039"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2adf5ea1-6ddd-4a27-8781-f8c6e6672edf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("1c7159bb-86a0-484c-bb01-011483b86737"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e00efa9c-3d00-4469-9aff-1bc42424bc34"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b366f944-3e81-43be-afa0-3a4905580191"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("3dd4836f-4856-477f-9650-a63cf6ce8224"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(480, 446),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e8b65e17-88ed-4140-861c-a27b2fb0534b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ee6a1214-b865-4559-9fd3-54e8c2bf59e8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowClearToolButtonClickSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowClearToolButtonClick",
				UId = new Guid("9ea0f6e2-b208-443d-ace3-94975d9f533f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cdace97d-c0e6-4826-a0c7-c5dc073ca749"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b361495a-2d74-46f4-b5f9-f6d0e76f6562"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("06304a14-8868-43be-8817-64561c2c1671"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(558, 1492),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b361495a-2d74-46f4-b5f9-f6d0e76f6562"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ee6a1214-b865-4559-9fd3-54e8c2bf59e8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16ChangeSearchModuleSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16ChangeSearchModule",
				UId = new Guid("e9e263fa-0087-4fea-be42-655858a605ec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(712, 1450),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6885e5fc-3f63-4e5e-a3f1-107daa1c2628"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c9f983a6-98c9-4715-8cd2-f95fdfd3e241"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("7060afdb-fbbd-43f4-83e0-b1496119f8cf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60b2eeae-40d2-4458-aed6-27631b179245"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("91362b05-9e57-4d57-933a-543b89de1176"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("875d7077-a332-43f8-b10f-df9783c6fb1e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(524, 543),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("46c0cf64-8ba5-40f5-9672-7cf91a66ed51"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a796e222-b7a7-4c51-9eaa-60e7f1e03ee9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("edc82526-a10a-4053-8975-cfccfdefef59"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(656, 556),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a796e222-b7a7-4c51-9eaa-60e7f1e03ee9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("302daab4-70a0-4ae6-b241-a45c3930a488"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(172, 726),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b128ddba-b67a-4f02-a5ae-747c276d1788"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cdd0ba6c-d857-4f7f-8ee9-650d4867e470"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow27",
				UId = new Guid("bc3320ff-41c7-46f9-8c58-50045245dffd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(314, 728),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cdd0ba6c-d857-4f7f-8ee9-650d4867e470"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow28",
				UId = new Guid("25df26dd-3c5d-42d0-a949-a7132d195a34"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(562, 731),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c14bb798-2674-4c1d-9535-32194f766373"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4f299ce7-f675-4db9-80de-12d1baa15a84"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow30SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow30",
				UId = new Guid("b25b3643-28d8-4cdd-86b6-b2ec0bc34ea3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(318, 882),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f0bbc3fc-c4ae-475d-8225-6b03220fb4a7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29",
				UId = new Guid("d88cb061-eb12-4d71-87f2-6c1f53efe53f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CurveCenterPosition = new Point(170, 880),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4656174e-7a66-4415-9903-4605217de76e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0bbc3fc-c4ae-475d-8225-6b03220fb4a7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateMyLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaMyLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9ed96222-3202-4f08-914e-493bbb759155"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MyLaneSet",
				Position = new Point(5, 5),
				Size = new Size(1096, 159),
				UseBackgroundMode = false
			};
			return schemaMyLaneSet;
		}

		protected virtual ProcessSchemaLane CreateExitButtonLaneLane() {
			ProcessSchemaLane schemaExitButtonLane = new ProcessSchemaLane(this) {
				UId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9ed96222-3202-4f08-914e-493bbb759155"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ExitButtonLane",
				Position = new Point(29, 0),
				Size = new Size(1067, 159),
				UseBackgroundMode = false
			};
			return schemaExitButtonLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("198430a9-d064-4731-b549-f925646c7dda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess10",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateExitButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("60b2eeae-40d2-4458-aed6-27631b179245"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("198430a9-d064-4731-b549-f925646c7dda"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ExitButtonClick",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ExitButtonClickStartMessage",
				Position = new Point(14, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateExitButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("91362b05-9e57-4d57-933a-543b89de1176"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("198430a9-d064-4731-b549-f925646c7dda"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ExitButtonClickScriptTask",
				Position = new Point(112, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateRemindingsPageEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaRemindingsPageEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("92c85eb3-52fe-4f08-87c8-4628e515b367"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"RemindingsPageEventSubProcess",
				Position = new Point(35, 171),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(416, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaRemindingsPageEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2qStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("76d7400b-fe95-453c-9e91-c74c87b9a7b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92c85eb3-52fe-4f08-87c8-4628e515b367"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"NewRemindingsCountButtonClick",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"StartMessage2q",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRemindingsPageParamsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bbe5807a-7140-46ce-9054-68a7349d6a5d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92c85eb3-52fe-4f08-87c8-4628e515b367"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"RemindingsPageParamsScriptTask",
				Position = new Point(148, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,79,79,131,64,16,197,207,242,41,54,156,104,44,155,154,66,133,160,38,198,38,134,147,13,133,120,30,96,172,155,202,110,157,93,108,154,166,223,221,5,26,108,76,244,50,251,111,222,111,223,188,12,27,33,107,33,55,122,5,27,44,210,154,221,51,137,123,246,220,138,218,115,227,58,154,87,101,88,250,33,192,220,15,130,40,240,227,58,140,253,155,42,196,219,114,22,45,96,22,186,147,196,249,2,98,66,106,3,178,194,30,225,121,57,18,129,86,111,134,23,41,127,197,242,73,73,67,234,67,243,238,159,73,87,248,163,222,245,7,158,142,82,158,171,181,33,107,199,179,84,221,239,216,22,15,150,120,129,191,102,189,188,43,29,21,132,68,226,133,20,159,45,166,203,196,89,191,171,125,54,142,85,104,164,28,244,150,191,236,208,246,165,151,46,45,249,207,246,159,56,178,223,17,253,171,89,1,65,131,6,73,159,147,92,138,202,8,37,129,14,119,195,64,83,54,172,15,236,232,92,29,221,198,250,239,133,164,42,212,218,242,221,233,121,192,225,102,140,199,62,157,156,83,226,56,132,166,37,201,12,181,152,124,3,124,243,207,145,193,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowRemindingsUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b94dff6f-0b12-44d5-8ffa-16980092cdc4"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92c85eb3-52fe-4f08-87c8-4628e515b367"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ShowRemindingsUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 30),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowRemindingsUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSettingsModeSettingsButtonMenuItemEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSettingsModeSettingsButtonMenuItemEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("67086d1e-c4e1-4f11-affd-c57c23097333"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SettingsModeSettingsButtonMenuItemEventSubProcess",
				Position = new Point(35, 341),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(374, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSettingsModeSettingsButtonMenuItemEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSettingsModeSettingsButtonMenuItemEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("00bc3671-670b-471d-971a-2372f88386a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67086d1e-c4e1-4f11-affd-c57c23097333"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SettingsModeSettingsButtonMenuItemEvent",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SettingsModeSettingsButtonMenuItemEvent",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSettingsButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6b395840-0f8b-469c-9ba4-c3e4babc5a88"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67086d1e-c4e1-4f11-affd-c57c23097333"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SettingsButtonClickScript",
				Position = new Point(141, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,79,77,11,130,64,16,189,247,43,22,47,42,196,218,93,58,132,116,16,10,2,141,14,209,97,210,73,5,155,141,217,209,232,223,183,154,68,81,167,121,195,251,226,69,209,14,42,212,171,178,204,10,110,110,18,120,208,34,75,224,251,115,229,103,40,210,80,101,147,26,168,194,210,15,189,48,158,245,192,170,48,36,72,50,88,19,7,161,33,100,181,84,99,84,242,226,134,195,166,221,192,195,116,162,83,193,171,61,46,78,10,172,202,145,25,172,185,136,222,167,250,128,231,73,105,245,27,124,229,254,52,186,162,127,253,163,43,37,43,64,5,198,179,15,137,206,107,54,247,117,239,222,192,203,59,114,147,182,166,196,105,213,176,137,81,58,38,37,220,97,252,4,68,203,21,10,18,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPrepeareInformationScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2ed4d1d8-8401-4a69-8ec4-abad6083bb69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67086d1e-c4e1-4f11-affd-c57c23097333"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptTaskPrepeareInformation",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,209,106,131,64,16,124,246,190,226,200,147,130,248,1,149,82,154,144,150,123,176,149,154,31,56,226,26,4,111,79,238,214,208,80,250,239,61,79,141,166,105,160,237,219,49,59,59,179,115,187,150,76,141,7,174,192,90,121,0,126,207,173,7,146,173,106,233,148,50,59,150,117,217,53,176,145,45,213,26,29,233,25,40,91,66,97,1,13,236,9,202,1,21,101,148,178,186,226,161,176,187,14,157,192,0,71,252,131,5,179,211,80,202,141,222,59,200,49,128,63,76,238,79,218,40,73,97,65,210,208,89,1,178,161,53,190,28,39,226,119,124,139,229,21,45,217,233,194,171,133,81,26,176,79,14,141,133,203,1,46,205,102,1,97,95,52,9,213,54,160,0,251,80,63,251,246,170,62,229,85,16,31,180,0,34,7,123,96,122,175,59,34,141,25,96,39,8,212,252,159,174,254,90,85,191,238,88,70,91,36,251,171,35,254,211,144,109,116,255,57,116,163,199,246,164,163,52,211,81,137,210,249,173,232,251,126,86,41,203,251,53,173,165,157,160,92,34,52,201,27,40,125,132,240,220,29,221,34,62,150,211,106,102,114,204,130,32,24,206,109,92,136,64,75,18,247,224,118,186,125,175,45,141,145,226,105,188,152,143,34,187,83,11,137,192,202,159,131,95,48,51,64,157,65,78,166,131,244,11,48,109,47,97,42,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateImapServersSettingsSettingsButtonMenuItemEventEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaImapServersSettingsSettingsButtonMenuItemEventEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("738e401c-03a2-4e39-bd0c-90713dbf8b6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ImapServersSettingsSettingsButtonMenuItemEventEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 488),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(378, 178),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaImapServersSettingsSettingsButtonMenuItemEventEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateImapServersSettingsSettingsButtonMenuItemEventStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("47b626c6-56a0-4421-b728-deb5601e2cd9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("738e401c-03a2-4e39-bd0c-90713dbf8b6e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ImapServersSettingsSettingsButtonMenuItemEvent",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ImapServersSettingsSettingsButtonMenuItemEventStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateImapServersSettingsSettingsButtonMenuItemEventScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a4d0883c-8903-4cc9-ad9b-8f2f9494a593"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("738e401c-03a2-4e39-bd0c-90713dbf8b6e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ImapServersSettingsSettingsButtonMenuItemEventScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,79,79,194,64,16,197,207,244,83,108,122,161,68,186,17,104,80,3,154,24,136,73,163,196,38,165,241,188,109,167,184,82,118,113,102,171,33,132,239,206,118,69,37,158,188,76,50,255,126,239,61,50,40,213,138,73,69,70,168,2,226,146,221,178,32,88,2,162,32,93,25,158,197,252,5,242,153,86,6,117,77,60,17,43,232,181,133,223,211,214,53,60,254,121,229,75,157,58,92,208,155,120,207,91,80,241,70,108,83,192,15,64,74,193,24,187,161,140,0,151,130,214,60,65,93,0,209,35,236,172,226,153,252,5,115,248,182,180,170,66,42,64,158,41,249,222,64,60,255,7,214,254,37,2,197,6,140,93,91,180,130,79,54,151,133,145,90,9,220,177,41,57,135,125,166,243,55,40,204,93,208,99,123,175,211,217,251,84,188,194,70,100,113,233,247,217,66,200,250,75,32,253,158,30,250,238,170,214,122,221,184,224,233,217,189,223,133,97,116,57,184,206,171,48,130,106,28,70,55,80,133,98,52,26,132,81,85,230,227,252,42,26,66,84,116,253,19,4,74,105,22,186,4,251,105,176,129,211,244,201,161,31,100,221,26,183,171,214,248,76,215,53,56,239,211,223,12,127,35,216,12,7,175,115,152,120,8,166,65,229,152,147,35,43,62,98,244,216,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenImapServersSettingsUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("91e34f72-437e-4615-bab2-4f981abed21f"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("738e401c-03a2-4e39-bd0c-90713dbf8b6e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"OpenImapServersSettingsUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 54),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenImapServersSettingsUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("89186007-50dc-4dcb-afc8-858d4f155a1d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(421, 344),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(347, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEditSocialAccountsButtonMenuItemEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6b030f99-a261-44c2-ba53-8713f5847b7a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89186007-50dc-4dcb-afc8-858d4f155a1d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EditSocialAccountsButtonMenuItemEvent",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EditSocialAccountsButtonMenuItemEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOpenSocialAccountGridScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f7bcdaf6-d2bd-4971-9cd1-5da7d95a10a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89186007-50dc-4dcb-afc8-858d4f155a1d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"OpenSocialAccountGridScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,77,79,219,64,16,61,147,95,177,245,5,71,197,134,144,144,130,2,72,144,4,20,181,148,72,9,237,161,234,97,188,59,78,182,117,118,205,238,154,18,161,252,247,206,218,41,249,104,132,240,97,37,143,231,189,153,55,111,214,79,96,24,42,39,221,124,196,167,56,131,59,80,48,65,195,46,216,131,69,211,213,74,33,119,82,171,184,255,127,82,167,182,30,100,86,115,9,217,21,231,186,80,110,25,187,216,69,30,223,162,27,40,235,64,113,188,158,127,133,25,134,193,104,29,28,212,59,53,235,140,84,19,102,75,224,195,64,16,213,142,2,49,125,137,199,122,84,38,135,43,152,92,210,151,184,48,28,163,49,96,117,234,40,63,254,142,9,233,114,70,103,54,30,82,63,117,127,196,87,54,47,95,226,193,43,116,131,248,62,71,181,209,228,173,145,162,68,14,141,230,104,237,103,156,83,173,181,194,31,89,245,153,14,95,15,164,34,233,15,74,62,22,56,232,189,73,72,199,16,12,205,197,161,177,68,170,240,15,235,201,210,7,48,115,118,94,137,60,96,58,249,69,238,92,250,246,158,200,199,124,27,23,190,1,170,191,183,126,167,182,201,27,95,9,17,6,175,190,4,7,43,143,168,143,195,67,118,118,210,68,4,56,142,68,27,69,212,106,67,59,130,246,167,102,116,146,156,166,237,36,109,136,70,163,181,147,51,211,250,119,81,186,48,90,99,15,246,155,77,206,91,208,132,40,129,36,33,194,150,136,78,143,225,40,106,36,103,71,45,209,56,59,21,205,198,190,223,153,174,206,178,106,93,207,87,202,183,133,95,178,84,102,107,131,125,31,40,44,181,145,186,241,125,239,158,241,41,168,9,178,41,24,161,185,64,118,91,72,193,116,202,198,163,235,124,198,180,98,6,65,176,212,232,25,19,224,32,1,139,53,153,178,240,195,214,165,234,93,143,144,23,134,46,72,95,77,104,63,252,205,232,130,234,63,83,212,33,57,100,192,231,133,1,5,171,203,243,165,156,145,13,234,117,246,82,219,91,42,41,199,183,185,36,219,2,124,54,61,236,37,224,122,150,131,145,86,171,241,60,71,26,240,77,73,210,221,8,199,253,199,2,178,197,193,63,80,134,169,235,63,231,134,246,156,248,105,100,197,76,13,193,77,189,63,94,83,76,86,173,178,11,139,61,105,243,12,230,223,32,43,124,141,20,50,139,108,149,97,228,100,186,70,248,186,9,101,190,37,128,87,83,181,254,227,39,123,41,215,114,107,118,221,194,24,250,185,44,171,47,22,11,114,104,111,215,90,85,35,171,84,122,234,229,208,40,125,177,115,13,81,72,119,167,133,111,59,112,134,218,175,119,246,106,6,93,97,20,243,239,157,191,28,71,7,230,52,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenSocialAccountGridPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b98b0491-c901-4970-b579-b95360d1f5b9"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89186007-50dc-4dcb-afc8-858d4f155a1d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"OpenSocialAccountGridPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 31),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenSocialAccountGridPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("77517f97-cb98-4864-ad3e-d1a00d859388"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(427, 495),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(357, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("18dbd9ac-8f5f-4f0d-8dca-0c6c5ee209a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77517f97-cb98-4864-ad3e-d1a00d859388"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LicensesSettingsButtonMenuItemEvent",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLicensesSettingsButtonMenuItemEventScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("add703c4-da59-4675-8f8d-eb691e1c690a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77517f97-cb98-4864-ad3e-d1a00d859388"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"LicensesSettingsButtonMenuItemEventScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,141,177,10,194,64,12,134,119,193,119,56,58,41,200,233,210,65,138,147,131,45,84,42,98,233,124,246,126,218,131,114,173,185,28,244,241,77,7,65,116,72,200,159,239,35,169,38,248,210,181,55,211,65,87,50,131,10,31,216,248,22,133,85,39,245,9,117,97,179,245,170,250,146,27,103,185,23,227,152,30,126,72,14,215,245,44,40,253,67,75,171,105,16,214,224,89,179,27,28,59,4,125,1,203,246,49,150,163,177,160,69,218,228,204,211,121,244,140,153,245,57,18,193,179,190,227,21,17,120,167,146,189,28,92,234,106,188,200,164,77,152,230,100,43,207,8,28,201,43,166,136,236,13,105,8,75,135,219,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLicPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("465135e7-f485-40b9-9e38-6b4143871c03"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("77517f97-cb98-4864-ad3e-d1a00d859388"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"OpenLicPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 54),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLicPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSetMailChimpSettingsButtonMenuItemEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSetMailChimpSettingsButtonMenuItemEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b33671fa-1eb2-41d3-8d8b-ba7415fd0505"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SetMailChimpSettingsButtonMenuItemEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(421, 668),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(378, 189),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSetMailChimpSettingsButtonMenuItemEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSetMailChimpSettingsButtonMenuItemEventStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("46c0cf64-8ba5-40f5-9672-7cf91a66ed51"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b33671fa-1eb2-41d3-8d8b-ba7415fd0505"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SetMailChimpSettingsButtonMenuItemEvent",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SetMailChimpSettingsButtonMenuItemEventStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 84),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateSetMailChimpSettingsButtonMenuItemEventUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("eef1fdcd-66a3-409a-8c77-6f7d7bb6aee2"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b33671fa-1eb2-41d3-8d8b-ba7415fd0505"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SetMailChimpSettingsButtonMenuItemEventUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 70),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSetMailChimpSettingsButtonMenuItemEventUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSetMailChimpIntegrationSettingPrepareScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a796e222-b7a7-4c51-9eaa-60e7f1e03ee9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b33671fa-1eb2-41d3-8d8b-ba7415fd0505"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SetMailChimpIntegrationSettingPrepareScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,241,77,204,204,113,206,200,204,45,8,78,45,41,201,204,75,47,118,42,45,41,201,207,243,77,205,43,245,44,73,205,117,45,75,205,43,9,45,78,45,10,73,44,206,214,243,47,72,205,75,45,242,204,43,46,73,204,75,78,245,76,81,176,85,128,113,66,61,83,172,121,185,130,73,52,48,32,49,29,164,19,104,14,134,54,144,84,112,114,70,106,110,34,196,232,162,212,146,210,162,60,133,146,162,210,84,107,0,234,247,59,84,184,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("05aeca4d-a7cd-4205-a4bd-03a692f41596"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 859),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(382, 327),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSetIntegrationLogMenuItemEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b128ddba-b67a-4f02-a5ae-747c276d1788"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("05aeca4d-a7cd-4205-a4bd-03a692f41596"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SetIntegrationLogMenuItemEvent",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SetIntegrationLogMenuItemEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePreparePageParametersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cdd0ba6c-d857-4f7f-8ee9-650d4867e470"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("05aeca4d-a7cd-4205-a4bd-03a692f41596"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"PreparePageParametersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,205,243,204,43,73,77,47,74,44,201,204,207,243,201,79,15,45,78,45,10,73,44,206,214,243,7,74,165,22,121,230,21,151,36,230,37,167,122,166,40,216,42,192,56,161,158,41,214,188,92,254,184,245,6,36,166,131,20,1,181,228,165,150,43,184,151,102,166,104,40,153,88,26,152,152,90,152,89,234,154,166,36,155,234,154,24,165,152,235,38,89,26,167,233,90,166,154,165,26,166,24,26,24,153,167,153,43,105,2,205,45,74,45,41,45,202,83,40,41,42,77,181,6,0,104,7,106,190,160,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenIntegrationLogUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("0c1d0dc3-c84a-42bf-8420-ebb793729a31"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("05aeca4d-a7cd-4205-a4bd-03a692f41596"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"OpenIntegrationLogUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 54),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenIntegrationLogUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateImportButtonMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4656174e-7a66-4415-9903-4605217de76e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("05aeca4d-a7cd-4205-a4bd-03a692f41596"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ImportButtonMenuItemClick",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ImportButtonMenuItemClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 222),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f0bbc3fc-c4ae-475d-8225-6b03220fb4a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("05aeca4d-a7cd-4205-a4bd-03a692f41596"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 208),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,203,78,195,48,16,69,215,69,226,31,76,86,142,84,185,221,247,33,161,80,170,44,74,139,82,96,129,88,88,201,208,90,36,118,240,3,20,85,253,119,236,56,77,162,182,98,147,104,198,227,115,231,206,120,93,2,143,139,82,72,189,161,59,120,81,32,183,84,125,145,181,77,131,140,185,210,148,167,16,103,104,134,78,193,75,156,77,110,111,214,215,239,213,129,47,111,15,147,116,15,5,245,215,70,35,246,137,112,2,57,164,26,178,149,200,76,238,232,119,51,180,52,44,35,139,162,212,85,136,14,174,112,240,67,37,2,174,153,174,60,225,217,128,172,44,153,195,47,90,156,231,177,107,33,18,156,91,48,19,156,244,11,86,148,219,54,228,16,5,73,165,188,102,16,78,90,13,85,23,197,217,19,45,192,226,47,36,201,125,150,69,34,55,5,199,29,192,243,137,141,251,74,214,100,16,18,7,242,248,75,214,35,203,53,72,229,152,248,242,52,146,64,53,248,154,55,166,247,27,42,45,203,93,192,62,25,137,162,164,146,41,193,183,85,9,100,241,109,104,110,125,89,217,33,58,159,106,216,243,152,138,60,247,147,185,234,112,9,218,219,136,218,186,179,129,54,44,183,189,142,69,34,97,184,70,115,52,62,237,108,240,207,187,232,204,52,75,124,96,53,133,202,106,170,180,100,124,55,68,254,63,199,45,111,112,8,146,102,63,214,98,39,253,62,254,112,93,187,41,52,203,121,165,185,129,169,123,70,115,220,95,105,72,182,34,169,177,56,60,122,232,209,155,169,35,251,145,160,141,228,72,75,3,147,63,207,241,234,130,16,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenImportPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("36f49d1e-c185-4f08-a9b5-f5869287d7e6"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("05aeca4d-a7cd-4205-a4bd-03a692f41596"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"OpenImportPageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 208),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenImportPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCommandGenerationButtonMenuItemEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCommandGenerationButtonMenuItemEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fdf2f631-62ac-4d74-bec0-100febf98915"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CommandGenerationButtonMenuItemEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(428, 864),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(301, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCommandGenerationButtonMenuItemEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCommandGenerationButtonMenuItemEventStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c14bb798-2674-4c1d-9535-32194f766373"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fdf2f631-62ac-4d74-bec0-100febf98915"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CommandGenerationButtonMenuItemEvent",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CommandGenerationButtonMenuItemEventStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCommandGenerationButtonMenuItemScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4f299ce7-f675-4db9-80de-12d1baa15a84"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fdf2f631-62ac-4d74-bec0-100febf98915"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"CommandGenerationButtonMenuItemScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,9,118,206,207,75,203,76,47,45,74,44,201,204,207,211,115,206,207,205,77,204,75,241,201,204,75,13,45,201,204,201,44,169,212,115,206,72,77,206,14,74,77,207,44,46,73,45,74,77,9,78,77,6,169,44,214,8,45,78,45,2,106,206,131,240,53,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,27,75,239,105,89,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateFindSelectedModuleSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaFindSelectedModuleSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("69bde98c-7526-452c-a2d9-3ca70d571484"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"FindSelectedModuleSubProcess",
				Position = new Point(50, 1238),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(230, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaFindSelectedModuleSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFindSelectedModuleStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ab094bca-c0f3-446c-8a96-5f83591ab308"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("69bde98c-7526-452c-a2d9-3ca70d571484"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FindSelectedModule",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"FindSelectedModule",
				Position = new Point(28, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptFindSelectedModuleSubProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("42af6167-1d4b-4676-a975-c0557b3a30db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("69bde98c-7526-452c-a2d9-3ca70d571484"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptFindSelectedModuleSubProcess",
				Position = new Point(112, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,193,110,219,48,12,61,39,64,254,65,200,165,50,16,8,189,23,25,208,25,237,22,96,25,178,37,89,15,195,14,106,204,166,194,100,201,163,36,23,198,182,127,31,101,199,113,60,27,221,14,1,20,242,241,61,242,145,112,41,145,5,7,152,90,99,224,224,149,53,108,201,54,242,8,98,223,139,222,204,166,37,65,193,120,229,171,237,225,25,114,185,150,134,112,216,226,155,160,232,229,54,104,75,149,1,138,119,224,79,33,62,191,27,114,204,19,38,29,219,1,162,116,246,201,139,212,34,136,26,167,192,137,145,130,145,118,62,5,192,138,154,49,240,194,238,254,142,243,145,198,23,108,190,173,220,218,102,65,195,60,33,198,65,85,106,117,200,13,43,8,125,122,46,135,146,226,54,203,154,44,143,124,209,139,38,187,95,101,53,237,176,226,94,105,15,232,98,37,31,102,83,4,233,161,193,60,40,255,188,145,40,115,136,5,188,9,166,54,47,36,42,103,205,174,42,200,167,31,65,106,26,134,228,22,108,11,154,22,6,89,51,214,42,19,59,187,245,168,204,145,39,73,114,114,45,175,115,142,154,214,237,202,39,195,54,104,101,141,33,29,142,247,47,37,242,169,39,198,7,124,180,191,96,60,123,195,174,147,217,244,231,108,58,137,170,238,212,89,103,208,42,35,63,7,197,95,175,191,69,237,198,210,47,82,7,224,221,2,196,71,178,34,234,214,148,47,22,191,187,66,30,160,102,170,175,112,29,180,87,31,160,4,189,147,143,228,48,81,150,64,79,177,147,71,177,45,180,242,252,234,215,85,66,34,3,18,66,17,203,189,50,25,189,222,131,164,187,125,91,81,25,31,35,62,67,220,226,178,141,115,107,205,88,227,124,151,138,61,162,49,139,46,23,24,201,59,195,217,146,142,61,104,157,176,104,241,228,53,197,127,77,240,63,194,191,233,247,170,197,231,101,70,180,171,75,25,66,166,144,168,247,168,41,77,107,253,220,5,248,217,172,91,87,68,230,118,135,237,223,222,39,97,191,18,15,240,72,199,231,209,106,39,34,32,150,159,176,162,229,229,23,138,145,159,186,70,240,1,13,243,24,224,230,15,244,213,78,245,239,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("113a32ea-67e0-4571-8fbe-8a0eb10ccf76"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SubProcess1",
				Position = new Point(288, 1221),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(397, 186),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSelectAndRunProcessEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("94ce6734-d6d7-46a5-a797-d7c9f73022d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("113a32ea-67e0-4571-8fbe-8a0eb10ccf76"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SelectAndRunProcess",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SelectAndRunProcessEvent",
				Position = new Point(28, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSelectAndRunProcessScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7c127c89-75ea-4cc1-a343-f19f36a77a6a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("113a32ea-67e0-4571-8fbe-8a0eb10ccf76"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SelectAndRunProcessScript",
				Position = new Point(56, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,95,111,218,48,20,197,159,169,212,239,96,241,82,208,218,0,162,72,69,237,42,181,192,16,218,90,144,128,246,97,154,38,55,190,1,15,199,78,109,135,46,170,248,238,187,118,210,150,127,171,120,137,32,241,249,221,123,206,189,94,82,77,64,90,110,179,113,56,135,152,222,81,73,103,160,201,87,50,53,160,59,74,74,8,45,87,50,232,237,30,186,60,62,90,127,75,150,47,227,204,220,41,150,10,24,105,21,130,49,136,217,3,15,250,96,7,210,88,42,67,184,205,238,105,12,149,242,131,211,22,170,114,21,201,198,106,46,103,132,23,231,6,12,89,149,202,4,180,166,70,69,54,152,14,130,71,120,194,6,173,86,194,4,35,4,87,221,35,184,49,137,255,19,12,222,165,193,68,141,61,174,226,200,195,4,228,24,4,250,234,82,75,157,205,9,53,139,160,40,254,29,50,172,180,86,246,11,241,88,247,112,213,40,151,232,96,42,249,115,10,131,238,71,163,198,59,156,250,62,119,131,192,118,183,186,168,213,150,251,163,255,125,15,47,7,197,239,14,126,98,7,143,140,168,198,112,45,104,55,8,137,216,46,247,52,170,51,114,149,247,125,74,212,211,31,212,94,251,166,92,75,201,182,176,242,137,170,122,80,117,36,151,54,177,193,13,99,149,114,158,153,91,128,242,41,217,93,129,125,18,161,212,34,245,3,30,191,5,238,180,39,23,173,250,57,107,66,243,172,209,110,132,103,231,45,104,156,181,155,248,171,221,168,71,237,122,171,121,193,216,249,137,167,118,148,16,121,168,87,31,198,182,125,93,147,136,139,181,224,14,19,21,131,173,213,200,100,216,29,146,112,78,229,12,200,156,106,166,66,6,164,159,114,70,84,68,38,227,219,36,38,74,18,13,148,145,72,171,152,48,12,239,137,26,56,62,42,234,122,183,155,35,219,46,71,94,49,214,210,107,57,84,113,66,53,55,74,78,178,196,37,249,205,35,58,27,175,131,222,115,74,197,234,52,151,164,6,186,220,36,130,102,15,84,164,78,19,81,97,128,188,125,23,16,217,222,223,68,227,36,176,54,154,79,99,57,162,118,238,162,198,33,61,42,189,48,9,13,161,252,38,208,124,54,95,83,188,79,205,227,13,202,156,149,188,239,159,191,200,107,126,165,182,86,252,157,26,224,37,90,173,16,188,250,223,22,252,240,91,144,251,116,244,34,180,234,101,105,255,249,48,53,86,197,29,161,12,176,222,18,47,157,51,146,67,250,154,51,127,183,253,71,191,33,26,108,170,37,177,58,133,203,127,95,82,245,103,32,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateLookupGridPageClosedEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("2814422c-12dd-49d0-aa7b-0fd8795728a2"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("113a32ea-67e0-4571-8fbe-8a0eb10ccf76"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"BoundaryEvent",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"LookupGridPageClosedEvent",
				Position = new Point(259, 14),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRunProcessScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6770ea02-22ed-4c25-bdac-b0955709bb20"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("113a32ea-67e0-4571-8fbe-8a0eb10ccf76"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"RunProcessScript",
				Position = new Point(294, 84),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,219,142,218,48,16,125,206,74,251,15,46,79,142,138,252,3,45,149,90,96,87,81,5,139,20,182,251,108,146,97,113,55,177,83,219,225,162,106,255,189,99,199,1,146,108,111,72,8,95,230,204,57,115,102,204,158,107,98,160,128,204,66,254,141,23,53,24,50,33,116,38,50,43,148,228,250,244,209,88,45,228,243,152,168,205,119,12,250,20,63,84,32,83,15,152,113,203,31,13,232,53,55,47,236,30,108,218,73,67,221,213,84,73,9,62,85,252,225,246,166,73,69,52,100,74,231,73,142,68,205,9,155,151,149,61,93,2,42,173,50,48,102,202,43,135,28,134,109,149,6,158,237,8,253,10,39,79,182,226,66,247,133,18,97,161,36,66,246,170,139,201,207,219,155,232,74,130,11,99,152,8,243,70,123,52,195,237,125,232,95,124,240,56,31,232,144,65,210,159,21,53,74,80,74,18,164,157,185,26,85,209,176,240,107,68,195,198,214,42,245,121,169,179,52,138,54,72,252,226,86,175,248,109,55,184,22,91,66,223,5,227,18,179,172,139,226,65,123,3,105,91,124,220,176,186,162,3,113,154,237,160,228,222,22,9,7,114,95,139,252,18,221,26,84,114,201,159,65,99,76,183,195,108,117,157,100,209,68,33,136,224,103,192,17,174,189,17,19,210,230,116,83,228,142,12,141,217,157,144,57,245,61,156,52,189,100,78,215,164,47,53,14,12,29,242,110,16,153,252,150,155,37,210,88,46,51,223,67,231,88,15,136,62,160,113,161,59,11,188,64,224,19,10,83,135,243,224,135,211,53,28,237,101,82,239,148,46,185,165,11,149,215,5,4,105,45,213,82,217,249,81,24,27,128,227,222,184,55,93,125,155,107,133,71,72,226,126,124,148,91,176,245,78,171,195,124,15,210,210,81,186,83,135,0,29,53,137,52,216,90,75,98,117,51,167,175,109,19,175,149,245,13,98,83,28,35,219,222,190,241,144,135,86,161,52,205,75,176,160,13,243,213,153,47,167,37,30,208,145,211,216,150,158,228,163,48,116,81,120,234,226,124,227,158,27,93,131,214,220,168,173,101,143,9,123,130,13,210,90,173,10,227,43,143,125,185,159,77,229,55,236,146,180,255,36,218,191,145,14,179,123,234,151,205,123,111,162,79,235,56,184,144,56,125,143,82,252,168,33,153,249,36,29,135,88,10,22,151,21,104,219,188,239,65,93,227,30,93,220,186,253,159,86,157,13,250,23,126,100,245,94,180,92,93,204,252,8,89,109,129,250,74,135,77,68,192,245,112,252,2,51,75,245,43,9,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenSelectDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8815c5ff-679e-4518-969e-22358826c8d4"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("113a32ea-67e0-4571-8fbe-8a0eb10ccf76"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"OpenSelectDataUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(182, 84),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenSelectDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b09c11e2-4be3-4f16-99a2-ddfa497fcc7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SubProcess2",
				Position = new Point(476, 1415),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 116),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateShowMessageEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("82264521-65aa-43fd-bc03-f3b418a82775"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b09c11e2-4be3-4f16-99a2-ddfa497fcc7e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ShowMessage",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ShowMessageEvent",
				Position = new Point(15, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateMessageWindowUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1b4f366e-38d1-4a3f-9da5-283ee54e518d"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b09c11e2-4be3-4f16-99a2-ddfa497fcc7e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MessageWindowUserTask",
				Position = new Point(106, 30),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeMessageWindowUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c54b2080-d64f-4dd9-9e29-77fab6d82904"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SubProcess3",
				Position = new Point(36, 1599),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(216, 102),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSettingsChangedEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b65bf503-18bd-448b-81e5-67fdb52482c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c54b2080-d64f-4dd9-9e29-77fab6d82904"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SettingsChanged",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SettingsChangedEvent",
				Position = new Point(22, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSettingsChangedScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("131613ba-034f-430b-8049-a4bd3c82e1f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c54b2080-d64f-4dd9-9e29-77fab6d82904"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SettingsChangedScript",
				Position = new Point(113, 16),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,79,77,11,130,64,16,189,247,43,22,47,42,196,218,93,58,132,116,16,10,2,141,14,209,97,210,73,5,155,141,217,209,232,223,183,154,68,81,167,121,195,251,226,69,209,14,42,212,171,178,204,10,110,110,18,120,208,34,75,224,251,115,229,103,40,210,80,101,147,26,168,194,210,15,189,48,158,245,192,170,48,36,72,50,88,19,7,161,33,100,181,84,99,84,242,226,134,195,166,221,192,195,116,162,83,193,171,61,46,78,10,172,202,145,25,172,185,136,222,167,250,128,231,73,105,245,27,124,229,254,52,186,162,127,253,163,43,37,43,64,5,198,179,15,137,206,107,54,247,117,239,222,192,203,59,114,147,182,166,196,105,213,176,137,81,58,38,37,220,97,252,4,68,203,21,10,18,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("60a03026-2058-4b56-8c14-465137320417"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(57, 1721),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(485, 391),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMessagePanelLinkClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c7921c78-2805-483d-8ab7-3dcbae70fffc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a03026-2058-4b56-8c14-465137320417"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MessagePanelLinkClick",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MessagePanelLinkClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 127),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLinkClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7185ed34-513e-4ad8-9b4f-214adc322c7a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a03026-2058-4b56-8c14-465137320417"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"LinkClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 113),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,189,10,194,64,12,128,247,62,69,232,212,130,244,5,78,5,81,7,65,65,176,155,56,156,119,225,76,91,18,200,165,85,223,94,17,113,112,255,126,38,175,16,132,13,31,182,157,144,109,165,41,195,2,170,13,5,35,97,175,207,121,54,37,78,51,144,107,135,193,150,245,23,111,218,155,202,253,39,185,226,128,57,251,132,71,207,56,172,7,10,61,198,61,113,191,139,239,222,255,226,92,82,44,47,77,43,167,79,188,170,93,161,104,163,50,152,142,232,94,72,170,81,194,150,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowDefinedPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b4bc1c4a-f7d2-43fb-af7b-023b1677fb74"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a03026-2058-4b56-8c14-465137320417"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ShowDefinedPageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(399, 216),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowDefinedPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateShowRemindingsUserTaskInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e14fa834-871c-4935-a8ad-ddf57bca0df5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a03026-2058-4b56-8c14-465137320417"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ShowRemindingsUserTaskInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(210, 216),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,111,107,194,48,16,198,95,175,159,34,244,85,101,54,56,180,155,210,109,48,117,72,97,50,153,150,189,78,219,83,67,109,210,37,81,145,225,119,223,53,21,255,76,182,55,109,122,119,207,115,191,187,116,195,20,41,217,2,166,233,18,10,54,102,2,207,138,60,145,88,131,26,72,33,32,53,92,10,58,2,115,81,225,185,147,223,34,183,17,58,31,80,112,145,113,177,208,85,58,142,50,116,18,176,37,163,53,207,60,183,151,117,219,105,18,36,126,192,88,219,239,116,186,29,191,151,5,61,255,46,13,224,33,105,117,239,89,43,168,92,54,200,164,46,156,234,70,104,118,133,90,145,69,66,27,38,82,232,239,176,163,119,197,208,32,76,147,147,75,237,207,15,26,139,232,121,51,80,138,105,57,55,52,142,232,39,36,56,186,81,114,165,105,165,107,84,15,250,162,75,251,65,163,163,148,206,228,212,40,108,229,33,181,182,39,146,195,14,29,207,236,111,109,111,107,84,185,50,46,144,58,22,252,107,13,209,48,116,166,75,185,29,194,28,163,153,229,197,189,207,152,206,233,123,9,88,24,157,99,162,245,223,245,167,133,95,45,224,127,209,132,41,86,128,1,165,15,151,53,228,246,206,153,218,61,214,51,53,73,253,126,38,223,206,205,183,91,224,8,86,168,100,10,90,99,3,183,121,152,177,142,28,55,132,169,189,179,15,29,155,236,51,13,99,204,218,150,2,86,20,57,229,6,60,183,56,11,30,217,35,49,151,213,191,112,174,24,172,120,154,67,246,198,69,110,7,173,169,232,107,81,26,92,140,2,179,86,130,24,181,134,240,7,149,40,14,207,214,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e6f68b51-1331-4be3-b775-39c7322638f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a03026-2058-4b56-8c14-465137320417"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,221,110,155,48,20,190,78,164,188,131,149,43,208,42,191,192,150,73,105,146,73,72,77,133,150,100,189,168,118,225,226,211,196,43,216,236,248,144,31,77,125,247,217,128,25,100,189,104,111,16,216,231,251,229,172,193,90,177,135,84,104,200,23,185,202,94,64,222,41,253,146,72,54,99,150,80,233,61,95,21,37,93,62,79,198,71,129,44,51,154,224,76,171,35,104,154,227,222,186,169,104,169,50,82,70,11,188,124,105,16,55,204,60,253,130,140,190,198,237,56,223,30,208,156,58,80,203,149,7,157,107,210,199,169,146,211,159,124,107,54,53,93,20,59,128,122,102,81,0,204,216,230,96,78,119,203,121,186,110,220,39,178,55,28,179,63,147,241,40,117,199,252,86,88,88,247,2,242,239,80,152,35,68,83,143,221,89,64,251,0,8,115,41,65,78,189,200,200,219,42,132,118,243,232,124,213,28,126,108,97,180,134,58,36,79,209,100,142,113,147,29,160,16,235,102,52,32,203,254,157,195,179,104,48,29,183,204,252,155,210,50,209,150,132,206,224,246,114,47,10,231,200,39,186,135,83,103,172,69,54,182,124,248,43,242,25,211,85,158,55,89,71,8,84,161,102,132,21,248,241,215,144,196,200,42,135,150,201,249,25,80,240,5,130,160,112,27,13,99,190,173,202,83,129,206,44,57,123,124,117,86,150,108,112,239,155,10,137,18,215,101,235,171,89,7,166,186,27,191,46,209,22,16,133,53,207,196,119,9,127,128,39,39,75,104,114,203,61,75,92,151,62,183,101,253,193,255,145,14,215,161,227,46,7,202,142,191,39,246,169,249,131,254,225,53,132,210,174,252,157,86,191,43,72,150,53,201,160,33,190,1,114,175,37,32,93,126,136,188,250,63,215,205,149,92,28,218,254,96,85,93,65,239,209,119,170,117,23,65,107,136,89,157,33,171,8,162,55,118,213,35,94,217,100,220,223,142,191,81,16,94,100,239,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateMailboxSettingsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4186fb24-821e-43f0-91f7-702ed83c1727"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60a03026-2058-4b56-8c14-465137320417"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MailboxSettingsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(301, 102),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,208,207,110,194,48,12,6,240,59,79,17,113,42,28,194,3,84,187,140,113,168,196,159,106,133,7,240,154,111,16,181,181,43,39,192,224,233,73,166,29,118,232,205,177,227,239,39,121,181,188,145,154,94,200,85,3,141,155,129,124,31,106,149,22,33,152,55,195,184,155,237,212,172,56,5,232,90,152,209,70,47,188,40,103,147,17,182,86,140,164,216,165,222,151,252,52,15,110,47,42,236,159,148,183,26,196,232,249,28,106,58,227,48,130,83,93,52,23,185,127,224,219,51,92,110,103,230,72,161,75,64,126,218,119,10,216,165,224,84,215,196,232,237,39,6,185,161,152,214,247,128,75,200,180,254,23,115,170,156,61,74,19,53,235,243,253,124,145,168,255,194,186,247,109,7,183,245,220,85,46,157,36,252,254,180,155,97,140,143,114,185,154,41,226,85,217,68,189,162,124,1,24,253,191,55,77,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8651190b-f06d-428a-8888-00272b1042a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"SubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 1417),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(204, 114),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMoveToModuleStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("076bc514-7c3e-4f54-bdb5-5ebfd72b1e06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8651190b-f06d-428a-8888-00272b1042a3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MoveToModule",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MoveToModule",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMoveToModuleScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("63356494-85eb-4129-a50e-dd6835075a02"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8651190b-f06d-428a-8888-00272b1042a3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MoveToModuleScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,75,111,130,64,20,133,215,229,87,76,220,8,137,153,180,107,106,19,251,54,169,137,169,24,23,198,197,0,87,58,237,192,152,59,3,214,180,254,247,94,20,90,124,180,118,7,195,153,239,112,207,185,133,64,150,234,2,2,61,20,40,82,176,128,134,117,89,164,51,11,239,150,7,47,168,151,119,5,100,182,135,137,97,194,176,91,25,89,169,51,129,171,75,99,81,102,73,135,233,240,21,34,123,229,59,114,206,220,67,88,151,101,185,82,30,251,112,206,142,56,13,246,143,78,120,172,25,40,3,37,236,224,102,247,96,18,146,59,91,194,116,198,100,76,99,200,185,220,74,135,34,1,62,200,149,149,79,80,128,10,68,104,120,143,108,9,32,66,30,136,132,143,22,74,90,183,253,217,246,124,167,160,152,150,26,223,204,66,68,208,143,233,126,131,54,61,159,237,41,8,65,146,123,153,197,244,244,8,34,6,188,94,17,211,61,230,250,45,49,157,166,71,229,154,234,56,87,112,156,214,244,219,193,236,231,48,109,245,45,164,23,173,25,15,244,104,147,135,235,121,117,95,91,254,78,75,191,91,158,26,224,159,206,107,231,207,252,55,85,150,63,225,87,245,49,132,88,34,109,192,24,21,125,124,0,251,252,115,224,86,81,245,204,162,164,214,229,214,175,180,80,1,32,10,163,231,150,143,251,124,2,225,13,173,55,106,101,120,41,240,157,74,201,107,166,219,112,35,54,130,205,49,99,22,115,240,191,0,58,37,14,115,48,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateHelpCalledEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaHelpCalledEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("14ab1d01-2b8d-41b9-9058-b3896a0293a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"HelpCalledEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(309, 1567),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(184, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaHelpCalledEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateHelpCalledStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f9de3122-2104-4e62-8c39-0fc4cdf8b23c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("14ab1d01-2b8d-41b9-9058-b3896a0293a5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"HelpCalled",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"HelpCalledStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptHelpCalledScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f4c06641-4593-4e6c-a444-ad29d48f9890"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("14ab1d01-2b8d-41b9-9058-b3896a0293a5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptHelpCalled",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,65,75,196,64,12,133,239,130,255,33,244,212,101,97,240,108,17,149,69,112,96,89,133,85,60,136,135,177,141,219,66,59,83,146,116,117,255,189,153,86,220,182,244,52,153,73,222,123,95,230,232,8,242,224,5,189,60,187,3,110,180,116,149,71,130,27,136,119,179,25,122,241,160,80,111,221,41,116,98,172,96,195,239,87,31,224,24,94,144,200,113,248,18,243,106,205,27,126,254,77,178,249,47,38,190,217,229,197,113,26,169,73,75,0,189,204,122,22,231,115,84,21,11,85,254,0,37,214,109,207,244,35,182,80,233,240,108,44,239,186,186,126,162,135,166,149,83,186,232,247,56,86,174,224,118,156,106,246,121,137,141,155,206,192,245,50,216,100,232,76,198,57,85,173,40,210,93,18,55,156,131,38,176,134,116,145,182,156,131,65,226,181,157,104,254,172,181,86,111,13,60,127,249,8,197,112,25,190,227,125,230,151,69,69,191,227,125,81,236,123,198,116,64,93,105,131,80,58,242,32,212,97,246,11,165,159,232,189,11,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("35f83dfc-214c-42e5-8471-f8a68bbd9eaf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(64, 1385),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMessagePanelMessageClosedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0d6e9f24-b409-438c-9cf5-20245ea7b961"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35f83dfc-214c-42e5-8471-f8a68bbd9eaf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MessagePanelMessageClosed",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"MessagePanelMessageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(7, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptMessagePanelMessageClosedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7e2b288d-6948-44e7-9faa-449064be0d12"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35f83dfc-214c-42e5-8471-f8a68bbd9eaf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptMessagePanelMessageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,140,65,10,194,48,20,68,215,246,20,33,171,116,147,11,20,23,213,106,55,10,193,34,174,67,50,168,208,254,200,79,82,237,237,109,116,55,51,188,121,198,222,161,119,54,226,140,24,215,108,44,97,212,23,76,97,134,146,167,174,53,215,8,142,55,48,90,239,225,101,221,84,179,101,225,49,34,65,108,5,225,45,186,95,81,133,220,7,34,184,244,12,84,235,106,115,228,48,41,57,44,177,136,134,133,220,163,231,144,95,69,242,23,232,195,7,46,175,223,117,97,164,204,36,18,103,52,95,245,94,116,92,151,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("927acb97-15d2-4823-802a-af0a575ef6d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 2143),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDoShowLDAPMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("452cc4ee-729d-4e71-9d52-4221fe0cf186"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("927acb97-15d2-4823-802a-af0a575ef6d1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DoShowLDAPMessage",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"DoShowLDAPMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDoShowLDAPMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6af27a8d-b97b-4599-85ad-128853c2ea30"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("927acb97-15d2-4823-802a-af0a575ef6d1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptDoShowLDAPMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,206,200,47,247,113,113,12,240,77,45,46,78,76,79,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,165,47,215,63,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cbc50e63-4006-4c5b-b729-3af3c6e5b46d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 2143),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(190, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateShowStartProcessStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4f0614af-91f0-4f0b-9f0a-864cd28339cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cbc50e63-4006-4c5b-b729-3af3c6e5b46d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ShowStartProcess",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ShowStartProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptShowStartProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e747b89d-d683-4c6e-a017-7650e52823b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cbc50e63-4006-4c5b-b729-3af3c6e5b46d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptShowStartProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,74,44,78,245,77,45,46,6,178,3,18,243,82,115,244,28,83,82,160,124,13,37,31,23,199,128,128,162,252,100,32,63,184,36,177,168,36,53,69,73,71,33,184,164,40,51,47,93,207,53,183,160,164,82,71,1,38,93,153,151,156,17,158,89,146,1,210,226,147,88,10,228,165,166,248,4,107,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,23,174,78,16,114,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("524e66a4-a053-4ea8-898e-cb9361aba8fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(428, 2147),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateErrorCheckRequiredLDAPSettingsStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ca546d89-405a-447c-a00c-5af310cdd73e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("524e66a4-a053-4ea8-898e-cb9361aba8fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ErrorCheckRequiredLDAPSettings",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ErrorCheckRequiredLDAPSettings",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptErrorCheckRequiredLDAPSettingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fe930371-0739-4b82-ad7b-784a41697630"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("524e66a4-a053-4ea8-898e-cb9361aba8fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptErrorCheckRequiredLDAPSettings",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,139,65,10,131,48,20,5,247,61,69,112,165,32,185,128,43,181,238,44,132,230,4,193,60,84,170,177,125,249,89,120,123,83,112,55,3,51,198,205,208,157,139,120,33,198,204,198,5,108,186,245,254,246,178,24,159,173,49,60,166,236,86,28,5,190,168,149,21,174,97,214,195,254,149,179,86,3,121,176,95,48,125,222,248,165,149,240,255,201,66,36,71,113,180,85,243,32,36,49,40,97,66,115,1,99,72,154,7,116,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("86fa20ce-4729-4217-abb1-08daaffb8b94"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"InitSubProcess",
				Position = new Point(56, 2533),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("753bba86-fa6f-4900-a025-e934caca069b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("86fa20ce-4729-4217-abb1-08daaffb8b94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"Init",
				Position = new Point(29, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8859912c-41a8-4eba-9b5e-db0a3c1d1ac5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("86fa20ce-4729-4217-abb1-08daaffb8b94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"InitScriptTask",
				Position = new Point(127, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,88,219,110,219,54,24,190,118,129,190,3,163,139,86,70,19,193,109,26,4,152,219,14,57,182,238,146,54,155,237,229,194,8,6,70,250,237,176,161,41,143,164,146,120,107,128,61,211,30,105,79,178,159,7,201,148,227,67,15,216,205,124,97,90,226,127,62,240,255,232,203,60,231,132,169,190,224,57,205,200,107,50,164,92,65,251,241,163,27,42,201,158,154,156,209,17,224,91,179,36,229,35,85,164,7,82,82,149,15,117,210,239,36,231,112,121,144,11,45,115,174,18,67,224,185,135,185,28,31,82,77,231,216,147,95,224,247,2,148,78,142,113,31,73,217,144,196,37,105,114,144,23,66,147,55,100,187,73,254,124,252,168,17,218,229,73,6,219,23,137,209,70,153,80,113,116,206,68,150,223,58,162,168,137,210,238,157,238,52,231,197,88,124,160,99,80,200,43,224,150,28,178,84,179,92,80,57,125,165,180,100,98,180,73,220,250,38,54,124,251,5,227,217,121,46,175,213,132,166,160,98,81,112,190,233,236,62,45,184,102,39,112,3,188,71,47,85,130,95,239,128,102,32,85,211,59,74,81,242,13,224,251,142,49,212,73,77,142,198,19,61,69,130,247,31,47,63,65,170,137,134,241,196,71,195,200,198,29,71,88,109,252,4,83,220,139,202,199,200,135,166,140,218,65,161,116,94,6,201,185,143,28,113,192,221,116,49,11,20,61,228,29,4,244,23,38,145,222,188,182,9,54,106,43,183,7,209,41,106,216,155,57,22,93,144,13,103,185,211,210,168,59,189,146,209,168,249,149,242,2,154,137,93,146,94,222,181,190,219,200,55,48,101,247,4,176,234,230,205,55,105,243,246,57,202,48,30,101,21,253,92,128,156,58,113,131,232,203,13,254,114,49,70,113,99,149,123,222,80,235,90,28,104,169,156,115,85,98,178,6,66,251,134,50,44,75,155,168,214,77,62,219,32,109,12,2,41,200,101,60,121,91,176,44,249,0,183,102,181,36,38,74,190,8,59,234,3,6,224,163,180,197,88,179,205,247,23,146,30,51,169,172,188,110,122,5,99,218,201,122,249,137,105,185,13,47,218,242,250,24,134,218,103,44,206,142,37,114,108,248,102,175,137,114,203,107,178,88,214,41,21,248,91,38,111,65,119,132,210,84,164,176,63,69,5,241,82,213,54,204,53,203,76,219,155,70,180,20,246,169,50,98,190,153,171,76,90,7,68,86,53,247,254,180,71,71,241,234,254,223,92,230,115,80,224,205,175,43,159,149,54,206,74,170,230,238,59,96,163,43,141,114,186,83,133,138,76,37,205,23,84,95,48,157,156,129,76,145,7,89,226,231,173,150,21,21,138,57,103,153,190,250,38,41,238,140,113,162,60,241,9,157,230,133,78,48,133,32,117,7,229,197,173,205,48,227,246,168,158,53,189,169,195,141,163,59,100,80,123,159,232,157,111,74,95,116,125,148,129,172,2,236,1,158,116,65,41,92,151,135,51,40,243,50,92,107,194,250,144,105,85,161,155,116,217,102,91,41,21,235,100,148,116,39,156,233,248,233,231,167,205,193,139,139,42,86,255,105,39,172,111,132,255,69,237,212,135,35,150,200,153,204,135,140,3,121,242,100,73,60,109,242,130,236,69,173,97,186,13,219,59,207,183,118,232,11,216,122,185,211,218,217,194,182,222,217,218,165,176,155,182,118,95,182,134,47,118,35,127,80,46,80,52,131,74,247,213,44,87,169,100,19,221,195,110,231,84,35,73,52,44,132,173,218,24,197,144,12,46,139,17,166,180,77,110,45,108,73,120,62,66,79,81,146,150,5,180,137,153,18,19,42,209,116,7,107,112,195,19,186,183,228,243,103,255,162,93,163,67,57,41,181,189,33,1,21,167,16,71,228,25,26,61,155,47,7,249,120,140,219,239,85,249,213,5,201,40,103,127,64,28,164,172,11,105,33,153,158,90,100,166,246,10,125,133,42,152,23,125,146,143,152,232,75,156,166,207,72,212,36,247,56,106,12,68,177,81,57,186,99,122,191,208,26,201,76,251,30,221,32,31,78,49,206,210,235,228,163,192,21,159,237,75,91,140,97,136,218,203,242,136,241,106,160,11,39,76,233,87,245,170,242,85,242,134,112,220,243,221,131,207,125,205,176,215,24,168,196,156,227,101,221,197,33,242,220,36,209,33,224,44,229,10,251,243,140,10,224,81,5,43,140,176,10,125,182,252,201,131,152,19,104,122,69,226,245,147,186,148,72,116,249,131,9,107,161,23,213,240,21,130,192,148,211,137,130,236,152,1,207,236,161,95,226,227,16,23,15,74,49,137,139,94,231,208,132,253,183,131,146,219,195,146,26,34,234,168,179,92,233,125,154,94,151,58,27,75,161,192,2,51,154,21,87,195,20,34,26,80,105,51,21,90,78,176,181,134,205,224,94,219,139,91,236,115,92,211,224,177,26,249,177,166,248,1,94,36,63,212,240,117,211,171,8,70,137,249,124,133,177,181,233,187,40,42,165,6,187,220,135,169,172,70,198,55,165,178,26,20,223,155,202,5,102,204,165,114,54,219,68,6,119,235,147,25,152,246,48,153,139,189,142,231,116,204,210,89,223,88,148,208,168,21,125,91,30,67,59,23,131,240,149,121,188,175,224,249,227,71,185,187,164,77,100,158,21,169,246,115,211,223,211,44,56,9,207,82,105,39,214,144,141,10,233,206,70,60,160,186,160,53,58,132,7,129,156,226,196,118,118,212,145,11,30,63,103,51,249,209,38,49,103,127,160,209,103,109,206,136,232,114,50,254,231,175,191,115,193,241,14,16,185,105,83,150,73,143,105,59,136,2,142,250,221,202,27,255,213,119,200,117,23,199,89,9,173,155,197,27,15,75,218,188,94,141,197,107,23,55,91,193,114,84,222,227,189,108,52,195,78,148,61,220,113,151,195,74,17,34,13,55,219,60,105,108,184,61,104,56,69,240,136,68,182,152,236,124,130,236,132,137,235,69,23,119,247,55,66,120,103,91,129,85,48,28,106,208,186,88,249,215,200,226,91,157,47,176,116,14,179,148,144,207,66,22,211,73,56,251,151,209,36,232,104,138,142,149,180,46,110,18,116,33,133,131,22,193,255,34,149,136,138,105,173,92,100,239,2,199,34,134,236,20,11,141,195,119,192,224,231,22,6,63,52,3,193,135,198,159,19,132,124,83,215,60,17,118,85,169,14,155,101,222,130,47,22,99,174,8,1,69,223,74,115,190,122,158,210,95,15,161,195,192,253,11,89,43,35,93,30,19,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5e6e5888-d8a7-48db-acc4-4d29ed2ce017"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"PageLoadCompleteSubProcess",
				Position = new Point(50, 2718),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(272, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1a88a3db-d2bd-485f-8849-fdec99dff48a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5e6e5888-d8a7-48db-acc4-4d29ed2ce017"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"PageLoadComplete",
				Position = new Point(35, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2444c3b3-15a8-4d2e-b538-a14b8c25ce9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5e6e5888-d8a7-48db-acc4-4d29ed2ce017"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"PageLoadCompleteScriptTask",
				Position = new Point(154, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,26,219,114,219,198,245,153,158,241,63,192,124,48,193,152,130,72,138,186,208,138,221,234,234,168,21,29,85,148,236,206,36,153,204,18,88,146,136,65,128,217,5,36,49,142,102,28,123,218,62,36,157,190,246,51,146,180,110,156,180,113,126,129,252,163,158,179,187,184,16,0,37,82,110,167,197,36,50,177,123,238,231,236,217,115,118,177,188,172,141,255,58,249,106,252,203,248,237,248,159,147,111,198,63,76,94,141,127,156,188,28,191,214,38,127,134,127,222,78,94,106,48,247,237,228,197,248,219,241,191,198,175,39,47,39,47,180,241,223,1,244,47,26,66,77,254,160,1,226,47,147,63,142,223,140,127,172,104,183,111,45,3,189,159,16,13,254,127,49,249,26,232,0,52,144,30,255,99,252,243,228,107,109,252,221,228,107,160,241,141,24,157,124,5,63,95,1,121,156,17,28,126,16,127,191,67,252,201,159,128,228,79,147,87,138,230,247,218,248,231,241,235,241,15,48,253,253,248,13,8,252,6,196,17,20,198,111,52,37,166,64,6,192,215,227,191,141,223,106,147,87,64,2,4,6,188,183,227,31,53,129,250,139,68,189,127,251,214,1,223,165,103,212,241,134,148,181,60,139,106,15,180,246,136,251,116,96,236,218,164,231,122,220,183,77,110,236,210,78,208,235,81,102,28,240,45,223,39,102,159,90,155,183,111,221,190,117,70,152,70,93,223,246,71,109,24,27,144,22,113,9,128,1,145,83,78,217,142,231,186,212,244,109,207,53,246,178,64,155,18,221,30,192,75,109,109,199,115,130,129,123,122,96,1,110,14,69,227,17,245,15,92,238,19,215,164,219,163,199,100,64,245,34,200,9,18,7,14,45,150,13,137,206,17,44,156,62,144,132,97,18,168,42,102,92,208,188,154,11,232,158,199,33,38,66,249,231,128,238,210,115,45,169,213,239,2,202,70,122,14,209,138,134,116,218,212,247,109,183,199,159,16,39,0,114,64,10,200,24,71,12,212,103,35,129,43,85,64,11,59,231,4,17,28,176,29,48,242,89,64,21,248,190,237,248,148,113,99,203,178,116,124,223,97,148,248,84,142,62,181,253,254,17,97,32,55,130,232,114,112,199,27,12,9,179,185,231,158,140,134,212,216,251,60,32,206,180,60,96,57,139,22,97,236,3,74,44,202,14,189,158,39,12,87,44,151,149,186,14,12,41,104,161,175,77,57,90,15,216,131,181,164,5,64,116,71,58,90,63,2,92,99,218,249,72,200,238,106,122,14,33,224,30,184,190,246,80,171,150,181,231,183,111,21,30,5,182,165,241,164,169,132,171,114,48,63,170,126,18,90,79,26,78,64,3,167,130,144,64,232,176,237,93,212,228,47,229,47,144,201,103,158,35,135,144,95,161,237,5,204,196,233,228,148,28,52,34,221,128,122,69,0,39,163,7,244,63,246,60,95,142,97,116,8,16,137,147,21,12,48,82,106,37,192,37,141,169,21,48,77,61,39,186,183,109,23,56,168,104,66,246,64,238,18,212,191,188,125,75,24,160,77,9,51,251,123,150,237,207,180,128,46,109,190,136,9,146,22,136,214,18,78,92,161,183,12,100,106,201,149,148,4,207,234,157,78,6,8,11,193,164,232,10,201,228,28,192,118,137,195,41,40,188,41,115,216,192,219,14,108,7,137,156,80,198,8,247,186,62,216,205,237,218,189,128,17,145,131,96,49,12,60,247,212,183,29,25,123,9,44,61,27,177,39,193,208,161,239,115,159,129,207,42,218,244,191,15,181,129,84,198,237,122,192,16,220,210,138,222,183,71,32,183,158,86,26,41,78,143,237,200,100,27,19,50,48,243,212,50,112,31,80,103,136,158,161,23,190,48,81,10,161,158,37,76,134,168,67,22,116,69,45,104,19,169,185,254,145,140,10,17,45,59,114,72,69,192,33,25,121,129,47,112,112,157,105,132,39,108,122,122,96,60,165,29,5,201,141,232,199,145,240,141,235,19,219,21,185,29,87,124,130,147,152,15,51,184,118,7,162,49,112,28,25,128,179,252,245,196,182,168,135,234,199,46,131,36,16,51,199,169,35,134,27,23,206,37,153,85,180,43,108,88,209,178,206,134,85,3,78,220,178,6,182,107,131,139,129,255,25,61,182,123,125,159,235,56,141,105,212,129,188,26,38,205,237,192,247,61,183,69,221,64,216,72,192,28,184,32,34,113,236,47,168,226,132,76,37,160,152,63,166,64,220,66,108,148,80,134,59,174,72,76,121,122,113,109,117,119,127,99,175,186,179,180,177,181,91,91,106,108,52,26,75,91,205,181,234,82,125,109,189,190,183,210,88,173,238,239,238,137,93,67,216,114,155,112,218,162,156,195,239,35,226,82,199,56,180,221,103,114,91,64,146,248,38,77,41,236,139,175,130,93,70,4,227,196,107,139,128,214,203,184,210,226,200,73,18,111,247,189,115,36,113,2,58,129,165,194,109,1,24,181,136,237,240,180,38,141,90,179,91,237,84,215,151,234,13,186,186,212,160,141,181,165,78,167,97,46,213,55,58,205,154,89,93,95,169,215,200,13,53,209,82,207,41,115,20,235,83,102,203,157,231,152,126,30,80,14,81,202,112,159,123,98,211,115,49,76,248,240,226,87,7,214,131,85,186,218,109,146,38,93,34,100,221,90,106,84,225,79,147,214,232,82,205,172,55,204,149,110,179,179,218,36,119,183,76,116,255,9,233,0,194,84,84,127,186,106,146,170,69,58,230,134,185,209,108,208,26,105,118,58,171,43,107,64,134,214,204,6,237,214,63,173,174,174,86,215,86,204,230,70,109,163,74,171,181,26,233,118,204,106,181,182,186,106,85,27,43,245,170,249,233,198,74,117,117,163,214,172,55,55,242,1,238,18,17,147,15,206,64,242,192,133,237,221,130,236,62,229,165,180,17,34,239,38,28,114,53,198,220,110,190,81,180,21,226,120,67,113,58,222,69,123,228,154,125,230,185,246,23,98,93,135,139,40,63,6,11,179,162,144,250,143,147,2,22,10,55,18,81,237,121,49,143,15,135,212,61,220,221,58,194,156,192,15,97,241,31,182,43,201,53,35,204,2,243,138,250,148,188,5,101,167,124,17,182,62,35,23,123,103,144,145,184,144,102,199,177,205,103,70,219,238,185,196,193,45,28,104,23,147,240,17,76,113,49,138,123,23,144,175,226,194,79,232,12,10,160,218,243,36,109,133,135,40,133,162,109,97,37,136,127,23,64,197,174,193,56,38,231,162,96,92,126,15,243,126,98,103,149,246,62,166,61,48,45,101,56,44,92,163,171,172,107,119,147,192,218,151,95,106,7,124,207,237,57,54,239,31,122,38,166,83,17,51,122,121,154,206,78,159,248,83,116,100,78,26,36,172,21,37,59,101,66,172,88,132,223,140,125,143,13,136,175,183,174,0,174,92,149,43,139,219,113,113,204,34,176,157,62,53,159,29,64,230,103,103,4,211,146,110,187,126,57,185,181,49,154,218,223,146,85,56,236,62,162,94,74,21,34,224,141,227,124,14,197,140,4,39,246,128,178,182,201,236,33,118,13,191,46,198,155,61,228,20,17,203,165,162,118,47,221,152,237,4,140,65,68,225,168,240,173,132,189,7,248,165,205,41,163,74,10,185,22,198,10,35,132,134,66,109,216,226,61,9,13,5,219,16,87,127,8,208,13,92,193,85,51,81,149,8,127,239,2,156,202,113,105,106,90,54,93,33,213,64,100,250,216,154,61,81,7,180,193,18,182,73,33,215,235,37,245,155,47,43,37,68,99,65,153,48,42,87,147,165,138,86,2,67,231,65,148,208,156,105,206,176,180,196,154,51,152,220,85,244,156,61,40,245,128,160,247,241,79,78,218,77,61,220,132,202,229,190,230,247,109,62,7,112,96,130,110,252,190,22,90,80,103,148,15,61,151,67,164,122,34,149,113,97,189,197,158,107,217,166,31,116,197,197,192,217,37,62,1,119,132,34,24,225,143,223,183,14,55,255,219,34,96,122,185,163,100,40,231,21,5,11,62,140,250,1,115,115,156,127,205,115,57,253,122,35,83,50,232,240,192,142,74,27,195,242,204,96,0,107,113,207,161,248,15,38,67,53,181,184,120,194,76,72,255,127,107,163,27,153,197,82,225,5,210,27,88,72,163,33,162,23,213,169,44,18,103,11,11,65,33,191,234,37,153,92,121,224,160,143,74,144,18,81,174,242,162,1,62,255,179,176,152,193,16,36,162,241,254,160,75,105,243,50,89,234,185,188,62,227,116,161,118,11,24,36,40,76,130,116,48,244,71,251,238,245,88,132,245,68,8,223,215,158,207,193,99,136,37,4,36,181,82,180,73,61,64,59,71,111,89,2,151,106,187,143,54,146,140,13,2,177,189,137,204,206,147,177,159,46,15,192,167,168,25,214,2,176,3,216,64,197,99,184,173,60,105,29,233,9,11,138,117,148,196,187,106,61,165,215,201,229,12,184,155,61,211,170,216,74,1,16,89,143,118,104,136,206,20,20,84,83,232,59,5,108,203,55,125,96,135,113,28,129,79,55,58,143,233,121,162,238,64,115,202,78,214,224,176,125,202,218,121,202,210,134,155,65,48,252,168,78,78,216,115,126,54,123,46,233,56,212,186,142,141,56,59,196,99,63,229,172,235,192,239,222,213,230,161,184,248,102,250,110,207,204,152,154,223,96,242,87,219,31,57,84,47,141,168,227,120,231,80,213,20,226,39,201,230,82,163,14,167,87,196,242,13,249,118,160,152,186,130,235,140,56,56,21,157,238,222,0,114,206,60,81,16,196,224,201,32,152,193,116,94,86,185,113,157,97,149,31,214,153,200,203,138,152,14,188,124,37,32,238,230,116,201,108,69,242,3,225,166,174,159,147,207,12,199,23,164,215,225,191,76,166,214,114,186,145,221,109,104,254,128,173,145,41,211,185,62,79,227,82,134,118,152,154,129,79,219,208,59,18,166,142,111,31,66,107,129,29,141,134,86,224,120,145,164,186,52,61,175,15,169,8,193,102,53,118,72,7,201,20,163,27,37,108,184,226,123,47,209,185,131,244,234,96,82,158,208,235,197,118,18,172,88,198,35,213,169,33,20,44,249,142,109,188,4,208,243,26,188,242,230,123,203,120,29,40,207,188,2,23,184,97,127,160,124,147,56,39,200,59,117,144,103,163,91,174,21,35,162,54,210,86,74,161,76,183,92,124,94,189,52,96,117,148,194,107,12,223,243,28,19,169,67,87,21,117,37,16,191,207,63,118,177,167,49,192,1,14,138,215,162,126,223,179,244,210,73,159,121,231,66,42,64,120,254,156,71,34,193,254,31,182,193,208,214,187,61,106,149,46,97,159,255,216,189,188,4,192,42,252,44,86,164,89,91,80,221,216,135,120,91,121,66,58,66,55,160,118,176,91,142,140,167,221,155,41,118,159,58,195,255,164,200,226,72,25,224,111,36,237,242,242,181,242,102,228,20,165,7,72,234,120,166,60,62,96,116,232,16,19,150,222,255,223,41,103,167,107,210,38,60,245,245,245,122,163,177,82,237,116,59,29,171,185,190,81,95,89,51,73,103,163,22,158,114,114,121,74,143,185,165,235,57,22,101,165,50,154,17,157,81,14,205,56,35,255,36,205,41,224,226,5,195,213,18,145,11,116,139,15,147,55,29,225,235,85,119,26,8,128,215,42,35,222,2,139,224,91,27,194,199,81,44,241,100,67,81,137,142,155,197,5,174,220,23,62,42,206,194,43,126,18,175,50,117,53,115,45,173,16,78,224,226,46,19,33,78,93,161,40,170,67,243,236,58,130,0,34,104,69,40,214,245,40,150,66,17,37,165,7,65,227,197,231,141,234,0,126,215,22,30,37,108,20,93,153,121,157,207,192,185,15,69,53,93,72,163,137,99,202,162,184,241,2,71,71,183,7,161,118,229,107,144,234,73,36,80,233,58,248,21,128,7,53,4,84,43,171,65,26,49,186,70,142,51,128,94,148,120,225,247,0,178,15,249,208,141,86,57,46,114,248,95,166,48,161,116,59,232,96,40,118,40,64,37,58,136,29,199,227,84,210,148,39,216,29,72,75,88,27,60,165,142,233,13,96,235,98,148,226,209,180,142,19,229,249,78,9,79,83,232,197,240,210,253,78,154,176,12,24,121,71,220,247,206,167,230,240,126,237,137,205,109,40,185,116,113,189,170,212,12,11,134,194,20,52,158,76,252,150,98,111,81,156,230,141,230,19,188,51,231,192,249,4,238,101,47,137,19,167,236,72,45,174,89,102,147,72,46,239,248,30,8,12,245,129,199,125,136,4,232,142,133,99,47,149,116,143,41,181,50,22,8,15,154,195,229,97,187,93,145,152,193,202,79,97,23,246,206,163,3,214,71,120,4,41,48,147,19,82,220,66,42,35,205,160,82,86,226,92,230,125,74,35,150,224,226,223,153,36,226,51,67,205,216,193,47,119,178,31,231,180,193,50,240,175,152,53,240,59,18,113,244,142,175,232,128,147,118,234,26,29,193,226,43,217,167,30,123,198,135,176,17,137,241,71,204,11,134,200,60,35,178,186,183,167,153,155,255,212,167,56,82,82,176,157,156,77,124,132,35,73,226,177,121,146,248,41,36,71,81,119,206,230,57,196,76,188,24,199,163,8,69,210,159,105,77,204,46,97,97,117,46,124,107,200,36,38,106,170,244,231,49,42,239,243,196,72,158,44,11,124,88,35,115,178,32,58,59,21,99,154,148,137,24,226,144,130,216,122,140,6,33,158,149,74,46,2,4,138,109,151,249,104,42,146,21,191,45,178,18,31,125,188,47,249,73,170,149,140,249,13,180,87,57,220,80,248,187,17,207,198,83,76,94,173,225,103,50,71,149,138,247,66,94,137,236,114,15,198,195,124,165,79,41,11,27,44,178,50,196,145,73,25,123,153,2,244,112,58,207,157,23,211,56,159,156,158,245,97,67,20,88,48,12,13,135,241,228,28,34,78,124,124,112,234,218,254,187,80,138,214,202,190,40,167,98,169,239,40,23,27,170,204,227,144,52,117,48,76,57,204,119,225,60,110,153,48,94,153,114,124,34,81,133,93,2,101,242,99,7,75,93,6,252,134,139,68,162,70,149,123,120,37,21,145,8,5,18,156,65,103,68,153,236,160,85,19,147,40,223,166,11,226,233,69,245,64,15,107,236,105,9,20,169,125,219,113,228,151,79,210,12,242,126,80,142,3,135,248,187,13,61,170,27,219,51,218,174,162,104,9,134,4,155,76,195,148,205,230,1,172,60,166,90,166,240,91,150,83,60,181,196,142,49,49,0,111,197,210,166,72,27,242,76,80,126,196,247,111,85,64,103,106,99,42,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("790ebc80-b078-40fe-a09d-f1b3da2bf5e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"PageLoadEventSubProcess",
				Position = new Point(344, 2544),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageNonInterruptingEvent1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a18309ca-d658-47cb-a6d3-c29ef17f5f19"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("790ebc80-b078-40fe-a09d-f1b3da2bf5e9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"StartMessageNonInterruptingEvent1",
				Position = new Point(28, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c51b2c11-6171-4ca9-94d7-e25ae4d55857"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("790ebc80-b078-40fe-a09d-f1b3da2bf5e9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"PageLoadScriptTask",
				Position = new Point(147, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,193,106,2,81,12,69,215,35,248,15,89,206,80,201,162,91,113,97,69,138,139,82,161,182,93,148,46,226,188,219,97,116,204,131,188,60,21,74,255,189,163,139,41,66,3,129,75,22,231,220,172,165,1,191,192,189,213,38,61,100,247,168,60,223,201,121,121,132,122,226,39,104,94,57,14,139,174,173,247,124,61,210,221,140,2,58,52,226,40,227,118,135,218,41,65,3,108,66,27,152,73,138,95,206,175,43,126,199,118,17,213,45,118,137,135,48,176,231,214,36,66,69,223,69,49,30,21,71,49,170,47,14,132,65,25,3,104,70,224,229,217,77,214,98,114,128,195,210,199,253,39,191,73,151,49,45,254,166,71,60,235,237,27,55,213,75,197,137,30,115,27,202,127,44,85,53,29,143,126,250,53,120,54,37,183,30,254,11,70,254,115,54,25,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessGlobalSearchEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessGlobalSearch = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f723cb40-789e-4273-918f-6aa27263aed4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcessGlobalSearch",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(343, 2715),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(475, 245),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessGlobalSearch;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartGlobalSearchStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e8b65e17-88ed-4140-861c-a27b2fb0534b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f723cb40-789e-4273-918f-6aa27263aed4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GlobalSearch",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"StartGlobalSearch",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGlobalSearchScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ee6a1214-b865-4559-9fd3-54e8c2bf59e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f723cb40-789e-4273-918f-6aa27263aed4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptGlobalSearch",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,65,78,195,48,16,60,55,175,176,114,74,164,202,226,30,113,128,146,66,36,144,42,181,226,130,56,152,100,105,44,109,236,96,175,219,70,168,127,199,113,40,40,109,122,138,51,222,157,157,153,245,78,24,102,65,152,178,222,192,129,216,45,91,137,45,240,117,64,242,74,18,239,225,44,146,159,44,177,100,164,218,242,188,105,169,227,249,151,19,104,147,255,214,52,101,223,209,44,116,47,208,163,27,173,241,222,17,105,197,159,100,5,73,154,205,162,35,3,180,112,181,110,93,235,189,175,139,142,97,220,26,16,74,130,234,69,87,14,161,168,78,35,7,109,39,116,24,187,243,46,154,128,244,196,11,173,72,72,5,230,100,167,7,64,81,255,49,26,159,69,167,29,241,130,160,177,111,55,239,76,88,54,234,202,206,249,86,70,151,96,173,103,155,152,193,251,191,66,89,18,170,4,254,91,234,41,46,218,125,168,228,143,45,24,234,94,5,58,72,226,193,202,202,200,70,152,238,65,218,22,69,183,208,232,26,21,10,226,249,228,54,210,73,246,77,109,244,62,223,121,155,201,229,101,225,253,27,37,48,4,113,160,57,139,239,218,22,187,129,120,41,209,223,198,125,240,127,251,57,15,223,123,31,231,238,53,60,162,254,16,56,192,65,239,213,215,51,172,123,66,233,8,191,20,185,148,170,26,43,9,42,35,3,228,140,98,100,28,100,63,94,25,114,204,193,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartClearToolButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cdace97d-c0e6-4826-a0c7-c5dc073ca749"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f723cb40-789e-4273-918f-6aa27263aed4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ClearToolButtonClick",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"StartClearToolButtonClick",
				Position = new Point(36, 159),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptClearToolButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b361495a-2d74-46f4-b5f9-f6d0e76f6562"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f723cb40-789e-4273-918f-6aa27263aed4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptClearToolButtonClick",
				Position = new Point(148, 145),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,78,77,44,74,206,112,77,201,44,209,11,73,173,40,81,176,85,40,46,41,202,204,75,215,115,205,45,40,169,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,6,68,44,146,49,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartChangeSearchModuleStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6885e5fc-3f63-4e5e-a3f1-107daa1c2628"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f723cb40-789e-4273-918f-6aa27263aed4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSearchModule",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"StartChangeSearchModule",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 61),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChangeSearchModuleScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c9f983a6-98c9-4715-8cd2-f95fdfd3e241"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f723cb40-789e-4273-918f-6aa27263aed4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ScriptChangeSearchModule",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(365, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,193,106,195,48,12,134,207,45,244,29,76,78,9,148,192,46,187,116,27,108,93,41,57,116,20,210,238,50,118,80,19,45,245,72,108,144,237,118,97,236,221,39,199,217,154,178,50,223,44,253,250,100,233,247,1,72,160,178,210,182,121,177,199,6,86,160,160,66,18,183,98,107,144,230,90,41,44,172,212,42,93,252,21,205,38,227,3,151,203,134,47,115,93,187,70,109,179,146,43,47,240,210,37,218,76,25,11,170,192,135,246,9,26,140,163,188,53,43,93,186,26,163,36,13,229,198,203,126,210,153,199,94,93,115,146,169,125,43,211,49,255,239,98,177,185,212,225,4,193,15,75,176,6,130,198,48,166,208,202,114,36,221,236,73,31,23,7,166,222,83,101,4,24,241,40,187,201,129,218,27,99,73,170,106,42,244,238,157,215,113,199,160,28,129,138,125,160,119,207,81,120,20,75,39,203,120,128,127,137,44,84,209,107,186,209,121,7,136,147,132,75,215,252,212,52,212,47,74,105,211,110,208,158,192,11,183,164,235,46,20,39,226,115,50,30,229,218,81,225,243,195,92,8,246,166,132,229,77,189,118,176,159,223,93,249,68,16,174,137,189,162,94,255,12,181,243,216,243,73,188,152,157,239,149,217,201,90,86,190,65,109,240,68,11,205,134,198,159,255,132,81,56,147,241,23,15,77,104,29,41,97,201,225,236,27,227,154,99,253,116,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dcec21b9-a379-458d-be47-ef8ac4933082"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(56, 2993),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(378, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaScriptTask CreateWelcomeScreenClosedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2adf5ea1-6ddd-4a27-8781-f8c6e6672edf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dcec21b9-a379-458d-be47-ef8ac4933082"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"WelcomeScreenClosedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,193,110,218,64,16,61,219,95,177,229,100,71,214,38,173,212,147,219,74,36,164,42,173,82,69,49,20,85,136,195,98,15,176,237,122,151,206,174,33,9,242,191,119,118,77,8,105,233,161,23,208,60,207,123,51,243,102,118,35,144,9,92,90,246,158,149,70,59,184,119,124,180,66,179,189,222,128,118,125,255,65,88,54,144,165,147,70,11,124,120,103,29,74,189,204,152,153,255,128,210,125,200,227,185,49,138,105,216,0,22,43,179,37,153,196,35,169,215,156,246,14,120,111,150,199,114,193,146,3,144,178,93,28,117,98,172,54,85,163,96,88,21,14,137,95,128,34,101,168,110,246,40,31,153,34,228,37,105,30,197,145,87,25,218,1,212,230,178,145,170,34,157,136,208,104,67,115,148,198,252,148,64,18,26,182,236,147,115,235,171,0,36,19,80,165,169,161,40,17,64,15,132,19,95,224,33,205,137,228,181,110,197,18,120,223,174,195,255,29,252,106,192,58,222,17,237,244,20,115,198,94,81,133,70,169,48,66,20,45,12,130,40,87,44,241,45,72,7,53,147,154,253,191,42,255,38,20,101,237,69,163,110,150,61,56,245,178,71,62,204,104,70,135,13,28,91,227,89,45,253,180,222,141,151,236,35,127,79,49,163,35,198,245,253,90,34,248,107,160,190,96,36,107,224,95,205,150,247,171,234,59,8,180,201,219,139,80,233,143,241,236,218,104,11,79,243,249,236,164,211,243,201,45,3,101,33,140,117,126,182,223,184,45,81,174,29,85,233,237,46,90,110,193,221,162,89,72,5,222,140,100,247,186,205,118,111,218,52,239,29,74,21,33,255,70,104,10,208,235,119,64,210,201,241,143,6,107,65,81,0,179,206,252,187,70,147,104,9,214,94,54,206,25,205,175,148,164,147,30,14,50,246,217,82,88,0,74,161,228,227,63,206,227,175,44,239,90,154,166,249,217,57,53,53,2,68,97,205,194,239,84,47,228,178,65,225,31,8,69,117,109,244,216,73,37,157,119,98,130,180,185,227,217,198,22,144,40,26,194,131,202,94,158,159,127,106,207,202,227,33,159,192,156,146,29,26,101,185,79,72,9,172,50,118,170,225,44,172,53,248,29,183,49,130,107,80,7,40,255,13,214,162,110,188,226,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWelcomeScreenClosedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f59859f0-7215-44e4-a591-a96a5efa6039"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dcec21b9-a379-458d-be47-ef8ac4933082"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"WelcomeScreenClosed",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"WelcomeScreenClosedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ba9c1aa8-54e9-47b8-9b7b-5bc14ad6ca06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50acb56b-7064-4b3c-af98-320eae79d9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"EventSubProcess9",
				Position = new Point(57, 3195),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(311, 162),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateShowWelcomeScreenClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e00efa9c-3d00-4469-9aff-1bc42424bc34"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba9c1aa8-54e9-47b8-9b7b-5bc14ad6ca06"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ShowWelcomeScreenClick",
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ShowWelcomeScreenClickStartMessage",
				Position = new Point(42, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateShowWelcomeScreenClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b366f944-3e81-43be-afa0-3a4905580191"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba9c1aa8-54e9-47b8-9b7b-5bc14ad6ca06"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Name = @"ShowWelcomeScreenClickScriptTask",
				Position = new Point(182, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,74,45,78,45,9,79,205,73,206,207,77,13,78,46,74,77,205,11,78,45,41,201,204,75,47,214,208,180,230,42,46,41,2,50,21,138,147,139,50,11,74,20,108,21,220,225,106,195,51,243,82,242,203,131,193,18,32,149,1,137,233,169,122,142,41,41,80,17,136,14,160,120,81,106,73,105,81,158,66,73,81,105,170,53,0,58,229,84,169,108,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFindTabHeaderByTagMethod());
			Methods.Add(CreateCheckModuleReadingRightsMethod());
			Methods.Add(CreateOnMultiLeveTabsTabChangeMethod());
			Methods.Add(CreateGetRedirectUrlMethod());
			Methods.Add(CreateAddOpenXmlDllMethod());
			Methods.Add(CreateShowLDAPMessageMethod());
			Methods.Add(CreateGetModuleCaptionMethod());
			Methods.Add(CreateInitializeContextHelpButtonMethod());
			Methods.Add(CreateAddOpenXmlDllReferenceMethod());
			Methods.Add(CreateAddWindowsBaseDllReferenceMethod());
			Methods.Add(CreateGetSettingsButtonMenuItemTagsAndCaptionsMethod());
			Methods.Add(CreateCompleteSettingsButtonMenuItemsMethod());
			Methods.Add(CreateOnSettingsButtonMenuItemClickMethod());
			Methods.Add(CreateGetAdministrativeRightsMethod());
			Methods.Add(CreateRegisterDemoLinksMethod());
			Methods.Add(CreateSubscribeOnMessagePanelCloseEventMethod());
			Methods.Add(CreateGetWelcomeWindowScriptMethod());
			Methods.Add(CreateGetProfileDataMethod());
			Methods.Add(CreateNeedShowWelcomeScreenMethod());
			Methods.Add(CreateGetModuleInfoByUIdMethod());
			Methods.Add(CreateResetWelcomeScreenSettingsMethod());
			Methods.Add(CreateFillSearchModulesMethod());
			Methods.Add(CreateBuildWorkspacesMethod());
			Methods.Add(CreateCreateItemTabHeaderMethod());
			Methods.Add(CreateGetWorkspaceChildElementsMethod());
			Methods.Add(CreateGetModuleEditsMethod());
			Methods.Add(CreateCreateAddMenuItemMethod());
			Methods.Add(CreateFillAddButtonMenuMethod());
			Methods.Add(CreateGetAddMenuItemCaptionMethod());
			Methods.Add(CreateGetWorkspaceEntityCollectionMethod());
			Methods.Add(CreateRunProcessMethod());
			Methods.Add(CreateIsEnglishLocalizationMethod());
			Methods.Add(CreateRegisterChatLinksMethod());
			Methods.Add(CreateIsRussianLocalizationMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("368a8430-9e48-4ca8-a404-c27647a0e6aa"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ab6ee143-6600-4750-b499-efce30694d41"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("50ba7521-25e0-4a80-9b8b-699987de4665"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("508099d5-5266-4168-b0f4-cfa21c83b073"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e6d29217-eef2-4009-b532-d82c537df6f1"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5dee138-c82f-469a-a5fe-5a1d2eef8d21"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1e6d6115-4b1e-40be-9e6c-ebe4cd56d454"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3898550f-2487-4196-9186-1514514959aa"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f544447-f3a7-4d3b-a05e-25c6215b95a4"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d97aaed2-0df3-4aee-8171-b031b9f99028"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("de7da21c-9b1e-4660-b06c-149b9a3dab12"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3f452131-56a5-44e8-b8cf-9b972a3432d8"),
				Name = "Terrasoft.Sync",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0f15370c-7b03-47e1-bfec-26023ed88ae5"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aec44efd-5e6c-4ddd-9733-13fdad5b8d55"),
				Name = "System.Net",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("da309d20-39b2-4841-aa6d-3ea3e4840b3c"),
				Name = "System.Web.UI.HtmlControls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f5a0e52c-74a7-4f9b-b109-ed77b81d0aa7"),
				Name = "Newtonsoft.Json.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("c42d95b3-a17f-45a6-9dff-a6ab283daf22")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4dc2d041-a3b6-4c84-b22d-60918e4765cc"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c42d95b3-a17f-45a6-9dff-a6ab283daf22")
			});
		}

		protected virtual SchemaMethod CreateFindTabHeaderByTagMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("263f3c61-2a48-4b63-b907-ae52d59ae378"),
				Name = "FindTabHeaderByTag",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.TabHeader"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b990fd59-f241-4948-a34e-24a835085861"),
				Name = "TabHeaders",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.UI.WebControls.Controls.TabHeaderCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("de734f9f-c687-40a3-aec6-fcb4cc7a419e"),
				Name = "Tag",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,61,11,194,48,16,134,231,228,87,156,91,11,82,220,131,14,10,162,123,213,57,181,87,13,196,4,242,33,136,228,191,155,164,54,148,14,129,228,222,123,158,187,180,104,12,183,122,112,205,229,220,220,176,59,104,229,140,150,182,41,151,150,119,39,228,61,26,48,232,174,92,122,132,45,40,47,37,163,131,54,200,239,207,234,205,13,8,135,47,16,10,74,187,173,225,75,137,24,160,74,81,212,60,178,147,11,101,171,248,168,115,76,162,211,27,149,105,70,73,0,148,22,115,48,3,39,97,228,189,114,176,131,205,200,146,217,66,71,161,250,210,185,255,196,1,75,122,157,134,50,2,9,76,242,2,175,198,239,252,157,211,70,83,204,82,49,208,124,2,13,116,25,255,0,142,60,2,87,65,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckModuleReadingRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("752b1e2e-d0a6-4dd5-8892-a3d219c07967"),
				Name = "CheckModuleReadingRights",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("04d45e12-ddf1-4a3a-b646-c0e29bf87088"),
				Name = "entitySchemaId",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,203,110,194,48,16,60,131,196,63,88,57,37,18,114,63,128,182,82,121,180,138,250,84,35,232,161,234,193,197,75,112,9,54,178,29,104,84,241,239,93,199,41,36,41,7,78,150,198,179,187,179,187,179,91,166,137,129,121,174,133,45,38,50,21,18,200,21,121,97,41,16,58,53,160,71,74,74,152,91,161,36,29,15,147,6,111,208,235,110,49,24,164,69,40,153,47,97,205,30,153,196,72,77,174,122,221,78,56,249,255,17,185,196,212,67,180,241,243,162,213,86,112,208,244,14,108,5,133,193,137,12,65,84,149,53,37,250,196,214,78,239,9,13,244,86,72,30,91,88,15,139,105,204,195,58,35,230,17,117,129,85,38,198,215,66,62,42,158,103,240,32,140,197,116,18,118,100,44,202,174,153,46,46,141,213,66,166,125,226,223,107,242,131,221,253,4,179,93,82,152,27,23,59,149,194,6,125,18,140,152,244,197,75,20,83,105,230,82,4,251,126,21,80,199,183,240,252,249,133,147,53,103,68,254,21,122,222,64,245,113,86,76,2,214,162,224,51,43,248,217,52,184,137,202,242,22,235,65,169,85,190,105,176,60,100,60,233,226,162,164,249,113,222,170,12,87,218,32,191,41,189,50,27,54,7,115,28,11,242,113,253,8,53,149,86,216,24,140,72,15,18,70,75,38,93,201,212,123,163,17,112,248,11,246,189,238,30,183,43,22,36,108,109,151,222,67,97,40,186,218,50,33,77,120,116,81,20,149,123,61,24,226,85,164,75,231,133,230,109,56,123,98,189,201,55,162,22,14,251,48,97,105,236,214,193,140,114,173,209,119,14,165,49,119,250,59,45,53,239,199,250,31,190,147,153,128,29,166,88,136,52,175,54,228,12,223,209,96,115,45,107,202,16,196,38,43,248,84,241,246,181,58,229,177,169,95,212,43,48,142,246,184,201,50,181,3,94,31,197,224,23,88,196,50,42,21,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnMultiLeveTabsTabChangeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9f3a47b4-5b53-4834-97e6-b0584624f894"),
				Name = "OnMultiLeveTabsTabChange",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,93,111,211,48,20,125,206,36,254,131,87,161,37,165,224,178,231,82,193,24,5,77,218,24,162,131,151,105,155,156,228,46,53,184,118,176,157,108,211,218,255,206,117,146,6,47,109,71,95,18,57,247,220,115,238,151,111,74,166,137,137,201,152,72,184,35,83,171,185,204,62,22,92,164,160,163,254,232,197,158,137,233,81,158,131,76,163,15,189,219,66,38,150,43,73,34,16,175,137,101,177,123,100,125,242,248,98,47,40,145,134,161,181,132,11,22,159,164,200,135,118,202,211,81,99,203,180,42,242,239,144,193,125,142,182,225,245,229,245,205,213,171,155,234,249,114,232,64,252,150,68,30,136,90,48,54,242,24,251,181,78,160,193,22,90,58,143,101,67,157,20,198,170,249,39,102,217,103,14,34,157,8,20,152,220,91,154,129,141,194,142,49,116,57,5,29,183,159,76,20,128,78,97,88,25,93,36,107,156,141,122,176,238,229,164,82,72,84,10,235,94,52,85,115,90,58,96,173,91,113,239,119,56,48,213,121,238,78,43,141,174,72,11,64,181,199,101,77,180,36,32,12,236,224,176,49,188,142,110,67,185,41,193,22,116,25,158,49,46,143,254,53,36,188,66,118,175,65,163,32,120,150,160,137,5,228,46,177,60,83,201,103,121,106,247,101,208,140,134,134,148,107,72,236,15,237,134,226,142,203,84,221,81,161,18,230,198,152,230,90,89,149,40,65,6,36,28,14,67,124,117,17,51,101,236,134,207,57,179,51,201,230,176,26,110,3,76,39,179,250,242,108,208,169,205,212,20,177,169,32,209,97,159,154,92,112,28,207,131,122,32,29,201,159,2,244,67,203,81,207,98,251,253,4,235,51,106,147,114,55,232,139,80,49,19,211,138,186,74,125,225,245,102,49,125,48,174,93,223,88,6,211,25,8,113,44,56,72,139,134,60,41,23,121,90,46,230,42,45,4,224,7,86,93,233,97,198,29,253,173,210,36,114,26,28,37,222,142,240,245,238,73,114,84,128,204,236,140,160,101,48,104,198,181,141,15,93,124,236,37,191,106,175,83,139,105,106,17,105,232,147,253,49,121,115,216,222,43,37,45,151,5,212,253,91,243,91,193,252,34,13,198,79,107,83,185,45,155,85,226,1,219,197,225,207,130,127,194,246,191,119,221,247,124,86,251,229,9,12,187,114,224,21,121,236,124,252,11,208,115,189,116,226,117,155,233,137,249,90,8,113,174,39,243,220,62,68,219,90,210,44,182,118,209,158,114,9,81,175,59,67,26,114,193,18,136,188,128,250,181,160,183,9,58,28,107,193,111,11,97,236,205,190,85,57,237,225,113,27,22,77,61,183,215,43,237,45,81,239,196,97,192,78,85,161,19,192,240,54,165,229,253,123,106,242,101,231,191,83,193,28,55,61,43,132,229,167,80,130,192,70,24,122,244,139,221,79,74,84,50,20,207,199,51,38,17,115,46,107,245,202,224,70,53,166,23,170,110,118,180,3,209,25,200,194,13,26,146,36,191,255,67,246,23,27,243,42,57,83,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRedirectUrlMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2ca05b00-175a-475b-9f98-6adde5b28416"),
				Name = "GetRedirectUrl",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,77,143,218,48,16,61,131,196,127,48,62,172,140,22,249,208,30,217,108,133,90,212,34,237,182,187,5,182,135,213,30,76,50,128,43,199,6,219,73,27,85,253,239,29,39,89,8,73,139,212,3,31,137,223,123,243,252,102,38,23,150,76,221,254,65,108,129,68,36,252,240,215,71,225,200,18,172,21,206,108,60,95,205,249,55,88,191,55,218,91,163,28,15,128,201,160,239,188,149,122,75,44,36,210,66,236,87,86,161,72,205,231,95,225,144,129,243,136,245,187,9,25,244,239,164,243,55,21,227,150,200,173,54,22,30,51,176,197,220,67,234,144,167,225,7,105,98,216,8,43,180,113,124,154,36,140,126,84,102,45,212,2,132,141,119,79,66,101,64,255,141,157,198,94,230,176,20,235,121,114,1,181,143,243,75,167,201,165,211,212,36,153,130,139,242,2,77,24,93,2,234,204,14,1,177,168,254,71,164,122,201,103,233,222,23,136,217,160,132,136,119,132,53,193,65,142,72,221,201,247,241,164,52,34,191,6,253,158,220,16,214,177,17,90,39,164,118,236,168,53,170,208,189,24,79,164,206,66,63,123,191,73,205,31,54,252,241,217,33,19,202,177,166,201,87,114,243,26,215,17,161,87,180,148,193,79,235,164,38,163,141,88,248,147,137,49,161,17,29,95,186,211,243,17,251,18,226,67,233,255,240,119,62,153,205,167,107,66,223,81,252,110,232,84,234,57,110,132,43,39,107,9,63,125,183,55,114,195,238,13,14,148,121,16,86,164,224,193,58,50,196,233,205,148,170,106,6,129,180,141,136,72,135,132,251,245,65,150,115,33,108,81,15,253,152,152,245,119,116,120,27,82,108,184,40,163,197,25,141,130,229,182,248,51,13,233,188,161,47,124,105,170,155,148,171,211,229,39,21,127,81,56,196,135,125,230,159,188,223,175,188,84,210,23,28,83,153,233,216,36,192,254,94,224,237,89,129,99,47,216,176,14,104,238,62,99,6,95,108,25,20,235,172,104,221,145,179,104,233,85,7,86,58,236,188,173,138,181,47,212,88,237,146,86,142,208,125,166,188,188,131,28,20,30,224,250,157,48,231,241,88,240,153,213,173,153,56,85,152,252,1,175,92,98,214,26,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddOpenXmlDllMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3f76417c-a460-4f62-ad0e-62bdecd7f201"),
				Name = "AddOpenXmlDll",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.References.Add("DocumentFormat.OpenXml", "DocumentFormat.OpenXml.dll");
			method.References.Add("WindowsBase", "global::WPF/WindowsBase.dll");
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateShowLDAPMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9ff272b3-b960-4baa-a009-7a71271572e2"),
				Name = "ShowLDAPMessage",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,110,219,48,12,61,59,64,254,65,243,73,14,2,229,3,138,30,18,199,45,60,164,168,81,47,216,89,179,216,84,152,45,101,148,220,46,24,246,239,163,28,173,201,90,183,192,182,67,2,153,228,123,122,124,164,42,185,3,177,146,14,110,192,57,58,87,210,64,43,238,160,179,143,192,211,205,122,89,85,104,27,202,213,94,162,7,149,102,23,211,137,190,103,252,67,21,144,91,7,152,91,99,160,241,218,26,177,94,213,208,244,168,253,161,48,59,109,64,92,131,207,165,41,190,83,212,195,237,30,80,134,58,158,82,240,70,26,98,88,170,78,27,237,252,49,145,206,199,88,243,30,17,140,15,81,81,170,44,99,63,166,147,4,193,247,104,72,204,207,233,228,81,34,115,208,178,75,102,224,137,213,208,18,144,255,73,146,9,194,228,182,237,59,186,189,62,184,225,222,173,209,62,157,179,180,164,182,40,127,133,182,27,146,161,237,250,96,154,135,107,180,253,126,200,37,37,49,225,71,171,95,194,51,113,59,194,24,24,10,227,241,48,80,151,174,248,214,203,118,140,59,222,206,164,139,186,169,163,222,105,179,99,124,189,58,250,102,145,169,47,207,199,75,246,194,157,194,184,30,97,189,58,133,120,180,40,242,148,107,233,229,29,72,5,68,20,8,200,42,17,71,114,12,243,19,127,132,38,195,136,21,138,80,240,155,47,57,153,158,36,100,123,248,69,247,201,247,141,54,95,227,4,194,145,228,220,235,29,15,235,18,147,34,151,251,32,143,138,104,19,76,48,34,180,226,54,52,254,77,125,86,183,197,48,202,52,61,11,133,191,82,81,180,126,176,79,1,25,215,181,84,226,147,173,61,82,163,195,85,213,232,58,7,180,19,75,165,120,228,11,165,211,201,98,246,151,178,105,107,27,104,255,77,248,9,251,191,210,103,139,183,138,207,159,237,160,240,51,32,189,48,21,159,237,56,136,242,241,123,20,56,103,71,141,162,232,246,254,240,252,117,101,177,147,158,191,6,108,234,249,123,67,74,87,105,182,152,205,223,183,35,20,205,22,89,118,241,11,11,99,75,170,158,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModuleCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c42a1071-beca-41d5-a03a-880b1e3572d3"),
				Name = "GetModuleCaption",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e3548cb0-79f8-4d61-8853-d86863e948a2"),
				Name = "moduleId",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,203,74,3,49,20,134,215,157,167,56,100,149,129,33,116,95,45,72,24,165,139,138,82,47,11,113,17,102,142,109,32,151,105,46,149,65,124,119,147,73,45,149,186,253,243,157,47,255,57,7,225,0,77,144,97,220,116,59,212,98,45,140,216,162,131,107,120,246,232,184,53,6,187,32,173,97,237,37,180,168,14,105,122,31,209,141,137,55,248,9,231,208,99,206,233,63,238,6,200,102,244,107,219,71,133,164,46,146,78,12,249,23,110,85,212,230,94,104,76,194,73,204,110,250,190,164,148,240,2,145,154,101,98,81,21,224,86,170,128,206,103,144,150,132,59,20,1,75,254,42,195,238,65,184,196,103,136,150,144,91,61,8,39,189,53,79,227,128,172,221,71,161,26,168,102,100,213,147,6,244,212,108,213,215,199,110,211,10,18,253,169,210,29,134,178,104,42,166,202,121,232,223,107,165,73,249,1,244,119,146,113,27,77,128,37,204,107,248,170,102,14,67,116,230,228,125,155,191,103,101,174,114,92,245,69,168,136,87,62,56,105,182,75,122,113,155,100,255,6,84,30,207,100,5,102,173,30,194,152,158,127,0,187,195,61,30,215,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c12d4519-a766-4947-bd5a-ba7351e04f1e"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,75,83,219,48,16,62,211,153,254,7,213,151,216,131,71,211,123,167,7,72,83,112,103,32,76,205,227,44,226,77,16,149,37,143,180,166,80,38,255,189,43,217,33,137,157,73,67,40,135,60,188,223,238,183,159,246,33,203,41,139,243,39,151,3,162,212,51,199,79,0,175,133,170,33,190,114,96,135,70,107,152,160,52,58,101,209,72,139,91,5,100,66,120,196,83,80,85,148,178,169,80,14,146,132,61,127,252,112,240,32,44,155,44,209,227,26,209,104,246,149,93,136,25,240,97,23,248,210,70,152,10,116,15,92,68,141,215,193,213,152,51,83,212,10,54,135,44,49,31,209,211,196,79,101,81,128,143,8,242,55,251,100,165,103,203,77,109,39,64,158,94,133,53,42,88,27,35,255,9,46,252,57,19,154,140,118,27,77,199,245,92,148,158,51,186,4,107,133,51,83,228,55,112,123,84,85,209,46,28,25,66,185,32,184,35,39,94,233,89,8,148,212,201,79,57,40,106,24,20,203,18,180,245,203,10,158,185,243,90,169,177,29,149,21,62,197,109,215,66,65,137,178,82,2,59,162,86,162,185,187,51,191,253,115,172,137,34,101,205,247,224,249,243,124,144,132,228,7,14,45,205,15,43,133,212,190,15,222,247,202,42,34,188,204,137,99,42,103,181,21,126,144,248,181,44,192,4,24,165,146,40,33,204,92,235,31,247,78,159,178,134,153,7,213,41,91,31,203,100,45,247,203,153,255,83,230,45,197,220,44,164,223,187,163,123,241,56,122,0,141,142,15,149,156,252,226,99,77,191,244,28,140,36,178,61,221,119,99,75,129,241,162,17,105,183,144,13,255,198,101,121,135,28,221,229,122,67,138,213,158,132,4,115,6,180,116,203,217,235,213,172,33,206,10,98,237,215,179,5,191,237,91,238,221,198,123,16,177,195,45,194,14,89,180,24,251,61,59,242,30,50,94,223,180,127,169,240,233,127,56,98,202,193,74,161,228,31,136,183,172,68,226,5,53,87,67,163,106,78,159,29,118,144,94,61,116,253,181,23,172,135,46,44,29,199,122,108,159,235,96,254,23,44,152,60,125,210,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddOpenXmlDllReferenceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ab6844f-b98a-490b-a623-a283e829132f"),
				Name = "AddOpenXmlDllReference",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateAddWindowsBaseDllReferenceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("958539e6-eee3-4ee2-8598-fcb05f664953"),
				Name = "AddWindowsBaseDllReference",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateGetSettingsButtonMenuItemTagsAndCaptionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1c82e62c-b932-4e3d-a55f-4bd415b6abb8"),
				Name = "GetSettingsButtonMenuItemTagsAndCaptions",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Tuple<Guid, string>[]"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,203,110,219,48,16,60,203,128,255,129,189,4,82,16,200,31,208,56,128,163,6,129,1,171,62,88,249,0,66,90,43,4,168,37,65,46,93,24,77,254,189,164,228,62,12,75,178,220,147,14,59,187,51,156,29,82,7,110,152,1,235,36,177,37,67,248,193,54,194,210,99,225,180,132,199,87,39,170,7,102,201,8,172,159,158,226,228,235,124,38,246,44,206,56,230,28,121,13,57,23,114,7,230,0,198,178,143,15,182,182,223,224,0,82,105,48,185,170,32,97,63,231,179,168,155,157,174,170,42,110,135,166,153,1,78,16,175,27,174,79,189,59,32,242,12,127,190,207,142,72,97,14,232,214,4,77,193,235,7,54,25,157,113,77,66,97,90,168,93,43,59,78,146,32,251,115,62,27,18,242,82,9,218,169,82,112,185,42,75,229,144,236,25,243,101,121,18,97,240,233,175,81,27,81,190,217,224,210,221,29,251,82,128,49,220,170,61,165,153,194,189,168,157,225,237,132,76,53,141,194,55,18,82,144,0,155,6,59,27,245,236,132,172,226,208,237,209,8,101,128,38,201,205,118,123,5,128,22,198,60,30,135,12,27,123,138,132,151,152,219,58,44,201,207,25,212,183,88,140,237,161,0,9,250,93,225,177,71,222,72,253,170,182,29,113,67,193,95,142,213,43,32,116,142,143,59,118,1,239,209,116,5,115,123,24,183,26,112,141,4,117,55,110,163,234,51,190,203,242,36,194,225,59,168,149,161,222,235,118,89,24,152,189,184,63,121,156,189,115,172,97,165,181,20,101,171,174,112,232,97,97,245,253,105,136,188,249,161,183,123,95,124,220,191,59,41,183,230,165,209,116,140,127,135,48,96,71,3,153,248,41,81,228,9,166,183,176,229,146,121,192,118,191,159,206,210,101,37,186,129,163,165,192,201,13,255,248,234,93,141,62,207,147,25,30,230,158,55,217,159,89,115,159,5,101,206,214,135,222,200,118,57,131,225,190,46,171,29,244,63,234,187,136,223,47,66,236,200,25,60,253,93,60,98,229,223,189,163,63,222,47,5,186,185,239,115,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteSettingsButtonMenuItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c71df34d-b549-4724-a216-30e64c7c77bb"),
				Name = "CompleteSettingsButtonMenuItems",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,91,79,194,48,20,126,30,9,255,161,217,211,136,73,35,190,34,38,115,26,93,162,196,0,198,231,202,14,163,102,107,177,237,6,9,225,191,219,211,13,100,192,18,229,101,151,238,59,223,229,156,118,37,83,68,131,49,92,164,250,190,48,70,10,50,36,111,44,5,58,105,172,14,186,157,210,66,185,129,124,202,82,29,138,36,98,75,195,165,208,22,255,4,166,137,126,5,81,196,167,208,160,103,105,154,106,244,153,39,9,160,104,112,134,155,190,128,72,205,130,220,146,62,150,242,57,9,166,160,20,211,114,110,232,123,76,63,224,51,146,194,40,153,105,250,184,54,52,214,225,23,91,143,225,187,0,109,122,100,211,237,120,71,114,232,140,142,33,151,37,132,89,230,12,109,187,157,185,84,192,102,11,18,28,100,252,181,65,184,56,23,188,226,71,79,39,21,20,195,247,201,112,72,38,176,100,138,25,169,14,90,82,21,122,165,107,125,253,217,54,64,192,138,180,166,219,63,32,207,158,212,249,247,206,102,12,147,36,216,179,87,176,75,218,215,74,126,236,97,139,151,153,101,227,162,0,92,193,5,140,152,215,193,255,149,16,11,44,177,103,57,118,245,22,159,224,94,43,120,66,71,176,194,123,37,189,7,140,88,14,22,209,50,13,58,149,19,163,108,146,192,31,249,205,194,221,156,219,106,111,154,70,44,224,47,50,77,141,56,183,135,170,238,65,29,181,90,218,108,7,45,219,20,71,184,171,119,100,23,13,176,133,185,54,237,26,221,16,217,186,19,113,176,173,207,29,200,59,114,109,233,189,122,196,122,166,248,210,216,112,71,90,81,198,65,152,248,129,92,17,159,74,129,86,237,123,180,96,34,5,28,158,143,122,238,103,131,27,202,145,4,21,151,59,151,63,252,241,127,10,156,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSettingsButtonMenuItemClickMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a21c5490-27e9-447d-911b-5c8cc355de9e"),
				Name = "OnSettingsButtonMenuItemClick",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fc36748c-1b64-4c22-99bc-d0228af8422a"),
				Name = "selectedTag",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,65,106,195,48,16,69,215,53,248,14,34,171,100,211,11,132,44,90,19,138,33,166,1,251,2,66,158,202,67,165,145,144,198,9,165,244,238,117,26,188,114,169,228,238,132,248,127,222,255,131,132,111,98,27,193,128,98,232,59,169,197,225,32,90,96,70,210,177,113,61,204,231,231,145,217,81,3,52,214,12,118,18,238,196,103,89,60,156,165,134,199,110,8,238,122,188,0,241,118,147,246,254,8,55,187,125,89,124,9,48,17,4,46,19,212,86,250,22,194,5,66,156,135,172,13,146,61,34,39,207,177,71,110,157,66,105,158,148,114,35,113,76,7,88,122,214,115,79,168,128,34,172,46,255,183,47,183,113,55,93,249,193,209,71,46,182,137,250,182,242,9,62,131,95,61,80,130,52,73,27,137,166,26,208,250,127,188,182,132,55,167,107,229,172,149,212,191,0,65,144,140,142,114,241,9,99,14,251,182,160,154,24,244,125,192,201,233,172,214,191,91,242,190,150,119,129,243,127,209,82,93,25,84,239,119,74,89,4,224,49,208,254,27,211,128,125,191,70,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAdministrativeRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("17b3befd-ba84-4d3c-b282-f596b9b57262"),
				Name = "GetAdministrativeRights",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,193,106,195,48,16,68,239,133,254,131,201,41,189,40,31,16,122,72,213,16,2,49,57,56,249,128,69,217,40,11,246,202,172,214,161,253,251,74,113,77,235,182,180,184,71,137,153,55,204,236,21,164,136,232,58,33,125,93,179,39,198,226,177,56,70,20,27,152,209,41,5,54,207,79,213,72,177,188,191,179,192,246,2,236,113,213,182,53,57,200,186,67,199,196,190,12,167,140,24,51,205,6,53,89,214,47,233,87,113,223,162,220,28,243,217,239,156,217,67,31,85,2,131,199,18,168,174,80,174,40,113,82,192,55,247,24,187,35,151,251,254,135,57,88,7,96,122,148,209,231,20,114,121,4,149,14,151,139,197,1,69,32,134,179,154,52,234,153,124,215,131,204,135,246,168,84,147,18,70,243,149,50,31,223,226,83,80,234,99,47,212,180,91,86,244,61,177,66,213,52,221,180,42,127,176,134,110,149,130,168,13,77,3,124,218,32,191,19,38,37,253,140,72,1,111,146,191,14,122,133,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRegisterDemoLinksMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("baedc292-34d6-406f-ba6e-d81b7ecaf323"),
				Name = "RegisterDemoLinks",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,24,219,110,219,54,244,217,1,242,15,156,135,193,50,106,171,78,135,161,152,211,116,91,220,172,53,144,22,69,46,232,99,65,75,180,77,132,22,5,146,174,227,166,254,247,157,67,82,18,37,59,169,19,108,195,30,22,4,176,120,120,238,87,146,151,107,109,216,34,254,196,38,241,245,56,30,9,206,50,115,153,40,158,155,247,52,163,51,166,72,162,201,9,249,8,159,241,31,58,183,191,33,214,241,225,193,181,102,106,36,179,140,37,134,203,140,44,235,75,79,91,71,2,170,241,2,192,231,92,3,159,57,91,80,194,27,235,147,6,163,184,65,224,213,139,223,50,51,206,180,161,89,194,78,215,31,232,130,69,237,55,108,33,79,151,198,200,76,183,187,32,10,152,24,37,133,101,64,146,112,113,66,50,182,34,225,126,212,37,119,135,7,173,75,185,84,9,238,135,123,14,216,84,164,135,232,246,235,122,156,2,69,195,16,112,107,138,40,99,112,243,110,4,220,209,104,71,161,255,233,114,253,65,174,206,217,212,180,187,72,126,120,176,1,43,180,81,60,155,145,137,221,116,230,33,74,97,72,104,151,117,10,126,92,43,17,161,7,106,155,143,214,100,4,209,102,202,233,178,91,17,135,241,47,168,114,193,103,115,243,144,38,22,97,47,69,74,242,68,107,151,203,64,241,123,251,149,54,107,193,94,31,30,196,41,164,81,127,226,28,77,215,114,105,206,132,205,13,35,243,33,25,228,183,228,7,190,200,165,130,212,195,42,104,125,237,243,44,101,183,67,242,2,86,155,130,222,208,137,96,150,108,206,80,181,33,57,26,12,126,66,252,21,79,205,188,92,86,4,147,190,81,125,147,246,39,82,165,80,126,119,21,234,47,249,237,54,166,128,28,0,45,215,153,92,57,93,45,197,132,38,55,51,37,151,89,58,36,75,48,184,221,110,147,103,247,228,206,51,176,186,221,238,146,76,246,21,203,25,53,100,128,230,109,139,74,108,148,159,34,44,204,15,47,14,93,224,76,236,235,156,38,16,136,225,110,169,10,221,246,20,161,65,42,60,104,98,33,78,240,236,166,191,82,52,183,252,115,154,166,78,41,8,17,4,219,253,132,234,33,190,69,77,164,144,106,72,86,115,110,24,154,53,133,180,235,79,233,130,139,245,144,92,209,185,92,208,18,172,249,87,6,65,63,178,172,28,104,229,19,99,34,5,38,117,203,176,91,211,167,130,207,178,33,113,46,71,104,178,84,26,165,228,146,23,32,193,140,9,221,151,73,181,160,194,230,22,56,118,23,28,84,102,253,34,17,43,176,149,104,20,205,244,20,96,184,147,177,18,142,89,157,153,34,56,14,166,231,52,149,171,6,98,202,18,169,40,246,234,114,99,211,58,60,120,245,220,85,84,219,214,220,68,74,65,184,62,203,102,130,235,57,84,220,184,248,62,151,9,24,253,213,50,176,5,234,203,83,87,181,121,120,112,197,148,162,90,78,77,28,52,121,216,155,46,179,196,17,98,68,190,80,69,124,252,96,239,231,193,177,3,213,50,82,102,83,142,187,54,128,52,119,106,119,48,135,160,211,156,67,104,71,14,104,115,167,211,115,206,187,129,230,81,199,2,64,133,33,115,150,141,179,15,108,245,9,156,134,254,153,82,161,89,207,86,112,150,174,62,82,5,173,12,66,166,129,71,167,0,203,21,54,56,132,184,62,127,120,80,24,67,18,5,169,202,156,194,17,79,123,36,45,141,118,250,247,160,111,206,220,196,130,255,29,102,183,156,221,85,15,243,35,175,242,163,31,112,110,55,66,78,45,14,37,197,237,208,106,37,2,117,221,209,9,173,250,101,79,123,241,210,46,23,84,205,120,134,20,3,44,48,242,50,191,117,120,69,175,179,139,166,17,195,45,179,0,107,227,26,68,32,51,6,31,116,20,131,108,84,137,92,228,144,252,172,211,43,3,79,252,224,110,89,30,149,69,23,150,96,228,9,162,144,161,115,30,138,217,244,136,153,115,109,191,21,51,75,149,213,124,118,124,79,96,62,66,47,161,138,165,65,128,152,168,69,227,95,243,124,205,193,187,194,240,143,185,244,79,169,10,63,156,9,182,128,86,209,112,50,184,228,73,62,126,108,32,67,191,51,1,222,174,89,202,68,81,13,28,143,27,76,196,60,45,32,112,212,200,5,196,211,71,232,236,214,196,87,30,20,161,253,157,87,110,138,39,76,8,223,84,79,218,237,1,12,28,55,192,252,2,183,125,249,21,16,65,181,134,239,234,36,208,110,191,118,241,67,166,170,248,198,69,218,192,110,28,3,154,19,255,142,167,155,138,25,48,120,78,76,250,93,126,126,130,111,17,167,252,11,248,5,112,113,231,179,160,19,38,62,227,36,108,218,80,142,200,26,53,13,105,1,99,23,21,192,230,138,77,17,173,170,118,104,158,168,199,157,239,191,27,48,130,214,76,2,189,30,107,226,78,151,185,51,196,131,62,179,171,34,34,118,129,241,122,141,133,99,115,54,9,7,70,53,49,106,73,214,236,99,177,71,235,53,106,187,230,1,40,211,31,109,121,162,20,62,37,209,195,44,27,51,134,156,156,184,41,227,107,213,169,25,215,36,52,107,97,139,167,159,108,168,132,47,137,185,89,32,89,81,25,49,205,115,177,142,28,115,235,14,40,160,84,46,98,14,215,51,245,238,234,253,57,32,35,141,179,33,42,235,177,133,197,52,5,82,168,186,103,164,99,211,163,211,181,164,192,18,74,122,52,231,34,141,202,70,252,84,23,24,181,44,60,128,234,47,247,55,250,184,160,169,102,241,119,73,43,212,26,117,48,224,247,98,17,224,31,223,239,43,236,209,137,224,201,77,208,154,35,246,5,42,185,26,55,45,127,146,176,174,137,192,250,94,96,78,175,169,156,117,117,171,232,194,54,123,44,36,108,209,27,224,173,217,67,49,220,79,47,119,38,129,25,99,138,96,121,205,98,7,37,223,190,121,192,113,137,255,216,232,181,172,212,56,87,246,247,13,155,210,165,48,246,8,73,224,175,213,10,229,199,2,142,153,246,61,1,134,150,160,9,67,111,237,229,16,28,78,143,25,81,123,12,198,119,80,49,181,185,101,103,83,99,110,253,63,168,254,174,65,117,231,60,190,249,143,78,152,251,251,46,176,29,186,211,37,234,63,244,102,108,31,231,238,111,202,155,90,222,106,102,174,224,198,246,9,15,141,62,41,93,26,186,78,6,80,160,44,170,222,237,199,245,226,159,133,28,186,176,83,220,59,158,145,8,9,185,30,159,253,74,126,35,71,4,46,142,129,162,49,136,118,68,86,76,119,251,216,167,253,51,77,168,92,112,192,11,53,4,96,236,190,75,249,123,72,242,85,142,204,244,220,94,210,138,230,101,224,220,204,204,123,104,30,252,28,90,137,184,162,19,237,251,88,209,230,13,92,95,117,121,158,223,69,16,7,40,229,116,8,111,158,248,46,21,222,235,58,225,211,6,244,210,237,91,106,207,79,248,146,29,214,54,164,95,213,5,46,45,32,186,115,175,11,157,163,151,112,89,239,184,4,105,237,84,18,174,7,76,153,104,208,243,188,122,110,130,238,67,16,234,231,201,144,170,145,83,21,142,123,107,115,138,67,131,44,157,183,117,205,216,45,56,112,39,36,183,191,44,249,134,189,147,64,102,87,21,201,104,78,51,124,212,117,237,220,181,113,252,247,47,128,232,59,153,93,48,154,174,163,250,19,194,61,79,13,49,166,76,132,47,218,216,249,41,135,66,251,220,72,24,76,180,238,49,190,118,36,58,190,96,51,174,161,147,133,79,230,167,48,130,110,162,218,139,250,91,112,222,58,7,61,123,164,93,141,58,61,186,212,237,94,245,62,137,172,29,89,154,58,72,164,253,198,95,145,103,77,185,199,23,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSubscribeOnMessagePanelCloseEventMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("99eb6827-95a8-4e77-9519-a6100dd62349"),
				Name = "SubscribeOnMessagePanelCloseEvent",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,205,106,195,48,16,132,207,246,83,8,95,100,131,80,218,30,19,2,117,147,22,12,77,49,36,33,103,97,173,109,21,89,42,210,230,167,24,191,123,21,39,129,244,146,139,88,105,151,153,79,179,7,225,136,175,28,153,19,143,78,153,134,127,88,215,9,76,95,147,254,105,224,214,164,180,3,239,69,3,149,182,30,36,101,164,222,155,10,85,232,116,190,41,133,1,205,200,117,164,64,232,50,210,247,113,52,153,108,192,57,225,109,141,60,255,22,167,21,96,107,165,231,155,214,217,227,66,43,48,248,126,8,199,78,97,91,10,39,58,64,112,62,165,253,243,16,28,232,234,162,55,170,95,235,197,205,190,239,111,110,114,122,111,204,149,28,134,108,22,71,170,38,233,255,119,50,159,19,218,191,12,52,35,113,20,97,171,60,175,132,214,101,152,184,128,165,116,4,27,145,70,139,58,132,80,58,123,250,205,93,51,165,45,118,250,28,11,101,7,5,199,53,10,132,149,149,48,165,202,84,122,47,129,50,175,26,35,244,87,248,199,244,33,252,3,116,102,246,90,159,249,67,25,71,33,252,44,97,228,140,200,223,132,135,123,81,126,9,176,88,50,82,24,143,194,84,176,45,36,35,201,231,50,47,183,62,4,185,3,7,185,148,32,147,32,56,106,132,219,186,114,234,7,211,176,236,108,246,7,168,9,141,107,246,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetWelcomeWindowScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e2d1d63f-7b9d-4868-94bb-c27bd4c50d79"),
				Name = "GetWelcomeWindowScript",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,109,111,226,72,12,254,220,74,253,15,35,36,148,160,171,162,222,151,211,138,234,164,131,52,187,229,174,64,213,80,177,95,135,196,144,220,134,25,52,153,148,178,85,255,251,121,94,82,38,9,236,238,181,106,5,30,219,243,216,143,237,241,11,21,164,92,145,63,9,131,61,137,165,200,217,102,92,229,69,10,194,31,220,94,93,230,107,226,151,90,26,76,202,89,85,20,115,17,109,119,242,224,199,80,64,34,33,157,242,180,42,32,228,41,12,6,228,237,234,242,226,66,128,172,4,35,214,74,107,163,163,247,171,203,47,85,158,146,124,75,55,16,39,25,108,233,243,36,197,123,149,244,67,235,168,114,226,240,234,242,5,193,58,14,80,225,185,4,17,114,198,16,75,206,89,176,228,226,91,185,163,9,4,70,99,74,25,106,139,71,193,95,114,12,41,248,2,210,138,252,222,68,57,122,200,75,217,80,237,13,84,12,248,163,116,39,172,148,148,37,48,62,204,232,22,252,158,9,118,194,214,92,108,169,186,176,229,163,55,32,180,36,45,97,19,57,98,118,34,8,62,231,44,157,72,216,218,27,78,100,213,146,96,141,145,39,36,193,100,250,108,162,59,57,118,111,68,201,173,85,113,14,173,184,92,5,163,221,14,88,234,255,213,83,144,183,31,1,47,17,40,223,219,58,89,128,16,180,228,107,25,24,177,175,137,191,96,24,194,144,120,109,35,239,90,159,38,116,167,82,54,36,253,101,244,16,206,167,81,28,62,69,209,44,28,61,46,38,243,89,223,40,9,40,243,239,116,85,160,159,53,45,74,48,210,125,158,202,108,72,62,221,220,152,239,107,161,111,146,162,178,10,25,228,155,76,14,201,31,181,6,98,160,133,171,161,77,98,121,80,158,189,29,77,83,204,217,144,220,152,223,26,97,193,75,24,37,6,165,151,97,197,120,40,85,71,239,138,6,237,181,17,89,192,153,239,105,43,239,154,172,43,166,77,125,100,135,236,205,249,49,81,163,127,233,235,20,100,198,211,50,88,100,130,239,195,34,7,38,163,23,252,183,204,101,246,72,21,64,9,162,244,251,143,79,243,48,138,227,231,201,93,255,154,120,75,40,18,142,216,19,1,192,66,117,89,138,183,121,111,12,94,64,196,25,223,15,61,242,27,73,57,147,234,75,152,65,242,109,204,95,131,68,125,128,20,143,188,119,111,112,107,35,80,127,31,181,248,64,15,188,146,29,78,177,159,164,224,133,57,181,212,230,41,102,196,49,178,25,75,115,1,31,249,226,34,255,142,166,180,240,26,172,121,191,223,220,244,189,38,79,70,214,76,174,134,213,106,45,12,164,3,175,62,104,32,235,218,213,156,98,126,65,184,149,240,83,88,14,166,19,126,131,18,231,130,250,108,239,47,121,37,18,24,122,173,174,183,158,203,186,11,177,236,39,211,209,23,44,250,251,104,58,210,212,26,248,216,252,206,177,58,112,239,63,102,60,192,154,245,79,224,105,242,186,230,28,195,253,31,196,54,179,97,25,65,94,203,93,65,15,117,191,24,175,54,36,72,55,80,42,139,70,239,208,34,223,168,42,88,113,41,249,214,10,215,185,188,215,169,29,31,212,221,72,133,33,162,197,122,1,107,25,171,169,45,44,228,232,85,6,70,224,191,17,28,8,80,3,36,142,149,80,142,127,193,108,247,218,48,211,237,58,174,16,37,235,36,200,136,221,194,114,180,59,99,44,124,152,199,209,248,121,177,152,183,134,88,70,89,90,168,162,115,71,130,121,86,58,19,68,95,224,27,120,23,239,173,196,100,80,236,126,25,42,78,131,67,188,131,36,167,197,253,135,221,36,181,176,117,37,33,9,235,28,199,158,5,99,75,151,120,79,96,62,218,55,208,154,168,97,236,138,103,102,188,59,195,31,86,248,90,180,181,213,115,102,85,21,254,96,199,54,158,137,238,167,217,57,186,86,17,232,146,65,74,75,28,107,234,187,223,191,143,30,30,195,249,108,17,125,93,232,217,168,223,194,110,234,234,244,181,103,98,183,33,236,129,155,198,182,81,135,246,59,4,16,223,207,151,216,200,225,63,227,249,215,38,247,118,236,118,234,92,253,185,205,169,219,249,200,175,81,234,40,28,59,227,140,66,27,237,25,53,167,87,206,104,56,133,126,4,220,169,86,61,131,142,51,233,204,171,168,180,220,11,6,183,103,220,41,102,253,250,180,167,188,153,101,134,96,45,85,133,26,96,184,144,44,184,89,75,117,147,216,157,199,156,7,79,128,83,42,193,197,236,44,41,189,107,242,119,137,139,97,12,2,251,2,71,130,127,231,102,108,197,95,67,67,236,64,237,125,142,195,19,205,221,245,165,95,99,103,29,52,97,157,241,232,188,234,93,79,245,166,137,79,65,219,174,245,108,116,109,155,235,158,147,175,147,158,126,224,227,199,214,205,230,235,186,104,238,174,78,3,119,67,58,185,0,118,61,218,205,246,179,78,175,223,220,131,76,142,175,73,107,99,174,83,63,184,253,15,20,222,108,99,217,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetProfileDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4d87778a-c955-4655-9d67-17bc0d20664b"),
				Name = "GetProfileData",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d31d07a5-0e99-4be5-a731-c87c33647e10"),
				Name = "profileKey",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,140,177,10,195,48,12,68,127,197,99,2,65,63,208,169,164,75,233,18,74,77,102,165,145,131,192,177,130,164,12,253,251,218,116,233,116,220,241,238,41,249,169,37,188,72,21,77,146,195,40,37,241,118,42,58,75,169,109,223,165,68,231,204,206,100,240,36,92,39,149,196,153,110,232,216,69,35,173,143,66,239,134,15,161,155,112,35,184,218,209,50,160,253,137,227,29,102,90,42,236,42,217,160,1,125,29,215,33,28,63,225,131,62,253,229,11,186,7,125,142,144,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNeedShowWelcomeScreenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("df6e522b-d2e0-41cc-8082-e7611bc2b1c2"),
				Name = "NeedShowWelcomeScreen",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,189,106,195,48,20,133,103,233,41,110,54,121,241,11,152,12,77,3,37,148,130,169,3,29,66,6,197,62,14,74,101,41,209,207,80,138,223,189,242,79,168,3,93,58,9,46,223,61,231,211,85,45,137,157,223,162,179,155,168,116,147,241,111,206,124,112,202,156,169,179,77,212,216,53,85,112,180,166,10,26,117,64,243,54,79,243,189,173,70,78,100,5,103,170,21,165,60,35,127,242,215,241,125,199,45,194,135,252,217,218,79,5,127,248,128,174,109,135,170,118,128,217,202,32,95,241,117,164,213,154,76,212,58,163,84,202,236,233,146,10,168,30,55,6,36,149,254,63,243,176,176,62,38,177,100,70,98,145,249,80,201,28,66,116,134,86,27,107,53,164,201,75,233,60,150,184,244,52,93,99,248,36,235,57,235,25,239,9,218,99,8,152,149,175,206,182,74,223,157,95,16,202,223,129,248,203,114,186,24,137,229,226,131,216,221,75,156,146,88,182,192,138,201,128,207,64,112,17,197,15,50,1,124,207,195,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModuleInfoByUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c5630e84-7113-4e82-8c58-572fb7f44dd6"),
				Name = "GetModuleInfoByUId",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Tuple<string, string, string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1b14eedb-59ba-4bc9-bec5-0b15138f8d2f"),
				Name = "UId",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,75,3,49,16,61,91,232,127,8,61,165,176,44,189,171,5,89,170,46,168,40,109,245,32,34,97,119,218,6,179,201,154,76,212,69,252,239,38,155,172,253,176,40,61,133,76,222,188,121,51,47,201,204,214,2,78,12,106,46,151,9,217,94,199,68,131,177,2,201,41,145,240,78,102,127,65,105,88,211,73,85,99,211,69,247,237,134,199,253,222,27,211,4,36,114,108,166,197,10,42,118,205,36,91,130,118,117,230,6,116,166,164,132,2,185,146,233,228,55,40,166,191,90,208,77,20,182,137,186,243,113,186,135,60,33,131,105,99,174,85,105,5,12,188,136,150,33,205,152,3,253,46,60,5,99,220,218,158,166,15,28,87,87,170,96,194,111,93,35,116,54,117,208,5,95,90,205,90,116,11,155,35,23,28,57,152,244,65,233,23,83,179,2,218,248,133,86,182,238,186,46,84,9,153,18,182,146,55,172,242,117,131,138,179,178,12,81,58,200,28,98,48,76,253,113,204,89,129,168,93,61,132,15,252,59,245,114,13,204,203,109,142,130,213,94,233,63,165,3,104,157,25,16,231,92,32,104,227,145,52,14,77,3,67,8,113,63,156,91,166,93,130,7,209,16,204,84,85,51,205,141,146,179,166,134,116,242,106,153,112,6,56,85,9,153,231,229,112,103,254,57,66,21,69,197,171,114,174,116,197,144,174,45,203,229,66,61,127,142,190,34,193,230,37,114,35,255,233,230,2,48,220,6,215,147,8,94,210,109,107,125,42,95,16,218,165,166,153,178,18,201,152,140,134,228,179,223,59,10,2,90,163,28,107,135,122,28,61,121,110,223,77,28,215,61,19,182,123,13,99,186,237,171,175,209,17,121,247,242,242,0,170,189,118,111,50,70,47,15,81,183,235,126,75,119,192,227,246,237,37,177,149,164,19,224,73,190,250,61,13,104,181,140,95,197,241,55,40,137,62,222,80,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetWelcomeScreenSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("10cbf42b-def5-49cf-bea1-2bb1cc156704"),
				Name = "ResetWelcomeScreenSettings",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,65,75,195,64,16,133,207,205,175,24,123,74,160,46,120,22,15,213,8,22,65,138,54,244,32,30,214,228,165,44,110,118,227,206,198,90,164,255,221,217,134,34,149,238,101,216,153,247,61,222,140,105,41,95,112,137,206,223,14,198,54,69,70,63,217,196,72,115,169,55,80,115,238,15,245,25,159,3,56,170,59,239,63,12,248,117,13,91,251,14,47,117,0,92,169,163,126,196,238,141,46,110,200,13,214,22,98,65,242,38,95,58,80,125,32,72,38,216,210,67,140,253,104,145,159,115,40,174,71,110,100,212,253,119,111,2,88,88,153,99,101,58,168,39,191,85,243,166,41,245,142,243,203,171,230,8,252,203,202,189,119,140,99,216,4,228,163,165,232,39,251,108,79,176,140,180,231,10,33,104,246,109,90,204,181,102,51,4,29,141,119,242,235,58,239,170,104,172,137,201,161,132,69,196,50,248,214,88,164,176,121,197,8,194,56,212,9,152,157,158,139,52,211,159,117,181,80,107,188,139,56,6,111,89,37,65,33,205,102,70,211,147,35,76,37,221,254,23,240,38,24,19,143,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillSearchModulesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4d04f2e7-b55b-4726-a6b4-d72b205e566d"),
				Name = "FillSearchModules",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,87,91,111,219,54,20,126,118,129,254,7,77,47,145,49,79,104,246,176,135,122,217,150,56,110,102,172,9,178,218,105,31,210,160,96,164,99,155,45,77,186,36,21,215,43,252,223,119,120,179,40,91,78,154,162,64,45,242,240,59,183,239,92,122,77,102,144,15,24,16,57,17,130,157,85,90,11,158,255,77,75,200,186,253,151,47,174,219,110,71,11,115,58,22,149,44,32,57,73,38,32,37,81,98,170,243,155,81,254,1,238,7,130,107,41,152,202,253,15,43,238,164,243,119,160,236,143,75,194,241,80,62,174,97,71,248,138,44,140,186,244,144,190,244,199,208,70,26,22,1,74,163,208,189,21,250,165,96,66,65,62,163,83,3,243,64,100,66,150,203,1,41,230,70,238,70,129,68,45,28,10,77,17,239,116,185,100,180,32,230,183,149,200,63,80,61,127,43,10,194,204,39,229,51,27,58,131,177,16,101,197,64,13,4,99,238,109,35,92,8,57,165,179,74,90,36,252,90,44,4,191,209,148,81,77,65,229,23,160,199,96,158,157,19,77,178,166,9,189,231,160,92,48,113,79,216,24,99,82,204,47,173,65,14,183,183,117,241,17,56,115,29,161,69,80,246,234,66,138,106,217,244,118,64,150,54,50,130,85,139,103,250,251,182,248,207,61,51,249,217,115,57,29,175,149,179,63,197,15,175,38,53,202,247,194,140,228,148,58,43,209,205,25,209,144,157,83,123,74,228,250,119,165,37,38,168,151,136,251,207,40,250,135,183,249,184,151,60,41,243,107,55,249,254,242,69,167,211,145,160,43,201,195,203,219,22,175,239,242,137,24,91,144,172,107,252,92,18,9,19,145,121,156,167,94,116,251,201,38,132,212,145,19,163,104,137,237,188,87,53,181,67,224,129,87,40,227,132,243,75,252,50,65,193,127,144,244,11,241,0,167,140,89,74,58,199,172,248,184,144,116,169,241,145,59,203,135,139,165,94,55,242,56,198,244,46,200,62,251,135,92,83,189,118,183,190,50,77,238,70,92,105,194,11,56,91,219,228,69,201,10,190,80,83,134,206,221,155,81,137,192,177,158,220,93,88,26,4,8,91,183,199,191,165,93,44,244,210,131,40,43,221,242,190,22,41,42,41,129,235,152,240,86,252,162,162,229,214,207,169,144,128,4,206,106,127,19,202,247,235,213,229,188,22,138,244,222,166,42,184,56,42,211,187,228,228,36,57,63,187,170,24,203,223,19,86,65,242,103,164,48,121,157,112,88,217,131,172,245,117,35,253,168,145,78,147,236,128,31,177,35,158,146,135,60,14,54,27,196,77,2,76,161,147,8,188,136,176,92,43,128,50,188,122,14,98,35,50,158,206,117,120,158,96,121,63,188,70,50,154,150,140,15,77,136,226,249,113,233,175,156,112,16,116,237,220,139,199,35,38,243,182,111,7,83,203,252,113,228,117,214,244,172,112,196,167,45,183,236,141,19,189,150,72,91,233,95,184,196,214,81,176,114,88,30,94,104,84,19,28,133,166,4,227,29,33,57,77,49,255,155,5,209,113,127,76,96,27,238,14,144,168,152,160,179,245,233,103,242,13,95,105,89,65,67,96,200,201,61,131,247,20,86,99,141,146,65,117,67,230,166,174,128,43,88,89,30,54,131,234,39,162,239,6,111,132,92,16,157,165,223,95,109,62,169,136,3,234,211,247,227,77,218,243,141,102,192,40,114,100,116,222,219,6,164,206,111,122,149,118,155,26,38,100,22,133,110,135,9,181,183,59,52,242,223,13,25,19,136,225,3,170,86,198,132,226,75,62,166,51,78,88,24,234,131,57,225,152,240,200,236,244,241,231,219,131,9,145,51,208,129,54,231,117,75,13,158,6,156,252,180,196,66,246,128,91,7,118,123,106,136,226,138,242,82,172,114,12,38,222,97,0,251,31,57,78,176,218,229,58,140,225,232,2,56,224,152,4,111,138,3,206,76,230,123,9,199,22,211,221,213,249,115,91,234,114,116,198,212,16,14,33,82,150,182,146,130,41,199,56,97,172,21,251,169,220,53,203,170,178,227,7,157,246,150,212,154,205,237,198,13,155,71,77,49,45,128,107,4,116,217,49,244,107,211,191,221,57,15,233,50,45,227,107,5,114,237,216,19,38,227,59,192,67,165,243,127,235,171,38,195,232,52,139,158,217,213,148,80,174,178,52,94,105,108,125,35,111,109,31,177,184,238,124,88,82,157,79,224,155,126,68,221,109,11,210,93,104,114,174,134,98,132,29,224,208,243,227,105,156,15,191,86,88,200,89,253,216,91,214,105,221,114,253,206,222,169,123,253,97,217,241,92,172,92,225,53,155,248,181,109,72,54,52,32,131,169,33,113,142,139,111,201,90,84,58,55,20,81,183,175,238,18,162,146,198,171,224,73,11,96,110,190,194,158,144,252,116,226,168,236,204,108,218,112,45,69,1,74,109,187,192,97,152,220,139,26,181,157,61,0,12,179,198,159,75,144,122,109,83,130,123,137,141,166,239,216,231,84,45,25,137,187,59,82,178,45,63,33,86,27,79,207,232,250,141,40,42,181,221,248,85,232,1,102,58,57,102,156,85,148,149,32,179,191,210,105,197,221,255,2,4,175,1,198,75,40,40,97,255,192,58,3,214,75,160,94,57,190,192,26,129,192,148,177,185,181,54,168,21,213,197,60,201,240,46,140,106,130,169,198,201,118,53,25,190,195,61,195,174,91,206,10,243,31,21,224,229,78,27,170,247,113,211,247,46,65,207,69,169,242,201,92,138,149,171,66,219,10,179,35,172,218,163,94,114,132,173,226,168,219,199,176,132,146,8,161,13,25,48,243,50,105,144,31,77,48,115,172,97,68,150,126,228,247,56,201,190,96,217,151,48,37,21,211,201,235,250,104,131,127,247,45,207,90,27,73,118,164,92,200,48,6,104,97,123,44,173,201,187,169,218,118,153,109,155,113,141,37,172,177,117,211,241,102,52,183,178,8,46,170,165,39,166,81,35,48,253,125,250,60,177,205,60,103,153,57,184,203,60,178,202,180,46,122,245,155,31,94,90,204,206,178,183,45,182,130,247,255,7,91,93,224,198,114,16,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBuildWorkspacesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d46c7ee3-91df-41dc-b19c-ef34d339698a"),
				Name = "BuildWorkspaces",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("55b81736-b1bd-4adb-9631-1385eba1679d"),
				Name = "node",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("898827b8-b2a2-4900-b1f3-afacc4deeb31"),
				Name = "tabHeaders",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "TabHeaderCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,111,194,48,12,61,23,105,255,193,112,64,69,66,21,119,180,73,163,155,6,135,237,52,141,195,180,67,104,140,90,17,154,169,73,152,166,209,255,190,164,105,67,194,199,216,165,86,157,231,231,231,103,239,72,5,133,88,242,106,35,62,73,134,112,11,37,167,58,232,168,24,131,253,190,249,127,31,136,111,241,204,169,98,184,160,131,15,243,252,48,123,209,128,228,141,48,133,211,155,94,177,134,216,227,25,193,207,77,47,122,37,171,57,18,138,85,202,25,195,76,22,188,4,161,86,46,45,192,182,153,250,216,0,225,1,118,90,233,87,199,159,230,5,163,143,12,183,88,74,195,242,132,114,121,246,45,54,242,71,166,222,40,108,102,235,183,179,13,135,23,248,146,148,171,82,194,29,76,236,24,209,145,162,180,66,34,113,33,113,235,178,13,243,24,100,165,108,179,166,91,80,214,118,109,25,35,233,60,72,238,41,13,160,150,32,58,54,202,255,79,14,47,13,184,214,159,26,144,9,60,21,108,106,101,0,175,91,55,66,84,40,112,205,245,144,89,14,177,177,61,243,220,129,162,188,96,91,55,218,76,233,164,219,134,136,253,234,113,184,255,145,83,127,213,176,21,231,12,242,130,82,44,143,204,232,246,165,143,114,98,173,51,92,125,139,237,202,195,129,156,31,102,154,80,81,135,143,92,47,7,78,230,77,106,218,2,206,117,209,58,117,155,77,7,169,109,180,161,62,89,107,75,168,123,228,7,230,218,110,200,91,167,81,252,239,19,92,19,93,230,14,254,15,71,175,93,160,209,240,11,175,58,105,98,30,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateItemTabHeaderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("139b5d2f-ad27-4f64-93df-674c5acde881"),
				Name = "CreateItemTabHeader",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "TabHeader"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c9d81f1e-714d-4886-8a3b-3dd3f3f9ff66"),
				Name = "node",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3e6dc37f-2b1d-4813-bab0-bae8e8f06797"),
				Name = "isSysModuleFolder",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,91,79,219,48,20,126,110,165,254,7,207,15,40,213,218,80,24,131,14,84,49,209,113,169,4,8,209,118,47,211,132,220,196,109,163,37,54,56,14,168,131,254,247,29,219,9,56,23,40,221,164,85,170,212,250,92,252,157,115,190,243,249,158,8,20,72,26,141,200,4,245,16,163,15,8,126,157,81,226,83,225,52,15,26,245,123,176,199,139,248,130,251,73,72,135,222,156,70,4,252,198,49,21,125,206,24,245,100,192,153,123,204,100,32,23,198,122,65,24,153,81,225,158,82,57,96,177,36,204,163,71,139,75,18,81,7,15,179,60,184,148,249,132,135,112,227,192,87,24,184,79,127,224,56,153,12,139,70,252,19,245,122,232,219,209,101,18,134,238,119,18,38,20,29,162,211,36,240,221,227,232,86,46,208,190,198,175,14,156,183,146,184,35,62,148,34,96,51,167,153,225,184,5,200,6,190,13,33,11,189,178,172,235,99,168,206,82,1,226,217,179,10,195,191,220,92,113,95,58,114,119,68,102,112,87,172,45,238,9,23,17,145,14,126,236,44,159,30,183,224,187,189,196,173,242,140,90,54,210,86,174,119,89,41,65,4,135,219,157,62,15,147,136,141,117,61,5,18,185,198,22,43,158,100,252,24,152,40,220,116,33,68,129,156,34,39,136,11,19,108,162,199,70,189,166,46,73,68,88,194,254,85,129,223,223,220,4,248,128,126,19,183,192,55,253,168,254,187,215,244,46,161,177,116,199,34,116,53,16,250,150,199,25,143,165,101,119,74,14,87,92,72,53,149,14,140,2,99,24,1,222,199,232,35,170,244,211,125,175,101,141,31,206,249,195,5,101,201,0,254,247,201,173,90,35,40,70,138,132,42,47,83,84,177,245,169,159,233,156,106,25,68,140,168,16,36,230,83,9,13,101,211,96,150,8,162,87,178,207,163,136,179,177,12,194,64,6,84,183,249,220,251,253,18,234,228,87,184,133,112,161,207,48,121,156,94,136,115,200,95,208,106,154,173,194,104,51,207,78,147,226,199,115,213,176,18,199,94,130,240,101,122,61,144,193,222,144,15,61,139,252,134,20,207,185,53,145,82,57,131,26,165,224,161,57,210,94,181,33,79,132,167,236,182,205,28,166,82,102,224,155,209,27,190,86,147,24,78,141,147,9,187,18,64,124,145,70,155,21,237,229,150,69,251,66,231,83,71,125,177,241,6,199,41,9,99,106,167,51,151,216,75,84,220,43,229,188,84,221,89,54,234,75,68,33,254,121,59,168,149,162,74,80,142,115,246,191,23,151,98,158,130,208,232,185,57,5,48,185,217,161,141,13,212,159,83,239,151,201,119,13,111,15,68,95,7,179,185,140,11,129,205,166,238,206,211,83,169,186,10,50,24,93,23,224,89,122,3,82,106,84,149,243,234,51,97,18,42,134,85,197,155,243,138,160,2,221,203,74,123,3,82,117,163,149,86,215,134,222,248,188,82,77,126,87,114,234,92,52,25,152,249,83,131,179,168,56,255,73,107,74,42,179,82,102,86,10,140,102,220,73,32,98,105,191,184,35,126,206,73,53,81,106,175,58,23,105,150,227,237,138,113,213,14,115,47,227,42,111,107,193,240,196,163,91,187,211,206,164,189,179,253,197,111,239,236,126,218,107,119,189,207,221,118,199,247,246,232,100,74,189,110,119,47,237,214,50,43,120,149,52,190,87,27,215,20,199,247,169,227,90,242,248,30,125,92,75,32,141,66,234,86,89,26,89,19,84,38,130,33,6,138,151,41,104,163,158,30,166,205,58,248,3,38,2,11,63,30,11,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetWorkspaceChildElementsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("17664e0f-9561-4257-895f-4ee87b2711f3"),
				Name = "GetWorkspaceChildElements",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Dictionary<string, object>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2322dcdc-3218-4ab5-acb2-eb95b64c03ad"),
				Name = "node",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,207,78,2,49,16,198,207,187,201,190,195,200,169,155,152,125,0,97,49,40,72,76,212,203,26,61,16,15,101,59,104,181,180,164,127,48,27,195,187,219,118,87,66,84,8,122,104,15,223,204,124,253,205,76,215,84,67,173,132,192,218,114,37,161,132,41,218,71,165,223,204,138,214,56,145,150,219,230,114,27,38,121,63,75,215,190,66,163,113,194,250,108,137,239,112,195,141,29,140,121,204,160,186,25,24,171,185,124,62,5,53,127,245,101,195,97,172,226,11,32,82,49,132,19,95,228,132,200,225,35,75,147,133,210,72,235,23,32,193,148,91,92,2,151,59,56,109,82,50,117,156,197,104,213,152,91,197,156,192,43,37,24,234,107,230,9,130,62,235,153,239,145,222,19,148,37,140,47,238,252,91,197,3,21,14,225,28,130,81,49,89,174,108,3,103,17,61,8,100,175,67,113,175,170,216,11,201,67,11,29,72,232,162,114,243,45,75,164,8,162,247,216,145,255,1,114,200,228,7,75,24,232,158,153,148,191,48,118,163,76,218,205,21,35,214,246,221,122,109,252,229,207,6,80,24,252,195,98,190,24,142,154,255,81,4,89,170,209,58,45,187,31,214,255,4,240,153,54,34,159,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModuleEditsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1266559f-6a64-4506-b873-66418930d499"),
				Name = "GetModuleEdits",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Dictionary<string, object>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,111,218,64,16,61,19,41,255,97,149,211,90,66,78,48,112,169,67,170,18,172,8,169,169,170,2,185,68,57,108,188,19,178,149,189,182,246,131,20,85,249,239,157,93,59,96,39,196,82,145,16,98,103,222,188,55,95,204,134,41,162,64,219,204,144,9,145,240,66,190,11,109,46,103,34,53,162,144,76,109,47,181,81,66,174,251,164,120,252,13,169,185,186,162,65,124,122,178,193,40,13,25,26,48,106,9,74,49,93,60,153,240,186,144,79,98,109,21,115,193,248,202,243,66,174,140,200,132,17,160,195,27,48,183,5,183,25,36,92,24,189,240,225,116,165,65,97,152,4,47,232,184,173,70,61,66,157,4,127,76,254,64,106,77,161,80,166,141,12,19,169,173,130,217,116,111,162,65,64,254,158,158,244,72,147,193,69,86,153,134,21,23,252,2,198,65,209,61,119,29,214,123,121,22,25,16,202,85,232,32,158,141,56,123,207,17,9,3,121,221,161,207,155,227,123,83,7,232,244,25,114,182,154,243,143,169,207,166,203,109,9,104,216,128,50,160,240,125,199,50,11,203,226,198,10,142,250,247,23,15,147,201,108,250,195,102,89,232,61,95,157,35,76,242,210,108,191,120,119,16,159,159,95,236,164,140,103,203,108,46,143,147,139,186,229,34,47,23,29,144,243,232,35,4,135,221,130,67,47,56,220,183,114,171,171,197,57,170,186,113,183,216,216,139,141,189,88,53,78,146,178,210,81,163,22,174,236,55,206,111,65,218,57,206,255,186,178,211,221,104,251,237,214,247,223,183,166,94,7,183,59,247,103,53,235,217,3,242,214,191,155,238,93,145,238,223,49,231,30,246,191,165,14,186,75,29,248,82,7,13,209,86,250,94,178,101,137,15,66,61,245,59,176,183,53,225,128,85,252,100,107,88,29,89,202,168,187,148,145,47,101,212,238,95,34,141,48,219,197,219,116,188,238,110,86,7,123,253,6,218,191,43,88,117,17,67,156,61,117,17,213,28,95,221,109,193,47,252,212,254,69,161,12,229,120,93,214,204,0,253,252,46,144,114,208,239,56,27,164,140,234,91,163,192,88,37,17,222,88,151,112,89,44,60,158,6,238,164,150,76,97,155,104,25,29,134,4,241,171,203,182,38,170,242,140,255,1,232,253,78,81,229,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAddMenuItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6af1de66-c76f-4981-9ada-7a2a1e3e14f5"),
				Name = "CreateAddMenuItem",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuItem"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("42a4632a-3a5c-4737-b210-7e5810744712"),
				Name = "caption",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("39c2cd08-16f5-4925-b224-46baf9f7f18a"),
				Name = "editPageUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b63debab-ae40-4af1-ae16-c9133493b6f3"),
				Name = "sysModuleEditId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bac42e9a-6ba3-4380-b001-5d542130a538"),
				Name = "typeColumnUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("65785293-7cc5-441a-aa66-e140a7531aab"),
				Name = "typeColumnValue",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,77,11,194,48,12,134,239,130,255,161,236,52,65,138,119,241,160,162,178,131,67,112,211,163,68,155,141,202,214,74,154,58,69,252,239,214,79,220,41,33,121,222,55,31,103,32,81,163,241,9,99,45,70,194,96,35,50,36,2,103,11,150,121,34,183,184,159,90,195,100,43,39,127,201,242,35,136,123,195,110,231,171,150,83,66,96,84,147,235,248,8,151,224,197,228,241,191,63,51,176,175,112,163,177,89,115,0,3,81,64,229,90,72,158,168,80,94,120,173,100,138,205,51,182,71,164,80,63,117,142,73,155,82,206,45,213,192,113,52,86,234,187,209,238,54,184,71,125,225,174,110,105,149,175,112,166,52,39,74,102,118,253,146,196,81,26,245,90,142,25,148,193,16,3,182,130,18,243,127,182,125,28,156,88,91,19,216,195,59,11,77,66,246,100,126,239,27,62,0,191,142,45,16,76,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillAddButtonMenuMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("86584263-ee0d-47f2-a1a0-43cb2689632b"),
				Name = "FillAddButtonMenu",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,77,143,155,48,16,61,103,165,253,15,46,135,93,80,17,234,158,179,89,169,155,77,163,72,77,181,42,155,94,218,30,92,152,36,110,193,142,140,105,132,34,254,123,199,54,73,12,228,163,71,198,111,222,188,249,228,51,43,212,227,11,75,20,19,156,202,234,177,80,146,241,85,72,196,175,223,144,168,167,39,146,139,180,204,96,146,50,85,144,17,153,130,154,31,13,126,48,188,189,177,30,164,72,36,219,40,132,216,239,104,146,111,84,117,124,94,10,153,83,21,219,143,17,241,118,31,234,72,112,255,62,201,88,242,231,62,36,203,146,27,13,62,100,1,217,237,200,238,161,38,117,29,18,181,102,69,224,33,207,95,42,73,81,21,54,122,156,172,33,167,200,179,40,64,142,5,231,96,156,163,9,87,76,85,246,117,78,57,93,129,140,80,242,76,65,254,92,125,161,57,248,94,188,231,240,180,120,148,5,52,89,19,255,124,9,156,10,16,198,221,122,160,208,219,155,129,22,150,208,141,246,70,65,199,231,239,94,99,245,126,70,111,194,102,110,10,54,152,150,44,37,128,144,87,20,184,152,165,232,198,97,75,180,217,119,253,29,72,139,227,72,130,5,113,83,190,192,213,71,158,167,60,118,248,34,159,11,59,67,166,170,13,140,69,86,230,252,130,180,22,232,42,209,55,154,149,112,157,202,192,174,165,248,31,233,157,82,164,59,158,3,47,245,88,33,193,24,71,72,193,199,52,157,55,54,191,105,124,232,54,57,236,86,54,108,87,39,236,230,104,66,237,195,68,179,28,105,26,181,56,240,74,138,204,154,244,8,14,6,177,40,101,162,223,221,55,107,108,150,194,50,135,22,237,76,75,103,167,34,45,197,128,172,219,171,100,57,46,69,187,246,78,117,44,22,215,176,1,154,192,22,141,64,37,75,64,64,173,83,233,30,136,79,230,34,248,222,150,241,84,108,35,60,8,248,134,107,63,252,193,189,240,80,223,104,156,49,224,106,246,226,152,166,192,65,98,201,155,92,99,67,236,235,88,33,225,101,150,217,46,233,186,71,216,149,231,82,41,60,13,186,57,250,211,223,211,4,142,168,247,61,85,250,62,173,240,216,33,216,15,34,154,166,166,177,123,173,15,117,96,101,118,130,156,16,187,55,29,38,71,108,128,107,183,87,42,241,32,41,144,69,211,214,243,39,200,158,141,190,35,158,136,238,78,219,238,116,86,253,156,119,111,137,221,222,90,219,57,215,13,149,24,251,184,35,232,25,67,134,98,33,221,27,181,43,91,18,191,125,4,222,141,204,182,217,255,3,185,187,235,173,118,11,96,79,236,73,5,157,179,161,167,205,181,12,47,249,245,28,76,104,237,82,95,24,10,247,31,118,114,66,117,200,55,144,146,22,98,169,34,28,207,37,91,149,56,169,236,48,26,118,86,23,138,101,76,49,40,244,207,233,43,172,240,31,12,18,167,72,75,109,166,185,117,57,250,105,180,71,188,241,177,186,245,75,253,15,232,139,171,104,215,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAddMenuItemCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a226e75c-9346-4532-b76c-85218f707649"),
				Name = "GetAddMenuItemCaption",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("36547832-becf-4d4a-9071-e29a1be4a650"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9b95524f-113f-44e2-967e-a1c97f52cf92"),
				Name = "typeColumnUId",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("32ee6257-6310-4269-92c4-d89057b61d22"),
				Name = "typeId",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,83,193,110,219,48,12,61,55,64,254,65,205,161,144,129,64,232,121,93,7,108,89,26,4,216,134,110,105,214,195,80,20,132,205,164,66,101,201,165,228,14,70,209,127,31,37,57,113,154,238,228,152,228,123,124,239,209,121,6,18,190,124,192,26,196,165,88,123,164,153,179,22,203,160,157,85,115,27,116,232,86,169,251,29,44,108,145,212,2,195,210,250,0,182,196,47,221,122,89,201,12,230,95,197,197,120,244,204,108,132,190,53,129,217,114,71,205,160,137,108,220,213,27,33,67,215,224,204,153,182,182,12,17,167,151,98,209,234,74,205,235,38,116,226,236,76,196,246,113,189,16,47,227,209,73,164,30,192,7,244,233,221,71,97,89,208,155,13,81,212,30,186,218,249,28,70,212,47,220,32,33,187,201,205,221,248,83,139,212,241,164,197,191,226,48,134,159,177,46,7,178,196,159,134,217,39,87,222,135,184,66,239,249,153,186,234,86,135,135,111,174,4,19,95,181,221,202,155,21,143,110,244,182,37,72,211,105,108,29,180,209,65,163,87,183,142,30,125,3,37,166,250,130,92,219,236,29,85,218,55,6,186,236,227,7,212,113,119,86,242,185,170,114,245,64,104,204,231,154,116,13,212,125,61,6,202,162,80,241,57,120,185,210,38,32,249,200,36,123,119,132,16,48,215,163,139,107,32,70,196,33,201,168,147,220,152,185,186,1,210,222,217,27,94,172,230,79,45,152,169,248,175,136,195,237,211,254,236,197,113,154,203,128,117,239,204,7,226,188,212,149,163,26,130,156,68,254,121,165,67,156,232,63,176,251,151,243,215,201,158,106,151,18,198,227,113,148,251,112,88,66,62,40,43,48,249,70,242,237,201,18,118,248,138,243,98,110,151,188,56,151,167,98,242,65,240,174,29,249,159,243,187,200,27,69,245,201,255,6,211,226,199,140,253,36,223,157,42,57,125,29,143,8,67,75,182,255,203,92,252,3,213,129,195,203,140,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetWorkspaceEntityCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7d943b81-ba89-412a-bd4a-760b284326dc"),
				Name = "GetWorkspaceEntityCollection",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Dictionary<string, object>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,203,10,2,49,12,69,215,10,254,67,151,10,195,252,128,15,144,17,220,232,106,70,92,199,26,53,90,155,146,166,130,127,111,103,20,69,112,225,46,175,115,200,189,129,24,8,161,2,123,66,51,53,155,136,82,177,247,104,149,216,151,243,16,28,89,104,235,238,162,220,146,158,86,108,193,181,45,249,227,112,52,30,244,87,20,117,178,160,14,1,185,79,162,74,94,21,134,119,231,236,153,205,140,96,76,78,179,190,169,179,252,64,199,36,157,179,172,248,122,101,191,81,114,164,132,177,92,162,214,232,50,180,0,133,225,160,223,251,254,167,248,71,176,230,125,114,216,192,238,105,42,222,241,126,208,237,248,3,111,89,46,49,128,197,110,190,20,78,161,141,39,168,73,252,43,196,248,1,24,76,2,47,49,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRunProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f27a7d15-43f6-410b-96be-a44766f5ab68"),
				Name = "RunProcess",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f680fd23-0ff9-46a4-af84-6823be575d49"),
				Name = "processSchemaName",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				ModifiedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,193,78,195,48,12,64,207,84,234,63,68,59,37,2,249,7,16,7,24,67,234,1,84,169,43,156,77,231,141,72,91,82,236,116,218,132,248,119,146,210,194,10,187,88,74,108,191,103,123,143,172,164,121,163,29,170,27,165,117,201,190,33,145,170,255,49,181,16,207,189,115,212,4,235,29,76,146,143,232,112,67,12,15,214,173,10,39,1,93,67,119,199,39,220,145,110,79,235,210,143,49,215,121,182,143,166,33,19,85,223,78,152,51,97,160,1,172,167,190,212,100,215,74,15,165,37,114,68,5,98,129,197,193,74,144,193,54,43,227,28,227,4,197,106,102,140,250,200,179,11,9,108,221,70,217,159,68,191,223,146,152,81,252,58,64,93,192,11,189,70,91,96,191,21,72,16,147,2,220,74,219,63,224,151,9,75,95,245,56,157,102,26,209,237,196,27,241,39,174,75,213,179,82,72,10,180,46,158,170,118,246,189,163,226,62,49,134,75,64,69,33,110,223,18,135,227,51,110,187,255,235,92,253,241,164,9,62,243,108,236,95,28,168,233,2,157,57,221,23,141,70,170,18,218,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsEnglishLocalizationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("066f5f63-eac4-4ce6-8de2-ea72c31d9cc1"),
				Name = "IsEnglishLocalization",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,204,209,10,194,32,20,0,208,95,17,159,20,50,174,155,198,32,246,32,110,236,53,24,245,62,234,18,194,186,131,171,18,251,251,213,7,156,195,88,42,147,80,83,77,47,61,239,121,198,82,18,189,243,121,194,242,88,214,138,234,158,145,227,70,132,207,146,54,58,9,121,227,244,89,120,143,117,253,81,148,90,244,189,32,252,138,127,161,100,240,174,129,198,93,12,132,110,52,163,181,214,116,46,180,6,192,122,63,128,119,17,90,169,175,7,21,169,146,106,120,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRegisterChatLinksMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("de28d1e5-5251-472f-8044-45537e7e8db6"),
				Name = "RegisterChatLinks",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,219,110,219,54,244,189,64,255,129,211,48,88,65,108,205,217,48,20,243,154,110,171,155,181,6,210,162,200,5,125,44,104,137,182,137,208,164,64,210,117,220,212,255,190,67,81,138,101,153,174,40,53,233,214,45,124,177,76,241,92,120,238,135,226,249,74,105,50,143,222,145,113,116,57,138,134,140,18,174,207,99,73,83,253,26,115,60,37,18,197,10,29,163,183,240,24,253,169,210,236,183,188,234,183,199,143,70,115,152,60,165,10,102,102,100,142,17,173,252,63,70,151,138,200,161,224,156,196,154,10,30,85,0,114,66,209,75,162,71,92,105,204,99,242,124,245,6,207,73,24,188,32,115,241,124,161,181,224,42,56,0,82,128,68,75,193,50,4,40,46,255,57,70,156,44,81,249,125,120,128,110,30,63,66,149,113,46,22,50,54,203,203,75,237,100,149,175,174,3,58,123,113,57,74,0,65,101,155,32,190,196,1,49,2,233,186,215,155,55,202,108,186,216,236,243,197,234,141,88,158,146,137,14,14,12,182,199,143,214,176,101,165,37,229,83,52,206,94,90,89,152,37,197,174,203,66,200,36,104,30,46,37,11,141,184,182,94,54,230,100,8,74,38,210,242,226,102,196,174,248,10,172,156,209,233,76,127,142,147,108,129,23,35,183,224,177,82,214,132,1,226,143,224,169,210,43,70,158,237,42,48,74,192,6,123,99,43,120,188,18,11,125,194,92,134,85,25,90,164,3,212,79,175,209,119,116,158,10,9,86,109,92,165,186,106,189,143,158,198,99,70,60,200,204,136,217,248,0,29,245,251,63,56,240,87,198,146,38,122,182,119,241,126,102,198,61,45,123,58,233,141,133,76,32,34,212,179,149,19,250,37,189,110,78,135,129,117,131,188,87,92,44,173,212,61,232,141,113,124,53,149,98,193,147,1,90,128,162,131,32,64,135,123,124,230,16,180,29,4,7,136,139,158,36,41,193,26,245,141,162,154,51,26,103,214,127,247,172,150,189,42,103,182,94,181,86,53,61,149,226,24,140,123,208,110,71,210,24,211,221,111,168,228,156,95,36,252,125,204,51,202,175,122,75,137,83,15,110,83,156,36,86,64,224,6,224,158,246,167,137,168,12,53,15,66,177,96,66,14,208,114,70,53,169,87,223,4,66,86,111,130,231,148,173,6,232,2,207,196,28,123,2,41,250,145,128,75,31,57,55,225,2,88,230,33,99,44,88,82,15,162,201,181,238,97,70,167,124,128,172,193,215,195,196,11,169,204,222,83,65,253,0,24,209,186,108,188,92,200,57,102,30,241,12,140,190,57,20,40,144,244,138,192,233,11,148,201,65,75,204,213,4,32,12,28,247,80,107,6,69,121,2,130,219,231,146,46,8,53,195,137,88,54,34,146,144,88,72,108,202,171,189,96,235,237,191,187,11,158,254,104,147,96,144,165,201,177,16,12,81,117,194,167,140,170,25,36,201,81,241,124,42,98,176,136,143,25,181,44,167,230,25,85,109,210,233,46,242,11,34,37,86,98,162,163,82,81,7,107,39,11,30,91,68,46,167,250,128,101,225,178,176,246,231,190,99,91,102,201,86,248,20,124,66,205,106,15,31,197,169,149,88,199,132,44,40,53,78,193,183,135,118,50,11,85,29,71,69,87,25,38,28,64,109,177,141,3,38,124,225,69,74,248,136,191,33,203,119,96,39,70,233,19,204,20,169,135,91,194,242,229,91,44,161,74,2,223,81,64,223,131,216,50,163,97,42,43,179,222,97,34,153,230,171,179,133,138,80,44,33,98,19,43,230,144,38,93,148,220,170,210,74,189,11,5,221,212,169,200,202,240,208,171,3,162,92,133,229,21,255,198,172,242,130,222,190,13,235,89,168,14,10,249,139,186,74,248,154,17,51,35,124,71,149,232,161,143,234,40,162,210,79,79,154,195,206,177,156,82,110,120,233,155,164,138,158,164,215,45,56,40,74,196,230,144,85,91,24,236,204,212,162,92,251,20,58,37,25,71,96,134,29,73,32,190,202,88,204,83,72,35,164,211,221,152,171,59,164,212,140,140,217,141,33,157,101,216,135,57,246,176,76,221,26,123,61,199,235,46,210,51,170,60,86,74,162,23,146,111,109,209,21,199,125,156,244,45,148,87,88,146,164,228,172,132,249,122,230,131,159,125,102,180,247,16,151,135,126,251,62,241,151,144,133,177,157,48,50,135,82,167,226,37,96,119,255,58,39,105,234,229,158,142,67,24,184,203,150,54,136,71,109,105,32,169,57,13,33,44,162,30,53,185,89,175,9,240,10,126,158,187,231,201,181,142,46,242,169,176,177,126,59,79,237,121,67,76,24,203,203,233,227,32,232,67,35,103,219,202,252,143,121,157,39,237,98,134,97,165,224,121,115,102,17,4,207,90,248,163,131,33,121,23,120,118,209,38,21,158,43,71,27,213,115,136,27,154,172,239,102,75,59,172,252,136,116,242,21,247,152,159,86,220,227,134,18,250,1,204,24,168,26,26,239,25,30,19,246,222,116,229,85,59,185,109,215,239,137,15,92,230,2,104,185,232,195,220,76,146,137,89,182,169,82,160,106,55,178,185,201,219,130,53,168,8,223,147,234,65,86,255,5,163,114,58,142,61,69,250,6,60,39,195,212,42,206,100,144,38,220,61,171,79,224,30,41,45,246,111,89,119,64,139,22,118,43,235,84,43,239,40,95,214,124,167,109,171,181,45,175,130,138,231,123,143,74,167,94,80,116,130,194,207,111,180,210,78,163,227,99,219,80,183,41,123,172,90,162,173,173,84,243,251,14,3,249,121,64,253,110,189,210,252,76,207,13,201,34,219,71,56,77,217,42,180,140,121,24,22,20,20,137,152,71,148,115,34,95,93,188,62,5,84,6,163,143,160,67,207,178,167,58,76,37,50,1,30,161,160,57,68,157,44,0,119,14,50,46,128,119,40,179,134,51,202,146,208,175,115,242,16,82,43,139,208,114,209,202,32,140,70,22,254,54,224,177,65,7,129,205,25,77,45,157,205,210,246,164,74,103,72,94,244,74,235,155,19,117,27,135,233,88,98,70,227,171,82,163,18,146,15,80,176,248,54,173,117,195,10,42,51,133,16,20,216,45,9,185,91,149,130,143,93,214,140,188,69,201,2,79,115,108,254,173,208,26,196,163,124,62,19,86,199,63,165,7,123,236,7,221,169,46,156,177,80,141,157,69,159,62,229,19,95,174,132,123,119,214,234,200,36,21,165,50,251,125,65,38,120,193,116,232,161,197,178,64,34,38,226,236,92,61,130,150,154,225,152,24,115,253,150,44,210,231,171,157,43,209,183,237,213,61,78,31,94,65,198,243,109,224,179,54,188,210,192,63,244,228,5,67,15,61,121,91,196,255,243,158,252,198,122,225,250,161,153,70,15,205,180,19,242,238,154,233,253,109,19,72,113,96,63,132,24,99,28,228,54,217,244,124,221,191,167,242,74,134,183,105,78,17,125,65,174,161,14,72,244,44,207,97,190,89,43,251,36,1,124,20,101,157,133,142,182,171,187,105,25,255,1,188,41,190,191,30,162,208,0,82,53,58,249,21,253,142,142,208,0,245,189,133,18,1,219,22,101,198,132,11,174,97,186,87,249,133,189,178,32,26,29,194,23,210,0,144,200,62,223,238,245,171,239,42,175,187,234,25,87,179,236,219,127,81,117,107,44,65,95,175,161,130,164,167,80,79,178,11,60,86,109,59,86,45,4,83,183,31,243,92,152,163,210,146,118,157,100,249,2,134,185,129,89,190,40,208,41,95,40,131,214,98,247,178,70,55,63,163,105,71,219,84,71,16,52,55,69,215,121,54,17,222,216,171,81,157,163,39,253,244,186,227,227,231,213,225,148,21,229,138,72,29,246,187,57,225,174,61,78,184,115,236,101,49,229,52,26,147,168,196,148,13,194,3,231,231,177,154,145,125,225,226,201,173,41,125,217,71,197,234,168,51,76,136,186,249,55,231,59,232,135,156,196,4,191,216,144,27,206,48,55,151,200,91,116,75,109,186,36,152,90,231,247,147,141,9,11,126,70,112,178,10,183,111,71,57,239,80,69,38,116,132,230,98,190,105,147,48,133,180,244,190,18,56,0,45,152,191,185,214,21,171,232,140,76,169,130,178,179,124,139,255,57,180,157,87,225,214,37,255,151,96,58,171,20,4,208,69,193,166,103,86,195,115,21,116,55,119,167,13,106,11,150,36,118,38,84,249,139,191,1,236,87,62,33,90,48,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsRussianLocalizationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("58ecf79a-fbf7-4013-acbe-970cd9f19758"),
				Name = "IsRussianLocalization",
				CreatedInSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,204,221,10,194,32,20,0,224,87,17,175,20,50,142,56,153,16,187,16,179,221,6,163,238,71,29,66,88,103,224,15,99,111,191,122,128,239,203,88,91,38,38,198,150,222,114,218,203,132,181,38,250,148,243,136,245,57,47,13,197,163,96,14,43,17,190,106,90,233,196,248,61,167,239,156,247,208,150,31,69,46,217,48,48,194,141,253,11,193,181,239,123,23,205,77,129,119,81,69,173,181,114,157,55,10,64,91,123,5,219,5,48,92,94,14,119,222,7,253,120,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MainPage_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"));
		}

		#endregion

	}

	#endregion

}

