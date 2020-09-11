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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: BaseEditPageSchema

	/// <exclude/>
	public class BaseEditPageSchema : Terrasoft.UI.WebControls.PageSchema
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _customControls;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CustomControls {
			get {
				return _customControls;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return _buttonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _designerModeButton;
		public Terrasoft.UI.WebControls.Controls.Button DesignerModeButton {
			get {
				return _designerModeButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacerButton;
		public Terrasoft.UI.WebControls.Controls.Spacer SpacerButton {
			get {
				return _spacerButton;
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

		private Terrasoft.UI.WebControls.Controls.Button _applyChangesButton;
		public Terrasoft.UI.WebControls.Controls.Button ApplyChangesButton {
			get {
				return _applyChangesButton;
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

		public BaseEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseEditPageSchema(BaseEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			RealUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			Name = "BaseEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ValidationMessagePanel = "BaseMessagePanel";
			HelpContextId = "qwerty5";
			PrimaryDataSourceName = "DataSource";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateCustomControls());
			Controls.AddAt(2, CreateButtonsControlLayout());
			ButtonsControlLayout.InsertItem(0, CreateContextHelpButton());
			ButtonsControlLayout.InsertItem(1, CreateDesignerModeButton());
			ButtonsControlLayout.InsertItem(2, CreateSpacerButton());
			ButtonsControlLayout.InsertItem(3, CreateOKButton());
			ButtonsControlLayout.InsertItem(4, CreateCancelButton());
			ButtonsControlLayout.InsertItem(5, CreateApplyChangesButton());
			Controls.AddAt(3, CreateDataSource());
			UpdateDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseEditPageEventsProcessSchema() {
			var schema = new BaseEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("e2117cea-a18d-41e8-9bf2-f3238399d9d4");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCustomControls() {
			_customControls = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_customControls.UId = new Guid("098b7849-2919-43fe-a6ff-c33f9e9658c9");
			_customControls.Name = "CustomControls";
			_customControls.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_customControls.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_customControls.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customControls.Tag = "";
			_customControls.Height = System.Web.UI.WebControls.Unit.Pixel(20);
			_customControls.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_customControls.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_customControls.StartNewAlignGroup = false;
			_customControls.Image = new ControlImage {};
			_customControls.Edges = "";
			return _customControls;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("0bbb52f6-e514-4717-b6b4-39050d7b2b6b");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Padding = "5 5 5 5";
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			_mainControlLayout.AutoScroll = true;
			return _mainControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("d7c559c6-5bd4-48a9-a3c4-466d36b4c73d");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDesignerModeButton() {
			_designerModeButton = new Terrasoft.UI.WebControls.Controls.Button();
			_designerModeButton.UId = new Guid("b986ef04-54a2-4589-a297-bb5f8a5202e3");
			_designerModeButton.Name = "DesignerModeButton";
			_designerModeButton.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_designerModeButton.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_designerModeButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_designerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_designerModeButton.Tag = "";
			_designerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			_designerModeButton.Hidden = true;
			return _designerModeButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacerButton() {
			_spacerButton = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacerButton.UId = new Guid("11366a38-83c0-4f9a-8a46-f0bd2164325c");
			_spacerButton.Name = "SpacerButton";
			_spacerButton.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_spacerButton.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_spacerButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacerButton.Tag = "";
			_spacerButton.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacerButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOKButton() {
			_oKButton = new Terrasoft.UI.WebControls.Controls.Button();
			_oKButton.UId = new Guid("25cc945d-725d-49b0-8c69-12942916030d");
			_oKButton.Name = "OKButton";
			_oKButton.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_oKButton.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_oKButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_oKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_oKButton.Tag = "";
			_oKButton.Image = new ControlImage {};
			return _oKButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("104db207-4b6b-4e0c-b66d-51f40d274f72");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_cancelButton.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateApplyChangesButton() {
			_applyChangesButton = new Terrasoft.UI.WebControls.Controls.Button();
			_applyChangesButton.UId = new Guid("f266b84e-44ce-4a6c-ace2-07e55d0ecd09");
			_applyChangesButton.Name = "ApplyChangesButton";
			_applyChangesButton.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_applyChangesButton.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_applyChangesButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_applyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_applyChangesButton.Tag = "";
			_applyChangesButton.Image = new ControlImage {};
			_applyChangesButton.Hidden = true;
			return _applyChangesButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonsControlLayout() {
			_buttonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonsControlLayout.UId = new Guid("64e56578-6b5d-4a19-9b25-10ca502ad731");
			_buttonsControlLayout.Name = "ButtonsControlLayout";
			_buttonsControlLayout.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_buttonsControlLayout.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_buttonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttonsControlLayout.Tag = "";
			_buttonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttonsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_buttonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_buttonsControlLayout.FitHeightByContent = true;
			_buttonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonsControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_buttonsControlLayout.StartNewAlignGroup = false;
			_buttonsControlLayout.Image = new ControlImage {};
			_buttonsControlLayout.Edges = "1 0 0 0";
			return _buttonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateDataSource() {
			_dataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_dataSource.UId = new Guid("a83cb1d7-2d2e-4094-bb42-5abe1749d6ec");
			_dataSource.Name = "DataSource";
			_dataSource.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_dataSource.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_dataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataSource.Tag = "";
			_dataSource.EnableServerActiveRow = false;
			_dataSource.SchemaUId = Guid.Empty;
			_dataSource.HierarchicalDepth = 1;
			_dataSource.DefStructure.ID = "c" + _dataSource.DefStructure.UId.ToString("N");
			_dataSource.DefStructure.UId = new Guid("e610f96f-b37f-4eea-bffb-9d6ee87f38ba");
			_dataSource.DefStructure.Name = "DefStructure";
			_dataSource.DefStructure.CreatedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			_dataSource.DefStructure.ModifiedInSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
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
			return new BaseEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseEditPageEventsProcess

	/// <exclude/>
	public class BaseEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Class: TreeGridLoadRowUserTaskFlowElement

		/// <exclude/>
		public class TreeGridLoadRowUserTaskFlowElement : TreeGridLoadRowUserTask
		{

			public TreeGridLoadRowUserTaskFlowElement(UserConnection userConnection, BaseEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "TreeGridLoadRowUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("ab5c5dfb-c112-4422-b486-2684ad2f53a2");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenPageSchemaDesigner_UserTaskFlowElement

		/// <exclude/>
		public class OpenPageSchemaDesigner_UserTaskFlowElement : OpenPageUserTask
		{

			public OpenPageSchemaDesigner_UserTaskFlowElement(UserConnection userConnection, BaseEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenPageSchemaDesigner_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenMessageUserTask223FlowElement

		/// <exclude/>
		public class OpenMessageUserTask223FlowElement : QuestionUserTask
		{

			public OpenMessageUserTask223FlowElement(UserConnection userConnection, BaseEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenMessageUserTask223";
				IsLogging = false;
				SchemaElementUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenContinueMessageUserTaskFlowElement

		/// <exclude/>
		public class OpenContinueMessageUserTaskFlowElement : QuestionUserTask
		{

			public OpenContinueMessageUserTaskFlowElement(UserConnection userConnection, BaseEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenContinueMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d");
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

		public BaseEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseEditPageEventsProcess";
			SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
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

		public virtual Guid EntityPrimaryColumnValue {
			get;
			set;
		}

		public virtual string AdditionalScriptAfterSave {
			get;
			set;
		}

		public virtual bool IsCopy {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual bool IsCaptionExists {
			get;
			set;
		}

		public virtual bool NeedRefreshGrid {
			get;
			set;
		}

		public virtual string PrimaryDisplayColumnValue {
			get;
			set;
		}

		public virtual bool SynchronizeDataSourceStructure {
			get;
			set;
		}

		public virtual Guid PrimaryColumnValue {
			get;
			set;
		}

		public virtual string SuccesfullCloseMessage {
			get;
			set;
		}

		public virtual bool IsNotWindowClose {
			get;
			set;
		}

		public virtual bool IsEdit {
			get;
			set;
		}

		private string _menuHelpItemCaption;
		public virtual string MenuHelpItemCaption {
			get {
				return _menuHelpItemCaption ?? (_menuHelpItemCaption = new LocalizableString(Storage, "a5bcc8d7215f41c58f3cf96f57d48c34",
						 "EventsProcessSchema.Parameters.MenuHelpItemCaption.Value"));
			}
			set {
				_menuHelpItemCaption = value;
			}
		}

		private string _menuVideoHelpItemCaption;
		public virtual string MenuVideoHelpItemCaption {
			get {
				return _menuVideoHelpItemCaption ?? (_menuVideoHelpItemCaption = new LocalizableString(Storage, "a5bcc8d7215f41c58f3cf96f57d48c34",
						 "EventsProcessSchema.Parameters.MenuVideoHelpItemCaption.Value"));
			}
			set {
				_menuVideoHelpItemCaption = value;
			}
		}

		public virtual bool IsSchemaBlocked {
			get;
			set;
		}

		public virtual string BlockedSchemaMessageText {
			get;
			set;
		}

		public virtual bool IsBasePageSchema {
			get;
			set;
		}

		public virtual bool IsBasePage {
			get;
			set;
		}

		public virtual Guid FolderUidBasePageEntity {
			get;
			set;
		}

		public virtual string NewPageEntityName {
			get;
			set;
		}

		public virtual Guid PrimaryEntitySchemaUId {
			get;
			set;
		}

		public virtual string SysModuleEditId {
			get;
			set;
		}

		private ProcessFlowElement _baseEventSubProcessPageLoadComplete;
		public ProcessFlowElement BaseEventSubProcessPageLoadComplete {
			get {
				return _baseEventSubProcessPageLoadComplete ?? (_baseEventSubProcessPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEventSubProcessPageLoadComplete",
					SchemaElementUId = new Guid("ec1b166c-6c70-45fc-ad5d-2476308c3e37"),
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
					SchemaElementUId = new Guid("344c1d94-f539-433b-b90c-5ab36b6a92c0"),
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
					SchemaElementUId = new Guid("0a4ac78f-bbcb-44a0-af53-1d3156bc75e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteExecute,
				});
			}
		}

		private ProcessFlowElement _baseEventSubProcessOkButtonClick;
		public ProcessFlowElement BaseEventSubProcessOkButtonClick {
			get {
				return _baseEventSubProcessOkButtonClick ?? (_baseEventSubProcessOkButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEventSubProcessOkButtonClick",
					SchemaElementUId = new Guid("80660e8b-5d62-4dad-8708-d67436c56390"),
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
					SchemaElementUId = new Guid("570f7190-4f9a-4c59-b921-3fb6604ef35e"),
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
					SchemaElementUId = new Guid("168424fd-2e64-4fba-b50f-616df20a706e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOKButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _baseEventSubProcessCancellButtonClick;
		public ProcessFlowElement BaseEventSubProcessCancellButtonClick {
			get {
				return _baseEventSubProcessCancellButtonClick ?? (_baseEventSubProcessCancellButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEventSubProcessCancellButtonClick",
					SchemaElementUId = new Guid("fbc99e83-d018-4c21-a551-f2f4d71cc46c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClick;
		public ProcessFlowElement CancelButtonClick {
			get {
				return _cancelButtonClick ?? (_cancelButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CancelButtonClick",
					SchemaElementUId = new Guid("842905ff-4c9d-4400-9347-65424e516a94"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptCancelButtonClick;
		public ProcessScriptTask ScriptCancelButtonClick {
			get {
				return _scriptCancelButtonClick ?? (_scriptCancelButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptCancelButtonClick",
					SchemaElementUId = new Guid("d2d0e38e-1a3d-4300-b706-cb579699f2e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptCancelButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _baseSubProcessDataSourceSaved;
		public ProcessFlowElement BaseSubProcessDataSourceSaved {
			get {
				return _baseSubProcessDataSourceSaved ?? (_baseSubProcessDataSourceSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseSubProcessDataSourceSaved",
					SchemaElementUId = new Guid("57a0bb57-527e-4e50-bd61-ab14437b2695"),
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
					SchemaElementUId = new Guid("7f51c8f5-1120-4541-a07e-1d312115dadd"),
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
					SchemaElementUId = new Guid("65bff8e7-adb5-46db-8a49-917b6122d7d4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceSavedExecute,
				});
			}
		}

		private TreeGridLoadRowUserTaskFlowElement _treeGridLoadRowUserTask;
		public TreeGridLoadRowUserTaskFlowElement TreeGridLoadRowUserTask {
			get {
				return _treeGridLoadRowUserTask ?? (_treeGridLoadRowUserTask = new TreeGridLoadRowUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTaskCloseWindowAfterSave;
		public ProcessScriptTask ScriptTaskCloseWindowAfterSave {
			get {
				return _scriptTaskCloseWindowAfterSave ?? (_scriptTaskCloseWindowAfterSave = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskCloseWindowAfterSave",
					SchemaElementUId = new Guid("4aad0d51-bce3-45cf-b6ab-54fe9375df97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskCloseWindowAfterSaveExecute,
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
					SchemaElementUId = new Guid("6ad2c194-854a-494f-97ff-30a9d838fc08"),
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

		private ProcessFlowElement _basePageLoadSubProcess;
		public ProcessFlowElement BasePageLoadSubProcess {
			get {
				return _basePageLoadSubProcess ?? (_basePageLoadSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BasePageLoadSubProcess",
					SchemaElementUId = new Guid("f00b5152-f4ab-4319-8d23-1ffef6884a80"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoad;
		public ProcessFlowElement PageLoad {
			get {
				return _pageLoad ?? (_pageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoad",
					SchemaElementUId = new Guid("419111f5-d617-4a4d-8234-27b88c987edc"),
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
					SchemaElementUId = new Guid("be2635dd-cae2-4bbd-9745-3706adc609f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadExecute,
				});
			}
		}

		private ProcessFlowElement _baseInitEventSubProcess;
		public ProcessFlowElement BaseInitEventSubProcess {
			get {
				return _baseInitEventSubProcess ?? (_baseInitEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseInitEventSubProcess",
					SchemaElementUId = new Guid("ce62d125-1572-4b36-a9f2-8a7325b02ffb"),
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
					SchemaElementUId = new Guid("033b480f-7a8c-4526-96d4-5df991e5be54"),
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
					SchemaElementUId = new Guid("a7dc6bf1-c6ce-40ae-b1ae-743b61b3e729"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptExecute,
				});
			}
		}

		private ProcessFlowElement _baseEventSubProcessApplyButtonClick;
		public ProcessFlowElement BaseEventSubProcessApplyButtonClick {
			get {
				return _baseEventSubProcessApplyButtonClick ?? (_baseEventSubProcessApplyButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseEventSubProcessApplyButtonClick",
					SchemaElementUId = new Guid("5b967f67-fea2-4eb8-9b96-6e05906cae56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseStartMessageApplyButtonClick;
		public ProcessFlowElement BaseStartMessageApplyButtonClick {
			get {
				return _baseStartMessageApplyButtonClick ?? (_baseStartMessageApplyButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseStartMessageApplyButtonClick",
					SchemaElementUId = new Guid("c23df4eb-d85f-4c26-9840-d093e961ce0a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptApplyChangesButtonClick;
		public ProcessScriptTask ScriptApplyChangesButtonClick {
			get {
				return _scriptApplyChangesButtonClick ?? (_scriptApplyChangesButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptApplyChangesButtonClick",
					SchemaElementUId = new Guid("cd6630e9-5cd5-4bd1-b475-34b85b3bd2d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptApplyChangesButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess223;
		public ProcessFlowElement EventSubProcess223 {
			get {
				return _eventSubProcess223 ?? (_eventSubProcess223 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess223",
					SchemaElementUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
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
					SchemaElementUId = new Guid("808ce38e-dc30-48fa-9180-f1adcbbd9205"),
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
					SchemaElementUId = new Guid("3b5ecbe1-d09e-440a-814d-29bcf66be0de"),
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

		private ProcessScriptTask _openMessageScriptTask223;
		public ProcessScriptTask OpenMessageScriptTask223 {
			get {
				return _openMessageScriptTask223 ?? (_openMessageScriptTask223 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpenMessageScriptTask223",
					SchemaElementUId = new Guid("8d5a54c5-07a3-447b-8b11-e60635d2adb3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpenMessageScriptTask223Execute,
				});
			}
		}

		private OpenMessageUserTask223FlowElement _openMessageUserTask223;
		public OpenMessageUserTask223FlowElement OpenMessageUserTask223 {
			get {
				return _openMessageUserTask223 ?? (_openMessageUserTask223 = new OpenMessageUserTask223FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEvent1;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEvent1 {
			get {
				return _intermediateCatchMessageEvent1 ?? (_intermediateCatchMessageEvent1 = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEvent1",
					SchemaElementUId = new Guid("a12f5a49-9486-4fa6-bf02-b8070daa132b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "YesOpenSchema",
				});
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
					SchemaElementUId = new Guid("572a0d59-bce6-46da-a4f9-890c1470503a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = GetIsEntitySchemaBlockedScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway223;
		public ProcessExclusiveGateway ExclusiveGateway223 {
			get {
				return _exclusiveGateway223 ?? (_exclusiveGateway223 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway223",
					SchemaElementUId = new Guid("492b99e9-cfae-49c0-83b2-9171440c55ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway223.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEvent2;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEvent2 {
			get {
				return _intermediateCatchMessageEvent2 ?? (_intermediateCatchMessageEvent2 = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEvent2",
					SchemaElementUId = new Guid("98f8095a-b08c-4ed5-92f6-bc5aab9e4cfe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "NoOpenSchema",
				});
			}
		}

		private ProcessEndEvent _end223;
		public ProcessEndEvent End223 {
			get {
				return _end223 ?? (_end223 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End223",
					SchemaElementUId = new Guid("2b34f89b-c43d-4f59-94f5-52657163193c"),
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
					SchemaElementUId = new Guid("02b2852c-3a27-4838-8c05-7fa20d83096b"),
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
					SchemaElementUId = new Guid("1433783e-76c3-4190-974e-edc838111e6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareUserTaskParametersScriptTaskExecute,
				});
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
					SchemaElementUId = new Guid("f861f45a-00e0-4dd7-aef4-51d7bc6b09bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("90e17638-f884-444a-a4bb-621fa6ac4816"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "YesContinueOpenSchema",
				});
			}
		}

		private OpenContinueMessageUserTaskFlowElement _openContinueMessageUserTask;
		public OpenContinueMessageUserTaskFlowElement OpenContinueMessageUserTask {
			get {
				return _openContinueMessageUserTask ?? (_openContinueMessageUserTask = new OpenContinueMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("96a4d659-1d36-4e3d-940c-4340d5f5c1e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "NoContinueOpenSchema",
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow707;
		public ProcessConditionalFlow SequenceFlow707 {
			get {
				return _sequenceFlow707 ?? (_sequenceFlow707 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow707",
					SchemaElementUId = new Guid("25a3327b-378c-4337-b34a-f13fae6b431c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow722;
		public ProcessConditionalFlow ConditionalFlow722 {
			get {
				return _conditionalFlow722 ?? (_conditionalFlow722 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow722",
					SchemaElementUId = new Guid("83ed0e5c-29ef-484c-ab5c-f1433162c15c"),
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
					SchemaElementUId = new Guid("ee5327d5-c2f2-4dc9-81be-3a700e3e76b6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
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

		private LocalizableString _questionMessage;
		public LocalizableString QuestionMessage {
			get {
				return _questionMessage ?? (_questionMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.QuestionMessage.Value"));
			}
		}

		private LocalizableString _continueOpenFieldEditorMessage;
		public LocalizableString ContinueOpenFieldEditorMessage {
			get {
				return _continueOpenFieldEditorMessage ?? (_continueOpenFieldEditorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ContinueOpenFieldEditorMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseEventSubProcessPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEventSubProcessPageLoadComplete };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[ScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadComplete };
			FlowElements[BaseEventSubProcessOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEventSubProcessOkButtonClick };
			FlowElements[OKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClick };
			FlowElements[ScriptOKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOKButtonClick };
			FlowElements[BaseEventSubProcessCancellButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEventSubProcessCancellButtonClick };
			FlowElements[CancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClick };
			FlowElements[ScriptCancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptCancelButtonClick };
			FlowElements[BaseSubProcessDataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSubProcessDataSourceSaved };
			FlowElements[DataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceSaved };
			FlowElements[ScriptDataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceSaved };
			FlowElements[TreeGridLoadRowUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridLoadRowUserTask };
			FlowElements[ScriptTaskCloseWindowAfterSave.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskCloseWindowAfterSave };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[BasePageLoadSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePageLoadSubProcess };
			FlowElements[PageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoad };
			FlowElements[ScriptPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoad };
			FlowElements[BaseInitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseInitEventSubProcess };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScript };
			FlowElements[BaseEventSubProcessApplyButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEventSubProcessApplyButtonClick };
			FlowElements[BaseStartMessageApplyButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseStartMessageApplyButtonClick };
			FlowElements[ScriptApplyChangesButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptApplyChangesButtonClick };
			FlowElements[EventSubProcess223.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess223 };
			FlowElements[DesignerModeButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { DesignerModeButtonClick };
			FlowElements[ScriptDesignerModeButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDesignerModeButtonClick };
			FlowElements[OpenPageSchemaDesigner_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenPageSchemaDesigner_UserTask };
			FlowElements[OpenMessageScriptTask223.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenMessageScriptTask223 };
			FlowElements[OpenMessageUserTask223.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenMessageUserTask223 };
			FlowElements[IntermediateCatchMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEvent1 };
			FlowElements[GetIsEntitySchemaBlockedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GetIsEntitySchemaBlockedScriptTask };
			FlowElements[ExclusiveGateway223.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway223 };
			FlowElements[IntermediateCatchMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEvent2 };
			FlowElements[End223.SchemaElementUId] = new Collection<ProcessFlowElement> { End223 };
			FlowElements[IsSavedEntityExclusiveGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { IsSavedEntityExclusiveGateway };
			FlowElements[PrepareUserTaskParametersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareUserTaskParametersScriptTask };
			FlowElements[NoContinueExit.SchemaElementUId] = new Collection<ProcessFlowElement> { NoContinueExit };
			FlowElements[YesContinueIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { YesContinueIntermediateCatchMessageEvent };
			FlowElements[OpenContinueMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenContinueMessageUserTask };
			FlowElements[NotContinueIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { NotContinueIntermediateCatchMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseEventSubProcessPageLoadComplete":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadComplete");
						break;
					case "ScriptPageLoadComplete":
						break;
					case "BaseEventSubProcessOkButtonClick":
						break;
					case "OKButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptOKButtonClick");
						break;
					case "ScriptOKButtonClick":
						break;
					case "BaseEventSubProcessCancellButtonClick":
						break;
					case "CancelButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptCancelButtonClick");
						break;
					case "ScriptCancelButtonClick":
						break;
					case "BaseSubProcessDataSourceSaved":
						break;
					case "DataSourceSaved":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceSaved");
						break;
					case "ScriptDataSourceSaved":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "TreeGridLoadRowUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTaskCloseWindowAfterSave");
						break;
					case "ScriptTaskCloseWindowAfterSave":
						break;
					case "ExclusiveGateway1":
						if (SequenceFlow707ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("TreeGridLoadRowUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTaskCloseWindowAfterSave");
						break;
					case "BasePageLoadSubProcess":
						break;
					case "PageLoad":
						e.Context.QueueTasks.Enqueue("ScriptPageLoad");
						break;
					case "ScriptPageLoad":
						break;
					case "BaseInitEventSubProcess":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitScript");
						break;
					case "InitScript":
						break;
					case "BaseEventSubProcessApplyButtonClick":
						break;
					case "BaseStartMessageApplyButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptApplyChangesButtonClick");
						break;
					case "ScriptApplyChangesButtonClick":
						break;
					case "EventSubProcess223":
						break;
					case "DesignerModeButtonClick":
						e.Context.QueueTasks.Enqueue("GetIsEntitySchemaBlockedScriptTask");
						break;
					case "ScriptDesignerModeButtonClick":
						e.Context.QueueTasks.Enqueue("OpenPageSchemaDesigner_UserTask");
						break;
					case "OpenPageSchemaDesigner_UserTask":
						break;
					case "OpenMessageScriptTask223":
						e.Context.QueueTasks.Enqueue("OpenMessageUserTask223");
						break;
					case "OpenMessageUserTask223":
						ActivatedEventElements.Add("IntermediateCatchMessageEvent1");
						ActivatedEventElements.Add("IntermediateCatchMessageEvent2");
						break;
					case "IntermediateCatchMessageEvent1":
						e.Context.QueueTasks.Enqueue("IsSavedEntityExclusiveGateway");
						break;
					case "GetIsEntitySchemaBlockedScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway223");
						break;
					case "ExclusiveGateway223":
						if (ConditionalFlow722ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OpenMessageScriptTask223");
							break;
						}
						e.Context.QueueTasks.Enqueue("IsSavedEntityExclusiveGateway");
						break;
					case "IntermediateCatchMessageEvent2":
						e.Context.QueueTasks.Enqueue("End223");
						break;
					case "End223":
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
					case "NoContinueExit":
						break;
					case "YesContinueIntermediateCatchMessageEvent":
						e.Context.QueueTasks.Enqueue("ScriptDesignerModeButtonClick");
						break;
					case "OpenContinueMessageUserTask":
						ActivatedEventElements.Add("YesContinueIntermediateCatchMessageEvent");
						ActivatedEventElements.Add("NotContinueIntermediateCatchMessageEvent");
						break;
					case "NotContinueIntermediateCatchMessageEvent":
						e.Context.QueueTasks.Enqueue("NoContinueExit");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow707ExpressionExecute() {
			return Convert.ToBoolean(NeedRefreshGrid);
		}

		private bool ConditionalFlow722ExpressionExecute() {
			return Convert.ToBoolean(IsSchemaBlocked);
		}

		private bool YesEntitySavedConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(IsEntityChanged());
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("OKButtonClick");
			ActivatedEventElements.Add("CancelButtonClick");
			ActivatedEventElements.Add("DataSourceSaved");
			ActivatedEventElements.Add("PageLoad");
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("BaseStartMessageApplyButtonClick");
			ActivatedEventElements.Add("DesignerModeButtonClick");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseEventSubProcessPageLoadComplete":
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
				case "BaseEventSubProcessOkButtonClick":
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
				case "BaseEventSubProcessCancellButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClick";
					result = CancelButtonClick.Execute(context);
					break;
				case "ScriptCancelButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptCancelButtonClick";
					result = ScriptCancelButtonClick.Execute(context, ScriptCancelButtonClickExecute);
					break;
				case "BaseSubProcessDataSourceSaved":
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
				case "TreeGridLoadRowUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridLoadRowUserTask";
					result = TreeGridLoadRowUserTask.Execute(context);
					break;
				case "ScriptTaskCloseWindowAfterSave":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskCloseWindowAfterSave";
					result = ScriptTaskCloseWindowAfterSave.Execute(context, ScriptTaskCloseWindowAfterSaveExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "BasePageLoadSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoad";
					result = PageLoad.Execute(context);
					break;
				case "ScriptPageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoad";
					result = ScriptPageLoad.Execute(context, ScriptPageLoadExecute);
					break;
				case "BaseInitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
					break;
				case "InitScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScript";
					result = InitScript.Execute(context, InitScriptExecute);
					break;
				case "BaseEventSubProcessApplyButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "BaseStartMessageApplyButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseStartMessageApplyButtonClick";
					result = BaseStartMessageApplyButtonClick.Execute(context);
					break;
				case "ScriptApplyChangesButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptApplyChangesButtonClick";
					result = ScriptApplyChangesButtonClick.Execute(context, ScriptApplyChangesButtonClickExecute);
					break;
				case "EventSubProcess223":
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
				case "OpenMessageScriptTask223":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenMessageScriptTask223";
					result = OpenMessageScriptTask223.Execute(context, OpenMessageScriptTask223Execute);
					break;
				case "OpenMessageUserTask223":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenMessageUserTask223";
					result = OpenMessageUserTask223.Execute(context);
					break;
				case "IntermediateCatchMessageEvent1":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEvent1";
					result = IntermediateCatchMessageEvent1.Execute(context);
					break;
				case "GetIsEntitySchemaBlockedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GetIsEntitySchemaBlockedScriptTask";
					result = GetIsEntitySchemaBlockedScriptTask.Execute(context, GetIsEntitySchemaBlockedScriptTaskExecute);
					break;
				case "ExclusiveGateway223":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway223";
					result = ExclusiveGateway223.Execute(context);
					break;
				case "IntermediateCatchMessageEvent2":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEvent2";
					result = IntermediateCatchMessageEvent2.Execute(context);
					break;
				case "End223":
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
				case "NoContinueExit":
					context.QueueTasks.Dequeue();
					break;
				case "YesContinueIntermediateCatchMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "YesContinueIntermediateCatchMessageEvent";
					result = YesContinueIntermediateCatchMessageEvent.Execute(context);
					break;
				case "OpenContinueMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenContinueMessageUserTask";
					result = OpenContinueMessageUserTask.Execute(context);
					break;
				case "NotContinueIntermediateCatchMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "NotContinueIntermediateCatchMessageEvent";
					result = NotContinueIntermediateCatchMessageEvent.Execute(context);
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
				case "SysModuleEditId":
					SysModuleEditId = reader.GetValue<System.String>();
				break;
				case "PrimaryEntitySchemaUId":
					PrimaryEntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "NewPageEntityName":
					NewPageEntityName = reader.GetValue<System.String>();
				break;
				case "FolderUidBasePageEntity":
					FolderUidBasePageEntity = reader.GetValue<System.Guid>();
				break;
				case "IsBasePage":
					IsBasePage = reader.GetValue<System.Boolean>();
				break;
				case "IsBasePageSchema":
					IsBasePageSchema = reader.GetValue<System.Boolean>();
				break;
				case "BlockedSchemaMessageText":
					BlockedSchemaMessageText = reader.GetValue<System.String>();
				break;
				case "IsSchemaBlocked":
					IsSchemaBlocked = reader.GetValue<System.Boolean>();
				break;
				case "MenuVideoHelpItemCaption":
					MenuVideoHelpItemCaption = reader.GetValue<System.String>();
				break;
				case "MenuHelpItemCaption":
					MenuHelpItemCaption = reader.GetValue<System.String>();
				break;
				case "IsEdit":
					IsEdit = reader.GetValue<System.Boolean>();
				break;
				case "IsNotWindowClose":
					IsNotWindowClose = reader.GetValue<System.Boolean>();
				break;
				case "SuccesfullCloseMessage":
					SuccesfullCloseMessage = reader.GetValue<System.String>();
				break;
				case "PrimaryColumnValue":
					PrimaryColumnValue = reader.GetValue<System.Guid>();
				break;
				case "SynchronizeDataSourceStructure":
					SynchronizeDataSourceStructure = reader.GetValue<System.Boolean>();
				break;
				case "PrimaryDisplayColumnValue":
					PrimaryDisplayColumnValue = reader.GetValue<System.String>();
				break;
				case "NeedRefreshGrid":
					NeedRefreshGrid = reader.GetValue<System.Boolean>();
				break;
				case "IsCaptionExists":
					IsCaptionExists = reader.GetValue<System.Boolean>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "IsCopy":
					IsCopy = reader.GetValue<System.Boolean>();
				break;
				case "AdditionalScriptAfterSave":
					AdditionalScriptAfterSave = reader.GetValue<System.String>();
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

		public virtual bool ScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			Page.DataSource.EnableServerActiveRow = true;
			InitializeDesignerModeButton();
			SuccesfullCloseMessage = Page.GetParameterValue("closeMessage") == null ? string.Empty : Page.GetParameterValue("closeMessage").ToString();
			var dataSource = Page.DataSource;
			if (dataSource.Schema == null) {
				return true;
			}
			string queryString = Page.Request.QueryString.ToString();
			if (queryString.Contains("recordId")) {
				EntityPrimaryColumnValue = new Guid(Page.Request.QueryString["recordId"].ToString());
			}
			IsNew = EntityPrimaryColumnValue.Equals(Guid.Empty);
			IsCopy = (queryString.Contains("Copy") && (Page.Request.QueryString["Copy"].ToString() == "true"));
			IsEdit = !IsNew && !IsCopy;
			string primaryColumnName = dataSource.Schema.PrimaryColumn.Name;
			if (dataSource.CurrentStructure.Columns.Count == 0) {
				EntityDataSourceUtilities.InitializeAutoDefStructure(dataSource as EntityDataSource);
			}
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
					if (column.HasDefValue && 
						((column.IsLookupType || column.IsMultiLookupType) &&
						column.ReferenceSchema.PrimaryDisplayColumn != null) &&
						!columnNames.Contains(column.Name)) {
						columnNames.Add(column.Name);
					}
				}
				row.LoadLookupDisplayValues(columnNames);
				dataSource.Insert(row);
			} else {
				dataSource.CurrentStructure.Filters.Add(dataSource.CreateFilterWithParameters(FilterComparisonType.Equal,
					primaryColumnName, EntityPrimaryColumnValue));
				/*if (dataSource.Schema.HierarchyColumn != null) {
					Terrasoft.Core.Entities.EntitySchemaColumn hierarchyColumn = (dataSource.Schema.HierarchyColumn.Clone() as Terrasoft.Core.Entities.EntitySchemaColumn);
					dataSource.Schema.HierarchyColumn = null;		
					dataSource.LoadRows();
					dataSource.Schema.HierarchyColumn = hierarchyColumn as Terrasoft.Core.Entities.EntitySchemaColumn;
				} else {*/
				if (dataSource.CurrentStructure.IsHierarchical) {
					Terrasoft.Core.Entities.EntitySchemaColumn hierarchyColumn = (dataSource.Schema.HierarchyColumn.Clone() as Terrasoft.Core.Entities.EntitySchemaColumn);
					dataSource.CurrentStructure.IsHierarchical = false;		
					dataSource.LoadRows();
					dataSource.Schema.HierarchyColumn = hierarchyColumn as Terrasoft.Core.Entities.EntitySchemaColumn;
				} else {
					dataSource.LoadRows();
				}
				if (IsCopy) {
					row = dataSource.Rows[0].Clone() as Terrasoft.Core.Entities.Entity;
					Guid currentUserContactId = Page.UserConnection.CurrentUser.ContactId;
					EntityPrimaryColumnValue = Guid.NewGuid();
					row.SetColumnValue(primaryColumnName, EntityPrimaryColumnValue);
					row.SetColumnValue("CreatedOn", DateTime.Now);
					row.SetColumnValue("CreatedById", currentUserContactId);
					row.SetColumnValue("ModifiedOn", DateTime.Now);
					row.SetColumnValue("ModifiedById", currentUserContactId);
					var columnNames = new List<string>();		
					foreach (var column in row.Schema.Columns) {
						if (column.HasDefValue && 
							((column.IsLookupType || column.IsMultiLookupType) &&
							column.ReferenceSchema.PrimaryDisplayColumn != null) &&
							!columnNames.Contains(column.Name)) {
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
			Page.DataSource.AjaxEvents.Saved.SignalName = "DataSourceSaved";
			Page.DataSource.AjaxEvents.Saved.ExtraParameters.Add(
							new Terrasoft.UI.WebControls.Controls.Parameter("request", "request", Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			MakeCaption();
			ShowTip();
			InitializeContextHelpButton();
			return true;
		}

		public virtual bool ScriptOKButtonClickExecute(ProcessExecutingContext context) {
			if (Page.DataSource.Schema != null) {
				OkClickMethod();
			}
			return true;
		}

		public virtual bool ScriptCancelButtonClickExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool ScriptDataSourceSavedExecute(ProcessExecutingContext context) {
			if (Page.DataSource.ActiveRow != null) {
				PrimaryDisplayColumnValue =	Page.DataSource.ActiveRow.PrimaryDisplayColumnValue;
				PrimaryColumnValue = Page.DataSource.ActiveRow.PrimaryColumnValue;
			}
			NeedRefreshGrid = false;
			var treeGridId = Page.GetParameterValue("treeGridId") == null ? String.Empty :
											Page.GetParameterValue("treeGridId").ToString();
			string updateGridRowScript = String.Empty;
			if (treeGridId != String.Empty) {
				TreeGridLoadRowUserTask.Page = Page;
				TreeGridLoadRowUserTask.TreeGridClientID = treeGridId;
				TreeGridLoadRowUserTask.PrimaryColumnValue = EntityPrimaryColumnValue;
				NeedRefreshGrid = true;
				ModifyRefreshRowUserTaskParameters();
			}
			return true;
		}

		public virtual bool ScriptTaskCloseWindowAfterSaveExecute(ProcessExecutingContext context) {
			if (SuccesfullCloseMessage != null) {
				var closeMessage = SuccesfullCloseMessage.ToString();
				if (!string.IsNullOrEmpty(closeMessage)){
					Page.ThrowClientEvent(closeMessage, new List<object>());
				}
			}
			if (NeedRefreshGrid) {
				var script = (string.IsNullOrEmpty(AdditionalScriptAfterSave) ? string.Empty : AdditionalScriptAfterSave);
				Page.ScriptManager.AddScript(script);
			}
			if (!IsNotWindowClose) {
				(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			} else {
				IsNotWindowClose = false;
			}
			return true;
		}

		public virtual bool ScriptPageLoadExecute(ProcessExecutingContext context) {
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			Page.DataSource.BeforeSaveRow +=
				delegate(object sender, DataSourceEventArgs e) {
					if (AreConditionsCorrect(e.Row)) {
						BeforeSaveRowOnConditionsCorrect(e.Row);
					} else {
						e.Cancel = true;
					}
					
				};
			return true;
		}

		public virtual bool InitScriptExecute(ProcessExecutingContext context) {
			Page.DataSource.SaveError +=
				delegate(object sender, DataSourceEventArgs e) {
					ShowErrorMessage(e.Exception.Message);
					e.IsHandled = true;
				};
			
			return true;
		}

		public virtual bool ScriptApplyChangesButtonClickExecute(ProcessExecutingContext context) {
			if (Page.DataSource.Schema == null) {
				return true;
			}
			Page.AddScript(Page.DataSource.ClientID + 
			".save();");
			IsNotWindowClose = true;
			return true;
		}

		public virtual bool ScriptDesignerModeButtonClickExecute(ProcessExecutingContext context) {
			var pageSchemaUId = Page.Schema.UId.ToString();
			var managerName = "PageSchemaManager";
			var manager = UserConnection.GetSchemaManager(managerName);
			Dictionary<string, string> pageParameters = new Dictionary<string, string>() {
				{"id", pageSchemaUId},
				{"viewMode", "1"},
				{"isUserMode", "1"}
			};
			if (IsBasePage) {
				var managerNewItemUId = Guid.NewGuid();
				var managerNewItem = manager.CreateSchema(NewPageEntityName, null, UserConnection, managerNewItemUId, true);
				manager.SaveDesignedItemFolderIdInSessionData(UserConnection, managerNewItemUId, FolderUidBasePageEntity);
				managerNewItem.FolderId = FolderUidBasePageEntity;
				manager.SaveDesignedItemInSessionData(UserConnection, managerNewItem.Instance as MetaSchema, managerNewItem.UId);
				pageParameters.Add("parentPageSchemaUId", pageSchemaUId);
				pageSchemaUId = managerNewItem.UId.ToString();
				pageParameters["id"] = pageSchemaUId;
				var primaryEntitySchemaUId = Page.GetParameterValue("entitySchemaUId") as string;
				if (primaryEntitySchemaUId != null) {
					pageParameters.Add("entitySchemaUId", primaryEntitySchemaUId);
				}
				if (!string.IsNullOrEmpty(SysModuleEditId)) {
					pageParameters.Add("sysModuleEditId", SysModuleEditId);
				}
			}
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

		public virtual bool OpenMessageScriptTask223Execute(ProcessExecutingContext context) {
			OpenMessageUserTask223.Page = Page;
			OpenMessageUserTask223.MessageText = BlockedSchemaMessageText;
			OpenMessageUserTask223.Icon = "QUESTION";
			OpenMessageUserTask223.Buttons = "YESNO";
			OpenMessageUserTask223.ResponseMessages = new Dictionary<string, string> {{"yes", "YesOpenSchema"}, {"no", "NoOpenSchema"}};
			return true;
		}

		public virtual bool GetIsEntitySchemaBlockedScriptTaskExecute(ProcessExecutingContext context) {
			IsSchemaBlocked = false;
			var designedItemSchemaId = UserConnection
				.SessionData[string.Concat(Page.Schema.UId.ToString("N"), "DesignedItemPrimaryEntitySchemaId")];
			Guid entitySchemaId = designedItemSchemaId != null ? (Guid)designedItemSchemaId : Guid.Empty;	
			string primaryEntitySchemaUId = Page.GetParameterValue("entitySchemaUId") as string;
			IsBasePage = false;
			if (!string.IsNullOrEmpty(primaryEntitySchemaUId)) {
				Guid primaryEntitySchemaId = new Guid(primaryEntitySchemaUId);
				if (primaryEntitySchemaId != Guid.Empty && entitySchemaId != primaryEntitySchemaId) {
					entitySchemaId = primaryEntitySchemaId;
					string sysModuleEditId = (new Select(UserConnection)
							.Column("SysModuleEdit", "Id")
							.From("SysModuleEdit")
							.InnerJoin("SysModuleEntity").On("SysModuleEdit", "SysModuleEntityId").IsEqual("SysModuleEntity", "Id")
							.Where("SysModuleEdit", "SysPageSchemaUId").IsEqual(new QueryParameter(Page.Schema.UId))
							.And("SysModuleEntity", "SysEntitySchemaUId").IsEqual(new QueryParameter(entitySchemaId)) as Select)
							.ExecuteScalar<string>();
					if (!string.IsNullOrEmpty(sysModuleEditId)) {
						IsBasePage = true;
						SysModuleEditId = sysModuleEditId;
					}
				}
			}
			ISchemaManagerItem entityItem = null;
			if(entitySchemaId != Guid.Empty) {
				var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager");
				entityItem = entitySchemaManager.GetItemByUId(entitySchemaId) as ISchemaManagerItem;
				var entityDesignItem = entitySchemaManager.DesignItem(UserConnection, entityItem.UId);
				SysSchema schema = new SysSchema(UserConnection);
				schema.FetchFromDB(entityItem.Id);
				if (!schema.LockedById.IsEmpty() && schema.LockedById != UserConnection.CurrentUser.Id) {
					BlockedSchemaMessageText = string.Format(new LocalizableString("Terrasoft.WebApp.WorkspaceExplorerModule",
								"Message.SchemaIsLockedBeforeEditConfirm").Value, schema.LockedByName);
					IsSchemaBlocked = true;
				}
				bool savingWithoutLockingEnabled = (bool)SysSettings.GetValue(UserConnection, "AllowSaveUnlockedSchema");
				if (!savingWithoutLockingEnabled && schema.LockedById.IsEmpty()) {
					BlockedSchemaMessageText = new LocalizableString("Terrasoft.WebApp.WorkspaceExplorerModule",
								"Message.SchemaIsNotLockedByYouConfirm").Value;
					IsSchemaBlocked = true;
				}
			}
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager");
			var item = pageSchemaManager.FindItemByUId(Page.Schema.UId) as ISchemaManagerItem;
			var pageDesignItem = pageSchemaManager.DesignItem(UserConnection, item.UId);
			if (string.IsNullOrEmpty(BlockedSchemaMessageText)) {
				SysSchema schema = new SysSchema(UserConnection);
				//schema.FetchFromDB(pageDesignItem.Id);
				schema.FetchFromDB(item.Id);
				if (!schema.LockedById.IsEmpty() && schema.LockedById != UserConnection.CurrentUser.Id) {
					BlockedSchemaMessageText = string.Format(new LocalizableString("Terrasoft.WebApp.SolutionExplorerModule",
								"Message.SchemaIsLockedBeforeEditConfirm").Value, schema.LockedByName);
					IsSchemaBlocked = true;
				}
				bool savingWithoutLockingEnabled = (bool)SysSettings.GetValue(UserConnection, "AllowSaveUnlockedSchema");
				if (!savingWithoutLockingEnabled && schema.LockedById.IsEmpty()) {
					BlockedSchemaMessageText = new LocalizableString("Terrasoft.WebApp.SolutionExplorerModule",
								"Message.SchemaIsNotLockedByYouConfirm").Value;
					IsSchemaBlocked = true;
				}
			}
			if ((item.Name == "BaseLookupEditPage") || (item.Name == "BaseCodeLookupEditPage") || (item.Name == "BaseValueLookupEditPage")) {
				IsBasePage = true;
				SysModuleEditId = string.Empty;
			}
			if (IsBasePage) {
				FolderUidBasePageEntity = pageDesignItem.FolderId;
				var pageNamePrefix = entityItem != null ? entityItem.Name + "PageEntity" : "Page";
				NewPageEntityName = pageSchemaManager.GenerateItemUniqueName(pageNamePrefix);
			}
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

		public virtual bool AreConditionsCorrect(Entity row) {
			return true;
		}

		public virtual void MakeCaption() {
			if(IsCaptionExists) {
				return;
			}
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
					primaryDisplayColumnName = Page.DataSource.Rows[0].GetTypedColumnValue<string>(columnName);
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

		public virtual void OkClickMethod() {
			NeedRefreshGrid = true;
			if(IsCopy){
				Page.ScriptManager.AddScript(Page.DataSource.ClientID + ".save();");
			}
			else{
				Page.ScriptManager.AddScript(
					"if (" + Page.DataSource.ClientID + ".activeRow.modifiedValues) {" 
						+ Page.DataSource.ClientID + ".save(); " + 
					"} else { window.close(); }"
				);
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

		public virtual string GetHelpContextId() {
			return Page.GetParameterValue("helpContextId") as string;
		}

		public virtual void ShowErrorMessage(string errorMessage) {
			MessagePanel messagePanel = ControlUtilities.FindControl(
				Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
			if (messagePanel != null) {
				messagePanel.AddMessage(Warning, errorMessage, MessageType.Warning);
			}
		}

		public virtual void BeforeSaveRowOnConditionsCorrect(Entity row) {
		}

		public virtual Dictionary<string, object> GetDefValues() {
			var parentEntityIdObj = Page.GetParameterValue("ParentEntityId");
			var parentEntitySchemaIdObj = Page.GetParameterValue("ParentEntitySchemaId");
			var sysModuleDetailIdObj = Page.GetParameterValue("SysModuleDetailId");
			var useModuleDetailObj = Page.GetParameterValue("UseModuleDetail");
			var defValues = new Dictionary<string, object>();
			if (parentEntityIdObj != null && sysModuleDetailIdObj != null && useModuleDetailObj != null && parentEntitySchemaIdObj != null) {
				var parentEntitySchemaId = new Guid(parentEntitySchemaIdObj.ToString());
				var parentEntityId = new Guid(parentEntityIdObj.ToString());
				var sysModuleDetailId = new Guid(sysModuleDetailIdObj.ToString());
				var useModuleDetail = Convert.ToBoolean(useModuleDetailObj.ToString());
				var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as 
				Terrasoft.Core.Entities.EntitySchemaManager;
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
					foreach (var column in entityCollectionColumns) {
						var columnValueName = entitySchemaQuery.GetSchema().Columns.GetByName(column.Value).ColumnValueName;
						defValues.Add(column.Key, entityCollection[0].GetColumnValue(columnValueName));
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
				var values = UserConnection.SessionData[defValuesIdObj.ToString()] as Dictionary<string, object>;
				foreach (var item in values) {
					defValues[item.Key] = item.Value;
				}
			}
			return defValues;
		}

		public virtual void ModifyRefreshRowUserTaskParameters() {
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

		public virtual bool GetIsDesignerModeButtonHidden() {
			var securityEngine = UserConnection.DBSecurityEngine;
			bool canChangeApplicationTuningMode = !securityEngine.GetCanExecuteOperation("CanChangeApplicationTuningMode");
				var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager");
			var item = pageSchemaManager.FindItemByUId(Page.Schema.UId) as ISchemaManagerItem;
			if ((item.Name == "BaseLookupEditPage") || (item.Name == "BaseCodeLookupEditPage") || (item.Name == "BaseValueLookupEditPage")) {
				return canChangeApplicationTuningMode;
			}
			string primaryEntitySchemaUId = Page.GetParameterValue("entitySchemaUId") as string;
			Guid entitySchemaUId;
			if (string.IsNullOrEmpty(primaryEntitySchemaUId)) {
				var primaryDataSource = (DataSource)Page.Schema.FindPageControlByName(Page.Schema.PrimaryDataSourceName);
				if (primaryDataSource.Schema == null){
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
			var designedItemSchemaId = UserConnection
				.SessionData[string.Concat(Page.Schema.UId.ToString("N"), "DesignedItemPrimaryEntitySchemaId")];
			Guid entitySchemaId = designedItemSchemaId != null ? (Guid)designedItemSchemaId : Guid.Empty;
			bool isHiddenOpenDesignerButton = false;
			if (!string.IsNullOrEmpty(primaryEntitySchemaUId)) {
				Guid primaryEntitySchemaId = new Guid(primaryEntitySchemaUId);
				if (primaryEntitySchemaId != Guid.Empty && entitySchemaId != primaryEntitySchemaId) {
					entitySchemaId = primaryEntitySchemaId;
					string sysModuleEditId = (new Select(UserConnection)
							.Column("SysModuleEdit", "Id")
							.From("SysModuleEdit")
							.InnerJoin("SysModuleEntity").On("SysModuleEdit", "SysModuleEntityId").IsEqual("SysModuleEntity", "Id")
							.Where("SysModuleEdit", "SysPageSchemaUId").IsEqual(new QueryParameter(Page.Schema.UId))
							.And("SysModuleEntity", "SysEntitySchemaUId").IsEqual(new QueryParameter(entitySchemaId)) as Select)
							.ExecuteScalar<string>();
					if (string.IsNullOrEmpty(sysModuleEditId)) {
						isHiddenOpenDesignerButton = true;
					}
				}
			}
			return canChangeApplicationTuningMode || isHiddenOpenDesignerButton;
		}

		public virtual void InitializeDesignerModeButton() {
			var securityEngine = UserConnection.DBSecurityEngine;
			var isHidden = GetIsDesignerModeButtonHidden();
			Page.DesignerModeButton.Hidden = isHidden;
		}

		public virtual bool IsEntityChanged() {
			return Page.DataSource.ActiveRowModified;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
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
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClick")) {
							context.QueueTasks.Enqueue("CancelButtonClick");
						}
						break;
					case "DataSourceSaved":
							if (ActivatedEventElements.Contains("DataSourceSaved")) {
							context.QueueTasks.Enqueue("DataSourceSaved");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoad")) {
							context.QueueTasks.Enqueue("PageLoad");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
						}
						break;
					case "ApplyChangesButtonClick":
							if (ActivatedEventElements.Contains("BaseStartMessageApplyButtonClick")) {
							context.QueueTasks.Enqueue("BaseStartMessageApplyButtonClick");
						}
						break;
					case "DesignerModeButtonClick":
							if (ActivatedEventElements.Contains("DesignerModeButtonClick")) {
							context.QueueTasks.Enqueue("DesignerModeButtonClick");
						}
						break;
					case "YesOpenSchema":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEvent1")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEvent1");
					}
					break;
					case "NoOpenSchema":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEvent2")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEvent2");
					}
					break;
					case "YesContinueOpenSchema":
					if (ActivatedEventElements.Remove("YesContinueIntermediateCatchMessageEvent")) {
						context.QueueTasks.Enqueue("YesContinueIntermediateCatchMessageEvent");
					}
					break;
					case "NoContinueOpenSchema":
					if (ActivatedEventElements.Remove("NotContinueIntermediateCatchMessageEvent")) {
						context.QueueTasks.Enqueue("NotContinueIntermediateCatchMessageEvent");
					}
					break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SysModuleEditId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleEditId", SysModuleEditId, null);
			}
			if (!HasMapping("PrimaryEntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PrimaryEntitySchemaUId", PrimaryEntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("NewPageEntityName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewPageEntityName", NewPageEntityName, null);
			}
			if (!HasMapping("FolderUidBasePageEntity") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FolderUidBasePageEntity", FolderUidBasePageEntity, Guid.Empty);
			}
			if (!HasMapping("IsBasePage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsBasePage", IsBasePage, false);
			}
			if (!HasMapping("IsBasePageSchema") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsBasePageSchema", IsBasePageSchema, false);
			}
			if (!HasMapping("BlockedSchemaMessageText") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("BlockedSchemaMessageText", BlockedSchemaMessageText, null);
			}
			if (!HasMapping("IsSchemaBlocked") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSchemaBlocked", IsSchemaBlocked, false);
			}
			if (!HasMapping("MenuVideoHelpItemCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MenuVideoHelpItemCaption", MenuVideoHelpItemCaption, null);
			}
			if (!HasMapping("MenuHelpItemCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MenuHelpItemCaption", MenuHelpItemCaption, null);
			}
			if (!HasMapping("IsEdit") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEdit", IsEdit, false);
			}
			if (!HasMapping("IsNotWindowClose") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNotWindowClose", IsNotWindowClose, false);
			}
			if (!HasMapping("SuccesfullCloseMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SuccesfullCloseMessage", SuccesfullCloseMessage, null);
			}
			if (!HasMapping("PrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PrimaryColumnValue", PrimaryColumnValue, Guid.Empty);
			}
			if (!HasMapping("SynchronizeDataSourceStructure") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SynchronizeDataSourceStructure", SynchronizeDataSourceStructure, false);
			}
			if (!HasMapping("PrimaryDisplayColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PrimaryDisplayColumnValue", PrimaryDisplayColumnValue, null);
			}
			if (!HasMapping("NeedRefreshGrid") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedRefreshGrid", NeedRefreshGrid, false);
			}
			if (!HasMapping("IsCaptionExists") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCaptionExists", IsCaptionExists, false);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("IsCopy") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCopy", IsCopy, false);
			}
			if (!HasMapping("AdditionalScriptAfterSave") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AdditionalScriptAfterSave", AdditionalScriptAfterSave, null);
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

	#region Class: BaseEditPageEventsProcess

	/// <exclude/>
	public class BaseEditPageEventsProcess : BaseEditPageEventsProcess<Terrasoft.WebApp.BaseEditPageSchemaUserControl>
	{

		public BaseEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout CustomControls {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CustomControls", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DesignerModeButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DesignerModeButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer SpacerButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("SpacerButton", true);
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

		public Terrasoft.UI.WebControls.Controls.Button ApplyChangesButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ApplyChangesButton", true);
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
			DesignerModeButton.AjaxEvents.Click.Event += DesignerModeButtonClick;
			OKButton.AjaxEvents.Click.Event += OKButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
			ApplyChangesButton.AjaxEvents.Click.Event += ApplyChangesButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DesignerModeButton.AjaxEvents.Click.Event -= DesignerModeButtonClick;
			OKButton.AjaxEvents.Click.Event -= OKButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
			ApplyChangesButton.AjaxEvents.Click.Event -= ApplyChangesButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseEditPageEventsProcess(UserConnection);
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

		public virtual void DesignerModeButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DesignerModeButtonClick");
		}

		public virtual void OKButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OKButtonClick");
		}

		public virtual void CancelButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CancelButtonClick");
		}

		public virtual void ApplyChangesButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ApplyChangesButtonClick");
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
			SchemaName = "BaseEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseEditPageEventsProcessSchema(BaseEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseEditPageEventsProcess";
			UId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dc0b4bfd-1bbe-4348-a089-240903d4ffb2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("80381644-c4ac-4e05-a6c7-02125b129e47"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"EntitySchemaManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("996ae05f-3d6c-4eff-9fe4-b5b614bc94d6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"EntityPrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAdditionalScriptAfterSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f836914-9ec2-4dc9-86a9-d3c020e0503a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"AdditionalScriptAfterSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCopyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dd3ef1eb-b59d-4cb2-8525-71fcd8e89a53"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsCopy",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e263d091-0336-4b2a-addb-cf7e9f790b25"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCaptionExistsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("89ae5cc1-51e2-4d63-9bb0-861147a01f39"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsCaptionExists",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedRefreshGridParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3949edac-b9bb-431c-b4ef-061495f6c078"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"NeedRefreshGrid",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrimaryDisplayColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2ac9ad85-cf22-47d3-8709-182e1cc9dcfd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"PrimaryDisplayColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSynchronizeDataSourceStructureParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3a50585b-a6cd-453c-afe5-ec023e8cf973"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"SynchronizeDataSourceStructure",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2afe4ca8-5089-4939-911b-0ea42d03d122"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"PrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccesfullCloseMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ddc06cd3-dd17-4f30-a93a-a0778ed58bc8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"SuccesfullCloseMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNotWindowCloseParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("40f3d259-1fb1-4cbc-b848-dda589653c7d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsNotWindowClose",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEditParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("12d41b1d-1624-404d-be0b-2b021fdba8df"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsEdit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMenuHelpItemCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("99f92fc5-542d-4e2f-af8e-6d11d8554efb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"MenuHelpItemCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMenuVideoHelpItemCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b98cbd6d-ed14-4af8-9fe8-8c2da705efcc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"MenuVideoHelpItemCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSchemaBlockedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e94b7441-fe92-4ee4-8d4f-87b19243ba8f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsSchemaBlocked",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBlockedSchemaMessageTextParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f87091e2-7c22-4314-a41e-3b67233d55a1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"BlockedSchemaMessageText",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsBasePageSchemaParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("90d70a5e-6760-4c16-aee5-72ae0d658bcf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsBasePageSchema",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsBasePageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a6ae48c2-3893-4327-b7ae-32a2ebe53f95"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsBasePage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFolderUidBasePageEntityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba3f4652-ef88-479e-b84a-48d63b1d2182"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"FolderUidBasePageEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewPageEntityNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("65fd0e69-e90c-4da1-b874-48aec7b7bf1f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"NewPageEntityName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrimaryEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("991a5f57-ead8-475e-a652-57483dd1e1e9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"PrimaryEntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleEditIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0bc11efd-d0b7-45d8-a5a0-4ab5c0b730ba"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"SysModuleEditId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateEntitySchemaManagerNameParameter());
			Parameters.Add(CreateEntityPrimaryColumnValueParameter());
			Parameters.Add(CreateAdditionalScriptAfterSaveParameter());
			Parameters.Add(CreateIsCopyParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateIsCaptionExistsParameter());
			Parameters.Add(CreateNeedRefreshGridParameter());
			Parameters.Add(CreatePrimaryDisplayColumnValueParameter());
			Parameters.Add(CreateSynchronizeDataSourceStructureParameter());
			Parameters.Add(CreatePrimaryColumnValueParameter());
			Parameters.Add(CreateSuccesfullCloseMessageParameter());
			Parameters.Add(CreateIsNotWindowCloseParameter());
			Parameters.Add(CreateIsEditParameter());
			Parameters.Add(CreateMenuHelpItemCaptionParameter());
			Parameters.Add(CreateMenuVideoHelpItemCaptionParameter());
			Parameters.Add(CreateIsSchemaBlockedParameter());
			Parameters.Add(CreateBlockedSchemaMessageTextParameter());
			Parameters.Add(CreateIsBasePageSchemaParameter());
			Parameters.Add(CreateIsBasePageParameter());
			Parameters.Add(CreateFolderUidBasePageEntityParameter());
			Parameters.Add(CreateNewPageEntityNameParameter());
			Parameters.Add(CreatePrimaryEntitySchemaUIdParameter());
			Parameters.Add(CreateSysModuleEditIdParameter());
		}

		protected virtual void InitializeTreeGridLoadRowUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("6ca261b7-d134-4268-abfa-cbf59da5b0da"),
				ContainerUId = new Guid("ab5c5dfb-c112-4422-b486-2684ad2f53a2"),
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
				UId = new Guid("74e37251-a212-47e4-9cda-2f1004b70711"),
				ContainerUId = new Guid("ab5c5dfb-c112-4422-b486-2684ad2f53a2"),
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
				UId = new Guid("e6792640-8931-401e-a390-a91775ae2e59"),
				ContainerUId = new Guid("ab5c5dfb-c112-4422-b486-2684ad2f53a2"),
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
				UId = new Guid("e1dc20cf-7351-47ce-810b-004559a0bfa6"),
				ContainerUId = new Guid("ab5c5dfb-c112-4422-b486-2684ad2f53a2"),
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

		protected virtual void InitializeOpenPageSchemaDesigner_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("0a294594-2398-4d1d-a0a8-8f87cef484a1"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f49e1833-6361-4e62-98c4-b014db71eba5"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("866cd75c-ffe8-4766-9ff9-245275c6772e"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4b68c365-34bc-42db-8d63-33771fd8c54d"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6d8eab86-52ba-4908-8d14-50b54c6b26fa"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("84d472fc-f0a5-4e37-a4f0-7e1d51f19dee"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5a0707f9-4d40-4541-8f3c-f0754fb26bde"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("faac4aae-a957-4c47-bf59-cba827d3099e"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("58501177-f9a5-423f-9830-409f1f81b871"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("78670f3b-2e9d-4934-8b6a-29f9cadb20f5"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5a3c3f65-17a0-4b72-91f1-8c3bc0ec5680"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6a2aee67-12f6-4718-b868-1cba7364461b"),
				ContainerUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeOpenMessageUserTask223Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("657676ab-d18b-44a2-8648-5639a67a0f04"),
				ContainerUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
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
				UId = new Guid("9a74a79e-90be-49ea-8d7a-48094f6c86ba"),
				ContainerUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
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
				UId = new Guid("2cca0cd8-533b-4cc3-bd48-8313b8b07ea0"),
				ContainerUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
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
				UId = new Guid("ade9a5a4-0951-436d-8541-7f72a00df773"),
				ContainerUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
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
				UId = new Guid("6395ebbb-ee0a-4c29-8556-3677a9115f46"),
				ContainerUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
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
				UId = new Guid("ea57cdeb-985b-413b-95d9-6a97deabeb8e"),
				ContainerUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
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
				UId = new Guid("a6048f17-a5e8-4cf7-b8b6-427eb8a43fae"),
				ContainerUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
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
				UId = new Guid("f0cf6a05-838c-4a36-b8a9-a96e5a594a06"),
				ContainerUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
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
				UId = new Guid("ce5cfe91-8d02-4431-b362-f1f1a5fc2981"),
				ContainerUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
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
				UId = new Guid("2a455c66-2bcb-438f-a065-bb401258c942"),
				ContainerUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
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
				UId = new Guid("5330224a-d2c2-4925-afeb-709345a5a149"),
				ContainerUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
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
				UId = new Guid("4667a986-a1e8-4ff9-b79d-ff9a941faf1d"),
				ContainerUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
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
				UId = new Guid("7ad2d1dd-80b8-46b9-8755-143414929a55"),
				ContainerUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
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
				UId = new Guid("d6b9fff3-d116-4a00-a656-b1c0291bc2d5"),
				ContainerUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
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
				UId = new Guid("6b25499f-cfb7-4886-bf7e-c692ec1ab7bd"),
				ContainerUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
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
				UId = new Guid("e3d4e6c1-fba1-486b-b369-c53486bb8f25"),
				ContainerUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
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
			ProcessSchemaLaneSet schemaLaneSet91 = CreateLaneSet91LaneSet();
			LaneSets.Add(schemaLaneSet91);
			ProcessSchemaLane schemaLane218 = CreateLane218Lane();
			schemaLaneSet91.Lanes.Add(schemaLane218);
			ProcessSchemaLane schemaLane219 = CreateLane219Lane();
			schemaLaneSet91.Lanes.Add(schemaLane219);
			ProcessSchemaLane schemaLane220 = CreateLane220Lane();
			schemaLaneSet91.Lanes.Add(schemaLane220);
			ProcessSchemaLane schemaLane223 = CreateLane223Lane();
			schemaLaneSet91.Lanes.Add(schemaLane223);
			ProcessSchemaEventSubProcess baseeventsubprocesspageloadcomplete = CreateBaseEventSubProcessPageLoadCompleteEventSubProcess();
			FlowElements.Add(baseeventsubprocesspageloadcomplete);
			ProcessSchemaEventSubProcess baseeventsubprocessokbuttonclick = CreateBaseEventSubProcessOkButtonClickEventSubProcess();
			FlowElements.Add(baseeventsubprocessokbuttonclick);
			ProcessSchemaEventSubProcess baseeventsubprocesscancellbuttonclick = CreateBaseEventSubProcessCancellButtonClickEventSubProcess();
			FlowElements.Add(baseeventsubprocesscancellbuttonclick);
			ProcessSchemaEventSubProcess basesubprocessdatasourcesaved = CreateBaseSubProcessDataSourceSavedEventSubProcess();
			FlowElements.Add(basesubprocessdatasourcesaved);
			ProcessSchemaEventSubProcess basepageloadsubprocess = CreateBasePageLoadSubProcessEventSubProcess();
			FlowElements.Add(basepageloadsubprocess);
			ProcessSchemaEventSubProcess baseiniteventsubprocess = CreateBaseInitEventSubProcessEventSubProcess();
			FlowElements.Add(baseiniteventsubprocess);
			ProcessSchemaEventSubProcess baseeventsubprocessapplybuttonclick = CreateBaseEventSubProcessApplyButtonClickEventSubProcess();
			FlowElements.Add(baseeventsubprocessapplybuttonclick);
			ProcessSchemaEventSubProcess eventsubprocess223 = CreateEventSubProcess223EventSubProcess();
			FlowElements.Add(eventsubprocess223);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			baseeventsubprocesspageloadcomplete.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask scriptpageloadcomplete = CreateScriptPageLoadCompleteScriptTask();
			baseeventsubprocesspageloadcomplete.FlowElements.Add(scriptpageloadcomplete);
			ProcessSchemaStartMessageEvent okbuttonclick = CreateOKButtonClickStartMessageEvent();
			baseeventsubprocessokbuttonclick.FlowElements.Add(okbuttonclick);
			ProcessSchemaScriptTask scriptokbuttonclick = CreateScriptOKButtonClickScriptTask();
			baseeventsubprocessokbuttonclick.FlowElements.Add(scriptokbuttonclick);
			ProcessSchemaStartMessageEvent cancelbuttonclick = CreateCancelButtonClickStartMessageEvent();
			baseeventsubprocesscancellbuttonclick.FlowElements.Add(cancelbuttonclick);
			ProcessSchemaScriptTask scriptcancelbuttonclick = CreateScriptCancelButtonClickScriptTask();
			baseeventsubprocesscancellbuttonclick.FlowElements.Add(scriptcancelbuttonclick);
			ProcessSchemaStartMessageEvent datasourcesaved = CreateDataSourceSavedStartMessageEvent();
			basesubprocessdatasourcesaved.FlowElements.Add(datasourcesaved);
			ProcessSchemaScriptTask scriptdatasourcesaved = CreateScriptDataSourceSavedScriptTask();
			basesubprocessdatasourcesaved.FlowElements.Add(scriptdatasourcesaved);
			ProcessSchemaUserTask treegridloadrowusertask = CreateTreeGridLoadRowUserTaskUserTask();
			basesubprocessdatasourcesaved.FlowElements.Add(treegridloadrowusertask);
			ProcessSchemaScriptTask scripttaskclosewindowaftersave = CreateScriptTaskCloseWindowAfterSaveScriptTask();
			basesubprocessdatasourcesaved.FlowElements.Add(scripttaskclosewindowaftersave);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			basesubprocessdatasourcesaved.FlowElements.Add(exclusivegateway1);
			ProcessSchemaStartMessageEvent pageload = CreatePageLoadStartMessageEvent();
			basepageloadsubprocess.FlowElements.Add(pageload);
			ProcessSchemaScriptTask scriptpageload = CreateScriptPageLoadScriptTask();
			basepageloadsubprocess.FlowElements.Add(scriptpageload);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			baseiniteventsubprocess.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask initscript = CreateInitScriptScriptTask();
			baseiniteventsubprocess.FlowElements.Add(initscript);
			ProcessSchemaStartMessageEvent basestartmessageapplybuttonclick = CreateBaseStartMessageApplyButtonClickStartMessageEvent();
			baseeventsubprocessapplybuttonclick.FlowElements.Add(basestartmessageapplybuttonclick);
			ProcessSchemaScriptTask scriptapplychangesbuttonclick = CreateScriptApplyChangesButtonClickScriptTask();
			baseeventsubprocessapplybuttonclick.FlowElements.Add(scriptapplychangesbuttonclick);
			ProcessSchemaStartMessageEvent designermodebuttonclick = CreateDesignerModeButtonClickStartMessageEvent();
			eventsubprocess223.FlowElements.Add(designermodebuttonclick);
			ProcessSchemaScriptTask scriptdesignermodebuttonclick = CreateScriptDesignerModeButtonClickScriptTask();
			eventsubprocess223.FlowElements.Add(scriptdesignermodebuttonclick);
			ProcessSchemaUserTask openpageschemadesigner_usertask = CreateOpenPageSchemaDesigner_UserTaskUserTask();
			eventsubprocess223.FlowElements.Add(openpageschemadesigner_usertask);
			ProcessSchemaScriptTask openmessagescripttask223 = CreateOpenMessageScriptTask223ScriptTask();
			eventsubprocess223.FlowElements.Add(openmessagescripttask223);
			ProcessSchemaUserTask openmessageusertask223 = CreateOpenMessageUserTask223UserTask();
			eventsubprocess223.FlowElements.Add(openmessageusertask223);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageevent1 = CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent();
			eventsubprocess223.FlowElements.Add(intermediatecatchmessageevent1);
			ProcessSchemaScriptTask getisentityschemablockedscripttask = CreateGetIsEntitySchemaBlockedScriptTaskScriptTask();
			eventsubprocess223.FlowElements.Add(getisentityschemablockedscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway223 = CreateExclusiveGateway223ExclusiveGateway();
			eventsubprocess223.FlowElements.Add(exclusivegateway223);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageevent2 = CreateIntermediateCatchMessageEvent2IntermediateCatchMessageEvent();
			eventsubprocess223.FlowElements.Add(intermediatecatchmessageevent2);
			ProcessSchemaEndEvent end223 = CreateEnd223EndEvent();
			eventsubprocess223.FlowElements.Add(end223);
			ProcessSchemaExclusiveGateway issavedentityexclusivegateway = CreateIsSavedEntityExclusiveGatewayExclusiveGateway();
			eventsubprocess223.FlowElements.Add(issavedentityexclusivegateway);
			ProcessSchemaScriptTask prepareusertaskparametersscripttask = CreatePrepareUserTaskParametersScriptTaskScriptTask();
			eventsubprocess223.FlowElements.Add(prepareusertaskparametersscripttask);
			ProcessSchemaEndEvent nocontinueexit = CreateNoContinueExitEndEvent();
			eventsubprocess223.FlowElements.Add(nocontinueexit);
			ProcessSchemaIntermediateCatchMessageEvent yescontinueintermediatecatchmessageevent = CreateYesContinueIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			eventsubprocess223.FlowElements.Add(yescontinueintermediatecatchmessageevent);
			ProcessSchemaUserTask opencontinuemessageusertask = CreateOpenContinueMessageUserTaskUserTask();
			eventsubprocess223.FlowElements.Add(opencontinuemessageusertask);
			ProcessSchemaIntermediateCatchMessageEvent notcontinueintermediatecatchmessageevent = CreateNotContinueIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			eventsubprocess223.FlowElements.Add(notcontinueintermediatecatchmessageevent);
			FlowElements.Add(CreateSequenceFlow696SequenceFlow());
			FlowElements.Add(CreateSequenceFlow697SequenceFlow());
			FlowElements.Add(CreateSequenceFlow699SequenceFlow());
			FlowElements.Add(CreateSequenceFlow700SequenceFlow());
			FlowElements.Add(CreateSequenceFlow703SequenceFlow());
			FlowElements.Add(CreateSequenceFlow704SequenceFlow());
			FlowElements.Add(CreateSequenceFlow707ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow708SequenceFlow());
			FlowElements.Add(CreateSequenceFlow709SequenceFlow());
			FlowElements.Add(CreateSequenceFlow710SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1678568678SequenceFlow());
			FlowElements.Add(CreateSequenceFlow713SequenceFlow());
			FlowElements.Add(CreateSequenceFlow714SequenceFlow());
			FlowElements.Add(CreateSequenceFlow715SequenceFlow());
			FlowElements.Add(CreateSequenceFlow716SequenceFlow());
			FlowElements.Add(CreateSequenceFlow717SequenceFlow());
			FlowElements.Add(CreateSequenceFlow718SequenceFlow());
			FlowElements.Add(CreateConditionalFlow722ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow719SequenceFlow());
			FlowElements.Add(CreateSequenceFlow720SequenceFlow());
			FlowElements.Add(CreateSequenceFlow721SequenceFlow());
			FlowElements.Add(CreateYesEntitySavedConditionalFlowConditionalFlow());
			FlowElements.Add(CreateNotSavedEntitySequenceFlowSequenceFlow());
			FlowElements.Add(CreateShowContinueMessageSequenceFlowSequenceFlow());
			FlowElements.Add(CreateYesContinueSequenceFlowSequenceFlow());
			FlowElements.Add(CreatePrepareDesignerWindowSequenceFlowSequenceFlow());
			FlowElements.Add(CreateNoContinueSequenceFlowSequenceFlow());
			FlowElements.Add(CreateNoContinueExitSequenceFlowSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNewRecordCaptionLocalizableString());
			LocalizableStrings.Add(CreateEditingRecordCaptionLocalizableString());
			LocalizableStrings.Add(CreateWarningLocalizableString());
			LocalizableStrings.Add(CreateTipLocalizableString());
			LocalizableStrings.Add(CreateQuestionMessageLocalizableString());
			LocalizableStrings.Add(CreateContinueOpenFieldEditorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNewRecordCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("515bf056-2530-49f8-a585-8e5df0e788fd"),
				Name = "NewRecordCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEditingRecordCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bb5aafcd-b4f5-41f4-8ceb-18f976d47ebf"),
				Name = "EditingRecordCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e825cac0-594f-482a-9076-fa19c6df9904"),
				Name = "Warning",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTipLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fbce18c3-bad1-497c-b605-00288d267b8a"),
				Name = "Tip",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateQuestionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5c600109-bc39-4bf4-988e-e02c998fd764"),
				Name = "QuestionMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContinueOpenFieldEditorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("13439232-213d-4782-b1e5-21b6f7d64c17"),
				Name = "ContinueOpenFieldEditorMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow696SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow696",
				UId = new Guid("c05adbda-1b6d-4da8-973a-8e76744d6c62"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(264, 140),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("344c1d94-f539-433b-b90c-5ab36b6a92c0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0a4ac78f-bbcb-44a0-af53-1d3156bc75e2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow697SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow697",
				UId = new Guid("8cef25da-16dc-49cd-aae3-68bee9fe1278"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(137, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("570f7190-4f9a-4c59-b921-3fb6604ef35e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("168424fd-2e64-4fba-b50f-616df20a706e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow699SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow699",
				UId = new Guid("ce1fe7cf-8e4a-4a9c-adf3-35495fa181ba"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f51c8f5-1120-4541-a07e-1d312115dadd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("65bff8e7-adb5-46db-8a49-917b6122d7d4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow700SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow700",
				UId = new Guid("5a6915a9-f882-4729-a209-504eb5199706"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(140, 479),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("419111f5-d617-4a4d-8234-27b88c987edc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("be2635dd-cae2-4bbd-9745-3706adc609f1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow703SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow703",
				UId = new Guid("27e5589a-c804-4063-a6b6-954389e8f844"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(384, 71),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab5c5dfb-c112-4422-b486-2684ad2f53a2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4aad0d51-bce3-45cf-b6ab-54fe9375df97"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow704SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow704",
				UId = new Guid("2802fcb6-72bc-4e9c-abf6-7f051d236eb2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(337, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6ad2c194-854a-494f-97ff-30a9d838fc08"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4aad0d51-bce3-45cf-b6ab-54fe9375df97"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow707ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow707",
				UId = new Guid("25a3327b-378c-4337-b34a-f13fae6b431c"),
				ConditionExpression = @"NeedRefreshGrid",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(385, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6ad2c194-854a-494f-97ff-30a9d838fc08"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab5c5dfb-c112-4422-b486-2684ad2f53a2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow708SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow708",
				UId = new Guid("26103495-56b0-41ce-9fcf-1a2c9245e591"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(268, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("65bff8e7-adb5-46db-8a49-917b6122d7d4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6ad2c194-854a-494f-97ff-30a9d838fc08"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow709SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow709",
				UId = new Guid("fce163a4-1d14-4a7e-ba46-f77282bbaf4c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(396, 505),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("033b480f-7a8c-4526-96d4-5df991e5be54"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a7dc6bf1-c6ce-40ae-b1ae-743b61b3e729"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow710SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow710",
				UId = new Guid("b57eede2-082f-4601-b4a3-0f4c2a1366de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c23df4eb-d85f-4c26-9840-d093e961ce0a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd6630e9-5cd5-4bd1-b475-34b85b3bd2d0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1678568678SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1678568678",
				UId = new Guid("04bed546-70b3-48c4-a55e-b15f8e974997"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(409, 446),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("842905ff-4c9d-4400-9347-65424e516a94"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d2d0e38e-1a3d-4300-b706-cb579699f2e6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow713SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow713",
				UId = new Guid("4ae3e834-ad2b-49f6-bbdd-080517fd92b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("808ce38e-dc30-48fa-9180-f1adcbbd9205"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("572a0d59-bce6-46da-a4f9-890c1470503a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow714SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow714",
				UId = new Guid("cd936dd7-69a2-4d69-b239-19c35ea678bf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(247, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3b5ecbe1-d09e-440a-814d-29bcf66be0de"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow715SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow715",
				UId = new Guid("1594458b-0e11-4987-ad40-8e032dfcf608"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8d5a54c5-07a3-447b-8b11-e60635d2adb3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow716SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow716",
				UId = new Guid("0e4d39b1-e814-4e5d-b984-508654437e29"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a12f5a49-9486-4fa6-bf02-b8070daa132b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow717SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow717",
				UId = new Guid("abeb3a8e-f69b-4513-bda3-af6949eca941"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a12f5a49-9486-4fa6-bf02-b8070daa132b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("02b2852c-3a27-4838-8c05-7fa20d83096b"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow718SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow718",
				UId = new Guid("e7dd8c68-8a9d-44b0-b3e5-741bbd7c0c06"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("572a0d59-bce6-46da-a4f9-890c1470503a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("492b99e9-cfae-49c0-83b2-9171440c55ec"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow722ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow722",
				UId = new Guid("83ed0e5c-29ef-484c-ab5c-f1433162c15c"),
				ConditionExpression = @"IsSchemaBlocked",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(351, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("492b99e9-cfae-49c0-83b2-9171440c55ec"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8d5a54c5-07a3-447b-8b11-e60635d2adb3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow719SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow719",
				UId = new Guid("116dc5dd-c76b-408c-9071-bbbf1b8a5cb7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(494, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("492b99e9-cfae-49c0-83b2-9171440c55ec"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("02b2852c-3a27-4838-8c05-7fa20d83096b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow720SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow720",
				UId = new Guid("4b5afb86-d417-4b54-a255-ef84f198d336"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(586, 59),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("98f8095a-b08c-4ed5-92f6-bc5aab9e4cfe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow721SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow721",
				UId = new Guid("2a1f7a3e-b2cd-4a05-8907-b2e90ba662f2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(644, 44),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("98f8095a-b08c-4ed5-92f6-bc5aab9e4cfe"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2b34f89b-c43d-4f59-94f5-52657163193c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateYesEntitySavedConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "YesEntitySavedConditionalFlow",
				UId = new Guid("ee5327d5-c2f2-4dc9-81be-3a700e3e76b6"),
				ConditionExpression = @"IsEntityChanged()",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(302, 212),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("02b2852c-3a27-4838-8c05-7fa20d83096b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1433783e-76c3-4190-974e-edc838111e6a"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateNotSavedEntitySequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "NotSavedEntitySequenceFlow",
				UId = new Guid("8996bc6c-ef11-4a33-9d82-0ef2895e2165"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(400, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("02b2852c-3a27-4838-8c05-7fa20d83096b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b5ecbe1-d09e-440a-814d-29bcf66be0de"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateShowContinueMessageSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ShowContinueMessageSequenceFlow",
				UId = new Guid("06e32589-4c60-4af4-9d7b-f206d64df14b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(206, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1433783e-76c3-4190-974e-edc838111e6a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateYesContinueSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "YesContinueSequenceFlow",
				UId = new Guid("410ab06d-1cf3-4f2e-b697-e4a67efff968"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(266, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("90e17638-f884-444a-a4bb-621fa6ac4816"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreatePrepareDesignerWindowSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "PrepareDesignerWindowSequenceFlow",
				UId = new Guid("6d36f72c-ebbc-414e-94d1-d9a82f8133de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(348, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("90e17638-f884-444a-a4bb-621fa6ac4816"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b5ecbe1-d09e-440a-814d-29bcf66be0de"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateNoContinueSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "NoContinueSequenceFlow",
				UId = new Guid("69e74a1b-84f7-45e4-b1de-46abdef19ed6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(139, 310),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("96a4d659-1d36-4e3d-940c-4340d5f5c1e1"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateNoContinueExitSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "NoContinueExitSequenceFlow",
				UId = new Guid("0dd0d92e-952a-4afe-831d-a00bca558494"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CurveCenterPosition = new Point(98, 260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96a4d659-1d36-4e3d-940c-4340d5f5c1e1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f861f45a-00e0-4dd7-aef4-51d7bc6b09bf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet91LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet91 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("15055af4-596a-40f3-8e23-a7a35cb61529"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"LaneSet91",
				Position = new Point(5, 5),
				Size = new Size(1153, 1272),
				UseBackgroundMode = false
			};
			return schemaLaneSet91;
		}

		protected virtual ProcessSchemaLane CreateLane218Lane() {
			ProcessSchemaLane schemaLane218 = new ProcessSchemaLane(this) {
				UId = new Guid("178efa30-baa5-4f35-beef-06a3cdd84285"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("15055af4-596a-40f3-8e23-a7a35cb61529"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"Lane218",
				Position = new Point(29, 838),
				Size = new Size(1124, 434),
				UseBackgroundMode = false
			};
			return schemaLane218;
		}

		protected virtual ProcessSchemaLane CreateLane219Lane() {
			ProcessSchemaLane schemaLane219 = new ProcessSchemaLane(this) {
				UId = new Guid("0d9edfd7-f665-4c93-8338-e0a0189f118e"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("15055af4-596a-40f3-8e23-a7a35cb61529"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"Lane219",
				Position = new Point(29, 682),
				Size = new Size(1124, 151),
				UseBackgroundMode = false
			};
			return schemaLane219;
		}

		protected virtual ProcessSchemaLane CreateLane220Lane() {
			ProcessSchemaLane schemaLane220 = new ProcessSchemaLane(this) {
				UId = new Guid("2fbace11-27e0-41c0-a594-f0fa505042bf"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("15055af4-596a-40f3-8e23-a7a35cb61529"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"Lane220",
				Position = new Point(29, 518),
				Size = new Size(1124, 159),
				UseBackgroundMode = false
			};
			return schemaLane220;
		}

		protected virtual ProcessSchemaLane CreateLane223Lane() {
			ProcessSchemaLane schemaLane223 = new ProcessSchemaLane(this) {
				UId = new Guid("b5b80b7f-3f68-452b-95a4-59ab5baba0fd"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("15055af4-596a-40f3-8e23-a7a35cb61529"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"Lane223",
				Position = new Point(29, 0),
				Size = new Size(1124, 513),
				UseBackgroundMode = false
			};
			return schemaLane223;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEventSubProcessPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEventSubProcessPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ec1b166c-6c70-45fc-ad5d-2476308c3e37"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("178efa30-baa5-4f35-beef-06a3cdd84285"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"BaseEventSubProcessPageLoadComplete",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(207, 125),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEventSubProcessPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("344c1d94-f539-433b-b90c-5ab36b6a92c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec1b166c-6c70-45fc-ad5d-2476308c3e37"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"PageLoadComplete",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0a4ac78f-bbcb-44a0-af53-1d3156bc75e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ec1b166c-6c70-45fc-ad5d-2476308c3e37"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ScriptPageLoadComplete",
				Position = new Point(106, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,88,91,83,27,55,20,126,54,51,252,7,225,135,204,58,195,40,121,46,165,29,48,14,120,10,132,98,104,30,50,121,80,118,143,177,154,181,214,145,180,6,183,225,191,247,28,73,187,43,95,177,203,75,59,227,1,91,123,206,119,238,23,237,141,120,0,126,38,172,24,20,165,78,129,247,148,248,154,195,0,244,20,244,73,106,229,20,110,139,71,118,204,172,46,225,104,127,175,175,164,149,34,151,127,193,25,24,249,160,64,95,21,25,156,150,214,22,42,233,32,193,160,76,83,48,195,50,207,187,121,97,224,10,140,65,9,8,112,67,130,206,193,222,8,45,198,96,65,255,33,242,18,146,118,26,145,181,59,236,248,152,41,100,102,191,50,99,181,84,15,188,55,158,216,25,251,105,75,126,126,87,12,28,159,83,102,42,52,203,106,219,42,37,26,107,145,68,14,89,210,144,240,65,58,130,177,168,180,232,176,191,247,247,90,26,108,169,85,229,129,231,253,61,175,25,251,94,130,158,121,105,21,244,45,224,161,177,252,247,230,209,188,70,36,46,226,227,221,66,89,33,149,73,218,26,210,66,103,253,172,221,241,82,123,202,74,59,187,209,114,44,244,172,91,228,229,88,57,139,81,148,130,71,118,94,202,44,89,39,243,115,131,246,37,146,223,241,234,247,205,53,80,72,215,73,224,189,239,165,200,77,66,34,188,251,137,177,111,186,197,100,134,108,107,244,167,167,24,191,55,111,216,6,181,28,81,172,18,121,186,77,158,109,119,188,144,94,38,45,10,57,240,74,34,218,129,23,124,84,187,125,18,43,124,141,185,128,228,75,17,228,115,102,113,34,91,14,118,183,212,26,148,69,93,202,20,67,140,7,142,218,224,255,82,89,82,237,125,28,139,38,111,238,173,204,177,14,192,240,166,30,78,74,91,156,193,176,6,139,4,49,97,216,34,68,136,197,122,228,193,76,165,35,93,40,132,222,5,115,88,104,16,233,136,37,148,251,166,98,244,134,49,169,216,22,230,123,155,23,120,121,223,156,228,143,98,102,6,144,67,106,155,142,80,27,193,180,107,20,84,55,193,213,46,134,161,134,220,179,88,56,170,105,169,183,184,178,104,173,175,139,212,17,126,146,118,116,223,20,199,43,171,99,30,115,177,68,90,164,45,31,128,141,112,19,119,180,46,181,14,215,214,146,195,123,102,144,27,216,94,113,146,117,62,47,126,41,233,59,139,74,99,28,90,20,243,180,38,49,1,243,82,26,251,179,47,158,95,188,183,93,95,132,161,131,38,42,20,118,86,253,244,20,33,141,92,22,77,157,126,148,59,21,77,8,66,35,14,49,34,7,85,101,244,65,170,236,116,70,170,36,14,131,255,6,51,239,96,10,119,224,60,136,91,237,74,215,123,66,30,29,121,159,123,204,198,205,49,44,166,235,101,81,124,43,39,119,179,9,80,27,9,199,183,48,4,76,250,20,230,99,121,38,205,36,23,193,189,139,42,181,90,145,79,249,73,150,45,90,227,124,239,254,60,55,174,243,21,152,214,133,183,236,159,128,31,41,125,33,76,21,7,210,217,97,39,43,45,250,241,131,213,199,87,101,110,101,243,140,122,176,227,252,87,38,7,222,131,216,228,186,24,211,38,229,171,66,92,242,77,76,115,20,251,133,28,112,89,136,204,107,26,196,135,156,139,64,28,83,212,40,250,202,128,182,84,19,174,101,54,165,180,169,147,125,144,57,110,8,94,161,165,166,227,31,82,245,215,187,132,73,252,97,183,24,79,132,150,166,80,228,73,63,8,15,201,136,165,250,219,80,242,206,130,119,111,87,110,22,252,66,130,22,58,29,173,206,181,59,208,90,152,98,104,209,231,154,150,49,235,135,129,151,229,33,2,227,104,1,232,120,11,105,28,119,50,5,56,117,113,120,108,47,202,135,241,101,83,66,239,111,181,22,200,41,232,216,232,67,103,217,10,104,209,184,157,244,141,91,238,219,119,97,184,108,202,150,190,169,52,144,169,248,127,133,226,5,91,80,149,33,174,114,240,223,10,202,70,85,158,67,192,252,218,23,130,177,180,62,16,253,231,247,95,182,247,162,179,146,166,43,75,189,203,238,13,149,59,54,182,212,246,179,106,127,15,135,10,55,28,89,168,202,187,116,202,107,218,163,23,198,184,91,155,113,241,113,163,124,237,62,177,75,67,89,135,209,246,253,44,251,168,218,135,12,215,64,184,147,99,224,215,190,83,110,228,56,157,225,222,115,184,210,21,235,121,241,166,39,135,114,39,113,21,203,139,242,182,218,92,124,18,239,58,95,95,26,176,175,152,176,175,26,177,59,204,216,151,135,108,179,130,236,52,103,215,15,90,194,194,79,220,23,48,182,185,196,240,213,175,5,146,77,25,75,209,17,209,11,132,8,169,6,8,247,132,80,235,228,242,112,101,192,216,52,188,115,35,178,142,126,184,13,54,22,85,73,48,191,57,59,91,147,78,180,107,5,26,146,89,83,145,191,32,139,220,83,187,190,86,99,245,86,234,43,119,197,194,30,67,197,107,16,126,22,94,66,240,147,63,197,83,111,138,142,197,75,159,152,66,198,7,242,65,137,60,92,109,219,13,165,123,218,62,218,2,161,247,100,181,104,182,27,151,51,62,147,168,172,154,78,121,223,231,159,224,43,229,158,46,114,159,132,238,75,205,74,239,37,220,5,10,171,55,250,186,3,2,189,31,226,183,226,209,185,225,74,124,131,174,152,80,115,245,111,139,70,197,227,157,156,184,239,205,85,154,64,224,201,94,64,62,137,222,44,197,175,97,254,1,159,88,208,25,182,18,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEventSubProcessOkButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEventSubProcessOkButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("80660e8b-5d62-4dad-8708-d67436c56390"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("178efa30-baa5-4f35-beef-06a3cdd84285"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"BaseEventSubProcessOkButtonClick",
				Position = new Point(29, 135),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(209, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEventSubProcessOkButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("570f7190-4f9a-4c59-b921-3fb6604ef35e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("80660e8b-5d62-4dad-8708-d67436c56390"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"OKButtonClick",
				Position = new Point(7, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOKButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("168424fd-2e64-4fba-b50f-616df20a706e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("80660e8b-5d62-4dad-8708-d67436c56390"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ScriptOKButtonClick",
				Position = new Point(112, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,11,78,206,72,205,77,84,80,180,85,200,43,205,201,209,84,168,230,226,244,207,118,206,201,76,206,246,77,45,201,200,79,209,208,180,230,170,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,132,59,83,217,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEventSubProcessCancellButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEventSubProcessCancellButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fbc99e83-d018-4c21-a551-f2f4d71cc46c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("178efa30-baa5-4f35-beef-06a3cdd84285"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"BaseEventSubProcessCancellButtonClick",
				Position = new Point(245, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(288, 240),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEventSubProcessCancellButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("842905ff-4c9d-4400-9347-65424e516a94"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fbc99e83-d018-4c21-a551-f2f4d71cc46c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"CancelButtonClick",
				Position = new Point(43, 95),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptCancelButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d2d0e38e-1a3d-4300-b706-cb579699f2e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fbc99e83-d018-4c21-a551-f2f4d71cc46c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ScriptCancelButtonClick",
				Position = new Point(169, 81),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseSubProcessDataSourceSavedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseSubProcessDataSourceSaved = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("57a0bb57-527e-4e50-bd61-ab14437b2695"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0d9edfd7-f665-4c93-8338-e0a0189f118e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"BaseSubProcessDataSourceSaved",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(540, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseSubProcessDataSourceSaved;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7f51c8f5-1120-4541-a07e-1d312115dadd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57a0bb57-527e-4e50-bd61-ab14437b2695"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"DataSourceSaved",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("65bff8e7-adb5-46db-8a49-917b6122d7d4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57a0bb57-527e-4e50-bd61-ab14437b2695"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ScriptDataSourceSaved",
				Position = new Point(99, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,203,106,195,48,16,69,215,14,228,31,148,172,226,141,62,160,193,148,18,135,16,104,139,137,221,238,7,123,156,138,202,15,70,227,20,83,250,239,149,31,169,109,154,164,213,74,104,238,156,185,163,171,82,177,10,224,136,210,7,134,176,168,40,70,249,16,179,58,225,161,248,16,11,79,228,149,214,174,248,156,207,156,128,84,6,84,251,202,148,26,234,77,161,171,44,127,5,93,161,240,156,171,8,121,181,107,61,32,39,44,241,39,107,10,249,154,207,158,17,147,3,166,132,230,109,71,42,177,140,20,180,105,138,39,32,193,132,216,60,239,147,51,124,135,28,0,65,134,140,212,98,86,203,65,180,116,133,215,173,45,238,69,200,164,242,163,220,102,37,215,226,206,58,238,207,127,48,50,42,186,246,149,107,157,152,246,42,170,50,1,110,37,118,161,48,38,85,178,117,53,30,99,181,202,134,50,114,189,152,10,186,52,162,190,254,88,64,131,122,49,72,17,152,119,217,56,235,247,92,223,144,157,223,55,90,97,206,123,223,182,12,19,111,53,94,140,108,155,179,226,250,98,60,206,239,112,152,186,202,83,145,168,180,238,107,163,25,63,159,106,218,159,179,1,19,114,69,121,215,248,13,74,97,28,24,178,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateTreeGridLoadRowUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ab5c5dfb-c112-4422-b486-2684ad2f53a2"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57a0bb57-527e-4e50-bd61-ab14437b2695"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"TreeGridLoadRowUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(316, 30),
				SchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeTreeGridLoadRowUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskCloseWindowAfterSaveScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4aad0d51-bce3-45cf-b6ab-54fe9375df97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57a0bb57-527e-4e50-bd61-ab14437b2695"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ScriptTaskCloseWindowAfterSave",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(435, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,95,107,194,48,16,127,86,240,59,92,223,18,24,249,0,115,110,136,200,16,166,27,171,195,231,216,94,53,35,75,202,93,170,140,225,119,95,146,10,115,195,65,73,201,221,239,111,76,3,162,236,170,10,185,233,172,157,89,207,184,68,102,189,67,40,38,224,226,76,194,215,104,56,56,104,130,234,114,59,129,235,52,181,246,101,32,227,118,66,142,35,207,68,253,130,243,64,45,120,21,193,207,52,255,104,195,167,184,84,147,50,121,12,94,50,127,79,254,56,179,6,93,152,31,226,241,11,120,3,14,143,240,100,56,220,249,237,59,86,225,94,200,236,115,26,13,227,151,220,86,136,245,43,54,132,188,127,36,83,255,196,231,138,76,27,98,112,113,53,207,180,174,77,48,222,105,91,102,224,180,9,72,165,62,160,132,7,56,51,50,18,110,225,127,108,202,146,107,244,139,165,118,241,66,42,18,250,129,232,83,36,220,57,111,17,99,248,176,49,174,78,181,99,213,62,177,200,42,83,110,211,31,52,195,26,137,52,251,38,168,183,133,218,224,118,230,93,32,111,89,37,128,84,153,154,223,252,4,104,25,179,200,95,233,88,190,209,113,217,187,19,134,142,28,4,234,112,252,13,93,201,87,250,8,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("6ad2c194-854a-494f-97ff-30a9d838fc08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57a0bb57-527e-4e50-bd61-ab14437b2695"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBasePageLoadSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBasePageLoadSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f00b5152-f4ab-4319-8d23-1ffef6884a80"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("178efa30-baa5-4f35-beef-06a3cdd84285"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"BasePageLoadSubProcess",
				Position = new Point(28, 266),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(210, 113),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBasePageLoadSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("419111f5-d617-4a4d-8234-27b88c987edc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f00b5152-f4ab-4319-8d23-1ffef6884a80"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"PageLoad",
				Position = new Point(22, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("be2635dd-cae2-4bbd-9745-3706adc609f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f00b5152-f4ab-4319-8d23-1ffef6884a80"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ScriptPageLoad",
				Position = new Point(106, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,177,106,195,48,16,134,103,233,41,110,116,72,209,11,24,15,142,219,41,67,66,12,221,175,246,31,163,84,72,112,58,165,133,146,119,175,82,67,75,135,12,183,220,253,223,125,252,71,94,224,14,251,93,81,77,209,245,23,254,124,185,34,106,118,67,240,211,187,27,184,100,228,87,14,126,102,245,41,82,71,42,5,173,61,222,185,103,86,30,83,145,9,110,135,115,18,140,124,197,41,125,208,182,179,102,70,192,194,138,38,189,93,48,41,101,196,25,242,68,127,208,143,169,151,37,19,54,244,101,141,241,103,106,122,193,144,226,236,239,182,60,36,145,202,54,112,245,235,102,13,153,127,170,67,124,148,110,107,246,70,8,25,43,134,90,38,78,8,191,21,234,185,142,53,183,214,10,180,72,92,247,223,157,67,71,167,18,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ce62d125-1572-4b36-a9f2-8a7325b02ffb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("178efa30-baa5-4f35-beef-06a3cdd84285"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"BaseInitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 259),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(218, 114),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("033b480f-7a8c-4526-96d4-5df991e5be54"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce62d125-1572-4b36-a9f2-8a7325b02ffb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a7dc6bf1-c6ce-40ae-b1ae-743b61b3e729"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce62d125-1572-4b36-a9f2-8a7325b02ffb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"InitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,140,65,10,194,48,16,69,215,45,244,14,179,108,81,114,1,233,66,48,160,11,65,200,9,98,243,137,74,73,202,100,82,5,241,238,166,42,184,249,139,199,127,239,100,61,212,206,138,53,49,243,0,101,236,12,205,28,153,86,125,83,87,14,35,188,21,180,241,124,195,32,148,16,28,120,77,127,67,207,8,178,101,159,8,29,61,139,82,153,75,188,127,18,71,164,84,242,45,148,126,12,152,228,26,131,250,177,110,179,60,161,14,105,111,131,27,225,168,39,225,140,5,191,202,52,53,67,50,135,47,124,3,105,44,185,233,165,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseEventSubProcessApplyButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseEventSubProcessApplyButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5b967f67-fea2-4eb8-9b96-6e05906cae56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2fbace11-27e0-41c0-a594-f0fa505042bf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"BaseEventSubProcessApplyButtonClick",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(199, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseEventSubProcessApplyButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseStartMessageApplyButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c23df4eb-d85f-4c26-9840-d093e961ce0a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b967f67-fea2-4eb8-9b96-6e05906cae56"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ApplyChangesButtonClick",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"BaseStartMessageApplyButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptApplyChangesButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cd6630e9-5cd5-4bd1-b475-34b85b3bd2d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b967f67-fea2-4eb8-9b96-6e05906cae56"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ScriptApplyChangesButtonClick",
				Position = new Point(98, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,11,78,206,72,205,77,84,176,181,85,200,43,205,201,209,84,168,230,226,44,74,45,41,45,202,83,40,41,42,77,181,230,170,229,2,235,112,76,73,9,78,46,202,44,40,193,48,192,57,39,51,53,175,196,211,69,65,91,129,75,73,175,56,177,44,85,67,211,90,73,211,154,203,179,216,47,191,36,60,51,47,37,191,220,57,39,191,56,85,193,22,106,36,178,249,0,192,97,108,77,147,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess223EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess223 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5b80b7f-3f68-452b-95a4-59ab5baba0fd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"EventSubProcess223",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1075, 492),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess223;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDesignerModeButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("808ce38e-dc30-48fa-9180-f1adcbbd9205"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DesignerModeButtonClick",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"DesignerModeButtonClick",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDesignerModeButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3b5ecbe1-d09e-440a-814d-29bcf66be0de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ScriptDesignerModeButtonClick",
				Position = new Point(295, 268),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,209,106,219,48,20,125,110,32,255,160,250,201,1,163,177,231,174,131,46,201,138,217,210,24,220,236,165,140,33,162,155,84,204,150,141,36,39,11,165,255,190,43,201,78,109,39,233,60,8,56,150,238,57,231,234,228,92,101,199,20,41,217,22,210,245,51,228,108,21,115,114,75,18,124,167,126,129,226,10,125,44,82,163,132,220,134,147,155,241,104,135,128,156,73,44,81,15,44,7,44,15,146,35,126,225,55,130,110,29,214,172,52,168,105,33,37,172,141,40,36,189,7,211,1,132,45,70,43,50,19,174,142,169,195,39,237,164,35,226,159,159,93,179,9,83,88,104,64,105,164,150,176,39,151,235,195,9,121,25,143,174,94,2,193,131,168,123,210,215,200,109,236,4,236,23,5,7,220,14,62,6,245,162,208,182,227,214,242,120,244,138,125,137,13,9,99,253,133,105,176,103,246,212,109,67,96,31,27,200,189,139,247,149,224,20,87,236,211,57,119,166,18,203,234,5,58,85,192,76,221,92,136,219,86,96,46,141,48,7,107,74,68,100,149,101,81,207,199,232,84,56,34,70,85,206,195,171,134,57,101,59,152,129,22,91,9,220,86,125,45,50,14,42,230,177,76,65,107,164,153,49,195,194,1,204,30,184,18,188,49,192,247,215,22,171,203,105,163,129,7,188,128,122,175,195,255,233,140,198,82,27,38,215,64,152,38,11,48,204,91,120,82,134,39,112,141,118,243,67,239,56,15,131,146,41,144,38,105,135,163,31,150,35,182,61,40,167,18,221,89,233,137,61,217,16,254,68,92,135,167,73,70,169,68,142,1,246,238,156,140,35,78,204,145,232,7,203,42,8,3,232,86,6,19,235,128,143,189,229,180,89,189,192,121,125,235,226,228,243,123,214,145,62,119,116,161,61,119,202,215,90,237,218,139,211,88,63,32,251,82,205,243,210,28,194,244,160,113,142,170,12,230,92,24,68,188,163,170,187,165,168,218,7,215,114,248,241,90,36,214,137,111,204,70,37,45,42,181,174,157,157,62,51,185,5,94,7,233,27,28,208,73,4,215,45,98,158,214,204,132,193,112,248,185,64,244,110,181,86,104,159,134,19,219,64,108,88,166,1,9,199,163,101,9,242,45,136,245,80,168,95,86,233,145,233,223,52,233,95,127,93,31,111,254,205,96,247,113,52,235,169,113,9,107,94,124,26,135,180,176,82,153,189,249,155,77,253,225,20,64,153,46,255,4,3,248,226,173,44,20,36,170,216,136,204,254,159,216,11,108,0,108,154,21,26,252,97,150,242,123,193,248,112,40,126,153,86,202,206,252,29,254,114,59,119,43,189,161,21,152,74,73,255,246,23,50,125,203,26,31,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenPageSchemaDesigner_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a71f515a-0302-45e7-929b-09c430d0ceea"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"OpenPageSchemaDesigner_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(428, 268),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenPageSchemaDesigner_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateOpenMessageScriptTask223ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8d5a54c5-07a3-447b-8b11-e60635d2adb3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"OpenMessageScriptTask223",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,49,15,130,48,16,133,119,19,255,67,211,153,56,224,136,58,16,25,24,164,42,48,56,54,120,65,130,94,73,175,68,9,225,191,219,6,6,6,113,122,185,123,223,123,151,19,13,224,9,136,100,9,57,129,206,36,213,190,191,221,156,237,204,246,204,73,176,94,137,223,208,180,202,224,99,44,27,62,85,81,195,61,45,30,240,146,51,107,57,31,23,10,109,144,95,242,40,205,98,145,240,101,52,108,141,81,72,142,190,69,105,34,254,160,87,160,198,162,48,89,46,131,240,102,199,170,48,149,66,169,187,29,25,93,97,233,177,81,15,172,239,121,7,196,61,219,13,228,90,199,31,248,224,177,158,163,114,70,162,230,251,193,94,215,96,90,141,204,232,22,130,47,84,140,99,6,69,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenMessageUserTask223UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("95ad44eb-fc0e-4e71-bcde-6ced292933cd"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"OpenMessageUserTask223",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(463, 37),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenMessageUserTask223Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("a12f5a49-9486-4fa6-bf02-b8070daa132b"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"YesOpenSchema",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IntermediateCatchMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(581, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateGetIsEntitySchemaBlockedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("572a0d59-bce6-46da-a4f9-890c1470503a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"GetIsEntitySchemaBlockedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,109,111,219,54,16,254,172,0,249,15,12,63,20,18,22,168,223,151,165,67,156,216,129,134,214,245,224,184,193,48,236,3,99,157,19,34,178,232,146,84,18,119,237,127,223,29,41,217,122,97,210,117,195,48,12,24,144,23,91,188,123,238,225,221,115,71,42,51,243,229,29,172,197,168,80,203,123,200,217,41,91,137,194,192,201,225,193,131,208,44,7,35,111,75,200,51,11,107,111,151,145,201,194,128,62,87,101,9,75,43,85,121,120,16,165,115,48,6,63,94,8,43,126,53,86,203,242,54,69,131,165,176,241,76,220,66,234,125,211,69,150,167,87,106,238,214,99,62,229,201,49,227,23,173,16,51,45,215,66,111,199,165,149,118,219,196,227,201,111,200,230,178,146,57,131,206,2,18,9,242,59,58,101,101,85,20,236,71,22,147,87,18,52,250,158,209,90,58,94,111,236,246,36,58,60,240,164,217,102,200,96,225,34,185,109,92,130,157,9,45,214,96,65,127,16,69,5,49,135,174,37,79,152,48,204,131,33,235,204,140,132,1,242,109,37,86,174,88,124,84,39,41,51,83,164,250,94,59,30,113,56,122,146,176,223,49,199,46,3,1,11,71,175,132,71,183,161,231,32,48,108,68,113,195,254,152,177,125,54,216,171,87,253,68,227,122,208,209,19,139,6,101,9,26,19,133,168,78,179,217,154,119,42,175,10,24,231,210,58,151,152,118,48,135,2,37,21,119,229,149,144,95,20,161,158,138,106,93,198,124,222,246,229,168,32,202,122,109,51,209,106,221,183,104,214,50,4,212,63,41,217,129,112,12,121,146,190,15,1,247,204,40,14,22,108,252,177,18,197,16,163,75,228,250,14,52,132,33,73,13,45,189,236,16,41,1,63,87,160,183,59,137,245,123,39,105,208,207,202,60,72,0,31,141,251,122,124,9,191,91,184,196,105,215,215,160,137,52,126,130,101,101,145,175,40,132,254,193,87,239,77,236,228,20,61,175,227,94,121,107,1,71,81,167,29,172,174,192,225,68,243,129,26,122,0,206,236,11,254,193,95,252,201,60,227,119,162,68,36,77,109,93,11,214,125,244,221,239,250,44,30,234,120,175,115,79,138,166,92,219,170,6,29,12,57,234,253,142,69,204,199,67,55,238,50,211,33,19,0,39,44,90,29,109,177,66,253,34,80,13,134,27,60,233,80,245,51,243,133,0,123,131,94,51,29,183,50,149,54,131,1,243,239,221,153,241,255,252,60,217,61,238,55,36,249,120,203,116,2,118,121,71,93,119,49,138,91,200,173,137,115,84,91,190,117,231,203,8,187,136,20,233,100,146,208,168,25,44,83,149,122,185,63,175,180,70,116,122,154,238,166,78,125,98,213,27,199,243,7,119,126,5,79,150,228,227,69,57,81,122,141,39,16,237,5,225,69,33,63,137,155,2,154,227,231,10,180,22,70,173,108,122,13,55,103,155,77,122,173,244,189,217,136,37,140,159,54,133,210,160,189,4,249,177,239,133,136,215,65,234,142,204,76,205,25,86,104,76,66,69,198,43,169,215,216,115,238,112,56,238,239,109,138,109,231,91,39,27,156,186,77,55,144,202,111,148,42,152,17,15,72,243,90,218,59,85,89,66,192,111,227,146,54,224,198,37,217,36,84,33,176,22,87,12,105,202,31,73,253,130,243,179,162,80,143,115,241,0,139,178,157,50,222,42,209,11,177,66,37,218,87,240,235,181,248,199,178,63,85,182,97,244,139,170,122,185,255,122,150,191,248,27,206,102,55,141,191,161,243,103,125,39,151,75,130,147,190,39,7,168,233,68,150,249,190,231,251,131,253,217,166,111,40,118,58,126,136,254,66,191,203,86,167,83,177,131,3,251,185,250,213,245,253,43,3,226,245,235,192,136,232,110,165,25,19,1,67,249,159,157,34,115,188,166,80,184,255,135,200,191,48,68,190,53,249,127,127,134,208,214,189,90,169,48,236,244,148,113,186,227,188,85,234,190,218,80,61,169,213,241,173,224,243,103,22,48,59,87,249,159,53,117,148,250,182,62,115,193,107,85,224,82,229,245,236,95,121,118,228,247,206,30,108,162,138,28,244,66,230,205,99,127,205,169,199,78,171,121,189,161,191,156,53,99,138,24,207,52,172,228,211,238,98,226,102,214,254,149,172,117,73,112,219,251,142,241,125,16,142,175,101,238,43,39,208,41,60,238,151,124,46,2,163,239,18,240,90,47,44,16,228,162,148,31,43,71,34,238,178,73,252,126,53,216,74,151,62,69,127,0,42,105,202,2,249,14,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway223ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("492b99e9-cfae-49c0-83b2-9171440c55ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"ExclusiveGateway223",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEvent2IntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("98f8095a-b08c-4ed5-92f6-bc5aab9e4cfe"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"NoOpenSchema",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IntermediateCatchMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(581, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd223EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("2b34f89b-c43d-4f59-94f5-52657163193c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"End223",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(679, 7),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateIsSavedEntityExclusiveGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("02b2852c-3a27-4838-8c05-7fa20d83096b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"IsSavedEntityExclusiveGateway",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareUserTaskParametersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1433783e-76c3-4190-974e-edc838111e6a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"PrepareUserTaskParametersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,177,14,130,64,12,134,119,19,223,225,114,51,241,5,80,7,21,19,6,65,5,6,71,2,13,94,212,30,185,150,40,33,188,187,119,17,18,7,35,83,243,183,223,255,183,141,107,192,173,70,86,216,192,1,136,242,10,50,2,147,230,116,91,28,173,16,43,225,138,63,159,197,127,200,65,167,240,98,107,24,41,231,216,43,184,151,65,169,88,155,1,154,136,10,11,141,54,67,158,178,32,73,195,56,146,19,252,166,97,214,72,206,114,9,146,40,158,226,207,64,181,229,199,190,51,34,60,197,78,21,172,52,230,166,93,18,27,133,149,39,62,117,45,186,78,182,64,210,179,11,128,190,127,75,138,43,60,114,217,123,162,147,168,29,16,233,95,243,222,158,100,128,27,131,130,77,3,254,27,129,181,59,247,116,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEndEvent CreateNoContinueExitEndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("f861f45a-00e0-4dd7-aef4-51d7bc6b09bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"NoContinueExit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateYesContinueIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("90e17638-f884-444a-a4bb-621fa6ac4816"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"YesContinueOpenSchema",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"YesContinueIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 282),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateOpenContinueMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("77c701b7-e570-41b9-a064-e35223e4db3d"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"OpenContinueMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 268),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenContinueMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateNotContinueIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("96a4d659-1d36-4e3d-940c-4340d5f5c1e1"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("944baa2e-3a71-49fd-a29a-6cf363c2f3d3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"NoContinueOpenSchema",
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"NotContinueIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 282),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateAreConditionsCorrectMethod());
			Methods.Add(CreateMakeCaptionMethod());
			Methods.Add(CreateOkClickMethodMethod());
			Methods.Add(CreateInitializeContextHelpButtonMethod());
			Methods.Add(CreateGetIsContextHelpButtonHiddenMethod());
			Methods.Add(CreateGetIsContextHelpEnabledMethod());
			Methods.Add(CreateGetHelpContextIdMethod());
			Methods.Add(CreateShowErrorMessageMethod());
			Methods.Add(CreateBeforeSaveRowOnConditionsCorrectMethod());
			Methods.Add(CreateGetDefValuesMethod());
			Methods.Add(CreateModifyRefreshRowUserTaskParametersMethod());
			Methods.Add(CreateShowTipMethod());
			Methods.Add(CreateGetIsDesignerModeButtonHiddenMethod());
			Methods.Add(CreateInitializeDesignerModeButtonMethod());
			Methods.Add(CreateIsEntityChangedMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateAreConditionsCorrectMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("183c6064-9017-49fb-bf23-5d615ea1d2e1"),
				Name = "AreConditionsCorrect",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b902ddf5-7028-4ff8-a8cd-de6a12d48463"),
				Name = "row",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("144b8f4e-2f30-4ac0-9590-11887f64dc95"),
				Name = "MakeCaption",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,77,79,194,48,24,62,67,194,127,40,28,76,155,144,6,175,34,26,51,62,178,11,18,64,61,24,15,117,235,176,201,214,46,111,59,113,33,251,239,118,235,6,98,28,39,15,75,151,188,207,87,159,190,34,194,190,246,88,106,132,146,179,47,161,141,38,232,208,235,118,128,155,12,228,184,215,45,122,221,79,6,40,80,113,150,200,37,75,56,154,160,21,219,113,58,101,134,109,84,6,1,167,155,224,131,39,140,206,133,12,87,32,18,6,249,84,232,52,102,185,119,100,97,50,118,66,105,11,192,202,110,12,8,185,163,179,36,53,121,141,6,30,40,8,27,203,5,55,43,6,22,108,56,60,179,56,227,120,224,0,126,56,32,103,12,191,228,212,228,254,4,201,44,142,209,61,146,124,143,22,153,8,177,155,208,173,114,150,152,16,116,83,77,206,204,3,87,75,251,133,235,222,44,92,87,58,13,99,174,32,97,198,242,6,135,81,129,240,225,186,32,3,11,18,17,194,125,95,47,109,138,171,43,100,255,60,149,230,174,110,17,97,39,65,237,220,134,125,132,42,8,62,213,78,28,176,243,151,133,53,40,245,59,5,226,177,230,14,119,161,231,223,183,89,171,189,126,29,189,149,245,110,243,148,135,14,92,21,124,235,82,221,253,12,82,58,181,6,110,179,37,164,100,93,78,111,191,83,229,181,186,67,226,51,222,176,233,121,216,186,77,196,109,238,177,142,11,109,216,231,88,87,235,112,122,205,255,142,129,171,198,31,116,90,158,136,105,180,229,0,76,171,200,208,39,159,190,240,119,79,73,3,42,214,180,4,144,102,175,172,125,237,48,254,6,74,194,195,221,167,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("eef1c386-4caa-4531-9af1-0e0e8e96fc18"),
				Name = "OkClickMethod",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,65,10,131,48,16,69,215,10,222,97,200,202,80,200,5,164,139,162,80,92,180,20,133,238,131,25,219,129,212,72,18,149,34,222,189,209,118,93,151,51,111,120,255,207,21,81,85,216,90,116,207,179,37,5,71,240,118,192,44,137,169,77,75,151,155,254,205,231,36,142,110,242,129,162,110,44,245,254,34,187,48,88,113,82,234,187,72,55,88,72,47,107,51,216,6,69,174,9,59,95,22,112,0,38,156,28,49,229,25,227,193,185,36,49,106,135,187,194,192,35,70,45,164,44,40,254,218,101,227,105,196,202,76,226,101,20,181,132,234,46,245,128,142,195,204,96,213,68,59,130,95,61,88,147,182,216,5,214,138,48,195,68,157,10,222,70,27,183,93,44,44,240,237,139,15,212,163,194,119,52,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0ba6c2a5-22b9-4f86-80f4-5e3b9a51f2b6"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,205,10,130,80,16,133,215,250,20,211,70,20,196,23,144,54,73,164,139,32,48,219,223,188,163,14,232,40,58,70,20,189,123,215,254,200,90,13,243,157,51,115,102,168,0,119,177,65,73,134,168,101,193,179,196,88,119,171,81,164,229,152,180,70,118,61,112,28,248,117,172,89,29,107,212,174,231,193,213,182,6,233,137,75,168,140,240,242,36,26,150,176,83,37,6,105,94,97,163,130,248,91,11,109,235,164,122,24,7,236,13,99,204,133,90,126,15,100,51,106,172,251,212,180,5,149,99,175,38,18,28,72,99,59,237,203,132,106,18,194,33,72,216,84,85,211,5,255,190,112,31,75,255,176,63,191,214,135,45,242,56,201,137,96,19,169,110,74,122,194,79,220,76,153,223,238,133,246,237,14,159,224,29,124,74,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9f86fe51-7120-4816-bb5a-6091fb3dc3a0"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dea76bc0-00f6-4a3f-b249-7d37da7d333c"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetHelpContextIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("87bb2429-754a-4e8a-b189-382d15c14ccc"),
				Name = "GetHelpContextId",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,115,79,45,9,72,44,74,204,77,45,73,45,10,75,204,41,77,213,80,202,72,205,41,112,206,207,43,73,173,40,241,76,81,210,84,72,44,86,40,46,41,202,204,75,183,6,0,132,208,221,229,57,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowErrorMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c0f2a7f3-b0f8-43bf-9f5f-7936baa47078"),
				Name = "ShowErrorMessage",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3da967d1-bac9-4b21-9802-93fbd7fac38e"),
				Name = "errorMessage",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,49,11,194,48,16,133,231,230,87,156,157,18,8,193,189,116,168,130,91,161,131,226,32,14,129,156,229,32,38,37,151,14,34,254,119,69,34,196,233,113,223,123,247,222,136,204,118,198,201,6,244,112,175,143,30,246,49,228,20,253,41,147,167,76,200,230,64,193,21,40,69,51,125,162,102,224,229,171,5,243,101,123,213,208,238,44,227,88,149,181,26,114,90,81,129,101,168,121,39,232,6,242,111,118,211,67,88,189,87,240,20,77,109,152,193,185,242,42,207,54,5,10,179,6,76,41,166,66,245,175,249,248,88,208,148,136,234,196,235,13,218,118,193,1,227,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBeforeSaveRowOnConditionsCorrectMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a4942fed-d838-495c-8d4c-2ce128b67fdd"),
				Name = "BeforeSaveRowOnConditionsCorrect",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f1b11efd-2f36-4b72-bcf0-59efd5d29509"),
				Name = "row",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9db2e75d-76be-4c70-bb1e-cffd2f0ae333"),
				Name = "GetDefValues",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, object>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,91,111,219,54,20,126,150,127,5,171,135,66,2,12,161,207,115,211,161,113,210,194,24,210,122,112,178,61,4,121,96,37,166,97,33,83,25,73,121,16,134,252,247,242,106,241,154,120,1,134,229,33,182,201,115,62,158,243,157,27,121,128,20,60,66,138,8,191,36,28,243,105,211,125,253,246,3,156,129,45,252,142,154,207,136,111,33,133,123,196,17,253,3,246,35,170,202,173,39,91,214,171,197,33,64,216,181,15,104,15,255,13,142,213,176,104,108,98,87,67,55,246,232,2,113,136,251,151,160,118,161,184,197,25,25,114,55,158,71,185,241,133,45,70,135,238,149,0,19,170,4,253,13,46,112,203,241,64,32,157,222,51,78,49,249,190,4,195,183,31,168,229,31,42,161,129,239,65,21,179,249,70,168,142,125,15,222,190,77,187,230,236,39,76,118,118,115,52,27,145,26,252,179,40,114,225,48,246,127,30,113,87,101,112,154,235,97,167,124,170,106,225,75,132,148,199,200,105,71,222,186,0,41,42,18,24,1,35,2,97,61,144,3,162,92,200,158,15,67,143,32,169,98,214,18,64,200,113,247,10,18,145,6,212,166,131,94,108,188,189,45,29,14,184,67,84,230,138,89,170,202,203,24,163,172,1,100,96,81,92,35,74,33,27,238,121,179,30,40,106,148,36,70,172,73,168,8,131,116,238,136,236,146,246,234,205,47,34,29,133,65,161,191,191,130,48,193,117,233,124,100,172,45,193,47,206,238,101,135,121,36,177,58,205,50,176,119,14,48,75,103,41,202,36,29,27,194,56,36,45,58,159,164,205,85,232,132,37,92,175,75,43,254,99,7,231,195,92,151,126,31,17,157,76,194,69,235,85,194,181,101,210,98,191,18,214,67,63,238,201,149,144,219,66,254,160,127,137,51,50,167,55,31,187,78,203,216,134,231,235,151,22,188,125,53,108,2,208,203,173,141,145,60,153,252,28,229,146,232,156,61,159,112,47,26,41,147,118,85,57,153,53,69,144,35,45,249,39,230,15,199,254,203,42,189,184,30,246,130,99,204,6,114,61,61,138,52,253,107,132,253,82,20,86,17,59,178,140,59,139,42,243,255,199,62,201,214,49,33,135,22,67,57,32,148,204,122,232,80,185,4,229,133,25,34,101,61,215,134,25,43,194,169,30,169,145,242,76,188,69,205,233,197,89,186,18,243,74,152,68,136,254,41,113,229,240,73,224,10,43,70,194,193,7,240,78,205,7,155,30,126,202,137,195,245,122,115,185,127,228,211,106,150,75,229,125,66,122,46,145,211,187,199,205,38,61,138,164,51,39,117,45,93,226,232,228,162,119,13,172,87,32,251,103,252,65,1,231,154,132,103,110,2,250,83,221,4,138,226,94,152,13,219,135,202,13,55,192,36,21,122,29,152,34,10,137,21,149,180,201,132,50,37,160,214,222,219,195,82,189,163,177,157,171,80,89,241,198,68,107,195,190,136,107,194,87,170,162,22,40,214,198,8,165,160,166,226,5,228,112,55,140,180,61,14,200,79,152,116,250,171,62,230,124,146,154,33,16,56,115,174,35,69,202,175,12,188,240,210,69,151,194,231,147,85,11,79,81,206,21,79,11,251,47,147,167,39,81,152,239,237,14,145,137,122,48,103,164,212,95,224,62,68,241,216,119,211,52,199,121,4,16,177,158,53,244,36,182,83,62,69,156,71,21,102,38,151,171,28,52,130,112,128,69,126,168,51,50,149,167,26,184,159,7,75,239,176,57,92,210,190,248,92,119,16,196,187,175,31,1,133,199,236,150,226,61,180,100,52,122,96,249,215,101,53,7,138,176,167,71,13,71,112,7,18,236,165,198,129,42,169,120,38,216,46,4,170,249,154,33,155,80,134,96,147,60,179,172,170,19,115,119,72,26,162,127,86,117,99,67,36,214,204,189,80,35,52,10,194,238,31,241,84,152,143,173,208,9,108,243,27,154,150,145,125,183,239,238,36,178,3,82,5,6,214,54,236,79,139,39,245,114,227,34,68,90,254,230,165,23,164,39,106,95,126,114,241,20,69,173,33,235,118,214,112,222,108,145,25,225,99,173,117,239,103,153,206,232,145,43,199,230,241,21,21,194,187,15,159,186,49,76,167,120,214,105,233,225,196,0,43,195,229,17,224,37,66,28,65,203,74,160,235,80,227,167,107,179,67,140,137,79,233,253,173,175,228,216,116,23,241,119,176,207,243,215,193,137,199,91,254,77,47,184,243,10,8,115,180,151,229,163,207,212,213,114,196,190,149,187,50,125,239,132,49,234,187,90,95,233,148,164,136,143,212,153,254,171,159,197,177,169,77,122,17,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateModifyRefreshRowUserTaskParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("72f9801f-9cd3-4959-8019-f476da6bea86"),
				Name = "ModifyRefreshRowUserTaskParameters",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateShowTipMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9258d962-24aa-494f-91e2-1a0cb32e8768"),
				Name = "ShowTip",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,80,193,106,195,48,12,61,39,95,161,229,80,108,8,102,247,146,67,183,177,209,195,88,160,233,46,165,7,173,81,139,135,99,7,91,25,140,209,127,159,147,37,195,59,238,36,244,244,244,244,158,62,208,3,235,126,219,190,188,189,67,5,53,94,72,61,17,215,232,177,35,38,255,138,102,32,81,76,148,66,174,115,125,6,241,203,191,169,192,14,198,192,106,5,251,64,254,222,89,75,39,214,206,170,29,133,16,235,3,50,30,22,186,106,220,142,189,182,23,33,143,203,170,132,175,60,11,19,58,218,136,14,196,79,39,255,41,184,206,179,231,72,137,246,107,180,100,160,75,155,10,162,18,123,103,246,172,141,102,77,65,61,106,219,206,160,152,66,111,66,63,213,25,12,135,219,99,9,197,29,6,74,117,139,18,216,15,36,1,3,164,120,60,63,126,230,207,213,52,98,150,78,212,166,109,231,101,209,232,190,28,147,151,139,92,243,217,147,218,218,179,243,29,142,201,227,207,179,107,126,253,6,39,163,34,38,168,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsDesignerModeButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("be90a8f4-f515-4710-a1a2-60438c18aea2"),
				Name = "GetIsDesignerModeButtonHidden",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,93,79,157,64,16,125,198,196,255,176,242,208,64,210,240,3,106,109,227,253,208,222,166,234,109,80,251,208,244,97,11,227,117,83,88,232,126,104,111,170,255,189,51,11,84,22,184,214,190,1,123,230,204,153,51,195,236,29,87,76,67,102,149,48,219,165,220,8,9,236,136,93,105,80,243,74,74,200,140,168,100,178,152,165,30,226,112,127,239,123,85,21,44,227,114,126,203,229,6,142,235,186,16,25,39,240,165,149,66,110,206,170,156,120,14,124,230,228,20,204,156,203,229,47,252,106,224,162,6,229,66,162,112,254,44,81,24,99,194,224,14,133,214,124,3,105,118,11,37,63,227,18,159,213,88,43,166,240,16,81,184,30,6,57,62,162,19,6,74,100,24,177,38,39,66,230,43,60,156,109,175,86,121,68,4,73,3,72,240,61,102,92,179,149,23,64,88,228,20,55,44,138,136,52,57,231,37,214,127,196,194,25,215,240,169,170,126,216,122,153,11,67,76,97,204,30,30,216,4,108,142,165,190,16,122,205,11,59,194,198,236,55,218,164,192,88,37,255,209,26,212,250,184,191,167,141,194,119,86,43,81,114,133,45,50,216,168,166,44,172,18,125,113,117,163,159,107,174,48,185,1,229,210,70,33,248,200,208,25,210,144,33,241,169,21,57,27,64,90,111,26,76,178,210,231,182,40,46,212,178,172,205,54,154,78,223,86,227,154,222,0,22,220,240,180,178,42,163,193,138,158,222,226,126,123,168,113,244,142,3,97,84,85,204,182,100,155,215,192,245,144,141,16,110,192,72,225,40,87,27,70,206,75,20,29,147,168,206,99,163,44,57,25,160,149,1,140,220,219,69,149,52,126,60,50,40,52,184,34,199,177,18,238,25,249,184,203,156,166,127,100,78,63,150,124,233,35,227,193,175,209,63,155,158,244,129,146,56,89,73,109,184,204,160,109,160,151,237,160,177,132,189,122,229,169,192,246,46,102,215,2,238,189,121,108,189,106,85,231,160,197,70,130,203,220,68,185,178,125,189,24,156,164,160,53,62,146,137,95,219,233,65,0,142,243,240,167,76,46,171,212,157,71,225,121,24,191,102,225,162,151,98,61,118,145,198,246,219,212,180,58,33,147,250,186,122,223,179,136,162,226,73,208,27,215,183,196,141,118,183,38,133,254,32,242,28,36,46,60,217,202,82,51,107,76,37,49,213,13,199,49,104,237,61,248,255,31,196,233,159,64,188,116,140,250,83,63,136,199,122,159,106,25,118,185,57,159,12,108,132,5,35,83,39,193,36,33,104,23,145,222,106,92,78,182,0,218,105,46,36,162,10,82,40,112,32,34,127,56,98,138,11,2,156,134,194,150,120,131,164,253,216,16,251,79,13,110,49,39,170,42,135,136,238,108,133,132,234,99,37,60,10,167,48,140,147,139,41,226,1,140,242,96,195,150,63,45,47,198,28,190,144,47,183,160,96,154,242,233,146,186,242,24,201,128,207,22,212,246,239,18,30,93,71,29,251,177,204,39,5,224,167,229,112,99,63,199,239,55,46,118,219,189,233,65,151,169,189,192,211,140,23,92,189,109,186,247,46,114,227,20,236,220,243,131,238,182,243,139,1,207,253,29,221,138,117,59,246,209,237,143,23,93,112,116,111,238,38,62,252,3,116,37,204,243,245,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeDesignerModeButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("75e31798-b9b1-42fc-a41b-7a2291ba85e5"),
				Name = "InitializeDesignerModeButton",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,78,77,46,45,202,44,169,116,205,75,207,204,75,85,176,85,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,70,81,97,205,85,6,212,149,89,236,145,153,146,146,154,7,84,239,158,90,226,89,236,146,90,156,153,158,151,90,228,155,159,146,234,84,90,82,146,159,7,145,215,208,180,230,10,72,76,79,213,195,84,160,7,55,1,102,152,53,0,181,161,39,38,144,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsEntityChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9c03bf45-e47e-46fa-81fb-22a0720e4d07"),
				Name = "IsEntityChanged",
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,76,46,201,44,75,13,202,47,247,205,79,201,76,203,76,77,177,6,0,222,22,119,253,41,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"));
		}

		#endregion

	}

	#endregion

}

