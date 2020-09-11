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
	using TSWebControls = Terrasoft.UI.WebControls;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: BaseSortByPositionGridPageSchema

	/// <exclude/>
	public class BaseSortByPositionGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _upPositionButton;
		public Terrasoft.UI.WebControls.Controls.Button UpPositionButton {
			get {
				return _upPositionButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _downPositionButton;
		public Terrasoft.UI.WebControls.Controls.Button DownPositionButton {
			get {
				return _downPositionButton;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseSortByPositionGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseSortByPositionGridPageSchema(BaseSortByPositionGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.Hidden = false;
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.FooterVisible = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
			RealUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
			Name = "BaseSortByPositionGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseSortByPositionGridPageEventsProcessSchema();
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
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.InsertItem(5, CreateUpPositionButton());
			ButtonsControlLayout.InsertItem(6, CreateDownPositionButton());
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			ButtonsControlLayout.MoveItem(9, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseSortByPositionGridPageEventsProcessSchema() {
			var schema = new BaseSortByPositionGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpPositionButton() {
			_upPositionButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upPositionButton.UId = new Guid("aa7d48f7-8da7-4e4f-9501-7b62d558ee2e");
			_upPositionButton.Name = "UpPositionButton";
			_upPositionButton.CreatedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
			_upPositionButton.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
			_upPositionButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_upPositionButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upPositionButton.Tag = "";
			_upPositionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb"),
				ImageHash = @"28e5147b7e6173c2fb14e6bacd7517ab"
			};
			return _upPositionButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownPositionButton() {
			_downPositionButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downPositionButton.UId = new Guid("bfeb1961-507e-4c08-8623-01fbda9a7e4d");
			_downPositionButton.Name = "DownPositionButton";
			_downPositionButton.CreatedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
			_downPositionButton.ModifiedInSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
			_downPositionButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_downPositionButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downPositionButton.Tag = "";
			_downPositionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb"),
				ImageHash = @"2b3c485798ac9920a70b8fe868d08161"
			};
			return _downPositionButton;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseSortByPositionGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseSortByPositionGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseSortByPositionGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseSortByPositionGridPageEventsProcess

	/// <exclude/>
	public class BaseSortByPositionGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseSortByPositionGridPageSchemaUserControl
	{

		public BaseSortByPositionGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseSortByPositionGridPageEventsProcess";
			SchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb");
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

		public virtual int DataSourceRowsCount {
			get;
			set;
		}

		public virtual Guid MovedPrimaryColumnValue {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("3f19b22c-4e3d-455b-bd78-a4985513e9a4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startUpPositionButtonClick;
		public ProcessFlowElement StartUpPositionButtonClick {
			get {
				return _startUpPositionButtonClick ?? (_startUpPositionButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartUpPositionButtonClick",
					SchemaElementUId = new Guid("0b2752c0-f443-4876-8fee-16116c7e00df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptUpPositionButtonClick;
		public ProcessScriptTask ScriptUpPositionButtonClick {
			get {
				return _scriptUpPositionButtonClick ?? (_scriptUpPositionButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptUpPositionButtonClick",
					SchemaElementUId = new Guid("fb3d562f-979e-4902-b0b9-4fce8bfa3bbe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptUpPositionButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadRowsResponseRegisteredChildEventSubProcess;
		public ProcessFlowElement DataSourceLoadRowsResponseRegisteredChildEventSubProcess {
			get {
				return _dataSourceLoadRowsResponseRegisteredChildEventSubProcess ?? (_dataSourceLoadRowsResponseRegisteredChildEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DataSourceLoadRowsResponseRegisteredChildEventSubProcess",
					SchemaElementUId = new Guid("ab157433-bb27-4c4b-a959-67eb00f99169"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoadRowsResponseRegisteredChildStartMessage;
		public ProcessFlowElement DataSourceLoadRowsResponseRegisteredChildStartMessage {
			get {
				return _dataSourceLoadRowsResponseRegisteredChildStartMessage ?? (_dataSourceLoadRowsResponseRegisteredChildStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoadRowsResponseRegisteredChildStartMessage",
					SchemaElementUId = new Guid("9061588e-ff40-469e-bb03-a1799fbaaa27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dataSourceLoadRowsResponseRegisteredChildScriptTask;
		public ProcessScriptTask DataSourceLoadRowsResponseRegisteredChildScriptTask {
			get {
				return _dataSourceLoadRowsResponseRegisteredChildScriptTask ?? (_dataSourceLoadRowsResponseRegisteredChildScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DataSourceLoadRowsResponseRegisteredChildScriptTask",
					SchemaElementUId = new Guid("cde70205-d5c6-411d-acc4-3fc9ca1422e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DataSourceLoadRowsResponseRegisteredChildScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess22;
		public ProcessFlowElement EventSubProcess22 {
			get {
				return _eventSubProcess22 ?? (_eventSubProcess22 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess22",
					SchemaElementUId = new Guid("f225c1ea-953d-40d8-b55e-ce33fd2a1b19"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startDownPositionButtonClick;
		public ProcessFlowElement StartDownPositionButtonClick {
			get {
				return _startDownPositionButtonClick ?? (_startDownPositionButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartDownPositionButtonClick",
					SchemaElementUId = new Guid("a79ac548-a428-4e4c-9712-0b3ebd25e7d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDownPositionButtonClick;
		public ProcessScriptTask ScriptDownPositionButtonClick {
			get {
				return _scriptDownPositionButtonClick ?? (_scriptDownPositionButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDownPositionButtonClick",
					SchemaElementUId = new Guid("8b5e5139-b231-4f3d-9237-0a694cffc227"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDownPositionButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _posEventSubProcess1;
		public ProcessFlowElement PosEventSubProcess1 {
			get {
				return _posEventSubProcess1 ?? (_posEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PosEventSubProcess1",
					SchemaElementUId = new Guid("e6616382-4093-4660-88b4-61240353f9df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _posStartMessage2;
		public ProcessFlowElement PosStartMessage2 {
			get {
				return _posStartMessage2 ?? (_posStartMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PosStartMessage2",
					SchemaElementUId = new Guid("506409fe-5ef8-46a3-8534-8159f5125ea7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _posIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent PosIntermediateThrowMessageEvent1 {
			get {
				return _posIntermediateThrowMessageEvent1 ?? (_posIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PosIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("44d8724c-1198-4554-ac39-e69ac0c75920"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteYesMessage",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _normalizePositionsScriptTask;
		public ProcessScriptTask NormalizePositionsScriptTask {
			get {
				return _normalizePositionsScriptTask ?? (_normalizePositionsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NormalizePositionsScriptTask",
					SchemaElementUId = new Guid("1a938515-626e-4cb1-bcdc-a1f47affc791"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NormalizePositionsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartUpPositionButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartUpPositionButtonClick };
			FlowElements[ScriptUpPositionButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptUpPositionButtonClick };
			FlowElements[DataSourceLoadRowsResponseRegisteredChildEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadRowsResponseRegisteredChildEventSubProcess };
			FlowElements[DataSourceLoadRowsResponseRegisteredChildStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadRowsResponseRegisteredChildStartMessage };
			FlowElements[DataSourceLoadRowsResponseRegisteredChildScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoadRowsResponseRegisteredChildScriptTask };
			FlowElements[EventSubProcess22.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess22 };
			FlowElements[StartDownPositionButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDownPositionButtonClick };
			FlowElements[ScriptDownPositionButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDownPositionButtonClick };
			FlowElements[PosEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { PosEventSubProcess1 };
			FlowElements[PosStartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { PosStartMessage2 };
			FlowElements[PosIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { PosIntermediateThrowMessageEvent1 };
			FlowElements[NormalizePositionsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NormalizePositionsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess8":
						break;
					case "StartUpPositionButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptUpPositionButtonClick");
						break;
					case "ScriptUpPositionButtonClick":
						break;
					case "DataSourceLoadRowsResponseRegisteredChildEventSubProcess":
						break;
					case "DataSourceLoadRowsResponseRegisteredChildStartMessage":
						e.Context.QueueTasks.Enqueue("DataSourceLoadRowsResponseRegisteredChildScriptTask");
						break;
					case "DataSourceLoadRowsResponseRegisteredChildScriptTask":
						break;
					case "EventSubProcess22":
						break;
					case "StartDownPositionButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptDownPositionButtonClick");
						break;
					case "ScriptDownPositionButtonClick":
						break;
					case "PosEventSubProcess1":
						break;
					case "PosStartMessage2":
						e.Context.QueueTasks.Enqueue("PosIntermediateThrowMessageEvent1");
						break;
					case "PosIntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("NormalizePositionsScriptTask");
						break;
					case "NormalizePositionsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartUpPositionButtonClick");
			ActivatedEventElements.Add("DataSourceLoadRowsResponseRegisteredChildStartMessage");
			ActivatedEventElements.Add("StartDownPositionButtonClick");
			ActivatedEventElements.Add("PosStartMessage2");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartUpPositionButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartUpPositionButtonClick";
					result = StartUpPositionButtonClick.Execute(context);
					break;
				case "ScriptUpPositionButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptUpPositionButtonClick";
					result = ScriptUpPositionButtonClick.Execute(context, ScriptUpPositionButtonClickExecute);
					break;
				case "DataSourceLoadRowsResponseRegisteredChildEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoadRowsResponseRegisteredChildStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadRowsResponseRegisteredChildStartMessage";
					result = DataSourceLoadRowsResponseRegisteredChildStartMessage.Execute(context);
					break;
				case "DataSourceLoadRowsResponseRegisteredChildScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoadRowsResponseRegisteredChildScriptTask";
					result = DataSourceLoadRowsResponseRegisteredChildScriptTask.Execute(context, DataSourceLoadRowsResponseRegisteredChildScriptTaskExecute);
					break;
				case "EventSubProcess22":
					context.QueueTasks.Dequeue();
					break;
				case "StartDownPositionButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDownPositionButtonClick";
					result = StartDownPositionButtonClick.Execute(context);
					break;
				case "ScriptDownPositionButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDownPositionButtonClick";
					result = ScriptDownPositionButtonClick.Execute(context, ScriptDownPositionButtonClickExecute);
					break;
				case "PosEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "PosStartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "PosStartMessage2";
					result = PosStartMessage2.Execute(context);
					break;
				case "PosIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DeleteYesMessage");
					result = PosIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "NormalizePositionsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "NormalizePositionsScriptTask";
					result = NormalizePositionsScriptTask.Execute(context, NormalizePositionsScriptTaskExecute);
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
				case "MovedPrimaryColumnValue":
					MovedPrimaryColumnValue = reader.GetValue<System.Guid>();
				break;
				case "DataSourceRowsCount":
					DataSourceRowsCount = reader.GetValue<System.Int32>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptUpPositionButtonClickExecute(ProcessExecutingContext context) {
			MoveItem(-1);
			return true;
		}

		public virtual bool DataSourceLoadRowsResponseRegisteredChildScriptTaskExecute(ProcessExecutingContext context) {
			DataSourceRowsCount = Page.DataSource.Rows.Count;
			Page.DataSource.SelectedItemPrimaryColumnValues.Clear();
			if (MovedPrimaryColumnValue != Guid.Empty) {
				Page.DataSource.SetClientActiveRow(MovedPrimaryColumnValue);
				Page.DataSource.SelectedItemPrimaryColumnValues.Add(MovedPrimaryColumnValue);
				MovedPrimaryColumnValue = Guid.Empty;
			} else {
				var activeRowUId = Guid.Empty;
				if (DataSourceRowsCount > 0) {
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
				ActivateButtons(DataSourceRowsCount > 0);
			}
			
			return true;
		}

		public virtual bool ScriptDownPositionButtonClickExecute(ProcessExecutingContext context) {
			MoveItem(1);
			return true;
		}

		public virtual bool NormalizePositionsScriptTaskExecute(ProcessExecutingContext context) {
			NormalizePositions();
			return true;
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = base.GetButtons();
			buttons.Add(Page.UpPositionButton.Name);
			buttons.Add(Page.DownPositionButton.Name);
			return buttons;
		}

		public virtual void MoveItem(int incrementPosition) {
			var dataSource = Page.DataSource;
			var schema = Page.DataSource.Schema;
			var firstEntityUId = dataSource.ActiveRowPrimaryColumnValue;
			var secondEntityUId = Guid.Empty;
			var query = new EntitySchemaQuery(schema);
			var primaryColumnName = query.AddColumn(schema.GetPrimaryColumnName()).Name;
			var positionColumnName = query.AddColumn("Position").Name;
			var dataSourceFilters = dataSource.CurrentStructure.Filters.ToEntitySchemaQueryFilterCollection(query);
			query.Filters.Add(dataSourceFilters);
			var entity = query.GetEntity(UserConnection, firstEntityUId);
			if (entity == null) {
				return;
			}
			var firstPosition = entity.GetTypedColumnValue<int>(positionColumnName);
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var dataSourceRowCountQuery = new EntitySchemaQuery(schema);
			dataSourceRowCountQuery.AddColumn(schema.GetPrimaryColumnName());
			dataSourceRowCountQuery.Filters.Add(dataSourceFilters);
			var entities = dataSourceRowCountQuery.GetEntityCollection(UserConnection);
			DataSourceRowsCount = entities.Count;
			if ((firstPosition + incrementPosition) < 0 || (firstPosition + incrementPosition) > DataSourceRowsCount) {
				return;
			}
			query.Filters.Clear();
			query.ResetSelectQuery();
			query.Filters.Add(dataSourceFilters);
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"Position", firstPosition + incrementPosition));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.NotEqual, 
				schema.GetPrimaryColumnName(), firstEntityUId));
			entities = query.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				secondEntityUId = entities[0].GetTypedColumnValue<Guid>(primaryColumnName);
			}
			var firstEntity = schema.CreateEntity(UserConnection);
			if (firstEntity.FetchFromDB(firstEntityUId)) {
				firstEntity.SetColumnValue("Position", firstPosition + incrementPosition);
				firstEntity.Save();
				MovedPrimaryColumnValue = firstEntityUId;
			}
			var secondEntity = schema.CreateEntity(UserConnection);
			if (secondEntity.FetchFromDB(secondEntityUId)) {
				secondEntity.SetColumnValue("Position", firstPosition);
				secondEntity.Save();
			}
			Page.TreeGrid.Clear();
			dataSource.LoadRows();
		}

		public virtual void NormalizePositions() {
			var sysAdminOperationGranteeSchemaQuery = new EntitySchemaQuery(Page.DataSource.Schema);
			var primarySchemaColumnName = Page.DataSource.Schema.GetPrimaryColumnName();
			var entitySchemaQuery = new EntitySchemaQuery(Page.DataSource.Schema);
			var primaryQueryColumnName = entitySchemaQuery.AddColumn(primarySchemaColumnName).Name;
			entitySchemaQuery.AddColumn("Position").OrderByAsc();
			var dataSourceFilters = Page.DataSource.CurrentStructure.Filters.ToEntitySchemaQueryFilterCollection(entitySchemaQuery);
			entitySchemaQuery.Filters.Add(dataSourceFilters);
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			
			var positionParam = new QueryParameter("P1", 0);
			var entityIdParam = new QueryParameter("P2", Guid.Empty);
			var update = new Update(UserConnection, Page.DataSource.Schema.Name)
				.Set("Position", positionParam)
				.Where(primarySchemaColumnName).IsEqual(entityIdParam) as Update; 	
			
			for (var i = 0; i < entities.Count; i++) {
				if (entities[i].GetTypedColumnValue<int>("Position") != i) {
					entityIdParam.Value = entities[i].GetTypedColumnValue<Guid>(primaryQueryColumnName);
					positionParam.Value = i;
					update.Execute();		
				}
			}
			
			Page.TreeGrid.Clear();
			Page.DataSource.LoadRows();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "UpPositionButtonClick":
							if (ActivatedEventElements.Contains("StartUpPositionButtonClick")) {
							context.QueueTasks.Enqueue("StartUpPositionButtonClick");
						}
						break;
					case "DataSourceLoadRowsResponseRegistered":
							if (ActivatedEventElements.Contains("DataSourceLoadRowsResponseRegisteredChildStartMessage")) {
							context.QueueTasks.Enqueue("DataSourceLoadRowsResponseRegisteredChildStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "DownPositionButtonClick":
							if (ActivatedEventElements.Contains("StartDownPositionButtonClick")) {
							context.QueueTasks.Enqueue("StartDownPositionButtonClick");
						}
						break;
					case "DeleteYesMessage":
							if (ActivatedEventElements.Contains("PosStartMessage2")) {
							context.QueueTasks.Enqueue("PosStartMessage2");
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
			if (!HasMapping("MovedPrimaryColumnValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MovedPrimaryColumnValue", MovedPrimaryColumnValue, Guid.Empty);
			}
			if (!HasMapping("DataSourceRowsCount") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DataSourceRowsCount", DataSourceRowsCount, 0);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseSortByPositionGridPageEventsProcess

	/// <exclude/>
	public class BaseSortByPositionGridPageEventsProcess : BaseSortByPositionGridPageEventsProcess<Terrasoft.WebApp.BaseSortByPositionGridPageSchemaUserControl>
	{

		public BaseSortByPositionGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseSortByPositionGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseSortByPositionGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button UpPositionButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UpPositionButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DownPositionButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DownPositionButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
			UpPositionButton.AjaxEvents.Click.Event += UpPositionButtonClick;
			DownPositionButton.AjaxEvents.Click.Event += DownPositionButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
			UpPositionButton.AjaxEvents.Click.Event -= UpPositionButtonClick;
			DownPositionButton.AjaxEvents.Click.Event -= DownPositionButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseSortByPositionGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseSortByPositionGridPageEventsProcess(UserConnection);
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

		public virtual void DeleteButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteButtonClick");
		}

		public virtual void UpPositionButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("UpPositionButtonClick");
		}

		public virtual void DownPositionButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownPositionButtonClick");
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
			SchemaName = "BaseSortByPositionGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseSortByPositionGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseSortByPositionGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseSortByPositionGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseSortByPositionGridPageEventsProcessSchema(BaseSortByPositionGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseSortByPositionGridPageEventsProcess";
			UId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19");
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

		protected virtual ProcessSchemaParameter CreateDataSourceRowsCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fa2e45ef-c5be-4c0b-964f-7808bc340b13"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"DataSourceRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMovedPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cb378519-2d42-46de-9890-650a2f6eda34"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"MovedPrimaryColumnValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDataSourceRowsCountParameter());
			Parameters.Add(CreateMovedPrimaryColumnValueParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet472 = CreateLaneSet472LaneSet();
			LaneSets.Add(schemaLaneSet472);
			ProcessSchemaLane schemaLane1520 = CreateLane1520Lane();
			schemaLaneSet472.Lanes.Add(schemaLane1520);
			ProcessSchemaLane schemaLane1521 = CreateLane1521Lane();
			schemaLaneSet472.Lanes.Add(schemaLane1521);
			ProcessSchemaLane schemaLane1522 = CreateLane1522Lane();
			schemaLaneSet472.Lanes.Add(schemaLane1522);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess datasourceloadrowsresponseregisteredchildeventsubprocess = CreateDataSourceLoadRowsResponseRegisteredChildEventSubProcessEventSubProcess();
			FlowElements.Add(datasourceloadrowsresponseregisteredchildeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess22 = CreateEventSubProcess22EventSubProcess();
			FlowElements.Add(eventsubprocess22);
			ProcessSchemaEventSubProcess poseventsubprocess1 = CreatePosEventSubProcess1EventSubProcess();
			FlowElements.Add(poseventsubprocess1);
			ProcessSchemaStartMessageEvent startuppositionbuttonclick = CreateStartUpPositionButtonClickStartMessageEvent();
			eventsubprocess8.FlowElements.Add(startuppositionbuttonclick);
			ProcessSchemaScriptTask scriptuppositionbuttonclick = CreateScriptUpPositionButtonClickScriptTask();
			eventsubprocess8.FlowElements.Add(scriptuppositionbuttonclick);
			ProcessSchemaStartMessageEvent datasourceloadrowsresponseregisteredchildstartmessage = CreateDataSourceLoadRowsResponseRegisteredChildStartMessageStartMessageEvent();
			datasourceloadrowsresponseregisteredchildeventsubprocess.FlowElements.Add(datasourceloadrowsresponseregisteredchildstartmessage);
			ProcessSchemaScriptTask datasourceloadrowsresponseregisteredchildscripttask = CreateDataSourceLoadRowsResponseRegisteredChildScriptTaskScriptTask();
			datasourceloadrowsresponseregisteredchildeventsubprocess.FlowElements.Add(datasourceloadrowsresponseregisteredchildscripttask);
			ProcessSchemaStartMessageEvent startdownpositionbuttonclick = CreateStartDownPositionButtonClickStartMessageEvent();
			eventsubprocess22.FlowElements.Add(startdownpositionbuttonclick);
			ProcessSchemaScriptTask scriptdownpositionbuttonclick = CreateScriptDownPositionButtonClickScriptTask();
			eventsubprocess22.FlowElements.Add(scriptdownpositionbuttonclick);
			ProcessSchemaStartMessageEvent posstartmessage2 = CreatePosStartMessage2StartMessageEvent();
			poseventsubprocess1.FlowElements.Add(posstartmessage2);
			ProcessSchemaIntermediateThrowMessageEvent posintermediatethrowmessageevent1 = CreatePosIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			poseventsubprocess1.FlowElements.Add(posintermediatethrowmessageevent1);
			ProcessSchemaScriptTask normalizepositionsscripttask = CreateNormalizePositionsScriptTaskScriptTask();
			poseventsubprocess1.FlowElements.Add(normalizepositionsscripttask);
			FlowElements.Add(CreateSequenceFlow8916SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8917SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8919SequenceFlow());
			FlowElements.Add(CreatePosSequenceFlow1SequenceFlow());
			FlowElements.Add(CreatePosSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8916SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8916",
				UId = new Guid("231f6e17-5110-45d3-a440-efe9c53735e5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0b2752c0-f443-4876-8fee-16116c7e00df"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fb3d562f-979e-4902-b0b9-4fce8bfa3bbe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8917SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8917",
				UId = new Guid("e566b414-4779-408c-b51b-09800c207a47"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a79ac548-a428-4e4c-9712-0b3ebd25e7d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b5e5139-b231-4f3d-9237-0a694cffc227"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8919SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8919",
				UId = new Guid("f132ec38-14bc-402c-b96c-0ceba3fda4b0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CurveCenterPosition = new Point(242, 448),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9061588e-ff40-469e-bb03-a1799fbaaa27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cde70205-d5c6-411d-acc4-3fc9ca1422e8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreatePosSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "PosSequenceFlow1",
				UId = new Guid("d48c279b-1880-41c3-92a3-1c9ab69bebfb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CurveCenterPosition = new Point(188, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("506409fe-5ef8-46a3-8534-8159f5125ea7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("44d8724c-1198-4554-ac39-e69ac0c75920"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreatePosSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "PosSequenceFlow2",
				UId = new Guid("eb8348a0-c386-4430-a2e9-4d40b7d4ca29"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CurveCenterPosition = new Point(286, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("44d8724c-1198-4554-ac39-e69ac0c75920"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1a938515-626e-4cb1-bcdc-a1f47affc791"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet472LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet472 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("180c2b5b-2819-424f-b62a-56f23115f0f7"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"LaneSet472",
				Position = new Point(5, 5),
				Size = new Size(894, 482),
				UseBackgroundMode = false
			};
			return schemaLaneSet472;
		}

		protected virtual ProcessSchemaLane CreateLane1520Lane() {
			ProcessSchemaLane schemaLane1520 = new ProcessSchemaLane(this) {
				UId = new Guid("e3437be5-1675-4413-b980-93c2d00923c9"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("180c2b5b-2819-424f-b62a-56f23115f0f7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"Lane1520",
				Position = new Point(29, 133),
				Size = new Size(865, 160),
				UseBackgroundMode = false
			};
			return schemaLane1520;
		}

		protected virtual ProcessSchemaLane CreateLane1521Lane() {
			ProcessSchemaLane schemaLane1521 = new ProcessSchemaLane(this) {
				UId = new Guid("c7a198b7-06ed-4a29-a68a-28c62eb6d10a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("180c2b5b-2819-424f-b62a-56f23115f0f7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"Lane1521",
				Position = new Point(29, 0),
				Size = new Size(865, 128),
				UseBackgroundMode = false
			};
			return schemaLane1521;
		}

		protected virtual ProcessSchemaLane CreateLane1522Lane() {
			ProcessSchemaLane schemaLane1522 = new ProcessSchemaLane(this) {
				UId = new Guid("2c055099-676e-4e06-ac75-aa33354e18d6"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("180c2b5b-2819-424f-b62a-56f23115f0f7"),
				CreatedInOwnerSchemaUId = new Guid("ed069b6f-65bb-4861-ad30-b29a0b393eeb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"Lane1522",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 298),
				Size = new Size(865, 184),
				UseBackgroundMode = false
			};
			return schemaLane1522;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3f19b22c-4e3d-455b-bd78-a4985513e9a4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e3437be5-1675-4413-b980-93c2d00923c9"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"EventSubProcess8",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(244, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartUpPositionButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0b2752c0-f443-4876-8fee-16116c7e00df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f19b22c-4e3d-455b-bd78-a4985513e9a4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpPositionButtonClick",
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"StartUpPositionButtonClick",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptUpPositionButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fb3d562f-979e-4902-b0b9-4fce8bfa3bbe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f19b22c-4e3d-455b-bd78-a4985513e9a4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"ScriptUpPositionButtonClick",
				Position = new Point(134, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,47,75,245,44,73,205,213,208,53,212,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,172,143,61,54,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDataSourceLoadRowsResponseRegisteredChildEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDataSourceLoadRowsResponseRegisteredChildEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ab157433-bb27-4c4b-a959-67eb00f99169"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c055099-676e-4e06-ac75-aa33354e18d6"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"DataSourceLoadRowsResponseRegisteredChildEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(356, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDataSourceLoadRowsResponseRegisteredChildEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadRowsResponseRegisteredChildStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9061588e-ff40-469e-bb03-a1799fbaaa27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab157433-bb27-4c4b-a959-67eb00f99169"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"DataSourceLoadRowsResponseRegisteredChildStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDataSourceLoadRowsResponseRegisteredChildScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cde70205-d5c6-411d-acc4-3fc9ca1422e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab157433-bb27-4c4b-a959-67eb00f99169"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"DataSourceLoadRowsResponseRegisteredChildScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,223,107,194,48,16,199,159,237,95,17,125,16,133,81,124,47,14,156,21,17,220,144,185,237,101,248,16,154,155,11,164,201,72,46,117,50,252,223,215,164,171,150,254,144,97,161,47,185,187,239,125,190,119,23,83,164,91,101,117,2,207,234,96,230,202,74,36,83,178,161,123,8,227,115,40,116,177,208,7,163,160,30,219,130,128,4,129,173,16,210,141,230,41,213,199,185,18,54,149,111,84,88,200,203,4,80,61,26,71,1,255,32,163,71,149,1,107,102,145,254,148,44,45,103,225,34,253,194,227,152,252,4,189,102,27,156,11,14,18,103,9,242,204,209,118,137,229,173,90,170,175,67,206,24,187,38,215,133,93,165,142,130,19,1,97,192,193,103,84,19,90,114,190,174,88,45,177,231,70,17,183,76,254,158,76,188,121,47,224,228,19,37,17,190,49,124,249,212,234,176,200,156,125,189,55,132,26,114,41,63,63,231,194,94,217,143,83,90,33,200,112,72,252,242,202,135,66,188,87,67,243,41,97,211,158,211,187,120,106,148,181,29,201,251,100,215,37,148,255,255,216,105,181,199,29,65,93,204,255,166,125,58,100,255,213,139,207,221,218,151,93,177,124,51,240,169,216,113,127,101,98,64,202,197,82,115,86,12,191,36,127,82,12,90,47,170,42,232,172,175,185,65,144,160,47,39,48,42,159,28,222,70,171,4,140,241,221,7,174,205,90,81,230,86,49,248,227,240,168,20,225,193,34,42,105,58,239,46,191,223,32,208,128,86,75,111,35,250,5,23,55,159,226,27,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess22EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess22 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f225c1ea-953d-40d8-b55e-ce33fd2a1b19"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e3437be5-1675-4413-b980-93c2d00923c9"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"EventSubProcess22",
				Position = new Point(295, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess22;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartDownPositionButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a79ac548-a428-4e4c-9712-0b3ebd25e7d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f225c1ea-953d-40d8-b55e-ce33fd2a1b19"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownPositionButtonClick",
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"StartDownPositionButtonClick",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDownPositionButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8b5e5139-b231-4f3d-9237-0a694cffc227"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f225c1ea-953d-40d8-b55e-ce33fd2a1b19"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"ScriptDownPositionButtonClick",
				Position = new Point(147, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,47,75,245,44,73,205,213,48,212,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,218,90,161,104,25,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePosEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaPosEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e6616382-4093-4660-88b4-61240353f9df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c7a198b7-06ed-4a29-a68a-28c62eb6d10a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"PosEventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(321, 107),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPosEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePosStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("506409fe-5ef8-46a3-8534-8159f5125ea7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6616382-4093-4660-88b4-61240353f9df"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"PosStartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePosIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("44d8724c-1198-4554-ac39-e69ac0c75920"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6616382-4093-4660-88b4-61240353f9df"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteYesMessage",
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"PosIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateNormalizePositionsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1a938515-626e-4cb1-bcdc-a1f47affc791"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6616382-4093-4660-88b4-61240353f9df"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Name = @"NormalizePositionsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(210, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,203,47,202,77,204,201,172,74,13,200,47,206,44,201,204,207,43,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,42,185,157,48,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateMoveItemMethod());
			Methods.Add(CreateNormalizePositionsMethod());
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
				UId = new Guid("f759fd7f-c235-4aad-9f86-46ed65d3d366"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,72,74,44,78,213,115,79,45,113,130,136,104,104,90,115,65,37,245,28,83,82,52,2,18,211,83,245,66,11,2,242,139,51,75,50,243,243,32,170,244,252,18,115,83,177,41,116,201,47,207,195,174,180,40,181,164,180,40,15,102,175,53,0,196,172,62,171,132,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMoveItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d43d2fcb-4891-4fd3-8e31-32f4d6cfeab2"),
				Name = "MoveItem",
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("40dd8749-1a82-44b8-b3b1-ff2e6415cea2"),
				Name = "incrementPosition",
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				ModifiedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,93,107,219,48,20,125,110,161,255,65,244,73,102,65,228,189,93,161,203,23,131,181,164,77,186,61,140,61,8,251,118,17,216,82,34,203,41,102,221,127,159,100,89,182,100,101,89,2,123,10,92,157,123,239,185,247,28,201,217,83,137,50,170,232,74,84,50,5,244,17,45,233,79,32,211,46,114,115,117,185,215,144,50,221,64,65,227,99,178,106,14,90,212,43,147,165,154,113,197,84,253,242,57,211,232,190,50,185,79,21,219,195,179,120,91,74,86,80,89,79,68,94,21,252,43,205,171,174,7,164,130,103,126,250,162,98,25,153,21,91,85,183,144,93,5,178,214,7,28,222,144,5,218,254,79,38,142,45,201,164,197,110,253,62,143,180,48,195,53,249,228,62,203,108,180,205,32,11,80,203,33,26,39,9,49,191,174,154,40,153,98,130,31,45,119,189,108,81,215,65,110,191,133,57,203,21,200,50,220,204,164,146,18,184,90,41,89,165,170,146,64,90,20,89,139,104,70,123,164,219,229,144,154,70,184,161,96,70,182,92,92,170,230,132,163,182,110,51,208,84,237,248,235,233,109,31,252,82,154,218,156,219,218,163,129,158,38,157,189,34,236,210,181,12,85,158,39,232,215,213,229,133,4,205,156,107,192,111,207,9,110,27,186,147,205,49,173,214,245,22,50,79,252,91,198,213,29,142,215,27,146,181,43,120,160,92,219,79,234,122,33,83,50,139,65,209,238,181,245,38,162,226,234,233,68,15,253,37,243,100,247,28,41,113,186,74,12,66,179,132,117,58,229,60,67,132,155,49,197,166,126,118,217,164,59,69,116,121,210,4,90,105,113,168,219,7,196,120,42,161,208,88,23,75,208,45,26,163,247,119,116,10,244,14,29,232,29,27,38,180,238,36,7,42,113,111,233,103,40,65,173,192,204,103,37,58,195,237,49,204,70,38,18,168,106,129,223,152,218,44,169,212,162,25,16,118,55,172,216,82,201,74,193,141,95,201,108,87,209,124,132,52,239,254,138,143,208,191,55,240,63,57,60,10,213,211,56,106,189,232,226,26,26,158,157,118,103,152,167,187,240,157,85,180,170,99,171,97,252,96,59,228,247,241,143,131,119,221,60,232,250,178,15,41,39,131,135,99,230,30,168,118,76,187,170,131,143,148,227,232,229,145,57,168,116,51,151,162,152,126,194,195,77,52,196,125,240,10,148,199,16,159,167,239,205,176,24,221,67,227,207,139,7,177,135,44,254,212,233,153,66,70,253,228,254,54,207,26,221,79,12,102,31,232,147,196,170,157,60,125,51,83,152,233,70,213,244,155,63,5,107,9,176,144,250,131,221,95,96,239,35,247,69,208,204,60,1,58,254,7,197,164,82,73,115,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNormalizePositionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("389e6d08-19b8-4990-91e2-b177d24ec498"),
				Name = "NormalizePositions",
				CreatedInSchemaUId = new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,65,110,219,48,16,60,203,128,255,192,250,68,33,6,145,246,234,36,128,235,186,70,128,162,113,107,167,61,20,61,16,210,166,33,32,145,234,146,76,42,20,249,123,150,148,228,90,182,236,75,47,54,196,221,153,157,157,33,159,36,50,91,219,121,94,42,125,87,1,74,167,140,94,161,212,14,96,147,61,66,41,191,120,192,154,93,51,13,207,108,169,157,114,245,222,57,95,203,95,32,62,72,39,55,198,99,6,162,169,165,179,241,232,137,152,43,84,165,196,22,176,48,133,47,245,103,89,2,177,13,227,196,10,220,186,193,252,235,230,29,27,28,78,255,63,85,177,181,39,234,104,128,152,231,121,211,193,79,172,146,138,240,75,196,231,176,147,181,177,42,24,59,73,197,29,230,128,239,235,185,205,118,123,229,59,161,31,85,225,0,237,128,63,11,143,72,35,54,14,125,230,60,130,104,91,197,214,28,173,223,148,104,118,1,89,152,202,143,180,165,131,130,59,74,18,206,143,52,245,66,80,96,7,237,162,248,26,53,123,195,239,109,208,162,117,243,25,104,218,20,90,79,214,18,101,217,38,25,89,226,1,208,76,242,237,237,100,202,46,251,249,223,230,103,17,239,8,177,242,42,23,203,178,114,117,7,245,21,45,4,45,230,62,126,28,8,155,158,186,146,49,229,241,40,17,27,112,123,73,78,251,11,196,142,239,143,128,112,250,166,220,218,229,111,47,11,222,219,35,101,210,182,138,102,44,9,230,60,24,100,60,136,86,164,247,114,70,127,87,59,215,197,194,120,237,232,236,226,34,101,127,105,166,122,96,188,43,254,80,63,67,2,219,186,130,246,230,125,147,133,135,43,165,221,205,254,29,100,111,174,153,106,224,73,79,139,136,253,93,178,103,24,131,193,55,124,248,29,5,203,147,164,103,206,142,87,197,90,19,134,88,254,129,204,187,240,188,19,218,59,121,25,143,94,194,250,49,134,45,2,172,144,82,92,20,32,49,190,148,195,120,62,25,153,127,53,207,150,138,175,80,220,30,254,197,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseSortByPositionGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("762f2682-b2a3-4f17-abcf-17e8a92b3e19"));
		}

		#endregion

	}

	#endregion

}

