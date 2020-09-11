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

	#region Class: BaseObjectRecordRightsGridPageSchema

	/// <exclude/>
	public class BaseObjectRecordRightsGridPageSchema : Terrasoft.WebApp.BaseVirtualGridPageSchema
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

		#endregion

		#region Constructors: Public

		public BaseObjectRecordRightsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseObjectRecordRightsGridPageSchema(BaseObjectRecordRightsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {};
			PrintButton.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6"),
				ImageHash = @"ff715ca6b6405b87c35185fbd4b2847b"
			};
			ContextHelpButton.Hidden = false;
			ContextHelpButton.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
		}

		private void UpdateTreeGrid() {
			TreeGrid.EnableInnerDragDrop = true;
			TreeGrid.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
			RealUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
			Name = "BaseObjectRecordRightsGridPage";
			ParentSchemaUId = new Guid("dbe94191-fb4c-4c41-b1eb-37ac77da867d");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "210";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseObjectRecordRightsGridPageEventsProcessSchema();
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
			ButtonsControlLayout.InsertItem(4, CreateUpButton());
			ButtonsControlLayout.InsertItem(5, CreateDownButton());
			ButtonsControlLayout.MoveItem(6, Spacer);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseObjectRecordRightsGridPageEventsProcessSchema() {
			var schema = new BaseObjectRecordRightsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpButton() {
			_upButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upButton.UId = new Guid("44b05923-57f8-4104-aa72-c97833cf12da");
			_upButton.Name = "UpButton";
			_upButton.CreatedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
			_upButton.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
			_upButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_upButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upButton.AjaxEvents.Click.ShowLoadMask = true;
			_upButton.Tag = "";
			_upButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			_upButton.Enabled = false;
			return _upButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownButton() {
			_downButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downButton.UId = new Guid("d83bd64d-3648-4cb9-8411-da321023bf7f");
			_downButton.Name = "DownButton";
			_downButton.CreatedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
			_downButton.ModifiedInSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
			_downButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_downButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downButton.AjaxEvents.Click.ShowLoadMask = true;
			_downButton.Tag = "";
			_downButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6"),
				ImageHash = @"237f430c77240f66f9368acf2476bfc0"
			};
			_downButton.Enabled = false;
			return _downButton;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseObjectRecordRightsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseObjectRecordRightsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseObjectRecordRightsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseObjectRecordRightsGridPageEventsProcess

	/// <exclude/>
	public class BaseObjectRecordRightsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseVirtualGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseObjectRecordRightsGridPageSchemaUserControl
	{

		#region Class: UserTaskChildOpenLookupGridPageFlowElement

		/// <exclude/>
		public class UserTaskChildOpenLookupGridPageFlowElement : OpenLookupUserTask
		{

			public UserTaskChildOpenLookupGridPageFlowElement(UserConnection userConnection, BaseObjectRecordRightsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskChildOpenLookupGridPage";
				IsLogging = false;
				SchemaElementUId = new Guid("3fe09f9a-0ec9-460a-adf3-e93a96931236");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public BaseObjectRecordRightsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseObjectRecordRightsGridPageEventsProcess";
			SchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
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

		public virtual Guid ModuleEntitySchemaUId {
			get;
			set;
		}

		public virtual string RightsSchemaName {
			get;
			set;
		}

		public virtual bool NeedAddDetailRequest {
			get;
			set;
		}

		public virtual bool UseDenyRecordRightsEnabled {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("59643b6b-89e5-46f5-a0d0-8fb22f481e20"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _downButtonClickStartMessage;
		public ProcessFlowElement DownButtonClickStartMessage {
			get {
				return _downButtonClickStartMessage ?? (_downButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DownButtonClickStartMessage",
					SchemaElementUId = new Guid("7cf11a73-ac30-40f3-93ac-e3678e07ffeb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _downButtonClickScriptTask;
		public ProcessScriptTask DownButtonClickScriptTask {
			get {
				return _downButtonClickScriptTask ?? (_downButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DownButtonClickScriptTask",
					SchemaElementUId = new Guid("8b1b8449-d998-498a-b89c-5de22bf19ef5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DownButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _gridPageRefreshRowIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent GridPageRefreshRowIntermediateThrowMessageEvent1 {
			get {
				return _gridPageRefreshRowIntermediateThrowMessageEvent1 ?? (_gridPageRefreshRowIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "GridPageRefreshRowIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("38386ca8-65d8-4f6d-bf71-050cbf700e99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "GridPageRefreshRow",
				});
			}
		}

		private ProcessScriptTask _upButtonClickScriptTask;
		public ProcessScriptTask UpButtonClickScriptTask {
			get {
				return _upButtonClickScriptTask ?? (_upButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpButtonClickScriptTask",
					SchemaElementUId = new Guid("18859623-4c5c-4689-838e-328185844a02"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _upButtonClickStartMessage;
		public ProcessFlowElement UpButtonClickStartMessage {
			get {
				return _upButtonClickStartMessage ?? (_upButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UpButtonClickStartMessage",
					SchemaElementUId = new Guid("f3799984-fc21-48c4-8b27-54953cd813ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("7605b66a-8d3a-4dfa-a0e9-ccb08000265d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage;
		public ProcessFlowElement PageLoadCompleteStartMessage {
			get {
				return _pageLoadCompleteStartMessage ?? (_pageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("1097ba68-6eae-4308-b4c8-cf276837c4db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _pageLoadCompleteIntermediateThrowMessageEvent ?? (_pageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("016066c9-e1d4-4f82-8b4b-a106dab98d8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("e0aab5c2-4b07-4492-a7db-abade07ce2a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildAddButtonClick;
		public ProcessFlowElement EventSubProcessChildAddButtonClick {
			get {
				return _eventSubProcessChildAddButtonClick ?? (_eventSubProcessChildAddButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildAddButtonClick",
					SchemaElementUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startChildAddButtonClick;
		public ProcessFlowElement StartChildAddButtonClick {
			get {
				return _startChildAddButtonClick ?? (_startChildAddButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartChildAddButtonClick",
					SchemaElementUId = new Guid("5cccd080-2925-438c-a32b-21b4d7f536a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildOpenLookupGridPage;
		public ProcessScriptTask ScriptChildOpenLookupGridPage {
			get {
				return _scriptChildOpenLookupGridPage ?? (_scriptChildOpenLookupGridPage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildOpenLookupGridPage",
					SchemaElementUId = new Guid("ed5d45ec-c369-4fbe-bc6c-b2f0a70693de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildOpenLookupGridPageExecute,
				});
			}
		}

		private UserTaskChildOpenLookupGridPageFlowElement _userTaskChildOpenLookupGridPage;
		public UserTaskChildOpenLookupGridPageFlowElement UserTaskChildOpenLookupGridPage {
			get {
				return _userTaskChildOpenLookupGridPage ?? (_userTaskChildOpenLookupGridPage = new UserTaskChildOpenLookupGridPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchChildLookupGridPageClosed;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchChildLookupGridPageClosed {
			get {
				return _intermediateCatchChildLookupGridPageClosed ?? (_intermediateCatchChildLookupGridPageClosed = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchChildLookupGridPageClosed",
					SchemaElementUId = new Guid("354767c0-f38b-4550-b411-4263485be01c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _scriptChildLookupGridPageClosed;
		public ProcessScriptTask ScriptChildLookupGridPageClosed {
			get {
				return _scriptChildLookupGridPageClosed ?? (_scriptChildLookupGridPageClosed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildLookupGridPageClosed",
					SchemaElementUId = new Guid("ba2817ab-5fc3-4241-a5d3-5a7c0a98efdc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildLookupGridPageClosedExecute,
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
					SchemaElementUId = new Guid("2f8deefb-652a-4eb9-a613-17854338dbd8"),
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

		private ProcessFlowElement _startMessageChild;
		public ProcessFlowElement StartMessageChild {
			get {
				return _startMessageChild ?? (_startMessageChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChild",
					SchemaElementUId = new Guid("da596df1-08de-4b12-86f7-3e3eb3eb3428"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildRequestAddDetailMessage;
		public ProcessScriptTask ScriptChildRequestAddDetailMessage {
			get {
				return _scriptChildRequestAddDetailMessage ?? (_scriptChildRequestAddDetailMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildRequestAddDetailMessage",
					SchemaElementUId = new Guid("56dba2a9-f18d-433f-bdd9-40ad15132c05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildRequestAddDetailMessageExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBaseGridPageRefreshRow;
		public ProcessThrowMessageEvent IntermediateThrowBaseGridPageRefreshRow {
			get {
				return _intermediateThrowBaseGridPageRefreshRow ?? (_intermediateThrowBaseGridPageRefreshRow = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBaseGridPageRefreshRow",
					SchemaElementUId = new Guid("a4ae7449-0024-49b0-9e34-c3630f2c50b1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "GridPageRefreshRow",
						ThrowToBase = true,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowChildNeedDetailRequest;
		public ProcessConditionalFlow ConditionalFlowChildNeedDetailRequest {
			get {
				return _conditionalFlowChildNeedDetailRequest ?? (_conditionalFlowChildNeedDetailRequest = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowChildNeedDetailRequest",
					SchemaElementUId = new Guid("5a751754-5000-420a-8f64-5be6809954c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _rightCaption;
		public LocalizableString RightCaption {
			get {
				return _rightCaption ?? (_rightCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RightCaption.Value"));
			}
		}

		private LocalizableString _rightLevelCaption;
		public LocalizableString RightLevelCaption {
			get {
				return _rightLevelCaption ?? (_rightLevelCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RightLevelCaption.Value"));
			}
		}

		private LocalizableString _positionCaption;
		public LocalizableString PositionCaption {
			get {
				return _positionCaption ?? (_positionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PositionCaption.Value"));
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
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[DownButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DownButtonClickStartMessage };
			FlowElements[DownButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DownButtonClickScriptTask };
			FlowElements[GridPageRefreshRowIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { GridPageRefreshRowIntermediateThrowMessageEvent1 };
			FlowElements[UpButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpButtonClickScriptTask };
			FlowElements[UpButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UpButtonClickStartMessage };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcessChildAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildAddButtonClick };
			FlowElements[StartChildAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartChildAddButtonClick };
			FlowElements[ScriptChildOpenLookupGridPage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildOpenLookupGridPage };
			FlowElements[UserTaskChildOpenLookupGridPage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskChildOpenLookupGridPage };
			FlowElements[IntermediateCatchChildLookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchChildLookupGridPageClosed };
			FlowElements[ScriptChildLookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildLookupGridPageClosed };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[StartMessageChild.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChild };
			FlowElements[ScriptChildRequestAddDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildRequestAddDetailMessage };
			FlowElements[IntermediateThrowBaseGridPageRefreshRow.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBaseGridPageRefreshRow };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "DownButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("DownButtonClickScriptTask");
						break;
					case "DownButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("GridPageRefreshRowIntermediateThrowMessageEvent1");
						break;
					case "GridPageRefreshRowIntermediateThrowMessageEvent1":
						break;
					case "UpButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("GridPageRefreshRowIntermediateThrowMessageEvent1");
						break;
					case "UpButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("UpButtonClickScriptTask");
						break;
					case "EventSubProcess3":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcessChildAddButtonClick":
						break;
					case "StartChildAddButtonClick":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ScriptChildOpenLookupGridPage":
						e.Context.QueueTasks.Enqueue("UserTaskChildOpenLookupGridPage");
						break;
					case "UserTaskChildOpenLookupGridPage":
						ActivatedEventElements.Add("IntermediateCatchChildLookupGridPageClosed");
						break;
					case "IntermediateCatchChildLookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("ScriptChildLookupGridPageClosed");
						break;
					case "ScriptChildLookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBaseGridPageRefreshRow");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlowChildNeedDetailRequestExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptChildRequestAddDetailMessage");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptChildOpenLookupGridPage");
						break;
					case "StartMessageChild":
						e.Context.QueueTasks.Enqueue("ScriptChildOpenLookupGridPage");
						break;
					case "ScriptChildRequestAddDetailMessage":
						break;
					case "IntermediateThrowBaseGridPageRefreshRow":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlowChildNeedDetailRequestExpressionExecute() {
			return Convert.ToBoolean(NeedAddDetailRequest);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DownButtonClickStartMessage");
			ActivatedEventElements.Add("UpButtonClickStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("StartChildAddButtonClick");
			ActivatedEventElements.Add("StartMessageChild");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "DownButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownButtonClickStartMessage";
					result = DownButtonClickStartMessage.Execute(context);
					break;
				case "DownButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownButtonClickScriptTask";
					result = DownButtonClickScriptTask.Execute(context, DownButtonClickScriptTaskExecute);
					break;
				case "GridPageRefreshRowIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = GridPageRefreshRowIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "UpButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpButtonClickScriptTask";
					result = UpButtonClickScriptTask.Execute(context, UpButtonClickScriptTaskExecute);
					break;
				case "UpButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpButtonClickStartMessage";
					result = UpButtonClickStartMessage.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "EventSubProcessChildAddButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartChildAddButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartChildAddButtonClick";
					result = StartChildAddButtonClick.Execute(context);
					break;
				case "ScriptChildOpenLookupGridPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildOpenLookupGridPage";
					result = ScriptChildOpenLookupGridPage.Execute(context, ScriptChildOpenLookupGridPageExecute);
					break;
				case "UserTaskChildOpenLookupGridPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskChildOpenLookupGridPage";
					result = UserTaskChildOpenLookupGridPage.Execute(context);
					break;
				case "IntermediateCatchChildLookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchChildLookupGridPageClosed";
					result = IntermediateCatchChildLookupGridPageClosed.Execute(context);
					break;
				case "ScriptChildLookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildLookupGridPageClosed";
					result = ScriptChildLookupGridPageClosed.Execute(context, ScriptChildLookupGridPageClosedExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "StartMessageChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChild";
					result = StartMessageChild.Execute(context);
					break;
				case "ScriptChildRequestAddDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildRequestAddDetailMessage";
					result = ScriptChildRequestAddDetailMessage.Execute(context, ScriptChildRequestAddDetailMessageExecute);
					break;
				case "IntermediateThrowBaseGridPageRefreshRow":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "GridPageRefreshRow");
					result = IntermediateThrowBaseGridPageRefreshRow.Execute(context);
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
				case "UseDenyRecordRightsEnabled":
					UseDenyRecordRightsEnabled = reader.GetValue<System.Boolean>();
				break;
				case "NeedAddDetailRequest":
					NeedAddDetailRequest = reader.GetValue<System.Boolean>();
				break;
				case "RightsSchemaName":
					RightsSchemaName = reader.GetValue<System.String>();
				break;
				case "ModuleEntitySchemaUId":
					ModuleEntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool DownButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			int currentPosition = GetSelectedRecordPosition();
			SetRecordPosition(currentPosition + 1);
			return true;
		}

		public virtual bool UpButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			int currentPosition = GetSelectedRecordPosition();
			if (currentPosition - 1 < 0) {
				return true;
			}
			SetRecordPosition(currentPosition - 1);
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			var moduleSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ModuleEntitySchemaUId);
			UseDenyRecordRightsEnabled = moduleSchema.UseDenyRecordRights;
			if (!UseDenyRecordRightsEnabled) {
				Page.UpButton.SetVisible(false);
				Page.DownButton.SetVisible(false);
			}
			var schema = UserConnection.DBSecurityEngine.GetRecordRightsSchema(moduleSchema);
			RightsSchemaName = schema.Name;
			return true;
		}

		public virtual bool ScriptChildOpenLookupGridPageExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			UserTaskChildOpenLookupGridPage.ProcessKey = Page.Process.InstanceUId;
			UserTaskChildOpenLookupGridPage.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>)UserTaskChildOpenLookupGridPage.PageParameters;
			string schemaUId = "d5d01fcd-6d8c-4b29-9e58-cca3ffe62364";
			pageParameters.Add("schemaUId", schemaUId);
			pageParameters.Add("hideButtons", true);
			return true;
		}

		public virtual bool ScriptChildLookupGridPageClosedExecute(ProcessExecutingContext context) {
			var values = (Dictionary <string, object>)UserTaskChildOpenLookupGridPage.GetSelectedValues(UserConnection);
			foreach (var valueItem in values) {
				var adminUnitId = new Guid(valueItem.Key);
				if (adminUnitId != Guid.Empty) {
					int operation = Convert.ToInt32(GetViewCode());
					int rightLevel = 1;
					string schemaName = UserConnection.EntitySchemaManager.GetItemByUId(ModuleEntitySchemaUId).Name;
					try {		
						var recordId = SetEntitySchemaRecordRightLevel(adminUnitId, schemaName,
							SelectedNodePrimaryColumnValue,	(Terrasoft.Core.Configuration.EntitySchemaRecordRightOperation) operation, 
							(Terrasoft.Core.Configuration.EntitySchemaRecordRightLevel) rightLevel);
					} catch (System.Security.SecurityException ex) {
						MessagePanel messagePanel = ControlUtilities.FindControl(
							Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
						if (messagePanel != null) {
							messagePanel.Clear();
							messagePanel.AddMessage(Warning, ex.Message, MessageType.Warning);
						}				
					}
				}
			
			}
			return true;
		}

		public virtual bool ScriptChildRequestAddDetailMessageExecute(ProcessExecutingContext context) {
			ListenerThrowEvent(ListenerPageProcessUId, "RequestAddDetailMessage");
			return true;
		}

		public override DataSourceRowConfig TreeGridConfigHandler(Entity row) {
			var config = new DataSourceRowConfig(row.PrimaryColumnValue);
			var icons = new Dictionary<string, ImageConfigValue>();		
			var dataSource = GetDataSource();
			foreach (var column in dataSource.CurrentStructure.Columns) {
				if (column.Name == "RightLevel") {
					var rightId = row.GetTypedColumnValue<Guid>(column.ValueColumnName);
					var columnIconImageName = string.Empty;
					if (rightId == new Guid("{33E0F782-B2E1-DF11-971B-001D60E938C6}")) {
						columnIconImageName = "Allow.png";
					}
					if (rightId == new Guid("{B19D0E8C-B2E1-DF11-971B-001D60E938C6}")) {
						columnIconImageName = "AllowAndGrant.png";
					}
					if (rightId == new Guid("{32E0F782-B2E1-DF11-971B-001D60E938C6}")) {
						columnIconImageName = "Deny.png";
					}
					var imageConfig = new ImageConfigValue(columnIconImageName);
					imageConfig.DisplayImageOnly = true;
					imageConfig.ImagePosition = ImagePosition.Center;
					icons.Add(column.Name, imageConfig);
				}
			}
			var iconConfig = new DataSourceRowColumnIconsConfigValue(icons);		
			config.AddConfig(iconConfig);
			return config;
		}

		public override void CellIconClickHandler(object sender, AjaxEventArgs e) {
			var nodeId = e.ExtraParameters["nodeId"];
			var iconId = e.ExtraParameters["iconId"];
			var denyRightLevel = new Guid("32E0F782-B2E1-DF11-971B-001D60E938C6");
			var allowRightLevel = new Guid("33E0F782-B2E1-DF11-971B-001D60E938C6");
			var allowAndGrantRightLevel = new Guid("B19D0E8C-B2E1-DF11-971B-001D60E938C6");
			var readRightOperation = new Guid("C742B793-4DF3-E011-A271-00155D04C01D");
			var editRightOperation = new Guid("868FC699-4DF3-E011-A271-00155D04C01D");
			var deleteRightOperation = new Guid("878FC699-4DF3-E011-A271-00155D04C01D");
			if ((nodeId != null) && (iconId != null)) {
				Guid recordId = (Guid)Json.Deserialize(nodeId, typeof(Guid));
				var column = (string)Json.Deserialize(iconId, typeof(String));
				if (column == "RightLevel") {
					var entity = GetEntity(recordId);
					var rightLevel = entity.GetTypedColumnValue<Guid>("RightLevelId");
					var rightOperation = entity.GetTypedColumnValue<Guid>("OperationId");
					var adminUnitId = entity.GetTypedColumnValue<Guid>("SysAdminUnitId");
					int rightCode = -1;
					if (rightLevel == denyRightLevel) {
						rightCode = 1;
					}
					if (rightLevel == allowRightLevel) {			
						rightCode = 2;			
					}
					if (rightLevel == allowAndGrantRightLevel) {			
						if (!UseDenyRecordRightsEnabled) {
							rightCode = 1;
						} else {
							rightCode = 0;
						}
					}
					int operationCode = -1;
					if (rightOperation == readRightOperation) {
						operationCode = 0;
					}
					if (rightOperation == editRightOperation) {
						operationCode = 1;
					}
					if (rightOperation == deleteRightOperation) {
						operationCode = 2;
					}
					if ((rightCode != -1) && (operationCode != -1)) {
						string schemaName = UserConnection.EntitySchemaManager.GetItemByUId(ModuleEntitySchemaUId).Name;
						try {
							recordId = SetEntitySchemaRecordRightLevel(adminUnitId, schemaName,
								SelectedNodePrimaryColumnValue,	(Terrasoft.Core.Configuration.EntitySchemaRecordRightOperation) operationCode, 
								(Terrasoft.Core.Configuration.EntitySchemaRecordRightLevel) rightCode);
						} catch (System.Security.SecurityException ex) {
							MessagePanel messagePanel = ControlUtilities.FindControl(
							Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
							if (messagePanel != null) {
								messagePanel.Clear();
								messagePanel.AddMessage(Warning, ex.Message, MessageType.Warning);
							}
						}
						GetDataSource().LoadRow(recordId);
					}
				}
			}
		}

		public override List<string> GetButtons() {
			var result = base.GetButtons();
			result.Add(Page.UpButton.Name);
			result.Add(Page.DownButton.Name);
			return result;
		}

		public override bool RowsDeleteMethod(Guid recordId) {
			var moduleSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ModuleEntitySchemaUId);
			var schema = UserConnection.DBSecurityEngine.GetRecordRightsSchema(moduleSchema);
			int operation = Convert.ToInt32(GetViewCode());
			try {
				UserConnection.DBSecurityEngine.DeleteEntitySchemaRecordRightLevel(
					(Terrasoft.Core.Configuration.EntitySchemaRecordRightOperation)operation, schema.Name, recordId);
			} catch (System.Security.SecurityException ex) {
				MessagePanel messagePanel = ControlUtilities.FindControl(
				Page.AspPage.Controls[0], "BaseMessagePanel", true) as MessagePanel;
				if (messagePanel != null) {
					messagePanel.Clear();
					messagePanel.AddMessage(Warning, ex.Message, MessageType.Warning);
				}				
			}
			var entities = GetEntities(CreateSelect());
			if (entities.Count > 0) {
				var existRecordId = entities[0].GetTypedColumnValue<Guid>("Id");
				var position = entities[0].GetTypedColumnValue<int>("Position");
				var primaryColumnValue = (DataSource as VirtualDataSource).ActiveRowPrimaryColumnValue;
				StoredProcedure setRecordPositionProcedure = new StoredProcedure(Page.UserConnection, "tsp_SetRecordPosition")
					.WithParameter("TableName", RightsSchemaName)
					.WithParameter("PrimaryColumnName", "Id")
					.WithParameter("PrimaryColumnValue", existRecordId)
					.WithParameter("GrouppingColumnNames", "Operation,RecordId")
					.WithParameter("Position", position) as StoredProcedure;
				setRecordPositionProcedure.PackageName = Page.UserConnection.DBEngine.SystemPackageName;
				setRecordPositionProcedure.Execute();
			}
			return true;
		}

		public override Select CreateSelect() {
			var moduleSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ModuleEntitySchemaUId);
			var schema = UserConnection.DBSecurityEngine.GetRecordRightsSchema(moduleSchema);
			var select = new Terrasoft.Core.DB.Select(Page.UserConnection)
				.Column(schema.Name, "Id")
				.Column(schema.Name, "SysAdminUnitId").As("SysAdminUnitId")
				.Column("SysAdminUnit", "Name").As("SysAdminUnitName")
				.Column("EntitySchemaRecRightOperation", "Id").As("OperationId")
				.Column("EntitySchemaRecRightOperation", "Name").As("OperationName")
				.Column("SysEntitySchemaRecOprRightLvl", "Id").As("RightLevelId")
				.Column("SysEntitySchemaRecOprRightLvl", "Name").As("RightLevelName")
				.Column("Position").As("Position")
				.From(schema.Name)
				.InnerJoin("EntitySchemaRecRightOperation").On("EntitySchemaRecRightOperation", "Value").IsEqual(schema.Name, "Operation")
				.InnerJoin("SysEntitySchemaRecOprRightLvl").On("SysEntitySchemaRecOprRightLvl", "Value").IsEqual(schema.Name, "RightLevel")
				.InnerJoin("SysAdminUnit").On("SysAdminUnit", "Id").IsEqual(schema.Name, "SysAdminUnitId")
				.Where(schema.Name, "RecordId").IsEqual(Terrasoft.Core.DB.Column.Parameter(SelectedNodePrimaryColumnValue))
				.And(schema.Name, "Position").IsGreater(new QueryParameter(-1))
				.And(schema.Name, "Operation").IsEqual(new QueryParameter(GetViewCode()))
				.OrderByAsc("Position") as Terrasoft.Core.DB.Select;
			return select;
		}

		public override List<Dictionary<string, object>> GetStructureDefinition() {
			List<Dictionary<string, object>> structure = new List<Dictionary<string, object>>();
			var moduleSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ModuleEntitySchemaUId);
			var schema = UserConnection.DBSecurityEngine.GetRecordRightsSchema(moduleSchema);
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var valueListSchemaManager = Page.UserConnection.ValueListSchemaManager;
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
				{"Name", "Position"},
				{"ValueColumnName", "Position"},
				{"DisplayColumnName", "Position"},
				{"DataValueType", "Integer"},
				{"Caption", PositionCaption},
				{"IsVisible", false},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "SysAdminUnit"},
				{"ValueColumnName", "SysAdminUnitId"},
				{"DisplayColumnName", "SysAdminUnitName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("VwSysAdminUnit").UId},
				{"ReferenceSchemaName", "VwSysAdminUnit"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", schema.Columns.GetByName("SysAdminUnit").Caption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "Operation"},
				{"ValueColumnName", "OperationId"},
				{"DisplayColumnName", "OperationName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("EntitySchemaRecRightOperation").UId},
				{"ReferenceSchemaName", "EntitySchemaRecRightOperation"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", RightCaption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			column = new Dictionary<string, object> {
				{"Name", "RightLevel"},
				{"ValueColumnName", "RightLevelId"},
				{"DisplayColumnName", "RightLevelName"},
				{"DataValueType", "Lookup"},
				{"ReferenceSchemaUId", entitySchemaManager.GetInstanceByName("SysEntitySchemaRecOprRightLvl").UId},
				{"ReferenceSchemaName", "SysEntitySchemaRecOprRightLvl"},
				{"ReferenceSchemaPrimaryColumnName", "Id"},
				{"ReferenceSchemaPrimaryDisplayColumnName", "Name"},
				{"Caption", RightLevelCaption},
				{"IsVisible", true},
				{"IsSortable", false}
			};
			structure.Add(column);
			return structure;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public virtual void SetRecordPosition(int position) {
			var primaryColumnValue = (DataSource as VirtualDataSource).ActiveRowPrimaryColumnValue;
			StoredProcedure setRecordPositionProcedure = new StoredProcedure(Page.UserConnection, "tsp_SetRecordPosition")
				.WithParameter("TableName", RightsSchemaName)
				.WithParameter("PrimaryColumnName", "Id")
				.WithParameter("PrimaryColumnValue", primaryColumnValue)
				.WithParameter("GrouppingColumnNames", "Operation,RecordId")
				.WithParameter("Position", position) as StoredProcedure;
			setRecordPositionProcedure.PackageName = Page.UserConnection.DBEngine.SystemPackageName;
			setRecordPositionProcedure.Execute();
		}

		public virtual int GetSelectedRecordPosition() {
			Guid selectedRecordId = (DataSource as VirtualDataSource).ActiveRowPrimaryColumnValue;
			var select = new Terrasoft.Core.DB.Select(Page.UserConnection)
				.From(RightsSchemaName)
				.Column("Position")
				.Where("Id").IsEqual(Column.Parameter(selectedRecordId)) as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var dataReader = select.ExecuteReader(dbExecutor)) {
					while (dataReader.Read()) {
						return UserConnection.DBTypeConverter.DBValueToInt(dataReader.GetValue(0));
					}
				}
			}
			return 0;
		}

		public virtual Guid SetEntitySchemaRecordRightLevel(Guid adminUnitId, string moduleSchemaName, Guid selectedNodePrimaryColumnValue, EntitySchemaRecordRightOperation operation, EntitySchemaRecordRightLevel rightCode) {
			return UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, moduleSchemaName,
								selectedNodePrimaryColumnValue,	(Terrasoft.Core.Configuration.EntitySchemaRecordRightOperation) operation, 
								(Terrasoft.Core.Configuration.EntitySchemaRecordRightLevel) rightCode);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DownButtonClick":
							if (ActivatedEventElements.Contains("DownButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("DownButtonClickStartMessage");
						}
						break;
					case "UpButtonClick":
							if (ActivatedEventElements.Contains("UpButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("UpButtonClickStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("StartChildAddButtonClick")) {
							context.QueueTasks.Enqueue("StartChildAddButtonClick");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("IntermediateCatchChildLookupGridPageClosed")) {
						context.QueueTasks.Enqueue("IntermediateCatchChildLookupGridPageClosed");
					}
					break;
					case "AllowAddDetailMessage":
							if (ActivatedEventElements.Contains("StartMessageChild")) {
							context.QueueTasks.Enqueue("StartMessageChild");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("UseDenyRecordRightsEnabled") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UseDenyRecordRightsEnabled", UseDenyRecordRightsEnabled, false);
			}
			if (!HasMapping("NeedAddDetailRequest") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedAddDetailRequest", NeedAddDetailRequest, false);
			}
			if (!HasMapping("RightsSchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RightsSchemaName", RightsSchemaName, null);
			}
			if (!HasMapping("ModuleEntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ModuleEntitySchemaUId", ModuleEntitySchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseObjectRecordRightsGridPageEventsProcess

	/// <exclude/>
	public class BaseObjectRecordRightsGridPageEventsProcess : BaseObjectRecordRightsGridPageEventsProcess<Terrasoft.WebApp.BaseObjectRecordRightsGridPageSchemaUserControl>
	{

		public BaseObjectRecordRightsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseObjectRecordRightsGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseObjectRecordRightsGridPageSchemaUserControl : Terrasoft.WebApp.BaseVirtualGridPageSchemaUserControl
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

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			UpButton.AjaxEvents.Click.Event += UpButtonClick;
			DownButton.AjaxEvents.Click.Event += DownButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			UpButton.AjaxEvents.Click.Event -= UpButtonClick;
			DownButton.AjaxEvents.Click.Event -= DownButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseObjectRecordRightsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseObjectRecordRightsGridPageEventsProcess(UserConnection);
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

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
		}

		public virtual void UpButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("UpButtonClick");
		}

		public virtual void DownButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownButtonClick");
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
			SchemaName = "BaseObjectRecordRightsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseObjectRecordRightsGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseObjectRecordRightsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseVirtualGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseObjectRecordRightsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseObjectRecordRightsGridPageEventsProcessSchema(BaseObjectRecordRightsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseObjectRecordRightsGridPageEventsProcess";
			UId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f");
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

		protected virtual ProcessSchemaParameter CreateModuleEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("44d71065-8737-4ef6-87b9-474a56a0e083"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"ModuleEntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRightsSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("39bfbec8-c3c6-470a-bd03-d494bafd2941"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"RightsSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedAddDetailRequestParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("17e525bc-106a-4f4a-a786-74c8dfd50d14"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"NeedAddDetailRequest",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUseDenyRecordRightsEnabledParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("af4b175f-4ef3-4b05-8b1b-2ca561ecf057"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"UseDenyRecordRightsEnabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateModuleEntitySchemaUIdParameter());
			Parameters.Add(CreateRightsSchemaNameParameter());
			Parameters.Add(CreateNeedAddDetailRequestParameter());
			Parameters.Add(CreateUseDenyRecordRightsEnabledParameter());
		}

		protected virtual void InitializeUserTaskChildOpenLookupGridPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("db803bb6-cbb4-44fc-a185-0f737f6c4b19"),
				ContainerUId = new Guid("3fe09f9a-0ec9-460a-adf3-e93a96931236"),
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
				UId = new Guid("f9f2a40f-30dc-40c8-8cef-09ac957a43c5"),
				ContainerUId = new Guid("3fe09f9a-0ec9-460a-adf3-e93a96931236"),
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
				UId = new Guid("ed645050-a35c-4a42-af1c-f4334b8a96d6"),
				ContainerUId = new Guid("3fe09f9a-0ec9-460a-adf3-e93a96931236"),
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
				UId = new Guid("5a2c6550-ab79-42ed-a79d-dcae2d6f8759"),
				ContainerUId = new Guid("3fe09f9a-0ec9-460a-adf3-e93a96931236"),
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaButtonsLane1 = CreateButtonsLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaButtonsLane1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocesschildaddbuttonclick = CreateEventSubProcessChildAddButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocesschildaddbuttonclick);
			ProcessSchemaStartMessageEvent downbuttonclickstartmessage = CreateDownButtonClickStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(downbuttonclickstartmessage);
			ProcessSchemaScriptTask downbuttonclickscripttask = CreateDownButtonClickScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(downbuttonclickscripttask);
			ProcessSchemaIntermediateThrowMessageEvent gridpagerefreshrowintermediatethrowmessageevent1 = CreateGridPageRefreshRowIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(gridpagerefreshrowintermediatethrowmessageevent1);
			ProcessSchemaScriptTask upbuttonclickscripttask = CreateUpButtonClickScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(upbuttonclickscripttask);
			ProcessSchemaStartMessageEvent upbuttonclickstartmessage = CreateUpButtonClickStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(upbuttonclickstartmessage);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent = CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent startchildaddbuttonclick = CreateStartChildAddButtonClickStartMessageEvent();
			eventsubprocesschildaddbuttonclick.FlowElements.Add(startchildaddbuttonclick);
			ProcessSchemaScriptTask scriptchildopenlookupgridpage = CreateScriptChildOpenLookupGridPageScriptTask();
			eventsubprocesschildaddbuttonclick.FlowElements.Add(scriptchildopenlookupgridpage);
			ProcessSchemaUserTask usertaskchildopenlookupgridpage = CreateUserTaskChildOpenLookupGridPageUserTask();
			eventsubprocesschildaddbuttonclick.FlowElements.Add(usertaskchildopenlookupgridpage);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchchildlookupgridpageclosed = CreateIntermediateCatchChildLookupGridPageClosedIntermediateCatchMessageEvent();
			eventsubprocesschildaddbuttonclick.FlowElements.Add(intermediatecatchchildlookupgridpageclosed);
			ProcessSchemaScriptTask scriptchildlookupgridpageclosed = CreateScriptChildLookupGridPageClosedScriptTask();
			eventsubprocesschildaddbuttonclick.FlowElements.Add(scriptchildlookupgridpageclosed);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocesschildaddbuttonclick.FlowElements.Add(exclusivegateway1);
			ProcessSchemaStartMessageEvent startmessagechild = CreateStartMessageChildStartMessageEvent();
			eventsubprocesschildaddbuttonclick.FlowElements.Add(startmessagechild);
			ProcessSchemaScriptTask scriptchildrequestadddetailmessage = CreateScriptChildRequestAddDetailMessageScriptTask();
			eventsubprocesschildaddbuttonclick.FlowElements.Add(scriptchildrequestadddetailmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasegridpagerefreshrow = CreateIntermediateThrowBaseGridPageRefreshRowIntermediateThrowMessageEvent();
			eventsubprocesschildaddbuttonclick.FlowElements.Add(intermediatethrowbasegridpagerefreshrow);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateConditionalFlowChildNeedDetailRequestConditionalFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateRightCaptionLocalizableString());
			LocalizableStrings.Add(CreateRightLevelCaptionLocalizableString());
			LocalizableStrings.Add(CreatePositionCaptionLocalizableString());
			LocalizableStrings.Add(CreateWarningLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateRightCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e3552fab-02a8-45ec-b738-ac64dedff6a0"),
				Name = "RightCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRightLevelCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c1dafb26-2cb0-4614-8a43-9a9cbdd9cd65"),
				Name = "RightLevelCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePositionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("24d1f0aa-348c-4a5e-beeb-2fd7fa20fa85"),
				Name = "PositionCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("920e2e0f-8123-4fcc-98e1-0be017c86e09"),
				Name = "Warning",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("ae07563e-f18e-4e16-bd12-45d01ec908d6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f3799984-fc21-48c4-8b27-54953cd813ce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18859623-4c5c-4689-838e-328185844a02"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("c6a64255-a00e-4b79-9bf6-684e1a109adc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7cf11a73-ac30-40f3-93ac-e3678e07ffeb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b1b8449-d998-498a-b89c-5de22bf19ef5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("bcd790d2-ebd2-45d0-93ca-1766647efca0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(176, 505),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1097ba68-6eae-4308-b4c8-cf276837c4db"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("016066c9-e1d4-4f82-8b4b-a106dab98d8d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("fab817e2-6c8a-4aea-9866-ca3f730479fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(268, 498),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("016066c9-e1d4-4f82-8b4b-a106dab98d8d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e0aab5c2-4b07-4492-a7db-abade07ce2a7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("af3b7626-e627-42de-aab9-23f67545a390"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(378, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8b1b8449-d998-498a-b89c-5de22bf19ef5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("38386ca8-65d8-4f6d-bf71-050cbf700e99"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("8493a9a9-ad1d-479b-99ae-fa4babf8dd1b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(388, 331),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18859623-4c5c-4689-838e-328185844a02"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("38386ca8-65d8-4f6d-bf71-050cbf700e99"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("fb3afcb5-4a89-42b1-9dad-679ad1961802"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(278, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ed5d45ec-c369-4fbe-bc6c-b2f0a70693de"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3fe09f9a-0ec9-460a-adf3-e93a96931236"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("d0b3970b-fdf5-4ac8-8d71-99716f091938"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(406, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3fe09f9a-0ec9-460a-adf3-e93a96931236"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("354767c0-f38b-4550-b411-4263485be01c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("52634b54-81a4-46e4-90a2-85d28fbefdd0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(516, 83),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("354767c0-f38b-4550-b411-4263485be01c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba2817ab-5fc3-4241-a5d3-5a7c0a98efdc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("9338c321-cf2b-4b1c-bf64-60ffbe0d152d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5cccd080-2925-438c-a32b-21b4d7f536a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f8deefb-652a-4eb9-a613-17854338dbd8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowChildNeedDetailRequestConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowChildNeedDetailRequest",
				UId = new Guid("5a751754-5000-420a-8f64-5be6809954c3"),
				ConditionExpression = @"NeedAddDetailRequest",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(318, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f8deefb-652a-4eb9-a613-17854338dbd8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("56dba2a9-f18d-433f-bdd9-40ad15132c05"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("224e2bcc-39a9-499f-aeac-07d362a94dd8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(390, 165),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da596df1-08de-4b12-86f7-3e3eb3eb3428"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed5d45ec-c369-4fbe-bc6c-b2f0a70693de"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow12",
				UId = new Guid("f3b043a1-7f15-45d8-a48d-d3fbcf5d9992"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(239, 160),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f8deefb-652a-4eb9-a613-17854338dbd8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed5d45ec-c369-4fbe-bc6c-b2f0a70693de"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("3c8af7a1-0409-456d-b6ef-9c854f6c56e8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CurveCenterPosition = new Point(758, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ba2817ab-5fc3-4241-a5d3-5a7c0a98efdc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4ae7449-0024-49b0-9e34-c3630f2c50b1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e34004af-43b4-4329-83bf-6a428401d11c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(897, 615),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateButtonsLane1Lane() {
			ProcessSchemaLane schemaButtonsLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("70bb6358-b99a-467c-8f71-70abec9ff605"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("e34004af-43b4-4329-83bf-6a428401d11c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"ButtonsLane1",
				Position = new Point(29, 352),
				Size = new Size(868, 312),
				UseBackgroundMode = false
			};
			return schemaButtonsLane1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("4ff5da6b-03d6-4fad-a1cc-a3ad86b08fb4"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("e34004af-43b4-4329-83bf-6a428401d11c"),
				CreatedInOwnerSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 381),
				Size = new Size(868, 234),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("f180258e-8aa2-47de-bce6-ddbcd27aa9c2"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e34004af-43b4-4329-83bf-6a428401d11c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(868, 347),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("59643b6b-89e5-46f5-a0d0-8fb22f481e20"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70bb6358-b99a-467c-8f71-70abec9ff605"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"EventSubProcess2",
				Position = new Point(36, 23),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(444, 242),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDownButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7cf11a73-ac30-40f3-93ac-e3678e07ffeb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59643b6b-89e5-46f5-a0d0-8fb22f481e20"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownButtonClick",
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"DownButtonClickStartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDownButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8b1b8449-d998-498a-b89c-5de22bf19ef5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59643b6b-89e5-46f5-a0d0-8fb22f481e20"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"DownButtonClickScriptTask",
				Position = new Point(197, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,204,43,81,72,46,45,42,74,205,43,9,200,47,206,44,201,204,207,83,176,85,112,79,45,9,78,205,73,77,46,73,77,9,74,77,206,47,74,129,201,105,104,90,115,5,167,150,160,9,162,27,160,173,96,8,84,87,148,90,82,90,148,167,80,82,84,154,106,13,0,255,106,221,186,103,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateGridPageRefreshRowIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("38386ca8-65d8-4f6d-bf71-050cbf700e99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59643b6b-89e5-46f5-a0d0-8fb22f481e20"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"GridPageRefreshRowIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(343, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("18859623-4c5c-4689-838e-328185844a02"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59643b6b-89e5-46f5-a0d0-8fb22f481e20"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"UpButtonClickScriptTask",
				Position = new Point(197, 142),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,204,43,81,72,46,45,42,74,205,43,9,200,47,206,44,201,204,207,83,176,85,112,79,45,9,78,205,73,77,46,73,77,9,74,77,206,47,74,129,201,105,104,90,115,101,166,41,104,160,107,209,85,48,84,176,81,48,208,84,168,230,226,44,74,45,41,45,202,83,40,41,42,77,181,230,170,229,10,78,45,65,51,3,139,102,160,177,200,218,0,196,22,164,220,150,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUpButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f3799984-fc21-48c4-8b27-54953cd813ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59643b6b-89e5-46f5-a0d0-8fb22f481e20"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpButtonClick",
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"UpButtonClickStartMessage",
				Position = new Point(29, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7605b66a-8d3a-4dfa-a0e9-ccb08000265d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ff5da6b-03d6-4fad-a1cc-a3ad86b08fb4"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(427, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1097ba68-6eae-4308-b4c8-cf276837c4db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7605b66a-8d3a-4dfa-a0e9-ccb08000265d"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("016066c9-e1d4-4f82-8b4b-a106dab98d8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7605b66a-8d3a-4dfa-a0e9-ccb08000265d"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e0aab5c2-4b07-4492-a7db-abade07ce2a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7605b66a-8d3a-4dfa-a0e9-ccb08000265d"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(217, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,177,78,196,48,16,68,107,252,21,166,203,53,254,129,136,38,36,66,87,28,66,23,133,222,56,115,57,75,201,26,217,235,67,17,226,223,217,35,141,11,82,218,51,122,51,179,55,27,245,18,198,60,163,119,87,44,86,63,233,33,33,62,7,34,56,246,129,76,71,236,121,221,212,147,37,59,33,154,23,240,145,18,91,114,104,214,225,56,86,167,63,68,105,149,223,67,173,132,213,130,214,51,92,136,227,217,79,87,78,29,217,143,25,163,4,149,185,230,31,103,173,252,69,87,143,251,140,131,254,86,15,111,210,200,12,159,77,102,150,182,61,248,221,39,47,106,117,177,115,130,116,216,28,109,248,162,125,207,143,186,201,33,210,206,9,218,166,135,203,81,182,117,52,121,194,125,127,89,103,155,80,149,123,132,89,106,175,118,129,112,183,0,115,127,213,42,130,115,36,205,49,163,254,5,4,229,18,177,135,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildAddButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildAddButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f180258e-8aa2-47de-bce6-ddbcd27aa9c2"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"EventSubProcessChildAddButtonClick",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(790, 326),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildAddButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartChildAddButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5cccd080-2925-438c-a32b-21b4d7f536a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"StartChildAddButtonClick",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildOpenLookupGridPageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ed5d45ec-c369-4fbe-bc6c-b2f0a70693de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"ScriptChildOpenLookupGridPage",
				Position = new Point(288, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,91,75,195,64,16,133,223,5,255,195,146,167,4,154,69,123,9,45,85,161,86,144,160,96,192,4,159,55,187,147,102,109,187,27,102,54,74,255,189,219,21,226,5,20,125,25,56,195,57,223,28,134,28,106,179,97,218,144,19,70,66,174,216,37,139,227,18,16,5,217,198,241,42,231,79,80,175,173,113,104,119,196,11,177,129,228,56,248,138,186,32,120,62,68,121,105,31,3,46,78,150,167,39,21,1,150,130,182,235,86,239,212,67,7,230,222,218,109,223,221,162,86,1,80,160,149,64,116,7,7,127,242,243,102,32,86,185,250,11,199,143,66,160,216,131,3,36,207,50,240,202,110,180,116,218,26,129,7,118,65,161,211,136,217,250,25,164,187,10,229,94,4,178,238,123,48,254,37,149,252,175,134,63,241,14,96,36,91,216,139,42,60,54,82,51,117,118,222,72,149,102,106,46,211,105,61,94,164,11,152,205,83,41,197,164,105,32,27,79,178,105,228,179,95,171,241,149,82,113,52,128,162,209,7,52,249,193,220,106,5,215,189,115,214,144,183,59,236,225,232,68,112,61,154,32,151,111,116,72,144,39,249,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskChildOpenLookupGridPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3fe09f9a-0ec9-460a-adf3-e93a96931236"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"UserTaskChildOpenLookupGridPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(393, 51),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskChildOpenLookupGridPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchChildLookupGridPageClosedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("354767c0-f38b-4550-b411-4263485be01c"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"IntermediateCatchChildLookupGridPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(498, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildLookupGridPageClosedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ba2817ab-5fc3-4241-a5d3-5a7c0a98efdc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"ScriptChildLookupGridPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(582, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,203,110,219,48,16,60,203,128,255,129,205,137,2,4,162,143,99,154,2,137,234,26,70,227,196,136,237,228,80,244,192,138,107,155,141,68,10,75,202,177,16,228,223,75,174,100,87,9,208,75,15,162,228,125,204,14,103,214,123,137,108,47,203,6,28,187,96,252,171,46,188,182,70,98,203,62,59,143,218,108,51,102,127,253,134,194,127,73,215,14,112,37,221,99,190,211,165,186,173,193,92,91,251,216,212,83,212,106,33,183,32,166,224,151,80,134,82,80,247,4,200,99,71,110,141,1,2,77,207,199,163,141,69,144,197,142,241,253,113,236,204,67,197,180,233,57,164,236,121,60,74,98,82,170,74,155,181,209,126,166,2,49,3,79,108,218,104,197,79,61,226,59,180,17,49,209,27,198,135,197,239,46,168,82,76,170,218,183,29,94,162,141,103,182,6,148,145,71,128,11,164,246,128,94,172,236,204,248,79,31,121,160,126,175,225,41,183,10,120,74,168,212,130,122,187,243,215,176,135,50,244,124,160,112,39,10,115,197,14,42,121,35,43,8,153,215,215,20,19,227,181,111,151,84,49,151,38,72,131,81,155,72,250,170,93,207,20,159,91,213,148,48,44,11,209,84,68,52,154,225,131,250,207,73,18,63,73,10,132,194,162,34,29,150,224,135,125,119,148,185,59,209,28,10,145,13,72,102,132,149,28,237,185,9,247,92,160,174,130,205,185,45,155,202,144,95,89,194,87,128,40,157,221,120,145,7,163,194,97,54,122,219,116,178,137,127,12,190,61,234,154,254,149,56,99,221,192,255,2,164,155,164,3,241,59,67,94,88,33,125,92,157,101,235,162,255,75,40,26,12,253,167,143,201,161,128,154,12,134,67,239,123,50,7,231,130,1,11,105,130,135,213,240,7,45,129,71,91,174,189,46,181,215,224,196,55,109,84,31,228,29,127,218,235,75,87,211,187,79,185,31,239,127,102,236,236,74,58,24,162,159,101,204,99,3,41,147,142,13,227,196,157,150,244,213,248,176,165,166,41,203,35,207,100,152,20,121,9,18,121,119,237,55,169,75,165,122,116,254,32,209,208,31,20,14,162,143,101,199,209,171,182,6,209,23,244,56,47,17,139,132,12,71,120,198,163,112,32,248,6,13,49,63,255,3,81,104,80,14,10,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("2f8deefb-652a-4eb9-a613-17854338dbd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("da596df1-08de-4b12-86f7-3e3eb3eb3428"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AllowAddDetailMessage",
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"StartMessageChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(309, 205),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildRequestAddDetailMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("56dba2a9-f18d-433f-bdd9-40ad15132c05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"ScriptChildRequestAddDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 226),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,240,129,10,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,5,165,22,150,166,22,151,56,166,164,184,164,150,36,102,230,248,2,101,128,106,148,52,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,170,228,80,243,83,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBaseGridPageRefreshRowIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a4ae7449-0024-49b0-9e34-c3630f2c50b1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a452a9a-c8ce-4224-aa36-31373bdd5037"),
				CreatedInOwnerSchemaUId = new Guid("119c8333-6931-4165-861e-0db0c22e0503"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"GridPageRefreshRow",
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Name = @"IntermediateThrowBaseGridPageRefreshRow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(722, 65),
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
			Methods.Add(CreateSetRecordPositionMethod());
			Methods.Add(CreateGetSelectedRecordPositionMethod());
			Methods.Add(CreateSetEntitySchemaRecordRightLevelMethod());
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
				UId = new Guid("9bfe8576-1d63-44ad-8f53-6ffecd301cc6"),
				Name = "Terrasoft.UI.WebControls.Controls",
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

		protected override SchemaMethod CreateTreeGridConfigHandlerMethod() {
			SchemaMethod method = base.CreateTreeGridConfigHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,91,107,194,48,20,126,174,191,34,244,169,130,45,173,130,83,188,128,182,85,132,177,137,142,189,135,54,214,64,155,74,154,42,69,252,239,59,73,188,84,17,25,108,143,77,190,219,73,191,179,199,28,69,57,219,208,4,141,16,35,7,20,96,129,215,121,201,35,178,202,15,190,186,177,120,126,112,150,156,102,152,87,126,158,150,25,251,198,105,73,154,131,198,30,216,20,232,197,133,76,35,65,115,6,184,97,33,56,101,73,11,45,50,156,16,173,163,88,99,171,57,48,12,197,140,175,86,64,159,19,113,179,6,76,99,147,115,130,163,45,178,246,42,162,180,69,148,213,72,142,95,114,78,152,88,11,94,70,162,228,112,160,80,69,19,29,27,6,221,32,75,179,156,15,156,129,195,8,153,43,154,108,197,59,217,147,212,84,24,67,74,115,121,184,136,33,130,28,19,98,124,85,59,18,215,230,28,206,75,26,143,47,98,234,72,223,74,93,8,170,101,244,245,2,30,67,77,172,61,145,126,5,39,204,118,162,146,72,153,234,106,168,223,76,170,91,230,177,211,9,221,217,91,175,109,79,219,161,103,7,51,207,179,251,111,222,212,118,93,47,232,186,97,191,211,243,187,39,179,169,115,27,207,221,204,73,154,194,12,59,150,152,210,236,244,210,112,234,245,3,55,236,249,127,55,156,176,120,206,49,19,191,52,238,180,255,97,210,128,176,234,206,79,85,241,214,181,115,33,31,219,103,61,145,83,191,176,70,117,2,90,236,82,92,41,192,39,75,43,208,130,138,145,71,152,186,95,230,5,149,149,7,204,221,183,227,67,51,9,87,28,185,32,206,36,142,235,125,108,213,195,202,4,167,198,233,186,78,254,139,133,188,196,47,234,83,41,11,181,87,122,151,165,219,121,119,111,122,224,194,9,236,9,59,47,252,224,7,47,190,202,156,252,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateCellIconClickHandlerMethod() {
			SchemaMethod method = base.CreateCellIconClickHandlerMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,149,95,111,26,57,16,192,159,169,212,239,224,240,80,25,9,86,11,164,1,212,227,36,88,150,40,167,38,141,74,210,123,168,250,224,91,79,18,75,139,29,217,222,36,244,148,239,222,241,122,23,12,129,52,119,15,192,50,158,249,205,120,254,237,3,211,68,42,14,103,156,140,9,68,233,147,213,236,146,105,182,4,11,218,124,111,250,179,230,143,79,239,223,61,160,170,200,148,60,164,234,207,214,170,28,228,234,171,184,189,179,159,225,1,114,52,145,240,72,78,11,193,105,179,223,75,227,249,96,216,235,76,123,105,183,51,155,119,187,157,209,160,59,237,196,113,119,118,18,167,163,254,48,57,105,182,42,14,203,115,245,120,8,212,255,175,160,137,228,167,154,73,123,0,56,237,142,102,113,58,76,222,4,212,192,120,201,249,114,15,154,89,161,228,22,43,25,28,247,166,131,81,191,115,60,155,247,59,105,140,172,73,111,208,117,172,143,31,103,241,113,130,204,53,11,184,176,175,176,134,39,195,121,114,50,26,189,137,197,33,199,146,188,70,27,188,145,38,110,8,165,85,123,28,33,161,200,243,22,249,240,129,208,170,15,106,89,139,252,251,254,93,195,193,49,41,153,210,188,236,17,234,4,173,191,140,146,209,12,12,104,193,114,241,19,42,94,155,216,213,61,168,27,175,228,156,53,92,236,153,202,139,165,139,150,26,171,133,188,125,105,238,93,175,205,23,94,173,4,184,112,107,192,152,52,55,53,110,250,0,75,15,32,173,176,43,244,112,10,54,45,159,105,29,115,9,41,149,116,216,30,222,34,66,253,43,244,201,147,210,195,55,150,23,240,135,11,254,79,26,120,194,1,216,161,132,37,248,61,105,173,189,5,98,124,41,228,181,20,214,207,222,111,41,139,149,153,108,76,42,144,144,214,71,148,96,1,16,211,233,122,49,38,45,188,238,120,103,114,171,212,53,66,83,111,249,188,223,124,103,96,209,30,173,95,32,122,159,42,233,107,148,151,211,26,208,156,205,209,181,129,153,11,183,172,96,169,102,82,201,254,201,129,215,113,239,9,188,241,76,32,55,176,79,33,174,20,54,145,97,214,84,93,148,3,153,11,74,60,222,179,21,234,72,118,49,241,158,44,110,161,94,46,133,67,168,125,5,217,66,237,219,9,135,96,189,109,24,221,228,231,200,221,221,111,128,109,35,127,80,3,253,232,18,147,221,193,146,93,224,11,2,161,88,40,157,40,41,33,115,70,145,159,188,69,169,113,206,36,187,5,237,26,250,204,194,114,186,186,62,227,244,92,241,34,135,80,13,165,173,200,209,124,137,172,94,173,11,184,217,57,139,122,168,189,77,208,23,101,251,208,96,146,218,65,128,109,15,106,44,48,77,153,5,126,129,151,186,212,98,201,244,42,24,175,118,131,94,129,214,204,168,27,27,37,74,3,126,201,27,113,91,248,76,68,7,60,7,9,223,202,90,155,84,94,255,23,181,26,135,117,113,90,117,107,103,204,102,119,132,226,14,192,100,70,11,200,10,237,214,69,253,144,62,101,112,95,182,5,60,173,103,228,28,140,193,26,92,50,137,211,183,12,255,140,9,70,99,181,202,175,173,200,133,21,96,162,185,144,188,18,82,111,126,137,234,209,196,220,151,191,213,145,249,30,255,104,147,230,148,25,8,233,77,220,220,186,128,22,97,134,132,114,31,125,217,112,91,254,215,175,157,42,210,70,120,26,37,57,48,77,171,171,239,156,77,56,175,28,208,191,153,150,216,145,109,188,114,84,201,218,181,119,183,67,163,74,161,6,61,111,150,64,3,187,114,198,44,91,168,66,103,64,91,209,103,133,243,173,30,119,94,26,78,23,63,207,191,0,157,119,80,36,80,9,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,45,46,205,41,81,176,85,72,74,44,78,213,115,79,45,113,42,45,41,201,207,43,214,208,180,230,130,200,233,57,166,164,104,4,36,166,167,234,133,22,64,36,245,252,18,115,83,177,200,187,228,151,231,161,171,40,41,45,202,131,90,98,13,0,226,21,111,41,112,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateRowsDeleteMethodMethod() {
			SchemaMethod method = base.CreateRowsDeleteMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,193,110,219,48,12,61,39,95,161,249,164,0,134,80,108,199,174,5,218,52,43,2,172,155,81,167,237,97,24,6,205,102,19,97,182,100,72,84,154,96,200,191,151,82,236,196,201,210,213,135,56,166,200,71,242,241,81,75,105,89,109,74,95,65,94,44,160,150,236,130,61,56,176,99,163,53,20,168,140,22,19,141,10,215,219,211,59,169,229,28,172,184,5,156,106,135,82,23,112,189,126,152,150,252,46,66,244,93,201,58,58,31,46,9,222,189,1,124,115,157,67,225,45,69,76,244,92,105,8,168,247,80,24,91,222,171,249,2,221,22,135,247,171,35,68,165,145,153,6,172,12,24,4,74,128,75,176,40,102,102,170,241,211,71,78,32,143,10,94,198,166,4,62,34,127,180,107,246,119,56,120,47,247,13,84,128,7,13,244,74,249,10,75,168,248,112,48,224,51,176,86,58,243,140,98,108,44,208,143,126,86,115,191,45,70,188,17,253,189,171,118,180,171,59,109,73,17,223,100,13,41,179,209,57,18,182,97,133,196,98,193,120,190,118,8,181,232,202,220,253,153,172,10,104,98,239,176,26,133,206,238,192,57,26,74,38,53,84,172,238,127,68,114,208,154,234,1,85,165,80,129,19,95,148,46,91,35,245,147,145,171,184,114,77,124,183,102,247,227,236,103,202,146,107,233,160,143,156,164,12,173,135,17,147,142,245,237,231,195,129,122,102,252,32,239,135,11,166,125,85,197,234,6,253,19,49,174,64,90,78,109,30,217,175,202,178,5,229,79,210,106,165,231,41,181,39,90,91,218,101,156,173,27,16,173,67,0,217,12,232,25,110,162,202,32,144,79,45,82,215,36,129,73,251,197,199,22,36,66,78,211,45,48,234,33,84,219,249,82,207,158,228,116,201,206,98,173,17,102,165,92,171,194,105,73,88,157,43,177,18,244,25,42,32,2,43,95,235,71,89,121,248,124,235,85,121,201,147,105,153,132,130,2,66,99,156,106,181,249,94,48,105,153,98,179,54,96,143,96,85,45,237,186,231,73,88,252,70,162,204,141,183,5,132,25,60,42,139,94,86,123,227,72,92,145,180,151,112,111,94,178,127,226,9,56,71,18,108,153,89,83,64,233,45,48,215,45,91,151,126,127,68,227,131,23,118,20,192,163,72,14,215,136,116,130,174,249,149,31,67,37,35,26,176,120,82,184,200,164,37,133,35,88,158,204,228,239,10,130,222,73,74,253,5,15,166,83,254,7,93,180,113,145,231,247,124,99,199,73,122,56,202,83,81,183,214,248,166,33,45,237,115,184,144,100,183,176,105,23,125,58,105,215,109,186,155,121,92,143,35,226,136,251,183,185,22,153,44,254,16,177,33,55,241,126,130,99,186,170,218,43,106,123,35,244,2,254,143,60,89,209,141,129,16,182,109,51,180,128,222,234,184,194,231,175,162,31,124,208,243,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateCreateSelectMethod() {
			SchemaMethod method = base.CreateCreateSelectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,148,203,78,195,48,16,69,215,244,43,162,174,18,9,44,177,174,88,180,165,160,32,250,128,210,178,182,226,161,181,148,216,48,118,138,242,247,248,1,141,243,104,203,50,227,153,115,111,102,198,62,80,140,10,201,202,28,214,217,30,10,26,221,69,27,5,56,149,66,64,166,185,20,100,38,52,215,149,63,157,83,65,119,128,228,17,116,42,148,166,34,131,73,181,73,89,60,119,136,48,213,68,147,209,224,96,240,234,4,248,126,178,134,172,68,83,49,19,59,46,192,82,95,33,147,200,94,249,110,175,149,231,196,161,187,63,34,228,134,97,136,2,190,163,55,64,164,74,126,104,50,149,8,134,74,214,238,56,94,25,171,164,169,153,12,174,76,86,94,22,34,246,174,200,130,22,112,29,13,83,54,60,121,182,174,212,152,21,92,108,4,215,54,143,140,85,220,9,214,197,141,163,161,169,183,152,158,42,31,14,234,194,238,153,62,184,38,44,63,1,169,117,62,252,53,233,48,199,104,75,249,34,33,176,114,140,119,124,24,147,45,208,242,19,29,235,249,144,55,124,248,32,28,32,239,182,224,60,34,48,82,67,58,78,86,82,113,103,221,103,214,159,38,231,1,101,17,14,202,198,82,51,103,124,146,252,98,43,18,178,252,79,187,182,52,47,173,205,84,205,190,74,154,183,246,34,192,53,181,207,255,189,215,190,216,161,243,218,117,211,122,196,235,237,59,106,53,22,210,205,175,159,219,179,214,239,123,64,104,203,187,107,218,224,116,175,161,159,34,89,81,52,69,26,48,246,247,18,216,66,50,88,33,47,40,86,62,199,253,107,98,197,198,130,181,164,130,29,72,213,35,2,181,36,123,239,95,74,192,170,134,223,220,158,0,132,83,255,51,219,83,111,30,159,45,135,239,169,241,22,39,14,181,68,6,56,169,198,42,11,87,47,162,234,228,147,51,26,32,232,18,197,239,3,53,250,1,71,101,76,9,93,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetStructureDefinitionMethod() {
			SchemaMethod method = base.CreateGetStructureDefinitionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,193,78,194,64,16,61,203,87,52,61,213,132,244,7,80,19,5,99,154,160,18,16,238,107,59,192,106,187,219,236,110,49,141,225,223,157,238,182,180,148,182,168,33,232,137,100,230,205,99,230,237,155,73,199,84,170,171,17,245,21,229,140,136,244,74,42,65,217,170,111,241,215,55,240,213,205,141,133,129,196,87,137,0,235,218,98,240,97,141,143,20,56,151,131,222,134,8,43,226,65,18,194,204,95,67,68,176,116,46,65,12,57,99,160,11,221,123,166,168,74,77,246,145,48,178,2,225,62,128,242,152,84,132,249,112,151,206,189,192,121,212,20,85,40,70,115,122,217,66,60,186,155,129,159,8,172,184,103,43,202,32,99,157,130,207,69,48,165,171,181,146,134,199,169,118,151,51,194,97,75,72,63,193,95,247,120,243,134,98,67,194,4,50,129,190,195,178,104,4,27,34,159,135,73,196,114,197,219,197,182,62,123,23,159,246,19,137,192,238,91,182,23,216,219,126,22,208,204,67,77,113,144,27,81,25,135,36,109,203,18,69,116,245,75,26,235,204,67,66,139,220,144,196,89,27,123,120,79,46,168,164,175,97,134,93,146,80,66,17,158,113,161,72,67,124,34,104,132,131,152,191,199,36,154,11,182,189,237,160,183,179,153,123,27,4,142,153,31,31,230,87,66,76,184,164,186,213,86,57,106,136,70,81,234,152,186,52,30,83,128,15,118,160,78,81,151,71,126,42,212,169,197,152,165,242,54,136,40,155,51,170,218,5,169,162,186,189,82,69,234,88,139,60,99,206,223,147,56,207,78,97,9,2,112,177,119,107,140,144,134,133,219,191,1,25,189,99,47,62,246,70,184,116,177,186,145,181,232,176,86,208,136,221,243,225,193,26,52,131,27,229,168,72,80,90,192,28,39,215,32,101,54,84,49,76,109,148,86,143,232,189,56,151,69,158,99,16,164,123,97,118,144,110,115,236,96,103,113,70,245,14,227,141,215,7,190,156,229,184,81,186,235,255,192,55,186,131,255,225,9,221,202,24,54,16,182,155,162,196,116,187,162,196,157,197,22,184,99,181,151,125,142,133,233,97,19,126,195,22,221,245,127,101,11,173,223,201,189,33,0,99,172,252,200,27,124,1,244,52,162,71,16,10,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
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

		protected virtual SchemaMethod CreateSetRecordPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("014cc80a-0f6d-419f-8a97-b03dee4c4c4e"),
				Name = "SetRecordPosition",
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d4e816c2-0fe8-4578-b8a7-f17414e82a9b"),
				Name = "position",
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,193,78,195,48,16,68,207,228,43,172,156,18,169,242,15,68,61,64,91,33,46,96,37,80,142,104,113,86,137,69,98,71,235,117,75,255,158,4,138,2,73,218,155,189,222,153,209,60,31,128,68,71,166,5,58,109,92,19,90,187,135,38,160,88,139,100,11,12,133,11,164,81,128,23,123,67,28,160,25,135,169,188,213,108,14,152,187,163,154,233,179,168,96,71,88,42,114,26,203,64,40,60,114,142,218,81,169,156,55,108,156,29,159,214,194,226,81,76,4,137,130,10,229,139,71,218,56,107,81,15,146,149,136,217,119,111,197,212,42,78,163,27,249,106,184,86,64,208,34,35,37,241,51,188,55,248,216,223,226,149,200,77,85,179,47,116,141,45,12,163,133,245,127,21,206,178,248,161,92,114,158,183,237,119,231,8,23,148,247,228,66,215,25,91,141,49,126,200,121,234,144,224,187,224,79,175,11,185,191,109,251,180,243,49,29,126,102,2,46,139,46,163,150,10,244,71,207,117,72,238,177,47,32,150,219,187,157,173,140,69,89,156,60,99,251,71,112,213,120,247,137,58,48,38,105,246,5,47,198,115,160,81,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSelectedRecordPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8521691e-fa70-482f-b7c0-79e6675d2753"),
				Name = "GetSelectedRecordPosition",
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "int"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,144,49,111,195,32,16,133,103,251,87,32,79,176,160,236,86,135,38,78,35,47,149,229,164,233,76,205,53,70,178,161,61,192,110,84,229,191,23,66,36,167,145,144,16,239,238,125,247,142,157,87,146,88,24,160,115,32,91,232,12,202,90,146,39,66,43,225,196,222,120,236,128,8,75,142,10,157,23,195,34,50,254,220,57,53,65,107,230,6,213,40,240,188,49,131,31,245,81,12,30,202,124,18,120,163,6,150,134,153,28,0,81,88,243,233,248,198,32,240,106,205,247,215,50,109,196,9,248,155,5,220,24,173,131,160,140,102,121,198,95,208,140,180,85,167,222,217,125,215,195,40,94,197,8,177,144,198,208,162,49,86,197,230,34,138,239,61,32,208,162,150,5,227,181,221,126,135,168,52,53,242,70,96,112,58,64,250,184,37,99,113,179,20,163,204,189,85,250,68,104,12,46,63,182,63,208,121,103,48,132,255,31,141,111,181,245,8,213,122,145,104,224,252,230,217,189,63,252,82,11,66,66,244,167,169,60,17,33,201,116,153,144,204,217,220,171,1,8,93,156,60,94,55,116,150,33,56,143,250,49,75,181,62,156,191,32,8,19,96,88,48,188,175,191,127,48,181,118,247,168,29,184,107,129,174,24,43,3,238,146,135,115,201,111,208,85,249,7,20,100,203,15,4,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEntitySchemaRecordRightLevelMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f2070906-42d2-4980-8a8e-efba044f07e6"),
				Name = "SetEntitySchemaRecordRightLevel",
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f9d90d57-55c7-403b-8e47-3beffa78a069"),
				Name = "adminUnitId",
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("53af2cbc-9297-42d7-bf2b-cb07c1ed9a69"),
				Name = "moduleSchemaName",
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2e13a099-b4d3-4dbc-8f3e-eabbe3e39e97"),
				Name = "selectedNodePrimaryColumnValue",
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fdd09acc-19f8-44c5-9097-1612c4642270"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaRecordRightOperation",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b5b1986d-8223-4cc7-b52a-acecdd43da3b"),
				Name = "rightCode",
				CreatedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				ModifiedInSchemaUId = new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaRecordRightLevel",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,79,203,10,194,48,16,60,43,248,15,57,90,40,253,1,111,70,15,130,168,180,214,123,104,198,26,72,118,101,155,8,253,123,99,213,163,23,231,176,204,194,48,15,65,76,66,170,29,32,154,137,208,69,199,84,109,214,13,186,36,46,142,91,234,29,161,106,16,183,20,243,223,116,55,4,83,163,99,177,181,235,111,113,143,7,252,210,216,224,168,37,23,119,182,84,129,109,242,120,43,15,38,160,92,204,103,47,12,240,217,31,246,192,22,39,113,193,200,168,217,167,64,23,227,19,202,217,242,12,17,51,240,53,86,154,5,249,208,213,245,73,204,212,233,71,254,241,142,183,160,80,252,165,165,250,36,254,229,56,45,42,148,188,184,206,85,139,213,19,11,244,77,75,37,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseObjectRecordRightsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("144398e3-b6b6-4e41-a48b-7a6625d4626f"));
		}

		#endregion

	}

	#endregion

}

