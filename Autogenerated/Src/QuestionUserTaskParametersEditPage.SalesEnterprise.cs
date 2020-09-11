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
	using System.Linq;
	using System.Runtime.Serialization.Formatters;
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

	#region Class: QuestionUserTaskParametersEditPageSchema

	/// <exclude/>
	public class QuestionUserTaskParametersEditPageSchema : Terrasoft.WebApp.QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema
	{

		#region Constructors: Public

		public QuestionUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QuestionUserTaskParametersEditPageSchema(QuestionUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateUserTaskTitleEdit() {
			UserTaskTitleEdit.Image = new ControlImage {};
			UserTaskTitleEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateSingleDecisionMode() {
			SingleDecisionMode.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateMultipleDecisionMode() {
			MultipleDecisionMode.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateEditButton() {
			EditButton.AjaxEvents.Click.IsProcessEventHandler = true;
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateUpButton() {
			UpButton.AjaxEvents.Click.IsProcessEventHandler = true;
			UpButton.Image = new ControlImage {};
			UpButton.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateDownButton() {
			DownButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownButton.Image = new ControlImage {};
			DownButton.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateControlLayout1() {
			ControlLayout1.Image = new ControlImage {};
			ControlLayout1.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateControlLayoutQuestion() {
			ControlLayoutQuestion.Image = new ControlImage {};
			ControlLayoutQuestion.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateUserQuestionTab() {
			UserQuestionTab.Image = new ControlImage {};
			UserQuestionTab.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateStartInEdit() {
			StartInEdit.Image = new ControlImage {};
			StartInEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateStartInPeriodEdit() {
			StartInPeriodEdit.Image = new ControlImage {};
			StartInPeriodEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout8() {
			ActivityControlLayout8.Image = new ControlImage {};
			ActivityControlLayout8.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateDurationEdit() {
			DurationEdit.Image = new ControlImage {};
			DurationEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateDurationPeriodEdit() {
			DurationPeriodEdit.Image = new ControlImage {};
			DurationPeriodEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout9() {
			ActivityControlLayout9.Image = new ControlImage {};
			ActivityControlLayout9.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityCategoryEdit() {
			ActivityCategoryEdit.Image = new ControlImage {};
			ActivityCategoryEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout3() {
			ActivityControlLayout3.Image = new ControlImage {};
			ActivityControlLayout3.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateOwnerEdit() {
			OwnerEdit.Image = new ControlImage {};
			OwnerEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateRemindBeforeEdit() {
			RemindBeforeEdit.Image = new ControlImage {};
			RemindBeforeEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateRemindBeforePeriodEdit() {
			RemindBeforePeriodEdit.Image = new ControlImage {};
			RemindBeforePeriodEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout10() {
			ActivityControlLayout10.Image = new ControlImage {};
			ActivityControlLayout10.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateExecutionContextEdit() {
			ExecutionContextEdit.Image = new ControlImage {};
			ExecutionContextEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout4() {
			ActivityControlLayout4.Image = new ControlImage {};
			ActivityControlLayout4.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout2() {
			ActivityControlLayout2.Image = new ControlImage {};
			ActivityControlLayout2.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout1() {
			BaseProcessUserTaskPageControlLayout1.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout1.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout2() {
			BaseProcessUserTaskPageControlLayout2.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout2.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout11() {
			ActivityControlLayout11.Image = new ControlImage {};
			ActivityControlLayout11.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateLeadEdit() {
			LeadEdit.Image = new ControlImage {};
			LeadEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateAccountEdit() {
			AccountEdit.Image = new ControlImage {};
			AccountEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateContactEdit() {
			ContactEdit.Image = new ControlImage {};
			ContactEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateOpportunityEdit() {
			OpportunityEdit.Image = new ControlImage {};
			OpportunityEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout6() {
			ActivityControlLayout6.Image = new ControlImage {};
			ActivityControlLayout6.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateInvoiceEdit() {
			InvoiceEdit.Image = new ControlImage {};
			InvoiceEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateDocumentEdit() {
			DocumentEdit.Image = new ControlImage {};
			DocumentEdit.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout7() {
			ActivityControlLayout7.Image = new ControlImage {};
			ActivityControlLayout7.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout5() {
			ActivityControlLayout5.Image = new ControlImage {};
			ActivityControlLayout5.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityControlLayout1() {
			ActivityControlLayout1.Image = new ControlImage {};
			ActivityControlLayout1.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateActivityTab() {
			ActivityTab.Image = new ControlImage {};
			ActivityTab.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateUserQuestionTabPanel() {
			UserQuestionTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
		}

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
			Name = "QuestionUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72");
			UseProfile = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQuestionUserTaskParametersEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			UpdateUserQuestionTabPanel();
			UpdateActivityTab();
			UpdateActivityControlLayout1();
			UpdateActivityControlLayout5();
			UpdateActivityControlLayout7();
			UpdateDocumentEdit();
			UpdateInvoiceEdit();
			UpdateActivityControlLayout6();
			UpdateOpportunityEdit();
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
			UpdateUserQuestionTab();
			UpdateControlLayoutQuestion();
			UpdateControlLayout1();
			UpdateButtonsControlLayout();
			UpdateDownButton();
			UpdateUpButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateAddButton();
			UpdateMultipleDecisionMode();
			UpdateSingleDecisionMode();
			UpdateUserTaskTitleEdit();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.MoveItem(0, UserQuestionTabPanel);
			UserQuestionTabPanel.MoveItem(0, UserQuestionTab);
			UserQuestionTab.MoveItem(0, ControlLayoutQuestion);
			ControlLayoutQuestion.MoveItem(0, UserTaskTitleEdit);
			ControlLayoutQuestion.MoveItem(1, RecommendationEdit);
			ControlLayoutQuestion.MoveItem(2, LabelDecisionMode);
			ControlLayoutQuestion.MoveItem(3, SingleDecisionMode);
			ControlLayoutQuestion.MoveItem(4, MultipleDecisionMode);
			ControlLayoutQuestion.MoveItem(5, LabelAnswers);
			ControlLayoutQuestion.MoveItem(6, ControlLayout1);
			ControlLayout1.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, EditButton);
			ButtonsControlLayout.MoveItem(2, DeleteButton);
			ButtonsControlLayout.MoveItem(3, Spacer2);
			ButtonsControlLayout.MoveItem(4, UpButton);
			ButtonsControlLayout.MoveItem(5, DownButton);
			ControlLayout1.MoveItem(1, AnswersTreeGrid);
			ControlLayoutQuestion.MoveItem(7, IsDecisionRequiredEdit);
			UserQuestionTabPanel.MoveItem(1, ActivityTab);
			ActivityTab.MoveItem(0, ActivityControlLayout1);
			ActivityControlLayout1.MoveItem(0, ActivityControlLayout2);
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
			ActivityControlLayout1.MoveItem(1, ActivityControlLayout11);
			ActivityControlLayout11.MoveItem(0, BaseProcessUserTaskPageControlLayout1);
			BaseProcessUserTaskPageControlLayout1.MoveItem(0, ShowExecutionPageEdit);
			ActivityControlLayout11.MoveItem(1, BaseProcessUserTaskPageControlLayout2);
			BaseProcessUserTaskPageControlLayout2.MoveItem(0, ShowInSchedulerEdit);
			ActivityControlLayout1.MoveItem(2, ActivityControlLayout5);
			ActivityControlLayout5.MoveItem(0, ActivityControlLayout6);
			ActivityControlLayout6.MoveItem(0, LeadEdit);
			ActivityControlLayout6.MoveItem(1, AccountEdit);
			ActivityControlLayout6.MoveItem(2, ContactEdit);
			ActivityControlLayout6.MoveItem(3, OpportunityEdit);
			ActivityControlLayout5.MoveItem(1, ActivityControlLayout7);
			ActivityControlLayout7.MoveItem(0, InvoiceEdit);
			ActivityControlLayout7.MoveItem(1, DocumentEdit);
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateQuestionUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new QuestionUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new QuestionUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new QuestionUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QuestionUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QuestionUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class QuestionUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> where TPage : Terrasoft.WebApp.QuestionUserTaskParametersEditPageSchemaUserControl
	{

		public QuestionUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QuestionUserTaskParametersEditPageEventsProcess";
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2b130167-25a2-45e9-9903-d8ce71dfbcff");
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

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
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

	#region Class: QuestionUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class QuestionUserTaskParametersEditPageEventsProcess : QuestionUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.QuestionUserTaskParametersEditPageSchemaUserControl>
	{

		public QuestionUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QuestionUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class QuestionUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl
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
			var process = (QuestionUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QuestionUserTaskParametersEditPageEventsProcess(UserConnection);
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
			SchemaName = "QuestionUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: QuestionUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class QuestionUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public QuestionUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QuestionUserTaskParametersEditPageEventsProcessSchema(QuestionUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QuestionUserTaskParametersEditPageEventsProcess";
			UId = new Guid("1d019ece-b0df-4e74-b20e-b8c29c5177d6");
			CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("30467d35-609e-4f88-a5b9-2b0b6497b2a5"),
				Name = "System.Runtime.Serialization.Formatters",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a7fde1d1-79c0-412a-bda3-e5b6e2f8b0c2"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c87ded00-3314-471d-86f6-1551df1ef8c9"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QuestionUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d019ece-b0df-4e74-b20e-b8c29c5177d6"));
		}

		#endregion

	}

	#endregion

}

