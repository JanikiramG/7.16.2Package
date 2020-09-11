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
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;
	using TSWebControls = Terrasoft.UI.WebControls;

	#region Class: ProductEditPageSchema

	/// <exclude/>
	public class ProductEditPageSchema : Terrasoft.WebApp.BaseModuleEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ImageBox _productRecourceImageEdit;
		public Terrasoft.UI.WebControls.Controls.ImageBox ProductRecourceImageEdit {
			get {
				return _productRecourceImageEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _uRLEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit URLEdit {
			get {
				return _uRLEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _typeEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeEdit {
			get {
				return _typeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _codeEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CodeEdit {
			get {
				return _codeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _ownerEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit OwnerEdit {
			get {
				return _ownerEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isUsedEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox isUsedEdit {
			get {
				return _isUsedEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isServiceEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsServiceEdit {
			get {
				return _isServiceEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _unitEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit UnitEdit {
			get {
				return _unitEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MultiCurrencyEdit _priceEdit;
		public Terrasoft.UI.WebControls.Controls.MultiCurrencyEdit PriceEdit {
			get {
				return _priceEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _taxEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TaxEdit {
			get {
				return _taxEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _descriptionEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return _descriptionEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ProductEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProductEditPageSchema(ProductEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateProcessButton() {
			ProcessButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ProcessButton.Image = new ControlImage {};
			ProcessButton.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdatePrintReportButton() {
			PrintReportButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintReportButton.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.Hidden = true;
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateCustomControlsLeft() {
			CustomControlsLeft.FitHeightByContent = true;
			CustomControlsLeft.Image = new ControlImage {};
			CustomControlsLeft.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateCustomControlsRight() {
			CustomControlsRight.FitHeightByContent = true;
			CustomControlsRight.Image = new ControlImage {};
			CustomControlsRight.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateDataControlLayout() {
			DataControlLayout.Image = new ControlImage {};
			DataControlLayout.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateDataTab() {
			DataTab.Image = new ControlImage {};
			DataTab.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateDataTabPanel() {
			DataTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			DataTabPanel.AjaxEvents.TabChange.ShowLoadMask = true;
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateCancelButton() {
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateButtomButtonLayout() {
			ButtomButtonLayout.Image = new ControlImage {};
			ButtomButtonLayout.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateRightControlLayout() {
			RightControlLayout.Image = new ControlImage {};
			RightControlLayout.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			RealUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			Name = "ProductEditPage";
			ParentSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProductEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateMainControlLayout();
			UpdateRightControlLayout();
			UpdateButtomButtonLayout();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDataTabPanel();
			UpdateDataTab();
			UpdateDataControlLayout();
			UpdateCustomControls();
			UpdateCustomControlsRight();
			UpdateCustomControlsLeft();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdateDesignerModeButton();
			UpdatePrintReportButton();
			UpdateActionButton();
			UpdateProcessButton();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, RightControlLayout);
			RightControlLayout.MoveItem(0, DataTabPanel);
			DataTabPanel.MoveItem(0, DataTab);
			DataTab.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ProcessButton);
			ButtonsControlLayout.MoveItem(1, PrintReportSpacer);
			ButtonsControlLayout.MoveItem(2, ActionButton);
			ButtonsControlLayout.MoveItem(3, PrintReportButton);
			ButtonsControlLayout.MoveItem(4, DesignerModeButton);
			ButtonsControlLayout.MoveItem(5, ContextHelpButton);
			DataTab.MoveItem(1, DataControlLayout);
			DataControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateNameEdit());
			ControlLayout1.InsertItem(1, CreateProductRecourceImageEdit());
			DataControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateURLEdit());
			DataControlLayout.MoveItem(2, CustomControls);
			CustomControls.MoveItem(0, CustomControlsLeft);
			CustomControlsLeft.InsertItem(0, CreateTypeEdit());
			CustomControlsLeft.InsertItem(1, CreateCodeEdit());
			CustomControlsLeft.InsertItem(2, CreateOwnerEdit());
			CustomControlsLeft.InsertItem(3, CreateisUsedEdit());
			CustomControls.MoveItem(1, CustomControlsRight);
			CustomControlsRight.InsertItem(0, CreateIsServiceEdit());
			CustomControlsRight.InsertItem(1, CreateUnitEdit());
			CustomControlsRight.InsertItem(2, CreatePriceEdit());
			CustomControlsRight.InsertItem(3, CreateTaxEdit());
			DataControlLayout.InsertItem(3, CreateDescriptionEdit());
			RightControlLayout.MoveItem(1, ButtomButtonLayout);
			ButtomButtonLayout.MoveItem(0, ButtomSpacer);
			ButtomButtonLayout.MoveItem(1, OKButton);
			ButtomButtonLayout.MoveItem(2, CancelButton);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateProductEditPageEventsProcessSchema() {
			var schema = new ProductEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("5c6ed9e8-e594-4fd2-9488-5245b8a2dc97");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_nameEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("a0c44521-cd45-4b80-9036-aa94a05453a4");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ImageBox CreateProductRecourceImageEdit() {
			_productRecourceImageEdit = new Terrasoft.UI.WebControls.Controls.ImageBox();
			_productRecourceImageEdit.UId = new Guid("7769c7f5-6d9a-4a4c-8396-7847e678fb95");
			_productRecourceImageEdit.Name = "ProductRecourceImageEdit";
			_productRecourceImageEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_productRecourceImageEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_productRecourceImageEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_productRecourceImageEdit.Tag = "";
			_productRecourceImageEdit.Image = new ControlImage {};
			_productRecourceImageEdit.Center = true;
			_productRecourceImageEdit.Height = System.Web.UI.WebControls.Unit.Pixel(20);
			_productRecourceImageEdit.Width = System.Web.UI.WebControls.Unit.Pixel(20);
			_productRecourceImageEdit.Edges = "";
			_productRecourceImageEdit.Margins = "0 5";
			_productRecourceImageEdit.Hidden = true;
			return _productRecourceImageEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("c5741e26-7610-4502-8969-562f0f88c495");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_controlLayout1.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateURLEdit() {
			_uRLEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_uRLEdit.UId = new Guid("ddf6ce28-fb06-4479-a166-9c83f29a97f5");
			_uRLEdit.Name = "URLEdit";
			_uRLEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_uRLEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_uRLEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_uRLEdit.Tag = "";
			_uRLEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_uRLEdit.Image = new ControlImage {};
			_uRLEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_uRLEdit.DataSource = "DataSource";
			_uRLEdit.ColumnUId = new Guid("2fcae901-0023-4b7a-8734-eb5b1f373a8a");
			return _uRLEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("8ef2364f-4cff-4b51-a479-8b68c0ba4a3f");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_controlLayout2.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateTypeEdit() {
			_typeEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_typeEdit.UId = new Guid("3fac3af5-ec46-47ed-a8c4-016251032c22");
			_typeEdit.Name = "TypeEdit";
			_typeEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_typeEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_typeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_typeEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_typeEdit.Tag = "";
			_typeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_typeEdit.Image = new ControlImage {};
			_typeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_typeEdit.DataSource = "DataSource";
			_typeEdit.ColumnUId = new Guid("ee337d7c-25bc-44e4-9d50-f5fb84496508");
			return _typeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCodeEdit() {
			_codeEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_codeEdit.UId = new Guid("10fb5e06-1d83-4aac-9b33-9bd30934481a");
			_codeEdit.Name = "CodeEdit";
			_codeEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_codeEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_codeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_codeEdit.Tag = "";
			_codeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_codeEdit.Image = new ControlImage {};
			_codeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_codeEdit.DataSource = "DataSource";
			_codeEdit.ColumnUId = new Guid("78514158-664a-4a33-9f1c-0fc5bc8ad7fd");
			return _codeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateOwnerEdit() {
			_ownerEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_ownerEdit.UId = new Guid("d3f82efa-3f92-44f1-bf1a-23989ec639b9");
			_ownerEdit.Name = "OwnerEdit";
			_ownerEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_ownerEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_ownerEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_ownerEdit.Tag = "";
			_ownerEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_ownerEdit.Image = new ControlImage {};
			_ownerEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_ownerEdit.DataSource = "DataSource";
			_ownerEdit.ColumnUId = new Guid("187d101d-a6fb-4955-b73e-a08f71ed1227");
			return _ownerEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateisUsedEdit() {
			_isUsedEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isUsedEdit.UId = new Guid("9ce0a50d-9fc7-490a-a525-5fb5e9c1185d");
			_isUsedEdit.Name = "isUsedEdit";
			_isUsedEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_isUsedEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_isUsedEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_isUsedEdit.Tag = "";
			_isUsedEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isUsedEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isUsedEdit.AlignedByCaption = false;
			_isUsedEdit.DataSource = "DataSource";
			_isUsedEdit.ColumnUId = new Guid("9d496b95-a64e-4bea-9a83-b4a3060eef2b");
			return _isUsedEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsServiceEdit() {
			_isServiceEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isServiceEdit.UId = new Guid("ff1a88f6-4473-4b86-81c5-738e6fd6a7e6");
			_isServiceEdit.Name = "IsServiceEdit";
			_isServiceEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_isServiceEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_isServiceEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_isServiceEdit.Tag = "";
			_isServiceEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isServiceEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isServiceEdit.AlignedByCaption = false;
			_isServiceEdit.DataSource = "DataSource";
			_isServiceEdit.ColumnUId = new Guid("76f06a66-fab8-406e-a9c0-fa912403a770");
			return _isServiceEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateUnitEdit() {
			_unitEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_unitEdit.UId = new Guid("4652bb37-441f-42e1-831f-ce3c83937294");
			_unitEdit.Name = "UnitEdit";
			_unitEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_unitEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_unitEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_unitEdit.Tag = "";
			_unitEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_unitEdit.Image = new ControlImage {};
			_unitEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_unitEdit.DataSource = "DataSource";
			_unitEdit.ColumnUId = new Guid("d5f30faf-5d88-4a76-be34-2a1c0583b0a4");
			return _unitEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MultiCurrencyEdit CreatePriceEdit() {
			_priceEdit = new Terrasoft.UI.WebControls.Controls.MultiCurrencyEdit();
			_priceEdit.UId = new Guid("75988dfc-2762-4649-8166-5deca2a430bb");
			_priceEdit.Name = "PriceEdit";
			_priceEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_priceEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_priceEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_priceEdit.Tag = "";
			_priceEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_priceEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_priceEdit.DataSource = "DataSource";
			_priceEdit.CurrentCurrencyUIdColumnUId = new Guid("090ee5d3-af75-41bd-ae86-c423dec53db6");
			_priceEdit.CurrentCurrencyValueColumnUId = new Guid("f897c6ba-aab3-48aa-ade8-2d3740abbb56");
			_priceEdit.CurrentCurrencyEditEnabled = true;
			_priceEdit.CurrentCurrencyRateEditEnabled = true;
			_priceEdit.CurrentCurrencyValueEditEnabled = true;
			_priceEdit.BaseCurrencyValueEditEnabled = true;
			return _priceEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateTaxEdit() {
			_taxEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_taxEdit.UId = new Guid("daace2d4-52cf-4181-9d82-98df60cebd73");
			_taxEdit.Name = "TaxEdit";
			_taxEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_taxEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_taxEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_taxEdit.Tag = "";
			_taxEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_taxEdit.Image = new ControlImage {};
			_taxEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_taxEdit.DataSource = "DataSource";
			_taxEdit.ColumnUId = new Guid("7961e5a9-157f-4376-a664-d350935138cc");
			return _taxEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateDescriptionEdit() {
			_descriptionEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_descriptionEdit.UId = new Guid("5e437630-daaf-404a-8c01-e9eb895147de");
			_descriptionEdit.Name = "DescriptionEdit";
			_descriptionEdit.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_descriptionEdit.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			_descriptionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_descriptionEdit.Tag = "";
			_descriptionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_descriptionEdit.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_descriptionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_descriptionEdit.DataSource = "DataSource";
			_descriptionEdit.ColumnUId = new Guid("141b2ef8-6ff5-4e16-8a2c-314ffafab449");
			return _descriptionEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed");
			DataSource.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae5ef7d5-1044-477f-affb-83bce9e65bbd");
			if (column != null) {
				column.UId = new Guid("1b0b3477-a724-4ecd-81c4-b0aa508425da");
				column.Name = @"ProductSource";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ab19483e-bd98-4b76-9565-56f7e309758b");
			if (column != null) {
				column.UId = new Guid("f897c6ba-aab3-48aa-ade8-2d3740abbb56");
				column.Name = @"Price";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("46e5c1bf-1a37-4828-bb11-1e5989ac3aff");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e3040d2d-93ff-4528-a4b7-42603e08bdcf");
			if (column != null) {
				column.UId = new Guid("a0c44521-cd45-4b80-9036-aa94a05453a4");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("71fbdca1-1cc3-42b4-a0a1-1549c0489f53");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("5ea48386-a13d-4593-9a11-928db7ff243f");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("d6ac7f95-6580-4ae5-9a2c-4ff2a4b6fdbb");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("ec6e027e-ccfe-4cad-917f-b138af900f0e");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2e1f4643-a44a-415e-8c4c-79283dc3d1d9");
			if (column != null) {
				column.UId = new Guid("78514158-664a-4a33-9f1c-0fc5bc8ad7fd");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e485abc9-4cc0-48ba-a8e6-76a6dd2ea222");
			if (column != null) {
				column.UId = new Guid("d5f30faf-5d88-4a76-be34-2a1c0583b0a4");
				column.Name = @"Unit";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e241007b-18ad-4411-a6fb-caf56fdaa941");
			if (column != null) {
				column.UId = new Guid("090ee5d3-af75-41bd-ae86-c423dec53db6");
				column.Name = @"Currency";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("51a20224-e62d-4198-b3e5-354d46e68af8");
			if (column != null) {
				column.UId = new Guid("7961e5a9-157f-4376-a664-d350935138cc");
				column.Name = @"Tax";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6cd88fbf-2355-45f8-8c8a-8e6308a77b96");
			if (column != null) {
				column.UId = new Guid("2fcae901-0023-4b7a-8734-eb5b1f373a8a");
				column.Name = @"URL";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ac574603-a4db-410c-877d-e383c0a6c51a");
			if (column != null) {
				column.UId = new Guid("ee337d7c-25bc-44e4-9d50-f5fb84496508");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b4687e9c-060d-4f9b-8367-b8ed66af0ada");
			if (column != null) {
				column.UId = new Guid("9d496b95-a64e-4bea-9a83-b4a3060eef2b");
				column.Name = @"Active";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("c4366881-6ecc-43fc-a859-4b1e4a859541");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b2030ccd-1270-4bed-ac8b-4ebf4cfda0d1");
			if (column != null) {
				column.UId = new Guid("187d101d-a6fb-4955-b73e-a08f71ed1227");
				column.Name = @"Owner";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("75b2a101-2a27-4911-a5c0-d4f7c724914d");
			if (column != null) {
				column.UId = new Guid("141b2ef8-6ff5-4e16-8a2c-314ffafab449");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4c9ed783-148c-41eb-92dd-5975dcfbdcd1");
			if (column != null) {
				column.UId = new Guid("933bbcca-425b-4961-8776-0d69e4102e46");
				column.Name = @"Notes";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ac574603-a4db-410c-877d-e383c0a6c51a.b38bd826-cb96-46fc-8798-992420f5ef87");
			if (column != null) {
				column.UId = new Guid("76f06a66-fab8-406e-a9c0-fa912403a770");
				column.Name = @"Type_IsService";
				column.CreatedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.ModifiedInSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			column.Caption.SetResourceInfo("6b6c2608cc514326a78f50c181d3f861", "Controls.DataSource.DefStructure.Columns.Type_IsService.Caption");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ProductEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ProductEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProductEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProductEditPageEventsProcess

	/// <exclude/>
	public class ProductEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseModuleEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProductEditPageSchemaUserControl
	{

		public ProductEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductEditPageEventsProcess";
			SchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861");
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

		private ProcessFlowElement _pageLoadCompleteEventSubProcess;
		public ProcessFlowElement PageLoadCompleteEventSubProcess {
			get {
				return _pageLoadCompleteEventSubProcess ?? (_pageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("84c5b22a-0bdd-4099-a015-c6be7307fcf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteChildStartMessage;
		public ProcessFlowElement PageLoadCompleteChildStartMessage {
			get {
				return _pageLoadCompleteChildStartMessage ?? (_pageLoadCompleteChildStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteChildStartMessage",
					SchemaElementUId = new Guid("6e1765a4-2fce-4f78-bf6c-3e0812756206"),
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
					SchemaElementUId = new Guid("a2a37c32-768c-4a2c-b0c2-e8fc3890dbcc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteChildScriptTask;
		public ProcessScriptTask PageLoadCompleteChildScriptTask {
			get {
				return _pageLoadCompleteChildScriptTask ?? (_pageLoadCompleteChildScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteChildScriptTask",
					SchemaElementUId = new Guid("0a7a6407-d877-4c80-b50d-4ae9971b14fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteChildScriptTaskExecute,
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
					SchemaElementUId = new Guid("2dc8c0ab-0af1-4ba3-a297-e3cc4a46e604"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _typeEditChangeMessage;
		public ProcessFlowElement TypeEditChangeMessage {
			get {
				return _typeEditChangeMessage ?? (_typeEditChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TypeEditChangeMessage",
					SchemaElementUId = new Guid("e13b12d0-9ee6-460a-beb3-162ab3e9fbee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _typeEditChangeScriptTask;
		public ProcessScriptTask TypeEditChangeScriptTask {
			get {
				return _typeEditChangeScriptTask ?? (_typeEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TypeEditChangeScriptTask",
					SchemaElementUId = new Guid("e1b88dd7-fdad-49dd-b353-47f042ddee89"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TypeEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("dae5c222-256b-4dd6-8527-040e387956b6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickMessage;
		public ProcessFlowElement OKButtonClickMessage {
			get {
				return _oKButtonClickMessage ?? (_oKButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClickMessage",
					SchemaElementUId = new Guid("c9b4d353-c777-493f-b9f3-e1949c305fec"),
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
					SchemaElementUId = new Guid("9a805cf7-7619-429d-beb9-6acf236b3daf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _oKButtonClickScript;
		public ProcessScriptTask OKButtonClickScript {
			get {
				return _oKButtonClickScript ?? (_oKButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OKButtonClickScript",
					SchemaElementUId = new Guid("bb7878df-fb63-4379-b661-53e4cb012514"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OKButtonClickScriptExecute,
				});
			}
		}

		private ProcessFlowElement _treeGridDblClickMessage;
		public ProcessFlowElement TreeGridDblClickMessage {
			get {
				return _treeGridDblClickMessage ?? (_treeGridDblClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridDblClickMessage",
					SchemaElementUId = new Guid("a4c23a22-4393-464d-a3bf-0c55d0ca0451"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess };
			FlowElements[PageLoadCompleteChildStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildStartMessage };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteChildScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[TypeEditChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TypeEditChangeMessage };
			FlowElements[TypeEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { TypeEditChangeScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[OKButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[OKButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickScript };
			FlowElements[TreeGridDblClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PageLoadCompleteEventSubProcess":
						break;
					case "PageLoadCompleteChildStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScriptTask");
						break;
					case "PageLoadCompleteChildScriptTask":
						break;
					case "EventSubProcess5":
						break;
					case "TypeEditChangeMessage":
						e.Context.QueueTasks.Enqueue("TypeEditChangeScriptTask");
						break;
					case "TypeEditChangeScriptTask":
						break;
					case "EventSubProcess6":
						break;
					case "OKButtonClickMessage":
						e.Context.QueueTasks.Enqueue("OKButtonClickScript");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "OKButtonClickScript":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "TreeGridDblClickMessage":
						e.Context.QueueTasks.Enqueue("OKButtonClickScript");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadCompleteChildStartMessage");
			ActivatedEventElements.Add("TypeEditChangeMessage");
			ActivatedEventElements.Add("OKButtonClickMessage");
			ActivatedEventElements.Add("TreeGridDblClickMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChildStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChildStartMessage";
					result = PageLoadCompleteChildStartMessage.Execute(context);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteChildScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChildScriptTask";
					result = PageLoadCompleteChildScriptTask.Execute(context, PageLoadCompleteChildScriptTaskExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "TypeEditChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TypeEditChangeMessage";
					result = TypeEditChangeMessage.Execute(context);
					break;
				case "TypeEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "TypeEditChangeScriptTask";
					result = TypeEditChangeScriptTask.Execute(context, TypeEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickMessage";
					result = OKButtonClickMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "OKButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickScript";
					result = OKButtonClickScript.Execute(context, OKButtonClickScriptExecute);
					break;
				case "TreeGridDblClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClickMessage";
					result = TreeGridDblClickMessage.Execute(context);
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

		public virtual bool PageLoadCompleteChildScriptTaskExecute(ProcessExecutingContext context) {
			var activeRow = Page.DataSource.ActiveRow;
			if (IsNew) {
				var primaryCurrencyId = new Guid(SysSettings.GetValue(UserConnection, "PrimaryCurrency").ToString());
				activeRow.SetColumnValue("CurrencyId", primaryCurrencyId);
				activeRow.LoadLookupDisplayValues("Currency");
			}
			InitImage();
			return true;
		}

		public virtual bool TypeEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			Entity activeRow = Page.DataSource.ActiveRow;
			var productTypeID = Page.TypeEdit.Value;
			var productTypeESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ProductType");
			var idColumn = productTypeESQ.AddColumn(productTypeESQ.RootSchema.GetPrimaryColumnName());
			var nameColumn = productTypeESQ.AddColumn("Name");      
			var isServiceColumn = productTypeESQ.AddColumn("IsService");
			productTypeESQ.IsDistinct = true; 
			var productTypeEntity = productTypeESQ.GetEntity(UserConnection, productTypeID);
			if (productTypeEntity != null) {
				bool isService = productTypeEntity.GetTypedColumnValue<bool>("IsService");
				Page.IsServiceEdit.SuspendAjaxEvents();
				Page.IsServiceEdit.Value = isService;
				Page.IsServiceEdit.ResumeAjaxEvents();
			}	
			return true;
		}

		public virtual bool OKButtonClickScriptExecute(ProcessExecutingContext context) {
			if(Page.DataSource.ActiveRowModified) {
				var	primaryValue = new Guid("5FACB8B4-ED6A-41BB-B224-659C2BF1EB8A");
				var converters = new JsonConverter[] {new GuidJsonConverter()};
				string id = Json.Serialize(Page.DataSource.ActiveRow.PrimaryColumnValue, converters[0]);
				Page.ScriptManager.AddScript(Page.DataSource.ClientID + 
					".onActiveRowColumnValuesChangedResponse(" 
					 + id + ",{\"ProductSourceId\" : {columnValue: "
					 + Json.Serialize(primaryValue, converters[0]) + "}});");
			}
			return true;
		}

		public virtual void InitImage() {
			var primaryValue = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("ProductSourceId");
			if(primaryValue == Guid.Empty) {
				primaryValue = new Guid("5FACB8B4-ED6A-41BB-B224-659C2BF1EB8A");
				Page.DataSource.ActiveRow.SetColumnValue("ProductSourceId", primaryValue);
			}
			
			var productSourceESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ProductSource");
			var idColumn = productSourceESQ.AddColumn(productSourceESQ.RootSchema.GetPrimaryColumnName());
			var nameColumn = productSourceESQ.AddColumn("Name");
			var imageColumn = productSourceESQ.AddColumn("Image");
			productSourceESQ.IsDistinct = true; 
			
			var productSource = productSourceESQ.GetEntity(UserConnection, primaryValue);
			if (productSource != null)
			{
			  	var controlImage = new ControlImage();	
				controlImage.Source = ControlImageSource.EntityColumn;
				controlImage.SchemaUId = productSource.Schema.UId;
				controlImage.EntityPrimaryColumnValue = primaryValue;
				controlImage.EntitySchemaColumnUId = productSource.Schema.Columns.GetByName("Image").UId;
				controlImage.UsePrimaryImageColumn = false;
				controlImage.UsePrimaryImageColumn = true;
				controlImage.UsePrimaryImageColumn = false;	
				controlImage.ResetCache();
				Page.ProductRecourceImageEdit.Image = controlImage;	
				Page.ProductRecourceImageEdit.Hidden = false;
			} else {
				Page.ProductRecourceImageEdit.Hidden = true;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChildStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChildStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "TypeEditChange":
							if (ActivatedEventElements.Contains("TypeEditChangeMessage")) {
							context.QueueTasks.Enqueue("TypeEditChangeMessage");
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClickMessage")) {
							context.QueueTasks.Enqueue("OKButtonClickMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "TreeGridDblClick":
							if (ActivatedEventElements.Contains("TreeGridDblClickMessage")) {
							context.QueueTasks.Enqueue("TreeGridDblClickMessage");
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

	#region Class: ProductEditPageEventsProcess

	/// <exclude/>
	public class ProductEditPageEventsProcess : ProductEditPageEventsProcess<Terrasoft.WebApp.ProductEditPageSchemaUserControl>
	{

		public ProductEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductEditPageSchemaUserControl

	/// <exclude/>
	public partial class ProductEditPageSchemaUserControl : Terrasoft.WebApp.BaseModuleEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ImageBox ProductRecourceImageEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ImageBox)PageContainer.FindPageControl("ProductRecourceImageEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit URLEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("URLEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("TypeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CodeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CodeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit OwnerEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("OwnerEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox isUsedEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("isUsedEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsServiceEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsServiceEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit UnitEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("UnitEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MultiCurrencyEdit PriceEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MultiCurrencyEdit)PageContainer.FindPageControl("PriceEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TaxEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("TaxEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit DescriptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("DescriptionEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			TypeEdit.AjaxEvents.Change.Event += TypeEditChange;
			DataSource.AjaxEvents.BeforeInsert.Event += DataSourceBeforeInsert;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			TypeEdit.AjaxEvents.Change.Event -= TypeEditChange;
			DataSource.AjaxEvents.BeforeInsert.Event -= DataSourceBeforeInsert;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ProductEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProductEditPageEventsProcess(UserConnection);
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

		public virtual void TypeEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("TypeEditChange");
		}

		public virtual void DataSourceBeforeInsert(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceBeforeInsert");
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
			SchemaName = "ProductEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ProductEditPageEventsProcessSchema

	/// <exclude/>
	public class ProductEditPageEventsProcessSchema : Terrasoft.WebApp.BaseModuleEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ProductEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProductEditPageEventsProcessSchema(ProductEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProductEditPageEventsProcess";
			UId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateIsSchemaBlockedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6322e39c-e443-400d-a070-e33ab9f7e541"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsSchemaBlocked",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess = CreatePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaStartMessageEvent pageloadcompletechildstartmessage = CreatePageLoadCompleteChildStartMessageStartMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletechildstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent = CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletechildscripttask = CreatePageLoadCompleteChildScriptTaskScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletechildscripttask);
			ProcessSchemaStartMessageEvent typeeditchangemessage = CreateTypeEditChangeMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(typeeditchangemessage);
			ProcessSchemaScriptTask typeeditchangescripttask = CreateTypeEditChangeScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(typeeditchangescripttask);
			ProcessSchemaStartMessageEvent okbuttonclickmessage = CreateOKButtonClickMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(okbuttonclickmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask okbuttonclickscript = CreateOKButtonClickScriptScriptTask();
			eventsubprocess6.FlowElements.Add(okbuttonclickscript);
			ProcessSchemaStartMessageEvent treegriddblclickmessage = CreateTreeGridDblClickMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(treegriddblclickmessage);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e3adfb06-f280-49e1-a988-4ab4a7efe87d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				CurveCenterPosition = new Point(189, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6e1765a4-2fce-4f78-bf6c-3e0812756206"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a2a37c32-768c-4a2c-b0c2-e8fc3890dbcc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0b41f9e8-77b2-4d76-afb8-af856b7766a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				CurveCenterPosition = new Point(302, 97),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a2a37c32-768c-4a2c-b0c2-e8fc3890dbcc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0a7a6407-d877-4c80-b50d-4ae9971b14fe"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("4db4b237-9575-412e-9f29-4b21a486d24c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e13b12d0-9ee6-460a-beb3-162ab3e9fbee"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e1b88dd7-fdad-49dd-b353-47f042ddee89"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("7f7b3500-ea77-41cd-be09-27cef9867a08"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c9b4d353-c777-493f-b9f3-e1949c305fec"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb7878df-fb63-4379-b661-53e4cb012514"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("e91fc3c0-3d0a-4590-a558-fce3c7a6ad9c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bb7878df-fb63-4379-b661-53e4cb012514"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9a805cf7-7619-429d-beb9-6acf236b3daf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("a46f8998-7344-42ef-8358-1dfc59a285fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				CurveCenterPosition = new Point(243, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4c23a22-4393-464d-a3bf-0c55d0ca0451"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb7878df-fb63-4379-b661-53e4cb012514"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("79cce728-2ea0-40d9-a526-5b9dde346153"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1045, 617),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6c0b44e0-7047-496c-b0c9-c94d77546de4"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("79cce728-2ea0-40d9-a526-5b9dde346153"),
				CreatedInOwnerSchemaUId = new Guid("6b6c2608-cc51-4326-a78f-50c181d3f861"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 411),
				Size = new Size(1016, 206),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("f9d5ec3f-7cf6-44c9-a1a8-c5cefe8d6990"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("79cce728-2ea0-40d9-a526-5b9dde346153"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"Lane3",
				Position = new Point(29, 247),
				Size = new Size(1016, 159),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("59874fae-5b07-424f-8524-0a821c935ee7"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("79cce728-2ea0-40d9-a526-5b9dde346153"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"Lane4",
				Position = new Point(29, 0),
				Size = new Size(1016, 242),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("84c5b22a-0bdd-4099-a015-c6be7307fcf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c0b44e0-7047-496c-b0c9-c94d77546de4"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"PageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(427, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6e1765a4-2fce-4f78-bf6c-3e0812756206"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84c5b22a-0bdd-4099-a015-c6be7307fcf9"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"PageLoadCompleteChildStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a2a37c32-768c-4a2c-b0c2-e8fc3890dbcc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84c5b22a-0bdd-4099-a015-c6be7307fcf9"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0a7a6407-d877-4c80-b50d-4ae9971b14fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84c5b22a-0bdd-4099-a015-c6be7307fcf9"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"PageLoadCompleteChildScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,209,74,195,64,16,69,159,27,200,63,44,251,180,129,178,63,80,124,144,20,74,160,72,49,234,251,144,140,101,105,50,19,102,103,19,130,248,239,110,21,45,234,235,92,206,185,151,153,65,12,116,26,102,124,228,197,220,153,19,156,209,239,65,161,229,36,29,250,251,239,108,87,22,225,213,184,38,62,224,82,153,183,178,216,204,25,157,36,140,32,107,157,68,144,186,181,233,179,130,112,49,135,20,122,215,174,177,69,213,64,231,232,15,168,47,48,36,116,207,17,165,102,34,204,98,166,173,177,167,223,10,91,249,39,110,85,50,229,170,42,183,110,126,230,249,108,171,121,72,35,125,169,236,173,214,110,255,79,249,3,31,25,250,35,243,37,77,251,16,167,1,214,79,73,188,89,236,21,120,47,139,134,130,54,99,254,131,187,30,4,53,9,25,149,132,187,15,170,201,250,28,45,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2dc8c0ab-0af1-4ba3-a297-e3cc4a46e604"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9d5ec3f-7cf6-44c9-a1a8-c5cefe8d6990"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"EventSubProcess5",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(430, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTypeEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e13b12d0-9ee6-460a-beb3-162ab3e9fbee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dc8c0ab-0af1-4ba3-a297-e3cc4a46e604"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TypeEditChange",
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"TypeEditChangeMessage",
				Position = new Point(57, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTypeEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e1b88dd7-fdad-49dd-b353-47f042ddee89"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dc8c0ab-0af1-4ba3-a297-e3cc4a46e604"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"TypeEditChangeScriptTask",
				Position = new Point(155, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,219,110,131,48,12,134,175,169,196,59,100,92,129,84,229,5,118,144,170,130,166,94,108,162,176,237,62,3,111,203,4,73,149,56,116,104,218,187,47,4,232,1,84,109,220,25,255,254,126,219,113,34,144,99,75,88,129,188,129,76,238,201,45,73,217,59,208,152,33,203,165,81,5,208,213,152,187,246,23,13,83,100,167,100,105,10,124,106,119,176,137,71,125,23,37,37,71,250,194,42,3,115,101,146,111,173,84,192,158,36,206,49,47,62,160,102,91,3,170,13,159,53,168,181,20,2,172,145,20,244,84,240,192,132,165,171,37,9,210,35,43,136,6,62,47,215,178,50,181,176,228,115,43,186,42,135,84,56,73,100,82,98,143,166,247,128,169,226,53,83,109,47,125,100,53,132,209,200,22,54,250,155,30,116,69,182,31,226,190,161,43,157,131,106,120,241,159,242,205,168,117,51,77,116,27,29,115,141,92,20,104,25,168,236,90,201,124,175,253,251,205,60,236,112,125,106,178,221,229,249,243,117,174,252,141,132,115,226,149,125,45,83,85,17,249,246,23,222,171,148,213,113,174,137,155,211,119,134,93,52,76,230,174,224,166,43,187,155,14,233,185,123,57,252,115,71,147,27,189,3,81,174,62,217,87,210,128,64,29,94,82,58,176,109,224,208,204,5,93,6,218,212,48,1,254,120,254,66,1,26,37,250,117,254,2,251,186,22,146,253,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dae5c222-256b-4dd6-8527-040e387956b6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59874fae-5b07-424f-8524-0a821c935ee7"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"EventSubProcess6",
				Position = new Point(50, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(535, 212),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c9b4d353-c777-493f-b9f3-e1949c305fec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dae5c222-256b-4dd6-8527-040e387956b6"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"OKButtonClickMessage",
				Position = new Point(42, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("9a805cf7-7619-429d-beb9-6acf236b3daf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dae5c222-256b-4dd6-8527-040e387956b6"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"IntermediateThrowMessageEvent1",
				Position = new Point(364, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOKButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bb7878df-fb63-4379-b661-53e4cb012514"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dae5c222-256b-4dd6-8527-040e387956b6"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"OKButtonClickScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(182, 105),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,65,107,194,64,16,133,207,10,254,135,97,79,9,154,80,69,197,42,61,36,81,139,5,65,20,122,81,15,75,118,180,11,113,87,38,187,74,27,242,223,27,19,219,90,75,143,51,179,239,155,247,118,228,206,89,240,61,250,99,110,248,74,91,138,209,15,98,35,79,184,212,231,185,22,114,39,81,184,144,53,234,181,19,167,218,145,228,129,211,251,43,79,44,194,19,40,60,195,179,149,194,97,189,105,16,133,131,176,235,77,198,253,192,235,182,195,208,11,59,157,174,215,239,61,70,157,112,218,158,132,131,128,185,163,10,3,177,86,39,36,131,148,94,33,47,169,86,209,87,115,189,133,236,139,252,107,224,184,249,133,144,26,146,106,15,82,20,226,203,220,95,33,73,158,200,15,252,63,138,191,168,156,71,58,177,7,85,250,111,221,216,88,63,108,75,115,165,126,21,147,60,154,57,87,69,65,126,32,68,213,248,3,143,18,137,202,204,198,208,132,66,90,99,190,86,223,251,110,246,164,209,27,87,123,20,75,76,143,90,165,232,176,242,121,161,42,18,52,129,181,178,13,91,144,22,54,54,21,120,38,54,12,134,144,197,63,140,33,176,171,230,46,240,237,65,238,3,93,224,121,238,142,202,127,207,27,117,66,99,73,129,33,139,163,79,161,111,203,205,247,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridDblClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a4c23a22-4393-464d-a3bf-0c55d0ca0451"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dae5c222-256b-4dd6-8527-040e387956b6"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TreeGridDblClick",
				ModifiedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				Name = @"TreeGridDblClickMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(203, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitImageMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f83ce94-cebc-400c-954c-bcb0fa73c690"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ec535512-952e-4f67-b052-d83dd8cbca7f"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5375dee1-bc17-46f5-9908-be2eaf10ece0"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6859a846-19bc-45e6-8ad5-b6c619db02aa"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8dee24f2-ec02-4125-a8b6-88b3d5ae47c2"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4d5c769a-260c-4913-9dfd-5f7a68a5f440"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f8edb689-e2d8-463d-a704-b7e060156d18"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateInitImageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ace6bac-a1de-4979-8df4-f949e9bb5743"),
				Name = "InitImage",
				CreatedInSchemaUId = new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,93,111,218,48,20,125,38,82,254,131,199,83,34,21,75,69,180,234,196,58,41,9,105,151,135,78,20,214,190,91,177,217,44,37,54,114,28,170,104,226,191,207,95,172,14,129,138,190,1,62,247,156,115,239,185,151,29,18,96,43,104,141,68,247,138,170,150,128,123,176,68,191,9,92,32,137,214,188,21,37,129,73,41,233,142,172,248,27,124,36,242,87,183,37,56,227,85,91,51,131,255,246,216,82,252,61,26,47,5,199,109,41,109,73,129,199,241,60,12,232,38,234,83,223,3,141,134,121,189,149,93,12,254,134,193,232,72,154,145,55,3,137,198,55,15,73,150,222,165,179,73,190,184,77,38,179,235,52,157,164,211,233,108,114,123,243,53,155,166,15,215,121,122,151,24,145,209,121,187,107,34,61,167,67,143,87,189,206,53,217,62,12,194,96,103,70,226,65,243,245,179,243,150,51,73,101,183,46,255,144,26,61,183,68,116,209,75,67,68,198,25,35,74,149,51,232,3,158,16,83,214,196,21,232,11,27,215,90,131,186,57,42,238,99,57,152,96,247,24,13,158,86,156,75,43,160,243,88,218,14,44,248,39,170,73,20,31,248,153,250,118,137,194,88,151,189,187,170,149,233,139,202,10,141,52,117,3,84,209,44,104,35,41,43,165,226,144,162,37,115,112,114,178,167,20,84,83,118,138,71,179,29,166,69,55,160,63,30,240,69,197,212,86,85,28,6,106,185,0,24,105,193,146,51,41,120,101,220,186,24,51,239,167,40,158,143,212,22,249,40,248,223,156,15,116,235,101,189,217,25,204,7,133,38,151,151,2,31,55,230,94,160,122,26,20,89,198,94,144,135,123,240,59,62,83,103,137,109,217,7,194,22,208,232,233,166,157,217,147,67,126,39,61,169,209,59,67,69,111,31,54,168,106,134,78,206,161,77,242,159,163,30,100,177,34,141,58,99,164,186,136,222,207,221,29,212,138,148,246,150,53,50,199,84,194,67,202,62,133,225,252,184,236,7,197,152,248,253,237,1,81,31,204,95,212,133,149,174,215,253,63,46,34,105,204,81,5,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eeee6d79-ee02-4120-9221-3043bc23ac35"));
		}

		#endregion

	}

	#endregion

}

