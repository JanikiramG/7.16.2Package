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

	#region Class: SetColumnPrimaryInfoPageSchema

	/// <exclude/>
	public class SetColumnPrimaryInfoPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return _mainControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _captionControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CaptionControlLayout {
			get {
				return _captionControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _captionLabel;
		public Terrasoft.UI.WebControls.Controls.Label CaptionLabel {
			get {
				return _captionLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _nameCaptionControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout NameCaptionControlLayout {
			get {
				return _nameCaptionControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _captiontEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CaptiontEdit {
			get {
				return _captiontEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _columnTypeLabel;
		public Terrasoft.UI.WebControls.Controls.Label ColumnTypeLabel {
			get {
				return _columnTypeLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _columnTypeControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ColumnTypeControlLayout {
			get {
				return _columnTypeControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _stringDateControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout StringDateControlLayout {
			get {
				return _stringDateControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _stringControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout StringControlLayout {
			get {
				return _stringControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _shortTextRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton ShortTextRadioButton {
			get {
				return _shortTextRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _mediumTextRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton MediumTextRadioButton {
			get {
				return _mediumTextRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _longTextRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton LongTextRadioButton {
			get {
				return _longTextRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _maxSizeTextRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton MaxSizeTextRadioButton {
			get {
				return _maxSizeTextRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _secureTextRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton SecureTextRadioButton {
			get {
				return _secureTextRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _dateTimeControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout DateTimeControlLayout {
			get {
				return _dateTimeControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _dateTimeRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton DateTimeRadioButton {
			get {
				return _dateTimeRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _dateRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton DateRadioButton {
			get {
				return _dateRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _timeRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton TimeRadioButton {
			get {
				return _timeRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _numberOtherControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout NumberOtherControlLayout {
			get {
				return _numberOtherControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _numberControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout NumberControlLayout {
			get {
				return _numberControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _integerRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton IntegerRadioButton {
			get {
				return _integerRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _floatRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton FloatRadioButton {
			get {
				return _floatRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _moneyRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton MoneyRadioButton {
			get {
				return _moneyRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _otherFieldsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout OtherFieldsControlLayout {
			get {
				return _otherFieldsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _booleanRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton BooleanRadioButton {
			get {
				return _booleanRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _lookupRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton LookupRadioButton {
			get {
				return _lookupRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _dictionaryLookupEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit DictionaryLookupEdit {
			get {
				return _dictionaryLookupEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _binaryRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton BinaryRadioButton {
			get {
				return _binaryRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _multiLookupRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton MultiLookupRadioButton {
			get {
				return _multiLookupRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _lookupPageContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer LookupPageContainer {
			get {
				return _lookupPageContainer;
			}
		}

		#endregion

		#region Constructors: Public

		public SetColumnPrimaryInfoPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SetColumnPrimaryInfoPageSchema(SetColumnPrimaryInfoPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			RealUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			Name = "SetColumnPrimaryInfoPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 350;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSetColumnPrimaryInfoPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateCaptionControlLayout());
			CaptionControlLayout.InsertItem(0, CreateCaptionLabel());
			MainControlLayout.InsertItem(1, CreateNameCaptionControlLayout());
			NameCaptionControlLayout.InsertItem(0, CreateNameEdit());
			NameCaptionControlLayout.InsertItem(1, CreateSpacer1());
			NameCaptionControlLayout.InsertItem(2, CreateCaptiontEdit());
			MainControlLayout.InsertItem(2, CreateColumnTypeLabel());
			MainControlLayout.InsertItem(3, CreateColumnTypeControlLayout());
			ColumnTypeControlLayout.InsertItem(0, CreateStringDateControlLayout());
			StringDateControlLayout.InsertItem(0, CreateStringControlLayout());
			StringControlLayout.InsertItem(0, CreateShortTextRadioButton());
			StringControlLayout.InsertItem(1, CreateMediumTextRadioButton());
			StringControlLayout.InsertItem(2, CreateLongTextRadioButton());
			StringControlLayout.InsertItem(3, CreateMaxSizeTextRadioButton());
			StringControlLayout.InsertItem(4, CreateSecureTextRadioButton());
			StringDateControlLayout.InsertItem(1, CreateDateTimeControlLayout());
			DateTimeControlLayout.InsertItem(0, CreateDateTimeRadioButton());
			DateTimeControlLayout.InsertItem(1, CreateDateRadioButton());
			DateTimeControlLayout.InsertItem(2, CreateTimeRadioButton());
			ColumnTypeControlLayout.InsertItem(1, CreateNumberOtherControlLayout());
			NumberOtherControlLayout.InsertItem(0, CreateNumberControlLayout());
			NumberControlLayout.InsertItem(0, CreateIntegerRadioButton());
			NumberControlLayout.InsertItem(1, CreateFloatRadioButton());
			NumberControlLayout.InsertItem(2, CreateMoneyRadioButton());
			NumberOtherControlLayout.InsertItem(1, CreateOtherFieldsControlLayout());
			OtherFieldsControlLayout.InsertItem(0, CreateBooleanRadioButton());
			OtherFieldsControlLayout.InsertItem(1, CreateLookupRadioButton());
			OtherFieldsControlLayout.InsertItem(2, CreateDictionaryLookupEdit());
			OtherFieldsControlLayout.InsertItem(3, CreateBinaryRadioButton());
			OtherFieldsControlLayout.InsertItem(4, CreateMultiLookupRadioButton());
			OtherFieldsControlLayout.InsertItem(5, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateLookupPageContainer());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSetColumnPrimaryInfoPageEventsProcessSchema() {
			var schema = new SetColumnPrimaryInfoPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateCaptionLabel() {
			_captionLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_captionLabel.UId = new Guid("1cd73156-6e60-4fb6-a24b-1279882eb433");
			_captionLabel.Name = "CaptionLabel";
			_captionLabel.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_captionLabel.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_captionLabel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionLabel.Tag = "";
			_captionLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _captionLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCaptionControlLayout() {
			_captionControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_captionControlLayout.UId = new Guid("6ba98a7d-9e4a-4643-86e8-e3670a6503ac");
			_captionControlLayout.Name = "CaptionControlLayout";
			_captionControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_captionControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_captionControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionControlLayout.Tag = "";
			_captionControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(30);
			_captionControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_captionControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionControlLayout.StartNewAlignGroup = false;
			_captionControlLayout.Image = new ControlImage {};
			_captionControlLayout.Edges = "";
			return _captionControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("31f0656f-fe7d-425a-b5ec-db38c1f7c6ab");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_nameEdit.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("a7e84981-9c48-45e0-9166-d4bb339408e8");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_spacer1.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCaptiontEdit() {
			_captiontEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_captiontEdit.UId = new Guid("1aaac08f-91a3-4be8-a540-9c9d8023ebcb");
			_captiontEdit.Name = "CaptiontEdit";
			_captiontEdit.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_captiontEdit.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_captiontEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captiontEdit.Tag = "";
			_captiontEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captiontEdit.Image = new ControlImage {};
			_captiontEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _captiontEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNameCaptionControlLayout() {
			_nameCaptionControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_nameCaptionControlLayout.UId = new Guid("6bcdf750-108d-4da3-87dc-f1f51e2335b5");
			_nameCaptionControlLayout.Name = "NameCaptionControlLayout";
			_nameCaptionControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_nameCaptionControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_nameCaptionControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameCaptionControlLayout.Tag = "";
			_nameCaptionControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(30);
			_nameCaptionControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_nameCaptionControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_nameCaptionControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameCaptionControlLayout.StartNewAlignGroup = false;
			_nameCaptionControlLayout.Image = new ControlImage {};
			_nameCaptionControlLayout.Edges = "0 1 1 1";
			return _nameCaptionControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateColumnTypeLabel() {
			_columnTypeLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_columnTypeLabel.UId = new Guid("1de3b9ca-21ae-49bc-965d-503661d6460b");
			_columnTypeLabel.Name = "ColumnTypeLabel";
			_columnTypeLabel.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_columnTypeLabel.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_columnTypeLabel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnTypeLabel.Tag = "";
			_columnTypeLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnTypeLabel.Width = System.Web.UI.WebControls.Unit.Pixel(70);
			_columnTypeLabel.Margins = "10 0 10 10";
			return _columnTypeLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateShortTextRadioButton() {
			_shortTextRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_shortTextRadioButton.UId = new Guid("3315ae02-61b0-4273-80eb-1f93fca7f770");
			_shortTextRadioButton.Name = "ShortTextRadioButton";
			_shortTextRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_shortTextRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_shortTextRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_shortTextRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_shortTextRadioButton.Tag = "";
			_shortTextRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_shortTextRadioButton.GroupName = "MainGroup";
			return _shortTextRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMediumTextRadioButton() {
			_mediumTextRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_mediumTextRadioButton.UId = new Guid("1cc3f4cd-44ed-4b49-b8c7-351b3c3b226c");
			_mediumTextRadioButton.Name = "MediumTextRadioButton";
			_mediumTextRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_mediumTextRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_mediumTextRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mediumTextRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_mediumTextRadioButton.Tag = "";
			_mediumTextRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_mediumTextRadioButton.GroupName = "MainGroup";
			return _mediumTextRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateLongTextRadioButton() {
			_longTextRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_longTextRadioButton.UId = new Guid("bca02b92-d1bc-45c5-89dc-dbbfa64cb709");
			_longTextRadioButton.Name = "LongTextRadioButton";
			_longTextRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_longTextRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_longTextRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_longTextRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_longTextRadioButton.Tag = "";
			_longTextRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_longTextRadioButton.GroupName = "MainGroup";
			return _longTextRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMaxSizeTextRadioButton() {
			_maxSizeTextRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_maxSizeTextRadioButton.UId = new Guid("66b35ba0-ae7d-4606-8c4e-e58af8200492");
			_maxSizeTextRadioButton.Name = "MaxSizeTextRadioButton";
			_maxSizeTextRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_maxSizeTextRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_maxSizeTextRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_maxSizeTextRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_maxSizeTextRadioButton.Tag = "";
			_maxSizeTextRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_maxSizeTextRadioButton.GroupName = "MainGroup";
			return _maxSizeTextRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateSecureTextRadioButton() {
			_secureTextRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_secureTextRadioButton.UId = new Guid("0da545d2-c2fa-41c8-8c78-f35ff79b4a98");
			_secureTextRadioButton.Name = "SecureTextRadioButton";
			_secureTextRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_secureTextRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_secureTextRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_secureTextRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_secureTextRadioButton.Tag = "";
			_secureTextRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_secureTextRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_secureTextRadioButton.GroupName = "MainGroup";
			return _secureTextRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateStringControlLayout() {
			_stringControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_stringControlLayout.UId = new Guid("bead296d-dc8e-4bed-a7b1-b53371c35de9");
			_stringControlLayout.Name = "StringControlLayout";
			_stringControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_stringControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_stringControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_stringControlLayout.Tag = "";
			_stringControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_stringControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_stringControlLayout.FitHeightByContent = true;
			_stringControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_stringControlLayout.StartNewAlignGroup = true;
			_stringControlLayout.Image = new ControlImage {};
			_stringControlLayout.Edges = "";
			return _stringControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateDateTimeRadioButton() {
			_dateTimeRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_dateTimeRadioButton.UId = new Guid("b4c38b13-e8e9-42a1-838c-6c4db98bc313");
			_dateTimeRadioButton.Name = "DateTimeRadioButton";
			_dateTimeRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_dateTimeRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_dateTimeRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dateTimeRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_dateTimeRadioButton.Tag = "";
			_dateTimeRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dateTimeRadioButton.GroupName = "MainGroup";
			return _dateTimeRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateDateRadioButton() {
			_dateRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_dateRadioButton.UId = new Guid("ae92681a-03f8-42b2-9d4f-c17a98351c06");
			_dateRadioButton.Name = "DateRadioButton";
			_dateRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_dateRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_dateRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dateRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_dateRadioButton.Tag = "";
			_dateRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dateRadioButton.GroupName = "MainGroup";
			return _dateRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateTimeRadioButton() {
			_timeRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_timeRadioButton.UId = new Guid("f029754a-5eb7-43c4-ac55-0fce2016a64c");
			_timeRadioButton.Name = "TimeRadioButton";
			_timeRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_timeRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_timeRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_timeRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_timeRadioButton.Tag = "";
			_timeRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_timeRadioButton.GroupName = "MainGroup";
			return _timeRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateDateTimeControlLayout() {
			_dateTimeControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_dateTimeControlLayout.UId = new Guid("aeed1921-0ab1-427d-a255-67f11dd90bdc");
			_dateTimeControlLayout.Name = "DateTimeControlLayout";
			_dateTimeControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_dateTimeControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_dateTimeControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dateTimeControlLayout.Tag = "";
			_dateTimeControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_dateTimeControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_dateTimeControlLayout.FitHeightByContent = true;
			_dateTimeControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_dateTimeControlLayout.StartNewAlignGroup = true;
			_dateTimeControlLayout.Image = new ControlImage {};
			_dateTimeControlLayout.Edges = "";
			return _dateTimeControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateStringDateControlLayout() {
			_stringDateControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_stringDateControlLayout.UId = new Guid("96773184-2fb2-424f-ba31-92a63d625c9b");
			_stringDateControlLayout.Name = "StringDateControlLayout";
			_stringDateControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_stringDateControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_stringDateControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_stringDateControlLayout.Tag = "";
			_stringDateControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_stringDateControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_stringDateControlLayout.FitHeightByContent = true;
			_stringDateControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_stringDateControlLayout.Padding = "0 0 0 10";
			_stringDateControlLayout.StartNewAlignGroup = false;
			_stringDateControlLayout.Image = new ControlImage {};
			_stringDateControlLayout.Edges = "";
			return _stringDateControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateIntegerRadioButton() {
			_integerRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_integerRadioButton.UId = new Guid("ad5e8bee-66b5-45df-a7e4-50927002b25c");
			_integerRadioButton.Name = "IntegerRadioButton";
			_integerRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_integerRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_integerRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_integerRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_integerRadioButton.Tag = "";
			_integerRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_integerRadioButton.GroupName = "MainGroup";
			return _integerRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateFloatRadioButton() {
			_floatRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_floatRadioButton.UId = new Guid("214e1acf-11da-4cac-ae72-d09e0510451f");
			_floatRadioButton.Name = "FloatRadioButton";
			_floatRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_floatRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_floatRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_floatRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_floatRadioButton.Tag = "";
			_floatRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_floatRadioButton.GroupName = "MainGroup";
			return _floatRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMoneyRadioButton() {
			_moneyRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_moneyRadioButton.UId = new Guid("8a37fe8a-c7b0-4285-8a03-726afd337817");
			_moneyRadioButton.Name = "MoneyRadioButton";
			_moneyRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_moneyRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_moneyRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_moneyRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_moneyRadioButton.Tag = "";
			_moneyRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_moneyRadioButton.GroupName = "MainGroup";
			return _moneyRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNumberControlLayout() {
			_numberControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_numberControlLayout.UId = new Guid("fcb0119e-0b6d-494b-9c41-75b21fd0a18d");
			_numberControlLayout.Name = "NumberControlLayout";
			_numberControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_numberControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_numberControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_numberControlLayout.Tag = "";
			_numberControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_numberControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_numberControlLayout.FitHeightByContent = true;
			_numberControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_numberControlLayout.StartNewAlignGroup = false;
			_numberControlLayout.Image = new ControlImage {};
			_numberControlLayout.Edges = "";
			return _numberControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateBooleanRadioButton() {
			_booleanRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_booleanRadioButton.UId = new Guid("9b0a733c-6ffb-4c8e-bfef-fdc32a7fd61a");
			_booleanRadioButton.Name = "BooleanRadioButton";
			_booleanRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_booleanRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_booleanRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_booleanRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_booleanRadioButton.Tag = "";
			_booleanRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_booleanRadioButton.GroupName = "MainGroup";
			return _booleanRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateLookupRadioButton() {
			_lookupRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_lookupRadioButton.UId = new Guid("e9c9fc2c-bd3d-46ef-9962-5a381087d35c");
			_lookupRadioButton.Name = "LookupRadioButton";
			_lookupRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_lookupRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_lookupRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lookupRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_lookupRadioButton.Tag = "";
			_lookupRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lookupRadioButton.GroupName = "MainGroup";
			return _lookupRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateDictionaryLookupEdit() {
			_dictionaryLookupEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_dictionaryLookupEdit.UId = new Guid("794c1455-a330-4f3e-a51c-84649909b61b");
			_dictionaryLookupEdit.Name = "DictionaryLookupEdit";
			_dictionaryLookupEdit.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_dictionaryLookupEdit.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_dictionaryLookupEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dictionaryLookupEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_dictionaryLookupEdit.Tag = "";
			_dictionaryLookupEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dictionaryLookupEdit.Image = new ControlImage {};
			_dictionaryLookupEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_dictionaryLookupEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_dictionaryLookupEdit.AlignedByCaption = false;
			_dictionaryLookupEdit.Margins = "0 0 0 10";
			_dictionaryLookupEdit.Enabled = false;
			_dictionaryLookupEdit.LookupSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868");
			return _dictionaryLookupEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateBinaryRadioButton() {
			_binaryRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_binaryRadioButton.UId = new Guid("5cf50ebc-5679-4a73-9d2c-fb72fe8b2d6d");
			_binaryRadioButton.Name = "BinaryRadioButton";
			_binaryRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_binaryRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_binaryRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_binaryRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_binaryRadioButton.Tag = "";
			_binaryRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_binaryRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_binaryRadioButton.GroupName = "MainGroup";
			return _binaryRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMultiLookupRadioButton() {
			_multiLookupRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_multiLookupRadioButton.UId = new Guid("f32ce96f-0299-4330-b74d-af95d1ed2efb");
			_multiLookupRadioButton.Name = "MultiLookupRadioButton";
			_multiLookupRadioButton.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_multiLookupRadioButton.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_multiLookupRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_multiLookupRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_multiLookupRadioButton.Tag = "";
			_multiLookupRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_multiLookupRadioButton.GroupName = "MainGroup";
			_multiLookupRadioButton.Hidden = true;
			return _multiLookupRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateLookupPageContainer() {
			_lookupPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_lookupPageContainer.UId = new Guid("5aefd296-9c83-4b3f-9c6a-9083b2156829");
			_lookupPageContainer.Name = "LookupPageContainer";
			_lookupPageContainer.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_lookupPageContainer.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_lookupPageContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lookupPageContainer.Tag = "";
			_lookupPageContainer.PageSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
			_lookupPageContainer.Height = System.Web.UI.WebControls.Unit.Pixel(200);
			_lookupPageContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_lookupPageContainer.StartNewAlignGroup = false;
			_lookupPageContainer.Edges = "1 1 1 1";
			_lookupPageContainer.Enabled = false;
			return _lookupPageContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("3babae63-123f-4600-bcd3-2a18f7c8d56f");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_controlLayout1.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(200);
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.Padding = "0 0 0 10";
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			_controlLayout1.Hidden = true;
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateOtherFieldsControlLayout() {
			_otherFieldsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_otherFieldsControlLayout.UId = new Guid("94d5a762-dd92-4cca-b959-f6be335be44c");
			_otherFieldsControlLayout.Name = "OtherFieldsControlLayout";
			_otherFieldsControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_otherFieldsControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_otherFieldsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_otherFieldsControlLayout.Tag = "";
			_otherFieldsControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_otherFieldsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_otherFieldsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_otherFieldsControlLayout.StartNewAlignGroup = false;
			_otherFieldsControlLayout.Image = new ControlImage {};
			_otherFieldsControlLayout.Edges = "";
			return _otherFieldsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNumberOtherControlLayout() {
			_numberOtherControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_numberOtherControlLayout.UId = new Guid("31edec19-6245-49a6-a593-885e5e956778");
			_numberOtherControlLayout.Name = "NumberOtherControlLayout";
			_numberOtherControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_numberOtherControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_numberOtherControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_numberOtherControlLayout.Tag = "";
			_numberOtherControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_numberOtherControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_numberOtherControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_numberOtherControlLayout.Padding = "0 10 0 10";
			_numberOtherControlLayout.StartNewAlignGroup = false;
			_numberOtherControlLayout.Image = new ControlImage {};
			_numberOtherControlLayout.Edges = "";
			return _numberOtherControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateColumnTypeControlLayout() {
			_columnTypeControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_columnTypeControlLayout.UId = new Guid("f1a06d08-5288-4627-bf05-2a1e7b786657");
			_columnTypeControlLayout.Name = "ColumnTypeControlLayout";
			_columnTypeControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_columnTypeControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_columnTypeControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnTypeControlLayout.Tag = "";
			_columnTypeControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnTypeControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_columnTypeControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnTypeControlLayout.StartNewAlignGroup = false;
			_columnTypeControlLayout.Image = new ControlImage {};
			_columnTypeControlLayout.Edges = "";
			return _columnTypeControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("60ab4eb9-1c4e-48cc-b9ad-1437f1ac0562");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			return _mainControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SetColumnPrimaryInfoPageSchemaUserControl();
		}

		public override object Clone() {
			return new SetColumnPrimaryInfoPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SetColumnPrimaryInfoPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SetColumnPrimaryInfoPageEventsProcess

	/// <exclude/>
	public class SetColumnPrimaryInfoPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.SetColumnPrimaryInfoPageSchemaUserControl
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

		public SetColumnPrimaryInfoPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SetColumnPrimaryInfoPageEventsProcess";
			SchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5");
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

		public virtual string ColumnType {
			get;
			set;
		}

		public virtual string ParentProcessUId {
			get;
			set;
		}

		public virtual Object RelatedLookupList {
			get;
			set;
		}

		public virtual bool TypeSelectionMode {
			get;
			set;
		}

		public virtual Guid LookupSchemaId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessColumnInfoLookupsChanged;
		public ProcessFlowElement EventSubProcessColumnInfoLookupsChanged {
			get {
				return _eventSubProcessColumnInfoLookupsChanged ?? (_eventSubProcessColumnInfoLookupsChanged = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessColumnInfoLookupsChanged",
					SchemaElementUId = new Guid("a95dcac2-1328-4390-a7d2-7ad73202376d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageColumnInfoLookupsChanged;
		public ProcessFlowElement StartMessageColumnInfoLookupsChanged {
			get {
				return _startMessageColumnInfoLookupsChanged ?? (_startMessageColumnInfoLookupsChanged = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageColumnInfoLookupsChanged",
					SchemaElementUId = new Guid("58384c66-2795-4d8c-8210-7a4ebc5ecdde"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptColumnInfoLookupsChanged;
		public ProcessScriptTask ScriptColumnInfoLookupsChanged {
			get {
				return _scriptColumnInfoLookupsChanged ?? (_scriptColumnInfoLookupsChanged = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptColumnInfoLookupsChanged",
					SchemaElementUId = new Guid("08d2223c-b529-490d-afe6-394f33b09320"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptColumnInfoLookupsChangedExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDirectSetColumnType;
		public ProcessFlowElement EventSubProcessDirectSetColumnType {
			get {
				return _eventSubProcessDirectSetColumnType ?? (_eventSubProcessDirectSetColumnType = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDirectSetColumnType",
					SchemaElementUId = new Guid("a58e8de0-ab64-4d2e-8934-a922d7741e68"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startDirectSetColumnType;
		public ProcessFlowElement StartDirectSetColumnType {
			get {
				return _startDirectSetColumnType ?? (_startDirectSetColumnType = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartDirectSetColumnType",
					SchemaElementUId = new Guid("9f434c71-1a60-43fe-8b4d-59fddf145209"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDirectSetColumnType;
		public ProcessScriptTask ScriptDirectSetColumnType {
			get {
				return _scriptDirectSetColumnType ?? (_scriptDirectSetColumnType = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDirectSetColumnType",
					SchemaElementUId = new Guid("cb5cc497-52b1-46f4-b769-6c7a4c083a5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDirectSetColumnTypeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess15;
		public ProcessFlowElement EventSubProcess15 {
			get {
				return _eventSubProcess15 ?? (_eventSubProcess15 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess15",
					SchemaElementUId = new Guid("a90a107e-3524-4786-9678-5ce7164e215f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDictionaryLookupEditChange;
		public ProcessFlowElement StartMessageDictionaryLookupEditChange {
			get {
				return _startMessageDictionaryLookupEditChange ?? (_startMessageDictionaryLookupEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDictionaryLookupEditChange",
					SchemaElementUId = new Guid("7874bc88-a4b2-4c20-ab80-ae43031e5da7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDictionaryLookupEditChange;
		public ProcessScriptTask ScriptDictionaryLookupEditChange {
			get {
				return _scriptDictionaryLookupEditChange ?? (_scriptDictionaryLookupEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDictionaryLookupEditChange",
					SchemaElementUId = new Guid("35b668b7-8060-4a04-bb98-fe69a93f0759"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDictionaryLookupEditChangeExecute,
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
					SchemaElementUId = new Guid("1410a316-9495-4c31-8af0-03dd67882863"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _lookupRadioButtonCheck;
		public ProcessFlowElement LookupRadioButtonCheck {
			get {
				return _lookupRadioButtonCheck ?? (_lookupRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LookupRadioButtonCheck",
					SchemaElementUId = new Guid("69ea8aeb-0cb8-43fd-a67b-9ca00096c05b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLookupRadioButtonCheck;
		public ProcessScriptTask ScriptLookupRadioButtonCheck {
			get {
				return _scriptLookupRadioButtonCheck ?? (_scriptLookupRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLookupRadioButtonCheck",
					SchemaElementUId = new Guid("9a1dee00-a4f4-4ead-82dd-a037738ad835"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLookupRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("ef550d8f-65af-4bfa-bca9-f6e27bcf3a85"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _multiLookupRadioButtonCheck;
		public ProcessFlowElement MultiLookupRadioButtonCheck {
			get {
				return _multiLookupRadioButtonCheck ?? (_multiLookupRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MultiLookupRadioButtonCheck",
					SchemaElementUId = new Guid("4384dd6a-32b7-4b66-aae1-4943d4b42308"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptRelatedLookupRadioButtonCheck;
		public ProcessScriptTask ScriptRelatedLookupRadioButtonCheck {
			get {
				return _scriptRelatedLookupRadioButtonCheck ?? (_scriptRelatedLookupRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptRelatedLookupRadioButtonCheck",
					SchemaElementUId = new Guid("8f547662-5444-4788-ad63-667b5c84105f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptRelatedLookupRadioButtonCheckExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess13;
		public ProcessFlowElement EventSubProcess13 {
			get {
				return _eventSubProcess13 ?? (_eventSubProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess13",
					SchemaElementUId = new Guid("69ddeb4e-c7d4-4051-96cf-b837b7bf4b55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _booleanRadioButtonCheck;
		public ProcessFlowElement BooleanRadioButtonCheck {
			get {
				return _booleanRadioButtonCheck ?? (_booleanRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BooleanRadioButtonCheck",
					SchemaElementUId = new Guid("b7315387-9307-491a-aecc-1b87aca8d317"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLogicRadioButtonCheck;
		public ProcessScriptTask ScriptLogicRadioButtonCheck {
			get {
				return _scriptLogicRadioButtonCheck ?? (_scriptLogicRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLogicRadioButtonCheck",
					SchemaElementUId = new Guid("d46ba082-926a-41c5-a545-642d4810777e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLogicRadioButtonCheckExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess16;
		public ProcessFlowElement EventSubProcess16 {
			get {
				return _eventSubProcess16 ?? (_eventSubProcess16 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess16",
					SchemaElementUId = new Guid("b5978477-aa6c-41a0-9c93-4559dc7924d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _binaryRadioButtonCheck;
		public ProcessFlowElement BinaryRadioButtonCheck {
			get {
				return _binaryRadioButtonCheck ?? (_binaryRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BinaryRadioButtonCheck",
					SchemaElementUId = new Guid("b3dcc705-837b-4182-9dcc-05f920c267d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _selectImageRadioButtonCheckScriptTask;
		public ProcessScriptTask SelectImageRadioButtonCheckScriptTask {
			get {
				return _selectImageRadioButtonCheckScriptTask ?? (_selectImageRadioButtonCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SelectImageRadioButtonCheckScriptTask",
					SchemaElementUId = new Guid("45f2866c-4064-4b3b-ad97-f26a140d0b89"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SelectImageRadioButtonCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("5ab95f01-18fb-4993-bc1a-cdb45bef6f99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dateTimeRadioButtonCheck;
		public ProcessFlowElement DateTimeRadioButtonCheck {
			get {
				return _dateTimeRadioButtonCheck ?? (_dateTimeRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DateTimeRadioButtonCheck",
					SchemaElementUId = new Guid("bf194d38-726a-48fa-b68b-04ab65f62098"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDateTimeRadioButtonCheck;
		public ProcessScriptTask ScriptDateTimeRadioButtonCheck {
			get {
				return _scriptDateTimeRadioButtonCheck ?? (_scriptDateTimeRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDateTimeRadioButtonCheck",
					SchemaElementUId = new Guid("3701a23b-01ed-40ff-95d0-411d2ba7f878"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDateTimeRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("9348d872-9098-4961-bb4d-70efaafbbc0b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dateRadioButtonCheck;
		public ProcessFlowElement DateRadioButtonCheck {
			get {
				return _dateRadioButtonCheck ?? (_dateRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DateRadioButtonCheck",
					SchemaElementUId = new Guid("e572dba6-89d8-48d3-966f-a965b2f8acbe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDateRadioButtonCheck;
		public ProcessScriptTask ScriptDateRadioButtonCheck {
			get {
				return _scriptDateRadioButtonCheck ?? (_scriptDateRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDateRadioButtonCheck",
					SchemaElementUId = new Guid("6a6506ac-4241-4696-9836-801073deab40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDateRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("e0772bb5-fe27-4c46-aa9f-c6a452af9a3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _timeRadioButtonCheck;
		public ProcessFlowElement TimeRadioButtonCheck {
			get {
				return _timeRadioButtonCheck ?? (_timeRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TimeRadioButtonCheck",
					SchemaElementUId = new Guid("64ea1073-39c8-4dbe-9725-6ccc8bd7275d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTimeRadioButtonCheck;
		public ProcessScriptTask ScriptTimeRadioButtonCheck {
			get {
				return _scriptTimeRadioButtonCheck ?? (_scriptTimeRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTimeRadioButtonCheck",
					SchemaElementUId = new Guid("5730e7c1-55ab-4764-8cee-4cfa6f001742"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTimeRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("67cd7304-2d1f-418d-9c42-d9e353e099d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _integerRadioButtonCheck;
		public ProcessFlowElement IntegerRadioButtonCheck {
			get {
				return _integerRadioButtonCheck ?? (_integerRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "IntegerRadioButtonCheck",
					SchemaElementUId = new Guid("519d270a-894a-4e2a-8ffd-3e519f9ba7f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptIntegerRadioButtonCheck;
		public ProcessScriptTask ScriptIntegerRadioButtonCheck {
			get {
				return _scriptIntegerRadioButtonCheck ?? (_scriptIntegerRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptIntegerRadioButtonCheck",
					SchemaElementUId = new Guid("463c30b2-7bdb-432c-98eb-2f3ff6b39863"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptIntegerRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("293deedc-89f1-430b-9b86-f5d53e006b40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _floatRadioButtonCheck;
		public ProcessFlowElement FloatRadioButtonCheck {
			get {
				return _floatRadioButtonCheck ?? (_floatRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FloatRadioButtonCheck",
					SchemaElementUId = new Guid("34fa592d-d8c1-428a-85f7-b54a111367a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptFloatRadioButtonCheck;
		public ProcessScriptTask ScriptFloatRadioButtonCheck {
			get {
				return _scriptFloatRadioButtonCheck ?? (_scriptFloatRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptFloatRadioButtonCheck",
					SchemaElementUId = new Guid("9cc92a92-ac0f-42d8-9424-51117f2cb585"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptFloatRadioButtonCheckExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess14;
		public ProcessFlowElement EventSubProcess14 {
			get {
				return _eventSubProcess14 ?? (_eventSubProcess14 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess14",
					SchemaElementUId = new Guid("c22aa2ed-6c97-4125-a824-830d91103354"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _moneyRadioButtonCheck;
		public ProcessFlowElement MoneyRadioButtonCheck {
			get {
				return _moneyRadioButtonCheck ?? (_moneyRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MoneyRadioButtonCheck",
					SchemaElementUId = new Guid("e549b0e1-838a-4459-8bf0-0f2a0f1621a4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptCurrencyRadioButtonCheck;
		public ProcessScriptTask ScriptCurrencyRadioButtonCheck {
			get {
				return _scriptCurrencyRadioButtonCheck ?? (_scriptCurrencyRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptCurrencyRadioButtonCheck",
					SchemaElementUId = new Guid("67ba233e-fcb9-45f7-b96f-d0b6638da749"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptCurrencyRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("11070241-39c3-434a-8b74-93348efe870c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _shortTextRadioButtonCheck;
		public ProcessFlowElement ShortTextRadioButtonCheck {
			get {
				return _shortTextRadioButtonCheck ?? (_shortTextRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ShortTextRadioButtonCheck",
					SchemaElementUId = new Guid("6970c956-ec46-4ec7-8733-1e8ab1a6ad53"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptShortStringRadioButtonCheck;
		public ProcessScriptTask ScriptShortStringRadioButtonCheck {
			get {
				return _scriptShortStringRadioButtonCheck ?? (_scriptShortStringRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptShortStringRadioButtonCheck",
					SchemaElementUId = new Guid("43514e45-6a3b-4d8a-958f-8d7088f8f043"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptShortStringRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("8fabbe9e-aa54-49dd-b6b9-a490f5ed4c82"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mediumTextRadioButtonCheck;
		public ProcessFlowElement MediumTextRadioButtonCheck {
			get {
				return _mediumTextRadioButtonCheck ?? (_mediumTextRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MediumTextRadioButtonCheck",
					SchemaElementUId = new Guid("e9d4c901-6138-4fe5-a675-fccab46457c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptMiddleStringRadioButtonCheck;
		public ProcessScriptTask ScriptMiddleStringRadioButtonCheck {
			get {
				return _scriptMiddleStringRadioButtonCheck ?? (_scriptMiddleStringRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptMiddleStringRadioButtonCheck",
					SchemaElementUId = new Guid("7700ffe3-3dc3-4871-8196-d780d6b837e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptMiddleStringRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("5b4a692a-66f1-46ab-811b-1a7146d468c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _longTextRadioButtonCheck;
		public ProcessFlowElement LongTextRadioButtonCheck {
			get {
				return _longTextRadioButtonCheck ?? (_longTextRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LongTextRadioButtonCheck",
					SchemaElementUId = new Guid("517f6398-8a0c-4728-86de-55551ce49040"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLongStringRadioButtonCheck;
		public ProcessScriptTask ScriptLongStringRadioButtonCheck {
			get {
				return _scriptLongStringRadioButtonCheck ?? (_scriptLongStringRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLongStringRadioButtonCheck",
					SchemaElementUId = new Guid("eed65fd6-d5a2-46bb-bacd-be53fa099414"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLongStringRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("f7b45d89-a2da-4b81-a993-cab13c9933c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _maxSizeTextRadioButtonCheck;
		public ProcessFlowElement MaxSizeTextRadioButtonCheck {
			get {
				return _maxSizeTextRadioButtonCheck ?? (_maxSizeTextRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MaxSizeTextRadioButtonCheck",
					SchemaElementUId = new Guid("f2ed4de5-9d62-4e70-957f-6327e904563b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptMaxStringRadioButtonCheck;
		public ProcessScriptTask ScriptMaxStringRadioButtonCheck {
			get {
				return _scriptMaxStringRadioButtonCheck ?? (_scriptMaxStringRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptMaxStringRadioButtonCheck",
					SchemaElementUId = new Guid("d2bc0fd0-fe1c-4e7a-812d-53bea83deda7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptMaxStringRadioButtonCheckExecute,
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
					SchemaElementUId = new Guid("76d7b553-8c6c-4e79-9378-9705ea23cc96"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _secureTextRadioButtonCheck;
		public ProcessFlowElement SecureTextRadioButtonCheck {
			get {
				return _secureTextRadioButtonCheck ?? (_secureTextRadioButtonCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SecureTextRadioButtonCheck",
					SchemaElementUId = new Guid("9292e915-2d29-4360-ab9a-ccd844708a07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSecureTextRadioButtonCheck;
		public ProcessScriptTask ScriptSecureTextRadioButtonCheck {
			get {
				return _scriptSecureTextRadioButtonCheck ?? (_scriptSecureTextRadioButtonCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSecureTextRadioButtonCheck",
					SchemaElementUId = new Guid("70d4b300-9479-4fec-86d8-551b06e71361"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSecureTextRadioButtonCheckExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadSubProcess;
		public ProcessFlowElement PageLoadSubProcess {
			get {
				return _pageLoadSubProcess ?? (_pageLoadSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadSubProcess",
					SchemaElementUId = new Guid("8036e55c-b1b1-45e7-9e4a-25682c974a26"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoad;
		public ProcessFlowElement PageLoad {
			get {
				return _pageLoad ?? (_pageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoad",
					SchemaElementUId = new Guid("aaf6f3f6-4346-4fb4-867f-ec11592efa9d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoad;
		public ProcessScriptTask ScriptPageLoad {
			get {
				return _scriptPageLoad ?? (_scriptPageLoad = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoad",
					SchemaElementUId = new Guid("fdb35110-ddbf-468d-b51a-25795be256e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadExecute,
				});
			}
		}

		private ProcessFlowElement _initSubProcess;
		public ProcessFlowElement InitSubProcess {
			get {
				return _initSubProcess ?? (_initSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitSubProcess",
					SchemaElementUId = new Guid("fec5daec-8a77-48bb-86fa-30f98e8fc8ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _returnParameters;
		public ProcessFlowElement ReturnParameters {
			get {
				return _returnParameters ?? (_returnParameters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ReturnParameters",
					SchemaElementUId = new Guid("c60033be-0c93-4c48-a201-10143ffb3279"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptReturnParameters;
		public ProcessScriptTask ScriptReturnParameters {
			get {
				return _scriptReturnParameters ?? (_scriptReturnParameters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptReturnParameters",
					SchemaElementUId = new Guid("f82d3c07-c6d2-4cf0-b70b-0f8b114954aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptReturnParametersExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteSubProcess;
		public ProcessFlowElement PageLoadCompleteSubProcess {
			get {
				return _pageLoadCompleteSubProcess ?? (_pageLoadCompleteSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteSubProcess",
					SchemaElementUId = new Guid("4c8c892d-d753-4d51-814c-f6809ac4d119"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadComplete;
		public ProcessFlowElement PageLoadComplete {
			get {
				return _pageLoadComplete ?? (_pageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadComplete",
					SchemaElementUId = new Guid("0b62c74e-57d1-48a7-b51e-03355e4d4e96"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadComplete;
		public ProcessScriptTask ScriptPageLoadComplete {
			get {
				return _scriptPageLoadComplete ?? (_scriptPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadComplete",
					SchemaElementUId = new Guid("de059205-8a87-46e3-a88f-ce6712cc437c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteExecute,
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
					SchemaElementUId = new Guid("9322d8b2-9a67-4a87-9863-7b91594e8f2c"),
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
					SchemaElementUId = new Guid("1b7687b3-83b1-4266-97b2-be7174c1419d"),
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
					SchemaElementUId = new Guid("d966fcc5-6e88-4cc8-80ca-d8d6a3ee97da"),
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
					SchemaElementUId = new Guid("640b672a-6784-463e-a571-ba4ce6399f6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessColumnInfoLookupsChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessColumnInfoLookupsChanged };
			FlowElements[StartMessageColumnInfoLookupsChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageColumnInfoLookupsChanged };
			FlowElements[ScriptColumnInfoLookupsChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptColumnInfoLookupsChanged };
			FlowElements[EventSubProcessDirectSetColumnType.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDirectSetColumnType };
			FlowElements[StartDirectSetColumnType.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDirectSetColumnType };
			FlowElements[ScriptDirectSetColumnType.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDirectSetColumnType };
			FlowElements[EventSubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess15 };
			FlowElements[StartMessageDictionaryLookupEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDictionaryLookupEditChange };
			FlowElements[ScriptDictionaryLookupEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDictionaryLookupEditChange };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[LookupRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupRadioButtonCheck };
			FlowElements[ScriptLookupRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLookupRadioButtonCheck };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[MultiLookupRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { MultiLookupRadioButtonCheck };
			FlowElements[ScriptRelatedLookupRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptRelatedLookupRadioButtonCheck };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[BooleanRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { BooleanRadioButtonCheck };
			FlowElements[ScriptLogicRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLogicRadioButtonCheck };
			FlowElements[EventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess16 };
			FlowElements[BinaryRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { BinaryRadioButtonCheck };
			FlowElements[SelectImageRadioButtonCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectImageRadioButtonCheckScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[DateTimeRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { DateTimeRadioButtonCheck };
			FlowElements[ScriptDateTimeRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDateTimeRadioButtonCheck };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[DateRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { DateRadioButtonCheck };
			FlowElements[ScriptDateRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDateRadioButtonCheck };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[TimeRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { TimeRadioButtonCheck };
			FlowElements[ScriptTimeRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTimeRadioButtonCheck };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[IntegerRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { IntegerRadioButtonCheck };
			FlowElements[ScriptIntegerRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptIntegerRadioButtonCheck };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[FloatRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { FloatRadioButtonCheck };
			FlowElements[ScriptFloatRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptFloatRadioButtonCheck };
			FlowElements[EventSubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess14 };
			FlowElements[MoneyRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { MoneyRadioButtonCheck };
			FlowElements[ScriptCurrencyRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptCurrencyRadioButtonCheck };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ShortTextRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ShortTextRadioButtonCheck };
			FlowElements[ScriptShortStringRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptShortStringRadioButtonCheck };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[MediumTextRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { MediumTextRadioButtonCheck };
			FlowElements[ScriptMiddleStringRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptMiddleStringRadioButtonCheck };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[LongTextRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { LongTextRadioButtonCheck };
			FlowElements[ScriptLongStringRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLongStringRadioButtonCheck };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[MaxSizeTextRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { MaxSizeTextRadioButtonCheck };
			FlowElements[ScriptMaxStringRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptMaxStringRadioButtonCheck };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[SecureTextRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { SecureTextRadioButtonCheck };
			FlowElements[ScriptSecureTextRadioButtonCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSecureTextRadioButtonCheck };
			FlowElements[PageLoadSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadSubProcess };
			FlowElements[PageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoad };
			FlowElements[ScriptPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoad };
			FlowElements[InitSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitSubProcess };
			FlowElements[ReturnParameters.SchemaElementUId] = new Collection<ProcessFlowElement> { ReturnParameters };
			FlowElements[ScriptReturnParameters.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptReturnParameters };
			FlowElements[PageLoadCompleteSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteSubProcess };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[ScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadComplete };
			FlowElements[ChildInitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitEventSubProcess };
			FlowElements[ChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInit };
			FlowElements[BaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseInit };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessColumnInfoLookupsChanged":
						break;
					case "StartMessageColumnInfoLookupsChanged":
						e.Context.QueueTasks.Enqueue("ScriptColumnInfoLookupsChanged");
						break;
					case "ScriptColumnInfoLookupsChanged":
						break;
					case "EventSubProcessDirectSetColumnType":
						break;
					case "StartDirectSetColumnType":
						e.Context.QueueTasks.Enqueue("ScriptDirectSetColumnType");
						break;
					case "ScriptDirectSetColumnType":
						break;
					case "EventSubProcess15":
						break;
					case "StartMessageDictionaryLookupEditChange":
						e.Context.QueueTasks.Enqueue("ScriptDictionaryLookupEditChange");
						break;
					case "ScriptDictionaryLookupEditChange":
						break;
					case "EventSubProcess11":
						break;
					case "LookupRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptLookupRadioButtonCheck");
						break;
					case "ScriptLookupRadioButtonCheck":
						break;
					case "EventSubProcess12":
						break;
					case "MultiLookupRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptRelatedLookupRadioButtonCheck");
						break;
					case "ScriptRelatedLookupRadioButtonCheck":
						break;
					case "EventSubProcess13":
						break;
					case "BooleanRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptLogicRadioButtonCheck");
						break;
					case "ScriptLogicRadioButtonCheck":
						break;
					case "EventSubProcess16":
						break;
					case "BinaryRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("SelectImageRadioButtonCheckScriptTask");
						break;
					case "SelectImageRadioButtonCheckScriptTask":
						break;
					case "EventSubProcess8":
						break;
					case "DateTimeRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptDateTimeRadioButtonCheck");
						break;
					case "ScriptDateTimeRadioButtonCheck":
						break;
					case "EventSubProcess9":
						break;
					case "DateRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptDateRadioButtonCheck");
						break;
					case "ScriptDateRadioButtonCheck":
						break;
					case "EventSubProcess10":
						break;
					case "TimeRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptTimeRadioButtonCheck");
						break;
					case "ScriptTimeRadioButtonCheck":
						break;
					case "EventSubProcess5":
						break;
					case "IntegerRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptIntegerRadioButtonCheck");
						break;
					case "ScriptIntegerRadioButtonCheck":
						break;
					case "EventSubProcess6":
						break;
					case "FloatRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptFloatRadioButtonCheck");
						break;
					case "ScriptFloatRadioButtonCheck":
						break;
					case "EventSubProcess14":
						break;
					case "MoneyRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptCurrencyRadioButtonCheck");
						break;
					case "ScriptCurrencyRadioButtonCheck":
						break;
					case "EventSubProcess1":
						break;
					case "ShortTextRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptShortStringRadioButtonCheck");
						break;
					case "ScriptShortStringRadioButtonCheck":
						break;
					case "EventSubProcess2":
						break;
					case "MediumTextRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptMiddleStringRadioButtonCheck");
						break;
					case "ScriptMiddleStringRadioButtonCheck":
						break;
					case "EventSubProcess3":
						break;
					case "LongTextRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptLongStringRadioButtonCheck");
						break;
					case "ScriptLongStringRadioButtonCheck":
						break;
					case "EventSubProcess4":
						break;
					case "MaxSizeTextRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptMaxStringRadioButtonCheck");
						break;
					case "ScriptMaxStringRadioButtonCheck":
						break;
					case "EventSubProcess7":
						break;
					case "SecureTextRadioButtonCheck":
						e.Context.QueueTasks.Enqueue("ScriptSecureTextRadioButtonCheck");
						break;
					case "ScriptSecureTextRadioButtonCheck":
						break;
					case "PageLoadSubProcess":
						break;
					case "PageLoad":
						e.Context.QueueTasks.Enqueue("ScriptPageLoad");
						break;
					case "ScriptPageLoad":
						break;
					case "InitSubProcess":
						break;
					case "ReturnParameters":
						e.Context.QueueTasks.Enqueue("ScriptReturnParameters");
						break;
					case "ScriptReturnParameters":
						break;
					case "PageLoadCompleteSubProcess":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadComplete");
						break;
					case "ScriptPageLoadComplete":
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

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageColumnInfoLookupsChanged");
			ActivatedEventElements.Add("StartDirectSetColumnType");
			ActivatedEventElements.Add("StartMessageDictionaryLookupEditChange");
			ActivatedEventElements.Add("LookupRadioButtonCheck");
			ActivatedEventElements.Add("MultiLookupRadioButtonCheck");
			ActivatedEventElements.Add("BooleanRadioButtonCheck");
			ActivatedEventElements.Add("BinaryRadioButtonCheck");
			ActivatedEventElements.Add("DateTimeRadioButtonCheck");
			ActivatedEventElements.Add("DateRadioButtonCheck");
			ActivatedEventElements.Add("TimeRadioButtonCheck");
			ActivatedEventElements.Add("IntegerRadioButtonCheck");
			ActivatedEventElements.Add("FloatRadioButtonCheck");
			ActivatedEventElements.Add("MoneyRadioButtonCheck");
			ActivatedEventElements.Add("ShortTextRadioButtonCheck");
			ActivatedEventElements.Add("MediumTextRadioButtonCheck");
			ActivatedEventElements.Add("LongTextRadioButtonCheck");
			ActivatedEventElements.Add("MaxSizeTextRadioButtonCheck");
			ActivatedEventElements.Add("SecureTextRadioButtonCheck");
			ActivatedEventElements.Add("PageLoad");
			ActivatedEventElements.Add("ReturnParameters");
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("ChildInit");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessColumnInfoLookupsChanged":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageColumnInfoLookupsChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageColumnInfoLookupsChanged";
					result = StartMessageColumnInfoLookupsChanged.Execute(context);
					break;
				case "ScriptColumnInfoLookupsChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptColumnInfoLookupsChanged";
					result = ScriptColumnInfoLookupsChanged.Execute(context, ScriptColumnInfoLookupsChangedExecute);
					break;
				case "EventSubProcessDirectSetColumnType":
					context.QueueTasks.Dequeue();
					break;
				case "StartDirectSetColumnType":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDirectSetColumnType";
					result = StartDirectSetColumnType.Execute(context);
					break;
				case "ScriptDirectSetColumnType":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDirectSetColumnType";
					result = ScriptDirectSetColumnType.Execute(context, ScriptDirectSetColumnTypeExecute);
					break;
				case "EventSubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDictionaryLookupEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDictionaryLookupEditChange";
					result = StartMessageDictionaryLookupEditChange.Execute(context);
					break;
				case "ScriptDictionaryLookupEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDictionaryLookupEditChange";
					result = ScriptDictionaryLookupEditChange.Execute(context, ScriptDictionaryLookupEditChangeExecute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "LookupRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupRadioButtonCheck";
					result = LookupRadioButtonCheck.Execute(context);
					break;
				case "ScriptLookupRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLookupRadioButtonCheck";
					result = ScriptLookupRadioButtonCheck.Execute(context, ScriptLookupRadioButtonCheckExecute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "MultiLookupRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "MultiLookupRadioButtonCheck";
					result = MultiLookupRadioButtonCheck.Execute(context);
					break;
				case "ScriptRelatedLookupRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptRelatedLookupRadioButtonCheck";
					result = ScriptRelatedLookupRadioButtonCheck.Execute(context, ScriptRelatedLookupRadioButtonCheckExecute);
					break;
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "BooleanRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "BooleanRadioButtonCheck";
					result = BooleanRadioButtonCheck.Execute(context);
					break;
				case "ScriptLogicRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLogicRadioButtonCheck";
					result = ScriptLogicRadioButtonCheck.Execute(context, ScriptLogicRadioButtonCheckExecute);
					break;
				case "EventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "BinaryRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "BinaryRadioButtonCheck";
					result = BinaryRadioButtonCheck.Execute(context);
					break;
				case "SelectImageRadioButtonCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectImageRadioButtonCheckScriptTask";
					result = SelectImageRadioButtonCheckScriptTask.Execute(context, SelectImageRadioButtonCheckScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "DateTimeRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "DateTimeRadioButtonCheck";
					result = DateTimeRadioButtonCheck.Execute(context);
					break;
				case "ScriptDateTimeRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDateTimeRadioButtonCheck";
					result = ScriptDateTimeRadioButtonCheck.Execute(context, ScriptDateTimeRadioButtonCheckExecute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "DateRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "DateRadioButtonCheck";
					result = DateRadioButtonCheck.Execute(context);
					break;
				case "ScriptDateRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDateRadioButtonCheck";
					result = ScriptDateRadioButtonCheck.Execute(context, ScriptDateRadioButtonCheckExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "TimeRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "TimeRadioButtonCheck";
					result = TimeRadioButtonCheck.Execute(context);
					break;
				case "ScriptTimeRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTimeRadioButtonCheck";
					result = ScriptTimeRadioButtonCheck.Execute(context, ScriptTimeRadioButtonCheckExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "IntegerRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntegerRadioButtonCheck";
					result = IntegerRadioButtonCheck.Execute(context);
					break;
				case "ScriptIntegerRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptIntegerRadioButtonCheck";
					result = ScriptIntegerRadioButtonCheck.Execute(context, ScriptIntegerRadioButtonCheckExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "FloatRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "FloatRadioButtonCheck";
					result = FloatRadioButtonCheck.Execute(context);
					break;
				case "ScriptFloatRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptFloatRadioButtonCheck";
					result = ScriptFloatRadioButtonCheck.Execute(context, ScriptFloatRadioButtonCheckExecute);
					break;
				case "EventSubProcess14":
					context.QueueTasks.Dequeue();
					break;
				case "MoneyRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "MoneyRadioButtonCheck";
					result = MoneyRadioButtonCheck.Execute(context);
					break;
				case "ScriptCurrencyRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptCurrencyRadioButtonCheck";
					result = ScriptCurrencyRadioButtonCheck.Execute(context, ScriptCurrencyRadioButtonCheckExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ShortTextRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShortTextRadioButtonCheck";
					result = ShortTextRadioButtonCheck.Execute(context);
					break;
				case "ScriptShortStringRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptShortStringRadioButtonCheck";
					result = ScriptShortStringRadioButtonCheck.Execute(context, ScriptShortStringRadioButtonCheckExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "MediumTextRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "MediumTextRadioButtonCheck";
					result = MediumTextRadioButtonCheck.Execute(context);
					break;
				case "ScriptMiddleStringRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptMiddleStringRadioButtonCheck";
					result = ScriptMiddleStringRadioButtonCheck.Execute(context, ScriptMiddleStringRadioButtonCheckExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "LongTextRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "LongTextRadioButtonCheck";
					result = LongTextRadioButtonCheck.Execute(context);
					break;
				case "ScriptLongStringRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLongStringRadioButtonCheck";
					result = ScriptLongStringRadioButtonCheck.Execute(context, ScriptLongStringRadioButtonCheckExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "MaxSizeTextRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "MaxSizeTextRadioButtonCheck";
					result = MaxSizeTextRadioButtonCheck.Execute(context);
					break;
				case "ScriptMaxStringRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptMaxStringRadioButtonCheck";
					result = ScriptMaxStringRadioButtonCheck.Execute(context, ScriptMaxStringRadioButtonCheckExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "SecureTextRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "SecureTextRadioButtonCheck";
					result = SecureTextRadioButtonCheck.Execute(context);
					break;
				case "ScriptSecureTextRadioButtonCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSecureTextRadioButtonCheck";
					result = ScriptSecureTextRadioButtonCheck.Execute(context, ScriptSecureTextRadioButtonCheckExecute);
					break;
				case "PageLoadSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoad";
					result = PageLoad.Execute(context);
					break;
				case "ScriptPageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoad";
					result = ScriptPageLoad.Execute(context, ScriptPageLoadExecute);
					break;
				case "InitSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ReturnParameters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReturnParameters";
					result = ReturnParameters.Execute(context);
					break;
				case "ScriptReturnParameters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptReturnParameters";
					result = ScriptReturnParameters.Execute(context, ScriptReturnParametersExecute);
					break;
				case "PageLoadCompleteSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete";
					result = PageLoadComplete.Execute(context);
					break;
				case "ScriptPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadComplete";
					result = ScriptPageLoadComplete.Execute(context, ScriptPageLoadCompleteExecute);
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
				case "LookupSchemaId":
					LookupSchemaId = reader.GetValue<System.Guid>();
				break;
				case "TypeSelectionMode":
					TypeSelectionMode = reader.GetValue<System.Boolean>();
				break;
				case "RelatedLookupList":
					RelatedLookupList = reader.GetSerializableObjectValue();
				break;
				case "ParentProcessUId":
					ParentProcessUId = reader.GetValue<System.String>();
				break;
				case "ColumnType":
					ColumnType = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptColumnInfoLookupsChangedExecute(ProcessExecutingContext context) {
			var process = UserConnection.IProcessEngine.GetProcessByUId(ParentProcessUId);
			if (process == null) {
				return true;
			}
			process.ThrowEvent(process.InternalContext, "SelectedTypeChanged");
			return true;
		}

		public virtual bool ScriptDirectSetColumnTypeExecute(ProcessExecutingContext context) {
			SetType(ColumnType, LookupSchemaId.ToString(), (RelatedLookupList as List<string>));
			return true;
		}

		public virtual bool ScriptDictionaryLookupEditChangeExecute(ProcessExecutingContext context) {
			/*
			if (Page.DictionaryLookupEdit.Value == null) {
				return true;
			} else {
				if ((Guid)Page.DictionaryLookupEdit.Value == Guid.Empty) {
					return true;
				}
			}*/
			var process = UserConnection.IProcessEngine.GetProcessByUId(ParentProcessUId);
			if (process == null) {
				return true;
			}
			process.ThrowEvent(process.InternalContext, "SelectedTypeChanged");
			return true;
		}

		public virtual bool ScriptLookupRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.LookupRadioButton);
			bool lookupTypeChecked = Page.LookupRadioButton.Checked;
			Page.DictionaryLookupEdit.Enabled = lookupTypeChecked;
			Page.DictionaryLookupEdit.SetRequired(lookupTypeChecked);
			if (!Page.LookupRadioButton.Checked) {
				Page.DictionaryLookupEdit.SetValueAndText(Guid.Empty, ""); 
			}
			return true;
		}

		public virtual bool ScriptRelatedLookupRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.MultiLookupRadioButton);
			Page.LookupPageContainer.Enabled = Page.MultiLookupRadioButton.Checked;
			if (!Page.MultiLookupRadioButton.Checked) {
				Page.LookupPageContainer.PageInstance.ThrowEvent("ClearAllItems");
			}
			return true;
		}

		public virtual bool ScriptLogicRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.BooleanRadioButton);
			return true;
		}

		public virtual bool SelectImageRadioButtonCheckScriptTaskExecute(ProcessExecutingContext context) {
			SetActiveType(Page.BinaryRadioButton);
			return true;
		}

		public virtual bool ScriptDateTimeRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.DateTimeRadioButton);
			return true;
		}

		public virtual bool ScriptDateRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.DateRadioButton);
			return true;
		}

		public virtual bool ScriptTimeRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.TimeRadioButton);
			return true;
		}

		public virtual bool ScriptIntegerRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.IntegerRadioButton);
			return true;
		}

		public virtual bool ScriptFloatRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.FloatRadioButton);
			return true;
		}

		public virtual bool ScriptCurrencyRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.MoneyRadioButton);
			return true;
		}

		public virtual bool ScriptShortStringRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.ShortTextRadioButton);
			return true;
		}

		public virtual bool ScriptMiddleStringRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.MediumTextRadioButton);
			return true;
		}

		public virtual bool ScriptLongStringRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.LongTextRadioButton);
			return true;
		}

		public virtual bool ScriptMaxStringRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.MaxSizeTextRadioButton);
			return true;
		}

		public virtual bool ScriptSecureTextRadioButtonCheckExecute(ProcessExecutingContext context) {
			SetActiveType(Page.SecureTextRadioButton);
			return true;
		}

		public virtual bool ScriptPageLoadExecute(ProcessExecutingContext context) {
			if (TypeSelectionMode) {
				Page.CaptionControlLayout.Hidden = true;
				Page.NameCaptionControlLayout.Hidden = true;
			}
			return true;
		}

		public virtual bool ScriptReturnParametersExecute(ProcessExecutingContext context) {
			if (ParentProcessUId == null) {
				return true;
			}
			var process = UserConnection.IProcessEngine.GetProcessByUId(ParentProcessUId);
			if (process == null) {
				return true;
			}
			var name = Page.NameEdit.Value;
			var caption = Page.CaptiontEdit.Value;
			if (ColumnType == "Lookup") {
				var dictionarySchema = Page.DictionaryLookupEdit.Value;
				var dictionarySchemaId = new Guid(dictionarySchema.ToString());
				var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
				//Код, который компилируется только в Workspace CR173294
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "VwSysSchemaInWorkspace");
				var sysSchemaIdColumnName = entitySchemaQuery.AddColumn("UId").Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, entitySchemaQuery.RootSchema.GetPrimaryColumnName(), dictionarySchemaId));
				var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
				var sysSchemaId = Guid.Empty;
				if (collection.Count > 0) {
					sysSchemaId = collection[0].GetTypedColumnValue<Guid>(sysSchemaIdColumnName);
				}
				process.SetPropertyValue("LookupSchemaId", sysSchemaId);
			} else if (ColumnType == "MultiLookup") {
				var entitySchemaList = Page.LookupPageContainer.PageInstance.Process.GetPropertyValue("EntitySchemaList");
				process.SetPropertyValue("LookupSchemaIds", entitySchemaList);
			}
			process.SetPropertyValue("ColumnType", ColumnType);
			process.SetPropertyValue("FieldName", name.ToString());
			process.SetPropertyValue("FieldCaption", caption.ToString());
			return true;
		}

		public virtual bool ScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			//GetControls(Page.Schema.Controls);
			//Page.ShortTextRadioButton.Checked = true;
			//SetActiveType(Page.ShortTextRadioButton);
			Page.LookupPageContainer.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			return true;
		}

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			Page.DictionaryLookupEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				filters.Add(new Dictionary<string, object> { 
					 {"comparisonType", FilterComparisonType.Equal},
					 {"leftExpressionColumnPath", "SysWorkspace"},
					 {"useDisplayValue", false }, 
					 {"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}});
				filters.Add(new Dictionary<string, object> { 
					 {"comparisonType", FilterComparisonType.Equal},
					 {"leftExpressionColumnPath", "ExtendParent"},
					 {"useDisplayValue", false }, 
					 {"rightExpressionParameterValues", new object[] {false}}});
				filters.Add(new Dictionary<string, object> { 
					 {"comparisonType", FilterComparisonType.Equal},
					 {"leftExpressionColumnPath", "ManagerName"},
					 {"useDisplayValue", false }, 
					 {"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}});
			};
			return true;
		}

		public virtual void GetControls(System.Web.UI.ControlCollection control) {
			foreach(var item in control) {
				if(item.GetType().Name == "RadioButton") {
								((Terrasoft.UI.WebControls.Controls.RadioButton)item).AjaxEvents.Check.Event += delegate(object sender, Terrasoft.UI.WebControls.Controls.AjaxEventArgs e){
									var radio = sender as Terrasoft.UI.WebControls.Controls.RadioButton;
									if (radio.Checked) {
										ColumnType = radio.Name.Replace("RadioButton", "");
										Page.DictionaryLookupEdit.Hidden = (ColumnType != "Lookup");
										Page.LookupPageContainer.Hidden = (ColumnType != "RelatedLookup");
										/*if(ColumnType == "RelatedLookup")
											Page.LookupPageContainer.Hide();
										if(ColumnType == "Lookup")
											Page.DictionaryLookupEdit.Show();
										else{
											Page.LookupPageContainer.Hide();
											Page.DictionaryLookupEdit.Hide();
										}*/
									}
								};
				}	
				if(item.GetType().Name == "ControlLayout") {
					GetControls(((Terrasoft.UI.WebControls.Controls.ControlLayout)item).Controls);
				}
			}
			return;
		}

		public virtual void SetActiveType(Terrasoft.UI.WebControls.Controls.RadioButton RadioButton) {
			if (!RadioButton.Checked) {
				return;
			}
			ColumnType = RadioButton.Name.Replace("RadioButton", "");
			if (ParentProcessUId == null) {
				return;
			}
			var process = UserConnection.IProcessEngine.GetProcessByUId(ParentProcessUId);
			if (process == null) {
				return;
			}
			process.ThrowEvent(process.InternalContext, "SelectedTypeChanged");
			return;
		}

		public virtual void SetType(string typeCode, string lookupSchemaId, List<string> lookupSchemaIds) {
			switch (typeCode) {
				case "Binary": 
					Page.BinaryRadioButton.Checked = true;
				break;
				case "Integer":
					Page.IntegerRadioButton.Checked = true;
				break;
				case "Float":
					Page.FloatRadioButton.Checked = true;
				break;
				case "Money":
					Page.MoneyRadioButton.Checked = true;
				break;
				case "Lookup":
					Page.LookupRadioButton.Checked = true;
					var schemaCaption = string.Empty;
					var manager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			
					//Код, который компилируется только в Workspace CR173294
					var entitySchemaQuery = new EntitySchemaQuery(manager, "VwSysSchemaInWorkspace");
					var captionColumnName = entitySchemaQuery.AddColumn("Caption").Name;
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "UId", new Guid(lookupSchemaId)));
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace", UserConnection.Workspace.Id));
					var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
					if (entities.Count > 0) {
						schemaCaption = entities[0].GetTypedColumnValue<string>(captionColumnName);
					}
					Page.DictionaryLookupEdit.SetValueAndText(new Guid(lookupSchemaId), schemaCaption);
					Page.DictionaryLookupEdit.Enabled = true;
				break;
				case "MultiLookup":
					Page.MultiLookupRadioButton.Checked = true;
					Page.LookupPageContainer.Enabled = true;
					Page.LookupPageContainer.PageInstance.Process.SetPropertyValue("EntitySchemaList", RelatedLookupList);
					Page.LookupPageContainer.PageInstance.ThrowEvent("InitializeLookupList");
				break;
				case "Boolean":
					Page.BooleanRadioButton.Checked = true;
				break;
				case "DateTime":
					Page.DateTimeRadioButton.Checked = true;
				break;
				case "Date":
					Page.DateRadioButton.Checked = true;
				break;
				case "Time":
					Page.TimeRadioButton.Checked = true;
				break;
				case "ShortText":
					Page.ShortTextRadioButton.Checked = true;
				break;
				case "MediumText":
					Page.MediumTextRadioButton.Checked = true;
				break;
				case "LongText":
					Page.LongTextRadioButton.Checked = true;
				break;
				case "MaxSizeText":
					Page.MaxSizeTextRadioButton.Checked = true;
				break;
				case "SecureText":
					Page.SecureTextRadioButton.Checked = true;
				break;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ColumnInfoLookupsChanged":
							if (ActivatedEventElements.Contains("StartMessageColumnInfoLookupsChanged")) {
							context.QueueTasks.Enqueue("StartMessageColumnInfoLookupsChanged");
						}
						break;
					case "DirectSetColumnType":
							if (ActivatedEventElements.Contains("StartDirectSetColumnType")) {
							context.QueueTasks.Enqueue("StartDirectSetColumnType");
						}
						break;
					case "DictionaryLookupEditChange":
							if (ActivatedEventElements.Contains("StartMessageDictionaryLookupEditChange")) {
							context.QueueTasks.Enqueue("StartMessageDictionaryLookupEditChange");
						}
						break;
					case "LookupRadioButtonCheck":
							if (ActivatedEventElements.Contains("LookupRadioButtonCheck")) {
							context.QueueTasks.Enqueue("LookupRadioButtonCheck");
						}
						break;
					case "MultiLookupRadioButtonCheck":
							if (ActivatedEventElements.Contains("MultiLookupRadioButtonCheck")) {
							context.QueueTasks.Enqueue("MultiLookupRadioButtonCheck");
						}
						break;
					case "BooleanRadioButtonCheck":
							if (ActivatedEventElements.Contains("BooleanRadioButtonCheck")) {
							context.QueueTasks.Enqueue("BooleanRadioButtonCheck");
						}
						break;
					case "BinaryRadioButtonCheck":
							if (ActivatedEventElements.Contains("BinaryRadioButtonCheck")) {
							context.QueueTasks.Enqueue("BinaryRadioButtonCheck");
						}
						break;
					case "DateTimeRadioButtonCheck":
							if (ActivatedEventElements.Contains("DateTimeRadioButtonCheck")) {
							context.QueueTasks.Enqueue("DateTimeRadioButtonCheck");
						}
						break;
					case "DateRadioButtonCheck":
							if (ActivatedEventElements.Contains("DateRadioButtonCheck")) {
							context.QueueTasks.Enqueue("DateRadioButtonCheck");
						}
						break;
					case "TimeRadioButtonCheck":
							if (ActivatedEventElements.Contains("TimeRadioButtonCheck")) {
							context.QueueTasks.Enqueue("TimeRadioButtonCheck");
						}
						break;
					case "IntegerRadioButtonCheck":
							if (ActivatedEventElements.Contains("IntegerRadioButtonCheck")) {
							context.QueueTasks.Enqueue("IntegerRadioButtonCheck");
						}
						break;
					case "FloatRadioButtonCheck":
							if (ActivatedEventElements.Contains("FloatRadioButtonCheck")) {
							context.QueueTasks.Enqueue("FloatRadioButtonCheck");
						}
						break;
					case "MoneyRadioButtonCheck":
							if (ActivatedEventElements.Contains("MoneyRadioButtonCheck")) {
							context.QueueTasks.Enqueue("MoneyRadioButtonCheck");
						}
						break;
					case "ShortTextRadioButtonCheck":
							if (ActivatedEventElements.Contains("ShortTextRadioButtonCheck")) {
							context.QueueTasks.Enqueue("ShortTextRadioButtonCheck");
						}
						break;
					case "MediumTextRadioButtonCheck":
							if (ActivatedEventElements.Contains("MediumTextRadioButtonCheck")) {
							context.QueueTasks.Enqueue("MediumTextRadioButtonCheck");
						}
						break;
					case "LongTextRadioButtonCheck":
							if (ActivatedEventElements.Contains("LongTextRadioButtonCheck")) {
							context.QueueTasks.Enqueue("LongTextRadioButtonCheck");
						}
						break;
					case "MaxSizeTextRadioButtonCheck":
							if (ActivatedEventElements.Contains("MaxSizeTextRadioButtonCheck")) {
							context.QueueTasks.Enqueue("MaxSizeTextRadioButtonCheck");
						}
						break;
					case "SecureTextRadioButtonCheck":
							if (ActivatedEventElements.Contains("SecureTextRadioButtonCheck")) {
							context.QueueTasks.Enqueue("SecureTextRadioButtonCheck");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoad")) {
							context.QueueTasks.Enqueue("PageLoad");
						}
						break;
					case "ReturnParameters":
							if (ActivatedEventElements.Contains("ReturnParameters")) {
							context.QueueTasks.Enqueue("ReturnParameters");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("ChildInit")) {
							context.QueueTasks.Enqueue("ChildInit");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("LookupSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LookupSchemaId", LookupSchemaId, Guid.Empty);
			}
			if (!HasMapping("TypeSelectionMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("TypeSelectionMode", TypeSelectionMode, false);
			}
			if (RelatedLookupList != null) {
				if (RelatedLookupList.GetType().IsSerializable ||
					RelatedLookupList.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("RelatedLookupList", RelatedLookupList, null);
				}
			}
			if (!HasMapping("ParentProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentProcessUId", ParentProcessUId, null);
			}
			if (!HasMapping("ColumnType") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnType", ColumnType, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SetColumnPrimaryInfoPageEventsProcess

	/// <exclude/>
	public class SetColumnPrimaryInfoPageEventsProcess : SetColumnPrimaryInfoPageEventsProcess<Terrasoft.WebApp.SetColumnPrimaryInfoPageSchemaUserControl>
	{

		public SetColumnPrimaryInfoPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SetColumnPrimaryInfoPageSchemaUserControl

	/// <exclude/>
	public partial class SetColumnPrimaryInfoPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CaptionControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CaptionControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label CaptionLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("CaptionLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout NameCaptionControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("NameCaptionControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CaptiontEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CaptiontEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label ColumnTypeLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("ColumnTypeLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ColumnTypeControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ColumnTypeControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout StringDateControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("StringDateControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout StringControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("StringControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton ShortTextRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("ShortTextRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton MediumTextRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("MediumTextRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton LongTextRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("LongTextRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton MaxSizeTextRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("MaxSizeTextRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton SecureTextRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("SecureTextRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout DateTimeControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("DateTimeControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton DateTimeRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("DateTimeRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton DateRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("DateRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton TimeRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("TimeRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout NumberOtherControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("NumberOtherControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout NumberControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("NumberControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton IntegerRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("IntegerRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton FloatRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("FloatRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton MoneyRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("MoneyRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout OtherFieldsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("OtherFieldsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton BooleanRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("BooleanRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton LookupRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("LookupRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit DictionaryLookupEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("DictionaryLookupEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton BinaryRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("BinaryRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton MultiLookupRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("MultiLookupRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer LookupPageContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("LookupPageContainer", true);
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
			ShortTextRadioButton.AjaxEvents.Check.Event += ShortTextRadioButtonCheck;
			MediumTextRadioButton.AjaxEvents.Check.Event += MediumTextRadioButtonCheck;
			LongTextRadioButton.AjaxEvents.Check.Event += LongTextRadioButtonCheck;
			MaxSizeTextRadioButton.AjaxEvents.Check.Event += MaxSizeTextRadioButtonCheck;
			SecureTextRadioButton.AjaxEvents.Check.Event += SecureTextRadioButtonCheck;
			DateTimeRadioButton.AjaxEvents.Check.Event += DateTimeRadioButtonCheck;
			DateRadioButton.AjaxEvents.Check.Event += DateRadioButtonCheck;
			TimeRadioButton.AjaxEvents.Check.Event += TimeRadioButtonCheck;
			IntegerRadioButton.AjaxEvents.Check.Event += IntegerRadioButtonCheck;
			FloatRadioButton.AjaxEvents.Check.Event += FloatRadioButtonCheck;
			MoneyRadioButton.AjaxEvents.Check.Event += MoneyRadioButtonCheck;
			BooleanRadioButton.AjaxEvents.Check.Event += BooleanRadioButtonCheck;
			LookupRadioButton.AjaxEvents.Check.Event += LookupRadioButtonCheck;
			DictionaryLookupEdit.AjaxEvents.Change.Event += DictionaryLookupEditChange;
			BinaryRadioButton.AjaxEvents.Check.Event += BinaryRadioButtonCheck;
			MultiLookupRadioButton.AjaxEvents.Check.Event += MultiLookupRadioButtonCheck;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ShortTextRadioButton.AjaxEvents.Check.Event -= ShortTextRadioButtonCheck;
			MediumTextRadioButton.AjaxEvents.Check.Event -= MediumTextRadioButtonCheck;
			LongTextRadioButton.AjaxEvents.Check.Event -= LongTextRadioButtonCheck;
			MaxSizeTextRadioButton.AjaxEvents.Check.Event -= MaxSizeTextRadioButtonCheck;
			SecureTextRadioButton.AjaxEvents.Check.Event -= SecureTextRadioButtonCheck;
			DateTimeRadioButton.AjaxEvents.Check.Event -= DateTimeRadioButtonCheck;
			DateRadioButton.AjaxEvents.Check.Event -= DateRadioButtonCheck;
			TimeRadioButton.AjaxEvents.Check.Event -= TimeRadioButtonCheck;
			IntegerRadioButton.AjaxEvents.Check.Event -= IntegerRadioButtonCheck;
			FloatRadioButton.AjaxEvents.Check.Event -= FloatRadioButtonCheck;
			MoneyRadioButton.AjaxEvents.Check.Event -= MoneyRadioButtonCheck;
			BooleanRadioButton.AjaxEvents.Check.Event -= BooleanRadioButtonCheck;
			LookupRadioButton.AjaxEvents.Check.Event -= LookupRadioButtonCheck;
			DictionaryLookupEdit.AjaxEvents.Change.Event -= DictionaryLookupEditChange;
			BinaryRadioButton.AjaxEvents.Check.Event -= BinaryRadioButtonCheck;
			MultiLookupRadioButton.AjaxEvents.Check.Event -= MultiLookupRadioButtonCheck;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SetColumnPrimaryInfoPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SetColumnPrimaryInfoPageEventsProcess(UserConnection);
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

		public virtual void ShortTextRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("ShortTextRadioButtonCheck");
		}

		public virtual void MediumTextRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("MediumTextRadioButtonCheck");
		}

		public virtual void LongTextRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("LongTextRadioButtonCheck");
		}

		public virtual void MaxSizeTextRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("MaxSizeTextRadioButtonCheck");
		}

		public virtual void SecureTextRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("SecureTextRadioButtonCheck");
		}

		public virtual void DateTimeRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("DateTimeRadioButtonCheck");
		}

		public virtual void DateRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("DateRadioButtonCheck");
		}

		public virtual void TimeRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("TimeRadioButtonCheck");
		}

		public virtual void IntegerRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("IntegerRadioButtonCheck");
		}

		public virtual void FloatRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("FloatRadioButtonCheck");
		}

		public virtual void MoneyRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("MoneyRadioButtonCheck");
		}

		public virtual void BooleanRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("BooleanRadioButtonCheck");
		}

		public virtual void LookupRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("LookupRadioButtonCheck");
		}

		public virtual void DictionaryLookupEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("DictionaryLookupEditChange");
		}

		public virtual void BinaryRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("BinaryRadioButtonCheck");
		}

		public virtual void MultiLookupRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("MultiLookupRadioButtonCheck");
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
			SchemaName = "SetColumnPrimaryInfoPage";
		}

		#endregion

	}

	#endregion

	#region Class: SetColumnPrimaryInfoPageEventsProcessSchema

	/// <exclude/>
	public class SetColumnPrimaryInfoPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public SetColumnPrimaryInfoPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SetColumnPrimaryInfoPageEventsProcessSchema(SetColumnPrimaryInfoPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SetColumnPrimaryInfoPageEventsProcess";
			UId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39");
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

		protected virtual ProcessSchemaParameter CreateColumnTypeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("88ab8860-2e37-446f-8709-ab6f6792b32b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ColumnType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a7b6460b-163a-48f4-bf32-a741c2c8204f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ParentProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRelatedLookupListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a2f75d54-b9b6-4146-948f-3a3ce281563b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"RelatedLookupList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTypeSelectionModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("887f08bb-5da7-465c-ba60-83c80d330bc7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"TypeSelectionMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2655ce47-af07-413d-a3f8-ee2c60f243fc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"LookupSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateColumnTypeParameter());
			Parameters.Add(CreateParentProcessUIdParameter());
			Parameters.Add(CreateRelatedLookupListParameter());
			Parameters.Add(CreateTypeSelectionModeParameter());
			Parameters.Add(CreateLookupSchemaIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet41 = CreateLaneSet41LaneSet();
			LaneSets.Add(schemaLaneSet41);
			ProcessSchemaLane schemaLane122 = CreateLane122Lane();
			schemaLaneSet41.Lanes.Add(schemaLane122);
			ProcessSchemaEventSubProcess eventsubprocesscolumninfolookupschanged = CreateEventSubProcessColumnInfoLookupsChangedEventSubProcess();
			FlowElements.Add(eventsubprocesscolumninfolookupschanged);
			ProcessSchemaEventSubProcess eventsubprocessdirectsetcolumntype = CreateEventSubProcessDirectSetColumnTypeEventSubProcess();
			FlowElements.Add(eventsubprocessdirectsetcolumntype);
			ProcessSchemaEventSubProcess eventsubprocess15 = CreateEventSubProcess15EventSubProcess();
			FlowElements.Add(eventsubprocess15);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess16 = CreateEventSubProcess16EventSubProcess();
			FlowElements.Add(eventsubprocess16);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess14 = CreateEventSubProcess14EventSubProcess();
			FlowElements.Add(eventsubprocess14);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess pageloadsubprocess = CreatePageLoadSubProcessEventSubProcess();
			FlowElements.Add(pageloadsubprocess);
			ProcessSchemaEventSubProcess initsubprocess = CreateInitSubProcessEventSubProcess();
			FlowElements.Add(initsubprocess);
			ProcessSchemaEventSubProcess pageloadcompletesubprocess = CreatePageLoadCompleteSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompletesubprocess);
			ProcessSchemaEventSubProcess childiniteventsubprocess = CreateChildInitEventSubProcessEventSubProcess();
			FlowElements.Add(childiniteventsubprocess);
			ProcessSchemaStartMessageEvent startmessagecolumninfolookupschanged = CreateStartMessageColumnInfoLookupsChangedStartMessageEvent();
			eventsubprocesscolumninfolookupschanged.FlowElements.Add(startmessagecolumninfolookupschanged);
			ProcessSchemaScriptTask scriptcolumninfolookupschanged = CreateScriptColumnInfoLookupsChangedScriptTask();
			eventsubprocesscolumninfolookupschanged.FlowElements.Add(scriptcolumninfolookupschanged);
			ProcessSchemaStartMessageEvent startdirectsetcolumntype = CreateStartDirectSetColumnTypeStartMessageEvent();
			eventsubprocessdirectsetcolumntype.FlowElements.Add(startdirectsetcolumntype);
			ProcessSchemaScriptTask scriptdirectsetcolumntype = CreateScriptDirectSetColumnTypeScriptTask();
			eventsubprocessdirectsetcolumntype.FlowElements.Add(scriptdirectsetcolumntype);
			ProcessSchemaStartMessageEvent startmessagedictionarylookupeditchange = CreateStartMessageDictionaryLookupEditChangeStartMessageEvent();
			eventsubprocess15.FlowElements.Add(startmessagedictionarylookupeditchange);
			ProcessSchemaScriptTask scriptdictionarylookupeditchange = CreateScriptDictionaryLookupEditChangeScriptTask();
			eventsubprocess15.FlowElements.Add(scriptdictionarylookupeditchange);
			ProcessSchemaStartMessageEvent lookupradiobuttoncheck = CreateLookupRadioButtonCheckStartMessageEvent();
			eventsubprocess11.FlowElements.Add(lookupradiobuttoncheck);
			ProcessSchemaScriptTask scriptlookupradiobuttoncheck = CreateScriptLookupRadioButtonCheckScriptTask();
			eventsubprocess11.FlowElements.Add(scriptlookupradiobuttoncheck);
			ProcessSchemaStartMessageEvent multilookupradiobuttoncheck = CreateMultiLookupRadioButtonCheckStartMessageEvent();
			eventsubprocess12.FlowElements.Add(multilookupradiobuttoncheck);
			ProcessSchemaScriptTask scriptrelatedlookupradiobuttoncheck = CreateScriptRelatedLookupRadioButtonCheckScriptTask();
			eventsubprocess12.FlowElements.Add(scriptrelatedlookupradiobuttoncheck);
			ProcessSchemaStartMessageEvent booleanradiobuttoncheck = CreateBooleanRadioButtonCheckStartMessageEvent();
			eventsubprocess13.FlowElements.Add(booleanradiobuttoncheck);
			ProcessSchemaScriptTask scriptlogicradiobuttoncheck = CreateScriptLogicRadioButtonCheckScriptTask();
			eventsubprocess13.FlowElements.Add(scriptlogicradiobuttoncheck);
			ProcessSchemaStartMessageEvent binaryradiobuttoncheck = CreateBinaryRadioButtonCheckStartMessageEvent();
			eventsubprocess16.FlowElements.Add(binaryradiobuttoncheck);
			ProcessSchemaScriptTask selectimageradiobuttoncheckscripttask = CreateSelectImageRadioButtonCheckScriptTaskScriptTask();
			eventsubprocess16.FlowElements.Add(selectimageradiobuttoncheckscripttask);
			ProcessSchemaStartMessageEvent datetimeradiobuttoncheck = CreateDateTimeRadioButtonCheckStartMessageEvent();
			eventsubprocess8.FlowElements.Add(datetimeradiobuttoncheck);
			ProcessSchemaScriptTask scriptdatetimeradiobuttoncheck = CreateScriptDateTimeRadioButtonCheckScriptTask();
			eventsubprocess8.FlowElements.Add(scriptdatetimeradiobuttoncheck);
			ProcessSchemaStartMessageEvent dateradiobuttoncheck = CreateDateRadioButtonCheckStartMessageEvent();
			eventsubprocess9.FlowElements.Add(dateradiobuttoncheck);
			ProcessSchemaScriptTask scriptdateradiobuttoncheck = CreateScriptDateRadioButtonCheckScriptTask();
			eventsubprocess9.FlowElements.Add(scriptdateradiobuttoncheck);
			ProcessSchemaStartMessageEvent timeradiobuttoncheck = CreateTimeRadioButtonCheckStartMessageEvent();
			eventsubprocess10.FlowElements.Add(timeradiobuttoncheck);
			ProcessSchemaScriptTask scripttimeradiobuttoncheck = CreateScriptTimeRadioButtonCheckScriptTask();
			eventsubprocess10.FlowElements.Add(scripttimeradiobuttoncheck);
			ProcessSchemaStartMessageEvent integerradiobuttoncheck = CreateIntegerRadioButtonCheckStartMessageEvent();
			eventsubprocess5.FlowElements.Add(integerradiobuttoncheck);
			ProcessSchemaScriptTask scriptintegerradiobuttoncheck = CreateScriptIntegerRadioButtonCheckScriptTask();
			eventsubprocess5.FlowElements.Add(scriptintegerradiobuttoncheck);
			ProcessSchemaStartMessageEvent floatradiobuttoncheck = CreateFloatRadioButtonCheckStartMessageEvent();
			eventsubprocess6.FlowElements.Add(floatradiobuttoncheck);
			ProcessSchemaScriptTask scriptfloatradiobuttoncheck = CreateScriptFloatRadioButtonCheckScriptTask();
			eventsubprocess6.FlowElements.Add(scriptfloatradiobuttoncheck);
			ProcessSchemaStartMessageEvent moneyradiobuttoncheck = CreateMoneyRadioButtonCheckStartMessageEvent();
			eventsubprocess14.FlowElements.Add(moneyradiobuttoncheck);
			ProcessSchemaScriptTask scriptcurrencyradiobuttoncheck = CreateScriptCurrencyRadioButtonCheckScriptTask();
			eventsubprocess14.FlowElements.Add(scriptcurrencyradiobuttoncheck);
			ProcessSchemaStartMessageEvent shorttextradiobuttoncheck = CreateShortTextRadioButtonCheckStartMessageEvent();
			eventsubprocess1.FlowElements.Add(shorttextradiobuttoncheck);
			ProcessSchemaScriptTask scriptshortstringradiobuttoncheck = CreateScriptShortStringRadioButtonCheckScriptTask();
			eventsubprocess1.FlowElements.Add(scriptshortstringradiobuttoncheck);
			ProcessSchemaStartMessageEvent mediumtextradiobuttoncheck = CreateMediumTextRadioButtonCheckStartMessageEvent();
			eventsubprocess2.FlowElements.Add(mediumtextradiobuttoncheck);
			ProcessSchemaScriptTask scriptmiddlestringradiobuttoncheck = CreateScriptMiddleStringRadioButtonCheckScriptTask();
			eventsubprocess2.FlowElements.Add(scriptmiddlestringradiobuttoncheck);
			ProcessSchemaStartMessageEvent longtextradiobuttoncheck = CreateLongTextRadioButtonCheckStartMessageEvent();
			eventsubprocess3.FlowElements.Add(longtextradiobuttoncheck);
			ProcessSchemaScriptTask scriptlongstringradiobuttoncheck = CreateScriptLongStringRadioButtonCheckScriptTask();
			eventsubprocess3.FlowElements.Add(scriptlongstringradiobuttoncheck);
			ProcessSchemaStartMessageEvent maxsizetextradiobuttoncheck = CreateMaxSizeTextRadioButtonCheckStartMessageEvent();
			eventsubprocess4.FlowElements.Add(maxsizetextradiobuttoncheck);
			ProcessSchemaScriptTask scriptmaxstringradiobuttoncheck = CreateScriptMaxStringRadioButtonCheckScriptTask();
			eventsubprocess4.FlowElements.Add(scriptmaxstringradiobuttoncheck);
			ProcessSchemaStartMessageEvent securetextradiobuttoncheck = CreateSecureTextRadioButtonCheckStartMessageEvent();
			eventsubprocess7.FlowElements.Add(securetextradiobuttoncheck);
			ProcessSchemaScriptTask scriptsecuretextradiobuttoncheck = CreateScriptSecureTextRadioButtonCheckScriptTask();
			eventsubprocess7.FlowElements.Add(scriptsecuretextradiobuttoncheck);
			ProcessSchemaStartMessageEvent pageload = CreatePageLoadStartMessageEvent();
			pageloadsubprocess.FlowElements.Add(pageload);
			ProcessSchemaScriptTask scriptpageload = CreateScriptPageLoadScriptTask();
			pageloadsubprocess.FlowElements.Add(scriptpageload);
			ProcessSchemaStartMessageEvent returnparameters = CreateReturnParametersStartMessageEvent();
			initsubprocess.FlowElements.Add(returnparameters);
			ProcessSchemaScriptTask scriptreturnparameters = CreateScriptReturnParametersScriptTask();
			initsubprocess.FlowElements.Add(scriptreturnparameters);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			pageloadcompletesubprocess.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask scriptpageloadcomplete = CreateScriptPageLoadCompleteScriptTask();
			pageloadcompletesubprocess.FlowElements.Add(scriptpageloadcomplete);
			ProcessSchemaStartMessageEvent childinit = CreateChildInitStartMessageEvent();
			childiniteventsubprocess.FlowElements.Add(childinit);
			ProcessSchemaIntermediateThrowMessageEvent baseinit = CreateBaseInitIntermediateThrowMessageEvent();
			childiniteventsubprocess.FlowElements.Add(baseinit);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			childiniteventsubprocess.FlowElements.Add(scriptchildinit);
			FlowElements.Add(CreateSequenceFlow389SequenceFlow());
			FlowElements.Add(CreateSequenceFlow390SequenceFlow());
			FlowElements.Add(CreateSequenceFlow391SequenceFlow());
			FlowElements.Add(CreateSequenceFlow392SequenceFlow());
			FlowElements.Add(CreateSequenceFlow393SequenceFlow());
			FlowElements.Add(CreateSequenceFlow394SequenceFlow());
			FlowElements.Add(CreateSequenceFlow395SequenceFlow());
			FlowElements.Add(CreateSequenceFlow396SequenceFlow());
			FlowElements.Add(CreateSequenceFlow397SequenceFlow());
			FlowElements.Add(CreateSequenceFlow398SequenceFlow());
			FlowElements.Add(CreateSequenceFlow399SequenceFlow());
			FlowElements.Add(CreateSequenceFlow400SequenceFlow());
			FlowElements.Add(CreateSequenceFlow401SequenceFlow());
			FlowElements.Add(CreateSequenceFlow402SequenceFlow());
			FlowElements.Add(CreateSequenceFlow403SequenceFlow());
			FlowElements.Add(CreateSequenceFlow404SequenceFlow());
			FlowElements.Add(CreateSequenceFlow405SequenceFlow());
			FlowElements.Add(CreateSequenceFlow406SequenceFlow());
			FlowElements.Add(CreateSequenceFlow407SequenceFlow());
			FlowElements.Add(CreateSequenceFlow408SequenceFlow());
			FlowElements.Add(CreateSequenceFlow409SequenceFlow());
			FlowElements.Add(CreateSequenceFlow410SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow389SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow389",
				UId = new Guid("221256f4-c216-4922-af09-ea49d9ef249d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(132, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aaf6f3f6-4346-4fb4-867f-ec11592efa9d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fdb35110-ddbf-468d-b51a-25795be256e4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow390SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow390",
				UId = new Guid("76d0d365-c70c-4bc3-960d-509570022803"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(352, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c60033be-0c93-4c48-a201-10143ffb3279"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f82d3c07-c6d2-4cf0-b70b-0f8b114954aa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow391SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow391",
				UId = new Guid("70a7d776-e535-42df-8e1b-31c2457ed009"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(570, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0b62c74e-57d1-48a7-b51e-03355e4d4e96"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("de059205-8a87-46e3-a88f-ce6712cc437c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow392SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow392",
				UId = new Guid("92e23762-be39-4551-ae34-9d7223bc2de6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6970c956-ec46-4ec7-8733-1e8ab1a6ad53"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("43514e45-6a3b-4d8a-958f-8d7088f8f043"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow393SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow393",
				UId = new Guid("9a042b42-9cbb-4e6a-85ed-1a7b1ef4873e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e9d4c901-6138-4fe5-a675-fccab46457c7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7700ffe3-3dc3-4871-8196-d780d6b837e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow394SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow394",
				UId = new Guid("3342d926-636a-465c-ba2d-6d16ecb773cd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("517f6398-8a0c-4728-86de-55551ce49040"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eed65fd6-d5a2-46bb-bacd-be53fa099414"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow395SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow395",
				UId = new Guid("33ea2999-04a5-47db-b4a4-59b6fc95f588"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2ed4de5-9d62-4e70-957f-6327e904563b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d2bc0fd0-fe1c-4e7a-812d-53bea83deda7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow396SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow396",
				UId = new Guid("3c634e6b-9aa3-4397-b427-79982c1be31f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("519d270a-894a-4e2a-8ffd-3e519f9ba7f1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("463c30b2-7bdb-432c-98eb-2f3ff6b39863"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow397SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow397",
				UId = new Guid("cbd9c75c-84e1-42ad-8a5e-356a3337352a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("34fa592d-d8c1-428a-85f7-b54a111367a9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9cc92a92-ac0f-42d8-9424-51117f2cb585"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow398SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow398",
				UId = new Guid("ed4a6999-6996-42b6-af58-1640e08aff46"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf194d38-726a-48fa-b68b-04ab65f62098"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3701a23b-01ed-40ff-95d0-411d2ba7f878"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow399SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow399",
				UId = new Guid("3f890af8-8e1c-4ecc-969d-d32a9b7581ca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e572dba6-89d8-48d3-966f-a965b2f8acbe"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a6506ac-4241-4696-9836-801073deab40"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow400SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow400",
				UId = new Guid("5d8ae5cc-604a-41dd-9b51-6dda5ebc1335"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("64ea1073-39c8-4dbe-9725-6ccc8bd7275d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5730e7c1-55ab-4764-8cee-4cfa6f001742"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow401SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow401",
				UId = new Guid("8908f7a7-1be8-4ace-afcc-cb5d6a8b3f0d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69ea8aeb-0cb8-43fd-a67b-9ca00096c05b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9a1dee00-a4f4-4ead-82dd-a037738ad835"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow402SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow402",
				UId = new Guid("f50fdc4a-a0e5-46a3-92b9-e866080e2494"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4384dd6a-32b7-4b66-aae1-4943d4b42308"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8f547662-5444-4788-ad63-667b5c84105f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow403SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow403",
				UId = new Guid("1b0ee879-8c77-4e4c-acc2-5bd8071015e3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b7315387-9307-491a-aecc-1b87aca8d317"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d46ba082-926a-41c5-a545-642d4810777e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow404SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow404",
				UId = new Guid("44ac7dce-81cc-439e-abf8-ef43c9ebe627"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e549b0e1-838a-4459-8bf0-0f2a0f1621a4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("67ba233e-fcb9-45f7-b96f-d0b6638da749"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow405SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow405",
				UId = new Guid("ab4085f7-2e1f-412d-9e5e-54a9776677c2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7874bc88-a4b2-4c20-ab80-ae43031e5da7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("35b668b7-8060-4a04-bb98-fe69a93f0759"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow406SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow406",
				UId = new Guid("ab360741-da24-442b-bbea-fd489b074ca2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(166, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58384c66-2795-4d8c-8210-7a4ebc5ecdde"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("08d2223c-b529-490d-afe6-394f33b09320"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow407SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow407",
				UId = new Guid("0b6db282-16c7-4df0-82a8-971ab96b741a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(162, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9f434c71-1a60-43fe-8b4d-59fddf145209"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb5cc497-52b1-46f4-b769-6c7a4c083a5a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow408SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow408",
				UId = new Guid("d54dca07-9243-4650-bb37-87a778726e6d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(140, 729),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1b7687b3-83b1-4266-97b2-be7174c1419d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d966fcc5-6e88-4cc8-80ca-d8d6a3ee97da"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow409SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow409",
				UId = new Guid("01ee5264-d1ca-4923-bb37-92ae95115368"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(234, 726),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d966fcc5-6e88-4cc8-80ca-d8d6a3ee97da"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("640b672a-6784-463e-a571-ba4ce6399f6e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow410SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow410",
				UId = new Guid("2171e2a7-2220-4b5c-b433-9a4e9a17ad21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9292e915-2d29-4360-ab9a-ccd844708a07"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("70d4b300-9479-4fec-86d8-551b06e71361"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("29e93834-eb5e-4c74-a6b0-ba1f13cd6363"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3dcc705-837b-4182-9dcc-05f920c267d5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45f2866c-4064-4b3b-ad97-f26a140d0b89"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet41LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet41 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a69a866e-d694-4f4d-8284-d17624f133eb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"LaneSet41",
				Position = new Point(5, 5),
				Size = new Size(1052, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet41;
		}

		protected virtual ProcessSchemaLane CreateLane122Lane() {
			ProcessSchemaLane schemaLane122 = new ProcessSchemaLane(this) {
				UId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a69a866e-d694-4f4d-8284-d17624f133eb"),
				CreatedInOwnerSchemaUId = new Guid("17a6bdde-9e1f-46af-a508-6f446d8f07c5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"Lane122",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1023, 177),
				UseBackgroundMode = false
			};
			return schemaLane122;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessColumnInfoLookupsChangedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessColumnInfoLookupsChanged = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a95dcac2-1328-4390-a7d2-7ad73202376d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcessColumnInfoLookupsChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(210, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessColumnInfoLookupsChanged;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageColumnInfoLookupsChangedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("58384c66-2795-4d8c-8210-7a4ebc5ecdde"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a95dcac2-1328-4390-a7d2-7ad73202376d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ColumnInfoLookupsChanged",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"StartMessageColumnInfoLookupsChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptColumnInfoLookupsChangedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("08d2223c-b529-490d-afe6-394f33b09320"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a95dcac2-1328-4390-a7d2-7ad73202376d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptColumnInfoLookupsChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,142,65,10,131,48,16,69,215,205,41,6,87,10,37,23,16,55,21,41,238,132,234,1,130,254,170,16,38,50,70,91,41,189,123,3,213,210,237,155,63,239,255,213,8,77,226,90,204,51,101,212,204,144,220,49,163,245,163,99,93,86,223,75,193,253,200,208,87,248,29,92,182,166,236,226,202,8,248,64,1,36,169,26,239,20,255,116,25,241,98,109,66,47,117,18,248,69,152,188,44,72,213,91,237,17,93,15,226,30,197,26,44,199,151,46,217,67,216,216,48,195,227,233,207,20,221,96,195,30,116,245,54,33,31,12,247,232,162,80,245,175,252,0,39,245,54,243,198,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDirectSetColumnTypeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDirectSetColumnType = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a58e8de0-ab64-4d2e-8934-a922d7741e68"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcessDirectSetColumnType",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDirectSetColumnType;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartDirectSetColumnTypeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9f434c71-1a60-43fe-8b4d-59fddf145209"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a58e8de0-ab64-4d2e-8934-a922d7741e68"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DirectSetColumnType",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"StartDirectSetColumnType",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDirectSetColumnTypeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cb5cc497-52b1-46f4-b769-6c7a4c083a5a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a58e8de0-ab64-4d2e-8934-a922d7741e68"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptDirectSetColumnType",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,9,169,44,72,213,112,206,207,41,205,205,3,49,117,20,124,242,243,179,75,11,130,147,51,82,115,19,61,83,244,66,242,131,75,138,50,243,210,53,52,117,20,52,130,82,115,18,75,82,83,32,74,124,50,139,75,20,18,139,21,64,180,77,49,88,145,157,166,166,53,87,81,106,73,105,81,158,66,73,81,105,170,53,0,114,72,60,199,97,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a90a107e-3524-4786-9678-5ce7164e215f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess15",
				Position = new Point(29, 198),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDictionaryLookupEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7874bc88-a4b2-4c20-ab80-ae43031e5da7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a90a107e-3524-4786-9678-5ce7164e215f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DictionaryLookupEditChange",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"StartMessageDictionaryLookupEditChange",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDictionaryLookupEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("35b668b7-8060-4a04-bb98-fe69a93f0759"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a90a107e-3524-4786-9678-5ce7164e215f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptDictionaryLookupEditChange",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,65,78,195,48,16,69,215,245,41,70,93,53,21,114,15,80,101,67,137,170,72,44,42,209,178,183,234,79,106,213,140,163,137,93,136,80,238,142,19,90,4,11,36,182,111,254,188,153,191,90,42,247,66,139,157,105,160,31,220,49,186,192,70,250,199,16,206,169,173,172,139,250,217,248,4,42,75,226,228,125,65,31,106,38,136,73,152,162,36,172,213,64,240,29,70,60,106,22,219,228,108,241,15,217,152,211,213,107,27,251,73,249,219,57,27,212,176,92,169,139,17,106,37,28,209,117,84,210,161,131,108,2,51,38,173,174,119,95,147,138,27,199,208,91,196,43,184,239,15,181,205,125,4,124,67,25,20,235,169,230,183,238,207,58,234,26,209,251,147,132,183,234,146,45,183,45,93,115,132,176,241,249,141,136,247,120,71,243,39,248,252,15,236,190,111,177,57,25,110,96,231,249,212,79,229,39,114,194,27,222,97,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1410a316-9495-4c31-8af0-03dd67882863"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess11",
				Position = new Point(36, 361),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 136),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLookupRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("69ea8aeb-0cb8-43fd-a67b-9ca00096c05b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1410a316-9495-4c31-8af0-03dd67882863"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"LookupRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"LookupRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLookupRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9a1dee00-a4f4-4ead-82dd-a037738ad835"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1410a316-9495-4c31-8af0-03dd67882863"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptLookupRadioButtonCheck",
				Position = new Point(77, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,177,14,130,48,20,69,103,155,244,31,42,83,73,76,127,128,56,160,18,23,7,3,196,189,208,167,54,212,22,155,87,35,49,254,187,128,110,24,230,123,206,189,183,0,76,107,212,15,40,187,22,248,81,94,64,28,156,107,66,155,75,165,221,38,32,58,27,39,148,84,206,25,102,198,100,32,183,87,168,27,80,108,205,254,43,226,7,244,230,8,236,116,63,226,172,244,221,23,205,148,70,145,89,89,153,177,100,82,60,235,21,128,57,220,131,246,160,248,196,28,206,234,51,227,203,249,99,49,123,81,178,152,221,56,73,19,32,181,170,132,39,242,125,208,74,100,183,22,187,21,139,162,56,97,148,188,41,241,128,193,91,134,62,64,242,1,234,45,64,179,74,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ef550d8f-65af-4bfa-bca9-f6e27bcf3a85"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess12",
				Position = new Point(232, 359),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMultiLookupRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4384dd6a-32b7-4b66-aae1-4943d4b42308"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef550d8f-65af-4bfa-bca9-f6e27bcf3a85"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MultiLookupRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"MultiLookupRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptRelatedLookupRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8f547662-5444-4788-ad63-667b5c84105f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef550d8f-65af-4bfa-bca9-f6e27bcf3a85"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptRelatedLookupRadioButtonCheck",
				Position = new Point(77, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,65,14,130,48,20,68,215,246,20,149,21,108,122,1,226,2,9,11,18,77,140,114,129,90,70,105,168,191,164,252,98,140,241,238,138,174,53,238,102,242,38,51,115,0,23,134,237,132,230,54,32,221,233,51,212,54,58,182,27,239,251,56,236,117,107,253,58,50,123,202,114,241,166,31,48,203,210,19,107,75,8,170,34,125,116,104,229,74,254,40,80,101,7,211,163,205,133,61,201,116,249,71,50,147,119,177,248,58,58,187,154,70,214,100,160,154,46,248,107,53,129,56,77,74,7,29,10,231,106,198,101,76,94,191,31,34,128,99,32,201,33,34,127,2,14,192,221,51,242,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("69ddeb4e-c7d4-4051-96cf-b837b7bf4b55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess13",
				Position = new Point(428, 359),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBooleanRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b7315387-9307-491a-aecc-1b87aca8d317"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("69ddeb4e-c7d4-4051-96cf-b837b7bf4b55"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"BooleanRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"BooleanRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLogicRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d46ba082-926a-41c5-a545-642d4810777e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("69ddeb4e-c7d4-4051-96cf-b837b7bf4b55"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptLogicRadioButtonCheck",
				Position = new Point(77, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,115,202,207,207,73,77,204,11,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,53,29,98,51,52,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b5978477-aa6c-41a0-9c93-4559dc7924d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess16",
				Position = new Point(623, 359),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(190, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBinaryRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b3dcc705-837b-4182-9dcc-05f920c267d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5978477-aa6c-41a0-9c93-4559dc7924d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"BinaryRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"BinaryRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSelectImageRadioButtonCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("45f2866c-4064-4b3b-ad97-f26a140d0b89"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5978477-aa6c-41a0-9c93-4559dc7924d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"SelectImageRadioButtonCheckScriptTask",
				Position = new Point(78, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,115,202,204,75,44,170,12,74,76,201,204,119,42,45,41,201,207,211,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,117,5,1,110,52,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5ab95f01-18fb-4993-bc1a-cdb45bef6f99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 530),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDateTimeRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bf194d38-726a-48fa-b68b-04ab65f62098"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ab95f01-18fb-4993-bc1a-cdb45bef6f99"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DateTimeRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"DateTimeRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDateTimeRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3701a23b-01ed-40ff-95d0-411d2ba7f878"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5ab95f01-18fb-4993-bc1a-cdb45bef6f99"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptDateTimeRadioButtonCheck",
				Position = new Point(77, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,115,73,44,73,13,201,204,77,13,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,250,142,83,28,53,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9348d872-9098-4961-bb4d-70efaafbbc0b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess9",
				Position = new Point(232, 530),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDateRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e572dba6-89d8-48d3-966f-a965b2f8acbe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9348d872-9098-4961-bb4d-70efaafbbc0b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DateRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"DateRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDateRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6a6506ac-4241-4696-9836-801073deab40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9348d872-9098-4961-bb4d-70efaafbbc0b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptDateRadioButtonCheck",
				Position = new Point(77, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,115,73,44,73,13,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,228,161,25,220,49,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e0772bb5-fe27-4c46-aa9f-c6a452af9a3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess10",
				Position = new Point(428, 533),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTimeRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("64ea1073-39c8-4dbe-9725-6ccc8bd7275d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0772bb5-fe27-4c46-aa9f-c6a452af9a3a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TimeRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"TimeRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTimeRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5730e7c1-55ab-4764-8cee-4cfa6f001742"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0772bb5-fe27-4c46-aa9f-c6a452af9a3a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptTimeRadioButtonCheck",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,11,201,204,77,13,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,97,156,108,21,49,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("67cd7304-2d1f-418d-9c42-d9e353e099d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess5",
				Position = new Point(36, 697),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateIntegerRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("519d270a-894a-4e2a-8ffd-3e519f9ba7f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67cd7304-2d1f-418d-9c42-d9e353e099d7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"IntegerRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"IntegerRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptIntegerRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("463c30b2-7bdb-432c-98eb-2f3ff6b39863"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67cd7304-2d1f-418d-9c42-d9e353e099d7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptIntegerRadioButtonCheck",
				Position = new Point(77, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,243,204,43,73,77,79,45,10,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,23,119,90,70,52,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("293deedc-89f1-430b-9b86-f5d53e006b40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess6",
				Position = new Point(232, 698),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFloatRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("34fa592d-d8c1-428a-85f7-b54a111367a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("293deedc-89f1-430b-9b86-f5d53e006b40"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FloatRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"FloatRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptFloatRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9cc92a92-ac0f-42d8-9424-51117f2cb585"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("293deedc-89f1-430b-9b86-f5d53e006b40"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptFloatRadioButtonCheck",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,115,203,201,79,44,9,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,179,76,26,240,50,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c22aa2ed-6c97-4125-a824-830d91103354"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess14",
				Position = new Point(428, 698),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMoneyRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e549b0e1-838a-4459-8bf0-0f2a0f1621a4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c22aa2ed-6c97-4125-a824-830d91103354"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MoneyRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"MoneyRadioButtonCheck",
				Position = new Point(14, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptCurrencyRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("67ba233e-fcb9-45f7-b96f-d0b6638da749"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c22aa2ed-6c97-4125-a824-830d91103354"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptCurrencyRadioButtonCheck",
				Position = new Point(77, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,243,205,207,75,173,12,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,142,157,51,120,50,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("11070241-39c3-434a-8b74-93348efe870c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 862),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateShortTextRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6970c956-ec46-4ec7-8733-1e8ab1a6ad53"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11070241-39c3-434a-8b74-93348efe870c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ShortTextRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ShortTextRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptShortStringRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("43514e45-6a3b-4d8a-958f-8d7088f8f043"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11070241-39c3-434a-8b74-93348efe870c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptShortStringRadioButtonCheck",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,11,206,200,47,42,9,73,173,40,9,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,67,40,128,105,54,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8fabbe9e-aa54-49dd-b6b9-a490f5ed4c82"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess2",
				Position = new Point(232, 865),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMediumTextRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e9d4c901-6138-4fe5-a675-fccab46457c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fabbe9e-aa54-49dd-b6b9-a490f5ed4c82"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MediumTextRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"MediumTextRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptMiddleStringRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7700ffe3-3dc3-4871-8196-d780d6b837e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fabbe9e-aa54-49dd-b6b9-a490f5ed4c82"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptMiddleStringRadioButtonCheck",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,243,77,77,201,44,205,13,73,173,40,9,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,51,104,145,169,55,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5b4a692a-66f1-46ab-811b-1a7146d468c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess3",
				Position = new Point(428, 861),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLongTextRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("517f6398-8a0c-4728-86de-55551ce49040"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b4a692a-66f1-46ab-811b-1a7146d468c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"LongTextRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"LongTextRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLongStringRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eed65fd6-d5a2-46bb-bacd-be53fa099414"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b4a692a-66f1-46ab-811b-1a7146d468c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptLongStringRadioButtonCheck",
				Position = new Point(77, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,243,201,207,75,15,73,173,40,9,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,44,171,202,55,53,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f7b45d89-a2da-4b81-a993-cab13c9933c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess4",
				Position = new Point(624, 861),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMaxSizeTextRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f2ed4de5-9d62-4e70-957f-6327e904563b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7b45d89-a2da-4b81-a993-cab13c9933c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MaxSizeTextRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"MaxSizeTextRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptMaxStringRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d2bc0fd0-fe1c-4e7a-812d-53bea83deda7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7b45d89-a2da-4b81-a993-cab13c9933c1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptMaxStringRadioButtonCheck",
				Position = new Point(77, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,243,77,172,8,206,172,74,13,73,173,40,9,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,129,145,237,240,56,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("76d7b553-8c6c-4e79-9378-9705ea23cc96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"EventSubProcess7",
				Position = new Point(820, 860),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSecureTextRadioButtonCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9292e915-2d29-4360-ab9a-ccd844708a07"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("76d7b553-8c6c-4e79-9378-9705ea23cc96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SecureTextRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"SecureTextRadioButtonCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSecureTextRadioButtonCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("70d4b300-9479-4fec-86d8-551b06e71361"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("76d7b553-8c6c-4e79-9378-9705ea23cc96"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptSecureTextRadioButtonCheck",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,76,46,201,44,75,13,169,44,72,213,8,72,76,79,213,11,78,77,46,45,74,13,73,173,40,9,74,76,201,204,119,42,45,41,201,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,133,110,113,175,55,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8036e55c-b1b1-45e7-9e4a-25682c974a26"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"PageLoadSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 1026),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(192, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("aaf6f3f6-4346-4fb4-867f-ec11592efa9d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8036e55c-b1b1-45e7-9e4a-25682c974a26"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"PageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(8, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fdb35110-ddbf-468d-b51a-25795be256e4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8036e55c-b1b1-45e7-9e4a-25682c974a26"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptPageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,169,44,72,13,78,205,73,77,46,201,204,207,243,205,79,73,213,84,168,230,226,12,72,76,79,213,115,78,44,0,9,58,231,231,149,20,229,231,248,36,86,230,151,150,232,121,100,166,164,164,230,41,216,42,148,20,149,166,90,67,85,250,37,230,166,18,163,186,150,171,40,181,164,180,40,15,194,5,0,54,194,202,88,127,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fec5daec-8a77-48bb-86fa-30f98e8fc8ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"InitSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(238, 1026),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(219, 126),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateReturnParametersStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c60033be-0c93-4c48-a201-10143ffb3279"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec5daec-8a77-48bb-86fa-30f98e8fc8ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ReturnParameters",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ReturnParameters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptReturnParametersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f82d3c07-c6d2-4cf0-b70b-0f8b114954aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fec5daec-8a77-48bb-86fa-30f98e8fc8ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptReturnParameters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,203,106,220,48,20,93,103,32,255,32,188,178,97,80,210,7,148,210,38,208,186,78,8,36,33,205,228,177,40,93,8,251,102,34,226,145,92,73,78,48,37,208,166,203,22,186,239,103,148,22,210,166,164,191,160,249,163,74,150,60,47,59,164,139,129,145,116,206,185,247,30,223,123,233,9,10,247,136,0,166,246,4,79,65,202,195,173,12,173,173,33,86,230,121,132,222,47,247,150,4,168,82,48,164,68,9,207,150,123,151,203,189,115,34,80,225,192,104,13,29,74,16,49,103,12,82,69,57,195,91,94,38,97,67,202,0,111,66,163,251,178,50,202,173,80,145,145,164,38,133,137,222,189,145,25,25,129,9,187,71,134,128,119,205,255,36,163,10,31,145,188,198,88,64,74,10,155,73,131,137,221,81,205,225,108,200,152,231,229,136,29,84,5,216,168,193,54,231,103,101,17,184,200,86,39,163,117,69,68,84,131,244,20,70,164,17,124,53,185,119,148,57,225,78,166,117,20,49,184,64,155,37,205,194,197,87,124,192,7,74,80,54,12,163,168,81,48,30,81,229,223,119,8,51,97,69,19,222,147,230,222,140,159,231,52,3,97,237,246,87,97,144,180,53,76,117,68,162,3,16,130,72,126,162,112,204,5,224,26,71,65,226,14,130,205,103,101,69,127,211,183,250,71,31,233,223,250,118,124,101,126,31,198,159,245,175,250,168,255,232,191,250,90,223,232,107,115,249,73,255,28,95,141,63,142,191,34,139,210,55,227,47,22,130,244,119,116,204,197,153,44,72,10,40,222,127,240,228,209,195,167,143,59,10,125,93,130,168,188,83,201,226,125,216,97,73,31,5,71,23,131,74,122,151,217,36,74,48,49,82,78,94,51,247,189,119,93,251,180,226,226,23,153,71,132,129,233,203,32,170,155,203,202,180,161,27,52,87,32,164,165,132,237,215,88,0,81,224,48,199,84,157,154,150,55,74,150,16,186,203,152,143,10,34,168,228,117,243,225,228,93,73,242,126,71,70,251,156,43,255,181,235,49,162,35,211,51,211,42,194,168,223,209,105,211,30,74,121,158,187,161,236,172,215,72,58,147,227,9,46,156,159,229,46,19,141,148,109,98,156,140,10,85,217,119,59,73,211,72,166,163,74,166,208,58,90,117,115,180,52,79,157,2,223,172,190,181,25,88,3,188,237,245,4,61,183,226,235,97,231,87,171,211,49,75,96,201,239,10,60,168,119,75,1,66,85,53,57,244,51,220,80,131,254,108,230,150,126,137,32,151,128,58,166,127,167,204,21,109,173,128,89,215,182,169,84,205,12,58,160,253,107,220,82,196,44,58,129,237,105,139,73,69,88,10,216,47,56,191,254,102,83,76,22,36,93,171,254,111,73,50,232,183,146,138,220,110,188,91,98,90,170,97,79,15,150,119,55,105,131,66,158,89,219,13,199,174,220,133,45,117,15,209,47,93,195,245,219,120,129,62,187,217,255,1,207,234,252,194,130,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4c8c892d-d753-4d51-814c-f6809ac4d119"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"PageLoadCompleteSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(462, 1026),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(222, 126),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0b62c74e-57d1-48a7-b51e-03355e4d4e96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4c8c892d-d753-4d51-814c-f6809ac4d119"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"PageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(8, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("de059205-8a87-46e3-a88f-ce6712cc437c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4c8c892d-d753-4d51-814c-f6809ac4d119"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,193,14,130,48,16,68,239,126,5,225,132,137,105,63,192,120,80,14,134,132,3,17,244,222,148,137,16,176,37,219,173,145,191,183,5,57,122,219,221,153,121,179,82,94,193,185,53,76,118,116,89,165,158,16,181,238,240,82,98,59,238,143,59,41,87,161,179,196,13,62,124,83,109,111,47,158,217,26,145,119,208,3,218,228,148,48,121,68,111,13,62,107,238,223,104,230,9,217,223,100,224,46,90,105,237,224,167,56,198,70,213,27,144,136,91,97,28,43,163,33,42,178,26,206,137,192,13,227,4,226,249,161,70,143,44,45,123,199,8,254,104,255,185,238,69,155,30,146,5,188,229,54,80,144,66,39,129,61,153,245,217,47,66,28,183,171,253,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateChildInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaChildInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9322d8b2-9a67-4a87-9863-7b91594e8f2c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ed7f8cf3-3c58-40fc-bd59-3e34acae2c87"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ChildInitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 1193),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(336, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaChildInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1b7687b3-83b1-4266-97b2-be7174c1419d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9322d8b2-9a67-4a87-9863-7b91594e8f2c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d966fcc5-6e88-4cc8-80ca-d8d6a3ee97da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9322d8b2-9a67-4a87-9863-7b91594e8f2c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"BaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("640b672a-6784-463e-a571-ba4ce6399f6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9322d8b2-9a67-4a87-9863-7b91594e8f2c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,81,75,75,195,64,16,62,87,240,63,12,57,181,24,242,7,250,128,210,70,16,84,2,245,113,16,15,107,50,73,215,110,118,227,204,70,27,66,254,187,155,135,173,30,60,22,122,216,203,176,223,59,18,25,6,107,25,91,105,180,160,234,214,152,93,89,132,137,180,65,68,88,8,194,254,114,45,149,69,130,171,57,36,168,48,19,22,97,108,222,222,49,182,192,168,19,36,31,142,208,240,19,181,93,82,198,128,19,168,47,47,70,43,163,20,118,18,179,163,212,140,45,73,157,249,208,243,44,22,144,118,34,12,115,192,160,23,228,169,67,15,231,96,153,36,99,141,95,240,63,5,212,224,254,143,160,246,98,147,59,243,146,141,126,168,10,244,124,232,249,86,127,206,65,248,81,10,213,248,3,70,97,106,195,125,65,200,236,232,157,231,50,215,145,176,91,135,246,54,21,63,27,218,113,33,98,244,14,136,146,113,45,185,80,162,122,18,170,108,101,82,161,24,161,241,127,124,144,204,182,191,72,35,65,34,71,103,164,251,207,14,208,6,234,221,191,188,66,29,181,107,60,114,107,84,235,190,177,224,160,27,220,36,77,211,76,206,165,146,112,111,221,242,46,145,27,251,132,149,116,240,115,202,125,39,180,91,137,238,157,235,19,198,246,66,109,165,173,54,241,22,115,49,72,122,67,13,141,123,132,182,36,13,150,74,156,126,3,168,130,76,73,196,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetControlsMethod());
			Methods.Add(CreateSetActiveTypeMethod());
			Methods.Add(CreateSetTypeMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d3578cc4-e09a-47d0-8ea2-8e8e5809d5f3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7872585c-9c1c-4e84-a77c-d58b60028111"),
				Name = "GetControls",
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("528c59b4-944a-4b3e-9ea3-93b7d3e7204d"),
				Name = "control",
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "System.Web.UI.ControlCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,81,79,194,48,16,199,159,199,167,56,247,212,33,41,31,128,236,65,145,168,9,49,6,49,62,151,245,6,133,209,146,174,67,9,217,119,183,101,221,50,4,17,247,178,174,253,247,119,119,255,221,165,74,35,75,22,100,203,52,8,131,107,16,18,18,37,141,86,89,4,251,78,32,82,226,182,233,35,154,233,110,131,36,162,47,108,141,16,199,16,78,24,23,234,190,48,70,201,240,160,117,15,33,83,212,154,229,42,53,244,253,153,126,224,108,88,209,114,218,44,90,23,35,7,143,232,221,146,125,141,182,40,141,85,45,48,89,209,195,7,220,198,192,49,195,57,51,72,212,108,137,137,129,28,37,71,221,131,191,163,52,204,59,61,207,1,35,159,96,224,42,213,46,3,136,61,13,88,126,5,175,149,245,192,163,68,10,228,128,170,178,70,222,216,16,4,67,149,21,107,233,60,179,113,42,145,115,142,78,112,147,177,4,201,145,125,61,8,195,168,166,6,175,108,142,244,65,36,70,40,201,244,110,172,212,170,216,140,184,48,244,73,112,142,210,2,73,11,127,99,255,69,165,249,201,168,118,221,210,85,193,132,68,253,59,98,130,153,245,153,159,144,250,93,219,3,237,106,78,181,181,244,98,84,219,59,13,243,148,120,30,117,214,132,183,133,250,108,177,48,203,113,255,239,12,46,155,220,86,150,221,190,95,150,213,187,180,71,101,112,113,52,124,211,140,217,78,21,198,15,135,149,213,189,68,174,153,146,35,134,159,147,250,208,101,87,118,202,142,70,83,104,57,248,6,40,22,33,5,197,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetActiveTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("05c2a1a1-ef3c-4658-8086-8de891c6b79c"),
				Name = "SetActiveType",
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("93e204ef-6f77-4303-b9c7-85e52ce4ea21"),
				Name = "RadioButton",
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.UI.WebControls.Controls.RadioButton",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,65,14,130,48,16,69,215,114,138,202,10,19,211,11,24,54,16,98,216,24,131,122,128,134,126,165,177,78,73,41,168,49,222,221,18,193,16,117,61,51,239,253,63,234,200,162,121,33,164,50,73,235,156,33,158,86,40,207,144,11,246,8,102,22,174,181,180,10,158,65,106,116,123,161,253,189,6,139,217,116,125,35,46,224,5,106,45,74,68,225,100,18,46,89,24,46,86,129,242,130,173,176,32,183,181,166,68,211,28,114,201,226,152,81,171,245,151,164,19,150,213,239,37,111,57,52,176,169,33,66,233,148,23,229,195,121,70,39,69,224,107,140,188,228,238,137,63,138,193,252,193,253,21,14,83,190,175,172,185,102,157,7,140,7,60,39,7,75,66,251,4,14,55,231,203,236,160,125,20,200,254,9,105,37,232,4,217,247,27,104,47,1,197,128,146,72,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b4cf8d89-bc29-4258-93aa-ae1c1e4303da"),
				Name = "SetType",
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2390f3f4-3c6f-40ee-b197-ecb8677ee4a6"),
				Name = "typeCode",
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("60067b79-a1b2-469b-b80e-3d514eb24985"),
				Name = "lookupSchemaId",
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b858183d-9d96-47cf-bfa2-b9af2eb86155"),
				Name = "lookupSchemaIds",
				CreatedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				ModifiedInSchemaUId = new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,149,223,111,211,48,16,199,159,139,196,255,96,229,41,145,170,108,252,144,16,27,76,218,178,110,170,180,161,177,118,219,3,226,193,75,142,214,106,98,23,219,89,23,208,36,24,143,32,241,206,159,129,64,26,12,141,127,193,253,143,176,227,54,77,211,109,144,23,30,34,197,95,95,62,119,190,59,95,196,136,200,176,143,92,153,13,33,96,17,120,232,237,221,59,141,16,11,64,206,6,161,152,103,206,10,210,74,99,15,247,192,183,202,62,142,8,219,72,165,100,212,15,250,16,14,32,66,79,145,228,41,172,106,203,99,14,120,176,90,64,218,84,66,15,184,179,82,64,38,74,45,202,86,204,176,44,49,242,117,45,194,46,163,144,149,8,249,186,22,97,135,177,65,58,44,33,172,112,59,163,113,130,57,18,97,31,18,28,224,161,36,140,234,77,33,57,161,61,191,149,12,101,86,24,37,152,106,40,215,219,7,2,120,192,40,133,208,216,251,219,32,59,57,96,215,90,184,78,139,74,34,179,57,209,241,16,22,232,154,13,205,55,30,150,150,212,23,117,165,190,53,145,250,169,174,198,231,250,121,55,254,168,126,228,75,245,75,253,86,23,234,82,93,104,241,131,250,62,62,31,191,31,127,70,198,74,93,142,63,25,19,164,190,162,35,198,7,98,136,67,64,193,254,189,71,15,238,63,126,56,141,29,74,126,159,167,192,51,125,10,10,163,185,120,114,221,157,156,178,137,156,195,81,39,19,118,171,77,11,180,227,21,9,9,109,190,2,22,167,9,125,134,19,208,208,5,71,254,122,20,89,11,215,153,36,216,241,124,99,157,115,22,237,183,72,44,129,11,243,157,187,184,27,232,146,75,176,54,71,68,246,247,48,215,40,243,129,107,197,128,37,67,204,137,96,180,171,111,140,223,122,157,226,88,31,230,160,29,57,205,252,200,219,41,137,220,56,239,140,201,225,34,207,243,254,107,48,58,175,179,124,54,171,237,84,108,249,38,178,213,185,18,18,16,215,38,89,183,160,45,165,78,117,108,57,238,60,214,130,200,43,228,78,65,126,192,82,42,209,26,90,182,51,165,209,168,94,131,169,229,139,229,151,198,131,57,195,164,150,135,56,78,225,137,189,38,107,238,66,35,88,103,103,197,69,220,36,121,12,122,52,217,43,217,138,136,244,59,32,115,204,58,141,186,112,42,221,155,138,211,156,191,158,150,125,51,182,69,241,113,124,235,160,73,99,73,22,102,69,73,253,203,192,40,141,22,243,170,83,44,49,161,192,175,241,124,179,173,89,181,169,144,152,234,58,239,113,22,130,16,38,35,250,117,8,92,102,121,102,230,7,201,14,17,82,119,203,62,196,186,233,34,11,53,154,87,195,83,183,207,217,168,117,162,11,235,234,193,175,139,139,99,242,6,102,44,123,187,43,9,219,96,44,6,76,75,201,154,40,181,166,243,166,142,186,75,18,40,97,166,82,109,78,133,81,235,251,74,12,181,253,119,250,140,75,211,176,37,72,161,213,251,227,65,68,210,164,130,154,137,53,255,125,180,87,33,77,165,122,49,225,211,142,238,136,106,80,51,181,94,174,32,76,121,21,54,19,255,141,117,246,7,95,155,185,103,3,9,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SetColumnPrimaryInfoPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6b585f4-055a-4462-b208-e552e6d68e39"));
		}

		#endregion

	}

	#endregion

}

