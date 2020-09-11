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
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
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

	#region Class: BaseManyToManyDetailGridPageSchema

	/// <exclude/>
	public class BaseManyToManyDetailGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public BaseManyToManyDetailGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseManyToManyDetailGridPageSchema(BaseManyToManyDetailGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				ImageHash = @""
			};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
			RealUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
			Name = "BaseManyToManyDetailGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseManyToManyDetailGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateBaseManyToManyDetailGridPageEventsProcessSchema() {
			var schema = new BaseManyToManyDetailGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseManyToManyDetailGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseManyToManyDetailGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseManyToManyDetailGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseManyToManyDetailGridPageEventsProcess

	/// <exclude/>
	public class BaseManyToManyDetailGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseManyToManyDetailGridPageSchemaUserControl
	{

		#region Class: OpenLookupGridPageFlowElement

		/// <exclude/>
		public class OpenLookupGridPageFlowElement : OpenLookupUserTask
		{

			public OpenLookupGridPageFlowElement(UserConnection userConnection, BaseManyToManyDetailGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupGridPage";
				IsLogging = false;
				SchemaElementUId = new Guid("4d66ce15-9db0-4c20-b940-6246efb8a800");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public BaseManyToManyDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseManyToManyDetailGridPageEventsProcess";
			SchemaUId = new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bb5ab5ef-40b7-45f6-b503-17afaa6584a0");
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

		public virtual bool IsEntityDetail {
			get;
			set;
		}

		private ProcessFlowElement _baseManyToManyDetailGridPageAddButtonClickSubProcess;
		public ProcessFlowElement BaseManyToManyDetailGridPageAddButtonClickSubProcess {
			get {
				return _baseManyToManyDetailGridPageAddButtonClickSubProcess ?? (_baseManyToManyDetailGridPageAddButtonClickSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseManyToManyDetailGridPageAddButtonClickSubProcess",
					SchemaElementUId = new Guid("11a0e195-139b-4f5e-83b9-b28ade464c76"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseManyToManyDetailGridPageAddButtonClick;
		public ProcessFlowElement BaseManyToManyDetailGridPageAddButtonClick {
			get {
				return _baseManyToManyDetailGridPageAddButtonClick ?? (_baseManyToManyDetailGridPageAddButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseManyToManyDetailGridPageAddButtonClick",
					SchemaElementUId = new Guid("d4916974-6c7c-4c5b-8f24-fdf49bd18e75"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseManyToManyDetailGridPageAddButtonClickScriptTask;
		public ProcessScriptTask BaseManyToManyDetailGridPageAddButtonClickScriptTask {
			get {
				return _baseManyToManyDetailGridPageAddButtonClickScriptTask ?? (_baseManyToManyDetailGridPageAddButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseManyToManyDetailGridPageAddButtonClickScriptTask",
					SchemaElementUId = new Guid("ec74923c-26bc-4d83-a7d7-b0bb1a5943c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseManyToManyDetailGridPageAddButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _initOpenLookupGridPage;
		public ProcessScriptTask InitOpenLookupGridPage {
			get {
				return _initOpenLookupGridPage ?? (_initOpenLookupGridPage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitOpenLookupGridPage",
					SchemaElementUId = new Guid("0cec1cf5-0662-4cea-8802-1ba626160a83"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitOpenLookupGridPageExecute,
				});
			}
		}

		private OpenLookupGridPageFlowElement _openLookupGridPage;
		public OpenLookupGridPageFlowElement OpenLookupGridPage {
			get {
				return _openLookupGridPage ?? (_openLookupGridPage = new OpenLookupGridPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("803ffccb-1e74-48e3-962f-f997c4db8e4a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessFlowElement _shadowingBaseEventsSubProcess;
		public ProcessFlowElement ShadowingBaseEventsSubProcess {
			get {
				return _shadowingBaseEventsSubProcess ?? (_shadowingBaseEventsSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ShadowingBaseEventsSubProcess",
					SchemaElementUId = new Guid("d819b817-4cf7-4280-a328-c5acdad1cfff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseManyToManyDetailGridPageInit;
		public ProcessFlowElement BaseManyToManyDetailGridPageInit {
			get {
				return _baseManyToManyDetailGridPageInit ?? (_baseManyToManyDetailGridPageInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseManyToManyDetailGridPageInit",
					SchemaElementUId = new Guid("250deb9d-a7ff-49fc-9e61-a7d45253da3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseManyToManyDetailGridPageInitScriptTask;
		public ProcessScriptTask BaseManyToManyDetailGridPageInitScriptTask {
			get {
				return _baseManyToManyDetailGridPageInitScriptTask ?? (_baseManyToManyDetailGridPageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseManyToManyDetailGridPageInitScriptTask",
					SchemaElementUId = new Guid("d3d1a1f1-a7f5-43a0-8c72-503d4c161550"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseManyToManyDetailGridPageInitScriptTaskExecute,
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
					SchemaElementUId = new Guid("95904da4-a608-44f7-af48-9e2fe81fb567"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _baseManyToManyDetailGridPageParentEventHandlerSubProcess;
		public ProcessFlowElement BaseManyToManyDetailGridPageParentEventHandlerSubProcess {
			get {
				return _baseManyToManyDetailGridPageParentEventHandlerSubProcess ?? (_baseManyToManyDetailGridPageParentEventHandlerSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseManyToManyDetailGridPageParentEventHandlerSubProcess",
					SchemaElementUId = new Guid("521229ba-99a7-4c3f-a130-45b8a95dd9c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseManyToManyDetailGridPagParentActiveRowChangedStartMessage;
		public ProcessFlowElement BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage {
			get {
				return _baseManyToManyDetailGridPagParentActiveRowChangedStartMessage ?? (_baseManyToManyDetailGridPagParentActiveRowChangedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage",
					SchemaElementUId = new Guid("4f29aa92-6f86-47a9-9db7-9265ef3a0f6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseManyToManyDetailGridPageParentActiveRowChangedScriptTask;
		public ProcessScriptTask BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask {
			get {
				return _baseManyToManyDetailGridPageParentActiveRowChangedScriptTask ?? (_baseManyToManyDetailGridPageParentActiveRowChangedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask",
					SchemaElementUId = new Guid("b4f83ac1-b431-4211-a9c2-a1de7e232678"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseManyToManyDetailGridPageParentActiveRowChangedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseManyToManyDetailGridPageAddButtonClickSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyDetailGridPageAddButtonClickSubProcess };
			FlowElements[BaseManyToManyDetailGridPageAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyDetailGridPageAddButtonClick };
			FlowElements[BaseManyToManyDetailGridPageAddButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyDetailGridPageAddButtonClickScriptTask };
			FlowElements[InitOpenLookupGridPage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitOpenLookupGridPage };
			FlowElements[OpenLookupGridPage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupGridPage };
			FlowElements[LookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosed };
			FlowElements[ShadowingBaseEventsSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ShadowingBaseEventsSubProcess };
			FlowElements[BaseManyToManyDetailGridPageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyDetailGridPageInit };
			FlowElements[BaseManyToManyDetailGridPageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyDetailGridPageInitScriptTask };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[BaseManyToManyDetailGridPageParentEventHandlerSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyDetailGridPageParentEventHandlerSubProcess };
			FlowElements[BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage };
			FlowElements[BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseManyToManyDetailGridPageAddButtonClickSubProcess":
						break;
					case "BaseManyToManyDetailGridPageAddButtonClick":
						e.Context.QueueTasks.Enqueue("InitOpenLookupGridPage");
						break;
					case "BaseManyToManyDetailGridPageAddButtonClickScriptTask":
						break;
					case "InitOpenLookupGridPage":
						e.Context.QueueTasks.Enqueue("OpenLookupGridPage");
						break;
					case "OpenLookupGridPage":
						ActivatedEventElements.Add("LookupGridPageClosed");
						break;
					case "LookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("BaseManyToManyDetailGridPageAddButtonClickScriptTask");
						break;
					case "ShadowingBaseEventsSubProcess":
						break;
					case "BaseManyToManyDetailGridPageInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "BaseManyToManyDetailGridPageInitScriptTask":
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("BaseManyToManyDetailGridPageInitScriptTask");
						break;
					case "BaseManyToManyDetailGridPageParentEventHandlerSubProcess":
						break;
					case "BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage":
						e.Context.QueueTasks.Enqueue("BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask");
						break;
					case "BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseManyToManyDetailGridPageAddButtonClick");
			ActivatedEventElements.Add("BaseManyToManyDetailGridPageInit");
			ActivatedEventElements.Add("BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseManyToManyDetailGridPageAddButtonClickSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseManyToManyDetailGridPageAddButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyDetailGridPageAddButtonClick";
					result = BaseManyToManyDetailGridPageAddButtonClick.Execute(context);
					break;
				case "BaseManyToManyDetailGridPageAddButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyDetailGridPageAddButtonClickScriptTask";
					result = BaseManyToManyDetailGridPageAddButtonClickScriptTask.Execute(context, BaseManyToManyDetailGridPageAddButtonClickScriptTaskExecute);
					break;
				case "InitOpenLookupGridPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitOpenLookupGridPage";
					result = InitOpenLookupGridPage.Execute(context, InitOpenLookupGridPageExecute);
					break;
				case "OpenLookupGridPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupGridPage";
					result = OpenLookupGridPage.Execute(context);
					break;
				case "LookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupGridPageClosed";
					result = LookupGridPageClosed.Execute(context);
					break;
				case "ShadowingBaseEventsSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseManyToManyDetailGridPageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyDetailGridPageInit";
					result = BaseManyToManyDetailGridPageInit.Execute(context);
					break;
				case "BaseManyToManyDetailGridPageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyDetailGridPageInitScriptTask";
					result = BaseManyToManyDetailGridPageInitScriptTask.Execute(context, BaseManyToManyDetailGridPageInitScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "BaseManyToManyDetailGridPageParentEventHandlerSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage";
					result = BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage.Execute(context);
					break;
				case "BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask";
					result = BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask.Execute(context, BaseManyToManyDetailGridPageParentActiveRowChangedScriptTaskExecute);
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
				case "IsEntityDetail":
					IsEntityDetail = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool BaseManyToManyDetailGridPageAddButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			Process lpProcess = UserConnection.IProcessEngine.FindProcessByUId(ListenerPageProcessUId);
			if (lpProcess == null || Page.DataSource == null) {
				return false;
			}
			
			EntitySchema entitySchema = Page.DataSource.Schema;
			Guid parentAssociationColumnValue = (Guid)lpProcess.GetPropertyValue(
				"ParentPrimaryColumnValue");
			DataSourceStructureColumn detaiAssociationColumn =
				Page.DataSource.CurrentStructure.Columns.FindByMetaPath(
					lpProcess.GetPropertyValue("DetailAssociationColumnUId").ToString());
			DataSourceStructureColumn detaiSelectionColumn =
				Page.DataSource.CurrentStructure.Columns.FindByMetaPath(
					lpProcess.GetPropertyValue("DetailSelectionColumnUId").ToString());
			if(parentAssociationColumnValue == Guid.Empty || detaiAssociationColumn == null ||
				detaiSelectionColumn == null) {
				return false;
			}
			
			var keysCollection = ((System.Collections.IDictionary)OpenLookupGridPage.GetSelectedValues(UserConnection)).Keys;
			foreach (string detaiAssociationColumnValue in keysCollection) {
				// Check if selected entity already exists
				EntitySchemaQuery esq = new EntitySchemaQuery(entitySchema);
				esq.AddColumn(entitySchema.GetPrimaryColumnName());
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
					detaiAssociationColumn.Name, parentAssociationColumnValue));
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
					detaiSelectionColumn.Name, detaiAssociationColumnValue));
				EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
				if(entityCollection.Count == 0) {
					// Create new entity and save to database
					Entity entity = entitySchema.CreateEntity(UserConnection);
					entity.PrimaryColumnValue = Guid.NewGuid();
					entity.SetColumnValue(detaiAssociationColumn.ValueColumnName, parentAssociationColumnValue);
					entity.SetColumnValue(detaiSelectionColumn.ValueColumnName, detaiAssociationColumnValue);
					entity.Save();
					Page.DataSource.LoadRow(entity.PrimaryColumnValue);
				}
			}
			
			return true;
		}

		public virtual bool InitOpenLookupGridPageExecute(ProcessExecutingContext context) {
			Process lpProcess = UserConnection.IProcessEngine.FindProcessByUId(ListenerPageProcessUId);
			if (lpProcess == null || Page.DataSource == null) {
				return false;
			}
			
			DataSourceStructureColumn detailSelectionColumn =
				Page.DataSource.CurrentStructure.Columns.FindByMetaPath(
					lpProcess.GetPropertyValue("DetailSelectionColumnUId").ToString());
			OpenLookupGridPage.PageParameters = new Dictionary <string, object>() {
				{ "schemaUId", detailSelectionColumn.ReferenceSchemaUId },
			};
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupGridPage.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			return true;
		}

		public virtual bool BaseManyToManyDetailGridPageInitScriptTaskExecute(ProcessExecutingContext context) {
			SubscribeDataSourcePrepareFiltersEvent();
			if(!Ext.IsAjaxRequest) {
				IsDetailGrid = true;
				InitializeDetailEditPageId();
			}
			return true;
		}

		public virtual bool BaseManyToManyDetailGridPageParentActiveRowChangedScriptTaskExecute(ProcessExecutingContext context) {
			if(String.IsNullOrEmpty(ListenerPageProcessUId) || Page.DataSource == null) {
				return false;
			}
			Page.TreeGrid.Clear();
			Page.DataSource.LoadRows();
			return true;
		}

		public virtual void SubscribeDataSourcePrepareFiltersEvent() {
			Page.DataSource.PrepareFilters += delegate(object sender, DataSourceEventArgs e) {
				Process lpProcess = UserConnection.IProcessEngine.FindProcessByUId(ListenerPageProcessUId);
				if (lpProcess == null || Page.DataSource == null) {
					return;
				}
				// Get association parameters from listener page
				Guid associationColumnUId = (Guid)lpProcess.GetPropertyValue("DetailAssociationColumnUId");
				Guid parentPrimaryColumnValue = (Guid)lpProcess.GetPropertyValue("ParentPrimaryColumnValue");
				SelectedNodePrimaryColumnValue = parentPrimaryColumnValue;
				if(associationColumnUId == Guid.Empty) {
					return;
				}
				var associationColumn = Page.DataSource.Schema.Columns.FindByUId(associationColumnUId);
				if(associationColumn == null) {
					return;
				}
				// Apply filter for datasource compliant column whith parent primary column value
				string filterName = "AssociationFilter";
				DataSourceFilter dsFilter = (DataSourceFilter)Page.DataSource.CurrentStructure.Filters.FindByName(filterName);
				if (dsFilter != null) {
					Page.DataSource.CurrentStructure.Filters.Remove(dsFilter);
				}
				dsFilter = Page.DataSource.CreateFilterWithParameters(
				FilterComparisonType.Equal, associationColumn.Name, parentPrimaryColumnValue);
					dsFilter.Name = filterName;
				Page.DataSource.CurrentStructure.Filters.Add(dsFilter);
			};
		}

		public virtual void InitializeDetailEditPageId() {
			if (EditPageUId == Guid.Empty) {
				Guid editPageSchemaId = Guid.Empty;
				EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysLookup");
				EntitySchemaQuery esq = new EntitySchemaQuery(entitySchema);
				var queryColumn = esq.AddColumn("SysEditPageSchemaUId");
				esq.Filters.Add(esq.CreateFilterWithParameters(
					FilterComparisonType.Equal, "SysEntitySchemaUId", EntitySchemaUId));
				EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
				if (entityCollection.Count > 0) {
					Entity lookupEntity = entityCollection[0];
					editPageSchemaId = lookupEntity.GetTypedColumnValue<Guid>(
						entitySchema.Columns.FindByName(queryColumn.Name).ColumnValueName);
				}
				EditPageUId = (editPageSchemaId == Guid.Empty ? GetDeafaultLookupEditSchemaId() : editPageSchemaId);
			}
		}

		public virtual Guid GetDeafaultLookupEditSchemaId() {
			var schemaUId = Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "DefLookupEditPageSchemaUId");
			return schemaUId == null ? Guid.Empty : (Guid)schemaUId;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			if (IsEntityDetail) {
				return base.GetRegisterEditPageScript(editPageUId, sysModuleEditId);
			} else {
				return string.Empty;
			}
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			if (IsEntityDetail) {
				return base.GetRegisterAddPageScript(editPageUId, sysModuleEditId, typeId);
			} else {
				Page.AddButton.AjaxEvents.Click.SignalName = "AddButtonClick";
				return string.Empty;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("BaseManyToManyDetailGridPageAddButtonClick")) {
							context.QueueTasks.Enqueue("BaseManyToManyDetailGridPageAddButtonClick");
							ProcessQueue(context);
							return;
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("LookupGridPageClosed")) {
						context.QueueTasks.Enqueue("LookupGridPageClosed");
					}
					break;
					case "Init":
							if (ActivatedEventElements.Contains("BaseManyToManyDetailGridPageInit")) {
							context.QueueTasks.Enqueue("BaseManyToManyDetailGridPageInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "ParentActiveRowChanged":
							if (ActivatedEventElements.Contains("BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage")) {
							context.QueueTasks.Enqueue("BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsEntityDetail") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEntityDetail", IsEntityDetail, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseManyToManyDetailGridPageEventsProcess

	/// <exclude/>
	public class BaseManyToManyDetailGridPageEventsProcess : BaseManyToManyDetailGridPageEventsProcess<Terrasoft.WebApp.BaseManyToManyDetailGridPageSchemaUserControl>
	{

		public BaseManyToManyDetailGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseManyToManyDetailGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseManyToManyDetailGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

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
			var process = (BaseManyToManyDetailGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseManyToManyDetailGridPageEventsProcess(UserConnection);
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
			SchemaName = "BaseManyToManyDetailGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseManyToManyDetailGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseManyToManyDetailGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseManyToManyDetailGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseManyToManyDetailGridPageEventsProcessSchema(BaseManyToManyDetailGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseManyToManyDetailGridPageEventsProcess";
			UId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048");
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

		protected virtual ProcessSchemaParameter CreateIsEntityDetailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("47bc2b2a-7262-48a5-abe7-4d3673cc08ed"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"IsEntityDetail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsEntityDetailParameter());
		}

		protected virtual void InitializeOpenLookupGridPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("70a39328-84d1-4f8f-8d09-7f742e9a6728"),
				ContainerUId = new Guid("4d66ce15-9db0-4c20-b940-6246efb8a800"),
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
				UId = new Guid("26cf9f6c-639d-426a-9822-b896321c8f2e"),
				ContainerUId = new Guid("4d66ce15-9db0-4c20-b940-6246efb8a800"),
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
				UId = new Guid("5770ffc5-906b-4c34-8b23-8e6e3a170008"),
				ContainerUId = new Guid("4d66ce15-9db0-4c20-b940-6246efb8a800"),
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
				UId = new Guid("b24f09bc-fdcf-46ff-9121-035560d83f23"),
				ContainerUId = new Guid("4d66ce15-9db0-4c20-b940-6246efb8a800"),
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
			ProcessSchemaLaneSet schemaLaneSet499 = CreateLaneSet499LaneSet();
			LaneSets.Add(schemaLaneSet499);
			ProcessSchemaLane schemaLane1652 = CreateLane1652Lane();
			schemaLaneSet499.Lanes.Add(schemaLane1652);
			ProcessSchemaEventSubProcess basemanytomanydetailgridpageaddbuttonclicksubprocess = CreateBaseManyToManyDetailGridPageAddButtonClickSubProcessEventSubProcess();
			FlowElements.Add(basemanytomanydetailgridpageaddbuttonclicksubprocess);
			ProcessSchemaEventSubProcess shadowingbaseeventssubprocess = CreateShadowingBaseEventsSubProcessEventSubProcess();
			FlowElements.Add(shadowingbaseeventssubprocess);
			ProcessSchemaEventSubProcess basemanytomanydetailgridpageparenteventhandlersubprocess = CreateBaseManyToManyDetailGridPageParentEventHandlerSubProcessEventSubProcess();
			FlowElements.Add(basemanytomanydetailgridpageparenteventhandlersubprocess);
			ProcessSchemaStartMessageEvent basemanytomanydetailgridpageaddbuttonclick = CreateBaseManyToManyDetailGridPageAddButtonClickStartMessageEvent();
			basemanytomanydetailgridpageaddbuttonclicksubprocess.FlowElements.Add(basemanytomanydetailgridpageaddbuttonclick);
			ProcessSchemaScriptTask basemanytomanydetailgridpageaddbuttonclickscripttask = CreateBaseManyToManyDetailGridPageAddButtonClickScriptTaskScriptTask();
			basemanytomanydetailgridpageaddbuttonclicksubprocess.FlowElements.Add(basemanytomanydetailgridpageaddbuttonclickscripttask);
			ProcessSchemaScriptTask initopenlookupgridpage = CreateInitOpenLookupGridPageScriptTask();
			basemanytomanydetailgridpageaddbuttonclicksubprocess.FlowElements.Add(initopenlookupgridpage);
			ProcessSchemaUserTask openlookupgridpage = CreateOpenLookupGridPageUserTask();
			basemanytomanydetailgridpageaddbuttonclicksubprocess.FlowElements.Add(openlookupgridpage);
			ProcessSchemaIntermediateCatchMessageEvent lookupgridpageclosed = CreateLookupGridPageClosedIntermediateCatchMessageEvent();
			basemanytomanydetailgridpageaddbuttonclicksubprocess.FlowElements.Add(lookupgridpageclosed);
			ProcessSchemaStartMessageEvent basemanytomanydetailgridpageinit = CreateBaseManyToManyDetailGridPageInitStartMessageEvent();
			shadowingbaseeventssubprocess.FlowElements.Add(basemanytomanydetailgridpageinit);
			ProcessSchemaScriptTask basemanytomanydetailgridpageinitscripttask = CreateBaseManyToManyDetailGridPageInitScriptTaskScriptTask();
			shadowingbaseeventssubprocess.FlowElements.Add(basemanytomanydetailgridpageinitscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			shadowingbaseeventssubprocess.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent basemanytomanydetailgridpagparentactiverowchangedstartmessage = CreateBaseManyToManyDetailGridPagParentActiveRowChangedStartMessageStartMessageEvent();
			basemanytomanydetailgridpageparenteventhandlersubprocess.FlowElements.Add(basemanytomanydetailgridpagparentactiverowchangedstartmessage);
			ProcessSchemaScriptTask basemanytomanydetailgridpageparentactiverowchangedscripttask = CreateBaseManyToManyDetailGridPageParentActiveRowChangedScriptTaskScriptTask();
			basemanytomanydetailgridpageparenteventhandlersubprocess.FlowElements.Add(basemanytomanydetailgridpageparentactiverowchangedscripttask);
			FlowElements.Add(CreateSequenceFlow9817SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9818SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9819SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9820SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9821SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9822SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9825SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9817SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9817",
				UId = new Guid("5f682574-3f10-49e7-b282-5540a6110a21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CurveCenterPosition = new Point(121, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("803ffccb-1e74-48e3-962f-f997c4db8e4a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ec74923c-26bc-4d83-a7d7-b0bb1a5943c5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9818SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9818",
				UId = new Guid("844f8bb6-c5f7-4242-a9a8-e0a64947f5b4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CurveCenterPosition = new Point(121, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4916974-6c7c-4c5b-8f24-fdf49bd18e75"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0cec1cf5-0662-4cea-8802-1ba626160a83"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9819SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9819",
				UId = new Guid("8a36000a-652d-4995-898a-df01b51feaca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CurveCenterPosition = new Point(121, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0cec1cf5-0662-4cea-8802-1ba626160a83"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4d66ce15-9db0-4c20-b940-6246efb8a800"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9820SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9820",
				UId = new Guid("4da471d9-1e28-45bd-a0d4-85ea21464946"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CurveCenterPosition = new Point(121, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4d66ce15-9db0-4c20-b940-6246efb8a800"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("803ffccb-1e74-48e3-962f-f997c4db8e4a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9821SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9821",
				UId = new Guid("37461e5f-9125-4935-95cb-2137dcc71945"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CurveCenterPosition = new Point(151, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("95904da4-a608-44f7-af48-9e2fe81fb567"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3d1a1f1-a7f5-43a0-8c72-503d4c161550"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9822SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9822",
				UId = new Guid("93d02c5c-d1be-45eb-8c84-ca26cafc3fea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CurveCenterPosition = new Point(155, 449),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f29aa92-6f86-47a9-9db7-9265ef3a0f6c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4f83ac1-b431-4211-a9c2-a1de7e232678"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9825SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9825",
				UId = new Guid("9644a270-e7b0-46a0-a51e-3837f1d94f26"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CurveCenterPosition = new Point(151, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("250deb9d-a7ff-49fc-9e61-a7d45253da3b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("95904da4-a608-44f7-af48-9e2fe81fb567"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet499LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet499 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f9e3973c-fd73-4d04-b814-d3914652d4df"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"LaneSet499",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(863, 506),
				UseBackgroundMode = false
			};
			return schemaLaneSet499;
		}

		protected virtual ProcessSchemaLane CreateLane1652Lane() {
			ProcessSchemaLane schemaLane1652 = new ProcessSchemaLane(this) {
				UId = new Guid("53c7ca6f-9d07-40c6-a045-7f0923133499"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("f9e3973c-fd73-4d04-b814-d3914652d4df"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"Lane1652",
				Position = new Point(29, 0),
				Size = new Size(834, 506),
				UseBackgroundMode = false
			};
			return schemaLane1652;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseManyToManyDetailGridPageAddButtonClickSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseManyToManyDetailGridPageAddButtonClickSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("11a0e195-139b-4f5e-83b9-b28ade464c76"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53c7ca6f-9d07-40c6-a045-7f0923133499"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"BaseManyToManyDetailGridPageAddButtonClickSubProcess",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(653, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseManyToManyDetailGridPageAddButtonClickSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseManyToManyDetailGridPageAddButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d4916974-6c7c-4c5b-8f24-fdf49bd18e75"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a0e195-139b-4f5e-83b9-b28ade464c76"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"BaseManyToManyDetailGridPageAddButtonClick",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseManyToManyDetailGridPageAddButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ec74923c-26bc-4d83-a7d7-b0bb1a5943c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a0e195-139b-4f5e-83b9-b28ade464c76"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"BaseManyToManyDetailGridPageAddButtonClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(546, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,77,83,219,48,16,61,219,191,98,39,39,121,134,17,189,103,124,128,16,24,166,148,166,13,180,103,213,222,16,13,182,100,36,25,234,41,252,247,174,36,7,140,243,193,169,61,197,209,62,237,190,221,247,86,11,163,11,180,22,170,102,209,127,229,112,107,209,204,180,82,88,56,169,21,191,236,35,115,117,39,21,242,115,169,202,254,228,180,187,189,44,217,149,180,14,21,154,133,184,195,62,64,199,217,52,149,43,96,131,188,57,168,182,170,224,249,25,60,146,159,9,39,150,186,53,5,110,66,25,252,73,19,131,174,53,10,86,162,178,56,77,95,210,116,174,156,116,221,178,88,99,45,0,135,127,242,113,34,30,3,211,244,162,149,37,52,194,16,252,196,90,93,72,225,59,153,233,170,173,213,15,81,181,84,18,152,7,101,175,252,248,5,58,250,108,208,184,46,64,88,154,76,22,33,197,194,200,90,152,110,112,125,66,221,189,149,93,58,211,22,196,26,35,2,74,116,66,110,213,133,60,77,198,124,103,173,241,5,94,19,240,8,181,97,200,167,221,23,74,180,16,110,77,84,146,3,68,39,103,190,96,181,85,145,84,152,100,252,70,83,122,169,238,88,246,49,233,37,86,81,244,255,68,121,84,111,7,97,185,98,135,117,204,193,235,200,231,117,227,58,239,173,125,195,127,117,95,154,236,110,245,144,7,31,133,129,123,236,44,97,251,91,222,64,108,217,145,243,107,254,118,106,249,229,153,12,95,228,151,236,107,131,234,74,235,251,182,185,48,178,12,131,164,65,196,194,88,6,254,150,189,95,182,44,227,159,169,206,52,93,105,131,162,88,3,179,97,22,123,218,138,51,144,106,68,46,52,113,124,12,179,53,22,247,64,107,104,251,154,253,254,128,168,40,123,217,1,254,166,221,181,105,50,220,177,111,45,26,138,216,7,106,81,225,19,108,197,216,112,9,73,162,132,176,252,164,44,35,165,119,209,40,252,96,123,174,69,141,65,215,112,233,92,86,14,141,245,151,153,255,63,35,86,14,227,233,79,233,214,180,126,132,247,16,22,15,103,186,38,55,72,171,213,77,215,32,159,63,180,162,58,34,167,237,158,14,247,213,142,14,190,3,255,136,202,200,92,61,145,3,26,6,30,113,210,3,143,225,248,32,247,186,248,161,142,161,99,27,81,54,218,156,241,125,114,106,171,156,183,250,167,96,145,224,145,208,104,80,122,99,14,85,130,21,143,8,78,67,73,139,255,75,88,36,108,44,185,1,229,239,158,226,126,92,17,178,131,75,18,193,124,251,37,133,126,127,175,241,201,255,178,33,122,137,110,128,100,123,68,14,193,55,119,125,160,247,7,233,199,194,109,37,63,164,225,48,55,205,47,246,50,126,63,175,180,40,191,235,39,182,119,34,254,214,139,127,116,250,87,136,30,90,156,254,5,209,197,182,67,167,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateInitOpenLookupGridPageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0cec1cf5-0662-4cea-8802-1ba626160a83"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a0e195-139b-4f5e-83b9-b28ade464c76"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"InitOpenLookupGridPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,219,78,2,49,16,125,134,132,127,152,240,180,27,73,127,0,49,17,86,201,70,140,68,64,159,203,50,64,181,180,235,180,141,217,0,255,238,236,5,36,6,223,186,115,57,183,217,41,217,12,157,3,157,79,155,215,0,22,14,105,100,141,193,204,43,107,68,218,116,30,204,70,25,20,143,202,172,154,202,176,88,164,171,104,162,156,71,131,52,149,27,108,26,92,142,251,157,182,90,67,116,1,60,0,19,180,134,195,1,202,81,145,72,47,103,54,80,134,167,86,12,251,78,187,69,232,3,25,88,75,237,144,65,142,157,118,167,253,59,59,243,20,50,30,192,145,213,97,103,96,133,94,42,61,67,93,171,109,170,3,198,249,67,34,70,129,8,141,63,3,136,122,214,85,142,134,197,51,3,77,165,223,70,188,218,58,171,22,99,244,252,204,145,124,241,38,117,192,168,155,92,99,100,199,221,88,204,45,163,43,179,137,226,210,254,75,142,102,98,237,103,200,199,164,86,149,156,42,35,73,114,135,30,169,204,218,224,55,36,170,2,146,84,192,173,171,246,123,96,151,31,12,127,23,213,145,236,161,235,178,45,238,100,73,211,187,238,89,188,226,26,217,32,71,116,26,133,99,143,243,99,37,53,42,40,227,188,228,1,238,12,32,138,230,72,36,157,93,123,177,72,197,59,46,249,230,158,172,118,149,202,184,210,123,239,242,234,67,164,231,213,11,147,255,120,172,147,123,194,130,89,46,40,111,224,28,65,201,36,249,103,34,177,48,234,43,96,154,48,84,115,119,62,15,246,127,0,126,33,71,100,151,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupGridPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4d66ce15-9db0-4c20-b940-6246efb8a800"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a0e195-139b-4f5e-83b9-b28ade464c76"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"OpenLookupGridPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 42),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupGridPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateLookupGridPageClosedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("803ffccb-1e74-48e3-962f-f997c4db8e4a"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a0e195-139b-4f5e-83b9-b28ade464c76"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"BoundaryEvent",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"LookupGridPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(427, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateShadowingBaseEventsSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaShadowingBaseEventsSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d819b817-4cf7-4280-a328-c5acdad1cfff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53c7ca6f-9d07-40c6-a045-7f0923133499"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"ShadowingBaseEventsSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 163),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(344, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaShadowingBaseEventsSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseManyToManyDetailGridPageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("250deb9d-a7ff-49fc-9e61-a7d45253da3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d819b817-4cf7-4280-a328-c5acdad1cfff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"BaseManyToManyDetailGridPageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseManyToManyDetailGridPageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d3d1a1f1-a7f5-43a0-8c72-503d4c161550"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d819b817-4cf7-4280-a328-c5acdad1cfff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"BaseManyToManyDetailGridPageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(238, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,140,193,14,130,48,16,5,207,246,43,234,13,46,254,0,241,96,66,53,189,17,249,130,133,62,205,154,166,202,118,107,136,134,127,71,195,117,102,50,125,25,242,40,60,160,37,165,254,89,100,68,39,120,145,224,204,81,33,217,189,145,180,170,27,195,183,106,239,102,61,248,124,122,208,124,197,84,144,181,182,95,179,243,185,133,18,199,139,112,176,71,171,82,208,252,104,98,101,138,252,193,102,93,96,237,232,14,31,254,183,197,8,180,72,218,234,21,148,5,19,179,134,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("95904da4-a608-44f7-af48-9e2fe81fb567"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d819b817-4cf7-4280-a328-c5acdad1cfff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBaseManyToManyDetailGridPageParentEventHandlerSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBaseManyToManyDetailGridPageParentEventHandlerSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("521229ba-99a7-4c3f-a130-45b8a95dd9c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53c7ca6f-9d07-40c6-a045-7f0923133499"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"BaseManyToManyDetailGridPageParentEventHandlerSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 329),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(309, 163),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBaseManyToManyDetailGridPageParentEventHandlerSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseManyToManyDetailGridPagParentActiveRowChangedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4f29aa92-6f86-47a9-9db7-9265ef3a0f6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("521229ba-99a7-4c3f-a130-45b8a95dd9c5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ParentActiveRowChanged",
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"BaseManyToManyDetailGridPagParentActiveRowChangedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseManyToManyDetailGridPageParentActiveRowChangedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b4f83ac1-b431-4211-a9c2-a1de7e232678"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("521229ba-99a7-4c3f-a130-45b8a95dd9c5"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				Name = @"BaseManyToManyDetailGridPageParentActiveRowChangedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,140,65,10,194,48,16,69,215,230,20,179,76,54,185,64,233,74,69,10,69,139,213,3,12,205,180,4,98,82,38,19,68,172,119,215,138,43,183,239,191,255,252,168,123,97,31,39,219,228,99,9,225,196,251,219,44,15,221,250,44,20,137,59,156,168,227,52,80,206,215,198,25,88,22,88,145,221,161,96,159,10,15,4,117,13,241,243,52,240,84,27,38,41,28,97,196,144,169,82,47,245,117,47,76,116,96,239,236,54,16,178,54,149,250,75,216,54,161,59,167,123,94,183,95,66,184,80,245,6,128,103,176,202,158,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSubscribeDataSourcePrepareFiltersEventMethod());
			Methods.Add(CreateInitializeDetailEditPageIdMethod());
			Methods.Add(CreateGetDeafaultLookupEditSchemaIdMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e166c122-42fa-4f50-991f-89f6d5e40e3c"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
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

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,44,118,205,43,201,44,169,116,73,45,73,204,204,209,84,168,230,229,226,44,74,45,41,45,202,83,72,74,44,78,213,115,79,45,9,74,77,207,44,46,73,45,114,77,201,44,9,72,76,79,13,78,46,202,44,40,209,72,133,114,67,61,83,116,20,138,43,139,125,243,83,74,115,82,65,138,60,83,52,173,121,185,106,21,82,115,138,83,145,13,44,46,41,202,204,75,215,115,205,45,40,169,4,41,0,0,27,204,239,221,128,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,142,65,10,194,48,16,69,215,246,20,161,171,22,36,23,40,46,170,6,233,66,17,139,7,136,205,24,70,211,180,100,166,98,16,239,110,227,162,203,255,255,227,241,241,46,138,134,148,103,228,184,7,214,232,74,241,201,86,1,120,10,94,220,52,129,60,0,95,192,34,49,132,218,152,179,182,208,118,1,71,46,192,32,167,120,109,204,90,80,164,227,96,38,7,106,110,83,193,113,132,198,148,85,246,21,224,8,146,53,193,114,118,108,39,230,193,203,250,161,223,234,5,158,73,238,28,118,79,217,162,245,218,157,116,15,98,35,242,5,252,143,121,181,188,34,14,232,173,84,253,200,113,214,255,0,77,63,40,24,195,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSubscribeDataSourcePrepareFiltersEventMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d74d2119-2eb7-4400-af4f-810b9c8cff40"),
				Name = "SubscribeDataSourcePrepareFiltersEvent",
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,203,110,219,48,16,60,75,95,177,245,73,66,13,230,3,2,31,92,199,9,2,20,129,80,55,237,153,21,215,50,11,138,84,73,202,133,208,228,223,187,164,100,89,245,163,240,141,224,104,103,103,102,151,42,120,133,236,129,123,190,49,173,45,145,21,22,27,110,241,81,42,143,214,193,199,5,8,84,88,113,143,153,249,241,19,75,15,14,181,64,59,135,99,209,122,143,218,47,109,229,0,115,248,147,38,133,53,37,58,7,170,57,156,22,240,234,208,174,140,214,196,32,141,102,207,3,178,214,149,212,200,30,165,22,195,205,167,238,245,89,100,159,165,243,168,209,22,36,111,0,232,58,191,79,19,185,133,108,66,188,0,221,42,5,111,111,80,252,235,228,0,69,69,137,69,223,90,77,229,239,105,114,119,7,79,232,129,59,103,74,201,131,28,32,203,188,198,232,120,107,77,13,106,104,79,64,133,105,242,212,74,49,253,126,101,84,91,107,18,68,198,178,0,230,163,34,70,212,116,108,208,250,238,27,87,45,102,179,7,244,92,170,229,133,242,89,48,20,201,67,230,154,10,101,205,109,215,227,177,250,166,6,197,149,226,72,191,161,241,149,30,197,139,17,120,145,255,90,235,152,117,118,217,245,2,130,40,182,174,27,223,157,7,188,231,246,60,45,234,116,50,33,182,41,119,88,115,214,227,46,46,65,63,253,75,77,243,43,122,254,59,231,101,211,168,14,182,113,153,97,107,44,8,234,238,250,253,40,77,221,40,201,181,167,83,36,250,189,147,126,55,196,1,77,159,199,1,219,135,68,210,196,121,43,117,53,16,190,208,202,144,171,217,100,178,253,179,153,81,255,163,205,254,14,132,27,14,52,209,83,48,63,77,102,213,218,160,98,227,109,91,146,161,240,64,226,123,28,50,10,157,179,163,136,195,179,24,91,124,152,70,114,51,247,23,172,205,30,71,150,188,79,113,162,251,140,201,34,253,23,122,248,59,101,87,140,175,40,75,147,254,122,69,33,115,43,157,209,95,187,6,217,250,87,203,213,252,124,57,88,176,49,191,186,138,65,202,40,132,13,185,31,253,19,122,179,201,165,16,83,135,239,247,127,1,74,201,84,158,1,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeDetailEditPageIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fde1284a-b7c4-4953-8a3b-3cf8843bfa93"),
				Name = "InitializeDetailEditPageId",
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,193,78,195,48,12,61,23,137,127,176,118,106,165,41,218,25,40,8,74,153,38,1,26,26,131,3,226,16,173,30,139,104,147,46,77,64,21,218,191,19,55,69,202,90,142,182,159,253,158,159,45,182,16,231,133,48,75,254,129,235,69,1,105,10,115,43,10,150,87,181,105,19,248,57,61,137,40,6,236,49,171,205,14,43,78,192,0,119,238,80,185,52,194,180,190,12,24,6,41,172,27,212,153,146,18,55,70,40,201,66,232,3,151,110,170,102,115,52,11,217,24,46,55,120,211,62,242,10,227,201,170,109,238,149,250,180,245,36,25,18,60,89,212,45,96,179,119,195,37,126,195,168,22,135,10,186,246,47,174,97,79,165,76,149,182,146,174,209,181,179,235,162,240,113,71,151,31,45,233,236,240,204,4,188,19,165,65,221,80,67,76,113,166,145,27,244,217,87,97,118,75,174,157,104,130,196,174,35,242,133,76,85,53,215,162,81,242,185,173,145,229,123,203,203,41,116,76,129,60,226,153,194,32,147,4,59,59,133,165,183,174,55,54,72,248,53,156,123,67,104,124,108,122,55,78,184,99,15,39,176,76,89,105,224,18,102,254,218,61,39,148,157,245,125,144,142,136,223,102,239,52,49,250,231,47,194,78,82,70,187,247,46,191,240,210,226,5,61,206,101,103,83,20,158,137,121,76,227,188,150,69,255,4,193,197,24,37,18,22,12,234,18,164,226,64,86,133,79,236,214,28,233,10,31,22,174,192,9,187,69,190,229,182,52,254,203,104,192,31,58,78,224,108,244,242,68,117,248,5,127,242,126,40,48,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDeafaultLookupEditSchemaIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d60fadd5-9d6b-4641-9a1f-19fe3980f4e1"),
				Name = "GetDeafaultLookupEditSchemaId",
				CreatedInSchemaUId = new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,205,193,10,194,48,16,4,208,187,95,177,244,212,130,228,3,44,197,131,150,34,120,16,98,189,135,102,83,131,233,166,108,54,66,255,222,246,160,120,25,24,120,204,188,13,67,26,158,56,153,254,98,161,129,59,50,155,20,157,168,83,100,92,131,156,31,51,27,241,145,148,94,146,70,17,79,99,82,29,202,195,132,140,101,159,144,87,70,56,108,102,15,197,25,221,53,198,87,158,91,235,229,102,70,212,223,253,162,170,119,140,146,153,254,63,27,160,28,2,28,161,203,222,170,118,154,101,129,3,148,91,171,126,172,254,0,98,9,57,203,169,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseManyToManyDetailGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06680ab0-0ac9-4b5e-8819-1701fda3f048"));
		}

		#endregion

	}

	#endregion

}

