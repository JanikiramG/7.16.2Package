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

	#region Class: BaseProcessUserTaskParametersEditPageSchema

	/// <exclude/>
	public class BaseProcessUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout1 {
			get {
				return _activityControlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _userTaskTitleEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return _userTaskTitleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _recommendationEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit RecommendationEdit {
			get {
				return _recommendationEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _informationOnStepMemoEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit InformationOnStepMemoEdit {
			get {
				return _informationOnStepMemoEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout2 {
			get {
				return _activityControlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout3 {
			get {
				return _activityControlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout8;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout8 {
			get {
				return _activityControlLayout8;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _startInEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit StartInEdit {
			get {
				return _startInEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _startInPeriodEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit StartInPeriodEdit {
			get {
				return _startInPeriodEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout9;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout9 {
			get {
				return _activityControlLayout9;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _durationEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit DurationEdit {
			get {
				return _durationEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _durationPeriodEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit DurationPeriodEdit {
			get {
				return _durationPeriodEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _activityCategoryEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ActivityCategoryEdit {
			get {
				return _activityCategoryEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout4 {
			get {
				return _activityControlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _ownerEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit OwnerEdit {
			get {
				return _ownerEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout10;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout10 {
			get {
				return _activityControlLayout10;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _remindBeforeEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit RemindBeforeEdit {
			get {
				return _remindBeforeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _remindBeforePeriodEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit RemindBeforePeriodEdit {
			get {
				return _remindBeforePeriodEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _executionContextEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ExecutionContextEdit {
			get {
				return _executionContextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout11;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout11 {
			get {
				return _activityControlLayout11;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _baseProcessUserTaskPageControlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BaseProcessUserTaskPageControlLayout1 {
			get {
				return _baseProcessUserTaskPageControlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _showExecutionPageEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ShowExecutionPageEdit {
			get {
				return _showExecutionPageEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _baseProcessUserTaskPageControlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BaseProcessUserTaskPageControlLayout2 {
			get {
				return _baseProcessUserTaskPageControlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _showInSchedulerEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInSchedulerEdit {
			get {
				return _showInSchedulerEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout5 {
			get {
				return _activityControlLayout5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout6;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout6 {
			get {
				return _activityControlLayout6;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _leadEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit LeadEdit {
			get {
				return _leadEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _accountEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit AccountEdit {
			get {
				return _accountEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _contactEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ContactEdit {
			get {
				return _contactEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _applicationEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ApplicationEdit {
			get {
				return _applicationEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _caseEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CaseEdit {
			get {
				return _caseEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _projectEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ProjectEdit {
			get {
				return _projectEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _opportunityEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit OpportunityEdit {
			get {
				return _opportunityEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _activityControlLayout7;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout7 {
			get {
				return _activityControlLayout7;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _invoiceEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit InvoiceEdit {
			get {
				return _invoiceEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _documentEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit DocumentEdit {
			get {
				return _documentEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _orderEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit OrderEdit {
			get {
				return _orderEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _contractEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ContractEdit {
			get {
				return _contractEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _problemEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ProblemEdit {
			get {
				return _problemEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _changeEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ChangeEdit {
			get {
				return _changeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _releaseEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ReleaseEdit {
			get {
				return _releaseEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseProcessUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseProcessUserTaskParametersEditPageSchema(BaseProcessUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			RealUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			Name = "BaseProcessUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			Width = 600;
			Height = 500;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseProcessUserTaskParametersEditPageEventsProcessSchema();
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
			TopControlLayout.InsertItem(0, CreateActivityControlLayout1());
			ActivityControlLayout1.InsertItem(0, CreateUserTaskTitleEdit());
			ActivityControlLayout1.InsertItem(1, CreateRecommendationEdit());
			ActivityControlLayout1.InsertItem(2, CreateInformationOnStepMemoEdit());
			ActivityControlLayout1.InsertItem(3, CreateActivityControlLayout2());
			ActivityControlLayout2.InsertItem(0, CreateActivityControlLayout3());
			ActivityControlLayout3.InsertItem(0, CreateActivityControlLayout8());
			ActivityControlLayout8.InsertItem(0, CreateStartInEdit());
			ActivityControlLayout8.InsertItem(1, CreateStartInPeriodEdit());
			ActivityControlLayout3.InsertItem(1, CreateActivityControlLayout9());
			ActivityControlLayout9.InsertItem(0, CreateDurationEdit());
			ActivityControlLayout9.InsertItem(1, CreateDurationPeriodEdit());
			ActivityControlLayout3.InsertItem(2, CreateActivityCategoryEdit());
			ActivityControlLayout2.InsertItem(1, CreateActivityControlLayout4());
			ActivityControlLayout4.InsertItem(0, CreateOwnerEdit());
			ActivityControlLayout4.InsertItem(1, CreateActivityControlLayout10());
			ActivityControlLayout10.InsertItem(0, CreateRemindBeforeEdit());
			ActivityControlLayout10.InsertItem(1, CreateRemindBeforePeriodEdit());
			ActivityControlLayout4.InsertItem(2, CreateExecutionContextEdit());
			ActivityControlLayout1.InsertItem(4, CreateActivityControlLayout11());
			ActivityControlLayout11.InsertItem(0, CreateBaseProcessUserTaskPageControlLayout1());
			BaseProcessUserTaskPageControlLayout1.InsertItem(0, CreateShowExecutionPageEdit());
			ActivityControlLayout11.InsertItem(1, CreateBaseProcessUserTaskPageControlLayout2());
			BaseProcessUserTaskPageControlLayout2.InsertItem(0, CreateShowInSchedulerEdit());
			ActivityControlLayout1.InsertItem(5, CreateActivityControlLayout5());
			ActivityControlLayout5.InsertItem(0, CreateActivityControlLayout6());
			ActivityControlLayout6.InsertItem(0, CreateLeadEdit());
			ActivityControlLayout6.InsertItem(1, CreateAccountEdit());
			ActivityControlLayout6.InsertItem(2, CreateContactEdit());
			ActivityControlLayout6.InsertItem(3, CreateApplicationEdit());
			ActivityControlLayout6.InsertItem(4, CreateCaseEdit());
			ActivityControlLayout6.InsertItem(5, CreateProjectEdit());
			ActivityControlLayout6.InsertItem(6, CreateOpportunityEdit());
			ActivityControlLayout5.InsertItem(1, CreateActivityControlLayout7());
			ActivityControlLayout7.InsertItem(0, CreateInvoiceEdit());
			ActivityControlLayout7.InsertItem(1, CreateDocumentEdit());
			ActivityControlLayout7.InsertItem(2, CreateOrderEdit());
			ActivityControlLayout7.InsertItem(3, CreateContractEdit());
			ActivityControlLayout7.InsertItem(4, CreateProblemEdit());
			ActivityControlLayout7.InsertItem(5, CreateChangeEdit());
			ActivityControlLayout7.InsertItem(6, CreateReleaseEdit());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseProcessUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new BaseProcessUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateUserTaskTitleEdit() {
			_userTaskTitleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_userTaskTitleEdit.UId = new Guid("524f8333-16c7-467a-803d-c7c43e2d5c06");
			_userTaskTitleEdit.Name = "UserTaskTitleEdit";
			_userTaskTitleEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_userTaskTitleEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_userTaskTitleEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_userTaskTitleEdit.Tag = "";
			_userTaskTitleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_userTaskTitleEdit.Image = new ControlImage {};
			_userTaskTitleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _userTaskTitleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateRecommendationEdit() {
			_recommendationEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_recommendationEdit.UId = new Guid("a2bb1ef6-e573-4427-ab7d-4588b711c061");
			_recommendationEdit.Name = "RecommendationEdit";
			_recommendationEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_recommendationEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_recommendationEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_recommendationEdit.Tag = "";
			_recommendationEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_recommendationEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_recommendationEdit.Required = true;
			return _recommendationEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateInformationOnStepMemoEdit() {
			_informationOnStepMemoEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_informationOnStepMemoEdit.UId = new Guid("4ca44acc-0fb5-4b40-a39c-e0d5ac4510e7");
			_informationOnStepMemoEdit.Name = "InformationOnStepMemoEdit";
			_informationOnStepMemoEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_informationOnStepMemoEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_informationOnStepMemoEdit.CreatedInPackageId = new Guid("726732c0-931c-4e11-9479-6aff326ae941");
			_informationOnStepMemoEdit.Tag = "";
			_informationOnStepMemoEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_informationOnStepMemoEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _informationOnStepMemoEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateStartInEdit() {
			_startInEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_startInEdit.UId = new Guid("4648e6d9-9f26-49e4-91f7-e36cfdb4b38f");
			_startInEdit.Name = "StartInEdit";
			_startInEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_startInEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_startInEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_startInEdit.Tag = "";
			_startInEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_startInEdit.Image = new ControlImage {};
			_startInEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _startInEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateStartInPeriodEdit() {
			_startInPeriodEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_startInPeriodEdit.UId = new Guid("8d988672-bf1f-47ff-b7a2-99830748a9c7");
			_startInPeriodEdit.Name = "StartInPeriodEdit";
			_startInPeriodEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_startInPeriodEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_startInPeriodEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_startInPeriodEdit.Tag = "";
			_startInPeriodEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_startInPeriodEdit.Image = new ControlImage {};
			_startInPeriodEdit.Width = System.Web.UI.WebControls.Unit.Percentage(30);
			_startInPeriodEdit.Required = true;
			return _startInPeriodEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout8() {
			_activityControlLayout8 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout8.UId = new Guid("29ffe306-b1e9-4714-8dd9-832157b7b0cb");
			_activityControlLayout8.Name = "ActivityControlLayout8";
			_activityControlLayout8.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout8.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout8.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout8.Tag = "";
			_activityControlLayout8.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout8.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_activityControlLayout8.FitHeightByContent = true;
			_activityControlLayout8.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout8.StartNewAlignGroup = false;
			_activityControlLayout8.Image = new ControlImage {};
			_activityControlLayout8.Edges = "";
			return _activityControlLayout8;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateDurationEdit() {
			_durationEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_durationEdit.UId = new Guid("08a3efca-7d41-4845-86a5-67dc3fb9717d");
			_durationEdit.Name = "DurationEdit";
			_durationEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_durationEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_durationEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_durationEdit.Tag = "";
			_durationEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_durationEdit.Image = new ControlImage {};
			_durationEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _durationEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateDurationPeriodEdit() {
			_durationPeriodEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_durationPeriodEdit.UId = new Guid("7f8845c0-b763-4fea-b04b-7c0b535ced14");
			_durationPeriodEdit.Name = "DurationPeriodEdit";
			_durationPeriodEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_durationPeriodEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_durationPeriodEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_durationPeriodEdit.Tag = "";
			_durationPeriodEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_durationPeriodEdit.Image = new ControlImage {};
			_durationPeriodEdit.Width = System.Web.UI.WebControls.Unit.Percentage(30);
			_durationPeriodEdit.Required = true;
			return _durationPeriodEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout9() {
			_activityControlLayout9 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout9.UId = new Guid("45fc1db6-a7cb-4367-b125-6fac33fd0e98");
			_activityControlLayout9.Name = "ActivityControlLayout9";
			_activityControlLayout9.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout9.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout9.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout9.Tag = "";
			_activityControlLayout9.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_activityControlLayout9.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_activityControlLayout9.FitHeightByContent = true;
			_activityControlLayout9.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout9.StartNewAlignGroup = false;
			_activityControlLayout9.Image = new ControlImage {};
			_activityControlLayout9.Edges = "";
			return _activityControlLayout9;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateActivityCategoryEdit() {
			_activityCategoryEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_activityCategoryEdit.UId = new Guid("b104175f-54ef-4af0-9e9a-337d761724e2");
			_activityCategoryEdit.Name = "ActivityCategoryEdit";
			_activityCategoryEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityCategoryEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityCategoryEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityCategoryEdit.Tag = "";
			_activityCategoryEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_activityCategoryEdit.Image = new ControlImage {};
			_activityCategoryEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityCategoryEdit.Required = true;
			return _activityCategoryEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout3() {
			_activityControlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout3.UId = new Guid("57e0ab71-327d-4dd5-a719-f3242b916d39");
			_activityControlLayout3.Name = "ActivityControlLayout3";
			_activityControlLayout3.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout3.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout3.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout3.Tag = "";
			_activityControlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_activityControlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_activityControlLayout3.FitHeightByContent = true;
			_activityControlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(50);
			_activityControlLayout3.StartNewAlignGroup = false;
			_activityControlLayout3.Image = new ControlImage {};
			_activityControlLayout3.Edges = "";
			return _activityControlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateOwnerEdit() {
			_ownerEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_ownerEdit.UId = new Guid("321545ca-03ca-4744-b7ef-bdad82ceb20f");
			_ownerEdit.Name = "OwnerEdit";
			_ownerEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_ownerEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_ownerEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_ownerEdit.Tag = "";
			_ownerEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_ownerEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_ownerEdit.Image = new ControlImage {};
			_ownerEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _ownerEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateRemindBeforeEdit() {
			_remindBeforeEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_remindBeforeEdit.UId = new Guid("d1110acb-b3ff-491c-85aa-d3aa1e1e43fa");
			_remindBeforeEdit.Name = "RemindBeforeEdit";
			_remindBeforeEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_remindBeforeEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_remindBeforeEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_remindBeforeEdit.Tag = "";
			_remindBeforeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_remindBeforeEdit.Image = new ControlImage {};
			_remindBeforeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _remindBeforeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateRemindBeforePeriodEdit() {
			_remindBeforePeriodEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_remindBeforePeriodEdit.UId = new Guid("ae5acedd-14f0-413b-ab40-5a1f1dad0759");
			_remindBeforePeriodEdit.Name = "RemindBeforePeriodEdit";
			_remindBeforePeriodEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_remindBeforePeriodEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_remindBeforePeriodEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_remindBeforePeriodEdit.Tag = "";
			_remindBeforePeriodEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_remindBeforePeriodEdit.Image = new ControlImage {};
			_remindBeforePeriodEdit.Width = System.Web.UI.WebControls.Unit.Percentage(30);
			_remindBeforePeriodEdit.Required = true;
			return _remindBeforePeriodEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout10() {
			_activityControlLayout10 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout10.UId = new Guid("f59a68be-6f7b-465e-a6e1-d7cf5d7211e9");
			_activityControlLayout10.Name = "ActivityControlLayout10";
			_activityControlLayout10.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout10.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout10.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout10.Tag = "";
			_activityControlLayout10.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_activityControlLayout10.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_activityControlLayout10.FitHeightByContent = true;
			_activityControlLayout10.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout10.StartNewAlignGroup = false;
			_activityControlLayout10.Image = new ControlImage {};
			_activityControlLayout10.Edges = "";
			return _activityControlLayout10;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateExecutionContextEdit() {
			_executionContextEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_executionContextEdit.UId = new Guid("dbbafd52-e58d-4757-a0a5-924c0f4af1d4");
			_executionContextEdit.Name = "ExecutionContextEdit";
			_executionContextEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_executionContextEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_executionContextEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_executionContextEdit.Tag = "";
			_executionContextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_executionContextEdit.DataValueTypeUId = new Guid("c0f04627-4620-4bc0-84e5-9419dc8516b1");
			_executionContextEdit.Image = new ControlImage {};
			_executionContextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_executionContextEdit.Hidden = true;
			return _executionContextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout4() {
			_activityControlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout4.UId = new Guid("c8d43851-0a71-4333-9be8-a430cb1aacf1");
			_activityControlLayout4.Name = "ActivityControlLayout4";
			_activityControlLayout4.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout4.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout4.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout4.Tag = "";
			_activityControlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_activityControlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_activityControlLayout4.FitHeightByContent = true;
			_activityControlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(50);
			_activityControlLayout4.StartNewAlignGroup = false;
			_activityControlLayout4.Image = new ControlImage {};
			_activityControlLayout4.Edges = "";
			return _activityControlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout2() {
			_activityControlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout2.UId = new Guid("13510695-93df-437b-a35d-37995ecb4d4c");
			_activityControlLayout2.Name = "ActivityControlLayout2";
			_activityControlLayout2.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout2.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout2.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout2.Tag = "";
			_activityControlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_activityControlLayout2.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_activityControlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_activityControlLayout2.FitHeightByContent = true;
			_activityControlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout2.StartNewAlignGroup = false;
			_activityControlLayout2.Image = new ControlImage {};
			_activityControlLayout2.Edges = "";
			return _activityControlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateShowExecutionPageEdit() {
			_showExecutionPageEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_showExecutionPageEdit.UId = new Guid("7599293a-da49-4898-8818-30d14b07b1cf");
			_showExecutionPageEdit.Name = "ShowExecutionPageEdit";
			_showExecutionPageEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_showExecutionPageEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_showExecutionPageEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_showExecutionPageEdit.Tag = "";
			_showExecutionPageEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showExecutionPageEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_showExecutionPageEdit.AlignedByCaption = false;
			return _showExecutionPageEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBaseProcessUserTaskPageControlLayout1() {
			_baseProcessUserTaskPageControlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_baseProcessUserTaskPageControlLayout1.UId = new Guid("4edcb1d8-648f-4d94-ab9b-bcac00ec459e");
			_baseProcessUserTaskPageControlLayout1.Name = "BaseProcessUserTaskPageControlLayout1";
			_baseProcessUserTaskPageControlLayout1.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_baseProcessUserTaskPageControlLayout1.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_baseProcessUserTaskPageControlLayout1.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_baseProcessUserTaskPageControlLayout1.Tag = "";
			_baseProcessUserTaskPageControlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_baseProcessUserTaskPageControlLayout1.FitHeightByContent = true;
			_baseProcessUserTaskPageControlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseProcessUserTaskPageControlLayout1.StartNewAlignGroup = false;
			_baseProcessUserTaskPageControlLayout1.Image = new ControlImage {};
			_baseProcessUserTaskPageControlLayout1.Edges = "";
			return _baseProcessUserTaskPageControlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateShowInSchedulerEdit() {
			_showInSchedulerEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_showInSchedulerEdit.UId = new Guid("0a592251-7787-4b2c-9978-3cb823e2c099");
			_showInSchedulerEdit.Name = "ShowInSchedulerEdit";
			_showInSchedulerEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_showInSchedulerEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_showInSchedulerEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_showInSchedulerEdit.Tag = "";
			_showInSchedulerEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showInSchedulerEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _showInSchedulerEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBaseProcessUserTaskPageControlLayout2() {
			_baseProcessUserTaskPageControlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_baseProcessUserTaskPageControlLayout2.UId = new Guid("7ad4bcfc-f24f-4903-82ab-4233448cdc2b");
			_baseProcessUserTaskPageControlLayout2.Name = "BaseProcessUserTaskPageControlLayout2";
			_baseProcessUserTaskPageControlLayout2.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_baseProcessUserTaskPageControlLayout2.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_baseProcessUserTaskPageControlLayout2.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_baseProcessUserTaskPageControlLayout2.Tag = "";
			_baseProcessUserTaskPageControlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_baseProcessUserTaskPageControlLayout2.FitHeightByContent = true;
			_baseProcessUserTaskPageControlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseProcessUserTaskPageControlLayout2.StartNewAlignGroup = false;
			_baseProcessUserTaskPageControlLayout2.Image = new ControlImage {};
			_baseProcessUserTaskPageControlLayout2.Edges = "";
			return _baseProcessUserTaskPageControlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout11() {
			_activityControlLayout11 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout11.UId = new Guid("750fb9a6-dd6e-43b7-8e0d-8fc396cfedf6");
			_activityControlLayout11.Name = "ActivityControlLayout11";
			_activityControlLayout11.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout11.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout11.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout11.Tag = "";
			_activityControlLayout11.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_activityControlLayout11.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_activityControlLayout11.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_activityControlLayout11.FitHeightByContent = true;
			_activityControlLayout11.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout11.StartNewAlignGroup = false;
			_activityControlLayout11.Image = new ControlImage {};
			_activityControlLayout11.Edges = "";
			return _activityControlLayout11;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateLeadEdit() {
			_leadEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_leadEdit.UId = new Guid("f180ae58-2a70-4b3b-ba9c-e059325121b4");
			_leadEdit.Name = "LeadEdit";
			_leadEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_leadEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_leadEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_leadEdit.Tag = "";
			_leadEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_leadEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_leadEdit.Image = new ControlImage {};
			_leadEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _leadEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateAccountEdit() {
			_accountEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_accountEdit.UId = new Guid("ef0fdb47-a4a2-496b-9a4b-4aa2041410a9");
			_accountEdit.Name = "AccountEdit";
			_accountEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_accountEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_accountEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_accountEdit.Tag = "";
			_accountEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_accountEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_accountEdit.Image = new ControlImage {};
			_accountEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _accountEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateContactEdit() {
			_contactEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_contactEdit.UId = new Guid("d7f1d431-b9f9-4405-9a42-18eca163900e");
			_contactEdit.Name = "ContactEdit";
			_contactEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_contactEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_contactEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_contactEdit.Tag = "";
			_contactEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_contactEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_contactEdit.Image = new ControlImage {};
			_contactEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _contactEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateApplicationEdit() {
			_applicationEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_applicationEdit.UId = new Guid("3f0d351c-f978-4be0-aea5-8505ed246645");
			_applicationEdit.Name = "ApplicationEdit";
			_applicationEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_applicationEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_applicationEdit.CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90");
			_applicationEdit.Tag = "";
			_applicationEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_applicationEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_applicationEdit.Image = new ControlImage {};
			_applicationEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _applicationEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateCaseEdit() {
			_caseEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_caseEdit.UId = new Guid("fd5d9786-cf33-4fcd-bc62-a0cb6429d02a");
			_caseEdit.Name = "CaseEdit";
			_caseEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_caseEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_caseEdit.CreatedInPackageId = new Guid("87d872f4-b5ed-4a1e-b58d-84649fa0a124");
			_caseEdit.Tag = "";
			_caseEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_caseEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_caseEdit.Image = new ControlImage {};
			_caseEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _caseEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateProjectEdit() {
			_projectEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_projectEdit.UId = new Guid("c76cfbc3-c739-42d2-a4ab-d6d2ef096164");
			_projectEdit.Name = "ProjectEdit";
			_projectEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_projectEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_projectEdit.CreatedInPackageId = new Guid("75f9eeee-f1fe-4547-94c4-c51a87b30ae3");
			_projectEdit.Tag = "";
			_projectEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_projectEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_projectEdit.Image = new ControlImage {};
			_projectEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _projectEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateOpportunityEdit() {
			_opportunityEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_opportunityEdit.UId = new Guid("0d899da1-82eb-42f6-a25c-292004c5dcba");
			_opportunityEdit.Name = "OpportunityEdit";
			_opportunityEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_opportunityEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_opportunityEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_opportunityEdit.Tag = "";
			_opportunityEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_opportunityEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_opportunityEdit.Image = new ControlImage {};
			_opportunityEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _opportunityEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout6() {
			_activityControlLayout6 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout6.UId = new Guid("2697639d-f1b4-4ff5-b00f-ef029b0bcce9");
			_activityControlLayout6.Name = "ActivityControlLayout6";
			_activityControlLayout6.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout6.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout6.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout6.Tag = "";
			_activityControlLayout6.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_activityControlLayout6.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_activityControlLayout6.FitHeightByContent = true;
			_activityControlLayout6.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout6.StartNewAlignGroup = false;
			_activityControlLayout6.Image = new ControlImage {};
			_activityControlLayout6.Edges = "";
			return _activityControlLayout6;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateInvoiceEdit() {
			_invoiceEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_invoiceEdit.UId = new Guid("3dacfb6d-a4c0-4203-aad3-f801180ac713");
			_invoiceEdit.Name = "InvoiceEdit";
			_invoiceEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_invoiceEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_invoiceEdit.CreatedInPackageId = new Guid("a912a08b-896f-4924-9743-535e00422571");
			_invoiceEdit.Tag = "";
			_invoiceEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_invoiceEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_invoiceEdit.Image = new ControlImage {};
			_invoiceEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _invoiceEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateDocumentEdit() {
			_documentEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_documentEdit.UId = new Guid("61899bd5-a7e2-4567-9333-b35f8d765cc3");
			_documentEdit.Name = "DocumentEdit";
			_documentEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_documentEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_documentEdit.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_documentEdit.Tag = "";
			_documentEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_documentEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_documentEdit.Image = new ControlImage {};
			_documentEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _documentEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateOrderEdit() {
			_orderEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_orderEdit.UId = new Guid("53b5f46e-25b9-4bd8-aacb-3f48d88e9a09");
			_orderEdit.Name = "OrderEdit";
			_orderEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_orderEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_orderEdit.CreatedInPackageId = new Guid("062eef53-10e4-4919-bfbc-2dd738d2904e");
			_orderEdit.Tag = "";
			_orderEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_orderEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_orderEdit.Image = new ControlImage {};
			_orderEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _orderEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateContractEdit() {
			_contractEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_contractEdit.UId = new Guid("9fa2da83-a15a-4ce5-aaa0-0d0fc84d2a9f");
			_contractEdit.Name = "ContractEdit";
			_contractEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_contractEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_contractEdit.CreatedInPackageId = new Guid("632a7e51-1efe-4367-ac83-73c7d59b6eb1");
			_contractEdit.Tag = "";
			_contractEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_contractEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_contractEdit.Image = new ControlImage {};
			_contractEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _contractEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateProblemEdit() {
			_problemEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_problemEdit.UId = new Guid("3a564dcf-e947-4f7d-a5ef-d8150fcc39b6");
			_problemEdit.Name = "ProblemEdit";
			_problemEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_problemEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_problemEdit.CreatedInPackageId = new Guid("87d872f4-b5ed-4a1e-b58d-84649fa0a124");
			_problemEdit.Tag = "";
			_problemEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_problemEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_problemEdit.Image = new ControlImage {};
			_problemEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _problemEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateChangeEdit() {
			_changeEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_changeEdit.UId = new Guid("d7cfd3ed-c6b3-4c1e-a1f8-46ab300f6d44");
			_changeEdit.Name = "ChangeEdit";
			_changeEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_changeEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_changeEdit.CreatedInPackageId = new Guid("87d872f4-b5ed-4a1e-b58d-84649fa0a124");
			_changeEdit.Tag = "";
			_changeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_changeEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_changeEdit.Image = new ControlImage {};
			_changeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _changeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateReleaseEdit() {
			_releaseEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_releaseEdit.UId = new Guid("7d6513bc-f972-4621-a992-cc590f415164");
			_releaseEdit.Name = "ReleaseEdit";
			_releaseEdit.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_releaseEdit.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_releaseEdit.CreatedInPackageId = new Guid("87d872f4-b5ed-4a1e-b58d-84649fa0a124");
			_releaseEdit.Tag = "";
			_releaseEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_releaseEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_releaseEdit.Image = new ControlImage {};
			_releaseEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _releaseEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout7() {
			_activityControlLayout7 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout7.UId = new Guid("45febb6e-9aff-49cb-abbd-e3cffbf75d3a");
			_activityControlLayout7.Name = "ActivityControlLayout7";
			_activityControlLayout7.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout7.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout7.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout7.Tag = "";
			_activityControlLayout7.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_activityControlLayout7.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_activityControlLayout7.FitHeightByContent = true;
			_activityControlLayout7.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout7.StartNewAlignGroup = false;
			_activityControlLayout7.Image = new ControlImage {};
			_activityControlLayout7.Edges = "";
			return _activityControlLayout7;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout5() {
			_activityControlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout5.UId = new Guid("2d8bb81a-9701-466f-ac0a-bc7dc692f1e8");
			_activityControlLayout5.Name = "ActivityControlLayout5";
			_activityControlLayout5.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout5.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout5.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout5.Tag = "";
			_activityControlLayout5.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout5.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_activityControlLayout5.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_activityControlLayout5.FitHeightByContent = true;
			_activityControlLayout5.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout5.StartNewAlignGroup = false;
			_activityControlLayout5.Image = new ControlImage {};
			_activityControlLayout5.Edges = "";
			return _activityControlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActivityControlLayout1() {
			_activityControlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_activityControlLayout1.UId = new Guid("c9d25704-6150-4b2a-8d86-8f71e1fadf64");
			_activityControlLayout1.Name = "ActivityControlLayout1";
			_activityControlLayout1.CreatedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout1.ModifiedInSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			_activityControlLayout1.CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
			_activityControlLayout1.Tag = "";
			_activityControlLayout1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_activityControlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activityControlLayout1.StartNewAlignGroup = false;
			_activityControlLayout1.Image = new ControlImage {};
			_activityControlLayout1.Edges = "";
			_activityControlLayout1.AutoScroll = true;
			return _activityControlLayout1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseProcessUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseProcessUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseProcessUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseProcessUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class BaseProcessUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchemaUserControl
	{

		public BaseProcessUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseProcessUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
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

		public virtual bool IsTitleChanged {
			get;
			set;
		}

		public virtual bool IsUsedActivityControls {
			get;
			set;
		}

		public virtual bool IsNotFirstInvokeBaseActivityInit {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("4834298f-2666-4190-8c3b-c8d0f1a4bc77"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _chieldInitStartMessage;
		public ProcessFlowElement ChieldInitStartMessage {
			get {
				return _chieldInitStartMessage ?? (_chieldInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChieldInitStartMessage",
					SchemaElementUId = new Guid("0e2217f1-4711-42aa-9cb6-2c6ea7738492"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _chieldInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ChieldInitIntermediateThrowMessageEvent {
			get {
				return _chieldInitIntermediateThrowMessageEvent ?? (_chieldInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ChieldInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("bcf2a5db-103e-4ef4-b858-62b4d2bd38f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("e2593b77-3315-40d0-a618-b67923c6a70b"),
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
					SchemaElementUId = new Guid("3f5e1ee0-93d8-4774-bea1-d2ea7f9dcc95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("f3ce1a69-98e2-4b4b-81a4-2fd373262d97"),
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
					SchemaElementUId = new Guid("aeda8b3b-d8a7-4a25-92fb-8d68a7ea618c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("6cb38234-46c2-40ce-9dba-834b31f7c8fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _userTaskRecommendationEditChangeStartMessage;
		public ProcessFlowElement UserTaskRecommendationEditChangeStartMessage {
			get {
				return _userTaskRecommendationEditChangeStartMessage ?? (_userTaskRecommendationEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UserTaskRecommendationEditChangeStartMessage",
					SchemaElementUId = new Guid("71c03d9e-1a28-45f6-aa20-4bc39dddecd9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _userTaskRecommendationEditChangeScriptTask;
		public ProcessScriptTask UserTaskRecommendationEditChangeScriptTask {
			get {
				return _userTaskRecommendationEditChangeScriptTask ?? (_userTaskRecommendationEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UserTaskRecommendationEditChangeScriptTask",
					SchemaElementUId = new Guid("f2f57e42-986e-4d90-851f-ad49fc6362dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UserTaskRecommendationEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("ef4a7e2c-50b3-4ccd-a4a8-5906c759f6e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _titleEditChangeStartMessage;
		public ProcessFlowElement TitleEditChangeStartMessage {
			get {
				return _titleEditChangeStartMessage ?? (_titleEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TitleEditChangeStartMessage",
					SchemaElementUId = new Guid("1a20a9dd-065d-4604-ac82-b0b4df0fce03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _titleEditChangeScriptTask;
		public ProcessScriptTask TitleEditChangeScriptTask {
			get {
				return _titleEditChangeScriptTask ?? (_titleEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TitleEditChangeScriptTask",
					SchemaElementUId = new Guid("3bed8caa-dc79-41bf-8c78-e1bd6aa3c1aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TitleEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5;
		public ProcessFlowElement EventSubProcess5 {
			get {
				return _eventSubProcess5 ?? (_eventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5",
					SchemaElementUId = new Guid("56f44291-0aca-4ed7-9c66-531d7d703023"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startInPeriodChangeStartMessage;
		public ProcessFlowElement StartInPeriodChangeStartMessage {
			get {
				return _startInPeriodChangeStartMessage ?? (_startInPeriodChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartInPeriodChangeStartMessage",
					SchemaElementUId = new Guid("7949870b-b059-4102-b715-3b670668cb25"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _startInPeriodChangeScriptTask;
		public ProcessScriptTask StartInPeriodChangeScriptTask {
			get {
				return _startInPeriodChangeScriptTask ?? (_startInPeriodChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "StartInPeriodChangeScriptTask",
					SchemaElementUId = new Guid("79640543-1c78-4214-90a2-7c7e5f166eb4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = StartInPeriodChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6;
		public ProcessFlowElement EventSubProcess6 {
			get {
				return _eventSubProcess6 ?? (_eventSubProcess6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6",
					SchemaElementUId = new Guid("0fd45181-2d26-424f-b6f2-3fd6dd77d13f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _onDurationPeriodChangeStartMessage;
		public ProcessFlowElement OnDurationPeriodChangeStartMessage {
			get {
				return _onDurationPeriodChangeStartMessage ?? (_onDurationPeriodChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OnDurationPeriodChangeStartMessage",
					SchemaElementUId = new Guid("0ae4b624-8726-4b71-9e3e-d91788ff7c66"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onDurationPeriodChangeScript;
		public ProcessScriptTask OnDurationPeriodChangeScript {
			get {
				return _onDurationPeriodChangeScript ?? (_onDurationPeriodChangeScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnDurationPeriodChangeScript",
					SchemaElementUId = new Guid("65bb58c9-55f4-4e8c-b4ae-aedbd5a2264c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnDurationPeriodChangeScriptExecute,
				});
			}
		}

		private ProcessFlowElement _remindBeforePeriodEditChangeEventSubProcess;
		public ProcessFlowElement RemindBeforePeriodEditChangeEventSubProcess {
			get {
				return _remindBeforePeriodEditChangeEventSubProcess ?? (_remindBeforePeriodEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "RemindBeforePeriodEditChangeEventSubProcess",
					SchemaElementUId = new Guid("9698f578-4c7b-46ca-a436-1c1f0882d0db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _onRemindBeforePeriodChangeStartMessage;
		public ProcessFlowElement OnRemindBeforePeriodChangeStartMessage {
			get {
				return _onRemindBeforePeriodChangeStartMessage ?? (_onRemindBeforePeriodChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OnRemindBeforePeriodChangeStartMessage",
					SchemaElementUId = new Guid("5b25205b-a2bc-431e-b209-3dfc2a005fd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onRemindBeforePeriodEditChangeScriptTask;
		public ProcessScriptTask OnRemindBeforePeriodEditChangeScriptTask {
			get {
				return _onRemindBeforePeriodEditChangeScriptTask ?? (_onRemindBeforePeriodEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnRemindBeforePeriodEditChangeScriptTask",
					SchemaElementUId = new Guid("ac96b9a3-ed9c-4994-bb89-b186e3b15ea5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnRemindBeforePeriodEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess7;
		public ProcessFlowElement EventSubProcess7 {
			get {
				return _eventSubProcess7 ?? (_eventSubProcess7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7",
					SchemaElementUId = new Guid("1f8988f9-2e7c-4d01-8267-cb1f4105ff06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _onActivityCategoryChangeStartMessage;
		public ProcessFlowElement OnActivityCategoryChangeStartMessage {
			get {
				return _onActivityCategoryChangeStartMessage ?? (_onActivityCategoryChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OnActivityCategoryChangeStartMessage",
					SchemaElementUId = new Guid("69cc3765-a649-45e6-b561-51dd20c49913"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onActivityCategoryChangeScriptTask;
		public ProcessScriptTask OnActivityCategoryChangeScriptTask {
			get {
				return _onActivityCategoryChangeScriptTask ?? (_onActivityCategoryChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnActivityCategoryChangeScriptTask",
					SchemaElementUId = new Guid("0aaa9201-487c-41ac-a64d-e69a54f98b69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnActivityCategoryChangeScriptTaskExecute,
				});
			}
		}

		private LocalizableString _defaultCategory;
		public LocalizableString DefaultCategory {
			get {
				return _defaultCategory ?? (_defaultCategory = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DefaultCategory.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[ChieldInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChieldInitStartMessage };
			FlowElements[ChieldInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ChieldInitIntermediateThrowMessageEvent };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[OkButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScriptTask };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[UserTaskRecommendationEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskRecommendationEditChangeStartMessage };
			FlowElements[UserTaskRecommendationEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskRecommendationEditChangeScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[TitleEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TitleEditChangeStartMessage };
			FlowElements[TitleEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { TitleEditChangeScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[StartInPeriodChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartInPeriodChangeStartMessage };
			FlowElements[StartInPeriodChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { StartInPeriodChangeScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[OnDurationPeriodChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OnDurationPeriodChangeStartMessage };
			FlowElements[OnDurationPeriodChangeScript.SchemaElementUId] = new Collection<ProcessFlowElement> { OnDurationPeriodChangeScript };
			FlowElements[RemindBeforePeriodEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { RemindBeforePeriodEditChangeEventSubProcess };
			FlowElements[OnRemindBeforePeriodChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OnRemindBeforePeriodChangeStartMessage };
			FlowElements[OnRemindBeforePeriodEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnRemindBeforePeriodEditChangeScriptTask };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[OnActivityCategoryChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OnActivityCategoryChangeStartMessage };
			FlowElements[OnActivityCategoryChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnActivityCategoryChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "ChieldInitStartMessage":
						e.Context.QueueTasks.Enqueue("ChieldInitIntermediateThrowMessageEvent");
						break;
					case "ChieldInitIntermediateThrowMessageEvent":
						break;
					case "EventSubProcess8":
						break;
					case "OkButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OkButtonClickScriptTask");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess3":
						break;
					case "UserTaskRecommendationEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("UserTaskRecommendationEditChangeScriptTask");
						break;
					case "UserTaskRecommendationEditChangeScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "TitleEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("TitleEditChangeScriptTask");
						break;
					case "TitleEditChangeScriptTask":
						break;
					case "EventSubProcess5":
						break;
					case "StartInPeriodChangeStartMessage":
						e.Context.QueueTasks.Enqueue("StartInPeriodChangeScriptTask");
						break;
					case "StartInPeriodChangeScriptTask":
						break;
					case "EventSubProcess6":
						break;
					case "OnDurationPeriodChangeStartMessage":
						e.Context.QueueTasks.Enqueue("OnDurationPeriodChangeScript");
						break;
					case "OnDurationPeriodChangeScript":
						break;
					case "RemindBeforePeriodEditChangeEventSubProcess":
						break;
					case "OnRemindBeforePeriodChangeStartMessage":
						e.Context.QueueTasks.Enqueue("OnRemindBeforePeriodEditChangeScriptTask");
						break;
					case "OnRemindBeforePeriodEditChangeScriptTask":
						break;
					case "EventSubProcess7":
						break;
					case "OnActivityCategoryChangeStartMessage":
						e.Context.QueueTasks.Enqueue("OnActivityCategoryChangeScriptTask");
						break;
					case "OnActivityCategoryChangeScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChieldInitStartMessage");
			ActivatedEventElements.Add("OkButtonClickStartMessage");
			ActivatedEventElements.Add("UserTaskRecommendationEditChangeStartMessage");
			ActivatedEventElements.Add("TitleEditChangeStartMessage");
			ActivatedEventElements.Add("StartInPeriodChangeStartMessage");
			ActivatedEventElements.Add("OnDurationPeriodChangeStartMessage");
			ActivatedEventElements.Add("OnRemindBeforePeriodChangeStartMessage");
			ActivatedEventElements.Add("OnActivityCategoryChangeStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ChieldInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChieldInitStartMessage";
					result = ChieldInitStartMessage.Execute(context);
					break;
				case "ChieldInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ChieldInitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickScriptTask";
					result = OkButtonClickScriptTask.Execute(context, OkButtonClickScriptTaskExecute);
					break;
				case "OkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage";
					result = OkButtonClickStartMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "UserTaskRecommendationEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskRecommendationEditChangeStartMessage";
					result = UserTaskRecommendationEditChangeStartMessage.Execute(context);
					break;
				case "UserTaskRecommendationEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskRecommendationEditChangeScriptTask";
					result = UserTaskRecommendationEditChangeScriptTask.Execute(context, UserTaskRecommendationEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "TitleEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TitleEditChangeStartMessage";
					result = TitleEditChangeStartMessage.Execute(context);
					break;
				case "TitleEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "TitleEditChangeScriptTask";
					result = TitleEditChangeScriptTask.Execute(context, TitleEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "StartInPeriodChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartInPeriodChangeStartMessage";
					result = StartInPeriodChangeStartMessage.Execute(context);
					break;
				case "StartInPeriodChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartInPeriodChangeScriptTask";
					result = StartInPeriodChangeScriptTask.Execute(context, StartInPeriodChangeScriptTaskExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "OnDurationPeriodChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnDurationPeriodChangeStartMessage";
					result = OnDurationPeriodChangeStartMessage.Execute(context);
					break;
				case "OnDurationPeriodChangeScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnDurationPeriodChangeScript";
					result = OnDurationPeriodChangeScript.Execute(context, OnDurationPeriodChangeScriptExecute);
					break;
				case "RemindBeforePeriodEditChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OnRemindBeforePeriodChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnRemindBeforePeriodChangeStartMessage";
					result = OnRemindBeforePeriodChangeStartMessage.Execute(context);
					break;
				case "OnRemindBeforePeriodEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnRemindBeforePeriodEditChangeScriptTask";
					result = OnRemindBeforePeriodEditChangeScriptTask.Execute(context, OnRemindBeforePeriodEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "OnActivityCategoryChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnActivityCategoryChangeStartMessage";
					result = OnActivityCategoryChangeStartMessage.Execute(context);
					break;
				case "OnActivityCategoryChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnActivityCategoryChangeScriptTask";
					result = OnActivityCategoryChangeScriptTask.Execute(context, OnActivityCategoryChangeScriptTaskExecute);
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
				case "IsNotFirstInvokeBaseActivityInit":
					IsNotFirstInvokeBaseActivityInit = reader.GetValue<System.Boolean>();
				break;
				case "IsUsedActivityControls":
					IsUsedActivityControls = reader.GetValue<System.Boolean>();
				break;
				case "IsTitleChanged":
					IsTitleChanged = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool OkButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.UserTaskTitleEdit.Text;
			return true;
		}

		public virtual bool UserTaskRecommendationEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (!IsTitleChanged) {
				Page.RecommendationEdit.Value = Page.UserTaskTitleEdit.Value;
			}
			return true;
		}

		public virtual bool TitleEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			IsTitleChanged = IsTitleChanged || !(Page.UserTaskTitleEdit.Value.Equals(Page.RecommendationEdit.Value));
			return true;
		}

		public virtual bool StartInPeriodChangeScriptTaskExecute(ProcessExecutingContext context) {
			OnPeriodChangeScript(context, "StartInPeriod", Page.StartInPeriodEdit.SelectedItem.Text);
			return true;
		}

		public virtual bool OnDurationPeriodChangeScriptExecute(ProcessExecutingContext context) {
			OnPeriodChangeScript(context, "DurationPeriod", Page.DurationPeriodEdit.SelectedItem.Text);
			return true;
		}

		public virtual bool OnRemindBeforePeriodEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			OnPeriodChangeScript(context, "RemindBeforePeriod", Page.RemindBeforePeriodEdit.SelectedItem.Text);
			return true;
		}

		public virtual bool OnActivityCategoryChangeScriptTaskExecute(ProcessExecutingContext context) {
			var parameters = context.ThrowEventArgs as Dictionary<string, object>;
			parameters.Add("columnName", "ActivityCategory");
			parameters.Add("row", parameters["newValue"]);
			parameters.Add("displayValue", Page.ActivityCategoryEdit.SelectedItem.Text);
			ThrowEvent(context, "OnPropertyChange");
			return true;
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return GetActivityControlsBinding();
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.UserTaskTitleEdit.Text) ?
				ElementNewCaption : Page.UserTaskTitleEdit.Text;
		}

		public virtual void OnPeriodChangeScript(ProcessExecutingContext context, string columnName, string displayValue) {
			var parameters = context.ThrowEventArgs as Dictionary<string, object>;
			parameters.Add("columnName", columnName);
			parameters.Add("row", parameters["newValue"]);
			parameters.Add("displayValue", displayValue);
			ThrowEvent(context, "OnPropertyChange");
		}

		public virtual void InitializeActivityDurationPeriodEditControls() {
			Page.StartInEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			Page.DurationEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			Page.RemindBeforeEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			InitOnLookupChangeEvent(Page.StartInPeriodEdit, "OnStartInPeriodChange");
			InitOnLookupChangeEvent(Page.DurationPeriodEdit, "OnDurationPeriodChange");
			InitOnLookupChangeEvent(Page.ActivityCategoryEdit, "OnActivityCategoryChange");
			InitOnLookupChangeEvent(Page.RemindBeforePeriodEdit, "OnRemindBeforePeriodChange");
		}

		public virtual void AddActivityDurationPeriodEditControlsItems() {
			Dictionary<string, string> durationDictionary = GetDurationsDictionary();
			foreach (var duration in durationDictionary) {
				var newItem = new UIControls.ListItem(duration.Key, duration.Value);
				Page.DurationPeriodEdit.Items.Add(newItem);
				Page.StartInPeriodEdit.Items.Add(newItem);
				Page.RemindBeforePeriodEdit.Items.Add(newItem);
			}
		}

		public virtual void SetActivityDurationPeriodEditControlsDefValue(VirtualDataSource propertyDataSource) {
			Entity row = propertyDataSource.Rows.First.Value;
			var durationPeriodValue = row.GetColumnValue("DurationPeriod").ToString();
			var startInPeriodValue = row.GetColumnValue("StartInPeriod").ToString();
			var remindBeforePeriodValue = row.GetColumnValue("RemindBeforePeriod").ToString();
			var durations = new Dictionary<string, string>();
			foreach (ProcessDurationPeriod item in Enum.GetValues(typeof(ProcessDurationPeriod))) {
				durations.Add(((int)item).ToString(), item.ToLocalizedString());
			}
			var setValueAndText = ".setValueAndText(\"";
			var argsBrackets = "\", \"";
			var closingBracket = "\");";
			var sb = new StringBuilder(256);
			sb.Append(Page.DurationPeriodEdit.ClientID);
			sb.Append(setValueAndText);
			sb.Append(durationPeriodValue);
			sb.Append(argsBrackets);
			sb.Append(durations[durationPeriodValue]);
			sb.Append(closingBracket);
			sb.Append(Page.StartInPeriodEdit.ClientID);
			sb.Append(setValueAndText);
			sb.Append(startInPeriodValue);
			sb.Append(argsBrackets);
			sb.Append(durations[startInPeriodValue]);
			sb.Append(closingBracket);
			sb.Append(Page.RemindBeforePeriodEdit.ClientID);
			sb.Append(setValueAndText);
			sb.Append(remindBeforePeriodValue);
			sb.Append(argsBrackets);
			sb.Append(durations[remindBeforePeriodValue]);
			sb.Append(closingBracket);
			Page.AddScript(sb.ToString());
		}

		public virtual Dictionary<Guid, string> AddActivityCategoryEditControlItems() {
			var activityCategoryItems = new Dictionary<Guid, string>();
			var select =
					new Select(UserConnection).
						Column("Id").
						Column("Name").
					From("ActivityCategory").
					Where("ActivityTypeId").IsEqual(Column.Parameter(new Guid("FBE0ACDC-CFC0-DF11-B00F-001D60E938C6"))) as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
						while (dr.Read()) {
							string displayValue = dr["Name"].ToString();
							Guid value =  UserConnection.DBTypeConverter.DBValueToGuid(dr["Id"]);
							activityCategoryItems[value] = displayValue;
							Page.ActivityCategoryEdit.Items.Add(
								new UIControls.ListItem(displayValue, value.ToString()));
						}
					}
				}
			return activityCategoryItems;
		}

		public virtual void SetActivityCategoryEditControlValue(VirtualDataSource propertyDataSource) {
			Page.ActivityCategoryEdit.SelectItem(propertyDataSource.Rows[0].GetColumnValue("ActivityCategoryId"));
		}

		public virtual void InvokeInitBaseActivityParametersEditPage() {
			InitializeActivityDurationPeriodEditControls();
			if (Ext.IsAjaxRequest && IsNotFirstInvokeBaseActivityInit) {
				return;
			}
			Page.UserTaskTitleEdit.Text = ElementNewCaption;
			var defValues = (Dictionary<string, ProcessSchemaParameterValue>)DefaultValues;
			string userTaskTitle = Page.UserTaskTitleEdit.Text;
			string recommendation = "Recommendation";
			SetDefaultValue(defValues[recommendation], userTaskTitle, userTaskTitle, recommendation);
			DefaultValues = defValues;
			FillPropertyDataSource(Source, (DesignModeClassDescriptor)Descriptor);
			var propertyDataSource = (VirtualDataSource)PropertyDataSource;
			Dictionary<Guid, string> activityCategoryItems = AddActivityCategoryEditControlItems();
			if (defValues["ActivityCategory"].Source == ProcessSchemaParameterValueSource.None) {
				// Устанавливаем по умолчанию категорию "Выполнить" для Активности
				Guid defActivityCategoryValue = new Guid("F51C4643-58E6-DF11-971B-001D60E938C6");
				string defActivityCategoryDisplayValue = activityCategoryItems[defActivityCategoryValue];
				SetDefaultValue(defValues["ActivityCategory"], defActivityCategoryValue.ToString(),
					defActivityCategoryDisplayValue, "ActivityCategory");
				Entity row = propertyDataSource.Rows[0];
				EntitySchemaColumn activityCategoryColumn = row.Schema.GetSchemaColumnByPath("ActivityCategory");
				row.SetColumnBothValues(activityCategoryColumn, defActivityCategoryValue, defActivityCategoryDisplayValue);
			}
			propertyDataSource.SetClientActiveRow();
			BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
			AddActivityDurationPeriodEditControlsItems();
			SetActivityDurationPeriodEditControlsDefValue(propertyDataSource);
			SetActivityCategoryEditControlValue(propertyDataSource);
			IsTitleChanged = !Page.UserTaskTitleEdit.Value.Equals(Page.RecommendationEdit.Value);
			IsNotFirstInvokeBaseActivityInit = true;
		}

		public virtual void SetActivityDurationPeriodEditControlsValue() {
			var propertyDataSource = (VirtualDataSource)PropertyDataSource;
			string scriptTemplate = string.Concat(
				"{1}.clearValue();{2}.clearValue();{3}.clearValue();",
				"var key = {0}.activeRow.columns[\"DurationPeriod\"];{1}.setValue(key.toString());",
				"key = {0}.activeRow.columns[\"StartInPeriod\"];{2}.setValue(key.toString());",
				"key = {0}.activeRow.columns[\"RemindBeforePeriod\"];{3}.setValue(key.toString());");
			var script = string.Format(scriptTemplate, propertyDataSource.ClientID,
				Page.DurationPeriodEdit.ClientID,
				Page.StartInPeriodEdit.ClientID,
				Page.RemindBeforePeriodEdit.ClientID);
			Page.AddScript(script);
		}

		public virtual Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetActivityControlsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl> {
				{"Recommendation", Page.RecommendationEdit},
				{"InformationOnStep", Page.InformationOnStepMemoEdit},
				{"Duration", Page.DurationEdit},
				{"StartIn", Page.StartInEdit},
				{"RemindBefore", Page.RemindBeforeEdit},
				{"OwnerId", Page.OwnerEdit},
				{"ExecutionContext", Page.ExecutionContextEdit},
				{"ShowInScheduler", Page.ShowInSchedulerEdit},
				{"ShowExecutionPage", Page.ShowExecutionPageEdit},
				{"Lead", Page.LeadEdit},
				{"Account", Page.AccountEdit},
				{"Contact", Page.ContactEdit},
				{"Opportunity", Page.OpportunityEdit},
				{"Invoice", Page.InvoiceEdit},
				{"Document", Page.DocumentEdit},
				{"ActivityCategory", Page.ActivityCategoryEdit},
				{"Order", Page.OrderEdit},
				{"Contract", Page.ContractEdit},
				{"Project", Page.ProjectEdit},
				{"Case", Page.CaseEdit},
				{"Problem", Page.ProblemEdit},
				{"Change", Page.ChangeEdit},
				{"Release", Page.ReleaseEdit},
				{"Application", Page.ApplicationEdit}
			};
		}

		public virtual void SetDefValueParameterValueEdit(Dictionary<string, Terrasoft.UI.WebControls.WebControl> parameterControlsBinding) {
			if (parameterControlsBinding == null || parameterControlsBinding.Count == 0) {
				return;
			}
			var sb = new StringBuilder(128 * parameterControlsBinding.Count);
			sb.Append("(function(){");
			foreach (KeyValuePair<string, Terrasoft.UI.WebControls.WebControl> parameterEditControl in parameterControlsBinding) {
				if (!(parameterEditControl.Value is ProcessSchemaParameterValueEdit)) {
					continue;
				}
				sb.Append(parameterEditControl.Value.ClientID);
				sb.Append(".hiddenField.value = Ext.util.JSON.encode(");
				sb.Append(parameterEditControl.Value.ClientID);
				sb.Append(".value);");
				sb.Append(parameterEditControl.Value.ClientID);
				sb.Append(".actualizeDisplayValue();");
			}
			sb.Append("})();");
			Page.AddScript(sb.ToString());
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("ChieldInitStartMessage")) {
							context.QueueTasks.Enqueue("ChieldInitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "UserTaskRecommendationEditChange":
							if (ActivatedEventElements.Contains("UserTaskRecommendationEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("UserTaskRecommendationEditChangeStartMessage");
						}
						break;
					case "TitleEditChange":
							if (ActivatedEventElements.Contains("TitleEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("TitleEditChangeStartMessage");
						}
						break;
					case "OnStartInPeriodChange":
							if (ActivatedEventElements.Contains("StartInPeriodChangeStartMessage")) {
							context.QueueTasks.Enqueue("StartInPeriodChangeStartMessage");
						}
						break;
					case "OnDurationPeriodChange":
							if (ActivatedEventElements.Contains("OnDurationPeriodChangeStartMessage")) {
							context.QueueTasks.Enqueue("OnDurationPeriodChangeStartMessage");
						}
						break;
					case "OnRemindBeforePeriodChange":
							if (ActivatedEventElements.Contains("OnRemindBeforePeriodChangeStartMessage")) {
							context.QueueTasks.Enqueue("OnRemindBeforePeriodChangeStartMessage");
						}
						break;
					case "OnActivityCategoryChange":
							if (ActivatedEventElements.Contains("OnActivityCategoryChangeStartMessage")) {
							context.QueueTasks.Enqueue("OnActivityCategoryChangeStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsNotFirstInvokeBaseActivityInit") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNotFirstInvokeBaseActivityInit", IsNotFirstInvokeBaseActivityInit, false);
			}
			if (!HasMapping("IsUsedActivityControls") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsUsedActivityControls", IsUsedActivityControls, false);
			}
			if (!HasMapping("IsTitleChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsTitleChanged", IsTitleChanged, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseProcessUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class BaseProcessUserTaskParametersEditPageEventsProcess : BaseProcessUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchemaUserControl>
	{

		public BaseProcessUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseProcessUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseProcessUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("UserTaskTitleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit RecommendationEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("RecommendationEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit InformationOnStepMemoEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("InformationOnStepMemoEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout8 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout8", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit StartInEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("StartInEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit StartInPeriodEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("StartInPeriodEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout9 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout9", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit DurationEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("DurationEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit DurationPeriodEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("DurationPeriodEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ActivityCategoryEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ActivityCategoryEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit OwnerEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("OwnerEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout10 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout10", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit RemindBeforeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("RemindBeforeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit RemindBeforePeriodEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("RemindBeforePeriodEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ExecutionContextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ExecutionContextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout11 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout11", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout BaseProcessUserTaskPageControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BaseProcessUserTaskPageControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ShowExecutionPageEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ShowExecutionPageEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout BaseProcessUserTaskPageControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BaseProcessUserTaskPageControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInSchedulerEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ShowInSchedulerEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout6 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout6", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit LeadEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("LeadEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit AccountEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("AccountEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ContactEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ContactEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ApplicationEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ApplicationEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CaseEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("CaseEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ProjectEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ProjectEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit OpportunityEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("OpportunityEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActivityControlLayout7 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActivityControlLayout7", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit InvoiceEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("InvoiceEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit DocumentEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("DocumentEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit OrderEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("OrderEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ContractEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ContractEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ProblemEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ProblemEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ChangeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ChangeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ReleaseEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ReleaseEdit", true);
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
			var process = (BaseProcessUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseProcessUserTaskParametersEditPageEventsProcess(UserConnection);
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
			SchemaName = "BaseProcessUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseProcessUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseProcessUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseProcessUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseProcessUserTaskParametersEditPageEventsProcessSchema(BaseProcessUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseProcessUserTaskParametersEditPageEventsProcess";
			UId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535");
			CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92");
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

		protected virtual ProcessSchemaParameter CreateIsTitleChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8cc1aa7b-c09b-495a-b7c5-4ebd685bf3c7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"IsTitleChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsUsedActivityControlsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3cd3058f-0f1a-4568-9c49-8c492f6a0df7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"IsUsedActivityControls",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNotFirstInvokeBaseActivityInitParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fc0aec7e-1f4d-41f7-936c-37e02c10ccf5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"IsNotFirstInvokeBaseActivityInit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsTitleChangedParameter());
			Parameters.Add(CreateIsUsedActivityControlsParameter());
			Parameters.Add(CreateIsNotFirstInvokeBaseActivityInitParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess remindbeforeperiodeditchangeeventsubprocess = CreateRemindBeforePeriodEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(remindbeforeperiodeditchangeeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaStartMessageEvent chieldinitstartmessage = CreateChieldInitStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(chieldinitstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent chieldinitintermediatethrowmessageevent = CreateChieldInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(chieldinitintermediatethrowmessageevent);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOkButtonClickScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent usertaskrecommendationeditchangestartmessage = CreateUserTaskRecommendationEditChangeStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(usertaskrecommendationeditchangestartmessage);
			ProcessSchemaScriptTask usertaskrecommendationeditchangescripttask = CreateUserTaskRecommendationEditChangeScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(usertaskrecommendationeditchangescripttask);
			ProcessSchemaStartMessageEvent titleeditchangestartmessage = CreateTitleEditChangeStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(titleeditchangestartmessage);
			ProcessSchemaScriptTask titleeditchangescripttask = CreateTitleEditChangeScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(titleeditchangescripttask);
			ProcessSchemaStartMessageEvent startinperiodchangestartmessage = CreateStartInPeriodChangeStartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(startinperiodchangestartmessage);
			ProcessSchemaScriptTask startinperiodchangescripttask = CreateStartInPeriodChangeScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(startinperiodchangescripttask);
			ProcessSchemaStartMessageEvent ondurationperiodchangestartmessage = CreateOnDurationPeriodChangeStartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(ondurationperiodchangestartmessage);
			ProcessSchemaScriptTask ondurationperiodchangescript = CreateOnDurationPeriodChangeScriptScriptTask();
			eventsubprocess6.FlowElements.Add(ondurationperiodchangescript);
			ProcessSchemaStartMessageEvent onremindbeforeperiodchangestartmessage = CreateOnRemindBeforePeriodChangeStartMessageStartMessageEvent();
			remindbeforeperiodeditchangeeventsubprocess.FlowElements.Add(onremindbeforeperiodchangestartmessage);
			ProcessSchemaScriptTask onremindbeforeperiodeditchangescripttask = CreateOnRemindBeforePeriodEditChangeScriptTaskScriptTask();
			remindbeforeperiodeditchangeeventsubprocess.FlowElements.Add(onremindbeforeperiodeditchangescripttask);
			ProcessSchemaStartMessageEvent onactivitycategorychangestartmessage = CreateOnActivityCategoryChangeStartMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(onactivitycategorychangestartmessage);
			ProcessSchemaScriptTask onactivitycategorychangescripttask = CreateOnActivityCategoryChangeScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(onactivitycategorychangescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateRemindBeforePeriodEditChangeSequenceFlowSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDefaultCategoryLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDefaultCategoryLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7c8f1095-a818-441d-b905-565094d48b53"),
				Name = "DefaultCategory",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e8c665d5-7460-4f31-b3d8-94e3cf754123"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CurveCenterPosition = new Point(154, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0e2217f1-4711-42aa-9cb6-2c6ea7738492"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bcf2a5db-103e-4ef4-b858-62b4d2bd38f7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("9bd0472e-ca02-49ed-b948-23730df480c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CurveCenterPosition = new Point(158, 300),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71c03d9e-1a28-45f6-aa20-4bc39dddecd9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f2f57e42-986e-4d90-851f-ad49fc6362dd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("c1d0991c-7216-43b8-a8e1-2a69127d5736"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CurveCenterPosition = new Point(160, 481),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1a20a9dd-065d-4604-ac82-b0b4df0fce03"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3bed8caa-dc79-41bf-8c78-e1bd6aa3c1aa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("73a1aaa5-ba49-4621-97a3-03bad0f194e0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CurveCenterPosition = new Point(168, 654),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7949870b-b059-4102-b715-3b670668cb25"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79640543-1c78-4214-90a2-7c7e5f166eb4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("8ee14810-6cb2-4c7c-9e9b-a6cbc1ee59c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CurveCenterPosition = new Point(196, 860),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0ae4b624-8726-4b71-9e3e-d91788ff7c66"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("65bb58c9-55f4-4e8c-b4ae-aedbd5a2264c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("c693c5f6-4de1-4551-9e39-55eb065f06db"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CurveCenterPosition = new Point(176, 1044),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69cc3765-a649-45e6-b561-51dd20c49913"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0aaa9201-487c-41ac-a64d-e69a54f98b69"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("09a2b9df-6d21-4c20-b277-6145e9c1ef6e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CurveCenterPosition = new Point(192, 283),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f3ce1a69-98e2-4b4b-81a4-2fd373262d97"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3f5e1ee0-93d8-4774-bea1-d2ea7f9dcc95"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("e7177d1f-9706-49ec-8b64-bfe23edfad17"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CurveCenterPosition = new Point(282, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3f5e1ee0-93d8-4774-bea1-d2ea7f9dcc95"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aeda8b3b-d8a7-4a25-92fb-8d68a7ea618c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateRemindBeforePeriodEditChangeSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "RemindBeforePeriodEditChangeSequenceFlow",
				UId = new Guid("3d6c3720-8fdc-4087-937b-92d75c1d423d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b25205b-a2bc-431e-b209-3dfc2a005fd8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac96b9a3-ed9c-4994-bb89-b186e3b15ea5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("57922c50-3433-4727-b952-a98c8227e104"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1182, 158),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("908cbf24-e565-4d5c-988f-b0704ed86690"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("57922c50-3433-4727-b952-a98c8227e104"),
				CreatedInOwnerSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1153, 158),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4834298f-2666-4190-8c3b-c8d0f1a4bc77"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("908cbf24-e565-4d5c-988f-b0704ed86690"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(270, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChieldInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0e2217f1-4711-42aa-9cb6-2c6ea7738492"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4834298f-2666-4190-8c3b-c8d0f1a4bc77"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"ChieldInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateChieldInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("bcf2a5db-103e-4ef4-b858-62b4d2bd38f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4834298f-2666-4190-8c3b-c8d0f1a4bc77"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"ChieldInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e2593b77-3315-40d0-a618-b67923c6a70b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("908cbf24-e565-4d5c-988f-b0704ed86690"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 170),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(267, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3f5e1ee0-93d8-4774-bea1-d2ea7f9dcc95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2593b77-3315-40d0-a618-b67923c6a70b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"OkButtonClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,73,205,77,205,43,241,75,45,119,78,44,40,201,204,207,83,176,85,8,72,76,79,213,11,45,78,45,10,73,44,206,14,201,44,201,73,117,77,201,44,209,11,73,173,40,177,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,182,51,200,141,62,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f3ce1a69-98e2-4b4b-81a4-2fd373262d97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2593b77-3315-40d0-a618-b67923c6a70b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"OkButtonClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("aeda8b3b-d8a7-4a25-92fb-8d68a7ea618c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2593b77-3315-40d0-a618-b67923c6a70b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6cb38234-46c2-40ce-9dba-834b31f7c8fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("908cbf24-e565-4d5c-988f-b0704ed86690"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 360),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 143),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUserTaskRecommendationEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("71c03d9e-1a28-45f6-aa20-4bc39dddecd9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cb38234-46c2-40ce-9dba-834b31f7c8fa"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"UserTaskRecommendationEditChange",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"UserTaskRecommendationEditChangeStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUserTaskRecommendationEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f2f57e42-986e-4d90-851f-ad49fc6362dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cb38234-46c2-40ce-9dba-834b31f7c8fa"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"UserTaskRecommendationEditChangeScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,44,14,201,44,201,73,117,206,72,204,75,79,77,209,84,168,230,229,226,12,72,76,79,213,11,74,77,206,207,205,77,205,75,73,44,201,204,207,115,77,201,44,209,11,75,204,41,77,85,176,85,0,203,135,22,167,22,133,36,22,103,131,181,35,164,173,121,185,106,121,185,138,82,75,74,139,242,20,74,138,128,2,0,57,105,26,103,103,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ef4a7e2c-50b3-4ccd-a4a8-5906c759f6e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("908cbf24-e565-4d5c-988f-b0704ed86690"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 550),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 126),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTitleEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1a20a9dd-065d-4604-ac82-b0b4df0fce03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef4a7e2c-50b3-4ccd-a4a8-5906c759f6e0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TitleEditChange",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"TitleEditChangeStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTitleEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3bed8caa-dc79-41bf-8c78-e1bd6aa3c1aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef4a7e2c-50b3-4ccd-a4a8-5906c759f6e0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"TitleEditChangeScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,14,201,44,201,73,117,206,72,204,75,79,77,81,176,85,240,68,21,168,169,81,80,212,8,72,76,79,213,11,45,78,45,10,73,44,206,6,75,187,166,100,150,232,133,37,230,148,166,234,185,22,150,38,230,20,67,212,4,165,38,231,231,230,166,230,165,36,150,100,230,231,33,20,105,106,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,73,1,49,162,119,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("56f44291-0aca-4ed7-9c66-531d7d703023"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("908cbf24-e565-4d5c-988f-b0704ed86690"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 730),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartInPeriodChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7949870b-b059-4102-b715-3b670668cb25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("56f44291-0aca-4ed7-9c66-531d7d703023"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OnStartInPeriodChange",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"StartInPeriodChangeStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateStartInPeriodChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("79640543-1c78-4214-90a2-7c7e5f166eb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("56f44291-0aca-4ed7-9c66-531d7d703023"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"StartInPeriodChangeScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,11,72,45,202,204,79,113,206,72,204,75,79,13,78,46,202,44,40,209,72,206,207,43,73,173,40,209,81,80,10,46,73,44,42,241,132,170,81,210,81,8,72,76,79,213,67,17,116,77,201,44,209,11,78,205,73,77,46,73,77,241,44,73,205,213,11,1,106,213,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,182,211,201,20,103,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0fd45181-2d26-424f-b6f2-3fd6dd77d13f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("908cbf24-e565-4d5c-988f-b0704ed86690"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(322, 730),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOnDurationPeriodChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0ae4b624-8726-4b71-9e3e-d91788ff7c66"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0fd45181-2d26-424f-b6f2-3fd6dd77d13f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OnDurationPeriodChange",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"OnDurationPeriodChangeStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnDurationPeriodChangeScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("65bb58c9-55f4-4e8c-b4ae-aedbd5a2264c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0fd45181-2d26-424f-b6f2-3fd6dd77d13f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"OnDurationPeriodChangeScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,11,72,45,202,204,79,113,206,72,204,75,79,13,78,46,202,44,40,209,72,206,207,43,73,173,40,209,81,80,114,41,45,74,44,201,204,135,42,82,210,81,8,72,76,79,213,67,21,117,77,201,44,209,11,78,205,73,77,46,73,77,241,44,73,205,213,11,1,106,214,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,143,55,18,60,105,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateRemindBeforePeriodEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaRemindBeforePeriodEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9698f578-4c7b-46ca-a436-1c1f0882d0db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("908cbf24-e565-4d5c-988f-b0704ed86690"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"RemindBeforePeriodEditChangeEventSubProcess",
				Position = new Point(595, 730),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 148),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaRemindBeforePeriodEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOnRemindBeforePeriodChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5b25205b-a2bc-431e-b209-3dfc2a005fd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9698f578-4c7b-46ca-a436-1c1f0882d0db"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OnRemindBeforePeriodChange",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"OnRemindBeforePeriodChangeStartMessage",
				Position = new Point(36, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnRemindBeforePeriodEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ac96b9a3-ed9c-4994-bb89-b186e3b15ea5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9698f578-4c7b-46ca-a436-1c1f0882d0db"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"OnRemindBeforePeriodEditChangeScriptTask",
				Position = new Point(155, 43),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,11,72,45,202,204,79,113,206,72,204,75,79,13,78,46,202,44,40,209,72,206,207,43,73,173,40,209,81,80,10,74,205,205,204,75,113,74,77,203,47,74,133,40,84,210,81,8,72,76,79,213,195,148,113,77,201,44,209,11,78,205,73,77,46,73,77,241,44,73,205,213,11,1,26,162,105,205,203,85,148,90,82,90,148,167,80,82,84,154,106,13,0,129,170,126,29,113,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1f8988f9-2e7c-4d01-8267-cb1f4105ff06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("908cbf24-e565-4d5c-988f-b0704ed86690"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"EventSubProcess7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 935),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(218, 134),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOnActivityCategoryChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("69cc3765-a649-45e6-b561-51dd20c49913"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f8988f9-2e7c-4d01-8267-cb1f4105ff06"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OnActivityCategoryChange",
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"OnActivityCategoryChangeStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOnActivityCategoryChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0aaa9201-487c-41ac-a64d-e69a54f98b69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f8988f9-2e7c-4d01-8267-cb1f4105ff06"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Name = @"OnActivityCategoryChangeScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,205,138,194,64,16,132,239,194,190,67,51,39,133,48,47,160,187,16,212,131,23,21,148,189,44,123,104,51,205,56,146,244,132,158,78,220,188,253,142,63,16,16,175,69,213,87,85,61,10,180,40,216,144,146,36,248,132,42,178,210,159,218,227,89,226,117,221,19,107,41,62,1,38,88,133,74,67,100,148,97,145,84,2,251,2,226,233,66,149,126,205,63,38,35,195,150,206,77,77,21,235,174,225,109,214,76,1,166,204,201,62,232,176,68,37,31,101,48,179,55,145,220,151,189,163,250,99,152,174,223,88,119,100,126,223,249,93,72,109,141,195,195,81,192,30,61,217,215,162,181,11,106,15,84,231,149,228,54,74,141,61,230,115,55,218,248,111,250,188,156,119,238,120,47,177,37,201,128,51,178,167,251,78,33,237,132,65,165,163,249,63,4,196,184,122,47,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnPeriodChangeScriptMethod());
			Methods.Add(CreateInitializeActivityDurationPeriodEditControlsMethod());
			Methods.Add(CreateAddActivityDurationPeriodEditControlsItemsMethod());
			Methods.Add(CreateSetActivityDurationPeriodEditControlsDefValueMethod());
			Methods.Add(CreateAddActivityCategoryEditControlItemsMethod());
			Methods.Add(CreateSetActivityCategoryEditControlValueMethod());
			Methods.Add(CreateInvokeInitBaseActivityParametersEditPageMethod());
			Methods.Add(CreateSetActivityDurationPeriodEditControlsValueMethod());
			Methods.Add(CreateGetActivityControlsBindingMethod());
			Methods.Add(CreateSetDefValueParameterValueEditMethod());
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

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,79,45,113,76,46,201,44,203,44,169,116,206,207,43,41,202,207,41,118,202,204,75,201,204,75,215,208,180,6,0,211,229,238,44,36,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,140,177,10,194,64,12,64,103,253,138,140,237,146,15,80,68,164,220,208,165,58,92,113,142,24,203,97,122,119,36,17,245,239,165,130,171,211,91,222,123,205,137,38,198,131,213,133,64,6,145,85,201,202,205,113,236,241,204,151,174,100,215,34,134,139,208,98,71,213,83,201,176,3,115,77,121,194,222,134,135,200,81,195,92,253,221,124,111,163,177,70,178,123,76,46,28,174,201,49,242,203,91,216,175,87,65,120,230,236,3,63,127,163,13,252,105,182,31,90,249,23,155,159,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnPeriodChangeScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5a9a2475-8425-44c0-b794-435069a3ecfa"),
				Name = "OnPeriodChangeScript",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1bc4a865-0fe3-42e8-8e16-7363666d472a"),
				Name = "context",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ca5f6682-a4ed-480a-9da1-7a3614710667"),
				Name = "columnName",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("61bf0d3d-794d-476f-952f-7fe93623c11d"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("009b01d9-4d0e-4527-8878-732f0fe59e92")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,207,187,10,194,64,16,5,208,222,175,24,182,138,176,248,3,62,32,168,173,90,136,141,88,140,155,33,137,36,179,97,118,146,152,191,119,65,97,5,45,239,229,48,143,1,5,58,20,108,73,73,2,172,193,121,86,122,234,226,92,137,31,247,3,177,230,82,6,192,0,187,218,105,237,25,101,90,5,149,154,75,11,254,254,32,167,155,229,44,141,88,228,69,145,25,231,155,190,229,67,236,140,133,20,230,191,50,110,137,36,181,87,195,52,94,176,233,201,220,254,240,162,14,93,131,211,27,88,248,142,81,167,163,179,207,31,22,204,145,79,226,59,18,157,182,21,114,73,38,194,23,222,205,26,38,247,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeActivityDurationPeriodEditControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9a999eaf-7a24-447d-9a61-77ab506b35ed"),
				Name = "InitializeActivityDurationPeriodEditControls",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,208,193,10,130,64,16,6,224,123,208,59,200,158,20,194,23,232,84,230,65,8,92,170,23,88,218,81,135,114,38,182,217,194,183,47,137,68,237,144,7,143,51,195,124,51,252,218,148,16,31,197,56,201,40,181,40,113,226,239,194,117,194,84,96,25,111,172,13,9,158,193,167,204,4,234,80,85,104,65,59,172,141,107,78,204,215,173,23,97,82,171,64,137,243,160,162,104,189,92,232,22,221,121,103,4,121,102,245,0,53,146,221,66,193,14,102,147,51,66,201,105,207,124,241,183,164,50,84,66,250,0,146,80,247,194,209,224,144,109,123,242,189,154,211,160,251,217,81,127,169,111,36,35,107,216,158,138,109,206,130,15,148,38,49,2,37,187,166,227,198,131,169,96,63,218,209,135,191,163,14,125,1,107,251,128,33,65,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddActivityDurationPeriodEditControlsItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c3ef822a-f89a-49f1-b697-939aac5df584"),
				Name = "AddActivityDurationPeriodEditControlsItems",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,203,10,194,48,16,69,215,45,244,31,178,76,161,228,7,124,128,90,145,162,139,162,232,62,52,99,13,180,9,76,166,74,17,255,221,6,251,216,8,186,154,97,238,185,119,102,82,93,144,182,70,98,59,119,132,218,148,9,251,212,37,83,13,74,175,165,35,194,22,108,7,148,246,115,55,9,60,158,69,225,213,34,200,226,198,248,93,226,104,102,218,124,9,138,217,51,10,3,207,25,120,100,4,117,151,220,117,236,156,109,172,33,180,149,19,7,237,200,43,124,112,139,61,180,201,152,37,46,178,106,192,175,13,114,89,130,24,142,202,1,181,85,91,165,73,120,183,19,43,165,120,191,100,162,79,36,145,178,63,225,35,212,218,168,53,248,255,126,57,94,111,247,44,5,242,80,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetActivityDurationPeriodEditControlsDefValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7c64765c-08f9-41f5-b888-f61ae892bbae"),
				Name = "SetActivityDurationPeriodEditControlsDefValue",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("efb09d9d-8f57-4b76-8a94-8fb25870a5ae"),
				Name = "propertyDataSource",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,79,79,2,49,16,197,207,146,248,29,154,61,117,19,210,131,137,94,80,19,254,105,72,60,16,32,94,196,67,217,14,216,184,180,155,233,172,136,198,239,238,238,178,8,133,37,8,167,205,118,222,188,190,223,164,211,53,164,105,201,208,46,216,29,75,208,38,128,180,236,72,146,67,155,98,4,98,96,23,78,60,104,116,36,158,101,156,66,227,178,246,33,145,169,20,37,105,107,250,128,218,170,162,146,245,103,46,226,17,168,109,227,116,110,138,67,30,116,60,101,16,138,145,29,18,106,51,227,97,233,229,72,34,245,254,97,53,220,22,86,57,33,204,181,81,45,152,90,132,227,118,131,61,117,149,231,154,212,101,46,6,22,172,163,163,252,87,226,242,214,21,202,58,91,125,239,139,150,220,76,70,111,140,247,209,70,224,156,143,207,52,193,156,105,195,186,38,157,231,129,138,40,142,211,50,1,59,173,238,9,195,144,125,95,214,46,254,130,136,166,82,156,115,109,40,204,237,182,51,215,139,11,178,131,39,27,201,88,127,129,90,87,242,108,63,229,188,203,107,155,70,141,224,147,50,174,64,236,156,241,113,16,148,252,18,103,174,133,50,122,7,202,71,16,140,131,58,219,84,163,216,186,204,191,20,172,234,97,99,93,117,147,114,104,171,20,173,84,199,10,144,95,93,223,228,113,220,68,52,147,4,140,226,125,57,3,225,83,119,149,38,209,142,53,24,234,117,124,245,78,86,191,88,241,48,125,193,54,79,117,171,123,169,48,121,245,181,62,119,5,141,247,86,207,133,217,223,140,211,89,246,61,78,69,217,223,147,115,121,14,236,231,233,80,7,140,142,146,21,60,217,250,12,35,212,9,241,76,186,217,157,176,241,11,110,222,35,221,12,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddActivityCategoryEditControlItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("eea16dfe-9a18-490c-aa4b-b3c26574e163"),
				Name = "AddActivityCategoryEditControlItems",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Dictionary<Guid, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,146,93,75,195,48,20,134,175,219,95,17,122,149,130,11,29,130,40,83,97,235,135,20,68,68,167,94,200,46,226,114,152,129,174,209,147,180,90,196,255,110,62,42,155,195,139,94,228,156,243,62,125,207,155,244,28,9,95,27,217,75,51,228,220,192,70,225,80,27,216,106,114,65,90,248,32,133,180,77,213,114,28,206,175,58,41,142,136,54,40,219,205,37,77,103,113,111,181,26,26,88,27,114,17,71,145,27,191,247,71,250,160,1,115,213,182,224,197,41,179,221,40,87,77,183,109,105,82,139,228,111,225,134,111,33,148,42,84,91,154,204,15,236,132,222,211,43,32,236,154,203,225,13,60,169,214,229,123,199,27,26,104,236,150,163,197,25,64,234,236,56,203,52,169,22,101,54,207,139,124,146,87,121,54,41,170,233,116,178,200,178,106,146,101,211,226,36,43,207,142,79,243,147,36,77,83,194,245,184,192,44,142,58,109,215,36,212,237,40,94,202,79,88,119,70,161,13,229,239,106,172,108,117,135,80,44,118,37,106,65,95,214,240,8,168,11,110,248,29,112,1,22,228,0,33,49,22,144,16,58,116,247,139,81,29,125,188,202,6,8,21,200,220,200,47,52,138,66,254,68,72,253,214,240,225,145,55,29,88,168,192,231,144,227,138,45,213,189,31,113,55,228,4,46,3,210,143,115,135,246,139,133,11,210,22,122,64,27,154,61,123,226,82,249,228,28,213,134,188,26,73,255,190,147,103,143,94,57,15,123,150,130,224,150,111,128,29,94,103,41,164,97,94,202,230,66,80,63,232,223,206,67,109,125,24,84,141,102,215,82,27,55,66,247,153,71,97,139,189,5,211,96,236,59,246,223,119,140,96,58,108,255,127,207,179,31,58,167,235,93,234,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetActivityCategoryEditControlValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ca044efa-33ce-4344-bb30-f011c4abf56b"),
				Name = "SetActivityCategoryEditControlValue",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("38ad0b01-7658-47bd-a6ec-14128483c810"),
				Name = "propertyDataSource",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,76,46,201,44,203,44,169,116,78,44,73,77,207,47,170,116,77,201,44,209,11,78,205,73,77,46,241,44,73,205,213,40,40,202,47,72,45,42,169,116,73,44,73,12,206,47,45,74,78,213,11,202,47,47,142,54,136,213,115,79,45,113,206,207,41,205,205,11,75,204,41,77,213,80,66,55,202,51,69,73,83,211,26,0,89,159,140,237,102,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInvokeInitBaseActivityParametersEditPageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aeef2dac-f254-4572-a618-bd0bfc2662b4"),
				Name = "InvokeInitBaseActivityParametersEditPage",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,85,205,78,219,64,16,62,199,79,177,245,1,57,146,99,18,21,40,40,5,41,36,1,229,80,20,65,202,5,113,88,197,67,216,226,120,195,238,154,159,86,149,90,122,232,161,85,91,245,21,250,2,168,45,18,226,175,175,176,126,163,206,218,33,63,196,129,67,18,103,253,205,55,223,124,51,30,55,66,166,24,13,216,91,168,180,21,59,98,234,180,22,9,170,24,15,155,32,24,247,235,62,83,85,30,42,193,3,233,228,203,22,219,35,78,253,68,121,13,89,121,67,79,54,225,48,2,169,200,204,12,105,200,13,174,214,152,144,170,17,30,241,3,88,165,114,64,217,192,36,121,242,206,202,9,80,145,8,203,214,123,171,73,59,224,189,150,32,90,84,30,180,152,10,192,100,242,90,112,162,200,50,169,7,208,133,80,109,192,113,149,246,140,152,178,117,68,5,241,97,111,155,6,152,17,33,78,141,181,205,29,42,78,95,74,37,88,216,113,73,83,240,54,72,185,213,222,135,46,109,82,65,187,160,64,36,33,43,249,26,236,209,40,80,41,65,217,74,99,72,52,42,1,105,31,209,53,136,17,208,230,93,212,231,39,62,97,144,189,57,118,98,151,173,45,80,163,249,156,129,242,157,241,224,93,119,92,193,196,223,113,56,54,96,172,12,204,61,96,46,91,107,44,8,208,130,30,8,236,34,85,116,139,71,162,13,78,250,227,162,99,32,89,39,124,197,125,168,6,84,74,252,219,22,172,167,184,200,143,92,166,78,247,38,104,140,229,219,76,168,136,6,195,195,252,100,58,84,56,108,204,122,196,124,151,164,182,173,16,218,31,135,42,85,208,225,226,180,161,160,107,74,168,248,126,229,193,173,145,177,75,80,247,163,55,244,209,126,24,98,239,122,247,74,151,31,155,132,20,228,109,240,16,146,153,156,157,37,250,87,252,49,62,211,231,250,22,63,191,245,181,190,196,239,115,125,161,111,136,254,167,239,72,252,73,223,232,59,125,29,127,78,48,151,241,55,162,175,244,57,134,92,232,63,250,46,254,144,28,217,250,103,252,197,224,145,192,128,206,226,175,54,209,127,49,236,59,209,63,244,21,194,13,239,45,6,152,108,151,86,206,216,99,26,248,176,148,68,39,26,19,194,49,49,24,199,94,155,47,85,231,22,230,158,23,230,23,235,11,133,218,90,169,84,88,122,81,90,45,20,139,165,218,66,177,190,244,124,177,186,96,163,71,185,254,136,102,144,214,152,236,5,116,192,157,217,140,157,105,98,118,145,122,250,76,103,244,194,157,90,151,215,226,91,137,72,39,239,90,185,220,19,74,93,50,73,110,234,172,135,10,143,136,224,199,88,203,228,180,122,155,252,88,238,20,119,7,200,116,18,170,60,136,186,225,68,237,253,227,101,67,231,165,72,111,29,212,104,204,234,105,147,170,125,39,91,76,18,6,170,143,228,106,63,245,197,201,206,51,221,154,204,59,163,110,228,205,234,204,168,214,36,15,24,110,204,36,24,176,120,243,192,172,178,48,217,223,92,72,7,203,233,95,154,211,212,253,12,223,220,225,62,65,130,145,7,115,250,91,97,240,124,162,136,167,209,181,62,189,51,153,123,156,34,99,19,60,18,216,144,201,190,172,238,211,176,3,62,118,242,217,148,69,158,142,96,253,16,215,152,116,18,204,248,238,30,130,18,214,199,223,105,152,71,137,8,202,255,1,215,185,98,45,69,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetActivityDurationPeriodEditControlsValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("98ba529c-6bd6-43a5-9f12-4d62bac15a5c"),
				Name = "SetActivityDurationPeriodEditControlsValue",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,145,65,107,131,64,16,133,207,13,228,63,136,39,133,176,180,201,81,122,104,99,10,185,73,44,185,52,61,12,235,52,44,89,119,101,28,45,65,242,223,235,106,75,98,12,185,244,250,120,243,237,123,111,107,32,175,32,91,32,241,49,6,134,212,86,36,209,123,246,130,173,34,174,64,159,197,48,25,249,162,233,164,100,82,102,239,149,146,84,193,239,152,23,26,216,221,247,186,88,90,35,129,131,233,228,193,111,158,78,66,106,4,218,130,174,48,8,163,102,126,45,44,174,4,127,230,14,235,54,227,1,143,45,180,121,60,9,144,172,106,220,216,111,33,173,174,114,83,126,236,252,184,34,96,101,77,130,164,108,182,243,63,35,247,88,137,220,131,218,99,193,54,237,18,5,225,31,246,62,50,101,32,94,95,18,231,255,36,110,48,87,38,123,197,47,75,120,129,93,220,195,134,237,194,174,126,63,239,121,214,55,75,121,59,235,112,245,217,141,159,20,75,173,208,240,58,118,1,19,216,163,24,110,181,202,20,143,61,131,242,183,45,227,54,3,159,11,222,249,94,178,44,237,82,254,134,13,163,31,171,165,126,22,115,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityControlsBindingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4b06afb9-04c1-4b9f-a315-4701bc32ece3"),
				Name = "GetActivityControlsBinding",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Dictionary<string, Terrasoft.UI.WebControls.WebControl>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,83,77,111,194,48,12,61,15,105,255,161,226,140,248,3,155,38,109,192,161,210,38,16,108,218,57,164,6,50,181,78,229,58,124,8,241,223,71,186,54,113,186,91,222,243,179,253,108,183,4,236,8,51,132,83,54,55,154,141,69,69,151,231,134,201,224,126,146,125,2,145,106,236,142,167,95,249,244,27,182,51,139,76,182,108,196,251,37,187,62,142,30,174,227,53,104,91,85,128,133,242,69,198,147,108,165,246,48,77,217,69,97,248,54,105,229,57,238,44,85,45,187,196,13,67,221,103,252,11,124,64,101,69,226,220,81,210,161,199,66,178,97,69,156,7,69,7,133,96,13,149,193,226,13,238,157,32,58,141,156,144,46,79,8,148,23,189,170,133,34,188,56,131,118,190,189,223,6,156,185,215,13,121,233,238,96,79,57,110,244,1,10,87,2,5,151,41,61,72,8,245,188,86,166,36,1,145,244,14,42,152,246,111,17,122,213,218,58,12,86,59,40,4,222,179,210,65,208,65,185,148,186,182,196,14,13,95,194,98,34,149,92,249,104,141,134,120,219,22,202,107,90,237,238,159,71,232,213,227,196,46,155,227,189,236,76,49,236,45,93,162,239,148,151,254,168,136,139,109,193,96,58,26,140,71,233,124,43,178,63,16,21,29,148,53,84,19,134,242,239,52,119,91,66,37,114,61,148,185,7,133,241,134,127,40,249,54,75,16,213,59,40,247,81,215,165,209,201,63,32,168,86,248,56,186,61,253,2,164,222,43,91,217,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetDefValueParameterValueEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("16beac21-d7cf-4488-b35f-33e0f912446f"),
				Name = "SetDefValueParameterValueEdit",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e99a885b-40a2-4a8a-9a62-f4bc49585f61"),
				Name = "parameterControlsBinding",
				CreatedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				ModifiedInSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, Terrasoft.UI.WebControls.WebControl>",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,89,75,3,49,16,126,222,66,255,67,220,167,172,72,80,159,132,90,161,151,80,5,93,216,170,207,105,50,219,14,164,201,146,163,30,109,255,187,123,180,180,138,69,16,223,194,204,119,205,100,48,39,180,224,150,47,192,131,29,24,237,173,81,174,143,90,162,158,145,110,151,232,160,20,89,175,201,49,12,27,152,160,125,133,60,79,200,170,221,138,44,248,96,117,167,221,218,180,91,75,110,137,155,146,82,5,94,73,230,109,137,239,7,84,18,44,189,184,188,34,167,191,168,38,165,138,155,178,94,81,128,150,52,166,121,208,194,163,209,52,89,197,85,47,55,22,184,152,19,122,15,239,207,92,5,72,57,218,107,87,251,156,145,9,88,203,157,201,61,123,26,179,23,152,238,44,14,222,55,251,0,35,137,126,91,37,168,143,6,107,102,196,114,105,39,244,39,46,171,115,16,116,36,181,70,128,115,153,152,195,130,167,59,104,221,174,240,73,163,20,137,146,135,58,64,57,78,84,110,44,218,207,123,92,158,13,20,130,246,227,97,181,132,3,70,204,230,40,37,232,91,4,37,217,178,78,210,37,163,55,207,130,71,197,238,178,199,7,6,90,24,9,52,254,70,253,139,89,109,144,116,254,67,138,11,31,184,194,15,24,162,43,20,111,126,147,110,181,55,95,174,96,147,236,234,41,159,1,235,73,153,9,139,133,167,37,102,98,154,35,163,73,210,249,4,59,212,144,58,217,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseProcessUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"));
		}

		#endregion

	}

	#endregion

}

