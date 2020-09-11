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

	#region Class: CalendarEditPageSchema

	/// <exclude/>
	public class CalendarEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _timeZoneEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit TimeZoneEdit {
			get {
				return _timeZoneEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _mainTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel MainTabPanel {
			get {
				return _mainTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _workingWeekTab;
		public Terrasoft.UI.WebControls.Controls.Tab WorkingWeekTab {
			get {
				return _workingWeekTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _workingWeekControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout WorkingWeekControlLayout {
			get {
				return _workingWeekControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _workingWeekLeftControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout WorkingWeekLeftControlLayout {
			get {
				return _workingWeekLeftControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _weekDaysTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid WeekDaysTreeGrid {
			get {
				return _weekDaysTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _workingWeekRightControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout WorkingWeekRightControlLayout {
			get {
				return _workingWeekRightControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isDiffFromParentWeekEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsDiffFromParentWeekEdit {
			get {
				return _isDiffFromParentWeekEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _dayTypeWeekEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit DayTypeWeekEdit {
			get {
				return _dayTypeWeekEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _weekIntervalsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekIntervalsControlLayout {
			get {
				return _weekIntervalsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _weekInterval0ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval0ControlLayout {
			get {
				return _weekInterval0ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekFrom0Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom0Edit {
			get {
				return _weekFrom0Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekTo0Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo0Edit {
			get {
				return _weekTo0Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _weekInterval1ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval1ControlLayout {
			get {
				return _weekInterval1ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekFrom1Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom1Edit {
			get {
				return _weekFrom1Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekTo1Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo1Edit {
			get {
				return _weekTo1Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _weekInterval2ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval2ControlLayout {
			get {
				return _weekInterval2ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekFrom2Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom2Edit {
			get {
				return _weekFrom2Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekTo2Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo2Edit {
			get {
				return _weekTo2Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _weekInterval3ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval3ControlLayout {
			get {
				return _weekInterval3ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekFrom3Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom3Edit {
			get {
				return _weekFrom3Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekTo3Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo3Edit {
			get {
				return _weekTo3Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _weekInterval4ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval4ControlLayout {
			get {
				return _weekInterval4ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekFrom4Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom4Edit {
			get {
				return _weekFrom4Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _weekTo4Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo4Edit {
			get {
				return _weekTo4Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _calendarTab;
		public Terrasoft.UI.WebControls.Controls.Tab CalendarTab {
			get {
				return _calendarTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarControlLayout {
			get {
				return _calendarControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarLeftControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarLeftControlLayout {
			get {
				return _calendarLeftControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarPeriodControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarPeriodControlLayout {
			get {
				return _calendarPeriodControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarPeriodButtonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarPeriodButtonsControlLayout {
			get {
				return _calendarPeriodButtonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _calendarPeriodLabel;
		public Terrasoft.UI.WebControls.Controls.Label CalendarPeriodLabel {
			get {
				return _calendarPeriodLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _dayButton;
		public Terrasoft.UI.WebControls.Controls.Button DayButton {
			get {
				return _dayButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _yesterdayItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem YesterdayItem {
			get {
				return _yesterdayItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _todayItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem TodayItem {
			get {
				return _todayItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _tomorowItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem TomorowItem {
			get {
				return _tomorowItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _weekButton;
		public Terrasoft.UI.WebControls.Controls.Button WeekButton {
			get {
				return _weekButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _lastWeekItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem LastWeekItem {
			get {
				return _lastWeekItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _currentWeekItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem CurrentWeekItem {
			get {
				return _currentWeekItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _nextWeekItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem NextWeekItem {
			get {
				return _nextWeekItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _monthButton;
		public Terrasoft.UI.WebControls.Controls.Button MonthButton {
			get {
				return _monthButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _lastMonthItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem LastMonthItem {
			get {
				return _lastMonthItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _currentMonthItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem CurrentMonthItem {
			get {
				return _currentMonthItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _nextMonthItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem NextMonthItem {
			get {
				return _nextMonthItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarPeriodEditControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarPeriodEditControlLayout {
			get {
				return _calendarPeriodEditControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _startDateEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit StartDateEdit {
			get {
				return _startDateEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _endDateEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit EndDateEdit {
			get {
				return _endDateEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _calendarDaysTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid CalendarDaysTreeGrid {
			get {
				return _calendarDaysTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarRightControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarRightControlLayout {
			get {
				return _calendarRightControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isDiffFromParentCalendarEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsDiffFromParentCalendarEdit {
			get {
				return _isDiffFromParentCalendarEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _dayTypeCalendarEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit DayTypeCalendarEdit {
			get {
				return _dayTypeCalendarEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarIntervalsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarIntervalsControlLayout {
			get {
				return _calendarIntervalsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarInterval0ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval0ControlLayout {
			get {
				return _calendarInterval0ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarFrom0Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom0Edit {
			get {
				return _calendarFrom0Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarTo0Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo0Edit {
			get {
				return _calendarTo0Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarInterval1ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval1ControlLayout {
			get {
				return _calendarInterval1ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarFrom1Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom1Edit {
			get {
				return _calendarFrom1Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarTo1Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo1Edit {
			get {
				return _calendarTo1Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarInterval2ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval2ControlLayout {
			get {
				return _calendarInterval2ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarFrom2Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom2Edit {
			get {
				return _calendarFrom2Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarTo2Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo2Edit {
			get {
				return _calendarTo2Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarInterval3ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval3ControlLayout {
			get {
				return _calendarInterval3ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarFrom3Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom3Edit {
			get {
				return _calendarFrom3Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarTo3Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo3Edit {
			get {
				return _calendarTo3Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _calendarInterval4ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval4ControlLayout {
			get {
				return _calendarInterval4ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarFrom4Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom4Edit {
			get {
				return _calendarFrom4Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _calendarTo4Edit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo4Edit {
			get {
				return _calendarTo4Edit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _weekDaysDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource WeekDaysDataSource {
			get {
				return _weekDaysDataSource;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _calendarDaysDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource CalendarDaysDataSource {
			get {
				return _calendarDaysDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public CalendarEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CalendarEditPageSchema(CalendarEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.Hidden = true;
			CustomControls.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(57);
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			RealUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			Name = "CalendarEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			Width = 620;
			Height = 570;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCalendarEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateNameEdit());
			MainControlLayout.InsertItem(1, CreateTimeZoneEdit());
			MainControlLayout.MoveItem(2, CustomControls);
			Controls.AddAt(2, CreateMainTabPanel());
			MainTabPanel.InsertItem(0, CreateWorkingWeekTab());
			WorkingWeekTab.InsertItem(0, CreateWorkingWeekControlLayout());
			WorkingWeekControlLayout.InsertItem(0, CreateWorkingWeekLeftControlLayout());
			WorkingWeekLeftControlLayout.InsertItem(0, CreateWeekDaysTreeGrid());
			WorkingWeekControlLayout.InsertItem(1, CreateWorkingWeekRightControlLayout());
			WorkingWeekRightControlLayout.InsertItem(0, CreateIsDiffFromParentWeekEdit());
			WorkingWeekRightControlLayout.InsertItem(1, CreateDayTypeWeekEdit());
			WorkingWeekRightControlLayout.InsertItem(2, CreateWeekIntervalsControlLayout());
			WeekIntervalsControlLayout.InsertItem(0, CreateWeekInterval0ControlLayout());
			WeekInterval0ControlLayout.InsertItem(0, CreateWeekFrom0Edit());
			WeekInterval0ControlLayout.InsertItem(1, CreateWeekTo0Edit());
			WeekIntervalsControlLayout.InsertItem(1, CreateWeekInterval1ControlLayout());
			WeekInterval1ControlLayout.InsertItem(0, CreateWeekFrom1Edit());
			WeekInterval1ControlLayout.InsertItem(1, CreateWeekTo1Edit());
			WeekIntervalsControlLayout.InsertItem(2, CreateWeekInterval2ControlLayout());
			WeekInterval2ControlLayout.InsertItem(0, CreateWeekFrom2Edit());
			WeekInterval2ControlLayout.InsertItem(1, CreateWeekTo2Edit());
			WeekIntervalsControlLayout.InsertItem(3, CreateWeekInterval3ControlLayout());
			WeekInterval3ControlLayout.InsertItem(0, CreateWeekFrom3Edit());
			WeekInterval3ControlLayout.InsertItem(1, CreateWeekTo3Edit());
			WeekIntervalsControlLayout.InsertItem(4, CreateWeekInterval4ControlLayout());
			WeekInterval4ControlLayout.InsertItem(0, CreateWeekFrom4Edit());
			WeekInterval4ControlLayout.InsertItem(1, CreateWeekTo4Edit());
			MainTabPanel.InsertItem(1, CreateCalendarTab());
			CalendarTab.InsertItem(0, CreateCalendarControlLayout());
			CalendarControlLayout.InsertItem(0, CreateCalendarLeftControlLayout());
			CalendarLeftControlLayout.InsertItem(0, CreateCalendarPeriodControlLayout());
			CalendarPeriodControlLayout.InsertItem(0, CreateCalendarPeriodButtonsControlLayout());
			CalendarPeriodButtonsControlLayout.InsertItem(0, CreateCalendarPeriodLabel());
			CalendarPeriodButtonsControlLayout.InsertItem(1, CreateDayButton());
			DayButton.InsertItem(0, CreateYesterdayItem());
			DayButton.InsertItem(1, CreateTodayItem());
			DayButton.InsertItem(2, CreateTomorowItem());
			CalendarPeriodButtonsControlLayout.InsertItem(2, CreateWeekButton());
			WeekButton.InsertItem(0, CreateLastWeekItem());
			WeekButton.InsertItem(1, CreateCurrentWeekItem());
			WeekButton.InsertItem(2, CreateNextWeekItem());
			CalendarPeriodButtonsControlLayout.InsertItem(3, CreateMonthButton());
			MonthButton.InsertItem(0, CreateLastMonthItem());
			MonthButton.InsertItem(1, CreateCurrentMonthItem());
			MonthButton.InsertItem(2, CreateNextMonthItem());
			CalendarPeriodControlLayout.InsertItem(1, CreateCalendarPeriodEditControlLayout());
			CalendarPeriodEditControlLayout.InsertItem(0, CreateStartDateEdit());
			CalendarPeriodEditControlLayout.InsertItem(1, CreateEndDateEdit());
			CalendarLeftControlLayout.InsertItem(1, CreateCalendarDaysTreeGrid());
			CalendarControlLayout.InsertItem(1, CreateCalendarRightControlLayout());
			CalendarRightControlLayout.InsertItem(0, CreateIsDiffFromParentCalendarEdit());
			CalendarRightControlLayout.InsertItem(1, CreateDayTypeCalendarEdit());
			CalendarRightControlLayout.InsertItem(2, CreateCalendarIntervalsControlLayout());
			CalendarIntervalsControlLayout.InsertItem(0, CreateCalendarInterval0ControlLayout());
			CalendarInterval0ControlLayout.InsertItem(0, CreateCalendarFrom0Edit());
			CalendarInterval0ControlLayout.InsertItem(1, CreateCalendarTo0Edit());
			CalendarIntervalsControlLayout.InsertItem(1, CreateCalendarInterval1ControlLayout());
			CalendarInterval1ControlLayout.InsertItem(0, CreateCalendarFrom1Edit());
			CalendarInterval1ControlLayout.InsertItem(1, CreateCalendarTo1Edit());
			CalendarIntervalsControlLayout.InsertItem(2, CreateCalendarInterval2ControlLayout());
			CalendarInterval2ControlLayout.InsertItem(0, CreateCalendarFrom2Edit());
			CalendarInterval2ControlLayout.InsertItem(1, CreateCalendarTo2Edit());
			CalendarIntervalsControlLayout.InsertItem(3, CreateCalendarInterval3ControlLayout());
			CalendarInterval3ControlLayout.InsertItem(0, CreateCalendarFrom3Edit());
			CalendarInterval3ControlLayout.InsertItem(1, CreateCalendarTo3Edit());
			CalendarIntervalsControlLayout.InsertItem(4, CreateCalendarInterval4ControlLayout());
			CalendarInterval4ControlLayout.InsertItem(0, CreateCalendarFrom4Edit());
			CalendarInterval4ControlLayout.InsertItem(1, CreateCalendarTo4Edit());
			TopLevelControl.MoveItem(3, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(4, DataSource);
			Controls.AddAt(5, CreateWeekDaysDataSource());
			UpdateWeekDaysDataSource();
			Controls.AddAt(6, CreateCalendarDaysDataSource());
			UpdateCalendarDaysDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateCalendarEditPageEventsProcessSchema() {
			var schema = new CalendarEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("cee5de10-27ea-4ff5-89d5-9b88c2529a3d");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_nameEdit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_nameEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("cef95359-9fa6-4450-bbe7-079c10ce4864");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateTimeZoneEdit() {
			_timeZoneEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_timeZoneEdit.UId = new Guid("c107e2a1-80d5-4c01-b46f-48ee494418ca");
			_timeZoneEdit.Name = "TimeZoneEdit";
			_timeZoneEdit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_timeZoneEdit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_timeZoneEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_timeZoneEdit.Tag = "";
			_timeZoneEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_timeZoneEdit.Image = new ControlImage {};
			_timeZoneEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_timeZoneEdit.DataSource = "DataSource";
			_timeZoneEdit.ColumnUId = new Guid("010c3524-f1da-455b-8b92-b4e159b81d83");
			return _timeZoneEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateWeekDaysTreeGrid() {
			_weekDaysTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_weekDaysTreeGrid.UId = new Guid("a7ed0898-b22f-473e-a954-f91f1011d28a");
			_weekDaysTreeGrid.Name = "WeekDaysTreeGrid";
			_weekDaysTreeGrid.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekDaysTreeGrid.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekDaysTreeGrid.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekDaysTreeGrid.Tag = "";
			_weekDaysTreeGrid.DataSourceId = "WeekDaysDataSource";
			_weekDaysTreeGrid.Edges = "1 1 1 1";
			_weekDaysTreeGrid.IsColumnAutowidth = true;
			_weekDaysTreeGrid.FooterVisible = false;
			_weekDaysTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekDaysTreeGrid.IsSummaryVisible = false;
			_weekDaysTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekDaysTreeGrid.ToolbarVisible = false;
			_weekDaysTreeGrid.QuickFilterVisible = false;
			_weekDaysTreeGrid.HideHeaders = false;
			return _weekDaysTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateWorkingWeekLeftControlLayout() {
			_workingWeekLeftControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_workingWeekLeftControlLayout.UId = new Guid("b18da074-2b8b-40bc-9060-76987dfc1385");
			_workingWeekLeftControlLayout.Name = "WorkingWeekLeftControlLayout";
			_workingWeekLeftControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_workingWeekLeftControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_workingWeekLeftControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_workingWeekLeftControlLayout.Tag = "";
			_workingWeekLeftControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_workingWeekLeftControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_workingWeekLeftControlLayout.StartNewAlignGroup = false;
			_workingWeekLeftControlLayout.Image = new ControlImage {};
			_workingWeekLeftControlLayout.Edges = "";
			return _workingWeekLeftControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsDiffFromParentWeekEdit() {
			_isDiffFromParentWeekEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isDiffFromParentWeekEdit.UId = new Guid("97ef3358-ed18-4182-a5ad-994afb912ba7");
			_isDiffFromParentWeekEdit.Name = "IsDiffFromParentWeekEdit";
			_isDiffFromParentWeekEdit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_isDiffFromParentWeekEdit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_isDiffFromParentWeekEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_isDiffFromParentWeekEdit.Tag = "";
			_isDiffFromParentWeekEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isDiffFromParentWeekEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isDiffFromParentWeekEdit.AlignedByCaption = false;
			return _isDiffFromParentWeekEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateDayTypeWeekEdit() {
			_dayTypeWeekEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_dayTypeWeekEdit.UId = new Guid("e9c3d317-4e6b-46e9-9076-37f9cca5c6af");
			_dayTypeWeekEdit.Name = "DayTypeWeekEdit";
			_dayTypeWeekEdit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_dayTypeWeekEdit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_dayTypeWeekEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_dayTypeWeekEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_dayTypeWeekEdit.Tag = "";
			_dayTypeWeekEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dayTypeWeekEdit.Image = new ControlImage {};
			_dayTypeWeekEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_dayTypeWeekEdit.Enabled = false;
			return _dayTypeWeekEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekFrom0Edit() {
			_weekFrom0Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekFrom0Edit.UId = new Guid("d12dd641-3c91-438d-b56b-658be78308e7");
			_weekFrom0Edit.Name = "WeekFrom0Edit";
			_weekFrom0Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom0Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom0Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekFrom0Edit.Tag = "0";
			_weekFrom0Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekFrom0Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekFrom0Edit.AlignedByCaption = false;
			_weekFrom0Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekFrom0Edit.Enabled = false;
			return _weekFrom0Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekTo0Edit() {
			_weekTo0Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekTo0Edit.UId = new Guid("fdb41b61-1fb3-4e90-8431-0c854ae83101");
			_weekTo0Edit.Name = "WeekTo0Edit";
			_weekTo0Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo0Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo0Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekTo0Edit.Tag = "0";
			_weekTo0Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekTo0Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekTo0Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekTo0Edit.Enabled = false;
			return _weekTo0Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateWeekInterval0ControlLayout() {
			_weekInterval0ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_weekInterval0ControlLayout.UId = new Guid("ed56969b-34ff-4843-9f64-344ba8c08de0");
			_weekInterval0ControlLayout.Name = "WeekInterval0ControlLayout";
			_weekInterval0ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval0ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval0ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekInterval0ControlLayout.Tag = "";
			_weekInterval0ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_weekInterval0ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_weekInterval0ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_weekInterval0ControlLayout.FitHeightByContent = true;
			_weekInterval0ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekInterval0ControlLayout.StartNewAlignGroup = false;
			_weekInterval0ControlLayout.Image = new ControlImage {};
			_weekInterval0ControlLayout.Edges = "";
			return _weekInterval0ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekFrom1Edit() {
			_weekFrom1Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekFrom1Edit.UId = new Guid("9e79ac51-da72-4b2a-b1ae-519f3143368d");
			_weekFrom1Edit.Name = "WeekFrom1Edit";
			_weekFrom1Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom1Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom1Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekFrom1Edit.Tag = "1";
			_weekFrom1Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekFrom1Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekFrom1Edit.AlignedByCaption = false;
			_weekFrom1Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekFrom1Edit.Enabled = false;
			return _weekFrom1Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekTo1Edit() {
			_weekTo1Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekTo1Edit.UId = new Guid("fb38b9c1-ab1f-4d7c-8e8d-3649cb687a8b");
			_weekTo1Edit.Name = "WeekTo1Edit";
			_weekTo1Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo1Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo1Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekTo1Edit.Tag = "1";
			_weekTo1Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekTo1Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekTo1Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekTo1Edit.Enabled = false;
			return _weekTo1Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateWeekInterval1ControlLayout() {
			_weekInterval1ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_weekInterval1ControlLayout.UId = new Guid("14f1bbd1-d8f5-46d3-a767-f794f7ff5fb6");
			_weekInterval1ControlLayout.Name = "WeekInterval1ControlLayout";
			_weekInterval1ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval1ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval1ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekInterval1ControlLayout.Tag = "";
			_weekInterval1ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_weekInterval1ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_weekInterval1ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_weekInterval1ControlLayout.FitHeightByContent = true;
			_weekInterval1ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekInterval1ControlLayout.StartNewAlignGroup = false;
			_weekInterval1ControlLayout.Image = new ControlImage {};
			_weekInterval1ControlLayout.Edges = "";
			return _weekInterval1ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekFrom2Edit() {
			_weekFrom2Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekFrom2Edit.UId = new Guid("4f02284d-ceea-416f-968b-777b284dc834");
			_weekFrom2Edit.Name = "WeekFrom2Edit";
			_weekFrom2Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom2Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom2Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekFrom2Edit.Tag = "2";
			_weekFrom2Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekFrom2Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekFrom2Edit.AlignedByCaption = false;
			_weekFrom2Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekFrom2Edit.Enabled = false;
			return _weekFrom2Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekTo2Edit() {
			_weekTo2Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekTo2Edit.UId = new Guid("89a8f46b-0645-4b51-8a04-9697801c3bb1");
			_weekTo2Edit.Name = "WeekTo2Edit";
			_weekTo2Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo2Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo2Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekTo2Edit.Tag = "2";
			_weekTo2Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekTo2Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekTo2Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekTo2Edit.Enabled = false;
			return _weekTo2Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateWeekInterval2ControlLayout() {
			_weekInterval2ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_weekInterval2ControlLayout.UId = new Guid("98cb8147-b7e8-4036-b161-00ef39e14e39");
			_weekInterval2ControlLayout.Name = "WeekInterval2ControlLayout";
			_weekInterval2ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval2ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval2ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekInterval2ControlLayout.Tag = "";
			_weekInterval2ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_weekInterval2ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_weekInterval2ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_weekInterval2ControlLayout.FitHeightByContent = true;
			_weekInterval2ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekInterval2ControlLayout.StartNewAlignGroup = false;
			_weekInterval2ControlLayout.Image = new ControlImage {};
			_weekInterval2ControlLayout.Edges = "";
			return _weekInterval2ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekFrom3Edit() {
			_weekFrom3Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekFrom3Edit.UId = new Guid("ea0c616f-280b-4e99-a15f-d66f10be350e");
			_weekFrom3Edit.Name = "WeekFrom3Edit";
			_weekFrom3Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom3Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom3Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekFrom3Edit.Tag = "3";
			_weekFrom3Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekFrom3Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekFrom3Edit.AlignedByCaption = false;
			_weekFrom3Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekFrom3Edit.Enabled = false;
			return _weekFrom3Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekTo3Edit() {
			_weekTo3Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekTo3Edit.UId = new Guid("b8e15fb5-0adb-49ec-9570-dc9d54b79e9a");
			_weekTo3Edit.Name = "WeekTo3Edit";
			_weekTo3Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo3Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo3Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekTo3Edit.Tag = "3";
			_weekTo3Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekTo3Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekTo3Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekTo3Edit.Enabled = false;
			return _weekTo3Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateWeekInterval3ControlLayout() {
			_weekInterval3ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_weekInterval3ControlLayout.UId = new Guid("6125d7cf-9906-4264-932b-8bec7acc976b");
			_weekInterval3ControlLayout.Name = "WeekInterval3ControlLayout";
			_weekInterval3ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval3ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval3ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekInterval3ControlLayout.Tag = "";
			_weekInterval3ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_weekInterval3ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_weekInterval3ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_weekInterval3ControlLayout.FitHeightByContent = true;
			_weekInterval3ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekInterval3ControlLayout.StartNewAlignGroup = false;
			_weekInterval3ControlLayout.Image = new ControlImage {};
			_weekInterval3ControlLayout.Edges = "";
			return _weekInterval3ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekFrom4Edit() {
			_weekFrom4Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekFrom4Edit.UId = new Guid("552b784d-02b6-4997-a7a4-85c004faa078");
			_weekFrom4Edit.Name = "WeekFrom4Edit";
			_weekFrom4Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom4Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekFrom4Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekFrom4Edit.Tag = "4";
			_weekFrom4Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekFrom4Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekFrom4Edit.AlignedByCaption = false;
			_weekFrom4Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekFrom4Edit.Enabled = false;
			return _weekFrom4Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateWeekTo4Edit() {
			_weekTo4Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_weekTo4Edit.UId = new Guid("fa643486-69e8-4062-94c6-d414916c9c32");
			_weekTo4Edit.Name = "WeekTo4Edit";
			_weekTo4Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo4Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekTo4Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekTo4Edit.Tag = "4";
			_weekTo4Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_weekTo4Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekTo4Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_weekTo4Edit.Enabled = false;
			return _weekTo4Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateWeekInterval4ControlLayout() {
			_weekInterval4ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_weekInterval4ControlLayout.UId = new Guid("3c05fcf1-b334-4f96-8b7b-a77bc9a87e82");
			_weekInterval4ControlLayout.Name = "WeekInterval4ControlLayout";
			_weekInterval4ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval4ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekInterval4ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekInterval4ControlLayout.Tag = "";
			_weekInterval4ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_weekInterval4ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_weekInterval4ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_weekInterval4ControlLayout.FitHeightByContent = true;
			_weekInterval4ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekInterval4ControlLayout.StartNewAlignGroup = false;
			_weekInterval4ControlLayout.Image = new ControlImage {};
			_weekInterval4ControlLayout.Edges = "";
			return _weekInterval4ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateWeekIntervalsControlLayout() {
			_weekIntervalsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_weekIntervalsControlLayout.UId = new Guid("3426bab5-236f-449b-9595-c3bb8bc89ce0");
			_weekIntervalsControlLayout.Name = "WeekIntervalsControlLayout";
			_weekIntervalsControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekIntervalsControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekIntervalsControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekIntervalsControlLayout.Tag = "";
			_weekIntervalsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_weekIntervalsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_weekIntervalsControlLayout.FitHeightByContent = true;
			_weekIntervalsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_weekIntervalsControlLayout.StartNewAlignGroup = false;
			_weekIntervalsControlLayout.Image = new ControlImage {};
			_weekIntervalsControlLayout.Edges = "";
			_weekIntervalsControlLayout.Enabled = false;
			return _weekIntervalsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateWorkingWeekRightControlLayout() {
			_workingWeekRightControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_workingWeekRightControlLayout.UId = new Guid("3b55c210-15bf-47cd-97e5-9ced5777b1d1");
			_workingWeekRightControlLayout.Name = "WorkingWeekRightControlLayout";
			_workingWeekRightControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_workingWeekRightControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_workingWeekRightControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_workingWeekRightControlLayout.Tag = "";
			_workingWeekRightControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_workingWeekRightControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_workingWeekRightControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_workingWeekRightControlLayout.StartNewAlignGroup = false;
			_workingWeekRightControlLayout.Image = new ControlImage {};
			_workingWeekRightControlLayout.Edges = "";
			return _workingWeekRightControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateWorkingWeekControlLayout() {
			_workingWeekControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_workingWeekControlLayout.UId = new Guid("ccef1d61-0f05-4774-967e-d91acd53e636");
			_workingWeekControlLayout.Name = "WorkingWeekControlLayout";
			_workingWeekControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_workingWeekControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_workingWeekControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_workingWeekControlLayout.Tag = "";
			_workingWeekControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_workingWeekControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_workingWeekControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_workingWeekControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_workingWeekControlLayout.Padding = "5 5 5 5";
			_workingWeekControlLayout.StartNewAlignGroup = false;
			_workingWeekControlLayout.Image = new ControlImage {};
			_workingWeekControlLayout.Edges = "";
			return _workingWeekControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateWorkingWeekTab() {
			_workingWeekTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_workingWeekTab.UId = new Guid("9df70e0f-e0e1-49de-8408-ec01022e5c4e");
			_workingWeekTab.Name = "WorkingWeekTab";
			_workingWeekTab.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_workingWeekTab.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_workingWeekTab.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_workingWeekTab.Tag = "";
			_workingWeekTab.Image = new ControlImage {};
			return _workingWeekTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateCalendarPeriodLabel() {
			_calendarPeriodLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_calendarPeriodLabel.UId = new Guid("62e7fd7b-70d1-4cf0-abfd-df4612339c1d");
			_calendarPeriodLabel.Name = "CalendarPeriodLabel";
			_calendarPeriodLabel.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarPeriodLabel.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarPeriodLabel.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarPeriodLabel.Tag = "";
			_calendarPeriodLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarPeriodLabel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _calendarPeriodLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateYesterdayItem() {
			_yesterdayItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_yesterdayItem.UId = new Guid("e470fa0e-60ab-42db-aacc-b09039742b82");
			_yesterdayItem.Name = "YesterdayItem";
			_yesterdayItem.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_yesterdayItem.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_yesterdayItem.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_yesterdayItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_yesterdayItem.Image = new ControlImage {};
			_yesterdayItem.Tag = "day&-1";
			return _yesterdayItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateTodayItem() {
			_todayItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_todayItem.UId = new Guid("5832803d-9391-49cd-86d4-ff35b101d249");
			_todayItem.Name = "TodayItem";
			_todayItem.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_todayItem.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_todayItem.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_todayItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_todayItem.Image = new ControlImage {};
			_todayItem.Tag = "day&0";
			return _todayItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateTomorowItem() {
			_tomorowItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_tomorowItem.UId = new Guid("10a460c6-7298-4b93-97d8-08b89eff0e2c");
			_tomorowItem.Name = "TomorowItem";
			_tomorowItem.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_tomorowItem.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_tomorowItem.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_tomorowItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_tomorowItem.Image = new ControlImage {};
			_tomorowItem.Tag = "day&1";
			return _tomorowItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDayButton() {
			_dayButton = new Terrasoft.UI.WebControls.Controls.Button();
			_dayButton.UId = new Guid("35748af8-e5d5-4255-bdc1-e88b80d910b5");
			_dayButton.Name = "DayButton";
			_dayButton.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_dayButton.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_dayButton.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_dayButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_dayButton.Tag = "";
			_dayButton.Image = new ControlImage {
				Source = ControlImageSource.ImageListSchema,
				SchemaUId = new Guid("7b4b2ab8-27bf-499c-a8f8-c348384a6bd6"),
				ItemUId = new Guid("ceeaa064-ff61-470b-8fac-088d723602d5"),
				ImageHash = @"91e70a2fa1bfb7dec9413b6c3628b398"
			};
			_dayButton.Margins = "0 0 0 5";
			return _dayButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateLastWeekItem() {
			_lastWeekItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_lastWeekItem.UId = new Guid("45168fce-562c-4901-b362-503385b1ead6");
			_lastWeekItem.Name = "LastWeekItem";
			_lastWeekItem.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_lastWeekItem.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_lastWeekItem.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_lastWeekItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lastWeekItem.Image = new ControlImage {};
			_lastWeekItem.Tag = "week&-1";
			return _lastWeekItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateCurrentWeekItem() {
			_currentWeekItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_currentWeekItem.UId = new Guid("af517dea-d805-42b9-af88-aab87a02c842");
			_currentWeekItem.Name = "CurrentWeekItem";
			_currentWeekItem.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_currentWeekItem.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_currentWeekItem.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_currentWeekItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_currentWeekItem.Image = new ControlImage {};
			_currentWeekItem.Tag = "week&0";
			return _currentWeekItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateNextWeekItem() {
			_nextWeekItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_nextWeekItem.UId = new Guid("83d875ba-0e96-4931-aa7b-8f0c5aec10ae");
			_nextWeekItem.Name = "NextWeekItem";
			_nextWeekItem.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_nextWeekItem.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_nextWeekItem.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_nextWeekItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nextWeekItem.Image = new ControlImage {};
			_nextWeekItem.Tag = "week&1";
			return _nextWeekItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateWeekButton() {
			_weekButton = new Terrasoft.UI.WebControls.Controls.Button();
			_weekButton.UId = new Guid("55d1206c-65dd-4889-951d-2752d74792d0");
			_weekButton.Name = "WeekButton";
			_weekButton.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekButton.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekButton.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_weekButton.Tag = "";
			_weekButton.Image = new ControlImage {
				Source = ControlImageSource.ImageListSchema,
				SchemaUId = new Guid("7b4b2ab8-27bf-499c-a8f8-c348384a6bd6"),
				ItemUId = new Guid("0399ffc4-0973-4e91-9637-99137e5b2e31"),
				ImageHash = @"4f881e0acf26749fb996a32fa353ff00"
			};
			_weekButton.Margins = "0 0 0 5";
			return _weekButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateLastMonthItem() {
			_lastMonthItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_lastMonthItem.UId = new Guid("67a58175-4039-411a-a0f9-bfce91b3455f");
			_lastMonthItem.Name = "LastMonthItem";
			_lastMonthItem.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_lastMonthItem.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_lastMonthItem.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_lastMonthItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lastMonthItem.Image = new ControlImage {};
			_lastMonthItem.Tag = "month&-1";
			return _lastMonthItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateCurrentMonthItem() {
			_currentMonthItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_currentMonthItem.UId = new Guid("b87c6ec5-b389-499a-888c-b3367b27079e");
			_currentMonthItem.Name = "CurrentMonthItem";
			_currentMonthItem.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_currentMonthItem.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_currentMonthItem.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_currentMonthItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_currentMonthItem.Image = new ControlImage {};
			_currentMonthItem.Tag = "month&0";
			return _currentMonthItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateNextMonthItem() {
			_nextMonthItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_nextMonthItem.UId = new Guid("26a9be47-9c7b-4490-95ca-6d9fb33a944d");
			_nextMonthItem.Name = "NextMonthItem";
			_nextMonthItem.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_nextMonthItem.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_nextMonthItem.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_nextMonthItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nextMonthItem.Image = new ControlImage {};
			_nextMonthItem.Tag = "month&1";
			return _nextMonthItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateMonthButton() {
			_monthButton = new Terrasoft.UI.WebControls.Controls.Button();
			_monthButton.UId = new Guid("cbdfef19-b623-4291-8658-398dcc7256b5");
			_monthButton.Name = "MonthButton";
			_monthButton.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_monthButton.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_monthButton.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_monthButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_monthButton.Tag = "";
			_monthButton.Image = new ControlImage {
				Source = ControlImageSource.ImageListSchema,
				SchemaUId = new Guid("7b4b2ab8-27bf-499c-a8f8-c348384a6bd6"),
				ItemUId = new Guid("d1302cce-bc55-4d86-a773-74ce01b492d3"),
				ImageHash = @"43f91aff284e643bcc16f9ac95aa56f0"
			};
			_monthButton.Margins = "0 0 0 5";
			return _monthButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarPeriodButtonsControlLayout() {
			_calendarPeriodButtonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarPeriodButtonsControlLayout.UId = new Guid("faf0ef32-29a2-4c39-964e-648173d9d78d");
			_calendarPeriodButtonsControlLayout.Name = "CalendarPeriodButtonsControlLayout";
			_calendarPeriodButtonsControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarPeriodButtonsControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarPeriodButtonsControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarPeriodButtonsControlLayout.Tag = "";
			_calendarPeriodButtonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_calendarPeriodButtonsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_calendarPeriodButtonsControlLayout.FitHeightByContent = true;
			_calendarPeriodButtonsControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_calendarPeriodButtonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarPeriodButtonsControlLayout.StartNewAlignGroup = false;
			_calendarPeriodButtonsControlLayout.Image = new ControlImage {};
			_calendarPeriodButtonsControlLayout.Edges = "";
			return _calendarPeriodButtonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateStartDateEdit() {
			_startDateEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_startDateEdit.UId = new Guid("7125bf37-ebb9-4f09-b114-7cb836bb3d55");
			_startDateEdit.Name = "StartDateEdit";
			_startDateEdit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_startDateEdit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_startDateEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_startDateEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_startDateEdit.Tag = "";
			_startDateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_startDateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_startDateEdit.Kind = Terrasoft.Common.DateTimeValueKind.Date;
			return _startDateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateEndDateEdit() {
			_endDateEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_endDateEdit.UId = new Guid("21a671f3-928b-47a7-b087-11358eed6c44");
			_endDateEdit.Name = "EndDateEdit";
			_endDateEdit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_endDateEdit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_endDateEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_endDateEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_endDateEdit.Tag = "";
			_endDateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_endDateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_endDateEdit.Kind = Terrasoft.Common.DateTimeValueKind.Date;
			return _endDateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarPeriodEditControlLayout() {
			_calendarPeriodEditControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarPeriodEditControlLayout.UId = new Guid("127a356e-df4b-4104-9358-a168a660efb8");
			_calendarPeriodEditControlLayout.Name = "CalendarPeriodEditControlLayout";
			_calendarPeriodEditControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarPeriodEditControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarPeriodEditControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarPeriodEditControlLayout.Tag = "";
			_calendarPeriodEditControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_calendarPeriodEditControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_calendarPeriodEditControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarPeriodEditControlLayout.FitHeightByContent = true;
			_calendarPeriodEditControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_calendarPeriodEditControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarPeriodEditControlLayout.StartNewAlignGroup = false;
			_calendarPeriodEditControlLayout.Image = new ControlImage {};
			_calendarPeriodEditControlLayout.Edges = "";
			return _calendarPeriodEditControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarPeriodControlLayout() {
			_calendarPeriodControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarPeriodControlLayout.UId = new Guid("6d5171d6-0360-4b81-9cd7-bf709f1e5de1");
			_calendarPeriodControlLayout.Name = "CalendarPeriodControlLayout";
			_calendarPeriodControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarPeriodControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarPeriodControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarPeriodControlLayout.Tag = "";
			_calendarPeriodControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarPeriodControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarPeriodControlLayout.FitHeightByContent = true;
			_calendarPeriodControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarPeriodControlLayout.StartNewAlignGroup = false;
			_calendarPeriodControlLayout.Image = new ControlImage {};
			_calendarPeriodControlLayout.Edges = "";
			return _calendarPeriodControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateCalendarDaysTreeGrid() {
			_calendarDaysTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_calendarDaysTreeGrid.UId = new Guid("ee928fac-7294-4a5b-a41e-3e18b4beaa72");
			_calendarDaysTreeGrid.Name = "CalendarDaysTreeGrid";
			_calendarDaysTreeGrid.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarDaysTreeGrid.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarDaysTreeGrid.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarDaysTreeGrid.Tag = "";
			_calendarDaysTreeGrid.DataSourceId = "CalendarDaysDataSource";
			_calendarDaysTreeGrid.Edges = "1 1 1 1";
			_calendarDaysTreeGrid.IsColumnAutowidth = true;
			_calendarDaysTreeGrid.FooterVisible = false;
			_calendarDaysTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarDaysTreeGrid.IsSummaryVisible = false;
			_calendarDaysTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarDaysTreeGrid.HideHeaders = false;
			return _calendarDaysTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarLeftControlLayout() {
			_calendarLeftControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarLeftControlLayout.UId = new Guid("f24b98af-827c-4e63-8189-b85be8892b3b");
			_calendarLeftControlLayout.Name = "CalendarLeftControlLayout";
			_calendarLeftControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarLeftControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarLeftControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarLeftControlLayout.Tag = "";
			_calendarLeftControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarLeftControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarLeftControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarLeftControlLayout.StartNewAlignGroup = false;
			_calendarLeftControlLayout.Image = new ControlImage {};
			_calendarLeftControlLayout.Edges = "";
			return _calendarLeftControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsDiffFromParentCalendarEdit() {
			_isDiffFromParentCalendarEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isDiffFromParentCalendarEdit.UId = new Guid("908ac057-f6d8-4a67-9b2c-2b06e4d0b4b2");
			_isDiffFromParentCalendarEdit.Name = "IsDiffFromParentCalendarEdit";
			_isDiffFromParentCalendarEdit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_isDiffFromParentCalendarEdit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_isDiffFromParentCalendarEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_isDiffFromParentCalendarEdit.Tag = "";
			_isDiffFromParentCalendarEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isDiffFromParentCalendarEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isDiffFromParentCalendarEdit.AlignedByCaption = false;
			return _isDiffFromParentCalendarEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateDayTypeCalendarEdit() {
			_dayTypeCalendarEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_dayTypeCalendarEdit.UId = new Guid("fff81c0f-db75-49af-808c-fa83e97fc305");
			_dayTypeCalendarEdit.Name = "DayTypeCalendarEdit";
			_dayTypeCalendarEdit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_dayTypeCalendarEdit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_dayTypeCalendarEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_dayTypeCalendarEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_dayTypeCalendarEdit.Tag = "";
			_dayTypeCalendarEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dayTypeCalendarEdit.Image = new ControlImage {};
			_dayTypeCalendarEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_dayTypeCalendarEdit.Enabled = false;
			return _dayTypeCalendarEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarFrom0Edit() {
			_calendarFrom0Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarFrom0Edit.UId = new Guid("9b65712e-910a-463a-9718-cb5b9d1e74bb");
			_calendarFrom0Edit.Name = "CalendarFrom0Edit";
			_calendarFrom0Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom0Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom0Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarFrom0Edit.Tag = "0";
			_calendarFrom0Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarFrom0Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarFrom0Edit.AlignedByCaption = false;
			_calendarFrom0Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarFrom0Edit.Enabled = false;
			return _calendarFrom0Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarTo0Edit() {
			_calendarTo0Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarTo0Edit.UId = new Guid("7f258fa7-b8cc-4014-8fe6-da40db177194");
			_calendarTo0Edit.Name = "CalendarTo0Edit";
			_calendarTo0Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo0Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo0Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarTo0Edit.Tag = "0";
			_calendarTo0Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarTo0Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarTo0Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarTo0Edit.Enabled = false;
			return _calendarTo0Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarInterval0ControlLayout() {
			_calendarInterval0ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarInterval0ControlLayout.UId = new Guid("0dabeede-3f09-4558-a9bb-c3e0c4ad4a4a");
			_calendarInterval0ControlLayout.Name = "CalendarInterval0ControlLayout";
			_calendarInterval0ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval0ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval0ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarInterval0ControlLayout.Tag = "";
			_calendarInterval0ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_calendarInterval0ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_calendarInterval0ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarInterval0ControlLayout.FitHeightByContent = true;
			_calendarInterval0ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarInterval0ControlLayout.StartNewAlignGroup = false;
			_calendarInterval0ControlLayout.Image = new ControlImage {};
			_calendarInterval0ControlLayout.Edges = "";
			return _calendarInterval0ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarFrom1Edit() {
			_calendarFrom1Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarFrom1Edit.UId = new Guid("de5752a3-ee7a-4589-9a36-a2ec7afc3148");
			_calendarFrom1Edit.Name = "CalendarFrom1Edit";
			_calendarFrom1Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom1Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom1Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarFrom1Edit.Tag = "1";
			_calendarFrom1Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarFrom1Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarFrom1Edit.AlignedByCaption = false;
			_calendarFrom1Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarFrom1Edit.Enabled = false;
			return _calendarFrom1Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarTo1Edit() {
			_calendarTo1Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarTo1Edit.UId = new Guid("901aeb08-3fa0-4628-82ab-5408db234bfc");
			_calendarTo1Edit.Name = "CalendarTo1Edit";
			_calendarTo1Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo1Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo1Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarTo1Edit.Tag = "1";
			_calendarTo1Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarTo1Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarTo1Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarTo1Edit.Enabled = false;
			return _calendarTo1Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarInterval1ControlLayout() {
			_calendarInterval1ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarInterval1ControlLayout.UId = new Guid("1bf449a8-5582-4fca-ae22-8a72e10fd525");
			_calendarInterval1ControlLayout.Name = "CalendarInterval1ControlLayout";
			_calendarInterval1ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval1ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval1ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarInterval1ControlLayout.Tag = "";
			_calendarInterval1ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_calendarInterval1ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_calendarInterval1ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarInterval1ControlLayout.FitHeightByContent = true;
			_calendarInterval1ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarInterval1ControlLayout.StartNewAlignGroup = false;
			_calendarInterval1ControlLayout.Image = new ControlImage {};
			_calendarInterval1ControlLayout.Edges = "";
			return _calendarInterval1ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarFrom2Edit() {
			_calendarFrom2Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarFrom2Edit.UId = new Guid("887afc3f-352b-4fb5-bc56-925d5dc2672c");
			_calendarFrom2Edit.Name = "CalendarFrom2Edit";
			_calendarFrom2Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom2Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom2Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarFrom2Edit.Tag = "2";
			_calendarFrom2Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarFrom2Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarFrom2Edit.AlignedByCaption = false;
			_calendarFrom2Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarFrom2Edit.Enabled = false;
			return _calendarFrom2Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarTo2Edit() {
			_calendarTo2Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarTo2Edit.UId = new Guid("a785afdf-cd41-471c-838b-9073da17e518");
			_calendarTo2Edit.Name = "CalendarTo2Edit";
			_calendarTo2Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo2Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo2Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarTo2Edit.Tag = "2";
			_calendarTo2Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarTo2Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarTo2Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarTo2Edit.Enabled = false;
			return _calendarTo2Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarInterval2ControlLayout() {
			_calendarInterval2ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarInterval2ControlLayout.UId = new Guid("e3159c33-b9d0-4378-9024-509a23b21c68");
			_calendarInterval2ControlLayout.Name = "CalendarInterval2ControlLayout";
			_calendarInterval2ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval2ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval2ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarInterval2ControlLayout.Tag = "";
			_calendarInterval2ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_calendarInterval2ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_calendarInterval2ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarInterval2ControlLayout.FitHeightByContent = true;
			_calendarInterval2ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarInterval2ControlLayout.StartNewAlignGroup = false;
			_calendarInterval2ControlLayout.Image = new ControlImage {};
			_calendarInterval2ControlLayout.Edges = "";
			return _calendarInterval2ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarFrom3Edit() {
			_calendarFrom3Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarFrom3Edit.UId = new Guid("4f8c8e4d-03a2-488b-9176-f4915583a01f");
			_calendarFrom3Edit.Name = "CalendarFrom3Edit";
			_calendarFrom3Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom3Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom3Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarFrom3Edit.Tag = "3";
			_calendarFrom3Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarFrom3Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarFrom3Edit.AlignedByCaption = false;
			_calendarFrom3Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarFrom3Edit.Enabled = false;
			return _calendarFrom3Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarTo3Edit() {
			_calendarTo3Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarTo3Edit.UId = new Guid("fa5c4f30-3f64-4a5e-8149-e1621db97c6d");
			_calendarTo3Edit.Name = "CalendarTo3Edit";
			_calendarTo3Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo3Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo3Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarTo3Edit.Tag = "3";
			_calendarTo3Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarTo3Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarTo3Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarTo3Edit.Enabled = false;
			return _calendarTo3Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarInterval3ControlLayout() {
			_calendarInterval3ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarInterval3ControlLayout.UId = new Guid("ef8b9782-2776-488f-bc1a-8ec1eaf1ca09");
			_calendarInterval3ControlLayout.Name = "CalendarInterval3ControlLayout";
			_calendarInterval3ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval3ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval3ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarInterval3ControlLayout.Tag = "";
			_calendarInterval3ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_calendarInterval3ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_calendarInterval3ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarInterval3ControlLayout.FitHeightByContent = true;
			_calendarInterval3ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarInterval3ControlLayout.StartNewAlignGroup = false;
			_calendarInterval3ControlLayout.Image = new ControlImage {};
			_calendarInterval3ControlLayout.Edges = "";
			return _calendarInterval3ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarFrom4Edit() {
			_calendarFrom4Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarFrom4Edit.UId = new Guid("96bbdc95-5720-4a40-bbcf-8f357ba309d6");
			_calendarFrom4Edit.Name = "CalendarFrom4Edit";
			_calendarFrom4Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom4Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarFrom4Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarFrom4Edit.Tag = "4";
			_calendarFrom4Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarFrom4Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarFrom4Edit.AlignedByCaption = false;
			_calendarFrom4Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarFrom4Edit.Enabled = false;
			return _calendarFrom4Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCalendarTo4Edit() {
			_calendarTo4Edit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_calendarTo4Edit.UId = new Guid("b5be6ad4-156c-4459-ac4f-471bfd334c92");
			_calendarTo4Edit.Name = "CalendarTo4Edit";
			_calendarTo4Edit.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo4Edit.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTo4Edit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarTo4Edit.Tag = "4";
			_calendarTo4Edit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_calendarTo4Edit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarTo4Edit.Kind = Terrasoft.Common.DateTimeValueKind.Time;
			_calendarTo4Edit.Enabled = false;
			return _calendarTo4Edit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarInterval4ControlLayout() {
			_calendarInterval4ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarInterval4ControlLayout.UId = new Guid("279a4234-ee3f-4b42-9fec-8ad14bde5d41");
			_calendarInterval4ControlLayout.Name = "CalendarInterval4ControlLayout";
			_calendarInterval4ControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval4ControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarInterval4ControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarInterval4ControlLayout.Tag = "";
			_calendarInterval4ControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_calendarInterval4ControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_calendarInterval4ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarInterval4ControlLayout.FitHeightByContent = true;
			_calendarInterval4ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarInterval4ControlLayout.StartNewAlignGroup = false;
			_calendarInterval4ControlLayout.Image = new ControlImage {};
			_calendarInterval4ControlLayout.Edges = "";
			return _calendarInterval4ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarIntervalsControlLayout() {
			_calendarIntervalsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarIntervalsControlLayout.UId = new Guid("b5d82a58-9477-43a2-b842-0ad0fb61ecc9");
			_calendarIntervalsControlLayout.Name = "CalendarIntervalsControlLayout";
			_calendarIntervalsControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarIntervalsControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarIntervalsControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarIntervalsControlLayout.Tag = "";
			_calendarIntervalsControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarIntervalsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarIntervalsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarIntervalsControlLayout.StartNewAlignGroup = false;
			_calendarIntervalsControlLayout.Image = new ControlImage {};
			_calendarIntervalsControlLayout.Edges = "";
			_calendarIntervalsControlLayout.Enabled = false;
			return _calendarIntervalsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarRightControlLayout() {
			_calendarRightControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarRightControlLayout.UId = new Guid("94d9aae7-b49b-4d32-a046-27103073afc5");
			_calendarRightControlLayout.Name = "CalendarRightControlLayout";
			_calendarRightControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarRightControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarRightControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarRightControlLayout.Tag = "";
			_calendarRightControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarRightControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarRightControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarRightControlLayout.StartNewAlignGroup = false;
			_calendarRightControlLayout.Image = new ControlImage {};
			_calendarRightControlLayout.Edges = "";
			return _calendarRightControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCalendarControlLayout() {
			_calendarControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_calendarControlLayout.UId = new Guid("1f10a028-5ac6-470f-89f8-2184dab8f542");
			_calendarControlLayout.Name = "CalendarControlLayout";
			_calendarControlLayout.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarControlLayout.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarControlLayout.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarControlLayout.Tag = "";
			_calendarControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_calendarControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_calendarControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_calendarControlLayout.Padding = "5 5 5 5";
			_calendarControlLayout.StartNewAlignGroup = false;
			_calendarControlLayout.Image = new ControlImage {};
			_calendarControlLayout.Edges = "";
			return _calendarControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateCalendarTab() {
			_calendarTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_calendarTab.UId = new Guid("aa10ff65-f62a-45cd-97ef-0f50ba4661b2");
			_calendarTab.Name = "CalendarTab";
			_calendarTab.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTab.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarTab.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarTab.Tag = "";
			_calendarTab.Image = new ControlImage {};
			return _calendarTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateMainTabPanel() {
			_mainTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_mainTabPanel.UId = new Guid("f7b0310c-7fec-407a-b73b-410e0ef53fa2");
			_mainTabPanel.Name = "MainTabPanel";
			_mainTabPanel.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_mainTabPanel.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_mainTabPanel.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_mainTabPanel.Tag = "";
			_mainTabPanel.ActiveTabIndex = 0;
			_mainTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainTabPanel.StartNewAlignGroup = false;
			_mainTabPanel.Collapsible = false;
			_mainTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainTabPanel.Margins = "5 5 5 5";
			return _mainTabPanel;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("3788dc9f-10e3-41a1-ac1b-bccc768afb64");
			DataSource.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("8f58f988-3082-45a7-aa60-3711f2a4cc0b");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("1261f1a5-4327-4b5f-a74c-e378c31f983e");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("1199908e-6ad8-4269-adbe-1dd5d5467dbb");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("cbb13797-07a9-48db-9fa2-30a368658018");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("9555a403-474d-404c-98e8-ff6336e21a42");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("cef95359-9fa6-4450-bbe7-079c10ce4864");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("7345f9bd-9cea-43c5-8dcc-b4fac3fa820e");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("527b9e4e-7dbf-4721-a112-72b423b3365a");
			if (column != null) {
				column.UId = new Guid("81425752-dad5-479a-9ab5-6160ac37f814");
				column.Name = @"Parent";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("a6b1019a-bb90-4bb6-a9aa-9d6ae6d85efd");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b642ae94-288a-475c-8585-1e13a73beb4b");
			if (column != null) {
				column.UId = new Guid("010c3524-f1da-455b-8b92-b4e159b81d83");
				column.Name = @"TimeZone";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("81f7790d-dfee-4027-9a78-5025f58448b5");
			if (column != null) {
				column.UId = new Guid("17889395-5797-466a-a665-21fd8a8b7225");
				column.Name = @"Depth";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateWeekDaysDataSource() {
			_weekDaysDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_weekDaysDataSource.UId = new Guid("a0527fd1-717c-4bce-8056-5a598d507e0f");
			_weekDaysDataSource.Name = "WeekDaysDataSource";
			_weekDaysDataSource.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekDaysDataSource.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekDaysDataSource.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_weekDaysDataSource.Tag = "";
			_weekDaysDataSource.EnableServerActiveRow = true;
			_weekDaysDataSource.SchemaUId = new Guid("13665ad9-ac50-479b-b43c-765d03988626");
			_weekDaysDataSource.HierarchicalDepth = 1;
			_weekDaysDataSource.DefStructure.ID = "c" + _weekDaysDataSource.DefStructure.UId.ToString("N");
			_weekDaysDataSource.DefStructure.UId = new Guid("edb877d3-444a-44e4-8f6b-ba2964c7cb5e");
			_weekDaysDataSource.DefStructure.Name = "DefStructure";
			_weekDaysDataSource.DefStructure.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_weekDaysDataSource.DefStructure.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			DataSourceStructureColumn column = null;
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("c819ad28-6d34-4552-b4b8-2e5a0a0467ad");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("1af5fa6e-d2cd-4304-9d36-a4b90326782c");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("b1461164-a271-4b09-850a-f0daef315d0b");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("591e2b0d-78ef-4a89-9983-d080871e8793");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("bb30fa12-2f61-4c4a-b277-a1639334c8c9");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("54771566-b3ee-4388-9511-7c0d6177cea5");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("5a88c990-9162-4876-875d-dffcb3669f5a");
			if (column != null) {
				column.UId = new Guid("27e45bc2-4aa3-4116-8d38-9bb3a06150b4");
				column.Name = @"DayOfWeek";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("d5ad1bba-36c0-4807-a99e-428d41eb01b6");
			if (column != null) {
				column.UId = new Guid("38f4b0cb-2ebb-408b-8a13-dc0e0cfefb3b");
				column.Name = @"DayType";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("424e20d8-274a-4a9c-b57a-3d189416b40f");
			if (column != null) {
				column.UId = new Guid("728b30d2-c642-4920-b659-cbe7d7937b31");
				column.Name = @"Date";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _weekDaysDataSource.DefStructure.TryAddColumnByMetaPath("e21b29e0-9bc7-40df-bcbb-cee71c414300");
			if (column != null) {
				column.UId = new Guid("ac879cdd-3631-4289-9d90-3f8d4bd75571");
				column.Name = @"Calendar";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			return _weekDaysDataSource;
		}

		protected virtual void UpdateWeekDaysDataSource() {
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateCalendarDaysDataSource() {
			_calendarDaysDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_calendarDaysDataSource.UId = new Guid("f24b78c0-2b12-4fd8-a8bf-1584da4143f0");
			_calendarDaysDataSource.Name = "CalendarDaysDataSource";
			_calendarDaysDataSource.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarDaysDataSource.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarDaysDataSource.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_calendarDaysDataSource.Tag = "";
			_calendarDaysDataSource.EnableServerActiveRow = true;
			_calendarDaysDataSource.SchemaUId = new Guid("13665ad9-ac50-479b-b43c-765d03988626");
			_calendarDaysDataSource.HierarchicalDepth = 1;
			_calendarDaysDataSource.DefStructure.ID = "c" + _calendarDaysDataSource.DefStructure.UId.ToString("N");
			_calendarDaysDataSource.DefStructure.UId = new Guid("56530f54-0b38-4db3-808b-4c362ea86c5a");
			_calendarDaysDataSource.DefStructure.Name = "DefStructure";
			_calendarDaysDataSource.DefStructure.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			_calendarDaysDataSource.DefStructure.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			DataSourceStructureColumn column = null;
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("93516f76-a4ec-4f31-a4d5-b4c9265f6779");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("d898d03c-cf77-4b4d-b13f-3978cda5f15d");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("d67a216b-213d-4eb1-b9d5-595be1cf7332");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("061daa68-4b36-49d9-8979-c9c86eb06509");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("b5afc613-b113-4bec-82ab-7d30f8afbdd1");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("fe091c82-2ab2-4028-a435-393cd048ae38");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("5a88c990-9162-4876-875d-dffcb3669f5a");
			if (column != null) {
				column.UId = new Guid("abc1e60f-54cb-4911-80d5-8c6c4c0a9778");
				column.Name = @"DayOfWeek";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("d5ad1bba-36c0-4807-a99e-428d41eb01b6");
			if (column != null) {
				column.UId = new Guid("43cc916b-78d9-444d-a67b-3bc074fd72da");
				column.Name = @"DayType";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("424e20d8-274a-4a9c-b57a-3d189416b40f");
			if (column != null) {
				column.UId = new Guid("31c417a5-89d9-4c3b-980a-7057cced35f4");
				column.Name = @"Date";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = _calendarDaysDataSource.DefStructure.TryAddColumnByMetaPath("e21b29e0-9bc7-40df-bcbb-cee71c414300");
			if (column != null) {
				column.UId = new Guid("1e2a0d44-6009-496e-9492-3cec8db8ee25");
				column.Name = @"Calendar";
				column.CreatedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.ModifiedInSchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			return _calendarDaysDataSource;
		}

		protected virtual void UpdateCalendarDaysDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new CalendarEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CalendarEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CalendarEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CalendarEditPageEventsProcess

	/// <exclude/>
	public class CalendarEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CalendarEditPageSchemaUserControl
	{

		public CalendarEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CalendarEditPageEventsProcess";
			SchemaUId = new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f0b30978-964a-48d8-b5c2-6a6c7fc4bb04");
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

		public virtual Object CalendarPageHelperState {
			get;
			set;
		}

		public virtual Object WeekPageHelperState {
			get;
			set;
		}

		public virtual string SessinonKeyQuickFilterList {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("ecbdf0d8-a905-40f3-a2c3-d101c28c055a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceSavedStartMessage;
		public ProcessFlowElement DataSourceSavedStartMessage {
			get {
				return _dataSourceSavedStartMessage ?? (_dataSourceSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceSavedStartMessage",
					SchemaElementUId = new Guid("785a80f2-e16c-424b-9b3a-5b48585d1fd5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dataSourceSavedScriptTask;
		public ProcessScriptTask DataSourceSavedScriptTask {
			get {
				return _dataSourceSavedScriptTask ?? (_dataSourceSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DataSourceSavedScriptTask",
					SchemaElementUId = new Guid("c350925e-2a55-45e9-b7cb-3679ec7040ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DataSourceSavedScriptTaskExecute,
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
					SchemaElementUId = new Guid("a0f81d42-340e-418f-af19-5bc6dfc95f71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceSaved",
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
					SchemaElementUId = new Guid("9b36f855-ff21-423f-a840-6662b4bd32de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _saveCalendarDataStartMessage;
		public ProcessFlowElement SaveCalendarDataStartMessage {
			get {
				return _saveCalendarDataStartMessage ?? (_saveCalendarDataStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SaveCalendarDataStartMessage",
					SchemaElementUId = new Guid("a31bf46a-2131-48df-abac-86a0efe192b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _saveCalendarDataScriptTask;
		public ProcessScriptTask SaveCalendarDataScriptTask {
			get {
				return _saveCalendarDataScriptTask ?? (_saveCalendarDataScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveCalendarDataScriptTask",
					SchemaElementUId = new Guid("0a020ffa-99da-45dc-bb55-c6610c769c2e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveCalendarDataScriptTaskExecute,
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
					SchemaElementUId = new Guid("65b3cab4-6e43-4fc1-9b30-52e1fa938e49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _weekDaysTreeGridSelectionChangeStartMessage;
		public ProcessFlowElement WeekDaysTreeGridSelectionChangeStartMessage {
			get {
				return _weekDaysTreeGridSelectionChangeStartMessage ?? (_weekDaysTreeGridSelectionChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WeekDaysTreeGridSelectionChangeStartMessage",
					SchemaElementUId = new Guid("49aa51ee-2a53-4c65-8ca2-ce4bf634a1db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _weekDaysTreeGridSelectionChangeScriptTask;
		public ProcessScriptTask WeekDaysTreeGridSelectionChangeScriptTask {
			get {
				return _weekDaysTreeGridSelectionChangeScriptTask ?? (_weekDaysTreeGridSelectionChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "WeekDaysTreeGridSelectionChangeScriptTask",
					SchemaElementUId = new Guid("172557d4-51aa-4139-80ec-8b0152d440f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = WeekDaysTreeGridSelectionChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("a1521a03-1410-4eba-af52-f2902b690e3e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _calendarDaysTreeGridSelectionChangeStartMessage;
		public ProcessFlowElement CalendarDaysTreeGridSelectionChangeStartMessage {
			get {
				return _calendarDaysTreeGridSelectionChangeStartMessage ?? (_calendarDaysTreeGridSelectionChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CalendarDaysTreeGridSelectionChangeStartMessage",
					SchemaElementUId = new Guid("25794336-98af-474d-9103-ad9854eabec4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _calendarDaysTreeGridSelectionChangeScriptTask;
		public ProcessScriptTask CalendarDaysTreeGridSelectionChangeScriptTask {
			get {
				return _calendarDaysTreeGridSelectionChangeScriptTask ?? (_calendarDaysTreeGridSelectionChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CalendarDaysTreeGridSelectionChangeScriptTask",
					SchemaElementUId = new Guid("6f28b843-1b1f-4d8a-bf37-d2036d4236a8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CalendarDaysTreeGridSelectionChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("7c243399-9348-4a38-93e5-d17870852f1b"),
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
					SchemaElementUId = new Guid("613fd53a-2bbf-4dc2-adf2-131f9411d790"),
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
					SchemaElementUId = new Guid("7ae0875a-bfd2-488b-8670-a112e48f0250"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("e19daf9d-f3df-4372-9607-6a54c7c004c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("1cbadd76-9fb2-4b4e-ac4b-99deba64a91c"),
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
					SchemaElementUId = new Guid("43087361-20e9-4115-a0cc-06c5630ffe9c"),
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
					SchemaElementUId = new Guid("03fecc71-3b5a-49ba-9b5a-a7c46538e271"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initScriptTask;
		public ProcessScriptTask InitScriptTask {
			get {
				return _initScriptTask ?? (_initScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask",
					SchemaElementUId = new Guid("37631aca-42c2-47ee-85bc-aa553fa27adb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
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
					SchemaElementUId = new Guid("da4ab074-dce8-4f7b-9b5e-6e3027d7e51c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dayTypeCalendarEditChangeStartMessage;
		public ProcessFlowElement DayTypeCalendarEditChangeStartMessage {
			get {
				return _dayTypeCalendarEditChangeStartMessage ?? (_dayTypeCalendarEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DayTypeCalendarEditChangeStartMessage",
					SchemaElementUId = new Guid("78ceccc1-1b26-45f5-af43-2829973823ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dayTypeCalendarEditChangeScriptTask;
		public ProcessScriptTask DayTypeCalendarEditChangeScriptTask {
			get {
				return _dayTypeCalendarEditChangeScriptTask ?? (_dayTypeCalendarEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DayTypeCalendarEditChangeScriptTask",
					SchemaElementUId = new Guid("e0b5b28a-5795-4982-9772-eb8f5d7f731b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DayTypeCalendarEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("94ec13d8-1d4f-4563-ac16-087b2841b32e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dayTypeWeekEditChangeStartMessage;
		public ProcessFlowElement DayTypeWeekEditChangeStartMessage {
			get {
				return _dayTypeWeekEditChangeStartMessage ?? (_dayTypeWeekEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DayTypeWeekEditChangeStartMessage",
					SchemaElementUId = new Guid("80a00fbd-5d38-40b6-8d5c-a7ba98352274"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dayTypeWeekEditChangeScriptTask;
		public ProcessScriptTask DayTypeWeekEditChangeScriptTask {
			get {
				return _dayTypeWeekEditChangeScriptTask ?? (_dayTypeWeekEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DayTypeWeekEditChangeScriptTask",
					SchemaElementUId = new Guid("bb819186-e551-4a5e-9e14-7ca6942a2992"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DayTypeWeekEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("5960b74a-305c-4bf8-a49b-a9866e641fde"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startDateEditChangeStartMessage;
		public ProcessFlowElement StartDateEditChangeStartMessage {
			get {
				return _startDateEditChangeStartMessage ?? (_startDateEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartDateEditChangeStartMessage",
					SchemaElementUId = new Guid("78eabbf5-9c92-4347-8ee8-3f5877559b60"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _startDateEditChangeScriptTask;
		public ProcessScriptTask StartDateEditChangeScriptTask {
			get {
				return _startDateEditChangeScriptTask ?? (_startDateEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "StartDateEditChangeScriptTask",
					SchemaElementUId = new Guid("c21c14c4-fe39-4cca-844a-1fa286f2ebdc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = StartDateEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("89e38206-f3cc-494b-a600-dbe8365a6f72"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _endDateEditChangeStartMessage;
		public ProcessFlowElement EndDateEditChangeStartMessage {
			get {
				return _endDateEditChangeStartMessage ?? (_endDateEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EndDateEditChangeStartMessage",
					SchemaElementUId = new Guid("b0f97eee-380e-4690-b157-e5d3defc6edc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _endDateEditChangeScriptTask;
		public ProcessScriptTask EndDateEditChangeScriptTask {
			get {
				return _endDateEditChangeScriptTask ?? (_endDateEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EndDateEditChangeScriptTask",
					SchemaElementUId = new Guid("44dcc6aa-7791-4f75-b935-c23813c42754"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EndDateEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("a736498b-9769-43bf-b954-f11b9b7bc0aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dayButtonClickStartMessage;
		public ProcessFlowElement DayButtonClickStartMessage {
			get {
				return _dayButtonClickStartMessage ?? (_dayButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DayButtonClickStartMessage",
					SchemaElementUId = new Guid("6c8dff4a-eb84-455a-85be-4c06ec2483f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dayButtonClickScriptTask;
		public ProcessScriptTask DayButtonClickScriptTask {
			get {
				return _dayButtonClickScriptTask ?? (_dayButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DayButtonClickScriptTask",
					SchemaElementUId = new Guid("7b661891-8ea6-4614-8bb6-d245e8c16119"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DayButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("29b7e07a-216d-4c19-867e-a9a1313a8a99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _monthButtonClickStartMessage;
		public ProcessFlowElement MonthButtonClickStartMessage {
			get {
				return _monthButtonClickStartMessage ?? (_monthButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MonthButtonClickStartMessage",
					SchemaElementUId = new Guid("983ae739-b53f-487e-bec0-9be64556a623"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _monthButtonClickScriptTask;
		public ProcessScriptTask MonthButtonClickScriptTask {
			get {
				return _monthButtonClickScriptTask ?? (_monthButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MonthButtonClickScriptTask",
					SchemaElementUId = new Guid("2d55a321-c143-4fce-a73e-a23e3351c59b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MonthButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("254b6514-5896-479e-8fdc-1291b06b94e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _weekButtonClickStartMessage;
		public ProcessFlowElement WeekButtonClickStartMessage {
			get {
				return _weekButtonClickStartMessage ?? (_weekButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WeekButtonClickStartMessage",
					SchemaElementUId = new Guid("a07ead2e-ae12-4879-b539-9f28641b021d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _weekButtonClickScriptTask;
		public ProcessScriptTask WeekButtonClickScriptTask {
			get {
				return _weekButtonClickScriptTask ?? (_weekButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "WeekButtonClickScriptTask",
					SchemaElementUId = new Guid("fedfe698-aecf-4dfc-9f90-65a718cb6fb9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = WeekButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("1d7d7b70-cced-4af1-90d6-a2e551dd02f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessStartSignalEvent _periodMenuItemClickStartSignal;
		public ProcessStartSignalEvent PeriodMenuItemClickStartSignal {
			get {
				return _periodMenuItemClickStartSignal ?? (_periodMenuItemClickStartSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "PeriodMenuItemClickStartSignal",
					SerializeToDB = false,
					IsLogging = false,
					SchemaElementUId = new Guid("72979caf-7dfe-4cc7-b2a2-da41fd844a7d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _periodMenuItemClickScriptTask;
		public ProcessScriptTask PeriodMenuItemClickScriptTask {
			get {
				return _periodMenuItemClickScriptTask ?? (_periodMenuItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PeriodMenuItemClickScriptTask",
					SchemaElementUId = new Guid("dbf057e2-9194-49e1-b5bb-2d815bd856c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PeriodMenuItemClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("a2ffad1d-c92d-4f35-b659-7aa32b3edf0e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _periodDaysFilterChangedStartMessage;
		public ProcessFlowElement PeriodDaysFilterChangedStartMessage {
			get {
				return _periodDaysFilterChangedStartMessage ?? (_periodDaysFilterChangedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PeriodDaysFilterChangedStartMessage",
					SchemaElementUId = new Guid("6b67ee33-f551-46f9-8ad8-a79abb3227ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _periodDaysFilterChangedScriptTask;
		public ProcessScriptTask PeriodDaysFilterChangedScriptTask {
			get {
				return _periodDaysFilterChangedScriptTask ?? (_periodDaysFilterChangedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PeriodDaysFilterChangedScriptTask",
					SchemaElementUId = new Guid("f9f5ec3a-7ac2-49d1-866a-648a5f1ed316"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PeriodDaysFilterChangedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[DataSourceSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceSavedStartMessage };
			FlowElements[DataSourceSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceSavedScriptTask };
			FlowElements[DataSourceSavedIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceSavedIntermediateThrowMessageEvent };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SaveCalendarDataStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveCalendarDataStartMessage };
			FlowElements[SaveCalendarDataScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveCalendarDataScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[WeekDaysTreeGridSelectionChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { WeekDaysTreeGridSelectionChangeStartMessage };
			FlowElements[WeekDaysTreeGridSelectionChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { WeekDaysTreeGridSelectionChangeScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[CalendarDaysTreeGridSelectionChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CalendarDaysTreeGridSelectionChangeStartMessage };
			FlowElements[CalendarDaysTreeGridSelectionChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CalendarDaysTreeGridSelectionChangeScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[InitStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage1 };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[DayTypeCalendarEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DayTypeCalendarEditChangeStartMessage };
			FlowElements[DayTypeCalendarEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DayTypeCalendarEditChangeScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[DayTypeWeekEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DayTypeWeekEditChangeStartMessage };
			FlowElements[DayTypeWeekEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DayTypeWeekEditChangeScriptTask };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartDateEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDateEditChangeStartMessage };
			FlowElements[StartDateEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDateEditChangeScriptTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[EndDateEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EndDateEditChangeStartMessage };
			FlowElements[EndDateEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EndDateEditChangeScriptTask };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[DayButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DayButtonClickStartMessage };
			FlowElements[DayButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DayButtonClickScriptTask };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[MonthButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { MonthButtonClickStartMessage };
			FlowElements[MonthButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MonthButtonClickScriptTask };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[WeekButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { WeekButtonClickStartMessage };
			FlowElements[WeekButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { WeekButtonClickScriptTask };
			FlowElements[EventSubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess14 };
			FlowElements[PeriodMenuItemClickStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { PeriodMenuItemClickStartSignal };
			FlowElements[PeriodMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PeriodMenuItemClickScriptTask };
			FlowElements[EventSubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess15 };
			FlowElements[PeriodDaysFilterChangedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PeriodDaysFilterChangedStartMessage };
			FlowElements[PeriodDaysFilterChangedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PeriodDaysFilterChangedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "DataSourceSavedStartMessage":
						e.Context.QueueTasks.Enqueue("DataSourceSavedScriptTask");
						break;
					case "DataSourceSavedScriptTask":
						e.Context.QueueTasks.Enqueue("DataSourceSavedIntermediateThrowMessageEvent");
						break;
					case "DataSourceSavedIntermediateThrowMessageEvent":
						break;
					case "EventSubProcess2":
						break;
					case "SaveCalendarDataStartMessage":
						e.Context.QueueTasks.Enqueue("SaveCalendarDataScriptTask");
						break;
					case "SaveCalendarDataScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "WeekDaysTreeGridSelectionChangeStartMessage":
						e.Context.QueueTasks.Enqueue("WeekDaysTreeGridSelectionChangeScriptTask");
						break;
					case "WeekDaysTreeGridSelectionChangeScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "CalendarDaysTreeGridSelectionChangeStartMessage":
						e.Context.QueueTasks.Enqueue("CalendarDaysTreeGridSelectionChangeScriptTask");
						break;
					case "CalendarDaysTreeGridSelectionChangeScriptTask":
						break;
					case "EventSubProcess5":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcess6":
						break;
					case "InitStartMessage1":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "EventSubProcess7":
						break;
					case "DayTypeCalendarEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("DayTypeCalendarEditChangeScriptTask");
						break;
					case "DayTypeCalendarEditChangeScriptTask":
						break;
					case "EventSubProcess8":
						break;
					case "DayTypeWeekEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("DayTypeWeekEditChangeScriptTask");
						break;
					case "DayTypeWeekEditChangeScriptTask":
						break;
					case "EventSubProcess9":
						break;
					case "StartDateEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("StartDateEditChangeScriptTask");
						break;
					case "StartDateEditChangeScriptTask":
						break;
					case "EventSubProcess10":
						break;
					case "EndDateEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("EndDateEditChangeScriptTask");
						break;
					case "EndDateEditChangeScriptTask":
						break;
					case "EventSubProcess11":
						break;
					case "DayButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("DayButtonClickScriptTask");
						break;
					case "DayButtonClickScriptTask":
						break;
					case "EventSubProcess13":
						break;
					case "MonthButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("MonthButtonClickScriptTask");
						break;
					case "MonthButtonClickScriptTask":
						break;
					case "EventSubProcess12":
						break;
					case "WeekButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("WeekButtonClickScriptTask");
						break;
					case "WeekButtonClickScriptTask":
						break;
					case "EventSubProcess14":
						break;
					case "PeriodMenuItemClickStartSignal":
						e.Context.QueueTasks.Enqueue("PeriodMenuItemClickScriptTask");
						break;
					case "PeriodMenuItemClickScriptTask":
						break;
					case "EventSubProcess15":
						break;
					case "PeriodDaysFilterChangedStartMessage":
						e.Context.QueueTasks.Enqueue("PeriodDaysFilterChangedScriptTask");
						break;
					case "PeriodDaysFilterChangedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DataSourceSavedStartMessage");
			ActivatedEventElements.Add("SaveCalendarDataStartMessage");
			ActivatedEventElements.Add("WeekDaysTreeGridSelectionChangeStartMessage");
			ActivatedEventElements.Add("CalendarDaysTreeGridSelectionChangeStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("InitStartMessage1");
			ActivatedEventElements.Add("DayTypeCalendarEditChangeStartMessage");
			ActivatedEventElements.Add("DayTypeWeekEditChangeStartMessage");
			ActivatedEventElements.Add("StartDateEditChangeStartMessage");
			ActivatedEventElements.Add("EndDateEditChangeStartMessage");
			ActivatedEventElements.Add("DayButtonClickStartMessage");
			ActivatedEventElements.Add("MonthButtonClickStartMessage");
			ActivatedEventElements.Add("WeekButtonClickStartMessage");
			ActivatedEventElements.Add("PeriodMenuItemClickStartSignal");
			ActivatedEventElements.Add("PeriodDaysFilterChangedStartMessage");
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
				case "DataSourceSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceSavedStartMessage";
					result = DataSourceSavedStartMessage.Execute(context);
					break;
				case "DataSourceSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceSavedScriptTask";
					result = DataSourceSavedScriptTask.Execute(context, DataSourceSavedScriptTaskExecute);
					break;
				case "DataSourceSavedIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceSaved");
					result = DataSourceSavedIntermediateThrowMessageEvent.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SaveCalendarDataStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveCalendarDataStartMessage";
					result = SaveCalendarDataStartMessage.Execute(context);
					break;
				case "SaveCalendarDataScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveCalendarDataScriptTask";
					result = SaveCalendarDataScriptTask.Execute(context, SaveCalendarDataScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "WeekDaysTreeGridSelectionChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "WeekDaysTreeGridSelectionChangeStartMessage";
					result = WeekDaysTreeGridSelectionChangeStartMessage.Execute(context);
					break;
				case "WeekDaysTreeGridSelectionChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "WeekDaysTreeGridSelectionChangeScriptTask";
					result = WeekDaysTreeGridSelectionChangeScriptTask.Execute(context, WeekDaysTreeGridSelectionChangeScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "CalendarDaysTreeGridSelectionChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CalendarDaysTreeGridSelectionChangeStartMessage";
					result = CalendarDaysTreeGridSelectionChangeStartMessage.Execute(context);
					break;
				case "CalendarDaysTreeGridSelectionChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CalendarDaysTreeGridSelectionChangeScriptTask";
					result = CalendarDaysTreeGridSelectionChangeScriptTask.Execute(context, CalendarDaysTreeGridSelectionChangeScriptTaskExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "EventSubProcess6":
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
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "DayTypeCalendarEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DayTypeCalendarEditChangeStartMessage";
					result = DayTypeCalendarEditChangeStartMessage.Execute(context);
					break;
				case "DayTypeCalendarEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DayTypeCalendarEditChangeScriptTask";
					result = DayTypeCalendarEditChangeScriptTask.Execute(context, DayTypeCalendarEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "DayTypeWeekEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DayTypeWeekEditChangeStartMessage";
					result = DayTypeWeekEditChangeStartMessage.Execute(context);
					break;
				case "DayTypeWeekEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DayTypeWeekEditChangeScriptTask";
					result = DayTypeWeekEditChangeScriptTask.Execute(context, DayTypeWeekEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartDateEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDateEditChangeStartMessage";
					result = StartDateEditChangeStartMessage.Execute(context);
					break;
				case "StartDateEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDateEditChangeScriptTask";
					result = StartDateEditChangeScriptTask.Execute(context, StartDateEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "EndDateEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EndDateEditChangeStartMessage";
					result = EndDateEditChangeStartMessage.Execute(context);
					break;
				case "EndDateEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EndDateEditChangeScriptTask";
					result = EndDateEditChangeScriptTask.Execute(context, EndDateEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DayButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DayButtonClickStartMessage";
					result = DayButtonClickStartMessage.Execute(context);
					break;
				case "DayButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DayButtonClickScriptTask";
					result = DayButtonClickScriptTask.Execute(context, DayButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "MonthButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "MonthButtonClickStartMessage";
					result = MonthButtonClickStartMessage.Execute(context);
					break;
				case "MonthButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MonthButtonClickScriptTask";
					result = MonthButtonClickScriptTask.Execute(context, MonthButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "WeekButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "WeekButtonClickStartMessage";
					result = WeekButtonClickStartMessage.Execute(context);
					break;
				case "WeekButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "WeekButtonClickScriptTask";
					result = WeekButtonClickScriptTask.Execute(context, WeekButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess14":
					context.QueueTasks.Dequeue();
					break;
				case "PeriodMenuItemClickStartSignal":
					context.QueueTasks.Dequeue();
					context.SenderName = "PeriodMenuItemClickStartSignal";
					result = PeriodMenuItemClickStartSignal.Execute(context);
					break;
				case "PeriodMenuItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PeriodMenuItemClickScriptTask";
					result = PeriodMenuItemClickScriptTask.Execute(context, PeriodMenuItemClickScriptTaskExecute);
					break;
				case "EventSubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "PeriodDaysFilterChangedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PeriodDaysFilterChangedStartMessage";
					result = PeriodDaysFilterChangedStartMessage.Execute(context);
					break;
				case "PeriodDaysFilterChangedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PeriodDaysFilterChangedScriptTask";
					result = PeriodDaysFilterChangedScriptTask.Execute(context, PeriodDaysFilterChangedScriptTaskExecute);
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
				case "SessinonKeyQuickFilterList":
					SessinonKeyQuickFilterList = reader.GetValue<System.String>();
				break;
				case "WeekPageHelperState":
					WeekPageHelperState = reader.GetSerializableObjectValue();
				break;
				case "CalendarPageHelperState":
					CalendarPageHelperState = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool DataSourceSavedScriptTaskExecute(ProcessExecutingContext context) {
			var calendarPageHelper = GetCalendarPageHelper();
			var weekPageHelper = GetWeekPageHelper();
			calendarPageHelper.HandleDataSourceSaved();
			weekPageHelper.HandleDataSourceSaved();
			SaveCalendarPageHelperState(calendarPageHelper);
			SaveWeekPageHelperState(weekPageHelper);
			return true;
		}

		public virtual bool SaveCalendarDataScriptTaskExecute(ProcessExecutingContext context) {
			var calendarPageHelper = GetCalendarPageHelper();
			var weekPageHelper = GetWeekPageHelper();
			calendarPageHelper.HandleDataSourceSaved();
			weekPageHelper.HandleDataSourceSaved();
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool WeekDaysTreeGridSelectionChangeScriptTaskExecute(ProcessExecutingContext context) {
			var weekPageHelper = GetWeekPageHelper();
			weekPageHelper.HandleTreeGridSelectionChange();
			SaveWeekPageHelperState(weekPageHelper);
			return true;
		}

		public virtual bool CalendarDaysTreeGridSelectionChangeScriptTaskExecute(ProcessExecutingContext context) {
			var calendarPageHelper = GetCalendarPageHelper();
			calendarPageHelper.HandleTreeGridSelectionChange();
			SaveCalendarPageHelperState(calendarPageHelper);
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			var calendarPageHelper = GetCalendarPageHelper();
			var weekPageHelper = GetWeekPageHelper();
			calendarPageHelper.HandlePageLoadComplete();
			weekPageHelper.HandlePageLoadComplete();
			SaveCalendarPageHelperState(calendarPageHelper);
			SaveWeekPageHelperState(weekPageHelper);
			FilterMenuItemClick(@"week&0");
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			SetPeriodButtonsSignal();
			var calendarPageHelper = GetCalendarPageHelper();
			var weekPageHelper = GetWeekPageHelper();
			calendarPageHelper.HandleInit();
			weekPageHelper.HandleInit();
			SaveCalendarPageHelperState(calendarPageHelper);
			SaveWeekPageHelperState(weekPageHelper);
			return true;
		}

		public virtual bool DayTypeCalendarEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var calendarPageHelper = GetCalendarPageHelper();
			calendarPageHelper.HandleDayTypeEditChange();
			SaveCalendarPageHelperState(calendarPageHelper);
			return true;
		}

		public virtual bool DayTypeWeekEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var weekPageHelper = GetWeekPageHelper();
			weekPageHelper.HandleDayTypeEditChange();
			SaveWeekPageHelperState(weekPageHelper);
			return true;
		}

		public virtual bool StartDateEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var startDate = Page.StartDateEdit.SelectedDate;
			var endDate = Page.EndDateEdit.SelectedDate;
			if (startDate != DateTime.MinValue && endDate != DateTime.MinValue && (endDate - startDate).TotalDays > 366) {
				Page.EndDateEdit.SuspendAjaxEvents();
				Page.EndDateEdit.SelectedDate = startDate.AddYears(1);
				Page.EndDateEdit.ResumeAjaxEvents();
			}
			
			var calendarPageHelper = GetCalendarPageHelper();
			calendarPageHelper.HandleDatesChange();
			SaveCalendarPageHelperState(calendarPageHelper);
			return true;
		}

		public virtual bool EndDateEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var startDate = Page.StartDateEdit.SelectedDate;
			var endDate = Page.EndDateEdit.SelectedDate;
			if (startDate != DateTime.MinValue && endDate != DateTime.MinValue && (endDate - startDate).TotalDays > 366) {
				Page.StartDateEdit.SuspendAjaxEvents();
				Page.StartDateEdit.SelectedDate = endDate.AddYears(-1);
				Page.StartDateEdit.ResumeAjaxEvents();
			}
			
			var calendarPageHelper = GetCalendarPageHelper();
			calendarPageHelper.HandleDatesChange();
			SaveCalendarPageHelperState(calendarPageHelper);
			return true;
		}

		public virtual bool DayButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			FilterMenuItemClick(@"day&0");
			return true;
		}

		public virtual bool MonthButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			FilterMenuItemClick(@"month&0");
			return true;
		}

		public virtual bool WeekButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			FilterMenuItemClick(@"week&0");
			return true;
		}

		public virtual bool PeriodMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			var s = (context.ThrowEventArgs  as Dictionary<string,object>)["tag"].ToString();
			FilterMenuItemClick(s);
			return true;
		}

		public virtual bool PeriodDaysFilterChangedScriptTaskExecute(ProcessExecutingContext context) {
			var calendarPageHelper = GetCalendarPageHelper();
			calendarPageHelper.HandleDatesChange();
			SaveCalendarPageHelperState(calendarPageHelper);
			return true;
		}

		public override void OkClickMethod() {
			NeedRefreshGrid = true;
			var script = @"if (window.validateCalendarControls() && window.validateWeekControls()) {{
				if ({0}.activeRow.modifiedValues) {{
					{0}.save(); 
				}} else {{ 
					window.Terrasoft.AjaxMethods.ThrowClientEvent('{1}', 'SaveCalendarData'); 
				}}
			}}";
			
			Page.ScriptManager.AddScript(string.Format(script, Page.DataSource.ClientID, InstanceUId));
		}

		public virtual TSConfiguration.CalendarHelperCalendarEditPage GetCalendarPageHelper() {
			var editPageHelper = new TSConfiguration.CalendarHelperCalendarEditPage();
			if (CalendarPageHelperState != null) {
				editPageHelper.LoadHelperState((TSConfiguration.HelperCalendarEditPageState)CalendarPageHelperState);
			}
			
			editPageHelper.UpdatePageControl(Page, UserConnection, InstanceUId);
			return editPageHelper;
		}

		public virtual TSConfiguration.WeekHelperCalendarEditPage GetWeekPageHelper() {
			var editPageHelper = new TSConfiguration.WeekHelperCalendarEditPage();
			if (WeekPageHelperState != null) {
				editPageHelper.LoadHelperState((TSConfiguration.HelperCalendarEditPageState) WeekPageHelperState);
			}
			
			editPageHelper.UpdatePageControl(Page, UserConnection, InstanceUId);
			return editPageHelper;
		}

		public virtual void SaveCalendarPageHelperState(TSConfiguration.BaseHelperCalendarEditPage pageHelper) {
			CalendarPageHelperState = pageHelper.GetHelperState();
		}

		public virtual void SaveWeekPageHelperState(TSConfiguration.BaseHelperCalendarEditPage pageHelper) {
			WeekPageHelperState = pageHelper.GetHelperState();
		}

		public virtual void FilterMenuItemClick(string parameters) {
			string[] filterParameters = parameters.Split('&');
			if (filterParameters.Length == 2)
			{
				DateTime startDate = DateTime.Today;
				DateTime endDate = DateTime.Today;
				var period = filterParameters[0];
				var value = Convert.ToInt32(filterParameters[1]);
				switch (period)
				{
					case "day":
						startDate = startDate.AddDays(value);
						endDate = startDate;
						break;
					case "week":
						DayOfWeek day = DateTime.Today.DayOfWeek;
						int days = day - DayOfWeek.Monday;
						if ((int)day == 0)
						{
							days = 6;
						}
						startDate = startDate.AddDays(-days + value * 7);
						endDate = startDate.AddDays(6);
						break;
					case "month":
						startDate = startDate.AddDays(1 - startDate.Day).AddMonths(value);
						endDate = startDate.AddMonths(1).AddDays(-1);
						break;
				}
				Page.StartDateEdit.SuspendAjaxEvents();
				Page.EndDateEdit.SuspendAjaxEvents();
				Page.StartDateEdit.SuspendEvents();
				Page.EndDateEdit.SuspendEvents();
				
				Page.StartDateEdit.SetValue(startDate);
				Page.EndDateEdit.SetValue(endDate);
				
				Page.StartDateEdit.Value = startDate;
				Page.EndDateEdit.Value = endDate;
			
				Page.StartDateEdit.ResumeAjaxEvents();
				Page.EndDateEdit.ResumeAjaxEvents();
				Page.StartDateEdit.ResumeEvents();
				Page.EndDateEdit.ResumeEvents();
			
				const string throwEventScript = @"if (window.validateCalendarControls()) {{
					Terrasoft.AjaxMethods.ThrowClientEventWithMask('{0}', 'PeriodDaysFilterChanged');
				}}";
				Page.AddScript(string.Format(throwEventScript, InstanceUId));
			}
		}

		public virtual void SetPeriodButtonsSignal() {
			foreach (var menuItem in Page.DayButton.Menu)
			{
				((Terrasoft.UI.WebControls.Controls.MenuItem)menuItem).AjaxEvents.Click.SignalName = "PeriodMenuItemClick";
			}
			foreach (var menuItem in Page.WeekButton.Menu)
			{
				((Terrasoft.UI.WebControls.Controls.MenuItem)menuItem).AjaxEvents.Click.SignalName = "PeriodMenuItemClick";
			}
			foreach (var menuItem in Page.MonthButton.Menu)
			{
				((Terrasoft.UI.WebControls.Controls.MenuItem)menuItem).AjaxEvents.Click.SignalName = "PeriodMenuItemClick";
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DataSourceSaved":
							if (ActivatedEventElements.Contains("DataSourceSavedStartMessage")) {
							context.QueueTasks.Enqueue("DataSourceSavedStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "SaveCalendarData":
							if (ActivatedEventElements.Contains("SaveCalendarDataStartMessage")) {
							context.QueueTasks.Enqueue("SaveCalendarDataStartMessage");
						}
						break;
					case "WeekDaysTreeGridSelectionChange":
							if (ActivatedEventElements.Contains("WeekDaysTreeGridSelectionChangeStartMessage")) {
							context.QueueTasks.Enqueue("WeekDaysTreeGridSelectionChangeStartMessage");
						}
						break;
					case "CalendarDaysTreeGridSelectionChange":
							if (ActivatedEventElements.Contains("CalendarDaysTreeGridSelectionChangeStartMessage")) {
							context.QueueTasks.Enqueue("CalendarDaysTreeGridSelectionChangeStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage1")) {
							context.QueueTasks.Enqueue("InitStartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "DayTypeCalendarEditChange":
							if (ActivatedEventElements.Contains("DayTypeCalendarEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("DayTypeCalendarEditChangeStartMessage");
						}
						break;
					case "DayTypeWeekEditChange":
							if (ActivatedEventElements.Contains("DayTypeWeekEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("DayTypeWeekEditChangeStartMessage");
						}
						break;
					case "StartDateEditChange":
							if (ActivatedEventElements.Contains("StartDateEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("StartDateEditChangeStartMessage");
						}
						break;
					case "EndDateEditChange":
							if (ActivatedEventElements.Contains("EndDateEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("EndDateEditChangeStartMessage");
						}
						break;
					case "DayButtonClick":
							if (ActivatedEventElements.Contains("DayButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("DayButtonClickStartMessage");
						}
						break;
					case "MonthButtonClick":
							if (ActivatedEventElements.Contains("MonthButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("MonthButtonClickStartMessage");
						}
						break;
					case "WeekButtonClick":
							if (ActivatedEventElements.Contains("WeekButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("WeekButtonClickStartMessage");
						}
						break;
					case "PeriodMenuItemClick":
							if (ActivatedEventElements.Contains("PeriodMenuItemClickStartSignal")) {
							context.QueueTasks.Enqueue("PeriodMenuItemClickStartSignal");
						}
						break;
					case "PeriodDaysFilterChanged":
							if (ActivatedEventElements.Contains("PeriodDaysFilterChangedStartMessage")) {
							context.QueueTasks.Enqueue("PeriodDaysFilterChangedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SessinonKeyQuickFilterList") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SessinonKeyQuickFilterList", SessinonKeyQuickFilterList, null);
			}
			if (WeekPageHelperState != null) {
				if (WeekPageHelperState.GetType().IsSerializable ||
					WeekPageHelperState.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("WeekPageHelperState", WeekPageHelperState, null);
				}
			}
			if (CalendarPageHelperState != null) {
				if (CalendarPageHelperState.GetType().IsSerializable ||
					CalendarPageHelperState.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("CalendarPageHelperState", CalendarPageHelperState, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: CalendarEditPageEventsProcess

	/// <exclude/>
	public class CalendarEditPageEventsProcess : CalendarEditPageEventsProcess<Terrasoft.WebApp.CalendarEditPageSchemaUserControl>
	{

		public CalendarEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CalendarEditPageSchemaUserControl

	/// <exclude/>
	public partial class CalendarEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit TimeZoneEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("TimeZoneEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel MainTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("MainTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab WorkingWeekTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("WorkingWeekTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout WorkingWeekControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("WorkingWeekControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout WorkingWeekLeftControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("WorkingWeekLeftControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid WeekDaysTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("WeekDaysTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout WorkingWeekRightControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("WorkingWeekRightControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsDiffFromParentWeekEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsDiffFromParentWeekEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit DayTypeWeekEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("DayTypeWeekEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekIntervalsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("WeekIntervalsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval0ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("WeekInterval0ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom0Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekFrom0Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo0Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekTo0Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval1ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("WeekInterval1ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom1Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekFrom1Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo1Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekTo1Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval2ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("WeekInterval2ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom2Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekFrom2Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo2Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekTo2Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval3ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("WeekInterval3ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom3Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekFrom3Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo3Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekTo3Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout WeekInterval4ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("WeekInterval4ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekFrom4Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekFrom4Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit WeekTo4Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("WeekTo4Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab CalendarTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("CalendarTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarLeftControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarLeftControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarPeriodControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarPeriodControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarPeriodButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarPeriodButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label CalendarPeriodLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("CalendarPeriodLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DayButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DayButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem YesterdayItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("YesterdayItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem TodayItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("TodayItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem TomorowItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("TomorowItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button WeekButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("WeekButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem LastWeekItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("LastWeekItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem CurrentWeekItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("CurrentWeekItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem NextWeekItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("NextWeekItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button MonthButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("MonthButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem LastMonthItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("LastMonthItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem CurrentMonthItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("CurrentMonthItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem NextMonthItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("NextMonthItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarPeriodEditControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarPeriodEditControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit StartDateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("StartDateEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit EndDateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("EndDateEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid CalendarDaysTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("CalendarDaysTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarRightControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarRightControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsDiffFromParentCalendarEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsDiffFromParentCalendarEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit DayTypeCalendarEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("DayTypeCalendarEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarIntervalsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarIntervalsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval0ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarInterval0ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom0Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarFrom0Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo0Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarTo0Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval1ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarInterval1ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom1Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarFrom1Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo1Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarTo1Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval2ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarInterval2ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom2Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarFrom2Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo2Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarTo2Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval3ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarInterval3ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom3Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarFrom3Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo3Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarTo3Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CalendarInterval4ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CalendarInterval4ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarFrom4Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarFrom4Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CalendarTo4Edit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CalendarTo4Edit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource WeekDaysDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("WeekDaysDataSource", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource CalendarDaysDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("CalendarDaysDataSource", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DayTypeWeekEdit.AjaxEvents.Change.Event += DayTypeWeekEditChange;
			DayButton.AjaxEvents.Click.Event += DayButtonClick;
			WeekButton.AjaxEvents.Click.Event += WeekButtonClick;
			MonthButton.AjaxEvents.Click.Event += MonthButtonClick;
			StartDateEdit.AjaxEvents.Change.Event += StartDateEditChange;
			EndDateEdit.AjaxEvents.Change.Event += EndDateEditChange;
			DayTypeCalendarEdit.AjaxEvents.Change.Event += DayTypeCalendarEditChange;
			DataSource.SaveRow += DataSourceSaved;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DayTypeWeekEdit.AjaxEvents.Change.Event -= DayTypeWeekEditChange;
			DayButton.AjaxEvents.Click.Event -= DayButtonClick;
			WeekButton.AjaxEvents.Click.Event -= WeekButtonClick;
			MonthButton.AjaxEvents.Click.Event -= MonthButtonClick;
			StartDateEdit.AjaxEvents.Change.Event -= StartDateEditChange;
			EndDateEdit.AjaxEvents.Change.Event -= EndDateEditChange;
			DayTypeCalendarEdit.AjaxEvents.Change.Event -= DayTypeCalendarEditChange;
			DataSource.SaveRow -= DataSourceSaved;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (CalendarEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CalendarEditPageEventsProcess(UserConnection);
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

		public virtual void DayTypeWeekEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("DayTypeWeekEditChange");
		}

		public virtual void DayButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DayButtonClick");
		}

		public virtual void WeekButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("WeekButtonClick");
		}

		public virtual void MonthButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("MonthButtonClick");
		}

		public virtual void StartDateEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("StartDateEditChange");
		}

		public virtual void EndDateEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("EndDateEditChange");
		}

		public virtual void DayTypeCalendarEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("DayTypeCalendarEditChange");
		}

		public virtual void DataSourceSaved(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceSaved");
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
			SchemaName = "CalendarEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CalendarEditPageEventsProcessSchema

	/// <exclude/>
	public class CalendarEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CalendarEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CalendarEditPageEventsProcessSchema(CalendarEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CalendarEditPageEventsProcess";
			UId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
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

		protected virtual ProcessSchemaParameter CreateCalendarPageHelperStateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("67a23238-6bc1-48c8-a0f8-dd3e60ddd26d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"CalendarPageHelperState",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateWeekPageHelperStateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b762b768-c15c-40bc-939f-eb283421c76d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"WeekPageHelperState",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSessinonKeyQuickFilterListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("49261b2d-e315-463b-8588-2f8da8425b60"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"SessinonKeyQuickFilterList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCalendarPageHelperStateParameter());
			Parameters.Add(CreateWeekPageHelperStateParameter());
			Parameters.Add(CreateSessinonKeyQuickFilterListParameter());
		}

		protected virtual void InitializePeriodMenuItemClickStartSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a4d6d29b-2f7d-4eff-b687-cdae5bc90247"),
				ContainerUId = new Guid("72979caf-7dfe-4cc7-b2a2-da41fd844a7d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("72979caf-7dfe-4cc7-b2a2-da41fd844a7d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"RecordId",
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
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaLane schemaLane6 = CreateLane6Lane();
			schemaLaneSet1.Lanes.Add(schemaLane6);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
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
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess14 = CreateEventSubProcess14EventSubProcess();
			FlowElements.Add(eventsubprocess14);
			ProcessSchemaEventSubProcess eventsubprocess15 = CreateEventSubProcess15EventSubProcess();
			FlowElements.Add(eventsubprocess15);
			ProcessSchemaStartMessageEvent datasourcesavedstartmessage = CreateDataSourceSavedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(datasourcesavedstartmessage);
			ProcessSchemaScriptTask datasourcesavedscripttask = CreateDataSourceSavedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(datasourcesavedscripttask);
			ProcessSchemaIntermediateThrowMessageEvent datasourcesavedintermediatethrowmessageevent = CreateDataSourceSavedIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(datasourcesavedintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent savecalendardatastartmessage = CreateSaveCalendarDataStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(savecalendardatastartmessage);
			ProcessSchemaScriptTask savecalendardatascripttask = CreateSaveCalendarDataScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(savecalendardatascripttask);
			ProcessSchemaStartMessageEvent weekdaystreegridselectionchangestartmessage = CreateWeekDaysTreeGridSelectionChangeStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(weekdaystreegridselectionchangestartmessage);
			ProcessSchemaScriptTask weekdaystreegridselectionchangescripttask = CreateWeekDaysTreeGridSelectionChangeScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(weekdaystreegridselectionchangescripttask);
			ProcessSchemaStartMessageEvent calendardaystreegridselectionchangestartmessage = CreateCalendarDaysTreeGridSelectionChangeStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(calendardaystreegridselectionchangestartmessage);
			ProcessSchemaScriptTask calendardaystreegridselectionchangescripttask = CreateCalendarDaysTreeGridSelectionChangeScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(calendardaystreegridselectionchangescripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent = CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess5.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent initstartmessage1 = CreateInitStartMessage1StartMessageEvent();
			eventsubprocess6.FlowElements.Add(initstartmessage1);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(initintermediatethrowmessageevent);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent daytypecalendareditchangestartmessage = CreateDayTypeCalendarEditChangeStartMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(daytypecalendareditchangestartmessage);
			ProcessSchemaScriptTask daytypecalendareditchangescripttask = CreateDayTypeCalendarEditChangeScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(daytypecalendareditchangescripttask);
			ProcessSchemaStartMessageEvent daytypeweekeditchangestartmessage = CreateDayTypeWeekEditChangeStartMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(daytypeweekeditchangestartmessage);
			ProcessSchemaScriptTask daytypeweekeditchangescripttask = CreateDayTypeWeekEditChangeScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(daytypeweekeditchangescripttask);
			ProcessSchemaStartMessageEvent startdateeditchangestartmessage = CreateStartDateEditChangeStartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(startdateeditchangestartmessage);
			ProcessSchemaScriptTask startdateeditchangescripttask = CreateStartDateEditChangeScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(startdateeditchangescripttask);
			ProcessSchemaStartMessageEvent enddateeditchangestartmessage = CreateEndDateEditChangeStartMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(enddateeditchangestartmessage);
			ProcessSchemaScriptTask enddateeditchangescripttask = CreateEndDateEditChangeScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(enddateeditchangescripttask);
			ProcessSchemaStartMessageEvent daybuttonclickstartmessage = CreateDayButtonClickStartMessageStartMessageEvent();
			eventsubprocess11.FlowElements.Add(daybuttonclickstartmessage);
			ProcessSchemaScriptTask daybuttonclickscripttask = CreateDayButtonClickScriptTaskScriptTask();
			eventsubprocess11.FlowElements.Add(daybuttonclickscripttask);
			ProcessSchemaStartMessageEvent monthbuttonclickstartmessage = CreateMonthButtonClickStartMessageStartMessageEvent();
			eventsubprocess13.FlowElements.Add(monthbuttonclickstartmessage);
			ProcessSchemaScriptTask monthbuttonclickscripttask = CreateMonthButtonClickScriptTaskScriptTask();
			eventsubprocess13.FlowElements.Add(monthbuttonclickscripttask);
			ProcessSchemaStartMessageEvent weekbuttonclickstartmessage = CreateWeekButtonClickStartMessageStartMessageEvent();
			eventsubprocess12.FlowElements.Add(weekbuttonclickstartmessage);
			ProcessSchemaScriptTask weekbuttonclickscripttask = CreateWeekButtonClickScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(weekbuttonclickscripttask);
			ProcessSchemaStartSignalEvent periodmenuitemclickstartsignal = CreatePeriodMenuItemClickStartSignalStartSignalEvent();
			eventsubprocess14.FlowElements.Add(periodmenuitemclickstartsignal);
			ProcessSchemaScriptTask periodmenuitemclickscripttask = CreatePeriodMenuItemClickScriptTaskScriptTask();
			eventsubprocess14.FlowElements.Add(periodmenuitemclickscripttask);
			ProcessSchemaStartMessageEvent perioddaysfilterchangedstartmessage = CreatePeriodDaysFilterChangedStartMessageStartMessageEvent();
			eventsubprocess15.FlowElements.Add(perioddaysfilterchangedstartmessage);
			ProcessSchemaScriptTask perioddaysfilterchangedscripttask = CreatePeriodDaysFilterChangedScriptTaskScriptTask();
			eventsubprocess15.FlowElements.Add(perioddaysfilterchangedscripttask);
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
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a0df9769-502e-4fa9-bb85-db2468274d47"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("785a80f2-e16c-424b-9b3a-5b48585d1fd5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c350925e-2a55-45e9-b7cb-3679ec7040ae"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0b3082fe-8d08-42eb-ac25-f7dc4360f33c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(254, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c350925e-2a55-45e9-b7cb-3679ec7040ae"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a0f81d42-340e-418f-af19-5bc6dfc95f71"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("8c917b61-714b-4ffd-96be-d00f851d8d51"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(530, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a31bf46a-2131-48df-abac-86a0efe192b2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0a020ffa-99da-45dc-bb55-c6610c769c2e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("747a680e-45ce-4127-9f76-71aece6ffca2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("49aa51ee-2a53-4c65-8ca2-ce4bf634a1db"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("172557d4-51aa-4139-80ec-8b0152d440f3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("55227a0b-ffae-4708-a466-3e5ac22465fb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("25794336-98af-474d-9103-ad9854eabec4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6f28b843-1b1f-4d8a-bf37-d2036d4236a8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("27ced066-941a-481d-8dae-374e15817b7b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(164, 89),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("613fd53a-2bbf-4dc2-adf2-131f9411d790"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ae0875a-bfd2-488b-8670-a112e48f0250"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("533c8e4c-736d-46d9-856f-208dd4aa2d9b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(280, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ae0875a-bfd2-488b-8670-a112e48f0250"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e19daf9d-f3df-4372-9607-6a54c7c004c1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("a7eed002-6aea-44d9-b591-169ae4f25e8d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(547, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("43087361-20e9-4115-a0cc-06c5630ffe9c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03fecc71-3b5a-49ba-9b5a-a7c46538e271"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("4c1e1d6d-702c-47bd-9548-9d78f25c544f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(666, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03fecc71-3b5a-49ba-9b5a-a7c46538e271"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("37631aca-42c2-47ee-85bc-aa553fa27adb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("d2340acf-8865-47e5-a3f3-bde9e6a4d929"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("78ceccc1-1b26-45f5-af43-2829973823ec"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e0b5b28a-5795-4982-9772-eb8f5d7f731b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("98076594-8fd7-4c2f-b229-229d4443012e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("80a00fbd-5d38-40b6-8d5c-a7ba98352274"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb819186-e551-4a5e-9e14-7ca6942a2992"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("4bb67eb5-f689-4f0e-a594-95ba624381a4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("78eabbf5-9c92-4347-8ee8-3f5877559b60"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c21c14c4-fe39-4cca-844a-1fa286f2ebdc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("ec76780f-bb10-450d-89b1-086dfbbb1bed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0f97eee-380e-4690-b157-e5d3defc6edc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("44dcc6aa-7791-4f75-b935-c23813c42754"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("07bcb338-6eeb-473c-9a6e-39c57353a942"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6c8dff4a-eb84-455a-85be-4c06ec2483f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b661891-8ea6-4614-8bb6-d245e8c16119"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("6d25391f-1654-47d0-b14a-44ea19f19748"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a07ead2e-ae12-4879-b539-9f28641b021d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fedfe698-aecf-4dfc-9f90-65a718cb6fb9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("e5845a83-0b32-41f4-9a2b-58ea48c79102"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("983ae739-b53f-487e-bec0-9be64556a623"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d55a321-c143-4fce-a73e-a23e3351c59b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("05ce234a-0ac1-498d-b9a8-8434fb36cb66"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(152, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("72979caf-7dfe-4cc7-b2a2-da41fd844a7d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dbf057e2-9194-49e1-b5bb-2d815bd856c5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("7af682dc-2490-4053-96be-9be48faa55de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CurveCenterPosition = new Point(451, 250),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b67ee33-f551-46f9-8ad8-a79abb3227ab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9f5ec3a-7ac2-49d1-866a-648a5f1ed316"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("70905696-3340-4c93-8356-107102c2fd19"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1446, 1202),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("db8fd90e-3dd9-47a9-b90f-cf047852e9ac"),
				ContainerItemIndex = 6,
				ContainerUId = new Guid("70905696-3340-4c93-8356-107102c2fd19"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"Lane1",
				Position = new Point(29, 1025),
				Size = new Size(1417, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("246d45d0-5638-4930-8549-b36fc3252fd0"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("70905696-3340-4c93-8356-107102c2fd19"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"Lane2",
				Position = new Point(29, 850),
				Size = new Size(1417, 170),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("d6b6bca8-4668-4ee5-aab9-b400ad057c7d"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("70905696-3340-4c93-8356-107102c2fd19"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"Lane3",
				Position = new Point(29, 673),
				Size = new Size(1417, 172),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("e7d795a1-df30-484b-a667-51e3a5a063c0"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("70905696-3340-4c93-8356-107102c2fd19"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"Lane4",
				Position = new Point(29, 503),
				Size = new Size(1417, 165),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("07f41e3b-9215-4e2d-9c5a-77a93dc613e5"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("70905696-3340-4c93-8356-107102c2fd19"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"Lane5",
				Position = new Point(29, 339),
				Size = new Size(1417, 159),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaLane CreateLane6Lane() {
			ProcessSchemaLane schemaLane6 = new ProcessSchemaLane(this) {
				UId = new Guid("2c10702b-5ef9-4f9f-8aac-3377ce2cd07e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("70905696-3340-4c93-8356-107102c2fd19"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"Lane6",
				Position = new Point(29, 0),
				Size = new Size(1417, 334),
				UseBackgroundMode = false
			};
			return schemaLane6;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ecbdf0d8-a905-40f3-a2c3-d101c28c055a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db8fd90e-3dd9-47a9-b90f-cf047852e9ac"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(290, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("785a80f2-e16c-424b-9b3a-5b48585d1fd5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ecbdf0d8-a905-40f3-a2c3-d101c28c055a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"DataSourceSavedStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDataSourceSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c350925e-2a55-45e9-b7cb-3679ec7040ae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ecbdf0d8-a905-40f3-a2c3-d101c28c055a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"DataSourceSavedScriptTask",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,78,204,73,205,75,73,44,10,72,76,79,245,72,205,41,72,45,82,176,85,112,79,45,113,198,16,215,208,180,230,229,42,3,106,41,79,77,205,70,87,30,142,34,6,86,138,105,178,158,71,98,94,74,78,170,75,98,73,98,112,126,105,81,114,106,112,98,89,106,10,88,49,170,153,120,20,130,88,152,110,11,46,73,44,73,213,192,180,17,166,3,213,121,16,213,168,86,130,84,22,165,150,148,22,229,41,148,20,149,166,90,3,0,97,123,96,37,28,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDataSourceSavedIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a0f81d42-340e-418f-af19-5bc6dfc95f71"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ecbdf0d8-a905-40f3-a2c3-d101c28c055a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"DataSourceSavedIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9b36f855-ff21-423f-a840-6662b4bd32de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db8fd90e-3dd9-47a9-b90f-cf047852e9ac"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(357, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSaveCalendarDataStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a31bf46a-2131-48df-abac-86a0efe192b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b36f855-ff21-423f-a840-6662b4bd32de"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SaveCalendarData",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"SaveCalendarDataStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveCalendarDataScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0a020ffa-99da-45dc-bb55-c6610c769c2e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9b36f855-ff21-423f-a840-6662b4bd32de"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"SaveCalendarDataScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,204,177,10,194,48,24,4,224,93,240,29,50,182,75,94,160,56,72,4,235,38,180,210,249,183,57,29,12,73,249,243,39,190,190,38,91,45,56,29,28,223,93,38,86,51,57,120,75,124,165,39,122,184,5,172,14,234,12,49,155,190,105,187,253,46,127,39,111,224,245,203,167,85,87,233,246,89,247,228,173,195,137,132,134,144,120,198,64,25,182,226,245,231,31,216,20,165,143,113,41,169,40,170,17,204,20,195,67,244,237,162,39,220,77,240,194,193,69,93,64,171,141,11,17,117,201,144,196,94,9,39,116,31,191,239,225,144,250,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("65b3cab4-6e43-4fc1-9b30-52e1fa938e49"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("246d45d0-5638-4930-8549-b36fc3252fd0"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess3",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(290, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWeekDaysTreeGridSelectionChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("49aa51ee-2a53-4c65-8ca2-ce4bf634a1db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65b3cab4-6e43-4fc1-9b30-52e1fa938e49"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"WeekDaysTreeGridSelectionChange",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"WeekDaysTreeGridSelectionChangeStartMessage",
				Position = new Point(14, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateWeekDaysTreeGridSelectionChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("172557d4-51aa-4139-80ec-8b0152d440f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65b3cab4-6e43-4fc1-9b30-52e1fa938e49"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"WeekDaysTreeGridSelectionChangeScriptTask",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,140,177,10,128,32,20,69,247,160,127,112,180,165,31,136,166,6,29,3,131,230,71,94,76,18,139,199,179,126,63,106,115,61,156,115,110,98,245,0,199,76,1,22,233,2,171,81,25,200,90,49,221,13,109,83,107,189,165,236,19,22,6,12,71,239,144,176,73,60,243,180,83,14,248,3,71,55,234,143,19,18,232,122,244,153,12,41,156,149,112,193,240,2,226,138,223,87,146,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a1521a03-1410-4eba-af52-f2902b690e3e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("246d45d0-5638-4930-8549-b36fc3252fd0"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess4",
				Position = new Point(350, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(290, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCalendarDaysTreeGridSelectionChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("25794336-98af-474d-9103-ad9854eabec4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1521a03-1410-4eba-af52-f2902b690e3e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CalendarDaysTreeGridSelectionChange",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"CalendarDaysTreeGridSelectionChangeStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCalendarDaysTreeGridSelectionChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6f28b843-1b1f-4d8a-bf37-d2036d4236a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1521a03-1410-4eba-af52-f2902b690e3e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"CalendarDaysTreeGridSelectionChangeScriptTask",
				Position = new Point(162, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,140,49,10,128,48,16,4,123,193,63,92,25,27,63,32,86,22,177,20,226,7,14,179,104,32,156,114,92,242,126,209,54,237,48,51,149,149,14,206,144,200,186,241,137,21,249,129,210,76,30,182,52,220,13,83,223,181,250,184,178,196,140,93,1,175,41,6,100,28,150,110,89,46,150,19,127,20,184,162,253,5,99,131,107,135,95,161,176,162,66,166,5,211,11,164,248,43,207,166,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7c243399-9348-4a38-93e5-d17870852f1b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d6b6bca8-4668-4ee5-aab9-b400ad057c7d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(348, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("613fd53a-2bbf-4dc2-adf2-131f9411d790"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7c243399-9348-4a38-93e5-d17870852f1b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7ae0875a-bfd2-488b-8670-a112e48f0250"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7c243399-9348-4a38-93e5-d17870852f1b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e19daf9d-f3df-4372-9607-6a54c7c004c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7c243399-9348-4a38-93e5-d17870852f1b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,206,49,11,194,48,16,5,224,93,240,63,132,14,82,23,113,47,130,16,208,10,10,66,7,231,163,121,72,105,154,150,227,18,255,190,77,197,33,6,92,223,125,239,238,2,177,106,201,194,25,226,59,61,81,195,78,96,117,80,103,136,206,242,114,91,173,87,97,174,188,128,254,151,63,146,108,161,249,230,93,77,206,88,196,224,58,146,209,227,48,89,8,22,157,46,253,39,27,10,200,191,107,132,230,121,126,243,219,72,31,252,232,244,102,148,167,206,10,248,6,231,47,130,65,219,174,237,203,99,17,221,102,95,68,192,16,207,78,9,123,84,111,170,221,89,220,63,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1cbadd76-9fb2-4b4e-ac4b-99deba64a91c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d6b6bca8-4668-4ee5-aab9-b400ad057c7d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(406, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("43087361-20e9-4115-a0cc-06c5630ffe9c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1cbadd76-9fb2-4b4e-ac4b-99deba64a91c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"InitStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("03fecc71-3b5a-49ba-9b5a-a7c46538e271"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1cbadd76-9fb2-4b4e-ac4b-99deba64a91c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("37631aca-42c2-47ee-85bc-aa553fa27adb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1cbadd76-9fb2-4b4e-ac4b-99deba64a91c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,177,10,194,64,16,68,123,193,127,184,50,54,254,64,176,49,133,177,11,92,97,189,120,67,56,114,108,100,157,139,191,47,70,20,46,215,206,190,121,59,30,28,96,113,14,231,76,206,250,244,113,84,73,205,161,221,239,22,49,119,151,4,13,98,131,140,232,145,30,48,119,114,23,176,171,242,127,229,5,76,91,252,86,100,43,90,155,143,189,104,72,184,106,228,74,148,162,237,213,203,130,122,133,167,16,77,237,254,53,202,33,95,186,252,243,33,13,204,166,142,150,209,190,1,41,85,194,105,33,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("da4ab074-dce8-4f7b-9b5e-6e3027d7e51c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d795a1-df30-484b-a667-51e3a5a063c0"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess7",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(222, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDayTypeCalendarEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("78ceccc1-1b26-45f5-af43-2829973823ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da4ab074-dce8-4f7b-9b5e-6e3027d7e51c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DayTypeCalendarEditChange",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"DayTypeCalendarEditChangeStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDayTypeCalendarEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e0b5b28a-5795-4982-9772-eb8f5d7f731b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da4ab074-dce8-4f7b-9b5e-6e3027d7e51c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"DayTypeCalendarEditChangeScriptTask",
				Position = new Point(99, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,140,49,10,128,48,16,4,123,193,63,164,212,198,15,4,171,40,90,10,250,129,197,44,42,132,32,199,37,224,239,69,219,180,195,204,100,136,217,17,24,61,100,193,193,153,225,166,152,222,76,84,87,240,166,181,117,85,234,221,140,232,3,7,60,219,115,115,244,151,186,19,241,224,175,175,200,44,79,171,66,217,148,171,175,16,106,146,104,84,18,237,11,88,52,162,186,160,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("94ec13d8-1d4f-4563-ac16-087b2841b32e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d795a1-df30-484b-a667-51e3a5a063c0"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess8",
				Position = new Point(281, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDayTypeWeekEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("80a00fbd-5d38-40b6-8d5c-a7ba98352274"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("94ec13d8-1d4f-4563-ac16-087b2841b32e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DayTypeWeekEditChange",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"DayTypeWeekEditChangeStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDayTypeWeekEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bb819186-e551-4a5e-9e14-7ca6942a2992"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("94ec13d8-1d4f-4563-ac16-087b2841b32e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"DayTypeWeekEditChangeScriptTask",
				Position = new Point(113, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,79,77,205,14,72,76,79,245,72,205,41,72,45,82,176,85,112,79,45,9,71,17,211,208,180,230,229,66,85,166,231,145,152,151,146,147,234,146,88,25,82,89,144,234,154,146,89,226,156,145,152,151,158,10,86,26,156,88,150,138,106,66,112,73,98,73,170,6,170,17,32,149,69,169,37,165,69,121,10,37,69,165,169,214,0,253,191,12,246,140,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5960b74a-305c-4bf8-a49b-a9866e641fde"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07f41e3b-9215-4e2d-9c5a-77a93dc613e5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess9",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartDateEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("78eabbf5-9c92-4347-8ee8-3f5877559b60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5960b74a-305c-4bf8-a49b-a9866e641fde"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"StartDateEditChange",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"StartDateEditChangeStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateStartDateEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c21c14c4-fe39-4cca-844a-1fa286f2ebdc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5960b74a-305c-4bf8-a49b-a9866e641fde"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"StartDateEditChangeScriptTask",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,79,75,3,49,20,196,207,46,236,119,136,151,146,61,24,16,161,151,165,66,105,23,123,17,196,45,130,199,71,51,214,149,52,150,228,101,81,196,239,110,210,210,63,152,237,41,228,101,230,55,147,164,39,39,60,147,227,57,49,196,68,60,209,26,170,61,12,26,221,177,106,97,176,98,232,52,168,203,162,143,14,88,125,174,111,246,219,33,117,247,38,228,137,127,61,17,105,93,118,27,168,199,206,190,144,9,16,163,209,145,119,233,92,30,4,55,167,178,149,90,126,50,153,57,125,123,113,47,238,198,227,74,252,148,197,85,94,40,248,109,180,79,63,232,171,233,97,217,203,170,30,212,157,21,143,23,59,230,168,169,214,175,32,231,229,237,176,241,25,62,108,240,143,255,91,22,251,167,90,145,137,233,228,146,109,1,179,133,139,240,7,240,44,155,239,124,185,92,45,200,106,131,20,231,103,239,100,215,216,9,91,234,145,51,226,207,49,100,14,73,14,7,14,206,10,118,1,245,31,191,111,178,89,247,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("89e38206-f3cc-494b-a600-dbe8365a6f72"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07f41e3b-9215-4e2d-9c5a-77a93dc613e5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess10",
				Position = new Point(246, 6),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEndDateEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b0f97eee-380e-4690-b157-e5d3defc6edc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89e38206-f3cc-494b-a600-dbe8365a6f72"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EndDateEditChange",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EndDateEditChangeStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEndDateEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("44dcc6aa-7791-4f75-b935-c23813c42754"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89e38206-f3cc-494b-a600-dbe8365a6f72"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EndDateEditChangeScriptTask",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,65,107,2,49,20,132,207,46,236,127,72,47,146,61,24,40,5,47,139,130,232,82,47,133,210,149,66,143,15,51,181,91,98,42,201,203,210,82,250,223,155,104,173,226,186,167,144,151,153,111,230,165,37,39,60,147,227,5,49,196,68,60,210,6,170,62,14,42,221,176,170,97,176,102,232,52,40,243,172,141,14,88,125,174,175,14,215,107,234,230,85,200,19,255,102,34,210,185,106,182,80,15,141,125,38,19,32,134,195,127,94,223,187,60,10,70,167,178,133,90,125,48,153,5,125,121,49,21,119,227,113,33,190,243,108,112,109,129,224,119,17,48,123,167,207,170,133,101,47,139,178,71,121,86,62,46,247,151,170,102,90,191,128,156,151,163,219,62,231,19,124,216,226,34,226,39,207,14,255,181,38,19,89,228,146,113,9,179,131,139,244,123,240,188,51,223,251,186,114,181,36,171,13,82,156,159,191,145,221,96,47,172,169,69,151,17,155,49,100,23,146,28,14,28,156,21,236,2,202,95,134,219,190,0,252,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a736498b-9769-43bf-b954-f11b9b7bc0aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c10702b-5ef9-4f9f-8aac-3377ce2cd07e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess11",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDayButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6c8dff4a-eb84-455a-85be-4c06ec2483f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a736498b-9769-43bf-b954-f11b9b7bc0aa"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DayButtonClick",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"DayButtonClickStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDayButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7b661891-8ea6-4614-8bb6-d245e8c16119"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a736498b-9769-43bf-b954-f11b9b7bc0aa"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"DayButtonClickScriptTask",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,41,73,45,242,77,205,43,245,44,73,205,117,206,201,76,206,214,112,80,74,73,172,84,51,80,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,43,76,139,45,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("29b7e07a-216d-4c19-867e-a9a1313a8a99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c10702b-5ef9-4f9f-8aac-3377ce2cd07e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess13",
				Position = new Point(442, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMonthButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("983ae739-b53f-487e-bec0-9be64556a623"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29b7e07a-216d-4c19-867e-a9a1313a8a99"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MonthButtonClick",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"MonthButtonClickStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMonthButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2d55a321-c143-4fce-a73e-a23e3351c59b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29b7e07a-216d-4c19-867e-a9a1313a8a99"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"MonthButtonClickScriptTask",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,41,73,45,242,77,205,43,245,44,73,205,117,206,201,76,206,214,112,80,202,205,207,43,201,80,51,80,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,178,130,23,151,46,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("254b6514-5896-479e-8fdc-1291b06b94e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c10702b-5ef9-4f9f-8aac-3377ce2cd07e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess12",
				Position = new Point(239, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWeekButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a07ead2e-ae12-4879-b539-9f28641b021d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("254b6514-5896-479e-8fdc-1291b06b94e5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"WeekButtonClick",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"WeekButtonClickStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateWeekButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fedfe698-aecf-4dfc-9f90-65a718cb6fb9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("254b6514-5896-479e-8fdc-1291b06b94e5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"WeekButtonClickScriptTask",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,41,73,45,242,77,205,43,245,44,73,205,117,206,201,76,206,214,112,80,42,79,77,205,86,51,80,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,188,254,134,31,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1d7d7b70-cced-4af1-90d6-a2e551dd02f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c10702b-5ef9-4f9f-8aac-3377ce2cd07e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess14",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess14;
		}

		protected virtual ProcessSchemaStartSignalEvent CreatePeriodMenuItemClickStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("72979caf-7dfe-4cc7-b2a2-da41fd844a7d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1d7d7b70-cced-4af1-90d6-a2e551dd02f1"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = false,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"PeriodMenuItemClickStartSignal",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 72),
				SerializeToDB = false,
				Signal = @"PeriodMenuItemClick",
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = false,
				WaitingRandomSignal = true
			};
			InitializePeriodMenuItemClickStartSignalParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePeriodMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dbf057e2-9194-49e1-b5bb-2d815bd856c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1d7d7b70-cced-4af1-90d6-a2e551dd02f1"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"PeriodMenuItemClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,201,77,10,194,48,16,6,208,189,224,29,134,174,82,144,94,160,42,136,63,224,162,171,118,39,46,98,24,98,108,157,129,201,151,170,183,23,125,219,55,123,163,76,27,114,65,5,252,70,51,220,77,95,199,153,5,59,139,153,200,103,58,164,128,164,226,237,179,206,176,36,113,165,183,7,7,108,235,75,5,31,171,107,51,104,255,15,87,183,203,197,41,77,96,235,88,202,25,252,220,79,41,140,46,255,194,24,197,132,96,133,219,47,240,165,64,222,120,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a2ffad1d-c92d-4f35-b659-7aa32b3edf0e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2c10702b-5ef9-4f9f-8aac-3377ce2cd07e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"EventSubProcess15",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(315, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePeriodDaysFilterChangedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6b67ee33-f551-46f9-8ad8-a79abb3227ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2ffad1d-c92d-4f35-b659-7aa32b3edf0e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PeriodDaysFilterChanged",
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"PeriodDaysFilterChangedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePeriodDaysFilterChangedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f9f5ec3a-7ac2-49d1-866a-648a5f1ed316"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a2ffad1d-c92d-4f35-b659-7aa32b3edf0e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Name = @"PeriodDaysFilterChangedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,78,204,73,205,75,73,44,10,72,76,79,245,72,205,41,72,45,82,176,85,112,79,45,113,198,16,215,208,180,230,229,194,84,174,231,145,152,151,146,147,234,146,88,146,90,236,156,145,152,151,158,10,86,24,156,88,150,138,105,70,112,9,80,153,6,166,33,32,29,69,169,37,165,69,121,10,37,69,165,169,214,0,100,215,169,160,154,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetCalendarPageHelperMethod());
			Methods.Add(CreateGetWeekPageHelperMethod());
			Methods.Add(CreateSaveCalendarPageHelperStateMethod());
			Methods.Add(CreateSaveWeekPageHelperStateMethod());
			Methods.Add(CreateFilterMenuItemClickMethod());
			Methods.Add(CreateSetPeriodButtonsSignalMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,65,75,196,48,16,133,207,205,175,8,123,216,182,80,130,158,139,224,210,85,233,97,69,182,171,158,135,102,186,141,102,19,153,164,173,80,250,223,77,219,21,193,203,192,123,243,205,155,153,103,68,121,196,134,208,181,79,164,36,191,227,158,58,204,89,15,196,93,77,234,203,7,235,126,163,26,158,12,202,72,59,136,30,180,146,224,177,0,141,70,2,21,214,120,178,218,37,41,223,110,249,63,232,29,241,243,15,72,249,56,178,104,206,26,111,38,1,181,87,61,30,3,125,177,82,53,10,229,27,232,14,221,74,69,51,226,160,199,36,205,57,139,166,137,163,118,24,90,65,68,215,45,39,36,2,103,27,47,118,31,240,125,64,223,90,233,196,169,37,59,20,90,161,241,15,125,40,73,60,222,78,113,198,227,42,164,253,94,189,7,15,241,53,153,77,211,38,103,236,5,206,40,170,229,231,3,152,32,72,236,164,92,141,196,121,82,230,44,30,45,93,32,168,197,204,248,50,50,71,85,182,163,26,197,186,181,220,103,188,52,206,131,169,241,181,148,105,154,255,0,23,245,185,241,102,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCalendarPageHelperMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2cdb1acb-35ec-43ef-9490-dc152c57a9ce"),
				Name = "GetCalendarPageHelper",
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				ResultValueTypeName = "TSConfiguration.CalendarHelperCalendarEditPage"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,65,10,194,48,16,69,215,230,20,227,46,133,210,11,20,87,69,176,224,162,80,123,128,161,153,150,64,152,148,105,170,11,241,238,166,106,81,139,238,146,63,63,239,133,57,163,0,25,27,42,236,233,64,110,32,129,29,48,93,224,84,23,158,59,219,79,130,193,122,206,10,116,196,6,229,89,90,110,251,215,83,157,228,202,118,160,151,252,141,171,3,6,130,109,132,78,206,37,112,85,155,111,93,118,244,104,62,170,90,175,205,191,141,143,114,242,199,23,127,115,83,106,37,106,6,19,71,115,16,249,65,188,211,243,57,133,102,140,116,207,76,237,172,75,161,228,49,32,183,212,148,38,114,132,194,36,188,218,81,126,7,140,166,95,217,55,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetWeekPageHelperMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d970fede-9e69-4ca7-ba20-26a0bcb92758"),
				Name = "GetWeekPageHelper",
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				ResultValueTypeName = "TSConfiguration.WeekHelperCalendarEditPage"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,193,10,194,48,12,134,207,246,41,226,173,131,177,23,24,158,134,224,192,131,48,135,231,176,102,163,88,210,145,117,122,16,223,221,86,5,117,120,11,201,159,239,11,185,160,0,25,27,14,56,208,142,220,72,2,27,96,186,194,177,169,60,247,118,152,5,131,245,92,156,136,206,175,64,133,142,216,160,108,223,107,58,43,149,237,65,167,196,7,211,4,12,4,235,8,155,157,203,224,166,86,191,154,98,239,209,124,69,181,94,26,255,219,158,225,12,254,200,226,25,119,165,22,150,118,52,113,148,26,17,30,196,59,157,234,28,218,41,162,61,51,117,201,149,67,205,83,64,238,168,173,77,228,8,133,89,120,241,152,242,1,244,102,255,23,44,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveCalendarPageHelperStateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("65c481c6-8734-4450-b57e-9dd0625d269c"),
				Name = "SaveCalendarPageHelperState",
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("76bf795c-7dc2-4f8c-b411-bbedf197ce0b"),
				Name = "pageHelper",
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "TSConfiguration.BaseHelperCalendarEditPage",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,78,204,73,205,75,73,44,10,72,76,79,245,72,205,41,72,45,10,46,73,44,73,85,176,85,40,128,139,232,185,167,150,32,201,105,104,90,3,0,131,86,17,79,54,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveWeekPageHelperStateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("567c2448-a9e1-4c7f-a46d-2b62503b2d10"),
				Name = "SaveWeekPageHelperState",
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("65336b8d-e3c7-4bba-9599-d9ba79e80559"),
				Name = "pageHelper",
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "TSConfiguration.BaseHelperCalendarEditPage",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,79,77,205,14,72,76,79,245,72,205,41,72,45,10,46,73,44,73,85,176,85,40,128,139,232,185,167,150,32,201,105,104,90,3,0,134,176,236,86,50,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFilterMenuItemClickMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e50be9f4-4ba0-48d4-85b2-2392ed8dc2dd"),
				Name = "FilterMenuItemClick",
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5f0d4c92-5054-4907-b9a3-564174178e2d"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				ModifiedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,148,95,111,218,48,20,197,159,157,79,97,241,48,146,173,181,160,147,58,105,8,105,21,163,18,210,208,208,160,237,3,226,193,35,134,120,4,27,217,23,104,133,248,238,187,118,254,64,33,136,190,197,246,185,63,159,115,99,219,130,145,106,62,158,208,153,76,65,152,1,55,124,41,240,195,210,54,93,149,3,54,92,165,18,194,250,167,122,212,10,228,140,134,167,106,246,75,168,57,36,180,221,166,119,81,176,11,200,79,14,98,36,151,130,90,224,6,220,8,129,197,36,27,233,152,191,181,142,84,66,197,151,52,27,110,232,74,24,169,99,92,61,221,119,220,152,228,146,13,79,215,174,190,163,213,70,24,192,242,158,130,175,119,103,78,199,205,9,102,32,118,43,97,154,208,48,35,71,1,65,207,100,202,173,160,53,220,182,246,29,71,228,216,122,249,205,30,98,180,250,102,67,191,161,67,17,114,112,95,202,252,252,95,35,248,162,85,130,183,66,44,50,50,2,126,207,94,112,72,113,179,179,208,172,92,246,20,169,192,201,220,31,113,234,91,90,46,179,190,86,89,147,80,133,127,37,68,105,228,137,109,218,136,220,172,75,69,72,94,125,239,133,251,235,209,110,125,193,151,188,167,159,233,183,139,49,203,146,251,168,42,241,82,43,72,62,210,204,38,198,58,204,226,84,228,150,250,174,252,90,167,143,132,205,232,16,161,249,222,16,166,30,240,185,96,195,162,172,27,75,96,195,181,93,33,242,225,31,127,237,110,132,2,27,186,42,47,236,102,59,93,147,85,242,62,192,58,146,84,147,4,60,187,216,97,153,179,154,86,200,242,198,92,228,61,231,215,227,248,128,158,209,10,81,14,107,5,149,168,63,194,174,151,226,90,207,46,171,170,104,215,73,7,69,64,166,90,89,192,40,238,233,162,144,24,189,245,171,195,169,145,43,64,255,63,106,238,54,108,165,138,245,150,225,233,145,49,178,58,60,197,92,220,224,3,1,70,167,136,138,232,206,221,143,145,48,134,91,61,3,230,220,246,5,36,58,182,108,228,176,157,84,34,215,195,95,36,36,125,110,23,97,125,215,216,215,111,104,125,224,95,14,119,216,30,253,19,211,73,184,154,139,216,189,144,100,191,175,21,73,240,64,102,190,194,204,47,123,212,102,201,33,60,181,125,67,123,24,138,171,169,120,234,197,17,66,246,255,1,197,178,120,61,155,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetPeriodButtonsSignalMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("34e327fd-0911-4d94-b6bf-92f65990ffb2"),
				Name = "SetPeriodButtonsSignal",
				CreatedInSchemaUId = new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,142,187,10,194,48,20,134,103,243,20,161,83,178,156,23,16,7,111,67,135,72,65,165,243,177,158,182,177,185,64,154,22,69,124,119,131,88,71,87,221,126,248,111,95,237,3,97,213,114,49,98,224,150,220,144,71,178,92,59,94,96,67,176,193,219,106,136,209,59,80,201,146,236,206,102,66,28,40,4,236,125,29,225,152,67,73,167,181,119,49,120,211,195,71,168,247,142,156,6,37,44,47,120,221,142,228,98,138,25,93,117,176,215,141,67,179,67,75,124,193,179,130,130,246,231,169,247,74,100,115,246,96,245,87,188,146,168,251,103,62,149,14,219,159,2,62,1,90,71,120,81,223,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CalendarEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3a853f48-3ed9-4043-9a3d-f31bb3b0f84a"));
		}

		#endregion

	}

	#endregion

}

