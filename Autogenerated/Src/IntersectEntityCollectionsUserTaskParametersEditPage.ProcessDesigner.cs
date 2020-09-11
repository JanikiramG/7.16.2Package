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
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: IntersectEntityCollectionsUserTaskParametersEditPageSchema

	/// <exclude/>
	public class IntersectEntityCollectionsUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _titleEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit TitleEdit {
			get {
				return _titleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _entityCollectionTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit EntityCollectionTextEdit {
			get {
				return _entityCollectionTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _entityCollectionEditToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton EntityCollectionEditToolButton {
			get {
				return _entityCollectionEditToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label1;
		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return _label1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _filterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return _filterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _samplingEntityCollectionTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SamplingEntityCollectionTextEdit {
			get {
				return _samplingEntityCollectionTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _samplingEntityCollectionEditToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton SamplingEntityCollectionEditToolButton {
			get {
				return _samplingEntityCollectionEditToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label2;
		public Terrasoft.UI.WebControls.Controls.Label Label2 {
			get {
				return _label2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _samplingFilterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit SamplingFilterEdit {
			get {
				return _samplingFilterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _samplingColumnEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SamplingColumnEdit {
			get {
				return _samplingColumnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _samplingColumnEditButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton SamplingColumnEditButton {
			get {
				return _samplingColumnEditButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label3;
		public Terrasoft.UI.WebControls.Controls.Label Label3 {
			get {
				return _label3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _columnEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnEdit {
			get {
				return _columnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _columnEditButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ColumnEditButton {
			get {
				return _columnEditButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _entityDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return _entityDataSource;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _samplingEntityDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource SamplingEntityDataSource {
			get {
				return _samplingEntityDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public IntersectEntityCollectionsUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public IntersectEntityCollectionsUserTaskParametersEditPageSchema(IntersectEntityCollectionsUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			RealUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			Name = "IntersectEntityCollectionsUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 615;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateIntersectEntityCollectionsUserTaskParametersEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateTitleEdit());
			ControlLayout1.InsertItem(1, CreateEntityCollectionTextEdit());
			EntityCollectionTextEdit.InsertItem(0, CreateEntityCollectionEditToolButton());
			ControlLayout1.InsertItem(2, CreateLabel1());
			ControlLayout1.InsertItem(3, CreateFilterEdit());
			TopControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateSamplingEntityCollectionTextEdit());
			SamplingEntityCollectionTextEdit.InsertItem(0, CreateSamplingEntityCollectionEditToolButton());
			ControlLayout2.InsertItem(1, CreateLabel2());
			ControlLayout2.InsertItem(2, CreateSamplingFilterEdit());
			TopControlLayout.InsertItem(2, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateSamplingColumnEdit());
			SamplingColumnEdit.InsertItem(0, CreateSamplingColumnEditButton());
			ControlLayout4.InsertItem(1, CreateLabel3());
			ControlLayout3.InsertItem(1, CreateColumnEdit());
			ColumnEdit.InsertItem(0, CreateColumnEditButton());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			Controls.AddAt(3, CreateEntityDataSource());
			UpdateEntityDataSource();
			Controls.AddAt(4, CreateSamplingEntityDataSource());
			UpdateSamplingEntityDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateIntersectEntityCollectionsUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new IntersectEntityCollectionsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateTitleEdit() {
			_titleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_titleEdit.UId = new Guid("2079bf5e-9279-4b6b-8bb8-dd50bf3c7bf3");
			_titleEdit.Name = "TitleEdit";
			_titleEdit.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_titleEdit.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_titleEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_titleEdit.Tag = "";
			_titleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_titleEdit.Image = new ControlImage {};
			_titleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_titleEdit.Required = true;
			return _titleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateEntityCollectionEditToolButton() {
			_entityCollectionEditToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_entityCollectionEditToolButton.UId = new Guid("5e140b64-4121-4d38-8402-73dda7ff6468");
			_entityCollectionEditToolButton.Name = "EntityCollectionEditToolButton";
			_entityCollectionEditToolButton.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_entityCollectionEditToolButton.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_entityCollectionEditToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionEditToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_entityCollectionEditToolButton.Tag = "";
			_entityCollectionEditToolButton.Image = new ControlImage {};
			return _entityCollectionEditToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateEntityCollectionTextEdit() {
			_entityCollectionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_entityCollectionTextEdit.UId = new Guid("56a99017-102e-4512-9492-81893aaae77b");
			_entityCollectionTextEdit.Name = "EntityCollectionTextEdit";
			_entityCollectionTextEdit.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_entityCollectionTextEdit.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_entityCollectionTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionTextEdit.Tag = "";
			_entityCollectionTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityCollectionTextEdit.Image = new ControlImage {};
			_entityCollectionTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityCollectionTextEdit.Required = true;
			return _entityCollectionTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel1() {
			_label1 = new Terrasoft.UI.WebControls.Controls.Label();
			_label1.UId = new Guid("77f5ad3f-d220-4e03-9c2d-47ee8ec6659d");
			_label1.Name = "Label1";
			_label1.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_label1.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_label1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label1.Tag = "";
			_label1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _label1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("d7aa8598-e4d2-416c-8443-7ad9001268a4");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_filterEdit.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "EntityDataSource";
			_filterEdit.Edges = "";
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("513545f4-b28c-4e2f-a915-c90d892f79ba");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_controlLayout1.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateSamplingEntityCollectionEditToolButton() {
			_samplingEntityCollectionEditToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_samplingEntityCollectionEditToolButton.UId = new Guid("722fa5dc-eeea-4fe4-9ea6-b83ad7cefd39");
			_samplingEntityCollectionEditToolButton.Name = "SamplingEntityCollectionEditToolButton";
			_samplingEntityCollectionEditToolButton.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingEntityCollectionEditToolButton.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingEntityCollectionEditToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_samplingEntityCollectionEditToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_samplingEntityCollectionEditToolButton.Tag = "";
			_samplingEntityCollectionEditToolButton.Image = new ControlImage {};
			return _samplingEntityCollectionEditToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSamplingEntityCollectionTextEdit() {
			_samplingEntityCollectionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_samplingEntityCollectionTextEdit.UId = new Guid("fcb90745-38cc-4689-bac2-1125865f92e3");
			_samplingEntityCollectionTextEdit.Name = "SamplingEntityCollectionTextEdit";
			_samplingEntityCollectionTextEdit.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingEntityCollectionTextEdit.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingEntityCollectionTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_samplingEntityCollectionTextEdit.Tag = "";
			_samplingEntityCollectionTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_samplingEntityCollectionTextEdit.Image = new ControlImage {};
			_samplingEntityCollectionTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_samplingEntityCollectionTextEdit.Required = true;
			return _samplingEntityCollectionTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel2() {
			_label2 = new Terrasoft.UI.WebControls.Controls.Label();
			_label2.UId = new Guid("047e58a8-581f-4dcc-948e-30d2ba8befeb");
			_label2.Name = "Label2";
			_label2.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_label2.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_label2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label2.Tag = "";
			_label2.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _label2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateSamplingFilterEdit() {
			_samplingFilterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_samplingFilterEdit.UId = new Guid("876c08fe-7779-4a07-ada6-290804afb446");
			_samplingFilterEdit.Name = "SamplingFilterEdit";
			_samplingFilterEdit.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingFilterEdit.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingFilterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_samplingFilterEdit.Tag = "";
			_samplingFilterEdit.DataSourceId = "SamplingEntityDataSource";
			_samplingFilterEdit.Edges = "";
			_samplingFilterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _samplingFilterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("65f7eb33-ea61-4e6c-81f0-f2421804be8f");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_controlLayout2.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
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

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateSamplingColumnEditButton() {
			_samplingColumnEditButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_samplingColumnEditButton.UId = new Guid("dbe6d16f-83a3-4576-bd59-732e152495e1");
			_samplingColumnEditButton.Name = "SamplingColumnEditButton";
			_samplingColumnEditButton.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingColumnEditButton.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingColumnEditButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_samplingColumnEditButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_samplingColumnEditButton.Tag = "";
			_samplingColumnEditButton.Image = new ControlImage {};
			return _samplingColumnEditButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSamplingColumnEdit() {
			_samplingColumnEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_samplingColumnEdit.UId = new Guid("550f40d2-be1f-4031-8d53-2ca43fafae2a");
			_samplingColumnEdit.Name = "SamplingColumnEdit";
			_samplingColumnEdit.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingColumnEdit.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingColumnEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_samplingColumnEdit.Tag = "";
			_samplingColumnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_samplingColumnEdit.Image = new ControlImage {};
			_samplingColumnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_samplingColumnEdit.Required = true;
			return _samplingColumnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel3() {
			_label3 = new Terrasoft.UI.WebControls.Controls.Label();
			_label3.UId = new Guid("2928e60f-5b0b-41d5-a415-3fa284269f79");
			_label3.Name = "Label3";
			_label3.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_label3.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_label3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label3.Tag = "";
			_label3.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _label3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("585cd1ef-7e44-4c5b-86c1-921431389f5b");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_controlLayout4.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout4.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout4.FitHeightByContent = true;
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateColumnEditButton() {
			_columnEditButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_columnEditButton.UId = new Guid("fd86de7d-7e43-482e-a074-6e0cfc7f6edc");
			_columnEditButton.Name = "ColumnEditButton";
			_columnEditButton.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_columnEditButton.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_columnEditButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnEditButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_columnEditButton.Tag = "";
			_columnEditButton.Image = new ControlImage {};
			return _columnEditButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateColumnEdit() {
			_columnEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_columnEdit.UId = new Guid("c1bf6c51-3320-43d6-a50d-dd92ba6801b1");
			_columnEdit.Name = "ColumnEdit";
			_columnEdit.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_columnEdit.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_columnEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnEdit.Tag = "";
			_columnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnEdit.Image = new ControlImage {};
			_columnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnEdit.Required = true;
			return _columnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("b658fbc2-0966-4cbc-9307-ef20f7ad8d99");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_controlLayout3.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.DefaultMargins = "0 0 5 0";
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("2ec1c99c-059e-4752-8d98-fa3134a6f18d");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_entityDataSource.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("09a6fcf1-2003-4990-8018-51369fda1313");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			return _entityDataSource;
		}

		protected virtual void UpdateEntityDataSource() {
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateSamplingEntityDataSource() {
			_samplingEntityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_samplingEntityDataSource.UId = new Guid("d65a753a-ea03-4eae-85cf-09bbcefa02ad");
			_samplingEntityDataSource.Name = "SamplingEntityDataSource";
			_samplingEntityDataSource.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingEntityDataSource.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingEntityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_samplingEntityDataSource.Tag = "";
			_samplingEntityDataSource.EnableServerActiveRow = false;
			_samplingEntityDataSource.SchemaUId = Guid.Empty;
			_samplingEntityDataSource.HierarchicalDepth = 1;
			_samplingEntityDataSource.DefStructure.ID = "c" + _samplingEntityDataSource.DefStructure.UId.ToString("N");
			_samplingEntityDataSource.DefStructure.UId = new Guid("f98f6763-5dcf-4984-8a4d-1eb6497daab8");
			_samplingEntityDataSource.DefStructure.Name = "DefStructure";
			_samplingEntityDataSource.DefStructure.CreatedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			_samplingEntityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			return _samplingEntityDataSource;
		}

		protected virtual void UpdateSamplingEntityDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new IntersectEntityCollectionsUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new IntersectEntityCollectionsUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.IntersectEntityCollectionsUserTaskParametersEditPageSchemaUserControl
	{

		#region Class: ChangeEntityCollectionUserMessageFlowElement

		/// <exclude/>
		public class ChangeEntityCollectionUserMessageFlowElement : QuestionUserTask
		{

			public ChangeEntityCollectionUserMessageFlowElement(UserConnection userConnection, IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeEntityCollectionUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b");
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

		public virtual string EntityCollectionMetaPath {
			get;
			set;
		}

		public virtual string EntityCollectionDisplayValue {
			get;
			set;
		}

		public virtual string SamplingEntityCollectionMetaPath {
			get;
			set;
		}

		public virtual string SamplingEntityCollectionDisplayValue {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual bool IsNewSamplingEntityCollection {
			get;
			set;
		}

		public virtual Guid EntityCollectionSchemaUId {
			get;
			set;
		}

		public virtual Guid SamplingEntityCollectionSchemaUId {
			get;
			set;
		}

		public virtual bool IsEditingSamplingEntityCollection {
			get;
			set;
		}

		public virtual string NewEntityCollectionParameterValue {
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

		public virtual bool IsSelectedColumnEdit {
			get;
			set;
		}

		public virtual string ColumnMetaPath {
			get;
			set;
		}

		public virtual string SamplingColumnMetaPath {
			get;
			set;
		}

		public virtual Guid SelectedSchemaColumnDataValueTypeUId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("8c26b486-06c6-474e-bc58-62f53821bfd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entityCollectionEditToolButtonClickMessage;
		public ProcessFlowElement EntityCollectionEditToolButtonClickMessage {
			get {
				return _entityCollectionEditToolButtonClickMessage ?? (_entityCollectionEditToolButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntityCollectionEditToolButtonClickMessage",
					SchemaElementUId = new Guid("945934d2-ef54-4919-a1f9-da313a720669"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _entityCollectionEditToolButtonClickScript;
		public ProcessScriptTask EntityCollectionEditToolButtonClickScript {
			get {
				return _entityCollectionEditToolButtonClickScript ?? (_entityCollectionEditToolButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EntityCollectionEditToolButtonClickScript",
					SchemaElementUId = new Guid("084af5d9-fe30-428a-b34d-b339a387f1b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EntityCollectionEditToolButtonClickScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessOnInit;
		public ProcessFlowElement EventSubProcessOnInit {
			get {
				return _eventSubProcessOnInit ?? (_eventSubProcessOnInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessOnInit",
					SchemaElementUId = new Guid("c1e183f1-36f8-4ed3-a143-76a5d63af5f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageInit;
		public ProcessFlowElement StartMessageInit {
			get {
				return _startMessageInit ?? (_startMessageInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageInit",
					SchemaElementUId = new Guid("7e565d21-3fb5-4960-98ea-e70a33b0bc34"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _childInitScript;
		public ProcessScriptTask ChildInitScript {
			get {
				return _childInitScript ?? (_childInitScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildInitScript",
					SchemaElementUId = new Guid("636d8048-4027-4703-8cbe-d2a48f7b94ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildInitScriptExecute,
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
					SchemaElementUId = new Guid("64cf90ec-6971-4c04-af3b-f42d4cc5f482"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("2e26c065-bed7-4874-81a7-524b935e7e38"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessagePageLoadComplete;
		public ProcessFlowElement StartMessagePageLoadComplete {
			get {
				return _startMessagePageLoadComplete ?? (_startMessagePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessagePageLoadComplete",
					SchemaElementUId = new Guid("82a4a152-28b8-437f-a550-277e54186624"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEventPageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowMessageEventPageLoadComplete {
			get {
				return _intermediateThrowMessageEventPageLoadComplete ?? (_intermediateThrowMessageEventPageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEventPageLoadComplete",
					SchemaElementUId = new Guid("4df3506f-fd28-4b75-b8b3-e220958b81a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteChildScript;
		public ProcessScriptTask PageLoadCompleteChildScript {
			get {
				return _pageLoadCompleteChildScript ?? (_pageLoadCompleteChildScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteChildScript",
					SchemaElementUId = new Guid("30f3340d-5765-4517-ba1e-47fa033630df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteChildScriptExecute,
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
					SchemaElementUId = new Guid("d4baa63c-9a25-4abf-acfa-90871ac9c454"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickMessage;
		public ProcessFlowElement OkButtonClickMessage {
			get {
				return _okButtonClickMessage ?? (_okButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickMessage",
					SchemaElementUId = new Guid("5c4c9ae9-f5c2-44f2-b6a6-9827d2b1d142"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickChildScript;
		public ProcessScriptTask OkButtonClickChildScript {
			get {
				return _okButtonClickChildScript ?? (_okButtonClickChildScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickChildScript",
					SchemaElementUId = new Guid("9e644802-cba2-4cde-b7ec-b32a549f5d3f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickChildScriptExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _okButtonClickIntermediateMessage;
		public ProcessThrowMessageEvent OkButtonClickIntermediateMessage {
			get {
				return _okButtonClickIntermediateMessage ?? (_okButtonClickIntermediateMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OkButtonClickIntermediateMessage",
					SchemaElementUId = new Guid("661cf85b-c18a-4400-9d3e-21009fdac1a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("632fbec6-7290-4d7a-a31c-9852251e2092"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _samplingEntityCollectionEditToolButtonClickMessage;
		public ProcessFlowElement SamplingEntityCollectionEditToolButtonClickMessage {
			get {
				return _samplingEntityCollectionEditToolButtonClickMessage ?? (_samplingEntityCollectionEditToolButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SamplingEntityCollectionEditToolButtonClickMessage",
					SchemaElementUId = new Guid("fee7aba0-7d65-4cf3-bdc3-87903ebf7358"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _samplingEntityCollectionEditToolButtonClickScript;
		public ProcessScriptTask SamplingEntityCollectionEditToolButtonClickScript {
			get {
				return _samplingEntityCollectionEditToolButtonClickScript ?? (_samplingEntityCollectionEditToolButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SamplingEntityCollectionEditToolButtonClickScript",
					SchemaElementUId = new Guid("4d80e733-af5a-4316-920b-386012b486d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SamplingEntityCollectionEditToolButtonClickScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeEntityCollectionYesMessage;
		public ProcessFlowElement EventSubProcessChangeEntityCollectionYesMessage {
			get {
				return _eventSubProcessChangeEntityCollectionYesMessage ?? (_eventSubProcessChangeEntityCollectionYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeEntityCollectionYesMessage",
					SchemaElementUId = new Guid("c02c1ff2-ab66-4345-aede-4bc65d6262ef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeEntityCollectionYesMessageBase;
		public ProcessFlowElement ChangeEntityCollectionYesMessageBase {
			get {
				return _changeEntityCollectionYesMessageBase ?? (_changeEntityCollectionYesMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeEntityCollectionYesMessageBase",
					SchemaElementUId = new Guid("4858face-9db4-4efe-bdb1-b3a772a6cf71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeEntityCollectionYesMessageScript;
		public ProcessScriptTask ChangeEntityCollectionYesMessageScript {
			get {
				return _changeEntityCollectionYesMessageScript ?? (_changeEntityCollectionYesMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeEntityCollectionYesMessageScript",
					SchemaElementUId = new Guid("fd0261ef-12b6-476a-bf5f-07f56cb24b0f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEntityCollectionYesMessageScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeEntityCollectionNoMessage;
		public ProcessFlowElement EventSubProcessChangeEntityCollectionNoMessage {
			get {
				return _eventSubProcessChangeEntityCollectionNoMessage ?? (_eventSubProcessChangeEntityCollectionNoMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeEntityCollectionNoMessage",
					SchemaElementUId = new Guid("bd4fab16-5283-45a0-aa5b-711cdd8f5b1c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeEntityCollectionNoMessageBase;
		public ProcessFlowElement ChangeEntityCollectionNoMessageBase {
			get {
				return _changeEntityCollectionNoMessageBase ?? (_changeEntityCollectionNoMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeEntityCollectionNoMessageBase",
					SchemaElementUId = new Guid("318b980a-6ddb-49cd-be46-ea6c99cc1f1f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeEntityCollectionNoMessageScript;
		public ProcessScriptTask ChangeEntityCollectionNoMessageScript {
			get {
				return _changeEntityCollectionNoMessageScript ?? (_changeEntityCollectionNoMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeEntityCollectionNoMessageScript",
					SchemaElementUId = new Guid("556d52d7-8420-41f9-9409-4ef9a0a7709f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEntityCollectionNoMessageScriptExecute,
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
					SchemaElementUId = new Guid("fcc6e2c0-ed32-420e-8321-2669017bd61b"),
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
					SchemaElementUId = new Guid("4795143b-20f0-4817-9d87-9a9c5c3d4f50"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _newEntityCollectionParameterValueScriptTask;
		public ProcessScriptTask NewEntityCollectionParameterValueScriptTask {
			get {
				return _newEntityCollectionParameterValueScriptTask ?? (_newEntityCollectionParameterValueScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NewEntityCollectionParameterValueScriptTask",
					SchemaElementUId = new Guid("5c6fe146-4fb4-44b6-a19e-777f8a5c17ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NewEntityCollectionParameterValueScriptTaskExecute,
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
					SchemaElementUId = new Guid("c3d54868-bfa9-4cb6-ae12-d85b0077fd9b"),
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

		private ProcessScriptTask _prepareChangeEntityCollectionQuestionScript;
		public ProcessScriptTask PrepareChangeEntityCollectionQuestionScript {
			get {
				return _prepareChangeEntityCollectionQuestionScript ?? (_prepareChangeEntityCollectionQuestionScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareChangeEntityCollectionQuestionScript",
					SchemaElementUId = new Guid("d84ac122-a854-4223-af2c-ff0b5dade848"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareChangeEntityCollectionQuestionScriptExecute,
				});
			}
		}

		private ChangeEntityCollectionUserMessageFlowElement _changeEntityCollectionUserMessage;
		public ChangeEntityCollectionUserMessageFlowElement ChangeEntityCollectionUserMessage {
			get {
				return _changeEntityCollectionUserMessage ?? (_changeEntityCollectionUserMessage = new ChangeEntityCollectionUserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("f3f9c007-5b9a-4593-9004-cf673f47433a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeEntityCollectionYesMessage",
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
					SchemaElementUId = new Guid("5b234e7d-ea7d-41a1-bc73-72f729ded483"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _columnEditButtonClickMessage;
		public ProcessFlowElement ColumnEditButtonClickMessage {
			get {
				return _columnEditButtonClickMessage ?? (_columnEditButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnEditButtonClickMessage",
					SchemaElementUId = new Guid("e912203e-357c-48d0-9bd5-6a9a90586dbb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _openColumnExplorerScriptTask;
		public ProcessScriptTask OpenColumnExplorerScriptTask {
			get {
				return _openColumnExplorerScriptTask ?? (_openColumnExplorerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpenColumnExplorerScriptTask",
					SchemaElementUId = new Guid("dccdbb18-9356-4390-b48c-61c8c7c8ee33"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpenColumnExplorerScriptTaskExecute,
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
					SchemaElementUId = new Guid("86e30d00-395c-4e9e-a1a1-a4710e3ee0ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _samplingColumnEditButtonClickMessage;
		public ProcessFlowElement SamplingColumnEditButtonClickMessage {
			get {
				return _samplingColumnEditButtonClickMessage ?? (_samplingColumnEditButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SamplingColumnEditButtonClickMessage",
					SchemaElementUId = new Guid("0c8da8c6-c7b3-4aaf-94d1-8a9500b0cee6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _openSamplingColumnExplorerScriptTask;
		public ProcessScriptTask OpenSamplingColumnExplorerScriptTask {
			get {
				return _openSamplingColumnExplorerScriptTask ?? (_openSamplingColumnExplorerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpenSamplingColumnExplorerScriptTask",
					SchemaElementUId = new Guid("9d89b57f-1819-40fd-8d70-e252145f2bd4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpenSamplingColumnExplorerScriptTaskExecute,
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
					SchemaElementUId = new Guid("4565ce1e-229b-4ee1-a585-5fd75acdbd04"),
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

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[EntityCollectionEditToolButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityCollectionEditToolButtonClickMessage };
			FlowElements[EntityCollectionEditToolButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityCollectionEditToolButtonClickScript };
			FlowElements[EventSubProcessOnInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessOnInit };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
			FlowElements[ChildInitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitScript };
			FlowElements[IntermediateThrowMessageEventInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventInit };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[StartMessagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePageLoadComplete };
			FlowElements[IntermediateThrowMessageEventPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventPageLoadComplete };
			FlowElements[PageLoadCompleteChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScript };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[OkButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickMessage };
			FlowElements[OkButtonClickChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildScript };
			FlowElements[OkButtonClickIntermediateMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickIntermediateMessage };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[SamplingEntityCollectionEditToolButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SamplingEntityCollectionEditToolButtonClickMessage };
			FlowElements[SamplingEntityCollectionEditToolButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SamplingEntityCollectionEditToolButtonClickScript };
			FlowElements[EventSubProcessChangeEntityCollectionYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeEntityCollectionYesMessage };
			FlowElements[ChangeEntityCollectionYesMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageBase };
			FlowElements[ChangeEntityCollectionYesMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageScript };
			FlowElements[EventSubProcessChangeEntityCollectionNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeEntityCollectionNoMessage };
			FlowElements[ChangeEntityCollectionNoMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageBase };
			FlowElements[ChangeEntityCollectionNoMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageScript };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[NewEntityCollectionParameterValueScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NewEntityCollectionParameterValueScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[PrepareChangeEntityCollectionQuestionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareChangeEntityCollectionQuestionScript };
			FlowElements[ChangeEntityCollectionUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionUserMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[ColumnEditButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnEditButtonClickMessage };
			FlowElements[OpenColumnExplorerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenColumnExplorerScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[SamplingColumnEditButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SamplingColumnEditButtonClickMessage };
			FlowElements[OpenSamplingColumnExplorerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenSamplingColumnExplorerScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "EntityCollectionEditToolButtonClickMessage":
						e.Context.QueueTasks.Enqueue("EntityCollectionEditToolButtonClickScript");
						break;
					case "EntityCollectionEditToolButtonClickScript":
						break;
					case "EventSubProcessOnInit":
						break;
					case "StartMessageInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventInit");
						break;
					case "ChildInitScript":
						break;
					case "IntermediateThrowMessageEventInit":
						e.Context.QueueTasks.Enqueue("ChildInitScript");
						break;
					case "EventSubProcess4":
						break;
					case "StartMessagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventPageLoadComplete");
						break;
					case "IntermediateThrowMessageEventPageLoadComplete":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScript");
						break;
					case "PageLoadCompleteChildScript":
						break;
					case "EventSubProcess5":
						break;
					case "OkButtonClickMessage":
						e.Context.QueueTasks.Enqueue("OkButtonClickChildScript");
						break;
					case "OkButtonClickChildScript":
						e.Context.QueueTasks.Enqueue("OkButtonClickIntermediateMessage");
						break;
					case "OkButtonClickIntermediateMessage":
						break;
					case "EventSubProcess3":
						break;
					case "SamplingEntityCollectionEditToolButtonClickMessage":
						e.Context.QueueTasks.Enqueue("SamplingEntityCollectionEditToolButtonClickScript");
						break;
					case "SamplingEntityCollectionEditToolButtonClickScript":
						break;
					case "EventSubProcessChangeEntityCollectionYesMessage":
						break;
					case "ChangeEntityCollectionYesMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionYesMessageScript");
						break;
					case "ChangeEntityCollectionYesMessageScript":
						break;
					case "EventSubProcessChangeEntityCollectionNoMessage":
						break;
					case "ChangeEntityCollectionNoMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionNoMessageScript");
						break;
					case "ChangeEntityCollectionNoMessageScript":
						break;
					case "EventSubProcess6":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("NewEntityCollectionParameterValueScriptTask");
						break;
					case "NewEntityCollectionParameterValueScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareChangeEntityCollectionQuestionScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "PrepareChangeEntityCollectionQuestionScript":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionUserMessage");
						break;
					case "ChangeEntityCollectionUserMessage":
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess7":
						break;
					case "ColumnEditButtonClickMessage":
						e.Context.QueueTasks.Enqueue("OpenColumnExplorerScriptTask");
						break;
					case "OpenColumnExplorerScriptTask":
						break;
					case "EventSubProcess8":
						break;
					case "SamplingColumnEditButtonClickMessage":
						e.Context.QueueTasks.Enqueue("OpenSamplingColumnExplorerScriptTask");
						break;
					case "OpenSamplingColumnExplorerScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(IsEditingSamplingEntityCollection ? !IsNewSamplingEntityCollection : !IsNew);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EntityCollectionEditToolButtonClickMessage");
			ActivatedEventElements.Add("StartMessageInit");
			ActivatedEventElements.Add("StartMessagePageLoadComplete");
			ActivatedEventElements.Add("OkButtonClickMessage");
			ActivatedEventElements.Add("SamplingEntityCollectionEditToolButtonClickMessage");
			ActivatedEventElements.Add("ChangeEntityCollectionYesMessageBase");
			ActivatedEventElements.Add("ChangeEntityCollectionNoMessageBase");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("ColumnEditButtonClickMessage");
			ActivatedEventElements.Add("SamplingColumnEditButtonClickMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "EntityCollectionEditToolButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityCollectionEditToolButtonClickMessage";
					result = EntityCollectionEditToolButtonClickMessage.Execute(context);
					break;
				case "EntityCollectionEditToolButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityCollectionEditToolButtonClickScript";
					result = EntityCollectionEditToolButtonClickScript.Execute(context, EntityCollectionEditToolButtonClickScriptExecute);
					break;
				case "EventSubProcessOnInit":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageInit";
					result = StartMessageInit.Execute(context);
					break;
				case "ChildInitScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitScript";
					result = ChildInitScript.Execute(context, ChildInitScriptExecute);
					break;
				case "IntermediateThrowMessageEventInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEventInit.Execute(context);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePageLoadComplete";
					result = StartMessagePageLoadComplete.Execute(context);
					break;
				case "IntermediateThrowMessageEventPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEventPageLoadComplete.Execute(context);
					break;
				case "PageLoadCompleteChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChildScript";
					result = PageLoadCompleteChildScript.Execute(context, PageLoadCompleteChildScriptExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickMessage";
					result = OkButtonClickMessage.Execute(context);
					break;
				case "OkButtonClickChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickChildScript";
					result = OkButtonClickChildScript.Execute(context, OkButtonClickChildScriptExecute);
					break;
				case "OkButtonClickIntermediateMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = OkButtonClickIntermediateMessage.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "SamplingEntityCollectionEditToolButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SamplingEntityCollectionEditToolButtonClickMessage";
					result = SamplingEntityCollectionEditToolButtonClickMessage.Execute(context);
					break;
				case "SamplingEntityCollectionEditToolButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SamplingEntityCollectionEditToolButtonClickScript";
					result = SamplingEntityCollectionEditToolButtonClickScript.Execute(context, SamplingEntityCollectionEditToolButtonClickScriptExecute);
					break;
				case "EventSubProcessChangeEntityCollectionYesMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeEntityCollectionYesMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionYesMessageBase";
					result = ChangeEntityCollectionYesMessageBase.Execute(context);
					break;
				case "ChangeEntityCollectionYesMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionYesMessageScript";
					result = ChangeEntityCollectionYesMessageScript.Execute(context, ChangeEntityCollectionYesMessageScriptExecute);
					break;
				case "EventSubProcessChangeEntityCollectionNoMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeEntityCollectionNoMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionNoMessageBase";
					result = ChangeEntityCollectionNoMessageBase.Execute(context);
					break;
				case "ChangeEntityCollectionNoMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionNoMessageScript";
					result = ChangeEntityCollectionNoMessageScript.Execute(context, ChangeEntityCollectionNoMessageScriptExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "NewEntityCollectionParameterValueScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "NewEntityCollectionParameterValueScriptTask";
					result = NewEntityCollectionParameterValueScriptTask.Execute(context, NewEntityCollectionParameterValueScriptTaskExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "PrepareChangeEntityCollectionQuestionScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareChangeEntityCollectionQuestionScript";
					result = PrepareChangeEntityCollectionQuestionScript.Execute(context, PrepareChangeEntityCollectionQuestionScriptExecute);
					break;
				case "ChangeEntityCollectionUserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionUserMessage";
					result = ChangeEntityCollectionUserMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "ColumnEditButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnEditButtonClickMessage";
					result = ColumnEditButtonClickMessage.Execute(context);
					break;
				case "OpenColumnExplorerScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenColumnExplorerScriptTask";
					result = OpenColumnExplorerScriptTask.Execute(context, OpenColumnExplorerScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "SamplingColumnEditButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SamplingColumnEditButtonClickMessage";
					result = SamplingColumnEditButtonClickMessage.Execute(context);
					break;
				case "OpenSamplingColumnExplorerScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenSamplingColumnExplorerScriptTask";
					result = OpenSamplingColumnExplorerScriptTask.Execute(context, OpenSamplingColumnExplorerScriptTaskExecute);
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
				case "SelectedSchemaColumnDataValueTypeUId":
					SelectedSchemaColumnDataValueTypeUId = reader.GetValue<System.Guid>();
				break;
				case "SamplingColumnMetaPath":
					SamplingColumnMetaPath = reader.GetValue<System.String>();
				break;
				case "ColumnMetaPath":
					ColumnMetaPath = reader.GetValue<System.String>();
				break;
				case "IsSelectedColumnEdit":
					IsSelectedColumnEdit = reader.GetValue<System.Boolean>();
				break;
				case "ColumnExplorer":
					ColumnExplorer = reader.GetSerializableObjectValue();
				break;
				case "IsColumnExplorerCreated":
					IsColumnExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "NewEntityCollectionParameterValue":
					NewEntityCollectionParameterValue = reader.GetValue<System.String>();
				break;
				case "IsEditingSamplingEntityCollection":
					IsEditingSamplingEntityCollection = reader.GetValue<System.Boolean>();
				break;
				case "SamplingEntityCollectionSchemaUId":
					SamplingEntityCollectionSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "EntityCollectionSchemaUId":
					EntityCollectionSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "IsNewSamplingEntityCollection":
					IsNewSamplingEntityCollection = reader.GetValue<System.Boolean>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "SamplingEntityCollectionDisplayValue":
					SamplingEntityCollectionDisplayValue = reader.GetValue<System.String>();
				break;
				case "SamplingEntityCollectionMetaPath":
					SamplingEntityCollectionMetaPath = reader.GetValue<System.String>();
				break;
				case "EntityCollectionDisplayValue":
					EntityCollectionDisplayValue = reader.GetValue<System.String>();
				break;
				case "EntityCollectionMetaPath":
					EntityCollectionMetaPath = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool EntityCollectionEditToolButtonClickScriptExecute(ProcessExecutingContext context) {
			IsEditingSamplingEntityCollection = false;
			ShowSchemaStructureExplorerEditWindow(EntityCollectionMetaPath,  Page.EntityCollectionTextEdit.ClientID, "EntityCollectionEditChange");
			return true;
		}

		public virtual bool ChildInitScriptExecute(ProcessExecutingContext context) {
			if (IsColumnExplorerCreated) {
				CreateColumnExplorer();
			}
			if (!Ext.IsAjaxRequest) {
				ParameterDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("EntityCollectionDataValueType").UId;
				Page.TitleEdit.Text = ElementNewCaption;
				var defValues = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
				DesignModeClassDescriptor descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = PropertyDataSource as VirtualDataSource;
				propertyDataSource.SetClientActiveRow();
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
				SetEnabledControlProperty(Page.ColumnEdit, false);
				Page.ColumnEditButton.Enabled = false;
				SetEnabledControlProperty(Page.SamplingColumnEdit, false);
				Page.SamplingColumnEditButton.Enabled = false;
				SelectedSchemaColumnDataValueTypeUId = Guid.Empty;
			}
			return true;
		}

		public virtual bool PageLoadCompleteChildScriptExecute(ProcessExecutingContext context) {
			EntityCollectionMetaPath = string.Empty;
			EntityCollectionDisplayValue = string.Empty;
			SamplingEntityCollectionMetaPath = string.Empty;
			SamplingEntityCollectionDisplayValue = string.Empty;
			var schema = FindDesignedProcessSchema();
			Page.FilterEdit.SetProcessSchema(schema);
			Page.FilterEdit.AggregationEnable = false;
			Page.SamplingFilterEdit.SetProcessSchema(schema);
			Page.SamplingFilterEdit.AggregationEnable = false;
			var df = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (df == null) {
				return true;
			}
			var entityCollection = df["EntityCollection"];
			if (entityCollection == null) {
				return true;
			}
			((Terrasoft.UI.WebControls.Page)Page.AspPage).CustomData["EntityCollectionCustomDataKey"] = Json.Serialize(entityCollection);
			if (entityCollection.ReferenceSchemaUId != Guid.Empty) {
				EntityCollectionSchemaUId = entityCollection.ReferenceSchemaUId;
				EntityCollectionMetaPath = entityCollection.Value;
				EntityCollectionDisplayValue = GetPropertyDisplayPathByServerMetaPath(GetPropertyServerMetaPathByClientMetaPath(entityCollection.Value));
				Page.EntityDataSource.SchemaUId = EntityCollectionSchemaUId;
				EntityCollectionDisplayValue = GetEntityCollectionDisplayValue(EntityCollectionDisplayValue, EntityCollectionMetaPath);
				Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
				SetEnabledControlProperty(Page.ColumnEdit, true);
				Page.ColumnEditButton.Enabled = true;
				var columnMetaPath = df["ColumnMetaPath"].Value;
				if(!string.IsNullOrEmpty(columnMetaPath)){
					ColumnMetaPath = columnMetaPath;
					EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntityCollectionSchemaUId);
					string schemaColumnPath = entitySchema.GetSchemaColumnPathByMetaPath(columnMetaPath);
					Page.ColumnEdit.Text = entitySchema.GetSchemaColumnFullCaptionByPath(schemaColumnPath);
				}
				string filters = df["DataSourceFilters"].Value;
				if (!string.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
					var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
						new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;	
					if (filterCollection != null) {
						Page.EntityDataSource.CurrentStructure.Filters.Add(filterCollection);
					}
				}
				InitializeFilterEdit(Page.EntityDataSource, Page.FilterEdit);
				Page.EntityDataSource.LoadStructure();
			} else {
				IsNew = true;
			}
			var samplingEntityCollection = df["SamplingEntityCollection"];
			if (samplingEntityCollection == null) {
				return true;
			}
			((Terrasoft.UI.WebControls.Page)Page.AspPage).CustomData["SamplingEntityCollectionCustomDataKey"] = Json.Serialize(samplingEntityCollection);
			if (samplingEntityCollection.ReferenceSchemaUId != Guid.Empty) {
				SamplingEntityCollectionSchemaUId = samplingEntityCollection.ReferenceSchemaUId;
				SamplingEntityCollectionMetaPath = samplingEntityCollection.Value;
				SamplingEntityCollectionDisplayValue = GetPropertyDisplayPathByServerMetaPath(
					GetPropertyServerMetaPathByClientMetaPath(samplingEntityCollection.Value));
				Page.SamplingEntityDataSource.SchemaUId = SamplingEntityCollectionSchemaUId;
				SamplingEntityCollectionDisplayValue = GetEntityCollectionDisplayValue(SamplingEntityCollectionDisplayValue, SamplingEntityCollectionMetaPath);
				Page.SamplingEntityCollectionTextEdit.Text = SamplingEntityCollectionDisplayValue;
				SetEnabledControlProperty(Page.SamplingColumnEdit, true);
				Page.SamplingColumnEditButton.Enabled = true;
				var columnMetaPath = df["SamplingColumnMetaPath"].Value;
				if(!string.IsNullOrEmpty(columnMetaPath)){
					SamplingColumnMetaPath = columnMetaPath;
					EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SamplingEntityCollectionSchemaUId);
					string schemaColumnPath = entitySchema.GetSchemaColumnPathByMetaPath(columnMetaPath);
					Page.SamplingColumnEdit.Text = entitySchema.GetSchemaColumnFullCaptionByPath(schemaColumnPath);
				}
				string filters = df["SamplingDataSourceFilters"].Value;
				if (!string.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.SamplingFilterEdit.DataSource);
					var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
						new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;	
					if (filterCollection != null) {
						Page.SamplingEntityDataSource.CurrentStructure.Filters.Add(filterCollection);
					}
				}
				InitializeFilterEdit(Page.SamplingEntityDataSource, Page.SamplingFilterEdit);
				Page.SamplingEntityDataSource.LoadStructure();
			} else {
				IsNewSamplingEntityCollection = true;
			}
			Page.FilterEdit.Enabled = EntityCollectionSchemaUId != Guid.Empty;
			Page.SamplingFilterEdit.Enabled = SamplingEntityCollectionSchemaUId != Guid.Empty;
			return true;
		}

		public virtual bool OkButtonClickChildScriptExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.TitleEdit.Text;
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			SaveEntityCollectionParameterValue(parametersValue, "EntityCollection", EntityCollectionMetaPath, EntityCollectionSchemaUId);
			SaveEntityCollectionParameterValue(parametersValue, "SamplingEntityCollection",
				SamplingEntityCollectionMetaPath, SamplingEntityCollectionSchemaUId);
			parametersValue["ResultEntityCollection"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				ReferenceSchemaUId = EntityCollectionSchemaUId
			};
			SaveDataSourceFiltersParameterValue(parametersValue, "DataSourceFilters", Page.FilterEdit);
			SaveDataSourceFiltersParameterValue(parametersValue, "SamplingDataSourceFilters", Page.SamplingFilterEdit);
			parametersValue["ColumnMetaPath"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = string.IsNullOrEmpty(ColumnMetaPath) ? noneVS : constVS,
				Value = ColumnMetaPath
			};
			parametersValue["SamplingColumnMetaPath"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = string.IsNullOrEmpty(SamplingColumnMetaPath) ? noneVS : constVS,
				Value = SamplingColumnMetaPath
			};
			return true;
		}

		public virtual bool SamplingEntityCollectionEditToolButtonClickScriptExecute(ProcessExecutingContext context) {
			IsEditingSamplingEntityCollection = true;
			ShowSchemaStructureExplorerEditWindow(SamplingEntityCollectionMetaPath,  Page.SamplingEntityCollectionTextEdit.ClientID, "EntityCollectionEditChange");
			return true;
		}

		public virtual bool ChangeEntityCollectionYesMessageScriptExecute(ProcessExecutingContext context) {
			ChangeEntityCollection();
			return true;
		}

		public virtual bool ChangeEntityCollectionNoMessageScriptExecute(ProcessExecutingContext context) {
			if(IsEditingSamplingEntityCollection) {
				Page.SamplingEntityCollectionTextEdit.Text = SamplingEntityCollectionDisplayValue;
			} else {
				Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
			}
			return true;
		}

		public virtual bool NewEntityCollectionParameterValueScriptTaskExecute(ProcessExecutingContext context) {
			NewEntityCollectionParameterValue = Json.Serialize(context.ThrowEventArgs);
			return true;
		}

		public virtual bool PrepareChangeEntityCollectionQuestionScriptExecute(ProcessExecutingContext context) {
			ChangeEntityCollectionUserMessage.Page = Page;
			ChangeEntityCollectionUserMessage.MessageText = ChangeSchemaEntityMessage;
			ChangeEntityCollectionUserMessage.Icon = "QUESTION";
			ChangeEntityCollectionUserMessage.Buttons = "YESNO";
			ChangeEntityCollectionUserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "ChangeEntityCollectionYesMessage"},
				{"no", "ChangeEntityCollectionNoMessage"},
			};
			return true;
		}

		public virtual bool OpenColumnExplorerScriptTaskExecute(ProcessExecutingContext context) {
			IsSelectedColumnEdit = true;
			OpenColumnExplorer(EntityCollectionSchemaUId, ColumnMetaPath);
			return true;
		}

		public virtual bool OpenSamplingColumnExplorerScriptTaskExecute(ProcessExecutingContext context) {
			IsSelectedColumnEdit = false;
			OpenColumnExplorer(SamplingEntityCollectionSchemaUId, SamplingColumnMetaPath);
			return true;
		}

		public override void InitializeSchemaExplorerWindow() {
			bool isNewSchemaExplorer = SchemaExplorer == null;
			if (isNewSchemaExplorer) {
				SchemaExplorer = new SchemaStructureExplorer(Page.TopControlLayout, "schemaStructure", false, false);
			}
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			if (isNewSchemaExplorer) {
				schemaExplorer.ManagerName = EditSchemaManagerName;
			} else {
				schemaExplorer.IncludedDataValueTypes.Clear();
			}
			schemaExplorer.IgnoredSchemaElementUId = EditElementUId;
			schemaExplorer.IncludedDataValueTypes.Add(ParameterDataValueTypeUId, Guid.NewGuid());
			Guid guidDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("Guid").UId;
			if (IsParameterLookup) {
				schemaExplorer.IncludedDataValueTypes.Add(guidDataValueTypeUId, Guid.Empty);
			}
			if (ParameterDataValueTypeUId == guidDataValueTypeUId) {
				schemaExplorer.IncludedDataValueTypes.Add(UserConnection.DataValueTypeManager.GetItemByName("Lookup").UId, Guid.Empty);
			}
			SchemaExplorerCreated = true;
			if (!SchemaExplorerRegistered) {
				schemaExplorer.Register();
				SchemaExplorerRegistered = true;
			}
		}

		public virtual string GetPropertyDisplayPathByServerMetaPath(string serverMetaPath) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var generator = new ProcessSchemaGenerator(UserConnection, processSchema.ProcessSchemaManager.Namespace);
			return generator.GetPropertyPathByMetaPath(new ProcessSchemaParameter(processSchema), serverMetaPath, true);
		}

		public virtual string GetPropertyServerMetaPathByClientMetaPath(string clientMetaPath) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var generator = new ProcessSchemaGenerator(UserConnection, processSchema.ProcessSchemaManager.Namespace);
			return generator.GetMetaPath(processSchema, clientMetaPath);
		}

		public virtual void ShowSchemaStructureExplorerEditWindow(string entityCollectionMetaPath, string textEditClientID, string textEditEventName) {
			InitializeSchemaExplorerWindow();
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			//Show parameters only where ReferenceSchemaUId not empty
			schemaExplorer.IncludedDataValueTypes[ParameterDataValueTypeUId] = Guid.NewGuid();
			var processSchema = FindDesignedProcessSchema();
			string handler = string.Empty;
			string handlerReferenceName = string.Format("window.{0}_EditCompleteParameter", schemaExplorer.ClientID);
			var propertyDataSource = PropertyDataSource as VirtualDataSource;
			var sb = new StringBuilder();
			sb.Append("function(columnInfo) {\n");
			sb.Append("var info = Ext.util.JSON.decode(columnInfo);");
			sb.AppendFormat("{0}.setValue(info.caption);", textEditClientID);
			sb.AppendFormat("window.Terrasoft.AjaxMethods.ThrowClientEventWithParameters('{0}', '{1}', columnInfo);", InstanceUId, textEditEventName);
			sb.Append("}");
			handler = sb.ToString();
			handler = string.Format(@"{0} = {1}", handlerReferenceName, handler);
			Page.ScriptManager.AddScript(string.Format("if ({2}) {{ {0}.un(\"{1}\",{2}); }}", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			Page.ScriptManager.AddScript(handler);
			Page.ScriptManager.AddScript(string.Format("{0}.on(\"{1}\",{2});", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			schemaExplorer.ManagerName = processSchema.Manager.Name;
			schemaExplorer.ShowEditWindow(processSchema.UId, entityCollectionMetaPath);
		}

		public virtual void ChangeEntityCollection() {
			var entityCollectionSelectedParameterValues = Json.Deserialize<Dictionary<string, object>>(NewEntityCollectionParameterValue);
			Guid entityCollectionSchemaUId = new Guid(entityCollectionSelectedParameterValues["referenceSchemaUId"].ToString());
			string entityCollectionMetaPath = entityCollectionSelectedParameterValues["metaPath"].ToString();
			string entityCollectionDisplayValue = entityCollectionSelectedParameterValues["caption"].ToString();
			entityCollectionDisplayValue = GetEntityCollectionDisplayValue(entityCollectionDisplayValue, entityCollectionMetaPath);
			if(IsEditingSamplingEntityCollection) {
				if (!IsNewSamplingEntityCollection) {
					Page.ColumnEdit.Text = string.Empty;
					Page.SamplingColumnEdit.Text = string.Empty;
					ColumnMetaPath = string.Empty;
					SamplingColumnMetaPath = string.Empty;
					SetEnabledControlProperty(Page.ColumnEdit, false);
					Page.ColumnEditButton.Enabled = false;
					ResetDataSourceFilters(Page.SamplingEntityDataSource);
				}
				IsNewSamplingEntityCollection = false;
				SamplingEntityCollectionSchemaUId = entityCollectionSchemaUId;
				SamplingEntityCollectionMetaPath = entityCollectionMetaPath;
				SamplingEntityCollectionDisplayValue = entityCollectionDisplayValue;
				Page.SamplingEntityCollectionTextEdit.Text = entityCollectionDisplayValue;
				Page.SamplingEntityDataSource.SchemaUId = entityCollectionSchemaUId;
				InitializeFilterEdit(Page.SamplingEntityDataSource, Page.SamplingFilterEdit);
				Page.SamplingEntityDataSource.LoadStructure();
				SetEnabledControlProperty(Page.SamplingColumnEdit, true);
				Page.SamplingColumnEditButton.Enabled = true;
				Page.SamplingFilterEdit.Enabled = SamplingEntityCollectionSchemaUId != Guid.Empty;
				//SetEnabledControlProperty(Page.SamplingColumnEdit, true);
			} else {
				if (!IsNew) {
					Page.ColumnEdit.Text = string.Empty;
					Page.SamplingColumnEdit.Text = string.Empty;
					ColumnMetaPath = string.Empty;
					SamplingColumnMetaPath = string.Empty;
					SetEnabledControlProperty(Page.ColumnEdit, false);
					Page.ColumnEditButton.Enabled = false;
					SetEnabledControlProperty(Page.SamplingColumnEdit, true);
					Page.SamplingColumnEditButton.Enabled = true;
					ResetDataSourceFilters(Page.EntityDataSource);
				}
				IsNew = false;
				EntityCollectionSchemaUId = entityCollectionSchemaUId;
				EntityCollectionMetaPath = entityCollectionMetaPath;
				EntityCollectionDisplayValue = entityCollectionDisplayValue;
				Page.EntityCollectionTextEdit.Text = entityCollectionDisplayValue;
				Page.EntityDataSource.SchemaUId = entityCollectionSchemaUId;
				InitializeFilterEdit(Page.EntityDataSource, Page.FilterEdit);
				Page.EntityDataSource.LoadStructure();
				//SetEnabledControlProperty(Page.ColumnEdit, true);
				//Page.ColumnEditButton.Enabled = true;
				Page.FilterEdit.Enabled = EntityCollectionSchemaUId != Guid.Empty;
			}
		}

		public virtual void InitializeFilterEdit(EntityDataSource dataSource, FilterEdit filterEdit) {
			var filterEditGroup = dataSource.FindFiltersGroupByName("FilterEdit");
			if (filterEditGroup == null) {
				filterEditGroup = dataSource.CreateFiltersGroup("FilterEdit");
				dataSource.CurrentStructure.Filters.Add(filterEditGroup);
			}
			filterEdit.AggregationEnable = false;
			filterEdit.IsColumnsExplorerRootMode = true;
			filterEdit.IsRightExpressionSchemaStructureExplorerRootMode = false;
			//filterEdit.Reinitialize(dataSource);
		}

		public virtual StructureExplorer CreateColumnExplorer() {
			var columnExplorer = new StructureExplorer(
				Page.TopControlLayout, "ColumnExplorer", false, true, null);
			
			columnExplorer.AjaxEvents.EditComplete.Event += ColumnExplorer_EditComplete;
			columnExplorer.AjaxEvents.EditComplete.ExtraParameters.Add(
				new UIControls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw));
			if (!IsColumnExplorerCreated) {
				columnExplorer.Register();
			}
			ColumnExplorer = columnExplorer;
			IsColumnExplorerCreated = true;
			return columnExplorer;
		}

		public virtual void OpenColumnExplorer(Guid entitySchemaUId, string columnMetaPath) {
			StructureExplorer columnExplorer;
			if (IsColumnExplorerCreated) {
				columnExplorer = (StructureExplorer)ColumnExplorer;
			} else {
				columnExplorer = CreateColumnExplorer();
			}
			/*
			if(!IsSelectedColumnEdit && SelectedSchemaColumnDataValueTypeUId != Guid.Empty) {
				columnExplorer.IncludedDataValueTypes.Clear();
				columnExplorer.IncludedDataValueTypes.Add(SelectedSchemaColumnDataValueTypeUId, Guid.Empty);
			}
			*/
			columnExplorer.ShowEditWindow(entitySchemaUId, columnMetaPath);
		}

		public virtual void ColumnExplorer_EditComplete(object sender, AjaxEventArgs e) {
			var column = (JObject)Json.Deserialize(e.ExtraParameters["itemsInfo"]);
			string columnCaption = column.Value<string>("caption");
			string columnMetaPath = column.Value<string>("metaPath");
			if(IsSelectedColumnEdit){
				Page.ColumnEdit.Text = columnCaption;
				ColumnMetaPath = columnMetaPath;
			} else {
				Page.SamplingColumnEdit.Text = columnCaption;
				SamplingColumnMetaPath = columnMetaPath;
				Page.ColumnEdit.Text = string.Empty;
				ColumnMetaPath = string.Empty;
				//SpecifySchemaColumnDataValueTypeUId(false);
				bool isEnabled = EntityCollectionSchemaUId != Guid.Empty;
				SetEnabledControlProperty(Page.ColumnEdit, isEnabled);
				Page.ColumnEditButton.Enabled = isEnabled;
			}
		}

		public virtual void SetEnabledControlProperty(TextEdit textEdit, bool isEnabled) {
			textEdit.Enabled = isEnabled;
			textEdit.SetRequired(isEnabled);
		}

		public virtual void SpecifySchemaColumnDataValueTypeUId(bool isSpecifiedSamplingColumn) {
			EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchemaColumn column;
			if (isSpecifiedSamplingColumn) {
				EntitySchema schema = entitySchemaManager.GetInstanceByUId(SamplingEntityCollectionSchemaUId);
				column = schema.GetSchemaColumnByMetaPath(SamplingColumnMetaPath);
			} else {
				EntitySchema schema = entitySchemaManager.GetInstanceByUId(EntityCollectionSchemaUId);
				column = schema.GetSchemaColumnByMetaPath(ColumnMetaPath);
			}
			SelectedSchemaColumnDataValueTypeUId = column.DataValueType.UId;
		}

		public virtual void ResetDataSourceFilters(EntityDataSource dataSource) {
			var filterEditGroup = dataSource.FindFiltersGroupByName("FilterEdit");
			if (filterEditGroup != null) {
				filterEditGroup.Clear();
			}
		}

		public virtual void SaveEntityCollectionParameterValue(Dictionary<string, ProcessSchemaParameterValue> parametersValue, string parameterName, string parameterMetaPath, Guid entitySchemaUId) {
			var entityCollection =
				Json.Deserialize<ProcessSchemaParameterValue>(((Terrasoft.UI.WebControls.Page)Page.AspPage)
				.CustomData[parameterName + "CustomDataKey"].ToString());
			entityCollection.MetaPath = parameterMetaPath;
			entityCollection.Value = parameterMetaPath;
			entityCollection.ModifiedInSchemaUId = EditSchemaUId;
			entityCollection.Source = string.IsNullOrEmpty(parameterMetaPath) ?
				ProcessSchemaParameterValueSource.None : ProcessSchemaParameterValueSource.Mapping;
			entityCollection.ReferenceSchemaUId = entitySchemaUId;
			parametersValue[parameterName] = entityCollection;
		}

		public virtual void SaveDataSourceFiltersParameterValue(Dictionary<string, ProcessSchemaParameterValue> parametersValue, string parameterName, FilterEdit filterEdit) {
			var filterCollection = filterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, filterEdit.DataSource);
			var serializedFilterCollection = Json.Serialize(filterCollection, jsonConverter);
			bool isNoneVS = filterCollection == null || filterCollection.Count == 0;
			parametersValue[parameterName] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = isNoneVS ? ProcessSchemaParameterValueSource.None : ProcessSchemaParameterValueSource.ConstValue,
				Value = isNoneVS ? string.Empty : serializedFilterCollection
			};
		}

		public virtual string GetEntityCollectionDisplayValue(string displayValue, string metaPath) {
			if (string.IsNullOrEmpty(displayValue)) {
				ProcessSchema processSchema = FindDesignedProcessSchema();
				displayValue = processSchema.GetBaseElementByUId(new Guid(metaPath)).Name;
			}
			return displayValue;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EntityCollectionEditToolButtonClick":
							if (ActivatedEventElements.Contains("EntityCollectionEditToolButtonClickMessage")) {
							context.QueueTasks.Enqueue("EntityCollectionEditToolButtonClickMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageInit")) {
							context.QueueTasks.Enqueue("StartMessageInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessagePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessagePageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "SamplingEntityCollectionEditToolButtonClick":
							if (ActivatedEventElements.Contains("SamplingEntityCollectionEditToolButtonClickMessage")) {
							context.QueueTasks.Enqueue("SamplingEntityCollectionEditToolButtonClickMessage");
						}
						break;
					case "ChangeEntityCollectionYesMessage":
							if (ActivatedEventElements.Contains("ChangeEntityCollectionYesMessageBase")) {
							context.QueueTasks.Enqueue("ChangeEntityCollectionYesMessageBase");
						}
						break;
					case "ChangeEntityCollectionNoMessage":
							if (ActivatedEventElements.Contains("ChangeEntityCollectionNoMessageBase")) {
							context.QueueTasks.Enqueue("ChangeEntityCollectionNoMessageBase");
						}
						break;
					case "EntityCollectionEditChange":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "ColumnEditButtonClick":
							if (ActivatedEventElements.Contains("ColumnEditButtonClickMessage")) {
							context.QueueTasks.Enqueue("ColumnEditButtonClickMessage");
						}
						break;
					case "SamplingColumnEditButtonClick":
							if (ActivatedEventElements.Contains("SamplingColumnEditButtonClickMessage")) {
							context.QueueTasks.Enqueue("SamplingColumnEditButtonClickMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SelectedSchemaColumnDataValueTypeUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedSchemaColumnDataValueTypeUId", SelectedSchemaColumnDataValueTypeUId, Guid.Empty);
			}
			if (!HasMapping("SamplingColumnMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SamplingColumnMetaPath", SamplingColumnMetaPath, null);
			}
			if (!HasMapping("ColumnMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnMetaPath", ColumnMetaPath, null);
			}
			if (!HasMapping("IsSelectedColumnEdit") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSelectedColumnEdit", IsSelectedColumnEdit, false);
			}
			if (ColumnExplorer != null) {
				if (ColumnExplorer.GetType().IsSerializable ||
					ColumnExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnExplorer", ColumnExplorer, null);
				}
			}
			if (!HasMapping("IsColumnExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsColumnExplorerCreated", IsColumnExplorerCreated, false);
			}
			if (!HasMapping("NewEntityCollectionParameterValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewEntityCollectionParameterValue", NewEntityCollectionParameterValue, null);
			}
			if (!HasMapping("IsEditingSamplingEntityCollection") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEditingSamplingEntityCollection", IsEditingSamplingEntityCollection, false);
			}
			if (!HasMapping("SamplingEntityCollectionSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SamplingEntityCollectionSchemaUId", SamplingEntityCollectionSchemaUId, Guid.Empty);
			}
			if (!HasMapping("EntityCollectionSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionSchemaUId", EntityCollectionSchemaUId, Guid.Empty);
			}
			if (!HasMapping("IsNewSamplingEntityCollection") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNewSamplingEntityCollection", IsNewSamplingEntityCollection, false);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("SamplingEntityCollectionDisplayValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SamplingEntityCollectionDisplayValue", SamplingEntityCollectionDisplayValue, null);
			}
			if (!HasMapping("SamplingEntityCollectionMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SamplingEntityCollectionMetaPath", SamplingEntityCollectionMetaPath, null);
			}
			if (!HasMapping("EntityCollectionDisplayValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionDisplayValue", EntityCollectionDisplayValue, null);
			}
			if (!HasMapping("EntityCollectionMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionMetaPath", EntityCollectionMetaPath, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess : IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.IntersectEntityCollectionsUserTaskParametersEditPageSchemaUserControl>
	{

		public IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IntersectEntityCollectionsUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class IntersectEntityCollectionsUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit TitleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("TitleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit EntityCollectionTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("EntityCollectionTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton EntityCollectionEditToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("EntityCollectionEditToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("FilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SamplingEntityCollectionTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SamplingEntityCollectionTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton SamplingEntityCollectionEditToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("SamplingEntityCollectionEditToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit SamplingFilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("SamplingFilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SamplingColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SamplingColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton SamplingColumnEditButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("SamplingColumnEditButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ColumnEditButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ColumnEditButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("EntityDataSource", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource SamplingEntityDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("SamplingEntityDataSource", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EntityCollectionEditToolButton.AjaxEvents.Click.Event += EntityCollectionEditToolButtonClick;
			SamplingEntityCollectionEditToolButton.AjaxEvents.Click.Event += SamplingEntityCollectionEditToolButtonClick;
			SamplingColumnEditButton.AjaxEvents.Click.Event += SamplingColumnEditButtonClick;
			ColumnEditButton.AjaxEvents.Click.Event += ColumnEditButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntityCollectionEditToolButton.AjaxEvents.Click.Event -= EntityCollectionEditToolButtonClick;
			SamplingEntityCollectionEditToolButton.AjaxEvents.Click.Event -= SamplingEntityCollectionEditToolButtonClick;
			SamplingColumnEditButton.AjaxEvents.Click.Event -= SamplingColumnEditButtonClick;
			ColumnEditButton.AjaxEvents.Click.Event -= ColumnEditButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void EntityCollectionEditToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EntityCollectionEditToolButtonClick");
		}

		public virtual void SamplingEntityCollectionEditToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SamplingEntityCollectionEditToolButtonClick");
		}

		public virtual void SamplingColumnEditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SamplingColumnEditButtonClick");
		}

		public virtual void ColumnEditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ColumnEditButtonClick");
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
			SchemaName = "IntersectEntityCollectionsUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: IntersectEntityCollectionsUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class IntersectEntityCollectionsUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public IntersectEntityCollectionsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public IntersectEntityCollectionsUserTaskParametersEditPageEventsProcessSchema(IntersectEntityCollectionsUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "IntersectEntityCollectionsUserTaskParametersEditPageEventsProcess";
			UId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6a892407-1e36-407c-aad6-fdac3ec5b6b9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EntityCollectionMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionDisplayValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cf21b9cc-b621-4c43-a8e5-0022fcfe401e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EntityCollectionDisplayValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingEntityCollectionMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b21ad13d-b478-4fa7-bd6f-a2a140f0de2f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"SamplingEntityCollectionMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingEntityCollectionDisplayValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("898b502f-b059-4c6b-ad43-4ee4cdc2a615"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"SamplingEntityCollectionDisplayValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("61d377ce-5e05-49e7-b182-f3dea7dd88db"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewSamplingEntityCollectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e59f8382-6f1f-466d-9fc8-07b3b098c7ab"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"IsNewSamplingEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("808329be-c75d-42a8-80c5-78ec7618a2db"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EntityCollectionSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingEntityCollectionSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dc53921e-fcef-4c65-833f-73b99a7d8414"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"SamplingEntityCollectionSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEditingSamplingEntityCollectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a162cb52-da6d-4c88-8bbf-32cc628bae83"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"IsEditingSamplingEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewEntityCollectionParameterValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("08ed47b0-3508-4d6a-83a8-2ee96debda76"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"NewEntityCollectionParameterValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsColumnExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("744db3b3-b12d-4013-a6c1-8ce85dc28d9c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"IsColumnExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0117e67e-5b9a-4364-8fe6-663997b017c8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ColumnExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSelectedColumnEditParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("655a98b4-6fe7-4b7e-b11e-2ae4f716cc05"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"IsSelectedColumnEdit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("11e5ccd6-0264-4dd8-a6e6-a1c73f372fa8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingColumnMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5ae25131-5f54-4eb8-b307-07d0a8e2b81d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"SamplingColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedSchemaColumnDataValueTypeUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0350a9b2-fe8a-49a9-bba3-50dd60cb48d2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"SelectedSchemaColumnDataValueTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntityCollectionMetaPathParameter());
			Parameters.Add(CreateEntityCollectionDisplayValueParameter());
			Parameters.Add(CreateSamplingEntityCollectionMetaPathParameter());
			Parameters.Add(CreateSamplingEntityCollectionDisplayValueParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateIsNewSamplingEntityCollectionParameter());
			Parameters.Add(CreateEntityCollectionSchemaUIdParameter());
			Parameters.Add(CreateSamplingEntityCollectionSchemaUIdParameter());
			Parameters.Add(CreateIsEditingSamplingEntityCollectionParameter());
			Parameters.Add(CreateNewEntityCollectionParameterValueParameter());
			Parameters.Add(CreateIsColumnExplorerCreatedParameter());
			Parameters.Add(CreateColumnExplorerParameter());
			Parameters.Add(CreateIsSelectedColumnEditParameter());
			Parameters.Add(CreateColumnMetaPathParameter());
			Parameters.Add(CreateSamplingColumnMetaPathParameter());
			Parameters.Add(CreateSelectedSchemaColumnDataValueTypeUIdParameter());
		}

		protected virtual void InitializeChangeEntityCollectionUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1dffd5d4-52fc-4791-a67d-07425dd93b43"),
				ContainerUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
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
				UId = new Guid("ef1fa890-e1d4-4cd6-9d8a-81e872022ae7"),
				ContainerUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
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
				UId = new Guid("a4a4f1a2-1d41-4735-b008-1220bb225b5c"),
				ContainerUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
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
				UId = new Guid("f8f2dde8-e158-4178-b44d-242e238b8cf5"),
				ContainerUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
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
				UId = new Guid("4f5f3986-0139-4fef-ac1c-fcf5a2278f74"),
				ContainerUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
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
				UId = new Guid("4bc3413a-7c94-4257-8c65-52a2a8351db9"),
				ContainerUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
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
				UId = new Guid("67e72c9f-bde0-40aa-824b-ee56358434dc"),
				ContainerUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
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
				UId = new Guid("f8a28288-d9b0-44e3-ac98-0b8b7457c29d"),
				ContainerUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
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
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocessoninit = CreateEventSubProcessOnInitEventSubProcess();
			FlowElements.Add(eventsubprocessoninit);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocesschangeentitycollectionyesmessage = CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeentitycollectionyesmessage);
			ProcessSchemaEventSubProcess eventsubprocesschangeentitycollectionnomessage = CreateEventSubProcessChangeEntityCollectionNoMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeentitycollectionnomessage);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaStartMessageEvent entitycollectionedittoolbuttonclickmessage = CreateEntityCollectionEditToolButtonClickMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(entitycollectionedittoolbuttonclickmessage);
			ProcessSchemaScriptTask entitycollectionedittoolbuttonclickscript = CreateEntityCollectionEditToolButtonClickScriptScriptTask();
			eventsubprocess2.FlowElements.Add(entitycollectionedittoolbuttonclickscript);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			eventsubprocessoninit.FlowElements.Add(startmessageinit);
			ProcessSchemaScriptTask childinitscript = CreateChildInitScriptScriptTask();
			eventsubprocessoninit.FlowElements.Add(childinitscript);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventinit = CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent();
			eventsubprocessoninit.FlowElements.Add(intermediatethrowmessageeventinit);
			ProcessSchemaStartMessageEvent startmessagepageloadcomplete = CreateStartMessagePageLoadCompleteStartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessagepageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventpageloadcomplete = CreateIntermediateThrowMessageEventPageLoadCompleteIntermediateThrowMessageEvent();
			eventsubprocess4.FlowElements.Add(intermediatethrowmessageeventpageloadcomplete);
			ProcessSchemaScriptTask pageloadcompletechildscript = CreatePageLoadCompleteChildScriptScriptTask();
			eventsubprocess4.FlowElements.Add(pageloadcompletechildscript);
			ProcessSchemaStartMessageEvent okbuttonclickmessage = CreateOkButtonClickMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(okbuttonclickmessage);
			ProcessSchemaScriptTask okbuttonclickchildscript = CreateOkButtonClickChildScriptScriptTask();
			eventsubprocess5.FlowElements.Add(okbuttonclickchildscript);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclickintermediatemessage = CreateOkButtonClickIntermediateMessageIntermediateThrowMessageEvent();
			eventsubprocess5.FlowElements.Add(okbuttonclickintermediatemessage);
			ProcessSchemaStartMessageEvent samplingentitycollectionedittoolbuttonclickmessage = CreateSamplingEntityCollectionEditToolButtonClickMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(samplingentitycollectionedittoolbuttonclickmessage);
			ProcessSchemaScriptTask samplingentitycollectionedittoolbuttonclickscript = CreateSamplingEntityCollectionEditToolButtonClickScriptScriptTask();
			eventsubprocess3.FlowElements.Add(samplingentitycollectionedittoolbuttonclickscript);
			ProcessSchemaStartMessageEvent changeentitycollectionyesmessagebase = CreateChangeEntityCollectionYesMessageBaseStartMessageEvent();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagebase);
			ProcessSchemaScriptTask changeentitycollectionyesmessagescript = CreateChangeEntityCollectionYesMessageScriptScriptTask();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagescript);
			ProcessSchemaStartMessageEvent changeentitycollectionnomessagebase = CreateChangeEntityCollectionNoMessageBaseStartMessageEvent();
			eventsubprocesschangeentitycollectionnomessage.FlowElements.Add(changeentitycollectionnomessagebase);
			ProcessSchemaScriptTask changeentitycollectionnomessagescript = CreateChangeEntityCollectionNoMessageScriptScriptTask();
			eventsubprocesschangeentitycollectionnomessage.FlowElements.Add(changeentitycollectionnomessagescript);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess6.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask newentitycollectionparametervaluescripttask = CreateNewEntityCollectionParameterValueScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(newentitycollectionparametervaluescripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess6.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask preparechangeentitycollectionquestionscript = CreatePrepareChangeEntityCollectionQuestionScriptScriptTask();
			eventsubprocess6.FlowElements.Add(preparechangeentitycollectionquestionscript);
			ProcessSchemaUserTask changeentitycollectionusermessage = CreateChangeEntityCollectionUserMessageUserTask();
			eventsubprocess6.FlowElements.Add(changeentitycollectionusermessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent columneditbuttonclickmessage = CreateColumnEditButtonClickMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(columneditbuttonclickmessage);
			ProcessSchemaScriptTask opencolumnexplorerscripttask = CreateOpenColumnExplorerScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(opencolumnexplorerscripttask);
			ProcessSchemaStartMessageEvent samplingcolumneditbuttonclickmessage = CreateSamplingColumnEditButtonClickMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(samplingcolumneditbuttonclickmessage);
			ProcessSchemaScriptTask opensamplingcolumnexplorerscripttask = CreateOpenSamplingColumnExplorerScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(opensamplingcolumnexplorerscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("008c3401-e4ab-437f-aaa9-72184018cc89"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5c8d21d9-3d1d-49d7-a6f1-dd73f59eba07"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("945934d2-ef54-4919-a1f9-da313a720669"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("084af5d9-fe30-428a-b34d-b339a387f1b3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8f122251-d066-4286-8a79-e41b8a624ec2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fee7aba0-7d65-4cf3-bdc3-87903ebf7358"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4d80e733-af5a-4316-920b-386012b486d7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("83ed02a1-9cc4-4fbd-bbd6-f3e4b6b1030b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(164, 428),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7e565d21-3fb5-4960-98ea-e70a33b0bc34"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("64cf90ec-6971-4c04-af3b-f42d4cc5f482"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("0e7cf0dd-194c-48be-b2be-328f697946c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(256, 430),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("64cf90ec-6971-4c04-af3b-f42d4cc5f482"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("636d8048-4027-4703-8cbe-d2a48f7b94ee"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("26b3c5c3-abda-4d1f-a66f-a7f3abdc60df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(498, 428),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("82a4a152-28b8-437f-a550-277e54186624"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4df3506f-fd28-4b75-b8b3-e220958b81a2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("8c6d2719-bb5c-4294-99e3-d477a64e52a6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(580, 428),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4df3506f-fd28-4b75-b8b3-e220958b81a2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("30f3340d-5765-4517-ba1e-47fa033630df"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("10791284-ec2f-466b-929c-8229c10a2448"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(162, 426),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c4c9ae9-f5c2-44f2-b6a6-9827d2b1d142"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e644802-cba2-4cde-b7ec-b32a549f5d3f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("70c16d6c-12ff-4dc2-9d8a-973764bc0e4f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(292, 428),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e644802-cba2-4cde-b7ec-b32a549f5d3f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("661cf85b-c18a-4400-9d3e-21009fdac1a9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("6cb2a147-fb6b-4531-badb-ddd77b9aac1f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(165, 442),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4858face-9db4-4efe-bdb1-b3a772a6cf71"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fd0261ef-12b6-476a-bf5f-07f56cb24b0f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("34618755-6410-44e0-a1ad-aad35939d327"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(445, 443),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("318b980a-6ddb-49cd-be46-ea6c99cc1f1f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("556d52d7-8420-41f9-9409-4ef9a0a7709f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("9f827cb7-e2b3-40ee-a921-e6307eee9617"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(168, 610),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4795143b-20f0-4817-9d87-9a9c5c3d4f50"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c6fe146-4fb4-44b6-a19e-777f8a5c17ed"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("c4d40395-d09a-4a67-a785-2ae065b72f1c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(318, 606),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c6fe146-4fb4-44b6-a19e-777f8a5c17ed"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c3d54868-bfa9-4cb6-ae12-d85b0077fd9b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("0e58b957-261a-40df-b5f1-f892ada3c5da"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(606, 610),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d84ac122-a854-4223-af2c-ff0b5dade848"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("4565ce1e-229b-4ee1-a585-5fd75acdbd04"),
				ConditionExpression = @"IsEditingSamplingEntityCollection ? !IsNewSamplingEntityCollection : !IsNew",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(454, 610),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3d54868-bfa9-4cb6-ae12-d85b0077fd9b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d84ac122-a854-4223-af2c-ff0b5dade848"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow14",
				UId = new Guid("e2c4d0fd-d57d-443c-86bc-9cb65c7e3a63"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(439, 690),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3d54868-bfa9-4cb6-ae12-d85b0077fd9b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f3f9c007-5b9a-4593-9004-cf673f47433a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("5446f122-0a98-4e82-9ead-4d21205a8248"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e912203e-357c-48d0-9bd5-6a9a90586dbb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dccdbb18-9356-4390-b48c-61c8c7c8ee33"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("473ae871-5a01-4d0b-9cd7-4925a0965764"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0c8da8c6-c7b3-4aaf-94d1-8a9500b0cee6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9d89b57f-1819-40fd-8d70-e252145f2bd4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("66e30422-6fac-4ef8-b020-c9414ce319c9"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1140, 1196),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a1f72800-9113-43ed-9fde-0593e4bd4e91"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("66e30422-6fac-4ef8-b020-c9414ce319c9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"Lane1",
				Position = new Point(29, 168),
				Size = new Size(1111, 645),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("5b651879-c36e-48cb-9741-0b0bad7e8f65"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("66e30422-6fac-4ef8-b020-c9414ce319c9"),
				CreatedInOwnerSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"Lane3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 1016),
				Size = new Size(1111, 180),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("8a49eaf2-361e-4f24-96e5-44222d3b2522"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("66e30422-6fac-4ef8-b020-c9414ce319c9"),
				CreatedInOwnerSchemaUId = new Guid("94ac7df3-6492-4299-bf1c-593ccb0cb56b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"Lane4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 818),
				Size = new Size(1111, 193),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("32515e73-f74d-4519-b0f9-792af6b809e8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("66e30422-6fac-4ef8-b020-c9414ce319c9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(1111, 163),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8c26b486-06c6-474e-bc58-62f53821bfd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1f72800-9113-43ed-9fde-0593e4bd4e91"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcess2",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(237, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntityCollectionEditToolButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("945934d2-ef54-4919-a1f9-da313a720669"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c26b486-06c6-474e-bc58-62f53821bfd8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntityCollectionEditToolButtonClick",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EntityCollectionEditToolButtonClickMessage",
				Position = new Point(29, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEntityCollectionEditToolButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("084af5d9-fe30-428a-b34d-b339a387f1b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c26b486-06c6-474e-bc58-62f53821bfd8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EntityCollectionEditToolButtonClickScript",
				Position = new Point(127, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,191,10,131,48,16,198,247,66,223,33,56,181,32,190,128,116,74,29,28,10,66,10,157,143,120,77,2,231,69,226,137,246,237,155,172,153,190,225,247,253,27,183,97,14,18,216,25,88,86,202,58,176,4,249,233,72,132,86,66,100,245,80,95,160,13,251,235,197,248,120,24,235,113,1,35,105,183,178,39,28,206,149,98,194,84,74,62,129,231,120,220,234,130,23,10,76,32,190,85,106,2,135,93,205,223,120,74,137,119,154,2,178,140,207,86,53,181,167,112,237,129,29,54,247,124,36,97,222,102,149,79,96,255,7,31,246,188,195,193,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessOnInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessOnInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c1e183f1-36f8-4ed3-a143-76a5d63af5f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b651879-c36e-48cb-9741-0b0bad7e8f65"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcessOnInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(318, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessOnInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7e565d21-3fb5-4960-98ea-e70a33b0bc34"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1e183f1-36f8-4ed3-a143-76a5d63af5f4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"StartMessageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("636d8048-4027-4703-8cbe-d2a48f7b94ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1e183f1-36f8-4ed3-a143-76a5d63af5f4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ChildInitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(210, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,205,110,219,48,12,62,55,64,222,65,235,201,6,12,191,64,182,1,141,227,21,57,180,40,154,180,119,206,98,50,13,178,228,81,84,27,99,216,187,143,178,51,103,65,186,98,39,139,210,247,35,82,159,205,78,101,235,80,121,27,91,87,31,58,235,9,169,34,4,70,157,171,159,243,217,213,88,156,3,178,124,49,159,253,154,207,140,144,63,212,7,46,215,225,230,59,28,30,241,71,196,192,35,239,1,8,90,100,164,21,48,60,131,141,184,237,59,124,90,107,245,73,61,5,49,241,206,97,195,198,187,242,12,113,7,14,246,72,229,45,242,154,177,93,246,247,34,147,93,215,142,13,247,114,13,59,146,206,56,215,121,41,194,139,193,117,143,229,214,176,197,90,27,46,183,120,96,241,171,45,182,232,248,30,95,43,232,18,59,65,95,128,148,198,221,32,18,4,180,194,29,68,203,199,26,130,90,153,193,9,168,255,24,152,140,219,23,234,129,124,131,33,108,154,111,216,194,212,225,64,249,156,52,87,24,204,222,221,121,141,149,133,16,164,108,200,116,236,147,211,180,76,86,83,145,124,254,69,74,138,95,140,181,226,218,33,113,159,122,222,248,72,13,102,227,167,248,75,54,255,211,83,119,129,22,199,75,137,228,252,108,136,35,216,211,102,210,184,228,151,27,228,202,26,153,224,141,76,228,5,31,253,235,144,128,171,165,113,58,205,217,83,200,228,189,142,203,180,43,211,202,242,226,141,187,20,167,153,15,18,34,93,59,248,106,81,75,32,152,252,212,108,54,60,229,49,119,34,92,168,29,216,128,249,244,202,167,163,101,100,150,24,29,117,164,219,1,249,31,234,27,104,59,43,87,125,199,229,18,242,158,91,10,39,234,49,30,35,227,141,244,223,70,163,203,186,237,184,31,255,34,66,142,228,20,83,196,197,111,66,60,123,91,143,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("64cf90ec-6971-4c04-af3b-f42d4cc5f482"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1e183f1-36f8-4ed3-a143-76a5d63af5f4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"IntermediateThrowMessageEventInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2e26c065-bed7-4874-81a7-524b935e7e38"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b651879-c36e-48cb-9741-0b0bad7e8f65"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(371, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(314, 159),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("82a4a152-28b8-437f-a550-277e54186624"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e26c065-bed7-4874-81a7-524b935e7e38"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"StartMessagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4df3506f-fd28-4b75-b8b3-e220958b81a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e26c065-bed7-4874-81a7-524b935e7e38"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"IntermediateThrowMessageEventPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("30f3340d-5765-4517-ba1e-47fa033630df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e26c065-bed7-4874-81a7-524b935e7e38"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"PageLoadCompleteChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,88,93,79,219,48,20,125,46,210,254,131,233,83,34,85,249,3,80,36,250,1,42,131,173,90,97,123,152,120,48,141,83,60,165,78,101,59,108,25,226,191,239,218,78,154,196,137,211,160,9,52,237,13,226,235,115,143,207,253,132,57,147,84,102,211,36,142,201,90,210,132,221,16,137,151,88,62,162,49,18,146,83,182,9,230,219,157,204,78,62,28,205,45,203,25,21,187,24,103,95,113,156,146,166,245,10,111,119,49,124,176,111,185,241,93,55,186,253,60,97,142,196,250,145,108,49,156,93,80,22,206,136,160,27,70,194,37,79,214,68,136,149,62,243,124,48,93,226,13,9,46,104,44,9,159,135,84,6,43,34,235,70,6,167,205,244,124,179,225,100,131,21,157,57,195,15,177,34,18,225,88,144,194,182,32,255,10,248,150,43,93,110,212,67,195,8,62,204,72,132,211,88,106,61,4,194,2,205,168,214,9,243,236,212,136,51,66,53,199,75,204,241,150,128,15,125,229,12,176,104,132,60,133,53,70,44,141,99,31,61,127,56,26,112,34,83,206,144,228,169,242,246,98,28,18,43,22,224,62,140,190,15,237,16,13,239,115,208,166,125,167,11,207,187,37,156,99,145,68,50,184,91,4,223,200,195,52,97,146,39,177,8,148,68,190,214,233,92,236,244,47,193,52,21,50,217,206,176,196,77,6,229,217,71,146,13,239,129,231,149,72,24,196,128,83,28,211,223,164,193,204,119,48,14,190,144,136,112,194,214,196,136,119,183,8,209,241,24,93,166,52,52,57,103,158,98,251,47,141,199,13,209,90,32,79,90,32,42,149,209,64,208,145,107,187,100,21,199,165,206,185,29,225,50,203,79,20,226,36,3,29,158,8,47,60,120,21,179,250,201,36,155,198,20,188,239,45,219,153,248,74,189,129,142,142,33,164,132,95,37,41,95,67,90,87,148,112,170,212,239,41,93,22,94,215,225,168,225,185,120,144,77,188,180,184,37,191,164,46,66,245,67,11,247,42,190,2,89,41,126,170,70,195,60,103,11,69,61,13,15,23,211,45,83,128,35,157,240,165,227,242,100,146,74,9,146,230,48,224,51,175,140,129,42,189,181,54,171,36,133,42,188,105,237,227,240,190,76,12,26,121,199,121,107,92,136,79,80,114,159,185,78,87,175,142,227,251,42,123,7,83,27,188,110,165,0,243,248,152,144,229,25,185,42,26,237,157,32,28,158,205,242,164,168,154,222,96,6,175,228,1,196,111,193,132,196,144,246,147,12,66,222,8,216,62,25,180,52,3,67,62,239,229,134,95,173,26,140,185,130,93,89,38,147,108,159,174,214,99,53,176,37,122,17,223,46,212,11,208,111,138,119,138,229,68,87,144,103,211,210,208,208,193,10,218,145,110,226,34,15,83,89,14,166,185,139,122,164,144,35,84,57,136,111,90,140,206,130,31,208,197,64,104,40,81,56,1,116,70,126,162,6,250,85,213,200,171,199,6,102,129,53,203,202,235,70,31,229,198,120,174,245,121,221,63,97,152,238,59,104,206,14,210,57,219,145,36,242,108,26,149,222,58,66,10,120,160,200,94,83,33,79,107,4,207,208,179,245,172,23,95,143,49,39,222,201,64,193,41,221,26,60,143,171,243,101,224,104,73,211,148,67,251,149,43,40,175,53,76,160,66,13,17,156,135,97,3,210,136,242,146,135,119,193,168,52,239,47,21,244,90,189,52,132,238,232,145,215,9,14,247,108,244,110,242,130,8,140,121,253,10,200,9,208,109,108,77,98,225,216,142,242,140,115,45,79,251,201,236,190,255,70,19,218,197,232,224,164,118,49,245,15,188,164,231,228,118,241,170,206,173,87,184,56,233,128,172,238,186,46,196,114,158,244,91,127,123,78,120,149,195,253,167,124,55,187,202,180,175,147,116,76,253,131,10,191,238,185,157,91,64,31,152,145,147,81,115,43,112,89,218,219,65,31,191,61,182,132,2,198,189,45,52,45,94,191,53,212,49,254,126,123,104,199,123,159,45,226,96,114,189,199,54,209,12,202,123,108,21,133,215,127,111,187,104,249,83,246,191,223,50,156,173,240,77,182,13,151,55,103,0,122,244,236,195,91,136,171,216,106,219,137,189,95,150,141,201,61,98,107,115,185,227,31,34,37,214,225,177,109,99,86,119,153,63,90,158,23,97,230,18,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d4baa63c-9a25-4abf-acfa-90871ac9c454"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a49eaf2-361e-4f24-96e5-44222d3b2522"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 172),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5c4c9ae9-f5c2-44f2-b6a6-9827d2b1d142"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4baa63c-9a25-4abf-acfa-90871ac9c454"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"OkButtonClickMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 73),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9e644802-cba2-4cde-b7ec-b32a549f5d3f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4baa63c-9a25-4abf-acfa-90871ac9c454"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"OkButtonClickChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,193,110,194,48,12,61,15,137,127,136,56,181,18,234,7,108,99,59,64,39,113,128,33,202,184,76,59,68,173,129,72,105,90,37,46,12,77,251,247,37,77,11,106,75,129,161,73,59,198,121,246,123,126,142,227,115,136,65,224,20,118,67,154,34,75,4,25,144,25,93,131,183,96,200,193,143,24,122,11,248,196,135,110,103,75,37,17,137,128,101,96,32,50,9,65,169,32,220,64,76,103,84,210,24,16,228,146,242,12,130,36,147,33,120,83,13,45,178,194,68,40,188,50,109,152,99,77,160,72,78,75,148,202,163,185,188,106,132,42,50,98,161,209,78,229,254,81,161,100,98,221,63,71,245,164,75,179,21,113,26,165,7,68,100,156,187,228,171,219,185,171,179,12,78,224,137,128,221,111,185,29,215,213,244,223,221,78,64,183,224,11,100,184,31,38,156,67,94,164,138,173,19,246,73,175,158,208,235,147,122,104,2,168,57,113,211,188,177,122,222,198,145,81,112,19,125,64,227,148,235,22,155,50,180,99,109,151,71,65,109,136,138,176,26,235,123,111,14,42,227,216,160,252,40,252,63,99,182,99,71,57,73,34,182,98,16,141,143,68,58,215,188,237,195,217,232,159,195,10,36,136,16,42,168,54,169,122,134,133,139,35,138,212,190,222,23,198,141,238,139,54,54,50,244,24,243,165,179,71,163,204,189,185,120,105,114,43,73,9,168,146,53,108,215,61,103,241,97,120,127,111,183,213,166,111,236,214,120,99,53,213,203,247,42,253,56,197,189,83,101,119,201,115,249,247,220,151,223,137,169,81,238,97,21,109,71,211,104,168,236,251,127,27,59,173,226,82,131,167,179,108,163,18,48,147,130,160,212,127,230,15,129,233,215,76,207,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOkButtonClickIntermediateMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("661cf85b-c18a-4400-9d3e-21009fdac1a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4baa63c-9a25-4abf-acfa-90871ac9c454"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"OkButtonClickIntermediateMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 73),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("632fbec6-7290-4d7a-a31c-9852251e2092"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1f72800-9113-43ed-9fde-0593e4bd4e91"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcess3",
				Position = new Point(308, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(251, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSamplingEntityCollectionEditToolButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fee7aba0-7d65-4cf3-bdc3-87903ebf7358"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("632fbec6-7290-4d7a-a31c-9852251e2092"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SamplingEntityCollectionEditToolButtonClick",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"SamplingEntityCollectionEditToolButtonClickMessage",
				Position = new Point(29, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSamplingEntityCollectionEditToolButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4d80e733-af5a-4316-920b-386012b486d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("632fbec6-7290-4d7a-a31c-9852251e2092"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"SamplingEntityCollectionEditToolButtonClickScript",
				Position = new Point(141, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,193,10,194,48,16,68,239,130,255,16,122,82,40,253,1,241,20,115,232,65,40,68,240,188,164,75,178,144,110,74,186,165,245,239,77,240,38,244,52,48,51,60,94,191,152,145,132,216,91,152,230,88,210,176,144,124,116,138,17,157,80,98,117,87,146,87,188,157,79,54,164,205,186,128,19,216,210,56,89,51,154,125,142,41,99,174,140,55,241,152,182,203,17,231,137,2,3,72,104,149,26,192,99,119,244,123,225,46,21,215,233,72,200,210,63,90,213,252,127,234,174,3,176,199,230,90,196,50,22,23,254,105,126,1,87,150,47,219,208,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeEntityCollectionYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c02c1ff2-ab66-4345-aede-4bc65d6262ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1f72800-9113-43ed-9fde-0593e4bd4e91"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcessChangeEntityCollectionYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 182),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 161),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeEntityCollectionYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionYesMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4858face-9db4-4efe-bdb1-b3a772a6cf71"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c02c1ff2-ab66-4345-aede-4bc65d6262ef"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ChangeEntityCollectionYesMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 76),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionYesMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fd0261ef-12b6-476a-bf5f-07f56cb24b0f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c02c1ff2-ab66-4345-aede-4bc65d6262ef"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ChangeEntityCollectionYesMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,204,75,79,117,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,211,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,182,115,214,243,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeEntityCollectionNoMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeEntityCollectionNoMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bd4fab16-5283-45a0-aa5b-711cdd8f5b1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1f72800-9113-43ed-9fde-0593e4bd4e91"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcessChangeEntityCollectionNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 182),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 162),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeEntityCollectionNoMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionNoMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("318b980a-6ddb-49cd-be46-ea6c99cc1f1f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bd4fab16-5283-45a0-aa5b-711cdd8f5b1c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionNoMessage",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ChangeEntityCollectionNoMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionNoMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("556d52d7-8420-41f9-9409-4ef9a0a7709f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bd4fab16-5283-45a0-aa5b-711cdd8f5b1c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ChangeEntityCollectionNoMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,240,44,118,77,201,44,201,204,75,15,78,204,45,200,1,210,174,121,37,153,37,149,206,249,57,57,169,201,37,153,249,121,154,10,213,188,92,156,1,137,233,169,122,184,148,132,164,86,148,128,76,209,3,49,20,108,21,112,169,115,201,44,46,200,73,172,12,75,204,41,77,181,230,229,170,85,72,205,41,78,69,24,79,200,88,66,198,241,114,21,165,150,148,22,229,41,148,20,1,5,0,98,218,111,5,220,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fcc6e2c0-ed32-420e-8321-2669017bd61b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1f72800-9113-43ed-9fde-0593e4bd4e91"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 357),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(674, 274),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4795143b-20f0-4817-9d87-9a9c5c3d4f50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fcc6e2c0-ed32-420e-8321-2669017bd61b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EntityCollectionEditChange",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateNewEntityCollectionParameterValueScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5c6fe146-4fb4-44b6-a19e-777f8a5c17ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fcc6e2c0-ed32-420e-8321-2669017bd61b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"NewEntityCollectionParameterValueScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,45,119,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,11,72,44,74,204,77,45,73,45,10,75,204,41,77,85,176,85,240,42,206,207,211,11,78,45,202,76,204,201,172,74,213,72,206,207,43,73,173,40,209,11,201,40,202,47,119,45,75,205,43,113,44,74,47,214,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,207,202,118,138,89,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("c3d54868-bfa9-4cb6-ae12-d85b0077fd9b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fcc6e2c0-ed32-420e-8321-2669017bd61b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareChangeEntityCollectionQuestionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d84ac122-a854-4223-af2c-ff0b5dade848"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fcc6e2c0-ed32-420e-8321-2669017bd61b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"PrepareChangeEntityCollectionQuestionScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(428, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,177,14,130,48,16,134,103,73,120,135,166,51,241,5,80,7,145,129,65,80,129,129,145,144,11,52,193,171,105,143,40,33,188,187,5,58,56,104,100,185,63,151,126,223,127,13,154,18,107,8,145,4,245,129,108,91,168,72,72,204,53,168,51,104,93,214,176,189,152,193,246,108,10,223,117,130,191,188,205,12,94,100,180,133,79,171,6,238,229,98,217,247,85,93,81,37,209,148,240,107,30,166,89,148,196,124,149,117,236,136,36,234,73,44,194,52,78,214,89,55,208,15,99,129,221,39,29,225,201,78,98,38,75,213,239,52,41,129,181,199,150,60,176,193,117,54,3,239,65,115,143,241,239,7,10,208,182,143,143,222,140,163,252,77,199,242,19,30,205,183,21,80,167,144,145,234,192,127,3,172,124,101,110,171,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeEntityCollectionUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("960dd96b-2b37-47ea-a1d2-c328f0313b17"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fcc6e2c0-ed32-420e-8321-2669017bd61b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ChangeEntityCollectionUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(561, 55),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeEntityCollectionUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f3f9c007-5b9a-4593-9004-cf673f47433a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fcc6e2c0-ed32-420e-8321-2669017bd61b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(428, 202),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5b234e7d-ea7d-41a1-bc73-72f729ded483"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32515e73-f74d-4519-b0f9-792af6b809e8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcess7",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(230, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnEditButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e912203e-357c-48d0-9bd5-6a9a90586dbb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b234e7d-ea7d-41a1-bc73-72f729ded483"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ColumnEditButtonClick",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"ColumnEditButtonClickMessage",
				Position = new Point(29, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOpenColumnExplorerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dccdbb18-9356-4390-b48c-61c8c7c8ee33"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b234e7d-ea7d-41a1-bc73-72f729ded483"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"OpenColumnExplorerScriptTask",
				Position = new Point(120, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,14,78,205,73,77,46,73,77,113,206,207,41,205,205,115,77,201,44,81,176,85,40,41,42,77,181,230,229,242,47,72,205,131,138,87,20,228,228,23,165,22,105,184,230,149,100,150,84,2,5,65,186,50,243,243,130,147,51,82,115,19,67,61,83,116,20,32,42,125,83,75,18,3,18,75,50,52,129,250,139,82,75,74,139,242,32,166,1,0,212,14,38,162,106,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("86e30d00-395c-4e9e-a1a1-a4710e3ee0ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32515e73-f74d-4519-b0f9-792af6b809e8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"EventSubProcess8",
				Position = new Point(273, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(214, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSamplingColumnEditButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0c8da8c6-c7b3-4aaf-94d1-8a9500b0cee6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("86e30d00-395c-4e9e-a1a1-a4710e3ee0ce"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SamplingColumnEditButtonClick",
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"SamplingColumnEditButtonClickMessage",
				Position = new Point(36, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOpenSamplingColumnExplorerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9d89b57f-1819-40fd-8d70-e252145f2bd4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("86e30d00-395c-4e9e-a1a1-a4710e3ee0ce"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Name = @"OpenSamplingColumnExplorerScriptTask",
				Position = new Point(127, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,14,78,205,73,77,46,73,77,113,206,207,41,205,205,115,77,201,44,81,176,85,72,75,204,41,78,181,230,229,242,47,72,205,131,74,84,20,228,228,23,165,22,105,4,39,230,22,228,100,230,165,187,230,149,100,150,84,2,37,65,218,51,243,243,130,147,51,82,115,19,67,61,83,116,20,96,74,32,58,125,83,75,18,3,18,75,50,52,129,230,21,165,150,148,22,229,41,148,20,149,166,90,3,0,90,105,93,229,123,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetPropertyDisplayPathByServerMetaPathMethod());
			Methods.Add(CreateGetPropertyServerMetaPathByClientMetaPathMethod());
			Methods.Add(CreateShowSchemaStructureExplorerEditWindowMethod());
			Methods.Add(CreateChangeEntityCollectionMethod());
			Methods.Add(CreateInitializeFilterEditMethod());
			Methods.Add(CreateCreateColumnExplorerMethod());
			Methods.Add(CreateOpenColumnExplorerMethod());
			Methods.Add(CreateColumnExplorer_EditCompleteMethod());
			Methods.Add(CreateSetEnabledControlPropertyMethod());
			Methods.Add(CreateSpecifySchemaColumnDataValueTypeUIdMethod());
			Methods.Add(CreateResetDataSourceFiltersMethod());
			Methods.Add(CreateSaveEntityCollectionParameterValueMethod());
			Methods.Add(CreateSaveDataSourceFiltersParameterValueMethod());
			Methods.Add(CreateGetEntityCollectionDisplayValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e10af37e-8a23-45ae-a3cb-87a783a57a66"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = base.CreateInitializeSchemaExplorerWindowMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,223,78,194,48,20,198,175,217,83,212,93,109,9,233,11,16,46,20,9,89,130,196,8,120,95,215,195,92,236,218,165,127,196,197,240,238,158,178,129,14,10,70,111,40,105,207,249,206,239,251,118,94,148,18,164,52,11,216,46,243,87,168,216,244,163,22,74,131,38,99,114,122,49,38,210,9,49,138,202,13,73,2,29,41,249,140,6,103,34,18,182,157,208,210,106,151,91,167,225,240,154,60,178,2,232,74,213,19,37,173,86,98,206,26,229,236,144,196,166,95,31,15,201,134,9,3,221,145,142,162,93,244,206,52,49,191,0,51,115,105,242,117,15,125,93,250,192,36,114,234,5,171,0,103,76,121,105,219,158,31,247,72,68,0,209,2,221,153,204,133,227,192,239,153,101,207,76,56,88,53,53,24,58,17,192,116,178,183,114,218,80,72,60,121,199,37,160,2,105,215,25,239,70,127,95,140,206,26,195,147,110,57,199,160,53,82,90,208,189,55,20,25,146,153,43,57,197,28,252,153,164,8,228,255,144,2,127,78,107,145,96,109,64,227,199,146,144,219,82,73,218,171,232,226,160,51,176,153,133,234,174,241,193,36,177,151,139,83,186,7,246,161,103,230,8,51,87,234,205,213,161,200,175,88,9,145,117,46,166,85,109,155,125,164,126,208,69,207,126,145,67,42,127,4,249,71,22,173,225,54,141,51,230,254,34,78,52,48,11,62,115,220,93,104,163,187,233,151,60,65,81,26,244,7,65,242,195,171,223,177,193,165,198,163,252,238,11,38,98,252,216,7,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyDisplayPathByServerMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d593d0c3-1522-42d5-a267-7d7d6fc471dd"),
				Name = "GetPropertyDisplayPathByServerMetaPath",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f3152c7a-7402-45d9-8e22-30095a61d440"),
				Name = "serverMetaPath",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,10,194,48,16,68,239,126,69,142,41,132,254,128,120,81,177,167,74,64,252,128,37,29,218,30,186,41,155,109,165,127,111,60,20,13,222,118,152,153,125,227,37,6,164,244,8,3,38,50,115,161,78,230,54,114,119,69,26,123,70,231,127,61,91,29,15,43,137,233,193,16,210,40,57,204,120,153,34,212,236,166,125,38,200,37,50,35,232,24,217,149,156,186,40,181,196,212,67,234,59,77,72,51,5,100,146,64,23,225,47,172,110,160,185,52,67,116,243,164,195,121,107,161,244,185,236,223,8,79,146,63,41,196,22,208,202,153,188,105,133,236,77,103,84,150,12,123,3,108,176,144,21,17,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyServerMetaPathByClientMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b51b298d-4341-4baa-854d-e2bb3fa82169"),
				Name = "GetPropertyServerMetaPathByClientMetaPath",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6f9fa105-792f-42fe-ac53-ff4e0d739269"),
				Name = "clientMetaPath",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,59,10,195,48,16,68,251,156,66,165,12,70,23,48,174,18,226,202,65,16,114,128,69,30,100,65,188,50,171,117,114,125,187,201,71,229,240,102,230,121,201,1,165,220,195,140,133,204,90,165,222,92,19,79,23,148,20,25,147,255,103,182,233,78,47,18,19,193,16,210,44,71,153,241,54,85,105,248,64,251,40,144,115,102,70,208,148,185,173,61,174,26,141,196,20,33,238,70,11,202,74,1,135,73,160,155,240,79,230,6,232,8,37,79,58,219,234,171,53,225,153,192,95,218,116,59,151,52,170,164,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowSchemaStructureExplorerEditWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4ecb6c28-cec0-44bd-adf9-2a7f81a6e79f"),
				Name = "ShowSchemaStructureExplorerEditWindow",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c675e5bd-d384-4490-96b2-757aec0f9e01"),
				Name = "entityCollectionMetaPath",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a8d9b52b-7b12-4b18-9942-7d68138f8ea9"),
				Name = "textEditClientID",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("74fd0127-4543-45c8-9e47-43459840f7f9"),
				Name = "textEditEventName",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,143,218,48,16,189,243,43,172,92,8,18,242,182,189,162,74,165,192,86,84,90,138,26,186,123,40,85,101,226,129,184,50,118,100,79,54,80,196,127,223,113,8,31,129,174,42,85,189,96,49,227,153,121,239,205,139,199,70,161,18,90,253,134,36,205,96,45,70,155,92,91,7,238,73,25,105,203,184,211,107,61,11,199,124,35,199,222,179,230,101,38,124,29,73,208,21,41,22,14,142,169,94,235,238,46,201,108,201,114,225,196,26,16,156,103,214,232,45,43,51,112,192,190,194,146,14,147,214,211,191,141,37,51,22,25,172,115,220,182,154,83,249,216,164,186,144,32,135,2,197,163,208,5,204,182,57,248,239,211,99,227,70,156,58,253,32,156,159,10,37,249,4,202,112,30,201,228,206,166,224,253,97,34,221,185,39,170,67,240,106,101,64,78,47,115,161,192,163,83,102,197,50,97,164,174,152,31,2,124,20,16,94,167,79,108,38,132,232,124,247,222,186,181,192,56,42,43,77,249,238,205,254,231,72,42,28,216,117,174,9,248,137,64,212,189,18,154,15,180,2,131,227,225,25,121,14,14,183,129,105,98,11,151,134,33,211,219,32,173,227,81,57,44,132,62,7,235,69,46,168,194,64,201,146,10,218,199,66,105,9,174,34,186,224,253,60,7,35,227,104,89,152,20,149,53,113,106,117,177,54,99,179,180,29,182,155,155,168,121,45,244,83,148,163,142,163,13,242,2,149,230,159,147,47,19,46,33,181,18,46,171,123,141,210,163,30,36,4,247,128,213,206,226,208,137,167,34,15,131,233,126,151,33,108,176,146,233,172,193,77,135,90,209,25,56,39,188,93,34,239,255,18,155,7,192,204,74,207,103,153,179,229,161,122,244,76,63,79,10,179,147,214,62,110,211,248,118,151,181,119,111,195,209,0,219,101,99,227,81,208,34,201,70,103,36,85,151,176,218,166,14,251,64,238,194,32,11,62,179,7,121,227,102,162,225,134,15,129,62,69,105,60,205,251,147,129,78,81,234,50,21,43,224,73,234,84,142,15,194,208,31,199,251,82,30,2,241,149,205,212,146,197,187,119,123,90,217,142,5,137,11,19,207,35,26,51,143,186,33,220,99,251,253,235,78,235,178,8,136,106,90,123,243,21,104,157,191,65,250,55,228,1,173,189,66,251,63,160,94,53,168,113,212,31,105,227,57,56,230,120,72,222,20,134,135,44,24,161,126,28,155,149,149,85,8,152,194,237,192,106,13,213,39,68,94,20,83,129,89,167,247,2,232,8,2,233,105,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateChangeEntityCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("93ea0e6f-3a4b-447c-91c4-72c3186585bd"),
				Name = "ChangeEntityCollection",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,203,110,219,48,16,60,219,95,193,228,36,3,130,252,1,121,28,26,187,129,139,182,48,234,180,151,160,7,70,90,39,44,40,81,32,169,166,106,225,127,239,82,138,35,74,178,72,217,72,111,61,89,48,103,119,150,203,153,249,73,37,129,76,51,93,222,8,206,33,214,76,100,27,48,31,144,172,169,164,41,104,144,223,40,47,64,145,43,242,65,137,44,90,128,2,201,40,103,191,225,114,193,170,10,42,203,75,165,37,203,30,67,34,30,126,96,245,245,117,240,25,158,151,157,206,237,142,179,139,233,109,193,146,62,127,252,4,41,253,186,74,144,49,131,103,98,64,193,200,33,239,207,37,108,65,66,22,195,107,155,243,239,209,157,216,84,227,5,51,36,173,39,237,209,126,2,77,215,84,63,33,235,104,178,244,165,166,69,49,200,176,96,42,231,180,172,138,143,97,137,105,110,206,59,36,158,238,183,160,187,235,183,17,189,133,218,135,225,224,114,144,151,109,131,149,90,38,76,227,28,27,154,230,28,127,187,76,51,242,103,58,97,91,18,156,173,20,234,192,9,155,172,233,35,68,248,103,145,102,166,109,116,7,191,52,94,160,94,98,180,76,115,93,94,236,97,251,78,126,120,141,176,30,181,11,104,183,114,1,205,38,233,3,135,228,70,100,90,10,190,150,34,7,169,203,160,51,121,72,182,148,43,163,235,222,165,222,21,90,163,119,94,250,32,73,133,52,192,47,104,39,189,160,154,110,68,33,99,120,207,56,190,188,10,90,183,173,247,214,128,12,195,110,58,113,238,214,226,24,130,216,70,27,52,161,163,222,225,152,253,145,163,218,227,6,251,24,187,28,216,71,131,53,18,176,181,112,124,175,102,183,209,216,173,172,50,180,64,21,131,245,155,153,1,220,207,22,146,214,113,83,54,243,14,245,81,208,4,173,95,196,186,144,96,220,239,83,101,223,40,33,193,122,232,81,57,52,106,240,93,120,51,180,5,244,11,236,236,170,138,241,87,83,205,231,167,207,191,35,128,186,110,39,204,255,36,241,118,119,41,226,88,73,56,83,203,149,86,214,188,167,166,209,105,41,244,6,233,243,22,169,243,15,210,102,32,101,14,164,203,136,84,241,250,242,144,122,230,115,159,70,237,36,57,152,32,163,147,99,247,23,73,57,237,17,178,10,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ad61046f-9e00-4a32-a939-7e1f48907e80"),
				Name = "InitializeFilterEdit",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("793a44ea-5b8b-4164-a0f3-3e24704a456d"),
				Name = "dataSource",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityDataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9d499df0-a3c3-4b35-8442-4cccc98a98d8"),
				Name = "filterEdit",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "FilterEdit",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,77,110,131,48,16,133,215,65,226,14,86,86,176,33,7,64,89,36,17,84,93,164,11,56,193,20,15,100,36,99,71,227,113,212,31,245,238,5,164,38,52,68,217,218,223,123,223,155,11,176,106,201,8,114,161,73,94,216,133,179,218,42,13,2,181,11,220,96,86,146,213,229,4,248,233,119,255,249,6,61,38,235,242,26,90,167,121,28,81,171,146,69,207,86,217,96,76,170,190,227,104,245,84,114,96,4,193,185,102,33,88,205,241,192,140,86,106,225,208,72,224,113,228,148,204,118,90,223,175,24,179,63,113,116,123,205,118,93,199,216,129,144,179,133,133,119,131,195,150,22,140,199,252,31,246,234,15,206,132,222,250,226,227,108,28,35,87,206,201,209,233,17,31,196,11,186,162,238,36,3,203,232,253,80,93,55,39,236,225,58,241,65,201,159,115,179,153,245,84,72,150,132,192,208,23,38,183,147,211,252,23,169,205,212,121,169,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("accf2df5-edfa-47a3-baeb-6ca165e6d360"),
				Name = "CreateColumnExplorer",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "StructureExplorer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,193,106,195,48,12,134,207,245,83,104,57,37,44,248,5,66,15,197,228,16,216,160,116,219,121,152,90,41,41,142,29,100,185,205,24,123,247,57,99,43,115,96,176,139,65,210,175,79,250,229,139,38,56,122,27,71,215,206,147,245,132,4,91,112,120,133,39,166,120,228,72,248,147,47,197,102,175,79,40,159,253,164,188,99,242,246,65,191,249,200,53,20,42,3,20,53,244,218,6,172,33,33,210,235,162,181,85,35,68,62,70,238,206,122,110,47,232,56,200,214,12,172,252,56,89,100,148,95,57,184,223,66,78,125,253,45,106,254,13,155,153,244,94,147,30,83,68,65,238,140,73,62,22,127,47,221,183,139,32,111,245,178,24,24,199,208,185,222,39,19,89,112,211,60,122,131,242,160,175,85,178,52,244,80,222,117,33,95,84,17,106,70,83,193,187,216,172,182,60,224,105,8,203,156,212,251,33,212,250,236,185,186,17,127,144,147,114,57,108,35,8,211,255,184,117,219,39,82,197,197,86,210,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOpenColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("359da85a-37cc-4d34-a10e-7440cfb0873e"),
				Name = "OpenColumnExplorer",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0a061ea6-6b35-4d96-ad13-a35567ebde10"),
				Name = "entitySchemaUId",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("65b2d523-8f63-4b3b-857b-35cd3b28b870"),
				Name = "columnMetaPath",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,203,10,194,48,16,69,215,246,43,198,141,164,69,234,7,136,11,169,34,93,8,66,124,172,67,102,164,129,244,65,58,65,139,248,239,86,171,96,139,11,151,153,220,123,230,140,100,231,53,123,71,235,107,101,75,71,14,116,105,125,94,124,158,243,192,156,65,164,117,210,155,38,142,20,19,134,112,11,70,253,60,44,64,200,33,51,76,6,204,59,144,173,233,103,187,67,247,11,34,108,43,193,44,106,93,196,56,173,37,89,210,237,250,119,8,13,195,100,2,159,169,212,25,229,170,251,91,41,86,71,101,61,237,155,138,14,41,194,120,1,27,111,48,94,231,21,55,63,244,227,180,208,214,35,97,175,89,199,137,37,245,210,248,51,191,68,20,255,8,77,191,117,158,71,70,179,96,176,65,102,229,229,121,227,201,20,88,94,4,21,108,184,233,152,47,64,23,223,18,171,157,226,44,156,63,0,72,81,248,222,210,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateColumnExplorer_EditCompleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5a138e97-622c-490e-a447-fe6f7965a5c0"),
				Name = "ColumnExplorer_EditComplete",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ac4a999b-5059-43c8-9ddd-2c7a8705bcbb"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ac43b7c6-185e-41ec-a2f1-c86bc5debc52"),
				Name = "e",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,205,78,131,64,16,62,195,83,172,156,32,49,244,1,106,61,72,137,161,137,177,9,213,139,241,48,192,208,174,217,31,178,59,152,162,241,221,93,10,109,99,109,245,184,51,223,239,100,223,193,176,82,139,86,42,54,99,225,226,177,120,195,146,162,133,213,42,158,163,69,195,65,240,15,12,49,78,183,100,96,9,6,36,18,26,251,18,112,66,105,51,85,235,224,53,154,250,150,12,87,235,81,42,129,134,184,238,21,135,119,252,12,162,197,155,1,115,27,6,229,176,15,78,121,15,72,206,130,54,23,137,114,4,244,76,94,135,153,205,81,184,188,88,37,59,120,90,113,138,62,125,111,9,107,140,143,163,120,133,91,58,104,142,225,166,190,151,156,55,221,15,166,254,23,67,97,145,237,21,115,144,141,112,65,254,87,254,137,252,195,225,82,212,161,113,156,202,134,186,115,73,79,246,147,73,222,96,201,235,46,47,55,40,97,128,207,129,96,119,191,85,215,224,83,86,133,53,184,54,238,114,94,161,181,96,220,166,10,10,129,149,147,75,21,113,234,28,173,191,166,171,48,200,56,14,187,154,177,251,150,87,7,167,28,105,164,37,90,145,209,98,105,116,131,134,186,240,164,201,245,209,32,250,221,243,174,37,114,95,236,152,224,0,118,87,255,6,201,13,181,165,148,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEnabledControlPropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f3c7a1bc-0091-41af-8689-5b996e03bcb3"),
				Name = "SetEnabledControlProperty",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("478d57f3-c3ed-4a50-b085-b884a757a463"),
				Name = "textEdit",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "TextEdit",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("472155c5-9511-483e-841f-4f114f7fdbd4"),
				Name = "isEnabled",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,73,173,40,113,77,201,44,209,115,205,75,76,202,73,77,81,176,85,200,44,134,178,173,185,74,96,178,193,169,37,65,169,133,165,153,69,169,41,26,112,121,77,107,0,43,239,15,219,62,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSpecifySchemaColumnDataValueTypeUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("98e4af0b-a9b9-4f93-99e5-0a78dd0ee8fe"),
				Name = "SpecifySchemaColumnDataValueTypeUId",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c5a971c0-9121-42e8-8144-102d26862378"),
				Name = "isSpecifiedSamplingColumn",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,144,193,10,131,48,12,134,207,246,41,122,212,139,47,32,94,116,50,60,12,6,206,221,67,141,90,168,81,108,61,200,216,187,175,174,8,138,222,182,83,224,79,242,229,35,25,25,105,230,66,180,216,193,13,8,26,28,57,158,100,49,47,53,142,105,79,132,194,200,158,194,236,56,20,177,109,152,246,106,234,136,139,111,137,152,172,185,47,117,49,160,144,181,196,170,128,110,80,146,26,55,21,240,23,243,182,203,92,187,18,159,201,132,87,52,57,105,3,36,48,153,203,188,242,87,154,67,88,166,114,150,110,205,78,4,17,243,156,137,69,58,246,66,217,154,38,243,13,13,220,193,180,254,94,110,141,45,227,205,81,105,252,81,246,79,146,71,57,86,224,130,180,207,221,108,92,192,192,19,212,132,143,121,64,123,196,162,221,141,112,215,9,109,43,250,0,32,78,187,227,13,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetDataSourceFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("795ac29e-ab7f-4dcd-9da4-8fa9115f0e32"),
				Name = "ResetDataSourceFilters",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("37b2347e-5791-4053-a33b-4bcd923c1fcb"),
				Name = "dataSource",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityDataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,203,204,41,73,45,114,77,201,44,113,47,202,47,45,80,176,85,72,73,44,73,12,206,47,45,74,78,213,115,203,204,75,113,3,43,40,6,203,58,85,250,37,230,166,106,40,185,193,53,41,105,90,115,101,166,41,104,160,27,163,104,171,144,87,154,147,163,169,80,205,197,137,38,167,231,156,147,154,88,164,1,212,88,11,0,173,34,162,52,129,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveEntityCollectionParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a96b260b-f235-4f65-861f-8cb17ad0e5df"),
				Name = "SaveEntityCollectionParameterValue",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f46b9828-05f1-4dec-b756-1ffbff567802"),
				Name = "parametersValue",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("07a64836-ed13-416c-a898-0cfc53379cd3"),
				Name = "parameterName",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("37eb1c9e-3309-4669-b2e7-082925e75e2e"),
				Name = "parameterMetaPath",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("51c22d1a-f240-4d4f-8b85-ffdc65e74552"),
				Name = "entitySchemaUId",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,205,78,131,64,16,62,219,164,239,176,233,9,98,178,15,96,173,198,208,30,208,128,68,90,61,152,30,86,24,218,77,150,29,50,59,152,224,211,75,33,165,85,137,122,217,205,204,126,243,253,204,190,43,18,96,89,115,19,160,49,144,177,70,43,22,211,201,197,189,67,43,151,224,128,180,50,250,3,174,19,194,12,156,75,179,61,148,42,81,164,74,96,160,103,101,106,184,241,60,111,13,68,202,97,193,114,19,202,23,120,11,208,50,161,113,50,81,59,240,15,135,188,115,85,87,180,236,50,168,29,99,185,84,172,94,171,35,87,220,94,226,82,204,78,111,15,208,204,182,114,141,41,147,182,59,207,247,231,211,201,119,183,50,2,110,253,240,94,44,196,64,117,236,141,225,59,203,255,5,71,152,235,66,67,30,218,62,248,38,204,219,209,85,174,121,168,199,198,82,172,41,59,136,184,206,185,12,93,92,27,243,72,171,178,226,198,251,161,236,139,219,118,41,191,108,184,231,147,49,90,16,87,226,111,96,164,170,170,213,29,179,246,4,5,16,216,12,206,3,245,168,243,72,131,71,215,241,126,253,165,237,48,114,34,158,127,2,202,204,245,162,75,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveDataSourceFiltersParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bf6e5705-5287-447e-8460-575f8528e8e5"),
				Name = "SaveDataSourceFiltersParameterValue",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b5e88091-10ea-4d5e-84b3-359ee9c5d9f0"),
				Name = "parametersValue",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("24c8f141-0c14-49c5-b320-76f27adf7b4b"),
				Name = "parameterName",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3357a808-f1b1-40d0-b6e8-5323cd17e87f"),
				Name = "filterEdit",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "FilterEdit",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,95,75,195,48,20,197,159,215,79,17,246,212,65,41,62,91,68,176,174,50,193,49,40,219,139,248,16,219,59,141,164,185,37,73,43,211,249,221,189,105,179,110,245,31,62,133,220,123,238,47,231,158,180,92,179,173,144,22,116,138,82,66,97,5,42,118,225,75,243,82,216,248,154,91,158,99,163,11,136,51,161,202,172,235,152,27,141,77,125,181,91,242,10,194,105,54,168,167,179,36,104,9,249,98,80,165,168,90,208,212,32,158,130,87,118,4,121,198,237,169,40,92,27,231,65,169,222,67,244,179,5,143,39,169,224,82,188,129,183,51,242,238,176,113,126,80,132,95,183,139,198,230,136,248,136,40,153,48,75,84,176,201,135,229,79,153,180,64,35,37,219,239,191,245,226,20,27,101,157,226,44,9,106,174,41,15,183,218,134,203,6,238,135,187,139,233,193,199,176,210,88,128,49,121,241,12,21,95,29,20,221,64,56,99,239,193,228,14,75,177,21,80,46,84,175,89,47,74,26,117,65,12,247,40,152,244,121,80,99,48,126,249,23,218,255,160,147,178,243,127,8,41,31,99,187,2,189,213,157,227,167,140,213,66,61,197,243,170,182,59,2,254,254,33,193,71,242,9,68,185,88,7,100,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityCollectionDisplayValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a0d49946-6a9b-48c2-b1bc-6aa862ccee07"),
				Name = "GetEntityCollectionDisplayValue",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("826a3c7e-8435-4484-8ccf-d9a2b412ad31"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ae24819e-d61d-4cb1-9a83-13542ce7e88f"),
				Name = "metaPath",
				CreatedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				ModifiedInSchemaUId = new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,140,177,10,195,32,20,0,231,248,21,142,186,228,7,164,75,104,26,178,164,129,210,238,143,248,154,8,106,197,247,164,72,233,191,183,99,50,30,220,157,123,74,69,156,93,92,219,145,166,226,253,53,247,33,113,85,214,81,242,80,31,224,11,106,45,63,162,153,243,107,65,162,219,178,97,0,153,14,116,146,23,23,237,25,201,173,17,237,193,84,218,136,102,127,251,203,135,184,29,144,59,32,236,61,6,140,220,213,251,104,85,196,183,28,138,179,42,32,195,12,188,105,221,78,16,208,136,175,200,200,37,71,185,127,154,31,50,114,192,190,200,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IntersectEntityCollectionsUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("894456e6-7236-47d9-9223-fcca6c52cb6c"));
		}

		#endregion

	}

	#endregion

}

