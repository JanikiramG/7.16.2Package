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

	#region Class: CurrencyRateEditPageSchema

	/// <exclude/>
	public class CurrencyRateEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _startDateEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit StartDateEdit {
			get {
				return _startDateEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FloatEdit _rateEdit;
		public Terrasoft.UI.WebControls.Controls.FloatEdit RateEdit {
			get {
				return _rateEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public CurrencyRateEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CurrencyRateEditPageSchema(CurrencyRateEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.AutoScroll = false;
			MainControlLayout.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			RealUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			Name = "CurrencyRateEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCurrencyRateEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateStartDateEdit());
			ControlLayout1.InsertItem(1, CreateRateEdit());
			MainControlLayout.MoveItem(1, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateCurrencyRateEditPageEventsProcessSchema() {
			var schema = new CurrencyRateEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateStartDateEdit() {
			_startDateEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_startDateEdit.UId = new Guid("ebaac00e-7477-496d-bc70-71b4243278f8");
			_startDateEdit.Name = "StartDateEdit";
			_startDateEdit.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			_startDateEdit.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			_startDateEdit.CreatedInPackageId = Guid.Empty;
			_startDateEdit.Tag = "";
			_startDateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_startDateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_startDateEdit.DataSource = "DataSource";
			_startDateEdit.ColumnUId = new Guid("932567fb-bca2-4dc7-94df-3c61b277baa2");
			_startDateEdit.Kind = Terrasoft.Common.DateTimeValueKind.Date;
			return _startDateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FloatEdit CreateRateEdit() {
			_rateEdit = new Terrasoft.UI.WebControls.Controls.FloatEdit();
			_rateEdit.UId = new Guid("aa7dbd29-590b-4b52-99d5-26f5df4dccf7");
			_rateEdit.Name = "RateEdit";
			_rateEdit.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			_rateEdit.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			_rateEdit.CreatedInPackageId = Guid.Empty;
			_rateEdit.Tag = "";
			_rateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_rateEdit.Image = new ControlImage {};
			_rateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_rateEdit.DataSource = "DataSource";
			_rateEdit.ColumnUId = new Guid("4a52989c-9d0d-49fc-aaac-5dd509a383c1");
			return _rateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("27821597-9873-4eb3-909f-87b5926aaea4");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			_controlLayout1.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			_controlLayout1.CreatedInPackageId = Guid.Empty;
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			DataSource.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("eec48a7d-63c5-4969-a398-a846e7a07693");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("d87aa597-929a-461b-9b99-5a30b4099bbc");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("e6b83155-e88a-43c7-a7ca-8328affc5036");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e77ec7b0-471e-45e8-ac00-54232c8c43f0");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("67f6b230-515a-4de5-9db0-6a57507172df");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("fffa677c-647e-4b47-9a24-8fb2639fe3a4");
			if (column != null) {
				column.UId = new Guid("932567fb-bca2-4dc7-94df-3c61b277baa2");
				column.Name = @"StartDate";
				column.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b4b497ac-79b3-4db1-a75a-f80d9039f3ea");
			if (column != null) {
				column.UId = new Guid("ed1f0bcc-a2c7-4e26-bf8b-3828a5f46c36");
				column.Name = @"EndDate";
				column.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("84ce4c1c-f001-4109-86fa-c9b36e8fd5d7");
			if (column != null) {
				column.UId = new Guid("2fd4cd66-1461-4500-a6e3-eec4bb18bd01");
				column.Name = @"Currency";
				column.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8484fcf9-f40d-48a1-a787-aba9e26c1fb0");
			if (column != null) {
				column.UId = new Guid("4a52989c-9d0d-49fc-aaac-5dd509a383c1");
				column.Name = @"Rate";
				column.CreatedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
				column.ModifiedInSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
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
			return new CurrencyRateEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CurrencyRateEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91efca06-166a-4181-a42e-b9651f192b0e"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CurrencyRateEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRateEditPageEventsProcess

	/// <exclude/>
	public class CurrencyRateEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CurrencyRateEditPageSchemaUserControl
	{

		public CurrencyRateEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CurrencyRateEditPageEventsProcess";
			SchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("91efca06-166a-4181-a42e-b9651f192b0e");
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

		private ProcessFlowElement _currencyRateEditPageInitEventSubProcess;
		public ProcessFlowElement CurrencyRateEditPageInitEventSubProcess {
			get {
				return _currencyRateEditPageInitEventSubProcess ?? (_currencyRateEditPageInitEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CurrencyRateEditPageInitEventSubProcess",
					SchemaElementUId = new Guid("ffa9f5fa-8bec-47f1-bc80-76004d116053"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyRateEditPageInitStartMessage;
		public ProcessFlowElement CurrencyRateEditPageInitStartMessage {
			get {
				return _currencyRateEditPageInitStartMessage ?? (_currencyRateEditPageInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyRateEditPageInitStartMessage",
					SchemaElementUId = new Guid("43348fba-3753-4ef8-a02e-1b7fb0d26365"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _currencyRateEditPageInitScriptTask;
		public ProcessScriptTask CurrencyRateEditPageInitScriptTask {
			get {
				return _currencyRateEditPageInitScriptTask ?? (_currencyRateEditPageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrencyRateEditPageInitScriptTask",
					SchemaElementUId = new Guid("93c26f79-2ef9-4d2b-926d-19848879a252"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrencyRateEditPageInitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteEventSubProcess;
		public ProcessFlowElement PageLoadCompleteEventSubProcess {
			get {
				return _pageLoadCompleteEventSubProcess ?? (_pageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyRateEditPagePageLoadCompleteStartMessage;
		public ProcessFlowElement CurrencyRateEditPagePageLoadCompleteStartMessage {
			get {
				return _currencyRateEditPagePageLoadCompleteStartMessage ?? (_currencyRateEditPagePageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyRateEditPagePageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("69d0bfa6-0f17-40c2-8f75-b6b52ee6a9be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _currencyRateEditPagePageLoadCompleteScriptTask;
		public ProcessScriptTask CurrencyRateEditPagePageLoadCompleteScriptTask {
			get {
				return _currencyRateEditPagePageLoadCompleteScriptTask ?? (_currencyRateEditPagePageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrencyRateEditPagePageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("4ec35cfe-a23d-4208-b0bc-81e396986ace"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrencyRateEditPagePageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _currencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent CurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _currencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent ?? (_currencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "CurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("aa2592b6-bb00-452f-bcba-fd7c56e9e4e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[CurrencyRateEditPageInitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditPageInitEventSubProcess };
			FlowElements[CurrencyRateEditPageInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditPageInitStartMessage };
			FlowElements[CurrencyRateEditPageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditPageInitScriptTask };
			FlowElements[PageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess };
			FlowElements[CurrencyRateEditPagePageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditPagePageLoadCompleteStartMessage };
			FlowElements[CurrencyRateEditPagePageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditPagePageLoadCompleteScriptTask };
			FlowElements[CurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "CurrencyRateEditPageInitEventSubProcess":
						break;
					case "CurrencyRateEditPageInitStartMessage":
						e.Context.QueueTasks.Enqueue("CurrencyRateEditPageInitScriptTask");
						break;
					case "CurrencyRateEditPageInitScriptTask":
						break;
					case "PageLoadCompleteEventSubProcess":
						break;
					case "CurrencyRateEditPagePageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("CurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "CurrencyRateEditPagePageLoadCompleteScriptTask":
						break;
					case "CurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("CurrencyRateEditPagePageLoadCompleteScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CurrencyRateEditPageInitStartMessage");
			ActivatedEventElements.Add("CurrencyRateEditPagePageLoadCompleteStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "CurrencyRateEditPageInitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencyRateEditPageInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateEditPageInitStartMessage";
					result = CurrencyRateEditPageInitStartMessage.Execute(context);
					break;
				case "CurrencyRateEditPageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateEditPageInitScriptTask";
					result = CurrencyRateEditPageInitScriptTask.Execute(context, CurrencyRateEditPageInitScriptTaskExecute);
					break;
				case "PageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencyRateEditPagePageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateEditPagePageLoadCompleteStartMessage";
					result = CurrencyRateEditPagePageLoadCompleteStartMessage.Execute(context);
					break;
				case "CurrencyRateEditPagePageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateEditPagePageLoadCompleteScriptTask";
					result = CurrencyRateEditPagePageLoadCompleteScriptTask.Execute(context, CurrencyRateEditPagePageLoadCompleteScriptTaskExecute);
					break;
				case "CurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = CurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool CurrencyRateEditPageInitScriptTaskExecute(ProcessExecutingContext context) {
			// Create event handler for "BeforeInsert" event
			// New row can be accessible only from here
			Page.DataSource.BeforeInsert += delegate(object sender, DataSourceEventArgs e) {
				if (IsNew) {
					// Set start date to current date if currency rate is new
					e.Row.SetColumnValue("StartDate", DateTime.Today);
					
					/*
					// Set currency devision
					var currencyColumn = e.Row.Schema.Columns.FindByName("Currency");
						if (currencyColumn != null) {
						EntitySchemaQuery esq = new EntitySchemaQuery(
							UserConnection.EntitySchemaManager.GetInstanceByName("Currency"));
						var queryColumn = esq.AddColumn("Division");
						
						Entity currency = esq.GetEntity(Page.UserConnection,
							e.Row.GetColumnValue(currencyColumn.ColumnValueName));
						if (currency != null) {
							e.Row.SetColumnValue("Division", currency.GetColumnValue(queryColumn.Name));
						}
					}
					*/
				}
			};
			return true;
		}

		public virtual bool CurrencyRateEditPagePageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			// Specify max and min value for Number control
			Page.RateEdit.MaxValue = Decimal.MaxValue;
			Page.RateEdit.MinValue = 0;
			Guid selectedNodeId;
			if (Guid.TryParse(Page.Request.QueryString["ParentEntityId"], out selectedNodeId)) {
				Page.DataSource.ActiveRow.SetColumnValue("CurrencyId", selectedNodeId);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("CurrencyRateEditPageInitStartMessage")) {
							context.QueueTasks.Enqueue("CurrencyRateEditPageInitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("CurrencyRateEditPagePageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("CurrencyRateEditPagePageLoadCompleteStartMessage");
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

	#region Class: CurrencyRateEditPageEventsProcess

	/// <exclude/>
	public class CurrencyRateEditPageEventsProcess : CurrencyRateEditPageEventsProcess<Terrasoft.WebApp.CurrencyRateEditPageSchemaUserControl>
	{

		public CurrencyRateEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CurrencyRateEditPageSchemaUserControl

	/// <exclude/>
	public partial class CurrencyRateEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit StartDateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("StartDateEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FloatEdit RateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FloatEdit)PageContainer.FindPageControl("RateEdit", true);
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
			var process = (CurrencyRateEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CurrencyRateEditPageEventsProcess(UserConnection);
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
			SchemaName = "CurrencyRateEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRateEditPageEventsProcessSchema

	/// <exclude/>
	public class CurrencyRateEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CurrencyRateEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CurrencyRateEditPageEventsProcessSchema(CurrencyRateEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CurrencyRateEditPageEventsProcess";
			UId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet252 = CreateLaneSet252LaneSet();
			LaneSets.Add(schemaLaneSet252);
			ProcessSchemaLane schemaLane699 = CreateLane699Lane();
			schemaLaneSet252.Lanes.Add(schemaLane699);
			ProcessSchemaEventSubProcess currencyrateeditpageiniteventsubprocess = CreateCurrencyRateEditPageInitEventSubProcessEventSubProcess();
			FlowElements.Add(currencyrateeditpageiniteventsubprocess);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess = CreatePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess);
			ProcessSchemaStartMessageEvent currencyrateeditpageinitstartmessage = CreateCurrencyRateEditPageInitStartMessageStartMessageEvent();
			currencyrateeditpageiniteventsubprocess.FlowElements.Add(currencyrateeditpageinitstartmessage);
			ProcessSchemaScriptTask currencyrateeditpageinitscripttask = CreateCurrencyRateEditPageInitScriptTaskScriptTask();
			currencyrateeditpageiniteventsubprocess.FlowElements.Add(currencyrateeditpageinitscripttask);
			ProcessSchemaStartMessageEvent currencyrateeditpagepageloadcompletestartmessage = CreateCurrencyRateEditPagePageLoadCompleteStartMessageStartMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(currencyrateeditpagepageloadcompletestartmessage);
			ProcessSchemaScriptTask currencyrateeditpagepageloadcompletescripttask = CreateCurrencyRateEditPagePageLoadCompleteScriptTaskScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(currencyrateeditpagepageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent currencyrateeditpagepageloadcompleteintermediatethrowmessageevent = CreateCurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(currencyrateeditpagepageloadcompleteintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow4087SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4088SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4089SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4087SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4087",
				UId = new Guid("76c21413-183a-4c83-a3d6-9d84d82cf0f2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				CurveCenterPosition = new Point(168, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("43348fba-3753-4ef8-a02e-1b7fb0d26365"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("93c26f79-2ef9-4d2b-926d-19848879a252"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4088SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4088",
				UId = new Guid("9dc56d83-8fbf-43b8-98f9-6fdd640a0253"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				CurveCenterPosition = new Point(215, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aa2592b6-bb00-452f-bcba-fd7c56e9e4e5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ec35cfe-a23d-4208-b0bc-81e396986ace"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4089SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4089",
				UId = new Guid("bdd88def-415f-4e6f-bfe1-1b92935aa241"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				CurveCenterPosition = new Point(215, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69d0bfa6-0f17-40c2-8f75-b6b52ee6a9be"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aa2592b6-bb00-452f-bcba-fd7c56e9e4e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet252LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet252 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("06170736-1f5c-4bb2-95c2-0e0bd5974fc4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"LaneSet252",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(718, 338),
				UseBackgroundMode = false
			};
			return schemaLaneSet252;
		}

		protected virtual ProcessSchemaLane CreateLane699Lane() {
			ProcessSchemaLane schemaLane699 = new ProcessSchemaLane(this) {
				UId = new Guid("ca0cbac0-7350-40e4-bdf6-3714dce8c81c"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("06170736-1f5c-4bb2-95c2-0e0bd5974fc4"),
				CreatedInOwnerSchemaUId = new Guid("91efca06-166a-4181-a42e-b9651f192b0e"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"Lane699",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(689, 338),
				UseBackgroundMode = false
			};
			return schemaLane699;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCurrencyRateEditPageInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCurrencyRateEditPageInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ffa9f5fa-8bec-47f1-bc80-76004d116053"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0cbac0-7350-40e4-bdf6-3714dce8c81c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CurrencyRateEditPageInitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCurrencyRateEditPageInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencyRateEditPageInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("43348fba-3753-4ef8-a02e-1b7fb0d26365"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ffa9f5fa-8bec-47f1-bc80-76004d116053"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CurrencyRateEditPageInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCurrencyRateEditPageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("93c26f79-2ef9-4d2b-926d-19848879a252"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ffa9f5fa-8bec-47f1-bc80-76004d116053"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CurrencyRateEditPageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,205,142,218,48,16,62,147,167,152,230,20,182,200,121,0,196,97,151,253,209,30,186,106,203,182,119,147,124,64,86,137,45,198,14,40,170,246,221,59,142,17,9,160,61,68,214,120,252,253,205,36,207,105,201,208,30,132,3,140,167,157,54,101,13,166,141,101,74,31,32,7,94,141,3,251,52,62,72,242,156,222,112,36,182,71,42,180,161,53,72,23,5,156,171,214,53,200,154,186,163,13,219,134,118,96,36,63,245,22,234,81,123,189,178,45,23,80,99,62,250,190,160,18,53,182,162,157,217,245,7,10,79,14,166,4,207,104,128,60,5,205,123,222,58,194,148,254,37,147,106,67,217,171,19,3,125,53,17,51,43,8,206,107,33,44,67,10,111,169,104,153,67,148,190,22,64,172,139,142,184,191,112,100,112,20,44,212,111,123,84,2,95,218,186,109,204,95,93,183,200,210,85,160,18,125,164,189,13,188,87,13,212,187,45,117,55,157,11,40,104,222,13,194,103,234,18,135,202,85,214,72,235,160,249,124,31,169,105,65,39,177,98,135,70,171,120,235,212,115,101,202,135,238,77,55,162,187,60,33,210,94,166,207,121,69,242,109,65,166,173,235,24,124,242,100,124,229,187,72,248,171,5,119,4,183,23,33,201,70,55,189,44,32,38,127,100,236,75,107,140,76,90,156,170,241,171,31,218,200,170,88,189,192,203,118,188,54,5,110,141,69,103,33,222,62,144,14,217,220,94,221,151,101,172,179,244,177,138,163,56,37,25,204,14,211,138,24,17,139,141,172,255,79,46,237,205,122,203,113,108,47,151,59,186,156,139,26,181,130,227,233,237,0,175,70,247,197,230,207,190,103,103,163,215,202,163,220,106,164,245,153,196,239,46,79,228,252,156,39,12,223,178,33,207,45,230,255,1,81,189,77,152,97,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0cbac0-7350-40e4-bdf6-3714dce8c81c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"PageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(348, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencyRateEditPagePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("69d0bfa6-0f17-40c2-8f75-b6b52ee6a9be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CurrencyRateEditPagePageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCurrencyRateEditPagePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4ec35cfe-a23d-4208-b0bc-81e396986ace"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CurrencyRateEditPagePageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,207,63,75,3,65,16,5,240,218,253,20,195,85,23,8,27,251,195,66,146,32,41,12,49,39,54,98,49,238,206,133,133,253,163,115,51,49,135,248,221,189,36,104,113,237,188,199,143,55,139,5,180,31,228,66,55,64,194,19,96,246,144,66,134,35,70,37,232,10,195,86,211,59,49,184,146,133,75,52,59,60,144,221,163,208,218,7,177,143,120,122,185,52,239,96,53,34,9,227,255,169,153,86,67,254,171,222,54,230,65,131,135,158,34,57,33,191,45,158,54,190,49,161,131,250,28,216,103,30,118,200,61,213,87,130,62,149,122,177,79,74,60,180,194,33,31,94,171,49,167,44,235,44,65,134,141,175,222,230,80,84,38,226,108,6,223,230,230,98,172,80,176,45,202,142,236,189,147,112,164,125,249,178,45,201,178,68,77,215,97,117,181,84,30,81,119,246,230,83,170,49,63,134,73,148,51,8,143,223,253,2,250,46,228,165,56,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateCurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("aa2592b6-bb00-452f-bcba-fd7c56e9e4e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CurrencyRateEditPagePageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 65),
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CurrencyRateEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"));
		}

		#endregion

	}

	#endregion

}

