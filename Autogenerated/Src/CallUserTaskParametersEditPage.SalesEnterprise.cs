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

	#region Class: CallUserTaskParametersEditPageSchema

	/// <exclude/>
	public class CallUserTaskParametersEditPageSchema : Terrasoft.WebApp.CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema
	{

		#region Constructors: Public

		public CallUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CallUserTaskParametersEditPageSchema(CallUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateUserTaskTitleEdit() {
			UserTaskTitleEdit.Image = new ControlImage {};
			UserTaskTitleEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateStartInEdit() {
			StartInEdit.Image = new ControlImage {};
			StartInEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateStartInPeriodEdit() {
			StartInPeriodEdit.Image = new ControlImage {};
			StartInPeriodEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout8() {
			ActivityControlLayout8.Image = new ControlImage {};
			ActivityControlLayout8.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateDurationEdit() {
			DurationEdit.Image = new ControlImage {};
			DurationEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateDurationPeriodEdit() {
			DurationPeriodEdit.Image = new ControlImage {};
			DurationPeriodEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout9() {
			ActivityControlLayout9.Image = new ControlImage {};
			ActivityControlLayout9.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityCategoryEdit() {
			ActivityCategoryEdit.Image = new ControlImage {};
			ActivityCategoryEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout3() {
			ActivityControlLayout3.Image = new ControlImage {};
			ActivityControlLayout3.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateOwnerEdit() {
			OwnerEdit.Image = new ControlImage {};
			OwnerEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateRemindBeforeEdit() {
			RemindBeforeEdit.Image = new ControlImage {};
			RemindBeforeEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateRemindBeforePeriodEdit() {
			RemindBeforePeriodEdit.Image = new ControlImage {};
			RemindBeforePeriodEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout10() {
			ActivityControlLayout10.Image = new ControlImage {};
			ActivityControlLayout10.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateExecutionContextEdit() {
			ExecutionContextEdit.Image = new ControlImage {};
			ExecutionContextEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout4() {
			ActivityControlLayout4.Image = new ControlImage {};
			ActivityControlLayout4.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout2() {
			ActivityControlLayout2.Image = new ControlImage {};
			ActivityControlLayout2.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout1() {
			BaseProcessUserTaskPageControlLayout1.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout1.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout2() {
			BaseProcessUserTaskPageControlLayout2.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout2.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout11() {
			ActivityControlLayout11.Image = new ControlImage {};
			ActivityControlLayout11.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateLeadEdit() {
			LeadEdit.Image = new ControlImage {};
			LeadEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateAccountEdit() {
			AccountEdit.Image = new ControlImage {};
			AccountEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateContactEdit() {
			ContactEdit.Image = new ControlImage {};
			ContactEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateApplicationEdit() {
			ApplicationEdit.Image = new ControlImage {};
			ApplicationEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateCaseEdit() {
			CaseEdit.Image = new ControlImage {};
			CaseEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateProjectEdit() {
			ProjectEdit.Image = new ControlImage {};
			ProjectEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateOpportunityEdit() {
			OpportunityEdit.Image = new ControlImage {};
			OpportunityEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout6() {
			ActivityControlLayout6.Image = new ControlImage {};
			ActivityControlLayout6.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateInvoiceEdit() {
			InvoiceEdit.Image = new ControlImage {};
			InvoiceEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateDocumentEdit() {
			DocumentEdit.Image = new ControlImage {};
			DocumentEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateOrderEdit() {
			OrderEdit.Image = new ControlImage {};
			OrderEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateContractEdit() {
			ContractEdit.Image = new ControlImage {};
			ContractEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateProblemEdit() {
			ProblemEdit.Image = new ControlImage {};
			ProblemEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateChangeEdit() {
			ChangeEdit.Image = new ControlImage {};
			ChangeEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateReleaseEdit() {
			ReleaseEdit.Image = new ControlImage {};
			ReleaseEdit.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout7() {
			ActivityControlLayout7.Image = new ControlImage {};
			ActivityControlLayout7.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout5() {
			ActivityControlLayout5.Image = new ControlImage {};
			ActivityControlLayout5.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateActivityControlLayout1() {
			ActivityControlLayout1.Image = new ControlImage {};
			ActivityControlLayout1.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
			Name = "CallUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
			CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCallUserTaskParametersEditPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateCallUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new CallUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new CallUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CallUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CallUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CallUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class CallUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> where TPage : Terrasoft.WebApp.CallUserTaskParametersEditPageSchemaUserControl
	{

		public CallUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CallUserTaskParametersEditPageEventsProcess";
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7fd103c3-1b39-4c3a-ba5d-5f3c2319b880");
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

	#region Class: CallUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class CallUserTaskParametersEditPageEventsProcess : CallUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.CallUserTaskParametersEditPageSchemaUserControl>
	{

		public CallUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CallUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class CallUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl
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
			var process = (CallUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CallUserTaskParametersEditPageEventsProcess(UserConnection);
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
			SchemaName = "CallUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CallUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class CallUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.CallUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public CallUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CallUserTaskParametersEditPageEventsProcessSchema(CallUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CallUserTaskParametersEditPageEventsProcess";
			UId = new Guid("6d984d8d-bb65-46ac-be07-5c4813902766");
			CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a4f43841-1a07-43af-8595-0a8d1afb56c6");
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CallUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d984d8d-bb65-46ac-be07-5c4813902766"));
		}

		#endregion

	}

	#endregion

}

