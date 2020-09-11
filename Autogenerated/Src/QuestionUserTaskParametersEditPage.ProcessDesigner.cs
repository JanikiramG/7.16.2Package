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

	#region Class: QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema

	/// <exclude/>
	public class QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TabPanel _userQuestionTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel UserQuestionTabPanel {
			get {
				return _userQuestionTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _userQuestionTab;
		public Terrasoft.UI.WebControls.Controls.Tab UserQuestionTab {
			get {
				return _userQuestionTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayoutQuestion;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutQuestion {
			get {
				return _controlLayoutQuestion;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _labelDecisionMode;
		public Terrasoft.UI.WebControls.Controls.Label LabelDecisionMode {
			get {
				return _labelDecisionMode;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _singleDecisionMode;
		public Terrasoft.UI.WebControls.Controls.RadioButton SingleDecisionMode {
			get {
				return _singleDecisionMode;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _multipleDecisionMode;
		public Terrasoft.UI.WebControls.Controls.RadioButton MultipleDecisionMode {
			get {
				return _multipleDecisionMode;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _labelAnswers;
		public Terrasoft.UI.WebControls.Controls.Label LabelAnswers {
			get {
				return _labelAnswers;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return _buttonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addButton;
		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return _addButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _editButton;
		public Terrasoft.UI.WebControls.Controls.Button EditButton {
			get {
				return _editButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _deleteButton;
		public Terrasoft.UI.WebControls.Controls.Button DeleteButton {
			get {
				return _deleteButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer2;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return _spacer2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _upButton;
		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return _upButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _downButton;
		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return _downButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _answersTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid AnswersTreeGrid {
			get {
				return _answersTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isDecisionRequiredEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsDecisionRequiredEdit {
			get {
				return _isDecisionRequiredEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _activityTab;
		public Terrasoft.UI.WebControls.Controls.Tab ActivityTab {
			get {
				return _activityTab;
			}
		}

		#endregion

		#region Constructors: Public

		public QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateUserTaskTitleEdit() {
			UserTaskTitleEdit.Image = new ControlImage {};
			UserTaskTitleEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateStartInEdit() {
			StartInEdit.Image = new ControlImage {};
			StartInEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateStartInPeriodEdit() {
			StartInPeriodEdit.Image = new ControlImage {};
			StartInPeriodEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout8() {
			ActivityControlLayout8.Image = new ControlImage {};
			ActivityControlLayout8.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateDurationEdit() {
			DurationEdit.Image = new ControlImage {};
			DurationEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateDurationPeriodEdit() {
			DurationPeriodEdit.Image = new ControlImage {};
			DurationPeriodEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout9() {
			ActivityControlLayout9.Image = new ControlImage {};
			ActivityControlLayout9.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityCategoryEdit() {
			ActivityCategoryEdit.Image = new ControlImage {};
			ActivityCategoryEdit.Enabled = false;
			ActivityCategoryEdit.Hidden = true;
			ActivityCategoryEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout3() {
			ActivityControlLayout3.Image = new ControlImage {};
			ActivityControlLayout3.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateOwnerEdit() {
			OwnerEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			OwnerEdit.Image = new ControlImage {};
			OwnerEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateRemindBeforeEdit() {
			RemindBeforeEdit.Image = new ControlImage {};
			RemindBeforeEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateRemindBeforePeriodEdit() {
			RemindBeforePeriodEdit.Image = new ControlImage {};
			RemindBeforePeriodEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout10() {
			ActivityControlLayout10.Image = new ControlImage {};
			ActivityControlLayout10.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateExecutionContextEdit() {
			ExecutionContextEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			ExecutionContextEdit.Image = new ControlImage {};
			ExecutionContextEdit.Hidden = false;
			ExecutionContextEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout4() {
			ActivityControlLayout4.Image = new ControlImage {};
			ActivityControlLayout4.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout2() {
			ActivityControlLayout2.Image = new ControlImage {};
			ActivityControlLayout2.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout1() {
			BaseProcessUserTaskPageControlLayout1.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout1.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout2() {
			BaseProcessUserTaskPageControlLayout2.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout2.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout11() {
			ActivityControlLayout11.Image = new ControlImage {};
			ActivityControlLayout11.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateLeadEdit() {
			LeadEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			LeadEdit.Image = new ControlImage {};
			LeadEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateAccountEdit() {
			AccountEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			AccountEdit.Image = new ControlImage {};
			AccountEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateContactEdit() {
			ContactEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			ContactEdit.Image = new ControlImage {};
			ContactEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateOpportunityEdit() {
			OpportunityEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			OpportunityEdit.Image = new ControlImage {};
			OpportunityEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout6() {
			ActivityControlLayout6.Image = new ControlImage {};
			ActivityControlLayout6.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateInvoiceEdit() {
			InvoiceEdit.Image = new ControlImage {};
			InvoiceEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateDocumentEdit() {
			DocumentEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			DocumentEdit.Image = new ControlImage {};
			DocumentEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout7() {
			ActivityControlLayout7.Image = new ControlImage {};
			ActivityControlLayout7.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout5() {
			ActivityControlLayout5.Image = new ControlImage {};
			ActivityControlLayout5.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateActivityControlLayout1() {
			ActivityControlLayout1.Padding = "5 5 5 5";
			ActivityControlLayout1.Image = new ControlImage {};
			ActivityControlLayout1.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			RealUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			Name = "QuestionUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
			ParentSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			UseProfile = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema();
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
			UpdateUserTaskTitleEdit();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.InsertItem(0, CreateUserQuestionTabPanel());
			UserQuestionTabPanel.InsertItem(0, CreateUserQuestionTab());
			UserQuestionTab.InsertItem(0, CreateControlLayoutQuestion());
			ControlLayoutQuestion.MoveItem(0, UserTaskTitleEdit);
			ControlLayoutQuestion.MoveItem(1, RecommendationEdit);
			ControlLayoutQuestion.InsertItem(2, CreateLabelDecisionMode());
			ControlLayoutQuestion.InsertItem(3, CreateSingleDecisionMode());
			ControlLayoutQuestion.InsertItem(4, CreateMultipleDecisionMode());
			ControlLayoutQuestion.InsertItem(5, CreateLabelAnswers());
			ControlLayoutQuestion.InsertItem(6, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateButtonsControlLayout());
			ButtonsControlLayout.InsertItem(0, CreateAddButton());
			ButtonsControlLayout.InsertItem(1, CreateEditButton());
			ButtonsControlLayout.InsertItem(2, CreateDeleteButton());
			ButtonsControlLayout.InsertItem(3, CreateSpacer2());
			ButtonsControlLayout.InsertItem(4, CreateUpButton());
			ButtonsControlLayout.InsertItem(5, CreateDownButton());
			ControlLayout1.InsertItem(1, CreateAnswersTreeGrid());
			ControlLayoutQuestion.InsertItem(7, CreateIsDecisionRequiredEdit());
			UserQuestionTabPanel.InsertItem(1, CreateActivityTab());
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

		protected virtual EmbeddedProcessSchema CreateQuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema() {
			var schema = new QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabelDecisionMode() {
			_labelDecisionMode = new Terrasoft.UI.WebControls.Controls.Label();
			_labelDecisionMode.UId = new Guid("79a87e0c-2a9a-4a92-9984-a0a4b34e2889");
			_labelDecisionMode.Name = "LabelDecisionMode";
			_labelDecisionMode.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_labelDecisionMode.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_labelDecisionMode.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_labelDecisionMode.Tag = "";
			_labelDecisionMode.DisplayStyle = Terrasoft.UI.WebControls.Controls.LabelDisplayStyle.GroupHeader;
			_labelDecisionMode.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_labelDecisionMode.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _labelDecisionMode;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateSingleDecisionMode() {
			_singleDecisionMode = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_singleDecisionMode.UId = new Guid("b27f78af-9601-44d1-a833-05fcb1551de6");
			_singleDecisionMode.Name = "SingleDecisionMode";
			_singleDecisionMode.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_singleDecisionMode.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_singleDecisionMode.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_singleDecisionMode.AjaxEvents.Check.IsProcessEventHandler = true;
			_singleDecisionMode.Tag = "";
			_singleDecisionMode.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_singleDecisionMode.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_singleDecisionMode.AlignedByCaption = false;
			_singleDecisionMode.GroupName = "DecisionMode";
			return _singleDecisionMode;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMultipleDecisionMode() {
			_multipleDecisionMode = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_multipleDecisionMode.UId = new Guid("eb021537-c522-4028-b218-7be278cbccc2");
			_multipleDecisionMode.Name = "MultipleDecisionMode";
			_multipleDecisionMode.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_multipleDecisionMode.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_multipleDecisionMode.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_multipleDecisionMode.AjaxEvents.Check.IsProcessEventHandler = true;
			_multipleDecisionMode.Tag = "";
			_multipleDecisionMode.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_multipleDecisionMode.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_multipleDecisionMode.AlignedByCaption = false;
			_multipleDecisionMode.GroupName = "DecisionMode";
			return _multipleDecisionMode;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabelAnswers() {
			_labelAnswers = new Terrasoft.UI.WebControls.Controls.Label();
			_labelAnswers.UId = new Guid("1c2e3a4d-e0d8-488e-bc8d-25fa8ff2f089");
			_labelAnswers.Name = "LabelAnswers";
			_labelAnswers.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_labelAnswers.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_labelAnswers.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_labelAnswers.Tag = "";
			_labelAnswers.DisplayStyle = Terrasoft.UI.WebControls.Controls.LabelDisplayStyle.GroupHeader;
			_labelAnswers.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_labelAnswers.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _labelAnswers;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddButton() {
			_addButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addButton.UId = new Guid("cb925170-2b1c-4b02-aaeb-3641c5a33658");
			_addButton.Name = "AddButton";
			_addButton.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_addButton.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_addButton.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_addButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addButton.Tag = "";
			_addButton.Image = new ControlImage {};
			return _addButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateEditButton() {
			_editButton = new Terrasoft.UI.WebControls.Controls.Button();
			_editButton.UId = new Guid("ca5609f5-4cf8-460b-8524-dd6b02bcee01");
			_editButton.Name = "EditButton";
			_editButton.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_editButton.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_editButton.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_editButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_editButton.Tag = "";
			_editButton.Image = new ControlImage {};
			return _editButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteButton() {
			_deleteButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteButton.UId = new Guid("1666f9c8-6950-459d-a7f9-4eab8fecb19d");
			_deleteButton.Name = "DeleteButton";
			_deleteButton.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_deleteButton.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_deleteButton.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_deleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_deleteButton.Tag = "";
			_deleteButton.Image = new ControlImage {};
			return _deleteButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer2() {
			_spacer2 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer2.UId = new Guid("8865cc75-8171-49ab-ae55-0ce460f509a2");
			_spacer2.Name = "Spacer2";
			_spacer2.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_spacer2.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_spacer2.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_spacer2.Tag = "";
			_spacer2.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpButton() {
			_upButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upButton.UId = new Guid("fa6b9f63-728e-4fce-a3c0-36ad8ab8499d");
			_upButton.Name = "UpButton";
			_upButton.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_upButton.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_upButton.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_upButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upButton.Tag = "";
			_upButton.Image = new ControlImage {};
			return _upButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownButton() {
			_downButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downButton.UId = new Guid("52e06202-a5f8-4194-92c5-20db8b6e00ed");
			_downButton.Name = "DownButton";
			_downButton.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_downButton.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_downButton.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_downButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downButton.Tag = "";
			_downButton.Image = new ControlImage {};
			return _downButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonsControlLayout() {
			_buttonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonsControlLayout.UId = new Guid("76173367-8f65-4cef-b252-a1c11d553a44");
			_buttonsControlLayout.Name = "ButtonsControlLayout";
			_buttonsControlLayout.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_buttonsControlLayout.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_buttonsControlLayout.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_buttonsControlLayout.Tag = "";
			_buttonsControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_buttonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonsControlLayout.StartNewAlignGroup = false;
			_buttonsControlLayout.Image = new ControlImage {};
			_buttonsControlLayout.Edges = "";
			return _buttonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateAnswersTreeGrid() {
			_answersTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_answersTreeGrid.UId = new Guid("fd0743dd-5d52-4304-99f2-a669a98f5926");
			_answersTreeGrid.Name = "AnswersTreeGrid";
			_answersTreeGrid.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_answersTreeGrid.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_answersTreeGrid.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_answersTreeGrid.Tag = "";
			_answersTreeGrid.Edges = "0 1 1 1";
			_answersTreeGrid.IsColumnAutowidth = true;
			_answersTreeGrid.FooterVisible = false;
			_answersTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_answersTreeGrid.IsSummaryVisible = false;
			_answersTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_answersTreeGrid.ToolbarVisible = false;
			_answersTreeGrid.QuickFilterVisible = false;
			_answersTreeGrid.HideHeaders = false;
			return _answersTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("9c64bc96-338e-4457-a8f8-0663c55e871b");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_controlLayout1.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_controlLayout1.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsDecisionRequiredEdit() {
			_isDecisionRequiredEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isDecisionRequiredEdit.UId = new Guid("3bb5ef3a-0f81-4380-b1b5-0c59141ccf81");
			_isDecisionRequiredEdit.Name = "IsDecisionRequiredEdit";
			_isDecisionRequiredEdit.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_isDecisionRequiredEdit.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_isDecisionRequiredEdit.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_isDecisionRequiredEdit.Tag = "";
			_isDecisionRequiredEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isDecisionRequiredEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isDecisionRequiredEdit.AlignedByCaption = false;
			return _isDecisionRequiredEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayoutQuestion() {
			_controlLayoutQuestion = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayoutQuestion.UId = new Guid("b454cebb-6cbf-4d53-9ab2-632ba63c97a1");
			_controlLayoutQuestion.Name = "ControlLayoutQuestion";
			_controlLayoutQuestion.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_controlLayoutQuestion.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_controlLayoutQuestion.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_controlLayoutQuestion.Tag = "";
			_controlLayoutQuestion.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayoutQuestion.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayoutQuestion.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayoutQuestion.Padding = "5 5 5 5";
			_controlLayoutQuestion.StartNewAlignGroup = false;
			_controlLayoutQuestion.Image = new ControlImage {};
			_controlLayoutQuestion.Edges = "";
			return _controlLayoutQuestion;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateUserQuestionTab() {
			_userQuestionTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_userQuestionTab.UId = new Guid("87b1a39f-f467-401b-9466-1a5e399c8aed");
			_userQuestionTab.Name = "UserQuestionTab";
			_userQuestionTab.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_userQuestionTab.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_userQuestionTab.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_userQuestionTab.Tag = "";
			_userQuestionTab.Image = new ControlImage {};
			return _userQuestionTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateActivityTab() {
			_activityTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_activityTab.UId = new Guid("e2ed6d6b-3ca1-4d74-b39d-1efa6f693ca1");
			_activityTab.Name = "ActivityTab";
			_activityTab.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_activityTab.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_activityTab.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_activityTab.Tag = "";
			_activityTab.Image = new ControlImage {};
			return _activityTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateUserQuestionTabPanel() {
			_userQuestionTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_userQuestionTabPanel.UId = new Guid("3799f10a-5c2c-49ab-a9ba-f0fd4a164ce2");
			_userQuestionTabPanel.Name = "UserQuestionTabPanel";
			_userQuestionTabPanel.CreatedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_userQuestionTabPanel.ModifiedInSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			_userQuestionTabPanel.CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			_userQuestionTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			_userQuestionTabPanel.Tag = "";
			_userQuestionTabPanel.ActiveTabIndex = 0;
			_userQuestionTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_userQuestionTabPanel.StartNewAlignGroup = false;
			_userQuestionTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _userQuestionTabPanel;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("17736af0-dba3-4c76-b544-20278e3358c5"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl
	{

		#region Class: OpenAddPageFlowElement

		/// <exclude/>
		public class OpenAddPageFlowElement : OpenPageUserTask
		{

			public OpenAddPageFlowElement(UserConnection userConnection, QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenAddPage";
				IsLogging = false;
				SchemaElementUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenEditPageFlowElement

		/// <exclude/>
		public class OpenEditPageFlowElement : OpenPageUserTask
		{

			public OpenEditPageFlowElement(UserConnection userConnection, QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPage";
				IsLogging = false;
				SchemaElementUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			SchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
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

		public virtual string GatewayCaption {
			get;
			set;
		}

		public virtual bool IsNotSpecifyAnyOneAnswer {
			get;
			set;
		}

		public virtual string InsertedRowValueKey {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess18;
		public ProcessFlowElement EventSubProcess18 {
			get {
				return _eventSubProcess18 ?? (_eventSubProcess18 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess18",
					SchemaElementUId = new Guid("8fbceb1c-af1f-4cef-93c2-bce5b93030a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageSingleDecisionModeCheck;
		public ProcessFlowElement StartMessageSingleDecisionModeCheck {
			get {
				return _startMessageSingleDecisionModeCheck ?? (_startMessageSingleDecisionModeCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageSingleDecisionModeCheck",
					SchemaElementUId = new Guid("d487eb18-18b7-4eaf-abf4-0350a94907f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskSingleDecisionModeCheck;
		public ProcessScriptTask ScriptTaskSingleDecisionModeCheck {
			get {
				return _scriptTaskSingleDecisionModeCheck ?? (_scriptTaskSingleDecisionModeCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSingleDecisionModeCheck",
					SchemaElementUId = new Guid("97fa8789-2fd7-4068-9e1b-d83dcc2c717c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSingleDecisionModeCheckExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess19;
		public ProcessFlowElement EventSubProcess19 {
			get {
				return _eventSubProcess19 ?? (_eventSubProcess19 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess19",
					SchemaElementUId = new Guid("d53f1016-c4ea-4575-a561-725514eec129"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageMultipleDecisionModeCheck;
		public ProcessFlowElement StartMessageMultipleDecisionModeCheck {
			get {
				return _startMessageMultipleDecisionModeCheck ?? (_startMessageMultipleDecisionModeCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageMultipleDecisionModeCheck",
					SchemaElementUId = new Guid("a6ff06a1-5f3b-40cb-b7ab-40159adb2b52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskMultipleDecisionModeCheck;
		public ProcessScriptTask ScriptTaskMultipleDecisionModeCheck {
			get {
				return _scriptTaskMultipleDecisionModeCheck ?? (_scriptTaskMultipleDecisionModeCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskMultipleDecisionModeCheck",
					SchemaElementUId = new Guid("7a72a016-4974-4951-99ab-d2bf68dcc3ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskMultipleDecisionModeCheckExecute,
				});
			}
		}

		private ProcessFlowElement _userQuestionTabPanelTabChangeEventSubProcess;
		public ProcessFlowElement UserQuestionTabPanelTabChangeEventSubProcess {
			get {
				return _userQuestionTabPanelTabChangeEventSubProcess ?? (_userQuestionTabPanelTabChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "UserQuestionTabPanelTabChangeEventSubProcess",
					SchemaElementUId = new Guid("abf5a006-bbf8-41b3-8930-23f318f91d5e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _userQuestionTabPanelTabChangeStartMessage;
		public ProcessFlowElement UserQuestionTabPanelTabChangeStartMessage {
			get {
				return _userQuestionTabPanelTabChangeStartMessage ?? (_userQuestionTabPanelTabChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UserQuestionTabPanelTabChangeStartMessage",
					SchemaElementUId = new Guid("d7c8db68-9e81-49fd-8176-86ae3a1a81c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _userQuestionTabPanelTabChangeScriptTask;
		public ProcessScriptTask UserQuestionTabPanelTabChangeScriptTask {
			get {
				return _userQuestionTabPanelTabChangeScriptTask ?? (_userQuestionTabPanelTabChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UserQuestionTabPanelTabChangeScriptTask",
					SchemaElementUId = new Guid("36d19abb-264a-4d9a-9ce6-4fd490882e92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UserQuestionTabPanelTabChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess13;
		public ProcessFlowElement EventSubProcess13 {
			get {
				return _eventSubProcess13 ?? (_eventSubProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess13",
					SchemaElementUId = new Guid("0593ead2-5378-4f4a-ad3b-6e62d47b71d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _downButtonClickStartMessage;
		public ProcessFlowElement DownButtonClickStartMessage {
			get {
				return _downButtonClickStartMessage ?? (_downButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DownButtonClickStartMessage",
					SchemaElementUId = new Guid("8c5b04f3-922c-4496-8be8-76ba29cc6e89"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _downButtonClickScriptTask;
		public ProcessScriptTask DownButtonClickScriptTask {
			get {
				return _downButtonClickScriptTask ?? (_downButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DownButtonClickScriptTask",
					SchemaElementUId = new Guid("1e435f41-11fd-43c2-bc84-25499de024d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DownButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess12;
		public ProcessFlowElement EventSubProcess12 {
			get {
				return _eventSubProcess12 ?? (_eventSubProcess12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess12",
					SchemaElementUId = new Guid("d4155405-78c2-4560-8216-61901ca913b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _upButtonClickStartMessage;
		public ProcessFlowElement UpButtonClickStartMessage {
			get {
				return _upButtonClickStartMessage ?? (_upButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UpButtonClickStartMessage",
					SchemaElementUId = new Guid("b97f58a8-ac02-46cd-8f61-a0643db4d783"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _upButtonClickScriptTask;
		public ProcessScriptTask UpButtonClickScriptTask {
			get {
				return _upButtonClickScriptTask ?? (_upButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpButtonClickScriptTask",
					SchemaElementUId = new Guid("7a85aaf7-ebbe-4719-9a84-f7bd7ba6ef93"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("f9df4129-679d-46db-9582-bd10f17c8810"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addButtonClickStartMessage;
		public ProcessFlowElement AddButtonClickStartMessage {
			get {
				return _addButtonClickStartMessage ?? (_addButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddButtonClickStartMessage",
					SchemaElementUId = new Guid("47d1ae0b-3dcd-4449-a338-867fe2b9cac1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addButtonClickScriptTask;
		public ProcessScriptTask AddButtonClickScriptTask {
			get {
				return _addButtonClickScriptTask ?? (_addButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddButtonClickScriptTask",
					SchemaElementUId = new Guid("5c048ce9-45ba-487f-bf06-6450d49ac1e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenAddPageFlowElement _openAddPage;
		public OpenAddPageFlowElement OpenAddPage {
			get {
				return _openAddPage ?? (_openAddPage = new OpenAddPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("7d77a1a6-957d-4b0d-a263-c3234be20310"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _editButtonClickStartMessage;
		public ProcessFlowElement EditButtonClickStartMessage {
			get {
				return _editButtonClickStartMessage ?? (_editButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EditButtonClickStartMessage",
					SchemaElementUId = new Guid("c740a5ce-4020-415e-9bc3-be1bf7581d9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _editButtonClickScriptTask;
		public ProcessScriptTask EditButtonClickScriptTask {
			get {
				return _editButtonClickScriptTask ?? (_editButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EditButtonClickScriptTask",
					SchemaElementUId = new Guid("a3d0a3b4-0181-4535-b8c8-1b24f74c4e42"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EditButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenEditPageFlowElement _openEditPage;
		public OpenEditPageFlowElement OpenEditPage {
			get {
				return _openEditPage ?? (_openEditPage = new OpenEditPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess11;
		public ProcessFlowElement EventSubProcess11 {
			get {
				return _eventSubProcess11 ?? (_eventSubProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess11",
					SchemaElementUId = new Guid("71a135d8-4e81-47da-bbe4-0420a753e7df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteButtonClickStartMessage;
		public ProcessFlowElement DeleteButtonClickStartMessage {
			get {
				return _deleteButtonClickStartMessage ?? (_deleteButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteButtonClickStartMessage",
					SchemaElementUId = new Guid("a8f6390d-d7ca-4e63-b42e-bf48da57cd33"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess14;
		public ProcessFlowElement EventSubProcess14 {
			get {
				return _eventSubProcess14 ?? (_eventSubProcess14 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess14",
					SchemaElementUId = new Guid("e2e5909a-f8a5-4388-a6c7-3633b31351fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _answersTreeGridDblClickStartMessage;
		public ProcessFlowElement AnswersTreeGridDblClickStartMessage {
			get {
				return _answersTreeGridDblClickStartMessage ?? (_answersTreeGridDblClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AnswersTreeGridDblClickStartMessage",
					SchemaElementUId = new Guid("e785f9c7-31b5-45cf-9b19-3d2c8a670a8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _editButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent EditButtonClickIntermediateThrowMessageEvent {
			get {
				return _editButtonClickIntermediateThrowMessageEvent ?? (_editButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "EditButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("4397c2d8-c147-4f4c-89e9-cbff877003cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "EditButtonClick",
				});
			}
		}

		private ProcessFlowElement _eventSubProcess15;
		public ProcessFlowElement EventSubProcess15 {
			get {
				return _eventSubProcess15 ?? (_eventSubProcess15 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess15",
					SchemaElementUId = new Guid("ac8b12f1-8147-485e-8a31-7c25c29117bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickStartMessageChild;
		public ProcessFlowElement OkButtonClickStartMessageChild {
			get {
				return _okButtonClickStartMessageChild ?? (_okButtonClickStartMessageChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickStartMessageChild",
					SchemaElementUId = new Guid("5d0f2ab6-28a4-4364-a066-11680a9cc5df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _okButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OkButtonClickIntermediateThrowMessageEvent {
			get {
				return _okButtonClickIntermediateThrowMessageEvent ?? (_okButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OkButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("2bf0154e-46c6-442b-a5a0-f17ba7abafd5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _okButtonClickChildScriptTask;
		public ProcessScriptTask OkButtonClickChildScriptTask {
			get {
				return _okButtonClickChildScriptTask ?? (_okButtonClickChildScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickChildScriptTask",
					SchemaElementUId = new Guid("f924978b-0110-4dc1-8b7f-f2cd8e953dde"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickChildScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _validateScriptTask;
		public ProcessScriptTask ValidateScriptTask {
			get {
				return _validateScriptTask ?? (_validateScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ValidateScriptTask",
					SchemaElementUId = new Guid("529b3708-ca92-4337-88f3-0940d63d5ec4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ValidateScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("e84754fc-3336-4fbe-936a-1f0712bbfd0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _showWorningMessageScriptTask;
		public ProcessScriptTask ShowWorningMessageScriptTask {
			get {
				return _showWorningMessageScriptTask ?? (_showWorningMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowWorningMessageScriptTask",
					SchemaElementUId = new Guid("c8b01802-7199-42d2-b9aa-6d92542f1d0e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowWorningMessageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _answerEditPageClosedEventSubProcess;
		public ProcessFlowElement AnswerEditPageClosedEventSubProcess {
			get {
				return _answerEditPageClosedEventSubProcess ?? (_answerEditPageClosedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AnswerEditPageClosedEventSubProcess",
					SchemaElementUId = new Guid("5ad11564-9cde-4c66-90b7-395a66ca5867"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _answerEditPageClosedStartMessage;
		public ProcessFlowElement AnswerEditPageClosedStartMessage {
			get {
				return _answerEditPageClosedStartMessage ?? (_answerEditPageClosedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AnswerEditPageClosedStartMessage",
					SchemaElementUId = new Guid("524e4aba-3f61-4fa1-a471-5ddd236f25fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _answerEditPageClosedScriptTask;
		public ProcessScriptTask AnswerEditPageClosedScriptTask {
			get {
				return _answerEditPageClosedScriptTask ?? (_answerEditPageClosedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AnswerEditPageClosedScriptTask",
					SchemaElementUId = new Guid("7b72d434-691b-452e-a2a8-7183f5d29650"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AnswerEditPageClosedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess16;
		public ProcessFlowElement EventSubProcess16 {
			get {
				return _eventSubProcess16 ?? (_eventSubProcess16 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess16",
					SchemaElementUId = new Guid("70053423-fce6-4425-bdee-6bfa3f5f3cc2"),
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
					SchemaElementUId = new Guid("d08a613a-d75c-4acd-a67e-b70a59fea22b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _initIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent InitIntermediateThrowMessageEvent {
			get {
				return _initIntermediateThrowMessageEvent ?? (_initIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("0574a9fc-1c0c-4e58-bb09-a699e1ce6679"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initScriptTask;
		public ProcessScriptTask InitScriptTask {
			get {
				return _initScriptTask ?? (_initScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask",
					SchemaElementUId = new Guid("fc320dec-1233-462a-93ae-24b15a48551f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess17;
		public ProcessFlowElement EventSubProcess17 {
			get {
				return _eventSubProcess17 ?? (_eventSubProcess17 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess17",
					SchemaElementUId = new Guid("2cb78049-09c2-4397-b681-8afb09746afd"),
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
					SchemaElementUId = new Guid("073dd44f-ab16-43bd-aaea-6ebca61d415f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _pageLoadCompleteIntermediateThrowMessageEvent ?? (_pageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("0740f650-80f6-4072-9203-0a67e0065bff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("83125548-e0b5-4382-8d50-5d52f8da9a2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _deleteButtonClickScriptTask;
		public ProcessScriptTask DeleteButtonClickScriptTask {
			get {
				return _deleteButtonClickScriptTask ?? (_deleteButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteButtonClickScriptTask",
					SchemaElementUId = new Guid("a182ec10-1caf-4198-a153-a99ea2b63704"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _isValidDataConditionalFlow;
		public ProcessConditionalFlow IsValidDataConditionalFlow {
			get {
				return _isValidDataConditionalFlow ?? (_isValidDataConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsValidDataConditionalFlow",
					SchemaElementUId = new Guid("213fc7cc-f1e2-48fc-90ff-6e4d24a9f951"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _captionColumnCaption;
		public LocalizableString CaptionColumnCaption {
			get {
				return _captionColumnCaption ?? (_captionColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CaptionColumnCaption.Value"));
			}
		}

		private LocalizableString _checkedColumnCaption;
		public LocalizableString CheckedColumnCaption {
			get {
				return _checkedColumnCaption ?? (_checkedColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CheckedColumnCaption.Value"));
			}
		}

		private LocalizableString _windowCaptionPattern;
		public LocalizableString WindowCaptionPattern {
			get {
				return _windowCaptionPattern ?? (_windowCaptionPattern = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WindowCaptionPattern.Value"));
			}
		}

		private LocalizableString _nameColumnCaption;
		public LocalizableString NameColumnCaption {
			get {
				return _nameColumnCaption ?? (_nameColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NameColumnCaption.Value"));
			}
		}

		private LocalizableString _doNotSpecifyAnyOneAnswer;
		public LocalizableString DoNotSpecifyAnyOneAnswer {
			get {
				return _doNotSpecifyAnyOneAnswer ?? (_doNotSpecifyAnyOneAnswer = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DoNotSpecifyAnyOneAnswer.Value"));
			}
		}

		private LocalizableString _validationMessageTitle;
		public LocalizableString ValidationMessageTitle {
			get {
				return _validationMessageTitle ?? (_validationMessageTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTitle.Value"));
			}
		}

		private LocalizableString _noCaptionLocalizableString;
		public LocalizableString NoCaptionLocalizableString {
			get {
				return _noCaptionLocalizableString ?? (_noCaptionLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NoCaptionLocalizableString.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess18.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess18 };
			FlowElements[StartMessageSingleDecisionModeCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageSingleDecisionModeCheck };
			FlowElements[ScriptTaskSingleDecisionModeCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSingleDecisionModeCheck };
			FlowElements[EventSubProcess19.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess19 };
			FlowElements[StartMessageMultipleDecisionModeCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageMultipleDecisionModeCheck };
			FlowElements[ScriptTaskMultipleDecisionModeCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskMultipleDecisionModeCheck };
			FlowElements[UserQuestionTabPanelTabChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionTabPanelTabChangeEventSubProcess };
			FlowElements[UserQuestionTabPanelTabChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionTabPanelTabChangeStartMessage };
			FlowElements[UserQuestionTabPanelTabChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionTabPanelTabChangeScriptTask };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[DownButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DownButtonClickStartMessage };
			FlowElements[DownButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DownButtonClickScriptTask };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[UpButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UpButtonClickStartMessage };
			FlowElements[UpButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpButtonClickScriptTask };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[AddButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickStartMessage };
			FlowElements[AddButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickScriptTask };
			FlowElements[OpenAddPage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenAddPage };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[EditButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickStartMessage };
			FlowElements[EditButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickScriptTask };
			FlowElements[OpenEditPage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPage };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[DeleteButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickStartMessage };
			FlowElements[EventSubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess14 };
			FlowElements[AnswersTreeGridDblClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AnswersTreeGridDblClickStartMessage };
			FlowElements[EditButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickIntermediateThrowMessageEvent };
			FlowElements[EventSubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess15 };
			FlowElements[OkButtonClickStartMessageChild.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessageChild };
			FlowElements[OkButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickIntermediateThrowMessageEvent };
			FlowElements[OkButtonClickChildScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildScriptTask };
			FlowElements[ValidateScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ValidateScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ShowWorningMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowWorningMessageScriptTask };
			FlowElements[AnswerEditPageClosedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AnswerEditPageClosedEventSubProcess };
			FlowElements[AnswerEditPageClosedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AnswerEditPageClosedStartMessage };
			FlowElements[AnswerEditPageClosedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AnswerEditPageClosedScriptTask };
			FlowElements[EventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess16 };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[EventSubProcess17.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess17 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[DeleteButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess18":
						break;
					case "StartMessageSingleDecisionModeCheck":
						e.Context.QueueTasks.Enqueue("ScriptTaskSingleDecisionModeCheck");
						break;
					case "ScriptTaskSingleDecisionModeCheck":
						break;
					case "EventSubProcess19":
						break;
					case "StartMessageMultipleDecisionModeCheck":
						e.Context.QueueTasks.Enqueue("ScriptTaskMultipleDecisionModeCheck");
						break;
					case "ScriptTaskMultipleDecisionModeCheck":
						break;
					case "UserQuestionTabPanelTabChangeEventSubProcess":
						break;
					case "UserQuestionTabPanelTabChangeStartMessage":
						e.Context.QueueTasks.Enqueue("UserQuestionTabPanelTabChangeScriptTask");
						break;
					case "UserQuestionTabPanelTabChangeScriptTask":
						break;
					case "EventSubProcess13":
						break;
					case "DownButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("DownButtonClickScriptTask");
						break;
					case "DownButtonClickScriptTask":
						break;
					case "EventSubProcess12":
						break;
					case "UpButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("UpButtonClickScriptTask");
						break;
					case "UpButtonClickScriptTask":
						break;
					case "EventSubProcess9":
						break;
					case "AddButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("AddButtonClickScriptTask");
						break;
					case "AddButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenAddPage");
						break;
					case "OpenAddPage":
						break;
					case "EventSubProcess10":
						break;
					case "EditButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("EditButtonClickScriptTask");
						break;
					case "EditButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenEditPage");
						break;
					case "OpenEditPage":
						break;
					case "EventSubProcess11":
						break;
					case "DeleteButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("DeleteButtonClickScriptTask");
						break;
					case "EventSubProcess14":
						break;
					case "AnswersTreeGridDblClickStartMessage":
						e.Context.QueueTasks.Enqueue("EditButtonClickIntermediateThrowMessageEvent");
						break;
					case "EditButtonClickIntermediateThrowMessageEvent":
						break;
					case "EventSubProcess15":
						break;
					case "OkButtonClickStartMessageChild":
						e.Context.QueueTasks.Enqueue("ValidateScriptTask");
						break;
					case "OkButtonClickIntermediateThrowMessageEvent":
						break;
					case "OkButtonClickChildScriptTask":
						e.Context.QueueTasks.Enqueue("OkButtonClickIntermediateThrowMessageEvent");
						break;
					case "ValidateScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (IsValidDataConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OkButtonClickChildScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ShowWorningMessageScriptTask");
						break;
					case "ShowWorningMessageScriptTask":
						break;
					case "AnswerEditPageClosedEventSubProcess":
						break;
					case "AnswerEditPageClosedStartMessage":
						e.Context.QueueTasks.Enqueue("AnswerEditPageClosedScriptTask");
						break;
					case "AnswerEditPageClosedScriptTask":
						break;
					case "EventSubProcess16":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "EventSubProcess17":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "DeleteButtonClickScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool IsValidDataConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(!IsNotSpecifyAnyOneAnswer);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageSingleDecisionModeCheck");
			ActivatedEventElements.Add("StartMessageMultipleDecisionModeCheck");
			ActivatedEventElements.Add("UserQuestionTabPanelTabChangeStartMessage");
			ActivatedEventElements.Add("DownButtonClickStartMessage");
			ActivatedEventElements.Add("UpButtonClickStartMessage");
			ActivatedEventElements.Add("AddButtonClickStartMessage");
			ActivatedEventElements.Add("EditButtonClickStartMessage");
			ActivatedEventElements.Add("DeleteButtonClickStartMessage");
			ActivatedEventElements.Add("AnswersTreeGridDblClickStartMessage");
			ActivatedEventElements.Add("OkButtonClickStartMessageChild");
			ActivatedEventElements.Add("AnswerEditPageClosedStartMessage");
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess18":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageSingleDecisionModeCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageSingleDecisionModeCheck";
					result = StartMessageSingleDecisionModeCheck.Execute(context);
					break;
				case "ScriptTaskSingleDecisionModeCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSingleDecisionModeCheck";
					result = ScriptTaskSingleDecisionModeCheck.Execute(context, ScriptTaskSingleDecisionModeCheckExecute);
					break;
				case "EventSubProcess19":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageMultipleDecisionModeCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageMultipleDecisionModeCheck";
					result = StartMessageMultipleDecisionModeCheck.Execute(context);
					break;
				case "ScriptTaskMultipleDecisionModeCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskMultipleDecisionModeCheck";
					result = ScriptTaskMultipleDecisionModeCheck.Execute(context, ScriptTaskMultipleDecisionModeCheckExecute);
					break;
				case "UserQuestionTabPanelTabChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "UserQuestionTabPanelTabChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserQuestionTabPanelTabChangeStartMessage";
					result = UserQuestionTabPanelTabChangeStartMessage.Execute(context);
					break;
				case "UserQuestionTabPanelTabChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserQuestionTabPanelTabChangeScriptTask";
					result = UserQuestionTabPanelTabChangeScriptTask.Execute(context, UserQuestionTabPanelTabChangeScriptTaskExecute);
					break;
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "DownButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownButtonClickStartMessage";
					result = DownButtonClickStartMessage.Execute(context);
					break;
				case "DownButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownButtonClickScriptTask";
					result = DownButtonClickScriptTask.Execute(context, DownButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "UpButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpButtonClickStartMessage";
					result = UpButtonClickStartMessage.Execute(context);
					break;
				case "UpButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpButtonClickScriptTask";
					result = UpButtonClickScriptTask.Execute(context, UpButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "AddButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickStartMessage";
					result = AddButtonClickStartMessage.Execute(context);
					break;
				case "AddButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickScriptTask";
					result = AddButtonClickScriptTask.Execute(context, AddButtonClickScriptTaskExecute);
					break;
				case "OpenAddPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenAddPage";
					result = OpenAddPage.Execute(context);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "EditButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditButtonClickStartMessage";
					result = EditButtonClickStartMessage.Execute(context);
					break;
				case "EditButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditButtonClickScriptTask";
					result = EditButtonClickScriptTask.Execute(context, EditButtonClickScriptTaskExecute);
					break;
				case "OpenEditPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenEditPage";
					result = OpenEditPage.Execute(context);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickStartMessage";
					result = DeleteButtonClickStartMessage.Execute(context);
					break;
				case "EventSubProcess14":
					context.QueueTasks.Dequeue();
					break;
				case "AnswersTreeGridDblClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AnswersTreeGridDblClickStartMessage";
					result = AnswersTreeGridDblClickStartMessage.Execute(context);
					break;
				case "EditButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = EditButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "EventSubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickStartMessageChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessageChild";
					result = OkButtonClickStartMessageChild.Execute(context);
					break;
				case "OkButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = OkButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "OkButtonClickChildScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickChildScriptTask";
					result = OkButtonClickChildScriptTask.Execute(context, OkButtonClickChildScriptTaskExecute);
					break;
				case "ValidateScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ValidateScriptTask";
					result = ValidateScriptTask.Execute(context, ValidateScriptTaskExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ShowWorningMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowWorningMessageScriptTask";
					result = ShowWorningMessageScriptTask.Execute(context, ShowWorningMessageScriptTaskExecute);
					break;
				case "AnswerEditPageClosedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AnswerEditPageClosedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AnswerEditPageClosedStartMessage";
					result = AnswerEditPageClosedStartMessage.Execute(context);
					break;
				case "AnswerEditPageClosedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AnswerEditPageClosedScriptTask";
					result = AnswerEditPageClosedScriptTask.Execute(context, AnswerEditPageClosedScriptTaskExecute);
					break;
				case "EventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
					break;
				case "InitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "EventSubProcess17":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "DeleteButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickScriptTask";
					result = DeleteButtonClickScriptTask.Execute(context, DeleteButtonClickScriptTaskExecute);
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
				case "InsertedRowValueKey":
					InsertedRowValueKey = reader.GetValue<System.String>();
				break;
				case "IsNotSpecifyAnyOneAnswer":
					IsNotSpecifyAnyOneAnswer = reader.GetValue<System.Boolean>();
				break;
				case "GatewayCaption":
					GatewayCaption = reader.GetValue<System.String>();
				break;
				case "ContextKey":
					ContextKey = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskSingleDecisionModeCheckExecute(ProcessExecutingContext context) {
			SetDecisionRequired();
			return true;
		}

		public virtual bool ScriptTaskMultipleDecisionModeCheckExecute(ProcessExecutingContext context) {
			SetDecisionRequired();
			return true;
		}

		public virtual bool UserQuestionTabPanelTabChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.UserQuestionTabPanel.ActiveTabIndex == 1 && !IsUsedActivityControls) {
				SetActivityDurationPeriodEditControlsValue();
				SetDefValueParameterValueEdit(GetActivityControlsBinding());
				/*
				ProcessSchema processSchema = FindDesignedProcessSchema();
				var processSchemaActivity = (ProcessSchemaActivity)processSchema.GetBaseElementByUId(EditElementUId);
				ProcessSchemaParameter parameter = processSchemaActivity.Parameters.FindByName("OwnerId");
				ProcessSchemaParameterValue value = parameter.SourceValue;
				value.SchemaUId = EditSchemaUId;
				value.SchemaManagerName = EditSchemaManagerName;
				Page.OwnerEdit.Value = value;
				*/
				IsUsedActivityControls = true;
			}
			return true;
		}

		public virtual bool DownButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			MoveEditedItem(false);
			return true;
		}

		public virtual bool UpButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			MoveEditedItem(true);
			return true;
		}

		public virtual bool AddButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			OpenAddPage.OpenerInstanceId = InstanceUId;
			OpenAddPage.UseCurrentActivePage = true;
			OpenAddPage.PageUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			OpenAddPage.CloseMessage = "AnswerEditPageClosed";
			InsertedRowValueKey = string.Concat(Name, "_", Guid.NewGuid().ToString());
			OpenAddPage.PageParameters = new Dictionary<string, string>() {
				{ "contextKey", ContextKey },
				{ "treeGridId", Page.AnswersTreeGrid.ClientID },
				{ "insertedRowValueKey", InsertedRowValueKey }
			};
			return true;
		}

		public virtual bool EditButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.AnswersTreeGrid.SelectedNodes.Count == 0) {
				return false;
			}
			TreeGridNode node = Page.AnswersTreeGrid.SelectedNodes[0];
			OpenEditPage.OpenerInstanceId = InstanceUId;
			OpenEditPage.UseCurrentActivePage = true;
			OpenEditPage.PageUId = new Guid("e850c765-038f-405e-b7b4-99e6c0a7fe8b");
			OpenEditPage.CloseMessage = "AnswerEditPageClosed";
			InsertedRowValueKey = string.Concat(Name, "_", Guid.NewGuid().ToString());
			OpenEditPage.PageParameters = new Dictionary<string, string>() {
				{ "contextKey", ContextKey },
				{ "treeGridId", Page.AnswersTreeGrid.ClientID },
				{ "itemId", node.Values["Id"].ToString() },
				{ "insertedRowValueKey", InsertedRowValueKey }
			};
			return true;
		}

		public virtual bool OkButtonClickChildScriptTaskExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.UserTaskTitleEdit.Text;
			
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			
			var decisionMode = GetDecisionMode();
			
			parametersValue["DecisionMode"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value = ((int)decisionMode).ToString()
			};
			
			parametersValue["Question"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value = Page.RecommendationEdit.Text
			};
			
			
			parametersValue["IsDecisionRequired"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value = Page.IsDecisionRequiredEdit.Checked.ToString().ToLower()
			};
			
			LocalizableParameterValuesList items = GetItems();
			if (items == null) {
				return true;
			}
			
			parametersValue["BranchingDecisions"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = items.Count > 0 ? constVS : noneVS,
				LocalizableCollectionValue = items
			};
			
			parametersValue["WindowCaption"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value = String.Format(WindowCaptionPattern, Page.UserTaskTitleEdit.Value)
			};
			return true;
		}

		public virtual bool ValidateScriptTaskExecute(ProcessExecutingContext context) {
			LocalizableParameterValuesList answers = GetItems();
			IsNotSpecifyAnyOneAnswer = answers == null || answers.Count == 0;
			return true;
		}

		public virtual bool ShowWorningMessageScriptTaskExecute(ProcessExecutingContext context) {
			Page.MainMessagePanel.AddMessage(ValidationMessageTitle, DoNotSpecifyAnyOneAnswer, MessageType.Warning);
			return true;
		}

		public virtual bool AnswerEditPageClosedScriptTaskExecute(ProcessExecutingContext context) {
			var insertRowScript = (string)UserConnection.SessionData[InsertedRowValueKey];
			UserConnection.SessionData.Remove(InsertedRowValueKey);
			Page.AddScript(insertRowScript);
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			InvokeInitBaseActivityParametersEditPage();
			CreateAnswersVds();
			object queryStringValue = Page.Request.QueryString["defValuesKey"];
			if (queryStringValue == null) {
				return false;
			}
			
			string defValuesKey = queryStringValue.ToString();
			var values = UserConnection.SessionData[defValuesKey] as Dictionary<string, ProcessSchemaParameterValue>;
			if (values == null) {
				return false;
			}
			
			// Next part of code executes only on first Init becuse of defValuesKey removed
			UserConnection.SessionData.Remove(defValuesKey);
			DefaultValues = values;
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			IsUsedActivityControls = Page.UserQuestionTabPanel.ActiveTabIndex == 1;
			var parameters = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (parameters == null) {
				return true;
			}
			GetewayDecisionSelectionMode decisionMode;
			Enum.TryParse(string.IsNullOrEmpty(parameters["DecisionMode"].Value) ? string.Empty : parameters["DecisionMode"].Value, out decisionMode);
			var decisionModeCB = ControlUtilities.FindControl<UIControls.RadioButton>(Page.TopControlLayout, decisionMode.ToString() + "DecisionMode");
			decisionModeCB.Checked = true;
			Page.RecommendationEdit.SetValue(string.IsNullOrEmpty(parameters["Question"].Value) ? string.Empty : parameters["Question"].Value);
			string isRequired = parameters["IsDecisionRequired"].Value;
			Page.IsDecisionRequiredEdit.Checked = string.IsNullOrEmpty(isRequired) ? false : Boolean.Parse(isRequired);
			LocalizableParameterValuesList items = parameters["BranchingDecisions"].LocalizableCollectionValue;
			if (items == null) {
				items = new LocalizableParameterValuesList();
			} else {
				items.SetupDefaultLocalizableValues("Caption", NoCaptionLocalizableString.Value);
			}
			ContextKey = Guid.NewGuid().ToString();
			Page.TempUserContext.Add(ContextKey);
			UserConnection.SessionData[ContextKey] = items;
			DisplayItems();
			SetDecisionRequired();
			return true;
		}

		public virtual bool DeleteButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			LocalizableParameterValuesList items = GetItems();
			if (items == null) {
				return true;
			}
			// Remove items from user context
			foreach (var node in Page.AnswersTreeGrid.SelectedNodes) {
				var Id = new Guid(node.Values["Id"].ToString());
				items.RemoveAll(el => new Guid(el["Id"].Value) == Id);
			}
			UserConnection.SessionData[ContextKey] = items;
			DisplayItems();
			return true;
		}

		public virtual void CreateAnswersVds() {
			var vds = new VirtualDataSource() {
				ID = "AnswersVds"
			};
			Page.PageContainer.Controls.Add(vds);
			
			// Set vds Id for calendar tree grid
			Page.AnswersTreeGrid.DataSourceId = vds.ID;
			
			DataSourceStructure vdsStructure = vds.DefStructure;
			
			vdsStructure.PrimaryColumnName = "Id";
			vdsStructure.PrimaryDisplayColumnName = "Name";
			
			var guidDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Guid");
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Id",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = guidDvt
			});
			
			var mediumTextDvt = UserConnection.DataValueTypeManager.GetInstanceByName("MediumText");
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Name",
				Caption = NameColumnCaption,
				IsVisible = false,
				IsHideable = true,
				IsSortable = true,
				DataValueType = mediumTextDvt
			});
			
			var maxSizeTextDvt = UserConnection.DataValueTypeManager.GetInstanceByName("MaxSizeText");
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Caption",
				Caption = CaptionColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
			
			var boolDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Boolean");
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "DefChecked",
				Caption = CheckedColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = boolDvt
			});
		}

		public virtual VirtualDataSource GetAnswersVds() {
			return Page.PageContainer.FindControl("AnswersVds") as VirtualDataSource;
		}

		public virtual LocalizableParameterValuesList GetItems() {
			var items = UserConnection.SessionData[ContextKey] as LocalizableParameterValuesList;
			if (items == null) {
				var oldItems = UserConnection.SessionData[ContextKey] as List<Dictionary<string, object>>;
				if (oldItems != null) {
					items = LocalizableParameterValuesList.GetFrom77FormatList(oldItems, "Caption");
				}
			}
			return items;
		}

		public virtual void DisplayItems() {
			LocalizableParameterValuesList items = GetItems();
			if (items == null) {
				return;
			}
			var vds = GetAnswersVds();
			vds.Clear();
			foreach (LocalizableParameterValues item in items) {
				Entity row = vds.CreateRow();
				foreach (string key in item.Keys) {
					row.SetColumnValue(key, item[key].Value);
				}
				vds.Add(row);
			}
			vds.LoadRows();
		}

		public virtual ProcessSchemaDecisionalGateway GetDecisionalGateway() {
			// Get schema manager
			var nameParam = Page.GetParameterValue("EditSchemaManagerName");
			if (nameParam == null) {
				return null;
			}
			
			string managerName = nameParam.ToString();
			ISchemaManager sm = UserConnection.GetSchemaManager(managerName);
			
			// Get schema manager item
			var schemaUIdParam = Page.GetParameterValue("EditSchemaUId");
			if (schemaUIdParam == null) {
				return null;
			}
			
			Guid schemaUId = new Guid(schemaUIdParam.ToString());
			ProcessSchema processSchema = null;
			
			if (sm is ProcessSchemaManager){
				processSchema = ((ProcessSchemaManager)sm).GetDesignInstance(UserConnection, schemaUId) as ProcessSchema;
			} else if (sm is PageSchemaManager) {
				var ps = ((PageSchemaManager)sm).GetDesignInstance(UserConnection, schemaUId) as PageSchema;
				processSchema = ps.EventsProcessSchema;
			}
			
			if (processSchema == null) {
				throw new System.ApplicationException("Unknown schema kind");
			}
			
			// Get edit Item
			var editItemUIdParam = Page.GetParameterValue("EditItemUId");
			if (editItemUIdParam == null) {
				return null;
			}
			
			Guid editItemUId = new Guid(editItemUIdParam.ToString());
			var editItem = processSchema.GetBaseElementByUId(editItemUId);
			
			return editItem as ProcessSchemaDecisionalGateway;
		}

		public virtual Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetGeneralControlsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl>();
		}

		public virtual GetewayDecisionSelectionMode GetDecisionMode() {
			if (Page.MultipleDecisionMode.Checked) {
				return GetewayDecisionSelectionMode.Multiple;
			}
			return GetewayDecisionSelectionMode.Single;
		}

		public virtual void SetDecisionRequired() {
			var decisionMode = GetDecisionMode();
			if (decisionMode == GetewayDecisionSelectionMode.Single) {
				Page.IsDecisionRequiredEdit.SetValue(true);
				Page.IsDecisionRequiredEdit.SetEnabled(false);
			} else {
				Page.IsDecisionRequiredEdit.SetEnabled(true);
			}
		}

		public virtual void MoveEditedItem(bool isMovedUp) {
			LocalizableParameterValuesList items = GetItems();
			TreeGrid treeGrid = Page.AnswersTreeGrid;
			if (items == null || treeGrid.SelectedNodes.Count == 0) {
				return;
			}
			TreeGridNode selectedNode = treeGrid.SelectedNodes[0];
			var itemId = new Guid(selectedNode.Values["Id"].ToString());
			var item = items.Find(el => new Guid(el["Id"].Value) == itemId);
			if (item == null) {
				return;
			}
			int index = items.IndexOf(item);
			if ((isMovedUp && index == 0) || (!isMovedUp && index == items.Count - 1)) {
				return;
			}
			LocalizableParameterValues targetItem;
			ItemMovePosition itemMovePosition;
			if (isMovedUp) {
				targetItem = items[index - 1];
				items[index - 1] = item;
				items[index] = targetItem;
				itemMovePosition = ItemMovePosition.Above;
			} else {
				targetItem = items[index + 1];
				items[index] = targetItem;
				items[index + 1] = item;
				itemMovePosition = ItemMovePosition.Below;
			}
			UserConnection.SessionData[ContextKey] = items;
			VirtualDataSource virtualDataSource = GetAnswersVds();
			virtualDataSource.Move(item["Id"].Value, targetItem["Id"].Value, itemMovePosition);
			treeGrid.SelectNode(itemId.ToString());
			virtualDataSource.SetClientActiveRow(itemId);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SingleDecisionModeCheck":
							if (ActivatedEventElements.Contains("StartMessageSingleDecisionModeCheck")) {
							context.QueueTasks.Enqueue("StartMessageSingleDecisionModeCheck");
						}
						break;
					case "MultipleDecisionModeCheck":
							if (ActivatedEventElements.Contains("StartMessageMultipleDecisionModeCheck")) {
							context.QueueTasks.Enqueue("StartMessageMultipleDecisionModeCheck");
						}
						break;
					case "UserQuestionTabPanelTabChange":
							if (ActivatedEventElements.Contains("UserQuestionTabPanelTabChangeStartMessage")) {
							context.QueueTasks.Enqueue("UserQuestionTabPanelTabChangeStartMessage");
						}
						break;
					case "DownButtonClick":
							if (ActivatedEventElements.Contains("DownButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("DownButtonClickStartMessage");
						}
						break;
					case "UpButtonClick":
							if (ActivatedEventElements.Contains("UpButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("UpButtonClickStartMessage");
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("AddButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("AddButtonClickStartMessage");
						}
						break;
					case "EditButtonClick":
							if (ActivatedEventElements.Contains("EditButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("EditButtonClickStartMessage");
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("DeleteButtonClickStartMessage");
						}
						break;
					case "AnswersTreeGridDblClick":
							if (ActivatedEventElements.Contains("AnswersTreeGridDblClickStartMessage")) {
							context.QueueTasks.Enqueue("AnswersTreeGridDblClickStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessageChild")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessageChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "AnswerEditPageClosed":
							if (ActivatedEventElements.Contains("AnswerEditPageClosedStartMessage")) {
							context.QueueTasks.Enqueue("AnswerEditPageClosedStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
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
			if (!HasMapping("InsertedRowValueKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("InsertedRowValueKey", InsertedRowValueKey, null);
			}
			if (!HasMapping("IsNotSpecifyAnyOneAnswer") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNotSpecifyAnyOneAnswer", IsNotSpecifyAnyOneAnswer, false);
			}
			if (!HasMapping("GatewayCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("GatewayCaption", GatewayCaption, null);
			}
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

	#region Class: QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess : QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<Terrasoft.WebApp.QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl>
	{

		public QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TabPanel UserQuestionTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("UserQuestionTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab UserQuestionTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("UserQuestionTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutQuestion {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayoutQuestion", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label LabelDecisionMode {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("LabelDecisionMode", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton SingleDecisionMode {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("SingleDecisionMode", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton MultipleDecisionMode {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("MultipleDecisionMode", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label LabelAnswers {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("LabelAnswers", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button EditButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("EditButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DeleteButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DeleteButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button UpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DownButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DownButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid AnswersTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("AnswersTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsDecisionRequiredEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsDecisionRequiredEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab ActivityTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("ActivityTab", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			UserQuestionTabPanel.AjaxEvents.TabChange.Event += UserQuestionTabPanelTabChange;
			SingleDecisionMode.AjaxEvents.Check.Event += SingleDecisionModeCheck;
			MultipleDecisionMode.AjaxEvents.Check.Event += MultipleDecisionModeCheck;
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			EditButton.AjaxEvents.Click.Event += EditButtonClick;
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
			UpButton.AjaxEvents.Click.Event += UpButtonClick;
			DownButton.AjaxEvents.Click.Event += DownButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			UserQuestionTabPanel.AjaxEvents.TabChange.Event -= UserQuestionTabPanelTabChange;
			SingleDecisionMode.AjaxEvents.Check.Event -= SingleDecisionModeCheck;
			MultipleDecisionMode.AjaxEvents.Check.Event -= MultipleDecisionModeCheck;
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			EditButton.AjaxEvents.Click.Event -= EditButtonClick;
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
			UpButton.AjaxEvents.Click.Event -= UpButtonClick;
			DownButton.AjaxEvents.Click.Event -= DownButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection);
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

		public virtual void UserQuestionTabPanelTabChange(object sender, EventArgs e) {
			object result = ThrowEvent("UserQuestionTabPanelTabChange");
		}

		public virtual void SingleDecisionModeCheck(object sender, EventArgs e) {
			object result = ThrowEvent("SingleDecisionModeCheck");
		}

		public virtual void MultipleDecisionModeCheck(object sender, EventArgs e) {
			object result = ThrowEvent("MultipleDecisionModeCheck");
		}

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
		}

		public virtual void EditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EditButtonClick");
		}

		public virtual void DeleteButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteButtonClick");
		}

		public virtual void UpButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("UpButtonClick");
		}

		public virtual void DownButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownButtonClick");
		}

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
			SchemaName = "QuestionUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			UId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c");
			CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("93bd589b-6589-45c3-bb26-3f1088cf1c42"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"ContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateGatewayCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d0519ddd-2b06-4032-93f7-d0c1437f954d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"GatewayCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNotSpecifyAnyOneAnswerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f9910b0-0200-4a09-88d6-7b3b4d2be287"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"IsNotSpecifyAnyOneAnswer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInsertedRowValueKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("78c9f723-c5a8-49a9-9385-a983eb359638"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"InsertedRowValueKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateContextKeyParameter());
			Parameters.Add(CreateGatewayCaptionParameter());
			Parameters.Add(CreateIsNotSpecifyAnyOneAnswerParameter());
			Parameters.Add(CreateInsertedRowValueKeyParameter());
		}

		protected virtual void InitializeOpenAddPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("66c19f37-e73b-4343-b6f1-4fb77dffb1c8"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("503efbd3-fe3f-4d27-a664-a9d119e18b86"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c33208d6-1fe9-4f3c-9d39-4707792b1f95"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("15395233-436e-437c-b409-a37be6789e9d"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1e743b75-a1dc-478a-ac58-08e79c26a4fa"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("53e82450-cbae-4d79-b8af-35d937924640"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e520cec3-1f3f-44ad-aece-088db9d1ca35"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ec51d232-be01-41d1-a489-1f0dac145370"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("fb091269-929e-41a7-99e1-9ca297c24032"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7abc1f3e-d13a-400f-90d4-aa254deacbb6"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5b01a928-bba1-4550-995d-01a892b32a66"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e4b09078-1546-474c-8094-29ab396a8d75"),
				ContainerUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeOpenEditPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("008f4de2-85eb-4b22-bc73-4f8f6cde6ce8"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("595dd561-f8e4-406a-b62e-b7a7f0aad41b"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e767c84a-23a1-457c-8bff-3a6cdd6932e1"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("047c0745-1559-4ee2-8226-319f95432fa8"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c85e660e-45f5-4974-a6df-db5069733b2e"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("38bf9df5-13b8-4224-969d-a2967a6121ba"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c81ffdd7-8093-4507-9cf0-e429c7111519"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4dbbd71d-3e1f-45b8-b92f-3dc103829515"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5f1ca473-6194-4e7e-ba96-fb9e52613075"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1089576c-826f-4928-a23f-77f0edc691a9"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7c14d736-b154-4f85-b7eb-c6add2ea888a"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("eeffd964-d891-4328-9e69-f1f4913eb39c"),
				ContainerUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet2.Lanes.Add(schemaLane5);
			ProcessSchemaEventSubProcess eventsubprocess18 = CreateEventSubProcess18EventSubProcess();
			FlowElements.Add(eventsubprocess18);
			ProcessSchemaEventSubProcess eventsubprocess19 = CreateEventSubProcess19EventSubProcess();
			FlowElements.Add(eventsubprocess19);
			ProcessSchemaEventSubProcess userquestiontabpaneltabchangeeventsubprocess = CreateUserQuestionTabPanelTabChangeEventSubProcessEventSubProcess();
			FlowElements.Add(userquestiontabpaneltabchangeeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess14 = CreateEventSubProcess14EventSubProcess();
			FlowElements.Add(eventsubprocess14);
			ProcessSchemaEventSubProcess eventsubprocess15 = CreateEventSubProcess15EventSubProcess();
			FlowElements.Add(eventsubprocess15);
			ProcessSchemaEventSubProcess answereditpageclosedeventsubprocess = CreateAnswerEditPageClosedEventSubProcessEventSubProcess();
			FlowElements.Add(answereditpageclosedeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess16 = CreateEventSubProcess16EventSubProcess();
			FlowElements.Add(eventsubprocess16);
			ProcessSchemaEventSubProcess eventsubprocess17 = CreateEventSubProcess17EventSubProcess();
			FlowElements.Add(eventsubprocess17);
			ProcessSchemaStartMessageEvent startmessagesingledecisionmodecheck = CreateStartMessageSingleDecisionModeCheckStartMessageEvent();
			eventsubprocess18.FlowElements.Add(startmessagesingledecisionmodecheck);
			ProcessSchemaScriptTask scripttasksingledecisionmodecheck = CreateScriptTaskSingleDecisionModeCheckScriptTask();
			eventsubprocess18.FlowElements.Add(scripttasksingledecisionmodecheck);
			ProcessSchemaStartMessageEvent startmessagemultipledecisionmodecheck = CreateStartMessageMultipleDecisionModeCheckStartMessageEvent();
			eventsubprocess19.FlowElements.Add(startmessagemultipledecisionmodecheck);
			ProcessSchemaScriptTask scripttaskmultipledecisionmodecheck = CreateScriptTaskMultipleDecisionModeCheckScriptTask();
			eventsubprocess19.FlowElements.Add(scripttaskmultipledecisionmodecheck);
			ProcessSchemaStartMessageEvent userquestiontabpaneltabchangestartmessage = CreateUserQuestionTabPanelTabChangeStartMessageStartMessageEvent();
			userquestiontabpaneltabchangeeventsubprocess.FlowElements.Add(userquestiontabpaneltabchangestartmessage);
			ProcessSchemaScriptTask userquestiontabpaneltabchangescripttask = CreateUserQuestionTabPanelTabChangeScriptTaskScriptTask();
			userquestiontabpaneltabchangeeventsubprocess.FlowElements.Add(userquestiontabpaneltabchangescripttask);
			ProcessSchemaStartMessageEvent downbuttonclickstartmessage = CreateDownButtonClickStartMessageStartMessageEvent();
			eventsubprocess13.FlowElements.Add(downbuttonclickstartmessage);
			ProcessSchemaScriptTask downbuttonclickscripttask = CreateDownButtonClickScriptTaskScriptTask();
			eventsubprocess13.FlowElements.Add(downbuttonclickscripttask);
			ProcessSchemaStartMessageEvent upbuttonclickstartmessage = CreateUpButtonClickStartMessageStartMessageEvent();
			eventsubprocess12.FlowElements.Add(upbuttonclickstartmessage);
			ProcessSchemaScriptTask upbuttonclickscripttask = CreateUpButtonClickScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(upbuttonclickscripttask);
			ProcessSchemaStartMessageEvent addbuttonclickstartmessage = CreateAddButtonClickStartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(addbuttonclickstartmessage);
			ProcessSchemaScriptTask addbuttonclickscripttask = CreateAddButtonClickScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(addbuttonclickscripttask);
			ProcessSchemaUserTask openaddpage = CreateOpenAddPageUserTask();
			eventsubprocess9.FlowElements.Add(openaddpage);
			ProcessSchemaStartMessageEvent editbuttonclickstartmessage = CreateEditButtonClickStartMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(editbuttonclickstartmessage);
			ProcessSchemaScriptTask editbuttonclickscripttask = CreateEditButtonClickScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(editbuttonclickscripttask);
			ProcessSchemaUserTask openeditpage = CreateOpenEditPageUserTask();
			eventsubprocess10.FlowElements.Add(openeditpage);
			ProcessSchemaStartMessageEvent deletebuttonclickstartmessage = CreateDeleteButtonClickStartMessageStartMessageEvent();
			eventsubprocess11.FlowElements.Add(deletebuttonclickstartmessage);
			ProcessSchemaStartMessageEvent answerstreegriddblclickstartmessage = CreateAnswersTreeGridDblClickStartMessageStartMessageEvent();
			eventsubprocess14.FlowElements.Add(answerstreegriddblclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent editbuttonclickintermediatethrowmessageevent = CreateEditButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess14.FlowElements.Add(editbuttonclickintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessagechild = CreateOkButtonClickStartMessageChildStartMessageEvent();
			eventsubprocess15.FlowElements.Add(okbuttonclickstartmessagechild);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclickintermediatethrowmessageevent = CreateOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess15.FlowElements.Add(okbuttonclickintermediatethrowmessageevent);
			ProcessSchemaScriptTask okbuttonclickchildscripttask = CreateOkButtonClickChildScriptTaskScriptTask();
			eventsubprocess15.FlowElements.Add(okbuttonclickchildscripttask);
			ProcessSchemaScriptTask validatescripttask = CreateValidateScriptTaskScriptTask();
			eventsubprocess15.FlowElements.Add(validatescripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess15.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask showworningmessagescripttask = CreateShowWorningMessageScriptTaskScriptTask();
			eventsubprocess15.FlowElements.Add(showworningmessagescripttask);
			ProcessSchemaStartMessageEvent answereditpageclosedstartmessage = CreateAnswerEditPageClosedStartMessageStartMessageEvent();
			answereditpageclosedeventsubprocess.FlowElements.Add(answereditpageclosedstartmessage);
			ProcessSchemaScriptTask answereditpageclosedscripttask = CreateAnswerEditPageClosedScriptTaskScriptTask();
			answereditpageclosedeventsubprocess.FlowElements.Add(answereditpageclosedscripttask);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocess16.FlowElements.Add(initstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess16.FlowElements.Add(initintermediatethrowmessageevent);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess16.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess17.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent = CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess17.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess17.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaScriptTask deletebuttonclickscripttask = CreateDeleteButtonClickScriptTaskScriptTask();
			FlowElements.Add(deletebuttonclickscripttask);
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateIsValidDataConditionalFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCaptionColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateCheckedColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateWindowCaptionPatternLocalizableString());
			LocalizableStrings.Add(CreateNameColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateDoNotSpecifyAnyOneAnswerLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateNoCaptionLocalizableStringLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCaptionColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("432b55e1-2448-4e10-b363-ed7ac3863a71"),
				Name = "CaptionColumnCaption",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCheckedColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab07fff0-0115-4fcc-86f7-0baf1b685a7d"),
				Name = "CheckedColumnCaption",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWindowCaptionPatternLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("18274249-fae4-4b5d-a588-ef5818efa805"),
				Name = "WindowCaptionPattern",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNameColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3b2fbc36-0eee-4bcd-bc20-7915c43e1eae"),
				Name = "NameColumnCaption",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDoNotSpecifyAnyOneAnswerLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("87923b32-9be8-407b-b2b5-1bd1784b2ea6"),
				Name = "DoNotSpecifyAnyOneAnswer",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c8264888-615c-4924-bd13-ca5bd3f2ac55"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoCaptionLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("452d580e-662e-43d5-b9cf-cb3b491a127e"),
				Name = "NoCaptionLocalizableString",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("91403587-3daa-492a-8ad8-925d06592e35"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("47d1ae0b-3dcd-4449-a338-867fe2b9cac1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c048ce9-45ba-487f-bf06-6450d49ac1e9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("6f0bb7ba-6373-4b1a-8cc6-a1b5c7eea9b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c740a5ce-4020-415e-9bc3-be1bf7581d9e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a3d0a3b4-0181-4535-b8c8-1b24f74c4e42"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("14bb789c-620a-4d66-a9e7-073e024b16fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a8f6390d-d7ca-4e63-b42e-bf48da57cd33"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a182ec10-1caf-4198-a153-a99ea2b63704"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("e806abf1-2755-4ed3-90d8-9bba35cd1a63"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b97f58a8-ac02-46cd-8f61-a0643db4d783"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a85aaf7-ebbe-4719-9a84-f7bd7ba6ef93"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("1e64dd2d-4bab-44d1-ad18-aa44d68a895d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8c5b04f3-922c-4496-8be8-76ba29cc6e89"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1e435f41-11fd-43c2-bc84-25499de024d8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("b5e36daa-7709-43e5-96e0-6159efdcfe44"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(838, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c048ce9-45ba-487f-bf06-6450d49ac1e9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("d318d5b9-c8dd-4e8c-b669-ca587b5490a4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(298, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a3d0a3b4-0181-4535-b8c8-1b24f74c4e42"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("366b28af-c29a-4d76-bbff-9c9f5b23907c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(808, 253),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e785f9c7-31b5-45cf-9b19-3d2c8a670a8d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4397c2d8-c147-4f4c-89e9-cbff877003cc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("b13442bb-db2e-499f-9449-cbd5298d94dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5d0f2ab6-28a4-4364-a066-11680a9cc5df"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("529b3708-ca92-4337-88f3-0940d63d5ec4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("50406c6e-907c-4d86-9458-6e9eef8ba7ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f924978b-0110-4dc1-8b7f-f2cd8e953dde"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2bf0154e-46c6-442b-a5a0-f17ba7abafd5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("f82f4046-7928-403d-bd09-08e0ee9d1d90"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(281, 582),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0574a9fc-1c0c-4e58-bb09-a699e1ce6679"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fc320dec-1233-462a-93ae-24b15a48551f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("60637078-110b-4e45-99ee-e4a5f64ea510"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(576, 580),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("073dd44f-ab16-43bd-aaea-6ebca61d415f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0740f650-80f6-4072-9203-0a67e0065bff"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("71f0294a-c0af-4b67-b7e8-7b268857cac3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(672, 582),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0740f650-80f6-4072-9203-0a67e0065bff"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("83125548-e0b5-4382-8d50-5d52f8da9a2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("db57530b-f531-4248-83b4-9a2a8da89d0d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7c8db68-9e81-49fd-8176-86ae3a1a81c1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("36d19abb-264a-4d9a-9ce6-4fd490882e92"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("f3663ad9-4f8e-4c83-b14e-026627e7ee7b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(166, 742),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d08a613a-d75c-4acd-a67e-b70a59fea22b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0574a9fc-1c0c-4e58-bb09-a699e1ce6679"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("031fb228-5bf0-41e2-b829-9841d93a303a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("529b3708-ca92-4337-88f3-0940d63d5ec4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e84754fc-3336-4fbe-936a-1f0712bbfd0c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsValidDataConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsValidDataConditionalFlow",
				UId = new Guid("213fc7cc-f1e2-48fc-90ff-6e4d24a9f951"),
				ConditionExpression = @"!IsNotSpecifyAnyOneAnswer",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(382, 587),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e84754fc-3336-4fbe-936a-1f0712bbfd0c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f924978b-0110-4dc1-8b7f-f2cd8e953dde"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow26",
				UId = new Guid("6ca01bf9-09e1-4471-8b78-a9717d84a8dd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(373, 656),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e84754fc-3336-4fbe-936a-1f0712bbfd0c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c8b01802-7199-42d2-b9aa-6d92542f1d0e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow27",
				UId = new Guid("48e7fc4d-d234-416d-b3ac-08c894aeeea1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d487eb18-18b7-4eaf-abf4-0350a94907f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97fa8789-2fd7-4068-9e1b-d83dcc2c717c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow28",
				UId = new Guid("a77d309c-bb99-401b-8496-779160db6292"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a6ff06a1-5f3b-40cb-b7ab-40159adb2b52"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a72a016-4974-4951-99ab-d2bf68dcc3ce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8283b967-b81e-41d6-b6aa-e94d81b3a80f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("e6eed693-79a7-45b3-97fa-872194b03e24"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CurveCenterPosition = new Point(708, 766),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("524e4aba-3f61-4fa1-a471-5ddd236f25fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b72d434-691b-452e-a2a8-7183f5d29650"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1896ccea-7e3c-4eab-bc7e-a9bd5d169ab7"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"LaneSet2",
				Position = new Point(5, 5),
				Size = new Size(1079, 169),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("1896ccea-7e3c-4eab-bc7e-a9bd5d169ab7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"Lane5",
				Position = new Point(29, 0),
				Size = new Size(1050, 169),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess18EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess18 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8fbceb1c-af1f-4cef-93c2-bce5b93030a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess18",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess18;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageSingleDecisionModeCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d487eb18-18b7-4eaf-abf4-0350a94907f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fbceb1c-af1f-4cef-93c2-bce5b93030a2"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SingleDecisionModeCheck",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"StartMessageSingleDecisionModeCheck",
				Position = new Point(36, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSingleDecisionModeCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("97fa8789-2fd7-4068-9e1b-d83dcc2c717c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fbceb1c-af1f-4cef-93c2-bce5b93030a2"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"ScriptTaskSingleDecisionModeCheck",
				Position = new Point(148, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,73,77,206,44,206,204,207,11,74,45,44,205,44,74,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,26,202,123,124,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess19EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess19 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d53f1016-c4ea-4575-a561-725514eec129"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess19",
				Position = new Point(294, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess19;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageMultipleDecisionModeCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a6ff06a1-5f3b-40cb-b7ab-40159adb2b52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d53f1016-c4ea-4575-a561-725514eec129"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MultipleDecisionModeCheck",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"StartMessageMultipleDecisionModeCheck",
				Position = new Point(22, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskMultipleDecisionModeCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7a72a016-4974-4951-99ab-d2bf68dcc3ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d53f1016-c4ea-4575-a561-725514eec129"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"ScriptTaskMultipleDecisionModeCheck",
				Position = new Point(162, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,73,77,206,44,206,204,207,11,74,45,44,205,44,74,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,26,202,123,124,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateUserQuestionTabPanelTabChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaUserQuestionTabPanelTabChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("abf5a006-bbf8-41b3-8930-23f318f91d5e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"UserQuestionTabPanelTabChangeEventSubProcess",
				Position = new Point(36, 184),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaUserQuestionTabPanelTabChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUserQuestionTabPanelTabChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d7c8db68-9e81-49fd-8176-86ae3a1a81c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("abf5a006-bbf8-41b3-8930-23f318f91d5e"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UserQuestionTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"UserQuestionTabPanelTabChangeStartMessage",
				Position = new Point(35, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUserQuestionTabPanelTabChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("36d19abb-264a-4d9a-9ce6-4fd490882e92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("abf5a006-bbf8-41b3-8930-23f318f91d5e"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"UserQuestionTabPanelTabChangeScriptTask",
				Position = new Point(140, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,193,78,195,48,12,134,207,76,218,59,132,29,166,116,135,76,156,81,15,148,14,212,3,80,52,182,123,104,188,17,169,75,39,39,45,76,136,119,199,73,215,110,69,19,151,40,191,253,217,254,19,89,111,24,207,229,22,196,202,2,190,214,96,157,174,204,155,124,207,165,129,82,220,21,78,55,64,50,51,10,190,88,28,179,27,54,157,178,235,204,18,174,66,86,187,195,125,101,28,86,165,141,216,247,120,116,181,4,215,37,210,26,165,239,151,3,234,74,45,148,118,29,186,150,101,13,60,186,109,249,20,54,33,144,75,148,59,112,128,65,121,158,63,158,186,117,181,137,54,74,155,45,143,66,249,124,70,71,142,85,1,214,46,139,15,216,73,182,31,168,152,61,80,65,10,86,111,13,168,1,217,26,104,36,14,75,186,129,84,202,243,75,137,104,128,11,242,152,72,11,139,18,118,96,92,114,88,101,138,123,243,199,0,201,48,103,208,170,127,42,219,247,183,248,178,13,209,179,86,248,167,36,135,103,146,124,242,242,105,0,51,53,249,167,121,248,71,214,132,51,62,77,18,203,170,198,2,66,182,253,1,186,136,182,150,220,18,234,237,247,250,47,242,36,13,109,12,122,23,3,244,44,30,44,249,181,10,38,61,34,214,71,23,77,55,117,54,167,227,242,38,17,230,48,80,63,227,17,130,171,209,180,129,95,155,15,81,49,175,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0593ead2-5378-4f4a-ad3b-6e62d47b71d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess13",
				Position = new Point(36, 360),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(227, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDownButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8c5b04f3-922c-4496-8be8-76ba29cc6e89"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0593ead2-5378-4f4a-ad3b-6e62d47b71d5"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownButtonClick",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"DownButtonClickStartMessage",
				Position = new Point(35, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDownButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1e435f41-11fd-43c2-bc84-25499de024d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0593ead2-5378-4f4a-ad3b-6e62d47b71d5"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"DownButtonClickScriptTask",
				Position = new Point(126, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,47,75,117,77,201,44,73,77,241,44,73,205,213,72,75,204,41,78,213,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,163,173,5,102,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d4155405-78c2-4560-8216-61901ca913b0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess12",
				Position = new Point(302, 359),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUpButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b97f58a8-ac02-46cd-8f61-a0643db4d783"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4155405-78c2-4560-8216-61901ca913b0"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpButtonClick",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"UpButtonClickStartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7a85aaf7-ebbe-4719-9a84-f7bd7ba6ef93"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4155405-78c2-4560-8216-61901ca913b0"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"UpButtonClickScriptTask",
				Position = new Point(140, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,47,75,117,77,201,44,73,77,241,44,73,205,213,40,41,42,77,213,180,230,229,42,74,45,41,45,202,83,0,113,173,1,99,19,41,117,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f9df4129-679d-46db-9582-bd10f17c8810"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess9",
				Position = new Point(575, 359),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(360, 148),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("47d1ae0b-3dcd-4449-a338-867fe2b9cac1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9df4129-679d-46db-9582-bd10f17c8810"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"AddButtonClickStartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5c048ce9-45ba-487f-bf06-6450d49ac1e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9df4129-679d-46db-9582-bd10f17c8810"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"AddButtonClickScriptTask",
				Position = new Point(126, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,93,107,194,64,16,124,174,224,127,56,238,41,129,36,4,234,39,253,0,137,69,66,169,145,86,251,90,206,220,42,7,246,82,246,54,77,69,252,239,221,36,86,138,237,203,114,123,51,179,179,115,151,125,128,157,104,189,80,91,136,50,62,3,166,214,145,178,57,164,90,220,137,159,102,149,234,155,110,39,251,69,94,57,72,74,68,176,52,201,201,124,66,125,201,2,194,18,46,152,117,89,53,211,44,84,98,86,26,237,73,24,245,227,124,56,232,135,241,245,104,19,246,226,62,132,235,225,186,23,142,199,48,200,99,53,220,192,104,45,253,139,65,201,174,112,240,4,206,181,86,114,98,93,5,248,160,13,213,112,131,106,201,26,94,26,144,64,63,23,213,171,218,149,240,8,123,166,59,66,99,183,81,82,216,92,145,55,87,239,16,8,249,38,131,102,163,104,14,85,179,153,31,45,139,151,134,233,249,151,254,117,89,40,100,37,1,186,83,158,169,225,248,133,85,184,191,109,29,130,147,211,189,231,139,67,183,115,117,16,50,47,44,193,23,241,30,108,151,156,27,113,12,90,156,16,96,134,70,167,154,241,198,170,141,230,150,39,128,163,27,126,233,116,122,150,152,191,25,89,251,95,242,99,183,115,228,32,8,84,162,109,255,231,27,126,220,61,0,245,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenAddPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("dd51e692-fbf8-4425-aadb-4395b3967e57"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9df4129-679d-46db-9582-bd10f17c8810"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"OpenAddPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 35),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenAddPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7d77a1a6-957d-4b0d-a263-c3234be20310"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess10",
				Position = new Point(35, 511),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(361, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEditButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c740a5ce-4020-415e-9bc3-be1bf7581d9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7d77a1a6-957d-4b0d-a263-c3234be20310"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EditButtonClickStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEditButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a3d0a3b4-0181-4535-b8c8-1b24f74c4e42"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7d77a1a6-957d-4b0d-a263-c3234be20310"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EditButtonClickScriptTask",
				Position = new Point(127, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,223,107,194,48,16,126,158,224,255,16,242,212,66,45,133,249,147,205,129,212,33,101,204,201,212,189,136,140,216,92,37,80,211,145,164,235,100,248,191,239,154,86,55,84,216,203,193,229,190,239,238,190,239,34,18,226,204,216,22,252,145,212,5,40,189,80,0,19,37,184,63,135,20,98,3,124,154,113,208,126,152,229,210,144,225,144,4,46,249,110,54,110,20,152,92,73,146,176,84,195,93,179,113,104,54,142,196,18,79,100,25,134,228,255,198,171,96,141,244,151,15,144,143,92,24,139,47,19,80,145,212,134,201,24,34,142,125,142,201,50,226,231,232,165,134,48,87,10,164,25,197,70,124,66,249,136,12,163,114,56,135,150,97,105,251,73,40,200,36,23,220,161,208,239,4,113,175,219,105,5,183,253,164,213,14,58,208,218,244,54,237,214,96,0,221,56,96,189,4,250,27,234,158,119,10,211,76,195,51,104,93,13,163,149,196,99,217,86,57,69,18,238,13,10,165,190,102,197,27,75,115,120,130,61,194,181,81,66,110,209,82,25,51,227,76,217,14,60,66,223,169,103,87,242,167,80,216,213,92,127,145,205,45,210,113,47,22,40,195,140,41,164,26,180,182,86,52,22,232,64,38,153,218,223,87,35,188,122,212,131,83,29,237,155,208,56,147,6,190,12,46,130,243,194,83,66,14,94,85,55,245,149,34,142,245,171,231,11,83,129,102,71,227,19,69,24,216,89,120,121,116,223,234,212,43,138,47,235,63,10,126,209,151,150,32,245,154,81,248,167,14,168,187,254,105,246,160,63,182,122,255,227,173,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("018ffaff-a16e-4f9d-be97-f7e36ab17c7a"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7d77a1a6-957d-4b0d-a263-c3234be20310"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"OpenEditPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 37),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenEditPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("71a135d8-4e81-47da-bbe4-0420a753e7df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess11",
				Position = new Point(428, 527),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(257, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a8f6390d-d7ca-4e63-b42e-bf48da57cd33"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71a135d8-4e81-47da-bbe4-0420a753e7df"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"DeleteButtonClickStartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e2e5909a-f8a5-4388-a6c7-3633b31351fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess14",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(700, 525),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAnswersTreeGridDblClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e785f9c7-31b5-45cf-9b19-3d2c8a670a8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2e5909a-f8a5-4388-a6c7-3633b31351fe"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AnswersTreeGridDblClick",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"AnswersTreeGridDblClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateEditButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4397c2d8-c147-4f4c-89e9-cbff877003cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2e5909a-f8a5-4388-a6c7-3633b31351fe"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EditButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ac8b12f1-8147-485e-8a31-7c25c29117bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess15",
				Position = new Point(36, 687),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(537, 247),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5d0f2ab6-28a4-4364-a066-11680a9cc5df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac8b12f1-8147-485e-8a31-7c25c29117bf"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"OkButtonClickStartMessageChild",
				Position = new Point(28, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2bf0154e-46c6-442b-a5a0-f17ba7abafd5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac8b12f1-8147-485e-8a31-7c25c29117bf"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"OkButtonClickIntermediateThrowMessageEvent",
				Position = new Point(462, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickChildScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f924978b-0110-4dc1-8b7f-f2cd8e953dde"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac8b12f1-8147-485e-8a31-7c25c29117bf"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"OkButtonClickChildScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(337, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,201,78,195,48,16,61,83,169,255,96,113,74,164,42,226,76,41,72,180,128,42,21,84,232,194,1,113,48,246,64,45,28,187,216,19,202,34,254,29,219,89,72,23,16,28,128,91,50,126,51,243,230,205,114,36,33,5,133,103,176,232,210,57,10,173,72,135,12,233,29,36,19,11,102,76,237,253,88,160,132,35,46,48,25,195,19,182,155,141,102,227,145,26,162,180,130,233,200,131,141,102,96,237,136,205,32,165,67,106,104,10,8,102,74,101,6,35,157,25,6,201,153,131,182,115,47,166,149,197,111,186,117,3,214,27,170,164,243,18,103,131,61,80,93,182,80,75,122,130,249,58,168,121,222,179,104,132,186,107,125,149,108,223,5,23,183,36,90,11,221,33,42,147,50,38,175,205,198,214,106,150,206,6,60,81,176,248,105,238,40,142,93,250,183,178,60,14,76,88,231,126,170,185,15,120,2,216,171,89,162,56,232,176,146,248,106,187,142,217,190,46,136,124,145,53,202,107,114,112,113,43,128,247,85,14,154,244,185,243,245,141,174,254,91,14,150,55,195,189,20,173,243,182,74,132,72,40,140,235,172,227,100,172,71,161,240,40,118,133,109,38,124,158,129,245,42,253,45,217,48,212,23,192,116,234,230,157,83,79,160,154,234,146,234,6,178,125,91,234,123,1,15,153,48,192,255,129,246,58,137,64,189,59,3,118,15,188,166,185,251,28,232,5,152,15,245,7,154,81,41,94,232,141,132,101,138,118,32,44,18,129,144,218,124,214,250,254,51,12,153,223,135,226,161,190,5,6,48,51,138,160,9,27,249,182,81,174,67,67,21,155,57,46,37,97,251,139,114,5,142,238,78,100,10,201,62,217,33,7,213,125,217,45,238,147,135,215,20,232,106,41,33,108,104,41,111,8,241,233,164,94,10,197,117,121,24,255,182,239,121,71,147,99,109,82,138,209,18,145,33,69,151,79,181,62,187,211,33,68,49,0,245,158,189,3,32,0,133,48,235,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateValidateScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("529b3708-ca92-4337-88f3-0940d63d5ec4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac8b12f1-8147-485e-8a31-7c25c29117bf"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"ValidateScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,140,187,10,194,80,16,5,123,193,127,216,82,27,177,15,41,130,133,4,130,17,4,251,53,28,225,194,205,94,217,7,18,201,199,27,5,109,231,204,153,174,12,156,211,139,111,25,103,86,30,225,208,43,231,128,117,201,156,88,236,9,53,170,233,8,111,29,163,109,182,213,122,213,218,169,248,229,129,33,221,167,70,166,94,208,124,197,197,251,63,106,146,200,153,230,249,135,118,135,18,226,159,97,191,36,20,30,42,228,26,168,222,33,33,29,215,133,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("e84754fc-3336-4fbe-936a-1f0712bbfd0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac8b12f1-8147-485e-8a31-7c25c29117bf"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateShowWorningMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c8b01802-7199-42d2-b9aa-6d92542f1d0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac8b12f1-8147-485e-8a31-7c25c29117bf"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"ShowWorningMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(336, 147),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,77,204,204,243,77,45,46,6,178,3,18,243,82,115,244,28,83,82,160,124,141,176,196,156,204,148,196,146,204,124,152,138,144,204,146,156,84,29,5,151,124,191,252,146,224,130,212,228,204,180,74,199,188,74,255,188,84,199,188,226,242,212,34,29,5,152,186,202,130,84,189,240,196,162,188,204,188,116,77,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,120,221,20,6,118,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAnswerEditPageClosedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAnswerEditPageClosedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5ad11564-9cde-4c66-90b7-395a66ca5867"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("e6eed693-79a7-45b3-97fa-872194b03e24"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"AnswerEditPageClosedEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(588, 686),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(214, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAnswerEditPageClosedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAnswerEditPageClosedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("524e4aba-3f61-4fa1-a471-5ddd236f25fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ad11564-9cde-4c66-90b7-395a66ca5867"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("e6eed693-79a7-45b3-97fa-872194b03e24"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AnswerEditPageClosed",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"AnswerEditPageClosedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAnswerEditPageClosedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7b72d434-691b-452e-a2a8-7183f5d29650"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ad11564-9cde-4c66-90b7-395a66ca5867"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("e6eed693-79a7-45b3-97fa-872194b03e24"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"AnswerEditPageClosedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,204,43,78,45,42,9,202,47,15,78,46,202,44,40,81,176,85,208,40,46,41,202,204,75,215,12,5,74,56,231,231,229,165,38,151,100,230,231,233,5,167,22,23,3,105,151,196,146,196,104,79,176,166,212,20,160,182,176,196,156,210,84,239,212,202,88,107,94,46,220,58,244,130,82,115,243,203,82,53,176,104,212,4,106,12,72,76,79,213,115,76,73,129,184,65,3,205,77,32,21,69,169,37,165,69,121,10,37,69,165,169,214,0,208,222,103,238,183,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("70053423-fce6-4425-bdee-6bfa3f5f3cc2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess16",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 967),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(315, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d08a613a-d75c-4acd-a67e-b70a59fea22b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70053423-fce6-4425-bdee-6bfa3f5f3cc2"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0574a9fc-1c0c-4e58-bb09-a699e1ce6679"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70053423-fce6-4425-bdee-6bfa3f5f3cc2"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fc320dec-1233-462a-93ae-24b15a48551f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70053423-fce6-4425-bdee-6bfa3f5f3cc2"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,81,205,78,194,64,16,62,219,164,239,48,225,4,137,41,15,128,152,32,120,32,38,6,69,185,16,14,67,59,197,213,178,171,179,211,74,99,124,119,167,91,80,212,24,47,187,217,253,126,102,190,153,169,173,220,19,77,173,145,11,244,52,74,197,84,70,234,25,50,110,73,136,253,101,102,100,134,27,234,246,6,113,52,102,66,161,145,245,175,138,44,50,31,62,221,250,145,82,129,151,146,184,158,11,27,187,89,96,81,18,12,161,209,37,183,164,136,151,228,230,11,95,118,50,202,3,201,95,81,221,89,169,137,201,161,251,219,97,8,182,44,138,30,188,197,209,9,147,148,108,33,199,194,147,10,222,227,40,142,124,32,195,177,155,150,253,233,147,220,185,246,21,218,173,144,161,10,108,165,222,123,226,177,179,86,3,24,103,147,57,121,175,247,4,5,151,199,166,43,64,15,19,19,72,200,245,89,91,247,20,102,236,82,149,204,211,7,218,226,231,204,130,236,124,31,234,80,234,191,40,253,62,92,211,78,224,25,89,192,229,144,186,140,128,118,148,150,162,114,103,139,90,15,200,13,123,129,102,91,176,86,200,83,67,253,22,159,105,235,42,202,226,232,239,104,186,146,134,211,61,214,53,147,153,80,142,101,33,139,195,112,218,214,21,216,247,43,92,210,224,3,225,145,66,32,48,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess17EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess17 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2cb78049-09c2-4397-b681-8afb09746afd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"EventSubProcess17",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 966),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(343, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess17;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("073dd44f-ab16-43bd-aaea-6ebca61d415f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cb78049-09c2-4397-b681-8afb09746afd"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0740f650-80f6-4072-9203-0a67e0065bff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cb78049-09c2-4397-b681-8afb09746afd"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("83125548-e0b5-4382-8d50-5d52f8da9a2a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cb78049-09c2-4397-b681-8afb09746afd"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,93,111,211,48,20,125,166,82,255,195,85,159,82,81,69,226,21,214,161,181,41,83,69,41,165,31,188,76,123,240,146,219,213,194,177,131,237,108,203,208,254,59,215,142,67,221,13,49,158,18,219,231,156,123,238,135,61,55,59,131,197,69,110,249,29,183,205,84,73,171,149,48,48,134,21,187,197,148,206,244,183,26,141,229,74,110,217,205,138,73,20,169,7,35,45,231,178,192,7,24,143,225,221,135,126,239,142,105,168,152,102,37,90,212,78,32,195,61,171,133,253,206,4,9,0,51,144,241,220,233,48,221,156,25,171,185,188,29,193,74,171,28,141,217,228,7,44,217,170,99,123,202,57,105,242,61,36,177,230,24,100,45,196,16,126,245,123,111,52,218,90,75,176,186,70,66,62,245,123,151,4,186,103,77,134,57,55,20,102,131,2,125,188,47,170,64,40,194,174,91,16,124,38,235,50,221,234,134,66,26,76,90,55,233,220,44,73,253,171,158,149,149,109,162,184,87,131,44,98,15,174,83,239,111,8,31,33,16,61,1,222,195,107,148,17,168,218,158,88,25,134,194,197,123,211,9,21,47,52,98,103,185,224,150,163,73,63,113,89,132,205,179,221,188,235,83,186,102,5,87,147,218,90,37,207,19,223,178,173,170,194,233,130,53,20,111,116,34,78,199,27,111,58,25,194,91,56,117,233,204,156,26,73,167,7,204,127,96,65,134,66,157,125,136,53,230,170,44,81,22,204,213,119,86,112,155,110,176,109,244,235,181,236,198,233,63,235,248,2,78,38,90,56,112,179,198,159,53,215,222,95,204,153,155,46,175,14,208,177,187,12,94,34,124,22,199,116,255,154,198,49,160,51,189,103,194,32,185,157,40,37,144,201,180,157,165,8,67,193,22,42,103,130,63,178,27,129,167,211,109,22,220,88,224,22,75,243,204,252,68,51,153,31,40,120,231,208,144,249,72,103,170,68,24,236,46,35,119,75,130,82,124,65,58,113,137,247,240,111,31,137,179,250,4,232,242,249,195,116,45,173,171,112,137,35,126,75,75,6,83,86,249,190,140,96,169,194,127,132,106,135,236,216,50,186,159,110,42,241,193,126,198,134,76,93,214,188,72,151,120,239,190,201,48,154,202,174,67,91,44,43,247,250,4,86,122,81,20,201,81,193,193,194,169,108,139,65,118,141,171,86,198,44,187,58,2,175,41,150,79,135,8,25,55,149,96,205,220,45,125,32,202,240,249,24,248,253,248,105,249,13,22,163,106,200,32,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a182ec10-1caf-4198-a153-a99ea2b63704"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6992dfda-725b-42bd-9e26-277d55d1ccdb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Name = @"DeleteButtonClickScriptTask",
				Position = new Point(573, 562),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,144,193,106,195,48,16,68,207,49,248,31,150,156,228,139,243,1,197,133,144,128,49,13,37,52,105,47,33,7,213,26,167,2,89,42,43,41,105,90,250,239,149,99,67,122,210,130,102,102,223,236,198,181,210,232,111,249,110,176,149,44,123,4,240,155,52,17,126,163,125,32,29,208,123,170,168,70,104,134,81,20,15,121,166,59,18,211,71,69,54,26,83,208,79,158,205,24,33,178,165,192,17,73,244,155,103,139,5,189,160,119,103,76,49,29,187,158,162,7,83,235,108,192,87,200,179,206,49,100,251,65,226,44,153,172,83,73,106,105,43,79,40,151,214,95,192,126,207,64,205,90,149,59,24,180,1,234,57,137,252,184,112,240,52,42,209,89,92,168,142,90,137,33,161,28,241,15,243,70,205,143,229,222,237,2,107,123,18,197,64,62,187,129,148,35,213,210,24,1,67,213,227,221,15,51,217,110,25,197,208,175,81,197,216,230,53,129,175,156,181,137,66,59,155,120,188,79,239,90,6,121,88,141,117,158,112,61,38,154,219,142,228,89,107,255,105,228,245,126,183,255,7,250,3,244,184,122,128,120,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateAnswersVdsMethod());
			Methods.Add(CreateGetAnswersVdsMethod());
			Methods.Add(CreateGetItemsMethod());
			Methods.Add(CreateDisplayItemsMethod());
			Methods.Add(CreateGetDecisionalGatewayMethod());
			Methods.Add(CreateGetGeneralControlsBindingMethod());
			Methods.Add(CreateGetDecisionModeMethod());
			Methods.Add(CreateSetDecisionRequiredMethod());
			Methods.Add(CreateMoveEditedItemMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("30467d35-609e-4f88-a5b9-2b0b6497b2a5"),
				Name = "System.Runtime.Serialization.Formatters",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c87ded00-3314-471d-86f6-1551df1ef8c9"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
		}

		protected virtual SchemaMethod CreateCreateAnswersVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dc8eaae9-5225-4889-8024-2b0a79072988"),
				Name = "CreateAnswersVds",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,148,209,78,194,48,20,134,175,221,83,52,187,26,137,153,15,64,184,0,150,224,46,48,38,67,238,143,235,1,27,187,150,180,29,138,134,119,247,116,107,24,76,98,140,224,205,214,253,61,253,207,249,191,38,219,130,97,91,110,217,136,41,124,99,75,97,92,13,50,3,7,133,174,77,137,201,128,125,70,55,121,70,251,241,88,217,55,52,118,201,109,28,237,135,209,35,172,49,245,143,169,86,14,132,66,147,250,149,209,210,166,99,206,19,114,29,12,163,232,238,142,21,232,154,30,57,103,43,109,88,9,18,21,167,190,206,32,178,181,17,188,245,10,254,11,82,103,36,166,221,20,116,112,228,29,210,60,35,199,78,47,156,169,75,87,27,244,155,221,71,91,155,225,234,32,209,169,227,138,244,209,136,10,204,110,170,101,93,169,7,168,252,153,56,231,241,240,108,89,38,236,70,66,175,218,191,99,239,75,65,214,181,224,217,214,145,252,100,209,16,5,133,165,19,90,53,17,150,32,107,92,236,54,56,7,69,49,77,58,67,151,43,235,64,149,56,217,121,155,36,158,145,65,60,232,117,39,136,109,203,196,95,205,153,212,97,183,185,162,163,16,183,116,97,118,41,172,120,150,94,90,129,180,216,104,247,130,35,244,197,66,27,215,19,79,166,38,61,196,139,246,131,144,183,66,46,234,106,129,239,238,162,212,243,131,205,117,178,55,87,66,243,79,97,227,231,32,201,43,109,101,208,126,195,134,90,124,67,19,180,62,153,19,16,71,124,224,189,16,31,120,57,160,206,231,58,132,2,133,83,72,97,245,19,167,3,146,63,98,58,225,209,113,122,214,90,94,4,104,66,6,8,234,58,112,232,135,49,125,193,242,21,121,143,79,43,254,35,159,192,193,131,249,2,58,224,57,18,144,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAnswersVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bfd398a4-25a6-4539-b13f-f4f7dd42b834"),
				Name = "GetAnswersVds",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,3,17,206,249,121,37,137,153,121,169,69,122,110,153,121,41,32,94,81,126,142,134,146,99,94,113,121,106,81,113,88,74,177,146,166,66,98,177,66,88,102,81,73,105,98,142,75,98,73,98,112,126,105,81,114,170,53,0,221,210,70,121,73,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("670f00f4-e762-4065-b92e-5de3d2ef762c"),
				Name = "GetItems",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "LocalizableParameterValuesList"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,61,11,194,64,12,134,231,222,175,136,157,20,138,171,67,213,197,82,17,29,4,209,69,28,162,70,57,185,222,73,46,21,171,248,223,189,250,133,147,224,20,120,73,158,39,201,9,25,180,80,225,161,7,115,79,60,112,214,210,70,180,179,237,25,121,31,106,134,130,203,16,11,157,101,76,213,10,208,195,196,109,208,232,11,174,13,77,145,177,32,33,94,160,41,201,79,180,151,84,233,29,52,95,212,30,216,210,152,22,92,85,116,10,46,103,182,163,255,117,1,218,205,244,163,15,185,234,122,97,109,247,9,184,245,33,12,247,251,169,138,106,227,135,221,248,146,70,239,235,126,239,220,30,146,228,236,138,78,39,119,92,160,212,217,7,152,64,60,192,99,109,143,91,193,117,83,55,197,36,37,219,231,235,210,59,138,44,50,255,69,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisplayItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3dbbefcc-a83a-4c50-89cb-0bd6aa8730b7"),
				Name = "DisplayItems",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,177,106,3,49,12,134,231,243,83,104,244,65,185,23,8,25,66,40,165,244,134,208,66,150,208,65,137,149,214,196,103,131,172,203,113,41,121,247,200,78,218,173,155,36,244,127,159,212,167,3,6,127,193,125,160,13,50,14,36,196,91,12,35,229,222,103,1,47,52,100,88,194,11,201,107,41,109,187,48,254,8,246,49,95,66,28,67,104,225,199,52,76,50,114,92,152,171,57,35,195,217,61,82,171,152,39,226,188,117,53,170,227,110,29,8,185,52,199,196,132,135,111,176,253,191,55,84,63,248,120,191,163,122,158,163,120,153,129,211,164,130,202,83,138,208,123,154,10,179,249,131,102,97,31,191,224,68,243,111,190,123,163,249,206,104,52,221,125,144,172,83,24,135,88,85,86,23,159,234,218,78,171,207,174,14,11,240,106,154,98,89,57,103,53,213,214,7,181,239,19,58,117,150,175,110,178,125,107,87,67,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDecisionalGatewayMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9e75b287-c4f5-4460-8a33-203130834594"),
				Name = "GetDecisionalGateway",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "ProcessSchemaDecisionalGateway"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,203,110,194,48,16,60,55,95,177,226,148,72,21,124,64,196,161,148,8,229,208,10,137,210,187,21,182,96,17,59,145,215,33,69,21,255,94,59,47,28,83,181,168,183,216,153,157,157,153,76,102,51,88,161,6,202,14,40,24,8,38,217,30,85,112,98,10,36,19,184,102,138,9,152,195,218,220,78,13,174,57,163,70,245,206,242,10,195,73,178,227,122,211,140,190,180,147,175,230,245,36,138,3,254,1,161,67,48,7,89,229,121,4,95,193,131,66,93,41,217,156,227,224,18,4,164,21,151,251,126,179,157,55,251,134,209,233,91,177,105,0,161,33,77,71,171,128,172,178,45,161,122,46,164,196,76,243,66,90,141,35,80,232,240,26,134,96,246,147,93,224,26,69,227,185,189,223,166,187,251,141,27,112,111,216,159,254,197,245,170,226,187,235,54,235,24,107,176,151,30,137,227,223,44,89,171,34,67,162,118,49,148,163,211,188,35,111,149,8,224,4,35,120,23,72,100,196,248,131,97,248,35,146,68,100,173,47,145,248,94,166,146,52,147,25,134,227,192,31,175,38,34,96,222,74,227,20,48,39,4,71,146,97,30,111,177,233,216,232,75,106,149,220,0,254,37,99,96,137,111,237,150,52,77,78,40,53,249,98,219,236,60,184,243,17,245,65,21,117,243,165,54,103,50,149,153,62,149,101,206,51,102,21,36,159,25,150,246,33,156,108,229,81,22,181,236,75,118,228,178,105,200,101,104,31,154,242,64,218,119,206,158,236,225,206,214,117,208,190,115,183,211,127,181,206,153,112,123,231,19,141,155,231,10,181,17,186,25,89,165,11,70,152,228,40,76,172,139,179,161,112,233,236,127,215,41,25,40,252,170,44,49,227,100,210,99,249,138,105,172,217,57,254,6,43,65,135,15,153,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetGeneralControlsBindingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("864cf6f6-926d-48a3-b3b3-7b9440c54458"),
				Name = "GetGeneralControlsBinding",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Dictionary<string, Terrasoft.UI.WebControls.WebControl>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,70,98,219,105,104,90,3,0,159,228,242,37,69,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDecisionModeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("68ddd90d-53cd-4a24-829e-02b444b74772"),
				Name = "GetDecisionMode",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				ResultValueTypeName = "GetewayDecisionSelectionMode"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,72,76,79,213,243,45,205,41,201,44,200,73,117,73,77,206,44,206,204,207,243,205,79,73,213,115,206,72,77,206,78,77,209,84,168,230,226,44,74,45,41,45,202,83,112,79,45,73,45,79,172,132,41,11,78,205,73,77,46,129,169,135,25,98,205,85,203,69,140,250,224,204,188,116,160,106,0,188,143,89,12,133,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetDecisionRequiredMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d40c6907-a27f-4ce9-8d77-d20ab9800a29"),
				Name = "SetDecisionRequired",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,73,77,206,44,206,204,207,243,205,79,73,85,176,85,112,79,45,113,65,18,209,208,180,230,202,76,83,208,64,85,5,86,150,90,158,88,9,83,26,156,154,147,154,92,2,149,215,11,206,204,75,207,73,213,84,168,230,226,12,72,76,79,213,243,44,134,169,11,74,45,44,205,44,74,77,113,77,201,44,209,11,78,45,9,75,204,41,77,213,40,41,42,77,5,218,67,72,177,107,94,98,82,78,106,138,70,90,98,78,49,72,125,173,66,42,144,65,132,45,48,141,80,123,106,1,36,204,46,178,247,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMoveEditedItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ac01c72e-a3ce-4510-bdbf-eac7df59638f"),
				Name = "MoveEditedItem",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				CreatedInPackageId = new Guid("d11c08ce-4dbf-4d8f-ae87-3e25d69a4b53"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("78c1b21b-7180-44c9-b8dc-600af4359f1c"),
				Name = "isMovedUp",
				CreatedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				ModifiedInSchemaUId = new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("d11c08ce-4dbf-4d8f-ae87-3e25d69a4b53")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,77,79,227,48,16,61,23,137,255,48,112,64,142,96,35,246,140,138,84,138,168,170,45,187,213,6,122,169,56,152,102,168,44,25,27,217,147,22,118,217,255,190,227,184,166,33,41,112,138,51,126,243,62,108,207,196,46,164,86,127,228,189,198,169,116,242,17,9,221,76,234,10,253,68,121,2,69,248,232,161,15,35,164,113,88,138,236,108,127,239,198,33,142,156,42,129,210,162,15,83,185,196,124,96,252,26,157,79,251,12,85,15,32,54,28,125,48,149,214,240,250,250,214,150,23,168,113,65,88,254,180,37,250,124,104,43,67,1,119,154,193,223,253,189,158,67,170,156,97,146,127,91,201,128,4,223,104,99,233,221,116,243,211,59,110,93,73,87,103,24,7,143,6,215,48,170,84,41,154,4,121,76,59,63,28,151,135,119,249,141,45,200,41,179,20,89,214,232,230,222,58,68,126,165,76,41,80,67,255,124,75,134,122,211,91,19,101,33,64,84,204,26,249,83,252,110,50,197,153,153,21,159,223,68,198,225,239,215,67,221,151,56,132,242,215,118,133,229,237,19,28,29,37,124,125,82,124,158,226,96,247,110,164,139,199,250,13,190,103,93,241,201,135,183,15,36,221,50,94,58,67,195,39,40,76,173,87,164,172,169,169,155,133,20,53,249,136,82,91,142,20,110,30,205,177,155,112,59,189,118,109,3,107,109,133,242,59,59,189,182,60,3,218,22,243,193,61,255,133,152,128,218,227,231,126,142,187,126,118,139,54,27,90,102,191,242,115,129,218,174,227,177,223,122,116,67,107,12,63,194,176,83,160,247,252,189,148,36,231,92,38,124,166,31,248,146,248,61,247,204,148,163,74,234,128,40,108,229,22,8,171,78,165,30,210,205,4,206,202,56,169,29,84,30,44,213,47,171,249,104,79,26,73,223,215,219,193,2,105,107,222,194,16,137,248,226,219,227,211,81,47,144,134,90,161,161,1,39,95,225,111,187,22,105,86,254,3,146,156,147,67,137,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QuestionUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3108d81-615c-4f50-8255-5d1640a0266c"));
		}

		#endregion

	}

	#endregion

}

