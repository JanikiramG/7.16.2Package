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

	#region Class: ClearChangeLogSettingsPageSchema

	/// <exclude/>
	public class ClearChangeLogSettingsPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout6;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return _controlLayout6;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout8;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout8 {
			get {
				return _controlLayout8;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _allEntitiesRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton AllEntitiesRadioButton {
			get {
				return _allEntitiesRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout7;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return _controlLayout7;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return _controlLayout5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout9;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return _controlLayout9;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _selectedEntityRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton SelectedEntityRadioButton {
			get {
				return _selectedEntityRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout10;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout10 {
			get {
				return _controlLayout10;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _entityComboBoxEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit EntityComboBoxEdit {
			get {
				return _entityComboBoxEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _beforeDateTimeEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit BeforeDateTimeEdit {
			get {
				return _beforeDateTimeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout13;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout13 {
			get {
				return _controlLayout13;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _footerControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout FooterControlLayout {
			get {
				return _footerControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _oKButton;
		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return _oKButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _cancelButton;
		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return _cancelButton;
			}
		}

		#endregion

		#region Constructors: Public

		public ClearChangeLogSettingsPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ClearChangeLogSettingsPageSchema(ClearChangeLogSettingsPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			RealUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			Name = "ClearChangeLogSettingsPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 240;
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateClearChangeLogSettingsPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateControlLayout6());
			ControlLayout6.InsertItem(0, CreateControlLayout4());
			ControlLayout6.InsertItem(1, CreateControlLayout8());
			ControlLayout8.InsertItem(0, CreateAllEntitiesRadioButton());
			ControlLayout1.InsertItem(1, CreateControlLayout7());
			ControlLayout7.InsertItem(0, CreateControlLayout5());
			ControlLayout7.InsertItem(1, CreateControlLayout9());
			ControlLayout9.InsertItem(0, CreateSelectedEntityRadioButton());
			ControlLayout7.InsertItem(2, CreateControlLayout10());
			ControlLayout10.InsertItem(0, CreateEntityComboBoxEdit());
			Controls.AddAt(2, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateBeforeDateTimeEdit());
			Controls.AddAt(3, CreateControlLayout13());
			Controls.AddAt(4, CreateFooterControlLayout());
			FooterControlLayout.InsertItem(0, CreateContextHelpButton());
			FooterControlLayout.InsertItem(1, CreateSpacer1());
			FooterControlLayout.InsertItem(2, CreateOKButton());
			FooterControlLayout.InsertItem(3, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateClearChangeLogSettingsPageEventsProcessSchema() {
			var schema = new ClearChangeLogSettingsPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("646b543a-138c-4686-abaf-5758ddb3bc66");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Edges = "";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("53c27cfa-8644-497c-8216-5d5cdaf9e56f");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout4.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(10);
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Pixel(10);
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateAllEntitiesRadioButton() {
			_allEntitiesRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_allEntitiesRadioButton.UId = new Guid("d38ade4e-f2b2-41cd-9d46-227ce4005ebe");
			_allEntitiesRadioButton.Name = "AllEntitiesRadioButton";
			_allEntitiesRadioButton.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_allEntitiesRadioButton.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_allEntitiesRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_allEntitiesRadioButton.Tag = "";
			_allEntitiesRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allEntitiesRadioButton.GroupName = "Group";
			return _allEntitiesRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout8() {
			_controlLayout8 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout8.UId = new Guid("75a1134a-5299-49b3-b156-826ebda4114e");
			_controlLayout8.Name = "ControlLayout8";
			_controlLayout8.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout8.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout8.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout8.Tag = "";
			_controlLayout8.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout8.FitHeightByContent = true;
			_controlLayout8.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout8.StartNewAlignGroup = false;
			_controlLayout8.Image = new ControlImage {};
			_controlLayout8.Edges = "";
			return _controlLayout8;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout6() {
			_controlLayout6 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout6.UId = new Guid("3f39442d-25af-49b0-9528-54f86e76631e");
			_controlLayout6.Name = "ControlLayout6";
			_controlLayout6.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout6.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout6.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout6.Tag = "";
			_controlLayout6.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout6.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout6.FitHeightByContent = true;
			_controlLayout6.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout6.StartNewAlignGroup = false;
			_controlLayout6.Image = new ControlImage {};
			_controlLayout6.Edges = "";
			return _controlLayout6;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout5() {
			_controlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout5.UId = new Guid("52ecc441-f4ee-43fc-abb0-d79738d5ba5a");
			_controlLayout5.Name = "ControlLayout5";
			_controlLayout5.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout5.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout5.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout5.Tag = "";
			_controlLayout5.Height = System.Web.UI.WebControls.Unit.Pixel(10);
			_controlLayout5.Width = System.Web.UI.WebControls.Unit.Pixel(10);
			_controlLayout5.StartNewAlignGroup = false;
			_controlLayout5.Image = new ControlImage {};
			_controlLayout5.Edges = "";
			return _controlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateSelectedEntityRadioButton() {
			_selectedEntityRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_selectedEntityRadioButton.UId = new Guid("72768b9d-358d-4710-adc2-831ac7bb6a64");
			_selectedEntityRadioButton.Name = "SelectedEntityRadioButton";
			_selectedEntityRadioButton.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_selectedEntityRadioButton.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_selectedEntityRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_selectedEntityRadioButton.Tag = "";
			_selectedEntityRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_selectedEntityRadioButton.GroupName = "Group";
			return _selectedEntityRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout9() {
			_controlLayout9 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout9.UId = new Guid("4eef4ea1-b28e-4cb3-bfff-45287f3a1330");
			_controlLayout9.Name = "ControlLayout9";
			_controlLayout9.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout9.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout9.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout9.Tag = "";
			_controlLayout9.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout9.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout9.FitHeightByContent = true;
			_controlLayout9.Width = System.Web.UI.WebControls.Unit.Pixel(150);
			_controlLayout9.StartNewAlignGroup = false;
			_controlLayout9.Image = new ControlImage {};
			_controlLayout9.Edges = "";
			return _controlLayout9;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateEntityComboBoxEdit() {
			_entityComboBoxEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_entityComboBoxEdit.UId = new Guid("70802112-ba0a-473c-b956-ded1f76c5fa4");
			_entityComboBoxEdit.Name = "EntityComboBoxEdit";
			_entityComboBoxEdit.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_entityComboBoxEdit.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_entityComboBoxEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityComboBoxEdit.Tag = "";
			_entityComboBoxEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityComboBoxEdit.Image = new ControlImage {};
			_entityComboBoxEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityComboBoxEdit.Margins = "0 10 10";
			return _entityComboBoxEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout10() {
			_controlLayout10 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout10.UId = new Guid("f9339b94-b36a-4433-95e7-7f6c99025a0e");
			_controlLayout10.Name = "ControlLayout10";
			_controlLayout10.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout10.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout10.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout10.Tag = "";
			_controlLayout10.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout10.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout10.FitHeightByContent = true;
			_controlLayout10.Width = System.Web.UI.WebControls.Unit.Percentage(50);
			_controlLayout10.StartNewAlignGroup = false;
			_controlLayout10.Image = new ControlImage {};
			_controlLayout10.Edges = "";
			return _controlLayout10;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout7() {
			_controlLayout7 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout7.UId = new Guid("6eb8c878-7b55-4f86-a660-ea2316601d54");
			_controlLayout7.Name = "ControlLayout7";
			_controlLayout7.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout7.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout7.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout7.Tag = "";
			_controlLayout7.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout7.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout7.FitHeightByContent = true;
			_controlLayout7.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout7.StartNewAlignGroup = false;
			_controlLayout7.Image = new ControlImage {};
			_controlLayout7.Edges = "";
			return _controlLayout7;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("1190d1df-43bc-4ba2-bdda-1a0b8fd42e9d");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout1.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateBeforeDateTimeEdit() {
			_beforeDateTimeEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_beforeDateTimeEdit.UId = new Guid("d53a99c0-b81d-49f0-88ea-724bef67ab03");
			_beforeDateTimeEdit.Name = "BeforeDateTimeEdit";
			_beforeDateTimeEdit.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_beforeDateTimeEdit.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_beforeDateTimeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_beforeDateTimeEdit.Tag = "";
			_beforeDateTimeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_beforeDateTimeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_beforeDateTimeEdit.CaptionVerticalAlign = Terrasoft.UI.WebControls.VerticalAlign.Middle;
			_beforeDateTimeEdit.AlignedByCaption = false;
			_beforeDateTimeEdit.Margins = "10 10 10 10";
			return _beforeDateTimeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("f650c8fc-e89c-4aad-8729-932a74e34bd2");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout2.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout13() {
			_controlLayout13 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout13.UId = new Guid("570f1f39-a316-4927-af57-8395d4f1b053");
			_controlLayout13.Name = "ControlLayout13";
			_controlLayout13.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout13.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_controlLayout13.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout13.Tag = "";
			_controlLayout13.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout13.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout13.StartNewAlignGroup = false;
			_controlLayout13.Image = new ControlImage {};
			_controlLayout13.Edges = "";
			return _controlLayout13;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("d1cdad2b-7e42-4ff0-9079-ab62b9896e1e");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.HelpContextId = "508";
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("9a7a71a6-16b6-40fd-8910-a38bf7ac5d4b");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_spacer1.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOKButton() {
			_oKButton = new Terrasoft.UI.WebControls.Controls.Button();
			_oKButton.UId = new Guid("ac5eb794-f35d-40fd-aaec-9fda9adeea9a");
			_oKButton.Name = "OKButton";
			_oKButton.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_oKButton.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_oKButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_oKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_oKButton.Tag = "";
			_oKButton.Image = new ControlImage {};
			return _oKButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("b5ec43db-7cda-43c0-b8df-0777788f09f1");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_cancelButton.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFooterControlLayout() {
			_footerControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_footerControlLayout.UId = new Guid("04a22afb-4561-4db4-b108-ce663eaa660d");
			_footerControlLayout.Name = "FooterControlLayout";
			_footerControlLayout.CreatedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_footerControlLayout.ModifiedInSchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			_footerControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_footerControlLayout.Tag = "";
			_footerControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_footerControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_footerControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_footerControlLayout.FitHeightByContent = true;
			_footerControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_footerControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_footerControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_footerControlLayout.StartNewAlignGroup = false;
			_footerControlLayout.Image = new ControlImage {};
			_footerControlLayout.Edges = "";
			return _footerControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ClearChangeLogSettingsPageSchemaUserControl();
		}

		public override object Clone() {
			return new ClearChangeLogSettingsPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ClearChangeLogSettingsPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ClearChangeLogSettingsPageEventsProcess

	/// <exclude/>
	public class ClearChangeLogSettingsPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.ClearChangeLogSettingsPageSchemaUserControl
	{

		private TPage _page;
		public TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public ClearChangeLogSettingsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ClearChangeLogSettingsPageEventsProcess";
			SchemaUId = new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8ffbb5a2-79cb-4c17-ac7b-f4565896305c");
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

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("f5433b26-5de5-4931-be4f-a05b7e14ecbc"),
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
					SchemaElementUId = new Guid("b187a91e-41a2-470f-9b91-8e4a490eca16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickedScriptTask1;
		public ProcessScriptTask OkButtonClickedScriptTask1 {
			get {
				return _okButtonClickedScriptTask1 ?? (_okButtonClickedScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickedScriptTask1",
					SchemaElementUId = new Guid("2f17984f-3b1a-4459-b020-6c8390bd0438"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickedScriptTask1Execute,
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
					SchemaElementUId = new Guid("b6dcffe5-2c3d-419b-bef1-dc241404d3e7"),
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
					SchemaElementUId = new Guid("2cd4f4f1-dc1f-4dc5-95d2-078f4df51b00"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _cancelButtonClickedScriptTask2;
		public ProcessScriptTask CancelButtonClickedScriptTask2 {
			get {
				return _cancelButtonClickedScriptTask2 ?? (_cancelButtonClickedScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CancelButtonClickedScriptTask2",
					SchemaElementUId = new Guid("04ccf6d9-a898-42e0-8958-1fa4d84cd73c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickedScriptTask2Execute,
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
					SchemaElementUId = new Guid("7e14158d-bee0-40de-91bd-6c4c86af0e6d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteScriptTaskStartMessage;
		public ProcessFlowElement PageLoadCompleteScriptTaskStartMessage {
			get {
				return _pageLoadCompleteScriptTaskStartMessage ?? (_pageLoadCompleteScriptTaskStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteScriptTaskStartMessage",
					SchemaElementUId = new Guid("96aca591-2b16-4252-b677-bcd95646dcdb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask;
		public ProcessScriptTask PageLoadCompleteScriptTask {
			get {
				return _pageLoadCompleteScriptTask ?? (_pageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("45690794-fa21-4dcd-9a22-3de37149177c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[OkButtonClickedScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickedScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[CancelButtonClickedScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickedScriptTask2 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[PageLoadCompleteScriptTaskStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTaskStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("OkButtonClickedScriptTask1");
						break;
					case "OkButtonClickedScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("CancelButtonClickedScriptTask2");
						break;
					case "CancelButtonClickedScriptTask2":
						break;
					case "EventSubProcess3":
						break;
					case "PageLoadCompleteScriptTaskStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("PageLoadCompleteScriptTaskStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "OkButtonClickedScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickedScriptTask1";
					result = OkButtonClickedScriptTask1.Execute(context, OkButtonClickedScriptTask1Execute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "CancelButtonClickedScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickedScriptTask2";
					result = CancelButtonClickedScriptTask2.Execute(context, CancelButtonClickedScriptTask2Execute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteScriptTaskStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTaskStartMessage";
					result = PageLoadCompleteScriptTaskStartMessage.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
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

		public virtual bool OkButtonClickedScriptTask1Execute(ProcessExecutingContext context) {
			Dictionary<string,object> parameters = (Dictionary<string,object>)UserConnection.SessionData["ClearChangeLogSettingsDictionary"];
			parameters["NeedClear"] = true;
			if(Page.AllEntitiesRadioButton.Checked) {
				parameters["NeedClearAll"] = true;
			}
			else {
				parameters["CurrentEntitySchemaId"] = new Guid(Page.EntityComboBoxEdit.SelectedItem.Value);
			}
			parameters["NeedClearBefore"] = Page.BeforeDateTimeEdit.Value;
			UserConnection.SessionData["ClearChangeLogSettingsDictionary"] = parameters;
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool CancelButtonClickedScriptTask2Execute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			Page.SelectedEntityRadioButton.Checked=true;
			Dictionary<string,object> parameters = (Dictionary<string,object>)UserConnection.SessionData["ClearChangeLogSettingsDictionary"];
			Guid currentEntitySchemaId = (Guid)parameters["CurrentEntitySchemaId"];
			Guid[] loggedEntitySchemaIds = (Guid[])parameters["LoggedEntitySchemaIds"];
			string[] loggedEntityCaptions = (string[])parameters["LoggedEntityCaptions"];
			for (int i=0; i < loggedEntitySchemaIds.Length; i++) {
				Page.EntityComboBoxEdit.AddItem(loggedEntitySchemaIds[i],loggedEntityCaptions[i]);
				if (loggedEntitySchemaIds[i] == currentEntitySchemaId) {
					Page.EntityComboBoxEdit.SelectItem(loggedEntitySchemaIds[i]);
				}
			}
			Page.BeforeDateTimeEdit.Value = parameters["NeedClearBefore"];
			var scriptBody = @"window.onRadioButtonCheck = function(rb) {{
								if (!rb.checked) {{ return false; }}			
								if (rb.id == '{1}') {{
									{0}.setEnabled(false);
								}} else {{
									{0}.setEnabled(true);
								}}
							 }};";
			Page.AddScript(string.Format(scriptBody, Page.EntityComboBoxEdit.ClientID, Page.AllEntitiesRadioButton.ClientID));
			Page.AddScript(string.Format("{0}.on('check', window.onRadioButtonCheck, this);", Page.AllEntitiesRadioButton.ClientID));
			Page.AddScript(string.Format("{0}.on('check', window.onRadioButtonCheck, this);", Page.SelectedEntityRadioButton.ClientID));
			Page.ScriptManager.AddScript("{0}.setReadOnly(true); {0}.allowEmpty = false;", Page.EntityComboBoxEdit.ClientID);
			InitializeContextHelpButton();
			return true;
		}

		public virtual void InitializeContextHelpButton() {
			if (!GetIsContextHelpButtonHidden() && GetIsContextHelpEnabled()) {
				Page.ContextHelpButton.Hidden = false;
				Page.ContextHelpButton.Image.Source = ControlImageSource.ResourceManager;
				Page.ContextHelpButton.Image.ResourceManagerName = "Terrasoft.WebApp";
				Page.ContextHelpButton.Image.ResourceItemName = "help.png";
				Page.ContextHelpButton.AjaxEvents.Click.OnClientEvent = "Terrasoft.HelpContext.showHelp(null, '" + Page.ContextHelpButton.ClientID + "')";
			}
		}

		public virtual bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual bool GetIsContextHelpEnabled() {
			return (bool)SysSettings.GetValue(UserConnection, "EnableContextHelp");
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteScriptTaskStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteScriptTaskStartMessage");
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

	#region Class: ClearChangeLogSettingsPageEventsProcess

	/// <exclude/>
	public class ClearChangeLogSettingsPageEventsProcess : ClearChangeLogSettingsPageEventsProcess<Terrasoft.WebApp.ClearChangeLogSettingsPageSchemaUserControl>
	{

		public ClearChangeLogSettingsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ClearChangeLogSettingsPageSchemaUserControl

	/// <exclude/>
	public partial class ClearChangeLogSettingsPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout6", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout8 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout8", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton AllEntitiesRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("AllEntitiesRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout7", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout9", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton SelectedEntityRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("SelectedEntityRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout10 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout10", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit EntityComboBoxEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("EntityComboBoxEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit BeforeDateTimeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("BeforeDateTimeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout13 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout13", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout FooterControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("FooterControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OKButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CancelButton", true);
			}
		}

		private Terrasoft.UI.WebControls.Controls.ScriptManager _scriptManager;
		public Terrasoft.UI.WebControls.Controls.ScriptManager ScriptManager {
			get {
				if (this._scriptManager != null) {
					return this._scriptManager;
				}
				if (!this.DesignMode && this.Page != null) {
					this._scriptManager = ScriptManager.GetCurrent(this.Page);
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
				}
				if (this.Page != null) {
					this._scriptManager = ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManagerProxy") as ScriptManager;
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
					this._scriptManager = (ScriptManager)ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManager");
					if (this.DesignMode && this._scriptManager == null) {
						this._scriptManager = new ScriptManager();
						this.Page.Controls.Add(this._scriptManager);
					}
				}
				if (this._scriptManager == null) {
					throw new InvalidOperationException("The Terrasoft Script Manager Control " +
						"is missing from this Page." +
						Environment.NewLine + Environment.NewLine +
						"Please add the following Script Manager tag inside the <body> or " +
						"<form> of this Page." +
						Environment.NewLine + Environment.NewLine + "Example" +
						Environment.NewLine + Environment.NewLine +
						" <ext:Script Manager runat=\"server\" />");
				}
				return this._scriptManager;
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PageLoadComplete(object sender, EventArgs e) {
			if (!((PageContainer)PageContainer).IsPageLoadCompleted) {
				((PageContainer)PageContainer).IsPageLoadCompleted = true;
				ThrowEvent("PageLoadComplete");
			}
		}

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			OKButton.AjaxEvents.Click.Event += OKButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			OKButton.AjaxEvents.Click.Event -= OKButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ClearChangeLogSettingsPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ClearChangeLogSettingsPageEventsProcess(UserConnection);
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

		public virtual void OKButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OKButtonClick");
		}

		public virtual void CancelButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CancelButtonClick");
		}

		public virtual void ThrowClientEvent(string message, params object[] parameters) {
			string key = CopyParameters(parameters);
			ScriptManager.AddScript("if (window.opener) { if (window.key) {window.opener.Terrasoft.AjaxMethods.ThrowClientEvent(window.key, '" + message + "', '" + key + "')}}");
		}

		public virtual void AjaxRefresh() {
			ScriptManager.AddScript("window.Terrasoft.AjaxMethods.ThrowClientEvent(null, null);");
		}

		public virtual void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public virtual void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public virtual void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "ClearChangeLogSettingsPage";
		}

		#endregion

	}

	#endregion

	#region Class: ClearChangeLogSettingsPageEventsProcessSchema

	/// <exclude/>
	public class ClearChangeLogSettingsPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public ClearChangeLogSettingsPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ClearChangeLogSettingsPageEventsProcessSchema(ClearChangeLogSettingsPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ClearChangeLogSettingsPageEventsProcess";
			UId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet90 = CreateLaneSet90LaneSet();
			LaneSets.Add(schemaLaneSet90);
			ProcessSchemaLane schemaLane216 = CreateLane216Lane();
			schemaLaneSet90.Lanes.Add(schemaLane216);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask okbuttonclickedscripttask1 = CreateOkButtonClickedScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(okbuttonclickedscripttask1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask cancelbuttonclickedscripttask2 = CreateCancelButtonClickedScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(cancelbuttonclickedscripttask2);
			ProcessSchemaStartMessageEvent pageloadcompletescripttaskstartmessage = CreatePageLoadCompleteScriptTaskStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(pageloadcompletescripttaskstartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(pageloadcompletescripttask);
			FlowElements.Add(CreateSequenceFlow692SequenceFlow());
			FlowElements.Add(CreateSequenceFlow693SequenceFlow());
			FlowElements.Add(CreateSequenceFlow694SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow692SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow692",
				UId = new Guid("93506ffb-f9c7-4fc7-809f-c474437b190c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b187a91e-41a2-470f-9b91-8e4a490eca16"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f17984f-3b1a-4459-b020-6c8390bd0438"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow693SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow693",
				UId = new Guid("7c8a915a-3789-40ee-a574-fce63efbe75d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2cd4f4f1-dc1f-4dc5-95d2-078f4df51b00"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("04ccf6d9-a898-42e0-8958-1fa4d84cd73c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow694SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow694",
				UId = new Guid("e0d9530c-84e5-42bd-805b-aa210bd74d9a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				CurveCenterPosition = new Point(214, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96aca591-2b16-4252-b677-bcd95646dcdb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45690794-fa21-4dcd-9a22-3de37149177c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet90LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet90 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("88d3ff43-baab-460e-ac78-74ed592281e2"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"LaneSet90",
				Position = new Point(5, 5),
				Size = new Size(794, 159),
				UseBackgroundMode = false
			};
			return schemaLaneSet90;
		}

		protected virtual ProcessSchemaLane CreateLane216Lane() {
			ProcessSchemaLane schemaLane216 = new ProcessSchemaLane(this) {
				UId = new Guid("02705a1c-6219-433a-88a1-79c776e3573a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("88d3ff43-baab-460e-ac78-74ed592281e2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"Lane216",
				Position = new Point(29, 0),
				Size = new Size(765, 159),
				UseBackgroundMode = false
			};
			return schemaLane216;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f5433b26-5de5-4931-be4f-a05b7e14ecbc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02705a1c-6219-433a-88a1-79c776e3573a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(311, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b187a91e-41a2-470f-9b91-8e4a490eca16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5433b26-5de5-4931-be4f-a05b7e14ecbc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"StartMessage1",
				Position = new Point(57, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickedScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2f17984f-3b1a-4459-b020-6c8390bd0438"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5433b26-5de5-4931-be4f-a05b7e14ecbc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"OkButtonClickedScriptTask1",
				Position = new Point(185, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,79,75,3,49,16,197,207,22,250,29,194,158,186,32,249,2,254,1,155,45,82,16,17,219,234,161,244,144,110,94,183,209,108,82,38,179,104,17,191,187,105,86,168,96,61,121,26,6,222,251,189,153,87,217,154,109,240,154,246,151,145,201,250,230,60,172,95,80,243,181,216,105,210,45,24,20,197,149,24,85,127,233,202,69,4,169,224,61,178,64,206,16,99,154,149,102,189,44,148,131,38,181,213,190,193,93,104,102,96,78,206,120,100,21,171,139,225,224,24,180,44,238,1,147,77,197,42,165,50,117,72,2,187,25,61,232,6,242,198,185,137,103,203,22,241,81,27,27,198,29,115,74,84,91,212,175,48,165,248,24,14,206,78,194,146,241,39,239,115,56,128,139,248,165,87,29,17,60,231,140,253,172,222,162,213,83,147,141,30,111,226,182,179,166,191,163,23,168,208,174,195,56,188,79,140,229,244,181,75,255,195,76,25,173,124,210,174,67,217,7,157,188,103,140,77,32,100,114,6,246,123,170,12,115,219,34,3,51,35,33,254,215,110,10,56,30,144,104,223,61,198,221,97,10,29,197,28,68,58,134,13,203,197,84,62,99,157,162,152,130,139,242,32,40,165,114,33,98,116,120,133,192,29,249,190,193,47,238,118,4,135,52,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b6dcffe5-2c3d-419b-bef1-dc241404d3e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02705a1c-6219-433a-88a1-79c776e3573a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"EventSubProcess2",
				Position = new Point(364, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(318, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2cd4f4f1-dc1f-4dc5-95d2-078f4df51b00"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6dcffe5-2c3d-419b-bef1-dc241404d3e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"StartMessage2",
				Position = new Point(50, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickedScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("04ccf6d9-a898-42e0-8958-1fa4d84cd73c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b6dcffe5-2c3d-419b-bef1-dc241404d3e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"CancelButtonClickedScriptTask2",
				Position = new Point(197, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7e14158d-bee0-40de-91bd-6c4c86af0e6d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02705a1c-6219-433a-88a1-79c776e3573a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 178),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(329, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteScriptTaskStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("96aca591-2b16-4252-b677-bcd95646dcdb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e14158d-bee0-40de-91bd-6c4c86af0e6d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"PageLoadCompleteScriptTaskStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(57, 66),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("45690794-fa21-4dcd-9a22-3de37149177c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e14158d-bee0-40de-91bd-6c4c86af0e6d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,193,142,218,48,20,60,111,190,194,205,133,68,139,162,237,57,75,213,37,208,22,137,182,171,165,237,5,113,48,241,35,184,117,108,100,59,101,41,202,191,247,217,73,10,187,34,187,199,230,18,57,30,207,155,55,111,226,123,90,64,178,0,1,185,5,54,149,150,219,195,3,101,92,141,43,107,149,76,178,45,228,191,128,141,172,174,32,13,38,60,183,92,73,170,15,183,198,106,46,139,161,90,255,196,147,239,200,142,106,90,130,5,109,200,136,68,189,184,248,187,1,157,41,41,193,3,176,176,49,248,158,80,75,151,97,38,128,234,108,75,101,1,115,85,44,192,90,60,105,78,92,225,42,13,62,86,156,145,188,210,26,164,109,212,46,242,45,148,116,198,92,93,183,27,159,164,32,229,37,100,199,179,92,17,161,138,162,107,187,219,54,29,211,114,245,132,107,126,9,235,184,154,22,159,177,101,116,231,100,123,178,14,208,75,215,129,29,219,70,105,18,113,105,9,31,221,164,132,147,219,203,34,147,57,200,194,110,17,113,125,29,147,99,112,117,239,6,217,210,169,114,173,198,234,113,202,184,77,238,24,155,89,40,163,139,44,75,190,26,94,82,141,223,227,52,184,226,27,210,123,142,140,70,151,7,225,213,244,202,105,162,246,162,34,87,185,14,234,192,83,140,1,13,1,12,8,124,227,37,120,138,31,84,84,128,190,158,187,249,5,128,249,252,52,120,103,228,111,170,137,201,53,223,217,177,98,7,196,191,15,247,92,50,181,79,148,60,139,184,79,56,238,110,42,233,131,22,233,53,118,224,90,192,199,25,240,70,175,147,188,249,13,220,6,209,96,43,45,201,134,10,3,41,169,107,132,157,192,136,197,128,162,53,131,227,219,122,112,34,186,58,222,212,137,1,180,138,174,5,176,200,159,118,141,186,167,174,9,224,178,23,236,126,190,19,214,191,177,110,26,166,141,69,56,225,133,239,179,13,90,242,65,233,146,226,234,95,243,67,210,55,142,76,112,28,224,108,210,34,238,132,240,32,14,230,201,45,208,162,226,248,149,146,161,83,142,30,14,188,97,131,33,233,117,124,72,236,150,155,56,13,255,123,229,23,46,191,231,197,155,202,159,169,196,133,62,147,18,182,3,123,0,202,190,74,113,104,39,70,220,103,42,132,218,79,203,157,117,17,108,66,19,190,62,15,172,56,147,232,6,21,252,15,224,133,105,225,209,126,2,177,107,148,69,184,221,198,208,95,204,127,1,142,78,39,1,197,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitializeContextHelpButtonMethod());
			Methods.Add(CreateGetIsContextHelpButtonHiddenMethod());
			Methods.Add(CreateGetIsContextHelpEnabledMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9310d1ca-d6aa-487a-aa73-195ec6e6ea5b"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("59478ba3-5ad7-456a-b715-27d7da6ce0d5"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,185,174,194,48,16,69,107,248,138,33,5,36,2,249,7,158,40,216,4,41,88,4,72,212,134,76,32,224,140,35,219,1,36,196,191,63,59,129,2,16,75,101,207,213,185,103,38,137,193,175,13,209,132,186,39,201,224,217,140,80,100,221,220,24,73,163,36,138,144,252,0,234,117,120,38,6,196,215,2,35,63,8,224,82,173,204,248,22,217,75,159,149,2,104,67,204,133,198,191,183,92,152,186,124,33,115,181,65,75,59,64,73,81,164,101,200,230,168,139,207,152,147,13,213,55,213,19,62,225,169,243,122,75,84,138,107,25,27,182,194,117,39,203,188,95,61,161,193,244,46,217,89,136,101,180,253,80,238,236,249,121,112,68,50,154,245,68,178,57,176,41,217,215,206,69,248,120,137,171,221,12,76,239,228,201,205,62,229,66,180,160,225,65,19,222,172,40,125,97,223,18,94,35,176,183,92,255,1,60,248,138,253,201,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4a5d8b36-7844-4719-96fd-0ceccafb807c"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c743e510-3a6c-44df-9236-1014e60719ce"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ClearChangeLogSettingsPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("669cece4-ea2d-4883-a857-a28f628c4e27"));
		}

		#endregion

	}

	#endregion

}

