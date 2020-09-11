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
	using Terrasoft.Configuration.ImportExcelData;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: NewLookupDataGridPageSchema

	/// <exclude/>
	public class NewLookupDataGridPageSchema : Terrasoft.WebApp.BaseVirtualGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bottomButtonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomButtonsControlLayout {
			get {
				return _bottomButtonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _bindToLookupDataButton;
		public Terrasoft.UI.WebControls.Controls.Button BindToLookupDataButton {
			get {
				return _bindToLookupDataButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addToLookupButton;
		public Terrasoft.UI.WebControls.Controls.Button AddToLookupButton {
			get {
				return _addToLookupButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addSelectedButton;
		public Terrasoft.UI.WebControls.Controls.Button AddSelectedButton {
			get {
				return _addSelectedButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _selectAllButton;
		public Terrasoft.UI.WebControls.Controls.Button SelectAllButton {
			get {
				return _selectAllButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addEmployeeButton;
		public Terrasoft.UI.WebControls.Controls.Button AddEmployeeButton {
			get {
				return _addEmployeeButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _ignoreEmployeeButton;
		public Terrasoft.UI.WebControls.Controls.Button IgnoreEmployeeButton {
			get {
				return _ignoreEmployeeButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _oKButton;
		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return _oKButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _closeButton;
		public Terrasoft.UI.WebControls.Controls.Button CloseButton {
			get {
				return _closeButton;
			}
		}

		#endregion

		#region Constructors: Public

		public NewLookupDataGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public NewLookupDataGridPageSchema(NewLookupDataGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {};
			PrintButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			RealUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			Name = "NewLookupDataGridPage";
			ParentSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 800;
			Height = 400;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateNewLookupDataGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateButtonsControlLayout();
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
			ButtonsControlLayout.MoveItem(4, Spacer);
			ButtonsControlLayout.MoveItem(5, PrintButton);
			ButtonsControlLayout.MoveItem(6, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			Controls.AddAt(2, CreateBottomButtonsControlLayout());
			BottomButtonsControlLayout.InsertItem(0, CreateBindToLookupDataButton());
			BottomButtonsControlLayout.InsertItem(1, CreateAddToLookupButton());
			BottomButtonsControlLayout.InsertItem(2, CreateAddSelectedButton());
			BottomButtonsControlLayout.InsertItem(3, CreateSelectAllButton());
			BottomButtonsControlLayout.InsertItem(4, CreateAddEmployeeButton());
			BottomButtonsControlLayout.InsertItem(5, CreateIgnoreEmployeeButton());
			BottomButtonsControlLayout.InsertItem(6, CreateSpacer1());
			BottomButtonsControlLayout.InsertItem(7, CreateOKButton());
			BottomButtonsControlLayout.InsertItem(8, CreateCloseButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateNewLookupDataGridPageEventsProcessSchema() {
			var schema = new NewLookupDataGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateBindToLookupDataButton() {
			_bindToLookupDataButton = new Terrasoft.UI.WebControls.Controls.Button();
			_bindToLookupDataButton.UId = new Guid("87ad14e6-5105-498f-9a41-735db7ab7f56");
			_bindToLookupDataButton.Name = "BindToLookupDataButton";
			_bindToLookupDataButton.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_bindToLookupDataButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_bindToLookupDataButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bindToLookupDataButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_bindToLookupDataButton.Tag = "";
			_bindToLookupDataButton.Image = new ControlImage {};
			return _bindToLookupDataButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddToLookupButton() {
			_addToLookupButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addToLookupButton.UId = new Guid("22d0c176-5551-4ff3-ae72-28045101620b");
			_addToLookupButton.Name = "AddToLookupButton";
			_addToLookupButton.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_addToLookupButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_addToLookupButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addToLookupButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addToLookupButton.Tag = "";
			_addToLookupButton.Image = new ControlImage {};
			_addToLookupButton.Enabled = false;
			_addToLookupButton.Hidden = true;
			return _addToLookupButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddSelectedButton() {
			_addSelectedButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addSelectedButton.UId = new Guid("2f21afcc-1cbc-4373-bb5a-28401a447133");
			_addSelectedButton.Name = "AddSelectedButton";
			_addSelectedButton.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_addSelectedButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_addSelectedButton.CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca");
			_addSelectedButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addSelectedButton.AjaxEvents.Click.ShowLoadMask = true;
			_addSelectedButton.Tag = "";
			_addSelectedButton.Image = new ControlImage {};
			return _addSelectedButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSelectAllButton() {
			_selectAllButton = new Terrasoft.UI.WebControls.Controls.Button();
			_selectAllButton.UId = new Guid("fde8c01f-43e8-4974-a79e-4e56303bf80d");
			_selectAllButton.Name = "SelectAllButton";
			_selectAllButton.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_selectAllButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_selectAllButton.CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca");
			_selectAllButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_selectAllButton.AjaxEvents.Click.ShowLoadMask = true;
			_selectAllButton.Tag = "";
			_selectAllButton.Image = new ControlImage {};
			return _selectAllButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddEmployeeButton() {
			_addEmployeeButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addEmployeeButton.UId = new Guid("1ffed68d-96fa-4e27-88da-aaffb019ef5f");
			_addEmployeeButton.Name = "AddEmployeeButton";
			_addEmployeeButton.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_addEmployeeButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_addEmployeeButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addEmployeeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addEmployeeButton.Tag = "";
			_addEmployeeButton.Image = new ControlImage {};
			_addEmployeeButton.Hidden = true;
			return _addEmployeeButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateIgnoreEmployeeButton() {
			_ignoreEmployeeButton = new Terrasoft.UI.WebControls.Controls.Button();
			_ignoreEmployeeButton.UId = new Guid("867623fc-8150-4021-8226-ad4d3d502f2d");
			_ignoreEmployeeButton.Name = "IgnoreEmployeeButton";
			_ignoreEmployeeButton.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_ignoreEmployeeButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_ignoreEmployeeButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_ignoreEmployeeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_ignoreEmployeeButton.Tag = "";
			_ignoreEmployeeButton.Image = new ControlImage {};
			_ignoreEmployeeButton.Hidden = true;
			return _ignoreEmployeeButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("e3560b7c-dfc3-4ce0-9f6d-bcd7d9131aa5");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_spacer1.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOKButton() {
			_oKButton = new Terrasoft.UI.WebControls.Controls.Button();
			_oKButton.UId = new Guid("4f91d4fd-de0b-4142-a258-2ea9af86e384");
			_oKButton.Name = "OKButton";
			_oKButton.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_oKButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_oKButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_oKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_oKButton.Tag = "";
			_oKButton.Image = new ControlImage {};
			_oKButton.AutoWidth = false;
			_oKButton.Hidden = true;
			return _oKButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCloseButton() {
			_closeButton = new Terrasoft.UI.WebControls.Controls.Button();
			_closeButton.UId = new Guid("ec78a928-6dd7-4bb3-9c50-6fe3b43c862f");
			_closeButton.Name = "CloseButton";
			_closeButton.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_closeButton.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_closeButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_closeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_closeButton.Tag = "";
			_closeButton.Image = new ControlImage {};
			return _closeButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBottomButtonsControlLayout() {
			_bottomButtonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bottomButtonsControlLayout.UId = new Guid("7becf4aa-613f-4ac7-9c61-b0cdc9c75591");
			_bottomButtonsControlLayout.Name = "BottomButtonsControlLayout";
			_bottomButtonsControlLayout.CreatedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_bottomButtonsControlLayout.ModifiedInSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			_bottomButtonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bottomButtonsControlLayout.Tag = "";
			_bottomButtonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_bottomButtonsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_bottomButtonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_bottomButtonsControlLayout.FitHeightByContent = true;
			_bottomButtonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(400);
			_bottomButtonsControlLayout.StartNewAlignGroup = false;
			_bottomButtonsControlLayout.Image = new ControlImage {};
			_bottomButtonsControlLayout.Edges = "";
			return _bottomButtonsControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new NewLookupDataGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new NewLookupDataGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new NewLookupDataGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: NewLookupDataGridPageEventsProcess

	/// <exclude/>
	public class NewLookupDataGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseVirtualGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.NewLookupDataGridPageSchemaUserControl
	{

		#region Class: OpenLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskFlowElement(UserConnection userConnection, NewLookupDataGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("dd5890c1-9ec7-4087-96a1-c93db268b246");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskAddOpenWindowFlowElement

		/// <exclude/>
		public class UserTaskAddOpenWindowFlowElement : OpenPageUserTask
		{

			public UserTaskAddOpenWindowFlowElement(UserConnection userConnection, NewLookupDataGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskAddOpenWindow";
				IsLogging = false;
				SchemaElementUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public NewLookupDataGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "NewLookupDataGridPageEventsProcess";
			SchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
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

		public virtual Guid DefValuesId {
			get;
			set;
		}

		public virtual Guid EntityPrimaryColumnValue {
			get;
			set;
		}

		public virtual bool IsOneFieldRequired {
			get;
			set;
		}

		public virtual Guid ExcelImportId {
			get;
			set;
		}

		public virtual Object IsAddIds {
			get;
			set;
		}

		public virtual bool IsSyncLookupConflicts {
			get;
			set;
		}

		private string _employeeSchemaId;
		public virtual string EmployeeSchemaId {
			get {
				return _employeeSchemaId ?? (_employeeSchemaId = new LocalizableString(Storage, "aa6ed9eab0814ec4a1f001d01a38b2a8",
						 "EventsProcessSchema.Parameters.EmployeeSchemaId.Value"));
			}
			set {
				_employeeSchemaId = value;
			}
		}

		public virtual Object EntitySchemaCache {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("701201d6-4cc2-4aa0-bdea-e83f40bb78e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childPageLoadCompleteStartMessage;
		public ProcessFlowElement ChildPageLoadCompleteStartMessage {
			get {
				return _childPageLoadCompleteStartMessage ?? (_childPageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildPageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("f1fec528-c7c4-442d-af55-47e628aa519a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _basePageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent BasePageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _basePageLoadCompleteIntermediateThrowMessageEvent ?? (_basePageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BasePageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("67ac5eb9-aca9-4ce9-b9b5-4997f43b8926"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childPageLoadCompleteScript;
		public ProcessScriptTask ChildPageLoadCompleteScript {
			get {
				return _childPageLoadCompleteScript ?? (_childPageLoadCompleteScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildPageLoadCompleteScript",
					SchemaElementUId = new Guid("5330a54e-7844-45a9-a6ae-53f91fac4c3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildPageLoadCompleteScriptExecute,
				});
			}
		}

		private ProcessFlowElement _bindToLookupDataButtonClickEventSubProcess;
		public ProcessFlowElement BindToLookupDataButtonClickEventSubProcess {
			get {
				return _bindToLookupDataButtonClickEventSubProcess ?? (_bindToLookupDataButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BindToLookupDataButtonClickEventSubProcess",
					SchemaElementUId = new Guid("ceb082c5-f5de-4934-bf9a-d8f2e1441ced"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _bindToLookupDataButtonClickStartMessage;
		public ProcessFlowElement BindToLookupDataButtonClickStartMessage {
			get {
				return _bindToLookupDataButtonClickStartMessage ?? (_bindToLookupDataButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BindToLookupDataButtonClickStartMessage",
					SchemaElementUId = new Guid("abc58427-9e18-435e-a16a-06ca0af2f13e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _bindToLookupDataButtonClickScript;
		public ProcessScriptTask BindToLookupDataButtonClickScript {
			get {
				return _bindToLookupDataButtonClickScript ?? (_bindToLookupDataButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BindToLookupDataButtonClickScript",
					SchemaElementUId = new Guid("554e7707-07fd-474e-8ede-17b581e46f3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BindToLookupDataButtonClickScriptExecute,
				});
			}
		}

		private OpenLookupUserTaskFlowElement _openLookupUserTask;
		public OpenLookupUserTaskFlowElement OpenLookupUserTask {
			get {
				return _openLookupUserTask ?? (_openLookupUserTask = new OpenLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _lookupGridPageClosed;
		public ProcessIntermediateCatchMessageEvent LookupGridPageClosed {
			get {
				return _lookupGridPageClosed ?? (_lookupGridPageClosed = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "LookupGridPageClosed",
					SchemaElementUId = new Guid("fabbb787-7989-4168-910f-cade345f0810"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _updateRowInTreeGridScript;
		public ProcessScriptTask UpdateRowInTreeGridScript {
			get {
				return _updateRowInTreeGridScript ?? (_updateRowInTreeGridScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateRowInTreeGridScript",
					SchemaElementUId = new Guid("1e051ed1-3b31-4092-954d-41b7b91c863b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRowInTreeGridScriptExecute,
				});
			}
		}

		private ProcessScriptTask _resolveConflictsScriptTask2;
		public ProcessScriptTask ResolveConflictsScriptTask2 {
			get {
				return _resolveConflictsScriptTask2 ?? (_resolveConflictsScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ResolveConflictsScriptTask2",
					SchemaElementUId = new Guid("8ddea3d9-a4f3-47e0-b511-595f5b618389"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ResolveConflictsScriptTask2Execute,
				});
			}
		}

		private ProcessFlowElement _addToLookupButtonClickEventSubProcess;
		public ProcessFlowElement AddToLookupButtonClickEventSubProcess {
			get {
				return _addToLookupButtonClickEventSubProcess ?? (_addToLookupButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AddToLookupButtonClickEventSubProcess",
					SchemaElementUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addToLookupButtonClickStartMessage;
		public ProcessFlowElement AddToLookupButtonClickStartMessage {
			get {
				return _addToLookupButtonClickStartMessage ?? (_addToLookupButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddToLookupButtonClickStartMessage",
					SchemaElementUId = new Guid("ad532f3f-6bf6-4e25-a460-8f0b3d207028"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addToLookupButtonClickScript;
		public ProcessScriptTask AddToLookupButtonClickScript {
			get {
				return _addToLookupButtonClickScript ?? (_addToLookupButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddToLookupButtonClickScript",
					SchemaElementUId = new Guid("65850628-bbaf-465b-b7b6-65b94e6c95a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddToLookupButtonClickScriptExecute,
				});
			}
		}

		private UserTaskAddOpenWindowFlowElement _userTaskAddOpenWindow;
		public UserTaskAddOpenWindowFlowElement UserTaskAddOpenWindow {
			get {
				return _userTaskAddOpenWindow ?? (_userTaskAddOpenWindow = new UserTaskAddOpenWindowFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("010b051c-382a-4290-9642-3998d7cc8a4d"),
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

		private ProcessScriptTask _addToLookupDataClickScript;
		public ProcessScriptTask AddToLookupDataClickScript {
			get {
				return _addToLookupDataClickScript ?? (_addToLookupDataClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddToLookupDataClickScript",
					SchemaElementUId = new Guid("f85f08c1-e203-47dc-aad0-8034a3a46a17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddToLookupDataClickScriptExecute,
				});
			}
		}

		private ProcessScriptTask _checkRequiredFieldsScript;
		public ProcessScriptTask CheckRequiredFieldsScript {
			get {
				return _checkRequiredFieldsScript ?? (_checkRequiredFieldsScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckRequiredFieldsScript",
					SchemaElementUId = new Guid("5ad98d8e-20b1-40a3-ae3c-a0eb59e4ce7b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckRequiredFieldsScriptExecute,
				});
			}
		}

		private ProcessScriptTask _resolveConflictsScriptTask;
		public ProcessScriptTask ResolveConflictsScriptTask {
			get {
				return _resolveConflictsScriptTask ?? (_resolveConflictsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ResolveConflictsScriptTask",
					SchemaElementUId = new Guid("97338d58-bc55-4bcd-80f2-7231ad720eb6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ResolveConflictsScriptTaskExecute,
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
					SchemaElementUId = new Guid("842cab6d-cc04-48c8-af15-6471e105f2b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "AddNewDataInTreeGrid",
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _userTaskAddOpenWindowClosedIntermediateCatchMessageEvent;
		public ProcessIntermediateCatchMessageEvent UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent {
			get {
				return _userTaskAddOpenWindowClosedIntermediateCatchMessageEvent ?? (_userTaskAddOpenWindowClosedIntermediateCatchMessageEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent",
					SchemaElementUId = new Guid("ce5e0970-6d5d-4b31-a6c2-bb067f3255e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "UserTaskAddOpenWindowClosed",
				});
			}
		}

		private ProcessFlowElement _treeGridDblClickEventSubProcess;
		public ProcessFlowElement TreeGridDblClickEventSubProcess {
			get {
				return _treeGridDblClickEventSubProcess ?? (_treeGridDblClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "TreeGridDblClickEventSubProcess",
					SchemaElementUId = new Guid("82cfbd51-03d7-4b94-88dc-01868295ce9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _treeGridDblClickStartMessage;
		public ProcessFlowElement TreeGridDblClickStartMessage {
			get {
				return _treeGridDblClickStartMessage ?? (_treeGridDblClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridDblClickStartMessage",
					SchemaElementUId = new Guid("bc74c068-f395-4df4-a0b2-3ec44d4d0e96"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _bindToLookupDataButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent BindToLookupDataButtonClickIntermediateThrowMessageEvent {
			get {
				return _bindToLookupDataButtonClickIntermediateThrowMessageEvent ?? (_bindToLookupDataButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BindToLookupDataButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("815fe998-f3ec-452d-b6bd-afae62bf5f49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BindToLookupDataButtonClick",
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
					SchemaElementUId = new Guid("b870be96-d481-441c-a2fd-0fff39a3061b"),
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

		private ProcessThrowMessageEvent _openContactEditPageEventIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OpenContactEditPageEventIntermediateThrowMessageEvent {
			get {
				return _openContactEditPageEventIntermediateThrowMessageEvent ?? (_openContactEditPageEventIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OpenContactEditPageEventIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("0bb18869-bce6-4b9f-be64-d92c24fbb5c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OpenContactEditPageEvent",
				});
			}
		}

		private ProcessExclusiveGateway _treeGridRowSelectedCheck;
		public ProcessExclusiveGateway TreeGridRowSelectedCheck {
			get {
				return _treeGridRowSelectedCheck ?? (_treeGridRowSelectedCheck = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "TreeGridRowSelectedCheck",
					SchemaElementUId = new Guid("71c3d040-c61e-4f1e-b283-f46f8403c8e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.TreeGridRowSelectedCheck.Question"),
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
					SchemaElementUId = new Guid("79cd02d7-6cda-48a7-9302-03cf41ec5463"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickEventSubProcess;
		public ProcessFlowElement CancelButtonClickEventSubProcess {
			get {
				return _cancelButtonClickEventSubProcess ?? (_cancelButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CancelButtonClickEventSubProcess",
					SchemaElementUId = new Guid("093271d1-9461-4aa2-aa16-dbfd648d6ef8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _closeButtonClickStartMessage;
		public ProcessFlowElement CloseButtonClickStartMessage {
			get {
				return _closeButtonClickStartMessage ?? (_closeButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CloseButtonClickStartMessage",
					SchemaElementUId = new Guid("da7f96e6-8ed5-48ac-91bd-4d562fb2c7fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _cancelButtonClickScript;
		public ProcessScriptTask CancelButtonClickScript {
			get {
				return _cancelButtonClickScript ?? (_cancelButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CancelButtonClickScript",
					SchemaElementUId = new Guid("d1991b1e-6198-4c54-9652-2810df80429c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptExecute,
				});
			}
		}

		private ProcessFlowElement _addNewDataInTreeGridEventSubProcess;
		public ProcessFlowElement AddNewDataInTreeGridEventSubProcess {
			get {
				return _addNewDataInTreeGridEventSubProcess ?? (_addNewDataInTreeGridEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AddNewDataInTreeGridEventSubProcess",
					SchemaElementUId = new Guid("1cdc1444-3a70-4937-b600-2dc0ba908dce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addNewDataInTreeGridStartMessage;
		public ProcessFlowElement AddNewDataInTreeGridStartMessage {
			get {
				return _addNewDataInTreeGridStartMessage ?? (_addNewDataInTreeGridStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddNewDataInTreeGridStartMessage",
					SchemaElementUId = new Guid("071f2c46-cfc3-44aa-b0c2-1a393c6350d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addNewDataInTreeGridScript;
		public ProcessScriptTask AddNewDataInTreeGridScript {
			get {
				return _addNewDataInTreeGridScript ?? (_addNewDataInTreeGridScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddNewDataInTreeGridScript",
					SchemaElementUId = new Guid("b8866549-72b2-4083-8ea4-7f852f8ecc29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddNewDataInTreeGridScriptExecute,
				});
			}
		}

		private ProcessFlowElement _addEmployeeEventSubProcess;
		public ProcessFlowElement AddEmployeeEventSubProcess {
			get {
				return _addEmployeeEventSubProcess ?? (_addEmployeeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AddEmployeeEventSubProcess",
					SchemaElementUId = new Guid("bbf1ab37-9bdc-4a3a-b831-45c7b5274116"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addEmployeeClickStartMessage;
		public ProcessFlowElement AddEmployeeClickStartMessage {
			get {
				return _addEmployeeClickStartMessage ?? (_addEmployeeClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddEmployeeClickStartMessage",
					SchemaElementUId = new Guid("d5027e3c-a61e-4af0-95a1-05ae386a1971"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addEmployeeScriptTask;
		public ProcessScriptTask AddEmployeeScriptTask {
			get {
				return _addEmployeeScriptTask ?? (_addEmployeeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddEmployeeScriptTask",
					SchemaElementUId = new Guid("a6e71cae-49b1-4e3e-8368-39ee50da9160"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddEmployeeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _ignoreEmployeeButtonClickEventSubProcess;
		public ProcessFlowElement IgnoreEmployeeButtonClickEventSubProcess {
			get {
				return _ignoreEmployeeButtonClickEventSubProcess ?? (_ignoreEmployeeButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "IgnoreEmployeeButtonClickEventSubProcess",
					SchemaElementUId = new Guid("45998d3d-7a4d-4977-a5b1-6e4b75deab11"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _ignoreEmployeeButtonClickStartMessage1;
		public ProcessFlowElement IgnoreEmployeeButtonClickStartMessage1 {
			get {
				return _ignoreEmployeeButtonClickStartMessage1 ?? (_ignoreEmployeeButtonClickStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "IgnoreEmployeeButtonClickStartMessage1",
					SchemaElementUId = new Guid("2332c79f-25a6-433b-a093-a97b106f02ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _ignoreEmployeeButtonClickScriptTask;
		public ProcessScriptTask IgnoreEmployeeButtonClickScriptTask {
			get {
				return _ignoreEmployeeButtonClickScriptTask ?? (_ignoreEmployeeButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IgnoreEmployeeButtonClickScriptTask",
					SchemaElementUId = new Guid("1d9d30fd-48dd-4c6a-95a1-9cf6e049f556"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IgnoreEmployeeButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _oKButtonEventSubProcess;
		public ProcessFlowElement OKButtonEventSubProcess {
			get {
				return _oKButtonEventSubProcess ?? (_oKButtonEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OKButtonEventSubProcess",
					SchemaElementUId = new Guid("f2b2b853-1ba4-421a-a7ac-e3a685007431"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickStartMessage;
		public ProcessFlowElement OKButtonClickStartMessage {
			get {
				return _oKButtonClickStartMessage ?? (_oKButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClickStartMessage",
					SchemaElementUId = new Guid("ad9fa8e0-5911-4ccd-89c2-6d6e6f8ff557"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _oKButtonScriptTask;
		public ProcessScriptTask OKButtonScriptTask {
			get {
				return _oKButtonScriptTask ?? (_oKButtonScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OKButtonScriptTask",
					SchemaElementUId = new Guid("4f72b873-c5fb-488d-9b69-7658d7ff862b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OKButtonScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _addSelectedEventSubProcess;
		public ProcessFlowElement AddSelectedEventSubProcess {
			get {
				return _addSelectedEventSubProcess ?? (_addSelectedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AddSelectedEventSubProcess",
					SchemaElementUId = new Guid("07f3ed87-9b2a-43fc-99ea-31875cdd45a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addSelectedStartMessage;
		public ProcessFlowElement AddSelectedStartMessage {
			get {
				return _addSelectedStartMessage ?? (_addSelectedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddSelectedStartMessage",
					SchemaElementUId = new Guid("4b3c4d85-c36d-4cb6-9f19-01aa74cffc43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addSelectedScriptTask;
		public ProcessScriptTask AddSelectedScriptTask {
			get {
				return _addSelectedScriptTask ?? (_addSelectedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddSelectedScriptTask",
					SchemaElementUId = new Guid("95e4541b-9b5f-49b2-9bce-376e030b5625"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddSelectedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _selectAllEventSubProcess;
		public ProcessFlowElement SelectAllEventSubProcess {
			get {
				return _selectAllEventSubProcess ?? (_selectAllEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SelectAllEventSubProcess",
					SchemaElementUId = new Guid("bc6c5e29-6c37-4336-bbb0-31ad22bc6d24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _selectAllStartMessage;
		public ProcessFlowElement SelectAllStartMessage {
			get {
				return _selectAllStartMessage ?? (_selectAllStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SelectAllStartMessage",
					SchemaElementUId = new Guid("6177b940-3aed-40d2-b293-b21a0bb0ae1a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _selectAllScriptTask;
		public ProcessScriptTask SelectAllScriptTask {
			get {
				return _selectAllScriptTask ?? (_selectAllScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SelectAllScriptTask",
					SchemaElementUId = new Guid("3bb979d6-b7e4-4d30-932e-c796ad0545ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SelectAllScriptTaskExecute,
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
					SchemaElementUId = new Guid("49f0ecaa-8b77-4a86-93e4-ac32c8e99aee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childPageInitStartMessage;
		public ProcessFlowElement ChildPageInitStartMessage {
			get {
				return _childPageInitStartMessage ?? (_childPageInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildPageInitStartMessage",
					SchemaElementUId = new Guid("98aa64f2-78b6-4e00-929e-afa665f1f74b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _basePageInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent BasePageInitIntermediateThrowMessageEvent {
			get {
				return _basePageInitIntermediateThrowMessageEvent ?? (_basePageInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BasePageInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("42173148-9348-40e8-8877-0a68140d3933"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childPageInitScript;
		public ProcessScriptTask ChildPageInitScript {
			get {
				return _childPageInitScript ?? (_childPageInitScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildPageInitScript",
					SchemaElementUId = new Guid("61498653-b55e-4dd5-ab48-26000399b566"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildPageInitScriptExecute,
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
					SchemaElementUId = new Guid("b6bb3489-0f16-4922-a276-6e0782d0d1b1"),
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
					SchemaElementUId = new Guid("d3e71e01-6a49-4e9c-9a80-b9416462e32e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("cb472cc3-945c-463b-8e35-1b2d4bba7cc5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _fileNameCaption;
		public LocalizableString FileNameCaption {
			get {
				return _fileNameCaption ?? (_fileNameCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FileNameCaption.Value"));
			}
		}

		private LocalizableString _lookupNameCaption;
		public LocalizableString LookupNameCaption {
			get {
				return _lookupNameCaption ?? (_lookupNameCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LookupNameCaption.Value"));
			}
		}

		private LocalizableString _columnCaption;
		public LocalizableString ColumnCaption {
			get {
				return _columnCaption ?? (_columnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ColumnCaption.Value"));
			}
		}

		private LocalizableString _lookupCaption;
		public LocalizableString LookupCaption {
			get {
				return _lookupCaption ?? (_lookupCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LookupCaption.Value"));
			}
		}

		private LocalizableString _pageCaption;
		public LocalizableString PageCaption {
			get {
				return _pageCaption ?? (_pageCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PageCaption.Value"));
			}
		}

		private LocalizableString _addNewLookupRecordLocalizableString;
		public LocalizableString AddNewLookupRecordLocalizableString {
			get {
				return _addNewLookupRecordLocalizableString ?? (_addNewLookupRecordLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AddNewLookupRecordLocalizableString.Value"));
			}
		}

		private LocalizableString _qBCaption;
		public LocalizableString QBCaption {
			get {
				return _qBCaption ?? (_qBCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.QBCaption.Value"));
			}
		}

		private LocalizableString _oneCCaption;
		public LocalizableString OneCCaption {
			get {
				return _oneCCaption ?? (_oneCCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OneCCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ChildPageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadCompleteStartMessage };
			FlowElements[BasePageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePageLoadCompleteIntermediateThrowMessageEvent };
			FlowElements[ChildPageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageLoadCompleteScript };
			FlowElements[BindToLookupDataButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BindToLookupDataButtonClickEventSubProcess };
			FlowElements[BindToLookupDataButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BindToLookupDataButtonClickStartMessage };
			FlowElements[BindToLookupDataButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { BindToLookupDataButtonClickScript };
			FlowElements[OpenLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTask };
			FlowElements[LookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosed };
			FlowElements[UpdateRowInTreeGridScript.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRowInTreeGridScript };
			FlowElements[ResolveConflictsScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ResolveConflictsScriptTask2 };
			FlowElements[AddToLookupButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AddToLookupButtonClickEventSubProcess };
			FlowElements[AddToLookupButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddToLookupButtonClickStartMessage };
			FlowElements[AddToLookupButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { AddToLookupButtonClickScript };
			FlowElements[UserTaskAddOpenWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskAddOpenWindow };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[AddToLookupDataClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { AddToLookupDataClickScript };
			FlowElements[CheckRequiredFieldsScript.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckRequiredFieldsScript };
			FlowElements[ResolveConflictsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ResolveConflictsScriptTask };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent };
			FlowElements[TreeGridDblClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickEventSubProcess };
			FlowElements[TreeGridDblClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickStartMessage };
			FlowElements[BindToLookupDataButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { BindToLookupDataButtonClickIntermediateThrowMessageEvent };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[OpenContactEditPageEventIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenContactEditPageEventIntermediateThrowMessageEvent };
			FlowElements[TreeGridRowSelectedCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridRowSelectedCheck };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[CancelButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickEventSubProcess };
			FlowElements[CloseButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseButtonClickStartMessage };
			FlowElements[CancelButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScript };
			FlowElements[AddNewDataInTreeGridEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AddNewDataInTreeGridEventSubProcess };
			FlowElements[AddNewDataInTreeGridStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddNewDataInTreeGridStartMessage };
			FlowElements[AddNewDataInTreeGridScript.SchemaElementUId] = new Collection<ProcessFlowElement> { AddNewDataInTreeGridScript };
			FlowElements[AddEmployeeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AddEmployeeEventSubProcess };
			FlowElements[AddEmployeeClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddEmployeeClickStartMessage };
			FlowElements[AddEmployeeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddEmployeeScriptTask };
			FlowElements[IgnoreEmployeeButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { IgnoreEmployeeButtonClickEventSubProcess };
			FlowElements[IgnoreEmployeeButtonClickStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { IgnoreEmployeeButtonClickStartMessage1 };
			FlowElements[IgnoreEmployeeButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { IgnoreEmployeeButtonClickScriptTask };
			FlowElements[OKButtonEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonEventSubProcess };
			FlowElements[OKButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickStartMessage };
			FlowElements[OKButtonScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonScriptTask };
			FlowElements[AddSelectedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSelectedEventSubProcess };
			FlowElements[AddSelectedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSelectedStartMessage };
			FlowElements[AddSelectedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSelectedScriptTask };
			FlowElements[SelectAllEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectAllEventSubProcess };
			FlowElements[SelectAllStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectAllStartMessage };
			FlowElements[SelectAllScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectAllScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[ChildPageInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageInitStartMessage };
			FlowElements[BasePageInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePageInitIntermediateThrowMessageEvent };
			FlowElements[ChildPageInitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildPageInitScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ChildPageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("BasePageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "BasePageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ChildPageLoadCompleteScript");
						break;
					case "ChildPageLoadCompleteScript":
						break;
					case "BindToLookupDataButtonClickEventSubProcess":
						break;
					case "BindToLookupDataButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("BindToLookupDataButtonClickScript");
						break;
					case "BindToLookupDataButtonClickScript":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTask");
						break;
					case "OpenLookupUserTask":
						ActivatedEventElements.Add("LookupGridPageClosed");
						break;
					case "LookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("UpdateRowInTreeGridScript");
						break;
					case "UpdateRowInTreeGridScript":
						e.Context.QueueTasks.Enqueue("ResolveConflictsScriptTask2");
						break;
					case "ResolveConflictsScriptTask2":
						break;
					case "AddToLookupButtonClickEventSubProcess":
						break;
					case "AddToLookupButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CheckRequiredFieldsScript");
						break;
					case "AddToLookupButtonClickScript":
						e.Context.QueueTasks.Enqueue("UserTaskAddOpenWindow");
						break;
					case "UserTaskAddOpenWindow":
						ActivatedEventElements.Add("UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("AddToLookupButtonClickScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("AddToLookupDataClickScript");
						break;
					case "AddToLookupDataClickScript":
						e.Context.QueueTasks.Enqueue("ResolveConflictsScriptTask");
						break;
					case "CheckRequiredFieldsScript":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ResolveConflictsScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent":
						e.Context.QueueTasks.Enqueue("ResolveConflictsScriptTask");
						break;
					case "TreeGridDblClickEventSubProcess":
						break;
					case "TreeGridDblClickStartMessage":
						e.Context.QueueTasks.Enqueue("TreeGridRowSelectedCheck");
						break;
					case "BindToLookupDataButtonClickIntermediateThrowMessageEvent":
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OpenContactEditPageEventIntermediateThrowMessageEvent");
							break;
						}
						e.Context.QueueTasks.Enqueue("BindToLookupDataButtonClickIntermediateThrowMessageEvent");
						break;
					case "OpenContactEditPageEventIntermediateThrowMessageEvent":
						break;
					case "TreeGridRowSelectedCheck":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
							break;
						}
							e.Context.QueueTasks.Enqueue("End1");
						break;
					case "End1":
						break;
					case "CancelButtonClickEventSubProcess":
						break;
					case "CloseButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScript");
						break;
					case "CancelButtonClickScript":
						break;
					case "AddNewDataInTreeGridEventSubProcess":
						break;
					case "AddNewDataInTreeGridStartMessage":
						e.Context.QueueTasks.Enqueue("AddNewDataInTreeGridScript");
						break;
					case "AddNewDataInTreeGridScript":
						break;
					case "AddEmployeeEventSubProcess":
						break;
					case "AddEmployeeClickStartMessage":
						e.Context.QueueTasks.Enqueue("AddEmployeeScriptTask");
						break;
					case "AddEmployeeScriptTask":
						break;
					case "IgnoreEmployeeButtonClickEventSubProcess":
						break;
					case "IgnoreEmployeeButtonClickStartMessage1":
						e.Context.QueueTasks.Enqueue("IgnoreEmployeeButtonClickScriptTask");
						break;
					case "IgnoreEmployeeButtonClickScriptTask":
						break;
					case "OKButtonEventSubProcess":
						break;
					case "OKButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OKButtonScriptTask");
						break;
					case "OKButtonScriptTask":
						break;
					case "AddSelectedEventSubProcess":
						break;
					case "AddSelectedStartMessage":
						e.Context.QueueTasks.Enqueue("AddSelectedScriptTask");
						break;
					case "AddSelectedScriptTask":
						break;
					case "SelectAllEventSubProcess":
						break;
					case "SelectAllStartMessage":
						e.Context.QueueTasks.Enqueue("SelectAllScriptTask");
						break;
					case "SelectAllScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "ChildPageInitStartMessage":
						e.Context.QueueTasks.Enqueue("BasePageInitIntermediateThrowMessageEvent");
						break;
					case "BasePageInitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ChildPageInitScript");
						break;
					case "ChildPageInitScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(!IsOneFieldRequired);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(IsContactSelected());
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean(Page.TreeGrid.SelectedNodes.Count > 0);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildPageLoadCompleteStartMessage");
			ActivatedEventElements.Add("BindToLookupDataButtonClickStartMessage");
			ActivatedEventElements.Add("AddToLookupButtonClickStartMessage");
			ActivatedEventElements.Add("TreeGridDblClickStartMessage");
			ActivatedEventElements.Add("CloseButtonClickStartMessage");
			ActivatedEventElements.Add("AddNewDataInTreeGridStartMessage");
			ActivatedEventElements.Add("AddEmployeeClickStartMessage");
			ActivatedEventElements.Add("IgnoreEmployeeButtonClickStartMessage1");
			ActivatedEventElements.Add("OKButtonClickStartMessage");
			ActivatedEventElements.Add("AddSelectedStartMessage");
			ActivatedEventElements.Add("SelectAllStartMessage");
			ActivatedEventElements.Add("ChildPageInitStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ChildPageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageLoadCompleteStartMessage";
					result = ChildPageLoadCompleteStartMessage.Execute(context);
					break;
				case "BasePageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = BasePageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ChildPageLoadCompleteScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageLoadCompleteScript";
					result = ChildPageLoadCompleteScript.Execute(context, ChildPageLoadCompleteScriptExecute);
					break;
				case "BindToLookupDataButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BindToLookupDataButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BindToLookupDataButtonClickStartMessage";
					result = BindToLookupDataButtonClickStartMessage.Execute(context);
					break;
				case "BindToLookupDataButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "BindToLookupDataButtonClickScript";
					result = BindToLookupDataButtonClickScript.Execute(context, BindToLookupDataButtonClickScriptExecute);
					break;
				case "OpenLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTask";
					result = OpenLookupUserTask.Execute(context);
					break;
				case "LookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupGridPageClosed";
					result = LookupGridPageClosed.Execute(context);
					break;
				case "UpdateRowInTreeGridScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRowInTreeGridScript";
					result = UpdateRowInTreeGridScript.Execute(context, UpdateRowInTreeGridScriptExecute);
					break;
				case "ResolveConflictsScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ResolveConflictsScriptTask2";
					result = ResolveConflictsScriptTask2.Execute(context, ResolveConflictsScriptTask2Execute);
					break;
				case "AddToLookupButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AddToLookupButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddToLookupButtonClickStartMessage";
					result = AddToLookupButtonClickStartMessage.Execute(context);
					break;
				case "AddToLookupButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddToLookupButtonClickScript";
					result = AddToLookupButtonClickScript.Execute(context, AddToLookupButtonClickScriptExecute);
					break;
				case "UserTaskAddOpenWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskAddOpenWindow";
					result = UserTaskAddOpenWindow.Execute(context);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "AddToLookupDataClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddToLookupDataClickScript";
					result = AddToLookupDataClickScript.Execute(context, AddToLookupDataClickScriptExecute);
					break;
				case "CheckRequiredFieldsScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckRequiredFieldsScript";
					result = CheckRequiredFieldsScript.Execute(context, CheckRequiredFieldsScriptExecute);
					break;
				case "ResolveConflictsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ResolveConflictsScriptTask";
					result = ResolveConflictsScriptTask.Execute(context, ResolveConflictsScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent";
					result = UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent.Execute(context);
					break;
				case "TreeGridDblClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "TreeGridDblClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClickStartMessage";
					result = TreeGridDblClickStartMessage.Execute(context);
					break;
				case "BindToLookupDataButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = BindToLookupDataButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "OpenContactEditPageEventIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = OpenContactEditPageEventIntermediateThrowMessageEvent.Execute(context);
					break;
				case "TreeGridRowSelectedCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridRowSelectedCheck";
					result = TreeGridRowSelectedCheck.Execute(context);
					break;
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CloseButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CloseButtonClickStartMessage";
					result = CloseButtonClickStartMessage.Execute(context);
					break;
				case "CancelButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickScript";
					result = CancelButtonClickScript.Execute(context, CancelButtonClickScriptExecute);
					break;
				case "AddNewDataInTreeGridEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AddNewDataInTreeGridStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddNewDataInTreeGridStartMessage";
					result = AddNewDataInTreeGridStartMessage.Execute(context);
					break;
				case "AddNewDataInTreeGridScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddNewDataInTreeGridScript";
					result = AddNewDataInTreeGridScript.Execute(context, AddNewDataInTreeGridScriptExecute);
					break;
				case "AddEmployeeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AddEmployeeClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddEmployeeClickStartMessage";
					result = AddEmployeeClickStartMessage.Execute(context);
					break;
				case "AddEmployeeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddEmployeeScriptTask";
					result = AddEmployeeScriptTask.Execute(context, AddEmployeeScriptTaskExecute);
					break;
				case "IgnoreEmployeeButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "IgnoreEmployeeButtonClickStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "IgnoreEmployeeButtonClickStartMessage1";
					result = IgnoreEmployeeButtonClickStartMessage1.Execute(context);
					break;
				case "IgnoreEmployeeButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "IgnoreEmployeeButtonClickScriptTask";
					result = IgnoreEmployeeButtonClickScriptTask.Execute(context, IgnoreEmployeeButtonClickScriptTaskExecute);
					break;
				case "OKButtonEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickStartMessage";
					result = OKButtonClickStartMessage.Execute(context);
					break;
				case "OKButtonScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonScriptTask";
					result = OKButtonScriptTask.Execute(context, OKButtonScriptTaskExecute);
					break;
				case "AddSelectedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AddSelectedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddSelectedStartMessage";
					result = AddSelectedStartMessage.Execute(context);
					break;
				case "AddSelectedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddSelectedScriptTask";
					result = AddSelectedScriptTask.Execute(context, AddSelectedScriptTaskExecute);
					break;
				case "SelectAllEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SelectAllStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectAllStartMessage";
					result = SelectAllStartMessage.Execute(context);
					break;
				case "SelectAllScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectAllScriptTask";
					result = SelectAllScriptTask.Execute(context, SelectAllScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ChildPageInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageInitStartMessage";
					result = ChildPageInitStartMessage.Execute(context);
					break;
				case "BasePageInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = BasePageInitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ChildPageInitScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildPageInitScript";
					result = ChildPageInitScript.Execute(context, ChildPageInitScriptExecute);
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
				case "EmployeeSchemaId":
					EmployeeSchemaId = reader.GetValue<System.String>();
				break;
				case "IsSyncLookupConflicts":
					IsSyncLookupConflicts = reader.GetValue<System.Boolean>();
				break;
				case "IsAddIds":
					IsAddIds = reader.GetSerializableObjectValue();
				break;
				case "ExcelImportId":
					ExcelImportId = reader.GetValue<System.Guid>();
				break;
				case "IsOneFieldRequired":
					IsOneFieldRequired = reader.GetValue<System.Boolean>();
				break;
				case "EntityPrimaryColumnValue":
					EntityPrimaryColumnValue = reader.GetValue<System.Guid>();
				break;
				case "DefValuesId":
					DefValuesId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ChildPageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			object isSyncLookupConflicts = UserConnection.SessionData["IsSyncLookupConflicts"];
			if (isSyncLookupConflicts != null) {
				IsSyncLookupConflicts = (bool)isSyncLookupConflicts;
				
			} else {
				IsSyncLookupConflicts = false;
			}
			if (IsSyncLookupConflicts) {
				Page.OKButton.Hidden = true;
				VirtualDataSource dataSource = GetDataSource();
				
				var entitiesToFillVirtualDS = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
						KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
				if (entitiesToFillVirtualDS == null) {
					entitiesToFillVirtualDS = new List<Tuple<Guid, string, string, string, string, 
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>();
				}
				
				var addEmployeeBtn = Page.AddEmployeeButton;
				var ignoreEmployeeBtn = Page.IgnoreEmployeeButton;
				var addToLookupBtn = Page.AddToLookupButton;
				var bindToLookupDataBtn = Page.BindToLookupDataButton;
				if (entitiesToFillVirtualDS.Count > 0) {	
					
					string buttonsLayoutID = Page.BottomButtonsControlLayout.ClientID;
					string addEmployeeBtnID = addEmployeeBtn.ClientID;
					string ignoreEmployeeBtnID = ignoreEmployeeBtn.ClientID;
					string addToLookupBtnID = addToLookupBtn.ClientID;
					string bindToLookupDataBtnID = bindToLookupDataBtn.ClientID;
						
					/*
					var dsSchemaId = entitiesToFillVirtualDS[0].Item6.Key.ToString();
					bool isEmployee = (dsSchemaId == EmployeeSchemaId);
					addToLookupBtn.Hidden = bindToLookupDataBtn.Hidden = isEmployee;
					addEmployeeBtn.Hidden = ignoreEmployeeBtn.Hidden = !isEmployee;	
					*/
					
					Page.AddScript(@"function refreshButtonsState (row) {
						" + buttonsLayoutID + @".beginContentUpdate();
						if (row == null) {
							" + addEmployeeBtnID + @".setVisible(false);
							" + ignoreEmployeeBtnID + @".setVisible(false);
							" + addToLookupBtnID + @".setVisible(false);
							" + bindToLookupDataBtnID + @".setVisible(false);				
						} else if (row.getColumnValue('SchemaId') == '" + EmployeeSchemaId + @"') {
							" + addEmployeeBtnID + @".setVisible(true);
							" + ignoreEmployeeBtnID + @".setVisible(true);
							" + addToLookupBtnID + @".setVisible(false);
							" + bindToLookupDataBtnID + @".setVisible(false);
						} else {
							" + addEmployeeBtnID + @".setVisible(false);
							" + ignoreEmployeeBtnID + @".setVisible(false);
							" + addToLookupBtnID + @".setVisible(false);
							" + bindToLookupDataBtnID + @".setVisible(true);
						}
						" + buttonsLayoutID + @".endContentUpdate();
			
					}");
			/* ORIGINAL SCRIPT
					Page.AddScript(@"
					" + dataSource.ClientID + @".on('activerowchanged', function() {
						" + buttonsLayoutID + @".beginContentUpdate();
						if (" + dataSource.ClientID + @".activeRow.getColumnValue('SchemaId') == '" + EmployeeSchemaId + @"') {
							" + addEmployeeBtnID + @".setVisible(true);
							" + ignoreEmployeeBtnID + @".setVisible(true);
							" + addToLookupBtnID + @".setVisible(false);
							" + bindToLookupDataBtnID + @".setVisible(false);
						} else {
							" + addEmployeeBtnID + @".setVisible(false);
							" + ignoreEmployeeBtnID + @".setVisible(false);
							" + addToLookupBtnID + @".setVisible(true);
							" + bindToLookupDataBtnID + @".setVisible(true);
						}
						" + buttonsLayoutID + @".endContentUpdate();
					});
					");
			*/		
					Page.AddScript(@"" + dataSource.ClientID + @".on('activerowchanged', function() {
							refreshButtonsState(" + dataSource.ClientID + @".activeRow)
						});"
					);
				}
			}
			else {
				Page.OKButton.Hidden = false;
			}
			/*
			var ds = GetDataSource();
			ds.EnableServerActiveRow = true;
			*/
			FillData(null);
			/*
			if (ds.Rows.Count > 0)
				ds.SetActiveRow(ds.Rows[0]);
			*/	
			RefreshButtonsStates(null);
			
			UserConnection.SessionData["NewLookupDataPageSuccessfullyClosed"] = false;
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = PageCaption;
			object excelImportId = UserConnection.SessionData["ExcelImportId"];
			if (excelImportId != null) {
				ExcelImportId = (Guid)excelImportId;
			}
			IsAddIds = new List<Guid>();
			return true;
		}

		public virtual bool BindToLookupDataButtonClickScriptExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			OpenLookupUserTask.PageParameters = new Dictionary <string, object>();
			OpenLookupUserTask.UseCurrentActivePage = true;
			var pageParameters = (Dictionary <string, object>)OpenLookupUserTask.PageParameters;
			var entity = GetEntity(GetDataSource().ActiveRowPrimaryColumnValue);
			pageParameters.Add("schemaUId", entity.GetTypedColumnValue<Guid>("SchemaId"));
			pageParameters.Add("lookupGridPageCaption", entity.GetTypedColumnValue<string>("Lookup"));
			pageParameters.Add("multiSelectMode", false);
			return true;
		}

		public virtual bool UpdateRowInTreeGridScriptExecute(ProcessExecutingContext context) {
			var values = (Dictionary<string, object>)OpenLookupUserTask.GetSelectedValues(UserConnection);
			if (values.Count != 1) {
				return true;
			}
			var dataSource = GetDataSource();
			foreach (KeyValuePair<string, object> value in values) {
				var items = value.Value as Dictionary<string, object>;
				foreach (var item in items) {
					if (item.Key != "Name") {
						continue;
					}
					var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
							KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
					if (entities != null) {
						for (int i = 0; i < entities.Count; i++) {
							if (entities[i].Item1 == dataSource.ActiveRowPrimaryColumnValue) {
								entities[i] = new Tuple<Guid, string, string, string, string, 
									KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>> 
											(entities[i].Item1, entities[i].Item2, item.Value.ToString(), entities[i].Item4, 
												entities[i].Item5, entities[i].Item6, entities[i].Item7);
								UserConnection.SessionData["NewLookupData"] = entities;
								break;
							}
						}
					}
				}
			}
			//dataSource.LoadRow(dataSource.ActiveRowPrimaryColumnValue);
			return true;
		}

		public virtual bool ResolveConflictsScriptTask2Execute(ProcessExecutingContext context) {
			ResolveConflicts();
			FillData(null);
			//RefreshButtonsStates();
			return true;
		}

		public virtual bool AddToLookupButtonClickScriptExecute(ProcessExecutingContext context) {
			EntityPrimaryColumnValue = Guid.Empty;
			var dataSource = GetDataSource();
			var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			if (entities == null) {
				return true;
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var sysLookupEntitySchema = entitySchemaManager.GetInstanceByName("SysLookup");
			var sysModuleEntityEntitySchema = entitySchemaManager.GetInstanceByName("SysModuleEntity");
			var sysModuleEditEntitySchema = entitySchemaManager.GetInstanceByName("SysModuleEdit");
			foreach (var entity in entities) {
				if (entity.Item1 != dataSource.ActiveRowPrimaryColumnValue) {
					continue;
				}
				string recordId = Guid.Empty.ToString();
				var entitySchemaUId = entity.Item6.Key;
				var entitySchema = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
				var defValues = new Dictionary <string, object>();
				defValues.Add(entitySchema.PrimaryDisplayColumn.Name, entity.Item2);
				Guid defValuesId = Guid.NewGuid();
				DefValuesId = defValuesId;
				UserConnection.SessionData[defValuesId.ToString()] = defValues;
				var entityId = Guid.NewGuid();
				EntityPrimaryColumnValue = entityId;
				var parameters =  new Dictionary<string, string> {
					{"recordId", recordId},
					{"entitySchemaUId", entitySchemaUId.ToString()},
					{"defValuesId", defValuesId.ToString()},
					{"createWithUId", entityId.ToString()}
				};
				UserTaskAddOpenWindow.PageParameters = parameters;
				UserTaskAddOpenWindow.OpenerInstanceId = Page.Process.InstanceUId;
				UserTaskAddOpenWindow.UseCurrentActivePage = true;
				//UserTaskAddOpenWindow.CloseMessage = "AddNewDataInTreeGrid";
				UserTaskAddOpenWindow.CloseMessage = "UserTaskAddOpenWindowClosed";
				entitySchema = sysLookupEntitySchema;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name);
				var editPageColumn = entitySchemaQuery.AddColumn("SysEditPageSchemaUId");
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"SysEntitySchemaUId", entitySchemaUId));
				var entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entityCollection.Count > 0) {
					UserTaskAddOpenWindow.PageUId = entityCollection[0].GetTypedColumnValue<Guid>(editPageColumn.ValueQueryAlias);
				} else {
					entitySchema = sysModuleEntityEntitySchema;
					entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name);
					var idColumn = entitySchemaQuery.AddColumn(entitySchema.GetPrimaryColumnName());
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
						FilterComparisonType.Equal, "SysEntitySchemaUId", entitySchemaUId));
					entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
					if (entityCollection.Count > 0) {
						entitySchema = sysModuleEditEntitySchema; 
						entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name);
						var sysPageSchemaColumn = entitySchemaQuery.AddColumn("SysPageSchemaUId");
						entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
							FilterComparisonType.Equal, "SysModuleEntity", entityCollection[0].GetTypedColumnValue<Guid>(idColumn.Name)));
						entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
						if (entityCollection.Count > 0) {
							UserTaskAddOpenWindow.PageUId = entityCollection[0].GetTypedColumnValue<Guid>(sysPageSchemaColumn.ValueQueryAlias);
						}
					}
				}
				break;
			}
			return true;
		}

		public virtual bool AddToLookupDataClickScriptExecute(ProcessExecutingContext context) {
			LogInfo("AddToLookupDataClickScriptExecute_Start");
			var dataSource = GetDataSource();	
			
			var isAddIds = IsAddIds as List<Guid>;
			isAddIds.Add(dataSource.ActiveRowPrimaryColumnValue);
			Page.AddToLookupButton.Enabled = false;
			
			var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			if (entities != null) {
				for (int i = 0; i < entities.Count; i++) {
					if (entities[i].Item1 != dataSource.ActiveRowPrimaryColumnValue) {
						continue;
					}
					
					var entitySchemaManager = UserConnection.EntitySchemaManager;
					var entitySchema = entitySchemaManager.GetInstanceByUId(entities[i].Item6.Key); 
					var entity = entitySchema.CreateEntity(UserConnection);
					entity.SetDefColumnValues();
					entity.SetColumnValue(entitySchema.PrimaryColumn.Name, Guid.NewGuid());
					entity.SetColumnValue(entitySchema.PrimaryDisplayColumn.Name, entities[i].Item2);
					entity.Save();
					entities[i] = 	new Tuple<Guid, string, string, string, string, 
										KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>> 
												(entities[i].Item1, entities[i].Item2, entities[i].Item2, entities[i].Item4, 
													entities[i].Item5, entities[i].Item6, entities[i].Item7);
					UserConnection.SessionData["NewLookupData"] = entities;
					if (!IsSyncLookupConflicts) {
						string message = string.Format(AddNewLookupRecordLocalizableString, 
								"\"" + entities[i].Item5 + "\"", 
								"\"" + entities[i].Item2 + "\"");
						LogExcelImportLog(message);
						dataSource.LoadRow(dataSource.ActiveRowPrimaryColumnValue);
					}			
					break;
				}
			}
			LogInfo("AddToLookupDataClickScriptExecute_End");
			return true;
		}

		public virtual bool CheckRequiredFieldsScriptExecute(ProcessExecutingContext context) {
			IsOneFieldRequired = true;
			var dataSource = GetDataSource();	
			var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			if (entities != null) {
				for (int i = 0; i < entities.Count; i++) {
					if (entities[i].Item1 == dataSource.ActiveRowPrimaryColumnValue) {
						var entitySchemaManager = UserConnection.EntitySchemaManager;
						var entitySchema = entitySchemaManager.GetInstanceByUId(entities[i].Item6.Key);
						if (entitySchema != null) {
							var requiredFieldsCount = 0;
							var columns = entitySchema.Columns;
							foreach (var column in columns) {
								if (column.RequirementType != EntitySchemaColumnRequirementType.None) {
									requiredFieldsCount++;
								}
							}
							IsOneFieldRequired = requiredFieldsCount <= 2 || entitySchema.Name == "Employee";
						}
						break;
					}
				}
			}
			
			return true;
		}

		public virtual bool ResolveConflictsScriptTaskExecute(ProcessExecutingContext context) {
			ResolveConflicts();
			//RefreshButtonsStates();
			return true;
		}

		public virtual bool CancelButtonClickScriptExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t\t{0}\t\tClose window \"NewLookupDataPage\" (\"Cancel\" button pressed)", ExcelImportId));
			UserConnection.SessionData["NewLookupData"] = null;
			UserConnection.SessionData["IsSyncLookupConflicts"] = null;
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool AddNewDataInTreeGridScriptExecute(ProcessExecutingContext context) {
			var dataSource = GetDataSource();	
			/*if (dataSource.ActiveRow == null)
				return true;*/
			if (dataSource.ActiveRowPrimaryColumnValue == Guid.Empty) {
				return true;
			}
			
			// A.Iskhakov: the code below has been left because of ExcelImport. It need to be removed/refactored
			
			var isAddIds = IsAddIds as List<Guid>;
			isAddIds.Add(dataSource.ActiveRowPrimaryColumnValue);
			Page.AddToLookupButton.Enabled = false;
			var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			if (entities != null && EntityPrimaryColumnValue != Guid.Empty) {
				for (int i = 0; i < entities.Count; i++) {
					if (entities[i].Item1 == dataSource.ActiveRowPrimaryColumnValue) {
						var entitySchemaManager = UserConnection.EntitySchemaManager;
						var entitySchema = entitySchemaManager.GetInstanceByUId(entities[i].Item6.Key);
						var lookupEntity = entitySchema.CreateEntity(UserConnection);
						if (lookupEntity.FetchFromDB(EntityPrimaryColumnValue)) {
							entities[i] = 	new Tuple<Guid, string, string, string, string, 
								KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>> 
								(entities[i].Item1, lookupEntity.GetTypedColumnValue<string>(entitySchema.PrimaryDisplayColumn.Name), 
								lookupEntity.GetTypedColumnValue<string>(entitySchema.PrimaryDisplayColumn.Name), entities[i].Item4, 
								entities[i].Item5, entities[i].Item6, entities[i].Item7);
							
							var nowParameter = new QueryParameter("now", UserConnection.CurrentUser.GetCurrentDateTime(), "DateTime");
							var currentUserContactIdParameter = new QueryParameter("currentUserId",
								UserConnection.CurrentUser.ContactId);
							
							if (!IsSyncLookupConflicts) {
								string message = string.Format(AddNewLookupRecordLocalizableString, 
										"\"" + entities[i].Item5 + "\"", 
										"\"" + entities[i].Item2 + "\"");
								LogExcelImportLog(message);
							}
							//UserConnection.SessionData["NewLookupData"] = entities;
							break;
						}
					}
				}
			}
			
			//dataSource.LoadRow(GetDataSource().ActiveRowPrimaryColumnValue);
			//dataSource.LoadRows();
			UserConnection.SessionData.Remove(DefValuesId.ToString());
			FillData(null);
			return true;
		}

		public virtual bool AddEmployeeScriptTaskExecute(ProcessExecutingContext context) {
			if (!IsSyncLookupConflicts) {
				return false;	
			}
			if(Page.TreeGrid.SelectedNodes.Count == 0){
				return false;
			}
			var resolvedConflicts = new List<Guid>();
			var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
									KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			var removeItems = new List<Tuple<Guid, string, string, string, string, 
									KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>();
			foreach(var node in Page.TreeGrid.SelectedNodes) {
				if (node.Values["SchemaId"].ToString() != EmployeeSchemaId) {
					continue;
				}
			
				Select select = new Select(UserConnection)
					.Column("DestinationRecordId")
					.Column("Id")
					.From("LookupConflict")
					.Where("LookupSchemaName").IsEqual(Column.Parameter(node.Values["Lookup"]))
					.And("LookupSchemaDisplayColumnName").IsEqual(Column.Parameter(node.Values["Column"]))
					.And("LookupSchemaDisplayColumnValue").IsEqual(Column.Parameter(node.Values["FileName"]))
					.And().Exists(
						new Select(UserConnection)
							.Column("Id")
							.From("Contact")
							.Where("Contact", "Id").IsEqual("DestinationRecordId"))
					.And().Not().Exists(
						new Select(UserConnection)
							.Column("ContactId")
							.From("Employee")
							.Where("Employee", "ContactId").IsEqual("DestinationRecordId")) as Select;
				
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (var reader = select.ExecuteReader(dbExecutor)) {
						while(reader.Read()){
							Guid contactId = UserConnection.DBTypeConverter.DBValueToGuid(reader[0]);
							Guid conflictId = UserConnection.DBTypeConverter.DBValueToGuid(reader[1]);
							try {
								new Insert(UserConnection)
									.Into("Employee")
									.Set("ContactId", Column.Parameter(contactId))
								.Execute(dbExecutor);
							} catch(System.Data.Common.DbException dbException){
							}
							resolvedConflicts.Add(conflictId);
						}
					}
				}
				if (resolvedConflicts.Count > 0) {
					new Delete(UserConnection)
						.From("LookupConflict")
						.Where("Id").In(resolvedConflicts.Select(c => Column.Parameter(c).Parameter).ToArray())
					.Execute();
				}
				if (entities != null) {
					for (int i = 0; i < entities.Count; i++) {
						if (entities[i].Item1 == new Guid(node.Values["Id"].ToString())) {
							removeItems.Add(entities[i]);
							break;
						}
					}
				}
			}
			if (entities != null) {
				foreach (var item in removeItems) {
					entities.Remove(item);
				}
				UserConnection.SessionData["NewLookupData"] = entities;
			}
			FillData(null);
			RefreshButtonsStates(null);
			return true;
		}

		public virtual bool IgnoreEmployeeButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			if (!IsSyncLookupConflicts) {
				return false;	
			}
			if (Page.TreeGrid.SelectedNodes.Count == 0) {
				return false;
			}
			var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
									KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			var removeItems = new List<Tuple<Guid, string, string, string, string, 
									KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>();
			foreach(var node in Page.TreeGrid.SelectedNodes) {
				if (node.Values["SchemaId"].ToString() != EmployeeSchemaId) {
					continue;
				}		
				var recordUId = new Guid(node.Values["Id"].ToString());	
				new Delete(UserConnection)
					.From("LookupConflict")
					.Where("LookupSchemaName").IsEqual(Column.Parameter(node.Values["Lookup"]))
					.And("LookupSchemaDisplayColumnName").IsEqual(Column.Parameter(node.Values["Column"]))
					.And("LookupSchemaDisplayColumnValue").IsEqual(Column.Parameter(node.Values["FileName"]))
					//.Where("Id").IsEqual(Column.Parameter(recordUId, "Guid"))
				.Execute();		
				if (entities != null) {
					for (int i = 0; i < entities.Count; i++) {
						if (entities[i].Item1 == recordUId) {
							removeItems.Add(entities[i]);
							break;
						}
					}
				}
			}
			if (entities != null) {
				foreach (var item in removeItems) {
					entities.Remove(item);
				}
				UserConnection.SessionData["NewLookupData"] = entities;
			}
			FillData(null);
			RefreshButtonsStates(null);
			return true;
		}

		public virtual bool OKButtonScriptTaskExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t\t{0}\t\tClose window \"NewLookupDataPage\" (\"OK\" button pressed)", ExcelImportId));
			UserConnection.SessionData["NewLookupDataPageSuccessfullyClosed"] =  true;
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool AddSelectedScriptTaskExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t\t{0}\t\tAdd new lookup, start (window \"NewLookupDataPage\")", ExcelImportId));
			var dataSource = GetDataSource();
			var lookupData = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			ObservableCollection<Guid> selectedItems = dataSource.SelectedItemPrimaryColumnValues;
			if (lookupData == null || selectedItems.Count == 0) {
				return true;
			}
			var entities = (from entity in lookupData
							join selectedItemId in selectedItems on entity.Item1 equals selectedItemId
							select entity).ToList();
			
			//ExecuteImportExcelLookup(entities);
			if (entities == null) {
				return true;
			}
			var excelImportIdParameter = Column.Parameter(ExcelImportId);
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchemas = new Dictionary<Guid, EntitySchema>();
			foreach (var entity in entities) {
				Guid guid = Guid.NewGuid();
				string valueInBpm = entity.Item2;
				Guid entitySchemaUId = entity.Item6.Key;
				EntitySchema entitySchema;
				if (!entitySchemas.ContainsKey(entitySchemaUId)) {
					entitySchema = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
					entitySchemas.Add(entitySchemaUId, entitySchema);
				} else {
					entitySchema = entitySchemas[entitySchemaUId];
				}
				bool validateRequired = false;
				var lookupEntity = entitySchema.CreateEntity(UserConnection);
				lookupEntity.SetDefColumnValues();
				lookupEntity.SetColumnValue(entitySchema.PrimaryColumn.Name, guid);
				lookupEntity.SetColumnValue(entitySchema.PrimaryDisplayColumn.Name, valueInBpm);
				lookupEntity.Save(validateRequired);
				string message = string.Format(AddNewLookupRecordLocalizableString, 
						"\"" + entity.Item5 + "\"",
						"\"" + valueInBpm + "\"");
				var copyEntity = new Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>(
					entity.Item1, entity.Item2, valueInBpm, entity.Item4, entity.Item5, entity.Item6, entity.Item7);
				lookupData.Add(copyEntity);
				lookupData.Remove(entity);
				LogExcelImportLog(message);
			}
			
			UserConnection.SessionData["NewLookupData"] = lookupData;
			FillData(null);
			LogInfo(string.Format("\t\t{0}\t\tAdd new lookup, end (window \"NewLookupDataPage\")", ExcelImportId));
			return true;
		}

		public virtual bool SelectAllScriptTaskExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t\t{0}\t\tSelect all new lookup, start (window \"NewLookupDataPage\")", ExcelImportId));
			var dataSource = GetDataSource();
			var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			dataSource.SelectedItemPrimaryColumnValues.Clear();
			foreach (var entity in entities) {
				dataSource.SelectedItemPrimaryColumnValues.Add(entity.Item1);
			}
			LogInfo(string.Format("\t\t{0}\t\tSelect all new lookup, end (window \"NewLookupDataPage\")", ExcelImportId));
			return true;
		}

		public virtual bool ChildPageInitScriptExecute(ProcessExecutingContext context) {
			Page.AddSelectedButton.AjaxEvents.Click.Timeout = 12000000;
			Page.SelectAllButton.AjaxEvents.Click.Timeout = 12000000;
			return true;
		}

		public override Entity GetEntity(Guid recordId) {
			var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			if (entities != null) {
				var entityTuple = entities.Where(t => t.Item1 == recordId).FirstOrDefault();
				if (entityTuple != null) {
					var row = GetDataSource().CreateRow();
					FillEntityByTuple(entityTuple, row);
					return row;		
				}		
			}
			
			return null;
		}

		public override List<Dictionary<string, object>> GetStructureDefinition() {
			var structure = new List<Dictionary<string, object>>();
			var column = new Dictionary<string, object> {
				{"Name", "Id"},
				{"ValueColumnName", "Id"},
				{"DisplayColumnName", "Id"},
				{"DataValueType", "Guid"},
				{"Caption", "Id"},
				{"IsVisible", false},
				{"IsSortable", false},
				{"IsPrimaryColumn", true}
			};
			structure.Add(column);
			
			column = new Dictionary<string, object> {
				{"Name", "Lookup"},
				{"ValueColumnName", "Lookup"},
				{"DisplayColumnName", "Lookup"},
				{"DataValueType", "Text"},
				{"Caption", LookupCaption},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			
			// Human-friendly dictionary name
			column = new Dictionary<string, object> {
				{"Name", "LookupCaption"},
				{"ValueColumnName", "LookupCaption"},
				{"DisplayColumnName", "LookupCaption"},
				{"DataValueType", "Text"},
				{"Caption", LookupCaption},
				{"IsVisible", true},
				{"IsSortable", true}
			};
			structure.Add(column);
			
			column = new Dictionary<string, object> {
				{"Name", "Column"},
				{"ValueColumnName", "Column"},
				{"DisplayColumnName", "Column"},
				{"DataValueType", "Text"},
				{"Caption", ColumnCaption},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			
			// Human-friendly column name
			column = new Dictionary<string, object> {
				{"Name", "ColumnCaption"},
				{"ValueColumnName", "ColumnCaption"},
				{"DisplayColumnName", "ColumnCaption"},
				{"DataValueType", "Text"},
				{"Caption", ColumnCaption},
				{"IsVisible", true},
				{"IsSortable", true}
			};
			structure.Add(column);
			
			
			var isSyncLookupConflicts = (bool)(UserConnection.SessionData["IsSyncLookupConflicts"] ?? false);
			column = new Dictionary<string, object> {
				{"Name", "FileName"},
				{"ValueColumnName", "FileName"},
				{"DisplayColumnName", "FileName"},
				{"DataValueType", "Text"},
				{"Caption", (IsSyncLookupConflicts || isSyncLookupConflicts) ? QBCaption : FileNameCaption},
				{"IsVisible", true},
				{"IsSortable", true}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "LookupName"},
				{"ValueColumnName", "LookupName"},
				{"DisplayColumnName", "LookupName"},
				{"DataValueType", "Text"},
				{"Caption", LookupNameCaption},
				{"IsVisible", true},
				{"IsSortable", true}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "SchemaId"},
				{"ValueColumnName", "SchemaId"},
				{"DisplayColumnName", "SchemaId"},
				{"DataValueType", "Guid"},
				{"Caption", "SchemaId"},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			return structure;
		}

		public override void FillData(DataSourceRequest dataSourceRequest) {
			Page.TreeGrid.Clear();
			var dataSource = GetDataSource();
			dataSource.SuspendAjaxEvents();
			dataSource.Rows.Clear();
			dataSource.Clear();
			dataSource.ResumeAjaxEvents();
			
			var entities = UserConnection.SessionData["NewLookupData"] as List<Tuple<Guid, string, string, string, string, 
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>;
			if (entities != null) {
				if (entities.Count < 1) {
					var addEmployeeBtn = Page.AddEmployeeButton;
					var ignoreEmployeeBtn = Page.IgnoreEmployeeButton;
					var addToLookupBtn = Page.AddToLookupButton;
					var bindToLookupDataBtn = Page.BindToLookupDataButton;
					addToLookupBtn.Hidden = bindToLookupDataBtn.Hidden = addEmployeeBtn.Hidden = 
						ignoreEmployeeBtn.Hidden = true;
				}
			
				foreach (var entity in entities) {
					var row = dataSource.CreateRow();
					FillEntityByTuple(entity, row);
					dataSource.Add(row);
				}
			}
			
			dataSource.LoadRows(dataSourceRequest);
		}

		public override void BaseActiveRowChangedHandler() {
			base.BaseActiveRowChangedHandler();
			
			var isAddIds = IsAddIds as List<Guid>;
			Page.AddToLookupButton.Enabled = !isAddIds.Contains(GetDataSource().ActiveRowPrimaryColumnValue);
		}

		public virtual bool IsContactSelected() {
			if (Page.TreeGrid.SelectedNodes.Count == 0) {
				return false;
			}
			
			return Page.TreeGrid.SelectedNodes[0].Values["SchemaId"].ToString() == EmployeeSchemaId;
		}

		public virtual EntitySchema GetEntitySchemaByName(string entitySchemaName) {
			if (EntitySchemaCache == null) {
				EntitySchemaCache = new Dictionary<string, EntitySchema>();
			}
			
			var entitySchemaCacheDict = EntitySchemaCache as Dictionary<string, EntitySchema>;
			if (!entitySchemaCacheDict.ContainsKey(entitySchemaName)) {	
				var entitySchema = UserConnection.EntitySchemaManager.FindInstanceByName(entitySchemaName);
				entitySchemaCacheDict.Add(entitySchemaName, entitySchema);
				return entitySchema;
			} else {
				return entitySchemaCacheDict[entitySchemaName];
			}
		}

		public virtual void FillEntityByTuple(Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>> tuple, Entity entity) {
			entity.SetColumnValue("Id", tuple.Item1);
			entity.SetColumnValue("FileName", tuple.Item2);
			entity.SetColumnValue("LookupName", tuple.Item3);
			entity.SetColumnValue("Column", tuple.Item4);
			entity.SetColumnValue("Lookup", tuple.Item5);
			entity.SetColumnValue("SchemaId", tuple.Item6.Key);
			
			var entitySchema = GetEntitySchemaByName(tuple.Item6.Value);
			entity.SetColumnValue("LookupCaption", entitySchema.Caption);
			
			var column = entitySchema.Columns.FindByName(tuple.Item4);
			
			// There is a difference between Excel and others
			if (column != null)
				entity.SetColumnValue("ColumnCaption", column.Caption);
			else
				entity.SetColumnValue("ColumnCaption", tuple.Item4);	
		}

		public virtual bool ResolveConflicts() {
			/* ORIGINAL METHOD 
			Tuple<System.Guid, string, string, string, string, System.Collections.Generic.KeyValuePair<System.Guid, string>, System.Collections.Generic.Dictionary<int, int>> conflict
			*/
			var conflicts = UserConnection.SessionData["NewLookupData"]
			as List<System.Tuple<System.Guid, string, string, string, string,
						System.Collections.Generic.KeyValuePair<System.Guid, string>,
						System.Collections.Generic.Dictionary<int, Collection<int>>>>;
			if ((conflicts == null) || (conflicts.Count == 0)) {
				return false;
			}
			
			var removeItems = new List<Tuple<Guid, string, string, string, string, 
									KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>();
			// MK Conflict with types
			/*
			foreach (var conflict in conflicts) {
				
				Terrasoft.Sync.LookupConflict lookupConflict;	
				if (!IsSyncLookupConflicts) {
					lookupConflict = new QBIntegrationUtilities(UserConnection).ConvertTupleToLookupConflictForExcell(conflict);
				}
				else {
					lookupConflict = new QBIntegrationUtilities(UserConnection).ConvertTupleToLookupConflict(conflict);
				}
				
				if (!lookupConflict.LookupRecordId.IsEmpty())
					removeItems.Add(conflict);
				Terrasoft.Sync.LookupResolver.SaveConflictResolution(UserConnection, lookupConflict);
			}*/ //// MK
			Terrasoft.Sync.LookupResolver.ApplyLookupConflictResolution(UserConnection);
			
			var dataSource = GetDataSource();	
			foreach(var conflict in removeItems)
			{
				if (conflicts.LastOrDefault() == conflict)
				{
					var first = conflicts.FirstOrDefault();
					if (first != null)
					{
						var addEmployeeBtn = Page.AddEmployeeButton;
						var ignoreEmployeeBtn = Page.IgnoreEmployeeButton;
						var addToLookupBtn = Page.AddToLookupButton;
						var bindToLookupDataBtn = Page.BindToLookupDataButton;
						
						var dsSchemaId = first.Item6.Key.ToString();
						bool isEmployee = dsSchemaId == EmployeeSchemaId;
						addToLookupBtn.Hidden = bindToLookupDataBtn.Hidden = isEmployee;
						addEmployeeBtn.Hidden = ignoreEmployeeBtn.Hidden = !isEmployee;	
					}
				}
				
				conflicts.Remove(conflict);
				dataSource.Remove(conflict.Item1);
				
			}
			
			
			UserConnection.SessionData["NewLookupData"] = conflicts;
			return true;
			
		}

		public virtual void RefreshButtonsStates(Entity entity) {
			var addEmployeeBtn = Page.AddEmployeeButton;
			var ignoreEmployeeBtn = Page.IgnoreEmployeeButton;
			var addToLookupBtn = Page.AddToLookupButton;
			var bindToLookupDataBtn = Page.BindToLookupDataButton;
			
			var ds = GetDataSource();
			if (ds.Rows.Count == 0)
			{
				//addToLookupBtn.Hidden = bindToLookupDataBtn.Hidden = true;
				addEmployeeBtn.Hidden = ignoreEmployeeBtn.Hidden = true;	
				return;
			} else {
				bool isEmployee = ds.Rows[0].GetTypedColumnValue<Guid>("SchemaId").ToString() == EmployeeSchemaId;
				//addToLookupBtn.Hidden = bindToLookupDataBtn.Hidden = isEmployee;
				addEmployeeBtn.Hidden = ignoreEmployeeBtn.Hidden = !isEmployee;		
			}
		}

		public virtual void LogInfo(string message) {
			if(ExcelUtilities.Log != null) {
				ExcelUtilities.Log.Info(message);
			}
		}

		public virtual void LogExcelImportLog(string message) {
			var nowParameter = new QueryParameter("now", DateTime.Now, "DateTime");
			var currentUserContactIdParameter = new QueryParameter("currentUserId",
				UserConnection.CurrentUser.ContactId);
			var guid = Guid.NewGuid();
			
			new Insert(UserConnection)
				.Into("ExcelImportLog")
				.Set("Id", Column.Parameter(guid))
				.Set("CreatedOn", nowParameter)
				.Set("CreatedById", currentUserContactIdParameter)
				.Set("ModifiedOn", nowParameter)
				.Set("ModifiedById", currentUserContactIdParameter)
				.Set("MessageText", Column.Parameter(message))
				.Set("ExcelImportId", Column.Parameter(ExcelImportId))
				.Execute();
		}

		public virtual void ExecuteImportExcelLookup(List<Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>> entities) {
			string jobName = "ImportExcelData";
			string jobGroup = "ImportExcelDataGroup";
			string processName = "ImportExcelLookupProcess";
			
			var processParameters = new Dictionary<string, object>() {
				{"ExcelImportId", ExcelImportId},
				{"Entities", entities},
				{"IsSyncLookupConflicts", IsSyncLookupConflicts}
			};
			AppScheduler.ScheduleImmediateProcessJob(jobName, jobGroup, processName,
				UserConnection.Workspace.Name, UserConnection.CurrentUser.Name, processParameters);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("ChildPageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("ChildPageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "BindToLookupDataButtonClick":
							if (ActivatedEventElements.Contains("BindToLookupDataButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("BindToLookupDataButtonClickStartMessage");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("LookupGridPageClosed")) {
						context.QueueTasks.Enqueue("LookupGridPageClosed");
					}
					break;
					case "AddToLookupButtonClick":
							if (ActivatedEventElements.Contains("AddToLookupButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("AddToLookupButtonClickStartMessage");
						}
						break;
					case "UserTaskAddOpenWindowClosed":
					if (ActivatedEventElements.Remove("UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent")) {
						context.QueueTasks.Enqueue("UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent");
					}
					break;
					case "TreeGridDblClick":
							if (ActivatedEventElements.Contains("TreeGridDblClickStartMessage")) {
							context.QueueTasks.Enqueue("TreeGridDblClickStartMessage");
						}
						break;
					case "CloseButtonClick":
							if (ActivatedEventElements.Contains("CloseButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CloseButtonClickStartMessage");
						}
						break;
					case "AddNewDataInTreeGrid":
							if (ActivatedEventElements.Contains("AddNewDataInTreeGridStartMessage")) {
							context.QueueTasks.Enqueue("AddNewDataInTreeGridStartMessage");
						}
						break;
					case "AddEmployeeButtonClick":
							if (ActivatedEventElements.Contains("AddEmployeeClickStartMessage")) {
							context.QueueTasks.Enqueue("AddEmployeeClickStartMessage");
						}
						break;
					case "IgnoreEmployeeButtonClick":
							if (ActivatedEventElements.Contains("IgnoreEmployeeButtonClickStartMessage1")) {
							context.QueueTasks.Enqueue("IgnoreEmployeeButtonClickStartMessage1");
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OKButtonClickStartMessage");
						}
						break;
					case "AddSelectedButtonClick":
							if (ActivatedEventElements.Contains("AddSelectedStartMessage")) {
							context.QueueTasks.Enqueue("AddSelectedStartMessage");
						}
						break;
					case "SelectAllButtonClick":
							if (ActivatedEventElements.Contains("SelectAllStartMessage")) {
							context.QueueTasks.Enqueue("SelectAllStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("ChildPageInitStartMessage")) {
							context.QueueTasks.Enqueue("ChildPageInitStartMessage");
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
			if (!HasMapping("EmployeeSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EmployeeSchemaId", EmployeeSchemaId, null);
			}
			if (!HasMapping("IsSyncLookupConflicts") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSyncLookupConflicts", IsSyncLookupConflicts, false);
			}
			if (IsAddIds != null) {
				if (IsAddIds.GetType().IsSerializable ||
					IsAddIds.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("IsAddIds", IsAddIds, null);
				}
			}
			if (!HasMapping("ExcelImportId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ExcelImportId", ExcelImportId, Guid.Empty);
			}
			if (!HasMapping("IsOneFieldRequired") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsOneFieldRequired", IsOneFieldRequired, false);
			}
			if (!HasMapping("EntityPrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityPrimaryColumnValue", EntityPrimaryColumnValue, Guid.Empty);
			}
			if (!HasMapping("DefValuesId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DefValuesId", DefValuesId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: NewLookupDataGridPageEventsProcess

	/// <exclude/>
	public class NewLookupDataGridPageEventsProcess : NewLookupDataGridPageEventsProcess<Terrasoft.WebApp.NewLookupDataGridPageSchemaUserControl>
	{

		public NewLookupDataGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: NewLookupDataGridPageSchemaUserControl

	/// <exclude/>
	public partial class NewLookupDataGridPageSchemaUserControl : Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BottomButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button BindToLookupDataButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("BindToLookupDataButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddToLookupButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddToLookupButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddSelectedButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddSelectedButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SelectAllButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SelectAllButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddEmployeeButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddEmployeeButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button IgnoreEmployeeButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("IgnoreEmployeeButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OKButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CloseButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CloseButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			TreeGrid.AjaxEvents.DblClick.Event += TreeGridDblClick;
			BindToLookupDataButton.AjaxEvents.Click.Event += BindToLookupDataButtonClick;
			AddToLookupButton.AjaxEvents.Click.Event += AddToLookupButtonClick;
			AddSelectedButton.AjaxEvents.Click.Event += AddSelectedButtonClick;
			SelectAllButton.AjaxEvents.Click.Event += SelectAllButtonClick;
			AddEmployeeButton.AjaxEvents.Click.Event += AddEmployeeButtonClick;
			IgnoreEmployeeButton.AjaxEvents.Click.Event += IgnoreEmployeeButtonClick;
			OKButton.AjaxEvents.Click.Event += OKButtonClick;
			CloseButton.AjaxEvents.Click.Event += CloseButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			TreeGrid.AjaxEvents.DblClick.Event -= TreeGridDblClick;
			BindToLookupDataButton.AjaxEvents.Click.Event -= BindToLookupDataButtonClick;
			AddToLookupButton.AjaxEvents.Click.Event -= AddToLookupButtonClick;
			AddSelectedButton.AjaxEvents.Click.Event -= AddSelectedButtonClick;
			SelectAllButton.AjaxEvents.Click.Event -= SelectAllButtonClick;
			AddEmployeeButton.AjaxEvents.Click.Event -= AddEmployeeButtonClick;
			IgnoreEmployeeButton.AjaxEvents.Click.Event -= IgnoreEmployeeButtonClick;
			OKButton.AjaxEvents.Click.Event -= OKButtonClick;
			CloseButton.AjaxEvents.Click.Event -= CloseButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (NewLookupDataGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new NewLookupDataGridPageEventsProcess(UserConnection);
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

		public virtual void TreeGridDblClick(object sender, EventArgs e) {
			object result = ThrowEvent("TreeGridDblClick");
		}

		public virtual void BindToLookupDataButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("BindToLookupDataButtonClick");
		}

		public virtual void AddToLookupButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddToLookupButtonClick");
		}

		public virtual void AddSelectedButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddSelectedButtonClick");
		}

		public virtual void SelectAllButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SelectAllButtonClick");
		}

		public virtual void AddEmployeeButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddEmployeeButtonClick");
		}

		public virtual void IgnoreEmployeeButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("IgnoreEmployeeButtonClick");
		}

		public virtual void OKButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OKButtonClick");
		}

		public virtual void CloseButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CloseButtonClick");
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
			SchemaName = "NewLookupDataGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: NewLookupDataGridPageEventsProcessSchema

	/// <exclude/>
	public class NewLookupDataGridPageEventsProcessSchema : Terrasoft.WebApp.BaseVirtualGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public NewLookupDataGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public NewLookupDataGridPageEventsProcessSchema(NewLookupDataGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "NewLookupDataGridPageEventsProcess";
			UId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateDefValuesIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("86b64636-92d3-46ec-9fae-d6616875450b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"DefValuesId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c6a3e8d6-484e-4ac7-8951-0cecaa276ab3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"EntityPrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsOneFieldRequiredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("75761df9-b159-4aec-9c01-a6f0b5a25f43"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"IsOneFieldRequired",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateExcelImportIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("671b84d2-dc05-413b-9f3c-f6214eb46727"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"ExcelImportId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsAddIdsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9a85c355-b2e4-4490-aad2-fc6e60079794"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"IsAddIds",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSyncLookupConflictsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1d084434-a101-42c5-821f-168463de854c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"IsSyncLookupConflicts",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEmployeeSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("463e9839-a3c8-4dcd-98ae-fbc8763980ba"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"EmployeeSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaCacheParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f1e2f691-ff45-4335-96bf-e0fbdcd4f2f6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"EntitySchemaCache",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDefValuesIdParameter());
			Parameters.Add(CreateEntityPrimaryColumnValueParameter());
			Parameters.Add(CreateIsOneFieldRequiredParameter());
			Parameters.Add(CreateExcelImportIdParameter());
			Parameters.Add(CreateIsAddIdsParameter());
			Parameters.Add(CreateIsSyncLookupConflictsParameter());
			Parameters.Add(CreateEmployeeSchemaIdParameter());
			Parameters.Add(CreateEntitySchemaCacheParameter());
		}

		protected virtual void InitializeOpenLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a4e9bfef-e4a1-4b1d-8db4-cd3c567ee42a"),
				ContainerUId = new Guid("dd5890c1-9ec7-4087-96a1-c93db268b246"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("9be66b5e-8b3f-4d26-a85a-31b53daa4c75"),
				ContainerUId = new Guid("dd5890c1-9ec7-4087-96a1-c93db268b246"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("4c0baca2-ef7e-4618-802a-0991c04f9e39"),
				ContainerUId = new Guid("dd5890c1-9ec7-4087-96a1-c93db268b246"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("4658a7a7-7f50-425b-a9f6-5c78e6d0d840"),
				ContainerUId = new Guid("dd5890c1-9ec7-4087-96a1-c93db268b246"),
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

		protected virtual void InitializeUserTaskAddOpenWindowParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("05444e44-2dfb-492f-804e-a20a3364f7db"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("13947f76-0c85-424b-9cea-405f6131c1b7"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("5fb75fb2-23a0-474d-8c7d-e95d24b684ae"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("5a07177e-599f-406c-93a2-35d56188726a"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("d17508b0-6e56-4eb7-ab67-67989c0aa801"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("b1c54f15-3435-4998-bc1f-83917d5422ca"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("fc63c6bd-51a4-4e24-9768-3bd4a80f0166"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("1f53c33c-bb44-4c0b-ba5f-bea241d936b0"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("6381afab-3393-4f17-9d8a-5dcd601ca409"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("8aa21200-a9e8-4cd0-b418-d79c449e390f"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("548864cf-2196-48b6-909d-9f658e1f066d"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("72aa98c6-39c4-48ba-9bad-7f5a6366ff2c"),
				ContainerUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaPageEventsLane = CreatePageEventsLaneLane();
			schemaLaneSet1.Lanes.Add(schemaPageEventsLane);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaLane schemaCancelButtonLane = CreateCancelButtonLaneLane();
			schemaLaneSet1.Lanes.Add(schemaCancelButtonLane);
			ProcessSchemaLane schemaEmployeeButtonsLane = CreateEmployeeButtonsLaneLane();
			schemaLaneSet1.Lanes.Add(schemaEmployeeButtonsLane);
			ProcessSchemaLane schemaOKButtonLane = CreateOKButtonLaneLane();
			schemaLaneSet1.Lanes.Add(schemaOKButtonLane);
			ProcessSchemaLane schemaAddSelectedLane = CreateAddSelectedLaneLane();
			schemaLaneSet1.Lanes.Add(schemaAddSelectedLane);
			ProcessSchemaLane schemaSelectAllLane = CreateSelectAllLaneLane();
			schemaLaneSet1.Lanes.Add(schemaSelectAllLane);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess bindtolookupdatabuttonclickeventsubprocess = CreateBindToLookupDataButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(bindtolookupdatabuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess addtolookupbuttonclickeventsubprocess = CreateAddToLookupButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(addtolookupbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess treegriddblclickeventsubprocess = CreateTreeGridDblClickEventSubProcessEventSubProcess();
			FlowElements.Add(treegriddblclickeventsubprocess);
			ProcessSchemaEventSubProcess cancelbuttonclickeventsubprocess = CreateCancelButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(cancelbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess addnewdataintreegrideventsubprocess = CreateAddNewDataInTreeGridEventSubProcessEventSubProcess();
			FlowElements.Add(addnewdataintreegrideventsubprocess);
			ProcessSchemaEventSubProcess addemployeeeventsubprocess = CreateAddEmployeeEventSubProcessEventSubProcess();
			FlowElements.Add(addemployeeeventsubprocess);
			ProcessSchemaEventSubProcess ignoreemployeebuttonclickeventsubprocess = CreateIgnoreEmployeeButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(ignoreemployeebuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess okbuttoneventsubprocess = CreateOKButtonEventSubProcessEventSubProcess();
			FlowElements.Add(okbuttoneventsubprocess);
			ProcessSchemaEventSubProcess addselectedeventsubprocess = CreateAddSelectedEventSubProcessEventSubProcess();
			FlowElements.Add(addselectedeventsubprocess);
			ProcessSchemaEventSubProcess selectalleventsubprocess = CreateSelectAllEventSubProcessEventSubProcess();
			FlowElements.Add(selectalleventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent childpageloadcompletestartmessage = CreateChildPageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(childpageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent basepageloadcompleteintermediatethrowmessageevent = CreateBasePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(basepageloadcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask childpageloadcompletescript = CreateChildPageLoadCompleteScriptScriptTask();
			eventsubprocess1.FlowElements.Add(childpageloadcompletescript);
			ProcessSchemaStartMessageEvent bindtolookupdatabuttonclickstartmessage = CreateBindToLookupDataButtonClickStartMessageStartMessageEvent();
			bindtolookupdatabuttonclickeventsubprocess.FlowElements.Add(bindtolookupdatabuttonclickstartmessage);
			ProcessSchemaScriptTask bindtolookupdatabuttonclickscript = CreateBindToLookupDataButtonClickScriptScriptTask();
			bindtolookupdatabuttonclickeventsubprocess.FlowElements.Add(bindtolookupdatabuttonclickscript);
			ProcessSchemaUserTask openlookupusertask = CreateOpenLookupUserTaskUserTask();
			bindtolookupdatabuttonclickeventsubprocess.FlowElements.Add(openlookupusertask);
			ProcessSchemaIntermediateCatchMessageEvent lookupgridpageclosed = CreateLookupGridPageClosedIntermediateCatchMessageEvent();
			bindtolookupdatabuttonclickeventsubprocess.FlowElements.Add(lookupgridpageclosed);
			ProcessSchemaScriptTask updaterowintreegridscript = CreateUpdateRowInTreeGridScriptScriptTask();
			bindtolookupdatabuttonclickeventsubprocess.FlowElements.Add(updaterowintreegridscript);
			ProcessSchemaScriptTask resolveconflictsscripttask2 = CreateResolveConflictsScriptTask2ScriptTask();
			bindtolookupdatabuttonclickeventsubprocess.FlowElements.Add(resolveconflictsscripttask2);
			ProcessSchemaStartMessageEvent addtolookupbuttonclickstartmessage = CreateAddToLookupButtonClickStartMessageStartMessageEvent();
			addtolookupbuttonclickeventsubprocess.FlowElements.Add(addtolookupbuttonclickstartmessage);
			ProcessSchemaScriptTask addtolookupbuttonclickscript = CreateAddToLookupButtonClickScriptScriptTask();
			addtolookupbuttonclickeventsubprocess.FlowElements.Add(addtolookupbuttonclickscript);
			ProcessSchemaUserTask usertaskaddopenwindow = CreateUserTaskAddOpenWindowUserTask();
			addtolookupbuttonclickeventsubprocess.FlowElements.Add(usertaskaddopenwindow);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			addtolookupbuttonclickeventsubprocess.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask addtolookupdataclickscript = CreateAddToLookupDataClickScriptScriptTask();
			addtolookupbuttonclickeventsubprocess.FlowElements.Add(addtolookupdataclickscript);
			ProcessSchemaScriptTask checkrequiredfieldsscript = CreateCheckRequiredFieldsScriptScriptTask();
			addtolookupbuttonclickeventsubprocess.FlowElements.Add(checkrequiredfieldsscript);
			ProcessSchemaScriptTask resolveconflictsscripttask = CreateResolveConflictsScriptTaskScriptTask();
			addtolookupbuttonclickeventsubprocess.FlowElements.Add(resolveconflictsscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			addtolookupbuttonclickeventsubprocess.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaIntermediateCatchMessageEvent usertaskaddopenwindowclosedintermediatecatchmessageevent = CreateUserTaskAddOpenWindowClosedIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			addtolookupbuttonclickeventsubprocess.FlowElements.Add(usertaskaddopenwindowclosedintermediatecatchmessageevent);
			ProcessSchemaStartMessageEvent treegriddblclickstartmessage = CreateTreeGridDblClickStartMessageStartMessageEvent();
			treegriddblclickeventsubprocess.FlowElements.Add(treegriddblclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent bindtolookupdatabuttonclickintermediatethrowmessageevent = CreateBindToLookupDataButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			treegriddblclickeventsubprocess.FlowElements.Add(bindtolookupdatabuttonclickintermediatethrowmessageevent);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			treegriddblclickeventsubprocess.FlowElements.Add(exclusivegateway2);
			ProcessSchemaIntermediateThrowMessageEvent opencontacteditpageeventintermediatethrowmessageevent = CreateOpenContactEditPageEventIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			treegriddblclickeventsubprocess.FlowElements.Add(opencontacteditpageeventintermediatethrowmessageevent);
			ProcessSchemaExclusiveGateway treegridrowselectedcheck = CreateTreeGridRowSelectedCheckExclusiveGateway();
			treegriddblclickeventsubprocess.FlowElements.Add(treegridrowselectedcheck);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			treegriddblclickeventsubprocess.FlowElements.Add(end1);
			ProcessSchemaStartMessageEvent closebuttonclickstartmessage = CreateCloseButtonClickStartMessageStartMessageEvent();
			cancelbuttonclickeventsubprocess.FlowElements.Add(closebuttonclickstartmessage);
			ProcessSchemaScriptTask cancelbuttonclickscript = CreateCancelButtonClickScriptScriptTask();
			cancelbuttonclickeventsubprocess.FlowElements.Add(cancelbuttonclickscript);
			ProcessSchemaStartMessageEvent addnewdataintreegridstartmessage = CreateAddNewDataInTreeGridStartMessageStartMessageEvent();
			addnewdataintreegrideventsubprocess.FlowElements.Add(addnewdataintreegridstartmessage);
			ProcessSchemaScriptTask addnewdataintreegridscript = CreateAddNewDataInTreeGridScriptScriptTask();
			addnewdataintreegrideventsubprocess.FlowElements.Add(addnewdataintreegridscript);
			ProcessSchemaStartMessageEvent addemployeeclickstartmessage = CreateAddEmployeeClickStartMessageStartMessageEvent();
			addemployeeeventsubprocess.FlowElements.Add(addemployeeclickstartmessage);
			ProcessSchemaScriptTask addemployeescripttask = CreateAddEmployeeScriptTaskScriptTask();
			addemployeeeventsubprocess.FlowElements.Add(addemployeescripttask);
			ProcessSchemaStartMessageEvent ignoreemployeebuttonclickstartmessage1 = CreateIgnoreEmployeeButtonClickStartMessage1StartMessageEvent();
			ignoreemployeebuttonclickeventsubprocess.FlowElements.Add(ignoreemployeebuttonclickstartmessage1);
			ProcessSchemaScriptTask ignoreemployeebuttonclickscripttask = CreateIgnoreEmployeeButtonClickScriptTaskScriptTask();
			ignoreemployeebuttonclickeventsubprocess.FlowElements.Add(ignoreemployeebuttonclickscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOKButtonClickStartMessageStartMessageEvent();
			okbuttoneventsubprocess.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaScriptTask okbuttonscripttask = CreateOKButtonScriptTaskScriptTask();
			okbuttoneventsubprocess.FlowElements.Add(okbuttonscripttask);
			ProcessSchemaStartMessageEvent addselectedstartmessage = CreateAddSelectedStartMessageStartMessageEvent();
			addselectedeventsubprocess.FlowElements.Add(addselectedstartmessage);
			ProcessSchemaScriptTask addselectedscripttask = CreateAddSelectedScriptTaskScriptTask();
			addselectedeventsubprocess.FlowElements.Add(addselectedscripttask);
			ProcessSchemaStartMessageEvent selectallstartmessage = CreateSelectAllStartMessageStartMessageEvent();
			selectalleventsubprocess.FlowElements.Add(selectallstartmessage);
			ProcessSchemaScriptTask selectallscripttask = CreateSelectAllScriptTaskScriptTask();
			selectalleventsubprocess.FlowElements.Add(selectallscripttask);
			ProcessSchemaStartMessageEvent childpageinitstartmessage = CreateChildPageInitStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(childpageinitstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent basepageinitintermediatethrowmessageevent = CreateBasePageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(basepageinitintermediatethrowmessageevent);
			ProcessSchemaScriptTask childpageinitscript = CreateChildPageInitScriptScriptTask();
			eventsubprocess2.FlowElements.Add(childpageinitscript);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFileNameCaptionLocalizableString());
			LocalizableStrings.Add(CreateLookupNameCaptionLocalizableString());
			LocalizableStrings.Add(CreateColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateLookupCaptionLocalizableString());
			LocalizableStrings.Add(CreatePageCaptionLocalizableString());
			LocalizableStrings.Add(CreateAddNewLookupRecordLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateQBCaptionLocalizableString());
			LocalizableStrings.Add(CreateOneCCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFileNameCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ec4e01a0-710d-48c5-84dd-a1fd8da1ddcc"),
				Name = "FileNameCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLookupNameCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4ce85aed-e87f-4f00-8fa3-f5414d83f621"),
				Name = "LookupNameCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("25423137-35fd-447a-8ce1-f2b8d0da6fa7"),
				Name = "ColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLookupCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("de36bfa0-b8a0-4ccb-8145-e80512ab6675"),
				Name = "LookupCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e4275d8c-95a1-4d8f-8702-9a85eb4d4e44"),
				Name = "PageCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddNewLookupRecordLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dd0eff0f-1a42-4b88-a676-691c966a3e59"),
				Name = "AddNewLookupRecordLocalizableString",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateQBCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8acd7bf1-1ee6-46ed-9b00-20bfdbd6eb15"),
				Name = "QBCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOneCCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c8fb934c-3751-45e7-9f11-3710d6d2d6e6"),
				Name = "OneCCaption",
				CreatedInPackageId = new Guid("30b410f2-ea84-42ba-b18d-d81d2fe69eec"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b28e80fb-d023-4fc5-bde0-a4e0611567cd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(204, 116),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f1fec528-c7c4-442d-af55-47e628aa519a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("67ac5eb9-aca9-4ce9-b9b5-4997f43b8926"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1e38f69b-058f-4e1d-8fd4-c7a5ed848500"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(297, 116),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("67ac5eb9-aca9-4ce9-b9b5-4997f43b8926"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5330a54e-7844-45a9-a6ae-53f91fac4c3b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("2f6f7e26-ddbf-479b-a13a-20704406428f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("abc58427-9e18-435e-a16a-06ca0af2f13e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("554e7707-07fd-474e-8ede-17b581e46f3a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("0df2159b-16d2-42e4-aa5c-731ce92f2383"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(316, 432),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("554e7707-07fd-474e-8ede-17b581e46f3a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dd5890c1-9ec7-4087-96a1-c93db268b246"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("a382fbea-bc3d-4d5d-9888-5c34f02f1eeb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(467, 468),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd5890c1-9ec7-4087-96a1-c93db268b246"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fabbb787-7989-4168-910f-cade345f0810"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("b1bcfb5a-1ba9-4389-bfd1-364114d35ba4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(604, 462),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fabbb787-7989-4168-910f-cade345f0810"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1e051ed1-3b31-4092-954d-41b7b91c863b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("14594d7b-0c29-4fa9-a07b-99e3678509bb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da7f96e6-8ed5-48ac-91bd-4d562fb2c7fb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d1991b1e-6198-4c54-9652-2810df80429c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("a1f6d0f4-6544-4854-a9f0-b7259186ffc5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(563, 744),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("071f2c46-cfc3-44aa-b0c2-1a393c6350d8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b8866549-72b2-4083-8ea4-7f852f8ecc29"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("3f4e3a76-645f-4c4e-87c2-2e8d355bcd93"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(309, 740),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("65850628-bbaf-465b-b7b6-65b94e6c95a1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("daa23e71-69f0-4bad-9d5d-90cb0a388b95"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ad98d8e-20b1-40a3-ae3c-a0eb59e4ce7b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("010b051c-382a-4290-9642-3998d7cc8a4d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("b6bb3489-0f16-4922-a276-6e0782d0d1b1"),
				ConditionExpression = @"!IsOneFieldRequired",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(302, 700),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("010b051c-382a-4290-9642-3998d7cc8a4d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("65850628-bbaf-465b-b7b6-65b94e6c95a1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("eb7a0a17-1654-4662-b578-d33526528c0e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(285, 765),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("010b051c-382a-4290-9642-3998d7cc8a4d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f85f08c1-e203-47dc-aad0-8034a3a46a17"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("bf946502-e3c2-482f-ad9c-567dabb82722"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ad532f3f-6bf6-4e25-a460-8f0b3d207028"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ad98d8e-20b1-40a3-ae3c-a0eb59e4ce7b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("47177be0-2a96-4c2c-b9db-a882c0645954"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d5027e3c-a61e-4af0-95a1-05ae386a1971"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a6e71cae-49b1-4e3e-8368-39ee50da9160"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow16",
				UId = new Guid("dd1eaa47-b278-4dcc-bb0b-24cc08a9c562"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(341, 475),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b870be96-d481-441c-a2fd-0fff39a3061b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("815fe998-f3ec-452d-b6bd-afae62bf5f49"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("d3e71e01-6a49-4e9c-9a80-b9416462e32e"),
				ConditionExpression = @"IsContactSelected()",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(351, 507),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b870be96-d481-441c-a2fd-0fff39a3061b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0bb18869-bce6-4b9f-be64-d92c24fbb5c2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(490, 512));
			schemaFlow.PolylinePointPositions.Add(new Point(490, 540));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("9600b58e-9e4b-43fa-8351-470e4e31e0de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2332c79f-25a6-433b-a093-a97b106f02ae"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1d9d30fd-48dd-4c6a-95a1-9cf6e049f556"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("32b3c63d-d325-4418-8059-b91d2b4fbbb8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(624, 1009),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f85f08c1-e203-47dc-aad0-8034a3a46a17"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97338d58-bc55-4bcd-80f2-7231ad720eb6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("7fb68bb5-bef2-4dcd-9a57-84e210fa9779"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(656, 938),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ce5e0970-6d5d-4b31-a6c2-bb067f3255e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("e83fc720-8cbd-450b-9ed8-f97778a21780"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(850, 938),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97338d58-bc55-4bcd-80f2-7231ad720eb6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("842cab6d-cc04-48c8-af15-6471e105f2b5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("8889dc5d-506c-4ea8-abd2-5c1e5ea7d7d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(710, 1240),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1e051ed1-3b31-4092-954d-41b7b91c863b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8ddea3d9-a4f3-47e0-b511-595f5b618389"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("b7704b5d-d5da-4dc9-b7fb-44224803a2c0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(181, 491),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bc74c068-f395-4df4-a0b2-3ec44d4d0e96"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71c3d040-c61e-4f1e-b283-f46f8403c8e5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("cb472cc3-945c-463b-8e35-1b2d4bba7cc5"),
				ConditionExpression = @"Page.TreeGrid.SelectedNodes.Count > 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(329, 491),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71c3d040-c61e-4f1e-b283-f46f8403c8e5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b870be96-d481-441c-a2fd-0fff39a3061b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("700b589f-f910-4475-b916-f184603021d3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(244, 550),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71c3d040-c61e-4f1e-b283-f46f8403c8e5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79cd02d7-6cda-48a7-9302-03cf41ec5463"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("51f74695-9efd-4360-a013-ee5a70b2a497"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ad9fa8e0-5911-4ccd-89c2-6d6e6f8ff557"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4f72b873-c5fb-488d-9b69-7658d7ff862b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("045bdc5a-ff1a-469f-837c-578bcf39fa4f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(656, 938),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ce5e0970-6d5d-4b31-a6c2-bb067f3255e5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97338d58-bc55-4bcd-80f2-7231ad720eb6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("6a981e4f-fdcb-4603-b638-a676b1c11d50"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4b3c4d85-c36d-4cb6-9f19-01aa74cffc43"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("95e4541b-9b5f-49b2-9bce-376e030b5625"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("c5c8a05c-2fde-4575-a271-0115eb52e2ed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6177b940-3aed-40d2-b293-b21a0bb0ae1a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3bb979d6-b7e4-4d30-932e-c796ad0545ca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("1c50bf7b-0d3a-45d1-af50-102690a9bea9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(529, 624),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("98aa64f2-78b6-4e00-929e-afa665f1f74b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("42173148-9348-40e8-8877-0a68140d3933"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow27",
				UId = new Guid("05081f4c-fb5d-42c7-a5e4-9af45178ddcd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CurveCenterPosition = new Point(622, 624),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42173148-9348-40e8-8877-0a68140d3933"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("61498653-b55e-4dd5-ab48-26000399b566"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(740, 945),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreatePageEventsLaneLane() {
			ProcessSchemaLane schemaPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("f3377275-227e-4e2b-a72d-e1aedc83a5e0"),
				ContainerItemIndex = 9,
				ContainerUId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				CreatedInOwnerSchemaUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"PageEventsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 676),
				Size = new Size(711, 269),
				UseBackgroundMode = false
			};
			return schemaPageEventsLane;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("dd7c7168-6a38-4d23-a5e3-dd0e6ae0f6aa"),
				ContainerItemIndex = 8,
				ContainerUId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"Lane2",
				Position = new Point(29, 647),
				Size = new Size(711, 238),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("6ef02bf3-799f-46a6-a5bc-4e599a6f118e"),
				ContainerItemIndex = 7,
				ContainerUId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"Lane3",
				Position = new Point(29, 618),
				Size = new Size(711, 280),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("fc200a17-9024-488c-a347-84ac5419c5ac"),
				ContainerItemIndex = 6,
				ContainerUId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"Lane4",
				Position = new Point(29, 589),
				Size = new Size(711, 225),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaLane CreateCancelButtonLaneLane() {
			ProcessSchemaLane schemaCancelButtonLane = new ProcessSchemaLane(this) {
				UId = new Guid("c97ac0a1-8556-453b-901c-97de45c1daa4"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"CancelButtonLane",
				Position = new Point(29, 393),
				Size = new Size(711, 191),
				UseBackgroundMode = false
			};
			return schemaCancelButtonLane;
		}

		protected virtual ProcessSchemaLane CreateEmployeeButtonsLaneLane() {
			ProcessSchemaLane schemaEmployeeButtonsLane = new ProcessSchemaLane(this) {
				UId = new Guid("4a6556e4-d49c-4a69-84e8-ed667b58c5a2"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"EmployeeButtonsLane",
				Position = new Point(29, 364),
				Size = new Size(711, 200),
				UseBackgroundMode = false
			};
			return schemaEmployeeButtonsLane;
		}

		protected virtual ProcessSchemaLane CreateOKButtonLaneLane() {
			ProcessSchemaLane schemaOKButtonLane = new ProcessSchemaLane(this) {
				UId = new Guid("0552f5c0-22a4-4246-b2a8-c81d7a820a56"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"OKButtonLane",
				Position = new Point(29, 335),
				Size = new Size(711, 159),
				UseBackgroundMode = false
			};
			return schemaOKButtonLane;
		}

		protected virtual ProcessSchemaLane CreateAddSelectedLaneLane() {
			ProcessSchemaLane schemaAddSelectedLane = new ProcessSchemaLane(this) {
				UId = new Guid("5ca1c4fb-8169-4ec4-94a9-403073b14598"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddSelectedLane",
				Position = new Point(29, 164),
				Size = new Size(711, 166),
				UseBackgroundMode = false
			};
			return schemaAddSelectedLane;
		}

		protected virtual ProcessSchemaLane CreateSelectAllLaneLane() {
			ProcessSchemaLane schemaSelectAllLane = new ProcessSchemaLane(this) {
				UId = new Guid("3df87f40-9e62-4ceb-9c5f-7669b5cdcaee"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4dab08d8-2664-426e-a4f5-3d8d6d409b58"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"SelectAllLane",
				Position = new Point(29, 0),
				Size = new Size(711, 159),
				UseBackgroundMode = false
			};
			return schemaSelectAllLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("701201d6-4cc2-4aa0-bdea-e83f40bb78e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3377275-227e-4e2b-a72d-e1aedc83a5e0"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(56, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(347, 217),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildPageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f1fec528-c7c4-442d-af55-47e628aa519a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("701201d6-4cc2-4aa0-bdea-e83f40bb78e6"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"ChildPageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBasePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("67ac5eb9-aca9-4ce9-b9b5-4997f43b8926"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("701201d6-4cc2-4aa0-bdea-e83f40bb78e6"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"BasePageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildPageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5330a54e-7844-45a9-a6ae-53f91fac4c3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("701201d6-4cc2-4aa0-bdea-e83f40bb78e6"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"ChildPageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,75,111,219,56,16,62,203,128,255,3,235,139,229,52,80,122,234,197,73,208,196,201,102,133,6,109,16,57,233,161,200,129,150,198,14,91,154,52,72,170,169,81,248,191,119,72,74,178,100,203,78,31,187,11,236,98,141,56,178,200,249,230,249,241,49,114,242,9,82,67,152,78,150,34,189,150,242,115,190,24,73,49,229,44,53,154,156,144,59,13,10,223,5,202,48,41,162,4,180,198,231,5,53,244,99,47,110,195,244,30,134,221,14,155,146,176,93,227,139,19,34,114,206,7,228,91,183,19,180,42,64,163,225,68,74,62,104,85,128,202,131,110,103,69,128,107,216,171,99,74,81,2,165,87,222,155,86,49,239,197,13,157,65,244,254,237,121,110,12,70,248,39,203,50,16,168,192,168,220,226,131,123,166,76,78,185,13,57,145,185,74,129,100,235,159,39,228,10,204,122,42,28,120,255,130,47,84,17,16,134,25,6,122,44,255,96,156,151,106,146,103,146,250,14,158,188,151,246,181,247,64,168,38,215,76,155,227,113,190,224,112,124,149,179,236,144,104,163,152,152,237,126,162,3,65,240,22,150,247,148,231,112,67,153,106,224,78,15,201,5,115,150,169,90,30,51,97,14,201,72,114,238,157,177,239,167,248,177,113,216,188,237,12,162,94,199,96,119,168,2,158,126,205,255,223,115,223,23,98,181,46,6,205,178,203,249,130,203,37,192,185,177,229,117,85,63,171,141,186,242,15,11,113,54,19,82,65,11,34,110,78,52,64,104,99,44,125,241,154,54,170,209,134,248,132,137,106,198,22,187,134,57,223,156,170,128,123,106,18,141,100,46,12,57,37,175,176,42,54,110,247,245,73,35,19,167,65,95,211,165,204,77,124,81,25,146,56,60,247,234,53,82,210,40,201,189,76,52,226,12,13,197,23,195,154,150,102,22,157,154,230,80,43,106,43,153,14,184,53,186,203,98,45,167,165,197,218,80,43,170,37,181,14,218,50,222,196,187,148,29,29,216,255,182,68,153,78,210,71,152,211,56,67,240,142,180,127,124,245,16,197,6,230,175,35,164,108,52,150,137,115,193,19,48,176,27,25,238,173,101,148,118,111,171,235,60,33,229,76,57,230,97,27,33,86,123,82,155,255,213,228,218,76,169,163,158,220,181,216,86,222,171,169,23,53,21,46,19,7,71,37,141,74,42,39,169,98,11,19,190,233,77,115,225,86,28,81,48,85,160,31,11,14,37,134,26,32,161,146,79,197,214,16,244,200,203,45,246,189,36,111,122,209,4,102,76,88,206,97,98,239,22,184,169,22,219,103,224,72,142,26,54,54,25,175,106,139,130,78,151,6,115,207,52,155,112,8,221,198,95,40,114,136,54,250,61,11,218,226,221,179,136,118,206,237,128,5,5,213,130,226,36,43,34,142,102,96,112,51,203,231,194,237,125,97,191,164,69,127,96,147,209,183,118,54,25,227,76,244,127,46,71,246,108,251,217,20,109,98,254,230,12,213,179,243,223,41,127,45,137,171,253,171,3,68,182,189,54,44,100,213,179,191,142,14,200,251,219,248,42,126,119,118,77,146,209,109,124,51,110,93,165,118,208,154,88,95,89,170,253,206,155,145,34,236,83,92,200,95,0,233,151,62,82,49,131,172,127,72,202,213,29,254,230,42,222,107,219,219,189,253,159,246,255,30,218,111,102,227,31,97,61,162,252,195,49,255,224,104,199,137,244,151,240,60,104,57,206,126,144,197,3,31,224,96,232,86,93,121,1,197,191,170,152,59,58,141,90,171,98,175,30,254,226,209,218,90,100,58,186,20,20,83,154,128,194,72,206,74,211,235,118,197,158,216,246,122,98,129,161,59,60,135,94,171,93,141,8,71,97,93,187,40,162,83,56,152,128,169,84,149,66,120,173,41,178,221,237,220,110,231,68,87,202,187,157,31,110,103,108,252,73,158,166,40,48,69,244,114,196,165,134,12,155,156,117,14,66,95,86,189,176,79,219,252,140,65,41,170,229,212,68,119,113,244,1,38,197,37,85,71,86,96,16,141,232,194,221,66,252,125,182,120,67,61,210,183,181,240,53,5,30,207,23,82,25,119,135,219,231,234,101,93,182,106,99,155,26,26,237,235,229,134,242,208,182,41,131,6,192,87,53,214,200,211,216,213,180,234,135,172,172,111,83,20,152,92,9,95,192,239,16,163,17,220,142,15,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBindToLookupDataButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBindToLookupDataButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ceb082c5-f5de-4934-bf9a-d8f2e1441ced"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd7c7168-6a38-4d23-a5e3-dd0e6ae0f6aa"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"BindToLookupDataButtonClickEventSubProcess",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(790, 215),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBindToLookupDataButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBindToLookupDataButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("abc58427-9e18-435e-a16a-06ca0af2f13e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb082c5-f5de-4934-bf9a-d8f2e1441ced"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"BindToLookupDataButtonClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"BindToLookupDataButtonClickStartMessage",
				Position = new Point(29, 80),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBindToLookupDataButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("554e7707-07fd-474e-8ede-17b581e46f3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb082c5-f5de-4934-bf9a-d8f2e1441ced"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"BindToLookupDataButtonClickScript",
				Position = new Point(141, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,97,75,195,48,16,134,191,11,254,135,176,79,41,142,252,1,231,96,108,50,138,138,197,182,250,249,214,220,102,92,154,212,75,178,177,127,111,154,14,81,161,243,75,184,192,221,243,190,247,158,243,164,204,142,41,227,60,152,6,115,201,238,24,231,21,18,129,179,91,47,234,92,188,225,102,105,141,39,171,157,40,96,135,89,255,136,133,235,210,71,228,223,163,162,178,101,194,241,236,246,250,234,185,67,243,104,237,62,116,181,67,170,192,237,69,65,182,65,231,30,240,20,85,126,72,222,176,132,236,159,94,9,148,65,18,181,81,159,1,243,213,8,42,246,22,64,208,162,71,114,17,103,240,200,86,170,241,202,26,160,19,155,185,228,100,202,236,230,3,27,63,31,179,20,139,101,32,66,227,23,113,246,128,61,55,210,60,5,140,3,7,32,214,253,85,226,23,100,178,127,173,158,169,81,80,249,62,134,53,250,251,84,243,88,173,192,67,105,3,53,200,51,49,24,122,177,199,130,84,27,197,150,86,135,214,188,130,14,216,47,243,219,151,88,72,201,39,174,121,199,22,234,92,78,166,103,5,17,169,213,169,67,249,99,122,182,14,74,206,249,164,76,221,177,57,27,227,233,180,201,154,148,76,183,129,174,223,251,50,123,8,36,210,135,20,198,217,109,208,94,149,168,99,108,79,86,98,164,110,65,187,180,26,161,15,100,134,35,124,1,185,154,222,196,161,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("dd5890c1-9ec7-4087-96a1-c93db268b246"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb082c5-f5de-4934-bf9a-d8f2e1441ced"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"OpenLookupUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 63),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateLookupGridPageClosedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("fabbb787-7989-4168-910f-cade345f0810"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb082c5-f5de-4934-bf9a-d8f2e1441ced"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"LookupGridPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(435, 76),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRowInTreeGridScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1e051ed1-3b31-4092-954d-41b7b91c863b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb082c5-f5de-4934-bf9a-d8f2e1441ced"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"UpdateRowInTreeGridScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(525, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,81,139,26,49,16,126,142,224,127,152,250,180,139,203,94,175,244,218,7,93,225,240,64,74,229,42,213,235,139,248,16,215,185,54,231,154,72,54,81,142,195,255,222,73,226,46,171,114,80,169,15,9,51,73,190,249,190,111,102,221,113,13,59,94,88,44,33,131,232,65,228,70,40,201,245,107,191,52,90,200,223,9,168,229,11,230,102,16,255,216,162,28,43,181,182,219,167,18,245,140,151,235,116,132,102,138,5,157,226,234,151,135,136,220,209,80,73,137,30,38,238,181,91,226,25,162,128,159,14,149,149,6,62,100,112,27,195,91,187,197,52,26,171,37,24,109,145,46,30,218,173,29,113,89,113,195,167,202,234,28,137,15,21,120,168,227,200,193,61,43,141,60,255,3,209,119,124,245,53,39,92,232,115,174,65,16,8,121,84,22,202,57,116,97,112,227,132,250,124,234,1,128,151,240,190,108,42,201,234,154,21,130,67,246,72,1,152,57,141,46,78,137,148,211,215,121,228,27,236,28,15,89,174,164,17,210,107,100,236,224,22,135,131,148,52,194,187,126,106,90,58,197,178,164,221,9,159,119,30,113,31,76,119,97,103,225,200,142,69,105,250,51,187,45,176,63,178,98,149,64,69,249,189,221,179,96,39,134,53,31,14,146,166,126,33,77,2,67,85,20,129,141,139,7,244,235,85,58,107,222,164,83,218,162,168,84,146,73,100,2,245,87,144,162,143,61,218,250,181,198,208,121,202,117,187,213,245,19,172,185,88,164,223,200,191,91,200,178,198,0,164,247,68,97,135,63,213,126,162,197,134,200,17,45,187,145,94,69,141,195,26,32,84,89,226,30,174,247,230,63,221,169,81,24,187,212,148,192,121,234,83,226,167,39,140,95,58,83,83,95,40,138,47,111,126,78,26,208,236,252,244,238,242,193,151,203,212,215,184,119,196,184,102,206,178,26,167,122,189,164,143,96,125,12,252,20,135,213,45,7,255,245,222,220,52,90,55,86,124,69,141,139,254,177,155,132,219,252,55,248,11,216,153,10,207,149,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateResolveConflictsScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8ddea3d9-a4f3-47e0-b511-595f5b618389"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceb082c5-f5de-4934-bf9a-d8f2e1441ced"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"ResolveConflictsScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(665, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,74,45,206,207,41,75,117,206,207,75,203,201,76,46,41,214,208,180,230,229,114,203,204,201,113,73,44,73,212,200,43,205,201,1,9,232,235,7,165,166,21,165,22,103,56,149,150,148,228,231,21,7,151,36,150,164,66,212,22,165,150,148,22,229,41,148,20,149,166,90,3,0,197,240,57,121,77,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAddToLookupButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAddToLookupButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6ef02bf3-799f-46a6-a5bc-4e599a6f118e"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddToLookupButtonClickEventSubProcess",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(882, 257),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAddToLookupButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddToLookupButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ad532f3f-6bf6-4e25-a460-8f0b3d207028"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddToLookupButtonClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddToLookupButtonClickStartMessage",
				Position = new Point(22, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddToLookupButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("65850628-bbaf-465b-b7b6-65b94e6c95a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddToLookupButtonClickScript",
				Position = new Point(351, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,81,79,219,48,16,126,14,18,255,193,203,83,42,69,129,237,97,47,148,74,172,237,80,53,96,221,90,198,3,226,193,36,7,120,164,118,231,56,84,17,226,191,239,108,55,141,147,166,80,182,34,65,72,125,247,217,247,221,119,95,210,33,87,76,21,99,201,102,84,22,125,145,230,51,254,139,166,57,144,99,114,154,179,36,26,206,230,170,56,218,223,123,162,146,36,84,209,137,200,101,108,86,65,13,86,247,65,103,25,2,26,142,65,134,1,151,25,200,190,224,28,98,197,4,143,38,144,101,120,213,57,215,254,5,44,206,132,120,204,231,250,214,191,33,52,35,103,44,83,221,105,62,79,161,171,55,14,73,166,36,227,247,155,175,251,123,158,247,13,10,115,218,49,101,178,150,214,11,201,128,153,141,177,172,46,227,42,36,88,92,106,207,162,239,123,248,131,103,102,119,36,168,206,124,76,120,158,166,29,242,140,216,18,84,46,57,81,50,7,140,123,113,202,43,38,241,3,204,232,57,229,244,30,228,122,165,195,245,160,37,59,89,145,217,178,221,16,4,104,129,141,144,223,17,207,20,229,49,124,41,46,232,12,2,127,82,166,251,157,10,240,92,36,121,10,22,240,159,97,93,144,22,240,132,169,255,133,70,8,3,124,39,36,208,248,129,4,21,157,132,241,149,110,44,247,171,174,20,209,72,193,236,35,249,112,236,136,47,58,65,158,159,224,167,88,172,203,214,230,123,177,192,108,110,58,231,97,235,60,43,10,34,33,22,50,25,37,53,113,71,83,49,49,203,70,196,94,179,205,151,38,220,57,205,231,8,85,215,22,185,13,45,136,22,52,208,87,187,38,112,103,106,208,195,195,97,225,8,152,116,75,209,139,219,223,168,178,158,61,234,42,33,58,73,234,176,209,146,153,1,203,230,41,93,18,20,233,158,132,110,41,159,12,140,166,162,218,188,98,7,135,84,95,237,94,131,218,186,19,173,23,95,25,117,39,210,33,250,198,197,168,115,185,97,255,225,102,159,42,243,74,156,57,149,88,168,2,169,137,108,48,217,173,187,72,207,202,229,217,47,149,225,135,43,145,188,132,118,169,209,46,63,108,202,195,169,171,204,113,170,198,248,118,14,202,216,24,7,66,193,21,83,15,46,122,61,84,203,184,36,122,74,179,71,236,247,247,57,240,43,198,19,177,136,198,168,179,177,91,116,197,192,230,36,253,47,200,82,153,134,117,141,131,202,17,49,246,47,42,87,46,171,22,175,131,224,167,253,92,74,60,178,157,73,141,128,64,75,211,244,14,14,218,211,250,169,200,224,28,119,177,225,62,174,98,179,181,94,70,124,42,1,78,37,75,252,205,187,54,211,91,163,76,144,69,105,12,105,171,11,183,13,244,143,28,112,246,236,48,14,155,159,7,45,179,94,151,134,153,183,202,83,208,1,53,61,86,187,13,175,48,136,122,138,237,170,49,206,225,50,161,82,94,167,89,140,77,251,202,82,221,234,53,19,176,171,125,35,47,27,163,69,86,9,37,176,31,246,197,12,245,194,50,193,167,197,28,162,225,159,156,166,246,233,106,78,241,150,250,59,13,215,172,30,179,173,53,162,27,14,27,113,65,221,62,12,94,245,4,168,226,162,190,200,185,34,61,114,184,116,249,205,211,224,154,118,5,112,125,120,163,247,215,101,38,142,133,152,23,135,94,80,111,80,100,150,204,153,79,82,70,51,115,170,23,2,105,6,118,243,117,81,109,122,18,31,53,195,119,166,43,67,59,75,182,146,84,13,1,89,168,89,169,121,90,219,78,238,82,96,26,206,123,77,101,239,80,152,183,75,121,109,167,175,205,61,110,188,16,29,145,181,240,221,245,216,91,190,139,85,94,176,181,133,180,216,199,238,251,251,102,131,107,47,151,225,59,167,178,84,183,37,164,83,171,97,71,90,216,82,12,59,182,155,150,142,182,122,142,103,94,96,205,31,253,123,139,221,120,180,95,72,220,111,40,127,1,98,120,0,3,199,13,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskAddOpenWindowUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("5a253e06-64e8-459e-90b5-b72a2250e0ca"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"UserTaskAddOpenWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(491, 41),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskAddOpenWindowParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("010b051c-382a-4290-9642-3998d7cc8a4d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateAddToLookupDataClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f85f08c1-e203-47dc-aad0-8034a3a46a17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddToLookupDataClickScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 153),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,209,78,219,48,20,125,54,18,255,96,242,148,170,85,180,161,193,30,2,72,208,118,40,90,134,42,2,123,97,104,50,201,109,103,145,216,149,237,180,116,211,254,125,215,113,155,38,13,211,168,22,181,113,109,31,31,159,123,124,125,27,203,89,36,166,210,247,46,179,236,78,198,82,62,151,243,17,51,108,152,243,244,57,73,21,159,155,241,11,164,165,129,239,137,97,202,120,189,240,240,96,193,20,205,16,148,200,82,165,64,207,233,53,152,81,221,247,123,33,57,60,112,40,174,145,55,202,52,98,162,205,79,166,105,204,181,57,187,46,121,118,129,108,27,76,128,141,191,165,13,46,83,195,23,112,43,151,19,197,11,166,86,67,153,151,133,248,202,242,18,172,136,9,155,65,208,80,125,85,26,35,69,48,22,236,41,135,12,55,156,178,92,67,184,81,2,194,112,195,193,42,185,215,160,134,82,8,192,13,112,69,2,90,99,107,3,120,240,110,96,185,53,193,123,172,197,222,149,243,28,42,201,3,170,141,226,98,246,247,246,240,128,144,207,176,170,148,78,24,87,173,101,23,3,58,226,213,198,24,210,25,23,102,64,49,176,220,105,177,253,11,124,172,43,83,234,215,154,143,206,169,40,243,188,71,127,33,247,84,42,234,35,144,114,140,229,93,136,205,89,29,93,48,148,165,48,56,214,239,59,48,105,242,60,240,199,32,50,80,188,183,132,111,116,218,177,144,84,34,135,40,173,159,132,252,182,47,251,173,141,93,37,233,15,40,216,23,38,240,84,84,215,227,113,23,20,190,70,128,43,95,225,11,48,191,34,161,13,19,41,92,173,238,163,172,19,209,105,128,134,247,66,218,230,220,97,11,134,10,152,1,167,197,111,43,236,85,114,28,26,51,194,140,96,218,112,65,251,187,243,141,73,191,181,71,203,194,224,134,21,48,160,246,252,3,204,44,219,250,189,125,169,70,92,207,115,214,102,220,141,255,184,77,202,22,208,84,236,128,232,6,17,176,164,251,166,114,245,252,87,62,111,105,8,233,38,227,43,209,188,105,232,195,160,201,75,118,167,79,186,43,78,187,67,31,157,77,251,148,132,243,154,36,220,92,176,163,72,39,43,145,58,24,242,76,177,122,26,189,185,59,206,40,90,32,41,102,51,174,119,3,193,39,169,10,102,124,172,97,245,22,183,144,74,149,197,50,101,57,255,105,11,89,210,62,8,239,155,231,209,126,39,138,19,28,179,83,255,194,29,175,113,46,104,18,203,217,248,37,133,60,42,230,82,25,236,249,107,141,235,249,70,137,136,37,203,176,64,236,81,159,177,76,16,87,37,158,240,218,61,219,17,172,27,248,137,223,254,151,51,22,89,165,85,129,41,149,160,70,97,1,250,3,183,204,191,148,178,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckRequiredFieldsScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5ad98d8e-20b1-40a3-ae3c-a0eb59e4ce7b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"CheckRequiredFieldsScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,83,77,79,195,48,12,61,119,210,254,131,217,105,211,166,8,56,112,89,59,9,198,135,42,96,32,198,184,32,14,161,53,16,209,38,35,31,160,10,248,239,184,77,233,54,86,170,86,150,45,251,249,189,215,36,54,87,18,79,5,102,233,13,190,57,161,49,133,8,172,118,56,238,118,222,185,134,148,91,62,87,78,39,72,245,51,180,199,77,222,31,140,3,223,131,210,10,43,208,80,199,194,160,158,42,41,49,177,66,73,54,71,99,40,150,67,247,189,25,126,92,40,245,234,150,101,218,123,0,110,224,66,24,27,222,186,101,134,225,153,19,233,8,140,213,66,62,255,31,187,157,32,56,199,226,142,103,14,175,185,208,27,99,147,17,28,139,106,49,215,69,40,164,29,193,84,101,153,231,82,230,19,122,72,151,120,130,126,195,121,39,2,233,178,108,0,159,132,253,164,52,244,169,17,4,105,217,29,83,8,27,117,108,170,156,180,84,27,14,125,115,176,142,115,47,30,88,108,49,223,131,40,90,51,141,29,210,242,119,188,81,31,215,90,228,68,139,8,185,92,86,252,107,148,160,177,176,152,39,47,152,243,75,46,249,51,234,109,55,79,182,155,198,173,8,52,218,2,200,232,247,197,210,88,46,19,60,42,22,113,186,69,254,128,145,183,3,143,217,136,251,197,220,48,170,94,170,235,51,83,29,32,83,25,84,25,183,234,72,42,189,230,15,35,230,109,48,117,35,217,142,60,121,129,254,106,2,132,252,157,109,54,86,156,124,145,213,167,53,39,212,219,98,137,37,187,117,123,60,254,159,38,54,83,18,87,104,65,11,251,225,176,166,20,124,251,88,135,184,237,154,180,169,15,35,216,135,175,175,77,181,51,158,99,121,46,122,39,249,50,83,5,98,207,111,241,224,143,36,254,181,42,148,57,125,244,118,59,26,173,211,210,95,197,31,1,109,65,42,165,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateResolveConflictsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("97338d58-bc55-4bcd-80f2-7231ad720eb6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"ResolveConflictsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(652, 153),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,74,45,206,207,41,75,117,206,207,75,203,201,76,46,41,214,208,180,230,229,210,215,15,74,77,43,74,45,206,112,42,45,41,201,207,43,14,46,73,44,73,133,72,21,165,150,148,22,229,41,148,20,149,166,90,3,0,123,59,80,68,60,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("842cab6d-cc04-48c8-af15-6471e105f2b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"AddNewDataInTreeGrid",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(813, 167),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateUserTaskAddOpenWindowClosedIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("ce5e0970-6d5d-4b31-a6c2-bb067f3255e5"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8f17df-f91d-4f49-bc29-f27659189eb1"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"UserTaskAddOpenWindowClosed",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"UserTaskAddOpenWindowClosedIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(617, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateTreeGridDblClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaTreeGridDblClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("82cfbd51-03d7-4b94-88dc-01868295ce9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc200a17-9024-488c-a347-84ac5419c5ac"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"TreeGridDblClickEventSubProcess",
				Position = new Point(36, 4),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(668, 207),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaTreeGridDblClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridDblClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bc74c068-f395-4df4-a0b2-3ec44d4d0e96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82cfbd51-03d7-4b94-88dc-01868295ce9a"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TreeGridDblClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"TreeGridDblClickStartMessage",
				Position = new Point(43, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBindToLookupDataButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("815fe998-f3ec-452d-b6bd-afae62bf5f49"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82cfbd51-03d7-4b94-88dc-01868295ce9a"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BindToLookupDataButtonClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"BindToLookupDataButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(476, 18),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b870be96-d481-441c-a2fd-0fff39a3061b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82cfbd51-03d7-4b94-88dc-01868295ce9a"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOpenContactEditPageEventIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0bb18869-bce6-4b9f-be64-d92c24fbb5c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82cfbd51-03d7-4b94-88dc-01868295ce9a"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OpenContactEditPageEvent",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"OpenContactEditPageEventIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(476, 95),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateTreeGridRowSelectedCheckExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("71c3d040-c61e-4f1e-b283-f46f8403c8e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82cfbd51-03d7-4b94-88dc-01868295ce9a"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"TreeGridRowSelectedCheck",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("79cd02d7-6cda-48a7-9302-03cf41ec5463"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82cfbd51-03d7-4b94-88dc-01868295ce9a"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"End1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(245, 18),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCancelButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCancelButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("093271d1-9461-4aa2-aa16-dbfd648d6ef8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c97ac0a1-8556-453b-901c-97de45c1daa4"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"CancelButtonClickEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(276, 170),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCancelButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCloseButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("da7f96e6-8ed5-48ac-91bd-4d562fb2c7fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("093271d1-9461-4aa2-aa16-dbfd648d6ef8"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CloseButtonClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"CloseButtonClickStartMessage",
				Position = new Point(29, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d1991b1e-6198-4c54-9652-2810df80429c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("093271d1-9461-4aa2-aa16-dbfd648d6ef8"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"CancelButtonClickScript",
				Position = new Point(92, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,65,75,196,48,16,133,239,130,255,33,228,148,130,132,189,47,30,164,42,4,150,69,88,23,15,198,67,182,157,150,98,118,166,204,76,169,34,254,119,19,189,232,201,211,27,152,247,61,222,219,209,24,112,32,39,202,19,142,254,158,248,156,212,217,168,81,63,54,159,85,218,76,2,102,157,176,167,213,68,187,135,117,71,244,186,204,183,73,211,67,26,33,90,227,162,109,19,118,144,203,125,90,84,9,205,204,32,2,125,99,175,204,221,91,249,132,243,76,172,161,111,154,237,229,197,81,128,91,66,132,78,39,66,127,40,214,162,53,240,249,111,190,125,49,215,6,151,156,255,129,130,28,222,177,251,225,138,103,200,83,167,242,27,118,181,169,191,145,185,170,73,98,30,129,57,9,13,234,143,193,63,193,169,80,202,148,197,87,67,227,191,71,187,218,149,65,23,70,163,188,192,246,11,77,221,169,121,45,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAddNewDataInTreeGridEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAddNewDataInTreeGridEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1cdc1444-3a70-4937-b600-2dc0ba908dce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6ef02bf3-799f-46a6-a5bc-4e599a6f118e"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddNewDataInTreeGridEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(932, 13),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(301, 203),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAddNewDataInTreeGridEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddNewDataInTreeGridStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("071f2c46-cfc3-44aa-b0c2-1a393c6350d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1cdc1444-3a70-4937-b600-2dc0ba908dce"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AddNewDataInTreeGrid",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddNewDataInTreeGridStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 91),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddNewDataInTreeGridScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b8866549-72b2-4083-8ea4-7f852f8ecc29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1cdc1444-3a70-4937-b600-2dc0ba908dce"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddNewDataInTreeGridScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,221,79,219,48,16,127,78,165,254,15,38,15,40,133,42,221,166,193,164,181,69,130,126,160,104,29,98,180,236,133,241,96,146,43,181,112,236,202,118,202,178,137,255,125,231,36,13,233,215,0,109,125,168,237,203,221,239,126,247,145,115,22,84,145,136,26,58,150,137,10,129,116,201,57,152,126,121,246,26,109,167,94,107,29,176,41,241,158,181,252,211,208,176,5,92,201,71,210,237,18,145,112,222,168,215,28,5,38,81,130,24,149,64,251,160,85,175,237,178,185,84,44,166,42,237,73,158,196,226,59,229,9,88,148,243,132,69,254,32,158,155,180,65,126,175,161,213,107,79,245,26,210,104,145,83,63,208,15,51,250,32,23,159,137,153,1,9,101,4,228,14,56,50,153,81,141,59,16,132,195,212,224,46,164,137,6,34,167,100,240,51,4,30,196,115,169,140,79,2,67,4,64,68,140,68,21,162,32,150,11,136,90,10,166,52,52,82,65,100,253,44,48,37,76,159,70,81,16,105,76,72,176,220,162,131,17,211,166,99,169,158,32,169,165,142,143,203,43,35,109,160,217,37,189,7,107,50,145,35,41,31,146,249,89,98,140,20,254,64,208,59,142,204,186,100,74,185,182,65,91,30,32,12,51,12,44,143,107,13,170,39,133,0,132,71,253,49,104,141,171,173,213,141,123,1,143,57,152,61,186,183,37,213,73,50,231,144,17,110,18,109,20,19,247,187,87,76,186,243,5,210,140,231,37,101,106,197,236,164,73,250,44,115,140,1,117,152,48,77,130,97,241,156,139,61,159,224,175,157,23,189,228,188,151,55,7,217,223,39,3,43,75,183,148,126,111,179,244,83,169,136,135,144,132,97,212,239,218,184,116,202,60,248,61,153,8,131,178,195,195,92,217,169,122,188,97,183,126,96,32,126,111,59,234,149,21,201,81,156,50,217,233,56,156,65,76,191,82,129,117,82,155,121,31,108,42,181,183,34,160,233,22,64,31,223,175,64,104,67,69,8,103,233,117,16,109,144,63,246,177,10,141,103,76,158,21,54,119,187,134,233,247,20,80,3,249,51,111,149,104,129,96,211,83,69,240,135,96,194,217,80,201,184,127,230,237,170,74,99,153,21,167,66,14,125,59,2,30,201,91,123,202,249,199,182,90,130,108,86,185,185,146,27,155,217,73,58,135,168,18,72,167,112,227,173,100,173,8,184,207,244,156,211,34,110,255,130,198,208,40,25,255,127,224,117,246,31,75,95,235,79,142,54,149,143,55,69,159,138,2,59,249,191,237,20,129,13,78,21,186,51,89,227,218,98,125,75,64,165,165,208,115,81,197,109,174,183,116,47,81,10,225,173,212,198,90,28,113,148,192,132,197,120,7,52,137,187,60,184,75,175,214,95,248,108,135,104,6,71,104,16,189,68,160,98,19,68,110,179,72,193,95,8,149,200,171,241,218,190,222,11,244,56,21,97,62,249,80,111,202,177,151,116,217,187,78,94,35,18,227,164,196,87,15,9,229,2,127,40,85,76,141,135,51,184,156,155,87,16,74,21,141,100,72,57,251,101,7,241,120,181,131,29,199,253,225,186,228,112,163,12,71,40,179,143,94,214,252,80,104,46,227,112,70,242,190,114,55,225,201,43,152,46,53,158,242,165,213,122,203,232,239,150,142,11,148,59,156,17,15,249,62,3,180,127,79,229,149,90,153,146,35,73,35,156,145,222,218,23,192,75,247,217,54,12,237,217,39,187,105,251,87,217,205,235,245,97,154,225,232,32,242,39,50,207,185,215,176,182,67,198,185,213,244,178,207,11,20,84,63,8,254,0,23,34,202,6,181,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAddEmployeeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAddEmployeeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bbf1ab37-9bdc-4a3a-b831-45c7b5274116"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a6556e4-d49c-4a69-84e8-ed667b58c5a2"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddEmployeeEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(265, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAddEmployeeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddEmployeeClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d5027e3c-a61e-4af0-95a1-05ae386a1971"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bbf1ab37-9bdc-4a3a-b831-45c7b5274116"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddEmployeeButtonClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddEmployeeClickStartMessage",
				Position = new Point(29, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddEmployeeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a6e71cae-49b1-4e3e-8368-39ee50da9160"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bbf1ab37-9bdc-4a3a-b831-45c7b5274116"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddEmployeeScriptTask",
				Position = new Point(92, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,86,77,111,226,48,16,61,83,169,255,193,229,228,168,40,106,207,20,164,182,208,10,109,133,42,96,119,15,136,131,155,12,197,106,98,179,182,67,55,90,245,191,239,216,78,66,210,208,110,219,195,34,132,137,237,121,243,230,59,124,77,232,201,68,207,115,17,221,73,249,148,109,175,165,88,39,60,50,58,32,127,142,143,58,10,76,166,4,89,179,68,67,191,115,124,244,114,124,196,215,244,158,61,66,184,80,0,183,138,199,225,28,18,136,12,196,83,25,131,14,175,101,38,12,25,12,200,89,208,2,112,242,59,166,136,2,45,147,29,196,149,54,50,32,2,158,201,29,215,230,226,54,227,241,144,6,125,127,21,132,225,134,131,189,241,93,131,66,9,129,218,184,20,168,87,107,92,71,204,176,101,119,10,207,222,0,251,216,93,17,166,61,216,34,219,38,224,32,123,68,27,197,197,227,219,43,210,117,159,111,144,255,96,73,6,247,140,171,134,232,176,71,70,220,41,103,42,191,224,194,244,200,181,76,18,207,199,62,15,241,211,47,77,76,229,14,38,6,210,134,113,255,159,143,243,228,90,42,96,209,134,90,102,2,227,68,184,32,239,68,209,7,159,99,114,216,203,161,211,174,151,221,121,180,129,148,77,226,238,42,92,200,185,163,64,3,114,50,32,227,116,155,200,28,160,188,224,229,59,145,196,224,137,204,6,190,131,145,199,95,175,133,104,191,120,191,248,61,218,140,110,96,229,49,153,146,44,21,180,59,2,141,64,204,30,204,32,146,42,70,14,205,27,213,198,141,146,41,237,54,147,185,56,250,185,1,5,229,153,167,58,101,41,116,131,112,162,199,191,50,150,80,143,22,222,51,133,251,6,84,211,124,47,216,93,5,30,238,82,196,77,176,17,215,219,132,229,30,228,83,200,254,244,131,200,78,232,195,208,55,60,1,199,165,14,30,132,227,223,152,141,154,186,20,123,63,8,7,156,92,185,25,175,26,86,250,119,239,225,114,187,71,156,72,197,244,112,28,235,180,166,210,124,149,92,161,180,197,177,204,205,215,36,171,125,100,89,147,253,23,89,219,89,60,31,155,213,248,205,52,150,1,113,149,21,63,140,127,67,148,25,169,218,221,106,44,116,166,96,116,181,223,162,65,81,38,53,4,172,210,24,172,180,175,144,208,227,193,204,109,211,61,126,41,218,121,222,96,124,169,23,11,237,53,68,245,39,29,219,41,72,84,90,214,102,52,186,90,228,91,192,141,29,40,76,27,124,118,57,179,144,86,176,128,92,158,173,108,251,168,195,185,138,250,50,222,121,133,103,84,94,216,224,131,60,17,8,247,70,144,49,106,19,97,100,59,152,120,48,7,83,15,190,107,129,205,122,168,124,16,148,82,165,95,235,30,45,104,189,144,136,25,236,148,243,92,99,239,14,237,56,193,20,75,83,107,32,94,142,96,107,121,185,80,23,255,75,127,191,248,165,53,219,194,203,56,166,123,199,21,138,220,237,23,223,24,93,167,109,203,249,81,58,196,73,234,29,101,189,52,194,188,64,222,135,188,244,78,235,171,146,222,103,184,56,160,172,168,177,136,12,134,7,60,24,236,31,2,236,253,151,74,177,156,22,149,91,250,50,232,215,172,169,198,54,78,7,145,37,73,97,2,206,33,66,113,48,17,142,249,115,214,199,229,162,154,240,222,94,220,59,61,45,179,187,142,180,228,171,208,142,211,115,251,114,97,93,225,210,170,209,235,94,77,166,170,72,58,181,97,236,162,81,195,44,227,254,128,9,250,212,14,141,123,225,121,203,156,98,170,250,210,229,136,110,199,106,77,87,161,191,50,112,230,142,168,189,89,57,235,51,47,53,131,202,87,254,85,10,123,123,98,143,168,163,132,123,51,88,99,100,55,87,153,49,82,232,185,97,6,116,117,88,188,138,25,133,3,249,47,31,199,138,36,248,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateIgnoreEmployeeButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaIgnoreEmployeeButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("45998d3d-7a4d-4977-a5b1-6e4b75deab11"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a6556e4-d49c-4a69-84e8-ed667b58c5a2"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"IgnoreEmployeeButtonClickEventSubProcess",
				Position = new Point(316, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(311, 165),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaIgnoreEmployeeButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateIgnoreEmployeeButtonClickStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2332c79f-25a6-433b-a093-a97b106f02ae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45998d3d-7a4d-4977-a5b1-6e4b75deab11"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"IgnoreEmployeeButtonClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"IgnoreEmployeeButtonClickStartMessage1",
				Position = new Point(42, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIgnoreEmployeeButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1d9d30fd-48dd-4c6a-95a1-9cf6e049f556"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45998d3d-7a4d-4977-a5b1-6e4b75deab11"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"IgnoreEmployeeButtonClickScriptTask",
				Position = new Point(154, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,77,111,226,48,16,61,7,137,255,224,230,148,168,200,237,158,129,74,93,160,21,218,10,161,66,119,15,136,131,55,25,138,85,199,102,253,209,46,90,241,223,59,182,67,68,86,221,170,61,109,14,118,226,153,121,243,50,111,198,124,67,178,179,169,89,236,101,113,167,212,147,219,141,148,220,8,94,88,147,147,63,221,78,162,193,58,45,201,134,9,3,253,164,219,57,116,59,28,67,230,236,17,232,82,3,220,106,94,210,5,8,40,44,148,51,85,130,161,35,229,164,37,195,33,185,124,3,34,32,60,51,77,64,90,110,57,24,50,36,15,6,52,166,149,136,193,149,68,52,99,112,31,51,203,86,233,12,94,34,47,255,153,174,9,51,228,142,27,59,88,186,157,128,193,173,227,101,143,24,171,185,124,252,247,142,28,194,243,13,246,223,153,112,48,103,92,183,66,175,122,100,204,67,114,166,247,3,46,109,143,140,148,16,145,143,255,190,194,167,31,121,107,168,212,51,76,45,84,158,186,132,151,255,197,39,203,145,209,70,105,96,197,54,243,204,36,86,159,112,73,222,209,38,10,226,5,244,206,52,100,55,171,116,81,108,161,98,211,50,93,211,165,90,4,10,89,78,206,134,100,82,237,132,218,3,28,29,98,124,82,40,20,79,58,175,102,114,72,176,43,146,88,153,66,233,242,97,90,214,117,241,127,212,206,243,87,134,220,55,84,226,93,199,72,210,66,214,110,132,220,167,162,55,90,85,89,218,238,205,52,154,126,108,65,195,209,22,41,206,88,5,105,78,167,102,242,203,49,145,97,213,92,37,233,156,105,60,183,160,219,116,98,96,186,206,35,220,181,44,219,96,99,110,118,130,237,35,200,167,144,163,245,131,200,33,232,195,208,55,92,64,224,82,131,95,92,28,235,128,213,125,7,164,81,167,71,82,175,76,26,194,233,228,55,20,14,75,143,90,36,117,107,52,147,137,13,32,157,16,181,232,216,106,36,195,222,35,28,245,189,236,227,54,104,134,56,206,60,158,157,159,215,222,45,164,21,95,83,63,49,95,252,173,208,16,57,122,38,39,35,69,175,203,242,52,204,247,184,119,249,137,109,254,20,223,15,126,245,203,161,185,141,222,102,92,207,6,9,195,193,17,221,15,199,73,174,58,127,243,15,247,193,148,121,207,144,214,231,248,204,213,52,108,202,17,111,57,84,74,120,83,22,40,225,217,61,108,52,152,237,87,103,173,146,102,97,153,5,211,24,235,91,210,106,28,171,87,249,69,221,36,149,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOKButtonEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOKButtonEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f2b2b853-1ba4-421a-a7ac-e3a685007431"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0552f5c0-22a4-4246-b2a8-c81d7a820a56"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"OKButtonEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOKButtonEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ad9fa8e0-5911-4ccd-89c2-6d6e6f8ff557"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f2b2b853-1ba4-421a-a7ac-e3a685007431"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"OKButtonClickStartMessage",
				Position = new Point(29, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOKButtonScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4f72b873-c5fb-488d-9b69-7658d7ff862b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f2b2b853-1ba4-421a-a7ac-e3a685007431"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"OKButtonScriptTask",
				Position = new Point(92, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,65,75,3,49,16,70,239,66,255,195,144,83,22,36,120,151,30,164,42,44,22,21,218,226,193,120,72,119,103,151,197,52,179,204,76,216,138,248,223,77,234,209,211,187,60,222,247,109,105,108,211,64,86,148,167,52,186,71,226,83,80,107,188,122,253,190,249,169,216,68,18,132,101,74,61,45,224,205,51,46,91,162,207,60,223,7,13,175,97,68,111,192,122,243,242,84,120,204,170,148,96,102,20,193,190,49,215,240,112,238,48,182,167,153,88,219,190,105,110,87,87,7,65,222,80,74,216,233,68,201,237,138,90,88,99,239,255,219,187,220,117,69,24,114,140,95,151,31,189,249,128,53,128,114,198,210,178,213,113,119,50,87,66,16,216,35,115,16,26,212,29,90,247,134,199,50,164,76,81,92,21,26,119,73,216,250,130,81,51,167,191,206,47,185,8,118,84,3,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAddSelectedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAddSelectedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("07f3ed87-9b2a-43fc-99ea-31875cdd45a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ca1c4fb-8169-4ec4-94a9-403073b14598"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddSelectedEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAddSelectedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddSelectedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4b3c4d85-c36d-4cb6-9f19-01aa74cffc43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07f3ed87-9b2a-43fc-99ea-31875cdd45a2"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddSelectedButtonClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddSelectedStartMessage",
				Position = new Point(29, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddSelectedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("95e4541b-9b5f-49b2-9bce-376e030b5625"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07f3ed87-9b2a-43fc-99ea-31875cdd45a2"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"AddSelectedScriptTask",
				Position = new Point(92, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,223,79,219,48,16,126,110,165,254,15,94,159,18,45,10,108,26,236,161,80,105,180,128,170,117,172,162,176,23,202,131,73,174,197,91,98,119,182,211,210,1,255,251,206,113,219,216,129,109,130,85,162,198,190,31,190,251,238,187,115,135,98,54,224,83,17,40,45,25,159,197,39,66,230,84,7,237,137,158,232,251,221,71,179,124,74,83,194,97,73,50,33,126,20,243,136,40,77,165,38,193,146,241,84,44,201,164,125,6,203,97,41,234,83,77,71,116,6,147,118,216,142,200,241,93,2,217,32,159,11,169,7,105,24,118,90,205,5,149,36,69,157,177,40,100,2,228,144,156,130,238,111,247,193,70,37,219,58,67,149,75,5,178,39,56,135,68,51,193,227,49,40,133,171,17,94,249,23,183,175,9,85,100,200,148,62,184,40,230,25,28,156,22,44,53,193,154,180,254,188,182,154,141,198,103,88,125,163,89,1,35,202,164,103,214,141,72,159,149,23,83,185,58,96,92,71,164,39,178,204,198,98,246,93,252,96,212,95,111,48,202,5,189,201,192,17,27,71,93,162,192,236,33,29,104,200,21,230,83,229,143,185,84,162,145,100,57,222,129,230,69,206,203,96,20,250,101,83,18,184,104,28,18,94,100,25,121,120,240,221,198,61,81,112,109,196,187,33,185,199,140,36,232,66,114,162,101,1,232,229,209,194,10,92,51,205,192,4,17,76,165,200,237,193,138,48,238,32,110,224,104,52,190,11,60,116,175,24,164,164,118,162,136,224,107,15,177,217,191,35,240,179,160,153,170,153,89,127,246,108,173,30,198,23,194,148,169,172,119,171,185,179,115,124,7,73,161,193,82,165,100,141,173,106,176,137,56,92,67,81,101,96,129,248,91,178,46,249,70,84,210,28,52,72,76,221,34,28,111,143,2,159,166,29,7,171,213,56,185,133,156,126,161,28,57,45,159,114,241,248,169,210,51,230,6,111,211,61,14,145,44,197,92,243,110,9,198,84,72,160,201,45,9,42,31,6,246,45,12,101,186,198,152,204,204,23,246,15,46,49,118,129,89,75,15,13,203,91,178,48,12,26,240,163,121,142,90,78,149,222,119,54,30,220,16,47,7,169,175,182,31,99,75,24,85,55,70,207,196,8,77,73,222,120,169,34,17,185,166,140,43,52,15,106,55,132,54,252,134,123,188,189,213,3,49,198,177,48,224,56,101,120,2,71,43,52,125,226,170,83,119,164,98,28,82,117,181,200,115,94,26,61,18,200,20,252,51,16,117,85,115,117,93,26,227,223,141,16,153,65,151,97,31,195,57,82,158,73,48,224,77,145,250,134,126,141,106,128,89,236,106,158,227,30,150,88,131,149,5,62,161,202,8,93,91,156,16,186,15,83,119,40,4,207,42,57,26,30,8,177,55,86,226,51,164,124,84,114,231,85,94,250,76,205,51,234,59,171,136,246,140,75,186,128,160,142,149,203,210,28,135,57,22,28,33,242,31,31,172,229,118,180,159,67,34,100,58,20,9,250,249,101,38,236,216,25,220,141,246,164,221,38,111,93,234,238,225,214,156,70,174,220,105,7,43,13,55,165,74,196,124,181,45,148,105,211,151,188,29,255,245,110,4,21,7,237,0,141,188,70,117,161,245,36,31,188,221,158,183,219,247,118,31,157,146,152,217,94,246,72,149,112,93,122,14,185,88,108,42,95,10,135,98,230,76,71,220,5,235,138,133,118,208,182,154,47,121,157,15,157,103,6,237,79,88,150,153,127,131,114,146,227,193,240,197,63,68,128,167,175,249,25,226,62,24,191,1,179,171,131,211,254,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSelectAllEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSelectAllEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bc6c5e29-6c37-4336-bbb0-31ad22bc6d24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3df87f40-9e62-4ceb-9c5f-7669b5cdcaee"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"SelectAllEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSelectAllEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSelectAllStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6177b940-3aed-40d2-b293-b21a0bb0ae1a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bc6c5e29-6c37-4336-bbb0-31ad22bc6d24"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SelectAllButtonClick",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"SelectAllStartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSelectAllScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3bb979d6-b7e4-4d30-932e-c796ad0545ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bc6c5e29-6c37-4336-bbb0-31ad22bc6d24"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"SelectAllScriptTask",
				Position = new Point(92, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,81,193,74,3,49,16,61,183,208,127,24,246,180,11,203,162,231,214,130,180,90,22,23,41,84,189,184,30,194,102,90,131,217,164,76,38,174,165,244,223,77,182,88,233,193,131,205,101,24,230,189,121,239,101,42,187,41,205,218,166,142,73,153,77,113,111,169,21,156,38,53,215,188,191,58,196,178,66,141,13,131,208,26,12,118,160,173,253,240,219,28,28,11,98,72,59,101,164,237,160,78,30,177,171,250,209,92,176,88,138,13,214,73,150,228,112,247,213,160,46,219,173,37,46,101,150,141,71,195,79,65,32,3,102,101,61,53,8,55,176,64,158,159,250,244,7,130,134,21,43,116,1,240,236,144,102,214,152,96,67,89,83,172,208,185,80,35,231,245,92,54,121,3,225,160,82,142,39,79,126,171,113,178,240,74,70,171,49,219,223,117,52,28,12,30,112,247,34,180,199,165,80,116,70,155,230,48,87,189,176,160,221,68,25,206,97,102,181,62,122,137,253,52,188,224,249,55,82,113,252,49,148,37,99,187,36,213,6,98,160,248,214,244,10,174,152,105,20,212,7,93,91,66,209,188,67,122,74,188,3,101,78,217,51,216,7,111,255,216,124,43,101,122,92,83,68,200,117,212,56,140,134,213,165,71,70,35,47,57,49,33,123,50,192,228,113,252,13,55,111,80,185,97,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("49f0ecaa-8b77-4a86-93e4-ac32c8e99aee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3377275-227e-4e2b-a72d-e1aedc83a5e0"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(413, 28),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(284, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildPageInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("98aa64f2-78b6-4e00-929e-afa665f1f74b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49f0ecaa-8b77-4a86-93e4-ac32c8e99aee"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"ChildPageInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBasePageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("42173148-9348-40e8-8877-0a68140d3933"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49f0ecaa-8b77-4a86-93e4-ac32c8e99aee"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"BasePageInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildPageInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("61498653-b55e-4dd5-ab48-26000399b566"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("49f0ecaa-8b77-4a86-93e4-ac32c8e99aee"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Name = @"ChildPageInitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,76,73,9,78,205,73,77,46,73,77,113,42,45,41,201,207,211,115,204,74,172,112,45,75,205,43,41,214,115,206,201,76,206,214,11,201,204,77,205,47,45,81,176,85,48,52,50,0,3,107,94,174,0,144,102,136,78,199,156,28,146,180,22,165,150,148,22,229,41,148,20,149,166,90,3,0,176,180,100,214,132,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateIsContactSelectedMethod());
			Methods.Add(CreateGetEntitySchemaByNameMethod());
			Methods.Add(CreateFillEntityByTupleMethod());
			Methods.Add(CreateResolveConflictsMethod());
			Methods.Add(CreateRefreshButtonsStatesMethod());
			Methods.Add(CreateLogInfoMethod());
			Methods.Add(CreateLogExcelImportLogMethod());
			Methods.Add(CreateExecuteImportExcelLookupMethod());
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
				UId = new Guid("0dee7b99-a10a-43a8-92cf-957bd89930cd"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1ff88c3f-9308-4698-88ac-7d83efb18a93"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("71df11d8-5543-4198-929a-6a80e3ed540a"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("a46a47cf-e8b1-4478-9d05-9dd8d463a60f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4032cedd-b8b1-4af5-8992-865b7bad361c"),
				Name = "Terrasoft.Core.Scheduler",
				Alias = "",
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5d8dd2f4-8f09-4197-bfc9-9ef435b45178"),
				Name = "Terrasoft.Configuration.ImportExcelData",
				Alias = "",
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110")
			});
		}

		protected override SchemaMethod CreateGetEntityMethod() {
			SchemaMethod method = base.CreateGetEntityMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,193,78,195,48,12,64,207,173,212,127,48,59,181,82,85,137,243,218,29,104,217,52,49,1,98,48,14,136,67,212,122,16,17,146,201,113,54,77,104,255,78,210,110,19,59,144,67,44,39,206,123,118,182,130,0,53,75,150,104,161,130,23,139,84,27,173,177,101,105,116,177,68,107,125,108,4,139,183,209,61,238,22,198,124,185,77,72,71,239,32,44,44,164,229,242,217,109,20,150,51,39,187,28,44,147,212,31,255,199,36,142,162,59,220,175,132,114,248,40,36,93,60,155,228,208,200,94,44,104,95,74,205,57,212,70,169,161,151,144,79,252,26,39,177,92,67,122,238,249,170,2,237,148,202,224,199,179,183,167,105,246,125,83,126,160,83,93,241,250,137,132,41,67,53,1,46,230,140,223,215,80,85,64,216,26,234,230,93,86,76,37,89,126,160,6,215,194,41,78,51,239,137,206,162,35,238,194,213,203,200,236,188,100,134,28,254,100,105,28,181,152,102,69,77,40,24,159,204,110,192,68,83,169,212,109,207,185,25,72,127,169,121,128,12,117,132,236,72,135,124,28,69,254,224,16,246,67,18,39,241,241,38,216,125,229,47,151,16,89,248,181,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetStructureDefinitionMethod() {
			SchemaMethod method = base.CreateGetStructureDefinitionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,150,93,79,194,48,20,134,175,221,175,104,118,53,18,132,123,65,137,66,84,18,98,52,32,55,198,139,178,21,173,118,237,210,110,232,2,252,119,187,47,200,182,110,140,49,141,87,219,206,121,223,157,211,167,39,77,87,144,3,225,114,207,116,61,142,192,37,160,232,11,76,176,112,251,35,108,186,152,81,200,253,190,204,99,250,214,6,108,241,129,76,247,234,202,104,245,180,149,244,153,140,120,54,141,77,197,122,176,214,206,214,250,3,180,145,222,6,250,216,210,183,237,32,48,135,196,67,195,240,23,185,220,8,11,135,64,191,40,11,93,24,186,103,190,19,102,238,60,156,228,134,208,9,218,72,233,199,98,142,5,94,144,64,187,132,68,160,36,60,101,220,133,138,248,35,199,182,92,72,84,94,38,37,31,180,213,182,61,109,71,170,115,109,89,70,180,126,9,67,171,69,98,194,216,167,231,20,211,72,229,149,68,210,138,44,149,25,250,118,115,84,34,75,252,125,44,158,50,4,221,46,184,247,108,72,207,151,28,35,106,17,31,88,59,14,128,202,134,79,129,148,244,127,128,85,90,86,130,44,35,108,130,92,56,35,121,112,191,51,58,241,100,22,226,72,229,149,28,210,138,74,0,34,203,159,140,78,12,165,254,216,164,122,61,196,169,194,216,40,133,77,80,171,59,54,225,1,140,197,212,167,102,60,152,140,46,137,164,35,36,41,99,193,24,105,25,207,2,113,25,166,40,100,214,153,34,33,228,51,104,251,37,168,150,183,234,175,96,48,136,54,76,214,168,5,254,22,19,20,190,23,50,207,40,148,184,179,154,74,164,13,229,154,192,102,163,230,212,2,3,240,116,19,219,193,5,72,106,54,189,85,39,28,123,229,32,115,154,146,3,239,104,152,123,219,191,224,49,53,223,145,13,203,238,14,25,133,146,69,86,83,237,30,145,113,53,114,230,113,36,99,116,127,243,234,253,0,27,33,190,126,136,9,0,0 };
			return method;
		}

		protected override SchemaMethod CreateFillDataMethod() {
			SchemaMethod method = base.CreateFillDataMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,83,77,79,2,49,16,61,47,9,255,161,114,90,18,178,137,103,62,18,88,16,141,196,16,64,47,198,67,165,3,142,150,22,251,1,110,140,255,221,118,55,236,118,17,247,210,204,188,121,51,175,211,183,115,186,133,100,165,0,166,10,89,146,114,160,42,110,119,155,141,3,85,132,81,67,151,210,170,53,144,62,153,130,25,151,113,94,82,193,201,210,234,61,8,54,124,167,95,147,3,8,163,207,11,22,242,168,131,238,1,114,49,185,0,109,119,112,214,174,16,229,66,52,8,218,73,122,212,160,82,41,4,172,13,74,145,44,65,107,119,122,149,207,173,7,56,206,164,252,176,123,31,182,94,8,213,100,134,218,244,86,118,207,161,55,181,200,58,68,27,133,98,251,255,217,108,68,209,61,100,79,148,91,152,83,84,53,218,160,67,198,152,15,166,42,235,161,48,29,146,74,206,11,45,62,30,184,207,169,198,13,137,75,205,87,125,34,44,231,109,242,237,122,135,72,146,74,43,12,233,145,235,2,139,252,85,41,99,147,221,158,203,12,96,100,132,187,240,220,63,214,48,200,90,99,164,232,158,234,113,43,164,130,11,148,187,58,80,103,185,41,43,89,236,170,62,165,204,214,235,95,81,148,144,95,110,64,26,157,67,21,179,62,37,185,69,198,192,243,46,116,171,192,250,2,170,188,111,24,253,185,109,133,27,101,193,79,253,241,166,137,54,174,140,174,223,72,92,218,39,35,40,74,35,5,11,87,242,232,216,161,57,29,211,128,51,111,110,192,40,186,65,206,39,121,135,81,150,59,169,120,192,172,227,169,69,73,192,118,59,140,79,121,39,37,87,19,192,51,73,153,255,47,226,42,183,128,79,11,218,180,187,191,30,201,123,178,151,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateBaseActiveRowChangedHandlerMethod() {
			SchemaMethod method = base.CreateBaseActiveRowChangedHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,142,193,14,130,48,16,68,239,124,69,189,193,165,63,128,154,0,26,36,225,64,212,120,95,232,6,27,203,174,105,183,24,255,222,94,240,50,153,100,242,38,111,132,128,186,78,81,77,98,87,188,242,167,121,2,205,104,46,64,198,161,207,139,50,203,86,240,202,134,202,152,206,4,117,80,221,86,33,168,222,6,217,183,209,154,99,153,13,48,163,78,211,157,123,230,87,124,215,81,132,73,159,9,70,135,38,129,187,237,68,55,76,2,150,66,222,162,156,64,224,198,209,79,152,23,250,175,49,120,187,128,255,54,236,226,66,15,112,17,147,201,15,237,11,191,202,174,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsContactSelectedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a72dbc7f-2cbc-4720-a959-b02d6b4d094d"),
				Name = "IsContactSelected",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,72,76,79,213,11,41,74,77,117,47,202,76,209,11,78,205,73,77,46,73,77,241,203,79,73,45,214,115,206,47,205,43,81,176,181,85,48,208,84,168,230,229,226,44,74,45,41,45,202,83,72,75,204,41,78,181,230,229,170,229,229,226,229,130,138,225,49,38,218,32,86,47,44,49,167,20,200,82,10,78,206,72,205,77,244,76,81,138,213,11,201,15,46,41,202,204,75,215,208,4,217,224,154,91,144,147,95,153,154,10,83,96,13,0,149,6,22,233,156,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntitySchemaByNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7efb0620-490e-4e82-aae1-228c5e75d0ed"),
				Name = "GetEntitySchemaByName",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "EntitySchema"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5be2c0ad-c2af-46a5-9345-7bddfb775d6d"),
				Name = "entitySchemaName",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,205,10,194,48,16,132,207,45,244,29,214,91,11,210,23,240,7,180,42,136,232,69,60,137,135,165,93,53,208,110,33,137,74,17,223,221,109,5,169,109,192,83,32,153,249,102,54,171,206,16,46,217,42,91,237,211,43,21,152,160,28,48,153,0,223,242,60,130,103,224,123,142,103,96,122,192,66,165,86,149,140,186,26,27,171,21,95,134,208,150,78,195,104,20,248,175,192,15,252,59,106,160,46,165,182,11,169,79,71,243,23,45,96,37,197,7,78,104,156,148,108,81,177,217,80,21,182,21,59,44,40,146,153,60,25,170,91,73,154,28,12,105,177,50,53,217,113,59,112,139,140,23,210,241,74,113,182,102,99,145,83,154,87,53,175,31,32,221,60,119,175,89,150,245,228,195,159,22,141,89,147,189,105,254,185,175,63,18,40,55,212,44,196,33,248,134,28,187,1,167,207,18,222,185,3,41,225,232,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillEntityByTupleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("05e66c91-2b91-489f-b658-03ae2b6db683"),
				Name = "FillEntityByTuple",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("188d1770-8371-4184-810c-0eff9d3dd035"),
				Name = "tuple",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b4a51f39-8086-4fa7-8d6a-d0a220c3aab4"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,81,75,195,48,20,133,159,23,200,127,184,238,169,3,201,80,167,47,178,23,199,38,67,241,101,178,247,216,158,178,96,154,148,53,81,251,239,109,155,193,154,77,58,31,239,229,251,114,238,33,48,78,185,90,108,224,22,86,251,194,108,165,246,72,198,235,108,124,77,206,151,26,98,237,80,220,76,30,57,195,223,232,74,105,188,201,2,145,112,59,32,188,90,251,233,203,51,229,110,64,9,67,132,207,46,38,68,248,253,0,190,73,119,40,228,73,229,7,241,130,186,149,56,251,146,123,10,106,32,105,78,207,112,203,222,230,169,110,235,36,125,187,123,251,226,141,11,89,58,101,219,102,253,0,113,88,31,227,211,78,109,130,99,172,219,86,98,165,76,118,118,194,44,216,211,41,189,239,176,7,169,138,36,101,42,207,155,193,164,160,15,184,111,192,208,242,39,133,38,105,50,178,174,1,43,206,84,78,201,33,240,106,78,198,107,61,225,108,52,248,53,199,30,65,236,55,128,174,240,127,63,42,48,226,236,23,171,243,241,66,161,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResolveConflictsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ebbb1087-3a65-430f-a220-f0d707cf598d"),
				Name = "ResolveConflicts",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,223,79,219,48,16,126,78,164,252,15,134,167,166,66,233,246,178,23,160,18,80,40,17,29,176,182,236,101,218,131,73,174,197,154,107,87,182,3,139,128,255,125,103,39,205,47,10,12,77,171,170,86,185,187,239,187,187,239,206,206,160,79,174,166,241,56,190,60,154,144,175,167,243,243,171,17,9,252,121,182,230,112,48,203,181,129,85,52,206,88,186,71,180,81,76,44,95,255,47,131,79,36,231,144,24,38,133,142,198,32,64,177,36,186,128,252,59,229,25,92,83,166,182,145,14,223,68,143,152,51,80,149,31,48,97,246,8,254,12,135,36,145,98,193,209,19,248,253,65,224,223,83,85,89,52,57,36,55,26,212,137,20,162,224,138,102,160,53,254,143,168,161,63,118,47,225,97,34,229,175,108,109,31,119,127,6,62,213,100,194,180,217,84,246,241,222,3,223,243,188,127,234,255,61,134,174,6,117,204,129,147,99,56,220,15,124,182,32,189,94,67,133,67,34,50,206,67,242,244,68,106,51,210,103,194,88,231,167,48,36,143,152,88,129,201,148,32,11,202,53,32,203,115,224,23,122,42,88,201,123,136,177,36,171,168,128,135,66,165,66,158,191,219,9,215,22,126,90,2,116,38,255,126,107,189,16,203,26,12,200,215,11,116,22,109,144,7,102,238,136,201,215,160,209,213,15,252,133,84,64,147,59,210,107,110,2,174,74,189,21,69,179,248,157,131,82,84,203,133,137,102,185,72,162,98,23,42,98,222,122,220,183,0,171,235,78,172,109,116,59,184,228,244,218,152,82,172,111,199,177,48,176,84,212,182,114,99,24,103,134,129,238,181,55,51,196,113,136,123,80,198,169,58,151,109,254,51,169,78,127,39,192,121,53,62,171,132,135,19,242,0,135,245,127,147,191,204,185,145,162,157,177,20,112,10,137,84,105,156,70,177,62,93,173,77,222,11,67,91,93,99,137,162,163,52,109,147,110,157,196,20,180,228,88,85,52,163,247,176,73,226,140,153,45,186,211,195,94,103,96,150,247,185,63,32,131,129,91,24,188,201,222,204,113,180,94,243,188,221,247,171,169,44,117,113,50,82,188,56,102,50,83,9,160,220,99,48,163,234,25,87,213,171,150,241,197,46,54,196,64,113,30,75,61,235,163,57,161,218,92,169,17,44,104,198,77,47,180,135,180,210,11,131,221,184,45,231,130,41,109,39,93,35,207,172,165,1,181,234,58,242,34,116,167,188,10,172,213,177,56,26,154,166,56,42,46,115,128,99,35,144,239,154,46,193,78,169,178,102,198,72,177,95,1,216,82,96,103,91,48,113,219,209,129,97,158,205,114,181,243,84,214,14,224,150,137,202,103,181,109,160,142,187,174,6,180,194,167,122,150,220,193,138,198,41,194,156,2,145,21,253,139,189,136,163,185,156,185,171,167,20,201,187,149,146,19,166,55,197,35,162,9,63,36,27,199,198,86,160,218,61,69,231,44,77,193,22,185,165,244,218,89,103,169,72,26,98,54,226,186,58,215,174,157,6,135,107,248,185,62,156,245,58,76,221,162,181,15,91,189,180,93,183,19,231,179,11,42,175,255,192,255,192,11,180,185,136,200,81,190,78,140,202,192,29,152,63,80,36,7,63,96,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRefreshButtonsStatesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7e6535f6-b498-4b2d-8197-a8476f8e80df"),
				Name = "RefreshButtonsStates",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("19cdde19-d090-4a01-8970-0c77b435aa6a"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,63,79,195,48,16,197,231,68,202,119,48,157,146,197,237,94,130,68,11,42,149,24,16,137,88,16,131,91,31,193,194,241,69,254,83,84,161,126,119,108,65,26,167,116,234,122,239,253,238,222,187,29,211,132,113,126,223,118,18,247,0,11,171,72,73,158,88,3,244,54,154,58,107,81,205,179,116,231,221,162,81,168,225,12,176,30,11,49,227,47,212,248,136,248,233,186,241,133,227,52,118,111,132,58,10,119,204,178,8,89,156,74,61,247,75,114,227,141,43,176,65,170,208,233,45,228,133,23,197,59,201,185,161,207,248,101,232,18,157,178,164,44,201,172,200,210,239,44,77,166,211,113,58,250,32,56,135,112,241,76,142,65,180,218,129,95,157,140,159,55,232,255,222,116,130,38,158,213,96,157,14,233,15,4,164,1,18,226,108,16,37,17,166,7,189,253,47,249,235,236,141,250,106,245,190,3,190,68,233,90,245,194,164,131,235,149,19,252,38,159,84,219,15,104,217,154,79,10,90,99,101,181,80,77,94,132,158,253,166,222,48,191,188,243,16,235,194,230,87,209,134,196,127,224,240,3,14,64,46,99,127,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ff708115-2b52-40f2-92af-ff44d95d820c"),
				Name = "LogInfo",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CreatedInPackageId = new Guid("ff6db8c2-aaeb-43c3-ad7c-1d48a4333145"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4a01897a-4c5f-4d5f-be20-df05a7418626"),
				Name = "message",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("ff6db8c2-aaeb-43c3-ad7c-1d48a4333145")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,112,173,72,78,205,9,45,201,204,201,44,201,76,45,214,243,201,79,87,80,180,85,200,43,205,201,209,84,168,230,229,226,196,148,215,243,204,75,203,215,200,77,45,46,78,76,79,213,180,230,229,170,5,0,224,225,217,64,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogExcelImportLogMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("95034924-bec7-47d1-b7a0-3f9b59212b7e"),
				Name = "LogExcelImportLog",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("95db59de-5495-40db-86b9-555ed93b1c70"),
				Name = "message",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,209,74,195,48,20,134,175,45,244,29,66,174,82,40,121,1,241,198,58,164,160,83,113,62,64,72,142,37,176,156,72,122,178,118,111,111,178,217,181,195,49,241,42,36,231,255,191,115,206,159,157,10,12,253,240,170,130,114,64,16,216,29,67,24,216,91,132,176,63,61,10,158,36,188,102,15,138,96,99,29,200,181,31,106,198,167,43,175,110,203,98,151,64,58,134,0,72,31,61,132,198,35,41,77,173,249,139,188,240,180,134,215,101,113,243,99,71,208,100,61,202,102,22,200,19,117,234,216,69,107,18,248,49,29,114,13,67,62,69,174,149,69,238,213,98,50,145,56,7,86,169,133,108,145,188,224,171,81,195,182,117,95,62,208,147,239,248,161,242,14,36,120,158,132,53,126,27,29,202,121,214,220,172,154,69,77,128,20,128,121,193,164,93,70,248,75,113,191,63,240,174,166,51,155,158,189,177,159,246,42,119,146,252,19,12,125,175,58,216,192,72,151,182,115,199,242,98,193,69,60,151,3,57,19,28,141,171,17,116,36,72,159,240,13,43,118,169,41,90,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateExecuteImportExcelLookupMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b708b1a8-25eb-4db4-8821-bba1b901d9cd"),
				Name = "ExecuteImportExcelLookup",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3ed248b9-3028-4447-89a5-7e1fc736f6c5"),
				Name = "entities",
				CreatedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				ModifiedInSchemaUId = new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>",
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,203,106,195,48,16,60,215,224,127,16,62,37,32,252,3,73,11,37,41,193,161,148,64,40,61,203,242,182,85,98,107,197,74,206,131,224,127,175,108,41,33,109,125,147,118,30,59,59,214,145,210,95,108,135,229,155,104,128,61,178,172,104,12,146,123,57,73,168,151,194,137,108,150,38,246,70,90,17,182,102,132,53,204,239,168,134,80,130,181,35,158,175,136,251,214,108,2,222,43,210,228,32,232,42,216,8,242,18,7,100,189,76,195,145,45,149,116,10,181,160,243,60,88,115,134,229,14,164,123,154,76,217,37,77,30,46,217,96,27,54,20,85,198,217,175,127,199,3,71,59,229,20,88,15,67,124,70,164,176,219,179,150,33,213,2,245,103,237,23,246,180,209,121,151,38,157,143,252,108,204,86,126,67,213,214,64,249,245,85,52,13,84,74,56,136,183,173,177,156,196,90,249,173,58,126,223,76,31,224,221,2,121,123,13,195,153,249,7,210,222,26,33,33,15,186,63,240,162,37,242,249,251,105,36,252,235,109,58,251,1,85,214,221,137,211,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new NewLookupDataGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6d6d768-1dd0-40ba-9f4f-d1752caad640"));
		}

		#endregion

	}

	#endregion

}

