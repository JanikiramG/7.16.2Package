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
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchema

	/// <exclude/>
	public class ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return _controlLayout5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label1;
		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return _label1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer2;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return _spacer2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _setColumnsMenuButton;
		public Terrasoft.UI.WebControls.Controls.Button SetColumnsMenuButton {
			get {
				return _setColumnsMenuButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _metaPathColumnsTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid MetaPathColumnsTreeGrid {
			get {
				return _metaPathColumnsTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label2;
		public Terrasoft.UI.WebControls.Controls.Label Label2 {
			get {
				return _label2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _saveIntoCollectionRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton SaveIntoCollectionRadioButton {
			get {
				return _saveIntoCollectionRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _resultEntityCollectionTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ResultEntityCollectionTextEdit {
			get {
				return _resultEntityCollectionTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _resultEntityCollectionEditToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ResultEntityCollectionEditToolButton {
			get {
				return _resultEntityCollectionEditToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _saveIntoResultCollectionRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton SaveIntoResultCollectionRadioButton {
			get {
				return _saveIntoResultCollectionRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _entityDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return _entityDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchema(ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			RealUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			Name = "ReadDataIntoEntityCollectionItemsUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 500;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema();
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
			ControlLayout1.InsertItem(2, CreateControlLayout5());
			ControlLayout5.InsertItem(0, CreateLabel1());
			ControlLayout5.InsertItem(1, CreateSpacer2());
			ControlLayout5.InsertItem(2, CreateSetColumnsMenuButton());
			TopControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateMetaPathColumnsTreeGrid());
			TopControlLayout.InsertItem(2, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateLabel2());
			ControlLayout3.InsertItem(1, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateSaveIntoCollectionRadioButton());
			ControlLayout4.InsertItem(1, CreateResultEntityCollectionTextEdit());
			ResultEntityCollectionTextEdit.InsertItem(0, CreateResultEntityCollectionEditToolButton());
			ControlLayout3.InsertItem(2, CreateSaveIntoResultCollectionRadioButton());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			Controls.AddAt(3, CreateEntityDataSource());
			UpdateEntityDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateTitleEdit() {
			_titleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_titleEdit.UId = new Guid("946fec82-79a8-4ffa-a3de-6ad717e3f981");
			_titleEdit.Name = "TitleEdit";
			_titleEdit.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_titleEdit.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
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
			_entityCollectionEditToolButton.UId = new Guid("6409ac2b-2925-40e4-a3a0-e8de00f140cb");
			_entityCollectionEditToolButton.Name = "EntityCollectionEditToolButton";
			_entityCollectionEditToolButton.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_entityCollectionEditToolButton.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_entityCollectionEditToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionEditToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_entityCollectionEditToolButton.Tag = "";
			_entityCollectionEditToolButton.Image = new ControlImage {};
			return _entityCollectionEditToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateEntityCollectionTextEdit() {
			_entityCollectionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_entityCollectionTextEdit.UId = new Guid("4561a732-5cd8-4ad2-82da-10d1cafb8128");
			_entityCollectionTextEdit.Name = "EntityCollectionTextEdit";
			_entityCollectionTextEdit.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_entityCollectionTextEdit.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
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
			_label1.UId = new Guid("51ae604e-a84f-4396-9a7e-57e91bd6755a");
			_label1.Name = "Label1";
			_label1.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_label1.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_label1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label1.Tag = "";
			_label1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _label1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer2() {
			_spacer2 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer2.UId = new Guid("526f275b-1bb2-46a9-9755-8eaa3fc1004d");
			_spacer2.Name = "Spacer2";
			_spacer2.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_spacer2.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_spacer2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer2.Tag = "";
			_spacer2.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSetColumnsMenuButton() {
			_setColumnsMenuButton = new Terrasoft.UI.WebControls.Controls.Button();
			_setColumnsMenuButton.UId = new Guid("7621ee2e-7b2b-4f0b-aa43-11eb35439f61");
			_setColumnsMenuButton.Name = "SetColumnsMenuButton";
			_setColumnsMenuButton.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_setColumnsMenuButton.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_setColumnsMenuButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_setColumnsMenuButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_setColumnsMenuButton.Tag = "";
			_setColumnsMenuButton.Image = new ControlImage {};
			return _setColumnsMenuButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout5() {
			_controlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout5.UId = new Guid("529f62e1-c77f-4240-8b00-1e391d258dcd");
			_controlLayout5.Name = "ControlLayout5";
			_controlLayout5.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_controlLayout5.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_controlLayout5.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout5.Tag = "";
			_controlLayout5.Height = System.Web.UI.WebControls.Unit.Pixel(24);
			_controlLayout5.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout5.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout5.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout5.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Center;
			_controlLayout5.StartNewAlignGroup = false;
			_controlLayout5.Image = new ControlImage {};
			_controlLayout5.Edges = "";
			return _controlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("6a45b218-1e81-4ed6-9157-510834275414");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_controlLayout1.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
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

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateMetaPathColumnsTreeGrid() {
			_metaPathColumnsTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_metaPathColumnsTreeGrid.UId = new Guid("04458575-796d-4f53-a6f6-550c5534f2cb");
			_metaPathColumnsTreeGrid.Name = "MetaPathColumnsTreeGrid";
			_metaPathColumnsTreeGrid.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_metaPathColumnsTreeGrid.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_metaPathColumnsTreeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_metaPathColumnsTreeGrid.Tag = "";
			_metaPathColumnsTreeGrid.Edges = "1 1 1 1";
			_metaPathColumnsTreeGrid.IsColumnAutowidth = true;
			_metaPathColumnsTreeGrid.IsMultilineMode = false;
			_metaPathColumnsTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_metaPathColumnsTreeGrid.IsSummaryVisible = false;
			_metaPathColumnsTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_metaPathColumnsTreeGrid.QuickFilterVisible = false;
			_metaPathColumnsTreeGrid.HideHeaders = false;
			return _metaPathColumnsTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("c718a7f0-318d-4eff-8348-cbf9a639558a");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_controlLayout2.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel2() {
			_label2 = new Terrasoft.UI.WebControls.Controls.Label();
			_label2.UId = new Guid("69522bca-928b-467b-aa49-6283f7184707");
			_label2.Name = "Label2";
			_label2.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_label2.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_label2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label2.Tag = "";
			_label2.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _label2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateSaveIntoCollectionRadioButton() {
			_saveIntoCollectionRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_saveIntoCollectionRadioButton.UId = new Guid("6da5ba53-1629-4285-a229-3654d83c1407");
			_saveIntoCollectionRadioButton.Name = "SaveIntoCollectionRadioButton";
			_saveIntoCollectionRadioButton.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_saveIntoCollectionRadioButton.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_saveIntoCollectionRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_saveIntoCollectionRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_saveIntoCollectionRadioButton.Tag = "";
			_saveIntoCollectionRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_saveIntoCollectionRadioButton.Width = System.Web.UI.WebControls.Unit.Pixel(85);
			_saveIntoCollectionRadioButton.AlignedByCaption = false;
			_saveIntoCollectionRadioButton.GroupName = "SaveResultRadioButtonGroup";
			return _saveIntoCollectionRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateResultEntityCollectionEditToolButton() {
			_resultEntityCollectionEditToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_resultEntityCollectionEditToolButton.UId = new Guid("1270b83c-dc77-4122-9214-b9e674607569");
			_resultEntityCollectionEditToolButton.Name = "ResultEntityCollectionEditToolButton";
			_resultEntityCollectionEditToolButton.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_resultEntityCollectionEditToolButton.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_resultEntityCollectionEditToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_resultEntityCollectionEditToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_resultEntityCollectionEditToolButton.Tag = "";
			_resultEntityCollectionEditToolButton.Image = new ControlImage {};
			return _resultEntityCollectionEditToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateResultEntityCollectionTextEdit() {
			_resultEntityCollectionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_resultEntityCollectionTextEdit.UId = new Guid("7aadc426-9914-48fb-9a4e-83507ca95c59");
			_resultEntityCollectionTextEdit.Name = "ResultEntityCollectionTextEdit";
			_resultEntityCollectionTextEdit.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_resultEntityCollectionTextEdit.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_resultEntityCollectionTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_resultEntityCollectionTextEdit.Tag = "";
			_resultEntityCollectionTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_resultEntityCollectionTextEdit.Image = new ControlImage {};
			_resultEntityCollectionTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_resultEntityCollectionTextEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_resultEntityCollectionTextEdit.AlignedByCaption = false;
			_resultEntityCollectionTextEdit.Margins = "0 0 0 0";
			return _resultEntityCollectionTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("cf3f1a9a-4a08-4575-b8d2-e4ce53d5b6ed");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_controlLayout4.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
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

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateSaveIntoResultCollectionRadioButton() {
			_saveIntoResultCollectionRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_saveIntoResultCollectionRadioButton.UId = new Guid("98b2384b-9a1c-4e45-9e0a-32279df813c8");
			_saveIntoResultCollectionRadioButton.Name = "SaveIntoResultCollectionRadioButton";
			_saveIntoResultCollectionRadioButton.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_saveIntoResultCollectionRadioButton.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_saveIntoResultCollectionRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_saveIntoResultCollectionRadioButton.Tag = "";
			_saveIntoResultCollectionRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_saveIntoResultCollectionRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_saveIntoResultCollectionRadioButton.AlignedByCaption = false;
			_saveIntoResultCollectionRadioButton.GroupName = "SaveResultRadioButtonGroup";
			return _saveIntoResultCollectionRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("14389261-456d-4a8b-a8e7-74b556177b43");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_controlLayout3.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(5);
			_controlLayout3.Collapsed = true;
			_controlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			_controlLayout3.Enabled = false;
			_controlLayout3.Hidden = true;
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("fe017c3b-b369-4206-922b-ff75abe3abdd");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_entityDataSource.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("726917f6-770f-4ced-bc2e-da6550e1bf45");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			return _entityDataSource;
		}

		protected virtual void UpdateEntityDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("229dd423-b654-461f-8eff-e779b3289d85"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl
	{

		#region Class: ChangeEntityCollectionUserMessageFlowElement

		/// <exclude/>
		public class ChangeEntityCollectionUserMessageFlowElement : QuestionUserTask
		{

			public ChangeEntityCollectionUserMessageFlowElement(UserConnection userConnection, ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeEntityCollectionUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ChangeResultEntityCollectionUserMessageFlowElement

		/// <exclude/>
		public class ChangeResultEntityCollectionUserMessageFlowElement : QuestionUserTask
		{

			public ChangeResultEntityCollectionUserMessageFlowElement(UserConnection userConnection, ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeResultEntityCollectionUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_isValidData = () => {{ return true; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("229dd423-b654-461f-8eff-e779b3289d85");
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

		public virtual Guid EntityCollectionSchemaUId {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual string EntityCollectionDisplayValue {
			get;
			set;
		}

		public virtual string NewEntityCollectionParameterValue {
			get;
			set;
		}

		public virtual string UserDefinedEntityCollectionMetaPath {
			get;
			set;
		}

		public virtual bool IsNewUserDefinedEntityCollection {
			get;
			set;
		}

		public virtual string NewUserDefinedEntityCollectionParameterValue {
			get;
			set;
		}

		public virtual string UserDefinedEntityCollectionDisplayValue {
			get;
			set;
		}

		public virtual Object ReadColumnsVirtualDataSource {
			get;
			set;
		}

		public virtual Object ColumnStructureExplorer {
			get;
			set;
		}

		public virtual bool IsColumnStructureExplorerCreated {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerRegistered {
			get;
			set;
		}

		public virtual string MetaPathColumns {
			get;
			set;
		}

		public virtual string EntitySchemaProcessData {
			get;
			set;
		}

		public virtual bool IsModifiedEntitySchemaProcessData {
			get;
			set;
		}

		private Func<bool> _isValidData;
		public virtual bool IsValidData {
			get {
				return (_isValidData ?? (_isValidData = () => false)).Invoke();
			}
			set {
				_isValidData = () => { return value; };
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
					SchemaElementUId = new Guid("b1e1c031-772f-4072-b113-3a6c63da1d05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _setColumnsMenuButtonClickStartMessage;
		public ProcessFlowElement SetColumnsMenuButtonClickStartMessage {
			get {
				return _setColumnsMenuButtonClickStartMessage ?? (_setColumnsMenuButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SetColumnsMenuButtonClickStartMessage",
					SchemaElementUId = new Guid("05a0e7dc-6025-4c1d-ad52-d78ae4d3882d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setColumnsMenuButtonClickScript;
		public ProcessScriptTask SetColumnsMenuButtonClickScript {
			get {
				return _setColumnsMenuButtonClickScript ?? (_setColumnsMenuButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetColumnsMenuButtonClickScript",
					SchemaElementUId = new Guid("c1f53259-fd6d-4c07-904e-548d41c6ea99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetColumnsMenuButtonClickScriptExecute,
				});
			}
		}

		private ProcessFlowElement _okButtonClickChildSubProcess;
		public ProcessFlowElement OkButtonClickChildSubProcess {
			get {
				return _okButtonClickChildSubProcess ?? (_okButtonClickChildSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OkButtonClickChildSubProcess",
					SchemaElementUId = new Guid("79fe864f-8b33-49d2-a91b-4c59c8506d16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickChild;
		public ProcessFlowElement OkButtonClickChild {
			get {
				return _okButtonClickChild ?? (_okButtonClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickChild",
					SchemaElementUId = new Guid("8b5ba844-90d1-40eb-9661-e4d042940565"),
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
					SchemaElementUId = new Guid("ecd1448d-2034-46c7-babf-d04ff73bf4d1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickChildScriptExecute,
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
					SchemaElementUId = new Guid("f68abaf3-64d9-4e29-844f-a28d028ad8fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _checkDataScriptTask;
		public ProcessScriptTask CheckDataScriptTask {
			get {
				return _checkDataScriptTask ?? (_checkDataScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckDataScriptTask",
					SchemaElementUId = new Guid("abb24334-0f9e-43d4-aed3-79f733f387bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckDataScriptTaskExecute,
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
					SchemaElementUId = new Guid("26653e05-8532-471c-a0e1-67275daa3b90"),
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

		private ProcessScriptTask _showWarningMessageScriptTask;
		public ProcessScriptTask ShowWarningMessageScriptTask {
			get {
				return _showWarningMessageScriptTask ?? (_showWarningMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowWarningMessageScriptTask",
					SchemaElementUId = new Guid("9c89231c-c1db-42e7-8f04-3a20ccf3e840"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowWarningMessageScriptTaskExecute,
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
					SchemaElementUId = new Guid("1a8eb83f-6216-454e-a044-9f810846dae6"),
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
					SchemaElementUId = new Guid("7e9c6e47-c6cb-4f4e-b9d1-ef6d2e955251"),
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
					SchemaElementUId = new Guid("a508b546-e554-4bc1-843d-4c8fbfd38b60"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("3013e45b-2db7-449c-8e1b-0361b01e1132"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildInitScriptExecute,
				});
			}
		}

		private ProcessFlowElement _onPageLoadComplete;
		public ProcessFlowElement OnPageLoadComplete {
			get {
				return _onPageLoadComplete ?? (_onPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OnPageLoadComplete",
					SchemaElementUId = new Guid("28958f3d-7490-405f-892a-fe6b75f90f9c"),
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
					SchemaElementUId = new Guid("8d6a4616-603b-4400-91e8-572957cfea96"),
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
					SchemaElementUId = new Guid("6df6aaec-1be3-4013-a806-5342984a636b"),
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
					SchemaElementUId = new Guid("8836bc0f-6c0d-4ccf-b48d-a52ca52a5a83"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteChildScriptExecute,
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
					SchemaElementUId = new Guid("67934257-77dd-41f5-a6b1-031bf9662070"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entityCollectionEditToolButtonClickStartMessage;
		public ProcessFlowElement EntityCollectionEditToolButtonClickStartMessage {
			get {
				return _entityCollectionEditToolButtonClickStartMessage ?? (_entityCollectionEditToolButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntityCollectionEditToolButtonClickStartMessage",
					SchemaElementUId = new Guid("0e840b83-7641-43de-91af-342851dce369"),
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
					SchemaElementUId = new Guid("2f59b04b-40cf-48f6-badf-b078875be593"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EntityCollectionEditToolButtonClickScriptExecute,
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
					SchemaElementUId = new Guid("7faa730b-446d-4e43-ad85-15e769722bdf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entityCollectionEditChangeStartMessage;
		public ProcessFlowElement EntityCollectionEditChangeStartMessage {
			get {
				return _entityCollectionEditChangeStartMessage ?? (_entityCollectionEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntityCollectionEditChangeStartMessage",
					SchemaElementUId = new Guid("65e50457-7c57-4c22-b612-c12182ca86a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _saveNewEntityCollectionParameterValueScript;
		public ProcessScriptTask SaveNewEntityCollectionParameterValueScript {
			get {
				return _saveNewEntityCollectionParameterValueScript ?? (_saveNewEntityCollectionParameterValueScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveNewEntityCollectionParameterValueScript",
					SchemaElementUId = new Guid("b4fa84ee-23c7-46bd-8a93-8b602bd09be8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveNewEntityCollectionParameterValueScriptExecute,
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
					SchemaElementUId = new Guid("01a38258-db8f-4095-a979-77e960828022"),
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

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3 {
			get {
				return _intermediateThrowMessageEvent3 ?? (_intermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("3fa2f4e3-0b89-4cb5-88af-b066269dcab7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeEntityCollectionYesMessage",
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
					SchemaElementUId = new Guid("342d3a60-b4fc-4eb4-9d21-4cbdf5ceed13"),
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

		private ProcessFlowElement _eventSubProcessChangeEntityCollectionYesMessage;
		public ProcessFlowElement EventSubProcessChangeEntityCollectionYesMessage {
			get {
				return _eventSubProcessChangeEntityCollectionYesMessage ?? (_eventSubProcessChangeEntityCollectionYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeEntityCollectionYesMessage",
					SchemaElementUId = new Guid("ceed82be-cec4-4614-a407-d54b152da5e9"),
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
					SchemaElementUId = new Guid("bae626b1-5c5d-439a-9c86-c708725fda42"),
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
					SchemaElementUId = new Guid("a8e37a72-0bf4-4cec-97e8-2241cd57ac38"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEntityCollectionYesMessageScriptExecute,
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
					SchemaElementUId = new Guid("4d153a60-0a6f-4e4a-8e32-fc86e3c50e0b"),
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
					SchemaElementUId = new Guid("5c56307a-d472-4055-ba4e-adb56e35634d"),
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
					SchemaElementUId = new Guid("150dfb18-8d62-4694-a60b-669be022e250"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEntityCollectionNoMessageScriptExecute,
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
					SchemaElementUId = new Guid("b22df098-35af-482f-b9a3-709c15541e4d"),
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
					SchemaElementUId = new Guid("024c3628-8600-42b4-a5fc-014973d14fea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _saveIntoCollectionRadioButtonCheckScript;
		public ProcessScriptTask SaveIntoCollectionRadioButtonCheckScript {
			get {
				return _saveIntoCollectionRadioButtonCheckScript ?? (_saveIntoCollectionRadioButtonCheckScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveIntoCollectionRadioButtonCheckScript",
					SchemaElementUId = new Guid("a08deab7-5ee1-4297-adea-4b6ab2de75ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveIntoCollectionRadioButtonCheckScriptExecute,
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
					SchemaElementUId = new Guid("b922a36f-9dd6-4e7d-aa24-697815e9ca8c"),
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
					SchemaElementUId = new Guid("a7d22f38-26d6-4d81-91da-16b3e4eab9ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _saveIntoResultCollectionRadioButtonCheckScript;
		public ProcessScriptTask SaveIntoResultCollectionRadioButtonCheckScript {
			get {
				return _saveIntoResultCollectionRadioButtonCheckScript ?? (_saveIntoResultCollectionRadioButtonCheckScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveIntoResultCollectionRadioButtonCheckScript",
					SchemaElementUId = new Guid("05eb1c1c-116d-415f-a051-6c8a22534d6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveIntoResultCollectionRadioButtonCheckScriptExecute,
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
					SchemaElementUId = new Guid("f6e2ee2e-818d-4134-bc50-e1ffef417ea3"),
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
					SchemaElementUId = new Guid("8bc3c605-7f4e-49a6-8f29-af1675a0793f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _resultEntityCollectionEditToolButtonClickScript;
		public ProcessScriptTask ResultEntityCollectionEditToolButtonClickScript {
			get {
				return _resultEntityCollectionEditToolButtonClickScript ?? (_resultEntityCollectionEditToolButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ResultEntityCollectionEditToolButtonClickScript",
					SchemaElementUId = new Guid("a69de0fd-bf37-416b-8589-2f2e15ae94bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ResultEntityCollectionEditToolButtonClickScriptExecute,
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
					SchemaElementUId = new Guid("35cb520e-2d46-4b86-8b88-2899040ce9a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage8;
		public ProcessFlowElement StartMessage8 {
			get {
				return _startMessage8 ?? (_startMessage8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage8",
					SchemaElementUId = new Guid("ed241270-dcea-4e4a-9bd8-58c297b96100"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _saveNewResultEntityCollectionParameterValueScript;
		public ProcessScriptTask SaveNewResultEntityCollectionParameterValueScript {
			get {
				return _saveNewResultEntityCollectionParameterValueScript ?? (_saveNewResultEntityCollectionParameterValueScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveNewResultEntityCollectionParameterValueScript",
					SchemaElementUId = new Guid("86de6d66-9bf5-400a-ac78-990b1a8b75a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveNewResultEntityCollectionParameterValueScriptExecute,
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
					SchemaElementUId = new Guid("87756328-94b6-4613-b11d-2ddd3fb41bf7"),
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

		private ProcessScriptTask _prepareChangeResultEntityCollectionQuestionScript;
		public ProcessScriptTask PrepareChangeResultEntityCollectionQuestionScript {
			get {
				return _prepareChangeResultEntityCollectionQuestionScript ?? (_prepareChangeResultEntityCollectionQuestionScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareChangeResultEntityCollectionQuestionScript",
					SchemaElementUId = new Guid("9139dfaa-e557-4c6e-a272-4fac42172f8a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareChangeResultEntityCollectionQuestionScriptExecute,
				});
			}
		}

		private ChangeResultEntityCollectionUserMessageFlowElement _changeResultEntityCollectionUserMessage;
		public ChangeResultEntityCollectionUserMessageFlowElement ChangeResultEntityCollectionUserMessage {
			get {
				return _changeResultEntityCollectionUserMessage ?? (_changeResultEntityCollectionUserMessage = new ChangeResultEntityCollectionUserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent4;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent4 {
			get {
				return _intermediateThrowMessageEvent4 ?? (_intermediateThrowMessageEvent4 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent4",
					SchemaElementUId = new Guid("bb24bdea-970f-4487-9d0d-a6adf7e070a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeResultEntityCollectionYesMessage",
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
					SchemaElementUId = new Guid("f1edd0aa-ff8e-415a-8560-6574ddf2397f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeResultEntityCollectionYesMessageBase;
		public ProcessFlowElement ChangeResultEntityCollectionYesMessageBase {
			get {
				return _changeResultEntityCollectionYesMessageBase ?? (_changeResultEntityCollectionYesMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeResultEntityCollectionYesMessageBase",
					SchemaElementUId = new Guid("9e3914f6-8d78-4ad5-bd0c-2f43045dca88"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeResultEntityCollectionScript;
		public ProcessScriptTask ChangeResultEntityCollectionScript {
			get {
				return _changeResultEntityCollectionScript ?? (_changeResultEntityCollectionScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeResultEntityCollectionScript",
					SchemaElementUId = new Guid("251a04a7-3f9a-474b-8b54-1eb1db6b60e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeResultEntityCollectionScriptExecute,
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
					SchemaElementUId = new Guid("b83717ae-1946-482b-901e-61d38bffd115"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeResultEntityCollectionNoMessageBase;
		public ProcessFlowElement ChangeResultEntityCollectionNoMessageBase {
			get {
				return _changeResultEntityCollectionNoMessageBase ?? (_changeResultEntityCollectionNoMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeResultEntityCollectionNoMessageBase",
					SchemaElementUId = new Guid("08950a5b-46be-4983-8d75-2c2ab2227e4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _cancelChangeResultEntityCollectionScript;
		public ProcessScriptTask CancelChangeResultEntityCollectionScript {
			get {
				return _cancelChangeResultEntityCollectionScript ?? (_cancelChangeResultEntityCollectionScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CancelChangeResultEntityCollectionScript",
					SchemaElementUId = new Guid("efff1762-1cf3-4a41-88a5-028412aa733d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelChangeResultEntityCollectionScriptExecute,
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
					SchemaElementUId = new Guid("6c363022-1d11-46a9-ba68-23abeab8a3b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
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
					SchemaElementUId = new Guid("af5b6ddd-3312-418a-ba2d-ce8ea71a6dff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _validationConditionalFlow;
		public ProcessConditionalFlow ValidationConditionalFlow {
			get {
				return _validationConditionalFlow ?? (_validationConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ValidationConditionalFlow",
					SchemaElementUId = new Guid("50b89e59-99e1-4b49-9aab-74598979b540"),
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

		private LocalizableString _readColumnsVirtualDataSourcePrimaryDisplayColumnName;
		public LocalizableString ReadColumnsVirtualDataSourcePrimaryDisplayColumnName {
			get {
				return _readColumnsVirtualDataSourcePrimaryDisplayColumnName ?? (_readColumnsVirtualDataSourcePrimaryDisplayColumnName = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ReadColumnsVirtualDataSourcePrimaryDisplayColumnName.Value"));
			}
		}

		private LocalizableString _isNotSelectedAnyEntityColumnsMessage;
		public LocalizableString IsNotSelectedAnyEntityColumnsMessage {
			get {
				return _isNotSelectedAnyEntityColumnsMessage ?? (_isNotSelectedAnyEntityColumnsMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IsNotSelectedAnyEntityColumnsMessage.Value"));
			}
		}

		private LocalizableString _validationMessageTitle;
		public LocalizableString ValidationMessageTitle {
			get {
				return _validationMessageTitle ?? (_validationMessageTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTitle.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SetColumnsMenuButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SetColumnsMenuButtonClickStartMessage };
			FlowElements[SetColumnsMenuButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetColumnsMenuButtonClickScript };
			FlowElements[OkButtonClickChildSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildSubProcess };
			FlowElements[OkButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChild };
			FlowElements[OkButtonClickChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildScript };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[CheckDataScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckDataScriptTask };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ShowWarningMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowWarningMessageScriptTask };
			FlowElements[EventSubProcessOnInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessOnInit };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
			FlowElements[IntermediateThrowMessageEventInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventInit };
			FlowElements[ChildInitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitScript };
			FlowElements[OnPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPageLoadComplete };
			FlowElements[StartMessagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePageLoadComplete };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[PageLoadCompleteChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScript };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[EntityCollectionEditToolButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityCollectionEditToolButtonClickStartMessage };
			FlowElements[EntityCollectionEditToolButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityCollectionEditToolButtonClickScript };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[EntityCollectionEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityCollectionEditChangeStartMessage };
			FlowElements[SaveNewEntityCollectionParameterValueScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveNewEntityCollectionParameterValueScript };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[PrepareChangeEntityCollectionQuestionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareChangeEntityCollectionQuestionScript };
			FlowElements[ChangeEntityCollectionUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionUserMessage };
			FlowElements[EventSubProcessChangeEntityCollectionYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeEntityCollectionYesMessage };
			FlowElements[ChangeEntityCollectionYesMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageBase };
			FlowElements[ChangeEntityCollectionYesMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageScript };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[ChangeEntityCollectionNoMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageBase };
			FlowElements[ChangeEntityCollectionNoMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageScript };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[SaveIntoCollectionRadioButtonCheckScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveIntoCollectionRadioButtonCheckScript };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[StartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6 };
			FlowElements[SaveIntoResultCollectionRadioButtonCheckScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveIntoResultCollectionRadioButtonCheckScript };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage7 };
			FlowElements[ResultEntityCollectionEditToolButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ResultEntityCollectionEditToolButtonClickScript };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage8.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage8 };
			FlowElements[SaveNewResultEntityCollectionParameterValueScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveNewResultEntityCollectionParameterValueScript };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[PrepareChangeResultEntityCollectionQuestionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareChangeResultEntityCollectionQuestionScript };
			FlowElements[ChangeResultEntityCollectionUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeResultEntityCollectionUserMessage };
			FlowElements[IntermediateThrowMessageEvent4.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent4 };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[ChangeResultEntityCollectionYesMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeResultEntityCollectionYesMessageBase };
			FlowElements[ChangeResultEntityCollectionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeResultEntityCollectionScript };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[ChangeResultEntityCollectionNoMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeResultEntityCollectionNoMessageBase };
			FlowElements[CancelChangeResultEntityCollectionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelChangeResultEntityCollectionScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "SetColumnsMenuButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("SetColumnsMenuButtonClickScript");
						break;
					case "SetColumnsMenuButtonClickScript":
						break;
					case "OkButtonClickChildSubProcess":
						break;
					case "OkButtonClickChild":
						e.Context.QueueTasks.Enqueue("CheckDataScriptTask");
						break;
					case "OkButtonClickChildScript":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "CheckDataScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "ExclusiveGateway3":
						if (ValidationConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OkButtonClickChildScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("ShowWarningMessageScriptTask");
						break;
					case "ShowWarningMessageScriptTask":
						break;
					case "EventSubProcessOnInit":
						break;
					case "StartMessageInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventInit");
						break;
					case "IntermediateThrowMessageEventInit":
						e.Context.QueueTasks.Enqueue("ChildInitScript");
						break;
					case "ChildInitScript":
						break;
					case "OnPageLoadComplete":
						break;
					case "StartMessagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScript");
						break;
					case "PageLoadCompleteChildScript":
						break;
					case "EventSubProcess3":
						break;
					case "EntityCollectionEditToolButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("EntityCollectionEditToolButtonClickScript");
						break;
					case "EntityCollectionEditToolButtonClickScript":
						break;
					case "EventSubProcess4":
						break;
					case "EntityCollectionEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("SaveNewEntityCollectionParameterValueScript");
						break;
					case "SaveNewEntityCollectionParameterValueScript":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareChangeEntityCollectionQuestionScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "PrepareChangeEntityCollectionQuestionScript":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionUserMessage");
						break;
					case "ChangeEntityCollectionUserMessage":
						break;
					case "EventSubProcessChangeEntityCollectionYesMessage":
						break;
					case "ChangeEntityCollectionYesMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionYesMessageScript");
						break;
					case "ChangeEntityCollectionYesMessageScript":
						break;
					case "EventSubProcess6":
						break;
					case "ChangeEntityCollectionNoMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionNoMessageScript");
						break;
					case "ChangeEntityCollectionNoMessageScript":
						break;
					case "EventSubProcess5":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("SaveIntoCollectionRadioButtonCheckScript");
						break;
					case "SaveIntoCollectionRadioButtonCheckScript":
						break;
					case "EventSubProcess7":
						break;
					case "StartMessage6":
						e.Context.QueueTasks.Enqueue("SaveIntoResultCollectionRadioButtonCheckScript");
						break;
					case "SaveIntoResultCollectionRadioButtonCheckScript":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage7":
						e.Context.QueueTasks.Enqueue("ResultEntityCollectionEditToolButtonClickScript");
						break;
					case "ResultEntityCollectionEditToolButtonClickScript":
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage8":
						e.Context.QueueTasks.Enqueue("SaveNewResultEntityCollectionParameterValueScript");
						break;
					case "SaveNewResultEntityCollectionParameterValueScript":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareChangeResultEntityCollectionQuestionScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent4");
						break;
					case "PrepareChangeResultEntityCollectionQuestionScript":
						e.Context.QueueTasks.Enqueue("ChangeResultEntityCollectionUserMessage");
						break;
					case "ChangeResultEntityCollectionUserMessage":
						break;
					case "IntermediateThrowMessageEvent4":
						break;
					case "EventSubProcess10":
						break;
					case "ChangeResultEntityCollectionYesMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeResultEntityCollectionScript");
						break;
					case "ChangeResultEntityCollectionScript":
						break;
					case "EventSubProcess11":
						break;
					case "ChangeResultEntityCollectionNoMessageBase":
						e.Context.QueueTasks.Enqueue("CancelChangeResultEntityCollectionScript");
						break;
					case "CancelChangeResultEntityCollectionScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(!IsNew);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(!IsNewUserDefinedEntityCollection);
		}

		private bool ValidationConditionalFlowExpressionExecute() {
			return Convert.ToBoolean( IsValidData);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SetColumnsMenuButtonClickStartMessage");
			ActivatedEventElements.Add("OkButtonClickChild");
			ActivatedEventElements.Add("StartMessageInit");
			ActivatedEventElements.Add("StartMessagePageLoadComplete");
			ActivatedEventElements.Add("EntityCollectionEditToolButtonClickStartMessage");
			ActivatedEventElements.Add("EntityCollectionEditChangeStartMessage");
			ActivatedEventElements.Add("ChangeEntityCollectionYesMessageBase");
			ActivatedEventElements.Add("ChangeEntityCollectionNoMessageBase");
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("StartMessage6");
			ActivatedEventElements.Add("StartMessage7");
			ActivatedEventElements.Add("StartMessage8");
			ActivatedEventElements.Add("ChangeResultEntityCollectionYesMessageBase");
			ActivatedEventElements.Add("ChangeResultEntityCollectionNoMessageBase");
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
				case "SetColumnsMenuButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetColumnsMenuButtonClickStartMessage";
					result = SetColumnsMenuButtonClickStartMessage.Execute(context);
					break;
				case "SetColumnsMenuButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetColumnsMenuButtonClickScript";
					result = SetColumnsMenuButtonClickScript.Execute(context, SetColumnsMenuButtonClickScriptExecute);
					break;
				case "OkButtonClickChildSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickChild";
					result = OkButtonClickChild.Execute(context);
					break;
				case "OkButtonClickChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickChildScript";
					result = OkButtonClickChildScript.Execute(context, OkButtonClickChildScriptExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "CheckDataScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckDataScriptTask";
					result = CheckDataScriptTask.Execute(context, CheckDataScriptTaskExecute);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "ShowWarningMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowWarningMessageScriptTask";
					result = ShowWarningMessageScriptTask.Execute(context, ShowWarningMessageScriptTaskExecute);
					break;
				case "EventSubProcessOnInit":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageInit";
					result = StartMessageInit.Execute(context);
					break;
				case "IntermediateThrowMessageEventInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEventInit.Execute(context);
					break;
				case "ChildInitScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitScript";
					result = ChildInitScript.Execute(context, ChildInitScriptExecute);
					break;
				case "OnPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePageLoadComplete";
					result = StartMessagePageLoadComplete.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "PageLoadCompleteChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChildScript";
					result = PageLoadCompleteChildScript.Execute(context, PageLoadCompleteChildScriptExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "EntityCollectionEditToolButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityCollectionEditToolButtonClickStartMessage";
					result = EntityCollectionEditToolButtonClickStartMessage.Execute(context);
					break;
				case "EntityCollectionEditToolButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityCollectionEditToolButtonClickScript";
					result = EntityCollectionEditToolButtonClickScript.Execute(context, EntityCollectionEditToolButtonClickScriptExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "EntityCollectionEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityCollectionEditChangeStartMessage";
					result = EntityCollectionEditChangeStartMessage.Execute(context);
					break;
				case "SaveNewEntityCollectionParameterValueScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveNewEntityCollectionParameterValueScript";
					result = SaveNewEntityCollectionParameterValueScript.Execute(context, SaveNewEntityCollectionParameterValueScriptExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent3.Execute(context);
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
				case "EventSubProcess6":
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
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "SaveIntoCollectionRadioButtonCheckScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveIntoCollectionRadioButtonCheckScript";
					result = SaveIntoCollectionRadioButtonCheckScript.Execute(context, SaveIntoCollectionRadioButtonCheckScriptExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6";
					result = StartMessage6.Execute(context);
					break;
				case "SaveIntoResultCollectionRadioButtonCheckScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveIntoResultCollectionRadioButtonCheckScript";
					result = SaveIntoResultCollectionRadioButtonCheckScript.Execute(context, SaveIntoResultCollectionRadioButtonCheckScriptExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage7";
					result = StartMessage7.Execute(context);
					break;
				case "ResultEntityCollectionEditToolButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ResultEntityCollectionEditToolButtonClickScript";
					result = ResultEntityCollectionEditToolButtonClickScript.Execute(context, ResultEntityCollectionEditToolButtonClickScriptExecute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage8":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage8";
					result = StartMessage8.Execute(context);
					break;
				case "SaveNewResultEntityCollectionParameterValueScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveNewResultEntityCollectionParameterValueScript";
					result = SaveNewResultEntityCollectionParameterValueScript.Execute(context, SaveNewResultEntityCollectionParameterValueScriptExecute);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "PrepareChangeResultEntityCollectionQuestionScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareChangeResultEntityCollectionQuestionScript";
					result = PrepareChangeResultEntityCollectionQuestionScript.Execute(context, PrepareChangeResultEntityCollectionQuestionScriptExecute);
					break;
				case "ChangeResultEntityCollectionUserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeResultEntityCollectionUserMessage";
					result = ChangeResultEntityCollectionUserMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent4":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent4.Execute(context);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeResultEntityCollectionYesMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeResultEntityCollectionYesMessageBase";
					result = ChangeResultEntityCollectionYesMessageBase.Execute(context);
					break;
				case "ChangeResultEntityCollectionScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeResultEntityCollectionScript";
					result = ChangeResultEntityCollectionScript.Execute(context, ChangeResultEntityCollectionScriptExecute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeResultEntityCollectionNoMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeResultEntityCollectionNoMessageBase";
					result = ChangeResultEntityCollectionNoMessageBase.Execute(context);
					break;
				case "CancelChangeResultEntityCollectionScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelChangeResultEntityCollectionScript";
					result = CancelChangeResultEntityCollectionScript.Execute(context, CancelChangeResultEntityCollectionScriptExecute);
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
				case "IsModifiedEntitySchemaProcessData":
					IsModifiedEntitySchemaProcessData = reader.GetValue<System.Boolean>();
				break;
				case "EntitySchemaProcessData":
					EntitySchemaProcessData = reader.GetValue<System.String>();
				break;
				case "MetaPathColumns":
					MetaPathColumns = reader.GetValue<System.String>();
				break;
				case "ColumnStructureExplorerRegistered":
					ColumnStructureExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "IsColumnStructureExplorerCreated":
					IsColumnStructureExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "ColumnStructureExplorer":
					ColumnStructureExplorer = reader.GetSerializableObjectValue();
				break;
				case "ReadColumnsVirtualDataSource":
					ReadColumnsVirtualDataSource = reader.GetSerializableObjectValue();
				break;
				case "UserDefinedEntityCollectionDisplayValue":
					UserDefinedEntityCollectionDisplayValue = reader.GetValue<System.String>();
				break;
				case "NewUserDefinedEntityCollectionParameterValue":
					NewUserDefinedEntityCollectionParameterValue = reader.GetValue<System.String>();
				break;
				case "IsNewUserDefinedEntityCollection":
					IsNewUserDefinedEntityCollection = reader.GetValue<System.Boolean>();
				break;
				case "UserDefinedEntityCollectionMetaPath":
					UserDefinedEntityCollectionMetaPath = reader.GetValue<System.String>();
				break;
				case "NewEntityCollectionParameterValue":
					NewEntityCollectionParameterValue = reader.GetValue<System.String>();
				break;
				case "EntityCollectionDisplayValue":
					EntityCollectionDisplayValue = reader.GetValue<System.String>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "EntityCollectionSchemaUId":
					EntityCollectionSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "EntityCollectionMetaPath":
					EntityCollectionMetaPath = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SetColumnsMenuButtonClickScriptExecute(ProcessExecutingContext context) {
			ShowColumnStructureExplorerEditWindow(EntityCollectionSchemaUId);
			return true;
		}

		public virtual bool OkButtonClickChildScriptExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.TitleEdit.Text;
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			var mappingVS = ProcessSchemaParameterValueSource.Mapping;
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			var entityCollection = Json.Deserialize<ProcessSchemaParameterValue>(((Terrasoft.UI.WebControls.Page)Page.AspPage).CustomData["EntityCollectionCustomDataKey"].ToString());
			entityCollection.Value = EntityCollectionMetaPath;
			entityCollection.ModifiedInSchemaUId = EditSchemaUId;
			entityCollection.Source = string.IsNullOrEmpty(EntityCollectionMetaPath)? noneVS : mappingVS;
			entityCollection.ReferenceSchemaUId = EntityCollectionSchemaUId;
			parametersValue["EntityCollection"] = entityCollection;
			
			var entitySchemaProcessData = JsonConvert.DeserializeObject<EntitySchemaProcessData>(EntitySchemaProcessData);
			entitySchemaProcessData.ParentSchemaUId = EntityCollectionSchemaUId;
			EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchema virtualDynamicSchema = entitySchemaManager
				.ForceGetSchema(entitySchemaProcessData, IsModifiedEntitySchemaProcessData);
			entitySchemaProcessData.SchemaUId = virtualDynamicSchema.UId;
			string serializedEntitySchemaProcessData = JsonConvert.SerializeObject(entitySchemaProcessData);
			parametersValue["ResultEntitySchemaProcessData"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = string.IsNullOrEmpty(EntitySchemaProcessData) ? noneVS : constVS,
				Value = serializedEntitySchemaProcessData
			};
			parametersValue["ResultEntityCollection"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				ReferenceSchemaUId = entitySchemaProcessData.SchemaUId
			};
			return true;
			/*var userDefinedEntityCollection = Json.Deserialize<ProcessSchemaParameterValue>(((UI.Core.Page)Page.AspPage)
				.CustomData["UserDefinedEntityCollectionCustomDataKey"].ToString());
			userDefinedEntityCollection.Value = UserDefinedEntityCollectionMetaPath;
			userDefinedEntityCollection.ModifiedInSchemaUId = EditSchemaUId;
			userDefinedEntityCollection.Source = string.IsNullOrEmpty(UserDefinedEntityCollectionMetaPath)? noneVS : mappingVS;
			parametersValue["UserDefinedEntityCollection"] = userDefinedEntityCollection;*/
		}

		public virtual bool CheckDataScriptTaskExecute(ProcessExecutingContext context) {
			IsValidData = !string.IsNullOrEmpty(EntitySchemaProcessData);
			return true;
		}

		public virtual bool ShowWarningMessageScriptTaskExecute(ProcessExecutingContext context) {
			Page.MainMessagePanel.Clear();
			Page.MainMessagePanel.AddMessage(ValidationMessageTitle, IsNotSelectedAnyEntityColumnsMessage, MessageType.Warning);
			return true;
		}

		public virtual bool ChildInitScriptExecute(ProcessExecutingContext context) {
			if(IsColumnStructureExplorerCreated){
				CreateColumnStructureExplorer();
			}
			VirtualDataSource virtualDataSource = CreateColumnVirtualDataSource();
			TreeGrid treeGrid = Page.MetaPathColumnsTreeGrid;
			treeGrid.ShowAutoWidthMenu = false;
			treeGrid.ShowMultiLineMenu = false;
			treeGrid.ShowSummariesMenu = false;
			treeGrid.IsShowOppositeReference = false;
			treeGrid.EnableContextMenu = false;
			treeGrid.IsColumnsExplorerRootMode = true;
			treeGrid.ToolbarVisible = false;
			treeGrid.DataSourceId = virtualDataSource.ID;
			treeGrid.GetRowConfigHandler = TreeGridConfigHandler;
			virtualDataSource.Loaded += treeGrid.DataLoaded;
			if (!Ext.IsAjaxRequest) {
				ParameterDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("EntityCollectionDataValueType").UId;
				Page.TitleEdit.Text = ElementNewCaption;
				var defValues = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
				DesignModeClassDescriptor descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = PropertyDataSource as VirtualDataSource;
				propertyDataSource.SetClientActiveRow();
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
				Page.SaveIntoCollectionRadioButton.Checked = true;
			}
			return true;
		}

		public virtual bool PageLoadCompleteChildScriptExecute(ProcessExecutingContext context) {
			EntityCollectionMetaPath = string.Empty;
			EntityCollectionDisplayValue = string.Empty;
			UserDefinedEntityCollectionMetaPath = string.Empty;
			UserDefinedEntityCollectionDisplayValue = string.Empty;
			var schema = FindDesignedProcessSchema();
			var df = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (df == null) {
				return true;
			}
			var entityCollection = df["EntityCollection"];
			if (entityCollection == null) {
				return true;
			}
			EntitySchemaProcessData entitySchemaProcessData;
			((Terrasoft.UI.WebControls.Page)Page.AspPage).CustomData["EntityCollectionCustomDataKey"] = Json.Serialize(entityCollection);
			if (entityCollection.ReferenceSchemaUId != Guid.Empty) {
				EntityCollectionSchemaUId = entityCollection.ReferenceSchemaUId;
				EntityCollectionMetaPath = entityCollection.Value;
				EntityCollectionDisplayValue = GetPropertyDisplayPathByServerMetaPath(GetPropertyServerMetaPathByClientMetaPath(entityCollection.Value));
				Page.EntityDataSource.SchemaUId = EntityCollectionSchemaUId;
				EntityCollectionDisplayValue = GetEntityCollectionDisplayValue(EntityCollectionDisplayValue, EntityCollectionMetaPath);
				Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
				//Page.EntityCollectionTextEdit.Enabled = string.IsNullOrEmpty(EntityCollectionDisplayValue) ? true : false;
				ProcessSchemaParameterValue resultEntitySchemaProcessData = df["ResultEntitySchemaProcessData"];
				entitySchemaProcessData = JsonConvert.DeserializeObject<EntitySchemaProcessData>(resultEntitySchemaProcessData.Value);
			} else {
				IsNew = true;
				entitySchemaProcessData = new EntitySchemaProcessData() {
					SchemaUId = Guid.NewGuid(),
					ParentSchemaColumnMetaPath = new Dictionary<Guid, string>()
				};
			}
			//MetaPathColumns = JsonConvert.SerializeObject(entitySchemaProcessData.ParentSchemaColumnMetaPath);
			LoadColumnVirtualDataSourceRows(entitySchemaProcessData.ParentSchemaColumnMetaPath);
			EntitySchemaProcessData = JsonConvert.SerializeObject(entitySchemaProcessData);
			/*var isSelectedResultEntityCollectionParameter = df["IsSelectedResultEntityCollection"];
			if(isSelectedResultEntityCollectionParameter != null){
				bool isSelectedResultEntityCollection = Convert.ToBoolean(isSelectedResultEntityCollectionParameter.Value);
				Page.SaveIntoResultCollectionRadioButton.Checked = isSelectedResultEntityCollection;
				bool isSelectedUserDefinedEntityCollection = !isSelectedResultEntityCollection;
				Page.SaveIntoCollectionRadioButton.Checked = isSelectedUserDefinedEntityCollection;
				Page.ResultEntityCollectionTextEdit.SetRequired(isSelectedUserDefinedEntityCollection);
				Page.ResultEntityCollectionTextEdit.Enabled = isSelectedUserDefinedEntityCollection;
				Page.ResultEntityCollectionEditToolButton.Enabled = isSelectedUserDefinedEntityCollection;
			}
			var userDefinedEntityCollection = df["UserDefinedEntityCollection"];
			if (userDefinedEntityCollection == null) {
				return true;
			}
			((UI.Core.Page)Page.AspPage).CustomData["UserDefinedEntityCollectionCustomDataKey"] = Json.Serialize(userDefinedEntityCollection);
			if (string.IsNullOrEmpty(userDefinedEntityCollection.Value)) {
				IsNewUserDefinedEntityCollection = true;	
			} else {
				UserDefinedEntityCollectionMetaPath = userDefinedEntityCollection.Value;
				UserDefinedEntityCollectionDisplayValue = GetPropertyDisplayPathByServerMetaPath(
					GetPropertyServerMetaPathByClientMetaPath(userDefinedEntityCollection.Value));
			}*/
			return true;
		}

		public virtual bool EntityCollectionEditToolButtonClickScriptExecute(ProcessExecutingContext context) {
			ShowSchemaStructureExplorerEditWindow(EntityCollectionMetaPath,  Page.EntityCollectionTextEdit.ClientID, "EntityCollectionEditChange");
			return true;
		}

		public virtual bool SaveNewEntityCollectionParameterValueScriptExecute(ProcessExecutingContext context) {
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

		public virtual bool ChangeEntityCollectionYesMessageScriptExecute(ProcessExecutingContext context) {
			var entityCollectionSelectedParameterValues = Json.Deserialize<Dictionary<string, object>>(NewEntityCollectionParameterValue);
			EntityCollectionSchemaUId = new Guid(entityCollectionSelectedParameterValues["referenceSchemaUId"].ToString());
			EntityCollectionMetaPath = entityCollectionSelectedParameterValues["metaPath"].ToString();
			EntityCollectionDisplayValue = entityCollectionSelectedParameterValues["caption"].ToString();
			EntityCollectionDisplayValue = GetEntityCollectionDisplayValue(EntityCollectionDisplayValue, EntityCollectionMetaPath);
			Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
			//Page.EntityCollectionTextEdit.Enabled = string.IsNullOrEmpty(EntityCollectionDisplayValue) ? true : false;
			IsNew = false;
			Page.MetaPathColumnsTreeGrid.Clear();
			var virtualDataSource = (VirtualDataSource)ReadColumnsVirtualDataSource;
			virtualDataSource.Clear();
			MetaPathColumns = null;
			EntitySchemaProcessData = null;
			//Page.EntityDataSource.Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntityCollectionSchemaUId);
			//Page.EntityDataSource.LoadStructure();
			return true;
		}

		public virtual bool ChangeEntityCollectionNoMessageScriptExecute(ProcessExecutingContext context) {
			Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
			return true;
		}

		public virtual bool SaveIntoCollectionRadioButtonCheckScriptExecute(ProcessExecutingContext context) {
			bool isSelectedUserDefinedEntityCollection = Page.SaveIntoCollectionRadioButton.Checked;
			SetUserTaskParameterConstValue("IsSelectedResultEntityCollection",
				(!isSelectedUserDefinedEntityCollection).ToString(), string.Empty);
			Page.ResultEntityCollectionTextEdit.Enabled = isSelectedUserDefinedEntityCollection;
			Page.ResultEntityCollectionTextEdit.SetRequired(isSelectedUserDefinedEntityCollection);
			Page.ResultEntityCollectionEditToolButton.Enabled = isSelectedUserDefinedEntityCollection;
			return true;
		}

		public virtual bool SaveIntoResultCollectionRadioButtonCheckScriptExecute(ProcessExecutingContext context) {
			if(Page.SaveIntoResultCollectionRadioButton.Checked){
				SetUserTaskParameterConstValue("IsSelectedResultEntityCollection",
					true.ToString(), string.Empty);
				Page.ResultEntityCollectionTextEdit.SetRequired(false);
				Page.ResultEntityCollectionTextEdit.Enabled = false;
				Page.ResultEntityCollectionEditToolButton.Enabled = false;
			}
			return true;
		}

		public virtual bool ResultEntityCollectionEditToolButtonClickScriptExecute(ProcessExecutingContext context) {
			ShowSchemaStructureExplorerEditWindow(UserDefinedEntityCollectionMetaPath, Page.ResultEntityCollectionTextEdit.ClientID, "ResultEntityCollectionEditChange");
			return true;
		}

		public virtual bool SaveNewResultEntityCollectionParameterValueScriptExecute(ProcessExecutingContext context) {
			NewUserDefinedEntityCollectionParameterValue = Json.Serialize(context.ThrowEventArgs);
			return true;
		}

		public virtual bool PrepareChangeResultEntityCollectionQuestionScriptExecute(ProcessExecutingContext context) {
			ChangeResultEntityCollectionUserMessage.Page = Page;
			ChangeResultEntityCollectionUserMessage.MessageText = ChangeSchemaEntityMessage;
			ChangeResultEntityCollectionUserMessage.Icon = "QUESTION";
			ChangeResultEntityCollectionUserMessage.Buttons = "YESNO";
			ChangeResultEntityCollectionUserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "ChangeResultEntityCollectionYesMessage"},
				{"no", "ChangeResultEntityCollectionNoMessage"},
			};
			return true;
		}

		public virtual bool ChangeResultEntityCollectionScriptExecute(ProcessExecutingContext context) {
			var entityCollectionSelectedParameterValues = Json.Deserialize<Dictionary<string, object>>(NewUserDefinedEntityCollectionParameterValue);
			UserDefinedEntityCollectionMetaPath = entityCollectionSelectedParameterValues["metaPath"].ToString();
			UserDefinedEntityCollectionDisplayValue = entityCollectionSelectedParameterValues["caption"].ToString();
			UserDefinedEntityCollectionDisplayValue = GetEntityCollectionDisplayValue(UserDefinedEntityCollectionDisplayValue, UserDefinedEntityCollectionMetaPath);
			Page.ResultEntityCollectionTextEdit.Text = UserDefinedEntityCollectionDisplayValue;
			IsNewUserDefinedEntityCollection = false;
			return true;
		}

		public virtual bool CancelChangeResultEntityCollectionScriptExecute(ProcessExecutingContext context) {
			Page.ResultEntityCollectionTextEdit.Text = UserDefinedEntityCollectionDisplayValue;
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

		public virtual VirtualDataSource CreateColumnVirtualDataSource() {
			var virtualDataSource = new VirtualDataSource() {
				ID = "VirtualDataSource"
			};
			Page.PageContainer.Controls.Add(virtualDataSource);
			ReadColumnsVirtualDataSource = virtualDataSource;
			InitializeColumnVirtualDataSourceStructure(virtualDataSource);
			return virtualDataSource;
		}

		public virtual void InitializeColumnVirtualDataSourceStructure(VirtualDataSource virtualDataSource) {
			var dataValueTypeManager = UserConnection.DataValueTypeManager;
			DataSourceStructure dataSourceStructure = virtualDataSource.DefStructure;
			dataSourceStructure.PrimaryColumnName = "Id";
			dataSourceStructure.PrimaryDisplayColumnName = "Id";
			var idColumn = new DataSourceStructureColumn {
				Name = "Id",
				DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
				IsVisible = false
			};
			dataSourceStructure.AddColumn(idColumn);
			var metaPathColumn = new DataSourceStructureColumn {
				Name = "MetaPath",
				DataValueType = dataValueTypeManager.GetInstanceByName("Text"),
				IsVisible = false
			};
			dataSourceStructure.AddColumn(metaPathColumn);
			var captionColumn = new DataSourceStructureColumn {
				Name = "Caption",
				DataValueType = dataValueTypeManager.GetInstanceByName("Text"),
				Caption = ReadColumnsVirtualDataSourcePrimaryDisplayColumnName,
				IsVisible = true
			};
			dataSourceStructure.AddColumn(captionColumn);
		}

		public virtual void ShowColumnStructureExplorerEditWindow(Guid schemaUId) {
			if (schemaUId == Guid.Empty) {
				return;
			}
			StructureExplorer columnStructureExplorer;
			if (!IsColumnStructureExplorerCreated) {
				columnStructureExplorer = CreateColumnStructureExplorer();
			} else {
				columnStructureExplorer = (StructureExplorer)ColumnStructureExplorer;	
			}
			if(!string.IsNullOrEmpty(EntitySchemaProcessData)) {
				var dataSourceStructureColumnCollection = new DataSourceStructureColumnCollection();
				EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(schemaUId);
				var entitySchemaProcessData = JsonConvert.DeserializeObject<EntitySchemaProcessData>(EntitySchemaProcessData);
				Dictionary<Guid, string> metaPathColumns = entitySchemaProcessData.ParentSchemaColumnMetaPath;
				foreach(KeyValuePair<Guid, string> columnData in metaPathColumns) {
					var dataSourceStructureColumn = new DataSourceStructureColumn();
					EntitySchemaColumn entitySchemaColumn = entitySchema.GetSchemaColumnByMetaPath(columnData.Value);
					string schemaColumnPath = entitySchema.GetSchemaColumnPathByMetaPath(columnData.Value);
					dataSourceStructureColumn.UId = columnData.Key;
					dataSourceStructureColumn.MetaPath = columnData.Value;
					dataSourceStructureColumn.Name = StringUtilities.CleanUpColumnName(schemaColumnPath);
					dataSourceStructureColumn.Caption = entitySchema.GetSchemaColumnFullCaptionByPath(schemaColumnPath);;
					dataSourceStructureColumn.DataValueType = entitySchemaColumn.DataValueType;
					dataSourceStructureColumnCollection.Add(dataSourceStructureColumn);
				}
				columnStructureExplorer.Columns = dataSourceStructureColumnCollection;
			}
			columnStructureExplorer.ShowEditWindow(schemaUId, null);
		}

		public virtual void ColumnStructureExplorer_EditComplete(object sender, AjaxEventArgs e) {
			var structureExplorerColumns = (JArray)Json.Deserialize(e.ExtraParameters["itemsInfo"]);
			EntitySchemaProcessData entitySchemaProcessData;
			if(string.IsNullOrEmpty(EntitySchemaProcessData)){
				entitySchemaProcessData = new EntitySchemaProcessData();
				entitySchemaProcessData.ParentSchemaColumnMetaPath = new Dictionary<Guid, string>();
			}
			else{
				entitySchemaProcessData = JsonConvert
					.DeserializeObject<EntitySchemaProcessData>(EntitySchemaProcessData);
			}
			EntitySchema parentSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntityCollectionSchemaUId);
			bool isModifiedEntitySchemaProcessData = false;
			Dictionary<Guid, string> processDataSchemaColumns =  entitySchemaProcessData.ParentSchemaColumnMetaPath;
			var selectedColumns = new Dictionary<Guid, string>();
			var addedColumns = new Dictionary<Guid, string>();
			var deletedColumns = new Dictionary<Guid, string>();
			foreach(var structureExplorerColumn in structureExplorerColumns) {
				bool isNotContains = true;
				var newColumnMetaPath = structureExplorerColumn["metaPath"].ToString();
				foreach(KeyValuePair<Guid, string> processDataSchemaColumn in processDataSchemaColumns) {
					if (processDataSchemaColumn.Value == newColumnMetaPath) {
						selectedColumns.Add(processDataSchemaColumn.Key, processDataSchemaColumn.Value);
						isNotContains = false;
						break;
					}
				}
				if (isNotContains) {
					//EntitySchemaColumn entitySchemaColumn = parentSchema.GetSchemaColumnByMetaPath(newColumnMetaPath);
					addedColumns.Add(Guid.NewGuid(), newColumnMetaPath);
				}
			}
			foreach(KeyValuePair<Guid, string> processDataSchemaColumn in processDataSchemaColumns) {
				if (selectedColumns.ContainsKey(processDataSchemaColumn.Key)){
					continue;
				}
				deletedColumns.Add(processDataSchemaColumn.Key, processDataSchemaColumn.Value);
			}
			
			// Validate whether columns where deleted
			/*
			if (deletedColumns.Count > 0) {
				ProcessSchema processSchema = FindDesignedProcessSchema();
				var editElements = new List<ProcessSchemaBaseElement>();
				foreach(string columnMetaPath in deletedColumns.Values) {
					editElements.AddRange(processSchema.GetProcessSchemaBaseElements(columnMetaPath));
				}
			}
			*/
			isModifiedEntitySchemaProcessData = deletedColumns.Count > 0 || addedColumns.Count > 0;
			IsModifiedEntitySchemaProcessData = IsModifiedEntitySchemaProcessData || isModifiedEntitySchemaProcessData;
			foreach(KeyValuePair<Guid, string> addedColumn in addedColumns) {
				selectedColumns.Add(addedColumn.Key, addedColumn.Value);
			}
			entitySchemaProcessData.ParentSchemaColumnMetaPath = selectedColumns;
			EntitySchemaProcessData = JsonConvert.SerializeObject(entitySchemaProcessData);
			LoadColumnVirtualDataSourceRows(selectedColumns);
		}

		public virtual StructureExplorer CreateColumnStructureExplorer() {
			// public StructureExplorer(WebControl parentControl, string key, bool isMultiSelect, bool isRootMode,
			//	string helpContextId, bool isShowStructureItemsProperties = true)
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);
			var columnStructureExplorer = new StructureExplorer(Page.TopControlLayout, "columnExplorer", true, false, string.Empty);
			columnStructureExplorer.ExcludeDataValueTypes = new string[] { "Binary", "File", "Image", "Color" };
			columnStructureExplorer.IsShowSystemColumns = true;
			columnStructureExplorer.IsShowOppositeReference = false;
			ComponentAjaxEvent editComplete = columnStructureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += ColumnStructureExplorer_EditComplete;
			editComplete.ExtraParameters.Add(param);
			columnStructureExplorer.Columns = new DataSourceStructureColumnCollection();
			IsColumnStructureExplorerCreated = true;
			if (!ColumnStructureExplorerRegistered) {
				columnStructureExplorer.Register();
				ColumnStructureExplorerRegistered = true;
			}
			ColumnStructureExplorer = columnStructureExplorer;
			return columnStructureExplorer;
		}

		public virtual DataSourceRowConfig TreeGridConfigHandler(Entity row) {
			return new DataSourceRowConfig(row.PrimaryColumnValue);
		}

		public virtual void LoadColumnVirtualDataSourceRows(Dictionary<Guid, string> processDataMetaPathColumns) {
			Page.MetaPathColumnsTreeGrid.Clear();
			var virtualDataSource = (VirtualDataSource)ReadColumnsVirtualDataSource;
			virtualDataSource.Clear();
			if (processDataMetaPathColumns.Count > 0) {
				EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
				EntitySchema entitySchema = entitySchemaManager.GetInstanceByUId(EntityCollectionSchemaUId);
				foreach(KeyValuePair<Guid, string> columnData in processDataMetaPathColumns) {
					Entity row = virtualDataSource.CreateRow();
					string metaPath = columnData.Value;
					string schemaColumnPath = entitySchema.GetSchemaColumnPathByMetaPath(metaPath);
					string schemaColumnFullCaption = entitySchema.GetSchemaColumnFullCaptionByPath(schemaColumnPath);
					row.SetColumnValue("Id", columnData.Key);
					row.SetColumnValue("Caption", schemaColumnFullCaption);
					row.SetColumnValue("MetaPath", metaPath);
					virtualDataSource.Add(row);
				}
			}
			virtualDataSource.LoadRows();
		}

		public virtual void SetUserTaskParameterConstValue(string parameterName, string value, string displayValue) {
			if (ParametersValue == null) {
				ParametersValue = new Dictionary<string, ProcessSchemaParameterValue>();
			}
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			ProcessSchemaParameterValue parameterValue = new ProcessSchemaParameterValue();
			parameterValue.ModifiedInSchemaUId = EditSchemaUId;
			parameterValue.Source = ProcessSchemaParameterValueSource.ConstValue;
			parameterValue.Value = value;
			parameterValue.DisplayValue = string.IsNullOrEmpty(displayValue) ? value : displayValue;
			if (parametersValue.ContainsKey(parameterName)) {
				parametersValue[parameterName] = parameterValue;
			} else {
				parametersValue.Add(parameterName, parameterValue);
			}
		}

		public virtual bool GetIsEqualMetaPathColumnsParameterValues(string metaPathColumnsValue1, string metaPathColumnsValue2) {
			if (metaPathColumnsValue1 != metaPathColumnsValue2) {
				return false;
			}
			/*var columns1 = JsonConvert.DeserializeObject<Dictionary<Guid, string>>(metaPathColumnsValue1);
			var columns2 = JsonConvert.DeserializeObject<Dictionary<Guid, string>>(metaPathColumnsValue2);
			foreach(var column1UId in columns1.Keys){
				string metaPathColumn1 = columns1[column1UId];
				bool isNotEqual = true;
				foreach(var column2UId in columns2.Keys) {
					string metaPathColumn2 = columns2[column2UId];
					if (metaPathColumn1 == metaPathColumn2) {
						isNotEqual = false;
						break;
					}
				}
				if (isNotEqual) {
					return false;
				}
			}*/
			return true;
			
			
			/*bool isNullOrEmptymetaPathColumnsValue1 = string.IsNullOrEmpty(metaPathColumnsValue1);
			bool isNullOrEmptymetaPathColumnsValue2 = string.IsNullOrEmpty(metaPathColumnsValue2);
			if (isNullOrEmptymetaPathColumnsValue1 && isNullOrEmptymetaPathColumnsValue2) {
				return true;
			}
			if (isNullOrEmptymetaPathColumnsValue1 || isNullOrEmptymetaPathColumnsValue2) {
				return false;
			}
			if (metaPathColumnsValue1.Length != metaPathColumnsValue2.Length) {
				return false;
			}
			char itemDelimeter = ',';
			char valueDelimeter = ':';
			string[] columns1 = metaPathColumnsValue1.Split(itemDelimeter);
			string[] columns2 = metaPathColumnsValue2.Split(itemDelimeter);
			for (int i = 0; i < columns1.Length; i++) {
				string metaPathColumn1 = columns1[i].Split(valueDelimeter)[1];
				bool isNotEqual = true;
				for (int j = 0; j < columns2.Length; j++) {
					string metaPathColumn2 = columns2[j].Split(valueDelimeter)[1];
					if (metaPathColumn1 == metaPathColumn2) {
						isNotEqual = false;
						break;
					}
				}
				if (isNotEqual) {
					return false;
				}
			}
			return true;*/
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
					case "SetColumnsMenuButtonClick":
							if (ActivatedEventElements.Contains("SetColumnsMenuButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("SetColumnsMenuButtonClickStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickChild")) {
							context.QueueTasks.Enqueue("OkButtonClickChild");
							ProcessQueue(context);
							return;
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
					case "EntityCollectionEditToolButtonClick":
							if (ActivatedEventElements.Contains("EntityCollectionEditToolButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("EntityCollectionEditToolButtonClickStartMessage");
						}
						break;
					case "EntityCollectionEditChange":
							if (ActivatedEventElements.Contains("EntityCollectionEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("EntityCollectionEditChangeStartMessage");
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
					case "SaveIntoCollectionRadioButtonCheck":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
						}
						break;
					case "SaveIntoResultCollectionRadioButtonCheck":
							if (ActivatedEventElements.Contains("StartMessage6")) {
							context.QueueTasks.Enqueue("StartMessage6");
						}
						break;
					case "ResultEntityCollectionEditToolButtonClick":
							if (ActivatedEventElements.Contains("StartMessage7")) {
							context.QueueTasks.Enqueue("StartMessage7");
						}
						break;
					case "ResultEntityCollectionEditChange":
							if (ActivatedEventElements.Contains("StartMessage8")) {
							context.QueueTasks.Enqueue("StartMessage8");
						}
						break;
					case "ChangeResultEntityCollectionYesMessage":
							if (ActivatedEventElements.Contains("ChangeResultEntityCollectionYesMessageBase")) {
							context.QueueTasks.Enqueue("ChangeResultEntityCollectionYesMessageBase");
						}
						break;
					case "ChangeResultEntityCollectionNoMessage":
							if (ActivatedEventElements.Contains("ChangeResultEntityCollectionNoMessageBase")) {
							context.QueueTasks.Enqueue("ChangeResultEntityCollectionNoMessageBase");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsModifiedEntitySchemaProcessData") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsModifiedEntitySchemaProcessData", IsModifiedEntitySchemaProcessData, false);
			}
			if (!HasMapping("EntitySchemaProcessData") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaProcessData", EntitySchemaProcessData, null);
			}
			if (!HasMapping("MetaPathColumns") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MetaPathColumns", MetaPathColumns, null);
			}
			if (!HasMapping("ColumnStructureExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerRegistered", ColumnStructureExplorerRegistered, false);
			}
			if (!HasMapping("IsColumnStructureExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsColumnStructureExplorerCreated", IsColumnStructureExplorerCreated, false);
			}
			if (ColumnStructureExplorer != null) {
				if (ColumnStructureExplorer.GetType().IsSerializable ||
					ColumnStructureExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnStructureExplorer", ColumnStructureExplorer, null);
				}
			}
			if (ReadColumnsVirtualDataSource != null) {
				if (ReadColumnsVirtualDataSource.GetType().IsSerializable ||
					ReadColumnsVirtualDataSource.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ReadColumnsVirtualDataSource", ReadColumnsVirtualDataSource, null);
				}
			}
			if (!HasMapping("UserDefinedEntityCollectionDisplayValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UserDefinedEntityCollectionDisplayValue", UserDefinedEntityCollectionDisplayValue, null);
			}
			if (!HasMapping("NewUserDefinedEntityCollectionParameterValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewUserDefinedEntityCollectionParameterValue", NewUserDefinedEntityCollectionParameterValue, null);
			}
			if (!HasMapping("IsNewUserDefinedEntityCollection") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNewUserDefinedEntityCollection", IsNewUserDefinedEntityCollection, false);
			}
			if (!HasMapping("UserDefinedEntityCollectionMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UserDefinedEntityCollectionMetaPath", UserDefinedEntityCollectionMetaPath, null);
			}
			if (!HasMapping("NewEntityCollectionParameterValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewEntityCollectionParameterValue", NewEntityCollectionParameterValue, null);
			}
			if (!HasMapping("EntityCollectionDisplayValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionDisplayValue", EntityCollectionDisplayValue, null);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("EntityCollectionSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionSchemaUId", EntityCollectionSchemaUId, Guid.Empty);
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

	#region Class: ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess : ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl>
	{

		public ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SetColumnsMenuButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SetColumnsMenuButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid MetaPathColumnsTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("MetaPathColumnsTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton SaveIntoCollectionRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("SaveIntoCollectionRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ResultEntityCollectionTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ResultEntityCollectionTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ResultEntityCollectionEditToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ResultEntityCollectionEditToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton SaveIntoResultCollectionRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("SaveIntoResultCollectionRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("EntityDataSource", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EntityCollectionEditToolButton.AjaxEvents.Click.Event += EntityCollectionEditToolButtonClick;
			SetColumnsMenuButton.AjaxEvents.Click.Event += SetColumnsMenuButtonClick;
			SaveIntoCollectionRadioButton.AjaxEvents.Check.Event += SaveIntoCollectionRadioButtonCheck;
			ResultEntityCollectionEditToolButton.AjaxEvents.Click.Event += ResultEntityCollectionEditToolButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntityCollectionEditToolButton.AjaxEvents.Click.Event -= EntityCollectionEditToolButtonClick;
			SetColumnsMenuButton.AjaxEvents.Click.Event -= SetColumnsMenuButtonClick;
			SaveIntoCollectionRadioButton.AjaxEvents.Check.Event -= SaveIntoCollectionRadioButtonCheck;
			ResultEntityCollectionEditToolButton.AjaxEvents.Click.Event -= ResultEntityCollectionEditToolButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void SetColumnsMenuButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SetColumnsMenuButtonClick");
		}

		public virtual void SaveIntoCollectionRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("SaveIntoCollectionRadioButtonCheck");
		}

		public virtual void ResultEntityCollectionEditToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ResultEntityCollectionEditToolButtonClick");
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
			SchemaName = "ReadDataIntoEntityCollectionItemsUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcess";
			UId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4");
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
			UId = new Guid("f0a9f353-8537-41af-8b82-3f842e2a94f0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EntityCollectionMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5111d3ee-3fdf-459e-8d19-ecf73a18c7eb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EntityCollectionSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2feb670b-0924-49a1-a472-9d1d8d9d9748"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionDisplayValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c5584ef9-9737-48c4-b9b7-40c9b997a9c4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EntityCollectionDisplayValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewEntityCollectionParameterValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("17c6fa96-5ffa-492b-bf89-f231a7549775"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"NewEntityCollectionParameterValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUserDefinedEntityCollectionMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8dea8fd3-fd73-4e7f-8308-54cce40b026d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"UserDefinedEntityCollectionMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewUserDefinedEntityCollectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a37482a0-e233-4669-8487-34c5f5d47f13"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IsNewUserDefinedEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewUserDefinedEntityCollectionParameterValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("798ab9ed-ce81-43a1-8c7c-59f54362e844"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"NewUserDefinedEntityCollectionParameterValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUserDefinedEntityCollectionDisplayValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("03e1ee1d-65a7-42ed-a33e-56c8ee322874"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"UserDefinedEntityCollectionDisplayValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateReadColumnsVirtualDataSourceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e1e8a5a8-b64c-4633-9164-882180fe347a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ReadColumnsVirtualDataSource",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0208a25d-156a-4507-b560-e73a869daa9f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ColumnStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsColumnStructureExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2cfc139e-3bf3-49f6-8fe9-f844216e7ee0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IsColumnStructureExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3515eef3-107e-4125-a22c-1ed3bd871244"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ColumnStructureExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMetaPathColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("793e1f5c-8f2c-43ae-a9eb-a4fedc1d3fa1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"MetaPathColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaProcessDataParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eb60f2e7-e431-4348-a570-cff116ab55cf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EntitySchemaProcessData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsModifiedEntitySchemaProcessDataParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("85adb58c-0edc-460b-a7d8-4dd5c5d1019d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IsModifiedEntitySchemaProcessData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsValidDataParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("11796826-6d5b-4124-b05b-1a32146e9820"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IsValidData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntityCollectionMetaPathParameter());
			Parameters.Add(CreateEntityCollectionSchemaUIdParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateEntityCollectionDisplayValueParameter());
			Parameters.Add(CreateNewEntityCollectionParameterValueParameter());
			Parameters.Add(CreateUserDefinedEntityCollectionMetaPathParameter());
			Parameters.Add(CreateIsNewUserDefinedEntityCollectionParameter());
			Parameters.Add(CreateNewUserDefinedEntityCollectionParameterValueParameter());
			Parameters.Add(CreateUserDefinedEntityCollectionDisplayValueParameter());
			Parameters.Add(CreateReadColumnsVirtualDataSourceParameter());
			Parameters.Add(CreateColumnStructureExplorerParameter());
			Parameters.Add(CreateIsColumnStructureExplorerCreatedParameter());
			Parameters.Add(CreateColumnStructureExplorerRegisteredParameter());
			Parameters.Add(CreateMetaPathColumnsParameter());
			Parameters.Add(CreateEntitySchemaProcessDataParameter());
			Parameters.Add(CreateIsModifiedEntitySchemaProcessDataParameter());
			Parameters.Add(CreateIsValidDataParameter());
		}

		protected virtual void InitializeChangeEntityCollectionUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("56f1770b-d489-49ad-92ae-14eb912edaca"),
				ContainerUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
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
				UId = new Guid("38edb4b0-839f-4d71-a7b3-cf3a74ea50c8"),
				ContainerUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
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
				UId = new Guid("03c8ae10-7240-4736-a24c-e53329fbb6a5"),
				ContainerUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
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
				UId = new Guid("87273616-08f3-4194-bf0c-341d82183aab"),
				ContainerUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
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
				UId = new Guid("9b6e12f6-ae90-4fb1-8b88-8e5d578a4c69"),
				ContainerUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
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
				UId = new Guid("3670679e-f142-4379-bdfa-16205d6ec566"),
				ContainerUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
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
				UId = new Guid("3f78e87b-d414-4858-b612-8da891d25787"),
				ContainerUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
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
				UId = new Guid("80bbf0c2-5105-4676-8daa-977e0c9d6f09"),
				ContainerUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
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

		protected virtual void InitializeChangeResultEntityCollectionUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("41f98960-0597-4874-9c11-285b687f1f9a"),
				ContainerUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
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
				UId = new Guid("3401ede7-b003-4192-80c6-2248ded30bc2"),
				ContainerUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
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
				UId = new Guid("0d8c5538-6321-4a89-b65a-7e8583a4bd13"),
				ContainerUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
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
				UId = new Guid("c15e3183-3861-4490-acae-5a601b560c40"),
				ContainerUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
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
				UId = new Guid("58aed575-e890-4255-9624-25d341422882"),
				ContainerUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
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
				UId = new Guid("b5b11b08-9beb-4d7b-b43b-8eccfdc3c056"),
				ContainerUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
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
				UId = new Guid("65baf5f9-e48d-487a-a04b-d099cb5c15ae"),
				ContainerUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
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
				UId = new Guid("6871e0cd-34d0-46a2-a472-e66db2699f70"),
				ContainerUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
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
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLaneInitEvents = CreateLaneInitEventsLane();
			schemaLaneSet1.Lanes.Add(schemaLaneInitEvents);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess okbuttonclickchildsubprocess = CreateOkButtonClickChildSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickchildsubprocess);
			ProcessSchemaEventSubProcess eventsubprocessoninit = CreateEventSubProcessOnInitEventSubProcess();
			FlowElements.Add(eventsubprocessoninit);
			ProcessSchemaEventSubProcess onpageloadcomplete = CreateOnPageLoadCompleteEventSubProcess();
			FlowElements.Add(onpageloadcomplete);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocesschangeentitycollectionyesmessage = CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeentitycollectionyesmessage);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaStartMessageEvent setcolumnsmenubuttonclickstartmessage = CreateSetColumnsMenuButtonClickStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(setcolumnsmenubuttonclickstartmessage);
			ProcessSchemaScriptTask setcolumnsmenubuttonclickscript = CreateSetColumnsMenuButtonClickScriptScriptTask();
			eventsubprocess2.FlowElements.Add(setcolumnsmenubuttonclickscript);
			ProcessSchemaStartMessageEvent okbuttonclickchild = CreateOkButtonClickChildStartMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(okbuttonclickchild);
			ProcessSchemaScriptTask okbuttonclickchildscript = CreateOkButtonClickChildScriptScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(okbuttonclickchildscript);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask checkdatascripttask = CreateCheckDataScriptTaskScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(checkdatascripttask);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			okbuttonclickchildsubprocess.FlowElements.Add(exclusivegateway3);
			ProcessSchemaScriptTask showwarningmessagescripttask = CreateShowWarningMessageScriptTaskScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(showwarningmessagescripttask);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			eventsubprocessoninit.FlowElements.Add(startmessageinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventinit = CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent();
			eventsubprocessoninit.FlowElements.Add(intermediatethrowmessageeventinit);
			ProcessSchemaScriptTask childinitscript = CreateChildInitScriptScriptTask();
			eventsubprocessoninit.FlowElements.Add(childinitscript);
			ProcessSchemaStartMessageEvent startmessagepageloadcomplete = CreateStartMessagePageLoadCompleteStartMessageEvent();
			onpageloadcomplete.FlowElements.Add(startmessagepageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			onpageloadcomplete.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask pageloadcompletechildscript = CreatePageLoadCompleteChildScriptScriptTask();
			onpageloadcomplete.FlowElements.Add(pageloadcompletechildscript);
			ProcessSchemaStartMessageEvent entitycollectionedittoolbuttonclickstartmessage = CreateEntityCollectionEditToolButtonClickStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(entitycollectionedittoolbuttonclickstartmessage);
			ProcessSchemaScriptTask entitycollectionedittoolbuttonclickscript = CreateEntityCollectionEditToolButtonClickScriptScriptTask();
			eventsubprocess3.FlowElements.Add(entitycollectionedittoolbuttonclickscript);
			ProcessSchemaStartMessageEvent entitycollectioneditchangestartmessage = CreateEntityCollectionEditChangeStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(entitycollectioneditchangestartmessage);
			ProcessSchemaScriptTask savenewentitycollectionparametervaluescript = CreateSaveNewEntityCollectionParameterValueScriptScriptTask();
			eventsubprocess4.FlowElements.Add(savenewentitycollectionparametervaluescript);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess4.FlowElements.Add(exclusivegateway1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess4.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaScriptTask preparechangeentitycollectionquestionscript = CreatePrepareChangeEntityCollectionQuestionScriptScriptTask();
			eventsubprocess4.FlowElements.Add(preparechangeentitycollectionquestionscript);
			ProcessSchemaUserTask changeentitycollectionusermessage = CreateChangeEntityCollectionUserMessageUserTask();
			eventsubprocess4.FlowElements.Add(changeentitycollectionusermessage);
			ProcessSchemaStartMessageEvent changeentitycollectionyesmessagebase = CreateChangeEntityCollectionYesMessageBaseStartMessageEvent();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagebase);
			ProcessSchemaScriptTask changeentitycollectionyesmessagescript = CreateChangeEntityCollectionYesMessageScriptScriptTask();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagescript);
			ProcessSchemaStartMessageEvent changeentitycollectionnomessagebase = CreateChangeEntityCollectionNoMessageBaseStartMessageEvent();
			eventsubprocess6.FlowElements.Add(changeentitycollectionnomessagebase);
			ProcessSchemaScriptTask changeentitycollectionnomessagescript = CreateChangeEntityCollectionNoMessageScriptScriptTask();
			eventsubprocess6.FlowElements.Add(changeentitycollectionnomessagescript);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess5.FlowElements.Add(startmessage5);
			ProcessSchemaScriptTask saveintocollectionradiobuttoncheckscript = CreateSaveIntoCollectionRadioButtonCheckScriptScriptTask();
			eventsubprocess5.FlowElements.Add(saveintocollectionradiobuttoncheckscript);
			ProcessSchemaStartMessageEvent startmessage6 = CreateStartMessage6StartMessageEvent();
			eventsubprocess7.FlowElements.Add(startmessage6);
			ProcessSchemaScriptTask saveintoresultcollectionradiobuttoncheckscript = CreateSaveIntoResultCollectionRadioButtonCheckScriptScriptTask();
			eventsubprocess7.FlowElements.Add(saveintoresultcollectionradiobuttoncheckscript);
			ProcessSchemaStartMessageEvent startmessage7 = CreateStartMessage7StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage7);
			ProcessSchemaScriptTask resultentitycollectionedittoolbuttonclickscript = CreateResultEntityCollectionEditToolButtonClickScriptScriptTask();
			eventsubprocess8.FlowElements.Add(resultentitycollectionedittoolbuttonclickscript);
			ProcessSchemaStartMessageEvent startmessage8 = CreateStartMessage8StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage8);
			ProcessSchemaScriptTask savenewresultentitycollectionparametervaluescript = CreateSaveNewResultEntityCollectionParameterValueScriptScriptTask();
			eventsubprocess9.FlowElements.Add(savenewresultentitycollectionparametervaluescript);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess9.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask preparechangeresultentitycollectionquestionscript = CreatePrepareChangeResultEntityCollectionQuestionScriptScriptTask();
			eventsubprocess9.FlowElements.Add(preparechangeresultentitycollectionquestionscript);
			ProcessSchemaUserTask changeresultentitycollectionusermessage = CreateChangeResultEntityCollectionUserMessageUserTask();
			eventsubprocess9.FlowElements.Add(changeresultentitycollectionusermessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent4 = CreateIntermediateThrowMessageEvent4IntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(intermediatethrowmessageevent4);
			ProcessSchemaStartMessageEvent changeresultentitycollectionyesmessagebase = CreateChangeResultEntityCollectionYesMessageBaseStartMessageEvent();
			eventsubprocess10.FlowElements.Add(changeresultentitycollectionyesmessagebase);
			ProcessSchemaScriptTask changeresultentitycollectionscript = CreateChangeResultEntityCollectionScriptScriptTask();
			eventsubprocess10.FlowElements.Add(changeresultentitycollectionscript);
			ProcessSchemaStartMessageEvent changeresultentitycollectionnomessagebase = CreateChangeResultEntityCollectionNoMessageBaseStartMessageEvent();
			eventsubprocess11.FlowElements.Add(changeresultentitycollectionnomessagebase);
			ProcessSchemaScriptTask cancelchangeresultentitycollectionscript = CreateCancelChangeResultEntityCollectionScriptScriptTask();
			eventsubprocess11.FlowElements.Add(cancelchangeresultentitycollectionscript);
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
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateValidationConditionalFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
			LocalizableStrings.Add(CreateReadColumnsVirtualDataSourcePrimaryDisplayColumnNameLocalizableString());
			LocalizableStrings.Add(CreateIsNotSelectedAnyEntityColumnsMessageLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("44c9229f-af62-4ce2-aa6f-b31aad72a1ba"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateReadColumnsVirtualDataSourcePrimaryDisplayColumnNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3346fb4f-6574-46b6-a6ff-0345c9a1a818"),
				Name = "ReadColumnsVirtualDataSourcePrimaryDisplayColumnName",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIsNotSelectedAnyEntityColumnsMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6440324f-494d-434f-a411-a8678016b5a7"),
				Name = "IsNotSelectedAnyEntityColumnsMessage",
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e2c4b2b4-f7bd-476c-9356-1ad3d7fd5a48"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("392b1df1-0121-4f90-be11-79c51fd92c1c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05a0e7dc-6025-4c1d-ad52-d78ae4d3882d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c1f53259-fd6d-4c07-904e-548d41c6ea99"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("3c7edc0e-3da9-4442-be40-b1fea209f504"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(156, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8b5ba844-90d1-40eb-9661-e4d042940565"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("abb24334-0f9e-43d4-aed3-79f733f387bf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("8981a313-29c6-453d-8a89-6a8a2f57ad75"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(284, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ecd1448d-2034-46c7-babf-d04ff73bf4d1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f68abaf3-64d9-4e29-844f-a28d028ad8fb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("2b21b7b7-bb3d-446b-aae4-420a1fa0f5cd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(158, 455),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7e9c6e47-c6cb-4f4e-b9d1-ef6d2e955251"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a508b546-e554-4bc1-843d-4c8fbfd38b60"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("ba3ad1da-f33a-4002-8643-e2e56814d39c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(247, 454),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a508b546-e554-4bc1-843d-4c8fbfd38b60"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3013e45b-2db7-449c-8e1b-0361b01e1132"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("158c40bd-bc9e-4c38-a143-3b1e29ed1d6d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(526, 448),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8d6a4616-603b-4400-91e8-572957cfea96"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6df6aaec-1be3-4013-a806-5342984a636b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("2b13fc2d-5d6c-47a7-b490-749fc4b0f304"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(620, 446),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6df6aaec-1be3-4013-a806-5342984a636b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8836bc0f-6c0d-4ccf-b48d-a52ca52a5a83"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("a7f3fc19-4744-4705-84ee-2f014f2ce563"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(416, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0e840b83-7641-43de-91af-342851dce369"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f59b04b-40cf-48f6-badf-b078875be593"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("da213a3b-8c4c-479b-a2ec-e878d8f2993b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(467, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("65e50457-7c57-4c22-b612-c12182ca86a0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4fa84ee-23c7-46bd-8a93-8b602bd09be8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("0b8e05cf-d880-4d2f-8f0d-18182013f25e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(604, 175),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b4fa84ee-23c7-46bd-8a93-8b602bd09be8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("01a38258-db8f-4095-a979-77e960828022"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("6c363022-1d11-46a9-ba68-23abeab8a3b5"),
				ConditionExpression = @"!IsNew",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(708, 116),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01a38258-db8f-4095-a979-77e960828022"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("342d3a60-b4fc-4eb4-9d21-4cbdf5ceed13"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow11",
				UId = new Guid("2d52d3c7-07f2-4acc-a6aa-98a754b8c45c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(718, 241),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01a38258-db8f-4095-a979-77e960828022"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3fa2f4e3-0b89-4cb5-88af-b066269dcab7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("055b8bd5-8882-43aa-a557-ab906b14151e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(857, 83),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("342d3a60-b4fc-4eb4-9d21-4cbdf5ceed13"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("9b0a804c-09cb-4dc2-abf2-9deab3059dd8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(182, 463),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bae626b1-5c5d-439a-9c86-c708725fda42"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a8e37a72-0bf4-4cec-97e8-2241cd57ac38"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("6b7e5f1c-7258-4491-9316-2bdafd2902a2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(496, 462),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c56307a-d472-4055-ba4e-adb56e35634d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("150dfb18-8d62-4694-a60b-669be022e250"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("8263b882-9ac4-496e-a924-8935230fd2a0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("024c3628-8600-42b4-a5fc-014973d14fea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a08deab7-5ee1-4297-adea-4b6ab2de75ca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("9c05ac46-f54a-4240-99f3-16c9fc2d9a24"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a7d22f38-26d6-4d81-91da-16b3e4eab9ec"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("05eb1c1c-116d-415f-a051-6c8a22534d6c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("a8c0957c-9b94-4aa2-8f08-0275ef721b7d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8bc3c605-7f4e-49a6-8f29-af1675a0793f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a69de0fd-bf37-416b-8589-2f2e15ae94bb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("986294cd-9434-47c2-aece-ab8ca3d89b43"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(184, 882),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ed241270-dcea-4e4a-9bd8-58c297b96100"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("86de6d66-9bf5-400a-ac78-990b1a8b75a0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("c772fa32-f2e9-4530-8c3c-49fac29d2de0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(336, 876),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("86de6d66-9bf5-400a-ac78-990b1a8b75a0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87756328-94b6-4613-b11d-2ddd3fb41bf7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("af5b6ddd-3312-418a-ba2d-ce8ea71a6dff"),
				ConditionExpression = @"!IsNewUserDefinedEntityCollection",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(434, 816),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("87756328-94b6-4613-b11d-2ddd3fb41bf7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9139dfaa-e557-4c6e-a272-4fac42172f8a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("46211cd4-7aa7-4690-a630-b70aeb3d2105"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(580, 782),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9139dfaa-e557-4c6e-a272-4fac42172f8a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow21",
				UId = new Guid("46b66321-3ad3-46bb-8f05-d781f6456cdb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(424, 928),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("87756328-94b6-4613-b11d-2ddd3fb41bf7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb24bdea-970f-4487-9d0d-a6adf7e070a2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("8a851c16-0b67-4903-a119-c3d3346fcaa6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(839, 806),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e3914f6-8d78-4ad5-bd0c-2f43045dca88"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("251a04a7-3f9a-474b-8b54-1eb1db6b60e7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("c1440877-f606-47d7-a690-498938223d70"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(839, 982),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("08950a5b-46be-4983-8d75-2c2ab2227e4f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("efff1762-1cf3-4a41-88a5-028412aa733d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("a5591aad-318c-4a25-9cb4-6c5f21283437"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(156, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("abb24334-0f9e-43d4-aed3-79f733f387bf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("26653e05-8532-471c-a0e1-67275daa3b90"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateValidationConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ValidationConditionalFlow",
				UId = new Guid("50b89e59-99e1-4b49-9aab-74598979b540"),
				ConditionExpression = @" IsValidData",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(448, 985),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("26653e05-8532-471c-a0e1-67275daa3b90"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ecd1448d-2034-46c7-babf-d04ff73bf4d1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow25",
				UId = new Guid("32241e57-426b-436b-a824-95bdb9d18a24"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CurveCenterPosition = new Point(410, 1068),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("26653e05-8532-471c-a0e1-67275daa3b90"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9c89231c-c1db-42e7-8f04-3a20ccf3e840"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a1cf9249-d3a9-46d4-8d79-61d5385ae216"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1165, 1371),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("a1cf9249-d3a9-46d4-8d79-61d5385ae216"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"Lane1",
				Position = new Point(29, 29),
				Size = new Size(1136, 861),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("26d163d6-3bcf-4fff-a1a8-cb2844a7bac5"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("a1cf9249-d3a9-46d4-8d79-61d5385ae216"),
				CreatedInOwnerSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 895),
				Size = new Size(1136, 292),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLaneInitEventsLane() {
			ProcessSchemaLane schemaLaneInitEvents = new ProcessSchemaLane(this) {
				UId = new Guid("c8e96493-5b5a-440d-a048-3daa17aeddff"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("a1cf9249-d3a9-46d4-8d79-61d5385ae216"),
				CreatedInOwnerSchemaUId = new Guid("229dd423-b654-461f-8eff-e779b3289d85"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"LaneInitEvents",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 1192),
				Size = new Size(1136, 179),
				UseBackgroundMode = false
			};
			return schemaLaneInitEvents;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("937116ed-162b-49d0-a2c3-9627def014f5"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a1cf9249-d3a9-46d4-8d79-61d5385ae216"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"Lane3",
				Position = new Point(29, 0),
				Size = new Size(1136, 165),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b1e1c031-772f-4072-b113-3a6c63da1d05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess2",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(283, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSetColumnsMenuButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("05a0e7dc-6025-4c1d-ad52-d78ae4d3882d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1e1c031-772f-4072-b113-3a6c63da1d05"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SetColumnsMenuButtonClick",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"SetColumnsMenuButtonClickStartMessage",
				Position = new Point(28, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetColumnsMenuButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c1f53259-fd6d-4c07-904e-548d41c6ea99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1e1c031-772f-4072-b113-3a6c63da1d05"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"SetColumnsMenuButtonClickScript",
				Position = new Point(126, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,206,200,47,119,206,207,41,205,205,11,46,41,42,77,46,41,45,74,117,173,40,200,201,47,74,45,114,77,201,44,9,207,204,75,201,47,215,112,205,43,201,44,169,4,170,203,73,77,46,201,204,207,11,78,206,72,205,77,12,245,76,209,180,230,229,42,74,5,234,202,83,0,106,79,181,6,0,97,152,109,99,79,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOkButtonClickChildSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOkButtonClickChildSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("79fe864f-8b33-49d2-a91b-4c59c8506d16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("26d163d6-3bcf-4fff-a1a8-cb2844a7bac5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"OkButtonClickChildSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(636, 278),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOkButtonClickChildSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8b5ba844-90d1-40eb-9661-e4d042940565"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79fe864f-8b33-49d2-a91b-4c59c8506d16"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"OkButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 115),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ecd1448d-2034-46c7-babf-d04ff73bf4d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79fe864f-8b33-49d2-a91b-4c59c8506d16"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"OkButtonClickChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(365, 17),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,81,111,218,48,16,126,94,165,254,7,139,167,164,66,238,251,90,58,77,192,38,54,65,171,2,221,195,212,7,55,28,173,167,196,142,108,135,142,77,251,239,187,196,9,132,224,152,108,211,30,227,220,125,247,125,119,159,207,227,24,18,16,102,6,175,67,150,26,46,5,25,144,59,246,12,116,193,77,12,227,21,55,116,1,223,205,213,249,217,134,41,34,164,128,135,121,30,162,100,4,90,207,163,23,72,216,29,83,44,1,3,234,129,197,25,204,101,166,34,160,51,12,45,179,34,41,180,233,152,54,44,98,243,131,50,57,97,105,202,197,115,199,244,169,141,46,115,211,42,68,23,49,133,180,195,19,166,201,136,71,185,110,166,182,215,218,40,76,238,251,234,220,32,52,95,147,224,8,122,64,68,22,199,33,249,121,126,246,166,89,101,224,136,39,2,94,255,180,118,16,134,88,254,151,21,135,83,227,102,59,148,113,12,81,57,184,79,90,10,58,2,13,138,179,152,255,128,107,47,88,16,44,64,41,166,229,218,208,229,132,126,129,39,108,190,81,50,214,52,119,64,88,216,224,189,78,139,15,58,204,180,145,201,136,25,246,181,55,110,148,222,255,251,12,219,222,35,93,200,121,161,198,242,109,18,165,85,7,154,48,83,48,72,210,188,184,114,166,114,197,215,28,86,19,97,197,44,39,171,28,1,253,185,251,118,165,89,91,96,164,109,47,157,232,25,78,233,86,141,147,212,108,131,54,2,225,187,202,233,111,247,254,115,193,223,195,26,20,136,8,14,72,53,162,234,4,27,54,56,110,101,239,17,17,154,117,48,177,62,243,114,156,118,182,121,215,203,209,227,248,54,160,76,221,1,183,79,223,16,226,122,236,206,187,9,90,126,236,199,118,244,11,189,129,138,77,87,193,245,2,83,38,208,74,135,42,170,179,1,89,34,105,84,32,202,214,58,18,27,112,100,195,149,201,88,60,218,10,150,240,168,60,28,184,224,241,78,210,15,18,157,240,17,74,230,65,139,188,62,153,232,202,107,127,209,156,122,91,92,244,168,237,138,117,35,217,141,169,173,84,99,176,243,195,177,182,105,8,93,70,187,7,157,197,166,165,78,225,186,124,33,121,22,70,96,119,91,135,139,216,199,176,46,23,239,152,56,169,93,188,242,213,200,193,170,133,113,178,95,184,28,79,105,111,92,181,255,35,186,198,221,185,34,78,218,199,10,81,96,50,37,136,81,197,107,120,121,145,175,128,12,155,48,130,53,23,85,19,254,233,5,192,189,63,148,10,28,11,63,191,50,245,157,191,108,175,235,95,255,30,194,187,151,192,3,94,123,20,124,72,221,222,7,31,130,223,177,29,24,182,189,26,71,118,244,96,21,158,244,176,188,186,184,252,13,18,251,182,153,178,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f68abaf3-64d9-4e29-844f-a28d028ad8fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79fe864f-8b33-49d2-a91b-4c59c8506d16"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(491, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckDataScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("abb24334-0f9e-43d4-aed3-79f733f387bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79fe864f-8b33-49d2-a91b-4c59c8506d16"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"CheckDataScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 101),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,14,75,204,201,76,113,73,44,73,84,176,85,80,44,46,41,202,204,75,215,243,44,246,43,205,201,241,47,114,205,45,40,169,212,112,205,43,201,44,169,12,78,206,72,205,77,12,40,202,79,78,45,46,6,169,215,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,185,143,214,116,75,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("26653e05-8532-471c-a0e1-67275daa3b90"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79fe864f-8b33-49d2-a91b-4c59c8506d16"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 101),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateShowWarningMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9c89231c-c1db-42e7-8f04-3a20ccf3e840"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79fe864f-8b33-49d2-a91b-4c59c8506d16"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("9df86e06-96f1-4a0a-9af0-669aea7ea95c"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ShowWarningMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(365, 178),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,141,177,10,194,64,16,68,123,193,127,184,50,66,184,31,72,21,130,133,69,228,32,162,245,226,13,97,97,221,147,187,189,226,254,94,133,164,179,155,199,188,97,2,173,240,51,177,206,40,229,155,3,41,196,79,2,202,221,105,56,30,194,223,126,140,113,227,238,78,194,145,140,211,110,220,216,4,189,187,148,107,178,5,130,167,33,142,218,206,106,108,109,74,82,95,90,54,181,119,251,166,189,225,31,148,149,117,253,189,102,88,205,234,44,87,12,31,44,159,18,163,162,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessOnInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessOnInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1a8eb83f-6216-454e-a044-9f810846dae6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8e96493-5b5a-440d-a048-3daa17aeddff"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcessOnInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 129),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessOnInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7e9c6e47-c6cb-4f4e-b9d1-ef6d2e955251"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a8eb83f-6216-454e-a044-9f810846dae6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"StartMessageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a508b546-e554-4bc1-843d-4c8fbfd38b60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a8eb83f-6216-454e-a044-9f810846dae6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IntermediateThrowMessageEventInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3013e45b-2db7-449c-8e1b-0361b01e1132"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a8eb83f-6216-454e-a044-9f810846dae6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChildInitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,219,110,219,48,12,125,110,128,254,131,215,39,27,11,252,3,93,6,36,142,215,25,104,186,32,78,179,103,214,166,19,109,178,228,73,116,46,24,246,239,163,236,56,151,185,217,147,37,226,156,67,242,144,178,40,252,196,70,90,214,165,74,201,212,25,213,6,227,125,37,181,65,19,25,4,194,60,248,125,63,184,107,207,55,128,126,240,120,63,248,115,63,88,9,67,53,200,41,16,164,186,54,25,122,219,94,100,228,93,74,245,24,141,212,210,32,62,25,145,123,212,29,70,222,28,214,24,206,144,96,14,180,105,201,182,195,49,165,67,134,233,70,239,198,53,233,239,34,167,205,12,85,205,220,2,164,197,127,65,179,90,146,120,22,10,255,7,74,235,178,4,35,208,222,2,37,214,193,190,85,149,182,130,112,129,5,26,84,77,155,61,104,172,224,77,114,223,138,112,79,183,245,142,189,117,222,46,180,166,153,206,157,34,219,126,133,93,106,45,223,192,172,132,21,44,252,158,218,217,215,196,121,216,155,70,152,76,47,225,79,72,11,189,227,10,11,177,254,10,42,151,104,152,213,185,124,21,103,90,95,237,89,67,142,185,247,113,228,93,85,208,134,153,33,10,207,255,16,239,137,187,28,255,128,253,2,127,213,104,41,240,220,130,205,193,64,137,132,198,49,86,32,107,92,30,42,124,109,234,126,181,188,140,90,41,204,72,104,21,94,33,102,160,120,51,140,171,61,33,44,39,135,23,150,241,31,98,69,130,14,236,165,108,73,87,156,135,32,100,225,199,38,43,111,213,82,144,196,56,23,20,46,121,50,156,47,150,88,162,162,23,220,69,80,57,182,131,110,193,120,57,22,141,136,101,208,20,11,224,21,58,222,193,122,83,209,100,2,115,248,100,201,8,181,30,122,115,163,51,180,54,205,54,88,194,169,195,134,242,217,105,78,209,138,181,114,227,141,36,88,203,215,204,136,138,180,203,116,58,186,84,167,139,203,115,139,228,20,191,8,41,57,107,133,134,14,23,175,170,253,12,47,100,131,174,167,170,135,118,175,173,31,228,204,189,215,234,52,250,252,48,69,138,164,96,7,199,236,200,22,121,167,154,103,125,55,17,42,119,62,107,99,125,158,215,241,232,162,236,150,31,12,223,169,101,120,246,60,56,13,44,133,45,38,138,244,121,188,11,200,133,158,212,68,188,30,209,6,179,159,152,159,31,12,255,153,12,242,255,74,181,129,191,79,8,215,61,243,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOnPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOnPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("28958f3d-7490-405f-892a-fe6b75f90f9c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8e96493-5b5a-440d-a048-3daa17aeddff"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"OnPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(299, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOnPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8d6a4616-603b-4400-91e8-572957cfea96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28958f3d-7490-405f-892a-fe6b75f90f9c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"StartMessagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("6df6aaec-1be3-4013-a806-5342984a636b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28958f3d-7490-405f-892a-fe6b75f90f9c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8836bc0f-6c0d-4ccf-b48d-a52ca52a5a83"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28958f3d-7490-405f-892a-fe6b75f90f9c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"PageLoadCompleteChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(189, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,77,115,218,48,16,61,147,153,252,7,37,39,59,195,152,123,9,233,148,143,102,232,87,24,32,233,161,147,131,192,75,162,214,88,84,146,147,186,157,252,247,174,36,131,141,141,133,155,233,133,16,180,251,222,219,213,238,106,71,177,98,42,29,240,40,130,165,98,60,254,12,138,78,168,122,36,61,34,149,96,241,67,48,90,111,84,218,61,61,25,149,44,135,76,110,34,154,222,209,40,129,170,245,173,4,49,132,21,139,33,44,59,214,83,56,156,220,108,79,84,16,185,124,132,53,197,179,247,44,14,135,32,217,3,194,76,4,95,130,148,51,115,230,249,153,105,184,66,51,36,162,73,164,12,162,36,84,146,33,51,76,84,164,151,22,190,77,246,220,39,84,208,53,40,16,198,229,10,177,216,138,120,26,171,71,226,36,138,124,242,231,244,164,37,64,37,34,38,74,36,128,22,47,150,16,74,209,32,125,184,250,118,94,14,242,252,62,3,173,218,59,41,44,78,166,210,74,30,82,69,51,218,202,239,232,228,121,115,16,130,74,190,82,193,237,56,248,10,139,1,143,149,224,145,12,38,244,1,124,253,17,188,147,27,243,79,48,72,164,226,107,237,90,213,156,159,125,132,244,252,30,35,251,32,121,28,204,64,48,26,177,223,80,137,197,175,137,49,152,194,10,4,196,75,176,130,111,199,33,57,235,145,235,132,133,246,158,109,240,101,254,220,184,87,73,243,1,200,238,1,136,66,65,86,16,204,93,31,114,42,21,228,53,40,204,240,6,132,74,179,19,141,216,79,49,15,79,32,182,12,94,193,108,255,164,159,14,34,134,236,59,203,195,74,124,157,189,150,185,29,43,72,39,126,198,19,177,132,160,152,137,218,44,53,11,197,101,225,185,14,219,21,230,109,64,101,225,185,197,28,126,169,81,200,84,160,191,28,208,94,196,215,32,157,142,27,102,20,211,69,4,97,62,37,198,242,11,246,206,141,48,85,228,148,239,147,183,166,173,200,27,178,162,145,52,116,142,25,64,4,72,28,33,117,237,103,155,124,234,178,49,29,223,170,233,211,172,151,176,51,177,80,84,128,51,109,219,84,55,139,239,40,254,178,6,244,202,115,234,202,42,73,143,14,2,24,164,105,43,204,17,60,35,97,54,84,28,146,98,180,171,65,246,108,139,182,138,149,104,250,23,177,245,95,207,111,235,99,76,34,194,91,35,188,135,100,93,236,64,13,95,152,196,218,173,157,93,228,149,231,163,251,139,157,121,157,206,214,201,66,200,82,182,102,251,185,242,106,2,10,234,197,232,12,125,226,52,180,191,222,49,161,18,26,229,253,54,229,207,242,149,168,245,5,243,138,8,52,96,231,66,191,50,76,206,64,23,53,132,197,154,203,43,125,87,188,89,101,142,143,216,103,207,145,215,28,247,44,123,166,116,21,44,56,143,142,74,66,37,219,112,231,188,143,30,64,227,230,124,121,37,219,201,50,163,79,48,142,21,183,110,185,195,148,134,140,247,19,165,112,140,14,30,97,249,195,76,135,99,52,221,106,16,142,5,5,1,207,154,32,238,9,109,46,209,193,188,67,61,76,186,155,139,51,80,83,248,153,48,1,161,215,8,216,111,138,156,79,220,255,33,88,67,206,49,239,89,54,254,29,60,91,186,18,231,101,233,6,112,192,236,86,49,39,138,115,43,243,60,220,172,6,92,192,177,149,202,33,227,232,118,229,144,183,93,180,14,190,130,14,191,237,166,145,191,11,238,178,55,17,183,246,94,147,102,219,255,81,13,93,55,212,235,86,48,253,2,53,95,195,26,228,73,223,246,69,231,244,164,88,0,127,1,213,123,31,68,87,13,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("67934257-77dd-41f5-a6b1-031bf9662070"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 169),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntityCollectionEditToolButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0e840b83-7641-43de-91af-342851dce369"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67934257-77dd-41f5-a6b1-031bf9662070"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EntityCollectionEditToolButtonClick",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EntityCollectionEditToolButtonClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEntityCollectionEditToolButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2f59b04b-40cf-48f6-badf-b078875be593"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67934257-77dd-41f5-a6b1-031bf9662070"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EntityCollectionEditToolButtonClickScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,49,10,195,48,16,4,251,64,254,32,92,37,96,252,1,151,138,138,20,1,131,12,169,133,188,88,7,202,93,56,206,216,249,125,236,214,245,236,176,19,139,172,49,23,124,82,52,93,178,45,138,176,125,171,40,52,76,100,111,226,73,214,91,96,35,251,121,169,21,217,72,248,5,75,67,178,210,58,55,164,25,221,153,143,216,236,208,59,95,9,108,207,71,235,154,243,230,224,190,36,158,209,220,251,235,69,177,127,179,219,35,208,255,1,166,17,248,117,149,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7faa730b-446d-4e43-ad85-15e769722bdf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 8),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(625, 336),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntityCollectionEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("65e50457-7c57-4c22-b612-c12182ca86a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7faa730b-446d-4e43-ad85-15e769722bdf"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EntityCollectionEditChange",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EntityCollectionEditChangeStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveNewEntityCollectionParameterValueScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b4fa84ee-23c7-46bd-8a93-8b602bd09be8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7faa730b-446d-4e43-ad85-15e769722bdf"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"SaveNewEntityCollectionParameterValueScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 135),
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
				UId = new Guid("01a38258-db8f-4095-a979-77e960828022"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7faa730b-446d-4e43-ad85-15e769722bdf"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 135),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3fa2f4e3-0b89-4cb5-88af-b066269dcab7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7faa730b-446d-4e43-ad85-15e769722bdf"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 254),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareChangeEntityCollectionQuestionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("342d3a60-b4fc-4eb4-9d21-4cbdf5ceed13"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7faa730b-446d-4e43-ad85-15e769722bdf"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"PrepareChangeEntityCollectionQuestionScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(379, 44),
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
				UId = new Guid("ac7f02d6-d2bd-47f9-9175-42a7f6a7ef7f"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7faa730b-446d-4e43-ad85-15e769722bdf"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChangeEntityCollectionUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(519, 44),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeEntityCollectionUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeEntityCollectionYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ceed82be-cec4-4614-a407-d54b152da5e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcessChangeEntityCollectionYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(567, 357),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(217, 126),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeEntityCollectionYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionYesMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bae626b1-5c5d-439a-9c86-c708725fda42"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceed82be-cec4-4614-a407-d54b152da5e9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChangeEntityCollectionYesMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionYesMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a8e37a72-0bf4-4cec-97e8-2241cd57ac38"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceed82be-cec4-4614-a407-d54b152da5e9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChangeEntityCollectionYesMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,77,79,195,48,12,134,239,72,252,135,136,83,43,161,238,206,167,196,90,77,67,124,84,116,112,65,28,188,214,64,80,154,76,78,58,40,191,30,167,29,101,43,80,109,183,124,248,125,94,199,177,151,64,2,181,147,174,30,27,165,48,119,210,232,12,253,2,139,20,8,74,116,72,15,160,42,180,226,84,92,90,163,163,24,45,146,4,37,63,241,36,150,141,2,168,62,177,142,164,126,57,20,102,254,198,234,179,179,224,6,223,147,30,121,147,24,30,239,239,245,35,178,252,21,75,184,159,22,236,166,241,93,76,42,89,4,91,38,248,120,64,248,140,132,58,199,14,115,240,20,205,76,214,164,22,132,127,25,94,163,131,20,220,43,251,109,109,83,174,52,27,240,63,216,177,180,11,5,117,35,219,133,159,195,194,223,239,136,159,160,27,138,8,134,46,15,197,127,117,241,198,41,188,96,212,15,152,225,135,75,10,233,34,191,96,251,33,60,51,70,163,97,74,162,97,174,208,127,123,219,72,209,212,222,84,74,221,82,82,46,92,61,152,124,40,206,133,35,174,193,145,120,6,101,189,27,139,185,121,78,187,125,227,253,253,36,166,84,165,182,51,66,156,144,44,162,177,66,160,166,194,75,158,134,165,36,87,129,138,193,65,102,42,202,125,105,131,135,254,97,120,135,80,172,64,191,46,61,169,127,182,230,210,203,195,119,58,191,180,251,224,182,119,83,50,57,90,235,1,63,1,27,69,92,99,183,18,142,187,231,209,28,27,173,219,34,69,235,192,107,208,172,165,136,219,100,170,173,3,158,146,139,154,39,228,87,105,187,217,9,7,28,175,12,20,220,154,85,238,42,194,230,85,132,188,212,205,71,28,127,1,249,6,244,206,86,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4d153a60-0a6f-4e4a-8e32-fc86e3c50e0b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 358),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionNoMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5c56307a-d472-4055-ba4e-adb56e35634d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d153a60-0a6f-4e4a-8e32-fc86e3c50e0b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionNoMessage",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChangeEntityCollectionNoMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionNoMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("150dfb18-8d62-4694-a60b-669be022e250"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d153a60-0a6f-4e4a-8e32-fc86e3c50e0b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChangeEntityCollectionNoMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,11,73,173,40,113,77,201,44,209,3,49,20,108,21,208,229,93,50,139,11,114,18,43,195,18,115,74,83,173,121,185,138,82,75,74,139,242,20,74,138,128,60,0,226,252,1,62,80,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b22df098-35af-482f-b9a3-709c15541e4d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("937116ed-162b-49d0-a2c3-9627def014f5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess5",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(258, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("024c3628-8600-42b4-a5fc-014973d14fea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b22df098-35af-482f-b9a3-709c15541e4d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SaveIntoCollectionRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"StartMessage5",
				Position = new Point(42, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveIntoCollectionRadioButtonCheckScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a08deab7-5ee1-4297-adea-4b6ab2de75ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b22df098-35af-482f-b9a3-709c15541e4d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"SaveIntoCollectionRadioButtonCheckScript",
				Position = new Point(147, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,193,138,194,64,16,68,207,10,254,195,232,41,1,153,31,16,47,27,115,240,38,73,220,251,232,148,58,100,236,214,153,30,209,191,223,68,196,133,101,89,178,183,134,130,122,85,213,59,102,175,92,172,225,177,23,216,109,68,88,225,224,8,182,36,113,242,40,216,247,138,99,82,75,181,49,71,232,218,220,176,38,225,111,165,50,214,241,71,18,97,210,197,9,251,22,118,49,25,215,144,222,173,49,177,221,152,96,206,16,132,130,41,202,167,241,9,217,108,253,134,86,136,201,203,79,222,108,62,25,143,178,233,160,108,185,110,184,150,224,232,152,229,115,21,159,151,46,207,23,121,228,93,146,103,236,223,33,13,238,82,90,39,186,36,179,243,176,93,201,65,192,129,174,221,6,21,174,201,5,216,108,88,145,191,141,123,211,166,251,216,107,236,255,135,14,144,20,72,73,72,88,124,1,192,248,164,189,251,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b922a36f-9dd6-4e7d-aa24-697815e9ca8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("937116ed-162b-49d0-a2c3-9627def014f5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess7",
				Position = new Point(337, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(263, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a7d22f38-26d6-4d81-91da-16b3e4eab9ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b922a36f-9dd6-4e7d-aa24-697815e9ca8c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SaveIntoResultCollectionRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"StartMessage6",
				Position = new Point(42, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveIntoResultCollectionRadioButtonCheckScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("05eb1c1c-116d-415f-a051-6c8a22534d6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b922a36f-9dd6-4e7d-aa24-697815e9ca8c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"SaveIntoResultCollectionRadioButtonCheckScript",
				Position = new Point(154, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,177,10,194,64,16,68,107,5,255,33,88,37,32,247,3,98,99,72,97,39,73,180,95,189,81,15,207,91,189,219,19,69,252,119,147,40,88,40,104,183,197,188,199,204,154,77,58,167,45,84,69,103,204,156,112,137,16,173,228,108,45,214,98,216,149,164,13,79,163,8,59,149,239,176,222,67,103,183,65,191,87,65,22,1,190,166,176,159,147,167,3,4,62,103,23,100,73,54,34,29,206,66,133,86,1,253,52,22,78,140,92,223,222,225,168,145,244,196,71,168,154,43,241,198,109,211,108,148,132,238,82,197,225,40,215,108,220,68,186,114,223,21,53,46,82,104,35,170,233,82,226,20,141,135,78,55,100,3,254,38,11,71,43,11,157,76,146,142,251,129,181,72,205,108,95,239,248,132,239,131,190,135,68,239,146,118,216,248,1,146,201,169,113,92,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f6e2ee2e-818d-4134-bc50-e1ffef417ea3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 337),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(256, 161),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage7StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8bc3c605-7f4e-49a6-8f29-af1675a0793f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6e2ee2e-818d-4134-bc50-e1ffef417ea3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ResultEntityCollectionEditToolButtonClick",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"StartMessage7",
				Position = new Point(42, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateResultEntityCollectionEditToolButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a69de0fd-bf37-416b-8589-2f2e15ae94bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6e2ee2e-818d-4134-bc50-e1ffef417ea3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ResultEntityCollectionEditToolButtonClickScript",
				Position = new Point(147, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,206,177,10,194,48,20,70,225,93,240,29,66,39,133,210,23,232,152,102,112,16,138,81,156,67,242,219,92,136,55,37,189,165,245,237,109,87,113,255,56,28,27,243,98,125,196,219,89,41,179,151,185,192,172,99,202,5,197,4,146,39,113,200,203,233,49,161,116,120,17,35,24,22,146,143,206,41,193,11,101,190,66,92,239,36,214,170,119,3,154,27,166,57,201,47,186,99,149,61,215,232,68,96,185,116,181,170,254,203,93,233,232,120,64,117,110,143,135,130,237,136,213,182,134,246,11,30,98,50,169,171,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("35cb520e-2d46-4b86-8b88-2899040ce9a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 512),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(627, 316),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage8StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ed241270-dcea-4e4a-9bd8-58c297b96100"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35cb520e-2d46-4b86-8b88-2899040ce9a9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ResultEntityCollectionEditChange",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"StartMessage8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveNewResultEntityCollectionParameterValueScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("86de6d66-9bf5-400a-ac78-990b1a8b75a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35cb520e-2d46-4b86-8b88-2899040ce9a9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"SaveNewResultEntityCollectionParameterValueScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,5,193,49,10,194,64,16,5,208,94,240,14,91,106,147,11,4,11,209,52,22,34,68,237,151,248,213,129,117,6,254,254,53,234,233,125,239,136,249,82,193,61,238,230,184,13,46,211,119,23,165,96,146,133,159,50,243,11,2,175,185,52,164,77,58,212,240,110,4,45,23,251,97,53,133,11,31,117,231,39,99,30,222,112,109,249,168,235,126,185,32,212,232,73,108,232,255,81,31,234,229,100,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("87756328-94b6-4613-b11d-2ddd3fb41bf7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35cb520e-2d46-4b86-8b88-2899040ce9a9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareChangeResultEntityCollectionQuestionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9139dfaa-e557-4c6e-a272-4fac42172f8a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35cb520e-2d46-4b86-8b88-2899040ce9a9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"PrepareChangeResultEntityCollectionQuestionScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,207,177,14,130,48,16,6,224,89,18,222,161,233,76,124,1,212,65,100,96,16,84,96,96,36,228,2,36,120,53,237,53,74,8,239,110,129,14,78,42,75,255,52,189,239,191,52,104,74,172,225,6,74,119,20,34,181,212,7,162,235,160,162,86,96,174,64,158,65,169,178,134,237,197,28,108,207,166,240,93,39,248,83,217,204,224,69,6,47,42,173,26,184,151,139,178,239,43,26,163,74,160,169,226,215,60,76,179,40,137,249,10,123,212,68,2,213,196,139,48,141,147,53,214,76,60,140,5,123,159,74,16,158,236,212,206,147,165,236,119,138,100,139,181,199,150,60,176,193,117,54,3,239,65,113,143,241,111,107,10,80,182,149,143,222,140,80,252,50,177,248,36,163,249,136,4,210,18,25,73,13,254,27,98,162,97,80,213,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeResultEntityCollectionUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1c1b9e6c-a82c-44dd-bb8a-8893cff18bd7"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35cb520e-2d46-4b86-8b88-2899040ce9a9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChangeResultEntityCollectionUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(526, 28),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeResultEntityCollectionUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent4IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("bb24bdea-970f-4487-9d0d-a6adf7e070a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35cb520e-2d46-4b86-8b88-2899040ce9a9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeResultEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"IntermediateThrowMessageEvent4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 231),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f1edd0aa-ff8e-415a-8560-6574ddf2397f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(679, 518),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(268, 162),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeResultEntityCollectionYesMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9e3914f6-8d78-4ad5-bd0c-2f43045dca88"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1edd0aa-ff8e-415a-8560-6574ddf2397f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeResultEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChangeResultEntityCollectionYesMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeResultEntityCollectionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("251a04a7-3f9a-474b-8b54-1eb1db6b60e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1edd0aa-ff8e-415a-8560-6574ddf2397f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChangeResultEntityCollectionScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,205,74,3,65,16,132,239,130,239,48,228,180,66,216,23,48,230,146,13,162,160,44,230,231,18,60,116,178,149,216,50,153,9,61,189,234,230,233,51,179,120,81,97,221,228,214,208,85,245,21,221,31,36,6,78,89,155,137,183,22,27,101,239,102,72,3,170,146,132,246,80,200,146,108,141,96,238,204,99,240,46,47,16,32,76,150,143,24,21,220,58,72,154,81,80,97,183,27,26,191,126,143,238,241,56,123,198,231,34,42,11,108,217,161,154,254,130,252,12,191,185,189,190,234,16,63,65,169,36,125,139,21,122,150,93,13,246,223,158,193,107,62,247,179,182,92,246,15,166,224,112,176,212,180,9,231,160,54,116,72,251,203,73,247,208,46,69,214,51,105,104,122,220,48,53,43,105,135,252,5,161,182,127,184,115,124,233,180,98,205,211,16,171,245,68,199,208,135,208,253,241,24,182,37,27,146,84,160,181,56,163,18,141,39,207,232,41,159,130,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b83717ae-1946-482b-901e-61d38bffd115"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("797eeaaf-c120-4bc5-91c5-c9fe8d287876"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(679, 693),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeResultEntityCollectionNoMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("08950a5b-46be-4983-8d75-2c2ab2227e4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b83717ae-1946-482b-901e-61d38bffd115"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeResultEntityCollectionNoMessage",
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"ChangeResultEntityCollectionNoMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelChangeResultEntityCollectionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("efff1762-1cf3-4a41-88a5-028412aa733d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b83717ae-1946-482b-901e-61d38bffd115"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Name = @"CancelChangeResultEntityCollectionScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(161, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,74,45,46,205,41,113,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,11,73,173,40,113,77,201,44,209,3,49,20,108,21,66,139,83,139,92,82,211,50,243,82,83,208,149,186,100,22,23,228,36,86,134,37,230,148,166,90,243,114,21,165,150,148,22,229,41,148,20,1,121,0,161,240,79,105,97,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetPropertyDisplayPathByServerMetaPathMethod());
			Methods.Add(CreateGetPropertyServerMetaPathByClientMetaPathMethod());
			Methods.Add(CreateShowSchemaStructureExplorerEditWindowMethod());
			Methods.Add(CreateCreateColumnVirtualDataSourceMethod());
			Methods.Add(CreateInitializeColumnVirtualDataSourceStructureMethod());
			Methods.Add(CreateShowColumnStructureExplorerEditWindowMethod());
			Methods.Add(CreateColumnStructureExplorer_EditCompleteMethod());
			Methods.Add(CreateCreateColumnStructureExplorerMethod());
			Methods.Add(CreateTreeGridConfigHandlerMethod());
			Methods.Add(CreateLoadColumnVirtualDataSourceRowsMethod());
			Methods.Add(CreateSetUserTaskParameterConstValueMethod());
			Methods.Add(CreateGetIsEqualMetaPathColumnsParameterValuesMethod());
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
		}

		protected override SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = base.CreateInitializeSchemaExplorerWindowMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,223,78,194,48,20,198,175,217,83,212,93,109,9,233,11,16,46,20,9,89,130,196,8,120,95,215,195,92,236,218,165,127,196,197,240,238,158,178,129,14,10,70,111,40,105,207,249,206,239,251,118,94,148,18,164,52,11,216,46,243,87,168,216,244,163,22,74,131,38,99,114,122,49,38,210,9,49,138,202,13,73,2,29,41,249,140,6,103,34,18,182,157,208,210,106,151,91,167,225,240,154,60,178,2,232,74,213,19,37,173,86,98,206,26,229,236,144,196,166,95,31,15,201,134,9,3,221,145,142,162,93,244,206,52,49,191,0,51,115,105,242,117,15,125,93,250,192,36,114,234,5,171,0,103,76,121,105,219,158,31,247,72,68,0,209,2,221,153,204,133,227,192,239,153,101,207,76,56,88,53,53,24,58,17,192,116,178,183,114,218,80,72,60,121,199,37,160,2,105,215,25,239,70,127,95,140,206,26,195,147,110,57,199,160,53,82,90,208,189,55,20,25,146,153,43,57,197,28,252,153,164,8,228,255,144,2,127,78,107,145,96,109,64,227,199,146,144,219,82,73,218,171,232,226,160,51,176,153,133,234,174,241,193,36,177,151,139,83,186,7,246,161,103,230,8,51,87,234,205,213,161,200,175,88,9,145,117,46,166,85,109,155,125,164,126,208,69,207,126,145,67,42,127,4,249,71,22,173,225,54,141,51,230,254,34,78,52,48,11,62,115,220,93,104,163,187,233,151,60,65,81,26,244,7,65,242,195,171,223,177,193,165,198,163,252,238,11,38,98,252,216,7,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyDisplayPathByServerMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("49517bff-38a6-42c1-a114-1e497bc49243"),
				Name = "GetPropertyDisplayPathByServerMetaPath",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1da04de6-b75c-4c8f-a5ab-481dcfe8e5ef"),
				Name = "serverMetaPath",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,10,194,48,16,68,239,126,69,142,41,132,254,128,120,81,177,167,74,64,252,128,37,29,218,30,186,41,155,109,165,127,111,60,20,13,222,118,152,153,125,227,37,6,164,244,8,3,38,50,115,161,78,230,54,114,119,69,26,123,70,231,127,61,91,29,15,43,137,233,193,16,210,40,57,204,120,153,34,212,236,166,125,38,200,37,50,35,232,24,217,149,156,186,40,181,196,212,67,234,59,77,72,51,5,100,146,64,23,225,47,172,110,160,185,52,67,116,243,164,195,121,107,161,244,185,236,223,8,79,146,63,41,196,22,208,202,153,188,105,133,236,77,103,84,150,12,123,3,108,176,144,21,17,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyServerMetaPathByClientMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a40fe705-6fcf-49b7-a687-41377b1aa2de"),
				Name = "GetPropertyServerMetaPathByClientMetaPath",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3b1cf59c-6c81-4c44-9965-17ad176b4d06"),
				Name = "clientMetaPath",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,59,10,195,48,16,68,251,156,66,165,12,70,23,48,174,18,226,202,65,16,114,128,69,30,100,65,188,50,171,117,114,125,187,201,71,229,240,102,230,121,201,1,165,220,195,140,133,204,90,165,222,92,19,79,23,148,20,25,147,255,103,182,233,78,47,18,19,193,16,210,44,71,153,241,54,85,105,248,64,251,40,144,115,102,70,208,148,185,173,61,174,26,141,196,20,33,238,70,11,202,74,1,135,73,160,155,240,79,230,6,232,8,37,79,58,219,234,171,53,225,153,192,95,218,116,59,151,52,170,164,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowSchemaStructureExplorerEditWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1c017827-762e-4f82-9ac5-085fe2cce55d"),
				Name = "ShowSchemaStructureExplorerEditWindow",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("faca8aa6-f238-4edd-b6b9-15b02cdd0bc7"),
				Name = "entityCollectionMetaPath",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a5d4231c-07f9-4fe5-9633-4348e91d603d"),
				Name = "textEditClientID",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c1ab2342-5890-4548-b08a-6cc73256eefd"),
				Name = "textEditEventName",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,139,219,48,16,189,247,87,8,95,226,128,17,109,175,161,208,108,146,133,20,118,27,234,116,247,18,40,138,52,137,85,100,201,200,227,77,210,144,255,222,145,237,124,56,233,178,176,244,98,227,55,95,111,158,158,53,181,26,181,48,250,15,164,50,131,92,76,182,133,113,30,252,179,182,202,109,226,254,224,195,139,240,172,236,196,216,23,214,77,102,162,108,145,20,125,37,177,242,112,12,53,245,133,119,18,202,178,201,161,242,123,234,62,134,82,175,45,168,217,101,44,12,44,209,107,187,102,153,176,202,212,195,26,128,79,242,2,119,215,225,31,176,2,15,86,194,163,200,225,156,123,239,124,46,48,142,54,245,26,124,255,241,240,107,162,52,142,92,94,24,64,152,9,79,233,8,62,74,174,118,227,35,163,193,226,116,220,63,49,47,192,227,110,44,80,164,174,242,50,12,153,221,130,164,192,147,246,88,9,115,6,91,237,150,84,97,97,195,210,154,218,93,165,141,2,95,47,186,228,195,162,0,171,226,104,85,89,137,218,217,88,58,83,229,118,106,87,174,207,246,11,27,117,211,66,63,77,49,234,56,217,34,175,80,27,254,45,253,254,200,21,72,167,224,178,122,208,41,61,234,65,66,240,18,240,73,152,10,226,208,137,75,81,132,193,148,159,48,132,45,214,50,157,53,184,233,208,42,58,7,239,69,233,86,200,135,191,197,246,1,48,115,170,228,243,204,187,77,83,61,121,161,199,179,198,236,164,117,25,247,104,124,47,97,189,253,167,240,234,144,77,216,212,150,40,232,32,127,78,213,153,73,221,37,28,109,87,135,67,88,238,194,32,75,62,119,141,188,113,55,208,113,195,215,176,62,161,52,158,230,253,203,64,39,148,186,204,196,26,120,42,189,46,240,65,88,250,240,124,168,84,3,196,87,54,211,43,22,239,63,31,232,200,246,44,72,92,217,120,17,209,152,69,148,4,120,192,14,135,215,157,150,176,8,104,85,217,122,243,21,106,253,183,40,189,143,121,96,235,174,216,254,15,170,87,13,90,30,237,79,218,185,14,142,49,30,130,55,133,105,230,54,193,8,237,125,212,173,172,173,66,196,52,238,70,206,24,168,127,33,242,162,152,9,204,250,131,191,130,105,252,112,220,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0342a007-f595-4340-802d-f107ece3c70c"),
				Name = "CreateColumnVirtualDataSource",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,141,49,10,195,48,12,69,231,250,20,38,83,178,248,2,166,67,73,150,108,165,129,238,34,22,197,224,202,160,72,9,180,244,238,117,232,86,103,17,31,61,222,255,43,176,93,35,139,66,26,64,96,202,202,51,218,179,37,220,236,253,255,223,118,246,109,78,227,80,120,83,193,198,124,188,185,194,3,221,126,250,76,2,145,144,221,158,56,167,197,93,66,104,171,169,206,155,27,66,232,115,210,39,45,85,105,89,170,20,111,70,138,18,33,197,23,254,188,74,155,132,117,22,101,60,28,100,44,136,14,138,191,38,140,55,140,13,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeColumnVirtualDataSourceStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ac4f823f-00a9-45b3-b9f9-293d0dd21b23"),
				Name = "InitializeColumnVirtualDataSourceStructure",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7f9f551e-2bd9-4f58-82b8-12378e432e62"),
				Name = "virtualDataSource",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,203,78,195,48,16,69,215,245,87,88,89,53,18,202,15,68,93,64,34,85,89,20,85,180,116,63,216,83,106,201,113,34,63,2,17,226,223,113,136,121,36,50,136,2,219,153,57,163,123,70,211,129,166,28,44,28,64,58,220,247,45,110,64,193,61,106,186,162,183,6,117,209,40,133,204,138,70,101,101,100,42,39,67,117,215,56,205,112,103,181,99,214,105,124,221,55,175,173,104,39,180,117,32,63,128,172,196,227,251,64,78,34,84,182,213,162,6,221,23,141,116,181,186,134,122,216,147,84,60,249,118,186,20,166,149,16,131,58,47,43,248,216,240,69,133,15,52,146,63,244,159,200,226,19,124,65,22,147,3,248,114,236,108,217,26,109,165,140,5,197,240,170,31,248,101,178,118,130,39,169,95,80,153,131,48,226,78,14,240,17,164,65,242,28,23,185,228,33,228,242,45,109,58,134,175,209,194,22,236,233,124,133,77,32,255,34,178,199,71,251,91,145,105,242,160,195,160,29,94,235,124,155,98,4,255,69,38,236,242,232,13,66,136,235,253,102,207,250,213,111,205,174,225,35,255,224,24,19,239,52,127,1,212,203,140,99,132,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnStructureExplorerEditWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b39d7562-7a93-463d-8d00-39d4936c5217"),
				Name = "ShowColumnStructureExplorerEditWindow",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8707cd79-e88f-443e-8111-d5cf065bce92"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,203,110,219,48,16,60,219,128,255,129,185,201,64,192,31,112,28,160,126,52,112,139,36,6,84,55,231,173,180,142,89,80,148,64,82,113,213,34,255,222,37,233,84,242,131,86,47,6,72,205,206,236,204,74,107,177,101,137,201,118,88,192,102,149,179,233,148,61,212,34,231,203,162,178,205,152,253,25,13,7,26,109,173,213,100,52,124,31,13,83,171,235,140,142,184,252,85,201,82,163,102,89,41,235,66,157,221,19,92,16,241,205,202,204,47,3,230,26,193,98,30,36,34,36,108,202,2,44,194,145,140,93,87,12,165,193,30,154,228,236,114,28,225,156,12,188,81,177,77,110,140,213,66,189,242,149,121,170,165,124,214,62,146,100,169,172,176,77,234,3,91,235,50,67,99,22,96,97,28,140,188,129,102,57,29,211,178,214,25,254,35,15,90,244,43,49,179,162,84,212,145,194,61,91,244,35,189,197,65,87,148,97,247,48,101,27,67,97,150,74,5,60,239,66,31,65,193,43,106,254,128,118,165,140,5,149,225,172,161,41,183,243,246,236,174,105,188,108,139,248,191,152,146,250,81,111,168,45,95,32,137,9,144,226,55,62,255,248,73,138,119,145,56,238,163,57,57,193,133,240,189,130,110,238,220,203,118,203,66,210,247,172,64,11,107,176,187,144,130,33,245,72,95,124,13,154,30,133,251,128,126,60,212,58,129,45,77,18,178,93,242,21,155,239,32,107,92,131,208,39,82,225,93,241,30,133,58,21,14,195,188,62,205,190,25,134,201,29,141,238,80,136,231,87,199,70,221,192,186,143,103,205,135,185,164,109,155,123,103,65,36,152,98,166,83,227,208,61,180,14,210,75,29,245,207,253,186,232,228,200,41,237,158,146,15,173,227,58,175,214,83,249,4,5,82,85,234,141,110,172,144,194,10,52,124,46,17,212,166,10,32,135,73,78,51,232,115,49,135,234,240,69,94,139,234,51,109,128,3,114,214,248,180,206,117,122,132,156,85,239,244,91,83,225,137,220,37,200,117,186,118,67,240,79,121,158,68,113,222,254,123,124,55,242,246,83,251,15,173,240,39,16,163,74,119,229,126,153,11,251,34,84,94,238,219,37,115,203,20,197,55,158,252,5,77,107,250,179,106,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateColumnStructureExplorer_EditCompleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("278ac500-6a43-4eff-81e1-6979ba58bf86"),
				Name = "ColumnStructureExplorer_EditComplete",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eebc4a66-108b-4777-879b-d35bef01e75a"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3370b1b2-c664-4a4e-b731-312dcc62ec79"),
				Name = "e",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,75,111,226,48,16,62,131,196,127,176,56,37,85,21,246,78,65,234,131,173,232,246,165,118,219,75,213,131,155,12,224,221,196,70,182,3,101,219,254,247,29,199,201,226,132,154,210,213,238,1,1,246,204,124,223,124,243,72,22,84,18,165,101,30,235,92,194,232,121,158,10,9,242,88,164,121,198,21,25,144,224,236,80,74,186,10,207,148,224,209,9,40,144,140,166,236,23,4,16,141,158,181,164,215,84,210,12,52,72,245,208,101,26,50,53,230,19,209,125,12,251,157,246,136,107,166,87,183,241,12,50,122,45,69,12,74,157,80,77,9,188,127,142,30,108,18,32,21,198,167,209,88,93,230,105,122,37,71,217,92,175,2,79,164,48,124,233,180,91,158,112,200,157,195,146,120,92,3,67,208,231,26,97,82,120,101,207,173,20,23,160,49,85,61,43,163,158,176,88,51,193,169,92,29,156,230,44,217,39,150,246,176,8,251,214,105,67,170,96,59,55,163,231,177,224,11,144,26,237,90,174,180,87,79,63,32,214,7,30,230,67,175,26,22,218,189,37,115,39,17,4,189,83,166,180,156,67,193,62,114,77,47,40,167,83,144,209,41,232,49,87,154,242,24,142,86,119,227,164,68,67,21,82,235,101,205,241,198,224,61,9,145,18,166,46,68,194,38,12,18,95,197,7,100,66,81,17,116,240,9,71,230,107,115,87,119,211,130,190,134,217,82,38,68,90,152,190,6,67,26,146,117,172,15,139,103,220,104,146,124,218,39,65,168,207,33,77,112,208,104,60,11,22,254,1,36,140,123,103,51,36,166,193,202,2,92,10,141,117,213,148,21,208,232,97,180,110,153,200,72,99,163,131,61,33,31,186,89,105,211,125,140,190,139,219,130,171,29,148,138,235,55,88,221,211,52,135,107,202,228,110,5,52,41,248,106,107,83,104,177,9,9,60,38,81,129,70,6,131,205,60,74,231,86,163,198,209,97,146,120,163,33,253,125,31,27,11,85,100,139,148,26,138,86,237,139,87,79,168,196,207,226,39,14,91,241,49,252,107,14,37,181,94,207,157,135,82,14,216,60,26,212,198,212,76,160,123,125,180,170,50,14,54,53,40,120,184,237,90,164,111,10,19,93,194,210,124,7,225,254,59,218,245,45,245,183,117,23,254,143,202,26,97,154,229,169,52,66,188,109,101,178,171,189,21,163,53,227,182,155,141,212,245,41,251,7,181,198,160,157,118,175,71,240,128,37,84,3,89,206,64,207,64,146,184,28,100,252,47,161,154,110,52,221,51,79,41,18,52,136,28,139,156,107,50,36,95,108,226,229,146,170,150,112,237,223,128,124,101,60,193,117,207,166,28,146,154,165,157,53,51,181,144,48,61,74,33,195,174,168,118,201,57,83,250,160,102,126,68,21,148,70,195,250,152,218,202,149,57,252,25,124,172,87,131,118,33,67,213,174,46,166,81,246,134,242,41,4,53,242,166,55,125,20,84,80,135,11,157,38,219,235,161,106,59,60,37,124,170,146,215,215,218,82,94,223,32,198,120,135,192,31,219,32,194,135,12,251,59,141,139,67,212,72,238,242,182,74,191,183,177,28,43,219,185,238,129,219,173,127,245,202,210,64,220,242,110,86,123,49,137,110,235,175,36,129,7,220,80,59,23,180,12,127,207,164,206,105,90,204,156,200,101,12,55,98,169,154,123,32,236,255,6,142,105,202,183,120,10,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ed8a3c6c-b9f7-47d1-bb29-3ff36bd11fa8"),
				Name = "CreateColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "StructureExplorer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,203,110,219,48,16,60,91,95,193,234,100,35,2,253,1,70,14,169,170,2,2,26,212,176,221,246,80,20,5,45,173,28,182,20,151,32,169,88,66,144,127,239,210,178,153,20,137,146,139,205,199,236,204,236,44,181,92,50,211,237,149,172,216,214,219,174,242,157,133,162,55,10,45,216,249,15,216,231,168,189,69,197,140,176,160,253,121,151,49,231,173,212,7,246,23,134,140,237,145,238,165,187,237,148,151,91,80,80,249,120,182,65,244,183,88,67,150,44,151,179,115,205,29,40,19,120,160,247,101,29,145,219,59,60,70,3,165,135,214,173,45,26,176,94,130,99,215,140,110,96,145,220,11,27,140,136,150,78,52,28,217,14,172,21,14,27,207,191,149,252,201,172,227,113,177,14,104,240,212,75,42,3,105,169,27,76,51,246,223,38,98,130,83,190,17,199,197,234,164,84,161,234,90,253,34,149,179,246,203,180,214,226,0,124,135,230,44,254,69,12,216,81,20,233,200,115,129,145,96,104,38,99,141,80,14,46,73,242,162,53,126,32,225,9,81,94,244,149,234,106,248,36,188,248,46,84,7,187,193,156,130,9,86,70,138,159,191,216,3,75,63,74,45,236,16,90,252,44,21,132,255,178,37,95,97,145,35,81,165,236,113,90,164,28,199,48,56,74,39,63,97,46,217,191,87,243,213,24,116,20,234,6,26,160,135,82,1,213,157,26,92,37,57,182,6,53,61,158,155,63,162,47,238,105,193,160,150,62,28,43,74,157,128,83,212,177,192,241,226,89,197,42,121,94,207,71,202,171,107,150,191,78,243,251,173,218,222,91,17,231,239,248,77,93,207,79,15,236,141,73,60,5,19,178,15,3,217,98,103,43,136,200,17,64,191,225,83,144,168,231,68,86,186,9,119,185,5,225,161,142,49,203,134,205,63,76,96,55,112,144,52,26,11,245,130,61,36,179,41,131,23,88,208,157,189,75,21,149,31,147,9,236,244,132,86,137,5,218,235,201,251,127,228,226,95,163,93,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateTreeGridConfigHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("85304075-d338-45d3-8f2c-9b97153e183b"),
				Name = "TreeGridConfigHandler",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceRowConfig"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6a11ebb9-e2fe-41ac-8e82-661529bfaa98"),
				Name = "row",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,73,44,73,12,206,47,45,74,78,13,202,47,119,206,207,75,203,76,215,40,202,47,215,11,40,202,204,77,44,170,116,206,207,41,205,205,11,75,204,41,77,213,180,6,0,27,141,163,135,55,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLoadColumnVirtualDataSourceRowsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0338a8d8-946d-471c-af98-d5149aeaf3eb"),
				Name = "LoadColumnVirtualDataSourceRows",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2041f19f-c925-4f0a-b555-253000ca87e8"),
				Name = "processDataMetaPathColumns",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<Guid, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,91,107,194,48,20,126,174,191,34,248,148,130,148,189,59,133,217,109,34,155,32,118,250,126,104,142,26,136,137,36,169,82,134,255,125,167,23,177,214,150,189,158,243,157,239,22,178,130,61,70,75,244,176,2,127,136,141,202,142,218,253,88,196,185,149,34,138,21,130,229,225,120,112,6,203,206,210,250,12,212,59,120,72,76,102,83,100,19,198,183,237,97,184,70,16,53,207,211,146,136,218,163,187,134,220,49,126,178,38,69,231,138,117,203,83,20,155,76,123,54,101,47,33,251,29,4,31,218,75,159,39,233,1,143,176,4,77,33,44,195,142,217,132,109,28,218,216,104,141,169,151,70,71,29,135,227,71,186,7,30,34,232,160,141,230,232,23,218,121,208,41,206,242,205,66,240,138,128,188,170,74,167,130,211,134,130,5,59,99,17,210,3,255,194,124,11,42,195,21,72,251,58,207,164,24,49,231,173,212,251,41,75,203,148,69,110,38,53,235,175,161,12,95,219,101,214,92,200,95,71,165,36,231,113,109,46,69,173,65,80,105,176,99,205,68,39,119,181,168,52,212,64,185,210,120,165,86,163,155,5,20,201,147,22,100,150,223,76,242,155,70,216,195,248,153,41,21,195,169,104,232,31,226,6,114,150,151,220,109,103,165,6,85,16,37,232,171,105,153,133,15,23,98,56,106,70,164,218,123,177,181,4,29,244,216,236,189,188,101,166,211,135,212,207,207,241,38,4,39,134,98,123,29,92,59,190,192,183,1,65,175,229,232,185,254,0,250,15,6,231,143,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetUserTaskParameterConstValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2d371712-ba5c-4421-b562-360d4fcc6c6c"),
				Name = "SetUserTaskParameterConstValue",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d935876d-f58f-4bcf-a188-29d9f9a3bfce"),
				Name = "parameterName",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f64d1b5b-47a8-4896-a2aa-230d639edee3"),
				Name = "value",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bdd6a32f-67a8-452e-9d5c-8745cc9707e2"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,205,106,195,48,12,62,207,79,161,99,2,37,15,208,172,27,99,237,33,148,117,133,178,93,198,14,38,86,55,129,99,7,203,233,8,99,239,62,39,161,109,126,186,194,78,198,210,247,103,75,180,135,104,43,157,44,208,163,227,87,169,43,132,197,2,76,165,117,12,223,226,102,210,3,131,95,176,164,220,147,53,210,213,183,236,29,153,143,25,108,157,205,145,121,151,127,98,33,79,172,150,116,23,197,169,248,17,7,233,160,156,200,141,13,36,255,87,61,21,87,186,103,199,126,254,43,132,38,235,144,147,60,89,69,123,66,149,153,142,240,146,169,160,179,82,228,79,247,9,103,103,43,151,183,239,251,219,170,195,36,143,214,176,111,11,19,149,99,230,195,197,238,146,184,212,178,62,130,186,191,74,50,222,132,225,61,187,85,81,250,58,82,61,76,12,247,157,18,204,161,95,79,5,133,45,24,141,166,137,229,37,25,94,99,125,238,109,194,17,183,139,49,130,191,13,32,239,33,206,48,108,88,0,64,205,120,129,154,60,40,53,116,152,141,200,205,250,252,2,42,17,143,189,169,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsEqualMetaPathColumnsParameterValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b777063c-1367-481d-b204-c052d3213f1e"),
				Name = "GetIsEqualMetaPathColumnsParameterValues",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3556c9b6-d208-446c-acec-67e0a3031fac"),
				Name = "metaPathColumnsValue1",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("156eefe5-0256-46a9-b72b-f9c5b7527151"),
				Name = "metaPathColumnsValue2",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,93,107,194,48,20,125,86,240,63,100,47,106,85,116,205,227,252,120,81,25,110,99,14,198,246,34,62,196,26,109,186,52,117,105,42,184,233,127,95,210,70,219,106,59,21,6,163,148,150,220,155,115,206,253,36,11,80,117,177,64,47,72,216,125,143,6,46,243,223,17,13,176,9,110,186,32,203,0,13,240,93,42,22,56,22,1,103,96,129,168,143,219,165,226,174,84,108,213,214,136,3,43,114,53,65,23,60,248,30,235,123,108,141,185,104,14,176,143,57,65,148,124,225,241,204,193,150,232,12,136,37,136,199,16,223,116,238,3,50,111,0,95,112,194,150,189,94,182,28,67,146,36,240,225,31,227,67,133,191,240,56,70,150,93,141,121,204,183,209,28,16,118,136,170,249,136,55,190,161,226,143,208,142,50,164,162,222,187,78,98,132,169,196,46,204,60,143,2,226,63,123,98,248,25,32,42,61,5,15,84,234,10,167,180,48,77,11,35,218,48,239,217,196,48,38,134,147,24,35,36,46,144,147,18,75,157,199,197,213,101,149,222,73,137,251,242,202,243,153,20,249,17,254,202,90,135,175,194,141,189,245,253,163,190,80,142,187,90,171,84,212,231,58,102,245,180,106,251,148,4,148,142,249,208,93,137,77,118,39,118,117,237,154,163,164,111,126,159,92,134,11,175,193,13,251,67,7,124,78,110,185,124,1,121,106,138,116,86,118,23,83,108,183,215,82,36,6,245,180,31,52,108,243,9,179,165,176,115,39,95,219,243,112,45,91,54,48,17,216,29,96,74,36,0,230,50,195,149,70,165,173,77,107,5,146,178,221,41,91,84,131,201,52,185,58,178,229,189,174,40,17,213,20,131,145,1,0,115,0,96,30,128,28,64,153,117,38,0,145,55,111,219,242,211,137,39,62,138,89,30,214,235,81,224,231,39,159,76,53,83,58,98,99,98,158,223,4,145,16,39,18,226,196,66,224,65,136,179,23,114,193,42,112,126,87,242,255,171,33,189,24,106,173,31,203,159,60,215,143,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityCollectionDisplayValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("354ee145-0de2-4179-bc3f-111c50556bda"),
				Name = "GetEntityCollectionDisplayValue",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d5d78927-88f8-466a-9d52-b9f1fe70e29a"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8aea30f7-9d41-4782-b5a5-426f2d4dee87"),
				Name = "metaPath",
				CreatedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
				ModifiedInSchemaUId = new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"),
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
			return new ReadDataIntoEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cc76b66c-8fbd-4338-965b-bf0c4e071ad4"));
		}

		#endregion

	}

	#endregion

}

