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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: BaseVirtualGridPageSchema

	/// <exclude/>
	public class BaseVirtualGridPageSchema : Terrasoft.UI.WebControls.PageSchema
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

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer {
			get {
				return _spacer;
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

		#endregion

		#region Constructors: Public

		public BaseVirtualGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseVirtualGridPageSchema(BaseVirtualGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			RealUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			Name = "BaseVirtualGridPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseVirtualGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateButtonsControlLayout());
			ButtonsControlLayout.InsertItem(0, CreateAddButton());
			ButtonsControlLayout.InsertItem(1, CreateCopyButton());
			ButtonsControlLayout.InsertItem(2, CreateEditButton());
			ButtonsControlLayout.InsertItem(3, CreateDeleteButton());
			ButtonsControlLayout.InsertItem(4, CreateSpacer());
			ButtonsControlLayout.InsertItem(5, CreatePrintButton());
			ButtonsControlLayout.InsertItem(6, CreateContextHelpButton());
			Controls.AddAt(1, CreateTreeGrid());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseVirtualGridPageEventsProcessSchema() {
			var schema = new BaseVirtualGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddButton() {
			_addButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addButton.UId = new Guid("5ff3d2eb-b28a-427d-a5b7-642f6c779c3e");
			_addButton.Name = "AddButton";
			_addButton.CreatedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_addButton.ModifiedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_addButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addButton.Tag = "";
			_addButton.Image = new ControlImage {};
			_addButton.Enabled = false;
			return _addButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCopyButton() {
			_copyButton = new Terrasoft.UI.WebControls.Controls.Button();
			_copyButton.UId = new Guid("3baa3b56-7fd4-4060-866a-15ed1fc2bd63");
			_copyButton.Name = "CopyButton";
			_copyButton.CreatedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_copyButton.ModifiedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_copyButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_copyButton.Tag = "";
			_copyButton.Image = new ControlImage {};
			_copyButton.Enabled = false;
			return _copyButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateEditButton() {
			_editButton = new Terrasoft.UI.WebControls.Controls.Button();
			_editButton.UId = new Guid("b3a00be5-6884-4e8c-9eaf-61aceda7f822");
			_editButton.Name = "EditButton";
			_editButton.CreatedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_editButton.ModifiedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_editButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_editButton.Tag = "";
			_editButton.Image = new ControlImage {};
			_editButton.Enabled = false;
			return _editButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteButton() {
			_deleteButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteButton.UId = new Guid("494666ae-fbae-4d75-aaf3-26eef2b569ae");
			_deleteButton.Name = "DeleteButton";
			_deleteButton.CreatedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_deleteButton.ModifiedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_deleteButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_deleteButton.Tag = "";
			_deleteButton.Image = new ControlImage {};
			_deleteButton.Enabled = false;
			return _deleteButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer() {
			_spacer = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer.UId = new Guid("a34927a5-75ac-4394-af72-be7c77d39527");
			_spacer.Name = "Spacer";
			_spacer.CreatedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_spacer.ModifiedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_spacer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer.Tag = "";
			_spacer.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreatePrintButton() {
			_printButton = new Terrasoft.UI.WebControls.Controls.Button();
			_printButton.UId = new Guid("e60e401e-ce46-4075-a461-408e95cd8141");
			_printButton.Name = "PrintButton";
			_printButton.CreatedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_printButton.ModifiedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_printButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_printButton.Tag = "";
			_printButton.Image = new ControlImage {};
			_printButton.Hidden = true;
			return _printButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("0aab7b1a-52b9-4a9e-9121-ea14d86f4538");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonsControlLayout() {
			_buttonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonsControlLayout.UId = new Guid("e274f255-6678-48ca-983d-0044bcd125e4");
			_buttonsControlLayout.Name = "ButtonsControlLayout";
			_buttonsControlLayout.CreatedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_buttonsControlLayout.ModifiedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
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

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateTreeGrid() {
			_treeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_treeGrid.UId = new Guid("b3b22f3e-3a69-4c22-869e-338a4ce6dc06");
			_treeGrid.Name = "TreeGrid";
			_treeGrid.CreatedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_treeGrid.ModifiedInSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			_treeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_treeGrid.Tag = "";
			_treeGrid.Edges = "";
			_treeGrid.IsColumnAutowidth = true;
			_treeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_treeGrid.IsSummaryVisible = false;
			_treeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_treeGrid.HideHeaders = false;
			return _treeGrid;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseVirtualGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseVirtualGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseVirtualGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseVirtualGridPageEventsProcess

	/// <exclude/>
	public class BaseVirtualGridPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl
	{

		private TPage _page;
		public TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public BaseVirtualGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseVirtualGridPageEventsProcess";
			SchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
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

		public virtual Object DataSourceFilter {
			get;
			set;
		}

		public virtual string ListenerPageProcessUId {
			get;
			set;
		}

		public virtual bool LocatedInEditPage {
			get;
			set;
		}

		public virtual bool IsContextHelpButtonInitialized {
			get;
			set;
		}

		public virtual Object EditPageHelpContextId {
			get;
			set;
		}

		public virtual Guid SelectedNodePrimaryColumnValue {
			get;
			set;
		}

		public virtual bool IsDetailGrid {
			get;
			set;
		}

		public virtual string DataSourceClientID {
			get;
			set;
		}

		public virtual bool UseModuleDetails {
			get;
			set;
		}

		public virtual Guid SysEntitySchemaId {
			get;
			set;
		}

		public virtual bool AddToMenuItemMoveTo {
			get;
			set;
		}

		public virtual Object FilterLeftExpression {
			get;
			set;
		}

		public virtual string ParentColumnMetaPath {
			get;
			set;
		}

		public virtual Object DataSource {
			get;
			set;
		}

		public virtual Guid EditPageUId {
			get;
			set;
		}

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual Guid SysModuleEditId {
			get;
			set;
		}

		public virtual Guid SysModuleDetailId {
			get;
			set;
		}

		public virtual Guid SysModuleId {
			get;
			set;
		}

		public virtual bool IsModuleProcessesTuningMode {
			get;
			set;
		}

		private string _menuHelpItemCaption;
		public virtual string MenuHelpItemCaption {
			get {
				return _menuHelpItemCaption ?? (_menuHelpItemCaption = new LocalizableString(Storage, "dbe94191fb4c4c41b1eb37ac77da867d",
						 "EventsProcessSchema.Parameters.MenuHelpItemCaption.Value"));
			}
			set {
				_menuHelpItemCaption = value;
			}
		}

		private string _menuVideoHelpItemCaption;
		public virtual string MenuVideoHelpItemCaption {
			get {
				return _menuVideoHelpItemCaption ?? (_menuVideoHelpItemCaption = new LocalizableString(Storage, "dbe94191fb4c4c41b1eb37ac77da867d",
						 "EventsProcessSchema.Parameters.MenuVideoHelpItemCaption.Value"));
			}
			set {
				_menuVideoHelpItemCaption = value;
			}
		}

		private ProcessFlowElement _eventSubProcessPageLoadComplete;
		public ProcessFlowElement EventSubProcessPageLoadComplete {
			get {
				return _eventSubProcessPageLoadComplete ?? (_eventSubProcessPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessPageLoadComplete",
					SchemaElementUId = new Guid("b115cba1-6825-4735-9518-628c5728206e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startPageLoadComplete;
		public ProcessFlowElement StartPageLoadComplete {
			get {
				return _startPageLoadComplete ?? (_startPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartPageLoadComplete",
					SchemaElementUId = new Guid("d5ecf09f-4747-4c64-b73f-33748254476f"),
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
					SchemaElementUId = new Guid("272bbd9e-86bc-4f6d-8ee8-e4a335cb57bd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessPageLoad;
		public ProcessFlowElement EventSubProcessPageLoad {
			get {
				return _eventSubProcessPageLoad ?? (_eventSubProcessPageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessPageLoad",
					SchemaElementUId = new Guid("fd1f78af-c9d3-4afd-8332-42c68689f6b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startPageLoad;
		public ProcessFlowElement StartPageLoad {
			get {
				return _startPageLoad ?? (_startPageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartPageLoad",
					SchemaElementUId = new Guid("57b8cf87-6ff2-4903-acf6-62834a36955a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoad;
		public ProcessScriptTask ScriptPageLoad {
			get {
				return _scriptPageLoad ?? (_scriptPageLoad = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoad",
					SchemaElementUId = new Guid("392fe560-11fa-4a93-8be6-e049c5f4a90e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessInit;
		public ProcessFlowElement EventSubProcessInit {
			get {
				return _eventSubProcessInit ?? (_eventSubProcessInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInit",
					SchemaElementUId = new Guid("d5a680f8-65e7-404c-bedf-59fc701e6e0e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startInit;
		public ProcessFlowElement StartInit {
			get {
				return _startInit ?? (_startInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartInit",
					SchemaElementUId = new Guid("db411fec-3edd-4168-876f-d1f3616b1b50"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInit;
		public ProcessScriptTask ScriptInit {
			get {
				return _scriptInit ?? (_scriptInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInit",
					SchemaElementUId = new Guid("3a9b05ea-2998-41a2-9dcb-6acf5ed066b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDeletYesMessage;
		public ProcessFlowElement EventSubProcessDeletYesMessage {
			get {
				return _eventSubProcessDeletYesMessage ?? (_eventSubProcessDeletYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDeletYesMessage",
					SchemaElementUId = new Guid("7cb14d3e-365c-4b08-b317-aaafec8d8740"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startDeleteYesMessage;
		public ProcessFlowElement StartDeleteYesMessage {
			get {
				return _startDeleteYesMessage ?? (_startDeleteYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartDeleteYesMessage",
					SchemaElementUId = new Guid("463ef591-cba0-4795-92ed-b2a3f6f86432"),
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
					SchemaElementUId = new Guid("75b01c36-3ee7-40fd-811e-4da36593e0da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteYesMessageExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessGridPageRefreshRow;
		public ProcessFlowElement EventSubProcessGridPageRefreshRow {
			get {
				return _eventSubProcessGridPageRefreshRow ?? (_eventSubProcessGridPageRefreshRow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessGridPageRefreshRow",
					SchemaElementUId = new Guid("36c684f1-5dd3-468a-8bc7-dfd0cfa8d7aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startGridPageRefreshRow;
		public ProcessFlowElement StartGridPageRefreshRow {
			get {
				return _startGridPageRefreshRow ?? (_startGridPageRefreshRow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartGridPageRefreshRow",
					SchemaElementUId = new Guid("a9fcb272-c865-4b45-97b3-8d9da93671da"),
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
					SchemaElementUId = new Guid("8ea74fc5-2a4f-464c-a8e6-016181a14e20"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGridPageRefreshRowExecute,
				});
			}
		}

		private LocalizableString _questionCaption;
		public LocalizableString QuestionCaption {
			get {
				return _questionCaption ?? (_questionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.QuestionCaption.Value"));
			}
		}

		private LocalizableString _deleteRecordMessage;
		public LocalizableString DeleteRecordMessage {
			get {
				return _deleteRecordMessage ?? (_deleteRecordMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteRecordMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPageLoadComplete };
			FlowElements[StartPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartPageLoadComplete };
			FlowElements[ScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadComplete };
			FlowElements[EventSubProcessPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPageLoad };
			FlowElements[StartPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { StartPageLoad };
			FlowElements[ScriptPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoad };
			FlowElements[EventSubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInit };
			FlowElements[StartInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartInit };
			FlowElements[ScriptInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInit };
			FlowElements[EventSubProcessDeletYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDeletYesMessage };
			FlowElements[StartDeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDeleteYesMessage };
			FlowElements[ScriptDeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteYesMessage };
			FlowElements[EventSubProcessGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessGridPageRefreshRow };
			FlowElements[StartGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { StartGridPageRefreshRow };
			FlowElements[ScriptGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGridPageRefreshRow };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessPageLoadComplete":
						break;
					case "StartPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadComplete");
						break;
					case "ScriptPageLoadComplete":
						break;
					case "EventSubProcessPageLoad":
						break;
					case "StartPageLoad":
						e.Context.QueueTasks.Enqueue("ScriptPageLoad");
						break;
					case "ScriptPageLoad":
						break;
					case "EventSubProcessInit":
						break;
					case "StartInit":
						e.Context.QueueTasks.Enqueue("ScriptInit");
						break;
					case "ScriptInit":
						break;
					case "EventSubProcessDeletYesMessage":
						break;
					case "StartDeleteYesMessage":
						e.Context.QueueTasks.Enqueue("ScriptDeleteYesMessage");
						break;
					case "ScriptDeleteYesMessage":
						break;
					case "EventSubProcessGridPageRefreshRow":
						break;
					case "StartGridPageRefreshRow":
						e.Context.QueueTasks.Enqueue("ScriptGridPageRefreshRow");
						break;
					case "ScriptGridPageRefreshRow":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartPageLoadComplete");
			ActivatedEventElements.Add("StartPageLoad");
			ActivatedEventElements.Add("StartInit");
			ActivatedEventElements.Add("StartDeleteYesMessage");
			ActivatedEventElements.Add("StartGridPageRefreshRow");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartPageLoadComplete";
					result = StartPageLoadComplete.Execute(context);
					break;
				case "ScriptPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadComplete";
					result = ScriptPageLoadComplete.Execute(context, ScriptPageLoadCompleteExecute);
					break;
				case "EventSubProcessPageLoad":
					context.QueueTasks.Dequeue();
					break;
				case "StartPageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartPageLoad";
					result = StartPageLoad.Execute(context);
					break;
				case "ScriptPageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoad";
					result = ScriptPageLoad.Execute(context, ScriptPageLoadExecute);
					break;
				case "EventSubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "StartInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartInit";
					result = StartInit.Execute(context);
					break;
				case "ScriptInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInit";
					result = ScriptInit.Execute(context, ScriptInitExecute);
					break;
				case "EventSubProcessDeletYesMessage":
					context.QueueTasks.Dequeue();
					break;
				case "StartDeleteYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDeleteYesMessage";
					result = StartDeleteYesMessage.Execute(context);
					break;
				case "ScriptDeleteYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDeleteYesMessage";
					result = ScriptDeleteYesMessage.Execute(context, ScriptDeleteYesMessageExecute);
					break;
				case "EventSubProcessGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					break;
				case "StartGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartGridPageRefreshRow";
					result = StartGridPageRefreshRow.Execute(context);
					break;
				case "ScriptGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGridPageRefreshRow";
					result = ScriptGridPageRefreshRow.Execute(context, ScriptGridPageRefreshRowExecute);
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
				case "MenuVideoHelpItemCaption":
					MenuVideoHelpItemCaption = reader.GetValue<System.String>();
				break;
				case "MenuHelpItemCaption":
					MenuHelpItemCaption = reader.GetValue<System.String>();
				break;
				case "IsModuleProcessesTuningMode":
					IsModuleProcessesTuningMode = reader.GetValue<System.Boolean>();
				break;
				case "SysModuleId":
					SysModuleId = reader.GetValue<System.Guid>();
				break;
				case "SysModuleDetailId":
					SysModuleDetailId = reader.GetValue<System.Guid>();
				break;
				case "SysModuleEditId":
					SysModuleEditId = reader.GetValue<System.Guid>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "EditPageUId":
					EditPageUId = reader.GetValue<System.Guid>();
				break;
				case "DataSource":
					DataSource = reader.GetSerializableObjectValue();
				break;
				case "ParentColumnMetaPath":
					ParentColumnMetaPath = reader.GetValue<System.String>();
				break;
				case "FilterLeftExpression":
					FilterLeftExpression = reader.GetSerializableObjectValue();
				break;
				case "AddToMenuItemMoveTo":
					AddToMenuItemMoveTo = reader.GetValue<System.Boolean>();
				break;
				case "SysEntitySchemaId":
					SysEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "UseModuleDetails":
					UseModuleDetails = reader.GetValue<System.Boolean>();
				break;
				case "DataSourceClientID":
					DataSourceClientID = reader.GetValue<System.String>();
				break;
				case "IsDetailGrid":
					IsDetailGrid = reader.GetValue<System.Boolean>();
				break;
				case "SelectedNodePrimaryColumnValue":
					SelectedNodePrimaryColumnValue = reader.GetValue<System.Guid>();
				break;
				case "EditPageHelpContextId":
					EditPageHelpContextId = reader.GetSerializableObjectValue();
				break;
				case "IsContextHelpButtonInitialized":
					IsContextHelpButtonInitialized = reader.GetValue<System.Boolean>();
				break;
				case "LocatedInEditPage":
					LocatedInEditPage = reader.GetValue<System.Boolean>();
				break;
				case "ListenerPageProcessUId":
					ListenerPageProcessUId = reader.GetValue<System.String>();
				break;
				case "DataSourceFilter":
					DataSourceFilter = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			PageLoadCompleteMethod();
			return true;
		}

		public virtual bool ScriptPageLoadExecute(ProcessExecutingContext context) {
			PageLoadMethod();
			return true;
		}

		public virtual bool ScriptInitExecute(ProcessExecutingContext context) {
			PageInitMethod();
			return true;
		}

		public virtual bool ScriptDeleteYesMessageExecute(ProcessExecutingContext context) {
			var dataSource = GetDataSource();
			var recordIds = new ObservableCollection<Guid>(dataSource.SelectedItemPrimaryColumnValues);
			foreach (var recordId in recordIds){
				RowsDeleteMethod(recordId);
				dataSource.Remove(recordId);
			}
			return true;
		}

		public virtual bool ScriptGridPageRefreshRowExecute(ProcessExecutingContext context) {
			FillData(null);
			return true;
		}

		public virtual bool GetIsContextHelpButtonHidden() {
			return true;
		}

		public virtual bool GetIsContextHelpEnabled() {
			return (bool)SysSettings.GetValue(UserConnection, "EnableContextHelp");
		}

		public virtual string GetRegisterQuetsionScript() {
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
													"') {window.Terrasoft.AjaxMethods.ThrowClientEvent('" + 
													processInstanceId + "','" + responseMessage.Value + "');} else ");
			}
			functionJsStringBuilder.Append("{window.Terrasoft.AjaxMethods.ThrowClientEvent('" + processInstanceId + 
											"','DefaultQuestionMessage');}}");
			return "Ext.MessageBox.message('" + QuestionCaption.ToString() + "','" + DeleteRecordMessage.ToString().Replace("'", @"\'") + "'," +
				buttonsJsString + "," + iconJsString + "," + functionJsStringBuilder.ToString() + ", this);";
		}

		public virtual void PageLoadMethod() {
		}

		public virtual void PageLoadCompleteMethod() {
			if (!IsContextHelpButtonInitialized) {
				Terrasoft.Configuration.VideoHelpUtilities.InitializeContextHelpButton(Page.ContextHelpButton, Page.Schema.HelpContextId, UserConnection);
				IsContextHelpButtonInitialized = true;
			}
		}

		public virtual void PageInitMethod() {
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			CreateDataSource();
			SetEntitySchemaUId("");
			PopulateEditPages();
			SubscribeOnControlEvents();
			if (!IsContextHelpButtonInitialized) {
				InitializeContextHelpButton();
				IsContextHelpButtonInitialized = true;
			}
		}

		public virtual void CreateDataSource() {
			var virtualDataSource = new VirtualDataSource() {
				ID = "VirtualDataSource"
			};
			Page.PageContainer.Controls.Add(virtualDataSource);
			DataSource = virtualDataSource;
			CreateDataSourceStructure();
			Page.TreeGrid.AjaxEvents.CellIconClick.Event += CellIconClickHandler;
			Page.TreeGrid.AjaxEvents.CellIconClick.ExtraParameters.Add(
				new Terrasoft.UI.WebControls.Controls.Parameter("nodeId", "nodeId", 
				Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			Page.TreeGrid.AjaxEvents.CellIconClick.ExtraParameters.Add(
				new Terrasoft.UI.WebControls.Controls.Parameter("iconId", "iconId", 
				Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			Page.TreeGrid.GetRowConfigHandler =	TreeGridConfigHandler;
			Page.TreeGrid.DataSourceId = virtualDataSource.ID; 
			virtualDataSource.Loaded += Page.TreeGrid.DataLoaded;
			virtualDataSource.AjaxEvents.Removed.ExtraParameters.Add(new Terrasoft.UI.WebControls.Controls.Parameter("request", 
				"request", Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			virtualDataSource.DataRequest += delegate(object sender, DataSourceEventArgs e) {
				FillData(e.Request);
			};
			virtualDataSource.LoadingRow += delegate(object sender, DataSourceEventArgs e) {
				Guid recordId = e.Request == null ? Guid.Empty : e.Request.PrimaryColumnValue;
				var dataSource = GetDataSource();
				dataSource.Rows.Add(GetEntity(recordId));
			};
		}

		public virtual VirtualDataSource GetDataSource() {
			return DataSource as VirtualDataSource;
		}

		public virtual void CreateDataSourceStructure() {
			var dataValueTypeManager = UserConnection.DataValueTypeManager;
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var dataSource = GetDataSource();
			var structure = dataSource.DefStructure;
			var structureItems = GetStructureDefinition();
			foreach (var item in structureItems) {
				var column = new DataSourceStructureColumn {
						Name = item["Name"].ToString(),
						ValueColumnName = item["ValueColumnName"].ToString(),
						DisplayColumnName = item["DisplayColumnName"].ToString(),
						DataValueType = dataValueTypeManager.GetInstanceByName(item["DataValueType"].ToString()),
						Caption = item["Caption"].ToString(),
						IsVisible = bool.Parse(item["IsVisible"].ToString()),
						IsSortable = bool.Parse(item["IsSortable"].ToString())
				};
				if (item.ContainsKey("ReferenceSchemaName")) {
					var referenceSchema = entitySchemaManager.GetInstanceByName(item["ReferenceSchemaName"].ToString());
					column.ReferenceSchemaName = item["ReferenceSchemaName"].ToString();
					column.ReferenceSchemaUId = referenceSchema.UId;
					column.ReferenceSchemaPrimaryColumnName = referenceSchema.GetPrimaryColumnName();
					column.ReferenceSchemaPrimaryDisplayColumnName = referenceSchema.GetPrimaryDisplayColumnName();
				}
				if (item.ContainsKey("IsPrimaryColumn")) {
					if (bool.Parse(item["IsPrimaryColumn"].ToString())) {
						structure.PrimaryColumnName = column.Name;
					}
				}
				if (item.ContainsKey("IsPrimaryDisplayColumn")) {
					if (bool.Parse(item["IsPrimaryDisplayColumn"].ToString())) {
						structure.PrimaryDisplayColumnName = column.Name;
					}
				}
				if (item.ContainsKey("IsHierarchicalColumn")) {
					if (bool.Parse(item["IsHierarchicalColumn"].ToString())) {
						structure.HierarchicalColumnName = column.Name;
					}
				}
				structure.Columns.Add(column);
			}
		}

		public virtual DataSourceRowConfig TreeGridConfigHandler(Entity row) {
				var config = new DataSourceRowConfig(row.PrimaryColumnValue);		
				return config;
		}

		public virtual Entity GetEntity(Guid recordId) {
			var dataSource = GetDataSource();
			var select = CreateSelect();
			select = select.And(select.SourceExpression.SchemaName, dataSource.DefStructure.PrimaryColumnName).IsEqual(Column.Parameter(recordId)) as Select;
			var entities = GetEntities(select);
			if (entities.Count == 1) {
				return entities[0];
			} else {
				return null;
			}
		}

		public virtual List<Entity> GetEntities(Select select) {
			var dataSource = GetDataSource();
			var structure = dataSource.DefStructure;
			List<Entity> entities = new List<Entity>();
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						var row = dataSource.CreateRow();
						foreach (var column in structure.Columns) {
							int ordinal = reader.GetOrdinal(column.ValueColumnName);
							var columnValue = column.DataValueType.GetValueForLoad(UserConnection, reader.GetValue(ordinal));
							row.SetColumnValue(column.ValueColumnName, columnValue);
							if (!string.IsNullOrEmpty(column.DisplayColumnName)) {
								ordinal = reader.GetOrdinal(column.DisplayColumnName);
								columnValue = column.DataValueType.GetDisplayValueForLoad(UserConnection, reader.GetValue(ordinal));
								row.SetColumnValue(column.DisplayColumnName, columnValue);
							}
						}
						entities.Add(row);
					}
				}
			}
			return entities;
		}

		public virtual void CellIconClickHandler(object sender, AjaxEventArgs e) {
		}

		public virtual List<string> GetButtons() {
			var result = new List<string>();
			result.Add(Page.AddButton.Name);
			result.Add(Page.EditButton.Name);
			result.Add(Page.CopyButton.Name);
			result.Add(Page.DeleteButton.Name);
			result.Add(Page.PrintButton.Name);
			return result;
		}

		public virtual void ActivateButtons(bool activate) {
			var buttons = GetButtons();
			var dataSourceRowsCount =
				GetDataSource().ActiveRowPrimaryColumnValue == Guid.Empty || !activate
				? 0 : 1;
			bool addButtonEnabledByRights = true;
			bool deleteButtonEnabledByRights = true;
			bool editButtonEnabledByRights = true;
			bool copyButtonEnabledByRights = true;
			if (EntitySchemaUId != Guid.Empty) {
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
				if (entitySchema != null) {
					var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
					string schemaName = entitySchema.Name;
					deleteButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaDeletingAllowed(schemaName);
					addButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
					copyButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
					editButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaEditingAllowed(schemaName);
				}
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

		public virtual bool RowsDeleteMethod(Guid recordId) {
			if (EntitySchemaUId == Guid.Empty) {
				return false;
			}
			
			var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			var entity = schema.CreateEntity(UserConnection);
			entity.PrimaryColumnValue = recordId;
			entity.StoringState = StoringObjectState.Deleted;
			return entity.Delete();
		}

		public virtual void ListenerThrowEvent(string processId, string eventName) {
			if (string.IsNullOrEmpty(processId)) {
				return;
			}
			var process = UserConnection.IProcessEngine.FindProcessByUId(processId);
			if (process != null) {
				process.ThrowEvent(process.InternalContext, eventName);
			}
		}

		public virtual void ListenerProcessSetProperty(string processId, string propertyName, object propertyValue) {
			if (string.IsNullOrEmpty(processId)) {
				return;
			}
			var process = UserConnection.IProcessEngine.GetProcessByUId(processId);
			process.SetPropertyValue(propertyName, propertyValue);
		}

		public virtual object ListenerProcessGetPropertyValue(string processId, string propertyName) {
			if (string.IsNullOrEmpty(processId)) {
				return null;
			}
			var process = UserConnection.IProcessEngine.GetProcessByUId(processId);
			return process.GetPropertyValue(propertyName);
		}

		public virtual Select CreateSelect() {
			return null;
		}

		public virtual List<Dictionary<string, object>> GetStructureDefinition() {
			List<Dictionary<string, object>> structure = new List<Dictionary<string, object>>();
			return structure;
		}

		public virtual void FillData(DataSourceRequest dataSourceRequest) {
			Page.TreeGrid.Clear();
			var dataSource = GetDataSource();
			dataSource.SuspendAjaxEvents();
			dataSource.Clear();
			dataSource.ResumeAjaxEvents();
			var select = CreateSelect();
			var entities = GetEntities(select);
			foreach (var entity in entities) {
				dataSource.Add(entity);
			}
			dataSource.LoadRows(dataSourceRequest);
		}

		public virtual string GetViewCode() {
			string code = string.Empty;
			var parentTab = Page.PageContainer.Parent as Tab;
			if (parentTab != null) {
				foreach (var item in parentTab.Menu) {
					var checkMenuItem = item as CheckMenuItem;
					if (checkMenuItem != null && checkMenuItem.Checked) {
						code = checkMenuItem.Tag;
						break;
					}
				}
			}
			return code;
		}

		public virtual void SubscribeOnControlEvents() {
			var dataSource = GetDataSource();
			dataSource.AjaxEvents.ActiveRowChanged.Event += (sender, e) => {
				BaseActiveRowChangedHandler();
			};
			dataSource.LoadRowsResponseRegistered += (sender, e) => {
				BaseLoadRowsResponseRegisteredHandler(sender, e);
			};
			if (EditPageUId != Guid.Empty) {
				Page.AddButton.AjaxEvents.Click.OnClientEvent = GetRegisterAddPageScript(EditPageUId, SysModuleEditId);
				Page.EditButton.AjaxEvents.Click.OnClientEvent = GetRegisterEditPageScript(EditPageUId, SysModuleEditId);
				Page.TreeGrid.AjaxEvents.DblClick.OnClientEvent = GetRegisterEditPageScript(EditPageUId, SysModuleEditId);
				Page.CopyButton.AjaxEvents.Click.OnClientEvent = GetRegisterCopyPageScript(EditPageUId, SysModuleEditId);
			}
			Page.DeleteButton.AjaxEvents.Click.OnClientEvent = GetRegisterQuetsionScript();
		}

		public virtual string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			var openPageParameters = new Dictionary<string, object>() {
					{"OpenerInstanceId", Page.Process.InstanceUId},		
				};
			
			var queryStringParameters = new Dictionary<string, string>() {
				{"recordId", GetDataSource().ClientID + ".activeRow.getPrimaryColumnValue()"},
				{"entitySchemaUId",string.Format("'{0}'", EntitySchemaUId)},
				{"treeGridId", string.Format("'{0}'", Page.TreeGrid.ClientID)},
				{"SysModuleEditId", string.Format("'{0}'", sysModuleEditId)}
			};
			ModifyEditPageParameters(openPageParameters, queryStringParameters);
			
			var sb = new StringBuilder();
			//var typeEditPageUIdScript = string.Format("{0}.getCustomData('typeId_' + {1}.activeRow.getColumnValue({0}.getCustomData('typeColumnName')).replace(/-/g, ''))", Page.AddButton.ClientID, GetDataSource().ClientID);
			sb.Append("Terrasoft.openWindow(");
			var sbCallback = new StringBuilder();
			var nullString = "null";
			var callbackString = "function(wnd) {{ {0} }}";
			var window = "wnd";
			sb.Append("'");
			sb.Append("ViewPage.aspx");	
			sb.Append("'");
			sb.Append(", ");
			//if (TypeColumnUId == Guid.Empty) {
				sb.Append("'");
				sb.Append(editPageUId.ToString());
				sb.Append("'");	
			/*} else {
				sb.Append(typeEditPageUIdScript);
			}*/
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
			/*	if (!parameter.Value.StartsWith("'") && parameter.Key != "recordId" && parameter.Key != "ParentEntityId") {
					sb.Append("'");
				}*/
				sb.Append(parameter.Value);
			/*	if (!parameter.Value.EndsWith("'") && parameter.Key != "recordId" && parameter.Key != "ParentEntityId") {
					sb.Append("'");
				}*/
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
			return string.Format("function() {{ if ({0}.activeRow) {{ {1} }} return true; }}()", GetDataSource().ClientID, sb.ToString());
		}

		public virtual void ModifyEditPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
		}

		public virtual void PopulateEditPages() {
			// Override to set EditPageUId
			var query = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModuleEdit");
			var sysModuleEditIdColumnName = query.AddColumn("Id").Name;
			var pageSchemaUIdColumnName = query.AddColumn("SysPageSchemaUId").Name;
			if (EditPageUId == Guid.Empty && SysModuleEditId == Guid.Empty && EntitySchemaUId != Guid.Empty) {
				query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"SysModuleEntity.SysEntitySchemaUId", EntitySchemaUId));
				var editPages = query.GetEntityCollection(UserConnection);
				foreach (var editPage in editPages) {
					EditPageUId = editPage.GetTypedColumnValue<Guid>(pageSchemaUIdColumnName);
					SysModuleEditId = editPage.GetTypedColumnValue<Guid>(sysModuleEditIdColumnName);
					break;
				}
			}
		}

		public virtual string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId) {
			var openPageParameters = new Dictionary<string, object>() {
					{"OpenerInstanceId", Page.Process.InstanceUId},		
				};
			
			var queryStringParameters = new Dictionary<string, string>() {
				{"recordId", string.Format("'{0}'", Guid.Empty)},
				{"entitySchemaUId",string.Format("'{0}'", EntitySchemaUId)},
				{"treeGridId", string.Format("'{0}'", Page.TreeGrid.ClientID)},
				{"SysModuleEditId", string.Format("'{0}'", sysModuleEditId)}
			};
			if (IsDetailGrid) {
				var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
				var dataSourceClientId = "window[Ext.decode(Ext.get('customDataField').dom.value)['SysModule_activeDataSource']]";
				queryStringParameters.Add("SysModuleDetailId", string.Format("'{0}'", SysModuleDetailId));
				queryStringParameters.Add("ParentEntityId", dataSourceClientId + ".activeRow.getPrimaryColumnValue()");
				queryStringParameters.Add("ParentEntitySchemaId", string.Format("'{0}'", SysEntitySchemaId));
				queryStringParameters.Add("UseModuleDetail", string.Format("'{0}'", UseModuleDetails));
			}
			ModifyAddPageParameters(openPageParameters, queryStringParameters);
			
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
			sb.Append("'");
			sb.Append(editPageUId.ToString());
			sb.Append("'");	
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
			/*	if (!parameter.Value.StartsWith("'") && parameter.Key != "recordId" && parameter.Key != "ParentEntityId") {
					sb.Append("'");		
				}*/
				sb.Append(parameter.Value);
			/*	if (!parameter.Value.EndsWith("'") && parameter.Key != "recordId" && parameter.Key != "ParentEntityId") {
					sb.Append("'");		
				}*/
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

		public virtual void ModifyAddPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
		}

		public virtual string GetRegisterCopyPageScript(Guid editPageUId, Guid sysModuleEditId) {
			var openPageParameters = new Dictionary<string, object>() {
					{"OpenerInstanceId", Page.Process.InstanceUId},		
				};
			
			var queryStringParameters = new Dictionary<string, string>() {
				{"recordId", GetDataSource().ClientID + ".activeRow.getPrimaryColumnValue()"},
				{"entitySchemaUId",string.Format("'{0}'", EntitySchemaUId)},
				{"treeGridId", string.Format("'{0}'", Page.TreeGrid.ClientID)},
				{"Copy", "'true'"},
				{"SysModuleEditId", string.Format("'{0}'", sysModuleEditId)}
			};
			ModifyCopyPageParameters(openPageParameters, queryStringParameters);
			
			var sb = new StringBuilder();
			//var typeEditPageUIdScript = string.Format("{0}.getCustomData('typeId_' + {1}.activeRow.getColumnValue({0}.getCustomData('typeColumnName')).replace(/-/g, ''))", Page.AddButton.ClientID, GetDataSource().ClientID);
			sb.Append("Terrasoft.openWindow(");
			var sbCallback = new StringBuilder();
			var nullString = "null";
			var callbackString = "function(wnd) {{ {0} }}";
			var window = "wnd";
			sb.Append("'");
			sb.Append("ViewPage.aspx");	
			sb.Append("'");
			sb.Append(", ");
			//if (TypeColumnUId == Guid.Empty) {
				sb.Append("'");
				sb.Append(editPageUId.ToString());
				sb.Append("'");	
			/*} else {
				sb.Append(typeEditPageUIdScript);
			}*/
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
			/*	if (!parameter.Value.StartsWith("'") && parameter.Key != "recordId" && parameter.Key != "ParentEntityId") {
					sb.Append("'");		
				}*/
				sb.Append(parameter.Value);
			/*	if (!parameter.Value.EndsWith("'") && parameter.Key != "recordId" && parameter.Key != "ParentEntityId") {
					sb.Append("'");		
				}*/
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

		public virtual void ModifyCopyPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
		}

		public virtual void SetEntitySchemaUId(string schemaName) {
			//Override to set EntitySchema
			if (string.IsNullOrEmpty(schemaName)) {
				EntitySchemaUId = Guid.Empty;
			} else {
				EntitySchemaUId = UserConnection.EntitySchemaManager.GetInstanceByName(schemaName).UId;
			}
		}

		public virtual void BaseActiveRowChangedHandler() {
			ActivateButtons(true);
			if(IsDetailGrid) {
				return;
			}
			ListenerThrowEvent(ListenerPageProcessUId, "GridActiveRowChanged");
		}

		public virtual void BaseLoadRowsResponseRegisteredHandler(object sender, DataSourceEventArgs e) {
			var dataSource = GetDataSource();
			var dataSourceRowsCount = dataSource.Rows.Count;
			dataSource.SelectedItemPrimaryColumnValues.Clear();
			var activeRowUId = Guid.Empty;
			if (e.Request.AlreadyContainsRows) {
				dataSource.SetClientActiveRow(dataSource.ActiveRowPrimaryColumnValue, true);
				dataSource.SelectedItemPrimaryColumnValues.Add(dataSource.ActiveRowPrimaryColumnValue);
				if (!IsDetailGrid) {
							   SelectedNodePrimaryColumnValue = dataSource.ActiveRowPrimaryColumnValue;
							   ListenerThrowEvent(ListenerPageProcessUId, "GridLoadRows");
							   ActivateButtons(true);
				}
			} else {
				if (dataSourceRowsCount > 0) {
					if (e != null && e.Row != null) {
						activeRowUId = e.Row.PrimaryColumnValue;
					} else {
						activeRowUId = dataSource.Rows[0].PrimaryColumnValue;
					}
					dataSource.SetClientActiveRow(activeRowUId, true);
					dataSource.SelectedItemPrimaryColumnValues.Add(
											dataSource.ActiveRowPrimaryColumnValue);
				} else {
					dataSource.SetClientActiveRow(activeRowUId, true);
				}
				if (!IsDetailGrid) {
					SelectedNodePrimaryColumnValue = activeRowUId;
					ListenerThrowEvent(ListenerPageProcessUId, "GridLoadRows");
				}
				ActivateButtons(dataSourceRowsCount > 0);
			}
		}

		public virtual void InitializeContextHelpButton() {
			if (!GetIsContextHelpButtonHidden() && GetIsContextHelpEnabled()) {
				string helpContextId = Page.Schema.HelpContextId;
				var userConnection = Page.UserConnection;
				TSConfiguration.VideoHelpUtilities.InitializeContextHelpButton(Page.ContextHelpButton, helpContextId, MenuHelpItemCaption, MenuVideoHelpItemCaption, userConnection);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartPageLoadComplete")) {
							context.QueueTasks.Enqueue("StartPageLoadComplete");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("StartPageLoad")) {
							context.QueueTasks.Enqueue("StartPageLoad");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartInit")) {
							context.QueueTasks.Enqueue("StartInit");
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("StartDeleteYesMessage")) {
							context.QueueTasks.Enqueue("StartDeleteYesMessage");
						}
						break;
					case "GridPageRefreshRow":
							if (ActivatedEventElements.Contains("StartGridPageRefreshRow")) {
							context.QueueTasks.Enqueue("StartGridPageRefreshRow");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("MenuVideoHelpItemCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MenuVideoHelpItemCaption", MenuVideoHelpItemCaption, null);
			}
			if (!HasMapping("MenuHelpItemCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MenuHelpItemCaption", MenuHelpItemCaption, null);
			}
			if (!HasMapping("IsModuleProcessesTuningMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsModuleProcessesTuningMode", IsModuleProcessesTuningMode, false);
			}
			if (!HasMapping("SysModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
			}
			if (!HasMapping("SysModuleDetailId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleDetailId", SysModuleDetailId, Guid.Empty);
			}
			if (!HasMapping("SysModuleEditId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleEditId", SysModuleEditId, Guid.Empty);
			}
			if (!HasMapping("EntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("EditPageUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditPageUId", EditPageUId, Guid.Empty);
			}
			if (DataSource != null) {
				if (DataSource.GetType().IsSerializable ||
					DataSource.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DataSource", DataSource, null);
				}
			}
			if (!HasMapping("ParentColumnMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentColumnMetaPath", ParentColumnMetaPath, null);
			}
			if (FilterLeftExpression != null) {
				if (FilterLeftExpression.GetType().IsSerializable ||
					FilterLeftExpression.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("FilterLeftExpression", FilterLeftExpression, null);
				}
			}
			if (!HasMapping("AddToMenuItemMoveTo") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AddToMenuItemMoveTo", AddToMenuItemMoveTo, false);
			}
			if (!HasMapping("SysEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysEntitySchemaId", SysEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("UseModuleDetails") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UseModuleDetails", UseModuleDetails, false);
			}
			if (!HasMapping("DataSourceClientID") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DataSourceClientID", DataSourceClientID, null);
			}
			if (!HasMapping("IsDetailGrid") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDetailGrid", IsDetailGrid, false);
			}
			if (!HasMapping("SelectedNodePrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedNodePrimaryColumnValue", SelectedNodePrimaryColumnValue, Guid.Empty);
			}
			if (EditPageHelpContextId != null) {
				if (EditPageHelpContextId.GetType().IsSerializable ||
					EditPageHelpContextId.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EditPageHelpContextId", EditPageHelpContextId, null);
				}
			}
			if (!HasMapping("IsContextHelpButtonInitialized") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsContextHelpButtonInitialized", IsContextHelpButtonInitialized, false);
			}
			if (!HasMapping("LocatedInEditPage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LocatedInEditPage", LocatedInEditPage, false);
			}
			if (!HasMapping("ListenerPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ListenerPageProcessUId", ListenerPageProcessUId, null);
			}
			if (DataSourceFilter != null) {
				if (DataSourceFilter.GetType().IsSerializable ||
					DataSourceFilter.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DataSourceFilter", DataSourceFilter, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseVirtualGridPageEventsProcess

	/// <exclude/>
	public class BaseVirtualGridPageEventsProcess : BaseVirtualGridPageEventsProcess<Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl>
	{

		public BaseVirtualGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseVirtualGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseVirtualGridPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer", true);
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
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseVirtualGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseVirtualGridPageEventsProcess(UserConnection);
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
			SchemaName = "BaseVirtualGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseVirtualGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseVirtualGridPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseVirtualGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseVirtualGridPageEventsProcessSchema(BaseVirtualGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseVirtualGridPageEventsProcess";
			UId = new Guid("119c8333-6931-4165-861e-0db0c22e0503");
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

		protected virtual ProcessSchemaParameter CreateDataSourceFilterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("97c20373-c2a4-459c-8a5d-e7860df94760"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"DataSourceFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a3ff28e5-66ec-4285-8d4e-6c5b25719b75"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"ListenerPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLocatedInEditPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1d69060a-271e-41d0-9cc6-b65ab117ebf4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"LocatedInEditPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsContextHelpButtonInitializedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("40ae2d30-f814-4800-9d98-e16762ed99ec"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"IsContextHelpButtonInitialized",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditPageHelpContextIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e3736cfb-160a-4e36-9345-c13736a15030"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"EditPageHelpContextId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedNodePrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4956f83c-edb0-4e03-ba4e-8c9848f62ec4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"SelectedNodePrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDetailGridParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8df48251-f078-4880-9b81-8e48d849ea51"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"IsDetailGrid",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceClientIDParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7e87c00b-d2cd-4ff8-928a-212d5fabb2cb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"DataSourceClientID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUseModuleDetailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2a271b2d-eece-436a-b8b3-d7098178dc61"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"UseModuleDetails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1e3309a8-214b-47c4-9dd7-35b9172d123d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"SysEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAddToMenuItemMoveToParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02d2b92f-94a7-448a-8d8f-1edcc5a13790"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"AddToMenuItemMoveTo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterLeftExpressionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("76b92ea4-8e15-4520-8422-1b3445e6a34a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"FilterLeftExpression",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentColumnMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ae074a38-4faa-4f82-a6b5-4ab3e8ac9547"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"ParentColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3bb12d60-3601-406a-8f5c-dc9526dd97f5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"DataSource",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4b533bf4-09bd-4fc5-ae15-6cb84f94ffc3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"EditPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5d622789-9133-43c5-b0d7-74d08173505c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleEditIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("978cd0c3-d14c-41e7-8b83-fb02b2000d3c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"SysModuleEditId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleDetailIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6f167e76-769b-46fa-ba8e-ef9be449f64c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"SysModuleDetailId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("171f5855-2c80-4dc3-bf14-3d5252823e28"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"SysModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsModuleProcessesTuningModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e870b5eb-26e7-46e9-828c-a39f4a97ba96"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"IsModuleProcessesTuningMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMenuHelpItemCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2e193fab-1c3f-474c-bab0-9ed3db026432"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"MenuHelpItemCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMenuVideoHelpItemCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b483949d-5cbf-47b1-821f-f55108e0b1dc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"MenuVideoHelpItemCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDataSourceFilterParameter());
			Parameters.Add(CreateListenerPageProcessUIdParameter());
			Parameters.Add(CreateLocatedInEditPageParameter());
			Parameters.Add(CreateIsContextHelpButtonInitializedParameter());
			Parameters.Add(CreateEditPageHelpContextIdParameter());
			Parameters.Add(CreateSelectedNodePrimaryColumnValueParameter());
			Parameters.Add(CreateIsDetailGridParameter());
			Parameters.Add(CreateDataSourceClientIDParameter());
			Parameters.Add(CreateUseModuleDetailsParameter());
			Parameters.Add(CreateSysEntitySchemaIdParameter());
			Parameters.Add(CreateAddToMenuItemMoveToParameter());
			Parameters.Add(CreateFilterLeftExpressionParameter());
			Parameters.Add(CreateParentColumnMetaPathParameter());
			Parameters.Add(CreateDataSourceParameter());
			Parameters.Add(CreateEditPageUIdParameter());
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateSysModuleEditIdParameter());
			Parameters.Add(CreateSysModuleDetailIdParameter());
			Parameters.Add(CreateSysModuleIdParameter());
			Parameters.Add(CreateIsModuleProcessesTuningModeParameter());
			Parameters.Add(CreateMenuHelpItemCaptionParameter());
			Parameters.Add(CreateMenuVideoHelpItemCaptionParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet20 = CreateLaneSet20LaneSet();
			LaneSets.Add(schemaLaneSet20);
			ProcessSchemaLane schemaLane63 = CreateLane63Lane();
			schemaLaneSet20.Lanes.Add(schemaLane63);
			ProcessSchemaEventSubProcess eventsubprocesspageloadcomplete = CreateEventSubProcessPageLoadCompleteEventSubProcess();
			FlowElements.Add(eventsubprocesspageloadcomplete);
			ProcessSchemaEventSubProcess eventsubprocesspageload = CreateEventSubProcessPageLoadEventSubProcess();
			FlowElements.Add(eventsubprocesspageload);
			ProcessSchemaEventSubProcess eventsubprocessinit = CreateEventSubProcessInitEventSubProcess();
			FlowElements.Add(eventsubprocessinit);
			ProcessSchemaEventSubProcess eventsubprocessdeletyesmessage = CreateEventSubProcessDeletYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocessdeletyesmessage);
			ProcessSchemaEventSubProcess eventsubprocessgridpagerefreshrow = CreateEventSubProcessGridPageRefreshRowEventSubProcess();
			FlowElements.Add(eventsubprocessgridpagerefreshrow);
			ProcessSchemaStartMessageEvent startpageloadcomplete = CreateStartPageLoadCompleteStartMessageEvent();
			eventsubprocesspageloadcomplete.FlowElements.Add(startpageloadcomplete);
			ProcessSchemaScriptTask scriptpageloadcomplete = CreateScriptPageLoadCompleteScriptTask();
			eventsubprocesspageloadcomplete.FlowElements.Add(scriptpageloadcomplete);
			ProcessSchemaStartMessageEvent startpageload = CreateStartPageLoadStartMessageEvent();
			eventsubprocesspageload.FlowElements.Add(startpageload);
			ProcessSchemaScriptTask scriptpageload = CreateScriptPageLoadScriptTask();
			eventsubprocesspageload.FlowElements.Add(scriptpageload);
			ProcessSchemaStartMessageEvent startinit = CreateStartInitStartMessageEvent();
			eventsubprocessinit.FlowElements.Add(startinit);
			ProcessSchemaScriptTask scriptinit = CreateScriptInitScriptTask();
			eventsubprocessinit.FlowElements.Add(scriptinit);
			ProcessSchemaStartMessageEvent startdeleteyesmessage = CreateStartDeleteYesMessageStartMessageEvent();
			eventsubprocessdeletyesmessage.FlowElements.Add(startdeleteyesmessage);
			ProcessSchemaScriptTask scriptdeleteyesmessage = CreateScriptDeleteYesMessageScriptTask();
			eventsubprocessdeletyesmessage.FlowElements.Add(scriptdeleteyesmessage);
			ProcessSchemaStartMessageEvent startgridpagerefreshrow = CreateStartGridPageRefreshRowStartMessageEvent();
			eventsubprocessgridpagerefreshrow.FlowElements.Add(startgridpagerefreshrow);
			ProcessSchemaScriptTask scriptgridpagerefreshrow = CreateScriptGridPageRefreshRowScriptTask();
			eventsubprocessgridpagerefreshrow.FlowElements.Add(scriptgridpagerefreshrow);
			FlowElements.Add(CreateSequenceFlow230SequenceFlow());
			FlowElements.Add(CreateSequenceFlow231SequenceFlow());
			FlowElements.Add(CreateSequenceFlow232SequenceFlow());
			FlowElements.Add(CreateSequenceFlow233SequenceFlow());
			FlowElements.Add(CreateSequenceFlow234SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateQuestionCaptionLocalizableString());
			LocalizableStrings.Add(CreateDeleteRecordMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateQuestionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d8778acd-bd10-434a-aaee-0cda5afac441"),
				Name = "QuestionCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteRecordMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9c78e898-5a8a-469f-98f2-4e2127541396"),
				Name = "DeleteRecordMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow230SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow230",
				UId = new Guid("64836a57-4d88-42f1-b37a-481ab59dd06d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CurveCenterPosition = new Point(176, 89),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d5ecf09f-4747-4c64-b73f-33748254476f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("272bbd9e-86bc-4f6d-8ee8-e4a335cb57bd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow231SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow231",
				UId = new Guid("6b4cdf0f-5f1a-4d45-80ce-50b99ec8fae2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CurveCenterPosition = new Point(168, 286),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("57b8cf87-6ff2-4903-acf6-62834a36955a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("392fe560-11fa-4a93-8be6-e049c5f4a90e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow232SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow232",
				UId = new Guid("aa97f860-42d3-491d-96fb-106491398ca6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CurveCenterPosition = new Point(178, 462),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("db411fec-3edd-4168-876f-d1f3616b1b50"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3a9b05ea-2998-41a2-9dcb-6acf5ed066b9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow233SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow233",
				UId = new Guid("7f152fee-df41-4570-a12c-cc3e90e5c7d7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CurveCenterPosition = new Point(169, 174),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("463ef591-cba0-4795-92ed-b2a3f6f86432"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75b01c36-3ee7-40fd-811e-4da36593e0da"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow234SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow234",
				UId = new Guid("862a27a8-4ab2-462d-8aeb-b4a4de5c1e4f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CurveCenterPosition = new Point(180, 212),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a9fcb272-c865-4b45-97b3-8d9da93671da"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8ea74fc5-2a4f-464c-a8e6-016181a14e20"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet20LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet20 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("26a4fe91-cf54-44ac-909a-a90016635aa1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"LaneSet20",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1144, 184),
				UseBackgroundMode = false
			};
			return schemaLaneSet20;
		}

		protected virtual ProcessSchemaLane CreateLane63Lane() {
			ProcessSchemaLane schemaLane63 = new ProcessSchemaLane(this) {
				UId = new Guid("66211815-8267-46fd-aeb5-7c1d06d0ee73"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("26a4fe91-cf54-44ac-909a-a90016635aa1"),
				CreatedInOwnerSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"Lane63",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1115, 184),
				UseBackgroundMode = false
			};
			return schemaLane63;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b115cba1-6825-4735-9518-628c5728206e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66211815-8267-46fd-aeb5-7c1d06d0ee73"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"EventSubProcessPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(243, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d5ecf09f-4747-4c64-b73f-33748254476f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b115cba1-6825-4735-9518-628c5728206e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"StartPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("272bbd9e-86bc-4f6d-8ee8-e4a335cb57bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b115cba1-6825-4735-9518-628c5728206e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"ScriptPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,245,201,79,76,113,206,207,45,200,73,45,73,245,77,45,201,200,79,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,185,119,62,162,38,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPageLoadEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPageLoad = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fd1f78af-c9d3-4afd-8332-42c68689f6b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66211815-8267-46fd-aeb5-7c1d06d0ee73"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"EventSubProcessPageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 196),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPageLoad;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartPageLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("57b8cf87-6ff2-4903-acf6-62834a36955a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fd1f78af-c9d3-4afd-8332-42c68689f6b2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"StartPageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("392fe560-11fa-4a93-8be6-e049c5f4a90e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fd1f78af-c9d3-4afd-8332-42c68689f6b2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"ScriptPageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,245,201,79,76,241,77,45,201,200,79,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,31,20,70,33,30,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d5a680f8-65e7-404c-bedf-59fc701e6e0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66211815-8267-46fd-aeb5-7c1d06d0ee73"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"EventSubProcessInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 380),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("db411fec-3edd-4168-876f-d1f3616b1b50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5a680f8-65e7-404c-bedf-59fc701e6e0e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"StartInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3a9b05ea-2998-41a2-9dcb-6acf5ed066b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5a680f8-65e7-404c-bedf-59fc701e6e0e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"ScriptInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,245,204,203,44,241,77,45,201,200,79,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,170,14,59,154,30,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDeletYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDeletYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7cb14d3e-365c-4b08-b317-aaafec8d8740"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66211815-8267-46fd-aeb5-7c1d06d0ee73"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"EventSubProcessDeletYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 560),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(235, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDeletYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartDeleteYesMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("463ef591-cba0-4795-92ed-b2a3f6f86432"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7cb14d3e-365c-4b08-b317-aaafec8d8740"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"StartDeleteYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteYesMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("75b01c36-3ee7-40fd-811e-4da36593e0da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7cb14d3e-365c-4b08-b317-aaafec8d8740"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"ScriptDeleteYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,187,10,194,48,24,70,231,246,41,50,166,139,47,224,101,177,80,58,136,210,130,123,154,124,210,64,46,240,231,82,68,124,119,227,160,237,248,113,14,231,203,130,152,18,81,140,62,145,4,59,178,14,177,253,111,222,236,235,92,12,130,244,164,122,21,138,224,176,176,235,20,64,89,76,6,103,111,12,100,212,222,29,186,164,213,137,175,177,221,136,47,130,234,35,236,141,180,21,244,44,122,178,238,46,76,66,40,237,135,39,8,57,51,190,61,97,218,173,135,205,171,174,6,191,132,182,180,34,46,136,179,87,252,71,75,161,218,252,13,176,62,99,75,223,53,33,38,114,44,82,194,254,3,111,20,93,211,236,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessGridPageRefreshRowEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessGridPageRefreshRow = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("36c684f1-5dd3-468a-8bc7-dfd0cfa8d7aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66211815-8267-46fd-aeb5-7c1d06d0ee73"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"EventSubProcessGridPageRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 741),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(243, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessGridPageRefreshRow;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartGridPageRefreshRowStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a9fcb272-c865-4b45-97b3-8d9da93671da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("36c684f1-5dd3-468a-8bc7-dfd0cfa8d7aa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"StartGridPageRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGridPageRefreshRowScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8ea74fc5-2a4f-464c-a8e6-016181a14e20"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("36c684f1-5dd3-468a-8bc7-dfd0cfa8d7aa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Name = @"ScriptGridPageRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,201,113,73,44,73,212,200,43,205,201,209,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,35,8,53,143,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetIsContextHelpButtonHiddenMethod());
			Methods.Add(CreateGetIsContextHelpEnabledMethod());
			Methods.Add(CreateGetRegisterQuetsionScriptMethod());
			Methods.Add(CreatePageLoadMethodMethod());
			Methods.Add(CreatePageLoadCompleteMethodMethod());
			Methods.Add(CreatePageInitMethodMethod());
			Methods.Add(CreateCreateDataSourceMethod());
			Methods.Add(CreateGetDataSourceMethod());
			Methods.Add(CreateCreateDataSourceStructureMethod());
			Methods.Add(CreateTreeGridConfigHandlerMethod());
			Methods.Add(CreateGetEntityMethod());
			Methods.Add(CreateGetEntitiesMethod());
			Methods.Add(CreateCellIconClickHandlerMethod());
			Methods.Add(CreateGetButtonsMethod());
			Methods.Add(CreateActivateButtonsMethod());
			Methods.Add(CreateRowsDeleteMethodMethod());
			Methods.Add(CreateListenerThrowEventMethod());
			Methods.Add(CreateListenerProcessSetPropertyMethod());
			Methods.Add(CreateListenerProcessGetPropertyValueMethod());
			Methods.Add(CreateCreateSelectMethod());
			Methods.Add(CreateGetStructureDefinitionMethod());
			Methods.Add(CreateFillDataMethod());
			Methods.Add(CreateGetViewCodeMethod());
			Methods.Add(CreateSubscribeOnControlEventsMethod());
			Methods.Add(CreateGetRegisterEditPageScriptMethod());
			Methods.Add(CreateModifyEditPageParametersMethod());
			Methods.Add(CreatePopulateEditPagesMethod());
			Methods.Add(CreateGetRegisterAddPageScriptMethod());
			Methods.Add(CreateModifyAddPageParametersMethod());
			Methods.Add(CreateGetRegisterCopyPageScriptMethod());
			Methods.Add(CreateModifyCopyPageParametersMethod());
			Methods.Add(CreateSetEntitySchemaUIdMethod());
			Methods.Add(CreateBaseActiveRowChangedHandlerMethod());
			Methods.Add(CreateBaseLoadRowsResponseRegisteredHandlerMethod());
			Methods.Add(CreateInitializeContextHelpButtonMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e0c6ae3c-b3a0-4e06-b747-2bf038a88cc7"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("917cbfdc-72d8-4e11-9182-d5a8af1cdec3"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9c1bc255-2fee-462f-bbc2-ac404082e1f1"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("71df11d8-5543-4198-929a-6a80e3ed540a"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("17456ae9-7ba5-43ae-b221-c2bb59cc23b0"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d0fa7743-d482-45cb-995a-da2785ff374b"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterQuetsionScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a00b95b4-9dcf-4cce-bb67-cdb6e53fda88"),
				Name = "GetRegisterQuetsionScript",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,203,78,195,48,16,60,55,95,97,249,146,68,68,254,129,80,68,161,61,20,68,233,11,36,36,46,38,217,80,163,96,71,182,211,135,170,254,59,118,156,244,145,82,33,145,131,163,236,236,236,206,142,237,40,45,25,255,68,31,165,214,130,171,7,53,171,190,99,79,185,56,75,4,63,11,126,131,82,244,19,238,196,218,1,168,139,240,96,173,201,211,62,142,247,185,133,20,137,9,15,185,210,148,39,48,76,77,242,216,36,145,177,3,72,131,188,12,211,216,91,82,137,36,168,194,72,129,186,154,50,4,14,43,212,103,137,102,130,83,185,185,118,165,35,228,222,55,65,24,123,109,18,233,165,105,128,55,160,112,132,112,31,114,208,240,6,170,70,241,69,2,23,135,252,145,56,74,111,249,99,52,157,153,112,133,48,193,118,125,27,204,70,207,198,129,99,239,46,17,38,47,131,217,124,248,60,194,110,246,172,228,213,148,13,237,174,100,121,10,178,182,224,36,102,167,190,144,78,122,69,1,220,140,211,224,193,135,230,33,218,218,65,50,33,129,38,139,224,17,54,175,52,47,97,76,153,108,27,218,222,2,196,248,217,174,132,91,175,243,87,123,150,33,219,25,117,187,200,183,206,180,106,16,163,193,68,189,206,254,193,190,81,185,98,60,21,43,50,7,41,169,18,153,38,189,47,186,126,2,189,16,169,34,243,133,20,171,251,156,1,215,131,165,89,130,170,240,81,137,243,243,102,108,246,163,95,251,87,6,84,120,24,239,16,228,10,144,181,104,247,167,175,255,209,248,155,48,239,48,120,228,247,33,163,101,174,39,37,40,219,187,22,105,165,237,220,129,213,165,228,237,139,70,234,83,229,122,52,220,123,90,216,23,153,11,167,63,8,143,92,112,167,123,10,137,144,105,227,196,33,145,76,161,200,105,2,1,246,205,85,184,197,239,62,174,201,134,235,117,218,247,192,32,22,56,249,79,236,131,151,108,60,149,21,33,189,96,42,140,113,252,3,202,164,250,177,140,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePageLoadMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d4cb9d39-11fb-4402-9f5f-92b1495ef4de"),
				Name = "PageLoadMethod",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreatePageLoadCompleteMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e12a2327-fdf6-441e-b036-e122170d239d"),
				Name = "PageLoadCompleteMethod",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,49,10,2,49,16,69,107,5,239,48,118,187,176,228,2,98,163,141,233,4,93,251,97,51,89,7,98,178,36,19,16,197,187,155,136,96,177,96,57,143,255,254,124,182,208,172,117,218,7,47,116,151,3,185,105,151,69,130,215,158,133,209,241,131,76,11,207,213,114,113,166,24,49,5,43,170,100,45,143,57,162,112,240,234,194,134,66,245,122,97,87,28,74,234,231,206,106,155,35,142,164,102,184,131,15,63,13,87,186,161,170,252,27,209,166,131,62,81,44,167,167,161,62,108,55,101,204,255,193,176,5,137,153,74,240,245,6,81,59,11,182,223,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePageInitMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8afd9c08-53f4-4f07-9e68-96a8d9cd59e8"),
				Name = "PageInitMethod",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,205,10,130,64,20,133,215,249,20,147,43,221,248,2,210,162,76,106,32,72,208,104,61,234,181,46,232,140,220,185,19,253,208,187,55,186,105,17,180,60,231,124,124,112,10,117,129,164,34,128,29,97,155,200,193,199,3,90,22,43,17,86,64,164,172,233,56,57,67,189,30,199,48,13,50,2,197,176,85,172,74,227,168,129,40,78,131,18,56,215,140,252,40,155,43,12,234,36,219,40,12,125,95,152,209,245,158,206,91,228,194,107,237,12,187,218,54,132,53,28,117,102,52,147,233,243,27,104,158,55,236,68,180,148,118,234,225,206,123,232,199,141,99,54,90,106,100,84,61,62,161,141,197,43,88,124,243,15,58,105,22,255,21,254,25,147,131,52,120,127,0,198,10,23,205,251,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9a5ad139-85cf-41a4-b1de-94c97beb3719"),
				Name = "CreateDataSource",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,219,110,163,48,16,125,134,175,176,120,34,218,202,31,80,20,173,34,146,166,72,93,41,74,47,251,236,226,41,114,107,236,236,96,72,163,85,255,189,99,104,33,9,121,104,170,190,68,195,92,206,153,241,153,76,35,144,53,10,93,45,244,92,56,113,107,107,204,129,77,153,129,45,123,56,246,199,19,246,63,12,178,57,197,163,81,48,10,223,146,112,37,10,224,254,39,181,198,9,101,0,185,183,208,234,138,207,164,140,71,84,147,36,60,224,29,37,36,97,138,32,28,12,158,91,135,117,238,106,164,118,62,8,239,16,96,137,74,242,217,179,120,93,52,96,92,197,83,208,58,203,173,73,181,202,95,120,235,100,191,166,236,192,125,45,140,212,128,95,71,121,117,40,86,2,69,9,14,176,155,40,12,252,83,221,1,162,168,236,147,227,247,25,255,11,143,253,208,189,209,151,197,145,177,18,50,25,93,176,193,10,131,51,16,254,80,21,95,139,237,228,140,249,127,166,115,69,128,93,231,189,245,67,157,103,37,125,222,168,202,249,221,26,16,9,110,182,217,68,199,217,75,112,107,187,37,252,39,85,124,136,200,166,193,103,248,192,127,92,58,236,81,38,79,237,27,207,230,9,11,199,238,27,43,36,72,191,66,99,188,46,150,156,168,218,19,100,13,165,109,64,158,148,226,108,33,16,254,213,80,185,246,253,247,62,190,41,197,184,111,111,174,59,88,63,178,4,13,5,253,9,99,251,248,12,185,99,21,24,9,120,193,134,138,118,200,25,22,21,131,246,72,92,41,221,226,197,68,210,225,16,207,219,41,42,255,120,202,20,164,231,247,152,150,181,146,12,33,183,40,91,69,123,66,54,165,51,86,107,205,126,51,159,195,23,229,198,237,216,229,144,192,87,168,74,129,187,212,234,186,52,15,66,215,116,109,130,134,46,162,220,63,73,180,108,251,39,144,82,134,48,167,182,59,9,41,107,97,156,114,187,248,179,151,73,55,241,59,201,68,140,43,98,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("497abc00-3211-46eb-8cb8-863c3e323d19"),
				Name = "GetDataSource",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,73,44,73,12,206,47,45,74,78,85,72,44,86,8,203,44,42,41,77,204,65,8,90,3,0,138,22,216,153,39,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateDataSourceStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0845a99d-ab8c-483b-ae2c-85bd358d1a41"),
				Name = "CreateDataSourceStructure",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,148,209,78,194,48,20,134,175,199,83,44,92,141,196,244,5,136,23,10,70,23,163,33,130,222,24,47,14,229,0,77,182,150,180,29,102,49,188,187,237,58,6,221,58,196,203,238,124,255,223,191,231,156,108,15,50,94,129,134,15,200,10,92,148,59,124,1,14,27,148,241,109,252,174,80,78,4,231,72,53,19,156,76,3,212,120,176,55,122,228,154,233,114,78,183,152,67,175,252,161,11,57,181,189,125,46,10,73,209,136,30,81,79,155,115,50,114,132,210,178,160,186,144,22,56,209,100,138,235,249,177,210,2,83,141,185,114,118,13,98,112,198,153,205,98,125,215,66,34,208,109,156,88,29,51,120,204,120,75,63,138,127,6,145,45,83,145,21,57,55,118,28,191,227,83,188,198,121,226,234,134,142,162,87,200,109,76,235,248,57,180,135,225,23,89,8,131,50,190,73,70,55,22,169,154,232,52,30,221,250,222,21,78,153,218,101,80,6,164,157,74,64,124,62,190,186,145,237,113,18,211,175,148,43,13,156,226,125,105,125,146,218,255,28,246,188,157,249,4,118,182,177,77,158,250,220,77,145,170,15,166,216,50,179,9,150,66,100,100,6,82,29,111,105,138,129,27,82,53,23,82,67,175,242,88,245,165,131,232,48,30,68,108,29,87,28,49,235,168,129,113,245,140,101,50,124,195,53,74,52,47,117,59,89,117,109,84,205,188,26,186,244,203,230,214,192,154,247,54,44,100,238,37,51,177,34,183,87,36,192,54,141,252,203,167,223,230,61,93,25,151,214,43,136,249,218,47,153,73,150,131,244,247,171,109,96,30,220,193,46,197,168,225,208,234,246,91,119,232,234,134,67,223,36,83,229,69,58,78,209,194,129,77,241,89,111,40,78,23,53,191,1,18,234,72,253,78,123,178,207,62,92,19,204,123,208,117,249,124,201,85,49,67,77,254,87,218,39,134,18,36,221,50,10,217,85,89,3,130,203,73,187,130,75,57,79,58,199,42,114,183,90,37,14,53,27,113,248,5,184,247,195,55,189,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateTreeGridConfigHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1de36edc-b0e2-4ad1-80b1-5a8cbcd0725e"),
				Name = "TreeGridConfigHandler",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceRowConfig"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("27f56d09-876e-455d-8e16-5d31201b794f"),
				Name = "row",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,44,75,44,82,72,206,207,75,203,76,87,176,85,200,75,45,87,112,73,44,73,12,206,47,45,74,78,13,202,47,119,6,203,104,20,229,151,235,5,20,101,230,38,22,85,58,231,231,148,230,230,133,37,230,148,166,106,90,115,114,114,113,22,165,150,148,22,229,65,205,176,6,0,238,251,169,232,80,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("644ddd4a-e32b-4098-8157-b3bd4f12a9a0"),
				Name = "GetEntity",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Entity"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7dd687bd-96f2-4a70-a97f-9b055b0da808"),
				Name = "recordId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,143,61,107,195,48,16,134,231,250,87,104,148,160,136,102,14,25,138,99,66,150,18,240,88,58,28,242,27,42,144,165,246,116,10,41,165,255,189,74,229,154,108,247,126,112,247,220,133,88,77,36,52,166,194,14,106,167,14,144,253,170,181,217,118,151,218,200,8,112,82,211,158,65,130,241,79,222,194,53,104,131,125,142,147,94,198,182,97,184,126,48,114,246,41,218,209,189,99,166,23,154,241,120,119,210,238,113,30,133,139,147,194,176,39,246,51,241,87,159,66,153,227,173,106,236,49,15,159,133,130,110,158,61,17,87,91,192,154,225,18,79,199,201,24,69,89,53,166,134,139,40,94,60,114,123,103,88,212,2,86,169,253,89,233,255,142,237,83,137,245,131,157,218,24,245,221,61,48,42,72,92,87,188,62,189,109,187,31,133,144,113,151,198,18,66,181,127,1,138,94,15,246,61,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntitiesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("22b5233a-bd90-447a-85b5-92d82b0dc9ff"),
				Name = "GetEntities",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Entity>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e4752b38-8e7c-4aca-ade5-ee2592564313"),
				Name = "select",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Select",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,221,74,195,48,20,190,78,159,34,222,101,48,242,2,83,65,219,42,194,216,192,169,247,181,61,115,129,44,25,73,186,90,100,239,238,73,210,174,29,83,25,120,211,146,115,190,159,115,190,180,251,194,208,170,112,197,74,215,166,4,122,67,31,193,101,199,51,155,204,146,61,34,172,51,117,233,106,227,1,3,154,103,176,94,245,157,89,50,23,214,93,231,202,9,215,222,82,240,111,1,22,9,10,26,58,238,121,209,218,10,245,65,153,215,174,222,243,79,40,107,167,13,98,95,45,152,84,43,5,165,19,90,241,92,89,148,206,238,135,18,155,76,232,87,66,70,124,3,69,5,158,107,65,34,134,71,53,120,14,101,54,168,71,34,105,54,66,2,101,145,197,61,170,147,36,36,168,233,230,116,199,20,145,168,166,27,63,54,130,214,26,11,229,38,122,151,90,214,91,69,133,26,18,226,105,168,217,78,147,8,229,168,54,149,80,133,68,225,206,22,67,94,198,26,139,18,252,173,144,53,68,234,162,216,66,244,34,131,71,232,163,64,7,247,87,20,74,47,237,14,188,92,56,60,104,51,215,184,208,105,138,211,145,107,128,177,110,158,73,231,130,59,243,21,184,116,48,250,101,170,233,120,152,142,44,214,148,93,225,246,120,31,252,201,46,106,41,151,38,223,238,92,219,107,100,194,238,100,209,142,118,235,163,33,23,228,114,206,142,182,228,178,88,58,250,127,210,249,35,158,179,225,126,10,232,144,244,143,254,159,224,119,85,197,80,53,0,176,115,72,14,137,1,252,120,212,241,183,153,125,3,67,70,89,116,152,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCellIconClickHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fec952dd-15ca-42e8-b179-e3d350758ae8"),
				Name = "CellIconClickHandler",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e5030763-3f3b-4a82-b11a-e14331f1f503"),
				Name = "sender",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1bb3dfdc-ac76-4503-9f98-a406b90439cb"),
				Name = "e",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4bd05e53-ba5d-4fed-99df-8632746ae853"),
				Name = "GetButtons",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,45,46,205,41,81,176,85,200,75,45,87,240,201,44,46,177,41,46,41,202,204,75,183,211,208,180,230,229,130,200,234,57,166,164,104,4,36,166,167,130,24,78,165,37,37,249,121,122,126,137,185,169,216,84,184,166,100,150,16,80,226,156,95,80,73,64,137,75,106,78,106,73,42,1,69,1,64,119,98,218,85,82,90,148,7,245,149,53,0,105,62,243,159,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0af8c311-f59f-421b-bb93-8c9db4fa6f0e"),
				Name = "ActivateButtons",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d5c7a50c-a928-4cd6-ae40-a8afa2be3cb0"),
				Name = "activate",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,93,111,218,48,20,125,78,126,133,203,67,21,164,41,234,94,139,216,196,71,212,33,109,93,85,202,246,108,226,11,88,115,236,200,118,96,209,202,127,223,117,18,32,192,18,186,118,123,65,138,125,238,57,247,227,92,179,166,154,204,51,107,149,52,164,79,238,192,14,203,143,160,219,243,215,120,199,168,165,83,149,233,24,30,213,198,140,84,38,45,233,251,30,2,199,251,155,160,27,14,98,203,215,14,242,160,121,66,117,62,82,34,75,228,55,42,50,32,125,228,205,56,11,163,36,181,57,121,126,38,87,212,161,169,5,223,251,72,110,200,45,121,223,243,231,74,9,66,25,43,229,35,73,231,2,216,48,127,228,203,149,117,153,89,157,65,133,98,32,192,194,11,128,192,184,125,1,44,86,105,222,14,227,11,18,68,210,114,155,79,227,21,36,116,54,97,228,170,94,85,151,252,242,61,215,46,168,161,48,124,102,64,143,148,148,128,5,43,25,214,57,190,80,73,151,160,67,236,228,68,26,75,101,12,195,28,137,79,133,112,14,158,211,63,98,70,113,153,9,81,200,22,186,108,62,133,56,211,136,136,228,146,75,108,58,121,64,250,240,36,129,241,240,24,134,220,158,177,154,203,37,49,5,243,61,77,92,108,93,44,116,103,14,216,222,247,211,12,138,194,76,189,152,177,139,71,169,129,16,106,3,44,56,40,186,26,189,150,225,95,230,30,164,41,72,214,76,222,54,227,183,179,183,25,237,50,123,132,209,141,220,91,127,235,47,148,6,26,175,2,55,232,88,73,171,209,180,92,150,3,174,214,117,84,30,127,166,185,202,108,88,125,153,189,45,203,13,199,108,118,225,212,144,39,208,154,26,181,176,225,108,18,126,135,249,46,104,31,93,113,87,254,171,40,42,231,145,235,107,82,26,7,225,73,74,53,124,213,216,32,42,42,92,97,154,119,164,227,184,224,167,253,4,34,45,217,58,93,71,113,83,58,247,192,91,170,82,142,15,79,141,160,91,194,60,179,225,54,94,145,163,171,242,198,139,169,1,210,25,236,188,211,185,45,78,189,10,89,141,3,11,111,114,87,175,192,207,177,193,63,122,53,194,113,205,235,141,156,193,159,30,199,15,174,56,236,78,203,182,52,104,70,123,23,189,78,177,209,133,13,122,163,253,78,188,78,175,113,167,206,244,24,44,104,38,44,249,107,153,83,166,45,254,108,9,8,76,191,24,255,25,83,249,94,23,64,183,57,206,96,19,51,6,116,150,184,211,156,185,180,167,56,152,216,2,187,87,12,46,253,91,21,46,123,219,250,253,139,253,251,111,11,120,222,192,5,197,230,30,58,248,27,25,99,209,240,31,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRowsDeleteMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("414f2ea0-14be-495a-bdb5-64faea1f607f"),
				Name = "RowsDeleteMethod",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b61c5558-fb9a-4106-ab0a-6ce501b15673"),
				Name = "recordId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,193,10,130,64,16,134,207,249,20,123,212,203,190,64,120,201,68,60,68,129,216,125,210,209,54,116,54,198,49,144,232,221,27,84,162,58,238,191,255,255,125,140,107,76,152,146,56,153,138,234,138,61,148,121,109,226,216,100,163,171,109,218,223,101,138,204,51,216,48,202,200,100,26,232,6,220,6,175,32,120,0,155,97,30,152,216,148,3,114,226,137,176,18,231,201,126,227,14,64,208,34,219,12,37,167,65,128,42,220,77,234,248,119,70,219,25,137,115,170,200,133,109,19,70,16,92,186,225,175,70,23,75,219,158,216,245,192,83,226,187,177,167,51,116,35,42,128,177,242,92,231,245,167,85,136,103,71,109,33,10,212,255,245,121,188,220,20,55,135,118,143,29,10,234,98,189,118,29,46,113,168,190,55,170,100,151,163,44,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateListenerThrowEventMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9477e0e2-f514-4736-b58d-fecd06cbaf35"),
				Name = "ListenerThrowEvent",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("201eb696-8bfb-4308-a5a0-cba3af711965"),
				Name = "processId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f5136a83-7407-42d5-b12e-7859f63f290e"),
				Name = "eventName",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,65,14,130,48,16,69,215,246,20,227,14,18,211,11,16,54,26,76,186,1,23,114,0,2,35,54,129,41,153,14,40,49,220,221,170,144,184,253,239,231,61,123,131,200,11,91,106,181,241,249,216,117,5,103,253,32,115,52,176,171,209,123,211,196,49,188,212,142,81,70,166,68,45,106,170,24,86,8,41,148,30,249,228,136,176,22,235,72,155,203,143,100,212,90,66,125,182,212,172,203,113,46,77,243,103,77,148,13,233,77,180,79,129,66,252,155,90,55,125,189,179,123,100,19,146,108,55,109,72,144,169,234,66,81,240,41,7,192,15,206,171,30,131,111,121,3,23,20,165,78,204,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateListenerProcessSetPropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("59cc8bc7-765e-49cb-a667-e48d90f978ab"),
				Name = "ListenerProcessSetProperty",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9a92f6c6-dd53-4b45-b4f6-639fd90fe781"),
				Name = "processId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d683efd8-55ad-4d00-ad3f-1a6708ce57a6"),
				Name = "propertyName",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("250b49d3-1cd5-4bbc-a7ef-8f23d22c11a3"),
				Name = "propertyValue",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,140,193,10,194,48,16,68,207,230,43,246,216,128,228,7,130,23,165,72,46,173,32,245,30,218,181,4,210,77,216,36,66,17,255,93,172,57,244,54,51,239,49,238,9,77,202,236,104,86,38,117,197,251,158,219,37,230,181,137,28,70,76,201,76,82,194,91,28,24,115,97,210,226,35,94,150,161,66,56,193,144,144,47,129,8,199,236,2,41,115,251,147,150,102,71,168,174,152,235,112,94,7,51,237,78,181,168,89,221,55,39,34,231,245,97,125,193,159,180,181,206,46,120,132,184,103,82,127,1,213,29,82,166,176,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateListenerProcessGetPropertyValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b448860d-16c3-4863-b8fb-48c161b9f8a1"),
				Name = "ListenerProcessGetPropertyValue",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("93687dde-2b89-4ce2-a44e-992ef96e72e1"),
				Name = "processId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("832c3372-3856-4795-a85c-3ac37d752456"),
				Name = "propertyName",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,140,59,14,194,48,16,5,107,124,138,45,227,198,23,136,104,64,17,114,19,104,66,111,37,75,100,201,89,91,235,53,146,133,184,59,63,23,148,111,222,104,252,13,186,44,236,105,53,54,143,37,132,51,15,91,146,218,37,142,51,230,108,23,173,225,161,118,140,82,152,128,222,70,175,158,234,238,24,154,1,123,152,50,242,49,18,225,44,62,146,177,151,223,51,208,234,9,205,9,165,129,67,157,236,242,87,238,85,203,54,212,212,132,44,245,234,66,193,143,251,93,163,219,80,247,47,69,238,226,64,173,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateSelectMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8fdc1051-9188-40f7-948c-b3a1f0803f28"),
				Name = "CreateSelect",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Select"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,43,205,201,177,6,0,44,130,140,166,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetStructureDefinitionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bf0bebb1-fc43-4181-8288-3c52468266b9"),
				Name = "GetStructureDefinition",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Dictionary<string, object>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,44,46,177,113,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,200,79,202,74,77,46,177,179,83,0,10,148,38,151,148,22,165,42,216,42,228,165,150,43,248,16,208,160,161,105,205,85,148,10,212,144,135,208,106,13,0,79,144,233,218,102,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f4b53ccb-aa52-432d-be39-824cf46083a6"),
				Name = "FillData",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0f93cb03-d4c7-4c22-8462-7522c68e006b"),
				Name = "dataSourceRequest",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceRequest",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,77,14,130,48,20,132,215,114,138,46,203,134,11,24,23,4,9,27,23,6,188,192,11,29,181,6,41,246,7,53,198,187,91,68,11,186,156,55,223,188,153,45,29,144,236,52,80,104,41,146,172,1,105,30,47,163,158,52,19,100,169,82,78,215,96,43,86,192,174,131,30,136,201,77,42,103,58,180,34,61,209,45,239,209,90,243,231,135,175,179,91,9,227,206,248,141,12,165,6,13,106,235,11,51,13,178,168,222,242,107,122,80,90,9,51,238,201,63,138,143,25,207,236,149,15,213,71,198,3,124,103,178,13,177,152,61,162,197,108,67,42,4,31,41,159,125,206,215,109,20,137,82,93,13,159,110,37,46,14,198,183,188,0,55,204,115,203,50,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetViewCodeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2cd35e53-7f14-4aed-918b-057312ae505a"),
				Name = "GetViewCode",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,65,10,131,48,16,69,215,230,20,211,141,216,77,46,16,92,73,23,93,20,186,240,2,49,142,26,212,177,196,88,40,197,187,55,19,5,43,132,144,153,255,230,255,36,179,119,150,90,48,83,141,144,195,28,43,121,27,95,254,163,196,91,59,120,105,135,228,75,93,5,245,169,91,148,188,21,19,121,109,9,93,168,88,6,61,67,64,148,176,13,100,199,196,37,7,90,134,225,10,95,145,52,147,67,109,58,200,216,212,122,28,193,210,97,46,31,72,75,228,18,214,77,135,166,231,214,157,193,124,227,67,70,241,223,87,1,230,188,51,188,103,66,154,158,93,100,156,197,122,11,73,246,247,158,145,82,183,108,154,84,225,170,61,159,86,17,214,42,28,250,197,81,252,35,245,3,116,246,151,142,48,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSubscribeOnControlEventsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c2e98d1b-a746-4564-a3a4-564b7f798061"),
				Name = "SubscribeOnControlEvents",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,144,209,78,131,64,16,69,159,229,43,214,55,136,13,63,208,96,66,161,169,77,52,42,232,7,172,204,72,87,113,151,236,14,40,49,253,119,119,169,88,106,210,68,73,250,180,185,51,115,231,204,221,150,107,6,156,120,174,26,93,32,139,216,10,41,253,209,126,48,247,246,221,48,126,225,31,203,22,37,153,48,46,72,180,152,169,247,100,195,101,137,16,246,117,118,17,49,223,160,4,212,51,134,1,139,46,217,167,119,182,224,6,127,207,95,113,9,21,106,7,216,30,48,174,21,7,59,102,50,52,181,146,6,51,44,133,33,212,8,199,151,31,247,12,152,189,173,231,137,103,230,47,65,208,29,47,241,113,13,236,220,230,110,132,13,241,86,83,23,184,181,174,19,198,0,139,134,72,201,113,242,164,18,197,107,120,43,237,107,245,46,118,255,109,3,213,186,156,59,47,180,168,105,140,153,177,188,51,55,10,154,10,93,117,13,246,152,29,200,201,9,164,97,247,127,80,15,26,113,165,109,214,17,40,125,170,78,194,74,84,221,77,136,229,108,127,71,109,189,158,149,98,133,132,19,104,247,13,146,17,74,126,211,130,249,23,75,169,201,113,19,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("df573149-16de-4326-9e3b-da2bff62407f"),
				Name = "GetRegisterEditPageScript",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("346606e3-ed9a-4d1f-9502-849f27900eff"),
				Name = "editPageUId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dd421698-287b-441c-9ae4-e81d722609da"),
				Name = "sysModuleEditId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,77,115,219,54,16,61,83,191,2,193,33,34,93,149,74,174,81,157,25,91,86,92,77,235,198,19,217,241,33,246,116,32,18,146,224,80,128,2,130,146,53,26,254,247,46,0,138,34,40,82,117,219,67,79,50,23,187,111,31,246,11,235,53,145,72,172,40,191,37,115,122,75,36,89,82,69,101,138,206,17,167,27,116,197,34,197,4,39,114,251,75,170,36,227,243,30,18,211,103,26,169,143,126,128,118,29,207,219,225,207,96,75,229,152,167,138,240,136,142,99,220,67,26,42,188,149,34,162,105,26,238,79,238,199,113,222,243,188,142,151,15,58,157,53,56,253,145,81,185,157,24,212,215,248,181,191,133,223,29,150,52,18,50,54,238,174,169,186,34,138,76,68,38,35,234,7,225,48,97,148,171,241,21,250,9,225,144,0,208,154,126,17,155,112,78,213,173,100,75,192,28,138,36,91,242,175,36,201,64,29,231,61,141,7,22,76,109,39,209,130,46,201,189,134,181,254,194,79,66,46,137,242,113,119,247,46,239,130,179,145,171,23,88,107,37,41,189,150,204,242,105,177,52,81,185,43,20,75,146,5,192,100,155,222,136,56,75,232,40,102,234,20,74,234,42,6,121,7,226,9,18,54,219,106,137,155,69,255,56,177,189,230,184,7,69,82,210,105,145,1,171,112,153,177,36,166,210,135,227,126,95,159,171,237,138,238,253,192,245,39,145,100,43,5,38,53,182,64,86,199,123,152,165,74,44,117,114,252,174,182,28,199,127,118,33,43,187,247,185,155,151,106,66,90,76,173,202,31,64,183,27,4,161,164,171,132,64,178,251,63,247,161,52,186,32,218,7,248,34,142,47,51,165,4,47,35,220,94,32,112,171,116,26,94,172,32,72,177,143,239,168,148,36,21,51,21,234,168,61,48,30,139,141,143,65,199,198,101,72,146,100,74,162,239,109,241,209,90,60,75,18,123,0,90,88,127,97,123,16,21,198,135,195,89,198,77,137,251,27,30,67,73,239,16,220,27,229,121,161,191,49,222,181,30,28,99,135,102,23,187,180,191,50,186,49,55,39,233,234,5,206,188,83,202,61,132,77,42,217,12,249,119,101,84,33,145,232,252,28,93,103,80,151,163,229,74,109,77,143,213,97,42,2,122,168,128,240,78,216,75,249,129,171,99,140,188,78,255,44,71,52,73,169,139,216,88,70,96,159,159,245,143,233,86,4,223,244,247,84,136,4,177,244,19,147,169,46,61,37,51,58,232,204,132,164,36,90,32,95,135,111,181,175,107,196,120,75,189,107,62,58,10,5,142,157,102,7,208,25,1,206,112,159,3,121,239,136,151,151,59,247,125,228,143,106,199,1,255,3,194,13,161,168,10,74,126,225,111,116,251,55,186,184,87,23,160,181,110,20,235,165,127,102,110,241,230,128,104,186,40,156,40,34,85,250,192,212,194,32,162,183,111,145,227,20,189,129,218,42,103,104,243,49,68,11,218,196,14,60,80,10,234,81,176,76,117,202,26,175,102,136,156,160,56,226,241,255,65,16,231,90,154,87,171,234,81,61,213,27,199,102,216,214,210,156,218,113,127,67,56,252,45,161,58,238,83,42,135,130,115,106,90,56,132,249,226,104,248,248,182,110,4,228,72,138,142,196,131,142,14,77,165,19,244,189,106,125,232,146,0,239,71,140,52,129,253,51,123,185,5,148,42,162,190,152,147,159,189,113,248,192,98,181,56,244,239,48,75,84,38,233,152,207,4,60,218,224,149,17,174,10,97,189,183,77,120,188,54,224,95,41,155,47,212,127,64,118,211,163,27,188,113,142,29,4,135,193,251,143,244,246,51,189,210,195,135,233,171,171,236,188,176,63,82,236,54,203,143,223,219,111,199,11,210,147,59,51,95,143,142,7,69,153,54,240,134,119,34,252,110,24,151,236,181,182,169,175,99,86,33,84,175,34,140,167,160,230,227,97,34,82,122,3,203,26,232,224,160,44,186,168,34,254,60,125,6,232,166,235,57,198,79,3,59,85,235,166,80,213,58,244,182,67,235,216,0,92,211,175,4,104,160,199,114,13,49,252,157,242,185,90,160,143,232,157,69,244,26,67,50,122,81,225,104,13,19,98,223,38,240,218,154,0,54,26,216,176,25,127,77,112,176,101,76,169,126,100,50,158,8,18,119,123,168,124,193,129,131,158,253,184,213,214,188,182,229,118,113,241,76,94,110,168,90,136,56,13,239,22,82,108,236,58,98,152,6,237,32,218,5,60,48,250,231,117,88,39,238,138,203,26,105,247,215,107,63,234,182,30,85,179,244,47,204,225,32,63,21,129,60,48,29,224,233,201,163,95,223,220,29,20,245,110,119,151,82,119,7,235,85,86,186,106,63,186,243,195,248,235,72,10,147,138,215,119,220,106,254,119,72,231,88,175,174,229,94,107,151,186,247,122,169,67,5,128,217,84,224,219,15,78,252,215,162,137,57,3,226,47,150,18,15,178,161,13,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateModifyEditPageParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("04b3acc8-6603-4760-bb63-21ef9026368a"),
				Name = "ModifyEditPageParameters",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d7a204c6-7b93-4b39-9c9e-ef2e62e430da"),
				Name = "openPageParameters",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("618becc4-c6d9-4bc1-9063-de1ea6675db2"),
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

		protected virtual SchemaMethod CreatePopulateEditPagesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0ba6b1bf-06d9-4de1-802d-1df74260cc0c"),
				Name = "PopulateEditPages",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,209,106,194,48,20,125,174,224,63,220,245,65,82,144,250,1,155,131,81,58,241,193,205,225,156,207,153,185,206,176,54,169,73,234,40,99,255,190,164,41,26,21,217,160,15,237,201,201,57,231,158,219,209,8,158,247,168,20,103,8,70,130,70,3,57,227,102,78,63,112,57,101,253,222,158,42,216,213,168,26,24,131,192,47,200,133,225,166,89,172,183,88,210,23,135,147,165,70,149,73,33,112,109,184,20,105,72,152,81,97,117,212,16,226,69,163,103,146,213,5,58,241,56,185,245,194,58,68,167,44,147,69,93,138,39,90,162,53,107,77,211,7,214,161,36,158,178,56,73,221,97,119,185,178,210,222,102,249,215,85,235,62,15,217,71,33,190,1,18,204,11,227,49,76,106,206,210,188,172,76,3,131,1,44,78,35,94,18,194,121,157,194,77,72,72,224,187,223,139,124,158,71,94,24,84,218,229,34,30,201,20,82,131,30,95,113,179,157,83,101,83,57,18,241,96,38,203,138,42,174,165,120,109,42,76,243,93,77,139,33,88,197,40,40,180,245,79,237,247,89,146,120,120,158,45,113,189,71,174,59,236,70,214,135,182,38,104,60,219,118,86,248,85,158,109,182,189,188,145,54,243,122,11,36,84,1,46,142,138,126,228,232,164,212,195,169,179,113,163,116,155,121,163,69,141,119,174,174,123,114,101,157,173,107,116,177,133,255,40,94,253,187,188,230,187,157,228,211,189,253,244,123,246,249,5,98,29,137,78,9,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8b895e79-1a67-42d3-be48-48dcdc8ca6d2"),
				Name = "GetRegisterAddPageScript",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f1ce5b15-b444-453c-8354-2dd65a989775"),
				Name = "editPageUId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("909b36d9-50f7-4bec-a478-46a74f80b3d9"),
				Name = "sysModuleEditId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,75,115,219,54,16,62,203,51,254,15,8,15,33,153,114,144,156,171,38,51,142,44,187,154,198,19,79,109,199,7,199,211,129,8,72,130,67,1,46,0,74,214,104,248,223,187,0,73,241,41,201,105,15,61,137,194,238,126,251,192,238,183,88,17,133,228,51,19,215,100,206,174,137,34,75,102,152,210,232,35,18,108,141,206,121,108,184,20,68,109,126,211,70,113,49,143,144,156,62,177,216,124,10,66,180,61,61,25,12,182,222,87,48,102,106,34,180,33,34,102,19,234,69,200,98,225,107,37,99,166,53,46,37,119,19,154,69,131,1,24,101,195,211,147,211,147,21,56,254,59,101,106,115,227,144,95,227,59,255,45,125,111,61,197,98,169,168,115,153,139,240,133,84,75,98,2,207,223,126,200,124,56,190,76,57,197,227,229,179,217,132,89,228,108,152,48,220,108,110,226,5,91,146,59,107,186,199,114,220,212,43,205,141,98,236,82,241,131,78,93,250,183,133,34,30,37,28,124,78,206,75,132,155,141,190,146,52,77,216,152,114,115,8,70,55,21,195,236,244,196,86,142,207,80,48,209,231,204,16,158,88,7,121,49,108,53,137,126,182,174,161,126,46,130,179,226,47,209,232,150,41,69,180,156,25,124,55,193,247,108,58,146,194,40,153,104,108,21,134,133,57,37,134,220,200,84,197,172,8,153,2,146,183,230,130,202,245,195,248,197,96,10,229,166,44,176,159,115,102,2,63,78,181,145,203,115,48,187,224,44,161,126,136,169,92,226,21,73,82,22,62,248,187,60,255,34,112,145,43,118,190,131,247,31,31,61,235,180,247,246,241,25,165,65,85,164,60,207,67,101,234,168,134,225,17,112,248,15,233,229,23,236,144,123,50,255,5,121,56,143,251,79,185,182,233,94,43,190,132,94,28,201,36,93,138,111,54,199,32,244,126,198,83,222,74,71,50,105,170,30,205,228,78,179,122,238,251,161,91,138,218,33,67,67,193,33,159,109,0,171,57,254,65,151,17,162,254,97,13,119,179,172,167,197,224,230,42,159,83,158,80,166,2,171,160,167,248,236,25,16,33,226,170,19,173,139,123,215,92,129,171,99,142,49,34,73,50,37,241,143,189,88,86,77,164,73,146,75,108,135,218,127,94,33,137,11,243,74,58,75,133,227,145,96,45,236,168,108,17,84,4,101,89,105,144,183,183,107,116,65,189,102,172,190,215,10,254,27,103,107,55,90,48,105,47,32,28,28,86,143,80,251,164,173,194,96,178,45,32,16,12,190,149,121,208,65,216,99,52,56,2,252,224,14,166,82,38,136,235,11,174,180,129,148,140,74,237,112,207,164,98,36,94,160,192,230,251,92,222,28,226,98,207,141,58,62,177,44,83,32,21,76,95,225,206,72,162,29,107,100,136,193,87,46,238,134,55,128,254,170,31,127,23,223,205,86,128,151,95,11,121,167,48,181,147,93,156,248,15,182,57,170,237,69,157,19,228,120,168,112,245,254,157,75,232,77,133,234,38,24,223,24,162,140,190,231,102,225,64,209,219,183,168,225,24,189,129,198,216,109,153,126,113,139,77,194,78,57,220,253,185,189,247,238,253,158,28,93,52,135,2,29,11,250,191,133,233,101,94,193,22,245,203,52,143,251,218,50,111,179,57,203,89,236,138,8,248,86,208,54,192,65,10,22,143,96,110,30,241,37,51,13,13,203,150,45,35,136,18,150,87,231,184,88,130,227,106,120,108,134,181,85,191,219,136,85,24,224,191,19,147,13,161,124,157,124,222,0,76,29,210,37,215,184,172,210,26,223,115,106,22,213,188,142,210,196,164,138,77,196,76,194,99,7,220,114,34,76,113,24,118,26,21,149,101,238,133,254,157,241,249,194,252,23,236,246,69,89,18,56,74,76,21,161,254,172,102,201,215,181,41,175,104,213,246,222,199,18,161,163,233,239,17,116,119,207,67,247,145,249,216,225,203,87,227,123,195,178,115,123,130,135,45,128,127,184,176,119,41,12,29,142,237,184,110,100,216,190,164,8,23,26,244,2,111,148,72,216,179,240,232,5,29,47,172,218,48,174,157,127,157,62,1,120,95,142,13,235,199,97,65,194,109,91,232,116,123,7,197,252,182,209,1,186,101,80,171,211,208,209,120,11,19,127,97,98,110,22,232,19,250,80,96,14,122,11,99,95,125,227,21,80,72,57,60,176,82,243,58,246,90,228,213,203,93,246,1,70,200,159,50,187,153,82,145,72,66,253,8,237,22,53,132,97,87,133,183,223,216,230,80,61,36,206,158,200,203,21,51,11,73,53,190,93,40,185,206,31,113,46,216,240,0,138,117,2,27,201,254,188,14,236,80,190,222,174,93,14,120,140,14,200,252,253,178,250,117,253,43,0,144,100,7,11,145,133,110,38,6,142,152,220,222,206,218,60,210,97,130,230,75,179,249,240,138,106,47,185,250,160,182,216,37,204,71,75,49,160,51,1,38,245,94,253,7,243,39,158,244,152,14,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateModifyAddPageParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8fa07cbc-ded8-41f5-8caa-1ffac3d49c58"),
				Name = "ModifyAddPageParameters",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("836a8d86-7c01-4ae5-873c-c8066cb5a84e"),
				Name = "openPageParameters",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ae4b4ea5-d372-4340-a874-2b368cf0c932"),
				Name = "queryStringParameters",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateGetRegisterCopyPageScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("924c475c-ab29-41cf-b4e2-587ff5399161"),
				Name = "GetRegisterCopyPageScript",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6a9078a3-89b8-41d4-bed2-597862b1defc"),
				Name = "editPageUId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("919e139d-3e8e-445e-a230-4275c82acec0"),
				Name = "sysModuleEditId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,207,115,226,54,20,62,155,191,66,171,195,218,78,169,217,94,75,179,51,9,97,83,166,77,151,41,201,230,176,201,116,132,45,64,89,35,81,73,134,48,140,255,247,62,73,6,108,99,211,180,61,244,100,208,123,239,123,223,251,41,173,137,68,98,69,249,152,204,233,152,72,178,164,154,74,133,46,17,167,27,116,195,98,205,4,39,114,251,147,210,146,241,121,23,137,233,11,141,245,199,32,68,187,142,231,237,240,103,176,165,114,196,149,38,60,166,163,4,119,145,129,138,198,82,196,84,169,104,47,121,24,37,121,215,243,58,94,222,239,116,214,224,244,207,140,202,237,196,162,190,197,175,251,22,126,119,88,210,88,200,196,186,187,165,250,134,104,50,17,153,140,105,16,70,131,148,81,174,71,55,232,59,132,35,2,64,107,250,187,216,68,115,170,199,146,45,1,115,32,210,108,201,191,144,52,3,117,156,119,13,30,88,48,189,157,196,11,186,36,15,6,214,249,139,62,9,185,36,58,192,254,238,67,238,131,179,97,85,47,116,214,90,82,122,43,153,227,211,98,105,179,114,95,40,30,72,22,0,3,177,218,130,14,246,181,204,168,95,112,154,108,213,157,72,178,148,14,19,166,207,65,171,170,98,152,119,32,201,112,194,102,91,3,92,45,109,112,90,237,110,115,49,194,162,82,106,90,148,197,41,92,103,44,77,168,12,64,220,235,25,185,222,174,172,103,3,10,57,153,196,146,173,52,152,212,216,2,89,83,132,65,166,180,88,154,138,5,190,177,28,37,127,248,80,170,221,15,121,181,88,229,42,181,152,58,149,223,128,174,31,134,145,164,171,148,64,7,244,190,239,65,191,248,112,180,207,250,85,146,92,103,90,11,126,72,123,123,215,64,84,106,26,93,173,32,73,73,128,239,169,148,68,137,153,142,76,214,30,25,79,196,38,192,160,227,242,50,32,105,58,37,241,183,182,252,24,45,158,165,169,19,128,22,54,255,176,19,196,133,241,81,56,203,184,237,251,96,195,19,232,243,29,130,184,81,158,23,250,27,235,221,232,129,24,87,104,250,184,74,251,11,163,27,27,57,81,171,87,144,121,231,148,161,237,108,41,217,12,5,247,135,172,66,33,209,229,37,186,205,160,89,135,203,149,222,218,193,171,195,148,14,232,177,3,162,123,225,130,10,194,170,142,53,242,58,189,139,28,209,84,209,42,98,99,27,129,125,126,209,59,165,91,58,248,106,254,79,133,72,17,83,159,152,84,166,245,204,24,245,59,51,33,41,137,23,40,48,233,91,237,251,26,49,222,210,239,134,143,201,66,129,227,86,220,17,116,70,128,51,196,115,36,239,157,240,242,242,74,188,79,252,73,239,56,224,255,136,112,67,42,202,7,7,126,209,47,116,251,55,186,184,91,63,64,107,51,40,206,75,239,194,70,241,238,136,104,167,40,154,104,34,181,122,100,122,97,17,209,251,247,168,226,20,189,131,222,58,44,214,102,49,100,11,198,196,109,65,80,10,235,89,176,5,54,91,30,138,214,24,156,165,114,134,228,144,39,255,15,69,156,155,220,229,229,206,122,210,207,245,225,113,85,118,253,52,167,238,30,184,35,28,126,75,232,144,7,69,229,64,112,78,237,24,71,176,99,42,26,1,30,215,141,128,30,81,232,228,184,223,49,201,41,77,131,137,172,54,139,85,18,224,253,132,145,33,176,191,127,175,183,128,82,70,52,129,85,42,180,55,142,30,89,162,23,199,25,30,100,169,206,36,29,241,153,128,219,28,188,50,194,117,113,88,159,111,155,30,175,13,248,103,202,230,11,253,31,144,171,229,49,67,222,184,203,142,7,199,229,251,143,244,246,123,189,52,199,199,13,108,250,236,178,176,63,81,244,155,207,79,239,220,175,167,47,167,231,234,222,124,59,58,238,23,109,218,192,27,238,138,232,155,101,124,96,111,180,109,127,157,178,138,160,123,53,97,92,129,90,128,7,169,80,244,14,94,113,160,131,195,67,211,197,165,227,207,211,23,128,110,10,175,98,252,220,119,155,181,110,10,93,109,82,239,102,180,142,13,192,53,253,82,130,250,102,53,215,16,163,95,41,159,235,5,250,136,62,56,68,175,49,37,195,87,29,13,215,176,35,246,99,2,55,174,77,96,163,129,75,155,245,215,4,7,47,141,41,53,23,77,198,83,65,18,191,139,14,183,56,112,48,251,31,183,218,218,27,247,240,194,184,122,33,175,119,84,47,68,162,162,251,133,20,27,247,36,177,76,195,118,16,227,2,46,25,243,121,27,214,153,88,241,161,71,218,253,117,219,69,126,171,168,92,165,127,97,14,130,252,92,6,242,208,78,128,103,54,143,185,129,243,234,162,168,79,123,245,97,90,125,135,117,75,207,186,242,60,86,247,135,245,215,145,20,54,21,7,131,114,95,254,5,227,71,219,210,81,13,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateModifyCopyPageParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cb343323-0455-4df3-81c5-c9f259b5ca62"),
				Name = "ModifyCopyPageParameters",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4407172d-64df-45e0-9e52-3e0851184bc0"),
				Name = "openPageParameters",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("679a5a56-c39e-43f9-a3be-551ca8090742"),
				Name = "queryStringParameters",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateSetEntitySchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("79aae19b-73c4-4f54-ad67-04bc94699b1c"),
				Name = "SetEntitySchemaUId",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("865a4524-5bd7-44ee-a739-48f536c679dd"),
				Name = "schemaName",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				ModifiedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,141,49,14,194,48,16,4,107,252,138,43,147,198,121,0,162,1,69,145,11,146,2,229,1,150,125,4,75,246,5,249,46,72,22,226,239,132,84,41,168,119,118,166,105,134,23,230,28,60,130,204,192,40,208,146,4,41,55,247,192,100,85,184,67,197,146,3,77,218,112,191,196,56,228,54,61,165,84,188,237,189,77,88,215,240,86,135,253,107,52,30,78,208,45,193,235,13,62,170,15,96,100,252,207,141,140,249,50,19,161,147,48,147,222,3,87,75,118,194,172,59,20,67,44,150,28,158,203,175,185,207,235,85,179,22,190,118,146,49,132,201,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseActiveRowChangedHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8b913036-f76b-4428-b7c4-44d3675bd50d"),
				Name = "BaseActiveRowChangedHandler",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,201,44,75,44,73,117,42,45,41,201,207,43,214,40,41,42,77,213,180,230,202,76,211,240,44,118,73,45,73,204,204,113,47,202,76,209,84,168,230,226,44,74,45,41,45,202,179,230,170,229,242,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,128,9,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,129,180,59,130,44,73,13,202,47,119,206,72,204,75,79,77,81,2,218,0,0,196,91,122,124,121,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBaseLoadRowsResponseRegisteredHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6236a011-7dd7-44cf-b826-130b48e865aa"),
				Name = "BaseLoadRowsResponseRegisteredHandler",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("51b8b345-a219-40fc-9093-0d6a4b7c4674"),
				Name = "sender",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3d7a9afe-60b5-4831-bf60-d37edde10d3a"),
				Name = "e",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,82,193,106,2,49,16,61,43,248,15,163,7,89,65,22,239,98,193,170,136,32,69,106,219,75,233,33,108,166,109,32,187,105,147,201,138,20,255,189,73,236,174,171,86,91,219,28,2,251,50,243,222,188,217,151,51,13,156,17,91,42,171,19,132,1,76,145,198,229,119,212,233,55,234,249,94,201,173,90,153,145,178,25,185,218,29,26,123,56,14,184,235,168,224,75,148,152,16,242,25,97,186,208,34,101,122,61,82,210,166,217,3,147,22,93,139,68,166,75,25,150,144,200,189,196,253,140,251,89,172,224,241,36,125,163,181,123,23,207,16,57,29,124,119,109,20,15,165,70,198,29,87,70,76,100,198,203,119,224,163,81,175,237,105,211,72,10,204,104,88,208,70,149,215,18,60,30,171,11,164,45,250,161,106,23,88,25,114,254,75,254,192,236,253,52,103,102,140,206,128,156,106,193,183,243,187,3,0,133,214,141,226,120,220,191,191,250,51,66,253,146,112,46,12,97,134,250,238,85,171,213,36,119,75,137,10,104,193,94,156,134,74,208,24,183,246,46,180,252,48,115,197,184,95,106,171,179,227,8,66,140,240,218,18,169,204,68,229,146,54,141,250,6,80,26,12,14,188,177,239,242,114,5,189,47,139,225,87,66,115,0,153,149,18,218,109,8,249,41,128,98,15,7,97,8,53,241,9,143,21,249,163,198,131,148,62,246,158,78,178,248,235,124,128,170,220,149,152,92,154,147,237,78,253,185,32,49,85,147,127,154,114,115,38,118,63,38,174,202,25,44,255,47,82,126,150,195,64,157,74,141,171,119,229,159,30,96,109,137,171,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("13621607-e951-4f54-ad88-38e31adaca8e"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,205,10,130,80,16,133,215,250,20,211,70,20,196,23,144,54,73,164,139,32,48,219,223,188,163,14,232,40,58,70,20,189,123,215,254,200,90,13,243,157,51,115,102,168,0,119,177,65,73,134,168,101,193,179,196,88,119,171,81,164,229,152,180,70,118,61,112,28,248,117,172,89,29,107,212,174,231,193,213,182,6,233,137,75,168,140,240,242,36,26,150,176,83,37,6,105,94,97,163,130,248,91,11,109,235,164,122,24,7,236,13,99,204,133,90,126,15,100,51,106,172,251,212,180,5,149,99,175,38,18,28,72,99,59,237,203,132,106,18,194,33,72,216,84,85,211,5,255,190,112,31,75,255,176,63,191,214,135,45,242,56,201,137,96,19,169,110,74,122,194,79,220,76,153,223,238,133,246,237,14,159,224,29,124,74,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseVirtualGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("119c8333-6931-4165-861e-0db0c22e0503"));
		}

		#endregion

	}

	#endregion

}

