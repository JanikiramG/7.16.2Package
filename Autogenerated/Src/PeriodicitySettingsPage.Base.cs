namespace Terrasoft.WebApp
{

	using DaysOfWeek = Terrasoft.Configuration.DaysOfWeek;
	using HoursOrMinutes = Terrasoft.Configuration.HoursOrMinutes;
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

	#region Class: PeriodicitySettingsPageSchema

	/// <exclude/>
	public class PeriodicitySettingsPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _dailyRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton DailyRadioButton {
			get {
				return _dailyRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _dailyEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit DailyEdit {
			get {
				return _dailyEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label1;
		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return _label1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return _controlLayout5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _weeklyRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton WeeklyRadioButton {
			get {
				return _weeklyRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _weeklyEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit WeeklyEdit {
			get {
				return _weeklyEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _monthlyRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton MonthlyRadioButton {
			get {
				return _monthlyRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout7;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return _controlLayout7;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout10;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout10 {
			get {
				return _controlLayout10;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _monthlyCustomRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton MonthlyCustomRadioButton {
			get {
				return _monthlyCustomRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _monthlyCustomEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit MonthlyCustomEdit {
			get {
				return _monthlyCustomEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label2;
		public Terrasoft.UI.WebControls.Controls.Label Label2 {
			get {
				return _label2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout6;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return _controlLayout6;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout11;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout11 {
			get {
				return _controlLayout11;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer2;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return _spacer2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _monthlyLastDayRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton MonthlyLastDayRadioButton {
			get {
				return _monthlyLastDayRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout8;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout8 {
			get {
				return _controlLayout8;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _onceRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton OnceRadioButton {
			get {
				return _onceRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _onceEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit OnceEdit {
			get {
				return _onceEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout9;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return _controlLayout9;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _customRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton CustomRadioButton {
			get {
				return _customRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _customPeriodEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit CustomPeriodEdit {
			get {
				return _customPeriodEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _customPeriodTypeEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CustomPeriodTypeEdit {
			get {
				return _customPeriodTypeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _customFromEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CustomFromEdit {
			get {
				return _customFromEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _customTillEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CustomTillEdit {
			get {
				return _customTillEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label3;
		public Terrasoft.UI.WebControls.Controls.Label Label3 {
			get {
				return _label3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout13;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout13 {
			get {
				return _controlLayout13;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label4;
		public Terrasoft.UI.WebControls.Controls.Label Label4 {
			get {
				return _label4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _startDateTimeEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit StartDateTimeEdit {
			get {
				return _startDateTimeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout14;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout14 {
			get {
				return _controlLayout14;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label5;
		public Terrasoft.UI.WebControls.Controls.Label Label5 {
			get {
				return _label5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _neverEndRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton NeverEndRadioButton {
			get {
				return _neverEndRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout12;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout12 {
			get {
				return _controlLayout12;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer3;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer3 {
			get {
				return _spacer3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _customEndRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton CustomEndRadioButton {
			get {
				return _customEndRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _endDateTimeEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit EndDateTimeEdit {
			get {
				return _endDateTimeEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public PeriodicitySettingsPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public PeriodicitySettingsPageSchema(PeriodicitySettingsPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			RealUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			Name = "PeriodicitySettingsPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 492;
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePeriodicitySettingsPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateDailyRadioButton());
			ControlLayout4.InsertItem(1, CreateDailyEdit());
			ControlLayout4.InsertItem(2, CreateLabel1());
			ControlLayout1.InsertItem(1, CreateControlLayout5());
			ControlLayout5.InsertItem(0, CreateWeeklyRadioButton());
			ControlLayout5.InsertItem(1, CreateWeeklyEdit());
			ControlLayout1.InsertItem(2, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateMonthlyRadioButton());
			ControlLayout3.InsertItem(1, CreateControlLayout7());
			ControlLayout7.InsertItem(0, CreateControlLayout10());
			ControlLayout10.InsertItem(0, CreateSpacer1());
			ControlLayout10.InsertItem(1, CreateMonthlyCustomRadioButton());
			ControlLayout7.InsertItem(1, CreateMonthlyCustomEdit());
			ControlLayout7.InsertItem(2, CreateLabel2());
			ControlLayout3.InsertItem(2, CreateControlLayout6());
			ControlLayout6.InsertItem(0, CreateControlLayout11());
			ControlLayout11.InsertItem(0, CreateSpacer2());
			ControlLayout11.InsertItem(1, CreateMonthlyLastDayRadioButton());
			MainControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateControlLayout8());
			ControlLayout8.InsertItem(0, CreateOnceRadioButton());
			ControlLayout8.InsertItem(1, CreateOnceEdit());
			ControlLayout2.InsertItem(1, CreateControlLayout9());
			ControlLayout9.InsertItem(0, CreateCustomRadioButton());
			ControlLayout9.InsertItem(1, CreateCustomPeriodEdit());
			ControlLayout9.InsertItem(2, CreateCustomPeriodTypeEdit());
			ControlLayout9.InsertItem(3, CreateCustomFromEdit());
			ControlLayout9.InsertItem(4, CreateCustomTillEdit());
			MainControlLayout.InsertItem(2, CreateLabel3());
			MainControlLayout.InsertItem(3, CreateControlLayout13());
			ControlLayout13.InsertItem(0, CreateLabel4());
			ControlLayout13.InsertItem(1, CreateStartDateTimeEdit());
			MainControlLayout.InsertItem(4, CreateControlLayout14());
			ControlLayout14.InsertItem(0, CreateLabel5());
			ControlLayout14.InsertItem(1, CreateNeverEndRadioButton());
			MainControlLayout.InsertItem(5, CreateControlLayout12());
			ControlLayout12.InsertItem(0, CreateSpacer3());
			ControlLayout12.InsertItem(1, CreateCustomEndRadioButton());
			ControlLayout12.InsertItem(2, CreateEndDateTimeEdit());
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

		protected virtual EmbeddedProcessSchema CreatePeriodicitySettingsPageEventsProcessSchema() {
			var schema = new PeriodicitySettingsPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateDailyRadioButton() {
			_dailyRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_dailyRadioButton.UId = new Guid("e9adeffb-dc14-4fd8-a824-ac85c31df14c");
			_dailyRadioButton.Name = "DailyRadioButton";
			_dailyRadioButton.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_dailyRadioButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_dailyRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dailyRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_dailyRadioButton.Tag = "";
			_dailyRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dailyRadioButton.Width = System.Web.UI.WebControls.Unit.Pixel(130);
			_dailyRadioButton.GroupName = "";
			return _dailyRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateDailyEdit() {
			_dailyEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_dailyEdit.UId = new Guid("433044ab-4512-430c-967c-081fa558856c");
			_dailyEdit.Name = "DailyEdit";
			_dailyEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_dailyEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_dailyEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dailyEdit.Tag = "";
			_dailyEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dailyEdit.Image = new ControlImage {};
			_dailyEdit.Width = System.Web.UI.WebControls.Unit.Pixel(35);
			_dailyEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			return _dailyEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel1() {
			_label1 = new Terrasoft.UI.WebControls.Controls.Label();
			_label1.UId = new Guid("2a2c2387-3776-49bd-ac7c-048bc96a0834");
			_label1.Name = "Label1";
			_label1.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label1.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label1.Tag = "";
			_label1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_label1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _label1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("15aae3f1-2b23-4913-a6a3-83ee48ec7679");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout4.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout4.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout4.FitHeightByContent = true;
			_controlLayout4.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateWeeklyRadioButton() {
			_weeklyRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_weeklyRadioButton.UId = new Guid("3641bceb-1286-48d5-b70f-25cc2cf30320");
			_weeklyRadioButton.Name = "WeeklyRadioButton";
			_weeklyRadioButton.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_weeklyRadioButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_weeklyRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_weeklyRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_weeklyRadioButton.Tag = "";
			_weeklyRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weeklyRadioButton.Width = System.Web.UI.WebControls.Unit.Pixel(130);
			_weeklyRadioButton.GroupName = "";
			return _weeklyRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateWeeklyEdit() {
			_weeklyEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_weeklyEdit.UId = new Guid("cd219ab7-c83e-4c4d-ae14-bb196bfacf76");
			_weeklyEdit.Name = "WeeklyEdit";
			_weeklyEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_weeklyEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_weeklyEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_weeklyEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_weeklyEdit.Tag = "";
			_weeklyEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weeklyEdit.Image = new ControlImage {};
			_weeklyEdit.Width = System.Web.UI.WebControls.Unit.Pixel(120);
			_weeklyEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			return _weeklyEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout5() {
			_controlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout5.UId = new Guid("6466f2d4-a09d-42ab-b773-19a121227bc9");
			_controlLayout5.Name = "ControlLayout5";
			_controlLayout5.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout5.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout5.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout5.Tag = "";
			_controlLayout5.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout5.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout5.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout5.FitHeightByContent = true;
			_controlLayout5.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout5.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.StartNewAlignGroup = false;
			_controlLayout5.Image = new ControlImage {};
			_controlLayout5.Edges = "";
			return _controlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMonthlyRadioButton() {
			_monthlyRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_monthlyRadioButton.UId = new Guid("da6eedc3-bf20-4f09-9812-dc2d0d7de2b5");
			_monthlyRadioButton.Name = "MonthlyRadioButton";
			_monthlyRadioButton.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_monthlyRadioButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_monthlyRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_monthlyRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_monthlyRadioButton.Tag = "";
			_monthlyRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_monthlyRadioButton.Width = System.Web.UI.WebControls.Unit.Pixel(130);
			_monthlyRadioButton.GroupName = "";
			return _monthlyRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("3f15955a-f8d0-4875-8c91-37e28ef2367e");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_spacer1.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Pixel(30);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMonthlyCustomRadioButton() {
			_monthlyCustomRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_monthlyCustomRadioButton.UId = new Guid("d12fb322-304c-42ec-8523-e23ef2c954ca");
			_monthlyCustomRadioButton.Name = "MonthlyCustomRadioButton";
			_monthlyCustomRadioButton.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_monthlyCustomRadioButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_monthlyCustomRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_monthlyCustomRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_monthlyCustomRadioButton.Tag = "";
			_monthlyCustomRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_monthlyCustomRadioButton.Width = System.Web.UI.WebControls.Unit.Pixel(100);
			_monthlyCustomRadioButton.GroupName = "";
			return _monthlyCustomRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout10() {
			_controlLayout10 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout10.UId = new Guid("e805a285-2e8f-4ab2-aad6-a6424523537b");
			_controlLayout10.Name = "ControlLayout10";
			_controlLayout10.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout10.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout10.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout10.Tag = "";
			_controlLayout10.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout10.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout10.FitHeightByContent = true;
			_controlLayout10.Width = System.Web.UI.WebControls.Unit.Pixel(130);
			_controlLayout10.StartNewAlignGroup = false;
			_controlLayout10.Image = new ControlImage {};
			_controlLayout10.Edges = "";
			return _controlLayout10;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateMonthlyCustomEdit() {
			_monthlyCustomEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_monthlyCustomEdit.UId = new Guid("e8fd5c40-dd19-4047-9a57-a173002f9ad2");
			_monthlyCustomEdit.Name = "MonthlyCustomEdit";
			_monthlyCustomEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_monthlyCustomEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_monthlyCustomEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_monthlyCustomEdit.Tag = "";
			_monthlyCustomEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_monthlyCustomEdit.Image = new ControlImage {};
			_monthlyCustomEdit.Width = System.Web.UI.WebControls.Unit.Pixel(35);
			_monthlyCustomEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			return _monthlyCustomEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel2() {
			_label2 = new Terrasoft.UI.WebControls.Controls.Label();
			_label2.UId = new Guid("63cd5ebd-baf8-4386-ab6f-0ae099b9c399");
			_label2.Name = "Label2";
			_label2.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label2.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label2.Tag = "";
			_label2.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_label2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _label2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout7() {
			_controlLayout7 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout7.UId = new Guid("97737d52-4004-4a3a-8e37-0edce85a0c6b");
			_controlLayout7.Name = "ControlLayout7";
			_controlLayout7.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout7.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout7.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout7.Tag = "";
			_controlLayout7.Height = System.Web.UI.WebControls.Unit.Pixel(100);
			_controlLayout7.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout7.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout7.FitHeightByContent = true;
			_controlLayout7.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout7.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout7.StartNewAlignGroup = false;
			_controlLayout7.Image = new ControlImage {};
			_controlLayout7.Edges = "";
			return _controlLayout7;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer2() {
			_spacer2 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer2.UId = new Guid("b7e486bf-647c-42b0-a25e-ce9b13496a07");
			_spacer2.Name = "Spacer2";
			_spacer2.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_spacer2.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_spacer2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer2.Tag = "";
			_spacer2.Size = System.Web.UI.WebControls.Unit.Pixel(30);
			return _spacer2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMonthlyLastDayRadioButton() {
			_monthlyLastDayRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_monthlyLastDayRadioButton.UId = new Guid("cdab278f-edce-4f7f-978d-4c0c5f381850");
			_monthlyLastDayRadioButton.Name = "MonthlyLastDayRadioButton";
			_monthlyLastDayRadioButton.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_monthlyLastDayRadioButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_monthlyLastDayRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_monthlyLastDayRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_monthlyLastDayRadioButton.Tag = "";
			_monthlyLastDayRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_monthlyLastDayRadioButton.Width = System.Web.UI.WebControls.Unit.Pixel(130);
			_monthlyLastDayRadioButton.GroupName = "";
			return _monthlyLastDayRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout11() {
			_controlLayout11 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout11.UId = new Guid("22f429f3-9e84-42ad-b78e-3d117cada882");
			_controlLayout11.Name = "ControlLayout11";
			_controlLayout11.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout11.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout11.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout11.Tag = "";
			_controlLayout11.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout11.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout11.FitHeightByContent = true;
			_controlLayout11.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout11.StartNewAlignGroup = false;
			_controlLayout11.Image = new ControlImage {};
			_controlLayout11.Edges = "";
			return _controlLayout11;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout6() {
			_controlLayout6 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout6.UId = new Guid("cb1d2132-1d5d-41db-aa5f-48865f45ca4e");
			_controlLayout6.Name = "ControlLayout6";
			_controlLayout6.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout6.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout6.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout6.Tag = "";
			_controlLayout6.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout6.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout6.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout6.FitHeightByContent = true;
			_controlLayout6.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout6.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout6.StartNewAlignGroup = false;
			_controlLayout6.Image = new ControlImage {};
			_controlLayout6.Edges = "";
			return _controlLayout6;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("7c35255b-b7cf-4615-8645-e5a956de3a2e");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout3.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(150);
			_controlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("cf73ff5a-7dc3-43bd-babf-2d8bff580894");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout1.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(320);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			_controlLayout1.Hidden = true;
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateOnceRadioButton() {
			_onceRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_onceRadioButton.UId = new Guid("4cdc1886-b7f2-4675-ba7b-087d32b9f010");
			_onceRadioButton.Name = "OnceRadioButton";
			_onceRadioButton.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_onceRadioButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_onceRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_onceRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_onceRadioButton.Tag = "";
			_onceRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_onceRadioButton.Width = System.Web.UI.WebControls.Unit.Pixel(123);
			_onceRadioButton.DataSource = "DataSource";
			_onceRadioButton.ColumnUId = new Guid("57c67041-c61c-48c9-aeea-86bea1044574");
			_onceRadioButton.GroupName = "MainGroup";
			return _onceRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateOnceEdit() {
			_onceEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_onceEdit.UId = new Guid("76efda7f-1330-4bff-9742-c2ef03b74ef1");
			_onceEdit.Name = "OnceEdit";
			_onceEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_onceEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_onceEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_onceEdit.Tag = "";
			_onceEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_onceEdit.Width = System.Web.UI.WebControls.Unit.Pixel(65);
			_onceEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_onceEdit.DataSource = "DataSource";
			_onceEdit.ColumnUId = new Guid("609e406b-2cb1-4378-b01a-e5b135473e3e");
			_onceEdit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			return _onceEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout8() {
			_controlLayout8 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout8.UId = new Guid("6b84e278-ccca-40f8-aeb9-6ac90fa0f47a");
			_controlLayout8.Name = "ControlLayout8";
			_controlLayout8.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout8.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout8.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout8.Tag = "";
			_controlLayout8.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout8.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout8.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout8.FitHeightByContent = true;
			_controlLayout8.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout8.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout8.StartNewAlignGroup = false;
			_controlLayout8.Image = new ControlImage {};
			_controlLayout8.Edges = "";
			return _controlLayout8;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateCustomRadioButton() {
			_customRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_customRadioButton.UId = new Guid("fe5607d6-ae81-4ab0-9b30-051c71458721");
			_customRadioButton.Name = "CustomRadioButton";
			_customRadioButton.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customRadioButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_customRadioButton.Tag = "";
			_customRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_customRadioButton.Width = System.Web.UI.WebControls.Unit.Pixel(123);
			_customRadioButton.DataSource = "DataSource";
			_customRadioButton.ColumnUId = new Guid("62fea540-4e04-4769-9d94-b0990fe21b42");
			_customRadioButton.GroupName = "MainGroup";
			return _customRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateCustomPeriodEdit() {
			_customPeriodEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_customPeriodEdit.UId = new Guid("32eed9b1-8679-4da3-947b-e5e884133d34");
			_customPeriodEdit.Name = "CustomPeriodEdit";
			_customPeriodEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customPeriodEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customPeriodEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customPeriodEdit.Tag = "";
			_customPeriodEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_customPeriodEdit.Image = new ControlImage {};
			_customPeriodEdit.Width = System.Web.UI.WebControls.Unit.Pixel(65);
			_customPeriodEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_customPeriodEdit.DataSource = "DataSource";
			_customPeriodEdit.ColumnUId = new Guid("6db774e0-9b07-4a79-aae5-0e7d8f6fb29d");
			return _customPeriodEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateCustomPeriodTypeEdit() {
			_customPeriodTypeEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_customPeriodTypeEdit.UId = new Guid("e0bc96cb-b35a-42a8-ac4a-50b39cdffeb3");
			_customPeriodTypeEdit.Name = "CustomPeriodTypeEdit";
			_customPeriodTypeEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customPeriodTypeEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customPeriodTypeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customPeriodTypeEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_customPeriodTypeEdit.Tag = "";
			_customPeriodTypeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_customPeriodTypeEdit.Image = new ControlImage {};
			_customPeriodTypeEdit.Width = System.Web.UI.WebControls.Unit.Pixel(100);
			return _customPeriodTypeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCustomFromEdit() {
			_customFromEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_customFromEdit.UId = new Guid("3a772bf2-5bce-4e2d-b2b8-57b2e341a2b0");
			_customFromEdit.Name = "CustomFromEdit";
			_customFromEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customFromEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customFromEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customFromEdit.Tag = "";
			_customFromEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_customFromEdit.Width = System.Web.UI.WebControls.Unit.Pixel(69);
			_customFromEdit.DataSource = "DataSource";
			_customFromEdit.ColumnUId = new Guid("20edff30-77e7-4d37-9ff3-c316956fb138");
			_customFromEdit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			return _customFromEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCustomTillEdit() {
			_customTillEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_customTillEdit.UId = new Guid("d43b6fba-7ee9-4078-a139-b7c949b2b2b0");
			_customTillEdit.Name = "CustomTillEdit";
			_customTillEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customTillEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customTillEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customTillEdit.Tag = "";
			_customTillEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_customTillEdit.Width = System.Web.UI.WebControls.Unit.Pixel(77);
			_customTillEdit.DataSource = "DataSource";
			_customTillEdit.ColumnUId = new Guid("a18b3c17-7957-495b-8206-5647d9bd94f3");
			_customTillEdit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			return _customTillEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout9() {
			_controlLayout9 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout9.UId = new Guid("0bbffdf3-825f-4ecd-84ad-9da70055f969");
			_controlLayout9.Name = "ControlLayout9";
			_controlLayout9.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout9.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout9.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout9.Tag = "";
			_controlLayout9.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout9.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout9.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout9.FitHeightByContent = true;
			_controlLayout9.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout9.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout9.StartNewAlignGroup = false;
			_controlLayout9.Image = new ControlImage {};
			_controlLayout9.Edges = "";
			return _controlLayout9;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("f7647057-0ff2-461d-be40-027a45e0722b");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout2.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(250);
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel3() {
			_label3 = new Terrasoft.UI.WebControls.Controls.Label();
			_label3.UId = new Guid("8ee721de-1a2f-4b37-91ec-fbbc9cbe2ea1");
			_label3.Name = "Label3";
			_label3.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label3.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label3.Tag = "";
			_label3.DisplayStyle = Terrasoft.UI.WebControls.Controls.LabelDisplayStyle.GroupHeader;
			_label3.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_label3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _label3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel4() {
			_label4 = new Terrasoft.UI.WebControls.Controls.Label();
			_label4.UId = new Guid("2868b66d-bc96-4b09-b067-9950b29ee0b9");
			_label4.Name = "Label4";
			_label4.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label4.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label4.Tag = "";
			_label4.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_label4.Width = System.Web.UI.WebControls.Unit.Pixel(123);
			return _label4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateStartDateTimeEdit() {
			_startDateTimeEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_startDateTimeEdit.UId = new Guid("269cf586-0316-4988-982c-6cde76ef7f16");
			_startDateTimeEdit.Name = "StartDateTimeEdit";
			_startDateTimeEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_startDateTimeEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_startDateTimeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_startDateTimeEdit.Tag = "";
			_startDateTimeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_startDateTimeEdit.Width = System.Web.UI.WebControls.Unit.Pixel(165);
			_startDateTimeEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_startDateTimeEdit.DataSource = "DataSource";
			_startDateTimeEdit.ColumnUId = new Guid("1d46e881-8517-42f6-b23d-dfc0f1d13a25");
			return _startDateTimeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout13() {
			_controlLayout13 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout13.UId = new Guid("13786170-8f4f-4d99-9fb7-4b0bb7f8c784");
			_controlLayout13.Name = "ControlLayout13";
			_controlLayout13.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout13.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout13.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout13.Tag = "";
			_controlLayout13.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout13.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout13.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout13.FitHeightByContent = true;
			_controlLayout13.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout13.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout13.StartNewAlignGroup = false;
			_controlLayout13.Image = new ControlImage {};
			_controlLayout13.Edges = "";
			return _controlLayout13;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel5() {
			_label5 = new Terrasoft.UI.WebControls.Controls.Label();
			_label5.UId = new Guid("06183f17-0e1b-4ff7-ad27-4709c4ea93f3");
			_label5.Name = "Label5";
			_label5.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label5.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_label5.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label5.Tag = "";
			_label5.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_label5.Width = System.Web.UI.WebControls.Unit.Pixel(100);
			return _label5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateNeverEndRadioButton() {
			_neverEndRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_neverEndRadioButton.UId = new Guid("a930b3a5-7835-4001-9dd9-834435cf351e");
			_neverEndRadioButton.Name = "NeverEndRadioButton";
			_neverEndRadioButton.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_neverEndRadioButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_neverEndRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_neverEndRadioButton.Tag = "";
			_neverEndRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_neverEndRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_neverEndRadioButton.Margins = "0 0 0 22";
			_neverEndRadioButton.DataSource = "DataSource";
			_neverEndRadioButton.ColumnUId = new Guid("2dffad48-e119-4829-96b2-b0f84fde7119");
			_neverEndRadioButton.GroupName = "EndGroup";
			return _neverEndRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout14() {
			_controlLayout14 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout14.UId = new Guid("a305f48f-fb83-4418-a214-7c1d63e0eb79");
			_controlLayout14.Name = "ControlLayout14";
			_controlLayout14.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout14.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout14.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout14.Tag = "";
			_controlLayout14.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout14.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout14.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout14.FitHeightByContent = true;
			_controlLayout14.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout14.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout14.StartNewAlignGroup = false;
			_controlLayout14.Image = new ControlImage {};
			_controlLayout14.Edges = "";
			return _controlLayout14;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer3() {
			_spacer3 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer3.UId = new Guid("9ec7d9da-b1c4-4ed6-9068-cd6a8eb7f753");
			_spacer3.Name = "Spacer3";
			_spacer3.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_spacer3.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_spacer3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer3.Tag = "";
			_spacer3.Size = System.Web.UI.WebControls.Unit.Pixel(100);
			return _spacer3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateCustomEndRadioButton() {
			_customEndRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_customEndRadioButton.UId = new Guid("769c7a5f-edde-4b90-a0e1-dc48e5600fc6");
			_customEndRadioButton.Name = "CustomEndRadioButton";
			_customEndRadioButton.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customEndRadioButton.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_customEndRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_customEndRadioButton.Tag = "";
			_customEndRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_customEndRadioButton.Width = System.Web.UI.WebControls.Unit.Pixel(13);
			_customEndRadioButton.Margins = "0 0 0 22";
			_customEndRadioButton.GroupName = "EndGroup";
			return _customEndRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateEndDateTimeEdit() {
			_endDateTimeEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_endDateTimeEdit.UId = new Guid("2e03a278-0bf4-4ea0-99d6-e33a9ab67a6c");
			_endDateTimeEdit.Name = "EndDateTimeEdit";
			_endDateTimeEdit.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_endDateTimeEdit.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_endDateTimeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_endDateTimeEdit.Tag = "";
			_endDateTimeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_endDateTimeEdit.Width = System.Web.UI.WebControls.Unit.Pixel(165);
			_endDateTimeEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_endDateTimeEdit.Margins = "0 0 0 7";
			_endDateTimeEdit.DataSource = "DataSource";
			_endDateTimeEdit.ColumnUId = new Guid("d760ee09-6cae-4998-9bf6-b2fd5450f77f");
			return _endDateTimeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout12() {
			_controlLayout12 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout12.UId = new Guid("b391c562-40e1-405d-92c8-9234d74edc13");
			_controlLayout12.Name = "ControlLayout12";
			_controlLayout12.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout12.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			_controlLayout12.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout12.Tag = "";
			_controlLayout12.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout12.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout12.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout12.FitHeightByContent = true;
			_controlLayout12.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout12.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout12.StartNewAlignGroup = false;
			_controlLayout12.Image = new ControlImage {};
			_controlLayout12.Edges = "";
			return _controlLayout12;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8");
			DataSource.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("e8c11ebf-5863-4177-9576-f1fbf83534a0");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("d81cdc4f-9fc6-43eb-b5de-e99a961964be");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("f02d3e7d-9c20-44a0-b306-cb1f4d1cfd6d");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e923f9ce-cfad-4ca8-864e-528fea890100");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("8e3a3b76-1b75-471b-8b18-81861eec470e");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("4001bfd4-52de-49f9-b29c-c80335d0ad86");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("47d763a9-8466-4603-9d1d-8b002ce224e7");
			if (column != null) {
				column.UId = new Guid("5b861d93-b656-453e-8954-36b714539541");
				column.Name = @"IsDaily";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4519971c-ef6a-4093-9ac2-815cba012376");
			if (column != null) {
				column.UId = new Guid("c337c179-8610-48d0-bcaf-e53d2eedf0d6");
				column.Name = @"DailyPeriod";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("12380ad3-9811-408f-a2ae-41d8824aff28");
			if (column != null) {
				column.UId = new Guid("11e6ccb3-bc67-4bb8-80e2-e015961dc3c8");
				column.Name = @"IsWeekly";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3c403256-b627-45e2-ae0c-a2b8287fc9fe");
			if (column != null) {
				column.UId = new Guid("22713013-494f-479a-840e-4d38a89c690a");
				column.Name = @"DayOfWeek";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c4c846c0-4f99-4c7b-96f2-96d0c2cebeb1");
			if (column != null) {
				column.UId = new Guid("8ef96bef-7c81-442e-80c4-7d55f11638a3");
				column.Name = @"IsMonthly";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("52b22af7-46c5-483b-9a75-03b93d4ec7a7");
			if (column != null) {
				column.UId = new Guid("040293ee-0733-4905-9f4a-09233d123a5c");
				column.Name = @"IsMonthlyCustom";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7fd3d658-9f16-4d63-816a-a7b825256605");
			if (column != null) {
				column.UId = new Guid("e94ab0c9-6a52-44e3-a60a-8259b79fafe1");
				column.Name = @"DayOfMonth";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e2d8c2fb-a4c7-4b5c-8d9f-bfc3ab4128d6");
			if (column != null) {
				column.UId = new Guid("aa6b61ed-0e44-4415-917f-cd1ed7fe9793");
				column.Name = @"IsMonthlyLastDay";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("69cbd451-c173-48d2-9a7f-b0e67bbd0269");
			if (column != null) {
				column.UId = new Guid("57c67041-c61c-48c9-aeea-86bea1044574");
				column.Name = @"IsOnce";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7817b396-8b15-4bb4-9248-7264b7a54ffa");
			if (column != null) {
				column.UId = new Guid("609e406b-2cb1-4378-b01a-e5b135473e3e");
				column.Name = @"OnceAt";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("71cd487f-f25f-4202-9965-4beb10ee76a4");
			if (column != null) {
				column.UId = new Guid("62fea540-4e04-4769-9d94-b0990fe21b42");
				column.Name = @"IsCustom";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("87be6e44-0210-469f-86d1-1e1d19414706");
			if (column != null) {
				column.UId = new Guid("6db774e0-9b07-4a79-aae5-0e7d8f6fb29d");
				column.Name = @"CustomPeriod";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5523cb12-f07f-4c73-b366-900c6860b9ab");
			if (column != null) {
				column.UId = new Guid("b4656409-124e-49a1-8ae8-1235c04cca1f");
				column.Name = @"CustomPeriodType";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("09b2ad89-826f-4806-869f-d4454507cb45");
			if (column != null) {
				column.UId = new Guid("20edff30-77e7-4d37-9ff3-c316956fb138");
				column.Name = @"CustomFrom";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2b6dfefc-6012-4039-896c-f0b539b78d4e");
			if (column != null) {
				column.UId = new Guid("a18b3c17-7957-495b-8206-5647d9bd94f3");
				column.Name = @"CustomTill";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ef6ae8b8-d210-4da8-8025-a47a9204f8a7");
			if (column != null) {
				column.UId = new Guid("1d46e881-8517-42f6-b23d-dfc0f1d13a25");
				column.Name = @"SchedulerStart";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("89965a50-cf91-4b73-8ea6-41814f699f55");
			if (column != null) {
				column.UId = new Guid("d760ee09-6cae-4998-9bf6-b2fd5450f77f");
				column.Name = @"SchedulerFinish";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4cc31fdf-ec3c-43cb-b0f4-c2fe2b5d4928");
			if (column != null) {
				column.UId = new Guid("2dffad48-e119-4829-96b2-b0f84fde7119");
				column.Name = @"IsSchedulerEndless";
				column.CreatedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
				column.ModifiedInSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
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
			return new PeriodicitySettingsPageSchemaUserControl();
		}

		public override object Clone() {
			return new PeriodicitySettingsPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new PeriodicitySettingsPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: PeriodicitySettingsPageEventsProcess

	/// <exclude/>
	public class PeriodicitySettingsPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.PeriodicitySettingsPageSchemaUserControl
	{

		public PeriodicitySettingsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PeriodicitySettingsPageEventsProcess";
			SchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6");
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

		public virtual string SessionDataPeriodicitySettingsRecordUIdKey {
			get;
			set;
		}

		public virtual Object DaysOfWeekSchema {
			get;
			set;
		}

		public virtual Object HoursOrMinutesSchema {
			get;
			set;
		}

		public virtual Object HoursOrMinutesLocalizableStrings {
			get;
			set;
		}

		private ProcessFlowElement _pageLoadCompleteEventSubProcess;
		public ProcessFlowElement PageLoadCompleteEventSubProcess {
			get {
				return _pageLoadCompleteEventSubProcess ?? (_pageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("f9a82c6e-049e-44ec-b728-bcdc7f8086ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage;
		public ProcessFlowElement PageLoadCompleteStartMessage {
			get {
				return _pageLoadCompleteStartMessage ?? (_pageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("e05f6392-11c4-4f70-8823-93834c6998df"),
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
					SchemaElementUId = new Guid("373fa58d-fc70-46d6-9ba6-7478a18f9a5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("c8277af2-b202-40f0-a88f-4e12031102d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickEventSubProcess;
		public ProcessFlowElement OKButtonClickEventSubProcess {
			get {
				return _oKButtonClickEventSubProcess ?? (_oKButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OKButtonClickEventSubProcess",
					SchemaElementUId = new Guid("f5e608bd-583a-47ab-8399-090712b1df7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickStartMessage;
		public ProcessFlowElement OKButtonClickStartMessage {
			get {
				return _oKButtonClickStartMessage ?? (_oKButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClickStartMessage",
					SchemaElementUId = new Guid("d2ddac52-248d-43cb-8484-3c8a4a493c2e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _oKButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OKButtonClickIntermediateThrowMessageEvent {
			get {
				return _oKButtonClickIntermediateThrowMessageEvent ?? (_oKButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OKButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("39930303-95aa-4dcb-9e12-4f6b16420dcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _oKButtonClickScriptTask;
		public ProcessScriptTask OKButtonClickScriptTask {
			get {
				return _oKButtonClickScriptTask ?? (_oKButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OKButtonClickScriptTask",
					SchemaElementUId = new Guid("77c90109-4267-4646-965a-63582769abfa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OKButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _weeklyEditChangeEventSubProcess;
		public ProcessFlowElement WeeklyEditChangeEventSubProcess {
			get {
				return _weeklyEditChangeEventSubProcess ?? (_weeklyEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "WeeklyEditChangeEventSubProcess",
					SchemaElementUId = new Guid("eb49239a-e763-4712-88ee-a6303126efe8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _weeklyEditChangeStartMessage;
		public ProcessFlowElement WeeklyEditChangeStartMessage {
			get {
				return _weeklyEditChangeStartMessage ?? (_weeklyEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WeeklyEditChangeStartMessage",
					SchemaElementUId = new Guid("5eb5fdac-e223-4605-abd3-ec1d84d94762"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _weeklyEditChangeScriptTask;
		public ProcessScriptTask WeeklyEditChangeScriptTask {
			get {
				return _weeklyEditChangeScriptTask ?? (_weeklyEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "WeeklyEditChangeScriptTask",
					SchemaElementUId = new Guid("19447de0-2dd8-45d4-a231-eb2e82d95ea8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = WeeklyEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _customPeriodTypeEditChangeEventSubProcess;
		public ProcessFlowElement CustomPeriodTypeEditChangeEventSubProcess {
			get {
				return _customPeriodTypeEditChangeEventSubProcess ?? (_customPeriodTypeEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CustomPeriodTypeEditChangeEventSubProcess",
					SchemaElementUId = new Guid("3eb100a3-03c3-4892-b444-62f74a1856a6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _customPeriodTypeEditChangeStartMessage;
		public ProcessFlowElement CustomPeriodTypeEditChangeStartMessage {
			get {
				return _customPeriodTypeEditChangeStartMessage ?? (_customPeriodTypeEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CustomPeriodTypeEditChangeStartMessage",
					SchemaElementUId = new Guid("5f12d7e6-d64e-48b9-9d1f-2da5f94479ad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _customPeriodTypeEditChangeScriptTask;
		public ProcessScriptTask CustomPeriodTypeEditChangeScriptTask {
			get {
				return _customPeriodTypeEditChangeScriptTask ?? (_customPeriodTypeEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CustomPeriodTypeEditChangeScriptTask",
					SchemaElementUId = new Guid("87b1d7e7-fb99-471a-a37e-61ccae28a1ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CustomPeriodTypeEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _initEventSubProcess1;
		public ProcessFlowElement InitEventSubProcess1 {
			get {
				return _initEventSubProcess1 ?? (_initEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitEventSubProcess1",
					SchemaElementUId = new Guid("596fc033-eb04-4828-acd1-497235f4888e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initStartMessage1;
		public ProcessFlowElement InitStartMessage1 {
			get {
				return _initStartMessage1 ?? (_initStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitStartMessage1",
					SchemaElementUId = new Guid("9267f9d0-a15f-40cc-a119-ab4c9be92e7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _initIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent InitIntermediateThrowMessageEvent {
			get {
				return _initIntermediateThrowMessageEvent ?? (_initIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("f58c8340-0845-45c8-9406-fbba250cf4d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initScriptTask1;
		public ProcessScriptTask InitScriptTask1 {
			get {
				return _initScriptTask1 ?? (_initScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask1",
					SchemaElementUId = new Guid("88ba1edb-6f00-441a-acac-15a97a6df0c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTask1Execute,
				});
			}
		}

		private LocalizableString _valueIsEmpty;
		public LocalizableString ValueIsEmpty {
			get {
				return _valueIsEmpty ?? (_valueIsEmpty = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValueIsEmpty.Value"));
			}
		}

		private LocalizableString _fieldCaption;
		public LocalizableString FieldCaption {
			get {
				return _fieldCaption ?? (_fieldCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FieldCaption.Value"));
			}
		}

		private LocalizableString _incorrectValue;
		public LocalizableString IncorrectValue {
			get {
				return _incorrectValue ?? (_incorrectValue = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IncorrectValue.Value"));
			}
		}

		private LocalizableString _startTimeMoreThanEndTime;
		public LocalizableString StartTimeMoreThanEndTime {
			get {
				return _startTimeMoreThanEndTime ?? (_startTimeMoreThanEndTime = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.StartTimeMoreThanEndTime.Value"));
			}
		}

		private LocalizableString _startDateMoreThanEndDate;
		public LocalizableString StartDateMoreThanEndDate {
			get {
				return _startDateMoreThanEndDate ?? (_startDateMoreThanEndDate = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.StartDateMoreThanEndDate.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent };
			FlowElements[OKButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickEventSubProcess };
			FlowElements[OKButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickStartMessage };
			FlowElements[OKButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickIntermediateThrowMessageEvent };
			FlowElements[OKButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickScriptTask };
			FlowElements[WeeklyEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { WeeklyEditChangeEventSubProcess };
			FlowElements[WeeklyEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { WeeklyEditChangeStartMessage };
			FlowElements[WeeklyEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { WeeklyEditChangeScriptTask };
			FlowElements[CustomPeriodTypeEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CustomPeriodTypeEditChangeEventSubProcess };
			FlowElements[CustomPeriodTypeEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CustomPeriodTypeEditChangeStartMessage };
			FlowElements[CustomPeriodTypeEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CustomPeriodTypeEditChangeScriptTask };
			FlowElements[InitEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess1 };
			FlowElements[InitStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage1 };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
			FlowElements[InitScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PageLoadCompleteEventSubProcess":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "OKButtonClickEventSubProcess":
						break;
					case "OKButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OKButtonClickScriptTask");
						break;
					case "OKButtonClickIntermediateThrowMessageEvent":
						break;
					case "OKButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OKButtonClickIntermediateThrowMessageEvent");
						break;
					case "WeeklyEditChangeEventSubProcess":
						break;
					case "WeeklyEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("WeeklyEditChangeScriptTask");
						break;
					case "WeeklyEditChangeScriptTask":
						break;
					case "CustomPeriodTypeEditChangeEventSubProcess":
						break;
					case "CustomPeriodTypeEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("CustomPeriodTypeEditChangeScriptTask");
						break;
					case "CustomPeriodTypeEditChangeScriptTask":
						break;
					case "InitEventSubProcess1":
						break;
					case "InitStartMessage1":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("InitScriptTask1");
						break;
					case "InitScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("OKButtonClickStartMessage");
			ActivatedEventElements.Add("WeeklyEditChangeStartMessage");
			ActivatedEventElements.Add("CustomPeriodTypeEditChangeStartMessage");
			ActivatedEventElements.Add("InitStartMessage1");
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
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "OKButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickStartMessage";
					result = OKButtonClickStartMessage.Execute(context);
					break;
				case "OKButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = OKButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "OKButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickScriptTask";
					result = OKButtonClickScriptTask.Execute(context, OKButtonClickScriptTaskExecute);
					break;
				case "WeeklyEditChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "WeeklyEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "WeeklyEditChangeStartMessage";
					result = WeeklyEditChangeStartMessage.Execute(context);
					break;
				case "WeeklyEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "WeeklyEditChangeScriptTask";
					result = WeeklyEditChangeScriptTask.Execute(context, WeeklyEditChangeScriptTaskExecute);
					break;
				case "CustomPeriodTypeEditChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CustomPeriodTypeEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CustomPeriodTypeEditChangeStartMessage";
					result = CustomPeriodTypeEditChangeStartMessage.Execute(context);
					break;
				case "CustomPeriodTypeEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CustomPeriodTypeEditChangeScriptTask";
					result = CustomPeriodTypeEditChangeScriptTask.Execute(context, CustomPeriodTypeEditChangeScriptTaskExecute);
					break;
				case "InitEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage1";
					result = InitStartMessage1.Execute(context);
					break;
				case "InitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "InitScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask1";
					result = InitScriptTask1.Execute(context, InitScriptTask1Execute);
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
				case "HoursOrMinutesLocalizableStrings":
					HoursOrMinutesLocalizableStrings = reader.GetSerializableObjectValue();
				break;
				case "HoursOrMinutesSchema":
					HoursOrMinutesSchema = reader.GetSerializableObjectValue();
				break;
				case "DaysOfWeekSchema":
					DaysOfWeekSchema = reader.GetSerializableObjectValue();
				break;
				case "SessionDataPeriodicitySettingsRecordUIdKey":
					SessionDataPeriodicitySettingsRecordUIdKey = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			AddEnableDisableControlsScript();
			FillAndInitializeValueListComboboxes();
			HideCalcInEditors();
			SetComboboxesReadonly();
			
			bool isSchedulerEndless = Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("IsSchedulerEndless");
			if (!isSchedulerEndless) {
				Page.CustomEndRadioButton.Checked = true;
			}
			
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
						LinkId = Page.OnceEdit.ClientID,
						Caption = FieldCaption.Value
					});
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
						LinkId = Page.StartDateTimeEdit.ClientID,
						Caption = FieldCaption.Value
					});		
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
						LinkId = Page.CustomFromEdit.ClientID,
						Caption = FieldCaption.Value
					});		
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
						LinkId = Page.CustomTillEdit.ClientID,
						Caption = FieldCaption.Value
					});		
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
						LinkId = Page.EndDateTimeEdit.ClientID,
						Caption = FieldCaption.Value
					});
			Page.BaseMessagePanel.Links.Add(new LinkConfig {
						LinkId = Page.CustomPeriodEdit.ClientID,
						Caption = FieldCaption.Value
					});
			
			Page.AddScript(Page.BaseMessagePanel.ClientID + ".on('linkclick', function(e, linkId){"
					+ "var cmp = Ext.getCmp(linkId);"
					+ "if (cmp && cmp.focus) {"
					+ "cmp.focus();}}, this)");
			
			return true;
		}

		public virtual bool OKButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			//---!! BREAK (Artem Shevchenko) !!---	
				if((UserConnection.CurrentUser.ContactId == new System.Guid("42008077-169C-4EA1-BA7B-DBF272E6FCE7")) 
					&& System.Diagnostics.Debugger.IsAttached)
				{System.Diagnostics.Debugger.Break();}
			//------------------------------------
			
			var onceEdit = Page.OnceEdit;
			var startDateTimeEdit = Page.StartDateTimeEdit;
			
			var customFromEdit = Page.CustomFromEdit;
			var customTillEdit = Page.CustomTillEdit;
			var endDateTimeEdit = Page.EndDateTimeEdit;
			var customPeriodEdit = Page.CustomPeriodEdit;
			
			var baseMessagePanel = Page.BaseMessagePanel;
			
			bool isDataCorrect = true;
			baseMessagePanel.Clear();
			if (Page.OnceRadioButton.Checked && onceEdit.IsNull) {
				var clientId = onceEdit.ClientID;
				var messagePanelMessage = string.Format(ValueIsEmpty.Value, "{" + clientId + "}");
				baseMessagePanel.AddMessage(clientId, Warning, messagePanelMessage, MessageType.Warning);														
				isDataCorrect = false;
			}
			if (startDateTimeEdit.IsNull) {
				var clientId = startDateTimeEdit.ClientID;
				var messagePanelMessage = string.Format(ValueIsEmpty.Value, "{" + clientId + "}");
				baseMessagePanel.AddMessage(clientId, Warning, messagePanelMessage, MessageType.Warning);														
				isDataCorrect = false;
			}
			if (Page.CustomRadioButton.Checked) {
				if (customFromEdit.IsNull) {
					var clientId = customFromEdit.ClientID;
					var messagePanelMessage = string.Format(ValueIsEmpty.Value, "{" + clientId + "}");
					baseMessagePanel.AddMessage(clientId, Warning, messagePanelMessage, MessageType.Warning);														
					isDataCorrect = false;
				}
				if (customTillEdit.IsNull) {
					var clientId = customTillEdit.ClientID;
					var messagePanelMessage = string.Format(ValueIsEmpty.Value, "{" + clientId + "}");
					baseMessagePanel.AddMessage(clientId, Warning, messagePanelMessage, MessageType.Warning);														
					isDataCorrect = false;
				}
				if ((decimal)(customPeriodEdit.Value) < 1) {
					var clientId = customPeriodEdit.ClientID;
					var messagePanelMessage = string.Format(IncorrectValue.Value, "{" + clientId + "}");
					baseMessagePanel.AddMessage(clientId, Warning, messagePanelMessage, MessageType.Warning);														
					isDataCorrect = false;
				}
				if ((DateTime)Page.CustomFromEdit.Value > (DateTime)Page.CustomTillEdit.Value) {
					baseMessagePanel.AddMessage(Warning, StartTimeMoreThanEndTime.Value, MessageType.Warning);														
					isDataCorrect = false;
				}
			}
			if (Page.CustomEndRadioButton.Checked) {
				if (endDateTimeEdit.IsNull) {
					var clientId = endDateTimeEdit.ClientID;
					var messagePanelMessage = string.Format(ValueIsEmpty.Value, "{" + clientId + "}");
					baseMessagePanel.AddMessage(clientId, Warning, messagePanelMessage, MessageType.Warning);														
					isDataCorrect = false;
				}
				if ((DateTime)Page.StartDateTimeEdit.Value > (DateTime)Page.EndDateTimeEdit.Value) {
					baseMessagePanel.AddMessage(Warning, StartDateMoreThanEndDate.Value, MessageType.Warning);														
					isDataCorrect = false;
				}
			}
			
			if (!isDataCorrect) {
				return false;
			}
				
			UserConnection.SessionData[SessionDataPeriodicitySettingsRecordUIdKey] = Page.DataSource.ActiveRowPrimaryColumnValue;
			
			return true;
		}

		public virtual bool WeeklyEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var selectedValueUId  = (Guid)Page.WeeklyEdit.Value;
			var configurationTools = new ConfigurationTools(UserConnection);
			object dayOfWeekValueObj = configurationTools.GetValueListEnumValueBySchemaItemUId(
					DaysOfWeekSchema as ValueListSchema, 
					selectedValueUId,
					typeof(DaysOfWeek)
				);	
			if (dayOfWeekValueObj != null) {
				var dataSource = Page.DataSource;
				var schema = dataSource.Schema;
				var activeRow = dataSource.ActiveRow;
				activeRow.SetColumnValue(schema.Columns.GetByName("DayOfWeek").ColumnValueName, 
					(int)dayOfWeekValueObj);
			} else {
				// Что-то не так... (здесь лучше Break вместо Exception):
				if (System.Diagnostics.Debugger.IsAttached) { 
					System.Diagnostics.Debugger.Break();
				}
			}
			return true;
		}

		public virtual bool CustomPeriodTypeEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var hoursOrMinutesValue = (Guid)Page.CustomPeriodTypeEdit.Value;	
			if (hoursOrMinutesValue != Guid.Empty) {
				var dataSource = Page.DataSource;
				var schema = dataSource.Schema;
				var activeRow = dataSource.ActiveRow;
				var hoursOrminutes = new TSConfiguration.HoursOrMinutesClass(UserConnection);
				int index = -1;
				foreach(var kvp in hoursOrminutes.GetHoursOrMinutes()) {
					index++;
					if (kvp.Key == hoursOrMinutesValue) {
						activeRow.SetColumnValue(schema.Columns.GetByName("CustomPeriodType").ColumnValueName, index);
						break;
					}
				}
			} else {
				// Что-то не так... (здесь лучше Break вместо Exception):
				if (System.Diagnostics.Debugger.IsAttached) { 
					System.Diagnostics.Debugger.Break();
				}
			}
			return true;
		}

		public virtual bool InitScriptTask1Execute(ProcessExecutingContext context) {
			// На странице специально для beta-версии был скрыт контейнер елементов "Частота повторения", 
			// в нем все controls были отвязаны от DS и от групп для предотвращения клиентских свалов.
			// Контейнер "Повторение в рамках одного дня" переименлван в "Частота повтореиня", 
			// а поле "Один раз в указанное время" на "Один раз в день"
			
			InitializeParameters();
			return true;
		}

		public override void MakeCaption() {
			if(IsCaptionExists) {
				return;
			}
			var caption = Page.DataSource.Schema.Caption;
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = caption;
		}

		public override bool GetIsDesignerModeButtonHidden() {
			return true;
		}

		public virtual void AddEnableDisableControlsScript() {
			#region DefineVars
				var dailyRbId = Page.DailyRadioButton.ClientID;
				var weeklyRbId = Page.WeeklyRadioButton.ClientID;
				var monthlyRbId = Page.MonthlyRadioButton.ClientID;
				var monthlyCustomRbId = Page.MonthlyCustomRadioButton.ClientID;
				var monthlyLastDayRbId = Page.MonthlyLastDayRadioButton.ClientID;
				var onceRbId = Page.OnceRadioButton.ClientID;
				var customRbId = Page.CustomRadioButton.ClientID;
				var dailyEditId = Page.DailyEdit.ClientID;
				var weeklyEditId = Page.WeeklyEdit.ClientID;
				var monthlyCustomEditId = Page.MonthlyCustomEdit.ClientID;
				var onceEditId = Page.OnceEdit.ClientID;
				var customPeriodEditId = Page.CustomPeriodEdit.ClientID;
				var customPeriodTypeEditId = Page.CustomPeriodTypeEdit.ClientID;
				var customFromEditId = Page.CustomFromEdit.ClientID;
				var customTillEditId = Page.CustomTillEdit.ClientID;
				var neverEndRbId = Page.NeverEndRadioButton.ClientID;
				var customEndRbId = Page.CustomEndRadioButton.ClientID;
				var startDateTimeEditId = Page.StartDateTimeEdit.ClientID;
				var endDateTimeEditId = Page.EndDateTimeEdit.ClientID;		
			#endregion
			
			var allRadioButtonIds = new List<string>() {
				// Temporary commented for beta-version: // dailyRbId,
				// Temporary commented for beta-version: // weeklyRbId,
				// Temporary commented for beta-version: // monthlyRbId,
				// Temporary commented for beta-version: // monthlyCustomRbId,
				// Temporary commented for beta-version: // monthlyLastDayRbId,
				onceRbId,
				customRbId,
				neverEndRbId,
				customEndRbId
			};
			
			var sb = new System.Text.StringBuilder();
			
			sb.AppendLine("function onRadioButtonCheck() {");
			
				// Temporary commented for beta-version: // sb.AppendLine(dailyEditId + ".setEnabled(" + dailyRbId +".checked);");
				// Temporary commented for beta-version: // sb.AppendLine(weeklyEditId + ".setEnabled(" + weeklyRbId + ".checked);");
			
				// Temporary commented for beta-version: // sb.AppendLine(monthlyCustomRbId + ".setEnabled(" + monthlyRbId + ".checked);");
				// Temporary commented for beta-version: // sb.AppendLine(monthlyLastDayRbId + ".setEnabled(" + monthlyRbId + ".checked);");
				// Temporary commented for beta-version: // sb.AppendLine(monthlyCustomEditId + ".setEnabled(" + monthlyCustomRbId + ".checked && " + monthlyCustomRbId + ".enabled);");
			
				sb.AppendLine(onceEditId + ".setEnabled(" + onceRbId + ".checked);");
			
				sb.AppendLine(customPeriodEditId + ".setEnabled(" + customRbId + ".checked);");
				sb.AppendLine(customPeriodTypeEditId + ".setEnabled(" + customRbId + ".checked);");
				sb.AppendLine(customFromEditId + ".setEnabled(" + customRbId + ".checked);");
				sb.AppendLine(customTillEditId + ".setEnabled(" + customRbId + ".checked);");
			
				sb.AppendLine(endDateTimeEditId + ".setEnabled(" + customEndRbId + ".checked);");
			
			sb.AppendLine("}");
			
			foreach (var rbId in allRadioButtonIds) {
				sb.AppendLine(rbId + ".on('check', onRadioButtonCheck, this);");
			}
			
			sb.AppendLine("onRadioButtonCheck();");
			var script = sb.ToString();
			Page.AddScript(script);
		}

		public virtual void HideCalcInEditors() {
			// Temporary commented for beta-version: // Page.DailyEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			// Temporary commented for beta-version: // Page.MonthlyCustomEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			Page.CustomPeriodEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
		}

		public virtual void InitializeParameters() {
			string queryString = Page.Request.QueryString.ToString();
			if (queryString.Contains("sessionDataPeriodicitySettingsRecordUIdKey")) {
				SessionDataPeriodicitySettingsRecordUIdKey = Page.Request.QueryString["sessionDataPeriodicitySettingsRecordUIdKey"].ToString();
			} else {
				SessionDataPeriodicitySettingsRecordUIdKey = "PeriodicitySettingsRecordUId";
			}
			
			if (DaysOfWeekSchema == null) {
				var daysOfWeekSchema = UserConnection.ValueListSchemaManager.GetInstanceByName("DaysOfWeek");
				daysOfWeekSchema.InitializeLocalizableValues();
				DaysOfWeekSchema = daysOfWeekSchema;
			}
			if (HoursOrMinutesSchema == null) {
				var hoursOrMinutesSchema = UserConnection.ValueListSchemaManager.GetInstanceByName("HoursOrMinutes");
				hoursOrMinutesSchema.InitializeLocalizableValues();
				HoursOrMinutesSchema = hoursOrMinutesSchema;
			}
		}

		public virtual void SetComboboxesReadonly() {
			var comboboxIds = new List<string>() {
			// Temporary commented for beta-version: // 	Page.WeeklyEdit.ClientID,
				Page.CustomPeriodTypeEdit.ClientID
			};
			
			var dateTimeIds = new List<string>() {
				Page.OnceEdit.ClientID,
				Page.CustomFromEdit.ClientID,
				Page.CustomTillEdit.ClientID,
				Page.StartDateTimeEdit.ClientID,
				Page.EndDateTimeEdit.ClientID
			};
			
			var sb = new System.Text.StringBuilder();
			foreach (var clientId in comboboxIds) {
				sb.AppendLine(clientId + ".setReadOnly(true); " + clientId + ".allowEmpty = false;");	
			}
			foreach (var clientId in dateTimeIds) {
				sb.AppendLine(clientId + ".allowEmpty = false;");	
			}
			var script = sb.ToString();
			
			Page.AddScript(script);
		}

		public virtual void FillAndInitializeValueListComboboxes() {
			var schema = Page.DataSource.Schema;
			var activeRow = Page.DataSource.ActiveRow;
			
			// Temporary commented for beta-version: // var daysOfWeekSchema = (ValueListSchema)DaysOfWeekSchema;
			var hoursOrMinutesSchema = (ValueListSchema)HoursOrMinutesSchema;
			
			var hoursOrminutes = new TSConfiguration.HoursOrMinutesClass(UserConnection);
			foreach(var kvp in hoursOrminutes.GetHoursOrMinutes()) {
				var comboBoxEditItem = new Terrasoft.UI.WebControls.Controls.ListItem(
							kvp.Value, kvp.Key.ToString());
				Page.CustomPeriodTypeEdit.Items.Add(comboBoxEditItem);
			}
			
			// Temporary commented for beta-version: // var dayOfWeekValue = activeRow.GetColumnValue(
			// Temporary commented for beta-version: // 	schema.Columns.GetByName("DayOfWeek").ColumnValueName
			// Temporary commented for beta-version: // );
			var customPeriodTypeValue = activeRow.GetColumnValue(
				schema.Columns.GetByName("CustomPeriodType").ColumnValueName
			);
			// Temporary commented for beta-version: // weeklyEdit.SelectedItem.Value = weeklyEdit.Items[(int)dayOfWeekValue].Value;
			Page.CustomPeriodTypeEdit.SelectedItem.Value = Page.CustomPeriodTypeEdit.Items[(int)customPeriodTypeValue].Value;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OKButtonClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "WeeklyEditChange":
							if (ActivatedEventElements.Contains("WeeklyEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("WeeklyEditChangeStartMessage");
						}
						break;
					case "CustomPeriodTypeEditChange":
							if (ActivatedEventElements.Contains("CustomPeriodTypeEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("CustomPeriodTypeEditChangeStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage1")) {
							context.QueueTasks.Enqueue("InitStartMessage1");
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
			if (HoursOrMinutesLocalizableStrings != null) {
				if (HoursOrMinutesLocalizableStrings.GetType().IsSerializable ||
					HoursOrMinutesLocalizableStrings.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("HoursOrMinutesLocalizableStrings", HoursOrMinutesLocalizableStrings, null);
				}
			}
			if (HoursOrMinutesSchema != null) {
				if (HoursOrMinutesSchema.GetType().IsSerializable ||
					HoursOrMinutesSchema.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("HoursOrMinutesSchema", HoursOrMinutesSchema, null);
				}
			}
			if (DaysOfWeekSchema != null) {
				if (DaysOfWeekSchema.GetType().IsSerializable ||
					DaysOfWeekSchema.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DaysOfWeekSchema", DaysOfWeekSchema, null);
				}
			}
			if (!HasMapping("SessionDataPeriodicitySettingsRecordUIdKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SessionDataPeriodicitySettingsRecordUIdKey", SessionDataPeriodicitySettingsRecordUIdKey, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: PeriodicitySettingsPageEventsProcess

	/// <exclude/>
	public class PeriodicitySettingsPageEventsProcess : PeriodicitySettingsPageEventsProcess<Terrasoft.WebApp.PeriodicitySettingsPageSchemaUserControl>
	{

		public PeriodicitySettingsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PeriodicitySettingsPageSchemaUserControl

	/// <exclude/>
	public partial class PeriodicitySettingsPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton DailyRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("DailyRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit DailyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("DailyEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton WeeklyRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("WeeklyRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit WeeklyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("WeeklyEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton MonthlyRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("MonthlyRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout7", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout10 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout10", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton MonthlyCustomRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("MonthlyCustomRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit MonthlyCustomEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("MonthlyCustomEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout6", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout11 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout11", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton MonthlyLastDayRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("MonthlyLastDayRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout8 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout8", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton OnceRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("OnceRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit OnceEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("OnceEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout9", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton CustomRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("CustomRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit CustomPeriodEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("CustomPeriodEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CustomPeriodTypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("CustomPeriodTypeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CustomFromEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CustomFromEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CustomTillEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CustomTillEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout13 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout13", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit StartDateTimeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("StartDateTimeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout14 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout14", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton NeverEndRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("NeverEndRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout12 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout12", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton CustomEndRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("CustomEndRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit EndDateTimeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("EndDateTimeEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DailyRadioButton.AjaxEvents.Check.Event += DailyRadioButtonCheck;
			WeeklyRadioButton.AjaxEvents.Check.Event += WeeklyRadioButtonCheck;
			WeeklyEdit.AjaxEvents.Change.Event += WeeklyEditChange;
			MonthlyRadioButton.AjaxEvents.Check.Event += MonthlyRadioButtonCheck;
			MonthlyCustomRadioButton.AjaxEvents.Check.Event += MonthlyCustomRadioButtonCheck;
			MonthlyLastDayRadioButton.AjaxEvents.Check.Event += MonthlyLastDayRadioButtonCheck;
			OnceRadioButton.AjaxEvents.Check.Event += OnceRadioButtonCheck;
			CustomRadioButton.AjaxEvents.Check.Event += CustomRadioButtonCheck;
			CustomPeriodTypeEdit.AjaxEvents.Change.Event += CustomPeriodTypeEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DailyRadioButton.AjaxEvents.Check.Event -= DailyRadioButtonCheck;
			WeeklyRadioButton.AjaxEvents.Check.Event -= WeeklyRadioButtonCheck;
			WeeklyEdit.AjaxEvents.Change.Event -= WeeklyEditChange;
			MonthlyRadioButton.AjaxEvents.Check.Event -= MonthlyRadioButtonCheck;
			MonthlyCustomRadioButton.AjaxEvents.Check.Event -= MonthlyCustomRadioButtonCheck;
			MonthlyLastDayRadioButton.AjaxEvents.Check.Event -= MonthlyLastDayRadioButtonCheck;
			OnceRadioButton.AjaxEvents.Check.Event -= OnceRadioButtonCheck;
			CustomRadioButton.AjaxEvents.Check.Event -= CustomRadioButtonCheck;
			CustomPeriodTypeEdit.AjaxEvents.Change.Event -= CustomPeriodTypeEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (PeriodicitySettingsPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new PeriodicitySettingsPageEventsProcess(UserConnection);
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

		public virtual void DailyRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("DailyRadioButtonCheck");
		}

		public virtual void WeeklyRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("WeeklyRadioButtonCheck");
		}

		public virtual void WeeklyEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("WeeklyEditChange");
		}

		public virtual void MonthlyRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("MonthlyRadioButtonCheck");
		}

		public virtual void MonthlyCustomRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("MonthlyCustomRadioButtonCheck");
		}

		public virtual void MonthlyLastDayRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("MonthlyLastDayRadioButtonCheck");
		}

		public virtual void OnceRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("OnceRadioButtonCheck");
		}

		public virtual void CustomRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("CustomRadioButtonCheck");
		}

		public virtual void CustomPeriodTypeEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("CustomPeriodTypeEditChange");
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
			SchemaName = "PeriodicitySettingsPage";
		}

		#endregion

	}

	#endregion

	#region Class: PeriodicitySettingsPageEventsProcessSchema

	/// <exclude/>
	public class PeriodicitySettingsPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public PeriodicitySettingsPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PeriodicitySettingsPageEventsProcessSchema(PeriodicitySettingsPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PeriodicitySettingsPageEventsProcess";
			UId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48");
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

		protected virtual ProcessSchemaParameter CreateSessionDataPeriodicitySettingsRecordUIdKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("337425f1-1f04-44ff-bee5-790013a87d43"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"SessionDataPeriodicitySettingsRecordUIdKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDaysOfWeekSchemaParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("da3645ff-26a8-497f-8b81-504659b1296e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"DaysOfWeekSchema",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHoursOrMinutesSchemaParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("47d633b5-1472-4a8b-8c2b-94269da29a6a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"HoursOrMinutesSchema",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHoursOrMinutesLocalizableStringsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("052a6185-106c-4002-845a-103d6a435d5e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"HoursOrMinutesLocalizableStrings",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSessionDataPeriodicitySettingsRecordUIdKeyParameter());
			Parameters.Add(CreateDaysOfWeekSchemaParameter());
			Parameters.Add(CreateHoursOrMinutesSchemaParameter());
			Parameters.Add(CreateHoursOrMinutesLocalizableStringsParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaPeriodicitySettingPageEventsProcessLaneSet = CreatePeriodicitySettingPageEventsProcessLaneSetLaneSet();
			LaneSets.Add(schemaPeriodicitySettingPageEventsProcessLaneSet);
			ProcessSchemaLane schemaPageEventsLane = CreatePageEventsLaneLane();
			schemaPeriodicitySettingPageEventsProcessLaneSet.Lanes.Add(schemaPageEventsLane);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaPeriodicitySettingPageEventsProcessLaneSet.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaControlsChangeLane = CreateControlsChangeLaneLane();
			schemaPeriodicitySettingPageEventsProcessLaneSet.Lanes.Add(schemaControlsChangeLane);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess = CreatePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess);
			ProcessSchemaEventSubProcess okbuttonclickeventsubprocess = CreateOKButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess weeklyeditchangeeventsubprocess = CreateWeeklyEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(weeklyeditchangeeventsubprocess);
			ProcessSchemaEventSubProcess customperiodtypeeditchangeeventsubprocess = CreateCustomPeriodTypeEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(customperiodtypeeditchangeeventsubprocess);
			ProcessSchemaEventSubProcess initeventsubprocess1 = CreateInitEventSubProcess1EventSubProcess();
			FlowElements.Add(initeventsubprocess1);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent = CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOKButtonClickStartMessageStartMessageEvent();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclickintermediatethrowmessageevent = CreateOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclickintermediatethrowmessageevent);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOKButtonClickScriptTaskScriptTask();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaStartMessageEvent weeklyeditchangestartmessage = CreateWeeklyEditChangeStartMessageStartMessageEvent();
			weeklyeditchangeeventsubprocess.FlowElements.Add(weeklyeditchangestartmessage);
			ProcessSchemaScriptTask weeklyeditchangescripttask = CreateWeeklyEditChangeScriptTaskScriptTask();
			weeklyeditchangeeventsubprocess.FlowElements.Add(weeklyeditchangescripttask);
			ProcessSchemaStartMessageEvent customperiodtypeeditchangestartmessage = CreateCustomPeriodTypeEditChangeStartMessageStartMessageEvent();
			customperiodtypeeditchangeeventsubprocess.FlowElements.Add(customperiodtypeeditchangestartmessage);
			ProcessSchemaScriptTask customperiodtypeeditchangescripttask = CreateCustomPeriodTypeEditChangeScriptTaskScriptTask();
			customperiodtypeeditchangeeventsubprocess.FlowElements.Add(customperiodtypeeditchangescripttask);
			ProcessSchemaStartMessageEvent initstartmessage1 = CreateInitStartMessage1StartMessageEvent();
			initeventsubprocess1.FlowElements.Add(initstartmessage1);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			initeventsubprocess1.FlowElements.Add(initintermediatethrowmessageevent);
			ProcessSchemaScriptTask initscripttask1 = CreateInitScriptTask1ScriptTask();
			initeventsubprocess1.FlowElements.Add(initscripttask1);
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsEmptyLocalizableString());
			LocalizableStrings.Add(CreateFieldCaptionLocalizableString());
			LocalizableStrings.Add(CreateIncorrectValueLocalizableString());
			LocalizableStrings.Add(CreateStartTimeMoreThanEndTimeLocalizableString());
			LocalizableStrings.Add(CreateStartDateMoreThanEndDateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("13305288-39f7-44fd-b0e5-880998eabffa"),
				Name = "ValueIsEmpty",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFieldCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6bf93a84-4881-4515-892a-5becbb29d663"),
				Name = "FieldCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIncorrectValueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("75e92b73-7657-4db2-9a2f-830c26952f66"),
				Name = "IncorrectValue",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartTimeMoreThanEndTimeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("da75483a-1eb5-47b1-b08e-75a2e9149ae2"),
				Name = "StartTimeMoreThanEndTime",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartDateMoreThanEndDateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("821afd7e-9648-4aa0-888c-e0566b86dca6"),
				Name = "StartDateMoreThanEndDate",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("edb7d90b-6caa-4459-bd9c-a81ed7d06a2e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CurveCenterPosition = new Point(164, 590),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e05f6392-11c4-4f70-8823-93834c6998df"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c8277af2-b202-40f0-a88f-4e12031102d8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f8edb53a-2262-4422-873d-f318b8b0a3b3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CurveCenterPosition = new Point(164, 590),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c8277af2-b202-40f0-a88f-4e12031102d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("373fa58d-fc70-46d6-9ba6-7478a18f9a5a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("6853b1f4-46a1-4acb-8c2d-20ff0c892ace"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2ddac52-248d-43cb-8484-3c8a4a493c2e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77c90109-4267-4646-965a-63582769abfa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("9a30951b-e1dc-47e2-830e-005a0e5bf1b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CurveCenterPosition = new Point(324, 69),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77c90109-4267-4646-965a-63582769abfa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("39930303-95aa-4dcb-9e12-4f6b16420dcf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("ed798d85-1367-476f-9468-cf56e4d5a5c4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5eb5fdac-e223-4605-abd3-ec1d84d94762"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("19447de0-2dd8-45d4-a231-eb2e82d95ea8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("cccf00ba-33a7-4243-93d4-2306a1606ec6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f12d7e6-d64e-48b9-9d1f-2da5f94479ad"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87b1d7e7-fb99-471a-a37e-61ccae28a1ea"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("52ebcd6b-6702-4498-bdf6-ccd7594f3aa0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CurveCenterPosition = new Point(198, 630),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9267f9d0-a15f-40cc-a119-ab4c9be92e7a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f58c8340-0845-45c8-9406-fbba250cf4d8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("3789b755-373f-41bc-a4b3-f539edb1d4aa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CurveCenterPosition = new Point(326, 629),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f58c8340-0845-45c8-9406-fbba250cf4d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88ba1edb-6f00-441a-acac-15a97a6df0c4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreatePeriodicitySettingPageEventsProcessLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaPeriodicitySettingPageEventsProcessLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("73fda9f0-b67f-45ab-80f8-3ce0303a1adb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"PeriodicitySettingPageEventsProcessLaneSet",
				Position = new Point(5, 5),
				Size = new Size(873, 723),
				UseBackgroundMode = false
			};
			return schemaPeriodicitySettingPageEventsProcessLaneSet;
		}

		protected virtual ProcessSchemaLane CreatePageEventsLaneLane() {
			ProcessSchemaLane schemaPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("2a9221cf-9b66-485e-9cc4-21f2e70a7312"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("73fda9f0-b67f-45ab-80f8-3ce0303a1adb"),
				CreatedInOwnerSchemaUId = new Guid("25bdbbfd-e62b-4cc1-8f25-a149314164d6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"PageEventsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 386),
				Size = new Size(844, 337),
				UseBackgroundMode = false
			};
			return schemaPageEventsLane;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("35ee70b2-8891-4d60-855c-88fd05a85bc6"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("73fda9f0-b67f-45ab-80f8-3ce0303a1adb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"Lane1",
				Position = new Point(29, 202),
				Size = new Size(844, 179),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateControlsChangeLaneLane() {
			ProcessSchemaLane schemaControlsChangeLane = new ProcessSchemaLane(this) {
				UId = new Guid("1c5a3120-c5ff-40fc-850a-5c4d4c4f1930"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("73fda9f0-b67f-45ab-80f8-3ce0303a1adb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"ControlsChangeLane",
				Position = new Point(29, 0),
				Size = new Size(844, 197),
				UseBackgroundMode = false
			};
			return schemaControlsChangeLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f9a82c6e-049e-44ec-b728-bcdc7f8086ae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a9221cf-9b66-485e-9cc4-21f2e70a7312"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"PageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(386, 133),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e05f6392-11c4-4f70-8823-93834c6998df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9a82c6e-049e-44ec-b728-bcdc7f8086ae"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("373fa58d-fc70-46d6-9ba6-7478a18f9a5a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9a82c6e-049e-44ec-b728-bcdc7f8086ae"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,148,207,110,26,49,16,198,207,139,196,59,184,123,72,22,21,249,5,210,70,34,11,180,72,169,138,0,245,110,236,1,70,120,61,43,123,156,63,141,120,247,218,11,84,149,146,83,138,148,211,218,227,79,243,253,102,214,227,145,49,19,167,214,22,198,24,242,167,38,199,158,108,88,106,143,45,87,131,155,126,111,138,214,142,156,153,57,100,84,22,127,195,47,101,35,220,99,224,154,154,53,173,233,9,66,39,252,142,6,106,101,245,204,77,12,50,249,99,116,9,255,232,22,160,12,57,251,220,157,244,123,107,34,43,48,153,237,192,68,11,126,226,140,133,16,196,87,49,87,91,144,99,197,106,73,209,107,144,35,205,248,0,11,122,148,223,128,87,207,45,152,154,108,108,92,199,242,37,231,185,173,202,217,171,76,101,246,193,141,168,62,189,118,25,136,151,126,175,232,140,234,24,152,154,20,95,40,131,116,23,153,201,201,122,7,122,15,38,193,176,143,144,242,28,50,114,167,191,83,1,126,164,20,105,61,87,14,172,188,71,183,15,114,100,76,229,224,81,228,93,106,228,6,183,157,69,81,228,192,204,156,203,250,233,52,228,14,201,218,34,56,158,141,135,157,168,86,45,35,185,164,154,34,88,115,218,202,174,194,44,56,228,90,46,96,191,100,229,57,181,22,86,216,188,147,163,40,46,66,114,108,251,212,167,214,127,60,198,42,93,243,15,197,72,215,239,255,254,202,5,155,49,7,143,100,222,139,113,2,73,142,167,103,228,109,174,115,102,241,89,148,146,92,117,109,19,137,182,168,247,215,67,177,137,78,231,212,21,12,133,237,8,7,47,101,118,72,226,7,229,133,110,218,4,49,121,98,185,77,15,76,211,86,39,209,205,89,148,167,62,139,174,174,178,86,110,72,199,60,242,231,227,191,177,244,20,29,14,67,193,59,12,131,242,72,239,129,163,119,199,177,255,3,245,148,136,111,33,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c8277af2-b202-40f0-a88f-4e12031102d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9a82c6e-049e-44ec-b728-bcdc7f8086ae"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOKButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOKButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f5e608bd-583a-47ab-8399-090712b1df7c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35ee70b2-8891-4d60-855c-88fd05a85bc6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"OKButtonClickEventSubProcess",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(384, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOKButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d2ddac52-248d-43cb-8484-3c8a4a493c2e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5e608bd-583a-47ab-8399-090712b1df7c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"OKButtonClickStartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("39930303-95aa-4dcb-9e12-4f6b16420dcf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5e608bd-583a-47ab-8399-090712b1df7c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"OKButtonClickIntermediateThrowMessageEvent",
				Position = new Point(301, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOKButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("77c90109-4267-4646-965a-63582769abfa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5e608bd-583a-47ab-8399-090712b1df7c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"OKButtonClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,86,91,107,219,48,20,126,78,32,255,65,201,67,177,105,236,94,40,205,70,214,129,237,36,35,148,110,33,73,183,135,177,7,213,62,77,68,109,169,72,114,75,8,249,239,147,124,73,125,73,211,81,186,193,168,95,108,29,127,58,151,79,159,142,116,116,100,89,86,187,141,220,233,208,185,68,134,195,37,68,104,182,132,7,127,9,244,142,153,168,221,86,128,70,171,217,32,183,134,113,45,128,123,140,82,240,37,97,212,246,98,206,129,74,109,181,149,89,98,95,142,3,116,113,129,40,60,162,217,74,40,95,246,151,152,4,70,231,236,244,248,248,195,113,175,103,157,156,127,244,172,179,161,115,98,185,78,207,181,6,238,232,180,119,58,60,31,121,195,94,199,52,145,138,211,56,56,200,231,14,8,94,80,38,36,241,133,61,128,155,120,177,80,129,198,194,145,42,210,18,2,83,161,215,251,160,46,7,124,103,152,253,77,171,121,164,235,124,241,105,53,91,205,7,204,17,163,62,12,3,34,209,5,154,224,5,216,223,178,113,63,253,45,36,230,114,128,37,204,73,84,194,205,170,63,250,185,71,63,22,146,69,35,206,162,34,222,43,89,251,69,232,156,132,97,29,154,91,51,40,208,96,87,26,195,178,185,228,119,2,156,176,160,238,249,201,190,205,249,6,11,184,2,33,20,104,130,41,132,249,4,183,98,79,38,220,48,22,34,34,84,92,236,49,37,11,95,251,151,60,6,245,183,234,200,246,66,192,92,45,76,171,73,110,145,177,165,120,138,3,194,220,88,74,173,173,37,248,119,16,32,165,134,124,53,212,210,127,141,195,208,68,107,181,240,73,69,33,81,242,211,146,123,194,120,169,109,208,207,48,81,33,110,150,131,130,11,201,9,93,216,35,198,35,44,141,239,56,140,97,44,134,209,189,92,217,201,160,139,58,235,14,58,124,138,112,136,58,155,142,78,184,81,43,198,9,130,108,108,228,240,46,250,129,57,85,17,186,187,226,119,81,246,49,95,221,131,157,33,205,126,163,244,232,29,87,97,243,22,135,66,211,185,73,105,171,169,112,31,63,117,240,251,33,170,160,242,29,10,75,233,210,184,242,30,45,177,89,165,179,2,45,114,249,119,200,252,135,108,62,75,103,99,83,34,42,239,69,127,64,212,22,250,206,136,50,2,240,73,132,67,211,168,54,223,180,14,19,125,66,39,251,136,43,76,120,21,117,99,234,167,217,37,225,254,51,242,242,118,101,238,56,43,211,82,208,103,180,19,181,213,91,198,242,250,165,218,182,21,37,39,184,118,119,197,56,204,151,152,170,179,84,15,115,234,222,160,184,122,87,82,49,246,54,166,202,49,191,119,195,85,177,239,109,199,149,229,80,187,144,61,167,155,202,149,233,149,194,209,46,10,194,209,195,183,21,78,42,157,118,9,149,102,201,65,198,156,22,143,62,229,175,114,95,159,169,28,212,91,207,253,89,248,78,155,12,241,137,92,205,64,74,149,153,152,130,234,27,193,245,56,184,132,213,175,252,222,167,177,51,22,115,31,108,71,57,124,128,41,123,156,112,213,223,248,202,99,97,28,209,164,212,228,54,152,101,147,220,255,126,3,87,175,91,9,99,12,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateWeeklyEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaWeeklyEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eb49239a-e763-4712-88ee-a6303126efe8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c5a3120-c5ff-40fc-850a-5c4d4c4f1930"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"WeeklyEditChangeEventSubProcess",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaWeeklyEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWeeklyEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5eb5fdac-e223-4605-abd3-ec1d84d94762"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb49239a-e763-4712-88ee-a6303126efe8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"WeeklyEditChange",
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"WeeklyEditChangeStartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateWeeklyEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("19447de0-2dd8-45d4-a231-eb2e82d95ea8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb49239a-e763-4712-88ee-a6303126efe8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"WeeklyEditChangeScriptTask",
				Position = new Point(126, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,77,111,19,49,16,61,39,82,254,195,208,147,87,42,238,157,168,135,166,27,85,145,16,69,132,194,217,217,157,108,221,238,218,149,63,82,86,168,7,224,0,135,254,15,174,8,81,33,241,209,223,224,253,71,29,123,155,80,136,196,101,181,126,243,230,205,155,103,175,132,1,139,53,22,14,203,87,162,246,120,50,43,1,246,129,29,121,89,102,207,69,133,252,53,226,121,221,78,75,233,120,98,140,71,195,21,117,21,90,45,101,229,141,112,82,171,151,90,215,150,218,20,94,194,225,86,129,157,88,52,4,43,26,67,88,70,10,122,113,70,7,40,69,123,188,140,3,146,242,241,226,140,52,182,133,249,17,186,68,120,42,173,155,42,223,164,195,164,157,23,167,216,136,153,195,134,92,179,209,112,48,200,69,107,123,193,190,6,194,194,166,179,135,118,33,18,255,221,121,55,130,174,189,64,189,100,127,68,50,66,179,241,96,52,148,75,96,219,94,31,209,194,190,174,51,120,75,188,152,73,41,156,152,107,111,10,164,61,82,120,249,6,25,223,115,108,111,108,255,1,153,247,206,214,12,65,41,173,240,133,190,252,155,116,176,134,35,111,195,225,115,116,135,186,246,141,74,182,88,47,207,123,40,37,55,105,159,137,6,217,78,190,246,191,147,241,7,29,177,216,103,194,164,114,217,214,150,241,182,174,0,107,139,105,205,189,61,8,159,187,247,225,246,113,252,64,248,29,110,128,254,190,132,31,156,115,96,225,123,248,22,110,186,119,221,53,132,159,221,135,238,99,247,137,8,19,131,226,28,194,215,240,43,213,98,227,244,77,129,23,233,53,60,33,213,152,239,188,181,116,147,60,151,162,82,218,58,89,88,158,227,194,87,21,26,62,179,7,206,9,90,173,164,176,147,217,255,177,211,56,22,141,15,174,200,252,104,104,208,121,163,192,25,122,189,119,189,222,31,171,242,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCustomPeriodTypeEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCustomPeriodTypeEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3eb100a3-03c3-4892-b444-62f74a1856a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c5a3120-c5ff-40fc-850a-5c4d4c4f1930"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"CustomPeriodTypeEditChangeEventSubProcess",
				Position = new Point(288, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(234, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCustomPeriodTypeEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCustomPeriodTypeEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5f12d7e6-d64e-48b9-9d1f-2da5f94479ad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3eb100a3-03c3-4892-b444-62f74a1856a6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CustomPeriodTypeEditChange",
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"CustomPeriodTypeEditChangeStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCustomPeriodTypeEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("87b1d7e7-fb99-471a-a37e-61ccae28a1ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3eb100a3-03c3-4892-b444-62f74a1856a6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"CustomPeriodTypeEditChangeScriptTask",
				Position = new Point(120, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,193,110,19,49,16,134,207,27,41,239,48,244,228,85,169,43,174,68,57,180,73,84,16,2,42,182,229,238,238,78,54,86,179,118,100,123,211,174,80,15,192,1,14,125,143,94,17,106,133,4,45,207,224,125,35,198,222,164,144,170,226,176,150,53,243,205,63,51,191,119,41,12,204,116,109,236,91,243,90,170,218,161,125,47,230,53,194,16,216,65,45,139,244,80,148,200,71,181,117,186,58,68,35,117,113,212,44,112,82,72,199,35,55,72,250,61,57,5,246,152,196,147,33,4,9,62,169,22,174,73,225,67,191,151,44,169,91,33,156,200,8,207,67,147,40,63,190,143,12,86,140,205,103,88,9,202,255,133,121,22,99,107,66,228,78,46,241,157,62,219,132,246,214,225,53,183,26,172,234,6,35,88,225,25,28,101,35,173,166,178,172,141,112,82,43,254,98,99,250,209,92,88,203,142,45,26,162,20,230,1,73,131,158,84,14,164,42,240,156,100,118,158,133,200,84,27,20,249,140,133,78,167,203,5,101,31,52,228,7,232,54,213,89,218,89,145,68,165,237,237,65,188,147,133,84,207,95,97,3,195,225,99,15,178,42,74,238,247,230,25,186,145,158,215,149,138,121,214,89,198,187,80,236,187,223,188,17,21,178,173,135,175,183,149,242,127,10,3,243,180,91,43,46,153,36,39,180,211,105,188,94,208,65,223,5,224,220,98,28,96,119,23,252,85,251,201,255,222,9,7,248,59,127,3,116,251,230,127,114,206,129,249,31,254,218,223,180,31,219,75,240,191,218,207,237,151,246,43,1,251,65,16,252,119,127,27,115,161,112,114,158,227,34,26,251,60,24,75,235,103,141,117,88,241,177,20,165,210,214,201,220,242,49,158,212,101,137,134,191,180,123,206,145,207,88,144,13,16,38,251,31,29,219,177,184,76,24,190,223,51,232,106,163,192,25,250,95,255,0,23,228,171,194,240,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("596fc033-eb04-4828-acd1-497235f4888e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a9221cf-9b66-485e-9cc4-21f2e70a7312"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"InitEventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(382, 143),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9267f9d0-a15f-40cc-a119-ab4c9be92e7a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("596fc033-eb04-4828-acd1-497235f4888e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"InitStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f58c8340-0845-45c8-9406-fbba250cf4d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("596fc033-eb04-4828-acd1-497235f4888e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("88ba1edb-6f00-441a-acac-15a97a6df0c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("596fc033-eb04-4828-acd1-497235f4888e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				Name = @"InitScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 43),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,80,189,74,195,80,20,222,3,121,135,67,38,5,53,15,208,213,197,77,240,9,162,100,8,212,20,210,116,113,170,45,21,164,133,238,130,58,186,198,52,161,177,77,210,87,248,238,27,249,157,155,116,81,193,225,194,185,231,231,251,243,125,193,43,50,49,143,102,102,166,200,208,160,50,79,40,217,192,1,37,203,138,205,189,89,113,208,10,10,150,107,185,13,211,224,28,57,199,83,174,85,168,4,159,102,137,189,30,237,216,91,154,153,96,135,22,141,153,161,196,23,111,185,42,44,247,124,53,159,14,90,228,226,225,3,153,114,163,229,203,132,156,108,219,239,84,215,40,102,237,157,137,235,248,212,153,139,2,161,102,69,162,82,238,70,113,154,140,134,227,158,93,101,40,74,110,214,216,170,19,179,180,13,185,188,145,126,38,216,80,222,156,44,135,163,23,28,44,83,209,159,50,2,243,124,100,86,19,132,237,244,170,55,54,23,106,50,215,76,84,233,69,167,236,229,151,87,15,239,63,157,80,49,45,216,144,107,66,101,132,226,74,161,193,98,211,133,219,208,173,216,220,245,166,234,162,34,147,242,53,242,127,94,149,69,56,230,213,143,153,57,239,222,8,207,113,199,191,181,74,230,170,162,139,202,138,80,125,22,166,182,50,26,2,252,117,199,134,6,178,242,92,199,117,174,226,40,141,130,97,244,16,94,7,73,112,31,166,97,50,62,57,29,184,78,18,166,147,36,150,52,153,132,131,111,254,87,44,244,101,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateAddEnableDisableControlsScriptMethod());
			Methods.Add(CreateHideCalcInEditorsMethod());
			Methods.Add(CreateInitializeParametersMethod());
			Methods.Add(CreateSetComboboxesReadonlyMethod());
			Methods.Add(CreateFillAndInitializeValueListComboboxesMethod());
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb83bc54-95ba-437a-b982-b3238f69fab5"),
				Name = "Terrasoft.Configuration.DaysOfWeek",
				Alias = "DaysOfWeek",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("863df032-cafa-4da4-8431-7a75db6deb82"),
				Name = "Terrasoft.Configuration.HoursOrMinutes",
				Alias = "HoursOrMinutes",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,240,44,118,78,44,40,201,204,207,115,173,200,44,46,41,214,84,168,230,226,44,74,45,41,45,202,179,230,170,229,42,75,44,82,72,134,200,43,216,42,4,36,166,167,234,185,36,150,36,6,231,151,22,37,167,234,5,39,103,164,230,38,234,65,13,176,230,210,0,43,112,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,48,141,64,147,161,118,88,3,0,97,56,235,134,145,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsDesignerModeButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsDesignerModeButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddEnableDisableControlsScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("02c01b26-64e7-4e76-a91c-9941075e5cc7"),
				Name = "AddEnableDisableControlsScript",
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,85,93,111,218,48,20,125,46,18,255,193,162,82,27,84,150,190,143,109,82,27,152,132,68,215,170,68,235,179,137,47,96,53,177,145,109,218,161,137,255,62,231,139,216,137,3,162,84,218,27,220,123,207,57,182,111,116,206,165,128,37,229,12,141,96,65,25,252,198,66,118,59,23,111,88,32,130,105,188,125,158,79,8,250,142,158,240,18,252,81,86,192,132,242,251,141,82,156,249,65,76,129,169,201,104,88,32,222,1,94,109,200,75,94,57,128,73,56,83,43,27,244,80,148,142,163,130,141,84,60,113,96,139,198,113,134,41,150,106,132,93,242,101,231,0,7,103,17,152,200,199,244,255,129,249,168,113,220,227,231,204,182,48,38,84,213,246,144,150,90,22,96,79,191,236,107,135,95,209,70,61,212,91,206,203,219,152,199,162,210,114,239,39,16,148,19,27,18,212,58,7,161,225,118,13,237,240,178,219,66,241,83,212,175,24,88,245,22,88,72,227,216,5,43,235,13,24,131,55,16,99,70,204,45,255,42,107,71,191,141,26,48,216,23,15,32,165,194,66,127,169,10,66,154,212,222,103,86,111,53,192,192,136,27,58,182,27,21,240,226,162,219,185,212,176,220,54,186,157,110,39,229,193,113,108,156,113,66,164,230,97,240,142,166,84,170,111,82,9,202,150,63,188,62,250,171,101,111,111,81,8,201,154,11,44,182,40,226,73,162,121,129,160,5,23,104,14,10,127,209,111,37,53,243,87,164,7,247,30,52,56,17,88,89,209,169,72,195,144,62,8,173,92,233,131,4,134,41,165,12,165,205,164,191,35,139,219,252,216,170,110,81,232,118,118,195,114,61,114,94,236,99,182,149,10,18,63,132,63,74,127,29,233,90,238,55,52,38,32,188,126,54,44,231,254,221,122,173,215,59,213,97,224,245,22,27,22,169,52,29,56,51,214,27,172,32,122,77,183,217,203,65,39,221,209,86,48,237,237,6,245,124,9,106,204,240,60,6,226,245,116,161,202,160,155,158,31,165,178,64,250,195,76,246,12,81,203,38,29,170,70,142,165,93,91,247,44,229,102,110,57,228,205,72,108,234,159,175,110,102,222,127,144,183,226,166,93,191,246,70,197,41,208,213,21,106,31,130,156,166,218,148,125,0,35,178,28,186,251,52,119,238,220,102,114,36,154,131,49,114,94,161,124,200,118,70,35,232,62,133,213,200,190,79,225,51,66,241,84,190,6,99,51,128,90,41,203,112,116,177,214,124,107,87,148,245,87,9,56,90,33,47,53,65,145,130,41,107,102,85,158,75,54,133,40,149,56,243,174,51,181,235,129,195,5,7,72,173,168,44,142,177,115,156,196,101,156,249,116,230,203,145,160,107,165,189,89,163,66,158,27,114,230,196,89,6,223,17,50,203,6,188,124,174,63,252,7,212,171,36,31,173,11,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateHideCalcInEditorsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("42ab38a0-1f6a-4069-8e75-40b487222b0a"),
				Name = "HideCalcInEditors",
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,206,49,14,194,48,12,133,225,29,137,59,88,153,90,9,154,29,38,104,25,24,144,50,244,2,129,184,173,165,38,70,174,11,202,237,65,244,4,72,29,223,242,253,207,90,104,49,62,89,188,100,120,112,140,152,20,3,116,44,112,71,245,251,23,202,68,156,14,96,45,56,223,99,213,120,26,243,37,144,86,245,60,41,199,154,83,71,125,117,10,161,72,248,134,101,94,21,99,97,6,10,232,132,226,151,110,153,199,243,172,202,201,236,192,168,204,104,202,242,184,221,216,127,243,55,78,58,140,121,105,175,118,227,71,47,144,67,33,14,171,201,31,253,168,98,86,96,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("57999871-f7f0-437f-97f9-384060cdfa6d"),
				Name = "InitializeParameters",
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,193,78,195,48,16,68,207,137,148,127,176,124,74,46,254,1,148,11,84,130,136,150,150,134,194,1,113,88,146,109,107,145,218,194,187,65,10,136,127,39,169,15,165,77,40,148,147,87,246,120,103,222,16,59,109,86,226,181,70,215,228,126,78,197,12,86,168,230,216,94,18,171,219,221,147,186,179,126,136,147,179,40,212,75,17,127,251,167,46,172,97,208,134,98,73,72,164,173,25,1,195,12,157,182,165,46,52,55,57,50,183,58,154,99,97,93,185,200,202,107,108,100,146,136,143,40,12,242,63,255,56,18,239,241,20,227,167,125,152,79,129,21,225,233,89,228,49,137,236,22,71,161,175,106,4,13,77,151,15,136,47,121,177,198,13,136,52,21,166,174,42,95,192,27,56,81,246,20,98,65,232,218,94,13,22,220,70,82,247,80,213,56,214,196,94,48,1,211,86,225,212,37,114,102,136,193,20,120,222,220,192,6,99,185,115,147,29,94,112,184,91,101,70,179,134,74,191,227,216,22,221,9,207,21,110,247,211,182,144,160,159,183,23,208,227,117,112,87,182,118,52,117,19,109,106,70,250,9,112,61,168,250,63,228,190,171,7,29,242,248,29,118,56,255,96,224,14,250,11,45,129,186,27,54,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetComboboxesReadonlyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0dbaa461-8549-4018-b2c0-ed0094b27166"),
				Name = "SetComboboxesReadonly",
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,91,75,195,64,16,133,159,27,200,127,24,250,148,160,166,239,70,133,218,86,40,20,90,76,192,231,77,118,90,23,247,18,118,167,151,32,254,119,55,73,145,20,66,124,62,223,156,57,115,230,196,44,148,70,21,166,48,151,53,119,240,12,26,207,176,17,142,158,28,89,161,15,47,81,12,223,97,48,155,65,142,170,50,150,217,186,25,80,168,9,57,236,141,133,2,137,61,156,208,58,97,244,35,120,112,178,99,7,76,62,16,191,100,189,226,130,146,133,20,30,95,47,239,195,160,211,22,71,71,70,237,208,10,195,243,186,194,27,42,12,126,210,48,8,131,147,143,198,25,97,46,20,142,69,235,44,183,186,196,177,101,111,214,168,49,61,23,82,14,235,25,49,75,203,107,144,97,100,165,249,32,208,63,197,21,215,11,178,218,17,170,36,199,11,121,239,230,144,215,163,144,28,109,20,123,216,55,138,172,252,132,168,153,41,59,31,14,66,247,191,212,157,237,138,100,94,85,168,249,70,104,140,254,208,59,152,38,14,233,29,25,223,106,89,71,100,143,24,167,48,245,194,13,195,164,52,231,149,170,168,246,185,246,76,58,76,167,113,58,241,145,71,66,244,254,241,111,136,177,5,109,33,165,21,21,121,205,123,228,166,107,162,173,32,12,218,82,231,156,103,45,18,117,100,156,254,2,116,79,217,52,173,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillAndInitializeValueListComboboxesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("545a04a2-516d-4821-9e22-2bff3d469055"),
				Name = "FillAndInitializeValueListComboboxes",
				CreatedInSchemaUId = new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,203,78,195,48,16,60,183,82,255,193,234,201,145,192,220,65,28,104,139,0,241,40,34,45,28,16,7,55,217,182,22,177,93,217,78,74,132,248,119,214,78,131,218,40,60,74,78,86,118,118,102,118,103,11,110,136,77,150,32,57,57,37,247,124,1,108,196,29,143,117,110,18,96,113,40,156,244,186,5,162,120,226,68,1,15,122,221,2,60,171,107,136,237,117,143,142,200,4,228,74,27,110,74,146,104,41,65,57,72,201,92,27,50,3,199,15,11,48,86,104,117,76,16,232,153,83,94,218,241,252,9,224,53,174,157,208,71,158,229,112,35,172,171,126,69,163,6,102,99,106,137,250,118,108,110,133,202,29,216,239,219,47,91,112,193,235,22,137,172,138,216,174,96,77,38,241,80,171,185,88,228,134,59,52,203,118,25,134,25,183,150,78,45,24,68,41,72,60,36,66,66,156,17,120,178,164,158,246,181,88,17,161,26,236,236,2,220,46,21,141,34,242,222,235,118,124,11,46,107,166,7,250,237,60,21,238,202,129,172,189,128,49,220,234,185,99,211,43,246,4,51,212,116,70,103,150,125,61,252,168,190,129,34,17,126,40,205,194,10,14,188,11,118,13,37,155,232,216,25,161,22,40,135,62,59,33,193,97,110,157,150,247,96,132,78,39,229,10,188,44,243,52,150,157,165,41,109,186,241,141,31,255,12,184,202,46,120,194,161,190,110,201,175,99,168,179,92,170,80,162,251,113,119,170,203,101,21,67,216,237,160,188,227,18,104,127,84,75,246,35,182,37,224,139,251,105,68,155,75,75,26,187,250,195,40,63,216,107,110,190,205,165,87,222,199,233,26,167,205,202,144,97,12,25,222,36,164,62,53,86,59,221,170,135,140,159,169,80,46,218,205,230,165,66,163,242,247,7,210,74,254,203,61,85,90,173,59,172,37,63,1,242,36,99,32,138,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PeriodicitySettingsPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("401cd484-fcd7-4e78-a97f-77bdb6fd9c48"));
		}

		#endregion

	}

	#endregion

}

