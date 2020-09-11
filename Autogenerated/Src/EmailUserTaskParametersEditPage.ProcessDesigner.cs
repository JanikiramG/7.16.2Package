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

	#region Class: EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema

	/// <exclude/>
	public class EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TabPanel _emailTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel EmailTabPanel {
			get {
				return _emailTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _emailParametersTab;
		public Terrasoft.UI.WebControls.Controls.Tab EmailParametersTab {
			get {
				return _emailParametersTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _emailControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout EmailControlLayout {
			get {
				return _emailControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout12;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout12 {
			get {
				return _controlLayout12;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _recepientEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit RecepientEdit {
			get {
				return _recepientEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _ccEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CcEdit {
			get {
				return _ccEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _bccEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit BccEdit {
			get {
				return _bccEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout11;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout11 {
			get {
				return _controlLayout11;
			}
		}

		private Terrasoft.UI.WebControls.Controls.HtmlEdit _bodyEdit;
		public Terrasoft.UI.WebControls.Controls.HtmlEdit BodyEdit {
			get {
				return _bodyEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _activityParametersTab;
		public Terrasoft.UI.WebControls.Controls.Tab ActivityParametersTab {
			get {
				return _activityParametersTab;
			}
		}

		#endregion

		#region Constructors: Public

		public EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateUserTaskTitleEdit() {
			UserTaskTitleEdit.Image = new ControlImage {};
			UserTaskTitleEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateRecommendationEdit() {
			RecommendationEdit.Height = System.Web.UI.WebControls.Unit.Pixel(20);
			RecommendationEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateStartInEdit() {
			StartInEdit.Image = new ControlImage {};
			StartInEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateStartInPeriodEdit() {
			StartInPeriodEdit.Image = new ControlImage {};
			StartInPeriodEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout8() {
			ActivityControlLayout8.Image = new ControlImage {};
			ActivityControlLayout8.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateDurationEdit() {
			DurationEdit.Image = new ControlImage {};
			DurationEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateDurationPeriodEdit() {
			DurationPeriodEdit.Image = new ControlImage {};
			DurationPeriodEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout9() {
			ActivityControlLayout9.Image = new ControlImage {};
			ActivityControlLayout9.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityCategoryEdit() {
			ActivityCategoryEdit.Image = new ControlImage {};
			ActivityCategoryEdit.Enabled = false;
			ActivityCategoryEdit.Hidden = true;
			ActivityCategoryEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout3() {
			ActivityControlLayout3.Image = new ControlImage {};
			ActivityControlLayout3.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateOwnerEdit() {
			OwnerEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			OwnerEdit.Image = new ControlImage {};
			OwnerEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateRemindBeforeEdit() {
			RemindBeforeEdit.Image = new ControlImage {};
			RemindBeforeEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateRemindBeforePeriodEdit() {
			RemindBeforePeriodEdit.Image = new ControlImage {};
			RemindBeforePeriodEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout10() {
			ActivityControlLayout10.Image = new ControlImage {};
			ActivityControlLayout10.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateExecutionContextEdit() {
			ExecutionContextEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			ExecutionContextEdit.Image = new ControlImage {};
			ExecutionContextEdit.Hidden = false;
			ExecutionContextEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout4() {
			ActivityControlLayout4.Image = new ControlImage {};
			ActivityControlLayout4.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout2() {
			ActivityControlLayout2.Image = new ControlImage {};
			ActivityControlLayout2.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout1() {
			BaseProcessUserTaskPageControlLayout1.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout1.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateBaseProcessUserTaskPageControlLayout2() {
			BaseProcessUserTaskPageControlLayout2.Image = new ControlImage {};
			BaseProcessUserTaskPageControlLayout2.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout11() {
			ActivityControlLayout11.Image = new ControlImage {};
			ActivityControlLayout11.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateLeadEdit() {
			LeadEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			LeadEdit.Image = new ControlImage {};
			LeadEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateAccountEdit() {
			AccountEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			AccountEdit.Image = new ControlImage {};
			AccountEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateContactEdit() {
			ContactEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			ContactEdit.Image = new ControlImage {};
			ContactEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateOpportunityEdit() {
			OpportunityEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			OpportunityEdit.Image = new ControlImage {};
			OpportunityEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout6() {
			ActivityControlLayout6.Image = new ControlImage {};
			ActivityControlLayout6.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateInvoiceEdit() {
			InvoiceEdit.Image = new ControlImage {};
			InvoiceEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateDocumentEdit() {
			DocumentEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			DocumentEdit.Image = new ControlImage {};
			DocumentEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout7() {
			ActivityControlLayout7.Image = new ControlImage {};
			ActivityControlLayout7.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout5() {
			ActivityControlLayout5.Image = new ControlImage {};
			ActivityControlLayout5.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateActivityControlLayout1() {
			ActivityControlLayout1.Padding = "5 5 5 5";
			ActivityControlLayout1.Image = new ControlImage {};
			ActivityControlLayout1.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			RealUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			Name = "EmailUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
			ParentSchemaUId = new Guid("3f7eb63c-4fec-44f8-980b-c7a258249a71");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 450;
			UseProfile = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema();
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
			TopControlLayout.InsertItem(0, CreateEmailTabPanel());
			EmailTabPanel.InsertItem(0, CreateEmailParametersTab());
			EmailParametersTab.InsertItem(0, CreateEmailControlLayout());
			EmailControlLayout.InsertItem(0, CreateControlLayout12());
			ControlLayout12.MoveItem(0, UserTaskTitleEdit);
			ControlLayout12.InsertItem(1, CreateRecepientEdit());
			ControlLayout12.InsertItem(2, CreateCcEdit());
			ControlLayout12.InsertItem(3, CreateBccEdit());
			ControlLayout12.MoveItem(4, RecommendationEdit);
			EmailControlLayout.InsertItem(1, CreateControlLayout11());
			ControlLayout11.InsertItem(0, CreateBodyEdit());
			EmailTabPanel.InsertItem(1, CreateActivityParametersTab());
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
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateEmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema() {
			var schema = new EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateRecepientEdit() {
			_recepientEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_recepientEdit.UId = new Guid("9c00344e-7b2c-484e-be32-b85518887b99");
			_recepientEdit.Name = "RecepientEdit";
			_recepientEdit.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_recepientEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_recepientEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_recepientEdit.Tag = "";
			_recepientEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_recepientEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_recepientEdit.Image = new ControlImage {};
			_recepientEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_recepientEdit.Required = true;
			return _recepientEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCcEdit() {
			_ccEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_ccEdit.UId = new Guid("7f401ac0-75f9-4f86-a97b-63b0c1c04a85");
			_ccEdit.Name = "CcEdit";
			_ccEdit.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_ccEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_ccEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_ccEdit.Tag = "";
			_ccEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_ccEdit.Image = new ControlImage {};
			_ccEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _ccEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateBccEdit() {
			_bccEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_bccEdit.UId = new Guid("7a937e94-34a1-42a7-9468-ae271fa3d964");
			_bccEdit.Name = "BccEdit";
			_bccEdit.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_bccEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_bccEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bccEdit.Tag = "";
			_bccEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_bccEdit.Image = new ControlImage {};
			_bccEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _bccEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout12() {
			_controlLayout12 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout12.UId = new Guid("40ed5bb8-b7ed-45f6-a2d9-dc19873280ec");
			_controlLayout12.Name = "ControlLayout12";
			_controlLayout12.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_controlLayout12.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_controlLayout12.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout12.Tag = "";
			_controlLayout12.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout12.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout12.FitHeightByContent = true;
			_controlLayout12.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout12.StartNewAlignGroup = false;
			_controlLayout12.Image = new ControlImage {};
			_controlLayout12.Edges = "";
			return _controlLayout12;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.HtmlEdit CreateBodyEdit() {
			_bodyEdit = new Terrasoft.UI.WebControls.Controls.HtmlEdit();
			_bodyEdit.UId = new Guid("30e927be-90e2-4d03-9ef7-01d8d1d39921");
			_bodyEdit.Name = "BodyEdit";
			_bodyEdit.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_bodyEdit.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_bodyEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bodyEdit.Tag = "";
			_bodyEdit.Edges = "0 0 0 0";
			_bodyEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_bodyEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _bodyEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout11() {
			_controlLayout11 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout11.UId = new Guid("50999737-9129-4893-ad19-b2506aaf5b86");
			_controlLayout11.Name = "ControlLayout11";
			_controlLayout11.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_controlLayout11.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_controlLayout11.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout11.Tag = "";
			_controlLayout11.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout11.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout11.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout11.StartNewAlignGroup = false;
			_controlLayout11.Image = new ControlImage {};
			_controlLayout11.Edges = "1 1 1 1";
			return _controlLayout11;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateEmailControlLayout() {
			_emailControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_emailControlLayout.UId = new Guid("d6d3795b-88ce-49a9-a873-018e5ba3b7cf");
			_emailControlLayout.Name = "EmailControlLayout";
			_emailControlLayout.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_emailControlLayout.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_emailControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_emailControlLayout.Tag = "";
			_emailControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_emailControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_emailControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_emailControlLayout.Padding = "5 5 5 5";
			_emailControlLayout.StartNewAlignGroup = false;
			_emailControlLayout.Image = new ControlImage {};
			_emailControlLayout.Edges = "";
			return _emailControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateEmailParametersTab() {
			_emailParametersTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_emailParametersTab.UId = new Guid("9a9f03e1-1809-4176-a69f-744243bf0cd7");
			_emailParametersTab.Name = "EmailParametersTab";
			_emailParametersTab.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_emailParametersTab.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_emailParametersTab.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_emailParametersTab.Tag = "";
			_emailParametersTab.Image = new ControlImage {};
			return _emailParametersTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateActivityParametersTab() {
			_activityParametersTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_activityParametersTab.UId = new Guid("fa866ec8-af61-45ee-aac1-0ea7ed87ffae");
			_activityParametersTab.Name = "ActivityParametersTab";
			_activityParametersTab.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_activityParametersTab.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_activityParametersTab.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_activityParametersTab.Tag = "";
			_activityParametersTab.Image = new ControlImage {};
			return _activityParametersTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateEmailTabPanel() {
			_emailTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_emailTabPanel.UId = new Guid("de0f52cc-1e23-4b1e-a8c3-f74b7896b755");
			_emailTabPanel.Name = "EmailTabPanel";
			_emailTabPanel.CreatedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_emailTabPanel.ModifiedInSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			_emailTabPanel.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_emailTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			_emailTabPanel.Tag = "";
			_emailTabPanel.ActiveTabIndex = 0;
			_emailTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_emailTabPanel.StartNewAlignGroup = false;
			_emailTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _emailTabPanel;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl
	{

		public EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			SchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
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

		private ProcessFlowElement _emailEventSubProcess;
		public ProcessFlowElement EmailEventSubProcess {
			get {
				return _emailEventSubProcess ?? (_emailEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EmailEventSubProcess",
					SchemaElementUId = new Guid("04fd0599-7900-4945-8bdf-dce824042e1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskChildInitAfterBase;
		public ProcessScriptTask ScriptTaskChildInitAfterBase {
			get {
				return _scriptTaskChildInitAfterBase ?? (_scriptTaskChildInitAfterBase = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskChildInitAfterBase",
					SchemaElementUId = new Guid("f96ed46a-36e0-46a7-8c79-db1068c34cd1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskChildInitAfterBaseExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageChildInit;
		public ProcessFlowElement StartMessageChildInit {
			get {
				return _startMessageChildInit ?? (_startMessageChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildInit",
					SchemaElementUId = new Guid("0064052d-42b9-4597-8426-37aa48e4a2c5"),
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
					SchemaElementUId = new Guid("2968ad14-0c2b-40ad-9783-b04fa7817c5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _emailTabPanelTabChangeEventSubProcess;
		public ProcessFlowElement EmailTabPanelTabChangeEventSubProcess {
			get {
				return _emailTabPanelTabChangeEventSubProcess ?? (_emailTabPanelTabChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EmailTabPanelTabChangeEventSubProcess",
					SchemaElementUId = new Guid("a2b9de2f-0975-4d6c-80ad-6f54280d2a76"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _emailTabPanelTabChangeStartMessage;
		public ProcessFlowElement EmailTabPanelTabChangeStartMessage {
			get {
				return _emailTabPanelTabChangeStartMessage ?? (_emailTabPanelTabChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmailTabPanelTabChangeStartMessage",
					SchemaElementUId = new Guid("92845127-def0-4a6b-a033-b54d8147b0d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _emailTabPanelTabChangeScriptTask;
		public ProcessScriptTask EmailTabPanelTabChangeScriptTask {
			get {
				return _emailTabPanelTabChangeScriptTask ?? (_emailTabPanelTabChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmailTabPanelTabChangeScriptTask",
					SchemaElementUId = new Guid("2cb16582-e1ae-494e-97c3-4e10894b43ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmailTabPanelTabChangeScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EmailEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailEventSubProcess };
			FlowElements[ScriptTaskChildInitAfterBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskChildInitAfterBase };
			FlowElements[StartMessageChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildInit };
			FlowElements[IntermediateThrowMessageEventInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventInit };
			FlowElements[EmailTabPanelTabChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailTabPanelTabChangeEventSubProcess };
			FlowElements[EmailTabPanelTabChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailTabPanelTabChangeStartMessage };
			FlowElements[EmailTabPanelTabChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailTabPanelTabChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EmailEventSubProcess":
						break;
					case "ScriptTaskChildInitAfterBase":
						break;
					case "StartMessageChildInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventInit");
						break;
					case "IntermediateThrowMessageEventInit":
						e.Context.QueueTasks.Enqueue("ScriptTaskChildInitAfterBase");
						break;
					case "EmailTabPanelTabChangeEventSubProcess":
						break;
					case "EmailTabPanelTabChangeStartMessage":
						e.Context.QueueTasks.Enqueue("EmailTabPanelTabChangeScriptTask");
						break;
					case "EmailTabPanelTabChangeScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageChildInit");
			ActivatedEventElements.Add("EmailTabPanelTabChangeStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EmailEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTaskChildInitAfterBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskChildInitAfterBase";
					result = ScriptTaskChildInitAfterBase.Execute(context, ScriptTaskChildInitAfterBaseExecute);
					break;
				case "StartMessageChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildInit";
					result = StartMessageChildInit.Execute(context);
					break;
				case "IntermediateThrowMessageEventInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEventInit.Execute(context);
					break;
				case "EmailTabPanelTabChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EmailTabPanelTabChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmailTabPanelTabChangeStartMessage";
					result = EmailTabPanelTabChangeStartMessage.Execute(context);
					break;
				case "EmailTabPanelTabChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmailTabPanelTabChangeScriptTask";
					result = EmailTabPanelTabChangeScriptTask.Execute(context, EmailTabPanelTabChangeScriptTaskExecute);
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

		public virtual bool ScriptTaskChildInitAfterBaseExecute(ProcessExecutingContext context) {
			InvokeInitBaseActivityParametersEditPage();
			return true;
		}

		public virtual bool EmailTabPanelTabChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.EmailTabPanel.ActiveTabIndex == 1 && !IsUsedActivityControls) {
				SetActivityDurationPeriodEditControlsValue();
				SetDefValueParameterValueEdit(GetActivityControlsBinding());
				IsUsedActivityControls = true;
			}
			return true;
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			Dictionary<string, Terrasoft.UI.WebControls.WebControl> activityControlsBinding = GetActivityControlsBinding();
			var emailControlsBinding = new Dictionary<string, Terrasoft.UI.WebControls.WebControl> {
				{"Recepient", Page.RecepientEdit},
				{"CopyRecepient", Page.CcEdit},
				{"BlindCopyRecepient", Page.BccEdit},
				{"Body", Page.BodyEdit}
			};
			foreach(KeyValuePair<string, Terrasoft.UI.WebControls.WebControl> activityControlBinding in activityControlsBinding) {
				emailControlsBinding.Add(activityControlBinding.Key, activityControlBinding.Value);
			}
			return emailControlsBinding;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageChildInit")) {
							context.QueueTasks.Enqueue("StartMessageChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "EmailTabPanelTabChange":
							if (ActivatedEventElements.Contains("EmailTabPanelTabChangeStartMessage")) {
							context.QueueTasks.Enqueue("EmailTabPanelTabChangeStartMessage");
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

	#region Class: EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess

	/// <exclude/>
	public class EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess : EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess<Terrasoft.WebApp.EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl>
	{

		public EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftSchemaUserControl : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TabPanel EmailTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("EmailTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab EmailParametersTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("EmailParametersTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout EmailControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("EmailControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout12 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout12", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit RecepientEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("RecepientEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CcEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CcEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit BccEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("BccEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout11 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout11", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.HtmlEdit BodyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.HtmlEdit)PageContainer.FindPageControl("BodyEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab ActivityParametersTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("ActivityParametersTab", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EmailTabPanel.AjaxEvents.TabChange.Event += EmailTabPanelTabChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EmailTabPanel.AjaxEvents.TabChange.Event -= EmailTabPanelTabChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess(UserConnection);
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

		public virtual void EmailTabPanelTabChange(object sender, EventArgs e) {
			object result = ThrowEvent("EmailTabPanelTabChange");
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
			SchemaName = "EmailUserTaskParametersEditPage_ProcessDesigner_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema : Terrasoft.WebApp.BaseProcessUserTaskParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcess";
			UId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.General;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet331 = CreateLaneSet331LaneSet();
			LaneSets.Add(schemaLaneSet331);
			ProcessSchemaLane schemaLane1061 = CreateLane1061Lane();
			schemaLaneSet331.Lanes.Add(schemaLane1061);
			ProcessSchemaLane schemaEmailTabPanelTabChangeLane = CreateEmailTabPanelTabChangeLaneLane();
			schemaLaneSet331.Lanes.Add(schemaEmailTabPanelTabChangeLane);
			ProcessSchemaEventSubProcess emaileventsubprocess = CreateEmailEventSubProcessEventSubProcess();
			FlowElements.Add(emaileventsubprocess);
			ProcessSchemaEventSubProcess emailtabpaneltabchangeeventsubprocess = CreateEmailTabPanelTabChangeEventSubProcessEventSubProcess();
			FlowElements.Add(emailtabpaneltabchangeeventsubprocess);
			ProcessSchemaScriptTask scripttaskchildinitafterbase = CreateScriptTaskChildInitAfterBaseScriptTask();
			emaileventsubprocess.FlowElements.Add(scripttaskchildinitafterbase);
			ProcessSchemaStartMessageEvent startmessagechildinit = CreateStartMessageChildInitStartMessageEvent();
			emaileventsubprocess.FlowElements.Add(startmessagechildinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventinit = CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent();
			emaileventsubprocess.FlowElements.Add(intermediatethrowmessageeventinit);
			ProcessSchemaStartMessageEvent emailtabpaneltabchangestartmessage = CreateEmailTabPanelTabChangeStartMessageStartMessageEvent();
			emailtabpaneltabchangeeventsubprocess.FlowElements.Add(emailtabpaneltabchangestartmessage);
			ProcessSchemaScriptTask emailtabpaneltabchangescripttask = CreateEmailTabPanelTabChangeScriptTaskScriptTask();
			emailtabpaneltabchangeeventsubprocess.FlowElements.Add(emailtabpaneltabchangescripttask);
			FlowElements.Add(CreateSequenceFlow6534SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6535SequenceFlow());
			FlowElements.Add(CreateEmailTabPanelTabChangeSequenceFlowSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6534SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6534",
				UId = new Guid("5a1433e1-e57a-4395-84ab-f754ace07e8a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				CurveCenterPosition = new Point(161, 72),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0064052d-42b9-4597-8426-37aa48e4a2c5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2968ad14-0c2b-40ad-9783-b04fa7817c5c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6535SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6535",
				UId = new Guid("79949955-38f4-4010-a509-0711881d192c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				CurveCenterPosition = new Point(262, 68),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2968ad14-0c2b-40ad-9783-b04fa7817c5c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f96ed46a-36e0-46a7-8c79-db1068c34cd1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateEmailTabPanelTabChangeSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "EmailTabPanelTabChangeSequenceFlow",
				UId = new Guid("e0cb50ac-b190-4c5e-a750-a1aaa44988b2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("92845127-def0-4a6b-a033-b54d8147b0d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2cb16582-e1ae-494e-97c3-4e10894b43ce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet331LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet331 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6a926bb2-d2b3-4856-8a48-719579bd6d65"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"LaneSet331",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1183, 346),
				UseBackgroundMode = false
			};
			return schemaLaneSet331;
		}

		protected virtual ProcessSchemaLane CreateLane1061Lane() {
			ProcessSchemaLane schemaLane1061 = new ProcessSchemaLane(this) {
				UId = new Guid("39fbd266-9db1-4296-ac30-0221ee4d2d47"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("6a926bb2-d2b3-4856-8a48-719579bd6d65"),
				CreatedInOwnerSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"Lane1061",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 164),
				Size = new Size(1154, 182),
				UseBackgroundMode = false
			};
			return schemaLane1061;
		}

		protected virtual ProcessSchemaLane CreateEmailTabPanelTabChangeLaneLane() {
			ProcessSchemaLane schemaEmailTabPanelTabChangeLane = new ProcessSchemaLane(this) {
				UId = new Guid("50e3b56f-9661-425a-9be4-0a94ca7a5bed"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6a926bb2-d2b3-4856-8a48-719579bd6d65"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"EmailTabPanelTabChangeLane",
				Position = new Point(29, 0),
				Size = new Size(1154, 159),
				UseBackgroundMode = false
			};
			return schemaEmailTabPanelTabChangeLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEmailEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEmailEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("04fd0599-7900-4945-8bdf-dce824042e1e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39fbd266-9db1-4296-ac30-0221ee4d2d47"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"EmailEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(297, 161),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEmailEventSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskChildInitAfterBaseScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f96ed46a-36e0-46a7-8c79-db1068c34cd1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04fd0599-7900-4945-8bdf-dce824042e1e"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"ScriptTaskChildInitAfterBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,43,203,207,78,245,204,203,44,113,74,44,78,117,76,46,201,44,203,44,169,12,72,44,74,204,77,45,73,45,42,118,77,201,44,9,72,76,79,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,4,27,106,220,57,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0064052d-42b9-4597-8426-37aa48e4a2c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04fd0599-7900-4945-8bdf-dce824042e1e"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"StartMessageChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2968ad14-0c2b-40ad-9783-b04fa7817c5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04fd0599-7900-4945-8bdf-dce824042e1e"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"IntermediateThrowMessageEventInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEmailTabPanelTabChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEmailTabPanelTabChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a2b9de2f-0975-4d6c-80ad-6f54280d2a76"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50e3b56f-9661-425a-9be4-0a94ca7a5bed"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"EmailTabPanelTabChangeEventSubProcess",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(234, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEmailTabPanelTabChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmailTabPanelTabChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("92845127-def0-4a6b-a033-b54d8147b0d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2b9de2f-0975-4d6c-80ad-6f54280d2a76"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EmailTabPanelTabChange",
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"EmailTabPanelTabChangeStartMessage",
				Position = new Point(35, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEmailTabPanelTabChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2cb16582-e1ae-494e-97c3-4e10894b43ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2b9de2f-0975-4d6c-80ad-6f54280d2a76"),
				CreatedInOwnerSchemaUId = new Guid("08a408c9-611a-44e4-92d3-8bd5ae4ca535"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"),
				Name = @"EmailTabPanelTabChangeScriptTask",
				Position = new Point(133, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,189,10,194,64,16,132,107,3,121,135,181,9,73,19,176,150,20,106,130,164,59,240,167,63,189,141,44,92,238,96,179,39,138,248,238,198,11,193,198,114,102,190,25,134,58,200,149,190,97,217,244,154,236,81,95,148,118,104,203,205,85,232,142,163,108,157,193,7,84,21,172,32,203,96,217,14,167,1,77,76,73,158,59,239,132,189,29,10,120,165,201,226,128,50,7,117,96,45,228,157,66,38,111,26,67,50,163,103,109,3,230,197,122,226,107,236,162,161,52,235,30,5,57,170,47,159,239,127,107,115,119,75,206,144,187,229,69,172,255,191,2,21,8,7,28,129,119,154,48,74,96,55,25,31,133,97,112,118,233,0,0,0 }
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

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,81,193,106,2,65,12,61,187,176,255,48,120,90,97,153,31,176,21,220,85,164,244,34,165,182,231,116,38,106,96,157,145,108,180,12,226,191,59,93,80,20,199,75,189,133,188,247,146,151,151,9,25,33,239,128,195,75,43,76,110,85,170,79,100,134,214,47,69,47,222,244,55,254,212,222,9,251,166,189,170,71,10,162,108,79,18,206,96,69,206,70,181,122,85,51,148,113,26,44,6,195,60,219,3,43,220,0,53,247,74,135,191,106,242,79,63,135,60,235,29,250,31,104,112,75,232,164,95,170,57,172,80,95,26,83,75,114,44,59,82,237,183,225,142,88,155,43,70,213,68,79,73,90,101,110,120,222,134,11,18,235,14,202,179,99,60,115,233,25,193,172,139,119,12,95,208,236,112,14,196,79,37,124,142,137,220,163,236,7,93,8,169,108,245,216,218,34,61,79,71,131,229,131,93,186,115,254,247,180,120,20,163,236,216,37,95,55,60,1,154,157,107,222,69,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailUserTaskParametersEditPage_ProcessDesigner_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed740ce2-3927-41ba-baab-ab62298a70ce"));
		}

		#endregion

	}

	#endregion

}

