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

	#region Class: BaseAdministrativeGridPageSchema

	/// <exclude/>
	public class BaseAdministrativeGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _upButton;
		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return _upButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _downButton;
		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return _downButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _checkBoxControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CheckBoxControlLayout {
			get {
				return _checkBoxControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _showRelatedRightsCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox ShowRelatedRightsCheckBox {
			get {
				return _showRelatedRightsCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _showRelatedRightsButton;
		public Terrasoft.UI.WebControls.Controls.Button ShowRelatedRightsButton {
			get {
				return _showRelatedRightsButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _ownMenuItem;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem OwnMenuItem {
			get {
				return _ownMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _allMenuItem;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem AllMenuItem {
			get {
				return _allMenuItem;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseAdministrativeGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseAdministrativeGridPageSchema(BaseAdministrativeGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.FooterVisible = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			RealUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			Name = "BaseAdministrativeGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseAdministrativeGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.InsertItem(4, CreateUpButton());
			ButtonsControlLayout.InsertItem(5, CreateDownButton());
			ButtonsControlLayout.InsertItem(6, CreateCheckBoxControlLayout());
			CheckBoxControlLayout.InsertItem(0, CreateShowRelatedRightsCheckBox());
			ButtonsControlLayout.MoveItem(7, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(8, PrintButton);
			ButtonsControlLayout.InsertItem(9, CreateShowRelatedRightsButton());
			ShowRelatedRightsButton.InsertItem(0, CreateOwnMenuItem());
			ShowRelatedRightsButton.InsertItem(1, CreateAllMenuItem());
			ButtonsControlLayout.MoveItem(10, ContextHelpButton);
			ButtonsControlLayout.MoveItem(11, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseAdministrativeGridPageEventsProcessSchema() {
			var schema = new BaseAdministrativeGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpButton() {
			_upButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upButton.UId = new Guid("f9f98030-84c0-45f7-ade0-eb1d24ee211c");
			_upButton.Name = "UpButton";
			_upButton.CreatedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_upButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_upButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_upButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upButton.Tag = "";
			_upButton.Image = new ControlImage {};
			_upButton.Enabled = false;
			return _upButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownButton() {
			_downButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downButton.UId = new Guid("962ddee8-658c-4475-b1c0-b1148fccf100");
			_downButton.Name = "DownButton";
			_downButton.CreatedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_downButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_downButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_downButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downButton.Tag = "";
			_downButton.Image = new ControlImage {};
			_downButton.Enabled = false;
			return _downButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateShowRelatedRightsCheckBox() {
			_showRelatedRightsCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_showRelatedRightsCheckBox.UId = new Guid("412d6e44-3fd1-452c-93d9-b368e6c61d25");
			_showRelatedRightsCheckBox.Name = "ShowRelatedRightsCheckBox";
			_showRelatedRightsCheckBox.CreatedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_showRelatedRightsCheckBox.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_showRelatedRightsCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_showRelatedRightsCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_showRelatedRightsCheckBox.Tag = "";
			_showRelatedRightsCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showRelatedRightsCheckBox.AlignedByCaption = false;
			return _showRelatedRightsCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCheckBoxControlLayout() {
			_checkBoxControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_checkBoxControlLayout.UId = new Guid("21890edd-4fb3-481d-994a-f302e9fa115f");
			_checkBoxControlLayout.Name = "CheckBoxControlLayout";
			_checkBoxControlLayout.CreatedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_checkBoxControlLayout.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_checkBoxControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_checkBoxControlLayout.Tag = "";
			_checkBoxControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_checkBoxControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_checkBoxControlLayout.FitHeightByContent = true;
			_checkBoxControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_checkBoxControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_checkBoxControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_checkBoxControlLayout.StartNewAlignGroup = false;
			_checkBoxControlLayout.Image = new ControlImage {};
			_checkBoxControlLayout.Edges = "";
			_checkBoxControlLayout.SplitterSize = 0;
			_checkBoxControlLayout.Hidden = true;
			return _checkBoxControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateOwnMenuItem() {
			_ownMenuItem = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_ownMenuItem.UId = new Guid("1030a902-ad8e-4cfa-893d-b9a5f26d4982");
			_ownMenuItem.Name = "OwnMenuItem";
			_ownMenuItem.CreatedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_ownMenuItem.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_ownMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_ownMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_ownMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			_ownMenuItem.Group = "Group";
			_ownMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_ownMenuItem.Image = new ControlImage {};
			_ownMenuItem.Tag = "";
			return _ownMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateAllMenuItem() {
			_allMenuItem = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_allMenuItem.UId = new Guid("3be45e70-c888-40b0-a95d-85ffd364655c");
			_allMenuItem.Name = "AllMenuItem";
			_allMenuItem.CreatedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_allMenuItem.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_allMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_allMenuItem.AjaxEvents.CheckChange.IsProcessEventHandler = true;
			_allMenuItem.AjaxEvents.CheckChange.ShowLoadMask = true;
			_allMenuItem.Group = "Group";
			_allMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allMenuItem.Image = new ControlImage {};
			_allMenuItem.Tag = "";
			return _allMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateShowRelatedRightsButton() {
			_showRelatedRightsButton = new Terrasoft.UI.WebControls.Controls.Button();
			_showRelatedRightsButton.UId = new Guid("b59be2a6-0853-44b0-97e8-e252a6170035");
			_showRelatedRightsButton.Name = "ShowRelatedRightsButton";
			_showRelatedRightsButton.CreatedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_showRelatedRightsButton.ModifiedInSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			_showRelatedRightsButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_showRelatedRightsButton.Tag = "";
			_showRelatedRightsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"),
				ImageHash = @"57f7aae3209afa943cac8813eca36f32"
			};
			_showRelatedRightsButton.ImageAsSprite = false;
			return _showRelatedRightsButton;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseAdministrativeGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseAdministrativeGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseAdministrativeGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseAdministrativeGridPageEventsProcess

	/// <exclude/>
	public class BaseAdministrativeGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseAdministrativeGridPageSchemaUserControl
	{

		#region Class: OpenLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskFlowElement(UserConnection userConnection, BaseAdministrativeGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("a5425596-1e11-4375-949b-f3225640a939");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public BaseAdministrativeGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseAdministrativeGridPageEventsProcess";
			SchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1");
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

		public virtual string VirtualDataSourceID {
			get;
			set;
		}

		public virtual Guid SelectedSchemaUIdForAddRights {
			get;
			set;
		}

		public virtual string OperationRightCode {
			get;
			set;
		}

		public virtual int RowsCount {
			get;
			set;
		}

		public virtual string RightsSchemaName {
			get;
			set;
		}

		public virtual string RightsGrouppingColumnNames {
			get;
			set;
		}

		public virtual Object SelectParameters {
			get;
			set;
		}

		public virtual bool ShowRightsBySubject {
			get;
			set;
		}

		private ProcessFlowElement _subProcess_ShowRelatedRightsCheckBoxCheck;
		public ProcessFlowElement SubProcess_ShowRelatedRightsCheckBoxCheck {
			get {
				return _subProcess_ShowRelatedRightsCheckBoxCheck ?? (_subProcess_ShowRelatedRightsCheckBoxCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess_ShowRelatedRightsCheckBoxCheck",
					SchemaElementUId = new Guid("0a1730f7-422b-4490-b13a-a5bfdb86acd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _showRelatedRightsCheckBoxCheckMessage;
		public ProcessFlowElement ShowRelatedRightsCheckBoxCheckMessage {
			get {
				return _showRelatedRightsCheckBoxCheckMessage ?? (_showRelatedRightsCheckBoxCheckMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ShowRelatedRightsCheckBoxCheckMessage",
					SchemaElementUId = new Guid("01e7250b-5ac1-495a-a1cd-2694f2f00ff9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwGridPageRefreshRow;
		public ProcessThrowMessageEvent ThrowGridPageRefreshRow {
			get {
				return _throwGridPageRefreshRow ?? (_throwGridPageRefreshRow = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowGridPageRefreshRow",
					SchemaElementUId = new Guid("d5cf731b-23ba-4b9d-9ddc-a05c4efcad57"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "GridPageRefreshRow",
				});
			}
		}

		private ProcessFlowElement _subProcess_Init;
		public ProcessFlowElement SubProcess_Init {
			get {
				return _subProcess_Init ?? (_subProcess_Init = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess_Init",
					SchemaElementUId = new Guid("e9beb33e-d684-49d5-b0c7-1c937558a885"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initMessage;
		public ProcessFlowElement InitMessage {
			get {
				return _initMessage ?? (_initMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitMessage",
					SchemaElementUId = new Guid("a2c5e314-59c0-431c-b9e3-84f71bebf1d3"),
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
					SchemaElementUId = new Guid("c7ca807a-2179-4a7d-bc29-55a9a3b5b76e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBaseInit;
		public ProcessThrowMessageEvent IntermediateThrowBaseInit {
			get {
				return _intermediateThrowBaseInit ?? (_intermediateThrowBaseInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBaseInit",
					SchemaElementUId = new Guid("029d3827-89d0-4cdb-9117-ecdc80321e71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BaseAdministrativeGrid",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcessSelectingEntitySchemaForAddRights;
		public ProcessFlowElement SubProcessSelectingEntitySchemaForAddRights {
			get {
				return _subProcessSelectingEntitySchemaForAddRights ?? (_subProcessSelectingEntitySchemaForAddRights = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessSelectingEntitySchemaForAddRights",
					SchemaElementUId = new Guid("dbc979b5-d64a-4862-a27b-079c87fb9f3f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _message_OpenVwSysSchemaInSolution;
		public ProcessFlowElement Message_OpenVwSysSchemaInSolution {
			get {
				return _message_OpenVwSysSchemaInSolution ?? (_message_OpenVwSysSchemaInSolution = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Message_OpenVwSysSchemaInSolution",
					SchemaElementUId = new Guid("7c3394be-25d1-46b8-a435-988dbbbff0e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initOpenLookupUserTaskScript;
		public ProcessScriptTask InitOpenLookupUserTaskScript {
			get {
				return _initOpenLookupUserTaskScript ?? (_initOpenLookupUserTaskScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitOpenLookupUserTaskScript",
					SchemaElementUId = new Guid("ecf4a4f1-426d-47e3-b6ef-0b00ce5e673b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitOpenLookupUserTaskScriptExecute,
				});
			}
		}

		private OpenLookupUserTaskFlowElement _openLookupUserTask;
		public OpenLookupUserTaskFlowElement OpenLookupUserTask {
			get {
				return _openLookupUserTask ?? (_openLookupUserTask = new OpenLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _catchMessage_LookupGridPageClosed;
		public ProcessIntermediateCatchMessageEvent CatchMessage_LookupGridPageClosed {
			get {
				return _catchMessage_LookupGridPageClosed ?? (_catchMessage_LookupGridPageClosed = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "CatchMessage_LookupGridPageClosed",
					SchemaElementUId = new Guid("12084bd3-aca9-4b3b-8669-db9c8bd3988a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _applyDataScript;
		public ProcessScriptTask ApplyDataScript {
			get {
				return _applyDataScript ?? (_applyDataScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ApplyDataScript",
					SchemaElementUId = new Guid("4d0bc475-4133-45b7-bfa5-0bce554330ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ApplyDataScriptExecute,
				});
			}
		}

		private ProcessExclusiveEventBasedGateway _eventBasedGateway1;
		public ProcessExclusiveEventBasedGateway EventBasedGateway1 {
			get {
				return _eventBasedGateway1 ?? (_eventBasedGateway1 = new ProcessExclusiveEventBasedGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventBasedGateway",
					Name = "EventBasedGateway1",
					SchemaElementUId = new Guid("111f5cf3-2bcf-4ca0-8a33-b3200ee96179"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Events = new Collection<string> { "CatchMessage_LookupGridPageClosed", "IntermediateCatchMessageEvent1", },
				});
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
					SchemaElementUId = new Guid("80c43959-c297-438f-b82e-7fdf975f5c9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Initialize",
				});
			}
		}

		private ProcessFlowElement _subProcess_AddEntitySchemaRight;
		public ProcessFlowElement SubProcess_AddEntitySchemaRight {
			get {
				return _subProcess_AddEntitySchemaRight ?? (_subProcess_AddEntitySchemaRight = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess_AddEntitySchemaRight",
					SchemaElementUId = new Guid("c59df333-0dcf-4e0d-ba45-191109460160"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _message_SelectSchemaForAddRights;
		public ProcessFlowElement Message_SelectSchemaForAddRights {
			get {
				return _message_SelectSchemaForAddRights ?? (_message_SelectSchemaForAddRights = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Message_SelectSchemaForAddRights",
					SchemaElementUId = new Guid("62fdbefd-5512-4279-9a89-d1465dc1c715"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSelectSchemaForAddRights;
		public ProcessScriptTask ScriptSelectSchemaForAddRights {
			get {
				return _scriptSelectSchemaForAddRights ?? (_scriptSelectSchemaForAddRights = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSelectSchemaForAddRights",
					SchemaElementUId = new Guid("03ac8f45-0301-4ff5-96ac-05570dcfdff7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSelectSchemaForAddRightsExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessPositionButtonClick;
		public ProcessFlowElement SubProcessPositionButtonClick {
			get {
				return _subProcessPositionButtonClick ?? (_subProcessPositionButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessPositionButtonClick",
					SchemaElementUId = new Guid("925c7e9f-2606-4e85-8423-6ba551b04677"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDownButtonClick;
		public ProcessFlowElement StartMessageDownButtonClick {
			get {
				return _startMessageDownButtonClick ?? (_startMessageDownButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDownButtonClick",
					SchemaElementUId = new Guid("b1be5054-17de-4feb-9d45-5c947bede808"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDownButtonClick;
		public ProcessScriptTask ScriptDownButtonClick {
			get {
				return _scriptDownButtonClick ?? (_scriptDownButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDownButtonClick",
					SchemaElementUId = new Guid("ff202233-d33c-43cc-bdf2-0d4c5a21adaf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDownButtonClickExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageGridPageRefreshRow;
		public ProcessThrowMessageEvent IntermediateThrowMessageGridPageRefreshRow {
			get {
				return _intermediateThrowMessageGridPageRefreshRow ?? (_intermediateThrowMessageGridPageRefreshRow = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageGridPageRefreshRow",
					SchemaElementUId = new Guid("a5d2b11d-ba19-41ea-a445-89383c43fce6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "GridPageRefreshRow",
				});
			}
		}

		private ProcessFlowElement _startMessageUpButtonClick;
		public ProcessFlowElement StartMessageUpButtonClick {
			get {
				return _startMessageUpButtonClick ?? (_startMessageUpButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageUpButtonClick",
					SchemaElementUId = new Guid("c7d71abf-09e4-42a4-8cf8-79566a944e61"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptUpButtonClick;
		public ProcessScriptTask ScriptUpButtonClick {
			get {
				return _scriptUpButtonClick ?? (_scriptUpButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptUpButtonClick",
					SchemaElementUId = new Guid("503e6fbf-801d-49ef-8445-6b3b477f7fb1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptUpButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessOwnMenuItemCheckChange;
		public ProcessFlowElement SubProcessOwnMenuItemCheckChange {
			get {
				return _subProcessOwnMenuItemCheckChange ?? (_subProcessOwnMenuItemCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessOwnMenuItemCheckChange",
					SchemaElementUId = new Guid("9b908f37-d1af-474e-b7e8-b560a688531e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _ownMenuItemCheckChange;
		public ProcessFlowElement OwnMenuItemCheckChange {
			get {
				return _ownMenuItemCheckChange ?? (_ownMenuItemCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OwnMenuItemCheckChange",
					SchemaElementUId = new Guid("1f4b9ae8-6114-4595-9c87-5df5377a1b6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _ownMenuItemOwnMenuItem;
		public ProcessThrowMessageEvent OwnMenuItemOwnMenuItem {
			get {
				return _ownMenuItemOwnMenuItem ?? (_ownMenuItemOwnMenuItem = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OwnMenuItemOwnMenuItem",
					SchemaElementUId = new Guid("ea67604d-499e-41e3-b54d-d0bb2904171a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "GridPageRefreshRow",
				});
			}
		}

		private ProcessScriptTask _scriptOwnMenuItemCheckChange;
		public ProcessScriptTask ScriptOwnMenuItemCheckChange {
			get {
				return _scriptOwnMenuItemCheckChange ?? (_scriptOwnMenuItemCheckChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOwnMenuItemCheckChange",
					SchemaElementUId = new Guid("e4393af3-45c1-4e77-bd0d-2ea43d020f23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOwnMenuItemCheckChangeExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessAllMenuItemCheckChange;
		public ProcessFlowElement SubProcessAllMenuItemCheckChange {
			get {
				return _subProcessAllMenuItemCheckChange ?? (_subProcessAllMenuItemCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessAllMenuItemCheckChange",
					SchemaElementUId = new Guid("eb15c43d-68ce-4489-bad0-fd0ca446c8fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _allMenuItemCheckChange;
		public ProcessFlowElement AllMenuItemCheckChange {
			get {
				return _allMenuItemCheckChange ?? (_allMenuItemCheckChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AllMenuItemCheckChange",
					SchemaElementUId = new Guid("18d5ff94-db6d-45ff-9b40-a6488556e13e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _allMenuItemGridPageRefreshRow;
		public ProcessThrowMessageEvent AllMenuItemGridPageRefreshRow {
			get {
				return _allMenuItemGridPageRefreshRow ?? (_allMenuItemGridPageRefreshRow = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "AllMenuItemGridPageRefreshRow",
					SchemaElementUId = new Guid("44444cfb-7e23-4f57-97f0-7d4c9dda05f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "GridPageRefreshRow",
				});
			}
		}

		private ProcessScriptTask _scriptAllMenuItemCheckChange;
		public ProcessScriptTask ScriptAllMenuItemCheckChange {
			get {
				return _scriptAllMenuItemCheckChange ?? (_scriptAllMenuItemCheckChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAllMenuItemCheckChange",
					SchemaElementUId = new Guid("eac4cbe5-406f-4a72-84c2-6024e6fb792c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAllMenuItemCheckChangeExecute,
				});
			}
		}

		private ProcessFlowElement _processAdministrativGridPageLoadComplete;
		public ProcessFlowElement ProcessAdministrativGridPageLoadComplete {
			get {
				return _processAdministrativGridPageLoadComplete ?? (_processAdministrativGridPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProcessAdministrativGridPageLoadComplete",
					SchemaElementUId = new Guid("5218a0a1-a898-44af-8c7a-2e97e60b5a18"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAdministrativePageLoadComplete;
		public ProcessFlowElement StartMessageAdministrativePageLoadComplete {
			get {
				return _startMessageAdministrativePageLoadComplete ?? (_startMessageAdministrativePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAdministrativePageLoadComplete",
					SchemaElementUId = new Guid("606f4c70-820b-4e18-a918-1463556c0bc3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAdministrativGridPageLoadComplete;
		public ProcessScriptTask ScriptAdministrativGridPageLoadComplete {
			get {
				return _scriptAdministrativGridPageLoadComplete ?? (_scriptAdministrativGridPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAdministrativGridPageLoadComplete",
					SchemaElementUId = new Guid("07d0b10e-ee24-4bdb-9689-12edb64c69fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAdministrativGridPageLoadCompleteExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBasePageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowBasePageLoadComplete {
			get {
				return _intermediateThrowBasePageLoadComplete ?? (_intermediateThrowBasePageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBasePageLoadComplete",
					SchemaElementUId = new Guid("90339c0d-748a-4f18-b09d-73b558ca8da4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcessAdministrativeGridDeleteButtonClick;
		public ProcessFlowElement SubProcessAdministrativeGridDeleteButtonClick {
			get {
				return _subProcessAdministrativeGridDeleteButtonClick ?? (_subProcessAdministrativeGridDeleteButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessAdministrativeGridDeleteButtonClick",
					SchemaElementUId = new Guid("88ae7864-7888-4aaa-b0c8-6451b9677b8b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAdministrativeGridDeleteButtonClick;
		public ProcessScriptTask ScriptAdministrativeGridDeleteButtonClick {
			get {
				return _scriptAdministrativeGridDeleteButtonClick ?? (_scriptAdministrativeGridDeleteButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAdministrativeGridDeleteButtonClick",
					SchemaElementUId = new Guid("ee4a2b3c-9de0-4801-9c2f-6d36d5b4c2e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAdministrativeGridDeleteButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _startAdministrativeGridDeleteButtonClick;
		public ProcessFlowElement StartAdministrativeGridDeleteButtonClick {
			get {
				return _startAdministrativeGridDeleteButtonClick ?? (_startAdministrativeGridDeleteButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartAdministrativeGridDeleteButtonClick",
					SchemaElementUId = new Guid("2b0ea09e-5e94-4d46-8998-0c8c9274f8dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _processAdministrativeGridRefreshRow;
		public ProcessFlowElement ProcessAdministrativeGridRefreshRow {
			get {
				return _processAdministrativeGridRefreshRow ?? (_processAdministrativeGridRefreshRow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProcessAdministrativeGridRefreshRow",
					SchemaElementUId = new Guid("808a9977-00e7-4724-9749-6e6b99fbcad7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAdministrativeGridRefreshRow;
		public ProcessFlowElement StartMessageAdministrativeGridRefreshRow {
			get {
				return _startMessageAdministrativeGridRefreshRow ?? (_startMessageAdministrativeGridRefreshRow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAdministrativeGridRefreshRow",
					SchemaElementUId = new Guid("f1b61080-8d98-4bda-bcf7-706ee2f8ed81"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAdministartiveGridRefreshRow;
		public ProcessScriptTask ScriptAdministartiveGridRefreshRow {
			get {
				return _scriptAdministartiveGridRefreshRow ?? (_scriptAdministartiveGridRefreshRow = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAdministartiveGridRefreshRow",
					SchemaElementUId = new Guid("b0a07bb4-8293-493a-82f2-28d6227dbbc2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAdministartiveGridRefreshRowExecute,
				});
			}
		}

		private ProcessFlowElement _processAdministrativeGridSelectionChange;
		public ProcessFlowElement ProcessAdministrativeGridSelectionChange {
			get {
				return _processAdministrativeGridSelectionChange ?? (_processAdministrativeGridSelectionChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProcessAdministrativeGridSelectionChange",
					SchemaElementUId = new Guid("4e480294-effc-45b8-bf28-c7a91bf2ad17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAdministrativeGridSelectionChange;
		public ProcessFlowElement StartMessageAdministrativeGridSelectionChange {
			get {
				return _startMessageAdministrativeGridSelectionChange ?? (_startMessageAdministrativeGridSelectionChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAdministrativeGridSelectionChange",
					SchemaElementUId = new Guid("0d76a44c-47cd-43a5-81df-7233f8bbebb8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAdministrativeGridSelectionChange;
		public ProcessScriptTask ScriptAdministrativeGridSelectionChange {
			get {
				return _scriptAdministrativeGridSelectionChange ?? (_scriptAdministrativeGridSelectionChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAdministrativeGridSelectionChange",
					SchemaElementUId = new Guid("4af6ec58-c89b-4b38-b5af-d17f6ac262bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAdministrativeGridSelectionChangeExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBaseSelectionChange;
		public ProcessThrowMessageEvent IntermediateThrowBaseSelectionChange {
			get {
				return _intermediateThrowBaseSelectionChange ?? (_intermediateThrowBaseSelectionChange = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBaseSelectionChange",
					SchemaElementUId = new Guid("2c0381a2-13ee-49ca-8942-a23477b8374a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceActiveRowChanged",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcess_ShowRelatedRightsCheckBoxCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess_ShowRelatedRightsCheckBoxCheck };
			FlowElements[ShowRelatedRightsCheckBoxCheckMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowRelatedRightsCheckBoxCheckMessage };
			FlowElements[ThrowGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowGridPageRefreshRow };
			FlowElements[SubProcess_Init.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess_Init };
			FlowElements[InitMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMessage };
			FlowElements[ScriptInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInit };
			FlowElements[IntermediateThrowBaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBaseInit };
			FlowElements[SubProcessSelectingEntitySchemaForAddRights.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSelectingEntitySchemaForAddRights };
			FlowElements[Message_OpenVwSysSchemaInSolution.SchemaElementUId] = new Collection<ProcessFlowElement> { Message_OpenVwSysSchemaInSolution };
			FlowElements[InitOpenLookupUserTaskScript.SchemaElementUId] = new Collection<ProcessFlowElement> { InitOpenLookupUserTaskScript };
			FlowElements[OpenLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTask };
			FlowElements[CatchMessage_LookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { CatchMessage_LookupGridPageClosed };
			FlowElements[ApplyDataScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyDataScript };
			FlowElements[EventBasedGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventBasedGateway1 };
			FlowElements[IntermediateCatchMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEvent1 };
			FlowElements[SubProcess_AddEntitySchemaRight.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess_AddEntitySchemaRight };
			FlowElements[Message_SelectSchemaForAddRights.SchemaElementUId] = new Collection<ProcessFlowElement> { Message_SelectSchemaForAddRights };
			FlowElements[ScriptSelectSchemaForAddRights.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSelectSchemaForAddRights };
			FlowElements[SubProcessPositionButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessPositionButtonClick };
			FlowElements[StartMessageDownButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDownButtonClick };
			FlowElements[ScriptDownButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDownButtonClick };
			FlowElements[IntermediateThrowMessageGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageGridPageRefreshRow };
			FlowElements[StartMessageUpButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageUpButtonClick };
			FlowElements[ScriptUpButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptUpButtonClick };
			FlowElements[SubProcessOwnMenuItemCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessOwnMenuItemCheckChange };
			FlowElements[OwnMenuItemCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { OwnMenuItemCheckChange };
			FlowElements[OwnMenuItemOwnMenuItem.SchemaElementUId] = new Collection<ProcessFlowElement> { OwnMenuItemOwnMenuItem };
			FlowElements[ScriptOwnMenuItemCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOwnMenuItemCheckChange };
			FlowElements[SubProcessAllMenuItemCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessAllMenuItemCheckChange };
			FlowElements[AllMenuItemCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { AllMenuItemCheckChange };
			FlowElements[AllMenuItemGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { AllMenuItemGridPageRefreshRow };
			FlowElements[ScriptAllMenuItemCheckChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAllMenuItemCheckChange };
			FlowElements[ProcessAdministrativGridPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessAdministrativGridPageLoadComplete };
			FlowElements[StartMessageAdministrativePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAdministrativePageLoadComplete };
			FlowElements[ScriptAdministrativGridPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAdministrativGridPageLoadComplete };
			FlowElements[IntermediateThrowBasePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBasePageLoadComplete };
			FlowElements[SubProcessAdministrativeGridDeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessAdministrativeGridDeleteButtonClick };
			FlowElements[ScriptAdministrativeGridDeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAdministrativeGridDeleteButtonClick };
			FlowElements[StartAdministrativeGridDeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartAdministrativeGridDeleteButtonClick };
			FlowElements[ProcessAdministrativeGridRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessAdministrativeGridRefreshRow };
			FlowElements[StartMessageAdministrativeGridRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAdministrativeGridRefreshRow };
			FlowElements[ScriptAdministartiveGridRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAdministartiveGridRefreshRow };
			FlowElements[ProcessAdministrativeGridSelectionChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessAdministrativeGridSelectionChange };
			FlowElements[StartMessageAdministrativeGridSelectionChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAdministrativeGridSelectionChange };
			FlowElements[ScriptAdministrativeGridSelectionChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAdministrativeGridSelectionChange };
			FlowElements[IntermediateThrowBaseSelectionChange.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBaseSelectionChange };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess_ShowRelatedRightsCheckBoxCheck":
						break;
					case "ShowRelatedRightsCheckBoxCheckMessage":
						e.Context.QueueTasks.Enqueue("ThrowGridPageRefreshRow");
						break;
					case "ThrowGridPageRefreshRow":
						break;
					case "SubProcess_Init":
						break;
					case "InitMessage":
						e.Context.QueueTasks.Enqueue("ScriptInit");
						break;
					case "ScriptInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBaseInit");
						break;
					case "IntermediateThrowBaseInit":
						break;
					case "SubProcessSelectingEntitySchemaForAddRights":
						break;
					case "Message_OpenVwSysSchemaInSolution":
						e.Context.QueueTasks.Enqueue("InitOpenLookupUserTaskScript");
						break;
					case "InitOpenLookupUserTaskScript":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTask");
						break;
					case "OpenLookupUserTask":
							e.Context.QueueTasks.Enqueue("EventBasedGateway1");
						break;
					case "CatchMessage_LookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("ApplyDataScript");
						break;
					case "ApplyDataScript":
						break;
					case "EventBasedGateway1":
						if (!ActivatedEventElements.Contains("EventBasedGateway1")) {
							ActivatedEventElements.Add("EventBasedGateway1");
						}
						break;
					case "IntermediateCatchMessageEvent1":
						break;
					case "SubProcess_AddEntitySchemaRight":
						break;
					case "Message_SelectSchemaForAddRights":
						e.Context.QueueTasks.Enqueue("ScriptSelectSchemaForAddRights");
						break;
					case "ScriptSelectSchemaForAddRights":
						break;
					case "SubProcessPositionButtonClick":
						break;
					case "StartMessageDownButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptDownButtonClick");
						break;
					case "ScriptDownButtonClick":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageGridPageRefreshRow");
						break;
					case "IntermediateThrowMessageGridPageRefreshRow":
						break;
					case "StartMessageUpButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptUpButtonClick");
						break;
					case "ScriptUpButtonClick":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageGridPageRefreshRow");
						break;
					case "SubProcessOwnMenuItemCheckChange":
						break;
					case "OwnMenuItemCheckChange":
						e.Context.QueueTasks.Enqueue("ScriptOwnMenuItemCheckChange");
						break;
					case "OwnMenuItemOwnMenuItem":
						break;
					case "ScriptOwnMenuItemCheckChange":
						e.Context.QueueTasks.Enqueue("OwnMenuItemOwnMenuItem");
						break;
					case "SubProcessAllMenuItemCheckChange":
						break;
					case "AllMenuItemCheckChange":
						e.Context.QueueTasks.Enqueue("ScriptAllMenuItemCheckChange");
						break;
					case "AllMenuItemGridPageRefreshRow":
						break;
					case "ScriptAllMenuItemCheckChange":
						e.Context.QueueTasks.Enqueue("AllMenuItemGridPageRefreshRow");
						break;
					case "ProcessAdministrativGridPageLoadComplete":
						break;
					case "StartMessageAdministrativePageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptAdministrativGridPageLoadComplete");
						break;
					case "ScriptAdministrativGridPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBasePageLoadComplete");
						break;
					case "IntermediateThrowBasePageLoadComplete":
						break;
					case "SubProcessAdministrativeGridDeleteButtonClick":
						break;
					case "ScriptAdministrativeGridDeleteButtonClick":
						break;
					case "StartAdministrativeGridDeleteButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptAdministrativeGridDeleteButtonClick");
						break;
					case "ProcessAdministrativeGridRefreshRow":
						break;
					case "StartMessageAdministrativeGridRefreshRow":
						e.Context.QueueTasks.Enqueue("ScriptAdministartiveGridRefreshRow");
						break;
					case "ScriptAdministartiveGridRefreshRow":
						break;
					case "ProcessAdministrativeGridSelectionChange":
						break;
					case "StartMessageAdministrativeGridSelectionChange":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBaseSelectionChange");
						break;
					case "ScriptAdministrativeGridSelectionChange":
						break;
					case "IntermediateThrowBaseSelectionChange":
						e.Context.QueueTasks.Enqueue("ScriptAdministrativeGridSelectionChange");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ShowRelatedRightsCheckBoxCheckMessage");
			ActivatedEventElements.Add("InitMessage");
			ActivatedEventElements.Add("Message_OpenVwSysSchemaInSolution");
			ActivatedEventElements.Add("Message_SelectSchemaForAddRights");
			ActivatedEventElements.Add("StartMessageDownButtonClick");
			ActivatedEventElements.Add("StartMessageUpButtonClick");
			ActivatedEventElements.Add("OwnMenuItemCheckChange");
			ActivatedEventElements.Add("AllMenuItemCheckChange");
			ActivatedEventElements.Add("StartMessageAdministrativePageLoadComplete");
			ActivatedEventElements.Add("StartAdministrativeGridDeleteButtonClick");
			ActivatedEventElements.Add("StartMessageAdministrativeGridRefreshRow");
			ActivatedEventElements.Add("StartMessageAdministrativeGridSelectionChange");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess_ShowRelatedRightsCheckBoxCheck":
					context.QueueTasks.Dequeue();
					break;
				case "ShowRelatedRightsCheckBoxCheckMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowRelatedRightsCheckBoxCheckMessage";
					result = ShowRelatedRightsCheckBoxCheckMessage.Execute(context);
					break;
				case "ThrowGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					result = ThrowGridPageRefreshRow.Execute(context);
					break;
				case "SubProcess_Init":
					context.QueueTasks.Dequeue();
					break;
				case "InitMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitMessage";
					result = InitMessage.Execute(context);
					break;
				case "ScriptInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInit";
					result = ScriptInit.Execute(context, ScriptInitExecute);
					break;
				case "IntermediateThrowBaseInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "BaseAdministrativeGrid");
					result = IntermediateThrowBaseInit.Execute(context);
					break;
				case "SubProcessSelectingEntitySchemaForAddRights":
					context.QueueTasks.Dequeue();
					break;
				case "Message_OpenVwSysSchemaInSolution":
					context.QueueTasks.Dequeue();
					context.SenderName = "Message_OpenVwSysSchemaInSolution";
					result = Message_OpenVwSysSchemaInSolution.Execute(context);
					break;
				case "InitOpenLookupUserTaskScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitOpenLookupUserTaskScript";
					result = InitOpenLookupUserTaskScript.Execute(context, InitOpenLookupUserTaskScriptExecute);
					break;
				case "OpenLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTask";
					result = OpenLookupUserTask.Execute(context);
					break;
				case "CatchMessage_LookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "CatchMessage_LookupGridPageClosed";
					result = CatchMessage_LookupGridPageClosed.Execute(context);
					break;
				case "ApplyDataScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyDataScript";
					result = ApplyDataScript.Execute(context, ApplyDataScriptExecute);
					break;
				case "EventBasedGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "EventBasedGateway1";
					result = EventBasedGateway1.Execute(context);
					break;
				case "IntermediateCatchMessageEvent1":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEvent1";
					result = IntermediateCatchMessageEvent1.Execute(context);
					break;
				case "SubProcess_AddEntitySchemaRight":
					context.QueueTasks.Dequeue();
					break;
				case "Message_SelectSchemaForAddRights":
					context.QueueTasks.Dequeue();
					context.SenderName = "Message_SelectSchemaForAddRights";
					result = Message_SelectSchemaForAddRights.Execute(context);
					break;
				case "ScriptSelectSchemaForAddRights":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSelectSchemaForAddRights";
					result = ScriptSelectSchemaForAddRights.Execute(context, ScriptSelectSchemaForAddRightsExecute);
					break;
				case "SubProcessPositionButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDownButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDownButtonClick";
					result = StartMessageDownButtonClick.Execute(context);
					break;
				case "ScriptDownButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDownButtonClick";
					result = ScriptDownButtonClick.Execute(context, ScriptDownButtonClickExecute);
					break;
				case "IntermediateThrowMessageGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageGridPageRefreshRow.Execute(context);
					break;
				case "StartMessageUpButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageUpButtonClick";
					result = StartMessageUpButtonClick.Execute(context);
					break;
				case "ScriptUpButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptUpButtonClick";
					result = ScriptUpButtonClick.Execute(context, ScriptUpButtonClickExecute);
					break;
				case "SubProcessOwnMenuItemCheckChange":
					context.QueueTasks.Dequeue();
					break;
				case "OwnMenuItemCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "OwnMenuItemCheckChange";
					result = OwnMenuItemCheckChange.Execute(context);
					break;
				case "OwnMenuItemOwnMenuItem":
					context.QueueTasks.Dequeue();
					result = OwnMenuItemOwnMenuItem.Execute(context);
					break;
				case "ScriptOwnMenuItemCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOwnMenuItemCheckChange";
					result = ScriptOwnMenuItemCheckChange.Execute(context, ScriptOwnMenuItemCheckChangeExecute);
					break;
				case "SubProcessAllMenuItemCheckChange":
					context.QueueTasks.Dequeue();
					break;
				case "AllMenuItemCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "AllMenuItemCheckChange";
					result = AllMenuItemCheckChange.Execute(context);
					break;
				case "AllMenuItemGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					result = AllMenuItemGridPageRefreshRow.Execute(context);
					break;
				case "ScriptAllMenuItemCheckChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAllMenuItemCheckChange";
					result = ScriptAllMenuItemCheckChange.Execute(context, ScriptAllMenuItemCheckChangeExecute);
					break;
				case "ProcessAdministrativGridPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAdministrativePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAdministrativePageLoadComplete";
					result = StartMessageAdministrativePageLoadComplete.Execute(context);
					break;
				case "ScriptAdministrativGridPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAdministrativGridPageLoadComplete";
					result = ScriptAdministrativGridPageLoadComplete.Execute(context, ScriptAdministrativGridPageLoadCompleteExecute);
					break;
				case "IntermediateThrowBasePageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowBasePageLoadComplete.Execute(context);
					break;
				case "SubProcessAdministrativeGridDeleteButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptAdministrativeGridDeleteButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAdministrativeGridDeleteButtonClick";
					result = ScriptAdministrativeGridDeleteButtonClick.Execute(context, ScriptAdministrativeGridDeleteButtonClickExecute);
					break;
				case "StartAdministrativeGridDeleteButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartAdministrativeGridDeleteButtonClick";
					result = StartAdministrativeGridDeleteButtonClick.Execute(context);
					break;
				case "ProcessAdministrativeGridRefreshRow":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAdministrativeGridRefreshRow":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAdministrativeGridRefreshRow";
					result = StartMessageAdministrativeGridRefreshRow.Execute(context);
					break;
				case "ScriptAdministartiveGridRefreshRow":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAdministartiveGridRefreshRow";
					result = ScriptAdministartiveGridRefreshRow.Execute(context, ScriptAdministartiveGridRefreshRowExecute);
					break;
				case "ProcessAdministrativeGridSelectionChange":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAdministrativeGridSelectionChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAdministrativeGridSelectionChange";
					result = StartMessageAdministrativeGridSelectionChange.Execute(context);
					break;
				case "ScriptAdministrativeGridSelectionChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAdministrativeGridSelectionChange";
					result = ScriptAdministrativeGridSelectionChange.Execute(context, ScriptAdministrativeGridSelectionChangeExecute);
					break;
				case "IntermediateThrowBaseSelectionChange":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceActiveRowChanged");
					result = IntermediateThrowBaseSelectionChange.Execute(context);
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
				case "ShowRightsBySubject":
					ShowRightsBySubject = reader.GetValue<System.Boolean>();
				break;
				case "SelectParameters":
					SelectParameters = reader.GetSerializableObjectValue();
				break;
				case "RightsGrouppingColumnNames":
					RightsGrouppingColumnNames = reader.GetValue<System.String>();
				break;
				case "RightsSchemaName":
					RightsSchemaName = reader.GetValue<System.String>();
				break;
				case "RowsCount":
					RowsCount = reader.GetValue<System.Int32>();
				break;
				case "OperationRightCode":
					OperationRightCode = reader.GetValue<System.String>();
				break;
				case "SelectedSchemaUIdForAddRights":
					SelectedSchemaUIdForAddRights = reader.GetValue<System.Guid>();
				break;
				case "VirtualDataSourceID":
					VirtualDataSourceID = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptInitExecute(ProcessExecutingContext context) {
			var virtualDataSource = new VirtualDataSource() {
				ID = VirtualDataSourceID
			};
			Page.AddButton.AjaxEvents.Click.SignalName = "OpenVwSysSchemaInSolution";
			virtualDataSource.AjaxEvents.Saved.Event += DataSource_Saved;
			virtualDataSource.AjaxEvents.Saved.ExtraParameters.Add(new Terrasoft.UI.WebControls.Controls.Parameter("request", "request", Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			Page.PageContainer.Controls.Add(virtualDataSource);
			var dataSource = Page.DataSource;
			var schema = dataSource.Schema;
			Page.TreeGrid.DataSourceId = virtualDataSource.ID; 
			DataSourceStructure defStructure = virtualDataSource.DefStructure;
			defStructure.Columns.Clear();
			defStructure.PrimaryColumnName = schema.PrimaryColumn.Name;
			if (schema.PrimaryDisplayColumn != null) {
				defStructure.PrimaryDisplayColumnName = schema.PrimaryDisplayColumn.Name;
			}
			var dataValueTypeManager = (DataValueTypeManager)
				Page.UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
			CreateVirtualDataSourceStructure(dataValueTypeManager, defStructure);
			if (!IsContextHelpButtonInitialized) {
				InitializeContextHelpButton();
				IsContextHelpButtonInitialized = true;
			}
			return true;
		}

		public virtual bool InitOpenLookupUserTaskScriptExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			//#/if IS_WORKSPACE
			//Код, который компилируется только в Workspace CR173850
			string schemaUId = ShowRightsBySubject ? "d5d01fcd-6d8c-4b29-9e58-cca3ffe62364" : "4FE60977-C711-48B2-8499-1CEBBECF7868";
			//#/endif
			OpenLookupUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)OpenLookupUserTask.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			if (!ShowRightsBySubject) {
				Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
				//#/if IS_WORKSPACE
				// TODO CR#172069
				filters.Add(new Dictionary<string, object> { 
					 {"comparisonType", FilterComparisonType.Equal},
					 {"leftExpressionColumnPath", "SysWorkspace"},
					 {"useDisplayValue", false }, 
					 {"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}
				});
				filters.Add(new Dictionary<string, object> { 
					 {"comparisonType", FilterComparisonType.Equal},
					 {"leftExpressionColumnPath", "ManagerName"},
					 {"useDisplayValue", false }, 
					 {"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}});
				//#/endif
				pageParameters.Add("LookupFilters", filters);
			}
			
			return true;
		}

		public virtual bool ApplyDataScriptExecute(ProcessExecutingContext context) {
			var values = (Dictionary <string, object>)OpenLookupUserTask.GetSelectedValues(UserConnection);
			Guid selectedId = Guid.Empty;
			foreach (var valueItem in values) {
				selectedId = new Guid(valueItem.Key);
			}
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			string key = instanceId + Page.PageContainer.UniqueID;
			if (selectedId.IsEmpty()) {
				return true;
			}
			//Код, который компилируется только в Workspace CR173850 
			var sysSchemaInWorkspace = new Terrasoft.Core.Configuration.VwSysSchemaInWorkspaceSchema(Page.UserConnection.EntitySchemaManager).CreateEntity(Page.UserConnection);
			if (!sysSchemaInWorkspace.FetchFromDB(selectedId)) {
				return true;
			}
			SelectedSchemaUIdForAddRights = sysSchemaInWorkspace.GetTypedColumnValue<Guid>("UId");
			
			ThrowEvent(context, "SelectSchemaForAddRights");
			return true;
		}

		public virtual bool ScriptSelectSchemaForAddRightsExecute(ProcessExecutingContext context) {
			if (SelectedNodePrimaryColumnValue.IsEmpty() || SelectedSchemaUIdForAddRights.IsEmpty()) {
				return true;
			}
			/*var schema = Page.DataSource.Schema;
			var entity = schema.CreateEntity(Page.UserConnection);
			var selectedSchema = Page.UserConnection.EntitySchemaManager.GetInstanceByUId(SelectedSchemaUIdForAddRights);*/
			return true;
		}

		public virtual bool ScriptDownButtonClickExecute(ProcessExecutingContext context) {
			if (Page.TreeGrid.SelectedNodes.Count == 0) {
				return true;
			}
			var selectedNode = Page.TreeGrid.SelectedNodes[0];
			var id = new Guid(selectedNode.Values["Id"].ToString());
			var position = Convert.ToInt32(selectedNode.Values["Position"]) + 1;
			var sysSchemaId = new Guid(selectedNode.Values["SysSchemaId"].ToString());
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			string subjectSchemaName = entitySchemaManager.GetItemByUId(sysSchemaId).Name;
			ChangeRightItemPosition(id, position, true, subjectSchemaName);
			return true;
		}

		public virtual bool ScriptUpButtonClickExecute(ProcessExecutingContext context) {
			if (Page.TreeGrid.SelectedNodes.Count == 0) {
				return true;
			}
			var selectedNode = Page.TreeGrid.SelectedNodes[0];
			var id = new Guid(selectedNode.Values["Id"].ToString());
			var position = Convert.ToInt32(selectedNode.Values["Position"]) - 1;
			if (position < 0) {
				return true;
			}
			var sysSchemaId = new Guid(selectedNode.Values["SysSchemaId"].ToString());
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			string subjectSchemaName = entitySchemaManager.GetItemByUId(sysSchemaId).Name;
			ChangeRightItemPosition(id, position, false, subjectSchemaName);
			return true;
		}

		public virtual bool ScriptOwnMenuItemCheckChangeExecute(ProcessExecutingContext context) {
			Page.AllMenuItem.Checked = false;
			return true;
		}

		public virtual bool ScriptAllMenuItemCheckChangeExecute(ProcessExecutingContext context) {
			Page.OwnMenuItem.Checked = false;
			return true;
		}

		public virtual bool ScriptAdministrativGridPageLoadCompleteExecute(ProcessExecutingContext context) {
			//Page.AddButton.Enabled = Page.DeleteButton.Enabled = HasRightsForChange();
			//Page.AddButton.AjaxEvents.Click.SignalName = "OpenVwSysSchemaInSolution";
			Page.OwnMenuItem.Checked = true;
			return true;
		}

		public virtual bool ScriptAdministrativeGridDeleteButtonClickExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count == 1) {
				var primaryRecordValue = selectedNodes[0].Values[Page.DataSource.Schema.PrimaryColumn.Name].ToString();
				var virtualDataSource = GetVirtualDataSource();
				virtualDataSource.Remove(new Guid(primaryRecordValue));
				var sel = GetSelectForVirtualDataSource(null);
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (var reader = sel.ExecuteReader(dbExecutor)) {
						if (reader.Read()) {
							if (reader.Read()) {
								EnableButtons(2);
							} else {
								EnableButtons(1);
							}
						} else {
							EnableButtons(0);
						}
					}
				}
			}
			return true;
		}

		public virtual bool ScriptAdministartiveGridRefreshRowExecute(ProcessExecutingContext context) {
			var virtualDataSource = GetVirtualDataSource();
			Collection<Guid> adminUnitCollection = new Collection<Guid>();
			Guid filterColumnValue = SelectedNodePrimaryColumnValue;
			if (Page.AllMenuItem.Checked) {
				if(!filterColumnValue.IsEmpty()) {
					adminUnitCollection = Page.UserConnection.DBSecurityEngine.GetUserAdminUnitCollection(filterColumnValue);
				}
			} else {
				adminUnitCollection.Add(filterColumnValue);
			}
			var objectParameters = new object[adminUnitCollection.Count];
			for (int i = 0; i < adminUnitCollection.Count; i++) {
				objectParameters[i] = adminUnitCollection[i];
			}
			Page.TreeGrid.Clear();
			virtualDataSource.Clear();
			SelectParameters = objectParameters;
			FillVirtualDataSource(virtualDataSource, objectParameters);
			virtualDataSource.LoadRows();
			RowsCount = virtualDataSource.Rows.Count;
			var buttons = GetButtons();
			foreach(var control in Page.ButtonsControlLayout.Controls) {
				var button = control as Terrasoft.UI.WebControls.Controls.Button;
				if (button != null && string.CompareOrdinal(button.Name, "ContextHelpButton") != 0) {
					if (buttons.Contains(button.Name)) {
						switch (button.Name) {
							case "ShowRelatedRightsButton":
								button.Enabled = true;
							break;
							case "AddButton":
								button.Enabled = HasRightsForChange();
							break;
							default :
								button.Enabled = (RowsCount > 0)  && HasRightsForChange();
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
				return true;
			}
			return true;
		}

		public virtual bool ScriptAdministrativeGridSelectionChangeExecute(ProcessExecutingContext context) {
			/*if (Page.TreeGrid.SelectedNodes.Count == 0) {
				return true;
			}
			if (RowsCount > 1) {
				var selectedNode = Page.TreeGrid.SelectedNodes[0];
				if (!selectedNode.Values.ContainsKey("Position")) {
					Page.UpButton.Enabled = false;
					Page.DownButton.Enabled = false;
					return true;
				}
				var sysSchemaId = new Guid(selectedNode.Values["SysSchemaId"].ToString());
				var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
				string subjectSchemaName = entitySchemaManager.GetItemByUId(sysSchemaId).Name;
				int position = Convert.ToInt32(selectedNode.Values["Position"]);
				Page.UpButton.Enabled = CanChangeItemPosition(subjectSchemaName, true, position, selectedNode);
				Page.DownButton.Enabled = CanChangeItemPosition(subjectSchemaName, false, position, selectedNode);
			}*/
			return true;
		}

		public virtual void CreateVirtualDataSourceStructure(DataValueTypeManager dataValueTypeManager, DataSourceStructure defStructure) {
		}

		public virtual void DataSource_Saved(object sender, AjaxEventArgs e) {
		}

		public virtual VirtualDataSource GetVirtualDataSource() {
			return Page.PageContainer.FindPageControl(VirtualDataSourceID) as VirtualDataSource;
		}

		public virtual void FillVirtualDataSource(VirtualDataSource virtualDataSource, params object[] objectParameters) {
		}

		public virtual bool HasRightsForChange() {
			if (OperationRightCode == null || OperationRightCode.Equals(String.Empty)) {
				return true;
			}
			var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
			return dbSecurityEngine.GetCanExecuteOperation(OperationRightCode);
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = new System.Collections.Generic.List<string>();
			buttons.Add(Page.EditButton.Name);
			buttons.Add(Page.DeleteButton.Name);
			buttons.Add(Page.UpButton.Name);
			buttons.Add(Page.DownButton.Name);
			return buttons;
		}

		public virtual void ChangeRightItemPosition(Guid primaryColumnValue, int position, bool increasePosition, string subjectSchemaName) {
			if (string.IsNullOrEmpty(RightsSchemaName) || string.IsNullOrEmpty(RightsGrouppingColumnNames)) {
				return;
			}
			//position = DeterminePositionForMove(position, increasePosition, subjectSchemaName);
			StoredProcedure setRecordPositionProcedure = new StoredProcedure(Page.UserConnection, "tsp_SetRecordPosition")
				.WithParameter("TableName", RightsSchemaName)
				.WithParameter("PrimaryColumnName", "Id")
				.WithParameter("PrimaryColumnValue", primaryColumnValue)
				.WithParameter("GrouppingColumnNames", RightsGrouppingColumnNames)
				.WithParameter("Position", position) as StoredProcedure;
			setRecordPositionProcedure.PackageName = Page.UserConnection.DBEngine.SystemPackageName;
			setRecordPositionProcedure.Execute();
		}

		public virtual bool CanChangeItemPosition(string subjectName, bool upPosition, int itemPosition, TreeGridNode selectedNode) {
			var select = new Select(Page.UserConnection)
					.Column(Func.Count(RightsSchemaName, "Id"))
					.From(RightsSchemaName)
					.Where(RightsSchemaName, "SubjectSchemaName").IsEqual(Column.Parameter(subjectName)) as Select;
			if (!ShowRightsBySubject) {
				select.And(RightsSchemaName, "SysAdminUnitId").In(Column.Parameters((object[])SelectParameters));
			}
			if (upPosition) {
				select.And(RightsSchemaName, "Position").IsLess(Column.Parameter(itemPosition));
			} else {
				select.And(RightsSchemaName, "Position").IsGreater(Column.Parameter(itemPosition));
			}
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					if (reader.Read()) {
						return UserConnection.DBTypeConverter.DBValueToInt(reader[0]) > 0;
					}
				}
			}
			return false;
		}

		public virtual int DeterminePositionForMove(int sourcePosition, bool doIncreasePosition, string sourceSubjectName) {
			return 0;
		}

		public virtual Select GetSelectForVirtualDataSource(params object[] objectParameters) {
			return new Select(Page.UserConnection);
		}

		public virtual void EnableButtons(int recordsCount) {
			Page.DeleteButton.Enabled = (recordsCount > 0) && HasRightsForChange();
			Page.UpButton.Enabled = (recordsCount > 1) && HasRightsForChange();
			Page.DownButton.Enabled = (recordsCount > 1) && HasRightsForChange();
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterCopyPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ShowRelatedRightsCheckBoxCheck":
							if (ActivatedEventElements.Contains("ShowRelatedRightsCheckBoxCheckMessage")) {
							context.QueueTasks.Enqueue("ShowRelatedRightsCheckBoxCheckMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitMessage")) {
							context.QueueTasks.Enqueue("InitMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "OpenVwSysSchemaInSolution":
							if (ActivatedEventElements.Contains("Message_OpenVwSysSchemaInSolution")) {
							context.QueueTasks.Enqueue("Message_OpenVwSysSchemaInSolution");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("CatchMessage_LookupGridPageClosed")) {
						EventBasedGateway1.CancelNonexecutedEvents("CatchMessage_LookupGridPageClosed");
						context.QueueTasks.Enqueue("CatchMessage_LookupGridPageClosed");
					}
					break;
					case "Initialize":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEvent1")) {
						EventBasedGateway1.CancelNonexecutedEvents("IntermediateCatchMessageEvent1");
						context.QueueTasks.Enqueue("IntermediateCatchMessageEvent1");
					}
					break;
					case "SelectSchemaForAddRights":
							if (ActivatedEventElements.Contains("Message_SelectSchemaForAddRights")) {
							context.QueueTasks.Enqueue("Message_SelectSchemaForAddRights");
						}
						break;
					case "DownButtonClick":
							if (ActivatedEventElements.Contains("StartMessageDownButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageDownButtonClick");
						}
						break;
					case "UpButtonClick":
							if (ActivatedEventElements.Contains("StartMessageUpButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageUpButtonClick");
						}
						break;
					case "OwnMenuItemCheckChange":
							if (ActivatedEventElements.Contains("OwnMenuItemCheckChange")) {
							context.QueueTasks.Enqueue("OwnMenuItemCheckChange");
						}
						break;
					case "AllMenuItemCheckChange":
							if (ActivatedEventElements.Contains("AllMenuItemCheckChange")) {
							context.QueueTasks.Enqueue("AllMenuItemCheckChange");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageAdministrativePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageAdministrativePageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("StartAdministrativeGridDeleteButtonClick")) {
							context.QueueTasks.Enqueue("StartAdministrativeGridDeleteButtonClick");
							ProcessQueue(context);
							return;
						}
						break;
					case "GridPageRefreshRow":
							if (ActivatedEventElements.Contains("StartMessageAdministrativeGridRefreshRow")) {
							context.QueueTasks.Enqueue("StartMessageAdministrativeGridRefreshRow");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceActiveRowChanged":
							if (ActivatedEventElements.Contains("StartMessageAdministrativeGridSelectionChange")) {
							context.QueueTasks.Enqueue("StartMessageAdministrativeGridSelectionChange");
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
			if (!HasMapping("ShowRightsBySubject") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ShowRightsBySubject", ShowRightsBySubject, false);
			}
			if (SelectParameters != null) {
				if (SelectParameters.GetType().IsSerializable ||
					SelectParameters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SelectParameters", SelectParameters, null);
				}
			}
			if (!HasMapping("RightsGrouppingColumnNames") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RightsGrouppingColumnNames", RightsGrouppingColumnNames, null);
			}
			if (!HasMapping("RightsSchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RightsSchemaName", RightsSchemaName, null);
			}
			if (!HasMapping("RowsCount") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RowsCount", RowsCount, 0);
			}
			if (!HasMapping("OperationRightCode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OperationRightCode", OperationRightCode, null);
			}
			if (!HasMapping("SelectedSchemaUIdForAddRights") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedSchemaUIdForAddRights", SelectedSchemaUIdForAddRights, Guid.Empty);
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

	#region Class: BaseAdministrativeGridPageEventsProcess

	/// <exclude/>
	public class BaseAdministrativeGridPageEventsProcess : BaseAdministrativeGridPageEventsProcess<Terrasoft.WebApp.BaseAdministrativeGridPageSchemaUserControl>
	{

		public BaseAdministrativeGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseAdministrativeGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseAdministrativeGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DownButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CheckBoxControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CheckBoxControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ShowRelatedRightsCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ShowRelatedRightsCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ShowRelatedRightsButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ShowRelatedRightsButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem OwnMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("OwnMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem AllMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("AllMenuItem", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			UpButton.AjaxEvents.Click.Event += UpButtonClick;
			DownButton.AjaxEvents.Click.Event += DownButtonClick;
			ShowRelatedRightsCheckBox.AjaxEvents.Check.Event += ShowRelatedRightsCheckBoxCheck;
			OwnMenuItem.AjaxEvents.CheckChange.Event += OwnMenuItemCheckChange;
			AllMenuItem.AjaxEvents.CheckChange.Event += AllMenuItemCheckChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			UpButton.AjaxEvents.Click.Event -= UpButtonClick;
			DownButton.AjaxEvents.Click.Event -= DownButtonClick;
			ShowRelatedRightsCheckBox.AjaxEvents.Check.Event -= ShowRelatedRightsCheckBoxCheck;
			OwnMenuItem.AjaxEvents.CheckChange.Event -= OwnMenuItemCheckChange;
			AllMenuItem.AjaxEvents.CheckChange.Event -= AllMenuItemCheckChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseAdministrativeGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseAdministrativeGridPageEventsProcess(UserConnection);
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

		public virtual void UpButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("UpButtonClick");
		}

		public virtual void DownButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownButtonClick");
		}

		public virtual void ShowRelatedRightsCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("ShowRelatedRightsCheckBoxCheck");
		}

		public virtual void OwnMenuItemCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("OwnMenuItemCheckChange");
		}

		public virtual void AllMenuItemCheckChange(object sender, EventArgs e) {
			object result = ThrowEvent("AllMenuItemCheckChange");
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
			SchemaName = "BaseAdministrativeGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseAdministrativeGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseAdministrativeGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseAdministrativeGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseAdministrativeGridPageEventsProcessSchema(BaseAdministrativeGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseAdministrativeGridPageEventsProcess";
			UId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateVirtualDataSourceIDParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5a80d711-cffd-4746-9aa8-e49c738af724"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"VirtualDataSourceID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedSchemaUIdForAddRightsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("70b9f49b-ef02-4283-9323-5f0be40f5fc0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SelectedSchemaUIdForAddRights",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOperationRightCodeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("785c3162-af95-4c0a-9227-a564b90d05d1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"OperationRightCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRowsCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("db8d4364-70a5-497d-964a-f77288838907"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"RowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRightsSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2a30cb9a-9348-4a1d-a690-54e8d86679b2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"RightsSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRightsGrouppingColumnNamesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4a17dfaf-996b-4a01-b68b-4b1c60b3780b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"RightsGrouppingColumnNames",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectParametersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f398e30-12df-4556-8563-904c4ee2395f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SelectParameters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateShowRightsBySubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("58ed9b8c-4a1f-4f29-bcfe-cdc78422f035"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ShowRightsBySubject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateVirtualDataSourceIDParameter());
			Parameters.Add(CreateSelectedSchemaUIdForAddRightsParameter());
			Parameters.Add(CreateOperationRightCodeParameter());
			Parameters.Add(CreateRowsCountParameter());
			Parameters.Add(CreateRightsSchemaNameParameter());
			Parameters.Add(CreateRightsGrouppingColumnNamesParameter());
			Parameters.Add(CreateSelectParametersParameter());
			Parameters.Add(CreateShowRightsBySubjectParameter());
		}

		protected virtual void InitializeOpenLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1151066a-cfdf-4fab-8ccb-3cc474d84dec"),
				ContainerUId = new Guid("a5425596-1e11-4375-949b-f3225640a939"),
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
				UId = new Guid("44cff625-f414-43ea-9dd9-f8c6920e8898"),
				ContainerUId = new Guid("a5425596-1e11-4375-949b-f3225640a939"),
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
				UId = new Guid("e04517f0-7474-45d8-98e3-0275af769e89"),
				ContainerUId = new Guid("a5425596-1e11-4375-949b-f3225640a939"),
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
				UId = new Guid("dc1190ac-72af-4e8d-a8ce-afc5efc6aa71"),
				ContainerUId = new Guid("a5425596-1e11-4375-949b-f3225640a939"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet425 = CreateLaneSet425LaneSet();
			LaneSets.Add(schemaLaneSet425);
			ProcessSchemaLane schemaLane1281 = CreateLane1281Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1281);
			ProcessSchemaLane schemaLane1282 = CreateLane1282Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1282);
			ProcessSchemaLane schemaLane1283 = CreateLane1283Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1283);
			ProcessSchemaLane schemaLane1284 = CreateLane1284Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1284);
			ProcessSchemaLane schemaLane1285 = CreateLane1285Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1285);
			ProcessSchemaLane schemaLane1286 = CreateLane1286Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1286);
			ProcessSchemaLane schemaLane1287 = CreateLane1287Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1287);
			ProcessSchemaLane schemaLane1288 = CreateLane1288Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1288);
			ProcessSchemaLane schemaLane1289 = CreateLane1289Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1289);
			ProcessSchemaLane schemaLane1290 = CreateLane1290Lane();
			schemaLaneSet425.Lanes.Add(schemaLane1290);
			ProcessSchemaEventSubProcess subprocess_showrelatedrightscheckboxcheck = CreateSubProcess_ShowRelatedRightsCheckBoxCheckEventSubProcess();
			FlowElements.Add(subprocess_showrelatedrightscheckboxcheck);
			ProcessSchemaEventSubProcess subprocess_init = CreateSubProcess_InitEventSubProcess();
			FlowElements.Add(subprocess_init);
			ProcessSchemaEventSubProcess subprocessselectingentityschemaforaddrights = CreateSubProcessSelectingEntitySchemaForAddRightsEventSubProcess();
			FlowElements.Add(subprocessselectingentityschemaforaddrights);
			ProcessSchemaEventSubProcess subprocess_addentityschemaright = CreateSubProcess_AddEntitySchemaRightEventSubProcess();
			FlowElements.Add(subprocess_addentityschemaright);
			ProcessSchemaEventSubProcess subprocesspositionbuttonclick = CreateSubProcessPositionButtonClickEventSubProcess();
			FlowElements.Add(subprocesspositionbuttonclick);
			ProcessSchemaEventSubProcess subprocessownmenuitemcheckchange = CreateSubProcessOwnMenuItemCheckChangeEventSubProcess();
			FlowElements.Add(subprocessownmenuitemcheckchange);
			ProcessSchemaEventSubProcess subprocessallmenuitemcheckchange = CreateSubProcessAllMenuItemCheckChangeEventSubProcess();
			FlowElements.Add(subprocessallmenuitemcheckchange);
			ProcessSchemaEventSubProcess processadministrativgridpageloadcomplete = CreateProcessAdministrativGridPageLoadCompleteEventSubProcess();
			FlowElements.Add(processadministrativgridpageloadcomplete);
			ProcessSchemaEventSubProcess subprocessadministrativegriddeletebuttonclick = CreateSubProcessAdministrativeGridDeleteButtonClickEventSubProcess();
			FlowElements.Add(subprocessadministrativegriddeletebuttonclick);
			ProcessSchemaEventSubProcess processadministrativegridrefreshrow = CreateProcessAdministrativeGridRefreshRowEventSubProcess();
			FlowElements.Add(processadministrativegridrefreshrow);
			ProcessSchemaEventSubProcess processadministrativegridselectionchange = CreateProcessAdministrativeGridSelectionChangeEventSubProcess();
			FlowElements.Add(processadministrativegridselectionchange);
			ProcessSchemaStartMessageEvent showrelatedrightscheckboxcheckmessage = CreateShowRelatedRightsCheckBoxCheckMessageStartMessageEvent();
			subprocess_showrelatedrightscheckboxcheck.FlowElements.Add(showrelatedrightscheckboxcheckmessage);
			ProcessSchemaIntermediateThrowMessageEvent throwgridpagerefreshrow = CreateThrowGridPageRefreshRowIntermediateThrowMessageEvent();
			subprocess_showrelatedrightscheckboxcheck.FlowElements.Add(throwgridpagerefreshrow);
			ProcessSchemaStartMessageEvent initmessage = CreateInitMessageStartMessageEvent();
			subprocess_init.FlowElements.Add(initmessage);
			ProcessSchemaScriptTask scriptinit = CreateScriptInitScriptTask();
			subprocess_init.FlowElements.Add(scriptinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbaseinit = CreateIntermediateThrowBaseInitIntermediateThrowMessageEvent();
			subprocess_init.FlowElements.Add(intermediatethrowbaseinit);
			ProcessSchemaStartMessageEvent message_openvwsysschemainsolution = CreateMessage_OpenVwSysSchemaInSolutionStartMessageEvent();
			subprocessselectingentityschemaforaddrights.FlowElements.Add(message_openvwsysschemainsolution);
			ProcessSchemaScriptTask initopenlookupusertaskscript = CreateInitOpenLookupUserTaskScriptScriptTask();
			subprocessselectingentityschemaforaddrights.FlowElements.Add(initopenlookupusertaskscript);
			ProcessSchemaUserTask openlookupusertask = CreateOpenLookupUserTaskUserTask();
			subprocessselectingentityschemaforaddrights.FlowElements.Add(openlookupusertask);
			ProcessSchemaIntermediateCatchMessageEvent catchmessage_lookupgridpageclosed = CreateCatchMessage_LookupGridPageClosedIntermediateCatchMessageEvent();
			subprocessselectingentityschemaforaddrights.FlowElements.Add(catchmessage_lookupgridpageclosed);
			ProcessSchemaScriptTask applydatascript = CreateApplyDataScriptScriptTask();
			subprocessselectingentityschemaforaddrights.FlowElements.Add(applydatascript);
			ProcessSchemaEventBasedGateway eventbasedgateway1 = CreateEventBasedGateway1EventBasedGateway();
			subprocessselectingentityschemaforaddrights.FlowElements.Add(eventbasedgateway1);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageevent1 = CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent();
			subprocessselectingentityschemaforaddrights.FlowElements.Add(intermediatecatchmessageevent1);
			ProcessSchemaStartMessageEvent message_selectschemaforaddrights = CreateMessage_SelectSchemaForAddRightsStartMessageEvent();
			subprocess_addentityschemaright.FlowElements.Add(message_selectschemaforaddrights);
			ProcessSchemaScriptTask scriptselectschemaforaddrights = CreateScriptSelectSchemaForAddRightsScriptTask();
			subprocess_addentityschemaright.FlowElements.Add(scriptselectschemaforaddrights);
			ProcessSchemaStartMessageEvent startmessagedownbuttonclick = CreateStartMessageDownButtonClickStartMessageEvent();
			subprocesspositionbuttonclick.FlowElements.Add(startmessagedownbuttonclick);
			ProcessSchemaScriptTask scriptdownbuttonclick = CreateScriptDownButtonClickScriptTask();
			subprocesspositionbuttonclick.FlowElements.Add(scriptdownbuttonclick);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessagegridpagerefreshrow = CreateIntermediateThrowMessageGridPageRefreshRowIntermediateThrowMessageEvent();
			subprocesspositionbuttonclick.FlowElements.Add(intermediatethrowmessagegridpagerefreshrow);
			ProcessSchemaStartMessageEvent startmessageupbuttonclick = CreateStartMessageUpButtonClickStartMessageEvent();
			subprocesspositionbuttonclick.FlowElements.Add(startmessageupbuttonclick);
			ProcessSchemaScriptTask scriptupbuttonclick = CreateScriptUpButtonClickScriptTask();
			subprocesspositionbuttonclick.FlowElements.Add(scriptupbuttonclick);
			ProcessSchemaStartMessageEvent ownmenuitemcheckchange = CreateOwnMenuItemCheckChangeStartMessageEvent();
			subprocessownmenuitemcheckchange.FlowElements.Add(ownmenuitemcheckchange);
			ProcessSchemaIntermediateThrowMessageEvent ownmenuitemownmenuitem = CreateOwnMenuItemOwnMenuItemIntermediateThrowMessageEvent();
			subprocessownmenuitemcheckchange.FlowElements.Add(ownmenuitemownmenuitem);
			ProcessSchemaScriptTask scriptownmenuitemcheckchange = CreateScriptOwnMenuItemCheckChangeScriptTask();
			subprocessownmenuitemcheckchange.FlowElements.Add(scriptownmenuitemcheckchange);
			ProcessSchemaStartMessageEvent allmenuitemcheckchange = CreateAllMenuItemCheckChangeStartMessageEvent();
			subprocessallmenuitemcheckchange.FlowElements.Add(allmenuitemcheckchange);
			ProcessSchemaIntermediateThrowMessageEvent allmenuitemgridpagerefreshrow = CreateAllMenuItemGridPageRefreshRowIntermediateThrowMessageEvent();
			subprocessallmenuitemcheckchange.FlowElements.Add(allmenuitemgridpagerefreshrow);
			ProcessSchemaScriptTask scriptallmenuitemcheckchange = CreateScriptAllMenuItemCheckChangeScriptTask();
			subprocessallmenuitemcheckchange.FlowElements.Add(scriptallmenuitemcheckchange);
			ProcessSchemaStartMessageEvent startmessageadministrativepageloadcomplete = CreateStartMessageAdministrativePageLoadCompleteStartMessageEvent();
			processadministrativgridpageloadcomplete.FlowElements.Add(startmessageadministrativepageloadcomplete);
			ProcessSchemaScriptTask scriptadministrativgridpageloadcomplete = CreateScriptAdministrativGridPageLoadCompleteScriptTask();
			processadministrativgridpageloadcomplete.FlowElements.Add(scriptadministrativgridpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasepageloadcomplete = CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent();
			processadministrativgridpageloadcomplete.FlowElements.Add(intermediatethrowbasepageloadcomplete);
			ProcessSchemaScriptTask scriptadministrativegriddeletebuttonclick = CreateScriptAdministrativeGridDeleteButtonClickScriptTask();
			subprocessadministrativegriddeletebuttonclick.FlowElements.Add(scriptadministrativegriddeletebuttonclick);
			ProcessSchemaStartMessageEvent startadministrativegriddeletebuttonclick = CreateStartAdministrativeGridDeleteButtonClickStartMessageEvent();
			subprocessadministrativegriddeletebuttonclick.FlowElements.Add(startadministrativegriddeletebuttonclick);
			ProcessSchemaStartMessageEvent startmessageadministrativegridrefreshrow = CreateStartMessageAdministrativeGridRefreshRowStartMessageEvent();
			processadministrativegridrefreshrow.FlowElements.Add(startmessageadministrativegridrefreshrow);
			ProcessSchemaScriptTask scriptadministartivegridrefreshrow = CreateScriptAdministartiveGridRefreshRowScriptTask();
			processadministrativegridrefreshrow.FlowElements.Add(scriptadministartivegridrefreshrow);
			ProcessSchemaStartMessageEvent startmessageadministrativegridselectionchange = CreateStartMessageAdministrativeGridSelectionChangeStartMessageEvent();
			processadministrativegridselectionchange.FlowElements.Add(startmessageadministrativegridselectionchange);
			ProcessSchemaScriptTask scriptadministrativegridselectionchange = CreateScriptAdministrativeGridSelectionChangeScriptTask();
			processadministrativegridselectionchange.FlowElements.Add(scriptadministrativegridselectionchange);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbaseselectionchange = CreateIntermediateThrowBaseSelectionChangeIntermediateThrowMessageEvent();
			processadministrativegridselectionchange.FlowElements.Add(intermediatethrowbaseselectionchange);
			FlowElements.Add(CreateSequenceFlow7234SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7235SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7236SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7237SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7238SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7239SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7242SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7243SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7244SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7245SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7246SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7247SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7266SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7267SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7268SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7269SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7270SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7280SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7281SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7282SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7283SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7284SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7285SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7286SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7234SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7234",
				UId = new Guid("2ad51702-35ac-4a32-9a2f-6eec8e239a5a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a2c5e314-59c0-431c-b9e3-84f71bebf1d3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7ca807a-2179-4a7d-bc29-55a9a3b5b76e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7235SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7235",
				UId = new Guid("caad93db-90c9-450c-99bd-3aff132f56a0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c3394be-25d1-46b8-a435-988dbbbff0e5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ecf4a4f1-426d-47e3-b6ef-0b00ce5e673b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7236SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7236",
				UId = new Guid("c57068f9-8fe2-4676-b0d3-63f13465f858"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ecf4a4f1-426d-47e3-b6ef-0b00ce5e673b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5425596-1e11-4375-949b-f3225640a939"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7237SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7237",
				UId = new Guid("95fd0a65-cb71-480a-9a88-90fe64cda762"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(518, 177),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("111f5cf3-2bcf-4ca0-8a33-b3200ee96179"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("12084bd3-aca9-4b3b-8669-db9c8bd3988a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7238SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7238",
				UId = new Guid("091901d3-3cd3-4f5a-b302-55b125b2a7c6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("12084bd3-aca9-4b3b-8669-db9c8bd3988a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4d0bc475-4133-45b7-bfa5-0bce554330ff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7239SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7239",
				UId = new Guid("8d432872-ab8c-4f14-987f-23fbb0ca642c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("62fdbefd-5512-4279-9a89-d1465dc1c715"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03ac8f45-0301-4ff5-96ac-05570dcfdff7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7242SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7242",
				UId = new Guid("1fc07113-ff5c-43d0-9672-abb131e6afaf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(518, 177),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a5425596-1e11-4375-949b-f3225640a939"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("111f5cf3-2bcf-4ca0-8a33-b3200ee96179"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7243SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7243",
				UId = new Guid("9054688c-a328-42f0-be46-3e1b60f3bb73"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(492, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("111f5cf3-2bcf-4ca0-8a33-b3200ee96179"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("80c43959-c297-438f-b82e-7fdf975f5c9e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7244SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7244",
				UId = new Guid("275d6eb0-2fe4-45e8-8711-c3fd812d392f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7d71abf-09e4-42a4-8cf8-79566a944e61"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("503e6fbf-801d-49ef-8445-6b3b477f7fb1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7245SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7245",
				UId = new Guid("49c29642-73c2-4ef4-abf8-515d60e0ab2b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b1be5054-17de-4feb-9d45-5c947bede808"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff202233-d33c-43cc-bdf2-0d4c5a21adaf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7246SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7246",
				UId = new Guid("5a5f29e5-e90d-4f48-89f1-bc2dbfe54aca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(306, 224),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff202233-d33c-43cc-bdf2-0d4c5a21adaf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5d2b11d-ba19-41ea-a445-89383c43fce6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7247SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7247",
				UId = new Guid("c73da6f2-9813-4625-b70c-789bc2c2d1cf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(325, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("503e6fbf-801d-49ef-8445-6b3b477f7fb1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5d2b11d-ba19-41ea-a445-89383c43fce6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7266SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7266",
				UId = new Guid("699c0163-51d4-4386-a659-f1d72a1e6b69"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(267, 645),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01e7250b-5ac1-495a-a1cd-2694f2f00ff9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5cf731b-23ba-4b9d-9ddc-a05c4efcad57"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7267SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7267",
				UId = new Guid("8d0b5119-e018-4d7d-85ff-687cffdb8097"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(154, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e4393af3-45c1-4e77-bd0d-2ea43d020f23"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ea67604d-499e-41e3-b54d-d0bb2904171a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7268SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7268",
				UId = new Guid("390d8aea-3924-468b-bf5d-d4165dfe846c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(154, 244),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eac4cbe5-406f-4a72-84c2-6024e6fb792c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("44444cfb-7e23-4f57-97f0-7d4c9dda05f0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7269SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7269",
				UId = new Guid("0147514b-a885-4897-99c7-4abacdad2d84"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(154, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1f4b9ae8-6114-4595-9c87-5df5377a1b6e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e4393af3-45c1-4e77-bd0d-2ea43d020f23"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7270SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7270",
				UId = new Guid("00ff2b36-38e0-4114-99eb-9b76ed61c38f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(154, 244),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18d5ff94-db6d-45ff-9b40-a6488556e13e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eac4cbe5-406f-4a72-84c2-6024e6fb792c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7280SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7280",
				UId = new Guid("1d41fe34-a27f-46d8-952c-26d76bc0d8fb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(299, 2444),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7ca807a-2179-4a7d-bc29-55a9a3b5b76e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("029d3827-89d0-4cdb-9117-ecdc80321e71"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7281SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7281",
				UId = new Guid("40227b40-6996-4b22-a0af-89a546d3bb63"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(294, 1702),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("07d0b10e-ee24-4bdb-9689-12edb64c69fb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("90339c0d-748a-4f18-b09d-73b558ca8da4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7282SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7282",
				UId = new Guid("455f868f-fe72-4c2d-835e-f634e9f814c0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(158, 1701),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("606f4c70-820b-4e18-a918-1463556c0bc3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("07d0b10e-ee24-4bdb-9689-12edb64c69fb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7283SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7283",
				UId = new Guid("07873850-ff2c-48c0-8991-ecc87323dffa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(168, 1708),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2b0ea09e-5e94-4d46-8998-0c8c9274f8dd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ee4a2b3c-9de0-4801-9c2f-6d36d5b4c2e4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7284SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7284",
				UId = new Guid("290fc1e7-37e9-411f-ada1-d3c7f32e1a42"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(168, 1696),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f1b61080-8d98-4bda-bcf7-706ee2f8ed81"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0a07bb4-8293-493a-82f2-28d6227dbbc2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7285SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7285",
				UId = new Guid("3bfad796-3f6a-442a-902d-7bafb3aeb37f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(211, 1693),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2c0381a2-13ee-49ca-8942-a23477b8374a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4af6ec58-c89b-4b38-b5af-d17f6ac262bb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7286SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7286",
				UId = new Guid("b141c637-fb32-406a-a571-353e074600e2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CurveCenterPosition = new Point(143, 1694),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0d76a44c-47cd-43a5-81df-7233f8bbebb8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2c0381a2-13ee-49ca-8942-a23477b8374a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet425LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet425 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"LaneSet425",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(872, 2036),
				UseBackgroundMode = false
			};
			return schemaLaneSet425;
		}

		protected virtual ProcessSchemaLane CreateLane1281Lane() {
			ProcessSchemaLane schemaLane1281 = new ProcessSchemaLane(this) {
				UId = new Guid("16a2072f-ff50-4ccb-9dfa-dc62ab3a07de"),
				ContainerItemIndex = 6,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1281",
				Position = new Point(29, 907),
				Size = new Size(843, 391),
				UseBackgroundMode = false
			};
			return schemaLane1281;
		}

		protected virtual ProcessSchemaLane CreateLane1282Lane() {
			ProcessSchemaLane schemaLane1282 = new ProcessSchemaLane(this) {
				UId = new Guid("10497ede-7a71-4e5a-957e-67d013156a98"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1282",
				Position = new Point(29, 727),
				Size = new Size(843, 175),
				UseBackgroundMode = false
			};
			return schemaLane1282;
		}

		protected virtual ProcessSchemaLane CreateLane1283Lane() {
			ProcessSchemaLane schemaLane1283 = new ProcessSchemaLane(this) {
				UId = new Guid("dd983e70-1b2e-4ed0-9259-7b3a8e0776ad"),
				ContainerItemIndex = 7,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1283",
				Position = new Point(29, 1303),
				Size = new Size(843, 165),
				UseBackgroundMode = false
			};
			return schemaLane1283;
		}

		protected virtual ProcessSchemaLane CreateLane1284Lane() {
			ProcessSchemaLane schemaLane1284 = new ProcessSchemaLane(this) {
				UId = new Guid("060cec6c-a1a0-4895-85f6-8473d157f797"),
				ContainerItemIndex = 8,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1284",
				Position = new Point(29, 1473),
				Size = new Size(843, 162),
				UseBackgroundMode = false
			};
			return schemaLane1284;
		}

		protected virtual ProcessSchemaLane CreateLane1285Lane() {
			ProcessSchemaLane schemaLane1285 = new ProcessSchemaLane(this) {
				UId = new Guid("477a4418-7398-4ddf-8d9b-7fc4d67b0e95"),
				ContainerItemIndex = 9,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1285",
				Position = new Point(29, 1640),
				Size = new Size(843, 232),
				UseBackgroundMode = false
			};
			return schemaLane1285;
		}

		protected virtual ProcessSchemaLane CreateLane1286Lane() {
			ProcessSchemaLane schemaLane1286 = new ProcessSchemaLane(this) {
				UId = new Guid("6215f3c1-da59-49b8-aaec-c79c47b3e4ae"),
				ContainerItemIndex = 10,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1286",
				Position = new Point(29, 1877),
				Size = new Size(843, 159),
				UseBackgroundMode = false
			};
			return schemaLane1286;
		}

		protected virtual ProcessSchemaLane CreateLane1287Lane() {
			ProcessSchemaLane schemaLane1287 = new ProcessSchemaLane(this) {
				UId = new Guid("84039b24-bb8a-499c-92ec-56f12ce5b2de"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1287",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 547),
				Size = new Size(843, 175),
				UseBackgroundMode = false
			};
			return schemaLane1287;
		}

		protected virtual ProcessSchemaLane CreateLane1288Lane() {
			ProcessSchemaLane schemaLane1288 = new ProcessSchemaLane(this) {
				UId = new Guid("b626b105-7fea-4753-8af4-916d78c63c8a"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1288",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 360),
				Size = new Size(843, 182),
				UseBackgroundMode = false
			};
			return schemaLane1288;
		}

		protected virtual ProcessSchemaLane CreateLane1289Lane() {
			ProcessSchemaLane schemaLane1289 = new ProcessSchemaLane(this) {
				UId = new Guid("f2148734-0992-4440-afc9-7934d237b888"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1289",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 180),
				Size = new Size(843, 175),
				UseBackgroundMode = false
			};
			return schemaLane1289;
		}

		protected virtual ProcessSchemaLane CreateLane1290Lane() {
			ProcessSchemaLane schemaLane1290 = new ProcessSchemaLane(this) {
				UId = new Guid("ff58e5f4-8870-424a-8cb4-58c16662b9b3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("04c8c3e7-89a1-4347-84d7-1657252d8805"),
				CreatedInOwnerSchemaUId = new Guid("82ba68b7-733c-4f44-a217-a7003bcc6ec1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Lane1290",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(843, 175),
				UseBackgroundMode = false
			};
			return schemaLane1290;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess_ShowRelatedRightsCheckBoxCheckEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess_ShowRelatedRightsCheckBoxCheck = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0a1730f7-422b-4490-b13a-a5bfdb86acd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd983e70-1b2e-4ed0-9259-7b3a8e0776ad"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SubProcess_ShowRelatedRightsCheckBoxCheck",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(216, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess_ShowRelatedRightsCheckBoxCheck;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateShowRelatedRightsCheckBoxCheckMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("01e7250b-5ac1-495a-a1cd-2694f2f00ff9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a1730f7-422b-4490-b13a-a5bfdb86acd8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ShowRelatedRightsCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ShowRelatedRightsCheckBoxCheckMessage",
				Position = new Point(50, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowGridPageRefreshRowIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d5cf731b-23ba-4b9d-9ddc-a05c4efcad57"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a1730f7-422b-4490-b13a-a5bfdb86acd8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ThrowGridPageRefreshRow",
				Position = new Point(134, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess_InitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess_Init = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e9beb33e-d684-49d5-b0c7-1c937558a885"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10497ede-7a71-4e5a-957e-67d013156a98"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SubProcess_Init",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(343, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess_Init;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a2c5e314-59c0-431c-b9e3-84f71bebf1d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9beb33e-d684-49d5-b0c7-1c937558a885"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"InitMessage",
				Position = new Point(29, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c7ca807a-2179-4a7d-bc29-55a9a3b5b76e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9beb33e-d684-49d5-b0c7-1c937558a885"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptInit",
				Position = new Point(113, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,143,155,48,16,61,135,95,225,229,4,234,202,127,0,237,33,13,213,150,195,182,81,201,166,199,106,138,39,91,183,142,161,131,77,146,86,251,223,107,3,27,96,65,85,123,65,30,191,55,95,111,198,52,64,172,145,100,44,168,20,12,228,165,165,2,217,29,211,120,98,251,215,247,81,204,126,7,171,44,117,248,12,203,210,224,57,9,182,240,132,124,45,196,91,107,76,169,249,250,59,156,223,53,168,77,205,55,74,22,63,120,46,159,52,168,15,112,244,57,194,143,21,234,253,41,191,212,121,241,13,143,144,233,188,84,214,200,82,135,73,48,43,106,28,44,135,6,5,111,13,246,230,142,13,164,47,45,242,111,222,103,67,176,5,114,181,24,164,218,87,29,249,174,119,72,4,117,121,48,252,49,227,159,241,235,166,212,134,74,229,58,120,57,92,157,162,144,240,167,197,218,132,183,108,116,252,143,8,15,165,64,254,9,78,113,220,107,231,63,158,6,82,35,13,14,190,184,89,79,206,167,113,227,19,227,185,181,65,6,74,199,168,91,121,29,58,80,121,39,121,159,117,71,136,247,36,197,200,51,19,142,63,151,49,75,19,22,12,118,110,200,22,198,18,50,129,135,193,88,242,76,71,132,36,24,211,93,155,202,30,181,223,17,4,138,226,87,232,150,228,17,232,210,145,250,213,233,58,154,66,220,99,73,32,15,44,154,194,169,172,43,5,61,139,221,184,229,182,74,181,171,188,148,103,194,94,76,55,97,244,89,159,175,163,216,131,178,184,187,84,248,0,218,105,75,206,61,74,23,238,227,96,213,106,255,88,35,185,57,107,44,252,230,243,117,85,245,132,45,149,141,20,110,11,238,209,244,87,81,184,20,41,116,138,109,8,193,224,236,85,94,187,139,150,74,187,157,76,45,238,180,187,201,106,191,118,120,54,239,81,85,221,67,206,180,52,18,148,252,133,162,251,5,92,237,25,213,143,111,245,247,16,78,17,151,179,21,141,208,101,214,157,249,7,248,39,83,197,139,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBaseInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("029d3827-89d0-4cdb-9117-ecdc80321e71"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9beb33e-d684-49d5-b0c7-1c937558a885"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BaseAdministrativeGrid",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"IntermediateThrowBaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessSelectingEntitySchemaForAddRightsEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessSelectingEntitySchemaForAddRights = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dbc979b5-d64a-4862-a27b-079c87fb9f3f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16a2072f-ff50-4ccb-9dfa-dc62ab3a07de"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SubProcessSelectingEntitySchemaForAddRights",
				Position = new Point(36, 6),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(770, 204),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessSelectingEntitySchemaForAddRights;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMessage_OpenVwSysSchemaInSolutionStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7c3394be-25d1-46b8-a435-988dbbbff0e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbc979b5-d64a-4862-a27b-079c87fb9f3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OpenVwSysSchemaInSolution",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Message_OpenVwSysSchemaInSolution",
				Position = new Point(22, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitOpenLookupUserTaskScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ecf4a4f1-426d-47e3-b6ef-0b00ce5e673b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbc979b5-d64a-4862-a27b-079c87fb9f3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"InitOpenLookupUserTaskScript",
				Position = new Point(119, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,77,111,211,64,16,61,39,82,254,195,226,94,18,17,187,73,154,38,14,45,69,141,227,72,81,129,68,77,66,15,8,161,173,189,110,76,157,93,119,119,77,177,34,75,80,142,32,113,231,103,32,144,10,69,229,47,108,254,17,235,77,112,63,20,1,23,36,14,94,201,163,121,111,222,188,153,97,156,250,248,8,248,152,113,136,29,212,115,193,125,80,44,142,16,165,144,17,143,27,227,158,113,128,14,45,130,57,37,1,51,6,240,8,149,210,199,216,101,161,250,49,122,25,212,24,145,161,162,43,150,182,10,249,126,136,240,67,66,142,163,112,204,16,29,65,118,108,12,40,113,16,99,123,40,150,85,174,149,188,11,20,101,250,164,149,160,143,17,53,198,216,63,137,80,175,35,169,214,215,215,214,125,15,244,134,207,15,250,251,123,195,193,174,101,167,65,241,81,92,138,207,101,32,190,137,203,249,153,252,94,207,223,137,175,234,87,124,23,63,196,185,184,16,231,50,248,86,124,153,159,205,223,204,63,128,52,75,92,204,223,167,41,64,124,2,7,132,30,179,16,58,8,88,251,213,230,134,185,89,41,228,217,194,17,230,76,208,20,142,149,33,195,9,57,221,247,143,38,156,181,227,97,116,248,2,57,28,60,0,154,187,233,86,170,158,227,234,13,215,116,244,250,97,173,165,183,208,166,169,59,14,220,240,60,212,168,109,52,234,26,184,7,180,122,215,110,84,90,205,166,110,53,171,85,189,110,182,107,186,89,111,181,244,170,101,183,219,182,213,109,154,13,83,91,246,137,176,235,123,171,221,147,246,12,32,133,83,196,17,101,82,22,70,167,160,227,59,220,39,24,210,24,108,47,148,151,1,81,10,119,212,20,94,66,10,194,219,192,226,111,80,165,63,86,150,172,55,25,141,93,215,45,106,153,97,90,249,202,188,84,130,156,92,241,206,10,11,75,96,86,200,231,44,18,4,72,169,217,190,82,117,91,212,14,240,252,224,90,215,127,7,82,6,228,86,46,143,140,130,81,191,211,151,115,95,171,54,107,149,70,75,198,150,53,84,59,55,189,189,77,13,102,64,230,231,192,76,115,200,52,132,212,103,4,143,226,16,201,214,187,138,196,186,17,54,236,147,8,6,73,121,137,9,144,199,237,87,33,149,167,32,233,101,47,209,20,15,32,159,72,180,54,140,89,182,148,90,134,136,24,234,248,44,12,96,252,4,6,81,90,198,131,1,67,32,41,255,210,65,83,111,175,72,179,225,168,124,38,1,105,67,11,245,79,159,129,153,186,183,116,190,242,222,240,194,73,35,171,107,244,220,36,145,188,137,242,239,127,112,229,17,196,82,48,125,44,123,250,135,166,104,54,230,62,143,135,106,121,151,37,181,36,73,178,53,90,222,102,110,213,250,47,78,102,209,103,74,189,180,45,197,74,47,11,121,138,120,68,49,224,52,66,91,63,1,14,63,79,221,117,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a5425596-1e11-4375-949b-f3225640a939"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbc979b5-d64a-4862-a27b-079c87fb9f3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"OpenLookupUserTask",
				Position = new Point(260, 49),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateCatchMessage_LookupGridPageClosedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("12084bd3-aca9-4b3b-8669-db9c8bd3988a"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbc979b5-d64a-4862-a27b-079c87fb9f3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"BoundaryNonInterruptingEvent",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("b851455c-ed5a-427c-831f-19dd15eb3e76"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"CatchMessage_LookupGridPageClosed",
				Position = new Point(568, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateApplyDataScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4d0bc475-4133-45b7-bfa5-0bce554330ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbc979b5-d64a-4862-a27b-079c87fb9f3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ApplyDataScript",
				Position = new Point(680, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,93,107,19,65,20,125,54,144,255,48,230,105,22,195,84,17,81,176,22,234,38,41,139,74,165,217,180,207,211,221,155,236,152,100,102,157,153,77,92,68,168,245,81,193,119,127,134,40,84,43,245,47,204,254,35,231,35,109,82,136,15,59,176,115,207,57,247,204,185,119,65,37,90,208,89,5,10,61,67,184,199,50,205,4,167,178,70,187,74,75,198,39,93,36,78,223,64,166,247,162,195,18,248,75,33,166,85,57,82,32,83,170,166,228,0,244,16,102,182,10,249,177,215,192,174,20,11,206,193,235,68,79,219,173,131,138,229,72,173,80,73,110,187,184,27,210,159,151,186,182,229,177,144,64,179,2,225,197,181,145,68,195,28,49,190,114,21,161,247,237,214,157,91,124,14,75,175,129,111,224,228,5,212,174,215,135,118,203,201,48,174,52,229,25,120,52,198,41,72,73,149,24,107,50,74,200,9,156,90,127,90,138,153,34,175,233,4,34,119,144,125,85,250,31,146,220,80,73,42,134,62,1,236,148,67,24,104,10,181,149,220,208,191,135,60,223,29,78,150,50,14,146,140,56,123,107,141,245,44,143,141,17,94,155,39,137,242,239,198,81,120,150,4,93,73,142,180,172,32,184,223,217,49,223,204,149,249,209,69,230,183,185,106,206,237,119,214,124,54,191,252,175,249,99,254,154,11,115,105,46,236,229,39,243,179,57,111,62,54,95,145,67,153,203,230,139,131,32,243,29,157,8,57,85,37,205,0,197,71,15,30,63,124,242,232,62,10,177,168,90,13,179,2,230,52,225,107,76,136,115,29,81,108,231,97,15,62,102,147,74,82,55,68,114,188,28,110,97,134,11,236,159,127,123,234,164,207,53,211,117,0,188,162,220,34,100,68,98,59,103,13,161,180,141,21,173,210,186,187,205,38,25,128,206,138,129,20,243,222,243,141,60,255,23,227,245,82,6,157,81,146,15,132,220,207,243,35,54,41,180,219,243,173,45,236,50,167,117,9,121,44,102,213,156,251,125,222,117,107,182,135,59,86,161,227,252,181,91,105,33,197,178,191,0,174,113,102,231,13,239,116,23,117,66,187,160,184,217,201,115,54,205,253,3,229,218,33,42,109,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventBasedGateway CreateEventBasedGateway1EventBasedGateway() {
			ProcessSchemaEventBasedGateway gateway = new ProcessSchemaEventBasedGateway(this) {
				UId = new Guid("111f5cf3-2bcf-4ca0-8a33-b3200ee96179"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbc979b5-d64a-4862-a27b-079c87fb9f3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				Instantiate = true,
				IsLogging = false,
				ManagerItemUId = new Guid("b11eb76c-c34e-4a34-ba93-559b8b0a9d04"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"EventBasedGateway1",
				Position = new Point(393, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("80c43959-c297-438f-b82e-7fdf975f5c9e"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dbc979b5-d64a-4862-a27b-079c87fb9f3f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"BoundaryEvent",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"Initialize",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"IntermediateCatchMessageEvent1",
				Position = new Point(407, 146),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess_AddEntitySchemaRightEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess_AddEntitySchemaRight = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c59df333-0dcf-4e0d-ba45-191109460160"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16a2072f-ff50-4ccb-9dfa-dc62ab3a07de"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SubProcess_AddEntitySchemaRight",
				Position = new Point(36, 223),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess_AddEntitySchemaRight;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMessage_SelectSchemaForAddRightsStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("62fdbefd-5512-4279-9a89-d1465dc1c715"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c59df333-0dcf-4e0d-ba45-191109460160"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SelectSchemaForAddRights",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"Message_SelectSchemaForAddRights",
				Position = new Point(22, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSelectSchemaForAddRightsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("03ac8f45-0301-4ff5-96ac-05570dcfdff7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c59df333-0dcf-4e0d-ba45-191109460160"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptSelectSchemaForAddRights",
				Position = new Point(120, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,207,207,110,194,48,12,6,240,51,121,138,28,91,14,225,1,170,29,70,249,163,30,64,136,10,238,86,99,104,164,214,65,142,51,169,130,189,251,186,70,104,227,194,213,250,125,182,63,119,209,89,141,29,54,130,118,239,45,30,216,245,192,67,233,187,216,211,25,186,136,166,10,235,254,38,67,150,235,199,67,63,109,221,180,216,195,169,178,27,207,159,214,30,221,181,149,240,71,115,125,87,51,70,137,76,90,56,98,161,190,213,98,254,5,172,195,20,212,31,250,0,87,52,43,16,168,125,228,6,77,218,88,168,95,132,36,78,134,17,37,109,74,70,16,92,79,211,108,10,158,2,114,233,137,198,103,156,167,60,197,194,203,115,207,27,175,212,164,45,137,236,128,70,193,102,139,82,81,16,160,6,151,195,88,42,123,91,51,47,230,11,245,191,220,15,144,252,176,208,69,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessPositionButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessPositionButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("925c7e9f-2606-4e85-8423-6ba551b04677"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("477a4418-7398-4ddf-8d9b-7fc4d67b0e95"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SubProcessPositionButtonClick",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(363, 211),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessPositionButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDownButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b1be5054-17de-4feb-9d45-5c947bede808"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("925c7e9f-2606-4e85-8423-6ba551b04677"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownButtonClick",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"StartMessageDownButtonClick",
				Position = new Point(22, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDownButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ff202233-d33c-43cc-bdf2-0d4c5a21adaf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("925c7e9f-2606-4e85-8423-6ba551b04677"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptDownButtonClick",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,177,78,195,48,16,134,103,242,20,167,76,137,136,172,2,99,148,133,8,69,25,168,42,210,178,160,12,110,125,36,70,141,141,236,115,81,132,120,119,220,132,210,72,141,96,246,247,127,254,239,78,190,66,180,226,13,178,181,65,44,140,20,172,194,61,238,8,197,82,11,180,44,215,78,17,100,25,44,98,248,12,174,12,146,51,10,200,56,76,131,175,224,192,13,216,9,15,25,252,33,123,89,212,233,16,145,194,131,10,63,160,112,82,68,83,1,123,230,123,231,201,176,20,97,205,214,186,34,35,85,19,197,241,24,124,215,86,146,212,202,199,115,173,14,104,200,51,165,162,187,219,121,203,234,135,15,235,24,174,225,102,148,216,222,86,187,22,59,94,254,95,163,58,179,115,125,80,145,164,126,36,30,185,242,163,155,211,10,54,22,141,239,168,188,211,23,96,15,151,100,26,216,193,6,214,109,223,60,54,62,46,121,119,92,227,140,153,21,72,37,97,119,223,111,74,95,247,220,44,102,199,80,26,228,45,87,13,62,201,166,29,184,211,240,145,20,201,239,230,146,225,118,201,229,159,126,162,233,113,191,1,207,38,197,219,24,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageGridPageRefreshRowIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a5d2b11d-ba19-41ea-a445-89383c43fce6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("925c7e9f-2606-4e85-8423-6ba551b04677"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"IntermediateThrowMessageGridPageRefreshRow",
				Position = new Point(295, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageUpButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c7d71abf-09e4-42a4-8cf8-79566a944e61"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("925c7e9f-2606-4e85-8423-6ba551b04677"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpButtonClick",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"StartMessageUpButtonClick",
				Position = new Point(22, 139),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptUpButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("503e6fbf-801d-49ef-8445-6b3b477f7fb1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("925c7e9f-2606-4e85-8423-6ba551b04677"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptUpButtonClick",
				Position = new Point(134, 125),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,61,79,195,48,20,69,103,252,43,158,50,37,82,176,10,140,33,11,17,138,50,80,85,164,101,65,25,220,250,53,49,74,108,228,143,162,8,241,223,113,27,218,70,106,84,102,159,123,124,223,21,91,8,23,172,70,186,212,136,185,22,156,150,216,226,198,34,159,43,142,134,102,202,73,11,105,10,179,8,190,201,141,70,235,180,4,171,29,38,228,135,236,152,6,51,226,33,133,43,178,247,89,149,28,34,130,123,80,226,23,228,78,240,112,44,160,111,172,117,158,12,10,30,84,116,169,74,171,133,172,195,40,26,130,159,202,8,43,148,244,241,76,201,29,106,235,153,66,218,135,251,105,203,226,143,15,170,8,110,225,46,33,194,159,123,146,60,94,57,170,55,229,166,193,142,21,255,87,45,207,236,84,103,148,86,216,126,32,94,152,244,243,232,227,76,43,131,218,223,33,189,211,247,161,207,151,100,66,204,193,6,198,173,63,60,54,60,206,89,183,159,122,194,76,115,180,133,197,238,169,95,21,190,238,185,89,68,247,161,132,100,13,147,53,190,138,186,57,112,199,129,66,193,227,211,186,49,108,89,107,48,190,252,212,159,52,30,235,23,85,230,5,155,61,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessOwnMenuItemCheckChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessOwnMenuItemCheckChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9b908f37-d1af-474e-b7e8-b560a688531e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6215f3c1-da59-49b8-aaec-c79c47b3e4ae"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SubProcessOwnMenuItemCheckChange",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(335, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessOwnMenuItemCheckChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOwnMenuItemCheckChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1f4b9ae8-6114-4595-9c87-5df5377a1b6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b908f37-d1af-474e-b7e8-b560a688531e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OwnMenuItemCheckChange",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"OwnMenuItemCheckChange",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOwnMenuItemOwnMenuItemIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ea67604d-499e-41e3-b54d-d0bb2904171a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b908f37-d1af-474e-b7e8-b560a688531e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"OwnMenuItemOwnMenuItem",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOwnMenuItemCheckChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e4393af3-45c1-4e77-bd0d-2ea43d020f23"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b908f37-d1af-474e-b7e8-b560a688531e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptOwnMenuItemCheckChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,204,201,241,77,205,43,245,44,73,205,213,115,206,72,77,206,78,77,81,176,85,72,75,204,41,78,181,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,194,203,38,146,46,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessAllMenuItemCheckChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessAllMenuItemCheckChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eb15c43d-68ce-4489-bad0-fd0ca446c8fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("060cec6c-a1a0-4895-85f6-8473d157f797"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SubProcessAllMenuItemCheckChange",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(335, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessAllMenuItemCheckChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAllMenuItemCheckChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("18d5ff94-db6d-45ff-9b40-a6488556e13e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb15c43d-68ce-4489-bad0-fd0ca446c8fa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AllMenuItemCheckChange",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"AllMenuItemCheckChange",
				Position = new Point(15, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateAllMenuItemGridPageRefreshRowIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("44444cfb-7e23-4f57-97f0-7d4c9dda05f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb15c43d-68ce-4489-bad0-fd0ca446c8fa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"AllMenuItemGridPageRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAllMenuItemCheckChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eac4cbe5-406f-4a72-84c2-6024e6fb792c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb15c43d-68ce-4489-bad0-fd0ca446c8fa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptAllMenuItemCheckChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,47,207,243,77,205,43,245,44,73,205,213,115,206,72,77,206,78,77,81,176,85,72,75,204,41,78,181,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,16,27,134,155,46,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProcessAdministrativGridPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProcessAdministrativGridPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5218a0a1-a898-44af-8c7a-2e97e60b5a18"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84039b24-bb8a-499c-92ec-56f12ce5b2de"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ProcessAdministrativGridPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(344, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProcessAdministrativGridPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAdministrativePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("606f4c70-820b-4e18-a918-1463556c0bc3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5218a0a1-a898-44af-8c7a-2e97e60b5a18"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"StartMessageAdministrativePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAdministrativGridPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("07d0b10e-ee24-4bdb-9689-12edb64c69fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5218a0a1-a898-44af-8c7a-2e97e60b5a18"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptAdministrativGridPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,205,177,14,130,48,20,133,225,157,167,32,76,186,148,7,32,14,136,24,25,20,99,19,247,43,220,180,133,114,107,218,91,209,183,215,224,166,227,201,159,124,39,207,207,160,80,148,125,191,141,204,142,68,77,112,179,216,167,155,116,9,59,180,200,248,215,14,16,46,70,105,14,123,231,43,13,164,112,181,46,146,252,23,43,7,120,214,15,36,14,162,178,166,27,133,52,138,192,158,96,194,15,146,181,119,164,235,44,95,65,118,26,39,104,72,58,27,217,56,202,138,100,145,218,153,142,72,177,97,156,68,165,177,27,151,115,246,17,139,196,35,71,79,223,241,6,117,37,135,203,198,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBasePageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("90339c0d-748a-4f18-b09d-73b558ca8da4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5218a0a1-a898-44af-8c7a-2e97e60b5a18"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"IntermediateThrowBasePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessAdministrativeGridDeleteButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessAdministrativeGridDeleteButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("88ae7864-7888-4aaa-b0c8-6451b9677b8b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b626b105-7fea-4753-8af4-916d78c63c8a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"SubProcessAdministrativeGridDeleteButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessAdministrativeGridDeleteButtonClick;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAdministrativeGridDeleteButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ee4a2b3c-9de0-4801-9c2f-6d36d5b4c2e4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88ae7864-7888-4aaa-b0c8-6451b9677b8b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptAdministrativeGridDeleteButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,63,111,194,48,20,196,103,242,41,60,58,139,5,93,17,11,127,202,134,16,161,44,136,193,36,87,106,201,177,171,103,59,109,85,241,221,235,196,69,16,168,26,41,203,123,247,187,59,61,55,146,152,131,70,233,81,173,108,5,199,38,108,45,79,16,91,2,150,164,42,81,220,110,199,153,122,101,188,7,136,153,13,198,179,201,132,141,114,246,157,13,154,232,248,78,170,150,244,181,65,105,169,218,73,29,16,109,123,212,126,120,16,221,194,237,187,184,185,244,178,176,129,74,136,162,124,67,45,197,58,121,204,172,14,181,17,43,89,227,32,182,182,240,164,204,137,231,227,20,212,40,242,65,234,43,29,115,150,240,187,251,113,2,238,167,98,131,218,54,224,6,31,108,25,84,197,31,123,231,151,164,216,62,121,167,123,60,91,122,12,49,65,235,86,31,92,236,200,120,139,85,199,197,39,202,224,45,69,250,197,129,102,214,152,200,43,107,196,194,184,64,152,79,175,35,158,119,39,188,53,32,200,10,148,206,39,146,23,54,221,140,95,189,127,177,65,251,56,9,16,173,230,98,247,207,98,176,48,242,168,49,13,222,91,227,248,83,91,63,126,103,6,237,240,183,102,116,209,100,247,194,190,110,152,116,173,44,254,231,236,156,17,124,32,195,60,5,140,127,0,41,82,65,232,121,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartAdministrativeGridDeleteButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2b0ea09e-5e94-4d46-8998-0c8c9274f8dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88ae7864-7888-4aaa-b0c8-6451b9677b8b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"StartAdministrativeGridDeleteButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProcessAdministrativeGridRefreshRowEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProcessAdministrativeGridRefreshRow = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("808a9977-00e7-4724-9749-6e6b99fbcad7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f2148734-0992-4440-afc9-7934d237b888"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ProcessAdministrativeGridRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 6),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProcessAdministrativeGridRefreshRow;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAdministrativeGridRefreshRowStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f1b61080-8d98-4bda-bcf7-706ee2f8ed81"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("808a9977-00e7-4724-9749-6e6b99fbcad7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"StartMessageAdministrativeGridRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAdministartiveGridRefreshRowScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b0a07bb4-8293-493a-82f2-28d6227dbbc2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("808a9977-00e7-4724-9749-6e6b99fbcad7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptAdministartiveGridRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,77,79,219,64,16,61,59,18,255,97,201,1,57,2,89,156,27,64,130,0,33,18,165,136,16,122,64,28,38,246,56,217,178,222,69,251,65,26,161,252,247,206,122,157,198,196,46,173,212,246,146,216,51,239,189,241,190,157,153,87,208,236,149,107,235,64,156,131,133,177,114,58,69,118,204,134,104,31,182,195,113,175,191,211,25,40,33,48,181,92,201,163,161,227,217,9,131,172,224,114,34,185,221,100,136,47,113,193,182,161,37,223,63,177,156,11,139,154,242,174,144,15,32,156,175,56,70,15,198,236,70,101,120,171,121,1,122,89,3,16,147,231,44,190,133,25,38,167,66,124,70,233,70,22,139,100,48,199,244,25,179,30,123,219,233,68,60,143,119,27,210,201,200,92,20,47,118,25,247,2,40,106,255,224,82,121,98,60,85,202,16,77,206,207,198,152,58,205,237,242,66,206,184,196,132,92,241,144,211,166,66,220,168,235,15,27,173,118,58,43,134,194,96,89,186,165,114,114,154,101,237,92,162,190,210,229,168,233,55,66,222,130,134,2,9,100,42,111,67,248,177,77,113,160,156,180,79,164,144,43,205,98,46,45,227,68,58,236,211,223,81,219,109,5,2,165,247,247,131,67,219,37,31,249,19,9,180,48,41,17,62,180,52,239,94,35,14,53,207,146,129,64,208,229,101,55,58,171,150,11,247,253,238,96,219,133,9,117,201,133,104,54,98,67,247,160,193,109,47,127,173,32,187,83,11,83,126,129,127,40,207,78,165,155,80,159,173,172,9,55,49,117,214,42,105,194,112,156,133,151,82,135,124,70,72,231,177,7,165,74,90,173,4,227,50,116,84,133,27,132,240,53,44,149,179,73,245,102,130,221,27,109,146,94,243,193,176,123,212,26,140,202,109,50,25,37,95,113,186,102,253,164,87,226,253,178,243,89,92,105,236,82,131,56,33,216,222,30,51,86,115,57,35,124,241,2,26,191,232,140,75,16,21,46,185,33,163,14,88,215,139,225,119,123,133,226,37,200,117,123,94,226,176,26,150,141,112,168,11,156,14,93,83,88,15,85,100,22,220,166,115,246,46,87,165,162,20,104,0,186,227,185,90,220,161,0,154,241,59,62,155,91,83,213,251,20,64,81,197,188,144,48,21,152,145,23,86,151,115,95,230,200,225,231,126,93,141,230,230,119,252,43,48,161,208,165,210,131,57,200,89,216,96,219,122,25,230,224,132,101,191,212,137,55,141,114,226,141,241,214,254,153,246,202,255,214,22,192,71,135,92,85,235,34,44,186,145,57,71,50,91,248,129,242,245,62,222,142,236,152,154,146,22,107,82,110,186,224,251,95,118,229,63,105,203,255,215,151,77,35,115,32,151,251,81,84,243,50,210,104,157,150,107,143,41,82,15,252,0,172,89,229,223,251,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProcessAdministrativeGridSelectionChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProcessAdministrativeGridSelectionChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4e480294-effc-45b8-bf28-c7a91bf2ad17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff58e5f4-8870-424a-8cb4-58c16662b9b3"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ProcessAdministrativeGridSelectionChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(272, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProcessAdministrativeGridSelectionChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAdministrativeGridSelectionChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0d76a44c-47cd-43a5-81df-7233f8bbebb8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4e480294-effc-45b8-bf28-c7a91bf2ad17"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"StartMessageAdministrativeGridSelectionChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAdministrativeGridSelectionChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4af6ec58-c89b-4b38-b5af-d17f6ac262bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4e480294-effc-45b8-bf28-c7a91bf2ad17"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"ScriptAdministrativeGridSelectionChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,205,110,194,48,16,132,207,201,83,184,57,37,8,25,218,30,17,61,64,43,20,85,69,168,1,46,136,131,33,11,184,10,107,100,59,160,168,226,221,107,59,252,138,128,122,246,236,204,183,179,110,212,248,130,132,3,182,4,58,148,0,61,201,83,154,64,6,115,13,105,95,164,160,104,87,228,168,73,187,77,154,17,249,245,61,9,58,151,72,180,204,161,229,239,125,59,253,45,118,170,84,189,145,103,39,218,50,73,212,133,11,105,147,7,17,147,230,180,229,123,214,233,233,114,136,142,89,150,59,0,212,140,163,250,132,34,12,6,66,113,205,5,6,145,11,242,156,237,104,211,201,181,22,72,63,144,205,50,72,77,220,130,101,202,0,30,4,239,98,135,247,37,87,43,121,251,3,126,161,146,249,10,214,44,182,90,132,29,233,229,60,13,43,0,39,65,114,214,6,83,58,20,137,150,28,151,97,20,181,74,47,64,205,117,81,74,190,24,26,34,121,108,100,164,64,154,5,209,152,114,71,119,163,52,30,202,249,17,149,207,126,140,174,124,237,179,181,173,181,194,154,246,64,199,26,214,157,98,20,27,224,51,91,68,237,144,173,218,156,106,115,40,210,120,152,252,45,72,109,192,99,212,175,47,213,59,158,138,159,218,173,238,213,222,101,216,93,49,92,130,5,56,142,132,55,224,117,87,118,253,4,81,191,250,45,167,128,202,179,253,59,194,221,247,65,198,190,214,240,47,79,255,7,103,19,52,108,11,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBaseSelectionChangeIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2c0381a2-13ee-49ca-8942-a23477b8374a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4e480294-effc-45b8-bf28-c7a91bf2ad17"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Name = @"IntermediateThrowBaseSelectionChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 55),
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
			Methods.Add(CreateCreateVirtualDataSourceStructureMethod());
			Methods.Add(CreateDataSource_SavedMethod());
			Methods.Add(CreateGetVirtualDataSourceMethod());
			Methods.Add(CreateFillVirtualDataSourceMethod());
			Methods.Add(CreateHasRightsForChangeMethod());
			Methods.Add(CreateChangeRightItemPositionMethod());
			Methods.Add(CreateCanChangeItemPositionMethod());
			Methods.Add(CreateDeterminePositionForMoveMethod());
			Methods.Add(CreateGetSelectForVirtualDataSourceMethod());
			Methods.Add(CreateEnableButtonsMethod());
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

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,200,75,45,87,8,174,44,46,73,205,213,115,206,207,201,73,77,46,201,4,74,232,185,167,230,165,22,101,38,235,249,100,22,151,216,20,151,20,101,230,165,219,105,104,90,115,65,53,234,57,166,164,104,4,36,166,167,234,185,166,100,150,56,129,5,245,252,18,115,83,177,41,113,73,205,73,45,73,37,160,40,180,128,144,41,249,229,121,168,74,138,82,75,74,139,242,96,126,177,6,0,126,236,174,141,216,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterCopyPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterCopyPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateVirtualDataSourceStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1ef53c46-c45e-489c-bd20-320ed8eb9b22"),
				Name = "CreateVirtualDataSourceStructure",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ce9a1c66-a163-4d48-884e-21e94ff6e650"),
				Name = "dataValueTypeManager",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataValueTypeManager",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0c6bb04b-51a1-49e1-acb6-ad72beb587c3"),
				Name = "defStructure",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceStructure",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateDataSource_SavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d6fe6bb4-39ea-4333-9da9-f7a99d127ea7"),
				Name = "DataSource_Saved",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("61f2cf43-78c3-4897-8ae5-4d2191357737"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d55e1367-c1dd-486a-bde5-5f918581396e"),
				Name = "e",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateGetVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ef3a5dc5-d5ef-42cf-9a70-b254f2773fef"),
				Name = "GetVirtualDataSource",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,3,17,206,249,121,37,137,153,121,169,69,122,110,153,121,41,48,145,162,252,28,141,176,204,162,146,210,196,28,151,196,146,196,224,252,210,162,228,84,79,23,77,133,196,98,5,12,113,107,0,231,40,17,24,84,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4d5ee0c3-810a-49eb-b770-3172da04c125"),
				Name = "FillVirtualDataSource",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a817c193-c00f-40d4-890d-6bdc6e7a354e"),
				Name = "virtualDataSource",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d34cfc07-3b03-4a16-ab23-1087188712ca"),
				Name = "objectParameters",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateHasRightsForChangeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("02a77607-daa7-469b-8d37-788208339556"),
				Name = "HasRightsForChange",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,207,77,10,194,48,16,5,224,181,133,222,97,150,205,38,23,40,221,88,131,75,139,197,3,196,118,140,129,56,173,211,137,88,172,119,183,130,8,254,108,231,61,62,222,248,3,100,155,30,217,138,239,104,235,221,81,202,174,69,40,10,160,24,2,76,19,252,166,218,156,163,13,67,86,11,123,114,218,156,122,25,149,130,91,154,44,24,37,50,129,112,196,60,77,238,105,114,177,12,237,190,198,38,178,151,209,144,243,52,235,80,89,135,122,55,32,151,29,17,54,79,94,175,150,159,181,25,120,113,223,128,94,163,148,150,204,117,190,10,190,7,254,121,68,229,15,200,229,111,253,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateChangeRightItemPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c757a3d1-a487-485e-a4b4-07bca93db645"),
				Name = "ChangeRightItemPosition",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("081914c4-726f-419b-bd59-5549fae95ac8"),
				Name = "primaryColumnValue",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("73febe9d-c3e9-465b-8fe1-3be278052edf"),
				Name = "position",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("518c3b2f-138b-4c9f-ba11-f03a5b113703"),
				Name = "increasePosition",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("356edc27-e430-4021-be56-2c06c4800767"),
				Name = "subjectSchemaName",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,201,78,195,48,16,61,55,95,97,229,148,72,85,250,1,81,47,180,1,245,64,137,26,150,35,114,157,33,53,196,118,52,30,3,21,229,223,113,80,55,146,208,155,53,243,150,153,55,150,47,44,178,132,82,87,201,194,46,93,93,223,97,166,26,218,70,43,89,109,200,22,98,3,138,47,185,130,152,237,118,236,2,242,6,141,107,26,223,157,153,218,41,221,82,108,28,179,175,96,132,64,14,117,26,124,7,147,73,99,172,36,105,52,155,178,57,16,160,146,26,242,125,237,218,224,173,121,135,232,128,25,51,169,5,2,183,71,196,152,89,183,126,5,65,103,99,165,65,65,6,161,204,209,8,40,29,2,179,64,43,16,6,203,3,237,212,154,50,13,31,172,67,136,114,94,65,242,96,1,103,70,107,175,254,235,20,146,109,158,139,174,84,24,7,163,228,73,210,38,231,232,221,253,6,81,120,207,215,53,180,179,132,99,214,75,173,15,207,81,42,142,219,83,76,158,22,46,202,33,229,63,208,71,94,187,22,219,244,138,3,204,161,107,28,199,27,60,213,128,251,97,103,239,185,127,198,140,219,110,124,105,240,127,224,73,206,197,155,79,183,181,240,225,15,4,157,204,175,50,93,249,95,144,20,91,75,160,206,8,23,133,179,79,16,142,32,138,211,31,240,201,149,46,194,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCanChangeItemPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2674b3ca-fec4-426a-a2e6-b0393e342be3"),
				Name = "CanChangeItemPosition",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b53c4b8f-7ad1-4dc4-aec5-3f06a41de653"),
				Name = "subjectName",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bf277457-3691-4d29-aac6-38b6e3a35b37"),
				Name = "upPosition",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("15664646-bdb5-406f-bab1-35be0a266656"),
				Name = "itemPosition",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a3389bd7-8c09-47e6-a3d4-00d6e4f0abc1"),
				Name = "selectedNode",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "TreeGridNode",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,203,106,195,48,16,69,215,246,87,168,89,73,80,68,246,166,133,60,139,161,148,144,71,187,8,89,40,246,36,86,177,165,84,143,164,161,228,223,43,75,110,221,54,129,80,240,194,186,154,57,119,174,152,61,83,72,67,9,153,65,119,72,192,1,205,252,1,79,216,22,232,66,131,26,72,33,156,192,165,32,113,20,209,129,44,109,37,240,216,138,204,253,91,97,240,148,111,11,163,103,89,1,21,123,98,21,220,162,78,154,119,136,175,30,43,89,157,21,248,155,151,2,20,92,234,157,217,245,171,243,107,181,14,161,169,30,189,89,86,226,96,78,39,76,57,221,128,194,58,20,123,42,65,76,55,211,39,49,223,32,124,51,43,228,33,56,244,143,13,150,160,143,56,10,121,105,79,228,23,7,56,234,94,94,113,177,16,220,212,65,104,42,206,140,53,198,210,243,150,43,18,44,219,43,66,146,248,228,7,176,187,137,212,220,63,221,117,219,175,82,31,247,17,180,62,79,203,13,84,223,196,218,5,65,169,225,159,232,7,5,172,134,93,167,199,86,115,177,69,120,239,86,36,95,143,222,33,179,70,42,183,38,191,215,130,142,132,182,10,134,253,86,194,196,7,254,209,239,76,115,168,123,155,73,3,13,166,94,198,45,61,52,70,245,235,133,22,90,151,52,188,40,82,96,172,18,127,7,24,246,231,199,29,56,97,15,202,37,113,231,103,86,90,152,203,212,173,103,192,44,187,43,130,238,81,55,113,148,83,236,190,83,220,176,54,204,189,97,242,9,252,194,82,136,7,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeterminePositionForMoveMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("31a7abe5-d673-45fd-8844-4821bd04ea19"),
				Name = "DeterminePositionForMove",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "int"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("27e38849-f82e-4a96-9ec2-2a35c0fcda1d"),
				Name = "sourcePosition",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bbeaa68e-43d1-47f6-8a82-3b4cef786f7d"),
				Name = "doIncreasePosition",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("18e3ed7e-ea2f-417a-998d-85c93ca863a7"),
				Name = "sourceSubjectName",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,48,176,6,0,192,147,116,237,9,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSelectForVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8243f7bb-57db-42f4-9954-155c8f433e69"),
				Name = "GetSelectForVirtualDataSource",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Select"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("28bdc51a-8ce9-4ad7-abcf-428da824f033"),
				Name = "objectParameters",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,8,78,205,73,77,46,209,8,72,76,79,213,11,45,78,45,114,206,207,203,3,10,100,230,231,105,90,3,0,95,134,191,37,39,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEnableButtonsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("df10e081-6b47-4461-8107-6e46775b58d1"),
				Name = "EnableButtons",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fe3c8e9f-b811-4f40-ac4d-4fbb73daf626"),
				Name = "recordsCount",
				CreatedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				ModifiedInSchemaUId = new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,205,73,45,73,117,42,45,41,201,207,211,115,205,75,76,202,73,77,81,176,85,208,40,74,77,206,47,74,41,118,206,47,205,43,81,176,83,48,208,84,80,83,83,240,72,44,14,202,76,207,40,41,118,203,47,114,206,72,204,75,79,213,208,180,230,10,0,153,19,90,64,208,12,67,66,102,184,228,151,231,81,98,10,0,21,97,171,40,209,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseAdministrativeGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76aeeb1b-9c5c-42c3-ba5d-b92b6b225a7f"));
		}

		#endregion

	}

	#endregion

}

