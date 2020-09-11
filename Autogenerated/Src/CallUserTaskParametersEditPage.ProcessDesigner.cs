namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
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
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema

	/// <exclude/>
	public class CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchema
	{

		#region Constructors: Public

		public CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateUserTaskTitleEdit() {
			UserTaskTitleEdit.Image = new ControlImage {};
			UserTaskTitleEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateStartInEdit() {
			StartInEdit.Image = new ControlImage {};
			StartInEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateStartInPeriodEdit() {
			StartInPeriodEdit.Image = new ControlImage {};
			StartInPeriodEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout8() {
			ActivityControlLayout8.Image = new ControlImage {};
			ActivityControlLayout8.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateDurationEdit() {
			DurationEdit.Image = new ControlImage {};
			DurationEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateDurationPeriodEdit() {
			DurationPeriodEdit.Image = new ControlImage {};
			DurationPeriodEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout9() {
			ActivityControlLayout9.Image = new ControlImage {};
			ActivityControlLayout9.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityCategoryEdit() {
			ActivityCategoryEdit.Image = new ControlImage {};
			ActivityCategoryEdit.Enabled = false;
			ActivityCategoryEdit.Hidden = true;
			ActivityCategoryEdit.Required = false;
			ActivityCategoryEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout3() {
			ActivityControlLayout3.Image = new ControlImage {};
			ActivityControlLayout3.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateOwnerEdit() {
			OwnerEdit.Image = new ControlImage {};
			OwnerEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateRemindBeforeEdit() {
			RemindBeforeEdit.Image = new ControlImage {};
			RemindBeforeEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateRemindBeforePeriodEdit() {
			RemindBeforePeriodEdit.Image = new ControlImage {};
			RemindBeforePeriodEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout10() {
			ActivityControlLayout10.Image = new ControlImage {};
			ActivityControlLayout10.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateExecutionContextEdit() {
			ExecutionContextEdit.Image = new ControlImage {};
			ExecutionContextEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout4() {
			ActivityControlLayout4.Image = new ControlImage {};
			ActivityControlLayout4.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout2() {
			ActivityControlLayout2.Image = new ControlImage {};
			ActivityControlLayout2.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout1() {
			BaseProcessUserTaskPageControlLayout1.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout1.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout2() {
			BaseProcessUserTaskPageControlLayout2.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout2.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout11() {
			ActivityControlLayout11.Image = new ControlImage {};
			ActivityControlLayout11.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateLeadEdit() {
			LeadEdit.Image = new ControlImage {};
			LeadEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateAccountEdit() {
			AccountEdit.Image = new ControlImage {};
			AccountEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateContactEdit() {
			ContactEdit.Image = new ControlImage {};
			ContactEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateApplicationEdit() {
			ApplicationEdit.Image = new ControlImage {};
			ApplicationEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateCaseEdit() {
			CaseEdit.Image = new ControlImage {};
			CaseEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateProjectEdit() {
			ProjectEdit.Image = new ControlImage {};
			ProjectEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateOpportunityEdit() {
			OpportunityEdit.Image = new ControlImage {};
			OpportunityEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout6() {
			ActivityControlLayout6.Image = new ControlImage {};
			ActivityControlLayout6.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateInvoiceEdit() {
			InvoiceEdit.Image = new ControlImage {};
			InvoiceEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateDocumentEdit() {
			DocumentEdit.Image = new ControlImage {};
			DocumentEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateOrderEdit() {
			OrderEdit.Image = new ControlImage {};
			OrderEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateContractEdit() {
			ContractEdit.Image = new ControlImage {};
			ContractEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateProblemEdit() {
			ProblemEdit.Image = new ControlImage {};
			ProblemEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateChangeEdit() {
			ChangeEdit.Image = new ControlImage {};
			ChangeEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateReleaseEdit() {
			ReleaseEdit.Image = new ControlImage {};
			ReleaseEdit.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout7() {
			ActivityControlLayout7.Image = new ControlImage {};
			ActivityControlLayout7.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout5() {
			ActivityControlLayout5.Image = new ControlImage {};
			ActivityControlLayout5.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateActivityControlLayout1() {
			ActivityControlLayout1.Image = new ControlImage {};
			ActivityControlLayout1.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
			RealUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
			Name = "CallUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
			ParentSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			UpdateActivityControlLayout1();
			UpdateActivityControlLayout5();
			UpdateActivityControlLayout7();
			UpdateReleaseEdit();
			UpdateChangeEdit();
			UpdateProblemEdit();
			UpdateContractEdit();
			UpdateOrderEdit();
			UpdateDocumentEdit();
			UpdateInvoiceEdit();
			UpdateActivityControlLayout6();
			UpdateOpportunityEdit();
			UpdateProjectEdit();
			UpdateCaseEdit();
			UpdateApplicationEdit();
			UpdateContactEdit();
			UpdateAccountEdit();
			UpdateLeadEdit();
			UpdateActivityControlLayout11();
			UpdateBaseProcessUserTaskPageControlLayout2();
			UpdateBaseProcessUserTaskPageControlLayout1();
			UpdateActivityControlLayout2();
			UpdateActivityControlLayout4();
			UpdateExecutionContextEdit();
			UpdateActivityControlLayout10();
			UpdateRemindBeforePeriodEdit();
			UpdateRemindBeforeEdit();
			UpdateOwnerEdit();
			UpdateActivityControlLayout3();
			UpdateActivityCategoryEdit();
			UpdateActivityControlLayout9();
			UpdateDurationPeriodEdit();
			UpdateDurationEdit();
			UpdateActivityControlLayout8();
			UpdateStartInPeriodEdit();
			UpdateStartInEdit();
			UpdateUserTaskTitleEdit();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.MoveItem(0, ActivityControlLayout1);
			ActivityControlLayout1.MoveItem(0, UserTaskTitleEdit);
			ActivityControlLayout1.MoveItem(1, RecommendationEdit);
			ActivityControlLayout1.MoveItem(2, InformationOnStepMemoEdit);
			ActivityControlLayout1.MoveItem(3, ActivityControlLayout2);
			ActivityControlLayout2.MoveItem(0, ActivityControlLayout3);
			ActivityControlLayout3.MoveItem(0, ActivityControlLayout8);
			ActivityControlLayout8.MoveItem(0, StartInEdit);
			ActivityControlLayout8.MoveItem(1, StartInPeriodEdit);
			ActivityControlLayout3.MoveItem(1, ActivityControlLayout9);
			ActivityControlLayout9.MoveItem(0, DurationEdit);
			ActivityControlLayout9.MoveItem(1, DurationPeriodEdit);
			ActivityControlLayout3.MoveItem(2, ActivityCategoryEdit);
			ActivityControlLayout2.MoveItem(1, ActivityControlLayout4);
			ActivityControlLayout4.MoveItem(0, OwnerEdit);
			ActivityControlLayout4.MoveItem(1, ActivityControlLayout10);
			ActivityControlLayout10.MoveItem(0, RemindBeforeEdit);
			ActivityControlLayout10.MoveItem(1, RemindBeforePeriodEdit);
			ActivityControlLayout4.MoveItem(2, ExecutionContextEdit);
			ActivityControlLayout1.MoveItem(4, ActivityControlLayout11);
			ActivityControlLayout11.MoveItem(0, BaseProcessUserTaskPageControlLayout1);
			BaseProcessUserTaskPageControlLayout1.MoveItem(0, ShowExecutionPageEdit);
			ActivityControlLayout11.MoveItem(1, BaseProcessUserTaskPageControlLayout2);
			BaseProcessUserTaskPageControlLayout2.MoveItem(0, ShowInSchedulerEdit);
			ActivityControlLayout1.MoveItem(5, ActivityControlLayout5);
			ActivityControlLayout5.MoveItem(0, ActivityControlLayout6);
			ActivityControlLayout6.MoveItem(0, LeadEdit);
			ActivityControlLayout6.MoveItem(1, AccountEdit);
			ActivityControlLayout6.MoveItem(2, ContactEdit);
			ActivityControlLayout6.MoveItem(3, ApplicationEdit);
			ActivityControlLayout6.MoveItem(4, CaseEdit);
			ActivityControlLayout6.MoveItem(5, ProjectEdit);
			ActivityControlLayout6.MoveItem(6, OpportunityEdit);
			ActivityControlLayout5.MoveItem(1, ActivityControlLayout7);
			ActivityControlLayout7.MoveItem(0, InvoiceEdit);
			ActivityControlLayout7.MoveItem(1, DocumentEdit);
			ActivityControlLayout7.MoveItem(2, OrderEdit);
			ActivityControlLayout7.MoveItem(3, ContractEdit);
			ActivityControlLayout7.MoveItem(4, ProblemEdit);
			ActivityControlLayout7.MoveItem(5, ChangeEdit);
			ActivityControlLayout7.MoveItem(6, ReleaseEdit);
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateCallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema() {
			var schema = new CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
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
			return new CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl
	{

		public CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			SchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
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

		private ProcessFlowElement _callActivityInitEventSubProcess;
		public ProcessFlowElement CallActivityInitEventSubProcess {
			get {
				return _callActivityInitEventSubProcess ?? (_callActivityInitEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CallActivityInitEventSubProcess",
					SchemaElementUId = new Guid("10650e28-db70-46f7-afec-88126a9d474d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _callActivityInitStartMessage;
		public ProcessFlowElement CallActivityInitStartMessage {
			get {
				return _callActivityInitStartMessage ?? (_callActivityInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CallActivityInitStartMessage",
					SchemaElementUId = new Guid("fd1c100c-885d-42fb-992f-6798410e7439"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _callActivityInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent CallActivityInitIntermediateThrowMessageEvent {
			get {
				return _callActivityInitIntermediateThrowMessageEvent ?? (_callActivityInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "CallActivityInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("dd0b8f79-78a6-42d7-a80f-4978124be690"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _callActivityInitScriptTask;
		public ProcessScriptTask CallActivityInitScriptTask {
			get {
				return _callActivityInitScriptTask ?? (_callActivityInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CallActivityInitScriptTask",
					SchemaElementUId = new Guid("e81dda4f-9459-4d30-8cf2-bcb6954275e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CallActivityInitScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[CallActivityInitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CallActivityInitEventSubProcess };
			FlowElements[CallActivityInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CallActivityInitStartMessage };
			FlowElements[CallActivityInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { CallActivityInitIntermediateThrowMessageEvent };
			FlowElements[CallActivityInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CallActivityInitScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "CallActivityInitEventSubProcess":
						break;
					case "CallActivityInitStartMessage":
						e.Context.QueueTasks.Enqueue("CallActivityInitIntermediateThrowMessageEvent");
						break;
					case "CallActivityInitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("CallActivityInitScriptTask");
						break;
					case "CallActivityInitScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CallActivityInitStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "CallActivityInitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CallActivityInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CallActivityInitStartMessage";
					result = CallActivityInitStartMessage.Execute(context);
					break;
				case "CallActivityInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = CallActivityInitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "CallActivityInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CallActivityInitScriptTask";
					result = CallActivityInitScriptTask.Execute(context, CallActivityInitScriptTaskExecute);
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

		public virtual bool CallActivityInitScriptTaskExecute(ProcessExecutingContext context) {
			InvokeInitBaseActivityParametersEditPage();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("CallActivityInitStartMessage")) {
							context.QueueTasks.Enqueue("CallActivityInitStartMessage");
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

	#region Class: CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess : CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<Terrasoft.WebApp.CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl>
	{

		public CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchemaUserControl
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
			var process = (CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection);
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
			SchemaName = "CallUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			UId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6");
			CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaCallActivityInitLaneSet = CreateCallActivityInitLaneSetLaneSet();
			LaneSets.Add(schemaCallActivityInitLaneSet);
			ProcessSchemaLane schemaCallActivityEditPageEventsLane = CreateCallActivityEditPageEventsLaneLane();
			schemaCallActivityInitLaneSet.Lanes.Add(schemaCallActivityEditPageEventsLane);
			ProcessSchemaEventSubProcess callactivityiniteventsubprocess = CreateCallActivityInitEventSubProcessEventSubProcess();
			FlowElements.Add(callactivityiniteventsubprocess);
			ProcessSchemaStartMessageEvent callactivityinitstartmessage = CreateCallActivityInitStartMessageStartMessageEvent();
			callactivityiniteventsubprocess.FlowElements.Add(callactivityinitstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent callactivityinitintermediatethrowmessageevent = CreateCallActivityInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			callactivityiniteventsubprocess.FlowElements.Add(callactivityinitintermediatethrowmessageevent);
			ProcessSchemaScriptTask callactivityinitscripttask = CreateCallActivityInitScriptTaskScriptTask();
			callactivityiniteventsubprocess.FlowElements.Add(callactivityinitscripttask);
			FlowElements.Add(CreateCallActivityInitSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateCallActivityInitSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateCallActivityInitSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "CallActivityInitSequenceFlow1",
				UId = new Guid("ae652720-9495-40eb-ad42-46a34a82d6db"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				CurveCenterPosition = new Point(176, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd1c100c-885d-42fb-992f-6798410e7439"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dd0b8f79-78a6-42d7-a80f-4978124be690"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateCallActivityInitSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "CallActivityInitSequenceFlow2",
				UId = new Guid("1036a378-883b-44fb-bc52-c040459f615f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				CurveCenterPosition = new Point(256, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd0b8f79-78a6-42d7-a80f-4978124be690"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e81dda4f-9459-4d30-8cf2-bcb6954275e1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateCallActivityInitLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaCallActivityInitLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e8fa5b41-8e43-47f1-9000-574b7d4c3818"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				Name = @"CallActivityInitLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(969, 198),
				UseBackgroundMode = false
			};
			return schemaCallActivityInitLaneSet;
		}

		protected virtual ProcessSchemaLane CreateCallActivityEditPageEventsLaneLane() {
			ProcessSchemaLane schemaCallActivityEditPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("e3e06472-e67a-4c16-9a1a-71cc7b62275f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e8fa5b41-8e43-47f1-9000-574b7d4c3818"),
				CreatedInOwnerSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				Name = @"CallActivityEditPageEventsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(940, 198),
				UseBackgroundMode = false
			};
			return schemaCallActivityEditPageEventsLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCallActivityInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCallActivityInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("10650e28-db70-46f7-afec-88126a9d474d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e3e06472-e67a-4c16-9a1a-71cc7b62275f"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				Name = @"CallActivityInitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(313, 177),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCallActivityInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCallActivityInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fd1c100c-885d-42fb-992f-6798410e7439"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10650e28-db70-46f7-afec-88126a9d474d"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				Name = @"CallActivityInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateCallActivityInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("dd0b8f79-78a6-42d7-a80f-4978124be690"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10650e28-db70-46f7-afec-88126a9d474d"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				Name = @"CallActivityInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCallActivityInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e81dda4f-9459-4d30-8cf2-bcb6954275e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10650e28-db70-46f7-afec-88126a9d474d"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"),
				Name = @"CallActivityInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,43,203,207,78,245,204,203,44,113,74,44,78,117,76,46,201,44,203,44,169,12,72,44,74,204,77,45,73,45,42,118,77,201,44,9,72,76,79,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,4,27,106,220,57,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a7fde1d1-79c0-412a-bda3-e5b6e2f8b0c2"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6"));
		}

		#endregion

	}

	#endregion

}

