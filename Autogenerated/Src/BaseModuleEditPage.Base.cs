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
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using TSWebControls = Terrasoft.UI.WebControls;

	#region Class: BaseModuleEditPageSchema

	/// <exclude/>
	public class BaseModuleEditPageSchema : Terrasoft.UI.WebControls.PageSchema
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _rightControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout RightControlLayout {
			get {
				return _rightControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _dataTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel DataTabPanel {
			get {
				return _dataTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _dataTab;
		public Terrasoft.UI.WebControls.Controls.Tab DataTab {
			get {
				return _dataTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return _buttonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _processButton;
		public Terrasoft.UI.WebControls.Controls.Button ProcessButton {
			get {
				return _processButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _printReportSpacer;
		public Terrasoft.UI.WebControls.Controls.Spacer PrintReportSpacer {
			get {
				return _printReportSpacer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _actionButton;
		public Terrasoft.UI.WebControls.Controls.Button ActionButton {
			get {
				return _actionButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _printReportButton;
		public Terrasoft.UI.WebControls.Controls.Button PrintReportButton {
			get {
				return _printReportButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _designerModeButton;
		public Terrasoft.UI.WebControls.Controls.Button DesignerModeButton {
			get {
				return _designerModeButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _dataControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout DataControlLayout {
			get {
				return _dataControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _customControls;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CustomControls {
			get {
				return _customControls;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _customControlsLeft;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CustomControlsLeft {
			get {
				return _customControlsLeft;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _customControlsRight;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CustomControlsRight {
			get {
				return _customControlsRight;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttomButtonLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtomButtonLayout {
			get {
				return _buttomButtonLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _buttomSpacer;
		public Terrasoft.UI.WebControls.Controls.Spacer ButtomSpacer {
			get {
				return _buttomSpacer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _oKButton;
		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return _oKButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _cancelButton;
		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return _cancelButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _previousButton;
		public Terrasoft.UI.WebControls.Controls.Button PreviousButton {
			get {
				return _previousButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _nextButton;
		public Terrasoft.UI.WebControls.Controls.Button NextButton {
			get {
				return _nextButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _dataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return _dataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseModuleEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseModuleEditPageSchema(BaseModuleEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			RealUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			Name = "BaseModuleEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 700;
			Height = 600;
			ValidationMessagePanel = "BaseMessagePanel";
			HelpContextId = "1abc2";
			PrimaryDataSourceName = "DataSource";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseModuleEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateRightControlLayout());
			RightControlLayout.InsertItem(0, CreateDataTabPanel());
			DataTabPanel.InsertItem(0, CreateDataTab());
			DataTab.InsertItem(0, CreateButtonsControlLayout());
			ButtonsControlLayout.InsertItem(0, CreateProcessButton());
			ButtonsControlLayout.InsertItem(1, CreatePrintReportSpacer());
			ButtonsControlLayout.InsertItem(2, CreateActionButton());
			ButtonsControlLayout.InsertItem(3, CreatePrintReportButton());
			ButtonsControlLayout.InsertItem(4, CreateDesignerModeButton());
			ButtonsControlLayout.InsertItem(5, CreateContextHelpButton());
			DataTab.InsertItem(1, CreateDataControlLayout());
			DataControlLayout.InsertItem(0, CreateCustomControls());
			CustomControls.InsertItem(0, CreateCustomControlsLeft());
			CustomControls.InsertItem(1, CreateCustomControlsRight());
			RightControlLayout.InsertItem(1, CreateButtomButtonLayout());
			ButtomButtonLayout.InsertItem(0, CreateButtomSpacer());
			ButtomButtonLayout.InsertItem(1, CreateOKButton());
			ButtomButtonLayout.InsertItem(2, CreateCancelButton());
			ButtomButtonLayout.InsertItem(3, CreatePreviousButton());
			ButtomButtonLayout.InsertItem(4, CreateNextButton());
			Controls.AddAt(2, CreateDataSource());
			UpdateDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseModuleEditPageEventsProcessSchema() {
			var schema = new BaseModuleEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("ddb22a81-bd9f-449e-8bae-0651b173c86d");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateProcessButton() {
			_processButton = new Terrasoft.UI.WebControls.Controls.Button();
			_processButton.UId = new Guid("45d34a24-62a9-49e0-84f4-bff5454a526c");
			_processButton.Name = "ProcessButton";
			_processButton.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_processButton.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_processButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_processButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_processButton.Tag = "";
			_processButton.ButtonStyle = Terrasoft.UI.WebControls.Controls.ButtonStyle.Orange;
			_processButton.Image = new ControlImage {};
			_processButton.Enabled = false;
			_processButton.Hidden = true;
			return _processButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreatePrintReportSpacer() {
			_printReportSpacer = new Terrasoft.UI.WebControls.Controls.Spacer();
			_printReportSpacer.UId = new Guid("e785e623-db26-4215-81ce-eb929d236a22");
			_printReportSpacer.Name = "PrintReportSpacer";
			_printReportSpacer.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_printReportSpacer.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_printReportSpacer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_printReportSpacer.Tag = "";
			_printReportSpacer.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _printReportSpacer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateActionButton() {
			_actionButton = new Terrasoft.UI.WebControls.Controls.Button();
			_actionButton.UId = new Guid("27b9c792-a59e-4df1-921e-9fe9813db8b7");
			_actionButton.Name = "ActionButton";
			_actionButton.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_actionButton.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_actionButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_actionButton.Tag = "";
			_actionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			_actionButton.Hidden = true;
			return _actionButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreatePrintReportButton() {
			_printReportButton = new Terrasoft.UI.WebControls.Controls.Button();
			_printReportButton.UId = new Guid("0cad010d-bac3-4f89-8a6e-e5bf79a88912");
			_printReportButton.Name = "PrintReportButton";
			_printReportButton.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_printReportButton.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_printReportButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_printReportButton.Tag = "";
			_printReportButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			_printReportButton.Hidden = true;
			return _printReportButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDesignerModeButton() {
			_designerModeButton = new Terrasoft.UI.WebControls.Controls.Button();
			_designerModeButton.UId = new Guid("234be893-ab67-4e13-b78c-dbe4d4b6cbd4");
			_designerModeButton.Name = "DesignerModeButton";
			_designerModeButton.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_designerModeButton.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_designerModeButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_designerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_designerModeButton.Tag = "";
			_designerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			_designerModeButton.Hidden = true;
			return _designerModeButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("56dbfdc8-ad14-4808-90e4-84570ddf1f75");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonsControlLayout() {
			_buttonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonsControlLayout.UId = new Guid("c29c98cd-0a59-4d91-b854-364835af6182");
			_buttonsControlLayout.Name = "ButtonsControlLayout";
			_buttonsControlLayout.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_buttonsControlLayout.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_buttonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttonsControlLayout.Tag = "";
			_buttonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttonsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_buttonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_buttonsControlLayout.FitHeightByContent = true;
			_buttonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonsControlLayout.StartNewAlignGroup = false;
			_buttonsControlLayout.Image = new ControlImage {};
			_buttonsControlLayout.Edges = "0 0 1 0";
			return _buttonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCustomControlsLeft() {
			_customControlsLeft = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_customControlsLeft.UId = new Guid("5104019c-cbdc-464d-8466-b24e1dc54d14");
			_customControlsLeft.Name = "CustomControlsLeft";
			_customControlsLeft.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_customControlsLeft.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_customControlsLeft.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customControlsLeft.Tag = "";
			_customControlsLeft.Height = System.Web.UI.WebControls.Unit.Pixel(20);
			_customControlsLeft.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_customControlsLeft.Width = System.Web.UI.WebControls.Unit.Percentage(50);
			_customControlsLeft.StartNewAlignGroup = false;
			_customControlsLeft.Image = new ControlImage {};
			_customControlsLeft.Edges = "";
			return _customControlsLeft;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCustomControlsRight() {
			_customControlsRight = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_customControlsRight.UId = new Guid("ce3df576-26d4-461b-b9db-52509812cef0");
			_customControlsRight.Name = "CustomControlsRight";
			_customControlsRight.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_customControlsRight.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_customControlsRight.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customControlsRight.Tag = "";
			_customControlsRight.Height = System.Web.UI.WebControls.Unit.Pixel(20);
			_customControlsRight.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_customControlsRight.Width = System.Web.UI.WebControls.Unit.Percentage(50);
			_customControlsRight.StartNewAlignGroup = false;
			_customControlsRight.Image = new ControlImage {};
			_customControlsRight.Edges = "";
			return _customControlsRight;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCustomControls() {
			_customControls = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_customControls.UId = new Guid("c70b2cd3-945d-4599-88a0-ef425b59f149");
			_customControls.Name = "CustomControls";
			_customControls.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_customControls.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_customControls.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customControls.Tag = "";
			_customControls.Height = System.Web.UI.WebControls.Unit.Pixel(100);
			_customControls.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_customControls.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_customControls.FitHeightByContent = true;
			_customControls.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_customControls.StartNewAlignGroup = false;
			_customControls.Image = new ControlImage {};
			_customControls.Edges = "";
			return _customControls;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateDataControlLayout() {
			_dataControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_dataControlLayout.UId = new Guid("e7ada0d0-f97f-41dc-9e9e-7b9b5d9dfa57");
			_dataControlLayout.Name = "DataControlLayout";
			_dataControlLayout.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_dataControlLayout.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_dataControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataControlLayout.Tag = "";
			_dataControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_dataControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_dataControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_dataControlLayout.Padding = "5 5 5 5";
			_dataControlLayout.StartNewAlignGroup = false;
			_dataControlLayout.Image = new ControlImage {};
			_dataControlLayout.Edges = "";
			_dataControlLayout.AutoScroll = true;
			return _dataControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateDataTab() {
			_dataTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_dataTab.UId = new Guid("2c271c93-4d17-406f-8512-3134c83a677f");
			_dataTab.Name = "DataTab";
			_dataTab.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_dataTab.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_dataTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataTab.Tag = "";
			_dataTab.Image = new ControlImage {};
			return _dataTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateDataTabPanel() {
			_dataTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_dataTabPanel.UId = new Guid("51f73c4e-8a6b-45dd-8940-13972da107e4");
			_dataTabPanel.Name = "DataTabPanel";
			_dataTabPanel.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_dataTabPanel.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_dataTabPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			_dataTabPanel.AjaxEvents.TabChange.ShowLoadMask = true;
			_dataTabPanel.Tag = "";
			_dataTabPanel.ActiveTabIndex = 0;
			_dataTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(70);
			_dataTabPanel.StartNewAlignGroup = false;
			_dataTabPanel.Collapsible = false;
			_dataTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _dataTabPanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateButtomSpacer() {
			_buttomSpacer = new Terrasoft.UI.WebControls.Controls.Spacer();
			_buttomSpacer.UId = new Guid("7651f7ec-2807-48af-84ee-96d706b59cf3");
			_buttomSpacer.Name = "ButtomSpacer";
			_buttomSpacer.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_buttomSpacer.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_buttomSpacer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttomSpacer.Tag = "";
			_buttomSpacer.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _buttomSpacer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOKButton() {
			_oKButton = new Terrasoft.UI.WebControls.Controls.Button();
			_oKButton.UId = new Guid("4e2f5e8c-d695-40f2-b8de-7b50bb3b99a1");
			_oKButton.Name = "OKButton";
			_oKButton.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_oKButton.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_oKButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_oKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_oKButton.Tag = "";
			_oKButton.Image = new ControlImage {};
			return _oKButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("bdb022ae-4c39-4883-982a-fd485ed4755f");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_cancelButton.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreatePreviousButton() {
			_previousButton = new Terrasoft.UI.WebControls.Controls.Button();
			_previousButton.UId = new Guid("3645b58c-aa94-4885-819c-dfb8b408fc34");
			_previousButton.Name = "PreviousButton";
			_previousButton.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_previousButton.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_previousButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_previousButton.Tag = "PreviousButtonClick";
			_previousButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"878d2b559c59f5abb6da19fa97e8de3a"
			};
			_previousButton.Width = System.Web.UI.WebControls.Unit.Pixel(10);
			_previousButton.Margins = "0 5 0 10";
			return _previousButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateNextButton() {
			_nextButton = new Terrasoft.UI.WebControls.Controls.Button();
			_nextButton.UId = new Guid("46f44b8c-0529-4f6a-8ff2-7bf59c144fae");
			_nextButton.Name = "NextButton";
			_nextButton.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_nextButton.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_nextButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nextButton.Tag = "NextButtonClick";
			_nextButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"a1e02f8527246df01dbf39bb2f002db4"
			};
			return _nextButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtomButtonLayout() {
			_buttomButtonLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttomButtonLayout.UId = new Guid("f3b612c5-0aee-47f8-a1c2-ccd3ec171ea8");
			_buttomButtonLayout.Name = "ButtomButtonLayout";
			_buttomButtonLayout.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_buttomButtonLayout.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_buttomButtonLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttomButtonLayout.Tag = "";
			_buttomButtonLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttomButtonLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_buttomButtonLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_buttomButtonLayout.FitHeightByContent = true;
			_buttomButtonLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttomButtonLayout.StartNewAlignGroup = false;
			_buttomButtonLayout.Image = new ControlImage {};
			_buttomButtonLayout.Edges = "";
			return _buttomButtonLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateRightControlLayout() {
			_rightControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_rightControlLayout.UId = new Guid("dfb991a8-8e82-43c9-ac04-e1e43af7b433");
			_rightControlLayout.Name = "RightControlLayout";
			_rightControlLayout.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_rightControlLayout.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
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
			_mainControlLayout.UId = new Guid("591cec09-9222-4a13-8468-1be6951b74a8");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			_mainControlLayout.HasSplitter = true;
			return _mainControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateDataSource() {
			_dataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_dataSource.UId = new Guid("524833fb-7d83-48d5-965d-e49b1e5c5aeb");
			_dataSource.Name = "DataSource";
			_dataSource.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_dataSource.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_dataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataSource.Tag = "";
			_dataSource.EnableServerActiveRow = false;
			_dataSource.SchemaUId = Guid.Empty;
			_dataSource.HierarchicalDepth = 1;
			_dataSource.DefStructure.ID = "c" + _dataSource.DefStructure.UId.ToString("N");
			_dataSource.DefStructure.UId = new Guid("8bf70b53-9ca0-499c-9e75-939ad2e17c72");
			_dataSource.DefStructure.Name = "DefStructure";
			_dataSource.DefStructure.CreatedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			_dataSource.DefStructure.ModifiedInSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			return _dataSource;
		}

		protected virtual void UpdateDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseModuleEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseModuleEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseModuleEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseModuleEditPageEventsProcess

	/// <exclude/>
	public class BaseModuleEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseModuleEditPageSchemaUserControl
	{

		#region Class: SaveYesNoTaskFlowElement

		/// <exclude/>
		public class SaveYesNoTaskFlowElement : QuestionUserTask
		{

			public SaveYesNoTaskFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveYesNoTask";
				IsLogging = false;
				SchemaElementUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenPageSchemaDesigner_UserTaskFlowElement

		/// <exclude/>
		public class OpenPageSchemaDesigner_UserTaskFlowElement : OpenPageUserTask
		{

			public OpenPageSchemaDesigner_UserTaskFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenPageSchemaDesigner_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenMessageUserTaskFlowElement

		/// <exclude/>
		public class OpenMessageUserTaskFlowElement : QuestionUserTask
		{

			public OpenMessageUserTaskFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("83718572-58e9-4591-a706-0ee32efba470");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenContinueMessageUserTaskFlowElement

		/// <exclude/>
		public class OpenContinueMessageUserTaskFlowElement : QuestionUserTask
		{

			public OpenContinueMessageUserTaskFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenContinueMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenSelectProcessUserTaskFlowElement

		/// <exclude/>
		public class OpenSelectProcessUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenSelectProcessUserTaskFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenSelectProcessUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("b7cf7a53-7bd3-443b-9d16-15ff652bd592");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: MessageWindowUserTaskFlowElement

		/// <exclude/>
		public class MessageWindowUserTaskFlowElement : QuestionUserTask
		{

			public MessageWindowUserTaskFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "MessageWindowUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: SyncRecentEntityUserTaskPLCFlowElement

		/// <exclude/>
		public class SyncRecentEntityUserTaskPLCFlowElement : SyncronizeRecentEntityUserTask
		{

			public SyncRecentEntityUserTaskPLCFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SyncRecentEntityUserTaskPLC";
				IsLogging = false;
				SchemaElementUId = new Guid("bef3d290-08e9-450b-9f21-64bba5311e35");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: SetDetailFilterFlowElement

		/// <exclude/>
		public class SetDetailFilterFlowElement : SetDetailFilter
		{

			public SetDetailFilterFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SetDetailFilter";
				IsLogging = false;
				SchemaElementUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: EditInitializeDetailsFlowElement

		/// <exclude/>
		public class EditInitializeDetailsFlowElement : InitializeDetails
		{

			public EditInitializeDetailsFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "EditInitializeDetails";
				IsLogging = false;
				SchemaElementUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskOpenPrintReportPageFlowElement

		/// <exclude/>
		public class UserTaskOpenPrintReportPageFlowElement : OpenPageUserTask
		{

			public UserTaskOpenPrintReportPageFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskOpenPrintReportPage";
				IsLogging = false;
				SchemaElementUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: LoadPrintReportButtonMenuProcessFlowElement

		/// <exclude/>
		public class LoadPrintReportButtonMenuProcessFlowElement : LoadPrintMenuProcess
		{

			public LoadPrintReportButtonMenuProcessFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessFlowElement";
				Name = "LoadPrintReportButtonMenuProcess";
				SerializeToDB = false;
				IsLogging = false;
				SchemaElementUId = new Guid("41088c29-9e6e-4b69-b8e4-f6069f688ffa");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: CheckSaveBeforePrintFlowElement

		/// <exclude/>
		public class CheckSaveBeforePrintFlowElement : QuestionUserTask
		{

			public CheckSaveBeforePrintFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CheckSaveBeforePrint";
				IsLogging = false;
				SchemaElementUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ConfirmIncludeInFolderFlowElement

		/// <exclude/>
		public class ConfirmIncludeInFolderFlowElement : QuestionUserTask
		{

			public ConfirmIncludeInFolderFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ConfirmIncludeInFolder";
				IsLogging = false;
				SchemaElementUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: TreeGridLoadRowUserTaskFlowElement

		/// <exclude/>
		public class TreeGridLoadRowUserTaskFlowElement : TreeGridLoadRowUserTask
		{

			public TreeGridLoadRowUserTaskFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "TreeGridLoadRowUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("b2e4ba66-8b06-44c3-934a-e7d88d510a00");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: SyncRecentEntityUserTaskDSSFlowElement

		/// <exclude/>
		public class SyncRecentEntityUserTaskDSSFlowElement : SyncronizeRecentEntityUserTask
		{

			public SyncRecentEntityUserTaskDSSFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SyncRecentEntityUserTaskDSS";
				IsLogging = false;
				SchemaElementUId = new Guid("765a52e9-f0ca-4bd8-812e-bf61ba1bed78");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: BaseParallelGateway1FlowElement

		/// <exclude/>
		public class BaseParallelGateway1FlowElement : ProcessParallelGateway
		{

			public BaseParallelGateway1FlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "BaseParallelGateway1";
				IsLogging = false;
				SchemaElementUId = new Guid("77f615c2-6c64-4611-8dc6-cd89889047e0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				PreviousFlowElements = new Collection<string> { "ScriptBeforeClose", };
			}

		}

		#endregion

		#region Class: AllowAddDetailUserTaskFlowElement

		/// <exclude/>
		public class AllowAddDetailUserTaskFlowElement : QuestionUserTask
		{

			public AllowAddDetailUserTaskFlowElement(UserConnection userConnection, BaseModuleEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AllowAddDetailUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f");
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

		public BaseModuleEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseModuleEditPageEventsProcess";
			SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
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

		public virtual Object DataSourceFilter {
			get;
			set;
		}

		public virtual Guid EntityPrimaryColumnValue {
			get;
			set;
		}

		public virtual string ActionAfterSaved {
			get;
			set;
		}

		public virtual string DetailFilterColumnName {
			get;
			set;
		}

		public virtual string FilterLeftExpression {
			get;
			set;
		}

		public virtual Object DefaultParameters {
			get;
			set;
		}

		public virtual Guid SysModuleId {
			get;
			set;
		}

		public virtual bool HasDetails {
			get;
			set;
		}

		public virtual bool IsWindowClose {
			get;
			set;
		}

		public virtual Guid SelectedFolderId {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual bool IsCopy {
			get;
			set;
		}

		public virtual bool DoIncludeInSelectedFolder {
			get;
			set;
		}

		public virtual bool NeedSendDetailAllowMessage {
			get;
			set;
		}

		public virtual Guid PrintReportSchemaUId {
			get;
			set;
		}

		public virtual Guid PrintReportOptionsSchemaUId {
			get;
			set;
		}

		public virtual bool NotRecivePrintReportMenu {
			get;
			set;
		}

		public virtual bool NeedTreeGridRefresh {
			get;
			set;
		}

		public virtual Object SuccesfullCloseMessage {
			get;
			set;
		}

		public virtual string PrimaryDisplayColumnValue {
			get;
			set;
		}

		public virtual Guid PrimaryColumnValue {
			get;
			set;
		}

		public virtual int NotesTabIndex {
			get;
			set;
		}

		public virtual bool IsEdit {
			get;
			set;
		}

		public virtual bool UseModuleDetails {
			get;
			set;
		}

		public virtual bool ParametersInitialized {
			get;
			set;
		}

		public virtual Object ModuleProcesses {
			get;
			set;
		}

		public virtual Object ModuleProcessesCaption {
			get;
			set;
		}

		private string _menuHelpItemCaption;
		public virtual string MenuHelpItemCaption {
			get {
				return _menuHelpItemCaption ?? (_menuHelpItemCaption = new LocalizableString(Storage, "d291b989e7374e5d883fff3a6d5aea01",
						 "EventsProcessSchema.Parameters.MenuHelpItemCaption.Value"));
			}
			set {
				_menuHelpItemCaption = value;
			}
		}

		private string _menuVideoHelpItemCaption;
		public virtual string MenuVideoHelpItemCaption {
			get {
				return _menuVideoHelpItemCaption ?? (_menuVideoHelpItemCaption = new LocalizableString(Storage, "d291b989e7374e5d883fff3a6d5aea01",
						 "EventsProcessSchema.Parameters.MenuVideoHelpItemCaption.Value"));
			}
			set {
				_menuVideoHelpItemCaption = value;
			}
		}

		public virtual string BlockedSchemaMessageText {
			get;
			set;
		}

		public virtual bool IsSchemaBlocked {
			get;
			set;
		}

		public virtual Object ParentGridStructure {
			get;
			set;
		}

		public virtual int PageRowsCount {
			get;
			set;
		}

		public virtual Object PageableDirection {
			get;
			set;
		}

		public virtual string StructureStoreKey {
			get;
			set;
		}

		public virtual bool NeedSave {
			get;
			set;
		}

		public virtual bool IsValidPage {
			get;
			set;
		}

		public virtual Object DataSourceStructure {
			get;
			set;
		}

		public virtual Object DataSourceFilters {
			get;
			set;
		}

		public virtual bool MustSaveBeforePrint {
			get;
			set;
		}

		private ProcessFlowElement _pagingEventSubProcess;
		public ProcessFlowElement PagingEventSubProcess {
			get {
				return _pagingEventSubProcess ?? (_pagingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PagingEventSubProcess",
					SchemaElementUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _nextButtonClickStartMessage;
		public ProcessFlowElement NextButtonClickStartMessage {
			get {
				return _nextButtonClickStartMessage ?? (_nextButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "NextButtonClickStartMessage",
					SchemaElementUId = new Guid("6b2342e6-06b7-418c-b188-cb6c8027e9c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _nextButtonClickScript;
		public ProcessScriptTask NextButtonClickScript {
			get {
				return _nextButtonClickScript ?? (_nextButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NextButtonClickScript",
					SchemaElementUId = new Guid("ba556e26-fe0e-4e3c-bccd-036300d9ea9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NextButtonClickScriptExecute,
				});
			}
		}

		private ProcessExclusiveGateway _isModifyExclusiveGateway;
		public ProcessExclusiveGateway IsModifyExclusiveGateway {
			get {
				return _isModifyExclusiveGateway ?? (_isModifyExclusiveGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "IsModifyExclusiveGateway",
					SchemaElementUId = new Guid("4b47d545-f464-4a58-ae59-953d479e2fab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.IsModifyExclusiveGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _scriptPreviousButtonClick;
		public ProcessScriptTask ScriptPreviousButtonClick {
			get {
				return _scriptPreviousButtonClick ?? (_scriptPreviousButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPreviousButtonClick",
					SchemaElementUId = new Guid("18db9e4a-3a1c-45b9-8aeb-cc28228707d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPreviousButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _previousButtonClickStartMessage;
		public ProcessFlowElement PreviousButtonClickStartMessage {
			get {
				return _previousButtonClickStartMessage ?? (_previousButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PreviousButtonClickStartMessage",
					SchemaElementUId = new Guid("0c794987-d68b-4dcf-b52f-a1f36186d0ac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _prepareSaveYesNoScriptTask;
		public ProcessScriptTask PrepareSaveYesNoScriptTask {
			get {
				return _prepareSaveYesNoScriptTask ?? (_prepareSaveYesNoScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareSaveYesNoScriptTask",
					SchemaElementUId = new Guid("7a7fe002-f782-4bd4-97b5-eddd35361816"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareSaveYesNoScriptTaskExecute,
				});
			}
		}

		private SaveYesNoTaskFlowElement _saveYesNoTask;
		public SaveYesNoTaskFlowElement SaveYesNoTask {
			get {
				return _saveYesNoTask ?? (_saveYesNoTask = new SaveYesNoTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _pagingScript;
		public ProcessScriptTask PagingScript {
			get {
				return _pagingScript ?? (_pagingScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PagingScript",
					SchemaElementUId = new Guid("3ce935f6-3bab-40cc-a67c-b486214157e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PagingScriptExecute,
				});
			}
		}

		private ProcessScriptTask _saveChangesScript;
		public ProcessScriptTask SaveChangesScript {
			get {
				return _saveChangesScript ?? (_saveChangesScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveChangesScript",
					SchemaElementUId = new Guid("d859723c-b83b-4106-88df-5786a04ef697"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveChangesScriptExecute,
				});
			}
		}

		private ProcessFlowElement _noMsgStartMessage;
		public ProcessFlowElement NoMsgStartMessage {
			get {
				return _noMsgStartMessage ?? (_noMsgStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "NoMsgStartMessage",
					SchemaElementUId = new Guid("e1dd6c29-0626-4671-ad45-2cae485bef43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _yesMsgStartMessage;
		public ProcessFlowElement YesMsgStartMessage {
			get {
				return _yesMsgStartMessage ?? (_yesMsgStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "YesMsgStartMessage",
					SchemaElementUId = new Guid("98ff0581-cb40-47e1-bdcf-461a0a646c43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2301;
		public ProcessFlowElement EventSubProcess2301 {
			get {
				return _eventSubProcess2301 ?? (_eventSubProcess2301 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2301",
					SchemaElementUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _designerModeButtonClick;
		public ProcessFlowElement DesignerModeButtonClick {
			get {
				return _designerModeButtonClick ?? (_designerModeButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DesignerModeButtonClick",
					SchemaElementUId = new Guid("bc7d014a-726b-4724-bd88-48ea228feff3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDesignerModeButtonClick;
		public ProcessScriptTask ScriptDesignerModeButtonClick {
			get {
				return _scriptDesignerModeButtonClick ?? (_scriptDesignerModeButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDesignerModeButtonClick",
					SchemaElementUId = new Guid("077d7255-2510-41b9-856c-f0840fe16492"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDesignerModeButtonClickExecute,
				});
			}
		}

		private OpenPageSchemaDesigner_UserTaskFlowElement _openPageSchemaDesigner_UserTask;
		public OpenPageSchemaDesigner_UserTaskFlowElement OpenPageSchemaDesigner_UserTask {
			get {
				return _openPageSchemaDesigner_UserTask ?? (_openPageSchemaDesigner_UserTask = new OpenPageSchemaDesigner_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _getIsEntitySchemaBlockedScriptTask;
		public ProcessScriptTask GetIsEntitySchemaBlockedScriptTask {
			get {
				return _getIsEntitySchemaBlockedScriptTask ?? (_getIsEntitySchemaBlockedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GetIsEntitySchemaBlockedScriptTask",
					SchemaElementUId = new Guid("7571c1a4-f42b-4b95-885f-f1b487b06196"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = GetIsEntitySchemaBlockedScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2301;
		public ProcessExclusiveGateway ExclusiveGateway2301 {
			get {
				return _exclusiveGateway2301 ?? (_exclusiveGateway2301 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2301",
					SchemaElementUId = new Guid("266cbed8-e88c-4aab-ad83-26bdca48c4d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway2301.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private OpenMessageUserTaskFlowElement _openMessageUserTask;
		public OpenMessageUserTaskFlowElement OpenMessageUserTask {
			get {
				return _openMessageUserTask ?? (_openMessageUserTask = new OpenMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _openMessageScriptTask;
		public ProcessScriptTask OpenMessageScriptTask {
			get {
				return _openMessageScriptTask ?? (_openMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpenMessageScriptTask",
					SchemaElementUId = new Guid("5c84b997-fbed-4bfe-a763-3162d4ff9601"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpenMessageScriptTaskExecute,
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEvent2301;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEvent2301 {
			get {
				return _intermediateCatchMessageEvent2301 ?? (_intermediateCatchMessageEvent2301 = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEvent2301",
					SchemaElementUId = new Guid("e104620f-dd2d-43c0-a3d6-cacea339499f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "NoOpenSchema",
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEvent2302;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEvent2302 {
			get {
				return _intermediateCatchMessageEvent2302 ?? (_intermediateCatchMessageEvent2302 = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEvent2302",
					SchemaElementUId = new Guid("765e93b8-4612-416b-9c4d-fafec32bb007"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "YesOpenSchema",
				});
			}
		}

		private ProcessEndEvent _end2301;
		public ProcessEndEvent End2301 {
			get {
				return _end2301 ?? (_end2301 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End2301",
					SchemaElementUId = new Guid("d52582ac-3138-4b51-9285-cd7ad47b42d4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _isSavedEntityExclusiveGateway;
		public ProcessExclusiveGateway IsSavedEntityExclusiveGateway {
			get {
				return _isSavedEntityExclusiveGateway ?? (_isSavedEntityExclusiveGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "IsSavedEntityExclusiveGateway",
					SchemaElementUId = new Guid("05510bb0-d74e-4d30-94c5-6563a8c5850d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.IsSavedEntityExclusiveGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _prepareUserTaskParametersScriptTask;
		public ProcessScriptTask PrepareUserTaskParametersScriptTask {
			get {
				return _prepareUserTaskParametersScriptTask ?? (_prepareUserTaskParametersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareUserTaskParametersScriptTask",
					SchemaElementUId = new Guid("96be1385-3f53-46da-8b41-e24e6209ce31"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareUserTaskParametersScriptTaskExecute,
				});
			}
		}

		private OpenContinueMessageUserTaskFlowElement _openContinueMessageUserTask;
		public OpenContinueMessageUserTaskFlowElement OpenContinueMessageUserTask {
			get {
				return _openContinueMessageUserTask ?? (_openContinueMessageUserTask = new OpenContinueMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessEndEvent _noContinueExit;
		public ProcessEndEvent NoContinueExit {
			get {
				return _noContinueExit ?? (_noContinueExit = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "NoContinueExit",
					SchemaElementUId = new Guid("0284c2bd-2ccb-4349-b37c-969dba234090"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _notContinueIntermediateCatchMessageEvent;
		public ProcessIntermediateCatchMessageEvent NotContinueIntermediateCatchMessageEvent {
			get {
				return _notContinueIntermediateCatchMessageEvent ?? (_notContinueIntermediateCatchMessageEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "NotContinueIntermediateCatchMessageEvent",
					SchemaElementUId = new Guid("03415cb1-68df-43bb-92bc-b0242d8dc10f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "NoContinueOpenSchema",
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _yesContinueIntermediateCatchMessageEvent;
		public ProcessIntermediateCatchMessageEvent YesContinueIntermediateCatchMessageEvent {
			get {
				return _yesContinueIntermediateCatchMessageEvent ?? (_yesContinueIntermediateCatchMessageEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "YesContinueIntermediateCatchMessageEvent",
					SchemaElementUId = new Guid("e5c2047b-2570-46a8-bb22-cdfdd34df672"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "YesContinueOpenSchema",
				});
			}
		}

		private ProcessFlowElement _eventSubProcessRunModuleProcess;
		public ProcessFlowElement EventSubProcessRunModuleProcess {
			get {
				return _eventSubProcessRunModuleProcess ?? (_eventSubProcessRunModuleProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessRunModuleProcess",
					SchemaElementUId = new Guid("c77aa29b-eb78-41be-81ee-6c435e16cb6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startRunModuleProcess;
		public ProcessFlowElement StartRunModuleProcess {
			get {
				return _startRunModuleProcess ?? (_startRunModuleProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartRunModuleProcess",
					SchemaElementUId = new Guid("bff1c977-c851-4f23-9821-53c600d5c766"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptRunModuleProcess;
		public ProcessScriptTask ScriptRunModuleProcess {
			get {
				return _scriptRunModuleProcess ?? (_scriptRunModuleProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptRunModuleProcess",
					SchemaElementUId = new Guid("ca0cd4b8-0665-43bd-a0f7-36b438c2f2f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptRunModuleProcessExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessProcessButtonClick;
		public ProcessFlowElement EventSubProcessProcessButtonClick {
			get {
				return _eventSubProcessProcessButtonClick ?? (_eventSubProcessProcessButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessProcessButtonClick",
					SchemaElementUId = new Guid("a9145d59-d3df-4820-9f30-c3798ae554d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startProcessButtonClick;
		public ProcessFlowElement StartProcessButtonClick {
			get {
				return _startProcessButtonClick ?? (_startProcessButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartProcessButtonClick",
					SchemaElementUId = new Guid("7ddd3473-03aa-47bf-a146-4298a73dd8ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptProcessButtonClick;
		public ProcessScriptTask ScriptProcessButtonClick {
			get {
				return _scriptProcessButtonClick ?? (_scriptProcessButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptProcessButtonClick",
					SchemaElementUId = new Guid("e2dd47b9-d1ee-4a25-a126-8df61fdb8130"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptProcessButtonClickExecute,
				});
			}
		}

		private OpenSelectProcessUserTaskFlowElement _openSelectProcessUserTask;
		public OpenSelectProcessUserTaskFlowElement OpenSelectProcessUserTask {
			get {
				return _openSelectProcessUserTask ?? (_openSelectProcessUserTask = new OpenSelectProcessUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptRunSelectedProcess;
		public ProcessScriptTask ScriptRunSelectedProcess {
			get {
				return _scriptRunSelectedProcess ?? (_scriptRunSelectedProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptRunSelectedProcess",
					SchemaElementUId = new Guid("97dcfd98-b758-4c7b-9d1e-b3906162ac4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptRunSelectedProcessExecute,
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEventProcessSelected;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEventProcessSelected {
			get {
				return _intermediateCatchMessageEventProcessSelected ?? (_intermediateCatchMessageEventProcessSelected = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEventProcessSelected",
					SchemaElementUId = new Guid("b3020b96-47b4-48ea-b412-c755340c3b36"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ProcessSelected",
				});
			}
		}

		private ProcessFlowElement _eventSubProcessShowMessage;
		public ProcessFlowElement EventSubProcessShowMessage {
			get {
				return _eventSubProcessShowMessage ?? (_eventSubProcessShowMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessShowMessage",
					SchemaElementUId = new Guid("3e311213-c1c7-4e11-90ae-9678aa8d2c21"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startShowMessage;
		public ProcessFlowElement StartShowMessage {
			get {
				return _startShowMessage ?? (_startShowMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartShowMessage",
					SchemaElementUId = new Guid("0910f651-c639-4fb5-b854-0f2cbf7a2714"),
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
					SchemaElementUId = new Guid("6f1abc56-5a1f-490a-bf17-33ad13f78f4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskHidePrinElements;
		public ProcessScriptTask ScriptTaskHidePrinElements {
			get {
				return _scriptTaskHidePrinElements ?? (_scriptTaskHidePrinElements = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskHidePrinElements",
					SchemaElementUId = new Guid("cec09f9a-d52a-4bf2-a29f-d366e039e075"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskHidePrinElementsExecute,
				});
			}
		}

		private SyncRecentEntityUserTaskPLCFlowElement _syncRecentEntityUserTaskPLC;
		public SyncRecentEntityUserTaskPLCFlowElement SyncRecentEntityUserTaskPLC {
			get {
				return _syncRecentEntityUserTaskPLC ?? (_syncRecentEntityUserTaskPLC = new SyncRecentEntityUserTaskPLCFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _syncPreparePLC;
		public ProcessScriptTask SyncPreparePLC {
			get {
				return _syncPreparePLC ?? (_syncPreparePLC = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SyncPreparePLC",
					SchemaElementUId = new Guid("d76fe3d0-2db0-48e6-a081-9b448a563b58"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SyncPreparePLCExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwDataTabPanelTabChange;
		public ProcessThrowMessageEvent ThrowDataTabPanelTabChange {
			get {
				return _throwDataTabPanelTabChange ?? (_throwDataTabPanelTabChange = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowDataTabPanelTabChange",
					SchemaElementUId = new Guid("40fa767c-6dec-4744-b2a1-f3c1d82fbb63"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataTabPanelTabChange",
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
					SchemaElementUId = new Guid("069dd4ac-7a30-4a82-936a-3332f1da27fc"),
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
					SchemaElementUId = new Guid("9e8b9bbd-a1ad-4208-86ca-9a2c83b8fa7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteExecute,
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
					SchemaElementUId = new Guid("b871e078-7b92-43d8-801b-96c6837511c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClick;
		public ProcessFlowElement OKButtonClick {
			get {
				return _oKButtonClick ?? (_oKButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClick",
					SchemaElementUId = new Guid("8590fa66-a8ef-4cc2-8d5c-0b41603c4de9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOKButtonClick;
		public ProcessScriptTask ScriptOKButtonClick {
			get {
				return _scriptOKButtonClick ?? (_scriptOKButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOKButtonClick",
					SchemaElementUId = new Guid("14493f34-45a0-4557-a526-6d82ce3a7e49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOKButtonClickExecute,
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
					SchemaElementUId = new Guid("db94ee31-f526-4156-ab8c-aa8435f9876f"),
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

		private ProcessScriptTask _scriptTaskSetDefDetailsUserTask;
		public ProcessScriptTask ScriptTaskSetDefDetailsUserTask {
			get {
				return _scriptTaskSetDefDetailsUserTask ?? (_scriptTaskSetDefDetailsUserTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSetDefDetailsUserTask",
					SchemaElementUId = new Guid("7ac53080-8296-43dc-a026-301ee9b54422"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSetDefDetailsUserTaskExecute,
				});
			}
		}

		private ProcessFlowElement _dataTabPanelTabChange;
		public ProcessFlowElement DataTabPanelTabChange {
			get {
				return _dataTabPanelTabChange ?? (_dataTabPanelTabChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataTabPanelTabChange",
					SchemaElementUId = new Guid("43901eca-38a6-41a9-98a3-a95bb834c2a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataTabPanelTabChange;
		public ProcessScriptTask ScriptDataTabPanelTabChange {
			get {
				return _scriptDataTabPanelTabChange ?? (_scriptDataTabPanelTabChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataTabPanelTabChange",
					SchemaElementUId = new Guid("a526974d-956a-40f2-aff2-5fbe43308a8e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataTabPanelTabChangeExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway41234677;
		public ProcessExclusiveGateway ExclusiveGateway41234677 {
			get {
				return _exclusiveGateway41234677 ?? (_exclusiveGateway41234677 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway41234677",
					SchemaElementUId = new Guid("f83f1eff-b917-4764-89e9-d596bb7b68ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway41234677.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
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
					SchemaElementUId = new Guid("14063a14-6b8c-4e0f-927b-2203693fb7ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("b48608ba-3487-4c36-9bb4-c42abc0f6f54"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseModuleEditInit;
		public ProcessFlowElement BaseModuleEditInit {
			get {
				return _baseModuleEditInit ?? (_baseModuleEditInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseModuleEditInit",
					SchemaElementUId = new Guid("8672cbb6-8e15-40e3-91f1-626ddd103911"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageInit;
		public ProcessScriptTask ScriptPageInit {
			get {
				return _scriptPageInit ?? (_scriptPageInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageInit",
					SchemaElementUId = new Guid("834c4cb1-dca2-4c80-8830-e1d4119418fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageInitExecute,
				});
			}
		}

		private EditInitializeDetailsFlowElement _editInitializeDetails;
		public EditInitializeDetailsFlowElement EditInitializeDetails {
			get {
				return _editInitializeDetails ?? (_editInitializeDetails = new EditInitializeDetailsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("aff55c23-fd01-4bc7-872d-70b54c1dbe36"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _subProcesOpenPrintReport;
		public ProcessFlowElement SubProcesOpenPrintReport {
			get {
				return _subProcesOpenPrintReport ?? (_subProcesOpenPrintReport = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcesOpenPrintReport",
					SchemaElementUId = new Guid("0105cfb5-dc5e-410e-a661-10413b2ebe96"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPrepareParametersPrintReoprtOpen;
		public ProcessScriptTask ScriptTaskPrepareParametersPrintReoprtOpen {
			get {
				return _scriptTaskPrepareParametersPrintReoprtOpen ?? (_scriptTaskPrepareParametersPrintReoprtOpen = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPrepareParametersPrintReoprtOpen",
					SchemaElementUId = new Guid("6fad93c0-f093-4d88-abdf-9ebfb581ab7f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPrepareParametersPrintReoprtOpenExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTaskClearPrintUserContext;
		public ProcessScriptTask ScriptTaskClearPrintUserContext {
			get {
				return _scriptTaskClearPrintUserContext ?? (_scriptTaskClearPrintUserContext = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskClearPrintUserContext",
					SchemaElementUId = new Guid("1419b1ad-f4d7-45fc-8dd8-6c8fbce49ca8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskClearPrintUserContextExecute,
				});
			}
		}

		private ProcessFlowElement _startMessagePrintButtonClick;
		public ProcessFlowElement StartMessagePrintButtonClick {
			get {
				return _startMessagePrintButtonClick ?? (_startMessagePrintButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessagePrintButtonClick",
					SchemaElementUId = new Guid("47bf5540-cec5-4f31-b490-ad7d964a6cdf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("df045715-ab64-4d5c-9666-721f708fcb1b"),
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

		private ProcessScriptTask _scriptTaskSetPrintReportParameters;
		public ProcessScriptTask ScriptTaskSetPrintReportParameters {
			get {
				return _scriptTaskSetPrintReportParameters ?? (_scriptTaskSetPrintReportParameters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSetPrintReportParameters",
					SchemaElementUId = new Guid("4a5c954d-97b2-45f2-b7de-644b553ac2a8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSetPrintReportParametersExecute,
				});
			}
		}

		private UserTaskOpenPrintReportPageFlowElement _userTaskOpenPrintReportPage;
		public UserTaskOpenPrintReportPageFlowElement UserTaskOpenPrintReportPage {
			get {
				return _userTaskOpenPrintReportPage ?? (_userTaskOpenPrintReportPage = new UserTaskOpenPrintReportPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _startMessageOpenPrintReportMessage;
		public ProcessFlowElement StartMessageOpenPrintReportMessage {
			get {
				return _startMessageOpenPrintReportMessage ?? (_startMessageOpenPrintReportMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageOpenPrintReportMessage",
					SchemaElementUId = new Guid("5cd067ef-5bd6-41bf-b683-5e121962f8b1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _subProcessBaseModuleEditPageLoad;
		public ProcessFlowElement SubProcessBaseModuleEditPageLoad {
			get {
				return _subProcessBaseModuleEditPageLoad ?? (_subProcessBaseModuleEditPageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessBaseModuleEditPageLoad",
					SchemaElementUId = new Guid("f584f8c4-7bb3-4479-8381-fa7f5b2d68f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private LoadPrintReportButtonMenuProcessFlowElement _loadPrintReportButtonMenuProcess;
		public LoadPrintReportButtonMenuProcessFlowElement LoadPrintReportButtonMenuProcess {
			get {
				return _loadPrintReportButtonMenuProcess ?? ((_loadPrintReportButtonMenuProcess) = new LoadPrintReportButtonMenuProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _startMessageBasePageLoad;
		public ProcessFlowElement StartMessageBasePageLoad {
			get {
				return _startMessageBasePageLoad ?? (_startMessageBasePageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageBasePageLoad",
					SchemaElementUId = new Guid("a09dff9b-f8d2-4164-a3f0-a94dc40d4c71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPrepareParametersFillPrinReportMenu;
		public ProcessScriptTask ScriptTaskPrepareParametersFillPrinReportMenu {
			get {
				return _scriptTaskPrepareParametersFillPrinReportMenu ?? (_scriptTaskPrepareParametersFillPrinReportMenu = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPrepareParametersFillPrinReportMenu",
					SchemaElementUId = new Guid("88a78a98-8ec2-4bb6-91d4-c0cb5dee6050"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPrepareParametersFillPrinReportMenuExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDefPageLoadEnd;
		public ProcessScriptTask ScriptTaskDefPageLoadEnd {
			get {
				return _scriptTaskDefPageLoadEnd ?? (_scriptTaskDefPageLoadEnd = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDefPageLoadEnd",
					SchemaElementUId = new Guid("a0e3b040-538f-4a5c-90c0-cd772f3319e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDefPageLoadEndExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessCheckBeforePrint;
		public ProcessFlowElement EventSubProcessCheckBeforePrint {
			get {
				return _eventSubProcessCheckBeforePrint ?? (_eventSubProcessCheckBeforePrint = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessCheckBeforePrint",
					SchemaElementUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPrepeareSaveBeforePrintParams;
		public ProcessScriptTask ScriptPrepeareSaveBeforePrintParams {
			get {
				return _scriptPrepeareSaveBeforePrintParams ?? (_scriptPrepeareSaveBeforePrintParams = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrepeareSaveBeforePrintParams",
					SchemaElementUId = new Guid("7f8a7ca6-852d-4f46-b020-c0735007051a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPrepeareSaveBeforePrintParamsExecute,
				});
			}
		}

		private CheckSaveBeforePrintFlowElement _checkSaveBeforePrint;
		public CheckSaveBeforePrintFlowElement CheckSaveBeforePrint {
			get {
				return _checkSaveBeforePrint ?? (_checkSaveBeforePrint = new CheckSaveBeforePrintFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _saveBeforePrintMessage;
		public ProcessFlowElement SaveBeforePrintMessage {
			get {
				return _saveBeforePrintMessage ?? (_saveBeforePrintMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SaveBeforePrintMessage",
					SchemaElementUId = new Guid("7d64b4be-4f5a-46be-9914-69194e0233eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _notSaveBeforePrintMessage;
		public ProcessFlowElement NotSaveBeforePrintMessage {
			get {
				return _notSaveBeforePrintMessage ?? (_notSaveBeforePrintMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "NotSaveBeforePrintMessage",
					SchemaElementUId = new Guid("d89911ce-2f7a-4b20-ad85-af9eba8adae6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowApplyButtonClick;
		public ProcessThrowMessageEvent IntermediateThrowApplyButtonClick {
			get {
				return _intermediateThrowApplyButtonClick ?? (_intermediateThrowApplyButtonClick = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowApplyButtonClick",
					SchemaElementUId = new Guid("3875432c-7297-4c11-a502-ffb00f184d15"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ApplyButtonClick",
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowStartPrintMessage;
		public ProcessThrowMessageEvent IntermediateThrowStartPrintMessage {
			get {
				return _intermediateThrowStartPrintMessage ?? (_intermediateThrowStartPrintMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowStartPrintMessage",
					SchemaElementUId = new Guid("1dc085de-0a8c-49cd-8438-d0c5ceb074da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "StartPrintMessage",
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
					SchemaElementUId = new Guid("c7f0a3b1-e680-47e4-8ebf-c49f2e8998a4"),
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

		private ProcessFlowElement _startOpenPrintDevExpressReportMessage;
		public ProcessFlowElement StartOpenPrintDevExpressReportMessage {
			get {
				return _startOpenPrintDevExpressReportMessage ?? (_startOpenPrintDevExpressReportMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartOpenPrintDevExpressReportMessage",
					SchemaElementUId = new Guid("98dca6dc-6d49-4815-b42b-99653f887f08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptReadOpenPrintParams;
		public ProcessScriptTask ScriptReadOpenPrintParams {
			get {
				return _scriptReadOpenPrintParams ?? (_scriptReadOpenPrintParams = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptReadOpenPrintParams",
					SchemaElementUId = new Guid("9e55b06c-c3d0-465a-857e-fd8c109cb46d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptReadOpenPrintParamsExecute,
				});
			}
		}

		private ProcessScriptTask _setMustSaveBeforePrintScriptTask;
		public ProcessScriptTask SetMustSaveBeforePrintScriptTask {
			get {
				return _setMustSaveBeforePrintScriptTask ?? (_setMustSaveBeforePrintScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetMustSaveBeforePrintScriptTask",
					SchemaElementUId = new Guid("f29a6c2c-0ff7-43e2-a798-08098163c01d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetMustSaveBeforePrintScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _savedCanPrintMessage;
		public ProcessFlowElement SavedCanPrintMessage {
			get {
				return _savedCanPrintMessage ?? (_savedCanPrintMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SavedCanPrintMessage",
					SchemaElementUId = new Guid("7dcb7cd9-0c1b-4ae4-a055-a6ab7da47580"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceSaved;
		public ProcessFlowElement DataSourceSaved {
			get {
				return _dataSourceSaved ?? (_dataSourceSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceSaved",
					SchemaElementUId = new Guid("b3f5495c-2777-4bbd-9308-c66be2337461"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceSaved;
		public ProcessScriptTask ScriptDataSourceSaved {
			get {
				return _scriptDataSourceSaved ?? (_scriptDataSourceSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceSaved",
					SchemaElementUId = new Guid("092402ec-6037-4377-b137-ee742f70f081"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceSavedExecute,
				});
			}
		}

		private ProcessScriptTask _scriptBeforeClose;
		public ProcessScriptTask ScriptBeforeClose {
			get {
				return _scriptBeforeClose ?? (_scriptBeforeClose = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptBeforeClose",
					SchemaElementUId = new Guid("46f4b017-6a6f-4bd7-86f8-fafa14ad09f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptBeforeCloseExecute,
				});
			}
		}

		private ConfirmIncludeInFolderFlowElement _confirmIncludeInFolder;
		public ConfirmIncludeInFolderFlowElement ConfirmIncludeInFolder {
			get {
				return _confirmIncludeInFolder ?? (_confirmIncludeInFolder = new ConfirmIncludeInFolderFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _yesMessage;
		public ProcessFlowElement YesMessage {
			get {
				return _yesMessage ?? (_yesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "YesMessage",
					SchemaElementUId = new Guid("e4cd4758-8aa3-494a-9fea-387eec6bc80a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptYesMessage;
		public ProcessScriptTask ScriptYesMessage {
			get {
				return _scriptYesMessage ?? (_scriptYesMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptYesMessage",
					SchemaElementUId = new Guid("8f0a31ad-832f-48d1-b97c-1cadb6e3656c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptYesMessageExecute,
				});
			}
		}

		private ProcessFlowElement _noMessage;
		public ProcessFlowElement NoMessage {
			get {
				return _noMessage ?? (_noMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "NoMessage",
					SchemaElementUId = new Guid("ef2a6d30-b345-4f03-8582-fc7168d10968"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private TreeGridLoadRowUserTaskFlowElement _treeGridLoadRowUserTask;
		public TreeGridLoadRowUserTaskFlowElement TreeGridLoadRowUserTask {
			get {
				return _treeGridLoadRowUserTask ?? (_treeGridLoadRowUserTask = new TreeGridLoadRowUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTaskAfterDataSourceSaved;
		public ProcessScriptTask ScriptTaskAfterDataSourceSaved {
			get {
				return _scriptTaskAfterDataSourceSaved ?? (_scriptTaskAfterDataSourceSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskAfterDataSourceSaved",
					SchemaElementUId = new Guid("6493a93c-1aa7-4440-845c-eb9af81d5f13"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskAfterDataSourceSavedExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayAfterSave;
		public ProcessExclusiveGateway ExclusiveGatewayAfterSave {
			get {
				return _exclusiveGatewayAfterSave ?? (_exclusiveGatewayAfterSave = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayAfterSave",
					SchemaElementUId = new Guid("c72690c4-a429-4348-90a9-fcdd19526e4a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGatewayAfterSave.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _preSyncDSS;
		public ProcessScriptTask PreSyncDSS {
			get {
				return _preSyncDSS ?? (_preSyncDSS = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PreSyncDSS",
					SchemaElementUId = new Guid("81518e82-9722-45dd-a356-00b23da3882a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PreSyncDSSExecute,
				});
			}
		}

		private SyncRecentEntityUserTaskDSSFlowElement _syncRecentEntityUserTaskDSS;
		public SyncRecentEntityUserTaskDSSFlowElement SyncRecentEntityUserTaskDSS {
			get {
				return _syncRecentEntityUserTaskDSS ?? (_syncRecentEntityUserTaskDSS = new SyncRecentEntityUserTaskDSSFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private BaseParallelGateway1FlowElement _baseParallelGateway1;
		public BaseParallelGateway1FlowElement BaseParallelGateway1 {
			get {
				return _baseParallelGateway1 ?? ((_baseParallelGateway1) = new BaseParallelGateway1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _baseExclusiveGateway4;
		public ProcessExclusiveGateway BaseExclusiveGateway4 {
			get {
				return _baseExclusiveGateway4 ?? (_baseExclusiveGateway4 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "BaseExclusiveGateway4",
					SchemaElementUId = new Guid("20eb4604-b55a-45d0-82af-8bc44ce47354"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.BaseExclusiveGateway4.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessFlowElement _subProcessAllowAddDetail;
		public ProcessFlowElement SubProcessAllowAddDetail {
			get {
				return _subProcessAllowAddDetail ?? (_subProcessAllowAddDetail = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessAllowAddDetail",
					SchemaElementUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageRequestAddDetailMessage;
		public ProcessFlowElement StartMessageRequestAddDetailMessage {
			get {
				return _startMessageRequestAddDetailMessage ?? (_startMessageRequestAddDetailMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageRequestAddDetailMessage",
					SchemaElementUId = new Guid("fb3ebee4-b51d-437d-9058-5c07fe1c9678"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskAllowAddDetail;
		public ProcessScriptTask ScriptTaskAllowAddDetail {
			get {
				return _scriptTaskAllowAddDetail ?? (_scriptTaskAllowAddDetail = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskAllowAddDetail",
					SchemaElementUId = new Guid("aba7e3fc-4360-4bf3-a025-dd33b70e724c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskAllowAddDetailExecute,
				});
			}
		}

		private AllowAddDetailUserTaskFlowElement _allowAddDetailUserTask;
		public AllowAddDetailUserTaskFlowElement AllowAddDetailUserTask {
			get {
				return _allowAddDetailUserTask ?? (_allowAddDetailUserTask = new AllowAddDetailUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTaskSendAllowMessage;
		public ProcessScriptTask ScriptTaskSendAllowMessage {
			get {
				return _scriptTaskSendAllowMessage ?? (_scriptTaskSendAllowMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSendAllowMessage",
					SchemaElementUId = new Guid("9aca68c3-9906-4950-a97b-fee7d69e1586"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSendAllowMessageExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageAllowAddDetail;
		public ProcessFlowElement StartMessageAllowAddDetail {
			get {
				return _startMessageAllowAddDetail ?? (_startMessageAllowAddDetail = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAllowAddDetail",
					SchemaElementUId = new Guid("18d8838c-9820-4c17-957b-1766afb153d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sendAllowAddDetailMessage;
		public ProcessFlowElement SendAllowAddDetailMessage {
			get {
				return _sendAllowAddDetailMessage ?? (_sendAllowAddDetailMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SendAllowAddDetailMessage",
					SchemaElementUId = new Guid("5f2accfc-6601-4c98-a286-78349e42a186"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskSendAllowDetailMessage;
		public ProcessScriptTask ScriptTaskSendAllowDetailMessage {
			get {
				return _scriptTaskSendAllowDetailMessage ?? (_scriptTaskSendAllowDetailMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSendAllowDetailMessage",
					SchemaElementUId = new Guid("7a85f52d-ca65-4733-a4a9-94485fe3d779"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSendAllowDetailMessageExecute,
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
					SchemaElementUId = new Guid("5629032e-26ca-4c0b-a528-8a601c3e7c8f"),
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

		private ProcessFlowElement _startMessageDenyAddDetailMessage;
		public ProcessFlowElement StartMessageDenyAddDetailMessage {
			get {
				return _startMessageDenyAddDetailMessage ?? (_startMessageDenyAddDetailMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDenyAddDetailMessage",
					SchemaElementUId = new Guid("fb20f4b4-6707-4412-a2e1-3d103c095e9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDenyAddDetailMessage;
		public ProcessScriptTask ScriptTaskDenyAddDetailMessage {
			get {
				return _scriptTaskDenyAddDetailMessage ?? (_scriptTaskDenyAddDetailMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDenyAddDetailMessage",
					SchemaElementUId = new Guid("fc467cdb-267e-45d0-be00-b194964eb977"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDenyAddDetailMessageExecute,
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow728;
		public ProcessConditionalFlow SequenceFlow728 {
			get {
				return _sequenceFlow728 ?? (_sequenceFlow728 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow728",
					SchemaElementUId = new Guid("a73d6859-7479-481e-b4f2-9c7790d42935"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow741;
		public ProcessConditionalFlow SequenceFlow741 {
			get {
				return _sequenceFlow741 ?? (_sequenceFlow741 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow741",
					SchemaElementUId = new Guid("e590f987-f6e1-425d-b1b0-2152cead77fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow753;
		public ProcessConditionalFlow SequenceFlow753 {
			get {
				return _sequenceFlow753 ?? (_sequenceFlow753 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow753",
					SchemaElementUId = new Guid("f014625b-f8dc-4f64-a8d5-be030dae46a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow761;
		public ProcessConditionalFlow SequenceFlow761 {
			get {
				return _sequenceFlow761 ?? (_sequenceFlow761 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow761",
					SchemaElementUId = new Guid("607e267e-b026-4553-8dd5-e49818faf5b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow762;
		public ProcessConditionalFlow SequenceFlow762 {
			get {
				return _sequenceFlow762 ?? (_sequenceFlow762 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow762",
					SchemaElementUId = new Guid("eb116c63-2969-4639-a3a7-b9e6e861d26a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow770;
		public ProcessConditionalFlow SequenceFlow770 {
			get {
				return _sequenceFlow770 ?? (_sequenceFlow770 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow770",
					SchemaElementUId = new Guid("883f8faf-c520-43dc-8e4f-2085e31779b8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _baseConditionalFlow1;
		public ProcessConditionalFlow BaseConditionalFlow1 {
			get {
				return _baseConditionalFlow1 ?? (_baseConditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "BaseConditionalFlow1",
					SchemaElementUId = new Guid("4742e5a2-ce4d-4448-8360-1117f3c44863"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow18021;
		public ProcessConditionalFlow ConditionalFlow18021 {
			get {
				return _conditionalFlow18021 ?? (_conditionalFlow18021 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow18021",
					SchemaElementUId = new Guid("3874f67a-f0ce-4af6-8a0a-5d954b855bd7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _yesEntitySavedConditionalFlow;
		public ProcessConditionalFlow YesEntitySavedConditionalFlow {
			get {
				return _yesEntitySavedConditionalFlow ?? (_yesEntitySavedConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "YesEntitySavedConditionalFlow",
					SchemaElementUId = new Guid("8eb78326-f2e8-4e8d-9306-c6587c3e23ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _isModifyNoConditionalFlow;
		public ProcessConditionalFlow IsModifyNoConditionalFlow {
			get {
				return _isModifyNoConditionalFlow ?? (_isModifyNoConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsModifyNoConditionalFlow",
					SchemaElementUId = new Guid("1eef0d8b-916e-4dc4-9d6a-506d61d0a800"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1wr325;
		public ProcessConditionalFlow ConditionalFlow1wr325 {
			get {
				return _conditionalFlow1wr325 ?? (_conditionalFlow1wr325 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1wr325",
					SchemaElementUId = new Guid("3e69c9a5-502a-408f-8baa-67faa58f3062"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _scriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken;
		public ProcessToken ScriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken {
			get {
				return _scriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken ?? (_scriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ScriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken",
					SchemaElementUId = new Guid("d3a0d655-93fe-4eda-ab56-9227ac501757"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private LocalizableString _includeInFolderMessage;
		public LocalizableString IncludeInFolderMessage {
			get {
				return _includeInFolderMessage ?? (_includeInFolderMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IncludeInFolderMessage.Value"));
			}
		}

		private LocalizableString _newRecordCaption;
		public LocalizableString NewRecordCaption {
			get {
				return _newRecordCaption ?? (_newRecordCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NewRecordCaption.Value"));
			}
		}

		private LocalizableString _editingRecordCaption;
		public LocalizableString EditingRecordCaption {
			get {
				return _editingRecordCaption ?? (_editingRecordCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EditingRecordCaption.Value"));
			}
		}

		private LocalizableString _newRecordNotSavedMessage;
		public LocalizableString NewRecordNotSavedMessage {
			get {
				return _newRecordNotSavedMessage ?? (_newRecordNotSavedMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NewRecordNotSavedMessage.Value"));
			}
		}

		private LocalizableString _saveBeforePrintQuestionMessage;
		public LocalizableString SaveBeforePrintQuestionMessage {
			get {
				return _saveBeforePrintQuestionMessage ?? (_saveBeforePrintQuestionMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SaveBeforePrintQuestionMessage.Value"));
			}
		}

		private LocalizableString _warning;
		public LocalizableString Warning {
			get {
				return _warning ?? (_warning = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Warning.Value"));
			}
		}

		private LocalizableString _tip;
		public LocalizableString Tip {
			get {
				return _tip ?? (_tip = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Tip.Value"));
			}
		}

		private LocalizableString _moduleProcessInstanceNotExistMessage;
		public LocalizableString ModuleProcessInstanceNotExistMessage {
			get {
				return _moduleProcessInstanceNotExistMessage ?? (_moduleProcessInstanceNotExistMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ModuleProcessInstanceNotExistMessage.Value"));
			}
		}

		private LocalizableString _continueOpenFieldEditorMessage;
		public LocalizableString ContinueOpenFieldEditorMessage {
			get {
				return _continueOpenFieldEditorMessage ?? (_continueOpenFieldEditorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ContinueOpenFieldEditorMessage.Value"));
			}
		}

		private LocalizableString _saveBeforePagingMessage;
		public LocalizableString SaveBeforePagingMessage {
			get {
				return _saveBeforePagingMessage ?? (_saveBeforePagingMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SaveBeforePagingMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PagingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PagingEventSubProcess };
			FlowElements[NextButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { NextButtonClickStartMessage };
			FlowElements[NextButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { NextButtonClickScript };
			FlowElements[IsModifyExclusiveGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { IsModifyExclusiveGateway };
			FlowElements[ScriptPreviousButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPreviousButtonClick };
			FlowElements[PreviousButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PreviousButtonClickStartMessage };
			FlowElements[PrepareSaveYesNoScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareSaveYesNoScriptTask };
			FlowElements[SaveYesNoTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveYesNoTask };
			FlowElements[PagingScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PagingScript };
			FlowElements[SaveChangesScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveChangesScript };
			FlowElements[NoMsgStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { NoMsgStartMessage };
			FlowElements[YesMsgStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { YesMsgStartMessage };
			FlowElements[EventSubProcess2301.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2301 };
			FlowElements[DesignerModeButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { DesignerModeButtonClick };
			FlowElements[ScriptDesignerModeButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDesignerModeButtonClick };
			FlowElements[OpenPageSchemaDesigner_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenPageSchemaDesigner_UserTask };
			FlowElements[GetIsEntitySchemaBlockedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GetIsEntitySchemaBlockedScriptTask };
			FlowElements[ExclusiveGateway2301.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2301 };
			FlowElements[OpenMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenMessageUserTask };
			FlowElements[OpenMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenMessageScriptTask };
			FlowElements[IntermediateCatchMessageEvent2301.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEvent2301 };
			FlowElements[IntermediateCatchMessageEvent2302.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEvent2302 };
			FlowElements[End2301.SchemaElementUId] = new Collection<ProcessFlowElement> { End2301 };
			FlowElements[IsSavedEntityExclusiveGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { IsSavedEntityExclusiveGateway };
			FlowElements[PrepareUserTaskParametersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareUserTaskParametersScriptTask };
			FlowElements[OpenContinueMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenContinueMessageUserTask };
			FlowElements[NoContinueExit.SchemaElementUId] = new Collection<ProcessFlowElement> { NoContinueExit };
			FlowElements[NotContinueIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { NotContinueIntermediateCatchMessageEvent };
			FlowElements[YesContinueIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { YesContinueIntermediateCatchMessageEvent };
			FlowElements[EventSubProcessRunModuleProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessRunModuleProcess };
			FlowElements[StartRunModuleProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartRunModuleProcess };
			FlowElements[ScriptRunModuleProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptRunModuleProcess };
			FlowElements[EventSubProcessProcessButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessProcessButtonClick };
			FlowElements[StartProcessButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartProcessButtonClick };
			FlowElements[ScriptProcessButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptProcessButtonClick };
			FlowElements[OpenSelectProcessUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenSelectProcessUserTask };
			FlowElements[ScriptRunSelectedProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptRunSelectedProcess };
			FlowElements[IntermediateCatchMessageEventProcessSelected.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEventProcessSelected };
			FlowElements[EventSubProcessShowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessShowMessage };
			FlowElements[StartShowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartShowMessage };
			FlowElements[MessageWindowUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MessageWindowUserTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ScriptTaskHidePrinElements.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskHidePrinElements };
			FlowElements[SyncRecentEntityUserTaskPLC.SchemaElementUId] = new Collection<ProcessFlowElement> { SyncRecentEntityUserTaskPLC };
			FlowElements[SyncPreparePLC.SchemaElementUId] = new Collection<ProcessFlowElement> { SyncPreparePLC };
			FlowElements[ThrowDataTabPanelTabChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowDataTabPanelTabChange };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[ScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadComplete };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[OKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClick };
			FlowElements[ScriptOKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOKButtonClick };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[SetDetailFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { SetDetailFilter };
			FlowElements[ScriptTaskSetDefDetailsUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSetDefDetailsUserTask };
			FlowElements[DataTabPanelTabChange.SchemaElementUId] = new Collection<ProcessFlowElement> { DataTabPanelTabChange };
			FlowElements[ScriptDataTabPanelTabChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataTabPanelTabChange };
			FlowElements[ExclusiveGateway41234677.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway41234677 };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[BaseModuleEditInit.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseModuleEditInit };
			FlowElements[ScriptPageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageInit };
			FlowElements[EditInitializeDetails.SchemaElementUId] = new Collection<ProcessFlowElement> { EditInitializeDetails };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[SubProcesOpenPrintReport.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcesOpenPrintReport };
			FlowElements[ScriptTaskPrepareParametersPrintReoprtOpen.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPrepareParametersPrintReoprtOpen };
			FlowElements[ScriptTaskClearPrintUserContext.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskClearPrintUserContext };
			FlowElements[StartMessagePrintButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePrintButtonClick };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ScriptTaskSetPrintReportParameters.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSetPrintReportParameters };
			FlowElements[UserTaskOpenPrintReportPage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskOpenPrintReportPage };
			FlowElements[StartMessageOpenPrintReportMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageOpenPrintReportMessage };
			FlowElements[SubProcessBaseModuleEditPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessBaseModuleEditPageLoad };
			FlowElements[LoadPrintReportButtonMenuProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadPrintReportButtonMenuProcess };
			FlowElements[StartMessageBasePageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageBasePageLoad };
			FlowElements[ScriptTaskPrepareParametersFillPrinReportMenu.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPrepareParametersFillPrinReportMenu };
			FlowElements[ScriptTaskDefPageLoadEnd.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDefPageLoadEnd };
			FlowElements[EventSubProcessCheckBeforePrint.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessCheckBeforePrint };
			FlowElements[ScriptPrepeareSaveBeforePrintParams.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepeareSaveBeforePrintParams };
			FlowElements[CheckSaveBeforePrint.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckSaveBeforePrint };
			FlowElements[SaveBeforePrintMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveBeforePrintMessage };
			FlowElements[NotSaveBeforePrintMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { NotSaveBeforePrintMessage };
			FlowElements[IntermediateThrowApplyButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowApplyButtonClick };
			FlowElements[IntermediateThrowStartPrintMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowStartPrintMessage };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[StartOpenPrintDevExpressReportMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartOpenPrintDevExpressReportMessage };
			FlowElements[ScriptReadOpenPrintParams.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptReadOpenPrintParams };
			FlowElements[SetMustSaveBeforePrintScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetMustSaveBeforePrintScriptTask };
			FlowElements[SavedCanPrintMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SavedCanPrintMessage };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[DataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceSaved };
			FlowElements[ScriptDataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceSaved };
			FlowElements[ScriptBeforeClose.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptBeforeClose };
			FlowElements[ConfirmIncludeInFolder.SchemaElementUId] = new Collection<ProcessFlowElement> { ConfirmIncludeInFolder };
			FlowElements[YesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { YesMessage };
			FlowElements[ScriptYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptYesMessage };
			FlowElements[NoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { NoMessage };
			FlowElements[TreeGridLoadRowUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridLoadRowUserTask };
			FlowElements[ScriptTaskAfterDataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskAfterDataSourceSaved };
			FlowElements[ExclusiveGatewayAfterSave.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayAfterSave };
			FlowElements[PreSyncDSS.SchemaElementUId] = new Collection<ProcessFlowElement> { PreSyncDSS };
			FlowElements[SyncRecentEntityUserTaskDSS.SchemaElementUId] = new Collection<ProcessFlowElement> { SyncRecentEntityUserTaskDSS };
			FlowElements[BaseParallelGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseParallelGateway1 };
			FlowElements[BaseExclusiveGateway4.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseExclusiveGateway4 };
			FlowElements[SubProcessAllowAddDetail.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessAllowAddDetail };
			FlowElements[StartMessageRequestAddDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageRequestAddDetailMessage };
			FlowElements[ScriptTaskAllowAddDetail.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskAllowAddDetail };
			FlowElements[AllowAddDetailUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AllowAddDetailUserTask };
			FlowElements[ScriptTaskSendAllowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSendAllowMessage };
			FlowElements[StartMessageAllowAddDetail.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAllowAddDetail };
			FlowElements[SendAllowAddDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SendAllowAddDetailMessage };
			FlowElements[ScriptTaskSendAllowDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSendAllowDetailMessage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[StartMessageDenyAddDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDenyAddDetailMessage };
			FlowElements[ScriptTaskDenyAddDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDenyAddDetailMessage };
			FlowElements[ScriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PagingEventSubProcess":
						break;
					case "NextButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("NextButtonClickScript");
						break;
					case "NextButtonClickScript":
						e.Context.QueueTasks.Enqueue("IsModifyExclusiveGateway");
						break;
					case "IsModifyExclusiveGateway":
						if (IsModifyNoConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PagingScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("PrepareSaveYesNoScriptTask");
						break;
					case "ScriptPreviousButtonClick":
						e.Context.QueueTasks.Enqueue("IsModifyExclusiveGateway");
						break;
					case "PreviousButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptPreviousButtonClick");
						break;
					case "PrepareSaveYesNoScriptTask":
						e.Context.QueueTasks.Enqueue("SaveYesNoTask");
						break;
					case "SaveYesNoTask":
						break;
					case "PagingScript":
						break;
					case "SaveChangesScript":
						e.Context.QueueTasks.Enqueue("PagingScript");
						break;
					case "NoMsgStartMessage":
						e.Context.QueueTasks.Enqueue("PagingScript");
						break;
					case "YesMsgStartMessage":
						e.Context.QueueTasks.Enqueue("SaveChangesScript");
						break;
					case "EventSubProcess2301":
						break;
					case "DesignerModeButtonClick":
						e.Context.QueueTasks.Enqueue("GetIsEntitySchemaBlockedScriptTask");
						break;
					case "ScriptDesignerModeButtonClick":
						e.Context.QueueTasks.Enqueue("OpenPageSchemaDesigner_UserTask");
						break;
					case "OpenPageSchemaDesigner_UserTask":
						break;
					case "GetIsEntitySchemaBlockedScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2301");
						break;
					case "ExclusiveGateway2301":
						if (ConditionalFlow18021ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OpenMessageScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("IsSavedEntityExclusiveGateway");
						break;
					case "OpenMessageUserTask":
						ActivatedEventElements.Add("IntermediateCatchMessageEvent2301");
						ActivatedEventElements.Add("IntermediateCatchMessageEvent2302");
						break;
					case "OpenMessageScriptTask":
						e.Context.QueueTasks.Enqueue("OpenMessageUserTask");
						break;
					case "IntermediateCatchMessageEvent2301":
						e.Context.QueueTasks.Enqueue("End2301");
						break;
					case "IntermediateCatchMessageEvent2302":
						e.Context.QueueTasks.Enqueue("IsSavedEntityExclusiveGateway");
						break;
					case "End2301":
						break;
					case "IsSavedEntityExclusiveGateway":
						if (YesEntitySavedConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareUserTaskParametersScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptDesignerModeButtonClick");
						break;
					case "PrepareUserTaskParametersScriptTask":
						e.Context.QueueTasks.Enqueue("OpenContinueMessageUserTask");
						break;
					case "OpenContinueMessageUserTask":
						ActivatedEventElements.Add("NotContinueIntermediateCatchMessageEvent");
						ActivatedEventElements.Add("YesContinueIntermediateCatchMessageEvent");
						break;
					case "NoContinueExit":
						break;
					case "NotContinueIntermediateCatchMessageEvent":
						e.Context.QueueTasks.Enqueue("NoContinueExit");
						break;
					case "YesContinueIntermediateCatchMessageEvent":
						e.Context.QueueTasks.Enqueue("ScriptDesignerModeButtonClick");
						break;
					case "EventSubProcessRunModuleProcess":
						break;
					case "StartRunModuleProcess":
						e.Context.QueueTasks.Enqueue("ScriptRunModuleProcess");
						break;
					case "ScriptRunModuleProcess":
						break;
					case "EventSubProcessProcessButtonClick":
						break;
					case "StartProcessButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptProcessButtonClick");
						break;
					case "ScriptProcessButtonClick":
						e.Context.QueueTasks.Enqueue("OpenSelectProcessUserTask");
						break;
					case "OpenSelectProcessUserTask":
						ActivatedEventElements.Add("IntermediateCatchMessageEventProcessSelected");
						break;
					case "ScriptRunSelectedProcess":
						break;
					case "IntermediateCatchMessageEventProcessSelected":
						e.Context.QueueTasks.Enqueue("ScriptRunSelectedProcess");
						break;
					case "EventSubProcessShowMessage":
						break;
					case "StartShowMessage":
						e.Context.QueueTasks.Enqueue("MessageWindowUserTask");
						break;
					case "MessageWindowUserTask":
						break;
					case "EventSubProcess1":
						break;
					case "ScriptTaskHidePrinElements":
						e.Context.QueueTasks.Enqueue("ThrowDataTabPanelTabChange");
						break;
					case "SyncRecentEntityUserTaskPLC":
						break;
					case "SyncPreparePLC":
						e.Context.QueueTasks.Enqueue("SyncRecentEntityUserTaskPLC");
						break;
					case "ThrowDataTabPanelTabChange":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadComplete");
						break;
					case "ScriptPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptTaskHidePrinElements");
						if (SequenceFlow762ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("SyncPreparePLC");
							break;
						}
						break;
					case "EventSubProcess3":
						break;
					case "OKButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptOKButtonClick");
						break;
					case "ScriptOKButtonClick":
						break;
					case "EventSubProcess7":
						break;
					case "SetDetailFilter":
							e.Context.QueueTasks.Enqueue("ScriptTaskSetDefDetailsUserTask");
						break;
					case "ScriptTaskSetDefDetailsUserTask":
						break;
					case "DataTabPanelTabChange":
						e.Context.QueueTasks.Enqueue("ScriptDataTabPanelTabChange");
						break;
					case "ScriptDataTabPanelTabChange":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway41234677");
						break;
					case "ExclusiveGateway41234677":
						if (ConditionalFlow1wr325ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("SetDetailFilter");
							break;
						}
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "End1":
						break;
					case "EventSubProcess2":
						break;
					case "BaseModuleEditInit":
						e.Context.QueueTasks.Enqueue("ScriptPageInit");
						break;
					case "ScriptPageInit":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						if (SequenceFlow728ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("EditInitializeDetails");
							break;
						}
						break;
					case "EditInitializeDetails":
						break;
					case "ScriptTask1":
						break;
					case "SubProcesOpenPrintReport":
						break;
					case "ScriptTaskPrepareParametersPrintReoprtOpen":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ScriptTaskClearPrintUserContext":
						break;
					case "StartMessagePrintButtonClick":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ExclusiveGateway2":
							e.Context.QueueTasks.Enqueue("ScriptTaskSetPrintReportParameters");
						break;
					case "ScriptTaskSetPrintReportParameters":
						e.Context.QueueTasks.Enqueue("UserTaskOpenPrintReportPage");
						break;
					case "UserTaskOpenPrintReportPage":
							e.Context.QueueTasks.Enqueue("ScriptTaskClearPrintUserContext");
						break;
					case "StartMessageOpenPrintReportMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskPrepareParametersPrintReoprtOpen");
						break;
					case "SubProcessBaseModuleEditPageLoad":
						break;
					case "LoadPrintReportButtonMenuProcess":
						break;
					case "StartMessageBasePageLoad":
						e.Context.QueueTasks.Enqueue("ScriptTaskPrepareParametersFillPrinReportMenu");
						break;
					case "ScriptTaskPrepareParametersFillPrinReportMenu":
						e.Context.QueueTasks.Enqueue("ScriptTaskDefPageLoadEnd");
						if (SequenceFlow753ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("ScriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken");
							break;
						}
						break;
					case "ScriptTaskDefPageLoadEnd":
						break;
					case "EventSubProcessCheckBeforePrint":
						break;
					case "ScriptPrepeareSaveBeforePrintParams":
						e.Context.QueueTasks.Enqueue("CheckSaveBeforePrint");
						break;
					case "CheckSaveBeforePrint":
						break;
					case "SaveBeforePrintMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowApplyButtonClick");
						break;
					case "NotSaveBeforePrintMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowStartPrintMessage");
						break;
					case "IntermediateThrowApplyButtonClick":
						e.Context.QueueTasks.Enqueue("SetMustSaveBeforePrintScriptTask");
						break;
					case "IntermediateThrowStartPrintMessage":
						break;
					case "ExclusiveGateway3":
						if (SequenceFlow770ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptPrepeareSaveBeforePrintParams");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowStartPrintMessage");
						break;
					case "StartOpenPrintDevExpressReportMessage":
						e.Context.QueueTasks.Enqueue("ScriptReadOpenPrintParams");
						break;
					case "ScriptReadOpenPrintParams":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "SetMustSaveBeforePrintScriptTask":
						break;
					case "SavedCanPrintMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowStartPrintMessage");
						break;
					case "SubProcess1":
						break;
					case "DataSourceSaved":
						e.Context.QueueTasks.Enqueue("ScriptBeforeClose");
						break;
					case "ScriptDataSourceSaved":
						e.Context.QueueTasks.Enqueue("ExclusiveGatewayAfterSave");
						break;
					case "ScriptBeforeClose":
						if (!e.Context.QueueTasks.Contains("BaseParallelGateway1")) {
							e.Context.QueueTasks.Enqueue("BaseParallelGateway1");
						}
						break;
					case "ConfirmIncludeInFolder":
						break;
					case "YesMessage":
						e.Context.QueueTasks.Enqueue("ScriptYesMessage");
						break;
					case "ScriptYesMessage":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceSaved");
						break;
					case "NoMessage":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceSaved");
						break;
					case "TreeGridLoadRowUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTaskAfterDataSourceSaved");
						break;
					case "ScriptTaskAfterDataSourceSaved":
						break;
					case "ExclusiveGatewayAfterSave":
						if (SequenceFlow761ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("TreeGridLoadRowUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTaskAfterDataSourceSaved");
						break;
					case "PreSyncDSS":
						e.Context.QueueTasks.Enqueue("SyncRecentEntityUserTaskDSS");
						break;
					case "SyncRecentEntityUserTaskDSS":
						break;
					case "BaseParallelGateway1":
						if (BaseParallelGateway1.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasks.Enqueue("BaseExclusiveGateway4");
							e.Context.QueueTasks.Enqueue("PreSyncDSS");
						}
						break;
					case "BaseExclusiveGateway4":
						if (BaseConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ConfirmIncludeInFolder");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptDataSourceSaved");
						break;
					case "SubProcessAllowAddDetail":
						break;
					case "StartMessageRequestAddDetailMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskAllowAddDetail");
						break;
					case "ScriptTaskAllowAddDetail":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "AllowAddDetailUserTask":
						break;
					case "ScriptTaskSendAllowMessage":
						break;
					case "StartMessageAllowAddDetail":
						e.Context.QueueTasks.Enqueue("ScriptTaskSendAllowMessage");
						break;
					case "SendAllowAddDetailMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskSendAllowDetailMessage");
						break;
					case "ScriptTaskSendAllowDetailMessage":
						break;
					case "ExclusiveGateway1":
						if (SequenceFlow741ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("AllowAddDetailUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTaskSendAllowDetailMessage");
						break;
					case "StartMessageDenyAddDetailMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskDenyAddDetailMessage");
						break;
					case "ScriptTaskDenyAddDetailMessage":
						break;
					case "ScriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken":
						e.Context.QueueTasks.Enqueue("LoadPrintReportButtonMenuProcess");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow728ExpressionExecute() {
			return Convert.ToBoolean(HasDetails);
		}

		private bool SequenceFlow741ExpressionExecute() {
			return Convert.ToBoolean(IsNew || IsCopy);
		}

		private bool SequenceFlow753ExpressionExecute() {
			return Convert.ToBoolean(!NotRecivePrintReportMenu);
		}

		private bool SequenceFlow761ExpressionExecute() {
			return Convert.ToBoolean(NeedTreeGridRefresh);
		}

		private bool SequenceFlow762ExpressionExecute() {
			return Convert.ToBoolean(IsEdit);
		}

		private bool SequenceFlow770ExpressionExecute() {
			return Convert.ToBoolean(Page.DataSource.ActiveRowModified);
		}

		private bool BaseConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(DoIncludeInSelectedFolder);
		}

		private bool ConditionalFlow18021ExpressionExecute() {
			return Convert.ToBoolean(IsSchemaBlocked);
		}

		private bool YesEntitySavedConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(IsEntityChanged());
		}

		private bool IsModifyNoConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(!NeedSave);
		}

		private bool ConditionalFlow1wr325ExpressionExecute() {
			return Convert.ToBoolean(HasDetails);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("NextButtonClickStartMessage");
			ActivatedEventElements.Add("PreviousButtonClickStartMessage");
			ActivatedEventElements.Add("NoMsgStartMessage");
			ActivatedEventElements.Add("YesMsgStartMessage");
			ActivatedEventElements.Add("DesignerModeButtonClick");
			ActivatedEventElements.Add("StartRunModuleProcess");
			ActivatedEventElements.Add("StartProcessButtonClick");
			ActivatedEventElements.Add("StartShowMessage");
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("OKButtonClick");
			ActivatedEventElements.Add("DataTabPanelTabChange");
			ActivatedEventElements.Add("BaseModuleEditInit");
			ActivatedEventElements.Add("StartMessagePrintButtonClick");
			ActivatedEventElements.Add("StartMessageOpenPrintReportMessage");
			ActivatedEventElements.Add("StartMessageBasePageLoad");
			ActivatedEventElements.Add("SaveBeforePrintMessage");
			ActivatedEventElements.Add("NotSaveBeforePrintMessage");
			ActivatedEventElements.Add("StartOpenPrintDevExpressReportMessage");
			ActivatedEventElements.Add("SavedCanPrintMessage");
			ActivatedEventElements.Add("DataSourceSaved");
			ActivatedEventElements.Add("YesMessage");
			ActivatedEventElements.Add("NoMessage");
			ActivatedEventElements.Add("StartMessageRequestAddDetailMessage");
			ActivatedEventElements.Add("StartMessageAllowAddDetail");
			ActivatedEventElements.Add("SendAllowAddDetailMessage");
			ActivatedEventElements.Add("StartMessageDenyAddDetailMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PagingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "NextButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "NextButtonClickStartMessage";
					result = NextButtonClickStartMessage.Execute(context);
					break;
				case "NextButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "NextButtonClickScript";
					result = NextButtonClickScript.Execute(context, NextButtonClickScriptExecute);
					break;
				case "IsModifyExclusiveGateway":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsModifyExclusiveGateway";
					result = IsModifyExclusiveGateway.Execute(context);
					break;
				case "ScriptPreviousButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPreviousButtonClick";
					result = ScriptPreviousButtonClick.Execute(context, ScriptPreviousButtonClickExecute);
					break;
				case "PreviousButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PreviousButtonClickStartMessage";
					result = PreviousButtonClickStartMessage.Execute(context);
					break;
				case "PrepareSaveYesNoScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareSaveYesNoScriptTask";
					result = PrepareSaveYesNoScriptTask.Execute(context, PrepareSaveYesNoScriptTaskExecute);
					break;
				case "SaveYesNoTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveYesNoTask";
					result = SaveYesNoTask.Execute(context);
					break;
				case "PagingScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PagingScript";
					result = PagingScript.Execute(context, PagingScriptExecute);
					break;
				case "SaveChangesScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveChangesScript";
					result = SaveChangesScript.Execute(context, SaveChangesScriptExecute);
					break;
				case "NoMsgStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "NoMsgStartMessage";
					result = NoMsgStartMessage.Execute(context);
					break;
				case "YesMsgStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "YesMsgStartMessage";
					result = YesMsgStartMessage.Execute(context);
					break;
				case "EventSubProcess2301":
					context.QueueTasks.Dequeue();
					break;
				case "DesignerModeButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "DesignerModeButtonClick";
					result = DesignerModeButtonClick.Execute(context);
					break;
				case "ScriptDesignerModeButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDesignerModeButtonClick";
					result = ScriptDesignerModeButtonClick.Execute(context, ScriptDesignerModeButtonClickExecute);
					break;
				case "OpenPageSchemaDesigner_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenPageSchemaDesigner_UserTask";
					result = OpenPageSchemaDesigner_UserTask.Execute(context);
					break;
				case "GetIsEntitySchemaBlockedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GetIsEntitySchemaBlockedScriptTask";
					result = GetIsEntitySchemaBlockedScriptTask.Execute(context, GetIsEntitySchemaBlockedScriptTaskExecute);
					break;
				case "ExclusiveGateway2301":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2301";
					result = ExclusiveGateway2301.Execute(context);
					break;
				case "OpenMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenMessageUserTask";
					result = OpenMessageUserTask.Execute(context);
					break;
				case "OpenMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenMessageScriptTask";
					result = OpenMessageScriptTask.Execute(context, OpenMessageScriptTaskExecute);
					break;
				case "IntermediateCatchMessageEvent2301":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEvent2301";
					result = IntermediateCatchMessageEvent2301.Execute(context);
					break;
				case "IntermediateCatchMessageEvent2302":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEvent2302";
					result = IntermediateCatchMessageEvent2302.Execute(context);
					break;
				case "End2301":
					context.QueueTasks.Dequeue();
					break;
				case "IsSavedEntityExclusiveGateway":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsSavedEntityExclusiveGateway";
					result = IsSavedEntityExclusiveGateway.Execute(context);
					break;
				case "PrepareUserTaskParametersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareUserTaskParametersScriptTask";
					result = PrepareUserTaskParametersScriptTask.Execute(context, PrepareUserTaskParametersScriptTaskExecute);
					break;
				case "OpenContinueMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenContinueMessageUserTask";
					result = OpenContinueMessageUserTask.Execute(context);
					break;
				case "NoContinueExit":
					context.QueueTasks.Dequeue();
					break;
				case "NotContinueIntermediateCatchMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "NotContinueIntermediateCatchMessageEvent";
					result = NotContinueIntermediateCatchMessageEvent.Execute(context);
					break;
				case "YesContinueIntermediateCatchMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "YesContinueIntermediateCatchMessageEvent";
					result = YesContinueIntermediateCatchMessageEvent.Execute(context);
					break;
				case "EventSubProcessRunModuleProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartRunModuleProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartRunModuleProcess";
					result = StartRunModuleProcess.Execute(context);
					break;
				case "ScriptRunModuleProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptRunModuleProcess";
					result = ScriptRunModuleProcess.Execute(context, ScriptRunModuleProcessExecute);
					break;
				case "EventSubProcessProcessButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartProcessButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartProcessButtonClick";
					result = StartProcessButtonClick.Execute(context);
					break;
				case "ScriptProcessButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptProcessButtonClick";
					result = ScriptProcessButtonClick.Execute(context, ScriptProcessButtonClickExecute);
					break;
				case "OpenSelectProcessUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenSelectProcessUserTask";
					result = OpenSelectProcessUserTask.Execute(context);
					break;
				case "ScriptRunSelectedProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptRunSelectedProcess";
					result = ScriptRunSelectedProcess.Execute(context, ScriptRunSelectedProcessExecute);
					break;
				case "IntermediateCatchMessageEventProcessSelected":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEventProcessSelected";
					result = IntermediateCatchMessageEventProcessSelected.Execute(context);
					break;
				case "EventSubProcessShowMessage":
					context.QueueTasks.Dequeue();
					break;
				case "StartShowMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartShowMessage";
					result = StartShowMessage.Execute(context);
					break;
				case "MessageWindowUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MessageWindowUserTask";
					result = MessageWindowUserTask.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTaskHidePrinElements":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskHidePrinElements";
					result = ScriptTaskHidePrinElements.Execute(context, ScriptTaskHidePrinElementsExecute);
					break;
				case "SyncRecentEntityUserTaskPLC":
					context.QueueTasks.Dequeue();
					context.SenderName = "SyncRecentEntityUserTaskPLC";
					result = SyncRecentEntityUserTaskPLC.Execute(context);
					break;
				case "SyncPreparePLC":
					context.QueueTasks.Dequeue();
					context.SenderName = "SyncPreparePLC";
					result = SyncPreparePLC.Execute(context, SyncPreparePLCExecute);
					break;
				case "ThrowDataTabPanelTabChange":
					context.QueueTasks.Dequeue();
					result = ThrowDataTabPanelTabChange.Execute(context);
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
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClick";
					result = OKButtonClick.Execute(context);
					break;
				case "ScriptOKButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOKButtonClick";
					result = ScriptOKButtonClick.Execute(context, ScriptOKButtonClickExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "SetDetailFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetDetailFilter";
					result = SetDetailFilter.Execute(context);
					break;
				case "ScriptTaskSetDefDetailsUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSetDefDetailsUserTask";
					result = ScriptTaskSetDefDetailsUserTask.Execute(context, ScriptTaskSetDefDetailsUserTaskExecute);
					break;
				case "DataTabPanelTabChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataTabPanelTabChange";
					result = DataTabPanelTabChange.Execute(context);
					break;
				case "ScriptDataTabPanelTabChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataTabPanelTabChange";
					result = ScriptDataTabPanelTabChange.Execute(context, ScriptDataTabPanelTabChangeExecute);
					break;
				case "ExclusiveGateway41234677":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway41234677";
					result = ExclusiveGateway41234677.Execute(context);
					break;
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "BaseModuleEditInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseModuleEditInit";
					result = BaseModuleEditInit.Execute(context);
					break;
				case "ScriptPageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageInit";
					result = ScriptPageInit.Execute(context, ScriptPageInitExecute);
					break;
				case "EditInitializeDetails":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditInitializeDetails";
					result = EditInitializeDetails.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "SubProcesOpenPrintReport":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTaskPrepareParametersPrintReoprtOpen":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPrepareParametersPrintReoprtOpen";
					result = ScriptTaskPrepareParametersPrintReoprtOpen.Execute(context, ScriptTaskPrepareParametersPrintReoprtOpenExecute);
					break;
				case "ScriptTaskClearPrintUserContext":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskClearPrintUserContext";
					result = ScriptTaskClearPrintUserContext.Execute(context, ScriptTaskClearPrintUserContextExecute);
					break;
				case "StartMessagePrintButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePrintButtonClick";
					result = StartMessagePrintButtonClick.Execute(context);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "ScriptTaskSetPrintReportParameters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSetPrintReportParameters";
					result = ScriptTaskSetPrintReportParameters.Execute(context, ScriptTaskSetPrintReportParametersExecute);
					break;
				case "UserTaskOpenPrintReportPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskOpenPrintReportPage";
					result = UserTaskOpenPrintReportPage.Execute(context);
					break;
				case "StartMessageOpenPrintReportMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageOpenPrintReportMessage";
					result = StartMessageOpenPrintReportMessage.Execute(context);
					break;
				case "SubProcessBaseModuleEditPageLoad":
					context.QueueTasks.Dequeue();
					break;
				case "LoadPrintReportButtonMenuProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "LoadPrintReportButtonMenuProcess";
					result = LoadPrintReportButtonMenuProcess.Execute(context);
					break;
				case "StartMessageBasePageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageBasePageLoad";
					result = StartMessageBasePageLoad.Execute(context);
					break;
				case "ScriptTaskPrepareParametersFillPrinReportMenu":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPrepareParametersFillPrinReportMenu";
					result = ScriptTaskPrepareParametersFillPrinReportMenu.Execute(context, ScriptTaskPrepareParametersFillPrinReportMenuExecute);
					break;
				case "ScriptTaskDefPageLoadEnd":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDefPageLoadEnd";
					result = ScriptTaskDefPageLoadEnd.Execute(context, ScriptTaskDefPageLoadEndExecute);
					break;
				case "EventSubProcessCheckBeforePrint":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptPrepeareSaveBeforePrintParams":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPrepeareSaveBeforePrintParams";
					result = ScriptPrepeareSaveBeforePrintParams.Execute(context, ScriptPrepeareSaveBeforePrintParamsExecute);
					break;
				case "CheckSaveBeforePrint":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckSaveBeforePrint";
					result = CheckSaveBeforePrint.Execute(context);
					break;
				case "SaveBeforePrintMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveBeforePrintMessage";
					result = SaveBeforePrintMessage.Execute(context);
					break;
				case "NotSaveBeforePrintMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "NotSaveBeforePrintMessage";
					result = NotSaveBeforePrintMessage.Execute(context);
					break;
				case "IntermediateThrowApplyButtonClick":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowApplyButtonClick.Execute(context);
					break;
				case "IntermediateThrowStartPrintMessage":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowStartPrintMessage.Execute(context);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "StartOpenPrintDevExpressReportMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartOpenPrintDevExpressReportMessage";
					result = StartOpenPrintDevExpressReportMessage.Execute(context);
					break;
				case "ScriptReadOpenPrintParams":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptReadOpenPrintParams";
					result = ScriptReadOpenPrintParams.Execute(context, ScriptReadOpenPrintParamsExecute);
					break;
				case "SetMustSaveBeforePrintScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetMustSaveBeforePrintScriptTask";
					result = SetMustSaveBeforePrintScriptTask.Execute(context, SetMustSaveBeforePrintScriptTaskExecute);
					break;
				case "SavedCanPrintMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SavedCanPrintMessage";
					result = SavedCanPrintMessage.Execute(context);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceSaved";
					result = DataSourceSaved.Execute(context);
					break;
				case "ScriptDataSourceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceSaved";
					result = ScriptDataSourceSaved.Execute(context, ScriptDataSourceSavedExecute);
					break;
				case "ScriptBeforeClose":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptBeforeClose";
					result = ScriptBeforeClose.Execute(context, ScriptBeforeCloseExecute);
					break;
				case "ConfirmIncludeInFolder":
					context.QueueTasks.Dequeue();
					context.SenderName = "ConfirmIncludeInFolder";
					result = ConfirmIncludeInFolder.Execute(context);
					break;
				case "YesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "YesMessage";
					result = YesMessage.Execute(context);
					break;
				case "ScriptYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptYesMessage";
					result = ScriptYesMessage.Execute(context, ScriptYesMessageExecute);
					break;
				case "NoMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "NoMessage";
					result = NoMessage.Execute(context);
					break;
				case "TreeGridLoadRowUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridLoadRowUserTask";
					result = TreeGridLoadRowUserTask.Execute(context);
					break;
				case "ScriptTaskAfterDataSourceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskAfterDataSourceSaved";
					result = ScriptTaskAfterDataSourceSaved.Execute(context, ScriptTaskAfterDataSourceSavedExecute);
					break;
				case "ExclusiveGatewayAfterSave":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGatewayAfterSave";
					result = ExclusiveGatewayAfterSave.Execute(context);
					break;
				case "PreSyncDSS":
					context.QueueTasks.Dequeue();
					context.SenderName = "PreSyncDSS";
					result = PreSyncDSS.Execute(context, PreSyncDSSExecute);
					break;
				case "SyncRecentEntityUserTaskDSS":
					context.QueueTasks.Dequeue();
					context.SenderName = "SyncRecentEntityUserTaskDSS";
					result = SyncRecentEntityUserTaskDSS.Execute(context);
					break;
				case "BaseParallelGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseParallelGateway1";
					result = BaseParallelGateway1.Execute(context);
					break;
				case "BaseExclusiveGateway4":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseExclusiveGateway4";
					result = BaseExclusiveGateway4.Execute(context);
					break;
				case "SubProcessAllowAddDetail":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageRequestAddDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageRequestAddDetailMessage";
					result = StartMessageRequestAddDetailMessage.Execute(context);
					break;
				case "ScriptTaskAllowAddDetail":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskAllowAddDetail";
					result = ScriptTaskAllowAddDetail.Execute(context, ScriptTaskAllowAddDetailExecute);
					break;
				case "AllowAddDetailUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AllowAddDetailUserTask";
					result = AllowAddDetailUserTask.Execute(context);
					break;
				case "ScriptTaskSendAllowMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSendAllowMessage";
					result = ScriptTaskSendAllowMessage.Execute(context, ScriptTaskSendAllowMessageExecute);
					break;
				case "StartMessageAllowAddDetail":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAllowAddDetail";
					result = StartMessageAllowAddDetail.Execute(context);
					break;
				case "SendAllowAddDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SendAllowAddDetailMessage";
					result = SendAllowAddDetailMessage.Execute(context);
					break;
				case "ScriptTaskSendAllowDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSendAllowDetailMessage";
					result = ScriptTaskSendAllowDetailMessage.Execute(context, ScriptTaskSendAllowDetailMessageExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "StartMessageDenyAddDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDenyAddDetailMessage";
					result = StartMessageDenyAddDetailMessage.Execute(context);
					break;
				case "ScriptTaskDenyAddDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDenyAddDetailMessage";
					result = ScriptTaskDenyAddDetailMessage.Execute(context, ScriptTaskDenyAddDetailMessageExecute);
					break;
				case "ScriptTaskPrepareParametersFillPrinReportMenuLoadPrintReportButtonMenuProcessToken":
					context.QueueTasks.Dequeue();
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
				case "MustSaveBeforePrint":
					MustSaveBeforePrint = reader.GetValue<System.Boolean>();
				break;
				case "DataSourceFilters":
					DataSourceFilters = reader.GetSerializableObjectValue();
				break;
				case "DataSourceStructure":
					DataSourceStructure = reader.GetSerializableObjectValue();
				break;
				case "IsValidPage":
					IsValidPage = reader.GetValue<System.Boolean>();
				break;
				case "NeedSave":
					NeedSave = reader.GetValue<System.Boolean>();
				break;
				case "PageableDirection":
					PageableDirection = reader.GetSerializableObjectValue();
				break;
				case "PageRowsCount":
					PageRowsCount = reader.GetValue<System.Int32>();
				break;
				case "ParentGridStructure":
					ParentGridStructure = reader.GetSerializableObjectValue();
				break;
				case "IsSchemaBlocked":
					IsSchemaBlocked = reader.GetValue<System.Boolean>();
				break;
				case "BlockedSchemaMessageText":
					BlockedSchemaMessageText = reader.GetValue<System.String>();
				break;
				case "MenuVideoHelpItemCaption":
					MenuVideoHelpItemCaption = reader.GetValue<System.String>();
				break;
				case "MenuHelpItemCaption":
					MenuHelpItemCaption = reader.GetValue<System.String>();
				break;
				case "ModuleProcessesCaption":
					ModuleProcessesCaption = reader.GetSerializableObjectValue();
				break;
				case "ModuleProcesses":
					ModuleProcesses = reader.GetSerializableObjectValue();
				break;
				case "ParametersInitialized":
					ParametersInitialized = reader.GetValue<System.Boolean>();
				break;
				case "UseModuleDetails":
					UseModuleDetails = reader.GetValue<System.Boolean>();
				break;
				case "IsEdit":
					IsEdit = reader.GetValue<System.Boolean>();
				break;
				case "NotesTabIndex":
					NotesTabIndex = reader.GetValue<System.Int32>();
				break;
				case "PrimaryColumnValue":
					PrimaryColumnValue = reader.GetValue<System.Guid>();
				break;
				case "PrimaryDisplayColumnValue":
					PrimaryDisplayColumnValue = reader.GetValue<System.String>();
				break;
				case "SuccesfullCloseMessage":
					SuccesfullCloseMessage = reader.GetSerializableObjectValue();
				break;
				case "NeedTreeGridRefresh":
					NeedTreeGridRefresh = reader.GetValue<System.Boolean>();
				break;
				case "NotRecivePrintReportMenu":
					NotRecivePrintReportMenu = reader.GetValue<System.Boolean>();
				break;
				case "PrintReportOptionsSchemaUId":
					PrintReportOptionsSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "PrintReportSchemaUId":
					PrintReportSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "NeedSendDetailAllowMessage":
					NeedSendDetailAllowMessage = reader.GetValue<System.Boolean>();
				break;
				case "DoIncludeInSelectedFolder":
					DoIncludeInSelectedFolder = reader.GetValue<System.Boolean>();
				break;
				case "IsCopy":
					IsCopy = reader.GetValue<System.Boolean>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "SelectedFolderId":
					SelectedFolderId = reader.GetValue<System.Guid>();
				break;
				case "IsWindowClose":
					IsWindowClose = reader.GetValue<System.Boolean>();
				break;
				case "HasDetails":
					HasDetails = reader.GetValue<System.Boolean>();
				break;
				case "SysModuleId":
					SysModuleId = reader.GetValue<System.Guid>();
				break;
				case "DefaultParameters":
					DefaultParameters = reader.GetSerializableObjectValue();
				break;
				case "FilterLeftExpression":
					FilterLeftExpression = reader.GetValue<System.String>();
				break;
				case "DetailFilterColumnName":
					DetailFilterColumnName = reader.GetValue<System.String>();
				break;
				case "ActionAfterSaved":
					ActionAfterSaved = reader.GetValue<System.String>();
				break;
				case "EntityPrimaryColumnValue":
					EntityPrimaryColumnValue = reader.GetValue<System.Guid>();
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

		public virtual bool NextButtonClickScriptExecute(ProcessExecutingContext context) {
			PageableDirection = PageableSelectDirection.Next;
			PageRowsCount = 1;
			InitStructureStore(context.ThrowEventArgs);
			if(!IsValidPage) {
				return false;	
			}
			return true;
		}

		public virtual bool ScriptPreviousButtonClickExecute(ProcessExecutingContext context) {
			PageableDirection = PageableSelectDirection.Prior;
			PageRowsCount = 1;
			InitStructureStore(context.ThrowEventArgs);
			if(!IsValidPage) {
				return false;	
			}
			return true;
		}

		public virtual bool PrepareSaveYesNoScriptTaskExecute(ProcessExecutingContext context) {
			SaveYesNoTask.Page = Page;
			SaveYesNoTask.MessageText = SaveBeforePagingMessage;
			SaveYesNoTask.Icon = "QUESTION";
			SaveYesNoTask.Buttons = "YESNO";
			SaveYesNoTask.ResponseMessages = new Dictionary<string, string> {
			                {"yes", "YesPagingMsg"},
			                {"no", "NoPagingMsg"},
			};
			return true;
		}

		public virtual bool PagingScriptExecute(ProcessExecutingContext context) {
			DoPaging(PageRowsCount, (PageableSelectDirection)PageableDirection);
			if (Page.DataTabPanel.ActiveTabIndex!= 0) {
				NotesTabIndex = 0;
				Page.ThrowEvent("DataTabPanelTabChange");
			}
			return true;
		}

		public virtual bool SaveChangesScriptExecute(ProcessExecutingContext context) {
			if (NotesTabIndex > 0) {
				string notes = ((Page.DataTabPanel.Tabs[NotesTabIndex].Items[0] as PageContainer).PageInstance.GetPropertyValue("NotesEdit") as HtmlEdit).Text;
				var converters = new JsonConverter[] {new GuidJsonConverter()};
				string id = Json.Serialize(Page.DataSource.ActiveRow.PrimaryColumnValue, converters[0]);
				Page.ScriptManager.AddScript(Page.DataSource.ClientID + 
					".onActiveRowColumnValuesChangedResponse(" 
					 + id + ",{\"Notes\" : {columnValue: "
					 + Json.Serialize(notes) + "}});");
			}
			string script = @"
				if ({0}.activeRow.modifiedValues) {{
					{0}.save();
					{0}.activeRow.modifiedValues = null;
				}}
			";
			Page.ScriptManager.AddScript(string.Format(script, Page.DataSource.ClientID));
			return true;
		}

		public virtual bool ScriptDesignerModeButtonClickExecute(ProcessExecutingContext context) {
			var pageSchemaUId = Page.Schema.UId.ToString();
			Dictionary <string, string> pageParameters = new Dictionary <string, string>() {
				{"id", pageSchemaUId},
				{"viewMode", "1"},
				{"isUserMode", "1"}
			};
			string IsPrimaryDataSourceSchemaChangedSessionKey = 
				string.Concat("IsPrimaryDataSourceSchemaChangedSessionKey", pageSchemaUId);
			UserConnection.SessionData[IsPrimaryDataSourceSchemaChangedSessionKey] = false;
			OpenPageSchemaDesigner_UserTask.PageParameters = pageParameters;
			OpenPageSchemaDesigner_UserTask.OpenerInstanceId = InstanceUId;
			OpenPageSchemaDesigner_UserTask.PageUrl = "Designers/PageSchemaDesigner.aspx";
			OpenPageSchemaDesigner_UserTask.IgnoreProfile = true;
			OpenPageSchemaDesigner_UserTask.CloseOpenerOnLoad = true;
			OpenPageSchemaDesigner_UserTask.UseCurrentActivePage = true;
			return true;
		}

		public virtual bool GetIsEntitySchemaBlockedScriptTaskExecute(ProcessExecutingContext context) {
			IsSchemaBlocked = false;
			var designedItemSchemaId = UserConnection
				.SessionData[string.Concat(Page.Schema.UId.ToString("N"), "DesignedItemPrimaryEntitySchemaId")];
			Guid entitySchemaId = designedItemSchemaId != null ? (Guid)designedItemSchemaId : Guid.Empty;
			string realEntitySchemaUId = Page.GetParameterValue("entitySchemaUId") as string;
			if (!string.IsNullOrEmpty(realEntitySchemaUId)) {
				Guid realEntitySchemaId = new Guid(realEntitySchemaUId);
				if(realEntitySchemaId != Guid.Empty && entitySchemaId != realEntitySchemaId) {
					entitySchemaId = realEntitySchemaId;
				}
			}
			
			
			var resourceManager = "Terrasoft.WebApp.WorkspaceExplorerModule";
			var entitySchemaManager = UserConnection.Workspace.SchemaManagerProvider
					.GetManager("EntitySchemaManager") as ISchemaManager;
			var pageSchemaManager = UserConnection.Workspace.SchemaManagerProvider
					.GetManager("PageSchemaManager") as ISchemaManager;
			
			
			ISchemaManagerItem entityItem = null;
			if(entitySchemaId != Guid.Empty) {
				entityItem = entitySchemaManager.GetItemByUId(entitySchemaId) as ISchemaManagerItem;
				var entityDesignItem = entitySchemaManager.DesignItem(UserConnection, entityItem.UId);//
				SysSchema schema = new SysSchema(UserConnection);
				schema.FetchFromDB(entityDesignItem.UId);//
				schema.FetchFromDB(entityItem.Id);
				if (!schema.LockedById.IsEmpty() && schema.LockedById != UserConnection.CurrentUser.Id) {
					BlockedSchemaMessageText = string.Format(new LocalizableString(resourceManager,
								"Message.SchemaIsLockedBeforeEditConfirm").Value, schema.LockedByName);
					IsSchemaBlocked = true;
				}
				bool savingWithoutLockingEnabled = (bool)SysSettings.GetValue(UserConnection, "AllowSaveUnlockedSchema");
				if (!savingWithoutLockingEnabled && schema.LockedById.IsEmpty()) {
					BlockedSchemaMessageText = new LocalizableString(resourceManager,
								"Message.SchemaIsNotLockedByYouConfirm").Value;
					IsSchemaBlocked = true;
				}
			}
			var item = pageSchemaManager.FindItemByUId(Page.Schema.UId) as ISchemaManagerItem;
			var pageDesignItem = pageSchemaManager.DesignItem(UserConnection, item.UId);//
			if (string.IsNullOrEmpty(BlockedSchemaMessageText)) {
				SysSchema schema = new SysSchema(UserConnection);
				schema.FetchFromDB(pageDesignItem.UId);//
				schema.FetchFromDB(item.Id);
				if (!schema.LockedById.IsEmpty() && schema.LockedById != UserConnection.CurrentUser.Id) {
					BlockedSchemaMessageText = string.Format(new LocalizableString(resourceManager,
								"Message.SchemaIsLockedBeforeEditConfirm").Value, schema.LockedByName);
					IsSchemaBlocked = true;
				}
				bool savingWithoutLockingEnabled = (bool)SysSettings.GetValue(UserConnection, "AllowSaveUnlockedSchema");
				if (!savingWithoutLockingEnabled && schema.LockedById.IsEmpty()) {
					BlockedSchemaMessageText = new LocalizableString(resourceManager,
								"Message.SchemaIsNotLockedByYouConfirm").Value;
					IsSchemaBlocked = true;
				}
			}
			return true;
		}

		public virtual bool OpenMessageScriptTaskExecute(ProcessExecutingContext context) {
			OpenMessageUserTask.Page = Page;
			OpenMessageUserTask.MessageText = BlockedSchemaMessageText;
			OpenMessageUserTask.Icon = "QUESTION";
			OpenMessageUserTask.Buttons = "YESNO";
			OpenMessageUserTask.ResponseMessages = new Dictionary<string, string> {{"yes", "YesOpenSchema"}, {"no", "NoOpenSchema"}};
			return true;
		}

		public virtual bool PrepareUserTaskParametersScriptTaskExecute(ProcessExecutingContext context) {
			OpenContinueMessageUserTask.Page = Page;
			OpenContinueMessageUserTask.MessageText = ContinueOpenFieldEditorMessage;
			OpenContinueMessageUserTask.Icon = "QUESTION";
			OpenContinueMessageUserTask.Buttons = "YESNO";
			OpenContinueMessageUserTask.ResponseMessages = new Dictionary<string, string> {{"yes", "YesContinueOpenSchema"}, {"no", "NoContinueOpenSchema"}};
			return true;
		}

		public virtual bool ScriptRunModuleProcessExecute(ProcessExecutingContext context) {
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			Guid processKey = new Guid(extraParams["tag"].ToString());
			EntitySchema sysModuleProcessSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysModuleAction");
			var manager = Page.UserConnection.ProcessSchemaManager;
			var schema =  (ProcessSchema)manager.FindInstanceByUId(processKey);
			if (schema == null) {	
				MessageWindowUserTask.MessageText = string.Format(ModuleProcessInstanceNotExistMessage, processKey);
				MessageWindowUserTask.Page = Page;
				Page.ThrowEvent("ShowMessage");
				return true;
			}
			var moduleProcess = schema.CreateProcess(UserConnection);
			if (schema.Parameters.ExistsByName("PageInstanceId")) {
				string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
				string pageInstanceId = instanceId + Page.PageContainer.UniqueID;
				moduleProcess.SetPropertyValue("PageInstanceId", pageInstanceId);
			}
			var treeGridClientId = Page.GetParameterValue("treeGridId") == null ? string.Empty : Page.GetParameterValue("treeGridId").ToString();
			if (!string.IsNullOrEmpty(treeGridClientId) && schema.Parameters.ExistsByName("ActiveTreeGridClientId")) {
				moduleProcess.SetPropertyValue("ActiveTreeGridClientId", treeGridClientId);
			}
			if (schema.Parameters.ExistsByName("ActiveTreeGridCurrentRowId")) {
				var dataSource = Page.DataSource;
				if (dataSource != null) {
					moduleProcess.SetPropertyValue("ActiveTreeGridCurrentRowId", dataSource.ActiveRowPrimaryColumnValue);
				}
			}
			moduleProcess.Execute(Page.UserConnection);
			return true;
		}

		public virtual bool ScriptProcessButtonClickExecute(ProcessExecutingContext context) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var vwSysModuleProcess = entitySchemaManager.GetInstanceByName("VwSysProcess");
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenSelectProcessUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			OpenSelectProcessUserTask.PageParameters = new Dictionary <string, object>();
			string schemaUId = vwSysModuleProcess.UId.ToString();
			var pageParameters = (Dictionary <string, object>)OpenSelectProcessUserTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			pageParameters.Add("lookupPageSchemaUId", "'8504d3e3-191c-45e1-931c-910f90538dd4'");
			pageParameters.Add("customClosedEvent", "ProcessSelected");
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			filters.Add(new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"useDisplayValue", false },
				 	// TODO CR#172401
					{"leftExpressionColumnPath", "SysWorkspace"},
					{"rightExpressionParameterValues", new object[] { Page.UserConnection.Workspace.Id }}
				});
			pageParameters.Add("LookupFilters", filters);		
			return true;
		}

		public virtual bool ScriptRunSelectedProcessExecute(ProcessExecutingContext context) {
			var selectedValues = (Dictionary<string, object>)OpenSelectProcessUserTask.GetSelectedValues(UserConnection);
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
				Guid sysProcessUId = new Guid(recordId);
				var entityManager = Page.UserConnection.EntitySchemaManager;
				var manager = Page.UserConnection.ProcessSchemaManager;
				var processSchema =  (ProcessSchema)manager.FindInstanceByUId(sysProcessUId);
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

		public virtual bool ScriptTaskHidePrinElementsExecute(ProcessExecutingContext context) {
			if (Page.PrintReportButton.Menu.Count > 0) {
				Page.PrintReportButton.Hidden = false;
				Page.PrintReportButton.Enabled = !(IsNew || IsCopy);
			}
			else {
				NotRecivePrintReportMenu = true;
			}
			FillProcessMenu();
			Page.ActionButton.Enabled = !(IsNew || IsCopy);
			return true;
		}

		public virtual bool SyncPreparePLCExecute(ProcessExecutingContext context) {
			SyncRecentEntityUserTaskPLC.SysEntitySchemaId = Page.DataSource.SchemaUId;
			SyncRecentEntityUserTaskPLC.EntityId = EntityPrimaryColumnValue;
			SyncRecentEntityUserTaskPLC.EntityDisplayName = PrimaryDisplayColumnValue;
			
			return true;
		}

		public virtual bool ScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			InitPagingButtons();
			if (Page.DataSource.Schema != null) {
				Page.DataTab.Caption = Page.DataSource.Schema.Caption;
			}
			Page.CancelButton.AjaxEvents.Click.OnClientEvent = "window.close();";
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["SysModule_activeDataSource"] = Page.DataSource.ClientID;
			SuccesfullCloseMessage = Page.GetParameterValue("closeMessage");
			InitializeDesignerModeButton();
			Page.DataSource.EnableServerActiveRow = true;
			var dataSource = Page.DataSource;
			if (dataSource.Schema == null) {
				return true;
			}
			string queryString = Page.Request.QueryString.ToString();
			if (queryString.Contains("recordId")) {
				EntityPrimaryColumnValue = new Guid(Page.Request.QueryString["recordId"].ToString());
			}
			IsNew = EntityPrimaryColumnValue.Equals(Guid.Empty);
			IsCopy = (queryString.Contains("Copy")  && (Page.Request.QueryString["Copy"].ToString() == "true"));
			string primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
			EntityDataSourceUtilities.SynchronizeStructure(dataSource as EntityDataSource);
			foreach (var structureColumn in dataSource.CurrentStructure.Columns) {
				structureColumn.IsAlwaysSelect = true;
			}
			Entity row = null;
			if (IsNew) {
				row = dataSource.CreateRow();
				if (queryString.Contains("createWithUId")) {
					EntityPrimaryColumnValue = new Guid(Page.Request.QueryString["createWithUId"].ToString());
					row.SetColumnValue(row.Schema.PrimaryColumn.Name, EntityPrimaryColumnValue);
				} else {
					EntityPrimaryColumnValue = new Guid(row.GetColumnValue(primaryColumnName).ToString());
				}
				Page.DataSource.CacheItemName = Page.SchemaName + "_" + EntityPrimaryColumnValue.ToString();
				if(DefaultParameters != null) {
					var defParameters = DefaultParameters as Dictionary <string, object>;
					row.SetColumnValue("TypeId", defParameters["TypeId"]);
				}
				var columnNames = new List<string>();			
				var defValues = GetDefValues();
				foreach(var value in defValues) {
					var column = row.Schema.Columns.FindByName(value.Key);
					if (column != null) {
						row.SetColumnValue(column.ColumnValueName, value.Value);
						if (column.IsLookupType && column.ReferenceSchema.PrimaryDisplayColumn != null) {
								columnNames.Add(value.Key);
						}
					}
				}
				foreach (var column in row.Schema.Columns) {
					if (column.HasDefValue && (column.IsLookupType || column.IsMultiLookupType) && !columnNames.Contains(column.Name)) {
						columnNames.Add(column.Name);
					}
				}
				row.LoadLookupDisplayValues(columnNames);
				dataSource.Insert(row);
			} else {
				dataSource.CurrentStructure.Filters.Add(dataSource.CreateFilterWithParameters(FilterComparisonType.Equal,
					primaryColumnName, EntityPrimaryColumnValue));
				var cacheItemName = Page.SchemaName + "_" + EntityPrimaryColumnValue.ToString();
				Page.DataSource.CacheItemName = cacheItemName;
				EntitySchemaQuery.ClearDefCache(Page.UserConnection, cacheItemName);
				dataSource.LoadRows();
				if (IsCopy) {
					row = dataSource.Rows[0].Clone() as Terrasoft.Core.Entities.Entity;
					Guid currentUserContactId = Page.UserConnection.CurrentUser.ContactId;
					EntityPrimaryColumnValue = Guid.NewGuid();
					Page.DataSource.CacheItemName = Page.SchemaName + "_" + EntityPrimaryColumnValue.ToString();
					row.SetColumnValue(primaryColumnName, EntityPrimaryColumnValue);
					row.SetColumnValue("CreatedOn", DateTime.Now);
					row.SetColumnValue("CreatedById", currentUserContactId);
					row.SetColumnValue("ModifiedOn", DateTime.Now);
					row.SetColumnValue("ModifiedById", currentUserContactId);
					var columnNames = new List<string>();
					foreach (var column in row.Schema.Columns) {
						if (column.HasDefValue && (column.IsLookupType || column.IsMultiLookupType) && !columnNames.Contains(column.Name)) {
							columnNames.Add(column.Name);
						}
					}
					row.LoadLookupDisplayValues(columnNames);
					dataSource.Insert(row);
				} 
			}
			dataSource.SetClientActiveRow(EntityPrimaryColumnValue);
			var activeRow = dataSource.ActiveRow;
			if ((IsCopy || IsNew) && activeRow != null) {
				foreach (string columnName in row.GetColumnValueNames()) {
					if (row.GetIsColumnValueLoaded(columnName)) {
						activeRow.SetColumnValue(columnName, row.GetColumnValue(columnName));
					}
				}
			}
			if (queryString.Contains("folderId") && !string.IsNullOrEmpty(Page.Request.QueryString["folderId"])) {
				SelectedFolderId = new Guid(Page.Request.QueryString["folderId"]);
			}
			IsEdit = !IsNew && !IsCopy;
			if(IsEdit) {
				PrimaryDisplayColumnValue = dataSource.Rows[0].GetTypedColumnValue<string>(Page.DataSource.Schema.FindPrimaryDisplayColumnName());
				var processListenersColumnValue = dataSource.Rows[0].GetTypedColumnValue<int>(UserConnection.IProcessEngine.ProcessListenersColumnName);
				if ((processListenersColumnValue & (int)EntityChangeType.Updated) != 0) {
						Page.ScriptManager.AddScript("{0}.setColumnValue('ModifiedOn', {1});", dataSource.ClientID,
							CtorDateTimeJsonConverter.WriteJson(DateTime.Now));
				}
			}
			ShowTip();
			MakeCaption();
			ParametersInitialized = true;
			InitializeContextHelpButton();
			aspPage.CustomData["needAddDetailRequest"] = IsNew || IsCopy;
			
			return true;
		}

		public virtual bool ScriptOKButtonClickExecute(ProcessExecutingContext context) {
			if (NotesTabIndex > 0) {
				string notes = ((Page.DataTabPanel.Tabs[NotesTabIndex].Items[0] as PageContainer).PageInstance.GetPropertyValue("NotesEdit") as HtmlEdit).Text;
				var converters = new JsonConverter[] {new GuidJsonConverter()};
				string id = Json.Serialize(Page.DataSource.ActiveRow.PrimaryColumnValue, converters[0]);
				Page.ScriptManager.AddScript(Page.DataSource.ClientID + 
					".onActiveRowColumnValuesChangedResponse(" 
					 + id + ",{\"Notes\" : {columnValue: "
					 + Json.Serialize(notes) + "}});");
			}
			if (Page.DataSource.Schema == null) {
				return true;
			}
			if (IsCopy) {
				NeedTreeGridRefresh = true;
				Page.ScriptManager.AddScript(Page.DataSource.ClientID + ".save();");
			} else {
				Page.ScriptManager.AddScript(
					"if (" + Page.DataSource.ClientID + ".activeRow.modifiedValues) {" 
						+ Page.DataSource.ClientID + ".save(); " + 
					"} else { window.close(); }"
				);
			}
			IsWindowClose = true;
			return true;
		}

		public virtual bool ScriptTaskSetDefDetailsUserTaskExecute(ProcessExecutingContext context) {
			if (IsNew || IsCopy) {
				SetDetailsNeedAddDetailRequest(true);
			}
			return true;
		}

		public virtual bool ScriptDataTabPanelTabChangeExecute(ProcessExecutingContext context) {
			var detailsTabPanel = Page.DataTabPanel;
			if (detailsTabPanel.Tabs.Count == 0) {
				return true;
			}
			var activeTabIndex = detailsTabPanel.ActiveTabIndex;
			if (Ext.IsAjaxRequest) {
				for (int index = 0; index < detailsTabPanel.Tabs.Count; index++) {
					var tab = detailsTabPanel.Tabs[index];
					if (tab.Items.Count > 0) {
						var pageContainer = tab.Items[0] as Terrasoft.UI.WebControls.Controls.PageContainer;
						var isTabActivated = Page.AspPage.Request.Form[tab.ClientID + "_TabActivated"] == "true";
						if (pageContainer != null) {
							var activePage = pageContainer.PageInstance;
							activePage.ThrowEvent("SetDetailPrintButtonMenu");	
						}
						if (pageContainer == null || isTabActivated) {
							continue;
						}
						activeTabIndex = index;
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
						break;
					}
				}
			} else {
				activeTabIndex = EditInitializeDetails.ActiveTabIndex;
			}
			var recordId = EntityPrimaryColumnValue;
			var activeTab = detailsTabPanel.Tabs[activeTabIndex];
			if (activeTabIndex == 0 || activeTab.Items.Count == 0) {
				return true;
			}
			var detailPageContainer = activeTab.Items[0] as PageContainer;
			if (detailPageContainer == null) {
				return true;
			}
			HasDetails = true;
			if (NotesTabIndex == 0 && detailPageContainer.PageSchemaUId == new Guid("e80efae6-82f0-48d1-bc73-38c9f4981aa4")) {
				NotesTabIndex = activeTabIndex;
				var htmlEdit = detailPageContainer.PageInstance.GetPropertyValue("NotesEdit") as HtmlEdit;
				var notes = Page.DataSource.ActiveRow.GetTypedColumnValue<string>("Notes");
				Page.ScriptManager.AddScript(htmlEdit.ClientID + ".setValue(" + Json.Serialize(notes) + ");");
			}
			bool isNewRecord = IsNew || IsCopy;
			var detailProcess = detailPageContainer.PageInstance.Process;
			var filterLeftExpression = detailProcess.GetPropertyValue("FilterLeftExpression") as Array;
			var parentColumnMetaPath = detailProcess.GetPropertyValue("ParentColumnMetaPath") == null ? 
			string.Empty : detailProcess.GetPropertyValue("ParentColumnMetaPath").ToString();
			SetDetailFilter.SysEntitySchemaId = Page.DataSource.SchemaUId;
			SetDetailFilter.ParentColumnMetaPath = parentColumnMetaPath;
			SetDetailFilter.FilterName = "DetailFilter";
			SetDetailFilter.DetailPageContainer = detailPageContainer;
			SetDetailFilter.PageDataSource = Page.DataSource;
			SetDetailFilter.DetailPageFilterName = "DataSourceFilter";
			SetDetailFilter.ThrowEventName = "GridPageRefreshRow";
			SetDetailFilter.FilterLeftExpressions = filterLeftExpression;
			SetDetailFilter.FilterRightValue = EntityPrimaryColumnValue;
			detailPageContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", EntityPrimaryColumnValue);
			return true;
		}

		public virtual bool ScriptPageInitExecute(ProcessExecutingContext context) {
			if (EntityPrimaryColumnValue == Guid.Empty) {
				var isNew = Page.GetParameterValue("recordId");
				if (isNew != null) {
					IsNew = (new Guid(isNew.ToString()) == Guid.Empty);
				}
				var isCopy = Page.GetParameterValue("Copy");
				if (isCopy != null) {
					IsCopy = (isCopy.ToString().ToLower() == "true");
				}
			}
			HasDetails = true;
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			Page.PreviousButton.AjaxEvents.Click.CausesValidation = true;
			Page.NextButton.AjaxEvents.Click.CausesValidation = true;
			
			if (!ParametersInitialized) {
				UseModuleDetails = true;
				if (Page.GetParameterValue("SysModuleEditId") != null) {
					var sysModuleEditUId = new Guid(Page.GetParameterValue("SysModuleEditId").ToString());
					var entitySchemaManager = UserConnection.EntitySchemaManager;
					var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleEdit");
					var useModuleDetailsColumnName = entitySchemaQuery.AddColumn("UseModuleDetails").Name;
					var helpContextIdColumnName = entitySchemaQuery.AddColumn("HelpContextId").Name;
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						entitySchemaQuery.RootSchema.GetPrimaryColumnName(), sysModuleEditUId));
					var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
					if (entities.Count > 0) {
						UseModuleDetails = entities[0].GetTypedColumnValue<bool>(useModuleDetailsColumnName);
						if (!UseModuleDetails) {
							EditInitializeDetails.SysModuleEditId = sysModuleEditUId;
						}
						string helpContextId = entities[0].GetTypedColumnValue<string>(helpContextIdColumnName);
						if (!string.IsNullOrEmpty(helpContextId)) {
							((TSWebControls.WebControl)Page.PageContainer).HelpContextId = helpContextId;
						}
					}
				}
				if (Page.GetParameterValue("SysModuleId") != null) {
					var sysModuleId = new Guid(Page.GetParameterValue("SysModuleId").ToString());
					if (sysModuleId != Guid.Empty) {
						SysModuleId = sysModuleId;
					}
				} else {
					SysModuleId = GetSysModuleId();
				}
			}
			EditInitializeDetails.SysModuleId = SysModuleId;
			EditInitializeDetails.DetailTabPanel = Page.DataTabPanel;
			EditInitializeDetails.InModuleEdit = true;
			EditInitializeDetails.UseModuleDetails = UseModuleDetails;
			EditInitializeDetails.ParentSysEntitySchemaId = Page.DataSource.SchemaUId;
			EditInitializeDetails.DefaultCollapsed = Page.DataTabPanel.Collapsed;
			Page.DataSource.BeforeSaveRow += delegate(object sender, DataSourceEventArgs e) {
				e.Cancel = !AreConditionsCorrect(e.Row);
			};
			Page.DataSource.SaveError +=
			delegate(object sender, DataSourceEventArgs e) {
				ShowErrorMessage(e.Exception.Message);
				e.IsHandled = true;
			};
			Page.DataSource.RemoveError +=
			delegate(object sender, DataSourceEventArgs e) {
				ShowErrorMessage(e.Exception.Message);
				e.IsHandled = true;
			};
			var AspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			if (AspPage.UseProfile) {
				AspPage.InitializeProfile(new ProfileKeyEventArgs());
				if (!Ext.IsAjaxRequest) {
					Page.DataTabPanel.UseProfile = false;
				}
			}
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptTaskPrepareParametersPrintReoprtOpenExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptTaskClearPrintUserContextExecute(ProcessExecutingContext context) {
			UserConnection.SessionData.Remove("PrintReportParameters");
			return true;
		}

		public virtual bool ScriptTaskSetPrintReportParametersExecute(ProcessExecutingContext context) {
			if (PrintReportSchemaUId == Guid.Empty) {
				return true;
			}
			UserTaskOpenPrintReportPage.OpenerInstanceId = InstanceUId;
			UserTaskOpenPrintReportPage.PageUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager");
			var pageSchema = pageSchemaManager.GetInstanceByUId(new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964")) 
								as PageSchema;
			var parameters = new Dictionary<string,string>();
			parameters.Add("ReportSchemaUId",PrintReportSchemaUId.ToString());
			parameters.Add("EntitySchemaUId", Page.DataSource.Schema.UId.ToString());
			if (PrintReportOptionsSchemaUId != Guid.Empty) {
				parameters.Add("OptionPageSchemaUId", PrintReportOptionsSchemaUId.ToString());
			}
			UserTaskOpenPrintReportPage.PageParameters = parameters;
			UserTaskOpenPrintReportPage.Centered = true;
			UserTaskOpenPrintReportPage.Width = pageSchema.Width;
			UserTaskOpenPrintReportPage.Height = pageSchema.Height;
			UserTaskOpenPrintReportPage.CloseOpenerOnLoad = false;
			var selectedRows = GetPrintSelectedActiveRows();
			UserConnection.SessionData[PrintReportSchemaUId.ToString() + "_SelectedActiveRows"] = selectedRows;		
			UserConnection.SessionData[PrintReportSchemaUId.ToString() + "_OpenMode"] = "EditPageMode";
			return true;
		}

		public virtual bool ScriptTaskPrepareParametersFillPrinReportMenuExecute(ProcessExecutingContext context) {
			LoadPrintReportButtonMenuProcess.SetPropertyValue("SysModuleId",SysModuleId);
			LoadPrintReportButtonMenuProcess.SetPropertyValue("Menu", Page.PrintReportButton.Menu);
			return true;
		}

		public virtual bool ScriptTaskDefPageLoadEndExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptPrepeareSaveBeforePrintParamsExecute(ProcessExecutingContext context) {
			CheckSaveBeforePrint.Page = Page;
			CheckSaveBeforePrint.MessageText = SaveBeforePrintQuestionMessage;
			CheckSaveBeforePrint.Icon = "INFORMATION";
			CheckSaveBeforePrint.Buttons = "YESNO";
			CheckSaveBeforePrint.ResponseMessages = new Dictionary<string, string> {{"yes", "SaveBeforePrintMessage"}, {"no", "NotSaveBeforePrintMessage"}};
			return true;
		}

		public virtual bool ScriptReadOpenPrintParamsExecute(ProcessExecutingContext context) {
			var contextParameters = context.ThrowEventArgs as Dictionary<string, object>;
			if (contextParameters.ContainsKey("tag")) {
				var parameters = contextParameters["tag"].ToString().Split('&');
				if (parameters.Length > 1) {
					PrintReportSchemaUId = new Guid(parameters[0]);
					PrintReportOptionsSchemaUId = new Guid(parameters[1]);
				}
			}
			return true;
		}

		public virtual bool SetMustSaveBeforePrintScriptTaskExecute(ProcessExecutingContext context) {
			MustSaveBeforePrint = true;
			Page.ScriptManager.AddScript(
					"if (" + Page.DataSource.ClientID + ".activeRow.modifiedValues) {" 
						+ Page.DataSource.ClientID + ".save(); " + 
					"}"
				);
			return true;
		}

		public virtual bool ScriptDataSourceSavedExecute(ProcessExecutingContext context) {
			DataSourceSavedMethod(context);
			return true;
		}

		public virtual bool ScriptBeforeCloseExecute(ProcessExecutingContext context) {
			var currentEntity = Page.DataSource.ActiveRow;
			if (currentEntity != null) {
				PrimaryColumnValue = currentEntity.PrimaryColumnValue;
				PrimaryDisplayColumnValue = currentEntity.PrimaryDisplayColumnValue;
			}
			if (SelectedFolderId != null && !SelectedFolderId.Equals(Guid.Empty) && (IsNew || IsCopy) && GetIsStaticNotRootFolder(SelectedFolderId)) {
				ConfirmIncludeInFolder.Page = Page;
				ConfirmIncludeInFolder.MessageText = IncludeInFolderMessage;
				ConfirmIncludeInFolder.Icon = "QUESTION";
				ConfirmIncludeInFolder.Buttons = "YESNO";
				ConfirmIncludeInFolder.ResponseMessages = new Dictionary<string, string> {{"yes", "YesMessage"}, {"no", "NoMessage"}};
				DoIncludeInSelectedFolder = true;
			}
			return true;
		}

		public virtual bool ScriptYesMessageExecute(ProcessExecutingContext context) {
			if (IsNew || IsCopy) {
				IncludeInSelectedFolder(SelectedFolderId);
			}
			SelectedFolderId = Guid.Empty;
			return true;
		}

		public virtual bool ScriptTaskAfterDataSourceSavedExecute(ProcessExecutingContext context) {
			if (IsWindowClose) {
				(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			}
			else {
				if (NeedSendDetailAllowMessage) {
					Page.ThrowEvent("SendAllowAddDetailMessage");
					NeedSendDetailAllowMessage = false;
				}
				IsNew = false;
				IsCopy = false;
				SetDetailsNeedAddDetailRequest(false);
				Page.PrintReportButton.Enabled = true;
				
				if(MustSaveBeforePrint){
					MustSaveBeforePrint = false;
					Page.ThrowEvent("SavedCanPrint");
				}
			}
			return true;
		}

		public virtual bool PreSyncDSSExecute(ProcessExecutingContext context) {
			SyncRecentEntityUserTaskDSS.SysEntitySchemaId = Page.DataSource.SchemaUId;
			
			SyncRecentEntityUserTaskDSS.EntityId = EntityPrimaryColumnValue;
			SyncRecentEntityUserTaskDSS.EntityDisplayName = PrimaryDisplayColumnValue;
			
			return true;
		}

		public virtual bool ScriptTaskAllowAddDetailExecute(ProcessExecutingContext context) {
			NeedSendDetailAllowMessage = false;
			AllowAddDetailUserTask.Page = Page;
			AllowAddDetailUserTask.MessageText = NewRecordNotSavedMessage;
			AllowAddDetailUserTask.Icon = "QUESTION";
			AllowAddDetailUserTask.Buttons = "YESNO";
			AllowAddDetailUserTask.ResponseMessages = new Dictionary<string, string> {{"yes", "AllowAddDetailMessage"},
																					{"no", "DenyAddDetailMessage"}};
			return true;
		}

		public virtual bool ScriptTaskSendAllowMessageExecute(ProcessExecutingContext context) {
			NeedSendDetailAllowMessage = true;
			if (Page.DataSource.Schema == null) {
				return true;
			}
			if (NotesTabIndex > 0) {
				string notes = ((Page.DataTabPanel.Tabs[NotesTabIndex].Items[0] as PageContainer).PageInstance.GetPropertyValue("NotesEdit") as HtmlEdit).Text;
				var converters = new JsonConverter[] {new GuidJsonConverter()};
				string id = Json.Serialize(Page.DataSource.ActiveRow.PrimaryColumnValue, converters[0]);
				Page.ScriptManager.AddScript(Page.DataSource.ClientID + 
					".onActiveRowColumnValuesChangedResponse(" 
					 + id + ",{\"Notes\" : {columnValue: "
					 + Json.Serialize(notes) + "}});");
			}
			Page.AddScript(string.Format("if (Ext.FormValidator.validate()) {0}.save();", Page.DataSource.ClientID));
			IsWindowClose = false;
			return true;
		}

		public virtual bool ScriptTaskSendAllowDetailMessageExecute(ProcessExecutingContext context) {
			var detailsTabPanel = Page.DataTabPanel;
			var activeTab = detailsTabPanel.Tabs[detailsTabPanel.ActiveTabIndex];
			var detailPageContainer = activeTab.Items[0] as PageContainer;
			if (NeedSendDetailAllowMessage) {
				detailPageContainer.PageInstance.ThrowEvent("AllowAddDetailMessage");
				NeedSendDetailAllowMessage = false;
			}
			return true;
		}

		public virtual bool ScriptTaskDenyAddDetailMessageExecute(ProcessExecutingContext context) {
			NeedSendDetailAllowMessage = false;
			return true;
		}

		public virtual void IncludeInSelectedFolder(Guid folderId) {
				Terrasoft.Core.Entities.EntitySchema folderEntrySchema = UserConnection.EntitySchemaManager.GetInstanceByName(String.Concat(Page.DataSource.Schema.Name, "InFolder"));
				var folderEntryEntity = folderEntrySchema.CreateEntity(UserConnection);
				folderEntryEntity.SetDefColumnValues();
				folderEntryEntity.SetColumnValue("FolderId", folderId);
				folderEntryEntity.SetColumnValue(String.Concat(Page.DataSource.Schema.Name, "Id"), EntityPrimaryColumnValue);
				folderEntryEntity.Save();
			return;
		}

		public virtual bool AreConditionsCorrect(Entity Row) {
			Page.BaseMessagePanel.Clear();
			return true;
		}

		public virtual void MakeCaption() {
			var columnName = Page.DataSource.Schema.FindPrimaryDisplayColumnName();
			var primaryDisplayColumnName = String.Empty;
			var record = Page.GetParameterValue("recordId");
			var recordId = record != null ? new Guid(record.ToString()) : Guid.Empty;
			var caption = Page.DataSource.Schema.Caption;
			string captionFormat = "{0} ({1})";
			if (!IsNew && !IsCopy) {
				if(string.IsNullOrEmpty(columnName)) {
					captionFormat = "{0}{1}";
				} else {
					primaryDisplayColumnName = Page.DataSource.ActiveRow.GetTypedColumnValue<string>(columnName);
					if(string.IsNullOrEmpty(primaryDisplayColumnName))
						captionFormat = "{0}{1}";
				}
				caption = string.Format(captionFormat, caption, primaryDisplayColumnName);
			}
			else {
				primaryDisplayColumnName = NewRecordCaption;
				caption = string.Format(captionFormat, caption, primaryDisplayColumnName);
			}
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = caption;
		}

		public virtual void SetDetailsNeedAddDetailRequest(bool needRequest) {
			foreach (var tabItem in Page.DataTabPanel.Tabs) {
				if (tabItem.Items.Count > 0) {
					var detailPageContainer = tabItem.Items[0] as PageContainer;
					if (detailPageContainer == null) {
						continue;
					}
					if (detailPageContainer.PageInstance.Process.GetType().GetMember("NeedAddDetailRequest").Length == 1) {
						detailPageContainer.PageInstance.Process.SetPropertyValue("NeedAddDetailRequest", needRequest);			
					}
				}
			}
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["needAddDetailRequest"] = needRequest;
		}

		public virtual object GetPrintSelectedActiveRows() {
			var primaryColumnName = Page.DataSource.CurrentStructure.PrimaryColumnName;
			var SelectedActiveRows = new List<Guid>();
			SelectedActiveRows.Add(EntityPrimaryColumnValue);
			var printSelectedActiveRows = new Dictionary<string, object>();
			printSelectedActiveRows.Add("Item1", Page.DataSource.Schema.Name);
			printSelectedActiveRows.Add("Item2", Page.DataSource.Schema.GetPrimaryColumnName());
			printSelectedActiveRows.Add("Item3", SelectedActiveRows);
			return printSelectedActiveRows;
		}

		public virtual void DataSourceSavedMethod(object context) {
			if (Page.DataSource.ActiveRow != null) {
				PrimaryDisplayColumnValue =	Page.DataSource.ActiveRow.PrimaryDisplayColumnValue;
			}
			NeedTreeGridRefresh = false;
			var treeGridId = Page.GetParameterValue("treeGridId") == null ? String.Empty :
								Page.GetParameterValue("treeGridId").ToString();
			string updateGridRowScript = String.Empty;
			if (treeGridId != String.Empty) {
				TreeGridLoadRowUserTask.Page = Page;
				TreeGridLoadRowUserTask.TreeGridClientID = treeGridId;
				TreeGridLoadRowUserTask.PrimaryColumnValue = EntityPrimaryColumnValue;
				NeedTreeGridRefresh = true;
			}
			if (IsWindowClose && SuccesfullCloseMessage != null) {
				var closeMessage = SuccesfullCloseMessage.ToString();
				if (!string.IsNullOrEmpty(closeMessage)){
					Page.ThrowClientEvent(closeMessage, new List<object>());
				}
			}
		}

		public virtual void ShowErrorMessage(string errorMessage) {
			MessagePanel messagePanel = ControlUtilities.FindControl(
				Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.AddMessage(Warning, errorMessage, MessageType.Warning);
			}
		}

		public virtual Guid GetSysModuleId() {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(entitySchemaManager, "SysModule");
			var sysEntityColumnName = query.AddColumn("SysModuleEntity").Name;
			var sysModuleIdColumnName = query.AddColumn(query.RootSchema.GetPrimaryColumnName()).Name;
			query.Filters.Add(query.CreateFilterWithParameters(
				FilterComparisonType.Equal,
				"SysModuleEntity.SysEntitySchemaUId",
				Page.DataSource.SchemaUId));
			var entities = query.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return entities[0].GetTypedColumnValue<Guid>(sysModuleIdColumnName);
			} else {
				return Guid.Empty;
			}
		}

		public virtual void InitializeContextHelpButton() {
			if (!GetIsContextHelpButtonHidden() && GetIsContextHelpEnabled()) {
				string helpContextId = Page.Schema.HelpContextId;
				var userConnection = Page.UserConnection;
				TSConfiguration.VideoHelpUtilities.InitializeContextHelpButton(Page.ContextHelpButton, helpContextId, MenuHelpItemCaption, MenuVideoHelpItemCaption, userConnection);
			}
		}

		public virtual bool GetIsContextHelpButtonHidden() {
			return true;
		}

		public virtual bool GetIsContextHelpEnabled() {
			return (bool)SysSettings.GetValue(UserConnection, "EnableContextHelp");
		}

		public virtual Dictionary<string, object> GetDefValues() {
			var parentEntityIdObj = Page.GetParameterValue("ParentEntityId");
			var parentEntitySchemaIdObj = Page.GetParameterValue("ParentEntitySchemaId");
			var sysModuleDetailIdObj = Page.GetParameterValue("SysModuleDetailId");
			var useModuleDetailObj = Page.GetParameterValue("UseModuleDetail");
			var parentModuleIdObj = Page.GetParameterValue("parentModuleId");
			var defValues = new Dictionary<string, object>();
			if (sysModuleDetailIdObj == null && parentModuleIdObj != null) {
				var parentModuleId = new Guid(parentModuleIdObj.ToString());
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var query = new EntitySchemaQuery(entitySchemaManager, "SysModuleDetail");
				var idColumnName = query.AddColumn("Id").Name;
				var sysModuleEntitySchemaIdColumnName = query.AddColumn("SysModule.SysModuleEntity.SysEntitySchemaUId").Name;
				query.Filters.Add(query.CreateFilterWithParameters(
					FilterComparisonType.Equal,	"SysModuleGrid.SysModuleEntity.SysEntitySchemaUId", Page.DataSource.SchemaUId));
				query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "SysModule", parentModuleId));
				var entities = query.GetEntityCollection(UserConnection);
				if (entities.Count > 0) {
					sysModuleDetailIdObj = entities[0].GetTypedColumnValue<Guid>(idColumnName);
					useModuleDetailObj = true;
					parentEntitySchemaIdObj = entities[0].GetTypedColumnValue<Guid>(sysModuleEntitySchemaIdColumnName);
				}
			}
			if (parentEntityIdObj != null && sysModuleDetailIdObj != null && useModuleDetailObj != null && parentEntitySchemaIdObj != null) {
				var parentEntitySchemaId = new Guid(parentEntitySchemaIdObj.ToString());
				var parentEntityId = new Guid(parentEntityIdObj.ToString());
				var sysModuleDetailId = new Guid(sysModuleDetailIdObj.ToString());
				var useModuleDetail = Convert.ToBoolean(useModuleDetailObj.ToString());
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				string detailSchemaName = useModuleDetail ? "SysModuleDetailParentAssc" : "SysModuleEditDetailParentAssc";
				Terrasoft.Core.Entities.EntitySchema moduleDetailSchema = entitySchemaManager.GetInstanceByName(detailSchemaName);
				var detailAsscSchemaName = useModuleDetail ? "SysModuleDetailParentAssc" : "SysModuleEditDetailParentAssc";
				var detailEntitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, detailAsscSchemaName);
				var parentColumnMetaPathColumn = detailEntitySchemaQuery.AddColumn("ParentColumnMetaPath");
				var columnMetaPathColumn = detailEntitySchemaQuery.AddColumn("ColumnMetaPath");
				string detailIdColumnName = useModuleDetail ? "SysModuleDetail" : "SysModuleEditDetail";
				detailEntitySchemaQuery.Filters.Add(detailEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					detailIdColumnName, sysModuleDetailId));
				detailEntitySchemaQuery.Filters.Add(detailEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"SysParentAssociationType.Code", "DefValue"));
				var defValuesCollection = detailEntitySchemaQuery.GetEntityCollection(UserConnection);
				if (defValuesCollection.Count > 0) {
					string columnMetaPath = string.Empty;
					string parentColumnMetaPath = string.Empty;
					var parentSchema = entitySchemaManager.GetInstanceByUId(parentEntitySchemaId);
					Terrasoft.Core.Entities.EntitySchemaQuery entitySchemaQuery = new EntitySchemaQuery(parentSchema);                          
					var entityCollectionColumns = new Dictionary<string, string>();
					foreach(var defValue in defValuesCollection) {
						columnMetaPath = defValue.GetTypedColumnValue<string>(columnMetaPathColumn.Name);
						if (!string.IsNullOrEmpty(columnMetaPath)) {
							if (Page.DataSource.Schema.FindSchemaColumnByPath(columnMetaPath) == null) {
								columnMetaPath = Page.DataSource.Schema.GetSchemaColumnPathByMetaPath(columnMetaPath);
							}
						}
						parentColumnMetaPath = defValue.GetTypedColumnValue<string>(parentColumnMetaPathColumn.Name);
						string parentColumnPath = parentColumnMetaPath;
						if (!string.IsNullOrEmpty(parentColumnPath)) {
							if (parentSchema.FindSchemaColumnByPath(parentColumnPath) == null) {
								parentColumnPath = parentSchema.GetSchemaColumnPathByMetaPath(parentColumnMetaPath);
							}
						}
						EntitySchemaQueryColumn parentColumn = entitySchemaQuery.AddColumn(parentColumnPath);
						entityCollectionColumns.Add(columnMetaPath, parentColumn.Name);
					}
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						parentSchema.PrimaryColumn.Name, parentEntityId));
					EntityCollection entityCollection =   entitySchemaQuery.GetEntityCollection(Page.UserConnection);
					if (entityCollection.Count != 0) {
			                foreach (var column in entityCollectionColumns) {
			                var columnValueName = entitySchemaQuery.GetSchema().Columns.GetByName(column.Value).ColumnValueName;
			                defValues.Add(column.Key, entityCollection[0].GetColumnValue(columnValueName));
			            }
			        }
				}
			}
			var typeColumnUIdObj = Page.GetParameterValue("typeColumnUId");
			var typeIdObj = Page.GetParameterValue("typeId");
			if (typeIdObj != null && typeColumnUIdObj != null) {
				var columnName = Page.DataSource.Schema.Columns.GetByUId(new Guid(typeColumnUIdObj.ToString())).Name;
				defValues.Add(columnName, new Guid(typeIdObj.ToString()));
			}
			var defValuesIdObj = Page.GetParameterValue("defValuesId");
			if (defValuesIdObj != null && UserConnection.SessionData[defValuesIdObj.ToString()] != null) {
				var defValuesKey = defValuesIdObj.ToString();
				var values = UserConnection.SessionData[defValuesKey] as Dictionary<string, object>;
				foreach (var item in values) {
					defValues[item.Key] = item.Value;
				}
				UserConnection.SessionData.Remove(defValuesKey);
			}
			return defValues;
		}

		public virtual bool GetIsStaticNotRootFolder(Guid folderId) {
			bool result = false;
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var entitySchemaName = Page.DataSource.Schema.Name;
			var folderSchema = entitySchemaManager.GetInstanceByName(entitySchemaName + "Folder");
			var folder = folderSchema.CreateEntity(UserConnection);
			if (folder.FetchFromDB(folderId)) {
				result = folder.GetTypedColumnValue<Guid>("FolderTypeId") == new Guid("9dc5f6e6-2a61-4de8-a059-de30f4e74f24") && folder.GetColumnValue("ParentId") != null;
			}
			return result;
		}

		public virtual void ShowTip() {
			var tipIdObj = Page.GetParameterValue("tipId");
			if (tipIdObj != null && UserConnection.SessionData[tipIdObj.ToString()] != null) {
				string tip = (string)UserConnection.SessionData[tipIdObj.ToString()];
				MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
				if (messagePanel != null) {
					messagePanel.AddMessage(Tip, tip, MessageType.Information);
				}
			}
		}

		public virtual void FillProcessMenu() {
			var moduleProcessesInfo = GetModuleProcessesInfo();
			var showActionButton = false;
			var button = Page.ActionButton;
			var menu = button.Menu;
			string resourceManagerName = "Terrasoft.WebApp";
			string resourceItemName = "actions.png";
			menu.RemoveAll();
			string script = string.Empty;
			string imageConfigTemplate = "source: 'ResourceManager', resourceManagerName: '{0}', resourceItemName: '{1}'";
			foreach (var processInfo in moduleProcessesInfo) {
				Guid actionId = processInfo.Item1;
				string processCaption = processInfo.Item2;
				Guid processUId = processInfo.Item3;
				bool isUpload = processInfo.Item4;
				if (processUId != Guid.Empty) {
					var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
					menuItem.CreatedByAjax = true;
					menuItem.EnableViewState = false;
					menuItem.UId = Guid.NewGuid();
					menuItem.Name = string.Format("{0}_process_{1}",button.ClientID, processUId.ToString("N"));
					menuItem.Tag = processUId.ToString();
					menuItem.Caption = processCaption;
					menuItem.AjaxEvents.Click.SignalName = "RunModuleProcess";
					menuItem.AjaxEvents.Click.AjaxEventTargetControlID = button.ClientID;
					menuItem.AjaxEvents.Click.ShowLoadMask = true;
					menuItem.AjaxEvents.Click.IsUpload = isUpload;
					script = string.Format("window.{0} = {1};\n", menuItem.ClientID, menuItem.GenerateControlScript(true, null));
					showActionButton = true;
					menu.Add(menuItem);
					script += string.Format("{0}.getMenu().addItem(window.{1});\n", button.ClientID, menuItem.ClientID);
				} else {
					var menuSeparator = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
					menuSeparator.UId = Guid.NewGuid();
					menuSeparator.ID = "ActivitySeparator_" + menuSeparator.UId.ToString("N");
					menuSeparator.CreatedByAjax = true;
					menuSeparator.EnableViewState = false;
					menuSeparator.Caption= processCaption;
					menuSeparator.CaptionColor = Color.FromArgb(0,2,77,156);
					menuSeparator.Hidden = false;
					var separator = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
					menu.Add(menuSeparator);
					script = string.Format("window.{0} = {1};\n", menuSeparator.ClientID, menuSeparator.GenerateControlScript(true, null));
					script += string.Format("{0}.getMenu().addItem(window.{1});\n", button.ClientID, menuSeparator.ClientID);
				}
				Page.AddScript(script);
			}
			script = string.Format("{0}.onContentChanged();\n", button.ClientID);
			Page.AddScript(script);
			button.Hidden = !showActionButton;
		}

		public virtual List<Tuple<Guid, string, Guid, bool>> GetModuleProcessesInfo() {
			var appCache = UserConnection.SessionCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			var actionsCollection = TSConfiguration.CommonUtilities.GetSelectData(
				UserConnection, TSConfiguration.CommonUtilities.GetModuleActionsSelect, appCache, TSConfiguration.CacheUtilities.ActionsCache);
			string captionColumnName = TSConfiguration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleAction", "Caption");
			var result = new List<Tuple<Guid, string, Guid, bool>>();
			Guid actionId;
			string actionCaption;
			Guid actionSchemaUId;
			bool actionImagePresented;
			foreach (var action in actionsCollection) {
				if (new Guid(action["sysModuleId"].ToString()) == SysModuleId) {
					actionId = new Guid(action["sysModuleActionId"].ToString());
					actionCaption = action[captionColumnName].ToString();
					actionSchemaUId = action["sysProcessSchemaId"] == DBNull.Value ? Guid.Empty : new Guid(action["sysProcessSchemaId"].ToString());
					if (actionSchemaUId != Guid.Empty && UserConnection.ProcessSchemaManager.FindItemByUId(actionSchemaUId)== null) {
						continue;
					}
					var processInfo = new Tuple<Guid, string, Guid, bool>(actionId, actionCaption, actionSchemaUId, false);
					result.Add(processInfo);
				}
			}
			return result;
		}

		public virtual void InitializeDesignerModeButton() {
			var isHidden = GetIsDesignerModeButtonHidden();
			Page.DesignerModeButton.Hidden = isHidden;
		}

		public virtual bool GetIsDesignerModeButtonHidden() {
			string primaryEntitySchemaUId = Page.GetParameterValue("entitySchemaUId") as string;
			Guid entitySchemaUId;
			if (string.IsNullOrEmpty(primaryEntitySchemaUId)) {
				var primaryDataSource = (DataSource)Page.Schema.FindPageControlByName(Page.Schema.PrimaryDataSourceName);
				if(primaryDataSource.Schema == null){
					return true;
				}
				entitySchemaUId = primaryDataSource.Schema.UId;
			} else {
				entitySchemaUId = new Guid(primaryEntitySchemaUId);
			}
			var entitySchema = (EntitySchema)UserConnection.EntitySchemaManager.FindItemByUId(entitySchemaUId).Instance;
			if (entitySchema != null && entitySchema.IsDBView) {
				return true;
			}
			var securityEngine = UserConnection.DBSecurityEngine;
			return !securityEngine.GetCanExecuteOperation("CanChangeApplicationTuningMode");
		}

		public virtual bool IsEntityChanged() {
			return Page.DataSource.ActiveRowModified;
		}

		public virtual void DoPaging(int pageRowsCount, PageableSelectDirection pageableDirection) {
			Page.PreviousButton.Enabled = true;
			Page.NextButton.Enabled = true;
			
			var ds = Page.DataSource;
			Guid oldPrimaryColumnValue = ds.ActiveRow.PrimaryColumnValue;
			ds.CacheItemName = String.Empty;
			var dsRequest = new DataSourceRequest();
			ds.PageRowsCount = pageRowsCount;
			dsRequest.PageableDirection = pageableDirection;
			dsRequest.Values["Id"] = ds.ActiveRow.PrimaryColumnValue;
			
			ds.CurrentStructure.Filters.Clear();
			InitDataSourceStructure();
			
			foreach(var column in ds.CurrentStructure.Columns) {
				if(column.OrderDirection != OrderDirection.None) {
					if(ds.ActiveRow.GetTypedColumnValue<object>(column.DisplayColumnName).ToString() == string.Empty) {
						dsRequest.Values[column.DisplayColumnName] = ds.ActiveRow.GetTypedColumnValue<object>(column.DisplayColumnName);
					}
					else
					{
						dsRequest.Values[column.Name] = ds.ActiveRow.GetTypedColumnValue<object>(column.DisplayColumnName);
					}
				}
			}
			LockAjaxEvents((Terrasoft.UI.WebControls.WebControl)Page.MainControlLayout, false);
			
			ds.LoadRows(dsRequest);
			if(ds.Rows.Count != 0) {
				ds.SetClientActiveRow(ds.Rows[0]);
				if(ds.Rows.Count == 1) {
					EnabledPagingButtons();
				}
			} else {
				string primaryColumnName = ds.Schema.PrimaryColumn.Name;
				ds.CurrentStructure.Filters.Add(ds.CreateFilterWithParameters(FilterComparisonType.Equal,
					primaryColumnName, EntityPrimaryColumnValue));
				var cacheItemName = Page.SchemaName + "_" + EntityPrimaryColumnValue.ToString();
				Page.DataSource.CacheItemName = cacheItemName;
				EntitySchemaQuery.ClearDefCache(Page.UserConnection, cacheItemName);
				ds.LoadRows();
				ds.SetClientActiveRow(oldPrimaryColumnValue);
				EnabledPagingButtons();
			}
			LockAjaxEvents((Terrasoft.UI.WebControls.WebControl)Page.MainControlLayout, true);
			EntityPrimaryColumnValue = Page.DataSource.ActiveRowPrimaryColumnValue;
			Page.ScriptManager.AddScript("NeedLoadStructure = false;");
			MakeCaption();
		}

		public virtual void RegisterButtonsScript() {
			Page.ScriptManager.AddScript(@"
			var showRecord = function(sender, e) {
				var isValid = true;
				if (!Ext.FormValidator.validate()) {
					isValid = false;
				}
				if(!window.editPageProccessInstanceId) {
					return;
				}
			
				var tag = sender.tag;
				if (!tag) { return; }
			
			    var needSave = (PageContainer_DataSource.activeRow.modifiedValues != null);
			
				if(!NeedLoadStructure) {
					var serializedStructure = JSON.stringify({
						needSave: needSave,
						isValid: isValid
					});
				} else {
					if (!window.parentGridDataSourceStructure) {
						var params = Ext.urlDecode(window.location.search.substring(1));
						var treeGridId = params && params.treeGridId;
						window.parentGridDataSourceStructure = window.opener[treeGridId].dataSource.structure;
					}
			
					var parentStructure = window.parentGridDataSourceStructure;
			
					var preparedStructure = Ext.apply({}, parentStructure);
					delete preparedStructure.quickViewColumns;
			
					var filters = preparedStructure.filters.encode();
					var serializedFilters = JSON.stringify(filters);
					delete preparedStructure.filters;
					var columns = preparedStructure.columns;
					var serializedColumns = JSON.stringify(columns);
					delete preparedStructure.columns;
					var serializedStructureShallow = JSON.stringify(preparedStructure);	
			
					var serializedStructure = JSON.stringify({
						columns: serializedColumns,
						filters: serializedFilters,
						structure: serializedStructureShallow,
						needSave: needSave,
						isValid: isValid
					}); 
				}
				NeedLoadStructure = false;
				Terrasoft.AjaxMethods.ThrowClientEventWithParameters(editPageProccessInstanceId, tag, serializedStructure, 
							{
			                   eventMask: {
			                            showMask: true,
			                            startDelay: 500,
			                            fitToElement: false,
			                            isDynamicPosition: true,
			                            msgCls: 'x-mask-loading blue',
			                            msg: 'Загрузка'
			                   }
			         		}
			);
			}
			");
			
			Page.ScriptManager.AddScript("{0}.on('click', showRecord, this);", Page.NextButton.ClientID);
			Page.ScriptManager.AddScript("{0}.on('click', showRecord, this);", Page.PreviousButton.ClientID);
		}

		public virtual void InitDataSourceStructure() {
			ParentGridStructure = new Dictionary<string, object>();
			var dataSource = Page.DataSource;
				
			var serializedString = DataSourceFilters.ToString();	
			
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, dataSource){
				PreventRegisteringClientScript = true
			};
			var filters = JsonConvert.DeserializeObject<DataSourceFilterCollection>(
									serializedString, jsonConverter);
			if (filters != null) {
				var existingFilterCollection = dataSource.CurrentStructure.Filters.FindByName(filters.Name) as DataSourceFilterCollection;
				if (existingFilterCollection != null){
					existingFilterCollection.Clear();
					var filtersCollection = filters as DataSourceFilterCollection;
					foreach (var filterItem in filtersCollection) {
						existingFilterCollection.Add(filterItem);
					}
					existingFilterCollection.LogicalOperation = filters.LogicalOperation;
					existingFilterCollection.IsEnabled = filters.IsEnabled;
					existingFilterCollection.IsNot = filters.IsNot;
				}
				else {
					dataSource.CurrentStructure.Filters.Add(filters);
				}
			}
			
			var structureString = DataSourceStructure.ToString();
			
			var jsonConv = new DataSourceStructureColumnJsonConverter(UserConnection, dataSource);
			
			//var structure = JsonConvert.DeserializeObject<DataSourceStructureColumnCollection>(
			//						structureString, jsonConv);
			
			var itemsArray = Json.Deserialize(structureString) as JArray;
			if (itemsArray == null) {
				return;
			}
			string sortColumnPath = string.Empty;
			foreach (JToken token in itemsArray.Children()) {
				int orderPosition = token.Value<int>("orderPosition");
				OrderDirection orderDirection =	(OrderDirection)Enum.Parse(typeof(OrderDirection), token.Value<string>("orderDirection")); 
				string metaPath = token.Value<string>("metaPath");
				DataSourceStructureColumn column = dataSource.CurrentStructure.Columns.FindByMetaPath(metaPath);
				if(column != null) {
					if(orderDirection != OrderDirection.None) {
						sortColumnPath = metaPath;
					}
					column.OrderDirection = orderDirection;
					column.OrderPosition = orderPosition;
				}
			}
		}

		public virtual void InitStructureStore(object args) {
			if (string.IsNullOrEmpty(StructureStoreKey)) {
				StructureStoreKey = Guid.NewGuid().ToString();
			}
			
			var dic = (IDictionary<string, object>)args;
			
			if(((IDictionary<string, object>)args).Count > 2) {
				//UserConnection.SessionData[StructureStoreKey] = args;
				DataSourceFilters = dic["filters"];
				DataSourceStructure = dic["columns"]; 
			}
			NeedSave = (bool)dic["needSave"];
			IsValidPage = (bool)dic["isValid"];
			
			var entity = Page.DataSource.ActiveRow;
			if(NeedSave && entity.GetChangedColumnValues().Count()==1) {
				foreach(var column in entity.GetChangedColumnValues()) { 
					if(column.Name == "Id")	{
						NeedSave = false;
					}
				}
			}
			CheckIsNotesChanged();
		}

		public virtual void EnabledPagingButtons() {
			if((PageableSelectDirection)PageableDirection == PageableSelectDirection.Next) {
				Page.NextButton.Enabled = false;
			}
			if((PageableSelectDirection)PageableDirection == PageableSelectDirection.Prior) {
				Page.PreviousButton.Enabled = false;
			}
		}

		public virtual void LockAjaxEvents(Terrasoft.UI.WebControls.WebControl Control, bool enableAjax) {
			int controlsCount = Control.Controls.Count;
			if (controlsCount > 0) {
				int index = 0;
				while (index < controlsCount) {
					Terrasoft.UI.WebControls.WebControl webControl = 
						Control.Controls[index] as Terrasoft.UI.WebControls.WebControl;
					if (webControl != null) {
						var observable = webControl as Terrasoft.UI.WebControls.Controls.Observable;
						if(observable !=null) {
							if(enableAjax) {
								observable.ResumeAjaxEvents();
							}else {
								observable.SuspendAjaxEvents();
							}
							LockAjaxEvents(webControl, enableAjax);
						}
					}
					index++;
				}
			}
		}

		public virtual void InitPagingButtons() {
			var isShowPagingButtons = (bool)SysSettings.GetValue(UserConnection, "ShowEditPageNavigationButtons");
			if(isShowPagingButtons) {
				Page.ScriptManager.AddScript("window.editPageProccessInstanceId = '" + Page.Process.InstanceUId.ToString() + "';");
				Page.ScriptManager.AddScript("var NeedLoadStructure = true;");
				RegisterButtonsScript();
			} else {
				Page.PreviousButton.Hidden = true;
				Page.NextButton.Hidden = true;	
			}
			
			var select = new Select(UserConnection)
							.Column(Func.Count(Column.Asterisk()))
							.From("SysModule")
							.Join(JoinType.Inner, "SysModuleEdit")
							.On("SysModuleEdit", "SysModuleEntityId").IsEqual("SysModule", "SysModuleEntityId")
				            .Where(new QueryColumnExpression("SysModule", "Id")).IsEqual(new QueryParameter(SysModuleId))as Select;
			
			var count =	select.ExecuteScalar<int>();
			
			if(IsNew || IsCopy || count > 1) {
				Page.PreviousButton.Hidden = true;
				Page.NextButton.Hidden = true;	
			}
		}

		public virtual void CheckIsNotesChanged() {
			if (NotesTabIndex != 0) {
				var htmlEdit = (Page.DataTabPanel.Tabs[NotesTabIndex].Items[0] as PageContainer).PageInstance.GetPropertyValue("NotesEdit") as HtmlEdit;
				var notes = Page.DataSource.ActiveRow.GetTypedColumnValue<string>("Notes");
				if (htmlEdit.Text != notes)
					NeedSave = true;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "NextButtonClick":
							if (ActivatedEventElements.Contains("NextButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("NextButtonClickStartMessage");
						}
						break;
					case "PreviousButtonClick":
							if (ActivatedEventElements.Contains("PreviousButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("PreviousButtonClickStartMessage");
						}
						break;
					case "NoPagingMsg":
							if (ActivatedEventElements.Contains("NoMsgStartMessage")) {
							context.QueueTasks.Enqueue("NoMsgStartMessage");
						}
						break;
					case "YesPagingMsg":
							if (ActivatedEventElements.Contains("YesMsgStartMessage")) {
							context.QueueTasks.Enqueue("YesMsgStartMessage");
						}
						break;
					case "DesignerModeButtonClick":
							if (ActivatedEventElements.Contains("DesignerModeButtonClick")) {
							context.QueueTasks.Enqueue("DesignerModeButtonClick");
						}
						break;
					case "NoOpenSchema":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEvent2301")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEvent2301");
					}
					break;
					case "YesOpenSchema":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEvent2302")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEvent2302");
					}
					break;
					case "NoContinueOpenSchema":
					if (ActivatedEventElements.Remove("NotContinueIntermediateCatchMessageEvent")) {
						context.QueueTasks.Enqueue("NotContinueIntermediateCatchMessageEvent");
					}
					break;
					case "YesContinueOpenSchema":
					if (ActivatedEventElements.Remove("YesContinueIntermediateCatchMessageEvent")) {
						context.QueueTasks.Enqueue("YesContinueIntermediateCatchMessageEvent");
					}
					break;
					case "RunModuleProcess":
							if (ActivatedEventElements.Contains("StartRunModuleProcess")) {
							context.QueueTasks.Enqueue("StartRunModuleProcess");
						}
						break;
					case "ProcessButtonClick":
							if (ActivatedEventElements.Contains("StartProcessButtonClick")) {
							context.QueueTasks.Enqueue("StartProcessButtonClick");
						}
						break;
					case "ProcessSelected":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEventProcessSelected")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEventProcessSelected");
					}
					break;
					case "ShowMessage":
							if (ActivatedEventElements.Contains("StartShowMessage")) {
							context.QueueTasks.Enqueue("StartShowMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClick")) {
							context.QueueTasks.Enqueue("OKButtonClick");
						}
						break;
					case "DataTabPanelTabChange":
							if (ActivatedEventElements.Contains("DataTabPanelTabChange")) {
							context.QueueTasks.Enqueue("DataTabPanelTabChange");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("BaseModuleEditInit")) {
							context.QueueTasks.Enqueue("BaseModuleEditInit");
						}
						break;
					case "PrintButtonClick":
							if (ActivatedEventElements.Contains("StartMessagePrintButtonClick")) {
							context.QueueTasks.Enqueue("StartMessagePrintButtonClick");
						}
						break;
					case "StartPrintMessage":
							if (ActivatedEventElements.Contains("StartMessageOpenPrintReportMessage")) {
							context.QueueTasks.Enqueue("StartMessageOpenPrintReportMessage");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("StartMessageBasePageLoad")) {
							context.QueueTasks.Enqueue("StartMessageBasePageLoad");
						}
						break;
					case "SaveBeforePrintMessage":
							if (ActivatedEventElements.Contains("SaveBeforePrintMessage")) {
							context.QueueTasks.Enqueue("SaveBeforePrintMessage");
						}
						break;
					case "NotSaveBeforePrintMessage":
							if (ActivatedEventElements.Contains("NotSaveBeforePrintMessage")) {
							context.QueueTasks.Enqueue("NotSaveBeforePrintMessage");
						}
						break;
					case "OpenPrintDevExpressReportMessage":
							if (ActivatedEventElements.Contains("StartOpenPrintDevExpressReportMessage")) {
							context.QueueTasks.Enqueue("StartOpenPrintDevExpressReportMessage");
						}
						break;
					case "SavedCanPrint":
							if (ActivatedEventElements.Contains("SavedCanPrintMessage")) {
							context.QueueTasks.Enqueue("SavedCanPrintMessage");
						}
						break;
					case "DataSourceSaved":
							if (ActivatedEventElements.Contains("DataSourceSaved")) {
							context.QueueTasks.Enqueue("DataSourceSaved");
						}
						break;
					case "YesMessage":
							if (ActivatedEventElements.Contains("YesMessage")) {
							context.QueueTasks.Enqueue("YesMessage");
						}
						break;
					case "NoMessage":
							if (ActivatedEventElements.Contains("NoMessage")) {
							context.QueueTasks.Enqueue("NoMessage");
						}
						break;
					case "RequestAddDetailMessage":
							if (ActivatedEventElements.Contains("StartMessageRequestAddDetailMessage")) {
							context.QueueTasks.Enqueue("StartMessageRequestAddDetailMessage");
						}
						break;
					case "AllowAddDetailMessage":
							if (ActivatedEventElements.Contains("StartMessageAllowAddDetail")) {
							context.QueueTasks.Enqueue("StartMessageAllowAddDetail");
						}
						break;
					case "SendAllowAddDetailMessage":
							if (ActivatedEventElements.Contains("SendAllowAddDetailMessage")) {
							context.QueueTasks.Enqueue("SendAllowAddDetailMessage");
						}
						break;
					case "DenyAddDetailMessage":
							if (ActivatedEventElements.Contains("StartMessageDenyAddDetailMessage")) {
							context.QueueTasks.Enqueue("StartMessageDenyAddDetailMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("MustSaveBeforePrint") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MustSaveBeforePrint", MustSaveBeforePrint, false);
			}
			if (DataSourceFilters != null) {
				if (DataSourceFilters.GetType().IsSerializable ||
					DataSourceFilters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DataSourceFilters", DataSourceFilters, null);
				}
			}
			if (DataSourceStructure != null) {
				if (DataSourceStructure.GetType().IsSerializable ||
					DataSourceStructure.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DataSourceStructure", DataSourceStructure, null);
				}
			}
			if (!HasMapping("IsValidPage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsValidPage", IsValidPage, false);
			}
			if (!HasMapping("NeedSave") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedSave", NeedSave, false);
			}
			if (PageableDirection != null) {
				if (PageableDirection.GetType().IsSerializable ||
					PageableDirection.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("PageableDirection", PageableDirection, null);
				}
			}
			if (!HasMapping("PageRowsCount") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PageRowsCount", PageRowsCount, 0);
			}
			if (ParentGridStructure != null) {
				if (ParentGridStructure.GetType().IsSerializable ||
					ParentGridStructure.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ParentGridStructure", ParentGridStructure, null);
				}
			}
			if (!HasMapping("IsSchemaBlocked") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSchemaBlocked", IsSchemaBlocked, false);
			}
			if (!HasMapping("BlockedSchemaMessageText") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("BlockedSchemaMessageText", BlockedSchemaMessageText, null);
			}
			if (!HasMapping("MenuVideoHelpItemCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MenuVideoHelpItemCaption", MenuVideoHelpItemCaption, null);
			}
			if (!HasMapping("MenuHelpItemCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MenuHelpItemCaption", MenuHelpItemCaption, null);
			}
			if (ModuleProcessesCaption != null) {
				if (ModuleProcessesCaption.GetType().IsSerializable ||
					ModuleProcessesCaption.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ModuleProcessesCaption", ModuleProcessesCaption, null);
				}
			}
			if (ModuleProcesses != null) {
				if (ModuleProcesses.GetType().IsSerializable ||
					ModuleProcesses.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ModuleProcesses", ModuleProcesses, null);
				}
			}
			if (!HasMapping("ParametersInitialized") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParametersInitialized", ParametersInitialized, false);
			}
			if (!HasMapping("UseModuleDetails") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UseModuleDetails", UseModuleDetails, false);
			}
			if (!HasMapping("IsEdit") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEdit", IsEdit, false);
			}
			if (!HasMapping("NotesTabIndex") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NotesTabIndex", NotesTabIndex, 0);
			}
			if (!HasMapping("PrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PrimaryColumnValue", PrimaryColumnValue, Guid.Empty);
			}
			if (!HasMapping("PrimaryDisplayColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PrimaryDisplayColumnValue", PrimaryDisplayColumnValue, null);
			}
			if (SuccesfullCloseMessage != null) {
				if (SuccesfullCloseMessage.GetType().IsSerializable ||
					SuccesfullCloseMessage.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SuccesfullCloseMessage", SuccesfullCloseMessage, null);
				}
			}
			if (!HasMapping("NeedTreeGridRefresh") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedTreeGridRefresh", NeedTreeGridRefresh, false);
			}
			if (!HasMapping("NotRecivePrintReportMenu") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NotRecivePrintReportMenu", NotRecivePrintReportMenu, false);
			}
			if (!HasMapping("PrintReportOptionsSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PrintReportOptionsSchemaUId", PrintReportOptionsSchemaUId, Guid.Empty);
			}
			if (!HasMapping("PrintReportSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PrintReportSchemaUId", PrintReportSchemaUId, Guid.Empty);
			}
			if (!HasMapping("NeedSendDetailAllowMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedSendDetailAllowMessage", NeedSendDetailAllowMessage, false);
			}
			if (!HasMapping("DoIncludeInSelectedFolder") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DoIncludeInSelectedFolder", DoIncludeInSelectedFolder, false);
			}
			if (!HasMapping("IsCopy") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCopy", IsCopy, false);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("SelectedFolderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedFolderId", SelectedFolderId, Guid.Empty);
			}
			if (!HasMapping("IsWindowClose") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsWindowClose", IsWindowClose, false);
			}
			if (!HasMapping("HasDetails") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HasDetails", HasDetails, false);
			}
			if (!HasMapping("SysModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
			}
			if (DefaultParameters != null) {
				if (DefaultParameters.GetType().IsSerializable ||
					DefaultParameters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DefaultParameters", DefaultParameters, null);
				}
			}
			if (!HasMapping("FilterLeftExpression") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FilterLeftExpression", FilterLeftExpression, null);
			}
			if (!HasMapping("DetailFilterColumnName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DetailFilterColumnName", DetailFilterColumnName, null);
			}
			if (!HasMapping("ActionAfterSaved") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ActionAfterSaved", ActionAfterSaved, null);
			}
			if (!HasMapping("EntityPrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityPrimaryColumnValue", EntityPrimaryColumnValue, Guid.Empty);
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

	#region Class: BaseModuleEditPageEventsProcess

	/// <exclude/>
	public class BaseModuleEditPageEventsProcess : BaseModuleEditPageEventsProcess<Terrasoft.WebApp.BaseModuleEditPageSchemaUserControl>
	{

		public BaseModuleEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseModuleEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseModuleEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout RightControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("RightControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel DataTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("DataTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab DataTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("DataTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ProcessButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ProcessButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer PrintReportSpacer {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("PrintReportSpacer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ActionButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ActionButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button PrintReportButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("PrintReportButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DesignerModeButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DesignerModeButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout DataControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("DataControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CustomControls {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CustomControls", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CustomControlsLeft {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CustomControlsLeft", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CustomControlsRight {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CustomControlsRight", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtomButtonLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtomButtonLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer ButtomSpacer {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("ButtomSpacer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OKButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CancelButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button PreviousButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("PreviousButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button NextButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("NextButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("DataSource", true);
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
			DataTabPanel.AjaxEvents.TabChange.Event += DataTabPanelTabChange;
			ProcessButton.AjaxEvents.Click.Event += ProcessButtonClick;
			DesignerModeButton.AjaxEvents.Click.Event += DesignerModeButtonClick;
			OKButton.AjaxEvents.Click.Event += OKButtonClick;
			DataSource.SaveRow += DataSourceSaved;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DataTabPanel.AjaxEvents.TabChange.Event -= DataTabPanelTabChange;
			ProcessButton.AjaxEvents.Click.Event -= ProcessButtonClick;
			DesignerModeButton.AjaxEvents.Click.Event -= DesignerModeButtonClick;
			OKButton.AjaxEvents.Click.Event -= OKButtonClick;
			DataSource.SaveRow -= DataSourceSaved;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseModuleEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseModuleEditPageEventsProcess(UserConnection);
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

		public virtual void DataTabPanelTabChange(object sender, EventArgs e) {
			object result = ThrowEvent("DataTabPanelTabChange");
		}

		public virtual void ProcessButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ProcessButtonClick");
		}

		public virtual void DesignerModeButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DesignerModeButtonClick");
		}

		public virtual void OKButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OKButtonClick");
		}

		public virtual void DataSourceSaved(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceSaved");
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
			SchemaName = "BaseModuleEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseModuleEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseModuleEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseModuleEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseModuleEditPageEventsProcessSchema(BaseModuleEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseModuleEditPageEventsProcess";
			UId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768");
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
			UId = new Guid("ca098cb7-b2c3-4f6c-b9e4-df753a4b852e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0e9a38da-997a-4edf-ad1c-88847bac9548"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EntitySchemaManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFilterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bcb15070-890f-4960-bc2d-7daf6de03d79"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"DataSourceFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("33c5cc14-fe8e-4b63-8ad1-49ba91f72000"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EntityPrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActionAfterSavedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("628cefea-3133-4dd6-ab67-41b58bd7a415"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ActionAfterSaved",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDetailFilterColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3435cb76-485d-49e1-a464-ffd81fcb53e0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"DetailFilterColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterLeftExpressionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("726c456f-a268-4116-b907-7bd86df266ba"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"FilterLeftExpression",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultParametersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("260dd832-0675-49d4-acff-b582ad441964"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"DefaultParameters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4e2e79b0-b6c8-4eb9-8f53-50c28ef63a41"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SysModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHasDetailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("68ca5aad-c305-4ed1-8496-c5f9dc5ed755"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"HasDetails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsWindowCloseParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("29a72bdf-9d73-4bd9-a30d-4bffefacd982"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsWindowClose",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d25c3217-13bd-420a-9460-45c4d3600798"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SelectedFolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d52ffd88-1e88-4c41-8d2e-40d2f20c956e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCopyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ad56eb98-e37e-45c2-aff9-51ef06e2638e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsCopy",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDoIncludeInSelectedFolderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dd66a7f6-4acc-4b84-a256-b5215011f68c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"DoIncludeInSelectedFolder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSendDetailAllowMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba7c417e-ea09-4e5c-bc38-785de618add1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NeedSendDetailAllowMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrintReportSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a933dfa2-10be-4add-95b7-16f6d6d2ba70"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PrintReportSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrintReportOptionsSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ada470d4-7a22-47d5-a8e3-366336c7e53c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PrintReportOptionsSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNotRecivePrintReportMenuParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("21adf86b-bef6-47fc-a9eb-d5d85fcbfbb8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NotRecivePrintReportMenu",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedTreeGridRefreshParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("12aaa2ec-c155-4179-971e-52250a45a58e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NeedTreeGridRefresh",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccesfullCloseMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("67e6c7fb-1900-4a75-b03b-e9468d92b2eb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SuccesfullCloseMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrimaryDisplayColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7e97109a-0088-4c97-bdde-7f92e36ba17f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PrimaryDisplayColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7a376d15-2ee9-4b84-8c55-6611505c6009"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNotesTabIndexParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ca9b88e0-0d42-493c-a61d-cade87825932"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NotesTabIndex",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEditParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("841e274c-5476-459f-ad30-853f75051610"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsEdit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUseModuleDetailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ef52450b-c955-4a6f-aa10-1f0eb080bbdf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"UseModuleDetails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParametersInitializedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a26a9a54-f4a1-4613-ad61-2e25817a75c9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ParametersInitialized",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateModuleProcessesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bf1b1302-4413-4969-bcdf-79db06b69c9e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ModuleProcesses",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateModuleProcessesCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2b19abf9-a16e-4c30-845a-e202f1f87d35"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ModuleProcessesCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMenuHelpItemCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0fd4380c-c2f6-4cbf-a2f9-679760faa63e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"MenuHelpItemCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMenuVideoHelpItemCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("db6cefc9-9ef4-4922-b457-f5402b92b601"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"MenuVideoHelpItemCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateBlockedSchemaMessageTextParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e209c32b-9b11-469b-83c5-867d340d37d4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"BlockedSchemaMessageText",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSchemaBlockedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6322e39c-e443-400d-a070-e33ab9f7e541"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsSchemaBlocked",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentGridStructureParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ea10ed6c-0906-4078-9245-d3e643b67203"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ParentGridStructure",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePageRowsCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("64b2ee42-0391-4585-8589-49589754a5ca"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PageRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePageableDirectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("df65d57d-b8b6-4149-accc-e2b53152b574"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PageableDirection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateStructureStoreKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b53bc169-26ba-4a47-a9b0-ae4a10e7e263"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StructureStoreKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c09f694e-43d3-4162-8990-acda871b4274"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NeedSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsValidPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0c944d12-7177-4cbb-8105-8bf0bac2c18e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsValidPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceStructureParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d62e6fd8-934c-4e0a-a01e-be1a92180d30"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"DataSourceStructure",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7e5c3c88-4a33-473c-a6d5-24f6bd6d5298"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMustSaveBeforePrintParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("57b98bba-a224-4bb0-a2b6-a916618d8793"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"MustSaveBeforePrint",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateEntitySchemaManagerNameParameter());
			Parameters.Add(CreateDataSourceFilterParameter());
			Parameters.Add(CreateEntityPrimaryColumnValueParameter());
			Parameters.Add(CreateActionAfterSavedParameter());
			Parameters.Add(CreateDetailFilterColumnNameParameter());
			Parameters.Add(CreateFilterLeftExpressionParameter());
			Parameters.Add(CreateDefaultParametersParameter());
			Parameters.Add(CreateSysModuleIdParameter());
			Parameters.Add(CreateHasDetailsParameter());
			Parameters.Add(CreateIsWindowCloseParameter());
			Parameters.Add(CreateSelectedFolderIdParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateIsCopyParameter());
			Parameters.Add(CreateDoIncludeInSelectedFolderParameter());
			Parameters.Add(CreateNeedSendDetailAllowMessageParameter());
			Parameters.Add(CreatePrintReportSchemaUIdParameter());
			Parameters.Add(CreatePrintReportOptionsSchemaUIdParameter());
			Parameters.Add(CreateNotRecivePrintReportMenuParameter());
			Parameters.Add(CreateNeedTreeGridRefreshParameter());
			Parameters.Add(CreateSuccesfullCloseMessageParameter());
			Parameters.Add(CreatePrimaryDisplayColumnValueParameter());
			Parameters.Add(CreatePrimaryColumnValueParameter());
			Parameters.Add(CreateNotesTabIndexParameter());
			Parameters.Add(CreateIsEditParameter());
			Parameters.Add(CreateUseModuleDetailsParameter());
			Parameters.Add(CreateParametersInitializedParameter());
			Parameters.Add(CreateModuleProcessesParameter());
			Parameters.Add(CreateModuleProcessesCaptionParameter());
			Parameters.Add(CreateMenuHelpItemCaptionParameter());
			Parameters.Add(CreateMenuVideoHelpItemCaptionParameter());
			Parameters.Add(CreateBlockedSchemaMessageTextParameter());
			Parameters.Add(CreateIsSchemaBlockedParameter());
			Parameters.Add(CreateParentGridStructureParameter());
			Parameters.Add(CreatePageRowsCountParameter());
			Parameters.Add(CreatePageableDirectionParameter());
			Parameters.Add(CreateStructureStoreKeyParameter());
			Parameters.Add(CreateNeedSaveParameter());
			Parameters.Add(CreateIsValidPageParameter());
			Parameters.Add(CreateDataSourceStructureParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateMustSaveBeforePrintParameter());
		}

		protected virtual void InitializeLoadPrintReportButtonMenuProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("dc5a8a76-1a3e-41b9-b453-7dec0bfdbbd5"),
				ContainerUId = new Guid("41088c29-9e6e-4b69-b8e4-f6069f688ffa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Name = @"Menu",
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
				UId = new Guid("26505018-330e-4485-902f-00a2ab68f57a"),
				ContainerUId = new Guid("41088c29-9e6e-4b69-b8e4-f6069f688ffa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
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

		protected virtual void InitializeSaveYesNoTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("0cdc842b-6600-4c9b-92f9-d46d7d9fc1e2"),
				ContainerUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
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
				UId = new Guid("08c7743f-d4bc-4008-ad9f-b55c4f4ecba8"),
				ContainerUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
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
				UId = new Guid("0b72fefc-b914-4cd0-8906-4f4a3559b9bb"),
				ContainerUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
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
				UId = new Guid("89c29524-312a-4bf7-9ff0-f9424c46db77"),
				ContainerUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
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
				UId = new Guid("2efde46f-a87a-4194-903a-cf85eb45d26c"),
				ContainerUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
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
				UId = new Guid("91011563-fff6-45fc-9da8-57352146a5de"),
				ContainerUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
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
				UId = new Guid("ee1d0764-3422-4c15-a0c6-7d5f045c74e2"),
				ContainerUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
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
				UId = new Guid("76bbb993-4a11-452e-97f0-94c860acde57"),
				ContainerUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
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

		protected virtual void InitializeOpenPageSchemaDesigner_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d0096559-3984-4224-b7af-d2841dea9556"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("c69a7c9e-3828-4bf1-a61b-172868343b71"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("0294785a-d932-47ec-bfe9-a6a8fbc7b766"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("487238af-4eaf-4002-a103-c778a6ba6904"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("ebc94cc6-9c2c-4f7f-aa09-be9e3087c76b"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("1206a912-c7f7-443c-a8b8-0617914ec706"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("ad1d2e11-6a83-4cec-a7c5-31a79d4c4d06"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("bc35b823-ce90-40ef-94cb-8ef3bf213c02"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("aae01be4-22ba-4e80-b7e5-2279a042725d"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("1d296f92-12a4-4537-a05a-e2ecb51a605e"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("e5852a31-13ab-42e5-9337-5d28a8137532"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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
				UId = new Guid("0af2d168-d5b8-4367-a231-54c20324a9ad"),
				ContainerUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
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

		protected virtual void InitializeOpenMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("fc3acf90-84c0-4662-a10b-4d9e82884c82"),
				ContainerUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
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
				UId = new Guid("435c9fb9-bb18-4c2b-88fd-14a4394f4fd7"),
				ContainerUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
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
				UId = new Guid("7dd4cc69-edfa-4b6e-9aa7-4f2bc3541db3"),
				ContainerUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
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
				UId = new Guid("bd037dd0-5cb6-4dbb-8b1a-07732808f1f1"),
				ContainerUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
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
				UId = new Guid("7c95d1a9-e081-485a-8b70-f678644fba4f"),
				ContainerUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
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
				UId = new Guid("04538f2a-00d7-4c21-824c-2d68995eb898"),
				ContainerUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
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
				UId = new Guid("56f1df8e-9bb2-4ca4-ab85-f5291f038ea3"),
				ContainerUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
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
				UId = new Guid("6c11a03b-1622-498b-91fe-6d163821d74e"),
				ContainerUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
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

		protected virtual void InitializeOpenContinueMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4f1c7d34-8d69-4c08-b9f5-a1f03ce174f1"),
				ContainerUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
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
				UId = new Guid("94d992a9-df2f-4c36-8ef3-558e6eb94b8e"),
				ContainerUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
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
				UId = new Guid("9db23234-6cbb-48e3-88fd-3068dfca2f35"),
				ContainerUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
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
				UId = new Guid("3b25f945-9cdc-415a-aa28-cd3161f563db"),
				ContainerUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
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
				UId = new Guid("5a3abdc7-e37d-4ca2-9570-cb1224e5c7d8"),
				ContainerUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
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
				UId = new Guid("0419aef4-519e-4814-badd-c98439a6b3f1"),
				ContainerUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
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
				UId = new Guid("0de02dd9-0dfb-4f40-9b74-caaaebd6e778"),
				ContainerUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
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
				UId = new Guid("ebd74adf-d473-4d60-9bd8-2e3d85e2f9ab"),
				ContainerUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
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

		protected virtual void InitializeOpenSelectProcessUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("258c0c8f-3da3-4e9b-b99f-62d1a02b4139"),
				ContainerUId = new Guid("b7cf7a53-7bd3-443b-9d16-15ff652bd592"),
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
				UId = new Guid("4e71d46e-108d-4c46-a170-1d1cf6fd7c5e"),
				ContainerUId = new Guid("b7cf7a53-7bd3-443b-9d16-15ff652bd592"),
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
				UId = new Guid("64ca3042-c044-46c2-8d84-aeb167a802fd"),
				ContainerUId = new Guid("b7cf7a53-7bd3-443b-9d16-15ff652bd592"),
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
				UId = new Guid("255dfe16-8326-443b-a96c-394c51c9a7c6"),
				ContainerUId = new Guid("b7cf7a53-7bd3-443b-9d16-15ff652bd592"),
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
				UId = new Guid("61393235-e3af-4b5a-b7d7-9c5464836553"),
				ContainerUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
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
				UId = new Guid("507705e1-3c9c-4638-b0d7-b7948098e2bf"),
				ContainerUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
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
				UId = new Guid("bf961d71-93b7-411e-a0ce-184a701b9a8c"),
				ContainerUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
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
				UId = new Guid("9b0c8726-69d7-402d-aebe-024d1153d462"),
				ContainerUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
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
				UId = new Guid("5838b8be-236d-4a42-a998-035f8894b89c"),
				ContainerUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
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
				UId = new Guid("627db335-1b80-4aec-b3e0-d33ecd6574b5"),
				ContainerUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
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
				UId = new Guid("5fe85101-ac64-46e9-8b56-cc949ef51923"),
				ContainerUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
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
				UId = new Guid("18be65ae-0693-426e-a3f9-027eb31b68c4"),
				ContainerUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
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

		protected virtual void InitializeSyncRecentEntityUserTaskPLCParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("42fe451d-3ec5-41e5-b0cb-b163b2c5e603"),
				ContainerUId = new Guid("bef3d290-08e9-450b-9f21-64bba5311e35"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("cdbcd425-9047-46b3-a412-a26027422c9b"),
				ContainerUId = new Guid("bef3d290-08e9-450b-9f21-64bba5311e35"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Name = @"EntityId",
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
				UId = new Guid("d444991e-b2c9-48fa-9898-7e43247e4258"),
				ContainerUId = new Guid("bef3d290-08e9-450b-9f21-64bba5311e35"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Name = @"EntityDisplayName",
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

		protected virtual void InitializeSetDetailFilterParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ec9659a7-40c0-4728-baaa-c1748293ffb3"),
				ContainerUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
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
				UId = new Guid("a994712a-a719-4d29-9c8e-e422caa13181"),
				ContainerUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
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
				UId = new Guid("7d655bc1-4e6d-4bbe-9da1-599992eaa21f"),
				ContainerUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
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
				UId = new Guid("eec1dc80-189f-4d2c-bc09-6e89ab1b3444"),
				ContainerUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
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
				UId = new Guid("671dcd96-d623-447b-876e-a450740d9d9e"),
				ContainerUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
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
				UId = new Guid("f5cf51cc-a0ca-486a-9211-fd54d9a09474"),
				ContainerUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
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
				UId = new Guid("2b5b69cc-40f5-456a-8b17-4a9e01f91da5"),
				ContainerUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
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
				UId = new Guid("7ef65969-89bb-488c-9995-41404c9a2562"),
				ContainerUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
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
				UId = new Guid("eab39a37-5ba5-489e-b90a-61451f8357ff"),
				ContainerUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
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

		protected virtual void InitializeEditInitializeDetailsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("abbb2fac-ec62-49e7-ab28-64ae874c7b2b"),
				ContainerUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
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
				UId = new Guid("86b832f1-d0e7-4db6-be4c-0de5dd03f0da"),
				ContainerUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
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
				UId = new Guid("48f176ce-ea9a-490a-b3bb-0c3bf93e1d87"),
				ContainerUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
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
				UId = new Guid("385a0bdf-c078-4473-b4e6-12f4dfcf7d99"),
				ContainerUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
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
				UId = new Guid("08dac3a9-ca35-4fc3-a8a5-a0cabf69b7bf"),
				ContainerUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
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
				UId = new Guid("fb1a9263-7433-4d7d-b173-a5594302552b"),
				ContainerUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
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
				UId = new Guid("9ddba714-ac50-46f8-bd77-2f8038555573"),
				ContainerUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
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
				UId = new Guid("b40dd66b-89a4-46c4-bd24-b09a75292e61"),
				ContainerUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
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
				UId = new Guid("4d47f82f-871f-4dc6-8acf-fc99932d7542"),
				ContainerUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
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

		protected virtual void InitializeUserTaskOpenPrintReportPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("3fe85260-c756-4bdf-ac9a-97e94e9204ed"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("3be0edb9-3840-48f7-956a-993fc59feee7"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("9b5bf1b3-c127-4d4b-b28e-1da7c6d31e88"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("0cf46ba1-7345-49e7-b11a-40ff74132c95"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("b2c02561-d4e0-499b-a473-b655a44afee0"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("ccfb2c32-5aca-4669-a932-d1723fe42e54"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("78586ad5-3323-4b99-9338-858393463658"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("2e7c2c73-ef66-4ce1-86b3-edfc1d533ff4"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("47538988-1bea-4bfc-b60f-657021b3451e"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("ec77875a-26e3-48b8-b662-059f0534e87c"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("2b1a6c6f-9a3a-4f8d-ae38-710657153cac"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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
				UId = new Guid("fba5a182-36ae-435f-b394-b26171270cf2"),
				ContainerUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
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

		protected virtual void InitializeCheckSaveBeforePrintParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("677d8797-bb3f-4beb-b4a8-9553d4835a12"),
				ContainerUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
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
				UId = new Guid("1454e8a3-3df4-4115-b9fb-9ad53bf67a25"),
				ContainerUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
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
				UId = new Guid("a8e6629b-7c34-41b0-a2f7-ea52dcc31290"),
				ContainerUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
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
				UId = new Guid("1e1d52fb-ddc1-4faa-ad35-eeb8ab0a7844"),
				ContainerUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
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
				UId = new Guid("5bb16415-a851-4259-b9fd-aa4a11c723ba"),
				ContainerUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
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
				UId = new Guid("af842635-a2e4-45a8-8ca5-14298e446f25"),
				ContainerUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
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
				UId = new Guid("c4f4673b-48f8-456a-ba36-37d1922e6f82"),
				ContainerUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
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
				UId = new Guid("2c4a63df-4054-4164-8699-c85ed7c957fb"),
				ContainerUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
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

		protected virtual void InitializeConfirmIncludeInFolderParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b0259237-4e1f-450e-8663-19001e91d6c9"),
				ContainerUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
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
				UId = new Guid("2d24b6c6-2999-4a4a-b470-055fe08ea5bd"),
				ContainerUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
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
				UId = new Guid("e616cf75-827c-455c-926d-caa783525831"),
				ContainerUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
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
				UId = new Guid("24873a96-c2d0-4628-a7e7-3c284c3c0b1f"),
				ContainerUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
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
				UId = new Guid("5acde2cb-8cfa-4d46-9fa7-3f9921f06e4a"),
				ContainerUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
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
				UId = new Guid("41af40d6-a0e1-46e7-acb5-0e5c9d99133b"),
				ContainerUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
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
				UId = new Guid("710dd0d4-9af6-435d-a915-29743881c188"),
				ContainerUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
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
				UId = new Guid("b6326b13-6fda-44e8-9468-5dc5097f185a"),
				ContainerUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
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

		protected virtual void InitializeTreeGridLoadRowUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d5d2bada-9c0d-4681-8d83-49efb530d189"),
				ContainerUId = new Guid("b2e4ba66-8b06-44c3-934a-e7d88d510a00"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
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
				UId = new Guid("927e8bd6-c199-4447-9e97-5055e8f7bcc0"),
				ContainerUId = new Guid("b2e4ba66-8b06-44c3-934a-e7d88d510a00"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Name = @"TreeGridClientID",
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
				UId = new Guid("00d53693-486e-4a86-994f-84b03f3eb8a3"),
				ContainerUId = new Guid("b2e4ba66-8b06-44c3-934a-e7d88d510a00"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Name = @"PrimaryColumnValue",
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
				UId = new Guid("0409471d-4dd8-4e12-b448-ee3918390c31"),
				ContainerUId = new Guid("b2e4ba66-8b06-44c3-934a-e7d88d510a00"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Name = @"LoadRows",
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

		protected virtual void InitializeSyncRecentEntityUserTaskDSSParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("9fee297d-6945-4af8-9831-64c51e608e34"),
				ContainerUId = new Guid("765a52e9-f0ca-4bd8-812e-bf61ba1bed78"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("86135835-6834-416a-8a67-4ba9e79246b3"),
				ContainerUId = new Guid("765a52e9-f0ca-4bd8-812e-bf61ba1bed78"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Name = @"EntityId",
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
				UId = new Guid("0b386225-b6fb-4cfd-8b7b-0651c2c89e43"),
				ContainerUId = new Guid("765a52e9-f0ca-4bd8-812e-bf61ba1bed78"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				Name = @"EntityDisplayName",
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

		protected virtual void InitializeAllowAddDetailUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5abf8705-0920-4b4c-a0d9-21ad4310e20b"),
				ContainerUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
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
				UId = new Guid("d58b9d42-08e6-4d51-a811-73e943ea5344"),
				ContainerUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
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
				UId = new Guid("5555ec4b-941b-4a06-af85-7861e5c49c52"),
				ContainerUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
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
				UId = new Guid("ab0a5168-bbe3-4d3f-98ce-aeba8ea47d4c"),
				ContainerUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
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
				UId = new Guid("0a9f31e4-90f9-405f-959d-a6e0be74c6a1"),
				ContainerUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
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
				UId = new Guid("48115468-d98a-4411-aa82-1421a3e9b39d"),
				ContainerUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
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
				UId = new Guid("ef718a72-2c96-4148-a8e1-b74c4d9e6067"),
				ContainerUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
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
				UId = new Guid("60449d27-1d45-4cf4-936a-c51adb6101a9"),
				ContainerUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
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
			ProcessSchemaLaneSet schemaLaneSet95 = CreateLaneSet95LaneSet();
			LaneSets.Add(schemaLaneSet95);
			ProcessSchemaLane schemaPagingLane = CreatePagingLaneLane();
			schemaLaneSet95.Lanes.Add(schemaPagingLane);
			ProcessSchemaEventSubProcess pagingeventsubprocess = CreatePagingEventSubProcessEventSubProcess();
			FlowElements.Add(pagingeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess2301 = CreateEventSubProcess2301EventSubProcess();
			FlowElements.Add(eventsubprocess2301);
			ProcessSchemaEventSubProcess eventsubprocessrunmoduleprocess = CreateEventSubProcessRunModuleProcessEventSubProcess();
			FlowElements.Add(eventsubprocessrunmoduleprocess);
			ProcessSchemaEventSubProcess eventsubprocessprocessbuttonclick = CreateEventSubProcessProcessButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocessprocessbuttonclick);
			ProcessSchemaEventSubProcess eventsubprocessshowmessage = CreateEventSubProcessShowMessageEventSubProcess();
			FlowElements.Add(eventsubprocessshowmessage);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess subprocesopenprintreport = CreateSubProcesOpenPrintReportEventSubProcess();
			FlowElements.Add(subprocesopenprintreport);
			ProcessSchemaEventSubProcess subprocessbasemoduleeditpageload = CreateSubProcessBaseModuleEditPageLoadEventSubProcess();
			FlowElements.Add(subprocessbasemoduleeditpageload);
			ProcessSchemaSubProcess loadprintreportbuttonmenuprocess = CreateLoadPrintReportButtonMenuProcessSubProcess();
			subprocessbasemoduleeditpageload.FlowElements.Add(loadprintreportbuttonmenuprocess);
			ProcessSchemaEventSubProcess eventsubprocesscheckbeforeprint = CreateEventSubProcessCheckBeforePrintEventSubProcess();
			FlowElements.Add(eventsubprocesscheckbeforeprint);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess subprocessallowadddetail = CreateSubProcessAllowAddDetailEventSubProcess();
			FlowElements.Add(subprocessallowadddetail);
			ProcessSchemaStartMessageEvent nextbuttonclickstartmessage = CreateNextButtonClickStartMessageStartMessageEvent();
			pagingeventsubprocess.FlowElements.Add(nextbuttonclickstartmessage);
			ProcessSchemaScriptTask nextbuttonclickscript = CreateNextButtonClickScriptScriptTask();
			pagingeventsubprocess.FlowElements.Add(nextbuttonclickscript);
			ProcessSchemaExclusiveGateway ismodifyexclusivegateway = CreateIsModifyExclusiveGatewayExclusiveGateway();
			pagingeventsubprocess.FlowElements.Add(ismodifyexclusivegateway);
			ProcessSchemaScriptTask scriptpreviousbuttonclick = CreateScriptPreviousButtonClickScriptTask();
			pagingeventsubprocess.FlowElements.Add(scriptpreviousbuttonclick);
			ProcessSchemaStartMessageEvent previousbuttonclickstartmessage = CreatePreviousButtonClickStartMessageStartMessageEvent();
			pagingeventsubprocess.FlowElements.Add(previousbuttonclickstartmessage);
			ProcessSchemaScriptTask preparesaveyesnoscripttask = CreatePrepareSaveYesNoScriptTaskScriptTask();
			pagingeventsubprocess.FlowElements.Add(preparesaveyesnoscripttask);
			ProcessSchemaUserTask saveyesnotask = CreateSaveYesNoTaskUserTask();
			pagingeventsubprocess.FlowElements.Add(saveyesnotask);
			ProcessSchemaScriptTask pagingscript = CreatePagingScriptScriptTask();
			pagingeventsubprocess.FlowElements.Add(pagingscript);
			ProcessSchemaScriptTask savechangesscript = CreateSaveChangesScriptScriptTask();
			pagingeventsubprocess.FlowElements.Add(savechangesscript);
			ProcessSchemaStartMessageEvent nomsgstartmessage = CreateNoMsgStartMessageStartMessageEvent();
			pagingeventsubprocess.FlowElements.Add(nomsgstartmessage);
			ProcessSchemaStartMessageEvent yesmsgstartmessage = CreateYesMsgStartMessageStartMessageEvent();
			pagingeventsubprocess.FlowElements.Add(yesmsgstartmessage);
			ProcessSchemaStartMessageEvent designermodebuttonclick = CreateDesignerModeButtonClickStartMessageEvent();
			eventsubprocess2301.FlowElements.Add(designermodebuttonclick);
			ProcessSchemaScriptTask scriptdesignermodebuttonclick = CreateScriptDesignerModeButtonClickScriptTask();
			eventsubprocess2301.FlowElements.Add(scriptdesignermodebuttonclick);
			ProcessSchemaUserTask openpageschemadesigner_usertask = CreateOpenPageSchemaDesigner_UserTaskUserTask();
			eventsubprocess2301.FlowElements.Add(openpageschemadesigner_usertask);
			ProcessSchemaScriptTask getisentityschemablockedscripttask = CreateGetIsEntitySchemaBlockedScriptTaskScriptTask();
			eventsubprocess2301.FlowElements.Add(getisentityschemablockedscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway2301 = CreateExclusiveGateway2301ExclusiveGateway();
			eventsubprocess2301.FlowElements.Add(exclusivegateway2301);
			ProcessSchemaUserTask openmessageusertask = CreateOpenMessageUserTaskUserTask();
			eventsubprocess2301.FlowElements.Add(openmessageusertask);
			ProcessSchemaScriptTask openmessagescripttask = CreateOpenMessageScriptTaskScriptTask();
			eventsubprocess2301.FlowElements.Add(openmessagescripttask);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageevent2301 = CreateIntermediateCatchMessageEvent2301IntermediateCatchMessageEvent();
			eventsubprocess2301.FlowElements.Add(intermediatecatchmessageevent2301);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageevent2302 = CreateIntermediateCatchMessageEvent2302IntermediateCatchMessageEvent();
			eventsubprocess2301.FlowElements.Add(intermediatecatchmessageevent2302);
			ProcessSchemaEndEvent end2301 = CreateEnd2301EndEvent();
			eventsubprocess2301.FlowElements.Add(end2301);
			ProcessSchemaExclusiveGateway issavedentityexclusivegateway = CreateIsSavedEntityExclusiveGatewayExclusiveGateway();
			eventsubprocess2301.FlowElements.Add(issavedentityexclusivegateway);
			ProcessSchemaScriptTask prepareusertaskparametersscripttask = CreatePrepareUserTaskParametersScriptTaskScriptTask();
			eventsubprocess2301.FlowElements.Add(prepareusertaskparametersscripttask);
			ProcessSchemaUserTask opencontinuemessageusertask = CreateOpenContinueMessageUserTaskUserTask();
			eventsubprocess2301.FlowElements.Add(opencontinuemessageusertask);
			ProcessSchemaEndEvent nocontinueexit = CreateNoContinueExitEndEvent();
			eventsubprocess2301.FlowElements.Add(nocontinueexit);
			ProcessSchemaIntermediateCatchMessageEvent notcontinueintermediatecatchmessageevent = CreateNotContinueIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			eventsubprocess2301.FlowElements.Add(notcontinueintermediatecatchmessageevent);
			ProcessSchemaIntermediateCatchMessageEvent yescontinueintermediatecatchmessageevent = CreateYesContinueIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			eventsubprocess2301.FlowElements.Add(yescontinueintermediatecatchmessageevent);
			ProcessSchemaStartMessageEvent startrunmoduleprocess = CreateStartRunModuleProcessStartMessageEvent();
			eventsubprocessrunmoduleprocess.FlowElements.Add(startrunmoduleprocess);
			ProcessSchemaScriptTask scriptrunmoduleprocess = CreateScriptRunModuleProcessScriptTask();
			eventsubprocessrunmoduleprocess.FlowElements.Add(scriptrunmoduleprocess);
			ProcessSchemaStartMessageEvent startprocessbuttonclick = CreateStartProcessButtonClickStartMessageEvent();
			eventsubprocessprocessbuttonclick.FlowElements.Add(startprocessbuttonclick);
			ProcessSchemaScriptTask scriptprocessbuttonclick = CreateScriptProcessButtonClickScriptTask();
			eventsubprocessprocessbuttonclick.FlowElements.Add(scriptprocessbuttonclick);
			ProcessSchemaUserTask openselectprocessusertask = CreateOpenSelectProcessUserTaskUserTask();
			eventsubprocessprocessbuttonclick.FlowElements.Add(openselectprocessusertask);
			ProcessSchemaScriptTask scriptrunselectedprocess = CreateScriptRunSelectedProcessScriptTask();
			eventsubprocessprocessbuttonclick.FlowElements.Add(scriptrunselectedprocess);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageeventprocessselected = CreateIntermediateCatchMessageEventProcessSelectedIntermediateCatchMessageEvent();
			eventsubprocessprocessbuttonclick.FlowElements.Add(intermediatecatchmessageeventprocessselected);
			ProcessSchemaStartMessageEvent startshowmessage = CreateStartShowMessageStartMessageEvent();
			eventsubprocessshowmessage.FlowElements.Add(startshowmessage);
			ProcessSchemaUserTask messagewindowusertask = CreateMessageWindowUserTaskUserTask();
			eventsubprocessshowmessage.FlowElements.Add(messagewindowusertask);
			ProcessSchemaScriptTask scripttaskhideprinelements = CreateScriptTaskHidePrinElementsScriptTask();
			eventsubprocess1.FlowElements.Add(scripttaskhideprinelements);
			ProcessSchemaUserTask syncrecententityusertaskplc = CreateSyncRecentEntityUserTaskPLCUserTask();
			eventsubprocess1.FlowElements.Add(syncrecententityusertaskplc);
			ProcessSchemaScriptTask syncprepareplc = CreateSyncPreparePLCScriptTask();
			eventsubprocess1.FlowElements.Add(syncprepareplc);
			ProcessSchemaIntermediateThrowMessageEvent throwdatatabpaneltabchange = CreateThrowDataTabPanelTabChangeIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(throwdatatabpaneltabchange);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask scriptpageloadcomplete = CreateScriptPageLoadCompleteScriptTask();
			eventsubprocess1.FlowElements.Add(scriptpageloadcomplete);
			ProcessSchemaStartMessageEvent okbuttonclick = CreateOKButtonClickStartMessageEvent();
			eventsubprocess3.FlowElements.Add(okbuttonclick);
			ProcessSchemaScriptTask scriptokbuttonclick = CreateScriptOKButtonClickScriptTask();
			eventsubprocess3.FlowElements.Add(scriptokbuttonclick);
			ProcessSchemaUserTask setdetailfilter = CreateSetDetailFilterUserTask();
			eventsubprocess7.FlowElements.Add(setdetailfilter);
			ProcessSchemaScriptTask scripttasksetdefdetailsusertask = CreateScriptTaskSetDefDetailsUserTaskScriptTask();
			eventsubprocess7.FlowElements.Add(scripttasksetdefdetailsusertask);
			ProcessSchemaStartMessageEvent datatabpaneltabchange = CreateDataTabPanelTabChangeStartMessageEvent();
			eventsubprocess7.FlowElements.Add(datatabpaneltabchange);
			ProcessSchemaScriptTask scriptdatatabpaneltabchange = CreateScriptDataTabPanelTabChangeScriptTask();
			eventsubprocess7.FlowElements.Add(scriptdatatabpaneltabchange);
			ProcessSchemaExclusiveGateway exclusivegateway41234677 = CreateExclusiveGateway41234677ExclusiveGateway();
			eventsubprocess7.FlowElements.Add(exclusivegateway41234677);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			eventsubprocess7.FlowElements.Add(end1);
			ProcessSchemaStartMessageEvent basemoduleeditinit = CreateBaseModuleEditInitStartMessageEvent();
			eventsubprocess2.FlowElements.Add(basemoduleeditinit);
			ProcessSchemaScriptTask scriptpageinit = CreateScriptPageInitScriptTask();
			eventsubprocess2.FlowElements.Add(scriptpageinit);
			ProcessSchemaUserTask editinitializedetails = CreateEditInitializeDetailsUserTask();
			eventsubprocess2.FlowElements.Add(editinitializedetails);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask1);
			ProcessSchemaScriptTask scripttaskprepareparametersprintreoprtopen = CreateScriptTaskPrepareParametersPrintReoprtOpenScriptTask();
			subprocesopenprintreport.FlowElements.Add(scripttaskprepareparametersprintreoprtopen);
			ProcessSchemaScriptTask scripttaskclearprintusercontext = CreateScriptTaskClearPrintUserContextScriptTask();
			subprocesopenprintreport.FlowElements.Add(scripttaskclearprintusercontext);
			ProcessSchemaStartMessageEvent startmessageprintbuttonclick = CreateStartMessagePrintButtonClickStartMessageEvent();
			subprocesopenprintreport.FlowElements.Add(startmessageprintbuttonclick);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			subprocesopenprintreport.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask scripttasksetprintreportparameters = CreateScriptTaskSetPrintReportParametersScriptTask();
			subprocesopenprintreport.FlowElements.Add(scripttasksetprintreportparameters);
			ProcessSchemaUserTask usertaskopenprintreportpage = CreateUserTaskOpenPrintReportPageUserTask();
			subprocesopenprintreport.FlowElements.Add(usertaskopenprintreportpage);
			ProcessSchemaStartMessageEvent startmessageopenprintreportmessage = CreateStartMessageOpenPrintReportMessageStartMessageEvent();
			subprocesopenprintreport.FlowElements.Add(startmessageopenprintreportmessage);
			ProcessSchemaStartMessageEvent startmessagebasepageload = CreateStartMessageBasePageLoadStartMessageEvent();
			subprocessbasemoduleeditpageload.FlowElements.Add(startmessagebasepageload);
			ProcessSchemaScriptTask scripttaskprepareparametersfillprinreportmenu = CreateScriptTaskPrepareParametersFillPrinReportMenuScriptTask();
			subprocessbasemoduleeditpageload.FlowElements.Add(scripttaskprepareparametersfillprinreportmenu);
			ProcessSchemaScriptTask scripttaskdefpageloadend = CreateScriptTaskDefPageLoadEndScriptTask();
			subprocessbasemoduleeditpageload.FlowElements.Add(scripttaskdefpageloadend);
			ProcessSchemaScriptTask scriptprepearesavebeforeprintparams = CreateScriptPrepeareSaveBeforePrintParamsScriptTask();
			eventsubprocesscheckbeforeprint.FlowElements.Add(scriptprepearesavebeforeprintparams);
			ProcessSchemaUserTask checksavebeforeprint = CreateCheckSaveBeforePrintUserTask();
			eventsubprocesscheckbeforeprint.FlowElements.Add(checksavebeforeprint);
			ProcessSchemaStartMessageEvent savebeforeprintmessage = CreateSaveBeforePrintMessageStartMessageEvent();
			eventsubprocesscheckbeforeprint.FlowElements.Add(savebeforeprintmessage);
			ProcessSchemaStartMessageEvent notsavebeforeprintmessage = CreateNotSaveBeforePrintMessageStartMessageEvent();
			eventsubprocesscheckbeforeprint.FlowElements.Add(notsavebeforeprintmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowapplybuttonclick = CreateIntermediateThrowApplyButtonClickIntermediateThrowMessageEvent();
			eventsubprocesscheckbeforeprint.FlowElements.Add(intermediatethrowapplybuttonclick);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowstartprintmessage = CreateIntermediateThrowStartPrintMessageIntermediateThrowMessageEvent();
			eventsubprocesscheckbeforeprint.FlowElements.Add(intermediatethrowstartprintmessage);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			eventsubprocesscheckbeforeprint.FlowElements.Add(exclusivegateway3);
			ProcessSchemaStartMessageEvent startopenprintdevexpressreportmessage = CreateStartOpenPrintDevExpressReportMessageStartMessageEvent();
			eventsubprocesscheckbeforeprint.FlowElements.Add(startopenprintdevexpressreportmessage);
			ProcessSchemaScriptTask scriptreadopenprintparams = CreateScriptReadOpenPrintParamsScriptTask();
			eventsubprocesscheckbeforeprint.FlowElements.Add(scriptreadopenprintparams);
			ProcessSchemaScriptTask setmustsavebeforeprintscripttask = CreateSetMustSaveBeforePrintScriptTaskScriptTask();
			eventsubprocesscheckbeforeprint.FlowElements.Add(setmustsavebeforeprintscripttask);
			ProcessSchemaStartMessageEvent savedcanprintmessage = CreateSavedCanPrintMessageStartMessageEvent();
			eventsubprocesscheckbeforeprint.FlowElements.Add(savedcanprintmessage);
			ProcessSchemaStartMessageEvent datasourcesaved = CreateDataSourceSavedStartMessageEvent();
			subprocess1.FlowElements.Add(datasourcesaved);
			ProcessSchemaScriptTask scriptdatasourcesaved = CreateScriptDataSourceSavedScriptTask();
			subprocess1.FlowElements.Add(scriptdatasourcesaved);
			ProcessSchemaScriptTask scriptbeforeclose = CreateScriptBeforeCloseScriptTask();
			subprocess1.FlowElements.Add(scriptbeforeclose);
			ProcessSchemaUserTask confirmincludeinfolder = CreateConfirmIncludeInFolderUserTask();
			subprocess1.FlowElements.Add(confirmincludeinfolder);
			ProcessSchemaStartMessageEvent yesmessage = CreateYesMessageStartMessageEvent();
			subprocess1.FlowElements.Add(yesmessage);
			ProcessSchemaScriptTask scriptyesmessage = CreateScriptYesMessageScriptTask();
			subprocess1.FlowElements.Add(scriptyesmessage);
			ProcessSchemaStartMessageEvent nomessage = CreateNoMessageStartMessageEvent();
			subprocess1.FlowElements.Add(nomessage);
			ProcessSchemaUserTask treegridloadrowusertask = CreateTreeGridLoadRowUserTaskUserTask();
			subprocess1.FlowElements.Add(treegridloadrowusertask);
			ProcessSchemaScriptTask scripttaskafterdatasourcesaved = CreateScriptTaskAfterDataSourceSavedScriptTask();
			subprocess1.FlowElements.Add(scripttaskafterdatasourcesaved);
			ProcessSchemaExclusiveGateway exclusivegatewayaftersave = CreateExclusiveGatewayAfterSaveExclusiveGateway();
			subprocess1.FlowElements.Add(exclusivegatewayaftersave);
			ProcessSchemaScriptTask presyncdss = CreatePreSyncDSSScriptTask();
			subprocess1.FlowElements.Add(presyncdss);
			ProcessSchemaUserTask syncrecententityusertaskdss = CreateSyncRecentEntityUserTaskDSSUserTask();
			subprocess1.FlowElements.Add(syncrecententityusertaskdss);
			ProcessSchemaParallelGateway baseparallelgateway1 = CreateBaseParallelGateway1ParallelGateway();
			subprocess1.FlowElements.Add(baseparallelgateway1);
			ProcessSchemaExclusiveGateway baseexclusivegateway4 = CreateBaseExclusiveGateway4ExclusiveGateway();
			subprocess1.FlowElements.Add(baseexclusivegateway4);
			ProcessSchemaStartMessageEvent startmessagerequestadddetailmessage = CreateStartMessageRequestAddDetailMessageStartMessageEvent();
			subprocessallowadddetail.FlowElements.Add(startmessagerequestadddetailmessage);
			ProcessSchemaScriptTask scripttaskallowadddetail = CreateScriptTaskAllowAddDetailScriptTask();
			subprocessallowadddetail.FlowElements.Add(scripttaskallowadddetail);
			ProcessSchemaUserTask allowadddetailusertask = CreateAllowAddDetailUserTaskUserTask();
			subprocessallowadddetail.FlowElements.Add(allowadddetailusertask);
			ProcessSchemaScriptTask scripttasksendallowmessage = CreateScriptTaskSendAllowMessageScriptTask();
			subprocessallowadddetail.FlowElements.Add(scripttasksendallowmessage);
			ProcessSchemaStartMessageEvent startmessageallowadddetail = CreateStartMessageAllowAddDetailStartMessageEvent();
			subprocessallowadddetail.FlowElements.Add(startmessageallowadddetail);
			ProcessSchemaStartMessageEvent sendallowadddetailmessage = CreateSendAllowAddDetailMessageStartMessageEvent();
			subprocessallowadddetail.FlowElements.Add(sendallowadddetailmessage);
			ProcessSchemaScriptTask scripttasksendallowdetailmessage = CreateScriptTaskSendAllowDetailMessageScriptTask();
			subprocessallowadddetail.FlowElements.Add(scripttasksendallowdetailmessage);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			subprocessallowadddetail.FlowElements.Add(exclusivegateway1);
			ProcessSchemaStartMessageEvent startmessagedenyadddetailmessage = CreateStartMessageDenyAddDetailMessageStartMessageEvent();
			subprocessallowadddetail.FlowElements.Add(startmessagedenyadddetailmessage);
			ProcessSchemaScriptTask scripttaskdenyadddetailmessage = CreateScriptTaskDenyAddDetailMessageScriptTask();
			subprocessallowadddetail.FlowElements.Add(scripttaskdenyadddetailmessage);
			FlowElements.Add(CreateSequenceFlow721SequenceFlow());
			FlowElements.Add(CreateSequenceFlow722SequenceFlow());
			FlowElements.Add(CreateSequenceFlow725SequenceFlow());
			FlowElements.Add(CreateSequenceFlow726SequenceFlow());
			FlowElements.Add(CreateSequenceFlow727SequenceFlow());
			FlowElements.Add(CreateSequenceFlow728ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow729DataTabPanelTabChangeSequenceFlow());
			FlowElements.Add(CreateSequenceFlow732SequenceFlow());
			FlowElements.Add(CreateSequenceFlow733SequenceFlow());
			FlowElements.Add(CreateSequenceFlow734SequenceFlow());
			FlowElements.Add(CreateSequenceFlow735SequenceFlow());
			FlowElements.Add(CreateSequenceFlow740SequenceFlow());
			FlowElements.Add(CreateSequenceFlow741ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow742SequenceFlow());
			FlowElements.Add(CreateSequenceFlow743SequenceFlow());
			FlowElements.Add(CreateSequenceFlow744SequenceFlow());
			FlowElements.Add(CreateSequenceFlow745SequenceFlow());
			FlowElements.Add(CreateSequenceFlow746SequenceFlow());
			FlowElements.Add(CreateSequenceFlow747SequenceFlow());
			FlowElements.Add(CreateSequenceFlow748SequenceFlow());
			FlowElements.Add(CreateSequenceFlow749SequenceFlow());
			FlowElements.Add(CreateSequenceFlow750SequenceFlow());
			FlowElements.Add(CreateSequenceFlow751SequenceFlow());
			FlowElements.Add(CreateSequenceFlow752SequenceFlow());
			FlowElements.Add(CreateSequenceFlow753ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow754SequenceFlow());
			FlowElements.Add(CreateSequenceFlow755SequenceFlow());
			FlowElements.Add(CreateSequenceFlow756SequenceFlow());
			FlowElements.Add(CreateSequenceFlow757SequenceFlow());
			FlowElements.Add(CreateSequenceFlow758SequenceFlow());
			FlowElements.Add(CreateSequenceFlow759SequenceFlow());
			FlowElements.Add(CreateSequenceFlow760SequenceFlow());
			FlowElements.Add(CreateSequenceFlow761ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow762ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow765SequenceFlow());
			FlowElements.Add(CreateSequenceFlow766SequenceFlow());
			FlowElements.Add(CreateSequenceFlow767SequenceFlow());
			FlowElements.Add(CreateSequenceFlow768SequenceFlow());
			FlowElements.Add(CreateSequenceFlow769SequenceFlow());
			FlowElements.Add(CreateSequenceFlow770ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow771SequenceFlow());
			FlowElements.Add(CreateSequenceFlow772SequenceFlow());
			FlowElements.Add(CreateSequenceFlow773SequenceFlow());
			FlowElements.Add(CreateSequenceFlow775SequenceFlow());
			FlowElements.Add(CreateBaseSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateBaseConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateBaseSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateBaseSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateBaseSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlowScriptProcessButtonClickSequenceFlow());
			FlowElements.Add(CreateSequenceFlowopenSelectProcessSequenceFlow());
			FlowElements.Add(CreateSequenceFlowWaitProcessSelectedSequenceFlow());
			FlowElements.Add(CreateSequenceFlowProcessSelectedSequenceFlow());
			FlowElements.Add(CreateSequenceFlowShowBaseMessageSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1RunModuleProcessSequenceFlow());
			FlowElements.Add(CreateSequenceFlow17781SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17791SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18001SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18011SequenceFlow());
			FlowElements.Add(CreateConditionalFlow18021ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow18031SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18041SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18051SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18061SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18071SequenceFlow());
			FlowElements.Add(CreateNotSavedEntitySequenceFlowSequenceFlow());
			FlowElements.Add(CreateYesEntitySavedConditionalFlowConditionalFlow());
			FlowElements.Add(CreateNoContinueExitSequenceFlowSequenceFlow());
			FlowElements.Add(CreateNoContinueSequenceFlowSequenceFlow());
			FlowElements.Add(CreateYesContinueSequenceFlowSequenceFlow());
			FlowElements.Add(CreatePrepareDesignerWindowSequenceFlowSequenceFlow());
			FlowElements.Add(CreateShowContinueMessageSequenceFlowSequenceFlow());
			FlowElements.Add(CreatePreviousSequenceFlowSequenceFlow());
			FlowElements.Add(CreateNextSequenceFlowSequenceFlow());
			FlowElements.Add(CreateNextIsModifySequenceFlowSequenceFlow());
			FlowElements.Add(CreatePrevIsModifySequenceFlowSequenceFlow());
			FlowElements.Add(CreateIsModifyYesSequenceFlowSequenceFlow());
			FlowElements.Add(CreateInitYesNoUserTaskSequenceFlowSequenceFlow());
			FlowElements.Add(CreateIsModifyNoConditionalFlowConditionalFlow());
			FlowElements.Add(CreateAfterSaveSequenceFlowSequenceFlow());
			FlowElements.Add(CreateNoMsgSequenceFlowSequenceFlow());
			FlowElements.Add(CreateYesMsgSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSavedBeforePrintSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1345435SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1wr325ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow23453432SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateIncludeInFolderMessageLocalizableString());
			LocalizableStrings.Add(CreateNewRecordCaptionLocalizableString());
			LocalizableStrings.Add(CreateEditingRecordCaptionLocalizableString());
			LocalizableStrings.Add(CreateNewRecordNotSavedMessageLocalizableString());
			LocalizableStrings.Add(CreateSaveBeforePrintQuestionMessageLocalizableString());
			LocalizableStrings.Add(CreateWarningLocalizableString());
			LocalizableStrings.Add(CreateTipLocalizableString());
			LocalizableStrings.Add(CreateModuleProcessInstanceNotExistMessageLocalizableString());
			LocalizableStrings.Add(CreateContinueOpenFieldEditorMessageLocalizableString());
			LocalizableStrings.Add(CreateSaveBeforePagingMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateIncludeInFolderMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2a8c3757-735f-4a6e-aab4-9491dfa91338"),
				Name = "IncludeInFolderMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNewRecordCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e752d611-807b-42e7-8e49-50500d969ee3"),
				Name = "NewRecordCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEditingRecordCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("861449d8-cf7a-4cd0-889f-1614588ee192"),
				Name = "EditingRecordCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNewRecordNotSavedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bc1fc93e-7bad-4962-bc44-df8f891eb7f6"),
				Name = "NewRecordNotSavedMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSaveBeforePrintQuestionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ef479715-25a3-4390-bda5-2a07f9db8b4b"),
				Name = "SaveBeforePrintQuestionMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("030c93da-1c74-4386-9835-1d2d73393637"),
				Name = "Warning",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTipLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("de9c33ed-5d00-4ff0-995e-b8f15ce8055a"),
				Name = "Tip",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateModuleProcessInstanceNotExistMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("86bf5b15-2dd5-4551-9e24-b494d8fb1bbb"),
				Name = "ModuleProcessInstanceNotExistMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContinueOpenFieldEditorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f3b60501-0d10-4a88-b0a0-dc42ca320fee"),
				Name = "ContinueOpenFieldEditorMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSaveBeforePagingMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3b92e6a1-2473-476f-a8b7-6b760cf93e6d"),
				Name = "SaveBeforePagingMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow721SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow721",
				UId = new Guid("f6c198a9-1753-42fb-bc21-9614d574824d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(232, 182),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("069dd4ac-7a30-4a82-936a-3332f1da27fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e8b9bbd-a1ad-4208-86ca-9a2c83b8fa7a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow722SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow722",
				UId = new Guid("a4afe787-1e16-4e3e-b954-c84c11a87f84"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(134, 234),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8590fa66-a8ef-4cc2-8d5c-0b41603c4de9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("14493f34-45a0-4557-a526-6d82ce3a7e49"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow725SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow725",
				UId = new Guid("69f2d10d-965b-46c2-a8e7-47eb9d7c3dbd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(359, 320),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("43901eca-38a6-41a9-98a3-a95bb834c2a0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a526974d-956a-40f2-aff2-5fbe43308a8e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow726SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow726",
				UId = new Guid("23c69370-f74b-45c2-8a02-c43e3425cb4d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(426, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8672cbb6-8e15-40e3-91f1-626ddd103911"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("834c4cb1-dca2-4c80-8830-e1d4119418fc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow727SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow727",
				UId = new Guid("a12551f1-63a3-4c39-9643-903ad69dcca2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(581, 426),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("834c4cb1-dca2-4c80-8830-e1d4119418fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aff55c23-fd01-4bc7-872d-70b54c1dbe36"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow728ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow728",
				UId = new Guid("a73d6859-7479-481e-b4f2-9c7790d42935"),
				ConditionExpression = @"HasDetails",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(582, 328),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("834c4cb1-dca2-4c80-8830-e1d4119418fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow729DataTabPanelTabChangeSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow729DataTabPanelTabChange",
				UId = new Guid("b0f982d8-1682-4464-bd44-eb14d280a1a6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(254, 451),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cec09f9a-d52a-4bf2-a29f-d366e039e075"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("40fa767c-6dec-4744-b2a1-f3c1d82fbb63"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow732SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow732",
				UId = new Guid("fb71d7e6-d9a3-4221-9961-40958ef82064"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(152, 730),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3f5495c-2777-4bbd-9308-c66be2337461"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("46f4b017-6a6f-4bd7-86f8-fafa14ad09f4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow733SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow733",
				UId = new Guid("5fd7fd49-1238-437b-9c9b-d2cd342d2e30"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(404, 635),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e4cd4758-8aa3-494a-9fea-387eec6bc80a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8f0a31ad-832f-48d1-b97c-1cadb6e3656c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow734SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow734",
				UId = new Guid("c4515f37-b49d-4b8e-9ecd-34c2b11146cc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(390, 594),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef2a6d30-b345-4f03-8582-fc7168d10968"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("092402ec-6037-4377-b137-ee742f70f081"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow735SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow735",
				UId = new Guid("20b08e1f-960d-434d-8674-84d4ff23e3c2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(452, 590),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8f0a31ad-832f-48d1-b97c-1cadb6e3656c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("092402ec-6037-4377-b137-ee742f70f081"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow740SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow740",
				UId = new Guid("99be3735-c6ba-4193-b6b6-cc7f47d79b22"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(596, 580),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb3ebee4-b51d-437d-9058-5c07fe1c9678"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aba7e3fc-4360-4bf3-a025-dd33b70e724c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow741ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow741",
				UId = new Guid("e590f987-f6e1-425d-b1b0-2152cead77fa"),
				ConditionExpression = @"IsNew || IsCopy",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(714, 582),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5629032e-26ca-4c0b-a528-8a601c3e7c8f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow742SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow742",
				UId = new Guid("4744c129-32cf-4f27-b244-f3ddf62ba833"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(596, 686),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18d8838c-9820-4c17-957b-1766afb153d5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9aca68c3-9906-4950-a97b-fee7d69e1586"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow743SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow743",
				UId = new Guid("f9ab63e3-e492-4059-bbd2-e56cd68b1f43"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(776, 684),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f2accfc-6601-4c98-a286-78349e42a186"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a85f52d-ca65-4733-a4a9-94485fe3d779"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow744SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow744",
				UId = new Guid("951a3c10-3ba9-4131-b7fd-ddbd808b108e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(756, 632),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5629032e-26ca-4c0b-a528-8a601c3e7c8f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a85f52d-ca65-4733-a4a9-94485fe3d779"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow745SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow745",
				UId = new Guid("90cd6298-5d39-4a9b-9f85-e41f39b06bfc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(722, 588),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aba7e3fc-4360-4bf3-a025-dd33b70e724c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5629032e-26ca-4c0b-a528-8a601c3e7c8f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow746SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow746",
				UId = new Guid("d4e3f883-d53e-4955-a66e-b6e5401d4c7c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(700, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ac53080-8296-43dc-a026-301ee9b54422"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow747SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow747",
				UId = new Guid("8d947910-2586-4f1d-9baf-abdffa845fb0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(603, 846),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb20f4b4-6707-4412-a2e1-3d103c095e9a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fc467cdb-267e-45d0-be00-b194964eb977"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow748SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow748",
				UId = new Guid("8af06434-f32b-436a-aa96-cdc82df41e0a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(254, 451),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a09dff9b-f8d2-4164-a3f0-a94dc40d4c71"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88a78a98-8ec2-4bb6-91d4-c0cb5dee6050"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow749SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow749",
				UId = new Guid("68044652-4789-4580-be3c-ec10c059ac5a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(254, 451),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e8b9bbd-a1ad-4208-86ca-9a2c83b8fa7a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cec09f9a-d52a-4bf2-a29f-d366e039e075"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow750SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow750",
				UId = new Guid("b2bcd6ef-828a-469a-90ab-b89840522b5f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(924, 376),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5cd067ef-5bd6-41bf-b683-5e121962f8b1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6fad93c0-f093-4d88-abdf-9ebfb581ab7f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow751SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow751",
				UId = new Guid("b858b22f-27f3-4659-8fb7-5a1c9b2ef8ae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1040, 375),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6fad93c0-f093-4d88-abdf-9ebfb581ab7f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("df045715-ab64-4d5c-9666-721f708fcb1b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow752SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow752",
				UId = new Guid("8520c55a-7b63-457d-becd-f8c7152f3bd0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1052, 142),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88a78a98-8ec2-4bb6-91d4-c0cb5dee6050"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a0e3b040-538f-4a5c-90c0-cd772f3319e2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow753ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow753",
				UId = new Guid("f014625b-f8dc-4f64-a8d5-be030dae46a5"),
				ConditionExpression = @"!NotRecivePrintReportMenu",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1112, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88a78a98-8ec2-4bb6-91d4-c0cb5dee6050"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("41088c29-9e6e-4b69-b8e4-f6069f688ffa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow754SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow754",
				UId = new Guid("43e64b30-fee9-4555-9e4e-686348f717c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1101, 470),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("47bf5540-cec5-4f31-b490-ad7d964a6cdf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("df045715-ab64-4d5c-9666-721f708fcb1b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow755SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow755",
				UId = new Guid("6d2913e4-1d3c-408e-9b6a-9a3137a8434d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1240, 385),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("df045715-ab64-4d5c-9666-721f708fcb1b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4a5c954d-97b2-45f2-b7de-644b553ac2a8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow756SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow756",
				UId = new Guid("6efa2cf5-844e-45ed-888e-96e706ed8261"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1334, 380),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4a5c954d-97b2-45f2-b7de-644b553ac2a8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow757SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow757",
				UId = new Guid("eb823c5f-89a3-4458-a582-53574956098f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1444, 380),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1419b1ad-f4d7-45fc-8dd8-6c8fbce49ca8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow758SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow758",
				UId = new Guid("07ab9ef5-8432-483e-a378-63e2f8f4b868"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(528, 764),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b2e4ba66-8b06-44c3-934a-e7d88d510a00"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6493a93c-1aa7-4440-845c-eb9af81d5f13"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow759SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow759",
				UId = new Guid("1e42c5cc-184e-4633-869d-00132a85eeb4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(422, 768),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("092402ec-6037-4377-b137-ee742f70f081"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c72690c4-a429-4348-90a9-fcdd19526e4a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow760SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow760",
				UId = new Guid("d69bd11f-f3f7-4b5f-b683-cef0e4f1bc03"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(584, 777),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c72690c4-a429-4348-90a9-fcdd19526e4a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6493a93c-1aa7-4440-845c-eb9af81d5f13"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow761ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow761",
				UId = new Guid("607e267e-b026-4553-8dd5-e49818faf5b9"),
				ConditionExpression = @"NeedTreeGridRefresh",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(510, 765),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c72690c4-a429-4348-90a9-fcdd19526e4a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b2e4ba66-8b06-44c3-934a-e7d88d510a00"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow762ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow762",
				UId = new Guid("eb116c63-2969-4639-a3a7-b9e6e861d26a"),
				ConditionExpression = @"IsEdit",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(734, 390),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e8b9bbd-a1ad-4208-86ca-9a2c83b8fa7a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d76fe3d0-2db0-48e6-a081-9b448a563b58"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow765SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow765",
				UId = new Guid("c01ae170-d0f6-430b-93c4-4a78bff80b3f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1138, 610),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f8a7ca6-852d-4f46-b020-c0735007051a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow766SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow766",
				UId = new Guid("daa3c314-45b5-434b-833d-d012f6bec88a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1038, 378),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("98dca6dc-6d49-4815-b42b-99653f887f08"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e55b06c-c3d0-465a-857e-fd8c109cb46d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow767SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow767",
				UId = new Guid("6bbc17f1-f3e5-4eda-b074-bbdb5abb6ba5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1408, 614),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d89911ce-2f7a-4b20-ad85-af9eba8adae6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1dc085de-0a8c-49cd-8438-d0c5ceb074da"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow768SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow768",
				UId = new Guid("61a73416-6d9a-43af-9b97-b3223f65c03b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1354, 560),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7d64b4be-4f5a-46be-9914-69194e0233eb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3875432c-7297-4c11-a502-ffb00f184d15"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow769SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow769",
				UId = new Guid("1ea0de28-b68b-4f8e-b54a-a6e6b5cc8979"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1448, 578),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3875432c-7297-4c11-a502-ffb00f184d15"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f29a6c2c-0ff7-43e2-a798-08098163c01d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow770ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow770",
				UId = new Guid("883f8faf-c520-43dc-8e4f-2085e31779b8"),
				ConditionExpression = @"Page.DataSource.ActiveRowModified",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1046, 665),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7f0a3b1-e680-47e4-8ebf-c49f2e8998a4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7f8a7ca6-852d-4f46-b020-c0735007051a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow771SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow771",
				UId = new Guid("faf3e6f2-201d-4697-a9e5-15ebc677bc00"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1268, 648),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7f0a3b1-e680-47e4-8ebf-c49f2e8998a4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1dc085de-0a8c-49cd-8438-d0c5ceb074da"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow772SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow772",
				UId = new Guid("0f272bb7-199a-4728-9bd4-08f5d936c407"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1146, 610),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e55b06c-c3d0-465a-857e-fd8c109cb46d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7f0a3b1-e680-47e4-8ebf-c49f2e8998a4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow773SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow773",
				UId = new Guid("a17381ab-b9fd-4647-b339-dc57d9411b06"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(672, 287),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d76fe3d0-2db0-48e6-a081-9b448a563b58"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bef3d290-08e9-450b-9f21-64bba5311e35"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow775SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow775",
				UId = new Guid("1fb06457-de4f-476c-8ef3-277e313f9e79"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(460, 1162),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("81518e82-9722-45dd-a356-00b23da3882a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("765a52e9-f0ca-4bd8-812e-bf61ba1bed78"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseSequenceFlow1",
				UId = new Guid("20629033-d206-4f1f-9b57-36bc9c925582"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(302, 1496),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("46f4b017-6a6f-4bd7-86f8-fafa14ad09f4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77f615c2-6c64-4611-8dc6-cd89889047e0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateBaseConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "BaseConditionalFlow1",
				UId = new Guid("4742e5a2-ce4d-4448-8360-1117f3c44863"),
				ConditionExpression = @"DoIncludeInSelectedFolder",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(452, 1418),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("20eb4604-b55a-45d0-82af-8bc44ce47354"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "BaseSequenceFlow2",
				UId = new Guid("99689944-b519-4145-8599-4a0a05433605"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(598, 1491),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("20eb4604-b55a-45d0-82af-8bc44ce47354"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("092402ec-6037-4377-b137-ee742f70f081"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseSequenceFlow3",
				UId = new Guid("f2c465e5-5677-4d11-a3cc-b980d3357e88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(408, 1495),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77f615c2-6c64-4611-8dc6-cd89889047e0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("20eb4604-b55a-45d0-82af-8bc44ce47354"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBaseSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BaseSequenceFlow4",
				UId = new Guid("9d2491c9-a5da-4c0c-ab34-e10eaaa1d55a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(341, 1566),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77f615c2-6c64-4611-8dc6-cd89889047e0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("81518e82-9722-45dd-a356-00b23da3882a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowScriptProcessButtonClickSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowScriptProcessButtonClick",
				UId = new Guid("ed9abf8d-2763-4dd5-a8da-608a3a3955c0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ddd3473-03aa-47bf-a146-4298a73dd8ed"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e2dd47b9-d1ee-4a25-a126-8df61fdb8130"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowopenSelectProcessSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowopenSelectProcess",
				UId = new Guid("01c775d3-6724-43b8-a2a2-3e0c2f246f28"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(253, 74),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e2dd47b9-d1ee-4a25-a126-8df61fdb8130"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b7cf7a53-7bd3-443b-9d16-15ff652bd592"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowWaitProcessSelectedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowWaitProcessSelected",
				UId = new Guid("ca1cdcee-a795-48f7-9ca3-aa97fa6d1d72"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(416, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b7cf7a53-7bd3-443b-9d16-15ff652bd592"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b3020b96-47b4-48ea-b412-c755340c3b36"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowProcessSelectedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowProcessSelected",
				UId = new Guid("ca0d211e-f27d-435f-b0a3-035fc23b4558"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(504, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3020b96-47b4-48ea-b412-c755340c3b36"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97dcfd98-b758-4c7b-9d1e-b3906162ac4b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowShowBaseMessageSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowShowBaseMessage",
				UId = new Guid("73b78f66-f640-4fc8-b6a7-4410a95c557c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(866, 74),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0910f651-c639-4fb5-b854-0f2cbf7a2714"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1RunModuleProcessSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1RunModuleProcess",
				UId = new Guid("c875abbe-5406-4439-ae25-7f3350f9ac85"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(182, 89),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bff1c977-c851-4f23-9821-53c600d5c766"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca0cd4b8-0665-43bd-a0f7-36b438c2f2f3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17781SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17781",
				UId = new Guid("8a2300e0-270b-477f-a97d-ab0c73302ec8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bc7d014a-726b-4724-bd88-48ea228feff3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7571c1a4-f42b-4b95-885f-f1b487b06196"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17791SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17791",
				UId = new Guid("786e0586-9ecb-4df9-9344-cc5c3db1aeec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(246, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("077d7255-2510-41b9-856c-f0840fe16492"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18001SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18001",
				UId = new Guid("0f086e8e-a1ea-4b4a-9975-24b53032b004"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7571c1a4-f42b-4b95-885f-f1b487b06196"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("266cbed8-e88c-4aab-ad83-26bdca48c4d0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18011SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18011",
				UId = new Guid("d6fa14dc-aaf8-4686-b8f5-f8293542d8e5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c84b997-fbed-4bfe-a763-3162d4ff9601"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow18021ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow18021",
				UId = new Guid("3874f67a-f0ce-4af6-8a0a-5d954b855bd7"),
				ConditionExpression = @"IsSchemaBlocked",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(366, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("266cbed8-e88c-4aab-ad83-26bdca48c4d0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c84b997-fbed-4bfe-a763-3162d4ff9601"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18031SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow18031",
				UId = new Guid("24b34e4b-04b9-4cc0-af7f-6da269c956d2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(490, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("266cbed8-e88c-4aab-ad83-26bdca48c4d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("05510bb0-d74e-4d30-94c5-6563a8c5850d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18041SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18041",
				UId = new Guid("ac49cbd7-b8d5-4431-8d49-bff71a74342e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(606, 55),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e104620f-dd2d-43c0-a3d6-cacea339499f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18051SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18051",
				UId = new Guid("404d2a85-9d9f-403f-95c9-a798bf9deeba"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(693, 36),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e104620f-dd2d-43c0-a3d6-cacea339499f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d52582ac-3138-4b51-9285-cd7ad47b42d4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18061SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18061",
				UId = new Guid("5331dfbc-af8b-4ec1-8468-7385df5a6d89"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(606, 80),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("765e93b8-4612-416b-9c4d-fafec32bb007"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18071SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18071",
				UId = new Guid("6851560f-e36e-4a6c-be52-986f25c52ab8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(686, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("765e93b8-4612-416b-9c4d-fafec32bb007"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("05510bb0-d74e-4d30-94c5-6563a8c5850d"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateNotSavedEntitySequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "NotSavedEntitySequenceFlow",
				UId = new Guid("d03dce01-9534-4baf-8e46-0820f6056c67"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(314, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05510bb0-d74e-4d30-94c5-6563a8c5850d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("077d7255-2510-41b9-856c-f0840fe16492"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateYesEntitySavedConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "YesEntitySavedConditionalFlow",
				UId = new Guid("8eb78326-f2e8-4e8d-9306-c6587c3e23ee"),
				ConditionExpression = @"IsEntityChanged()",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(233, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05510bb0-d74e-4d30-94c5-6563a8c5850d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("96be1385-3f53-46da-8b41-e24e6209ce31"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateNoContinueExitSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "NoContinueExitSequenceFlow",
				UId = new Guid("83cb9f4e-1623-43a4-b122-c65bc8fe43cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(99, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03415cb1-68df-43bb-92bc-b0242d8dc10f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0284c2bd-2ccb-4349-b37c-969dba234090"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateNoContinueSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "NoContinueSequenceFlow",
				UId = new Guid("8fd8157a-bebe-450e-b5ca-4aefdba382c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(126, 309),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03415cb1-68df-43bb-92bc-b0242d8dc10f"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateYesContinueSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "YesContinueSequenceFlow",
				UId = new Guid("1a638815-1329-4e9e-9eae-ff5c0ec0eebd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(244, 323),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e5c2047b-2570-46a8-bb22-cdfdd34df672"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreatePrepareDesignerWindowSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "PrepareDesignerWindowSequenceFlow",
				UId = new Guid("e4484586-ef58-4a1e-8584-e54cc455e2d6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(318, 322),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e5c2047b-2570-46a8-bb22-cdfdd34df672"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("077d7255-2510-41b9-856c-f0840fe16492"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateShowContinueMessageSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ShowContinueMessageSequenceFlow",
				UId = new Guid("0ae291c8-85f0-4ba3-b0df-6dd3bea09b0b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(182, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96be1385-3f53-46da-8b41-e24e6209ce31"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreatePreviousSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "PreviousSequenceFlow",
				UId = new Guid("66ca1ee6-a74d-4715-94f2-76cd018d0f09"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(184, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0c794987-d68b-4dcf-b52f-a1f36186d0ac"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18db9e4a-3a1c-45b9-8aeb-cc28228707d2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateNextSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "NextSequenceFlow",
				UId = new Guid("254702d7-0ac9-4f96-a9fe-e6a659a78b32"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(183, 172),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b2342e6-06b7-418c-b188-cb6c8027e9c1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba556e26-fe0e-4e3c-bccd-036300d9ea9e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateNextIsModifySequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "NextIsModifySequenceFlow",
				UId = new Guid("27602a22-21ba-4bac-8ce6-71d1c7de5b9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(365, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba556e26-fe0e-4e3c-bccd-036300d9ea9e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4b47d545-f464-4a58-ae59-953d479e2fab"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreatePrevIsModifySequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "PrevIsModifySequenceFlow",
				UId = new Guid("61297e8b-6e31-4eb8-9cf2-627a83292918"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(376, 93),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18db9e4a-3a1c-45b9-8aeb-cc28228707d2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4b47d545-f464-4a58-ae59-953d479e2fab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateIsModifyYesSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "IsModifyYesSequenceFlow",
				UId = new Guid("3a368d85-6f25-43fa-82e9-49bdf8261ca7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(420, 224),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4b47d545-f464-4a58-ae59-953d479e2fab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a7fe002-f782-4bd4-97b5-eddd35361816"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateInitYesNoUserTaskSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "InitYesNoUserTaskSequenceFlow",
				UId = new Guid("948243de-2f57-4b01-840a-df2525b685bc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(354, 292),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a7fe002-f782-4bd4-97b5-eddd35361816"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsModifyNoConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsModifyNoConditionalFlow",
				UId = new Guid("1eef0d8b-916e-4dc4-9d6a-506d61d0a800"),
				ConditionExpression = @"!NeedSave",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(428, 148),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4b47d545-f464-4a58-ae59-953d479e2fab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ce935f6-3bab-40cc-a67c-b486214157e9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateAfterSaveSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "AfterSaveSequenceFlow",
				UId = new Guid("b0efc012-9a28-408e-9560-44a527f48cd6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(504, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d859723c-b83b-4106-88df-5786a04ef697"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ce935f6-3bab-40cc-a67c-b486214157e9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateNoMsgSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "NoMsgSequenceFlow",
				UId = new Guid("f2e3c029-b9e3-4599-9041-1f6e03993754"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(577, 148),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e1dd6c29-0626-4671-ad45-2cae485bef43"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ce935f6-3bab-40cc-a67c-b486214157e9"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateYesMsgSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "YesMsgSequenceFlow",
				UId = new Guid("5aba7bb3-1533-497a-8c8b-23da27801894"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(573, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("98ff0581-cb40-47e1-bdcf-461a0a646c43"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d859723c-b83b-4106-88df-5786a04ef697"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSavedBeforePrintSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SavedBeforePrintSequenceFlow",
				UId = new Guid("2c974645-e073-4bf4-9e57-ecccdc96356a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(1448, 578),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7dcb7cd9-0c1b-4ae4-a055-a6ab7da47580"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1dc085de-0a8c-49cd-8438-d0c5ceb074da"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1345435SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1345435",
				UId = new Guid("a721fc4a-bed0-471d-ab3c-db5b83694c52"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(264, 800),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a526974d-956a-40f2-aff2-5fbe43308a8e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f83f1eff-b917-4764-89e9-d596bb7b68ee"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1wr325ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1wr325",
				UId = new Guid("3e69c9a5-502a-408f-8baa-67faa58f3062"),
				ConditionExpression = @"HasDetails",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(370, 797),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f83f1eff-b917-4764-89e9-d596bb7b68ee"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23453432SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow23453432",
				UId = new Guid("bd2fe2d8-6813-467f-a288-7c9c157f0979"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CurveCenterPosition = new Point(316, 856),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f83f1eff-b917-4764-89e9-d596bb7b68ee"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("14063a14-6b8c-4e0f-927b-2203693fb7ce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet95LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet95 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d8a83043-e89f-4dc3-bd03-0f199830d443"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"LaneSet95",
				Position = new Point(5, 5),
				Size = new Size(1255, 331),
				UseBackgroundMode = false
			};
			return schemaLaneSet95;
		}

		protected virtual ProcessSchemaLane CreatePagingLaneLane() {
			ProcessSchemaLane schemaPagingLane = new ProcessSchemaLane(this) {
				UId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d8a83043-e89f-4dc3-bd03-0f199830d443"),
				CreatedInOwnerSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PagingLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1226, 331),
				UseBackgroundMode = false
			};
			return schemaPagingLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePagingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPagingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PagingEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(626, 310),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPagingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateNextButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6b2342e6-06b7-418c-b188-cb6c8027e9c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"NextButtonClick",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NextButtonClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateNextButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ba556e26-fe0e-4e3c-bccd-036300d9ea9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NextButtonClickScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,140,49,11,194,48,16,70,231,6,242,31,226,214,46,5,231,224,32,234,208,69,138,17,247,24,175,53,16,114,112,185,90,65,252,239,94,161,184,190,239,125,175,247,35,248,123,130,99,36,8,28,49,155,157,233,87,230,32,9,251,47,237,25,222,108,181,90,230,11,206,229,128,83,102,209,183,194,186,28,217,49,77,129,39,2,199,72,80,7,204,44,135,246,250,36,156,79,47,200,188,167,177,52,34,199,161,222,116,229,230,83,124,44,173,198,124,180,170,8,228,154,205,224,83,1,91,105,245,213,106,69,146,5,251,3,134,51,49,247,168,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateIsModifyExclusiveGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("4b47d545-f464-4a58-ae59-953d479e2fab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsModifyExclusiveGateway",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPreviousButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("18db9e4a-3a1c-45b9-8aeb-cc28228707d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptPreviousButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 16),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,140,177,10,194,48,20,69,231,6,242,15,113,107,151,130,115,112,16,117,232,22,26,113,143,241,181,6,66,30,188,188,88,65,252,119,83,40,174,231,220,123,140,155,193,221,35,156,3,129,231,128,73,29,148,217,152,133,88,217,223,244,134,2,146,150,98,245,35,46,249,132,37,113,221,239,43,27,82,96,203,84,60,23,2,203,72,208,122,76,12,111,238,175,79,194,229,242,130,196,71,154,115,87,199,97,106,119,67,190,185,24,30,107,171,83,31,41,26,130,122,77,106,114,49,131,110,164,248,74,177,161,154,5,253,3,162,8,104,182,169,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePreviousButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0c794987-d68b-4dcf-b52f-a1f36186d0ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PreviousButtonClick",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PreviousButtonClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareSaveYesNoScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7a7fe002-f782-4bd4-97b5-eddd35361816"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PrepareSaveYesNoScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 219),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,206,177,14,130,48,16,6,224,157,132,119,104,58,19,95,0,117,32,50,48,88,212,226,192,216,144,147,16,147,171,233,21,149,16,222,221,107,100,65,236,114,73,255,239,114,191,54,79,168,129,148,173,12,221,55,39,211,130,216,137,48,210,56,210,139,236,8,68,252,95,193,219,51,9,89,6,55,235,128,113,135,237,156,174,182,138,198,34,115,121,190,230,186,42,74,37,87,34,235,189,183,72,1,213,185,86,229,90,92,128,30,44,96,190,17,40,194,75,28,186,198,119,22,141,27,182,228,29,119,72,196,119,238,197,24,71,226,231,141,114,0,146,9,31,1,154,43,83,43,167,228,159,68,27,160,178,75,55,113,49,7,190,119,40,188,235,33,253,0,182,2,6,254,59,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSaveYesNoTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("39b5cae4-f7ea-4b02-9a37-482225beae5d"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SaveYesNoTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 219),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSaveYesNoTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreatePagingScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3ce935f6-3bab-40cc-a67c-b486214157e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PagingScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(407, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,65,11,130,64,16,133,207,10,251,31,54,79,10,33,221,165,67,184,30,186,132,148,127,96,172,73,23,150,89,88,71,13,162,255,222,100,72,93,230,241,190,225,189,103,124,13,157,165,46,21,193,179,159,135,210,143,196,91,189,120,104,29,94,208,225,149,141,13,114,173,167,108,229,63,82,168,216,222,191,129,220,0,67,3,109,13,132,46,63,200,127,66,177,71,186,225,99,179,215,187,76,63,85,28,157,60,227,176,98,45,88,26,162,37,222,244,193,207,213,132,196,105,242,95,37,90,246,64,29,38,159,181,151,138,3,242,24,72,115,24,177,120,3,74,212,16,31,195,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveChangesScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d859723c-b83b-4106-88df-5786a04ef697"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SaveChangesScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(407, 219),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,193,110,219,48,12,134,207,41,208,119,32,124,178,208,64,200,185,193,134,21,238,214,101,192,134,160,41,118,73,115,224,44,54,19,96,83,129,36,167,237,12,191,251,72,167,107,218,13,235,77,164,248,81,63,127,209,223,65,249,45,100,74,55,248,99,193,142,30,224,61,204,12,244,167,39,147,148,163,231,45,176,222,194,59,40,203,37,110,201,94,98,70,169,93,34,83,99,229,144,214,175,240,141,93,100,106,211,122,182,1,76,160,68,21,56,163,103,138,198,106,184,224,148,145,107,178,87,148,151,49,236,40,230,199,239,216,116,84,22,99,163,143,206,231,194,40,252,57,183,141,70,198,222,208,67,158,139,162,61,70,168,3,239,133,161,168,154,152,238,225,75,10,92,253,73,174,55,208,107,242,170,243,238,213,69,105,134,249,113,38,239,4,214,123,187,162,232,177,241,191,232,56,221,42,116,81,244,93,212,217,239,233,58,220,219,101,244,45,198,199,42,52,93,203,163,214,233,11,25,50,170,209,214,35,191,170,163,223,229,175,200,18,68,123,225,220,33,241,79,243,170,241,196,121,113,9,103,32,232,164,176,129,159,223,123,241,78,170,126,34,111,201,93,83,218,5,78,226,209,88,46,148,76,112,6,197,180,191,61,184,118,91,192,57,244,245,145,60,135,226,169,242,175,49,199,239,52,10,15,131,153,23,42,125,56,61,121,242,37,141,106,197,155,15,74,123,217,141,126,54,88,124,118,162,13,206,223,121,114,7,113,178,38,186,39,19,173,73,184,167,114,244,97,242,22,162,127,214,53,141,214,13,242,108,33,135,55,125,59,232,178,159,66,108,81,162,49,57,133,255,185,105,84,64,164,220,69,134,28,59,154,255,6,179,66,82,194,222,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateNoMsgStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e1dd6c29-0626-4671-ad45-2cae485bef43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"NoPagingMsg",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NoMsgStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(547, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateYesMsgStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("98ff0581-cb40-47e1-bdcf-461a0a646c43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c87cbeeb-5b25-486c-905f-7e30fbaff577"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"YesPagingMsg",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"YesMsgStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(547, 233),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2301EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2301 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EventSubProcess2301",
				Position = new Point(35, 343),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1159, 382),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2301;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDesignerModeButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bc7d014a-726b-4724-bd88-48ea228feff3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DesignerModeButtonClick",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"DesignerModeButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDesignerModeButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("077d7255-2510-41b9-856c-f0840fe16492"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptDesignerModeButtonClick",
				Position = new Point(267, 282),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,77,107,195,48,12,134,207,43,244,63,152,156,90,8,30,59,239,3,70,122,9,219,104,32,237,105,140,33,18,53,53,75,229,34,59,237,74,233,127,159,146,180,219,218,193,240,41,150,228,247,209,43,57,27,96,181,134,10,243,98,137,43,152,167,165,186,87,153,196,186,79,104,201,232,153,205,61,27,170,70,227,219,225,96,98,10,111,44,1,239,212,157,235,210,177,234,191,15,29,40,3,134,21,122,100,39,36,194,173,250,71,48,26,171,253,112,112,181,143,76,25,197,231,54,14,113,87,216,24,220,190,216,18,165,28,221,68,199,164,113,115,135,252,43,61,28,28,196,89,15,85,169,203,216,172,164,221,4,60,228,182,225,226,72,77,150,64,21,150,57,58,39,126,158,112,39,6,133,215,203,116,98,169,0,63,138,194,229,151,150,219,237,180,198,132,68,216,205,172,143,151,91,212,107,56,248,77,140,45,160,118,40,192,233,26,41,251,238,50,65,103,42,66,126,111,251,204,192,125,232,236,114,229,231,111,16,64,104,235,200,41,57,15,84,96,247,3,156,2,25,42,208,194,156,107,209,69,167,162,187,254,43,208,224,214,159,81,0,47,173,200,50,102,108,23,166,70,161,122,110,66,54,145,212,214,97,63,204,148,158,45,148,225,82,57,36,13,51,146,127,148,119,219,96,123,247,71,205,232,27,166,62,250,2,184,172,4,129,47,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenPageSchemaDesigner_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d1ccc261-1f1d-45f7-9fb8-13fe2fd5bb1b"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"OpenPageSchemaDesigner_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(379, 282),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenPageSchemaDesigner_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateGetIsEntitySchemaBlockedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7571c1a4-f42b-4b95-885f-f1b487b06196"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"GetIsEntitySchemaBlockedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,85,77,79,219,64,16,61,7,137,255,176,248,128,108,41,90,238,173,80,69,32,65,150,74,26,41,164,81,85,245,176,216,19,88,97,123,163,221,117,32,173,248,239,157,253,8,254,76,56,20,245,4,65,138,179,51,59,243,230,205,188,113,172,230,201,3,228,108,148,137,228,17,82,114,78,86,44,83,240,249,248,104,195,36,73,65,241,251,2,210,88,67,238,252,98,227,178,80,32,47,69,81,64,162,185,40,142,143,6,116,14,74,225,227,21,211,236,167,210,146,23,247,20,29,18,166,195,25,187,7,234,238,210,69,156,210,91,49,183,246,48,152,6,209,144,4,87,181,20,51,201,115,38,183,227,66,115,189,221,229,11,162,95,136,230,186,228,41,129,134,1,129,244,226,59,57,39,69,153,101,228,11,9,205,173,168,215,233,19,49,54,58,206,215,122,139,225,29,102,34,129,101,245,236,11,155,197,150,112,13,122,198,36,203,65,131,252,206,178,18,194,0,154,158,65,68,152,34,46,18,134,228,43,18,158,120,46,98,53,69,68,223,164,77,23,246,100,137,34,242,7,121,180,85,182,205,22,67,1,79,22,113,239,101,204,54,224,171,142,201,113,81,213,73,78,79,219,20,162,189,123,203,97,25,116,216,238,122,154,196,47,199,71,248,111,62,102,98,36,40,81,202,4,110,88,129,172,73,188,21,220,130,148,76,137,149,166,75,184,187,88,175,233,82,200,71,181,102,9,140,159,215,153,144,32,111,68,90,102,16,248,161,171,231,173,194,52,103,174,138,65,27,142,51,41,54,60,5,105,240,155,150,249,227,48,24,119,131,186,126,197,141,51,15,97,141,207,239,12,96,214,14,185,39,189,249,52,15,205,220,122,82,236,163,27,111,59,97,97,183,157,85,187,93,27,27,23,123,168,53,32,141,117,180,197,73,106,197,235,65,104,92,77,215,171,70,57,1,31,72,80,57,132,77,14,135,181,170,168,157,227,179,51,12,61,223,250,157,68,148,251,114,211,255,122,220,138,98,167,223,121,210,9,232,228,97,34,69,126,53,10,219,232,106,25,246,122,91,191,87,65,25,253,58,207,175,118,57,142,182,184,191,98,229,68,28,25,53,117,204,166,3,173,65,185,44,165,196,232,230,148,190,106,203,175,91,79,20,46,79,100,234,22,158,53,214,234,87,198,68,200,28,215,167,169,28,195,179,140,255,102,119,25,248,221,217,82,217,208,132,196,191,192,71,242,35,25,43,15,12,86,168,178,113,202,53,194,90,113,153,7,17,181,43,108,216,46,96,138,251,205,22,63,136,59,239,5,45,75,240,122,31,220,9,145,17,197,54,136,101,201,245,131,40,181,137,128,191,198,133,65,105,220,67,227,19,153,166,129,214,104,81,102,208,220,226,108,79,65,112,145,101,226,105,206,54,176,40,234,188,4,181,62,28,200,213,215,135,170,77,111,19,254,111,20,79,133,222,165,253,33,202,22,193,111,83,249,226,22,14,119,242,233,236,29,58,225,69,90,201,179,245,50,221,175,207,221,18,107,136,179,27,253,128,52,121,67,50,166,9,189,239,178,125,188,122,222,223,73,203,205,82,14,43,153,127,104,248,67,195,255,91,195,18,116,41,139,221,225,95,255,113,52,174,85,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2301ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("266cbed8-e88c-4aab-ad83-26bdca48c4d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ExclusiveGateway2301",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(196, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateOpenMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("83718572-58e9-4591-a706-0ee32efba470"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"OpenMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(441, 34),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateOpenMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5c84b997-fbed-4bfe-a763-3162d4ff9601"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"OpenMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(336, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,49,15,130,48,16,133,119,19,255,67,211,153,248,7,80,7,34,3,131,173,10,12,142,77,189,32,65,175,164,87,162,132,240,223,109,3,3,131,76,47,239,221,247,238,78,182,128,103,32,82,21,148,4,182,80,212,236,46,222,176,3,11,18,111,55,242,15,49,251,2,190,206,131,201,203,232,6,30,185,126,194,91,45,70,43,229,76,27,244,45,126,45,211,188,200,164,224,43,92,210,57,103,144,2,122,79,115,33,215,184,27,80,235,57,152,243,80,64,248,176,83,173,93,109,80,217,126,79,206,214,88,69,108,210,35,27,6,222,3,241,200,47,6,10,43,167,215,249,24,177,129,163,9,3,97,150,249,232,79,91,112,157,69,230,108,7,241,15,45,179,19,172,54,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEvent2301IntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("e104620f-dd2d-43c0-a3d6-cacea339499f"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"NoOpenSchema",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IntermediateCatchMessageEvent2301",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(560, 7),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEvent2302IntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("765e93b8-4612-416b-9c4d-fafec32bb007"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"YesOpenSchema",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IntermediateCatchMessageEvent2302",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(560, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd2301EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("d52582ac-3138-4b51-9285-cd7ad47b42d4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"End2301",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(623, 7),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateIsSavedEntityExclusiveGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("05510bb0-d74e-4d30-94c5-6563a8c5850d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsSavedEntityExclusiveGateway",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareUserTaskParametersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("96be1385-3f53-46da-8b41-e24e6209ce31"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PrepareUserTaskParametersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,177,14,130,64,12,134,119,19,223,225,114,51,241,5,80,7,21,19,6,65,5,6,71,2,13,94,212,30,185,150,40,33,188,187,119,17,18,7,35,83,243,183,223,255,183,141,107,192,173,70,86,216,192,1,136,242,10,50,2,147,230,116,91,28,173,16,43,225,138,63,159,197,127,200,65,167,240,98,107,24,41,231,216,43,184,151,65,169,88,155,1,154,136,10,11,141,54,67,158,178,32,73,195,56,146,19,252,166,97,214,72,206,114,9,146,40,158,226,207,64,181,229,199,190,51,34,60,197,78,21,172,52,230,166,93,18,27,133,149,39,62,117,45,186,78,182,64,210,179,11,128,190,127,75,138,43,60,114,217,123,162,147,168,29,16,233,95,243,222,158,100,128,27,131,130,77,3,254,27,129,181,59,247,116,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenContinueMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e8acc341-b607-4708-926b-0b24d5be0fa0"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"OpenContinueMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 282),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenContinueMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEndEvent CreateNoContinueExitEndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("0284c2bd-2ccb-4349-b37c-969dba234090"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NoContinueExit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 191),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateNotContinueIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("03415cb1-68df-43bb-92bc-b0242d8dc10f"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"NoContinueOpenSchema",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NotContinueIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 296),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateYesContinueIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("e5c2047b-2570-46a8-bb22-cdfdd34df672"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a91f1cab-1087-4b94-9e27-4f13de258305"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"YesContinueOpenSchema",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"YesContinueIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 296),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessRunModuleProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessRunModuleProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c77aa29b-eb78-41be-81ee-6c435e16cb6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EventSubProcessRunModuleProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 751),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessRunModuleProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartRunModuleProcessStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bff1c977-c851-4f23-9821-53c600d5c766"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c77aa29b-eb78-41be-81ee-6c435e16cb6e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RunModuleProcess",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartRunModuleProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptRunModuleProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ca0cd4b8-0665-43bd-a0f7-36b438c2f2f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c77aa29b-eb78-41be-81ee-6c435e16cb6e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptRunModuleProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,205,78,219,64,16,62,131,196,59,44,57,32,91,141,246,1,74,105,149,38,1,69,21,52,106,146,114,168,122,88,236,33,217,214,222,77,103,199,9,22,226,221,59,187,177,99,59,20,65,47,249,25,239,247,51,223,204,122,163,80,192,3,161,154,42,84,185,19,23,34,177,134,184,34,231,43,180,219,241,6,12,13,112,233,132,114,98,164,19,210,214,40,44,63,56,66,109,150,125,97,239,126,65,66,31,207,79,142,175,10,157,138,53,218,4,156,251,2,37,19,25,216,10,95,141,90,252,63,122,164,150,189,159,114,110,103,129,33,138,99,198,142,13,105,42,103,201,10,114,37,92,233,174,109,90,100,48,221,145,85,229,11,177,112,128,67,107,12,4,23,178,13,186,86,70,45,1,229,21,208,196,56,82,38,129,207,229,141,202,33,234,205,106,186,65,128,245,188,222,134,155,206,119,16,230,157,242,183,60,32,239,104,87,236,21,208,213,126,68,212,57,21,87,140,242,82,155,180,113,177,152,164,81,19,139,87,215,247,34,170,73,56,165,34,203,98,241,120,116,114,124,116,205,103,152,225,150,241,118,235,13,205,149,251,45,171,234,156,83,100,209,93,240,242,210,98,174,40,234,4,85,107,222,88,26,63,104,71,21,176,47,186,242,47,200,248,20,170,48,252,161,16,74,179,2,156,227,202,110,43,100,200,240,8,129,10,52,130,176,240,128,167,42,213,182,33,111,55,244,41,135,8,138,234,114,212,205,186,27,137,12,123,2,4,232,100,232,194,213,131,244,142,234,22,39,105,47,230,208,216,197,46,15,161,247,15,88,52,138,230,128,168,156,189,39,185,152,200,91,184,99,53,66,155,185,208,101,28,122,27,184,117,248,35,27,206,214,86,158,55,212,235,142,46,211,183,180,222,237,150,199,127,120,9,165,13,207,127,97,244,159,2,38,35,207,209,201,67,206,128,248,231,26,144,202,239,42,43,158,55,213,63,80,139,155,100,9,1,174,80,167,195,76,243,60,130,145,160,205,43,191,143,172,34,173,143,250,148,234,21,19,159,234,213,25,231,107,42,197,251,55,161,187,137,248,41,157,86,44,19,119,195,172,95,49,176,69,135,230,98,113,118,38,94,27,168,191,144,27,152,31,64,235,193,190,150,220,11,232,254,179,160,170,12,223,178,98,7,156,5,34,51,124,179,219,198,149,159,68,170,72,205,108,129,73,125,95,228,104,95,241,51,247,74,173,51,167,251,59,206,207,254,183,173,182,133,126,75,89,238,206,241,131,41,234,156,223,200,67,155,21,185,9,36,97,121,159,66,211,93,181,241,3,36,5,65,244,143,23,158,199,180,47,244,95,68,35,83,235,23,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessProcessButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessProcessButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a9145d59-d3df-4820-9f30-c3798ae554d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EventSubProcessProcessButtonClick",
				Position = new Point(35, 933),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(581, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessProcessButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartProcessButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7ddd3473-03aa-47bf-a146-4298a73dd8ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9145d59-d3df-4820-9f30-c3798ae554d0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ProcessButtonClick",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartProcessButtonClick",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptProcessButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e2dd47b9-d1ee-4a25-a126-8df61fdb8130"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9145d59-d3df-4820-9f30-c3798ae554d0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptProcessButtonClick",
				Position = new Point(120, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,209,110,218,48,20,125,6,137,127,176,178,135,6,13,92,24,160,21,209,85,234,128,78,104,235,64,3,218,135,105,15,110,114,129,12,99,167,182,67,23,33,254,125,215,78,70,129,142,170,47,81,156,220,115,206,61,231,222,100,205,20,1,97,34,147,142,131,5,172,216,45,19,108,14,138,124,34,83,13,170,43,133,128,192,68,82,208,254,203,162,78,169,184,70,248,250,105,156,234,91,25,38,28,70,74,6,160,53,162,255,195,73,191,128,25,8,109,152,8,224,115,250,157,173,192,247,238,44,54,71,121,101,36,212,70,69,98,78,162,188,110,16,34,151,239,79,64,41,166,229,204,208,233,128,222,195,3,246,101,148,228,154,142,144,184,108,47,244,90,199,238,64,7,59,40,157,200,177,163,243,45,243,48,6,49,6,142,118,114,61,107,112,194,244,146,230,231,175,144,162,216,158,242,123,226,152,237,197,10,178,72,160,137,169,136,30,19,24,244,94,103,68,200,136,41,180,104,64,217,56,4,60,145,94,228,146,100,42,37,151,153,205,10,145,15,191,17,126,229,239,89,215,46,179,169,115,254,50,90,12,224,200,151,29,65,124,172,231,191,34,86,126,107,223,72,126,72,76,175,195,208,247,118,13,122,149,231,102,203,39,138,185,148,203,196,77,102,188,7,243,206,46,90,181,102,216,128,70,181,222,174,7,213,102,11,234,213,118,3,239,218,245,218,172,93,107,53,46,194,176,121,230,157,98,13,18,109,228,170,203,165,134,176,191,198,93,179,156,185,153,204,25,132,14,220,149,156,103,11,124,249,156,200,113,32,87,100,22,241,189,65,189,13,228,194,207,129,174,171,195,25,31,215,147,77,169,88,40,108,188,64,174,98,166,34,45,197,36,141,1,251,190,113,20,221,131,199,180,255,152,48,190,173,100,144,68,67,47,210,49,103,233,29,227,137,197,204,24,215,64,220,123,82,56,63,39,147,97,111,72,186,63,222,213,63,126,104,214,234,25,138,195,204,244,255,196,10,35,193,142,208,83,178,18,35,102,22,54,42,220,170,123,169,150,58,102,1,120,255,100,84,52,95,236,33,118,153,59,81,141,48,107,48,115,243,243,23,217,100,31,199,209,95,98,199,74,113,127,183,91,36,222,158,154,225,55,183,25,153,123,203,158,71,89,238,20,10,165,162,2,147,40,65,140,74,160,243,23,212,156,156,132,163,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenSelectProcessUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b7cf7a53-7bd3-443b-9d16-15ff652bd592"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9145d59-d3df-4820-9f30-c3798ae554d0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"OpenSelectProcessUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 37),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenSelectProcessUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptRunSelectedProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("97dcfd98-b758-4c7b-9d1e-b3906162ac4b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9145d59-d3df-4820-9f30-c3798ae554d0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptRunSelectedProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(470, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,219,142,218,48,16,125,102,165,253,7,151,39,71,69,254,129,94,164,46,203,174,162,10,22,9,232,62,155,100,88,220,77,236,212,118,128,168,218,127,239,248,18,32,1,109,219,7,66,28,207,156,51,231,120,198,59,174,137,129,2,50,11,249,15,94,212,96,200,23,66,239,69,102,133,146,92,55,159,141,213,66,190,140,136,90,255,196,160,175,201,83,5,114,225,19,230,90,101,96,204,202,128,94,114,243,202,30,193,46,58,72,212,109,141,149,148,224,209,146,79,183,55,1,141,104,200,148,206,211,28,185,194,23,54,41,43,219,156,2,170,128,61,230,149,203,188,12,219,40,13,60,219,18,250,29,26,79,54,231,66,247,107,37,194,66,73,132,236,9,76,200,239,219,155,193,89,9,46,140,33,16,226,14,118,232,135,91,251,208,191,88,225,243,124,160,203,140,37,189,95,81,168,4,75,73,99,105,71,174,80,213,224,82,248,121,70,96,99,75,181,240,184,212,89,58,24,172,145,248,213,189,189,225,175,93,224,187,216,16,250,33,26,151,154,89,93,20,79,218,27,72,91,241,73,96,125,172,69,78,76,99,218,19,245,174,72,216,19,183,113,10,110,253,1,105,133,109,166,92,242,23,208,24,57,199,127,214,61,107,54,241,49,139,108,11,37,143,145,109,122,249,110,98,172,225,106,102,117,190,135,249,132,118,162,147,136,204,30,132,204,83,105,44,151,25,220,53,40,135,118,196,121,33,206,156,30,30,106,70,143,226,65,76,113,3,193,158,17,74,237,143,61,30,191,46,225,96,79,77,249,160,116,201,45,157,170,188,46,32,210,180,244,51,101,39,7,97,108,76,28,245,58,59,28,224,117,46,231,78,52,201,71,121,183,150,91,173,246,147,29,30,1,29,46,182,106,31,83,135,1,72,131,173,181,36,86,135,150,124,107,29,63,175,12,33,59,186,217,24,59,198,182,187,87,102,246,210,42,44,77,243,18,44,104,195,188,58,115,215,204,240,3,29,186,26,91,233,105,62,140,253,53,136,83,45,142,59,110,178,232,18,180,230,70,109,44,91,165,236,25,214,72,107,181,42,140,87,158,120,185,223,76,229,23,236,4,218,239,254,246,198,232,48,187,169,62,45,62,134,78,115,15,199,193,133,196,38,89,73,241,171,134,244,222,131,116,28,98,11,112,151,91,5,218,134,81,190,208,53,234,209,37,173,219,255,105,213,209,160,127,225,71,86,239,69,203,213,205,153,28,32,171,45,208,43,51,149,132,235,224,188,57,254,0,58,60,147,23,247,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEventProcessSelectedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("b3020b96-47b4-48ea-b412-c755340c3b36"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9145d59-d3df-4820-9f30-c3798ae554d0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"ProcessSelected",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IntermediateCatchMessageEventProcessSelected",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(372, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessShowMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessShowMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3e311213-c1c7-4e11-90ae-9678aa8d2c21"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EventSubProcessShowMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(623, 933),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessShowMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartShowMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0910f651-c639-4fb5-b854-0f2cbf7a2714"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3e311213-c1c7-4e11-90ae-9678aa8d2c21"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ShowMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartShowMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateMessageWindowUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e9553c49-cbea-4f68-9d9b-8e17092a325a"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3e311213-c1c7-4e11-90ae-9678aa8d2c21"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"MessageWindowUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 37),
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
				UId = new Guid("6f1abc56-5a1f-490a-bf17-33ad13f78f4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EventSubProcess1",
				Position = new Point(372, 1347),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(442, 228),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskHidePrinElementsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cec09f9a-d52a-4bf2-a29f-d366e039e075"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f1abc56-5a1f-490a-bf17-33ad13f78f4f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskHidePrinElements",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,193,10,130,64,16,134,207,9,190,195,116,211,139,116,143,130,18,35,15,137,244,6,155,142,177,176,204,200,238,108,17,217,187,183,234,165,139,208,121,190,255,251,70,119,144,212,234,142,89,109,53,201,21,123,182,114,244,34,76,217,5,201,103,57,123,18,216,195,38,133,119,28,173,22,208,179,110,91,36,216,65,167,140,195,237,50,88,144,186,25,108,3,185,78,74,87,225,19,134,1,74,151,115,255,74,195,236,19,71,24,4,83,170,226,48,109,244,3,127,44,227,75,97,43,214,227,76,159,180,49,181,229,6,157,27,111,201,40,153,210,135,70,52,211,127,85,139,226,45,205,214,47,76,202,128,244,16,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSyncRecentEntityUserTaskPLCUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("bef3d290-08e9-450b-9f21-64bba5311e35"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f1abc56-5a1f-490a-bf17-33ad13f78f4f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SyncRecentEntityUserTaskPLC",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 128),
				SchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSyncRecentEntityUserTaskPLCParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSyncPreparePLCScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d76fe3d0-2db0-48e6-a081-9b448a563b58"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f1abc56-5a1f-490a-bf17-33ad13f78f4f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SyncPreparePLC",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,206,59,14,194,48,12,128,225,189,167,200,9,114,1,196,212,50,84,170,80,68,40,187,149,90,16,145,184,200,113,134,220,158,135,89,88,42,54,251,183,244,201,190,81,56,97,64,146,3,73,148,54,23,228,51,148,187,155,122,235,91,209,232,195,13,51,140,139,217,27,7,87,180,3,8,248,181,114,64,171,167,121,92,118,157,223,160,180,124,4,29,29,199,12,220,250,53,213,76,23,72,21,255,1,134,88,30,9,218,17,50,190,127,81,227,27,127,168,142,81,42,147,17,126,109,79,156,20,217,38,228,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowDataTabPanelTabChangeIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("40fa767c-6dec-4744-b2a1-f3c1d82fbb63"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f1abc56-5a1f-490a-bf17-33ad13f78f4f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ThrowDataTabPanelTabChange",
				Position = new Point(358, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("069dd4ac-7a30-4a82-936a-3332f1da27fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f1abc56-5a1f-490a-bf17-33ad13f78f4f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PageLoadComplete",
				Position = new Point(22, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9e8b9bbd-a1ad-4208-86ca-9a2c83b8fa7a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f1abc56-5a1f-490a-bf17-33ad13f78f4f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptPageLoadComplete",
				Position = new Point(91, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,88,109,111,219,56,12,254,156,2,253,15,158,63,108,14,46,16,118,159,123,29,208,37,221,150,187,181,235,45,237,237,67,81,12,170,205,180,218,28,41,147,228,118,185,45,255,253,72,73,182,229,188,117,189,23,28,80,164,137,76,145,20,249,240,33,229,177,20,246,140,223,8,121,243,178,178,86,73,147,245,15,246,247,196,52,201,112,21,216,136,91,62,81,149,206,129,77,242,91,152,241,228,201,97,34,171,178,236,39,223,246,247,122,141,204,57,191,102,67,62,183,66,201,228,48,217,188,181,22,64,253,203,253,61,39,51,228,50,135,210,91,102,71,159,248,215,227,59,144,214,176,97,41,242,207,236,157,196,255,248,219,45,162,218,244,94,200,66,221,179,188,84,6,208,207,20,53,221,113,157,112,51,39,109,181,225,163,240,147,155,228,28,180,230,70,77,45,187,24,179,15,112,61,84,210,106,85,26,70,2,184,59,236,100,195,202,88,53,35,143,47,211,201,194,156,168,162,42,225,35,207,173,184,131,246,28,233,213,134,179,121,23,199,35,212,54,169,242,28,204,20,163,51,36,15,79,192,152,200,173,215,128,129,214,124,6,22,244,31,188,172,32,75,243,72,44,165,184,143,49,27,130,151,226,79,24,129,17,55,18,52,186,2,62,62,46,49,171,214,143,37,191,46,97,2,250,14,244,145,115,247,189,186,71,139,86,87,16,162,83,52,210,235,222,135,84,23,107,89,62,140,179,172,193,86,90,214,58,49,119,198,106,4,76,242,165,2,189,152,248,239,65,245,123,192,69,99,217,239,237,35,118,174,252,151,6,89,209,62,70,25,225,2,97,151,106,200,149,46,198,69,218,247,86,143,165,21,118,113,166,197,140,235,197,80,149,213,76,186,176,161,41,9,247,201,235,74,20,217,54,155,151,173,182,171,200,126,223,187,63,54,167,64,65,218,102,129,29,127,169,120,105,50,50,193,142,103,115,187,112,185,49,67,53,95,224,182,45,254,211,211,180,159,36,79,159,38,59,252,114,82,177,79,20,234,148,66,155,58,247,66,104,231,177,83,167,8,26,180,187,150,37,214,113,157,145,24,106,240,167,106,115,124,97,69,137,168,2,195,38,11,153,223,106,37,17,94,104,189,202,49,171,16,229,158,10,102,117,51,185,52,85,26,120,126,155,100,132,38,83,111,244,70,19,33,99,191,134,149,214,88,13,141,118,230,165,140,207,232,202,94,54,54,71,229,61,95,152,9,148,144,219,22,181,203,250,16,137,118,96,38,36,6,232,184,212,5,84,186,103,177,113,116,211,18,254,29,208,122,219,145,150,59,193,15,194,222,94,180,112,251,135,120,235,234,92,5,93,143,188,101,19,176,145,222,204,45,109,75,228,96,43,58,157,190,101,2,165,129,31,119,156,108,189,238,154,95,131,88,127,213,233,101,204,240,117,144,17,9,48,182,48,11,160,116,207,253,41,220,202,79,73,250,49,197,207,173,181,213,97,3,76,82,54,130,41,175,202,150,27,77,183,197,244,28,135,193,52,122,126,152,172,239,65,236,142,68,78,237,5,237,37,191,248,50,26,36,234,250,19,66,235,197,182,20,164,231,139,57,96,190,6,93,11,151,245,250,85,19,7,242,34,111,66,101,66,108,223,10,99,131,173,23,120,160,94,175,23,68,81,157,179,64,130,24,247,81,253,211,159,58,84,148,43,168,59,151,42,42,163,90,38,58,183,183,136,58,34,172,132,146,98,175,176,25,190,92,144,55,153,211,193,126,131,133,199,26,33,63,236,236,134,114,83,8,188,32,139,150,60,252,188,206,22,113,177,90,172,220,183,74,125,174,230,20,38,34,188,176,252,30,166,128,245,159,67,23,214,35,97,230,37,15,40,88,117,169,215,139,194,202,142,138,98,245,52,46,252,238,99,217,134,206,147,81,222,112,208,122,124,130,254,200,233,55,220,212,121,112,36,189,233,44,223,191,39,205,242,9,34,76,180,207,250,180,233,73,236,108,195,40,121,91,183,53,155,172,157,42,150,57,136,79,68,174,191,85,188,240,150,66,172,2,90,34,37,110,83,196,118,99,105,64,91,42,108,215,213,90,62,216,69,199,175,68,73,248,118,14,173,49,167,127,72,20,214,86,66,230,23,135,106,54,231,90,24,37,41,18,190,63,14,232,16,107,36,178,131,183,220,9,92,218,254,93,14,121,136,162,58,230,14,154,201,194,27,116,36,142,67,28,112,141,224,112,91,61,203,95,24,58,182,148,224,72,101,208,213,178,154,12,202,31,54,30,211,118,30,63,45,4,48,172,181,42,146,189,124,126,133,118,149,196,73,182,59,170,14,17,226,204,249,72,77,219,59,235,16,67,76,158,228,62,167,193,61,139,51,234,184,168,99,216,245,185,78,63,173,178,70,246,224,129,150,225,134,30,108,178,174,109,120,164,254,199,61,96,19,43,61,6,87,91,201,221,195,186,120,39,145,223,209,125,56,23,51,96,167,190,96,118,238,120,185,112,61,97,83,168,183,239,197,73,93,76,197,163,204,213,91,30,180,247,67,221,135,4,31,75,143,255,31,63,62,76,144,45,241,63,138,35,183,147,36,78,77,110,184,140,7,105,204,136,187,192,53,151,167,108,23,206,220,109,51,186,102,69,154,26,5,97,82,13,12,64,17,11,67,43,134,167,221,219,233,130,77,214,194,244,223,30,169,78,94,119,118,115,135,205,250,81,139,11,50,100,179,145,162,128,65,17,197,167,137,125,227,198,230,97,192,215,219,134,145,49,86,21,247,176,229,174,123,221,84,149,5,104,26,180,29,64,252,17,17,62,167,120,252,119,218,93,175,118,204,213,205,238,171,224,189,191,44,64,241,42,60,248,177,241,60,82,83,223,1,143,11,65,119,142,39,254,54,72,174,249,140,185,252,101,254,121,120,203,177,97,140,169,233,114,3,169,99,208,168,30,138,72,176,169,210,45,111,70,104,150,219,100,197,77,119,109,227,156,107,149,131,49,84,247,32,177,59,255,45,87,132,180,47,178,149,78,49,62,243,154,143,229,141,144,192,206,54,218,105,42,211,193,123,151,47,72,30,104,165,239,43,105,120,203,229,13,184,185,225,98,94,16,189,246,9,253,207,107,48,134,238,161,197,220,158,112,137,63,52,209,129,95,200,210,111,207,151,204,116,81,248,172,101,218,103,131,228,219,207,203,254,1,13,240,235,175,100,6,158,104,134,86,233,154,143,127,197,17,6,207,125,135,172,128,118,62,104,97,221,82,214,225,235,122,232,199,191,201,173,186,63,23,115,199,174,39,252,51,132,87,88,225,93,76,61,37,181,175,109,138,246,22,219,46,82,45,192,87,251,6,202,121,244,42,103,211,187,39,9,80,224,225,71,128,181,83,6,32,187,183,78,30,164,142,75,2,70,247,247,226,215,50,127,1,33,212,11,19,199,19,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b871e078-7b92-43d8-801b-96c6837511c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EventSubProcess3",
				Position = new Point(589, 1130),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(203, 109),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8590fa66-a8ef-4cc2-8d5c-0b41603c4de9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b871e078-7b92-43d8-801b-96c6837511c7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"OKButtonClick",
				Position = new Point(22, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOKButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("14493f34-45a0-4557-a526-6d82ce3a7e49"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b871e078-7b92-43d8-801b-96c6837511c7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptOKButtonClick",
				Position = new Point(105, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,77,107,27,49,16,61,59,144,255,48,232,180,75,130,200,57,38,133,176,41,238,22,26,76,108,218,131,227,131,178,26,219,2,237,200,72,90,59,174,217,255,222,209,174,29,59,41,164,208,155,230,227,189,121,243,70,102,1,217,163,139,24,166,234,165,36,141,175,240,5,110,114,216,95,94,12,66,244,134,150,64,169,10,119,144,101,99,181,68,249,160,162,226,222,177,34,180,146,31,97,246,14,62,151,101,196,58,204,110,230,160,2,36,68,225,40,42,67,232,115,153,194,146,66,84,84,161,28,97,28,123,183,70,31,119,63,149,109,48,19,29,209,87,109,162,200,19,248,91,172,109,138,114,57,197,215,56,100,69,27,229,161,114,180,97,12,250,164,137,112,11,223,131,163,226,152,156,205,97,159,146,163,198,232,119,133,44,111,135,167,157,140,102,112,170,203,9,122,163,172,249,141,167,237,38,174,241,172,239,190,138,102,131,79,110,43,199,222,212,202,239,10,103,155,154,58,173,215,103,50,120,213,60,81,119,248,73,229,205,58,254,80,196,129,151,247,90,247,137,191,200,11,107,144,98,249,0,87,192,208,129,144,142,222,230,157,205,9,197,74,209,18,245,19,134,181,163,192,30,117,237,140,226,13,174,64,92,239,159,123,215,158,5,220,194,190,58,33,111,65,28,58,63,172,217,157,51,79,224,182,205,135,34,73,111,47,47,12,127,131,143,26,39,213,10,107,5,119,108,115,99,109,255,39,60,198,198,19,68,223,224,9,88,134,194,173,119,125,195,35,162,158,122,196,145,55,172,122,225,49,172,216,234,67,255,127,123,36,100,80,27,204,142,122,1,109,192,110,220,167,132,157,179,73,160,96,138,79,217,213,219,173,107,167,205,194,160,238,237,231,157,122,199,7,255,32,56,200,3,113,60,232,81,35,108,13,105,230,173,172,11,93,71,155,238,114,112,189,12,191,186,106,145,138,39,155,206,77,254,3,68,253,200,50,160,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("db94ee31-f526-4156-ab8c-aa8435f9876f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EventSubProcess7",
				Position = new Point(36, 1116),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(536, 214),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaUserTask CreateSetDetailFilterUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("958af1cf-e7fd-4306-ab40-79c68e8c5625"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db94ee31-f526-4156-ab8c-aa8435f9876f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SetDetailFilter",
				Position = new Point(315, 27),
				SchemaUId = new Guid("f2200aba-2944-475d-b8dc-e9bc7f9e2d84"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSetDetailFilterParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSetDefDetailsUserTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7ac53080-8296-43dc-a026-301ee9b54422"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db94ee31-f526-4156-ab8c-aa8435f9876f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskSetDefDetailsUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(427, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,246,75,45,87,168,169,81,240,44,118,206,47,168,212,84,168,230,226,12,78,45,113,73,45,73,204,204,1,202,165,166,56,166,164,64,120,65,169,133,165,169,197,37,26,37,69,165,169,154,214,92,181,92,69,169,37,165,69,121,10,32,190,53,0,166,172,6,29,76,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataTabPanelTabChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("43901eca-38a6-41a9-98a3-a95bb834c2a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db94ee31-f526-4156-ab8c-aa8435f9876f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"DataTabPanelTabChange",
				Position = new Point(28, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataTabPanelTabChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a526974d-956a-40f2-aff2-5fbe43308a8e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db94ee31-f526-4156-ab8c-aa8435f9876f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptDataTabPanelTabChange",
				Position = new Point(112, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,109,111,226,70,16,254,76,164,252,135,173,63,156,140,146,88,228,46,186,114,229,184,138,16,146,227,148,68,8,184,246,67,20,85,11,30,96,91,179,75,119,215,73,104,142,255,222,217,23,3,54,38,69,141,20,97,150,153,103,158,153,121,102,214,79,84,146,24,52,101,137,26,210,81,143,114,72,72,147,244,232,20,162,43,170,105,118,214,56,62,98,19,18,22,44,35,124,80,81,91,164,92,147,102,147,212,170,228,245,248,168,34,65,167,146,19,45,83,64,183,213,241,209,19,198,160,99,205,158,0,237,187,60,134,23,12,81,132,106,229,12,124,188,206,139,142,186,170,245,39,125,233,195,223,41,40,237,34,76,132,36,33,195,160,204,131,213,26,254,241,243,14,238,134,162,183,57,57,113,32,21,67,75,211,81,9,23,227,243,96,141,31,27,198,210,80,65,203,168,171,97,158,229,251,37,75,215,1,45,176,98,109,193,17,135,131,68,200,181,249,67,237,145,80,69,134,32,37,85,98,162,163,239,221,232,119,24,25,91,41,18,131,230,31,122,219,8,141,53,48,51,180,108,113,168,134,56,235,77,75,45,236,167,47,75,116,45,228,252,193,196,108,39,12,184,238,94,145,19,18,252,177,237,25,60,154,22,5,166,43,129,67,55,89,229,105,255,212,36,60,77,146,44,175,202,166,113,38,24,198,206,153,91,198,93,174,52,229,99,112,144,149,141,117,52,156,73,241,220,121,66,54,97,48,0,125,101,107,220,147,216,182,203,84,107,193,239,128,167,65,181,81,177,142,171,61,140,154,142,17,249,241,163,80,136,53,199,49,218,50,158,122,2,14,103,71,108,204,107,202,231,164,76,211,57,60,147,193,82,97,143,162,33,160,206,6,26,185,77,47,83,150,196,32,195,106,99,171,181,18,140,192,11,220,48,125,123,254,86,115,55,207,91,120,131,177,100,11,125,71,57,162,201,98,67,175,145,170,119,193,178,109,91,6,213,195,116,148,115,114,81,93,6,209,13,32,109,44,158,179,8,213,232,148,76,104,162,224,52,79,169,186,45,15,155,34,59,36,238,186,48,89,107,8,254,169,81,212,90,44,128,199,183,248,75,168,108,137,173,88,41,170,226,181,182,138,104,28,135,175,231,171,106,35,56,245,133,94,75,248,180,32,183,236,188,234,9,30,132,31,139,91,186,20,169,14,203,34,100,72,171,141,50,108,33,176,41,8,60,20,78,18,153,22,114,69,194,201,155,50,20,143,188,4,220,70,224,17,57,211,151,75,179,174,178,18,219,15,239,63,146,64,255,178,143,38,30,254,175,8,96,245,109,181,118,20,219,137,153,133,99,52,97,255,128,27,30,181,187,36,253,118,149,48,22,50,238,154,245,208,193,113,208,75,156,179,57,149,203,182,72,210,57,255,141,38,118,62,114,123,120,223,218,203,51,121,244,139,184,200,15,87,174,153,201,245,113,110,53,254,199,85,224,194,246,10,11,179,0,229,215,102,113,41,110,46,161,94,217,158,216,19,245,43,85,190,130,102,51,187,99,131,116,47,52,168,124,82,239,222,149,241,179,171,110,48,158,193,156,126,55,85,118,219,227,38,101,113,24,64,189,6,19,10,31,207,234,239,39,181,179,139,122,124,126,54,26,255,252,225,236,67,125,252,105,114,241,169,126,78,233,69,80,117,204,10,1,11,183,162,209,134,41,208,76,207,19,211,255,117,139,118,185,100,107,23,103,90,247,164,88,128,212,75,219,230,48,176,49,140,187,91,24,95,61,88,6,206,205,207,219,87,252,64,164,18,129,156,180,250,226,217,64,14,151,11,136,183,196,243,217,77,214,23,143,30,88,69,91,132,252,80,180,226,216,43,63,203,33,119,33,69,10,180,103,137,95,191,41,193,163,1,72,39,241,208,18,171,26,51,28,213,170,107,220,72,136,4,183,207,61,60,247,173,194,145,119,215,124,51,218,235,170,182,88,44,27,57,77,73,49,6,165,14,169,155,55,245,238,19,150,224,40,223,194,68,119,94,22,18,207,153,224,27,20,103,90,82,234,235,18,55,87,245,22,110,203,140,155,91,58,174,154,119,136,216,163,122,118,0,120,175,196,13,193,179,27,241,87,114,124,228,247,93,103,190,208,75,242,203,255,68,204,239,185,245,77,237,114,139,240,134,116,27,197,169,191,27,151,72,103,61,24,37,254,101,49,237,139,196,238,113,137,183,251,184,167,115,243,242,17,108,255,20,148,88,95,149,46,150,18,41,148,242,156,194,38,165,221,36,223,12,87,160,185,118,218,79,117,243,114,148,121,221,72,22,27,172,62,76,80,73,51,28,196,50,191,50,197,25,189,151,9,120,175,123,159,77,103,110,14,223,190,47,14,29,34,28,226,162,212,6,144,192,24,95,211,238,69,12,187,216,120,19,239,11,107,52,184,189,191,255,5,63,202,187,0,160,12,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway41234677ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f83f1eff-b917-4764-89e9-d596bb7b68ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db94ee31-f526-4156-ab8c-aa8435f9876f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ExclusiveGateway41234677",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(217, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("14063a14-6b8c-4e0f-927b-2203693fb7ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db94ee31-f526-4156-ab8c-aa8435f9876f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"End1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 140),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b48608ba-3487-4c36-9bb4-c42abc0f6f54"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EventSubProcess2",
				Position = new Point(36, 1347),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(319, 252),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseModuleEditInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8672cbb6-8e15-40e3-91f1-626ddd103911"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b48608ba-3487-4c36-9bb4-c42abc0f6f54"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"BaseModuleEditInit",
				Position = new Point(14, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("834c4cb1-dca2-4c80-8830-e1d4119418fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b48608ba-3487-4c36-9bb4-c42abc0f6f54"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptPageInit",
				Position = new Point(84, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,77,111,19,49,16,61,167,82,255,131,147,147,35,170,21,247,146,74,33,44,52,130,150,208,77,225,128,56,184,217,73,107,112,236,224,143,166,1,245,191,51,182,247,43,155,13,20,46,72,81,178,177,103,222,188,25,191,25,47,95,18,154,74,203,237,118,166,249,138,233,237,68,9,183,146,31,153,112,64,70,35,242,198,241,60,73,87,107,187,29,146,159,199,71,189,123,166,9,55,151,176,33,35,50,99,183,144,188,1,59,99,154,173,192,130,14,94,116,160,97,161,116,62,205,7,195,83,244,224,24,33,122,244,71,68,58,33,34,80,111,90,160,80,137,63,62,76,180,74,230,42,179,154,203,91,58,28,182,8,120,180,199,138,195,68,173,183,191,33,225,183,155,4,130,121,155,65,129,81,108,55,66,227,227,59,181,1,77,3,135,129,213,14,6,101,124,252,156,51,243,10,44,227,194,160,183,223,196,173,64,228,253,219,151,206,90,37,147,241,87,246,144,222,131,180,38,153,8,190,248,150,76,152,51,96,144,28,207,153,229,74,182,28,103,26,238,185,114,230,31,221,47,225,193,254,189,235,241,145,175,77,191,42,157,153,74,110,57,26,254,128,60,214,232,218,192,133,202,157,128,189,116,67,89,15,21,63,219,154,232,150,230,220,122,33,180,42,239,79,208,52,109,174,167,57,66,87,74,120,50,110,83,45,167,37,50,4,61,103,139,59,88,177,11,38,17,75,35,56,166,162,39,74,74,88,248,34,36,233,190,81,39,192,7,7,122,91,112,75,219,235,180,35,212,9,217,165,57,168,137,185,86,53,99,175,93,98,138,24,96,47,104,50,206,243,104,65,7,237,115,192,204,189,91,133,124,7,98,141,201,89,148,193,52,127,58,236,121,211,173,137,185,239,245,154,11,175,16,239,77,247,119,39,26,152,133,104,243,137,219,187,90,82,52,46,78,212,106,205,52,55,74,206,183,107,72,210,239,142,137,19,226,67,117,196,186,82,202,198,255,65,4,205,193,228,25,210,225,201,158,122,218,199,207,193,116,38,143,120,241,20,17,78,68,41,208,93,101,68,32,175,238,18,40,153,40,39,45,57,35,207,11,249,118,181,69,105,252,249,249,23,31,196,103,153,55,102,233,139,27,165,196,25,61,172,128,24,54,196,237,183,225,203,176,189,32,251,170,71,139,221,164,213,21,72,166,93,157,136,253,24,190,77,232,151,93,197,60,129,127,116,59,163,7,148,214,164,31,77,19,28,240,216,241,239,117,24,222,187,126,195,42,35,74,231,217,39,184,241,59,90,97,46,245,243,48,206,69,252,242,11,140,75,208,195,228,188,197,122,7,181,145,229,99,113,85,60,105,72,253,105,64,253,229,108,234,156,75,158,72,19,176,191,127,181,246,122,217,78,196,134,249,105,149,19,1,97,32,154,239,90,35,163,198,2,109,92,86,127,16,77,240,206,118,98,117,123,196,223,57,187,153,49,9,162,188,122,95,49,203,202,181,131,174,83,89,203,177,190,66,186,109,59,122,171,189,116,208,23,207,4,117,140,201,52,39,117,72,176,226,154,41,167,23,144,196,173,235,223,166,187,100,78,88,63,39,216,218,64,222,149,112,82,237,150,23,113,35,196,75,88,42,13,25,187,135,43,181,33,207,70,36,7,1,183,56,38,169,186,249,138,179,134,24,144,185,191,47,106,159,112,111,143,245,173,33,16,53,1,120,123,203,69,168,118,127,172,125,39,32,87,28,82,56,56,52,190,102,89,10,56,44,55,254,176,31,59,24,248,216,169,214,74,99,244,227,163,127,8,159,221,169,77,0,184,0,99,16,28,195,165,15,11,88,135,27,180,88,11,74,3,236,246,115,38,115,17,234,84,156,111,23,165,43,88,169,255,78,202,119,247,216,172,61,183,242,84,203,191,204,144,57,104,205,140,90,218,228,122,154,52,103,147,55,56,141,239,76,133,185,23,235,76,171,37,23,5,183,114,189,150,83,177,29,222,114,139,231,183,176,173,146,42,230,67,152,155,233,131,69,198,254,253,237,10,190,59,48,182,152,11,251,178,171,195,34,255,37,195,145,80,183,187,6,235,180,140,233,254,2,255,93,248,243,222,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateEditInitializeDetailsUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("58df09bf-c532-4161-98f3-2968494e0ddc"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b48608ba-3487-4c36-9bb4-c42abc0f6f54"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EditInitializeDetails",
				Position = new Point(210, 27),
				SchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeEditInitializeDetailsParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aff55c23-fd01-4bc7-872d-70b54c1dbe36"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b48608ba-3487-4c36-9bb4-c42abc0f6f54"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTask1",
				Position = new Point(84, 126),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcesOpenPrintReportEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcesOpenPrintReport = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0105cfb5-dc5e-410e-a661-10413b2ebe96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SubProcesOpenPrintReport",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 1963),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(742, 242),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcesOpenPrintReport;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPrepareParametersPrintReoprtOpenScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6fad93c0-f093-4d88-abdf-9ebfb581ab7f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0105cfb5-dc5e-410e-a661-10413b2ebe96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskPrepareParametersPrintReoprtOpen",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskClearPrintUserContextScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1419b1ad-f4d7-45fc-8dd8-6c8fbce49ca8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0105cfb5-dc5e-410e-a661-10413b2ebe96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskClearPrintUserContext",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(631, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,78,45,46,6,210,46,137,37,137,122,65,169,185,249,101,169,26,74,1,69,153,121,37,65,169,5,249,69,37,1,137,69,137,185,169,37,169,69,197,74,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,207,243,235,149,73,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePrintButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("47bf5540-cec5-4f31-b490-ad7d964a6cdf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0105cfb5-dc5e-410e-a661-10413b2ebe96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PrintButtonClick",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartMessagePrintButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("df045715-ab64-4d5c-9666-721f708fcb1b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0105cfb5-dc5e-410e-a661-10413b2ebe96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSetPrintReportParametersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4a5c954d-97b2-45f2-b7de-644b553ac2a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0105cfb5-dc5e-410e-a661-10413b2ebe96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskSetPrintReportParameters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(372, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,93,107,219,48,20,125,142,127,133,230,39,135,53,134,108,161,73,112,91,72,147,144,21,86,18,234,150,61,140,82,46,214,77,34,150,72,70,82,90,66,217,127,175,62,18,108,199,157,203,168,31,36,251,234,222,115,142,174,142,204,150,36,90,72,198,245,29,230,66,234,52,91,227,22,30,110,40,185,188,36,179,29,163,241,116,155,235,125,155,188,6,45,137,122,39,57,209,114,135,73,240,55,120,80,40,239,65,253,153,231,200,75,8,11,88,97,108,99,40,111,184,210,192,51,180,104,228,248,97,176,147,198,90,59,56,1,132,227,139,211,16,133,253,140,2,194,96,208,201,96,208,237,244,186,67,218,25,66,191,223,201,190,117,7,189,229,247,172,59,60,239,133,237,36,120,6,73,114,83,239,183,113,11,220,188,75,131,100,249,198,130,115,204,52,19,60,158,161,174,100,68,225,226,180,168,142,102,96,106,208,22,233,184,177,235,189,81,29,253,175,230,54,9,90,246,1,69,10,13,71,106,9,91,212,40,213,161,23,19,230,228,131,220,95,40,109,186,182,58,243,211,85,100,196,22,217,241,136,26,250,147,243,12,207,222,59,229,248,94,164,14,34,106,191,3,49,229,154,233,125,9,194,73,140,39,160,33,21,59,153,97,236,215,226,26,18,171,186,106,158,91,221,170,48,215,151,154,185,78,185,125,73,209,146,3,255,191,49,171,2,154,237,105,135,69,185,187,5,123,179,55,199,200,77,18,90,115,250,107,208,148,252,139,81,189,174,184,198,135,154,171,126,32,91,173,117,181,204,199,62,144,182,17,10,253,189,155,243,159,2,172,198,37,108,20,122,51,41,220,24,243,35,189,19,47,118,195,198,183,14,32,61,132,71,198,89,207,104,23,173,151,78,174,75,138,74,153,217,158,251,239,15,92,68,190,146,240,169,14,26,62,26,206,178,132,164,213,250,44,139,221,235,173,160,232,176,195,41,101,174,15,46,146,4,229,127,213,27,204,243,19,218,227,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskOpenPrintReportPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("914e256d-d58b-49e0-bc3a-c482a54df751"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0105cfb5-dc5e-410e-a661-10413b2ebe96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"UserTaskOpenPrintReportPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(498, 72),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskOpenPrintReportPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageOpenPrintReportMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5cd067ef-5bd6-41bf-b683-5e121962f8b1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0105cfb5-dc5e-410e-a661-10413b2ebe96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"StartPrintMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartMessageOpenPrintReportMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessBaseModuleEditPageLoadEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessBaseModuleEditPageLoad = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f584f8c4-7bb3-4479-8381-fa7f5b2d68f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SubProcessBaseModuleEditPageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(896, 1115),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(296, 256),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessBaseModuleEditPageLoad;
		}

		protected virtual ProcessSchemaSubProcess CreateLoadPrintReportButtonMenuProcessSubProcess() {
			ProcessSchemaSubProcess schemaLoadPrintReportButtonMenuProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("41088c29-9e6e-4b69-b8e4-f6069f688ffa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f584f8c4-7bb3-4479-8381-fa7f5b2d68f3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"LoadPrintReportButtonMenuProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 37),
				SchemaUId = new Guid("b7e6c182-5e8a-42d3-9de3-0e739f6632f4"),
				SerializeToDB = false,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeLoadPrintReportButtonMenuProcessParameters(schemaLoadPrintReportButtonMenuProcess);
			return schemaLoadPrintReportButtonMenuProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageBasePageLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a09dff9b-f8d2-4164-a3f0-a94dc40d4c71"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f584f8c4-7bb3-4479-8381-fa7f5b2d68f3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartMessageBasePageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPrepareParametersFillPrinReportMenuScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("88a78a98-8ec2-4bb6-91d4-c0cb5dee6050"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f584f8c4-7bb3-4479-8381-fa7f5b2d68f3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskPrepareParametersFillPrinReportMenu",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,79,76,9,40,202,204,43,9,74,45,200,47,42,113,42,45,41,201,207,243,77,205,43,13,40,202,79,78,45,46,214,11,78,45,1,50,11,82,139,74,42,195,18,115,74,83,53,148,130,43,139,125,243,83,74,115,82,61,83,148,116,144,56,154,214,92,62,164,155,6,146,85,210,81,8,72,76,79,213,195,208,170,7,146,5,154,91,148,90,82,90,148,167,80,82,84,154,106,13,0,19,106,89,246,178,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskDefPageLoadEndScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a0e3b040-538f-4a5c-90c0-cd772f3319e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f584f8c4-7bb3-4479-8381-fa7f5b2d68f3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskDefPageLoadEnd",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessCheckBeforePrintEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessCheckBeforePrint = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"EventSubProcessCheckBeforePrint",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 1641),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(634, 310),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessCheckBeforePrint;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrepeareSaveBeforePrintParamsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7f8a7ca6-852d-4f46-b020-c0735007051a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptPrepeareSaveBeforePrintParams",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 203),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,206,177,14,130,48,16,6,224,221,196,119,184,116,38,190,0,106,34,168,9,3,5,129,197,145,144,19,27,147,214,180,87,149,16,222,221,54,50,17,59,221,112,223,255,223,165,119,236,30,117,251,194,4,111,74,99,169,133,164,77,217,246,8,59,240,35,94,175,210,127,36,71,99,220,186,193,15,57,185,216,94,44,26,18,74,206,40,212,145,117,74,186,48,203,248,185,168,242,67,147,21,156,133,108,98,137,148,52,158,95,79,53,47,130,176,66,243,116,16,231,219,62,33,241,13,71,209,249,143,90,61,108,13,57,216,71,240,155,123,24,71,54,160,97,17,176,69,215,92,193,166,8,70,38,149,23,92,81,8,77,238,35,141,100,181,4,210,22,227,47,207,98,107,117,90,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateCheckSaveBeforePrintUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b61661c3-14c6-402b-8c9e-0b1751fe96ac"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"CheckSaveBeforePrint",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(238, 203),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeCheckSaveBeforePrintParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSaveBeforePrintMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7d64b4be-4f5a-46be-9914-69194e0233eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SaveBeforePrintMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SaveBeforePrintMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(350, 217),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateNotSaveBeforePrintMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d89911ce-2f7a-4b20-ad85-af9eba8adae6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"NotSaveBeforePrintMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NotSaveBeforePrintMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(371, 105),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowApplyButtonClickIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3875432c-7297-4c11-a502-ffb00f184d15"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ApplyButtonClick",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IntermediateThrowApplyButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(441, 217),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowStartPrintMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("1dc085de-0a8c-49cd-8438-d0c5ceb074da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"StartPrintMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IntermediateThrowStartPrintMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(532, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("c7f0a3b1-e680-47e4-8ebf-c49f2e8998a4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartOpenPrintDevExpressReportMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("98dca6dc-6d49-4815-b42b-99653f887f08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpenPrintDevExpressReportMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartOpenPrintDevExpressReportMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptReadOpenPrintParamsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9e55b06c-c3d0-465a-857e-fd8c109cb46d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptReadOpenPrintParams",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,65,139,194,48,16,70,207,205,175,24,60,172,45,72,88,207,85,65,84,68,92,88,177,122,18,15,177,142,109,68,147,50,153,86,69,252,239,182,5,81,80,240,250,49,239,61,166,80,4,177,53,140,103,158,41,82,71,100,36,7,221,199,38,23,41,217,211,168,64,195,125,74,28,40,7,67,29,179,182,70,209,165,227,152,180,73,90,96,55,123,140,185,23,10,189,3,255,205,38,7,229,162,180,113,83,188,248,13,86,73,35,8,224,42,188,162,76,103,31,154,79,114,85,95,175,229,194,70,117,201,15,100,148,29,52,251,205,159,102,16,10,175,202,61,13,242,15,77,194,41,244,160,93,251,189,89,201,240,28,51,75,28,197,41,30,213,114,178,45,51,6,79,48,206,245,246,5,93,253,174,43,223,43,241,159,85,95,186,111,96,187,6,111,226,38,8,57,39,3,76,57,134,119,211,186,183,39,86,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSetMustSaveBeforePrintScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f29a6c2c-0ff7-43e2-a798-08098163c01d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SetMustSaveBeforePrintScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(525, 210),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,193,10,131,64,12,68,207,10,254,67,216,147,82,216,31,144,30,218,122,233,65,144,10,189,7,55,150,128,221,45,49,107,15,165,255,222,85,63,160,167,48,153,97,230,181,113,214,30,23,58,211,24,132,58,97,175,112,4,149,72,117,145,119,248,32,219,15,194,47,109,209,39,33,246,228,220,254,40,139,60,203,12,143,80,26,56,192,150,108,80,177,15,81,6,178,151,137,201,235,181,73,150,177,56,40,47,116,11,111,251,12,142,71,38,119,199,41,210,92,193,199,192,90,147,253,41,152,19,96,89,213,176,46,109,179,95,147,78,149,8,133,52,138,223,121,127,241,56,73,13,203,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSavedCanPrintMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7dcb7cd9-0c1b-4ae4-a055-a6ab7da47580"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d9e89835-d024-49e6-912f-fc15c2c83709"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SavedCanPrint",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SavedCanPrintMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(553, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SubProcess1",
				Position = new Point(36, 2235),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1176, 483),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b3f5495c-2777-4bbd-9308-c66be2337461"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"DataSourceSaved",
				Position = new Point(21, 182),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("092402ec-6037-4377-b137-ee742f70f081"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptDataSourceSaved",
				Position = new Point(602, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,44,73,12,206,47,45,74,78,13,78,44,75,77,241,77,45,201,200,79,209,72,206,207,43,73,173,40,209,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,124,87,47,134,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptBeforeCloseScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("46f4b017-6a6f-4bd7-86f8-fafa14ad09f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptBeforeClose",
				Position = new Point(105, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,209,106,194,48,20,134,175,39,248,14,177,23,67,65,250,2,206,193,102,59,201,197,170,179,110,176,203,208,30,37,144,230,116,201,137,78,170,239,190,148,86,135,202,100,87,9,231,124,255,249,15,127,178,17,134,101,206,24,208,20,107,146,180,99,99,54,23,107,8,35,65,34,69,103,50,8,159,50,146,27,88,224,118,212,237,200,21,235,159,243,189,49,211,78,169,1,171,186,157,187,185,145,133,48,187,9,42,87,232,15,161,28,248,121,103,124,120,141,140,126,133,145,180,165,18,255,209,95,147,126,204,161,89,48,5,5,25,65,254,130,42,7,195,243,227,142,236,254,158,245,46,155,97,252,229,132,178,253,169,147,254,94,148,180,27,212,92,159,219,4,182,108,191,103,220,78,176,108,138,83,32,110,83,18,36,179,4,105,129,72,205,148,43,199,65,19,199,4,245,74,154,130,235,76,185,28,184,110,218,97,29,112,155,243,232,111,234,21,172,245,196,18,190,201,195,23,221,182,121,67,206,51,212,94,23,188,189,199,233,146,207,146,224,6,251,236,136,80,219,26,255,140,211,100,118,139,93,128,45,61,11,237,6,181,72,251,160,34,233,127,9,106,255,50,15,150,140,212,235,33,107,206,71,86,85,193,14,108,48,244,195,193,182,178,224,48,100,85,160,177,174,38,120,42,30,106,227,8,79,158,231,185,122,43,50,199,135,54,64,206,232,166,240,3,228,21,92,66,198,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateConfirmIncludeInFolderUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("393724b3-8b65-4b09-ba21-c26c24a15611"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ConfirmIncludeInFolder",
				Position = new Point(336, 21),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeConfirmIncludeInFolderParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateYesMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e4cd4758-8aa3-494a-9fea-387eec6bc80a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"YesMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"YesMessage",
				Position = new Point(477, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptYesMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8f0a31ad-832f-48d1-b97c-1cadb6e3656c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptYesMessage",
				Position = new Point(603, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,246,75,45,87,168,169,81,240,44,118,206,47,168,212,84,168,230,229,226,244,204,75,206,41,77,73,245,204,11,78,205,73,77,46,73,77,113,203,207,73,73,45,210,64,229,122,166,104,90,243,114,213,242,114,161,11,43,216,42,184,151,102,166,232,185,230,22,148,84,2,149,20,165,150,148,22,229,41,148,20,149,166,90,3,0,248,234,231,118,116,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateNoMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ef2a6d30-b345-4f03-8582-fc7168d10968"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"NoMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"NoMessage",
				Position = new Point(623, 308),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateTreeGridLoadRowUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b2e4ba66-8b06-44c3-934a-e7d88d510a00"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"TreeGridLoadRowUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(896, 168),
				SchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeTreeGridLoadRowUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskAfterDataSourceSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6493a93c-1aa7-4440-845c-eb9af81d5f13"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskAfterDataSourceSaved",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1057, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,177,106,195,48,16,134,103,27,252,14,34,147,188,232,5,74,7,199,205,224,33,33,196,41,153,21,116,110,13,66,231,234,206,49,165,228,221,107,157,67,241,144,78,2,233,251,191,255,116,125,167,116,67,151,62,56,156,106,143,4,165,250,41,242,76,31,237,7,152,138,134,116,42,75,234,12,49,90,194,142,205,123,99,46,112,173,49,112,68,79,38,1,165,145,168,46,95,138,252,94,228,224,9,196,210,207,242,3,128,107,33,184,55,96,219,251,202,123,156,246,64,148,82,194,100,210,116,254,140,56,237,110,16,88,111,18,45,92,229,30,169,71,96,147,252,89,246,191,81,189,170,206,206,229,9,155,231,200,26,58,192,180,190,108,168,198,225,123,125,211,2,47,30,74,218,191,198,19,124,141,64,172,133,147,90,25,243,24,251,192,39,24,48,242,118,100,198,96,118,193,94,61,184,89,201,113,20,163,252,91,239,71,226,214,222,96,11,29,70,144,92,41,223,125,242,176,158,231,201,58,102,216,213,54,8,186,172,224,46,107,142,192,99,12,75,239,47,124,161,98,158,199,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayAfterSaveExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("c72690c4-a429-4348-90a9-fcdd19526e4a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ExclusiveGatewayAfterSave",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(763, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePreSyncDSSScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("81518e82-9722-45dd-a356-00b23da3882a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"PreSyncDSS",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(224, 308),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,206,59,14,194,48,12,128,225,61,82,238,144,19,228,2,21,19,97,232,130,42,76,187,91,169,5,17,73,138,28,103,200,237,121,132,133,5,177,217,191,165,79,134,150,253,137,60,101,57,100,9,210,230,66,124,198,114,115,0,22,90,233,17,252,149,18,142,171,217,153,9,47,100,29,10,194,86,217,147,237,167,121,92,7,173,180,130,31,90,47,111,164,143,19,135,132,220,246,91,172,41,47,24,43,13,255,8,46,148,123,196,118,196,68,175,127,58,242,137,223,150,86,76,82,57,27,225,231,254,0,108,190,159,127,234,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSyncRecentEntityUserTaskDSSUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("765a52e9-f0ca-4bd8-812e-bf61ba1bed78"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SyncRecentEntityUserTaskDSS",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(364, 308),
				SchemaUId = new Guid("788daa7e-2cdc-4ddf-b73a-7b2f38c98ba6"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSyncRecentEntityUserTaskDSSParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaParallelGateway CreateBaseParallelGateway1ParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("77f615c2-6c64-4611-8dc6-cd89889047e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"BaseParallelGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateBaseExclusiveGateway4ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("20eb4604-b55a-45d0-82af-8bc44ce47354"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("185300ea-1e8f-4f72-9749-aced1e53f3f4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"BaseExclusiveGateway4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(343, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessAllowAddDetailEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessAllowAddDetail = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a56909ce-ae55-4584-b987-125fe3cb3b63"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SubProcessAllowAddDetail",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 2725),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(453, 413),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessAllowAddDetail;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageRequestAddDetailMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fb3ebee4-b51d-437d-9058-5c07fe1c9678"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RequestAddDetailMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartMessageRequestAddDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskAllowAddDetailScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aba7e3fc-4360-4bf3-a025-dd33b70e724c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskAllowAddDetail",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,141,49,142,194,48,16,69,235,205,41,44,215,209,94,32,11,18,40,20,20,24,150,132,130,210,138,255,162,136,104,188,242,76,54,68,17,119,39,1,55,43,148,105,190,52,243,222,31,3,184,2,228,114,136,173,155,85,211,248,110,7,102,123,129,90,168,31,219,48,178,228,185,93,185,200,156,24,161,180,124,253,60,188,160,41,102,153,216,85,226,38,35,106,208,29,81,249,224,140,151,194,254,193,197,243,172,190,173,60,141,158,254,62,109,138,114,187,55,122,150,92,183,34,158,120,130,207,155,194,236,231,201,35,248,119,36,17,127,79,10,161,83,121,93,73,237,201,134,254,139,37,212,116,73,213,43,151,106,24,116,15,214,169,210,255,43,99,131,190,167,201,199,219,12,154,252,164,228,160,254,221,184,103,73,128,180,129,148,132,22,217,3,71,246,225,214,134,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateAllowAddDetailUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3b7525e9-2068-4768-acdf-de1795f5b27f"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"AllowAddDetailUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 42),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeAllowAddDetailUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSendAllowMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9aca68c3-9906-4950-a97b-fee7d69e1586"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskSendAllowMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 165),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,77,107,27,49,16,61,59,144,255,48,236,105,69,140,240,57,198,5,179,78,211,45,36,152,108,104,14,142,15,211,213,196,17,104,71,70,210,218,78,205,254,247,74,187,77,237,52,244,166,249,120,51,239,141,222,61,145,170,136,213,130,2,106,51,55,198,238,239,200,123,220,16,204,32,184,150,166,151,23,250,5,242,101,204,200,5,6,172,108,235,106,146,85,253,74,13,194,108,6,220,26,35,224,120,121,49,114,20,90,199,239,168,110,0,222,219,64,254,17,127,150,172,232,0,95,96,50,244,250,224,52,111,128,83,53,110,202,79,11,98,239,18,153,140,140,15,191,250,0,95,203,50,80,227,87,147,53,160,135,132,40,44,71,222,76,78,200,20,150,236,3,114,164,119,75,97,233,236,150,92,120,251,129,166,165,60,235,7,221,40,29,50,145,192,223,66,99,82,36,228,35,29,66,164,59,218,161,131,218,242,46,98,200,37,78,76,123,248,238,45,23,239,201,213,26,142,41,121,219,106,245,161,144,139,110,122,210,164,85,4,167,186,172,200,105,52,250,23,125,58,223,188,14,122,71,15,118,47,151,78,55,232,222,10,107,218,134,123,174,227,51,26,81,170,72,163,123,124,85,59,189,13,119,200,49,112,114,174,212,144,248,52,188,48,154,56,148,11,184,130,8,29,101,210,242,223,125,103,123,124,241,138,188,33,245,64,126,107,217,199,27,245,237,17,21,21,92,65,54,62,62,15,87,123,206,224,26,142,245,9,121,13,217,159,206,127,100,246,223,41,18,184,235,196,52,19,131,13,122,126,39,186,195,153,228,87,235,26,12,121,150,76,114,115,8,125,28,167,107,133,193,58,185,27,94,148,139,232,151,73,39,61,238,226,123,154,141,225,127,106,69,218,86,250,39,205,42,202,52,214,39,7,191,160,241,201,140,231,214,252,13,92,74,171,233,243,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAllowAddDetailStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("18d8838c-9820-4c17-957b-1766afb153d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AllowAddDetailMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartMessageAllowAddDetail",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 179),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSendAllowAddDetailMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5f2accfc-6601-4c98-a286-78349e42a186"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SendAllowAddDetailMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"SendAllowAddDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 182),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSendAllowDetailMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7a85f52d-ca65-4733-a4a9-94485fe3d779"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskSendAllowDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,177,10,194,64,12,134,103,239,41,130,83,93,14,247,195,161,168,67,7,165,160,155,116,136,94,212,194,153,194,93,188,10,226,187,123,214,42,40,186,37,63,223,255,37,17,61,88,18,172,93,88,227,182,68,38,7,19,40,241,64,122,134,130,175,204,168,152,64,220,73,29,41,101,9,249,42,233,52,132,205,119,152,191,10,5,91,186,84,79,203,19,122,156,152,54,156,70,38,159,124,111,183,46,132,78,97,51,174,0,3,124,80,70,213,123,200,150,68,118,69,108,103,157,38,119,174,105,23,20,66,2,71,112,85,131,31,118,253,216,10,14,130,188,35,189,62,250,166,157,71,98,201,134,93,59,183,189,171,215,12,71,70,13,254,95,73,191,238,209,5,50,234,166,60,201,217,51,136,63,147,185,3,218,117,155,173,74,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("5629032e-26ca-4c0b-a528-8a601c3e7c8f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDenyAddDetailMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fb20f4b4-6707-4412-a2e1-3d103c095e9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DenyAddDetailMessage",
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"StartMessageDenyAddDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 322),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskDenyAddDetailMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fc467cdb-267e-45d0-be00-b194964eb977"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62954eaa-b054-45ee-861c-28f41fd81dfb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"ScriptTaskDenyAddDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 308),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,77,77,9,78,205,75,113,73,45,73,204,204,113,204,201,201,47,247,77,45,46,78,76,79,85,176,85,72,75,204,41,78,181,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,250,31,82,193,48,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateIncludeInSelectedFolderMethod());
			Methods.Add(CreateAreConditionsCorrectMethod());
			Methods.Add(CreateMakeCaptionMethod());
			Methods.Add(CreateSetDetailsNeedAddDetailRequestMethod());
			Methods.Add(CreateGetPrintSelectedActiveRowsMethod());
			Methods.Add(CreateDataSourceSavedMethodMethod());
			Methods.Add(CreateShowErrorMessageMethod());
			Methods.Add(CreateGetSysModuleIdMethod());
			Methods.Add(CreateInitializeContextHelpButtonMethod());
			Methods.Add(CreateGetIsContextHelpButtonHiddenMethod());
			Methods.Add(CreateGetIsContextHelpEnabledMethod());
			Methods.Add(CreateGetDefValuesMethod());
			Methods.Add(CreateGetIsStaticNotRootFolderMethod());
			Methods.Add(CreateShowTipMethod());
			Methods.Add(CreateFillProcessMenuMethod());
			Methods.Add(CreateGetModuleProcessesInfoMethod());
			Methods.Add(CreateInitializeDesignerModeButtonMethod());
			Methods.Add(CreateGetIsDesignerModeButtonHiddenMethod());
			Methods.Add(CreateIsEntityChangedMethod());
			Methods.Add(CreateDoPagingMethod());
			Methods.Add(CreateRegisterButtonsScriptMethod());
			Methods.Add(CreateInitDataSourceStructureMethod());
			Methods.Add(CreateInitStructureStoreMethod());
			Methods.Add(CreateEnabledPagingButtonsMethod());
			Methods.Add(CreateLockAjaxEventsMethod());
			Methods.Add(CreateInitPagingButtonsMethod());
			Methods.Add(CreateCheckIsNotesChangedMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f83ce94-cebc-400c-954c-bcb0fa73c690"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ec535512-952e-4f67-b052-d83dd8cbca7f"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5375dee1-bc17-46f5-9908-be2eaf10ece0"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6859a846-19bc-45e6-8ad5-b6c619db02aa"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8dee24f2-ec02-4125-a8b6-88b3d5ae47c2"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4d5c769a-260c-4913-9dfd-5f7a68a5f440"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f8edb689-e2d8-463d-a704-b7e060156d18"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("61f65d3c-be85-4b5c-b0f9-8dba3eb98b31"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5d972c04-b4bc-4b2e-bf55-fb43b1a2df4e"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateIncludeInSelectedFolderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fbd3f78c-0645-4186-b8b6-237d27ab62ea"),
				Name = "IncludeInSelectedFolder",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dec06b68-56a7-4f20-b562-4eebd55cba68"),
				Name = "folderId",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,65,106,195,48,16,69,215,41,244,14,198,43,25,140,46,16,186,169,211,22,47,90,2,110,187,31,228,239,68,96,143,96,52,14,248,246,113,172,22,28,66,160,221,137,225,205,255,111,180,249,132,8,197,208,169,173,130,192,190,176,122,245,136,233,49,53,238,136,129,178,46,244,45,100,30,201,239,228,41,251,138,144,42,48,195,169,15,124,197,191,19,211,1,98,223,160,53,71,37,118,120,158,62,104,128,105,84,60,31,230,42,118,164,102,63,83,118,71,74,77,24,197,193,166,109,123,33,203,44,175,249,117,169,205,139,98,251,248,176,57,145,172,61,82,223,236,113,227,102,43,1,41,18,96,174,53,151,164,155,20,219,64,119,232,170,208,143,3,127,83,63,34,154,251,228,10,51,121,82,172,219,188,252,17,169,219,191,109,254,235,39,218,188,40,179,148,179,23,63,144,76,171,168,123,125,116,194,114,133,64,71,225,237,25,195,3,20,54,234,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAreConditionsCorrectMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dbed006b-1f92-40c2-ae82-1c6b68b2cb89"),
				Name = "AreConditionsCorrect",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4ba67035-7ce8-4b18-ab00-631359977f85"),
				Name = "Row",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,74,44,78,245,77,45,46,6,178,3,18,243,82,115,244,156,115,82,19,139,52,52,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,148,180,13,77,43,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d9af4267-2de8-4b99-bc92-219899bf27d2"),
				Name = "MakeCaption",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,77,79,194,48,24,62,111,191,162,236,64,218,132,52,122,21,209,144,33,100,23,36,128,122,174,91,135,77,182,117,105,59,200,66,246,223,125,215,50,64,227,56,121,106,147,247,249,234,211,119,207,20,138,101,86,229,197,146,229,28,77,208,138,237,56,157,49,195,54,178,82,49,167,155,248,139,231,140,206,69,145,172,148,200,153,170,103,66,151,25,171,195,51,11,147,177,191,7,157,178,103,14,170,27,163,68,177,163,47,121,105,106,7,86,60,150,42,233,12,23,220,172,152,2,172,225,234,157,101,21,199,129,3,68,73,64,174,9,81,75,57,113,7,19,84,84,89,134,158,81,193,15,104,81,137,4,187,9,221,74,103,136,9,65,15,118,114,109,29,179,210,8,89,244,63,54,116,128,177,175,173,74,71,152,75,149,51,3,180,224,120,215,32,124,188,111,72,48,246,69,138,240,32,210,75,136,48,28,34,184,133,178,172,9,58,250,158,72,177,19,160,48,134,160,175,202,134,192,151,190,137,197,121,127,233,131,58,136,123,13,226,153,230,22,117,163,222,223,239,152,198,70,236,249,90,30,218,98,183,117,201,19,7,183,213,62,186,80,79,215,57,192,169,55,110,159,47,33,64,186,153,221,247,46,85,159,164,29,14,255,96,141,186,130,71,189,43,4,1,27,191,107,226,70,17,240,11,107,187,2,231,47,252,223,8,216,54,61,213,101,123,34,166,209,150,43,197,180,76,13,125,139,232,7,255,12,101,97,148,204,52,109,1,164,219,36,48,143,187,64,223,144,224,47,67,114,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetDetailsNeedAddDetailRequestMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("716a91a3-7ee7-4b27-b3f0-7a7e3e01719f"),
				Name = "SetDetailsNeedAddDetailRequest",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5eb64a89-6329-4422-adb3-d372d1f387ed"),
				Name = "needRequest",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,81,75,195,48,16,126,174,224,127,56,250,212,130,132,249,92,38,140,14,164,160,82,180,234,195,216,195,181,189,110,133,52,169,201,69,24,226,127,55,169,29,56,152,34,36,225,187,228,190,251,190,220,117,218,16,54,123,72,222,209,0,99,93,48,13,208,43,40,113,71,98,141,140,21,214,37,42,146,194,3,155,194,199,229,69,212,119,144,204,169,34,28,86,228,218,41,134,27,88,124,39,68,161,88,75,140,189,12,117,114,173,60,84,100,96,9,39,188,205,98,11,104,225,36,39,11,252,160,112,150,191,4,229,164,156,85,162,198,63,244,202,209,196,249,252,131,40,66,84,40,203,168,26,18,165,209,13,89,43,110,137,171,195,72,73,26,208,61,13,53,153,36,126,32,106,87,109,187,158,138,60,210,155,35,203,113,42,238,72,237,120,31,12,92,31,213,255,173,243,68,236,225,72,134,15,47,40,29,253,34,114,5,202,95,207,81,154,121,133,227,183,252,246,43,52,21,237,24,36,124,35,167,1,173,230,208,55,177,34,99,208,234,142,197,115,33,94,169,14,158,140,150,118,178,228,27,52,51,69,238,44,235,33,76,118,19,171,115,54,182,190,248,15,35,217,23,2,165,68,131,34,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPrintSelectedActiveRowsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("601ad86e-e38c-429e-81c2-cd60b178a5ed"),
				Name = "GetPrintSelectedActiveRows",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,205,10,194,48,16,132,239,62,69,232,169,5,9,168,199,170,32,86,138,32,34,22,188,199,116,209,72,147,200,118,211,210,183,119,213,147,150,66,175,187,51,223,236,79,163,80,60,209,88,133,221,214,87,193,186,163,178,32,86,226,164,110,32,51,69,170,240,1,53,200,109,64,4,71,5,97,208,20,16,228,233,223,148,78,26,102,21,80,129,38,40,55,154,76,3,103,223,214,12,115,208,138,131,169,105,153,7,83,174,227,36,157,244,101,114,83,150,241,206,145,161,238,7,125,81,85,128,228,11,231,65,121,132,161,132,204,112,197,59,118,46,107,98,229,109,42,252,245,193,218,79,226,128,247,19,27,237,9,236,44,154,246,182,46,244,29,172,146,239,245,198,32,230,195,136,28,168,119,177,56,25,3,93,48,180,223,103,39,2,63,194,13,29,37,125,1,129,34,2,229,218,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDataSourceSavedMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c5e3d0d8-56d0-44b8-90e8-8cbcaa7174e0"),
				Name = "DataSourceSavedMethod",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2466c734-667a-4119-b9a5-0844ce709f59"),
				Name = "context",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,219,78,131,64,20,124,134,175,56,237,67,3,137,225,3,68,52,166,109,26,146,90,155,130,250,188,194,161,93,93,88,178,187,148,16,211,127,119,23,218,20,162,24,121,32,228,92,102,230,204,64,51,112,182,100,143,222,130,40,18,241,74,36,232,61,38,138,30,113,199,107,152,4,80,84,140,185,240,101,91,91,65,115,34,154,5,149,37,35,205,156,179,42,47,94,9,171,16,2,107,20,193,27,221,242,237,147,189,65,76,99,129,184,18,52,221,97,38,80,30,32,128,140,48,169,219,71,34,64,157,155,97,170,235,45,201,10,213,150,8,146,163,66,209,226,56,211,235,208,212,133,160,83,12,15,16,41,65,139,189,183,204,75,213,192,173,109,153,231,63,16,94,204,187,85,199,245,109,217,126,65,85,166,68,117,50,121,29,37,130,150,74,11,234,51,248,54,213,78,246,244,78,134,253,214,194,203,173,107,78,12,208,139,68,17,19,249,233,25,89,231,3,253,241,169,75,125,206,40,22,42,92,232,141,43,223,31,123,231,8,6,137,193,178,80,84,53,63,91,26,231,247,84,148,232,50,51,103,134,242,141,22,41,175,231,140,75,132,217,12,162,42,73,80,102,218,248,182,244,132,82,154,147,250,191,143,137,51,233,55,131,145,173,129,255,150,161,155,116,41,120,161,220,232,217,103,209,26,234,244,193,92,87,51,116,233,198,7,97,132,25,139,150,71,253,26,204,221,64,129,53,172,169,84,119,252,253,3,19,117,239,184,134,229,100,159,190,1,47,237,152,131,9,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowErrorMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e59e5c0e-017a-408a-8c39-1fd7521047b2"),
				Name = "ShowErrorMessage",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9da21532-6943-4f71-aa04-179f91250423"),
				Name = "errorMessage",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,49,11,194,48,16,133,231,230,87,156,157,18,8,193,189,116,168,130,91,161,131,226,32,14,129,156,229,32,38,37,151,14,34,254,119,69,34,196,233,113,223,123,247,222,136,204,118,198,201,6,244,112,175,143,30,246,49,228,20,253,41,147,167,76,200,230,64,193,21,40,69,51,125,162,102,224,229,171,5,243,101,123,213,208,238,44,227,88,149,181,26,114,90,81,129,101,168,121,39,232,6,242,111,118,211,67,88,189,87,240,20,77,109,152,193,185,242,42,207,54,5,10,179,6,76,41,166,66,245,175,249,248,88,208,148,136,234,196,235,13,218,118,193,1,227,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysModuleIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("01cac851-ead9-4567-b144-20a7dc16ba0a"),
				Name = "GetSysModuleId",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,65,79,2,49,16,133,207,146,240,31,154,61,117,19,210,112,87,73,204,138,132,3,6,93,209,3,241,48,97,71,105,210,109,97,218,98,54,198,255,110,75,151,5,149,120,236,204,123,223,204,188,238,128,24,106,39,93,83,174,214,88,195,12,52,188,35,177,107,182,176,72,133,209,26,87,78,26,45,198,127,69,151,253,222,46,216,183,30,169,9,6,141,31,236,84,245,16,235,252,12,124,192,178,178,177,51,83,121,133,89,222,82,108,99,147,185,48,202,215,250,30,106,12,204,61,91,220,84,85,170,242,163,49,137,179,92,68,229,145,145,154,211,234,95,74,122,63,26,227,210,94,98,130,110,78,178,6,58,153,206,243,142,157,244,119,82,57,36,27,57,45,161,32,4,135,169,254,34,221,122,14,20,12,81,196,251,189,139,84,47,76,189,1,146,214,232,167,102,131,98,188,245,160,6,161,251,251,18,81,30,2,72,59,45,166,85,22,117,243,144,152,184,5,7,165,241,180,66,209,117,243,67,114,251,132,37,218,238,208,112,77,23,165,74,223,199,127,254,102,180,202,55,198,15,86,81,24,175,29,27,177,97,206,62,195,80,66,231,73,119,228,229,240,53,66,227,1,109,132,207,160,60,94,77,188,172,70,252,108,234,113,194,23,67,101,241,20,24,13,98,92,111,92,19,219,223,15,138,163,113,124,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc358b97-f24b-4641-9297-7dabd63fdb1b"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,205,10,130,80,16,133,215,5,189,195,180,17,5,241,5,162,77,18,233,34,8,204,246,55,239,164,3,58,138,142,17,69,239,222,189,253,145,185,26,230,59,103,102,206,208,9,220,249,6,37,238,194,154,5,47,18,97,217,172,122,145,154,35,210,26,217,245,192,113,224,223,177,102,117,44,81,187,158,7,183,217,116,210,73,75,156,67,97,148,183,41,214,176,132,157,202,49,72,178,2,43,21,68,191,218,194,204,156,85,11,125,135,173,129,140,153,80,205,159,137,116,64,173,119,159,152,254,68,121,223,42,139,130,3,105,172,237,198,84,168,36,33,236,130,152,77,85,37,93,113,244,136,251,220,58,194,254,48,175,15,91,228,222,202,177,96,21,170,198,94,122,193,239,185,129,50,12,239,153,156,247,7,244,213,113,247,78,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("06bbcd06-3c73-46d4-a913-efcc29712355"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("76a6b421-167e-440e-9fed-39a67d7c3910"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8ae9b126-25eb-493e-9b92-96920dd20732"),
				Name = "GetDefValues",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, object>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,88,91,79,220,56,20,126,14,18,255,33,204,67,149,145,70,81,159,119,10,171,50,204,34,180,162,157,238,192,238,3,226,193,77,76,73,149,11,117,156,89,69,21,255,189,182,143,227,248,58,19,216,173,202,3,144,248,156,239,220,47,206,14,145,248,9,17,92,211,117,77,11,218,95,229,31,63,127,141,79,227,13,250,130,211,75,76,55,136,160,10,83,76,254,70,101,135,147,217,198,160,157,205,151,199,71,59,11,98,155,61,226,10,189,4,104,224,80,112,109,223,94,55,121,87,226,11,76,81,81,30,194,218,218,228,10,168,107,177,126,178,31,230,214,36,182,140,131,163,67,170,152,180,10,34,199,15,130,160,101,172,53,254,55,190,40,50,90,52,53,34,253,187,150,146,162,254,178,136,155,207,95,113,70,207,18,206,82,60,196,137,223,7,140,189,43,203,248,205,27,143,86,39,112,56,143,191,31,31,69,174,226,82,244,101,87,228,137,195,156,222,52,91,161,72,50,231,10,8,118,172,5,231,26,213,204,98,194,48,152,151,200,170,169,107,44,44,72,215,46,209,192,255,173,195,164,151,82,117,178,79,252,125,226,65,95,196,118,40,103,74,153,34,95,53,101,87,213,31,152,187,25,166,192,78,223,231,242,109,50,227,206,78,249,225,192,160,252,103,230,216,126,20,37,62,221,154,236,252,89,7,186,53,228,1,206,31,69,201,18,161,229,120,9,188,89,17,140,40,134,247,255,20,244,81,101,75,155,48,174,8,14,86,77,197,194,81,180,77,125,211,63,225,116,253,173,67,229,34,26,85,185,36,69,62,69,157,5,36,229,5,162,104,219,116,36,99,54,12,103,16,211,87,104,185,71,67,45,86,76,180,153,80,86,14,21,34,239,65,24,171,25,80,156,185,188,132,28,74,204,148,18,188,188,2,6,222,116,213,116,53,141,207,226,183,144,218,81,160,61,12,244,119,111,239,185,24,174,171,12,172,168,189,119,60,243,207,18,61,145,132,168,200,219,36,40,233,68,104,163,112,107,155,38,239,96,30,10,37,158,143,143,158,161,238,221,110,124,50,22,189,215,114,237,220,99,202,137,221,50,92,83,2,141,195,36,116,219,135,3,228,107,34,166,57,33,144,32,187,99,176,142,224,243,134,15,196,242,10,131,96,217,182,195,132,50,226,243,166,41,49,170,19,215,115,255,119,75,132,70,207,70,1,199,135,83,217,134,108,253,126,119,250,32,76,203,247,109,155,205,226,223,180,211,117,94,80,135,130,11,187,193,132,160,182,121,160,172,120,8,6,149,120,41,233,186,197,149,38,65,190,58,245,153,200,179,251,170,110,41,170,51,124,222,115,165,19,219,10,229,33,56,224,122,252,108,19,71,105,206,112,121,217,208,241,169,108,229,47,84,235,53,35,220,32,250,8,79,76,72,64,188,62,81,54,30,254,113,170,101,175,198,245,33,26,25,102,141,186,195,1,8,185,93,56,59,164,145,62,77,66,52,175,156,47,188,249,186,166,44,220,150,0,229,249,139,52,228,30,83,137,217,100,5,226,45,64,16,173,154,156,79,198,217,133,220,253,102,115,173,72,228,58,56,14,193,61,81,127,193,200,244,0,187,211,19,178,196,76,61,38,30,222,167,235,234,137,246,75,141,208,87,1,62,242,177,90,166,247,18,182,155,120,135,9,12,230,41,77,12,234,29,79,238,0,186,134,243,101,28,252,25,44,194,150,231,193,15,123,246,120,248,11,123,124,20,61,48,197,81,246,152,232,81,143,139,218,151,1,50,60,145,19,152,129,214,187,100,12,226,124,157,36,29,119,28,145,29,39,50,102,87,237,7,54,238,63,18,17,59,139,115,62,168,33,56,252,27,37,171,169,58,135,127,65,208,121,207,89,109,164,225,182,162,16,93,211,2,248,204,80,29,158,19,159,247,3,155,45,6,236,227,27,148,250,29,72,217,73,142,12,55,124,221,157,158,218,144,66,124,252,135,66,96,195,152,65,208,83,54,228,122,7,193,117,126,80,215,73,78,247,153,229,115,189,83,113,114,168,233,252,86,103,176,103,155,99,11,136,9,84,162,104,236,102,74,44,12,105,90,216,132,138,174,104,125,68,184,167,255,97,56,68,134,131,55,164,168,208,224,144,20,134,153,185,4,195,132,136,236,110,239,52,33,230,192,216,227,66,223,160,16,21,230,153,22,227,13,75,163,150,179,130,221,7,96,88,216,77,81,118,179,56,25,119,23,222,204,2,145,241,66,140,156,162,236,228,118,226,181,5,30,147,121,58,68,154,189,147,235,39,32,164,2,98,56,87,120,75,87,170,106,183,90,182,164,127,226,126,225,232,46,47,115,26,100,98,169,43,130,164,131,63,143,143,207,234,42,199,237,164,44,29,0,232,246,208,119,35,131,84,125,54,226,111,167,112,74,22,30,210,145,69,187,248,57,138,56,55,190,76,223,21,3,93,217,8,3,159,220,234,34,102,227,235,87,167,241,43,137,47,8,80,5,6,144,139,176,84,30,85,16,135,188,162,17,42,215,88,204,154,127,172,11,220,22,183,45,251,203,61,112,103,50,105,106,221,187,78,84,180,44,179,180,113,227,176,14,107,224,110,248,36,56,69,62,195,188,143,81,187,231,211,33,135,53,42,180,160,184,226,245,9,114,228,36,80,128,119,252,56,21,176,167,130,20,202,73,126,141,136,194,58,165,127,225,170,217,225,68,87,77,198,136,96,218,17,109,187,89,254,0,217,56,180,151,96,22,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsStaticNotRootFolderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d21a2ac2-6264-49be-81ce-fa9d84191244"),
				Name = "GetIsStaticNotRootFolder",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2ab444c0-526c-49d0-859c-2f15ada947c4"),
				Name = "folderId",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,207,79,131,48,20,62,203,95,81,57,44,37,6,50,39,67,23,196,195,152,44,28,52,75,166,222,159,244,225,72,74,107,74,171,33,198,255,221,50,72,100,97,215,247,253,204,151,247,46,37,39,10,27,195,53,73,72,9,188,193,216,249,2,69,80,232,74,183,251,226,128,53,60,129,128,15,84,150,240,218,160,74,165,16,88,232,74,138,96,139,250,132,65,221,199,169,204,245,8,52,228,12,48,13,122,134,26,109,202,206,162,193,6,52,236,165,81,5,6,61,24,116,104,175,41,37,103,168,250,179,229,159,233,218,85,203,69,163,65,20,184,110,59,37,157,4,93,17,55,59,26,185,222,216,182,219,97,228,31,164,10,65,99,223,159,158,14,96,117,85,73,104,79,15,50,212,197,33,83,178,222,172,135,83,206,60,143,252,56,23,255,3,247,76,91,238,165,253,68,150,74,110,106,241,6,220,224,253,214,84,236,129,14,141,58,52,103,118,185,36,33,2,191,73,7,82,119,197,138,101,25,97,228,47,32,186,246,67,134,119,62,204,151,43,159,225,205,188,12,241,54,44,23,161,213,204,102,163,156,81,4,117,119,160,236,10,71,227,75,107,108,56,143,157,95,71,161,54,74,12,95,16,255,1,80,52,63,96,18,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowTipMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7966f14c-cc70-4e93-9b20-566d4e1807d0"),
				Name = "ShowTip",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,80,193,106,195,48,12,61,39,95,161,229,80,108,8,102,247,146,67,183,177,209,195,88,160,233,46,165,7,173,81,139,135,99,7,91,25,140,209,127,159,147,37,195,59,238,36,244,244,244,244,158,62,208,3,235,126,219,190,188,189,67,5,53,94,72,61,17,215,232,177,35,38,255,138,102,32,81,76,148,66,174,115,125,6,241,203,191,169,192,14,198,192,106,5,251,64,254,222,89,75,39,214,206,170,29,133,16,235,3,50,30,22,186,106,220,142,189,182,23,33,143,203,170,132,175,60,11,19,58,218,136,14,196,79,39,255,41,184,206,179,231,72,137,246,107,180,100,160,75,155,10,162,18,123,103,246,172,141,102,77,65,61,106,219,206,160,152,66,111,66,63,213,25,12,135,219,99,9,197,29,6,74,117,139,18,216,15,36,1,3,164,120,60,63,126,230,207,213,52,98,150,78,212,166,109,231,101,209,232,190,28,147,151,139,92,243,217,147,218,218,179,243,29,142,201,227,207,179,107,126,253,6,39,163,34,38,168,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillProcessMenuMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c18a3103-8075-4d59-b52a-0f8b59fffb20"),
				Name = "FillProcessMenu",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,219,110,218,64,16,125,38,82,255,97,227,151,24,197,90,133,244,18,169,168,15,132,92,138,84,162,40,144,246,165,82,180,224,193,113,99,239,90,235,53,52,138,248,247,206,174,215,55,236,36,109,213,62,32,96,231,204,236,153,57,103,12,107,38,73,44,252,44,130,107,41,150,144,166,144,78,248,74,144,79,228,18,212,180,29,112,251,195,55,123,107,76,74,239,197,102,180,84,161,224,167,153,82,130,99,198,138,69,41,216,240,162,56,188,102,1,208,58,208,2,98,224,25,134,115,28,157,226,55,12,164,74,134,60,32,18,82,145,201,37,76,25,199,108,121,197,98,64,168,51,7,41,89,42,86,138,126,131,197,40,73,156,118,198,68,65,92,192,153,185,52,165,9,15,52,82,95,72,111,32,22,107,24,69,145,233,195,38,167,75,25,38,10,83,242,239,244,60,78,212,99,21,14,99,36,49,22,124,21,6,115,136,147,136,41,83,62,191,240,35,57,184,105,178,61,240,186,248,35,238,233,104,91,139,21,76,117,96,176,61,208,12,87,66,2,91,222,19,87,207,39,201,167,110,196,8,121,151,70,125,242,244,102,175,119,153,133,62,201,91,157,248,200,171,150,71,245,29,3,44,220,179,157,216,216,152,37,26,222,1,62,30,22,21,109,228,182,179,230,91,13,91,8,17,145,48,189,77,34,193,186,64,239,52,40,92,17,183,86,106,31,109,133,213,243,9,231,252,123,133,25,116,14,150,225,176,33,149,208,183,19,173,53,14,95,73,17,165,180,252,48,181,9,70,198,94,175,200,167,99,156,160,2,255,244,113,244,131,253,196,106,74,102,208,68,156,115,182,136,224,107,8,155,153,202,149,44,108,91,3,229,109,27,170,87,176,209,239,187,23,89,147,89,199,92,8,25,51,229,58,40,241,157,109,247,14,85,117,60,107,239,113,20,2,87,147,51,175,54,87,58,23,51,147,237,58,87,78,127,167,252,156,5,213,72,27,224,221,134,119,181,180,7,77,148,158,198,249,26,41,164,154,202,242,129,206,194,128,179,168,216,148,155,140,55,86,221,121,37,187,60,152,51,25,128,178,170,76,206,170,125,46,26,126,141,6,62,68,190,160,125,166,44,125,232,84,171,149,49,169,12,87,120,207,100,236,238,112,161,200,38,228,190,216,80,20,6,99,40,201,240,59,119,60,82,141,175,20,166,60,186,4,14,18,157,97,187,154,153,194,174,166,230,17,158,69,145,149,170,227,249,215,160,79,71,190,239,22,69,251,117,142,135,93,182,161,56,71,109,106,183,79,153,239,27,107,23,212,7,219,126,206,186,101,166,86,27,230,158,45,1,52,116,115,185,102,144,48,108,74,200,63,218,176,50,171,230,186,242,236,229,37,169,96,198,22,142,30,213,58,84,143,229,249,157,67,14,73,171,96,115,41,58,170,189,184,224,21,236,181,45,175,21,204,247,229,217,253,105,33,199,34,50,99,52,239,244,66,138,120,36,131,133,123,228,29,123,39,39,222,224,253,135,46,218,159,67,223,7,222,160,97,126,68,255,153,44,165,221,202,96,255,47,247,162,214,112,195,104,213,249,239,110,200,255,176,123,155,93,238,121,124,229,255,52,124,223,242,201,175,215,81,12,62,55,6,77,69,75,202,21,214,26,223,51,30,128,118,113,215,253,186,210,179,87,88,108,41,243,254,238,227,97,248,11,3,119,95,7,105,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModuleProcessesInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4755058d-8cc3-4f19-ae22-808a18a5a1b9"),
				Name = "GetModuleProcessesInfo",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, string, Guid, bool>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,91,107,219,48,20,126,78,161,255,65,243,67,81,192,248,7,44,77,71,154,110,33,144,150,130,147,245,97,236,65,181,143,83,49,89,50,186,116,100,99,255,125,186,185,190,5,90,48,54,62,151,239,114,142,244,74,36,34,77,179,38,197,11,160,37,58,40,144,107,193,57,20,154,10,158,229,160,148,253,250,108,246,68,245,203,78,20,132,185,95,202,143,120,159,219,210,138,30,141,36,190,218,151,29,52,101,84,83,80,217,147,144,191,84,67,10,240,241,141,20,166,153,47,46,47,94,29,163,135,87,107,193,88,96,178,212,19,52,81,215,130,119,112,27,208,57,184,242,59,162,9,190,188,152,13,181,166,31,1,184,23,165,97,176,10,236,1,45,125,179,127,6,97,104,40,246,249,168,115,162,180,180,99,64,5,105,92,220,154,49,53,127,32,53,124,204,204,174,248,211,181,224,177,153,36,63,169,190,218,196,134,214,129,40,105,167,40,65,25,166,45,27,135,223,104,71,149,190,222,155,134,193,245,198,208,50,69,65,93,138,194,223,179,16,236,230,6,187,86,23,136,27,216,150,157,141,16,137,28,195,178,220,26,174,201,193,87,59,160,182,187,38,71,120,180,42,128,107,112,185,74,72,176,195,65,184,219,49,162,124,186,237,57,250,107,247,71,43,132,157,114,71,132,67,205,143,68,181,182,183,101,242,51,219,139,220,139,195,243,57,90,46,81,222,37,3,196,172,181,17,135,112,30,106,21,139,134,128,139,174,63,154,182,32,177,119,178,210,126,103,175,241,109,48,93,171,163,125,148,162,176,55,39,100,29,175,19,127,119,251,96,24,203,190,19,102,0,125,241,82,179,175,117,163,79,232,243,89,237,19,144,137,120,55,192,177,142,79,203,62,242,213,213,248,70,15,80,239,9,183,27,148,217,55,202,203,173,134,250,246,100,33,198,144,115,171,157,91,229,113,226,179,66,112,77,185,1,47,225,159,123,185,109,55,1,119,203,43,17,119,241,206,89,196,237,234,210,225,201,75,199,103,46,69,21,97,10,130,229,112,228,179,85,89,226,30,163,207,89,41,246,145,160,141,228,241,106,44,254,3,221,37,204,159,222,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeDesignerModeButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("85f39fb9-2291-463b-976a-ccd7eb71d4fa"),
				Name = "InitializeDesignerModeButton",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,44,246,200,76,73,73,205,83,176,85,112,79,45,241,44,118,73,45,206,76,207,75,45,242,205,79,73,117,42,45,41,201,207,131,200,107,104,90,115,5,36,166,167,234,97,42,208,131,155,0,51,204,26,0,75,232,218,227,90,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsDesignerModeButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("88bd6d53-bce8-413f-87f0-777412a47037"),
				Name = "GetIsDesignerModeButtonHidden",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,146,207,142,130,48,16,198,207,154,248,14,149,131,105,47,188,128,241,176,40,107,56,248,39,113,245,222,192,136,77,96,32,211,178,46,217,248,238,219,2,155,5,92,15,28,58,253,190,153,143,223,84,27,82,152,178,146,84,46,169,14,209,40,83,159,226,27,228,242,28,37,108,197,142,50,5,127,11,230,40,73,230,96,128,46,50,171,128,123,48,84,122,130,73,205,116,211,108,57,155,110,43,149,176,145,196,150,213,149,241,86,227,71,122,95,101,217,129,194,188,52,53,255,127,188,16,236,123,54,157,124,74,250,205,183,145,70,158,138,138,98,176,209,248,223,73,52,49,91,163,255,174,48,113,231,117,129,134,138,44,168,247,54,57,239,43,142,227,110,78,33,108,192,137,186,242,167,81,157,139,173,86,12,109,102,225,50,77,8,76,69,200,12,85,224,124,15,251,193,19,188,87,173,252,22,199,131,65,166,161,249,199,103,47,194,157,57,140,175,216,56,255,108,234,216,244,189,14,75,95,41,206,26,200,130,64,136,141,42,208,239,223,237,36,90,38,212,240,138,12,228,65,109,251,242,81,18,225,71,168,141,196,24,186,253,13,166,205,91,36,108,177,24,164,176,219,221,4,23,5,247,118,129,67,86,93,106,13,113,69,214,17,98,170,208,173,115,148,116,19,156,6,10,235,236,250,204,135,86,247,58,215,18,195,47,91,53,112,40,129,164,107,192,61,91,92,223,36,166,240,86,150,153,138,155,234,71,133,246,245,237,138,4,60,177,252,1,201,43,79,40,252,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsEntityChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9e19eba2-72ac-4c48-aef3-66abebfe8a44"),
				Name = "IsEntityChanged",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,76,46,201,44,75,13,202,47,247,205,79,201,76,203,76,77,177,6,0,222,22,119,253,41,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDoPagingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("44f08930-c52c-488e-acf1-973fb8036218"),
				Name = "DoPaging",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f1bdefc9-35d2-44e5-8f11-d138de249a28"),
				Name = "pageRowsCount",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("265e3f7d-2620-4d2e-9acb-4c1662841515"),
				Name = "pageableDirection",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "PageableSelectDirection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,219,110,218,64,16,125,142,191,98,203,147,173,34,43,125,166,84,74,13,141,144,128,210,144,52,15,81,84,109,240,144,108,98,239,58,123,33,65,85,254,189,51,187,14,152,24,170,170,202,3,23,207,158,157,57,103,110,158,241,91,72,103,26,86,66,57,243,213,89,171,100,58,148,252,166,128,156,245,153,213,14,122,209,140,48,83,120,182,7,206,163,21,215,44,55,248,236,145,3,110,249,92,57,189,192,163,83,39,114,166,138,124,166,69,201,245,58,83,133,43,229,79,94,56,64,116,110,210,147,133,21,43,56,83,79,105,27,209,139,16,144,241,197,29,140,44,148,83,94,210,157,185,213,66,222,166,195,178,178,235,94,29,248,12,30,29,24,139,167,18,158,216,54,124,109,143,19,239,137,184,97,32,147,41,39,9,91,53,159,9,81,195,61,144,4,14,132,6,164,167,100,13,222,177,53,47,120,182,230,170,51,202,59,215,255,34,203,235,114,90,131,180,40,199,45,172,211,144,126,19,133,5,141,7,5,112,77,148,71,82,216,173,150,13,144,142,162,165,210,128,137,137,73,255,194,187,102,66,178,125,110,67,96,147,176,223,209,145,88,198,1,156,126,215,57,232,173,190,15,125,182,107,73,167,74,130,191,67,151,118,4,157,130,61,95,87,144,55,20,125,86,55,247,120,239,203,171,247,129,48,85,193,107,205,84,183,36,61,87,161,112,113,194,250,125,102,26,69,12,81,142,90,217,60,228,171,149,225,255,34,212,195,152,47,248,129,194,0,254,252,149,194,187,71,125,137,94,162,177,90,60,156,220,243,231,225,10,203,101,226,248,28,180,230,70,45,109,122,49,74,47,225,38,83,210,106,85,152,198,255,196,79,215,132,11,89,27,198,124,173,156,237,178,37,71,21,73,232,171,177,226,57,117,117,188,81,131,7,161,134,100,78,67,247,99,193,143,125,226,209,60,7,155,21,2,89,108,196,189,130,175,142,175,137,114,235,54,86,240,83,40,91,189,9,144,24,214,51,108,7,67,13,74,18,25,229,150,80,161,218,172,106,78,66,61,205,20,30,231,187,228,187,115,226,83,222,243,236,14,206,201,73,158,19,173,12,7,193,66,48,94,10,123,55,227,26,239,18,34,14,198,76,149,21,215,194,40,73,245,74,135,143,142,23,93,164,222,162,211,101,67,105,133,93,183,39,54,33,69,126,212,222,44,35,95,144,32,192,91,62,178,206,175,14,126,31,114,212,24,3,244,248,102,89,182,86,221,78,52,196,7,175,33,220,15,7,122,29,118,197,0,150,254,102,236,253,93,24,146,44,101,152,227,238,174,147,36,228,116,211,35,245,243,158,14,216,187,178,19,79,98,127,197,223,183,163,233,189,130,78,15,229,177,253,166,217,78,230,190,133,91,215,73,139,202,78,184,196,7,77,237,19,12,113,103,10,144,83,74,54,61,134,238,253,72,245,58,200,97,194,31,32,227,21,101,19,117,254,1,111,2,203,217,47,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRegisterButtonsScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a5665a01-f7e4-48bc-af19-ee8c0da61a59"),
				Name = "RegisterButtonsScript",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,205,110,26,49,16,62,19,169,239,224,112,8,139,180,177,210,67,47,160,72,77,33,169,82,53,41,10,81,122,168,170,202,217,29,192,141,177,169,237,5,210,8,169,82,31,162,175,17,169,135,74,125,10,242,70,29,175,205,66,128,132,180,234,30,96,215,158,239,155,111,126,60,110,177,46,208,118,162,249,192,158,48,137,31,154,30,164,169,95,136,94,150,159,109,13,153,38,166,167,70,103,144,40,157,146,125,210,201,100,98,185,146,145,1,153,130,142,9,84,201,205,179,173,146,51,228,230,130,9,238,172,172,206,160,142,171,188,67,162,237,195,177,165,71,74,247,243,77,102,149,166,67,255,6,81,213,131,75,115,100,135,9,147,67,39,57,60,218,30,113,153,170,17,133,148,219,22,10,108,105,149,36,96,204,177,52,150,201,4,142,211,64,161,193,102,90,6,100,16,100,89,23,41,189,82,138,31,133,36,124,71,24,9,24,146,35,8,62,14,36,1,210,54,27,2,34,35,231,177,161,164,101,92,130,254,212,100,150,181,85,166,19,160,12,147,48,132,51,20,214,87,41,239,112,72,49,128,12,12,217,222,39,50,19,162,90,207,69,184,0,78,145,239,173,98,105,27,147,146,160,191,144,176,92,160,1,205,49,240,175,48,223,69,183,111,218,239,78,169,177,154,203,46,239,92,71,185,117,105,38,171,86,8,140,243,245,144,186,218,44,251,110,113,82,205,243,64,0,115,25,18,236,162,14,169,28,48,13,210,190,214,60,157,7,180,44,46,87,135,134,172,111,80,144,171,96,166,69,19,155,32,133,40,208,8,149,48,215,9,212,0,211,73,143,154,236,210,107,142,158,87,115,255,158,196,106,0,231,235,216,85,55,48,238,236,132,55,58,223,245,136,167,72,68,158,96,166,6,128,117,249,48,39,249,72,211,121,141,204,12,144,83,251,174,152,197,133,236,107,248,30,117,91,95,32,208,224,76,239,21,205,229,136,13,6,2,235,53,137,151,93,248,124,164,32,192,194,42,154,126,201,120,114,117,193,97,212,80,34,235,75,179,224,170,195,133,5,237,138,176,10,11,123,20,100,94,23,239,228,126,91,29,21,240,165,166,10,216,13,194,130,85,65,156,120,125,107,213,36,133,246,101,17,141,2,181,36,34,64,54,136,120,152,184,176,105,247,152,16,106,180,234,97,133,173,90,47,205,147,251,23,199,47,136,168,173,134,229,143,97,200,84,109,53,247,126,191,104,198,218,35,250,227,127,57,233,36,12,203,149,57,179,56,77,207,65,107,102,84,199,210,131,207,108,124,2,182,167,82,67,207,123,90,141,26,130,99,171,30,14,241,231,61,183,189,150,59,152,224,132,71,15,207,220,216,141,214,120,93,36,49,201,181,150,110,252,64,93,122,192,121,57,97,230,170,70,214,27,20,143,187,116,188,161,187,75,226,13,198,150,105,219,4,193,174,107,228,197,222,222,6,235,14,183,231,234,80,64,31,181,212,124,138,54,32,184,105,94,75,214,231,73,75,25,238,102,222,147,84,245,77,183,33,176,35,42,227,221,62,70,178,43,176,56,216,83,228,18,47,138,202,102,44,2,167,63,166,183,211,159,119,223,238,190,79,127,77,127,79,111,43,107,65,147,133,213,124,206,185,243,132,127,101,127,9,181,30,187,227,203,55,123,19,138,183,121,37,17,56,130,42,241,194,101,143,53,238,113,60,155,229,152,228,20,167,48,182,175,50,107,113,226,251,150,57,110,58,7,255,139,190,165,97,200,85,102,86,92,252,1,126,99,105,177,164,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitDataSourceStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("25d5c491-d400-4cbf-8eaf-78299bddb344"),
				Name = "InitDataSourceStructure",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,193,78,27,49,16,61,7,137,127,112,115,242,74,145,243,1,33,72,52,129,10,212,38,81,129,222,205,238,36,152,58,118,100,123,105,211,138,127,239,120,189,222,93,111,32,208,28,54,178,253,102,222,155,25,63,175,184,1,229,190,24,81,220,58,83,230,174,52,64,166,68,193,47,50,23,185,19,90,113,179,63,179,206,8,181,25,17,253,240,4,185,59,167,217,228,244,228,153,27,82,112,199,111,117,105,114,31,179,226,27,96,243,102,7,33,131,128,178,96,4,151,226,15,120,10,204,131,216,22,118,37,164,3,99,217,157,14,135,152,27,195,66,224,147,213,106,166,213,51,24,132,68,85,253,200,155,46,136,222,35,25,174,20,84,218,71,29,133,217,95,20,180,50,240,140,229,126,135,141,176,8,71,190,153,20,184,113,155,27,177,115,72,129,61,128,211,147,151,186,190,117,160,192,253,14,11,155,67,83,209,178,106,200,89,95,212,76,75,25,20,156,83,100,173,126,253,46,140,210,242,124,75,197,154,208,72,249,9,203,45,165,204,136,151,237,181,192,111,148,140,113,125,6,20,215,22,201,102,165,241,243,108,102,201,98,127,175,132,42,62,239,23,124,11,145,130,249,69,70,184,61,232,105,155,220,15,209,171,122,147,60,202,244,42,7,111,161,216,76,2,55,213,173,25,12,58,125,77,138,136,133,191,171,103,176,214,6,120,254,72,104,155,234,218,193,150,8,117,152,56,244,239,136,180,139,162,160,109,142,32,241,229,104,49,95,245,70,228,92,46,119,96,120,170,253,224,104,114,52,209,181,189,84,252,65,66,209,201,208,236,189,23,186,208,46,9,195,181,15,241,210,65,90,8,101,127,228,98,180,13,176,89,157,225,37,26,208,70,244,43,198,109,51,117,172,219,119,238,129,105,155,40,44,166,220,170,15,155,183,202,60,30,39,162,254,195,150,61,218,212,159,227,113,237,208,180,218,214,160,109,93,2,239,136,189,48,134,239,107,242,46,43,237,37,168,188,117,83,161,107,115,119,195,187,254,54,128,81,254,182,96,231,195,91,75,172,54,46,136,93,113,247,136,108,97,159,93,110,119,206,167,107,76,112,115,167,127,130,34,174,250,162,5,90,14,54,123,20,178,192,169,211,44,208,8,229,136,54,5,152,149,182,162,190,186,85,28,251,193,101,9,103,120,126,78,135,9,98,88,221,137,165,223,154,11,83,155,85,167,203,233,128,166,128,236,82,149,91,182,226,198,2,117,251,29,232,117,31,48,74,120,67,105,145,186,65,13,179,108,66,144,189,238,200,22,28,175,123,241,106,112,60,15,146,223,156,61,201,195,223,241,103,51,96,227,179,249,173,78,77,35,71,22,30,70,90,231,74,30,107,191,223,235,16,158,167,13,96,11,173,32,190,77,7,163,142,44,237,99,20,120,88,111,14,211,222,36,38,125,104,103,206,201,84,163,207,255,1,23,227,147,236,253,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitStructureStoreMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cae4d6de-932c-4bd2-a3f3-d39c0c6da416"),
				Name = "InitStructureStore",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5acd927e-fd50-494f-850a-fc33db48f52b"),
				Name = "args",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,93,75,195,48,20,125,78,97,255,33,244,97,36,32,25,250,58,59,144,78,71,17,170,88,245,69,246,144,165,183,93,180,75,36,73,55,134,248,223,77,218,58,63,246,48,72,8,201,61,247,156,115,15,145,21,38,214,25,169,106,150,217,188,109,154,59,115,189,121,119,123,82,56,211,10,215,26,40,156,54,112,11,123,74,241,199,40,66,71,239,56,193,139,86,150,44,135,93,56,9,101,143,186,232,24,9,157,142,162,207,81,52,138,182,220,224,82,10,15,37,217,92,10,39,181,226,102,127,217,11,159,97,189,122,5,225,102,148,155,218,78,3,94,86,132,156,68,82,150,234,86,57,60,195,23,189,181,201,228,201,130,73,181,82,208,53,178,2,172,245,231,156,59,254,114,228,123,233,221,12,130,40,32,10,221,26,1,55,178,113,96,172,175,121,191,47,113,213,95,227,229,95,212,129,236,27,39,116,211,110,84,192,225,110,228,28,160,44,248,54,212,201,74,235,134,118,40,53,188,118,116,153,125,230,141,44,239,121,253,15,37,251,66,7,234,163,3,229,164,11,65,7,48,251,177,193,174,252,156,91,120,208,187,105,151,217,65,117,60,30,122,216,2,92,186,230,170,134,50,237,44,122,234,22,44,25,178,35,52,73,206,251,240,42,159,10,23,107,18,244,250,105,176,84,167,88,124,171,159,23,33,175,221,247,176,156,111,252,56,9,142,179,50,166,40,16,35,244,43,140,138,55,22,66,150,200,135,20,182,95,233,26,196,155,255,124,218,129,29,84,252,207,249,2,204,132,228,205,153,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEnabledPagingButtonsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8082b4fc-6963-46f2-a8f7-b408c5af2da2"),
				Name = "EnabledPagingButtons",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,208,8,72,76,79,77,76,202,73,13,78,205,73,77,46,113,201,44,2,146,153,249,121,154,48,113,184,136,130,173,173,2,14,197,122,126,169,21,37,154,10,213,92,156,32,5,96,158,83,105,73,9,80,194,53,15,164,60,69,193,86,33,45,49,167,56,213,154,171,150,43,147,90,150,6,20,101,230,23,33,108,13,40,74,45,203,204,47,45,198,105,51,0,65,97,10,177,238,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLockAjaxEventsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9af09c8f-a103-4824-92c1-10c43def161b"),
				Name = "LockAjaxEvents",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bda6fe62-2498-498d-9af6-f00b846f533e"),
				Name = "Control",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.UI.WebControls.WebControl",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1d23a8a6-f238-46ae-b68d-5bb81f1706ab"),
				Name = "enableAjax",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,77,107,2,49,16,61,71,240,63,140,183,21,75,240,110,83,16,241,32,20,10,253,192,131,244,144,213,17,163,105,82,50,187,171,80,252,239,230,67,118,99,145,210,75,230,227,205,155,247,38,202,84,176,182,166,114,86,211,204,214,190,18,48,75,53,191,70,226,17,152,244,123,106,11,197,237,240,19,140,135,240,211,239,49,229,11,101,54,120,242,252,177,31,101,199,157,210,8,69,234,61,222,106,36,10,123,71,231,36,217,109,197,63,22,124,137,101,171,215,229,112,236,82,1,129,196,126,187,91,69,137,79,144,4,255,88,24,172,177,112,71,182,120,32,192,212,90,95,93,177,70,58,176,37,161,107,100,233,79,16,185,135,191,68,218,228,165,37,71,53,47,87,100,251,6,34,23,11,32,154,0,76,247,242,212,118,89,71,224,175,72,245,87,132,231,13,154,138,138,97,90,203,206,168,9,239,49,222,106,250,70,179,185,71,73,225,217,174,15,25,218,29,248,0,153,153,196,137,148,248,196,143,30,141,66,219,215,231,11,96,69,27,204,59,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitPagingButtonsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9987bd9a-65dc-471b-a906-8f8d0d7d2c79"),
				Name = "InitPagingButtons",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,77,111,19,49,16,61,39,82,254,131,181,151,218,162,178,196,57,180,82,137,82,88,68,67,96,91,56,27,123,154,90,108,198,193,31,73,86,148,255,206,120,63,210,18,69,234,165,62,88,182,223,155,55,51,111,188,85,158,217,80,61,184,221,82,173,44,174,222,167,24,29,6,118,193,248,79,231,106,81,53,161,130,24,9,9,242,3,196,239,170,78,192,239,2,248,153,67,4,29,173,195,115,86,228,248,185,177,145,52,96,161,182,118,165,50,208,107,21,98,58,25,219,123,126,34,141,96,127,38,227,81,142,146,149,246,118,19,111,20,210,197,203,43,99,186,7,94,236,44,26,183,147,208,203,47,189,211,26,66,40,49,68,133,26,74,67,181,158,21,236,13,107,101,50,76,168,28,224,187,210,200,91,87,69,79,73,185,32,86,113,54,109,11,122,33,235,150,124,89,0,152,207,78,25,138,78,58,38,15,148,137,142,208,11,124,131,149,13,17,124,223,75,31,153,161,191,12,234,0,79,189,45,61,108,173,75,161,99,202,143,214,24,192,65,108,32,45,96,31,79,18,70,36,56,25,79,198,185,164,0,53,153,78,8,194,142,85,237,229,104,26,130,244,104,201,153,171,211,26,249,117,66,77,231,132,145,119,47,242,42,215,108,195,47,46,196,192,189,246,110,205,11,26,245,141,51,169,134,98,120,255,228,44,242,188,221,54,27,32,75,17,124,30,246,192,203,19,63,112,191,32,63,66,254,163,98,180,177,41,77,33,100,25,230,191,147,170,159,231,59,205,36,97,246,108,201,31,15,224,129,231,198,191,38,240,77,215,206,124,191,241,52,111,106,252,72,48,43,60,37,59,68,45,149,87,107,32,7,248,129,93,26,33,84,232,221,156,14,78,235,236,25,187,24,117,142,203,249,30,116,138,80,105,85,43,255,206,98,188,108,39,221,126,236,50,44,72,254,241,145,149,97,230,54,77,62,117,209,151,236,173,120,205,95,240,15,255,4,20,221,173,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckIsNotesChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b36f633e-e394-4c91-8951-2f0fef30ac6d"),
				Name = "CheckIsNotesChanged",
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,143,65,139,194,64,12,133,207,10,251,31,98,79,157,203,224,221,85,88,84,180,23,41,90,246,34,30,178,54,234,64,155,145,153,180,42,139,255,221,153,210,21,246,150,144,188,239,189,103,78,144,110,172,144,47,240,39,227,146,238,48,154,194,88,193,239,199,112,208,162,131,139,212,213,178,52,2,83,72,115,60,147,94,160,96,248,205,145,169,210,97,240,251,127,242,131,206,132,106,191,31,31,0,61,68,197,220,178,160,97,114,74,199,53,99,47,200,71,210,43,146,220,217,43,57,121,124,99,213,80,154,116,160,104,150,168,40,94,247,214,147,62,10,199,115,200,241,142,177,179,141,11,160,175,163,152,150,182,246,22,145,197,227,74,229,220,86,77,205,29,245,211,139,51,124,158,245,244,68,69,154,9,165,255,138,233,130,238,18,75,119,120,21,174,131,13,81,185,195,150,130,151,184,134,130,226,249,2,61,227,13,200,39,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseModuleEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"));
		}

		#endregion

	}

	#endregion

}

