namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ChangeLogModulePageSchema

	/// <exclude/>
	public class ChangeLogModulePageSchema : Terrasoft.WebApp.BaseModulePageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _filterControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return _filterControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return _controlLayout5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _periodCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox PeriodCheckBox {
			get {
				return _periodCheckBox;
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout6;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return _controlLayout6;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _ownerCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox OwnerCheckBox {
			get {
				return _ownerCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _ownerEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit OwnerEdit {
			get {
				return _ownerEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _currentUserToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton CurrentUserToolButton {
			get {
				return _currentUserToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _objectControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ObjectControlLayout {
			get {
				return _objectControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label1;
		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return _label1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _objectComboBoxEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ObjectComboBoxEdit {
			get {
				return _objectComboBoxEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ChangeLogModulePageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ChangeLogModulePageSchema(ChangeLogModulePageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateFolderLayout() {
			FolderLayout.Image = new ControlImage {};
			FolderLayout.Hidden = true;
			FolderLayout.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
		}

		private void UpdateSaveToolButton() {
			SaveToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			SaveToolButton.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
		}

		private void UpdateApplyToolButton() {
			ApplyToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf"),
				ImageHash = @"4dde0eddf6e97ed8c6d821a115676e80"
			};
			ApplyToolButton.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
		}

		private void UpdateFilterEditLayout() {
			FilterEditLayout.Image = new ControlImage {};
			FilterEditLayout.Hidden = true;
			FilterEditLayout.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
		}

		private void UpdateLeftControlLayout() {
			LeftControlLayout.Image = new ControlImage {};
			LeftControlLayout.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
		}

		private void UpdateGrid() {
			Grid.PageSchemaUId = new Guid("ed09a621-92d1-4361-8d5b-73d53e36dc4a");
			Grid.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
		}

		private void UpdateGridTab() {
			GridTab.Image = new ControlImage {};
			GridTab.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
		}

		private void UpdateGridTabPanel() {
			GridTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
		}

		private void UpdateDetailsTabPanel() {
			DetailsTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			DetailsTabPanel.AjaxEvents.TabChange.ShowLoadMask = true;
		}

		private void UpdateRightControlLayout() {
			RightControlLayout.Image = new ControlImage {};
			RightControlLayout.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			RealUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			Name = "ChangeLogModulePage";
			ParentSchemaUId = new Guid("f3176148-0d11-4c41-8da5-d6e5e75151cf");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateChangeLogModulePageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateMainControlLayout();
			UpdateRightControlLayout();
			UpdateDetailsTabPanel();
			UpdateGridTabPanel();
			UpdateGridTab();
			UpdateGrid();
			UpdateLeftControlLayout();
			UpdateFilterEditLayout();
			UpdateApplyToolButton();
			UpdateSaveToolButton();
			UpdateFolderLayout();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, LeftControlLayout);
			LeftControlLayout.InsertItem(0, CreateFilterControlLayout());
			FilterControlLayout.InsertItem(0, CreateControlLayout5());
			ControlLayout5.InsertItem(0, CreatePeriodCheckBox());
			ControlLayout5.InsertItem(1, CreateDayButton());
			DayButton.InsertItem(0, CreateYesterdayItem());
			DayButton.InsertItem(1, CreateTodayItem());
			DayButton.InsertItem(2, CreateTomorowItem());
			ControlLayout5.InsertItem(2, CreateWeekButton());
			WeekButton.InsertItem(0, CreateLastWeekItem());
			WeekButton.InsertItem(1, CreateCurrentWeekItem());
			WeekButton.InsertItem(2, CreateNextWeekItem());
			ControlLayout5.InsertItem(3, CreateMonthButton());
			MonthButton.InsertItem(0, CreateLastMonthItem());
			MonthButton.InsertItem(1, CreateCurrentMonthItem());
			FilterControlLayout.InsertItem(1, CreateControlLayout6());
			ControlLayout6.InsertItem(0, CreateSpacer1());
			ControlLayout6.InsertItem(1, CreateStartDateEdit());
			ControlLayout6.InsertItem(2, CreateEndDateEdit());
			FilterControlLayout.InsertItem(2, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateOwnerCheckBox());
			ControlLayout4.InsertItem(1, CreateOwnerEdit());
			OwnerEdit.InsertItem(0, CreateCurrentUserToolButton());
			LeftControlLayout.InsertItem(1, CreateObjectControlLayout());
			ObjectControlLayout.InsertItem(0, CreateLabel1());
			ObjectControlLayout.InsertItem(1, CreateObjectComboBoxEdit());
			LeftControlLayout.MoveItem(2, CustomSearchContainer);
			LeftControlLayout.MoveItem(3, FolderLayout);
			FolderLayout.MoveItem(0, BaseFolder);
			LeftControlLayout.MoveItem(4, FilterEditLayout);
			FilterEditLayout.MoveItem(0, FilterEdit);
			FilterEdit.MoveItem(0, SaveToolButton);
			FilterEdit.MoveItem(1, ApplyToolButton);
			MainControlLayout.MoveItem(1, RightControlLayout);
			RightControlLayout.MoveItem(0, GridTabPanel);
			GridTabPanel.MoveItem(0, GridTab);
			GridTab.MoveItem(0, Grid);
			RightControlLayout.MoveItem(1, DetailsTabPanel);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateChangeLogModulePageEventsProcessSchema() {
			var schema = new ChangeLogModulePageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreatePeriodCheckBox() {
			_periodCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_periodCheckBox.UId = new Guid("ffc84328-9c06-4fa8-aa97-27e3664ade93");
			_periodCheckBox.Name = "PeriodCheckBox";
			_periodCheckBox.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_periodCheckBox.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_periodCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_periodCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_periodCheckBox.Tag = "";
			_periodCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_periodCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _periodCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateYesterdayItem() {
			_yesterdayItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_yesterdayItem.UId = new Guid("bb042353-05eb-4899-a4d6-1ed1d0b424be");
			_yesterdayItem.Name = "YesterdayItem";
			_yesterdayItem.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_yesterdayItem.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_yesterdayItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_yesterdayItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_yesterdayItem.Image = new ControlImage {};
			_yesterdayItem.Tag = "day&-1";
			return _yesterdayItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateTodayItem() {
			_todayItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_todayItem.UId = new Guid("0778b6c3-5a0e-4b7e-befd-5bdd469d5eca");
			_todayItem.Name = "TodayItem";
			_todayItem.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_todayItem.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_todayItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_todayItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_todayItem.Image = new ControlImage {};
			_todayItem.Tag = "day&0";
			return _todayItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateTomorowItem() {
			_tomorowItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_tomorowItem.UId = new Guid("085abb66-dfd8-47af-8bc3-add1f00b914d");
			_tomorowItem.Name = "TomorowItem";
			_tomorowItem.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_tomorowItem.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_tomorowItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_tomorowItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_tomorowItem.Image = new ControlImage {};
			_tomorowItem.Tag = "day&1";
			return _tomorowItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDayButton() {
			_dayButton = new Terrasoft.UI.WebControls.Controls.Button();
			_dayButton.UId = new Guid("a0737b63-a057-4757-8a55-4fb6d19a23dc");
			_dayButton.Name = "DayButton";
			_dayButton.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_dayButton.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_dayButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dayButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_dayButton.Tag = "";
			_dayButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f"),
				ImageHash = @"5fc7fcb824fb8800e6d97f18e1761396"
			};
			_dayButton.Margins = "0 0 0 5";
			return _dayButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateLastWeekItem() {
			_lastWeekItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_lastWeekItem.UId = new Guid("3f602ed6-b7e0-43b3-bd43-3fbb1d7a8535");
			_lastWeekItem.Name = "LastWeekItem";
			_lastWeekItem.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_lastWeekItem.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_lastWeekItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lastWeekItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lastWeekItem.Image = new ControlImage {};
			_lastWeekItem.Tag = "week&-1";
			return _lastWeekItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateCurrentWeekItem() {
			_currentWeekItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_currentWeekItem.UId = new Guid("f165b03e-9ce4-4f3f-afa7-c4293350bd56");
			_currentWeekItem.Name = "CurrentWeekItem";
			_currentWeekItem.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_currentWeekItem.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_currentWeekItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_currentWeekItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_currentWeekItem.Image = new ControlImage {};
			_currentWeekItem.Tag = "week&0";
			return _currentWeekItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateNextWeekItem() {
			_nextWeekItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_nextWeekItem.UId = new Guid("1fda58ec-538a-46a8-be36-7e32f3158466");
			_nextWeekItem.Name = "NextWeekItem";
			_nextWeekItem.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_nextWeekItem.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_nextWeekItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nextWeekItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nextWeekItem.Image = new ControlImage {};
			_nextWeekItem.Tag = "week&1";
			return _nextWeekItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateWeekButton() {
			_weekButton = new Terrasoft.UI.WebControls.Controls.Button();
			_weekButton.UId = new Guid("fcc07597-35f9-46b7-910b-b12fe06b8f01");
			_weekButton.Name = "WeekButton";
			_weekButton.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_weekButton.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_weekButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_weekButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_weekButton.Tag = "";
			_weekButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f"),
				ImageHash = @"8ff38cda0e8bfc6dd7fbbadfb5152227"
			};
			_weekButton.Margins = "0 0 0 5";
			return _weekButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateLastMonthItem() {
			_lastMonthItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_lastMonthItem.UId = new Guid("11ee1791-e1c9-4d4f-86fd-66b9100f4174");
			_lastMonthItem.Name = "LastMonthItem";
			_lastMonthItem.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_lastMonthItem.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_lastMonthItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lastMonthItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lastMonthItem.Image = new ControlImage {};
			_lastMonthItem.Tag = "month&-1";
			return _lastMonthItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateCurrentMonthItem() {
			_currentMonthItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_currentMonthItem.UId = new Guid("9197c9ca-8dc1-4f89-b387-de0ad625970b");
			_currentMonthItem.Name = "CurrentMonthItem";
			_currentMonthItem.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_currentMonthItem.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_currentMonthItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_currentMonthItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_currentMonthItem.Image = new ControlImage {};
			_currentMonthItem.Tag = "month&0";
			return _currentMonthItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateMonthButton() {
			_monthButton = new Terrasoft.UI.WebControls.Controls.Button();
			_monthButton.UId = new Guid("5b413dd6-fa64-4755-bcb9-58b97dcb547d");
			_monthButton.Name = "MonthButton";
			_monthButton.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_monthButton.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_monthButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_monthButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_monthButton.Tag = "";
			_monthButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f"),
				ImageHash = @"77601d54ae1517555a580b644f0e0d75"
			};
			_monthButton.Margins = "0 0 0 5";
			return _monthButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout5() {
			_controlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout5.UId = new Guid("0cbecccd-a0d2-4ca8-982e-81a53958188a");
			_controlLayout5.Name = "ControlLayout5";
			_controlLayout5.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_controlLayout5.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_controlLayout5.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout5.Tag = "";
			_controlLayout5.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout5.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout5.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout5.FitHeightByContent = true;
			_controlLayout5.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.StartNewAlignGroup = false;
			_controlLayout5.Image = new ControlImage {};
			_controlLayout5.Edges = "";
			return _controlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("f6b5db60-c709-4844-bbfd-34d745241aa7");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_spacer1.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Pixel(13);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateStartDateEdit() {
			_startDateEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_startDateEdit.UId = new Guid("6e77afa1-6134-4c70-85ee-f0d6a8f396d8");
			_startDateEdit.Name = "StartDateEdit";
			_startDateEdit.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_startDateEdit.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_startDateEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_startDateEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_startDateEdit.Tag = "";
			_startDateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_startDateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_startDateEdit.Margins = "0 0 0 0";
			_startDateEdit.Kind = Terrasoft.Common.DateTimeValueKind.Date;
			return _startDateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateEndDateEdit() {
			_endDateEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_endDateEdit.UId = new Guid("80e9ebf7-c2f5-4996-b011-83ac6ff95500");
			_endDateEdit.Name = "EndDateEdit";
			_endDateEdit.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_endDateEdit.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_endDateEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_endDateEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_endDateEdit.Tag = "";
			_endDateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_endDateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_endDateEdit.Margins = "0 0 0 10";
			_endDateEdit.Kind = Terrasoft.Common.DateTimeValueKind.Date;
			return _endDateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout6() {
			_controlLayout6 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout6.UId = new Guid("b915681a-9fd3-465e-93c1-b32ac66097b9");
			_controlLayout6.Name = "ControlLayout6";
			_controlLayout6.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_controlLayout6.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_controlLayout6.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout6.Tag = "";
			_controlLayout6.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout6.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout6.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout6.FitHeightByContent = true;
			_controlLayout6.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout6.Padding = "3 0 0 0";
			_controlLayout6.StartNewAlignGroup = false;
			_controlLayout6.Image = new ControlImage {};
			_controlLayout6.Edges = "";
			return _controlLayout6;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateOwnerCheckBox() {
			_ownerCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_ownerCheckBox.UId = new Guid("7a6c56f3-f8b4-45f8-9363-e9355cd99998");
			_ownerCheckBox.Name = "OwnerCheckBox";
			_ownerCheckBox.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_ownerCheckBox.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_ownerCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_ownerCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_ownerCheckBox.Tag = "";
			_ownerCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _ownerCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateCurrentUserToolButton() {
			_currentUserToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_currentUserToolButton.UId = new Guid("3bcb1eb9-89a2-4e20-b0b6-a4051c9eb1f6");
			_currentUserToolButton.Name = "CurrentUserToolButton";
			_currentUserToolButton.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_currentUserToolButton.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_currentUserToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_currentUserToolButton.Tag = "";
			_currentUserToolButton.Image = new ControlImage {};
			_currentUserToolButton.Hidden = true;
			return _currentUserToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateOwnerEdit() {
			_ownerEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_ownerEdit.UId = new Guid("88b34648-60e4-402e-b7e3-2fc0493ca996");
			_ownerEdit.Name = "OwnerEdit";
			_ownerEdit.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_ownerEdit.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_ownerEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_ownerEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_ownerEdit.Tag = "";
			_ownerEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_ownerEdit.Image = new ControlImage {};
			_ownerEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_ownerEdit.LookupSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			return _ownerEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("9812a503-a701-4d7c-b1be-76fc057e36df");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_controlLayout4.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout4.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout4.FitHeightByContent = true;
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.Padding = "3 0 0 0";
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFilterControlLayout() {
			_filterControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_filterControlLayout.UId = new Guid("b7556f58-69ec-470a-a693-014bcfb968fe");
			_filterControlLayout.Name = "FilterControlLayout";
			_filterControlLayout.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_filterControlLayout.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_filterControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterControlLayout.Tag = "";
			_filterControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(90);
			_filterControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.StartNewAlignGroup = false;
			_filterControlLayout.Image = new ControlImage {};
			_filterControlLayout.Edges = "";
			return _filterControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel1() {
			_label1 = new Terrasoft.UI.WebControls.Controls.Label();
			_label1.UId = new Guid("9fd624ee-80ec-410e-9991-e3ca2114d0af");
			_label1.Name = "Label1";
			_label1.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_label1.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_label1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label1.Tag = "";
			_label1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _label1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateObjectComboBoxEdit() {
			_objectComboBoxEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_objectComboBoxEdit.UId = new Guid("347b4576-fdc9-4041-b2c3-da6debce6525");
			_objectComboBoxEdit.Name = "ObjectComboBoxEdit";
			_objectComboBoxEdit.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_objectComboBoxEdit.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_objectComboBoxEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_objectComboBoxEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_objectComboBoxEdit.Tag = "";
			_objectComboBoxEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectComboBoxEdit.Image = new ControlImage {};
			_objectComboBoxEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectComboBoxEdit.Margins = "0 0 0 0";
			return _objectComboBoxEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateObjectControlLayout() {
			_objectControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_objectControlLayout.UId = new Guid("d92d97ed-05bc-45b5-aa0c-5f2322e19e9a");
			_objectControlLayout.Name = "ObjectControlLayout";
			_objectControlLayout.CreatedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_objectControlLayout.ModifiedInSchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			_objectControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_objectControlLayout.Tag = "";
			_objectControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_objectControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_objectControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_objectControlLayout.FitHeightByContent = true;
			_objectControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectControlLayout.Padding = "0 0 7 0";
			_objectControlLayout.StartNewAlignGroup = false;
			_objectControlLayout.Image = new ControlImage {};
			_objectControlLayout.Edges = "";
			return _objectControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ChangeLogModulePageSchemaUserControl();
		}

		public override object Clone() {
			return new ChangeLogModulePageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("479145ca-4624-4121-9760-08ae15d28f6f"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ChangeLogModulePageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogModulePageEventsProcess

	/// <exclude/>
	public class ChangeLogModulePageEventsProcess<TPage> : Terrasoft.WebApp.BaseModulePageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ChangeLogModulePageSchemaUserControl
	{

		public ChangeLogModulePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeLogModulePageEventsProcess";
			SchemaUId = new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("479145ca-4624-4121-9760-08ae15d28f6f");
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

		public virtual bool ManuaStartDateChange {
			get;
			set;
		}

		public virtual bool ManuaEndDateChange {
			get;
			set;
		}

		public virtual Object LogObjectsList {
			get;
			set;
		}

		public virtual bool LoggingDisabled {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("eb50784d-5cfe-4b17-a0a5-153b4d1e4bb7"),
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
					SchemaElementUId = new Guid("b280fe5f-9231-440a-a79e-2fe7e38ca88d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("1359470f-4e64-4404-bcea-ad4f3f9988ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
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
					SchemaElementUId = new Guid("9fab3796-91d1-4236-880c-8beee35e6296"),
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
					SchemaElementUId = new Guid("4c958ff7-eb1c-4004-a5b0-052902448f17"),
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
					SchemaElementUId = new Guid("8ed1f6b6-fac2-42e4-98f5-122ad23e1911"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("705fa23c-6517-4c4f-9d86-0965bb024309"),
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
					SchemaElementUId = new Guid("d085ed82-72ba-46c3-a1e5-0e47143de821"),
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
					SchemaElementUId = new Guid("76705411-4d75-4ce4-9826-2bbeefe9777e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DayButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("149749eb-7e42-444b-804e-658231069b96"),
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
					SchemaElementUId = new Guid("dcff9092-8a22-47ca-84a9-d58c8db152d1"),
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
					SchemaElementUId = new Guid("5d95c30b-4aef-4610-8689-d13034225aa0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PeriodMenuItemClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("9d7cf1a1-2668-47f5-9866-30efe4255ccd"),
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
					SchemaElementUId = new Guid("31a7d5a9-ae05-4aef-b872-5acf5cadf97b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _ownerCheckBoxCheckScriptTask;
		public ProcessScriptTask OwnerCheckBoxCheckScriptTask {
			get {
				return _ownerCheckBoxCheckScriptTask ?? (_ownerCheckBoxCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OwnerCheckBoxCheckScriptTask",
					SchemaElementUId = new Guid("aa8dbcfa-1981-4069-ae4d-c0c2131e3b55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OwnerCheckBoxCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("d2acfc05-1101-43b1-864b-1527ba902dc2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("7d2e8b97-26e1-4d34-b457-cf6c9f478410"),
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
					SchemaElementUId = new Guid("23b54c51-47e2-4102-9c6a-421beba93e2b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _periodCheckBoxCheckScriptTask;
		public ProcessScriptTask PeriodCheckBoxCheckScriptTask {
			get {
				return _periodCheckBoxCheckScriptTask ?? (_periodCheckBoxCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PeriodCheckBoxCheckScriptTask",
					SchemaElementUId = new Guid("bc17f755-78e0-416e-bb61-776472f16232"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PeriodCheckBoxCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("b584d124-8762-4b72-b25a-34e3bed7defb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage9;
		public ProcessFlowElement StartMessage9 {
			get {
				return _startMessage9 ?? (_startMessage9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage9",
					SchemaElementUId = new Guid("cba2127e-fa5c-453e-a032-461dfc69d248"),
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
					SchemaElementUId = new Guid("b1ba8c24-9afa-4111-8950-2fa26d60b445"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = StartDateEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("153f77f5-8332-4920-a37a-bd4a6a3bb5b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage10;
		public ProcessFlowElement StartMessage10 {
			get {
				return _startMessage10 ?? (_startMessage10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage10",
					SchemaElementUId = new Guid("3e4d46aa-5cea-4deb-987b-1fbf232a7bea"),
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
					SchemaElementUId = new Guid("3a96567a-1c35-4213-990a-83763c540df1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EndDateEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("82d70f98-3d9a-4059-808e-cc111898ded6"),
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
					SchemaElementUId = new Guid("954ec25c-8ef9-479d-9dd3-8d98f577bd4f"),
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
					SchemaElementUId = new Guid("91494b60-0027-470d-bde5-22657e51a687"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask6Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess17;
		public ProcessFlowElement EventSubProcess17 {
			get {
				return _eventSubProcess17 ?? (_eventSubProcess17 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess17",
					SchemaElementUId = new Guid("97e90b6e-099a-489c-a63e-aef26365c648"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage12;
		public ProcessFlowElement StartMessage12 {
			get {
				return _startMessage12 ?? (_startMessage12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage12",
					SchemaElementUId = new Guid("6b6a5749-20af-4da8-ac52-07f39b9503d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _objectComboBoxEditChangeScriptTask;
		public ProcessScriptTask ObjectComboBoxEditChangeScriptTask {
			get {
				return _objectComboBoxEditChangeScriptTask ?? (_objectComboBoxEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ObjectComboBoxEditChangeScriptTask",
					SchemaElementUId = new Guid("189db39d-9bdd-4ced-839c-8cabab91559e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ObjectComboBoxEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess18;
		public ProcessFlowElement EventSubProcess18 {
			get {
				return _eventSubProcess18 ?? (_eventSubProcess18 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess18",
					SchemaElementUId = new Guid("79020eea-3350-4e87-acdf-a47e0b6c3783"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage13;
		public ProcessFlowElement PageLoadCompleteStartMessage13 {
			get {
				return _pageLoadCompleteStartMessage13 ?? (_pageLoadCompleteStartMessage13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage13",
					SchemaElementUId = new Guid("e3c18b95-062a-4d9c-912a-1456932d6beb"),
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
					SchemaElementUId = new Guid("dbd8996b-4277-44ef-a43a-4a8b51d99e5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("18f2d73c-ec62-4e17-b2be-c89c6f95a263"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess19;
		public ProcessFlowElement EventSubProcess19 {
			get {
				return _eventSubProcess19 ?? (_eventSubProcess19 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess19",
					SchemaElementUId = new Guid("ff30ed3c-b60c-4ea5-b769-676a71bfd88c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initStartMessage14;
		public ProcessFlowElement InitStartMessage14 {
			get {
				return _initStartMessage14 ?? (_initStartMessage14 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitStartMessage14",
					SchemaElementUId = new Guid("f242f423-7679-4c27-a402-752d2932ddc0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("97e82799-2a9d-42a0-8c9f-7c32b8b89657"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
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
					SchemaElementUId = new Guid("a16ea0fb-eb2f-45fa-acee-adaa38de55d4"),
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
					SchemaElementUId = new Guid("7b717993-23c6-4cd7-a6b2-07e15ac6624e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTask1Execute,
				});
			}
		}

		private LocalizableString _confirmationLocalizableString;
		public LocalizableString ConfirmationLocalizableString {
			get {
				return _confirmationLocalizableString ?? (_confirmationLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ConfirmationLocalizableString.Value"));
			}
		}

		private LocalizableString _waitingLocalizableString;
		public LocalizableString WaitingLocalizableString {
			get {
				return _waitingLocalizableString ?? (_waitingLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WaitingLocalizableString.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[DayButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DayButtonClickScriptTask };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[PeriodMenuItemClickStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { PeriodMenuItemClickStartSignal };
			FlowElements[PeriodMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PeriodMenuItemClickScriptTask };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[StartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6 };
			FlowElements[OwnerCheckBoxCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OwnerCheckBoxCheckScriptTask };
			FlowElements[StartMessage7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage7 };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[StartMessage8.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage8 };
			FlowElements[PeriodCheckBoxCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PeriodCheckBoxCheckScriptTask };
			FlowElements[EventSubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess14 };
			FlowElements[StartMessage9.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage9 };
			FlowElements[StartDateEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDateEditChangeScriptTask };
			FlowElements[EventSubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess15 };
			FlowElements[StartMessage10.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage10 };
			FlowElements[EndDateEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EndDateEditChangeScriptTask };
			FlowElements[EventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess16 };
			FlowElements[StartMessage11.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage11 };
			FlowElements[ScriptTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask6 };
			FlowElements[EventSubProcess17.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess17 };
			FlowElements[StartMessage12.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage12 };
			FlowElements[ObjectComboBoxEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectComboBoxEditChangeScriptTask };
			FlowElements[EventSubProcess18.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess18 };
			FlowElements[PageLoadCompleteStartMessage13.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage13 };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess19.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess19 };
			FlowElements[InitStartMessage14.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage14 };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[InitScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess10":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
						break;
					case "EventSubProcess9":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("DayButtonClickScriptTask");
						break;
					case "DayButtonClickScriptTask":
						break;
					case "EventSubProcess11":
						break;
					case "PeriodMenuItemClickStartSignal":
						e.Context.QueueTasks.Enqueue("PeriodMenuItemClickScriptTask");
						break;
					case "PeriodMenuItemClickScriptTask":
						break;
					case "EventSubProcess12":
						break;
					case "StartMessage6":
						e.Context.QueueTasks.Enqueue("OwnerCheckBoxCheckScriptTask");
						break;
					case "OwnerCheckBoxCheckScriptTask":
						break;
					case "StartMessage7":
						e.Context.QueueTasks.Enqueue("OwnerCheckBoxCheckScriptTask");
						break;
					case "EventSubProcess13":
						break;
					case "StartMessage8":
						e.Context.QueueTasks.Enqueue("PeriodCheckBoxCheckScriptTask");
						break;
					case "PeriodCheckBoxCheckScriptTask":
						break;
					case "EventSubProcess14":
						break;
					case "StartMessage9":
						e.Context.QueueTasks.Enqueue("StartDateEditChangeScriptTask");
						break;
					case "StartDateEditChangeScriptTask":
						break;
					case "EventSubProcess15":
						break;
					case "StartMessage10":
						e.Context.QueueTasks.Enqueue("EndDateEditChangeScriptTask");
						break;
					case "EndDateEditChangeScriptTask":
						break;
					case "EventSubProcess16":
						break;
					case "StartMessage11":
						e.Context.QueueTasks.Enqueue("ScriptTask6");
						break;
					case "ScriptTask6":
						break;
					case "EventSubProcess17":
						break;
					case "StartMessage12":
						e.Context.QueueTasks.Enqueue("ObjectComboBoxEditChangeScriptTask");
						break;
					case "ObjectComboBoxEditChangeScriptTask":
						break;
					case "EventSubProcess18":
						break;
					case "PageLoadCompleteStartMessage13":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess19":
						break;
					case "InitStartMessage14":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
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
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("PeriodMenuItemClickStartSignal");
			ActivatedEventElements.Add("StartMessage6");
			ActivatedEventElements.Add("StartMessage7");
			ActivatedEventElements.Add("StartMessage8");
			ActivatedEventElements.Add("StartMessage9");
			ActivatedEventElements.Add("StartMessage10");
			ActivatedEventElements.Add("StartMessage11");
			ActivatedEventElements.Add("StartMessage12");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage13");
			ActivatedEventElements.Add("InitStartMessage14");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "DayButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DayButtonClickScriptTask";
					result = DayButtonClickScriptTask.Execute(context, DayButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess11":
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
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6";
					result = StartMessage6.Execute(context);
					break;
				case "OwnerCheckBoxCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OwnerCheckBoxCheckScriptTask";
					result = OwnerCheckBoxCheckScriptTask.Execute(context, OwnerCheckBoxCheckScriptTaskExecute);
					break;
				case "StartMessage7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage7";
					result = StartMessage7.Execute(context);
					break;
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage8":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage8";
					result = StartMessage8.Execute(context);
					break;
				case "PeriodCheckBoxCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PeriodCheckBoxCheckScriptTask";
					result = PeriodCheckBoxCheckScriptTask.Execute(context, PeriodCheckBoxCheckScriptTaskExecute);
					break;
				case "EventSubProcess14":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage9":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage9";
					result = StartMessage9.Execute(context);
					break;
				case "StartDateEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDateEditChangeScriptTask";
					result = StartDateEditChangeScriptTask.Execute(context, StartDateEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage10":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage10";
					result = StartMessage10.Execute(context);
					break;
				case "EndDateEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EndDateEditChangeScriptTask";
					result = EndDateEditChangeScriptTask.Execute(context, EndDateEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage11":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage11";
					result = StartMessage11.Execute(context);
					break;
				case "ScriptTask6":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask6";
					result = ScriptTask6.Execute(context, ScriptTask6Execute);
					break;
				case "EventSubProcess17":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage12":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage12";
					result = StartMessage12.Execute(context);
					break;
				case "ObjectComboBoxEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectComboBoxEditChangeScriptTask";
					result = ObjectComboBoxEditChangeScriptTask.Execute(context, ObjectComboBoxEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess18":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage13":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage13";
					result = PageLoadCompleteStartMessage13.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess19":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage14":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage14";
					result = InitStartMessage14.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent2.Execute(context);
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
				case "LoggingDisabled":
					LoggingDisabled = reader.GetValue<System.Boolean>();
				break;
				case "LogObjectsList":
					LogObjectsList = reader.GetSerializableObjectValue();
				break;
				case "ManuaEndDateChange":
					ManuaEndDateChange = reader.GetValue<System.Boolean>();
				break;
				case "ManuaStartDateChange":
					ManuaStartDateChange = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			FilterMenuItemClick(@"month&0");
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool DayButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			FilterMenuItemClick(@"day&0");
			return true;
		}

		public virtual bool PeriodMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			var s = (context.ThrowEventArgs  as Dictionary<string,object>)["tag"].ToString();
			FilterMenuItemClick(s);
			return true;
		}

		public virtual bool OwnerCheckBoxCheckScriptTaskExecute(ProcessExecutingContext context) {
			 UpdateLogGrid();
			return true;
		}

		public virtual bool PeriodCheckBoxCheckScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.PeriodCheckBox.Checked == true) {
			     Page.StartDateEdit.Enabled = true;
			     Page.EndDateEdit.Enabled = true;
			     FilterMenuItemClick(@"day&0");
			}
			else {
				ManuaStartDateChange = true;
				ManuaEndDateChange = true;
			   Page.StartDateEdit.Clear();
			   Page.EndDateEdit.Clear();
			   Page.StartDateEdit.Enabled = false;
			   Page.EndDateEdit.Enabled = false;
			   UpdateLogGrid();
			}
			
			return true;
		}

		public virtual bool StartDateEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (!ManuaStartDateChange) {
				UpdateLogGrid();	
			} 
			ManuaStartDateChange = false;
			return true;
		}

		public virtual bool EndDateEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (!ManuaEndDateChange) {
				UpdateLogGrid();	
			}
			ManuaEndDateChange = false;
			return true;
		}

		public virtual bool ScriptTask6Execute(ProcessExecutingContext context) {
			UpdateLogGrid();
			return true;
		}

		public virtual bool ObjectComboBoxEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var grid = Page.Grid;
			var dataSource = grid.FindPageControlByName("DataSource") as Terrasoft.UI.WebControls.Controls.EntityDataSource;
			if (dataSource != null) {
				var filters = dataSource.CurrentStructure.Filters;
				var quickFilter = filters.FindByName("QuickFilter");
				if (quickFilter != null) {
					filters.Remove(quickFilter);
				}
			}
			grid.PageInstance.Process.SetPropertyValue("ObjectSchemaId",new Guid(Page.ObjectComboBoxEdit.SelectedItem.Value));
			grid.PageInstance.ThrowEvent("ObjectChanged");
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			if (!UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanViewConfiguration")) {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageChangeLog");
			}
			if (LoggingDisabled) {
				DisableChangelogControlPanel();
				return true;
			}
			Page.PeriodCheckBox.Checked = true;
			Page.OwnerCheckBox.Checked = true;
			Page.StartDateEdit.Value = DateTime.Now;
			Page.EndDateEdit.Value = DateTime.Now;
			SetCurrentUser();
			var template = @"function(){{if(checked==false){{Ext.MessageBox.confirm('{0}','{1}',function(btn){{if (btn=='no'){{el.setChecked(true);}}else{{el.callPageMethod('ThrowEvent',{{signalName:'ConfirmMessage',checked:true}});}}}},this);return false;}}return true;}}()";;
			Page.OwnerCheckBox.AjaxEvents.Check.OnClientEvent =	string.Format(template, ConfirmationLocalizableString, WaitingLocalizableString);
			Page.ScriptManager.AddScript("{0}.setReadOnly(true); {0}.allowEmpty = false;", Page.ObjectComboBoxEdit.ClientID);
			FillLogObjectsCombo();
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
				foreach (var menuItem in Page.DayButton.Menu){
					((Terrasoft.UI.WebControls.Controls.MenuItem)menuItem).AjaxEvents.Click.SignalName = "PeriodMenuItemClick";
				}
				foreach (var menuItem in Page.WeekButton.Menu){
					((Terrasoft.UI.WebControls.Controls.MenuItem)menuItem).AjaxEvents.Click.SignalName = "PeriodMenuItemClick";
				}
				foreach (var menuItem in Page.MonthButton.Menu){
					((Terrasoft.UI.WebControls.Controls.MenuItem)menuItem).AjaxEvents.Click.SignalName = "PeriodMenuItemClick";
				}
			
				if (!Terrasoft.UI.WebControls.Ext.IsAjaxRequest) {
					LogObjectsList = new List<Tuple<string, string>>();
					var list = LogObjectsList as List<Tuple<string, string>>;
					var schemaManager = UserConnection.EntitySchemaManager;
					var schemaQuery = new EntitySchemaQuery(schemaManager, "VwLogObjects");
					var uidColumn = schemaQuery.AddColumn("UId");
					var captionColumn = schemaQuery.AddColumn("Caption");
					schemaQuery.Filters.Add(schemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
							"SysWorkspace", UserConnection.Workspace.Id));
					var entities = schemaQuery.GetEntityCollection(UserConnection);
			
					if (entities.Count == 0) {
						LoggingDisabled = true;
						Page.Grid.PageInstance.Process.SetPropertyValue("UpdateSchema", false);
						return true;
					}
					
					foreach (var entity in entities) {
						var uid = entity.GetTypedColumnValue<string>(uidColumn.Name);
						var value = entity.GetTypedColumnValue<string>(captionColumn.Name);
						list.Add(new Tuple<string, string>(uid, value));
					}
					
					Page.Grid.PageInstance.Process.SetPropertyValue("ObjectSchemaId", new Guid(list[0].Item1));		
					Page.Grid.PageInstance.Process.SetPropertyValue("UpdateSchema", true);
					
				} else {
					var formStr = Page.AspPage.Request.Form["__EVENTARGUMENT"];
					if (string.IsNullOrEmpty(formStr)) {
						return true;
					}	
					string[] senderArgs = formStr.Split('|');
					string senderName = senderArgs[0];
					string eventName = senderArgs[2];
					if ((senderName == Page.ObjectComboBoxEdit.ClientID) && (eventName == "Change")) {
						string senderValue = Page.AspPage.Request.Form[Page.ObjectComboBoxEdit.ClientID + "_Value"];
						Page.Grid.PageInstance.Process.SetPropertyValue("ObjectSchemaId", new Guid(senderValue));
						Page.Grid.PageInstance.Process.SetPropertyValue("UpdateSchema", true);
					} else {
						Page.Grid.PageInstance.Process.SetPropertyValue("UpdateSchema", false);
					}
				}
				return true;
		}

		public virtual bool InitScriptTask1Execute(ProcessExecutingContext context) {
			Page.OwnerEdit.PrepareLookupFilter += PrepareOwnerEditFilter;
			return true;
		}

		public override DataSourceRowConfig GetModuleRowConfig(Entity module) {
			base.GetModuleRowConfig(module);
			string primaryColumnName = module.Schema.PrimaryColumn.Name;
			string primaryColumnValue = module.GetColumnValue(primaryColumnName).ToString();
			var config = new DataSourceRowConfig(primaryColumnValue);
			var columnName = "ChangeTypeId";
			EntityColumnValue columnValue = module.FindEntityColumnValue(columnName);
			if (columnValue != null) {
				Guid changeType = module.GetTypedColumnValue<Guid>(columnName);
				string backgroundColor;
				if (changeType == new Guid("A852C33F-0BDD-E011-92C3-00155D04C01D")) {
					backgroundColor = "Green";
				} else if (changeType == new Guid("AA52C33F-0BDD-E011-92C3-00155D04C01D")) {
					backgroundColor = "Red";
				} else {
					backgroundColor = "Blue";
				}
				config.AddConfig(new DataSourceRowColorConfigValue(backgroundColor));
				return config;
			} else {
				return base.GetModuleRowConfig(module);
			}
		}

		public override void SetDefaultModuleParameters() {
			base.SetDefaultModuleParameters();
			Page.LeftControlLayout.Hidden = false;
		}

		public override void BasePrepeareFilters() {
			base.BasePrepeareFilters();
			if (LoggingDisabled) {
				return;
			}
			var dataSource = GetActiveDataSource();
			Guid schemaUId = dataSource.Schema.UId;
			//dataSource.Schema = null;
			dataSource.SchemaKind = EntitySchemaKind.TrackChangesInDB;
			//dataSource.Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(schemaUId).GetTrackChangesInDBSchema();
			DateTime startDate = (DateTime)Page.StartDateEdit.Value;
			DateTime endDate = (DateTime)Page.EndDateEdit.Value;
			Guid ownerId = (Guid)Page.OwnerEdit.Value;
			var filterGroup = dataSource.FindFiltersGroupByName("LogFilters");
			if (filterGroup != null) {
				dataSource.CurrentStructure.Filters.Remove(filterGroup);
			}
			filterGroup = dataSource.CurrentStructure.CreateFiltersGroup("LogFilters", LogicalOperationStrict.And);
			if ((startDate.Date != DateTime.MinValue.Date) && (endDate.Date != DateTime.MinValue.Date) && (startDate.Date == endDate.Date)) {
				filterGroup.Add(
						dataSource.CreateFilterWithParameters(
								FilterComparisonType.GreaterOrEqual,
								"ChangeTrackedOn", startDate.Date));
				filterGroup.Add(
						dataSource.CreateFilterWithParameters(
								FilterComparisonType.LessOrEqual,
								"ChangeTrackedOn", endDate.Date.AddDays(1).AddSeconds(-1)));
			}
			else {
				if (startDate.Date != DateTime.MinValue.Date) {
					filterGroup.Add(
						dataSource.CreateFilterWithParameters(
								FilterComparisonType.GreaterOrEqual,
								"ChangeTrackedOn", startDate.Date));
				}
				if (endDate.Date != DateTime.MinValue.Date) {
					filterGroup.Add(
						dataSource.CreateFilterWithParameters(
								FilterComparisonType.LessOrEqual,
								"ChangeTrackedOn", endDate.Date.AddDays(1).AddSeconds(-1)));
				}
			}
			if ((ownerId != Guid.Empty) && (Page.OwnerCheckBox.Checked)) {
				filterGroup.Add(
					dataSource.CreateFilterWithParameters(
							FilterComparisonType.Equal,
							"ChangeTrackedBy", ownerId));
			}
			dataSource.CurrentStructure.Filters.Add(filterGroup);
		}

		public override void SetProcessExtraParameters(Process moduleProcess, ProcessSchema processSchema) {
			if (processSchema.Parameters.ExistsByName("CurrentSchemaUId")) {
				moduleProcess.SetPropertyValue("CurrentSchemaUId", Page.ObjectComboBoxEdit.Value);
			}
			if (processSchema.Parameters.ExistsByName("GridProcessUId")) {
				moduleProcess.SetPropertyValue("GridProcessUId", Page.Grid.PageInstance.Process.InstanceUId);	
			}
		}

		public virtual void SetCurrentUser() {
			Guid contactId = UserConnection.CurrentUser.ContactId;
			string contactName = UserConnection.CurrentUser.ContactName;
			Page.OwnerEdit.SetValueAndText(contactId, contactName);
		}

		public virtual void FilterMenuItemClick(string data) {
			if (!Page.PeriodCheckBox.Checked) {
				return;
			}
			ManuaStartDateChange = true;
			ManuaEndDateChange = true;
			string[] filterParameters = data.Split('&');
			if (filterParameters.Length == 2){
				DateTime startDate = DateTime.Today;
				DateTime endDate = DateTime.Today;
				var period = filterParameters[0];
				var value = Convert.ToInt32(filterParameters[1]);
				switch(period){
					case "day":
							startDate = startDate.AddDays(value);
							endDate = startDate;
							break;
					case "week":
							DayOfWeek day = DateTime.Today.DayOfWeek;
							int days = day - DayOfWeek.Monday;
							if ((int)day == 0) {
								days = 6;
							}
							startDate = startDate.AddDays(-days+value*7);
							endDate = startDate.AddDays(6);
							break;
					case "month":
							startDate = startDate.AddDays(1-startDate.Day).AddMonths(value);
							endDate = startDate.AddMonths(1).AddDays(-1);
							break;
				}
				Page.StartDateEdit.Value = startDate;
				Page.EndDateEdit.Value = endDate;	
			}
			UpdateLogGrid();
		}

		public virtual void UpdateLogGrid() {
			Page.Grid.PageInstance.ThrowEvent("FilterChanged");
		}

		public virtual void FillLogObjectsCombo() {
			if (LogObjectsList != null) {
				var list = LogObjectsList as List<Tuple<string, string>>;
				foreach (var item in list) {
					Page.ObjectComboBoxEdit.AddItem(item.Item1, item.Item2);
				}	
				if (list.Count > 0) {		
					Page.ObjectComboBoxEdit.SelectItem(list[0].Item1);		
					Page.Grid.PageInstance.ThrowEvent("ObjectChanged");
				}
			}
		}

		public virtual void SendObjectChanged(Guid schemaId) {
			Page.Grid.PageInstance.Process.SetPropertyValue("ObjectSchemaId", schemaId);
			Page.Grid.PageInstance.ThrowEvent("ObjectChanged");
		}

		public virtual void DisableChangelogControlPanel() {
			Page.FilterControlLayout.SetEnabled(false, true);
			Page.ObjectControlLayout.SetEnabled(false, true);
		}

		public virtual void PrepareOwnerEditFilter(object sender, LookupEditEventArgs e) {
			var filters = e.Filters;
			filters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.Equal}, 
				{"leftExpressionColumnPath", "[SysAdminUnit:Contact].Id"},
				{"aggregationType", AggregationTypeStrict.Count},
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", new object[] {1}}});
		}

		public override bool OnPageLoadComlete() {
			if (!Page.CustomSearchContainer.Hidden) {
				SetCustomFilterDetails();
				Page.CustomSearchContainer.PageInstance.ThrowEvent("Initialize");
			}
			if (Ext.IsAjaxRequest) {
				return true;
			}
			if (Page.Grid.PageInstance == null) {
				Page.GridTab.Hidden = true;
			}
			var gridInstance = Page.Grid.PageInstance as Terrasoft.WebApp.BaseGridPageSchemaUserControl;
			var dataSource = GetActiveDataSource();
			if (gridInstance != null) {
				gridInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);	
				SetPageKeyShortcuts(gridInstance);
			}
			if (FoldersMode != "None") {
				var process = Page.BaseFolder.PageInstance.Process;
				process.SetPropertyValue("EntitySchemaUId", FolderEntitySchemaUId);
				process.SetPropertyValue("ListenerPage", Page);
				process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
				process.SetPropertyValue("IsMultiFolder", FoldersMode == "MultiFolderEntry");
				Page.BaseFolder.PageInstance.ThrowEvent("Initialize");
			} else if (dataSource != null && dataSource.Schema != null) {
				dataSource.LoadRows();
			}
			var detailsTabPanel = Page.DetailsTabPanel;
			if(detailsTabPanel.Tabs.Count == 0) {
				detailsTabPanel.ActiveTabIndex = -1;
				if (Page.DetailsTabPanel.Hidden == false) {
					Page.DetailsTabPanel.Hidden = true;
				}		
			} else {
				if (Page.DetailsTabPanel.Hidden == true) {
					Page.DetailsTabPanel.Hidden = false;
				}
			}
			var activeTabIndex = Page.GridTab.Hidden ? 1 : 0;
			var profileData = ((Terrasoft.UI.WebControls.Page)Page.AspPage).ProfileData;
			if (profileData != null) {
				var profileTabPanelItem = profileData[Page.GridTabPanel.ClientID];	
				if (profileTabPanelItem != null) {
					if (profileTabPanelItem.Values.ContainsKey("activetabindex")) {
						activeTabIndex = (int)(long)(profileTabPanelItem.Values["activetabindex"]);
					}	
				}
			}
			var tabs = Page.GridTabPanel.Tabs;
			bool showDetails = true;
			if (activeTabIndex < tabs.Count) {
				showDetails = !(tabs[activeTabIndex].Name == AnalyticsTabName);
			}
			DisplayDetailsTabPanel(showDetails);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "MonthButtonClick":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
						}
						break;
					case "WeekButtonClick":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
						}
						break;
					case "DayButtonClick":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
						}
						break;
					case "PeriodMenuItemClick":
							if (ActivatedEventElements.Contains("PeriodMenuItemClickStartSignal")) {
							context.QueueTasks.Enqueue("PeriodMenuItemClickStartSignal");
						}
						break;
					case "OwnerCheckBoxCheck":
							if (ActivatedEventElements.Contains("StartMessage6")) {
							context.QueueTasks.Enqueue("StartMessage6");
						}
						break;
					case "ConfirmMessage":
							if (ActivatedEventElements.Contains("StartMessage7")) {
							context.QueueTasks.Enqueue("StartMessage7");
						}
						break;
					case "PeriodCheckBoxCheck":
							if (ActivatedEventElements.Contains("StartMessage8")) {
							context.QueueTasks.Enqueue("StartMessage8");
						}
						break;
					case "StartDateEditChange":
							if (ActivatedEventElements.Contains("StartMessage9")) {
							context.QueueTasks.Enqueue("StartMessage9");
						}
						break;
					case "EndDateEditChange":
							if (ActivatedEventElements.Contains("StartMessage10")) {
							context.QueueTasks.Enqueue("StartMessage10");
						}
						break;
					case "OwnerEditChange":
							if (ActivatedEventElements.Contains("StartMessage11")) {
							context.QueueTasks.Enqueue("StartMessage11");
						}
						break;
					case "ObjectComboBoxEditChange":
							if (ActivatedEventElements.Contains("StartMessage12")) {
							context.QueueTasks.Enqueue("StartMessage12");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage13")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage13");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage14")) {
							context.QueueTasks.Enqueue("InitStartMessage14");
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
			if (!HasMapping("LoggingDisabled") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LoggingDisabled", LoggingDisabled, false);
			}
			if (LogObjectsList != null) {
				if (LogObjectsList.GetType().IsSerializable ||
					LogObjectsList.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("LogObjectsList", LogObjectsList, null);
				}
			}
			if (!HasMapping("ManuaEndDateChange") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ManuaEndDateChange", ManuaEndDateChange, false);
			}
			if (!HasMapping("ManuaStartDateChange") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ManuaStartDateChange", ManuaStartDateChange, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogModulePageEventsProcess

	/// <exclude/>
	public class ChangeLogModulePageEventsProcess : ChangeLogModulePageEventsProcess<Terrasoft.WebApp.ChangeLogModulePageSchemaUserControl>
	{

		public ChangeLogModulePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ChangeLogModulePageSchemaUserControl

	/// <exclude/>
	public partial class ChangeLogModulePageSchemaUserControl : Terrasoft.WebApp.BaseModulePageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("FilterControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox PeriodCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("PeriodCheckBox", true);
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout6", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox OwnerCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("OwnerCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit OwnerEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("OwnerEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton CurrentUserToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("CurrentUserToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ObjectControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ObjectControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ObjectComboBoxEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ObjectComboBoxEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			PeriodCheckBox.AjaxEvents.Check.Event += PeriodCheckBoxCheck;
			DayButton.AjaxEvents.Click.Event += DayButtonClick;
			WeekButton.AjaxEvents.Click.Event += WeekButtonClick;
			MonthButton.AjaxEvents.Click.Event += MonthButtonClick;
			StartDateEdit.AjaxEvents.Change.Event += StartDateEditChange;
			EndDateEdit.AjaxEvents.Change.Event += EndDateEditChange;
			OwnerCheckBox.AjaxEvents.Check.Event += OwnerCheckBoxCheck;
			OwnerEdit.AjaxEvents.Change.Event += OwnerEditChange;
			ObjectComboBoxEdit.AjaxEvents.Change.Event += ObjectComboBoxEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			PeriodCheckBox.AjaxEvents.Check.Event -= PeriodCheckBoxCheck;
			DayButton.AjaxEvents.Click.Event -= DayButtonClick;
			WeekButton.AjaxEvents.Click.Event -= WeekButtonClick;
			MonthButton.AjaxEvents.Click.Event -= MonthButtonClick;
			StartDateEdit.AjaxEvents.Change.Event -= StartDateEditChange;
			EndDateEdit.AjaxEvents.Change.Event -= EndDateEditChange;
			OwnerCheckBox.AjaxEvents.Check.Event -= OwnerCheckBoxCheck;
			OwnerEdit.AjaxEvents.Change.Event -= OwnerEditChange;
			ObjectComboBoxEdit.AjaxEvents.Change.Event -= ObjectComboBoxEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ChangeLogModulePageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ChangeLogModulePageEventsProcess(UserConnection);
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

		public virtual void PeriodCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("PeriodCheckBoxCheck");
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

		public virtual void OwnerCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("OwnerCheckBoxCheck");
		}

		public virtual void OwnerEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("OwnerEditChange");
		}

		public virtual void ObjectComboBoxEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ObjectComboBoxEditChange");
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
			SchemaName = "ChangeLogModulePage";
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogModulePageEventsProcessSchema

	/// <exclude/>
	public class ChangeLogModulePageEventsProcessSchema : Terrasoft.WebApp.BaseModulePageEventsProcessSchema
	{

		#region Constructors: Public

		public ChangeLogModulePageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ChangeLogModulePageEventsProcessSchema(ChangeLogModulePageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ChangeLogModulePageEventsProcess";
			UId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateManuaStartDateChangeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ad07fd01-c3c4-4d43-8473-3e3f7e10cbe3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"ManuaStartDateChange",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateManuaEndDateChangeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("06aa8fe1-a8f4-4961-a2f8-470a49b00b7b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"ManuaEndDateChange",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLogObjectsListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("70d4fafb-3a5a-4ac4-a4da-35c3930699ae"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"LogObjectsList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoggingDisabledParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bedf8aa2-fba1-457e-885a-ea771a651303"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"LoggingDisabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateManuaStartDateChangeParameter());
			Parameters.Add(CreateManuaEndDateChangeParameter());
			Parameters.Add(CreateLogObjectsListParameter());
			Parameters.Add(CreateLoggingDisabledParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet301 = CreateLaneSet301LaneSet();
			LaneSets.Add(schemaLaneSet301);
			ProcessSchemaLane schemaLane925 = CreateLane925Lane();
			schemaLaneSet301.Lanes.Add(schemaLane925);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess14 = CreateEventSubProcess14EventSubProcess();
			FlowElements.Add(eventsubprocess14);
			ProcessSchemaEventSubProcess eventsubprocess15 = CreateEventSubProcess15EventSubProcess();
			FlowElements.Add(eventsubprocess15);
			ProcessSchemaEventSubProcess eventsubprocess16 = CreateEventSubProcess16EventSubProcess();
			FlowElements.Add(eventsubprocess16);
			ProcessSchemaEventSubProcess eventsubprocess17 = CreateEventSubProcess17EventSubProcess();
			FlowElements.Add(eventsubprocess17);
			ProcessSchemaEventSubProcess eventsubprocess18 = CreateEventSubProcess18EventSubProcess();
			FlowElements.Add(eventsubprocess18);
			ProcessSchemaEventSubProcess eventsubprocess19 = CreateEventSubProcess19EventSubProcess();
			FlowElements.Add(eventsubprocess19);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage5);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask5);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess9.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask2);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask daybuttonclickscripttask = CreateDayButtonClickScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(daybuttonclickscripttask);
			ProcessSchemaStartSignalEvent periodmenuitemclickstartsignal = CreatePeriodMenuItemClickStartSignalStartSignalEvent();
			eventsubprocess11.FlowElements.Add(periodmenuitemclickstartsignal);
			ProcessSchemaScriptTask periodmenuitemclickscripttask = CreatePeriodMenuItemClickScriptTaskScriptTask();
			eventsubprocess11.FlowElements.Add(periodmenuitemclickscripttask);
			ProcessSchemaStartMessageEvent startmessage6 = CreateStartMessage6StartMessageEvent();
			eventsubprocess12.FlowElements.Add(startmessage6);
			ProcessSchemaScriptTask ownercheckboxcheckscripttask = CreateOwnerCheckBoxCheckScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(ownercheckboxcheckscripttask);
			ProcessSchemaStartMessageEvent startmessage7 = CreateStartMessage7StartMessageEvent();
			eventsubprocess12.FlowElements.Add(startmessage7);
			ProcessSchemaStartMessageEvent startmessage8 = CreateStartMessage8StartMessageEvent();
			eventsubprocess13.FlowElements.Add(startmessage8);
			ProcessSchemaScriptTask periodcheckboxcheckscripttask = CreatePeriodCheckBoxCheckScriptTaskScriptTask();
			eventsubprocess13.FlowElements.Add(periodcheckboxcheckscripttask);
			ProcessSchemaStartMessageEvent startmessage9 = CreateStartMessage9StartMessageEvent();
			eventsubprocess14.FlowElements.Add(startmessage9);
			ProcessSchemaScriptTask startdateeditchangescripttask = CreateStartDateEditChangeScriptTaskScriptTask();
			eventsubprocess14.FlowElements.Add(startdateeditchangescripttask);
			ProcessSchemaStartMessageEvent startmessage10 = CreateStartMessage10StartMessageEvent();
			eventsubprocess15.FlowElements.Add(startmessage10);
			ProcessSchemaScriptTask enddateeditchangescripttask = CreateEndDateEditChangeScriptTaskScriptTask();
			eventsubprocess15.FlowElements.Add(enddateeditchangescripttask);
			ProcessSchemaStartMessageEvent startmessage11 = CreateStartMessage11StartMessageEvent();
			eventsubprocess16.FlowElements.Add(startmessage11);
			ProcessSchemaScriptTask scripttask6 = CreateScriptTask6ScriptTask();
			eventsubprocess16.FlowElements.Add(scripttask6);
			ProcessSchemaStartMessageEvent startmessage12 = CreateStartMessage12StartMessageEvent();
			eventsubprocess17.FlowElements.Add(startmessage12);
			ProcessSchemaScriptTask objectcomboboxeditchangescripttask = CreateObjectComboBoxEditChangeScriptTaskScriptTask();
			eventsubprocess17.FlowElements.Add(objectcomboboxeditchangescripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage13 = CreatePageLoadCompleteStartMessage13StartMessageEvent();
			eventsubprocess18.FlowElements.Add(pageloadcompletestartmessage13);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess18.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess18.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent initstartmessage14 = CreateInitStartMessage14StartMessageEvent();
			eventsubprocess19.FlowElements.Add(initstartmessage14);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess19.FlowElements.Add(initscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess19.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask initscripttask1 = CreateInitScriptTask1ScriptTask();
			eventsubprocess19.FlowElements.Add(initscripttask1);
			FlowElements.Add(CreateSequenceFlow5649SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5650SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5651SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5652SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5653SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5654SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5655SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5656SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5657SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5658SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5659SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5660SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5661SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5662SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5663SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateConfirmationLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateWaitingLocalizableStringLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateConfirmationLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0e318eeb-073e-4bf2-afc5-dcb1bae7ff05"),
				Name = "ConfirmationLocalizableString",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWaitingLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7e55263c-b8a3-4cb9-954e-c42359a8ff99"),
				Name = "WaitingLocalizableString",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5649SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5649",
				UId = new Guid("6e1d71a5-4cb7-41fa-8e34-b0351d090c8a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d085ed82-72ba-46c3-a1e5-0e47143de821"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("76705411-4d75-4ce4-9826-2bbeefe9777e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5650SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5650",
				UId = new Guid("ee0db88b-8d42-48b5-a686-46a42fbfe814"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c958ff7-eb1c-4004-a5b0-052902448f17"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8ed1f6b6-fac2-42e4-98f5-122ad23e1911"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5651SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5651",
				UId = new Guid("6e472dd8-d5c3-4273-99fb-d9e1c73ef4ef"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b280fe5f-9231-440a-a79e-2fe7e38ca88d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1359470f-4e64-4404-bcea-ad4f3f9988ee"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5652SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5652",
				UId = new Guid("27597e73-bb85-4869-aef1-3a064cccd5d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(494, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dcff9092-8a22-47ca-84a9-d58c8db152d1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5d95c30b-4aef-4610-8689-d13034225aa0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5653SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5653",
				UId = new Guid("774f673e-ebd6-45d2-a50e-3d55f4672885"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("31a7d5a9-ae05-4aef-b872-5acf5cadf97b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aa8dbcfa-1981-4069-ae4d-c0c2131e3b55"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5654SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5654",
				UId = new Guid("3cdbe302-1f80-422c-889d-bb6c5abee207"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(586, 238),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2acfc05-1101-43b1-864b-1527ba902dc2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aa8dbcfa-1981-4069-ae4d-c0c2131e3b55"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5655SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5655",
				UId = new Guid("85766d09-caf8-4021-8058-5aed16c23adc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("23b54c51-47e2-4102-9c6a-421beba93e2b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bc17f755-78e0-416e-bb61-776472f16232"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5656SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5656",
				UId = new Guid("6c4268a3-d2ad-4f20-8aa0-a8c99924da47"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cba2127e-fa5c-453e-a032-461dfc69d248"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b1ba8c24-9afa-4111-8950-2fa26d60b445"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5657SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5657",
				UId = new Guid("dce356ec-cbed-44dd-b972-835312e92bff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3e4d46aa-5cea-4deb-987b-1fbf232a7bea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3a96567a-1c35-4213-990a-83763c540df1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5658SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5658",
				UId = new Guid("7028b3de-366b-4ef9-96ce-3eb5b618ebe4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("954ec25c-8ef9-479d-9dd3-8d98f577bd4f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("91494b60-0027-470d-bde5-22657e51a687"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5659SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5659",
				UId = new Guid("e725d61c-39e2-40f0-a2d5-df518f76e660"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b6a5749-20af-4da8-ac52-07f39b9503d6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("189db39d-9bdd-4ced-839c-8cabab91559e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5660SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5660",
				UId = new Guid("570019f2-b182-4a4b-9c0c-8371b6c3c98e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(180, 1065),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e3c18b95-062a-4d9c-912a-1456932d6beb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dbd8996b-4277-44ef-a43a-4a8b51d99e5c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5661SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5661",
				UId = new Guid("b857abb9-5dcf-45e7-bcb5-76ec9f5f0e8f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(352, 1064),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dbd8996b-4277-44ef-a43a-4a8b51d99e5c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18f2d73c-ec62-4e17-b2be-c89c6f95a263"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5662SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5662",
				UId = new Guid("5b05a1f3-8f76-41b6-a2ad-b2857446ac7d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(182, 1260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f242f423-7679-4c27-a402-752d2932ddc0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97e82799-2a9d-42a0-8c9f-7c32b8b89657"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5663SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5663",
				UId = new Guid("7fa9c7e6-f109-4d8a-a95c-7293621a614a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(352, 1256),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97e82799-2a9d-42a0-8c9f-7c32b8b89657"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a16ea0fb-eb2f-45fa-acee-adaa38de55d4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a981b7f1-cbc4-48db-be66-8d4dd9029d4c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CurveCenterPosition = new Point(489, 520),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a16ea0fb-eb2f-45fa-acee-adaa38de55d4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b717993-23c6-4cd7-a6b2-07e15ac6624e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet301LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet301 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("66a02c97-7f06-4ae2-bf43-e3addbb94838"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"LaneSet301",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(757, 479),
				UseBackgroundMode = false
			};
			return schemaLaneSet301;
		}

		protected virtual ProcessSchemaLane CreateLane925Lane() {
			ProcessSchemaLane schemaLane925 = new ProcessSchemaLane(this) {
				UId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("66a02c97-7f06-4ae2-bf43-e3addbb94838"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"Lane925",
				Position = new Point(29, 0),
				Size = new Size(728, 479),
				UseBackgroundMode = false
			};
			return schemaLane925;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eb50784d-5cfe-4b17-a0a5-153b4d1e4bb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess10",
				Position = new Point(36, 163),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b280fe5f-9231-440a-a79e-2fe7e38ca88d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb50784d-5cfe-4b17-a0a5-153b4d1e4bb7"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MonthButtonClick",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage5",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1359470f-4e64-4404-bcea-ad4f3f9988ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb50784d-5cfe-4b17-a0a5-153b4d1e4bb7"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"ScriptTask5",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,41,73,45,242,77,205,43,245,44,73,205,117,206,201,76,206,214,112,80,202,205,207,43,201,80,51,80,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,214,78,145,121,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9fab3796-91d1-4236-880c-8beee35e6296"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess9",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4c958ff7-eb1c-4004-a5b0-052902448f17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9fab3796-91d1-4236-880c-8beee35e6296"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"WeekButtonClick",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage4",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8ed1f6b6-fac2-42e4-98f5-122ad23e1911"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9fab3796-91d1-4236-880c-8beee35e6296"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"ScriptTask2",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("705fa23c-6517-4c4f-9d86-0965bb024309"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 317),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(270, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d085ed82-72ba-46c3-a1e5-0e47143de821"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("705fa23c-6517-4c4f-9d86-0965bb024309"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DayButtonClick",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage3",
				Position = new Point(43, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDayButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("76705411-4d75-4ce4-9826-2bbeefe9777e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("705fa23c-6517-4c4f-9d86-0965bb024309"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"DayButtonClickScriptTask",
				Position = new Point(162, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,41,73,45,242,77,205,43,245,44,73,205,117,206,201,76,206,214,112,80,74,73,172,84,51,80,210,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,34,210,105,53,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("149749eb-7e42-444b-804e-658231069b96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(329, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(329, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartSignalEvent CreatePeriodMenuItemClickStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("dcff9092-8a22-47ca-84a9-d58c8db152d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("149749eb-7e42-444b-804e-658231069b96"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
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
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"PeriodMenuItemClickStartSignal",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 51),
				SerializeToDB = false,
				Signal = @"PeriodMenuItemClick",
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = false,
				WaitingRandomSignal = true
			};
			
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePeriodMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5d95c30b-4aef-4610-8689-d13034225aa0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("149749eb-7e42-444b-804e-658231069b96"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"PeriodMenuItemClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,201,61,10,194,64,16,6,208,222,83,12,169,54,32,185,64,84,16,127,192,194,202,116,98,177,46,195,186,26,103,96,230,219,168,183,87,108,223,155,162,145,211,146,66,82,1,191,209,13,55,211,215,110,98,193,218,178,19,69,167,109,73,40,42,209,62,11,135,21,201,115,189,222,57,97,213,158,27,196,220,92,186,65,79,255,8,109,63,219,151,17,108,71,150,122,0,63,55,99,73,143,224,63,55,70,53,33,88,229,254,11,96,130,70,57,118,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9d7cf1a1-2668-47f5-9866-30efe4255ccd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess12",
				Position = new Point(329, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(332, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("31a7d5a9-ae05-4aef-b872-5acf5cadf97b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d7cf1a1-2668-47f5-9866-30efe4255ccd"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OwnerCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage6",
				Position = new Point(28, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOwnerCheckBoxCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aa8dbcfa-1981-4069-ae4d-c0c2131e3b55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d7cf1a1-2668-47f5-9866-30efe4255ccd"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"OwnerCheckBoxCheckScriptTask",
				Position = new Point(119, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,8,45,72,73,44,73,245,201,79,119,47,202,76,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,3,98,66,148,30,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage7StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d2acfc05-1101-43b1-864b-1527ba902dc2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d7cf1a1-2668-47f5-9866-30efe4255ccd"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ConfirmMessage",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7d2e8b97-26e1-4d34-b457-cf6c9f478410"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess13",
				Position = new Point(329, 322),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(332, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage8StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("23b54c51-47e2-4102-9c6a-421beba93e2b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7d2e8b97-26e1-4d34-b457-cf6c9f478410"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PeriodCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage8",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePeriodCheckBoxCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bc17f755-78e0-416e-bb61-776472f16232"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7d2e8b97-26e1-4d34-b457-cf6c9f478410"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"PeriodCheckBoxCheckScriptTask",
				Position = new Point(190, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,193,10,130,64,16,134,207,237,83,44,30,66,47,210,93,132,104,179,8,18,132,232,1,38,119,210,197,109,141,109,23,138,232,221,211,53,76,202,154,211,192,247,49,255,63,226,72,253,12,10,12,51,212,162,230,172,196,188,90,212,215,208,45,200,105,28,83,163,45,6,244,78,104,59,206,221,25,208,102,9,6,19,46,76,152,40,56,200,86,117,102,52,240,18,197,255,91,43,33,13,234,20,149,221,24,60,49,41,242,202,159,123,28,110,211,153,23,68,228,65,80,94,176,137,158,164,160,44,244,177,172,4,85,96,127,170,163,175,176,15,54,94,153,73,4,237,7,111,60,108,250,5,127,189,123,132,166,221,248,141,49,105,127,230,13,222,214,197,90,11,238,187,247,136,70,99,181,234,186,62,1,106,154,60,81,139,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b584d124-8762-4b72-b25a-34e3bed7defb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess14",
				Position = new Point(35, 491),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 136),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage9StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cba2127e-fa5c-453e-a032-461dfc69d248"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b584d124-8762-4b72-b25a-34e3bed7defb"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"StartDateEditChange",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage9",
				Position = new Point(29, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateStartDateEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b1ba8c24-9afa-4111-8950-2fa26d60b445"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b584d124-8762-4b72-b25a-34e3bed7defb"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartDateEditChangeScriptTask",
				Position = new Point(162, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,77,204,43,77,12,46,73,44,42,113,73,44,73,117,206,72,204,75,79,213,84,168,230,226,12,45,72,1,10,248,228,167,187,23,101,166,104,104,90,115,114,213,42,112,97,83,173,96,171,144,150,152,83,156,106,205,85,148,90,82,90,148,167,80,82,84,154,106,13,0,223,89,184,177,93,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("153f77f5-8332-4920-a37a-bd4a6a3bb5b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess15",
				Position = new Point(329, 491),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(332, 136),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage10StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3e4d46aa-5cea-4deb-987b-1fbf232a7bea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("153f77f5-8332-4920-a37a-bd4a6a3bb5b9"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EndDateEditChange",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage10",
				Position = new Point(36, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEndDateEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3a96567a-1c35-4213-990a-83763c540df1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("153f77f5-8332-4920-a37a-bd4a6a3bb5b9"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EndDateEditChangeScriptTask",
				Position = new Point(190, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,77,204,43,77,116,205,75,113,73,44,73,117,206,72,204,75,79,213,84,168,230,226,12,45,72,1,10,248,228,167,187,23,101,166,104,104,90,115,114,213,114,97,42,85,176,85,72,75,204,41,78,181,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,53,135,215,238,88,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("82d70f98-3d9a-4059-808e-cc111898ded6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess16",
				Position = new Point(35, 645),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 136),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage11StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("954ec25c-8ef9-479d-9dd3-8d98f577bd4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82d70f98-3d9a-4059-808e-cc111898ded6"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OwnerEditChange",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage11",
				Position = new Point(29, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask6ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("91494b60-0027-470d-bde5-22657e51a687"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82d70f98-3d9a-4059-808e-cc111898ded6"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"ScriptTask6",
				Position = new Point(162, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,245,201,79,119,47,202,76,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,148,225,202,126,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess17EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess17 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("97e90b6e-099a-489c-a63e-aef26365c648"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess17",
				Position = new Point(36, 807),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess17;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage12StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6b6a5749-20af-4da8-ac52-07f39b9503d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97e90b6e-099a-489c-a63e-aef26365c648"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectComboBoxEditChange",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"StartMessage12",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateObjectComboBoxEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("189db39d-9bdd-4ced-839c-8cabab91559e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97e90b6e-099a-489c-a63e-aef26365c648"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"ObjectComboBoxEditChangeScriptTask",
				Position = new Point(161, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,81,203,78,195,48,16,60,183,82,255,193,228,212,72,200,63,80,245,210,80,170,92,160,144,2,103,55,222,182,134,196,134,245,58,165,66,252,59,107,247,45,36,31,86,187,51,59,179,227,78,161,88,163,209,98,44,230,106,13,114,198,245,104,208,239,184,173,21,169,202,5,172,129,135,17,35,239,141,213,17,85,56,75,232,154,201,238,65,181,48,204,238,78,192,44,23,202,139,5,32,42,239,86,36,95,74,249,6,203,3,220,203,83,49,181,100,104,119,230,177,162,89,137,225,133,226,205,88,216,208,52,185,248,25,244,123,209,205,202,52,4,232,217,202,25,37,139,128,8,150,42,194,80,83,64,96,135,9,53,58,144,190,130,169,63,246,61,38,30,86,164,51,142,222,159,206,136,44,143,180,232,227,146,118,101,164,119,92,241,12,173,235,224,18,152,200,191,131,62,191,148,85,204,169,180,158,148,101,159,115,116,53,120,47,43,32,46,63,1,105,247,170,154,192,250,143,203,119,168,169,170,55,208,170,82,103,183,22,182,98,22,140,30,166,223,216,79,11,215,46,221,196,125,79,181,33,94,209,112,11,116,73,208,202,180,36,143,210,255,53,23,27,116,219,105,199,241,28,85,138,141,178,107,208,233,78,4,206,203,10,14,14,70,127,120,65,212,228,4,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess18EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess18 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("79020eea-3350-4e87-acdf-a47e0b6c3783"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess18",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 981),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(423, 183),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess18;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessage13StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e3c18b95-062a-4d9c-912a-1456932d6beb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79020eea-3350-4e87-acdf-a47e0b6c3783"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"PageLoadCompleteStartMessage13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dbd8996b-4277-44ef-a43a-4a8b51d99e5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79020eea-3350-4e87-acdf-a47e0b6c3783"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,193,110,219,48,12,61,39,64,254,65,243,197,50,96,24,219,181,129,129,181,142,59,12,104,154,96,233,218,179,98,51,142,58,89,10,36,185,73,102,248,223,71,73,78,81,96,221,122,49,36,234,241,241,241,145,230,59,66,63,253,52,160,11,37,37,84,150,43,153,45,110,54,80,117,154,219,115,41,27,46,33,251,6,182,96,178,60,97,212,194,234,0,154,57,28,141,48,248,200,225,136,169,59,222,116,33,26,37,9,233,103,211,201,71,156,197,30,170,95,255,98,93,50,201,26,40,246,76,54,112,167,154,40,153,207,166,195,108,202,81,44,94,49,191,89,112,195,182,2,234,80,108,188,133,4,161,26,44,108,181,18,107,38,65,80,151,60,209,96,59,45,137,213,29,4,174,53,22,200,214,160,185,170,189,148,27,117,10,154,160,38,249,5,231,65,171,163,196,86,254,143,217,88,166,237,130,89,40,107,110,179,71,38,58,64,132,11,60,240,22,178,123,117,188,32,75,89,127,132,219,160,221,157,214,32,173,51,209,235,127,97,154,88,104,15,2,145,152,240,53,218,117,210,27,75,147,190,231,59,90,5,85,121,190,99,194,0,198,202,147,205,150,96,12,150,116,170,43,55,34,221,210,184,255,60,196,105,220,127,193,239,43,197,214,74,207,66,220,41,207,99,169,98,188,131,200,12,10,9,196,212,53,155,204,135,1,144,222,191,85,76,8,215,208,18,236,94,213,52,126,216,107,117,44,95,80,116,156,246,189,225,141,100,226,158,181,112,21,23,161,246,168,38,78,71,173,87,142,114,24,28,233,48,164,118,207,77,50,31,167,228,155,192,248,219,161,13,3,77,162,249,251,51,185,126,102,39,95,218,132,241,100,43,89,8,142,119,31,36,249,196,88,141,59,147,221,42,221,50,75,47,70,166,100,148,230,23,239,78,97,75,252,183,219,163,141,135,167,228,137,113,139,135,191,94,146,215,177,87,154,31,108,216,86,157,93,215,117,8,208,8,109,118,238,253,0,86,175,164,56,143,246,17,23,70,223,208,168,246,96,207,56,200,208,105,148,146,208,213,246,25,127,151,66,181,91,133,109,249,21,9,125,124,95,184,146,183,92,8,92,255,128,50,30,230,151,227,173,77,127,0,28,35,64,9,208,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("18f2d73c-ec62-4e17-b2be-c89c6f95a263"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("79020eea-3350-4e87-acdf-a47e0b6c3783"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess19EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess19 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ff30ed3c-b60c-4ea5-b769-676a71bfd88c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0222d991-8ab8-4ba5-a7c1-fb47b5ebd30e"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"EventSubProcess19",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 1177),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(679, 163),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess19;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessage14StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f242f423-7679-4c27-a402-752d2932ddc0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff30ed3c-b60c-4ea5-b769-676a71bfd88c"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"InitStartMessage14",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("97e82799-2a9d-42a0-8c9f-7c32b8b89657"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff30ed3c-b60c-4ea5-b769-676a71bfd88c"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,223,79,219,48,16,126,206,164,253,15,94,30,32,213,42,139,237,149,31,82,41,5,85,162,208,209,95,15,8,33,183,185,182,134,212,9,182,3,84,27,255,251,238,98,183,77,203,128,109,66,218,30,210,88,246,221,119,223,221,125,231,52,24,167,26,196,104,202,162,123,161,217,12,84,222,180,48,99,82,177,182,152,0,63,18,243,195,220,218,84,241,22,30,85,190,127,252,16,4,81,212,5,173,133,73,199,150,247,154,124,0,195,122,170,172,78,19,195,151,139,150,7,170,44,16,43,188,118,35,30,27,247,160,44,154,37,114,116,203,59,114,162,68,114,38,102,192,246,89,216,6,45,211,120,225,87,88,132,187,24,238,9,159,215,57,14,0,110,255,123,146,45,12,58,253,247,44,241,87,142,89,244,233,197,176,141,71,203,155,134,2,92,192,93,14,198,86,88,193,244,52,157,156,15,111,96,100,205,169,52,22,163,40,120,96,180,220,235,230,89,2,123,198,106,169,38,85,230,222,7,7,81,133,34,6,84,139,196,57,108,32,8,243,154,251,210,217,140,166,48,19,45,161,176,136,26,81,122,6,52,146,85,136,35,177,148,13,101,165,157,119,202,70,27,174,223,114,208,115,207,183,108,93,236,71,107,240,85,22,246,31,86,52,195,85,10,185,140,235,105,146,207,20,2,149,96,121,45,246,251,81,216,107,198,37,135,145,200,136,223,91,78,117,103,230,29,203,70,199,50,177,160,13,25,71,229,253,58,138,204,130,59,29,72,59,109,11,141,93,39,211,200,109,214,211,89,38,180,52,169,234,206,51,224,141,187,92,36,85,70,240,65,16,118,230,102,144,234,91,147,137,17,132,213,205,98,46,143,120,51,174,172,114,1,170,154,4,179,145,198,9,88,87,79,76,38,113,8,209,58,32,65,16,8,41,110,1,130,186,206,21,202,97,159,237,120,101,145,180,38,216,244,35,105,196,48,129,24,195,88,157,67,17,62,40,102,231,68,203,152,211,170,169,140,21,10,249,181,117,58,2,99,120,7,44,46,51,208,118,222,23,73,14,216,134,44,198,250,184,22,99,134,99,145,24,112,169,4,26,108,174,213,10,156,134,54,160,103,109,114,11,162,115,154,219,5,229,5,79,47,4,228,231,108,168,2,84,99,223,205,130,128,23,242,65,180,84,12,167,169,244,12,8,225,158,204,126,15,99,77,68,101,28,154,168,66,25,36,234,95,14,16,197,175,186,88,190,147,203,108,255,184,164,110,28,92,73,81,228,213,98,148,78,48,64,68,60,46,119,174,56,93,51,95,48,206,95,6,216,232,25,53,200,113,166,59,139,1,118,208,117,128,202,135,189,154,117,44,221,4,69,152,154,201,138,183,191,172,248,49,30,95,134,215,215,141,126,227,172,91,187,56,233,181,240,29,94,237,46,100,232,202,131,55,220,89,158,36,231,186,49,203,236,60,242,152,149,69,163,159,9,165,72,203,185,94,94,49,3,42,6,93,211,19,154,8,239,203,59,89,34,109,180,253,99,219,143,114,97,236,77,253,189,188,242,195,154,149,173,128,174,242,231,70,95,87,180,163,50,144,79,221,181,5,199,125,152,30,166,143,141,88,90,250,24,32,82,243,168,194,182,182,112,228,86,176,248,81,168,79,133,154,64,184,76,114,141,97,223,139,242,229,154,190,21,146,125,102,225,117,1,227,171,253,158,58,43,145,244,106,126,71,145,149,21,246,158,247,205,147,255,95,80,86,211,79,253,228,188,43,110,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a16ea0fb-eb2f-45fa-acee-adaa38de55d4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff30ed3c-b60c-4ea5-b769-676a71bfd88c"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7b717993-23c6-4cd7-a6b2-07e15ac6624e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff30ed3c-b60c-4ea5-b769-676a71bfd88c"),
				CreatedInOwnerSchemaUId = new Guid("6d43b969-e278-4e8a-932c-446176483d1b"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Name = @"InitScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(449, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,47,207,75,45,114,77,201,44,209,11,40,74,45,72,44,74,245,201,207,207,46,45,112,203,204,41,73,45,82,208,182,85,128,10,195,213,65,100,172,121,185,138,82,75,74,139,242,20,74,138,74,83,129,60,0,71,143,242,146,77,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetCurrentUserMethod());
			Methods.Add(CreateFilterMenuItemClickMethod());
			Methods.Add(CreateUpdateLogGridMethod());
			Methods.Add(CreateFillLogObjectsComboMethod());
			Methods.Add(CreateSendObjectChangedMethod());
			Methods.Add(CreateDisableChangelogControlPanelMethod());
			Methods.Add(CreatePrepareOwnerEditFilterMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a8d2abf8-07ab-4e55-8690-1a75dfa0f6da"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d6630e4d-7a19-48f1-9051-b7afb4319d94"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9eaf8c85-25b4-4106-b135-2ce7c11e0517"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80e9a624-774f-4aa9-bdc1-372108d985e1"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("66c04ada-c3e9-49ab-83a7-051f50d29d99"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f1f380c2-17a6-4748-871a-be4cb513b6b0"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cafacd03-d1a2-43da-8fb1-db3dc13351a7"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8a52f61f-eae7-4d4d-8095-62319ae446eb"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f54c9c05-732e-45af-939f-13fc737c792b"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdc1f75a-bdaa-4bb9-913e-3e80b88105af"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7e624e1a-9617-4102-957b-d7222d4aa9d1"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateGetModuleRowConfigMethod() {
			SchemaMethod method = base.CreateGetModuleRowConfigMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,111,130,48,24,62,99,226,127,232,56,193,1,2,115,36,91,246,145,40,168,217,97,203,162,102,247,74,95,177,25,180,166,210,25,179,248,223,215,82,50,235,215,118,216,129,3,111,159,175,62,188,204,241,26,194,49,212,47,156,200,18,38,124,147,114,182,160,133,87,53,239,254,125,183,179,174,5,101,5,90,9,90,97,177,77,121,41,43,246,138,43,64,143,200,128,194,105,190,132,10,135,111,54,34,212,144,11,236,119,92,74,139,174,220,173,185,119,98,228,135,51,62,109,100,60,157,231,19,11,148,55,33,149,4,131,13,202,112,141,167,92,138,220,138,127,234,183,167,90,23,112,211,37,102,5,204,182,43,120,38,174,66,12,89,77,235,131,152,249,185,200,35,202,200,9,212,219,75,107,51,186,64,158,77,190,82,105,101,89,250,232,171,219,113,198,146,18,148,255,152,31,148,161,7,196,210,125,208,224,167,35,117,167,45,118,142,243,143,66,112,201,52,131,11,125,210,24,91,210,166,37,45,226,185,253,219,228,58,237,245,70,65,52,200,178,96,24,197,113,112,167,6,65,20,197,73,146,69,55,105,20,103,174,111,50,58,71,218,186,175,177,0,96,186,40,103,135,160,92,3,250,213,172,255,63,179,9,16,219,234,18,108,160,58,50,56,245,152,205,8,251,132,180,155,112,102,67,20,207,28,154,207,118,36,233,55,245,10,168,165,96,237,162,169,129,149,161,61,154,255,249,231,236,190,1,193,120,106,165,93,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetDefaultModuleParametersMethod() {
			SchemaMethod method = base.CreateSetDefaultModuleParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,78,45,113,73,77,75,44,205,41,241,205,79,41,205,73,13,72,44,74,204,77,45,73,45,42,214,208,180,230,229,10,72,76,79,213,243,73,77,43,113,206,207,43,41,202,207,241,73,172,204,47,45,209,243,200,76,73,73,205,83,176,85,72,75,204,41,78,181,6,0,246,210,210,188,74,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateBasePrepeareFiltersMethod() {
			SchemaMethod method = base.CreateBasePrepeareFiltersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,85,93,111,218,48,20,125,38,191,194,227,161,74,164,206,85,159,17,15,36,80,132,214,14,52,232,246,236,38,183,96,53,177,51,219,97,139,38,254,251,174,157,0,78,41,26,147,86,105,47,40,185,31,39,247,156,115,109,158,152,6,26,227,207,66,65,9,76,193,29,207,13,40,29,70,131,128,63,147,240,94,174,215,92,172,199,92,179,167,28,178,136,252,10,122,10,76,165,196,32,216,5,91,166,72,198,12,91,202,74,165,64,134,100,10,102,148,26,190,133,241,33,106,145,166,21,207,136,78,55,80,176,199,89,134,117,199,38,186,116,97,138,241,65,112,115,115,146,192,98,81,229,249,32,56,201,124,226,194,66,77,132,225,166,62,134,232,74,177,244,37,217,48,177,6,61,19,227,248,28,236,163,6,149,72,33,0,7,150,130,250,56,15,76,176,53,40,138,116,102,66,27,38,82,136,107,156,48,60,112,136,108,238,245,151,154,102,75,24,233,195,138,23,64,176,89,25,251,134,31,12,247,209,104,129,232,116,185,79,77,50,110,232,87,150,87,224,53,130,200,222,110,155,52,9,191,201,201,43,127,8,80,78,220,208,190,55,197,115,27,244,75,173,99,207,206,226,169,146,85,217,181,226,14,229,107,253,119,217,184,254,204,10,8,251,184,4,109,184,223,174,133,15,241,161,113,200,173,134,7,150,84,74,129,48,75,163,170,20,247,197,162,59,8,250,5,10,185,5,31,34,178,187,116,118,170,19,160,68,1,10,224,15,218,25,241,154,224,11,79,89,62,47,65,49,235,45,182,242,212,208,145,200,218,241,195,131,45,212,137,140,20,246,34,211,7,46,156,86,46,19,145,171,43,18,182,94,92,84,251,10,121,56,36,126,119,228,84,242,168,210,81,150,133,65,175,215,81,206,227,247,141,155,205,130,41,180,193,157,74,91,217,235,53,169,68,22,37,83,92,75,177,170,75,160,83,215,165,230,106,242,189,98,249,117,83,217,111,182,211,45,42,100,115,129,226,116,7,140,80,145,247,153,231,30,180,254,227,48,190,54,246,211,99,86,235,240,54,178,143,75,72,165,200,116,248,241,54,138,220,130,64,174,193,170,103,13,188,220,63,108,248,239,244,222,53,36,46,93,171,119,163,240,143,45,66,94,187,230,120,237,239,34,36,101,239,34,58,41,74,83,55,231,227,120,45,37,27,72,95,98,249,147,186,7,252,111,57,119,54,254,130,231,155,52,61,130,93,126,113,141,252,218,89,155,29,187,228,254,178,83,117,46,175,223,16,22,64,203,68,7,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetProcessExtraParametersMethod() {
			SchemaMethod method = base.CreateSetProcessExtraParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,177,10,131,48,24,132,231,230,41,196,201,64,249,95,192,77,145,226,210,10,210,238,49,249,219,166,24,35,201,47,40,197,119,175,86,93,74,7,183,227,184,239,238,244,61,136,90,103,37,122,95,202,39,26,1,133,112,194,32,161,243,144,245,218,147,79,134,243,100,68,97,218,57,135,13,45,177,107,174,66,206,131,55,59,24,171,186,26,139,165,3,74,164,73,182,232,104,184,137,186,251,135,29,131,66,60,16,46,213,11,37,165,214,84,54,177,125,166,52,193,151,224,49,27,153,222,127,235,228,180,90,215,247,159,250,129,214,75,179,11,179,202,27,79,162,145,8,91,195,102,76,97,30,31,216,248,1,85,242,105,148,55,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnPageLoadComleteMethod() {
			SchemaMethod method = base.CreateOnPageLoadComleteMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,77,79,219,64,16,61,59,191,98,241,1,217,82,107,193,181,105,84,165,9,80,171,128,16,129,246,128,56,108,236,9,217,106,179,155,238,142,129,20,241,223,187,31,182,179,118,155,40,55,219,51,243,102,230,205,155,49,91,144,228,232,134,62,65,54,169,52,202,213,12,168,42,150,19,41,144,50,1,42,251,198,202,18,68,74,222,6,209,12,208,251,156,51,142,160,166,96,92,184,78,210,225,32,218,3,96,77,185,208,72,69,1,217,221,82,201,151,179,103,16,152,196,185,96,200,40,103,127,32,54,16,239,3,102,42,57,123,197,44,215,227,95,244,245,22,126,87,160,209,37,86,128,149,18,4,85,5,141,163,75,120,161,88,217,193,39,163,17,17,21,231,46,170,117,185,163,243,186,13,50,106,65,158,169,34,79,198,184,13,37,59,48,169,38,119,160,20,213,114,129,217,79,152,143,215,235,236,43,213,96,61,173,227,172,88,194,138,222,107,80,182,105,37,249,208,129,151,20,233,76,86,202,65,95,0,142,11,100,207,48,109,191,90,222,108,39,157,34,142,130,250,67,67,118,163,100,1,90,103,102,6,230,113,13,10,55,63,40,175,32,137,47,153,70,48,68,219,82,106,175,251,188,140,63,248,118,154,184,6,200,152,210,97,228,102,105,237,223,97,51,91,74,133,69,133,186,83,73,59,145,115,201,75,80,250,74,150,174,186,248,90,10,51,47,91,159,109,114,237,225,27,242,44,45,62,160,59,246,186,10,35,148,245,206,62,206,4,50,220,212,100,186,6,60,82,239,123,186,23,36,36,163,166,224,240,128,3,217,219,7,151,235,171,138,35,243,149,183,45,120,246,140,54,227,192,106,250,82,155,184,93,158,93,212,237,217,24,2,92,3,177,67,10,180,86,43,136,28,31,7,10,204,60,125,29,121,5,214,75,73,203,91,249,226,86,217,111,70,233,119,219,108,206,13,21,192,155,249,78,187,159,173,128,147,158,107,102,30,116,54,145,149,64,219,241,137,207,213,243,241,187,96,94,115,81,194,171,65,255,120,106,120,104,247,186,151,166,93,222,17,89,80,211,178,131,140,246,122,214,107,30,189,71,81,195,211,219,65,9,108,220,33,248,174,16,155,160,38,140,246,59,250,223,245,249,66,78,201,39,114,226,239,131,17,209,130,113,119,16,140,123,146,108,111,204,125,110,207,76,125,76,180,147,67,234,224,198,122,237,94,172,46,155,88,127,68,66,176,112,200,65,162,166,135,28,97,101,18,6,17,15,97,173,190,207,9,103,70,113,249,244,209,222,138,32,65,7,36,76,180,203,41,115,139,97,5,225,254,7,218,28,156,36,246,100,33,157,51,75,86,156,122,132,232,31,14,19,38,48,77,184,20,79,233,30,236,135,62,222,163,93,42,51,250,237,116,140,73,247,102,178,21,235,112,48,151,146,19,189,148,47,245,184,91,253,216,166,122,85,125,118,96,94,224,174,238,110,220,81,98,205,15,221,160,199,236,154,174,220,1,24,11,202,55,200,10,171,40,251,205,45,220,148,233,53,167,155,158,214,146,0,216,184,133,255,192,191,231,59,52,13,180,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetCurrentUserMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("48cf8395-ef1c-49cf-b0b5-8233f3215fcd"),
				Name = "SetCurrentUser",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,81,72,206,207,43,73,76,46,241,76,81,176,85,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,46,45,42,74,205,43,1,137,234,57,195,148,89,115,21,151,20,101,230,165,195,52,250,37,230,166,18,165,21,164,208,154,43,32,49,61,85,207,191,60,47,181,200,53,37,179,68,47,56,181,36,44,49,167,52,213,49,47,37,36,181,162,68,3,238,26,29,100,243,53,173,1,33,254,236,170,171,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFilterMenuItemClickMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6e4ef47c-f207-4401-b811-0a5774050ed9"),
				Name = "FilterMenuItemClick",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2fc7daf5-91b6-4982-a70e-1180b97b6222"),
				Name = "data",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,81,79,194,48,16,126,222,126,69,229,65,55,13,13,195,4,19,151,61,40,18,99,2,145,4,212,7,194,67,101,199,214,0,29,233,58,144,24,254,187,215,110,140,9,24,233,83,219,251,238,187,239,187,246,248,148,56,23,125,22,1,237,131,228,73,216,142,97,50,123,76,190,168,217,64,232,146,111,219,146,160,50,41,124,123,107,247,152,200,216,64,49,169,158,152,130,118,204,68,4,36,32,74,102,224,231,193,142,8,79,132,82,37,185,136,70,99,50,229,115,5,178,207,36,91,0,110,82,68,132,76,49,58,88,206,185,114,174,46,175,92,223,230,168,233,16,71,187,32,34,21,147,32,32,77,23,37,233,26,67,190,0,146,238,196,32,211,238,146,14,147,144,109,252,10,10,114,85,167,48,43,38,201,210,120,199,232,97,217,81,99,92,64,86,108,158,233,252,118,34,86,32,21,166,191,8,117,219,60,18,58,242,198,104,193,74,215,92,77,98,39,39,214,130,173,9,75,129,212,176,102,237,30,79,150,85,21,94,238,233,67,136,66,55,169,99,202,105,34,92,123,241,37,46,15,124,74,96,51,191,228,94,3,204,10,114,228,120,157,126,224,25,187,187,57,114,77,203,112,206,195,133,210,184,252,49,54,164,78,202,56,237,37,34,111,147,134,225,187,56,136,117,13,103,64,26,230,115,232,85,36,183,114,220,246,12,127,117,157,114,99,92,94,223,253,237,179,196,183,220,147,150,23,137,80,241,89,13,245,234,251,59,188,112,117,160,167,179,255,237,117,5,233,185,123,3,222,129,34,116,109,230,168,156,142,78,200,21,125,47,190,77,245,229,12,172,152,147,95,160,162,184,111,225,164,189,45,113,46,160,155,68,207,146,135,142,235,255,0,123,218,51,68,169,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateLogGridMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d1543f1f-26c2-428a-939a-84669d0c5cc2"),
				Name = "UpdateLogGrid",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,47,202,76,209,11,0,178,60,243,138,75,18,243,146,83,245,66,50,138,242,203,93,203,82,243,74,52,148,220,50,115,74,82,139,156,51,18,243,210,83,83,148,52,173,1,220,146,53,26,51,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillLogObjectsComboMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7924e4ac-383b-4cab-acde-98aa00a12335"),
				Name = "FillLogObjectsCombo",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,65,107,2,49,16,133,207,89,240,63,140,158,118,65,194,182,87,117,65,69,100,97,65,161,222,74,15,113,51,238,166,196,164,36,89,45,72,255,123,51,166,148,210,131,48,204,60,134,121,223,60,117,130,188,177,221,238,248,142,109,240,141,242,1,198,11,48,131,214,5,220,70,25,187,8,7,154,182,11,248,119,38,60,208,156,31,134,15,141,115,31,156,50,221,20,210,172,170,89,244,158,172,67,209,246,144,19,68,5,60,131,50,119,88,66,179,189,232,144,39,228,218,158,143,118,101,63,55,82,5,190,148,178,142,215,57,89,56,169,167,41,252,234,231,130,208,95,44,54,21,179,19,142,175,237,96,2,84,80,70,48,99,143,208,47,168,227,234,78,39,231,107,249,150,30,20,179,63,190,173,83,146,147,170,141,15,194,180,200,15,189,179,215,205,5,77,200,39,63,212,94,152,14,229,36,165,25,101,177,190,1,205,199,127,254,75,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSendObjectChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("07a0a137-acce-4755-9456-9c346526bc17"),
				Name = "SendObjectChanged",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("54dcca74-6c63-401d-be35-85eab232f81c"),
				Name = "schemaId",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,47,202,76,209,11,0,178,60,243,138,75,18,243,146,83,245,2,138,242,147,83,139,139,245,130,83,75,128,204,130,212,162,146,202,176,196,156,210,84,13,37,255,164,172,212,228,146,224,228,140,212,220,68,207,20,37,29,133,98,40,83,211,154,43,0,187,97,33,25,69,249,229,174,101,169,121,37,48,237,206,25,137,121,233,169,41,74,154,214,0,8,188,128,233,128,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisableChangelogControlPanelMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("df13dbec-3443-43e4-ae12-6fa013274bdd"),
				Name = "DisableChangelogControlPanel",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,203,204,41,73,45,114,206,207,43,41,202,207,241,73,172,204,47,45,209,11,78,45,113,205,75,76,202,73,77,209,72,75,204,41,78,213,81,40,41,42,77,213,180,230,229,10,0,105,241,79,202,74,77,46,33,78,11,0,210,15,251,199,100,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareOwnerEditFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d34c0656-8926-4d34-a4ca-356f6e5c8026"),
				Name = "PrepareOwnerEditFilter",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8dd3830b-d5bf-4c24-a989-d649ce60cfde"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f4aaa8c9-2d65-43f9-92dc-f258806c9425"),
				Name = "e",
				CreatedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				ModifiedInSchemaUId = new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "LookupEditEventArgs",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,65,75,195,64,16,133,207,22,250,31,150,156,20,194,66,175,86,133,144,86,232,173,80,245,82,122,24,147,201,118,101,179,27,119,102,213,16,246,191,187,105,34,216,219,240,152,239,205,123,243,5,94,52,218,48,122,18,143,2,229,243,52,175,151,139,89,149,69,93,223,90,252,22,27,93,177,118,22,124,255,64,236,181,85,185,112,239,31,88,241,147,24,196,114,113,51,100,149,107,59,240,154,156,125,233,59,204,114,49,153,149,87,178,220,126,6,48,49,159,16,131,13,111,127,58,143,68,201,187,116,38,180,118,15,124,78,112,118,60,244,84,212,173,182,175,86,243,125,233,44,67,197,39,185,171,179,152,95,96,80,202,163,130,49,213,124,176,184,86,14,41,103,197,178,116,193,242,204,4,194,141,166,206,64,255,6,38,140,76,3,134,240,47,143,215,234,252,47,208,30,60,180,152,58,92,150,41,109,143,159,152,106,31,79,98,88,197,24,239,214,191,152,203,194,135,68,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeLogModulePageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a3690f22-c0af-4d08-9ab2-6fd5a36c9627"));
		}

		#endregion

	}

	#endregion

}

