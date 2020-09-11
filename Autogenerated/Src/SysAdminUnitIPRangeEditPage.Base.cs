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
	using System.Net;
	using System.Text.RegularExpressions;
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

	#region Class: SysAdminUnitIPRangeEditPageSchema

	/// <exclude/>
	public class SysAdminUnitIPRangeEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _beginIPTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit BeginIPTextEdit {
			get {
				return _beginIPTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _endIPTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit EndIPTextEdit {
			get {
				return _endIPTextEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SysAdminUnitIPRangeEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysAdminUnitIPRangeEditPageSchema(SysAdminUnitIPRangeEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
			RealUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
			Name = "SysAdminUnitIPRangeEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			Width = 350;
			Height = 180;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnitIPRangeEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateApplyChangesButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDesignerModeButton();
			UpdateContextHelpButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateBeginIPTextEdit());
			MainControlLayout.InsertItem(1, CreateEndIPTextEdit());
			MainControlLayout.MoveItem(2, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysAdminUnitIPRangeEditPageEventsProcessSchema() {
			var schema = new SysAdminUnitIPRangeEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateBeginIPTextEdit() {
			_beginIPTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_beginIPTextEdit.UId = new Guid("cb2d53db-d6fb-4165-9714-eeca5135f47d");
			_beginIPTextEdit.Name = "BeginIPTextEdit";
			_beginIPTextEdit.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
			_beginIPTextEdit.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
			_beginIPTextEdit.CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			_beginIPTextEdit.Tag = "";
			_beginIPTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_beginIPTextEdit.Image = new ControlImage {};
			_beginIPTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_beginIPTextEdit.DataSource = "DataSource";
			_beginIPTextEdit.ColumnUId = new Guid("bdd2f185-aee7-45f0-b894-98360d373b54");
			_beginIPTextEdit.Required = true;
			return _beginIPTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateEndIPTextEdit() {
			_endIPTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_endIPTextEdit.UId = new Guid("4ff6d382-4bfc-4440-b84c-68dfc02b7adf");
			_endIPTextEdit.Name = "EndIPTextEdit";
			_endIPTextEdit.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
			_endIPTextEdit.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
			_endIPTextEdit.CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			_endIPTextEdit.Tag = "";
			_endIPTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_endIPTextEdit.Image = new ControlImage {};
			_endIPTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_endIPTextEdit.DataSource = "DataSource";
			_endIPTextEdit.ColumnUId = new Guid("f7f6fc8b-df3c-423d-8d43-9a2799d0754c");
			_endIPTextEdit.Required = true;
			return _endIPTextEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			DataSource.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ed3b8c54-449c-40d9-9c03-45accdda2a3c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("52d2175e-db06-4c5a-892b-9be74e866b1f");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("489ea4c5-0d45-49f4-8f5b-6f4bda61577b");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("43959cf5-6227-41fc-b98f-c6a8cdeb1475");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("c779b53d-d683-4496-95a1-0e65826eb850");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("65a4741a-eadc-485b-a6e7-2662f0729cc9");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("80562de5-dd61-480f-af1f-84ceefea423f");
			if (column != null) {
				column.UId = new Guid("bdd2f185-aee7-45f0-b894-98360d373b54");
				column.Name = @"BeginIP";
				column.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3df16c98-3a83-4b7b-94b0-c138ba6ded0d");
			if (column != null) {
				column.UId = new Guid("f7f6fc8b-df3c-423d-8d43-9a2799d0754c");
				column.Name = @"EndIP";
				column.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1e3c68d3-97a9-45a6-ae30-951580afc7c5");
			if (column != null) {
				column.UId = new Guid("51e98b6c-6066-44c2-a3cd-8778b641eb9e");
				column.Name = @"SysAdminUnit";
				column.CreatedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.ModifiedInSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysAdminUnitIPRangeEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysAdminUnitIPRangeEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysAdminUnitIPRangeEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitIPRangeEditPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitIPRangeEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysAdminUnitIPRangeEditPageSchemaUserControl
	{

		public SysAdminUnitIPRangeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnitIPRangeEditPageEventsProcess";
			SchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf");
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

		public virtual bool NoErrorsFound {
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
					SchemaElementUId = new Guid("aeaa8fb7-b0e2-41b2-8bb0-a5558309a85e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage;
		public ProcessFlowElement OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage {
			get {
				return _oKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage ?? (_oKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage",
					SchemaElementUId = new Guid("a26fb0b1-ec8a-4c52-8454-bea3eff40b0e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask;
		public ProcessScriptTask ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask {
			get {
				return _processOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask ?? (_processOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask",
					SchemaElementUId = new Guid("10481f4a-ba25-42e4-ae18-27f1b2e8dabe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _oKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent {
			get {
				return _oKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent ?? (_oKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("653c60d7-54af-4fcb-bb0f-ef73dcdb4c55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("a162b3dc-e061-4755-b970-fb5b74a4069e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage;
		public ProcessFlowElement PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage {
			get {
				return _pageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage ?? (_pageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage",
					SchemaElementUId = new Guid("22b98fc8-d45b-48c3-abdf-6b65f788c6a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processPageLoadCompleteScriptTask;
		public ProcessScriptTask ProcessPageLoadCompleteScriptTask {
			get {
				return _processPageLoadCompleteScriptTask ?? (_processPageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessPageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("03982a65-b2ba-4142-aa92-7d6281ecde1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessPageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _sysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent {
			get {
				return _sysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent ?? (_sysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("18cf8a30-6975-4e07-9fc0-b9f9cec2205d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
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
					SchemaElementUId = new Guid("8f117a38-5719-4bf0-b73c-f387b01445e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _iPRangeErrorMessage;
		public LocalizableString IPRangeErrorMessage {
			get {
				return _iPRangeErrorMessage ?? (_iPRangeErrorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IPRangeErrorMessage.Value"));
			}
		}

		private LocalizableString _iPFormatErrorMessage;
		public LocalizableString IPFormatErrorMessage {
			get {
				return _iPFormatErrorMessage ?? (_iPFormatErrorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IPFormatErrorMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage };
			FlowElements[ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask };
			FlowElements[OKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage };
			FlowElements[ProcessPageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessPageLoadCompleteScriptTask };
			FlowElements[SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask");
						break;
					case "ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask":
						if (ConditionalFlow1ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("OKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent");
							break;
						}
						break;
					case "OKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent":
						break;
					case "EventSubProcess2":
						break;
					case "PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessPageLoadCompleteScriptTask");
						break;
					case "ProcessPageLoadCompleteScriptTask":
						e.Context.QueueTasks.Enqueue("SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent");
						break;
					case "SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(NoErrorsFound);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage");
			ActivatedEventElements.Add("PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage");
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
				case "OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage";
					result = OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage.Execute(context);
					break;
				case "ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask";
					result = ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask.Execute(context, ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTaskExecute);
					break;
				case "OKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = OKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage";
					result = PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage.Execute(context);
					break;
				case "ProcessPageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessPageLoadCompleteScriptTask";
					result = ProcessPageLoadCompleteScriptTask.Execute(context, ProcessPageLoadCompleteScriptTaskExecute);
					break;
				case "SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent.Execute(context);
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
				case "NoErrorsFound":
					NoErrorsFound = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTaskExecute(ProcessExecutingContext context) {
			NoErrorsFound = true;	
			Page.BaseMessagePanel.Clear();
			if (!CheckIPData(Page.BeginIPTextEdit.Text) || !CheckIPData(Page.EndIPTextEdit.Text)) {
				Page.BaseMessagePanel.AddMessage("IPFormatError", Warning, 
					IPFormatErrorMessage,
					MessageType.Warning);
				NoErrorsFound = false;		
				return false;
			}
			IPAddress beginIPAdress = null;
			IPAddress endIPAdress = null;
			if (!IPAddress.TryParse(Page.BeginIPTextEdit.Text, out beginIPAdress)) {
				NoErrorsFound = false;
			}
			if (!IPAddress.TryParse(Page.EndIPTextEdit.Text, out endIPAdress)) {
				NoErrorsFound = false;
			}
			if (!NoErrorsFound) {
				Page.BaseMessagePanel.AddMessage("IPFormatError", Warning, 
					IPFormatErrorMessage,
					MessageType.Warning);
				NoErrorsFound = false;	
			}
			if (!NoErrorsFound) {
				return false;
			}
			
			var beginIPAdressBytes = beginIPAdress.GetAddressBytes();
			var endIPAdressBytes = endIPAdress.GetAddressBytes();
			for (int i = 0; i < endIPAdressBytes.Length; i++) {
				if (beginIPAdressBytes[i] > endIPAdressBytes[i]) {
					Page.BaseMessagePanel.AddMessage("IPRangeError", Warning, 
						IPRangeErrorMessage,
						MessageType.Warning);
					NoErrorsFound = false;	
				}
			}
			
			return true;
		}

		public virtual bool ProcessPageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			SynchronizeDataSourceStructure = true;
			return true;
		}

		public virtual bool CheckIPData(string text) {
			string pattern = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
			Match isMatch = Regex.Match(text, pattern, RegexOptions.IgnoreCase);
			return isMatch.Success;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage")) {
							context.QueueTasks.Enqueue("OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage")) {
							context.QueueTasks.Enqueue("PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage");
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
			if (!HasMapping("NoErrorsFound") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NoErrorsFound", NoErrorsFound, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitIPRangeEditPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitIPRangeEditPageEventsProcess : SysAdminUnitIPRangeEditPageEventsProcess<Terrasoft.WebApp.SysAdminUnitIPRangeEditPageSchemaUserControl>
	{

		public SysAdminUnitIPRangeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnitIPRangeEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysAdminUnitIPRangeEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit BeginIPTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("BeginIPTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit EndIPTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("EndIPTextEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysAdminUnitIPRangeEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysAdminUnitIPRangeEditPageEventsProcess(UserConnection);
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
			SchemaName = "SysAdminUnitIPRangeEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitIPRangeEditPageEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnitIPRangeEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnitIPRangeEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnitIPRangeEditPageEventsProcessSchema(SysAdminUnitIPRangeEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnitIPRangeEditPageEventsProcess";
			UId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a");
			CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateNoErrorsFoundParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5094abce-fa96-4349-bde5-2ecb20300e8c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"NoErrorsFound",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNoErrorsFoundParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent okbuttonclick_sysadminunitiprangeeditpage_startmessage = CreateOKButtonClick_SysAdminUnitIPRangeEditPage_StartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(okbuttonclick_sysadminunitiprangeeditpage_startmessage);
			ProcessSchemaScriptTask processokbuttonclick_sysadminunitiprangeeditpage_scripttask = CreateProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(processokbuttonclick_sysadminunitiprangeeditpage_scripttask);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclick_sysadminunitiprangeeditpage_intermediatethrowmessageevent = CreateOKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(okbuttonclick_sysadminunitiprangeeditpage_intermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent pageloadcomplete_sysadminunitiprangeeditpage_startmessage = CreatePageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcomplete_sysadminunitiprangeeditpage_startmessage);
			ProcessSchemaScriptTask processpageloadcompletescripttask = CreateProcessPageLoadCompleteScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(processpageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent sysadminunitiprangeeditpage_intermediatethrowmessageevent = CreateSysAdminUnitIPRangeEditPage_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(sysadminunitiprangeeditpage_intermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateIPRangeErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateIPFormatErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateIPRangeErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2bb2615c-3f60-49ae-8389-958a32d26456"),
				Name = "IPRangeErrorMessage",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIPFormatErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7a0f1c6b-b058-4780-ab37-b78e5aa34ce5"),
				Name = "IPFormatErrorMessage",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("32d1dd10-33b7-471a-8d0b-08a15c6b7e0a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				CurveCenterPosition = new Point(218, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a26fb0b1-ec8a-4c52-8454-bea3eff40b0e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("10481f4a-ba25-42e4-ae18-27f1b2e8dabe"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a5f5311c-595a-4a8a-ad72-187e59bd5801"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				CurveCenterPosition = new Point(216, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("22b98fc8-d45b-48c3-abdf-6b65f788c6a2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03982a65-b2ba-4142-aa92-7d6281ecde1e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("0afbe2ec-c5a5-4a99-a300-69e076852d0a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				CurveCenterPosition = new Point(386, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03982a65-b2ba-4142-aa92-7d6281ecde1e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18cf8a30-6975-4e07-9fc0-b9f9cec2205d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("8f117a38-5719-4bf0-b73c-f387b01445e9"),
				ConditionExpression = @"NoErrorsFound",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				CurveCenterPosition = new Point(383, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("10481f4a-ba25-42e4-ae18-27f1b2e8dabe"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("653c60d7-54af-4fcb-bb0f-ef73dcdb4c55"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("fddb0754-adcf-4bda-95f4-6302e998bef7"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(569, 352),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("3dd7e53b-fdd7-4409-b8fb-144891a46c2f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("fddb0754-adcf-4bda-95f4-6302e998bef7"),
				CreatedInOwnerSchemaUId = new Guid("a626e5c1-4b99-4232-a29f-d505a21c69cf"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(540, 352),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("aeaa8fb7-b0e2-41b2-8bb0-a5558309a85e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3dd7e53b-fdd7-4409-b8fb-144891a46c2f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(406, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClick_SysAdminUnitIPRangeEditPage_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a26fb0b1-ec8a-4c52-8454-bea3eff40b0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aeaa8fb7-b0e2-41b2-8bb0-a5558309a85e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"OKButtonClick_SysAdminUnitIPRangeEditPage_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("10481f4a-ba25-42e4-ae18-27f1b2e8dabe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aeaa8fb7-b0e2-41b2-8bb0-a5558309a85e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"ProcessOKButtonClick_SysAdminUnitIPRangeEditPage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,193,74,195,64,16,61,111,32,255,48,246,148,210,176,120,143,21,218,218,74,64,203,34,5,15,226,97,53,211,116,49,110,100,179,17,139,237,191,187,155,172,146,52,105,233,209,83,54,243,230,237,188,121,143,100,153,207,149,202,85,177,200,75,153,192,24,180,42,49,34,190,199,120,138,116,202,11,188,199,162,48,103,198,37,102,116,150,33,87,193,48,242,61,177,134,224,98,182,193,215,183,152,221,112,205,131,154,128,169,144,49,91,225,151,158,39,66,83,123,24,194,110,7,221,214,185,76,14,27,135,240,237,123,164,127,242,36,73,220,123,48,136,217,34,87,239,92,87,202,7,33,60,114,37,133,76,67,48,108,210,2,29,37,180,128,59,175,182,31,72,29,195,46,66,150,7,14,172,121,86,24,11,140,7,68,161,46,149,116,21,223,219,251,94,204,140,16,101,110,130,151,122,213,73,253,54,6,89,102,89,212,108,64,187,224,33,92,217,246,215,67,87,106,203,184,42,240,184,123,33,228,165,110,15,115,62,245,235,174,84,158,156,210,53,190,158,209,208,123,230,132,22,254,175,194,59,169,177,155,170,239,125,114,213,54,121,186,213,104,115,107,21,233,45,106,103,106,133,87,95,130,165,54,188,251,37,54,74,189,180,117,174,32,16,82,131,48,205,151,145,121,92,117,174,161,119,40,83,189,49,224,104,84,107,183,59,117,117,62,137,103,184,238,176,77,181,38,157,149,202,3,151,41,246,134,66,154,96,51,148,163,169,28,143,133,236,157,225,46,132,234,119,243,3,205,232,203,34,132,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("653c60d7-54af-4fcb-bb0f-ef73dcdb4c55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aeaa8fb7-b0e2-41b2-8bb0-a5558309a85e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"OKButtonClick_SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a162b3dc-e061-4755-b970-fb5b74a4069e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3dd7e53b-fdd7-4409-b8fb-144891a46c2f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 182),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(414, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("22b98fc8-d45b-48c3-abdf-6b65f788c6a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a162b3dc-e061-4755-b970-fb5b74a4069e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"PageLoadComplete_SysAdminUnitIPRangeEditPage_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessPageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("03982a65-b2ba-4142-aa92-7d6281ecde1e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a162b3dc-e061-4755-b970-fb5b74a4069e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"ProcessPageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,117,73,44,73,12,206,47,45,74,78,13,46,41,42,77,46,41,45,74,85,176,85,0,50,83,173,121,185,138,82,129,252,60,8,15,0,151,164,164,124,52,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSysAdminUnitIPRangeEditPage_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("18cf8a30-6975-4e07-9fc0-b9f9cec2205d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a162b3dc-e061-4755-b970-fb5b74a4069e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Name = @"SysAdminUnitIPRangeEditPage_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 65),
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
			Methods.Add(CreateCheckIPDataMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a177f32a-d124-41d6-87e8-098ce1747f6b"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f0ba3eaf-09b1-42cc-b46f-6d524657cc27"),
				Name = "System.Net",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
		}

		protected virtual SchemaMethod CreateCheckIPDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2d9656d0-1d81-4a8e-a0e4-d549be2e1639"),
				Name = "CheckIPData",
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7fbf7d8c-ec4f-4d89-aa43-437a68d18734"),
				Name = "text",
				CreatedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				ModifiedInSchemaUId = new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,46,41,202,204,75,87,40,72,44,41,73,45,202,83,176,85,112,80,138,211,208,136,54,208,181,140,173,137,54,4,146,16,166,33,152,170,54,170,173,49,2,178,76,160,162,70,166,64,218,52,86,51,70,79,179,218,184,150,84,93,42,74,214,92,190,137,37,201,25,10,153,197,16,218,86,33,40,53,61,181,66,15,204,211,40,73,173,40,209,129,185,76,7,34,229,95,80,146,153,159,87,172,231,153,158,151,95,148,234,156,88,156,170,105,205,85,148,90,82,10,116,59,212,20,189,224,210,228,228,212,226,98,107,0,35,212,161,190,219,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnitIPRangeEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("647951cf-bb59-4955-a1ec-3924c2e1602a"));
		}

		#endregion

	}

	#endregion

}

