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
	using System.Threading;
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
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: BaseGridPageSchema

	/// <exclude/>
	public class BaseGridPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

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

		private Terrasoft.UI.WebControls.Controls.Button _copyButton;
		public Terrasoft.UI.WebControls.Controls.Button CopyButton {
			get {
				return _copyButton;
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

		private Terrasoft.UI.WebControls.Controls.Spacer _spacerPrintButton;
		public Terrasoft.UI.WebControls.Controls.Spacer SpacerPrintButton {
			get {
				return _spacerPrintButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _actionButton;
		public Terrasoft.UI.WebControls.Controls.Button ActionButton {
			get {
				return _actionButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _printButton;
		public Terrasoft.UI.WebControls.Controls.Button PrintButton {
			get {
				return _printButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _treeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid TreeGrid {
			get {
				return _treeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _sendEmailMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem SendEmailMenuItem {
			get {
				return _sendEmailMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _sendTemplateEmailMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem SendTemplateEmailMenuItem {
			get {
				return _sendTemplateEmailMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _callMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem CallMenuItem {
			get {
				return _callMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _showChangelogMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem ShowChangelogMenuItem {
			get {
				return _showChangelogMenuItem;
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

		public BaseGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseGridPageSchema(BaseGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			RealUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			Name = "BaseGridPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateButtonsControlLayout());
			ButtonsControlLayout.InsertItem(0, CreateAddButton());
			ButtonsControlLayout.InsertItem(1, CreateCopyButton());
			ButtonsControlLayout.InsertItem(2, CreateEditButton());
			ButtonsControlLayout.InsertItem(3, CreateDeleteButton());
			ButtonsControlLayout.InsertItem(4, CreateSpacerPrintButton());
			ButtonsControlLayout.InsertItem(5, CreateActionButton());
			ButtonsControlLayout.InsertItem(6, CreatePrintButton());
			ButtonsControlLayout.InsertItem(7, CreateContextHelpButton());
			Controls.AddAt(1, CreateTreeGrid());
			TreeGrid.InsertItem(0, CreateSendEmailMenuItem());
			TreeGrid.InsertItem(1, CreateSendTemplateEmailMenuItem());
			TreeGrid.InsertItem(2, CreateCallMenuItem());
			TreeGrid.InsertItem(3, CreateShowChangelogMenuItem());
			Controls.AddAt(2, CreateDataSource());
			UpdateDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseGridPageEventsProcessSchema() {
			var schema = new BaseGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddButton() {
			_addButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addButton.UId = new Guid("fa246055-9547-47c8-a69c-7c16df13ba33");
			_addButton.Name = "AddButton";
			_addButton.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_addButton.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_addButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addButton.Tag = "";
			_addButton.Image = new ControlImage {};
			_addButton.ImageAsSprite = false;
			_addButton.Enabled = false;
			return _addButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCopyButton() {
			_copyButton = new Terrasoft.UI.WebControls.Controls.Button();
			_copyButton.UId = new Guid("df6b91b4-9e51-4dfc-8a7c-7c9f3d72d235");
			_copyButton.Name = "CopyButton";
			_copyButton.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_copyButton.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_copyButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_copyButton.Tag = "";
			_copyButton.Image = new ControlImage {};
			_copyButton.ImageAsSprite = false;
			_copyButton.Enabled = false;
			return _copyButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateEditButton() {
			_editButton = new Terrasoft.UI.WebControls.Controls.Button();
			_editButton.UId = new Guid("889c7cac-5802-42f7-9f2d-87da51065888");
			_editButton.Name = "EditButton";
			_editButton.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_editButton.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_editButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_editButton.Tag = "";
			_editButton.Image = new ControlImage {};
			_editButton.ImageAsSprite = false;
			_editButton.Enabled = false;
			return _editButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteButton() {
			_deleteButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteButton.UId = new Guid("5899ec09-b88b-40a4-9446-66cbf5092c26");
			_deleteButton.Name = "DeleteButton";
			_deleteButton.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_deleteButton.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_deleteButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_deleteButton.Tag = "";
			_deleteButton.Image = new ControlImage {};
			_deleteButton.ImageAsSprite = false;
			_deleteButton.Enabled = false;
			return _deleteButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacerPrintButton() {
			_spacerPrintButton = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacerPrintButton.UId = new Guid("2edb0f3c-d2b0-4913-a626-4ab589d40e0e");
			_spacerPrintButton.Name = "SpacerPrintButton";
			_spacerPrintButton.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_spacerPrintButton.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_spacerPrintButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacerPrintButton.Tag = "";
			_spacerPrintButton.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacerPrintButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateActionButton() {
			_actionButton = new Terrasoft.UI.WebControls.Controls.Button();
			_actionButton.UId = new Guid("539c9a35-4707-41af-8fd0-ea6561e45289");
			_actionButton.Name = "ActionButton";
			_actionButton.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_actionButton.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_actionButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_actionButton.Tag = "";
			_actionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			_actionButton.Hidden = true;
			return _actionButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreatePrintButton() {
			_printButton = new Terrasoft.UI.WebControls.Controls.Button();
			_printButton.UId = new Guid("f1ddd7c8-e4f0-4752-8a6b-03a091dc9893");
			_printButton.Name = "PrintButton";
			_printButton.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_printButton.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_printButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_printButton.Tag = "";
			_printButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			_printButton.Hidden = true;
			return _printButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("4b568517-b406-4dcc-aa6e-dd549f3d2d4c");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonsControlLayout() {
			_buttonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonsControlLayout.UId = new Guid("83b25d52-de0c-4746-ab7d-2f05b4d252de");
			_buttonsControlLayout.Name = "ButtonsControlLayout";
			_buttonsControlLayout.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_buttonsControlLayout.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_buttonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttonsControlLayout.Tag = "";
			_buttonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_buttonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonsControlLayout.StartNewAlignGroup = false;
			_buttonsControlLayout.Image = new ControlImage {};
			_buttonsControlLayout.Edges = "0 0 1 0";
			return _buttonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateSendEmailMenuItem() {
			_sendEmailMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_sendEmailMenuItem.UId = new Guid("a933c65c-de45-4a16-b077-2719c84c06af");
			_sendEmailMenuItem.Name = "SendEmailMenuItem";
			_sendEmailMenuItem.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_sendEmailMenuItem.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_sendEmailMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sendEmailMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sendEmailMenuItem.Image = new ControlImage {};
			_sendEmailMenuItem.Tag = "";
			_sendEmailMenuItem.Enabled = false;
			_sendEmailMenuItem.Hidden = true;
			return _sendEmailMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateSendTemplateEmailMenuItem() {
			_sendTemplateEmailMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_sendTemplateEmailMenuItem.UId = new Guid("6ddb1d39-067a-4d4b-abde-277898b92ff4");
			_sendTemplateEmailMenuItem.Name = "SendTemplateEmailMenuItem";
			_sendTemplateEmailMenuItem.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_sendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_sendTemplateEmailMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sendTemplateEmailMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sendTemplateEmailMenuItem.Image = new ControlImage {};
			_sendTemplateEmailMenuItem.Tag = "";
			_sendTemplateEmailMenuItem.Enabled = false;
			_sendTemplateEmailMenuItem.Hidden = true;
			return _sendTemplateEmailMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateCallMenuItem() {
			_callMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_callMenuItem.UId = new Guid("df35c555-cacd-4d5d-ac9e-6b0fb63fa4db");
			_callMenuItem.Name = "CallMenuItem";
			_callMenuItem.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_callMenuItem.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_callMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_callMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			_callMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_callMenuItem.Image = new ControlImage {};
			_callMenuItem.Tag = "";
			return _callMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateShowChangelogMenuItem() {
			_showChangelogMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_showChangelogMenuItem.UId = new Guid("b3a89bcc-81cd-454e-bf87-1fc1ec23ec11");
			_showChangelogMenuItem.Name = "ShowChangelogMenuItem";
			_showChangelogMenuItem.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_showChangelogMenuItem.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_showChangelogMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_showChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_showChangelogMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showChangelogMenuItem.Image = new ControlImage {};
			_showChangelogMenuItem.Tag = "";
			_showChangelogMenuItem.Hidden = true;
			return _showChangelogMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateTreeGrid() {
			_treeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_treeGrid.UId = new Guid("a1f5fa11-d3e1-4f2a-94f2-0dc1800bdf53");
			_treeGrid.Name = "TreeGrid";
			_treeGrid.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_treeGrid.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_treeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_treeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			_treeGrid.Tag = "";
			_treeGrid.DataSourceId = "DataSource";
			_treeGrid.Edges = "";
			_treeGrid.IsColumnAutowidth = true;
			_treeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_treeGrid.IsSummaryVisible = false;
			_treeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_treeGrid.EnableDragDrop = true;
			_treeGrid.HideHeaders = false;
			return _treeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateDataSource() {
			_dataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_dataSource.UId = new Guid("f1bf72e1-90c4-488b-9a66-b38c39e4960a");
			_dataSource.Name = "DataSource";
			_dataSource.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_dataSource.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_dataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataSource.Tag = "";
			_dataSource.EnableServerActiveRow = false;
			_dataSource.SchemaUId = Guid.Empty;
			_dataSource.HierarchicalDepth = 1;
			_dataSource.DefStructure.ID = "c" + _dataSource.DefStructure.UId.ToString("N");
			_dataSource.DefStructure.UId = new Guid("52d1fd45-32ff-4b48-bc1f-6355f9afb3ca");
			_dataSource.DefStructure.Name = "DefStructure";
			_dataSource.DefStructure.CreatedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			_dataSource.DefStructure.ModifiedInSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
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
			return new BaseGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseGridPageEventsProcess

	/// <exclude/>
	public class BaseGridPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Class: OpenEmailEditPage_BaseGridPage_UserTaskFlowElement

		/// <exclude/>
		public class OpenEmailEditPage_BaseGridPage_UserTaskFlowElement : OpenPageUserTask
		{

			public OpenEmailEditPage_BaseGridPage_UserTaskFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEmailEditPage_BaseGridPage_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ViewRecordAllChangesProcessFlowElement

		/// <exclude/>
		public class ViewRecordAllChangesProcessFlowElement : ViewRecordAllChangesProcess
		{

			public ViewRecordAllChangesProcessFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessFlowElement";
				Name = "ViewRecordAllChangesProcess";
				SerializeToDB = false;
				IsLogging = false;
				SchemaElementUId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowNoPhoneNumbersUserTaskFlowElement

		/// <exclude/>
		public class ShowNoPhoneNumbersUserTaskFlowElement : QuestionUserTask
		{

			public ShowNoPhoneNumbersUserTaskFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowNoPhoneNumbersUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenSelectNumberUserTaskFlowElement

		/// <exclude/>
		public class OpenSelectNumberUserTaskFlowElement : OpenPageUserTask
		{

			public OpenSelectNumberUserTaskFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenSelectNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: LoadPrintReportButtonMenuProcessFlowElement

		/// <exclude/>
		public class LoadPrintReportButtonMenuProcessFlowElement : LoadPrintMenuProcess
		{

			public LoadPrintReportButtonMenuProcessFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessFlowElement";
				Name = "LoadPrintReportButtonMenuProcess";
				SerializeToDB = false;
				IsLogging = false;
				SchemaElementUId = new Guid("cde71fb5-e60e-4225-a880-ab81c127d7d7");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskAddOpenWindowFlowElement

		/// <exclude/>
		public class UserTaskAddOpenWindowFlowElement : OpenPageUserTask
		{

			public UserTaskAddOpenWindowFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskAddOpenWindow";
				IsLogging = false;
				SchemaElementUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskEditOpenWindowFlowElement

		/// <exclude/>
		public class UserTaskEditOpenWindowFlowElement : OpenPageUserTask
		{

			public UserTaskEditOpenWindowFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskEditOpenWindow";
				IsLogging = false;
				SchemaElementUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserMessageFlowElement

		/// <exclude/>
		public class UserMessageFlowElement : QuestionUserTask
		{

			public UserMessageFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskOpenCopyEditPageFlowElement

		/// <exclude/>
		public class UserTaskOpenCopyEditPageFlowElement : OpenPageUserTask
		{

			public UserTaskOpenCopyEditPageFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskOpenCopyEditPage";
				IsLogging = false;
				SchemaElementUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskPrintOpenWindowFlowElement

		/// <exclude/>
		public class UserTaskPrintOpenWindowFlowElement : OpenPageUserTask
		{

			public UserTaskPrintOpenWindowFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskPrintOpenWindow";
				IsLogging = false;
				SchemaElementUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowMSWordReportCreatedUserTaskFlowElement

		/// <exclude/>
		public class ShowMSWordReportCreatedUserTaskFlowElement : QuestionUserTask
		{

			public ShowMSWordReportCreatedUserTaskFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowMSWordReportCreatedUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenProcessEditUserTaskFlowElement

		/// <exclude/>
		public class OpenProcessEditUserTaskFlowElement : OpenPageUserTask
		{

			public OpenProcessEditUserTaskFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenProcessEditUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: MessageWindowUserTaskFlowElement

		/// <exclude/>
		public class MessageWindowUserTaskFlowElement : QuestionUserTask
		{

			public MessageWindowUserTaskFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "MessageWindowUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: CreateNewSysModuleReportMenuItemClickUserTaskFlowElement

		/// <exclude/>
		public class CreateNewSysModuleReportMenuItemClickUserTaskFlowElement : OpenPageUserTask
		{

			public CreateNewSysModuleReportMenuItemClickUserTaskFlowElement(UserConnection userConnection, BaseGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CreateNewSysModuleReportMenuItemClickUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf");
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

		public BaseGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseGridPageEventsProcess";
			SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
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

		public virtual Object DataSourceFilter {
			get;
			set;
		}

		public virtual Object ListenerPage {
			get;
			set;
		}

		public virtual Object FilterLeftExpression {
			get;
			set;
		}

		public virtual string ParentFieldName {
			get;
			set;
		}

		public virtual Guid SysModuleDetailId {
			get;
			set;
		}

		public virtual Guid SelectedNodePrimaryColumnValue {
			get;
			set;
		}

		public virtual Guid SysEntitySchemaId {
			get;
			set;
		}

		public virtual string EditPageQueryStringAddition {
			get;
			set;
		}

		public virtual Guid DefValuesId {
			get;
			set;
		}

		public virtual bool IsDetailGrid {
			get;
			set;
		}

		public virtual bool IsSearch {
			get;
			set;
		}

		public virtual bool DisableButtons {
			get;
			set;
		}

		public virtual Guid SelectedFolderId {
			get;
			set;
		}

		public virtual Object DataSourceLoadingEventArgs {
			get;
			set;
		}

		public virtual string CurrentGridSchemaName {
			get;
			set;
		}

		public virtual bool NeedAddDetailRequest {
			get;
			set;
		}

		public virtual Guid SysModuleId {
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

		public virtual string ParentColumnMetaPath {
			get;
			set;
		}

		public virtual bool DefaultWay {
			get;
			set;
		}

		public virtual string ListenerPageProcessUId {
			get;
			set;
		}

		public virtual bool AddToMenuItemMoveTo {
			get;
			set;
		}

		public virtual bool SynchronizeDataSourceStructure {
			get;
			set;
		}

		public virtual bool LocatedInEditPage {
			get;
			set;
		}

		public virtual Guid TypeColumnUId {
			get;
			set;
		}

		public virtual Object TypeEditPageUIds {
			get;
			set;
		}

		public virtual Guid SysModuleEditId {
			get;
			set;
		}

		public virtual bool UseModuleDetails {
			get;
			set;
		}

		public virtual bool IsContextHelpButtonInitialized {
			get;
			set;
		}

		public virtual string EditPageHelpContextId {
			get;
			set;
		}

		public virtual string PrintReportPageHelpContextId {
			get;
			set;
		}

		public virtual Guid SelectedTypeId {
			get;
			set;
		}

		public virtual bool IsPrimaryGrid {
			get;
			set;
		}

		public virtual bool IsModuleProcessesTuningMode {
			get;
			set;
		}

		public virtual Guid SysModuleProcessPrimaryColumnUId {
			get;
			set;
		}

		private string _menuHelpItemCaption;
		public virtual string MenuHelpItemCaption {
			get {
				return _menuHelpItemCaption ?? (_menuHelpItemCaption = new LocalizableString(Storage, "96384a2ccd4f4c29acda49d24ea3ef73",
						 "EventsProcessSchema.Parameters.MenuHelpItemCaption.Value"));
			}
			set {
				_menuHelpItemCaption = value;
			}
		}

		private string _menuVideoHelpItemCaption;
		public virtual string MenuVideoHelpItemCaption {
			get {
				return _menuVideoHelpItemCaption ?? (_menuVideoHelpItemCaption = new LocalizableString(Storage, "96384a2ccd4f4c29acda49d24ea3ef73",
						 "EventsProcessSchema.Parameters.MenuVideoHelpItemCaption.Value"));
			}
			set {
				_menuVideoHelpItemCaption = value;
			}
		}

		public virtual Guid MailboxSyncSettingsLinkId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1_BaseGridPage;
		public ProcessFlowElement EventSubProcess1_BaseGridPage {
			get {
				return _eventSubProcess1_BaseGridPage ?? (_eventSubProcess1_BaseGridPage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1_BaseGridPage",
					SchemaElementUId = new Guid("78551111-b367-4bd4-baf2-4929c65ade97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage;
		public ProcessFlowElement SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage {
			get {
				return _sendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage ?? (_sendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage",
					SchemaElementUId = new Guid("e1b1a918-e77e-4f37-aea7-5311fb514f72"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _createEmailCustomContextMenu_ScriptTask;
		public ProcessScriptTask CreateEmailCustomContextMenu_ScriptTask {
			get {
				return _createEmailCustomContextMenu_ScriptTask ?? (_createEmailCustomContextMenu_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateEmailCustomContextMenu_ScriptTask",
					SchemaElementUId = new Guid("cd1b6897-ae10-4a41-87b4-dbc850e72dba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateEmailCustomContextMenu_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8_BaseGridPage;
		public ProcessFlowElement EventSubProcess8_BaseGridPage {
			get {
				return _eventSubProcess8_BaseGridPage ?? (_eventSubProcess8_BaseGridPage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8_BaseGridPage",
					SchemaElementUId = new Guid("8637437e-9cc9-49f7-afee-3c7630bd4641"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _processEmailContextItemClick_StartMessage;
		public ProcessFlowElement ProcessEmailContextItemClick_StartMessage {
			get {
				return _processEmailContextItemClick_StartMessage ?? (_processEmailContextItemClick_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProcessEmailContextItemClick_StartMessage",
					SchemaElementUId = new Guid("8650c458-0155-4930-ba08-4d0915d902a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processEmailContextMenuClick_ScriptTask;
		public ProcessScriptTask ProcessEmailContextMenuClick_ScriptTask {
			get {
				return _processEmailContextMenuClick_ScriptTask ?? (_processEmailContextMenuClick_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessEmailContextMenuClick_ScriptTask",
					SchemaElementUId = new Guid("241dee9f-8625-4938-9c5f-b27f7a5d0e15"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessEmailContextMenuClick_ScriptTaskExecute,
				});
			}
		}

		private OpenEmailEditPage_BaseGridPage_UserTaskFlowElement _openEmailEditPage_BaseGridPage_UserTask;
		public OpenEmailEditPage_BaseGridPage_UserTaskFlowElement OpenEmailEditPage_BaseGridPage_UserTask {
			get {
				return _openEmailEditPage_BaseGridPage_UserTask ?? (_openEmailEditPage_BaseGridPage_UserTask = new OpenEmailEditPage_BaseGridPage_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess12539;
		public ProcessFlowElement EventSubProcess12539 {
			get {
				return _eventSubProcess12539 ?? (_eventSubProcess12539 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess12539",
					SchemaElementUId = new Guid("c0d62ae7-a85b-4bf7-b30d-d7ecec9dbc8e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ViewRecordAllChangesProcessFlowElement _viewRecordAllChangesProcess;
		public ViewRecordAllChangesProcessFlowElement ViewRecordAllChangesProcess {
			get {
				return _viewRecordAllChangesProcess ?? ((_viewRecordAllChangesProcess) = new ViewRecordAllChangesProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _showChangelogMenuItemClickScriptTask;
		public ProcessScriptTask ShowChangelogMenuItemClickScriptTask {
			get {
				return _showChangelogMenuItemClickScriptTask ?? (_showChangelogMenuItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowChangelogMenuItemClickScriptTask",
					SchemaElementUId = new Guid("ce64ed8c-06e3-4051-ae5e-a5e3bc8ef080"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowChangelogMenuItemClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _showChangelogMenuItemClickStartMessage;
		public ProcessFlowElement ShowChangelogMenuItemClickStartMessage {
			get {
				return _showChangelogMenuItemClickStartMessage ?? (_showChangelogMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ShowChangelogMenuItemClickStartMessage",
					SchemaElementUId = new Guid("1f519f5d-9c9a-49bb-9dd8-6d8d1af57530"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess1werwe;
		public ProcessFlowElement EventSubProcess1werwe {
			get {
				return _eventSubProcess1werwe ?? (_eventSubProcess1werwe = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1werwe",
					SchemaElementUId = new Guid("87abc823-8872-428e-a204-9985fcd9a64e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1ddrrg;
		public ProcessFlowElement StartMessage1ddrrg {
			get {
				return _startMessage1ddrrg ?? (_startMessage1ddrrg = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1ddrrg",
					SchemaElementUId = new Guid("c2569eb7-8256-4ff4-b311-8ce2d448f136"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _createCallCustomContextMenu_ScriptTask;
		public ProcessScriptTask CreateCallCustomContextMenu_ScriptTask {
			get {
				return _createCallCustomContextMenu_ScriptTask ?? (_createCallCustomContextMenu_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateCallCustomContextMenu_ScriptTask",
					SchemaElementUId = new Guid("98c735b7-c031-48a4-bb95-93271c373b7d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateCallCustomContextMenu_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess1bghhj;
		public ProcessFlowElement EventSubProcess1bghhj {
			get {
				return _eventSubProcess1bghhj ?? (_eventSubProcess1bghhj = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1bghhj",
					SchemaElementUId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _processCallContextItemClick_StartMessage;
		public ProcessFlowElement ProcessCallContextItemClick_StartMessage {
			get {
				return _processCallContextItemClick_StartMessage ?? (_processCallContextItemClick_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProcessCallContextItemClick_StartMessage",
					SchemaElementUId = new Guid("a0912c0b-46d8-4b3a-940b-1d4fac5e80e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processCallContextMenuItemClick_ScriptTask;
		public ProcessScriptTask ProcessCallContextMenuItemClick_ScriptTask {
			get {
				return _processCallContextMenuItemClick_ScriptTask ?? (_processCallContextMenuItemClick_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessCallContextMenuItemClick_ScriptTask",
					SchemaElementUId = new Guid("e8a5615a-b40a-44c0-b275-c8a9a57f7992"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessCallContextMenuItemClick_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _numberSelectedMessage;
		public ProcessFlowElement NumberSelectedMessage {
			get {
				return _numberSelectedMessage ?? (_numberSelectedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "NumberSelectedMessage",
					SchemaElementUId = new Guid("da949a79-83d6-450c-b6e7-d738b148df2e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3wwwcc;
		public ProcessExclusiveGateway ExclusiveGateway3wwwcc {
			get {
				return _exclusiveGateway3wwwcc ?? (_exclusiveGateway3wwwcc = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3wwwcc",
					SchemaElementUId = new Guid("9f6e9db4-a8d4-47de-97be-e9d0e8074803"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway3wwwcc.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _notifyCtiPanelCallMessage_ScriptTask;
		public ProcessScriptTask NotifyCtiPanelCallMessage_ScriptTask {
			get {
				return _notifyCtiPanelCallMessage_ScriptTask ?? (_notifyCtiPanelCallMessage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NotifyCtiPanelCallMessage_ScriptTask",
					SchemaElementUId = new Guid("ce372dfc-2331-4855-9ed8-72941ae1d9d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NotifyCtiPanelCallMessage_ScriptTaskExecute,
				});
			}
		}

		private ShowNoPhoneNumbersUserTaskFlowElement _showNoPhoneNumbersUserTask;
		public ShowNoPhoneNumbersUserTaskFlowElement ShowNoPhoneNumbersUserTask {
			get {
				return _showNoPhoneNumbersUserTask ?? (_showNoPhoneNumbersUserTask = new ShowNoPhoneNumbersUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _processCallContextMenuItemClick_ScriptTask3;
		public ProcessScriptTask ProcessCallContextMenuItemClick_ScriptTask3 {
			get {
				return _processCallContextMenuItemClick_ScriptTask3 ?? (_processCallContextMenuItemClick_ScriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessCallContextMenuItemClick_ScriptTask3",
					SchemaElementUId = new Guid("11411a79-6972-4c80-b471-3f1f5a773311"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessCallContextMenuItemClick_ScriptTask3Execute,
				});
			}
		}

		private OpenSelectNumberUserTaskFlowElement _openSelectNumberUserTask;
		public OpenSelectNumberUserTaskFlowElement OpenSelectNumberUserTask {
			get {
				return _openSelectNumberUserTask ?? (_openSelectNumberUserTask = new OpenSelectNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _sendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess;
		public ProcessFlowElement SendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess {
			get {
				return _sendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess ?? (_sendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess",
					SchemaElementUId = new Guid("ec21fa26-b8d3-4cb1-9b9b-a3cb91aeab8a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sendTemplateEmailMenuItemPrepareMenuStartMessage;
		public ProcessFlowElement SendTemplateEmailMenuItemPrepareMenuStartMessage {
			get {
				return _sendTemplateEmailMenuItemPrepareMenuStartMessage ?? (_sendTemplateEmailMenuItemPrepareMenuStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SendTemplateEmailMenuItemPrepareMenuStartMessage",
					SchemaElementUId = new Guid("1ced35bb-2a8d-49d3-a2c8-8e6a01a969ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _createTemplateEmailCustomContextMenu_ScriptTask;
		public ProcessScriptTask CreateTemplateEmailCustomContextMenu_ScriptTask {
			get {
				return _createTemplateEmailCustomContextMenu_ScriptTask ?? (_createTemplateEmailCustomContextMenu_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateTemplateEmailCustomContextMenu_ScriptTask",
					SchemaElementUId = new Guid("be1f28b7-fa96-430b-91ab-3b65887a6285"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateTemplateEmailCustomContextMenu_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _processEmailTemplateContextItemClickEventSubProcess;
		public ProcessFlowElement ProcessEmailTemplateContextItemClickEventSubProcess {
			get {
				return _processEmailTemplateContextItemClickEventSubProcess ?? (_processEmailTemplateContextItemClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProcessEmailTemplateContextItemClickEventSubProcess",
					SchemaElementUId = new Guid("2ac96a3d-be56-4b61-8187-a2d14fcc8411"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _processEmailTemplateContextItemClickStartMessage;
		public ProcessFlowElement ProcessEmailTemplateContextItemClickStartMessage {
			get {
				return _processEmailTemplateContextItemClickStartMessage ?? (_processEmailTemplateContextItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProcessEmailTemplateContextItemClickStartMessage",
					SchemaElementUId = new Guid("2de65970-7933-440d-936d-141bf30d4883"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processEmailTemplateContextItemClickScriptTask;
		public ProcessScriptTask ProcessEmailTemplateContextItemClickScriptTask {
			get {
				return _processEmailTemplateContextItemClickScriptTask ?? (_processEmailTemplateContextItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessEmailTemplateContextItemClickScriptTask",
					SchemaElementUId = new Guid("3cfa055f-2d64-4d7d-bf7e-03df128360ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessEmailTemplateContextItemClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _baseGridPageInit;
		public ProcessFlowElement BaseGridPageInit {
			get {
				return _baseGridPageInit ?? (_baseGridPageInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseGridPageInit",
					SchemaElementUId = new Guid("82a8c96b-065d-40d7-b9fd-54282c9705a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseGridPageInitStartMessage;
		public ProcessFlowElement BaseGridPageInitStartMessage {
			get {
				return _baseGridPageInitStartMessage ?? (_baseGridPageInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseGridPageInitStartMessage",
					SchemaElementUId = new Guid("90e1d275-94eb-47ba-bb6a-d33039a29424"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskBaseGridPageInit;
		public ProcessScriptTask ScriptTaskBaseGridPageInit {
			get {
				return _scriptTaskBaseGridPageInit ?? (_scriptTaskBaseGridPageInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskBaseGridPageInit",
					SchemaElementUId = new Guid("8f50880b-1417-42aa-9101-5a5d0fd77239"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskBaseGridPageInitExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _initializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit;
		public ProcessThrowMessageEvent InitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit {
			get {
				return _initializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit ?? (_initializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit",
					SchemaElementUId = new Guid("c4615c33-f47c-4253-9ac4-f3ca13df4c19"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "InitializeFilterEdit",
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteEventSubProcess;
		public ProcessFlowElement PageLoadCompleteEventSubProcess {
			get {
				return _pageLoadCompleteEventSubProcess ?? (_pageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("0c6fb7c2-7c16-4a83-93ef-4ca2f55f957b"),
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
					SchemaElementUId = new Guid("a58fb0fd-2928-46a9-9ea9-03750afda36a"),
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
					SchemaElementUId = new Guid("6a3a49da-b2c0-4161-98b8-3c5077053502"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTaskCheckMenuItem;
		public ProcessScriptTask ScriptTaskCheckMenuItem {
			get {
				return _scriptTaskCheckMenuItem ?? (_scriptTaskCheckMenuItem = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskCheckMenuItem",
					SchemaElementUId = new Guid("b40bc5dd-63f4-4576-8a30-5dafb14b6446"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskCheckMenuItemExecute,
				});
			}
		}

		private ProcessScriptTask _scriptRegisterClientScript;
		public ProcessScriptTask ScriptRegisterClientScript {
			get {
				return _scriptRegisterClientScript ?? (_scriptRegisterClientScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptRegisterClientScript",
					SchemaElementUId = new Guid("64bc4d5a-1c95-41fd-9e9d-f0841451db04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptRegisterClientScriptExecute,
				});
			}
		}

		private LoadPrintReportButtonMenuProcessFlowElement _loadPrintReportButtonMenuProcess;
		public LoadPrintReportButtonMenuProcessFlowElement LoadPrintReportButtonMenuProcess {
			get {
				return _loadPrintReportButtonMenuProcess ?? ((_loadPrintReportButtonMenuProcess) = new LoadPrintReportButtonMenuProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("e63ad5b7-44b1-47f2-8c5f-6e757dbdef31"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addButtonClick;
		public ProcessFlowElement AddButtonClick {
			get {
				return _addButtonClick ?? (_addButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddButtonClick",
					SchemaElementUId = new Guid("ae0d6ca0-9d7b-4fc1-a214-bfc25300d799"),
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
					SchemaElementUId = new Guid("98efad80-8442-4330-8c08-c4d14232c7c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAddButtonClickExecute,
				});
			}
		}

		private ProcessScriptTask _scriptSetDefValues;
		public ProcessScriptTask ScriptSetDefValues {
			get {
				return _scriptSetDefValues ?? (_scriptSetDefValues = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSetDefValues",
					SchemaElementUId = new Guid("43a6b49d-0742-4f58-99e0-ef4e671d2311"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSetDefValuesExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTaskSendAllowRequest;
		public ProcessScriptTask ScriptTaskSendAllowRequest {
			get {
				return _scriptTaskSendAllowRequest ?? (_scriptTaskSendAllowRequest = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSendAllowRequest",
					SchemaElementUId = new Guid("e469f4f1-cfa0-42db-9295-ea2f96e88b4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSendAllowRequestExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageAllowAddDetailMessage;
		public ProcessFlowElement StartMessageAllowAddDetailMessage {
			get {
				return _startMessageAllowAddDetailMessage ?? (_startMessageAllowAddDetailMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAllowAddDetailMessage",
					SchemaElementUId = new Guid("32e28819-8c26-431d-83b7-195db3b3b8a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _gatewayCheckAlloAddDetail;
		public ProcessExclusiveGateway GatewayCheckAlloAddDetail {
			get {
				return _gatewayCheckAlloAddDetail ?? (_gatewayCheckAlloAddDetail = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "GatewayCheckAlloAddDetail",
					SchemaElementUId = new Guid("48b36f4c-a0b0-4aae-9885-e54b830f70eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.GatewayCheckAlloAddDetail.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private UserTaskAddOpenWindowFlowElement _userTaskAddOpenWindow;
		public UserTaskAddOpenWindowFlowElement UserTaskAddOpenWindow {
			get {
				return _userTaskAddOpenWindow ?? (_userTaskAddOpenWindow = new UserTaskAddOpenWindowFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("8f21206f-ffe1-4d10-95dd-5a3e401afc56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _editButtonClick;
		public ProcessFlowElement EditButtonClick {
			get {
				return _editButtonClick ?? (_editButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EditButtonClick",
					SchemaElementUId = new Guid("a1332396-f146-4aa4-950f-5244739f32e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptEditButtonClick;
		public ProcessScriptTask ScriptEditButtonClick {
			get {
				return _scriptEditButtonClick ?? (_scriptEditButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptEditButtonClick",
					SchemaElementUId = new Guid("4f3938ec-fed9-4842-ba5d-02b2a4f006fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptEditButtonClickExecute,
				});
			}
		}

		private UserTaskEditOpenWindowFlowElement _userTaskEditOpenWindow;
		public UserTaskEditOpenWindowFlowElement UserTaskEditOpenWindow {
			get {
				return _userTaskEditOpenWindow ?? (_userTaskEditOpenWindow = new UserTaskEditOpenWindowFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("1187aaba-0ef2-45e5-a4bf-f47de9d17d0c"),
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

		private ProcessScriptTask _scriptDefEditScript;
		public ProcessScriptTask ScriptDefEditScript {
			get {
				return _scriptDefEditScript ?? (_scriptDefEditScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDefEditScript",
					SchemaElementUId = new Guid("733ee819-36c5-427b-87fc-0be76a8e013c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDefEditScriptExecute,
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
					SchemaElementUId = new Guid("0aa48f27-6309-4522-8361-c08d16c6fc16"),
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
					SchemaElementUId = new Guid("56e65ffb-cfe8-4f83-b2cc-377ab0ad0bb8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteButtonClickExecute,
				});
			}
		}

		private UserMessageFlowElement _userMessage;
		public UserMessageFlowElement UserMessage {
			get {
				return _userMessage ?? (_userMessage = new UserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _deleteButtonClick;
		public ProcessFlowElement DeleteButtonClick {
			get {
				return _deleteButtonClick ?? (_deleteButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteButtonClick",
					SchemaElementUId = new Guid("2f99e62f-c050-4b1e-87d2-39d5393c270a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageCustomDeleteMessage;
		public ProcessFlowElement StartMessageCustomDeleteMessage {
			get {
				return _startMessageCustomDeleteMessage ?? (_startMessageCustomDeleteMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageCustomDeleteMessage",
					SchemaElementUId = new Guid("a03fd159-e954-43ba-a2bd-6db776117fe2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskCustomDeleteMessage;
		public ProcessScriptTask ScriptTaskCustomDeleteMessage {
			get {
				return _scriptTaskCustomDeleteMessage ?? (_scriptTaskCustomDeleteMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskCustomDeleteMessage",
					SchemaElementUId = new Guid("2dd25769-6b44-4e0d-8959-3448584ee10c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskCustomDeleteMessageExecute,
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
					SchemaElementUId = new Guid("ed21598d-905f-4a9b-b633-6ab5d3ed04c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _copyButtonClick;
		public ProcessFlowElement CopyButtonClick {
			get {
				return _copyButtonClick ?? (_copyButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CopyButtonClick",
					SchemaElementUId = new Guid("5fbf7352-f831-42ef-9724-84156114e6c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptCopyButtonClick;
		public ProcessScriptTask ScriptCopyButtonClick {
			get {
				return _scriptCopyButtonClick ?? (_scriptCopyButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptCopyButtonClick",
					SchemaElementUId = new Guid("86cc8d24-167b-43a7-bf0b-256241d63a85"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptCopyButtonClickExecute,
				});
			}
		}

		private UserTaskOpenCopyEditPageFlowElement _userTaskOpenCopyEditPage;
		public UserTaskOpenCopyEditPageFlowElement UserTaskOpenCopyEditPage {
			get {
				return _userTaskOpenCopyEditPage ?? (_userTaskOpenCopyEditPage = new UserTaskOpenCopyEditPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptDefCopyButton;
		public ProcessScriptTask ScriptDefCopyButton {
			get {
				return _scriptDefCopyButton ?? (_scriptDefCopyButton = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDefCopyButton",
					SchemaElementUId = new Guid("3b949a31-54f6-4b1c-84bc-f6a9a8903fee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDefCopyButtonExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayCopyOpenWindow;
		public ProcessExclusiveGateway ExclusiveGatewayCopyOpenWindow {
			get {
				return _exclusiveGatewayCopyOpenWindow ?? (_exclusiveGatewayCopyOpenWindow = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayCopyOpenWindow",
					SchemaElementUId = new Guid("6b8b652c-170d-4398-85fe-53da3e3ead24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGatewayCopyOpenWindow.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
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
					SchemaElementUId = new Guid("52bbae35-7cd2-4e3d-83b1-b162227c2a67"),
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
					SchemaElementUId = new Guid("8334edc8-790e-4017-9baa-84828238e595"),
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
					SchemaElementUId = new Guid("852df471-5a6d-4017-8422-f4fb37356a7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteNoMessageExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessOpenPrintReport;
		public ProcessFlowElement SubProcessOpenPrintReport {
			get {
				return _subProcessOpenPrintReport ?? (_subProcessOpenPrintReport = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessOpenPrintReport",
					SchemaElementUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
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
					SchemaElementUId = new Guid("f60b76a8-9f7a-4220-aeac-0896f32dad4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPrepareParametersOpenPrintReport;
		public ProcessScriptTask ScriptTaskPrepareParametersOpenPrintReport {
			get {
				return _scriptTaskPrepareParametersOpenPrintReport ?? (_scriptTaskPrepareParametersOpenPrintReport = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPrepareParametersOpenPrintReport",
					SchemaElementUId = new Guid("d371b146-df23-43c5-907e-19ab135966ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPrepareParametersOpenPrintReportExecute,
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
					SchemaElementUId = new Guid("d125104f-5de5-4320-a89b-958edaaef717"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskClearPrintUserContextExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageOpenPrintReportButtonClick;
		public ProcessFlowElement StartMessageOpenPrintReportButtonClick {
			get {
				return _startMessageOpenPrintReportButtonClick ?? (_startMessageOpenPrintReportButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageOpenPrintReportButtonClick",
					SchemaElementUId = new Guid("35d95d40-2e4f-442a-bf66-2ea1be25c1d8"),
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
					SchemaElementUId = new Guid("b56e7de1-87ca-4be3-9697-01291dc4ffdf"),
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

		private ProcessScriptTask _scriptTaskSetReportOptions;
		public ProcessScriptTask ScriptTaskSetReportOptions {
			get {
				return _scriptTaskSetReportOptions ?? (_scriptTaskSetReportOptions = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSetReportOptions",
					SchemaElementUId = new Guid("140ca1ac-5412-42a4-8521-6f911e66aa07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSetReportOptionsExecute,
				});
			}
		}

		private UserTaskPrintOpenWindowFlowElement _userTaskPrintOpenWindow;
		public UserTaskPrintOpenWindowFlowElement UserTaskPrintOpenWindow {
			get {
				return _userTaskPrintOpenWindow ?? (_userTaskPrintOpenWindow = new UserTaskPrintOpenWindowFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayOpenPrint;
		public ProcessExclusiveGateway ExclusiveGatewayOpenPrint {
			get {
				return _exclusiveGatewayOpenPrint ?? (_exclusiveGatewayOpenPrint = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayOpenPrint",
					SchemaElementUId = new Guid("d4d93ae6-c806-42c8-b93b-c173941216dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGatewayOpenPrint.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _scriptDefOperPrintWindow;
		public ProcessScriptTask ScriptDefOperPrintWindow {
			get {
				return _scriptDefOperPrintWindow ?? (_scriptDefOperPrintWindow = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDefOperPrintWindow",
					SchemaElementUId = new Guid("5204dbbf-5b6f-4fd6-abca-18b5112fa1f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDefOperPrintWindowExecute,
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
					SchemaElementUId = new Guid("0710c493-5f13-4bcc-b164-65906dcce2f6"),
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
					SchemaElementUId = new Guid("20c865f7-a59c-494c-a008-20c5bb01dcbd"),
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
					SchemaElementUId = new Guid("a52679bb-9d72-4ead-895d-4b5ea5729568"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteYesMessageExecute,
				});
			}
		}

		private ProcessFlowElement _createMSWordReportMessageEventSubProcess;
		public ProcessFlowElement CreateMSWordReportMessageEventSubProcess {
			get {
				return _createMSWordReportMessageEventSubProcess ?? (_createMSWordReportMessageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CreateMSWordReportMessageEventSubProcess",
					SchemaElementUId = new Guid("177d8565-e713-409a-90d3-030b4b516532"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _createMSWordReportMessageStartMessage;
		public ProcessFlowElement CreateMSWordReportMessageStartMessage {
			get {
				return _createMSWordReportMessageStartMessage ?? (_createMSWordReportMessageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CreateMSWordReportMessageStartMessage",
					SchemaElementUId = new Guid("be02116f-138a-4371-9394-f6a71a0c4b5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _createMSWordReportMessageScriptTask;
		public ProcessScriptTask CreateMSWordReportMessageScriptTask {
			get {
				return _createMSWordReportMessageScriptTask ?? (_createMSWordReportMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateMSWordReportMessageScriptTask",
					SchemaElementUId = new Guid("2e031421-af26-4fb6-986e-bb78ab06917d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateMSWordReportMessageScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _showMSWordReportCreatedScriptTask;
		public ProcessScriptTask ShowMSWordReportCreatedScriptTask {
			get {
				return _showMSWordReportCreatedScriptTask ?? (_showMSWordReportCreatedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowMSWordReportCreatedScriptTask",
					SchemaElementUId = new Guid("e57ce0fb-48da-48a5-9500-3b0311ea8aaf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowMSWordReportCreatedScriptTaskExecute,
				});
			}
		}

		private ShowMSWordReportCreatedUserTaskFlowElement _showMSWordReportCreatedUserTask;
		public ShowMSWordReportCreatedUserTaskFlowElement ShowMSWordReportCreatedUserTask {
			get {
				return _showMSWordReportCreatedUserTask ?? (_showMSWordReportCreatedUserTask = new ShowMSWordReportCreatedUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway33453453456789789783434535;
		public ProcessExclusiveGateway ExclusiveGateway33453453456789789783434535 {
			get {
				return _exclusiveGateway33453453456789789783434535 ?? (_exclusiveGateway33453453456789789783434535 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway33453453456789789783434535",
					SchemaElementUId = new Guid("419bf684-d717-417e-a32f-1dbff983ae92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway33453453456789789783434535.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessEndEvent _end1345345897809780343535;
		public ProcessEndEvent End1345345897809780343535 {
			get {
				return _end1345345897809780343535 ?? (_end1345345897809780343535 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1345345897809780343535",
					SchemaElementUId = new Guid("e6e69f0a-a64b-4683-8570-fecd7ed98855"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _saveReportToLocalDiskEventSubProcess;
		public ProcessFlowElement SaveReportToLocalDiskEventSubProcess {
			get {
				return _saveReportToLocalDiskEventSubProcess ?? (_saveReportToLocalDiskEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SaveReportToLocalDiskEventSubProcess",
					SchemaElementUId = new Guid("4dc53ca6-21e8-41af-b704-5dffe03805a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _saveReportToLocalDiskStartMessage;
		public ProcessFlowElement SaveReportToLocalDiskStartMessage {
			get {
				return _saveReportToLocalDiskStartMessage ?? (_saveReportToLocalDiskStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SaveReportToLocalDiskStartMessage",
					SchemaElementUId = new Guid("83d722c6-b54b-49c1-9e75-710af234f8da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _saveReportToLocalDiskScriptTask;
		public ProcessScriptTask SaveReportToLocalDiskScriptTask {
			get {
				return _saveReportToLocalDiskScriptTask ?? (_saveReportToLocalDiskScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveReportToLocalDiskScriptTask",
					SchemaElementUId = new Guid("c30fee04-e75a-4943-8ff0-69607a375c11"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveReportToLocalDiskScriptTaskExecute,
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
					SchemaElementUId = new Guid("0242a396-3be1-4bf2-a329-ee67e681d589"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwEditButtonClick;
		public ProcessThrowMessageEvent ThrowEditButtonClick {
			get {
				return _throwEditButtonClick ?? (_throwEditButtonClick = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowEditButtonClick",
					SchemaElementUId = new Guid("949b78e9-58a2-4555-bf53-4e390b056524"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "EditButtonClick",
				});
			}
		}

		private ProcessFlowElement _treeGridDblClick;
		public ProcessFlowElement TreeGridDblClick {
			get {
				return _treeGridDblClick ?? (_treeGridDblClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridDblClick",
					SchemaElementUId = new Guid("0cfbb5c2-ff9c-44a8-b45b-4af693fce3d8"),
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
					SchemaElementUId = new Guid("16140af4-ca5d-4620-8b5d-6d68fb31ac59"),
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
					SchemaElementUId = new Guid("b1e311a3-3e9c-4b51-865a-fa7e6ede7d2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptGridPageRefreshRow;
		public ProcessScriptTask ScriptGridPageRefreshRow {
			get {
				return _scriptGridPageRefreshRow ?? (_scriptGridPageRefreshRow = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptGridPageRefreshRow",
					SchemaElementUId = new Guid("ea8c0720-e286-4004-9364-7ed7bf2b763b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridPageRefreshRowExecute,
				});
			}
		}

		private ProcessFlowElement _dataSourceActiveRowChangedEventSubProcess;
		public ProcessFlowElement DataSourceActiveRowChangedEventSubProcess {
			get {
				return _dataSourceActiveRowChangedEventSubProcess ?? (_dataSourceActiveRowChangedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DataSourceActiveRowChangedEventSubProcess",
					SchemaElementUId = new Guid("572d5404-89d1-4679-be14-a6ee40c99e29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceActiveRowChangedEvent;
		public ProcessFlowElement DataSourceActiveRowChangedEvent {
			get {
				return _dataSourceActiveRowChangedEvent ?? (_dataSourceActiveRowChangedEvent = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceActiveRowChangedEvent",
					SchemaElementUId = new Guid("476873f8-10a4-41fd-97e5-17e664da6b66"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dataSourceActiveRowChangedScriptTask;
		public ProcessScriptTask DataSourceActiveRowChangedScriptTask {
			get {
				return _dataSourceActiveRowChangedScriptTask ?? (_dataSourceActiveRowChangedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DataSourceActiveRowChangedScriptTask",
					SchemaElementUId = new Guid("4d8b9f3e-6330-436f-9462-b038b1216c75"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DataSourceActiveRowChangedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadRowsResponseRegisteredEventSubProcess;
		public ProcessFlowElement DataSourceLoadRowsResponseRegisteredEventSubProcess {
			get {
				return _dataSourceLoadRowsResponseRegisteredEventSubProcess ?? (_dataSourceLoadRowsResponseRegisteredEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DataSourceLoadRowsResponseRegisteredEventSubProcess",
					SchemaElementUId = new Guid("36e70033-537a-496f-8f93-bbf6d0c02d1f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadRowsResponseRegisteredStartMessage;
		public ProcessFlowElement DataSourceLoadRowsResponseRegisteredStartMessage {
			get {
				return _dataSourceLoadRowsResponseRegisteredStartMessage ?? (_dataSourceLoadRowsResponseRegisteredStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoadRowsResponseRegisteredStartMessage",
					SchemaElementUId = new Guid("7ad28e1a-9277-4eac-92a7-931ca8f0bd62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dataSourceLoadRowsResponseRegisteredScriptTask;
		public ProcessScriptTask DataSourceLoadRowsResponseRegisteredScriptTask {
			get {
				return _dataSourceLoadRowsResponseRegisteredScriptTask ?? (_dataSourceLoadRowsResponseRegisteredScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DataSourceLoadRowsResponseRegisteredScriptTask",
					SchemaElementUId = new Guid("1b81ff46-e66c-4c7d-9b3d-f1a346bfcaaa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DataSourceLoadRowsResponseRegisteredScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadingSubProcess;
		public ProcessFlowElement DataSourceLoadingSubProcess {
			get {
				return _dataSourceLoadingSubProcess ?? (_dataSourceLoadingSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DataSourceLoadingSubProcess",
					SchemaElementUId = new Guid("41f89ff0-b697-4f13-bae1-731e35e4f08f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoading;
		public ProcessFlowElement DataSourceLoading {
			get {
				return _dataSourceLoading ?? (_dataSourceLoading = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoading",
					SchemaElementUId = new Guid("a5f48926-d190-43ec-99de-2bd2b535244c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dataSourceLoadingScriptTask;
		public ProcessScriptTask DataSourceLoadingScriptTask {
			get {
				return _dataSourceLoadingScriptTask ?? (_dataSourceLoadingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DataSourceLoadingScriptTask",
					SchemaElementUId = new Guid("ec055e27-e9ca-4a7c-8c26-40a333efd389"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DataSourceLoadingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _basePrepareFiltersDataSourceSubProcess;
		public ProcessFlowElement BasePrepareFiltersDataSourceSubProcess {
			get {
				return _basePrepareFiltersDataSourceSubProcess ?? (_basePrepareFiltersDataSourceSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BasePrepareFiltersDataSourceSubProcess",
					SchemaElementUId = new Guid("ac17d3ca-be40-4368-9021-6c85360dee7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageBasePrepareFilters;
		public ProcessFlowElement StartMessageBasePrepareFilters {
			get {
				return _startMessageBasePrepareFilters ?? (_startMessageBasePrepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageBasePrepareFilters",
					SchemaElementUId = new Guid("7b4693af-a1c6-4ed0-9d9d-82808be59f78"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskSendMessageBasePrepareFilter;
		public ProcessScriptTask ScriptTaskSendMessageBasePrepareFilter {
			get {
				return _scriptTaskSendMessageBasePrepareFilter ?? (_scriptTaskSendMessageBasePrepareFilter = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSendMessageBasePrepareFilter",
					SchemaElementUId = new Guid("4ccab20f-51ac-4182-b720-273dabfdf3a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSendMessageBasePrepareFilterExecute,
				});
			}
		}

		private ProcessScriptTask _scriptCreateDemoFilters;
		public ProcessScriptTask ScriptCreateDemoFilters {
			get {
				return _scriptCreateDemoFilters ?? (_scriptCreateDemoFilters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptCreateDemoFilters",
					SchemaElementUId = new Guid("2aa1b071-fb4e-41cb-94be-e1219c3661bd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptCreateDemoFiltersExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessInitializeFilterEdit;
		public ProcessFlowElement EventSubProcessInitializeFilterEdit {
			get {
				return _eventSubProcessInitializeFilterEdit ?? (_eventSubProcessInitializeFilterEdit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInitializeFilterEdit",
					SchemaElementUId = new Guid("f3f2330a-9474-4e7b-89a3-d02402705ac9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageInitializeFilterEdit;
		public ProcessFlowElement StartMessageInitializeFilterEdit {
			get {
				return _startMessageInitializeFilterEdit ?? (_startMessageInitializeFilterEdit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageInitializeFilterEdit",
					SchemaElementUId = new Guid("33586ad9-acff-4f9a-bf93-9fc1badc7f51"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInitializeFilterEdit;
		public ProcessScriptTask ScriptInitializeFilterEdit {
			get {
				return _scriptInitializeFilterEdit ?? (_scriptInitializeFilterEdit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInitializeFilterEdit",
					SchemaElementUId = new Guid("f424ffe2-d9bc-4616-aeec-0f95f43697a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitializeFilterEditExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessClearData;
		public ProcessFlowElement EventSubProcessClearData {
			get {
				return _eventSubProcessClearData ?? (_eventSubProcessClearData = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessClearData",
					SchemaElementUId = new Guid("a45d5f43-f507-4a3a-9209-a20abdef75e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startClearData;
		public ProcessFlowElement StartClearData {
			get {
				return _startClearData ?? (_startClearData = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartClearData",
					SchemaElementUId = new Guid("3e0f58db-73af-4caa-be84-33461262856e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptClearData;
		public ProcessScriptTask ScriptClearData {
			get {
				return _scriptClearData ?? (_scriptClearData = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptClearData",
					SchemaElementUId = new Guid("004a8d7f-690c-41c8-a865-b93a5b9f079b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptClearDataExecute,
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
					SchemaElementUId = new Guid("502c9fdd-af56-4f10-9af3-0910221be3de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _selectFolder;
		public ProcessFlowElement SelectFolder {
			get {
				return _selectFolder ?? (_selectFolder = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SelectFolder",
					SchemaElementUId = new Guid("23df5659-911c-46f6-95a6-bfa49c63b31f"),
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
					SchemaElementUId = new Guid("a1ffa055-37e7-4112-bda5-d5ef3b5b6483"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSelectFolderExecute,
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
					SchemaElementUId = new Guid("2e323a9f-3bee-4e41-a29d-3ec3efc519c6"),
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
					SchemaElementUId = new Guid("315a487f-aad5-4645-8648-0fe6ab36af7d"),
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
					SchemaElementUId = new Guid("fe08a71a-6dd8-4978-97aa-fd85e00a7e1b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptApplySearchFilterExecute,
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
					SchemaElementUId = new Guid("6f8f7a53-e50b-45a0-a104-4989af26d799"),
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
					SchemaElementUId = new Guid("d312a685-3ec7-4c42-8325-bd38aef1e095"),
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
					SchemaElementUId = new Guid("f3c4b42c-8043-4eff-a84f-9531dbfcf50d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptRunModuleProcessExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessProcessPropsWindowClosed;
		public ProcessFlowElement EventSubProcessProcessPropsWindowClosed {
			get {
				return _eventSubProcessProcessPropsWindowClosed ?? (_eventSubProcessProcessPropsWindowClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessProcessPropsWindowClosed",
					SchemaElementUId = new Guid("9bafe48c-f085-4759-bc0a-319683fb1403"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startProcessPropsWindowClosed;
		public ProcessFlowElement StartProcessPropsWindowClosed {
			get {
				return _startProcessPropsWindowClosed ?? (_startProcessPropsWindowClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartProcessPropsWindowClosed",
					SchemaElementUId = new Guid("ef2e34f4-06ea-4a5a-b8a1-d3e1adaac355"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptProcessPropsWindowClosed;
		public ProcessScriptTask ScriptProcessPropsWindowClosed {
			get {
				return _scriptProcessPropsWindowClosed ?? (_scriptProcessPropsWindowClosed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptProcessPropsWindowClosed",
					SchemaElementUId = new Guid("6fbfe17e-cb63-40c2-b7fb-5306622417ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptProcessPropsWindowClosedExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess1OpenProcessEdit;
		public ProcessFlowElement EventSubProcess1OpenProcessEdit {
			get {
				return _eventSubProcess1OpenProcessEdit ?? (_eventSubProcess1OpenProcessEdit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1OpenProcessEdit",
					SchemaElementUId = new Guid("61495bba-c122-4612-86f0-80226240a164"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startCreateNewProcessMenuItemClick;
		public ProcessFlowElement StartCreateNewProcessMenuItemClick {
			get {
				return _startCreateNewProcessMenuItemClick ?? (_startCreateNewProcessMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartCreateNewProcessMenuItemClick",
					SchemaElementUId = new Guid("c0af7230-5cf6-4022-baa8-712bb01b3a3d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptCreateNewProcessMenuItemClick;
		public ProcessScriptTask ScriptCreateNewProcessMenuItemClick {
			get {
				return _scriptCreateNewProcessMenuItemClick ?? (_scriptCreateNewProcessMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptCreateNewProcessMenuItemClick",
					SchemaElementUId = new Guid("0e4bbcee-b4be-46e7-a5d6-69a21046ab45"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptCreateNewProcessMenuItemClickExecute,
				});
			}
		}

		private OpenProcessEditUserTaskFlowElement _openProcessEditUserTask;
		public OpenProcessEditUserTaskFlowElement OpenProcessEditUserTask {
			get {
				return _openProcessEditUserTask ?? (_openProcessEditUserTask = new OpenProcessEditUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("037e96df-6979-4d86-82bd-1d83354beec6"),
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
					SchemaElementUId = new Guid("9ae77a58-9bb7-4057-8353-9a5b97a9f458"),
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

		private ProcessFlowElement _eventSubProcess1TuningModeChanged;
		public ProcessFlowElement EventSubProcess1TuningModeChanged {
			get {
				return _eventSubProcess1TuningModeChanged ?? (_eventSubProcess1TuningModeChanged = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1TuningModeChanged",
					SchemaElementUId = new Guid("d3923fb6-891f-427e-86e2-caf424809011"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startTuningModeChanged;
		public ProcessFlowElement StartTuningModeChanged {
			get {
				return _startTuningModeChanged ?? (_startTuningModeChanged = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartTuningModeChanged",
					SchemaElementUId = new Guid("51300206-0e8d-4bad-a8a6-0add8f578efa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTuningModeChanged;
		public ProcessScriptTask ScriptTuningModeChanged {
			get {
				return _scriptTuningModeChanged ?? (_scriptTuningModeChanged = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTuningModeChanged",
					SchemaElementUId = new Guid("b24742a5-228b-4d91-9b22-3032bae867bd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTuningModeChangedExecute,
				});
			}
		}

		private ProcessFlowElement _createNewSysModuleReportMenuItemClickEventSubProcess;
		public ProcessFlowElement CreateNewSysModuleReportMenuItemClickEventSubProcess {
			get {
				return _createNewSysModuleReportMenuItemClickEventSubProcess ?? (_createNewSysModuleReportMenuItemClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CreateNewSysModuleReportMenuItemClickEventSubProcess",
					SchemaElementUId = new Guid("671b33af-7ba4-4958-9b51-7b792893f2d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageCreateNewSysModuleReportMenuItemClick;
		public ProcessFlowElement StartMessageCreateNewSysModuleReportMenuItemClick {
			get {
				return _startMessageCreateNewSysModuleReportMenuItemClick ?? (_startMessageCreateNewSysModuleReportMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageCreateNewSysModuleReportMenuItemClick",
					SchemaElementUId = new Guid("c060ab60-5e2b-464a-9011-2b5d867784d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskCreateNewSysModuleReportMenuItemClick;
		public ProcessScriptTask ScriptTaskCreateNewSysModuleReportMenuItemClick {
			get {
				return _scriptTaskCreateNewSysModuleReportMenuItemClick ?? (_scriptTaskCreateNewSysModuleReportMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskCreateNewSysModuleReportMenuItemClick",
					SchemaElementUId = new Guid("0c070f3d-a8e7-475a-a74b-1dc9350b3ced"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskCreateNewSysModuleReportMenuItemClickExecute,
				});
			}
		}

		private CreateNewSysModuleReportMenuItemClickUserTaskFlowElement _createNewSysModuleReportMenuItemClickUserTask;
		public CreateNewSysModuleReportMenuItemClickUserTaskFlowElement CreateNewSysModuleReportMenuItemClickUserTask {
			get {
				return _createNewSysModuleReportMenuItemClickUserTask ?? (_createNewSysModuleReportMenuItemClickUserTask = new CreateNewSysModuleReportMenuItemClickUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _sysModuleReportPropsWindowClosedEventSubProcess;
		public ProcessFlowElement SysModuleReportPropsWindowClosedEventSubProcess {
			get {
				return _sysModuleReportPropsWindowClosedEventSubProcess ?? (_sysModuleReportPropsWindowClosedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysModuleReportPropsWindowClosedEventSubProcess",
					SchemaElementUId = new Guid("1f4332c9-2f5b-4061-8b32-b32581c8c0e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysModuleReportPropsWindowClosedStartMessage;
		public ProcessFlowElement SysModuleReportPropsWindowClosedStartMessage {
			get {
				return _sysModuleReportPropsWindowClosedStartMessage ?? (_sysModuleReportPropsWindowClosedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysModuleReportPropsWindowClosedStartMessage",
					SchemaElementUId = new Guid("8459b111-da6c-45e5-b401-b9c10bc2e455"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysModuleReportPropsWindowClosedScriptTask;
		public ProcessScriptTask SysModuleReportPropsWindowClosedScriptTask {
			get {
				return _sysModuleReportPropsWindowClosedScriptTask ?? (_sysModuleReportPropsWindowClosedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysModuleReportPropsWindowClosedScriptTask",
					SchemaElementUId = new Guid("2deb0bd9-c079-4644-80b7-c8e3dae82748"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysModuleReportPropsWindowClosedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _setDetailPrintButtonMenuEventSubProcess1;
		public ProcessFlowElement SetDetailPrintButtonMenuEventSubProcess1 {
			get {
				return _setDetailPrintButtonMenuEventSubProcess1 ?? (_setDetailPrintButtonMenuEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SetDetailPrintButtonMenuEventSubProcess1",
					SchemaElementUId = new Guid("f26bbf13-4145-4815-b978-099ab33ab2ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _setDetailPrintButtonMenuStartMessage1;
		public ProcessFlowElement SetDetailPrintButtonMenuStartMessage1 {
			get {
				return _setDetailPrintButtonMenuStartMessage1 ?? (_setDetailPrintButtonMenuStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SetDetailPrintButtonMenuStartMessage1",
					SchemaElementUId = new Guid("f27631e2-2c27-438c-a760-4c991b7a0cf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setDetailPrintButtonMenuScriptTask1;
		public ProcessScriptTask SetDetailPrintButtonMenuScriptTask1 {
			get {
				return _setDetailPrintButtonMenuScriptTask1 ?? (_setDetailPrintButtonMenuScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetDetailPrintButtonMenuScriptTask1",
					SchemaElementUId = new Guid("edcc4a52-ebff-45e0-b28e-a6c05c3cb655"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetDetailPrintButtonMenuScriptTask1Execute,
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow284;
		public ProcessConditionalFlow SequenceFlow284 {
			get {
				return _sequenceFlow284 ?? (_sequenceFlow284 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow284",
					SchemaElementUId = new Guid("9fefce9b-fc4e-4ab8-a86c-d76cd20e0d00"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow295;
		public ProcessConditionalFlow SequenceFlow295 {
			get {
				return _sequenceFlow295 ?? (_sequenceFlow295 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow295",
					SchemaElementUId = new Guid("7cf06fc1-597a-420d-a065-bd35f98fb2f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow297;
		public ProcessConditionalFlow SequenceFlow297 {
			get {
				return _sequenceFlow297 ?? (_sequenceFlow297 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow297",
					SchemaElementUId = new Guid("bf384f74-8b24-4b7b-b72d-b34bf7d95c06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow28;
		public ProcessConditionalFlow ConditionalFlow28 {
			get {
				return _conditionalFlow28 ?? (_conditionalFlow28 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow28",
					SchemaElementUId = new Guid("57de51fd-a22c-46f6-af6d-0fe53a83e13c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1retbb;
		public ProcessConditionalFlow ConditionalFlow1retbb {
			get {
				return _conditionalFlow1retbb ?? (_conditionalFlow1retbb = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1retbb",
					SchemaElementUId = new Guid("d8206b9c-a294-45e4-9407-5a9ea035558d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1wwers;
		public ProcessConditionalFlow ConditionalFlow1wwers {
			get {
				return _conditionalFlow1wwers ?? (_conditionalFlow1wwers = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1wwers",
					SchemaElementUId = new Guid("10d58161-27c6-456c-9800-3ca84e57cd5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow156757575757234242424;
		public ProcessConditionalFlow ConditionalFlow156757575757234242424 {
			get {
				return _conditionalFlow156757575757234242424 ?? (_conditionalFlow156757575757234242424 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow156757575757234242424",
					SchemaElementUId = new Guid("603886c2-dea5-400d-b2f3-ae2bd8335b98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _showChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken;
		public ProcessToken ShowChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken {
			get {
				return _showChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken ?? (_showChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ShowChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken",
					SchemaElementUId = new Guid("0df5a143-d3a5-4b4b-a755-76faa7f09f8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private LocalizableString _deleteRecordMessage;
		public LocalizableString DeleteRecordMessage {
			get {
				return _deleteRecordMessage ?? (_deleteRecordMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteRecordMessage.Value"));
			}
		}

		private LocalizableString _warning;
		public LocalizableString Warning {
			get {
				return _warning ?? (_warning = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Warning.Value"));
			}
		}

		private LocalizableString _dependencyWarningMessage;
		public LocalizableString DependencyWarningMessage {
			get {
				return _dependencyWarningMessage ?? (_dependencyWarningMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DependencyWarningMessage.Value"));
			}
		}

		private LocalizableString _rightLevelWarningMessage;
		public LocalizableString RightLevelWarningMessage {
			get {
				return _rightLevelWarningMessage ?? (_rightLevelWarningMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RightLevelWarningMessage.Value"));
			}
		}

		private LocalizableString _rightLevelDependencyWarningMessage;
		public LocalizableString RightLevelDependencyWarningMessage {
			get {
				return _rightLevelDependencyWarningMessage ?? (_rightLevelDependencyWarningMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RightLevelDependencyWarningMessage.Value"));
			}
		}

		private LocalizableString _questionCaption;
		public LocalizableString QuestionCaption {
			get {
				return _questionCaption ?? (_questionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.QuestionCaption.Value"));
			}
		}

		private LocalizableString _newRecordNotSavedMessage;
		public LocalizableString NewRecordNotSavedMessage {
			get {
				return _newRecordNotSavedMessage ?? (_newRecordNotSavedMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NewRecordNotSavedMessage.Value"));
			}
		}

		private LocalizableString _contextMenuSeparatorTemplatePattern;
		public LocalizableString ContextMenuSeparatorTemplatePattern {
			get {
				return _contextMenuSeparatorTemplatePattern ?? (_contextMenuSeparatorTemplatePattern = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ContextMenuSeparatorTemplatePattern.Value"));
			}
		}

		private LocalizableString _contextMenuSeparatorContactPattern;
		public LocalizableString ContextMenuSeparatorContactPattern {
			get {
				return _contextMenuSeparatorContactPattern ?? (_contextMenuSeparatorContactPattern = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ContextMenuSeparatorContactPattern.Value"));
			}
		}

		private LocalizableString _createNewProcessMenuItemCaption;
		public LocalizableString CreateNewProcessMenuItemCaption {
			get {
				return _createNewProcessMenuItemCaption ?? (_createNewProcessMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CreateNewProcessMenuItemCaption.Value"));
			}
		}

		private LocalizableString _deleteProcessMenuItemCaption;
		public LocalizableString DeleteProcessMenuItemCaption {
			get {
				return _deleteProcessMenuItemCaption ?? (_deleteProcessMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteProcessMenuItemCaption.Value"));
			}
		}

		private LocalizableString _moduleProcessInstanceNotExistMessage;
		public LocalizableString ModuleProcessInstanceNotExistMessage {
			get {
				return _moduleProcessInstanceNotExistMessage ?? (_moduleProcessInstanceNotExistMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ModuleProcessInstanceNotExistMessage.Value"));
			}
		}

		private LocalizableString _noPhoneNumber;
		public LocalizableString NoPhoneNumber {
			get {
				return _noPhoneNumber ?? (_noPhoneNumber = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NoPhoneNumber.Value"));
			}
		}

		private LocalizableString _mSWordReportWasCreated;
		public LocalizableString MSWordReportWasCreated {
			get {
				return _mSWordReportWasCreated ?? (_mSWordReportWasCreated = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.MSWordReportWasCreated.Value"));
			}
		}

		private LocalizableString _setSettingsNow;
		public LocalizableString SetSettingsNow {
			get {
				return _setSettingsNow ?? (_setSettingsNow = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SetSettingsNow.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1_BaseGridPage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1_BaseGridPage };
			FlowElements[SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage };
			FlowElements[CreateEmailCustomContextMenu_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateEmailCustomContextMenu_ScriptTask };
			FlowElements[EventSubProcess8_BaseGridPage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8_BaseGridPage };
			FlowElements[ProcessEmailContextItemClick_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessEmailContextItemClick_StartMessage };
			FlowElements[ProcessEmailContextMenuClick_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessEmailContextMenuClick_ScriptTask };
			FlowElements[OpenEmailEditPage_BaseGridPage_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEmailEditPage_BaseGridPage_UserTask };
			FlowElements[EventSubProcess12539.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12539 };
			FlowElements[ViewRecordAllChangesProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ViewRecordAllChangesProcess };
			FlowElements[ShowChangelogMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowChangelogMenuItemClickScriptTask };
			FlowElements[ShowChangelogMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowChangelogMenuItemClickStartMessage };
			FlowElements[EventSubProcess1werwe.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1werwe };
			FlowElements[StartMessage1ddrrg.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1ddrrg };
			FlowElements[CreateCallCustomContextMenu_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateCallCustomContextMenu_ScriptTask };
			FlowElements[EventSubProcess1bghhj.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1bghhj };
			FlowElements[ProcessCallContextItemClick_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessCallContextItemClick_StartMessage };
			FlowElements[ProcessCallContextMenuItemClick_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessCallContextMenuItemClick_ScriptTask };
			FlowElements[NumberSelectedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { NumberSelectedMessage };
			FlowElements[ExclusiveGateway3wwwcc.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3wwwcc };
			FlowElements[NotifyCtiPanelCallMessage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NotifyCtiPanelCallMessage_ScriptTask };
			FlowElements[ShowNoPhoneNumbersUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowNoPhoneNumbersUserTask };
			FlowElements[ProcessCallContextMenuItemClick_ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessCallContextMenuItemClick_ScriptTask3 };
			FlowElements[OpenSelectNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenSelectNumberUserTask };
			FlowElements[SendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess };
			FlowElements[SendTemplateEmailMenuItemPrepareMenuStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SendTemplateEmailMenuItemPrepareMenuStartMessage };
			FlowElements[CreateTemplateEmailCustomContextMenu_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateTemplateEmailCustomContextMenu_ScriptTask };
			FlowElements[ProcessEmailTemplateContextItemClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessEmailTemplateContextItemClickEventSubProcess };
			FlowElements[ProcessEmailTemplateContextItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessEmailTemplateContextItemClickStartMessage };
			FlowElements[ProcessEmailTemplateContextItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessEmailTemplateContextItemClickScriptTask };
			FlowElements[BaseGridPageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseGridPageInit };
			FlowElements[BaseGridPageInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseGridPageInitStartMessage };
			FlowElements[ScriptTaskBaseGridPageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskBaseGridPageInit };
			FlowElements[InitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit.SchemaElementUId] = new Collection<ProcessFlowElement> { InitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit };
			FlowElements[PageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[ScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadComplete };
			FlowElements[ScriptTaskCheckMenuItem.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskCheckMenuItem };
			FlowElements[ScriptRegisterClientScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptRegisterClientScript };
			FlowElements[LoadPrintReportButtonMenuProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadPrintReportButtonMenuProcess };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[AddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClick };
			FlowElements[ScriptAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAddButtonClick };
			FlowElements[ScriptSetDefValues.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSetDefValues };
			FlowElements[ScriptTaskSendAllowRequest.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSendAllowRequest };
			FlowElements[StartMessageAllowAddDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAllowAddDetailMessage };
			FlowElements[GatewayCheckAlloAddDetail.SchemaElementUId] = new Collection<ProcessFlowElement> { GatewayCheckAlloAddDetail };
			FlowElements[UserTaskAddOpenWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskAddOpenWindow };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[EditButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClick };
			FlowElements[ScriptEditButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptEditButtonClick };
			FlowElements[UserTaskEditOpenWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskEditOpenWindow };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ScriptDefEditScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDefEditScript };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[ScriptDeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteButtonClick };
			FlowElements[UserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserMessage };
			FlowElements[DeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClick };
			FlowElements[StartMessageCustomDeleteMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageCustomDeleteMessage };
			FlowElements[ScriptTaskCustomDeleteMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskCustomDeleteMessage };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[CopyButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { CopyButtonClick };
			FlowElements[ScriptCopyButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptCopyButtonClick };
			FlowElements[UserTaskOpenCopyEditPage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskOpenCopyEditPage };
			FlowElements[ScriptDefCopyButton.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDefCopyButton };
			FlowElements[ExclusiveGatewayCopyOpenWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayCopyOpenWindow };
			FlowElements[SubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess5 };
			FlowElements[DeleteNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteNoMessage };
			FlowElements[ScriptDeleteNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteNoMessage };
			FlowElements[SubProcessOpenPrintReport.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessOpenPrintReport };
			FlowElements[StartMessageOpenPrintReportMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageOpenPrintReportMessage };
			FlowElements[ScriptTaskPrepareParametersOpenPrintReport.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPrepareParametersOpenPrintReport };
			FlowElements[ScriptTaskClearPrintUserContext.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskClearPrintUserContext };
			FlowElements[StartMessageOpenPrintReportButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageOpenPrintReportButtonClick };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ScriptTaskSetReportOptions.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSetReportOptions };
			FlowElements[UserTaskPrintOpenWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskPrintOpenWindow };
			FlowElements[ExclusiveGatewayOpenPrint.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayOpenPrint };
			FlowElements[ScriptDefOperPrintWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDefOperPrintWindow };
			FlowElements[SubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess4 };
			FlowElements[DeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteYesMessage };
			FlowElements[ScriptDeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteYesMessage };
			FlowElements[CreateMSWordReportMessageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateMSWordReportMessageEventSubProcess };
			FlowElements[CreateMSWordReportMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateMSWordReportMessageStartMessage };
			FlowElements[CreateMSWordReportMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateMSWordReportMessageScriptTask };
			FlowElements[ShowMSWordReportCreatedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMSWordReportCreatedScriptTask };
			FlowElements[ShowMSWordReportCreatedUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMSWordReportCreatedUserTask };
			FlowElements[ExclusiveGateway33453453456789789783434535.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway33453453456789789783434535 };
			FlowElements[End1345345897809780343535.SchemaElementUId] = new Collection<ProcessFlowElement> { End1345345897809780343535 };
			FlowElements[SaveReportToLocalDiskEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveReportToLocalDiskEventSubProcess };
			FlowElements[SaveReportToLocalDiskStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveReportToLocalDiskStartMessage };
			FlowElements[SaveReportToLocalDiskScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveReportToLocalDiskScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[ThrowEditButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowEditButtonClick };
			FlowElements[TreeGridDblClick.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClick };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessageNonInterruptingEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageNonInterruptingEvent2 };
			FlowElements[ScriptGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridPageRefreshRow };
			FlowElements[DataSourceActiveRowChangedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceActiveRowChangedEventSubProcess };
			FlowElements[DataSourceActiveRowChangedEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceActiveRowChangedEvent };
			FlowElements[DataSourceActiveRowChangedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceActiveRowChangedScriptTask };
			FlowElements[DataSourceLoadRowsResponseRegisteredEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadRowsResponseRegisteredEventSubProcess };
			FlowElements[DataSourceLoadRowsResponseRegisteredStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadRowsResponseRegisteredStartMessage };
			FlowElements[DataSourceLoadRowsResponseRegisteredScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadRowsResponseRegisteredScriptTask };
			FlowElements[DataSourceLoadingSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadingSubProcess };
			FlowElements[DataSourceLoading.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoading };
			FlowElements[DataSourceLoadingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadingScriptTask };
			FlowElements[BasePrepareFiltersDataSourceSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePrepareFiltersDataSourceSubProcess };
			FlowElements[StartMessageBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageBasePrepareFilters };
			FlowElements[ScriptTaskSendMessageBasePrepareFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSendMessageBasePrepareFilter };
			FlowElements[ScriptCreateDemoFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptCreateDemoFilters };
			FlowElements[EventSubProcessInitializeFilterEdit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInitializeFilterEdit };
			FlowElements[StartMessageInitializeFilterEdit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInitializeFilterEdit };
			FlowElements[ScriptInitializeFilterEdit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInitializeFilterEdit };
			FlowElements[EventSubProcessClearData.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessClearData };
			FlowElements[StartClearData.SchemaElementUId] = new Collection<ProcessFlowElement> { StartClearData };
			FlowElements[ScriptClearData.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptClearData };
			FlowElements[SubProcessSelectFolder.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSelectFolder };
			FlowElements[SelectFolder.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectFolder };
			FlowElements[ScriptSelectFolder.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSelectFolder };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[ApplySearchFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplySearchFilter };
			FlowElements[ScriptApplySearchFilter.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptApplySearchFilter };
			FlowElements[EventSubProcessRunModuleProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessRunModuleProcess };
			FlowElements[StartRunModuleProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartRunModuleProcess };
			FlowElements[ScriptRunModuleProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptRunModuleProcess };
			FlowElements[EventSubProcessProcessPropsWindowClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessProcessPropsWindowClosed };
			FlowElements[StartProcessPropsWindowClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { StartProcessPropsWindowClosed };
			FlowElements[ScriptProcessPropsWindowClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptProcessPropsWindowClosed };
			FlowElements[EventSubProcess1OpenProcessEdit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1OpenProcessEdit };
			FlowElements[StartCreateNewProcessMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartCreateNewProcessMenuItemClick };
			FlowElements[ScriptCreateNewProcessMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptCreateNewProcessMenuItemClick };
			FlowElements[OpenProcessEditUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenProcessEditUserTask };
			FlowElements[EventSubProcessShowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessShowMessage };
			FlowElements[StartShowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartShowMessage };
			FlowElements[MessageWindowUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MessageWindowUserTask };
			FlowElements[EventSubProcess1TuningModeChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1TuningModeChanged };
			FlowElements[StartTuningModeChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { StartTuningModeChanged };
			FlowElements[ScriptTuningModeChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTuningModeChanged };
			FlowElements[CreateNewSysModuleReportMenuItemClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateNewSysModuleReportMenuItemClickEventSubProcess };
			FlowElements[StartMessageCreateNewSysModuleReportMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageCreateNewSysModuleReportMenuItemClick };
			FlowElements[ScriptTaskCreateNewSysModuleReportMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskCreateNewSysModuleReportMenuItemClick };
			FlowElements[CreateNewSysModuleReportMenuItemClickUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateNewSysModuleReportMenuItemClickUserTask };
			FlowElements[SysModuleReportPropsWindowClosedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysModuleReportPropsWindowClosedEventSubProcess };
			FlowElements[SysModuleReportPropsWindowClosedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysModuleReportPropsWindowClosedStartMessage };
			FlowElements[SysModuleReportPropsWindowClosedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysModuleReportPropsWindowClosedScriptTask };
			FlowElements[SetDetailPrintButtonMenuEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SetDetailPrintButtonMenuEventSubProcess1 };
			FlowElements[SetDetailPrintButtonMenuStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { SetDetailPrintButtonMenuStartMessage1 };
			FlowElements[SetDetailPrintButtonMenuScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { SetDetailPrintButtonMenuScriptTask1 };
			FlowElements[ShowChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1_BaseGridPage":
						break;
					case "SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage":
						e.Context.QueueTasks.Enqueue("CreateEmailCustomContextMenu_ScriptTask");
						break;
					case "CreateEmailCustomContextMenu_ScriptTask":
						break;
					case "EventSubProcess8_BaseGridPage":
						break;
					case "ProcessEmailContextItemClick_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessEmailContextMenuClick_ScriptTask");
						break;
					case "ProcessEmailContextMenuClick_ScriptTask":
						e.Context.QueueTasks.Enqueue("OpenEmailEditPage_BaseGridPage_UserTask");
						break;
					case "OpenEmailEditPage_BaseGridPage_UserTask":
						break;
					case "EventSubProcess12539":
						break;
					case "ViewRecordAllChangesProcess":
						break;
					case "ShowChangelogMenuItemClickScriptTask":
						e.Context.QueueTasks.Enqueue("ShowChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken");
						break;
					case "ShowChangelogMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("ShowChangelogMenuItemClickScriptTask");
						break;
					case "EventSubProcess1werwe":
						break;
					case "StartMessage1ddrrg":
						e.Context.QueueTasks.Enqueue("CreateCallCustomContextMenu_ScriptTask");
						break;
					case "CreateCallCustomContextMenu_ScriptTask":
						break;
					case "EventSubProcess1bghhj":
						break;
					case "ProcessCallContextItemClick_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessCallContextMenuItemClick_ScriptTask");
						break;
					case "ProcessCallContextMenuItemClick_ScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3wwwcc");
						break;
					case "NumberSelectedMessage":
						e.Context.QueueTasks.Enqueue("NotifyCtiPanelCallMessage_ScriptTask");
						break;
					case "ExclusiveGateway3wwwcc":
						if (ConditionalFlow1retbbExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("NotifyCtiPanelCallMessage_ScriptTask");
							break;
						}
						if (ConditionalFlow1wwersExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ProcessCallContextMenuItemClick_ScriptTask3");
							break;
						}
						e.Context.QueueTasks.Enqueue("ShowNoPhoneNumbersUserTask");
						break;
					case "NotifyCtiPanelCallMessage_ScriptTask":
						break;
					case "ShowNoPhoneNumbersUserTask":
						break;
					case "ProcessCallContextMenuItemClick_ScriptTask3":
						e.Context.QueueTasks.Enqueue("OpenSelectNumberUserTask");
						break;
					case "OpenSelectNumberUserTask":
						break;
					case "SendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess":
						break;
					case "SendTemplateEmailMenuItemPrepareMenuStartMessage":
						e.Context.QueueTasks.Enqueue("CreateTemplateEmailCustomContextMenu_ScriptTask");
						break;
					case "CreateTemplateEmailCustomContextMenu_ScriptTask":
						break;
					case "ProcessEmailTemplateContextItemClickEventSubProcess":
						break;
					case "ProcessEmailTemplateContextItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("ProcessEmailTemplateContextItemClickScriptTask");
						break;
					case "ProcessEmailTemplateContextItemClickScriptTask":
						break;
					case "BaseGridPageInit":
						break;
					case "BaseGridPageInitStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskBaseGridPageInit");
						break;
					case "ScriptTaskBaseGridPageInit":
						break;
					case "InitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit":
						break;
					case "PageLoadCompleteEventSubProcess":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadComplete");
						break;
					case "ScriptPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptTaskCheckMenuItem");
						break;
					case "ScriptTaskCheckMenuItem":
						e.Context.QueueTasks.Enqueue("ScriptRegisterClientScript");
						break;
					case "ScriptRegisterClientScript":
						break;
					case "LoadPrintReportButtonMenuProcess":
						break;
					case "EventSubProcess4":
						break;
					case "AddButtonClick":
						e.Context.QueueTasks.Enqueue("GatewayCheckAlloAddDetail");
						break;
					case "ScriptAddButtonClick":
						e.Context.QueueTasks.Enqueue("UserTaskAddOpenWindow");
						break;
					case "ScriptSetDefValues":
						e.Context.QueueTasks.Enqueue("ScriptAddButtonClick");
						break;
					case "ScriptTaskSendAllowRequest":
						break;
					case "StartMessageAllowAddDetailMessage":
						e.Context.QueueTasks.Enqueue("ScriptSetDefValues");
						break;
					case "GatewayCheckAlloAddDetail":
						if (SequenceFlow284ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTaskSendAllowRequest");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptSetDefValues");
						break;
					case "UserTaskAddOpenWindow":
						break;
					case "EventSubProcess6":
						break;
					case "EditButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptEditButtonClick");
						break;
					case "ScriptEditButtonClick":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "UserTaskEditOpenWindow":
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow28ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("UserTaskEditOpenWindow");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptDefEditScript");
						break;
					case "ScriptDefEditScript":
						break;
					case "EventSubProcess7":
						break;
					case "ScriptDeleteButtonClick":
						e.Context.QueueTasks.Enqueue("UserMessage");
						break;
					case "UserMessage":
						break;
					case "DeleteButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptDeleteButtonClick");
						break;
					case "StartMessageCustomDeleteMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskCustomDeleteMessage");
						break;
					case "ScriptTaskCustomDeleteMessage":
						e.Context.QueueTasks.Enqueue("UserMessage");
						break;
					case "EventSubProcess5":
						break;
					case "CopyButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptCopyButtonClick");
						break;
					case "ScriptCopyButtonClick":
						e.Context.QueueTasks.Enqueue("ExclusiveGatewayCopyOpenWindow");
						break;
					case "UserTaskOpenCopyEditPage":
						break;
					case "ScriptDefCopyButton":
						break;
					case "ExclusiveGatewayCopyOpenWindow":
						if (SequenceFlow295ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("UserTaskOpenCopyEditPage");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptDefCopyButton");
						break;
					case "SubProcess5":
						break;
					case "DeleteNoMessage":
						e.Context.QueueTasks.Enqueue("ScriptDeleteNoMessage");
						break;
					case "ScriptDeleteNoMessage":
						break;
					case "SubProcessOpenPrintReport":
						break;
					case "StartMessageOpenPrintReportMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskPrepareParametersOpenPrintReport");
						break;
					case "ScriptTaskPrepareParametersOpenPrintReport":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ScriptTaskClearPrintUserContext":
						break;
					case "StartMessageOpenPrintReportButtonClick":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
							e.Context.QueueTasks.Enqueue("ScriptTaskSetReportOptions");
						break;
					case "ScriptTaskSetReportOptions":
						e.Context.QueueTasks.Enqueue("ExclusiveGatewayOpenPrint");
						break;
					case "UserTaskPrintOpenWindow":
							e.Context.QueueTasks.Enqueue("ScriptTaskClearPrintUserContext");
						break;
					case "ExclusiveGatewayOpenPrint":
						if (SequenceFlow297ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("UserTaskPrintOpenWindow");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptDefOperPrintWindow");
						break;
					case "ScriptDefOperPrintWindow":
						break;
					case "SubProcess4":
						break;
					case "DeleteYesMessage":
						e.Context.QueueTasks.Enqueue("ScriptDeleteYesMessage");
						break;
					case "ScriptDeleteYesMessage":
						break;
					case "CreateMSWordReportMessageEventSubProcess":
						break;
					case "CreateMSWordReportMessageStartMessage":
						e.Context.QueueTasks.Enqueue("CreateMSWordReportMessageScriptTask");
						break;
					case "CreateMSWordReportMessageScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway33453453456789789783434535");
						break;
					case "ShowMSWordReportCreatedScriptTask":
						e.Context.QueueTasks.Enqueue("ShowMSWordReportCreatedUserTask");
						break;
					case "ShowMSWordReportCreatedUserTask":
						break;
					case "ExclusiveGateway33453453456789789783434535":
						if (ConditionalFlow156757575757234242424ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("End1345345897809780343535");
							break;
						}
						e.Context.QueueTasks.Enqueue("ShowMSWordReportCreatedScriptTask");
						break;
					case "End1345345897809780343535":
						break;
					case "SaveReportToLocalDiskEventSubProcess":
						break;
					case "SaveReportToLocalDiskStartMessage":
						e.Context.QueueTasks.Enqueue("SaveReportToLocalDiskScriptTask");
						break;
					case "SaveReportToLocalDiskScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "ThrowEditButtonClick":
						break;
					case "TreeGridDblClick":
						e.Context.QueueTasks.Enqueue("ThrowEditButtonClick");
						break;
					case "EventSubProcess2":
						break;
					case "StartMessageNonInterruptingEvent2":
						e.Context.QueueTasks.Enqueue("ScriptGridPageRefreshRow");
						break;
					case "ScriptGridPageRefreshRow":
						break;
					case "DataSourceActiveRowChangedEventSubProcess":
						break;
					case "DataSourceActiveRowChangedEvent":
						e.Context.QueueTasks.Enqueue("DataSourceActiveRowChangedScriptTask");
						break;
					case "DataSourceActiveRowChangedScriptTask":
						break;
					case "DataSourceLoadRowsResponseRegisteredEventSubProcess":
						break;
					case "DataSourceLoadRowsResponseRegisteredStartMessage":
						e.Context.QueueTasks.Enqueue("DataSourceLoadRowsResponseRegisteredScriptTask");
						break;
					case "DataSourceLoadRowsResponseRegisteredScriptTask":
						break;
					case "DataSourceLoadingSubProcess":
						break;
					case "DataSourceLoading":
						e.Context.QueueTasks.Enqueue("DataSourceLoadingScriptTask");
						break;
					case "DataSourceLoadingScriptTask":
						break;
					case "BasePrepareFiltersDataSourceSubProcess":
						break;
					case "StartMessageBasePrepareFilters":
						e.Context.QueueTasks.Enqueue("ScriptTaskSendMessageBasePrepareFilter");
						break;
					case "ScriptTaskSendMessageBasePrepareFilter":
						e.Context.QueueTasks.Enqueue("ScriptCreateDemoFilters");
						break;
					case "ScriptCreateDemoFilters":
						break;
					case "EventSubProcessInitializeFilterEdit":
						break;
					case "StartMessageInitializeFilterEdit":
						e.Context.QueueTasks.Enqueue("ScriptInitializeFilterEdit");
						break;
					case "ScriptInitializeFilterEdit":
						break;
					case "EventSubProcessClearData":
						break;
					case "StartClearData":
						e.Context.QueueTasks.Enqueue("ScriptClearData");
						break;
					case "ScriptClearData":
						break;
					case "SubProcessSelectFolder":
						break;
					case "SelectFolder":
						e.Context.QueueTasks.Enqueue("ScriptSelectFolder");
						break;
					case "ScriptSelectFolder":
						break;
					case "SubProcess1":
						break;
					case "ApplySearchFilter":
						e.Context.QueueTasks.Enqueue("ScriptApplySearchFilter");
						break;
					case "ScriptApplySearchFilter":
						break;
					case "EventSubProcessRunModuleProcess":
						break;
					case "StartRunModuleProcess":
						e.Context.QueueTasks.Enqueue("ScriptRunModuleProcess");
						break;
					case "ScriptRunModuleProcess":
						break;
					case "EventSubProcessProcessPropsWindowClosed":
						break;
					case "StartProcessPropsWindowClosed":
						e.Context.QueueTasks.Enqueue("ScriptProcessPropsWindowClosed");
						break;
					case "ScriptProcessPropsWindowClosed":
						break;
					case "EventSubProcess1OpenProcessEdit":
						break;
					case "StartCreateNewProcessMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptCreateNewProcessMenuItemClick");
						break;
					case "ScriptCreateNewProcessMenuItemClick":
						e.Context.QueueTasks.Enqueue("OpenProcessEditUserTask");
						break;
					case "OpenProcessEditUserTask":
						break;
					case "EventSubProcessShowMessage":
						break;
					case "StartShowMessage":
						e.Context.QueueTasks.Enqueue("MessageWindowUserTask");
						break;
					case "MessageWindowUserTask":
						break;
					case "EventSubProcess1TuningModeChanged":
						break;
					case "StartTuningModeChanged":
						e.Context.QueueTasks.Enqueue("ScriptTuningModeChanged");
						break;
					case "ScriptTuningModeChanged":
						break;
					case "CreateNewSysModuleReportMenuItemClickEventSubProcess":
						break;
					case "StartMessageCreateNewSysModuleReportMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskCreateNewSysModuleReportMenuItemClick");
						break;
					case "ScriptTaskCreateNewSysModuleReportMenuItemClick":
						e.Context.QueueTasks.Enqueue("CreateNewSysModuleReportMenuItemClickUserTask");
						break;
					case "CreateNewSysModuleReportMenuItemClickUserTask":
						break;
					case "SysModuleReportPropsWindowClosedEventSubProcess":
						break;
					case "SysModuleReportPropsWindowClosedStartMessage":
						e.Context.QueueTasks.Enqueue("SysModuleReportPropsWindowClosedScriptTask");
						break;
					case "SysModuleReportPropsWindowClosedScriptTask":
						break;
					case "SetDetailPrintButtonMenuEventSubProcess1":
						break;
					case "SetDetailPrintButtonMenuStartMessage1":
						e.Context.QueueTasks.Enqueue("SetDetailPrintButtonMenuScriptTask1");
						break;
					case "SetDetailPrintButtonMenuScriptTask1":
						break;
					case "ShowChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken":
						e.Context.QueueTasks.Enqueue("ViewRecordAllChangesProcess");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow284ExpressionExecute() {
			return Convert.ToBoolean(NeedAddDetailRequest);
		}

		private bool SequenceFlow295ExpressionExecute() {
			return Convert.ToBoolean(!DefaultWay);
		}

		private bool SequenceFlow297ExpressionExecute() {
			return Convert.ToBoolean(PrintReportSchemaUId != Guid.Empty);
		}

		private bool ConditionalFlow28ExpressionExecute() {
			return Convert.ToBoolean(!DefaultWay);
		}

		private bool ConditionalFlow1retbbExpressionExecute() {
			return Convert.ToBoolean(Terrasoft.Configuration.CommunicationUtilities.GetSelectedCommunicationNumbers(UserConnection).Length == 1);
		}

		private bool ConditionalFlow1wwersExpressionExecute() {
			return Convert.ToBoolean(Terrasoft.Configuration.CommunicationUtilities.GetSelectedCommunicationNumbers(UserConnection).Length > 1);
		}

		private bool ConditionalFlow156757575757234242424ExpressionExecute() {
			return Convert.ToBoolean(!(bool)SysSettings.GetValue(UserConnection, "SaveWordReportAsRecordAttachment"));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage");
			ActivatedEventElements.Add("ProcessEmailContextItemClick_StartMessage");
			ActivatedEventElements.Add("ShowChangelogMenuItemClickStartMessage");
			ActivatedEventElements.Add("StartMessage1ddrrg");
			ActivatedEventElements.Add("ProcessCallContextItemClick_StartMessage");
			ActivatedEventElements.Add("NumberSelectedMessage");
			ActivatedEventElements.Add("SendTemplateEmailMenuItemPrepareMenuStartMessage");
			ActivatedEventElements.Add("ProcessEmailTemplateContextItemClickStartMessage");
			ActivatedEventElements.Add("BaseGridPageInitStartMessage");
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("AddButtonClick");
			ActivatedEventElements.Add("StartMessageAllowAddDetailMessage");
			ActivatedEventElements.Add("EditButtonClick");
			ActivatedEventElements.Add("DeleteButtonClick");
			ActivatedEventElements.Add("StartMessageCustomDeleteMessage");
			ActivatedEventElements.Add("CopyButtonClick");
			ActivatedEventElements.Add("DeleteNoMessage");
			ActivatedEventElements.Add("StartMessageOpenPrintReportMessage");
			ActivatedEventElements.Add("StartMessageOpenPrintReportButtonClick");
			ActivatedEventElements.Add("DeleteYesMessage");
			ActivatedEventElements.Add("CreateMSWordReportMessageStartMessage");
			ActivatedEventElements.Add("SaveReportToLocalDiskStartMessage");
			ActivatedEventElements.Add("TreeGridDblClick");
			ActivatedEventElements.Add("StartMessageNonInterruptingEvent2");
			ActivatedEventElements.Add("DataSourceActiveRowChangedEvent");
			ActivatedEventElements.Add("DataSourceLoadRowsResponseRegisteredStartMessage");
			ActivatedEventElements.Add("DataSourceLoading");
			ActivatedEventElements.Add("StartMessageBasePrepareFilters");
			ActivatedEventElements.Add("StartMessageInitializeFilterEdit");
			ActivatedEventElements.Add("StartClearData");
			ActivatedEventElements.Add("SelectFolder");
			ActivatedEventElements.Add("ApplySearchFilter");
			ActivatedEventElements.Add("StartRunModuleProcess");
			ActivatedEventElements.Add("StartProcessPropsWindowClosed");
			ActivatedEventElements.Add("StartCreateNewProcessMenuItemClick");
			ActivatedEventElements.Add("StartShowMessage");
			ActivatedEventElements.Add("StartTuningModeChanged");
			ActivatedEventElements.Add("StartMessageCreateNewSysModuleReportMenuItemClick");
			ActivatedEventElements.Add("SysModuleReportPropsWindowClosedStartMessage");
			ActivatedEventElements.Add("SetDetailPrintButtonMenuStartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1_BaseGridPage":
					context.QueueTasks.Dequeue();
					break;
				case "SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage";
					result = SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage.Execute(context);
					break;
				case "CreateEmailCustomContextMenu_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateEmailCustomContextMenu_ScriptTask";
					result = CreateEmailCustomContextMenu_ScriptTask.Execute(context, CreateEmailCustomContextMenu_ScriptTaskExecute);
					break;
				case "EventSubProcess8_BaseGridPage":
					context.QueueTasks.Dequeue();
					break;
				case "ProcessEmailContextItemClick_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessEmailContextItemClick_StartMessage";
					result = ProcessEmailContextItemClick_StartMessage.Execute(context);
					break;
				case "ProcessEmailContextMenuClick_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessEmailContextMenuClick_ScriptTask";
					result = ProcessEmailContextMenuClick_ScriptTask.Execute(context, ProcessEmailContextMenuClick_ScriptTaskExecute);
					break;
				case "OpenEmailEditPage_BaseGridPage_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenEmailEditPage_BaseGridPage_UserTask";
					result = OpenEmailEditPage_BaseGridPage_UserTask.Execute(context);
					break;
				case "EventSubProcess12539":
					context.QueueTasks.Dequeue();
					break;
				case "ViewRecordAllChangesProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "ViewRecordAllChangesProcess";
					result = ViewRecordAllChangesProcess.Execute(context);
					break;
				case "ShowChangelogMenuItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowChangelogMenuItemClickScriptTask";
					result = ShowChangelogMenuItemClickScriptTask.Execute(context, ShowChangelogMenuItemClickScriptTaskExecute);
					break;
				case "ShowChangelogMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowChangelogMenuItemClickStartMessage";
					result = ShowChangelogMenuItemClickStartMessage.Execute(context);
					break;
				case "EventSubProcess1werwe":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1ddrrg":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1ddrrg";
					result = StartMessage1ddrrg.Execute(context);
					break;
				case "CreateCallCustomContextMenu_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateCallCustomContextMenu_ScriptTask";
					result = CreateCallCustomContextMenu_ScriptTask.Execute(context, CreateCallCustomContextMenu_ScriptTaskExecute);
					break;
				case "EventSubProcess1bghhj":
					context.QueueTasks.Dequeue();
					break;
				case "ProcessCallContextItemClick_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessCallContextItemClick_StartMessage";
					result = ProcessCallContextItemClick_StartMessage.Execute(context);
					break;
				case "ProcessCallContextMenuItemClick_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessCallContextMenuItemClick_ScriptTask";
					result = ProcessCallContextMenuItemClick_ScriptTask.Execute(context, ProcessCallContextMenuItemClick_ScriptTaskExecute);
					break;
				case "NumberSelectedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "NumberSelectedMessage";
					result = NumberSelectedMessage.Execute(context);
					break;
				case "ExclusiveGateway3wwwcc":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3wwwcc";
					result = ExclusiveGateway3wwwcc.Execute(context);
					break;
				case "NotifyCtiPanelCallMessage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "NotifyCtiPanelCallMessage_ScriptTask";
					result = NotifyCtiPanelCallMessage_ScriptTask.Execute(context, NotifyCtiPanelCallMessage_ScriptTaskExecute);
					break;
				case "ShowNoPhoneNumbersUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowNoPhoneNumbersUserTask";
					result = ShowNoPhoneNumbersUserTask.Execute(context);
					break;
				case "ProcessCallContextMenuItemClick_ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessCallContextMenuItemClick_ScriptTask3";
					result = ProcessCallContextMenuItemClick_ScriptTask3.Execute(context, ProcessCallContextMenuItemClick_ScriptTask3Execute);
					break;
				case "OpenSelectNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenSelectNumberUserTask";
					result = OpenSelectNumberUserTask.Execute(context);
					break;
				case "SendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SendTemplateEmailMenuItemPrepareMenuStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SendTemplateEmailMenuItemPrepareMenuStartMessage";
					result = SendTemplateEmailMenuItemPrepareMenuStartMessage.Execute(context);
					break;
				case "CreateTemplateEmailCustomContextMenu_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateTemplateEmailCustomContextMenu_ScriptTask";
					result = CreateTemplateEmailCustomContextMenu_ScriptTask.Execute(context, CreateTemplateEmailCustomContextMenu_ScriptTaskExecute);
					break;
				case "ProcessEmailTemplateContextItemClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ProcessEmailTemplateContextItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessEmailTemplateContextItemClickStartMessage";
					result = ProcessEmailTemplateContextItemClickStartMessage.Execute(context);
					break;
				case "ProcessEmailTemplateContextItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessEmailTemplateContextItemClickScriptTask";
					result = ProcessEmailTemplateContextItemClickScriptTask.Execute(context, ProcessEmailTemplateContextItemClickScriptTaskExecute);
					break;
				case "BaseGridPageInit":
					context.QueueTasks.Dequeue();
					break;
				case "BaseGridPageInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseGridPageInitStartMessage";
					result = BaseGridPageInitStartMessage.Execute(context);
					break;
				case "ScriptTaskBaseGridPageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskBaseGridPageInit";
					result = ScriptTaskBaseGridPageInit.Execute(context, ScriptTaskBaseGridPageInitExecute);
					break;
				case "InitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit":
					context.QueueTasks.Dequeue();
					result = InitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit.Execute(context);
					break;
				case "PageLoadCompleteEventSubProcess":
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
				case "ScriptTaskCheckMenuItem":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskCheckMenuItem";
					result = ScriptTaskCheckMenuItem.Execute(context, ScriptTaskCheckMenuItemExecute);
					break;
				case "ScriptRegisterClientScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptRegisterClientScript";
					result = ScriptRegisterClientScript.Execute(context, ScriptRegisterClientScriptExecute);
					break;
				case "LoadPrintReportButtonMenuProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "LoadPrintReportButtonMenuProcess";
					result = LoadPrintReportButtonMenuProcess.Execute(context);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "AddButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClick";
					result = AddButtonClick.Execute(context);
					break;
				case "ScriptAddButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAddButtonClick";
					result = ScriptAddButtonClick.Execute(context, ScriptAddButtonClickExecute);
					break;
				case "ScriptSetDefValues":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSetDefValues";
					result = ScriptSetDefValues.Execute(context, ScriptSetDefValuesExecute);
					break;
				case "ScriptTaskSendAllowRequest":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSendAllowRequest";
					result = ScriptTaskSendAllowRequest.Execute(context, ScriptTaskSendAllowRequestExecute);
					break;
				case "StartMessageAllowAddDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAllowAddDetailMessage";
					result = StartMessageAllowAddDetailMessage.Execute(context);
					break;
				case "GatewayCheckAlloAddDetail":
					context.QueueTasks.Dequeue();
					context.SenderName = "GatewayCheckAlloAddDetail";
					result = GatewayCheckAlloAddDetail.Execute(context);
					break;
				case "UserTaskAddOpenWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskAddOpenWindow";
					result = UserTaskAddOpenWindow.Execute(context);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "EditButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditButtonClick";
					result = EditButtonClick.Execute(context);
					break;
				case "ScriptEditButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptEditButtonClick";
					result = ScriptEditButtonClick.Execute(context, ScriptEditButtonClickExecute);
					break;
				case "UserTaskEditOpenWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskEditOpenWindow";
					result = UserTaskEditOpenWindow.Execute(context);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "ScriptDefEditScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDefEditScript";
					result = ScriptDefEditScript.Execute(context, ScriptDefEditScriptExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptDeleteButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDeleteButtonClick";
					result = ScriptDeleteButtonClick.Execute(context, ScriptDeleteButtonClickExecute);
					break;
				case "UserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserMessage";
					result = UserMessage.Execute(context);
					break;
				case "DeleteButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClick";
					result = DeleteButtonClick.Execute(context);
					break;
				case "StartMessageCustomDeleteMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageCustomDeleteMessage";
					result = StartMessageCustomDeleteMessage.Execute(context);
					break;
				case "ScriptTaskCustomDeleteMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskCustomDeleteMessage";
					result = ScriptTaskCustomDeleteMessage.Execute(context, ScriptTaskCustomDeleteMessageExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "CopyButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "CopyButtonClick";
					result = CopyButtonClick.Execute(context);
					break;
				case "ScriptCopyButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptCopyButtonClick";
					result = ScriptCopyButtonClick.Execute(context, ScriptCopyButtonClickExecute);
					break;
				case "UserTaskOpenCopyEditPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskOpenCopyEditPage";
					result = UserTaskOpenCopyEditPage.Execute(context);
					break;
				case "ScriptDefCopyButton":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDefCopyButton";
					result = ScriptDefCopyButton.Execute(context, ScriptDefCopyButtonExecute);
					break;
				case "ExclusiveGatewayCopyOpenWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGatewayCopyOpenWindow";
					result = ExclusiveGatewayCopyOpenWindow.Execute(context);
					break;
				case "SubProcess5":
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
				case "SubProcessOpenPrintReport":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageOpenPrintReportMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageOpenPrintReportMessage";
					result = StartMessageOpenPrintReportMessage.Execute(context);
					break;
				case "ScriptTaskPrepareParametersOpenPrintReport":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPrepareParametersOpenPrintReport";
					result = ScriptTaskPrepareParametersOpenPrintReport.Execute(context, ScriptTaskPrepareParametersOpenPrintReportExecute);
					break;
				case "ScriptTaskClearPrintUserContext":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskClearPrintUserContext";
					result = ScriptTaskClearPrintUserContext.Execute(context, ScriptTaskClearPrintUserContextExecute);
					break;
				case "StartMessageOpenPrintReportButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageOpenPrintReportButtonClick";
					result = StartMessageOpenPrintReportButtonClick.Execute(context);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ScriptTaskSetReportOptions":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSetReportOptions";
					result = ScriptTaskSetReportOptions.Execute(context, ScriptTaskSetReportOptionsExecute);
					break;
				case "UserTaskPrintOpenWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskPrintOpenWindow";
					result = UserTaskPrintOpenWindow.Execute(context);
					break;
				case "ExclusiveGatewayOpenPrint":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGatewayOpenPrint";
					result = ExclusiveGatewayOpenPrint.Execute(context);
					break;
				case "ScriptDefOperPrintWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDefOperPrintWindow";
					result = ScriptDefOperPrintWindow.Execute(context, ScriptDefOperPrintWindowExecute);
					break;
				case "SubProcess4":
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
				case "CreateMSWordReportMessageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CreateMSWordReportMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateMSWordReportMessageStartMessage";
					result = CreateMSWordReportMessageStartMessage.Execute(context);
					break;
				case "CreateMSWordReportMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateMSWordReportMessageScriptTask";
					result = CreateMSWordReportMessageScriptTask.Execute(context, CreateMSWordReportMessageScriptTaskExecute);
					break;
				case "ShowMSWordReportCreatedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMSWordReportCreatedScriptTask";
					result = ShowMSWordReportCreatedScriptTask.Execute(context, ShowMSWordReportCreatedScriptTaskExecute);
					break;
				case "ShowMSWordReportCreatedUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMSWordReportCreatedUserTask";
					result = ShowMSWordReportCreatedUserTask.Execute(context);
					break;
				case "ExclusiveGateway33453453456789789783434535":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway33453453456789789783434535";
					result = ExclusiveGateway33453453456789789783434535.Execute(context);
					break;
				case "End1345345897809780343535":
					context.QueueTasks.Dequeue();
					break;
				case "SaveReportToLocalDiskEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SaveReportToLocalDiskStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveReportToLocalDiskStartMessage";
					result = SaveReportToLocalDiskStartMessage.Execute(context);
					break;
				case "SaveReportToLocalDiskScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveReportToLocalDiskScriptTask";
					result = SaveReportToLocalDiskScriptTask.Execute(context, SaveReportToLocalDiskScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "ThrowEditButtonClick":
					context.QueueTasks.Dequeue();
					result = ThrowEditButtonClick.Execute(context);
					break;
				case "TreeGridDblClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClick";
					result = TreeGridDblClick.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageNonInterruptingEvent2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageNonInterruptingEvent2";
					result = StartMessageNonInterruptingEvent2.Execute(context);
					break;
				case "ScriptGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGridPageRefreshRow";
					result = ScriptGridPageRefreshRow.Execute(context, ScriptGridPageRefreshRowExecute);
					break;
				case "DataSourceActiveRowChangedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceActiveRowChangedEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceActiveRowChangedEvent";
					result = DataSourceActiveRowChangedEvent.Execute(context);
					break;
				case "DataSourceActiveRowChangedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceActiveRowChangedScriptTask";
					result = DataSourceActiveRowChangedScriptTask.Execute(context, DataSourceActiveRowChangedScriptTaskExecute);
					break;
				case "DataSourceLoadRowsResponseRegisteredEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoadRowsResponseRegisteredStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadRowsResponseRegisteredStartMessage";
					result = DataSourceLoadRowsResponseRegisteredStartMessage.Execute(context);
					break;
				case "DataSourceLoadRowsResponseRegisteredScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadRowsResponseRegisteredScriptTask";
					result = DataSourceLoadRowsResponseRegisteredScriptTask.Execute(context, DataSourceLoadRowsResponseRegisteredScriptTaskExecute);
					break;
				case "DataSourceLoadingSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoading":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoading";
					result = DataSourceLoading.Execute(context);
					break;
				case "DataSourceLoadingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadingScriptTask";
					result = DataSourceLoadingScriptTask.Execute(context, DataSourceLoadingScriptTaskExecute);
					break;
				case "BasePrepareFiltersDataSourceSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageBasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageBasePrepareFilters";
					result = StartMessageBasePrepareFilters.Execute(context);
					break;
				case "ScriptTaskSendMessageBasePrepareFilter":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSendMessageBasePrepareFilter";
					result = ScriptTaskSendMessageBasePrepareFilter.Execute(context, ScriptTaskSendMessageBasePrepareFilterExecute);
					break;
				case "ScriptCreateDemoFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptCreateDemoFilters";
					result = ScriptCreateDemoFilters.Execute(context, ScriptCreateDemoFiltersExecute);
					break;
				case "EventSubProcessInitializeFilterEdit":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageInitializeFilterEdit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageInitializeFilterEdit";
					result = StartMessageInitializeFilterEdit.Execute(context);
					break;
				case "ScriptInitializeFilterEdit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInitializeFilterEdit";
					result = ScriptInitializeFilterEdit.Execute(context, ScriptInitializeFilterEditExecute);
					break;
				case "EventSubProcessClearData":
					context.QueueTasks.Dequeue();
					break;
				case "StartClearData":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartClearData";
					result = StartClearData.Execute(context);
					break;
				case "ScriptClearData":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptClearData";
					result = ScriptClearData.Execute(context, ScriptClearDataExecute);
					break;
				case "SubProcessSelectFolder":
					context.QueueTasks.Dequeue();
					break;
				case "SelectFolder":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectFolder";
					result = SelectFolder.Execute(context);
					break;
				case "ScriptSelectFolder":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSelectFolder";
					result = ScriptSelectFolder.Execute(context, ScriptSelectFolderExecute);
					break;
				case "SubProcess1":
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
				case "EventSubProcessProcessPropsWindowClosed":
					context.QueueTasks.Dequeue();
					break;
				case "StartProcessPropsWindowClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartProcessPropsWindowClosed";
					result = StartProcessPropsWindowClosed.Execute(context);
					break;
				case "ScriptProcessPropsWindowClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptProcessPropsWindowClosed";
					result = ScriptProcessPropsWindowClosed.Execute(context, ScriptProcessPropsWindowClosedExecute);
					break;
				case "EventSubProcess1OpenProcessEdit":
					context.QueueTasks.Dequeue();
					break;
				case "StartCreateNewProcessMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartCreateNewProcessMenuItemClick";
					result = StartCreateNewProcessMenuItemClick.Execute(context);
					break;
				case "ScriptCreateNewProcessMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptCreateNewProcessMenuItemClick";
					result = ScriptCreateNewProcessMenuItemClick.Execute(context, ScriptCreateNewProcessMenuItemClickExecute);
					break;
				case "OpenProcessEditUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenProcessEditUserTask";
					result = OpenProcessEditUserTask.Execute(context);
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
				case "EventSubProcess1TuningModeChanged":
					context.QueueTasks.Dequeue();
					break;
				case "StartTuningModeChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartTuningModeChanged";
					result = StartTuningModeChanged.Execute(context);
					break;
				case "ScriptTuningModeChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTuningModeChanged";
					result = ScriptTuningModeChanged.Execute(context, ScriptTuningModeChangedExecute);
					break;
				case "CreateNewSysModuleReportMenuItemClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageCreateNewSysModuleReportMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageCreateNewSysModuleReportMenuItemClick";
					result = StartMessageCreateNewSysModuleReportMenuItemClick.Execute(context);
					break;
				case "ScriptTaskCreateNewSysModuleReportMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskCreateNewSysModuleReportMenuItemClick";
					result = ScriptTaskCreateNewSysModuleReportMenuItemClick.Execute(context, ScriptTaskCreateNewSysModuleReportMenuItemClickExecute);
					break;
				case "CreateNewSysModuleReportMenuItemClickUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateNewSysModuleReportMenuItemClickUserTask";
					result = CreateNewSysModuleReportMenuItemClickUserTask.Execute(context);
					break;
				case "SysModuleReportPropsWindowClosedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysModuleReportPropsWindowClosedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysModuleReportPropsWindowClosedStartMessage";
					result = SysModuleReportPropsWindowClosedStartMessage.Execute(context);
					break;
				case "SysModuleReportPropsWindowClosedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysModuleReportPropsWindowClosedScriptTask";
					result = SysModuleReportPropsWindowClosedScriptTask.Execute(context, SysModuleReportPropsWindowClosedScriptTaskExecute);
					break;
				case "SetDetailPrintButtonMenuEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SetDetailPrintButtonMenuStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetDetailPrintButtonMenuStartMessage1";
					result = SetDetailPrintButtonMenuStartMessage1.Execute(context);
					break;
				case "SetDetailPrintButtonMenuScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetDetailPrintButtonMenuScriptTask1";
					result = SetDetailPrintButtonMenuScriptTask1.Execute(context, SetDetailPrintButtonMenuScriptTask1Execute);
					break;
				case "ShowChangelogMenuItemClickScriptTaskViewRecordAllChangesProcessToken":
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
				case "MailboxSyncSettingsLinkId":
					MailboxSyncSettingsLinkId = reader.GetValue<System.Guid>();
				break;
				case "MenuVideoHelpItemCaption":
					MenuVideoHelpItemCaption = reader.GetValue<System.String>();
				break;
				case "MenuHelpItemCaption":
					MenuHelpItemCaption = reader.GetValue<System.String>();
				break;
				case "SysModuleProcessPrimaryColumnUId":
					SysModuleProcessPrimaryColumnUId = reader.GetValue<System.Guid>();
				break;
				case "IsModuleProcessesTuningMode":
					IsModuleProcessesTuningMode = reader.GetValue<System.Boolean>();
				break;
				case "IsPrimaryGrid":
					IsPrimaryGrid = reader.GetValue<System.Boolean>();
				break;
				case "SelectedTypeId":
					SelectedTypeId = reader.GetValue<System.Guid>();
				break;
				case "PrintReportPageHelpContextId":
					PrintReportPageHelpContextId = reader.GetValue<System.String>();
				break;
				case "EditPageHelpContextId":
					EditPageHelpContextId = reader.GetValue<System.String>();
				break;
				case "IsContextHelpButtonInitialized":
					IsContextHelpButtonInitialized = reader.GetValue<System.Boolean>();
				break;
				case "UseModuleDetails":
					UseModuleDetails = reader.GetValue<System.Boolean>();
				break;
				case "SysModuleEditId":
					SysModuleEditId = reader.GetValue<System.Guid>();
				break;
				case "TypeEditPageUIds":
					TypeEditPageUIds = reader.GetSerializableObjectValue();
				break;
				case "TypeColumnUId":
					TypeColumnUId = reader.GetValue<System.Guid>();
				break;
				case "LocatedInEditPage":
					LocatedInEditPage = reader.GetValue<System.Boolean>();
				break;
				case "SynchronizeDataSourceStructure":
					SynchronizeDataSourceStructure = reader.GetValue<System.Boolean>();
				break;
				case "AddToMenuItemMoveTo":
					AddToMenuItemMoveTo = reader.GetValue<System.Boolean>();
				break;
				case "ListenerPageProcessUId":
					ListenerPageProcessUId = reader.GetValue<System.String>();
				break;
				case "DefaultWay":
					DefaultWay = reader.GetValue<System.Boolean>();
				break;
				case "ParentColumnMetaPath":
					ParentColumnMetaPath = reader.GetValue<System.String>();
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
				case "SysModuleId":
					SysModuleId = reader.GetValue<System.Guid>();
				break;
				case "NeedAddDetailRequest":
					NeedAddDetailRequest = reader.GetValue<System.Boolean>();
				break;
				case "CurrentGridSchemaName":
					CurrentGridSchemaName = reader.GetValue<System.String>();
				break;
				case "SelectedFolderId":
					SelectedFolderId = reader.GetValue<System.Guid>();
				break;
				case "DisableButtons":
					DisableButtons = reader.GetValue<System.Boolean>();
				break;
				case "IsSearch":
					IsSearch = reader.GetValue<System.Boolean>();
				break;
				case "IsDetailGrid":
					IsDetailGrid = reader.GetValue<System.Boolean>();
				break;
				case "DefValuesId":
					DefValuesId = reader.GetValue<System.Guid>();
				break;
				case "EditPageQueryStringAddition":
					EditPageQueryStringAddition = reader.GetValue<System.String>();
				break;
				case "SysEntitySchemaId":
					SysEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "SelectedNodePrimaryColumnValue":
					SelectedNodePrimaryColumnValue = reader.GetValue<System.Guid>();
				break;
				case "SysModuleDetailId":
					SysModuleDetailId = reader.GetValue<System.Guid>();
				break;
				case "ParentFieldName":
					ParentFieldName = reader.GetValue<System.String>();
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

		public virtual bool CreateEmailCustomContextMenu_ScriptTaskExecute(ProcessExecutingContext context) {
			var menuParentItem = (Page.SendEmailMenuItem as MenuItemBase);
			if (Ext.IsAjaxRequest) {
				ClearMenuItems(menuParentItem);
			}
			var contactSchemaId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			var employeeSchemaId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			var contactColumnCaptionValueMap = GetSchemasColumnList(new Guid[] { contactSchemaId, employeeSchemaId });
			if (contactColumnCaptionValueMap.Count > 0) {
				foreach (var columnCaption in contactColumnCaptionValueMap.Keys) {
					var menuItem = GetContextMenuItem("Mail", columnCaption, GetSchemaTag("Contact", contactColumnCaptionValueMap[columnCaption]));
					menuParentItem.Menu.Add(menuItem);
					(Page.AspPage as Terrasoft.UI.WebControls.Page).RegisterClientSpecialInitScript(string.Format("{0} = {{}};{0}.setImage = Ext.emptyFn;", menuItem.ClientID));
					menuParentItem.Menu.AddCaptionItem(menuItem);
				}
			}
			return true;
		}

		public virtual bool ProcessEmailContextMenuClick_ScriptTaskExecute(ProcessExecutingContext context) {
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			string tag = extraParams["tag"].ToString();
			
			OpenEmailEditPage_BaseGridPage_UserTask.OpenerInstanceId = Page.Process.InstanceUId;
			OpenEmailEditPage_BaseGridPage_UserTask.PageUId = new Guid("DCDDA065-321B-4560-AACB-05F6CC72CD80");
			Dictionary <string, string> parameters = new Dictionary <string, string>() {
				{"ContactId", ReadIdFromTag(tag, "ContactId").ToString()},
				{"TemplateId", ReadIdFromTag(tag, "TemplateId").ToString()},
				{"customClosedEvent", "EmailEditPageClosed"}
			};
			OpenEmailEditPage_BaseGridPage_UserTask.PageParameters = parameters;
			return true;
		}

		public virtual bool ShowChangelogMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			ViewRecordAllChangesProcess.ActiveTreeGridCurrentRowId = Page.DataSource.ActiveRowPrimaryColumnValue;
			ViewRecordAllChangesProcess.CurrentSchemaUId = Page.DataSource.Schema.UId;
			ViewRecordAllChangesProcess.FilterByChangeTracked = true;
			return true;
		}

		public virtual bool CreateCallCustomContextMenu_ScriptTaskExecute(ProcessExecutingContext context) {
			int menuItemIndex = Page.TreeGrid.Menu.IndexOf(Page.CallMenuItem);
			(Page.TreeGrid.Menu[menuItemIndex] as MenuItemBase).Menu.RemoveAll();
			var contactSchemaId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			var employeeSchemaId = new Guid("fb1c2bed-91d4-4b06-a28c-621a3d187008");
			var accountSchemaId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			if (Page.DataSource.Schema.UId == contactSchemaId) {
				var menuItem = GetContextMenuItem("Call", Page.DataSource.Schema.Caption, GetSchemaTag("Contact", Page.DataSource.ActiveRowPrimaryColumnValue));
				(Page.TreeGrid.Menu[menuItemIndex] as MenuItemBase).Menu.Add(menuItem);
				(Page.AspPage as Terrasoft.UI.WebControls.Page).RegisterClientSpecialInitScript(string.Format("{0} = {{}};{0}.setImage = Ext.emptyFn;", menuItem.ClientID));
				(Page.TreeGrid.Menu[menuItemIndex] as MenuItemBase).Menu.AddCaptionItem(menuItem);
			}
			if (Page.DataSource.Schema.UId == accountSchemaId) {
				var menuItem = GetContextMenuItem("Call", Page.DataSource.Schema.Caption, GetSchemaTag("Account", Page.DataSource.ActiveRowPrimaryColumnValue));
				(Page.TreeGrid.Menu[menuItemIndex] as MenuItemBase).Menu.Add(menuItem);
				(Page.AspPage as Terrasoft.UI.WebControls.Page).RegisterClientSpecialInitScript(string.Format("{0} = {{}};{0}.setImage = Ext.emptyFn;", menuItem.ClientID));
				(Page.TreeGrid.Menu[menuItemIndex] as MenuItemBase).Menu.AddCaptionItem(menuItem);
			}
			Dictionary<string, Guid> contactColumnCaptionValueMap = GetSchemasColumnList(new Guid[] { contactSchemaId, employeeSchemaId });
			if (contactColumnCaptionValueMap.Count > 0) {
				foreach (var columnCaption in contactColumnCaptionValueMap.Keys) {
					var menuItem = GetContextMenuItem("Call", columnCaption, GetSchemaTag("Contact", contactColumnCaptionValueMap[columnCaption]));
					(Page.TreeGrid.Menu[menuItemIndex] as MenuItemBase).Menu.Add(menuItem);
					(Page.AspPage as Terrasoft.UI.WebControls.Page).RegisterClientSpecialInitScript(string.Format("{0} = {{}};{0}.setImage = Ext.emptyFn;", menuItem.ClientID));
					(Page.TreeGrid.Menu[menuItemIndex] as MenuItemBase).Menu.AddCaptionItem(menuItem);
				}
			}
			Dictionary<string, Guid> accountColumnCaptionValueMap = GetSchemasColumnList(new Guid[] { accountSchemaId });
			if (accountColumnCaptionValueMap.Count > 0) {
				foreach (var columnCaption in accountColumnCaptionValueMap.Keys) {
					var menuItem = GetContextMenuItem("Call", columnCaption, GetSchemaTag("Account", accountColumnCaptionValueMap[columnCaption]));
					(Page.TreeGrid.Menu[menuItemIndex] as MenuItemBase).Menu.Add(menuItem);
					(Page.AspPage as Terrasoft.UI.WebControls.Page).RegisterClientSpecialInitScript(string.Format("{0} = {{}};{0}.setImage = Ext.emptyFn;", menuItem.ClientID));
					(Page.TreeGrid.Menu[menuItemIndex] as MenuItemBase).Menu.AddCaptionItem(menuItem);
				}
			}
			return true;
		}

		public virtual bool ProcessCallContextMenuItemClick_ScriptTaskExecute(ProcessExecutingContext context) {
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			string tag = extraParams["tag"].ToString();
			var contactId = ReadIdFromTag(tag, "ContactId");
			var accountId = ReadIdFromTag(tag, "AccountId");
			if (contactId != Guid.Empty) {
				Terrasoft.Configuration.CommunicationUtilities.SetSelectedCommunicationNumbers(UserConnection, GetContactPhoneNumbers(contactId));	
			}
			if (accountId != Guid.Empty) {
				Terrasoft.Configuration.CommunicationUtilities.SetSelectedCommunicationNumbers(UserConnection, GetAccountPhoneNumbers(accountId));	
			}
			return true;
		}

		public virtual bool NotifyCtiPanelCallMessage_ScriptTaskExecute(ProcessExecutingContext context) {
			var phoneNumbers = Terrasoft.Configuration.CommunicationUtilities.GetSelectedCommunicationNumbers(UserConnection) as string[];
			if (phoneNumbers.Length == 1) {
				string script = Terrasoft.Configuration.CommunicationUtilities.GetProcessConnectionAttemptScript(UserConnection, "Phone", phoneNumbers[0]);
				Page.AddScript(script);
			}
			return true;
		}

		public virtual bool ProcessCallContextMenuItemClick_ScriptTask3Execute(ProcessExecutingContext context) {
			OpenSelectNumberUserTask.PageUId = new Guid("88622c8c-a8c1-44eb-aa1a-f9deb654b655");
			OpenSelectNumberUserTask.OpenerInstanceId = InstanceUId;
			OpenSelectNumberUserTask.CloseMessage = "NumberSelected";
			return true;
		}

		public virtual bool CreateTemplateEmailCustomContextMenu_ScriptTaskExecute(ProcessExecutingContext context) {
			var menuParentItem = (Page.SendTemplateEmailMenuItem as MenuItemBase);
			if (Ext.IsAjaxRequest){
				ClearMenuItems(menuParentItem);
			}
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "EmailTemplate");
			esq.Cache = UserConnection.SessionCache.WithLocalCaching(TSConfiguration.CacheUtilities.EmailTemplateCacheGroup);
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddColumn("Name").OrderByAsc();
			esq.Filters.Add(
				esq.CreateFilterWithParameters(
					FilterComparisonType.Equal,
					"Object.Id",
					Page.DataSource.Schema.UId
				)
			);
			esq.Filters.Add(
				esq.CreateFilterWithParameters(
					FilterComparisonType.Equal,
					"Object.SysWorkspace.Id",
					UserConnection.Workspace.Id
				)
			);
			esq.CacheItemName = string.Format("EmailTemplate_{0}_{1}", Page.DataSource.Schema.UId, SysModuleId);
			var entityCollection = esq.GetEntityCollection(UserConnection);
			foreach(var entity in entityCollection) {
				var menuItem = GetContextMenuItem("EmailTemplate", entity.PrimaryDisplayColumnValue, GetSchemaTag("EmailTemplate", entity.PrimaryColumnValue));
				menuParentItem.Menu.Add(menuItem);
				(Page.AspPage as Terrasoft.UI.WebControls.Page).RegisterClientSpecialInitScript(string.Format("{0} = {{}};{0}.setImage = Ext.emptyFn;", menuItem.ClientID));
				menuParentItem.Menu.AddCaptionItem(menuItem);
			}
			return true;
		}

		public virtual bool ProcessEmailTemplateContextItemClickScriptTaskExecute(ProcessExecutingContext context) {
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			string tag = extraParams["tag"].ToString();
			var emailTemplateId = ReadIdFromTag(tag, "EmailTemplateId").ToString();
			var manager = Page.UserConnection.ProcessSchemaManager;
			var schema =  (ProcessSchema)manager.GetInstanceByName("SendEmailUsingTemplateProcess");
			if (schema == null) {	
				MessageWindowUserTask.MessageText = string.Format(ModuleProcessInstanceNotExistMessage, "SendEmailUsingTemplateProcess");
				MessageWindowUserTask.Page = Page;
				Page.ThrowEvent("ShowMessage");
				return true;
			}
			var moduleProcess = schema.CreateProcess(UserConnection);
			
			var dataSource = Page.DataSource;
			if (dataSource != null) {
				if (schema.Parameters.ExistsByName("ActiveRowPrimaryColumnValue")) {
					moduleProcess.SetPropertyValue("ActiveRowPrimaryColumnValue", dataSource.ActiveRowPrimaryColumnValue);
				}
				
				if (schema.Parameters.ExistsByName("EmailTemplateId")) {
					moduleProcess.SetPropertyValue("EmailTemplateId", new Guid(emailTemplateId));
				}
				
				if (schema.Parameters.ExistsByName("MailboxSyncSettingsLinkId")) {
					moduleProcess.SetPropertyValue("MailboxSyncSettingsLinkId", MailboxSyncSettingsLinkId);
				}
			}
			moduleProcess.Execute(Page.UserConnection);
			return true;
		}

		public virtual bool ScriptTaskBaseGridPageInitExecute(ProcessExecutingContext context) {
			if (SysModuleId == Guid.Empty) {
				SysModuleId = GetSysModuleId();
			}
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
			Page.DataSource.Loading += delegate(object sender, DataSourceEventArgs e) {
				DataSourceLoadingEventArgs = e;
				Page.ThrowEvent("DataSourceLoading");
			};
			Page.DataSource.Loaded += delegate(object sender, DataSourceEventArgs e) {
				context.ThrowEventArgs = e;
				ThrowEvent(context, "DataSourceLoadRows");
			};
			Page.DataSource.PrepareFilters += delegate(object sender, DataSourceEventArgs e) {
			  	Page.ThrowEvent("BasePrepareFilters");
			};
			Page.DataSource.LoadRowsResponseRegistered += delegate(object sender, DataSourceEventArgs e) {
				context.ThrowEventArgs = e;
				ThrowEvent(context, "DataSourceLoadRowsResponseRegistered");
			};
			
			var editPages = GetEditPages();
			if (TypeColumnUId != Guid.Empty && Page.DataSource.CurrentStructure.Columns.FindByMetaPath(TypeColumnUId.ToString()) == null) {
				var typeColumn = Page.DataSource.Schema.Columns.GetByUId(TypeColumnUId);
				var column = Page.DataSource.CurrentStructure.AddColumnByPath(typeColumn.Name);
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			foreach (var item in editPages) {
				var addMenuItem = CreateAddButtonMenuItem(item.Value, item.Key);
				Page.AddButton.Menu.Add(addMenuItem);
				if (!IsContextHelpButtonInitialized) {
					string formatString = "{0}.on('click', function(el) {{ {1} }}, this)";
					var parameters =  item.Key.Split('&');
					var typeEditPageUId = new Guid(parameters[0]);
					var typeEntityId = new Guid(parameters[1]);
					var typeEditPageUIds = TypeEditPageUIds as Dictionary<Guid, Dictionary<string, Guid>>;
					string script = GetRegisterAddPageScript(typeEditPageUId, typeEditPageUIds[typeEntityId]["SysModuleEditId"], typeEntityId);
					Page.AddScript(string.Format(formatString, addMenuItem.ClientID, script));		
				}
			}
			if (!IsContextHelpButtonInitialized) {
				if (!IsPrimaryGrid && IsLoggingEnabled()) {
					/*Page.TreeGrid.CustomConfig.Add(new ConfigItem("enableContextMenu", "false"));
					Page.AddScript(string.Format("{0}.contextMenuId = '{1}_menu';window['{1}_menu'] = {1}.menu;{0}.enableContextMenu = true;{0}.initContextMenu();", Page.TreeGrid.ClientID, Page.ContextMenuButton.ClientID));*/
					Page.TreeGrid.AjaxEvents.ContextMenu.OnClientEvent = string.Format("function() {{ {0}.setVisible(true); }}();", Page.ShowChangelogMenuItem.ClientID);
				}
			}
			if (!IsContextHelpButtonInitialized || Page.PageContainer.CreatedByAjax) {
				InitializeContextHelpButton();
				IsContextHelpButtonInitialized = true;
			}
			
			return true;
		}

		public virtual bool ScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			LoadViewFilters(false);
			if (SynchronizeDataSourceStructure) {
				EntityDataSourceUtilities.SynchronizeStructure(Page.DataSource);
			}
			EditPageHelpContextId = ((Terrasoft.UI.WebControls.WebControl)Page.PageContainer).HelpContextId;
			IsLoggingEnabled();
			Page.CallMenuItem.Hidden = true;//!Terrasoft.Configuration.MsgServiceUtilities.CanUseMsgService(UserConnection);
			if (IsPrimaryGrid) {
				FillProcessMenu();
			}
			
			MessagePanel messagePanel = ControlUtilities.FindControl(
					Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				MailboxSyncSettingsLinkId = Guid.NewGuid();
				messagePanel.Links.Add(new Terrasoft.UI.WebControls.Controls.LinkConfig {
					Url = new Uri(Page.Request.Url, 
						string.Format("ViewPage.aspx?Id=c8ce13a0-3836-4ba7-b389-4b9e2014013c&userId={0}", UserConnection.CurrentUser.Id)).ToString(),	
					LinkId = MailboxSyncSettingsLinkId.ToString(),
					Caption = SetSettingsNow
				});
			}
			return true;
		}

		public virtual bool ScriptTaskCheckMenuItemExecute(ProcessExecutingContext context) {
			if (!IsDetailGrid) {
				FillPrintMenu();
				if (Page.PrintButton.Menu.Count > 0) {
					Page.PrintButton.Hidden = false;
				}
			}
			return true;
		}

		public virtual bool ScriptRegisterClientScriptExecute(ProcessExecutingContext context) {
			string formatString = "{0}.on('click', function(el) {{ {1} }}, this)";
			string script = GetRegisterQuestionScript();
			if (!string.IsNullOrEmpty(script)) {	
				Page.AddScript(string.Format(formatString, Page.DeleteButton.ClientID, script));
			}
			if (TypeColumnUId != Guid.Empty) {
				var typeColumnName = Page.DataSource.Schema.Columns.GetByUId(TypeColumnUId).ColumnValueName;
				// Page.AddScript(string.Format("{0}.setCustomData('typeColumnName', '{1}');", Page.AddButton.ClientID, typeColumnName));
				string tempDataKey = "tempData";
				var AspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
				if (!AspPage.CustomData.ContainsKey(tempDataKey)) {
					AspPage.CustomData.Add(tempDataKey, new JObject());
				}
				var tempData = AspPage.CustomData[tempDataKey] as JObject;
				JObject data = null;		
				if (tempData[Page.AddButton.ClientID] != null) {
					data = tempData[Page.AddButton.ClientID] as JObject;
				} else {
					data = new JObject();
				}		
				data["typeColumnName"] = new JValue(typeColumnName);
				tempData[Page.AddButton.ClientID] = data;		
				AspPage.CustomData[tempDataKey] = tempData;
				
			} else {
				script = GetRegisterAddPageScript(EditPageUId, SysModuleEditId, Guid.Empty);	
				if (!string.IsNullOrEmpty(script)) {
					Page.AddScript(string.Format(formatString, Page.AddButton.ClientID, script));
				}
			}
			script = GetRegisterEditPageScript(EditPageUId, SysModuleEditId);
			script = GetRegisterTreeGridDblClickScript(script);
			if (!string.IsNullOrEmpty(script)) {
				Page.AddScript(string.Format("{0}.on('dblclick', function(el) {{ {1} }}, this)", Page.TreeGrid.ClientID, script));
			}
			script = GetRegisterEditPageScript(EditPageUId, SysModuleEditId);
			if (!string.IsNullOrEmpty(script)) {
				Page.AddScript(string.Format(formatString, Page.EditButton.ClientID, script));
			}
			script = GetRegisterCopyPageScript(EditPageUId, SysModuleEditId);
			if (!string.IsNullOrEmpty(script)) {
				Page.AddScript(string.Format(formatString, Page.CopyButton.ClientID, script));
			}
			return true;
		}

		public virtual bool ScriptAddButtonClickExecute(ProcessExecutingContext context) {
			PrepareOpenEditPageParameters();
			return true;
		}

		public virtual bool ScriptSetDefValuesExecute(ProcessExecutingContext context) {
			GetDefValues();
			return true;
		}

		public virtual bool ScriptTaskSendAllowRequestExecute(ProcessExecutingContext context) {
			ListenerThrowEvent(ListenerPageProcessUId, "RequestAddDetailMessage");
			return true;
		}

		public virtual bool ScriptEditButtonClickExecute(ProcessExecutingContext context) {
			PrepareOpenModuleEditPageParameters();
			return true;
		}

		public virtual bool ScriptDefEditScriptExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptDeleteButtonClickExecute(ProcessExecutingContext context) {
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

		public virtual bool ScriptTaskCustomDeleteMessageExecute(ProcessExecutingContext context) {
			CustomDelete();
			return true;
		}

		public virtual bool ScriptCopyButtonClickExecute(ProcessExecutingContext context) {
			PrepareCopyOpenWindow();
			return true;
		}

		public virtual bool ScriptDefCopyButtonExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptDeleteNoMessageExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptTaskPrepareParametersOpenPrintReportExecute(ProcessExecutingContext context) {
			var contextParameters = context.ThrowEventArgs as Dictionary<string, object>;
			if (contextParameters.ContainsKey("tag")) {
				var parameters = contextParameters["tag"].ToString().Split('&');
				if (parameters.Length > 1) {
					PrintReportSchemaUId = new Guid(parameters[0]);
					PrintReportOptionsSchemaUId = new Guid(parameters[1]);
					PrintReportPageHelpContextId = parameters[2];
				}
			}
			return true;
		}

		public virtual bool ScriptTaskClearPrintUserContextExecute(ProcessExecutingContext context) {
			UserConnection.SessionData.Remove("PrintReportParameters");
			return true;
		}

		public virtual bool ScriptTaskSetReportOptionsExecute(ProcessExecutingContext context) {
			if (PrintReportSchemaUId == Guid.Empty) {
				return true;
			}
			UserTaskPrintOpenWindow.OpenerInstanceId = InstanceUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			UserTaskPrintOpenWindow.PageUId =  new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			var pageSchema = pageSchemaManager.GetInstanceByUId(UserTaskPrintOpenWindow.PageUId) as PageSchema;
			var parameters =  
			      new Dictionary<string, string> {
			            {"ReportSchemaUId", PrintReportSchemaUId.ToString()},
						{"EntitySchemaUId", Page.DataSource.Schema.UId.ToString()}
			      };
			if(PrintReportOptionsSchemaUId != Guid.Empty) {
				parameters.Add("OptionPageSchemaUId", PrintReportOptionsSchemaUId.ToString());
			}
			if(!string.IsNullOrEmpty(PrintReportPageHelpContextId)) {
				parameters.Add("HelpContextId", PrintReportPageHelpContextId);
			}
			UserTaskPrintOpenWindow.PageParameters = parameters;
			UserTaskPrintOpenWindow.Width = pageSchema.Width;
			UserTaskPrintOpenWindow.Height = pageSchema.Height;
			UserTaskPrintOpenWindow.Centered = true;
			UserTaskPrintOpenWindow.CloseOpenerOnLoad = false;
			var selectedRows = GetSelectedRows();
			UserConnection.SessionData[PrintReportSchemaUId.ToString() + "_SelectedActiveRows"] = selectedRows;
			UserConnection.SessionData.Remove(PrintReportSchemaUId.ToString() + "_OpenMode");
			UserConnection.SessionData[PrintReportSchemaUId.ToString() + "_SerializedFilters"] = GetSerializedFilters();
			return true;
		}

		public virtual bool ScriptDefOperPrintWindowExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptDeleteYesMessageExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count == 0) {
				return true;
			}
				
			string primaryRecordValue;
			var dataSource = Page.DataSource;
			bool includeDependencyMessage = false;
			bool includeRightLevelMessage = false;
			string warningMessageId = "WarningMessageId";
			var canDeleteRight = Terrasoft.Core.DB.SchemaRecordRightLevels.CanDelete;
			var canChangeDeleteRight = Terrasoft.Core.DB.SchemaRecordRightLevels.CanChangeDeleteRight;
			
			// Get message panel for current page
			MessagePanel messagePanel = ControlUtilities.FindControl(
				Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			
			// Remove message if it appeared before to avoid duplicating
			if (messagePanel != null) {
				messagePanel.Remove(warningMessageId);
			}
			
			// Remove selected nodes
			foreach (var node in selectedNodes) {
				primaryRecordValue = node.Values[Page.DataSource.Schema.PrimaryColumn.Name].ToString();
				var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
				var entitySchema = Page.DataSource.Schema;
				var rightLevel = dbSecurityEngine.GetEntitySchemaRecordRightLevel(
					entitySchema.Name, new Guid(primaryRecordValue));
				bool canChangeDelete = (rightLevel & canChangeDeleteRight) == canChangeDeleteRight;
				bool canDelete = (rightLevel & canDeleteRight) == canDeleteRight;
				if (canChangeDelete || canDelete) {
					try {
						dataSource.Remove(new Guid(primaryRecordValue));
					}
					catch (Exception e) {
						includeDependencyMessage = true;
					}
				} else {
					includeRightLevelMessage = true;
				}
			}	
			
			// Show appropriate message
			if (messagePanel != null) {
				string warningMessage = null;
				if (includeDependencyMessage && includeRightLevelMessage) {
					warningMessage = RightLevelDependencyWarningMessage;
				} else if (includeDependencyMessage) {
					warningMessage = DependencyWarningMessage;
				} else if (includeRightLevelMessage) {
					warningMessage = RightLevelWarningMessage;
				}
				if (warningMessage != null) {
					messagePanel.AddMessage(warningMessageId,
						Warning, warningMessage, MessageType.Warning);
				}
			}
			return true;
		}

		public virtual bool CreateMSWordReportMessageScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.TreeGrid.SelectedNodes.Count == 0) {
				return true;
			}
			var contextParameters = context.ThrowEventArgs as Dictionary<string, object>;
			if (contextParameters.ContainsKey("tag")) {
				var parameters = contextParameters["tag"].ToString().Split('&');
				if (parameters.Length > 0) {
					var reportId = new Guid(parameters[0]);
					var recordId = new Guid(Page.TreeGrid.SelectedNodes[0].Values["Id"].ToString());
					var wordReportUtility = new Terrasoft.Configuration.WordReportUtility(UserConnection);
					Guid fileId = wordReportUtility.GenerateReport(reportId, recordId);
					if (fileId == Guid.Empty) {
						return false;
					}
					var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
					aspPage.CustomData["ReportFileId"] = fileId;
				}
			}
			
			return true;
		}

		public virtual bool ShowMSWordReportCreatedScriptTaskExecute(ProcessExecutingContext context) {
			ShowMSWordReportCreatedUserTask.ProcessInstanceId = InstanceUId;
			ShowMSWordReportCreatedUserTask.MessageText = MSWordReportWasCreated;
			ShowMSWordReportCreatedUserTask.Icon = "INFO";
			ShowMSWordReportCreatedUserTask.Buttons = "OK";
			ShowMSWordReportCreatedUserTask.ResponseMessages = new Dictionary<string, string> {
				{"ok", "SaveReportToLocalDisk"}
			};
			ShowMSWordReportCreatedUserTask.PageParameters = new Dictionary<string, object> {
				{"IsUpload", true}
			};
			return true;
		}

		public virtual bool SaveReportToLocalDiskScriptTaskExecute(ProcessExecutingContext context) {
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			if (aspPage.CustomData["ReportFileId"] == null 
				|| string.IsNullOrEmpty(aspPage.CustomData["ReportFileId"].ToString())) {
				return true;
			}
			
			var fileId = new Guid(aspPage.CustomData["ReportFileId"].ToString());
			
			
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "File");
			var fileDataColumnName = entitySchemaQuery.AddColumn("Data").Name;
			var fileNameColumnName = entitySchemaQuery.AddColumn("Name").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				entitySchemaQuery.RootSchema.GetPrimaryColumnName(), fileId));
			var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (collection.Count == 0) {
				return true;
			}
			
			var currentRow = collection[0];
			var data = currentRow.GetBytesValue(fileDataColumnName) as byte[];
			var fileName = currentRow.GetTypedColumnValue<string>(fileNameColumnName);
			var Response = Page.Response;
			TSConfiguration.PageResponse.Write(Response, data, fileName, TSConfiguration.ContentType.XmlType);
			
			return true;
		}

		public virtual bool ScriptGridPageRefreshRowExecute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			var currentStructure = dataSource.CurrentStructure;
			var detailFilters = currentStructure.Filters.FindByName("DetailFilter");
			if (detailFilters != null) {
				currentStructure.Filters.Remove(detailFilters);
			}
			var searchFilters = currentStructure.Filters.FindByName("SearchFilter");
			if (searchFilters != null) {
				currentStructure.Filters.Remove(searchFilters);
			}
			var folderFilters = currentStructure.Filters.FindByName("FolderFilter");
			if (folderFilters != null) {
				currentStructure.Filters.Remove(folderFilters);
			}
			if(DataSourceFilter != null){
				currentStructure.Filters.Add((Terrasoft.UI.WebControls.Controls.IDataSourceFilterItem) DataSourceFilter);
			}
			DataSourceFilter = null;
			var treeGrid = Page.TreeGrid;
			treeGrid.Clear();
			DataSourceRequest request = Page.DataSource.Schema.HierarchyColumn == null ? null : new DataSourceRequest();
			Page.DataSource.LoadRows(request);
			if (DefValuesId != Guid.Empty && UserConnection.SessionData[DefValuesId.ToString()] != null) {
				UserConnection.SessionData.Remove(DefValuesId.ToString());
			}
			DefValuesId = Guid.Empty;
			return true;
		}

		public virtual bool DataSourceActiveRowChangedScriptTaskExecute(ProcessExecutingContext context) {
			ActivateButtons(true);
			ThrowEvent(context, "SendEmailMenuItemPrepareMenu");
			ThrowEvent(context, "SendTemplateEmailMenuItemPrepareMenu");
			if(IsDetailGrid) {
				return true;
			}
			ListenerThrowEvent(ListenerPageProcessUId, "GridActiveRowChanged");
			return true;
		}

		public virtual bool DataSourceLoadRowsResponseRegisteredScriptTaskExecute(ProcessExecutingContext context) {
			var dataSourceRowsCount = Page.DataSource.Rows.Count;
			Page.DataSource.SelectedItemPrimaryColumnValues.Clear();
			var activeRowUId = Guid.Empty;
			var eventArgs = (context.ThrowEventArgs as DataSourceEventArgs);
			if (eventArgs != null && eventArgs.Request.AlreadyContainsRows) {
				Page.DataSource.SetClientActiveRow(Page.DataSource.ActiveRowPrimaryColumnValue, true);
			    Page.DataSource.SelectedItemPrimaryColumnValues.Add(Page.DataSource.ActiveRowPrimaryColumnValue);
			    if (!IsDetailGrid) {
			                   SelectedNodePrimaryColumnValue = Page.DataSource.ActiveRowPrimaryColumnValue;
			                   ListenerThrowEvent(ListenerPageProcessUId, "GridLoadRows");
			                   ActivateButtons(true);
			    }
			} else {
				if (dataSourceRowsCount > 0) {
					var e = context.ThrowEventArgs as DataSourceEventArgs;
					if (e != null && e.Row != null) {
						activeRowUId = e.Row.PrimaryColumnValue;
					} else {
						activeRowUId = Page.DataSource.Rows[0].PrimaryColumnValue;
					}
					Page.DataSource.SetClientActiveRow(activeRowUId, true);
					Page.DataSource.SelectedItemPrimaryColumnValues.Add(
											Page.DataSource.ActiveRowPrimaryColumnValue);
				} else {
					Page.DataSource.SetClientActiveRow(activeRowUId, true);
				}
				if (!IsDetailGrid) {
					SelectedNodePrimaryColumnValue = activeRowUId;
					ListenerThrowEvent(ListenerPageProcessUId, "GridLoadRows");
				}
				ActivateButtons(dataSourceRowsCount > 0);
				if (dataSourceRowsCount > 0) {
					ThrowEvent(context, "SendEmailMenuItemPrepareMenu");
					ThrowEvent(context, "SendTemplateEmailMenuItemPrepareMenu");
				}
				else {
					ClearMenuItems(Page.SendEmailMenuItem);
					ClearMenuItems(Page.SendTemplateEmailMenuItem);
				}
			}
			return true;
		}

		public virtual bool DataSourceLoadingScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptTaskSendMessageBasePrepareFilterExecute(ProcessExecutingContext context) {
			if (!IsDetailGrid) {
				ListenerThrowEvent(ListenerPageProcessUId, "BasePrepareFilters");
			}
			return true;
		}

		public virtual bool ScriptCreateDemoFiltersExecute(ProcessExecutingContext context) {
			var userId = UserConnection.CurrentUser.Id;
			var contactId = UserConnection.CurrentUser.ContactId;
			var demoUsers = new Guid[] {
				new Guid("1B4B9325-66CC-DF11-9B2A-001D60E938C6"),
				new Guid("E19B3E68-F36B-1410-9693-20CF308CCEC3"),
				new Guid("64508C35-BC4B-E011-8617-00155D043204")
			};
			if (!demoUsers.Contains(userId)) {
				return true;
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
			return true;
		}

		public virtual bool ScriptInitializeFilterEditExecute(ProcessExecutingContext context) {
			var filterEditGroup = Page.DataSource.FindFiltersGroupByName("FilterEdit");
			if (filterEditGroup == null) {
				filterEditGroup = Page.DataSource.CreateFiltersGroup("FilterEdit");
				Page.DataSource.CurrentStructure.Filters.Add(filterEditGroup);
			}
			return true;
		}

		public virtual bool ScriptClearDataExecute(ProcessExecutingContext context) {
			ClearData();
			return true;
		}

		public virtual bool ScriptSelectFolderExecute(ProcessExecutingContext context) {
			if (!IsDetailGrid) {
				ListenerThrowEvent(ListenerPageProcessUId, "SelectFolder");
			}
			return true;
		}

		public virtual bool ScriptApplySearchFilterExecute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			var dataSourceFilter = (Terrasoft.UI.WebControls.Controls.IDataSourceFilterItem) DataSourceFilter;
			var currentStructure = dataSource.CurrentStructure;
			if(!object.ReferenceEquals(DataSourceFilter, null)) {	
				for(int i = 0; i < currentStructure.Filters.Count; i++) {
					if(!currentStructure.Filters[i].Name.Equals("SearchFilter")) {
						currentStructure.Filters[i].IsEnabled = false;
					} else {
						currentStructure.Filters[i] = dataSourceFilter;
					}
				}
				if(!currentStructure.Filters.Contains(dataSourceFilter)) {
					currentStructure.Filters.Add(dataSourceFilter);
				}
				IsSearch = true;
			} else {
				foreach (var filter in currentStructure.Filters) {
					if(!filter.Name.Equals("SearchFilter")) {	
						filter.IsEnabled = true;
					} else {
						filter.IsEnabled = false;
						IsSearch = false;
					}
				}
			}
			Page.TreeGrid.Clear();
			dataSource.LoadRows();
			Page.TreeGrid.MarkSummaryAsWrong();
			return true;
		}

		public virtual bool ScriptRunModuleProcessExecute(ProcessExecutingContext context) {
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			var processKey = new Guid(extraParams["tag"].ToString());
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
			
			if (schema.Parameters.ExistsByName("ActiveTreeGridClientId")) {
				moduleProcess.SetPropertyValue("ActiveTreeGridClientId", Page.TreeGrid.ClientID);
			}
			
			var dataSource = Page.DataSource;
			if (dataSource != null) {
				if (schema.Parameters.ExistsByName("ActiveTreeGridCurrentRowId")) {
					moduleProcess.SetPropertyValue("ActiveTreeGridCurrentRowId", dataSource.ActiveRowPrimaryColumnValue);
				}
					
				if (schema.Parameters.ExistsByName("TreeGridSelectedRowsIds")) {
					var idsCollection = dataSource.SelectedItemPrimaryColumnValues;
					var selectedRowsCount = idsCollection.Count;
					var propValue = new Guid[selectedRowsCount];
					for(var i = 0; i < selectedRowsCount; i++) 
						propValue[i] = idsCollection[i];
					moduleProcess.SetPropertyValue("TreeGridSelectedRowsIds", propValue);
				}
			}
			
			//Delete block 20.11.2012 
			/*if (schema.Parameters.ExistsByName("ActiveTreeGridSelectedNodesId")) {
			UserConnection.SessionData["MapSelectNodesId"] = null;
				var selectedNodes = Page.TreeGrid.SelectedNodes;
				if (selectedNodes.Count > 0) {
					var primaryRecordValues = new List<Guid>();
					foreach (var node in selectedNodes) {    
						var primaryRecordValue = node.Values["Id"].ToString();
						primaryRecordValues.Add(new Guid(primaryRecordValue));
						//primaryRecordValues.Add(new Guid(primaryRecordValue.ToString()));
					}
					UserConnection.SessionData["MapSelectNodesId"] = primaryRecordValues;
					moduleProcess.SetPropertyValue("ActiveTreeGridSelectedNodesId", primaryRecordValues);
				}
			}*/
			
			
			ModifyModuleProcessParameters(moduleProcess);
			moduleProcess.Execute(Page.UserConnection);
			return true;
		}

		public virtual bool ScriptProcessPropsWindowClosedExecute(ProcessExecutingContext context) {
			FillProcessMenu();
			return true;
		}

		public virtual bool ScriptCreateNewProcessMenuItemClickExecute(ProcessExecutingContext context) {
			OpenProcessEditUserTask.PageUId = new Guid("48bf8725-66d2-4e84-b1b2-a71d854f5993");
			OpenProcessEditUserTask.OpenerInstanceId = InstanceUId;
			OpenProcessEditUserTask.UseCurrentActivePage = true;
			OpenProcessEditUserTask.CloseMessage = "ProcessPropsWindowClosed";
			OpenProcessEditUserTask.PageParameters = new Dictionary<string, string> {
				{"signalName", "NewModuleProcessAdded"},
				{"ajaxEventTargetControl", Page.ActionButton.ClientID},
				{"SysModuleId", SysModuleId.ToString()}
			};
			return true;
		}

		public virtual bool ScriptTuningModeChangedExecute(ProcessExecutingContext context) {
			FillProcessMenu();
			FillPrintMenu();
			return true;
		}

		public virtual bool ScriptTaskCreateNewSysModuleReportMenuItemClickExecute(ProcessExecutingContext context) {
			CreateNewSysModuleReportMenuItemClickUserTask.PageUId = new Guid("23f6abcb-ef06-4e9d-b06d-c534e0e5ba29");
			CreateNewSysModuleReportMenuItemClickUserTask.OpenerInstanceId = InstanceUId;
			CreateNewSysModuleReportMenuItemClickUserTask.UseCurrentActivePage = true;
			CreateNewSysModuleReportMenuItemClickUserTask.CloseMessage = "SysModuleReportPropsWindowClosed";
			CreateNewSysModuleReportMenuItemClickUserTask.PageParameters = new Dictionary<string, string> {
				{"signalName", "NewModuleSysModuleReportAdded"},
				{"ajaxEventTargetControl", Page.PrintButton.ClientID},
				{"SysModuleId", SysModuleId.ToString()},
				{"ParentEntitySchemaId", Page.DataSource.SchemaUId.ToString()}
			};
			return true;
		}

		public virtual bool SysModuleReportPropsWindowClosedScriptTaskExecute(ProcessExecutingContext context) {
			FillPrintMenu();
			
			return true;
		}

		public virtual bool SetDetailPrintButtonMenuScriptTask1Execute(ProcessExecutingContext context) {
			if (IsDetailGrid) {
				FillPrintMenu();
				if (Page.PrintButton.Menu.Count > 0) {
					Page.PrintButton.Hidden = false;
				}
			}
			
			return true;
		}

		public virtual Guid SetDefValues() {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as 
				Terrasoft.Core.Entities.EntitySchemaManager;
			string detailSchemaName = UseModuleDetails ? "SysModuleDetailParentAssc" : "SysModuleEditDetailParentAssc";
			Terrasoft.Core.Entities.EntitySchema moduleDetailSchema = entitySchemaManager.GetInstanceByName(detailSchemaName);
			var detailAsscSchemaName = UseModuleDetails ? "SysModuleDetailParentAssc" : "SysModuleEditDetailParentAssc";
			var detailEntitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, detailAsscSchemaName);
			var parentColumnMetaPathColumn = detailEntitySchemaQuery.AddColumn("ParentColumnMetaPath");
			var columnMetaPathColumn = detailEntitySchemaQuery.AddColumn("ColumnMetaPath");
			string detailIdColumnName = UseModuleDetails ? "SysModuleDetail" : "SysModuleEditDetail";
			detailEntitySchemaQuery.Filters.Add(detailEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				detailIdColumnName, SysModuleDetailId));
			detailEntitySchemaQuery.Filters.Add(detailEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysParentAssociationType.Code", "DefValue"));
			var defValues = new Dictionary <string, object>();
			var defValuesCollection = detailEntitySchemaQuery.GetEntityCollection(UserConnection);
			if (defValuesCollection.Count > 0) {
				string columnMetaPath = string.Empty;
				string parentColumnMetaPath = string.Empty;
				var parentSchema = entitySchemaManager.GetInstanceByUId(SysEntitySchemaId);
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
			    	parentSchema.PrimaryColumn.Name, SelectedNodePrimaryColumnValue));
				EntityCollection entityCollection =   entitySchemaQuery.GetEntityCollection(Page.UserConnection);
				foreach (var column in entityCollectionColumns) {
					var columnValueName = entitySchemaQuery.GetSchema().Columns.GetByName(column.Value).ColumnValueName;
					defValues.Add(column.Key, entityCollection[0].GetColumnValue(columnValueName));
				}
			}
			var newGuid = Guid.NewGuid();
			UserConnection.SessionData[newGuid.ToString()] = defValues;
			return newGuid;
		}

		public virtual System.Collections.Generic.List<string> GetButtons() {
			var buttons = new System.Collections.Generic.List<string>();
			buttons.Add(Page.AddButton.Name);
			buttons.Add(Page.EditButton.Name);
			buttons.Add(Page.CopyButton.Name);
			buttons.Add(Page.DeleteButton.Name);
			buttons.Add(Page.PrintButton.Name);
			return buttons;
		}

		public virtual void CallRefreshDetails(Terrasoft.UI.WebControls.PageSchemaUserControl listenerPage) {
			if (!IsDetailGrid) {
				ListenerThrowEvent(ListenerPageProcessUId, "GridActiveRowChanged");
			}
		}

		public virtual void SetAdditionalDataSourceProperties() {
			return;
		}

		public virtual void PrepareOpenEditPageParameters() {
			string recordId = Guid.Empty.ToString();
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			UserTaskAddOpenWindow.OpenerInstanceId = InstanceUId;
			UserTaskAddOpenWindow.UseCurrentActivePage = true;
			UserTaskAddOpenWindow.PageUId = EditPageUId;
			var parameters =  
			      new Dictionary<string, string> {
			            {"recordId", recordId.ToString()},
			            {"entitySchemaUId", EntitySchemaUId.ToString()},
			            {"treeGridId", Page.TreeGrid.ClientID},
						{"SysModuleEditId", SysModuleEditId.ToString()}
			      };
			if (!IsDetailGrid && SysModuleId != Guid.Empty) {
				parameters.Add("SysModuleId", SysModuleId.ToString());
			}
			if (!LocatedInEditPage && !string.IsNullOrEmpty(ListenerPageProcessUId)) {
				var listenerPageProcess = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);	
				var mainPageProcessUId = listenerPageProcess.GetPropertyValue("MainPageProcessUId") != null ? listenerPageProcess.GetPropertyValue("MainPageProcessUId").ToString() : string.Empty;
				if (!string.IsNullOrEmpty(mainPageProcessUId)) {
					parameters.Add("mainPageProcessUId", mainPageProcessUId);	
				}	
			}
			if(DefValuesId != null && !DefValuesId.IsEmpty()) {
				parameters.Add("defValuesId", DefValuesId.ToString());
			}
			if(SelectedFolderId != null && !SelectedFolderId.Equals(Guid.Empty)) {
				parameters.Add("folderId", SelectedFolderId.ToString());
			}
			if (!string.IsNullOrEmpty(EditPageHelpContextId)) {
				parameters.Add("helpContextId", EditPageHelpContextId);
			}
			UserTaskAddOpenWindow.PageParameters = parameters;
			UserTaskAddOpenWindow.Centered = true;
			UserTaskAddOpenWindow.CloseOpenerOnLoad = false;
		}

		public virtual void PrepareOpenModuleEditPageParameters() {
			DefaultWay = true;
			var activeRowPrimaryColumnValue = Page.DataSource.ActiveRowPrimaryColumnValue;
			if (activeRowPrimaryColumnValue == Guid.Empty || activeRowPrimaryColumnValue == null) {
				return;
			}
			DefaultWay = false;
			if (TypeEditPageUIds != null && TypeColumnUId != Guid.Empty) {
				Dictionary<Guid, Dictionary<string, Guid>> typeEditPageUIds = TypeEditPageUIds as Dictionary<Guid, Dictionary<string, Guid>>;
				if (typeEditPageUIds != null) {
					var typeColumnValue = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>(Page.DataSource.Schema.Columns.GetByUId(TypeColumnUId));
					EditPageUId = typeEditPageUIds[typeColumnValue]["EditPageUId"];
					SysModuleEditId = typeEditPageUIds[typeColumnValue]["SysModuleEditId"];
				}
			}
			string recordId = activeRowPrimaryColumnValue.ToString();
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			UserTaskEditOpenWindow.OpenerInstanceId = InstanceUId;
			UserTaskEditOpenWindow.UseCurrentActivePage = true;
			UserTaskEditOpenWindow.PageUId = EditPageUId;
			var parameters =  
			      new Dictionary<string, string> {
			            {"recordId", recordId.ToString()},
			            {"entitySchemaUId", EntitySchemaUId.ToString()},
			            {"treeGridId", Page.TreeGrid.ClientID},
						{"SysModuleEditId", SysModuleEditId.ToString()}
			      };
			if (!IsDetailGrid && SysModuleId != Guid.Empty) {
				parameters.Add("SysModuleId", SysModuleId.ToString());
			}
			if (!LocatedInEditPage && !string.IsNullOrEmpty(ListenerPageProcessUId)) {
				var listenerPageProcess = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);	
				var mainPageProcessUId = listenerPageProcess.GetPropertyValue("MainPageProcessUId") != null ? listenerPageProcess.GetPropertyValue("MainPageProcessUId").ToString() : string.Empty;
				if (!string.IsNullOrEmpty(mainPageProcessUId)) {
					parameters.Add("mainPageProcessUId", mainPageProcessUId);	
				}
			}
			if(DefValuesId != null && !DefValuesId.IsEmpty()) {
				parameters.Add("defValuesId", DefValuesId.ToString());
			}
			if(SelectedFolderId != null && !SelectedFolderId.Equals(Guid.Empty)) {
				parameters.Add("folderId", SelectedFolderId.ToString());
			}
			if (!string.IsNullOrEmpty(EditPageHelpContextId)) {
				parameters.Add("helpContextId", EditPageHelpContextId);
			}
			UserTaskEditOpenWindow.PageParameters = parameters;
			UserTaskEditOpenWindow.Centered = true;
			UserTaskEditOpenWindow.CloseOpenerOnLoad = false;
		}

		public virtual Guid GetSysModuleId() {
			if (Page.DataSource.Schema != null) {
				var entitySchemaUId = Page.DataSource.Schema.UId;
				var primaryColumnName =  Page.DataSource.Schema.PrimaryColumn.Name; 
				var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
				entitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(string.Format(TSConfiguration.CacheUtilities.ModuleDataCacheGroup, entitySchemaUId));
				var primaryColumn = entitySchemaQuery.AddColumn("Id");
				EntitySchemaQueryFilterCollection filters = entitySchemaQuery.Filters;
				filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
													"SysModuleEntity.SysEntitySchemaUId", entitySchemaUId));
				entitySchemaQuery.CacheItemName = "BaseGridPage.GetSysModuleId_SysEntitySchemaId" + entitySchemaUId;
				var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entities.Count > 0) {
					return entities[0].GetTypedColumnValue<Guid>(primaryColumn.Name);
				}
			}
			return Guid.Empty;
		}

		public virtual object GetSelectedRows() {
			var primaryColumnName = Page.DataSource.CurrentStructure.PrimaryColumnName;
			var SelectedActiveRows = new List<Guid>();
			foreach(var selectedNode in Page.TreeGrid.SelectedNodes){
				SelectedActiveRows.Add(new Guid(selectedNode.Values[primaryColumnName].ToString()));
			}
			var selectedRows = new Dictionary<string, object>();
			selectedRows.Add("Item1", Page.DataSource.Schema.Name);
			selectedRows.Add("Item2", Page.DataSource.Schema.GetPrimaryColumnName());
			selectedRows.Add("Item3", SelectedActiveRows);
			return selectedRows;
		}

		public virtual void PrepareCopyOpenWindow() {
			if (TypeEditPageUIds != null && TypeColumnUId != Guid.Empty) {
				Dictionary<Guid, Dictionary<string, Guid>> typeEditPageUIds = TypeEditPageUIds as Dictionary<Guid, Dictionary<string, Guid>>;
				if (typeEditPageUIds != null) {
					var typeColumnValue = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>(Page.DataSource.Schema.Columns.GetByUId(TypeColumnUId));
					EditPageUId = typeEditPageUIds[typeColumnValue]["EditPageUId"];
					SysModuleEditId = typeEditPageUIds[typeColumnValue]["SysModuleEditId"];	
				}
			}
			DefaultWay = true;
			var activeRowPrimaryColumnValue = Page.DataSource.ActiveRowPrimaryColumnValue;
			if (activeRowPrimaryColumnValue == Guid.Empty || activeRowPrimaryColumnValue == null) {
				return;
			}
			DefaultWay = false;
			string recordId = activeRowPrimaryColumnValue.ToString();
			EntitySchemaUId = Page.DataSource.SchemaUId;
			var pageSchemaManager = Page.DataSource.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId) as PageSchema;
			UserTaskOpenCopyEditPage.OpenerInstanceId = InstanceUId;
			UserTaskOpenCopyEditPage.UseCurrentActivePage = true;
			UserTaskOpenCopyEditPage.PageUId = EditPageUId;
			var parameters = new Dictionary<string, string> {
			            {"recordId", recordId.ToString()},
			            {"entitySchemaUId", EntitySchemaUId.ToString()},
						{"Copy", "true"},
			            {"treeGridId", Page.TreeGrid.ClientID},
						{"SysModuleEditId", SysModuleEditId.ToString()}
			      };
			if (!IsDetailGrid && SysModuleId != Guid.Empty) {
				parameters.Add("SysModuleId", SysModuleId.ToString());
			}
			if (!LocatedInEditPage && !string.IsNullOrEmpty(ListenerPageProcessUId)) {
				var listenerPageProcess = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);	
				var mainPageProcessUId = listenerPageProcess.GetPropertyValue("MainPageProcessUId") != null ? listenerPageProcess.GetPropertyValue("MainPageProcessUId").ToString() : string.Empty;
				if (!string.IsNullOrEmpty(mainPageProcessUId)) {
					parameters.Add("mainPageProcessUId", mainPageProcessUId);	
				}
			}
			if(SelectedFolderId != null && !SelectedFolderId.Equals(Guid.Empty)) {
				parameters.Add("folderId", SelectedFolderId.ToString());
			}
			if (!string.IsNullOrEmpty(EditPageHelpContextId)) {
				parameters.Add("helpContextId", EditPageHelpContextId);
			}
			UserTaskOpenCopyEditPage.PageParameters = parameters;
			UserTaskOpenCopyEditPage.Centered = true;
			UserTaskOpenCopyEditPage.CloseOpenerOnLoad = false;
		}

		public virtual void GetDefValues() {
			if(IsDetailGrid) {
				if (DefValuesId.Equals(Guid.Empty)) {
					DefValuesId = SetDefValues();
				}
			}
			if (SelectedTypeId != Guid.Empty) {
					var schemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
					var schema = Page.DataSource.Schema;
					var columnUId = schema.Columns.GetByUId(TypeColumnUId).Name;
					if (DefValuesId != Guid.Empty) {
						var dictionary = UserConnection.SessionData[DefValuesId.ToString()] as Dictionary <string, object>;
						if (dictionary.ContainsKey(columnUId.ToString())) {
							dictionary.Remove(columnUId.ToString());
						}
						dictionary.Add(columnUId.ToString(), SelectedTypeId);
					} else {
						DefValuesId = Guid.NewGuid();
						var dictionary = new Dictionary <string, object>();
						dictionary.Add(columnUId.ToString(), SelectedTypeId);
						UserConnection.SessionData[DefValuesId.ToString()] = dictionary;
					}
				}
			
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

		public virtual void CustomDelete() {
			UserMessage.Page = Page;
			UserMessage.MessageText = DeleteRecordMessage;
			UserMessage.Icon = "QUESTION";
			UserMessage.Buttons = "YESNO";
			UserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "DeleteYesMessage"},
				{"no", "DeleteNoMessage"},
			};
		}

		public virtual void ListenerProcessSetProperty(string processId, string propertyName, object propertyValue) {
			if (string.IsNullOrEmpty(processId)) {
				return;
			}
			var process = UserConnection.IProcessEngine.GetProcessByUId(processId);
			process.SetPropertyValue(propertyName, propertyValue);
		}

		public virtual object GetListenerProcessPropertyValue(string listenerProcessId, string property) {
			if (string.IsNullOrEmpty(listenerProcessId)) {
				return null;
			}
			var process = UserConnection.IProcessEngine.GetProcessByUId(listenerProcessId);
			return process.GetPropertyValue(property);
		}

		public virtual void ClearData() {
			Page.TreeGrid.Clear();
		}

		public virtual string GetSerializedFilters() {
			var dataSource = Page.DataSource;
			var filter = dataSource.CurrentStructure.Filters;
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, dataSource);
			return Json.Serialize(filter, jsonConverter);
		}

		public virtual Dictionary<string, string> GetEditPages() {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
			entitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(string.Format(TSConfiguration.CacheUtilities.ModuleDataCacheGroup, SysModuleId));
			var primaryColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName()).Name;
			var typeColumnUIdColumnName =  entitySchemaQuery.AddColumn("SysModuleEntity.TypeColumnUId").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"Id", SysModuleId));
			entitySchemaQuery.CacheItemName = string.Format("SysModuleEntityTypeColumnUId_{0}", SysModuleId);
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			Guid typeColumnUId = Guid.Empty;
			foreach (var entity in entities) {
				typeColumnUId = entity.GetTypedColumnValue<Guid>(typeColumnUIdColumnName);
				break;
			}
			TypeColumnUId = typeColumnUId;
			Dictionary <string, string> listEditPages = new Dictionary <string, string>();
			entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleEdit");
			entitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(string.Format(TSConfiguration.CacheUtilities.ModuleDataCacheGroup, SysModuleId));
			var sysModuleEditPrimaryColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName()).Name;
			var pageSchemaUIdColumnName = entitySchemaQuery.AddColumn("SysPageSchemaUId").Name;
			if (TypeColumnUId == Guid.Empty || Page.DataSource.Schema.Columns.FindByUId(typeColumnUId) == null) {
				if (EditPageUId == Guid.Empty && SysModuleEditId == Guid.Empty) {
					Page.DataSource.EnableServerActiveRow = false;
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						"SysModuleEntity.SysEntitySchemaUId", Page.DataSource.SchemaUId));
					entitySchemaQuery.CacheItemName = string.Format("SysModuleEditPages_{0}", Page.DataSource.SchemaUId);
					var pageSchemaManager = (PageSchemaManager)UserConnection.GetSchemaManager("PageSchemaManager");
					var editPages = entitySchemaQuery.GetEntityCollection(UserConnection);
					foreach (var editPage in editPages) {
						Guid editPageUId = editPage.GetTypedColumnValue<Guid>(pageSchemaUIdColumnName);
						Guid sysModuleEditPageId = editPage.GetTypedColumnValue<Guid>(sysModuleEditPrimaryColumnName);
						PageSchema editPageSchema = pageSchemaManager.FindInstanceByUId(editPageUId);
						PageSchema sysModuleEditPageSchema = pageSchemaManager.FindInstanceByUId(sysModuleEditPageId);
						if (editPageSchema != null && sysModuleEditPageSchema != null) {
							EditPageUId = editPageUId;
							SysModuleEditId = sysModuleEditPageId;
						}
						break;
					}
				}
				return listEditPages;
			}
			var typeEditPageUIds = new Dictionary<Guid, Dictionary<string, Guid>>();
			var typeSchema = Page.DataSource.Schema.Columns.GetByUId(typeColumnUId).ReferenceSchema;
			if (typeColumnUId != Guid.Empty) {
				entitySchemaQuery = new EntitySchemaQuery(typeSchema);
				entitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(string.Format(TSConfiguration.CacheUtilities.ModuleDataCacheGroup, SysModuleId));
				Page.DataSource.EnableServerActiveRow = true;
				var typePrimaryColumnName = entitySchemaQuery.AddColumn(typeSchema.GetPrimaryColumnName()).Name;
				var typeDisplayColumnName = entitySchemaQuery.AddColumn(typeSchema.GetPrimaryDisplayColumnName()).Name;
				var typePageSchemaUIdColumnName =  entitySchemaQuery.AddColumn("[SysModuleEdit:TypeColumnValue]." +
					"SysPageSchemaUId").Name;
				var primarySysModuleEditColumnName =  entitySchemaQuery.AddColumn("[SysModuleEdit:TypeColumnValue].Id").Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"[SysModuleEdit:TypeColumnValue].SysModuleEntity.SysEntitySchemaUId", Page.DataSource.SchemaUId));
				entitySchemaQuery.CacheItemName = string.Format("SysModuleEditPages_{0}", Page.DataSource.SchemaUId);
				var editPages = entitySchemaQuery.GetEntityCollection(UserConnection);
				foreach (var editPage in editPages) {
					var key = editPage.GetTypedColumnValue<Guid>(typePageSchemaUIdColumnName).ToString() + "&" +
						editPage.GetTypedColumnValue<Guid>(typePrimaryColumnName).ToString();
					listEditPages[key] = 
						editPage.GetTypedColumnValue<string>(typeDisplayColumnName);
					typeEditPageUIds.Add(editPage.GetTypedColumnValue<Guid>(typePrimaryColumnName),
						new Dictionary <string, Guid>() {
							{"EditPageUId", editPage.GetTypedColumnValue<Guid>(typePageSchemaUIdColumnName)},
							{"SysModuleEditId", editPage.GetTypedColumnValue<Guid>(primarySysModuleEditColumnName)}
						}
					);
				}
			}
			if (typeEditPageUIds.Count > 0) {
				TypeEditPageUIds = typeEditPageUIds;
			} else {
				TypeEditPageUIds = null;
			}
			return listEditPages;
		}

		public virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddButtonMenuItem(string menuCaption, string menuTag) {
			var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			menuItem.Name = "TypeMenu_" + (new Guid(menuTag.Split('&')[1])).ToString("N");
			menuItem.Caption = menuCaption;
			menuItem.CaptionColor = Color.FromArgb(0,2,77,156);
			menuItem.Image = new ControlImage {};
			menuItem.Tag = menuTag;
			var parameters = menuTag.Split('&');
			var typeEditPageUId = new Guid(parameters[0]);
			var typeEntityId = new Guid(parameters[1]);
			var typeEditPageUIds = TypeEditPageUIds as Dictionary<Guid, Dictionary<string, Guid>>;
			var sysModuleEditId = typeEditPageUIds[typeEntityId]["SysModuleEditId"];
			string tempDataKey = "tempData";
			var AspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			if (!AspPage.CustomData.ContainsKey(tempDataKey)) {
				AspPage.CustomData.Add(tempDataKey, new JObject());
			}
			var tempData = AspPage.CustomData[tempDataKey] as JObject;
			JObject data = null;
			if (tempData[Page.AddButton.ClientID] != null) {
				data = tempData[Page.AddButton.ClientID] as JObject;
			} else {
				data = new JObject();
			}
			data[string.Format("typeId_{0}", typeEntityId.ToString("N"))] = new JValue(typeEditPageUId.ToString());
			data[string.Format("sysModuleEditId_{0}", typeEntityId.ToString("N"))] = new JValue(sysModuleEditId.ToString());
			tempData[Page.AddButton.ClientID] = data;		
			AspPage.CustomData[tempDataKey] = tempData;
			return menuItem;
		}

		public virtual void ActivateButtons(bool activate) {
			var buttons = GetButtons();
			var dataSourceRowsCount = Page.DataSource.ActiveRowPrimaryColumnValue == Guid.Empty || !activate ? 0 : 1;
			bool addButtonEnabledByRights = true;
			bool deleteButtonEnabledByRights = true;
			bool editButtonEnabledByRights = true;
			bool copyButtonEnabledByRights = true;
			var entitySchema = Page.DataSource.Schema;
			if (entitySchema != null) {
				var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
				string schemaName = entitySchema.Name;
				deleteButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaDeletingAllowed(schemaName);
				addButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
				copyButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
				editButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaEditingAllowed(schemaName);
			}
			foreach(var control in Page.ButtonsControlLayout.Controls) {
				var button = control as Terrasoft.UI.WebControls.Controls.Button;
				if (button != null && string.CompareOrdinal(button.Name, "ContextHelpButton") != 0) {
					if (buttons.Contains(button.Name)) {
						switch (button.Name) {
							case "AddButton":
								button.Enabled = addButtonEnabledByRights;
							break;
							case "DeleteButton":
								button.Enabled = (dataSourceRowsCount > 0) && deleteButtonEnabledByRights;
							break;
							case "EditButton":
								button.Enabled = (dataSourceRowsCount > 0) && editButtonEnabledByRights;
							break;
							case "CopyButton":
								button.Enabled = (dataSourceRowsCount > 0) && copyButtonEnabledByRights;
							break;
							default :
								button.Enabled = (dataSourceRowsCount > 0);
							break;
						}
					} else {
						button.Enabled = true;
					}
				}
			}
			if (IsDetailGrid && SelectedNodePrimaryColumnValue == Guid.Empty) {
				foreach(var control in Page.ButtonsControlLayout.Controls) {
					var button = control as Terrasoft.UI.WebControls.Controls.Button;
					if (button != null && string.CompareOrdinal(button.Name, "ContextHelpButton") != 0) {
						button.Enabled = false;		
					}
				}
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

		public virtual string GetRegisterQuestionScript() {
			string buttonsJsString;
			string iconJsString;
			string messageBoxString = "Ext.MessageBox";
			string processInstanceId = Page.Process.InstanceUId;
			var responseMessages = new Dictionary<string, string>();
			responseMessages.Add("yes", "DeleteYesMessage");
			responseMessages.Add("no", "DeleteNoMessage");
			buttonsJsString = messageBoxString + "." + "YESNO";
			iconJsString = messageBoxString + ".QUESTION";
			var functionJsStringBuilder = new StringBuilder();
			functionJsStringBuilder.Append("function(btn) {");
			foreach(KeyValuePair<string, string> responseMessage in responseMessages){
				functionJsStringBuilder.Append("if (btn == '" + responseMessage.Key + 
													"') {window.Terrasoft.AjaxMethods.ThrowClientEventWithMask('" + 
													processInstanceId + "','" + responseMessage.Value + "');} else ");
			}
			functionJsStringBuilder.Append("{window.Terrasoft.AjaxMethods.ThrowClientEventWithMask('" + processInstanceId + 
											"','DefaultQuestionMessage');}}");
			return "Ext.MessageBox.message('" + QuestionCaption.ToString() + "','" + DeleteRecordMessage.ToString().Replace("'", @"\'") + "'," +
				buttonsJsString + "," + iconJsString + "," + functionJsStringBuilder.ToString() + ", this);";
		}

		public virtual string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			var openPageParameters = new Dictionary<string, object>() {
					{"OpenerInstanceId", Page.Process.InstanceUId},		
				};
			
			var queryStringParameters = new Dictionary<string, string>() {
				{"recordId", Page.DataSource.ClientID + ".activeRow.getPrimaryColumnValue()"},
				{"entitySchemaUId",string.Format("'{0}'", Page.DataSource.SchemaUId)},
				{"treeGridId", string.Format("'{0}'", Page.TreeGrid.ClientID)},
				{"SysModuleEditId", string.Format("'{0}'", sysModuleEditId)}
			};
			if (TypeColumnUId != Guid.Empty && sysModuleEditId == Guid.Empty) {
				queryStringParameters["SysModuleEditId"] = "sysModuleEditId";
			}
			ModifyEditPageParameters(openPageParameters, queryStringParameters);
			
			var sb = new StringBuilder();
			sb.Append("{");
			if (TypeColumnUId == Guid.Empty) {
				sb.Append(string.Format("var editPageId = {0};", Json.Serialize(EditPageUId)));
			} else {
				var typeEditPageUIdScript = string.Format("{0}.getCustomData('typeId_' + {1}.activeRow.getColumnValue({0}.getCustomData('typeColumnName')).replace(/-/g, ''));", 
					Page.AddButton.ClientID, Page.DataSource.ClientID);
				var sysModuleEditIdScript = string.Format("{0}.getCustomData('sysModuleEditId_' + {1}.activeRow.getColumnValue({0}.getCustomData('typeColumnName')).replace(/-/g, ''));", 
					Page.AddButton.ClientID, Page.DataSource.ClientID);
				sb.Append("var editPageId = " + typeEditPageUIdScript);
				sb.Append("var sysModuleEditId = " + sysModuleEditIdScript);
			}
			sb.Append("Terrasoft.openWindow(");
			var sbCallback = new StringBuilder();
			var nullString = "null";
			var callbackString = "function(wnd) {{ {0} }}";
			var window = "wnd";
			sb.Append("'");
			sb.Append("ViewPage.aspx");	
			sb.Append("'");
			sb.Append(", ");
			sb.Append("editPageId");
			sb.Append(", ");
			sb.Append("[");
			bool isFirst = true;
			foreach (var parameter in queryStringParameters) {
				if (isFirst) {
					isFirst = false;
				} else {
					sb.Append(", ");
				}
				sb.Append("\n\t{name: ");
				sb.Append("'");
				sb.Append(parameter.Key);
				sb.Append("'");
				sb.Append(",");
				sb.Append(" value: ");
				if (!parameter.Value.StartsWith("'") && parameter.Key != "recordId" && parameter.Key != "SysModuleEditId" && parameter.Key != "ParentEntityId") {
					sb.Append("'");
				}
				sb.Append(parameter.Value);
				if (!parameter.Value.EndsWith("'") && parameter.Key != "recordId" && parameter.Key != "ParentEntityId" && parameter.Key != "SysModuleEditId") {
					sb.Append("'");
				}
				sb.Append("}");
			}
			sb.Append("\t]");	
			sb.Append(", ");
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as PageSchemaManager;
			if (EditPageUId != Guid.Empty) {
				var pageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId);	
				sb.Append(pageSchema.Width.ToString(CultureInfo.InvariantCulture));
				sb.Append(", ");		
				sb.Append(pageSchema.Height.ToString(CultureInfo.InvariantCulture));
				sb.Append(", ");
			}
			else {
				sb.Append("null, null, ");
			}
			sb.Append("true");
			sb.Append(", ");
			sb.Append(nullString);
			sb.Append(", ");
			sb.Append(nullString);
			sbCallback.Append("\nvar windowKey = ");
			sbCallback.Append("'");
			sbCallback.Append(openPageParameters["OpenerInstanceId"].ToString());
			sbCallback.Append("'");
			sbCallback.Append(";");	
			sbCallback.Append("\nwnd.key = windowKey;");
			if (openPageParameters.ContainsKey("CloseMessage")) {
				var closeMessageObj = openPageParameters["CloseMessage"];
				if (closeMessageObj != null) {
					var closeMessage = closeMessageObj.ToString();
					if (closeMessage.Length > 0) {
						sbCallback.Append("\nExt.EventManager.on(");	
						sbCallback.Append(window);
						sbCallback.Append(", 'beforeunload', function() {\n\t");
						sbCallback.Append("if (Terrasoft.AjaxMethods.ThrowClientEvent)");
						sbCallback.Append("\n\t\t{\n\tTerrasoft.AjaxMethods.ThrowClientEvent(");	
						sbCallback.Append("windowKey");
						sbCallback.Append(",");
						sbCallback.Append("'");
						sbCallback.Append(closeMessage);
						sbCallback.Append("'");
						sbCallback.Append(");}");
						sbCallback.Append("\n});");				
					}
				}
			}
			sb.Append(", ");
			sb.Append(string.Format(callbackString, sbCallback.ToString()));
			sb.Append(");");
			sb.Append("}");
			return string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, sb.ToString());
		}

		public virtual string GetRegisterCopyPageScript(Guid editPageUId, Guid sysModuleEditId) {
			var openPageParameters = new Dictionary<string, object>() {
					{"OpenerInstanceId", Page.Process.InstanceUId},		
				};
			var queryStringParameters = new Dictionary<string, string>() {
				{"recordId", Page.DataSource.ClientID + ".activeRow.getPrimaryColumnValue()"},
				{"entitySchemaUId",string.Format("'{0}'", Page.DataSource.SchemaUId)},
				{"treeGridId", string.Format("'{0}'", Page.TreeGrid.ClientID)},
				{"Copy", "'true'"},
				{"SysModuleEditId", string.Format("'{0}'", sysModuleEditId)}
			};
			if (TypeColumnUId != Guid.Empty && sysModuleEditId == Guid.Empty) {
				queryStringParameters["SysModuleEditId"] = "sysModuleEditId";
			}
			if (!IsDetailGrid) {
				var selectedFolderValue = "Ext.decode(Ext.get('customDataField').dom.value)['SysModule_selectedFolderId']";
				string selectedFolderId = string.Format("{0} ? {0} : ''", selectedFolderValue);
				queryStringParameters.Add("folderId", selectedFolderId);	
			}
			ModifyCopyPageParameters(openPageParameters, queryStringParameters);
			var sb = new StringBuilder();
			sb.Append("{");
			if (TypeColumnUId == Guid.Empty) {
				sb.Append(string.Format("var editPageId = {0};", Json.Serialize(editPageUId)));
			} else {
				var typeEditPageUIdScript = string.Format("{0}.getCustomData('typeId_' + {1}.activeRow.getColumnValue({0}.getCustomData('typeColumnName')).replace(/-/g, ''));", 
					Page.AddButton.ClientID, Page.DataSource.ClientID);
				var sysModuleEditIdScript = string.Format("{0}.getCustomData('sysModuleEditId_' + {1}.activeRow.getColumnValue({0}.getCustomData('typeColumnName')).replace(/-/g, ''));", 
					Page.AddButton.ClientID, Page.DataSource.ClientID);
				sb.Append("var editPageId = " + typeEditPageUIdScript);
				sb.Append("var sysModuleEditId = " + sysModuleEditIdScript);
			}
			sb.Append("Terrasoft.openWindow(");
			var sbCallback = new StringBuilder();
			var nullString = "null";
			var callbackString = "function(wnd) {{ {0} }}";
			var window = "wnd";
			sb.Append("'");
			sb.Append("ViewPage.aspx");	
			sb.Append("'");
			sb.Append(", ");
			sb.Append("editPageId");
			sb.Append(", ");
			sb.Append("[");
			bool isFirst = true;
			foreach (var parameter in queryStringParameters) {
				if (isFirst) {
					isFirst = false;
				} else {
					sb.Append(", ");
				}
				sb.Append("\n\t{name: ");
				sb.Append("'");
				sb.Append(parameter.Key);
				sb.Append("'");
				sb.Append(",");
				sb.Append(" value: ");
				if (!parameter.Value.StartsWith("'") && parameter.Key != "recordId" &&  
					parameter.Key != "SysModuleEditId" && parameter.Key != "folderId" && parameter.Key != "ParentEntityId") {
					sb.Append("'");		
				}
				sb.Append(parameter.Value);
				if (!parameter.Value.StartsWith("'") && parameter.Key != "recordId" && 
					parameter.Key != "SysModuleEditId" && parameter.Key != "folderId" && parameter.Key != "ParentEntityId") {
					sb.Append("'");		
				}
				sb.Append("}");
			}
			sb.Append("\t]");	
			sb.Append(", ");
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as PageSchemaManager;
			if (EditPageUId != Guid.Empty) {
				var pageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId);	
				sb.Append(pageSchema.Width.ToString(CultureInfo.InvariantCulture));
				sb.Append(", ");		
				sb.Append(pageSchema.Height.ToString(CultureInfo.InvariantCulture));
				sb.Append(", ");
			}
			else {
				sb.Append("null, null, ");
			}
			sb.Append("true");
			sb.Append(", ");
			sb.Append(nullString);
			sb.Append(", ");
			sb.Append(nullString);
			sbCallback.Append("\nvar windowKey = ");
			sbCallback.Append("'");
			sbCallback.Append(openPageParameters["OpenerInstanceId"].ToString());
			sbCallback.Append("'");
			sbCallback.Append(";");	
			sbCallback.Append("\nwnd.key = windowKey;");
			if (openPageParameters.ContainsKey("CloseMessage")) {
				var closeMessageObj = openPageParameters["CloseMessage"];
				if (closeMessageObj != null) {
					var closeMessage = closeMessageObj.ToString();
					if (closeMessage.Length > 0) {
						sbCallback.Append("\nExt.EventManager.on(");	
						sbCallback.Append(window);
						sbCallback.Append(", 'beforeunload', function() {\n\t");
						sbCallback.Append("if (Terrasoft.AjaxMethods.ThrowClientEvent)");
						sbCallback.Append("\n\t\t{\n\tTerrasoft.AjaxMethods.ThrowClientEvent(");	
						sbCallback.Append("windowKey");
						sbCallback.Append(",");
						sbCallback.Append("'");
						sbCallback.Append(closeMessage);
						sbCallback.Append("'");
						sbCallback.Append(");}");
						sbCallback.Append("\n});");				
					}
				}
			}
			sb.Append(", ");
			sb.Append(string.Format(callbackString, sbCallback.ToString()));
			sb.Append(");");
			sb.Append("}");
			return sb.ToString();
		}

		public virtual string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			var sb = new StringBuilder();
			
			var openPageParameters = new Dictionary<string, object>() {
					{"OpenerInstanceId", Page.Process.InstanceUId},		
				};
			var queryStringParameters = new Dictionary<string, string>() {
				{"recordId", string.Format("'{0}'", Guid.Empty)},
				{"entitySchemaUId",string.Format("'{0}'", Page.DataSource.SchemaUId)},
				{"treeGridId", string.Format("'{0}'", Page.TreeGrid.ClientID)},
				{"SysModuleEditId", string.Format("'{0}'", sysModuleEditId)}
			};
			if (TypeColumnUId != Guid.Empty) {
				queryStringParameters.Add("typeColumnUId", Json.Serialize(TypeColumnUId));
				queryStringParameters.Add("typeId", Json.Serialize(typeId));
			}
			if (IsDetailGrid) {
				var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
				string dataSourceClientId = "window[Ext.decode(Ext.get('customDataField').dom.value)['SysModule_activeDataSource']]";
				queryStringParameters.Add("SysModuleDetailId", string.Format("'{0}'", SysModuleDetailId));
				queryStringParameters.Add("ParentEntityId", dataSourceClientId + ".activeRow.getPrimaryColumnValue()");
				queryStringParameters.Add("ParentEntitySchemaId", string.Format("'{0}'", SysEntitySchemaId));
				queryStringParameters.Add("UseModuleDetail", string.Format("'{0}'", UseModuleDetails));	
			} else {
				var selectedFolderValue = "Ext.decode(Ext.get('customDataField').dom.value)['SysModule_selectedFolderId']";
				string selectedFolderId = string.Format("{0} ? {0} : ''", selectedFolderValue);
				queryStringParameters.Add("folderId", selectedFolderId);	
			}
			ModifyAddPageParameters(openPageParameters, queryStringParameters);
			string openWinowScript = GetRegisterOpenWindowScript(openPageParameters, queryStringParameters, editPageUId);
			
			if (IsDetailGrid) {
				sb.Append(GetAddScriptForDetail(openWinowScript));
			} else {
				sb.Append(openWinowScript);
			}
			return sb.ToString();
		}

		public virtual void ModifyAddPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
		}

		public virtual void ModifyEditPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
		}

		public virtual void ModifyCopyPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
		}

		public virtual void LoadViewFilters(bool enabledFilters) {
		}

		public virtual string GetAddScriptForDetail(string openWindowScript) {
			var sb = new StringBuilder();
			sb.Append("\nvar needAddDetailRequest = Ext.decode(Ext.get('customDataField').dom.value)['needAddDetailRequest'];\n");
			sb.AppendFormat("if (!needAddDetailRequest) {{ {0} }}", openWindowScript);
			sb.Append("else {");
			string function = @"function(btn) {{
									if (btn == 'yes') {{							
										if (!Ext.FormValidator.validate()) {{
											return;
										}}
										var activeDataSource = window[Ext.decode(Ext.get('customDataField').dom.value)['SysModule_activeDataSource']];							
										window.onDatasourceSaved = function() {{															
											{0}								
											activeDataSource.un('saved', window.onDatasourceSaved, this);
										}};
										activeDataSource.on('saved', window.onDatasourceSaved, this);
										activeDataSource.save();
									}}
								}}";
			function = string.Format(function, openWindowScript); 					
			string mbstr = Terrasoft.Configuration.ClientScriptUtilities.GetMessageScript(Warning, NewRecordNotSavedMessage, Terrasoft.Configuration.MessageBoxButtons.YesNo, 
								Terrasoft.Configuration.MessageBoxIcon.Question, function);
			sb.Append(mbstr);
			sb.Append("}\n");
			return sb.ToString();
		}

		public virtual string GetRegisterOpenWindowScript(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters, Guid editPageUId) {
			var sb = new StringBuilder();
			sb.Append("Terrasoft.openWindow(");
			var sbCallback = new StringBuilder();
			var nullString = "null";
			var callbackString = "function(wnd) {{ {0} }}";
			var window = "wnd";
			sb.Append("'");
			sb.Append("ViewPage.aspx");	
			sb.Append("'");
			sb.Append(", ");
			sb.Append(Json.Serialize(editPageUId));
			sb.Append(", ");
			sb.Append("[");
			bool isFirst = true;
			foreach (var parameter in queryStringParameters) {
				if (isFirst) {
					isFirst = false;
				} else {
					sb.Append(", ");
				}
				sb.Append("\n\t{name: ");
				sb.Append("'");
				sb.Append(parameter.Key);
				sb.Append("'");
				sb.Append(",");
				sb.Append(" value: ");
				sb.Append(parameter.Value);
				sb.Append("}");
			}
			sb.Append("\t]");	
			sb.Append(", ");
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as PageSchemaManager;
			if (EditPageUId != Guid.Empty) {
				var pageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId);	
				sb.Append(pageSchema.Width.ToString(CultureInfo.InvariantCulture));
				sb.Append(", ");		
				sb.Append(pageSchema.Height.ToString(CultureInfo.InvariantCulture));
				sb.Append(", ");
			}
			else {
				sb.Append("null, null, ");
			}
			sb.Append("true");
			sb.Append(", ");
			sb.Append(nullString);
			sb.Append(", ");
			sb.Append(nullString);
			sbCallback.Append("\nvar windowKey = ");
			sbCallback.Append("'");
			sbCallback.Append(openPageParameters["OpenerInstanceId"].ToString());
			sbCallback.Append("'");
			sbCallback.Append(";");	
			sbCallback.Append("\nwnd.key = windowKey;");
			if (openPageParameters.ContainsKey("CloseMessage")) {
				var closeMessageObj = openPageParameters["CloseMessage"];
				if (closeMessageObj != null) {
					var closeMessage = closeMessageObj.ToString();
					if (closeMessage.Length > 0) {
						sbCallback.Append("\nExt.EventManager.on(");	
						sbCallback.Append(window);
						sbCallback.Append(", 'beforeunload', function() {\n\t");
						sbCallback.Append("if (Terrasoft.AjaxMethods.ThrowClientEvent)");
						sbCallback.Append("\n\t\t{\n\tTerrasoft.AjaxMethods.ThrowClientEvent(");	
						sbCallback.Append("windowKey");
						sbCallback.Append(",");
						sbCallback.Append("'");
						sbCallback.Append(closeMessage);
						sbCallback.Append("'");
						sbCallback.Append(");}");
						sbCallback.Append("\n});");				
					}
				}
			}
			sb.Append(", ");
			sb.Append(string.Format(callbackString, sbCallback.ToString()));
			sb.Append(");");
			return sb.ToString();
		}

		public virtual Terrasoft.UI.WebControls.Controls.MenuItem EmailContextMenuItem(string caption, string tag) {
			var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			var newId = Guid.NewGuid();
			menuItem.UId = newId;
			menuItem.ID = string.Format("EmailMenuItem_{0}", newId.ToString("N"));
			menuItem.Caption = caption;
			menuItem.Tag = tag;
			menuItem.CreatedByAjax = true;
			menuItem.EnableViewState = false;
			menuItem.AjaxEvents.Click.ShowLoadMask = true;
			menuItem.AjaxEvents.Click.SignalName = "ProcessEmailContextItemClick";
			menuItem.AjaxEvents.Click.AjaxEventTargetControlID = Page.TreeGrid.ClientID;
			return menuItem;
		}

		public virtual Terrasoft.UI.WebControls.Controls.MenuSeparator ContextMenuSeparator(string caption) {
			var menuSeparator = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
			var newId = Guid.NewGuid();
			menuSeparator.UId = newId;
			menuSeparator.ID = string.Format("EmailMenuSeparator_{0}", newId.ToString("N"));
			menuSeparator.Caption = caption;
			return menuSeparator;
		}

		public virtual string GetSchemaTag(string schemaName, Guid id) {
			return string.Concat(schemaName, "Id:", id.ToString());
		}

		public virtual Dictionary<string, Guid> GetSchemasColumnList(IEnumerable<Guid> schemaIds) {
			var result = new Dictionary<string, Guid>();
			
			if (Page.DataSource.ActiveRowPrimaryColumnValue.Equals(Guid.Empty)) {
				return result;
			}
			
			//var contactSchemaId = new Guid("16BE3651-8FE2-4159-8DD0-A803D4683DD3");
			//var employeeSchemaId = new Guid("FB1C2BED-91D4-4B06-A28C-621A3D187008");
			var lookupDataValueType = UserConnection.DataValueTypeManager.GetInstanceByName("Lookup");
			var columnMap = new Dictionary<string, EntitySchemaQueryColumn>();
			foreach (var column in Page.DataSource.Schema.Columns) {
				foreach(var schemaId in schemaIds) {
					if (column.ReferenceSchemaUId.Equals(schemaId) && lookupDataValueType.Equals(column.DataValueType)) {
						columnMap.Add(column.Name, null);
					}
				}
			}
			
			var keyList = new List<string>(columnMap.Keys);
			
			if (columnMap.Keys.Count > 0) {
				var currentESQ = new EntitySchemaQuery(Page.DataSource.Schema);	
				foreach (var columnName in keyList) {
					columnMap[columnName] = currentESQ.AddColumn(string.Format("{0}.Id", columnName));		
				}
				var idFilter = currentESQ.CreateFilterWithParameters(
					FilterComparisonType.Equal, 
					Page.DataSource.CurrentStructure.PrimaryColumnName, 
					Page.DataSource.ActiveRowPrimaryColumnValue);
				currentESQ.Filters.Add(idFilter);
			
				var collection = currentESQ.GetEntityCollection(UserConnection);
				foreach (var columnName in keyList) {
					var esq_columnValueId = collection[0].GetTypedColumnValue<Guid>(columnMap[columnName].Name);
					if (!esq_columnValueId.Equals(Guid.Empty)) {
						string columnCaption = Page.DataSource.Schema.Columns.Find(c => c.Name.Equals(columnName)).Caption;
						result.Add(columnCaption, esq_columnValueId);
					}
				}	
			}
			
			return result;
		}

		public virtual string GetTemplateTag(Guid id) {
			return string.Format("TemplateId:{0}", id.ToString());
		}

		public virtual Guid ReadIdFromTag(string tag, string tagName) {
			if (string.IsNullOrEmpty(tag)) {
				return Guid.Empty;
			}
			if (tag.Split(':')[0].Equals(tagName)) {
				return new Guid(tag.Split(':')[1]);
			}
			 return Guid.Empty;
		}

		public virtual Dictionary<string, Guid> GetTemplatePairsList() {
			var result = new Dictionary<string, Guid>();
			
			var templateESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "EmailTemplate");  
			var template_IdColumn = templateESQ.AddColumn("Id");      
			var template_NameColumn = templateESQ.AddColumn("Name");  
			
			var orderFilter = templateESQ.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"Module.Id", 
				SysModuleId);
				
			templateESQ.Filters.Add(orderFilter);  
			
			var list = templateESQ.GetEntityCollection(UserConnection);
			foreach (var template in list) {
				var name = template.GetTypedColumnValue<string>(template_NameColumn.Name);
				var id = template.GetTypedColumnValue<Guid>(template_IdColumn.Name);
				if (!result.ContainsKey(name)) {
					result.Add(name, id);
				}
			}
			
			
			return result;
		}

		public virtual void CreateContextMenu() {
			/*Page.TreeGrid.CustomConfig.Add(new ConfigItem("enableContextMenu", "false"));
			Page.AddScript(string.Format("{0}.contextMenuId = '{1}_menu';window['{1}_menu'] = {1}.menu;{0}.enableContextMenu = true;{0}.initContextMenu();", Page.TreeGrid.ClientID, Page.ContextMenuButton.ClientID));*/
		}

		public virtual bool IsLoggingEnabled() {
			if ((Page.DataSource != null) && (Page.DataSource.Schema != null)) {
				return Page.DataSource.Schema.IsTrackChangesInDB;
			}
			return false;
		}

		public virtual List<Tuple<Guid, string, Guid, bool>> GetModuleProcessesInfo() {
			var appCache = UserConnection.ApplicationCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			List<Dictionary<string, object>> actions = TSConfiguration.CommonUtilities.GetSelectData(
				UserConnection, TSConfiguration.CommonUtilities.GetModuleActionsSelect, appCache, TSConfiguration.CacheUtilities.ActionsCache);
			string captionColumnName = TSConfiguration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleAction", "Caption");
			var result = new List<Tuple<Guid, string, Guid, bool>>();
			Guid actionId;
			Guid actionSchemaUId;
			bool actionImagePresented;
			foreach (var action in actions) {
				if (new Guid(action["sysModuleId"].ToString()) == SysModuleId) {
					actionId = new Guid(action["sysModuleActionId"].ToString());
					var lczActionCaption = action[captionColumnName].ToString();
					actionSchemaUId = action["sysProcessSchemaId"] == DBNull.Value ? Guid.Empty : new Guid(action["sysProcessSchemaId"].ToString());
					if (actionSchemaUId != Guid.Empty && UserConnection.ProcessSchemaManager.FindItemByUId(actionSchemaUId)== null) {
						continue;
					}
					var processInfo = new Tuple<Guid, string, Guid, bool>(actionId, lczActionCaption, actionSchemaUId, false);
					result.Add(processInfo);
				}
			}
			return result;
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
			if (IsModuleProcessesTuningMode) {
				var menuItem = new WebControls.MenuItem();
				menuItem.CreatedByAjax = true;
				menuItem.EnableViewState = false;
				menuItem.Name = string.Format("{0}_CreateNewProcess", button.ClientID);
				menuItem.UId = Guid.NewGuid();
				menuItem.Tag = "CreateNewProcess";
				menuItem.Caption = CreateNewProcessMenuItemCaption.Value;
				menuItem.Image.Source = Terrasoft.UI.WebControls.ControlImageSource.ResourceManager;
				menuItem.Image.ResourceManagerName = "Terrasoft.WebApp";
				menuItem.Image.ResourceItemName = "navigator-ico-topbuttons-add.png";
				menuItem.AjaxEvents.Click.SignalName = "CreateNewProcessMenuItemClick";
				menuItem.AjaxEvents.Click.AjaxEventTargetControlID = button.ClientID;
				script = string.Format("window.{0} = {1};\n", menuItem.ClientID, menuItem.GenerateControlScript(true, null));
				script += string.Format("{0}.getMenu().addItem(window.{1});\n", button.ClientID, menuItem.ClientID);
				script += string.Format("{0}.getMenu().addSeparator();\n", button.ClientID);
				var separator = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
				separator.Name = string.Format("{0}_sep_{1}",button.ClientID, menuItem.Name);
				separator.EnableViewState = false;
				menu.Add(separator);
				menu.Add(menuItem);
				Page.AddScript(script);
				resourceManagerName = "Terrasoft.WebApp";
				resourceItemName = "designmode-indicator.png";
				showActionButton = true;
			}
			foreach (var processInfo in moduleProcessesInfo) {
				Guid actionId = processInfo.Item1;
				string processCaption = processInfo.Item2;
				Guid processUId = processInfo.Item3;
				bool isUpload = processInfo.Item4;
				if (processUId != Guid.Empty) {
					var menuItem = new WebControls.MenuItem();
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

		public virtual Terrasoft.UI.WebControls.Controls.MenuItem CallContextMenuItem(string caption, string tag) {
			var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			var newId = Guid.NewGuid();
			menuItem.UId = newId;
			menuItem.ID = string.Format("CallMenuItem_{0}", newId.ToString("N"));
			menuItem.Caption = caption;
			menuItem.Tag = tag;
			menuItem.CreatedByAjax = true;
			menuItem.EnableViewState = false;
			menuItem.AjaxEvents.Click.ShowLoadMask = true;
			menuItem.AjaxEvents.Click.SignalName = "ProcessCallContextItemClick";
			menuItem.AjaxEvents.Click.AjaxEventTargetControlID = Page.TreeGrid.ClientID;
			return menuItem;
		}

		public virtual string[] GetContactPhoneNumbers(Guid contactId) {
			var result = new List<string>();
			return result.ToArray();
		}

		public virtual string[] GetAccountPhoneNumbers(Guid accountId) {
			var result = new List<string>();
			return result.ToArray();
		}

		public virtual string GetRegisterTreeGridDblClickScript(string defaultScript) {
			return defaultScript;
		}

		public virtual void ModifyModuleProcessParameters(Process process) {
		}

		public virtual void FillPrintMenu() {
			var button = Page.PrintButton;
			var menu = button.Menu;
			menu.RemoveAll();
			if (menu != null && SysModuleId != Guid.Empty) {
				string script = string.Empty;
				if (IsModuleProcessesTuningMode) {
					var menuItem = new WebControls.MenuItem();
					menuItem.CreatedByAjax = true;
					menuItem.EnableViewState = false;
					menuItem.Name = string.Format("{0}_CreateNewProcess", button.ClientID);
					menuItem.UId = Guid.NewGuid();
					menuItem.Tag = "CreateNewProcess";
					menuItem.Caption = CreateNewProcessMenuItemCaption.Value;
					menuItem.Image.Source = Terrasoft.UI.WebControls.ControlImageSource.ResourceManager;
					menuItem.Image.ResourceManagerName = "Terrasoft.WebApp";
					menuItem.Image.ResourceItemName = "navigator-ico-topbuttons-add.png";
					menuItem.AjaxEvents.Click.SignalName = "CreateNewSysModuleReportMenuItemClick";
					menuItem.AjaxEvents.Click.AjaxEventTargetControlID = button.ClientID;
					script = string.Format("window.{0} = {1};\n", menuItem.ClientID, menuItem.GenerateControlScript(true, null));
					script += string.Format("{0}.getMenu().addItem(window.{1});\n", button.ClientID, menuItem.ClientID);
					script += string.Format("{0}.getMenu().addSeparator();\n", button.ClientID);
					var separator = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
					separator.Name = string.Format("{0}_sep_{1}",button.ClientID, menuItem.Name);
					separator.EnableViewState = false;
					menu.Add(separator);
					menu.Add(menuItem);
					Page.AddScript(script);
				}
			
				var appCache = UserConnection.SessionCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
				var reportsCollection = TSConfiguration.CommonUtilities.GetSelectData(
					UserConnection, TSConfiguration.CommonUtilities.GetModuleReportsSelect, appCache, TSConfiguration.CacheUtilities.ReportsCache);
				string captionColumnName = TSConfiguration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleReport", "Caption");
				var reportSchemaManager = UserConnection.GetSchemaManager("ReportSchemaManager") as Terrasoft.Reports.ReportSchemaManager;
				var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as Terrasoft.UI.WebControls.PageSchemaManager;
				reportsCollection.Sort(delegate(Dictionary<string, object> p1, Dictionary<string, object> p2) { 
					return p1[captionColumnName].ToString().CompareTo(p2[captionColumnName].ToString());});
			
				foreach (var report in reportsCollection) {
					Guid sysModuleId = new Guid(report["sysModuleId"].ToString());
					if (SysModuleId == sysModuleId) {
						var menuItem = new WebControls.MenuItem();
						Guid reportId = new Guid(report["sysModuleReportId"].ToString());
						Guid typeId = new Guid(report["typeId"].ToString());
						string caption = report[captionColumnName].ToString();
						string helpContextId = report["helpContextId"].ToString();
						if (typeId == new Guid("32F72C9C-72C7-44E0-8C84-34C9ED17CA50")) {
							Guid reportSchemaUId = new Guid(report["sysReportSchemaUId"].ToString());
							Guid sysOptionsPageSchemaUId = report["sysOptionsPageSchemaUId"] == DBNull.Value ? Guid.Empty : new Guid(report["sysOptionsPageSchemaUId"].ToString());
							if (reportSchemaManager.FindItemByUId(reportSchemaUId) != null &&
								(sysOptionsPageSchemaUId == Guid.Empty || pageSchemaManager.FindItemByUId(sysOptionsPageSchemaUId) != null)) {
								menuItem = CreateMenuItem(caption, reportSchemaUId.ToString()
									+ @"&" + sysOptionsPageSchemaUId.ToString() + @"&" + helpContextId,
									"PrintReportMenuItem_"+reportId.ToString("n"), true);
							}
						} else if (typeId == new Guid("8BC259EF-4276-4906-B7A6-23DC59BE7FE2")) {
							menuItem = CreateMenuItem(caption, reportId.ToString("n"),
								"PrintReportMenuItem_" + reportId.ToString("n"), false);
						}
						menu.Add(menuItem);
						script = string.Format("window.{0} = {1};\n", menuItem.ClientID, menuItem.GenerateControlScript(true, null));
						script += string.Format("{0}.getMenu().addItem(window.{1});\n", button.ClientID, menuItem.ClientID);
						Page.AddScript(script);
					}
				}
				script = string.Format("{0}.onContentChanged();\n", button.ClientID);
				Page.AddScript(script);
			}
		}

		public virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateMenuItem(string MenuItemCaption, string MenuItemTag, string menuID, bool isDevExpressReport) {
			var button = Page.PrintButton;
			
			var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			menuItem.ID = menuID;	
			menuItem.UId = Guid.NewGuid();
			menuItem.Caption = MenuItemCaption;
			menuItem.CreatedByAjax = true;
			menuItem.EnableViewState = false;
			menuItem.AjaxEvents.Click.AjaxEventTargetControlID = button.ClientID;
			menuItem.CaptionColor = Color.FromArgb(0,2,77,156);
			menuItem.Tag = MenuItemTag;
			menuItem.AjaxEvents.Click.SignalName = isDevExpressReport ? "OpenPrintDevExpressReportMessage" : "CreateMSWordReportMessage";
			if (!isDevExpressReport) {
				menuItem.AjaxEvents.Click.IsUpload = true;
			}
			
			return menuItem;
		}

		public virtual void OpenReportPage(string parameters) {
			var keyName = "PrintReportParameters";
			UserConnection.SessionData[keyName] = parameters;
		}

		public virtual Terrasoft.UI.WebControls.Controls.MenuItem GetContextMenuItem(string itemName, string caption, string tag) {
			var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			var newId = Guid.NewGuid();
			menuItem.UId = newId;
			menuItem.ID = string.Format("{0}MenuItem_{1}", itemName, newId.ToString("N"));
			menuItem.Caption = caption;
			menuItem.Tag = tag;
			menuItem.CreatedByAjax = true;
			menuItem.EnableViewState = false;
			menuItem.AjaxEvents.Click.ShowLoadMask = true;
			menuItem.AjaxEvents.Click.SignalName = string.Format("Process{0}ContextItemClick", itemName);
			menuItem.AjaxEvents.Click.AjaxEventTargetControlID = Page.TreeGrid.ClientID;
			return menuItem;
		}

		public virtual void ClearMenuItems(MenuItemBase menuItem) {
			string clearMenuScript = string.Format("if ({0}.getMenu().items.items.length > 0){{ {0}.getMenu().removeAll();}} if ({0}.rendered){{ {0}.onContentChanged();}}", menuItem.ClientID);
			Page.ScriptManager.AddScript(clearMenuScript);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SendEmailMenuItemPrepareMenu":
							if (ActivatedEventElements.Contains("SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage")) {
							context.QueueTasks.Enqueue("SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage");
						}
						break;
					case "ProcessMailContextItemClick":
							if (ActivatedEventElements.Contains("ProcessEmailContextItemClick_StartMessage")) {
							context.QueueTasks.Enqueue("ProcessEmailContextItemClick_StartMessage");
						}
						break;
					case "ShowChangelogMenuItemClick":
							if (ActivatedEventElements.Contains("ShowChangelogMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("ShowChangelogMenuItemClickStartMessage");
						}
						break;
					case "CallMenuItemPrepareMenu":
							if (ActivatedEventElements.Contains("StartMessage1ddrrg")) {
							context.QueueTasks.Enqueue("StartMessage1ddrrg");
						}
						break;
					case "ProcessCallContextItemClick":
							if (ActivatedEventElements.Contains("ProcessCallContextItemClick_StartMessage")) {
							context.QueueTasks.Enqueue("ProcessCallContextItemClick_StartMessage");
						}
						break;
					case "NumberSelected":
							if (ActivatedEventElements.Contains("NumberSelectedMessage")) {
							context.QueueTasks.Enqueue("NumberSelectedMessage");
						}
						break;
					case "SendTemplateEmailMenuItemPrepareMenu":
							if (ActivatedEventElements.Contains("SendTemplateEmailMenuItemPrepareMenuStartMessage")) {
							context.QueueTasks.Enqueue("SendTemplateEmailMenuItemPrepareMenuStartMessage");
						}
						break;
					case "ProcessEmailTemplateContextItemClick":
							if (ActivatedEventElements.Contains("ProcessEmailTemplateContextItemClickStartMessage")) {
							context.QueueTasks.Enqueue("ProcessEmailTemplateContextItemClickStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("BaseGridPageInitStartMessage")) {
							context.QueueTasks.Enqueue("BaseGridPageInitStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("AddButtonClick")) {
							context.QueueTasks.Enqueue("AddButtonClick");
						}
						break;
					case "AllowAddDetailMessage1":
							if (ActivatedEventElements.Contains("StartMessageAllowAddDetailMessage")) {
							context.QueueTasks.Enqueue("StartMessageAllowAddDetailMessage");
						}
						break;
					case "EditButtonClick":
							if (ActivatedEventElements.Contains("EditButtonClick")) {
							context.QueueTasks.Enqueue("EditButtonClick");
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteButtonClick")) {
							context.QueueTasks.Enqueue("DeleteButtonClick");
						}
						break;
					case "CustomDeleteMessage":
							if (ActivatedEventElements.Contains("StartMessageCustomDeleteMessage")) {
							context.QueueTasks.Enqueue("StartMessageCustomDeleteMessage");
						}
						break;
					case "CopyButtonClick":
							if (ActivatedEventElements.Contains("CopyButtonClick")) {
							context.QueueTasks.Enqueue("CopyButtonClick");
						}
						break;
					case "DeleteNoMessage":
							if (ActivatedEventElements.Contains("DeleteNoMessage")) {
							context.QueueTasks.Enqueue("DeleteNoMessage");
						}
						break;
					case "OpenPrintDevExpressReportMessage":
							if (ActivatedEventElements.Contains("StartMessageOpenPrintReportMessage")) {
							context.QueueTasks.Enqueue("StartMessageOpenPrintReportMessage");
						}
						break;
					case "PrintButtonClick":
							if (ActivatedEventElements.Contains("StartMessageOpenPrintReportButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageOpenPrintReportButtonClick");
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("DeleteYesMessage")) {
							context.QueueTasks.Enqueue("DeleteYesMessage");
						}
						break;
					case "CreateMSWordReportMessage":
							if (ActivatedEventElements.Contains("CreateMSWordReportMessageStartMessage")) {
							context.QueueTasks.Enqueue("CreateMSWordReportMessageStartMessage");
						}
						break;
					case "SaveReportToLocalDisk":
							if (ActivatedEventElements.Contains("SaveReportToLocalDiskStartMessage")) {
							context.QueueTasks.Enqueue("SaveReportToLocalDiskStartMessage");
						}
						break;
					case "TreeGridDblClick":
							if (ActivatedEventElements.Contains("TreeGridDblClick")) {
							context.QueueTasks.Enqueue("TreeGridDblClick");
						}
						break;
					case "GridPageRefreshRow":
							if (ActivatedEventElements.Contains("StartMessageNonInterruptingEvent2")) {
							context.QueueTasks.Enqueue("StartMessageNonInterruptingEvent2");
						}
						break;
					case "DataSourceActiveRowChanged":
							if (ActivatedEventElements.Contains("DataSourceActiveRowChangedEvent")) {
							context.QueueTasks.Enqueue("DataSourceActiveRowChangedEvent");
						}
						break;
					case "DataSourceLoadRowsResponseRegistered":
							if (ActivatedEventElements.Contains("DataSourceLoadRowsResponseRegisteredStartMessage")) {
							context.QueueTasks.Enqueue("DataSourceLoadRowsResponseRegisteredStartMessage");
						}
						break;
					case "DataSourceLoading":
							if (ActivatedEventElements.Contains("DataSourceLoading")) {
							context.QueueTasks.Enqueue("DataSourceLoading");
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("StartMessageBasePrepareFilters")) {
							context.QueueTasks.Enqueue("StartMessageBasePrepareFilters");
						}
						break;
					case "InitializeFilterEdit":
							if (ActivatedEventElements.Contains("StartMessageInitializeFilterEdit")) {
							context.QueueTasks.Enqueue("StartMessageInitializeFilterEdit");
						}
						break;
					case "ClearData":
							if (ActivatedEventElements.Contains("StartClearData")) {
							context.QueueTasks.Enqueue("StartClearData");
						}
						break;
					case "SelectFolder":
							if (ActivatedEventElements.Contains("SelectFolder")) {
							context.QueueTasks.Enqueue("SelectFolder");
						}
						break;
					case "ApplySearchFilter":
							if (ActivatedEventElements.Contains("ApplySearchFilter")) {
							context.QueueTasks.Enqueue("ApplySearchFilter");
						}
						break;
					case "RunModuleProcess":
							if (ActivatedEventElements.Contains("StartRunModuleProcess")) {
							context.QueueTasks.Enqueue("StartRunModuleProcess");
						}
						break;
					case "ProcessPropsWindowClosed":
							if (ActivatedEventElements.Contains("StartProcessPropsWindowClosed")) {
							context.QueueTasks.Enqueue("StartProcessPropsWindowClosed");
						}
						break;
					case "CreateNewProcessMenuItemClick":
							if (ActivatedEventElements.Contains("StartCreateNewProcessMenuItemClick")) {
							context.QueueTasks.Enqueue("StartCreateNewProcessMenuItemClick");
						}
						break;
					case "ShowMessage":
							if (ActivatedEventElements.Contains("StartShowMessage")) {
							context.QueueTasks.Enqueue("StartShowMessage");
						}
						break;
					case "TuningModeChanged":
							if (ActivatedEventElements.Contains("StartTuningModeChanged")) {
							context.QueueTasks.Enqueue("StartTuningModeChanged");
						}
						break;
					case "CreateNewSysModuleReportMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageCreateNewSysModuleReportMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageCreateNewSysModuleReportMenuItemClick");
						}
						break;
					case "SysModuleReportPropsWindowClosed":
							if (ActivatedEventElements.Contains("SysModuleReportPropsWindowClosedStartMessage")) {
							context.QueueTasks.Enqueue("SysModuleReportPropsWindowClosedStartMessage");
						}
						break;
					case "SetDetailPrintButtonMenu":
							if (ActivatedEventElements.Contains("SetDetailPrintButtonMenuStartMessage1")) {
							context.QueueTasks.Enqueue("SetDetailPrintButtonMenuStartMessage1");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("MailboxSyncSettingsLinkId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MailboxSyncSettingsLinkId", MailboxSyncSettingsLinkId, Guid.Empty);
			}
			if (!HasMapping("MenuVideoHelpItemCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MenuVideoHelpItemCaption", MenuVideoHelpItemCaption, null);
			}
			if (!HasMapping("MenuHelpItemCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MenuHelpItemCaption", MenuHelpItemCaption, null);
			}
			if (!HasMapping("SysModuleProcessPrimaryColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleProcessPrimaryColumnUId", SysModuleProcessPrimaryColumnUId, Guid.Empty);
			}
			if (!HasMapping("IsModuleProcessesTuningMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsModuleProcessesTuningMode", IsModuleProcessesTuningMode, false);
			}
			if (!HasMapping("IsPrimaryGrid") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsPrimaryGrid", IsPrimaryGrid, false);
			}
			if (!HasMapping("SelectedTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedTypeId", SelectedTypeId, Guid.Empty);
			}
			if (!HasMapping("PrintReportPageHelpContextId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PrintReportPageHelpContextId", PrintReportPageHelpContextId, null);
			}
			if (!HasMapping("EditPageHelpContextId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditPageHelpContextId", EditPageHelpContextId, null);
			}
			if (!HasMapping("IsContextHelpButtonInitialized") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsContextHelpButtonInitialized", IsContextHelpButtonInitialized, false);
			}
			if (!HasMapping("UseModuleDetails") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UseModuleDetails", UseModuleDetails, false);
			}
			if (!HasMapping("SysModuleEditId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleEditId", SysModuleEditId, Guid.Empty);
			}
			if (TypeEditPageUIds != null) {
				if (TypeEditPageUIds.GetType().IsSerializable ||
					TypeEditPageUIds.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("TypeEditPageUIds", TypeEditPageUIds, null);
				}
			}
			if (!HasMapping("TypeColumnUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("TypeColumnUId", TypeColumnUId, Guid.Empty);
			}
			if (!HasMapping("LocatedInEditPage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LocatedInEditPage", LocatedInEditPage, false);
			}
			if (!HasMapping("SynchronizeDataSourceStructure") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SynchronizeDataSourceStructure", SynchronizeDataSourceStructure, false);
			}
			if (!HasMapping("AddToMenuItemMoveTo") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AddToMenuItemMoveTo", AddToMenuItemMoveTo, false);
			}
			if (!HasMapping("ListenerPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ListenerPageProcessUId", ListenerPageProcessUId, null);
			}
			if (!HasMapping("DefaultWay") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DefaultWay", DefaultWay, false);
			}
			if (!HasMapping("ParentColumnMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentColumnMetaPath", ParentColumnMetaPath, null);
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
			if (!HasMapping("SysModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
			}
			if (!HasMapping("NeedAddDetailRequest") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedAddDetailRequest", NeedAddDetailRequest, false);
			}
			if (!HasMapping("CurrentGridSchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentGridSchemaName", CurrentGridSchemaName, null);
			}
			if (!HasMapping("SelectedFolderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedFolderId", SelectedFolderId, Guid.Empty);
			}
			if (!HasMapping("DisableButtons") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DisableButtons", DisableButtons, false);
			}
			if (!HasMapping("IsSearch") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSearch", IsSearch, false);
			}
			if (!HasMapping("IsDetailGrid") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDetailGrid", IsDetailGrid, false);
			}
			if (!HasMapping("DefValuesId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DefValuesId", DefValuesId, Guid.Empty);
			}
			if (!HasMapping("EditPageQueryStringAddition") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditPageQueryStringAddition", EditPageQueryStringAddition, null);
			}
			if (!HasMapping("SysEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysEntitySchemaId", SysEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("SelectedNodePrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedNodePrimaryColumnValue", SelectedNodePrimaryColumnValue, Guid.Empty);
			}
			if (!HasMapping("SysModuleDetailId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleDetailId", SysModuleDetailId, Guid.Empty);
			}
			if (!HasMapping("ParentFieldName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentFieldName", ParentFieldName, null);
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

	#region Class: BaseGridPageEventsProcess

	/// <exclude/>
	public class BaseGridPageEventsProcess : BaseGridPageEventsProcess<Terrasoft.WebApp.BaseGridPageSchemaUserControl>
	{

		public BaseGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseGridPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

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

		public Terrasoft.UI.WebControls.Controls.Button CopyButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CopyButton", true);
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

		public Terrasoft.UI.WebControls.Controls.Spacer SpacerPrintButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("SpacerPrintButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ActionButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ActionButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button PrintButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("PrintButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid TreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("TreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem SendEmailMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("SendEmailMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem SendTemplateEmailMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("SendTemplateEmailMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem CallMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("CallMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem ShowChangelogMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("ShowChangelogMenuItem", true);
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
			TreeGrid.AjaxEvents.ContextMenu.Event += TreeGridContextMenu;
			CallMenuItem.AjaxEvents.PrepareMenu.Event += CallMenuItemPrepareMenu;
			ShowChangelogMenuItem.AjaxEvents.Click.Event += ShowChangelogMenuItemClick;
			DataSource.AjaxEvents.ActiveRowChanged.Event += DataSourceActiveRowChanged;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			TreeGrid.AjaxEvents.ContextMenu.Event -= TreeGridContextMenu;
			CallMenuItem.AjaxEvents.PrepareMenu.Event -= CallMenuItemPrepareMenu;
			ShowChangelogMenuItem.AjaxEvents.Click.Event -= ShowChangelogMenuItemClick;
			DataSource.AjaxEvents.ActiveRowChanged.Event -= DataSourceActiveRowChanged;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseGridPageEventsProcess(UserConnection);
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

		public virtual void TreeGridContextMenu(object sender, EventArgs e) {
			object result = ThrowEvent("TreeGridContextMenu");
		}

		public virtual void CallMenuItemPrepareMenu(object sender, EventArgs e) {
			object result = ThrowEvent("CallMenuItemPrepareMenu");
		}

		public virtual void ShowChangelogMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("ShowChangelogMenuItemClick");
		}

		public virtual void DataSourceActiveRowChanged(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceActiveRowChanged");
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
			SchemaName = "BaseGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseGridPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseGridPageEventsProcessSchema(BaseGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseGridPageEventsProcess";
			UId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
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
			UId = new Guid("8646af6b-c3ce-40b2-8598-f31c1f0efb18"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3f9742e8-11f3-4287-a41a-cee847838aa0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EntitySchemaManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a676227c-1197-410d-9d09-3e896ddf170d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EditPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFilterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("74f7b7c6-3f97-4723-bf07-f7d486edd921"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8b8c2fa5-b200-4407-b3cb-24e745ca553d"),
				ContainerUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ListenerPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterLeftExpressionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7777c776-3e5f-4a6b-bb8f-1607da19206c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"FilterLeftExpression",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentFieldNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("263bb18b-aefa-4be6-b251-2a47246b6df4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ParentFieldName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleDetailIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce1de52e-ea94-446f-8b8b-fbb7c4668aca"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SysModuleDetailId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedNodePrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1f457134-7eaf-4879-8c29-c78a46ed517e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SelectedNodePrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77ef7490-0e81-4272-996a-82ecda9a93da"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SysEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditPageQueryStringAdditionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1ea1b70d-ec51-4d8d-95aa-1b8e043f2a77"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EditPageQueryStringAddition",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefValuesIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f2c59f3a-ff29-4e6d-aafb-492b3343fa01"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DefValuesId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDetailGridParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("04bdc9fb-7b3e-46b2-a9d5-f9fb06051373"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"IsDetailGrid",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSearchParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce69f72a-6ac6-467b-9fe6-45a3eb55e8f6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"IsSearch",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDisableButtonsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("400ae67a-67f6-4520-9315-e8c60e97783b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DisableButtons",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6ab778b8-b696-4324-a924-90f6e7d15777"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SelectedFolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceLoadingEventArgsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("916904b3-2b63-45bd-902a-da64487f146c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceLoadingEventArgs",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentGridSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3e1d8f00-bc74-457f-8611-6c8e9b8a914e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CurrentGridSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedAddDetailRequestParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("04e689cc-5f7c-4d5d-b36b-ff088ea37a5b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"NeedAddDetailRequest",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0f6e6f6e-0588-4373-83e1-2b815e04286c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SysModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrintReportSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("18a9613d-83cd-4b5a-809b-a79701e39948"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"PrintReportSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrintReportOptionsSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ef5689e4-959f-427b-9482-a548cb350863"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"PrintReportOptionsSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNotRecivePrintReportMenuParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("50f690ca-0a16-4b15-a8b6-640043076b04"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"NotRecivePrintReportMenu",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentColumnMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6d8fc116-adb4-4e66-aba9-0970487f1a0c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ParentColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultWayParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("457df590-490d-4997-9f71-4d354f7cdc29"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DefaultWay",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3c2d83af-d521-4926-a50d-992f01b91a59"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ListenerPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAddToMenuItemMoveToParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0bf7eff0-e467-41df-aed8-3963f886ba3e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"AddToMenuItemMoveTo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSynchronizeDataSourceStructureParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b0cdbf7d-2ad9-487b-b180-706575edd033"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SynchronizeDataSourceStructure",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLocatedInEditPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("40c28186-0b0f-4e41-b533-a88aa426775b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"LocatedInEditPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTypeColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eb8b4c75-f742-49d5-89af-3383f40f9fa9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"TypeColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTypeEditPageUIdsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a8f38f24-d677-4caf-8226-6a8a6e624fb2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"TypeEditPageUIds",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleEditIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("18d60bb1-ea1e-496b-884d-a9e836b0a673"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SysModuleEditId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUseModuleDetailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("498b0ce9-a217-490d-8853-96a1ef38a037"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"UseModuleDetails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsContextHelpButtonInitializedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9a4c51c6-76f6-4d0f-907f-4078d4285e54"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"IsContextHelpButtonInitialized",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditPageHelpContextIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("09899841-b165-4974-b495-e4929694265a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EditPageHelpContextId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrintReportPageHelpContextIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cdc31e96-4c12-47eb-9120-6818edf9907d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"PrintReportPageHelpContextId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f9611021-b05f-4ce2-a7da-9255273f8063"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SelectedTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsPrimaryGridParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("37b31ed6-9b7e-41c3-87b6-ae564c94413f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"IsPrimaryGrid",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsModuleProcessesTuningModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fba0bf94-4210-4cb7-b2c6-3874bb180614"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"IsModuleProcessesTuningMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleProcessPrimaryColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e86847a9-4763-4a6e-9c66-3503345b62f8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SysModuleProcessPrimaryColumnUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMenuHelpItemCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("462f6910-5b78-41b8-be43-b7cc5214eb85"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"MenuHelpItemCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMenuVideoHelpItemCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e56cb3d7-d0db-46ac-8a22-93c3d0146021"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"MenuVideoHelpItemCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMailboxSyncSettingsLinkIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7ed6b59a-be57-4f10-b1b4-0a2ce8323923"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"MailboxSyncSettingsLinkId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateEntitySchemaManagerNameParameter());
			Parameters.Add(CreateEditPageUIdParameter());
			Parameters.Add(CreateDataSourceFilterParameter());
			Parameters.Add(CreateListenerPageParameter());
			Parameters.Add(CreateFilterLeftExpressionParameter());
			Parameters.Add(CreateParentFieldNameParameter());
			Parameters.Add(CreateSysModuleDetailIdParameter());
			Parameters.Add(CreateSelectedNodePrimaryColumnValueParameter());
			Parameters.Add(CreateSysEntitySchemaIdParameter());
			Parameters.Add(CreateEditPageQueryStringAdditionParameter());
			Parameters.Add(CreateDefValuesIdParameter());
			Parameters.Add(CreateIsDetailGridParameter());
			Parameters.Add(CreateIsSearchParameter());
			Parameters.Add(CreateDisableButtonsParameter());
			Parameters.Add(CreateSelectedFolderIdParameter());
			Parameters.Add(CreateDataSourceLoadingEventArgsParameter());
			Parameters.Add(CreateCurrentGridSchemaNameParameter());
			Parameters.Add(CreateNeedAddDetailRequestParameter());
			Parameters.Add(CreateSysModuleIdParameter());
			Parameters.Add(CreatePrintReportSchemaUIdParameter());
			Parameters.Add(CreatePrintReportOptionsSchemaUIdParameter());
			Parameters.Add(CreateNotRecivePrintReportMenuParameter());
			Parameters.Add(CreateParentColumnMetaPathParameter());
			Parameters.Add(CreateDefaultWayParameter());
			Parameters.Add(CreateListenerPageProcessUIdParameter());
			Parameters.Add(CreateAddToMenuItemMoveToParameter());
			Parameters.Add(CreateSynchronizeDataSourceStructureParameter());
			Parameters.Add(CreateLocatedInEditPageParameter());
			Parameters.Add(CreateTypeColumnUIdParameter());
			Parameters.Add(CreateTypeEditPageUIdsParameter());
			Parameters.Add(CreateSysModuleEditIdParameter());
			Parameters.Add(CreateUseModuleDetailsParameter());
			Parameters.Add(CreateIsContextHelpButtonInitializedParameter());
			Parameters.Add(CreateEditPageHelpContextIdParameter());
			Parameters.Add(CreatePrintReportPageHelpContextIdParameter());
			Parameters.Add(CreateSelectedTypeIdParameter());
			Parameters.Add(CreateIsPrimaryGridParameter());
			Parameters.Add(CreateIsModuleProcessesTuningModeParameter());
			Parameters.Add(CreateSysModuleProcessPrimaryColumnUIdParameter());
			Parameters.Add(CreateMenuHelpItemCaptionParameter());
			Parameters.Add(CreateMenuVideoHelpItemCaptionParameter());
			Parameters.Add(CreateMailboxSyncSettingsLinkIdParameter());
		}

		protected virtual void InitializeViewRecordAllChangesProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4d4871c0-6451-491d-a279-3ebb3823c2ce"),
				ContainerUId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"PageInstanceId",
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
				UId = new Guid("20dbe5b6-386e-46e4-8cf9-e6255205c009"),
				ContainerUId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
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
				UId = new Guid("641a5a84-b66e-418e-9383-491740db6867"),
				ContainerUId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"ShowGrid",
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
				UId = new Guid("466c55ff-bd70-49e5-a774-bf7a3b2745e6"),
				ContainerUId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"CurrentSchemaUId",
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
				UId = new Guid("04a633ec-0ccd-44c9-bdf3-1b54ba8cc52c"),
				ContainerUId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"ActiveTreeGridCurrentRowId",
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
				UId = new Guid("94f28b2c-0f4b-41a5-b788-d255285509a8"),
				ContainerUId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"FilterByChangeTracked",
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
				UId = new Guid("a549cf9b-b631-4f10-89e6-2cf0f6b69bc4"),
				ContainerUId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				Name = @"RecordNotSelectedMessage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
			});
		}

		protected virtual void InitializeLoadPrintReportButtonMenuProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("6deeca81-4823-41a4-832b-2a3fc9e96008"),
				ContainerUId = new Guid("cde71fb5-e60e-4225-a880-ab81c127d7d7"),
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
				UId = new Guid("b4aef445-babc-4878-975b-945810feeea3"),
				ContainerUId = new Guid("cde71fb5-e60e-4225-a880-ab81c127d7d7"),
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

		protected virtual void InitializeOpenEmailEditPage_BaseGridPage_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d7a09fcf-9aa9-4759-b8ae-9e4782a567d4"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8635ec04-c7ca-4f16-8668-38952809cc89"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d5a4ed02-fba2-45d2-892a-52a9ee2ddc2d"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("38b0f053-86fb-4b8b-ab8e-a798f795ccc2"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7b4139af-653c-4c67-8ec1-a27ab91fb55f"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("47c7f05c-c0ad-42cf-93dc-5af6656cf418"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("12e489ab-5ba5-49fe-8cb3-fa4dfea5450f"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("00f4e590-3884-4e9e-bf45-4a0d2d0cf6c9"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b139ce69-5e53-4680-97dc-e60ed462d99b"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("476b85cf-6b1a-4877-8cc5-92e64f05ea27"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("db614a9c-7815-4e6d-b546-37cb590b0d1a"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0d8ab7fb-044f-43f3-a3ff-74a1d960b704"),
				ContainerUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeShowNoPhoneNumbersUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("8a58e958-ce7b-4005-9bc9-a338479e6222"),
				ContainerUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
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
				UId = new Guid("66630936-5101-4dfd-b0ca-e88c7c429715"),
				ContainerUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
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
				UId = new Guid("1269815d-9e93-44dd-afe0-7719257a5cc2"),
				ContainerUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
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
				UId = new Guid("75325b40-3782-4e1f-a1db-6c2ce75eb012"),
				ContainerUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
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
				UId = new Guid("0de1b57d-038f-4703-853f-75f31435faa2"),
				ContainerUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
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
				UId = new Guid("c38affd8-6758-40e4-8d90-893354fe7845"),
				ContainerUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
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
				UId = new Guid("d9e883f2-a563-4bed-bede-7baedb43f898"),
				ContainerUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
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
				UId = new Guid("3bb62243-3992-4bd2-9f02-caadcc79aefc"),
				ContainerUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
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

		protected virtual void InitializeOpenSelectNumberUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("251fef28-a8bc-47d1-9e6e-f9b58cf81f46"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0adab7d2-fb20-4de3-bc3e-a743270e8a8b"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2b061492-82f6-4182-8101-a70d941e5d0b"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7edff7a3-2c62-4e41-824a-9ae175722d6f"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("64b1399f-7462-4702-8e39-16ec6be10ee3"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4cf860c5-f71f-4f0e-8495-7065c3a50c1c"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f1b0cf51-52d0-41ce-bf90-d00c280b1b62"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e358ecff-7789-4121-ad7b-d77b08779d7b"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2fa203cb-6cc7-428c-ab76-36127554bd19"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6bcfc206-ff7c-4c46-ab06-f355a03e398b"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3a1008e1-b144-40fc-8338-a48076fe8419"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1b453143-5a6e-4b2a-9217-7f8e0589e455"),
				ContainerUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeUserTaskAddOpenWindowParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("756432c0-bd0e-41e4-af53-772aa3f430a6"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d7747ab1-6316-47a2-8860-f288778803b5"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("32f55e51-4236-41ea-9e11-d65b27f5f033"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3ac446ba-6e18-425c-b9e2-38322c0ad78b"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0381fbb1-bc8a-48c0-9150-1fbc44aff63a"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("bafe8109-2e0a-42a9-ac52-e3697464ca46"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("32cad288-4759-4b29-89b4-e6a1f541b666"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ef28bab7-ebb4-4653-a6d2-cc318bd27b1c"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("be15b521-617b-4ee7-b4f4-49b06ea60269"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("211e6203-e81c-4976-8c50-3236cb1fbd6f"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("92c36fd1-4af6-4a57-be0a-0937956f1afb"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("091daa64-33c3-40e8-a4e4-f9c900765de6"),
				ContainerUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeUserTaskEditOpenWindowParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("33356136-f495-4e0b-9bac-195b0a98cd3d"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("09b6fc3b-ac0e-4e76-b156-d67c1c82da5b"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2aa7e66b-bed5-4c8f-804c-8b2af23b3a0d"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4108e476-b3b1-438e-84f7-8577704a0d2f"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fc9b8584-5e54-4b8d-86d1-102f083bc19d"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8a08bee0-52c5-4bce-8187-b97568fb38a8"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a4ca434d-56d9-455d-9384-13e7676929ab"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("418b1237-9863-4ade-a58f-7a0456a38adc"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("65057a58-e0d8-43af-9f9d-c49ddbfd401d"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e2c8057b-ad88-49d9-943d-e5152e2cb68c"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("903b012b-d045-4bcc-8fb8-9478e45aa477"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3482e2a1-6f9c-4513-980d-8c0599ce30cf"),
				ContainerUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7dd65f74-d085-45c2-a38b-7e93fb4db1f7"),
				ContainerUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
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
				UId = new Guid("6bf73810-c4ef-4dbe-a5e0-2527ca1b3812"),
				ContainerUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
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
				UId = new Guid("b4c71516-7f8b-4e94-bb9b-194e3ce8e84a"),
				ContainerUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
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
				UId = new Guid("f5c582d5-91fd-4ca9-9abe-f5810f8f9bbf"),
				ContainerUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
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
				UId = new Guid("c775dc92-e3e1-49a3-8cc0-606ca32c76fe"),
				ContainerUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
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
				UId = new Guid("20926060-9171-4e67-acfb-4a14b1dbec38"),
				ContainerUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
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
				UId = new Guid("f0bf45cf-b35c-4264-88e4-7cc70a42a3aa"),
				ContainerUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
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
				UId = new Guid("4bbb8081-b66a-44d6-b331-1755767d3a0b"),
				ContainerUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
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

		protected virtual void InitializeUserTaskOpenCopyEditPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5e975836-cc27-4b0e-a0d9-ac1d7bbefebf"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ade72140-a472-40f9-b590-c00cf6181dcd"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7c436d4f-6127-4eff-9333-e8ab5baf103e"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("67bebe4b-295b-4ca3-b392-49b500bc73c8"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8387953c-ed39-417c-abc2-32cf60b703fa"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c260aac9-7533-4833-ba0a-1c617a8dccdc"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2b73258b-cefa-4f3e-b294-d14372675a5c"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b342c1d0-a616-40db-b643-0480985788c5"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("433c53fa-84a8-4e03-9c4b-9d469081f874"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9096ed4e-4db6-4add-aea2-617820311c7b"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b7eaa146-4ea4-4a96-9db1-255f9f0a3d0f"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("db47f53c-e799-448e-9463-33b8c792d890"),
				ContainerUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeUserTaskPrintOpenWindowParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("df54b1b7-959f-4f3d-bd01-d388dd659e66"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3fedddf7-b23d-40bb-811a-8c8ee955d9c0"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a773fe66-04d5-4180-b97f-160391178c83"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("35d6711c-ab35-45bd-b1de-1391365aa4b1"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a46516b8-a0aa-4ed9-a705-a4688822d456"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d526b4ad-c24e-402c-91c1-bed56f75f2d3"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("639b79ac-d138-4adb-b14f-6cca8548e323"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d81761a9-3aad-4dcb-b46c-8f0d4ddcd6ce"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1e1c0d43-7a2c-41d2-89d3-667b9f994a6e"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f42f1e9e-524e-4c93-8843-7d57e3f613f5"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("34eb64a2-3883-465c-ab72-9614be26c1b1"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9c7afed4-0d20-4ee6-aedf-face67ea0b68"),
				ContainerUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeShowMSWordReportCreatedUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("02ab4851-fb50-49c8-b332-b3ee63538f50"),
				ContainerUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
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
				UId = new Guid("1b2fab2f-ac29-4124-875d-4581b9fba4a0"),
				ContainerUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
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
				UId = new Guid("37bb3e7c-040b-4857-b2cb-b1af24bdf21d"),
				ContainerUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
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
				UId = new Guid("eef6d66d-f25c-48b9-9ff4-b20c805afd08"),
				ContainerUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
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
				UId = new Guid("50f8aaa5-3237-4e72-802b-936d3e79dec0"),
				ContainerUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
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
				UId = new Guid("4d0acc18-6a10-44d9-9a0b-3bf2484ac9b2"),
				ContainerUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
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
				UId = new Guid("3aa47625-2fac-4af1-bba4-5f1d232196d8"),
				ContainerUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
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
				UId = new Guid("29ebb8e9-27d1-46a1-93b6-dd60e102d43d"),
				ContainerUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
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

		protected virtual void InitializeOpenProcessEditUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("74f151f0-fc06-4868-a458-bcb565030780"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("01efc4bb-7db5-47d1-a7c9-17a85188aa9b"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("23fd1298-2120-41f7-93d6-432f402b9302"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d3f1f86a-9935-4a44-a315-4b1a530c164b"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2c384617-7ccd-453a-a7ad-e14189f5a8f0"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5c6cb596-c03f-4515-b57c-a19cbd0b7c6d"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a31d2ef8-2499-4cf0-9380-104b14ca7676"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d278b987-4cc0-4cf6-86dd-e3c56fa0e0be"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9453d32b-801b-462b-97a2-114a7398850c"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c94d123b-a8e3-49b5-a687-5ea227a97ecf"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4defa774-7a10-4062-ba5c-5784f08c1438"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("594ec966-ea6b-4e2c-8cc8-4c9e578fa326"),
				ContainerUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeMessageWindowUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("3639fbe2-9a45-49ac-84c3-a7b57ccc4b6e"),
				ContainerUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
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
				UId = new Guid("d4b17c95-fd0f-46b7-bb07-bf8849944c95"),
				ContainerUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
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
				UId = new Guid("7f0fcdaf-2abc-465d-9fe7-947dd116bf2e"),
				ContainerUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
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
				UId = new Guid("d5a2f611-a081-4ab3-972d-07b20b50929f"),
				ContainerUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
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
				UId = new Guid("5a61e7cd-abd1-49fc-9336-132ee053f77e"),
				ContainerUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
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
				UId = new Guid("0f855a1b-bef7-4aed-8659-08d47acbd110"),
				ContainerUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
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
				UId = new Guid("91366d54-91dd-4197-abf9-0542708c4a67"),
				ContainerUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
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
				UId = new Guid("60a386ce-d6e5-472c-900f-823a7edc277e"),
				ContainerUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
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

		protected virtual void InitializeCreateNewSysModuleReportMenuItemClickUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4825dd48-c526-48a0-9b06-9abed6d1341f"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9fb69c6b-e422-4faf-b501-69d5a1ea8412"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3fa99bfd-1a15-4d76-bedf-d5b3e656ddd3"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("47fbf835-64eb-4b1f-92b4-7f8885bccf74"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("52febef1-6cea-4c04-868f-cad042cd8b13"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9130feb6-9c3b-48fb-ba72-93a3fe93339d"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("af78b274-f8e6-4c11-89a4-8919adeb03e8"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7c571cf6-027c-4a94-80db-98a0d2393a60"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fd59103b-4a66-49a8-b3fc-adc99f992954"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("16fdcff6-fd0b-4141-83ac-595dceb79220"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2fb4cf84-aed8-4dfc-9e0f-f30dcdb935b2"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ab1266c7-3f58-4f45-be07-88ac17dd4877"),
				ContainerUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
			ProcessSchemaLaneSet schemaLaneSet26 = CreateLaneSet26LaneSet();
			LaneSets.Add(schemaLaneSet26);
			ProcessSchemaLane schemaContextMenuLane_BaseGridPage = CreateContextMenuLane_BaseGridPageLane();
			schemaLaneSet26.Lanes.Add(schemaContextMenuLane_BaseGridPage);
			ProcessSchemaEventSubProcess eventsubprocess1_basegridpage = CreateEventSubProcess1_BaseGridPageEventSubProcess();
			FlowElements.Add(eventsubprocess1_basegridpage);
			ProcessSchemaEventSubProcess eventsubprocess8_basegridpage = CreateEventSubProcess8_BaseGridPageEventSubProcess();
			FlowElements.Add(eventsubprocess8_basegridpage);
			ProcessSchemaEventSubProcess eventsubprocess12539 = CreateEventSubProcess12539EventSubProcess();
			FlowElements.Add(eventsubprocess12539);
			ProcessSchemaSubProcess viewrecordallchangesprocess = CreateViewRecordAllChangesProcessSubProcess();
			eventsubprocess12539.FlowElements.Add(viewrecordallchangesprocess);
			ProcessSchemaEventSubProcess eventsubprocess1werwe = CreateEventSubProcess1werweEventSubProcess();
			FlowElements.Add(eventsubprocess1werwe);
			ProcessSchemaEventSubProcess eventsubprocess1bghhj = CreateEventSubProcess1bghhjEventSubProcess();
			FlowElements.Add(eventsubprocess1bghhj);
			ProcessSchemaEventSubProcess sendtemplateemailmenuitempreparemenustartmessageeventsubprocess = CreateSendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcessEventSubProcess();
			FlowElements.Add(sendtemplateemailmenuitempreparemenustartmessageeventsubprocess);
			ProcessSchemaEventSubProcess processemailtemplatecontextitemclickeventsubprocess = CreateProcessEmailTemplateContextItemClickEventSubProcessEventSubProcess();
			FlowElements.Add(processemailtemplatecontextitemclickeventsubprocess);
			ProcessSchemaEventSubProcess basegridpageinit = CreateBaseGridPageInitEventSubProcess();
			FlowElements.Add(basegridpageinit);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess = CreatePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess);
			ProcessSchemaSubProcess loadprintreportbuttonmenuprocess = CreateLoadPrintReportButtonMenuProcessSubProcess();
			pageloadcompleteeventsubprocess.FlowElements.Add(loadprintreportbuttonmenuprocess);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess subprocess5 = CreateSubProcess5EventSubProcess();
			FlowElements.Add(subprocess5);
			ProcessSchemaEventSubProcess subprocessopenprintreport = CreateSubProcessOpenPrintReportEventSubProcess();
			FlowElements.Add(subprocessopenprintreport);
			ProcessSchemaEventSubProcess subprocess4 = CreateSubProcess4EventSubProcess();
			FlowElements.Add(subprocess4);
			ProcessSchemaEventSubProcess createmswordreportmessageeventsubprocess = CreateCreateMSWordReportMessageEventSubProcessEventSubProcess();
			FlowElements.Add(createmswordreportmessageeventsubprocess);
			ProcessSchemaEventSubProcess savereporttolocaldiskeventsubprocess = CreateSaveReportToLocalDiskEventSubProcessEventSubProcess();
			FlowElements.Add(savereporttolocaldiskeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess datasourceactiverowchangedeventsubprocess = CreateDataSourceActiveRowChangedEventSubProcessEventSubProcess();
			FlowElements.Add(datasourceactiverowchangedeventsubprocess);
			ProcessSchemaEventSubProcess datasourceloadrowsresponseregisteredeventsubprocess = CreateDataSourceLoadRowsResponseRegisteredEventSubProcessEventSubProcess();
			FlowElements.Add(datasourceloadrowsresponseregisteredeventsubprocess);
			ProcessSchemaEventSubProcess datasourceloadingsubprocess = CreateDataSourceLoadingSubProcessEventSubProcess();
			FlowElements.Add(datasourceloadingsubprocess);
			ProcessSchemaEventSubProcess basepreparefiltersdatasourcesubprocess = CreateBasePrepareFiltersDataSourceSubProcessEventSubProcess();
			FlowElements.Add(basepreparefiltersdatasourcesubprocess);
			ProcessSchemaEventSubProcess eventsubprocessinitializefilteredit = CreateEventSubProcessInitializeFilterEditEventSubProcess();
			FlowElements.Add(eventsubprocessinitializefilteredit);
			ProcessSchemaEventSubProcess eventsubprocesscleardata = CreateEventSubProcessClearDataEventSubProcess();
			FlowElements.Add(eventsubprocesscleardata);
			ProcessSchemaEventSubProcess subprocessselectfolder = CreateSubProcessSelectFolderEventSubProcess();
			FlowElements.Add(subprocessselectfolder);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess eventsubprocessrunmoduleprocess = CreateEventSubProcessRunModuleProcessEventSubProcess();
			FlowElements.Add(eventsubprocessrunmoduleprocess);
			ProcessSchemaEventSubProcess eventsubprocessprocesspropswindowclosed = CreateEventSubProcessProcessPropsWindowClosedEventSubProcess();
			FlowElements.Add(eventsubprocessprocesspropswindowclosed);
			ProcessSchemaEventSubProcess eventsubprocess1openprocessedit = CreateEventSubProcess1OpenProcessEditEventSubProcess();
			FlowElements.Add(eventsubprocess1openprocessedit);
			ProcessSchemaEventSubProcess eventsubprocessshowmessage = CreateEventSubProcessShowMessageEventSubProcess();
			FlowElements.Add(eventsubprocessshowmessage);
			ProcessSchemaEventSubProcess eventsubprocess1tuningmodechanged = CreateEventSubProcess1TuningModeChangedEventSubProcess();
			FlowElements.Add(eventsubprocess1tuningmodechanged);
			ProcessSchemaEventSubProcess createnewsysmodulereportmenuitemclickeventsubprocess = CreateCreateNewSysModuleReportMenuItemClickEventSubProcessEventSubProcess();
			FlowElements.Add(createnewsysmodulereportmenuitemclickeventsubprocess);
			ProcessSchemaEventSubProcess sysmodulereportpropswindowclosedeventsubprocess = CreateSysModuleReportPropsWindowClosedEventSubProcessEventSubProcess();
			FlowElements.Add(sysmodulereportpropswindowclosedeventsubprocess);
			ProcessSchemaEventSubProcess setdetailprintbuttonmenueventsubprocess1 = CreateSetDetailPrintButtonMenuEventSubProcess1EventSubProcess();
			FlowElements.Add(setdetailprintbuttonmenueventsubprocess1);
			ProcessSchemaStartMessageEvent sendemailmenuitempreparemenu_basegridpage_startmessage = CreateSendEmailMenuItemPrepareMenu_BaseGridPage_StartMessageStartMessageEvent();
			eventsubprocess1_basegridpage.FlowElements.Add(sendemailmenuitempreparemenu_basegridpage_startmessage);
			ProcessSchemaScriptTask createemailcustomcontextmenu_scripttask = CreateCreateEmailCustomContextMenu_ScriptTaskScriptTask();
			eventsubprocess1_basegridpage.FlowElements.Add(createemailcustomcontextmenu_scripttask);
			ProcessSchemaStartMessageEvent processemailcontextitemclick_startmessage = CreateProcessEmailContextItemClick_StartMessageStartMessageEvent();
			eventsubprocess8_basegridpage.FlowElements.Add(processemailcontextitemclick_startmessage);
			ProcessSchemaScriptTask processemailcontextmenuclick_scripttask = CreateProcessEmailContextMenuClick_ScriptTaskScriptTask();
			eventsubprocess8_basegridpage.FlowElements.Add(processemailcontextmenuclick_scripttask);
			ProcessSchemaUserTask openemaileditpage_basegridpage_usertask = CreateOpenEmailEditPage_BaseGridPage_UserTaskUserTask();
			eventsubprocess8_basegridpage.FlowElements.Add(openemaileditpage_basegridpage_usertask);
			ProcessSchemaScriptTask showchangelogmenuitemclickscripttask = CreateShowChangelogMenuItemClickScriptTaskScriptTask();
			eventsubprocess12539.FlowElements.Add(showchangelogmenuitemclickscripttask);
			ProcessSchemaStartMessageEvent showchangelogmenuitemclickstartmessage = CreateShowChangelogMenuItemClickStartMessageStartMessageEvent();
			eventsubprocess12539.FlowElements.Add(showchangelogmenuitemclickstartmessage);
			ProcessSchemaStartMessageEvent startmessage1ddrrg = CreateStartMessage1ddrrgStartMessageEvent();
			eventsubprocess1werwe.FlowElements.Add(startmessage1ddrrg);
			ProcessSchemaScriptTask createcallcustomcontextmenu_scripttask = CreateCreateCallCustomContextMenu_ScriptTaskScriptTask();
			eventsubprocess1werwe.FlowElements.Add(createcallcustomcontextmenu_scripttask);
			ProcessSchemaStartMessageEvent processcallcontextitemclick_startmessage = CreateProcessCallContextItemClick_StartMessageStartMessageEvent();
			eventsubprocess1bghhj.FlowElements.Add(processcallcontextitemclick_startmessage);
			ProcessSchemaScriptTask processcallcontextmenuitemclick_scripttask = CreateProcessCallContextMenuItemClick_ScriptTaskScriptTask();
			eventsubprocess1bghhj.FlowElements.Add(processcallcontextmenuitemclick_scripttask);
			ProcessSchemaStartMessageEvent numberselectedmessage = CreateNumberSelectedMessageStartMessageEvent();
			eventsubprocess1bghhj.FlowElements.Add(numberselectedmessage);
			ProcessSchemaExclusiveGateway exclusivegateway3wwwcc = CreateExclusiveGateway3wwwccExclusiveGateway();
			eventsubprocess1bghhj.FlowElements.Add(exclusivegateway3wwwcc);
			ProcessSchemaScriptTask notifyctipanelcallmessage_scripttask = CreateNotifyCtiPanelCallMessage_ScriptTaskScriptTask();
			eventsubprocess1bghhj.FlowElements.Add(notifyctipanelcallmessage_scripttask);
			ProcessSchemaUserTask shownophonenumbersusertask = CreateShowNoPhoneNumbersUserTaskUserTask();
			eventsubprocess1bghhj.FlowElements.Add(shownophonenumbersusertask);
			ProcessSchemaScriptTask processcallcontextmenuitemclick_scripttask3 = CreateProcessCallContextMenuItemClick_ScriptTask3ScriptTask();
			eventsubprocess1bghhj.FlowElements.Add(processcallcontextmenuitemclick_scripttask3);
			ProcessSchemaUserTask openselectnumberusertask = CreateOpenSelectNumberUserTaskUserTask();
			eventsubprocess1bghhj.FlowElements.Add(openselectnumberusertask);
			ProcessSchemaStartMessageEvent sendtemplateemailmenuitempreparemenustartmessage = CreateSendTemplateEmailMenuItemPrepareMenuStartMessageStartMessageEvent();
			sendtemplateemailmenuitempreparemenustartmessageeventsubprocess.FlowElements.Add(sendtemplateemailmenuitempreparemenustartmessage);
			ProcessSchemaScriptTask createtemplateemailcustomcontextmenu_scripttask = CreateCreateTemplateEmailCustomContextMenu_ScriptTaskScriptTask();
			sendtemplateemailmenuitempreparemenustartmessageeventsubprocess.FlowElements.Add(createtemplateemailcustomcontextmenu_scripttask);
			ProcessSchemaStartMessageEvent processemailtemplatecontextitemclickstartmessage = CreateProcessEmailTemplateContextItemClickStartMessageStartMessageEvent();
			processemailtemplatecontextitemclickeventsubprocess.FlowElements.Add(processemailtemplatecontextitemclickstartmessage);
			ProcessSchemaScriptTask processemailtemplatecontextitemclickscripttask = CreateProcessEmailTemplateContextItemClickScriptTaskScriptTask();
			processemailtemplatecontextitemclickeventsubprocess.FlowElements.Add(processemailtemplatecontextitemclickscripttask);
			ProcessSchemaStartMessageEvent basegridpageinitstartmessage = CreateBaseGridPageInitStartMessageStartMessageEvent();
			basegridpageinit.FlowElements.Add(basegridpageinitstartmessage);
			ProcessSchemaScriptTask scripttaskbasegridpageinit = CreateScriptTaskBaseGridPageInitScriptTask();
			basegridpageinit.FlowElements.Add(scripttaskbasegridpageinit);
			ProcessSchemaIntermediateThrowMessageEvent initializefilteredit_basegridpage_intermediatethrowinitializefilteredit = CreateInitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEditIntermediateThrowMessageEvent();
			basegridpageinit.FlowElements.Add(initializefilteredit_basegridpage_intermediatethrowinitializefilteredit);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask scriptpageloadcomplete = CreateScriptPageLoadCompleteScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(scriptpageloadcomplete);
			ProcessSchemaScriptTask scripttaskcheckmenuitem = CreateScriptTaskCheckMenuItemScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(scripttaskcheckmenuitem);
			ProcessSchemaScriptTask scriptregisterclientscript = CreateScriptRegisterClientScriptScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(scriptregisterclientscript);
			ProcessSchemaStartMessageEvent addbuttonclick = CreateAddButtonClickStartMessageEvent();
			eventsubprocess4.FlowElements.Add(addbuttonclick);
			ProcessSchemaScriptTask scriptaddbuttonclick = CreateScriptAddButtonClickScriptTask();
			eventsubprocess4.FlowElements.Add(scriptaddbuttonclick);
			ProcessSchemaScriptTask scriptsetdefvalues = CreateScriptSetDefValuesScriptTask();
			eventsubprocess4.FlowElements.Add(scriptsetdefvalues);
			ProcessSchemaScriptTask scripttasksendallowrequest = CreateScriptTaskSendAllowRequestScriptTask();
			eventsubprocess4.FlowElements.Add(scripttasksendallowrequest);
			ProcessSchemaStartMessageEvent startmessageallowadddetailmessage = CreateStartMessageAllowAddDetailMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessageallowadddetailmessage);
			ProcessSchemaExclusiveGateway gatewaycheckalloadddetail = CreateGatewayCheckAlloAddDetailExclusiveGateway();
			eventsubprocess4.FlowElements.Add(gatewaycheckalloadddetail);
			ProcessSchemaUserTask usertaskaddopenwindow = CreateUserTaskAddOpenWindowUserTask();
			eventsubprocess4.FlowElements.Add(usertaskaddopenwindow);
			ProcessSchemaStartMessageEvent editbuttonclick = CreateEditButtonClickStartMessageEvent();
			eventsubprocess6.FlowElements.Add(editbuttonclick);
			ProcessSchemaScriptTask scripteditbuttonclick = CreateScriptEditButtonClickScriptTask();
			eventsubprocess6.FlowElements.Add(scripteditbuttonclick);
			ProcessSchemaUserTask usertaskeditopenwindow = CreateUserTaskEditOpenWindowUserTask();
			eventsubprocess6.FlowElements.Add(usertaskeditopenwindow);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess6.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask scriptdefeditscript = CreateScriptDefEditScriptScriptTask();
			eventsubprocess6.FlowElements.Add(scriptdefeditscript);
			ProcessSchemaScriptTask scriptdeletebuttonclick = CreateScriptDeleteButtonClickScriptTask();
			eventsubprocess7.FlowElements.Add(scriptdeletebuttonclick);
			ProcessSchemaUserTask usermessage = CreateUserMessageUserTask();
			eventsubprocess7.FlowElements.Add(usermessage);
			ProcessSchemaStartMessageEvent deletebuttonclick = CreateDeleteButtonClickStartMessageEvent();
			eventsubprocess7.FlowElements.Add(deletebuttonclick);
			ProcessSchemaStartMessageEvent startmessagecustomdeletemessage = CreateStartMessageCustomDeleteMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(startmessagecustomdeletemessage);
			ProcessSchemaScriptTask scripttaskcustomdeletemessage = CreateScriptTaskCustomDeleteMessageScriptTask();
			eventsubprocess7.FlowElements.Add(scripttaskcustomdeletemessage);
			ProcessSchemaStartMessageEvent copybuttonclick = CreateCopyButtonClickStartMessageEvent();
			eventsubprocess5.FlowElements.Add(copybuttonclick);
			ProcessSchemaScriptTask scriptcopybuttonclick = CreateScriptCopyButtonClickScriptTask();
			eventsubprocess5.FlowElements.Add(scriptcopybuttonclick);
			ProcessSchemaUserTask usertaskopencopyeditpage = CreateUserTaskOpenCopyEditPageUserTask();
			eventsubprocess5.FlowElements.Add(usertaskopencopyeditpage);
			ProcessSchemaScriptTask scriptdefcopybutton = CreateScriptDefCopyButtonScriptTask();
			eventsubprocess5.FlowElements.Add(scriptdefcopybutton);
			ProcessSchemaExclusiveGateway exclusivegatewaycopyopenwindow = CreateExclusiveGatewayCopyOpenWindowExclusiveGateway();
			eventsubprocess5.FlowElements.Add(exclusivegatewaycopyopenwindow);
			ProcessSchemaStartMessageEvent deletenomessage = CreateDeleteNoMessageStartMessageEvent();
			subprocess5.FlowElements.Add(deletenomessage);
			ProcessSchemaScriptTask scriptdeletenomessage = CreateScriptDeleteNoMessageScriptTask();
			subprocess5.FlowElements.Add(scriptdeletenomessage);
			ProcessSchemaStartMessageEvent startmessageopenprintreportmessage = CreateStartMessageOpenPrintReportMessageStartMessageEvent();
			subprocessopenprintreport.FlowElements.Add(startmessageopenprintreportmessage);
			ProcessSchemaScriptTask scripttaskprepareparametersopenprintreport = CreateScriptTaskPrepareParametersOpenPrintReportScriptTask();
			subprocessopenprintreport.FlowElements.Add(scripttaskprepareparametersopenprintreport);
			ProcessSchemaScriptTask scripttaskclearprintusercontext = CreateScriptTaskClearPrintUserContextScriptTask();
			subprocessopenprintreport.FlowElements.Add(scripttaskclearprintusercontext);
			ProcessSchemaStartMessageEvent startmessageopenprintreportbuttonclick = CreateStartMessageOpenPrintReportButtonClickStartMessageEvent();
			subprocessopenprintreport.FlowElements.Add(startmessageopenprintreportbuttonclick);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			subprocessopenprintreport.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask scripttasksetreportoptions = CreateScriptTaskSetReportOptionsScriptTask();
			subprocessopenprintreport.FlowElements.Add(scripttasksetreportoptions);
			ProcessSchemaUserTask usertaskprintopenwindow = CreateUserTaskPrintOpenWindowUserTask();
			subprocessopenprintreport.FlowElements.Add(usertaskprintopenwindow);
			ProcessSchemaExclusiveGateway exclusivegatewayopenprint = CreateExclusiveGatewayOpenPrintExclusiveGateway();
			subprocessopenprintreport.FlowElements.Add(exclusivegatewayopenprint);
			ProcessSchemaScriptTask scriptdefoperprintwindow = CreateScriptDefOperPrintWindowScriptTask();
			subprocessopenprintreport.FlowElements.Add(scriptdefoperprintwindow);
			ProcessSchemaStartMessageEvent deleteyesmessage = CreateDeleteYesMessageStartMessageEvent();
			subprocess4.FlowElements.Add(deleteyesmessage);
			ProcessSchemaScriptTask scriptdeleteyesmessage = CreateScriptDeleteYesMessageScriptTask();
			subprocess4.FlowElements.Add(scriptdeleteyesmessage);
			ProcessSchemaStartMessageEvent createmswordreportmessagestartmessage = CreateCreateMSWordReportMessageStartMessageStartMessageEvent();
			createmswordreportmessageeventsubprocess.FlowElements.Add(createmswordreportmessagestartmessage);
			ProcessSchemaScriptTask createmswordreportmessagescripttask = CreateCreateMSWordReportMessageScriptTaskScriptTask();
			createmswordreportmessageeventsubprocess.FlowElements.Add(createmswordreportmessagescripttask);
			ProcessSchemaScriptTask showmswordreportcreatedscripttask = CreateShowMSWordReportCreatedScriptTaskScriptTask();
			createmswordreportmessageeventsubprocess.FlowElements.Add(showmswordreportcreatedscripttask);
			ProcessSchemaUserTask showmswordreportcreatedusertask = CreateShowMSWordReportCreatedUserTaskUserTask();
			createmswordreportmessageeventsubprocess.FlowElements.Add(showmswordreportcreatedusertask);
			ProcessSchemaExclusiveGateway exclusivegateway33453453456789789783434535 = CreateExclusiveGateway33453453456789789783434535ExclusiveGateway();
			createmswordreportmessageeventsubprocess.FlowElements.Add(exclusivegateway33453453456789789783434535);
			ProcessSchemaEndEvent end1345345897809780343535 = CreateEnd1345345897809780343535EndEvent();
			createmswordreportmessageeventsubprocess.FlowElements.Add(end1345345897809780343535);
			ProcessSchemaStartMessageEvent savereporttolocaldiskstartmessage = CreateSaveReportToLocalDiskStartMessageStartMessageEvent();
			savereporttolocaldiskeventsubprocess.FlowElements.Add(savereporttolocaldiskstartmessage);
			ProcessSchemaScriptTask savereporttolocaldiskscripttask = CreateSaveReportToLocalDiskScriptTaskScriptTask();
			savereporttolocaldiskeventsubprocess.FlowElements.Add(savereporttolocaldiskscripttask);
			ProcessSchemaIntermediateThrowMessageEvent throweditbuttonclick = CreateThrowEditButtonClickIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(throweditbuttonclick);
			ProcessSchemaStartMessageEvent treegriddblclick = CreateTreeGridDblClickStartMessageEvent();
			eventsubprocess3.FlowElements.Add(treegriddblclick);
			ProcessSchemaStartMessageEvent startmessagenoninterruptingevent2 = CreateStartMessageNonInterruptingEvent2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessagenoninterruptingevent2);
			ProcessSchemaScriptTask scriptgridpagerefreshrow = CreateScriptGridPageRefreshRowScriptTask();
			eventsubprocess2.FlowElements.Add(scriptgridpagerefreshrow);
			ProcessSchemaStartMessageEvent datasourceactiverowchangedevent = CreateDataSourceActiveRowChangedEventStartMessageEvent();
			datasourceactiverowchangedeventsubprocess.FlowElements.Add(datasourceactiverowchangedevent);
			ProcessSchemaScriptTask datasourceactiverowchangedscripttask = CreateDataSourceActiveRowChangedScriptTaskScriptTask();
			datasourceactiverowchangedeventsubprocess.FlowElements.Add(datasourceactiverowchangedscripttask);
			ProcessSchemaStartMessageEvent datasourceloadrowsresponseregisteredstartmessage = CreateDataSourceLoadRowsResponseRegisteredStartMessageStartMessageEvent();
			datasourceloadrowsresponseregisteredeventsubprocess.FlowElements.Add(datasourceloadrowsresponseregisteredstartmessage);
			ProcessSchemaScriptTask datasourceloadrowsresponseregisteredscripttask = CreateDataSourceLoadRowsResponseRegisteredScriptTaskScriptTask();
			datasourceloadrowsresponseregisteredeventsubprocess.FlowElements.Add(datasourceloadrowsresponseregisteredscripttask);
			ProcessSchemaStartMessageEvent datasourceloading = CreateDataSourceLoadingStartMessageEvent();
			datasourceloadingsubprocess.FlowElements.Add(datasourceloading);
			ProcessSchemaScriptTask datasourceloadingscripttask = CreateDataSourceLoadingScriptTaskScriptTask();
			datasourceloadingsubprocess.FlowElements.Add(datasourceloadingscripttask);
			ProcessSchemaStartMessageEvent startmessagebasepreparefilters = CreateStartMessageBasePrepareFiltersStartMessageEvent();
			basepreparefiltersdatasourcesubprocess.FlowElements.Add(startmessagebasepreparefilters);
			ProcessSchemaScriptTask scripttasksendmessagebasepreparefilter = CreateScriptTaskSendMessageBasePrepareFilterScriptTask();
			basepreparefiltersdatasourcesubprocess.FlowElements.Add(scripttasksendmessagebasepreparefilter);
			ProcessSchemaScriptTask scriptcreatedemofilters = CreateScriptCreateDemoFiltersScriptTask();
			basepreparefiltersdatasourcesubprocess.FlowElements.Add(scriptcreatedemofilters);
			ProcessSchemaStartMessageEvent startmessageinitializefilteredit = CreateStartMessageInitializeFilterEditStartMessageEvent();
			eventsubprocessinitializefilteredit.FlowElements.Add(startmessageinitializefilteredit);
			ProcessSchemaScriptTask scriptinitializefilteredit = CreateScriptInitializeFilterEditScriptTask();
			eventsubprocessinitializefilteredit.FlowElements.Add(scriptinitializefilteredit);
			ProcessSchemaStartMessageEvent startcleardata = CreateStartClearDataStartMessageEvent();
			eventsubprocesscleardata.FlowElements.Add(startcleardata);
			ProcessSchemaScriptTask scriptcleardata = CreateScriptClearDataScriptTask();
			eventsubprocesscleardata.FlowElements.Add(scriptcleardata);
			ProcessSchemaStartMessageEvent selectfolder = CreateSelectFolderStartMessageEvent();
			subprocessselectfolder.FlowElements.Add(selectfolder);
			ProcessSchemaScriptTask scriptselectfolder = CreateScriptSelectFolderScriptTask();
			subprocessselectfolder.FlowElements.Add(scriptselectfolder);
			ProcessSchemaStartMessageEvent applysearchfilter = CreateApplySearchFilterStartMessageEvent();
			subprocess1.FlowElements.Add(applysearchfilter);
			ProcessSchemaScriptTask scriptapplysearchfilter = CreateScriptApplySearchFilterScriptTask();
			subprocess1.FlowElements.Add(scriptapplysearchfilter);
			ProcessSchemaStartMessageEvent startrunmoduleprocess = CreateStartRunModuleProcessStartMessageEvent();
			eventsubprocessrunmoduleprocess.FlowElements.Add(startrunmoduleprocess);
			ProcessSchemaScriptTask scriptrunmoduleprocess = CreateScriptRunModuleProcessScriptTask();
			eventsubprocessrunmoduleprocess.FlowElements.Add(scriptrunmoduleprocess);
			ProcessSchemaStartMessageEvent startprocesspropswindowclosed = CreateStartProcessPropsWindowClosedStartMessageEvent();
			eventsubprocessprocesspropswindowclosed.FlowElements.Add(startprocesspropswindowclosed);
			ProcessSchemaScriptTask scriptprocesspropswindowclosed = CreateScriptProcessPropsWindowClosedScriptTask();
			eventsubprocessprocesspropswindowclosed.FlowElements.Add(scriptprocesspropswindowclosed);
			ProcessSchemaStartMessageEvent startcreatenewprocessmenuitemclick = CreateStartCreateNewProcessMenuItemClickStartMessageEvent();
			eventsubprocess1openprocessedit.FlowElements.Add(startcreatenewprocessmenuitemclick);
			ProcessSchemaScriptTask scriptcreatenewprocessmenuitemclick = CreateScriptCreateNewProcessMenuItemClickScriptTask();
			eventsubprocess1openprocessedit.FlowElements.Add(scriptcreatenewprocessmenuitemclick);
			ProcessSchemaUserTask openprocesseditusertask = CreateOpenProcessEditUserTaskUserTask();
			eventsubprocess1openprocessedit.FlowElements.Add(openprocesseditusertask);
			ProcessSchemaStartMessageEvent startshowmessage = CreateStartShowMessageStartMessageEvent();
			eventsubprocessshowmessage.FlowElements.Add(startshowmessage);
			ProcessSchemaUserTask messagewindowusertask = CreateMessageWindowUserTaskUserTask();
			eventsubprocessshowmessage.FlowElements.Add(messagewindowusertask);
			ProcessSchemaStartMessageEvent starttuningmodechanged = CreateStartTuningModeChangedStartMessageEvent();
			eventsubprocess1tuningmodechanged.FlowElements.Add(starttuningmodechanged);
			ProcessSchemaScriptTask scripttuningmodechanged = CreateScriptTuningModeChangedScriptTask();
			eventsubprocess1tuningmodechanged.FlowElements.Add(scripttuningmodechanged);
			ProcessSchemaStartMessageEvent startmessagecreatenewsysmodulereportmenuitemclick = CreateStartMessageCreateNewSysModuleReportMenuItemClickStartMessageEvent();
			createnewsysmodulereportmenuitemclickeventsubprocess.FlowElements.Add(startmessagecreatenewsysmodulereportmenuitemclick);
			ProcessSchemaScriptTask scripttaskcreatenewsysmodulereportmenuitemclick = CreateScriptTaskCreateNewSysModuleReportMenuItemClickScriptTask();
			createnewsysmodulereportmenuitemclickeventsubprocess.FlowElements.Add(scripttaskcreatenewsysmodulereportmenuitemclick);
			ProcessSchemaUserTask createnewsysmodulereportmenuitemclickusertask = CreateCreateNewSysModuleReportMenuItemClickUserTaskUserTask();
			createnewsysmodulereportmenuitemclickeventsubprocess.FlowElements.Add(createnewsysmodulereportmenuitemclickusertask);
			ProcessSchemaStartMessageEvent sysmodulereportpropswindowclosedstartmessage = CreateSysModuleReportPropsWindowClosedStartMessageStartMessageEvent();
			sysmodulereportpropswindowclosedeventsubprocess.FlowElements.Add(sysmodulereportpropswindowclosedstartmessage);
			ProcessSchemaScriptTask sysmodulereportpropswindowclosedscripttask = CreateSysModuleReportPropsWindowClosedScriptTaskScriptTask();
			sysmodulereportpropswindowclosedeventsubprocess.FlowElements.Add(sysmodulereportpropswindowclosedscripttask);
			ProcessSchemaStartMessageEvent setdetailprintbuttonmenustartmessage1 = CreateSetDetailPrintButtonMenuStartMessage1StartMessageEvent();
			setdetailprintbuttonmenueventsubprocess1.FlowElements.Add(setdetailprintbuttonmenustartmessage1);
			ProcessSchemaScriptTask setdetailprintbuttonmenuscripttask1 = CreateSetDetailPrintButtonMenuScriptTask1ScriptTask();
			setdetailprintbuttonmenueventsubprocess1.FlowElements.Add(setdetailprintbuttonmenuscripttask1);
			FlowElements.Add(CreateSequenceFlow262_BaseGridPageSequenceFlow());
			FlowElements.Add(CreateSequenceFlow263SequenceFlow());
			FlowElements.Add(CreateSequenceFlow264SequenceFlow());
			FlowElements.Add(CreateSequenceFlow265SequenceFlow());
			FlowElements.Add(CreateSequenceFlow266SequenceFlow());
			FlowElements.Add(CreateSequenceFlow267SequenceFlow());
			FlowElements.Add(CreateSequenceFlow268SequenceFlow());
			FlowElements.Add(CreateSequenceFlow269SequenceFlow());
			FlowElements.Add(CreateSequenceFlow272SequenceFlow());
			FlowElements.Add(CreateSequenceFlow273SequenceFlow());
			FlowElements.Add(CreateSequenceFlow274SequenceFlow());
			FlowElements.Add(CreateSequenceFlow275SequenceFlow());
			FlowElements.Add(CreateSequenceFlow276SequenceFlow());
			FlowElements.Add(CreateSequenceFlow277SequenceFlow());
			FlowElements.Add(CreateSequenceFlow278SequenceFlow());
			FlowElements.Add(CreateSequenceFlow279_BaseGridPageSequenceFlow());
			FlowElements.Add(CreateSequenceFlow280SequenceFlow());
			FlowElements.Add(CreateSequenceFlow282_BaseGridPageSequenceFlow());
			FlowElements.Add(CreateSequenceFlow283SequenceFlow());
			FlowElements.Add(CreateSequenceFlow284ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow285SequenceFlow());
			FlowElements.Add(CreateSequenceFlow286SequenceFlow());
			FlowElements.Add(CreateSequenceFlow287SequenceFlow());
			FlowElements.Add(CreateSequenceFlow288SequenceFlow());
			FlowElements.Add(CreateSequenceFlow289SequenceFlow());
			FlowElements.Add(CreateSequenceFlow290SequenceFlow());
			FlowElements.Add(CreateSequenceFlow291SequenceFlow());
			FlowElements.Add(CreateSequenceFlow293SequenceFlow());
			FlowElements.Add(CreateSequenceFlow294SequenceFlow());
			FlowElements.Add(CreateSequenceFlow295ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow296SequenceFlow());
			FlowElements.Add(CreateSequenceFlow297ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow298SequenceFlow());
			FlowElements.Add(CreateSequenceFlow299SequenceFlow());
			FlowElements.Add(CreateSequenceFlow300SequenceFlow());
			FlowElements.Add(CreateSequenceFlow301SequenceFlow());
			FlowElements.Add(CreateSequenceFlow303SequenceFlow());
			FlowElements.Add(CreateSequenceFlow304SequenceFlow());
			FlowElements.Add(CreateSequenceFlow305SequenceFlow());
			FlowElements.Add(CreateSequenceFlow306SequenceFlow());
			FlowElements.Add(CreateConditionalFlow28ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow308_BaseGridPageSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1_yyySequenceFlow());
			FlowElements.Add(CreateSequenceFlow5_BaseGridPageSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1_BaseGridPageSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1321_BaseGridPageSequenceFlow());
			FlowElements.Add(CreateSequenceFlowCreateDemoFiltersSequenceFlow());
			FlowElements.Add(CreateSequenceFlowRunModuleProcessSequenceFlow());
			FlowElements.Add(CreateSequenceFlowProcessPropsWindowClosedSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3CreateNewProcessMenuItemClickSequenceFlow());
			FlowElements.Add(CreateSequenceFlow5CreateNewProcessMenuItemClickSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3ShowMessageSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3TuningModeChangedSequenceFlow());
			FlowElements.Add(CreateSequenceFlow13123SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1qwedbSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1opisdSequenceFlow());
			FlowElements.Add(CreateSequenceFlow2jhghjSequenceFlow());
			FlowElements.Add(CreateSequenceFlow2vvvfgnrSequenceFlow());
			FlowElements.Add(CreateConditionalFlow1retbbConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2uuiooSequenceFlow());
			FlowElements.Add(CreateConditionalFlow1wwersConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3qwedxwqSequenceFlow());
			FlowElements.Add(CreateCreateMSWordReportMessageSequenceFlow16786785474534SequenceFlow());
			FlowElements.Add(CreateSequenceFlow223543576586834534347SequenceFlow());
			FlowElements.Add(CreateConditionalFlow156757575757234242424ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow134535354123123768678678SequenceFlow());
			FlowElements.Add(CreateSequenceFlow235t345346967963453535SequenceFlow());
			FlowElements.Add(CreateSequenceFlow145785686797335780780SequenceFlow());
			FlowElements.Add(CreateSequenceFlow145654676797807890345345345SequenceFlow());
			FlowElements.Add(CreateSequenceFlow289089534343656868678678SequenceFlow());
			FlowElements.Add(CreateSequenceFlow378978978234534534679789789789SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1345374563456475685675456456SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1345353535533654646789973435SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2346546235423547684564756858SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDeleteRecordMessageLocalizableString());
			LocalizableStrings.Add(CreateWarningLocalizableString());
			LocalizableStrings.Add(CreateDependencyWarningMessageLocalizableString());
			LocalizableStrings.Add(CreateRightLevelWarningMessageLocalizableString());
			LocalizableStrings.Add(CreateRightLevelDependencyWarningMessageLocalizableString());
			LocalizableStrings.Add(CreateQuestionCaptionLocalizableString());
			LocalizableStrings.Add(CreateNewRecordNotSavedMessageLocalizableString());
			LocalizableStrings.Add(CreateContextMenuSeparatorTemplatePatternLocalizableString());
			LocalizableStrings.Add(CreateContextMenuSeparatorContactPatternLocalizableString());
			LocalizableStrings.Add(CreateCreateNewProcessMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateDeleteProcessMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateModuleProcessInstanceNotExistMessageLocalizableString());
			LocalizableStrings.Add(CreateNoPhoneNumberLocalizableString());
			LocalizableStrings.Add(CreateMSWordReportWasCreatedLocalizableString());
			LocalizableStrings.Add(CreateSetSettingsNowLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDeleteRecordMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2df74b94-0a0b-4b10-b317-d10269d22d55"),
				Name = "DeleteRecordMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d11666ef-43c6-4644-b278-d68f98a9f3f9"),
				Name = "Warning",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDependencyWarningMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("25aac33d-8ef3-4aea-96b9-b76c57c18efb"),
				Name = "DependencyWarningMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRightLevelWarningMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("beae3465-f790-4578-b9cc-04d2b54dd950"),
				Name = "RightLevelWarningMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRightLevelDependencyWarningMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3b869ec1-ca8c-427a-87f6-e12dd811cc02"),
				Name = "RightLevelDependencyWarningMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateQuestionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d6048f17-7e23-4fcc-85e2-ce6363b21732"),
				Name = "QuestionCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNewRecordNotSavedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("21965490-1e71-409a-b4c1-47948a433c96"),
				Name = "NewRecordNotSavedMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContextMenuSeparatorTemplatePatternLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a5816eac-e6b1-4ea4-a6d3-e390d6f612c1"),
				Name = "ContextMenuSeparatorTemplatePattern",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContextMenuSeparatorContactPatternLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1b3b6f2d-a9fc-4efc-a6f3-aba19042f64e"),
				Name = "ContextMenuSeparatorContactPattern",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCreateNewProcessMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3e57fb5f-7e55-46a8-bbc8-0cb0b94be4a2"),
				Name = "CreateNewProcessMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteProcessMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c5912bcb-f995-4b09-922c-e3f1fb59e61d"),
				Name = "DeleteProcessMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateModuleProcessInstanceNotExistMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2c09d435-2e2c-40b6-b466-9e0f42979f35"),
				Name = "ModuleProcessInstanceNotExistMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoPhoneNumberLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0aafda61-4179-49f1-9df4-a452af0a1424"),
				Name = "NoPhoneNumber",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMSWordReportWasCreatedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("69288403-dfa6-40d2-a535-6c7f4801ae49"),
				Name = "MSWordReportWasCreated",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSetSettingsNowLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("89e9b78d-ac7c-4cd6-9365-3364fb7fab43"),
				Name = "SetSettingsNow",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow262_BaseGridPageSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow262_BaseGridPage",
				UId = new Guid("02f1bb18-57a3-416b-b011-c96696748841"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(252, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a58fb0fd-2928-46a9-9ea9-03750afda36a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a3a49da-b2c0-4161-98b8-3c5077053502"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow263SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow263",
				UId = new Guid("8f2f9402-26fb-468c-979f-b296800d9b44"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(546, 120),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b1e311a3-3e9c-4b51-865a-fa7e6ede7d2a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ea8c0720-e286-4004-9364-7ed7bf2b763b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow264SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow264",
				UId = new Guid("93a56934-55a6-4368-9b35-18cd9d8f0801"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(156, 208),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("43a6b49d-0742-4f58-99e0-ef4e671d2311"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("98efad80-8442-4330-8c08-c4d14232c7c9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow265SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow265",
				UId = new Guid("0e4abe98-4bd7-431b-81f0-7b92f9c2a1b3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(410, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5fbf7352-f831-42ef-9724-84156114e6c4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("86cc8d24-167b-43a7-bf0b-256241d63a85"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow266SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow266",
				UId = new Guid("811f4eaa-1bf4-4596-be8a-7a540dd2811b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(664, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a1332396-f146-4aa4-950f-5244739f32e8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4f3938ec-fed9-4842-ba5d-02b2a4f006fe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow267SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow267",
				UId = new Guid("39c8099b-e497-4af9-8ca8-9b85907369c1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(908, 215),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f99e62f-c050-4b1e-87d2-39d5393c270a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("56e65ffb-cfe8-4f83-b2cc-377ab0ad0bb8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow268SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow268",
				UId = new Guid("5585b06d-d161-4fd9-b592-f38cecc31ef3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(559, 74),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0cfbb5c2-ff9c-44a8-b45b-4af693fce3d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("949b78e9-58a2-4555-bf53-4e390b056524"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow269SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow269",
				UId = new Guid("c5781b1b-a970-4b27-bde1-38f19997224d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("315a487f-aad5-4645-8648-0fe6ab36af7d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe08a71a-6dd8-4978-97aa-fd85e00a7e1b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow272SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow272",
				UId = new Guid("0ccbe7c7-45af-4c86-9984-bc10dcd25d1a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(752, 321),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("98efad80-8442-4330-8c08-c4d14232c7c9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow273SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow273",
				UId = new Guid("4f871e12-3be1-42b2-909a-6a49220db876"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(322, 61),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("20c865f7-a59c-494c-a008-20c5bb01dcbd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a52679bb-9d72-4ead-895d-4b5ea5729568"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow274SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow274",
				UId = new Guid("a25767bb-5b4d-49e2-8f93-73e7ea9faf5e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(715, 452),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("56e65ffb-cfe8-4f83-b2cc-377ab0ad0bb8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow275SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow275",
				UId = new Guid("cc52cb5c-55ee-426b-8aac-6996cc9c7232"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(526, 62),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8334edc8-790e-4017-9baa-84828238e595"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("852df471-5a6d-4017-8422-f4fb37356a7e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow276SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow276",
				UId = new Guid("d214cda5-a02f-4bc3-952c-5f97e9a3e6e5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(158, 724),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a5f48926-d190-43ec-99de-2bd2b535244c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ec055e27-e9ca-4a7c-8c26-40a333efd389"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow277SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow277",
				UId = new Guid("d429c205-f775-4405-8fb2-6d20a966eba4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(452, 331),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f3938ec-fed9-4842-ba5d-02b2a4f006fe"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1187aaba-0ef2-45e5-a4bf-f47de9d17d0c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow278SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow278",
				UId = new Guid("da085a14-ecfc-4221-9ff6-e42c30add90b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(390, 736),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("23df5659-911c-46f6-95a6-bfa49c63b31f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a1ffa055-37e7-4112-bda5-d5ef3b5b6483"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow279_BaseGridPageSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow279_BaseGridPage",
				UId = new Guid("8c0ca166-22c3-4f15-a7bb-d10c6600e027"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(631, 736),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("90e1d275-94eb-47ba-bb6a-d33039a29424"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8f50880b-1417-42aa-9101-5a5d0fd77239"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow280SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow280",
				UId = new Guid("32fbcf91-8b1c-4a63-8cee-4f237d1d8550"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(149, 898),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7b4693af-a1c6-4ed0-9d9d-82808be59f78"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ccab20f-51ac-4182-b720-273dabfdf3a2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow282_BaseGridPageSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow282_BaseGridPage",
				UId = new Guid("b17d6995-beef-4cfe-858b-16ba6165b9b3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(647, 886),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a3a49da-b2c0-4161-98b8-3c5077053502"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b40bc5dd-63f4-4576-8a30-5dafb14b6446"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow283SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow283",
				UId = new Guid("e65157f7-0c1b-42d6-9650-21a26ef59d76"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(156, 208),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ae0d6ca0-9d7b-4fc1-a214-bfc25300d799"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("48b36f4c-a0b0-4aae-9885-e54b830f70eb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow284ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow284",
				UId = new Guid("9fefce9b-fc4e-4ab8-a86c-d76cd20e0d00"),
				ConditionExpression = @"NeedAddDetailRequest",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(574, 322),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48b36f4c-a0b0-4aae-9885-e54b830f70eb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e469f4f1-cfa0-42db-9295-ea2f96e88b4b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow285SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow285",
				UId = new Guid("679275b7-cd89-44c0-8e9b-76e6feb432dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(625, 396),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("32e28819-8c26-431d-83b7-195db3b3b8a7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("43a6b49d-0742-4f58-99e0-ef4e671d2311"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow286SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow286",
				UId = new Guid("302ffba2-008b-44e9-a713-8ee9af470d7f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(515, 378),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48b36f4c-a0b0-4aae-9885-e54b830f70eb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("43a6b49d-0742-4f58-99e0-ef4e671d2311"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow287SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow287",
				UId = new Guid("adb76f25-52d0-4829-bcfa-984a93388ee0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(136, 1028),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f60b76a8-9f7a-4220-aeac-0896f32dad4c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d371b146-df23-43c5-907e-19ab135966ed"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow288SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow288",
				UId = new Guid("aecfbbf1-0558-4461-87ee-8b5158286a94"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(256, 1032),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d371b146-df23-43c5-907e-19ab135966ed"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b56e7de1-87ca-4be3-9697-01291dc4ffdf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow289SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow289",
				UId = new Guid("fc7a5426-52c1-4baf-9dfd-bf80b29ddad3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(374, 1030),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d125104f-5de5-4320-a89b-958edaaef717"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow290SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow290",
				UId = new Guid("c2de5bbc-3037-483a-ab4c-3514e0ab5ffd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(212, 1284),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("35d95d40-2e4f-442a-bf66-2ea1be25c1d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b56e7de1-87ca-4be3-9697-01291dc4ffdf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow291SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow291",
				UId = new Guid("9e1396ab-fee0-4243-9969-f44e78b92dc3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(356, 1288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b56e7de1-87ca-4be3-9697-01291dc4ffdf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("140ca1ac-5412-42a4-8521-6f911e66aa07"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow293SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow293",
				UId = new Guid("59e09336-4cf7-45ce-80e7-8186915f8fa7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(907, 993),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b8b652c-170d-4398-85fe-53da3e3ead24"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b949a31-54f6-4b1c-84bc-f6a9a8903fee"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow294SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow294",
				UId = new Guid("d96dc89c-c1c6-41e6-9b87-6a5d6a64c270"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(920, 906),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("86cc8d24-167b-43a7-bf0b-256241d63a85"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6b8b652c-170d-4398-85fe-53da3e3ead24"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow295ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow295",
				UId = new Guid("7cf06fc1-597a-420d-a065-bd35f98fb2f7"),
				ConditionExpression = @"!DefaultWay",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(1028, 903),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b8b652c-170d-4398-85fe-53da3e3ead24"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow296SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow296",
				UId = new Guid("db7f24d0-197d-4899-9cb6-3e526d20ff0f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(470, 1396),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("140ca1ac-5412-42a4-8521-6f911e66aa07"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d4d93ae6-c806-42c8-b93b-c173941216dc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow297ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow297",
				UId = new Guid("bf384f74-8b24-4b7b-b72d-b34bf7d95c06"),
				ConditionExpression = @"PrintReportSchemaUId != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(564, 1380),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4d93ae6-c806-42c8-b93b-c173941216dc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow298SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow298",
				UId = new Guid("44f4e0ee-de8d-41ea-a8a3-756eee0004c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(505, 1436),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4d93ae6-c806-42c8-b93b-c173941216dc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5204dbbf-5b6f-4fd6-abca-18b5112fa1f1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow299SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow299",
				UId = new Guid("11fd33e8-2a58-4cf1-8ca7-d7a41f48bb9e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(894, 876),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a03fd159-e954-43ba-a2bd-6db776117fe2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2dd25769-6b44-4e0d-8959-3448584ee10c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow300SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow300",
				UId = new Guid("9397ab22-3ac3-459a-8bea-d7b6176b7925"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(1019, 831),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2dd25769-6b44-4e0d-8959-3448584ee10c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow301SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow301",
				UId = new Guid("c80c9e3b-d3f3-45ca-848d-e1097669d912"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(188, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("33586ad9-acff-4f9a-bf93-9fc1badc7f51"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f424ffe2-d9bc-4616-aeec-0f95f43697a1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow303SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow303",
				UId = new Guid("5a82b713-543e-4b4f-96f4-fa0e77674ab4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(458, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3e0f58db-73af-4caa-be84-33461262856e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("004a8d7f-690c-41c8-a865-b93a5b9f079b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow304SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow304",
				UId = new Guid("413e9ef6-6ac0-4ac7-a96d-dd774d034a05"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("476873f8-10a4-41fd-97e5-17e664da6b66"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4d8b9f3e-6330-436f-9462-b038b1216c75"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow305SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow305",
				UId = new Guid("f2131eec-3d2b-4788-8105-b3b235fa0d1e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(1255, 785),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ad28e1a-9277-4eac-92a7-931ca8f0bd62"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1b81ff46-e66c-4c7d-9b3d-f1a346bfcaaa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow306SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow306",
				UId = new Guid("54afc6ef-bdb8-4c7c-8c8c-3ef2ed1f19e1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(310, 409),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1187aaba-0ef2-45e5-a4bf-f47de9d17d0c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("733ee819-36c5-427b-87fc-0be76a8e013c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow28ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow28",
				UId = new Guid("57de51fd-a22c-46f6-af6d-0fe53a83e13c"),
				ConditionExpression = @"!DefaultWay",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(366, 358),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1187aaba-0ef2-45e5-a4bf-f47de9d17d0c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow308_BaseGridPageSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow308_BaseGridPage",
				UId = new Guid("85eb36d9-3c22-4453-b6ba-25956def8472"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(435, 298),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b40bc5dd-63f4-4576-8a30-5dafb14b6446"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("64bc4d5a-1c95-41fd-9e9d-f0841451db04"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1_yyySequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1_yyy",
				UId = new Guid("f4112e71-0489-41c7-9ea1-a3e74526a0a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e1b1a918-e77e-4f37-aea7-5311fb514f72"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd1b6897-ae10-4a41-87b4-dbc850e72dba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5_BaseGridPageSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5_BaseGridPage",
				UId = new Guid("b3eadec4-488b-41cd-ae20-8b46fdd2f2cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(170, 230),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8650c458-0155-4930-ba08-4d0915d902a7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("241dee9f-8625-4938-9c5f-b27f7a5d0e15"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1_BaseGridPageSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1_BaseGridPage",
				UId = new Guid("e5f5a638-c280-4271-946a-24d764b53304"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(317, 231),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("241dee9f-8625-4938-9c5f-b27f7a5d0e15"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1321_BaseGridPageSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1321_BaseGridPage",
				UId = new Guid("b05226d2-208d-4195-a1de-0798a518ac9f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(612, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ce64ed8c-06e3-4051-ae5e-a5e3bc8ef080"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowCreateDemoFiltersSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowCreateDemoFilters",
				UId = new Guid("1c124f49-7d89-4bf5-9c6e-6e4c6c13ea5d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(802, 2374),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ccab20f-51ac-4182-b720-273dabfdf3a2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2aa1b071-fb4e-41cb-94be-e1219c3661bd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowRunModuleProcessSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowRunModuleProcess",
				UId = new Guid("991cf359-3fff-437d-9e24-3d8e1846c407"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(201, 306),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d312a685-3ec7-4c42-8325-bd38aef1e095"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f3c4b42c-8043-4eff-a84f-9531dbfcf50d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowProcessPropsWindowClosedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowProcessPropsWindowClosed",
				UId = new Guid("b1664cca-82e1-4570-9e17-49f433fffe0e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(320, 300),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef2e34f4-06ea-4a5a-b8a1-d3e1adaac355"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6fbfe17e-cb63-40c2-b7fb-5306622417ea"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3CreateNewProcessMenuItemClickSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3CreateNewProcessMenuItemClick",
				UId = new Guid("5e7d287a-d363-43d7-a13d-abbbcd400ac3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(266, 500),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c0af7230-5cf6-4022-baa8-712bb01b3a3d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0e4bbcee-b4be-46e7-a5d6-69a21046ab45"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5CreateNewProcessMenuItemClickSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5CreateNewProcessMenuItemClick",
				UId = new Guid("f2a206f3-9ce4-4c6c-b593-7907f33ab7ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(402, 480),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0e4bbcee-b4be-46e7-a5d6-69a21046ab45"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3ShowMessageSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3ShowMessage",
				UId = new Guid("71dc27cc-1d64-43a1-80d0-776690c1e69d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(210, 756),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ae77a58-9bb7-4057-8353-9a5b97a9f458"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3TuningModeChangedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3TuningModeChanged",
				UId = new Guid("cc83b300-1539-4801-946b-92a6f0d7534b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(194, 1002),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("51300206-0e8d-4bad-a8a6-0add8f578efa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b24742a5-228b-4d91-9b22-3032bae867bd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13123SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13123",
				UId = new Guid("6cc2923d-cb96-4e4f-a909-a7e6d864a4b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(458, 124),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1f519f5d-9c9a-49bb-9dd8-6d8d1af57530"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ce64ed8c-06e3-4051-ae5e-a5e3bc8ef080"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1qwedbSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1qwedb",
				UId = new Guid("921256f4-c6d0-40aa-9a72-ef8d3c5caca9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c2569eb7-8256-4ff4-b311-8ce2d448f136"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("98c735b7-c031-48a4-bb95-93271c373b7d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1opisdSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1opisd",
				UId = new Guid("ddbb1492-2654-4a13-91f9-e0be5dc62e2a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(438, 244),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a0912c0b-46d8-4b3a-940b-1d4fac5e80e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e8a5615a-b40a-44c0-b275-c8a9a57f7992"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2jhghjSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2jhghj",
				UId = new Guid("a83ec03f-b617-4945-bdb4-c26bdda2f679"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(565, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e8a5615a-b40a-44c0-b275-c8a9a57f7992"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9f6e9db4-a8d4-47de-97be-e9d0e8074803"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2vvvfgnrSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2vvvfgnr",
				UId = new Guid("e316665b-f8bb-4e11-a074-30585bb2b309"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(527, 409),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da949a79-83d6-450c-b6e7-d738b148df2e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ce372dfc-2331-4855-9ed8-72941ae1d9d5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1retbbConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1retbb",
				UId = new Guid("d8206b9c-a294-45e4-9407-5a9ea035558d"),
				ConditionExpression = @"Terrasoft.Configuration.CommunicationUtilities.GetSelectedCommunicationNumbers(UserConnection).Length == 1",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(600, 345),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9f6e9db4-a8d4-47de-97be-e9d0e8074803"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ce372dfc-2331-4855-9ed8-72941ae1d9d5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2uuiooSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2uuioo",
				UId = new Guid("df938ba1-cf1f-4f7b-998a-e526a14b264b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(636, 236),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9f6e9db4-a8d4-47de-97be-e9d0e8074803"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1wwersConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1wwers",
				UId = new Guid("10d58161-27c6-456c-9800-3ca84e57cd5b"),
				ConditionExpression = @"Terrasoft.Configuration.CommunicationUtilities.GetSelectedCommunicationNumbers(UserConnection).Length > 1",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(676, 335),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9f6e9db4-a8d4-47de-97be-e9d0e8074803"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("11411a79-6972-4c80-b471-3f1f5a773311"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3qwedxwqSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3qwedxwq",
				UId = new Guid("97b7d03f-e7e7-441f-b09f-cd70c50d4111"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(825, 338),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("11411a79-6972-4c80-b471-3f1f5a773311"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateCreateMSWordReportMessageSequenceFlow16786785474534SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "CreateMSWordReportMessageSequenceFlow16786785474534",
				UId = new Guid("f045aff9-831d-4d9a-931f-224a6aa833bb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(182, 2435),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("be02116f-138a-4371-9394-f6a71a0c4b5b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2e031421-af26-4fb6-986e-bb78ab06917d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow223543576586834534347SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow223543576586834534347",
				UId = new Guid("f0e3e1d5-8371-4bd7-99c9-1811d9f3127b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(480, 2438),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e57ce0fb-48da-48a5-9500-3b0311ea8aaf"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow156757575757234242424ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow156757575757234242424",
				UId = new Guid("603886c2-dea5-400d-b2f3-ae2bd8335b98"),
				ConditionExpression = @"!(bool)SysSettings.GetValue(UserConnection, ""SaveWordReportAsRecordAttachment"")",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(456, 2526),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("419bf684-d717-417e-a32f-1dbff983ae92"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e6e69f0a-a64b-4683-8570-fecd7ed98855"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow134535354123123768678678SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow134535354123123768678678",
				UId = new Guid("7fe4a3c6-d8ec-4211-971e-d682741e2360"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(468, 2435),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("419bf684-d717-417e-a32f-1dbff983ae92"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e57ce0fb-48da-48a5-9500-3b0311ea8aaf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow235t345346967963453535SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow235t345346967963453535",
				UId = new Guid("bb9eeacc-9eda-4e50-a18c-1685dc988c2a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(342, 2436),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2e031421-af26-4fb6-986e-bb78ab06917d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("419bf684-d717-417e-a32f-1dbff983ae92"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow145785686797335780780SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow145785686797335780780",
				UId = new Guid("c22b7346-54bb-48c1-885a-79df755e95a6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(228, 2740),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("83d722c6-b54b-49c1-9e75-710af234f8da"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c30fee04-e75a-4943-8ff0-69607a375c11"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow145654676797807890345345345SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow145654676797807890345345345",
				UId = new Guid("ff399fef-6b8e-47c4-a75e-6346da491c51"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(525, 4144),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c060ab60-5e2b-464a-9011-2b5d867784d7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c070f3d-a8e7-475a-a74b-1dc9350b3ced"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow289089534343656868678678SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow289089534343656868678678",
				UId = new Guid("764f74c7-8162-44d7-8796-578679dc9f99"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(668, 4142),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0c070f3d-a8e7-475a-a74b-1dc9350b3ced"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow378978978234534534679789789789SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow378978978234534534679789789789",
				UId = new Guid("bb5f51be-a3fd-4b5e-b4be-ea9bd745d65f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(176, 4458),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8459b111-da6c-45e5-b401-b9c10bc2e455"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2deb0bd9-c079-4644-80b7-c8e3dae82748"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1345374563456475685675456456SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1345374563456475685675456456",
				UId = new Guid("3aaaf286-9d99-4b27-9cab-32c2de42c3fb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(533, 4166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f27631e2-2c27-438c-a760-4c991b7a0cf9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("edcc4a52-ebff-45e0-b28e-a6c05c3cb655"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1345353535533654646789973435SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1345353535533654646789973435",
				UId = new Guid("e9375708-85f4-4dca-ae64-c77b0b74e964"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ced35bb-2a8d-49d3-a2c8-8e6a01a969ba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("be1f28b7-fa96-430b-91ab-3b65887a6285"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2346546235423547684564756858SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2346546235423547684564756858",
				UId = new Guid("4cb0b303-94dd-4113-ad86-39f0abc7b7b9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CurveCenterPosition = new Point(896, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2de65970-7933-440d-936d-141bf30d4883"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3cfa055f-2d64-4d7d-bf7e-03df128360ed"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet26LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet26 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("eafcd8c9-4e61-472f-ac4b-e54b508c4258"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"LaneSet26",
				Position = new Point(5, 5),
				Size = new Size(1096, 733),
				UseBackgroundMode = false
			};
			return schemaLaneSet26;
		}

		protected virtual ProcessSchemaLane CreateContextMenuLane_BaseGridPageLane() {
			ProcessSchemaLane schemaContextMenuLane_BaseGridPage = new ProcessSchemaLane(this) {
				UId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("eafcd8c9-4e61-472f-ac4b-e54b508c4258"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ContextMenuLane_BaseGridPage",
				Position = new Point(29, 0),
				Size = new Size(1067, 733),
				UseBackgroundMode = false
			};
			return schemaContextMenuLane_BaseGridPage;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1_BaseGridPageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1_BaseGridPage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("78551111-b367-4bd4-baf2-4929c65ade97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess1_BaseGridPage",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(256, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1_BaseGridPage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSendEmailMenuItemPrepareMenu_BaseGridPage_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e1b1a918-e77e-4f37-aea7-5311fb514f72"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("78551111-b367-4bd4-baf2-4929c65ade97"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SendEmailMenuItemPrepareMenu",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SendEmailMenuItemPrepareMenu_BaseGridPage_StartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateEmailCustomContextMenu_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cd1b6897-ae10-4a41-87b4-dbc850e72dba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("78551111-b367-4bd4-baf2-4929c65ade97"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CreateEmailCustomContextMenu_ScriptTask",
				Position = new Point(134, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,221,111,218,48,16,127,6,137,255,193,202,147,145,136,149,0,205,82,161,78,98,89,91,69,27,82,85,186,237,161,234,195,17,31,212,83,226,100,182,195,64,40,255,251,108,66,182,177,15,158,124,146,239,126,31,247,187,45,40,82,160,172,31,64,161,52,169,193,130,220,16,250,0,27,100,75,148,252,182,0,145,47,236,255,241,7,52,233,234,119,160,113,56,27,244,197,154,208,219,157,97,169,158,127,133,221,35,126,171,81,155,33,57,12,250,189,36,71,80,93,191,166,231,44,110,182,25,244,183,150,62,43,165,129,204,44,179,87,44,32,229,150,95,226,119,114,95,11,78,189,48,90,225,36,186,10,253,120,141,99,127,26,94,93,251,49,231,129,15,113,48,225,211,40,158,112,62,241,28,150,3,194,162,202,203,61,226,63,145,214,171,48,27,175,144,251,215,33,159,250,211,85,16,249,48,142,51,63,26,135,48,225,97,252,38,8,226,159,72,39,73,73,153,215,133,76,160,50,162,148,159,33,175,113,1,149,69,189,199,147,90,221,118,124,20,218,208,142,234,249,133,28,254,244,52,250,91,91,211,109,239,18,23,75,202,90,26,242,150,4,237,74,215,165,66,200,94,9,109,69,254,54,65,132,188,168,154,125,192,189,110,65,122,219,83,230,167,180,173,155,196,78,226,206,116,97,81,111,97,99,247,70,231,20,163,95,190,159,96,67,189,164,165,59,182,253,159,248,249,12,227,101,232,108,247,122,231,199,192,28,49,155,115,78,59,89,109,87,123,135,115,93,185,215,93,223,19,42,5,186,92,27,246,41,101,95,112,229,36,168,50,215,204,53,12,217,35,110,108,18,168,146,92,88,228,101,133,153,128,60,149,194,170,86,162,50,84,27,37,228,134,221,149,170,0,67,189,67,208,88,251,135,67,211,204,108,201,52,154,180,112,68,55,196,93,180,77,204,236,239,228,204,250,235,84,177,22,56,125,127,217,197,201,235,113,147,103,134,154,227,205,43,52,181,146,196,168,26,103,63,0,201,107,184,49,127,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8_BaseGridPageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8_BaseGridPage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8637437e-9cc9-49f7-afee-3c7630bd4641"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess8_BaseGridPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(393, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8_BaseGridPage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProcessEmailContextItemClick_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8650c458-0155-4930-ba08-4d0915d902a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8637437e-9cc9-49f7-afee-3c7630bd4641"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProcessMailContextItemClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ProcessEmailContextItemClick_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessEmailContextMenuClick_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("241dee9f-8625-4938-9c5f-b27f7a5d0e15"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8637437e-9cc9-49f7-afee-3c7630bd4641"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ProcessEmailContextMenuClick_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,81,75,195,48,16,199,159,237,167,8,125,234,160,45,117,186,41,84,7,93,187,141,62,89,180,123,18,145,179,57,106,117,77,198,37,221,148,177,239,110,186,169,171,136,162,79,225,238,254,247,35,249,101,5,196,240,69,19,100,64,80,43,118,201,10,41,180,233,248,249,35,201,245,100,133,66,71,84,42,6,138,37,85,161,43,41,128,94,47,148,166,74,148,46,147,15,79,88,232,81,104,237,27,76,67,105,16,29,224,173,109,90,246,157,159,203,155,93,194,233,133,150,117,181,68,49,169,161,90,76,120,165,51,40,241,126,12,10,103,84,241,93,49,87,72,57,168,103,191,205,33,165,66,105,16,5,166,220,160,219,128,159,145,44,80,41,255,99,50,79,121,248,103,104,91,205,119,44,129,107,54,107,42,238,216,73,156,36,81,48,28,120,39,253,227,177,119,58,24,6,94,20,197,99,47,24,76,135,113,124,214,143,147,243,192,54,55,63,24,96,159,10,246,231,136,45,219,247,162,70,82,239,232,95,194,78,143,109,172,163,141,29,27,215,80,232,148,219,46,187,70,224,41,159,146,172,115,40,29,99,205,101,157,121,175,99,112,235,182,187,57,214,203,5,104,252,113,185,19,248,190,93,52,74,203,58,94,72,133,124,247,201,6,98,127,209,183,159,217,91,107,251,63,183,89,215,195,65,74,104,17,234,134,4,211,212,96,248,6,229,168,101,189,119,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEmailEditPage_BaseGridPage_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c0d1a80d-254a-4ba2-a208-4d9e21b2f319"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8637437e-9cc9-49f7-afee-3c7630bd4641"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"OpenEmailEditPage_BaseGridPage_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 37),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenEmailEditPage_BaseGridPage_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12539EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12539 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c0d62ae7-a85b-4bf7-b30d-d7ecec9dbc8e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess12539",
				Position = new Point(50, 541),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(554, 178),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12539;
		}

		protected virtual ProcessSchemaSubProcess CreateViewRecordAllChangesProcessSubProcess() {
			ProcessSchemaSubProcess schemaViewRecordAllChangesProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("086070f4-9cb3-4534-8ee9-029c02232dab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0d62ae7-a85b-4bf7-b30d-d7ecec9dbc8e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ViewRecordAllChangesProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 37),
				SchemaUId = new Guid("d7111807-3e7b-4e7a-8a98-2d77f3250438"),
				SerializeToDB = false,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeViewRecordAllChangesProcessParameters(schemaViewRecordAllChangesProcess);
			return schemaViewRecordAllChangesProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateShowChangelogMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ce64ed8c-06e3-4051-ae5e-a5e3bc8ef080"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0d62ae7-a85b-4bf7-b30d-d7ecec9dbc8e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ShowChangelogMenuItemClickScriptTask",
				Position = new Point(169, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,65,10,131,48,20,68,247,61,133,39,200,5,74,23,214,210,210,157,168,117,255,73,6,13,141,9,140,137,226,237,171,232,178,184,252,243,134,55,191,181,152,43,232,64,147,59,87,244,226,59,140,37,131,198,56,170,92,71,59,161,33,240,162,53,69,34,225,99,21,230,183,201,110,89,41,29,212,67,162,212,33,81,227,40,175,180,164,29,132,75,17,92,26,124,43,46,225,122,105,79,86,14,111,173,123,12,242,249,235,222,153,90,225,185,234,105,93,4,239,203,30,55,20,253,197,230,139,220,158,32,98,162,223,143,31,253,7,56,112,247,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateShowChangelogMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1f519f5d-9c9a-49bb-9dd8-6d8d1af57530"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0d62ae7-a85b-4bf7-b30d-d7ecec9dbc8e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ShowChangelogMenuItemClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ShowChangelogMenuItemClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1werweEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1werwe = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("87abc823-8872-428e-a204-9985fcd9a64e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess1werwe",
				Position = new Point(42, 175),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(248, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1werwe;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1ddrrgStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c2569eb7-8256-4ff4-b311-8ce2d448f136"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87abc823-8872-428e-a204-9985fcd9a64e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CallMenuItemPrepareMenu",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartMessage1ddrrg",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateCallCustomContextMenu_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("98c735b7-c031-48a4-bb95-93271c373b7d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87abc823-8872-428e-a204-9985fcd9a64e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CreateCallCustomContextMenu_ScriptTask",
				Position = new Point(134, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,149,81,111,218,48,20,133,159,91,169,255,193,226,41,72,196,74,2,132,84,172,149,24,93,43,212,161,85,45,219,30,170,62,56,246,133,90,74,28,228,56,45,8,241,223,103,99,210,21,74,163,181,107,167,61,244,9,132,125,207,189,62,247,211,129,11,133,82,16,197,64,65,58,16,12,102,232,8,93,144,9,224,145,4,56,147,156,225,161,62,197,171,163,111,99,103,117,212,39,73,50,92,215,212,187,7,251,206,211,130,235,13,205,27,68,114,84,86,124,38,57,212,173,234,37,164,217,29,244,146,196,49,50,119,68,34,154,9,69,168,186,162,183,144,146,1,211,195,8,184,71,103,5,103,78,205,15,99,104,134,109,223,141,198,16,184,45,191,125,232,70,140,121,46,137,188,38,107,133,81,147,177,102,173,20,130,116,154,100,115,128,157,74,227,216,167,65,12,204,61,244,89,203,109,197,94,232,146,32,162,110,24,248,164,201,252,168,227,121,209,131,18,161,52,43,196,238,145,130,54,235,80,159,196,174,207,192,115,91,109,207,119,227,150,23,184,94,0,30,180,73,39,96,33,172,132,248,24,89,151,78,136,34,87,89,33,41,96,171,136,191,27,205,163,237,151,215,209,226,96,127,207,244,47,157,212,141,207,64,245,245,53,152,169,210,76,167,102,150,81,107,160,103,196,251,100,170,120,38,26,166,212,254,52,34,19,93,100,155,237,168,235,81,197,239,224,50,187,191,144,60,37,114,222,207,146,34,21,63,72,82,64,221,60,100,239,213,203,238,49,230,164,143,168,89,43,245,242,169,249,52,69,35,144,146,228,217,88,105,79,240,79,136,205,148,50,75,114,108,46,212,53,45,19,158,43,144,253,132,131,222,199,20,40,39,201,64,112,253,48,201,167,202,201,149,228,98,130,79,51,153,18,229,212,22,222,82,91,182,88,44,151,93,253,21,231,160,6,169,105,116,132,190,204,20,214,124,168,249,169,232,106,11,202,161,176,21,30,156,252,253,67,215,182,175,54,244,248,205,203,63,33,97,11,184,247,37,161,103,155,125,144,240,239,73,56,225,212,28,105,107,63,217,129,27,171,84,57,46,163,192,26,190,22,88,249,62,36,83,187,123,187,192,220,222,248,170,189,112,202,76,186,190,65,139,237,44,105,60,77,195,101,25,74,85,189,112,223,160,129,142,145,103,25,28,103,18,8,189,69,142,77,234,71,21,136,139,202,169,241,57,204,115,43,242,2,146,55,90,60,31,97,85,141,175,55,52,110,236,62,223,144,220,255,29,221,119,97,119,111,89,205,239,58,192,94,207,239,246,95,238,3,173,85,202,47,163,181,82,233,237,105,253,29,179,85,141,63,104,125,63,90,37,168,66,10,164,100,1,221,95,184,31,65,21,245,10,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1bghhjEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1bghhj = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess1bghhj",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(350, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(595, 359),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1bghhj;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProcessCallContextItemClick_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a0912c0b-46d8-4b3a-940b-1d4fac5e80e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProcessCallContextItemClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ProcessCallContextItemClick_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 147),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessCallContextMenuItemClick_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e8a5615a-b40a-44c0-b275-c8a9a57f7992"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ProcessCallContextMenuItemClick_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,80,193,78,194,64,16,61,67,194,63,140,61,181,73,211,31,168,152,16,69,194,197,16,41,39,227,97,216,78,203,26,118,215,204,206,162,196,248,239,46,133,130,28,60,123,156,55,239,205,123,111,118,200,64,159,194,184,64,70,227,97,12,202,89,137,72,81,109,216,125,76,119,100,101,194,173,7,244,240,160,149,104,103,145,247,183,94,88,219,54,7,183,126,35,37,119,229,104,120,68,64,176,141,55,126,93,124,73,34,148,188,22,149,91,118,140,52,139,228,93,116,61,248,160,146,121,29,249,207,132,245,188,126,100,103,42,108,211,40,200,33,185,239,247,73,175,64,165,92,176,127,43,38,253,190,83,232,6,210,139,199,205,24,102,65,215,197,212,188,203,62,131,175,209,112,80,17,51,122,215,72,17,173,26,221,6,198,67,189,56,25,19,172,86,221,180,18,189,213,162,201,23,75,146,37,109,99,91,170,175,24,79,193,172,137,125,186,242,196,241,144,165,238,73,57,204,72,78,21,22,27,103,169,167,157,35,101,89,57,24,13,191,143,65,47,213,254,37,232,233,115,87,65,207,145,206,65,153,36,176,5,225,64,229,15,54,13,185,6,56,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateNumberSelectedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("da949a79-83d6-450c-b6e7-d738b148df2e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"NumberSelected",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"NumberSelectedMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 273),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3wwwccExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("9f6e9db4-a8d4-47de-97be-e9d0e8074803"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ExclusiveGateway3wwwcc",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(238, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateNotifyCtiPanelCallMessage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ce372dfc-2331-4855-9ed8-72941ae1d9d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"NotifyCtiPanelCallMessage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 259),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,63,11,194,64,12,197,103,11,253,14,193,201,130,20,157,165,131,56,184,136,20,170,147,56,156,109,218,6,236,93,73,114,46,226,119,247,180,130,127,70,199,151,188,188,252,120,23,195,208,183,206,226,214,119,39,100,129,12,118,200,108,196,213,154,174,156,173,169,241,108,148,156,13,170,235,188,165,242,169,246,74,103,82,66,73,215,168,5,158,177,84,172,190,28,175,192,201,94,144,67,144,13,142,48,77,192,8,136,50,217,230,112,92,196,17,213,48,249,252,159,110,208,54,218,66,150,193,60,129,107,28,141,6,51,72,201,212,235,95,120,57,187,18,69,222,16,75,85,236,122,45,158,145,63,128,83,24,231,15,158,241,244,171,151,195,236,152,4,220,81,110,26,76,151,85,245,186,29,168,30,155,91,28,49,170,103,11,202,30,23,119,103,171,174,192,88,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowNoPhoneNumbersUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f6d55fc1-9305-4739-88ba-c19e05007b8c"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ShowNoPhoneNumbersUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(490, 14),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowNoPhoneNumbersUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessCallContextMenuItemClick_ScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("11411a79-6972-4c80-b471-3f1f5a773311"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ProcessCallContextMenuItemClick_ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(364, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,63,11,194,48,20,196,119,193,239,16,50,233,16,161,37,45,145,226,228,32,29,180,130,246,3,188,36,167,136,53,74,254,224,215,55,90,28,117,184,225,113,247,187,119,221,3,238,128,1,38,238,210,77,195,247,1,254,72,225,186,216,211,25,125,107,217,138,57,60,217,38,93,236,140,43,85,151,165,81,70,144,50,133,144,18,90,16,21,36,78,75,11,93,87,50,171,226,243,102,58,233,126,181,190,13,248,214,133,72,206,224,83,255,61,242,179,127,228,122,184,7,108,17,66,222,149,41,62,218,99,20,150,103,212,35,38,239,88,244,9,205,11,239,110,32,99,215,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenSelectNumberUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f781f2eb-aa5b-4695-9f0b-9eb34b60d99d"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d4ff517-1109-4b75-8caf-c0793106f664"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"OpenSelectNumberUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(490, 133),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenSelectNumberUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ec21fa26-b8d3-4cb1-9b9b-a3cb91aeab8a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess",
				Position = new Point(36, 356),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 160),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSendTemplateEmailMenuItemPrepareMenuStartMessageEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSendTemplateEmailMenuItemPrepareMenuStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1ced35bb-2a8d-49d3-a2c8-8e6a01a969ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec21fa26-b8d3-4cb1-9b9b-a3cb91aeab8a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SendTemplateEmailMenuItemPrepareMenu",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SendTemplateEmailMenuItemPrepareMenuStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateTemplateEmailCustomContextMenu_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("be1f28b7-fa96-430b-91ab-3b65887a6285"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec21fa26-b8d3-4cb1-9b9b-a3cb91aeab8a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CreateTemplateEmailCustomContextMenu_ScriptTask",
				Position = new Point(133, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,77,79,219,64,16,61,19,41,255,193,202,201,145,162,85,123,70,28,66,72,144,165,82,40,14,229,136,6,123,146,44,93,239,154,217,53,96,69,249,239,157,89,199,106,146,170,237,169,39,175,53,111,223,123,243,181,111,64,73,133,182,185,3,66,27,178,128,85,114,145,164,119,176,70,149,163,45,151,88,213,6,2,206,43,208,230,134,113,17,1,62,233,207,151,224,113,124,62,28,232,85,146,206,63,130,202,252,244,5,62,238,241,181,65,31,198,219,225,224,108,102,16,168,135,251,244,88,76,174,238,134,131,55,118,129,254,149,165,45,190,39,115,27,116,104,243,98,131,21,124,107,144,218,244,193,35,205,156,181,88,4,237,172,58,4,220,128,101,179,52,73,70,209,99,111,120,36,204,76,169,102,192,48,38,62,161,200,209,123,254,198,168,122,212,97,243,197,21,96,228,87,219,117,186,204,25,186,210,235,134,32,162,35,236,33,104,163,131,70,175,142,148,98,236,154,92,83,247,146,119,164,43,160,54,90,159,57,211,84,86,202,98,222,161,245,57,26,54,192,118,2,53,184,135,79,203,178,67,165,163,175,80,177,115,117,75,37,210,101,59,245,69,218,115,46,180,9,72,94,192,41,23,53,102,70,200,242,93,64,50,224,170,242,117,65,9,226,172,11,204,92,85,3,105,239,236,178,173,81,205,95,27,48,19,9,143,110,159,95,216,138,202,202,81,252,143,45,191,130,0,185,107,168,224,238,199,234,170,135,172,228,232,120,56,248,239,70,242,214,63,58,250,225,107,96,245,222,213,73,215,14,1,199,182,98,23,100,162,164,132,92,95,31,136,27,169,22,142,42,8,233,241,108,60,109,63,237,158,182,159,119,163,73,242,231,172,39,9,27,186,113,101,99,48,43,69,37,206,104,28,60,238,150,233,12,177,144,136,95,99,152,159,68,78,70,86,8,86,142,235,84,108,210,95,68,137,182,191,81,142,19,89,154,183,253,90,238,23,146,5,152,43,224,71,232,23,233,36,37,78,165,35,234,135,239,74,123,14,236,199,239,59,152,6,39,194,210,229,183,132,245,191,238,31,92,28,139,249,179,227,189,85,226,35,206,64,239,50,130,186,135,99,234,107,249,202,51,177,68,34,240,110,21,184,164,234,17,159,37,11,114,198,43,1,140,213,61,174,181,151,225,48,154,137,243,26,11,13,38,179,154,125,146,174,67,122,210,69,238,27,23,99,187,221,237,206,249,168,60,134,172,18,161,139,68,158,30,78,37,180,11,123,206,185,244,166,84,71,156,93,253,53,135,25,212,82,249,88,214,195,116,248,97,34,12,13,217,110,91,127,2,184,154,213,139,43,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProcessEmailTemplateContextItemClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProcessEmailTemplateContextItemClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2ac96a3d-be56-4b61-8187-a2d14fcc8411"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ProcessEmailTemplateContextItemClickEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(749, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(239, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProcessEmailTemplateContextItemClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProcessEmailTemplateContextItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2de65970-7933-440d-936d-141bf30d4883"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ac96a3d-be56-4b61-8187-a2d14fcc8411"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProcessEmailTemplateContextItemClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ProcessEmailTemplateContextItemClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessEmailTemplateContextItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3cfa055f-2d64-4d7d-bf7e-03df128360ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2ac96a3d-be56-4b61-8187-a2d14fcc8411"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ProcessEmailTemplateContextItemClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,209,110,155,64,16,124,118,164,252,195,149,39,144,208,253,64,155,74,169,227,68,150,234,200,10,164,121,168,250,112,129,45,190,6,238,162,189,197,216,170,250,239,93,14,136,33,169,211,68,66,2,45,51,179,179,115,123,91,133,2,118,132,106,173,80,85,78,156,137,204,26,226,138,76,55,104,155,197,22,12,157,99,225,132,114,226,66,103,164,173,81,184,255,228,8,181,41,98,97,239,127,65,70,159,63,158,158,116,21,65,170,96,141,145,226,247,128,75,193,15,153,218,196,35,194,136,193,219,182,107,165,116,153,66,245,88,42,130,101,206,172,27,80,249,50,191,68,91,165,170,8,153,22,139,96,49,69,5,209,75,161,74,25,85,0,178,192,154,223,242,214,1,206,173,49,224,205,202,53,218,12,156,75,178,13,55,92,117,208,158,232,124,141,121,34,156,160,162,94,81,94,1,45,141,35,101,50,248,178,191,86,21,132,65,2,38,247,158,110,29,123,24,140,245,244,160,181,164,127,138,112,80,62,19,166,46,203,72,252,158,157,158,204,86,140,96,217,59,109,114,219,180,46,83,229,30,100,95,77,57,50,118,210,165,40,47,45,86,138,194,149,205,235,114,16,31,156,92,91,90,236,180,163,158,200,25,253,223,211,145,222,109,94,125,108,45,200,199,119,56,118,30,118,99,155,158,217,201,32,80,141,70,16,214,45,225,79,159,255,216,101,59,131,31,94,206,17,14,46,194,233,169,180,98,29,57,87,164,18,91,99,54,24,145,23,79,149,62,204,17,228,195,83,160,108,230,16,180,244,171,6,4,232,164,207,198,13,199,117,206,237,182,112,99,155,53,234,138,23,119,110,203,186,50,223,84,89,243,68,157,204,108,226,95,38,64,252,249,8,72,123,15,123,93,35,30,13,32,95,1,250,244,56,175,217,27,125,191,88,251,55,122,125,206,139,133,129,70,92,213,58,15,159,221,183,232,189,150,86,76,191,183,187,100,111,50,238,75,188,105,238,171,54,15,239,48,119,92,33,22,71,255,13,54,249,153,234,47,118,144,213,4,225,63,46,125,203,25,175,234,95,108,60,23,94,229,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseGridPageInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseGridPageInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("82a8c96b-065d-40d7-b9fd-54282c9705a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"BaseGridPageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 745),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(554, 183),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseGridPageInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseGridPageInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("90e1d275-94eb-47ba-bb6a-d33039a29424"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82a8c96b-065d-40d7-b9fd-54282c9705a1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"BaseGridPageInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskBaseGridPageInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8f50880b-1417-42aa-9101-5a5d0fd77239"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82a8c96b-065d-40d7-b9fd-54282c9705a1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTaskBaseGridPageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,91,111,219,54,20,126,182,129,252,7,214,15,177,212,9,106,251,172,185,64,236,92,102,44,217,140,56,233,75,16,12,172,116,44,179,147,73,131,164,226,106,169,255,251,14,73,221,108,217,73,151,151,189,8,32,207,237,59,183,143,98,11,226,205,11,117,35,146,60,131,105,66,70,35,114,149,179,36,188,88,173,117,225,147,231,147,126,111,71,76,174,64,183,46,60,63,58,233,111,79,250,51,154,66,120,78,53,157,139,92,198,16,142,97,33,36,220,194,74,60,193,173,216,144,95,70,36,129,12,82,170,193,19,95,191,65,172,137,2,158,128,12,72,99,117,241,4,92,159,201,84,17,112,145,159,168,36,107,25,95,51,165,129,131,84,19,145,229,43,254,7,93,1,2,185,87,32,39,130,115,244,197,4,15,167,51,41,98,80,234,130,167,140,67,88,158,14,152,70,165,99,165,101,30,235,92,26,95,251,240,39,185,148,136,101,94,169,68,71,193,160,113,237,40,116,87,42,188,100,60,25,23,38,152,119,24,190,169,90,143,97,233,15,57,28,17,158,103,153,171,128,141,26,119,35,157,37,137,83,31,23,51,170,151,47,133,233,57,243,112,170,190,48,197,190,102,38,223,5,205,20,236,10,207,178,13,45,212,28,155,132,189,25,17,140,100,21,182,4,80,213,97,233,6,57,226,244,160,226,177,0,56,63,81,119,128,174,5,77,24,79,223,56,56,141,168,244,211,104,140,136,13,107,227,221,45,165,216,88,145,55,232,152,12,236,104,31,129,6,201,27,145,197,130,107,248,174,91,161,219,168,90,128,74,197,128,236,33,195,109,82,71,161,205,36,172,169,132,75,150,105,44,253,219,32,18,210,45,206,152,42,216,245,253,98,117,12,198,91,80,107,193,21,114,64,106,70,65,254,191,21,235,162,169,19,56,233,155,29,131,132,105,147,138,114,20,119,81,29,45,193,153,77,189,43,214,224,102,249,30,121,240,93,155,38,201,233,233,171,12,178,199,13,55,160,169,93,220,29,183,225,157,64,3,156,61,207,247,119,121,192,64,212,181,234,1,198,154,199,75,88,209,58,10,166,48,46,208,227,174,127,191,226,177,248,152,155,14,236,125,162,105,64,132,53,195,188,68,48,175,240,11,110,191,121,40,104,188,36,158,1,198,52,172,8,227,77,59,154,244,105,146,220,0,207,167,70,99,68,38,104,164,1,209,141,115,173,5,175,36,158,113,16,126,161,89,14,129,117,22,254,14,133,95,47,124,173,31,26,3,115,244,90,110,107,86,126,55,69,218,178,195,244,27,100,107,103,49,229,76,51,154,177,127,32,41,169,89,217,86,17,196,191,162,218,245,13,129,13,158,63,110,67,193,189,97,156,177,248,239,97,64,22,57,183,47,148,7,166,151,207,228,249,211,150,108,183,1,209,75,166,252,65,84,145,60,238,22,214,211,174,237,136,212,208,195,249,58,99,218,27,158,14,253,90,211,180,160,154,207,123,251,38,115,216,216,113,244,26,39,15,31,31,247,44,184,102,186,56,170,254,105,95,189,9,96,0,221,237,95,81,69,206,153,205,139,202,226,87,227,45,104,95,184,218,4,54,204,231,207,81,171,92,42,150,108,173,221,150,85,219,136,125,48,142,231,86,228,237,133,15,58,120,30,218,249,60,62,12,234,255,17,163,52,77,6,143,193,78,198,46,177,170,255,101,16,135,38,188,180,205,243,218,61,12,218,147,22,78,50,134,251,48,61,15,74,224,190,31,245,122,229,179,229,136,225,167,134,165,84,156,73,182,194,242,92,73,150,24,210,152,170,107,145,166,230,121,226,20,247,38,49,107,111,71,235,195,123,71,193,18,192,232,226,90,42,45,86,24,102,193,82,59,181,166,133,238,104,167,126,0,214,65,137,195,128,31,32,13,218,37,28,248,63,145,191,29,218,184,177,182,99,50,196,73,253,107,133,167,97,180,65,210,18,155,135,230,230,17,229,120,8,205,33,50,198,29,0,213,142,27,33,195,114,180,68,200,169,8,111,47,195,186,206,246,190,165,93,46,108,165,128,233,188,255,80,39,84,219,159,125,163,223,237,51,160,218,182,225,159,220,217,89,145,251,131,106,167,93,239,166,219,76,132,170,64,151,44,230,25,248,126,132,187,218,194,59,95,138,205,100,73,121,10,153,72,59,67,226,71,255,101,50,200,143,31,206,169,249,24,69,138,63,174,50,116,204,134,111,132,73,201,205,67,99,212,241,103,223,167,222,43,129,218,116,123,210,151,128,204,206,221,213,191,78,200,71,17,255,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEditIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c4615c33-f47c-4253-9ac4-f3ca13df4c19"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82a8c96b-065d-40d7-b9fd-54282c9705a1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"InitializeFilterEdit",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"InitializeFilterEdit_BaseGridPage_IntermediateThrowInitializeFilterEdit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0c6fb7c2-7c16-4a83-93ef-4ca2f55f957b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"PageLoadCompleteEventSubProcess",
				Position = new Point(36, 954),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(638, 195),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a58fb0fd-2928-46a9-9ea9-03750afda36a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c6fb7c2-7c16-4a83-93ef-4ca2f55f957b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"PageLoadComplete",
				Position = new Point(29, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6a3a49da-b2c0-4161-98b8-3c5077053502"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c6fb7c2-7c16-4a83-93ef-4ca2f55f957b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptPageLoadComplete",
				Position = new Point(106, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,83,81,111,218,48,16,126,14,18,255,193,229,97,114,36,112,97,84,27,85,133,166,142,65,27,9,42,180,148,237,97,218,131,137,15,102,205,216,236,236,12,88,197,127,159,157,164,16,30,250,146,56,119,247,125,223,221,119,206,212,112,241,77,194,110,34,149,3,180,116,197,149,133,248,174,217,144,43,66,211,131,206,126,161,209,242,31,124,225,142,167,38,199,12,82,135,121,230,114,132,152,188,52,27,209,88,59,233,14,231,244,194,73,37,157,4,203,106,232,19,134,206,249,26,216,185,58,40,29,155,141,177,144,46,100,30,65,109,71,70,59,216,187,68,144,33,161,244,25,16,185,53,43,199,22,9,251,14,203,144,69,163,108,237,28,23,156,225,17,2,92,106,192,152,93,48,121,145,196,78,205,122,45,245,122,172,249,82,129,160,65,185,0,142,184,82,51,208,121,226,96,195,30,165,16,160,189,178,111,24,238,174,175,175,206,250,158,109,37,215,57,114,39,141,102,51,187,78,1,255,202,250,192,35,174,23,22,206,25,234,191,208,195,52,100,1,243,234,106,98,231,40,55,28,15,15,40,69,105,162,119,95,205,209,100,96,109,104,133,86,182,52,27,51,31,241,77,206,185,6,69,54,245,143,33,169,198,63,235,79,164,22,85,144,122,210,168,24,239,222,110,203,49,43,227,126,116,127,182,73,235,51,247,141,214,232,90,237,98,226,152,112,75,234,241,170,229,11,229,171,33,209,185,82,101,231,51,46,213,210,236,195,174,83,112,206,27,108,167,82,255,46,182,247,144,75,193,158,96,23,222,197,72,81,157,135,133,58,203,238,133,160,26,118,228,205,69,159,14,161,190,92,66,161,28,45,48,184,16,176,11,148,229,197,250,10,127,114,176,158,2,85,155,132,154,200,58,244,61,177,137,193,13,119,180,21,174,122,81,201,237,118,255,41,17,195,108,144,65,175,207,187,157,254,160,255,161,115,179,228,31,59,203,254,224,214,159,110,225,125,183,119,211,237,245,179,119,185,223,163,175,125,233,30,189,79,151,75,101,163,28,17,180,11,81,150,136,56,102,207,38,45,52,105,220,142,66,11,39,59,222,180,170,14,9,136,17,223,6,106,15,241,117,175,165,79,102,231,115,199,234,102,32,248,191,73,151,183,244,63,95,118,89,6,195,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskCheckMenuItemScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b40bc5dd-63f4-4576-8a30-5dafb14b6446"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c6fb7c2-7c16-4a83-93ef-4ca2f55f957b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTaskCheckMenuItem",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,44,118,73,45,73,204,204,113,47,202,76,209,84,168,230,229,226,116,203,204,201,9,40,202,204,43,241,77,205,43,213,208,180,6,10,101,2,85,6,36,166,167,234,129,197,157,74,75,74,242,243,244,64,210,122,206,249,165,121,37,10,118,10,6,16,189,156,24,170,60,50,83,82,82,243,20,108,21,210,18,115,138,83,65,134,213,242,114,1,81,81,106,73,105,81,158,66,73,81,105,170,53,0,178,203,156,40,137,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptRegisterClientScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("64bc4d5a-1c95-41fd-9e9d-f0841451db04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c6fb7c2-7c16-4a83-93ef-4ca2f55f957b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptRegisterClientScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(371, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,77,111,211,64,16,61,187,82,255,195,54,151,216,146,181,133,115,212,67,235,148,42,32,90,32,41,28,162,28,28,123,146,46,172,63,180,31,160,40,242,127,103,103,189,78,108,234,226,32,85,66,202,33,187,158,247,230,189,153,217,145,74,176,124,75,54,133,200,98,53,175,15,87,100,180,127,83,209,34,247,199,9,103,201,143,113,72,54,58,79,20,51,55,192,3,178,223,147,253,219,138,84,85,72,212,19,147,193,104,114,126,38,107,168,76,4,43,149,97,184,3,245,5,182,76,42,16,159,53,72,196,206,237,55,63,48,209,108,67,252,139,26,66,103,242,94,115,254,32,110,179,82,237,252,154,32,48,73,188,243,51,239,83,188,5,122,157,166,14,234,16,239,172,88,191,173,57,36,54,116,10,28,20,220,104,165,138,156,70,156,65,174,102,211,144,52,164,38,115,85,39,95,236,74,136,10,174,179,252,113,150,146,11,163,87,179,148,90,9,38,181,201,252,51,22,68,29,130,238,227,12,140,169,58,71,172,226,121,161,69,2,116,158,60,65,22,211,58,70,82,227,249,102,103,248,186,236,129,251,254,53,230,26,144,200,168,240,46,47,201,95,189,217,6,72,80,145,150,170,200,48,165,63,238,202,49,77,25,155,46,140,131,201,40,60,112,61,115,222,197,216,10,120,174,85,10,178,18,137,63,192,14,59,222,28,177,153,214,253,181,44,145,182,177,221,28,99,73,22,32,68,44,139,141,162,143,51,250,13,214,81,145,43,81,112,73,49,0,225,182,189,14,64,143,22,40,6,198,44,151,38,165,223,74,31,212,37,247,122,16,198,83,59,50,36,57,252,34,239,31,214,223,33,49,147,100,237,84,77,183,92,152,17,252,156,104,217,34,89,161,7,199,129,4,238,47,73,107,112,110,166,113,226,121,206,70,131,91,190,80,226,21,14,15,66,156,7,71,50,12,235,106,168,8,112,9,29,138,142,83,27,99,69,225,215,229,168,219,215,209,170,137,183,67,230,255,209,117,4,15,11,186,178,5,168,157,15,21,240,104,16,185,205,171,58,202,239,219,0,38,29,210,185,73,191,77,153,194,163,121,27,33,153,239,228,199,34,213,28,240,22,47,90,15,113,210,52,97,104,85,96,213,254,117,85,244,189,150,214,158,192,177,50,191,62,55,141,254,19,236,32,83,31,197,66,0,220,9,150,78,215,60,194,13,219,136,174,243,159,184,32,135,246,227,97,137,167,107,126,218,30,119,165,105,212,189,184,65,95,161,42,175,97,176,167,171,152,96,96,253,247,137,143,138,114,247,255,197,163,138,1,241,2,148,22,57,81,66,195,228,55,162,40,182,115,187,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaSubProcess CreateLoadPrintReportButtonMenuProcessSubProcess() {
			ProcessSchemaSubProcess schemaLoadPrintReportButtonMenuProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("cde71fb5-e60e-4225-a880-ab81c127d7d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c6fb7c2-7c16-4a83-93ef-4ca2f55f957b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"LoadPrintReportButtonMenuProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(554, 125),
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

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e63ad5b7-44b1-47f2-8c5f-6e757dbdef31"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess4",
				Position = new Point(29, 1175),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(565, 254),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ae0d6ca0-9d7b-4fc1-a214-bfc25300d799"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e63ad5b7-44b1-47f2-8c5f-6e757dbdef31"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"AddButtonClick",
				Position = new Point(15, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAddButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("98efad80-8442-4330-8c08-c4d14232c7c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e63ad5b7-44b1-47f2-8c5f-6e757dbdef31"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptAddButtonClick",
				Position = new Point(350, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,74,45,72,44,74,245,47,72,205,115,77,201,44,9,72,76,79,13,72,44,74,204,77,45,73,45,42,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,39,200,203,191,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSetDefValuesScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("43a6b49d-0742-4f58-99e0-ef4e671d2311"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e63ad5b7-44b1-47f2-8c5f-6e757dbdef31"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptSetDefValues",
				Position = new Point(217, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,45,113,73,77,11,75,204,41,77,45,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,74,28,7,38,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSendAllowRequestScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e469f4f1-cfa0-42db-9295-ea2f96e88b4b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e63ad5b7-44b1-47f2-8c5f-6e757dbdef31"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTaskSendAllowRequest",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 142),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,240,129,10,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,5,165,22,150,166,22,151,56,166,164,184,164,150,36,102,230,248,2,101,128,106,148,52,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,170,228,80,243,83,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAllowAddDetailMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("32e28819-8c26-431d-83b7-195db3b3b8a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e63ad5b7-44b1-47f2-8c5f-6e757dbdef31"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AllowAddDetailMessage1",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartMessageAllowAddDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateGatewayCheckAlloAddDetailExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("48b36f4c-a0b0-4aae-9885-e54b830f70eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e63ad5b7-44b1-47f2-8c5f-6e757dbdef31"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"GatewayCheckAlloAddDetail",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskAddOpenWindowUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c140f4a8-077b-4cc6-89e6-5fa5e71b2f71"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e63ad5b7-44b1-47f2-8c5f-6e757dbdef31"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"UserTaskAddOpenWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(462, 35),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskAddOpenWindowParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8f21206f-ffe1-4d10-95dd-5a3e401afc56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess6",
				Position = new Point(29, 1434),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(463, 228),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEditButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a1332396-f146-4aa4-950f-5244739f32e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f21206f-ffe1-4d10-95dd-5a3e401afc56"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EditButtonClick",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptEditButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4f3938ec-fed9-4842-ba5d-02b2a4f006fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f21206f-ffe1-4d10-95dd-5a3e401afc56"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptEditButtonClick",
				Position = new Point(106, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,74,45,72,44,74,245,47,72,205,243,205,79,41,205,73,117,77,201,44,9,72,76,79,13,72,44,74,204,77,45,73,45,42,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,68,36,54,25,51,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskEditOpenWindowUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("71fbf623-c1da-4252-a101-08ff4a8badd0"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f21206f-ffe1-4d10-95dd-5a3e401afc56"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"UserTaskEditOpenWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(323, 30),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskEditOpenWindowParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("1187aaba-0ef2-45e5-a4bf-f47de9d17d0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f21206f-ffe1-4d10-95dd-5a3e401afc56"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDefEditScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("733ee819-36c5-427b-87fc-0be76a8e013c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f21206f-ffe1-4d10-95dd-5a3e401afc56"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptDefEditScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0aa48f27-6309-4522-8361-c08d16c6fc16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess7",
				Position = new Point(36, 1666),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(294, 212),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("56e65ffb-cfe8-4f83-b2cc-377ab0ad0bb8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0aa48f27-6309-4522-8361-c08d16c6fc16"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptDeleteButtonClick",
				Position = new Point(98, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,206,207,10,130,64,16,6,240,115,62,197,178,103,233,5,172,14,161,135,14,105,249,231,224,81,236,67,132,216,141,157,145,18,241,221,219,197,133,180,203,124,12,191,111,96,42,130,185,130,168,233,176,191,217,33,142,194,69,20,84,43,240,89,226,195,214,99,60,193,200,209,106,243,240,178,173,95,90,173,108,79,222,171,164,40,47,89,42,183,124,30,152,181,34,215,168,147,34,205,254,56,7,189,44,195,239,174,167,240,22,113,223,114,175,85,99,198,3,177,233,85,23,138,37,79,98,10,118,147,28,65,50,20,114,121,174,6,249,115,57,135,78,149,254,97,170,87,54,71,129,1,15,70,9,54,3,162,47,21,18,83,39,15,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cedc5fb2-cf5c-4c73-a44d-c92d4af8b062"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0aa48f27-6309-4522-8361-c08d16c6fc16"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"UserMessage",
				Position = new Point(210, 28),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2f99e62f-c050-4b1e-87d2-39d5393c270a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0aa48f27-6309-4522-8361-c08d16c6fc16"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DeleteButtonClick",
				Position = new Point(28, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageCustomDeleteMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a03fd159-e954-43ba-a2bd-6db776117fe2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0aa48f27-6309-4522-8361-c08d16c6fc16"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CustomDeleteMessage",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartMessageCustomDeleteMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 126),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskCustomDeleteMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2dd25769-6b44-4e0d-8959-3448584ee10c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0aa48f27-6309-4522-8361-c08d16c6fc16"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTaskCustomDeleteMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(98, 112),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,45,46,201,207,117,73,205,73,45,73,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,169,163,188,196,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ed21598d-905f-4a9b-b633-6ab5d3ed04c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess5",
				Position = new Point(498, 1435),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(425, 221),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCopyButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5fbf7352-f831-42ef-9724-84156114e6c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed21598d-905f-4a9b-b633-6ab5d3ed04c9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CopyButtonClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CopyButtonClick",
				Position = new Point(28, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptCopyButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("86cc8d24-167b-43a7-bf0b-256241d63a85"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed21598d-905f-4a9b-b633-6ab5d3ed04c9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptCopyButtonClick",
				Position = new Point(106, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,74,45,72,44,74,117,206,47,168,244,47,72,205,11,207,204,75,201,47,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,138,123,225,45,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskOpenCopyEditPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ceea7f23-f673-448d-980e-f422170fd594"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed21598d-905f-4a9b-b633-6ab5d3ed04c9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"UserTaskOpenCopyEditPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 30),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskOpenCopyEditPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDefCopyButtonScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3b949a31-54f6-4b1c-84bc-f6a9a8903fee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed21598d-905f-4a9b-b633-6ab5d3ed04c9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptDefCopyButton",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(210, 125),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayCopyOpenWindowExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("6b8b652c-170d-4398-85fe-53da3e3ead24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed21598d-905f-4a9b-b633-6ab5d3ed04c9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ExclusiveGatewayCopyOpenWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("52bbae35-7cd2-4e3d-83b1-b162227c2a67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SubProcess5",
				Position = new Point(336, 1665),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(219, 101),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteNoMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8334edc8-790e-4017-9baa-84828238e595"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52bbae35-7cd2-4e3d-83b1-b162227c2a67"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteNoMessage",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DeleteNoMessage",
				Position = new Point(36, 29),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteNoMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("852df471-5a6d-4017-8422-f4fb37356a7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52bbae35-7cd2-4e3d-83b1-b162227c2a67"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptDeleteNoMessage",
				Position = new Point(113, 15),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessOpenPrintReportEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessOpenPrintReport = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SubProcessOpenPrintReport",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 1897),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(647, 297),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessOpenPrintReport;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageOpenPrintReportMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f60b76a8-9f7a-4220-aeac-0896f32dad4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpenPrintDevExpressReportMessage",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartMessageOpenPrintReportMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPrepareParametersOpenPrintReportScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d371b146-df23-43c5-907e-19ab135966ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTaskPrepareParametersOpenPrintReport",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,193,74,195,64,20,69,215,153,175,120,116,97,19,40,193,186,141,22,74,21,21,5,131,105,87,37,139,49,125,78,70,218,153,225,205,75,106,145,254,187,147,136,52,80,193,237,229,158,123,184,173,36,168,172,97,252,228,92,146,220,33,35,121,184,249,205,210,101,77,118,127,215,162,225,57,41,15,210,195,173,174,88,91,35,233,112,237,153,180,81,19,176,111,31,88,241,44,19,250,29,226,179,181,116,17,18,169,141,127,194,67,60,98,169,70,73,2,95,34,106,131,218,253,225,60,145,235,190,93,166,75,91,244,166,56,73,11,183,213,28,143,47,198,73,38,162,78,119,90,72,159,209,40,174,97,6,211,126,63,202,3,195,175,232,44,113,81,213,184,147,171,199,77,208,24,220,195,125,163,55,3,116,125,89,118,123,67,226,197,117,47,253,127,224,244,12,204,165,194,7,220,186,197,207,155,158,28,0,87,101,232,31,197,81,16,114,67,6,152,26,204,190,1,158,190,237,216,134,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskClearPrintUserContextScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d125104f-5de5-4320-a89b-958edaaef717"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTaskClearPrintUserContext",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(546, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,78,45,46,6,210,46,137,37,137,122,65,169,185,249,101,169,26,74,1,69,153,121,37,65,169,5,249,69,37,1,137,69,137,185,169,37,169,69,197,74,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,207,243,235,149,73,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageOpenPrintReportButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("35d95d40-2e4f-442a-bf66-2ea1be25c1d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PrintButtonClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartMessageOpenPrintReportButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 175),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b56e7de1-87ca-4be3-9697-01291dc4ffdf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSetReportOptionsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("140ca1ac-5412-42a4-8521-6f911e66aa07"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTaskSetReportOptions",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(322, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,209,110,218,48,20,125,6,137,127,112,243,148,104,96,137,13,13,80,215,73,93,219,181,72,107,137,72,171,62,76,211,100,197,23,176,22,236,200,118,160,12,241,239,179,29,82,146,64,233,203,242,226,196,185,247,220,115,124,207,53,155,34,63,148,140,235,9,164,66,234,40,158,195,130,60,141,40,186,184,64,183,25,163,248,102,145,234,117,128,54,173,102,67,130,206,36,71,90,102,112,222,106,110,91,205,39,5,242,145,168,63,14,96,156,2,127,102,156,138,21,182,175,32,71,92,105,194,99,176,96,168,248,48,208,38,119,73,36,74,201,12,242,114,247,132,155,119,105,162,66,179,226,107,162,73,36,50,25,3,206,255,227,74,88,40,197,146,81,144,248,22,244,110,203,247,194,58,152,23,156,191,205,207,70,59,141,8,113,88,57,157,190,215,143,41,1,50,24,116,98,50,232,118,122,221,33,237,12,73,191,223,137,63,118,7,189,233,167,184,59,252,220,115,168,85,242,6,228,64,137,165,86,8,254,182,54,149,252,119,152,4,136,40,180,215,240,90,68,146,5,104,144,202,50,109,53,145,123,44,227,107,22,107,38,56,145,235,47,74,27,200,89,27,229,235,87,219,40,84,122,54,94,173,177,94,27,29,235,55,126,20,145,67,240,131,109,219,244,186,209,216,120,55,92,51,189,174,100,30,239,79,45,191,96,176,53,58,216,180,108,175,113,106,105,171,189,203,206,14,93,182,87,141,47,169,233,75,158,179,63,156,3,13,117,208,18,149,32,247,169,33,113,150,159,15,30,169,135,44,73,198,210,21,44,83,179,5,238,32,73,175,4,215,240,162,77,79,142,211,169,196,84,137,28,66,156,30,19,27,31,150,123,188,175,117,194,188,207,140,234,121,197,117,249,214,137,148,59,96,179,185,174,230,228,123,39,146,174,192,168,144,96,167,100,55,241,111,70,38,66,65,62,243,99,254,67,16,155,50,37,137,130,157,143,21,36,16,107,160,19,177,178,42,205,112,68,165,29,191,152,84,115,108,28,156,175,113,4,74,153,213,58,237,231,59,110,69,31,144,247,187,192,187,52,233,75,176,168,222,47,83,169,92,248,100,17,60,129,133,88,194,209,155,176,94,203,10,189,23,20,188,255,194,91,50,146,176,191,64,191,179,196,246,221,209,118,7,84,251,225,78,169,124,1,255,3,34,179,197,98,185,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskPrintOpenWindowUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b232c525-12ad-42ef-8785-707390f4e71c"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"UserTaskPrintOpenWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(546, 48),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskPrintOpenWindowParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayOpenPrintExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("d4d93ae6-c806-42c8-b93b-c173941216dc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ExclusiveGatewayOpenPrint",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(434, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDefOperPrintWindowScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5204dbbf-5b6f-4fd6-abca-18b5112fa1f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0971058b-1645-4287-aa3d-b86eab782c94"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptDefOperPrintWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(427, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0710c493-5f13-4bcc-b164-65906dcce2f6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SubProcess4",
				Position = new Point(337, 1771),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(227, 114),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteYesMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("20c865f7-a59c-494c-a008-20c5bb01dcbd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0710c493-5f13-4bcc-b164-65906dcce2f6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DeleteYesMessage",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteYesMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a52679bb-9d72-4ead-895d-4b5ea5729568"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0710c493-5f13-4bcc-b164-65906dcce2f6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptDeleteYesMessage",
				Position = new Point(119, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,77,111,219,48,12,61,219,191,130,203,161,112,128,192,237,61,200,161,77,187,98,192,86,4,77,186,29,138,30,84,139,73,4,216,146,33,203,201,130,53,255,125,148,172,56,254,72,50,20,59,25,161,200,199,71,242,145,217,48,13,5,166,152,24,228,79,138,99,1,19,152,177,21,198,11,141,248,168,5,143,231,205,215,113,40,150,16,181,2,226,169,42,165,129,201,4,110,134,240,39,12,52,154,82,75,48,186,196,113,184,15,131,176,48,90,200,21,228,90,100,76,239,158,49,81,154,255,100,169,125,222,80,118,206,12,155,171,82,39,120,72,125,95,91,198,225,187,82,41,8,153,164,37,199,123,204,81,114,148,201,238,7,22,5,121,82,192,146,165,69,199,237,89,172,214,230,59,110,48,237,185,121,42,91,166,37,125,253,243,55,78,14,131,95,29,219,160,98,151,48,121,79,213,154,10,149,28,23,168,53,43,212,210,80,221,154,184,222,197,243,100,141,25,171,234,58,230,166,190,28,66,107,164,233,154,201,21,254,7,94,15,96,28,134,215,215,240,136,6,50,95,107,206,36,166,176,84,148,176,212,26,105,50,57,153,67,95,215,204,189,102,205,31,19,152,42,105,180,74,95,140,72,133,17,52,209,175,66,114,111,140,194,192,205,228,182,200,221,215,155,139,215,155,183,17,12,238,88,129,77,228,193,200,205,125,8,172,128,166,189,162,249,140,153,218,96,205,148,148,36,12,176,60,71,166,145,195,59,18,105,4,163,128,109,148,224,192,203,60,21,9,51,52,20,39,186,22,233,47,19,144,101,154,58,193,53,31,226,42,71,212,157,240,208,74,177,193,225,160,96,144,86,194,161,205,204,146,53,68,118,80,214,68,90,106,175,133,203,212,151,48,117,207,186,199,238,71,241,218,145,175,31,101,60,171,226,166,42,45,51,25,63,177,12,223,226,133,154,59,49,70,68,45,112,123,240,62,71,26,153,48,187,7,185,18,178,222,134,151,2,53,117,93,18,23,161,36,9,164,237,230,163,105,208,100,170,242,245,247,200,19,241,190,186,22,21,121,118,211,198,36,166,135,6,88,87,135,36,136,160,153,204,149,51,2,137,91,120,44,5,143,250,61,26,218,10,221,130,118,86,128,178,71,13,46,87,39,87,100,104,47,203,169,135,6,232,121,184,19,64,109,8,171,172,46,173,143,143,163,159,155,123,96,244,206,125,131,227,177,58,40,237,95,133,7,116,2,3,146,177,85,215,195,239,4,115,59,69,240,184,193,133,203,86,29,80,23,191,7,218,127,116,17,23,110,156,15,216,135,251,192,73,125,190,86,91,187,94,90,17,53,102,234,197,187,188,77,39,79,36,84,14,190,95,103,73,95,93,157,189,193,85,189,61,212,163,223,17,173,125,137,199,117,249,151,82,159,129,255,20,232,231,57,247,65,171,6,117,66,154,237,109,95,171,91,206,189,83,239,98,141,172,60,124,130,81,103,28,163,195,113,93,236,114,140,189,211,176,154,125,216,250,255,253,11,136,146,163,197,223,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCreateMSWordReportMessageEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCreateMSWordReportMessageEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("177d8565-e713-409a-90d3-030b4b516532"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CreateMSWordReportMessageEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 2225),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(722, 275),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCreateMSWordReportMessageEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCreateMSWordReportMessageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("be02116f-138a-4371-9394-f6a71a0c4b5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("177d8565-e713-409a-90d3-030b4b516532"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CreateMSWordReportMessage",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CreateMSWordReportMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateMSWordReportMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2e031421-af26-4fb6-986e-bb78ab06917d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("177d8565-e713-409a-90d3-030b4b516532"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CreateMSWordReportMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,65,107,194,64,16,133,207,10,254,135,37,135,26,65,22,239,173,130,84,43,210,82,164,106,61,136,135,213,76,226,150,184,27,102,39,90,41,254,247,238,110,146,170,181,244,150,132,55,223,123,243,50,50,102,225,68,36,192,103,8,48,66,25,241,41,164,176,33,136,94,117,4,134,63,234,92,17,235,118,89,167,197,190,26,245,26,2,229,168,24,97,14,247,141,250,169,81,223,11,100,27,173,8,62,105,34,80,236,128,0,13,235,86,223,248,108,139,250,48,220,131,162,62,38,134,9,195,6,114,67,82,43,129,199,7,67,40,85,210,102,122,253,97,61,123,150,40,109,158,27,156,77,161,72,72,101,158,225,24,6,36,146,160,85,164,113,230,217,31,174,231,209,165,151,175,248,76,79,189,87,216,226,211,44,149,20,54,239,154,45,235,87,115,134,103,4,127,1,149,208,150,245,170,125,189,5,66,166,145,198,145,53,80,112,96,163,92,70,23,51,203,206,202,147,74,233,70,99,116,45,253,167,95,59,203,223,69,154,219,167,96,28,93,229,60,51,15,150,248,230,35,204,73,218,236,199,18,62,3,68,97,116,76,174,159,88,38,57,10,87,44,95,252,214,135,115,3,104,53,10,124,243,5,217,69,99,177,76,193,135,189,241,224,35,80,96,129,80,124,13,171,14,218,63,43,22,24,215,95,69,233,250,125,249,112,151,209,177,172,175,58,152,88,164,6,252,192,169,90,75,152,204,53,99,205,125,65,253,242,213,94,200,121,177,249,152,47,96,237,126,63,234,212,112,39,240,144,114,150,63,230,134,244,110,32,72,44,131,34,232,147,207,18,172,44,182,136,229,244,39,127,170,141,250,229,245,126,3,243,45,34,21,250,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateShowMSWordReportCreatedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e57ce0fb-48da-48a5-9500-3b0311ea8aaf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("177d8565-e713-409a-90d3-030b4b516532"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ShowMSWordReportCreatedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(421, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,193,78,194,64,16,134,207,54,233,59,108,246,76,124,1,212,131,18,147,141,32,13,109,195,121,220,157,64,45,236,52,51,83,209,16,222,221,69,74,226,73,123,154,204,228,255,254,111,202,45,29,22,229,154,56,172,176,35,214,39,70,80,12,181,32,87,32,237,109,193,228,81,196,69,81,136,30,93,48,247,230,186,212,46,76,243,172,252,167,97,145,112,216,96,133,159,154,216,223,201,53,200,16,30,81,227,60,197,196,91,247,250,188,180,35,242,143,189,42,69,57,35,203,151,49,192,10,165,75,0,14,255,158,201,136,7,51,107,188,54,20,129,191,238,68,185,137,155,137,185,204,7,115,204,179,155,163,165,214,78,140,45,225,3,47,189,21,205,201,195,110,214,72,107,79,121,118,26,161,46,146,175,0,134,61,42,242,31,98,122,123,71,175,87,177,147,186,219,17,132,164,87,238,113,112,49,106,207,241,231,50,253,6,4,209,27,93,221,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowMSWordReportCreatedUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("06130922-63ff-45b2-9119-15ae1e0d641d"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("177d8565-e713-409a-90d3-030b4b516532"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ShowMSWordReportCreatedUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(610, 49),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowMSWordReportCreatedUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway33453453456789789783434535ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("419bf684-d717-417e-a32f-1dbff983ae92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("177d8565-e713-409a-90d3-030b4b516532"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ExclusiveGateway33453453456789789783434535",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(288, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1345345897809780343535EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("e6e69f0a-a64b-4683-8570-fecd7ed98855"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("177d8565-e713-409a-90d3-030b4b516532"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"End1345345897809780343535",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(442, 203),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSaveReportToLocalDiskEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSaveReportToLocalDiskEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4dc53ca6-21e8-41af-b704-5dffe03805a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SaveReportToLocalDiskEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 2522),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSaveReportToLocalDiskEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSaveReportToLocalDiskStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("83d722c6-b54b-49c1-9e75-710af234f8da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4dc53ca6-21e8-41af-b704-5dffe03805a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SaveReportToLocalDisk",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SaveReportToLocalDiskStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveReportToLocalDiskScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c30fee04-e75a-4943-8ff0-69607a375c11"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4dc53ca6-21e8-41af-b704-5dffe03805a9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SaveReportToLocalDiskScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,193,110,219,48,12,61,47,64,254,65,240,73,6,12,161,247,44,3,58,47,43,114,88,151,37,233,50,32,200,65,141,153,84,128,44,121,148,212,194,88,247,239,19,109,39,238,226,98,232,78,2,197,199,167,71,62,73,143,18,153,116,213,66,30,129,77,25,45,226,186,11,165,99,107,64,148,206,30,188,184,155,139,13,220,231,214,120,180,218,9,2,76,198,35,117,96,188,171,22,121,112,222,150,159,164,151,219,100,9,149,69,255,89,105,152,23,201,142,77,167,204,4,173,217,120,244,238,249,153,57,143,202,28,197,220,221,198,189,175,56,43,43,95,191,129,69,172,237,170,169,228,105,154,178,95,145,11,193,7,52,204,99,32,45,191,199,163,241,232,49,182,115,104,10,98,55,6,158,216,77,80,197,127,146,79,136,168,165,2,227,149,175,87,251,7,40,229,23,105,34,7,70,222,59,7,24,39,97,96,239,149,53,98,54,4,77,134,229,223,2,96,221,137,154,93,238,243,87,14,202,88,66,234,146,116,210,183,69,210,115,171,67,105,110,101,73,134,13,78,16,215,69,209,34,120,66,232,36,21,4,125,193,65,225,219,57,8,211,115,12,161,81,162,7,116,84,194,135,217,28,65,122,104,49,27,229,31,22,18,35,17,21,240,118,51,183,101,37,81,57,107,214,117,5,98,246,51,72,157,209,61,25,114,45,173,245,109,44,110,192,47,80,149,18,235,190,17,158,102,157,243,233,105,98,123,171,117,235,209,171,93,70,150,214,136,252,140,227,127,91,155,118,87,188,39,18,185,13,198,211,133,190,250,231,29,220,7,196,120,226,210,62,197,163,251,242,237,213,174,211,86,68,111,40,117,198,145,156,143,181,7,247,93,234,0,124,232,118,74,15,242,62,34,182,187,11,55,7,60,52,203,206,193,134,237,125,251,228,62,240,161,255,167,89,45,193,85,214,184,243,39,112,138,99,122,189,138,19,57,168,99,64,217,140,128,242,167,180,216,160,242,192,79,97,214,244,149,157,149,101,236,178,152,126,144,40,180,113,251,71,169,105,109,31,220,203,65,254,1,136,72,230,203,149,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0242a396-3be1-4bf2-a329-ee67e681d589"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess3",
				Position = new Point(36, 2726),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(203, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowEditButtonClickIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("949b78e9-58a2-4555-bf53-4e390b056524"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0242a396-3be1-4bf2-a329-ee67e681d589"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ThrowEditButtonClick",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridDblClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0cfbb5c2-ff9c-44a8-b45b-4af693fce3d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0242a396-3be1-4bf2-a329-ee67e681d589"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TreeGridDblClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"TreeGridDblClick",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("16140af4-ca5d-4620-8b5d-6d68fb31ac59"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess2",
				Position = new Point(253, 2728),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(239, 133),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageNonInterruptingEvent2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b1e311a3-3e9c-4b51-865a-fa7e6ede7d2a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16140af4-ca5d-4620-8b5d-6d68fb31ac59"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartMessageNonInterruptingEvent2",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridPageRefreshRowScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ea8c0720-e286-4004-9364-7ed7bf2b763b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16140af4-ca5d-4620-8b5d-6d68fb31ac59"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptGridPageRefreshRow",
				Position = new Point(105, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,223,78,194,48,20,135,175,37,225,29,42,23,100,187,233,3,72,136,209,33,184,196,24,195,64,47,140,23,117,61,131,37,93,171,167,45,132,24,223,221,206,253,97,27,98,178,171,110,61,251,125,253,210,115,182,99,72,56,51,44,82,22,99,32,83,242,196,54,64,103,245,206,100,56,216,185,79,98,139,8,210,68,6,109,108,44,230,31,30,83,52,232,84,203,16,7,195,82,49,79,133,1,212,46,209,133,208,178,228,86,201,111,15,143,44,3,111,52,107,132,70,190,35,165,9,241,218,164,203,41,145,86,8,159,124,13,7,23,103,161,75,200,212,14,218,209,156,247,93,200,105,96,24,111,123,202,69,141,80,45,215,38,245,146,107,69,27,114,137,18,28,176,167,220,188,17,170,229,218,164,94,114,173,104,41,151,38,222,113,54,138,82,13,253,151,121,195,185,231,173,0,145,105,149,24,186,14,233,11,188,7,74,26,84,66,211,250,33,236,210,67,3,153,79,186,187,165,205,137,74,97,82,142,159,65,128,5,166,188,26,234,85,249,238,202,85,137,6,194,117,192,203,113,71,214,18,62,45,104,67,176,92,79,254,9,26,197,91,200,24,189,79,1,243,254,29,2,37,108,38,201,180,56,158,92,23,203,21,145,176,39,39,220,223,211,186,196,7,197,248,82,237,181,87,30,90,181,111,6,201,51,19,110,39,228,249,61,47,172,115,190,203,62,204,129,140,199,100,173,1,221,205,73,136,77,170,36,141,64,107,183,230,212,215,70,142,174,148,107,71,42,55,158,255,214,30,128,243,249,106,4,254,198,84,183,223,112,107,170,185,42,130,107,190,116,29,176,48,249,1,126,15,248,5,98,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDataSourceActiveRowChangedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDataSourceActiveRowChangedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("572d5404-89d1-4679-be14-a6ee40c99e29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceActiveRowChangedEventSubProcess",
				Position = new Point(36, 3026),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(226, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDataSourceActiveRowChangedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceActiveRowChangedEventStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("476873f8-10a4-41fd-97e5-17e664da6b66"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("572d5404-89d1-4679-be14-a6ee40c99e29"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceActiveRowChangedEvent",
				Position = new Point(29, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDataSourceActiveRowChangedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4d8b9f3e-6330-436f-9462-b038b1216c75"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("572d5404-89d1-4679-be14-a6ee40c99e29"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceActiveRowChangedScriptTask",
				Position = new Point(113, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,209,10,130,64,20,68,159,19,252,7,241,201,160,63,232,201,74,66,40,144,178,15,88,220,73,23,116,87,238,222,213,32,250,247,118,131,192,39,31,231,50,51,103,110,222,176,154,4,227,224,152,141,182,25,147,195,118,31,71,117,71,102,46,38,104,206,26,163,25,47,222,37,233,29,90,22,131,80,253,21,218,149,140,161,34,140,130,16,100,186,154,170,49,140,189,199,172,166,213,51,43,237,9,236,45,103,82,114,155,188,227,104,67,96,71,58,9,187,188,229,19,71,23,101,25,26,180,96,253,79,149,104,81,145,105,96,237,163,148,30,29,106,242,240,33,110,102,62,118,66,183,144,63,212,178,245,11,167,37,215,250,3,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDataSourceLoadRowsResponseRegisteredEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDataSourceLoadRowsResponseRegisteredEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("36e70033-537a-496f-8f93-bbf6d0c02d1f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceLoadRowsResponseRegisteredEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 2888),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(243, 129),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDataSourceLoadRowsResponseRegisteredEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadRowsResponseRegisteredStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7ad28e1a-9277-4eac-92a7-931ca8f0bd62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("36e70033-537a-496f-8f93-bbf6d0c02d1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceLoadRowsResponseRegisteredStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDataSourceLoadRowsResponseRegisteredScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1b81ff46-e66c-4c7d-9b3d-f1a346bfcaaa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("36e70033-537a-496f-8f93-bbf6d0c02d1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceLoadRowsResponseRegisteredScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,81,75,195,48,16,126,238,96,255,33,250,48,58,144,226,123,153,48,231,24,131,41,99,83,95,196,135,208,156,90,72,147,153,92,54,69,246,223,77,210,117,173,107,231,54,13,165,208,92,238,190,239,187,251,210,37,85,132,81,164,115,105,84,2,51,185,210,3,105,4,146,30,153,210,87,136,110,182,161,200,197,34,31,140,219,173,221,224,28,56,36,8,108,140,144,77,85,154,81,245,57,144,220,100,226,145,114,3,54,143,3,85,97,215,102,46,45,32,77,48,93,58,176,135,49,179,72,35,147,178,104,152,45,240,115,19,135,37,8,236,171,87,109,131,97,34,5,194,7,70,247,111,74,174,134,219,8,213,164,196,223,110,59,132,244,133,132,101,133,179,30,17,134,115,210,233,148,101,163,25,188,91,86,24,245,185,2,202,44,85,129,52,21,218,73,236,146,175,118,43,168,235,195,1,79,93,122,65,61,220,61,178,141,212,245,95,16,84,6,28,55,98,215,169,189,235,51,118,10,88,1,227,218,112,54,214,55,96,165,241,145,74,153,87,70,234,171,192,191,147,12,234,229,26,156,240,11,120,220,136,48,73,53,130,0,85,142,48,44,182,92,237,169,146,9,104,109,205,112,65,206,29,211,137,164,204,205,226,188,219,92,207,19,160,8,215,6,81,10,29,86,187,187,110,183,214,4,184,6,63,71,215,132,38,123,95,145,203,124,208,129,247,155,21,121,146,205,98,151,233,125,246,195,95,238,142,20,27,155,242,193,142,215,253,153,168,177,113,65,80,33,94,75,108,186,142,79,151,207,123,75,185,215,17,46,174,162,148,54,109,74,61,108,82,79,219,175,19,237,250,67,248,223,73,175,55,3,175,187,62,8,14,154,188,90,211,119,224,95,166,245,92,118,109,186,207,136,241,81,70,173,240,216,120,213,2,207,65,176,97,102,165,222,130,48,249,108,96,65,21,184,207,156,200,254,188,123,200,22,220,210,251,61,223,9,41,135,227,255,227,197,89,157,255,150,106,28,114,220,125,71,27,97,11,40,251,40,64,163,132,159,106,252,13,111,92,29,3,158,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDataSourceLoadingSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDataSourceLoadingSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("41f89ff0-b697-4f13-bae1-731e35e4f08f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceLoadingSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 2887),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(229, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDataSourceLoadingSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a5f48926-d190-43ec-99de-2bd2b535244c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("41f89ff0-b697-4f13-bae1-731e35e4f08f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoading",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceLoading",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDataSourceLoadingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ec055e27-e9ca-4a7c-8c26-40a333efd389"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("41f89ff0-b697-4f13-bae1-731e35e4f08f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"DataSourceLoadingScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBasePrepareFiltersDataSourceSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBasePrepareFiltersDataSourceSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ac17d3ca-be40-4368-9021-6c85360dee7c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"BasePrepareFiltersDataSourceSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 3037),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(360, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBasePrepareFiltersDataSourceSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageBasePrepareFiltersStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7b4693af-a1c6-4ed0-9d9d-82808be59f78"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac17d3ca-be40-4368-9021-6c85360dee7c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartMessageBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSendMessageBasePrepareFilterScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4ccab20f-51ac-4182-b720-273dabfdf3a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac17d3ca-be40-4368-9021-6c85360dee7c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTaskSendMessageBasePrepareFilter",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,44,118,73,45,73,204,204,113,47,202,76,209,84,168,230,226,244,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,128,9,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,57,37,22,3,5,82,11,18,139,82,221,50,115,74,82,139,138,149,52,173,185,106,185,138,82,75,74,139,242,20,74,138,74,83,173,1,248,74,216,63,102,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptCreateDemoFiltersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2aa1b071-fb4e-41cb-94be-e1219c3661bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac17d3ca-be40-4368-9021-6c85360dee7c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptCreateDemoFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,83,203,110,156,48,20,93,151,175,112,88,129,132,145,121,131,70,93,196,6,162,145,170,36,234,52,234,162,234,194,2,55,177,196,152,169,49,83,141,170,252,123,237,146,25,152,73,164,116,215,29,190,247,156,115,207,125,176,167,18,140,3,147,235,22,124,4,15,250,131,244,66,176,70,241,94,248,100,148,146,9,101,162,254,186,93,89,123,141,109,122,161,104,163,222,131,147,35,108,98,181,108,219,155,248,160,89,130,253,2,55,35,111,191,125,7,191,173,15,199,151,99,7,56,198,69,20,38,48,77,9,129,101,29,4,176,192,225,53,68,40,40,83,84,21,81,78,82,219,245,150,148,42,40,112,84,165,57,172,163,20,195,32,14,16,44,210,34,130,33,34,117,132,114,66,42,18,93,80,210,56,209,137,40,129,152,196,24,86,72,87,201,211,32,51,85,146,164,68,113,20,162,216,118,173,231,149,197,127,0,231,234,100,124,234,136,139,193,153,166,229,186,198,189,100,106,148,2,40,57,178,149,245,60,181,74,21,221,244,163,108,152,238,245,158,62,50,191,60,69,166,97,12,26,222,104,158,1,204,232,227,248,54,199,236,60,185,154,119,74,91,184,165,91,67,177,203,57,100,191,2,157,107,214,92,180,47,137,27,217,143,59,124,48,34,206,133,168,59,53,187,84,185,210,123,26,187,238,111,147,39,191,254,75,214,255,172,145,251,51,25,215,180,127,110,99,166,17,201,168,98,75,31,151,14,60,240,169,127,228,13,237,238,118,76,82,115,77,122,12,188,81,254,157,212,202,11,176,127,221,182,206,219,202,95,185,122,186,167,82,171,25,160,179,152,194,166,121,98,91,234,129,9,71,250,237,142,74,62,244,226,203,97,199,252,234,231,72,59,15,216,147,84,139,15,182,55,31,185,251,63,170,207,199,26,134,36,73,98,164,255,134,2,7,48,46,170,26,230,21,206,96,22,198,250,242,179,188,74,50,98,187,255,98,114,61,220,234,117,78,136,183,204,45,12,24,185,215,43,55,162,231,251,94,222,254,31,22,41,127,220,70,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInitializeFilterEditEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInitializeFilterEdit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f3f2330a-9474-4e7b-89a3-d02402705ac9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcessInitializeFilterEdit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 3216),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInitializeFilterEdit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitializeFilterEditStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("33586ad9-acff-4f9a-bf93-9fc1badc7f51"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3f2330a-9474-4e7b-89a3-d02402705ac9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InitializeFilterEdit",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartMessageInitializeFilterEdit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitializeFilterEditScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f424ffe2-d9bc-4616-aeec-0f95f43697a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3f2330a-9474-4e7b-89a3-d02402705ac9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptInitializeFilterEdit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,61,10,194,64,16,70,235,236,41,134,84,73,179,23,8,41,252,139,157,8,57,193,144,157,200,194,186,145,201,140,32,226,221,93,183,16,73,10,251,247,190,247,221,145,97,244,65,136,15,206,203,145,39,189,65,11,103,188,144,221,163,96,63,41,15,100,59,31,93,151,169,57,35,219,199,9,175,84,149,221,215,44,235,198,248,17,170,213,86,11,81,67,168,225,105,138,255,157,29,19,10,253,150,150,141,98,165,40,51,69,233,133,117,16,229,207,215,108,219,141,115,203,55,201,127,25,166,132,69,72,60,53,111,83,172,177,58,254,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessClearDataEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessClearData = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a45d5f43-f507-4a3a-9209-a20abdef75e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcessClearData",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 3212),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessClearData;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartClearDataStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3e0f58db-73af-4caa-be84-33461262856e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a45d5f43-f507-4a3a-9209-a20abdef75e8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ClearData",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartClearData",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptClearDataScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("004a8d7f-690c-41c8-a865-b93a5b9f079b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a45d5f43-f507-4a3a-9209-a20abdef75e8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptClearData",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,73,77,44,114,73,44,73,212,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,99,255,199,28,25,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessSelectFolderEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessSelectFolder = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("502c9fdd-af56-4f10-9af3-0910221be3de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SubProcessSelectFolder",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 3398),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(213, 133),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessSelectFolder;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSelectFolderStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("23df5659-911c-46f6-95a6-bfa49c63b31f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("502c9fdd-af56-4f10-9af3-0910221be3de"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SelectFolder",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SelectFolder",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSelectFolderScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a1ffa055-37e7-4112-bda5-d5ef3b5b6483"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("502c9fdd-af56-4f10-9af3-0910221be3de"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptSelectFolder",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,44,118,73,45,73,204,204,113,47,202,76,209,84,168,230,229,226,244,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,128,9,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,5,167,230,164,38,151,184,229,231,164,164,22,41,105,90,243,114,213,242,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,165,188,186,4,99,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2e323a9f-3bee-4e41-a29d-3ec3efc519c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SubProcess1",
				Position = new Point(253, 3398),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateApplySearchFilterStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("315a487f-aad5-4645-8648-0fe6ab36af7d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e323a9f-3bee-4e41-a29d-3ec3efc519c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ApplySearchFilter",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ApplySearchFilter",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptApplySearchFilterScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fe08a71a-6dd8-4978-97aa-fd85e00a7e1b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e323a9f-3bee-4e41-a29d-3ec3efc519c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptApplySearchFilter",
				Position = new Point(112, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,209,78,194,48,20,125,238,190,98,242,180,5,211,248,62,125,32,128,102,137,26,3,24,30,140,15,101,187,195,233,214,198,219,22,99,12,255,238,45,69,198,134,64,178,164,77,239,57,189,231,156,219,173,4,134,185,48,98,170,44,102,16,222,132,79,98,9,124,180,59,73,130,85,11,113,91,86,6,144,112,209,12,16,133,86,133,225,207,41,159,195,98,168,164,65,85,105,190,219,164,163,14,45,53,80,199,97,247,212,183,200,44,34,72,51,53,104,51,99,209,73,105,186,242,97,167,154,4,101,17,93,168,197,59,100,134,79,160,0,170,102,48,254,180,162,210,81,183,193,101,40,109,85,197,113,248,195,2,86,40,140,74,105,194,146,26,92,37,180,92,31,180,230,158,230,156,88,105,8,211,239,19,55,96,204,245,60,6,126,41,95,249,163,168,129,111,69,244,166,32,48,123,243,213,94,236,47,96,167,216,169,30,75,177,168,32,39,101,5,93,65,38,25,91,135,64,187,179,228,86,90,127,177,18,59,112,223,41,217,155,105,137,82,234,168,203,223,74,62,74,28,228,249,33,39,217,52,76,181,55,79,170,136,70,62,26,23,20,63,8,170,68,110,230,133,127,76,165,60,58,130,38,119,143,61,19,49,115,49,109,145,251,113,122,21,237,52,255,129,237,82,223,119,208,140,194,121,91,7,155,31,100,134,0,119,88,230,124,88,17,46,34,223,123,143,245,94,137,124,162,190,180,59,110,163,31,4,126,76,109,93,11,252,30,232,57,42,185,116,24,4,178,44,189,200,95,255,56,37,71,144,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessRunModuleProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessRunModuleProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6f8f7a53-e50b-45a0-a104-4989af26d799"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcessRunModuleProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 3559),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessRunModuleProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartRunModuleProcessStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d312a685-3ec7-4c42-8325-bd38aef1e095"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f8f7a53-e50b-45a0-a104-4989af26d799"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RunModuleProcess",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartRunModuleProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(57, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptRunModuleProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f3c4b42c-8043-4eff-a84f-9531dbfcf50d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f8f7a53-e50b-45a0-a104-4989af26d799"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptRunModuleProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(168, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,77,83,34,49,16,61,107,149,255,33,59,167,25,165,2,122,197,181,10,65,183,168,93,45,74,96,61,80,30,226,76,3,179,14,9,155,100,64,106,203,255,190,157,100,62,1,119,81,15,130,61,221,239,189,238,126,147,184,98,146,192,171,150,108,192,36,91,40,242,149,132,130,107,140,208,209,92,138,245,205,10,184,238,200,153,34,76,145,94,28,234,88,112,38,55,151,74,203,152,207,26,68,60,255,130,80,95,181,79,142,87,8,180,148,34,4,165,190,195,6,113,56,172,201,183,52,142,252,10,252,196,211,108,230,61,209,145,24,90,0,63,8,178,210,5,227,108,6,18,235,6,248,73,199,10,100,87,112,14,150,145,14,28,240,48,156,195,130,221,185,212,172,80,217,24,214,17,191,150,21,100,136,244,54,230,81,159,43,205,120,8,215,155,113,63,242,75,153,134,61,158,18,63,7,65,213,105,146,4,228,207,209,201,241,209,29,230,32,194,35,214,139,181,17,52,98,234,133,102,209,17,118,133,164,110,14,244,86,200,5,211,254,157,136,210,4,50,25,57,231,189,208,55,175,177,210,89,97,131,212,233,223,161,49,83,200,134,97,146,236,80,202,141,248,222,112,46,214,89,165,103,97,36,232,84,114,162,101,106,10,222,178,169,86,5,25,185,182,79,218,149,192,116,30,246,235,179,54,96,213,161,80,187,57,208,32,21,181,125,168,235,205,61,6,124,207,104,202,155,236,71,94,128,99,67,29,110,34,36,46,30,32,173,239,143,64,74,166,196,84,211,113,159,62,194,51,242,105,41,18,101,251,12,108,119,29,181,180,127,208,18,179,226,147,118,9,189,172,241,34,124,133,235,204,217,199,252,50,20,44,230,232,128,49,143,127,167,208,239,25,140,218,68,232,16,52,126,93,130,212,155,159,44,73,119,155,106,108,177,5,110,182,135,13,168,131,3,93,193,72,2,124,147,113,212,77,98,220,92,57,168,255,41,121,167,186,225,58,204,227,52,123,208,43,148,153,189,71,76,179,161,72,101,152,123,136,246,138,72,102,249,74,202,151,194,246,40,235,19,141,165,82,162,132,7,177,46,155,251,104,119,85,136,70,69,62,117,121,248,96,32,227,5,158,60,93,145,164,11,110,65,172,39,222,12,217,129,178,115,182,33,36,232,117,136,16,85,245,35,85,104,54,147,139,35,133,20,137,123,23,112,120,21,41,121,89,95,195,98,87,141,106,231,16,170,2,223,21,41,55,231,68,13,150,218,104,145,143,231,193,210,66,84,14,205,201,14,200,147,205,159,10,233,91,153,152,219,106,227,199,229,46,29,134,207,206,2,98,210,143,10,236,73,252,180,45,3,67,237,67,86,245,222,216,26,165,242,124,21,214,128,205,102,15,51,53,144,231,68,132,47,228,162,69,207,207,233,69,235,252,2,37,53,79,63,238,175,156,247,94,68,160,10,139,109,221,16,67,212,142,159,198,230,19,239,142,45,93,81,94,98,122,55,22,55,50,171,43,178,207,243,87,164,120,165,106,132,237,220,92,213,160,219,32,185,34,173,138,117,150,206,19,15,16,10,25,57,79,100,27,253,129,205,93,154,181,94,185,131,204,172,17,88,56,39,118,151,28,17,241,12,171,139,66,92,130,63,118,137,251,193,13,54,102,82,199,52,241,76,155,91,7,166,217,255,142,38,218,137,34,191,184,156,119,19,130,172,180,217,252,68,113,245,102,119,56,246,5,253,240,178,246,80,31,228,213,127,59,167,177,15,183,240,238,105,211,184,247,228,24,111,241,120,186,169,221,229,165,83,253,154,2,83,91,151,116,243,10,97,170,193,223,243,95,140,73,174,222,210,127,1,41,205,236,3,123,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessProcessPropsWindowClosedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessProcessPropsWindowClosed = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9bafe48c-f085-4759-bc0a-319683fb1403"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcessProcessPropsWindowClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 3734),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(265, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessProcessPropsWindowClosed;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartProcessPropsWindowClosedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ef2e34f4-06ea-4a5a-b8a1-d3e1adaac355"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9bafe48c-f085-4759-bc0a-319683fb1403"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProcessPropsWindowClosed",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartProcessPropsWindowClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptProcessPropsWindowClosedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6fbfe17e-cb63-40c2-b7fb-5306622417ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9bafe48c-f085-4759-bc0a-319683fb1403"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptProcessPropsWindowClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,201,9,40,202,79,78,45,46,246,77,205,43,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,253,174,150,3,32,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1OpenProcessEditEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1OpenProcessEdit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("61495bba-c122-4612-86f0-80226240a164"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess1OpenProcessEdit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(385, 3564),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(385, 179),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1OpenProcessEdit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartCreateNewProcessMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c0af7230-5cf6-4022-baa8-712bb01b3a3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61495bba-c122-4612-86f0-80226240a164"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CreateNewProcessMenuItemClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartCreateNewProcessMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptCreateNewProcessMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0e4bbcee-b4be-46e7-a5d6-69a21046ab45"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61495bba-c122-4612-86f0-80226240a164"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptCreateNewProcessMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,80,75,107,194,64,16,62,55,224,127,8,123,82,72,2,218,168,145,62,32,85,41,57,248,0,35,61,175,238,24,182,77,119,101,118,99,42,226,127,119,242,40,244,82,79,243,224,123,205,172,142,160,214,168,247,96,204,92,72,187,53,128,41,55,95,193,154,103,176,77,132,251,226,42,40,221,247,66,138,46,11,163,221,33,26,15,134,254,104,36,6,126,8,81,232,239,250,187,129,207,199,125,17,13,195,195,112,50,121,100,189,167,142,179,250,71,180,218,3,38,202,88,174,246,80,171,255,14,228,117,135,72,205,180,64,4,101,227,189,149,39,168,210,17,217,98,1,119,88,211,92,27,88,208,182,65,179,22,67,229,104,62,164,18,186,172,17,130,221,209,168,156,214,28,249,55,88,64,211,190,99,38,41,133,86,28,207,207,198,162,84,153,231,54,245,213,189,116,156,135,11,51,50,83,60,95,18,139,121,46,91,66,185,208,162,200,161,53,136,133,32,211,171,87,67,249,39,255,153,159,232,178,148,99,6,118,170,149,69,157,19,173,114,14,226,218,232,173,176,86,43,186,71,18,46,153,181,204,205,217,52,178,137,32,248,159,41,72,245,166,142,211,237,93,59,206,149,174,67,176,5,170,230,95,55,39,90,31,44,242,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenProcessEditUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("fb58079e-80f9-425b-88b3-538783fd1037"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61495bba-c122-4612-86f0-80226240a164"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"OpenProcessEditUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 63),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenProcessEditUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessShowMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessShowMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("037e96df-6979-4d86-82bd-1d83354beec6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcessShowMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 3909),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessShowMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartShowMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9ae77a58-9bb7-4057-8353-9a5b97a9f458"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("037e96df-6979-4d86-82bd-1d83354beec6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ShowMessage",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartShowMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateMessageWindowUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("864ceb92-b74b-442f-a4ec-9bbd85abd9b4"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("037e96df-6979-4d86-82bd-1d83354beec6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"MessageWindowUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 44),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeMessageWindowUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1TuningModeChangedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1TuningModeChanged = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d3923fb6-891f-427e-86e2-caf424809011"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"EventSubProcess1TuningModeChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 3915),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1TuningModeChanged;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartTuningModeChangedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("51300206-0e8d-4bad-a8a6-0add8f578efa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d3923fb6-891f-427e-86e2-caf424809011"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TuningModeChanged",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartTuningModeChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTuningModeChangedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b24742a5-228b-4d91-9b22-3032bae867bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d3923fb6-891f-427e-86e2-caf424809011"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTuningModeChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(154, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,201,9,40,202,79,78,45,46,246,77,205,43,213,208,180,230,229,114,3,139,101,230,149,192,69,138,82,75,74,139,242,20,74,138,74,83,173,1,179,33,1,220,50,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCreateNewSysModuleReportMenuItemClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCreateNewSysModuleReportMenuItemClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("671b33af-7ba4-4958-9b51-7b792893f2d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CreateNewSysModuleReportMenuItemClickEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 3747),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(375, 160),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCreateNewSysModuleReportMenuItemClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageCreateNewSysModuleReportMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c060ab60-5e2b-464a-9011-2b5d867784d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("671b33af-7ba4-4958-9b51-7b792893f2d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CreateNewSysModuleReportMenuItemClick",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"StartMessageCreateNewSysModuleReportMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 61),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskCreateNewSysModuleReportMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0c070f3d-a8e7-475a-a74b-1dc9350b3ced"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("671b33af-7ba4-4958-9b51-7b792893f2d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"ScriptTaskCreateNewSysModuleReportMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,81,75,107,194,64,16,62,87,240,63,132,156,20,76,16,95,32,125,128,141,82,114,208,134,70,233,121,146,29,211,173,113,87,102,39,90,17,255,123,215,196,150,214,91,78,187,195,126,175,249,54,32,4,198,5,30,226,163,153,107,81,228,248,134,59,77,60,71,85,132,140,219,32,151,233,102,101,144,150,96,54,126,4,25,174,66,225,60,58,10,15,206,75,33,69,203,237,245,215,35,72,210,196,195,117,119,228,13,112,44,188,164,59,18,94,58,236,15,176,139,195,4,122,99,183,125,223,108,4,181,172,94,119,168,144,66,101,24,84,138,165,231,207,96,19,212,150,179,151,160,32,66,197,147,148,229,30,47,155,88,73,166,2,107,107,5,185,54,56,71,99,42,13,247,134,20,145,222,153,119,169,132,62,148,72,225,214,118,184,164,139,128,96,139,140,100,174,117,79,165,77,174,21,208,241,193,48,73,149,117,156,234,124,114,78,205,198,221,201,53,50,83,144,47,44,203,237,56,174,245,170,140,110,28,39,66,216,72,231,78,73,129,79,248,154,237,109,43,75,160,12,57,208,138,73,231,150,126,73,224,71,86,157,159,11,102,173,236,210,210,194,194,233,149,248,43,26,10,139,254,51,249,75,29,151,169,90,237,43,212,46,98,153,51,197,146,143,113,250,129,91,40,57,165,195,20,24,98,93,80,138,126,245,180,250,175,208,108,156,109,121,132,92,144,170,62,235,27,246,134,157,100,177,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateCreateNewSysModuleReportMenuItemClickUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e5f43128-3eb8-4aad-a5b5-9b88dcf9ecaf"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("671b33af-7ba4-4958-9b51-7b792893f2d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"CreateNewSysModuleReportMenuItemClickUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 47),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeCreateNewSysModuleReportMenuItemClickUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysModuleReportPropsWindowClosedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysModuleReportPropsWindowClosedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1f4332c9-2f5b-4061-8b32-b32581c8c0e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SysModuleReportPropsWindowClosedEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 4073),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysModuleReportPropsWindowClosedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysModuleReportPropsWindowClosedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8459b111-da6c-45e5-b401-b9c10bc2e455"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f4332c9-2f5b-4061-8b32-b32581c8c0e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysModuleReportPropsWindowClosed",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SysModuleReportPropsWindowClosedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 61),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysModuleReportPropsWindowClosedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2deb0bd9-c079-4644-80b7-c8e3dae82748"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f4332c9-2f5b-4061-8b32-b32581c8c0e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SysModuleReportPropsWindowClosedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,201,9,40,202,204,43,241,77,205,43,213,208,180,230,229,226,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,48,186,83,35,32,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSetDetailPrintButtonMenuEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSetDetailPrintButtonMenuEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f26bbf13-4145-4815-b978-099ab33ab2ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1060a07d-bbeb-434e-9db5-71e9319f4ab3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SetDetailPrintButtonMenuEventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(379, 4083),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSetDetailPrintButtonMenuEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSetDetailPrintButtonMenuStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f27631e2-2c27-438c-a760-4c991b7a0cf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f26bbf13-4145-4815-b978-099ab33ab2ab"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SetDetailPrintButtonMenu",
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SetDetailPrintButtonMenuStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetDetailPrintButtonMenuScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("edcc4a52-ebff-45e0-b28e-a6c05c3cb655"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f26bbf13-4145-4815-b978-099ab33ab2ab"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Name = @"SetDetailPrintButtonMenuScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,118,73,45,73,204,204,113,47,202,76,209,84,168,230,229,226,116,203,204,201,9,40,202,204,43,241,77,205,43,213,208,180,6,10,101,2,21,6,36,166,167,234,129,197,157,74,75,74,242,243,244,64,210,122,206,249,165,121,37,10,118,10,6,16,189,156,24,170,60,50,83,82,82,243,20,108,21,210,18,115,138,83,65,134,213,242,114,1,17,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,240,132,15,77,138,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetDefValuesMethod());
			Methods.Add(CreateGetButtonsMethod());
			Methods.Add(CreateCallRefreshDetailsMethod());
			Methods.Add(CreateSetAdditionalDataSourcePropertiesMethod());
			Methods.Add(CreatePrepareOpenEditPageParametersMethod());
			Methods.Add(CreatePrepareOpenModuleEditPageParametersMethod());
			Methods.Add(CreateGetSysModuleIdMethod());
			Methods.Add(CreateGetSelectedRowsMethod());
			Methods.Add(CreatePrepareCopyOpenWindowMethod());
			Methods.Add(CreateGetDefValuesMethod());
			Methods.Add(CreateListenerThrowEventMethod());
			Methods.Add(CreateCustomDeleteMethod());
			Methods.Add(CreateListenerProcessSetPropertyMethod());
			Methods.Add(CreateGetListenerProcessPropertyValueMethod());
			Methods.Add(CreateClearDataMethod());
			Methods.Add(CreateGetSerializedFiltersMethod());
			Methods.Add(CreateGetEditPagesMethod());
			Methods.Add(CreateCreateAddButtonMenuItemMethod());
			Methods.Add(CreateActivateButtonsMethod());
			Methods.Add(CreateInitializeContextHelpButtonMethod());
			Methods.Add(CreateGetIsContextHelpButtonHiddenMethod());
			Methods.Add(CreateGetIsContextHelpEnabledMethod());
			Methods.Add(CreateGetRegisterQuestionScriptMethod());
			Methods.Add(CreateGetRegisterEditPageScriptMethod());
			Methods.Add(CreateGetRegisterCopyPageScriptMethod());
			Methods.Add(CreateGetRegisterAddPageScriptMethod());
			Methods.Add(CreateModifyAddPageParametersMethod());
			Methods.Add(CreateModifyEditPageParametersMethod());
			Methods.Add(CreateModifyCopyPageParametersMethod());
			Methods.Add(CreateLoadViewFiltersMethod());
			Methods.Add(CreateGetAddScriptForDetailMethod());
			Methods.Add(CreateGetRegisterOpenWindowScriptMethod());
			Methods.Add(CreateEmailContextMenuItemMethod());
			Methods.Add(CreateContextMenuSeparatorMethod());
			Methods.Add(CreateGetSchemaTagMethod());
			Methods.Add(CreateGetSchemasColumnListMethod());
			Methods.Add(CreateGetTemplateTagMethod());
			Methods.Add(CreateReadIdFromTagMethod());
			Methods.Add(CreateGetTemplatePairsListMethod());
			Methods.Add(CreateCreateContextMenuMethod());
			Methods.Add(CreateIsLoggingEnabledMethod());
			Methods.Add(CreateGetModuleProcessesInfoMethod());
			Methods.Add(CreateFillProcessMenuMethod());
			Methods.Add(CreateCallContextMenuItemMethod());
			Methods.Add(CreateGetContactPhoneNumbersMethod());
			Methods.Add(CreateGetAccountPhoneNumbersMethod());
			Methods.Add(CreateGetRegisterTreeGridDblClickScriptMethod());
			Methods.Add(CreateModifyModuleProcessParametersMethod());
			Methods.Add(CreateFillPrintMenuMethod());
			Methods.Add(CreateCreateMenuItemMethod());
			Methods.Add(CreateOpenReportPageMethod());
			Methods.Add(CreateGetContextMenuItemMethod());
			Methods.Add(CreateClearMenuItemsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateSetDefValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f759a3c9-0dea-41a1-a7f2-630178b80967"),
				Name = "SetDefValues",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,91,79,219,48,20,126,78,126,133,151,167,68,170,44,158,23,96,130,22,80,53,209,117,42,108,15,136,7,47,113,169,167,52,97,182,195,20,77,252,247,29,95,218,58,177,131,42,164,105,72,200,245,241,185,126,231,150,23,194,17,173,37,147,221,170,216,208,45,185,37,53,121,162,28,157,161,37,156,216,16,113,239,109,201,155,23,86,82,142,111,168,180,164,52,185,242,117,36,25,34,2,197,209,29,229,156,136,102,45,241,180,225,20,107,78,70,5,14,136,228,177,144,156,213,79,168,164,146,176,202,188,45,200,150,130,63,247,130,222,54,101,91,209,153,126,19,232,19,74,86,157,112,105,75,194,33,150,11,33,138,4,125,116,94,175,74,38,61,142,60,62,198,49,180,117,244,91,210,89,8,49,133,198,188,22,146,212,5,189,236,148,207,233,48,136,44,143,95,0,110,67,86,62,252,227,248,14,198,220,136,190,182,148,119,96,175,166,191,145,71,79,3,145,77,130,30,219,96,158,181,193,105,83,181,219,250,22,216,150,68,110,204,13,76,140,24,199,23,101,105,120,210,100,25,144,79,172,238,226,221,90,125,125,189,186,154,91,198,227,145,31,195,27,80,30,115,231,154,85,146,114,161,220,74,199,120,166,156,18,73,13,231,119,38,55,128,6,184,164,196,82,67,156,54,91,64,152,137,166,190,235,158,161,68,127,181,164,154,64,79,249,113,76,208,192,229,121,153,101,255,201,59,133,212,190,18,155,130,17,201,44,203,180,41,105,50,65,201,140,174,191,145,170,165,73,182,111,10,67,16,182,50,103,172,80,66,4,74,245,212,228,110,130,154,31,63,105,33,207,211,161,8,128,80,81,205,254,70,117,64,123,26,226,129,59,133,196,67,12,117,109,174,160,150,173,81,26,80,11,110,183,181,68,231,232,36,67,127,226,200,214,82,191,60,193,180,161,227,171,237,179,236,242,61,91,168,67,124,230,67,47,29,63,100,238,231,101,10,72,187,177,66,210,243,227,38,174,25,3,244,232,193,224,58,151,229,104,244,207,132,66,7,80,155,240,253,228,238,115,107,78,157,219,104,13,78,147,98,147,186,73,70,172,14,37,92,231,35,242,50,177,227,84,120,169,186,179,125,162,105,167,59,83,161,241,130,237,104,139,34,85,10,31,108,146,230,98,209,86,213,23,174,147,53,144,203,140,11,154,95,175,204,25,145,100,213,180,188,216,111,207,107,86,151,230,167,49,114,217,41,193,161,30,116,6,224,128,25,171,207,15,106,68,59,132,232,42,87,204,151,221,78,108,104,68,69,22,189,198,230,127,164,50,143,2,111,124,238,31,32,12,52,128,53,17,146,126,27,244,161,18,23,118,183,52,199,192,246,228,135,112,143,122,121,20,204,161,128,250,96,123,29,101,247,153,43,57,104,250,225,90,243,98,80,6,70,58,77,15,246,126,242,39,61,91,251,52,189,198,170,109,125,187,238,134,240,95,223,187,27,148,173,168,7,236,146,179,45,217,193,129,237,42,163,42,26,90,46,96,93,244,222,117,17,170,157,17,13,135,185,55,114,0,204,80,88,161,61,160,59,203,91,6,187,57,132,210,195,199,136,26,67,35,136,155,66,58,176,106,87,237,23,70,208,13,115,77,51,188,75,25,208,236,151,163,209,128,77,180,120,218,215,167,178,190,31,133,78,158,241,103,218,77,60,239,30,78,30,149,98,71,71,58,240,47,51,85,240,170,151,42,140,231,155,150,149,224,179,58,240,194,92,213,88,238,227,131,87,84,8,56,213,60,122,176,66,248,174,89,233,222,77,179,71,103,142,136,60,230,84,182,188,222,41,207,227,191,148,161,40,79,118,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e17a2fbb-f49e-42d5-8b0c-b59063e44e21"),
				Name = "GetButtons",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "System.Collections.Generic.List<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,200,75,45,87,8,174,44,46,73,205,213,115,206,207,201,73,77,46,201,4,74,232,185,167,230,165,22,101,38,235,249,100,22,151,216,20,151,20,101,230,165,219,105,104,90,115,65,53,234,57,166,164,104,4,36,166,167,130,24,78,96,49,61,191,196,220,84,108,42,92,83,50,75,8,40,113,206,47,168,36,160,196,37,53,39,181,36,149,128,162,0,160,59,209,236,42,74,45,41,45,202,131,121,216,26,0,38,128,88,91,253,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCallRefreshDetailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0efa4ffe-5c57-4066-ba65-38e06e5ddb71"),
				Name = "CallRefreshDetails",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8926b357-db2d-4fab-a187-bc8beb885d3b"),
				Name = "listenerPage",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.UI.WebControls.PageSchemaUserControl",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,44,118,73,45,73,204,204,113,47,202,76,209,84,168,230,226,244,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,128,9,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,129,52,57,38,151,100,150,165,6,229,151,59,103,36,230,165,167,166,40,105,90,115,213,2,0,63,16,81,235,91,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetAdditionalDataSourcePropertiesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f829a093-f281-4b20-852d-956f97e7492d"),
				Name = "SetAdditionalDataSourceProperties",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareOpenEditPageParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e0f4979d-c9fa-4589-acfe-5fabf0eff5c3"),
				Name = "PrepareOpenEditPageParameters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,203,142,218,48,20,93,39,95,97,178,24,37,18,202,7,52,125,104,10,148,70,130,14,18,76,187,182,226,11,99,53,56,212,118,152,70,136,127,239,181,157,76,66,18,218,69,179,193,248,62,206,245,57,71,87,105,201,197,129,72,200,10,201,82,70,62,144,101,201,89,188,56,158,116,21,239,138,173,13,135,81,226,47,132,230,186,218,102,47,112,164,207,54,113,67,15,16,207,169,166,219,162,148,25,196,111,177,196,63,83,73,78,24,118,87,107,42,240,44,239,150,196,55,105,27,89,156,57,3,25,47,65,215,87,97,176,233,55,11,34,135,2,140,235,54,136,16,3,88,211,39,21,74,83,145,193,231,10,199,11,23,117,13,158,35,66,21,105,235,19,255,89,129,220,81,245,243,145,177,167,19,136,31,92,176,226,53,54,71,144,77,23,251,250,230,143,125,239,120,21,222,206,74,41,65,232,199,76,243,51,24,28,172,212,178,132,123,37,245,88,152,213,25,178,225,83,210,35,104,144,10,163,196,39,246,19,240,74,230,28,187,23,130,202,234,189,178,114,77,137,251,253,72,46,117,154,251,46,65,35,115,48,125,83,188,35,242,117,218,75,135,91,205,177,170,231,130,191,21,107,9,176,148,220,161,89,225,119,245,77,60,203,57,182,78,231,88,227,121,222,37,216,86,106,93,176,50,7,243,104,155,223,187,233,226,212,48,215,196,231,123,18,78,82,53,7,77,121,110,26,147,135,135,182,18,89,156,116,221,28,33,27,94,75,98,140,196,135,65,39,187,139,122,131,136,78,187,58,172,85,145,81,13,44,21,141,56,6,112,226,200,142,83,245,173,204,243,39,105,193,194,21,87,218,120,198,100,161,163,51,80,202,216,205,14,97,212,204,135,113,148,213,152,98,86,8,1,86,209,56,173,35,11,113,224,2,140,145,235,11,231,227,59,24,137,231,32,142,148,139,219,16,34,140,224,214,125,79,32,117,245,157,230,37,132,193,122,80,26,68,134,77,129,47,36,159,254,163,73,135,86,242,174,182,169,147,39,241,61,203,241,40,155,195,167,56,38,7,122,14,19,81,214,145,106,195,209,213,179,186,134,115,216,219,137,149,115,140,125,163,209,181,115,143,227,184,65,162,81,23,177,54,19,225,186,117,3,23,133,91,200,81,93,96,95,138,28,151,92,15,178,31,140,23,191,74,154,171,176,227,226,209,1,246,117,190,241,112,191,197,152,145,71,73,110,76,253,21,242,19,154,80,195,111,221,240,220,199,123,233,166,152,181,48,90,106,224,238,175,185,77,119,159,181,0,247,54,227,12,55,6,72,96,255,88,160,179,188,80,224,214,245,147,88,21,212,228,239,145,66,72,254,0,189,47,45,140,234,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareOpenModuleEditPageParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c9f5198c-dc84-4d8b-88c9-48cec19ab95a"),
				Name = "PrepareOpenModuleEditPageParameters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,93,111,218,48,20,125,78,126,133,201,67,149,72,40,63,96,140,78,29,176,14,169,93,209,160,235,67,213,7,11,95,90,107,193,97,182,211,46,106,249,239,187,182,19,48,73,160,149,150,23,192,247,158,123,238,199,241,13,99,88,209,34,211,119,180,36,67,162,101,1,131,240,153,74,66,151,154,63,195,207,252,101,38,249,154,202,114,148,103,197,90,252,162,89,1,232,55,163,143,144,142,169,166,243,188,144,75,72,47,142,123,15,66,190,34,241,201,112,67,114,89,112,150,78,214,27,93,146,183,183,211,220,67,34,138,44,75,200,107,24,72,208,133,20,131,112,27,142,253,34,86,52,83,21,237,162,220,192,132,113,109,242,189,157,50,69,122,14,78,206,206,136,177,185,200,104,49,134,125,18,54,250,152,99,26,185,64,254,207,198,210,39,222,129,210,146,139,199,190,133,156,159,19,221,164,25,146,22,51,85,228,227,17,7,97,96,210,111,197,237,121,213,7,102,76,122,87,196,187,163,73,47,65,155,172,152,231,111,243,56,143,155,152,249,242,9,214,52,117,142,202,0,191,150,200,31,31,180,44,73,48,203,192,75,207,232,167,145,240,125,35,191,135,251,200,51,71,15,38,194,188,84,215,57,43,50,11,252,104,148,6,200,70,218,162,16,92,27,137,132,101,46,153,13,118,66,76,233,34,159,91,255,24,75,153,8,205,117,233,42,119,197,116,119,5,109,238,134,108,208,236,142,174,169,192,239,242,40,36,61,112,155,201,252,153,51,144,166,173,213,81,28,205,154,193,162,196,177,64,213,7,103,68,138,22,173,137,51,21,74,83,177,4,55,38,175,119,137,209,221,30,63,8,111,21,200,5,85,191,141,207,205,6,196,29,23,12,181,97,190,130,172,195,216,242,235,31,182,224,35,48,60,30,21,82,130,208,78,102,134,105,183,70,142,96,246,106,241,242,172,91,42,233,26,52,72,115,131,72,72,236,35,224,165,235,162,184,207,115,188,9,196,123,94,163,122,244,81,127,167,2,111,206,219,126,195,29,14,199,142,168,134,16,78,129,181,4,184,148,220,177,217,217,47,170,147,116,148,113,12,61,29,35,38,8,130,215,150,96,251,164,113,226,243,84,52,91,183,196,122,83,53,6,77,121,102,2,155,205,181,67,118,238,173,125,19,211,11,198,226,200,243,246,89,15,24,19,179,68,45,215,85,190,164,26,216,84,212,195,49,132,61,215,236,116,170,126,224,246,185,145,150,44,190,226,74,27,213,24,47,20,245,18,148,178,107,193,36,97,166,153,181,237,56,86,163,138,81,46,4,216,137,166,211,202,50,17,143,92,128,209,114,117,224,164,124,132,99,16,56,138,53,229,226,208,132,12,29,188,85,220,13,72,93,218,171,31,71,215,45,104,148,236,94,15,95,254,35,136,215,86,242,169,146,169,27,79,181,213,187,187,217,46,197,117,178,53,207,182,35,142,181,3,109,122,180,181,99,141,241,245,104,19,86,78,48,245,27,176,231,157,99,54,46,143,164,83,68,108,239,137,108,62,174,37,162,120,14,25,14,23,216,183,60,195,53,215,160,108,26,211,201,159,2,223,215,177,39,226,206,4,86,149,191,145,112,51,68,151,142,59,123,92,107,250,59,100,27,212,160,134,191,186,110,115,147,239,201,119,49,91,161,19,106,232,78,172,185,153,191,207,246,12,71,87,227,8,87,6,72,96,239,173,208,81,150,43,112,43,251,70,92,229,148,237,254,245,252,3,249,192,110,65,206,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysModuleIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("872c5564-efce-49a0-a6d3-0bf681deebaa"),
				Name = "GetSysModuleId",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,83,239,107,219,48,16,253,220,66,255,7,205,159,100,22,68,191,103,45,108,89,26,2,235,200,112,211,125,24,165,28,241,37,21,200,146,167,31,27,102,236,127,223,201,114,218,57,86,140,65,72,119,239,189,211,187,147,220,51,190,129,3,138,207,224,161,50,193,238,80,84,187,23,108,128,189,187,97,58,40,85,178,63,87,151,23,191,192,50,212,94,250,46,69,183,235,154,221,176,60,82,80,112,62,96,90,43,27,176,221,194,168,208,232,175,208,32,161,206,193,54,255,231,138,152,60,103,25,233,123,208,132,183,68,180,117,104,23,70,107,220,121,105,180,88,161,31,101,240,98,57,133,21,37,3,199,50,129,121,70,234,91,64,219,145,144,198,223,35,72,127,206,51,69,205,88,81,117,238,222,212,65,97,81,70,202,9,157,88,0,109,166,213,87,232,28,173,125,84,124,151,254,229,139,217,129,138,91,169,15,220,121,75,139,184,51,182,1,207,31,42,2,238,229,33,88,232,177,61,104,235,165,146,94,162,19,73,63,26,220,7,86,214,132,118,118,218,190,178,204,246,136,10,155,150,252,177,174,83,148,23,235,58,221,107,98,199,157,84,62,94,72,169,116,33,182,239,15,92,150,48,37,187,72,52,164,69,13,158,49,203,34,120,76,233,209,148,13,88,154,139,8,224,71,193,166,5,43,157,209,15,93,139,98,249,51,128,154,17,237,235,247,214,144,84,178,160,253,114,108,69,113,198,156,51,189,91,123,108,134,81,46,62,129,35,127,101,221,143,116,28,192,163,216,186,126,62,17,34,29,246,254,84,104,52,117,212,187,172,91,196,155,136,222,220,229,227,233,233,203,149,244,150,143,60,98,97,130,246,236,150,93,167,247,123,97,209,7,171,95,117,126,92,63,69,218,232,217,208,218,71,80,1,63,172,130,172,111,121,59,121,137,189,192,223,171,75,250,7,166,152,41,150,77,235,187,249,63,26,175,87,13,69,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSelectedRowsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("21b7cea8-39f3-4d19-a24b-cd1fd5e98c08"),
				Name = "GetSelectedRows",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,203,74,3,49,20,134,215,206,83,132,174,18,40,1,117,57,85,40,45,12,130,148,98,138,27,113,17,147,99,27,153,36,114,146,76,17,241,221,205,140,46,162,97,214,57,223,127,203,32,145,188,163,177,18,63,54,190,79,214,237,164,5,114,67,246,242,8,124,43,163,20,62,161,2,190,73,136,224,162,136,152,84,76,8,124,255,31,106,155,33,107,9,232,65,69,208,107,21,205,0,15,254,28,178,152,131,51,185,55,33,174,186,100,244,45,101,109,243,234,17,164,58,209,17,9,191,200,206,107,32,198,253,88,31,16,160,67,163,185,40,94,3,251,108,46,106,7,190,214,154,142,30,163,60,45,229,248,163,236,19,132,167,170,225,51,63,248,220,197,184,35,101,44,231,249,106,202,36,69,236,173,201,54,222,101,120,21,166,251,37,241,47,111,249,106,170,81,2,83,138,197,93,4,123,185,88,86,251,9,117,2,43,249,232,61,203,93,205,115,29,196,106,112,202,102,149,174,179,82,189,83,62,71,200,159,231,254,20,109,191,1,217,184,214,173,3,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareCopyOpenWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc5392f6-1b66-4745-8e76-0816fe71e066"),
				Name = "PrepareCopyOpenWindow",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,223,111,218,48,16,126,78,254,10,147,135,42,72,40,127,192,88,59,117,192,58,164,118,69,131,110,15,85,31,44,114,180,214,130,195,108,167,93,212,242,191,239,206,78,192,36,129,85,26,47,128,239,199,119,119,223,231,179,88,177,120,81,110,96,146,10,51,227,143,112,55,77,53,235,157,51,89,100,25,59,59,99,100,27,229,89,177,150,104,33,195,85,33,210,100,178,222,152,178,207,94,195,96,44,150,70,228,146,171,242,35,89,6,204,59,208,70,9,249,56,176,33,23,23,204,52,97,206,89,11,153,107,246,254,140,195,48,16,88,126,43,111,85,190,173,47,120,230,202,34,187,38,126,240,172,0,4,38,223,100,204,13,159,231,133,90,66,114,137,16,207,240,61,127,73,174,192,80,85,169,231,111,235,184,136,155,49,243,229,19,172,121,226,28,53,5,126,46,17,63,62,24,89,191,143,85,6,94,121,8,222,44,248,190,81,223,195,125,228,153,163,7,202,48,47,245,77,158,22,153,13,124,111,150,70,16,102,10,194,96,27,110,195,49,172,120,145,153,159,188,164,68,170,128,97,72,115,226,245,20,102,74,172,113,222,239,156,89,219,123,24,18,49,39,211,249,74,98,111,111,167,177,61,66,21,152,66,201,97,179,137,21,207,52,194,58,129,48,5,203,92,165,118,76,39,242,38,139,124,110,253,99,36,105,34,141,48,165,227,212,209,212,205,55,218,220,176,54,104,118,71,55,92,226,111,117,52,36,57,112,155,169,252,89,164,160,72,48,213,81,28,205,154,201,162,190,67,129,138,97,103,68,136,22,44,229,153,74,109,184,92,130,19,160,167,138,62,221,168,125,252,48,188,211,160,22,92,255,186,221,128,28,229,155,178,246,77,232,0,84,157,200,14,160,254,99,91,62,26,136,134,81,161,20,72,227,4,65,135,59,85,29,141,218,223,6,175,218,122,176,138,175,193,128,162,13,33,225,165,107,1,184,239,11,20,4,243,62,175,81,77,124,52,216,105,192,99,121,59,104,184,195,33,233,24,213,144,193,97,112,16,4,175,17,181,129,142,17,53,24,181,50,26,5,112,165,132,43,193,118,186,168,78,146,81,38,16,111,58,174,19,53,111,231,128,53,78,124,240,10,102,235,110,86,111,170,199,96,184,200,40,49,173,233,93,100,231,146,222,79,52,185,76,211,56,242,188,125,212,3,196,62,93,49,139,117,157,47,185,129,116,42,107,166,8,176,231,24,72,166,250,27,222,204,91,101,193,226,107,161,13,201,136,188,80,231,75,208,218,238,64,42,130,168,205,218,118,228,152,68,50,202,165,4,75,115,50,173,44,19,249,40,36,144,188,171,3,167,238,35,24,180,218,8,98,205,133,60,52,33,66,7,110,149,119,3,202,148,118,27,196,209,77,43,52,234,239,222,194,79,255,145,196,27,43,251,80,105,215,209,83,61,97,221,211,108,183,226,38,217,226,179,237,136,180,118,68,215,235,95,172,226,57,100,56,110,72,191,228,25,238,34,167,154,250,205,239,53,141,201,228,119,129,251,53,246,100,213,169,171,85,229,79,162,106,166,232,82,86,103,215,181,202,190,66,182,65,85,24,248,99,234,198,155,120,79,190,11,93,222,206,80,130,59,185,135,102,254,194,217,99,156,216,94,35,188,200,160,32,253,247,158,27,101,185,6,183,91,111,229,117,206,211,221,91,245,23,30,57,94,141,122,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ebdf6c92-0a62-46f9-a0be-4348351947c7"),
				Name = "GetDefValues",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,221,78,131,48,20,190,134,167,168,187,42,201,194,11,76,76,20,22,178,24,23,35,155,55,198,139,10,135,89,3,237,108,203,22,98,120,119,219,178,159,226,136,23,187,42,57,253,126,206,119,78,161,37,94,200,4,20,161,85,42,104,17,160,31,223,163,37,194,9,148,175,164,106,64,46,138,112,254,221,144,74,226,180,161,250,187,222,170,54,176,48,207,193,160,8,101,160,78,5,28,204,124,175,243,59,223,72,101,80,65,174,160,88,181,91,208,200,155,8,57,74,86,104,71,4,146,249,39,212,228,137,48,178,1,161,229,214,18,68,204,25,211,84,202,89,152,130,202,92,4,158,204,153,162,170,29,20,39,1,34,18,141,92,204,6,38,90,253,89,87,195,132,40,146,241,70,228,16,246,232,35,44,231,85,83,179,181,141,213,83,194,216,150,164,233,227,161,213,55,216,164,137,143,184,32,92,146,26,12,253,207,236,198,210,90,139,130,218,92,68,180,151,89,51,144,82,159,166,189,55,119,15,43,158,41,65,217,6,7,239,38,103,114,150,184,149,246,98,138,248,199,151,22,185,51,157,216,86,206,54,58,1,211,91,102,242,17,90,124,10,232,104,30,150,234,121,14,231,5,106,190,131,113,184,245,232,252,33,225,190,40,70,209,83,52,124,5,150,221,33,168,36,244,174,195,183,100,71,182,132,189,57,113,239,116,49,52,6,251,255,70,112,160,93,219,155,119,197,78,34,167,65,155,207,252,3,254,47,177,63,97,92,98,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateListenerThrowEventMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0354fcd5-76fb-4beb-95cd-0251da0818ae"),
				Name = "ListenerThrowEvent",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4506066b-0164-498a-a1b9-564ac7935c9e"),
				Name = "listenerPageProcessUId",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("48f06d05-6de4-49bb-a9e5-f96a36f34150"),
				Name = "eventName",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,65,14,130,48,16,69,215,246,20,117,7,137,233,5,8,27,13,38,221,32,11,57,64,3,35,54,41,83,50,29,80,98,184,187,85,97,233,246,255,153,247,190,189,201,36,48,89,236,148,14,229,232,220,133,138,126,224,57,113,54,48,32,80,101,58,168,200,55,16,66,173,219,52,149,47,177,35,224,145,48,19,139,152,12,201,225,215,202,92,214,1,232,228,17,161,97,235,81,233,245,175,192,206,34,168,179,197,118,77,142,115,100,253,83,100,194,198,81,27,117,159,75,140,179,190,222,53,83,215,59,249,71,49,1,242,118,166,52,50,16,26,23,245,12,79,62,72,248,212,165,233,33,242,150,55,107,208,165,107,230,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCustomDeleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5e218ebe-bee0-437e-a9b4-987be10d3c3b"),
				Name = "CustomDelete",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,206,177,10,131,48,16,6,224,185,62,69,200,44,125,1,219,14,69,7,135,106,171,102,112,20,251,35,129,146,148,92,74,43,226,187,55,193,64,181,203,253,28,223,127,112,130,96,46,32,234,6,236,175,110,176,35,243,145,68,98,5,33,27,124,172,243,20,15,88,84,232,181,185,7,217,214,243,94,43,215,227,55,145,213,77,94,22,124,203,231,151,181,90,145,111,180,89,93,148,127,92,129,158,142,17,118,223,83,120,179,84,246,86,106,213,153,241,64,214,72,53,196,108,201,19,155,162,221,196,71,16,143,25,95,158,107,65,225,156,207,177,87,165,127,88,232,149,205,201,23,17,171,47,235,2,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateListenerProcessSetPropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9b4f3266-22bd-434f-a68d-a4a8d9d090e4"),
				Name = "ListenerProcessSetProperty",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6c2fa11d-a25f-447a-bb8b-43814b65a2d6"),
				Name = "processId",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ea212236-ad29-4c61-b1ce-0142ecd681fc"),
				Name = "propertyName",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a2f19661-0e73-4339-83ab-a6b073957431"),
				Name = "propertyValue",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,140,193,10,194,48,16,68,207,230,43,246,216,128,228,7,130,23,165,72,46,173,32,245,30,218,181,4,210,77,216,36,66,17,255,93,172,57,244,54,51,239,49,238,9,77,202,236,104,86,38,117,197,251,158,219,37,230,181,137,28,70,76,201,76,82,194,91,28,24,115,97,210,226,35,94,150,161,66,56,193,144,144,47,129,8,199,236,2,41,115,251,147,150,102,71,168,174,152,235,112,94,7,51,237,78,181,168,89,221,55,39,34,231,245,97,125,193,159,180,181,206,46,120,132,184,103,82,127,1,213,29,82,166,176,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetListenerProcessPropertyValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d4b5bdca-3922-4a5e-8851-00d8a4f90933"),
				Name = "GetListenerProcessPropertyValue",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7424582b-a161-4079-9461-d20752238613"),
				Name = "listenerProcessId",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6afc875f-3bf8-4c1c-9c86-b7d1414d63af"),
				Name = "property",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,141,177,10,2,49,16,68,107,243,21,91,38,77,126,224,176,81,14,73,163,54,103,127,220,173,71,32,110,194,238,70,8,226,191,43,152,210,114,134,121,111,226,29,172,40,71,218,124,144,115,77,233,194,227,163,104,179,41,138,34,33,95,57,47,40,18,86,231,224,101,118,140,90,153,128,190,203,193,188,205,115,102,40,191,5,236,97,18,228,99,38,194,69,99,38,31,58,59,210,22,9,253,9,181,23,135,54,133,245,207,195,96,186,190,43,59,82,144,181,221,230,84,209,150,158,220,240,1,243,189,30,124,185,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cce8cf08-9ccf-4499-9777-193cf3664304"),
				Name = "ClearData",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,41,74,77,117,47,202,76,209,115,206,73,77,44,210,208,180,6,0,101,120,51,84,22,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSerializedFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8e611b2e-9f5b-48dc-9a0b-03b759e2176b"),
				Name = "GetSerializedFilters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,65,10,194,48,16,69,247,130,119,200,178,66,201,5,196,85,197,133,43,161,120,128,16,191,18,41,19,248,153,68,240,244,166,182,216,186,156,153,247,255,155,226,104,110,78,93,31,51,61,204,193,92,220,3,246,248,219,236,183,155,82,145,123,24,20,172,231,133,181,93,38,33,218,43,179,215,76,216,211,23,74,115,228,153,162,116,81,10,56,37,5,47,179,244,206,236,121,13,53,215,4,214,73,224,53,68,105,87,178,93,45,37,170,69,204,24,177,61,24,220,16,222,104,166,207,218,127,221,136,127,0,125,67,236,138,218,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEditPagesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("333265af-68a7-4358-973f-26bbea5deb67"),
				Name = "GetEditPages",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,87,91,79,219,48,20,126,14,18,255,193,228,1,37,162,138,120,222,0,137,149,130,42,141,169,163,237,246,128,208,100,90,23,44,82,167,115,156,162,10,250,223,119,108,231,102,59,189,112,25,218,144,160,36,246,249,206,241,185,124,159,59,199,28,17,38,168,88,244,71,247,100,138,47,49,195,119,132,163,99,52,76,9,111,39,140,145,145,160,9,139,58,238,166,207,187,59,115,203,252,123,70,248,2,140,25,121,68,29,251,125,208,224,168,133,252,254,34,189,76,198,89,76,252,16,16,29,180,168,141,225,193,13,168,79,210,20,62,213,106,244,147,138,251,175,201,8,199,242,145,178,187,32,21,28,62,162,243,132,79,177,8,6,125,48,156,208,187,140,99,101,171,140,134,130,198,84,80,146,70,218,253,25,22,88,45,92,240,36,155,181,80,25,87,119,28,134,249,89,103,156,78,49,95,180,147,56,155,178,111,120,42,227,114,35,62,29,143,245,142,192,93,187,74,18,161,159,163,11,34,122,54,94,16,134,145,252,204,253,137,197,140,232,197,97,119,108,120,93,235,182,202,169,46,66,52,168,227,248,165,11,23,227,156,198,130,240,84,98,53,4,223,230,4,11,162,247,200,148,247,48,7,32,105,16,232,151,237,100,58,195,156,166,9,147,30,163,206,239,12,199,45,180,187,227,249,224,214,77,233,138,98,119,5,153,230,199,52,235,104,159,203,56,214,175,167,195,165,229,163,222,161,80,232,198,98,65,21,52,24,0,197,186,183,2,179,213,36,204,69,70,199,102,53,0,76,190,140,58,211,153,88,192,142,73,2,201,25,221,163,160,154,9,68,89,233,59,68,79,144,6,27,65,239,147,49,200,163,228,229,251,129,227,140,28,73,240,147,96,69,3,200,144,188,91,112,248,0,255,44,119,119,6,22,174,97,6,91,206,168,58,9,180,26,58,210,41,109,229,169,61,65,49,77,69,103,76,69,15,230,49,205,103,119,205,254,160,177,112,175,157,121,233,248,63,152,251,180,30,175,51,180,127,153,4,102,144,52,189,219,38,129,77,28,208,171,91,86,99,79,39,40,176,58,166,222,204,232,249,25,73,203,72,102,166,159,100,124,68,162,60,90,109,145,2,77,176,241,151,5,88,154,13,26,74,32,150,197,177,238,118,233,167,232,44,215,203,254,62,50,218,192,222,160,49,60,59,146,14,195,183,49,233,19,62,39,252,20,90,98,78,174,146,71,200,197,4,199,169,60,156,231,125,28,171,121,158,195,180,240,92,31,130,161,226,189,230,108,14,243,6,107,138,120,107,30,44,6,55,103,191,213,158,148,35,179,157,42,177,15,122,246,203,208,26,59,232,83,99,61,240,29,19,191,242,65,106,124,242,90,202,245,60,147,82,115,72,69,170,5,124,222,35,158,162,103,82,111,181,242,105,13,185,174,24,44,237,92,99,166,118,162,183,197,94,207,24,185,139,42,133,37,100,254,120,236,150,73,13,93,151,165,2,179,17,209,195,87,59,177,139,232,132,254,34,232,134,131,231,46,228,84,91,209,238,233,169,151,35,189,202,235,94,157,24,224,167,211,88,44,173,86,114,221,161,134,166,82,232,189,75,245,183,80,67,253,44,127,57,17,25,103,166,190,105,185,44,174,86,181,32,92,229,83,133,108,213,95,20,74,168,42,172,133,176,64,42,115,187,129,56,161,97,154,120,51,186,34,19,194,9,100,95,239,207,73,218,188,46,236,185,236,184,189,14,87,65,170,50,254,187,114,187,53,225,11,158,41,190,47,74,240,82,89,174,50,178,73,132,75,23,103,52,157,197,248,141,46,28,144,38,79,189,102,106,218,120,241,191,54,230,230,83,165,242,138,155,110,34,31,29,200,17,89,115,57,240,106,223,115,12,176,119,140,194,240,247,129,114,189,49,176,247,80,243,143,18,243,119,211,217,173,101,86,174,63,144,197,118,2,184,166,139,195,104,144,244,85,14,130,16,29,32,127,63,239,74,111,91,88,71,78,107,128,74,2,12,206,191,134,152,111,32,232,205,46,138,175,56,141,179,174,145,109,217,208,77,250,218,184,91,42,166,85,223,184,180,101,41,153,79,126,205,49,180,199,27,139,176,108,21,176,150,214,110,7,189,158,34,194,101,37,205,42,113,75,37,188,133,168,25,25,108,39,25,19,232,4,29,234,147,14,92,97,182,77,164,138,35,2,247,253,85,6,242,170,161,165,190,241,18,240,7,203,165,73,198,246,18,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAddButtonMenuItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c1f91b47-5410-4c37-aab6-72004198b859"),
				Name = "CreateAddButtonMenuItem",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuItem"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a884ea23-f83d-49f5-8ace-42bda0d286a0"),
				Name = "menuCaption",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8b810b22-ea08-4315-bf33-a0808a42890d"),
				Name = "menuTag",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,91,107,219,48,20,126,78,32,255,65,245,195,42,51,35,146,65,215,135,172,133,204,89,135,55,122,129,184,219,131,49,69,169,212,160,97,75,70,146,91,76,200,127,159,100,203,141,237,37,132,61,89,151,239,114,206,167,147,188,98,9,114,202,203,72,211,28,92,1,78,223,64,76,165,196,74,188,104,244,24,161,223,116,29,10,174,165,200,20,122,95,220,58,2,244,231,147,113,203,70,119,56,167,70,194,139,171,130,90,196,147,7,62,2,104,21,191,151,140,64,139,139,241,6,173,138,140,105,120,254,225,220,79,102,169,239,163,88,172,180,100,124,3,189,59,175,167,23,226,66,51,193,141,164,61,114,187,3,128,80,100,66,26,84,253,69,55,82,228,11,185,89,195,105,240,41,184,188,12,102,23,159,123,170,81,142,55,212,117,234,26,106,142,182,187,46,204,84,234,140,205,202,92,188,154,156,10,44,77,139,154,74,181,191,234,180,227,80,218,180,255,141,48,253,96,68,31,35,226,172,234,8,246,2,201,52,237,225,185,102,186,58,10,158,165,71,196,109,33,241,240,8,43,176,100,207,54,25,44,171,47,86,43,232,30,168,58,237,160,54,185,190,118,186,170,82,183,130,148,89,173,84,215,49,116,74,186,117,166,137,183,234,51,188,212,40,53,210,192,228,87,44,177,198,63,105,101,231,161,221,122,206,107,161,138,135,230,13,236,7,181,91,83,246,209,201,179,0,195,102,47,0,158,57,60,10,75,165,69,110,133,235,193,196,140,43,99,8,59,230,190,15,182,147,241,232,0,97,65,72,23,24,212,169,255,184,95,255,161,207,26,250,54,236,157,203,219,129,76,177,255,202,36,29,137,212,214,239,20,12,221,173,0,105,184,188,204,50,87,127,203,73,154,230,9,249,90,106,45,56,10,51,70,185,142,150,41,56,107,240,77,241,78,224,52,171,103,191,3,52,83,180,43,208,107,176,233,207,222,36,205,147,161,27,33,115,172,161,103,31,57,34,79,219,233,206,11,122,147,217,255,153,250,105,43,249,11,103,37,133,131,97,217,131,235,44,15,25,13,6,238,191,29,7,252,129,227,233,184,174,234,167,153,143,70,147,241,169,135,221,167,111,148,37,213,165,228,239,127,153,243,191,169,95,208,117,64,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f56dd792-9ebe-4dcd-b067-9ab31ff602b5"),
				Name = "ActivateButtons",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7374e663-9680-46fa-8c97-b69ca9801845"),
				Name = "activate",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,77,111,219,48,12,61,219,191,66,205,161,72,128,193,232,174,53,178,33,31,70,23,96,232,138,102,221,206,178,197,36,194,100,201,144,229,100,198,154,255,62,202,114,60,167,169,157,174,221,46,1,44,62,190,71,145,143,202,150,106,18,23,198,40,153,147,49,185,1,51,117,31,195,81,232,111,49,198,168,161,75,85,232,4,238,213,46,159,169,66,26,196,221,209,53,4,243,38,20,76,18,195,183,22,113,167,121,74,117,57,83,162,72,229,55,42,10,32,99,164,45,56,11,162,52,51,37,121,124,36,23,212,162,169,1,242,145,92,145,107,242,62,244,99,165,4,161,140,57,241,72,210,88,0,155,150,247,124,189,49,182,46,163,11,168,81,12,4,24,120,1,16,24,55,47,128,37,42,43,251,97,182,13,32,13,55,229,50,217,64,74,159,185,191,11,132,62,95,145,225,17,244,98,76,100,33,196,136,252,242,189,170,157,241,18,146,66,35,32,146,107,46,225,192,245,144,131,158,41,41,1,91,163,100,48,159,30,195,66,223,203,141,230,114,77,242,138,247,150,166,54,181,45,21,216,51,196,245,247,231,169,126,128,19,95,228,81,139,103,110,243,81,105,34,132,218,1,27,254,17,68,71,120,61,51,58,79,61,201,50,144,172,147,187,111,18,111,38,239,115,195,121,242,8,179,187,168,247,254,74,105,160,201,102,104,7,156,40,105,52,218,138,75,55,216,122,157,102,238,248,51,45,85,97,130,250,43,111,108,225,54,16,75,57,164,211,156,124,5,173,105,174,86,38,120,88,4,223,33,62,36,53,217,53,55,94,206,218,174,166,168,13,71,46,47,137,115,12,194,211,140,106,248,162,177,57,84,212,184,202,45,239,200,192,114,193,79,243,9,68,230,216,6,35,75,113,85,85,214,226,117,170,148,227,195,208,34,24,57,152,151,239,184,73,54,228,40,228,34,94,66,115,32,131,201,193,54,131,235,234,212,171,145,245,44,240,226,93,198,10,43,124,140,13,254,17,182,8,231,45,151,119,114,14,159,123,188,62,216,203,97,119,122,246,164,67,51,106,44,244,58,197,78,11,118,232,205,154,125,120,157,94,231,62,157,232,49,88,209,66,24,242,215,50,79,153,246,248,179,39,32,176,252,106,252,39,76,238,69,173,128,123,220,28,107,176,69,62,7,116,150,184,209,156,217,178,151,56,152,196,0,187,85,12,206,253,157,84,46,123,219,250,253,139,253,251,111,11,120,218,192,21,197,230,134,158,215,244,240,55,9,125,169,109,193,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("07ab6794-5e15-41c3-8853-d120b87a50fd"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,205,10,130,80,16,133,215,250,20,211,70,20,196,23,144,54,73,164,139,32,48,219,223,188,163,14,232,40,58,70,20,189,123,215,254,200,90,13,243,157,51,115,102,168,0,119,177,65,73,134,168,101,193,179,196,88,119,171,81,164,229,152,180,70,118,61,112,28,248,117,172,89,29,107,212,174,231,193,213,182,6,233,137,75,168,140,240,242,36,26,150,176,83,37,6,105,94,97,163,130,248,91,11,109,235,164,122,24,7,236,13,99,204,133,90,126,15,100,51,106,172,251,212,180,5,149,99,175,38,18,28,72,99,59,237,203,132,106,18,194,33,72,216,84,85,211,5,255,190,112,31,75,255,176,63,191,214,135,45,242,56,201,137,96,19,169,110,74,122,194,79,220,76,153,223,238,133,246,237,14,159,224,29,124,74,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b10ed1c7-a792-4118-9984-19afb3b679b3"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3c46b4ca-40e0-418f-8a26-44de42812454"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterQuestionScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("96940f50-959a-471e-bbaf-3c9a2fbcab94"),
				Name = "GetRegisterQuestionScript",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,203,78,235,48,16,93,55,95,97,121,147,68,68,254,129,80,68,161,93,244,162,150,66,91,16,18,27,147,76,136,239,13,118,100,59,180,21,234,191,99,199,73,31,41,21,139,155,133,163,204,153,51,115,230,216,142,210,146,241,119,244,86,105,45,184,250,163,230,245,119,236,41,23,103,137,224,39,193,15,80,138,190,195,141,88,59,0,245,17,30,173,53,153,236,226,120,151,91,74,145,152,240,152,43,77,121,2,227,212,36,207,76,18,153,57,128,180,200,114,156,198,222,39,149,72,130,42,141,20,104,170,41,67,224,176,66,67,150,104,38,56,149,155,75,87,58,66,238,125,21,132,177,215,37,145,65,154,6,120,3,10,71,8,15,161,0,13,47,160,26,20,159,37,112,177,207,159,138,131,244,142,63,70,211,137,9,23,8,19,108,215,151,209,124,122,111,28,56,244,238,28,225,97,57,154,47,198,247,83,236,102,207,42,94,79,217,210,110,42,86,164,32,27,11,142,98,118,234,51,233,100,80,150,192,205,56,45,30,188,105,30,162,47,59,72,38,36,208,36,15,238,96,243,68,139,10,102,148,201,174,161,221,45,64,140,159,236,74,248,229,245,126,107,207,50,100,59,163,126,31,249,214,153,78,13,98,52,152,168,215,219,61,216,55,42,87,140,167,98,69,22,32,37,85,34,211,100,240,151,174,39,160,115,145,42,178,200,165,88,221,22,12,184,30,125,154,229,153,233,124,66,213,191,160,110,112,80,234,244,220,25,187,253,232,71,29,181,17,53,30,198,91,4,133,2,100,173,218,254,234,239,255,104,253,73,160,183,55,34,242,135,144,209,170,208,15,21,40,171,161,17,107,37,110,221,1,214,149,228,221,139,71,154,83,230,122,180,220,91,90,218,23,89,8,55,71,16,30,184,225,78,251,35,36,66,166,173,35,251,68,242,8,101,65,19,8,176,111,174,198,53,126,245,113,67,54,92,175,215,189,23,6,177,192,209,127,99,23,60,103,231,177,172,8,233,156,169,48,198,241,55,119,106,104,122,156,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e531cbc3-72f6-4149-ac01-6d3843c2d56b"),
				Name = "GetRegisterEditPageScript",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cc8f34b0-c887-4ba9-9efd-3c06d34b4582"),
				Name = "editPageUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5c9f80a0-56fb-43bc-8155-67ff7e97f430"),
				Name = "sysModuleEditId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,87,75,115,219,54,16,62,75,191,2,193,33,34,167,42,147,92,171,58,51,182,172,164,110,235,198,83,217,241,193,246,116,32,18,146,224,80,128,10,130,150,85,13,255,123,119,9,74,36,65,210,143,230,210,139,101,1,187,223,62,240,237,67,15,76,19,181,230,242,130,45,248,5,211,108,197,13,215,9,57,34,146,111,200,169,8,141,80,146,233,237,207,137,209,66,46,134,68,205,238,121,104,62,122,62,217,245,123,189,29,253,2,186,92,159,201,196,48,25,242,179,136,14,9,66,5,23,90,133,60,73,130,253,205,213,89,148,13,123,189,126,47,27,245,251,15,96,244,239,148,235,237,52,71,125,137,93,251,89,216,221,81,205,67,165,163,210,220,41,51,108,170,82,29,242,96,28,11,46,205,217,41,249,129,208,128,1,208,3,255,83,109,130,5,55,23,90,172,0,115,172,226,116,37,191,178,56,229,158,79,179,33,226,129,134,48,219,105,184,228,43,118,133,176,214,94,240,73,233,21,51,30,29,236,222,103,131,22,99,7,13,223,226,24,205,249,103,45,172,103,79,97,92,22,130,7,119,11,128,233,54,57,87,81,26,243,73,36,204,83,40,73,93,208,207,250,144,89,49,39,222,229,118,205,109,136,224,22,121,115,68,62,167,96,102,178,90,155,45,121,251,214,213,35,71,85,129,60,187,173,47,115,211,240,236,14,30,139,58,104,116,212,207,250,112,32,230,91,60,168,147,202,107,242,108,216,78,3,191,224,72,50,43,8,97,5,78,82,17,71,92,123,112,157,204,130,227,53,192,69,30,221,81,191,45,240,102,92,165,142,147,82,52,197,11,119,81,147,64,138,71,144,226,95,19,37,131,41,215,130,197,226,31,238,237,35,194,215,246,193,102,70,120,156,112,68,70,0,3,214,43,18,211,80,139,181,1,44,199,22,64,35,21,199,105,98,212,10,137,228,13,80,243,44,250,107,0,132,221,125,200,234,148,173,114,181,67,213,138,252,1,169,27,248,126,160,249,58,102,33,247,222,253,248,14,170,102,0,71,24,9,148,106,206,186,227,40,58,73,141,129,176,246,180,235,174,31,136,48,15,204,121,226,87,4,230,104,254,47,35,172,16,169,65,3,10,254,182,62,107,139,98,163,172,114,237,214,220,33,117,170,4,190,228,90,179,68,205,77,128,5,114,45,100,164,54,30,146,218,150,192,152,197,241,140,133,223,186,74,1,165,100,26,199,246,2,13,227,55,106,47,194,66,185,188,156,167,50,111,174,222,70,70,80,22,59,36,59,201,178,66,126,147,91,71,57,184,166,181,58,27,208,122,221,125,21,124,147,103,150,37,235,71,184,235,61,37,60,36,206,65,153,232,231,36,111,240,251,76,169,152,136,228,147,208,9,114,207,232,148,143,250,115,165,57,11,151,196,67,207,215,251,238,65,132,236,232,42,88,170,216,40,10,28,59,194,74,208,57,131,114,134,151,45,235,186,215,240,171,151,213,94,254,86,222,154,157,4,252,159,236,173,155,129,202,193,193,191,224,55,190,125,70,150,14,221,3,242,128,5,82,88,193,24,222,148,120,121,237,4,83,195,180,73,174,133,89,230,120,216,234,107,38,113,18,148,99,179,253,218,109,241,237,82,144,81,40,159,73,62,49,241,249,220,76,13,154,137,114,156,237,12,98,34,163,239,12,193,113,238,101,113,190,36,4,154,81,183,112,111,205,157,203,123,203,18,203,199,5,183,219,193,57,147,240,191,6,134,93,37,92,143,149,148,60,175,192,224,51,55,53,9,143,94,184,74,224,26,75,72,227,216,14,188,74,95,170,207,121,127,63,148,74,39,192,122,195,35,116,96,191,159,157,108,1,165,54,226,32,176,218,11,238,149,131,107,17,153,101,112,169,108,125,121,227,52,54,169,230,103,114,174,96,219,3,171,130,73,83,28,250,46,175,49,61,189,46,224,95,184,88,44,205,119,32,195,243,236,75,183,114,133,237,112,72,236,223,198,27,98,39,121,166,3,149,205,245,85,114,251,190,93,105,22,101,135,69,38,30,21,250,13,193,65,251,121,115,125,186,105,174,223,119,101,250,252,87,161,211,81,193,229,22,191,97,22,4,223,114,143,15,222,143,246,91,87,211,171,0,40,110,152,144,9,136,121,116,28,171,132,159,195,79,1,144,161,254,129,153,97,229,248,203,236,30,160,219,194,171,41,223,21,93,195,85,5,234,99,234,109,17,187,216,0,236,200,87,18,52,194,254,239,32,6,191,115,185,48,75,242,145,188,183,136,189,214,148,76,30,77,48,121,128,86,179,175,37,152,168,121,2,91,21,108,218,114,123,109,112,176,198,204,56,78,179,84,198,138,69,131,33,57,76,105,240,1,135,12,237,212,205,55,223,195,6,113,124,207,30,207,185,89,170,40,9,46,151,90,109,236,174,147,123,234,119,131,160,9,152,100,248,241,50,172,39,98,165,7,142,116,219,27,118,95,13,58,175,170,175,244,31,212,225,34,123,42,3,153,159,87,64,15,219,19,182,254,172,222,40,220,106,175,175,191,245,61,107,88,89,219,170,245,88,239,31,185,189,190,59,97,52,135,246,38,221,237,26,95,25,183,227,195,234,108,87,183,15,249,234,214,189,225,162,35,181,134,240,47,130,226,117,202,239,15,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterCopyPageScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7a364412-97bb-46bd-af2f-76c38fb15461"),
				Name = "GetRegisterCopyPageScript",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eff5a374-9497-4fcd-8ca5-5fc93e7bb8a6"),
				Name = "editPageUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8abb2407-f1a2-491d-992a-77d2f554340f"),
				Name = "sysModuleEditId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,87,75,115,27,55,12,62,203,51,249,15,12,15,217,221,169,186,73,175,81,157,142,45,63,170,182,110,60,149,147,28,28,79,134,218,133,36,58,43,82,225,114,173,168,154,253,239,5,185,239,135,228,184,237,33,23,201,38,129,15,32,128,15,128,30,152,34,114,13,226,154,45,224,154,41,182,2,13,42,38,199,68,192,134,156,241,64,115,41,152,218,254,28,107,197,197,98,72,228,236,30,2,253,198,245,200,238,217,209,96,176,163,111,81,25,212,68,196,154,137,0,38,33,29,18,131,229,95,43,25,64,28,251,197,205,187,73,152,14,7,3,84,74,71,207,142,30,208,236,151,4,212,118,106,113,191,197,114,246,93,88,222,81,5,129,84,97,101,240,140,105,54,149,137,10,192,31,71,28,132,158,156,145,31,8,245,25,34,61,192,95,114,227,47,64,95,43,190,66,208,177,140,146,149,120,207,162,4,92,143,166,67,11,136,42,92,111,167,193,18,86,236,157,193,205,44,250,23,82,173,152,118,169,179,123,149,58,61,214,74,13,47,7,210,10,224,82,241,204,183,67,32,55,185,96,233,112,129,48,150,235,45,10,81,71,171,4,156,194,193,233,54,190,146,97,18,193,121,200,245,33,240,184,41,232,165,207,142,76,208,249,156,184,55,219,53,100,175,71,135,201,243,99,114,153,160,253,243,213,90,111,201,139,23,109,77,114,92,23,200,34,223,155,182,219,142,115,119,152,73,218,130,163,232,68,154,249,241,124,18,159,129,102,60,50,239,207,128,77,77,196,16,97,121,65,120,33,163,16,148,77,144,193,57,255,170,253,16,243,29,130,107,254,196,68,186,78,144,196,90,174,76,30,46,56,68,161,227,249,161,92,249,15,70,197,187,117,74,119,62,53,33,39,161,115,103,220,24,100,161,35,237,91,180,214,10,42,198,148,252,66,204,231,107,226,216,232,118,125,244,70,251,2,227,159,132,161,75,231,57,122,71,27,147,51,26,216,160,160,183,124,190,53,137,111,82,209,237,178,115,216,79,29,47,231,85,60,203,73,148,9,156,38,220,88,114,205,117,60,243,79,214,136,135,46,237,168,215,91,18,61,25,175,180,90,161,49,214,0,51,107,220,179,161,195,40,141,240,141,191,197,82,248,83,80,156,69,252,111,112,11,17,67,17,207,88,77,9,68,49,148,73,215,232,192,121,37,51,13,20,95,235,222,68,152,204,143,203,188,187,142,209,156,132,159,28,36,250,238,167,180,73,245,58,199,247,168,102,34,127,98,252,28,207,243,21,172,35,22,128,251,242,199,151,216,110,28,60,50,111,49,93,206,146,21,19,121,154,104,141,47,43,216,186,191,241,216,122,176,185,104,18,224,9,79,107,105,126,167,111,172,21,84,167,24,40,122,220,155,218,62,205,78,227,177,234,189,225,243,178,46,82,3,184,1,165,88,44,231,218,55,100,249,192,69,40,55,46,173,248,48,102,81,52,99,193,231,189,188,48,98,34,137,162,236,198,24,55,255,209,252,38,200,213,171,219,121,34,236,124,114,55,194,52,175,157,109,15,105,90,40,108,172,7,70,16,239,105,147,119,14,109,17,241,61,135,141,141,49,139,215,95,169,109,7,135,196,113,42,180,78,170,160,63,46,123,107,15,102,82,70,132,199,23,92,197,166,24,205,144,193,211,185,84,192,130,37,113,205,19,214,69,91,33,92,236,105,55,150,191,166,129,228,72,249,74,80,225,206,25,178,220,228,186,198,247,65,215,189,65,218,44,135,143,226,163,222,9,180,242,58,191,239,132,163,118,82,250,233,255,14,219,71,165,233,176,115,66,236,196,40,76,217,209,84,97,90,102,249,83,205,148,142,63,112,189,180,144,102,78,54,204,154,49,90,173,35,230,218,50,170,43,211,158,145,253,72,229,176,232,191,198,12,32,255,206,237,178,98,82,222,9,171,121,117,182,104,237,137,84,53,178,254,167,231,126,135,175,165,41,237,246,137,143,250,174,67,176,188,8,179,154,95,64,182,204,93,49,129,127,43,172,225,119,49,168,177,20,2,44,223,253,75,208,13,9,151,94,183,149,208,71,22,147,206,113,62,108,107,205,176,185,125,85,59,80,229,6,218,239,248,100,92,40,118,234,211,45,194,212,33,237,227,26,57,47,180,253,15,60,212,75,255,70,102,52,118,199,73,164,19,5,19,49,151,184,162,163,89,206,132,206,15,189,14,107,72,17,228,94,232,95,129,47,150,250,191,96,219,68,149,61,162,118,107,218,240,144,100,159,61,9,53,157,235,209,166,87,53,246,167,74,22,115,163,214,154,170,246,110,42,244,184,64,232,72,58,123,46,186,219,220,109,247,39,212,93,21,75,239,137,248,116,84,84,120,143,243,56,141,252,207,214,237,242,9,163,114,13,236,122,230,99,225,227,138,46,98,148,115,233,56,146,49,92,225,79,58,148,161,94,85,174,65,237,252,237,236,30,193,251,222,216,208,190,43,122,79,91,23,25,97,114,144,179,188,141,142,208,45,133,90,156,70,118,246,180,48,253,63,64,44,244,146,188,33,175,114,204,65,111,96,204,143,138,243,7,108,52,5,201,112,180,103,113,236,213,200,162,151,153,236,3,196,205,106,6,102,156,38,34,146,44,116,134,164,92,24,208,13,51,223,232,126,101,187,146,151,11,205,201,61,251,122,5,122,41,195,216,191,89,42,185,201,214,47,235,172,119,0,197,24,193,49,106,190,190,13,236,208,123,105,89,46,7,44,14,15,220,57,251,239,234,233,250,87,0,120,147,30,12,68,234,89,78,12,108,3,179,99,34,109,247,145,78,39,104,238,231,205,5,112,88,219,40,235,68,109,117,23,111,212,238,76,153,155,10,176,15,10,196,168,23,239,63,86,57,175,196,135,17,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6066d9c3-e37b-4667-a518-411e51ec97d5"),
				Name = "GetRegisterAddPageScript",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7ca1fe87-606e-44ea-bdb3-56754026fd4f"),
				Name = "editPageUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1ef7bd20-b13b-4c05-99f3-1c8b02e7311a"),
				Name = "sysModuleEditId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d0707644-a667-46cb-99d3-031d44591f8e"),
				Name = "typeId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,223,111,218,48,16,126,6,137,255,193,203,75,18,13,89,123,94,215,77,29,208,42,147,166,162,2,235,67,85,77,38,62,152,167,36,102,182,3,203,80,254,247,157,237,64,203,143,66,167,189,16,18,223,247,221,125,223,93,46,75,166,136,158,146,75,82,192,138,140,140,18,197,252,115,41,50,14,42,138,47,58,237,78,123,137,1,114,1,197,144,205,97,200,20,203,193,128,210,13,160,47,82,35,100,193,84,245,65,59,108,151,200,233,79,72,205,199,40,38,235,78,187,213,90,7,183,8,6,149,20,218,176,34,133,132,7,93,98,185,232,80,201,20,180,166,155,147,73,194,235,110,171,133,160,250,194,167,253,85,130,170,124,77,175,201,236,175,155,204,235,64,65,42,21,119,9,253,17,189,150,42,103,38,10,194,245,187,58,196,199,55,165,224,116,144,47,76,21,215,93,135,129,194,8,83,141,210,31,144,179,137,133,190,128,116,10,250,204,176,145,44,85,10,116,139,216,16,25,5,112,163,196,201,244,142,100,220,4,210,94,38,48,123,210,223,48,140,42,253,85,242,50,131,1,23,230,20,141,222,13,140,235,78,219,58,40,102,36,26,87,11,232,201,172,204,11,44,141,188,185,124,174,216,185,116,212,98,122,197,121,20,152,231,88,76,243,69,203,130,142,64,9,150,137,63,176,75,29,219,89,57,71,118,140,197,63,119,240,218,151,156,232,62,24,38,50,235,137,175,209,142,2,211,11,235,22,54,223,153,118,213,220,50,77,198,160,20,211,114,102,232,36,161,247,48,237,201,194,40,153,105,106,3,108,85,222,53,194,183,205,106,140,230,72,22,172,68,193,229,234,97,240,219,80,142,227,194,33,178,127,231,96,162,48,45,181,145,185,237,241,181,128,140,135,49,229,50,167,75,150,149,16,63,132,219,238,124,103,56,136,75,120,154,133,240,241,49,56,227,198,22,236,165,158,106,238,65,232,89,171,241,30,229,13,220,32,59,230,35,202,223,146,128,250,186,239,228,202,202,29,42,145,227,187,228,27,250,205,106,140,226,224,95,50,249,23,224,140,146,221,208,179,74,38,26,158,107,127,153,122,47,80,35,51,238,145,154,64,166,97,59,66,26,50,92,76,192,175,165,221,110,78,163,157,128,255,105,253,46,101,194,67,223,249,102,226,246,79,49,219,94,253,88,62,249,68,236,239,123,18,186,87,249,176,198,115,38,205,26,246,3,52,26,236,92,232,180,177,90,49,171,48,122,119,135,71,135,107,189,123,124,231,218,26,26,81,22,115,47,10,185,26,165,74,44,12,106,186,1,115,7,115,161,49,240,214,31,242,205,233,235,51,116,9,224,242,178,161,118,155,184,15,207,241,101,160,167,244,106,129,172,60,194,188,40,201,39,66,67,125,96,180,87,159,223,44,79,131,240,4,223,15,244,27,72,129,41,85,129,95,68,58,150,190,70,252,12,254,5,195,253,37,153,36,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateModifyAddPageParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6d031369-c461-49d8-88dd-65ad4e8a629f"),
				Name = "ModifyAddPageParameters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e2a79ae1-57d1-4c7d-943c-bc6e6cd55bfb"),
				Name = "openPageParameters",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("923f36a7-0718-403f-91e6-dc7b2c2e60a8"),
				Name = "queryStringParameters",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateModifyEditPageParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("66b97c47-732b-4b71-925f-ce9dcb982ed9"),
				Name = "ModifyEditPageParameters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3cedd309-1575-4edc-8d64-f0258ba279c0"),
				Name = "openPageParameters",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9435cbd2-912f-4724-85e9-a0939a767a93"),
				Name = "queryStringParameters",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateModifyCopyPageParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("94b7a20f-dc1d-43c3-ad18-4773309a2e88"),
				Name = "ModifyCopyPageParameters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fc8e5baf-918c-4211-b9b7-a3c9e6acce96"),
				Name = "openPageParameters",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3d8de5a7-7ba3-4f1b-ba59-8554a4eb2679"),
				Name = "queryStringParameters",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateLoadViewFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0eb0ee39-b426-43d4-87a6-c0374988c3bb"),
				Name = "LoadViewFilters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b538a008-9c48-47b7-8217-aae9bf774ff0"),
				Name = "enabledFilters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateGetAddScriptForDetailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bd76ec08-61b1-4845-9725-b8ac15b2bed1"),
				Name = "GetAddScriptForDetail",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f29603b5-fec8-42cf-a29a-8ce268996254"),
				Name = "openWindowScript",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,111,219,48,12,61,59,191,66,245,197,50,96,8,187,27,1,214,180,235,176,67,3,172,238,86,12,109,48,40,22,147,9,112,164,76,162,156,22,129,255,251,36,127,4,206,71,49,108,62,81,34,249,200,71,63,170,230,134,216,37,153,18,5,59,82,160,145,106,61,115,178,18,96,104,154,79,236,146,93,111,183,160,4,141,95,84,237,67,21,128,184,22,226,22,144,203,234,1,126,59,176,232,147,63,189,34,19,80,106,1,52,152,107,64,154,148,206,162,222,220,114,228,119,18,42,145,164,76,232,13,171,121,229,32,125,78,46,1,37,139,252,69,197,227,178,119,218,108,56,210,88,174,8,189,186,148,146,146,253,158,236,63,52,164,105,226,140,104,159,243,36,149,208,187,162,52,114,139,199,12,160,178,64,246,45,126,203,147,172,156,42,81,106,229,9,124,140,135,3,93,162,10,168,147,168,253,66,101,127,67,166,83,146,188,129,77,130,171,243,68,125,68,27,114,21,104,135,110,191,243,74,10,142,218,4,166,193,2,154,142,224,162,200,0,58,163,242,225,220,52,131,21,198,203,125,11,53,132,153,21,218,153,18,124,103,187,150,207,243,191,79,184,120,179,247,90,184,10,126,158,162,38,139,69,126,194,161,171,194,180,10,81,182,141,42,120,13,194,55,112,24,204,136,122,116,146,30,249,95,112,118,119,90,150,57,69,19,27,80,147,140,188,87,48,35,248,75,218,116,52,159,131,121,134,167,255,3,239,12,36,0,208,131,127,248,29,94,78,249,100,164,143,78,49,172,215,227,224,184,164,56,210,13,161,151,216,102,233,13,159,255,8,198,248,182,86,200,110,180,90,201,181,51,60,0,176,155,74,130,194,46,247,27,202,74,162,4,203,62,3,222,131,181,124,13,157,135,62,113,163,60,92,70,230,176,123,240,42,48,98,174,177,229,215,199,101,239,86,232,3,102,250,117,230,16,181,178,236,7,216,185,206,72,71,244,239,105,95,74,127,252,26,150,173,101,60,112,63,218,173,150,230,241,182,53,221,42,119,114,247,79,12,123,212,221,243,226,135,253,7,159,179,3,189,117,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterOpenWindowScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("858aafc7-c3b9-478b-ba6c-1cdd545f9d1f"),
				Name = "GetRegisterOpenWindowScript",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4cdca878-bb35-4fd8-a314-9d10bc3d8bbc"),
				Name = "openPageParameters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ba64c08b-bd4b-4ca4-bbb0-a91bba867908"),
				Name = "queryStringParameters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d88ac078-c19a-44ad-a47a-4801c495baaf"),
				Name = "editPageUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,91,111,218,48,20,126,78,165,254,7,207,47,36,18,178,250,60,180,73,45,162,29,219,170,86,234,237,161,237,131,33,7,112,27,108,102,59,80,134,242,223,119,236,4,18,18,160,235,246,0,132,115,249,206,241,185,124,206,156,107,98,6,228,11,145,176,32,55,86,11,57,62,75,69,18,131,14,163,206,241,145,25,176,211,217,12,100,28,210,91,208,154,27,53,178,76,161,224,65,200,88,45,66,234,140,230,30,163,203,147,100,192,135,175,123,177,156,153,76,147,36,215,160,25,117,255,104,161,25,22,238,165,118,148,202,161,21,74,134,11,25,71,100,181,34,171,147,140,100,217,218,97,225,51,112,134,168,167,219,185,182,104,45,249,123,1,139,107,62,6,198,205,236,13,149,193,97,243,54,169,73,190,27,37,217,13,104,193,19,241,27,66,136,133,117,112,119,253,56,122,207,149,62,122,193,64,169,132,8,115,46,180,177,152,180,213,41,160,116,164,52,240,225,132,132,238,68,51,174,249,20,44,104,34,36,249,149,130,94,230,197,184,94,203,13,150,225,248,40,16,35,18,22,72,185,32,40,113,71,60,49,14,56,200,8,224,83,174,110,166,23,100,248,169,136,159,228,147,93,73,140,242,185,208,55,170,83,145,108,242,100,63,96,249,174,53,109,55,36,100,206,147,116,71,168,18,248,222,25,212,221,50,111,159,109,21,247,201,62,55,218,89,156,49,47,233,24,110,134,19,152,242,75,46,241,89,99,137,238,12,232,174,146,18,252,116,177,11,176,91,22,33,189,174,59,209,136,112,67,26,98,140,225,90,209,43,135,129,124,250,66,46,82,17,179,222,116,102,151,121,115,182,211,192,248,141,156,92,10,125,105,44,151,67,56,91,34,76,21,210,31,110,171,70,107,111,246,32,98,59,97,183,42,159,146,176,155,38,54,213,208,151,35,197,250,18,195,10,46,109,33,140,26,77,113,53,10,246,66,127,3,49,158,216,255,193,246,141,218,140,96,69,235,150,190,77,242,239,29,13,117,139,241,238,58,150,52,242,81,203,53,75,85,38,191,36,19,28,103,199,39,123,44,91,123,20,142,14,93,179,202,53,125,164,87,40,3,189,110,106,63,166,207,101,45,163,15,226,211,206,122,194,119,36,143,220,199,94,125,218,155,35,116,60,142,155,204,102,102,12,7,223,114,33,13,218,133,180,155,40,3,151,96,12,218,208,168,28,215,97,69,126,53,120,65,240,93,103,220,242,126,238,20,196,84,247,197,141,112,61,40,136,170,142,142,208,53,135,74,157,58,158,218,106,152,236,39,200,177,157,144,175,228,164,192,12,118,22,166,247,102,89,111,14,210,174,151,12,47,146,188,142,59,61,242,234,229,33,119,1,182,73,107,0,142,173,83,153,40,30,183,218,100,115,61,97,26,142,62,233,126,103,119,134,242,250,60,125,225,111,151,96,39,42,54,236,118,162,213,162,155,8,204,211,39,27,29,64,113,65,144,165,221,207,223,129,29,58,47,221,140,203,129,136,237,3,186,214,126,93,181,93,255,4,128,154,236,96,33,178,200,239,68,224,9,204,223,101,89,157,71,26,76,96,252,84,177,115,165,167,220,134,219,175,27,237,202,251,75,117,81,107,236,18,229,171,165,1,105,79,162,75,117,86,255,0,255,15,163,86,73,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEmailContextMenuItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("44786b3b-10f8-4bc8-80c8-0faf4648b265"),
				Name = "EmailContextMenuItem",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuItem"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4b788e0b-56d7-4d58-8b08-4a791a9ecb4f"),
				Name = "caption",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0cc2d67f-ce85-43a5-aa5c-113042fc92d8"),
				Name = "tag",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,65,75,195,64,16,133,239,130,255,33,228,148,130,44,222,139,7,109,99,9,216,80,72,212,163,76,147,105,92,155,236,202,236,36,169,136,255,221,73,210,150,132,138,167,29,230,189,247,13,59,211,0,121,21,154,58,98,172,188,59,207,96,235,165,72,4,206,238,88,61,71,234,21,183,11,107,152,108,233,212,185,88,31,3,193,108,126,125,213,8,65,98,81,46,241,85,173,115,21,99,219,189,189,120,66,11,42,31,240,81,62,110,71,75,233,58,38,109,10,245,104,169,2,14,252,176,2,93,158,70,188,125,223,254,248,55,67,80,165,54,233,173,129,31,251,179,9,126,1,159,172,173,17,88,54,84,99,49,133,66,4,134,98,146,32,4,198,252,225,235,254,3,14,157,76,53,142,245,208,192,182,196,23,141,109,194,98,20,199,14,74,55,177,116,201,176,65,195,178,154,82,103,123,149,188,219,246,201,66,190,6,183,255,3,121,233,215,133,129,50,134,170,195,251,27,178,25,58,215,127,191,91,53,30,184,139,245,86,255,95,206,185,145,2,21,200,199,59,245,187,221,64,129,42,37,196,21,201,105,196,46,174,104,41,52,66,174,201,156,111,63,255,5,38,158,86,83,9,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateContextMenuSeparatorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("09822b63-ca0c-4fc5-a31f-d6fe608074d1"),
				Name = "ContextMenuSeparator",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuSeparator"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dd7fd2d3-6e98-4bd5-aee2-89ef4aec5021"),
				Name = "caption",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,65,11,130,64,16,133,239,65,255,97,217,147,66,44,221,165,147,149,236,33,47,26,29,99,107,167,88,208,29,25,71,61,68,255,189,77,33,18,79,243,224,189,247,61,166,55,36,106,240,93,1,141,33,195,72,98,39,60,12,162,4,34,211,226,131,213,89,171,11,220,82,244,76,88,181,234,39,78,255,173,40,78,214,171,62,176,66,87,219,192,200,58,103,85,14,195,247,142,230,108,36,64,237,52,164,237,194,211,251,96,181,76,206,63,213,17,169,54,28,201,67,109,92,53,91,188,190,182,111,185,153,16,170,196,98,204,71,50,151,241,114,45,53,13,59,244,1,123,159,84,72,16,112,71,126,254,123,242,1,17,186,72,77,14,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaTagMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1f708fac-c897-4e56-aca9-0b00b10b088a"),
				Name = "GetSchemaTag",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8a4ac610-cdbe-41a4-b12c-af99623347b7"),
				Name = "schemaName",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b1ee3044-857a-485c-b7e2-0c2beeeb6edd"),
				Name = "id",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,206,207,75,78,44,209,40,78,206,72,205,77,244,75,204,77,213,81,80,242,76,177,82,210,81,200,76,209,11,201,15,6,171,210,208,212,180,6,0,50,190,152,124,55,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemasColumnListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("24c281c0-bffc-4d56-b2a3-1902291a0f1d"),
				Name = "GetSchemasColumnList",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, Guid>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f3a24457-89ea-4a35-a06c-10ad736cb9df"),
				Name = "schemaIds",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "IEnumerable<Guid>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,93,75,227,80,16,125,142,224,127,184,219,7,73,161,137,233,135,221,136,90,104,147,84,202,234,162,118,221,125,16,89,46,201,168,193,228,38,222,220,84,130,248,223,247,126,165,105,108,149,125,40,180,157,59,103,230,156,51,51,43,76,17,133,162,76,24,58,67,4,94,145,31,135,44,206,8,166,213,105,193,104,76,30,123,232,188,140,163,137,217,61,217,223,219,223,139,31,144,121,133,31,193,246,49,195,203,172,164,33,216,83,158,177,130,155,236,245,138,198,41,79,244,178,164,76,201,111,156,148,96,7,47,37,78,10,83,64,216,65,154,179,170,219,69,111,251,123,6,5,86,82,162,75,115,228,119,1,126,120,184,226,237,132,25,97,56,100,203,240,9,82,188,136,116,95,2,193,236,244,199,179,96,56,62,234,91,238,60,24,88,163,254,209,177,229,250,190,99,77,93,103,232,143,198,238,208,247,135,29,209,169,130,130,52,79,178,10,96,39,214,124,214,247,6,179,192,183,142,251,254,200,26,205,156,177,53,29,184,158,53,30,244,167,67,191,239,126,119,28,87,98,9,164,36,203,158,203,92,144,150,188,126,85,57,112,176,219,2,168,151,17,2,82,51,187,21,190,196,132,235,68,237,115,96,11,82,48,76,66,152,85,63,113,10,102,231,66,130,173,177,67,169,215,37,206,63,183,32,32,44,102,149,162,113,93,66,173,177,114,229,33,163,128,195,39,100,54,96,40,38,232,163,77,42,219,86,153,133,178,65,167,202,204,162,22,137,231,214,223,245,51,67,216,174,144,237,27,120,0,10,156,141,194,187,93,68,181,201,117,82,23,29,28,236,18,172,126,167,129,90,49,61,22,134,177,22,195,158,70,81,253,84,200,214,67,164,76,18,193,215,48,248,180,136,143,28,26,209,250,51,84,23,113,81,143,176,248,170,149,155,152,13,222,15,168,138,102,136,219,255,115,85,74,194,208,4,57,170,15,169,100,73,57,79,22,44,175,53,238,150,9,91,155,160,98,221,19,163,145,118,211,21,65,67,168,171,219,213,148,215,157,220,53,175,238,121,201,166,190,144,66,217,102,42,90,246,60,163,41,102,102,231,205,121,183,23,81,167,183,81,160,203,203,27,74,31,73,35,142,230,113,194,128,182,17,61,222,28,3,21,249,19,179,167,43,76,121,46,255,81,152,162,39,21,240,178,52,199,52,46,50,210,216,215,67,34,254,145,184,167,144,151,140,150,33,95,108,176,91,167,64,217,183,43,239,139,211,33,157,222,232,88,181,84,200,177,168,57,41,59,13,173,112,162,214,176,77,148,175,159,242,205,91,63,48,219,107,43,11,253,183,91,242,172,20,47,127,195,166,83,121,87,154,250,119,206,189,168,42,36,139,54,248,156,170,51,186,211,109,57,224,106,180,197,108,126,219,42,240,233,29,53,12,53,17,186,103,15,231,90,130,175,183,159,171,73,248,118,161,179,9,10,101,241,246,110,170,57,178,53,154,236,203,80,167,122,99,43,117,180,183,45,199,198,146,26,122,75,219,247,254,31,13,73,88,163,118,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetTemplateTagMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8d519718-20ff-46a5-8bde-f6d1fe2a76b5"),
				Name = "GetTemplateTag",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c5dd4423-d730-45a2-bc18-0aebc677a919"),
				Name = "id",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,203,47,202,77,44,209,80,10,73,205,45,200,73,44,73,245,76,177,170,54,168,85,210,81,200,76,209,11,201,15,6,43,210,208,212,180,6,0,92,176,20,46,54,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateReadIdFromTagMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ea6b2e9c-45a1-4110-a077-a46dedf59df9"),
				Name = "ReadIdFromTag",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("716fd41f-3103-4b96-9aeb-8fd05cc615a8"),
				Name = "tag",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e963813f-e5cf-4e95-9e59-d0489e975a0f"),
				Name = "tagName",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,40,46,41,202,204,75,215,243,44,246,43,205,201,241,47,114,205,45,40,169,212,40,73,76,215,212,84,168,230,226,44,74,45,41,45,202,83,112,47,205,76,209,3,75,89,115,213,114,101,2,181,1,85,232,5,23,228,100,150,104,168,91,169,107,70,27,196,234,185,22,150,38,230,20,131,36,252,18,115,83,81,180,231,165,150,131,141,64,215,101,24,171,9,50,79,1,211,22,0,116,55,152,137,154,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetTemplatePairsListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c6de0f48-1d75-4638-9ab8-f0bbb04ef9bd"),
				Name = "GetTemplatePairsList",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,221,74,195,48,20,190,110,158,34,246,42,133,210,23,152,10,82,235,24,50,113,108,234,165,132,229,108,11,164,201,60,73,38,69,246,238,38,77,209,110,10,235,85,114,78,190,159,243,245,28,56,82,4,235,149,163,55,84,195,39,189,151,107,39,141,230,216,93,91,135,82,111,75,58,245,82,220,178,98,66,200,33,188,118,208,238,21,119,208,44,23,3,164,209,78,186,110,185,222,65,203,23,30,176,99,47,22,176,54,90,67,207,85,141,31,204,185,230,91,192,146,230,77,203,165,90,13,108,121,49,161,244,132,255,125,38,106,163,124,171,131,202,72,179,186,19,67,157,229,51,209,195,226,119,10,125,226,45,92,2,199,55,73,181,199,26,20,128,15,82,57,192,51,76,141,16,78,169,245,38,221,238,153,99,128,134,139,101,169,88,155,118,207,81,90,163,87,221,30,170,230,195,115,85,82,146,229,115,35,188,130,42,216,140,215,101,103,83,97,38,66,150,25,25,107,36,34,27,253,177,145,147,95,123,74,90,119,230,107,10,46,5,27,38,82,41,233,179,224,131,204,198,4,247,235,29,101,227,124,168,212,61,97,65,191,72,22,27,58,12,52,98,143,212,113,148,33,171,87,174,60,12,219,112,203,254,9,185,138,199,56,83,228,146,226,18,83,218,167,63,255,249,135,69,110,40,187,74,75,89,133,97,28,151,218,62,66,199,162,203,162,247,156,13,221,24,87,172,150,65,53,34,143,228,72,8,65,112,30,245,176,214,147,111,237,239,196,108,226,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateContextMenuMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aaa44dd0-ce54-4981-a5ff-232b81969511"),
				Name = "CreateContextMenu",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,203,10,130,64,20,134,247,61,133,204,198,81,98,172,181,180,40,163,112,17,4,181,139,8,115,142,50,160,103,98,60,98,32,190,123,163,69,74,45,191,255,114,46,129,127,76,114,16,103,3,176,55,74,138,168,174,72,151,145,198,76,229,98,45,37,71,104,156,55,198,4,37,103,128,201,189,0,171,16,60,233,0,88,179,185,195,178,164,168,128,121,94,56,27,166,217,222,41,53,234,65,188,34,163,48,23,59,109,202,132,56,107,23,157,72,199,106,44,157,149,227,182,203,238,86,90,114,195,70,161,212,205,101,84,174,214,183,32,122,8,251,242,223,118,27,32,83,195,96,42,84,52,177,184,23,218,219,126,222,43,20,32,197,219,143,62,73,111,106,34,141,223,128,253,197,15,94,16,70,171,65,29,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsLoggingEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("994dc114-6e29-4e21-b450-b6e545ec38ee"),
				Name = "IsLoggingEnabled",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,208,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,85,80,180,85,200,43,205,201,209,84,80,83,83,64,151,212,11,78,206,72,205,77,132,171,209,84,168,230,226,44,74,45,41,45,202,83,192,174,84,207,179,56,164,40,49,57,219,57,35,49,47,61,181,216,51,207,197,201,154,171,150,11,170,39,45,49,167,56,213,26,0,47,69,182,7,135,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModuleProcessesInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ed99ba7-eb4f-4748-bf61-67a801d5d5dc"),
				Name = "GetModuleProcessesInfo",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, string, Guid, bool>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,91,107,219,48,20,126,78,161,255,65,243,67,177,193,248,7,44,151,145,38,91,8,164,165,224,164,125,24,123,80,229,227,84,155,44,25,93,58,210,177,255,62,93,236,58,182,3,43,228,33,210,57,231,187,29,249,21,75,132,235,122,133,201,11,160,57,58,40,144,43,193,57,16,77,5,207,150,117,205,40,193,238,191,239,200,158,168,126,217,9,130,153,59,82,126,140,247,185,109,47,233,209,72,223,149,249,182,131,166,140,106,10,42,123,18,242,151,170,49,1,127,191,145,194,212,201,244,250,106,71,149,158,173,169,39,193,242,52,83,90,90,176,20,137,231,159,150,121,177,64,216,151,148,85,52,34,16,85,37,120,199,176,1,157,3,179,83,107,172,113,124,125,53,233,91,72,63,2,112,39,10,195,96,25,56,3,90,250,158,202,5,132,190,199,102,206,223,58,115,193,12,34,184,246,185,9,102,42,126,143,43,248,152,153,29,121,235,70,226,161,153,40,63,169,115,181,145,189,90,5,162,200,113,191,218,117,74,80,134,105,203,198,225,55,242,73,239,77,205,96,182,49,180,72,81,27,117,56,61,11,193,22,139,216,141,186,139,38,247,109,209,63,231,214,89,133,15,254,218,77,180,109,21,62,194,131,165,3,174,193,213,74,33,193,166,128,98,39,35,244,32,202,219,101,38,232,143,93,15,45,81,236,132,57,248,56,84,190,71,170,117,181,45,162,31,217,94,228,94,100,156,36,104,62,71,121,87,12,16,147,86,101,227,241,50,212,178,105,234,3,78,221,188,147,199,200,91,232,104,226,179,88,13,196,104,113,231,0,211,142,255,61,149,110,212,177,63,72,65,64,169,80,117,244,206,195,250,246,222,48,150,61,98,102,0,125,241,138,179,175,85,173,79,232,243,69,11,35,144,145,7,151,227,80,199,167,249,57,242,205,205,240,115,238,161,222,97,110,215,39,179,111,148,23,91,13,213,237,201,66,12,33,19,171,157,91,229,77,240,19,34,184,166,220,128,151,240,183,205,178,14,184,91,94,138,102,37,255,121,113,113,187,193,116,180,135,116,248,230,82,84,98,166,32,184,14,111,59,91,22,69,124,70,234,107,86,141,253,73,208,70,242,230,27,152,254,3,67,87,222,8,222,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillProcessMenuMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5b3e1b46-1a2a-4174-b9a3-4a9585bc6f4d"),
				Name = "FillProcessMenu",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,86,91,111,211,48,24,125,238,164,253,135,144,151,165,90,103,49,110,147,152,120,40,101,64,37,54,161,165,131,23,164,201,109,220,204,144,216,145,237,180,76,168,255,157,207,183,229,210,244,50,4,60,117,177,207,119,124,190,251,22,88,4,57,79,202,140,124,22,124,70,164,36,114,204,230,60,120,19,124,32,234,114,253,34,234,159,31,30,44,192,72,222,241,229,112,166,40,103,111,75,165,56,3,139,57,206,36,113,215,83,127,248,25,167,4,213,129,14,144,19,86,194,181,197,161,75,248,130,11,169,4,101,105,32,136,228,165,152,145,75,204,192,90,92,225,156,0,52,156,16,33,176,228,115,133,190,146,233,176,40,194,117,139,177,34,185,135,99,243,168,68,5,75,53,82,63,136,174,73,206,23,100,152,101,198,15,103,44,103,130,22,10,76,236,55,186,200,11,117,95,93,211,28,68,140,56,155,211,116,66,242,34,195,202,208,219,7,95,7,71,215,77,181,71,131,46,253,128,251,245,116,85,187,243,74,245,197,233,234,72,43,164,243,32,26,203,86,208,39,37,3,17,112,72,250,193,175,195,131,158,143,157,182,7,25,140,44,3,136,6,200,83,130,103,210,4,82,95,25,255,122,30,136,70,130,128,236,228,237,253,240,59,254,9,102,74,148,164,1,184,96,120,154,145,47,148,44,99,101,29,244,217,172,48,46,176,46,74,239,185,200,177,138,66,112,235,214,210,95,145,165,147,29,14,124,98,71,25,37,76,141,223,53,229,220,140,19,93,97,37,77,16,24,233,223,150,222,9,78,117,140,215,120,155,78,225,66,103,24,128,109,156,143,130,67,160,47,56,107,249,59,214,73,69,177,73,5,16,84,165,117,51,70,245,120,186,63,12,220,162,81,43,223,29,180,215,251,215,239,38,211,122,33,51,188,160,41,86,92,156,208,25,63,81,188,176,177,149,39,56,73,124,117,87,60,58,195,23,11,8,186,212,193,159,253,64,49,77,25,206,60,217,198,80,105,236,14,166,135,131,9,22,41,81,62,54,239,170,62,246,233,214,60,237,182,242,5,179,164,44,225,75,4,117,3,119,80,251,231,223,24,212,75,149,85,71,81,59,250,64,24,17,160,218,61,24,27,226,72,215,240,32,96,101,150,245,251,181,247,142,187,42,20,129,92,237,105,212,71,16,52,211,32,94,198,233,170,111,21,180,92,232,144,244,200,103,98,82,96,161,243,22,117,191,96,232,204,44,245,64,215,208,187,170,209,182,121,157,94,235,242,159,91,250,20,48,183,224,112,56,216,236,171,54,110,241,237,152,13,104,152,36,209,3,186,223,56,246,180,230,212,174,2,136,139,205,159,13,164,185,121,196,192,239,117,141,250,132,72,40,114,216,99,228,4,178,74,103,70,182,239,140,142,77,229,198,223,234,240,96,206,161,31,102,119,65,164,243,80,216,150,48,11,144,178,174,189,104,103,176,30,88,129,93,47,102,144,213,236,144,150,117,106,158,181,219,195,221,85,179,170,13,126,118,238,25,221,205,77,39,231,115,13,155,114,158,5,84,222,20,25,199,93,160,23,26,164,215,72,141,234,137,27,180,102,171,89,253,143,91,34,187,183,200,94,107,100,247,244,223,103,211,56,199,54,84,113,229,54,154,240,216,88,71,225,85,216,111,209,219,237,210,5,110,59,220,206,154,59,104,162,118,76,220,235,146,53,118,122,184,195,250,113,83,118,155,12,40,252,79,80,40,151,88,254,232,204,214,154,197,184,42,45,95,101,198,226,127,143,242,45,61,219,219,48,92,254,215,248,95,5,4,10,186,217,70,241,223,152,223,189,6,211,246,38,169,96,166,44,66,29,170,5,85,247,15,231,183,97,112,28,172,17,54,155,162,131,109,107,131,199,251,44,132,54,161,237,151,141,253,179,134,28,241,204,132,209,252,162,247,130,231,67,145,78,163,167,131,103,131,179,179,193,233,203,87,93,178,63,210,36,33,172,33,227,175,173,213,102,185,197,141,53,247,7,125,81,115,184,81,104,213,249,190,29,242,47,202,125,93,157,173,249,109,203,27,46,55,133,65,75,209,41,101,10,184,70,119,152,165,36,217,242,191,208,198,39,28,246,33,205,79,218,227,225,252,55,193,128,181,165,199,14,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCallContextMenuItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dac805a1-3beb-4253-aba6-331bb376a5ba"),
				Name = "CallContextMenuItem",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuItem"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eb3c57bb-8189-40fc-8a55-7158ebd7c251"),
				Name = "caption",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f4fc66d9-bf9e-42ec-8bfa-bb7c29bd32d9"),
				Name = "tag",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,65,75,195,64,16,133,239,130,255,33,228,148,130,44,222,139,7,109,107,9,216,80,104,212,163,76,147,233,26,187,217,149,217,73,83,17,255,187,179,73,91,26,42,158,118,152,247,222,55,236,204,14,40,170,209,54,41,99,29,221,69,22,219,40,71,34,240,110,195,234,57,85,175,184,158,56,203,228,140,87,167,98,113,8,36,163,241,245,213,78,8,18,75,75,137,207,155,170,84,25,182,225,237,196,35,90,80,101,143,79,203,243,118,58,149,174,103,170,172,86,143,142,106,224,36,158,128,49,199,9,111,223,183,63,241,77,159,83,185,91,117,206,36,206,226,209,128,62,129,79,174,156,21,86,209,87,231,98,14,90,4,6,61,72,16,2,99,249,240,117,255,1,251,32,83,131,231,250,204,194,218,224,75,133,237,138,197,40,142,13,24,63,176,132,228,108,135,150,101,51,166,42,182,106,245,238,218,39,7,229,2,252,246,15,228,165,191,210,22,76,6,117,192,199,75,114,5,122,31,126,31,22,141,123,14,169,206,25,255,139,57,53,114,32,141,124,184,82,183,217,37,104,84,57,33,206,73,14,35,118,113,165,83,161,17,114,67,246,116,249,241,47,144,220,247,243,7,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetContactPhoneNumbersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a270e1bf-bf7f-4f05-a741-e8349c56374b"),
				Name = "GetContactPhoneNumbers",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string[]"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("79a7ade2-5889-4c4d-9d6f-2ab86b10f23e"),
				Name = "contactId",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,45,46,205,41,81,176,85,200,75,45,87,240,201,44,46,177,41,46,41,202,204,75,183,211,208,180,230,229,42,74,45,41,45,202,131,42,210,11,201,119,44,42,74,172,4,202,0,0,114,155,68,31,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAccountPhoneNumbersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f1bd588f-3441-4deb-b9b0-c0f52d2f1922"),
				Name = "GetAccountPhoneNumbers",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string[]"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d1ded138-fd23-4724-9da3-dc3e9548249e"),
				Name = "accountId",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,45,46,205,41,81,176,85,200,75,45,87,240,201,44,46,177,41,46,41,202,204,75,183,211,208,180,230,229,42,74,45,41,45,202,131,42,210,11,201,119,44,42,74,172,4,202,0,0,114,155,68,31,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterTreeGridDblClickScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1e1e212b-87b5-40f4-ae72-3260923b856f"),
				Name = "GetRegisterTreeGridDblClickScript",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6a1622b0-b76d-4d19-99d4-512c4faae1d4"),
				Name = "defaultScript",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,73,77,75,44,205,41,9,78,46,202,44,40,177,6,0,91,46,68,177,21,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateModifyModuleProcessParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("93d64a05-57d6-4584-92f2-82d108ba53df"),
				Name = "ModifyModuleProcessParameters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("492e0730-ede0-43c8-8fde-985dd8f14e1b"),
				Name = "process",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateFillPrintMenuMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0e897cb0-dc24-4573-bf42-04f61ca33201"),
				Name = "FillPrintMenu",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,87,91,83,226,72,20,126,198,42,255,67,111,30,172,80,146,148,34,138,174,235,238,66,0,203,170,209,181,12,142,15,179,83,86,27,90,204,76,232,78,117,58,58,172,195,127,223,211,151,64,18,18,212,151,121,80,224,244,119,190,115,239,156,60,99,142,30,82,33,24,69,103,232,26,79,137,123,205,67,42,250,74,116,186,189,245,12,231,51,66,83,56,213,48,247,18,126,193,129,20,186,55,100,198,158,73,47,138,236,38,136,194,71,100,43,236,111,103,136,166,81,132,118,118,144,63,79,46,217,36,141,200,197,68,138,207,211,112,226,14,103,177,152,55,209,235,246,86,35,17,96,109,138,146,128,135,177,0,27,250,183,70,0,99,67,82,94,24,134,107,206,2,146,36,36,25,167,20,64,32,36,154,164,145,57,121,33,200,12,72,40,121,65,119,228,193,99,84,112,22,37,202,99,121,164,156,108,52,50,164,235,113,130,5,153,244,231,189,111,248,7,232,9,158,146,34,98,72,241,67,68,62,135,228,197,23,0,5,204,35,142,146,18,232,10,207,200,202,245,17,227,51,44,108,235,117,111,113,175,13,92,145,23,227,186,213,202,146,232,69,33,161,226,98,80,242,232,22,178,100,146,4,90,242,179,236,243,24,79,1,97,173,49,151,34,195,177,8,85,73,203,192,44,23,6,225,126,198,81,57,232,139,153,108,3,159,165,60,144,113,141,9,231,56,97,143,2,188,115,243,105,53,95,20,92,163,161,31,18,245,229,18,83,16,242,42,222,18,196,36,207,90,89,1,19,189,56,182,54,233,74,81,166,72,241,115,56,197,130,113,39,12,152,35,88,172,51,156,56,120,50,113,99,58,45,17,201,82,15,159,33,247,137,172,65,240,221,245,195,41,197,81,198,182,76,215,178,111,111,72,204,184,88,166,77,234,188,69,185,20,140,49,159,18,145,229,105,176,154,161,172,252,138,168,220,252,89,7,189,132,116,194,94,92,104,36,56,123,221,95,156,254,75,161,129,86,53,54,28,57,209,57,161,132,131,255,198,162,175,136,109,217,214,45,53,144,205,102,222,224,110,85,207,186,224,176,12,214,110,186,144,64,53,53,153,31,251,139,166,118,161,20,68,133,79,31,181,227,147,24,115,89,68,187,218,132,230,147,99,158,100,72,51,231,111,117,167,158,254,60,191,242,44,251,189,97,120,1,115,15,49,91,173,250,112,165,114,153,240,173,43,195,237,77,38,246,18,222,44,202,51,102,45,86,215,49,136,77,29,117,58,213,209,98,123,11,254,203,124,224,56,246,112,240,36,237,220,38,132,67,212,148,4,106,178,125,152,118,248,84,167,238,93,40,158,62,177,0,71,242,39,68,106,143,125,128,62,134,211,20,220,144,104,5,187,21,97,20,138,144,36,238,29,227,223,147,24,7,68,201,207,57,75,99,101,88,154,228,106,34,18,143,69,145,54,37,47,137,50,29,155,205,24,93,241,157,19,225,19,9,31,96,129,109,25,92,209,219,214,123,24,242,3,153,104,186,214,50,1,21,12,197,144,140,158,146,170,88,204,179,39,208,55,33,132,147,206,168,105,135,119,56,243,41,248,111,165,98,151,163,177,74,247,7,180,180,101,174,92,171,148,72,31,252,153,97,115,29,174,151,81,102,46,143,176,173,155,117,53,171,137,112,146,155,5,19,171,91,1,205,140,199,242,214,254,168,233,235,178,82,217,112,105,8,215,240,210,250,90,255,192,179,134,11,123,2,5,133,139,156,216,131,80,73,49,159,255,161,75,212,66,236,225,27,64,255,68,241,126,11,109,58,110,195,66,128,100,119,113,34,82,78,1,255,101,173,188,95,221,49,243,149,34,220,61,80,88,152,68,50,102,118,220,222,12,109,158,46,100,225,128,252,145,193,67,34,120,66,246,170,134,40,164,235,99,97,150,19,249,20,71,73,110,13,210,23,151,122,184,107,157,47,86,238,216,42,26,149,12,114,9,202,239,81,103,103,121,62,99,230,131,75,144,118,75,219,127,195,167,27,3,170,240,76,179,136,121,92,19,151,62,169,82,44,14,31,232,26,149,141,53,40,168,62,145,40,150,209,145,31,58,128,204,102,65,110,173,171,203,108,102,30,231,92,182,14,218,163,110,219,59,241,28,248,223,117,58,157,225,158,115,236,29,119,156,131,142,119,50,28,236,119,189,222,225,158,213,204,178,157,207,159,238,240,219,218,52,222,20,81,85,233,88,118,201,63,42,252,100,53,56,183,133,224,106,16,214,87,25,203,160,127,5,15,121,189,210,161,191,114,187,54,250,189,210,175,106,166,10,231,100,202,42,46,43,119,4,155,129,236,169,254,28,52,237,82,50,154,185,215,0,77,211,176,107,3,204,191,25,160,159,63,215,111,167,146,173,26,162,165,205,85,157,26,185,153,208,219,221,114,18,76,175,181,202,101,204,101,192,112,52,118,209,223,214,142,133,118,235,74,148,83,65,75,108,161,19,91,25,149,165,94,176,138,107,229,189,181,155,141,226,138,201,130,71,69,75,189,148,100,117,88,168,143,5,34,176,80,160,186,62,62,238,123,237,195,147,225,200,233,180,187,71,78,231,100,239,200,233,119,123,71,78,251,96,224,29,158,244,135,221,209,176,157,235,227,119,167,103,205,53,19,80,117,60,16,126,93,68,106,31,50,33,233,136,106,246,159,95,191,25,255,178,213,120,195,110,167,114,34,255,234,162,151,174,200,27,18,26,139,10,239,9,211,41,153,108,218,155,107,77,45,254,7,146,80,2,5,253,15,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateMenuItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8de24b7e-30c2-49d4-92d6-6326a77da296"),
				Name = "CreateMenuItem",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuItem"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2d4cbe59-65d1-4bbf-b097-7167d22de462"),
				Name = "MenuItemCaption",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fca9366e-838b-41b9-bbff-7fa715a93939"),
				Name = "MenuItemTag",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("56108e3b-26b1-44b8-8099-90a88a6673eb"),
				Name = "menuID",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4ac4cf99-2f3d-4709-8936-3ba5decb81d9"),
				Name = "isDevExpressReport",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,77,79,195,48,12,134,207,155,212,255,16,118,218,164,41,2,36,152,196,132,208,190,64,61,108,76,108,99,231,148,122,85,160,77,42,199,237,134,16,255,29,183,251,44,19,156,146,248,125,236,248,141,147,43,20,65,70,100,141,184,23,83,21,129,156,162,54,212,47,67,93,175,238,213,115,38,18,48,153,79,144,48,99,96,45,230,128,168,156,93,145,92,248,114,9,193,192,26,66,27,59,121,216,140,119,9,205,22,215,216,103,75,127,200,5,202,211,176,91,59,137,47,252,144,133,167,76,135,114,2,235,98,173,230,13,84,74,186,236,112,95,119,23,169,64,8,138,32,236,127,246,222,213,134,81,194,12,78,245,145,81,65,12,175,26,214,51,98,144,137,149,138,93,5,41,50,71,57,24,98,39,177,126,251,56,6,230,10,35,160,157,189,210,198,246,209,10,142,101,246,115,222,238,192,198,22,153,44,87,249,136,54,233,97,20,52,47,219,215,237,78,167,125,117,115,91,241,56,87,209,137,63,62,253,219,216,76,71,70,197,19,149,20,62,180,27,66,62,218,164,8,206,189,64,106,145,196,131,104,60,167,96,202,89,254,22,199,188,227,65,55,196,157,104,108,31,109,60,91,90,12,171,42,95,175,87,162,121,113,94,188,37,190,188,122,237,239,222,124,183,72,99,171,194,227,12,190,139,127,132,64,25,154,195,87,234,254,0,253,140,177,222,122,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOpenReportPageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c43fdf70-a204-4fb9-b4e6-fb11754d718f"),
				Name = "OpenReportPage",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("26711f41-8fc1-470c-a491-3e156d6ef8ff"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,78,173,244,75,204,77,85,176,85,80,10,40,202,204,43,9,74,45,200,47,42,9,72,44,2,10,150,164,22,21,43,89,115,133,22,167,22,57,231,231,229,165,38,151,100,230,231,233,5,167,22,23,3,105,151,196,146,196,104,168,238,88,160,246,2,184,22,107,0,199,200,105,138,88,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetContextMenuItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("799f2dea-fad3-477d-bb42-7c33998768b2"),
				Name = "GetContextMenuItem",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuItem"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("981f6fd2-87ae-4be5-a7a5-14a7d1e40617"),
				Name = "itemName",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7b5bd184-5b37-4eb2-bddf-a8c929e4d5a4"),
				Name = "caption",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4fc7015b-0a66-444c-af98-c841dbe5f97e"),
				Name = "tag",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,79,107,2,49,16,197,239,126,138,101,79,10,18,218,179,244,208,170,149,133,42,130,219,246,88,70,119,76,83,119,147,50,153,221,181,136,223,189,19,255,17,88,240,148,97,230,189,95,200,155,52,64,73,133,182,206,24,171,228,41,177,216,38,57,18,129,119,91,86,239,153,250,196,245,216,89,38,87,122,117,43,230,23,67,127,48,234,53,2,16,87,86,136,123,86,155,66,45,176,13,103,152,93,193,2,42,206,240,172,136,186,217,68,154,158,201,88,173,94,29,85,192,253,244,240,112,188,210,191,14,143,199,116,152,24,41,23,80,225,240,236,87,185,91,157,44,253,116,145,14,226,75,198,240,203,198,89,97,110,206,85,52,203,65,75,159,65,199,122,66,96,44,94,254,158,127,96,31,166,84,99,52,158,90,88,151,248,97,176,93,177,232,68,176,133,210,199,138,224,155,54,104,89,162,41,205,102,167,86,223,174,125,115,80,204,193,239,186,192,174,220,104,11,101,120,91,55,135,37,185,13,122,47,113,132,212,113,207,1,113,178,69,145,12,238,209,111,141,28,72,35,95,150,119,202,124,9,26,85,78,136,51,146,133,137,92,84,217,100,212,35,228,154,236,237,63,140,254,1,37,248,228,39,29,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearMenuItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cf0322c0-6485-464f-8e56-3d2734923cd8"),
				Name = "ClearMenuItems",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1c644da9-6939-4fb2-b49e-8b49edc4deba"),
				Name = "menuItem",
				CreatedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				ModifiedInSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "MenuItemBase",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,193,10,194,48,12,134,239,130,239,16,118,106,65,202,238,67,97,76,132,29,6,130,79,80,214,216,21,218,84,186,232,101,236,221,173,155,59,232,37,144,252,95,254,63,25,57,57,178,208,123,212,169,67,122,222,250,228,30,12,71,24,23,65,93,98,10,154,69,225,238,32,166,114,86,22,249,131,9,169,28,99,24,191,213,35,89,30,224,4,165,156,38,248,229,18,134,248,194,218,123,33,171,121,134,205,40,33,25,76,104,182,133,72,77,36,70,226,102,208,100,209,44,116,113,128,144,93,218,28,162,26,239,178,218,158,101,181,223,93,181,69,181,158,218,105,202,77,82,181,49,235,64,252,253,34,171,55,122,95,129,109,228,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"));
		}

		#endregion

	}

	#endregion

}

