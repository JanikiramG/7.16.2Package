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

	#region Class: ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema

	/// <exclude/>
	public class ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchema
	{

		#region Constructors: Public

		public ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateUserTaskTitleEdit() {
			UserTaskTitleEdit.Image = new ControlImage {};
			UserTaskTitleEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateStartInEdit() {
			StartInEdit.Image = new ControlImage {};
			StartInEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateStartInPeriodEdit() {
			StartInPeriodEdit.Image = new ControlImage {};
			StartInPeriodEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout8() {
			ActivityControlLayout8.Image = new ControlImage {};
			ActivityControlLayout8.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateDurationEdit() {
			DurationEdit.Image = new ControlImage {};
			DurationEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateDurationPeriodEdit() {
			DurationPeriodEdit.Image = new ControlImage {};
			DurationPeriodEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout9() {
			ActivityControlLayout9.Image = new ControlImage {};
			ActivityControlLayout9.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityCategoryEdit() {
			ActivityCategoryEdit.Image = new ControlImage {};
			ActivityCategoryEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout3() {
			ActivityControlLayout3.Image = new ControlImage {};
			ActivityControlLayout3.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateOwnerEdit() {
			OwnerEdit.Image = new ControlImage {};
			OwnerEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateRemindBeforeEdit() {
			RemindBeforeEdit.Image = new ControlImage {};
			RemindBeforeEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateRemindBeforePeriodEdit() {
			RemindBeforePeriodEdit.Image = new ControlImage {};
			RemindBeforePeriodEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout10() {
			ActivityControlLayout10.Image = new ControlImage {};
			ActivityControlLayout10.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateExecutionContextEdit() {
			ExecutionContextEdit.Image = new ControlImage {};
			ExecutionContextEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout4() {
			ActivityControlLayout4.Image = new ControlImage {};
			ActivityControlLayout4.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout2() {
			ActivityControlLayout2.Image = new ControlImage {};
			ActivityControlLayout2.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout1() {
			BaseProcessUserTaskPageControlLayout1.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout1.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout2() {
			BaseProcessUserTaskPageControlLayout2.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout2.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout11() {
			ActivityControlLayout11.Image = new ControlImage {};
			ActivityControlLayout11.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateLeadEdit() {
			LeadEdit.Image = new ControlImage {};
			LeadEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateAccountEdit() {
			AccountEdit.Image = new ControlImage {};
			AccountEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateContactEdit() {
			ContactEdit.Image = new ControlImage {};
			ContactEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateApplicationEdit() {
			ApplicationEdit.Image = new ControlImage {};
			ApplicationEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateCaseEdit() {
			CaseEdit.Image = new ControlImage {};
			CaseEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateProjectEdit() {
			ProjectEdit.Image = new ControlImage {};
			ProjectEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateOpportunityEdit() {
			OpportunityEdit.Image = new ControlImage {};
			OpportunityEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout6() {
			ActivityControlLayout6.Image = new ControlImage {};
			ActivityControlLayout6.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateInvoiceEdit() {
			InvoiceEdit.Image = new ControlImage {};
			InvoiceEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateDocumentEdit() {
			DocumentEdit.Image = new ControlImage {};
			DocumentEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateOrderEdit() {
			OrderEdit.Image = new ControlImage {};
			OrderEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateContractEdit() {
			ContractEdit.Image = new ControlImage {};
			ContractEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateProblemEdit() {
			ProblemEdit.Image = new ControlImage {};
			ProblemEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateChangeEdit() {
			ChangeEdit.Image = new ControlImage {};
			ChangeEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateReleaseEdit() {
			ReleaseEdit.Image = new ControlImage {};
			ReleaseEdit.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout7() {
			ActivityControlLayout7.Image = new ControlImage {};
			ActivityControlLayout7.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout5() {
			ActivityControlLayout5.Image = new ControlImage {};
			ActivityControlLayout5.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateActivityControlLayout1() {
			ActivityControlLayout1.Image = new ControlImage {};
			ActivityControlLayout1.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
			RealUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
			Name = "ActivityUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
			ParentSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema() {
			var schema = new ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
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
			return new ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl
	{

		public ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			SchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
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

		private ProcessFlowElement _activityInitEventSubProcess;
		public ProcessFlowElement ActivityInitEventSubProcess {
			get {
				return _activityInitEventSubProcess ?? (_activityInitEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivityInitEventSubProcess",
					SchemaElementUId = new Guid("8b34bee6-bc1f-4149-a5f3-b48e4704f09d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityInitStartMessage;
		public ProcessFlowElement ActivityInitStartMessage {
			get {
				return _activityInitStartMessage ?? (_activityInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityInitStartMessage",
					SchemaElementUId = new Guid("bf325618-78c4-4b1d-afc6-84c0f2cfca6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityInitScriptTask;
		public ProcessScriptTask ActivityInitScriptTask {
			get {
				return _activityInitScriptTask ?? (_activityInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityInitScriptTask",
					SchemaElementUId = new Guid("c6cccc9a-6580-403a-b340-986a9df094d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityInitScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _activityInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ActivityInitIntermediateThrowMessageEvent {
			get {
				return _activityInitIntermediateThrowMessageEvent ?? (_activityInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ActivityInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("dea301d3-7a9d-4cf1-ab2d-a4f6e787efb4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ActivityInitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInitEventSubProcess };
			FlowElements[ActivityInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInitStartMessage };
			FlowElements[ActivityInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInitScriptTask };
			FlowElements[ActivityInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInitIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ActivityInitEventSubProcess":
						break;
					case "ActivityInitStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityInitIntermediateThrowMessageEvent");
						break;
					case "ActivityInitScriptTask":
						break;
					case "ActivityInitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ActivityInitScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ActivityInitStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ActivityInitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityInitStartMessage";
					result = ActivityInitStartMessage.Execute(context);
					break;
				case "ActivityInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityInitScriptTask";
					result = ActivityInitScriptTask.Execute(context, ActivityInitScriptTaskExecute);
					break;
				case "ActivityInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ActivityInitIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool ActivityInitScriptTaskExecute(ProcessExecutingContext context) {
			InvokeInitBaseActivityParametersEditPage();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("ActivityInitStartMessage")) {
							context.QueueTasks.Enqueue("ActivityInitStartMessage");
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

	#region Class: ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess : ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<Terrasoft.WebApp.ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl>
	{

		public ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchemaUserControl
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
			var process = (ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection);
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
			SchemaName = "ActivityUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			UId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998");
			CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
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
			ProcessSchemaLaneSet schemaActivityLaneSet = CreateActivityLaneSetLaneSet();
			LaneSets.Add(schemaActivityLaneSet);
			ProcessSchemaLane schemaActivityLane = CreateActivityLaneLane();
			schemaActivityLaneSet.Lanes.Add(schemaActivityLane);
			ProcessSchemaEventSubProcess activityiniteventsubprocess = CreateActivityInitEventSubProcessEventSubProcess();
			FlowElements.Add(activityiniteventsubprocess);
			ProcessSchemaStartMessageEvent activityinitstartmessage = CreateActivityInitStartMessageStartMessageEvent();
			activityiniteventsubprocess.FlowElements.Add(activityinitstartmessage);
			ProcessSchemaScriptTask activityinitscripttask = CreateActivityInitScriptTaskScriptTask();
			activityiniteventsubprocess.FlowElements.Add(activityinitscripttask);
			ProcessSchemaIntermediateThrowMessageEvent activityinitintermediatethrowmessageevent = CreateActivityInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			activityiniteventsubprocess.FlowElements.Add(activityinitintermediatethrowmessageevent);
			FlowElements.Add(CreateActivityInitSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateActivityInitSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateActivityInitSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ActivityInitSequenceFlow1",
				UId = new Guid("0b267991-f314-47ef-9495-f773bfe72c2f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				CurveCenterPosition = new Point(165, 93),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf325618-78c4-4b1d-afc6-84c0f2cfca6b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dea301d3-7a9d-4cf1-ab2d-a4f6e787efb4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateActivityInitSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ActivityInitSequenceFlow2",
				UId = new Guid("d2cb8851-bbef-4bb8-be96-280f2cae9dc0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				CurveCenterPosition = new Point(240, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dea301d3-7a9d-4cf1-ab2d-a4f6e787efb4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6cccc9a-6580-403a-b340-986a9df094d7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateActivityLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaActivityLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("01196425-25f6-433d-bb52-2a3cde238c20"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				Name = @"ActivityLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(926, 198),
				UseBackgroundMode = false
			};
			return schemaActivityLaneSet;
		}

		protected virtual ProcessSchemaLane CreateActivityLaneLane() {
			ProcessSchemaLane schemaActivityLane = new ProcessSchemaLane(this) {
				UId = new Guid("7c30c2c1-8b98-4786-9151-59b0fc62a11a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("01196425-25f6-433d-bb52-2a3cde238c20"),
				CreatedInOwnerSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				Name = @"ActivityLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(897, 198),
				UseBackgroundMode = false
			};
			return schemaActivityLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivityInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivityInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8b34bee6-bc1f-4149-a5f3-b48e4704f09d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7c30c2c1-8b98-4786-9151-59b0fc62a11a"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				Name = @"ActivityInitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(299, 177),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivityInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bf325618-78c4-4b1d-afc6-84c0f2cfca6b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b34bee6-bc1f-4149-a5f3-b48e4704f09d"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				Name = @"ActivityInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c6cccc9a-6580-403a-b340-986a9df094d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b34bee6-bc1f-4149-a5f3-b48e4704f09d"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				Name = @"ActivityInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,43,203,207,78,245,204,203,44,113,74,44,78,117,76,46,201,44,203,44,169,12,72,44,74,204,77,45,73,45,42,118,77,201,44,9,72,76,79,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,4,27,106,220,57,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateActivityInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("dea301d3-7a9d-4cf1-ab2d-a4f6e787efb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b34bee6-bc1f-4149-a5f3-b48e4704f09d"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("6ec04dfe-7359-45ab-adc0-038265952998"),
				Name = @"ActivityInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 65),
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
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a7fde1d1-79c0-412a-bda3-e5b6e2f8b0c2"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ec04dfe-7359-45ab-adc0-038265952998"));
		}

		#endregion

	}

	#endregion

}

