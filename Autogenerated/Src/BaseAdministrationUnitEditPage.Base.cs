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
	using System.Linq;
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

	#region Class: BaseAdministrationUnitEditPageSchema

	/// <exclude/>
	public class BaseAdministrationUnitEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _lDAPControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout LDAPControlLayout {
			get {
				return _lDAPControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _synchronizeWithLDAPCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox SynchronizeWithLDAPCheckBox {
			get {
				return _synchronizeWithLDAPCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _lDAPEntryEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit LDAPEntryEdit {
			get {
				return _lDAPEntryEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _lDAPEntryButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton LDAPEntryButton {
			get {
				return _lDAPEntryButton;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseAdministrationUnitEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseAdministrationUnitEditPageSchema(BaseAdministrationUnitEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			RealUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			Name = "BaseAdministrationUnitEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 400;
			Height = 230;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseAdministrationUnitEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateNameEdit());
			MainControlLayout.InsertItem(1, CreateLDAPControlLayout());
			LDAPControlLayout.InsertItem(0, CreateSynchronizeWithLDAPCheckBox());
			LDAPControlLayout.InsertItem(1, CreateLDAPEntryEdit());
			LDAPEntryEdit.InsertItem(0, CreateLDAPEntryButton());
			MainControlLayout.MoveItem(2, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateBaseAdministrationUnitEditPageEventsProcessSchema() {
			var schema = new BaseAdministrationUnitEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("e1bdc9ee-5d78-4995-855b-528282c67c2c");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_nameEdit.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("a68a8dc1-03c4-437c-8fe7-acf23eee520d");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateSynchronizeWithLDAPCheckBox() {
			_synchronizeWithLDAPCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_synchronizeWithLDAPCheckBox.UId = new Guid("dd47fdff-f2fe-4dcf-8389-91f51ebf0286");
			_synchronizeWithLDAPCheckBox.Name = "SynchronizeWithLDAPCheckBox";
			_synchronizeWithLDAPCheckBox.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_synchronizeWithLDAPCheckBox.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_synchronizeWithLDAPCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_synchronizeWithLDAPCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_synchronizeWithLDAPCheckBox.Tag = "";
			_synchronizeWithLDAPCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_synchronizeWithLDAPCheckBox.Width = System.Web.UI.WebControls.Unit.Pixel(15);
			_synchronizeWithLDAPCheckBox.AlignedByCaption = false;
			_synchronizeWithLDAPCheckBox.DataSource = "DataSource";
			_synchronizeWithLDAPCheckBox.ColumnUId = new Guid("fabe012a-0304-431c-8096-ea9cf074ced5");
			return _synchronizeWithLDAPCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateLDAPEntryButton() {
			_lDAPEntryButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_lDAPEntryButton.UId = new Guid("3d9fc12b-9f53-48a3-8efb-1b709545e396");
			_lDAPEntryButton.Name = "LDAPEntryButton";
			_lDAPEntryButton.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_lDAPEntryButton.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_lDAPEntryButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lDAPEntryButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_lDAPEntryButton.Tag = "";
			_lDAPEntryButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2"),
				ItemUId = new Guid("ceeaa064-ff61-470b-8fac-088d723602d5"),
				ImageHash = @"54ac1a2d1db28aa44e6b7837c54cc5e6"
			};
			_lDAPEntryButton.Enabled = false;
			return _lDAPEntryButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateLDAPEntryEdit() {
			_lDAPEntryEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_lDAPEntryEdit.UId = new Guid("1e9beac9-1dac-4366-98f2-b78981a1a2ae");
			_lDAPEntryEdit.Name = "LDAPEntryEdit";
			_lDAPEntryEdit.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_lDAPEntryEdit.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_lDAPEntryEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lDAPEntryEdit.Tag = "";
			_lDAPEntryEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lDAPEntryEdit.Image = new ControlImage {};
			_lDAPEntryEdit.Width = System.Web.UI.WebControls.Unit.Percentage(60);
			_lDAPEntryEdit.DataSource = "DataSource";
			_lDAPEntryEdit.ColumnUId = new Guid("fbd519a7-9eef-4321-bea6-231e64c058ec");
			_lDAPEntryEdit.Enabled = false;
			return _lDAPEntryEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateLDAPControlLayout() {
			_lDAPControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_lDAPControlLayout.UId = new Guid("851cfbee-e069-4b1b-9603-900c9301a399");
			_lDAPControlLayout.Name = "LDAPControlLayout";
			_lDAPControlLayout.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_lDAPControlLayout.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			_lDAPControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lDAPControlLayout.Tag = "";
			_lDAPControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_lDAPControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_lDAPControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_lDAPControlLayout.FitHeightByContent = true;
			_lDAPControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_lDAPControlLayout.StartNewAlignGroup = true;
			_lDAPControlLayout.Image = new ControlImage {};
			_lDAPControlLayout.Edges = "";
			return _lDAPControlLayout;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			DataSource.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("662299e2-6051-440d-9c5b-eb8227f600da");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("b0fee6e9-801e-447c-8b1d-baf069962ace");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("91ae8612-7e2e-4b96-af3c-5bf47dade1b6");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("74c0a0e0-c126-4991-97ee-eca934d4bfbd");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("2f461510-b51a-4209-9aa4-c65f6d0556ed");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("a68a8dc1-03c4-437c-8fe7-acf23eee520d");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("d56d9212-e94b-4be0-b39b-292b1e8ecde4");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3b1b6e4c-aa09-413c-9ded-a6ad81bb93c1");
			if (column != null) {
				column.UId = new Guid("8e3d244d-0c8f-4853-96a7-11baecba0329");
				column.Name = @"SysAdminUnitType";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3678b2d1-343e-4e0c-8a93-f082143be510");
			if (column != null) {
				column.UId = new Guid("9f63ca6e-7b1c-4ccc-8922-5751cb407216");
				column.Name = @"ParentRole";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("45d5d808-1ad8-42bf-aaf2-177dcd2079c7");
			if (column != null) {
				column.UId = new Guid("7f38ec11-62de-44cc-9fcc-2aa35eecb246");
				column.Name = @"Account";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("72a7351e-36cf-40f9-b334-0a7563bd60fb");
			if (column != null) {
				column.UId = new Guid("7869616d-2744-45c5-be9a-944e03b10397");
				column.Name = @"IsDirectoryEntry";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8280981b-5189-40a1-b700-6a35c572dba2");
			if (column != null) {
				column.UId = new Guid("d21321af-8872-4946-8371-b1b40a7d2374");
				column.Name = @"TimeZone";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a07a30ff-b3df-45db-a83c-bf89027250d8");
			if (column != null) {
				column.UId = new Guid("abc89b9b-964e-4334-9fa5-3f18443884b7");
				column.Name = @"UserPassword";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a986b074-459c-40b1-b4b6-0e286b3ef123");
			if (column != null) {
				column.UId = new Guid("e9534dad-5d67-4e80-9898-eebe457dc376");
				column.Name = @"Active";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2e25fe29-ea38-4db2-84d5-03a8db9b2491");
			if (column != null) {
				column.UId = new Guid("fbd519a7-9eef-4321-bea6-231e64c058ec");
				column.Name = @"LDAPEntry";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("184336ef-e07a-4f5a-9850-8d4ccaff520f");
			if (column != null) {
				column.UId = new Guid("fabe012a-0304-431c-8096-ea9cf074ced5");
				column.Name = @"SynchronizeWithLDAP";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c2748d54-0f48-4251-bfc0-ff6e2478348d");
			if (column != null) {
				column.UId = new Guid("844bd4c6-6443-4697-959a-ff3f4ded8459");
				column.Name = @"LDAPEntryId";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e161e2fc-4fac-4ae0-ba3c-e9f70d52ecb4");
			if (column != null) {
				column.UId = new Guid("15014db6-d076-4339-8294-5b0895c848cc");
				column.Name = @"LDAPEntryDN";
				column.CreatedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
				column.ModifiedInSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
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
			return new BaseAdministrationUnitEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseAdministrationUnitEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseAdministrationUnitEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseAdministrationUnitEditPageEventsProcess

	/// <exclude/>
	public class BaseAdministrationUnitEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseAdministrationUnitEditPageSchemaUserControl
	{

		#region Class: LDAPEntryButtonClickUserTaskFlowElement

		/// <exclude/>
		public class LDAPEntryButtonClickUserTaskFlowElement : OpenPageUserTask
		{

			public LDAPEntryButtonClickUserTaskFlowElement(UserConnection userConnection, BaseAdministrationUnitEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LDAPEntryButtonClickUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskLoadRowsAdditionalTreeGridFlowElement

		/// <exclude/>
		public class UserTaskLoadRowsAdditionalTreeGridFlowElement : TreeGridLoadRowUserTask
		{

			public UserTaskLoadRowsAdditionalTreeGridFlowElement(UserConnection userConnection, BaseAdministrationUnitEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskLoadRowsAdditionalTreeGrid";
				IsLogging = false;
				SchemaElementUId = new Guid("1a77b270-d913-49b8-8c73-e9c07363488b");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public BaseAdministrationUnitEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseAdministrationUnitEditPageEventsProcess";
			SchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2");
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

		public virtual string AdditionalTreeGridClientID {
			get;
			set;
		}

		public virtual bool areConditionsCorrect {
			get;
			set;
		}

		public virtual bool IsLdapEntryChanged {
			get;
			set;
		}

		private ProcessFlowElement _lDAPEntryButtonClickEventSubProcess4;
		public ProcessFlowElement LDAPEntryButtonClickEventSubProcess4 {
			get {
				return _lDAPEntryButtonClickEventSubProcess4 ?? (_lDAPEntryButtonClickEventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "LDAPEntryButtonClickEventSubProcess4",
					SchemaElementUId = new Guid("9b435c20-0406-415a-8f01-3093679fc025"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _lDAPEntryButtonClick;
		public ProcessFlowElement LDAPEntryButtonClick {
			get {
				return _lDAPEntryButtonClick ?? (_lDAPEntryButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LDAPEntryButtonClick",
					SchemaElementUId = new Guid("273a646d-8aba-4b32-bb24-69f72dd82e2b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLDAPEntryButtonClick;
		public ProcessScriptTask ScriptLDAPEntryButtonClick {
			get {
				return _scriptLDAPEntryButtonClick ?? (_scriptLDAPEntryButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLDAPEntryButtonClick",
					SchemaElementUId = new Guid("4fb19a03-39c2-4934-b0ed-13559a4fb4ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLDAPEntryButtonClickExecute,
				});
			}
		}

		private LDAPEntryButtonClickUserTaskFlowElement _lDAPEntryButtonClickUserTask;
		public LDAPEntryButtonClickUserTaskFlowElement LDAPEntryButtonClickUserTask {
			get {
				return _lDAPEntryButtonClickUserTask ?? (_lDAPEntryButtonClickUserTask = new LDAPEntryButtonClickUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _lDAPUsersGridPageCloseEventSubProcess;
		public ProcessFlowElement LDAPUsersGridPageCloseEventSubProcess {
			get {
				return _lDAPUsersGridPageCloseEventSubProcess ?? (_lDAPUsersGridPageCloseEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "LDAPUsersGridPageCloseEventSubProcess",
					SchemaElementUId = new Guid("20ca54d6-fc69-420c-bc8b-a511dc8f37d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _lDAPUsersGridPageClose;
		public ProcessFlowElement LDAPUsersGridPageClose {
			get {
				return _lDAPUsersGridPageClose ?? (_lDAPUsersGridPageClose = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LDAPUsersGridPageClose",
					SchemaElementUId = new Guid("4be4047f-8d77-4b78-9df8-02c0553e3ccc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLDAPUsersGridPageClose;
		public ProcessScriptTask ScriptLDAPUsersGridPageClose {
			get {
				return _scriptLDAPUsersGridPageClose ?? (_scriptLDAPUsersGridPageClose = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLDAPUsersGridPageClose",
					SchemaElementUId = new Guid("2432e106-0506-4ae2-b44f-74de5a75b32e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLDAPUsersGridPageCloseExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck;
		public ProcessFlowElement EventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck {
			get {
				return _eventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck ?? (_eventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck",
					SchemaElementUId = new Guid("4d8e7742-0a8c-41ca-8586-a84b76c0885a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _synchronizeWithLDAPCheckBoxCheck;
		public ProcessFlowElement SynchronizeWithLDAPCheckBoxCheck {
			get {
				return _synchronizeWithLDAPCheckBoxCheck ?? (_synchronizeWithLDAPCheckBoxCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SynchronizeWithLDAPCheckBoxCheck",
					SchemaElementUId = new Guid("6971cc4d-5874-4835-bc6c-ece798be2d30"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSynchronizeWithLDAPCheckBoxCheck;
		public ProcessScriptTask ScriptSynchronizeWithLDAPCheckBoxCheck {
			get {
				return _scriptSynchronizeWithLDAPCheckBoxCheck ?? (_scriptSynchronizeWithLDAPCheckBoxCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSynchronizeWithLDAPCheckBoxCheck",
					SchemaElementUId = new Guid("46858c16-3b75-44a7-adf8-12676c789f45"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSynchronizeWithLDAPCheckBoxCheckExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessPageLoadComplete;
		public ProcessFlowElement EventSubProcessPageLoadComplete {
			get {
				return _eventSubProcessPageLoadComplete ?? (_eventSubProcessPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessPageLoadComplete",
					SchemaElementUId = new Guid("be58466d-5696-4b23-83f8-97b0d07f728e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteChild;
		public ProcessFlowElement PageLoadCompleteChild {
			get {
				return _pageLoadCompleteChild ?? (_pageLoadCompleteChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteChild",
					SchemaElementUId = new Guid("18378d4b-5388-4120-8748-0faa72c54fe5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteParent;
		public ProcessThrowMessageEvent PageLoadCompleteParent {
			get {
				return _pageLoadCompleteParent ?? (_pageLoadCompleteParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteParent",
					SchemaElementUId = new Guid("160189d5-08ec-43ed-9acc-ca75198ebe2e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadCompleteChild;
		public ProcessScriptTask ScriptPageLoadCompleteChild {
			get {
				return _scriptPageLoadCompleteChild ?? (_scriptPageLoadCompleteChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadCompleteChild",
					SchemaElementUId = new Guid("7032531e-3e3c-4d91-ab9c-99f13a837506"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessBaseAdministrationUnitEditPageOkBuutonClick;
		public ProcessFlowElement SubProcessBaseAdministrationUnitEditPageOkBuutonClick {
			get {
				return _subProcessBaseAdministrationUnitEditPageOkBuutonClick ?? (_subProcessBaseAdministrationUnitEditPageOkBuutonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessBaseAdministrationUnitEditPageOkBuutonClick",
					SchemaElementUId = new Guid("b9021768-6ccf-48c3-9cf9-a28860c89d6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startBaseAdministrationUnitEditPageOkButtonClick;
		public ProcessFlowElement StartBaseAdministrationUnitEditPageOkButtonClick {
			get {
				return _startBaseAdministrationUnitEditPageOkButtonClick ?? (_startBaseAdministrationUnitEditPageOkButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartBaseAdministrationUnitEditPageOkButtonClick",
					SchemaElementUId = new Guid("5da1e769-b2a8-4260-9c06-6c0dc7e8c687"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptBaseAdministrationUnitEditPageOkButtonClick;
		public ProcessScriptTask ScriptBaseAdministrationUnitEditPageOkButtonClick {
			get {
				return _scriptBaseAdministrationUnitEditPageOkButtonClick ?? (_scriptBaseAdministrationUnitEditPageOkButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptBaseAdministrationUnitEditPageOkButtonClick",
					SchemaElementUId = new Guid("079a5788-d305-4e1f-be2b-c4faa416a03d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptBaseAdministrationUnitEditPageOkButtonClickExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBaseOkButtonClick;
		public ProcessThrowMessageEvent IntermediateThrowBaseOkButtonClick {
			get {
				return _intermediateThrowBaseOkButtonClick ?? (_intermediateThrowBaseOkButtonClick = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBaseOkButtonClick",
					SchemaElementUId = new Guid("b9f4f540-c6b8-4140-b8ab-678f52227f94"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private UserTaskLoadRowsAdditionalTreeGridFlowElement _userTaskLoadRowsAdditionalTreeGrid;
		public UserTaskLoadRowsAdditionalTreeGridFlowElement UserTaskLoadRowsAdditionalTreeGrid {
			get {
				return _userTaskLoadRowsAdditionalTreeGrid ?? (_userTaskLoadRowsAdditionalTreeGrid = new UserTaskLoadRowsAdditionalTreeGridFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("d6438337-7ee6-4440-810d-da82bd161ecd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow4261;
		public ProcessConditionalFlow SequenceFlow4261 {
			get {
				return _sequenceFlow4261 ?? (_sequenceFlow4261 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow4261",
					SchemaElementUId = new Guid("65ff380d-05c8-43f6-b0fc-8988a3df6399"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _nameNotUniqueMessage;
		public LocalizableString NameNotUniqueMessage {
			get {
				return _nameNotUniqueMessage ?? (_nameNotUniqueMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NameNotUniqueMessage.Value"));
			}
		}

		private LocalizableString _attentionCaption;
		public LocalizableString AttentionCaption {
			get {
				return _attentionCaption ?? (_attentionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AttentionCaption.Value"));
			}
		}

		private LocalizableString _elementCaption;
		public LocalizableString ElementCaption {
			get {
				return _elementCaption ?? (_elementCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ElementCaption.Value"));
			}
		}

		private LocalizableString _departmentCaption;
		public LocalizableString DepartmentCaption {
			get {
				return _departmentCaption ?? (_departmentCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DepartmentCaption.Value"));
			}
		}

		private LocalizableString _teamCaption;
		public LocalizableString TeamCaption {
			get {
				return _teamCaption ?? (_teamCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TeamCaption.Value"));
			}
		}

		private LocalizableString _chiefCaption;
		public LocalizableString ChiefCaption {
			get {
				return _chiefCaption ?? (_chiefCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChiefCaption.Value"));
			}
		}

		private LocalizableString _organizationCaption;
		public LocalizableString OrganizationCaption {
			get {
				return _organizationCaption ?? (_organizationCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OrganizationCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[LDAPEntryButtonClickEventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPEntryButtonClickEventSubProcess4 };
			FlowElements[LDAPEntryButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPEntryButtonClick };
			FlowElements[ScriptLDAPEntryButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLDAPEntryButtonClick };
			FlowElements[LDAPEntryButtonClickUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPEntryButtonClickUserTask };
			FlowElements[LDAPUsersGridPageCloseEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPUsersGridPageCloseEventSubProcess };
			FlowElements[LDAPUsersGridPageClose.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPUsersGridPageClose };
			FlowElements[ScriptLDAPUsersGridPageClose.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLDAPUsersGridPageClose };
			FlowElements[EventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck };
			FlowElements[SynchronizeWithLDAPCheckBoxCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeWithLDAPCheckBoxCheck };
			FlowElements[ScriptSynchronizeWithLDAPCheckBoxCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSynchronizeWithLDAPCheckBoxCheck };
			FlowElements[EventSubProcessPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPageLoadComplete };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[PageLoadCompleteParent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteParent };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[SubProcessBaseAdministrationUnitEditPageOkBuutonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessBaseAdministrationUnitEditPageOkBuutonClick };
			FlowElements[StartBaseAdministrationUnitEditPageOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartBaseAdministrationUnitEditPageOkButtonClick };
			FlowElements[ScriptBaseAdministrationUnitEditPageOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptBaseAdministrationUnitEditPageOkButtonClick };
			FlowElements[IntermediateThrowBaseOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBaseOkButtonClick };
			FlowElements[UserTaskLoadRowsAdditionalTreeGrid.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskLoadRowsAdditionalTreeGrid };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "LDAPEntryButtonClickEventSubProcess4":
						break;
					case "LDAPEntryButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptLDAPEntryButtonClick");
						break;
					case "ScriptLDAPEntryButtonClick":
						e.Context.QueueTasks.Enqueue("LDAPEntryButtonClickUserTask");
						break;
					case "LDAPEntryButtonClickUserTask":
						break;
					case "LDAPUsersGridPageCloseEventSubProcess":
						break;
					case "LDAPUsersGridPageClose":
						e.Context.QueueTasks.Enqueue("ScriptLDAPUsersGridPageClose");
						break;
					case "ScriptLDAPUsersGridPageClose":
						break;
					case "EventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck":
						break;
					case "SynchronizeWithLDAPCheckBoxCheck":
						e.Context.QueueTasks.Enqueue("ScriptSynchronizeWithLDAPCheckBoxCheck");
						break;
					case "ScriptSynchronizeWithLDAPCheckBoxCheck":
						break;
					case "EventSubProcessPageLoadComplete":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteParent");
						break;
					case "PageLoadCompleteParent":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						break;
					case "SubProcessBaseAdministrationUnitEditPageOkBuutonClick":
						break;
					case "StartBaseAdministrationUnitEditPageOkButtonClick":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBaseOkButtonClick");
						break;
					case "ScriptBaseAdministrationUnitEditPageOkButtonClick":
						if (SequenceFlow4261ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("UserTaskLoadRowsAdditionalTreeGrid");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "IntermediateThrowBaseOkButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptBaseAdministrationUnitEditPageOkButtonClick");
						break;
					case "UserTaskLoadRowsAdditionalTreeGrid":
						break;
					case "ScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow4261ExpressionExecute() {
			return Convert.ToBoolean(AdditionalTreeGridClientID != String.Empty);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("LDAPEntryButtonClick");
			ActivatedEventElements.Add("LDAPUsersGridPageClose");
			ActivatedEventElements.Add("SynchronizeWithLDAPCheckBoxCheck");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("StartBaseAdministrationUnitEditPageOkButtonClick");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "LDAPEntryButtonClickEventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "LDAPEntryButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "LDAPEntryButtonClick";
					result = LDAPEntryButtonClick.Execute(context);
					break;
				case "ScriptLDAPEntryButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLDAPEntryButtonClick";
					result = ScriptLDAPEntryButtonClick.Execute(context, ScriptLDAPEntryButtonClickExecute);
					break;
				case "LDAPEntryButtonClickUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LDAPEntryButtonClickUserTask";
					result = LDAPEntryButtonClickUserTask.Execute(context);
					break;
				case "LDAPUsersGridPageCloseEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "LDAPUsersGridPageClose":
					context.QueueTasks.Dequeue();
					context.SenderName = "LDAPUsersGridPageClose";
					result = LDAPUsersGridPageClose.Execute(context);
					break;
				case "ScriptLDAPUsersGridPageClose":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLDAPUsersGridPageClose";
					result = ScriptLDAPUsersGridPageClose.Execute(context, ScriptLDAPUsersGridPageCloseExecute);
					break;
				case "EventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck":
					context.QueueTasks.Dequeue();
					break;
				case "SynchronizeWithLDAPCheckBoxCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeWithLDAPCheckBoxCheck";
					result = SynchronizeWithLDAPCheckBoxCheck.Execute(context);
					break;
				case "ScriptSynchronizeWithLDAPCheckBoxCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSynchronizeWithLDAPCheckBoxCheck";
					result = ScriptSynchronizeWithLDAPCheckBoxCheck.Execute(context, ScriptSynchronizeWithLDAPCheckBoxCheckExecute);
					break;
				case "EventSubProcessPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "PageLoadCompleteParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteParent.Execute(context);
					break;
				case "ScriptPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChild";
					result = ScriptPageLoadCompleteChild.Execute(context, ScriptPageLoadCompleteChildExecute);
					break;
				case "SubProcessBaseAdministrationUnitEditPageOkBuutonClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartBaseAdministrationUnitEditPageOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartBaseAdministrationUnitEditPageOkButtonClick";
					result = StartBaseAdministrationUnitEditPageOkButtonClick.Execute(context);
					break;
				case "ScriptBaseAdministrationUnitEditPageOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptBaseAdministrationUnitEditPageOkButtonClick";
					result = ScriptBaseAdministrationUnitEditPageOkButtonClick.Execute(context, ScriptBaseAdministrationUnitEditPageOkButtonClickExecute);
					break;
				case "IntermediateThrowBaseOkButtonClick":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowBaseOkButtonClick.Execute(context);
					break;
				case "UserTaskLoadRowsAdditionalTreeGrid":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskLoadRowsAdditionalTreeGrid";
					result = UserTaskLoadRowsAdditionalTreeGrid.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
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
				case "IsLdapEntryChanged":
					IsLdapEntryChanged = reader.GetValue<System.Boolean>();
				break;
				case "areConditionsCorrect":
					areConditionsCorrect = reader.GetValue<System.Boolean>();
				break;
				case "AdditionalTreeGridClientID":
					AdditionalTreeGridClientID = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptLDAPEntryButtonClickExecute(ProcessExecutingContext context) {
			LDAPEntryButtonClickUserTask.CloseMessage = "LDAPUsersGridPageClose";
			LDAPEntryButtonClickUserTask.OpenerInstanceId = InstanceUId;
			LDAPEntryButtonClickUserTask.PageUId = new Guid("{851a0832-1942-464f-85d9-c8ce0ab93e5d}");
			LDAPEntryButtonClickUserTask.UseCurrentActivePage = true;
			return true;
		}

		public virtual bool ScriptLDAPUsersGridPageCloseExecute(ProcessExecutingContext context) {
			var activeRow = Page.DataSource.ActiveRow;
			var currentUserId = UserConnection.CurrentUser.Id.ToString();
			var sessionData = UserConnection.SessionData;
			var ldapEntryKey = currentUserId + "LDAPEntry";
			if (sessionData[ldapEntryKey] != null) {
				activeRow.SetColumnValue("LDAPEntry", sessionData[currentUserId + "LDAPEntry"]);
				IsLdapEntryChanged = true;
				sessionData.Remove(currentUserId + "LDAPEntry");
			}
			var ldapEntryIdKey = currentUserId + "LDAPEntryId";
			if (sessionData[ldapEntryIdKey] != null) {
				activeRow.SetColumnValue("LDAPEntryId", sessionData[ldapEntryIdKey]);	
				sessionData.Remove(ldapEntryIdKey);
			}
			var ldapEntryDNKey = currentUserId + "LDAPEntryDN";
			if (sessionData[ldapEntryDNKey] != null) {
				activeRow.SetColumnValue("LDAPEntryDN", sessionData[ldapEntryDNKey]);	
				sessionData.Remove(ldapEntryDNKey);
			}
			return true;
		}

		public virtual bool ScriptSynchronizeWithLDAPCheckBoxCheckExecute(ProcessExecutingContext context) {
			SetLDAPEntryEnable();
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			SetLDAPEntryEnable();
			SetLDAPControlsVisibility();
			return true;
		}

		public virtual bool ScriptBaseAdministrationUnitEditPageOkButtonClickExecute(ProcessExecutingContext context) {
			AdditionalTreeGridClientID = String.Empty;
			var additionalTreeGridClientID = Page.GetParameterValue("additionalTreeGrid");
			if (additionalTreeGridClientID != null && areConditionsCorrect) {
				AdditionalTreeGridClientID = additionalTreeGridClientID.ToString();
				UserTaskLoadRowsAdditionalTreeGrid.Page = Page;
				UserTaskLoadRowsAdditionalTreeGrid.TreeGridClientID = AdditionalTreeGridClientID;
				UserTaskLoadRowsAdditionalTreeGrid.PrimaryColumnValue = EntityPrimaryColumnValue;
			}
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			return true;
		}

		public override bool AreConditionsCorrect(Entity row) {
			var entitySchemaManager = Page.UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			EntitySchemaQuery entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysAdminUnit");
			entitySchemaQuery.AddColumn("Id");
			EntitySchemaQueryFilterCollection filters = entitySchemaQuery.Filters;
			var filter = (EntitySchemaQueryFilter)entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Name", row.GetColumnValue("Name"));
			filters.Add(filter);
			filter = (EntitySchemaQueryFilter)entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.NotEqual, "Id", row.GetColumnValue("Id"));
			filters.Add(filter);
			EntitySchemaQueryOptions options = new EntitySchemaQueryOptions() {
				PageableDirection = PageableSelectDirection.Current,
				PageableConditionValues = new Dictionary<string, object>()
			};
			EntityCollection entityCollection = entitySchemaQuery.GetEntityCollection(Page.UserConnection, options);
			areConditionsCorrect = (entityCollection == null || (entityCollection.Count == 0));
			if (!areConditionsCorrect && !Page.BaseMessagePanel.HasMessage("CaptionNotUnique")) {
				Page.BaseMessagePanel.AddMessage("CaptionNotUnique", AttentionCaption, NameNotUniqueMessage);
			}
			return areConditionsCorrect;
		}

		public override void MakeCaption() {
			if(IsCaptionExists) {
				return;
			}
			
			var columnName = Page.DataSource.Schema.FindPrimaryDisplayColumnName();
			var primaryDisplayColumnName = String.Empty;
			var record = Page.GetParameterValue("recordId");
			var recordId = record != null ? new Guid(record.ToString()) : Guid.Empty;
			bool isNew = recordId.IsEmpty() || Convert.ToBoolean(Page.GetParameterValue("Copy"));
			if (isNew) {
				primaryDisplayColumnName = NewRecordCaption;
			} else {
				if(string.IsNullOrEmpty(columnName)) {
					primaryDisplayColumnName = EditingRecordCaption;
				} else {
					primaryDisplayColumnName = Page.DataSource.Rows[0].GetTypedColumnValue<string>(columnName);
				}
			}
			string caption;
			
			var shemaUId = Page.GetParameterValue("Id");
			
			switch (shemaUId.ToString()) {
				case "921acc0b-bc2d-4d46-8422-3a3cd2c99b79" : 
					caption = DepartmentCaption;
					break;
				case "5cc6b39d-d152-4768-91d7-ed417fca9073" : 
					caption = TeamCaption;
					break;
				case "247e12ab-d374-4fb5-a4d7-2ab3b0ed750a" : 
					caption = ChiefCaption;
					break;
				case "8d64ecff-4f2d-4791-a90a-6610f37fc116" : 
					caption = OrganizationCaption;
					break;
				default : caption = ElementCaption;
						  break;
			}
			
			caption = string.Format("{0} ({1})", caption, primaryDisplayColumnName);
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = caption;
		}

		public override Dictionary<string, object> GetDefValues() {
			var defValues = base.GetDefValues();
			var parentRoleIdObj = Page.GetParameterValue("ParentRole");
			if (parentRoleIdObj != null) {
				var parentRoleId = new Guid(parentRoleIdObj.ToString());
				if (parentRoleId != Guid.Empty) {
					defValues["ParentRole"] = parentRoleId;
				}
			}
			if ((Guid)defValues["ParentRole"] != Guid.Empty) {
				var sysAdminUnit = new SysAdminUnit(Page.UserConnection);
				if (sysAdminUnit.FetchFromDB((Guid)defValues["ParentRole"])) {
					defValues["ConnectionType"] = sysAdminUnit.GetColumnValue("ConnectionType");
				}
			}
			return defValues;
		}

		public virtual void SetLDAPEntryEnable() {
			var synchronizeWithLDAP = Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("SynchronizeWithLDAP");
			Page.LDAPEntryEdit.Clear();
			Page.LDAPEntryEdit.SetRequired(synchronizeWithLDAP);
			Page.LDAPEntryButton.SetEnabled(synchronizeWithLDAP);
			Page.LDAPEntryEdit.SetEnabled(synchronizeWithLDAP);
			return;
		}

		public virtual void SetLDAPControlsVisibility() {
			var enabled = false;
			Page.LDAPControlLayout.Enabled = enabled;
			Page.SynchronizeWithLDAPCheckBox.Enabled = enabled;
			Page.LDAPEntryEdit.Enabled = enabled;
			Page.LDAPEntryButton.Enabled = enabled;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "LDAPEntryButtonClick":
							if (ActivatedEventElements.Contains("LDAPEntryButtonClick")) {
							context.QueueTasks.Enqueue("LDAPEntryButtonClick");
						}
						break;
					case "LDAPUsersGridPageClose":
							if (ActivatedEventElements.Contains("LDAPUsersGridPageClose")) {
							context.QueueTasks.Enqueue("LDAPUsersGridPageClose");
						}
						break;
					case "SynchronizeWithLDAPCheckBoxCheck":
							if (ActivatedEventElements.Contains("SynchronizeWithLDAPCheckBoxCheck")) {
							context.QueueTasks.Enqueue("SynchronizeWithLDAPCheckBoxCheck");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("StartBaseAdministrationUnitEditPageOkButtonClick")) {
							context.QueueTasks.Enqueue("StartBaseAdministrationUnitEditPageOkButtonClick");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsLdapEntryChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsLdapEntryChanged", IsLdapEntryChanged, false);
			}
			if (!HasMapping("areConditionsCorrect") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("areConditionsCorrect", areConditionsCorrect, false);
			}
			if (!HasMapping("AdditionalTreeGridClientID") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AdditionalTreeGridClientID", AdditionalTreeGridClientID, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseAdministrationUnitEditPageEventsProcess

	/// <exclude/>
	public class BaseAdministrationUnitEditPageEventsProcess : BaseAdministrationUnitEditPageEventsProcess<Terrasoft.WebApp.BaseAdministrationUnitEditPageSchemaUserControl>
	{

		public BaseAdministrationUnitEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseAdministrationUnitEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseAdministrationUnitEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout LDAPControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("LDAPControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox SynchronizeWithLDAPCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("SynchronizeWithLDAPCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit LDAPEntryEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("LDAPEntryEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton LDAPEntryButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("LDAPEntryButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SynchronizeWithLDAPCheckBox.AjaxEvents.Check.Event += SynchronizeWithLDAPCheckBoxCheck;
			LDAPEntryButton.AjaxEvents.Click.Event += LDAPEntryButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SynchronizeWithLDAPCheckBox.AjaxEvents.Check.Event -= SynchronizeWithLDAPCheckBoxCheck;
			LDAPEntryButton.AjaxEvents.Click.Event -= LDAPEntryButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseAdministrationUnitEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseAdministrationUnitEditPageEventsProcess(UserConnection);
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

		public virtual void SynchronizeWithLDAPCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("SynchronizeWithLDAPCheckBoxCheck");
		}

		public virtual void LDAPEntryButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("LDAPEntryButtonClick");
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
			SchemaName = "BaseAdministrationUnitEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseAdministrationUnitEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseAdministrationUnitEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseAdministrationUnitEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseAdministrationUnitEditPageEventsProcessSchema(BaseAdministrationUnitEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseAdministrationUnitEditPageEventsProcess";
			UId = new Guid("be93cedc-0027-4250-a670-31afb5189433");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateAdditionalTreeGridClientIDParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fbd7acf1-d3b3-47f4-ab3d-97cb61c9a0a3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"AdditionalTreeGridClientID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateareConditionsCorrectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8a5c883b-5fdd-4452-bb73-48a459f68a02"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"areConditionsCorrect",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsLdapEntryChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("63e43393-a01f-46d1-8398-59a2688de329"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"IsLdapEntryChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateAdditionalTreeGridClientIDParameter());
			Parameters.Add(CreateareConditionsCorrectParameter());
			Parameters.Add(CreateIsLdapEntryChangedParameter());
		}

		protected virtual void InitializeLDAPEntryButtonClickUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f07c4eb5-4309-49c5-b288-7053de474558"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("53bd0182-b250-4201-9799-32bc3bfa948f"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("921c95f5-1ef1-404b-8c70-76c674606534"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("adfe5f7d-87e3-46ed-b030-59106d8843ab"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("f18ea279-3c03-4e99-b65a-53de162cce5b"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("d592d36f-f09d-46c7-adcf-bbb64a411b75"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("d01b6dee-772a-41b6-afb9-090027bc6313"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("b1a4ada0-c052-4f17-b5c5-fb7c5adf4666"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("7f3ffc55-4e8e-42d5-b4f3-ae968313980d"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("d10fb753-5872-490f-9058-873c90f63438"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("1f11c7d9-96d0-454c-952a-905e8b3fc4c3"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
				UId = new Guid("6d3ae694-6051-4a5e-83f4-1d66a3d54646"),
				ContainerUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
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
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeUserTaskLoadRowsAdditionalTreeGridParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("6e6b8ece-d378-4e48-87fb-8543f8a65aea"),
				ContainerUId = new Guid("1a77b270-d913-49b8-8c73-e9c07363488b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
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
				UId = new Guid("997d38ae-b547-41d7-9388-f70cab6094b2"),
				ContainerUId = new Guid("1a77b270-d913-49b8-8c73-e9c07363488b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Name = @"TreeGridClientID",
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
				UId = new Guid("9693face-f976-461a-8415-0ab9f70b8a6e"),
				ContainerUId = new Guid("1a77b270-d913-49b8-8c73-e9c07363488b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Name = @"PrimaryColumnValue",
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
				UId = new Guid("e2167462-fd2b-4fc7-b945-9a6580bc7856"),
				ContainerUId = new Guid("1a77b270-d913-49b8-8c73-e9c07363488b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				Name = @"LoadRows",
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
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet266 = CreateLaneSet266LaneSet();
			LaneSets.Add(schemaLaneSet266);
			ProcessSchemaLane schemaLane743 = CreateLane743Lane();
			schemaLaneSet266.Lanes.Add(schemaLane743);
			ProcessSchemaEventSubProcess ldapentrybuttonclickeventsubprocess4 = CreateLDAPEntryButtonClickEventSubProcess4EventSubProcess();
			FlowElements.Add(ldapentrybuttonclickeventsubprocess4);
			ProcessSchemaEventSubProcess ldapusersgridpagecloseeventsubprocess = CreateLDAPUsersGridPageCloseEventSubProcessEventSubProcess();
			FlowElements.Add(ldapusersgridpagecloseeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocessscriptsynchronizewithldapcheckboxcheck = CreateEventSubProcessScriptSynchronizeWithLDAPCheckBoxCheckEventSubProcess();
			FlowElements.Add(eventsubprocessscriptsynchronizewithldapcheckboxcheck);
			ProcessSchemaEventSubProcess eventsubprocesspageloadcomplete = CreateEventSubProcessPageLoadCompleteEventSubProcess();
			FlowElements.Add(eventsubprocesspageloadcomplete);
			ProcessSchemaEventSubProcess subprocessbaseadministrationuniteditpageokbuutonclick = CreateSubProcessBaseAdministrationUnitEditPageOkBuutonClickEventSubProcess();
			FlowElements.Add(subprocessbaseadministrationuniteditpageokbuutonclick);
			ProcessSchemaStartMessageEvent ldapentrybuttonclick = CreateLDAPEntryButtonClickStartMessageEvent();
			ldapentrybuttonclickeventsubprocess4.FlowElements.Add(ldapentrybuttonclick);
			ProcessSchemaScriptTask scriptldapentrybuttonclick = CreateScriptLDAPEntryButtonClickScriptTask();
			ldapentrybuttonclickeventsubprocess4.FlowElements.Add(scriptldapentrybuttonclick);
			ProcessSchemaUserTask ldapentrybuttonclickusertask = CreateLDAPEntryButtonClickUserTaskUserTask();
			ldapentrybuttonclickeventsubprocess4.FlowElements.Add(ldapentrybuttonclickusertask);
			ProcessSchemaStartMessageEvent ldapusersgridpageclose = CreateLDAPUsersGridPageCloseStartMessageEvent();
			ldapusersgridpagecloseeventsubprocess.FlowElements.Add(ldapusersgridpageclose);
			ProcessSchemaScriptTask scriptldapusersgridpageclose = CreateScriptLDAPUsersGridPageCloseScriptTask();
			ldapusersgridpagecloseeventsubprocess.FlowElements.Add(scriptldapusersgridpageclose);
			ProcessSchemaStartMessageEvent synchronizewithldapcheckboxcheck = CreateSynchronizeWithLDAPCheckBoxCheckStartMessageEvent();
			eventsubprocessscriptsynchronizewithldapcheckboxcheck.FlowElements.Add(synchronizewithldapcheckboxcheck);
			ProcessSchemaScriptTask scriptsynchronizewithldapcheckboxcheck = CreateScriptSynchronizeWithLDAPCheckBoxCheckScriptTask();
			eventsubprocessscriptsynchronizewithldapcheckboxcheck.FlowElements.Add(scriptsynchronizewithldapcheckboxcheck);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			eventsubprocesspageloadcomplete.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteparent = CreatePageLoadCompleteParentIntermediateThrowMessageEvent();
			eventsubprocesspageloadcomplete.FlowElements.Add(pageloadcompleteparent);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			eventsubprocesspageloadcomplete.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaStartMessageEvent startbaseadministrationuniteditpageokbuttonclick = CreateStartBaseAdministrationUnitEditPageOkButtonClickStartMessageEvent();
			subprocessbaseadministrationuniteditpageokbuutonclick.FlowElements.Add(startbaseadministrationuniteditpageokbuttonclick);
			ProcessSchemaScriptTask scriptbaseadministrationuniteditpageokbuttonclick = CreateScriptBaseAdministrationUnitEditPageOkButtonClickScriptTask();
			subprocessbaseadministrationuniteditpageokbuutonclick.FlowElements.Add(scriptbaseadministrationuniteditpageokbuttonclick);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbaseokbuttonclick = CreateIntermediateThrowBaseOkButtonClickIntermediateThrowMessageEvent();
			subprocessbaseadministrationuniteditpageokbuutonclick.FlowElements.Add(intermediatethrowbaseokbuttonclick);
			ProcessSchemaUserTask usertaskloadrowsadditionaltreegrid = CreateUserTaskLoadRowsAdditionalTreeGridUserTask();
			subprocessbaseadministrationuniteditpageokbuutonclick.FlowElements.Add(usertaskloadrowsadditionaltreegrid);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			subprocessbaseadministrationuniteditpageokbuutonclick.FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow4261ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4264SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4267SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4268SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4269SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4270SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4271SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4272SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4273SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4274SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNameNotUniqueMessageLocalizableString());
			LocalizableStrings.Add(CreateAttentionCaptionLocalizableString());
			LocalizableStrings.Add(CreateElementCaptionLocalizableString());
			LocalizableStrings.Add(CreateDepartmentCaptionLocalizableString());
			LocalizableStrings.Add(CreateTeamCaptionLocalizableString());
			LocalizableStrings.Add(CreateChiefCaptionLocalizableString());
			LocalizableStrings.Add(CreateOrganizationCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNameNotUniqueMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0d4074d4-517a-4422-a566-6012f1abd0b9"),
				Name = "NameNotUniqueMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAttentionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b1bf1003-677a-49a4-9b0f-3b72266c536b"),
				Name = "AttentionCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateElementCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aa1a4477-ea8f-43fb-b2ad-2e0c0adf2ec4"),
				Name = "ElementCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDepartmentCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f51f7394-e248-43a0-86bc-cbaa64b9b252"),
				Name = "DepartmentCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTeamCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4945b165-5fae-4298-ab7d-e6578b7701cb"),
				Name = "TeamCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateChiefCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cace1d4c-d467-4496-9972-99f94fc8cacf"),
				Name = "ChiefCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOrganizationCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c91248d0-5ac2-42bb-8bb8-fc56f0214b9a"),
				Name = "OrganizationCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow4261ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow4261",
				UId = new Guid("65ff380d-05c8-43f6-b0fc-8988a3df6399"),
				ConditionExpression = @"AdditionalTreeGridClientID != String.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(192, 709),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("079a5788-d305-4e1f-be2b-c4faa416a03d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1a77b270-d913-49b8-8c73-e9c07363488b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(224, 507));
			schemaFlow.PolylinePointPositions.Add(new Point(301, 507));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4264SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4264",
				UId = new Guid("ffc42709-ec35-4dc9-9713-48d3aa518e8e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(196, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b9f4f540-c6b8-4140-b8ab-678f52227f94"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("079a5788-d305-4e1f-be2b-c4faa416a03d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(119, 507));
			schemaFlow.PolylinePointPositions.Add(new Point(224, 507));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4267SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4267",
				UId = new Guid("ed8e8f55-a917-48b4-8158-3a96f076e581"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(196, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5da1e769-b2a8-4260-9c06-6c0dc7e8c687"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b9f4f540-c6b8-4140-b8ab-678f52227f94"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4268SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4268",
				UId = new Guid("d6d7bfbf-aa71-4c56-acde-313a6904e7d1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(330, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("079a5788-d305-4e1f-be2b-c4faa416a03d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d6438337-7ee6-4440-810d-da82bd161ecd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4269SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4269",
				UId = new Guid("926a59ee-7f89-4bef-874b-11203206f502"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6971cc4d-5874-4835-bc6c-ece798be2d30"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("46858c16-3b75-44a7-adf8-12676c789f45"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4270SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4270",
				UId = new Guid("77df39f1-17e7-4070-990d-91011f6b0f3e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(359, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18378d4b-5388-4120-8748-0faa72c54fe5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("160189d5-08ec-43ed-9acc-ca75198ebe2e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4271SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4271",
				UId = new Guid("8581da05-121f-44ff-9507-e16f7f38bfa3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(441, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("160189d5-08ec-43ed-9acc-ca75198ebe2e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7032531e-3e3c-4d91-ab9c-99f13a837506"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4272SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4272",
				UId = new Guid("7abdc9fb-1396-4a2e-a7ef-9036fc3c2f1d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("273a646d-8aba-4b32-bb24-69f72dd82e2b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4fb19a03-39c2-4934-b0ed-13559a4fb4ea"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4273SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4273",
				UId = new Guid("57c30ae4-5097-413c-82bb-c1150a15a918"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(260, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4fb19a03-39c2-4934-b0ed-13559a4fb4ea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4274SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4274",
				UId = new Guid("43d70add-90e6-419e-99b9-9d2ea8006bee"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CurveCenterPosition = new Point(520, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4be4047f-8d77-4b78-9df8-02c0553e3ccc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2432e106-0506-4ae2-b44f-74de5a75b32e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet266LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet266 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("451ed6bf-bb6b-4513-8d06-16b728383768"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"LaneSet266",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1093, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet266;
		}

		protected virtual ProcessSchemaLane CreateLane743Lane() {
			ProcessSchemaLane schemaLane743 = new ProcessSchemaLane(this) {
				UId = new Guid("a08122f9-9223-4891-997e-2edda09c8153"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("451ed6bf-bb6b-4513-8d06-16b728383768"),
				CreatedInOwnerSchemaUId = new Guid("a3c512b3-ff21-4d08-a8ea-6590b9d3dcf2"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"Lane743",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1064, 177),
				UseBackgroundMode = false
			};
			return schemaLane743;
		}

		protected virtual ProcessSchemaEventSubProcess CreateLDAPEntryButtonClickEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaLDAPEntryButtonClickEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9b435c20-0406-415a-8f01-3093679fc025"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a08122f9-9223-4891-997e-2edda09c8153"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"LDAPEntryButtonClickEventSubProcess4",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(327, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaLDAPEntryButtonClickEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLDAPEntryButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("273a646d-8aba-4b32-bb24-69f72dd82e2b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b435c20-0406-415a-8f01-3093679fc025"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"LDAPEntryButtonClick",
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"LDAPEntryButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLDAPEntryButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4fb19a03-39c2-4934-b0ed-13559a4fb4ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b435c20-0406-415a-8f01-3093679fc025"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"ScriptLDAPEntryButtonClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,205,10,194,48,16,132,239,62,69,233,73,15,149,254,74,74,241,80,171,148,66,197,30,236,3,196,100,149,208,146,202,38,81,68,124,119,251,131,87,123,219,217,157,249,134,45,247,105,117,144,26,95,59,163,117,39,179,86,176,166,86,128,103,170,154,117,214,118,10,142,160,20,189,129,181,181,236,178,55,15,71,149,163,224,85,191,28,13,118,178,40,255,81,78,119,144,128,133,84,154,74,6,5,239,73,63,81,23,124,38,60,180,212,99,70,194,211,202,141,224,75,251,77,34,143,186,36,240,29,47,14,125,39,220,132,87,135,68,60,118,24,97,224,210,75,28,64,196,63,246,106,6,221,15,153,65,4,169,83,166,197,3,170,233,75,141,6,146,5,130,54,40,39,241,5,49,69,26,8,36,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateLDAPEntryButtonClickUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("544e4fbc-1b01-42c3-ae51-d77e17f34661"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b435c20-0406-415a-8f01-3093679fc025"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"LDAPEntryButtonClickUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 37),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeLDAPEntryButtonClickUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateLDAPUsersGridPageCloseEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaLDAPUsersGridPageCloseEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("20ca54d6-fc69-420c-bc8b-a511dc8f37d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a08122f9-9223-4891-997e-2edda09c8153"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"LDAPUsersGridPageCloseEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(379, 2),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaLDAPUsersGridPageCloseEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLDAPUsersGridPageCloseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4be4047f-8d77-4b78-9df8-02c0553e3ccc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("20ca54d6-fc69-420c-bc8b-a511dc8f37d8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LDAPUsersGridPageClose",
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"LDAPUsersGridPageClose",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLDAPUsersGridPageCloseScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2432e106-0506-4ae2-b44f-74de5a75b32e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("20ca54d6-fc69-420c-bc8b-a511dc8f37d8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"ScriptLDAPUsersGridPageClose",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,193,106,131,64,16,134,207,250,20,155,156,148,134,125,1,201,33,104,15,210,16,66,108,123,9,57,44,58,181,194,102,182,172,187,150,80,250,238,29,181,105,214,166,85,114,19,230,255,191,241,155,109,132,102,34,55,85,3,59,245,206,150,108,43,74,224,137,48,34,83,86,231,192,87,231,89,228,55,20,205,173,214,128,230,169,6,157,22,20,111,63,98,133,8,20,83,200,227,203,152,167,5,127,84,153,209,21,150,65,216,183,107,168,107,138,181,248,235,110,118,25,246,105,89,136,183,123,52,250,244,0,39,138,15,87,223,177,249,58,89,109,187,249,60,242,171,23,22,56,244,189,219,61,176,217,146,161,149,50,100,31,190,247,35,75,11,77,172,164,61,226,179,144,22,2,135,183,112,255,116,63,178,248,64,98,94,90,175,207,219,226,87,129,37,180,135,49,218,2,205,28,14,223,193,81,53,16,140,224,136,246,57,84,79,139,41,249,180,24,211,239,250,55,31,128,152,195,19,252,226,133,145,247,167,218,48,118,109,147,108,166,108,146,205,152,77,215,191,217,134,152,255,216,244,188,73,155,46,214,217,104,48,86,227,247,227,126,1,223,114,227,15,59,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessScriptSynchronizeWithLDAPCheckBoxCheckEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4d8e7742-0a8c-41ca-8586-a84b76c0885a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a08122f9-9223-4891-997e-2edda09c8153"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"EventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck",
				Position = new Point(36, 192),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessScriptSynchronizeWithLDAPCheckBoxCheck;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSynchronizeWithLDAPCheckBoxCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6971cc4d-5874-4835-bc6c-ece798be2d30"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d8e7742-0a8c-41ca-8586-a84b76c0885a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SynchronizeWithLDAPCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"SynchronizeWithLDAPCheckBoxCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSynchronizeWithLDAPCheckBoxCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("46858c16-3b75-44a7-adf8-12676c789f45"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d8e7742-0a8c-41ca-8586-a84b76c0885a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"ScriptSynchronizeWithLDAPCheckBoxCheck",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,241,113,113,12,112,205,43,41,170,116,205,75,76,202,73,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,104,212,208,18,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("be58466d-5696-4b23-83f8-97b0d07f728e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a08122f9-9223-4891-997e-2edda09c8153"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"EventSubProcessPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 191),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(277, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("18378d4b-5388-4120-8748-0faa72c54fe5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be58466d-5696-4b23-83f8-97b0d07f728e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("160189d5-08ec-43ed-9acc-ca75198ebe2e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be58466d-5696-4b23-83f8-97b0d07f728e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"PageLoadCompleteParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(91, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7032531e-3e3c-4d91-ab9c-99f13a837506"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be58466d-5696-4b23-83f8-97b0d07f728e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(168, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,241,113,113,12,112,205,43,41,170,116,205,75,76,202,73,213,208,180,230,10,134,136,58,231,3,133,243,115,138,195,50,139,51,147,50,115,50,75,42,65,146,69,169,37,165,69,121,10,37,69,165,169,214,0,171,243,247,57,63,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessBaseAdministrationUnitEditPageOkBuutonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessBaseAdministrationUnitEditPageOkBuutonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b9021768-6ccf-48c3-9cf9-a28860c89d6a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a08122f9-9223-4891-997e-2edda09c8153"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"SubProcessBaseAdministrationUnitEditPageOkBuutonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 371),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(367, 304),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessBaseAdministrationUnitEditPageOkBuutonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartBaseAdministrationUnitEditPageOkButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5da1e769-b2a8-4260-9c06-6c0dc7e8c687"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9021768-6ccf-48c3-9cf9-a28860c89d6a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"StartBaseAdministrationUnitEditPageOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptBaseAdministrationUnitEditPageOkButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("079a5788-d305-4e1f-be2b-c4faa416a03d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9021768-6ccf-48c3-9cf9-a28860c89d6a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"ScriptBaseAdministrationUnitEditPageOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,205,10,130,80,16,70,215,221,167,152,90,136,110,124,1,105,33,38,18,180,136,178,246,67,78,114,233,122,111,140,99,33,209,187,103,63,59,83,92,14,51,223,225,124,19,23,133,22,237,44,154,156,137,50,214,69,98,52,89,89,175,96,9,123,97,109,203,48,173,174,210,70,234,134,12,56,118,190,197,146,194,140,100,139,140,21,9,241,17,77,67,254,162,31,90,4,145,210,103,240,71,112,243,37,216,198,24,240,60,64,166,196,217,239,101,157,56,102,58,73,0,15,53,139,199,108,134,217,97,238,190,205,252,78,99,118,168,137,115,172,47,27,135,197,206,221,235,62,52,124,23,251,245,155,22,248,163,51,236,58,209,129,117,133,220,38,206,52,149,253,60,182,131,166,86,180,180,253,85,164,158,138,73,26,182,32,220,141,47,108,122,145,21,230,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBaseOkButtonClickIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b9f4f540-c6b8-4140-b8ab-678f52227f94"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9021768-6ccf-48c3-9cf9-a28860c89d6a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"IntermediateThrowBaseOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskLoadRowsAdditionalTreeGridUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1a77b270-d913-49b8-8c73-e9c07363488b"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9021768-6ccf-48c3-9cf9-a28860c89d6a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"UserTaskLoadRowsAdditionalTreeGrid",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 191),
				SchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskLoadRowsAdditionalTreeGridParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d6438337-7ee6-4440-810d-da82bd161ecd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9021768-6ccf-48c3-9cf9-a28860c89d6a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetLDAPEntryEnableMethod());
			Methods.Add(CreateSetLDAPControlsVisibilityMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9172e0a8-be67-4466-bee9-4324d80b45f1"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0127c4ec-c32d-490a-92db-dac6957dd282"),
				Name = "System.Linq",
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

		protected override SchemaMethod CreateAreConditionsCorrectMethod() {
			SchemaMethod method = base.CreateAreConditionsCorrectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,147,77,79,220,64,12,134,207,228,87,152,28,208,68,138,34,238,91,42,45,129,150,30,160,91,109,129,243,64,12,76,53,153,89,230,3,20,21,254,123,237,124,44,31,147,61,246,148,196,126,237,121,60,175,243,36,29,160,9,42,116,235,219,7,108,229,185,52,242,30,29,28,193,138,158,213,165,71,87,91,99,240,54,40,107,170,239,24,62,200,68,126,154,214,230,5,72,15,51,137,69,246,62,248,43,162,235,62,156,61,68,142,192,224,51,36,74,49,67,89,66,190,238,252,178,105,149,185,52,42,228,197,34,75,250,85,203,166,169,173,142,173,17,249,143,134,37,73,235,111,74,7,30,83,235,97,76,184,235,3,158,80,210,118,131,216,47,178,39,186,185,65,72,58,177,163,105,145,54,168,29,202,128,67,250,90,133,135,149,116,178,69,238,41,178,189,9,165,221,72,167,188,53,191,187,13,86,167,143,81,106,154,245,130,116,121,9,206,62,179,17,195,80,87,82,71,20,67,170,160,225,70,116,158,90,12,239,219,224,255,198,188,176,97,34,165,139,158,231,100,7,118,81,38,108,63,55,236,134,7,59,62,119,108,198,40,19,5,252,205,246,120,107,229,141,198,19,229,70,51,135,77,230,216,26,217,224,109,166,170,163,115,52,120,249,86,69,171,222,40,206,245,184,211,137,39,170,215,75,215,125,241,193,41,115,95,130,189,249,67,77,190,138,34,123,157,192,223,237,15,126,14,204,45,18,93,205,231,66,49,243,207,149,211,248,116,67,210,189,17,250,218,58,30,132,93,77,207,35,240,168,53,188,188,164,201,170,182,209,4,150,28,178,21,234,14,196,254,108,227,131,3,216,239,129,142,165,199,115,244,158,222,87,210,160,174,206,164,31,191,69,94,203,30,143,204,167,95,240,49,242,22,78,62,164,133,228,247,238,194,18,150,33,48,173,53,99,174,4,222,235,173,98,44,37,232,215,204,97,136,206,192,28,248,226,31,23,205,214,118,212,4,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,73,111,155,64,20,62,219,146,255,195,148,19,72,1,177,25,66,211,180,106,29,39,226,226,68,89,218,67,213,195,99,230,145,140,202,166,153,33,174,155,248,191,119,0,219,217,26,159,44,60,223,54,223,123,192,115,51,149,51,104,20,175,171,249,31,46,149,180,200,195,100,60,18,168,90,81,29,77,198,235,201,120,50,190,7,65,104,93,180,101,181,128,18,201,49,185,128,91,116,78,64,193,85,221,10,138,206,21,189,195,18,156,83,94,177,11,193,75,16,171,19,46,155,2,86,179,29,203,180,142,6,161,230,29,128,150,189,82,130,87,183,206,188,108,212,106,131,22,72,107,193,182,150,103,168,46,64,104,176,66,241,29,138,22,77,99,0,164,204,176,94,48,210,142,179,33,127,56,38,85,91,20,228,11,169,112,73,206,90,206,204,225,196,185,174,7,75,211,178,200,199,254,100,103,158,213,117,65,184,92,104,198,241,78,211,73,101,127,110,90,228,241,145,204,234,234,30,133,210,42,223,52,24,161,50,223,11,57,171,155,149,97,117,9,121,78,204,94,117,232,121,79,25,26,115,217,219,110,198,211,13,131,96,33,177,39,242,220,148,67,91,169,92,232,203,157,139,33,216,211,152,172,193,97,159,197,156,113,165,37,94,219,140,158,249,236,163,191,222,130,203,122,41,127,186,191,186,2,174,87,13,178,1,220,87,240,105,8,251,249,121,190,222,169,223,176,225,144,208,93,130,97,146,178,91,170,155,116,223,244,55,115,215,18,75,174,232,29,49,183,156,23,163,237,46,66,65,223,200,72,124,15,40,117,51,59,163,62,179,67,22,70,246,97,232,251,118,0,1,101,62,77,146,44,78,12,189,10,221,205,55,113,180,251,9,54,32,84,137,149,122,86,210,40,19,8,191,143,118,210,83,74,163,44,72,152,205,188,169,111,135,113,116,104,39,30,139,109,100,161,23,231,20,18,55,14,222,74,95,35,148,123,68,253,48,70,207,135,204,102,65,28,218,97,158,77,109,8,181,168,254,43,200,92,100,241,212,133,183,162,179,59,142,249,30,213,67,22,133,72,243,92,11,118,45,196,137,103,235,120,96,71,145,231,230,129,14,235,121,209,91,213,115,113,11,21,255,11,221,227,127,197,25,230,208,22,74,19,159,72,243,2,95,247,54,34,100,75,233,191,46,79,224,205,70,159,214,162,4,101,26,15,238,154,152,15,222,218,50,14,182,138,7,239,126,62,186,53,24,222,191,175,178,233,126,9,72,221,174,16,32,235,92,57,55,169,243,3,51,253,198,42,81,23,210,233,0,150,51,219,57,111,87,239,31,28,142,224,53,16,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,189,78,195,48,20,70,231,68,202,59,152,78,246,146,23,168,58,64,75,43,38,34,218,178,32,6,183,185,45,70,246,117,228,159,162,8,245,221,177,147,146,132,20,88,173,239,28,223,239,218,39,110,72,9,135,103,46,61,88,50,35,59,110,33,95,129,91,124,159,81,54,205,210,83,72,85,220,0,186,39,45,225,161,124,220,189,135,108,193,143,77,182,224,134,43,112,96,26,130,78,138,46,57,137,176,56,16,58,134,111,102,4,189,148,140,124,102,105,50,182,7,53,194,7,89,121,81,142,193,124,163,215,206,8,60,82,22,213,201,216,29,197,145,203,239,85,229,234,86,159,116,253,94,134,163,189,134,107,134,104,212,157,179,244,220,14,76,163,133,253,69,254,114,75,44,97,107,123,91,42,129,91,20,238,82,98,61,56,162,205,194,182,22,204,92,35,194,222,9,141,93,139,33,155,47,193,237,223,150,70,171,197,221,255,147,176,235,138,189,123,83,87,109,205,31,238,240,96,115,45,189,194,203,107,141,242,172,223,131,1,231,13,246,223,99,250,5,235,43,132,117,45,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetLDAPEntryEnableMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2ef1cfc2-f300-44a7-a45b-92d29c867e26"),
				Name = "SetLDAPEntryEnable",
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,193,10,130,80,16,69,247,65,255,32,174,108,243,126,192,10,76,165,77,11,209,168,245,168,67,62,120,205,212,52,207,176,175,15,131,86,22,181,188,92,206,185,183,7,9,110,3,53,157,48,217,7,30,173,118,187,44,41,130,85,80,192,9,77,6,10,21,123,105,208,36,141,218,30,75,190,155,45,234,126,184,96,155,178,243,103,58,128,243,184,172,153,221,58,10,171,169,42,92,196,243,217,75,54,166,156,84,134,188,181,106,82,135,32,209,151,178,66,45,241,234,173,96,27,125,184,55,165,54,94,149,105,228,114,130,218,253,139,189,199,126,64,130,234,133,226,39,53,218,31,215,45,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetLDAPControlsVisibilityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d3d6f39a-8d44-468d-a4f9-3d7eec1c75fd"),
				Name = "SetLDAPControlsVisibility",
				CreatedInSchemaUId = new Guid("be93cedc-0027-4250-a670-31afb5189433"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,205,75,76,202,73,77,81,176,85,72,75,204,41,78,181,230,10,72,76,79,213,243,113,113,12,112,206,207,43,41,202,207,241,73,172,204,47,45,209,115,133,171,131,234,128,170,12,174,204,75,206,40,202,207,203,172,74,13,207,44,201,0,107,204,72,77,206,118,202,175,192,169,7,164,200,21,104,120,165,107,74,38,110,147,225,170,156,74,75,74,242,243,176,168,3,0,53,241,207,76,192,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseAdministrationUnitEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be93cedc-0027-4250-a670-31afb5189433"));
		}

		#endregion

	}

	#endregion

}

