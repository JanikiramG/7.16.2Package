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
	using System.Web;
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
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ProcessSchemaParameterValueEditPageSchema

	/// <exclude/>
	public class ProcessSchemaParameterValueEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.PageContainer _pageContainerFormula;
		public Terrasoft.UI.WebControls.Controls.PageContainer PageContainerFormula {
			get {
				return _pageContainerFormula;
			}
		}

		#endregion

		#region Constructors: Public

		public ProcessSchemaParameterValueEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProcessSchemaParameterValueEditPageSchema(ProcessSchemaParameterValueEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
			RealUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
			Name = "ProcessSchemaParameterValueEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProcessSchemaParameterValueEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.InsertItem(0, CreatePageContainerFormula());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateProcessSchemaParameterValueEditPageEventsProcessSchema() {
			var schema = new ProcessSchemaParameterValueEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreatePageContainerFormula() {
			_pageContainerFormula = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_pageContainerFormula.UId = new Guid("80da1364-dfb8-4075-aa7a-754a330547f8");
			_pageContainerFormula.Name = "PageContainerFormula";
			_pageContainerFormula.CreatedInSchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
			_pageContainerFormula.ModifiedInSchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
			_pageContainerFormula.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_pageContainerFormula.Tag = "";
			_pageContainerFormula.PageSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_pageContainerFormula.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_pageContainerFormula.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_pageContainerFormula.StartNewAlignGroup = false;
			_pageContainerFormula.Edges = "";
			return _pageContainerFormula;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ProcessSchemaParameterValueEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ProcessSchemaParameterValueEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63345a55-3c3d-4db7-9557-64b69a430c15"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProcessSchemaParameterValueEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProcessSchemaParameterValueEditPageEventsProcess

	/// <exclude/>
	public class ProcessSchemaParameterValueEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProcessSchemaParameterValueEditPageSchemaUserControl
	{

		public ProcessSchemaParameterValueEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProcessSchemaParameterValueEditPageEventsProcess";
			SchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("63345a55-3c3d-4db7-9557-64b69a430c15");
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

		private ProcessFlowElement _eventSubProcessInit;
		public ProcessFlowElement EventSubProcessInit {
			get {
				return _eventSubProcessInit ?? (_eventSubProcessInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInit",
					SchemaElementUId = new Guid("876dc80f-c303-407f-9dac-393437fd85f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childInitStartMessage;
		public ProcessFlowElement ChildInitStartMessage {
			get {
				return _childInitStartMessage ?? (_childInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInitStartMessage",
					SchemaElementUId = new Guid("2c602458-c209-47e8-8736-9d0ec928fb82"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEventInit;
		public ProcessThrowMessageEvent IntermediateThrowMessageEventInit {
			get {
				return _intermediateThrowMessageEventInit ?? (_intermediateThrowMessageEventInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEventInit",
					SchemaElementUId = new Guid("37bd3bde-a077-40b8-887e-3df32f31ff41"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTaskInitChild;
		public ProcessScriptTask ScriptTaskInitChild {
			get {
				return _scriptTaskInitChild ?? (_scriptTaskInitChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskInitChild",
					SchemaElementUId = new Guid("d1e38a50-3585-4850-8b0a-0ec409626088"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskInitChildExecute,
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
					SchemaElementUId = new Guid("f8a6777d-4adc-4188-ab66-00aea2766998"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessagePageLoadComplete;
		public ProcessFlowElement StartMessagePageLoadComplete {
			get {
				return _startMessagePageLoadComplete ?? (_startMessagePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessagePageLoadComplete",
					SchemaElementUId = new Guid("67bf689d-1fc2-4bf3-82d9-5662e1f39c65"),
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
					SchemaElementUId = new Guid("c9ce0d57-5f75-42b5-8bf0-b34646a85a68"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEventPageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowMessageEventPageLoadComplete {
			get {
				return _intermediateThrowMessageEventPageLoadComplete ?? (_intermediateThrowMessageEventPageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEventPageLoadComplete",
					SchemaElementUId = new Guid("195d13af-00d7-41b7-bfed-7c45210f3f4e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
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
					SchemaElementUId = new Guid("2e39bb4d-6867-4391-ab30-23b32180b8f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("47e4d2f1-fe70-4940-a3b2-ef2ba6b1326d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("ce91b670-94e1-4cce-afdf-bb9993ad15ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _okClickScriptTaskScriptTask;
		public ProcessScriptTask OkClickScriptTaskScriptTask {
			get {
				return _okClickScriptTaskScriptTask ?? (_okClickScriptTaskScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkClickScriptTaskScriptTask",
					SchemaElementUId = new Guid("c47b6bd0-f5a9-4f12-bd74-9bebc7ab5fa5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkClickScriptTaskScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInit };
			FlowElements[ChildInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitStartMessage };
			FlowElements[IntermediateThrowMessageEventInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventInit };
			FlowElements[ScriptTaskInitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskInitChild };
			FlowElements[EventSubProcessPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPageLoadComplete };
			FlowElements[StartMessagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePageLoadComplete };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[IntermediateThrowMessageEventPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventPageLoadComplete };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[OkClickScriptTaskScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkClickScriptTaskScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessInit":
						break;
					case "ChildInitStartMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventInit");
						break;
					case "IntermediateThrowMessageEventInit":
						e.Context.QueueTasks.Enqueue("ScriptTaskInitChild");
						break;
					case "ScriptTaskInitChild":
						break;
					case "EventSubProcessPageLoadComplete":
						break;
					case "StartMessagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventPageLoadComplete");
						break;
					case "IntermediateThrowMessageEventPageLoadComplete":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("OkClickScriptTaskScriptTask");
						break;
					case "OkClickScriptTaskScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildInitStartMessage");
			ActivatedEventElements.Add("StartMessagePageLoadComplete");
			ActivatedEventElements.Add("StartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "ChildInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitStartMessage";
					result = ChildInitStartMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEventInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEventInit.Execute(context);
					break;
				case "ScriptTaskInitChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskInitChild";
					result = ScriptTaskInitChild.Execute(context, ScriptTaskInitChildExecute);
					break;
				case "EventSubProcessPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePageLoadComplete";
					result = StartMessagePageLoadComplete.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEventPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEventPageLoadComplete.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "OkClickScriptTaskScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkClickScriptTaskScriptTask";
					result = OkClickScriptTaskScriptTask.Execute(context, OkClickScriptTaskScriptTaskExecute);
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

		public virtual bool ScriptTaskInitChildExecute(ProcessExecutingContext context) {
			InitializeContextHelpButton();
			if (Ext.IsAjaxRequest) {
				if (SchemaExplorerCreated) {
					InitializeSchemaExplorerWindow();
				}
			} else {
				var formulaPageProcess = GetFormulaPageProcess();
				formulaPageProcess.EditSchemaUId = EditSchemaUId;
				formulaPageProcess.EditSchemaManagerName = EditSchemaManagerName;
				formulaPageProcess.EditElementUId = EditElementUId;
				formulaPageProcess.MessagePanelClientId = Page.MainMessagePanel.ClientID;
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			var key = Page.Request.QueryString["tempUserContextUId"].ToString();
			var values = (Dictionary<string, string>)UserConnection.SessionData[key];
			var serializedValue = values["value"];
			var displayValue = values["displayValue"];
			Page.TempUserContext.Add(serializedValue);
			var provider = new ProcessSchemaParameterValueProvider();
			ProcessSchemaParameterValue deserializedValue = (ProcessSchemaParameterValue)provider
				.DeserializeValue(UserConnection, null, typeof(ProcessSchemaParameterValue), serializedValue.ToString());
			var formulaPageProcess = GetFormulaPageProcess();
			formulaPageProcess.Page.ValueMemoEdit.Required = false;
			formulaPageProcess.Page.InsertParameterButton.Hidden = EditSchemaManagerName == "ProcessUserTaskSchemaManager";
			// Условие key == "PageContainer_RecepientEdit".
			// Временное решение для устранения ошибки, которая возникает при выборе значения из справочника, в окне формулы,
			// для поля "Кому" в карточке редактирования параметров действия "Email" процесса (CRM-10331).
			// Суть ошибки в том, что колонка DataSource(для поля RecepientEdit) на карточке формируется на основании типа
			// параметра Recepient из действия EmailUserTask, т.е. строковая колонка. Следовательно такая колонка не хранит в
			// себе информации о ReferenceSchemaUId который нам нужен, для открытия справочника в формуле. Тип параметра Recepient
			// из действия EmailUserTask менять нельзя из за соображений совместимости. Фактически получается, что поле 
			// RecepientEdit на карточке это строковое поле, но иногда нам нужно поведение этого поля как lookup. К сожалению у 
			// нас колонки DataSource могут себя вести или как строка или как справочник (что то одно). Для правильного решения 
			// задачи нужно изменить сам подход работы с такими полями на карточках параметров процессов.
			if (key == "PageContainer_RecepientEdit") {
				deserializedValue.ReferenceSchemaUId = new Guid("7F331863-EB75-41AA-985A-B10E46816FF1");
			}
			formulaPageProcess.ReferenceSchemaUId = deserializedValue.ReferenceSchemaUId;
			if (deserializedValue.ReferenceSchemaUId != Guid.Empty) {
				ISchemaManagerItem<EntitySchema> item = UserConnection.EntitySchemaManager
					.FindItemByUId(deserializedValue.ReferenceSchemaUId);
				if (item != null && item.IsInstanceInitialized && item.Instance.IsDynamicallyCreated) {
					formulaPageProcess.ReferenceSchemaUId = Guid.Empty;
				}
			}
			object queryStringValue = Page.Request.QueryString["SamplingSchemaUId"];
			if (queryStringValue != null) {
				formulaPageProcess.SamplingSchemaUId = new Guid(queryStringValue.ToString());
				formulaPageProcess.SamplingSchemaColumnDataValueTypeUId = deserializedValue.DataValueTypeUId;
			}
			UserConnection.SessionData[key] = null;
			string serverMetaPath = deserializedValue.Value;
			if (deserializedValue.Source == ProcessSchemaParameterValueSource.None) {
				return true;
			} else if (deserializedValue.Source == ProcessSchemaParameterValueSource.Script) {
				formulaPageProcess.SetFormulaBody(deserializedValue.Value);
			} else {
				RunConversionParameterValue(deserializedValue, formulaPageProcess);
			}
			return true;
		}

		public virtual bool OkClickScriptTaskScriptTaskExecute(ProcessExecutingContext context) {
			var formulaPageProcess = GetFormulaPageProcess();
			var serializedValue = Page.TempUserContext[0];
			var provider = new ProcessSchemaParameterValueProvider();
			var parameterValue = (ProcessSchemaParameterValue)provider.DeserializeValue(UserConnection,
				null, typeof(ProcessSchemaParameterValue), serializedValue);
			parameterValue.Value = formulaPageProcess.GetFormulaBody();
			parameterValue.DisplayValue = formulaPageProcess.ConvertFormulaTaskBodyToDisplayCode(parameterValue.Value);
			if (string.IsNullOrEmpty(parameterValue.Value)) {
				parameterValue.Source = ProcessSchemaParameterValueSource.None;
			} else {
				parameterValue.Source = ProcessSchemaParameterValueSource.Script;
			}
			string displayValue;
			object outputValue;
			string parameterValueValue = parameterValue.Value;
			string parameterValueDisplayValue = parameterValue.DisplayValue;
			parameterValue.Value = string.Empty;
			parameterValue.DisplayValue = string.Empty;
			provider.SerializeValue(UserConnection, null, typeof(ProcessSchemaParameterValue), parameterValue, out outputValue, out displayValue);
			var script = 
				@"var key = window.name;
				if (window.opener) {
					var parameterEditPageParams = window.opener.window.processSchemaParameterValueEditPageParams[key];
					var sender = parameterEditPageParams.sender;
					var processSchemaParameterValueEditPageCallback = parameterEditPageParams.processSchemaParameterValueEditPageCallback;
					if (sender && processSchemaParameterValueEditPageCallback) { 
						var value = '" + outputValue.ToString() + @"';
						var parameterValue = Ext.util.JSON.decode(value);
						parameterValue.value = '" + parameterValueValue + @"';
						parameterValue.displayValue = '" + parameterValueDisplayValue + @"';
						processSchemaParameterValueEditPageCallback.call(parameterEditPageParams.sender, Ext.util.JSON.encode(parameterValue));
					}
				}
				window.close();";
			Page.AddScript(script);
			return true;
		}

		public override void MakeCaption() {
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Caption = string.Format("{0} {1}", WindowCaption, NewRecord);
		}

		public override void OkClickMethod() {
		}

		public override void InitializeContextHelpButton() {
			base.InitializeContextHelpButton();
		}

		public virtual Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl> GetFormulaPageProcess() {
			var formulaPage = Page.PageContainerFormula.PageInstance as Terrasoft.WebApp.FormulaEditPageSchemaUserControl;
			if (formulaPage != null) {
				return (Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl>)formulaPage.Process;
			}
			return null;
		}

		public virtual void RunConversionParameterValue(ProcessSchemaParameterValue parameterValue, Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl> formulaPageProcess) {
			string value = parameterValue.Value;
			if (string.IsNullOrEmpty(value)) {
				return;
			}
			if (parameterValue.Source == ProcessSchemaParameterValueSource.ConstValue) {
				DataValueTypeManager dataValueTypeManager = UserConnection.DataValueTypeManager;
				IEnumerable<DataValueTypeManagerItem> dataValueTypeItems = dataValueTypeManager.GetItems();
				Guid dataValueTypeUId = parameterValue.DataValueTypeUId;
				DataValueTypeManagerItem dataValueTypeItem = null;
				foreach (DataValueTypeManagerItem item in dataValueTypeItems) {
					if (item.UId == dataValueTypeUId) {
						dataValueTypeItem = item;
						break;
					}
				}
				string displayValue = null;
				if (dataValueTypeItem.GroupName == "Dates") {
					string dateTimeKind = "DateTime";
					if (dataValueTypeItem.Name == "Date") {
						dateTimeKind = dataValueTypeItem.Name;
					} else if (dataValueTypeItem.Name == "Time") {
						dateTimeKind = dataValueTypeItem.Name;
					}
					displayValue = formulaPageProcess.MakeDateTimeValueMacros(DateTime.Parse(value), dateTimeKind);
				} else if (dataValueTypeItem.GroupName == "Strings") {
					bool isNotFirst = value.IndexOf("\"") != 0;
					bool isNotLast = value.LastIndexOf("\"") != value.Length - 1;
					string insStr = "\"";
					if (isNotFirst && isNotLast) {
						displayValue = string.Concat(insStr, value, insStr);
					} else if (isNotFirst) {
						displayValue = string.Concat(insStr, value);
					} else if (isNotLast) {
						displayValue = string.Concat(value, insStr);
					}
				} else if (dataValueTypeItem.GroupName == "Dictionaries" && dataValueTypeItem.Name == "Lookup") {
					EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(parameterValue.ReferenceSchemaUId);
					Entity lookup = new Entity(UserConnection);
					lookup.Schema = entitySchema;
					if (lookup.FetchFromDB(new Guid(value))) {
						var values = new Dictionary<string, object>();
						values.Add("schemaUId", parameterValue.ReferenceSchemaUId.ToString());
						values.Add("selectedValue", value);
						string primaryDisplayColumnValue = lookup.PrimaryDisplayColumnValue == null
							? string.Empty
							: lookup.PrimaryDisplayColumnValue.ToString();
						values.Add(entitySchema.FindPrimaryDisplayColumnName(), primaryDisplayColumnValue);
						formulaPageProcess.TryMakeLookupValueMacros(values, out displayValue);
					}
				} else if (dataValueTypeItem.GroupName == "Others") {
					if (dataValueTypeItem.Name == "Guid") {
						displayValue = string.Concat("new Guid(\"", value, "\")");
					} else if (dataValueTypeItem.Name == "Boolean"){
						displayValue = value.ToLower();
					}
				}
				if (displayValue == null) {
					displayValue = value;
				}
				formulaPageProcess.Page.ValueMemoEdit.Text = displayValue;
			} else if (parameterValue.Source == ProcessSchemaParameterValueSource.SystemValue) {
				Guid sysVariableUId;
				SystemValue sysVariable;
				if (Guid.TryParse(value, out sysVariableUId)) {
					sysVariable = UserConnection.SystemValueManager.GetInstanceByUId(sysVariableUId);
				} else {
					sysVariable = UserConnection.SystemValueManager.GetInstanceByName(value);
				}
				formulaPageProcess.Page.ValueMemoEdit.Text =
					formulaPageProcess.MakeSysVariableMacros(sysVariable.Name, sysVariable.Caption);
			} else if (parameterValue.Source == ProcessSchemaParameterValueSource.SystemSetting) {
				var sysSetting = new Terrasoft.Configuration.SysSettings(UserConnection);
				Guid settingUId;
				if ((Guid.TryParse(value, out settingUId) && sysSetting.FetchFromDB(settingUId))
						|| sysSetting.FetchFromDB("Code", value)) {
					formulaPageProcess.Page.ValueMemoEdit.Text = formulaPageProcess.MakeSysSettingValueMacros(sysSetting.Name, sysSetting.Code);
				}
			} else if (parameterValue.Source == ProcessSchemaParameterValueSource.Mapping) {
				string serverMetaPath = formulaPageProcess.GetPropertyServerMetaPathByClientMetaPath(value);
				string macros = formulaPageProcess.MakeMacros(formulaPageProcess.GetPropertyDisplayPathByServerMetaPath(serverMetaPath));
				var metaParamsDictionary = (Dictionary<string, string>)formulaPageProcess.MetaParamsDictionary;
				if (!metaParamsDictionary.ContainsKey(macros)) {
					metaParamsDictionary.Add(macros, formulaPageProcess.MakeMacros(serverMetaPath));
				}
				formulaPageProcess.Page.ValueMemoEdit.Text = macros;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("ChildInitStartMessage")) {
							context.QueueTasks.Enqueue("ChildInitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessagePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessagePageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
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

	#region Class: ProcessSchemaParameterValueEditPageEventsProcess

	/// <exclude/>
	public class ProcessSchemaParameterValueEditPageEventsProcess : ProcessSchemaParameterValueEditPageEventsProcess<Terrasoft.WebApp.ProcessSchemaParameterValueEditPageSchemaUserControl>
	{

		public ProcessSchemaParameterValueEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProcessSchemaParameterValueEditPageSchemaUserControl

	/// <exclude/>
	public partial class ProcessSchemaParameterValueEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.PageContainer PageContainerFormula {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("PageContainerFormula", true);
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
			var process = (ProcessSchemaParameterValueEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProcessSchemaParameterValueEditPageEventsProcess(UserConnection);
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
			SchemaName = "ProcessSchemaParameterValueEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ProcessSchemaParameterValueEditPageEventsProcessSchema

	/// <exclude/>
	public class ProcessSchemaParameterValueEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ProcessSchemaParameterValueEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProcessSchemaParameterValueEditPageEventsProcessSchema(ProcessSchemaParameterValueEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProcessSchemaParameterValueEditPageEventsProcess";
			UId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaProcessSchemaParameterValueEditPageLaneSet = CreateProcessSchemaParameterValueEditPageLaneSetLaneSet();
			LaneSets.Add(schemaProcessSchemaParameterValueEditPageLaneSet);
			ProcessSchemaLane schemaPageEventsLane = CreatePageEventsLaneLane();
			schemaProcessSchemaParameterValueEditPageLaneSet.Lanes.Add(schemaPageEventsLane);
			ProcessSchemaLane schemaControlEvensLane = CreateControlEvensLaneLane();
			schemaProcessSchemaParameterValueEditPageLaneSet.Lanes.Add(schemaControlEvensLane);
			ProcessSchemaEventSubProcess eventsubprocessinit = CreateEventSubProcessInitEventSubProcess();
			FlowElements.Add(eventsubprocessinit);
			ProcessSchemaEventSubProcess eventsubprocesspageloadcomplete = CreateEventSubProcessPageLoadCompleteEventSubProcess();
			FlowElements.Add(eventsubprocesspageloadcomplete);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent childinitstartmessage = CreateChildInitStartMessageStartMessageEvent();
			eventsubprocessinit.FlowElements.Add(childinitstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventinit = CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent();
			eventsubprocessinit.FlowElements.Add(intermediatethrowmessageeventinit);
			ProcessSchemaScriptTask scripttaskinitchild = CreateScriptTaskInitChildScriptTask();
			eventsubprocessinit.FlowElements.Add(scripttaskinitchild);
			ProcessSchemaStartMessageEvent startmessagepageloadcomplete = CreateStartMessagePageLoadCompleteStartMessageEvent();
			eventsubprocesspageloadcomplete.FlowElements.Add(startmessagepageloadcomplete);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocesspageloadcomplete.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventpageloadcomplete = CreateIntermediateThrowMessageEventPageLoadCompleteIntermediateThrowMessageEvent();
			eventsubprocesspageloadcomplete.FlowElements.Add(intermediatethrowmessageeventpageloadcomplete);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask okclickscripttaskscripttask = CreateOkClickScriptTaskScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(okclickscripttaskscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fbf3c8f8-f5ea-4bc6-8237-3c1e54bd25b4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				CurveCenterPosition = new Point(244, 89),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("37bd3bde-a077-40b8-887e-3df32f31ff41"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d1e38a50-3585-4850-8b0a-0ec409626088"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("72912f0b-d714-4243-acd0-209dfb9c9c01"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				CurveCenterPosition = new Point(154, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2c602458-c209-47e8-8736-9d0ec928fb82"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("37bd3bde-a077-40b8-887e-3df32f31ff41"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("1ec2f16a-b196-42ff-ac01-58333d4ead93"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				CurveCenterPosition = new Point(161, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("67bf689d-1fc2-4bf3-82d9-5662e1f39c65"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c9ce0d57-5f75-42b5-8bf0-b34646a85a68"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("87ba7367-e675-4789-991f-5979169d3f4c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				CurveCenterPosition = new Point(292, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c9ce0d57-5f75-42b5-8bf0-b34646a85a68"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("195d13af-00d7-41b7-bfed-7c45210f3f4e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("1983b946-42a7-431b-80e9-235d0fa9e7fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				CurveCenterPosition = new Point(475, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("47e4d2f1-fe70-4940-a3b2-ef2ba6b1326d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ce91b670-94e1-4cce-afdf-bb9993ad15ba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("f57e5409-a21e-4ba1-8619-232ff536a6fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				CurveCenterPosition = new Point(574, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ce91b670-94e1-4cce-afdf-bb9993ad15ba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c47b6bd0-f5a9-4f12-bd74-9bebc7ab5fa5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateProcessSchemaParameterValueEditPageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaProcessSchemaParameterValueEditPageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5412893b-bfa6-423f-b7fb-07b29927d0f3"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"ProcessSchemaParameterValueEditPageLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1136, 473),
				UseBackgroundMode = false
			};
			return schemaProcessSchemaParameterValueEditPageLaneSet;
		}

		protected virtual ProcessSchemaLane CreatePageEventsLaneLane() {
			ProcessSchemaLane schemaPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("f3a6780d-64aa-4f47-81f5-d029bc9ad822"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5412893b-bfa6-423f-b7fb-07b29927d0f3"),
				CreatedInOwnerSchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"PageEventsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1107, 293),
				UseBackgroundMode = false
			};
			return schemaPageEventsLane;
		}

		protected virtual ProcessSchemaLane CreateControlEvensLaneLane() {
			ProcessSchemaLane schemaControlEvensLane = new ProcessSchemaLane(this) {
				UId = new Guid("d12a0f03-7902-41b3-903d-fca5424e92ff"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("5412893b-bfa6-423f-b7fb-07b29927d0f3"),
				CreatedInOwnerSchemaUId = new Guid("63345a55-3c3d-4db7-9557-64b69a430c15"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"ControlEvensLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 298),
				Size = new Size(1107, 175),
				UseBackgroundMode = false
			};
			return schemaControlEvensLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("876dc80f-c303-407f-9dac-393437fd85f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3a6780d-64aa-4f47-81f5-d029bc9ad822"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"EventSubProcessInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 2),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(277, 119),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2c602458-c209-47e8-8736-9d0ec928fb82"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("876dc80f-c303-407f-9dac-393437fd85f5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"ChildInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("37bd3bde-a077-40b8-887e-3df32f31ff41"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("876dc80f-c303-407f-9dac-393437fd85f5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"IntermediateThrowMessageEventInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskInitChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d1e38a50-3585-4850-8b0a-0ec409626088"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("876dc80f-c303-407f-9dac-393437fd85f5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"ScriptTaskInitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,65,75,195,64,16,133,207,9,228,63,236,177,189,228,15,20,15,26,163,230,16,41,21,241,60,52,175,117,101,179,91,103,103,107,80,250,223,221,36,98,27,138,245,50,48,239,189,239,13,76,101,181,104,50,250,19,133,179,130,78,30,96,118,55,65,196,217,217,124,145,165,122,163,102,101,39,121,229,175,223,168,91,225,61,192,203,92,125,101,105,210,91,79,235,87,180,84,118,59,227,24,92,48,72,208,140,118,82,253,86,79,83,47,218,54,238,99,104,79,14,89,122,80,48,30,3,178,39,86,27,199,109,48,180,164,45,150,236,214,240,94,93,169,123,200,221,153,62,54,156,231,243,178,209,50,158,124,174,154,72,79,246,127,153,154,108,212,249,145,90,76,216,19,253,66,71,105,208,194,202,241,240,81,248,131,170,227,232,87,178,48,133,209,49,59,176,125,36,175,73,219,83,63,255,9,220,198,174,248,58,134,4,182,74,56,96,241,13,27,170,166,155,201,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f8a6777d-4adc-4188-ab66-00aea2766998"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3a6780d-64aa-4f47-81f5-d029bc9ad822"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"EventSubProcessPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 135),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(329, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("67bf689d-1fc2-4bf3-82d9-5662e1f39c65"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8a6777d-4adc-4188-ab66-00aea2766998"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"StartMessagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c9ce0d57-5f75-42b5-8bf0-b34646a85a68"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8a6777d-4adc-4188-ab66-00aea2766998"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,87,93,79,27,71,20,125,38,82,254,195,212,15,145,45,153,77,16,9,161,74,136,196,103,202,3,17,5,210,23,20,85,91,239,144,108,89,239,58,235,49,173,91,33,5,83,74,37,210,34,85,125,202,91,63,126,128,227,198,96,62,108,254,194,238,63,234,185,119,102,253,109,64,170,16,246,122,230,222,115,207,61,115,102,60,222,177,67,177,45,203,98,70,172,218,175,165,181,38,223,150,100,81,89,95,150,100,88,94,87,161,235,191,222,76,41,153,47,188,44,202,112,62,240,149,252,94,189,92,118,82,175,172,141,64,79,167,51,79,238,222,217,1,202,142,237,33,21,64,233,5,55,167,220,192,183,195,242,211,34,199,100,133,126,127,150,49,48,190,228,8,107,93,22,139,120,95,176,149,189,9,22,175,12,20,130,92,219,115,127,144,206,87,4,10,76,13,190,153,226,247,84,18,231,184,197,130,103,151,251,131,186,135,57,150,91,219,232,237,194,154,117,156,116,95,161,164,149,66,24,236,184,142,12,129,233,203,239,196,106,24,228,64,116,61,247,70,230,237,85,59,180,243,82,201,144,51,86,77,36,171,112,77,156,112,228,96,83,233,107,18,50,9,135,187,119,198,172,133,78,50,79,166,123,101,204,10,191,228,121,89,161,202,5,25,108,93,139,154,237,215,182,107,29,147,238,183,130,48,95,242,108,18,205,64,129,235,115,169,150,6,198,185,235,193,112,139,245,102,248,21,153,15,22,29,87,177,177,220,80,58,128,218,178,189,162,188,38,113,217,7,71,213,38,62,87,82,10,86,249,194,117,28,233,35,157,224,116,111,43,182,143,248,240,5,226,196,204,140,72,25,20,18,103,195,46,110,247,4,165,80,240,254,125,17,253,29,239,69,23,81,43,170,69,141,168,174,157,79,153,8,33,95,216,174,47,195,175,215,100,78,22,92,233,43,42,149,178,116,226,239,241,187,168,30,93,226,191,137,191,22,146,105,32,254,133,7,8,43,250,20,93,196,199,34,222,143,247,226,10,230,170,24,231,57,12,70,45,4,54,162,143,209,121,212,200,10,188,182,226,10,254,17,68,147,53,192,157,50,202,57,178,234,113,69,68,87,152,107,96,38,62,66,18,5,2,159,66,170,241,97,7,180,17,157,10,180,115,197,197,0,130,57,3,130,26,53,20,197,99,147,136,254,196,16,151,241,62,24,30,101,117,63,154,109,116,133,40,122,72,69,31,240,132,144,20,167,2,35,126,199,28,15,241,172,123,69,74,53,58,199,96,3,159,72,193,106,66,228,138,162,241,241,146,200,235,73,42,80,143,206,72,11,210,154,42,44,230,109,215,75,233,222,90,241,207,136,221,3,251,170,72,207,175,173,140,79,60,152,156,156,200,24,173,255,132,136,149,248,125,143,108,68,139,8,69,151,89,17,31,210,19,235,200,139,217,36,190,130,78,145,245,160,20,230,100,186,191,187,158,21,205,8,18,114,72,143,70,38,234,15,82,81,43,123,4,194,193,45,80,109,118,186,6,31,18,130,58,215,148,251,37,168,118,106,234,133,26,208,131,229,72,188,138,158,42,86,84,183,132,49,79,139,123,171,105,127,244,180,105,65,30,124,162,213,208,1,21,60,95,196,239,137,29,113,170,114,95,253,89,66,27,225,192,248,178,65,30,171,49,115,244,85,135,194,117,98,217,108,75,80,197,250,80,147,192,92,147,91,50,148,126,78,234,253,132,211,191,203,192,240,231,25,43,20,93,226,13,170,157,144,61,179,109,123,81,216,57,133,177,109,142,71,216,149,215,182,203,164,36,68,244,23,201,123,173,176,90,249,155,197,21,122,219,198,199,218,84,77,35,216,105,178,135,176,179,170,196,172,133,191,143,92,236,196,236,234,51,61,92,227,234,123,188,226,151,100,5,122,2,197,127,218,27,226,144,230,181,77,181,231,246,49,84,77,60,212,113,44,79,66,108,166,222,227,202,81,166,252,149,19,251,108,65,199,79,130,149,21,188,244,180,124,24,248,151,118,105,223,138,52,147,202,53,182,77,114,96,105,104,100,180,58,27,133,79,160,115,225,5,193,118,169,128,14,63,104,1,78,48,122,97,14,158,223,112,196,105,254,124,30,237,245,58,173,209,181,13,73,119,224,211,102,54,54,211,167,157,145,146,40,95,208,155,174,217,213,98,117,96,106,208,53,34,109,52,213,194,182,208,24,250,204,128,243,31,102,239,155,140,70,178,59,184,211,238,67,27,81,186,15,172,63,201,6,232,70,143,102,48,135,57,241,27,108,29,58,174,72,86,82,235,83,124,64,175,130,171,208,25,93,137,143,16,144,108,65,50,74,219,12,199,250,195,144,5,174,198,7,35,142,207,222,83,18,67,56,27,221,45,145,190,205,87,86,70,252,136,107,195,192,149,195,26,178,149,245,13,231,121,201,117,210,169,199,75,56,131,167,167,38,199,23,231,30,63,26,127,56,49,59,59,254,249,244,163,217,241,185,137,7,139,15,167,166,39,166,150,150,38,82,244,149,191,59,244,203,123,40,250,109,72,60,209,157,221,138,239,103,51,76,214,90,204,23,84,89,247,185,220,243,69,191,140,219,234,211,69,95,185,170,172,199,159,9,23,67,160,210,119,247,236,142,49,185,0,27,179,150,92,223,33,144,185,50,234,221,138,20,73,50,70,29,112,33,48,164,235,152,184,119,143,11,91,203,69,92,104,148,141,132,101,223,85,6,170,51,107,230,16,182,80,246,237,188,155,179,61,175,60,31,74,91,73,71,247,55,118,91,173,59,194,16,161,93,94,167,224,155,111,209,175,120,219,185,207,39,183,207,209,247,253,117,59,95,240,240,212,198,230,75,52,53,56,0,99,154,213,68,135,240,28,128,234,54,92,63,90,223,93,244,102,188,249,192,43,229,249,215,3,231,111,224,254,59,202,117,253,65,218,197,55,252,28,17,186,59,196,234,223,47,116,121,222,145,225,138,84,32,165,222,12,45,196,175,35,29,109,14,70,108,224,107,110,233,58,200,122,17,248,82,11,27,74,85,10,125,161,66,70,222,21,18,23,104,241,255,11,172,231,66,183,160,70,175,93,251,202,63,23,56,229,33,181,218,191,153,12,35,194,89,43,249,16,20,34,145,144,189,85,7,17,178,67,126,107,152,243,165,187,229,255,0,83,212,9,149,164,14,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("195d13af-00d7-41b7-bfed-7c45210f3f4e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8a6777d-4adc-4188-ab66-00aea2766998"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"IntermediateThrowMessageEventPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2e39bb4d-6867-4391-ab30-23b32180b8f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d12a0f03-7902-41b3-903d-fca5424e92ff"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(282, 112),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("47e4d2f1-fe70-4940-a3b2-ef2ba6b1326d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e39bb4d-6867-4391-ab30-23b32180b8f1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ce91b670-94e1-4cce-afdf-bb9993ad15ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e39bb4d-6867-4391-ab30-23b32180b8f1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkClickScriptTaskScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c47b6bd0-f5a9-4f12-bd74-9bebc7ab5fa5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e39bb4d-6867-4391-ab30-23b32180b8f1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Name = @"OkClickScriptTaskScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(189, 24),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,77,111,218,64,16,61,131,196,127,88,113,72,140,138,86,189,71,149,210,18,90,181,7,130,100,218,75,212,131,227,29,82,151,101,215,218,93,155,208,170,255,189,179,31,118,108,99,220,160,30,144,96,62,222,155,121,51,59,148,137,34,91,169,246,5,79,214,201,19,172,149,76,65,107,242,142,124,2,243,241,196,30,205,110,38,227,18,83,52,168,44,225,217,47,96,223,18,94,0,198,219,40,186,129,125,254,21,125,11,41,12,60,155,135,183,223,67,124,174,100,153,49,80,24,40,224,64,2,92,156,254,128,61,226,171,100,15,6,148,131,90,135,200,154,42,111,185,17,32,26,200,158,85,68,244,14,234,26,157,39,10,117,9,72,77,38,197,124,50,30,137,130,243,57,49,199,28,228,118,16,116,222,237,215,214,214,174,139,86,213,157,138,73,95,164,252,32,217,49,234,73,190,203,116,206,147,227,0,6,86,94,130,170,112,54,137,222,89,172,141,12,153,11,201,32,234,171,200,146,101,91,18,105,163,50,241,68,63,235,21,54,125,175,150,251,220,28,251,19,102,228,55,106,211,113,197,178,80,169,27,243,121,153,124,12,93,73,1,72,250,135,0,215,240,159,88,113,170,178,220,88,180,201,216,119,64,88,67,42,116,200,199,159,56,80,34,11,147,23,166,50,134,208,54,111,37,110,95,211,231,114,58,115,25,152,218,249,133,8,202,59,197,255,57,249,110,112,181,205,241,224,46,147,11,54,185,205,63,183,202,53,213,243,134,166,200,245,147,119,179,192,26,113,162,183,83,107,217,193,17,127,30,50,193,228,129,10,68,197,200,145,93,182,96,146,57,8,80,126,159,70,173,167,188,100,153,113,219,109,13,250,5,196,103,208,240,43,63,223,72,27,224,1,43,177,151,198,179,104,16,254,210,156,161,163,62,160,142,127,5,205,34,225,252,49,73,119,3,160,23,160,56,102,247,40,125,165,87,87,151,212,128,122,218,17,248,218,203,176,55,215,83,242,166,57,70,186,145,177,91,165,104,134,142,219,233,245,77,157,114,114,79,151,207,134,22,38,227,244,75,124,191,162,12,82,123,75,202,106,244,152,213,89,217,22,103,223,27,107,16,118,82,89,123,219,123,16,90,239,161,9,244,122,129,104,138,95,162,225,225,207,59,93,131,72,79,47,232,204,247,143,183,199,125,194,86,166,92,106,192,35,62,69,167,251,211,123,207,152,191,83,145,127,34,54,75,129,41,148,32,70,225,101,248,11,63,17,85,186,99,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetFormulaPageProcessMethod());
			Methods.Add(CreateRunConversionParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("058acf75-494e-49c5-9805-9050bb221b80"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,214,11,72,76,79,213,4,17,122,142,197,5,96,142,158,115,98,65,73,102,126,158,130,173,66,113,73,81,102,94,186,158,91,126,81,110,98,137,134,82,181,65,173,66,181,97,173,146,142,66,120,102,94,74,126,57,84,161,142,130,95,106,121,80,106,114,126,81,138,166,53,0,76,118,211,157,107,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			return method;
		}

		protected override SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = base.CreateInitializeContextHelpButtonMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,243,204,203,44,201,76,204,201,172,74,117,206,207,43,73,173,40,241,72,205,41,112,42,45,41,201,207,211,208,180,6,0,21,115,174,228,35,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFormulaPageProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("95747223-416a-455a-9c35-6733efea82a5"),
				Name = "GetFormulaPageProcess",
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,142,177,10,194,64,12,134,103,239,41,226,214,46,247,2,103,5,145,10,221,10,42,206,177,166,90,184,230,74,114,237,34,190,187,156,118,232,38,46,9,36,63,223,255,77,40,208,6,233,71,143,53,222,9,10,72,203,166,177,15,28,177,99,146,195,247,255,57,86,172,17,185,33,64,133,19,137,160,134,54,218,11,93,119,195,96,231,96,121,235,98,202,30,155,7,245,120,86,146,132,146,224,157,233,90,200,150,117,235,2,120,244,62,135,167,89,9,197,81,24,178,95,216,114,34,142,90,75,104,72,117,243,183,196,54,95,8,216,25,227,204,203,204,253,201,199,189,1,176,44,108,129,23,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRunConversionParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a976d1f3-d802-4b0d-b21b-467478536c1c"),
				Name = "RunConversionParameterValue",
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9f13cd7c-20e3-434a-99b6-5d3fd56db14c"),
				Name = "parameterValue",
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaParameterValue",
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("782d59ff-3ce1-40c5-854b-33cee40f9129"),
				Name = "formulaPageProcess",
				CreatedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				ModifiedInSchemaUId = new Guid("330c7711-91ea-461a-9697-28bda52a2a54"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl>",
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,75,111,219,70,16,62,43,64,254,3,195,67,64,2,42,209,94,171,200,69,45,217,134,16,203,54,42,197,167,94,214,210,72,98,205,23,118,151,78,136,166,255,189,51,251,160,150,226,74,142,146,28,44,147,203,111,103,190,121,236,55,43,36,79,139,109,240,194,178,26,130,113,80,49,206,114,144,192,31,105,33,81,191,163,183,111,210,77,16,9,133,76,102,226,174,206,178,123,126,149,87,178,137,212,190,56,14,254,125,251,102,192,65,214,188,64,244,127,122,195,129,173,69,89,243,21,250,24,7,15,188,92,129,16,139,213,14,114,246,208,65,105,80,50,41,11,33,213,130,54,61,101,146,169,215,101,83,193,156,21,108,11,60,88,251,22,199,193,39,1,28,247,23,176,146,105,89,36,190,173,200,113,48,187,42,234,28,56,123,202,224,131,15,51,147,144,95,116,125,208,146,64,15,62,199,201,13,72,245,61,138,201,250,77,157,174,187,184,79,179,117,63,191,211,3,196,232,72,172,100,185,207,5,237,21,88,11,218,180,41,57,176,213,46,136,142,238,78,213,79,225,137,72,167,120,64,37,35,80,162,152,142,123,236,13,108,224,163,65,251,70,234,235,19,242,120,86,143,216,5,234,79,247,77,176,78,69,149,177,230,209,52,154,37,78,94,123,22,147,27,94,214,213,29,102,138,136,132,24,19,136,208,248,183,230,112,109,153,230,240,49,45,40,175,10,67,239,225,200,198,210,183,218,49,24,58,241,184,150,252,219,116,68,1,100,2,130,87,140,43,22,223,97,156,126,14,146,132,85,205,235,12,143,200,22,204,153,73,230,236,25,108,172,10,54,103,43,94,138,200,174,37,120,158,4,152,115,57,236,164,73,53,230,201,24,186,105,95,168,76,183,137,127,42,203,44,72,197,93,41,175,83,46,36,210,83,78,146,89,177,134,47,247,155,40,252,59,68,232,187,113,240,235,168,11,191,101,14,154,94,122,59,204,39,40,182,114,23,252,18,252,54,114,10,157,22,2,137,80,137,17,221,22,215,225,241,254,253,222,77,155,246,110,30,141,116,161,42,172,152,140,180,197,161,246,58,52,14,226,195,10,239,61,156,111,212,111,236,155,9,250,136,157,87,186,105,170,196,143,241,20,15,14,101,232,68,191,222,150,229,115,93,217,42,95,21,50,149,141,150,230,0,220,151,158,178,186,80,87,5,81,186,89,177,130,203,6,69,227,112,8,252,5,27,224,128,95,245,54,146,149,209,222,109,144,41,46,36,15,240,57,208,107,81,215,171,134,107,92,210,50,115,137,182,61,98,64,215,32,87,187,107,94,230,211,203,136,204,146,52,219,185,101,203,241,194,184,174,156,48,190,219,4,54,31,116,109,134,65,249,244,15,82,184,208,250,78,91,8,158,252,185,94,71,161,176,193,132,195,67,133,239,7,156,44,75,125,178,162,216,103,10,50,244,2,107,181,59,236,244,147,61,17,21,79,115,36,54,213,45,52,41,179,58,47,108,35,153,152,31,142,67,180,244,42,123,131,63,108,227,169,97,174,215,126,127,213,134,19,64,143,191,91,136,228,26,69,199,103,133,90,47,66,113,58,26,136,177,235,145,191,37,111,72,1,117,207,186,250,167,57,96,149,106,217,25,53,223,117,124,238,229,14,120,43,124,175,232,61,245,83,248,77,231,58,108,219,15,165,172,213,31,212,181,56,236,41,198,9,135,151,168,172,192,138,48,246,186,124,49,37,186,45,63,3,143,156,240,237,176,237,192,117,55,24,246,62,75,35,179,213,83,11,122,214,55,196,57,228,229,213,58,149,201,18,190,144,212,187,134,232,62,184,15,235,7,238,132,139,70,96,26,156,75,161,186,99,137,70,60,162,204,209,53,206,220,159,28,156,251,213,94,54,104,23,181,145,51,39,117,215,116,45,89,105,112,86,251,10,232,184,58,42,128,7,102,157,25,252,227,246,213,65,218,43,196,185,117,34,255,71,174,24,139,61,45,115,192,28,162,170,21,135,110,194,146,9,171,172,58,255,204,106,47,64,74,60,64,186,22,36,210,232,211,172,25,161,94,2,231,76,148,27,73,135,108,147,110,107,206,108,234,12,80,248,38,136,238,29,13,48,125,67,132,79,116,71,139,141,105,158,238,121,116,230,139,131,138,213,225,252,250,245,24,52,156,148,235,189,192,155,110,59,235,148,29,47,157,241,231,234,163,195,162,173,158,93,32,38,182,129,126,78,245,230,172,170,218,186,153,177,133,69,120,1,62,7,137,91,240,154,231,229,143,221,141,143,21,112,156,33,29,248,101,51,201,82,28,46,246,221,233,122,99,62,87,113,30,79,139,201,195,105,167,102,20,105,143,93,6,81,151,191,158,221,212,146,185,90,193,36,136,253,165,1,105,68,158,43,132,254,127,17,251,40,122,172,216,174,124,231,115,65,253,46,25,222,17,63,66,19,233,224,109,23,121,225,52,157,53,108,248,74,138,124,129,158,61,2,180,43,146,131,255,1,58,144,60,226,98,16,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProcessSchemaParameterValueEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("330c7711-91ea-461a-9697-28bda52a2a54"));
		}

		#endregion

	}

	#endregion

}

