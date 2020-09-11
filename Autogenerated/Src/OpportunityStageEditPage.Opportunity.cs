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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: OpportunityStageEditPageSchema

	/// <exclude/>
	public class OpportunityStageEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _numberEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit NumberEdit {
			get {
				return _numberEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _maxProbabilityEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit MaxProbabilityEdit {
			get {
				return _maxProbabilityEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _nextStepTermEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit NextStepTermEdit {
			get {
				return _nextStepTermEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _endEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox EndEdit {
			get {
				return _endEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _successfulEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox SuccessfulEdit {
			get {
				return _successfulEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _checkBox1;
		public Terrasoft.UI.WebControls.Controls.CheckBox CheckBox1 {
			get {
				return _checkBox1;
			}
		}

		#endregion

		#region Constructors: Public

		public OpportunityStageEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public OpportunityStageEditPageSchema(OpportunityStageEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("295e983d-c2b3-4628-a9f8-a061567fa7fb");
			NameEdit.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("6baf2b47-fcc2-4745-ae3f-aba0a4d1359b");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			RealUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			Name = "OpportunityStageEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 370;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateOpportunityStageEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateApplyChangesButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDesignerModeButton();
			UpdateContextHelpButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			UpdateDescriptionEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.InsertItem(1, CreateNumberEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
			MainControlLayout.InsertItem(3, CreateMaxProbabilityEdit());
			MainControlLayout.InsertItem(4, CreateNextStepTermEdit());
			MainControlLayout.InsertItem(5, CreateEndEdit());
			MainControlLayout.InsertItem(6, CreateSuccessfulEdit());
			MainControlLayout.InsertItem(7, CreateCheckBox1());
			MainControlLayout.MoveItem(8, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateOpportunityStageEditPageEventsProcessSchema() {
			var schema = new OpportunityStageEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateNumberEdit() {
			_numberEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_numberEdit.UId = new Guid("902b25d1-68cf-44c2-a6ae-9e3c9cc5b9c6");
			_numberEdit.Name = "NumberEdit";
			_numberEdit.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_numberEdit.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_numberEdit.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			_numberEdit.Tag = "";
			_numberEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_numberEdit.Image = new ControlImage {};
			_numberEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_numberEdit.DataSource = "DataSource";
			_numberEdit.ColumnUId = new Guid("e6ba1477-24de-40c7-9f1e-85808c89d214");
			return _numberEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateMaxProbabilityEdit() {
			_maxProbabilityEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_maxProbabilityEdit.UId = new Guid("542117f3-18aa-4ae7-891b-277ed38ecd5b");
			_maxProbabilityEdit.Name = "MaxProbabilityEdit";
			_maxProbabilityEdit.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_maxProbabilityEdit.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_maxProbabilityEdit.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			_maxProbabilityEdit.Tag = "";
			_maxProbabilityEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_maxProbabilityEdit.Image = new ControlImage {};
			_maxProbabilityEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_maxProbabilityEdit.DataSource = "DataSource";
			_maxProbabilityEdit.ColumnUId = new Guid("5a0d810b-bfba-429b-b6d3-dd062e197e3d");
			return _maxProbabilityEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateNextStepTermEdit() {
			_nextStepTermEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_nextStepTermEdit.UId = new Guid("531eb66c-54cf-4568-bf6b-a28e5f334746");
			_nextStepTermEdit.Name = "NextStepTermEdit";
			_nextStepTermEdit.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_nextStepTermEdit.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_nextStepTermEdit.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			_nextStepTermEdit.Tag = "";
			_nextStepTermEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nextStepTermEdit.Image = new ControlImage {};
			_nextStepTermEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nextStepTermEdit.DataSource = "DataSource";
			_nextStepTermEdit.ColumnUId = new Guid("7929e5c1-6e56-406e-b289-323009b50a5c");
			return _nextStepTermEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateEndEdit() {
			_endEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_endEdit.UId = new Guid("c5fac2a6-176b-4ee5-b74b-fcc9afe0f67c");
			_endEdit.Name = "EndEdit";
			_endEdit.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_endEdit.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_endEdit.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			_endEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_endEdit.Tag = "";
			_endEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_endEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_endEdit.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_endEdit.DataSource = "DataSource";
			_endEdit.ColumnUId = new Guid("6b8aaf88-6a4c-4e5a-9caf-7171c34a1f08");
			return _endEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateSuccessfulEdit() {
			_successfulEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_successfulEdit.UId = new Guid("c197c875-5039-4d71-852f-284fb4242459");
			_successfulEdit.Name = "SuccessfulEdit";
			_successfulEdit.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_successfulEdit.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_successfulEdit.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			_successfulEdit.Tag = "";
			_successfulEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_successfulEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_successfulEdit.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_successfulEdit.DataSource = "DataSource";
			_successfulEdit.ColumnUId = new Guid("620192f3-ad65-40e4-8349-0c9878d46eda");
			return _successfulEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateCheckBox1() {
			_checkBox1 = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_checkBox1.UId = new Guid("f2ecd95f-b2e0-4d43-a2da-6bb9af8371e1");
			_checkBox1.Name = "CheckBox1";
			_checkBox1.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_checkBox1.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			_checkBox1.CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340");
			_checkBox1.Tag = "";
			_checkBox1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkBox1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_checkBox1.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_checkBox1.DataSource = "DataSource";
			_checkBox1.ColumnUId = new Guid("f84492e3-66fe-4164-b287-28e41711ac4c");
			return _checkBox1;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			DataSource.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("acf7a876-9c1f-4ff4-b506-2557e46bf6cb");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("5966cd95-6142-4019-a7ac-beec6e4bcd87");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("0956e49b-47e2-444b-b8de-d362c4db93ac");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("59e8ccbf-6a23-4311-a751-8e60745972d9");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("4ddeecd7-62d1-401f-abae-6be850f3be84");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("295e983d-c2b3-4628-a9f8-a061567fa7fb");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("6baf2b47-fcc2-4745-ae3f-aba0a4d1359b");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("146e7f2e-a20d-4cc2-9c5c-bcc8dde6ed63");
			if (column != null) {
				column.UId = new Guid("6b8aaf88-6a4c-4e5a-9caf-7171c34a1f08");
				column.Name = @"End";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9d36f697-56db-4539-9809-b07f01dfe9a0");
			if (column != null) {
				column.UId = new Guid("620192f3-ad65-40e4-8349-0c9878d46eda");
				column.Name = @"Successful";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5cff1d37-c039-46ce-ac3e-a4d7abe49c5f");
			if (column != null) {
				column.UId = new Guid("e6ba1477-24de-40c7-9f1e-85808c89d214");
				column.Name = @"Number";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("e885ae04-b0b2-43df-9b9b-5fa6fcd0eb53");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("388070cb-b942-4af8-a6fb-4b722d30847e");
			if (column != null) {
				column.UId = new Guid("5a0d810b-bfba-429b-b6d3-dd062e197e3d");
				column.Name = @"MaxProbability";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5112d458-569f-445a-90a9-a4c8e0041b28");
			if (column != null) {
				column.UId = new Guid("7929e5c1-6e56-406e-b289-323009b50a5c");
				column.Name = @"NextStepTerm";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("875d786d-74b6-4f1c-b885-5fb7da04453b");
			if (column != null) {
				column.UId = new Guid("f84492e3-66fe-4164-b287-28e41711ac4c");
				column.Name = @"ShowInFunnel";
				column.CreatedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.ModifiedInSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new OpportunityStageEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new OpportunityStageEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new OpportunityStageEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStageEditPageEventsProcess

	/// <exclude/>
	public class OpportunityStageEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.OpportunityStageEditPageSchemaUserControl
	{

		public OpportunityStageEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityStageEditPageEventsProcess";
			SchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83");
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

		private ProcessFlowElement _subProcessEndEditCheck;
		public ProcessFlowElement SubProcessEndEditCheck {
			get {
				return _subProcessEndEditCheck ?? (_subProcessEndEditCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessEndEditCheck",
					SchemaElementUId = new Guid("789e9c7a-ba20-4f70-99f8-a0878beb13a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageEndEditCheck;
		public ProcessFlowElement StartMessageEndEditCheck {
			get {
				return _startMessageEndEditCheck ?? (_startMessageEndEditCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageEndEditCheck",
					SchemaElementUId = new Guid("23eb8799-e8ac-40b4-a7c5-d22094986e34"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptEndEditCheck;
		public ProcessScriptTask ScriptEndEditCheck {
			get {
				return _scriptEndEditCheck ?? (_scriptEndEditCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptEndEditCheck",
					SchemaElementUId = new Guid("662bb5d9-f9e2-4965-a2bd-30f128d9ea07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptEndEditCheckExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessChildPageLoadComplete;
		public ProcessFlowElement SubProcessChildPageLoadComplete {
			get {
				return _subProcessChildPageLoadComplete ?? (_subProcessChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChildPageLoadComplete",
					SchemaElementUId = new Guid("a0efca5c-2212-4198-8cac-fea672ce5809"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildPageLoadComplete;
		public ProcessFlowElement StartMessageChildPageLoadComplete {
			get {
				return _startMessageChildPageLoadComplete ?? (_startMessageChildPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildPageLoadComplete",
					SchemaElementUId = new Guid("6e0c2007-86ab-4123-8ac2-a420f8064cc1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBasePageLoadComplete1;
		public ProcessThrowMessageEvent IntermediateThrowBasePageLoadComplete1 {
			get {
				return _intermediateThrowBasePageLoadComplete1 ?? (_intermediateThrowBasePageLoadComplete1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBasePageLoadComplete1",
					SchemaElementUId = new Guid("19593108-8559-4873-8d1f-49c41845175d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptChildPageLoadComplete;
		public ProcessScriptTask ScriptChildPageLoadComplete {
			get {
				return _scriptChildPageLoadComplete ?? (_scriptChildPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildPageLoadComplete",
					SchemaElementUId = new Guid("4af5e7d5-5108-4c8e-94f8-72334689fce7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildPageLoadCompleteExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildInitStartMessage;
		public ProcessFlowElement EventSubProcessChildInitStartMessage {
			get {
				return _eventSubProcessChildInitStartMessage ?? (_eventSubProcessChildInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildInitStartMessage",
					SchemaElementUId = new Guid("51fe9e06-8852-4bd6-b4e3-4012ac0b61dd"),
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
					SchemaElementUId = new Guid("165751c4-d506-4c48-996d-828ae2d23028"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("3b34d6d5-beb5-4e74-89fc-7885dfc90f0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
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
					SchemaElementUId = new Guid("777a3066-4d7b-4984-8258-77276da6c737"),
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
			FlowElements[SubProcessEndEditCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessEndEditCheck };
			FlowElements[StartMessageEndEditCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageEndEditCheck };
			FlowElements[ScriptEndEditCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptEndEditCheck };
			FlowElements[SubProcessChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChildPageLoadComplete };
			FlowElements[StartMessageChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildPageLoadComplete };
			FlowElements[IntermediateThrowBasePageLoadComplete1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBasePageLoadComplete1 };
			FlowElements[ScriptChildPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildPageLoadComplete };
			FlowElements[EventSubProcessChildInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildInitStartMessage };
			FlowElements[ChildInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitStartMessage };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessEndEditCheck":
						break;
					case "StartMessageEndEditCheck":
						e.Context.QueueTasks.Enqueue("ScriptEndEditCheck");
						break;
					case "ScriptEndEditCheck":
						break;
					case "SubProcessChildPageLoadComplete":
						break;
					case "StartMessageChildPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBasePageLoadComplete1");
						break;
					case "IntermediateThrowBasePageLoadComplete1":
						e.Context.QueueTasks.Enqueue("ScriptChildPageLoadComplete");
						break;
					case "ScriptChildPageLoadComplete":
						break;
					case "EventSubProcessChildInitStartMessage":
						break;
					case "ChildInitStartMessage":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitScriptTask":
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageEndEditCheck");
			ActivatedEventElements.Add("StartMessageChildPageLoadComplete");
			ActivatedEventElements.Add("ChildInitStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessEndEditCheck":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageEndEditCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageEndEditCheck";
					result = StartMessageEndEditCheck.Execute(context);
					break;
				case "ScriptEndEditCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptEndEditCheck";
					result = ScriptEndEditCheck.Execute(context, ScriptEndEditCheckExecute);
					break;
				case "SubProcessChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildPageLoadComplete";
					result = StartMessageChildPageLoadComplete.Execute(context);
					break;
				case "IntermediateThrowBasePageLoadComplete1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowBasePageLoadComplete1.Execute(context);
					break;
				case "ScriptChildPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildPageLoadComplete";
					result = ScriptChildPageLoadComplete.Execute(context, ScriptChildPageLoadCompleteExecute);
					break;
				case "EventSubProcessChildInitStartMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChildInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitStartMessage";
					result = ChildInitStartMessage.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "InitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool ScriptEndEditCheckExecute(ProcessExecutingContext context) {
			if (Page.EndEdit.Checked) {
				Page.SuccessfulEdit.Enabled = true;
			}
			else {
				Page.SuccessfulEdit.Value = false;
				Page.SuccessfulEdit.Enabled = false;
			}
			return true;
		}

		public virtual bool ScriptChildPageLoadCompleteExecute(ProcessExecutingContext context) {
			// Set checkboxes visibility
			if (Page.DataSource.Rows.Count > 0) {
				var stage = Page.DataSource.Rows[0] as Terrasoft.Configuration.OpportunityStage;
				Page.SuccessfulEdit.Enabled = stage.End;
				if (!stage.End && stage.Successful) {
					stage.Successful = false;
				}
			}
			
			// Specify max and min value for NumberEdit control
			Page.NumberEdit.MaxValue = Int32.MaxValue;
			Page.NumberEdit.MinValue = 0;
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			Page.DataSource.EnableServerActiveRow = true;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EndEditCheck":
							if (ActivatedEventElements.Contains("StartMessageEndEditCheck")) {
							context.QueueTasks.Enqueue("StartMessageEndEditCheck");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessageChildPageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessageChildPageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("ChildInitStartMessage")) {
							context.QueueTasks.Enqueue("ChildInitStartMessage");
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

	#region Class: OpportunityStageEditPageEventsProcess

	/// <exclude/>
	public class OpportunityStageEditPageEventsProcess : OpportunityStageEditPageEventsProcess<Terrasoft.WebApp.OpportunityStageEditPageSchemaUserControl>
	{

		public OpportunityStageEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityStageEditPageSchemaUserControl

	/// <exclude/>
	public partial class OpportunityStageEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.IntegerEdit NumberEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("NumberEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit MaxProbabilityEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("MaxProbabilityEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit NextStepTermEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("NextStepTermEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox EndEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("EndEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox SuccessfulEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("SuccessfulEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox CheckBox1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("CheckBox1", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EndEdit.AjaxEvents.Check.Event += EndEditCheck;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EndEdit.AjaxEvents.Check.Event -= EndEditCheck;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (OpportunityStageEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new OpportunityStageEditPageEventsProcess(UserConnection);
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

		public virtual void EndEditCheck(object sender, EventArgs e) {
			object result = ThrowEvent("EndEditCheck");
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
			SchemaName = "OpportunityStageEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStageEditPageEventsProcessSchema

	/// <exclude/>
	public class OpportunityStageEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public OpportunityStageEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public OpportunityStageEditPageEventsProcessSchema(OpportunityStageEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityStageEditPageEventsProcess";
			UId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1057 = CreateLaneSet1057LaneSet();
			LaneSets.Add(schemaLaneSet1057);
			ProcessSchemaLane schemaLane3660 = CreateLane3660Lane();
			schemaLaneSet1057.Lanes.Add(schemaLane3660);
			ProcessSchemaLane schemaLane3661 = CreateLane3661Lane();
			schemaLaneSet1057.Lanes.Add(schemaLane3661);
			ProcessSchemaEventSubProcess subprocessendeditcheck = CreateSubProcessEndEditCheckEventSubProcess();
			FlowElements.Add(subprocessendeditcheck);
			ProcessSchemaEventSubProcess subprocesschildpageloadcomplete = CreateSubProcessChildPageLoadCompleteEventSubProcess();
			FlowElements.Add(subprocesschildpageloadcomplete);
			ProcessSchemaEventSubProcess eventsubprocesschildinitstartmessage = CreateEventSubProcessChildInitStartMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschildinitstartmessage);
			ProcessSchemaStartMessageEvent startmessageendeditcheck = CreateStartMessageEndEditCheckStartMessageEvent();
			subprocessendeditcheck.FlowElements.Add(startmessageendeditcheck);
			ProcessSchemaScriptTask scriptendeditcheck = CreateScriptEndEditCheckScriptTask();
			subprocessendeditcheck.FlowElements.Add(scriptendeditcheck);
			ProcessSchemaStartMessageEvent startmessagechildpageloadcomplete = CreateStartMessageChildPageLoadCompleteStartMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(startmessagechildpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasepageloadcomplete1 = CreateIntermediateThrowBasePageLoadComplete1IntermediateThrowMessageEvent();
			subprocesschildpageloadcomplete.FlowElements.Add(intermediatethrowbasepageloadcomplete1);
			ProcessSchemaScriptTask scriptchildpageloadcomplete = CreateScriptChildPageLoadCompleteScriptTask();
			subprocesschildpageloadcomplete.FlowElements.Add(scriptchildpageloadcomplete);
			ProcessSchemaStartMessageEvent childinitstartmessage = CreateChildInitStartMessageStartMessageEvent();
			eventsubprocesschildinitstartmessage.FlowElements.Add(childinitstartmessage);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocesschildinitstartmessage.FlowElements.Add(initscripttask);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocesschildinitstartmessage.FlowElements.Add(initintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow20747SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20748SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20749SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20750SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20751SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20747SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20747",
				UId = new Guid("d9d0d989-3b8c-4cac-adf3-2927cd2d9bc8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("23eb8799-e8ac-40b4-a7c5-d22094986e34"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("662bb5d9-f9e2-4965-a2bd-30f128d9ea07"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20748SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20748",
				UId = new Guid("902cf18e-9631-4763-9bcd-0efb1bf70cb4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				CurveCenterPosition = new Point(172, 237),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("19593108-8559-4873-8d1f-49c41845175d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4af5e7d5-5108-4c8e-94f8-72334689fce7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20749SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20749",
				UId = new Guid("d3f98450-127e-41f5-b0f1-ede4747f1ba6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				CurveCenterPosition = new Point(326, 240),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6e0c2007-86ab-4123-8ac2-a420f8064cc1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("19593108-8559-4873-8d1f-49c41845175d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20750SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20750",
				UId = new Guid("9f8d69a5-adb5-4eee-a5ae-665c29209e18"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				CurveCenterPosition = new Point(198, 238),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("777a3066-4d7b-4984-8258-77276da6c737"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b34d6d5-beb5-4e74-89fc-7885dfc90f0c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20751SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20751",
				UId = new Guid("0dd9691c-5cbd-466e-b783-8f21f728416a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				CurveCenterPosition = new Point(198, 238),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("165751c4-d506-4c48-996d-828ae2d23028"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("777a3066-4d7b-4984-8258-77276da6c737"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1057LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1057 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("21d63b1d-af51-47f4-9d45-6e006d68fbb8"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"LaneSet1057",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(787, 491),
				UseBackgroundMode = false
			};
			return schemaLaneSet1057;
		}

		protected virtual ProcessSchemaLane CreateLane3660Lane() {
			ProcessSchemaLane schemaLane3660 = new ProcessSchemaLane(this) {
				UId = new Guid("47bab1d2-8523-4a46-921f-a9d27cf17c00"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("21d63b1d-af51-47f4-9d45-6e006d68fbb8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"Lane3660",
				Position = new Point(29, 0),
				Size = new Size(758, 145),
				UseBackgroundMode = false
			};
			return schemaLane3660;
		}

		protected virtual ProcessSchemaLane CreateLane3661Lane() {
			ProcessSchemaLane schemaLane3661 = new ProcessSchemaLane(this) {
				UId = new Guid("573f0186-00df-45c6-86c5-a557937d7443"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("21d63b1d-af51-47f4-9d45-6e006d68fbb8"),
				CreatedInOwnerSchemaUId = new Guid("4ca08a6b-e289-4d45-ab02-577d5ce15c83"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"Lane3661",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 150),
				Size = new Size(758, 341),
				UseBackgroundMode = false
			};
			return schemaLane3661;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessEndEditCheckEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessEndEditCheck = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("789e9c7a-ba20-4f70-99f8-a0878beb13a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("47bab1d2-8523-4a46-921f-a9d27cf17c00"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"SubProcessEndEditCheck",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(177, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessEndEditCheck;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageEndEditCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("23eb8799-e8ac-40b4-a7c5-d22094986e34"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("789e9c7a-ba20-4f70-99f8-a0878beb13a3"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EndEditCheck",
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"StartMessageEndEditCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptEndEditCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("662bb5d9-f9e2-4965-a2bd-30f128d9ea07"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("789e9c7a-ba20-4f70-99f8-a0878beb13a3"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"ScriptEndEditCheck",
				Position = new Point(77, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,72,76,79,213,115,205,75,113,77,201,44,209,115,206,72,77,206,78,77,209,84,168,230,226,4,75,4,151,38,39,167,22,23,167,149,230,128,229,93,243,18,147,114,82,83,20,108,21,74,138,74,83,173,185,106,185,82,115,138,83,113,169,14,75,204,41,77,5,170,77,75,4,42,178,38,100,34,84,85,45,87,81,106,73,105,81,30,196,6,0,174,113,205,115,162,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChildPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChildPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a0efca5c-2212-4198-8cac-fea672ce5809"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("573f0186-00df-45c6-86c5-a557937d7443"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"SubProcessChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 174),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(339, 153),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChildPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildPageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6e0c2007-86ab-4123-8ac2-a420f8064cc1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0efca5c-2212-4198-8cac-fea672ce5809"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"StartMessageChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBasePageLoadComplete1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("19593108-8559-4873-8d1f-49c41845175d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0efca5c-2212-4198-8cac-fea672ce5809"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"IntermediateThrowBasePageLoadComplete1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4af5e7d5-5108-4c8e-94f8-72334689fce7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0efca5c-2212-4198-8cac-fea672ce5809"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"ScriptChildPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(203, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,189,78,196,48,16,132,235,248,41,150,230,4,141,19,65,25,29,13,92,65,193,143,8,162,65,20,27,199,62,44,28,59,90,175,67,78,232,222,29,39,130,59,9,40,119,246,219,153,209,150,37,52,154,65,189,105,245,222,134,73,71,24,109,180,173,117,150,119,194,26,56,125,192,173,150,215,200,216,132,68,74,203,199,240,17,229,85,72,158,225,18,170,51,248,20,197,136,4,145,51,7,107,248,15,127,169,94,1,35,60,105,34,140,193,112,62,247,198,110,19,33,219,224,229,253,48,4,226,228,115,98,51,187,212,162,88,92,154,164,148,142,209,36,183,233,44,203,141,199,214,233,46,103,44,89,121,238,50,57,87,60,57,8,176,90,125,111,143,199,75,197,226,183,154,109,12,186,56,135,237,197,94,136,50,255,97,208,202,154,29,244,56,1,102,175,222,122,24,209,37,13,38,16,220,165,190,213,52,55,1,21,60,83,112,98,105,121,212,229,45,78,207,11,191,134,27,207,23,231,7,161,254,139,90,255,131,86,181,32,205,137,60,48,101,244,11,50,129,84,101,145,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildInitStartMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildInitStartMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("51fe9e06-8852-4bd6-b4e3-4012ac0b61dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("573f0186-00df-45c6-86c5-a557937d7443"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"EventSubProcessChildInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(336, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildInitStartMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("165751c4-d506-4c48-996d-828ae2d23028"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("51fe9e06-8852-4bd6-b4e3-4012ac0b61dd"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"ChildInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3b34d6d5-beb5-4e74-89fc-7885dfc90f0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("51fe9e06-8852-4bd6-b4e3-4012ac0b61dd"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,205,75,76,202,73,13,78,45,42,75,45,114,76,46,201,44,75,13,202,47,87,176,85,40,41,42,77,181,230,42,74,45,41,45,202,131,112,0,128,241,7,3,58,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("777a3066-4d7b-4984-8258-77276da6c737"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("51fe9e06-8852-4bd6-b4e3-4012ac0b61dd"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				CreatedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 62),
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
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityStageEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0fb80cfc-89e7-4204-af0e-1f8abc6f49db"));
		}

		#endregion

	}

	#endregion

}

