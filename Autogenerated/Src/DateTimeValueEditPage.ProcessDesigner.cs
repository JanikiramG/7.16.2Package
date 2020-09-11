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
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: DateTimeValueEditPageSchema

	/// <exclude/>
	public class DateTimeValueEditPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _mainMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel MainMessagePanel {
			get {
				return _mainMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _topControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TopControlLayout {
			get {
				return _topControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _dateTimeEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit DateTimeEdit {
			get {
				return _dateTimeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bottomControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomControlLayout {
			get {
				return _bottomControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _okButton;
		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return _okButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _cancelButton;
		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return _cancelButton;
			}
		}

		#endregion

		#region Constructors: Public

		public DateTimeValueEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public DateTimeValueEditPageSchema(DateTimeValueEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			RealUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			Name = "DateTimeValueEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDateTimeValueEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateMainMessagePanel());
			Controls.AddAt(1, CreateTopControlLayout());
			TopControlLayout.InsertItem(0, CreateDateTimeEdit());
			Controls.AddAt(2, CreateBottomControlLayout());
			BottomControlLayout.InsertItem(0, CreateSpacer1());
			BottomControlLayout.InsertItem(1, CreateOkButton());
			BottomControlLayout.InsertItem(2, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateDateTimeValueEditPageEventsProcessSchema() {
			var schema = new DateTimeValueEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateMainMessagePanel() {
			_mainMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_mainMessagePanel.UId = new Guid("130d6785-1847-4dce-b148-5b28b2a714c4");
			_mainMessagePanel.Name = "MainMessagePanel";
			_mainMessagePanel.CreatedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_mainMessagePanel.ModifiedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_mainMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainMessagePanel.Tag = "";
			_mainMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_mainMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainMessagePanel.Edges = "0 0 1 0";
			return _mainMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateDateTimeEdit() {
			_dateTimeEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_dateTimeEdit.UId = new Guid("9c114c5d-f205-4047-817f-547b641fcaf7");
			_dateTimeEdit.Name = "DateTimeEdit";
			_dateTimeEdit.CreatedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_dateTimeEdit.ModifiedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_dateTimeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dateTimeEdit.Tag = "";
			_dateTimeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dateTimeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _dateTimeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTopControlLayout() {
			_topControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_topControlLayout.UId = new Guid("1f9abf1c-9288-454f-81df-a118efe49744");
			_topControlLayout.Name = "TopControlLayout";
			_topControlLayout.CreatedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_topControlLayout.ModifiedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_topControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_topControlLayout.Tag = "";
			_topControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_topControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_topControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_topControlLayout.Padding = "5 5 5 5";
			_topControlLayout.StartNewAlignGroup = false;
			_topControlLayout.Image = new ControlImage {};
			_topControlLayout.Edges = "";
			return _topControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("e6aa8238-7571-4b40-8a66-af651556a1a2");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_spacer1.ModifiedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("39523b8e-5f84-44fc-a220-66f83dd8d5c8");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_okButton.ModifiedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_okButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("bb792730-97e7-474b-83c6-40a3f7e792e4");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_cancelButton.ModifiedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBottomControlLayout() {
			_bottomControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bottomControlLayout.UId = new Guid("4b4baa13-86af-433f-90b8-f299538c607e");
			_bottomControlLayout.Name = "BottomControlLayout";
			_bottomControlLayout.CreatedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_bottomControlLayout.ModifiedInSchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			_bottomControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bottomControlLayout.Tag = "";
			_bottomControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_bottomControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_bottomControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bottomControlLayout.StartNewAlignGroup = false;
			_bottomControlLayout.Image = new ControlImage {};
			_bottomControlLayout.Edges = "1 0 0 0";
			return _bottomControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new DateTimeValueEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new DateTimeValueEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d02c5d7d-e691-4000-901c-84be8065fe10"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DateTimeValueEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: DateTimeValueEditPageEventsProcess

	/// <exclude/>
	public class DateTimeValueEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.DateTimeValueEditPageSchemaUserControl
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

		public DateTimeValueEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DateTimeValueEditPageEventsProcess";
			SchemaUId = new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d02c5d7d-e691-4000-901c-84be8065fe10");
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

		public virtual string ContextKey {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessOkButtonClick;
		public ProcessFlowElement EventSubProcessOkButtonClick {
			get {
				return _eventSubProcessOkButtonClick ?? (_eventSubProcessOkButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessOkButtonClick",
					SchemaElementUId = new Guid("6f07443f-5e39-4cc6-b639-414156369a1d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickStartMessage;
		public ProcessFlowElement OkButtonClickStartMessage {
			get {
				return _okButtonClickStartMessage ?? (_okButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickStartMessage",
					SchemaElementUId = new Guid("5e23a33f-54ac-4860-ad37-26f537239db0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskOkButtonClick;
		public ProcessScriptTask ScriptTaskOkButtonClick {
			get {
				return _scriptTaskOkButtonClick ?? (_scriptTaskOkButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskOkButtonClick",
					SchemaElementUId = new Guid("db7d8de8-8077-4bd7-aea8-3352207a0274"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskOkButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessCancelButtonClick;
		public ProcessFlowElement EventSubProcessCancelButtonClick {
			get {
				return _eventSubProcessCancelButtonClick ?? (_eventSubProcessCancelButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessCancelButtonClick",
					SchemaElementUId = new Guid("00fc30d3-cf77-41f9-ac5b-ce952b7578bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickStartMessage;
		public ProcessFlowElement CancelButtonClickStartMessage {
			get {
				return _cancelButtonClickStartMessage ?? (_cancelButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CancelButtonClickStartMessage",
					SchemaElementUId = new Guid("482248c3-a993-4547-b4a1-e02741c8c22e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskCancelButtonClick;
		public ProcessScriptTask ScriptTaskCancelButtonClick {
			get {
				return _scriptTaskCancelButtonClick ?? (_scriptTaskCancelButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskCancelButtonClick",
					SchemaElementUId = new Guid("cf7a5a79-8d75-4d2e-ac22-943eec69709b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskCancelButtonClickExecute,
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
					SchemaElementUId = new Guid("f11d7212-a087-46c7-9e8b-1cfd2c940d40"),
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
					SchemaElementUId = new Guid("551704cb-ba0a-4e31-9842-fcaf0d203d3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPageInit;
		public ProcessScriptTask ScriptTaskPageInit {
			get {
				return _scriptTaskPageInit ?? (_scriptTaskPageInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPageInit",
					SchemaElementUId = new Guid("4bdb9ed7-7306-4fc2-ac79-ea0f54a2a42b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPageInitExecute,
				});
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
					SchemaElementUId = new Guid("3f98613e-5bf8-4875-a244-3b45d8695afa"),
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
					SchemaElementUId = new Guid("c3d76886-09e4-4e77-b148-c72f33bb6c16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPageLoadComplete;
		public ProcessScriptTask ScriptTaskPageLoadComplete {
			get {
				return _scriptTaskPageLoadComplete ?? (_scriptTaskPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPageLoadComplete",
					SchemaElementUId = new Guid("0c6a6b02-e9ea-458d-a623-51b2f3f0bdc4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPageLoadCompleteExecute,
				});
			}
		}

		private LocalizableString _dateValueEditCaption;
		public LocalizableString DateValueEditCaption {
			get {
				return _dateValueEditCaption ?? (_dateValueEditCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DateValueEditCaption.Value"));
			}
		}

		private LocalizableString _timeValueEditCaption;
		public LocalizableString TimeValueEditCaption {
			get {
				return _timeValueEditCaption ?? (_timeValueEditCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TimeValueEditCaption.Value"));
			}
		}

		private LocalizableString _dateTimeValueEditCaption;
		public LocalizableString DateTimeValueEditCaption {
			get {
				return _dateTimeValueEditCaption ?? (_dateTimeValueEditCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DateTimeValueEditCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessOkButtonClick };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[ScriptTaskOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskOkButtonClick };
			FlowElements[EventSubProcessCancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessCancelButtonClick };
			FlowElements[CancelButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage };
			FlowElements[ScriptTaskCancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskCancelButtonClick };
			FlowElements[EventSubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInit };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[ScriptTaskPageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPageInit };
			FlowElements[EventSubProcessPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPageLoadComplete };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[ScriptTaskPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPageLoadComplete };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessOkButtonClick":
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskOkButtonClick");
						break;
					case "ScriptTaskOkButtonClick":
						break;
					case "EventSubProcessCancelButtonClick":
						break;
					case "CancelButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskCancelButtonClick");
						break;
					case "ScriptTaskCancelButtonClick":
						break;
					case "EventSubProcessInit":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskPageInit");
						break;
					case "ScriptTaskPageInit":
						break;
					case "EventSubProcessPageLoadComplete":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskPageLoadComplete");
						break;
					case "ScriptTaskPageLoadComplete":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OkButtonClickStartMessage");
			ActivatedEventElements.Add("CancelButtonClickStartMessage");
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessOkButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage";
					result = OkButtonClickStartMessage.Execute(context);
					break;
				case "ScriptTaskOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskOkButtonClick";
					result = ScriptTaskOkButtonClick.Execute(context, ScriptTaskOkButtonClickExecute);
					break;
				case "EventSubProcessCancelButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickStartMessage";
					result = CancelButtonClickStartMessage.Execute(context);
					break;
				case "ScriptTaskCancelButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskCancelButtonClick";
					result = ScriptTaskCancelButtonClick.Execute(context, ScriptTaskCancelButtonClickExecute);
					break;
				case "EventSubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
					break;
				case "ScriptTaskPageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPageInit";
					result = ScriptTaskPageInit.Execute(context, ScriptTaskPageInitExecute);
					break;
				case "EventSubProcessPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "ScriptTaskPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPageLoadComplete";
					result = ScriptTaskPageLoadComplete.Execute(context, ScriptTaskPageLoadCompleteExecute);
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
				case "ContextKey":
					ContextKey = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskOkButtonClickExecute(ProcessExecutingContext context) {
			UserConnection.SessionData[ContextKey] = Page.DateTimeEdit.SelectedDate;
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool ScriptTaskCancelButtonClickExecute(ProcessExecutingContext context) {
			UserConnection.SessionData[ContextKey] = null;
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool ScriptTaskPageInitExecute(ProcessExecutingContext context) {
			if (Ext.IsAjaxRequest) {
				return true;
			}
			var dateTimeKind = Page.Request.QueryString["dateTimeKind"] as string;
			if (string.IsNullOrEmpty(dateTimeKind)) {
				return true;
			}
			string dateTimeEditCaption;
			if (dateTimeKind == "Date") {
				Page.DateTimeEdit.Kind = DateTimeValueKind.Date;
				dateTimeEditCaption = DateValueEditCaption;
			} else if (dateTimeKind == "Time") {
				Page.DateTimeEdit.Kind = DateTimeValueKind.Time;
				dateTimeEditCaption = TimeValueEditCaption;
			} else {
				dateTimeEditCaption = DateTimeValueEditCaption;
			}
			Page.DateTimeEdit.Caption = dateTimeEditCaption;
			ContextKey = (string)Page.Request.QueryString["contextKey"];
			/*
			var script = string.Format("{0}.setKind('{1}');", Page.DateTimeEdit.ClientID, dateTimeKind.ToLower());
			Page.AddScript(script);
			*/
			return true;
		}

		public virtual bool ScriptTaskPageLoadCompleteExecute(ProcessExecutingContext context) {
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CancelButtonClickStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ContextKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ContextKey", ContextKey, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: DateTimeValueEditPageEventsProcess

	/// <exclude/>
	public class DateTimeValueEditPageEventsProcess : DateTimeValueEditPageEventsProcess<Terrasoft.WebApp.DateTimeValueEditPageSchemaUserControl>
	{

		public DateTimeValueEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DateTimeValueEditPageSchemaUserControl

	/// <exclude/>
	public partial class DateTimeValueEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel MainMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("MainMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout TopControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TopControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit DateTimeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("DateTimeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BottomControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OkButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CancelButton", true);
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
			OkButton.AjaxEvents.Click.Event += OkButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			OkButton.AjaxEvents.Click.Event -= OkButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (DateTimeValueEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new DateTimeValueEditPageEventsProcess(UserConnection);
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

		public virtual void OkButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OkButtonClick");
		}

		public virtual void CancelButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CancelButtonClick");
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
			SchemaName = "DateTimeValueEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: DateTimeValueEditPageEventsProcessSchema

	/// <exclude/>
	public class DateTimeValueEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public DateTimeValueEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DateTimeValueEditPageEventsProcessSchema(DateTimeValueEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DateTimeValueEditPageEventsProcess";
			UId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9");
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

		protected virtual ProcessSchemaParameter CreateContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7fc3bdf9-734c-4782-af83-2dac59b25b1c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"ContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateContextKeyParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocessokbuttonclick = CreateEventSubProcessOkButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocessokbuttonclick);
			ProcessSchemaEventSubProcess eventsubprocesscancelbuttonclick = CreateEventSubProcessCancelButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocesscancelbuttonclick);
			ProcessSchemaEventSubProcess eventsubprocessinit = CreateEventSubProcessInitEventSubProcess();
			FlowElements.Add(eventsubprocessinit);
			ProcessSchemaEventSubProcess eventsubprocesspageloadcomplete = CreateEventSubProcessPageLoadCompleteEventSubProcess();
			FlowElements.Add(eventsubprocesspageloadcomplete);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			eventsubprocessokbuttonclick.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaScriptTask scripttaskokbuttonclick = CreateScriptTaskOkButtonClickScriptTask();
			eventsubprocessokbuttonclick.FlowElements.Add(scripttaskokbuttonclick);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage = CreateCancelButtonClickStartMessageStartMessageEvent();
			eventsubprocesscancelbuttonclick.FlowElements.Add(cancelbuttonclickstartmessage);
			ProcessSchemaScriptTask scripttaskcancelbuttonclick = CreateScriptTaskCancelButtonClickScriptTask();
			eventsubprocesscancelbuttonclick.FlowElements.Add(scripttaskcancelbuttonclick);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocessinit.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask scripttaskpageinit = CreateScriptTaskPageInitScriptTask();
			eventsubprocessinit.FlowElements.Add(scripttaskpageinit);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocesspageloadcomplete.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask scripttaskpageloadcomplete = CreateScriptTaskPageLoadCompleteScriptTask();
			eventsubprocesspageloadcomplete.FlowElements.Add(scripttaskpageloadcomplete);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDateValueEditCaptionLocalizableString());
			LocalizableStrings.Add(CreateTimeValueEditCaptionLocalizableString());
			LocalizableStrings.Add(CreateDateTimeValueEditCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDateValueEditCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("91e4bb01-89df-4a5f-acdd-387c86799f28"),
				Name = "DateValueEditCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTimeValueEditCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9800f88a-be91-4aac-9b05-148d8e017902"),
				Name = "TimeValueEditCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateTimeValueEditCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7c2c8a46-5df3-46f8-b75d-79e4f7dd5131"),
				Name = "DateTimeValueEditCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("872238eb-3fe8-4e56-b425-d81fb8189af5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("482248c3-a993-4547-b4a1-e02741c8c22e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf7a5a79-8d75-4d2e-ac22-943eec69709b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("6ca7b466-5f27-4021-b14a-1fbd44d036fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5e23a33f-54ac-4860-ad37-26f537239db0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db7d8de8-8077-4bd7-aea8-3352207a0274"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("16cee661-b0fa-4e05-bba5-31d7b506c785"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				CurveCenterPosition = new Point(173, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("551704cb-ba0a-4e31-9842-fcaf0d203d3a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4bdb9ed7-7306-4fc2-ac79-ea0f54a2a42b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("cd204e0e-34c2-4418-a25d-1894d0ed520c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				CurveCenterPosition = new Point(421, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3d76886-09e4-4e77-b148-c72f33bb6c16"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c6a6b02-e9ea-458d-a623-51b2f3f0bdc4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0d870cd6-c2de-4543-8119-c92f5589c6d0"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1157, 354),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("dabe409d-1e14-4c44-86dd-7ca0a0a27143"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("0d870cd6-c2de-4543-8119-c92f5589c6d0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"Lane1",
				Position = new Point(29, 164),
				Size = new Size(1128, 190),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("3ab7de9b-3e28-405b-abf3-55721ec8ec14"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("0d870cd6-c2de-4543-8119-c92f5589c6d0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(1128, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessOkButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessOkButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6f07443f-5e39-4cc6-b639-414156369a1d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ab7de9b-3e28-405b-abf3-55721ec8ec14"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"EventSubProcessOkButtonClick",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(214, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessOkButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5e23a33f-54ac-4860-ad37-26f537239db0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f07443f-5e39-4cc6-b639-414156369a1d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskOkButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("db7d8de8-8077-4bd7-aea8-3352207a0274"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f07443f-5e39-4cc6-b639-414156369a1d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"ScriptTaskOkButtonClick",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,140,177,10,194,64,16,68,123,193,127,184,242,210,236,15,4,139,16,45,196,70,48,33,133,88,156,102,148,131,243,78,118,55,160,127,239,94,170,97,30,243,102,20,112,95,114,198,67,99,201,116,129,136,229,62,104,184,26,86,124,245,132,223,205,237,220,57,188,64,198,49,196,55,14,115,84,219,38,179,48,87,216,110,55,222,15,96,14,82,158,74,227,145,38,220,235,1,151,36,84,221,102,61,232,228,179,22,234,83,17,248,198,60,134,46,156,157,242,130,246,15,227,220,70,198,142,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessCancelButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessCancelButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("00fc30d3-cf77-41f9-ac5b-ce952b7578bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ab7de9b-3e28-405b-abf3-55721ec8ec14"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"EventSubProcessCancelButtonClick",
				Position = new Point(260, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(227, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessCancelButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("482248c3-a993-4547-b4a1-e02741c8c22e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00fc30d3-cf77-41f9-ac5b-ce952b7578bc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"CancelButtonClickStartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskCancelButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cf7a5a79-8d75-4d2e-ac22-943eec69709b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00fc30d3-cf77-41f9-ac5b-ce952b7578bc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"ScriptTaskCancelButtonClick",
				Position = new Point(126, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,78,45,46,6,210,46,137,37,137,209,64,225,146,212,138,18,239,212,202,88,5,91,133,188,210,156,28,107,94,46,13,141,144,212,162,162,196,226,252,180,18,189,80,79,189,240,212,36,144,178,162,252,156,98,189,128,196,244,84,77,16,161,231,88,92,0,230,232,57,231,228,23,167,106,104,2,245,21,165,150,148,22,229,41,148,20,149,166,90,3,0,128,55,103,53,116,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f11d7212-a087-46c7-9e8b-1cfd2c940d40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dabe409d-1e14-4c44-86dd-7ca0a0a27143"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"EventSubProcessInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(228, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("551704cb-ba0a-4e31-9842-fcaf0d203d3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f11d7212-a087-46c7-9e8b-1cfd2c940d40"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPageInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4bdb9ed7-7306-4fc2-ac79-ea0f54a2a42b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f11d7212-a087-46c7-9e8b-1cfd2c940d40"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"ScriptTaskPageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,77,107,131,64,16,134,207,17,252,15,203,94,162,33,152,246,44,57,132,104,33,164,244,43,161,151,146,195,18,167,97,139,95,221,29,91,69,252,239,93,117,107,149,106,161,199,217,125,223,121,159,217,29,254,74,44,63,71,103,39,55,111,44,127,130,247,12,36,218,164,52,141,153,0,204,68,76,80,100,224,154,70,101,26,31,76,144,128,33,28,121,4,123,30,7,100,77,30,216,5,28,237,114,30,51,16,197,1,5,143,47,47,180,47,164,39,194,36,145,205,141,106,197,85,102,91,168,216,187,44,12,239,133,31,165,88,88,125,143,61,1,209,26,59,14,63,224,184,101,41,242,36,214,157,135,132,107,66,61,117,64,219,110,13,174,215,179,58,122,142,239,179,103,22,102,141,179,81,169,142,179,145,32,173,111,180,195,252,138,64,40,129,140,98,212,197,255,49,234,106,26,163,211,142,98,148,127,226,79,121,77,227,55,222,143,115,252,221,183,73,140,144,227,30,10,37,209,127,107,79,239,198,185,147,211,147,114,175,22,237,110,201,179,224,41,170,14,122,57,110,18,17,49,180,104,121,85,57,18,176,126,15,107,94,94,87,115,219,165,75,50,66,25,114,136,113,231,45,7,91,234,28,147,219,228,19,132,101,219,174,158,109,19,4,135,38,203,106,35,235,139,197,202,52,250,203,246,5,220,41,178,61,25,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3f98613e-5bf8-4875-a244-3b45d8695afa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dabe409d-1e14-4c44-86dd-7ca0a0a27143"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"EventSubProcessPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 13),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(227, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c3d76886-09e4-4e77-b148-c72f33bb6c16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f98613e-5bf8-4875-a244-3b45d8695afa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0c6a6b02-e9ea-458d-a623-51b2f3f0bdc4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f98613e-5bf8-4875-a244-3b45d8695afa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"),
				Name = @"ScriptTaskPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DateTimeValueEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53e4dc56-6023-45c1-ab0e-996e82dd71d9"));
		}

		#endregion

	}

	#endregion

}

