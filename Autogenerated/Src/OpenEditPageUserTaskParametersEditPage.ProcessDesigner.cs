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

	#region Class: OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema

	/// <exclude/>
	public class OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _openEditPageControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout OpenEditPageControlLayout {
			get {
				return _openEditPageControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _openEditPageTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel OpenEditPageTabPanel {
			get {
				return _openEditPageTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _generalParametersTab;
		public Terrasoft.UI.WebControls.Controls.Tab GeneralParametersTab {
			get {
				return _generalParametersTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return _controlLayout5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _entityPageControlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout EntityPageControlLayout1 {
			get {
				return _entityPageControlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _pageEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit PageEdit {
			get {
				return _pageEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _objectEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return _objectEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _newRecordEdit;
		public Terrasoft.UI.WebControls.Controls.RadioButton NewRecordEdit {
			get {
				return _newRecordEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _setDefColumnValuesControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout SetDefColumnValuesControlLayout {
			get {
				return _setDefColumnValuesControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _setDefaultColumnValuesButton;
		public Terrasoft.UI.WebControls.Controls.Button SetDefaultColumnValuesButton {
			get {
				return _setDefaultColumnValuesButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _existingRecordEdit;
		public Terrasoft.UI.WebControls.Controls.RadioButton ExistingRecordEdit {
			get {
				return _existingRecordEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _editExistingEntityControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout EditExistingEntityControlLayout {
			get {
				return _editExistingEntityControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _recordIdEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit RecordIdEdit {
			get {
				return _recordIdEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isMatchConditionsEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsMatchConditionsEdit {
			get {
				return _isMatchConditionsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _filterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return _filterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _generateDecisionsFromColumnEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox GenerateDecisionsFromColumnEdit {
			get {
				return _generateDecisionsFromColumnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _createResultListByColumnControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CreateResultListByColumnControlLayout {
			get {
				return _createResultListByColumnControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _decisionalColumnEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit DecisionalColumnEdit {
			get {
				return _decisionalColumnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _exploreButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ExploreButton {
			get {
				return _exploreButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _activityParametersTab;
		public Terrasoft.UI.WebControls.Controls.Tab ActivityParametersTab {
			get {
				return _activityParametersTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _entityDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return _entityDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateUserTaskTitleEdit() {
			UserTaskTitleEdit.Image = new ControlImage {};
			UserTaskTitleEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateRecommendationEdit() {
			RecommendationEdit.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			RecommendationEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateStartInEdit() {
			StartInEdit.Image = new ControlImage {};
			StartInEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateStartInPeriodEdit() {
			StartInPeriodEdit.Image = new ControlImage {};
			StartInPeriodEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout8() {
			ActivityControlLayout8.Image = new ControlImage {};
			ActivityControlLayout8.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateDurationEdit() {
			DurationEdit.Image = new ControlImage {};
			DurationEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateDurationPeriodEdit() {
			DurationPeriodEdit.Image = new ControlImage {};
			DurationPeriodEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout9() {
			ActivityControlLayout9.Image = new ControlImage {};
			ActivityControlLayout9.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityCategoryEdit() {
			ActivityCategoryEdit.Image = new ControlImage {};
			ActivityCategoryEdit.Enabled = false;
			ActivityCategoryEdit.Hidden = true;
			ActivityCategoryEdit.Required = false;
			ActivityCategoryEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout3() {
			ActivityControlLayout3.Image = new ControlImage {};
			ActivityControlLayout3.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateOwnerEdit() {
			OwnerEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			OwnerEdit.Image = new ControlImage {};
			OwnerEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateRemindBeforeEdit() {
			RemindBeforeEdit.Image = new ControlImage {};
			RemindBeforeEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateRemindBeforePeriodEdit() {
			RemindBeforePeriodEdit.Image = new ControlImage {};
			RemindBeforePeriodEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout10() {
			ActivityControlLayout10.Image = new ControlImage {};
			ActivityControlLayout10.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateExecutionContextEdit() {
			ExecutionContextEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			ExecutionContextEdit.Image = new ControlImage {};
			ExecutionContextEdit.Hidden = false;
			ExecutionContextEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout4() {
			ActivityControlLayout4.Image = new ControlImage {};
			ActivityControlLayout4.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout2() {
			ActivityControlLayout2.Image = new ControlImage {};
			ActivityControlLayout2.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout1() {
			BaseProcessUserTaskPageControlLayout1.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout1.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout2() {
			BaseProcessUserTaskPageControlLayout2.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout2.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout11() {
			ActivityControlLayout11.Image = new ControlImage {};
			ActivityControlLayout11.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateLeadEdit() {
			LeadEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			LeadEdit.Image = new ControlImage {};
			LeadEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateAccountEdit() {
			AccountEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			AccountEdit.Image = new ControlImage {};
			AccountEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateContactEdit() {
			ContactEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			ContactEdit.Image = new ControlImage {};
			ContactEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateOpportunityEdit() {
			OpportunityEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			OpportunityEdit.Image = new ControlImage {};
			OpportunityEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout6() {
			ActivityControlLayout6.Image = new ControlImage {};
			ActivityControlLayout6.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateInvoiceEdit() {
			InvoiceEdit.Image = new ControlImage {};
			InvoiceEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateDocumentEdit() {
			DocumentEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			DocumentEdit.Image = new ControlImage {};
			DocumentEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout7() {
			ActivityControlLayout7.Image = new ControlImage {};
			ActivityControlLayout7.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout5() {
			ActivityControlLayout5.Image = new ControlImage {};
			ActivityControlLayout5.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateActivityControlLayout1() {
			ActivityControlLayout1.Padding = "5 5 5 5";
			ActivityControlLayout1.Image = new ControlImage {};
			ActivityControlLayout1.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			RealUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			Name = "OpenEditPageUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
			ParentSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UseProfile = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema();
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
			UpdateRecommendationEdit();
			UpdateUserTaskTitleEdit();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.InsertItem(0, CreateOpenEditPageControlLayout());
			OpenEditPageControlLayout.InsertItem(0, CreateOpenEditPageTabPanel());
			OpenEditPageTabPanel.InsertItem(0, CreateGeneralParametersTab());
			GeneralParametersTab.InsertItem(0, CreateControlLayout5());
			ControlLayout5.MoveItem(0, UserTaskTitleEdit);
			ControlLayout5.MoveItem(1, RecommendationEdit);
			ControlLayout5.InsertItem(2, CreateEntityPageControlLayout1());
			EntityPageControlLayout1.InsertItem(0, CreatePageEdit());
			EntityPageControlLayout1.InsertItem(1, CreateObjectEdit());
			ControlLayout5.InsertItem(3, CreateNewRecordEdit());
			ControlLayout5.InsertItem(4, CreateSetDefColumnValuesControlLayout());
			SetDefColumnValuesControlLayout.InsertItem(0, CreateSetDefaultColumnValuesButton());
			ControlLayout5.InsertItem(5, CreateExistingRecordEdit());
			ControlLayout5.InsertItem(6, CreateEditExistingEntityControlLayout());
			EditExistingEntityControlLayout.InsertItem(0, CreateRecordIdEdit());
			ControlLayout5.InsertItem(7, CreateIsMatchConditionsEdit());
			ControlLayout5.InsertItem(8, CreateFilterEdit());
			ControlLayout5.InsertItem(9, CreateGenerateDecisionsFromColumnEdit());
			ControlLayout5.InsertItem(10, CreateCreateResultListByColumnControlLayout());
			CreateResultListByColumnControlLayout.InsertItem(0, CreateDecisionalColumnEdit());
			DecisionalColumnEdit.InsertItem(0, CreateExploreButton());
			OpenEditPageTabPanel.InsertItem(1, CreateActivityParametersTab());
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
			Controls.AddAt(3, CreateEntityDataSource());
			UpdateEntityDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateOpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema() {
			var schema = new OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreatePageEdit() {
			_pageEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_pageEdit.UId = new Guid("9cdb2c92-ea83-42c1-94a2-7eb9fbdee0d6");
			_pageEdit.Name = "PageEdit";
			_pageEdit.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_pageEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_pageEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_pageEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_pageEdit.Tag = "";
			_pageEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_pageEdit.Image = new ControlImage {};
			_pageEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_pageEdit.Required = true;
			_pageEdit.LookupSchemaUId = new Guid("46ffda25-af49-4a3d-aa4d-10b43e7154cf");
			return _pageEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateObjectEdit() {
			_objectEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_objectEdit.UId = new Guid("9c73a8dd-f314-452f-8a37-3b5d86fc0383");
			_objectEdit.Name = "ObjectEdit";
			_objectEdit.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_objectEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_objectEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_objectEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_objectEdit.Tag = "";
			_objectEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectEdit.Image = new ControlImage {};
			_objectEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectEdit.Required = true;
			_objectEdit.LookupSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111");
			return _objectEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateEntityPageControlLayout1() {
			_entityPageControlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_entityPageControlLayout1.UId = new Guid("6dded926-a043-46a9-a8a4-a7ecd53bded3");
			_entityPageControlLayout1.Name = "EntityPageControlLayout1";
			_entityPageControlLayout1.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_entityPageControlLayout1.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_entityPageControlLayout1.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_entityPageControlLayout1.Tag = "";
			_entityPageControlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_entityPageControlLayout1.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_entityPageControlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_entityPageControlLayout1.FitHeightByContent = true;
			_entityPageControlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityPageControlLayout1.StartNewAlignGroup = false;
			_entityPageControlLayout1.Image = new ControlImage {};
			_entityPageControlLayout1.Edges = "";
			return _entityPageControlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateNewRecordEdit() {
			_newRecordEdit = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_newRecordEdit.UId = new Guid("9b490cd7-8bf2-4634-aecb-a12de9296bcb");
			_newRecordEdit.Name = "NewRecordEdit";
			_newRecordEdit.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_newRecordEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_newRecordEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_newRecordEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_newRecordEdit.Tag = "";
			_newRecordEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_newRecordEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_newRecordEdit.AlignedByCaption = false;
			_newRecordEdit.GroupName = "RecordEditMode";
			return _newRecordEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSetDefaultColumnValuesButton() {
			_setDefaultColumnValuesButton = new Terrasoft.UI.WebControls.Controls.Button();
			_setDefaultColumnValuesButton.UId = new Guid("e23120ff-3088-4caf-b22f-3343d97348ed");
			_setDefaultColumnValuesButton.Name = "SetDefaultColumnValuesButton";
			_setDefaultColumnValuesButton.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_setDefaultColumnValuesButton.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_setDefaultColumnValuesButton.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_setDefaultColumnValuesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_setDefaultColumnValuesButton.Tag = "";
			_setDefaultColumnValuesButton.Image = new ControlImage {};
			_setDefaultColumnValuesButton.Enabled = false;
			return _setDefaultColumnValuesButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateSetDefColumnValuesControlLayout() {
			_setDefColumnValuesControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_setDefColumnValuesControlLayout.UId = new Guid("e8d84815-3cea-40b8-aad8-24e00a8b751b");
			_setDefColumnValuesControlLayout.Name = "SetDefColumnValuesControlLayout";
			_setDefColumnValuesControlLayout.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_setDefColumnValuesControlLayout.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_setDefColumnValuesControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_setDefColumnValuesControlLayout.Tag = "";
			_setDefColumnValuesControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_setDefColumnValuesControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_setDefColumnValuesControlLayout.FitHeightByContent = true;
			_setDefColumnValuesControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_setDefColumnValuesControlLayout.Padding = "0 0 0 20";
			_setDefColumnValuesControlLayout.StartNewAlignGroup = false;
			_setDefColumnValuesControlLayout.Image = new ControlImage {};
			_setDefColumnValuesControlLayout.Edges = "";
			return _setDefColumnValuesControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateExistingRecordEdit() {
			_existingRecordEdit = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_existingRecordEdit.UId = new Guid("d9fea117-db72-4bd7-afdb-f34f9f271604");
			_existingRecordEdit.Name = "ExistingRecordEdit";
			_existingRecordEdit.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_existingRecordEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_existingRecordEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_existingRecordEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_existingRecordEdit.Tag = "";
			_existingRecordEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_existingRecordEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_existingRecordEdit.AlignedByCaption = false;
			_existingRecordEdit.GroupName = "RecordEditMode";
			return _existingRecordEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateRecordIdEdit() {
			_recordIdEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_recordIdEdit.UId = new Guid("1a3130d4-e8b5-4d5b-9ab6-42fb6831bbbd");
			_recordIdEdit.Name = "RecordIdEdit";
			_recordIdEdit.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_recordIdEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_recordIdEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_recordIdEdit.Tag = "";
			_recordIdEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_recordIdEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_recordIdEdit.Image = new ControlImage {};
			_recordIdEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_recordIdEdit.Margins = "0 0 0 0";
			_recordIdEdit.Enabled = false;
			return _recordIdEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateEditExistingEntityControlLayout() {
			_editExistingEntityControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_editExistingEntityControlLayout.UId = new Guid("c74b0a85-28ec-43fd-a9b5-54e46c7e7457");
			_editExistingEntityControlLayout.Name = "EditExistingEntityControlLayout";
			_editExistingEntityControlLayout.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_editExistingEntityControlLayout.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_editExistingEntityControlLayout.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_editExistingEntityControlLayout.Tag = "";
			_editExistingEntityControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_editExistingEntityControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_editExistingEntityControlLayout.FitHeightByContent = true;
			_editExistingEntityControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_editExistingEntityControlLayout.Padding = "0 0 0 20";
			_editExistingEntityControlLayout.StartNewAlignGroup = false;
			_editExistingEntityControlLayout.Image = new ControlImage {};
			_editExistingEntityControlLayout.Edges = "";
			return _editExistingEntityControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsMatchConditionsEdit() {
			_isMatchConditionsEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isMatchConditionsEdit.UId = new Guid("2d4e39cc-a16f-4199-916a-08d0e5167c00");
			_isMatchConditionsEdit.Name = "IsMatchConditionsEdit";
			_isMatchConditionsEdit.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_isMatchConditionsEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_isMatchConditionsEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_isMatchConditionsEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_isMatchConditionsEdit.Tag = "";
			_isMatchConditionsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isMatchConditionsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isMatchConditionsEdit.AlignedByCaption = false;
			_isMatchConditionsEdit.Margins = "0 0 5";
			return _isMatchConditionsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("9fca2b46-e0c0-433c-a198-e910bf27fc16");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_filterEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "EntityDataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateGenerateDecisionsFromColumnEdit() {
			_generateDecisionsFromColumnEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_generateDecisionsFromColumnEdit.UId = new Guid("91fcb28a-37c5-4ee9-ab0d-0bbb421ecf4a");
			_generateDecisionsFromColumnEdit.Name = "GenerateDecisionsFromColumnEdit";
			_generateDecisionsFromColumnEdit.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_generateDecisionsFromColumnEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_generateDecisionsFromColumnEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_generateDecisionsFromColumnEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_generateDecisionsFromColumnEdit.Tag = "";
			_generateDecisionsFromColumnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_generateDecisionsFromColumnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_generateDecisionsFromColumnEdit.AlignedByCaption = false;
			_generateDecisionsFromColumnEdit.Margins = "0 0";
			return _generateDecisionsFromColumnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateExploreButton() {
			_exploreButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_exploreButton.UId = new Guid("0e962c24-9972-4f0b-872e-4d91b92dd516");
			_exploreButton.Name = "ExploreButton";
			_exploreButton.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_exploreButton.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_exploreButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_exploreButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_exploreButton.Tag = "";
			_exploreButton.Image = new ControlImage {};
			return _exploreButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateDecisionalColumnEdit() {
			_decisionalColumnEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_decisionalColumnEdit.UId = new Guid("45bba414-6d61-485b-8615-3ea55362f997");
			_decisionalColumnEdit.Name = "DecisionalColumnEdit";
			_decisionalColumnEdit.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_decisionalColumnEdit.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_decisionalColumnEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_decisionalColumnEdit.Tag = "";
			_decisionalColumnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_decisionalColumnEdit.Image = new ControlImage {};
			_decisionalColumnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_decisionalColumnEdit.AlignedByCaption = false;
			_decisionalColumnEdit.Margins = "0 0 0 0";
			return _decisionalColumnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCreateResultListByColumnControlLayout() {
			_createResultListByColumnControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_createResultListByColumnControlLayout.UId = new Guid("ac3fcd99-3d0b-4fcd-89df-6d6de170a08a");
			_createResultListByColumnControlLayout.Name = "CreateResultListByColumnControlLayout";
			_createResultListByColumnControlLayout.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_createResultListByColumnControlLayout.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_createResultListByColumnControlLayout.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_createResultListByColumnControlLayout.Tag = "";
			_createResultListByColumnControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(25);
			_createResultListByColumnControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_createResultListByColumnControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_createResultListByColumnControlLayout.Padding = "0 0 0 20";
			_createResultListByColumnControlLayout.StartNewAlignGroup = false;
			_createResultListByColumnControlLayout.Image = new ControlImage {};
			_createResultListByColumnControlLayout.Edges = "";
			return _createResultListByColumnControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout5() {
			_controlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout5.UId = new Guid("0f4aba9a-54fb-44d3-b91c-2c59c6f1e355");
			_controlLayout5.Name = "ControlLayout5";
			_controlLayout5.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_controlLayout5.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_controlLayout5.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout5.Tag = "";
			_controlLayout5.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout5.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.Padding = "5 5 5 5";
			_controlLayout5.StartNewAlignGroup = false;
			_controlLayout5.Image = new ControlImage {};
			_controlLayout5.Edges = "";
			return _controlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateGeneralParametersTab() {
			_generalParametersTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_generalParametersTab.UId = new Guid("e759976f-8d18-4ab6-9704-56bdeb32b502");
			_generalParametersTab.Name = "GeneralParametersTab";
			_generalParametersTab.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_generalParametersTab.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_generalParametersTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_generalParametersTab.Tag = "";
			_generalParametersTab.Image = new ControlImage {};
			return _generalParametersTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateActivityParametersTab() {
			_activityParametersTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_activityParametersTab.UId = new Guid("c905d2b2-1468-4d5d-9978-77151e0f438f");
			_activityParametersTab.Name = "ActivityParametersTab";
			_activityParametersTab.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_activityParametersTab.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_activityParametersTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_activityParametersTab.Tag = "";
			_activityParametersTab.Image = new ControlImage {};
			return _activityParametersTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateOpenEditPageTabPanel() {
			_openEditPageTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_openEditPageTabPanel.UId = new Guid("9f028cda-af78-48d6-b5dd-5b7ea8b6bdc0");
			_openEditPageTabPanel.Name = "OpenEditPageTabPanel";
			_openEditPageTabPanel.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_openEditPageTabPanel.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_openEditPageTabPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_openEditPageTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			_openEditPageTabPanel.Tag = "";
			_openEditPageTabPanel.ActiveTabIndex = 0;
			_openEditPageTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_openEditPageTabPanel.StartNewAlignGroup = false;
			_openEditPageTabPanel.Collapsible = false;
			_openEditPageTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _openEditPageTabPanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateOpenEditPageControlLayout() {
			_openEditPageControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_openEditPageControlLayout.UId = new Guid("bb4c580e-fb6e-4e87-be17-9e0eb188203a");
			_openEditPageControlLayout.Name = "OpenEditPageControlLayout";
			_openEditPageControlLayout.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_openEditPageControlLayout.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_openEditPageControlLayout.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_openEditPageControlLayout.Tag = "";
			_openEditPageControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_openEditPageControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_openEditPageControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_openEditPageControlLayout.StartNewAlignGroup = false;
			_openEditPageControlLayout.Image = new ControlImage {};
			_openEditPageControlLayout.Edges = "";
			return _openEditPageControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("dc892bca-bdca-415d-955d-2b5d9e103358");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_entityDataSource.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("1a5540d1-a874-4521-8dbb-c436c3af23f5");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			return _entityDataSource;
		}

		protected virtual void UpdateEntityDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl
	{

		#region Class: OpenSpecifyColumnValuesPageFlowElement

		/// <exclude/>
		public class OpenSpecifyColumnValuesPageFlowElement : OpenPageUserTask
		{

			public OpenSpecifyColumnValuesPageFlowElement(UserConnection userConnection, OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenSpecifyColumnValuesPage";
				IsLogging = false;
				SchemaElementUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ChangeSchemaEntityUserMessageFlowElement

		/// <exclude/>
		public class ChangeSchemaEntityUserMessageFlowElement : QuestionUserTask
		{

			public ChangeSchemaEntityUserMessageFlowElement(UserConnection userConnection, OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeSchemaEntityUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowWarningChangeEntitySchemaOnSaveMessageUserTaskFlowElement

		/// <exclude/>
		public class ShowWarningChangeEntitySchemaOnSaveMessageUserTaskFlowElement : QuestionUserTask
		{

			public ShowWarningChangeEntitySchemaOnSaveMessageUserTaskFlowElement(UserConnection userConnection, OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowWarningChangeEntitySchemaOnSaveMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			SchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
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

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual bool IsColumnExplorerCreated {
			get;
			set;
		}

		public virtual Object ColumnExplorer {
			get;
			set;
		}

		public virtual string DecisionalColumnMetaPath {
			get;
			set;
		}

		public virtual string ColumnValuesContextKey {
			get;
			set;
		}

		public virtual Object EntitiesForPages {
			get;
			set;
		}

		public virtual Guid PageSchemaId {
			get;
			set;
		}

		public virtual bool FilterEditSchemaExplorerCreated {
			get;
			set;
		}

		public virtual Guid FilterUId {
			get;
			set;
		}

		public virtual Object FilterEditSchemaExplorer {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual bool IsEntitySchemaChanged {
			get;
			set;
		}

		public virtual bool IsDataValid_NewRow {
			get;
			set;
		}

		public virtual bool IsDataValid_ExistingRow {
			get;
			set;
		}

		public virtual bool IsFilterParamsValuesCorrect {
			get;
			set;
		}

		public virtual string InsertedColumnValueKey {
			get;
			set;
		}

		public virtual bool IsChangingEntitySchema {
			get;
			set;
		}

		public virtual bool IsChangingPageSchema {
			get;
			set;
		}

		public virtual Object EditCardSchemaUIdPageTypeUIdTies {
			get;
			set;
		}

		private ProcessFlowElement _openEditPageTabPanelTabChangeEventSubProcess;
		public ProcessFlowElement OpenEditPageTabPanelTabChangeEventSubProcess {
			get {
				return _openEditPageTabPanelTabChangeEventSubProcess ?? (_openEditPageTabPanelTabChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenEditPageTabPanelTabChangeEventSubProcess",
					SchemaElementUId = new Guid("c089bc1e-e554-4485-8bb1-93d51f3fdc58"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _openEditPageTabPanelTabChangeStartMessage;
		public ProcessFlowElement OpenEditPageTabPanelTabChangeStartMessage {
			get {
				return _openEditPageTabPanelTabChangeStartMessage ?? (_openEditPageTabPanelTabChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpenEditPageTabPanelTabChangeStartMessage",
					SchemaElementUId = new Guid("791ec8ec-0b59-4d92-80f4-667a98c282ac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _openEditPageTabPanelTabChangeScriptTask;
		public ProcessScriptTask OpenEditPageTabPanelTabChangeScriptTask {
			get {
				return _openEditPageTabPanelTabChangeScriptTask ?? (_openEditPageTabPanelTabChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpenEditPageTabPanelTabChangeScriptTask",
					SchemaElementUId = new Guid("ade33697-e56a-4be9-881d-9a2bed7bd6f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpenEditPageTabPanelTabChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess20;
		public ProcessFlowElement EventSubProcess20 {
			get {
				return _eventSubProcess20 ?? (_eventSubProcess20 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess20",
					SchemaElementUId = new Guid("7fe4fdb3-1770-425d-af95-ac2f30210371"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _objectEditChange_StartMessage;
		public ProcessFlowElement ObjectEditChange_StartMessage {
			get {
				return _objectEditChange_StartMessage ?? (_objectEditChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ObjectEditChange_StartMessage",
					SchemaElementUId = new Guid("a5b8cd7d-b918-4876-b85b-3a5fe128b6fd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _objectEditChange_ScriptTask;
		public ProcessScriptTask ObjectEditChange_ScriptTask {
			get {
				return _objectEditChange_ScriptTask ?? (_objectEditChange_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ObjectEditChange_ScriptTask",
					SchemaElementUId = new Guid("dea9d59c-8b21-4eae-beed-9d7317e85bc1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ObjectEditChange_ScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("df1194a5-5eec-4f79-a100-0d5b57f00110"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessThrowMessageEvent _objectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent {
			get {
				return _objectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent ?? (_objectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("349d7c57-7730-4ab0-9b68-bbe7b76122f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "NOChangeEntitySchemaOnSave",
				});
			}
		}

		private ProcessThrowMessageEvent _objectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent {
			get {
				return _objectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent ?? (_objectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("f909db95-b193-4dc1-848a-c710334f3fbf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeSchemaEntityYesMessage",
				});
			}
		}

		private ProcessScriptTask _isChangingEntitySchemaScriptTask;
		public ProcessScriptTask IsChangingEntitySchemaScriptTask {
			get {
				return _isChangingEntitySchemaScriptTask ?? (_isChangingEntitySchemaScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IsChangingEntitySchemaScriptTask",
					SchemaElementUId = new Guid("6a2c2afd-7462-4844-98cb-c819c8a343b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IsChangingEntitySchemaScriptTaskExecute,
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
					SchemaElementUId = new Guid("fe65d0c2-077b-4f05-ae74-67028fc73064"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _newRecordEditCheckStartMessage;
		public ProcessFlowElement NewRecordEditCheckStartMessage {
			get {
				return _newRecordEditCheckStartMessage ?? (_newRecordEditCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "NewRecordEditCheckStartMessage",
					SchemaElementUId = new Guid("12cc4c0e-52d4-4719-8061-10424e3cbc18"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _newRecordEditCheckScriptTask;
		public ProcessScriptTask NewRecordEditCheckScriptTask {
			get {
				return _newRecordEditCheckScriptTask ?? (_newRecordEditCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NewRecordEditCheckScriptTask",
					SchemaElementUId = new Guid("a57dfa0c-f12e-4ec9-a3ec-c5d4bc54bfb1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NewRecordEditCheckScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess21;
		public ProcessFlowElement EventSubProcess21 {
			get {
				return _eventSubProcess21 ?? (_eventSubProcess21 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess21",
					SchemaElementUId = new Guid("30df178a-2ad0-4aa0-944b-42a17dbc70c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _existingRecordEditCheck_StartMessage;
		public ProcessFlowElement ExistingRecordEditCheck_StartMessage {
			get {
				return _existingRecordEditCheck_StartMessage ?? (_existingRecordEditCheck_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ExistingRecordEditCheck_StartMessage",
					SchemaElementUId = new Guid("d4dbdde1-4767-40e9-a634-e19b1c5d6f3c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _existingRecordEditCheckScriptTask;
		public ProcessScriptTask ExistingRecordEditCheckScriptTask {
			get {
				return _existingRecordEditCheckScriptTask ?? (_existingRecordEditCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ExistingRecordEditCheckScriptTask",
					SchemaElementUId = new Guid("e9afeaff-53e5-4041-a379-91591c78c7ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ExistingRecordEditCheckScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _setDefaultColumnValuesButtonClickEventSubProcess;
		public ProcessFlowElement SetDefaultColumnValuesButtonClickEventSubProcess {
			get {
				return _setDefaultColumnValuesButtonClickEventSubProcess ?? (_setDefaultColumnValuesButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SetDefaultColumnValuesButtonClickEventSubProcess",
					SchemaElementUId = new Guid("7808c037-d4df-4301-a794-f523196669bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _setDefaultColumnValuesButtonClickStartMessage;
		public ProcessFlowElement SetDefaultColumnValuesButtonClickStartMessage {
			get {
				return _setDefaultColumnValuesButtonClickStartMessage ?? (_setDefaultColumnValuesButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SetDefaultColumnValuesButtonClickStartMessage",
					SchemaElementUId = new Guid("2f2f2b4c-2c72-4b68-b938-993870cfa22e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setDefaultColumnValuesButtonClickScriptTask;
		public ProcessScriptTask SetDefaultColumnValuesButtonClickScriptTask {
			get {
				return _setDefaultColumnValuesButtonClickScriptTask ?? (_setDefaultColumnValuesButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetDefaultColumnValuesButtonClickScriptTask",
					SchemaElementUId = new Guid("05acb539-edf9-4e24-bdb2-8add59496bfa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetDefaultColumnValuesButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenSpecifyColumnValuesPageFlowElement _openSpecifyColumnValuesPage;
		public OpenSpecifyColumnValuesPageFlowElement OpenSpecifyColumnValuesPage {
			get {
				return _openSpecifyColumnValuesPage ?? (_openSpecifyColumnValuesPage = new OpenSpecifyColumnValuesPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("b4c1f6c7-89b6-4549-b3a9-033b8d26e2ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _exploreButtonClickStartMessage;
		public ProcessFlowElement ExploreButtonClickStartMessage {
			get {
				return _exploreButtonClickStartMessage ?? (_exploreButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ExploreButtonClickStartMessage",
					SchemaElementUId = new Guid("52dfdc54-c593-4598-85d2-4723e1e4d96a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _exploreButtonClickScriptTask;
		public ProcessScriptTask ExploreButtonClickScriptTask {
			get {
				return _exploreButtonClickScriptTask ?? (_exploreButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ExploreButtonClickScriptTask",
					SchemaElementUId = new Guid("5b1ec650-1ad5-4f2a-94bd-9abc6c51c541"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ExploreButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("45b4a479-9327-47db-bd25-4bdddaf279e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _generateDecisionsFromColumnEditCheckStartMessage;
		public ProcessFlowElement GenerateDecisionsFromColumnEditCheckStartMessage {
			get {
				return _generateDecisionsFromColumnEditCheckStartMessage ?? (_generateDecisionsFromColumnEditCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "GenerateDecisionsFromColumnEditCheckStartMessage",
					SchemaElementUId = new Guid("8074a953-d01e-4a59-921f-5ccdcd5b6fd3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _generateDecisionsFromColumnEditCheckScriptTask;
		public ProcessScriptTask GenerateDecisionsFromColumnEditCheckScriptTask {
			get {
				return _generateDecisionsFromColumnEditCheckScriptTask ?? (_generateDecisionsFromColumnEditCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GenerateDecisionsFromColumnEditCheckScriptTask",
					SchemaElementUId = new Guid("c3cb2e09-3b3b-4a25-92c5-8fed53875426"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = GenerateDecisionsFromColumnEditCheckScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _openEditPageEventSubProcess8;
		public ProcessFlowElement OpenEditPageEventSubProcess8 {
			get {
				return _openEditPageEventSubProcess8 ?? (_openEditPageEventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenEditPageEventSubProcess8",
					SchemaElementUId = new Guid("f374c9de-b946-42d5-aeb1-5132aec81d06"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _isMatchConditionsEditCheckStartMessage;
		public ProcessFlowElement IsMatchConditionsEditCheckStartMessage {
			get {
				return _isMatchConditionsEditCheckStartMessage ?? (_isMatchConditionsEditCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "IsMatchConditionsEditCheckStartMessage",
					SchemaElementUId = new Guid("2fc49664-cb20-4721-8800-655dddd2796d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _isMatchConditionsEditCheckScriptTask;
		public ProcessScriptTask IsMatchConditionsEditCheckScriptTask {
			get {
				return _isMatchConditionsEditCheckScriptTask ?? (_isMatchConditionsEditCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IsMatchConditionsEditCheckScriptTask",
					SchemaElementUId = new Guid("b971fcab-e2b3-42f6-bd80-325e113640c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IsMatchConditionsEditCheckScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _openEditPageEventSubProcess7;
		public ProcessFlowElement OpenEditPageEventSubProcess7 {
			get {
				return _openEditPageEventSubProcess7 ?? (_openEditPageEventSubProcess7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenEditPageEventSubProcess7",
					SchemaElementUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _objectEditChangeStartMessage;
		public ProcessFlowElement ObjectEditChangeStartMessage {
			get {
				return _objectEditChangeStartMessage ?? (_objectEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ObjectEditChangeStartMessage",
					SchemaElementUId = new Guid("5b233931-a7a0-433d-a9f2-f50d61cc6a40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
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

		private ProcessScriptTask _scriptTaskPrepareChangeSchemaEntityQuestion;
		public ProcessScriptTask ScriptTaskPrepareChangeSchemaEntityQuestion {
			get {
				return _scriptTaskPrepareChangeSchemaEntityQuestion ?? (_scriptTaskPrepareChangeSchemaEntityQuestion = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPrepareChangeSchemaEntityQuestion",
					SchemaElementUId = new Guid("5b3ff4a1-f642-4c88-a3da-1cb1d8f83d39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPrepareChangeSchemaEntityQuestionExecute,
				});
			}
		}

		private ChangeSchemaEntityUserMessageFlowElement _changeSchemaEntityUserMessage;
		public ChangeSchemaEntityUserMessageFlowElement ChangeSchemaEntityUserMessage {
			get {
				return _changeSchemaEntityUserMessage ?? (_changeSchemaEntityUserMessage = new ChangeSchemaEntityUserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3 {
			get {
				return _intermediateThrowMessageEvent3 ?? (_intermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("8574bc6f-d9d4-40c9-af8e-e74c0e88e3ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeSchemaEntityYesMessage",
				});
			}
		}

		private ProcessScriptTask _isChangingPageSchemaScriptTask;
		public ProcessScriptTask IsChangingPageSchemaScriptTask {
			get {
				return _isChangingPageSchemaScriptTask ?? (_isChangingPageSchemaScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IsChangingPageSchemaScriptTask",
					SchemaElementUId = new Guid("2666200a-061b-449d-bb9c-c02e0bbb35fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IsChangingPageSchemaScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _openEditPageEventSubProcess5;
		public ProcessFlowElement OpenEditPageEventSubProcess5 {
			get {
				return _openEditPageEventSubProcess5 ?? (_openEditPageEventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenEditPageEventSubProcess5",
					SchemaElementUId = new Guid("c5eb5076-6548-41da-85b5-d6c53e888e3e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeSchemaEntityYesMessageScriptTask;
		public ProcessScriptTask ChangeSchemaEntityYesMessageScriptTask {
			get {
				return _changeSchemaEntityYesMessageScriptTask ?? (_changeSchemaEntityYesMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeSchemaEntityYesMessageScriptTask",
					SchemaElementUId = new Guid("aa02346a-cf73-4be7-9d90-6b4456849260"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeSchemaEntityYesMessageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _yESChangeEntitySchemaOnSave_StartMessage;
		public ProcessFlowElement YESChangeEntitySchemaOnSave_StartMessage {
			get {
				return _yESChangeEntitySchemaOnSave_StartMessage ?? (_yESChangeEntitySchemaOnSave_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "YESChangeEntitySchemaOnSave_StartMessage",
					SchemaElementUId = new Guid("cd126551-0fb2-4104-9adb-fc52eda2e6fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _openEditPageEventSubProcess6;
		public ProcessFlowElement OpenEditPageEventSubProcess6 {
			get {
				return _openEditPageEventSubProcess6 ?? (_openEditPageEventSubProcess6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenEditPageEventSubProcess6",
					SchemaElementUId = new Guid("2fb7ee02-7b50-40cf-bf15-3c0a09bf3ccb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeSchemaEntityNoMessageStartMessage;
		public ProcessFlowElement ChangeSchemaEntityNoMessageStartMessage {
			get {
				return _changeSchemaEntityNoMessageStartMessage ?? (_changeSchemaEntityNoMessageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityNoMessageStartMessage",
					SchemaElementUId = new Guid("6a0680a3-cb1d-4bac-aabc-17ceadd65837"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeSchemaEntityNoMessageScriptTask;
		public ProcessScriptTask ChangeSchemaEntityNoMessageScriptTask {
			get {
				return _changeSchemaEntityNoMessageScriptTask ?? (_changeSchemaEntityNoMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeSchemaEntityNoMessageScriptTask",
					SchemaElementUId = new Guid("6e5f5bd8-e2ba-4f83-8523-ede64aa8c5ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeSchemaEntityNoMessageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _openEditPageEventSubProcess4;
		public ProcessFlowElement OpenEditPageEventSubProcess4 {
			get {
				return _openEditPageEventSubProcess4 ?? (_openEditPageEventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenEditPageEventSubProcess4",
					SchemaElementUId = new Guid("ca0f37c4-c64d-47ab-95a2-9b3207e8e325"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("cbca2f3b-34ce-490a-b4e7-a485d6cff867"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessThrowMessageEvent _okButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent {
			get {
				return _okButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent ?? (_okButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("c9ad13fa-7f93-465a-ad9b-97adf2cca287"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "YESChangeEntitySchemaOnSave",
				});
			}
		}

		private ProcessScriptTask _prepareWindowQuestionOnSave_ScriptTask;
		public ProcessScriptTask PrepareWindowQuestionOnSave_ScriptTask {
			get {
				return _prepareWindowQuestionOnSave_ScriptTask ?? (_prepareWindowQuestionOnSave_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareWindowQuestionOnSave_ScriptTask",
					SchemaElementUId = new Guid("81756ce6-df3d-4e26-a990-e7e1adad9237"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareWindowQuestionOnSave_ScriptTaskExecute,
				});
			}
		}

		private ShowWarningChangeEntitySchemaOnSaveMessageUserTaskFlowElement _showWarningChangeEntitySchemaOnSaveMessageUserTask;
		public ShowWarningChangeEntitySchemaOnSaveMessageUserTaskFlowElement ShowWarningChangeEntitySchemaOnSaveMessageUserTask {
			get {
				return _showWarningChangeEntitySchemaOnSaveMessageUserTask ?? (_showWarningChangeEntitySchemaOnSaveMessageUserTask = new ShowWarningChangeEntitySchemaOnSaveMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _changeSchemaEntityYesMessageStartMessage;
		public ProcessFlowElement ChangeSchemaEntityYesMessageStartMessage {
			get {
				return _changeSchemaEntityYesMessageStartMessage ?? (_changeSchemaEntityYesMessageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityYesMessageStartMessage",
					SchemaElementUId = new Guid("c66ba53d-1b1b-4d49-96b6-278f05436dc9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processPageSelect_ScriptTask;
		public ProcessScriptTask ProcessPageSelect_ScriptTask {
			get {
				return _processPageSelect_ScriptTask ?? (_processPageSelect_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessPageSelect_ScriptTask",
					SchemaElementUId = new Guid("6a0cec4f-8827-445f-a089-f7a4683e7ff8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessPageSelect_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("f6c9d983-5719-44d7-9319-23b59142fc4a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _nOChangeEntitySchemaOnSave_StartMessage;
		public ProcessFlowElement NOChangeEntitySchemaOnSave_StartMessage {
			get {
				return _nOChangeEntitySchemaOnSave_StartMessage ?? (_nOChangeEntitySchemaOnSave_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "NOChangeEntitySchemaOnSave_StartMessage",
					SchemaElementUId = new Guid("2c7daf6d-171b-48d9-a8a4-3515d1a1b0b6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _clearObject_ScriptTask;
		public ProcessScriptTask ClearObject_ScriptTask {
			get {
				return _clearObject_ScriptTask ?? (_clearObject_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClearObject_ScriptTask",
					SchemaElementUId = new Guid("325354ea-54c2-4375-8d59-00fff1795734"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ClearObject_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _openEditPageEventSubProcess2;
		public ProcessFlowElement OpenEditPageEventSubProcess2 {
			get {
				return _openEditPageEventSubProcess2 ?? (_openEditPageEventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenEditPageEventSubProcess2",
					SchemaElementUId = new Guid("e6fc8dc5-48c1-44bd-84d9-8b5c5cebc46b"),
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
					SchemaElementUId = new Guid("711ea29e-913b-47a5-8678-5d32ee76fd3e"),
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
					SchemaElementUId = new Guid("01677a75-89bc-4c7b-8d59-c38b77ae5996"),
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
					SchemaElementUId = new Guid("ad2dd160-8b07-4ffc-bd54-08feebe07f29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _createControlsScriptTask;
		public ProcessScriptTask CreateControlsScriptTask {
			get {
				return _createControlsScriptTask ?? (_createControlsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateControlsScriptTask",
					SchemaElementUId = new Guid("b1b52be0-65ed-4740-b09f-df2d451afc8e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateControlsScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _openEditPageEventSubProcess3;
		public ProcessFlowElement OpenEditPageEventSubProcess3 {
			get {
				return _openEditPageEventSubProcess3 ?? (_openEditPageEventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OpenEditPageEventSubProcess3",
					SchemaElementUId = new Guid("2cfdd037-9818-4b4a-a528-968fb206ab59"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoqdCompleteStartMessage;
		public ProcessFlowElement PageLoqdCompleteStartMessage {
			get {
				return _pageLoqdCompleteStartMessage ?? (_pageLoqdCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoqdCompleteStartMessage",
					SchemaElementUId = new Guid("6cbd8f75-4830-4bb0-8080-c027c888ce59"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoqdCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoqdCompleteIntermediateThrowMessageEvent {
			get {
				return _pageLoqdCompleteIntermediateThrowMessageEvent ?? (_pageLoqdCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoqdCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("151d4457-eab8-4547-8bc8-81f9cb4bc4b3"),
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
					SchemaElementUId = new Guid("98d7e503-bc70-4f90-9653-9db8b44ec678"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess18;
		public ProcessFlowElement EventSubProcess18 {
			get {
				return _eventSubProcess18 ?? (_eventSubProcess18 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess18",
					SchemaElementUId = new Guid("74f9a575-9378-4e94-b51d-b285de2ce2cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickOpenEditPageScriptTask;
		public ProcessScriptTask OkButtonClickOpenEditPageScriptTask {
			get {
				return _okButtonClickOpenEditPageScriptTask ?? (_okButtonClickOpenEditPageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickOpenEditPageScriptTask",
					SchemaElementUId = new Guid("bd951774-27eb-4e37-b7bb-d202a7a2153c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickOpenEditPageScriptTaskExecute,
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
					SchemaElementUId = new Guid("4ca88245-9591-4e41-a639-295bf0bff211"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _okButtonClickOpenEditPageStartMessage;
		public ProcessFlowElement OkButtonClickOpenEditPageStartMessage {
			get {
				return _okButtonClickOpenEditPageStartMessage ?? (_okButtonClickOpenEditPageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickOpenEditPageStartMessage",
					SchemaElementUId = new Guid("c2f8bbc5-37dd-466c-9fd3-ddb78ce09c53"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _chackValidation_ScriptTask;
		public ProcessScriptTask ChackValidation_ScriptTask {
			get {
				return _chackValidation_ScriptTask ?? (_chackValidation_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChackValidation_ScriptTask",
					SchemaElementUId = new Guid("b60261ba-ae4d-406c-a20f-7690cee176f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChackValidation_ScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway4;
		public ProcessExclusiveGateway ExclusiveGateway4 {
			get {
				return _exclusiveGateway4 ?? (_exclusiveGateway4 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway4",
					SchemaElementUId = new Guid("49f1b70f-4547-45fe-aa26-063d1070c1b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway4.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _warningMessage_ScriptTask;
		public ProcessScriptTask WarningMessage_ScriptTask {
			get {
				return _warningMessage_ScriptTask ?? (_warningMessage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "WarningMessage_ScriptTask",
					SchemaElementUId = new Guid("595206a6-3a9a-42ce-8ee7-d970eb4db855"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = WarningMessage_ScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("366d4846-1b35-425a-944f-fa4dee542187"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("aa60037e-92fd-4503-9197-1af09de5dcf2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("efb9efa2-b759-4c2f-9fb0-c48d884e79d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow4;
		public ProcessConditionalFlow ConditionalFlow4 {
			get {
				return _conditionalFlow4 ?? (_conditionalFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow4",
					SchemaElementUId = new Guid("64a1d4cb-219e-414d-a5af-fce2906b0051"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow5;
		public ProcessConditionalFlow ConditionalFlow5 {
			get {
				return _conditionalFlow5 ?? (_conditionalFlow5 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow5",
					SchemaElementUId = new Guid("1ec21bab-08e5-4335-ab58-5d977bf13bfb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _changeSchemaEntityMessage;
		public LocalizableString ChangeSchemaEntityMessage {
			get {
				return _changeSchemaEntityMessage ?? (_changeSchemaEntityMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChangeSchemaEntityMessage.Value"));
			}
		}

		private LocalizableString _captionColumnCaption;
		public LocalizableString CaptionColumnCaption {
			get {
				return _captionColumnCaption ?? (_captionColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CaptionColumnCaption.Value"));
			}
		}

		private LocalizableString _valueColumnCaption;
		public LocalizableString ValueColumnCaption {
			get {
				return _valueColumnCaption ?? (_valueColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValueColumnCaption.Value"));
			}
		}

		private LocalizableString _warningChangeEntitySchemaOnSave;
		public LocalizableString WarningChangeEntitySchemaOnSave {
			get {
				return _warningChangeEntitySchemaOnSave ?? (_warningChangeEntitySchemaOnSave = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WarningChangeEntitySchemaOnSave.Value"));
			}
		}

		private LocalizableString _validationMessageTitle;
		public LocalizableString ValidationMessageTitle {
			get {
				return _validationMessageTitle ?? (_validationMessageTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTitle.Value"));
			}
		}

		private LocalizableString _validationMessageTextNewRow;
		public LocalizableString ValidationMessageTextNewRow {
			get {
				return _validationMessageTextNewRow ?? (_validationMessageTextNewRow = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTextNewRow.Value"));
			}
		}

		private LocalizableString _validationMessageTextExistingRow;
		public LocalizableString ValidationMessageTextExistingRow {
			get {
				return _validationMessageTextExistingRow ?? (_validationMessageTextExistingRow = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTextExistingRow.Value"));
			}
		}

		private LocalizableString _validationMessageTextFilterParamsEmpty;
		public LocalizableString ValidationMessageTextFilterParamsEmpty {
			get {
				return _validationMessageTextFilterParamsEmpty ?? (_validationMessageTextFilterParamsEmpty = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTextFilterParamsEmpty.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[OpenEditPageTabPanelTabChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageTabPanelTabChangeEventSubProcess };
			FlowElements[OpenEditPageTabPanelTabChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageTabPanelTabChangeStartMessage };
			FlowElements[OpenEditPageTabPanelTabChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageTabPanelTabChangeScriptTask };
			FlowElements[EventSubProcess20.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess20 };
			FlowElements[ObjectEditChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChange_StartMessage };
			FlowElements[ObjectEditChange_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChange_ScriptTask };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent };
			FlowElements[ObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent };
			FlowElements[IsChangingEntitySchemaScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { IsChangingEntitySchemaScriptTask };
			FlowElements[EventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess16 };
			FlowElements[NewRecordEditCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { NewRecordEditCheckStartMessage };
			FlowElements[NewRecordEditCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NewRecordEditCheckScriptTask };
			FlowElements[EventSubProcess21.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess21 };
			FlowElements[ExistingRecordEditCheck_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ExistingRecordEditCheck_StartMessage };
			FlowElements[ExistingRecordEditCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ExistingRecordEditCheckScriptTask };
			FlowElements[SetDefaultColumnValuesButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SetDefaultColumnValuesButtonClickEventSubProcess };
			FlowElements[SetDefaultColumnValuesButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SetDefaultColumnValuesButtonClickStartMessage };
			FlowElements[SetDefaultColumnValuesButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetDefaultColumnValuesButtonClickScriptTask };
			FlowElements[OpenSpecifyColumnValuesPage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenSpecifyColumnValuesPage };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[ExploreButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ExploreButtonClickStartMessage };
			FlowElements[ExploreButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ExploreButtonClickScriptTask };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[GenerateDecisionsFromColumnEditCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateDecisionsFromColumnEditCheckStartMessage };
			FlowElements[GenerateDecisionsFromColumnEditCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateDecisionsFromColumnEditCheckScriptTask };
			FlowElements[OpenEditPageEventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageEventSubProcess8 };
			FlowElements[IsMatchConditionsEditCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { IsMatchConditionsEditCheckStartMessage };
			FlowElements[IsMatchConditionsEditCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { IsMatchConditionsEditCheckScriptTask };
			FlowElements[OpenEditPageEventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageEventSubProcess7 };
			FlowElements[ObjectEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChangeStartMessage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ScriptTaskPrepareChangeSchemaEntityQuestion.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPrepareChangeSchemaEntityQuestion };
			FlowElements[ChangeSchemaEntityUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityUserMessage };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[IsChangingPageSchemaScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { IsChangingPageSchemaScriptTask };
			FlowElements[OpenEditPageEventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageEventSubProcess5 };
			FlowElements[ChangeSchemaEntityYesMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityYesMessageScriptTask };
			FlowElements[YESChangeEntitySchemaOnSave_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { YESChangeEntitySchemaOnSave_StartMessage };
			FlowElements[OpenEditPageEventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageEventSubProcess6 };
			FlowElements[ChangeSchemaEntityNoMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityNoMessageStartMessage };
			FlowElements[ChangeSchemaEntityNoMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityNoMessageScriptTask };
			FlowElements[OpenEditPageEventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageEventSubProcess4 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[OkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent };
			FlowElements[PrepareWindowQuestionOnSave_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareWindowQuestionOnSave_ScriptTask };
			FlowElements[ShowWarningChangeEntitySchemaOnSaveMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowWarningChangeEntitySchemaOnSaveMessageUserTask };
			FlowElements[ChangeSchemaEntityYesMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityYesMessageStartMessage };
			FlowElements[ProcessPageSelect_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessPageSelect_ScriptTask };
			FlowElements[EventSubProcess19.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess19 };
			FlowElements[NOChangeEntitySchemaOnSave_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { NOChangeEntitySchemaOnSave_StartMessage };
			FlowElements[ClearObject_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearObject_ScriptTask };
			FlowElements[OpenEditPageEventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageEventSubProcess2 };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[CreateControlsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateControlsScriptTask };
			FlowElements[OpenEditPageEventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageEventSubProcess3 };
			FlowElements[PageLoqdCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteStartMessage };
			FlowElements[PageLoqdCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoqdCompleteIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcess18.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess18 };
			FlowElements[OkButtonClickOpenEditPageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickOpenEditPageScriptTask };
			FlowElements[OkButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickIntermediateThrowMessageEvent };
			FlowElements[OkButtonClickOpenEditPageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickOpenEditPageStartMessage };
			FlowElements[ChackValidation_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChackValidation_ScriptTask };
			FlowElements[ExclusiveGateway4.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway4 };
			FlowElements[WarningMessage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { WarningMessage_ScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "OpenEditPageTabPanelTabChangeEventSubProcess":
						break;
					case "OpenEditPageTabPanelTabChangeStartMessage":
						e.Context.QueueTasks.Enqueue("OpenEditPageTabPanelTabChangeScriptTask");
						break;
					case "OpenEditPageTabPanelTabChangeScriptTask":
						break;
					case "EventSubProcess20":
						break;
					case "ObjectEditChange_StartMessage":
						e.Context.QueueTasks.Enqueue("IsChangingEntitySchemaScriptTask");
						break;
					case "ObjectEditChange_ScriptTask":
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent");
							break;
						}
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent");
							break;
						}
						break;
					case "ObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ObjectEditChange_ScriptTask");
						break;
					case "ObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent":
						break;
					case "IsChangingEntitySchemaScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "EventSubProcess16":
						break;
					case "NewRecordEditCheckStartMessage":
						e.Context.QueueTasks.Enqueue("NewRecordEditCheckScriptTask");
						break;
					case "NewRecordEditCheckScriptTask":
						break;
					case "EventSubProcess21":
						break;
					case "ExistingRecordEditCheck_StartMessage":
						e.Context.QueueTasks.Enqueue("ExistingRecordEditCheckScriptTask");
						break;
					case "ExistingRecordEditCheckScriptTask":
						break;
					case "SetDefaultColumnValuesButtonClickEventSubProcess":
						break;
					case "SetDefaultColumnValuesButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("SetDefaultColumnValuesButtonClickScriptTask");
						break;
					case "SetDefaultColumnValuesButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenSpecifyColumnValuesPage");
						break;
					case "OpenSpecifyColumnValuesPage":
						break;
					case "EventSubProcess11":
						break;
					case "ExploreButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ExploreButtonClickScriptTask");
						break;
					case "ExploreButtonClickScriptTask":
						break;
					case "EventSubProcess9":
						break;
					case "GenerateDecisionsFromColumnEditCheckStartMessage":
						e.Context.QueueTasks.Enqueue("GenerateDecisionsFromColumnEditCheckScriptTask");
						break;
					case "GenerateDecisionsFromColumnEditCheckScriptTask":
						break;
					case "OpenEditPageEventSubProcess8":
						break;
					case "IsMatchConditionsEditCheckStartMessage":
						e.Context.QueueTasks.Enqueue("IsMatchConditionsEditCheckScriptTask");
						break;
					case "IsMatchConditionsEditCheckScriptTask":
						break;
					case "OpenEditPageEventSubProcess7":
						break;
					case "ObjectEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("IsChangingPageSchemaScriptTask");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTaskPrepareChangeSchemaEntityQuestion");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "ScriptTaskPrepareChangeSchemaEntityQuestion":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityUserMessage");
						break;
					case "ChangeSchemaEntityUserMessage":
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "IsChangingPageSchemaScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "OpenEditPageEventSubProcess5":
						break;
					case "ChangeSchemaEntityYesMessageScriptTask":
						break;
					case "YESChangeEntitySchemaOnSave_StartMessage":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityYesMessageScriptTask");
						break;
					case "OpenEditPageEventSubProcess6":
						break;
					case "ChangeSchemaEntityNoMessageStartMessage":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityNoMessageScriptTask");
						break;
					case "ChangeSchemaEntityNoMessageScriptTask":
						break;
					case "OpenEditPageEventSubProcess4":
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareWindowQuestionOnSave_ScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("OkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent");
						break;
					case "OkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent":
						break;
					case "PrepareWindowQuestionOnSave_ScriptTask":
						e.Context.QueueTasks.Enqueue("ShowWarningChangeEntitySchemaOnSaveMessageUserTask");
						break;
					case "ShowWarningChangeEntitySchemaOnSaveMessageUserTask":
						break;
					case "ChangeSchemaEntityYesMessageStartMessage":
						e.Context.QueueTasks.Enqueue("ProcessPageSelect_ScriptTask");
						break;
					case "ProcessPageSelect_ScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "EventSubProcess19":
						break;
					case "NOChangeEntitySchemaOnSave_StartMessage":
						e.Context.QueueTasks.Enqueue("ClearObject_ScriptTask");
						break;
					case "ClearObject_ScriptTask":
						break;
					case "OpenEditPageEventSubProcess2":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("CreateControlsScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "CreateControlsScriptTask":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "OpenEditPageEventSubProcess3":
						break;
					case "PageLoqdCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoqdCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoqdCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcess18":
						break;
					case "OkButtonClickOpenEditPageScriptTask":
						e.Context.QueueTasks.Enqueue("OkButtonClickIntermediateThrowMessageEvent");
						break;
					case "OkButtonClickIntermediateThrowMessageEvent":
						break;
					case "OkButtonClickOpenEditPageStartMessage":
						e.Context.QueueTasks.Enqueue("ChackValidation_ScriptTask");
						break;
					case "ChackValidation_ScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway4");
						break;
					case "ExclusiveGateway4":
						if (ConditionalFlow5ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OkButtonClickOpenEditPageScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("WarningMessage_ScriptTask");
						break;
					case "WarningMessage_ScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(EntitySchemaUId != Guid.Empty);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(IsEntitySchemaNeedInChangesForListeningByProcess());
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean((Guid)Page.ObjectEdit.Value == Guid.Empty);
		}

		private bool ConditionalFlow4ExpressionExecute() {
			return Convert.ToBoolean((Guid)Page.ObjectEdit.Value != Guid.Empty && EntitySchemaUId == Guid.Empty);
		}

		private bool ConditionalFlow5ExpressionExecute() {
			return Convert.ToBoolean(IsDataValid_NewRow && IsDataValid_ExistingRow && IsFilterParamsValuesCorrect);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OpenEditPageTabPanelTabChangeStartMessage");
			ActivatedEventElements.Add("ObjectEditChange_StartMessage");
			ActivatedEventElements.Add("NewRecordEditCheckStartMessage");
			ActivatedEventElements.Add("ExistingRecordEditCheck_StartMessage");
			ActivatedEventElements.Add("SetDefaultColumnValuesButtonClickStartMessage");
			ActivatedEventElements.Add("ExploreButtonClickStartMessage");
			ActivatedEventElements.Add("GenerateDecisionsFromColumnEditCheckStartMessage");
			ActivatedEventElements.Add("IsMatchConditionsEditCheckStartMessage");
			ActivatedEventElements.Add("ObjectEditChangeStartMessage");
			ActivatedEventElements.Add("YESChangeEntitySchemaOnSave_StartMessage");
			ActivatedEventElements.Add("ChangeSchemaEntityNoMessageStartMessage");
			ActivatedEventElements.Add("ChangeSchemaEntityYesMessageStartMessage");
			ActivatedEventElements.Add("NOChangeEntitySchemaOnSave_StartMessage");
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("PageLoqdCompleteStartMessage");
			ActivatedEventElements.Add("OkButtonClickOpenEditPageStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "OpenEditPageTabPanelTabChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OpenEditPageTabPanelTabChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenEditPageTabPanelTabChangeStartMessage";
					result = OpenEditPageTabPanelTabChangeStartMessage.Execute(context);
					break;
				case "OpenEditPageTabPanelTabChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenEditPageTabPanelTabChangeScriptTask";
					result = OpenEditPageTabPanelTabChangeScriptTask.Execute(context, OpenEditPageTabPanelTabChangeScriptTaskExecute);
					break;
				case "EventSubProcess20":
					context.QueueTasks.Dequeue();
					break;
				case "ObjectEditChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectEditChange_StartMessage";
					result = ObjectEditChange_StartMessage.Execute(context);
					break;
				case "ObjectEditChange_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectEditChange_ScriptTask";
					result = ObjectEditChange_ScriptTask.Execute(context, ObjectEditChange_ScriptTaskExecute);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "ObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = ObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "ObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = ObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "IsChangingEntitySchemaScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsChangingEntitySchemaScriptTask";
					result = IsChangingEntitySchemaScriptTask.Execute(context, IsChangingEntitySchemaScriptTaskExecute);
					break;
				case "EventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "NewRecordEditCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "NewRecordEditCheckStartMessage";
					result = NewRecordEditCheckStartMessage.Execute(context);
					break;
				case "NewRecordEditCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "NewRecordEditCheckScriptTask";
					result = NewRecordEditCheckScriptTask.Execute(context, NewRecordEditCheckScriptTaskExecute);
					break;
				case "EventSubProcess21":
					context.QueueTasks.Dequeue();
					break;
				case "ExistingRecordEditCheck_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExistingRecordEditCheck_StartMessage";
					result = ExistingRecordEditCheck_StartMessage.Execute(context);
					break;
				case "ExistingRecordEditCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExistingRecordEditCheckScriptTask";
					result = ExistingRecordEditCheckScriptTask.Execute(context, ExistingRecordEditCheckScriptTaskExecute);
					break;
				case "SetDefaultColumnValuesButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SetDefaultColumnValuesButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetDefaultColumnValuesButtonClickStartMessage";
					result = SetDefaultColumnValuesButtonClickStartMessage.Execute(context);
					break;
				case "SetDefaultColumnValuesButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetDefaultColumnValuesButtonClickScriptTask";
					result = SetDefaultColumnValuesButtonClickScriptTask.Execute(context, SetDefaultColumnValuesButtonClickScriptTaskExecute);
					break;
				case "OpenSpecifyColumnValuesPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenSpecifyColumnValuesPage";
					result = OpenSpecifyColumnValuesPage.Execute(context);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "ExploreButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExploreButtonClickStartMessage";
					result = ExploreButtonClickStartMessage.Execute(context);
					break;
				case "ExploreButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExploreButtonClickScriptTask";
					result = ExploreButtonClickScriptTask.Execute(context, ExploreButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "GenerateDecisionsFromColumnEditCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateDecisionsFromColumnEditCheckStartMessage";
					result = GenerateDecisionsFromColumnEditCheckStartMessage.Execute(context);
					break;
				case "GenerateDecisionsFromColumnEditCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateDecisionsFromColumnEditCheckScriptTask";
					result = GenerateDecisionsFromColumnEditCheckScriptTask.Execute(context, GenerateDecisionsFromColumnEditCheckScriptTaskExecute);
					break;
				case "OpenEditPageEventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "IsMatchConditionsEditCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsMatchConditionsEditCheckStartMessage";
					result = IsMatchConditionsEditCheckStartMessage.Execute(context);
					break;
				case "IsMatchConditionsEditCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsMatchConditionsEditCheckScriptTask";
					result = IsMatchConditionsEditCheckScriptTask.Execute(context, IsMatchConditionsEditCheckScriptTaskExecute);
					break;
				case "OpenEditPageEventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "ObjectEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectEditChangeStartMessage";
					result = ObjectEditChangeStartMessage.Execute(context);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ScriptTaskPrepareChangeSchemaEntityQuestion":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPrepareChangeSchemaEntityQuestion";
					result = ScriptTaskPrepareChangeSchemaEntityQuestion.Execute(context, ScriptTaskPrepareChangeSchemaEntityQuestionExecute);
					break;
				case "ChangeSchemaEntityUserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityUserMessage";
					result = ChangeSchemaEntityUserMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "IsChangingPageSchemaScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsChangingPageSchemaScriptTask";
					result = IsChangingPageSchemaScriptTask.Execute(context, IsChangingPageSchemaScriptTaskExecute);
					break;
				case "OpenEditPageEventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityYesMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityYesMessageScriptTask";
					result = ChangeSchemaEntityYesMessageScriptTask.Execute(context, ChangeSchemaEntityYesMessageScriptTaskExecute);
					break;
				case "YESChangeEntitySchemaOnSave_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "YESChangeEntitySchemaOnSave_StartMessage";
					result = YESChangeEntitySchemaOnSave_StartMessage.Execute(context);
					break;
				case "OpenEditPageEventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityNoMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityNoMessageStartMessage";
					result = ChangeSchemaEntityNoMessageStartMessage.Execute(context);
					break;
				case "ChangeSchemaEntityNoMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityNoMessageScriptTask";
					result = ChangeSchemaEntityNoMessageScriptTask.Execute(context, ChangeSchemaEntityNoMessageScriptTaskExecute);
					break;
				case "OpenEditPageEventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "OkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = OkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "PrepareWindowQuestionOnSave_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareWindowQuestionOnSave_ScriptTask";
					result = PrepareWindowQuestionOnSave_ScriptTask.Execute(context, PrepareWindowQuestionOnSave_ScriptTaskExecute);
					break;
				case "ShowWarningChangeEntitySchemaOnSaveMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowWarningChangeEntitySchemaOnSaveMessageUserTask";
					result = ShowWarningChangeEntitySchemaOnSaveMessageUserTask.Execute(context);
					break;
				case "ChangeSchemaEntityYesMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityYesMessageStartMessage";
					result = ChangeSchemaEntityYesMessageStartMessage.Execute(context);
					break;
				case "ProcessPageSelect_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessPageSelect_ScriptTask";
					result = ProcessPageSelect_ScriptTask.Execute(context, ProcessPageSelect_ScriptTaskExecute);
					break;
				case "EventSubProcess19":
					context.QueueTasks.Dequeue();
					break;
				case "NOChangeEntitySchemaOnSave_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "NOChangeEntitySchemaOnSave_StartMessage";
					result = NOChangeEntitySchemaOnSave_StartMessage.Execute(context);
					break;
				case "ClearObject_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClearObject_ScriptTask";
					result = ClearObject_ScriptTask.Execute(context, ClearObject_ScriptTaskExecute);
					break;
				case "OpenEditPageEventSubProcess2":
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
				case "CreateControlsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateControlsScriptTask";
					result = CreateControlsScriptTask.Execute(context, CreateControlsScriptTaskExecute);
					break;
				case "OpenEditPageEventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoqdCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoqdCompleteStartMessage";
					result = PageLoqdCompleteStartMessage.Execute(context);
					break;
				case "PageLoqdCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoqdCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "EventSubProcess18":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickOpenEditPageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickOpenEditPageScriptTask";
					result = OkButtonClickOpenEditPageScriptTask.Execute(context, OkButtonClickOpenEditPageScriptTaskExecute);
					break;
				case "OkButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = OkButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "OkButtonClickOpenEditPageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickOpenEditPageStartMessage";
					result = OkButtonClickOpenEditPageStartMessage.Execute(context);
					break;
				case "ChackValidation_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChackValidation_ScriptTask";
					result = ChackValidation_ScriptTask.Execute(context, ChackValidation_ScriptTaskExecute);
					break;
				case "ExclusiveGateway4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway4";
					result = ExclusiveGateway4.Execute(context);
					break;
				case "WarningMessage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "WarningMessage_ScriptTask";
					result = WarningMessage_ScriptTask.Execute(context, WarningMessage_ScriptTaskExecute);
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
				case "EditCardSchemaUIdPageTypeUIdTies":
					EditCardSchemaUIdPageTypeUIdTies = reader.GetSerializableObjectValue();
				break;
				case "IsChangingPageSchema":
					IsChangingPageSchema = reader.GetValue<System.Boolean>();
				break;
				case "IsChangingEntitySchema":
					IsChangingEntitySchema = reader.GetValue<System.Boolean>();
				break;
				case "InsertedColumnValueKey":
					InsertedColumnValueKey = reader.GetValue<System.String>();
				break;
				case "IsFilterParamsValuesCorrect":
					IsFilterParamsValuesCorrect = reader.GetValue<System.Boolean>();
				break;
				case "IsDataValid_ExistingRow":
					IsDataValid_ExistingRow = reader.GetValue<System.Boolean>();
				break;
				case "IsDataValid_NewRow":
					IsDataValid_NewRow = reader.GetValue<System.Boolean>();
				break;
				case "IsEntitySchemaChanged":
					IsEntitySchemaChanged = reader.GetValue<System.Boolean>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "FilterEditSchemaExplorer":
					FilterEditSchemaExplorer = reader.GetSerializableObjectValue();
				break;
				case "FilterUId":
					FilterUId = reader.GetValue<System.Guid>();
				break;
				case "FilterEditSchemaExplorerCreated":
					FilterEditSchemaExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "PageSchemaId":
					PageSchemaId = reader.GetValue<System.Guid>();
				break;
				case "EntitiesForPages":
					EntitiesForPages = reader.GetSerializableObjectValue();
				break;
				case "ColumnValuesContextKey":
					ColumnValuesContextKey = reader.GetValue<System.String>();
				break;
				case "DecisionalColumnMetaPath":
					DecisionalColumnMetaPath = reader.GetValue<System.String>();
				break;
				case "IsColumnExplorerCreated":
					IsColumnExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool OpenEditPageTabPanelTabChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.OpenEditPageTabPanel.ActiveTabIndex == 1 && !IsUsedActivityControls) {
				SetActivityDurationPeriodEditControlsValue();
				SetDefValueParameterValueEdit(GetActivityControlsBinding());
				IsUsedActivityControls = true;
			}
			return true;
		}

		public virtual bool ObjectEditChange_ScriptTaskExecute(ProcessExecutingContext context) {
			//IsEntitySchemaChanged = true;
			return true;
		}

		public virtual bool IsChangingEntitySchemaScriptTaskExecute(ProcessExecutingContext context) {
			IsChangingEntitySchema = true;
			return true;
		}

		public virtual bool NewRecordEditCheckScriptTaskExecute(ProcessExecutingContext context) {
			bool isNewRecordMode = Page.NewRecordEdit.Checked;
			SetControlsEnabledProperty(isNewRecordMode);
			return true;
		}

		public virtual bool ExistingRecordEditCheckScriptTaskExecute(ProcessExecutingContext context) {
			bool isExistingRecordEditMode = Page.ExistingRecordEdit.Checked;
			SetControlsEnabledProperty(!isExistingRecordEditMode);
			if (isExistingRecordEditMode) {
				UserConnection.SessionData[ColumnValuesContextKey] = new Dictionary<string, ProcessSchemaParameterValue>();
			}
			return true;
		}

		public virtual bool SetDefaultColumnValuesButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			OpenSpecifyColumnValuesPage.OpenerInstanceId = InstanceUId;
			OpenSpecifyColumnValuesPage.UseCurrentActivePage = true;
			OpenSpecifyColumnValuesPage.PageUId = new Guid("F08055CC-A384-4885-8FD0-B6173B0E1D7B");
			OpenSpecifyColumnValuesPage.PageParameters = new Dictionary<string, string>() {
				{ "entitySchemaUId", EntitySchemaUId.ToString() },
				{ "editSchemaUId", EditSchemaUId.ToString() },
				{ "editSchemaManagerName", EditSchemaManagerName },
				{ "columnValuesContextKey", ColumnValuesContextKey },
				{ "editElementUId", EditElementUId.ToString() }
			};
			//OpenSpecifyColumnValuesPage.CloseMessage = "ColumnValueEditPageClosed";
			//InsertedColumnValueKey = Name + "_" + Guid.NewGuid().ToString();
			return true;
		}

		public virtual bool ExploreButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			OpenColumnExplorer();
			return true;
		}

		public virtual bool GenerateDecisionsFromColumnEditCheckScriptTaskExecute(ProcessExecutingContext context) {
			Page.DecisionalColumnEdit.SetEnabled(Page.GenerateDecisionsFromColumnEdit.Checked);
			Page.ExploreButton.SetEnabled(Page.GenerateDecisionsFromColumnEdit.Checked);
			/*
			if (!Page.GenerateDecisionsFromColumnEdit.Checked) {
				Page.DecisionalColumnEdit.Clear();
				DecisionalColumnMetaPath = String.Empty;
			}
			*/
			return true;
		}

		public virtual bool IsMatchConditionsEditCheckScriptTaskExecute(ProcessExecutingContext context) {
			Page.FilterEdit.Enabled = Page.IsMatchConditionsEdit.Checked;
			return true;
		}

		public virtual bool ScriptTaskPrepareChangeSchemaEntityQuestionExecute(ProcessExecutingContext context) {
			ChangeSchemaEntityUserMessage.Page = Page;
			ChangeSchemaEntityUserMessage.MessageText = ChangeSchemaEntityMessage;
			ChangeSchemaEntityUserMessage.Icon = "QUESTION";
			ChangeSchemaEntityUserMessage.Buttons = "YESNO";
			ChangeSchemaEntityUserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "ChangeSchemaEntityYesMessage"},
				{"no", "ChangeSchemaEntityNoMessage"},
			};
			return true;
		}

		public virtual bool IsChangingPageSchemaScriptTaskExecute(ProcessExecutingContext context) {
			IsChangingPageSchema = true;
			return true;
		}

		public virtual bool ChangeSchemaEntityYesMessageScriptTaskExecute(ProcessExecutingContext context) {
			Page.EntityDataSource.SchemaUId = EntitySchemaUId;
			ResetControlValues();
			Page.FilterEdit.SetDataSource(Page.EntityDataSource);
			if (EntitySchemaUId != Guid.Empty) {
				Page.EntityDataSource.LoadStructure();
			}
			EnableControls();
			SetControlsEnabledProperty(Page.NewRecordEdit.Checked);
			
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			ProcessSchemaParameterValue recordIdValue;
			if (!parametersValue.TryGetValue("RecordId", out recordIdValue)) {
				recordIdValue = new ProcessSchemaParameterValue();
			}
			recordIdValue.ModifiedInSchemaUId = EditSchemaUId;
			recordIdValue.ReferenceSchemaUId = EntitySchemaUId;
			parametersValue["RecordId"] = recordIdValue;
			return true;
		}

		public virtual bool ChangeSchemaEntityNoMessageScriptTaskExecute(ProcessExecutingContext context) {
			Page.PageEdit.SuspendAjaxEvents();
			var clientUnitSchemaManager = (ClientUnitSchemaManager)UserConnection
				.GetSchemaManager("ClientUnitSchemaManager");
			ISchemaManagerItem<ClientUnitSchema> clientUnitSchemaItem = clientUnitSchemaManager.GetItemByUId(PageSchemaId);
			Page.PageEdit.SetValueAndText(clientUnitSchemaItem.Id, clientUnitSchemaItem.Caption);
			/*
			VwSysClientUnitSchema clientUnitSchema;
			if (TryFetchClientUnitSchemaFromDb(out clientUnitSchema)) {
				Page.PageEdit.SetValueAndText(clientUnitSchema.Id, clientUnitSchema.Caption);
			}
			*/
			Page.PageEdit.ResumeAjaxEvents();
			return true;
		}

		public virtual bool PrepareWindowQuestionOnSave_ScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			var objectCaption = entitySchema.Caption;
			
			ShowWarningChangeEntitySchemaOnSaveMessageUserTask.Page = Page;
			ShowWarningChangeEntitySchemaOnSaveMessageUserTask.MessageText = 
				string.Format(WarningChangeEntitySchemaOnSave, 
					string.IsNullOrEmpty(Page.UserTaskTitleEdit.Text) ? string.Empty : " \"" + Page.UserTaskTitleEdit.Text + "\"",
					objectCaption);
			ShowWarningChangeEntitySchemaOnSaveMessageUserTask.Icon = "WARNING";
			ShowWarningChangeEntitySchemaOnSaveMessageUserTask.Buttons = "OKCANCEL";
			ShowWarningChangeEntitySchemaOnSaveMessageUserTask.ResponseMessages = new Dictionary<string, string> {
				{"ok", "YESChangeEntitySchemaOnSave"},
				{"cancel", "NOChangeEntitySchemaOnSave"},
			};
			return true;
		}

		public virtual bool ProcessPageSelect_ScriptTaskExecute(ProcessExecutingContext context) {
			PageSchemaId = Guid.Empty;
			EntitySchemaUId = Guid.Empty;
			var selectedPageSchemaId = (Guid)Page.PageEdit.Value;
			if (selectedPageSchemaId != Guid.Empty) {
				var select =
					new Select(UserConnection)
						.Column("UId")
					.From("SysSchema")
					.Where("Id").IsEqual(Column.Parameter(selectedPageSchemaId)) as Select;
				PageSchemaId = select.ExecuteScalar<Guid>();
				var entitySchemaIds = (Dictionary<object, List<object>>)EntitiesForPages;
				EntitySchemaUId = new Guid(entitySchemaIds[PageSchemaId.ToString()][0].ToString());
				SetEnabledActivityTabControls(EntitySchemaUId);
			}
			return true;
		}

		public virtual bool ClearObject_ScriptTaskExecute(ProcessExecutingContext context) {
			Page.AddScript(string.Format("{0}.setValueAndText('','');", Page.ObjectEdit.ClientID));
			
			EntitySchemaUId = Guid.Empty;
			
			Page.EntityDataSource.SchemaUId = EntitySchemaUId;
			ResetControlValues();
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			if (Ext.IsAjaxRequest) {
				return true;
			}
			var falseValue = "false";
			var defValues = (Dictionary<string, ProcessSchemaParameterValue>)DefaultValues;
			////SetDefaultValue(defValues["ShowTip"], falseValue, string.Empty, "ShowTip");
			SetDefaultValue(defValues["IsMatchConditions"], falseValue, string.Empty, "IsMatchConditions");
			SetDefaultValue(defValues["GenerateDecisionsFromColumn"], falseValue, string.Empty, "GenerateDecisionsFromColumn");
			////SetDefaultValue(defValues["PageSchemaId"], "10E5B380-25F3-474D-8DEC-6B4084180AC7", string.Empty, "PageSchemaId");
			DefaultValues = defValues;
			InvokeInitBaseActivityParametersEditPage();
			return true;
		}

		public virtual bool CreateControlsScriptTaskExecute(ProcessExecutingContext context) {
			if (IsColumnExplorerCreated) {
				CreateColumnExplorer();
			}
			var entitySchemaUIds = (Dictionary<object, List<object>>)EntitiesForPages;
			//TODO Hack. Bug in process parameters serialization with types of Dictionary<object, List<object>>, where key is Guid
			var newentitySchemaUIds = new Dictionary<object, List<object>>();
			if (entitySchemaUIds != null) {
				foreach (var entityUId in entitySchemaUIds.Keys) {
					var newListObject = new List<object>();
					foreach (var listObjectItem in entitySchemaUIds[entityUId]) {
						newListObject.Add(new Guid((string)listObjectItem));
					}
					newentitySchemaUIds.Add(new Guid((string)entityUId), newListObject);
				}
			}
			var workSpaceFilter = new Dictionary<string, object> {
				{ "comparisonType", FilterComparisonType.Equal },
				{ "leftExpressionColumnPath", "SysWorkspace" },
				{ "useDisplayValue", false },
				{ "rightExpressionParameterValues", new object[] { UserConnection.Workspace.Id } }
			};
			/*
			var processSchema = FindDesignedProcessSchema();
			var packageFilter = new Dictionary<string, object> {
				{ "comparisonType", FilterComparisonType.Equal },
				{ "leftExpressionColumnPath", "SysPackageUId" },
				{ "useDisplayValue", false },
				{ "rightExpressionParameterValues", new object[] { processSchema.PackageUId } }
			};
			*/
			var schemaFilter = new Dictionary<string, object> {
				{ "comparisonType", FilterComparisonType.Equal },
				{ "leftExpressionColumnPath", "UId" },
				{ "useDisplayValue", false },
				{ "rightExpressionParameterValues", null }
			};
			var extendParentFilter = new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.Equal},
				{"leftExpressionColumnPath", "ExtendParent"},
				{"useDisplayValue", false},
				{"rightExpressionParameterValues", new object[] {false}}};
			Page.PageEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var lookupFilters = (Collection<Dictionary<string, object>>)e.Filters;
				schemaFilter["rightExpressionParameterValues"] = entitySchemaUIds == null ? null : newentitySchemaUIds.Keys.ToArray();
				//lookupFilters.Add(packageFilter);
				lookupFilters.Add(schemaFilter);
				lookupFilters.Add(workSpaceFilter);
				lookupFilters.Add(extendParentFilter);
			};
			Page.ObjectEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var lookupFilters = (Collection<Dictionary<string, object>>)e.Filters;
				schemaFilter["rightExpressionParameterValues"] = PageSchemaId == Guid.Empty ?
					new object[] { Guid.Empty }: entitySchemaUIds == null ? null : newentitySchemaUIds[PageSchemaId].ToArray();
				lookupFilters.Add(schemaFilter);
				lookupFilters.Add(workSpaceFilter);
			};
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			IsUsedActivityControls = Page.OpenEditPageTabPanel.ActiveTabIndex == 1;
			Page.OpenEditPageTabPanel.UseProfile = false;
			PrepareEntitiesForPages();
			ConfigureFilterEdit();
			var parameters = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (parameters == null) {
				return true;
			}
			string parameterValue = parameters["EditMode"].Value;
			RecordEditMode editMode;
			Enum.TryParse(string.IsNullOrEmpty(parameterValue) ? string.Empty : parameterValue, out editMode);
			bool isNewRecordEditMode = editMode == RecordEditMode.New;
			if (isNewRecordEditMode) {
				Page.NewRecordEdit.Checked = true;
			} else {
				Page.ExistingRecordEdit.Checked = true;
			}
			parameterValue = parameters["ObjectSchemaId"].Value;
			IsNew = string.IsNullOrEmpty(parameterValue);
			if (!IsNew) {
				EntitySchemaUId = new Guid(parameterValue);
				Page.EntityDataSource.SchemaUId = EntitySchemaUId;
				string filters = parameters["DataSourceFilters"].Value;
				if (!string.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(
						UserConnection, Page.FilterEdit.DataSource);
					var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
						new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;
					if (filterCollection != null) {
						var filterEditGroup = Page.EntityDataSource.FindFiltersGroupByName(filterCollection.Name);
						if (filterEditGroup != null) {
							Page.EntityDataSource.CurrentStructure.Filters.Remove(filterEditGroup);
						}
						Page.EntityDataSource.CurrentStructure.Filters.Add(filterCollection);
					}
				}
				Page.EntityDataSource.LoadStructure();
				Page.FilterEdit.SetDataSource(Page.EntityDataSource);
				ISchemaManagerItem<EntitySchema> entitySchemaItem = GetEntitySchemaItem();
				Page.ObjectEdit.SetValueAndText(entitySchemaItem.Id, entitySchemaItem.Caption);
			}
			parameterValue = parameters["PageSchemaId"].Value;
			if (!string.IsNullOrEmpty(parameterValue)) {
				PageSchemaId = new Guid(parameterValue);
				var clientUnitSchemaManager = (ClientUnitSchemaManager)UserConnection
					.GetSchemaManager("ClientUnitSchemaManager");
				ISchemaManagerItem<ClientUnitSchema> clientUnitSchemaItem = clientUnitSchemaManager.GetItemByUId(PageSchemaId);
				Page.PageEdit.SetValueAndText(clientUnitSchemaItem.Id, clientUnitSchemaItem.Caption);
			}
			if (EntitySchemaUId != Guid.Empty) {
				DecisionalColumnMetaPath = parameters["DecisionalColumnMetaPath"].Value;
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
				if (!string.IsNullOrEmpty(DecisionalColumnMetaPath)) {
					var column = entitySchema.GetSchemaColumnByMetaPath(DecisionalColumnMetaPath);
					Page.DecisionalColumnEdit.Text = column.Caption.ToString();
				}
			}
			ColumnValuesContextKey = Guid.NewGuid().ToString();
			var columnValues = new Dictionary<string, ProcessSchemaParameterValue>();
			ProcessSchemaParameterValue columnValuesParameterValue = parameters["RecordColumnValues"];
			if (columnValuesParameterValue != null) {
				EntityColumnMappingCollection cvColection =
					EntityColumnMappingCollection.DeserializeValue(columnValuesParameterValue);
				if (cvColection != null) {
					foreach (var cv in cvColection) {
						columnValues[cv.ColumnMetaPath] = cv.Value;
					}
				}
			}
			UserConnection.SessionData[ColumnValuesContextKey] = columnValues;
			EnableControls();
			SetControlsEnabledProperty(isNewRecordEditMode);
			SetEnabledActivityTabControls(EntitySchemaUId);
			return true;
		}

		public virtual bool OkButtonClickOpenEditPageScriptTaskExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.UserTaskTitleEdit.Text;
			
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			
			// Record Id allways must have ReferenceSchemaUId value
			var recordIdValue = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				ReferenceSchemaUId = EntitySchemaUId
			};
			
			if (Page.ExistingRecordEdit.Checked) {
				recordIdValue.Source = Page.RecordIdEdit.ParameterValue.Source;
				recordIdValue.Value = Page.RecordIdEdit.ParameterValue.Value;
				recordIdValue.MetaPath = Page.RecordIdEdit.ParameterValue.Value;
				recordIdValue.DisplayValue = Page.RecordIdEdit.ParameterValue.DisplayValue;
			}
			
			parametersValue["RecordId"] = recordIdValue;
			
			// Set record edit mode
			parametersValue["EditMode"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value = Page.NewRecordEdit.Checked ? "0" : "1"
			};
			
			// Set user task executed mode
			/*
			foreach (var executedMode in Enum.GetValues(typeof(UserTaskExecutedMode))) {
				var executedModeCB = ControlUtilities.FindControl<UIControls.RadioButton>(
					Page.TopControlLayout, executedMode.ToString() + "Edit");
					
				if (executedModeCB.Checked) {
					parametersValue["ExecutedMode"] = new ProcessSchemaParameterValue() {
						ModifiedInSchemaUId = EditSchemaUId,
						Source = constVS,
						Value = ((int)executedMode).ToString()
					};
					break;
				}
			}
			*/
			
			// Serealize datasource filter instead of ESQ one because we need to rebuild
			// it when reopen page for this element.
			// Obtain ESQ filter from serealized datasource filter for this element on runtime
			var filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			var jsonConverter = new DataSourceFiltersJsonConverter(
				UserConnection, Page.FilterEdit.DataSource);
			
			parametersValue["DataSourceFilters"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = Page.IsMatchConditionsEdit.Checked ? constVS : noneVS,
				Value = Page.IsMatchConditionsEdit.Checked ? 
					Json.Serialize(filterCollection, jsonConverter) : String.Empty
			};
			
			parametersValue["GenerateDecisionsFromColumn"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value = Page.GenerateDecisionsFromColumnEdit.Checked.ToString()
			};
			
			if (string.IsNullOrEmpty(Convert.ToString(Page.DecisionalColumnEdit.Value))) {
				DecisionalColumnMetaPath = string.Empty;
			}
			parametersValue["DecisionalColumnMetaPath"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = String.IsNullOrEmpty(DecisionalColumnMetaPath) ? noneVS : constVS,
				Value = DecisionalColumnMetaPath,
			};
			
			// Set object schema value
			string objectSchemaId = EntitySchemaUId == Guid.Empty ?
				string.Empty : EntitySchemaUId.ToString();
			
			parametersValue["ObjectSchemaId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = String.IsNullOrEmpty(objectSchemaId) ? noneVS : constVS,
				Value = objectSchemaId
			};
			bool isNotGuidEmptyPageSchemaId = PageSchemaId != Guid.Empty;
			string pageSchemaId = isNotGuidEmptyPageSchemaId ?
				PageSchemaId.ToString() : string.Empty ;
			parametersValue["PageSchemaId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = isNotGuidEmptyPageSchemaId ? constVS : noneVS,
				Value = pageSchemaId
			};
			var editCardSchemaUIdPageTypeUIdTies = (Dictionary<Guid, Guid>)EditCardSchemaUIdPageTypeUIdTies;
			var pageTypeUIdParameterValue =  new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
			};
			Guid pageTypeUId;
			if (isNotGuidEmptyPageSchemaId && editCardSchemaUIdPageTypeUIdTies.TryGetValue(PageSchemaId, out pageTypeUId)) {
				pageTypeUIdParameterValue.Source = constVS;
				pageTypeUIdParameterValue.Value = pageTypeUId.ToString();
			} else {
				pageTypeUIdParameterValue.Source = noneVS;
				pageTypeUIdParameterValue.Value = string.Empty;
			}
			parametersValue["PageTypeUId"] = pageTypeUIdParameterValue;
			
			// Set column values
			EntityColumnMappingCollection mappingCollection = null;
			if (Page.NewRecordEdit.Checked) {
				var specifiedColumnValues =
					UserConnection.SessionData[ColumnValuesContextKey] as Dictionary<string, ProcessSchemaParameterValue>;
				if (specifiedColumnValues != null) {
					mappingCollection = new EntityColumnMappingCollection(specifiedColumnValues, EntitySchemaUId);
				}
			}
			LocalizableParameterValuesList mappingLocalizableList = mappingCollection == null 
				? new LocalizableParameterValuesList()
				: mappingCollection.ToLocalizableList(UserConnection.DataValueTypeManager);
			parametersValue["RecordColumnValues"] = new ProcessSchemaParameterValue {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = mappingLocalizableList.Count == 0 ? noneVS : constVS,
				LocalizableCollectionValue = mappingLocalizableList
			};
			
			var processSchema = FindDesignedProcessSchema();
			var parametrizedElement = (IParametrizedProcessSchemaElement)processSchema.GetBaseElementByUId(EditElementUId);
			parametrizedElement.EntitySchemaUId = EntitySchemaUId;
			return true;
		}

		public virtual bool ChackValidation_ScriptTaskExecute(ProcessExecutingContext context) {
			IsDataValid_NewRow = true;
			IsDataValid_ExistingRow = true;
			if (Page.ExistingRecordEdit.Checked) {
				IsDataValid_ExistingRow = !string.IsNullOrEmpty(Page.RecordIdEdit.ParameterValue.Value);
			}
			/*
			else {
				if (Page.NewRecordEdit.Checked) {
					foreach (var pair in GetColumnValues()) {
						if (string.IsNullOrEmpty(pair.Value.Value)) {
							IsDataValid_NewRow = false;
							break;
						}
					}
				}
			}
			*/
			IsFilterParamsValuesCorrect = true;
			if (Page.IsMatchConditionsEdit.Checked) {
				var filters = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
				IsFilterParamsValuesCorrect = filters.Count != 0 && !filters.IsAnyLeftExpressionNullOrEmpty();
			}
			return true;
		}

		public virtual bool WarningMessage_ScriptTaskExecute(ProcessExecutingContext context) {
			var text = string.Empty;
			if (!IsDataValid_NewRow) {
				Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessageTextNewRow, MessageType.Warning);
			}
			if (!IsDataValid_ExistingRow) {
				Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessageTextExistingRow, MessageType.Warning);
			}
			if (!IsFilterParamsValuesCorrect) {
				Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessageTextFilterParamsEmpty, MessageType.Warning);
			}
			
			return true;
		}

		public virtual void SetFilterEditEnabled(bool isEnabled) {
			Page.FilterEdit.Enabled = isEnabled;
		}

		public virtual void ResetControlValues() {
			Page.IsMatchConditionsEdit.SuspendAjaxEvents();
			Page.IsMatchConditionsEdit.Checked = false;
			Page.FilterEdit.Enabled = false;
			var filterEditGroup = Page.EntityDataSource.FindFiltersGroupByName(Page.FilterEdit.FilterEditGroupName);
			filterEditGroup.Clear();
			Page.IsMatchConditionsEdit.ResumeAjaxEvents();
			Page.GenerateDecisionsFromColumnEdit.SuspendAjaxEvents();
			Page.GenerateDecisionsFromColumnEdit.Checked = false;
			Page.DecisionalColumnEdit.SetEnabled(false);
			Page.DecisionalColumnEdit.Clear();
			Page.GenerateDecisionsFromColumnEdit.ResumeAjaxEvents();
			if (EntitySchemaUId != Guid.Empty) {
				ISchemaManagerItem<EntitySchema> entitySchemaItem = GetEntitySchemaItem();
				Page.ObjectEdit.SetValueAndText(entitySchemaItem.Id, entitySchemaItem.Caption);
				Page.NewRecordEdit.Enabled = true;
				Page.ExistingRecordEdit.Enabled = true;
			} else {
				Page.ObjectEdit.Clear();
				Page.NewRecordEdit.Enabled = false;
				Page.ExistingRecordEdit.Enabled = false;
				Page.NewRecordEdit.Checked = false;
				Page.ExistingRecordEdit.Checked = false;
				Page.RecordIdEdit.Enabled = false;
				Page.FilterEdit.Enabled = false;
				Page.IsMatchConditionsEdit.Enabled = false;
				Page.GenerateDecisionsFromColumnEdit.Enabled =false;
				Page.DecisionalColumnEdit.Enabled = false;
			}
			Page.RecordIdEdit.ParameterValue = new ProcessSchemaParameterValue() {
				DataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("Lookup").UId,
				ReferenceSchemaUId = EntitySchemaUId,
				SchemaUId = EditSchemaUId,
				SchemaManagerName = EditSchemaManagerName
			};
			UserConnection.SessionData[ColumnValuesContextKey] = new Dictionary<string, ProcessSchemaParameterValue>();
		}

		public virtual StructureExplorer GetColumnExplorer() {
			if (!IsColumnExplorerCreated) {
				CreateColumnExplorer();
			}
			
			return (StructureExplorer)ColumnExplorer;
		}

		public virtual void ColumnExplorer_EditComplete(object sender, AjaxEventArgs e) {
			var column = (JObject)Json.Deserialize(e.ExtraParameters["itemsInfo"]);
			
			Page.DecisionalColumnEdit.Text = column.Value<string>("caption");
			DecisionalColumnMetaPath = column.Value<string>("metaPath");
		}

		public virtual void OpenColumnExplorer() {
			if (EntitySchemaUId == Guid.Empty) {
				return;
			}
			
			var columnExplorer = GetColumnExplorer();
			if (columnExplorer == null) {
				return;
			}
			
			columnExplorer.ShowEditWindow(EntitySchemaUId, DecisionalColumnMetaPath);
		}

		public virtual void CreateColumnExplorer() {
			var columnExplorer = new StructureExplorer(
				Page.TopControlLayout, "ColumnExplorer", false, true, null);
			
			columnExplorer.AjaxEvents.EditComplete.Event += ColumnExplorer_EditComplete;
			columnExplorer.AjaxEvents.EditComplete.ExtraParameters.Add(
				new UIControls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw));	
			
			columnExplorer.IncludedDataValueTypes.Clear();
			columnExplorer.IncludedDataValueTypes.Add(UserConnection.
				DataValueTypeManager.GetItemByName("Lookup").UId, Guid.Empty);
			
			if (!IsColumnExplorerCreated) {
				columnExplorer.Register();
			}
			
			ColumnExplorer = columnExplorer;
			IsColumnExplorerCreated = true;
		}

		public virtual void CreateColumnValuesVds() {
			/*
			var vds = new VirtualDataSource() {
				ID = "ColumnValuesVds"
			};
			Page.PageContainer.Controls.Add(vds);
			
			// Set vds Id for calendar tree grid
			Page.ColumnValuesTreeGrid.DataSourceId = vds.ID;
			
			DataSourceStructure vdsStructure = vds.DefStructure;
			
			vdsStructure.PrimaryColumnName = "Id";
			vdsStructure.PrimaryDisplayColumnName = "Name";
			
			var guidDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Guid");
			var maxSizeTextDvt = UserConnection.DataValueTypeManager.GetInstanceByName("MaxSizeText");
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Id",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = guidDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "MetaPath",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Name",
				Caption = CaptionColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Value",
				Caption = ValueColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
			*/
		}

		public virtual void PrepareEntitiesForPages() {
			var sysModuleFolderId = new Guid("F330F0C2-3EE4-4A73-9AC9-8439543CA19B");
			var GuidTypeName = "Guid";
			var entitySchemaUIdSelect = (Select)new Select(UserConnection)
				.Column("UId")
				.From("SysSchema")
				.Where("ManagerName").IsEqual(new QueryParameter("EntitySchemaManager", "EntitySchemaManager"))
				.And("ExtendParent").IsEqual(new QueryParameter("ExtendParent", false));
			entitySchemaUIdSelect.IsDistinct = true;
			var clientUnitSchemaUIdSelect = (Select)new Select(UserConnection)
				.Column("UId")
				.From("SysSchema")
				.Where("ManagerName").IsEqual(new QueryParameter("ClientUnitSchemaManager", "ClientUnitSchemaManager"))
				.And("ExtendParent").IsEqual(new QueryParameter("ExtendParent1", false));
			clientUnitSchemaUIdSelect.IsDistinct = true;
			var cardSchemaUIdEntitySchemaUIdTiesSelect =
				(Select)new Select(UserConnection)
					.Column("SysModuleEdit", "CardSchemaUId").As("EditCardSchemaUId")
					.Column("SysModuleEdit", "TypeColumnValue").As("TypeColumnUId")
					.Column("SysModuleEntity", "SysEntitySchemaUId").As("EntitySchemaUId")
				.From("SysModule")
				.Join(JoinType.LeftOuter, "SysModuleEdit")
					.On("SysModuleEdit", "SysModuleEntityId").IsEqual("SysModule", "SysModuleEntityId")
				.Join(JoinType.LeftOuter, "SysModuleEntity")
					.On("SysModuleEntity", "Id").IsEqual("SysModuleEdit", "SysModuleEntityId")
				.Where("SysModuleEdit", "CardSchemaUId").Not().IsNull()
					.And("SysModuleEntity", "SysEntitySchemaUId").Not().IsNull()
					.And("SysModuleEntity", "SysEntitySchemaUId").In(entitySchemaUIdSelect)
					.And("SysModuleEdit", "CardSchemaUId").In(clientUnitSchemaUIdSelect)
					.And("SysModule", "Code").IsNotEqual(Column.Parameter("SysProcessLog"));
			cardSchemaUIdEntitySchemaUIdTiesSelect.InitializeParameters();
			var cardSchemaUIdEntitySchemaUIdTies = new Dictionary<object, List<object>>(32);
			var editCardSchemaUIdPageTypeUIdTies = new Dictionary<Guid, Guid>(32);
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = cardSchemaUIdEntitySchemaUIdTiesSelect.ExecuteReader(dbExecutor)) {
					while (dataReader.Read()) {
						var entitySchemaUId = dataReader.GetColumnValue<Guid>("EntitySchemaUId");
						var editCardSchemaUId = dataReader.GetColumnValue<Guid>("EditCardSchemaUId");
						var typeColumnUId = dataReader.GetColumnValue<Guid>("TypeColumnUId");
						if (!typeColumnUId.IsEmpty()) {
							editCardSchemaUIdPageTypeUIdTies[editCardSchemaUId] = typeColumnUId;
						}
						cardSchemaUIdEntitySchemaUIdTies[editCardSchemaUId] = new List<object> { entitySchemaUId };
					}
				}
			}
			EntitiesForPages = cardSchemaUIdEntitySchemaUIdTies;
			EditCardSchemaUIdPageTypeUIdTies = editCardSchemaUIdPageTypeUIdTies;
		}

		public virtual Guid GetDeafLookupEditPageId() {
			var pageSchemaId = Terrasoft.Core.Configuration.SysSettings.GetValue(
				UserConnection, "DefLookupEditPageSchemaUId");
				
			if (pageSchemaId == null){
				return Guid.Empty;
			} else {
				return new Guid(pageSchemaId.ToString());
			}
		}

		public virtual void ConfigureFilterEdit() {
			Page.FilterEdit.SetProcessSchema(FindDesignedProcessSchema());
		}

		public virtual bool IsEntitySchemaNeedInChangesForListeningByProcess() {
			/*
			if (!IsEntitySchemaChanged) {
				return false;
			}		
			*/
			if (EntitySchemaUId.Equals(Guid.Empty)) {
				return false;
			}
			
			var columnName = UserConnection.IProcessEngine.ProcessListenersColumnName;
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var desSchema = (ISchemaManagerItem)entitySchemaManager.FindItemByUId(EntitySchemaUId);
			var desSchemaItem = entitySchemaManager.DesignItem(UserConnection, desSchema.UId);
			var schema = (EntitySchema)desSchemaItem.Instance;
			return schema.Columns.FindByColumnValueName(columnName) == null;
		}

		public virtual List<Guid> GetNotNullColumnIdList() {
			var result = new List<Guid>();
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			foreach(var column in entitySchema.Columns) {
				if (!entitySchema.PrimaryColumn.UId.Equals(column.UId) 
						&& column.IsDBRequirement
						&& !column.HasDefValue) {
					result.Add(column.UId);
				}
			}
			
			return result;
		}

		public virtual List<QueryParameter> GetEntityIdsWithoutPrcListenersColumn() {
			var manager = UserConnection.EntitySchemaManager;
			var columnName = UserConnection.IProcessEngine.ProcessListenersColumnName;
			var entityIds = new List<QueryParameter>();
			foreach (var item in manager.GetItems()) {
				var entitySchema = manager.FindInstanceByUId(item.UId);
				if(entitySchema != null && entitySchema.Columns.FindByName(columnName) == null) {
					entityIds.Add(new QueryParameter(item.UId));
				}
			}
			
			return entityIds;
		}

		public virtual void EnableControls() {
			bool isPageEditFilled = (Guid)Page.PageEdit.Value != Guid.Empty;
			Page.ObjectEdit.Enabled = isPageEditFilled;
			Page.NewRecordEdit.Enabled = isPageEditFilled;
			Page.ExistingRecordEdit.Enabled = isPageEditFilled;
			Page.GenerateDecisionsFromColumnEdit.Enabled = isPageEditFilled;
			Page.DecisionalColumnEdit.Enabled = Page.GenerateDecisionsFromColumnEdit.Checked && isPageEditFilled;
			Page.ExploreButton.Enabled = Page.GenerateDecisionsFromColumnEdit.Checked && isPageEditFilled;
			Page.IsMatchConditionsEdit.Enabled = isPageEditFilled;
			Page.FilterEdit.Enabled = Page.IsMatchConditionsEdit.Checked && isPageEditFilled;
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			Dictionary<string, Terrasoft.UI.WebControls.WebControl> activityControlsBinding = GetActivityControlsBinding();
			var openEditPageControlsBinding = new Dictionary<string, Terrasoft.UI.WebControls.WebControl> {
				{ "IsMatchConditions", Page.IsMatchConditionsEdit },
				{ "RecordId", Page.RecordIdEdit },
				{ "GenerateDecisionsFromColumn", Page.GenerateDecisionsFromColumnEdit }
			};
			foreach(KeyValuePair<string, Terrasoft.UI.WebControls.WebControl> activityControlBinding in activityControlsBinding) {
				openEditPageControlsBinding.Add(activityControlBinding.Key, activityControlBinding.Value);
			}
			return openEditPageControlsBinding;
		}

		public virtual Dictionary<string, ProcessSchemaParameterValue> GetColumnValues() {
			return UserConnection.SessionData[ColumnValuesContextKey] as Dictionary<string, ProcessSchemaParameterValue>;
		}

		public virtual void SetControlsEnabledProperty(bool isEnabled) {
			bool isNotEnabled = !isEnabled;
			bool isNotEmptyEntitySchemaUId = EntitySchemaUId != Guid.Empty;
			Page.SetDefaultColumnValuesButton.Enabled = isEnabled && isNotEmptyEntitySchemaUId;
			bool isEnabledEditExistingRecordControls = Page.ExistingRecordEdit.Checked && isNotEnabled && isNotEmptyEntitySchemaUId;
			Page.RecordIdEdit.Enabled = isEnabledEditExistingRecordControls;
			/*
			Page.IsMatchConditionsEdit.Enabled = isEnabledEditExistingRecordControls;
			Page.FilterEdit.Enabled = Page.IsMatchConditionsEdit.Enabled && Page.IsMatchConditionsEdit.Checked;
			*/
		}

		public virtual ISchemaManagerItem<EntitySchema> GetEntitySchemaItem() {
			return UserConnection.EntitySchemaManager.GetItemByUId(EntitySchemaUId);
		}

		public virtual bool TryFetchClientUnitSchemaFromDb(out VwSysClientUnitSchema clientUnitSchema) {
			clientUnitSchema = new VwSysClientUnitSchema(UserConnection);
			var conditions = new Dictionary<string, object>() {
				{ "UId", PageSchemaId },
				{ "SysWorkspace", UserConnection.Workspace.Id}
			};
			return clientUnitSchema.FetchFromDB(conditions);
		}

		public virtual void SetEnabledActivityTabControls(Guid entitySchemaUId) {
			if (entitySchemaUId == Guid.Empty) {
				return;
			}
			bool isEnabled = UserConnection.EntitySchemaManager.GetItemByUId(entitySchemaUId).Name != "Activity";
			Page.ActivityParametersTab.Enabled = isEnabled;
			Page.StartInEdit.Enabled = isEnabled;
			Page.StartInPeriodEdit.Enabled = isEnabled;
			Page.DurationEdit.Enabled = isEnabled;
			Page.DurationPeriodEdit.Enabled = isEnabled;
			Page.RemindBeforeEdit.Enabled = isEnabled;
			Page.RemindBeforePeriodEdit.Enabled = isEnabled;
			Page.OwnerEdit.Enabled = isEnabled;
			Page.ExecutionContextEdit.Enabled = isEnabled;
			Page.LeadEdit.Enabled = isEnabled;
			Page.AccountEdit.Enabled = isEnabled;
			Page.ContactEdit.Enabled = isEnabled;
			Page.OpportunityEdit.Enabled = isEnabled;
			Page.DocumentEdit.Enabled = isEnabled;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpenEditPageTabPanelTabChange":
							if (ActivatedEventElements.Contains("OpenEditPageTabPanelTabChangeStartMessage")) {
							context.QueueTasks.Enqueue("OpenEditPageTabPanelTabChangeStartMessage");
						}
						break;
					case "ObjectEditChange":
							if (ActivatedEventElements.Contains("ObjectEditChange_StartMessage")) {
							context.QueueTasks.Enqueue("ObjectEditChange_StartMessage");
						}
						break;
					case "NewRecordEditCheck":
							if (ActivatedEventElements.Contains("NewRecordEditCheckStartMessage")) {
							context.QueueTasks.Enqueue("NewRecordEditCheckStartMessage");
						}
						break;
					case "ExistingRecordEditCheck":
							if (ActivatedEventElements.Contains("ExistingRecordEditCheck_StartMessage")) {
							context.QueueTasks.Enqueue("ExistingRecordEditCheck_StartMessage");
						}
						break;
					case "SetDefaultColumnValuesButtonClick":
							if (ActivatedEventElements.Contains("SetDefaultColumnValuesButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("SetDefaultColumnValuesButtonClickStartMessage");
						}
						break;
					case "ExploreButtonClick":
							if (ActivatedEventElements.Contains("ExploreButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("ExploreButtonClickStartMessage");
						}
						break;
					case "GenerateDecisionsFromColumnEditCheck":
							if (ActivatedEventElements.Contains("GenerateDecisionsFromColumnEditCheckStartMessage")) {
							context.QueueTasks.Enqueue("GenerateDecisionsFromColumnEditCheckStartMessage");
						}
						break;
					case "IsMatchConditionsEditCheck":
							if (ActivatedEventElements.Contains("IsMatchConditionsEditCheckStartMessage")) {
							context.QueueTasks.Enqueue("IsMatchConditionsEditCheckStartMessage");
						}
						break;
					case "PageEditChange":
							if (ActivatedEventElements.Contains("ObjectEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("ObjectEditChangeStartMessage");
						}
						break;
					case "YESChangeEntitySchemaOnSave":
							if (ActivatedEventElements.Contains("YESChangeEntitySchemaOnSave_StartMessage")) {
							context.QueueTasks.Enqueue("YESChangeEntitySchemaOnSave_StartMessage");
						}
						break;
					case "ChangeSchemaEntityNoMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityNoMessageStartMessage")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityNoMessageStartMessage");
						}
						break;
					case "ChangeSchemaEntityYesMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityYesMessageStartMessage")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityYesMessageStartMessage");
						}
						break;
					case "NOChangeEntitySchemaOnSave":
							if (ActivatedEventElements.Contains("NOChangeEntitySchemaOnSave_StartMessage")) {
							context.QueueTasks.Enqueue("NOChangeEntitySchemaOnSave_StartMessage");
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
							if (ActivatedEventElements.Contains("PageLoqdCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoqdCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickOpenEditPageStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickOpenEditPageStartMessage");
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
			if (EditCardSchemaUIdPageTypeUIdTies != null) {
				if (EditCardSchemaUIdPageTypeUIdTies.GetType().IsSerializable ||
					EditCardSchemaUIdPageTypeUIdTies.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EditCardSchemaUIdPageTypeUIdTies", EditCardSchemaUIdPageTypeUIdTies, null);
				}
			}
			if (!HasMapping("IsChangingPageSchema") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsChangingPageSchema", IsChangingPageSchema, false);
			}
			if (!HasMapping("IsChangingEntitySchema") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsChangingEntitySchema", IsChangingEntitySchema, false);
			}
			if (!HasMapping("InsertedColumnValueKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("InsertedColumnValueKey", InsertedColumnValueKey, null);
			}
			if (!HasMapping("IsFilterParamsValuesCorrect") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsFilterParamsValuesCorrect", IsFilterParamsValuesCorrect, false);
			}
			if (!HasMapping("IsDataValid_ExistingRow") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDataValid_ExistingRow", IsDataValid_ExistingRow, false);
			}
			if (!HasMapping("IsDataValid_NewRow") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDataValid_NewRow", IsDataValid_NewRow, false);
			}
			if (!HasMapping("IsEntitySchemaChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEntitySchemaChanged", IsEntitySchemaChanged, false);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (FilterEditSchemaExplorer != null) {
				if (FilterEditSchemaExplorer.GetType().IsSerializable ||
					FilterEditSchemaExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("FilterEditSchemaExplorer", FilterEditSchemaExplorer, null);
				}
			}
			if (!HasMapping("FilterUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FilterUId", FilterUId, Guid.Empty);
			}
			if (!HasMapping("FilterEditSchemaExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FilterEditSchemaExplorerCreated", FilterEditSchemaExplorerCreated, false);
			}
			if (!HasMapping("PageSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PageSchemaId", PageSchemaId, Guid.Empty);
			}
			if (EntitiesForPages != null) {
				if (EntitiesForPages.GetType().IsSerializable ||
					EntitiesForPages.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EntitiesForPages", EntitiesForPages, null);
				}
			}
			if (!HasMapping("ColumnValuesContextKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnValuesContextKey", ColumnValuesContextKey, null);
			}
			if (!HasMapping("DecisionalColumnMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DecisionalColumnMetaPath", DecisionalColumnMetaPath, null);
			}
			if (!HasMapping("IsColumnExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsColumnExplorerCreated", IsColumnExplorerCreated, false);
			}
			if (!HasMapping("EntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess : OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<Terrasoft.WebApp.OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl>
	{

		public OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout OpenEditPageControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("OpenEditPageControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel OpenEditPageTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("OpenEditPageTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab GeneralParametersTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("GeneralParametersTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout EntityPageControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("EntityPageControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit PageEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("PageEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ObjectEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton NewRecordEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("NewRecordEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout SetDefColumnValuesControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("SetDefColumnValuesControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SetDefaultColumnValuesButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SetDefaultColumnValuesButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton ExistingRecordEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("ExistingRecordEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout EditExistingEntityControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("EditExistingEntityControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit RecordIdEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("RecordIdEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsMatchConditionsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsMatchConditionsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("FilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox GenerateDecisionsFromColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("GenerateDecisionsFromColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CreateResultListByColumnControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CreateResultListByColumnControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit DecisionalColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("DecisionalColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ExploreButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ExploreButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab ActivityParametersTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("ActivityParametersTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("EntityDataSource", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			OpenEditPageTabPanel.AjaxEvents.TabChange.Event += OpenEditPageTabPanelTabChange;
			PageEdit.AjaxEvents.Change.Event += PageEditChange;
			ObjectEdit.AjaxEvents.Change.Event += ObjectEditChange;
			NewRecordEdit.AjaxEvents.Check.Event += NewRecordEditCheck;
			SetDefaultColumnValuesButton.AjaxEvents.Click.Event += SetDefaultColumnValuesButtonClick;
			ExistingRecordEdit.AjaxEvents.Check.Event += ExistingRecordEditCheck;
			IsMatchConditionsEdit.AjaxEvents.Check.Event += IsMatchConditionsEditCheck;
			GenerateDecisionsFromColumnEdit.AjaxEvents.Check.Event += GenerateDecisionsFromColumnEditCheck;
			ExploreButton.AjaxEvents.Click.Event += ExploreButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			OpenEditPageTabPanel.AjaxEvents.TabChange.Event -= OpenEditPageTabPanelTabChange;
			PageEdit.AjaxEvents.Change.Event -= PageEditChange;
			ObjectEdit.AjaxEvents.Change.Event -= ObjectEditChange;
			NewRecordEdit.AjaxEvents.Check.Event -= NewRecordEditCheck;
			SetDefaultColumnValuesButton.AjaxEvents.Click.Event -= SetDefaultColumnValuesButtonClick;
			ExistingRecordEdit.AjaxEvents.Check.Event -= ExistingRecordEditCheck;
			IsMatchConditionsEdit.AjaxEvents.Check.Event -= IsMatchConditionsEditCheck;
			GenerateDecisionsFromColumnEdit.AjaxEvents.Check.Event -= GenerateDecisionsFromColumnEditCheck;
			ExploreButton.AjaxEvents.Click.Event -= ExploreButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection);
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

		public virtual void OpenEditPageTabPanelTabChange(object sender, EventArgs e) {
			object result = ThrowEvent("OpenEditPageTabPanelTabChange");
		}

		public virtual void PageEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("PageEditChange");
		}

		public virtual void ObjectEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ObjectEditChange");
		}

		public virtual void NewRecordEditCheck(object sender, EventArgs e) {
			object result = ThrowEvent("NewRecordEditCheck");
		}

		public virtual void SetDefaultColumnValuesButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SetDefaultColumnValuesButtonClick");
		}

		public virtual void ExistingRecordEditCheck(object sender, EventArgs e) {
			object result = ThrowEvent("ExistingRecordEditCheck");
		}

		public virtual void IsMatchConditionsEditCheck(object sender, EventArgs e) {
			object result = ThrowEvent("IsMatchConditionsEditCheck");
		}

		public virtual void GenerateDecisionsFromColumnEditCheck(object sender, EventArgs e) {
			object result = ThrowEvent("GenerateDecisionsFromColumnEditCheck");
		}

		public virtual void ExploreButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ExploreButtonClick");
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
			SchemaName = "OpenEditPageUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			UId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("36333446-62d5-48ed-92c3-942fdbff2f6a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsColumnExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cf3775f7-b219-4ab4-8299-a0173bea49a9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsColumnExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("73982c5c-835a-4441-8b2d-82a6b7f3b4c7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ColumnExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDecisionalColumnMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b52ff499-58b8-43c4-bea7-951e7226d852"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"DecisionalColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnValuesContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a02e4095-41f8-4fca-b38c-5a84e10c618e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ColumnValuesContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitiesForPagesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("782eaf3d-38b1-45c1-8c2c-463ce59e6330"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EntitiesForPages",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePageSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("532e04dc-c2a3-49fc-9ed1-d43ee8ba3fbe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"PageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterEditSchemaExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e70e40f0-fe01-4ac7-8525-c40db27bb109"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"FilterEditSchemaExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e81efd52-3ce2-402d-8b08-5fb91dd30913"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"FilterUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterEditSchemaExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("16a7dd14-9a40-4c91-b157-cf72fe0c970b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"FilterEditSchemaExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("09c43afa-9440-47cf-9214-9655bfe4eafd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEntitySchemaChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9d6fff6-2147-4364-aaff-e23b304cf6cd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsEntitySchemaChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDataValid_NewRowParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c7f11728-2e32-45b5-97ed-9dffe295b23a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsDataValid_NewRow",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDataValid_ExistingRowParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("38715ee3-c89a-47ec-ac8d-5c762c9e139d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsDataValid_ExistingRow",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsFilterParamsValuesCorrectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("25599e26-ea77-4b17-9768-6bf7b55f9964"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsFilterParamsValuesCorrect",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInsertedColumnValueKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a41dcc17-10de-4afd-b212-87e84070222a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"InsertedColumnValueKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsChangingEntitySchemaParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3776bbbd-d8a5-400f-9a28-5cc7229f280f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsChangingEntitySchema",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsChangingPageSchemaParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b9e5a4cf-fba0-425c-a2ec-69081f2207c9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsChangingPageSchema",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditCardSchemaUIdPageTypeUIdTiesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("488ad1d0-9707-4f4e-a204-1a877be6e129"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EditCardSchemaUIdPageTypeUIdTies",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateIsColumnExplorerCreatedParameter());
			Parameters.Add(CreateColumnExplorerParameter());
			Parameters.Add(CreateDecisionalColumnMetaPathParameter());
			Parameters.Add(CreateColumnValuesContextKeyParameter());
			Parameters.Add(CreateEntitiesForPagesParameter());
			Parameters.Add(CreatePageSchemaIdParameter());
			Parameters.Add(CreateFilterEditSchemaExplorerCreatedParameter());
			Parameters.Add(CreateFilterUIdParameter());
			Parameters.Add(CreateFilterEditSchemaExplorerParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateIsEntitySchemaChangedParameter());
			Parameters.Add(CreateIsDataValid_NewRowParameter());
			Parameters.Add(CreateIsDataValid_ExistingRowParameter());
			Parameters.Add(CreateIsFilterParamsValuesCorrectParameter());
			Parameters.Add(CreateInsertedColumnValueKeyParameter());
			Parameters.Add(CreateIsChangingEntitySchemaParameter());
			Parameters.Add(CreateIsChangingPageSchemaParameter());
			Parameters.Add(CreateEditCardSchemaUIdPageTypeUIdTiesParameter());
		}

		protected virtual void InitializeOpenSpecifyColumnValuesPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("df5ee9d1-a657-4b08-9a6c-5dc533e1be27"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("6ef6072c-2001-4af8-bb2c-0e1a105a4e78"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("9065fcce-28e8-4ed9-bcb6-8419212ddadb"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("de06b9ec-028f-4802-8dcf-d06f8caeafa9"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("0d1c605e-4ca3-45d2-8719-c847c4e72947"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("714ba5b6-bdda-4ae2-b37a-4fc4423dab47"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("30b16d0d-dc17-4fca-8798-cbe2cc6f34ea"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("cfd0bcfb-1198-4334-afd6-da8c1c746031"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("629f0b36-64df-4dbe-9980-a74e0adc6b31"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("60013da6-fedc-449b-a960-1b82ddaf5034"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("de1f7556-1514-4f72-b77d-0345d495d841"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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
				UId = new Guid("b1c51350-938d-48c1-a8f8-eb2f0d2e1e05"),
				ContainerUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
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

		protected virtual void InitializeChangeSchemaEntityUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("08b10b2c-01dc-4fb1-826e-f5c82bf0cdea"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Page",
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
				UId = new Guid("dda342e7-450f-4737-8e41-68c2f05a6e3f"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Icon",
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
				UId = new Guid("d629ad44-3535-4578-a28d-37598ff38bbe"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Buttons",
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
				UId = new Guid("5cbc38f8-4b3f-48f5-8341-ab748c594447"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"WindowCaption",
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
				UId = new Guid("8977b561-77d4-4b77-b33a-a5b7a35792d0"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"MessageText",
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
				UId = new Guid("feb02ffd-7c41-4b59-9e39-77ffca30ece3"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ResponseMessages",
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
				UId = new Guid("a23c93da-9ff0-49f4-b2f6-f3d361ca3688"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ProcessInstanceId",
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
				UId = new Guid("0aff2b67-7a75-4155-a0d3-553654619f4b"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
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
		}

		protected virtual void InitializeShowWarningChangeEntitySchemaOnSaveMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e0018757-8c24-4c1d-a8bf-cc342e81ecca"),
				ContainerUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Page",
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
				UId = new Guid("b4711a59-23b5-493d-b4c6-c89600e9abe2"),
				ContainerUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Icon",
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
				UId = new Guid("45ed2dff-1d51-44c9-81a8-0463c458b103"),
				ContainerUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Buttons",
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
				UId = new Guid("51f28740-353c-4f53-b414-604b347b9810"),
				ContainerUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"WindowCaption",
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
				UId = new Guid("b6635672-d635-47d8-ba67-3dd640a6bc9a"),
				ContainerUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"MessageText",
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
				UId = new Guid("68bd1e40-96f7-4121-ade5-1795edbaed61"),
				ContainerUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ResponseMessages",
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
				UId = new Guid("5101e220-a69f-484a-bd4d-2bfb19d254e6"),
				ContainerUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ProcessInstanceId",
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
				UId = new Guid("9d20c212-0383-447a-9953-6a29ce525ed8"),
				ContainerUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
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
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaOpenEditPageLaneSet = CreateOpenEditPageLaneSetLaneSet();
			LaneSets.Add(schemaOpenEditPageLaneSet);
			ProcessSchemaLane schemaOpenEditPageTabPanelTabChangeLane = CreateOpenEditPageTabPanelTabChangeLaneLane();
			schemaOpenEditPageLaneSet.Lanes.Add(schemaOpenEditPageTabPanelTabChangeLane);
			ProcessSchemaEventSubProcess openeditpagetabpaneltabchangeeventsubprocess = CreateOpenEditPageTabPanelTabChangeEventSubProcessEventSubProcess();
			FlowElements.Add(openeditpagetabpaneltabchangeeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess20 = CreateEventSubProcess20EventSubProcess();
			FlowElements.Add(eventsubprocess20);
			ProcessSchemaEventSubProcess eventsubprocess16 = CreateEventSubProcess16EventSubProcess();
			FlowElements.Add(eventsubprocess16);
			ProcessSchemaEventSubProcess eventsubprocess21 = CreateEventSubProcess21EventSubProcess();
			FlowElements.Add(eventsubprocess21);
			ProcessSchemaEventSubProcess setdefaultcolumnvaluesbuttonclickeventsubprocess = CreateSetDefaultColumnValuesButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(setdefaultcolumnvaluesbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess openeditpageeventsubprocess8 = CreateOpenEditPageEventSubProcess8EventSubProcess();
			FlowElements.Add(openeditpageeventsubprocess8);
			ProcessSchemaEventSubProcess openeditpageeventsubprocess7 = CreateOpenEditPageEventSubProcess7EventSubProcess();
			FlowElements.Add(openeditpageeventsubprocess7);
			ProcessSchemaEventSubProcess openeditpageeventsubprocess5 = CreateOpenEditPageEventSubProcess5EventSubProcess();
			FlowElements.Add(openeditpageeventsubprocess5);
			ProcessSchemaEventSubProcess openeditpageeventsubprocess6 = CreateOpenEditPageEventSubProcess6EventSubProcess();
			FlowElements.Add(openeditpageeventsubprocess6);
			ProcessSchemaEventSubProcess openeditpageeventsubprocess4 = CreateOpenEditPageEventSubProcess4EventSubProcess();
			FlowElements.Add(openeditpageeventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess19 = CreateEventSubProcess19EventSubProcess();
			FlowElements.Add(eventsubprocess19);
			ProcessSchemaEventSubProcess openeditpageeventsubprocess2 = CreateOpenEditPageEventSubProcess2EventSubProcess();
			FlowElements.Add(openeditpageeventsubprocess2);
			ProcessSchemaEventSubProcess openeditpageeventsubprocess3 = CreateOpenEditPageEventSubProcess3EventSubProcess();
			FlowElements.Add(openeditpageeventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess18 = CreateEventSubProcess18EventSubProcess();
			FlowElements.Add(eventsubprocess18);
			ProcessSchemaStartMessageEvent openeditpagetabpaneltabchangestartmessage = CreateOpenEditPageTabPanelTabChangeStartMessageStartMessageEvent();
			openeditpagetabpaneltabchangeeventsubprocess.FlowElements.Add(openeditpagetabpaneltabchangestartmessage);
			ProcessSchemaScriptTask openeditpagetabpaneltabchangescripttask = CreateOpenEditPageTabPanelTabChangeScriptTaskScriptTask();
			openeditpagetabpaneltabchangeeventsubprocess.FlowElements.Add(openeditpagetabpaneltabchangescripttask);
			ProcessSchemaStartMessageEvent objecteditchange_startmessage = CreateObjectEditChange_StartMessageStartMessageEvent();
			eventsubprocess20.FlowElements.Add(objecteditchange_startmessage);
			ProcessSchemaScriptTask objecteditchange_scripttask = CreateObjectEditChange_ScriptTaskScriptTask();
			eventsubprocess20.FlowElements.Add(objecteditchange_scripttask);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			eventsubprocess20.FlowElements.Add(exclusivegateway3);
			ProcessSchemaIntermediateThrowMessageEvent objecteditchange_nochangeentityschemaonsave_intermediatethrowmessageevent = CreateObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess20.FlowElements.Add(objecteditchange_nochangeentityschemaonsave_intermediatethrowmessageevent);
			ProcessSchemaIntermediateThrowMessageEvent objecteditchange_changeschemaentityyesmessage_intermediatethrowmessageevent = CreateObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess20.FlowElements.Add(objecteditchange_changeschemaentityyesmessage_intermediatethrowmessageevent);
			ProcessSchemaScriptTask ischangingentityschemascripttask = CreateIsChangingEntitySchemaScriptTaskScriptTask();
			eventsubprocess20.FlowElements.Add(ischangingentityschemascripttask);
			ProcessSchemaStartMessageEvent newrecordeditcheckstartmessage = CreateNewRecordEditCheckStartMessageStartMessageEvent();
			eventsubprocess16.FlowElements.Add(newrecordeditcheckstartmessage);
			ProcessSchemaScriptTask newrecordeditcheckscripttask = CreateNewRecordEditCheckScriptTaskScriptTask();
			eventsubprocess16.FlowElements.Add(newrecordeditcheckscripttask);
			ProcessSchemaStartMessageEvent existingrecordeditcheck_startmessage = CreateExistingRecordEditCheck_StartMessageStartMessageEvent();
			eventsubprocess21.FlowElements.Add(existingrecordeditcheck_startmessage);
			ProcessSchemaScriptTask existingrecordeditcheckscripttask = CreateExistingRecordEditCheckScriptTaskScriptTask();
			eventsubprocess21.FlowElements.Add(existingrecordeditcheckscripttask);
			ProcessSchemaStartMessageEvent setdefaultcolumnvaluesbuttonclickstartmessage = CreateSetDefaultColumnValuesButtonClickStartMessageStartMessageEvent();
			setdefaultcolumnvaluesbuttonclickeventsubprocess.FlowElements.Add(setdefaultcolumnvaluesbuttonclickstartmessage);
			ProcessSchemaScriptTask setdefaultcolumnvaluesbuttonclickscripttask = CreateSetDefaultColumnValuesButtonClickScriptTaskScriptTask();
			setdefaultcolumnvaluesbuttonclickeventsubprocess.FlowElements.Add(setdefaultcolumnvaluesbuttonclickscripttask);
			ProcessSchemaUserTask openspecifycolumnvaluespage = CreateOpenSpecifyColumnValuesPageUserTask();
			setdefaultcolumnvaluesbuttonclickeventsubprocess.FlowElements.Add(openspecifycolumnvaluespage);
			ProcessSchemaStartMessageEvent explorebuttonclickstartmessage = CreateExploreButtonClickStartMessageStartMessageEvent();
			eventsubprocess11.FlowElements.Add(explorebuttonclickstartmessage);
			ProcessSchemaScriptTask explorebuttonclickscripttask = CreateExploreButtonClickScriptTaskScriptTask();
			eventsubprocess11.FlowElements.Add(explorebuttonclickscripttask);
			ProcessSchemaStartMessageEvent generatedecisionsfromcolumneditcheckstartmessage = CreateGenerateDecisionsFromColumnEditCheckStartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(generatedecisionsfromcolumneditcheckstartmessage);
			ProcessSchemaScriptTask generatedecisionsfromcolumneditcheckscripttask = CreateGenerateDecisionsFromColumnEditCheckScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(generatedecisionsfromcolumneditcheckscripttask);
			ProcessSchemaStartMessageEvent ismatchconditionseditcheckstartmessage = CreateIsMatchConditionsEditCheckStartMessageStartMessageEvent();
			openeditpageeventsubprocess8.FlowElements.Add(ismatchconditionseditcheckstartmessage);
			ProcessSchemaScriptTask ismatchconditionseditcheckscripttask = CreateIsMatchConditionsEditCheckScriptTaskScriptTask();
			openeditpageeventsubprocess8.FlowElements.Add(ismatchconditionseditcheckscripttask);
			ProcessSchemaStartMessageEvent objecteditchangestartmessage = CreateObjectEditChangeStartMessageStartMessageEvent();
			openeditpageeventsubprocess7.FlowElements.Add(objecteditchangestartmessage);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			openeditpageeventsubprocess7.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask scripttaskpreparechangeschemaentityquestion = CreateScriptTaskPrepareChangeSchemaEntityQuestionScriptTask();
			openeditpageeventsubprocess7.FlowElements.Add(scripttaskpreparechangeschemaentityquestion);
			ProcessSchemaUserTask changeschemaentityusermessage = CreateChangeSchemaEntityUserMessageUserTask();
			openeditpageeventsubprocess7.FlowElements.Add(changeschemaentityusermessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			openeditpageeventsubprocess7.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaScriptTask ischangingpageschemascripttask = CreateIsChangingPageSchemaScriptTaskScriptTask();
			openeditpageeventsubprocess7.FlowElements.Add(ischangingpageschemascripttask);
			ProcessSchemaScriptTask changeschemaentityyesmessagescripttask = CreateChangeSchemaEntityYesMessageScriptTaskScriptTask();
			openeditpageeventsubprocess5.FlowElements.Add(changeschemaentityyesmessagescripttask);
			ProcessSchemaStartMessageEvent yeschangeentityschemaonsave_startmessage = CreateYESChangeEntitySchemaOnSave_StartMessageStartMessageEvent();
			openeditpageeventsubprocess5.FlowElements.Add(yeschangeentityschemaonsave_startmessage);
			ProcessSchemaStartMessageEvent changeschemaentitynomessagestartmessage = CreateChangeSchemaEntityNoMessageStartMessageStartMessageEvent();
			openeditpageeventsubprocess6.FlowElements.Add(changeschemaentitynomessagestartmessage);
			ProcessSchemaScriptTask changeschemaentitynomessagescripttask = CreateChangeSchemaEntityNoMessageScriptTaskScriptTask();
			openeditpageeventsubprocess6.FlowElements.Add(changeschemaentitynomessagescripttask);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			openeditpageeventsubprocess4.FlowElements.Add(exclusivegateway2);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclick_yeschangeentityschemaonsave_intermediatethrowmessageevent = CreateOkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			openeditpageeventsubprocess4.FlowElements.Add(okbuttonclick_yeschangeentityschemaonsave_intermediatethrowmessageevent);
			ProcessSchemaScriptTask preparewindowquestiononsave_scripttask = CreatePrepareWindowQuestionOnSave_ScriptTaskScriptTask();
			openeditpageeventsubprocess4.FlowElements.Add(preparewindowquestiononsave_scripttask);
			ProcessSchemaUserTask showwarningchangeentityschemaonsavemessageusertask = CreateShowWarningChangeEntitySchemaOnSaveMessageUserTaskUserTask();
			openeditpageeventsubprocess4.FlowElements.Add(showwarningchangeentityschemaonsavemessageusertask);
			ProcessSchemaStartMessageEvent changeschemaentityyesmessagestartmessage = CreateChangeSchemaEntityYesMessageStartMessageStartMessageEvent();
			openeditpageeventsubprocess4.FlowElements.Add(changeschemaentityyesmessagestartmessage);
			ProcessSchemaScriptTask processpageselect_scripttask = CreateProcessPageSelect_ScriptTaskScriptTask();
			openeditpageeventsubprocess4.FlowElements.Add(processpageselect_scripttask);
			ProcessSchemaStartMessageEvent nochangeentityschemaonsave_startmessage = CreateNOChangeEntitySchemaOnSave_StartMessageStartMessageEvent();
			eventsubprocess19.FlowElements.Add(nochangeentityschemaonsave_startmessage);
			ProcessSchemaScriptTask clearobject_scripttask = CreateClearObject_ScriptTaskScriptTask();
			eventsubprocess19.FlowElements.Add(clearobject_scripttask);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			openeditpageeventsubprocess2.FlowElements.Add(initstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			openeditpageeventsubprocess2.FlowElements.Add(initintermediatethrowmessageevent);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			openeditpageeventsubprocess2.FlowElements.Add(initscripttask);
			ProcessSchemaScriptTask createcontrolsscripttask = CreateCreateControlsScriptTaskScriptTask();
			openeditpageeventsubprocess2.FlowElements.Add(createcontrolsscripttask);
			ProcessSchemaStartMessageEvent pageloqdcompletestartmessage = CreatePageLoqdCompleteStartMessageStartMessageEvent();
			openeditpageeventsubprocess3.FlowElements.Add(pageloqdcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloqdcompleteintermediatethrowmessageevent = CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			openeditpageeventsubprocess3.FlowElements.Add(pageloqdcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			openeditpageeventsubprocess3.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaScriptTask okbuttonclickopeneditpagescripttask = CreateOkButtonClickOpenEditPageScriptTaskScriptTask();
			eventsubprocess18.FlowElements.Add(okbuttonclickopeneditpagescripttask);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclickintermediatethrowmessageevent = CreateOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess18.FlowElements.Add(okbuttonclickintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent okbuttonclickopeneditpagestartmessage = CreateOkButtonClickOpenEditPageStartMessageStartMessageEvent();
			eventsubprocess18.FlowElements.Add(okbuttonclickopeneditpagestartmessage);
			ProcessSchemaScriptTask chackvalidation_scripttask = CreateChackValidation_ScriptTaskScriptTask();
			eventsubprocess18.FlowElements.Add(chackvalidation_scripttask);
			ProcessSchemaExclusiveGateway exclusivegateway4 = CreateExclusiveGateway4ExclusiveGateway();
			eventsubprocess18.FlowElements.Add(exclusivegateway4);
			ProcessSchemaScriptTask warningmessage_scripttask = CreateWarningMessage_ScriptTaskScriptTask();
			eventsubprocess18.FlowElements.Add(warningmessage_scripttask);
			FlowElements.Add(CreateOpenEditPageSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateOpenEditPageSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateOpenEditPageSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateOpenEditPageSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateOpenEditPageSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateOpenEditPageSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateOpenEditPageSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow31SequenceFlow());
			FlowElements.Add(CreateOpenEditPageSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow30SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow34SequenceFlow());
			FlowElements.Add(CreateSequenceFlow38SequenceFlow());
			FlowElements.Add(CreateSequenceFlow32SequenceFlow());
			FlowElements.Add(CreateConditionalFlow5ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow36SequenceFlow());
			FlowElements.Add(CreateSequenceFlow37SequenceFlow());
			FlowElements.Add(CreateOpenEditPageSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow39SequenceFlow());
			FlowElements.Add(CreateOpenEditPageTabPanelTabChange1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
			LocalizableStrings.Add(CreateCaptionColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateValueColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateWarningChangeEntitySchemaOnSaveLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTextNewRowLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTextExistingRowLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTextFilterParamsEmptyLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b7d14295-5ec7-4d62-8c82-c0697824da77"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCaptionColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("08db47de-8e45-4b0e-9d53-d0f25379aafd"),
				Name = "CaptionColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValueColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("162f8a2e-242c-4089-a4a4-54aa02f44c44"),
				Name = "ValueColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningChangeEntitySchemaOnSaveLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0dd6667c-97bf-477a-9c69-89815a2e8d16"),
				Name = "WarningChangeEntitySchemaOnSave",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab230c67-bcec-4424-a848-97bf68525ffb"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTextNewRowLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b8bd7658-e49d-49cc-826d-597975aa0836"),
				Name = "ValidationMessageTextNewRow",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTextExistingRowLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("52e99f6e-5077-4234-b27b-9e10fd83f045"),
				Name = "ValidationMessageTextExistingRow",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTextFilterParamsEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8871b2eb-d5e3-46d1-96d6-777563bfa072"),
				Name = "ValidationMessageTextFilterParamsEmpty",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageSequenceFlow1",
				UId = new Guid("17cec332-3e68-4596-a00a-d58e13cd26f9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(276, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b1b52be0-65ed-4740-b09f-df2d451afc8e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ad2dd160-8b07-4ffc-bd54-08feebe07f29"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageSequenceFlow2",
				UId = new Guid("dcd5b868-52fa-469d-89db-a510404c7e88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(164, 89),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("711ea29e-913b-47a5-8678-5d32ee76fd3e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("01677a75-89bc-4c7b-8d59-c38b77ae5996"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageSequenceFlow3",
				UId = new Guid("8f246b77-7172-4503-b08f-5ef3e8ea1b87"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(155, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6cbd8f75-4830-4bb0-8080-c027c888ce59"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("151d4457-eab8-4547-8bc8-81f9cb4bc4b3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageSequenceFlow4",
				UId = new Guid("ec28097c-6b7f-4208-add5-d4cb0b3b2fc9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(256, 273),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("151d4457-eab8-4547-8bc8-81f9cb4bc4b3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("98d7e503-bc70-4f90-9653-9db8b44ec678"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageSequenceFlow6",
				UId = new Guid("7d88d7bc-d1af-4a9c-aa70-b9970557eb10"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(262, 458),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bd951774-27eb-4e37-b7bb-d202a7a2153c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ca88245-9591-4e41-a639-295bf0bff211"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageSequenceFlow7",
				UId = new Guid("595ad73c-2770-44d5-ac0a-fd9626a2cb6e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(174, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b233931-a7a0-433d-a9f2-f50d61cc6a40"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2666200a-061b-449d-bb9c-c02e0bbb35fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageSequenceFlow9",
				UId = new Guid("1d9ae3c9-adad-4307-b312-9c0ba2aed483"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(494, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b3ff4a1-f642-4c88-a3da-1cb1d8f83d39"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("022eba4b-bcae-434e-99ab-b8f0d4b41fe8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(218, 142),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8574bc6f-d9d4-40c9-af8e-e74c0e88e3ec"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("366d4846-1b35-425a-944f-fa4dee542187"),
				ConditionExpression = @"EntitySchemaUId != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(328, 74),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b3ff4a1-f642-4c88-a3da-1cb1d8f83d39"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("5db85672-97bb-4260-b325-e6d54c876198"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(484, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a0680a3-cb1d-4bac-aabc-17ceadd65837"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6e5f5bd8-e2ba-4f83-8523-ede64aa8c5ce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("5b918fe9-92b3-42b8-b85d-7ffbf66b5321"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2fc49664-cb20-4721-8800-655dddd2796d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b971fcab-e2b3-42f6-bd80-325e113640c9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("884cfa49-2602-4a0f-8497-09ef43f8fd0c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8074a953-d01e-4a59-921f-5ccdcd5b6fd3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c3cb2e09-3b3b-4a25-92c5-8fed53875426"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("1d430985-43cd-4ffc-b675-e94d1c0c47be"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("52dfdc54-c593-4598-85d2-4723e1e4d96a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b1ec650-1ad5-4f2a-94bd-9abc6c51c541"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("e995b388-26a8-4722-9c10-670992202a06"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(276, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01677a75-89bc-4c7b-8d59-c38b77ae5996"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b1b52be0-65ed-4740-b09f-df2d451afc8e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("17d9c260-5c06-4aee-97ff-b7cf84a09468"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("12cc4c0e-52d4-4719-8061-10424e3cbc18"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a57dfa0c-f12e-4ec9-a3ec-c5d4bc54bfb1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow28",
				UId = new Guid("18e7b301-f412-4f60-bae5-bb97a73330bc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(232, 723),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cbca2f3b-34ce-490a-b4e7-a485d6cff867"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c9ad13fa-7f93-465a-ad9b-97adf2cca287"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("aa60037e-92fd-4503-9197-1af09de5dcf2"),
				ConditionExpression = @"IsEntitySchemaNeedInChangesForListeningByProcess()",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(293, 658),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cbca2f3b-34ce-490a-b4e7-a485d6cff867"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("81756ce6-df3d-4e26-a990-e7e1adad9237"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow31SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow31",
				UId = new Guid("e222ac5c-7f78-43ba-9bd9-4ee29cff256b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(443, 658),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("81756ce6-df3d-4e26-a990-e7e1adad9237"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageSequenceFlow8",
				UId = new Guid("1129f837-51e7-4135-b627-558e426b8c6b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(170, 1050),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c66ba53d-1b1b-4d49-96b6-278f05436dc9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a0cec4f-8827-445f-a089-f7a4683e7ff8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow30SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow30",
				UId = new Guid("d80ff0b6-aade-4368-a02f-b6bcbfaf9024"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(174, 538),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd126551-0fb2-4104-9adb-fc52eda2e6fa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aa02346a-cf73-4be7-9d90-6b4456849260"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29",
				UId = new Guid("d145d0bc-f225-4dd8-a20e-71bf49783234"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(444, 958),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2c7daf6d-171b-48d9-a8a4-3515d1a1b0b6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("325354ea-54c2-4375-8d59-00fff1795734"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("efb9efa2-b759-4c2f-9fb0-c48d884e79d8"),
				ConditionExpression = @"(Guid)Page.ObjectEdit.Value == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(327, 69),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("df1194a5-5eec-4f79-a100-0d5b57f00110"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("349d7c57-7730-4ab0-9b68-bbe7b76122f4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("64a1d4cb-219e-414d-a5af-fce2906b0051"),
				ConditionExpression = @"(Guid)Page.ObjectEdit.Value != Guid.Empty && EntitySchemaUId == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(285, 171),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("df1194a5-5eec-4f79-a100-0d5b57f00110"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f909db95-b193-4dc1-848a-c710334f3fbf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow34SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow34",
				UId = new Guid("ffeebe2d-8460-4f0b-b9e5-1630de91b184"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(398, 95),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("349d7c57-7730-4ab0-9b68-bbe7b76122f4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dea9d59c-8b21-4eae-beed-9d7317e85bc1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow38SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow38",
				UId = new Guid("9bb82135-d481-4b90-9ac7-e7debf0b052f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(170, 1050),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a0cec4f-8827-445f-a089-f7a4683e7ff8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cbca2f3b-34ce-490a-b4e7-a485d6cff867"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow32SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow32",
				UId = new Guid("e5a3f1d2-1aee-4840-8248-2da03751c6bd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(217, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a5b8cd7d-b918-4876-b85b-3a5fe128b6fd"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a2c2afd-7462-4844-98cb-c819c8a343b3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow5ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow5",
				UId = new Guid("1ec21bab-08e5-4335-ab58-5d977bf13bfb"),
				ConditionExpression = @"IsDataValid_NewRow && IsDataValid_ExistingRow && IsFilterParamsValuesCorrect",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(370, 2986),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("49f1b70f-4547-45fe-aa26-063d1070c1b9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bd951774-27eb-4e37-b7bb-d202a7a2153c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow36SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow36",
				UId = new Guid("65ee3035-46a3-417c-8b5c-7e4dd8edc574"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(376, 3105),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("49f1b70f-4547-45fe-aa26-063d1070c1b9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("595206a6-3a9a-42ce-8ee7-d970eb4db855"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow37SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow37",
				UId = new Guid("cce08288-df32-4ca0-b484-93eec8e65479"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(285, 3052),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b60261ba-ae4d-406c-a20f-7690cee176f5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("49f1b70f-4547-45fe-aa26-063d1070c1b9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageSequenceFlow5",
				UId = new Guid("52ceedaf-a9da-481f-87e0-dafe6462717a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(160, 3053),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c2f8bbc5-37dd-466c-9fd3-ddb78ce09c53"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b60261ba-ae4d-406c-a20f-7690cee176f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow39SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow39",
				UId = new Guid("a44e36ed-942c-41d0-8068-98c27daa2f12"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4dbdde1-4767-40e9-a634-e19b1c5d6f3c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e9afeaff-53e5-4041-a379-91591c78c7ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateOpenEditPageTabPanelTabChange1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "OpenEditPageTabPanelTabChange1",
				UId = new Guid("48431178-7bd5-4538-b224-3026e4d95420"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("791ec8ec-0b59-4d92-80f4-667a98c282ac"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ade33697-e56a-4be9-881d-9a2bed7bd6f4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("f57a2f24-0a95-49bb-a86a-3247928fd8dd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f2f2b4c-2c72-4b68-b938-993870cfa22e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("05acb539-edf9-4e24-bdb2-8add59496bfa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("65008585-750d-42e7-989c-5a6fec33d841"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(706, 465),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05acb539-edf9-4e24-bdb2-8add59496bfa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("e0d70485-b06e-4bb8-933e-22bd2220cb62"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(174, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2666200a-061b-449d-bb9c-c02e0bbb35fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("afa86550-a781-4b26-866b-8b06b38cfaa4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CurveCenterPosition = new Point(217, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a2c2afd-7462-4844-98cb-c819c8a343b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("df1194a5-5eec-4f79-a100-0d5b57f00110"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateOpenEditPageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaOpenEditPageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ee071d19-aa8f-44b4-ab50-b5d5c7477b6a"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(730, 171),
				UseBackgroundMode = false
			};
			return schemaOpenEditPageLaneSet;
		}

		protected virtual ProcessSchemaLane CreateOpenEditPageTabPanelTabChangeLaneLane() {
			ProcessSchemaLane schemaOpenEditPageTabPanelTabChangeLane = new ProcessSchemaLane(this) {
				UId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ee071d19-aa8f-44b4-ab50-b5d5c7477b6a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageTabPanelTabChangeLane",
				Position = new Point(29, 0),
				Size = new Size(701, 171),
				UseBackgroundMode = false
			};
			return schemaOpenEditPageTabPanelTabChangeLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenEditPageTabPanelTabChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenEditPageTabPanelTabChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c089bc1e-e554-4485-8bb1-93d51f3fdc58"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageTabPanelTabChangeEventSubProcess",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(234, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenEditPageTabPanelTabChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpenEditPageTabPanelTabChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("791ec8ec-0b59-4d92-80f4-667a98c282ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c089bc1e-e554-4485-8bb1-93d51f3fdc58"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OpenEditPageTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageTabPanelTabChangeStartMessage",
				Position = new Point(35, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOpenEditPageTabPanelTabChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ade33697-e56a-4be9-881d-9a2bed7bd6f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c089bc1e-e554-4485-8bb1-93d51f3fdc58"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageTabPanelTabChangeScriptTask",
				Position = new Point(133, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,189,10,194,64,16,132,107,3,121,135,181,9,73,19,176,150,20,106,68,82,121,224,79,127,122,107,88,136,119,178,217,19,69,124,119,189,11,193,198,114,102,190,25,134,46,144,43,221,98,185,189,161,93,27,146,32,246,250,164,180,197,174,92,156,133,238,65,54,214,224,3,170,10,102,144,101,48,109,250,67,143,38,166,36,207,149,179,194,174,235,11,120,165,201,100,135,50,6,181,103,45,228,172,66,38,103,194,250,136,30,117,231,49,47,230,3,95,227,37,26,74,179,190,162,32,71,21,248,124,243,91,27,187,75,178,134,108,155,23,177,254,255,10,84,32,236,241,11,188,211,132,81,60,219,193,248,0,223,31,211,223,240,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess20EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess20 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7fe4fdb3-1770-425d-af95-ac2f30210371"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EventSubProcess20",
				Position = new Point(36, 184),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(553, 235),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess20;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateObjectEditChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a5b8cd7d-b918-4876-b85b-3a5fe128b6fd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7fe4fdb3-1770-425d-af95-ac2f30210371"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectEditChange",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ObjectEditChange_StartMessage",
				Position = new Point(35, 98),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateObjectEditChange_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dea9d59c-8b21-4eae-beed-9d7317e85bc1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7fe4fdb3-1770-425d-af95-ac2f30210371"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ObjectEditChange_ScriptTask",
				Position = new Point(462, 14),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,247,44,118,205,43,201,44,169,12,78,206,72,205,77,116,206,72,204,75,79,77,81,176,85,40,41,42,77,181,230,229,42,74,45,41,45,202,131,240,0,55,23,56,79,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("df1194a5-5eec-4f79-a100-0d5b57f00110"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7fe4fdb3-1770-425d-af95-ac2f30210371"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 84),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("349d7c57-7730-4ab0-9b68-bbe7b76122f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7fe4fdb3-1770-425d-af95-ac2f30210371"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"NOChangeEntitySchemaOnSave",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ObjectEditChange_NOChangeEntitySchemaOnSave_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(371, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f909db95-b193-4dc1-848a-c710334f3fbf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7fe4fdb3-1770-425d-af95-ac2f30210371"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ObjectEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(378, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIsChangingEntitySchemaScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6a2c2afd-7462-4844-98cb-c819c8a343b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7fe4fdb3-1770-425d-af95-ac2f30210371"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsChangingEntitySchemaScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 84),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,118,206,72,204,75,207,204,75,119,205,43,201,44,169,12,78,206,72,205,77,84,176,85,40,41,42,77,181,230,229,42,74,45,41,45,202,131,240,0,167,32,144,228,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fe65d0c2-077b-4f05-ae74-67028fc73064"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EventSubProcess16",
				Position = new Point(35, 445),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(255, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateNewRecordEditCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("12cc4c0e-52d4-4719-8061-10424e3cbc18"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe65d0c2-077b-4f05-ae74-67028fc73064"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"NewRecordEditCheck",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"NewRecordEditCheckStartMessage",
				Position = new Point(28, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateNewRecordEditCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a57dfa0c-f12e-4ec9-a3ec-c5d4bc54bfb1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe65d0c2-077b-4f05-ae74-67028fc73064"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"NewRecordEditCheckScriptTask",
				Position = new Point(147, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,202,207,207,81,200,44,246,75,45,15,74,77,206,47,74,241,205,79,73,85,176,85,8,72,76,79,213,131,11,186,166,100,150,232,57,103,164,38,103,167,166,88,243,114,5,167,150,56,231,231,149,20,229,231,20,187,230,37,38,229,164,166,4,20,229,23,164,22,149,84,106,160,153,164,9,84,93,148,90,82,90,148,167,80,82,84,154,106,13,0,223,54,116,173,110,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess21EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess21 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("30df178a-2ad0-4aa0-944b-42a17dbc70c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EventSubProcess21",
				Position = new Point(35, 606),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess21;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateExistingRecordEditCheck_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d4dbdde1-4767-40e9-a634-e19b1c5d6f3c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("30df178a-2ad0-4aa0-944b-42a17dbc70c6"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ExistingRecordEditCheck",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ExistingRecordEditCheck_StartMessage",
				Position = new Point(36, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateExistingRecordEditCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e9afeaff-53e5-4041-a379-91591c78c7ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("30df178a-2ad0-4aa0-944b-42a17dbc70c6"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ExistingRecordEditCheckScriptTask",
				Position = new Point(148, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,193,106,194,64,16,134,207,6,242,14,235,45,66,201,11,88,189,196,156,74,33,52,216,75,241,48,238,254,234,210,205,78,153,157,160,65,250,238,174,94,197,211,28,126,190,111,190,61,115,48,62,181,23,159,212,199,227,23,44,139,107,157,215,79,118,48,43,211,209,17,245,243,90,55,39,216,95,184,101,89,244,208,134,163,10,135,212,70,218,7,184,78,248,15,162,83,53,127,37,94,100,206,31,76,245,114,55,215,178,152,109,19,36,171,35,172,122,142,117,143,148,242,221,144,210,79,195,97,28,226,55,133,17,233,254,29,23,253,192,180,203,193,17,103,179,241,15,130,100,122,79,42,217,254,102,114,147,205,124,111,79,24,168,35,161,1,10,121,8,214,213,61,231,191,44,4,58,74,52,42,35,150,55,150,164,198,62,24,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSetDefaultColumnValuesButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSetDefaultColumnValuesButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7808c037-d4df-4301-a794-f523196669bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"SetDefaultColumnValuesButtonClickEventSubProcess",
				Position = new Point(36, 774),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(353, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSetDefaultColumnValuesButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSetDefaultColumnValuesButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2f2f2b4c-2c72-4b68-b938-993870cfa22e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7808c037-d4df-4301-a794-f523196669bc"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SetDefaultColumnValuesButtonClick",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"SetDefaultColumnValuesButtonClickStartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetDefaultColumnValuesButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("05acb539-edf9-4e24-bdb2-8add59496bfa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7808c037-d4df-4301-a794-f523196669bc"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"SetDefaultColumnValuesButtonClickScriptTask",
				Position = new Point(126, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,111,107,194,48,16,198,95,175,208,239,16,242,74,153,213,138,118,22,54,7,26,117,200,240,15,56,247,118,132,246,230,2,109,42,73,58,87,196,239,238,181,186,217,194,112,123,147,144,203,253,158,123,46,185,197,22,228,106,11,129,120,207,88,18,165,177,124,229,81,10,122,201,55,208,92,224,29,168,169,212,134,203,0,166,33,233,147,239,195,122,26,222,219,214,226,10,188,214,192,82,165,64,154,65,96,196,39,228,65,20,48,42,133,63,200,124,89,23,213,36,236,200,83,42,194,26,157,184,190,235,121,140,57,131,142,223,117,186,190,239,57,254,100,228,58,195,187,118,175,51,116,199,237,81,111,72,235,255,16,94,114,197,99,48,160,244,89,127,36,208,94,34,185,202,30,180,81,66,110,26,228,180,63,214,234,100,111,91,55,123,66,177,9,97,178,85,240,1,49,71,103,180,65,198,213,72,243,37,89,21,16,50,135,198,25,10,133,169,32,229,243,117,96,198,37,90,85,115,116,90,1,75,241,31,42,40,117,201,18,105,224,203,60,67,134,24,251,245,162,82,109,28,65,140,189,93,252,93,2,21,131,182,117,192,167,109,181,174,61,46,139,18,13,51,208,250,244,207,180,148,144,43,231,57,69,74,72,11,41,28,36,80,6,194,82,90,238,174,79,138,230,110,9,125,163,184,230,159,223,156,195,174,24,130,122,201,19,106,40,48,169,146,167,129,58,2,52,232,4,41,198,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenSpecifyColumnValuesPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1250eaec-c101-4362-89f8-568e69d3e562"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7808c037-d4df-4301-a794-f523196669bc"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenSpecifyColumnValuesPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 35),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenSpecifyColumnValuesPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b4c1f6c7-89b6-4549-b3a9-033b8d26e2ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EventSubProcess11",
				Position = new Point(36, 938),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(248, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateExploreButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("52dfdc54-c593-4598-85d2-4723e1e4d96a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b4c1f6c7-89b6-4549-b3a9-033b8d26e2ec"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ExploreButtonClick",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ExploreButtonClickStartMessage",
				Position = new Point(28, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateExploreButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5b1ec650-1ad5-4f2a-94bd-9abc6c51c541"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b4c1f6c7-89b6-4549-b3a9-033b8d26e2ec"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ExploreButtonClickScriptTask",
				Position = new Point(140, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,205,115,206,207,41,205,205,115,173,40,200,201,47,74,45,210,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,165,195,225,118,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("45b4a479-9327-47db-bd25-4bdddaf279e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EventSubProcess9",
				Position = new Point(35, 1105),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 168),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateGenerateDecisionsFromColumnEditCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8074a953-d01e-4a59-921f-5ccdcd5b6fd3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45b4a479-9327-47db-bd25-4bdddaf279e6"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"GenerateDecisionsFromColumnEditCheck",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"GenerateDecisionsFromColumnEditCheckStartMessage",
				Position = new Point(36, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateGenerateDecisionsFromColumnEditCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c3cb2e09-3b3b-4a25-92c5-8fed53875426"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45b4a479-9327-47db-bd25-4bdddaf279e6"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"GenerateDecisionsFromColumnEditCheckScriptTask",
				Position = new Point(162, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,207,65,10,194,48,16,5,208,117,3,185,67,220,213,46,218,3,20,55,214,232,74,8,244,4,177,29,219,96,58,41,211,9,40,226,221,181,130,32,130,11,113,253,223,255,240,141,237,32,223,64,227,38,23,208,250,42,248,56,160,110,29,231,53,176,70,123,240,208,166,102,70,59,64,32,203,240,194,211,150,194,240,230,171,30,154,19,180,203,82,138,167,215,231,209,7,130,117,100,14,248,207,90,145,73,225,142,42,93,252,84,84,87,41,18,243,245,93,229,193,82,58,207,39,159,249,30,216,26,203,189,90,169,154,201,97,151,235,97,228,203,131,222,164,200,10,41,8,56,18,42,166,8,229,29,175,123,203,179,64,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenEditPageEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenEditPageEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f374c9de-b946-42d5-aeb1-5132aec81d06"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageEventSubProcess8",
				Position = new Point(36, 1302),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(262, 167),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenEditPageEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateIsMatchConditionsEditCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2fc49664-cb20-4721-8800-655dddd2796d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f374c9de-b946-42d5-aeb1-5132aec81d06"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"IsMatchConditionsEditCheck",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsMatchConditionsEditCheckStartMessage",
				Position = new Point(35, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIsMatchConditionsEditCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b971fcab-e2b3-42f6-bd80-325e113640c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f374c9de-b946-42d5-aeb1-5132aec81d06"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsMatchConditionsEditCheckScriptTask",
				Position = new Point(161, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,203,204,41,73,45,114,77,201,44,209,115,205,75,76,202,73,77,81,176,85,8,0,201,120,22,251,38,150,36,103,56,231,231,1,37,51,243,243,138,193,138,156,51,82,147,179,83,83,172,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,135,249,134,33,75,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenEditPageEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenEditPageEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageEventSubProcess7",
				Position = new Point(36, 1503),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(538, 211),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenEditPageEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateObjectEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5b233931-a7a0-433d-a9f2-f50d61cc6a40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageEditChange",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ObjectEditChangeStartMessage",
				Position = new Point(28, 83),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(217, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPrepareChangeSchemaEntityQuestionScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5b3ff4a1-f642-4c88-a3da-1cb1d8f83d39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ScriptTaskPrepareChangeSchemaEntityQuestion",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(329, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,140,49,14,130,64,16,69,107,57,197,102,107,226,5,80,11,145,130,66,80,129,130,114,67,38,64,225,172,217,25,162,132,112,119,119,227,22,38,24,105,230,103,242,223,251,113,167,176,133,162,233,224,174,18,228,158,199,138,192,156,129,72,181,176,189,216,35,246,194,69,20,196,127,81,159,37,188,216,26,75,214,247,107,51,105,163,209,250,242,90,37,69,153,230,153,92,19,142,3,179,70,114,78,157,20,89,190,42,220,128,30,86,0,255,59,19,225,41,78,125,195,189,70,101,198,29,177,233,177,13,197,39,15,98,10,54,147,28,129,100,40,228,114,187,6,242,83,114,14,29,137,250,55,152,233,47,110,142,2,3,60,24,20,108,6,136,222,35,22,238,217,135,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeSchemaEntityUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ChangeSchemaEntityUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(448, 20),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeSchemaEntityUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("8574bc6f-d9d4-40c9-af8e-e74c0e88e3ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(378, 153),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIsChangingPageSchemaScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2666200a-061b-449d-bb9c-c02e0bbb35fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"IsChangingPageSchemaScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,118,206,72,204,75,207,204,75,15,72,76,79,13,78,206,72,205,77,84,176,85,40,41,42,77,181,230,229,42,74,45,41,45,202,131,240,0,46,210,172,247,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenEditPageEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenEditPageEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c5eb5076-6548-41da-85b5-d6c53e888e3e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageEventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 2140),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenEditPageEventSubProcess5;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeSchemaEntityYesMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aa02346a-cf73-4be7-9d90-6b4456849260"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5eb5076-6548-41da-85b5-d6c53e888e3e"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ChangeSchemaEntityYesMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,65,110,194,48,16,60,55,82,254,96,56,37,18,202,7,40,189,64,138,144,218,42,74,218,94,170,30,92,123,1,171,193,70,235,77,81,84,245,239,53,78,128,38,32,164,222,236,245,206,206,204,122,50,190,130,36,213,164,168,158,113,226,133,169,80,64,82,136,53,108,248,203,66,178,9,107,30,143,149,113,24,228,96,129,166,70,19,154,242,149,151,21,216,40,118,229,108,63,234,94,149,4,152,74,69,73,1,116,26,25,101,151,136,246,48,181,100,81,143,131,13,38,108,94,41,153,164,155,45,213,49,251,14,131,155,139,248,228,193,112,89,16,86,130,42,4,175,226,39,12,82,205,63,74,104,5,54,218,138,163,96,219,188,202,12,205,22,144,234,70,216,19,236,114,16,6,165,87,62,93,131,248,4,185,7,134,193,23,71,182,229,200,55,224,140,89,239,215,109,37,235,85,184,101,51,37,72,25,205,177,190,181,132,74,175,70,204,145,8,176,182,49,118,132,120,196,93,107,253,108,244,132,233,170,44,15,166,251,188,231,253,76,195,238,191,220,81,220,174,234,74,19,67,191,144,133,244,183,86,237,160,71,159,60,99,61,7,242,231,104,152,183,136,225,136,153,138,186,3,226,198,81,167,214,138,191,34,226,240,165,29,88,242,104,164,90,42,144,11,221,9,170,251,186,191,49,237,98,114,88,2,130,22,112,61,219,61,127,111,39,79,239,174,191,191,18,4,151,59,205,92,0,97,252,11,21,195,83,146,74,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateYESChangeEntitySchemaOnSave_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cd126551-0fb2-4104-9adb-fc52eda2e6fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5eb5076-6548-41da-85b5-d6c53e888e3e"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"YESChangeEntitySchemaOnSave",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"YESChangeEntitySchemaOnSave_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenEditPageEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenEditPageEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2fb7ee02-7b50-40cf-bf15-3c0a09bf3ccb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageEventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 1720),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(251, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenEditPageEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityNoMessageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6a0680a3-cb1d-4bac-aabc-17ceadd65837"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2fb7ee02-7b50-40cf-bf15-3c0a09bf3ccb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityNoMessage",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ChangeSchemaEntityNoMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeSchemaEntityNoMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6e5f5bd8-e2ba-4f83-8523-ede64aa8c5ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2fb7ee02-7b50-40cf-bf15-3c0a09bf3ccb"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ChangeSchemaEntityNoMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,81,75,195,48,20,133,159,45,244,63,132,61,165,67,178,31,48,21,102,221,164,15,66,177,235,222,179,230,234,34,235,237,72,110,230,138,248,223,77,192,7,155,118,15,190,4,146,156,147,251,157,67,74,249,14,162,244,203,90,105,18,149,179,39,64,181,250,144,151,245,25,144,44,207,150,105,114,150,134,53,71,237,247,53,106,170,154,3,180,242,69,162,55,25,118,207,120,62,125,149,213,22,76,222,33,66,67,186,195,52,185,17,207,48,148,240,217,21,239,44,140,45,6,71,5,65,123,23,203,31,70,92,65,230,161,174,224,6,130,160,120,236,235,66,241,16,251,215,165,194,192,114,216,5,208,78,30,29,172,80,109,225,66,124,106,146,40,212,237,36,130,200,229,41,164,14,207,46,230,105,178,251,172,122,27,211,143,156,94,172,223,24,223,154,126,3,212,28,98,253,198,116,237,211,158,119,142,70,206,44,99,95,190,225,255,37,152,164,255,75,254,157,38,243,69,220,203,43,88,215,66,244,69,12,144,51,200,200,56,88,254,0,204,114,100,39,83,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenEditPageEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenEditPageEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ca0f37c4-c64d-47ab-95a2-9b3207e8e325"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageEventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 1880),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(652, 247),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenEditPageEventSubProcess4;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("cbca2f3b-34ce-490a-b4e7-a485d6cff867"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0f37c4-c64d-47ab-95a2-9b3207e8e325"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c9ad13fa-7f93-465a-ad9b-97adf2cca287"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0f37c4-c64d-47ab-95a2-9b3207e8e325"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"YESChangeEntitySchemaOnSave",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OkButtonClick_YESChangeEntitySchemaOnSave_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 167),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareWindowQuestionOnSave_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("81756ce6-df3d-4e26-a990-e7e1adad9237"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0f37c4-c64d-47ab-95a2-9b3207e8e325"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"PrepareWindowQuestionOnSave_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,223,106,194,48,20,198,175,39,248,14,33,87,202,74,30,96,238,15,218,117,82,54,219,97,21,25,236,38,171,7,237,172,137,36,167,186,34,190,251,78,186,10,221,197,28,244,42,156,228,251,126,223,201,73,246,210,48,80,152,97,153,164,107,216,74,118,199,230,22,140,175,149,130,20,51,173,68,208,56,157,72,37,87,96,196,24,48,84,22,165,74,97,84,206,195,101,175,41,162,186,63,232,118,246,68,214,31,159,68,241,229,206,145,8,221,76,18,245,54,73,187,157,100,173,15,11,105,84,166,86,254,90,170,21,52,129,177,74,228,30,38,96,45,133,187,238,102,210,110,196,43,21,132,116,203,160,21,160,174,103,240,133,196,233,118,174,44,26,178,139,39,109,182,18,123,255,208,60,231,56,91,66,27,21,121,30,155,96,187,195,178,231,90,18,231,152,89,134,57,4,203,12,133,11,234,179,7,86,123,42,45,187,97,156,189,115,206,174,217,5,23,157,114,18,121,46,241,215,72,251,237,110,30,166,213,107,240,197,112,26,133,209,152,183,163,140,10,68,173,172,3,197,207,254,48,242,131,151,150,164,41,216,29,145,206,251,14,169,224,192,30,179,234,7,74,83,222,254,204,204,171,103,119,207,142,52,138,35,215,27,238,49,254,22,36,127,5,241,147,87,9,83,247,83,115,39,142,226,139,218,19,93,192,0,22,70,49,52,5,12,190,1,34,38,76,243,31,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowWarningChangeEntitySchemaOnSaveMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2f54065e-9369-4754-be22-b4f76893c117"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0f37c4-c64d-47ab-95a2-9b3207e8e325"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ShowWarningChangeEntitySchemaOnSaveMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(540, 49),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowWarningChangeEntitySchemaOnSaveMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityYesMessageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c66ba53d-1b1b-4d49-96b6-278f05436dc9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0f37c4-c64d-47ab-95a2-9b3207e8e325"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ChangeSchemaEntityYesMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessPageSelect_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6a0cec4f-8827-445f-a089-f7a4683e7ff8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0f37c4-c64d-47ab-95a2-9b3207e8e325"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ProcessPageSelect_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,75,107,195,48,12,62,167,208,255,224,229,100,195,48,187,247,1,163,75,71,97,135,66,218,237,80,122,112,27,173,245,112,236,77,86,186,133,177,255,62,59,9,44,107,123,9,145,228,239,37,45,213,1,242,253,17,74,181,40,216,132,61,86,186,144,89,249,78,245,104,56,200,44,105,170,219,233,250,114,124,82,200,60,24,216,19,20,203,255,52,60,62,20,177,41,227,39,43,52,201,103,101,42,8,48,253,202,248,85,216,77,159,95,176,239,225,32,249,147,96,147,80,38,22,62,89,222,212,124,237,1,103,206,218,240,175,157,21,113,154,200,153,51,85,105,121,26,220,166,77,75,206,209,149,60,205,107,223,202,116,221,151,35,32,240,52,190,146,11,159,125,84,202,240,22,27,252,162,42,129,0,175,154,20,130,41,223,89,8,89,146,179,220,45,68,102,95,176,175,40,12,148,81,56,142,161,166,92,140,186,60,208,219,234,162,240,113,91,15,186,9,161,176,30,187,221,91,96,184,101,79,218,83,87,76,167,162,185,132,6,63,119,24,21,125,228,186,188,78,220,78,20,227,103,18,155,190,75,185,114,57,161,182,7,46,182,155,187,109,175,108,28,230,64,153,85,59,3,197,125,240,116,10,52,43,181,11,123,38,116,198,243,51,205,136,248,25,14,16,168,66,203,8,195,125,127,1,198,57,213,157,80,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess19EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess19 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f6c9d983-5719-44d7-9319-23b59142fc4a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EventSubProcess19",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 2140),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess19;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateNOChangeEntitySchemaOnSave_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2c7daf6d-171b-48d9-a8a4-3515d1a1b0b6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6c9d983-5719-44d7-9319-23b59142fc4a"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"NOChangeEntitySchemaOnSave",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"NOChangeEntitySchemaOnSave_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateClearObject_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("325354ea-54c2-4375-8d59-00fff1795734"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6c9d983-5719-44d7-9319-23b59142fc4a"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ClearObject_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,193,10,130,64,20,69,247,130,255,32,110,102,4,25,218,75,11,49,11,87,73,86,251,105,230,97,19,58,35,207,55,144,68,255,158,218,38,218,159,115,239,169,101,11,34,215,186,81,104,6,226,35,161,177,173,216,59,236,37,241,248,181,121,139,17,232,42,59,15,185,213,103,120,18,103,44,101,44,201,226,52,170,23,247,120,123,128,162,82,27,18,69,103,192,82,181,75,146,44,12,194,160,180,100,104,106,212,29,122,121,169,116,180,141,14,222,104,81,246,3,77,43,176,250,95,106,39,73,54,206,163,2,241,43,252,77,204,214,9,230,158,194,89,66,215,173,89,35,95,222,16,200,163,141,8,61,100,31,15,11,86,155,211,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenEditPageEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenEditPageEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e6fc8dc5-48c1-44bd-84d9-8b5c5cebc46b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageEventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 2323),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(426, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenEditPageEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("711ea29e-913b-47a5-8678-5d32ee76fd3e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6fc8dc5-48c1-44bd-84d9-8b5c5cebc46b"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("01677a75-89bc-4c7b-8d59-c38b77ae5996"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6fc8dc5-48c1-44bd-84d9-8b5c5cebc46b"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ad2dd160-8b07-4ffc-bd54-08feebe07f29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6fc8dc5-48c1-44bd-84d9-8b5c5cebc46b"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(323, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,193,106,194,64,16,134,207,13,248,14,75,78,9,36,54,214,88,3,182,5,77,98,201,161,32,181,244,82,122,88,226,68,183,77,118,237,238,196,42,210,119,239,198,64,136,8,102,111,179,255,204,247,15,51,195,50,98,197,123,236,39,106,250,69,247,175,240,83,130,66,155,28,123,198,141,4,44,37,39,40,75,152,244,140,191,158,177,163,146,100,52,87,240,78,243,18,200,35,49,79,145,57,169,165,21,100,39,65,105,197,138,88,138,76,112,42,15,15,10,37,227,107,135,44,164,72,65,169,101,186,129,130,46,168,164,5,32,200,83,201,147,29,65,70,203,28,107,128,6,222,234,183,4,108,127,91,141,193,135,185,220,136,223,55,182,53,63,157,86,71,14,169,173,250,113,177,197,131,67,154,44,91,3,175,192,18,245,66,49,221,132,130,175,88,213,180,234,192,94,230,119,24,60,3,7,73,17,34,72,153,170,10,230,82,20,161,200,203,130,119,88,93,171,180,187,199,180,160,107,168,231,157,172,42,39,115,224,197,163,217,48,240,220,187,209,124,232,250,99,63,114,131,40,14,221,251,153,239,5,254,32,240,166,225,216,188,232,226,12,83,217,158,109,75,175,187,177,212,90,194,119,226,27,18,206,112,70,21,76,245,25,236,24,30,154,125,171,88,15,173,2,90,21,168,125,99,255,137,231,249,44,139,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateControlsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b1b52be0-65ed-4740-b09f-df2d451afc8e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6fc8dc5-48c1-44bd-84d9-8b5c5cebc46b"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"CreateControlsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,86,77,79,219,64,16,61,7,137,255,48,205,201,166,145,115,167,124,136,18,211,162,34,17,9,104,15,81,14,91,123,226,108,227,172,221,221,53,193,69,254,239,157,221,53,198,38,73,17,21,21,82,47,142,236,157,143,247,222,204,206,132,207,192,59,87,167,89,90,44,69,120,151,167,153,68,121,42,145,105,140,125,184,223,221,233,185,151,174,129,231,127,216,221,169,118,119,110,153,4,20,154,235,242,42,154,227,146,221,156,199,10,14,193,27,241,72,243,76,48,89,30,100,223,127,96,164,7,112,193,149,174,95,142,142,252,208,56,113,84,103,153,28,179,4,21,133,27,14,175,47,71,151,240,153,69,139,0,62,22,9,112,1,185,204,34,84,10,114,38,217,18,53,74,5,10,37,103,41,255,197,76,2,88,113,61,7,93,230,168,32,155,193,115,105,7,176,154,163,68,88,96,9,92,193,167,130,199,142,131,192,213,6,26,244,245,217,144,86,9,78,26,174,249,191,163,0,69,154,58,17,103,164,26,139,230,224,61,42,70,70,134,226,83,191,224,11,150,202,57,245,106,104,38,225,165,205,87,131,106,35,176,0,122,221,4,105,227,112,174,113,185,41,203,164,193,48,173,115,245,58,137,130,147,56,246,76,42,163,145,231,41,45,185,72,252,110,92,223,101,174,204,99,131,128,155,67,52,121,253,65,151,154,13,86,53,93,181,202,228,226,42,103,17,158,241,148,234,190,94,13,23,111,0,181,12,150,196,61,244,163,108,73,205,194,85,38,174,169,43,250,3,112,254,167,157,207,65,248,179,96,41,84,3,231,147,226,76,83,103,75,234,52,10,238,58,125,204,244,156,188,251,87,165,250,70,80,148,129,210,111,60,10,133,35,174,242,148,149,95,89,90,152,52,51,150,42,108,206,37,79,230,173,144,227,135,246,181,214,170,111,169,215,200,39,83,184,135,27,101,32,10,129,150,94,208,100,12,168,71,42,48,170,152,11,178,231,164,169,47,133,83,154,132,57,227,34,30,161,226,137,192,120,220,62,179,173,97,61,232,78,209,45,123,123,41,199,14,8,149,255,223,105,217,145,39,120,204,248,40,228,222,208,201,162,172,201,27,171,242,202,90,208,196,121,160,105,71,205,157,70,17,147,29,221,187,23,17,125,9,79,135,238,143,44,195,22,142,126,109,191,133,108,125,250,194,178,59,215,202,240,54,11,37,48,143,48,230,58,24,75,36,192,120,145,101,139,34,175,37,120,127,8,49,166,152,208,94,3,207,197,160,189,34,98,148,52,221,173,161,113,13,111,9,236,137,76,20,160,155,145,118,180,182,226,216,85,71,60,83,119,109,15,182,107,122,228,99,80,251,152,49,215,110,188,201,115,76,167,148,101,125,57,185,229,2,199,238,103,127,211,6,179,155,36,184,206,78,164,100,165,91,19,195,97,7,191,29,209,157,225,96,173,214,109,218,128,183,152,60,25,216,91,172,214,251,209,254,147,120,168,154,91,5,255,79,221,12,41,87,16,154,63,84,51,179,10,131,112,153,235,18,142,235,181,217,30,93,173,227,106,255,239,138,62,105,167,156,118,171,255,90,117,53,229,146,168,11,41,64,203,2,63,252,6,179,31,147,62,67,10,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOpenEditPageEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaOpenEditPageEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2cfdd037-9818-4b4a-a528-968fb206ab59"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OpenEditPageEventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 2498),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOpenEditPageEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoqdCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6cbd8f75-4830-4bb0-8080-c027c888ce59"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cfdd037-9818-4b4a-a528-968fb206ab59"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"PageLoqdCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoqdCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("151d4457-eab8-4547-8bc8-81f9cb4bc4b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cfdd037-9818-4b4a-a528-968fb206ab59"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"PageLoqdCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("98d7e503-bc70-4f90-9653-9db8b44ec678"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2cfdd037-9818-4b4a-a528-968fb206ab59"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,87,223,79,219,72,16,126,6,137,255,97,155,39,71,138,44,245,245,74,56,65,18,80,218,2,81,3,247,130,120,88,236,9,108,207,217,141,118,215,41,190,42,255,251,205,236,218,241,218,177,211,86,66,128,61,51,223,124,243,115,215,115,243,104,32,189,76,172,216,10,91,76,148,180,90,101,134,141,217,130,191,66,124,191,1,57,75,133,165,135,7,254,178,224,18,178,216,41,211,227,92,166,240,206,198,99,246,241,211,217,105,191,62,58,88,104,181,18,25,32,236,138,103,6,72,93,195,134,107,152,73,43,172,0,115,173,52,217,152,104,136,50,100,177,18,175,185,134,107,145,89,208,4,232,222,111,185,102,104,196,215,128,111,137,227,20,86,60,207,236,63,60,203,193,48,110,216,84,32,55,37,185,46,206,141,213,66,190,142,24,186,78,192,152,101,242,6,107,190,168,172,157,201,5,98,138,21,139,66,204,49,147,121,150,13,217,207,179,211,19,13,54,215,146,89,157,19,227,221,217,169,199,172,57,56,20,228,81,3,60,13,136,237,173,74,97,240,28,59,49,90,126,131,68,233,180,18,48,40,255,65,201,76,230,235,248,65,23,200,203,64,228,225,227,185,185,67,10,247,122,182,222,216,34,106,58,27,178,191,89,169,230,196,236,175,22,155,17,83,185,221,187,160,172,189,40,149,49,97,238,224,71,139,199,120,175,70,97,55,133,49,170,151,217,233,48,245,233,113,21,111,200,226,201,27,36,255,66,138,208,85,210,24,96,189,107,245,217,187,48,22,217,31,181,57,59,61,154,225,251,151,239,144,88,95,208,121,26,228,121,78,76,81,249,119,242,88,6,247,193,217,248,120,92,47,22,30,247,113,78,132,36,194,221,228,34,237,48,46,195,113,38,83,110,249,82,229,58,129,56,180,110,225,145,81,217,64,43,215,215,166,21,87,13,227,251,222,4,161,157,56,178,157,129,149,96,67,31,196,9,13,201,119,163,36,14,209,22,52,74,202,56,14,208,63,135,74,17,153,158,224,164,106,124,37,193,77,209,200,239,128,122,8,227,26,195,165,192,249,242,238,39,42,203,188,21,186,35,228,120,10,8,38,120,38,254,131,138,226,136,217,98,3,106,21,181,185,212,214,195,17,115,76,136,241,87,108,149,243,6,203,11,246,179,21,219,110,232,198,190,23,207,209,164,220,29,208,252,16,78,122,24,10,69,122,163,85,190,169,150,224,65,145,175,133,76,203,36,58,197,171,226,14,139,120,224,34,166,183,62,81,1,133,26,190,197,160,167,163,38,185,214,32,237,18,135,35,193,117,84,213,195,196,223,96,173,182,208,70,45,253,237,220,239,63,68,188,76,211,131,32,60,30,193,237,122,155,254,171,226,233,30,45,170,167,35,232,156,37,216,218,32,234,132,113,118,115,63,46,183,92,162,138,158,91,88,159,135,99,116,193,32,120,34,49,22,233,6,236,172,245,54,32,225,183,69,69,194,205,211,165,76,31,224,221,70,109,172,120,158,142,14,28,196,19,190,169,18,241,171,205,68,14,59,246,82,255,236,182,246,74,189,87,43,148,95,44,33,234,218,36,19,200,249,81,10,219,200,29,90,70,147,110,209,176,57,231,84,224,24,147,216,208,137,6,61,198,131,190,58,181,245,47,14,152,149,245,234,33,76,20,72,227,170,192,101,25,133,73,168,139,73,191,58,75,217,229,202,149,179,83,208,44,41,149,167,189,251,113,54,41,231,254,144,245,101,153,66,34,12,93,46,50,156,142,124,45,111,193,226,125,194,190,181,183,120,143,90,184,204,169,108,97,159,33,68,179,36,113,200,39,204,143,52,150,203,4,124,142,90,164,135,199,207,137,62,98,225,193,145,56,9,221,12,2,232,186,55,188,225,85,81,153,246,99,186,173,225,74,214,86,113,229,163,154,81,39,184,55,85,57,226,7,181,116,196,253,244,238,92,113,188,145,191,225,209,237,20,13,191,64,193,202,242,224,217,237,70,99,216,180,173,67,41,175,134,229,17,248,103,183,67,7,117,68,161,225,98,113,108,47,248,219,78,24,202,224,185,220,11,71,48,26,231,131,175,117,153,101,190,217,32,251,224,48,75,182,248,80,157,191,148,250,163,234,225,217,236,92,29,97,177,111,170,208,69,243,228,90,41,13,60,121,99,145,75,251,150,137,6,159,234,120,11,93,60,37,219,184,217,48,207,212,13,219,122,66,170,19,7,127,90,147,177,196,106,224,95,58,55,158,186,155,227,121,223,89,94,226,238,217,252,37,131,234,235,198,21,22,55,72,245,236,165,41,150,122,131,183,138,162,243,198,235,45,74,205,234,115,9,63,113,246,152,29,195,24,126,63,252,15,130,251,67,87,104,13,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess18EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess18 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("74f9a575-9378-4e94-b51d-b285de2ce2cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("42e52b01-adaf-4f36-a07a-81c1e5adf0d7"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"EventSubProcess18",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 2671),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(537, 297),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess18;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickOpenEditPageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bd951774-27eb-4e37-b7bb-d202a7a2153c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74f9a575-9378-4e94-b51d-b285de2ce2cc"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OkButtonClickOpenEditPageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,88,75,115,218,72,16,62,227,42,255,135,9,135,148,148,165,228,228,106,130,93,101,140,93,236,250,181,6,231,146,202,97,144,26,51,177,208,168,102,70,182,217,45,255,247,237,121,8,70,66,96,146,141,119,15,46,195,168,159,95,127,234,233,102,144,194,28,50,117,5,79,125,154,43,198,51,210,35,55,244,30,162,59,9,98,76,229,195,152,169,20,6,9,83,209,24,158,85,119,127,111,127,239,145,10,146,241,12,190,140,180,176,224,49,72,57,138,103,48,167,55,84,208,57,40,16,95,104,90,192,136,23,34,134,232,10,69,187,86,43,230,153,84,59,170,245,141,172,62,88,58,205,75,57,105,206,77,168,213,19,42,201,41,139,117,30,84,44,62,75,37,88,118,223,217,230,236,8,141,179,41,9,214,76,247,72,86,164,105,72,254,222,223,107,213,189,244,26,228,73,6,79,63,234,59,8,67,116,255,162,211,59,56,32,183,16,115,145,144,97,66,104,154,62,209,133,36,243,66,42,50,163,143,128,207,166,32,32,139,193,218,185,67,161,71,109,194,226,34,140,230,48,241,67,217,226,55,176,89,93,242,132,77,25,36,195,108,101,180,71,116,169,151,223,59,40,214,224,26,165,50,197,212,98,121,130,73,152,34,105,36,13,123,6,207,76,42,204,223,230,100,232,211,159,65,252,0,137,245,93,137,56,178,21,47,153,119,235,158,25,173,106,228,78,178,187,102,97,197,135,87,12,148,132,170,233,95,130,66,144,212,236,95,152,56,101,50,79,233,98,231,72,124,249,146,5,53,86,125,109,151,6,218,223,208,100,197,95,215,177,102,4,202,61,32,128,94,200,156,39,208,96,72,71,128,5,7,99,232,151,242,99,89,60,247,114,235,179,10,8,216,91,214,105,64,142,73,251,99,155,28,146,246,167,118,201,30,151,77,129,157,135,40,108,61,4,158,33,46,20,10,219,164,14,62,236,239,77,185,0,26,207,72,160,121,95,62,215,137,17,150,33,43,139,121,116,14,182,107,200,64,45,114,224,211,160,236,100,3,79,58,12,109,142,117,43,253,19,140,26,59,143,18,60,189,83,44,101,138,129,140,206,88,150,184,195,207,119,67,247,73,70,183,52,97,252,164,80,138,103,71,1,26,107,153,116,199,60,119,18,23,116,193,11,213,169,56,192,199,35,211,25,16,228,223,136,41,75,91,55,129,86,11,255,244,235,83,141,166,250,214,180,214,203,234,73,255,64,105,91,187,22,183,213,88,222,214,178,192,65,192,50,21,250,49,135,94,134,90,244,197,36,55,193,170,61,232,79,47,134,233,31,14,150,245,198,7,41,251,11,72,66,177,228,214,215,148,165,24,47,22,84,42,160,9,225,83,50,24,253,73,240,22,33,19,136,41,210,131,60,1,38,138,188,80,28,185,63,41,88,154,24,107,72,255,167,25,100,120,198,115,252,151,99,57,8,18,134,168,25,147,4,236,77,23,25,201,235,137,162,154,48,104,215,121,155,10,62,39,178,12,39,105,136,167,110,9,35,34,162,192,70,56,119,109,216,202,245,121,154,66,236,95,165,103,230,220,176,255,20,173,186,251,77,147,202,62,145,231,130,23,249,201,226,10,11,21,180,87,210,134,24,218,240,119,201,51,228,212,35,8,29,135,187,106,150,150,156,145,223,125,33,77,71,205,123,60,200,108,48,157,45,177,132,221,198,230,179,230,226,13,155,135,9,110,40,47,169,138,103,24,52,202,97,204,178,214,49,202,241,225,208,141,31,107,173,230,53,3,154,138,26,167,8,121,199,76,161,131,122,209,58,85,180,67,116,102,233,28,13,230,185,90,148,189,106,13,172,115,200,64,80,5,167,16,51,169,93,159,33,161,208,108,49,207,254,135,158,187,37,26,31,146,202,187,186,186,194,237,236,130,104,94,225,8,116,45,76,226,129,131,100,165,98,28,149,14,104,234,89,55,161,148,45,182,46,225,93,181,210,3,214,94,129,235,28,220,160,253,134,152,142,154,178,223,20,71,136,172,114,179,240,97,83,53,54,233,117,106,151,30,159,124,71,254,17,105,34,42,103,59,139,143,123,102,131,109,154,190,244,176,122,94,176,196,2,73,142,209,189,143,44,6,86,83,240,202,222,76,230,235,138,199,255,26,235,106,190,175,33,92,149,182,176,78,56,79,9,147,87,92,105,92,140,85,205,86,15,194,202,215,119,62,126,221,37,238,121,85,101,139,189,99,179,36,172,14,252,91,254,176,66,115,210,109,128,219,87,125,67,176,183,37,176,181,183,250,64,88,128,205,220,132,142,250,84,36,75,103,218,226,24,103,46,252,56,198,177,73,143,7,222,66,164,29,119,12,206,71,225,224,21,213,110,185,239,45,79,171,0,160,233,95,138,145,78,73,71,230,123,116,139,225,22,208,222,191,127,21,131,104,44,22,229,64,26,248,202,29,130,163,161,239,206,117,203,141,41,71,245,158,223,221,42,237,151,206,73,84,223,250,23,28,99,112,146,218,209,167,229,196,110,46,119,232,234,30,74,134,239,27,141,250,45,50,54,13,212,246,70,185,191,103,123,154,235,170,52,207,209,167,55,122,205,215,78,236,66,223,245,150,212,198,197,100,181,23,200,28,123,183,230,142,245,97,151,10,210,211,51,68,117,180,194,105,66,234,30,175,231,165,175,190,176,222,3,224,89,253,1,139,111,63,247,203,132,217,8,154,227,120,231,255,64,209,106,76,23,95,144,173,32,53,91,238,212,111,139,112,53,183,95,240,88,79,77,116,146,66,53,88,121,129,251,126,9,186,39,101,142,123,77,213,176,225,235,137,236,216,68,186,221,180,217,37,14,215,237,32,167,107,222,130,90,109,116,81,140,29,205,175,75,154,97,225,69,216,212,132,45,21,124,36,118,105,197,63,213,136,155,113,138,250,28,183,9,141,204,199,13,87,158,167,176,130,160,124,237,154,141,150,99,134,105,167,126,26,168,161,55,144,83,144,236,62,131,164,146,98,16,118,43,63,184,9,189,17,13,220,214,131,93,125,120,227,157,87,52,157,80,88,113,165,87,242,19,42,193,61,60,89,32,30,129,70,199,29,56,142,53,56,139,214,38,157,58,57,81,79,128,42,68,70,148,192,118,241,15,128,167,58,74,207,20,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOkButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4ca88245-9591-4e41-a639-295bf0bff211"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74f9a575-9378-4e94-b51d-b285de2ce2cc"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OkButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(470, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickOpenEditPageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c2f8bbc5-37dd-466c-9fd3-ddb78ce09c53"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74f9a575-9378-4e94-b51d-b285de2ce2cc"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"OkButtonClickOpenEditPageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 114),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChackValidation_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b60261ba-ae4d-406c-a20f-7690cee176f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74f9a575-9378-4e94-b51d-b285de2ce2cc"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ChackValidation_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 100),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,79,79,194,64,16,197,207,52,233,119,88,56,144,194,161,120,39,28,180,86,210,68,145,104,226,213,172,237,20,54,148,221,102,102,87,32,134,239,238,254,1,196,8,94,38,219,157,217,55,191,247,90,208,61,215,252,141,55,162,122,159,193,230,69,109,216,132,105,52,48,142,163,226,172,151,111,5,105,33,23,191,6,68,205,146,57,95,64,122,234,66,169,176,202,43,161,211,108,9,229,10,170,1,251,138,163,206,117,165,46,105,180,31,105,65,51,211,52,207,152,175,91,189,11,162,65,172,8,114,115,142,124,13,26,208,138,24,72,125,29,88,132,125,28,141,134,113,4,13,129,223,116,66,114,102,174,208,116,106,133,192,203,37,75,62,57,178,150,11,100,66,178,41,232,76,53,102,45,189,54,37,131,195,176,151,188,72,233,94,166,231,60,199,23,191,252,158,82,173,185,133,28,135,129,15,11,176,10,231,189,171,174,236,189,155,225,200,5,255,32,26,235,213,155,166,192,147,41,68,40,245,133,240,11,122,226,186,92,102,74,90,167,66,73,250,235,216,249,172,189,36,89,1,255,42,108,240,163,142,245,85,25,44,221,173,172,66,135,166,168,76,123,183,155,217,216,147,222,207,116,207,165,222,249,159,240,176,42,205,148,145,154,117,39,236,134,245,251,172,123,188,46,232,86,238,30,161,214,249,182,69,32,178,204,231,177,30,126,43,130,54,40,131,219,111,87,154,217,3,166,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway4ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("49f1b70f-4547-45fe-aa26-063d1070c1b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74f9a575-9378-4e94-b51d-b285de2ce2cc"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"ExclusiveGateway4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 100),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateWarningMessage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("595206a6-3a9a-42ce-8ee7-d970eb4db855"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74f9a575-9378-4e94-b51d-b285de2ce2cc"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Name = @"WarningMessage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 192),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,145,193,10,130,64,16,134,207,9,190,195,118,83,16,95,64,58,68,25,116,48,36,162,142,49,228,36,11,235,42,179,99,42,209,187,183,88,130,80,68,23,111,51,255,204,252,255,7,115,3,18,140,45,139,133,48,76,82,231,97,92,84,220,69,174,35,175,194,155,111,205,26,24,142,160,100,118,222,97,179,47,27,95,220,93,103,150,66,142,97,2,82,39,104,140,173,83,208,168,194,101,150,189,123,175,63,1,150,229,176,113,144,172,48,16,159,186,13,127,57,7,98,144,186,10,195,19,144,182,56,190,37,121,124,129,137,91,105,216,206,39,34,26,217,255,129,181,145,138,145,82,32,40,140,181,171,209,172,74,34,188,240,20,104,227,176,254,87,191,0,93,135,144,107,210,130,169,198,232,9,175,57,79,210,237,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetFilterEditEnabledMethod());
			Methods.Add(CreateResetControlValuesMethod());
			Methods.Add(CreateGetColumnExplorerMethod());
			Methods.Add(CreateColumnExplorer_EditCompleteMethod());
			Methods.Add(CreateOpenColumnExplorerMethod());
			Methods.Add(CreateCreateColumnExplorerMethod());
			Methods.Add(CreateCreateColumnValuesVdsMethod());
			Methods.Add(CreatePrepareEntitiesForPagesMethod());
			Methods.Add(CreateGetDeafLookupEditPageIdMethod());
			Methods.Add(CreateConfigureFilterEditMethod());
			Methods.Add(CreateIsEntitySchemaNeedInChangesForListeningByProcessMethod());
			Methods.Add(CreateGetNotNullColumnIdListMethod());
			Methods.Add(CreateGetEntityIdsWithoutPrcListenersColumnMethod());
			Methods.Add(CreateEnableControlsMethod());
			Methods.Add(CreateGetColumnValuesMethod());
			Methods.Add(CreateSetControlsEnabledPropertyMethod());
			Methods.Add(CreateGetEntitySchemaItemMethod());
			Methods.Add(CreateTryFetchClientUnitSchemaFromDbMethod());
			Methods.Add(CreateSetEnabledActivityTabControlsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e125c1cb-ec25-497c-b8f9-3979ca4b0369"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e4282000-e552-4e32-ba70-5d53aa639f9b"),
				Name = "Terrasoft.Configuration.RecordEditMode",
				Alias = "RecordEditMode",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("046d9c11-d04e-4e1a-b303-c574766cc84e"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e849c80a-bb45-4632-b5ed-1d2ab85b2155"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6169a4ac-da64-4e3a-a66c-d1e924fd32ab"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
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
				UId = new Guid("041d0e0d-f21a-4205-b82f-48ff17af056a"),
				Name = "Terrasoft.Configuration.VwSysClientUnitSchema",
				Alias = "VwSysClientUnitSchema",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
		}

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,81,203,106,195,48,16,60,87,95,33,114,114,192,232,7,220,22,210,184,13,166,20,66,233,227,188,149,54,137,192,89,149,213,58,197,4,255,123,229,20,67,32,137,15,205,77,171,217,121,48,91,122,43,62,16,112,123,27,133,61,173,115,253,134,204,16,195,74,204,123,101,62,241,107,30,72,56,212,241,232,125,175,33,209,118,94,218,1,124,240,228,18,91,223,233,5,202,236,60,152,77,11,181,3,214,225,27,233,209,121,89,194,26,79,249,132,63,186,252,103,170,189,186,217,235,73,21,95,64,236,38,253,38,147,36,19,39,185,238,189,204,9,208,167,208,93,126,96,189,162,13,236,42,55,44,15,243,241,206,2,9,25,4,75,180,62,246,2,79,28,182,243,80,55,91,26,104,35,43,127,74,170,43,212,42,48,130,221,100,207,216,126,64,221,224,18,60,95,213,255,80,159,167,75,151,153,246,229,140,52,111,102,206,101,231,85,77,138,153,95,112,52,135,252,233,176,157,98,148,134,105,236,186,197,47,114,191,39,111,110,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetFilterEditEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ef68c028-d026-44a5-a519-596b3588aa2b"),
				Name = "SetFilterEditEnabled",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("90e5538b-464f-4c88-934c-a2ac36044860"),
				Name = "isEnabled",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,203,204,41,73,45,114,77,201,44,209,115,205,75,76,202,73,77,81,176,85,200,44,134,178,173,1,79,198,39,133,36,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetControlValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("815c7f75-4e5c-4e22-8c8a-5012c129357e"),
				Name = "ResetControlValues",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,219,110,163,48,16,125,78,165,254,131,183,79,68,138,248,129,109,42,117,9,137,80,111,81,210,238,203,106,31,92,152,52,110,193,70,182,105,131,170,254,123,199,134,92,76,2,244,9,129,207,204,153,115,124,134,57,125,1,63,82,119,84,199,235,64,240,132,105,38,184,10,241,233,47,11,149,3,79,174,95,233,38,124,7,174,149,55,252,125,126,54,111,47,8,214,16,191,65,66,198,100,69,83,5,91,240,148,165,26,164,69,132,156,62,167,14,226,157,74,178,218,1,102,82,20,57,158,218,186,144,107,166,203,9,213,116,41,10,25,155,70,60,169,154,41,11,252,83,222,211,12,188,38,201,212,109,103,48,102,240,6,139,31,164,64,101,159,164,5,168,34,131,83,22,204,128,131,164,26,38,16,51,101,240,83,41,178,64,164,69,198,251,220,235,43,109,241,113,11,167,233,33,13,232,218,84,207,130,135,157,232,134,230,190,65,78,170,103,43,226,85,87,179,140,215,144,209,167,40,33,191,198,100,86,176,196,15,179,92,151,67,242,121,126,54,136,170,211,59,202,145,73,70,26,178,203,195,170,43,2,7,111,230,24,229,206,140,24,247,171,165,28,216,105,31,158,95,33,214,91,213,127,105,90,192,53,79,30,97,163,189,102,47,63,74,70,71,4,126,64,115,115,179,251,142,247,240,177,128,88,200,164,17,78,45,11,216,129,194,13,83,154,241,151,46,228,23,1,244,222,234,110,142,186,183,188,155,115,123,213,63,32,117,161,110,195,227,236,180,54,108,131,86,144,168,155,181,115,169,7,29,27,213,134,238,203,226,174,206,45,59,25,243,99,142,175,58,241,142,182,57,149,248,111,64,25,54,75,136,230,240,65,230,82,196,160,84,21,27,23,225,85,201,54,127,36,251,254,88,230,96,210,63,38,79,10,36,234,228,120,233,56,139,239,32,234,13,64,129,218,164,176,254,105,93,220,10,241,86,228,23,67,31,59,140,176,235,2,86,32,129,199,176,223,170,49,105,236,153,193,57,199,168,226,196,97,205,104,120,28,208,193,119,116,4,93,105,140,189,68,221,248,52,211,255,171,220,180,34,20,66,52,110,217,13,148,255,107,147,38,204,86,80,89,94,42,45,49,86,163,46,223,174,48,254,223,225,212,138,232,104,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a6878c7a-443c-4795-96de-2bd44cd96654"),
				Name = "GetColumnExplorer",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "StructureExplorer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,44,118,206,207,41,205,205,115,173,40,200,201,47,74,45,114,46,74,77,44,73,77,209,84,168,230,226,132,176,81,229,53,52,173,185,106,185,184,138,82,75,74,139,242,20,52,130,75,138,74,147,129,204,84,152,188,38,170,114,107,0,68,56,129,79,101,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateColumnExplorer_EditCompleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("67bc26bc-c2b8-48bd-a92d-ddc862d2bdb7"),
				Name = "ColumnExplorer_EditComplete",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("838ed736-2bc5-4bf6-9779-142f00de3c4a"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4a3201bf-cc0b-44c9-9deb-4924973416e3"),
				Name = "e",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,205,59,14,194,48,16,69,209,62,171,176,92,57,141,55,192,167,129,20,68,66,164,64,52,136,98,48,67,152,200,31,228,153,160,136,213,99,1,21,18,253,59,247,61,32,43,151,252,24,162,90,40,211,238,206,3,58,169,91,78,209,174,145,49,19,120,122,162,65,219,76,146,161,131,12,1,5,51,31,53,9,6,222,196,107,210,167,122,86,85,29,244,88,136,35,166,20,193,175,222,205,230,66,98,247,56,73,137,127,94,236,1,252,136,115,150,76,177,95,26,237,224,46,5,232,146,248,197,91,148,114,40,183,191,54,124,7,5,191,0,247,71,119,248,199,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOpenColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("06e40476-c348-4767-abb9-2ae68238d174"),
				Name = "OpenColumnExplorer",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,65,10,194,48,20,68,215,6,114,135,191,108,64,122,129,146,149,6,113,81,16,138,184,14,73,36,31,210,164,196,31,107,17,239,110,192,85,139,219,225,205,155,193,59,52,42,18,210,50,24,239,70,125,61,91,144,18,78,5,109,171,198,137,22,1,111,206,118,217,81,201,177,227,236,195,25,103,79,157,193,164,80,198,168,94,83,72,217,101,168,21,71,135,85,214,136,202,99,245,111,81,9,177,132,240,79,188,38,219,193,167,89,89,164,27,70,155,230,237,207,61,28,157,193,7,166,168,195,111,185,119,164,47,154,188,232,190,106,104,180,106,215,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9f76f233-8a5e-4ddf-a7e7-b390b90e3113"),
				Name = "CreateColumnExplorer",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,65,106,195,48,16,60,91,175,80,125,178,169,209,7,76,14,169,107,130,33,41,33,77,122,45,139,181,14,110,101,201,72,171,36,166,244,239,149,75,27,234,132,64,47,130,93,141,102,103,70,123,0,203,107,163,124,167,203,83,175,140,69,203,103,92,227,145,63,147,245,53,121,139,191,253,132,69,107,216,163,216,154,190,48,154,172,81,75,24,140,167,140,199,197,132,32,206,120,3,202,97,198,3,69,56,181,87,42,205,25,155,142,17,243,55,56,149,7,212,228,68,41,91,42,76,215,43,36,20,223,61,126,63,227,83,214,215,191,160,252,223,100,39,178,176,6,11,93,168,172,19,115,41,131,143,209,223,174,250,113,225,196,249,62,137,91,194,206,85,186,49,193,196,164,56,99,86,70,162,216,192,49,77,243,232,202,83,165,107,229,37,202,71,32,120,1,229,113,59,244,232,68,161,16,108,146,94,169,190,1,31,69,238,28,218,32,80,99,77,173,209,130,69,19,204,10,116,248,10,43,22,72,85,16,249,48,60,5,113,73,188,52,230,221,247,113,42,118,149,204,248,194,183,82,148,93,79,195,152,126,219,240,228,174,114,211,80,11,139,64,40,83,254,193,162,11,109,27,220,183,110,204,36,60,254,100,172,184,220,145,41,60,103,55,168,3,114,220,130,252,11,123,157,90,86,104,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnValuesVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7abb2342-791f-477f-8671-1ef0f9b98e17"),
				Name = "CreateColumnValuesVds",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,82,193,110,131,48,12,61,15,137,127,136,114,162,213,4,31,80,245,176,21,169,227,208,169,18,29,119,143,184,93,36,8,85,18,186,118,211,254,125,14,176,209,210,222,214,109,23,72,158,159,159,253,28,71,99,223,219,129,102,59,97,216,148,41,124,101,153,212,182,134,34,6,11,105,85,235,28,131,17,123,247,189,155,36,38,2,159,85,69,93,170,12,138,26,77,38,12,247,189,143,137,239,45,97,131,161,251,204,42,101,65,42,212,161,59,233,170,48,225,157,16,1,169,143,136,230,123,81,196,82,180,77,181,68,176,117,165,89,14,5,42,65,29,88,141,200,54,90,138,78,238,184,210,138,98,115,10,133,125,87,148,62,117,58,97,18,55,202,125,36,181,186,206,109,173,209,133,251,75,203,142,113,253,13,53,121,199,156,112,169,101,9,250,208,150,126,132,210,101,241,68,240,201,101,94,44,205,182,128,1,221,253,121,43,77,174,54,181,20,241,206,82,224,201,160,166,161,40,204,173,172,84,227,164,49,183,58,108,113,1,138,44,235,112,142,54,81,198,130,202,241,254,224,132,2,62,39,1,238,134,231,212,74,216,167,242,13,87,184,183,63,18,93,244,58,124,116,62,6,122,178,214,83,224,22,226,194,100,187,104,187,24,71,115,186,117,123,98,50,105,228,115,225,176,53,20,6,91,240,65,10,132,51,52,173,180,29,162,39,38,40,208,141,144,54,237,106,173,46,208,194,18,236,203,239,52,124,250,74,215,236,187,217,45,87,114,6,91,247,224,132,117,167,150,222,93,134,174,72,243,220,84,15,30,121,250,2,255,206,82,83,101,224,169,193,254,195,209,56,250,4,15,121,70,184,16,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareEntitiesForPagesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc8cf4b1-0f2d-468b-a7ef-7e279b4fce0c"),
				Name = "PrepareEntitiesForPages",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,149,223,111,218,48,16,199,159,225,175,240,242,228,72,16,181,133,105,67,180,149,40,132,138,137,254,216,104,183,135,105,15,46,185,182,158,130,211,217,78,219,172,226,127,159,127,132,36,13,73,137,212,151,189,128,115,182,63,119,247,181,239,252,72,56,18,137,56,139,130,56,132,105,20,6,192,103,1,58,66,12,158,208,105,76,3,236,76,123,189,189,233,222,248,160,219,243,253,126,183,63,250,212,235,14,70,227,65,247,115,191,55,248,216,239,141,71,251,131,19,199,29,182,31,21,73,239,184,74,30,224,156,172,64,65,28,253,237,216,41,96,146,202,100,177,188,135,21,185,158,5,11,8,97,41,213,26,108,71,174,118,104,135,248,90,0,31,71,140,169,49,141,152,219,110,121,227,40,140,87,12,59,106,163,163,191,167,60,90,97,103,145,8,203,51,182,31,247,192,1,59,103,132,145,59,224,58,2,199,245,102,194,255,19,147,16,107,250,215,24,120,114,73,184,154,145,192,177,227,23,34,74,119,57,29,84,105,118,181,131,17,83,106,248,207,18,88,160,40,42,159,93,252,226,210,14,186,37,161,0,87,9,85,169,132,34,77,168,144,148,25,81,36,143,193,202,182,12,169,90,127,205,168,252,159,164,27,151,162,42,200,87,55,245,110,9,247,139,26,214,202,82,171,35,225,65,182,212,127,125,2,87,20,196,70,212,118,171,137,170,185,172,139,77,237,248,1,149,38,255,162,35,149,222,72,168,52,212,92,201,254,38,67,151,144,157,252,78,194,24,82,74,110,125,131,96,50,211,12,101,42,165,185,9,166,108,45,94,10,75,49,182,47,17,101,88,255,104,191,222,28,110,229,69,172,14,197,162,11,241,154,64,46,170,210,40,69,101,34,216,156,118,193,89,245,202,134,17,216,124,43,98,200,132,168,113,251,70,144,121,69,236,60,221,243,72,98,77,63,143,195,16,155,40,204,21,111,122,30,239,220,62,99,184,178,153,84,145,106,18,80,136,218,90,170,192,24,68,20,216,254,160,162,183,170,218,107,232,21,10,87,109,184,228,209,18,132,152,71,119,142,169,216,70,5,168,226,161,146,146,144,254,133,140,38,176,219,172,134,211,103,107,66,77,153,18,158,28,70,55,191,21,180,131,230,170,37,164,31,199,199,184,119,144,2,161,92,151,151,170,85,233,203,86,11,212,15,90,199,60,115,41,38,22,148,221,33,60,57,241,159,97,25,203,136,163,224,38,27,30,161,215,157,195,243,153,136,57,76,78,114,19,118,93,244,210,110,165,152,217,132,72,242,13,136,122,133,81,144,15,143,26,182,47,207,122,6,187,13,231,145,88,39,173,167,123,26,2,194,57,217,211,127,105,8,173,86,197,51,173,92,23,86,159,130,44,180,165,67,43,195,118,67,25,102,176,178,190,141,112,219,205,50,3,202,98,11,108,2,43,245,76,3,162,183,8,127,120,69,210,237,97,245,32,147,76,137,214,174,155,241,115,107,193,47,253,220,20,161,198,215,90,255,236,58,188,106,152,190,121,197,123,139,94,182,14,103,173,125,40,23,235,246,186,109,184,10,54,141,184,142,85,52,184,52,195,246,150,214,219,5,176,75,137,225,63,188,62,147,152,66,10,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDeafLookupEditPageIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("96fd69ad-2ddf-4b31-96fb-1ba35e963175"),
				Name = "GetDeafLookupEditPageId",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,193,10,130,64,16,134,207,9,190,195,224,73,33,246,5,194,83,73,8,29,2,181,251,162,163,45,173,187,50,59,91,72,248,238,173,29,34,47,115,249,191,255,255,230,41,9,38,57,96,213,222,113,148,101,7,57,212,72,36,157,237,89,28,45,97,56,166,87,131,39,201,202,26,81,205,174,66,102,101,6,39,206,200,55,169,61,166,113,180,107,28,82,32,13,182,43,182,135,228,132,253,197,218,135,159,138,78,241,245,103,104,202,46,201,14,161,16,71,170,135,116,171,206,193,120,173,179,119,136,9,217,147,129,179,87,157,40,198,137,231,208,89,0,181,67,248,139,13,190,190,200,102,71,212,182,98,10,31,166,217,106,90,62,177,161,173,77,227,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateConfigureFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("41733806-45f1-46a0-b9f9-ad45b8ccf70f"),
				Name = "ConfigureFilterEdit",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,203,204,41,73,45,114,77,201,44,209,11,78,45,9,40,202,79,78,45,46,14,78,206,72,205,77,212,112,203,204,75,113,73,45,206,76,207,75,77,65,149,209,212,180,6,0,157,242,84,0,62,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsEntitySchemaNeedInChangesForListeningByProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f10fd2fd-7925-45f4-ab19-7a7a44d17e6e"),
				Name = "IsEntitySchemaNeedInChangesForListeningByProcess",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,205,110,131,48,16,132,207,248,41,156,27,142,42,231,1,16,151,80,82,89,106,171,74,85,122,183,96,67,44,193,146,122,237,74,168,234,187,215,64,20,32,225,230,159,249,102,199,227,221,150,153,19,143,55,138,114,116,198,117,159,197,25,26,157,157,53,86,80,10,254,203,34,11,206,91,228,39,93,19,36,236,47,138,216,118,55,48,115,224,168,74,153,127,251,160,137,95,188,9,235,230,226,58,177,198,51,246,163,45,47,218,218,55,248,174,27,224,41,63,18,216,172,69,132,194,153,22,165,250,176,109,1,20,2,85,6,65,94,119,175,134,28,32,88,202,110,104,50,88,193,44,198,155,70,93,129,125,244,204,31,69,35,93,2,141,167,129,137,213,66,160,28,52,98,197,93,30,12,150,253,229,190,11,207,190,175,65,220,249,246,194,224,189,230,243,12,100,42,236,5,241,50,238,211,132,203,201,146,110,57,231,35,197,98,146,84,72,78,99,17,186,185,246,62,82,114,108,141,134,236,251,110,220,125,233,218,67,95,100,60,125,135,224,105,202,209,215,117,242,15,202,75,244,156,26,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotNullColumnIdListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("18b5b1cf-cc73-46ba-9b92-a49a7c44c5dc"),
				Name = "GetNotNullColumnIdList",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,193,138,194,64,12,134,207,83,232,59,140,23,153,94,230,5,92,23,180,138,22,92,144,21,189,135,105,170,3,109,138,153,25,151,178,248,238,59,110,171,84,200,37,249,254,252,127,200,13,88,50,186,80,123,57,151,132,63,114,103,157,255,216,4,91,126,170,108,150,38,183,200,145,188,245,221,193,92,176,129,168,58,58,228,188,37,66,227,109,75,122,61,162,95,64,112,70,214,27,244,5,57,15,100,112,217,29,139,82,141,69,177,127,56,87,45,35,152,139,122,36,152,182,14,13,73,75,111,89,58,255,31,187,76,254,166,137,176,149,84,147,55,188,103,219,0,119,189,74,71,91,189,190,6,168,157,50,175,73,38,227,166,16,211,233,16,161,11,183,90,126,227,53,88,198,38,154,61,233,100,192,91,112,43,172,78,80,7,236,83,69,255,28,189,40,203,177,109,188,95,220,211,36,86,154,48,250,192,52,124,113,246,7,102,68,116,140,81,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityIdsWithoutPrcListenersColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aae7e67a-0157-4432-8bee-84986642e3a0"),
				Name = "GetEntityIdsWithoutPrcListenersColumn",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<QueryParameter>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,209,106,3,33,16,69,159,215,175,176,47,193,125,241,7,182,41,52,33,45,66,91,82,74,62,64,116,146,8,235,8,163,155,178,148,252,123,117,109,178,44,125,115,228,222,51,247,206,69,19,247,26,245,9,136,175,249,33,2,109,3,34,152,228,2,202,29,38,151,198,47,115,6,175,223,171,168,99,151,236,48,161,31,60,126,104,15,255,77,106,79,193,64,140,59,60,57,4,249,55,189,185,152,0,129,226,246,110,173,40,152,118,40,27,51,9,225,155,23,225,227,231,0,52,238,53,101,85,2,122,18,109,199,142,129,64,155,51,23,197,228,18,120,238,240,150,92,190,66,82,249,43,138,182,229,63,172,153,185,53,123,70,223,148,47,14,173,194,152,52,26,216,140,7,101,69,97,201,252,200,59,26,119,20,11,223,67,206,52,244,61,95,173,22,60,89,75,196,137,182,25,75,25,49,159,164,229,235,106,155,178,52,247,130,242,217,90,81,42,46,219,205,1,74,130,43,187,50,70,144,6,194,249,52,221,47,242,117,14,102,166,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEnableControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0141e003-ac1e-4c06-ab8e-43e82adfff88"),
				Name = "EnableControls",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,143,189,14,130,48,20,133,119,19,223,161,46,68,23,94,192,176,136,149,56,248,19,7,247,82,110,160,90,122,73,123,27,245,237,5,12,139,33,164,14,142,237,249,206,215,158,28,81,51,229,206,162,4,94,40,218,41,173,161,96,9,91,102,94,21,171,238,58,30,178,248,42,180,7,182,72,88,151,197,188,110,232,181,158,207,122,230,148,223,64,82,79,113,35,242,143,227,91,59,192,71,120,92,64,162,45,2,121,254,84,142,148,41,127,42,101,96,192,10,130,45,72,229,20,26,183,179,88,167,168,125,109,2,13,67,83,232,209,90,208,43,105,5,242,222,226,81,52,177,174,209,104,97,227,137,208,252,193,191,119,7,65,178,74,209,180,81,167,8,156,223,158,8,236,216,232,113,227,212,87,222,186,238,85,227,102,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("baad2147-19b4-41ef-977b-07664df9d6ec"),
				Name = "GetColumnValues",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,203,49,10,128,48,12,70,225,171,244,0,226,5,20,23,187,185,8,162,139,56,132,242,163,5,155,66,146,130,222,222,226,244,150,239,9,172,8,187,85,33,99,102,70,176,152,185,93,160,90,235,201,104,31,243,93,18,111,116,23,104,37,134,199,38,188,135,35,117,62,254,156,228,237,213,36,242,217,184,89,114,168,243,18,46,36,154,73,40,193,32,255,61,116,31,0,37,148,5,109,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlsEnabledPropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8edaee32-c963-4949-88e2-67f9cbf0c780"),
				Name = "SetControlsEnabledProperty",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5eacdaed-acec-42b9-8997-43a5de00784e"),
				Name = "isEnabled",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,177,14,130,48,16,64,119,19,255,161,44,14,14,240,1,134,69,68,195,160,49,26,221,11,156,114,177,244,12,189,38,250,247,86,36,162,68,140,113,108,251,250,222,181,41,145,18,104,86,196,177,150,169,130,92,132,194,67,211,44,38,195,65,218,2,229,153,175,177,102,228,235,54,43,160,148,187,228,78,119,119,188,80,44,44,230,126,141,59,193,90,30,193,223,2,207,224,32,173,226,136,148,45,245,94,42,11,102,106,153,73,251,109,249,25,22,163,81,127,180,157,170,161,227,28,57,190,160,97,212,199,13,100,84,229,17,105,174,72,25,231,172,251,239,167,119,222,143,10,200,78,175,165,223,202,181,238,161,73,30,162,15,227,247,15,228,12,193,184,177,36,102,41,57,43,220,145,195,145,180,249,75,87,171,230,168,24,170,206,253,31,34,238,177,95,168,230,139,92,100,28,220,0,81,49,144,233,41,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntitySchemaItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("926f766f-390c-4242-89f5-612090af6fa9"),
				Name = "GetEntitySchemaItem",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "ISchemaManagerItem<EntitySchema>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,205,43,201,44,169,12,78,206,72,205,77,244,77,204,75,76,79,45,210,115,79,45,241,44,73,205,117,170,12,245,76,209,64,86,0,228,107,90,3,0,235,18,60,94,72,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateTryFetchClientUnitSchemaFromDbMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a3b44c0e-94d2-4676-8442-7ab928fffa77"),
				Name = "TryFetchClientUnitSchemaFromDb",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c9a3dd29-dd75-42fd-88e9-02f279c1659d"),
				Name = "clientUnitSchema",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = Terrasoft.Common.ParameterDirection.Output,
				ValueTypeName = "out VwSysClientUnitSchema",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,193,10,130,64,20,69,215,9,254,195,195,149,130,248,3,86,139,20,193,93,32,214,122,154,121,232,84,190,137,153,41,17,241,223,155,50,138,220,190,243,238,189,135,95,37,146,173,73,218,138,183,216,49,216,0,97,15,135,190,26,76,182,96,97,109,80,103,138,8,185,149,138,162,212,247,30,76,3,87,36,228,235,96,62,225,92,190,57,211,195,218,88,45,169,137,65,157,206,46,180,13,35,24,125,111,53,66,80,151,34,136,97,207,26,156,187,75,1,83,60,35,183,124,84,250,98,110,140,163,251,249,31,77,190,40,41,197,228,123,147,147,208,104,239,154,128,47,116,147,2,45,111,11,173,186,124,23,254,36,163,244,9,101,225,39,113,244,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEnabledActivityTabControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4afefdfb-677c-4e60-96ae-50baecebc417"),
				Name = "SetEnabledActivityTabControls",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d052ba05-6782-4ddc-9522-c15b44d1f205"),
				Name = "entitySchemaUId",
				CreatedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				ModifiedInSchemaUId = new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,193,78,195,48,12,134,207,84,234,59,132,157,216,37,47,128,122,216,32,154,42,1,171,24,123,0,55,245,32,210,226,84,174,3,171,16,239,78,122,24,32,14,164,92,147,207,223,239,196,118,7,117,133,36,78,198,157,125,65,15,251,186,83,85,165,54,209,117,218,248,94,198,165,122,47,139,11,70,137,76,215,101,241,81,22,109,8,71,229,6,67,208,30,49,209,106,63,32,223,4,34,180,226,2,105,243,67,119,15,4,207,200,122,131,82,11,250,245,152,252,191,243,150,250,1,60,170,203,74,45,86,201,240,154,238,22,41,169,73,133,250,124,208,0,39,70,144,135,39,104,245,119,244,87,27,231,130,157,0,75,77,166,115,50,3,107,144,93,232,114,240,109,100,152,94,54,151,155,103,125,68,239,168,91,227,33,48,254,135,157,103,223,190,17,114,14,50,39,180,113,234,56,77,79,240,36,57,254,14,33,27,188,178,54,68,202,170,166,68,176,89,108,219,247,129,37,82,90,129,236,239,7,27,61,254,145,252,9,190,244,208,66,235,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpenEditPageUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21fa320f-74b6-4345-b8b1-6c0a9c265d1c"));
		}

		#endregion

	}

	#endregion

}

