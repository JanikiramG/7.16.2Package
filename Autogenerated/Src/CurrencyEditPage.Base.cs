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

	#region Class: CurrencyEditPageSchema

	/// <exclude/>
	public class CurrencyEditPageSchema : Terrasoft.WebApp.BaseCodeLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _shortNameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ShortNameEdit {
			get {
				return _shortNameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _symbolEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SymbolEdit {
			get {
				return _symbolEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _divisionEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit DivisionEdit {
			get {
				return _divisionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _showCurrecySymbolLeftRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton ShowCurrecySymbolLeftRadioButton {
			get {
				return _showCurrecySymbolLeftRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _showCurrecySymbolRightRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton ShowCurrecySymbolRightRadioButton {
			get {
				return _showCurrecySymbolRightRadioButton;
			}
		}

		#endregion

		#region Constructors: Public

		public CurrencyEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CurrencyEditPageSchema(CurrencyEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("249d97a2-961f-436a-80a0-7a1f9f613b32");
			NameEdit.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateCodeEdit() {
			CodeEdit.Image = new ControlImage {};
			CodeEdit.ColumnUId = new Guid("d3fc7ffa-e13a-4d98-a288-1a2b05dbcc60");
			CodeEdit.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("21ec0011-0897-4317-86fb-39f4147b8a9d");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			RealUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			Name = "CurrencyEditPage";
			ParentSchemaUId = new Guid("8026a6a3-000c-44de-9bd4-4c12c29a803b");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 310;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCurrencyEditPageEventsProcessSchema();
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
			UpdateCodeEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateControlLayout2());
			ControlLayout2.MoveItem(0, NameEdit);
			ControlLayout2.MoveItem(1, CodeEdit);
			ControlLayout2.InsertItem(2, CreateShortNameEdit());
			ControlLayout2.InsertItem(3, CreateSymbolEdit());
			ControlLayout1.InsertItem(1, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateDivisionEdit());
			ControlLayout3.InsertItem(1, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateShowCurrecySymbolLeftRadioButton());
			ControlLayout4.InsertItem(1, CreateShowCurrecySymbolRightRadioButton());
			MainControlLayout.MoveItem(1, DescriptionEdit);
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

		protected virtual EmbeddedProcessSchema CreateCurrencyEditPageEventsProcessSchema() {
			var schema = new CurrencyEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateShortNameEdit() {
			_shortNameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_shortNameEdit.UId = new Guid("8e9a759d-342b-4450-83f0-5f721ca05a76");
			_shortNameEdit.Name = "ShortNameEdit";
			_shortNameEdit.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_shortNameEdit.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_shortNameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_shortNameEdit.Tag = "";
			_shortNameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_shortNameEdit.Image = new ControlImage {};
			_shortNameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_shortNameEdit.DataSource = "DataSource";
			_shortNameEdit.ColumnUId = new Guid("2cf27cf4-0a73-427f-b1dd-9aec7bf1bc0c");
			return _shortNameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSymbolEdit() {
			_symbolEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_symbolEdit.UId = new Guid("961eb563-d6a4-4eb6-8b22-42ddf66e60ac");
			_symbolEdit.Name = "SymbolEdit";
			_symbolEdit.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_symbolEdit.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_symbolEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_symbolEdit.Tag = "";
			_symbolEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_symbolEdit.Image = new ControlImage {};
			_symbolEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_symbolEdit.DataSource = "DataSource";
			_symbolEdit.ColumnUId = new Guid("fafb1cf8-33aa-4142-a4b7-94c6c6a3931b");
			return _symbolEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("3a01cec1-c189-4fc1-84d8-5e9c103db915");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_controlLayout2.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(80);
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(60);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateDivisionEdit() {
			_divisionEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_divisionEdit.UId = new Guid("79b31226-70dc-4864-853e-43d76f6c483b");
			_divisionEdit.Name = "DivisionEdit";
			_divisionEdit.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_divisionEdit.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_divisionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_divisionEdit.Tag = "";
			_divisionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_divisionEdit.Image = new ControlImage {};
			_divisionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_divisionEdit.DataSource = "DataSource";
			_divisionEdit.ColumnUId = new Guid("0ffad9d0-c059-4bee-a958-1effcc4179bc");
			return _divisionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateShowCurrecySymbolLeftRadioButton() {
			_showCurrecySymbolLeftRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_showCurrecySymbolLeftRadioButton.UId = new Guid("8001df66-8c9d-4d57-b1ca-74be7bb3e09b");
			_showCurrecySymbolLeftRadioButton.Name = "ShowCurrecySymbolLeftRadioButton";
			_showCurrecySymbolLeftRadioButton.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_showCurrecySymbolLeftRadioButton.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_showCurrecySymbolLeftRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_showCurrecySymbolLeftRadioButton.Tag = "";
			_showCurrecySymbolLeftRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showCurrecySymbolLeftRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_showCurrecySymbolLeftRadioButton.AlignedByCaption = false;
			_showCurrecySymbolLeftRadioButton.GroupName = "CurrencySymbolPositionGroup";
			return _showCurrecySymbolLeftRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateShowCurrecySymbolRightRadioButton() {
			_showCurrecySymbolRightRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_showCurrecySymbolRightRadioButton.UId = new Guid("f26522a9-3e77-4459-9a6b-8f3774f87bc4");
			_showCurrecySymbolRightRadioButton.Name = "ShowCurrecySymbolRightRadioButton";
			_showCurrecySymbolRightRadioButton.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_showCurrecySymbolRightRadioButton.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_showCurrecySymbolRightRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_showCurrecySymbolRightRadioButton.Tag = "";
			_showCurrecySymbolRightRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showCurrecySymbolRightRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_showCurrecySymbolRightRadioButton.AlignedByCaption = false;
			_showCurrecySymbolRightRadioButton.DataSource = "DataSource";
			_showCurrecySymbolRightRadioButton.ColumnUId = new Guid("50085a3f-22bd-48b3-a6eb-506f20581920");
			_showCurrecySymbolRightRadioButton.GroupName = "CurrencySymbolPositionGroup";
			return _showCurrecySymbolRightRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("6c11b05b-9437-411f-8a05-cd6585b52be1");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_controlLayout4.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout4.FitHeightByContent = true;
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("335ad62f-2869-4d30-9b2c-10e6b2523ae9");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_controlLayout3.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(80);
			_controlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(40);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.DefaultMargins = "0 0 7 0";
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("630c113b-e8db-4b31-92b5-86118bb16fec");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_controlLayout1.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(80);
			_controlLayout1.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			DataSource.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("69c93bcb-eac2-4842-bcf8-9f2052fdf56e");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("1a6be987-e37c-4bde-8ff6-d1c65e2cce3f");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("1b654753-35e0-4dd0-a52f-8e686d4638fa");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("0cb1c208-da37-4e26-9150-92bafb78e528");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("01ee230a-65b1-4feb-9970-01405bfaa4bf");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("249d97a2-961f-436a-80a0-7a1f9f613b32");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("21ec0011-0897-4317-86fb-39f4147b8a9d");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("13aad544-ec30-4e76-a373-f0cff3202e24");
			if (column != null) {
				column.UId = new Guid("d3fc7ffa-e13a-4d98-a288-1a2b05dbcc60");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("81913c21-afcb-4a38-9164-af361a45d80f");
			if (column != null) {
				column.UId = new Guid("2cf27cf4-0a73-427f-b1dd-9aec7bf1bc0c");
				column.Name = @"ShortName";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1468ee69-0ffb-496f-9d4d-e91c1656d474");
			if (column != null) {
				column.UId = new Guid("fafb1cf8-33aa-4142-a4b7-94c6c6a3931b");
				column.Name = @"Symbol";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("aa202f22-3aa0-441e-b192-5e03e7e8090d");
			if (column != null) {
				column.UId = new Guid("7b53559b-b3c0-4de2-9c40-34c5a5ff7749");
				column.Name = @"RecalcDirection";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e8667452-cecb-4735-acf7-428ea8d62e50");
			if (column != null) {
				column.UId = new Guid("0ffad9d0-c059-4bee-a958-1effcc4179bc");
				column.Name = @"Division";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("df51504c-ae63-42e8-964d-8a30ceff0a7c");
			if (column != null) {
				column.UId = new Guid("50085a3f-22bd-48b3-a6eb-506f20581920");
				column.Name = @"CurrecySymbolPosition";
				column.CreatedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
				column.ModifiedInSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
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
			return new CurrencyEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CurrencyEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CurrencyEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyEditPageEventsProcess

	/// <exclude/>
	public class CurrencyEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CurrencyEditPageSchemaUserControl
	{

		public CurrencyEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CurrencyEditPageEventsProcess";
			SchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7");
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

		private ProcessFlowElement _currencyEditPagePageLoadCompleteEventSubProcess;
		public ProcessFlowElement CurrencyEditPagePageLoadCompleteEventSubProcess {
			get {
				return _currencyEditPagePageLoadCompleteEventSubProcess ?? (_currencyEditPagePageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CurrencyEditPagePageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("0a4ad7cd-25d9-4720-b06c-9843d2387b54"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyEditPagePageLoadCompleteStartMessage;
		public ProcessFlowElement CurrencyEditPagePageLoadCompleteStartMessage {
			get {
				return _currencyEditPagePageLoadCompleteStartMessage ?? (_currencyEditPagePageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyEditPagePageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("c6147c30-b7a3-4770-9e4a-b3292f150897"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _currencyEditPagePageLoadCompleteScriptTask;
		public ProcessScriptTask CurrencyEditPagePageLoadCompleteScriptTask {
			get {
				return _currencyEditPagePageLoadCompleteScriptTask ?? (_currencyEditPagePageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrencyEditPagePageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("3d030dd9-902a-44a3-abf5-f8060fa791ef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrencyEditPagePageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _currencyEditPagePageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent CurrencyEditPagePageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _currencyEditPagePageLoadCompleteIntermediateThrowMessageEvent ?? (_currencyEditPagePageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "CurrencyEditPagePageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("0a769330-4114-4049-aaa9-87d2e314fb9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[CurrencyEditPagePageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyEditPagePageLoadCompleteEventSubProcess };
			FlowElements[CurrencyEditPagePageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyEditPagePageLoadCompleteStartMessage };
			FlowElements[CurrencyEditPagePageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyEditPagePageLoadCompleteScriptTask };
			FlowElements[CurrencyEditPagePageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyEditPagePageLoadCompleteIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "CurrencyEditPagePageLoadCompleteEventSubProcess":
						break;
					case "CurrencyEditPagePageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("CurrencyEditPagePageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "CurrencyEditPagePageLoadCompleteScriptTask":
						break;
					case "CurrencyEditPagePageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("CurrencyEditPagePageLoadCompleteScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CurrencyEditPagePageLoadCompleteStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "CurrencyEditPagePageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencyEditPagePageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyEditPagePageLoadCompleteStartMessage";
					result = CurrencyEditPagePageLoadCompleteStartMessage.Execute(context);
					break;
				case "CurrencyEditPagePageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyEditPagePageLoadCompleteScriptTask";
					result = CurrencyEditPagePageLoadCompleteScriptTask.Execute(context, CurrencyEditPagePageLoadCompleteScriptTaskExecute);
					break;
				case "CurrencyEditPagePageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = CurrencyEditPagePageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool CurrencyEditPagePageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			// Specify max and min value for NumberEdit control
			Page.DivisionEdit.MaxValue = 100;
			Page.DivisionEdit.MinValue = 1;
			Page.ShowCurrecySymbolLeftRadioButton.Checked = Page.DataSource.ActiveRow.GetTypedColumnValue<int>("CurrecySymbolPosition") == 0;
			Page.ShowCurrecySymbolRightRadioButton.Checked = !Page.ShowCurrecySymbolLeftRadioButton.Checked;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("CurrencyEditPagePageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("CurrencyEditPagePageLoadCompleteStartMessage");
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

	#region Class: CurrencyEditPageEventsProcess

	/// <exclude/>
	public class CurrencyEditPageEventsProcess : CurrencyEditPageEventsProcess<Terrasoft.WebApp.CurrencyEditPageSchemaUserControl>
	{

		public CurrencyEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CurrencyEditPageSchemaUserControl

	/// <exclude/>
	public partial class CurrencyEditPageSchemaUserControl : Terrasoft.WebApp.BaseCodeLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ShortNameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ShortNameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SymbolEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SymbolEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit DivisionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("DivisionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton ShowCurrecySymbolLeftRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("ShowCurrecySymbolLeftRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton ShowCurrecySymbolRightRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("ShowCurrecySymbolRightRadioButton", true);
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
			var process = (CurrencyEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CurrencyEditPageEventsProcess(UserConnection);
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
			SchemaName = "CurrencyEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyEditPageEventsProcessSchema

	/// <exclude/>
	public class CurrencyEditPageEventsProcessSchema : Terrasoft.WebApp.BaseCodeLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CurrencyEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CurrencyEditPageEventsProcessSchema(CurrencyEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CurrencyEditPageEventsProcess";
			UId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1181 = CreateLaneSet1181LaneSet();
			LaneSets.Add(schemaLaneSet1181);
			ProcessSchemaLane schemaLane3976 = CreateLane3976Lane();
			schemaLaneSet1181.Lanes.Add(schemaLane3976);
			ProcessSchemaEventSubProcess currencyeditpagepageloadcompleteeventsubprocess = CreateCurrencyEditPagePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(currencyeditpagepageloadcompleteeventsubprocess);
			ProcessSchemaStartMessageEvent currencyeditpagepageloadcompletestartmessage = CreateCurrencyEditPagePageLoadCompleteStartMessageStartMessageEvent();
			currencyeditpagepageloadcompleteeventsubprocess.FlowElements.Add(currencyeditpagepageloadcompletestartmessage);
			ProcessSchemaScriptTask currencyeditpagepageloadcompletescripttask = CreateCurrencyEditPagePageLoadCompleteScriptTaskScriptTask();
			currencyeditpagepageloadcompleteeventsubprocess.FlowElements.Add(currencyeditpagepageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent currencyeditpagepageloadcompleteintermediatethrowmessageevent = CreateCurrencyEditPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			currencyeditpagepageloadcompleteeventsubprocess.FlowElements.Add(currencyeditpagepageloadcompleteintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow22579SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22580SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22579SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22579",
				UId = new Guid("48a58f99-1d13-4e4a-a317-42787f4f357c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				CurveCenterPosition = new Point(195, 83),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0a769330-4114-4049-aaa9-87d2e314fb9e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d030dd9-902a-44a3-abf5-f8060fa791ef"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22580SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22580",
				UId = new Guid("4c6e5cc1-bea9-4dfe-a04a-9ab8692fa3d0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				CurveCenterPosition = new Point(195, 83),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6147c30-b7a3-4770-9e4a-b3292f150897"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0a769330-4114-4049-aaa9-87d2e314fb9e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1181LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1181 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e2c79afe-3c00-428e-823b-146b1f1c5ba4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				Name = @"LaneSet1181",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(794, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1181;
		}

		protected virtual ProcessSchemaLane CreateLane3976Lane() {
			ProcessSchemaLane schemaLane3976 = new ProcessSchemaLane(this) {
				UId = new Guid("351ba74e-8ca9-46d8-bac9-1acfda3a46c5"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e2c79afe-3c00-428e-823b-146b1f1c5ba4"),
				CreatedInOwnerSchemaUId = new Guid("6d367ac9-1d34-43f6-a90b-37d3c6c6c9c7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				Name = @"Lane3976",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(765, 177),
				UseBackgroundMode = false
			};
			return schemaLane3976;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCurrencyEditPagePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCurrencyEditPagePageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0a4ad7cd-25d9-4720-b06c-9843d2387b54"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("351ba74e-8ca9-46d8-bac9-1acfda3a46c5"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				Name = @"CurrencyEditPagePageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(319, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCurrencyEditPagePageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrencyEditPagePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c6147c30-b7a3-4770-9e4a-b3292f150897"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a4ad7cd-25d9-4720-b06c-9843d2387b54"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				Name = @"CurrencyEditPagePageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCurrencyEditPagePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3d030dd9-902a-44a3-abf5-f8060fa791ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a4ad7cd-25d9-4720-b06c-9843d2387b54"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				Name = @"CurrencyEditPagePageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(217, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,142,65,79,194,64,16,133,239,38,254,135,129,19,94,150,122,198,154,96,33,92,212,144,150,120,95,118,167,116,98,119,135,12,179,133,254,123,43,4,19,19,57,120,126,223,123,239,155,78,161,218,163,163,186,135,96,79,96,163,135,64,17,58,219,38,132,154,5,222,83,216,162,44,61,41,56,142,42,220,222,223,173,237,14,205,130,58,58,16,199,239,200,188,217,211,199,185,146,195,99,150,205,254,68,40,254,32,87,160,106,248,88,36,17,116,125,213,135,45,183,175,88,107,105,61,241,75,82,229,104,138,6,221,39,250,161,115,25,180,106,43,78,226,208,204,157,82,135,37,31,205,10,117,211,239,209,23,220,166,112,249,120,162,168,207,147,241,175,233,53,31,72,7,153,241,3,228,57,100,55,21,74,218,53,55,28,70,255,146,30,30,4,53,73,4,149,132,179,47,79,0,198,15,106,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateCurrencyEditPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0a769330-4114-4049-aaa9-87d2e314fb9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a4ad7cd-25d9-4720-b06c-9843d2387b54"),
				CreatedInOwnerSchemaUId = new Guid("70385971-9645-442e-a042-de6f8d36ba35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"),
				Name = @"CurrencyEditPagePageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 56),
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
			return new CurrencyEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09b3e4cb-e077-4420-88af-efe6c5a43fbb"));
		}

		#endregion

	}

	#endregion

}

