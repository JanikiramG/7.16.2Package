namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using RecordEditMode = Terrasoft.Configuration.RecordEditMode;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using UIControls = Terrasoft.UI.WebControls.Controls;
	using VwSysClientUnitSchema = Terrasoft.Configuration.VwSysClientUnitSchema;

	#region Class: OpenEditPageUserTaskParametersEditPageSchema

	/// <exclude/>
	public class OpenEditPageUserTaskParametersEditPageSchema : Terrasoft.WebApp.OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema
	{

		#region Constructors: Public

		public OpenEditPageUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public OpenEditPageUserTaskParametersEditPageSchema(OpenEditPageUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateUserTaskTitleEdit() {
			UserTaskTitleEdit.Image = new ControlImage {};
			UserTaskTitleEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdatePageEdit() {
			PageEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			PageEdit.Image = new ControlImage {};
			PageEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateObjectEdit() {
			ObjectEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			ObjectEdit.Image = new ControlImage {};
			ObjectEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateEntityPageControlLayout1() {
			EntityPageControlLayout1.Image = new ControlImage {};
			EntityPageControlLayout1.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateNewRecordEdit() {
			NewRecordEdit.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateSetDefaultColumnValuesButton() {
			SetDefaultColumnValuesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SetDefaultColumnValuesButton.Image = new ControlImage {};
			SetDefaultColumnValuesButton.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateSetDefColumnValuesControlLayout() {
			SetDefColumnValuesControlLayout.Image = new ControlImage {};
			SetDefColumnValuesControlLayout.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateExistingRecordEdit() {
			ExistingRecordEdit.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateRecordIdEdit() {
			RecordIdEdit.Image = new ControlImage {};
			RecordIdEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateEditExistingEntityControlLayout() {
			EditExistingEntityControlLayout.Image = new ControlImage {};
			EditExistingEntityControlLayout.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateIsMatchConditionsEdit() {
			IsMatchConditionsEdit.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateGenerateDecisionsFromColumnEdit() {
			GenerateDecisionsFromColumnEdit.AjaxEvents.Check.IsProcessEventHandler = true;
		}

		private void UpdateExploreButton() {
			ExploreButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ExploreButton.Image = new ControlImage {};
			ExploreButton.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateDecisionalColumnEdit() {
			DecisionalColumnEdit.Image = new ControlImage {};
			DecisionalColumnEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateCreateResultListByColumnControlLayout() {
			CreateResultListByColumnControlLayout.Image = new ControlImage {};
			CreateResultListByColumnControlLayout.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateControlLayout5() {
			ControlLayout5.Image = new ControlImage {};
			ControlLayout5.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateGeneralParametersTab() {
			GeneralParametersTab.Image = new ControlImage {};
			GeneralParametersTab.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateStartInEdit() {
			StartInEdit.Image = new ControlImage {};
			StartInEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateStartInPeriodEdit() {
			StartInPeriodEdit.Image = new ControlImage {};
			StartInPeriodEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout8() {
			ActivityControlLayout8.Image = new ControlImage {};
			ActivityControlLayout8.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateDurationEdit() {
			DurationEdit.Image = new ControlImage {};
			DurationEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateDurationPeriodEdit() {
			DurationPeriodEdit.Image = new ControlImage {};
			DurationPeriodEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout9() {
			ActivityControlLayout9.Image = new ControlImage {};
			ActivityControlLayout9.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityCategoryEdit() {
			ActivityCategoryEdit.Image = new ControlImage {};
			ActivityCategoryEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout3() {
			ActivityControlLayout3.Image = new ControlImage {};
			ActivityControlLayout3.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateOwnerEdit() {
			OwnerEdit.Image = new ControlImage {};
			OwnerEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateRemindBeforeEdit() {
			RemindBeforeEdit.Image = new ControlImage {};
			RemindBeforeEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateRemindBeforePeriodEdit() {
			RemindBeforePeriodEdit.Image = new ControlImage {};
			RemindBeforePeriodEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout10() {
			ActivityControlLayout10.Image = new ControlImage {};
			ActivityControlLayout10.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateExecutionContextEdit() {
			ExecutionContextEdit.Image = new ControlImage {};
			ExecutionContextEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout4() {
			ActivityControlLayout4.Image = new ControlImage {};
			ActivityControlLayout4.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout2() {
			ActivityControlLayout2.Image = new ControlImage {};
			ActivityControlLayout2.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout1() {
			BaseProcessUserTaskPageControlLayout1.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout1.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout2() {
			BaseProcessUserTaskPageControlLayout2.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout2.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout11() {
			ActivityControlLayout11.Image = new ControlImage {};
			ActivityControlLayout11.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateLeadEdit() {
			LeadEdit.Image = new ControlImage {};
			LeadEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateAccountEdit() {
			AccountEdit.Image = new ControlImage {};
			AccountEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateContactEdit() {
			ContactEdit.Image = new ControlImage {};
			ContactEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateOpportunityEdit() {
			OpportunityEdit.Image = new ControlImage {};
			OpportunityEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout6() {
			ActivityControlLayout6.Image = new ControlImage {};
			ActivityControlLayout6.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateInvoiceEdit() {
			InvoiceEdit.Image = new ControlImage {};
			InvoiceEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateDocumentEdit() {
			DocumentEdit.Image = new ControlImage {};
			DocumentEdit.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout7() {
			ActivityControlLayout7.Image = new ControlImage {};
			ActivityControlLayout7.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout5() {
			ActivityControlLayout5.Image = new ControlImage {};
			ActivityControlLayout5.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityControlLayout1() {
			ActivityControlLayout1.Image = new ControlImage {};
			ActivityControlLayout1.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateActivityParametersTab() {
			ActivityParametersTab.Image = new ControlImage {};
			ActivityParametersTab.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateOpenEditPageTabPanel() {
			OpenEditPageTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
		}

		private void UpdateOpenEditPageControlLayout() {
			OpenEditPageControlLayout.Image = new ControlImage {};
			OpenEditPageControlLayout.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
			Name = "OpenEditPageUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72");
			UseProfile = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpenEditPageUserTaskParametersEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			UpdateOpenEditPageControlLayout();
			UpdateOpenEditPageTabPanel();
			UpdateActivityParametersTab();
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
			UpdateGeneralParametersTab();
			UpdateControlLayout5();
			UpdateCreateResultListByColumnControlLayout();
			UpdateDecisionalColumnEdit();
			UpdateExploreButton();
			UpdateGenerateDecisionsFromColumnEdit();
			UpdateIsMatchConditionsEdit();
			UpdateEditExistingEntityControlLayout();
			UpdateRecordIdEdit();
			UpdateExistingRecordEdit();
			UpdateSetDefColumnValuesControlLayout();
			UpdateSetDefaultColumnValuesButton();
			UpdateNewRecordEdit();
			UpdateEntityPageControlLayout1();
			UpdateObjectEdit();
			UpdatePageEdit();
			UpdateUserTaskTitleEdit();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.MoveItem(0, OpenEditPageControlLayout);
			OpenEditPageControlLayout.MoveItem(0, OpenEditPageTabPanel);
			OpenEditPageTabPanel.MoveItem(0, GeneralParametersTab);
			GeneralParametersTab.MoveItem(0, ControlLayout5);
			ControlLayout5.MoveItem(0, UserTaskTitleEdit);
			ControlLayout5.MoveItem(1, RecommendationEdit);
			ControlLayout5.MoveItem(2, EntityPageControlLayout1);
			EntityPageControlLayout1.MoveItem(0, PageEdit);
			EntityPageControlLayout1.MoveItem(1, ObjectEdit);
			ControlLayout5.MoveItem(3, NewRecordEdit);
			ControlLayout5.MoveItem(4, SetDefColumnValuesControlLayout);
			SetDefColumnValuesControlLayout.MoveItem(0, SetDefaultColumnValuesButton);
			ControlLayout5.MoveItem(5, ExistingRecordEdit);
			ControlLayout5.MoveItem(6, EditExistingEntityControlLayout);
			EditExistingEntityControlLayout.MoveItem(0, RecordIdEdit);
			ControlLayout5.MoveItem(7, IsMatchConditionsEdit);
			ControlLayout5.MoveItem(8, FilterEdit);
			ControlLayout5.MoveItem(9, GenerateDecisionsFromColumnEdit);
			ControlLayout5.MoveItem(10, CreateResultListByColumnControlLayout);
			CreateResultListByColumnControlLayout.MoveItem(0, DecisionalColumnEdit);
			DecisionalColumnEdit.MoveItem(0, ExploreButton);
			OpenEditPageTabPanel.MoveItem(1, ActivityParametersTab);
			ActivityParametersTab.MoveItem(0, ActivityControlLayout1);
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
			TopLevelControl.MoveItem(3, EntityDataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateOpenEditPageUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new OpenEditPageUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new OpenEditPageUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new OpenEditPageUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new OpenEditPageUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: OpenEditPageUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class OpenEditPageUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> where TPage : Terrasoft.WebApp.OpenEditPageUserTaskParametersEditPageSchemaUserControl
	{

		public OpenEditPageUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpenEditPageUserTaskParametersEditPageEventsProcess";
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("35dd7323-dddb-49bb-a9d8-6541e628e475");
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

	#region Class: OpenEditPageUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class OpenEditPageUserTaskParametersEditPageEventsProcess : OpenEditPageUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.OpenEditPageUserTaskParametersEditPageSchemaUserControl>
	{

		public OpenEditPageUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpenEditPageUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class OpenEditPageUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl
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
			var process = (OpenEditPageUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new OpenEditPageUserTaskParametersEditPageEventsProcess(UserConnection);
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
			SchemaName = "OpenEditPageUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: OpenEditPageUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class OpenEditPageUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public OpenEditPageUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpenEditPageUserTaskParametersEditPageEventsProcessSchema(OpenEditPageUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpenEditPageUserTaskParametersEditPageEventsProcess";
			UId = new Guid("b55eaab4-da2a-48f8-a3d5-288753efe99e");
			CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c");
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
				UId = new Guid("e125c1cb-ec25-497c-b8f9-3979ca4b0369"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e4282000-e552-4e32-ba70-5d53aa639f9b"),
				Name = "Terrasoft.Configuration.RecordEditMode",
				Alias = "RecordEditMode",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("046d9c11-d04e-4e1a-b303-c574766cc84e"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e849c80a-bb45-4632-b5ed-1d2ab85b2155"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6169a4ac-da64-4e3a-a66c-d1e924fd32ab"),
				Name = "Terrasoft.Configuration",
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
				UId = new Guid("041d0e0d-f21a-4205-b82f-48ff17af056a"),
				Name = "Terrasoft.Configuration.VwSysClientUnitSchema",
				Alias = "VwSysClientUnitSchema",
				CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpenEditPageUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b55eaab4-da2a-48f8-a3d5-288753efe99e"));
		}

		#endregion

	}

	#endregion

}

