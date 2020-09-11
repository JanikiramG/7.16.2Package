namespace Terrasoft.WebApp
{

	using DocumentFormat.OpenXml.CustomProperties;
	using DocumentFormat.OpenXml.Packaging;
	using DocumentFormat.OpenXml.VariantTypes;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
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

	#region Class: SysModuleReportMSWordEditPageSchema

	/// <exclude/>
	public class SysModuleReportMSWordEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LocalizableTextEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysModuleEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysModuleEdit {
			get {
				return _sysModuleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FileUploadEdit _fileUploadEdit;
		public Terrasoft.UI.WebControls.Controls.FileUploadEdit FileUploadEdit {
			get {
				return _fileUploadEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _showInSectionEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInSectionEdit {
			get {
				return _showInSectionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _showInCardEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInCardEdit {
			get {
				return _showInCardEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FileUploadButton _uploadTemplateButton;
		public Terrasoft.UI.WebControls.Controls.FileUploadButton UploadTemplateButton {
			get {
				return _uploadTemplateButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _saveToFileButton;
		public Terrasoft.UI.WebControls.Controls.Button SaveToFileButton {
			get {
				return _saveToFileButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _dataTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel DataTabPanel {
			get {
				return _dataTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _sysModuleReportFieldsTab;
		public Terrasoft.UI.WebControls.Controls.Tab SysModuleReportFieldsTab {
			get {
				return _sysModuleReportFieldsTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _sysModuleReportFieldsPageContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer SysModuleReportFieldsPageContainer {
			get {
				return _sysModuleReportFieldsPageContainer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _sysModuleReportTableTab;
		public Terrasoft.UI.WebControls.Controls.Tab SysModuleReportTableTab {
			get {
				return _sysModuleReportTableTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _additionalMacrosesPageContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer AdditionalMacrosesPageContainer {
			get {
				return _additionalMacrosesPageContainer;
			}
		}

		#endregion

		#region Constructors: Public

		public SysModuleReportMSWordEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleReportMSWordEditPageSchema(SysModuleReportMSWordEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Height = System.Web.UI.WebControls.Unit.Pixel(0);
			CustomControls.Image = new ControlImage {};
			CustomControls.Hidden = true;
			CustomControls.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.AutoScroll = false;
			MainControlLayout.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			RealUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			Name = "SysModuleReportMSWordEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 550;
			Height = 440;
			UseProfile = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportMSWordEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateCaptionEdit());
			MainControlLayout.InsertItem(1, CreateSysModuleEdit());
			MainControlLayout.InsertItem(2, CreateFileUploadEdit());
			MainControlLayout.InsertItem(3, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateShowInSectionEdit());
			ControlLayout2.InsertItem(1, CreateShowInCardEdit());
			MainControlLayout.InsertItem(4, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateUploadTemplateButton());
			ControlLayout1.InsertItem(1, CreateSaveToFileButton());
			MainControlLayout.InsertItem(5, CreateDataTabPanel());
			DataTabPanel.InsertItem(0, CreateSysModuleReportFieldsTab());
			SysModuleReportFieldsTab.InsertItem(0, CreateSysModuleReportFieldsPageContainer());
			DataTabPanel.InsertItem(1, CreateSysModuleReportTableTab());
			SysModuleReportTableTab.InsertItem(0, CreateAdditionalMacrosesPageContainer());
			MainControlLayout.MoveItem(6, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateSysModuleReportMSWordEditPageEventsProcessSchema() {
			var schema = new SysModuleReportMSWordEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.LocalizableTextEdit();
			_captionEdit.UId = new Guid("c68de178-e663-4113-8667-7a29c34eeed0");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_captionEdit.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_captionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionEdit.Required = true;
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysModuleEdit() {
			_sysModuleEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysModuleEdit.UId = new Guid("f2d2297e-53b6-4b27-823b-70eabff3f134");
			_sysModuleEdit.Name = "SysModuleEdit";
			_sysModuleEdit.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_sysModuleEdit.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_sysModuleEdit.CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			_sysModuleEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_sysModuleEdit.Tag = "";
			_sysModuleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysModuleEdit.Image = new ControlImage {};
			_sysModuleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysModuleEdit.DataSource = "DataSource";
			_sysModuleEdit.ColumnUId = new Guid("de464b17-8b1d-42cc-98fd-f3c6da159f99");
			return _sysModuleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadEdit CreateFileUploadEdit() {
			_fileUploadEdit = new Terrasoft.UI.WebControls.Controls.FileUploadEdit();
			_fileUploadEdit.UId = new Guid("f2ad96dc-5592-474c-9cde-765feb259fad");
			_fileUploadEdit.Name = "FileUploadEdit";
			_fileUploadEdit.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_fileUploadEdit.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_fileUploadEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_fileUploadEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_fileUploadEdit.Tag = "";
			_fileUploadEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_fileUploadEdit.Image = new ControlImage {};
			_fileUploadEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_fileUploadEdit.Hidden = true;
			_fileUploadEdit.Required = true;
			return _fileUploadEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateShowInSectionEdit() {
			_showInSectionEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_showInSectionEdit.UId = new Guid("e6c886e1-7046-42ed-8e93-2081caff536d");
			_showInSectionEdit.Name = "ShowInSectionEdit";
			_showInSectionEdit.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_showInSectionEdit.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_showInSectionEdit.CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			_showInSectionEdit.Tag = "";
			_showInSectionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showInSectionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_showInSectionEdit.DataSource = "DataSource";
			_showInSectionEdit.ColumnUId = new Guid("6f861889-e1ad-4b3e-8fed-42ba6c8347fe");
			return _showInSectionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateShowInCardEdit() {
			_showInCardEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_showInCardEdit.UId = new Guid("b79cd987-0af5-47c0-8d82-851bc76c4951");
			_showInCardEdit.Name = "ShowInCardEdit";
			_showInCardEdit.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_showInCardEdit.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_showInCardEdit.CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			_showInCardEdit.Tag = "";
			_showInCardEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showInCardEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_showInCardEdit.DataSource = "DataSource";
			_showInCardEdit.ColumnUId = new Guid("c4996acb-942b-48fe-b582-4e3b127b6196");
			return _showInCardEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("028e5a2c-058c-4953-99f3-e1514f15e2e5");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_controlLayout2.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_controlLayout2.CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadButton CreateUploadTemplateButton() {
			_uploadTemplateButton = new Terrasoft.UI.WebControls.Controls.FileUploadButton();
			_uploadTemplateButton.UId = new Guid("05214751-907e-4577-9fd6-08a9d240ed66");
			_uploadTemplateButton.Name = "UploadTemplateButton";
			_uploadTemplateButton.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_uploadTemplateButton.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_uploadTemplateButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_uploadTemplateButton.AjaxEvents.Upload.IsProcessEventHandler = true;
			_uploadTemplateButton.Tag = "";
			_uploadTemplateButton.Image = new ControlImage {};
			_uploadTemplateButton.Margins = "0 0 0 10";
			return _uploadTemplateButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSaveToFileButton() {
			_saveToFileButton = new Terrasoft.UI.WebControls.Controls.Button();
			_saveToFileButton.UId = new Guid("c27d7434-19c6-4a2b-8717-29eead0e179a");
			_saveToFileButton.Name = "SaveToFileButton";
			_saveToFileButton.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_saveToFileButton.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_saveToFileButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_saveToFileButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_saveToFileButton.Tag = "";
			_saveToFileButton.Image = new ControlImage {};
			_saveToFileButton.Margins = "0 0 0 10";
			return _saveToFileButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("010193ea-9744-4542-9689-693f75f03518");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_controlLayout1.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(35);
			_controlLayout1.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.Padding = "5 5 5 5";
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateSysModuleReportFieldsPageContainer() {
			_sysModuleReportFieldsPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_sysModuleReportFieldsPageContainer.UId = new Guid("92d549c9-fa95-4477-91d2-c9115ea5ae22");
			_sysModuleReportFieldsPageContainer.Name = "SysModuleReportFieldsPageContainer";
			_sysModuleReportFieldsPageContainer.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_sysModuleReportFieldsPageContainer.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_sysModuleReportFieldsPageContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysModuleReportFieldsPageContainer.Tag = "";
			_sysModuleReportFieldsPageContainer.PageSchemaUId = new Guid("bff4dfd2-1ba3-4c08-b783-3e4f5bc21bde");
			_sysModuleReportFieldsPageContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysModuleReportFieldsPageContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysModuleReportFieldsPageContainer.StartNewAlignGroup = false;
			_sysModuleReportFieldsPageContainer.Edges = "";
			return _sysModuleReportFieldsPageContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateSysModuleReportFieldsTab() {
			_sysModuleReportFieldsTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_sysModuleReportFieldsTab.UId = new Guid("24e99b4f-af57-4739-bb19-38c43d088bf2");
			_sysModuleReportFieldsTab.Name = "SysModuleReportFieldsTab";
			_sysModuleReportFieldsTab.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_sysModuleReportFieldsTab.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_sysModuleReportFieldsTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysModuleReportFieldsTab.Tag = "";
			_sysModuleReportFieldsTab.Image = new ControlImage {};
			return _sysModuleReportFieldsTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateAdditionalMacrosesPageContainer() {
			_additionalMacrosesPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_additionalMacrosesPageContainer.UId = new Guid("f155d3c3-7c78-46c4-b803-da67183344cc");
			_additionalMacrosesPageContainer.Name = "AdditionalMacrosesPageContainer";
			_additionalMacrosesPageContainer.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_additionalMacrosesPageContainer.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_additionalMacrosesPageContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_additionalMacrosesPageContainer.Tag = "";
			_additionalMacrosesPageContainer.PageSchemaUId = new Guid("6eac44c5-5684-4f4d-92f9-18bab315b954");
			_additionalMacrosesPageContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_additionalMacrosesPageContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_additionalMacrosesPageContainer.StartNewAlignGroup = false;
			_additionalMacrosesPageContainer.Edges = "";
			return _additionalMacrosesPageContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateSysModuleReportTableTab() {
			_sysModuleReportTableTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_sysModuleReportTableTab.UId = new Guid("c9d2832c-6549-4986-9bf0-ba3939f36e23");
			_sysModuleReportTableTab.Name = "SysModuleReportTableTab";
			_sysModuleReportTableTab.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_sysModuleReportTableTab.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_sysModuleReportTableTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysModuleReportTableTab.Tag = "";
			_sysModuleReportTableTab.Image = new ControlImage {};
			return _sysModuleReportTableTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateDataTabPanel() {
			_dataTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_dataTabPanel.UId = new Guid("0cb29214-ca9f-4dee-91c8-e79f4b4d608c");
			_dataTabPanel.Name = "DataTabPanel";
			_dataTabPanel.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_dataTabPanel.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			_dataTabPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataTabPanel.Tag = "";
			_dataTabPanel.ActiveTabIndex = 0;
			_dataTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(75);
			_dataTabPanel.StartNewAlignGroup = false;
			_dataTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_dataTabPanel.Margins = "0 0 0 0";
			return _dataTabPanel;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297");
			DataSource.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("1046a4e4-aae4-4902-b965-55d25f11fbdb");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("baf52598-de9e-4329-a889-f4a11b8d9880");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("f3fdb5ae-f6d7-49dc-8bf8-115fa4c0c183");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("4a9b7204-48a3-4408-995e-e1113656064d");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("e2798b37-09ec-4ff4-8a18-1da86b5d4f3d");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fb83606-040e-4fdb-aeb6-a9357886dcb3");
			if (column != null) {
				column.UId = new Guid("83f2f4e1-7bdd-4949-b691-02228893293e");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b6607c22-ca01-41f0-8637-610221a869b6");
			if (column != null) {
				column.UId = new Guid("de464b17-8b1d-42cc-98fd-f3c6da159f99");
				column.Name = @"SysModule";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b99f16cb-925d-48f2-94e9-98f9eb249048");
			if (column != null) {
				column.UId = new Guid("9ab41cf7-be60-4252-96f6-063b06c5c17a");
				column.Name = @"AutoPreview";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5c6855ee-1bce-4a62-901b-50482def049b");
			if (column != null) {
				column.UId = new Guid("406279f4-8a1f-4342-9562-8bb19e088726");
				column.Name = @"HelpContextId";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("2ebf8627-753e-44ca-b28f-3e750141be16");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("aba36b7e-96c2-4005-a9b9-64ceee36aaac");
			if (column != null) {
				column.UId = new Guid("429830df-ca74-4bf4-bbff-33378f1b8d87");
				column.Name = @"MacrosList";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("94f2a9f7-55c7-4ecf-9b64-17583ddc058b");
			if (column != null) {
				column.UId = new Guid("82909b25-fa02-4231-a3ad-d7701ad4828b");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cb6b495c-384d-4a40-9f93-35c6dfb79a3b");
			if (column != null) {
				column.UId = new Guid("aad882e7-4701-485b-8818-095c7e20f354");
				column.Name = @"File";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("362bb0b0-d3da-4b01-abe6-a617e1b1257f");
			if (column != null) {
				column.UId = new Guid("4cdd106d-7784-4259-83db-855ddbac4ff8");
				column.Name = @"FileName";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8e01622f-e04b-480a-859a-01df55c30729");
			if (column != null) {
				column.UId = new Guid("afa660f1-d460-460b-8df1-2ae001b334d6");
				column.Name = @"SysReportSchemaUId";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1f17f6cb-8a86-408c-9207-d2f8b22ae1b7");
			if (column != null) {
				column.UId = new Guid("7726ab24-929a-45a4-b0fe-d2bc012406b2");
				column.Name = @"SysOptionsPageSchemaUId";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9a75dacc-e0b6-456c-af91-1a1a369eaa3b");
			if (column != null) {
				column.UId = new Guid("c4996acb-942b-48fe-b582-4e3b127b6196");
				column.Name = @"ShowInCard";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3b976c18-5bfe-482a-8ac1-a9377075a627");
			if (column != null) {
				column.UId = new Guid("6f861889-e1ad-4b3e-8fed-42ba6c8347fe");
				column.Name = @"ShowInSection";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("025ae038-8c4b-46b8-8d94-239ef3ac7911");
			if (column != null) {
				column.UId = new Guid("8884e932-76d8-49aa-96a9-fbe8140ff961");
				column.Name = @"ConvertInPDF";
				column.CreatedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
				column.ModifiedInSchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
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
			return new SysModuleReportMSWordEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleReportMSWordEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("41899fab-093e-4808-86db-5794b9836745"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleReportMSWordEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportMSWordEditPageEventsProcess

	/// <exclude/>
	public class SysModuleReportMSWordEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleReportMSWordEditPageSchemaUserControl
	{

		#region Class: UserMessageUserTaskFlowElement

		/// <exclude/>
		public class UserMessageUserTaskFlowElement : QuestionUserTask
		{

			public UserMessageUserTaskFlowElement(UserConnection userConnection, SysModuleReportMSWordEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowInvalidObjectNameUserTaskFlowElement

		/// <exclude/>
		public class ShowInvalidObjectNameUserTaskFlowElement : QuestionUserTask
		{

			public ShowInvalidObjectNameUserTaskFlowElement(UserConnection userConnection, SysModuleReportMSWordEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowInvalidObjectNameUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenInvalidCaptionMessageUserTaskFlowElement

		/// <exclude/>
		public class OpenInvalidCaptionMessageUserTaskFlowElement : QuestionUserTask
		{

			public OpenInvalidCaptionMessageUserTaskFlowElement(UserConnection userConnection, SysModuleReportMSWordEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenInvalidCaptionMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenInvalidColumnCaptionMessageUserTaskFlowElement

		/// <exclude/>
		public class OpenInvalidColumnCaptionMessageUserTaskFlowElement : QuestionUserTask
		{

			public OpenInvalidColumnCaptionMessageUserTaskFlowElement(UserConnection userConnection, SysModuleReportMSWordEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenInvalidColumnCaptionMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public SysModuleReportMSWordEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReportMSWordEditPageEventsProcess";
			SchemaUId = new Guid("41899fab-093e-4808-86db-5794b9836745");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("41899fab-093e-4808-86db-5794b9836745");
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

		public virtual string FileContent {
			get;
			set;
		}

		public virtual int FileSize {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerCreated {
			get;
			set;
		}

		public virtual Object ColumnStructureExplorer {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerRegistered {
			get;
			set;
		}

		private string _attributeName;
		public virtual string AttributeName {
			get {
				return _attributeName ?? (_attributeName = new LocalizableString(Storage, "41899fab093e480886db5794b9836745",
						 "EventsProcessSchema.Parameters.AttributeName.Value"));
			}
			set {
				_attributeName = value;
			}
		}

		public virtual Guid SelectedModuleId {
			get;
			set;
		}

		public virtual Guid ParentEntitySchemaId {
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

		public virtual string FileName {
			get;
			set;
		}

		public virtual bool IsFileChanged {
			get;
			set;
		}

		private string _defMSWordReportTemplateKnowledgeBaseCode;
		public virtual string DefMSWordReportTemplateKnowledgeBaseCode {
			get {
				return _defMSWordReportTemplateKnowledgeBaseCode ?? (_defMSWordReportTemplateKnowledgeBaseCode = new LocalizableString(Storage, "41899fab093e480886db5794b9836745",
						 "EventsProcessSchema.Parameters.DefMSWordReportTemplateKnowledgeBaseCode.Value"));
			}
			set {
				_defMSWordReportTemplateKnowledgeBaseCode = value;
			}
		}

		public virtual string ConflictedObjectName {
			get;
			set;
		}

		public virtual string InvalidCaptionMessage {
			get;
			set;
		}

		public virtual string InvalidColumnCaptionMessage {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("b816fbbc-aa84-4e20-8940-af7b98d10907"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysModuleEditChangeStartMessage4;
		public ProcessFlowElement SysModuleEditChangeStartMessage4 {
			get {
				return _sysModuleEditChangeStartMessage4 ?? (_sysModuleEditChangeStartMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysModuleEditChangeStartMessage4",
					SchemaElementUId = new Guid("7bf0f17f-d01d-4ddd-9e51-77ac55e598d6"),
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
					SchemaElementUId = new Guid("bed080b9-0b6d-457c-ae0b-696dc947ea7f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("09b7bb1b-516c-40ae-ae58-6da67a6e5c98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("902a598f-818e-4372-afc2-082fdb54fae9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("21a6c3ab-db15-4f98-8bd6-e31f78ce1681"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
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
					SchemaElementUId = new Guid("1277ed1f-614b-4e43-a49c-073538370b63"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childSaveToFileButtonClickStartMessage;
		public ProcessFlowElement ChildSaveToFileButtonClickStartMessage {
			get {
				return _childSaveToFileButtonClickStartMessage ?? (_childSaveToFileButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildSaveToFileButtonClickStartMessage",
					SchemaElementUId = new Guid("66bf4a1c-9a66-4fa1-bcc8-fd68307e56da"),
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
					SchemaElementUId = new Guid("f6a3d828-4b8f-4c9f-8bc7-5dfe813a2827"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("6f44c70c-0ee2-467a-a451-a1dc81c7bff1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDataSourceSaved;
		public ProcessFlowElement StartMessageDataSourceSaved {
			get {
				return _startMessageDataSourceSaved ?? (_startMessageDataSourceSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDataSourceSaved",
					SchemaElementUId = new Guid("def1ab16-e08c-4e78-bc53-e0be161c5644"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _dataSourceSavedIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent DataSourceSavedIntermediateThrowMessageEvent {
			get {
				return _dataSourceSavedIntermediateThrowMessageEvent ?? (_dataSourceSavedIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "DataSourceSavedIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("fb157cb1-8951-4547-a453-68b42ee5a9c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask9;
		public ProcessScriptTask ScriptTask9 {
			get {
				return _scriptTask9 ?? (_scriptTask9 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask9",
					SchemaElementUId = new Guid("4caa1198-f2e9-41b5-8c22-4a58688c8be1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask9Execute,
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
					SchemaElementUId = new Guid("a83d6a3c-f147-4c63-ae85-2f93006406f2"),
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
					SchemaElementUId = new Guid("91d00f34-5d44-448b-8d50-693d66d497d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _userQuestionYesMessageScriptTask;
		public ProcessScriptTask UserQuestionYesMessageScriptTask {
			get {
				return _userQuestionYesMessageScriptTask ?? (_userQuestionYesMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UserQuestionYesMessageScriptTask",
					SchemaElementUId = new Guid("7835f3b8-62d3-4ec1-8808-47e14584847a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UserQuestionYesMessageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("030d8b4f-1a60-4044-bc52-dd6a950f090a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage7;
		public ProcessFlowElement StartMessage7 {
			get {
				return _startMessage7 ?? (_startMessage7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage7",
					SchemaElementUId = new Guid("1a66e820-715b-431c-bfe8-44d49a1551fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent5;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent5 {
			get {
				return _intermediateThrowMessageEvent5 ?? (_intermediateThrowMessageEvent5 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent5",
					SchemaElementUId = new Guid("6173e659-c1ed-4303-a393-ea21eba91519"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("b6485cfb-ef84-4f63-aec8-2a29b2b569c3"),
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
					SchemaElementUId = new Guid("30d12d9d-56a2-4d55-8cc9-64930de5073c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _fileUploadEditChangeScriptTask;
		public ProcessScriptTask FileUploadEditChangeScriptTask {
			get {
				return _fileUploadEditChangeScriptTask ?? (_fileUploadEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FileUploadEditChangeScriptTask",
					SchemaElementUId = new Guid("eac2b15d-816d-461a-85a0-2d71018adac6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FileUploadEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("b63b8654-8b3c-4605-9a55-eb7cf7d1c57d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _beforeParentPageLoadCompleteStartMessage;
		public ProcessFlowElement BeforeParentPageLoadCompleteStartMessage {
			get {
				return _beforeParentPageLoadCompleteStartMessage ?? (_beforeParentPageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BeforeParentPageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("71b0cfd6-251e-4441-ae4f-87190574f49a"),
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
					SchemaElementUId = new Guid("277c925c-4c33-425a-bb03-ec3c205d0463"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _afterParentPageLoadCompleteScriptTask;
		public ProcessScriptTask AfterParentPageLoadCompleteScriptTask {
			get {
				return _afterParentPageLoadCompleteScriptTask ?? (_afterParentPageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AfterParentPageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("c9a60923-5469-4e14-8a9e-fa737325d7ef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AfterParentPageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTask5;
		public ProcessScriptTask ScriptTask5 {
			get {
				return _scriptTask5 ?? (_scriptTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5",
					SchemaElementUId = new Guid("b01f80b7-9929-4ccb-af87-95adc347a68e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("ea2efe78-4c1a-4128-a848-d2443da513b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3;
		public ProcessFlowElement StartMessage3 {
			get {
				return _startMessage3 ?? (_startMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3",
					SchemaElementUId = new Guid("feced922-af16-4028-a17c-7d045324c795"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _chilInitScriptTask;
		public ProcessScriptTask ChilInitScriptTask {
			get {
				return _chilInitScriptTask ?? (_chilInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChilInitScriptTask",
					SchemaElementUId = new Guid("7b4255e6-eb4e-4e25-9f76-6a392d30a590"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChilInitScriptTaskExecute,
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
					SchemaElementUId = new Guid("6e6c203d-3118-4b7f-97ab-c36ec28916da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5;
		public ProcessFlowElement StartMessage5 {
			get {
				return _startMessage5 ?? (_startMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5",
					SchemaElementUId = new Guid("2b521b7d-bb3e-4cf0-87fd-c0326b95a001"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("04f672c2-5459-4f5b-8e8b-8f8e7f344475"),
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

		private ProcessScriptTask _scriptTask8;
		public ProcessScriptTask ScriptTask8 {
			get {
				return _scriptTask8 ?? (_scriptTask8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask8",
					SchemaElementUId = new Guid("31d2e6b5-98d9-4eeb-9170-1142c7656244"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask8Execute,
				});
			}
		}

		private UserMessageUserTaskFlowElement _userMessageUserTask;
		public UserMessageUserTaskFlowElement UserMessageUserTask {
			get {
				return _userMessageUserTask ?? (_userMessageUserTask = new UserMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("5330ea13-7927-4a71-b919-b9fabfaa720b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
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
					SchemaElementUId = new Guid("220641bc-9be7-420e-8797-0183b27fa623"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessScriptTask _checkObjectNames;
		public ProcessScriptTask CheckObjectNames {
			get {
				return _checkObjectNames ?? (_checkObjectNames = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckObjectNames",
					SchemaElementUId = new Guid("4ea8a10b-0b86-47d6-bfa8-fbb535351eb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckObjectNamesExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af;
		public ProcessExclusiveGateway ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af {
			get {
				return _exclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af ?? (_exclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af",
					SchemaElementUId = new Guid("c3c2379d-3b36-4c4f-b44e-cc5b953c78af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _prepareInvalidObjectNameMessageParameters;
		public ProcessScriptTask PrepareInvalidObjectNameMessageParameters {
			get {
				return _prepareInvalidObjectNameMessageParameters ?? (_prepareInvalidObjectNameMessageParameters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareInvalidObjectNameMessageParameters",
					SchemaElementUId = new Guid("89d64b1c-bdc2-40d7-a137-922f83d3c700"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareInvalidObjectNameMessageParametersExecute,
				});
			}
		}

		private ShowInvalidObjectNameUserTaskFlowElement _showInvalidObjectNameUserTask;
		public ShowInvalidObjectNameUserTaskFlowElement ShowInvalidObjectNameUserTask {
			get {
				return _showInvalidObjectNameUserTask ?? (_showInvalidObjectNameUserTask = new ShowInvalidObjectNameUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _checkReportCaptionScriptTask;
		public ProcessScriptTask CheckReportCaptionScriptTask {
			get {
				return _checkReportCaptionScriptTask ?? (_checkReportCaptionScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckReportCaptionScriptTask",
					SchemaElementUId = new Guid("4c4aa2d7-c662-4396-949e-035854b560fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckReportCaptionScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4;
		public ProcessExclusiveGateway ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4 {
			get {
				return _exclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4 ?? (_exclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4",
					SchemaElementUId = new Guid("5c55d4e2-8be7-41bd-ab04-7b3096c6d2b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private OpenInvalidCaptionMessageUserTaskFlowElement _openInvalidCaptionMessageUserTask;
		public OpenInvalidCaptionMessageUserTaskFlowElement OpenInvalidCaptionMessageUserTask {
			get {
				return _openInvalidCaptionMessageUserTask ?? (_openInvalidCaptionMessageUserTask = new OpenInvalidCaptionMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _prepareInvalidCaptionMessageWindowParameters;
		public ProcessScriptTask PrepareInvalidCaptionMessageWindowParameters {
			get {
				return _prepareInvalidCaptionMessageWindowParameters ?? (_prepareInvalidCaptionMessageWindowParameters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareInvalidCaptionMessageWindowParameters",
					SchemaElementUId = new Guid("55d9eaf4-5754-42ac-be59-b716e2c7527c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareInvalidCaptionMessageWindowParametersExecute,
				});
			}
		}

		private ProcessScriptTask _checkReportColumnsCaptionsScriptTask;
		public ProcessScriptTask CheckReportColumnsCaptionsScriptTask {
			get {
				return _checkReportColumnsCaptionsScriptTask ?? (_checkReportColumnsCaptionsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckReportColumnsCaptionsScriptTask",
					SchemaElementUId = new Guid("95da3e2c-e197-4979-a1d0-9e5d043c23e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckReportColumnsCaptionsScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385;
		public ProcessExclusiveGateway ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385 {
			get {
				return _exclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385 ?? (_exclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385",
					SchemaElementUId = new Guid("9a817989-adcc-47c6-bdae-c0c5e41a1385"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private OpenInvalidColumnCaptionMessageUserTaskFlowElement _openInvalidColumnCaptionMessageUserTask;
		public OpenInvalidColumnCaptionMessageUserTaskFlowElement OpenInvalidColumnCaptionMessageUserTask {
			get {
				return _openInvalidColumnCaptionMessageUserTask ?? (_openInvalidColumnCaptionMessageUserTask = new OpenInvalidColumnCaptionMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _prepareInvalidColumnCaptionMessageWindowParameters;
		public ProcessScriptTask PrepareInvalidColumnCaptionMessageWindowParameters {
			get {
				return _prepareInvalidColumnCaptionMessageWindowParameters ?? (_prepareInvalidColumnCaptionMessageWindowParameters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareInvalidColumnCaptionMessageWindowParameters",
					SchemaElementUId = new Guid("92fb43c2-731c-4c4a-b2c0-298bf7d2355e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareInvalidColumnCaptionMessageWindowParametersExecute,
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
					SchemaElementUId = new Guid("112a9654-b56d-47ac-8885-c968463be2a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38;
		public ProcessConditionalFlow ConditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38 {
			get {
				return _conditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38 ?? (_conditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38",
					SchemaElementUId = new Guid("f8971421-111c-4e81-9d44-f2f10a949e38"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fb;
		public ProcessConditionalFlow ConditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fb {
			get {
				return _conditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fb ?? (_conditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fb = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fb",
					SchemaElementUId = new Guid("7eca7a46-4a02-47b0-abcd-ef2ea78de7fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2;
		public ProcessConditionalFlow ConditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2 {
			get {
				return _conditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2 ?? (_conditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2",
					SchemaElementUId = new Guid("95547e1d-9d25-42ef-bab6-02cf5f2d46b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _defaultTemplateFileName;
		public LocalizableString DefaultTemplateFileName {
			get {
				return _defaultTemplateFileName ?? (_defaultTemplateFileName = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DefaultTemplateFileName.Value"));
			}
		}

		private LocalizableString _userQuestionTitle;
		public LocalizableString UserQuestionTitle {
			get {
				return _userQuestionTitle ?? (_userQuestionTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UserQuestionTitle.Value"));
			}
		}

		private LocalizableString _showInvalidObjectNameUserTaskMessage;
		public LocalizableString ShowInvalidObjectNameUserTaskMessage {
			get {
				return _showInvalidObjectNameUserTaskMessage ?? (_showInvalidObjectNameUserTaskMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ShowInvalidObjectNameUserTaskMessage.Value"));
			}
		}

		private LocalizableString _invalidCaptionMessageTpl;
		public LocalizableString InvalidCaptionMessageTpl {
			get {
				return _invalidCaptionMessageTpl ?? (_invalidCaptionMessageTpl = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.InvalidCaptionMessageTpl.Value"));
			}
		}

		private LocalizableString _invalidColumnCaptionMessageTpl;
		public LocalizableString InvalidColumnCaptionMessageTpl {
			get {
				return _invalidColumnCaptionMessageTpl ?? (_invalidColumnCaptionMessageTpl = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.InvalidColumnCaptionMessageTpl.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[SysModuleEditChangeStartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { SysModuleEditChangeStartMessage4 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[ChildSaveToFileButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildSaveToFileButtonClickStartMessage };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessageDataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDataSourceSaved };
			FlowElements[DataSourceSavedIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceSavedIntermediateThrowMessageEvent };
			FlowElements[ScriptTask9.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask9 };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[StartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6 };
			FlowElements[UserQuestionYesMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionYesMessageScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage7 };
			FlowElements[IntermediateThrowMessageEvent5.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent5 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[FileUploadEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FileUploadEditChangeScriptTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[BeforeParentPageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeParentPageLoadCompleteStartMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[AfterParentPageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterParentPageLoadCompleteScriptTask };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ChilInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChilInitScriptTask };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ScriptTask8.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask8 };
			FlowElements[UserMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UserMessageUserTask };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[CheckObjectNames.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckObjectNames };
			FlowElements[ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af };
			FlowElements[PrepareInvalidObjectNameMessageParameters.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareInvalidObjectNameMessageParameters };
			FlowElements[ShowInvalidObjectNameUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowInvalidObjectNameUserTask };
			FlowElements[CheckReportCaptionScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckReportCaptionScriptTask };
			FlowElements[ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4 };
			FlowElements[OpenInvalidCaptionMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenInvalidCaptionMessageUserTask };
			FlowElements[PrepareInvalidCaptionMessageWindowParameters.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareInvalidCaptionMessageWindowParameters };
			FlowElements[CheckReportColumnsCaptionsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckReportColumnsCaptionsScriptTask };
			FlowElements[ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385 };
			FlowElements[OpenInvalidColumnCaptionMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenInvalidColumnCaptionMessageUserTask };
			FlowElements[PrepareInvalidColumnCaptionMessageWindowParameters.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareInvalidColumnCaptionMessageWindowParameters };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4":
						break;
					case "SysModuleEditChangeStartMessage4":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
					case "EventSubProcess11":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
					case "EventSubProcess10":
						break;
					case "ChildSaveToFileButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "EventSubProcess9":
						break;
					case "StartMessageDataSourceSaved":
						e.Context.QueueTasks.Enqueue("DataSourceSavedIntermediateThrowMessageEvent");
						break;
					case "DataSourceSavedIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ScriptTask9");
						break;
					case "ScriptTask9":
						break;
					case "EventSubProcess7":
						break;
					case "StartMessage6":
						e.Context.QueueTasks.Enqueue("UserQuestionYesMessageScriptTask");
						break;
					case "UserQuestionYesMessageScriptTask":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage7":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent5");
						break;
					case "IntermediateThrowMessageEvent5":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("FileUploadEditChangeScriptTask");
						break;
					case "FileUploadEditChangeScriptTask":
						break;
					case "EventSubProcess1":
						break;
					case "BeforeParentPageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("AfterParentPageLoadCompleteScriptTask");
						break;
					case "AfterParentPageLoadCompleteScriptTask":
						break;
					case "ScriptTask5":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "EventSubProcess3":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ChilInitScriptTask");
						break;
					case "ChilInitScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "EventSubProcess6":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("CheckReportCaptionScriptTask");
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask8");
							break;
						}
						e.Context.QueueTasks.Enqueue("CheckObjectNames");
						break;
					case "ScriptTask8":
						e.Context.QueueTasks.Enqueue("UserMessageUserTask");
						break;
					case "UserMessageUserTask":
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "CheckObjectNames":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af");
						break;
					case "ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af":
						if (ConditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
							break;
						}
						e.Context.QueueTasks.Enqueue("PrepareInvalidObjectNameMessageParameters");
						break;
					case "PrepareInvalidObjectNameMessageParameters":
						e.Context.QueueTasks.Enqueue("ShowInvalidObjectNameUserTask");
						break;
					case "ShowInvalidObjectNameUserTask":
						break;
					case "CheckReportCaptionScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4");
						break;
					case "ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4":
						if (ConditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fbExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("CheckReportColumnsCaptionsScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("PrepareInvalidCaptionMessageWindowParameters");
						break;
					case "OpenInvalidCaptionMessageUserTask":
						break;
					case "PrepareInvalidCaptionMessageWindowParameters":
						e.Context.QueueTasks.Enqueue("OpenInvalidCaptionMessageUserTask");
						break;
					case "CheckReportColumnsCaptionsScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385");
						break;
					case "ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385":
						if (ConditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask1");
							break;
						}
						e.Context.QueueTasks.Enqueue("PrepareInvalidColumnCaptionMessageWindowParameters");
						break;
					case "OpenInvalidColumnCaptionMessageUserTask":
						break;
					case "PrepareInvalidColumnCaptionMessageWindowParameters":
						e.Context.QueueTasks.Enqueue("OpenInvalidColumnCaptionMessageUserTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Page.DataSource.ActiveRow.GetTypedColumnValue<string>("MacrosList")));
		}

		private bool ConditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38ExpressionExecute() {
			return Convert.ToBoolean(ConflictedObjectName == null);
		}

		private bool ConditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fbExpressionExecute() {
			return Convert.ToBoolean(InvalidCaptionMessage == null);
		}

		private bool ConditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2ExpressionExecute() {
			return Convert.ToBoolean(InvalidColumnCaptionMessage == null);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysModuleEditChangeStartMessage4");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("ChildSaveToFileButtonClickStartMessage");
			ActivatedEventElements.Add("StartMessageDataSourceSaved");
			ActivatedEventElements.Add("StartMessage6");
			ActivatedEventElements.Add("StartMessage7");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("BeforeParentPageLoadCompleteStartMessage");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("StartMessage5");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "SysModuleEditChangeStartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysModuleEditChangeStartMessage4";
					result = SysModuleEditChangeStartMessage4.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "ChildSaveToFileButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildSaveToFileButtonClickStartMessage";
					result = ChildSaveToFileButtonClickStartMessage.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDataSourceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDataSourceSaved";
					result = StartMessageDataSourceSaved.Execute(context);
					break;
				case "DataSourceSavedIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceSaved");
					result = DataSourceSavedIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ScriptTask9":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask9";
					result = ScriptTask9.Execute(context, ScriptTask9Execute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6";
					result = StartMessage6.Execute(context);
					break;
				case "UserQuestionYesMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserQuestionYesMessageScriptTask";
					result = UserQuestionYesMessageScriptTask.Execute(context, UserQuestionYesMessageScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage7";
					result = StartMessage7.Execute(context);
					break;
				case "IntermediateThrowMessageEvent5":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowMessageEvent5.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "FileUploadEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FileUploadEditChangeScriptTask";
					result = FileUploadEditChangeScriptTask.Execute(context, FileUploadEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "BeforeParentPageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BeforeParentPageLoadCompleteStartMessage";
					result = BeforeParentPageLoadCompleteStartMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "AfterParentPageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AfterParentPageLoadCompleteScriptTask";
					result = AfterParentPageLoadCompleteScriptTask.Execute(context, AfterParentPageLoadCompleteScriptTaskExecute);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ChilInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChilInitScriptTask";
					result = ChilInitScriptTask.Execute(context, ChilInitScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "ScriptTask8":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask8";
					result = ScriptTask8.Execute(context, ScriptTask8Execute);
					break;
				case "UserMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserMessageUserTask";
					result = UserMessageUserTask.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "CheckObjectNames":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckObjectNames";
					result = CheckObjectNames.Execute(context, CheckObjectNamesExecute);
					break;
				case "ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af";
					result = ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af.Execute(context);
					break;
				case "PrepareInvalidObjectNameMessageParameters":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareInvalidObjectNameMessageParameters";
					result = PrepareInvalidObjectNameMessageParameters.Execute(context, PrepareInvalidObjectNameMessageParametersExecute);
					break;
				case "ShowInvalidObjectNameUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowInvalidObjectNameUserTask";
					result = ShowInvalidObjectNameUserTask.Execute(context);
					break;
				case "CheckReportCaptionScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckReportCaptionScriptTask";
					result = CheckReportCaptionScriptTask.Execute(context, CheckReportCaptionScriptTaskExecute);
					break;
				case "ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4";
					result = ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4.Execute(context);
					break;
				case "OpenInvalidCaptionMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenInvalidCaptionMessageUserTask";
					result = OpenInvalidCaptionMessageUserTask.Execute(context);
					break;
				case "PrepareInvalidCaptionMessageWindowParameters":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareInvalidCaptionMessageWindowParameters";
					result = PrepareInvalidCaptionMessageWindowParameters.Execute(context, PrepareInvalidCaptionMessageWindowParametersExecute);
					break;
				case "CheckReportColumnsCaptionsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckReportColumnsCaptionsScriptTask";
					result = CheckReportColumnsCaptionsScriptTask.Execute(context, CheckReportColumnsCaptionsScriptTaskExecute);
					break;
				case "ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385";
					result = ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385.Execute(context);
					break;
				case "OpenInvalidColumnCaptionMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenInvalidColumnCaptionMessageUserTask";
					result = OpenInvalidColumnCaptionMessageUserTask.Execute(context);
					break;
				case "PrepareInvalidColumnCaptionMessageWindowParameters":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareInvalidColumnCaptionMessageWindowParameters";
					result = PrepareInvalidColumnCaptionMessageWindowParameters.Execute(context, PrepareInvalidColumnCaptionMessageWindowParametersExecute);
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
				case "InvalidColumnCaptionMessage":
					InvalidColumnCaptionMessage = reader.GetValue<System.String>();
				break;
				case "InvalidCaptionMessage":
					InvalidCaptionMessage = reader.GetValue<System.String>();
				break;
				case "ConflictedObjectName":
					ConflictedObjectName = reader.GetValue<System.String>();
				break;
				case "DefMSWordReportTemplateKnowledgeBaseCode":
					DefMSWordReportTemplateKnowledgeBaseCode = reader.GetValue<System.String>();
				break;
				case "IsFileChanged":
					IsFileChanged = reader.GetValue<System.Boolean>();
				break;
				case "FileName":
					FileName = reader.GetValue<System.String>();
				break;
				case "CloseWindowAfterSave":
					CloseWindowAfterSave = reader.GetValue<System.Boolean>();
				break;
				case "NeedSendAllowMessage":
					NeedSendAllowMessage = reader.GetValue<System.Boolean>();
				break;
				case "ParentEntitySchemaId":
					ParentEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "SelectedModuleId":
					SelectedModuleId = reader.GetValue<System.Guid>();
				break;
				case "AttributeName":
					AttributeName = reader.GetValue<System.String>();
				break;
				case "ColumnStructureExplorerRegistered":
					ColumnStructureExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "ColumnStructureExplorer":
					ColumnStructureExplorer = reader.GetSerializableObjectValue();
				break;
				case "ColumnStructureExplorerCreated":
					ColumnStructureExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "FileSize":
					FileSize = reader.GetValue<System.Int32>();
				break;
				case "FileContent":
					FileContent = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			SelectedModuleId = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("SysModuleId");
			ParentEntitySchemaId = GetParentEntitySchemaId(SelectedModuleId);
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["SysModule_parentEntitySchema"] = ParentEntitySchemaId;
			
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			if (Page.UploadTemplateButton.HasFiles) {
				var bytes = Page.UploadTemplateButton.PostedFiles[0].GetFileBytes();
				FileSize = bytes.Length;
				FileContent = Convert.ToBase64String(bytes);
				FileName = Page.UploadTemplateButton.FileNames[0];
				IsFileChanged = true;
			}
			
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			var fileCaption = Page.DataSource.ActiveRow.GetTypedColumnValue<string>("Caption");
			if (string.IsNullOrEmpty(fileCaption)) {
				fileCaption = FileName;
			} else {
				fileCaption = string.Concat(fileCaption, ".docx");
			}
			if (string.IsNullOrEmpty(FileContent)||string.IsNullOrEmpty(fileCaption)){
				return true;
			}
			
			byte[] data = Convert.FromBase64String((string)FileContent);
			var Response = Page.Response;
			PageResponse.Write(Response, data, fileCaption, ContentType.StreamType);
			
			return true;
		}

		public virtual bool ScriptTask9Execute(ProcessExecutingContext context) {
			Terrasoft.Configuration.CommonUtilities.SaveLocalizableValue(Page.DataSource.ActiveRow, Page.CaptionEdit.LocalizableText, "Caption");
			Terrasoft.Configuration.SysModuleFolderUtilities.ResetModuleReportCache(UserConnection.SessionCache.WithLocalCaching(Terrasoft.Configuration.CacheUtilities.WorkspaceCacheGroup));
			
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["needAddDetailRequest"] = false;
			
			return true;
		}

		public virtual bool UserQuestionYesMessageScriptTaskExecute(ProcessExecutingContext context) {
			var pageInstance = Page.SysModuleReportFieldsPageContainer.PageInstance 
				as Terrasoft.WebApp.SysModuleReportFieldsGridPageSchemaUserControl;
			pageInstance.ThrowEvent("SetupMacrosesButtonClick");
			
			return true;
		}

		public virtual bool FileUploadEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.FileUploadEdit.HasFile) {
				Page.FileUploadEdit.FileContent.Position = 0;
				FileSize = (int)Page.FileUploadEdit.FileContent.Length;
				FileContent = Convert.ToBase64String(Page.FileUploadEdit.FileBytes);
				FileName = Page.FileUploadEdit.FileName;
				IsFileChanged = true;
			}
			
			return true;
		}

		public virtual bool AfterParentPageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			SelectedModuleId = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("SysModuleId");
			ParentEntitySchemaId = GetParentEntitySchemaId(SelectedModuleId);
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["SysModule_parentEntitySchema"] = ParentEntitySchemaId;
			
			
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			Page.CaptionEdit.LocalizableText = 
				Terrasoft.Configuration.CommonUtilities.GetLocalizableValue(UserConnection, Page.DataSource.Schema.Name, "Caption", Page.DataSource.ActiveRowPrimaryColumnValue);
			
			if (IsNew) {
				Page.FileUploadEdit.SetValue(DefaultTemplateFileName.Value);
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var entitySchema = entitySchemaManager.GetInstanceByName("KnowledgeBaseFile"); 
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name);
			
				var dataColumn = entitySchemaQuery.AddColumn("Data");
				entitySchemaQuery.Filters.Add(
					entitySchemaQuery.CreateFilterWithParameters(
					FilterComparisonType.Equal, "KnowledgeBase.Code", 
					new object[] {DefMSWordReportTemplateKnowledgeBaseCode}));
				entitySchemaQuery.Filters.Add(
					entitySchemaQuery.CreateFilterWithParameters(
						FilterComparisonType.Equal, "Name", new object[] {DefaultTemplateFileName.ToString()}));
			
				var entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entityCollection.Count > 0) {
					var fileContent = entityCollection[0].GetBytesValue(dataColumn.Name)  as byte[];
					FileSize = fileContent.Length;
					FileContent = Convert.ToBase64String(fileContent);
					FileName = DefaultTemplateFileName.Value;
				}
			} else {
				Page.FileUploadEdit.Value = Page.DataSource.ActiveRow.GetTypedColumnValue<string>("FileName");
				FileName = Page.DataSource.ActiveRow.GetTypedColumnValue<string>("FileName");
				if (Page.DataSource.ActiveRow.GetColumnValue("File") != null) {
					FileContent = Convert.ToBase64String((byte[])Page.DataSource.ActiveRow.GetColumnValue("File"));
					FileSize = ((byte[])Page.DataSource.ActiveRow.GetColumnValue("File")).Length;
				}
			}
			
			Page.AdditionalMacrosesPageContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", EntityPrimaryColumnValue);
			
			Page.AdditionalMacrosesPageContainer.PageInstance.ThrowEvent("GridPageRefreshRow");
			aspPage.CustomData["SysModule_activeDataSource"] = Page.DataSource.ClientID;
			aspPage.CustomData["needAddDetailRequest"] = IsNew || IsCopy;
			
			IsFileChanged = IsNew || IsCopy;
			IsNotWindowClose = IsNew || IsCopy;
			
			var pageInstance = Page.SysModuleReportFieldsPageContainer.PageInstance 
				as Terrasoft.WebApp.SysModuleReportFieldsGridPageSchemaUserControl;
			pageInstance.Process.SetPropertyValue("ParentEntitySchemaId", ParentEntitySchemaId);
			pageInstance.Process.SetPropertyValue("MacrosList", Page.DataSource.ActiveRow.GetTypedColumnValue<string>("MacrosList"));
			pageInstance.Process.SetPropertyValue("SysModuleReportId", EntityPrimaryColumnValue);
			pageInstance.ThrowEvent("FillData");
			
			Page.SysModuleEdit.Enabled = IsNew || IsCopy;
			
			return true;
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ChilInitScriptTaskExecute(ProcessExecutingContext context) {
			Page.DataSource.BeforeSaveRow +=
			 delegate(object sender, DataSourceEventArgs e) {
				 if (IsFileChanged) {
					 if (FileContent != null) {
						byte[] fileData = Convert.FromBase64String((string)FileContent);
						var memoryStream = new System.IO.MemoryStream();
						memoryStream.Write(fileData, 0, FileSize);
						SetCustomTemplateProperty(memoryStream, e.Row.GetTypedColumnValue<string>("Id"));
						e.Row.SetStreamValue("File", memoryStream);
						FileContent = null;
					}
					e.Row.SetColumnValue("FileName", FileName);
				 }
				 e.Row.SetColumnValue("TypeId", new Guid("8BC259EF-4276-4906-B7A6-23DC59BE7FE2"));
				 e.Row.SetColumnValue("Caption", Page.CaptionEdit.LocalizableText.GetCultureValue(GeneralResourceStorage.CurrentCulture));
				 
				 var pageInstance = Page.SysModuleReportFieldsPageContainer.PageInstance 
					as Terrasoft.WebApp.SysModuleReportFieldsGridPageSchemaUserControl;
				 e.Row.SetColumnValue("MacrosList", 
				 	pageInstance.Process.GetPropertyValue("MacrosList").ToString());
				 
			 };
			
			Page.SaveToFileButton.AjaxEvents.Click.IsUpload = true;
			
			Page.DataTabPanel.IgnoreProfileProperties.Add("activetabindex");
			return true;
		}

		public virtual bool ScriptTask8Execute(ProcessExecutingContext context) {
			UserMessageUserTask.Page = Page;
			UserMessageUserTask.MessageText = UserQuestionTitle;
			UserMessageUserTask.Icon = "QUESTION";
			UserMessageUserTask.Buttons = "YESNO";
			UserMessageUserTask.ResponseMessages = new Dictionary<string, string> {
				{"yes", "UserQuestionYesMessage"},
				{"no", "UserQuestionNoMessage"}
			};
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var macrosList = Page.SysModuleReportFieldsPageContainer
				.PageInstance.Process.GetPropertyValue("MacrosList").ToString();
			if (macrosList != Page.DataSource.ActiveRow.GetTypedColumnValue<string>("MacrosList")) {
				Page.DataSource.ActiveRow.SetColumnValue("MacrosList", macrosList);
			}
			
			return true;
		}

		public virtual bool CheckObjectNamesExecute(ProcessExecutingContext context) {
			var reportId = Page.DataSource.ActiveRowPrimaryColumnValue;
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModuleReportTable");
			esq.AddColumn("Caption");
			esq.AddColumn("MacrosList");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysModuleReport", reportId));
			var linkedTables = esq.GetEntityCollection(UserConnection);
			var reportColumnListStr = Page.DataSource.ActiveRow.GetTypedColumnValue<string>("MacrosList");
			var reportColumns = (Json.Deserialize(reportColumnListStr) as JArray).Select(x => new {
				Caption = x.Value<string>("caption") ?? string.Empty,
				MetaPathCaption = x.Value<string>("metaPathCaption") ?? string.Empty
			});
			ConflictedObjectName = null;
			foreach (var table in linkedTables) {
				var tableCaption = table.GetTypedColumnValue<string>("Caption");
				var tableColumnListStr = table.GetTypedColumnValue<string>("MacrosList");
				var tableColumns = (Json.Deserialize(tableColumnListStr) as JArray).Select(x => new {
					Caption = $"{tableCaption}.{x.Value<string>("caption") ?? string.Empty}",
					MetaPathCaption = $"{tableCaption}.{x.Value<string>("metaPathCaption") ?? string.Empty}"
				});
				foreach (var tableColumn in tableColumns) {
					var hasConflict = reportColumns.Any(x => 
						x.Caption == tableColumn.Caption ||
						x.Caption == tableColumn.MetaPathCaption ||
						x.MetaPathCaption == tableColumn.Caption ||
						x.MetaPathCaption == tableColumn.MetaPathCaption);
					if (hasConflict) {
						ConflictedObjectName = tableCaption;
						return true;
					}
				}
			}
			return true;
		}

		public virtual bool PrepareInvalidObjectNameMessageParametersExecute(ProcessExecutingContext context) {
			ShowInvalidObjectNameUserTask.Page = Page;
			ShowInvalidObjectNameUserTask.MessageText = string.Format(ShowInvalidObjectNameUserTaskMessage, ConflictedObjectName);
			ShowInvalidObjectNameUserTask.Icon = "QUESTION";
			ShowInvalidObjectNameUserTask.Buttons = "OK";
			return true;
		}

		public virtual bool CheckReportCaptionScriptTaskExecute(ProcessExecutingContext context) {
			InvalidCaptionMessage = null;
			string caption = Page.CaptionEdit.LocalizableText;
			var invalidFileNameChars = Path.GetInvalidFileNameChars();
			var index = caption.IndexOfAny(invalidFileNameChars);
			if (index >= 0) {
				InvalidCaptionMessage = InvalidCaptionMessageTpl;
			}
			return true;
		}

		public virtual bool PrepareInvalidCaptionMessageWindowParametersExecute(ProcessExecutingContext context) {
			OpenInvalidCaptionMessageUserTask.Page = Page;
			OpenInvalidCaptionMessageUserTask.MessageText = InvalidCaptionMessage;
			OpenInvalidCaptionMessageUserTask.Icon = "QUESTION";
			OpenInvalidCaptionMessageUserTask.Buttons = "OK";
			return true;
		}

		public virtual bool CheckReportColumnsCaptionsScriptTaskExecute(ProcessExecutingContext context) {
			InvalidColumnCaptionMessage = null;
			var macrosList = Json.Deserialize(Page.SysModuleReportFieldsPageContainer
				.PageInstance.Process.GetPropertyValue("MacrosList").ToString()) as JArray ?? new JArray();
			var reportId = Page.DataSource.ActiveRowPrimaryColumnValue;
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModuleReportTable");
			esq.AddColumn("Caption");
			esq.AddColumn("MacrosList");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysModuleReport", reportId));
			var linkedTables = esq.GetEntityCollection(UserConnection);
			string[] invalidColumnCaptionChars = {"#", "."};
			foreach (var table in linkedTables) {
				var tableCaption = table.GetTypedColumnValue<string>("Caption");
				var tableCaptionInvalid = invalidColumnCaptionChars.Any(invalidChar => tableCaption.IndexOf(invalidChar) >= 0);
				if (tableCaptionInvalid) {
					InvalidColumnCaptionMessage = InvalidColumnCaptionMessageTpl;
					return true;
				}
				var tableColumnListStr = table.GetTypedColumnValue<string>("MacrosList");
				var tableColumns = Json.Deserialize(tableColumnListStr) as JArray;
				macrosList.Merge(tableColumns);
			}
			foreach (var column in macrosList) {
				var caption = column.Value<string>("caption");
				var regex = new Regex(@"(?<=\[#)(?<macros>[^(#\])]*)(?=#\])", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.ExplicitCapture);
				var macrosCount = regex.Matches(caption).Count;
				var charsInMacrosCount = 2;
				var charCount = caption.Count(x => x == '#');
				if (macrosCount * charsInMacrosCount != charCount) {
					InvalidColumnCaptionMessage = InvalidColumnCaptionMessageTpl;
					return true;
				}
			}
			return true;
		}

		public virtual bool PrepareInvalidColumnCaptionMessageWindowParametersExecute(ProcessExecutingContext context) {
			OpenInvalidColumnCaptionMessageUserTask.Page = Page;
			OpenInvalidColumnCaptionMessageUserTask.MessageText = InvalidColumnCaptionMessage;
			OpenInvalidColumnCaptionMessageUserTask.Icon = "QUESTION";
			OpenInvalidColumnCaptionMessageUserTask.Buttons = "OK";
			return true;
		}

		public override void OkClickMethod() {
			var primaryCultureinfo = UserConnection.GetPrimaryCultureInfo();
			if(!Page.CaptionEdit.LocalizableText.HasCultureValue(primaryCultureinfo)) {
				Page.CaptionEdit.LocalizableText.SetCultureValue(primaryCultureinfo, Page.CaptionEdit.LocalizableText);
			}
			
			UserConnection.SessionData["IsFileChanged"] = IsFileChanged;
			IsNotWindowClose = false;
			string caption = Page.CaptionEdit.LocalizableText.GetCultureValue(UserConnection.GetPrimaryCultureInfo());
			var converters = new JsonConverter[] {new GuidJsonConverter()};
			string id = Json.Serialize(Page.DataSource.ActiveRow.PrimaryColumnValue, converters[0]);
			Page.ScriptManager.AddScript(Page.DataSource.ClientID + 
					".onActiveRowColumnValuesChangedResponse(" 
					 + id + ",{\"Caption\" : {columnValue: "
					 + Json.Serialize(caption) + "}});");
			base.OkClickMethod();
		}

		public override Dictionary<string, object> GetDefValues() {
			Dictionary<string, object> defValues = base.GetDefValues();
			defValues["SysModule"] = SelectedModuleId;
			return defValues;
		}

		public virtual void SetCustomTemplateProperty(Stream fileStream, string propertyValue) {
			if (fileStream.Length == 0) {
			  return;
			}
			var newProp = new CustomDocumentProperty();
			newProp.VTLPWSTR = new VTLPWSTR(propertyValue);
			newProp.FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}";
			newProp.Name = AttributeName;
			
			using (var document = WordprocessingDocument.Open(fileStream, true)) {
			  var customProps = document.CustomFilePropertiesPart;
			  if (customProps == null) {
				customProps = document.AddCustomFilePropertiesPart();
				customProps.Properties = new DocumentFormat.OpenXml.
				  CustomProperties.Properties();
			  }
			
			  var props = customProps.Properties;
			  if (props != null) {
				var prop = props.
				  Where(p => ((CustomDocumentProperty)p).
					Name.Value == AttributeName).FirstOrDefault();
				if (prop != null) {
				  prop.Remove();
				}
			
				props.AppendChild(newProp);
				int pid = 2;
				foreach (CustomDocumentProperty item in props){
				  item.PropertyId = pid++;
				}
				props.Save();
			  }
			}
		}

		public virtual Guid GetParentEntitySchemaId(Guid sysModuleId) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("SysModule");
			var entitySchemaQuery = new Terrasoft.Core.Entities.EntitySchemaQuery(schema);
			var column = entitySchemaQuery.AddColumn("SysModuleEntity.SysEntitySchemaUId");
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
																						schema.PrimaryColumn.Name, sysModuleId));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return entities[0].GetTypedColumnValue<Guid>("SysModuleEntity_SysEntitySchemaUId");
			} 
			
			return Guid.Empty;
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

		public virtual DataSourceStructureColumn CreateColumn(EntitySchema schema, string metaPath) {
			EntitySchemaColumn entitySchemaColumn = schema.FindSchemaColumnByMetaPath(metaPath);
			if (entitySchemaColumn == null) {
				return null;
			}
			
			string path = schema.GetSchemaColumnPathByMetaPath(metaPath);
			string metaPathCaption = schema.GetSchemaColumnFullCaptionByPath(path);
			var column = new DataSourceStructureColumn {
				UId = Guid.NewGuid(),
				MetaPath = metaPath,
				MetaPathCaption = metaPathCaption,
				DataValueType = entitySchemaColumn.DataValueType,
				Name = entitySchemaColumn.Name,
				Caption = entitySchemaColumn.Caption
			};
			
			return column;
		}

		public virtual EntitySchemaColumn FindColumnByCaption(EntitySchema schema, string caption) {
			foreach (var item in schema.Columns) {
				if (item.Caption.Value.Equals(caption)) {
					return item;
				}
			}
			return null;
		}

		public virtual DataSourceStructureColumn CreateReferenceColumn(EntitySchema schema, List<string> macrosParts) {
			var metaPath = new StringBuilder();
			var metaPathCaption = new StringBuilder();
			var name = new StringBuilder();
			var caption = new StringBuilder();
			
			var column = FindColumnByCaption(schema, macrosParts[0]);
			var dataValueType = column.DataValueType;
			metaPath.Append(column.UId.ToString());
			metaPathCaption.Append(column.Caption);
			name.Append(column.Name);
			caption.Append(column.Caption);
			
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			
			for (int i = 1; i < macrosParts.Count; i++) {
				if (column.ReferenceSchemaUId != Guid.Empty) {
					var referenceSchema = entitySchemaManager.GetInstanceByUId(column.ReferenceSchemaUId);
					column = FindColumnByCaption(referenceSchema, macrosParts[i]);
					metaPath.Append(".");
					metaPath.Append(column.UId.ToString());
					metaPathCaption.Append(".");
					metaPathCaption.Append(column.Caption);
					name.Append("_");
					name.Append(column.Name);
					caption.Append(".");
					caption.Append(column.Caption);
					if ( i == macrosParts.Count - 1) {
						dataValueType = column.DataValueType;
					}
				} else {
					break;
				}
			}
			
			return new DataSourceStructureColumn {
				UId = Guid.NewGuid(),
				MetaPath = metaPath.ToString(),
				MetaPathCaption = metaPathCaption.ToString(),
				DataValueType = dataValueType,
				Name = name.ToString(),
				Caption = caption.ToString()
			};
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysModuleEditChange":
							if (ActivatedEventElements.Contains("SysModuleEditChangeStartMessage4")) {
							context.QueueTasks.Enqueue("SysModuleEditChangeStartMessage4");
						}
						break;
					case "UploadTemplateButtonUpload":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "SaveToFileButtonClick":
							if (ActivatedEventElements.Contains("ChildSaveToFileButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("ChildSaveToFileButtonClickStartMessage");
						}
						break;
					case "DataSourceSaved":
							if (ActivatedEventElements.Contains("StartMessageDataSourceSaved")) {
							context.QueueTasks.Enqueue("StartMessageDataSourceSaved");
							ProcessQueue(context);
							return;
						}
						break;
					case "UserQuestionYesMessage":
							if (ActivatedEventElements.Contains("StartMessage6")) {
							context.QueueTasks.Enqueue("StartMessage6");
						}
						break;
					case "UserQuestionNoMessage":
							if (ActivatedEventElements.Contains("StartMessage7")) {
							context.QueueTasks.Enqueue("StartMessage7");
						}
						break;
					case "FileUploadEditChange":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("BeforeParentPageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("BeforeParentPageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
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
			if (!HasMapping("InvalidColumnCaptionMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("InvalidColumnCaptionMessage", InvalidColumnCaptionMessage, null);
			}
			if (!HasMapping("InvalidCaptionMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("InvalidCaptionMessage", InvalidCaptionMessage, null);
			}
			if (!HasMapping("ConflictedObjectName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ConflictedObjectName", ConflictedObjectName, null);
			}
			if (!HasMapping("DefMSWordReportTemplateKnowledgeBaseCode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DefMSWordReportTemplateKnowledgeBaseCode", DefMSWordReportTemplateKnowledgeBaseCode, null);
			}
			if (!HasMapping("IsFileChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsFileChanged", IsFileChanged, false);
			}
			if (!HasMapping("FileName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileName", FileName, null);
			}
			if (!HasMapping("CloseWindowAfterSave") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CloseWindowAfterSave", CloseWindowAfterSave, false);
			}
			if (!HasMapping("NeedSendAllowMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedSendAllowMessage", NeedSendAllowMessage, false);
			}
			if (!HasMapping("ParentEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentEntitySchemaId", ParentEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("SelectedModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedModuleId", SelectedModuleId, Guid.Empty);
			}
			if (!HasMapping("AttributeName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AttributeName", AttributeName, null);
			}
			if (!HasMapping("ColumnStructureExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerRegistered", ColumnStructureExplorerRegistered, false);
			}
			if (ColumnStructureExplorer != null) {
				if (ColumnStructureExplorer.GetType().IsSerializable ||
					ColumnStructureExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnStructureExplorer", ColumnStructureExplorer, null);
				}
			}
			if (!HasMapping("ColumnStructureExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerCreated", ColumnStructureExplorerCreated, false);
			}
			if (!HasMapping("FileSize") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileSize", FileSize, 0);
			}
			if (!HasMapping("FileContent") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileContent", FileContent, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportMSWordEditPageEventsProcess

	/// <exclude/>
	public class SysModuleReportMSWordEditPageEventsProcess : SysModuleReportMSWordEditPageEventsProcess<Terrasoft.WebApp.SysModuleReportMSWordEditPageSchemaUserControl>
	{

		public SysModuleReportMSWordEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReportMSWordEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleReportMSWordEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LocalizableTextEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysModuleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysModuleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FileUploadEdit FileUploadEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FileUploadEdit)PageContainer.FindPageControl("FileUploadEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInSectionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ShowInSectionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInCardEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ShowInCardEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FileUploadButton UploadTemplateButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.FileUploadButton)PageContainer.FindPageControl("UploadTemplateButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SaveToFileButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SaveToFileButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel DataTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("DataTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab SysModuleReportFieldsTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("SysModuleReportFieldsTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer SysModuleReportFieldsPageContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("SysModuleReportFieldsPageContainer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab SysModuleReportTableTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("SysModuleReportTableTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer AdditionalMacrosesPageContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("AdditionalMacrosesPageContainer", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SysModuleEdit.AjaxEvents.Change.Event += SysModuleEditChange;
			FileUploadEdit.AjaxEvents.Change.Event += FileUploadEditChange;
			UploadTemplateButton.AjaxEvents.Upload.Event += UploadTemplateButtonUpload;
			SaveToFileButton.AjaxEvents.Click.Event += SaveToFileButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SysModuleEdit.AjaxEvents.Change.Event -= SysModuleEditChange;
			FileUploadEdit.AjaxEvents.Change.Event -= FileUploadEditChange;
			UploadTemplateButton.AjaxEvents.Upload.Event -= UploadTemplateButtonUpload;
			SaveToFileButton.AjaxEvents.Click.Event -= SaveToFileButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleReportMSWordEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleReportMSWordEditPageEventsProcess(UserConnection);
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

		public virtual void SysModuleEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SysModuleEditChange");
		}

		public virtual void FileUploadEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("FileUploadEditChange");
		}

		public virtual void UploadTemplateButtonUpload(object sender, EventArgs e) {
			object result = ThrowEvent("UploadTemplateButtonUpload");
		}

		public virtual void SaveToFileButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SaveToFileButtonClick");
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
			SchemaName = "SysModuleReportMSWordEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportMSWordEditPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportMSWordEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportMSWordEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportMSWordEditPageEventsProcessSchema(SysModuleReportMSWordEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReportMSWordEditPageEventsProcess";
			UId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921");
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

		protected virtual ProcessSchemaParameter CreateFileContentParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a191d33e-5a0c-46a6-a4e6-947d8ba4e35e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"FileContent",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileSizeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ca6e95a7-e951-4b53-b4e6-98f0d7246290"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"FileSize",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ac69c0d5-fd0b-45c2-911f-07179a779324"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ColumnStructureExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fddc04f4-8bde-4e72-b1b4-efd35484af69"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ColumnStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d38c86e7-65ee-4028-9a65-30ff49f579a3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ColumnStructureExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAttributeNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f368f642-0041-426f-918b-1a153df3fddd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"AttributeName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e85a7551-a875-4e79-b518-49cac0435411"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"SelectedModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02963707-ddd2-4f69-b207-71211355e537"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ParentEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSendAllowMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("90595701-a8e3-4c08-b6b7-0aa9042f1972"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"NeedSendAllowMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCloseWindowAfterSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fc237f42-9024-4233-a4e1-0fe69a4f45cd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"CloseWindowAfterSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b55680b4-bcdb-4d63-8b1f-ebefad0e7612"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"FileName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsFileChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be905a5a-9cd9-4aa5-877a-1f61d65bd844"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"IsFileChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefMSWordReportTemplateKnowledgeBaseCodeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b968c49b-fe0e-4472-8878-9827bf8bebbd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"DefMSWordReportTemplateKnowledgeBaseCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateConflictedObjectNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("41e9cfd4-7760-4c20-8418-79aff1bbbecf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ConflictedObjectName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInvalidCaptionMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5c26e92f-69ec-4aff-905e-ca750b7c072f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"InvalidCaptionMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInvalidColumnCaptionMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b1365fe6-2df8-4f20-891a-e6f2a25228fe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"InvalidColumnCaptionMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFileContentParameter());
			Parameters.Add(CreateFileSizeParameter());
			Parameters.Add(CreateColumnStructureExplorerCreatedParameter());
			Parameters.Add(CreateColumnStructureExplorerParameter());
			Parameters.Add(CreateColumnStructureExplorerRegisteredParameter());
			Parameters.Add(CreateAttributeNameParameter());
			Parameters.Add(CreateSelectedModuleIdParameter());
			Parameters.Add(CreateParentEntitySchemaIdParameter());
			Parameters.Add(CreateNeedSendAllowMessageParameter());
			Parameters.Add(CreateCloseWindowAfterSaveParameter());
			Parameters.Add(CreateFileNameParameter());
			Parameters.Add(CreateIsFileChangedParameter());
			Parameters.Add(CreateDefMSWordReportTemplateKnowledgeBaseCodeParameter());
			Parameters.Add(CreateConflictedObjectNameParameter());
			Parameters.Add(CreateInvalidCaptionMessageParameter());
			Parameters.Add(CreateInvalidColumnCaptionMessageParameter());
		}

		protected virtual void InitializeUserMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c0fe85cb-43ce-4691-9b5f-80c87b07ff1e"),
				ContainerUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
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
				UId = new Guid("dcacea37-00df-4782-87a4-18abb007a53c"),
				ContainerUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
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
				UId = new Guid("13fbb36c-555c-46c0-978a-9f3634771b4a"),
				ContainerUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
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
				UId = new Guid("fcc4b813-b3ef-4002-a429-d5760a7f22f3"),
				ContainerUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
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
				UId = new Guid("0e06e086-7752-4586-9d71-bb1f5eb165ce"),
				ContainerUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
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
				UId = new Guid("aba96f09-d525-4b2c-91be-5c679a533a01"),
				ContainerUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
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
				UId = new Guid("eaf6465f-c675-4d18-924e-a97c8f5ce1de"),
				ContainerUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
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
				UId = new Guid("01ab5061-f753-4bf5-8ca6-18df78923874"),
				ContainerUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
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

		protected virtual void InitializeShowInvalidObjectNameUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d7a9987b-4419-4552-9388-1b489ea2c9cc"),
				ContainerUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
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
				UId = new Guid("73b4e5f4-3d77-43d1-9788-286418217048"),
				ContainerUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
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
				UId = new Guid("04b4d33f-0e15-4a54-b394-51f8d0550667"),
				ContainerUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
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
				UId = new Guid("6bda2847-b548-4c21-8895-fa11e5b28a1d"),
				ContainerUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
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
				UId = new Guid("cc043a7b-8202-4e9e-9659-e1788fcf9b28"),
				ContainerUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
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
				UId = new Guid("91ef9ac3-bd62-4922-af85-a1aace2b1aee"),
				ContainerUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
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
				UId = new Guid("9f36736d-5767-4743-8405-940dbadfabf4"),
				ContainerUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
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
				UId = new Guid("5804c137-4ddc-4b73-b887-c2acbd8fd1aa"),
				ContainerUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
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
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected virtual void InitializeOpenInvalidCaptionMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("9acca5e8-4b72-4615-8699-449e9f15bd61"),
				ContainerUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
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
				UId = new Guid("85c8432e-94a5-4591-a4c0-8de28142b084"),
				ContainerUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
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
				UId = new Guid("4d0038a5-e56d-4d29-8264-f1afab1d46f7"),
				ContainerUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
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
				UId = new Guid("85edf29b-b334-441a-bddc-5dd508a5cbe2"),
				ContainerUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
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
				UId = new Guid("84a1c6ec-0901-4c03-9aa0-82e5c09c5cfc"),
				ContainerUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
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
				UId = new Guid("ea5be265-7dd6-437d-987f-4c3f46974d67"),
				ContainerUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
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
				UId = new Guid("92eccddf-b969-418f-9da5-b9e4b493ade5"),
				ContainerUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
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
				UId = new Guid("78fa2cc9-d264-43cf-982f-6c580b11ff3f"),
				ContainerUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
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
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected virtual void InitializeOpenInvalidColumnCaptionMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("516136f9-cc85-42fa-9b9a-b83ce5cfa22e"),
				ContainerUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
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
				UId = new Guid("04234c10-a3c1-48f3-a067-9b1b4c4df33f"),
				ContainerUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
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
				UId = new Guid("51533ddc-0e9a-4c5d-a583-8cdbbdbe72c1"),
				ContainerUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
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
				UId = new Guid("d9040c76-815a-4600-9247-3b4789b574e3"),
				ContainerUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
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
				UId = new Guid("9476e79f-f52e-47be-9fa6-3095b0c5647a"),
				ContainerUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
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
				UId = new Guid("699ae06c-00d3-4340-a4c9-943ccd2f9947"),
				ContainerUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
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
				UId = new Guid("ba52586b-515f-45ef-8b50-9956a33717cf"),
				ContainerUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
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
				UId = new Guid("002adc64-9cfc-4dae-904d-aff59687aac5"),
				ContainerUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
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
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaStartMessageEvent sysmoduleeditchangestartmessage4 = CreateSysModuleEditChangeStartMessage4StartMessageEvent();
			eventsubprocess4.FlowElements.Add(sysmoduleeditchangestartmessage4);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask4);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess11.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess11.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent childsavetofilebuttonclickstartmessage = CreateChildSaveToFileButtonClickStartMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(childsavetofilebuttonclickstartmessage);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask2);
			ProcessSchemaStartMessageEvent startmessagedatasourcesaved = CreateStartMessageDataSourceSavedStartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessagedatasourcesaved);
			ProcessSchemaIntermediateThrowMessageEvent datasourcesavedintermediatethrowmessageevent = CreateDataSourceSavedIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(datasourcesavedintermediatethrowmessageevent);
			ProcessSchemaScriptTask scripttask9 = CreateScriptTask9ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask9);
			ProcessSchemaStartMessageEvent startmessage6 = CreateStartMessage6StartMessageEvent();
			eventsubprocess7.FlowElements.Add(startmessage6);
			ProcessSchemaScriptTask userquestionyesmessagescripttask = CreateUserQuestionYesMessageScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(userquestionyesmessagescripttask);
			ProcessSchemaStartMessageEvent startmessage7 = CreateStartMessage7StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage7);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent5 = CreateIntermediateThrowMessageEvent5IntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(intermediatethrowmessageevent5);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask fileuploadeditchangescripttask = CreateFileUploadEditChangeScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(fileuploadeditchangescripttask);
			ProcessSchemaStartMessageEvent beforeparentpageloadcompletestartmessage = CreateBeforeParentPageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(beforeparentpageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask afterparentpageloadcompletescripttask = CreateAfterParentPageLoadCompleteScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(afterparentpageloadcompletescripttask);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask5);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask chilinitscripttask = CreateChilInitScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(chilinitscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess6.FlowElements.Add(startmessage5);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			eventsubprocess6.FlowElements.Add(exclusivegateway3);
			ProcessSchemaScriptTask scripttask8 = CreateScriptTask8ScriptTask();
			eventsubprocess6.FlowElements.Add(scripttask8);
			ProcessSchemaUserTask usermessageusertask = CreateUserMessageUserTaskUserTask();
			eventsubprocess6.FlowElements.Add(usermessageusertask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess6.FlowElements.Add(scripttask1);
			ProcessSchemaScriptTask checkobjectnames = CreateCheckObjectNamesScriptTask();
			eventsubprocess6.FlowElements.Add(checkobjectnames);
			ProcessSchemaExclusiveGateway exclusivegateway4_c3c2379d3b364c4fb44ecc5b953c78af = CreateExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78afExclusiveGateway();
			eventsubprocess6.FlowElements.Add(exclusivegateway4_c3c2379d3b364c4fb44ecc5b953c78af);
			ProcessSchemaScriptTask prepareinvalidobjectnamemessageparameters = CreatePrepareInvalidObjectNameMessageParametersScriptTask();
			eventsubprocess6.FlowElements.Add(prepareinvalidobjectnamemessageparameters);
			ProcessSchemaUserTask showinvalidobjectnameusertask = CreateShowInvalidObjectNameUserTaskUserTask();
			eventsubprocess6.FlowElements.Add(showinvalidobjectnameusertask);
			ProcessSchemaScriptTask checkreportcaptionscripttask = CreateCheckReportCaptionScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(checkreportcaptionscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway5_5c55d4e28be741bdab047b3096c6d2b4 = CreateExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4ExclusiveGateway();
			eventsubprocess6.FlowElements.Add(exclusivegateway5_5c55d4e28be741bdab047b3096c6d2b4);
			ProcessSchemaUserTask openinvalidcaptionmessageusertask = CreateOpenInvalidCaptionMessageUserTaskUserTask();
			eventsubprocess6.FlowElements.Add(openinvalidcaptionmessageusertask);
			ProcessSchemaScriptTask prepareinvalidcaptionmessagewindowparameters = CreatePrepareInvalidCaptionMessageWindowParametersScriptTask();
			eventsubprocess6.FlowElements.Add(prepareinvalidcaptionmessagewindowparameters);
			ProcessSchemaScriptTask checkreportcolumnscaptionsscripttask = CreateCheckReportColumnsCaptionsScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(checkreportcolumnscaptionsscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway6_9a817989adcc47c6bdaec0c5e41a1385 = CreateExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385ExclusiveGateway();
			eventsubprocess6.FlowElements.Add(exclusivegateway6_9a817989adcc47c6bdaec0c5e41a1385);
			ProcessSchemaUserTask openinvalidcolumncaptionmessageusertask = CreateOpenInvalidColumnCaptionMessageUserTaskUserTask();
			eventsubprocess6.FlowElements.Add(openinvalidcolumncaptionmessageusertask);
			ProcessSchemaScriptTask prepareinvalidcolumncaptionmessagewindowparameters = CreatePrepareInvalidColumnCaptionMessageWindowParametersScriptTask();
			eventsubprocess6.FlowElements.Add(prepareinvalidcolumncaptionmessagewindowparameters);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2_4e4c422a540f4d259a65fcd7cc1f9878SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15_3908958148d4488b8b824d05d30aa39bSequenceFlow());
			FlowElements.Add(CreateSequenceFlow19_5cec553019154254979a0ac3024347cbSequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3_7692ef790c6e4dd29c5417e35f958602SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20_0183edf5bf4144a7a6feada2b4880c01SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13_7e5d498b9fb64f8c9fdcd02e0e922cceSequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fbConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow4_29f3221c3a924a98b68357122716ab37SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21_bf57a074f0ce43209d5e21b62932347dSequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1_0675b6f82f004ef5a7801d91931559d0SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow22_48654c6f3e1542f8838de93c752a9fc5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23_f7be47f8686d4285b55480948c22bbafSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDefaultTemplateFileNameLocalizableString());
			LocalizableStrings.Add(CreateUserQuestionTitleLocalizableString());
			LocalizableStrings.Add(CreateShowInvalidObjectNameUserTaskMessageLocalizableString());
			LocalizableStrings.Add(CreateInvalidCaptionMessageTplLocalizableString());
			LocalizableStrings.Add(CreateInvalidColumnCaptionMessageTplLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDefaultTemplateFileNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("56d8729e-c162-4543-9c0d-12c191f2137e"),
				Name = "DefaultTemplateFileName",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUserQuestionTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("68bd63bb-03f4-4c5a-a0f2-f2a6e31091c8"),
				Name = "UserQuestionTitle",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateShowInvalidObjectNameUserTaskMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7cac1d1d-3f2a-43fd-bc24-5486a7af6496"),
				Name = "ShowInvalidObjectNameUserTaskMessage",
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInvalidCaptionMessageTplLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6be1c2ce-6e08-448f-b2cc-1f02a2ce358d"),
				Name = "InvalidCaptionMessageTpl",
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInvalidColumnCaptionMessageTplLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("045fcaf0-5d43-4813-b0f7-143a1793c740"),
				Name = "InvalidColumnCaptionMessageTpl",
				CreatedInPackageId = new Guid("9a523c3d-01af-48e1-ae7e-8726470b5821"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("768b228b-1f1b-4aab-b710-f00b227920b0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(216, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71b0cfd6-251e-4441-ae4f-87190574f49a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b01f80b7-9929-4ccb-af87-95adc347a68e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("270ae926-907b-49b4-b8f8-fd97884de726"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(340, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("277c925c-4c33-425a-bb03-ec3c205d0463"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c9a60923-5469-4e14-8a9e-fa737325d7ef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("08eb96de-3042-4815-94e0-9634095d1144"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("30d12d9d-56a2-4d55-8cc9-64930de5073c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eac2b15d-816d-461a-85a0-2d71018adac6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("0d89d378-58b3-4a3b-887a-3e15c48c6f3f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(292, 448),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("feced922-af16-4028-a17c-7d045324c795"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b4255e6-eb4e-4e25-9f76-6a392d30a590"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("fc9d9d97-7213-479b-8c9c-d69ceb915979"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(363, 450),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7b4255e6-eb4e-4e25-9f76-6a392d30a590"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6e6c203d-3118-4b7f-97ab-c36ec28916da"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("112a9654-b56d-47ac-8885-c968463be2a1"),
				ConditionExpression = @"string.IsNullOrEmpty(Page.DataSource.ActiveRow.GetTypedColumnValue<string>(""MacrosList""))",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(350, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("04f672c2-5459-4f5b-8e8b-8f8e7f344475"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("31d2e6b5-98d9-4eeb-9170-1142c7656244"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("6be665bb-7b90-4e34-b48f-e05e038fae4a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(497, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("31d2e6b5-98d9-4eeb-9170-1142c7656244"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(572, 2552));
			schemaFlow.PolylinePointPositions.Add(new Point(572, 2549));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("be9e2ca2-c8d5-4fa6-a6ee-ab0f00b09cca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(210, 532),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1a66e820-715b-431c-bfe8-44d49a1551fa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6173e659-c1ed-4303-a393-ea21eba91519"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("c4866e80-167b-49f8-8635-89f5aded331a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(196, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("def1ab16-e08c-4e78-bc53-e0be161c5644"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fb157cb1-8951-4547-a453-68b42ee5a9c6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("abf1837c-a3e1-48df-ac76-c44ed07d1f00"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(342, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb157cb1-8951-4547-a453-68b42ee5a9c6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4caa1198-f2e9-41b5-8c22-4a58688c8be1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("0cd2624d-959a-4282-8a83-2d3bed877f33"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("66bf4a1c-9a66-4fa1-bcc8-fd68307e56da"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f6a3d828-4b8f-4c9f-8bc7-5dfe813a2827"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("bd9640e2-5327-43bf-8c1a-a43d38f55ead"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("902a598f-818e-4372-afc2-082fdb54fae9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("21a6c3ab-db15-4f98-8bd6-e31f78ce1681"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("44340336-a6a8-41e3-a9c3-d73abc06cd80"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(381, 650),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("220641bc-9be7-420e-8797-0183b27fa623"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("04f672c2-5459-4f5b-8e8b-8f8e7f344475"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(309, 2550));
			schemaFlow.PolylinePointPositions.Add(new Point(309, 2552));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("1c9a5ff1-abb6-4fc2-a344-4873d8da25b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(220, 902),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("91d00f34-5d44-448b-8d50-693d66d497d3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7835f3b8-62d3-4ec1-8808-47e14584847a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(112, 1189));
			schemaFlow.PolylinePointPositions.Add(new Point(112, 1191));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("c4aa7650-2bc6-48f8-8bd5-b77586e17256"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7bf0f17f-d01d-4ddd-9e51-77ac55e598d6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bed080b9-0b6d-457c-ae0b-696dc947ea7f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("28de65bc-22d9-49bb-ade8-b91b74444595"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(216, 106),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b01f80b7-9929-4ccb-af87-95adc347a68e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("277c925c-4c33-425a-bb03-ec3c205d0463"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1_f8971421111c4e819d44f2f10a949e38",
				UId = new Guid("f8971421-111c-4e81-9d44-f2f10a949e38"),
				ConditionExpression = @"ConflictedObjectName == null",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3c2379d-3b36-4c4f-b44e-cc5b953c78af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5330ea13-7927-4a71-b919-b9fabfaa720b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(374, 2806));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2_4e4c422a540f4d259a65fcd7cc1f9878SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2_4e4c422a540f4d259a65fcd7cc1f9878",
				UId = new Guid("4e4c422a-540f-4d25-9a65-fcd7cc1f9878"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3c2379d-3b36-4c4f-b44e-cc5b953c78af"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("89d64b1c-bdc2-40d7-a137-922f83d3c700"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15_3908958148d4488b8b824d05d30aa39bSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15_3908958148d4488b8b824d05d30aa39b",
				UId = new Guid("39089581-48d4-488b-8b82-4d05d30aa39b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("89d64b1c-bdc2-40d7-a137-922f83d3c700"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19_5cec553019154254979a0ac3024347cbSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19_5cec553019154254979a0ac3024347cb",
				UId = new Guid("5cec5530-1915-4254-979a-0ac3024347cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c4aa2d7-c662-4396-949e-035854b560fc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c55d4e2-8be7-41bd-ab04-7b3096c6d2b4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3_7692ef790c6e4dd29c5417e35f958602SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3_7692ef790c6e4dd29c5417e35f958602",
				UId = new Guid("7692ef79-0c6e-4dd2-9c54-17e35f958602"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c55d4e2-8be7-41bd-ab04-7b3096c6d2b4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("55d9eaf4-5754-42ac-be59-b716e2c7527c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20_0183edf5bf4144a7a6feada2b4880c01SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20_0183edf5bf4144a7a6feada2b4880c01",
				UId = new Guid("0183edf5-bf41-44a7-a6fe-ada2b4880c01"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55d9eaf4-5754-42ac-be59-b716e2c7527c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13_7e5d498b9fb64f8c9fdcd02e0e922cceSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13_7e5d498b9fb64f8c9fdcd02e0e922cce",
				UId = new Guid("7e5d498b-9fb6-4f8c-9fdc-d02e0e922cce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2b521b7d-bb3e-4cf0-87fd-c0326b95a001"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c4aa2d7-c662-4396-949e-035854b560fc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fbConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2_7eca7a464a0247b0abcdef2ea78de7fb",
				UId = new Guid("7eca7a46-4a02-47b0-abcd-ef2ea78de7fb"),
				ConditionExpression = @"InvalidCaptionMessage == null",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c55d4e2-8be7-41bd-ab04-7b3096c6d2b4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("95da3e2c-e197-4979-a1d0-9e5d043c23e8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(377, 2290));
			schemaFlow.PolylinePointPositions.Add(new Point(224, 2290));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow4_29f3221c3a924a98b68357122716ab37SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow4_29f3221c3a924a98b68357122716ab37",
				UId = new Guid("29f3221c-3a92-4a98-b683-57122716ab37"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("04f672c2-5459-4f5b-8e8b-8f8e7f344475"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ea8a10b-0b86-47d6-bfa8-fbb535351eb7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(386, 2610));
			schemaFlow.PolylinePointPositions.Add(new Point(216, 2610));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21_bf57a074f0ce43209d5e21b62932347dSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21_bf57a074f0ce43209d5e21b62932347d",
				UId = new Guid("bf57a074-f0ce-4320-9d5e-21b62932347d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ea8a10b-0b86-47d6-bfa8-fbb535351eb7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c3c2379d-3b36-4c4f-b44e-cc5b953c78af"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1_0675b6f82f004ef5a7801d91931559d0SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1_0675b6f82f004ef5a7801d91931559d0",
				UId = new Guid("0675b6f8-2f00-4ef5-a780-1d91931559d0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("9a523c3d-01af-48e1-ae7e-8726470b5821"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9a817989-adcc-47c6-bdae-c0c5e41a1385"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("92fb43c2-731c-4c4a-b2c0-298bf7d2355e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow3_95547e1d9d2542efbab602cf5f2d46b2",
				UId = new Guid("95547e1d-9d25-42ef-bab6-02cf5f2d46b2"),
				ConditionExpression = @"InvalidColumnCaptionMessage == null",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("9a523c3d-01af-48e1-ae7e-8726470b5821"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9a817989-adcc-47c6-bdae-c0c5e41a1385"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("220641bc-9be7-420e-8797-0183b27fa623"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(429, 2410));
			schemaFlow.PolylinePointPositions.Add(new Point(429, 2492));
			schemaFlow.PolylinePointPositions.Add(new Point(224, 2492));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22_48654c6f3e1542f8838de93c752a9fc5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22_48654c6f3e1542f8838de93c752a9fc5",
				UId = new Guid("48654c6f-3e15-42f8-838d-e93c752a9fc5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("9a523c3d-01af-48e1-ae7e-8726470b5821"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("95da3e2c-e197-4979-a1d0-9e5d043c23e8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9a817989-adcc-47c6-bdae-c0c5e41a1385"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23_f7be47f8686d4285b55480948c22bbafSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23_f7be47f8686d4285b55480948c22bbaf",
				UId = new Guid("f7be47f8-686d-4285-b554-80948c22bbaf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("9a523c3d-01af-48e1-ae7e-8726470b5821"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("92fb43c2-731c-4c4a-b2c0-298bf7d2355e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("64504545-3251-4d4e-8c1d-f3a121fa396c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1559, 159),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("64504545-3251-4d4e-8c1d-f3a121fa396c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"Lane3",
				Position = new Point(29, 0),
				Size = new Size(1530, 159),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b816fbbc-aa84-4e20-8940-af7b98d10907"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess4",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysModuleEditChangeStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7bf0f17f-d01d-4ddd-9e51-77ac55e598d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b816fbbc-aa84-4e20-8940-af7b98d10907"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysModuleEditChange",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"SysModuleEditChangeStartMessage4",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bed080b9-0b6d-457c-ae0b-696dc947ea7f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b816fbbc-aa84-4e20-8940-af7b98d10907"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ScriptTask4",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,203,10,194,48,16,69,247,66,255,33,116,165,155,252,64,85,40,85,74,23,130,24,31,11,17,25,155,81,11,105,82,38,19,165,127,111,43,138,160,46,135,153,123,230,92,133,6,75,70,189,112,58,24,44,180,152,136,37,92,80,206,128,65,185,64,37,202,180,228,234,134,43,119,151,57,242,186,109,80,103,206,132,218,110,193,4,28,231,161,210,211,97,172,90,255,70,196,163,36,26,44,129,208,242,220,114,197,173,42,175,88,195,147,221,17,254,109,134,234,75,163,71,220,128,4,248,166,215,121,91,165,175,17,188,88,35,17,120,119,102,185,41,228,14,79,153,179,76,206,120,217,31,116,233,87,82,102,193,179,171,251,58,251,143,228,177,249,145,136,15,207,39,191,110,29,43,26,16,114,32,43,152,2,38,15,251,255,222,145,51,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("09b7bb1b-516c-40ae-ae58-6da67a6e5c98"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess11",
				Position = new Point(49, 171),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(472, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("902a598f-818e-4372-afc2-082fdb54fae9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09b7bb1b-516c-40ae-ae58-6da67a6e5c98"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UploadTemplateButtonUpload",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"StartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("21a6c3ab-db15-4f98-8bd6-e31f78ce1681"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09b7bb1b-516c-40ae-ae58-6da67a6e5c98"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ScriptTask3",
				Position = new Point(168, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,63,11,194,48,16,197,103,11,253,14,25,219,37,56,136,139,184,180,224,31,16,41,180,78,226,112,210,51,13,180,73,73,174,5,21,191,187,73,164,110,186,189,123,239,126,143,59,121,99,73,1,2,249,169,111,53,212,21,118,125,11,132,217,64,164,21,223,129,221,200,22,109,202,158,113,52,27,193,176,235,157,208,178,53,251,205,20,218,18,214,1,59,207,47,124,139,228,117,230,185,36,93,185,26,63,150,242,129,174,37,180,241,3,42,65,205,20,229,90,17,42,114,169,83,35,26,226,149,206,192,226,114,81,146,145,74,36,1,250,54,29,161,195,191,247,76,75,254,26,15,237,195,75,121,3,74,96,237,72,50,3,58,255,21,71,113,100,144,6,163,62,214,27,25,213,247,219,26,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1277ed1f-614b-4e43-a49c-073538370b63"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess10",
				Position = new Point(36, 541),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(248, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildSaveToFileButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("66bf4a1c-9a66-4fa1-bcc8-fd68307e56da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1277ed1f-614b-4e43-a49c-073538370b63"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SaveToFileButtonClick",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ChildSaveToFileButtonClickStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f6a3d828-4b8f-4c9f-8bc7-5dfe813a2827"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1277ed1f-614b-4e43-a49c-073538370b63"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ScriptTask2",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,79,75,196,48,16,197,207,22,250,29,66,79,13,148,156,196,139,127,64,171,43,94,86,217,21,61,136,135,216,206,46,129,52,41,201,164,90,220,253,238,78,186,45,116,65,244,150,199,36,191,247,230,165,147,142,109,148,134,82,182,168,172,97,151,236,73,110,65,220,74,148,107,27,92,5,226,186,66,213,193,202,126,138,123,192,231,190,133,186,180,58,52,230,69,234,0,23,30,157,50,219,171,60,27,1,25,63,79,19,181,97,249,97,32,30,252,50,104,253,232,238,154,22,251,124,230,196,57,251,78,147,147,99,239,5,169,165,108,128,24,123,6,218,195,47,119,70,112,105,77,37,113,78,44,88,38,106,91,125,13,17,246,127,164,136,46,244,28,193,32,223,237,254,15,26,51,56,192,224,12,67,23,224,64,79,147,143,30,225,237,157,213,84,21,197,34,96,7,14,197,194,217,230,70,122,56,59,93,15,224,124,204,192,231,174,132,232,168,248,21,248,214,26,218,114,108,125,210,52,142,122,146,226,213,41,132,124,146,197,96,89,176,163,213,71,114,252,31,65,198,32,155,120,140,70,105,50,207,254,3,122,153,31,157,240,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6f44c70c-0ee2-467a-a451-a1dc81c7bff1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 720),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(389, 164),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDataSourceSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("def1ab16-e08c-4e78-bc53-e0be161c5644"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f44c70c-0ee2-467a-a451-a1dc81c7bff1"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"StartMessageDataSourceSaved",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDataSourceSavedIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("fb157cb1-8951-4547-a453-68b42ee5a9c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f44c70c-0ee2-467a-a451-a1dc81c7bff1"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"DataSourceSavedIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask9ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4caa1198-f2e9-41b5-8c22-4a58688c8be1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f44c70c-0ee2-467a-a451-a1dc81c7bff1"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ScriptTask9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(288, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,77,107,194,64,16,189,11,254,135,144,147,130,236,31,144,30,36,182,82,104,161,68,173,135,210,195,152,60,117,233,186,147,206,204,218,143,95,223,36,10,246,226,105,121,251,230,125,204,172,32,66,202,59,115,5,199,157,223,39,33,243,28,91,116,60,114,92,155,15,222,60,212,45,233,132,39,174,40,248,95,218,6,188,82,72,24,189,208,30,110,78,70,75,78,82,193,205,42,243,39,148,252,53,201,122,170,160,166,51,187,175,189,185,127,226,21,190,109,146,229,23,54,31,79,135,131,213,141,26,203,31,125,230,58,5,60,112,168,33,215,62,37,20,118,166,74,52,44,86,80,117,192,104,173,144,214,33,162,58,203,161,218,190,61,231,54,222,14,125,139,14,250,184,31,221,10,237,199,175,81,27,150,15,109,168,66,255,191,16,78,205,184,235,60,28,156,72,50,210,166,219,53,187,59,175,60,187,64,210,236,106,191,126,116,27,108,219,16,19,14,234,186,129,86,127,81,186,34,169,241,177,59,227,91,30,129,122,86,215,115,24,249,80,226,51,65,45,127,111,205,119,20,20,125,168,192,146,196,204,36,97,250,7,232,142,42,173,190,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a83d6a3c-f147-4c63-ae85-2f93006406f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(20, 1106),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(884, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("91d00f34-5d44-448b-8d50-693d66d497d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a83d6a3c-f147-4c63-ae85-2f93006406f2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"UserQuestionYesMessage",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"StartMessage6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUserQuestionYesMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7835f3b8-62d3-4ec1-8808-47e14584847a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a83d6a3c-f147-4c63-ae85-2f93006406f2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"UserQuestionYesMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,177,10,194,48,20,69,103,11,253,135,208,73,151,252,64,113,208,162,226,80,40,182,226,28,211,167,13,198,188,240,222,75,197,191,183,221,58,56,94,14,231,112,71,67,42,154,39,156,3,139,9,22,212,86,53,211,212,237,151,107,236,147,135,11,68,36,57,58,240,61,207,164,194,32,198,5,32,221,44,181,60,91,25,86,29,16,25,198,135,232,27,220,119,49,254,207,156,200,245,179,220,218,1,222,230,202,64,115,148,208,151,121,182,252,162,187,129,240,115,24,33,200,186,104,65,82,172,141,37,100,224,125,18,193,80,121,103,95,197,102,178,242,140,38,76,65,9,37,40,127,27,87,66,45,212,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("030d8b4f-1a60-4044-bc52-dd6a950f090a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(20, 1326),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage7StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1a66e820-715b-431c-bfe8-44d49a1551fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("030d8b4f-1a60-4044-bc52-dd6a950f090a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"UserQuestionNoMessage",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"StartMessage7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent5IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("6173e659-c1ed-4303-a393-ea21eba91519"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("030d8b4f-1a60-4044-bc52-dd6a950f090a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"IntermediateThrowMessageEvent5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(154, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b6485cfb-ef84-4f63-aec8-2a29b2b569c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess2",
				Position = new Point(35, 1540),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(312, 139),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("30d12d9d-56a2-4d55-8cc9-64930de5073c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6485cfb-ef84-4f63-aec8-2a29b2b569c3"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FileUploadEditChange",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"StartMessage2",
				Position = new Point(50, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFileUploadEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eac2b15d-816d-461a-85a0-2d71018adac6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6485cfb-ef84-4f63-aec8-2a29b2b569c3"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"FileUploadEditChangeScriptTask",
				Position = new Point(204, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,193,10,194,64,12,68,207,22,250,15,123,108,47,139,7,241,34,94,90,20,5,145,66,245,3,22,26,183,129,154,149,221,84,80,241,223,221,168,189,85,188,101,38,111,194,4,79,42,171,140,5,189,198,14,142,151,206,153,102,213,32,235,141,9,226,228,234,145,38,147,49,64,100,233,136,129,88,87,46,32,163,35,181,84,211,69,228,101,87,227,29,162,206,144,56,255,151,223,1,89,110,135,228,215,141,225,56,93,193,179,62,184,194,4,152,207,106,246,72,118,180,175,200,226,198,16,242,225,204,222,156,165,192,47,88,214,130,110,223,127,150,173,33,11,77,228,217,247,226,63,211,36,77,60,112,239,233,99,189,0,143,198,112,188,41,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b63b8654-8b3c-4605-9a55-eb7cf7d1c57d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(63, 1722),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(477, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBeforeParentPageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("71b0cfd6-251e-4441-ae4f-87190574f49a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b63b8654-8b3c-4605-9a55-eb7cf7d1c57d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"BeforeParentPageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("277c925c-4c33-425a-bb03-ec3c205d0463"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b63b8654-8b3c-4605-9a55-eb7cf7d1c57d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAfterParentPageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c9a60923-5469-4e14-8a9e-fa737325d7ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b63b8654-8b3c-4605-9a55-eb7cf7d1c57d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"AfterParentPageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(323, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,77,111,219,56,16,61,39,64,254,131,170,147,4,4,66,15,197,94,210,45,224,56,110,96,52,73,179,145,179,57,4,65,193,72,99,155,93,154,84,73,42,174,218,230,191,239,12,41,203,178,37,27,73,177,11,95,100,105,230,205,155,55,31,100,10,2,50,11,249,165,202,75,1,227,60,248,51,184,102,51,72,206,152,101,169,42,117,6,201,32,179,252,9,110,212,50,57,7,59,169,10,200,135,74,148,11,249,55,19,37,188,63,47,121,254,33,10,211,202,172,32,194,248,228,232,240,154,105,144,118,36,45,183,85,154,205,97,193,28,54,34,244,125,137,210,45,26,4,241,196,116,192,76,65,116,86,172,6,245,95,102,130,9,104,205,140,154,218,228,118,156,220,193,227,80,73,171,149,48,9,25,160,119,237,153,12,75,99,213,130,210,185,95,147,252,82,116,72,132,15,46,72,151,27,98,209,207,129,125,254,116,90,90,171,100,50,248,202,190,143,158,208,214,36,67,193,179,127,146,33,43,13,24,148,132,231,204,114,37,17,204,234,18,78,106,199,33,43,232,237,40,231,54,185,80,25,154,253,96,143,2,38,240,221,162,229,209,225,193,58,29,76,100,202,103,165,118,48,248,111,177,80,242,214,114,193,45,7,67,37,104,249,187,18,68,183,6,52,122,73,84,16,93,142,59,5,244,153,36,87,108,1,199,65,88,83,9,187,118,77,161,175,53,95,48,93,181,202,28,59,21,248,52,136,198,230,10,150,113,240,19,57,59,255,143,92,192,109,33,20,203,93,114,41,88,79,234,12,166,172,20,118,2,139,66,48,11,100,70,4,146,6,238,128,234,11,45,169,47,153,68,64,141,122,108,38,148,140,186,70,125,254,232,216,3,71,138,141,165,177,76,102,112,90,17,133,40,252,36,213,82,64,62,131,83,102,28,51,108,217,160,7,241,175,18,116,133,176,18,150,193,104,251,125,212,19,236,120,195,221,41,238,149,115,208,216,25,204,107,186,69,213,225,37,131,188,30,172,40,164,162,184,49,58,232,154,33,95,11,218,144,121,132,6,61,22,67,13,94,113,180,187,227,118,142,93,141,68,200,201,57,248,15,216,88,56,4,220,40,73,35,157,140,190,149,76,96,119,108,72,131,221,151,3,54,10,121,145,6,234,241,43,150,228,254,33,248,137,213,189,76,239,148,206,111,160,80,186,169,242,134,55,57,63,199,255,87,22,251,211,32,229,145,120,135,116,111,75,78,84,106,53,151,179,40,246,116,55,58,1,75,34,124,31,246,22,13,187,107,180,101,183,53,143,78,0,154,156,109,60,84,183,148,54,248,16,188,245,227,228,130,78,145,20,173,50,52,110,226,173,93,238,223,62,80,196,211,202,186,93,131,99,182,238,41,223,109,1,237,198,71,252,126,255,112,82,23,27,82,254,131,54,104,11,58,185,0,57,179,243,198,98,29,17,159,158,64,91,212,132,74,248,199,187,90,153,150,111,220,120,81,64,116,217,59,233,100,252,124,116,248,28,128,48,176,115,107,56,211,87,31,61,198,113,195,195,103,21,210,143,76,139,218,127,130,71,181,219,11,212,194,240,190,97,28,188,193,173,81,10,81,87,246,69,26,71,190,108,241,107,99,197,219,133,254,125,164,86,95,80,209,154,115,15,167,148,83,255,49,113,201,50,173,240,164,163,215,148,17,227,18,119,44,253,91,45,217,228,90,171,12,140,161,163,0,31,11,204,180,170,163,172,78,249,43,220,12,221,51,6,231,213,143,210,174,227,231,245,84,38,115,173,150,238,156,142,194,115,205,115,250,120,3,83,13,102,142,42,184,242,238,191,39,48,167,216,90,194,250,150,176,41,43,222,0,48,194,248,108,7,154,4,200,145,245,25,32,67,113,3,223,74,48,214,225,184,163,52,248,245,11,31,134,170,168,92,142,99,227,122,101,206,228,12,242,94,27,124,163,236,29,151,185,90,14,5,230,191,3,136,150,73,209,210,98,197,187,201,205,111,238,143,28,68,190,71,66,218,253,27,183,45,188,106,13,138,162,31,102,37,177,95,144,245,26,164,91,25,50,42,94,214,34,125,55,48,119,85,233,190,142,95,142,234,91,229,130,163,240,123,174,61,251,151,66,11,35,126,69,232,45,161,92,54,251,218,188,216,213,191,216,23,162,185,23,212,195,208,128,187,45,58,146,116,39,236,239,154,163,67,13,182,212,210,223,74,255,5,23,195,38,145,246,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b01f80b7-9929-4ccb-af87-95adc347a68e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b63b8654-8b3c-4605-9a55-eb7cf7d1c57d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ScriptTask5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ea2efe78-4c1a-4128-a848-d2443da513b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(70, 1897),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(343, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("feced922-af16-4028-a17c-7d045324c795"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ea2efe78-4c1a-4128-a848-d2443da513b2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChilInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7b4255e6-eb4e-4e25-9f76-6a392d30a590"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ea2efe78-4c1a-4128-a848-d2443da513b2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ChilInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,193,78,219,64,16,61,131,196,63,108,115,114,212,100,133,82,8,69,45,149,18,55,137,34,65,27,225,80,14,85,15,19,123,18,150,174,119,173,221,113,32,84,252,123,103,109,3,174,74,123,112,236,236,190,247,230,237,243,140,23,176,65,249,25,8,18,91,186,20,229,24,215,214,97,2,91,188,180,119,226,237,217,193,190,200,80,227,6,8,35,187,186,197,148,132,71,147,161,235,137,23,214,100,139,134,70,110,227,5,118,197,175,131,253,61,161,214,34,154,251,169,210,24,223,128,217,96,86,175,215,27,213,178,53,196,36,241,230,76,152,82,235,102,123,111,181,35,252,254,67,172,25,17,228,197,153,96,224,22,29,201,169,179,249,24,60,14,143,18,114,202,108,162,200,87,247,110,75,173,251,161,18,217,130,19,57,230,214,237,24,138,144,179,138,193,59,145,236,60,97,46,231,95,229,69,107,51,106,72,109,130,188,118,138,207,251,228,162,39,14,123,34,148,73,212,3,54,240,4,41,46,61,217,124,137,121,161,57,157,133,179,5,251,220,69,109,161,158,64,201,57,202,25,210,114,87,96,22,91,93,230,230,27,232,18,63,214,246,63,69,157,121,214,233,54,170,53,154,181,107,122,5,140,58,161,116,167,247,199,145,26,124,59,201,58,200,106,253,49,252,60,107,181,138,214,90,95,32,15,122,79,143,149,150,8,28,241,58,39,88,103,147,189,42,197,89,169,178,168,243,126,28,15,142,79,39,211,254,209,224,100,216,63,58,61,28,246,199,39,163,97,127,240,238,115,124,124,58,158,156,76,39,131,230,84,255,16,141,161,32,101,13,171,46,66,11,54,127,39,153,34,121,110,83,208,234,1,86,26,151,120,79,33,189,184,212,84,58,172,185,51,52,232,64,95,162,175,186,47,33,235,42,137,210,57,14,162,129,54,197,195,21,250,161,96,196,220,120,2,147,34,71,85,213,228,134,184,176,89,169,241,18,11,235,104,170,80,103,62,236,132,72,65,113,17,185,104,211,66,170,224,197,18,157,3,111,215,36,175,113,53,42,138,215,117,102,78,101,129,157,164,55,152,195,149,71,23,84,157,213,255,201,228,2,82,103,253,185,242,196,177,4,216,94,219,182,228,22,75,209,251,144,199,83,183,253,77,236,202,165,109,38,228,57,2,241,200,15,7,251,245,161,121,180,151,54,188,251,113,73,100,141,28,221,194,125,53,192,94,198,90,165,63,229,220,95,21,218,66,198,49,145,43,241,133,26,102,97,9,171,5,24,212,114,190,49,252,161,96,31,97,74,26,59,10,189,28,101,220,30,144,146,218,34,193,74,241,167,226,190,19,124,56,228,183,98,106,197,223,171,45,10,110,117,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("6e6c203d-3118-4b7f-97ab-c36ec28916da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ea2efe78-4c1a-4128-a848-d2443da513b2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3902f66f-d74d-4d84-95c6-04b4e5678fbf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 2140),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1124, 820),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2b521b7d-bb3e-4cf0-87fd-c0326b95a001"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"StartMessage5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(52, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("04f672c2-5459-4f5b-8e8b-8f8e7f344475"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(317, 385),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask8ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("31d2e6b5-98d9-4eeb-9170-1142c7656244"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ScriptTask8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(432, 385),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,206,189,10,194,48,16,7,240,217,66,223,33,100,46,190,64,213,65,236,208,193,214,218,100,232,88,202,81,130,146,72,238,130,150,210,119,55,209,34,34,118,186,15,126,119,252,37,130,61,2,98,219,131,244,173,104,241,178,62,249,129,109,89,40,105,28,201,63,98,158,5,60,200,195,176,174,28,32,41,163,133,162,235,210,85,222,25,237,57,175,100,86,139,188,44,248,130,219,59,34,163,49,208,38,171,139,114,201,157,1,111,222,193,188,15,7,26,238,236,160,186,144,164,181,195,6,201,42,221,39,236,93,119,108,140,163,213,200,7,64,158,48,254,29,187,1,156,191,240,41,121,33,109,126,77,97,62,36,142,38,159,201,2,57,171,25,89,7,233,19,210,87,127,140,72,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e4f2ba62-08a7-418f-9f4a-de94c88917b0"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"UserMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(560, 382),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("5330ea13-7927-4a71-b919-b9fabfaa720b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(673, 653),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("220641bc-9be7-420e-8797-0183b27fa623"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 382),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,208,193,10,130,64,16,6,224,115,130,239,176,117,82,136,125,1,43,8,163,8,18,68,163,251,162,147,44,232,142,204,206,26,18,189,123,42,17,118,232,54,204,48,223,63,76,167,72,52,170,32,180,23,109,89,108,69,170,42,144,121,111,19,44,93,13,25,180,72,124,212,80,151,118,156,196,104,88,105,3,228,123,11,57,54,206,198,178,50,5,200,148,176,0,107,229,9,120,40,91,32,238,111,170,118,16,172,146,47,191,10,229,21,115,38,109,170,32,140,124,79,223,69,48,11,95,126,210,15,138,85,142,142,6,117,95,176,238,32,195,199,232,94,251,22,202,24,107,215,152,137,222,216,137,218,253,70,132,226,57,28,247,31,202,129,103,198,207,238,122,246,138,241,190,151,239,249,30,1,59,50,130,201,65,244,6,204,7,112,215,46,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckObjectNamesScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4ea8a10b-0b86-47d6-bfa8-fbb535351eb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"CheckObjectNames",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 520),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,148,209,110,218,48,20,134,175,131,196,59,88,209,46,18,9,249,5,54,90,33,202,166,85,99,99,165,219,174,79,147,67,241,230,216,212,118,40,89,203,187,215,142,33,51,9,3,46,241,57,231,247,127,254,207,97,13,138,40,92,73,101,62,231,100,72,102,240,136,244,6,12,204,101,169,50,164,163,204,176,53,222,201,231,153,98,5,168,106,44,121,89,136,159,192,75,124,223,239,173,237,48,234,39,59,39,240,153,76,132,97,166,154,103,75,44,224,123,137,170,74,126,104,84,99,41,4,90,21,41,104,216,48,5,97,175,82,3,18,207,43,61,149,121,201,241,174,182,113,15,15,28,227,212,170,91,101,58,202,115,127,101,18,143,97,229,84,142,149,166,144,41,169,191,48,109,154,234,71,198,13,42,237,186,18,247,123,172,16,12,250,211,95,204,44,103,160,160,64,215,146,248,195,177,44,86,160,152,150,226,190,90,33,157,60,149,192,187,238,226,65,147,86,154,238,18,224,76,252,193,188,246,173,109,20,238,182,79,104,252,178,214,33,247,219,183,194,216,15,123,53,191,136,91,96,110,212,41,12,78,217,249,203,3,16,31,180,81,76,60,94,117,114,104,235,59,119,201,173,221,144,222,160,53,195,128,179,191,152,28,113,144,18,208,228,118,164,20,84,41,157,163,219,32,217,144,225,85,141,249,165,223,139,118,44,172,222,134,182,60,100,123,76,228,250,154,248,83,58,41,86,166,26,216,185,41,26,152,129,89,158,152,47,14,91,186,58,253,222,214,45,103,163,92,112,150,25,204,191,61,252,182,6,191,90,156,238,33,150,156,219,234,66,90,222,217,146,36,46,3,227,208,16,38,14,72,165,245,34,77,249,159,163,250,231,233,156,195,167,24,72,180,32,94,32,212,2,214,214,58,14,172,123,217,89,94,1,176,119,241,75,184,240,150,190,92,142,112,27,59,136,71,40,94,32,122,150,235,54,182,218,53,218,168,75,207,175,235,24,134,241,120,134,117,106,75,208,251,23,97,253,28,188,122,58,18,149,143,195,53,71,27,218,248,30,134,106,205,241,235,235,233,190,246,250,77,127,39,151,51,250,103,250,91,229,58,153,136,45,72,18,236,186,75,32,250,207,215,16,66,169,199,35,133,166,84,54,69,85,255,129,71,209,214,133,110,63,169,126,47,172,188,1,7,105,46,170,22,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78afExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("c3c2379d-3b36-4c4f-b44e-cc5b953c78af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ExclusiveGateway4_c3c2379d3b364c4fb44ecc5b953c78af",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(305, 520),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareInvalidObjectNameMessageParametersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("89d64b1c-bdc2-40d7-a137-922f83d3c700"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"PrepareInvalidObjectNameMessageParameters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(432, 520),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,206,200,47,247,204,43,75,204,201,76,241,79,202,74,77,46,241,75,204,77,13,45,78,45,10,73,44,206,214,11,72,76,79,85,176,85,0,81,214,188,92,193,120,213,250,166,22,23,3,213,133,164,86,148,0,181,20,151,20,101,230,165,235,185,229,23,229,38,150,104,224,213,9,213,168,163,224,156,159,151,150,147,153,92,146,138,164,72,147,160,189,158,201,249,121,64,11,149,2,67,93,131,67,60,253,253,148,8,234,112,42,45,41,201,207,43,6,105,242,247,6,41,47,74,45,41,45,202,83,40,41,42,77,181,6,0,12,51,37,138,17,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowInvalidObjectNameUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c56d8edb-c58d-4a2b-9d0f-903136c33988"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ShowInvalidObjectNameUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(571, 520),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowInvalidObjectNameUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckReportCaptionScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4c4aa2d7-c662-4396-949e-035854b560fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"CheckReportCaptionScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,205,14,130,48,16,132,207,246,41,246,8,151,198,59,193,196,16,53,77,252,59,240,2,43,44,216,164,22,210,46,4,53,190,187,85,240,134,199,157,153,111,54,163,108,143,70,151,25,182,172,27,123,32,239,177,38,72,193,118,198,36,194,179,211,182,134,98,116,131,124,14,174,156,194,155,82,179,220,55,69,224,31,120,49,148,211,192,137,232,209,129,30,75,183,218,208,17,111,148,93,209,249,47,204,87,185,35,86,51,118,20,255,208,146,134,144,157,94,74,245,185,79,213,218,222,163,185,214,64,233,10,162,145,90,165,176,140,225,41,22,234,207,168,89,61,111,195,208,151,112,196,157,179,192,174,163,228,13,183,61,151,189,21,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("5c55d4e2-8be7-41bd-ab04-7b3096c6d2b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ExclusiveGateway5_5c55d4e28be741bdab047b3096c6d2b4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateOpenInvalidCaptionMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e6d769c5-56ef-4396-8ec7-2a6afd474033"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"OpenInvalidCaptionMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(570, 65),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenInvalidCaptionMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareInvalidCaptionMessageWindowParametersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("55d9eaf4-5754-42ac-be59-b716e2c7527c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("aed62d9a-c3fc-4cd3-85c5-ffb68182d96b"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"PrepareInvalidCaptionMessageWindowParameters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(433, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,205,243,204,43,75,204,201,76,113,78,44,40,201,204,207,243,77,45,46,78,76,79,13,45,78,45,10,73,44,206,214,11,0,114,20,108,21,64,148,53,47,151,63,65,245,80,126,72,106,69,9,80,27,86,181,68,153,227,153,156,159,7,52,64,41,48,212,53,56,196,211,223,79,137,40,93,78,165,37,37,249,121,197,32,141,254,222,32,45,69,169,37,165,69,121,10,37,69,165,169,214,0,39,55,45,173,237,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckReportColumnsCaptionsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("95da3e2c-e197-4979-a1d0-9e5d043c23e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("9a523c3d-01af-48e1-ae7e-8726470b5821"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"CheckReportColumnsCaptionsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 243),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,93,79,219,48,20,125,46,18,255,193,75,31,112,16,178,166,189,142,148,85,1,166,160,85,116,180,219,30,128,73,94,114,105,173,165,78,176,157,210,140,241,223,119,237,164,109,146,118,104,47,147,170,52,185,95,231,220,123,143,29,201,37,79,69,18,102,105,177,144,33,207,141,200,228,8,180,230,51,32,1,145,69,154,190,63,60,88,114,69,22,60,86,153,254,36,180,65,251,149,206,36,59,7,13,74,96,246,47,160,99,140,103,147,82,143,178,164,72,225,6,242,76,153,75,1,105,162,173,39,204,164,225,66,130,58,60,232,49,107,136,164,54,92,198,192,198,42,139,17,141,125,4,131,175,57,40,83,126,229,105,1,212,27,109,240,60,159,77,179,137,81,66,206,168,239,19,174,201,213,80,41,94,146,179,51,34,225,169,254,162,126,77,84,57,240,40,65,154,142,213,57,55,124,146,21,10,209,134,177,17,75,184,201,158,198,74,44,184,42,171,174,29,96,157,12,250,209,182,141,85,47,164,17,166,156,196,115,88,240,207,5,168,146,126,193,118,177,19,9,177,29,18,107,6,140,184,68,40,117,66,188,206,12,166,252,71,10,158,165,134,149,217,48,169,7,77,189,122,212,251,92,205,206,107,239,165,72,13,40,109,163,168,253,14,21,112,3,149,245,155,48,243,49,87,124,1,54,132,86,198,48,91,228,92,9,92,211,180,204,129,93,60,22,60,221,101,231,157,108,166,229,175,199,151,10,249,19,18,199,91,227,40,44,26,46,167,106,22,25,166,85,247,157,97,216,100,237,54,116,123,79,196,30,73,133,115,174,108,185,103,175,143,160,30,243,94,48,227,33,195,54,226,57,161,22,215,88,68,204,109,17,240,201,51,74,102,227,174,139,97,29,247,105,137,217,246,146,198,30,79,43,26,131,246,132,119,74,68,21,71,172,244,87,182,108,40,75,186,246,162,129,4,131,86,9,22,201,4,86,215,15,205,24,159,12,2,242,214,33,138,7,66,247,32,86,29,245,162,87,143,221,43,222,105,110,15,100,175,167,192,20,74,18,163,156,116,123,47,173,30,93,158,21,16,158,154,127,27,86,71,115,221,90,122,223,153,223,197,106,28,78,91,100,123,101,176,17,168,89,43,67,91,152,151,142,6,98,231,178,34,216,166,110,37,16,111,182,95,197,177,78,15,113,119,225,10,102,176,170,143,243,141,125,167,31,60,122,118,26,220,221,246,125,252,175,48,6,183,223,105,255,238,222,191,63,70,91,96,223,80,160,46,250,218,149,211,44,154,73,36,25,114,13,228,119,219,51,65,224,20,80,176,59,158,139,85,158,138,88,24,187,188,66,193,134,82,133,25,102,133,180,215,168,35,200,70,220,224,37,162,105,205,223,103,206,189,206,136,173,22,35,57,106,37,190,107,122,215,198,58,191,74,167,43,171,87,124,4,228,168,127,180,81,100,19,255,120,95,237,55,193,182,230,255,211,42,254,218,198,63,190,30,233,201,135,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("9a817989-adcc-47c6-bdae-c0c5e41a1385"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("9a523c3d-01af-48e1-ae7e-8726470b5821"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"ExclusiveGateway6_9a817989adcc47c6bdaec0c5e41a1385",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 243),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateOpenInvalidColumnCaptionMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b7220d4a-aaaf-4c15-9570-77a4261aaea1"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("9a523c3d-01af-48e1-ae7e-8726470b5821"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"OpenInvalidColumnCaptionMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(564, 243),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenInvalidColumnCaptionMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareInvalidColumnCaptionMessageWindowParametersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("92fb43c2-731c-4c4a-b2c0-298bf7d2355e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afc01283-0570-4507-9fce-b4840455577d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("9a523c3d-01af-48e1-ae7e-8726470b5821"),
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Name = @"PrepareInvalidColumnCaptionMessageWindowParameters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(434, 243),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,205,243,204,43,75,204,201,76,113,206,207,41,205,205,115,78,44,40,201,204,207,243,77,45,46,78,76,79,13,45,78,45,10,73,44,206,214,11,0,114,20,108,21,64,148,53,151,63,145,154,160,252,144,212,138,18,160,94,60,58,136,55,210,51,57,63,15,104,150,82,96,168,107,112,136,167,191,159,18,241,90,157,74,75,74,242,243,138,65,186,253,189,129,250,138,82,75,74,139,242,20,74,138,74,83,173,1,164,86,250,220,7,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetCustomTemplatePropertyMethod());
			Methods.Add(CreateGetParentEntitySchemaIdMethod());
			Methods.Add(CreateGetSysModuleIdMethod());
			Methods.Add(CreateCreateColumnMethod());
			Methods.Add(CreateFindColumnByCaptionMethod());
			Methods.Add(CreateCreateReferenceColumnMethod());
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
				UId = new Guid("6c2fae44-c97f-4ccd-98ce-67729dd64f31"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fe7db120-90e2-42a8-b356-0865115cff0f"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9e52a132-8dd6-4f7e-bfa4-b956e180e1a6"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("35af31e8-2c3e-47e3-b373-cb672a140b35"),
				Name = "DocumentFormat.OpenXml.CustomProperties",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ae5a334b-a11e-413f-8d7d-807249885c3b"),
				Name = "DocumentFormat.OpenXml.Packaging",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("54712016-af02-4b87-8205-cf74a13f10d3"),
				Name = "DocumentFormat.OpenXml.VariantTypes",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("62f7307e-8c4c-48b4-962d-cd1e9bcaa879"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10070d6f-0df6-46d8-9abe-7e3fc7645e21"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("85f517de-8e67-41fb-955e-72d96f25b577"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c1576e2-e1c2-4996-8259-0157123ea481"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0")
			});
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,203,110,194,48,16,69,215,228,43,92,175,18,129,172,174,65,93,160,208,82,170,210,34,210,199,2,88,152,100,0,11,99,35,219,9,109,163,252,123,39,188,202,99,145,174,34,143,239,157,57,115,157,140,27,178,54,98,197,205,119,152,74,151,26,16,106,166,201,29,121,183,96,66,173,20,196,78,104,197,186,224,6,103,178,30,202,252,160,229,137,153,127,51,224,115,96,33,95,151,202,251,68,56,246,172,99,46,197,15,159,74,120,131,47,199,30,185,221,219,62,184,76,193,191,158,24,4,36,247,106,149,141,34,112,21,141,26,164,170,9,66,23,158,119,177,95,4,214,226,183,195,29,31,209,158,125,16,18,194,5,87,115,72,232,4,211,56,171,180,188,158,125,209,238,83,168,68,111,66,169,45,160,98,198,165,133,150,103,157,17,106,78,226,221,120,172,87,174,212,189,88,233,127,193,227,18,25,62,93,172,85,6,198,129,177,56,74,193,134,60,89,173,194,67,113,52,33,121,89,236,166,34,57,187,240,131,226,136,42,18,180,150,183,152,129,17,37,26,248,91,232,50,139,72,167,38,6,214,70,150,12,134,122,195,14,44,90,166,43,181,5,110,156,64,140,110,39,8,182,117,71,177,17,107,215,231,10,15,134,181,147,100,87,184,106,29,74,1,202,245,58,164,78,188,90,141,50,173,142,195,78,134,216,125,244,67,176,107,173,44,248,180,84,163,7,233,235,132,54,242,49,221,103,60,166,164,73,242,248,207,218,36,116,39,189,216,113,255,68,65,233,47,138,160,69,145,124,202,45,176,215,37,50,197,203,62,184,133,78,240,23,255,5,129,119,131,134,35,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,200,79,202,74,77,46,177,83,72,73,77,11,75,204,41,77,45,86,176,85,72,74,44,78,213,115,79,45,113,129,137,105,104,90,115,193,21,68,43,5,87,22,251,230,167,148,230,164,42,197,2,85,7,167,230,0,77,72,77,129,8,121,166,88,115,21,165,150,148,22,229,33,140,180,6,0,127,249,67,81,120,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetCustomTemplatePropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("777d42d6-11f5-4fee-a9a8-4b071abea5d6"),
				Name = "SetCustomTemplateProperty",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0aa5c3b1-3b86-491e-98a9-1a933c444636"),
				Name = "fileStream",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Stream",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5a66d3a6-ad2a-46df-bdee-28ba762a100a"),
				Name = "propertyValue",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,93,107,194,64,16,124,54,191,98,235,83,130,245,136,22,105,69,44,104,162,80,144,42,42,218,215,212,172,122,144,47,46,23,139,136,255,189,123,151,11,70,208,183,92,118,103,118,102,118,249,30,236,61,143,112,37,5,6,49,155,97,114,144,71,24,14,193,117,224,98,1,8,148,133,72,6,214,213,58,5,2,18,252,91,136,52,131,161,250,2,175,200,101,26,251,233,174,136,49,145,170,128,66,158,109,103,96,153,62,182,89,207,22,219,213,122,105,0,213,211,206,76,239,38,136,10,172,245,79,83,17,7,242,43,164,254,230,197,239,121,190,223,115,123,237,238,164,239,181,59,110,103,220,238,191,245,223,219,238,135,235,118,199,93,111,218,31,77,174,205,27,248,59,136,145,128,35,41,5,255,45,36,170,247,192,178,138,156,39,7,176,149,252,208,72,165,174,109,42,66,82,177,195,92,149,43,15,108,158,97,82,203,227,21,164,32,129,101,20,138,97,167,45,171,113,57,145,84,124,172,76,98,74,56,147,2,199,124,17,8,57,32,24,167,132,239,96,148,69,17,69,138,179,241,132,110,20,134,207,24,85,186,117,24,187,149,77,200,149,151,50,75,237,232,39,142,152,213,0,179,176,27,162,6,86,188,0,87,203,248,204,140,164,199,147,42,91,101,215,75,205,80,133,37,168,46,234,177,219,35,10,180,233,223,39,216,246,227,163,113,50,135,90,27,106,101,76,31,133,138,233,110,147,14,155,114,145,203,185,240,113,31,20,81,25,68,37,226,78,3,232,209,108,137,113,122,66,221,70,182,26,165,156,81,70,113,132,222,145,71,161,109,238,70,243,208,77,100,92,157,93,151,94,251,148,118,191,59,194,19,173,192,37,198,192,147,210,161,163,39,170,95,85,64,103,125,191,68,215,106,233,217,102,244,42,40,213,168,148,175,255,93,19,2,241,119,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetParentEntitySchemaIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("23854ba2-9541-4164-958e-7c19cbb8caaf"),
				Name = "GetParentEntitySchemaId",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c4adb1e5-d1a9-4ad3-bdd9-ede24e6cbe64"),
				Name = "sysModuleId",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,65,75,3,49,16,133,207,22,246,63,132,158,178,80,66,239,213,130,46,181,236,161,82,105,171,7,17,25,118,167,54,176,155,212,73,82,9,226,127,55,217,180,210,178,154,91,50,153,111,222,123,115,0,98,166,218,97,11,236,134,109,12,82,161,149,194,202,74,173,196,76,89,105,253,170,171,46,64,193,59,146,152,163,45,149,177,160,42,188,243,15,208,34,31,174,188,89,232,218,53,56,204,39,217,224,16,128,120,214,248,232,144,124,96,43,252,100,107,36,2,163,183,86,20,154,48,241,37,154,139,65,221,127,158,36,157,120,149,110,92,171,2,164,7,22,183,117,93,116,213,51,29,9,39,194,253,28,188,41,235,78,96,159,113,47,27,139,100,34,139,247,171,5,33,88,76,127,158,165,221,45,129,130,237,216,192,211,99,161,219,61,144,52,90,173,253,62,184,250,112,208,140,88,54,184,234,159,100,75,44,73,182,64,62,9,23,49,197,17,51,39,245,101,157,95,228,24,2,250,211,121,216,68,178,23,48,77,218,24,191,92,96,196,200,45,227,39,76,72,221,41,203,166,108,156,179,175,160,143,208,58,82,191,83,94,198,175,17,26,77,28,51,125,130,198,225,245,220,201,122,218,139,247,237,159,120,191,131,243,108,112,68,199,86,49,107,247,214,79,126,0,111,12,140,139,105,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysModuleIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c3afb128-d6a8-42c0-967b-584eb9034699"),
				Name = "GetSysModuleId",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d0b9fa7c-1e7f-49b9-a744-5b121c3af345"),
				Name = "sysModuleInWorkspaceId",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,189,110,2,49,16,132,107,120,10,235,170,187,198,47,64,146,2,194,161,43,72,67,126,106,203,158,4,43,246,250,228,31,36,11,229,221,99,223,33,32,74,183,218,217,153,111,246,36,60,11,242,8,43,216,35,123,11,240,27,71,4,25,181,35,190,165,168,99,62,76,234,94,144,248,130,231,59,196,129,66,20,36,177,206,47,194,162,109,14,57,236,157,74,6,3,93,199,222,25,5,223,116,171,229,169,0,48,5,21,192,76,226,27,15,17,49,199,183,127,161,197,161,63,89,59,59,120,143,40,143,189,119,246,121,221,134,27,230,195,249,239,48,10,137,65,117,29,59,47,150,139,74,145,206,36,75,181,211,29,105,218,5,222,107,82,255,250,54,221,69,127,23,38,161,138,171,18,229,17,147,167,75,231,250,239,107,30,161,238,14,31,118,73,171,167,246,134,43,157,127,24,76,0,59,95,237,245,134,111,237,24,115,17,127,1,174,183,243,4,101,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("88fba15e-bddb-4be8-94e6-5ae8e263054e"),
				Name = "CreateColumn",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceStructureColumn"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0e0f7c3b-0a18-44f3-89a4-5ee5d398a88b"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b464251a-65ba-4186-8f92-1e70f3b3a9a2"),
				Name = "metaPath",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,203,142,131,48,12,60,23,137,127,200,17,164,138,31,64,189,244,169,30,182,90,137,221,189,91,224,182,145,32,160,212,105,133,170,253,247,181,217,32,232,131,83,146,241,120,102,28,111,12,105,106,179,252,140,21,172,234,210,85,70,225,43,180,80,151,238,153,108,181,41,198,149,101,251,129,4,159,64,231,168,242,151,56,13,3,125,84,209,59,153,133,50,174,44,99,117,15,131,153,69,114,214,116,0,119,252,134,65,24,92,200,106,115,82,13,171,12,150,59,164,177,136,88,76,184,250,246,30,90,65,67,186,54,147,74,91,118,246,156,101,219,137,53,94,232,10,86,229,253,228,6,111,106,13,4,89,237,108,142,25,89,151,115,112,244,35,201,36,223,251,130,121,59,167,139,228,128,55,57,163,120,206,120,31,146,139,125,166,49,60,228,123,74,44,36,113,252,129,210,225,87,219,32,83,94,127,51,121,160,72,207,1,170,9,170,84,132,49,88,190,33,249,34,239,34,149,101,248,253,252,255,67,250,7,46,227,17,144,40,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindColumnByCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("97afb85e-ba5b-4c18-ba5f-9a23ed9d39aa"),
				Name = "FindColumnByCaption",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "EntitySchemaColumn"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("858c97d0-122f-4c71-b9c3-d2f4a91eb0d9"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6eb28ada-a42f-43b8-bafd-2744f64b3b9d"),
				Name = "caption",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,140,59,14,128,32,12,64,103,56,69,71,92,184,128,35,241,10,238,13,169,145,164,20,5,234,98,188,187,241,179,190,247,242,150,82,9,227,10,238,192,10,169,83,134,36,208,226,74,25,125,40,172,89,218,0,167,53,105,1,247,104,31,112,235,169,136,159,145,149,252,180,43,114,115,241,131,195,155,154,74,93,171,188,183,209,154,203,94,246,39,162,204,227,13,237,74,57,77,114,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateReferenceColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c691a72e-5feb-4f31-b7b8-7073fc7a0b5f"),
				Name = "CreateReferenceColumn",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceStructureColumn"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("122f944f-c49b-4e3b-b5d9-695e9ae4af86"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8603205a-cc04-462a-abb9-4bac93f194a9"),
				Name = "macrosParts",
				CreatedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				ModifiedInSchemaUId = new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,77,111,130,64,16,61,175,137,255,97,235,9,162,37,245,108,61,84,180,198,131,198,84,237,165,49,205,22,70,221,84,22,178,44,26,210,248,223,59,11,88,190,252,232,5,194,204,155,55,243,246,13,123,96,146,122,160,216,156,169,29,237,83,1,71,186,80,146,139,237,32,226,123,23,164,97,246,154,141,67,1,100,179,64,113,95,220,196,10,230,193,77,128,115,135,36,67,249,251,200,211,160,87,46,92,59,249,24,196,89,127,35,116,118,224,177,14,245,152,35,253,112,206,164,10,63,158,214,231,6,46,83,236,157,237,35,88,198,129,30,37,165,178,134,197,48,66,207,162,172,151,32,0,225,26,25,108,53,113,173,165,159,142,101,152,102,1,152,117,175,224,179,168,6,106,233,149,236,12,67,58,229,220,171,77,71,7,161,184,138,23,137,188,41,19,108,11,18,5,172,66,144,182,47,4,56,9,199,168,14,74,8,54,190,164,6,23,138,114,172,233,246,240,245,92,60,33,203,246,35,161,48,220,110,155,244,167,217,32,124,67,207,131,188,193,6,36,8,7,82,86,60,3,250,208,167,227,136,187,214,200,11,84,156,22,16,61,162,44,67,177,213,133,161,173,49,168,137,8,21,67,220,32,70,186,235,141,180,120,66,110,218,93,105,89,246,157,175,83,134,170,157,45,171,117,57,113,213,231,28,90,113,186,70,117,119,19,8,41,238,66,235,179,85,15,86,22,4,143,224,74,211,187,171,67,18,39,181,235,253,186,223,244,145,118,51,247,200,63,127,12,66,78,248,56,81,216,135,144,86,126,73,96,223,58,131,137,147,94,53,9,42,146,34,249,129,117,245,194,143,36,186,163,100,228,96,28,82,255,146,82,189,73,217,34,205,224,168,223,134,217,193,248,52,191,118,254,252,201,221,40,34,242,59,167,122,250,101,252,176,34,174,36,86,3,102,217,197,164,61,40,151,230,45,156,26,53,10,70,225,191,84,161,86,151,42,5,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReportMSWordEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f8cedcd4-f05e-4939-b73e-90ee95c84921"));
		}

		#endregion

	}

	#endregion

}

