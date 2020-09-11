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
	using Terrasoft.Configuration;
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
	using Terrasoft.Web.Common;

	#region Class: SysModuleDetailEditPageSchema

	/// <exclude/>
	public class SysModuleDetailEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LocalizableTextEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysPageSchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysPageSchemaEdit {
			get {
				return _sysPageSchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysEntitySchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysEntitySchemaEdit {
			get {
				return _sysEntitySchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _typeColumnEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeColumnEdit {
			get {
				return _typeColumnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _optionsPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel OptionsPanel {
			get {
				return _optionsPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _associationTab;
		public Terrasoft.UI.WebControls.Controls.Tab AssociationTab {
			get {
				return _associationTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _detailParentAsscContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer DetailParentAsscContainer {
			get {
				return _detailParentAsscContainer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _sysModuleEditContainer;
		public Terrasoft.UI.WebControls.Controls.Tab SysModuleEditContainer {
			get {
				return _sysModuleEditContainer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _sysModuleEditPageContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer SysModuleEditPageContainer {
			get {
				return _sysModuleEditPageContainer;
			}
		}

		#endregion

		#region Constructors: Public

		public SysModuleDetailEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleDetailEditPageSchema(SysModuleDetailEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateBaseMessagePanel() {
			BaseMessagePanel.Edges = "0 0 0 0";
			BaseMessagePanel.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			ButtonsControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			ButtonsControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Left;
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.HasSplitter = true;
			MainControlLayout.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			RealUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			Name = "SysModuleDetailEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 400;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleDetailEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateMainControlLayout();
			UpdateCustomControls();
			UpdateButtonsControlLayout();
			UpdateDesignerModeButton();
			UpdateApplyChangesButton();
			UpdateContextHelpButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateBaseMessagePanel();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, OKButton);
			ButtonsControlLayout.MoveItem(1, CancelButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, ContextHelpButton);
			ButtonsControlLayout.MoveItem(4, ApplyChangesButton);
			ButtonsControlLayout.MoveItem(5, DesignerModeButton);
			TopLevelControl.MoveItem(2, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateCaptionEdit());
			MainControlLayout.InsertItem(1, CreateSysPageSchemaEdit());
			MainControlLayout.InsertItem(2, CreateSysEntitySchemaEdit());
			MainControlLayout.InsertItem(3, CreateTypeColumnEdit());
			MainControlLayout.MoveItem(4, CustomControls);
			Controls.AddAt(3, CreateOptionsPanel());
			OptionsPanel.InsertItem(0, CreateAssociationTab());
			AssociationTab.InsertItem(0, CreateDetailParentAsscContainer());
			OptionsPanel.InsertItem(1, CreateSysModuleEditContainer());
			SysModuleEditContainer.InsertItem(0, CreateSysModuleEditPageContainer());
			TopLevelControl.MoveItem(4, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleDetailEditPageEventsProcessSchema() {
			var schema = new SysModuleDetailEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.LocalizableTextEdit();
			_captionEdit.UId = new Guid("0fe5efbc-3511-4609-891d-9b28b8526e92");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_captionEdit.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_captionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionEdit.Required = true;
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysPageSchemaEdit() {
			_sysPageSchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysPageSchemaEdit.UId = new Guid("d7e07ce1-d7e4-47c0-af0f-f4efdee3e950");
			_sysPageSchemaEdit.Name = "SysPageSchemaEdit";
			_sysPageSchemaEdit.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_sysPageSchemaEdit.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_sysPageSchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysPageSchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_sysPageSchemaEdit.Tag = "";
			_sysPageSchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysPageSchemaEdit.Image = new ControlImage {};
			_sysPageSchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysPageSchemaEdit.Required = true;
			_sysPageSchemaEdit.LookupSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae");
			return _sysPageSchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysEntitySchemaEdit() {
			_sysEntitySchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysEntitySchemaEdit.UId = new Guid("348468fe-a414-4135-848e-3015b3d98ed1");
			_sysEntitySchemaEdit.Name = "SysEntitySchemaEdit";
			_sysEntitySchemaEdit.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_sysEntitySchemaEdit.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_sysEntitySchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysEntitySchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_sysEntitySchemaEdit.Tag = "";
			_sysEntitySchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysEntitySchemaEdit.Image = new ControlImage {};
			_sysEntitySchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysEntitySchemaEdit.Required = true;
			_sysEntitySchemaEdit.LookupSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae");
			return _sysEntitySchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateTypeColumnEdit() {
			_typeColumnEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_typeColumnEdit.UId = new Guid("2311aca2-9e13-42cc-b013-78fa1f9c995a");
			_typeColumnEdit.Name = "TypeColumnEdit";
			_typeColumnEdit.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_typeColumnEdit.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_typeColumnEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_typeColumnEdit.Tag = "";
			_typeColumnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_typeColumnEdit.Image = new ControlImage {};
			_typeColumnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _typeColumnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateDetailParentAsscContainer() {
			_detailParentAsscContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_detailParentAsscContainer.UId = new Guid("12307cc2-3727-46d1-a62a-af30eb4d431b");
			_detailParentAsscContainer.Name = "DetailParentAsscContainer";
			_detailParentAsscContainer.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_detailParentAsscContainer.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_detailParentAsscContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_detailParentAsscContainer.HelpContextId = "277";
			_detailParentAsscContainer.Tag = "";
			_detailParentAsscContainer.PageSchemaUId = new Guid("c96a54f2-9ba3-412d-bfac-c97c7a0a9646");
			_detailParentAsscContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_detailParentAsscContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_detailParentAsscContainer.StartNewAlignGroup = false;
			_detailParentAsscContainer.Edges = "";
			return _detailParentAsscContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateAssociationTab() {
			_associationTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_associationTab.UId = new Guid("f4b65dfd-a6a3-4a83-bcce-ab9a077ad70e");
			_associationTab.Name = "AssociationTab";
			_associationTab.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_associationTab.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_associationTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_associationTab.Tag = "";
			_associationTab.Image = new ControlImage {};
			return _associationTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateSysModuleEditPageContainer() {
			_sysModuleEditPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_sysModuleEditPageContainer.UId = new Guid("47d17f78-3879-49c8-9495-f246318911bc");
			_sysModuleEditPageContainer.Name = "SysModuleEditPageContainer";
			_sysModuleEditPageContainer.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_sysModuleEditPageContainer.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_sysModuleEditPageContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysModuleEditPageContainer.Tag = "";
			_sysModuleEditPageContainer.PageSchemaUId = new Guid("b489c203-06c3-4502-b8a3-7c3692af97f2");
			_sysModuleEditPageContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysModuleEditPageContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysModuleEditPageContainer.StartNewAlignGroup = false;
			_sysModuleEditPageContainer.Edges = "";
			return _sysModuleEditPageContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateSysModuleEditContainer() {
			_sysModuleEditContainer = new Terrasoft.UI.WebControls.Controls.Tab();
			_sysModuleEditContainer.UId = new Guid("8d98e98e-34ea-4bee-b681-4c695c21efa5");
			_sysModuleEditContainer.Name = "SysModuleEditContainer";
			_sysModuleEditContainer.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_sysModuleEditContainer.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_sysModuleEditContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysModuleEditContainer.Tag = "";
			_sysModuleEditContainer.Image = new ControlImage {};
			return _sysModuleEditContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateOptionsPanel() {
			_optionsPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_optionsPanel.UId = new Guid("0d4fa8f6-c996-477f-8824-483a57fa90c9");
			_optionsPanel.Name = "OptionsPanel";
			_optionsPanel.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_optionsPanel.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			_optionsPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_optionsPanel.Tag = "";
			_optionsPanel.ActiveTabIndex = 0;
			_optionsPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_optionsPanel.StartNewAlignGroup = false;
			_optionsPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _optionsPanel;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("fac3d18a-97ac-4d97-8997-31241d391675");
			DataSource.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("fdecd3d3-280c-47aa-862a-b9c85f580c1d");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("27165c5b-f3c0-453c-b2d5-1802d624cfd1");
			if (column != null) {
				column.UId = new Guid("d893015e-552e-4395-a86a-46c39df52fef");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("15f34e9b-25a9-4a82-9c56-e3118434a9ee");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("8f0e0d57-4caa-4d9b-b3df-68fb2c0909fd");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("c99a5d88-fff5-4dbe-9cd0-af8fd9e0b637");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("c1f81146-82c1-46b3-806a-d5a6aa92c0a8");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f9ca8dd6-d2e3-4aee-b150-adff370afc22");
			if (column != null) {
				column.UId = new Guid("daaecbf1-88e8-456e-a227-3c33eb2bc15d");
				column.Name = @"SysModule";
				column.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8905fbc3-3962-4925-aab1-cdcf3f7c7acb");
			if (column != null) {
				column.UId = new Guid("23722c19-90ee-4ad4-b277-640250b33239");
				column.Name = @"SysModuleGrid";
				column.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4eec92e2-97d0-4f92-baf7-af8b2dee04be");
			if (column != null) {
				column.UId = new Guid("52ca65d2-079a-4aa2-a6c8-640b8863bbf8");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.ModifiedInSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysModuleDetailEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleDetailEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleDetailEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleDetailEditPageEventsProcess

	/// <exclude/>
	public class SysModuleDetailEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleDetailEditPageSchemaUserControl
	{

		#region Class: AllowAddDetailUserTaskFlowElement

		/// <exclude/>
		public class AllowAddDetailUserTaskFlowElement : QuestionUserTask
		{

			public AllowAddDetailUserTaskFlowElement(UserConnection userConnection, SysModuleDetailEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AllowAddDetailUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: DetailTreeGridLoadRowUserTaskFlowElement

		/// <exclude/>
		public class DetailTreeGridLoadRowUserTaskFlowElement : TreeGridLoadRowUserTask
		{

			public DetailTreeGridLoadRowUserTaskFlowElement(UserConnection userConnection, SysModuleDetailEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "DetailTreeGridLoadRowUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("780c652d-ff96-4fb7-a7a6-41bb105f1b3f");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public SysModuleDetailEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleDetailEditPageEventsProcess";
			SchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36");
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

		public virtual Guid SelectedModuleId {
			get;
			set;
		}

		public virtual Guid SelectedModuleEntityId {
			get;
			set;
		}

		public virtual Guid SelectedPageSchemaId {
			get;
			set;
		}

		public virtual Guid SelectedDetailEntitySchemaId {
			get;
			set;
		}

		public virtual bool NeedSendAllowMessage {
			get;
			set;
		}

		public virtual bool CloseWindowAfterSave {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess5;
		public ProcessFlowElement EventSubProcess5 {
			get {
				return _eventSubProcess5 ?? (_eventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5",
					SchemaElementUId = new Guid("082e778c-f5db-4f5e-9f11-d7164073b08c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("93193c2c-9eba-4034-be4e-602808e9ea6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("961a61ab-b95d-4fdd-99ed-b94f04a3c969"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("8ebe34e3-ce4d-4afa-9c51-dc22c7d8676c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
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
					SchemaElementUId = new Guid("11a0ee4f-7ed3-42f5-b390-2ef0525fb319"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("82544d01-f667-49ed-a763-ff92c08ad9b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4;
		public ProcessFlowElement StartMessage4 {
			get {
				return _startMessage4 ?? (_startMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4",
					SchemaElementUId = new Guid("e51b23cb-48a1-4d07-9b4c-4e9f3526aa60"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("87677a3a-7dd2-4ea7-af87-0382e4586999"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("b44509f5-802b-4529-bda2-21de371e55e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage6;
		public ProcessFlowElement StartMessage6 {
			get {
				return _startMessage6 ?? (_startMessage6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6",
					SchemaElementUId = new Guid("d6bffd25-0874-4f98-8ee5-ba5218a3a04a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask6;
		public ProcessScriptTask ScriptTask6 {
			get {
				return _scriptTask6 ?? (_scriptTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask6",
					SchemaElementUId = new Guid("3d462202-28b1-44e5-b4f3-20d3701909d1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask6Execute,
				});
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
					SchemaElementUId = new Guid("e98f76d1-def1-4e56-b36c-7b5b45dee35c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startRequestAddDetailMessage;
		public ProcessFlowElement StartRequestAddDetailMessage {
			get {
				return _startRequestAddDetailMessage ?? (_startRequestAddDetailMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartRequestAddDetailMessage",
					SchemaElementUId = new Guid("0c8dd0f7-e559-44f6-bebb-cb12b03ca9ac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask7;
		public ProcessScriptTask ScriptTask7 {
			get {
				return _scriptTask7 ?? (_scriptTask7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask7",
					SchemaElementUId = new Guid("e5939809-be81-430c-85c2-de1658430cc5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask7Execute,
				});
			}
		}

		private AllowAddDetailUserTaskFlowElement _allowAddDetailUserTask;
		public AllowAddDetailUserTaskFlowElement AllowAddDetailUserTask {
			get {
				return _allowAddDetailUserTask ?? (_allowAddDetailUserTask = new AllowAddDetailUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _startChildAllowAddDetailMessage;
		public ProcessFlowElement StartChildAllowAddDetailMessage {
			get {
				return _startChildAllowAddDetailMessage ?? (_startChildAllowAddDetailMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartChildAllowAddDetailMessage",
					SchemaElementUId = new Guid("3d6e0dba-c035-4cfc-973c-c3af0fb4e239"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask8;
		public ProcessScriptTask ScriptTask8 {
			get {
				return _scriptTask8 ?? (_scriptTask8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask8",
					SchemaElementUId = new Guid("b46be345-2403-46c4-88ee-d0e7862e51be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask8Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask10;
		public ProcessScriptTask ScriptTask10 {
			get {
				return _scriptTask10 ?? (_scriptTask10 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask10",
					SchemaElementUId = new Guid("011c3c70-c151-4b51-9cca-fedabf19808a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask10Execute,
				});
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
					SchemaElementUId = new Guid("53c66c3a-1f8e-476f-8ae4-471c7478623a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startChildDataSourceSaved;
		public ProcessFlowElement StartChildDataSourceSaved {
			get {
				return _startChildDataSourceSaved ?? (_startChildDataSourceSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartChildDataSourceSaved",
					SchemaElementUId = new Guid("030bee36-41eb-4d1a-bf06-62d02603e2fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask11;
		public ProcessScriptTask ScriptTask11 {
			get {
				return _scriptTask11 ?? (_scriptTask11 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask11",
					SchemaElementUId = new Guid("c1e78a94-0c98-4240-8c5e-212b78b48daf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask11Execute,
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
					SchemaElementUId = new Guid("8ca63a06-0f5b-40dd-8d56-dd12a58a44ca"),
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

		private DetailTreeGridLoadRowUserTaskFlowElement _detailTreeGridLoadRowUserTask;
		public DetailTreeGridLoadRowUserTaskFlowElement DetailTreeGridLoadRowUserTask {
			get {
				return _detailTreeGridLoadRowUserTask ?? (_detailTreeGridLoadRowUserTask = new DetailTreeGridLoadRowUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTask12;
		public ProcessScriptTask ScriptTask12 {
			get {
				return _scriptTask12 ?? (_scriptTask12 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask12",
					SchemaElementUId = new Guid("0ef6c56a-4188-4ada-a069-682122297027"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask12Execute,
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
					SchemaElementUId = new Guid("b3888c95-c748-467f-a850-a7d9e4e1117e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage11;
		public ProcessFlowElement StartMessage11 {
			get {
				return _startMessage11 ?? (_startMessage11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage11",
					SchemaElementUId = new Guid("2f175cee-a672-45e9-916a-b286080356c8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2 {
			get {
				return _intermediateThrowMessageEvent2 ?? (_intermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("785b8075-10be-4d53-a2c0-49c20f1915bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask13;
		public ProcessScriptTask ScriptTask13 {
			get {
				return _scriptTask13 ?? (_scriptTask13 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask13",
					SchemaElementUId = new Guid("56842afe-0748-4544-9451-9ef021c85f03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask13Execute,
				});
			}
		}

		private ProcessFlowElement _childInitEventSubProcess;
		public ProcessFlowElement ChildInitEventSubProcess {
			get {
				return _childInitEventSubProcess ?? (_childInitEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ChildInitEventSubProcess",
					SchemaElementUId = new Guid("7e7c8674-4e12-4fdf-87d6-2390d36a2687"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childInit;
		public ProcessFlowElement ChildInit {
			get {
				return _childInit ?? (_childInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInit",
					SchemaElementUId = new Guid("063f3402-b805-49b5-9461-98938cbe4c64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _baseInit;
		public ProcessThrowMessageEvent BaseInit {
			get {
				return _baseInit ?? (_baseInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseInit",
					SchemaElementUId = new Guid("65fb2ea8-10ed-487c-b410-e891191a13f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptChildInit;
		public ProcessScriptTask ScriptChildInit {
			get {
				return _scriptChildInit ?? (_scriptChildInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildInit",
					SchemaElementUId = new Guid("ec0784de-48a5-4479-b77e-10005876bd86"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow66;
		public ProcessConditionalFlow ConditionalFlow66 {
			get {
				return _conditionalFlow66 ?? (_conditionalFlow66 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow66",
					SchemaElementUId = new Guid("e0c5d5a9-1ce4-420c-a972-7c10cb47ff23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _newRecordNotSavedMessage;
		public LocalizableString NewRecordNotSavedMessage {
			get {
				return _newRecordNotSavedMessage ?? (_newRecordNotSavedMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NewRecordNotSavedMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6 };
			FlowElements[ScriptTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask6 };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartRequestAddDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartRequestAddDetailMessage };
			FlowElements[ScriptTask7.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask7 };
			FlowElements[AllowAddDetailUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AllowAddDetailUserTask };
			FlowElements[StartChildAllowAddDetailMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartChildAllowAddDetailMessage };
			FlowElements[ScriptTask8.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask8 };
			FlowElements[ScriptTask10.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask10 };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[StartChildDataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { StartChildDataSourceSaved };
			FlowElements[ScriptTask11.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask11 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[DetailTreeGridLoadRowUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DetailTreeGridLoadRowUserTask };
			FlowElements[ScriptTask12.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask12 };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[StartMessage11.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage11 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[ScriptTask13.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask13 };
			FlowElements[ChildInitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitEventSubProcess };
			FlowElements[ChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInit };
			FlowElements[BaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseInit };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess5":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask2":
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "EventSubProcess7":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage6":
						e.Context.QueueTasks.Enqueue("ScriptTask6");
						break;
					case "ScriptTask6":
						break;
					case "EventSubProcess10":
						break;
					case "StartRequestAddDetailMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask7");
						break;
					case "ScriptTask7":
						e.Context.QueueTasks.Enqueue("AllowAddDetailUserTask");
						break;
					case "AllowAddDetailUserTask":
						break;
					case "StartChildAllowAddDetailMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask10");
						break;
					case "ScriptTask8":
						break;
					case "ScriptTask10":
						e.Context.QueueTasks.Enqueue("ScriptTask8");
						break;
					case "EventSubProcess11":
						break;
					case "StartChildDataSourceSaved":
						e.Context.QueueTasks.Enqueue("ScriptTask11");
						break;
					case "ScriptTask11":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow66ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("DetailTreeGridLoadRowUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTask12");
						break;
					case "DetailTreeGridLoadRowUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTask12");
						break;
					case "ScriptTask12":
						break;
					case "EventSubProcess12":
						break;
					case "StartMessage11":
						e.Context.QueueTasks.Enqueue("ScriptTask13");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "ScriptTask13":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "ChildInitEventSubProcess":
						break;
					case "ChildInit":
						e.Context.QueueTasks.Enqueue("BaseInit");
						break;
					case "BaseInit":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "ScriptChildInit":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow66ExpressionExecute() {
			return Convert.ToBoolean(NeedRefreshGrid);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("StartMessage6");
			ActivatedEventElements.Add("StartRequestAddDetailMessage");
			ActivatedEventElements.Add("StartChildAllowAddDetailMessage");
			ActivatedEventElements.Add("StartChildDataSourceSaved");
			ActivatedEventElements.Add("StartMessage11");
			ActivatedEventElements.Add("ChildInit");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6";
					result = StartMessage6.Execute(context);
					break;
				case "ScriptTask6":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask6";
					result = ScriptTask6.Execute(context, ScriptTask6Execute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartRequestAddDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartRequestAddDetailMessage";
					result = StartRequestAddDetailMessage.Execute(context);
					break;
				case "ScriptTask7":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask7";
					result = ScriptTask7.Execute(context, ScriptTask7Execute);
					break;
				case "AllowAddDetailUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AllowAddDetailUserTask";
					result = AllowAddDetailUserTask.Execute(context);
					break;
				case "StartChildAllowAddDetailMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartChildAllowAddDetailMessage";
					result = StartChildAllowAddDetailMessage.Execute(context);
					break;
				case "ScriptTask8":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask8";
					result = ScriptTask8.Execute(context, ScriptTask8Execute);
					break;
				case "ScriptTask10":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask10";
					result = ScriptTask10.Execute(context, ScriptTask10Execute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "StartChildDataSourceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartChildDataSourceSaved";
					result = StartChildDataSourceSaved.Execute(context);
					break;
				case "ScriptTask11":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask11";
					result = ScriptTask11.Execute(context, ScriptTask11Execute);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "DetailTreeGridLoadRowUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DetailTreeGridLoadRowUserTask";
					result = DetailTreeGridLoadRowUserTask.Execute(context);
					break;
				case "ScriptTask12":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask12";
					result = ScriptTask12.Execute(context, ScriptTask12Execute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage11":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage11";
					result = StartMessage11.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ScriptTask13":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask13";
					result = ScriptTask13.Execute(context, ScriptTask13Execute);
					break;
				case "ChildInitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInit";
					result = ChildInit.Execute(context);
					break;
				case "BaseInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = BaseInit.Execute(context);
					break;
				case "ScriptChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildInit";
					result = ScriptChildInit.Execute(context, ScriptChildInitExecute);
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
				case "CloseWindowAfterSave":
					CloseWindowAfterSave = reader.GetValue<System.Boolean>();
				break;
				case "NeedSendAllowMessage":
					NeedSendAllowMessage = reader.GetValue<System.Boolean>();
				break;
				case "SelectedDetailEntitySchemaId":
					SelectedDetailEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "SelectedPageSchemaId":
					SelectedPageSchemaId = reader.GetValue<System.Guid>();
				break;
				case "SelectedModuleEntityId":
					SelectedModuleEntityId = reader.GetValue<System.Guid>();
				break;
				case "SelectedModuleId":
					SelectedModuleId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			SelectedModuleEntityId = GetSysModuleEntityId(SelectedModuleId);
			if (Page.DataSource.Rows.Count > 0) {
				var entity = Page.DataSource.Rows[0];
				var pageSchemaColumn = entity.Schema.Columns.GetByName("SysModuleGrid");
				var moduleGridId = entity.GetTypedColumnValue<Guid>(pageSchemaColumn.ColumnValueName);
				var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleGrid");
				var pageSchemaColumnName = entitySchemaQuery.AddColumn("SysPageSchemaUId").Name;
				var moduleEntitySchemaColumnName = entitySchemaQuery.AddColumn("SysModuleEntity.Id").Name;
				var entitySchemaColumnName = entitySchemaQuery.AddColumn("SysModuleEntity.SysEntitySchemaUId").Name;
				var typeColumnUIdColumnName = entitySchemaQuery.AddColumn("SysModuleEntity.TypeColumnUId").Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					entitySchemaQuery.RootSchema.GetPrimaryColumnName(), moduleGridId));
				var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				var pageSchemaId = entities[0].GetTypedColumnValue<Guid>(pageSchemaColumnName);
				var entitySchemaId = entities[0].GetTypedColumnValue<Guid>(entitySchemaColumnName); 
				var typeColumnUId = entities[0].GetTypedColumnValue<Guid>(typeColumnUIdColumnName);
				Guid moduleEnityId = entities[0].GetTypedColumnValue<Guid>(moduleEntitySchemaColumnName);
				Page.SysPageSchemaEdit.SetValueAndText(pageSchemaId, GetSchemaDisplayValue(pageSchemaId));
				Page.SysEntitySchemaEdit.SetValueAndText(entitySchemaId, GetSchemaDisplayValue(entitySchemaId));
				SelectedPageSchemaId = pageSchemaId;
				SelectedDetailEntitySchemaId = entitySchemaId;
				FillTypeColumnEdit(entitySchemaId);
				if (entitySchemaId != Guid.Empty && typeColumnUId != Guid.Empty) {
					var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaId);
					var typeColumn = schema.Columns.GetByUId(typeColumnUId);
					Page.TypeColumnEdit.SetValueAndText(typeColumn.UId, typeColumn.Caption);
				}
				Page.SysModuleEditPageContainer.PageInstance.Process.SetPropertyValue("SysModuleEntityId", moduleEnityId);
			}
			if (!IsNew && !IsCopy) {
				Page.DetailParentAsscContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", EntityPrimaryColumnValue);
				Page.SysModuleEditPageContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", EntityPrimaryColumnValue);
			}
			Page.DetailParentAsscContainer.PageInstance.ThrowEvent("GridPageRefreshRow");
			Page.SysModuleEditPageContainer.PageInstance.ThrowEvent("GridPageRefreshRow");
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["SysModule_activeDataSource"] = Page.DataSource.ClientID;
			Page.CaptionEdit.LocalizableText = 
				Terrasoft.Configuration.CommonUtilities.GetLocalizableValue(UserConnection, Page.DataSource.Schema.Name, "Caption", Page.DataSource.ActiveRowPrimaryColumnValue);
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var sysModuleInWorkspaceId = Guid.Parse(Page.GetParameterValue("ParentEntityId") as string);
			SelectedModuleId = GetSysModuleId(sysModuleInWorkspaceId);
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			string tempString = Page.CaptionEdit.Text;
			Page.CaptionEdit.Text = string.Empty;
			Page.CaptionEdit.Text = tempString;
			SelectedPageSchemaId = Page.SysPageSchemaEdit.Value == null ? Guid.Empty : new Guid(Page.SysPageSchemaEdit.Value.ToString());
			return true;
		}

		public virtual bool ScriptTask6Execute(ProcessExecutingContext context) {
			string tempString = Page.CaptionEdit.Text;
			Page.CaptionEdit.Text = string.Empty;
			Page.CaptionEdit.Text = tempString;
			SelectedDetailEntitySchemaId = Page.SysEntitySchemaEdit.Value == null ? Guid.Empty : new Guid(Page.SysEntitySchemaEdit.Value.ToString());
			FillTypeColumnEdit(SelectedDetailEntitySchemaId);
			return true;
		}

		public virtual bool ScriptTask7Execute(ProcessExecutingContext context) {
			NeedSendAllowMessage = true;
			AllowAddDetailUserTask.Page = Page;
			AllowAddDetailUserTask.MessageText = NewRecordNotSavedMessage;
			AllowAddDetailUserTask.Icon = "QUESTION";
			AllowAddDetailUserTask.Buttons = "YESNO";
			AllowAddDetailUserTask.ResponseMessages = new Dictionary<string, string> {{"yes", "AllowAddDetailMessage"},
																					{"no", "DenyAddDetailMessage"}};
			return true;
		}

		public virtual bool ScriptTask8Execute(ProcessExecutingContext context) {
			OkClickMethod();
			return true;
		}

		public virtual bool ScriptTask10Execute(ProcessExecutingContext context) {
			CloseWindowAfterSave = false;
			return true;
		}

		public virtual bool ScriptTask11Execute(ProcessExecutingContext context) {
			if (Page.DataSource.ActiveRow!= null) {
				PrimaryDisplayColumnValue =	Page.DataSource.ActiveRow.PrimaryDisplayColumnValue;
				PrimaryColumnValue =	Page.DataSource.ActiveRow.PrimaryColumnValue;
			}
			NeedRefreshGrid = false;
			var treeGridId = Page.GetParameterValue("treeGridId") == null ? String.Empty :
											Page.GetParameterValue("treeGridId").ToString();
			string updateGridRowScript = String.Empty;
			if (treeGridId != String.Empty) {
				DetailTreeGridLoadRowUserTask.Page = Page;
				DetailTreeGridLoadRowUserTask.TreeGridClientID = treeGridId;
				DetailTreeGridLoadRowUserTask.PrimaryColumnValue = EntityPrimaryColumnValue;
				NeedRefreshGrid = true;
			}
			Terrasoft.Configuration.CommonUtilities.SaveLocalizableValue(Page.DataSource.ActiveRow, Page.CaptionEdit.LocalizableText, "Caption");
			return true;
		}

		public virtual bool ScriptTask12Execute(ProcessExecutingContext context) {
			if (NeedSendAllowMessage) {
				if (Page.DetailParentAsscContainer.PageInstance != null) {
					Page.DetailParentAsscContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", EntityPrimaryColumnValue);
					Page.DetailParentAsscContainer.PageInstance.ThrowEvent("AllowAddDetailMessage");
					NeedSendAllowMessage = false;
				}
			}
			if (!CloseWindowAfterSave) {
				return true;
			}
			if (SuccesfullCloseMessage != null) {
				var closeMessage = SuccesfullCloseMessage.ToString();
				if (!string.IsNullOrEmpty(closeMessage)){
					Page.ThrowClientEvent(closeMessage, new List<object>());
				}
			}
			if (NeedRefreshGrid) {
				var script = (string.IsNullOrEmpty(AdditionalScriptAfterSave) ? string.Empty : AdditionalScriptAfterSave);
				Page.ScriptManager.AddScript(script);
			}
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool ScriptTask13Execute(ProcessExecutingContext context) {
			NeedSendAllowMessage = false;
			CloseWindowAfterSave = true;
			return true;
		}

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			Page.SysPageSchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				//Код, который компилируется только в Workspace CR173568
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysWorkspace.Id"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {"PageSchemaManager"}}});
				//CR174896
				/*	filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysPackage.Id"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {Guid.Empty}}});*/
			};
			
			Page.SysEntitySchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				
				//Код, который компилируется только в Workspace CR173568
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysWorkspace.Id"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}});
				//CR174896
				/*	filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysPackage.Id"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {Guid.Empty}}});*/
			};
			return true;
		}

		public override void OkClickMethod() {
			string caption = Page.CaptionEdit.LocalizableText.GetCultureValue(UserConnection.GetPrimaryCultureInfo());
			var converters = new JsonConverter[] {new GuidJsonConverter()};
			string id = Json.Serialize(Page.DataSource.ActiveRow.PrimaryColumnValue, converters[0]);
			Page.ScriptManager.AddScript(Page.DataSource.ClientID + 
					".onActiveRowColumnValuesChangedResponse(" 
					 + id + ",{\"Caption\" : {columnValue: "
					 + Json.Serialize(caption) + "}});");
			NeedRefreshGrid = true;
			if(IsCopy){
				Page.ScriptManager.AddScript(Page.DataSource.ClientID + ".save();");
			}
			else{
				if (CloseWindowAfterSave) {
					Page.ScriptManager.AddScript(
						"if (" + Page.DataSource.ClientID + ".activeRow.modifiedValues) {" 
							+ Page.DataSource.ClientID + ".save(); " + 
						"} else { window.close(); }"
					);
				} else {
					Page.ScriptManager.AddScript(Page.DataSource.ClientID + ".save();");
				}
			
			UserConnection.ApplicationCache.WithLocalCaching(Terrasoft.Configuration.CacheUtilities.WorkspaceCacheGroup).
					SetOrRemoveValue(Terrasoft.Configuration.CacheUtilities.DetailsCache, null);
			}
		}

		public virtual string GetSchemaDisplayValue(Guid recordId) {
			// TODO #170697
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "VwSysSchemaInfo");
			var captionColumnName = entitySchemaQuery.AddColumn("Caption").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				entitySchemaQuery.RootSchema.GetPrimaryColumnName(), recordId));
			//Код, который компилируется только в Workspace CR173568
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				"SysWorkspace", UserConnection.Workspace.Id));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return entities[0].GetTypedColumnValue<string>(captionColumnName);
			} else {
				return string.Empty;
			}
		}

		public virtual Guid GetSysModuleGridId() {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleGrid");
			var idColumnName = entitySchemaQuery.AddColumn("Id").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysPageSchemaUId", SelectedPageSchemaId));
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysModuleEntity", SelectedDetailEntitySchemaId));
			//Код, который компилируется только в Workspace CR173568, CR173588
			/*entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysWorkspace", UserConnection.Workspace.Id));*/
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return entities[0].GetTypedColumnValue<Guid>(idColumnName);
			} else {
				var schema = entitySchemaManager.GetInstanceByName("SysModuleGrid");
				var key = Guid.NewGuid();
				var entity = schema.CreateEntity(UserConnection);
				entity.SetDefColumnValues();
				var sysDetailModuleEntityId = GetDetailSysModuleEntityId();
				entity.SetColumnValue("Id", key);
				entity.SetColumnValue("SysModuleEntityId", sysDetailModuleEntityId);
				//Код, который компилируется только в Workspace CR173568, CR173588
				//entity.SetColumnValue("SysWorkspaceId", UserConnection.Workspace.Id);
				entity.SetColumnValue("SysPageSchemaUId", SelectedPageSchemaId);
				entity.Save();
				return key;
			}
		}

		public virtual Guid GetDetailSysModuleEntityId() {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleEntity");
			var idColumnName = entitySchemaQuery.AddColumn("Id").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysEntitySchemaUId", SelectedDetailEntitySchemaId));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				var schema = entitySchemaManager.GetInstanceByName("SysModuleEntity");
				var entity = schema.CreateEntity(UserConnection);
				Guid key = entities[0].GetTypedColumnValue<Guid>(idColumnName);
				entity.FetchFromDB(key);
				if (Page.TypeColumnEdit.Value != null && !string.IsNullOrEmpty(Page.TypeColumnEdit.Value.ToString())) {
					entity.SetColumnValue("TypeColumnUId", Page.TypeColumnEdit.Value);
				}
				entity.Save();
				Page.SysModuleEditPageContainer.PageInstance.Process.SetPropertyValue("SysModuleEntityId", key);
				Page.SysModuleEditPageContainer.PageInstance.ThrowEvent("GridPageRefreshRow");
				return key;
			} else {
				var schema = entitySchemaManager.GetInstanceByName("SysModuleEntity");
				var key = Guid.NewGuid();
				var entity = schema.CreateEntity(UserConnection);
				entity.SetDefColumnValues();
				entity.SetColumnValue("Id", key);
				entity.SetColumnValue("SysEntitySchemaUId", SelectedDetailEntitySchemaId);
			//Код, который компилируется только в Workspace CR173568, CR173582
				//entity.SetColumnValue("SysWorkspaceId", UserConnection.Workspace.Id);
			   if (Page.TypeColumnEdit.Value != null && !string.IsNullOrEmpty(Page.TypeColumnEdit.Value.ToString())) {
					entity.SetColumnValue("TypeColumnUId", Page.TypeColumnEdit.Value);
				} else {
					entity.SetColumnValue("TypeColumnUId", null);
				}
				entity.Save();
				Page.SysModuleEditPageContainer.PageInstance.Process.SetPropertyValue("SysModuleEntityId", key);
				Page.SysModuleEditPageContainer.PageInstance.ThrowEvent("GridPageRefreshRow");
				return key;
			}
		}

		public virtual void FillTypeColumnEdit(Guid entitySchemaId) {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager");
			var  entity = entitySchemaManager.GetInstanceByUId(entitySchemaId) as EntitySchema;
			foreach(EntitySchemaColumn item in entity.Columns) {
				var columnTypeName = item.DataValueType.ToString();
				switch(columnTypeName){
				case "Terrasoft.Core.GuidDataValueType":
				case "Terrasoft.Core.LookupDataValueType":
				case "Terrasoft.Core.MultiLookupDataValueType":
					Page.TypeColumnEdit.AddItem(item.UId, item.Caption);
					continue;
				}
			}
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void BeforeSaveRowOnConditionsCorrect(Entity row) {
			var moduleGrid = GetSysModuleGridId();
			row.SetColumnValue("SysModuleGridId", moduleGrid);
		}

		public override Dictionary<string, object> GetDefValues() {
			Dictionary<string, object> defValues = base.GetDefValues();
			defValues["SysModule"] = SelectedModuleId;
			return defValues;
		}

		public virtual Guid GetSysModuleId(Guid sysModuleInWorkspaceId) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("SysModuleInSysModuleFolder");
			var entity = schema.CreateEntity(UserConnection);
			if (entity.FetchFromDB(sysModuleInWorkspaceId)) {	
				var columnName = schema.Columns.FindByName("SysModule").ColumnValueName;	
				return entity.GetTypedColumnValue<Guid>(columnName);
			} else {
				return Guid.Empty;
			}
		}

		public virtual Guid GetSysModuleEntityId(Guid sysModuleId) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("SysModule");
			var entity = schema.CreateEntity(UserConnection);
			if (entity.FetchFromDB(sysModuleId)) {
				var columnName = schema.Columns.FindByName("SysModuleEntity").ColumnValueName;	
				return entity.GetTypedColumnValue<Guid>(columnName);
			} else {
				return Guid.Empty;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "SysPageSchemaEditChange":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
						}
						break;
					case "SysEntitySchemaEditChange":
							if (ActivatedEventElements.Contains("StartMessage6")) {
							context.QueueTasks.Enqueue("StartMessage6");
						}
						break;
					case "RequestAddDetailMessage":
							if (ActivatedEventElements.Contains("StartRequestAddDetailMessage")) {
							context.QueueTasks.Enqueue("StartRequestAddDetailMessage");
						}
						break;
					case "AllowAddDetailMessage":
							if (ActivatedEventElements.Contains("StartChildAllowAddDetailMessage")) {
							context.QueueTasks.Enqueue("StartChildAllowAddDetailMessage");
						}
						break;
					case "DataSourceSaved":
							if (ActivatedEventElements.Contains("StartChildDataSourceSaved")) {
							context.QueueTasks.Enqueue("StartChildDataSourceSaved");
							ProcessQueue(context);
							return;
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("StartMessage11")) {
							context.QueueTasks.Enqueue("StartMessage11");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("ChildInit")) {
							context.QueueTasks.Enqueue("ChildInit");
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
			if (!HasMapping("CloseWindowAfterSave") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CloseWindowAfterSave", CloseWindowAfterSave, false);
			}
			if (!HasMapping("NeedSendAllowMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedSendAllowMessage", NeedSendAllowMessage, false);
			}
			if (!HasMapping("SelectedDetailEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedDetailEntitySchemaId", SelectedDetailEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("SelectedPageSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedPageSchemaId", SelectedPageSchemaId, Guid.Empty);
			}
			if (!HasMapping("SelectedModuleEntityId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedModuleEntityId", SelectedModuleEntityId, Guid.Empty);
			}
			if (!HasMapping("SelectedModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedModuleId", SelectedModuleId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleDetailEditPageEventsProcess

	/// <exclude/>
	public class SysModuleDetailEditPageEventsProcess : SysModuleDetailEditPageEventsProcess<Terrasoft.WebApp.SysModuleDetailEditPageSchemaUserControl>
	{

		public SysModuleDetailEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleDetailEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleDetailEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LocalizableTextEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysPageSchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysPageSchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysEntitySchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysEntitySchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("TypeColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel OptionsPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("OptionsPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab AssociationTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("AssociationTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer DetailParentAsscContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("DetailParentAsscContainer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab SysModuleEditContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("SysModuleEditContainer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer SysModuleEditPageContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("SysModuleEditPageContainer", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SysPageSchemaEdit.AjaxEvents.Change.Event += SysPageSchemaEditChange;
			SysEntitySchemaEdit.AjaxEvents.Change.Event += SysEntitySchemaEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SysPageSchemaEdit.AjaxEvents.Change.Event -= SysPageSchemaEditChange;
			SysEntitySchemaEdit.AjaxEvents.Change.Event -= SysEntitySchemaEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleDetailEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleDetailEditPageEventsProcess(UserConnection);
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

		public virtual void SysPageSchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SysPageSchemaEditChange");
		}

		public virtual void SysEntitySchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SysEntitySchemaEditChange");
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
			SchemaName = "SysModuleDetailEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleDetailEditPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleDetailEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleDetailEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleDetailEditPageEventsProcessSchema(SysModuleDetailEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleDetailEditPageEventsProcess";
			UId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8");
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

		protected override ProcessSchemaParameter CreateSuccesfullCloseMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ddc06cd3-dd17-4f30-a93a-a0778ed58bc8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"SuccesfullCloseMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a40e1ec6-2561-455c-a1c6-79d176b06a37"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"SelectedModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedModuleEntityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0e25b0d0-c1d3-456c-9399-fade27040062"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"SelectedModuleEntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedPageSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("51c9b84f-c7c2-4087-bb00-1cc7ab72c55c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"SelectedPageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedDetailEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f5b7f5a7-5729-449f-9279-2b2cc3c42a89"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"SelectedDetailEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSendAllowMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1ff27f1c-acf2-44b8-adc0-fa6e1509bfb8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"NeedSendAllowMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCloseWindowAfterSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("771fa017-f565-4993-b4a6-f173fedcf1e5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"CloseWindowAfterSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSelectedModuleIdParameter());
			Parameters.Add(CreateSelectedModuleEntityIdParameter());
			Parameters.Add(CreateSelectedPageSchemaIdParameter());
			Parameters.Add(CreateSelectedDetailEntitySchemaIdParameter());
			Parameters.Add(CreateNeedSendAllowMessageParameter());
			Parameters.Add(CreateCloseWindowAfterSaveParameter());
		}

		protected virtual void InitializeAllowAddDetailUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f9f55bf6-ee60-4e3b-8532-4a7d87b02bcd"),
				ContainerUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
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
				UId = new Guid("22a61d11-51d0-4174-b681-e1748d3d23ff"),
				ContainerUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
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
				UId = new Guid("1e86ad42-1f82-4593-82b9-25eb114e668d"),
				ContainerUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
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
				UId = new Guid("4b44f694-1513-4603-a2f0-d01490775d66"),
				ContainerUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
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
				UId = new Guid("49d6df34-4461-4d7f-b7c5-bff957f803d1"),
				ContainerUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
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
				UId = new Guid("c284c7eb-1898-4be0-a867-2063b39daa18"),
				ContainerUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
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
				UId = new Guid("e0eea077-7fdf-475a-98f4-705ec92e34db"),
				ContainerUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
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
				UId = new Guid("ba31f20c-2764-4d1b-8964-d3c96b6e3ac7"),
				ContainerUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
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

		protected virtual void InitializeDetailTreeGridLoadRowUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ed80716a-a68a-487a-bdbd-266e79a52aea"),
				ContainerUId = new Guid("780c652d-ff96-4fb7-a7a6-41bb105f1b3f"),
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
				UId = new Guid("7f378750-9503-4ef9-a636-a44070963c6b"),
				ContainerUId = new Guid("780c652d-ff96-4fb7-a7a6-41bb105f1b3f"),
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
				UId = new Guid("83d1e111-5492-4937-a983-348eed952fee"),
				ContainerUId = new Guid("780c652d-ff96-4fb7-a7a6-41bb105f1b3f"),
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
				UId = new Guid("61706ccb-4517-4832-adea-5784f735678b"),
				ContainerUId = new Guid("780c652d-ff96-4fb7-a7a6-41bb105f1b3f"),
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
			ProcessSchemaLaneSet schemaLaneSet176 = CreateLaneSet176LaneSet();
			LaneSets.Add(schemaLaneSet176);
			ProcessSchemaLane schemaLane467 = CreateLane467Lane();
			schemaLaneSet176.Lanes.Add(schemaLane467);
			ProcessSchemaLane schemaLane468 = CreateLane468Lane();
			schemaLaneSet176.Lanes.Add(schemaLane468);
			ProcessSchemaLane schemaLane469 = CreateLane469Lane();
			schemaLaneSet176.Lanes.Add(schemaLane469);
			ProcessSchemaLane schemaLane470 = CreateLane470Lane();
			schemaLaneSet176.Lanes.Add(schemaLane470);
			ProcessSchemaLane schemaLane471 = CreateLane471Lane();
			schemaLaneSet176.Lanes.Add(schemaLane471);
			ProcessSchemaLane schemaLane472 = CreateLane472Lane();
			schemaLaneSet176.Lanes.Add(schemaLane472);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess childiniteventsubprocess = CreateChildInitEventSubProcessEventSubProcess();
			FlowElements.Add(childiniteventsubprocess);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess5.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess5.FlowElements.Add(scripttask2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess5.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess5.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess7.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess7.FlowElements.Add(scripttask4);
			ProcessSchemaStartMessageEvent startmessage6 = CreateStartMessage6StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage6);
			ProcessSchemaScriptTask scripttask6 = CreateScriptTask6ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask6);
			ProcessSchemaStartMessageEvent startrequestadddetailmessage = CreateStartRequestAddDetailMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(startrequestadddetailmessage);
			ProcessSchemaScriptTask scripttask7 = CreateScriptTask7ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask7);
			ProcessSchemaUserTask allowadddetailusertask = CreateAllowAddDetailUserTaskUserTask();
			eventsubprocess10.FlowElements.Add(allowadddetailusertask);
			ProcessSchemaStartMessageEvent startchildallowadddetailmessage = CreateStartChildAllowAddDetailMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(startchildallowadddetailmessage);
			ProcessSchemaScriptTask scripttask8 = CreateScriptTask8ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask8);
			ProcessSchemaScriptTask scripttask10 = CreateScriptTask10ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask10);
			ProcessSchemaStartMessageEvent startchilddatasourcesaved = CreateStartChildDataSourceSavedStartMessageEvent();
			eventsubprocess11.FlowElements.Add(startchilddatasourcesaved);
			ProcessSchemaScriptTask scripttask11 = CreateScriptTask11ScriptTask();
			eventsubprocess11.FlowElements.Add(scripttask11);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess11.FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask detailtreegridloadrowusertask = CreateDetailTreeGridLoadRowUserTaskUserTask();
			eventsubprocess11.FlowElements.Add(detailtreegridloadrowusertask);
			ProcessSchemaScriptTask scripttask12 = CreateScriptTask12ScriptTask();
			eventsubprocess11.FlowElements.Add(scripttask12);
			ProcessSchemaStartMessageEvent startmessage11 = CreateStartMessage11StartMessageEvent();
			eventsubprocess12.FlowElements.Add(startmessage11);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess12.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask scripttask13 = CreateScriptTask13ScriptTask();
			eventsubprocess12.FlowElements.Add(scripttask13);
			ProcessSchemaStartMessageEvent childinit = CreateChildInitStartMessageEvent();
			childiniteventsubprocess.FlowElements.Add(childinit);
			ProcessSchemaIntermediateThrowMessageEvent baseinit = CreateBaseInitIntermediateThrowMessageEvent();
			childiniteventsubprocess.FlowElements.Add(baseinit);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			childiniteventsubprocess.FlowElements.Add(scriptchildinit);
			FlowElements.Add(CreateSequenceFlow3117SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3119SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3120SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3121SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3122SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3125SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3126SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3127SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3128SequenceFlow());
			FlowElements.Add(CreateConditionalFlow66ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3130SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3131SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3132SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3133SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3136SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3137SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNewRecordNotSavedMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNewRecordNotSavedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8ca10811-4719-4d11-81fe-a2cd7f9fb333"),
				Name = "NewRecordNotSavedMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3117SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3117",
				UId = new Guid("7088791b-1551-4426-8262-cd5d12a0acf8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(192, 246),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8ebe34e3-ce4d-4afa-9c51-dc22c7d8676c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("961a61ab-b95d-4fdd-99ed-b94f04a3c969"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3119SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3119",
				UId = new Guid("38f50660-54da-40f3-8c6b-245b8f31f8ab"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e51b23cb-48a1-4d07-9b4c-4e9f3526aa60"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87677a3a-7dd2-4ea7-af87-0382e4586999"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3120SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3120",
				UId = new Guid("2c408c6a-4e85-4a68-b479-36ab04343ea6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d6bffd25-0874-4f98-8ee5-ba5218a3a04a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d462202-28b1-44e5-b4f3-20d3701909d1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3121SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3121",
				UId = new Guid("c5013049-d2ba-4135-8671-e5072a620cf9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(162, 393),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0c8dd0f7-e559-44f6-bebb-cb12b03ca9ac"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e5939809-be81-430c-85c2-de1658430cc5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3122SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3122",
				UId = new Guid("7df63a0d-ccdb-479c-be5b-3df0871a9781"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(274, 394),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e5939809-be81-430c-85c2-de1658430cc5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3125SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3125",
				UId = new Guid("cabf5901-09f0-490d-8de9-b1a9e388a3b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(228, 547),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("011c3c70-c151-4b51-9cca-fedabf19808a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b46be345-2403-46c4-88ee-d0e7862e51be"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3126SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3126",
				UId = new Guid("f1c013f1-6d0d-439f-ac2e-de7fdbff7016"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(228, 547),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d6e0dba-c035-4cfc-973c-c3af0fb4e239"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("011c3c70-c151-4b51-9cca-fedabf19808a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3127SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3127",
				UId = new Guid("58bb811e-6a70-4ee7-8ce6-69ff8b4a1036"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(162, 250),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("030bee36-41eb-4d1a-bf06-62d02603e2fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c1e78a94-0c98-4240-8c5e-212b78b48daf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3128SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3128",
				UId = new Guid("8c23e6fb-bffb-4028-9afd-a228c1017e3c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(274, 246),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c1e78a94-0c98-4240-8c5e-212b78b48daf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8ca63a06-0f5b-40dd-8d56-dd12a58a44ca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow66ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow66",
				UId = new Guid("e0c5d5a9-1ce4-420c-a972-7c10cb47ff23"),
				ConditionExpression = @"NeedRefreshGrid",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(374, 244),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8ca63a06-0f5b-40dd-8d56-dd12a58a44ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("780c652d-ff96-4fb7-a7a6-41bb105f1b3f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3130SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3130",
				UId = new Guid("1802066f-cfe2-4851-9256-120bab5cafac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(494, 248),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("780c652d-ff96-4fb7-a7a6-41bb105f1b3f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0ef6c56a-4188-4ada-a069-682122297027"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3131SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3131",
				UId = new Guid("a051d4de-f08b-42b4-8b75-b3235d0e7918"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(452, 256),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8ca63a06-0f5b-40dd-8d56-dd12a58a44ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0ef6c56a-4188-4ada-a069-682122297027"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3132SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3132",
				UId = new Guid("c3925d36-0745-427c-8317-5bcf7696c693"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("56842afe-0748-4544-9451-9ef021c85f03"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("785b8075-10be-4d53-a2c0-49c20f1915bf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3133SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3133",
				UId = new Guid("f8c61cbd-b181-453a-89a6-6d4e8398b018"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f175cee-a672-45e9-916a-b286080356c8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("56842afe-0748-4544-9451-9ef021c85f03"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3136SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3136",
				UId = new Guid("f669b261-a747-4052-8954-7e7e0f5f9fc3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(150, 798),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("063f3402-b805-49b5-9461-98938cbe4c64"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("65fb2ea8-10ed-487c-b410-e891191a13f8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3137SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3137",
				UId = new Guid("5706c6a7-81ad-459c-9cbd-e85c2142cb84"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(231, 795),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("65fb2ea8-10ed-487c-b410-e891191a13f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ec0784de-48a5-4479-b77e-10005876bd86"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("734743f4-42c6-4a71-abda-0f6928c331f4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(232, 422),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("11a0ee4f-7ed3-42f5-b390-2ef0525fb319"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8ebe34e3-ce4d-4afa-9c51-dc22c7d8676c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("79e42a2f-9b0f-4ead-9a8f-82d29b0f6644"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CurveCenterPosition = new Point(232, 422),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("93193c2c-9eba-4034-be4e-602808e9ea6e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("11a0ee4f-7ed3-42f5-b390-2ef0525fb319"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet176LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet176 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("28cc5d0d-ec18-40d8-a013-04c2395b20fb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"LaneSet176",
				Position = new Point(5, 5),
				Size = new Size(859, 1090),
				UseBackgroundMode = false
			};
			return schemaLaneSet176;
		}

		protected virtual ProcessSchemaLane CreateLane467Lane() {
			ProcessSchemaLane schemaLane467 = new ProcessSchemaLane(this) {
				UId = new Guid("93a27187-e536-4823-9cd0-bcf301e10098"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("28cc5d0d-ec18-40d8-a013-04c2395b20fb"),
				CreatedInOwnerSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"Lane467",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 329),
				Size = new Size(830, 370),
				UseBackgroundMode = false
			};
			return schemaLane467;
		}

		protected virtual ProcessSchemaLane CreateLane468Lane() {
			ProcessSchemaLane schemaLane468 = new ProcessSchemaLane(this) {
				UId = new Guid("8f8ffda8-3fb4-4338-85eb-5b392847be06"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("28cc5d0d-ec18-40d8-a013-04c2395b20fb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"Lane468",
				Position = new Point(29, 179),
				Size = new Size(830, 145),
				UseBackgroundMode = false
			};
			return schemaLane468;
		}

		protected virtual ProcessSchemaLane CreateLane469Lane() {
			ProcessSchemaLane schemaLane469 = new ProcessSchemaLane(this) {
				UId = new Guid("7ad8ffcb-0a3a-43ad-b975-fb0b3828bbe8"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("28cc5d0d-ec18-40d8-a013-04c2395b20fb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"Lane469",
				Position = new Point(29, 29),
				Size = new Size(830, 145),
				UseBackgroundMode = false
			};
			return schemaLane469;
		}

		protected virtual ProcessSchemaLane CreateLane470Lane() {
			ProcessSchemaLane schemaLane470 = new ProcessSchemaLane(this) {
				UId = new Guid("d989b15e-0810-4e4f-b0c1-06a2937e9690"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("28cc5d0d-ec18-40d8-a013-04c2395b20fb"),
				CreatedInOwnerSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"Lane470",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 705),
				Size = new Size(830, 210),
				UseBackgroundMode = false
			};
			return schemaLane470;
		}

		protected virtual ProcessSchemaLane CreateLane471Lane() {
			ProcessSchemaLane schemaLane471 = new ProcessSchemaLane(this) {
				UId = new Guid("5c1d87cf-3f22-4c03-994b-e0eb37a78764"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("28cc5d0d-ec18-40d8-a013-04c2395b20fb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"Lane471",
				Position = new Point(29, 0),
				Size = new Size(830, 144),
				UseBackgroundMode = false
			};
			return schemaLane471;
		}

		protected virtual ProcessSchemaLane CreateLane472Lane() {
			ProcessSchemaLane schemaLane472 = new ProcessSchemaLane(this) {
				UId = new Guid("8c2c7523-d75a-45de-8871-1df87922472b"),
				ContainerItemIndex = 6,
				ContainerUId = new Guid("28cc5d0d-ec18-40d8-a013-04c2395b20fb"),
				CreatedInOwnerSchemaUId = new Guid("768e1b97-01fe-44ec-875c-b3d366e32d36"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"Lane472",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 920),
				Size = new Size(830, 170),
				UseBackgroundMode = false
			};
			return schemaLane472;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("082e778c-f5db-4f5e-9f11-d7164073b08c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("93a27187-e536-4823-9cd0-bcf301e10098"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(423, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("93193c2c-9eba-4034-be4e-602808e9ea6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("082e778c-f5db-4f5e-9f11-d7164073b08c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("961a61ab-b95d-4fdd-99ed-b94f04a3c969"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("082e778c-f5db-4f5e-9f11-d7164073b08c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(323, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,81,79,219,48,16,126,30,210,254,67,232,3,74,165,202,226,157,13,169,180,25,170,54,88,71,219,241,128,208,100,146,43,245,150,196,153,237,0,217,196,127,223,217,78,91,59,73,39,58,246,150,216,119,223,125,119,254,206,190,25,164,16,43,72,46,120,82,166,16,229,138,169,106,146,4,239,131,115,80,179,74,250,203,225,204,179,158,36,253,147,183,7,108,25,132,83,122,15,100,76,21,157,241,82,196,64,174,248,163,36,35,94,230,42,56,13,142,251,193,239,183,7,111,30,168,8,192,0,33,122,151,195,205,241,237,73,109,87,224,246,44,94,65,70,71,60,45,179,28,61,172,43,177,171,196,46,75,130,44,207,170,75,154,65,216,219,176,61,23,44,233,245,215,80,217,102,205,164,85,195,160,223,188,42,32,177,56,95,105,90,194,187,243,146,37,167,97,51,52,113,76,116,160,13,176,69,178,166,23,52,71,55,177,78,172,38,233,237,77,5,127,96,9,8,29,186,94,10,123,81,27,163,215,15,168,12,230,32,4,149,124,169,48,188,0,98,236,24,72,210,225,208,197,231,75,9,66,151,57,135,199,32,106,174,135,29,204,7,193,174,250,53,235,161,107,176,169,163,131,74,134,73,93,77,115,20,211,141,219,98,130,104,68,187,249,71,226,242,218,11,218,213,36,105,129,195,127,129,197,127,151,95,59,7,133,234,177,206,184,247,239,113,230,46,140,19,162,13,242,129,165,10,132,212,96,97,123,119,36,128,42,176,54,215,76,173,166,84,32,146,118,8,237,226,136,103,5,21,76,242,92,135,36,209,207,146,166,131,0,35,117,132,186,226,92,213,18,70,177,78,5,203,168,168,182,57,134,253,129,215,85,125,191,37,80,166,157,85,64,40,155,52,34,233,91,132,241,60,92,72,205,44,207,237,111,135,230,182,61,139,176,120,65,236,209,184,59,155,117,15,204,110,49,245,79,130,46,21,188,24,117,135,118,12,89,109,177,105,144,245,93,252,50,216,191,181,149,193,182,119,147,219,155,81,194,20,153,129,50,48,195,60,153,195,147,10,221,234,15,204,59,96,126,198,76,22,41,173,140,169,103,211,247,192,221,248,157,240,254,81,236,10,224,91,217,16,235,215,103,234,203,195,229,226,154,141,65,81,150,70,157,39,95,185,14,216,33,233,182,17,53,233,102,120,109,165,223,185,134,140,14,241,153,196,210,147,40,43,240,85,59,58,106,232,193,219,182,143,160,81,141,52,254,72,197,151,127,215,229,174,143,123,146,75,69,243,24,206,42,4,237,98,214,144,34,2,203,142,87,82,59,123,252,172,175,57,55,63,251,214,145,109,221,200,66,31,153,243,63,162,197,166,117,159,29,25,212,183,28,162,233,21,76,18,207,34,199,124,244,223,58,33,130,111,98,12,82,234,120,248,89,128,80,245,233,55,239,73,188,27,7,126,87,232,128,207,118,248,56,156,200,75,124,231,176,252,248,53,226,69,93,106,59,98,24,13,224,109,136,101,27,74,25,239,79,164,22,211,37,79,192,187,9,205,62,178,178,4,219,91,94,83,188,182,26,175,33,129,85,218,167,20,243,149,224,143,209,3,26,133,61,125,191,235,205,43,88,10,144,43,28,210,204,92,176,87,86,47,197,251,252,241,172,84,10,187,96,248,157,62,25,123,156,32,83,22,255,64,137,149,18,36,230,195,18,170,181,134,250,86,162,212,207,164,214,61,149,133,246,95,143,94,195,250,215,155,161,22,19,114,13,119,154,160,224,169,52,252,208,187,246,36,163,82,42,158,233,97,244,102,171,187,111,20,123,242,1,182,35,106,239,182,99,108,69,130,72,116,50,94,39,81,119,131,105,162,79,60,70,202,191,232,93,10,186,137,208,27,5,225,206,117,249,146,221,151,194,164,132,127,89,198,243,133,98,169,157,243,176,99,29,127,43,3,255,182,24,180,200,212,79,182,190,238,113,156,171,169,244,218,118,67,147,25,22,191,91,47,2,84,41,114,91,226,63,115,212,189,199,30,12,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("8ebe34e3-ce4d-4afa-9c51-dc22c7d8676c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("082e778c-f5db-4f5e-9f11-d7164073b08c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("11a0ee4f-7ed3-42f5-b390-2ef0525fb319"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("082e778c-f5db-4f5e-9f11-d7164073b08c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,141,177,10,194,64,16,5,123,193,127,88,82,93,154,252,64,176,148,112,133,16,8,196,122,201,62,194,97,188,200,238,158,144,191,55,138,88,89,78,49,51,79,86,178,205,46,171,148,5,49,95,87,189,217,131,39,68,161,19,117,37,73,211,179,26,66,207,51,154,14,190,19,223,225,208,145,151,130,80,237,140,236,231,236,201,183,40,85,77,108,100,174,41,207,117,123,60,12,88,48,57,228,155,255,52,225,195,239,39,225,255,251,237,42,188,104,38,215,130,246,5,79,253,239,250,166,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("82544d01-f667-49ed-a763-ff92c08ad9b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f8ffda8-3fb4-4338-85eb-5b392847be06"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"EventSubProcess7",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(177, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e51b23cb-48a1-4d07-9b4c-4e9f3526aa60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82544d01-f667-49ed-a763-ff92c08ad9b4"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysPageSchemaEditChange",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"StartMessage4",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("87677a3a-7dd2-4ea7-af87-0382e4586999"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82544d01-f667-49ed-a763-ff92c08ad9b4"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask4",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,141,177,10,195,32,16,134,119,159,226,198,100,241,1,42,210,161,132,210,173,96,232,46,241,72,5,53,162,39,105,222,190,173,82,178,180,221,142,143,239,191,47,83,178,97,6,66,31,85,59,37,92,245,140,252,164,35,217,37,12,198,18,31,241,65,130,125,197,47,61,215,29,31,124,164,237,183,181,23,4,83,232,112,34,52,111,87,77,119,244,250,98,62,93,181,229,29,215,7,55,237,10,130,148,16,138,115,112,132,115,177,166,213,224,0,1,215,10,186,127,99,62,46,45,221,245,189,96,9,169,164,0,148,10,138,39,170,135,106,162,255,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b44509f5-802b-4529-bda2-21de371e55e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ad8ffcb-0a3a-43ad-b975-fb0b3828bbe8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"EventSubProcess9",
				Position = new Point(36, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(177, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d6bffd25-0874-4f98-8ee5-ba5218a3a04a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b44509f5-802b-4529-bda2-21de371e55e2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysEntitySchemaEditChange",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"StartMessage6",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask6ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3d462202-28b1-44e5-b4f3-20d3701909d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b44509f5-802b-4529-bda2-21de371e55e2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask6",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,193,10,194,48,16,68,239,253,138,61,182,151,124,128,161,120,168,85,188,9,41,222,67,179,212,192,38,13,233,6,205,223,91,82,68,15,234,109,153,157,153,55,11,71,235,39,96,116,65,109,103,11,23,61,161,232,116,96,59,251,222,88,22,3,62,88,86,95,229,213,190,148,156,232,93,224,252,219,245,38,200,74,33,225,200,104,14,200,218,82,239,217,114,86,227,13,157,62,155,23,95,229,229,243,81,170,174,154,18,66,219,130,79,68,176,135,83,178,102,227,194,14,60,222,139,80,255,143,139,97,222,102,212,77,35,171,163,37,26,114,192,110,166,228,202,222,250,223,184,53,17,145,83,244,192,49,161,124,2,77,120,212,242,61,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e98f76d1-def1-4e56-b36c-7b5b45dee35c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("93a27187-e536-4823-9cd0-bcf301e10098"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 142),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(320, 214),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartRequestAddDetailMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0c8dd0f7-e559-44f6-bebb-cb12b03ca9ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e98f76d1-def1-4e56-b36c-7b5b45dee35c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RequestAddDetailMessage",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"StartRequestAddDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask7ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e5939809-be81-430c-85c2-de1658430cc5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e98f76d1-def1-4e56-b36c-7b5b45dee35c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,77,11,130,64,16,134,207,249,43,150,61,75,127,160,15,40,236,208,161,181,212,14,29,23,247,37,36,153,141,221,49,19,241,191,167,233,37,194,185,12,204,60,207,59,48,10,48,41,200,236,202,210,214,39,120,175,239,16,27,193,174,194,42,248,14,119,198,68,96,93,148,87,15,151,105,255,88,158,71,102,104,179,204,20,149,225,205,61,170,80,39,200,173,51,202,114,170,95,48,211,122,86,63,230,150,122,79,94,174,135,52,59,198,74,206,146,251,138,217,146,31,224,219,33,85,241,60,153,192,63,123,18,211,237,65,33,212,34,42,114,46,44,105,215,172,61,187,130,238,161,24,251,86,180,173,108,224,101,40,228,111,228,148,32,187,48,88,252,85,43,201,14,74,4,106,254,141,110,21,56,112,229,104,124,241,7,54,66,65,165,127,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateAllowAddDetailUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("03c7d207-a4ee-4979-a324-338f7e820eae"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e98f76d1-def1-4e56-b36c-7b5b45dee35c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"AllowAddDetailUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 37),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeAllowAddDetailUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartChildAllowAddDetailMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3d6e0dba-c035-4cfc-973c-c3af0fb4e239"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e98f76d1-def1-4e56-b36c-7b5b45dee35c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AllowAddDetailMessage",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"StartChildAllowAddDetailMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 142),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask8ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b46be345-2403-46c4-88ee-d0e7862e51be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e98f76d1-def1-4e56-b36c-7b5b45dee35c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,118,206,201,76,206,246,77,45,201,200,79,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,214,240,155,235,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask10ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("011c3c70-c151-4b51-9cca-fedabf19808a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e98f76d1-def1-4e56-b36c-7b5b45dee35c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,201,47,78,13,207,204,75,201,47,119,76,43,73,45,10,78,44,75,85,176,85,72,75,204,41,78,181,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,250,49,71,221,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("53c66c3a-1f8e-476f-8ae4-471c7478623a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d989b15e-0810-4e4f-b0c1-06a2937e9690"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(545, 182),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartChildDataSourceSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("030bee36-41eb-4d1a-bf06-62d02603e2fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53c66c3a-1f8e-476f-8ae4-471c7478623a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"StartChildDataSourceSaved",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask11ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c1e78a94-0c98-4240-8c5e-212b78b48daf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53c66c3a-1f8e-476f-8ae4-471c7478623a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,93,107,2,49,16,124,86,232,127,136,62,41,72,126,64,69,74,185,19,17,164,136,119,246,125,235,237,217,165,185,228,216,219,179,181,165,255,189,185,15,81,169,98,155,167,36,59,51,59,155,9,165,106,176,132,45,234,16,4,34,87,242,6,245,227,70,104,135,43,247,222,155,40,91,26,51,84,95,119,221,206,146,41,3,222,135,84,228,6,246,129,51,101,102,159,193,148,168,38,157,171,10,250,42,107,124,148,252,167,214,185,200,247,93,247,9,49,89,97,202,88,188,206,152,18,53,81,41,152,162,42,238,128,149,48,98,117,61,175,10,181,248,12,101,9,12,25,10,114,45,51,232,31,65,253,161,154,52,99,171,7,21,9,147,221,234,105,150,203,94,221,123,199,237,250,139,140,142,93,67,31,12,189,147,162,222,170,50,79,64,106,136,31,40,218,48,229,226,93,157,182,241,88,242,153,156,184,238,157,3,154,52,66,20,32,19,183,168,133,131,74,112,93,32,199,80,188,233,202,95,59,237,248,38,248,112,31,24,66,43,243,208,19,143,221,111,211,47,133,168,166,86,72,246,23,3,235,252,142,75,248,16,101,140,204,80,184,84,116,224,108,74,219,146,65,200,89,127,202,50,103,215,66,134,132,176,208,17,236,112,225,54,96,232,19,94,12,54,207,127,245,231,140,154,220,3,200,43,177,105,66,162,79,200,49,126,200,72,245,219,106,191,74,139,81,74,182,141,175,31,242,79,26,153,34,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("8ca63a06-0f5b-40dd-8d56-dd12a58a44ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53c66c3a-1f8e-476f-8ae4-471c7478623a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateDetailTreeGridLoadRowUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("780c652d-ff96-4fb7-a7a6-41bb105f1b3f"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53c66c3a-1f8e-476f-8ae4-471c7478623a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"DetailTreeGridLoadRowUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(316, 53),
				SchemaUId = new Guid("f75d2775-3c53-40fc-b123-f437981440a5"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeDetailTreeGridLoadRowUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask12ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0ef6c56a-4188-4ada-a069-682122297027"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53c66c3a-1f8e-476f-8ae4-471c7478623a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(442, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,97,75,195,48,16,134,63,111,224,127,56,247,169,5,201,15,80,167,140,57,100,224,230,176,83,63,103,237,85,35,89,50,46,215,141,33,254,119,175,201,196,138,243,131,80,104,147,123,223,235,155,231,98,106,200,230,136,85,129,174,26,89,235,119,51,12,65,191,96,14,239,39,253,158,145,234,66,86,234,6,89,27,187,208,132,142,71,33,148,99,239,100,195,33,169,182,60,117,129,181,43,17,78,135,224,26,107,147,185,247,15,167,90,144,47,229,207,170,64,150,207,13,18,239,159,180,109,48,27,20,104,177,100,172,230,190,194,5,153,181,166,253,216,219,102,237,98,125,112,6,19,199,134,247,191,75,249,197,127,67,44,95,201,239,38,91,17,101,131,8,99,84,85,201,122,160,50,72,61,143,1,131,33,212,218,6,108,5,31,39,125,121,90,120,167,99,235,3,62,27,87,73,179,154,145,10,189,61,176,37,228,134,28,48,53,173,231,160,47,154,82,48,212,194,48,26,191,122,255,224,186,213,4,101,183,58,132,227,54,181,244,5,147,113,47,89,140,29,243,132,184,161,166,97,46,226,123,154,172,55,188,207,186,221,242,252,123,118,145,199,216,26,1,146,168,116,133,103,224,112,7,119,38,240,165,95,189,201,136,174,178,60,255,121,250,150,211,3,214,132,225,245,150,76,245,29,63,148,100,54,44,193,179,163,121,4,187,97,227,157,182,69,20,118,200,93,195,193,17,149,112,14,127,107,219,44,241,24,169,48,211,78,22,164,196,144,54,178,148,34,79,244,211,61,31,133,77,251,6,29,96,137,68,58,248,154,213,227,84,61,227,170,189,51,228,109,136,87,38,87,17,116,4,219,29,228,39,138,82,183,131,79,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b3888c95-c748-467f-a850-a7d9e4e1117e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c1d87cf-3f22-4c03-994b-e0eb37a78764"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"EventSubProcess12",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(244, 120),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage11StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2f175cee-a672-45e9-916a-b286080356c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3888c95-c748-467f-a850-a7d9e4e1117e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"StartMessage11",
				Position = new Point(14, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("785b8075-10be-4d53-a2c0-49c20f1915bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3888c95-c748-467f-a850-a7d9e4e1117e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"IntermediateThrowMessageEvent2",
				Position = new Point(182, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask13ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("56842afe-0748-4544-9451-9ef021c85f03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3888c95-c748-467f-a850-a7d9e4e1117e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptTask13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 27),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,77,77,9,78,205,75,113,204,201,201,47,247,77,45,46,78,76,79,85,176,85,72,75,204,41,78,181,230,114,206,201,47,78,13,207,204,75,201,47,119,76,43,73,45,10,78,44,3,201,150,20,149,2,37,139,82,75,74,139,242,32,28,0,89,177,82,134,71,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateChildInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaChildInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7e7c8674-4e12-4fdf-87d6-2390d36a2687"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c2c7523-d75a-45de-8871-1df87922472b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ChildInitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(291, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaChildInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("063f3402-b805-49b5-9461-98938cbe4c64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e7c8674-4e12-4fdf-87d6-2390d36a2687"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("65fb2ea8-10ed-487c-b410-e891191a13f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e7c8674-4e12-4fdf-87d6-2390d36a2687"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"BaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ec0784de-48a5-4479-b77e-10005876bd86"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e7c8674-4e12-4fdf-87d6-2390d36a2687"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,203,110,212,48,20,93,119,164,249,135,171,172,250,136,28,33,160,20,77,91,169,154,6,132,4,40,162,20,22,136,133,73,238,100,204,56,78,176,157,66,52,138,4,101,9,18,123,62,163,42,82,161,168,252,130,243,71,216,201,80,134,5,172,168,52,139,89,68,150,173,115,239,57,62,190,57,17,77,145,28,84,42,178,235,65,60,198,140,134,9,211,36,146,88,80,137,247,243,124,82,22,119,24,215,40,97,99,7,18,228,152,82,141,176,154,191,120,137,177,6,133,34,65,233,67,7,116,165,225,17,10,189,39,83,5,184,6,211,126,111,101,152,115,110,161,44,23,219,251,172,93,169,172,182,149,150,76,164,62,116,125,118,119,97,212,146,40,216,1,36,29,161,26,216,234,32,48,159,205,133,57,245,193,124,51,23,205,177,253,222,54,31,204,215,118,107,190,155,31,230,204,156,155,51,123,248,222,124,105,142,155,119,205,39,112,40,115,222,124,116,16,48,39,240,52,151,19,85,208,24,97,248,232,218,173,235,55,55,183,108,227,25,31,217,75,146,85,129,175,225,239,218,96,10,22,191,50,245,226,60,179,166,48,149,139,199,85,129,158,15,157,206,225,31,199,36,124,85,82,94,251,179,26,142,35,29,190,41,36,42,101,187,91,47,202,76,68,84,143,109,181,103,109,191,148,70,238,37,94,237,119,53,165,194,125,166,10,78,171,39,148,151,142,104,68,185,194,203,158,146,165,227,185,166,17,149,52,67,43,164,69,43,11,119,247,233,196,63,123,14,83,247,180,228,80,57,161,66,116,47,65,230,121,235,186,94,27,44,134,35,15,168,176,98,229,67,123,159,171,114,195,251,61,233,51,54,239,151,1,65,224,230,227,198,214,237,77,183,89,95,4,67,218,63,51,158,184,23,188,186,1,185,91,178,132,132,89,161,171,214,137,245,160,223,171,173,31,253,94,52,11,135,80,104,166,171,69,140,135,101,66,44,19,226,191,39,196,252,184,47,51,226,159,25,33,81,151,82,128,150,37,14,126,2,120,73,106,28,75,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetSchemaDisplayValueMethod());
			Methods.Add(CreateGetSysModuleGridIdMethod());
			Methods.Add(CreateGetDetailSysModuleEntityIdMethod());
			Methods.Add(CreateFillTypeColumnEditMethod());
			Methods.Add(CreateGetSysModuleIdMethod());
			Methods.Add(CreateGetSysModuleEntityIdMethod());
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
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6ad4b694-5a68-4f8e-93c8-16a6bd0f77d3"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d3fb8cf1-e005-49ff-9f3d-b44f37d3bade"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,203,110,219,48,16,60,203,128,255,129,224,73,66,12,162,231,4,61,24,114,97,56,232,35,176,147,250,144,228,192,82,43,123,17,154,20,150,148,221,212,208,191,151,164,228,52,77,129,36,232,77,220,157,157,153,29,138,206,19,154,13,83,178,241,104,13,251,200,174,228,6,68,217,31,63,85,232,197,103,171,164,198,95,242,135,134,107,248,233,197,28,124,217,106,223,18,124,151,186,133,252,198,1,149,214,24,80,113,36,182,175,8,119,146,30,7,212,194,212,54,47,138,139,241,104,47,137,41,107,246,64,30,200,5,45,3,7,118,233,172,41,79,197,219,123,118,140,197,121,139,213,95,141,188,232,2,129,235,205,98,21,102,99,91,172,128,48,154,131,60,217,158,73,47,87,182,37,5,98,26,220,236,97,105,15,226,228,198,234,118,103,146,229,201,51,23,183,31,238,163,181,52,190,82,132,141,255,34,77,56,144,152,86,85,95,248,135,187,212,8,198,47,102,236,140,141,71,89,198,133,53,79,114,207,100,92,185,149,102,3,213,18,92,99,141,131,156,39,120,152,10,11,156,49,62,57,222,241,33,232,59,206,206,217,81,253,153,61,103,124,192,190,216,115,184,168,34,18,116,93,113,193,163,251,175,16,85,106,2,183,157,83,74,199,83,11,161,129,117,190,112,165,109,30,139,99,160,251,223,37,185,112,114,15,249,32,214,141,71,160,29,68,66,172,89,94,106,235,96,141,166,178,135,105,29,18,93,5,104,193,98,247,117,189,8,200,120,100,224,65,226,85,117,249,116,151,59,91,97,141,80,245,249,6,153,62,210,44,123,131,97,240,207,248,112,101,25,239,88,92,130,29,217,33,89,23,42,174,17,33,93,10,62,46,154,157,48,111,238,242,238,236,178,16,222,120,244,226,197,76,155,70,163,146,241,187,148,106,11,98,141,126,155,94,93,60,134,31,62,191,6,34,233,108,237,69,24,171,113,211,82,66,139,4,191,241,168,209,35,56,177,182,244,224,26,169,32,213,231,100,219,166,16,209,252,10,252,55,90,194,206,238,135,55,251,78,194,25,120,137,218,165,234,132,153,86,235,244,3,252,6,216,238,64,120,52,4,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateBeforeSaveRowOnConditionsCorrectMethod() {
			SchemaMethod method = base.CreateBeforeSaveRowOnConditionsCorrectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,205,79,41,205,73,117,47,202,76,81,176,85,112,79,45,9,174,44,246,133,11,121,166,104,104,90,115,21,229,151,235,5,167,150,56,231,231,148,230,230,133,37,230,148,166,106,40,161,41,83,210,65,50,8,168,5,0,33,210,123,242,90,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,200,79,202,74,77,46,177,83,72,73,77,11,75,204,41,77,45,86,176,85,72,74,44,78,213,115,79,45,113,129,137,105,104,90,115,193,21,68,43,5,87,22,251,230,167,148,230,164,42,197,2,85,7,167,230,0,77,72,77,129,8,121,166,88,115,21,165,150,148,22,229,33,140,180,6,0,127,249,67,81,120,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaDisplayValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5f6fb902-ba2d-4977-9618-2b3e61c0f125"),
				Name = "GetSchemaDisplayValue",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f45c26c6-e0af-490e-bc82-a2b8eba2ff55"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,146,205,106,213,64,20,199,215,22,250,14,135,184,73,32,204,189,69,236,85,212,130,196,171,116,97,123,219,94,219,133,184,24,146,115,219,193,100,38,158,153,180,4,17,250,177,84,112,239,99,72,11,213,74,125,133,201,27,57,211,196,171,53,119,237,34,12,249,207,255,252,230,124,13,6,48,221,124,182,9,119,87,70,195,213,135,163,229,165,67,78,128,210,8,83,239,164,7,88,240,151,92,242,125,36,120,2,19,119,178,86,100,183,238,38,164,14,69,134,196,94,160,233,164,48,24,247,25,65,4,92,195,20,137,184,86,51,195,18,69,200,110,124,2,53,91,16,240,168,159,206,86,133,84,187,100,36,30,193,248,95,61,92,144,120,12,193,238,209,78,173,91,113,93,206,84,16,117,220,148,151,70,40,153,168,188,42,228,6,47,208,113,123,111,177,167,89,214,58,194,32,105,3,130,136,121,183,163,244,221,207,69,110,144,180,143,10,251,183,9,33,55,216,122,246,132,57,152,112,114,32,31,16,182,98,162,138,146,147,208,74,78,235,210,53,231,93,197,243,120,121,233,78,31,181,173,148,233,134,225,218,62,33,81,112,170,255,148,18,70,49,16,166,138,178,245,44,242,5,15,6,246,139,189,182,231,49,216,239,246,186,57,117,223,113,243,209,126,187,249,181,63,236,79,123,105,175,236,165,19,207,236,69,115,218,156,52,159,193,187,236,85,243,201,91,192,126,133,61,69,111,117,201,83,132,100,123,101,116,239,254,234,131,255,216,130,192,13,113,158,64,16,195,43,237,189,82,98,234,103,194,230,87,172,43,120,190,57,110,185,22,14,214,181,173,221,32,215,181,188,165,132,183,161,30,35,102,16,254,198,184,141,173,164,129,53,24,70,240,222,165,68,104,42,146,243,87,94,15,223,120,168,79,187,91,153,93,158,87,248,88,27,18,114,127,45,236,237,155,231,127,0,204,53,254,141,107,237,108,92,148,166,246,134,95,216,172,23,240,163,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysModuleGridIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c463ed11-a833-42c8-b607-417631443c12"),
				Name = "GetSysModuleGridId",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,77,111,211,64,16,61,183,82,255,195,42,39,187,178,54,69,8,136,4,84,130,180,68,57,180,10,164,165,7,196,97,21,79,232,170,206,58,236,174,83,89,8,9,202,17,36,238,252,12,4,82,161,168,252,133,245,63,98,198,107,18,55,73,35,46,244,16,57,153,143,55,111,158,223,100,34,52,3,101,165,205,251,131,99,24,137,61,161,196,43,208,236,33,235,225,147,251,32,191,146,235,233,116,34,99,208,188,3,182,10,5,141,221,69,140,70,200,132,97,7,160,181,48,233,208,242,118,170,129,151,117,18,12,95,210,112,127,99,125,50,71,231,105,6,58,71,50,10,78,217,238,124,60,88,66,60,98,141,126,110,246,210,56,75,160,163,101,220,8,43,84,25,183,211,36,27,169,125,49,2,4,92,24,194,31,197,85,69,208,232,98,27,167,66,236,93,44,124,34,19,11,218,80,67,176,152,109,107,16,22,124,205,145,180,199,61,161,17,136,26,2,31,108,167,163,177,208,210,164,234,32,31,163,32,175,51,145,68,108,99,125,141,136,147,232,30,237,16,73,68,172,15,9,12,44,196,179,120,55,14,195,27,167,229,245,244,47,160,198,106,7,172,144,73,253,189,84,236,154,77,247,197,93,186,111,17,115,63,221,101,113,134,159,119,197,71,247,163,252,233,126,185,223,238,220,93,184,115,12,126,112,223,139,179,226,125,241,153,81,149,187,40,62,81,9,115,95,217,81,170,79,204,88,12,128,181,159,221,186,119,251,206,221,86,84,125,107,181,112,194,230,205,42,48,101,131,235,31,26,42,86,10,53,144,169,226,211,20,47,183,223,108,214,108,140,78,95,106,54,60,29,47,27,90,46,241,56,193,85,88,146,81,14,89,240,23,6,207,39,83,150,109,179,173,144,189,65,82,26,108,166,213,116,202,139,173,151,4,74,204,43,27,63,23,73,6,15,58,153,140,183,131,186,249,9,248,45,131,196,64,137,67,84,77,201,108,142,104,117,80,132,218,85,198,10,53,128,199,57,1,4,75,46,172,132,57,1,58,85,154,200,247,225,148,158,193,52,231,145,49,237,103,85,111,195,107,176,100,243,53,95,207,251,96,119,96,88,91,200,204,32,77,110,188,1,235,238,236,198,68,129,186,40,51,103,221,110,69,104,6,94,67,46,207,62,162,37,86,213,44,32,98,203,53,68,74,152,255,127,9,56,226,122,174,211,214,146,232,42,227,174,222,249,159,254,151,234,16,98,2,94,235,202,167,40,43,249,238,15,145,9,211,189,111,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDetailSysModuleEntityIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7297dae6-c9fc-4bee-88d8-51f8faeb82ce"),
				Name = "GetDetailSysModuleEntityId",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,83,203,110,19,49,20,93,183,82,255,193,157,69,229,145,34,167,80,1,149,128,74,52,77,171,44,90,74,147,210,5,98,97,101,110,26,171,19,79,176,61,137,70,168,18,148,37,72,236,249,12,4,82,161,168,252,130,243,71,92,143,39,205,91,162,136,13,44,162,137,239,227,220,227,115,174,123,92,17,144,70,152,172,222,108,67,135,239,115,201,79,65,145,199,228,16,191,204,7,217,68,238,80,37,61,17,129,98,123,96,138,16,13,170,179,24,65,72,184,38,13,80,138,235,164,101,88,37,81,192,242,58,1,154,205,105,120,184,178,220,155,162,243,44,5,149,33,25,9,125,82,157,142,211,57,196,75,36,168,103,122,63,137,210,24,124,67,16,22,184,34,170,36,113,218,145,7,188,3,8,57,51,134,61,137,138,10,26,212,162,32,100,174,16,123,103,11,119,69,108,64,105,215,64,103,179,21,5,220,128,175,57,17,166,125,200,21,2,185,6,234,131,149,164,211,229,74,232,68,54,178,46,74,242,42,229,113,137,172,44,47,57,234,227,183,60,70,26,37,82,135,24,154,6,162,29,48,92,196,227,249,90,20,134,227,162,161,174,115,47,134,70,249,54,188,158,195,18,137,164,199,218,17,145,210,31,29,140,104,17,58,132,65,179,82,105,200,22,89,15,201,107,100,230,70,232,28,113,106,64,33,187,27,81,147,218,112,217,132,237,204,9,71,231,250,176,52,50,24,129,60,98,33,152,175,154,195,107,105,47,21,17,57,131,108,56,26,249,189,88,127,233,70,58,253,10,207,158,243,56,133,71,174,116,139,142,59,157,35,248,137,108,23,76,179,189,171,146,206,206,54,69,188,60,229,110,157,175,186,195,242,109,213,72,24,150,227,145,85,92,189,52,142,201,218,26,89,213,70,9,121,202,106,250,0,35,79,85,181,211,69,186,11,91,89,35,169,231,13,52,12,189,134,67,22,117,48,99,148,105,48,234,246,126,47,132,204,249,158,143,174,83,231,61,160,121,208,191,213,27,189,177,195,69,80,70,220,24,137,238,184,211,208,30,134,239,183,9,90,59,30,248,183,11,202,100,5,147,41,199,114,54,67,157,110,53,162,209,86,73,191,218,67,158,52,216,83,34,114,201,35,104,41,208,237,163,164,239,55,65,129,73,149,116,248,120,58,39,16,107,248,251,171,230,183,198,109,5,59,128,190,251,210,63,94,195,145,125,59,208,26,115,80,211,169,244,132,187,19,34,46,168,185,253,179,71,176,114,217,126,178,215,246,75,137,216,239,246,122,112,129,191,55,131,247,246,91,126,180,63,236,79,123,105,175,236,37,6,223,217,175,131,139,193,219,193,71,226,170,236,213,224,131,43,33,246,51,57,73,212,153,238,242,38,144,202,209,157,7,27,247,238,111,150,138,127,155,119,145,110,185,188,152,240,77,107,78,118,82,46,118,147,100,158,43,33,228,159,123,103,163,141,252,93,64,119,131,255,249,141,254,2,120,93,151,196,44,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillTypeColumnEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4d597521-4978-431d-bbf0-91e5d8b8d4d7"),
				Name = "FillTypeColumnEdit",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c650218f-437b-41e6-a3c7-efc5f894ad2f"),
				Name = "entitySchemaId",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,65,106,195,48,16,60,219,175,16,62,217,80,244,128,134,30,218,52,4,67,83,2,113,123,95,164,77,34,98,75,70,94,185,152,146,191,119,101,251,224,208,6,122,146,118,118,118,102,71,234,193,11,180,100,104,56,168,51,54,176,3,11,39,244,226,73,236,249,148,19,40,111,122,123,239,122,163,209,203,45,210,12,229,217,230,183,70,86,172,210,158,229,103,125,150,252,195,40,138,148,182,35,176,10,95,134,143,82,231,75,82,169,11,1,157,88,138,175,210,163,243,8,234,156,47,209,181,171,67,99,133,33,108,132,177,179,145,156,208,174,16,223,105,18,55,81,99,93,13,45,190,67,131,188,80,228,203,87,32,248,132,58,96,108,200,202,29,200,27,123,202,121,251,164,251,50,196,78,183,115,5,171,41,232,80,100,21,122,15,157,59,18,59,121,148,219,96,244,141,88,246,120,135,249,230,220,37,180,255,227,238,66,77,230,206,64,50,126,82,172,166,168,27,109,72,62,107,93,114,174,124,12,199,47,250,48,197,92,67,75,198,217,24,43,81,142,31,200,6,228,251,53,189,254,0,106,214,245,97,4,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysModuleIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4a153faf-96e3-4baf-9a80-f3c61e376019"),
				Name = "GetSysModuleId",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1990efc0-4801-4f90-90b9-43f376457f1c"),
				Name = "sysModuleInWorkspaceId",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,205,110,194,48,16,132,207,32,241,14,86,78,206,197,47,0,237,1,74,80,14,244,2,109,207,150,61,133,168,246,58,242,15,146,133,250,238,197,9,106,168,122,91,237,204,206,55,123,145,158,5,117,134,149,236,137,189,5,248,141,35,130,138,157,35,177,165,216,197,124,24,212,189,36,121,130,23,59,196,150,66,148,164,176,206,175,210,130,87,135,28,246,78,39,131,150,126,199,198,25,13,95,213,203,197,252,114,35,96,72,186,17,70,148,216,120,200,136,49,159,255,165,150,147,238,147,241,241,68,52,136,234,220,120,103,95,214,60,76,160,15,231,191,66,47,21,90,93,215,236,58,91,204,103,133,163,156,73,150,74,173,7,214,176,11,162,233,72,255,171,92,213,119,253,93,154,132,34,46,75,150,71,76,158,238,181,203,207,199,220,67,63,56,87,187,212,233,103,62,241,74,237,111,6,19,192,174,83,64,113,137,173,237,99,46,242,15,134,255,111,195,108,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysModuleEntityIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2928cd7c-e0e5-42cf-9a11-6a43a385a48f"),
				Name = "GetSysModuleEntityId",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("db37bac6-01ff-41ef-a77b-55d57bba6b20"),
				Name = "sysModuleId",
				CreatedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				ModifiedInSchemaUId = new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,189,142,194,48,16,132,235,228,41,172,84,78,227,23,128,163,128,35,136,130,107,248,233,45,123,57,44,197,107,100,175,145,172,211,189,59,118,18,4,136,118,103,230,155,217,155,244,44,168,11,88,201,190,216,49,128,95,57,68,80,100,28,138,53,146,161,180,31,212,157,68,249,11,94,108,128,182,24,72,162,130,101,250,145,22,120,179,79,97,231,116,236,161,105,103,245,45,243,96,200,101,222,8,22,43,15,146,96,164,241,247,142,156,48,103,198,199,132,232,128,212,165,243,206,126,47,121,120,80,183,186,109,217,95,93,21,178,114,125,180,88,106,95,232,195,45,136,206,160,254,152,52,150,54,237,228,58,201,62,66,177,204,170,186,242,64,209,227,180,182,60,118,72,87,208,47,198,249,38,26,189,224,207,210,188,246,159,65,31,160,236,153,226,197,35,214,246,74,41,139,119,109,231,213,213,78,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleDetailEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ee64e0d-3fff-4ea7-b9f1-ff9d524593f8"));
		}

		#endregion

	}

	#endregion

}

