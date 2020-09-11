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

	#region Class: SysAdminUnitGrantedRightsGridPageSchema

	/// <exclude/>
	public class SysAdminUnitGrantedRightsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public SysAdminUnitGrantedRightsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysAdminUnitGrantedRightsGridPageSchema(SysAdminUnitGrantedRightsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.FooterVisible = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
			RealUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
			Name = "SysAdminUnitGrantedRightsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnitGrantedRightsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysAdminUnitGrantedRightsGridPageEventsProcessSchema() {
			var schema = new SysAdminUnitGrantedRightsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("7273d66e-49ea-43e9-92ea-20f3d542407c");
			DataSource.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("c4cea81d-c751-49c8-b38e-7666f861bee1");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
				column.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8a2e796c-7ed7-4544-a9bc-4a3149183f3e");
			if (column != null) {
				column.UId = new Guid("b15a26c3-ab7b-4259-b489-d4f335d299eb");
				column.Name = @"GrantorSysAdminUnit";
				column.CreatedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
				column.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5290e2da-05d6-49e7-b839-9b098bf6b15e");
			if (column != null) {
				column.UId = new Guid("a3b279ef-c254-49d7-ae55-aabac69dfedd");
				column.Name = @"GranteeSysAdminUnit";
				column.CreatedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
				column.ModifiedInSchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
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
			return new SysAdminUnitGrantedRightsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysAdminUnitGrantedRightsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysAdminUnitGrantedRightsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitGrantedRightsGridPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitGrantedRightsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysAdminUnitGrantedRightsGridPageSchemaUserControl
	{

		#region Class: UserTaskOpenLookupFlowElement

		/// <exclude/>
		public class UserTaskOpenLookupFlowElement : OpenLookupUserTask
		{

			public UserTaskOpenLookupFlowElement(UserConnection userConnection, SysAdminUnitGrantedRightsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskOpenLookup";
				IsLogging = false;
				SchemaElementUId = new Guid("f9c84cf9-617d-4311-b288-cf83b5114b64");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public SysAdminUnitGrantedRightsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnitGrantedRightsGridPageEventsProcess";
			SchemaUId = new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0cad3757-6841-4acf-8796-8c7fca48ec23");
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

		private ProcessFlowElement _eventSubProcessAddButtonClick;
		public ProcessFlowElement EventSubProcessAddButtonClick {
			get {
				return _eventSubProcessAddButtonClick ?? (_eventSubProcessAddButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessAddButtonClick",
					SchemaElementUId = new Guid("1f4e2d52-ffa4-49fd-8797-99cf70124496"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAddButtonClick;
		public ProcessFlowElement StartMessageAddButtonClick {
			get {
				return _startMessageAddButtonClick ?? (_startMessageAddButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAddButtonClick",
					SchemaElementUId = new Guid("4b6e938f-b1fe-4b28-8c70-4a3b84eab087"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskAddButtonClick;
		public ProcessScriptTask ScriptTaskAddButtonClick {
			get {
				return _scriptTaskAddButtonClick ?? (_scriptTaskAddButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskAddButtonClick",
					SchemaElementUId = new Guid("d639ec28-251d-4e4f-96cd-5bbb3594ca24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskAddButtonClickExecute,
				});
			}
		}

		private UserTaskOpenLookupFlowElement _userTaskOpenLookup;
		public UserTaskOpenLookupFlowElement UserTaskOpenLookup {
			get {
				return _userTaskOpenLookup ?? (_userTaskOpenLookup = new UserTaskOpenLookupFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptAddRecord;
		public ProcessScriptTask ScriptAddRecord {
			get {
				return _scriptAddRecord ?? (_scriptAddRecord = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAddRecord",
					SchemaElementUId = new Guid("62812d08-f2da-48f8-9f08-f57c8c0dbc44"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAddRecordExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageLookupGridPageClosed;
		public ProcessFlowElement StartMessageLookupGridPageClosed {
			get {
				return _startMessageLookupGridPageClosed ?? (_startMessageLookupGridPageClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageLookupGridPageClosed",
					SchemaElementUId = new Guid("f9aa5e20-d774-46d1-be60-515898113c5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildDeleteMessage;
		public ProcessFlowElement EventSubProcessChildDeleteMessage {
			get {
				return _eventSubProcessChildDeleteMessage ?? (_eventSubProcessChildDeleteMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildDeleteMessage",
					SchemaElementUId = new Guid("ba2be681-55ae-472a-aac0-d0a7c1f70c4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildDeletYesMessage;
		public ProcessFlowElement StartMessageChildDeletYesMessage {
			get {
				return _startMessageChildDeletYesMessage ?? (_startMessageChildDeletYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildDeletYesMessage",
					SchemaElementUId = new Guid("e31629e2-924f-4fd8-a9ab-748539669b2e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildDeleteYesMessage;
		public ProcessScriptTask ScriptChildDeleteYesMessage {
			get {
				return _scriptChildDeleteYesMessage ?? (_scriptChildDeleteYesMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildDeleteYesMessage",
					SchemaElementUId = new Guid("bb3dfcda-d5a0-4b98-8d8a-cde7b549227d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildDeleteYesMessageExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildBasePrepareFilters;
		public ProcessFlowElement EventSubProcessChildBasePrepareFilters {
			get {
				return _eventSubProcessChildBasePrepareFilters ?? (_eventSubProcessChildBasePrepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildBasePrepareFilters",
					SchemaElementUId = new Guid("f3e1fb95-f404-4361-b19f-0dae482ad3fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildBasePrepareFilters;
		public ProcessFlowElement StartMessageChildBasePrepareFilters {
			get {
				return _startMessageChildBasePrepareFilters ?? (_startMessageChildBasePrepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildBasePrepareFilters",
					SchemaElementUId = new Guid("662a294b-830b-4786-938b-43ed92582e7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskChildBasePrepareFilters;
		public ProcessScriptTask ScriptTaskChildBasePrepareFilters {
			get {
				return _scriptTaskChildBasePrepareFilters ?? (_scriptTaskChildBasePrepareFilters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskChildBasePrepareFilters",
					SchemaElementUId = new Guid("4cb3ef37-05aa-4aa2-b3bf-f8fcab57e72d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskChildBasePrepareFiltersExecute,
				});
			}
		}

		private LocalizableString _actualizeOrganizationalStructureMessage;
		public LocalizableString ActualizeOrganizationalStructureMessage {
			get {
				return _actualizeOrganizationalStructureMessage ?? (_actualizeOrganizationalStructureMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ActualizeOrganizationalStructureMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessAddButtonClick };
			FlowElements[StartMessageAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAddButtonClick };
			FlowElements[ScriptTaskAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskAddButtonClick };
			FlowElements[UserTaskOpenLookup.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskOpenLookup };
			FlowElements[ScriptAddRecord.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAddRecord };
			FlowElements[StartMessageLookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageLookupGridPageClosed };
			FlowElements[EventSubProcessChildDeleteMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildDeleteMessage };
			FlowElements[StartMessageChildDeletYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildDeletYesMessage };
			FlowElements[ScriptChildDeleteYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildDeleteYesMessage };
			FlowElements[EventSubProcessChildBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildBasePrepareFilters };
			FlowElements[StartMessageChildBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildBasePrepareFilters };
			FlowElements[ScriptTaskChildBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskChildBasePrepareFilters };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessAddButtonClick":
						break;
					case "StartMessageAddButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskAddButtonClick");
						break;
					case "ScriptTaskAddButtonClick":
						e.Context.QueueTasks.Enqueue("UserTaskOpenLookup");
						break;
					case "UserTaskOpenLookup":
						break;
					case "ScriptAddRecord":
						break;
					case "StartMessageLookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("ScriptAddRecord");
						break;
					case "EventSubProcessChildDeleteMessage":
						break;
					case "StartMessageChildDeletYesMessage":
						e.Context.QueueTasks.Enqueue("ScriptChildDeleteYesMessage");
						break;
					case "ScriptChildDeleteYesMessage":
						break;
					case "EventSubProcessChildBasePrepareFilters":
						break;
					case "StartMessageChildBasePrepareFilters":
						e.Context.QueueTasks.Enqueue("ScriptTaskChildBasePrepareFilters");
						break;
					case "ScriptTaskChildBasePrepareFilters":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageAddButtonClick");
			ActivatedEventElements.Add("StartMessageLookupGridPageClosed");
			ActivatedEventElements.Add("StartMessageChildDeletYesMessage");
			ActivatedEventElements.Add("StartMessageChildBasePrepareFilters");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessAddButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAddButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAddButtonClick";
					result = StartMessageAddButtonClick.Execute(context);
					break;
				case "ScriptTaskAddButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskAddButtonClick";
					result = ScriptTaskAddButtonClick.Execute(context, ScriptTaskAddButtonClickExecute);
					break;
				case "UserTaskOpenLookup":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskOpenLookup";
					result = UserTaskOpenLookup.Execute(context);
					break;
				case "ScriptAddRecord":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAddRecord";
					result = ScriptAddRecord.Execute(context, ScriptAddRecordExecute);
					break;
				case "StartMessageLookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageLookupGridPageClosed";
					result = StartMessageLookupGridPageClosed.Execute(context);
					break;
				case "EventSubProcessChildDeleteMessage":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildDeletYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildDeletYesMessage";
					result = StartMessageChildDeletYesMessage.Execute(context);
					break;
				case "ScriptChildDeleteYesMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildDeleteYesMessage";
					result = ScriptChildDeleteYesMessage.Execute(context, ScriptChildDeleteYesMessageExecute);
					break;
				case "EventSubProcessChildBasePrepareFilters":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildBasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildBasePrepareFilters";
					result = StartMessageChildBasePrepareFilters.Execute(context);
					break;
				case "ScriptTaskChildBasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskChildBasePrepareFilters";
					result = ScriptTaskChildBasePrepareFilters.Execute(context, ScriptTaskChildBasePrepareFiltersExecute);
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

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskAddButtonClickExecute(ProcessExecutingContext context) {
			UserTaskOpenLookup.ProcessKey = Page.Process.InstanceUId;
			string schemaUId = "d5d01fcd-6d8c-4b29-9e58-cca3ffe62364";
			UserTaskOpenLookup.PageParameters = new Dictionary <string, object>();
			var pageParameters = new Dictionary <string, object>();
			pageParameters.Add("schemaUId", schemaUId);
			UserTaskOpenLookup.PageParameters = pageParameters;
			return true;
		}

		public virtual bool ScriptAddRecordExecute(ProcessExecutingContext context) {
			var values = (Dictionary <string, object>)UserTaskOpenLookup.GetSelectedValues(UserConnection);
			Guid selectedValue = Guid.Empty;
			foreach (var valueItem in values) {
				selectedValue = new Guid(valueItem.Key);
				break;
			}
			if (selectedValue == Guid.Empty || SelectedNodePrimaryColumnValue == Guid.Empty 
				|| (selectedValue == SelectedNodePrimaryColumnValue)) {
				return true;
			}
			var schema = Page.DataSource.Schema;
			var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
			bool newRecord = true;
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(entitySchemaManager, "SysAdminUnitGrantedRight");
			var primaryColumnName = query.AddColumn(query.RootSchema.GetPrimaryColumnName()).Name;
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "GranteeSysAdminUnit",
				SelectedNodePrimaryColumnValue));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "GrantorSysAdminUnit",
				selectedValue));
			var entities = query.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				newRecord = false;
			}
			if (newRecord) {
				Guid recordId = dbSecurityEngine.SetAdminUnitGrantedRight(selectedValue, SelectedNodePrimaryColumnValue);	
				dbSecurityEngine.ClearAdminUnitExpressionsCache(SelectedNodePrimaryColumnValue);
				Page.DataSource.LoadRow(recordId);
			}
			ShowActualizeOrganizationalStructureMessage();
			return true;
		}

		public virtual bool ScriptChildDeleteYesMessageExecute(ProcessExecutingContext context) {
			var values = new List<Guid>();
			foreach (var item in Page.DataSource.SelectedItemPrimaryColumnValues) {
				values.Add(item);
			}
			foreach (var item in values) {
				Page.UserConnection.DBSecurityEngine.DeleteAdminUnitGrantedRight(item);
				Page.DataSource.Remove(item);
			}
			Page.UserConnection.DBSecurityEngine.ClearAdminUnitExpressionsCache(SelectedNodePrimaryColumnValue);
			ShowActualizeOrganizationalStructureMessage();
			return true;
		}

		public virtual bool ScriptTaskChildBasePrepareFiltersExecute(ProcessExecutingContext context) {
			var dataSource = Page.DataSource;
			string filterCode = string.Empty;
			var viewFilterGroup = dataSource.FindFiltersGroupByName("ViewFilters");
			if (viewFilterGroup != null) {
				foreach (var filter in viewFilterGroup) {
					if (filter.IsEnabled) {
						filterCode = filter.Name;
						break;
					}
				}
				foreach (var filter in dataSource.CurrentStructure.Filters) {
					filter.IsEnabled = filterCode != "All";
				}
				if (filterCode == "All") {
					LoadViewFilters(true);
				}
			}
			return true;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public override void LoadViewFilters(bool enabledFilters) {
			var dataSource = Page.DataSource;
			var structure = Page.DataSource.CurrentStructure;
			var filters = dataSource.FindFiltersGroupByName("ViewFilters");
			if (filters != null) {
				structure.Filters.Remove(filters);
			}
			filters = structure.CreateFiltersGroup("ViewFilters", LogicalOperationStrict.And);
			var filterValuesObj = Page.UserConnection.DBSecurityEngine.GetUserAdminUnitCollection(SelectedNodePrimaryColumnValue);
			object[] filterValueArray = new object[filterValuesObj.Count];
			for (int i=0; i<filterValueArray.Length; i++) {
				filterValueArray[i] = filterValuesObj[i];
			}
			DataSourceFilterExpression leftExpression = structure.CreateDataSourceFilterExpression("GrantorSysAdminUnit");
			DataSourceFilterExpression rightExpression = structure.CreateDataSourceFilterExpression(filterValueArray);
			var filterItem = new DataSourceFilter(dataSource.Schema, Terrasoft.Core.Entities.FilterComparisonType.Equal,
				leftExpression, rightExpression);
			filterItem.Name = "All";
			filterItem.IsEnabled = enabledFilters;
			filters.Add(filterItem);
			structure.Filters.Add(filters);
		}

		public virtual void ShowActualizeOrganizationalStructureMessage() {
			var page = (Terrasoft.UI.WebControls.Page)System.Web.HttpContext.Current.CurrentHandler;
			if (page != null) {
				var scriptManager = page.FindControl("ScriptManager") as ScriptManager;
				var script = @"var messagePanel = window.mainPage.Ext.FormValidator.getVMP();
				messagePanel.clear();
				messagePanel.addMessage('', Ext.StringList('WC.Common').getValue('FormValidator.Warning'), '" + ActualizeOrganizationalStructureMessage + "', 'warning');";
				scriptManager.AddScript(script);
				}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("StartMessageAddButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageAddButtonClick");
							ProcessQueue(context);
							return;
						}
						break;
					case "LookupGridPageClosed":
							if (ActivatedEventElements.Contains("StartMessageLookupGridPageClosed")) {
							context.QueueTasks.Enqueue("StartMessageLookupGridPageClosed");
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("StartMessageChildDeletYesMessage")) {
							context.QueueTasks.Enqueue("StartMessageChildDeletYesMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("StartMessageChildBasePrepareFilters")) {
							context.QueueTasks.Enqueue("StartMessageChildBasePrepareFilters");
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
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitGrantedRightsGridPageEventsProcess

	/// <exclude/>
	public class SysAdminUnitGrantedRightsGridPageEventsProcess : SysAdminUnitGrantedRightsGridPageEventsProcess<Terrasoft.WebApp.SysAdminUnitGrantedRightsGridPageSchemaUserControl>
	{

		public SysAdminUnitGrantedRightsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnitGrantedRightsGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysAdminUnitGrantedRightsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysAdminUnitGrantedRightsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysAdminUnitGrantedRightsGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysAdminUnitGrantedRightsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitGrantedRightsGridPageEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnitGrantedRightsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnitGrantedRightsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnitGrantedRightsGridPageEventsProcessSchema(SysAdminUnitGrantedRightsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnitGrantedRightsGridPageEventsProcess";
			UId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected virtual void InitializeUserTaskOpenLookupParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("095884dc-a8c2-4329-87fc-182e066f6c5a"),
				ContainerUId = new Guid("f9c84cf9-617d-4311-b288-cf83b5114b64"),
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
				UId = new Guid("217827b3-1730-4940-bc29-73c7f4d2736a"),
				ContainerUId = new Guid("f9c84cf9-617d-4311-b288-cf83b5114b64"),
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
				UId = new Guid("2825ae69-36f7-43e2-a93d-4535121adf7a"),
				ContainerUId = new Guid("f9c84cf9-617d-4311-b288-cf83b5114b64"),
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
				UId = new Guid("56df2896-abe9-45fe-8838-1636773965b6"),
				ContainerUId = new Guid("f9c84cf9-617d-4311-b288-cf83b5114b64"),
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
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocessaddbuttonclick = CreateEventSubProcessAddButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocessaddbuttonclick);
			ProcessSchemaEventSubProcess eventsubprocesschilddeletemessage = CreateEventSubProcessChildDeleteMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschilddeletemessage);
			ProcessSchemaEventSubProcess eventsubprocesschildbasepreparefilters = CreateEventSubProcessChildBasePrepareFiltersEventSubProcess();
			FlowElements.Add(eventsubprocesschildbasepreparefilters);
			ProcessSchemaStartMessageEvent startmessageaddbuttonclick = CreateStartMessageAddButtonClickStartMessageEvent();
			eventsubprocessaddbuttonclick.FlowElements.Add(startmessageaddbuttonclick);
			ProcessSchemaScriptTask scripttaskaddbuttonclick = CreateScriptTaskAddButtonClickScriptTask();
			eventsubprocessaddbuttonclick.FlowElements.Add(scripttaskaddbuttonclick);
			ProcessSchemaUserTask usertaskopenlookup = CreateUserTaskOpenLookupUserTask();
			eventsubprocessaddbuttonclick.FlowElements.Add(usertaskopenlookup);
			ProcessSchemaScriptTask scriptaddrecord = CreateScriptAddRecordScriptTask();
			eventsubprocessaddbuttonclick.FlowElements.Add(scriptaddrecord);
			ProcessSchemaStartMessageEvent startmessagelookupgridpageclosed = CreateStartMessageLookupGridPageClosedStartMessageEvent();
			eventsubprocessaddbuttonclick.FlowElements.Add(startmessagelookupgridpageclosed);
			ProcessSchemaStartMessageEvent startmessagechilddeletyesmessage = CreateStartMessageChildDeletYesMessageStartMessageEvent();
			eventsubprocesschilddeletemessage.FlowElements.Add(startmessagechilddeletyesmessage);
			ProcessSchemaScriptTask scriptchilddeleteyesmessage = CreateScriptChildDeleteYesMessageScriptTask();
			eventsubprocesschilddeletemessage.FlowElements.Add(scriptchilddeleteyesmessage);
			ProcessSchemaStartMessageEvent startmessagechildbasepreparefilters = CreateStartMessageChildBasePrepareFiltersStartMessageEvent();
			eventsubprocesschildbasepreparefilters.FlowElements.Add(startmessagechildbasepreparefilters);
			ProcessSchemaScriptTask scripttaskchildbasepreparefilters = CreateScriptTaskChildBasePrepareFiltersScriptTask();
			eventsubprocesschildbasepreparefilters.FlowElements.Add(scripttaskchildbasepreparefilters);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateActualizeOrganizationalStructureMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateActualizeOrganizationalStructureMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("81d5a4f9-4226-41eb-98d1-ebaeabf912f3"),
				Name = "ActualizeOrganizationalStructureMessage",
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("67013354-7251-43f0-b7cd-f8a04dc3151f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4b6e938f-b1fe-4b28-8c70-4a3b84eab087"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d639ec28-251d-4e4f-96cd-5bbb3594ca24"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("231799f6-b658-485f-8ea6-0972ab09709d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				CurveCenterPosition = new Point(261, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d639ec28-251d-4e4f-96cd-5bbb3594ca24"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9c84cf9-617d-4311-b288-cf83b5114b64"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("1ec9f311-485c-41d5-a2cc-f836c30ca091"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				CurveCenterPosition = new Point(484, 75),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9aa5e20-d774-46d1-be60-515898113c5b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("62812d08-f2da-48f8-9f08-f57c8c0dbc44"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("e4d41503-c3f3-46da-a7f3-553fb616e085"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				CurveCenterPosition = new Point(170, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e31629e2-924f-4fd8-a9ab-748539669b2e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb3dfcda-d5a0-4b98-8d8a-cde7b549227d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("c62bd552-3282-43af-97c7-929a35f03341"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				CurveCenterPosition = new Point(434, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("662a294b-830b-4786-938b-43ed92582e7a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4cb3ef37-05aa-4aa2-b3bf-f8fcab57e72d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e2835cee-9295-4863-821b-8ccab229dded"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(622, 317),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6efa2abe-6bc2-41a4-956f-a03dfdf964e0"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e2835cee-9295-4863-821b-8ccab229dded"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(593, 317),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessAddButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessAddButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1f4e2d52-ffa4-49fd-8797-99cf70124496"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6efa2abe-6bc2-41a4-956f-a03dfdf964e0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"EventSubProcessAddButtonClick",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(543, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessAddButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAddButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4b6e938f-b1fe-4b28-8c70-4a3b84eab087"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f4e2d52-ffa4-49fd-8797-99cf70124496"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"StartMessageAddButtonClick",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskAddButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d639ec28-251d-4e4f-96cd-5bbb3594ca24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f4e2d52-ffa4-49fd-8797-99cf70124496"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"ScriptTaskAddButtonClick",
				Position = new Point(85, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,143,79,11,130,64,20,196,239,126,138,197,83,129,74,255,20,101,43,8,186,68,65,30,242,3,60,223,62,203,162,93,121,187,22,125,251,132,168,8,58,68,215,97,102,126,51,133,37,222,129,61,109,27,210,27,99,78,109,19,229,108,144,172,93,211,77,204,68,14,123,122,42,209,74,91,7,26,169,88,41,233,89,199,181,222,11,139,7,58,67,167,116,102,95,197,106,48,172,80,133,137,74,49,156,148,163,44,204,40,78,67,68,24,87,21,37,163,113,50,241,165,87,124,129,118,156,28,24,206,228,136,109,215,165,233,42,150,53,186,218,104,224,155,152,62,112,129,48,229,145,208,205,123,125,233,93,128,69,243,71,238,51,19,45,148,234,249,175,27,126,240,190,212,255,109,234,103,159,244,152,92,203,90,56,110,73,222,1,93,74,219,35,96,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskOpenLookupUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f9c84cf9-617d-4311-b288-cf83b5114b64"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f4e2d52-ffa4-49fd-8797-99cf70124496"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"UserTaskOpenLookup",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 37),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskOpenLookupParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAddRecordScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("62812d08-f2da-48f8-9f08-f57c8c0dbc44"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f4e2d52-ffa4-49fd-8797-99cf70124496"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"ScriptAddRecord",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(442, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,148,77,143,218,48,16,134,207,32,241,31,44,78,142,132,162,222,105,87,162,129,162,85,247,131,146,221,246,108,146,1,92,18,59,59,118,160,217,238,254,247,142,99,160,33,160,114,234,137,48,126,231,153,25,207,140,183,2,217,86,100,37,24,246,137,241,177,76,172,212,74,96,197,62,26,139,82,173,6,76,47,126,66,98,111,130,103,3,248,36,204,230,177,0,117,167,245,166,44,194,41,216,24,50,58,133,244,123,205,224,78,20,105,165,160,230,4,195,94,119,90,202,148,153,166,138,2,57,99,56,201,11,91,145,98,169,17,68,178,102,124,123,200,229,214,66,206,164,218,39,22,176,223,189,110,167,141,80,176,171,49,252,232,17,126,133,202,69,236,44,136,183,161,143,247,94,87,46,25,111,121,54,163,179,183,55,118,168,224,65,167,48,67,153,83,241,145,206,202,92,93,210,19,157,92,206,145,255,134,4,190,4,4,91,162,98,22,75,240,217,185,130,77,178,134,92,80,65,51,177,130,112,44,172,136,117,137,9,132,113,125,48,244,170,116,17,67,82,162,180,213,68,173,164,130,131,254,244,190,195,241,231,83,25,121,47,180,206,220,101,205,33,209,152,146,223,62,188,163,130,178,36,245,129,238,133,34,32,146,160,197,156,156,139,246,238,47,37,208,160,248,86,52,85,223,156,157,95,128,15,88,63,174,204,40,205,165,122,86,210,78,81,40,186,179,185,92,173,109,63,216,67,139,230,237,61,136,220,149,90,7,10,71,105,234,173,220,255,159,107,109,61,222,13,226,172,237,199,131,32,116,191,196,245,250,47,50,179,128,198,113,246,132,136,6,197,130,183,255,144,118,61,19,72,14,78,196,189,49,210,121,33,80,26,173,158,170,2,194,201,75,41,50,42,194,39,14,205,90,250,3,106,240,181,41,248,95,169,104,60,75,229,100,66,131,160,217,112,89,239,186,15,75,23,231,59,71,121,102,190,225,23,118,216,109,209,193,53,140,116,169,44,187,97,31,252,80,55,71,107,41,50,3,127,23,239,120,228,149,245,75,128,181,225,214,169,219,51,29,198,96,47,206,198,233,186,13,174,45,219,176,67,193,206,224,81,6,2,143,248,201,175,2,193,24,170,207,68,244,246,0,191,198,36,100,123,65,239,180,72,231,122,199,15,37,5,190,242,120,173,119,163,196,82,123,228,43,60,226,74,40,249,42,234,87,53,139,105,247,232,4,225,158,98,19,141,59,151,230,171,240,7,34,236,9,130,142,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageLookupGridPageClosedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f9aa5e20-d774-46d1-be60-515898113c5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f4e2d52-ffa4-49fd-8797-99cf70124496"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"StartMessageLookupGridPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(357, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildDeleteMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildDeleteMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ba2be681-55ae-472a-aac0-d0a7c1f70c4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6efa2abe-6bc2-41a4-956f-a03dfdf964e0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"EventSubProcessChildDeleteMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 147),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildDeleteMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildDeletYesMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e31629e2-924f-4fd8-a9ab-748539669b2e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba2be681-55ae-472a-aac0-d0a7c1f70c4c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"StartMessageChildDeletYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildDeleteYesMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bb3dfcda-d5a0-4b98-8d8a-cde7b549227d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba2be681-55ae-472a-aac0-d0a7c1f70c4c"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"ScriptChildDeleteYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,193,74,195,64,16,134,207,45,244,29,246,152,94,242,2,173,66,76,75,17,170,150,134,122,31,178,99,50,176,153,149,217,221,212,86,124,119,39,17,75,81,4,175,251,207,254,223,183,179,61,136,233,193,37,12,230,198,48,30,205,150,66,92,110,18,217,219,108,190,152,77,95,188,32,212,173,201,122,29,164,136,157,33,54,59,104,48,95,65,132,202,39,169,49,175,208,97,29,209,222,107,190,19,234,64,78,165,119,169,227,231,177,121,110,222,103,211,201,23,37,47,172,205,134,158,161,252,227,143,254,254,234,218,200,58,4,148,210,51,43,133,60,231,171,187,10,235,36,20,79,107,110,136,213,69,5,34,22,182,35,62,48,197,141,0,171,206,158,154,54,94,96,147,159,214,123,236,124,143,215,50,255,98,149,14,65,46,168,245,219,171,96,8,58,25,74,125,7,102,223,187,120,244,22,127,239,98,0,85,173,63,22,117,76,224,232,140,79,210,0,211,25,6,22,184,42,74,210,68,240,65,59,85,102,252,2,65,61,97,163,17,46,62,1,62,103,18,98,175,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildBasePrepareFiltersEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildBasePrepareFilters = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f3e1fb95-f404-4361-b19f-0dae482ad3fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6efa2abe-6bc2-41a4-956f-a03dfdf964e0"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"EventSubProcessChildBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(301, 147),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildBasePrepareFilters;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildBasePrepareFiltersStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("662a294b-830b-4786-938b-43ed92582e7a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3e1fb95-f404-4361-b19f-0dae482ad3fc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"StartMessageChildBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskChildBasePrepareFiltersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4cb3ef37-05aa-4aa2-b3bf-f8fcab57e72d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3e1fb95-f404-4361-b19f-0dae482ad3fc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				Name = @"ScriptTaskChildBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,205,138,194,48,20,133,215,205,83,92,187,106,55,125,129,224,98,116,116,24,144,97,64,152,125,108,110,157,96,76,228,54,169,136,248,238,230,71,170,83,24,200,34,220,115,114,190,123,50,8,2,41,156,216,90,79,45,194,28,190,197,30,155,247,113,194,89,239,72,153,61,116,74,59,164,165,149,209,148,103,205,234,120,114,23,206,134,144,49,40,60,175,147,229,131,172,63,5,207,51,181,89,43,35,179,216,39,117,113,249,18,71,172,202,159,241,81,95,214,156,169,14,170,105,206,108,14,198,107,93,195,149,21,157,37,20,237,111,48,5,96,222,7,148,153,162,147,181,136,89,217,210,124,246,43,35,118,26,101,86,138,63,77,30,158,184,15,143,226,46,32,14,241,118,99,241,252,131,124,233,182,244,68,104,220,214,145,111,157,167,88,54,21,202,176,233,10,35,49,225,67,185,242,77,235,146,39,214,115,229,188,219,67,204,65,27,43,228,203,119,85,1,135,117,122,119,99,132,1,108,32,142,248,29,44,167,207,130,208,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateShowActualizeOrganizationalStructureMessageMethod());
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

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
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

		protected override SchemaMethod CreateLoadViewFiltersMethod() {
			SchemaMethod method = base.CreateLoadViewFiltersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,193,78,227,48,16,61,147,175,240,230,148,138,202,226,222,237,161,132,82,33,33,64,27,224,130,122,112,147,73,106,228,216,97,108,151,141,86,251,239,59,33,73,147,6,118,15,123,179,253,222,204,155,121,51,62,8,100,153,112,34,49,30,83,96,75,246,32,10,224,87,199,151,69,112,32,134,117,232,83,231,241,11,2,143,61,34,104,151,244,148,54,34,151,202,1,90,226,15,217,249,181,212,217,117,11,108,208,248,234,178,190,19,37,68,225,179,132,247,238,61,156,45,2,153,179,168,143,255,182,100,218,43,53,99,191,130,179,99,21,188,35,243,31,80,154,3,244,100,10,253,29,12,194,3,61,70,16,14,198,202,167,154,115,118,107,10,153,10,117,95,1,10,39,141,166,110,100,234,248,74,103,179,113,63,207,66,121,176,247,187,215,222,135,39,11,24,27,173,33,109,162,248,213,101,2,169,71,233,234,181,46,164,6,190,1,215,80,86,89,41,245,147,150,46,54,74,181,220,40,129,230,4,217,157,201,224,1,101,41,176,38,212,151,250,67,132,100,205,238,149,8,47,219,177,246,10,81,212,36,174,225,157,117,248,164,50,30,27,175,221,118,17,228,6,89,36,181,99,114,121,177,96,242,251,52,11,191,5,93,184,61,65,231,231,31,246,78,9,47,114,75,74,147,244,244,216,184,60,204,191,245,112,253,179,66,176,150,250,98,10,114,55,186,126,158,195,223,99,163,112,131,66,59,131,73,109,143,150,53,27,241,15,57,148,197,254,191,245,166,45,159,12,251,198,65,217,89,61,77,17,141,150,58,73,247,80,138,57,123,4,202,96,77,238,104,2,164,189,214,78,58,9,182,219,213,216,148,149,64,105,141,126,172,43,66,223,188,80,243,224,236,212,172,249,180,27,170,103,168,133,55,159,133,10,10,87,74,133,39,192,141,93,107,177,83,144,17,10,237,169,91,237,158,102,249,42,203,162,33,132,18,127,254,77,3,133,190,210,31,162,129,237,197,25,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowActualizeOrganizationalStructureMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aee20801-ac77-4a70-b644-2ce7728b9008"),
				Name = "ShowActualizeOrganizationalStructureMessage",
				CreatedInSchemaUId = new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,209,106,2,49,16,69,159,235,87,164,251,146,44,149,252,128,8,45,75,197,66,165,130,173,62,79,77,92,2,217,137,76,102,181,181,244,223,59,81,91,148,62,133,220,123,231,220,97,118,64,106,11,173,87,99,101,94,61,17,228,180,97,251,246,100,87,254,189,73,200,148,98,182,115,9,212,139,207,204,190,43,186,157,50,111,139,233,63,216,54,61,145,199,191,119,10,232,162,167,209,32,108,148,57,130,111,199,10,251,24,107,245,53,184,217,73,91,94,83,216,242,12,80,76,146,218,18,178,147,128,238,92,103,170,197,101,162,170,21,100,117,37,141,46,65,66,184,175,202,183,243,57,139,59,7,244,81,196,189,16,211,222,118,16,176,172,111,31,101,215,73,162,110,9,49,56,224,68,182,245,188,156,205,77,45,184,203,89,187,142,30,232,191,12,206,205,78,127,163,245,80,21,222,130,41,96,251,28,50,27,189,106,108,147,186,46,161,174,143,100,136,189,4,175,27,87,64,40,3,186,30,42,93,169,59,245,176,230,94,204,131,127,161,22,48,28,128,67,66,136,130,237,197,33,127,238,147,100,37,141,122,255,59,62,170,100,185,171,59,218,7,231,78,55,50,39,189,172,255,253,3,93,150,76,97,221,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnitGrantedRightsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c4b81e1a-b21f-413b-b510-20261191a04a"));
		}

		#endregion

	}

	#endregion

}

