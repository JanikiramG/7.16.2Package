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
	using System.Text.RegularExpressions;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: AnswerEditPageSchema

	/// <exclude/>
	public class AnswerEditPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _answerEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit AnswerEdit {
			get {
				return _answerEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _checkedEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox CheckedEdit {
			get {
				return _checkedEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
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

		public AnswerEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AnswerEditPageSchema(AnswerEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			RealUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			Name = "AnswerEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 440;
			Height = 280;
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAnswerEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateAnswerEdit());
			ControlLayout1.InsertItem(1, CreateCheckedEdit());
			Controls.AddAt(2, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateSpacer1());
			ControlLayout2.InsertItem(1, CreateOkButton());
			ControlLayout2.InsertItem(2, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAnswerEditPageEventsProcessSchema() {
			var schema = new AnswerEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("e84b739d-e0eb-41d4-83bb-bc1f5a1d51d9");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateAnswerEdit() {
			_answerEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_answerEdit.UId = new Guid("9a386cd4-0611-4b35-8d91-f32bcd168628");
			_answerEdit.Name = "AnswerEdit";
			_answerEdit.CreatedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_answerEdit.ModifiedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_answerEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_answerEdit.Tag = "";
			_answerEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_answerEdit.Height = System.Web.UI.WebControls.Unit.Pixel(70);
			_answerEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_answerEdit.Required = true;
			return _answerEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateCheckedEdit() {
			_checkedEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_checkedEdit.UId = new Guid("f10d9661-e419-411b-80f0-a7c6689e2ec7");
			_checkedEdit.Name = "CheckedEdit";
			_checkedEdit.CreatedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_checkedEdit.ModifiedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_checkedEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_checkedEdit.Tag = "";
			_checkedEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _checkedEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("fb407a94-4ec8-4d8c-94c4-3de3d39b7f5b");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_controlLayout1.ModifiedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.Padding = "5 5 5 5";
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("179f57c6-29d7-46f5-8e9e-dfc01e5a8caa");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_spacer1.ModifiedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("1438cc88-13b0-4ae5-ae9a-329dc04dd2de");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_okButton.ModifiedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_okButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("d4ac77c5-4473-440d-b8ac-4da0af9caa16");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_cancelButton.ModifiedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("5622458d-9dd2-456d-baf0-7ab7f6477918");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_controlLayout2.ModifiedInSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "1 0 0 0";
			return _controlLayout2;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AnswerEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AnswerEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AnswerEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AnswerEditPageEventsProcess

	/// <exclude/>
	public class AnswerEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.AnswerEditPageSchemaUserControl
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

		public AnswerEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AnswerEditPageEventsProcess";
			SchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
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

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual Guid ItemId {
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
					SchemaElementUId = new Guid("f8411171-98fa-4fd5-a5fa-30e839cc2365"),
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
					SchemaElementUId = new Guid("f4408710-e402-4756-a1b9-30d8898db93c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickScriptTask;
		public ProcessScriptTask OkButtonClickScriptTask {
			get {
				return _okButtonClickScriptTask ?? (_okButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickScriptTask",
					SchemaElementUId = new Guid("0d84c3d4-207a-4f6e-b6f4-bcc0b9b5785c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("02eea287-b9d9-4833-b8ab-f6184048d9d9"),
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
					SchemaElementUId = new Guid("d206d9ab-4120-43d2-b914-ac8d921e1f78"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _cancelButtonClickScriptTask;
		public ProcessScriptTask CancelButtonClickScriptTask {
			get {
				return _cancelButtonClickScriptTask ?? (_cancelButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CancelButtonClickScriptTask",
					SchemaElementUId = new Guid("6fb6516b-cf69-4f16-a6d5-1ba18e7fea44"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("3ce45552-dece-4024-be1a-c8e76f912034"),
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
					SchemaElementUId = new Guid("858ff537-9f6e-4478-af81-db946ff9683a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("ec6f7ed6-4316-4ffb-8eb7-fb1afd78a00f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private LocalizableString _schemaLocalizableString1;
		public LocalizableString SchemaLocalizableString1 {
			get {
				return _schemaLocalizableString1 ?? (_schemaLocalizableString1 = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SchemaLocalizableString1.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[OkButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[CancelButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage };
			FlowElements[CancelButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OkButtonClickScriptTask");
						break;
					case "OkButtonClickScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "CancelButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask");
						break;
					case "CancelButtonClickScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
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
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
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
				case "OkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage";
					result = OkButtonClickStartMessage.Execute(context);
					break;
				case "OkButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickScriptTask";
					result = OkButtonClickScriptTask.Execute(context, OkButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickStartMessage";
					result = CancelButtonClickStartMessage.Execute(context);
					break;
				case "CancelButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickScriptTask";
					result = CancelButtonClickScriptTask.Execute(context, CancelButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
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
				case "ItemId":
					ItemId = reader.GetValue<System.Guid>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool OkButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			LocalizableParameterValues item = AddItem();
			if (item == null) {
				return true;
			}
			string serializedItem = Json.Serialize(new {
				Id = item["Id"].Value,
				Name = item["Name"].Value,
				Caption = item["Caption"].Value,
				DefChecked = bool.Parse(item["DefChecked"].Value)
			});
			var sb = new StringBuilder(@"(function() {
				var treeGrid = window.Ext.getCmp('");
			sb.Append(Page.GetParameterValue("treeGridId"));
			sb.Append(@"');
				if (!treeGrid) {
					return;
				}
				var dataSource = treeGrid.dataSource;
				if (!dataSource) {
					return;
				}");
			if (IsNew) {
				sb.Append(@"
					var row = dataSource.createRow(");
				sb.Append(serializedItem);
				sb.Append(@");
					dataSource.rows.insert(0, row.getPrimaryColumnValue(), row);
					dataSource.setActiveRow(row);
					dataSource.fireEvent('inserted', dataSource, row, { });");
			} else {
				sb.Append(@"
					var columns = ");
				sb.Append(serializedItem);
				sb.Append(@";
					var row = dataSource.getRow(columns[dataSource.getPrimaryColumnName()]);
					for (var columnName in columns) {
						row.setColumnValue(columnName, columns[columnName]);
					}
					dataSource.fireEvent('rowloaded', dataSource, [row.columns], { });");
			}
			sb.Append(@"
			})();");
			var insertedRowValueKey = (string)Page.GetParameterValue("insertedRowValueKey");
			UserConnection.SessionData[insertedRowValueKey] = sb.ToString();
			Page.AddScript("window.close();");
			return true;
		}

		public virtual bool CancelButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			((Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			LocalizableParameterValuesList items = GetItems();
			if (items == null) {
				return true;
			}
			object idParam = Page.GetParameterValue("itemId");
			IsNew = (idParam == null);
			if (IsNew) {
				ItemId = Guid.NewGuid();
			} else {
				ItemId = new Guid(idParam.ToString());
			}
			
			if (!IsNew) {
				var item = items.Find(el => new Guid(el["Id"].Value) == ItemId);
				if (item != null) {
					Page.AnswerEdit.SetValue(item["Caption"].Value);
					Page.CheckedEdit.Checked = bool.Parse(item["DefChecked"].Value);
				}
			}
			bool checkedEditEnabled = true;
			foreach(var item in items) {
				if ((new Guid(item["Id"].Value) != ItemId) && bool.Parse(item["DefChecked"].Value)) {
					checkedEditEnabled = false;
				}
			}
			Page.CheckedEdit.Enabled = checkedEditEnabled;
			Page.OkButton.AjaxEvents.Click.CausesValidation = true;
			return true;
		}

		public virtual LocalizableParameterValues AddItem() {
			string contextKey = Page.GetParameterValue("contextKey").ToString();
			var items = UserConnection.SessionData[contextKey] as LocalizableParameterValuesList;
			if (items == null) {
				return null;
			}
			LocalizableParameterValues item = null;
			string answerText = Page.AnswerEdit.Text;
			if (IsNew) {
				int maxIndex = items.Count == 0 ? -1 : items.Select(c => {
					var match = Regex.Match((string)c["Name"].Value, "[0-9]+");
					return Int32.Parse(match.Value);
				}).Aggregate((max, current) => Math.Max(max, current));
				maxIndex++;
				item = new LocalizableParameterValues {
					{ "Id", Guid.NewGuid(), false },
					{ "Name", "Decision" + maxIndex, false },
					{ "Caption", answerText, true },
					{ "DefChecked", Page.CheckedEdit.Checked, false }
				};
				items.Add(item);
			} else {
				item = items.Find(c => new Guid(c["Id"].Value) == ItemId);
				if (item != null) {
					LocalizableParameterValue parameterValue = item["Caption"];
					if (parameterValue == null) {
						item["Caption"] = new LocalizableParameterValue(answerText, true);
					} else {
						parameterValue.LocalizableValue.Value = answerText;
					}
					item["DefChecked"] = new LocalizableParameterValue(Page.CheckedEdit.Checked.ToString(), false);
				}
			}
			UserConnection.SessionData[contextKey] = items;
			return item;
		}

		public virtual LocalizableParameterValuesList GetItems() {
			object contextKey = Page.GetParameterValue("contextKey");
			if (contextKey == null || UserConnection.SessionData[contextKey.ToString()] == null) {
				return null;
			}
			var items = (LocalizableParameterValuesList)UserConnection.SessionData[contextKey.ToString()];
			return items;
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
			if (!HasMapping("ItemId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ItemId", ItemId, Guid.Empty);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AnswerEditPageEventsProcess

	/// <exclude/>
	public class AnswerEditPageEventsProcess : AnswerEditPageEventsProcess<Terrasoft.WebApp.AnswerEditPageSchemaUserControl>
	{

		public AnswerEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AnswerEditPageSchemaUserControl

	/// <exclude/>
	public partial class AnswerEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit AnswerEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("AnswerEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox CheckedEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("CheckedEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
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
			var process = (AnswerEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AnswerEditPageEventsProcess(UserConnection);
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
			SchemaName = "AnswerEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AnswerEditPageEventsProcessSchema

	/// <exclude/>
	public class AnswerEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public AnswerEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AnswerEditPageEventsProcessSchema(AnswerEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AnswerEditPageEventsProcess";
			UId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c");
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

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("01ab9ed4-d630-4241-aa66-09e5e8189829"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateItemIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cc6ef68d-07ae-44d2-a070-49e18eb31c30"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"ItemId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateItemIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet57 = CreateLaneSet57LaneSet();
			LaneSets.Add(schemaLaneSet57);
			ProcessSchemaLane schemaLane160 = CreateLane160Lane();
			schemaLaneSet57.Lanes.Add(schemaLane160);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOkButtonClickScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage = CreateCancelButtonClickStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(cancelbuttonclickstartmessage);
			ProcessSchemaScriptTask cancelbuttonclickscripttask = CreateCancelButtonClickScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(cancelbuttonclickscripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(pageloadcompletescripttask);
			FlowElements.Add(CreateSequenceFlow504SequenceFlow());
			FlowElements.Add(CreateSequenceFlow505SequenceFlow());
			FlowElements.Add(CreateSequenceFlow506SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSchemaLocalizableString1LocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSchemaLocalizableString1LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("94883ab9-fb42-418c-b673-629de6da83b2"),
				Name = "SchemaLocalizableString1",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow504SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow504",
				UId = new Guid("683bd5c6-f22a-4389-8eae-49459bd5bb00"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f4408710-e402-4756-a1b9-30d8898db93c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0d84c3d4-207a-4f6e-b6f4-bcc0b9b5785c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(133, 71));
			schemaFlow.PolylinePointPositions.Add(new Point(133, 75));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow505SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow505",
				UId = new Guid("9ca796a3-4f5e-4402-ac8a-c62bd23a80ac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				CurveCenterPosition = new Point(174, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("858ff537-9f6e-4478-af81-db946ff9683a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ec6f7ed6-4316-4ffb-8eb7-fb1afd78a00f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow506SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow506",
				UId = new Guid("c7f21bc5-4083-4001-a2bd-45295711a462"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d206d9ab-4120-43d2-b914-ac8d921e1f78"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6fb6516b-cf69-4f16-a6d5-1ba18e7fea44"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet57LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet57 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("10b7b5d7-3f41-4382-b6b2-3ae717b2866c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"LaneSet57",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1309, 158),
				UseBackgroundMode = false
			};
			return schemaLaneSet57;
		}

		protected virtual ProcessSchemaLane CreateLane160Lane() {
			ProcessSchemaLane schemaLane160 = new ProcessSchemaLane(this) {
				UId = new Guid("ad48f24d-0426-4ebd-b65d-27c6b5f6fd89"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("10b7b5d7-3f41-4382-b6b2-3ae717b2866c"),
				CreatedInOwnerSchemaUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"Lane160",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1280, 158),
				UseBackgroundMode = false
			};
			return schemaLane160;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f8411171-98fa-4fd5-a5fa-30e839cc2365"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ad48f24d-0426-4ebd-b65d-27c6b5f6fd89"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 6),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f4408710-e402-4756-a1b9-30d8898db93c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8411171-98fa-4fd5-a5fa-30e839cc2365"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(28, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0d84c3d4-207a-4f6e-b6f4-bcc0b9b5785c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8411171-98fa-4fd5-a5fa-30e839cc2365"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"OkButtonClickScriptTask",
				Position = new Point(140, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,143,218,48,16,61,131,196,127,112,115,193,145,80,212,251,106,165,165,236,106,69,91,173,80,105,247,130,56,152,100,160,86,141,141,108,135,116,187,226,191,119,198,78,72,82,224,208,19,100,62,222,123,243,108,207,87,147,11,37,255,136,141,130,133,176,98,15,30,236,171,80,37,56,38,61,236,217,61,155,22,197,28,255,241,244,110,52,148,91,198,99,248,158,233,82,169,148,189,143,134,3,11,190,180,154,121,91,2,214,156,70,67,231,173,212,59,230,192,74,2,135,0,128,80,159,157,209,217,178,137,114,13,85,232,159,23,152,35,216,85,50,47,146,117,22,248,39,152,120,65,61,231,20,125,116,147,51,113,240,210,232,115,190,254,238,150,60,194,118,246,19,242,95,64,4,27,99,84,134,51,58,224,177,161,205,54,61,41,170,167,49,143,194,50,183,193,30,82,184,12,195,124,42,165,42,192,242,135,132,111,75,157,19,19,143,211,83,177,183,0,207,86,18,77,37,117,97,170,236,233,183,207,118,224,103,251,3,31,39,132,233,54,217,244,112,0,93,240,133,216,65,246,12,190,239,55,79,26,16,244,32,237,119,60,36,99,10,12,200,254,15,77,89,100,175,205,167,236,169,22,83,8,47,150,166,180,57,121,215,84,103,109,244,140,212,134,46,177,146,230,184,231,238,5,170,152,239,10,162,114,34,179,166,66,150,22,41,203,45,8,15,223,76,197,3,68,167,169,127,29,254,73,62,196,234,65,7,9,161,93,38,53,182,121,254,113,66,76,228,232,194,202,189,176,111,51,163,202,189,142,206,165,33,121,209,239,192,79,241,160,142,65,204,181,130,173,180,240,116,4,237,249,56,210,64,49,158,116,102,9,176,19,246,206,240,82,4,121,39,6,202,193,77,47,242,160,201,161,31,255,57,250,221,77,55,113,96,82,95,35,175,250,153,158,21,244,60,120,186,142,67,110,141,101,188,149,20,222,145,212,141,192,250,180,7,228,40,154,212,181,178,173,159,52,213,171,54,86,163,159,110,251,136,144,202,136,226,194,200,21,113,213,128,235,158,165,253,123,78,15,144,215,41,210,223,156,11,154,16,4,126,129,55,52,136,199,5,147,222,122,73,87,186,2,226,15,12,207,140,214,16,222,47,110,34,231,240,247,17,117,174,174,180,172,145,9,181,125,55,113,3,132,5,24,24,113,35,46,115,43,15,158,39,245,107,207,149,193,181,82,235,238,174,195,191,244,92,185,169,95,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("02eea287-b9d9-4833-b8ab-f6184048d9d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ad48f24d-0426-4ebd-b65d-27c6b5f6fd89"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"EventSubProcess3",
				Position = new Point(287, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(221, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d206d9ab-4120-43d2-b914-ac8d921e1f78"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02eea287-b9d9-4833-b8ab-f6184048d9d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"CancelButtonClickStartMessage",
				Position = new Point(28, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6fb6516b-cf69-4f16-a6d5-1ba18e7fea44"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02eea287-b9d9-4833-b8ab-f6184048d9d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"CancelButtonClickScriptTask",
				Position = new Point(126, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,72,76,79,213,4,17,122,142,197,5,96,142,158,115,78,126,113,170,134,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,160,144,205,48,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3ce45552-dece-4024-be1a-c8e76f912034"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ad48f24d-0426-4ebd-b65d-27c6b5f6fd89"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 170),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("858ff537-9f6e-4478-af81-db946ff9683a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ce45552-dece-4024-be1a-c8e76f912034"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ec6f7ed6-4316-4ffb-8eb7-fb1afd78a00f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ce45552-dece-4024-be1a-c8e76f912034"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,205,110,194,48,16,132,207,32,241,14,38,7,228,92,252,2,136,74,52,165,85,36,212,34,81,245,130,122,48,201,6,12,198,174,252,3,85,43,222,189,182,99,146,32,56,244,148,40,158,253,102,118,156,185,44,40,103,63,116,205,97,65,21,61,128,1,245,65,185,5,61,103,218,32,102,224,160,209,4,189,128,201,253,43,78,199,131,62,171,16,142,7,19,36,44,231,41,250,29,244,123,10,140,85,2,25,101,193,137,206,131,190,92,239,160,112,140,50,144,29,101,65,55,64,28,234,218,9,39,30,150,151,137,103,231,250,21,78,78,138,155,169,104,17,125,195,121,237,151,135,41,31,206,178,146,184,207,254,25,2,158,17,112,13,215,34,225,176,65,16,193,228,93,46,141,98,98,131,211,180,142,91,27,12,59,14,71,170,66,3,110,60,236,75,158,153,40,49,112,52,121,104,121,192,87,137,11,255,73,194,50,169,15,92,155,122,108,239,210,21,26,118,171,234,133,38,166,66,159,64,205,74,102,200,18,76,221,133,215,174,146,140,126,25,38,69,3,29,55,51,217,22,138,61,148,97,40,190,187,116,107,41,57,113,107,233,11,224,9,170,120,122,197,56,135,69,189,26,21,45,104,38,252,245,123,78,188,187,74,42,160,197,22,55,251,51,81,23,80,167,247,59,225,182,207,96,216,109,96,216,52,128,70,163,127,101,139,173,220,205,84,81,119,151,109,248,155,22,90,229,237,248,56,234,223,246,143,214,24,41,200,116,71,191,103,71,16,70,147,140,179,98,79,50,106,53,104,151,130,149,212,87,222,150,208,253,157,255,0,181,17,189,2,38,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateAddItemMethod());
			Methods.Add(CreateGetItemsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2b2fd53a-8e5b-4488-8292-b194e735ab9f"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6d5a794f-9c1d-4fe5-ab25-78f43000738a"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9ecb85dd-8cfd-4600-bf45-d0869cc35631"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6d3f339a-511c-44fc-8b87-3c45a0e77eec"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateAddItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f4e511d1-15bd-447f-b2e9-b44777b84ec3"),
				Name = "AddItem",
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "LocalizableParameterValues"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,193,110,155,64,16,61,195,87,76,57,129,76,86,105,123,106,145,91,89,118,27,161,166,81,84,39,185,88,62,108,97,140,87,197,75,180,187,212,52,150,255,189,179,11,24,219,146,155,158,96,118,223,204,188,55,111,64,27,37,100,1,89,37,13,54,230,27,254,129,49,220,243,2,217,13,154,123,174,248,6,13,170,39,94,214,24,6,3,40,136,216,67,53,119,169,97,148,248,191,185,2,97,112,163,41,249,81,163,154,86,82,98,102,68,37,217,28,181,166,231,140,27,190,24,242,151,192,53,220,86,25,47,197,11,255,89,226,105,39,125,43,180,73,124,177,130,176,171,58,6,89,151,101,4,59,223,83,104,106,37,93,156,248,123,255,114,17,199,8,198,29,82,183,58,185,212,91,84,15,196,162,215,57,113,39,95,114,97,152,61,110,219,166,250,14,183,174,157,144,6,54,188,73,101,142,13,165,56,62,108,90,213,116,76,172,174,225,51,92,189,133,143,221,249,28,75,146,29,102,48,254,100,115,61,59,151,13,55,217,154,50,127,96,129,13,251,110,163,48,108,217,68,217,34,184,35,202,193,146,57,202,49,4,139,235,171,15,203,81,64,51,245,122,165,169,52,239,223,49,18,167,49,116,197,90,176,133,236,35,54,41,10,133,5,55,24,210,101,19,67,86,43,133,210,68,150,2,53,91,83,199,230,244,198,38,246,138,70,35,10,250,57,225,246,31,150,56,61,59,8,210,60,136,225,166,22,57,163,9,217,103,24,197,176,226,165,70,216,199,45,196,73,34,45,51,204,132,245,62,128,209,97,132,231,216,41,127,182,107,66,240,193,153,24,140,170,7,200,12,87,211,53,102,191,208,118,118,150,117,161,243,172,123,63,212,165,161,116,146,52,155,228,185,91,32,82,188,7,180,215,187,131,218,22,241,85,200,188,181,203,170,119,114,200,19,210,216,57,18,89,147,83,130,166,185,29,91,191,145,240,230,104,33,189,139,67,131,231,211,176,237,186,56,136,94,90,151,109,205,115,220,113,117,239,44,231,53,167,194,243,65,186,93,26,244,123,222,105,55,118,84,169,61,232,201,14,133,92,5,191,167,114,100,200,235,108,46,25,118,244,255,232,188,115,11,77,95,244,127,254,64,58,11,19,191,251,76,108,148,252,5,178,143,199,115,206,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aa61b4c5-dcfa-404b-9b49-28e79eb8f987"),
				Name = "GetItems",
				CreatedInSchemaUId = new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "LocalizableParameterValuesList"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,142,189,10,194,48,20,133,103,243,20,151,78,201,210,23,8,157,20,28,236,80,168,186,136,195,109,185,150,72,154,64,114,35,254,212,119,183,20,165,58,58,29,46,156,239,126,199,55,103,106,25,90,239,152,174,188,161,27,20,80,97,71,249,154,184,194,128,61,49,133,61,218,68,50,155,75,153,210,194,156,64,126,99,5,184,100,45,12,3,236,34,133,165,119,110,124,108,188,203,107,138,113,204,21,50,30,102,32,223,250,154,131,113,157,84,199,15,172,224,33,22,129,56,5,55,221,90,60,197,5,3,24,166,62,142,195,100,233,91,180,230,142,141,165,223,113,177,52,145,213,223,98,45,222,182,201,160,95,219,115,126,98,13,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AnswerEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3e9d3c4-1659-4fcb-9495-6508a5e1cb3c"));
		}

		#endregion

	}

	#endregion

}

