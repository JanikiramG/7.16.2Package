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

	#region Class: RelationTypeEditPageSchema

	/// <exclude/>
	public class RelationTypeEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _reverseRelationTypeEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ReverseRelationTypeEdit {
			get {
				return _reverseRelationTypeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout {
			get {
				return _controlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _forContactContactEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ForContactContactEdit {
			get {
				return _forContactContactEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _forAccountContactEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ForAccountContactEdit {
			get {
				return _forAccountContactEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _forContactAccountEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ForContactAccountEdit {
			get {
				return _forContactAccountEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _forAccountAccountEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ForAccountAccountEdit {
			get {
				return _forAccountAccountEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public RelationTypeEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public RelationTypeEditPageSchema(RelationTypeEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("1f5a3ae3-3293-438a-bc0f-ebbeccb6b91e");
			NameEdit.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("dcd87a41-98fa-4f98-a34e-7a66d3a66152");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			RealUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			Name = "RelationTypeEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 375;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRelationTypeEditPageEventsProcessSchema();
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
			MainControlLayout.MoveItem(1, DescriptionEdit);
			MainControlLayout.InsertItem(2, CreateReverseRelationTypeEdit());
			MainControlLayout.InsertItem(3, CreateControlLayout());
			ControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateForContactContactEdit());
			ControlLayout1.InsertItem(1, CreateForAccountContactEdit());
			ControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateForContactAccountEdit());
			ControlLayout2.InsertItem(1, CreateForAccountAccountEdit());
			MainControlLayout.MoveItem(4, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateRelationTypeEditPageEventsProcessSchema() {
			var schema = new RelationTypeEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateReverseRelationTypeEdit() {
			_reverseRelationTypeEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_reverseRelationTypeEdit.UId = new Guid("0a8a6344-9ad3-48a4-978a-f708991b9728");
			_reverseRelationTypeEdit.Name = "ReverseRelationTypeEdit";
			_reverseRelationTypeEdit.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_reverseRelationTypeEdit.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_reverseRelationTypeEdit.CreatedInPackageId = Guid.Empty;
			_reverseRelationTypeEdit.Tag = "";
			_reverseRelationTypeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_reverseRelationTypeEdit.Image = new ControlImage {};
			_reverseRelationTypeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_reverseRelationTypeEdit.DataSource = "DataSource";
			_reverseRelationTypeEdit.ColumnUId = new Guid("e73b69ba-202a-48c5-b62f-0ab84853eae0");
			return _reverseRelationTypeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateForContactContactEdit() {
			_forContactContactEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_forContactContactEdit.UId = new Guid("593d2c58-3fd9-4eb0-99a5-008c581e67ab");
			_forContactContactEdit.Name = "ForContactContactEdit";
			_forContactContactEdit.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_forContactContactEdit.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_forContactContactEdit.CreatedInPackageId = Guid.Empty;
			_forContactContactEdit.Tag = "";
			_forContactContactEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_forContactContactEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_forContactContactEdit.AlignedByCaption = false;
			_forContactContactEdit.DataSource = "DataSource";
			_forContactContactEdit.ColumnUId = new Guid("e21705c0-00f6-43eb-bf20-4fd3f79e175c");
			return _forContactContactEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateForAccountContactEdit() {
			_forAccountContactEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_forAccountContactEdit.UId = new Guid("f8bfa3e5-d9c6-4dc8-871f-38e81b9b83dd");
			_forAccountContactEdit.Name = "ForAccountContactEdit";
			_forAccountContactEdit.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_forAccountContactEdit.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_forAccountContactEdit.CreatedInPackageId = Guid.Empty;
			_forAccountContactEdit.Tag = "";
			_forAccountContactEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_forAccountContactEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_forAccountContactEdit.AlignedByCaption = false;
			_forAccountContactEdit.DataSource = "DataSource";
			_forAccountContactEdit.ColumnUId = new Guid("8c6a77fb-f28d-4c05-a720-6527dd573993");
			return _forAccountContactEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("6c0b12f0-38b3-4b88-8a45-495598452719");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_controlLayout1.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_controlLayout1.CreatedInPackageId = Guid.Empty;
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateForContactAccountEdit() {
			_forContactAccountEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_forContactAccountEdit.UId = new Guid("6b78200e-ff75-4d96-84db-bb6344fbcbfc");
			_forContactAccountEdit.Name = "ForContactAccountEdit";
			_forContactAccountEdit.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_forContactAccountEdit.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_forContactAccountEdit.CreatedInPackageId = Guid.Empty;
			_forContactAccountEdit.Tag = "";
			_forContactAccountEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_forContactAccountEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_forContactAccountEdit.DataSource = "DataSource";
			_forContactAccountEdit.ColumnUId = new Guid("94b1b49a-bd6c-4be4-a892-5c0818256cbb");
			return _forContactAccountEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateForAccountAccountEdit() {
			_forAccountAccountEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_forAccountAccountEdit.UId = new Guid("65944245-d023-4ef3-9647-263be47700b4");
			_forAccountAccountEdit.Name = "ForAccountAccountEdit";
			_forAccountAccountEdit.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_forAccountAccountEdit.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_forAccountAccountEdit.CreatedInPackageId = Guid.Empty;
			_forAccountAccountEdit.Tag = "";
			_forAccountAccountEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_forAccountAccountEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_forAccountAccountEdit.DataSource = "DataSource";
			_forAccountAccountEdit.ColumnUId = new Guid("104d3058-abc1-40bf-9eb6-35d9fa0f1226");
			return _forAccountAccountEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("5f987372-72b5-4a27-805b-0fac38de52a1");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_controlLayout2.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_controlLayout2.CreatedInPackageId = Guid.Empty;
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout() {
			_controlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout.UId = new Guid("780fecfc-6578-4a18-808e-553b1acc18bf");
			_controlLayout.Name = "ControlLayout";
			_controlLayout.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_controlLayout.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			_controlLayout.CreatedInPackageId = Guid.Empty;
			_controlLayout.Tag = "";
			_controlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout.FitHeightByContent = true;
			_controlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout.Padding = "0 0 0 10";
			_controlLayout.StartNewAlignGroup = false;
			_controlLayout.Image = new ControlImage {};
			_controlLayout.Edges = "";
			return _controlLayout;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23");
			DataSource.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("223654e8-abff-46c8-a8a7-fbc56c249f27");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("c9b385d3-c312-49c0-b243-3f323e241d2b");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("a51d83f5-7d84-4987-9a58-c294d0bd00a3");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("4de157f9-5d42-4d95-a2a6-e452e090bebe");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("983014ac-4c1d-44e0-ad39-f47d7320bd73");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("1f5a3ae3-3293-438a-bc0f-ebbeccb6b91e");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("dcd87a41-98fa-4f98-a34e-7a66d3a66152");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f4e69913-fe63-4238-bf3c-1107f516ed75");
			if (column != null) {
				column.UId = new Guid("e21705c0-00f6-43eb-bf20-4fd3f79e175c");
				column.Name = @"ForContactContact";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a4671b71-f200-4c14-b7fa-2cb2fe5492b4");
			if (column != null) {
				column.UId = new Guid("8c6a77fb-f28d-4c05-a720-6527dd573993");
				column.Name = @"ForAccountContact";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("09ad639a-d97b-457f-89a6-7a173badefb5");
			if (column != null) {
				column.UId = new Guid("94b1b49a-bd6c-4be4-a892-5c0818256cbb");
				column.Name = @"ForContactAccount";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6838568d-88cd-402c-bddf-c798342238f0");
			if (column != null) {
				column.UId = new Guid("104d3058-abc1-40bf-9eb6-35d9fa0f1226");
				column.Name = @"ForAccountAccount";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("46e3c8e9-74e4-4da6-af3f-06ec44c5dc73");
			if (column != null) {
				column.UId = new Guid("e73b69ba-202a-48c5-b62f-0ab84853eae0");
				column.Name = @"ReverseRelationType";
				column.CreatedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
				column.ModifiedInSchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
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
			return new RelationTypeEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new RelationTypeEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f584bb60-6e92-47b4-a149-4871fad4464d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new RelationTypeEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: RelationTypeEditPageEventsProcess

	/// <exclude/>
	public class RelationTypeEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.RelationTypeEditPageSchemaUserControl
	{

		public RelationTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RelationTypeEditPageEventsProcess";
			SchemaUId = new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f584bb60-6e92-47b4-a149-4871fad4464d");
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

	#region Class: RelationTypeEditPageEventsProcess

	/// <exclude/>
	public class RelationTypeEditPageEventsProcess : RelationTypeEditPageEventsProcess<Terrasoft.WebApp.RelationTypeEditPageSchemaUserControl>
	{

		public RelationTypeEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RelationTypeEditPageSchemaUserControl

	/// <exclude/>
	public partial class RelationTypeEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ReverseRelationTypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ReverseRelationTypeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ForContactContactEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ForContactContactEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ForAccountContactEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ForAccountContactEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ForContactAccountEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ForContactAccountEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ForAccountAccountEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ForAccountAccountEdit", true);
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
			var process = (RelationTypeEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new RelationTypeEditPageEventsProcess(UserConnection);
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
			SchemaName = "RelationTypeEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: RelationTypeEditPageEventsProcessSchema

	/// <exclude/>
	public class RelationTypeEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public RelationTypeEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RelationTypeEditPageEventsProcessSchema(RelationTypeEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RelationTypeEditPageEventsProcess";
			UId = new Guid("4693051b-de4c-4af8-a43a-69d80f2b45c9");
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
			return new RelationTypeEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4693051b-de4c-4af8-a43a-69d80f2b45c9"));
		}

		#endregion

	}

	#endregion

}

