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

	#region Class: LookupColumnEditPageSchema

	/// <exclude/>
	public class LookupColumnEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _metaPathEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit MetaPathEdit {
			get {
				return _metaPathEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _widthEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit WidthEdit {
			get {
				return _widthEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _orderComboBoxEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit OrderComboBoxEdit {
			get {
				return _orderComboBoxEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public LookupColumnEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LookupColumnEditPageSchema(LookupColumnEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			RealUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			Name = "LookupColumnEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 250;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLookupColumnEditPageEventsProcessSchema();
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
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateMetaPathEdit());
			MainControlLayout.InsertItem(1, CreateCaptionEdit());
			MainControlLayout.InsertItem(2, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateWidthEdit());
			ControlLayout1.InsertItem(1, CreateSpacer1());
			ControlLayout1.InsertItem(2, CreateOrderComboBoxEdit());
			MainControlLayout.MoveItem(3, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateLookupColumnEditPageEventsProcessSchema() {
			var schema = new LookupColumnEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateMetaPathEdit() {
			_metaPathEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_metaPathEdit.UId = new Guid("a52e6c1a-31eb-4a5f-ba96-cbb50d7c1bdf");
			_metaPathEdit.Name = "MetaPathEdit";
			_metaPathEdit.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_metaPathEdit.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_metaPathEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_metaPathEdit.Tag = "";
			_metaPathEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_metaPathEdit.Image = new ControlImage {};
			_metaPathEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_metaPathEdit.DataSource = "DataSource";
			_metaPathEdit.ColumnUId = new Guid("a72e0b0f-347a-465f-824d-ecbd08da2480");
			_metaPathEdit.Enabled = false;
			return _metaPathEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_captionEdit.UId = new Guid("166ad8fc-46ec-4e12-944a-d559b8b11a4f");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_captionEdit.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_captionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionEdit.DataSource = "DataSource";
			_captionEdit.ColumnUId = new Guid("70b7b607-d539-4555-aadf-7786231dc549");
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateWidthEdit() {
			_widthEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_widthEdit.UId = new Guid("cff8bf2d-1e9d-42c5-91b9-53b329911537");
			_widthEdit.Name = "WidthEdit";
			_widthEdit.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_widthEdit.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_widthEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_widthEdit.Tag = "";
			_widthEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_widthEdit.Image = new ControlImage {};
			_widthEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_widthEdit.DataSource = "DataSource";
			_widthEdit.ColumnUId = new Guid("f0842f8b-96f0-47c0-a226-cbc26c292781");
			return _widthEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("602fa2c8-8490-46e0-b08d-d3f6cc8bc88f");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_spacer1.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Pixel(30);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateOrderComboBoxEdit() {
			_orderComboBoxEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_orderComboBoxEdit.UId = new Guid("860ce444-4b1a-4acc-86e4-76bdeda52e59");
			_orderComboBoxEdit.Name = "OrderComboBoxEdit";
			_orderComboBoxEdit.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_orderComboBoxEdit.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_orderComboBoxEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_orderComboBoxEdit.Tag = "";
			_orderComboBoxEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_orderComboBoxEdit.Image = new ControlImage {};
			_orderComboBoxEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_orderComboBoxEdit.DataSource = "DataSource";
			_orderComboBoxEdit.ColumnUId = new Guid("5fd1bed6-960b-42e3-8dc5-a7694fa8ac96");
			return _orderComboBoxEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("376c263d-23bf-4adf-aacb-b1a724e39f2f");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_controlLayout1.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(30);
			_controlLayout1.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("6c654cdc-23c2-49ea-b957-8b5252bea05e");
			DataSource.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("d07e3747-bd35-445f-bcf1-3c3bb63a0e1d");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("9d125a92-5510-4a2c-bfb3-0055d045991d");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("e4011e46-db84-43e7-a078-a0a130c8a566");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("52c00c31-2046-4032-985d-3ad554ac13d6");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("f512367b-ce5e-45aa-b3c4-0fb54d06e85f");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c8c10f8f-cfb2-454d-89f6-1fa2b845c0ea");
			if (column != null) {
				column.UId = new Guid("4e2ef947-ad27-4e32-aeb8-76c7207ef576");
				column.Name = @"SysLookup";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("219ff834-643d-4ad3-b154-48f81c3a9c07");
			if (column != null) {
				column.UId = new Guid("d8c3c57c-14b8-4a83-99f9-86b3938cfe9b");
				column.Name = @"MetaPath";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d4305e9c-d71c-4b59-8e1c-8309d2970c2f");
			if (column != null) {
				column.UId = new Guid("151e459a-da6f-460c-ba52-7af06c4e9e27");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("dbae20af-93a5-4df8-a239-7cc89873a61e");
			if (column != null) {
				column.UId = new Guid("70b7b607-d539-4555-aadf-7786231dc549");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("be9f648c-cc8e-4e88-8adb-e9b852486155");
			if (column != null) {
				column.UId = new Guid("f0842f8b-96f0-47c0-a226-cbc26c292781");
				column.Name = @"Width";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e6806a6c-6698-4696-8e66-df3cfd9eb580");
			if (column != null) {
				column.UId = new Guid("5fd1bed6-960b-42e3-8dc5-a7694fa8ac96");
				column.Name = @"SysOrderDirection";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b72ca89d-b132-4b40-a26e-9d6d34d0ddaf");
			if (column != null) {
				column.UId = new Guid("a72e0b0f-347a-465f-824d-ecbd08da2480");
				column.Name = @"MetaCaption";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("8fc41a00-890d-405a-ab67-05f486e17856");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("2e702a8a-f5f7-41a3-9026-f1b7ffe973b2");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("6d14728e-a152-4aab-82d6-d14585ccd4d3");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("435356b5-e4ab-4cc2-aa08-cc41dce8f95e");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("a9491b42-b2ec-419c-b1b3-b5b6a2e00046");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("4ace3eb5-c70a-4d38-8c4e-0123b930dec5");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("c8c10f8f-cfb2-454d-89f6-1fa2b845c0ea");
			if (column != null) {
				column.UId = new Guid("3d1ed567-5b75-4d98-a4c6-09611878d716");
				column.Name = @"SysLookup";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("219ff834-643d-4ad3-b154-48f81c3a9c07");
			if (column != null) {
				column.UId = new Guid("c653e7fb-a3fe-40a7-8c5b-761f950cb3bb");
				column.Name = @"MetaPath";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("d4305e9c-d71c-4b59-8e1c-8309d2970c2f");
			if (column != null) {
				column.UId = new Guid("01227ff4-1c18-428d-b295-d36d6ca1070b");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("dbae20af-93a5-4df8-a239-7cc89873a61e");
			if (column != null) {
				column.UId = new Guid("da0b3e1d-0327-4321-952a-bc0f3257e890");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("be9f648c-cc8e-4e88-8adb-e9b852486155");
			if (column != null) {
				column.UId = new Guid("552f8fd8-1a52-473b-8838-9c3f4ece06d0");
				column.Name = @"Width";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("e6806a6c-6698-4696-8e66-df3cfd9eb580");
			if (column != null) {
				column.UId = new Guid("fada1b08-790e-4b58-8708-eafeee98b85c");
				column.Name = @"SysOrderDirection";
				column.CreatedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
				column.ModifiedInSchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
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
			return new LookupColumnEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new LookupColumnEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("24c196f5-af4f-4619-8116-57efab1d6b99"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LookupColumnEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LookupColumnEditPageEventsProcess

	/// <exclude/>
	public class LookupColumnEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LookupColumnEditPageSchemaUserControl
	{

		public LookupColumnEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LookupColumnEditPageEventsProcess";
			SchemaUId = new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("24c196f5-af4f-4619-8116-57efab1d6b99");
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

	#region Class: LookupColumnEditPageEventsProcess

	/// <exclude/>
	public class LookupColumnEditPageEventsProcess : LookupColumnEditPageEventsProcess<Terrasoft.WebApp.LookupColumnEditPageSchemaUserControl>
	{

		public LookupColumnEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LookupColumnEditPageSchemaUserControl

	/// <exclude/>
	public partial class LookupColumnEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit MetaPathEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("MetaPathEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit WidthEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("WidthEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit OrderComboBoxEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("OrderComboBoxEdit", true);
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
			var process = (LookupColumnEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LookupColumnEditPageEventsProcess(UserConnection);
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
			SchemaName = "LookupColumnEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: LookupColumnEditPageEventsProcessSchema

	/// <exclude/>
	public class LookupColumnEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public LookupColumnEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LookupColumnEditPageEventsProcessSchema(LookupColumnEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LookupColumnEditPageEventsProcess";
			UId = new Guid("d2edb8f6-ce87-4e2f-8335-2db895e8cb88");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
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
			return new LookupColumnEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d2edb8f6-ce87-4e2f-8335-2db895e8cb88"));
		}

		#endregion

	}

	#endregion

}

