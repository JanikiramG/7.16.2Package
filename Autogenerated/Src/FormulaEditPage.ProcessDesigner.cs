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
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Packages;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: FormulaEditPageSchema

	/// <exclude/>
	public class FormulaEditPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _valueControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ValueControlLayout {
			get {
				return _valueControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _valueToolBarControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ValueToolBarControlLayout {
			get {
				return _valueToolBarControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addOperatorButton;
		public Terrasoft.UI.WebControls.Controls.Button AddOperatorButton {
			get {
				return _addOperatorButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _plusMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem PlusMenuItem {
			get {
				return _plusMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _minusMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem MinusMenuItem {
			get {
				return _minusMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _multiplyMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem MultiplyMenuItem {
			get {
				return _multiplyMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _devideMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem DevideMenuItem {
			get {
				return _devideMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _parenthesesMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem ParenthesesMenuItem {
			get {
				return _parenthesesMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addFunctionButton;
		public Terrasoft.UI.WebControls.Controls.Button AddFunctionButton {
			get {
				return _addFunctionButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _roundUpMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem RoundUpMenuItem {
			get {
				return _roundUpMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _roundMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem RoundMenuItem {
			get {
				return _roundMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _roundDownMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem RoundDownMenuItem {
			get {
				return _roundDownMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _modMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem ModMenuItem {
			get {
				return _modMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _minMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem MinMenuItem {
			get {
				return _minMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _maxMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem MaxMenuItem {
			get {
				return _maxMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _absMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AbsMenuItem {
			get {
				return _absMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _avgMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AvgMenuItem {
			get {
				return _avgMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _dayItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem DayItem {
			get {
				return _dayItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _monthItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem MonthItem {
			get {
				return _monthItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _dayOfWeekItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem DayOfWeekItem {
			get {
				return _dayOfWeekItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _timeItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem TimeItem {
			get {
				return _timeItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _dayInRangeItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem DayInRangeItem {
			get {
				return _dayInRangeItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _insertParameterButton;
		public Terrasoft.UI.WebControls.Controls.Button InsertParameterButton {
			get {
				return _insertParameterButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addSysVariableButton;
		public Terrasoft.UI.WebControls.Controls.Button AddSysVariableButton {
			get {
				return _addSysVariableButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuSeparator _menuSeparatorDateTime;
		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorDateTime {
			get {
				return _menuSeparatorDateTime;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _dateMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem DateMenuItem {
			get {
				return _dateMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _timeMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem TimeMenuItem {
			get {
				return _timeMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _dateTimeMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem DateTimeMenuItem {
			get {
				return _dateTimeMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuSeparator _menuSeparatorSamplingColumnValue;
		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorSamplingColumnValue {
			get {
				return _menuSeparatorSamplingColumnValue;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _samplingColumnValueMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem SamplingColumnValueMenuItem {
			get {
				return _samplingColumnValueMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuSeparator _menuSeparatorSysSettings;
		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorSysSettings {
			get {
				return _menuSeparatorSysSettings;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _sysSettingsMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem SysSettingsMenuItem {
			get {
				return _sysSettingsMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuSeparator _menuSeparatorLookup;
		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorLookup {
			get {
				return _menuSeparatorLookup;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _lookupMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem LookupMenuItem {
			get {
				return _lookupMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuSeparator _menuSeparatorSysVariable;
		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorSysVariable {
			get {
				return _menuSeparatorSysVariable;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _valueMemoEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit ValueMemoEdit {
			get {
				return _valueMemoEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _hiddenInsertParameterTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit HiddenInsertParameterTextEdit {
			get {
				return _hiddenInsertParameterTextEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public FormulaEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public FormulaEditPageSchema(FormulaEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			RealUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			Name = "FormulaEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UseProfile = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFormulaEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateValueControlLayout());
			ValueControlLayout.InsertItem(0, CreateValueToolBarControlLayout());
			ValueToolBarControlLayout.InsertItem(0, CreateAddOperatorButton());
			AddOperatorButton.InsertItem(0, CreatePlusMenuItem());
			AddOperatorButton.InsertItem(1, CreateMinusMenuItem());
			AddOperatorButton.InsertItem(2, CreateMultiplyMenuItem());
			AddOperatorButton.InsertItem(3, CreateDevideMenuItem());
			AddOperatorButton.InsertItem(4, CreateParenthesesMenuItem());
			ValueToolBarControlLayout.InsertItem(1, CreateAddFunctionButton());
			AddFunctionButton.InsertItem(0, CreateRoundUpMenuItem());
			AddFunctionButton.InsertItem(1, CreateRoundMenuItem());
			AddFunctionButton.InsertItem(2, CreateRoundDownMenuItem());
			AddFunctionButton.InsertItem(3, CreateModMenuItem());
			AddFunctionButton.InsertItem(4, CreateMinMenuItem());
			AddFunctionButton.InsertItem(5, CreateMaxMenuItem());
			AddFunctionButton.InsertItem(6, CreateAbsMenuItem());
			AddFunctionButton.InsertItem(7, CreateAvgMenuItem());
			AddFunctionButton.InsertItem(8, CreateDayItem());
			AddFunctionButton.InsertItem(9, CreateMonthItem());
			AddFunctionButton.InsertItem(10, CreateDayOfWeekItem());
			AddFunctionButton.InsertItem(11, CreateTimeItem());
			AddFunctionButton.InsertItem(12, CreateDayInRangeItem());
			ValueToolBarControlLayout.InsertItem(2, CreateInsertParameterButton());
			ValueToolBarControlLayout.InsertItem(3, CreateAddSysVariableButton());
			AddSysVariableButton.InsertItem(0, CreateMenuSeparatorDateTime());
			AddSysVariableButton.InsertItem(1, CreateDateMenuItem());
			AddSysVariableButton.InsertItem(2, CreateTimeMenuItem());
			AddSysVariableButton.InsertItem(3, CreateDateTimeMenuItem());
			AddSysVariableButton.InsertItem(4, CreateMenuSeparatorSamplingColumnValue());
			AddSysVariableButton.InsertItem(5, CreateSamplingColumnValueMenuItem());
			AddSysVariableButton.InsertItem(6, CreateMenuSeparatorSysSettings());
			AddSysVariableButton.InsertItem(7, CreateSysSettingsMenuItem());
			AddSysVariableButton.InsertItem(8, CreateMenuSeparatorLookup());
			AddSysVariableButton.InsertItem(9, CreateLookupMenuItem());
			AddSysVariableButton.InsertItem(10, CreateMenuSeparatorSysVariable());
			ValueControlLayout.InsertItem(1, CreateValueMemoEdit());
			ValueControlLayout.InsertItem(2, CreateHiddenInsertParameterTextEdit());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateFormulaEditPageEventsProcessSchema() {
			var schema = new FormulaEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreatePlusMenuItem() {
			_plusMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_plusMenuItem.UId = new Guid("aeb4a279-0e2e-440b-9e25-c040e6817742");
			_plusMenuItem.Name = "PlusMenuItem";
			_plusMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_plusMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_plusMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_plusMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_plusMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_plusMenuItem.Image = new ControlImage {};
			_plusMenuItem.Tag = "";
			return _plusMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateMinusMenuItem() {
			_minusMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_minusMenuItem.UId = new Guid("63b6f626-28a6-40d5-9b5c-adf493f33531");
			_minusMenuItem.Name = "MinusMenuItem";
			_minusMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_minusMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_minusMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_minusMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_minusMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_minusMenuItem.Image = new ControlImage {};
			_minusMenuItem.Tag = "";
			return _minusMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateMultiplyMenuItem() {
			_multiplyMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_multiplyMenuItem.UId = new Guid("b5344905-b8a0-487f-8935-b8ac6318b1a0");
			_multiplyMenuItem.Name = "MultiplyMenuItem";
			_multiplyMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_multiplyMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_multiplyMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_multiplyMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_multiplyMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_multiplyMenuItem.Image = new ControlImage {};
			_multiplyMenuItem.Tag = "";
			return _multiplyMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateDevideMenuItem() {
			_devideMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_devideMenuItem.UId = new Guid("752f39fc-4b19-483a-94ff-70d74767a12b");
			_devideMenuItem.Name = "DevideMenuItem";
			_devideMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_devideMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_devideMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_devideMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_devideMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_devideMenuItem.Image = new ControlImage {};
			_devideMenuItem.Tag = "";
			return _devideMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateParenthesesMenuItem() {
			_parenthesesMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_parenthesesMenuItem.UId = new Guid("0ddc78a6-0a1c-4e75-8f6b-e1046446e699");
			_parenthesesMenuItem.Name = "ParenthesesMenuItem";
			_parenthesesMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_parenthesesMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_parenthesesMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_parenthesesMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_parenthesesMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_parenthesesMenuItem.Image = new ControlImage {};
			_parenthesesMenuItem.Tag = "";
			return _parenthesesMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddOperatorButton() {
			_addOperatorButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addOperatorButton.UId = new Guid("f6f0254d-c269-49e5-a4f1-d02c0a84f164");
			_addOperatorButton.Name = "AddOperatorButton";
			_addOperatorButton.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_addOperatorButton.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_addOperatorButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addOperatorButton.Tag = "";
			_addOperatorButton.Image = new ControlImage {};
			return _addOperatorButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateRoundUpMenuItem() {
			_roundUpMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_roundUpMenuItem.UId = new Guid("0d9ce910-8e15-4350-8a17-be5feae526bc");
			_roundUpMenuItem.Name = "RoundUpMenuItem";
			_roundUpMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_roundUpMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_roundUpMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_roundUpMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_roundUpMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_roundUpMenuItem.Image = new ControlImage {};
			_roundUpMenuItem.Tag = "";
			return _roundUpMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateRoundMenuItem() {
			_roundMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_roundMenuItem.UId = new Guid("756d156a-88fe-43f7-8c07-d7d7892e219e");
			_roundMenuItem.Name = "RoundMenuItem";
			_roundMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_roundMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_roundMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_roundMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_roundMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_roundMenuItem.Image = new ControlImage {};
			_roundMenuItem.Tag = "";
			return _roundMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateRoundDownMenuItem() {
			_roundDownMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_roundDownMenuItem.UId = new Guid("d19728dc-ce2f-4a1b-b204-81b8df3895b8");
			_roundDownMenuItem.Name = "RoundDownMenuItem";
			_roundDownMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_roundDownMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_roundDownMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_roundDownMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_roundDownMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_roundDownMenuItem.Image = new ControlImage {};
			_roundDownMenuItem.Tag = "";
			return _roundDownMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateModMenuItem() {
			_modMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_modMenuItem.UId = new Guid("81c65285-1548-4e56-8d46-3e913c19c701");
			_modMenuItem.Name = "ModMenuItem";
			_modMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_modMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_modMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_modMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_modMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_modMenuItem.Image = new ControlImage {};
			_modMenuItem.Tag = "";
			return _modMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateMinMenuItem() {
			_minMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_minMenuItem.UId = new Guid("3affe9a2-4665-4369-bff1-0313f286ad0f");
			_minMenuItem.Name = "MinMenuItem";
			_minMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_minMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_minMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_minMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_minMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_minMenuItem.Image = new ControlImage {};
			_minMenuItem.Tag = "";
			return _minMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateMaxMenuItem() {
			_maxMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_maxMenuItem.UId = new Guid("e3a698d9-38a9-4310-9d72-d19fcf52017b");
			_maxMenuItem.Name = "MaxMenuItem";
			_maxMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_maxMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_maxMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_maxMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_maxMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_maxMenuItem.Image = new ControlImage {};
			_maxMenuItem.Tag = "";
			return _maxMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAbsMenuItem() {
			_absMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_absMenuItem.UId = new Guid("88ecf3b2-147a-4c5c-bcae-ada5886fcf29");
			_absMenuItem.Name = "AbsMenuItem";
			_absMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_absMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_absMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_absMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_absMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_absMenuItem.Image = new ControlImage {};
			_absMenuItem.Tag = "";
			return _absMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAvgMenuItem() {
			_avgMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_avgMenuItem.UId = new Guid("8edf116f-3ff1-4163-a5dd-a8fd5709b366");
			_avgMenuItem.Name = "AvgMenuItem";
			_avgMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_avgMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_avgMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_avgMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_avgMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_avgMenuItem.Image = new ControlImage {};
			_avgMenuItem.Tag = "";
			return _avgMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateDayItem() {
			_dayItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_dayItem.UId = new Guid("a4bede53-2ac7-452c-985e-88449517b344");
			_dayItem.Name = "DayItem";
			_dayItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dayItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dayItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dayItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_dayItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dayItem.Image = new ControlImage {};
			_dayItem.Tag = "";
			return _dayItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateMonthItem() {
			_monthItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_monthItem.UId = new Guid("cab00be0-aeef-4307-af0b-22cfabbac70d");
			_monthItem.Name = "MonthItem";
			_monthItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_monthItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_monthItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_monthItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_monthItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_monthItem.Image = new ControlImage {};
			_monthItem.Tag = "";
			return _monthItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateDayOfWeekItem() {
			_dayOfWeekItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_dayOfWeekItem.UId = new Guid("3af9e8fe-4dd4-449f-adfd-bc4c86ef946c");
			_dayOfWeekItem.Name = "DayOfWeekItem";
			_dayOfWeekItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dayOfWeekItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dayOfWeekItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dayOfWeekItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_dayOfWeekItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dayOfWeekItem.Image = new ControlImage {};
			_dayOfWeekItem.Tag = "";
			return _dayOfWeekItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateTimeItem() {
			_timeItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_timeItem.UId = new Guid("18064561-f94a-49c4-a9ec-8fc7d0b7686d");
			_timeItem.Name = "TimeItem";
			_timeItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_timeItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_timeItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_timeItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_timeItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_timeItem.Image = new ControlImage {};
			_timeItem.Tag = "";
			return _timeItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateDayInRangeItem() {
			_dayInRangeItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_dayInRangeItem.UId = new Guid("b2d73f8f-5ca6-498b-a20c-ddbd435be1c3");
			_dayInRangeItem.Name = "DayInRangeItem";
			_dayInRangeItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dayInRangeItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dayInRangeItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dayInRangeItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_dayInRangeItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dayInRangeItem.Image = new ControlImage {};
			_dayInRangeItem.Tag = "";
			return _dayInRangeItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddFunctionButton() {
			_addFunctionButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addFunctionButton.UId = new Guid("7afc39cd-7b4b-4800-8129-f33df5316d0c");
			_addFunctionButton.Name = "AddFunctionButton";
			_addFunctionButton.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_addFunctionButton.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_addFunctionButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addFunctionButton.Tag = "";
			_addFunctionButton.Image = new ControlImage {};
			return _addFunctionButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateInsertParameterButton() {
			_insertParameterButton = new Terrasoft.UI.WebControls.Controls.Button();
			_insertParameterButton.UId = new Guid("e59ff5f0-1144-42cb-86bb-81d5a4df42df");
			_insertParameterButton.Name = "InsertParameterButton";
			_insertParameterButton.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_insertParameterButton.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_insertParameterButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_insertParameterButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_insertParameterButton.Tag = "";
			_insertParameterButton.Image = new ControlImage {};
			return _insertParameterButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuSeparator CreateMenuSeparatorDateTime() {
			_menuSeparatorDateTime = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
			_menuSeparatorDateTime.UId = new Guid("dbbe7fae-c075-4b69-be62-f3a7314ca4d7");
			_menuSeparatorDateTime.Name = "MenuSeparatorDateTime";
			_menuSeparatorDateTime.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorDateTime.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorDateTime.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_menuSeparatorDateTime.Tag = "";
			_menuSeparatorDateTime.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_menuSeparatorDateTime.Image = new ControlImage {};
			return _menuSeparatorDateTime;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateDateMenuItem() {
			_dateMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_dateMenuItem.UId = new Guid("7cd0b3f6-f379-4f63-813e-4c1d99e31d8b");
			_dateMenuItem.Name = "DateMenuItem";
			_dateMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dateMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dateMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dateMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_dateMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dateMenuItem.Image = new ControlImage {};
			_dateMenuItem.Tag = "";
			return _dateMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateTimeMenuItem() {
			_timeMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_timeMenuItem.UId = new Guid("94a971e8-f621-4004-b455-ef13b486d8b8");
			_timeMenuItem.Name = "TimeMenuItem";
			_timeMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_timeMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_timeMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_timeMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_timeMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_timeMenuItem.Image = new ControlImage {};
			_timeMenuItem.Tag = "";
			return _timeMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateDateTimeMenuItem() {
			_dateTimeMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_dateTimeMenuItem.UId = new Guid("a42bc6d9-6533-407f-b0c1-663743a5aa7d");
			_dateTimeMenuItem.Name = "DateTimeMenuItem";
			_dateTimeMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dateTimeMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_dateTimeMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dateTimeMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_dateTimeMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dateTimeMenuItem.Image = new ControlImage {};
			_dateTimeMenuItem.Tag = "";
			return _dateTimeMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuSeparator CreateMenuSeparatorSamplingColumnValue() {
			_menuSeparatorSamplingColumnValue = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
			_menuSeparatorSamplingColumnValue.UId = new Guid("16f83f3f-f5b3-40c1-a86b-64cbbff946f7");
			_menuSeparatorSamplingColumnValue.Name = "MenuSeparatorSamplingColumnValue";
			_menuSeparatorSamplingColumnValue.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorSamplingColumnValue.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorSamplingColumnValue.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_menuSeparatorSamplingColumnValue.Tag = "";
			_menuSeparatorSamplingColumnValue.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_menuSeparatorSamplingColumnValue.Image = new ControlImage {};
			return _menuSeparatorSamplingColumnValue;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateSamplingColumnValueMenuItem() {
			_samplingColumnValueMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_samplingColumnValueMenuItem.UId = new Guid("199c70fc-a786-4195-bebc-b7802c90ec13");
			_samplingColumnValueMenuItem.Name = "SamplingColumnValueMenuItem";
			_samplingColumnValueMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_samplingColumnValueMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_samplingColumnValueMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_samplingColumnValueMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_samplingColumnValueMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_samplingColumnValueMenuItem.Image = new ControlImage {};
			_samplingColumnValueMenuItem.Tag = "";
			return _samplingColumnValueMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuSeparator CreateMenuSeparatorSysSettings() {
			_menuSeparatorSysSettings = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
			_menuSeparatorSysSettings.UId = new Guid("fbdbac5e-d055-4f98-9d06-d082d9632855");
			_menuSeparatorSysSettings.Name = "MenuSeparatorSysSettings";
			_menuSeparatorSysSettings.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorSysSettings.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorSysSettings.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_menuSeparatorSysSettings.Tag = "";
			_menuSeparatorSysSettings.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_menuSeparatorSysSettings.Image = new ControlImage {};
			return _menuSeparatorSysSettings;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateSysSettingsMenuItem() {
			_sysSettingsMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_sysSettingsMenuItem.UId = new Guid("54cbe21b-1b67-4804-867b-8f9c47e45821");
			_sysSettingsMenuItem.Name = "SysSettingsMenuItem";
			_sysSettingsMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_sysSettingsMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_sysSettingsMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysSettingsMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_sysSettingsMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysSettingsMenuItem.Image = new ControlImage {};
			_sysSettingsMenuItem.Tag = "";
			return _sysSettingsMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuSeparator CreateMenuSeparatorLookup() {
			_menuSeparatorLookup = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
			_menuSeparatorLookup.UId = new Guid("009b15f2-78b2-457e-83b2-79054c063f7f");
			_menuSeparatorLookup.Name = "MenuSeparatorLookup";
			_menuSeparatorLookup.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorLookup.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorLookup.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_menuSeparatorLookup.Tag = "";
			_menuSeparatorLookup.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_menuSeparatorLookup.Image = new ControlImage {};
			return _menuSeparatorLookup;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateLookupMenuItem() {
			_lookupMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_lookupMenuItem.UId = new Guid("2086c460-2f79-4d78-9b91-e7785dc3fbb4");
			_lookupMenuItem.Name = "LookupMenuItem";
			_lookupMenuItem.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_lookupMenuItem.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_lookupMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lookupMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_lookupMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lookupMenuItem.Image = new ControlImage {};
			_lookupMenuItem.Tag = "";
			return _lookupMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuSeparator CreateMenuSeparatorSysVariable() {
			_menuSeparatorSysVariable = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
			_menuSeparatorSysVariable.UId = new Guid("7cab1e7f-19d9-4f02-97f8-878108cd4cee");
			_menuSeparatorSysVariable.Name = "MenuSeparatorSysVariable";
			_menuSeparatorSysVariable.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorSysVariable.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_menuSeparatorSysVariable.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_menuSeparatorSysVariable.Tag = "";
			_menuSeparatorSysVariable.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_menuSeparatorSysVariable.Image = new ControlImage {};
			return _menuSeparatorSysVariable;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddSysVariableButton() {
			_addSysVariableButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addSysVariableButton.UId = new Guid("f97cd298-4a77-4361-b5df-15ebe73aba31");
			_addSysVariableButton.Name = "AddSysVariableButton";
			_addSysVariableButton.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_addSysVariableButton.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_addSysVariableButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addSysVariableButton.Tag = "";
			_addSysVariableButton.Image = new ControlImage {};
			return _addSysVariableButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateValueToolBarControlLayout() {
			_valueToolBarControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_valueToolBarControlLayout.UId = new Guid("5f051738-dbe5-4127-88fb-8e0344b90300");
			_valueToolBarControlLayout.Name = "ValueToolBarControlLayout";
			_valueToolBarControlLayout.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_valueToolBarControlLayout.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_valueToolBarControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_valueToolBarControlLayout.Tag = "";
			_valueToolBarControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_valueToolBarControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_valueToolBarControlLayout.FitHeightByContent = true;
			_valueToolBarControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_valueToolBarControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_valueToolBarControlLayout.Padding = "4 0 4 5";
			_valueToolBarControlLayout.StartNewAlignGroup = false;
			_valueToolBarControlLayout.DefaultMargins = "0 5 0 0";
			_valueToolBarControlLayout.Image = new ControlImage {};
			_valueToolBarControlLayout.Edges = "1 1 0 1";
			return _valueToolBarControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateValueMemoEdit() {
			_valueMemoEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_valueMemoEdit.UId = new Guid("aa74a7fa-bc2b-4371-807a-ee1356f21029");
			_valueMemoEdit.Name = "ValueMemoEdit";
			_valueMemoEdit.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_valueMemoEdit.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_valueMemoEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_valueMemoEdit.Tag = "";
			_valueMemoEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_valueMemoEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_valueMemoEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_valueMemoEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_valueMemoEdit.CaptionVerticalAlign = Terrasoft.UI.WebControls.VerticalAlign.NotSet;
			_valueMemoEdit.AlignedByCaption = false;
			_valueMemoEdit.Required = true;
			return _valueMemoEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateHiddenInsertParameterTextEdit() {
			_hiddenInsertParameterTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_hiddenInsertParameterTextEdit.UId = new Guid("f211a45f-6edf-4d87-b1fe-d12a24ea9c7d");
			_hiddenInsertParameterTextEdit.Name = "HiddenInsertParameterTextEdit";
			_hiddenInsertParameterTextEdit.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_hiddenInsertParameterTextEdit.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_hiddenInsertParameterTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_hiddenInsertParameterTextEdit.Tag = "";
			_hiddenInsertParameterTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_hiddenInsertParameterTextEdit.Image = new ControlImage {};
			_hiddenInsertParameterTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(150);
			_hiddenInsertParameterTextEdit.AlignedByCaption = false;
			_hiddenInsertParameterTextEdit.Hidden = true;
			return _hiddenInsertParameterTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateValueControlLayout() {
			_valueControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_valueControlLayout.UId = new Guid("1af35c31-9b62-445c-8ab7-fff19b1034de");
			_valueControlLayout.Name = "ValueControlLayout";
			_valueControlLayout.CreatedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_valueControlLayout.ModifiedInSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_valueControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_valueControlLayout.Tag = "";
			_valueControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_valueControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_valueControlLayout.StartNewAlignGroup = false;
			_valueControlLayout.Image = new ControlImage {};
			_valueControlLayout.Edges = "";
			return _valueControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new FormulaEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new FormulaEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new FormulaEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: FormulaEditPageEventsProcess

	/// <exclude/>
	public class FormulaEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.FormulaEditPageSchemaUserControl
	{

		#region Class: UserTaskSysSettingsMenuItemClickFlowElement

		/// <exclude/>
		public class UserTaskSysSettingsMenuItemClickFlowElement : OpenLookupUserTask
		{

			public UserTaskSysSettingsMenuItemClickFlowElement(UserConnection userConnection, FormulaEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskSysSettingsMenuItemClick";
				IsLogging = false;
				SchemaElementUId = new Guid("106607bc-02df-4179-ba4a-e10938427966");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskOpenLookupGridPageFlowElement

		/// <exclude/>
		public class UserTaskOpenLookupGridPageFlowElement : OpenLookupUserTask
		{

			public UserTaskOpenLookupGridPageFlowElement(UserConnection userConnection, FormulaEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskOpenLookupGridPage";
				IsLogging = false;
				SchemaElementUId = new Guid("e26865e6-a67d-4778-8d9b-d571e3c42a95");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserTaskOpenDateTimeValueEditPageFlowElement

		/// <exclude/>
		public class UserTaskOpenDateTimeValueEditPageFlowElement : OpenPageUserTask
		{

			public UserTaskOpenDateTimeValueEditPageFlowElement(UserConnection userConnection, FormulaEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTaskOpenDateTimeValueEditPage";
				IsLogging = false;
				SchemaElementUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		private TPage _page;
		public TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public FormulaEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormulaEditPageEventsProcess";
			SchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_samplingColumnValuePrefix = () => {{ return "SamplingColumnValue."; }};
			_dateValuePrefix = () => {{ return "DateValue."; }};
			_timeValuePrefix = () => {{ return "TimeValue."; }};
			_dateTimeValuePrefix = () => {{ return "DateTimeValue."; }};
			_referenceSchemaListKey = () => {{ return "FormulaEditPage_ReferenceSchemaList"; }};
			_referenceSchemaListCountKey = () => {{ return "FormulaEditPage_ReferenceSchemaListCountKey"; }};
			_terrasoftCommonNamespace = () => {{ return "Terrasoft.Common."; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
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

		public virtual Guid EditSchemaUId {
			get;
			set;
		}

		public virtual string EditSchemaManagerName {
			get;
			set;
		}

		private string _leftMacrosBracket;
		public virtual string LeftMacrosBracket {
			get {
				return _leftMacrosBracket ?? (_leftMacrosBracket = new LocalizableString(Storage, "c53bce00ec064c8c8b0bc619be916631",
						 "EventsProcessSchema.Parameters.LeftMacrosBracket.Value"));
			}
			set {
				_leftMacrosBracket = value;
			}
		}

		private string _rightMacrosBracket;
		public virtual string RightMacrosBracket {
			get {
				return _rightMacrosBracket ?? (_rightMacrosBracket = new LocalizableString(Storage, "c53bce00ec064c8c8b0bc619be916631",
						 "EventsProcessSchema.Parameters.RightMacrosBracket.Value"));
			}
			set {
				_rightMacrosBracket = value;
			}
		}

		public virtual Object MetaParamsDictionary {
			get;
			set;
		}

		private string _sysVariablePrefix;
		public virtual string SysVariablePrefix {
			get {
				return _sysVariablePrefix ?? (_sysVariablePrefix = new LocalizableString(Storage, "c53bce00ec064c8c8b0bc619be916631",
						 "EventsProcessSchema.Parameters.SysVariablePrefix.Value"));
			}
			set {
				_sysVariablePrefix = value;
			}
		}

		private string _sysSettingsPrefix;
		public virtual string SysSettingsPrefix {
			get {
				return _sysSettingsPrefix ?? (_sysSettingsPrefix = new LocalizableString(Storage, "c53bce00ec064c8c8b0bc619be916631",
						 "EventsProcessSchema.Parameters.SysSettingsPrefix.Value"));
			}
			set {
				_sysSettingsPrefix = value;
			}
		}

		private string _borderOfOperandPattern;
		public virtual string BorderOfOperandPattern {
			get {
				return _borderOfOperandPattern ?? (_borderOfOperandPattern = new LocalizableString(Storage, "c53bce00ec064c8c8b0bc619be916631",
						 "EventsProcessSchema.Parameters.BorderOfOperandPattern.Value"));
			}
			set {
				_borderOfOperandPattern = value;
			}
		}

		public virtual Object SchemaExplorer {
			get;
			set;
		}

		private string _lookupValuePrefix;
		public virtual string LookupValuePrefix {
			get {
				return _lookupValuePrefix ?? (_lookupValuePrefix = new LocalizableString(Storage, "c53bce00ec064c8c8b0bc619be916631",
						 "EventsProcessSchema.Parameters.LookupValuePrefix.Value"));
			}
			set {
				_lookupValuePrefix = value;
			}
		}

		public virtual bool SchemaExplorerCreated {
			get;
			set;
		}

		public virtual bool SchemaExplorerRegistered {
			get;
			set;
		}

		public virtual Guid EditElementUId {
			get;
			set;
		}

		public virtual Guid SamplingSchemaUId {
			get;
			set;
		}

		public virtual Guid SamplingSchemaColumnDataValueTypeUId {
			get;
			set;
		}

		public virtual Object ColumnStructureExplorer {
			get;
			set;
		}

		public virtual bool IsColumnStructureExplorerRegistered {
			get;
			set;
		}

		public virtual bool IsColumnStructureExplorerCreated {
			get;
			set;
		}

		private Func<string> _samplingColumnValuePrefix;
		public virtual string SamplingColumnValuePrefix {
			get {
				return (_samplingColumnValuePrefix ?? (_samplingColumnValuePrefix = () => null)).Invoke();
			}
			set {
				_samplingColumnValuePrefix = () => { return value; };
			}
		}

		public virtual string DateTimeKind {
			get;
			set;
		}

		private Func<string> _dateValuePrefix;
		public virtual string DateValuePrefix {
			get {
				return (_dateValuePrefix ?? (_dateValuePrefix = () => null)).Invoke();
			}
			set {
				_dateValuePrefix = () => { return value; };
			}
		}

		private Func<string> _timeValuePrefix;
		public virtual string TimeValuePrefix {
			get {
				return (_timeValuePrefix ?? (_timeValuePrefix = () => null)).Invoke();
			}
			set {
				_timeValuePrefix = () => { return value; };
			}
		}

		private Func<string> _dateTimeValuePrefix;
		public virtual string DateTimeValuePrefix {
			get {
				return (_dateTimeValuePrefix ?? (_dateTimeValuePrefix = () => null)).Invoke();
			}
			set {
				_dateTimeValuePrefix = () => { return value; };
			}
		}

		private Func<string> _referenceSchemaListKey;
		public virtual string ReferenceSchemaListKey {
			get {
				return (_referenceSchemaListKey ?? (_referenceSchemaListKey = () => null)).Invoke();
			}
			set {
				_referenceSchemaListKey = () => { return value; };
			}
		}

		private Func<string> _referenceSchemaListCountKey;
		public virtual string ReferenceSchemaListCountKey {
			get {
				return (_referenceSchemaListCountKey ?? (_referenceSchemaListCountKey = () => null)).Invoke();
			}
			set {
				_referenceSchemaListCountKey = () => { return value; };
			}
		}

		public virtual Guid ReferenceSchemaUId {
			get;
			set;
		}

		public virtual string MessagePanelClientId {
			get;
			set;
		}

		private Func<string> _terrasoftCommonNamespace;
		public virtual string TerrasoftCommonNamespace {
			get {
				return (_terrasoftCommonNamespace ?? (_terrasoftCommonNamespace = () => null)).Invoke();
			}
			set {
				_terrasoftCommonNamespace = () => { return value; };
			}
		}

		private ProcessFlowElement _eventSubProcessPlusMenuItemClick;
		public ProcessFlowElement EventSubProcessPlusMenuItemClick {
			get {
				return _eventSubProcessPlusMenuItemClick ?? (_eventSubProcessPlusMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessPlusMenuItemClick",
					SchemaElementUId = new Guid("0caf71d5-02fa-4130-a808-c1d07e65cd5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessagePlusMenuItemClick;
		public ProcessFlowElement StartMessagePlusMenuItemClick {
			get {
				return _startMessagePlusMenuItemClick ?? (_startMessagePlusMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessagePlusMenuItemClick",
					SchemaElementUId = new Guid("7170a189-f16b-42af-95c5-7053732450f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPlusMenuItemClick;
		public ProcessScriptTask ScriptTaskPlusMenuItemClick {
			get {
				return _scriptTaskPlusMenuItemClick ?? (_scriptTaskPlusMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPlusMenuItemClick",
					SchemaElementUId = new Guid("97e05b5b-e119-4082-97f5-682c713362b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPlusMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessParenthesesMenuItemClick;
		public ProcessFlowElement EventSubProcessParenthesesMenuItemClick {
			get {
				return _eventSubProcessParenthesesMenuItemClick ?? (_eventSubProcessParenthesesMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessParenthesesMenuItemClick",
					SchemaElementUId = new Guid("eb7b022c-5caa-4ecb-99bc-daa5994a63f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageParenthesesMenuItemClick;
		public ProcessFlowElement StartMessageParenthesesMenuItemClick {
			get {
				return _startMessageParenthesesMenuItemClick ?? (_startMessageParenthesesMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageParenthesesMenuItemClick",
					SchemaElementUId = new Guid("9697455b-7477-4c32-847f-27bff465e2c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskParenthesesMenuItemClick;
		public ProcessScriptTask ScriptTaskParenthesesMenuItemClick {
			get {
				return _scriptTaskParenthesesMenuItemClick ?? (_scriptTaskParenthesesMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskParenthesesMenuItemClick",
					SchemaElementUId = new Guid("6ea38408-02ed-4788-9837-f72e6c329a8f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskParenthesesMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessMinusMenuItemClick;
		public ProcessFlowElement EventSubProcessMinusMenuItemClick {
			get {
				return _eventSubProcessMinusMenuItemClick ?? (_eventSubProcessMinusMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessMinusMenuItemClick",
					SchemaElementUId = new Guid("aa64324b-d77d-4cda-a8f1-8fc0d723ec8e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageMinusMenuItemClick;
		public ProcessFlowElement StartMessageMinusMenuItemClick {
			get {
				return _startMessageMinusMenuItemClick ?? (_startMessageMinusMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageMinusMenuItemClick",
					SchemaElementUId = new Guid("9a13f824-6df4-4291-b337-c248e23cd310"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskMinusMenuItemClick;
		public ProcessScriptTask ScriptTaskMinusMenuItemClick {
			get {
				return _scriptTaskMinusMenuItemClick ?? (_scriptTaskMinusMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskMinusMenuItemClick",
					SchemaElementUId = new Guid("7124fd00-95cf-4976-a05e-3eed82c308ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskMinusMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessMultiplyMenuItemClick;
		public ProcessFlowElement EventSubProcessMultiplyMenuItemClick {
			get {
				return _eventSubProcessMultiplyMenuItemClick ?? (_eventSubProcessMultiplyMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessMultiplyMenuItemClick",
					SchemaElementUId = new Guid("856b221b-c850-4b44-9886-e4d6cae316f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageMultiplyMenuItemClick;
		public ProcessFlowElement StartMessageMultiplyMenuItemClick {
			get {
				return _startMessageMultiplyMenuItemClick ?? (_startMessageMultiplyMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageMultiplyMenuItemClick",
					SchemaElementUId = new Guid("cb35ff3f-caaf-41a2-b99c-dfe106e093f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskMultiplyMenuItemClick;
		public ProcessScriptTask ScriptTaskMultiplyMenuItemClick {
			get {
				return _scriptTaskMultiplyMenuItemClick ?? (_scriptTaskMultiplyMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskMultiplyMenuItemClick",
					SchemaElementUId = new Guid("24899907-49c7-40c3-a7f0-e5c6773a272d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskMultiplyMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDevideMenuItemClick;
		public ProcessFlowElement EventSubProcessDevideMenuItemClick {
			get {
				return _eventSubProcessDevideMenuItemClick ?? (_eventSubProcessDevideMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDevideMenuItemClick",
					SchemaElementUId = new Guid("64c00367-b08e-46a7-8f1b-dfe9b7a077fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDevideMenuItemClick;
		public ProcessFlowElement StartMessageDevideMenuItemClick {
			get {
				return _startMessageDevideMenuItemClick ?? (_startMessageDevideMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDevideMenuItemClick",
					SchemaElementUId = new Guid("8ce1b97d-ca5a-41cc-8a4e-0262dbdeacc0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDevideMenuItemClick;
		public ProcessScriptTask ScriptTaskDevideMenuItemClick {
			get {
				return _scriptTaskDevideMenuItemClick ?? (_scriptTaskDevideMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDevideMenuItemClick",
					SchemaElementUId = new Guid("d573162c-a01b-46dc-86d2-85453da8fef1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDevideMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessInit;
		public ProcessFlowElement EventSubProcessInit {
			get {
				return _eventSubProcessInit ?? (_eventSubProcessInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInit",
					SchemaElementUId = new Guid("b18d23b9-688c-4fd7-adc7-e4c9e17ccc9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskInit;
		public ProcessScriptTask ScriptTaskInit {
			get {
				return _scriptTaskInit ?? (_scriptTaskInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskInit",
					SchemaElementUId = new Guid("ca348541-e13f-4e28-acd6-f7810dab8e9b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskInitExecute,
				});
			}
		}

		private ProcessFlowElement _initStartMessage;
		public ProcessFlowElement InitStartMessage {
			get {
				return _initStartMessage ?? (_initStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitStartMessage",
					SchemaElementUId = new Guid("2217f6a7-f22c-4d60-a750-f44a07577ab6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessPageLoadComplete;
		public ProcessFlowElement EventSubProcessPageLoadComplete {
			get {
				return _eventSubProcessPageLoadComplete ?? (_eventSubProcessPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessPageLoadComplete",
					SchemaElementUId = new Guid("b5f59f58-4b26-4f65-9cd8-f83d0bbb657e"),
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
					SchemaElementUId = new Guid("e65ae098-abe2-4b08-a38f-7284b59aece7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPageLoadComplete;
		public ProcessScriptTask ScriptTaskPageLoadComplete {
			get {
				return _scriptTaskPageLoadComplete ?? (_scriptTaskPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPageLoadComplete",
					SchemaElementUId = new Guid("975a8f09-6f48-412c-a4f7-c692a5e1853f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPageLoadCompleteExecute,
				});
			}
		}

		private ProcessFlowElement _addParameterButtonClickEventSubProcess;
		public ProcessFlowElement AddParameterButtonClickEventSubProcess {
			get {
				return _addParameterButtonClickEventSubProcess ?? (_addParameterButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AddParameterButtonClickEventSubProcess",
					SchemaElementUId = new Guid("d4d95ba2-7a32-49ea-9d6b-c3d3ab38d5fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _insertParameterButtonClickStartMessage;
		public ProcessFlowElement InsertParameterButtonClickStartMessage {
			get {
				return _insertParameterButtonClickStartMessage ?? (_insertParameterButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InsertParameterButtonClickStartMessage",
					SchemaElementUId = new Guid("aa79ea3a-4d3d-4df9-8c9d-d1576063a196"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _insertParameterButtonClickScriptTask;
		public ProcessScriptTask InsertParameterButtonClickScriptTask {
			get {
				return _insertParameterButtonClickScriptTask ?? (_insertParameterButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertParameterButtonClickScriptTask",
					SchemaElementUId = new Guid("aafdfc6b-e9d7-4e81-8805-d3d34421915f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InsertParameterButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessRoundUpMenuItemClick;
		public ProcessFlowElement EventSubProcessRoundUpMenuItemClick {
			get {
				return _eventSubProcessRoundUpMenuItemClick ?? (_eventSubProcessRoundUpMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessRoundUpMenuItemClick",
					SchemaElementUId = new Guid("512093bb-acb9-4741-9924-2dc841535b4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageRoundUpMenuItemClick;
		public ProcessFlowElement StartMessageRoundUpMenuItemClick {
			get {
				return _startMessageRoundUpMenuItemClick ?? (_startMessageRoundUpMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageRoundUpMenuItemClick",
					SchemaElementUId = new Guid("ff4eb434-e5bc-40ae-af7c-ee0787bd0b37"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskRoundUpMenuItemClick;
		public ProcessScriptTask ScriptTaskRoundUpMenuItemClick {
			get {
				return _scriptTaskRoundUpMenuItemClick ?? (_scriptTaskRoundUpMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskRoundUpMenuItemClick",
					SchemaElementUId = new Guid("f3f11e06-54ab-4ad9-9996-364371e1946b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskRoundUpMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessRoundMenuItemClick;
		public ProcessFlowElement EventSubProcessRoundMenuItemClick {
			get {
				return _eventSubProcessRoundMenuItemClick ?? (_eventSubProcessRoundMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessRoundMenuItemClick",
					SchemaElementUId = new Guid("c1b1f9bd-549c-4a53-bac8-632f2cbaf512"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageRoundMenuItemClick;
		public ProcessFlowElement StartMessageRoundMenuItemClick {
			get {
				return _startMessageRoundMenuItemClick ?? (_startMessageRoundMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageRoundMenuItemClick",
					SchemaElementUId = new Guid("f5227d1b-898c-4997-a840-685fb5900b71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskRoundMenuItemClick;
		public ProcessScriptTask ScriptTaskRoundMenuItemClick {
			get {
				return _scriptTaskRoundMenuItemClick ?? (_scriptTaskRoundMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskRoundMenuItemClick",
					SchemaElementUId = new Guid("a044b7b8-3b76-4504-a69e-60855df9746a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskRoundMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessRoundDownMenuItemClick;
		public ProcessFlowElement EventSubProcessRoundDownMenuItemClick {
			get {
				return _eventSubProcessRoundDownMenuItemClick ?? (_eventSubProcessRoundDownMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessRoundDownMenuItemClick",
					SchemaElementUId = new Guid("d455032b-8d09-433d-9903-ff5794604c4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageRoundDownMenuItemClick;
		public ProcessFlowElement StartMessageRoundDownMenuItemClick {
			get {
				return _startMessageRoundDownMenuItemClick ?? (_startMessageRoundDownMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageRoundDownMenuItemClick",
					SchemaElementUId = new Guid("c234c060-a760-4f93-b347-e2c47073777a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskRoundDownMenuItemClick;
		public ProcessScriptTask ScriptTaskRoundDownMenuItemClick {
			get {
				return _scriptTaskRoundDownMenuItemClick ?? (_scriptTaskRoundDownMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskRoundDownMenuItemClick",
					SchemaElementUId = new Guid("7b9d15d8-0a13-404d-9ec1-a16986d34798"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskRoundDownMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessModMenuItemClick;
		public ProcessFlowElement EventSubProcessModMenuItemClick {
			get {
				return _eventSubProcessModMenuItemClick ?? (_eventSubProcessModMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessModMenuItemClick",
					SchemaElementUId = new Guid("6be7db61-749f-4c7f-b7c4-9a22bbf48771"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageModMenuItemClick;
		public ProcessFlowElement StartMessageModMenuItemClick {
			get {
				return _startMessageModMenuItemClick ?? (_startMessageModMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageModMenuItemClick",
					SchemaElementUId = new Guid("70636e5b-525f-4a37-84f6-bf66a8cda0cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskModMenuItemClick;
		public ProcessScriptTask ScriptTaskModMenuItemClick {
			get {
				return _scriptTaskModMenuItemClick ?? (_scriptTaskModMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskModMenuItemClick",
					SchemaElementUId = new Guid("354ae8c1-397b-4ca5-8776-11dc3881d01a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskModMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessMinMenuItemClick;
		public ProcessFlowElement EventSubProcessMinMenuItemClick {
			get {
				return _eventSubProcessMinMenuItemClick ?? (_eventSubProcessMinMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessMinMenuItemClick",
					SchemaElementUId = new Guid("9ebf3925-c6b5-45b9-b2d1-d9c35448a03e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageMinMenuItemClick;
		public ProcessFlowElement StartMessageMinMenuItemClick {
			get {
				return _startMessageMinMenuItemClick ?? (_startMessageMinMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageMinMenuItemClick",
					SchemaElementUId = new Guid("c1a1ea8b-6506-453c-bc5a-3fab97979239"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskMinMenuItemClick;
		public ProcessScriptTask ScriptTaskMinMenuItemClick {
			get {
				return _scriptTaskMinMenuItemClick ?? (_scriptTaskMinMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskMinMenuItemClick",
					SchemaElementUId = new Guid("5709ee4b-1de2-45f5-bfd4-4996000bccf0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskMinMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessMaxMenuItemClick;
		public ProcessFlowElement EventSubProcessMaxMenuItemClick {
			get {
				return _eventSubProcessMaxMenuItemClick ?? (_eventSubProcessMaxMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessMaxMenuItemClick",
					SchemaElementUId = new Guid("72a41657-39ae-4b59-b5d6-948a0810ccaf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageMaxMenuItemClick;
		public ProcessFlowElement StartMessageMaxMenuItemClick {
			get {
				return _startMessageMaxMenuItemClick ?? (_startMessageMaxMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageMaxMenuItemClick",
					SchemaElementUId = new Guid("37f8a883-b8b3-40cb-bcd6-2029769a9ea5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskMaxMenuItemClick;
		public ProcessScriptTask ScriptTaskMaxMenuItemClick {
			get {
				return _scriptTaskMaxMenuItemClick ?? (_scriptTaskMaxMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskMaxMenuItemClick",
					SchemaElementUId = new Guid("19c002fe-9f8a-4cac-a572-bdd818394e7f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskMaxMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessAbsMenuItemClick;
		public ProcessFlowElement EventSubProcessAbsMenuItemClick {
			get {
				return _eventSubProcessAbsMenuItemClick ?? (_eventSubProcessAbsMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessAbsMenuItemClick",
					SchemaElementUId = new Guid("7b2d5546-a7c7-45a8-ad4e-c72451b9b089"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAbsMenuItemClick;
		public ProcessFlowElement StartMessageAbsMenuItemClick {
			get {
				return _startMessageAbsMenuItemClick ?? (_startMessageAbsMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAbsMenuItemClick",
					SchemaElementUId = new Guid("bc57e542-32f8-4b8e-8be1-25353a720232"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskAbsMenuItemClick;
		public ProcessScriptTask ScriptTaskAbsMenuItemClick {
			get {
				return _scriptTaskAbsMenuItemClick ?? (_scriptTaskAbsMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskAbsMenuItemClick",
					SchemaElementUId = new Guid("3dbdce4a-f8d0-4a6c-8c6b-d9434a6aaf2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskAbsMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessAvgMenuItemClick;
		public ProcessFlowElement EventSubProcessAvgMenuItemClick {
			get {
				return _eventSubProcessAvgMenuItemClick ?? (_eventSubProcessAvgMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessAvgMenuItemClick",
					SchemaElementUId = new Guid("dd046fee-1dac-49b2-96b1-479472944fb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAvgMenuItemClick;
		public ProcessFlowElement StartMessageAvgMenuItemClick {
			get {
				return _startMessageAvgMenuItemClick ?? (_startMessageAvgMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAvgMenuItemClick",
					SchemaElementUId = new Guid("e6ff7e23-cb10-4576-9e3f-7522fcab5f42"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskAvgMenuItemClick;
		public ProcessScriptTask ScriptTaskAvgMenuItemClick {
			get {
				return _scriptTaskAvgMenuItemClick ?? (_scriptTaskAvgMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskAvgMenuItemClick",
					SchemaElementUId = new Guid("7dd0d9e2-0d1c-4e7a-a4a4-2715fbd646d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskAvgMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDayItemClick;
		public ProcessFlowElement EventSubProcessDayItemClick {
			get {
				return _eventSubProcessDayItemClick ?? (_eventSubProcessDayItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDayItemClick",
					SchemaElementUId = new Guid("4e639c74-1572-4eed-af7d-93628439fedb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDayItemClick;
		public ProcessFlowElement StartMessageDayItemClick {
			get {
				return _startMessageDayItemClick ?? (_startMessageDayItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDayItemClick",
					SchemaElementUId = new Guid("cd841e73-cef3-4db7-be8e-1902fe0246f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDayItemClick;
		public ProcessScriptTask ScriptTaskDayItemClick {
			get {
				return _scriptTaskDayItemClick ?? (_scriptTaskDayItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDayItemClick",
					SchemaElementUId = new Guid("e7f9b0df-9f89-447a-9281-4055d7f55f1c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDayItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessMonthItemClick;
		public ProcessFlowElement EventSubProcessMonthItemClick {
			get {
				return _eventSubProcessMonthItemClick ?? (_eventSubProcessMonthItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessMonthItemClick",
					SchemaElementUId = new Guid("9c959d83-8e7a-475c-92d9-ad65f18297a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageMonthItemClick;
		public ProcessFlowElement StartMessageMonthItemClick {
			get {
				return _startMessageMonthItemClick ?? (_startMessageMonthItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageMonthItemClick",
					SchemaElementUId = new Guid("46bec8ad-5fb0-47db-8f1e-9585b298d11a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskMonthItemClick;
		public ProcessScriptTask ScriptTaskMonthItemClick {
			get {
				return _scriptTaskMonthItemClick ?? (_scriptTaskMonthItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskMonthItemClick",
					SchemaElementUId = new Guid("1fde018d-59ed-4cdb-b5d8-9283497a55d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskMonthItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDayOfWeekItemClick;
		public ProcessFlowElement EventSubProcessDayOfWeekItemClick {
			get {
				return _eventSubProcessDayOfWeekItemClick ?? (_eventSubProcessDayOfWeekItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDayOfWeekItemClick",
					SchemaElementUId = new Guid("9ad3ef8c-fb4d-4a67-a383-6b84d113e6c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDayOfWeekItemClick;
		public ProcessFlowElement StartMessageDayOfWeekItemClick {
			get {
				return _startMessageDayOfWeekItemClick ?? (_startMessageDayOfWeekItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDayOfWeekItemClick",
					SchemaElementUId = new Guid("36aef9b3-89fd-4bf4-84ea-473c61dfa7af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDayOfWeekItemClick;
		public ProcessScriptTask ScriptTaskDayOfWeekItemClick {
			get {
				return _scriptTaskDayOfWeekItemClick ?? (_scriptTaskDayOfWeekItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDayOfWeekItemClick",
					SchemaElementUId = new Guid("255ec44a-8563-4530-ae6a-a201a23da784"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDayOfWeekItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessTimeItemClick;
		public ProcessFlowElement EventSubProcessTimeItemClick {
			get {
				return _eventSubProcessTimeItemClick ?? (_eventSubProcessTimeItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessTimeItemClick",
					SchemaElementUId = new Guid("764ebf1b-85a2-4640-916e-56da921af811"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageTimeItemClick;
		public ProcessFlowElement StartMessageTimeItemClick {
			get {
				return _startMessageTimeItemClick ?? (_startMessageTimeItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageTimeItemClick",
					SchemaElementUId = new Guid("f220011f-8312-430b-8322-3bd59fe8da3d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskTimeItemClick;
		public ProcessScriptTask ScriptTaskTimeItemClick {
			get {
				return _scriptTaskTimeItemClick ?? (_scriptTaskTimeItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskTimeItemClick",
					SchemaElementUId = new Guid("aad4d2af-7c89-4cca-a5d9-3d712d5af4b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskTimeItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDayInRangeItemClick;
		public ProcessFlowElement EventSubProcessDayInRangeItemClick {
			get {
				return _eventSubProcessDayInRangeItemClick ?? (_eventSubProcessDayInRangeItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDayInRangeItemClick",
					SchemaElementUId = new Guid("ff8b3527-e063-4ff5-8956-4e1eb3b6ffbf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDayInRangeItemClick;
		public ProcessFlowElement StartMessageDayInRangeItemClick {
			get {
				return _startMessageDayInRangeItemClick ?? (_startMessageDayInRangeItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDayInRangeItemClick",
					SchemaElementUId = new Guid("23b4f3d4-94e1-4258-af01-28f38e14ff04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDayInRangeItemClick;
		public ProcessScriptTask ScriptTaskDayInRangeItemClick {
			get {
				return _scriptTaskDayInRangeItemClick ?? (_scriptTaskDayInRangeItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDayInRangeItemClick",
					SchemaElementUId = new Guid("eab49b20-41a6-4f92-8349-071af60ac682"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDayInRangeItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessSysSettingsMenuItemClick;
		public ProcessFlowElement EventSubProcessSysSettingsMenuItemClick {
			get {
				return _eventSubProcessSysSettingsMenuItemClick ?? (_eventSubProcessSysSettingsMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessSysSettingsMenuItemClick",
					SchemaElementUId = new Guid("d06b181d-2be7-4f20-9df1-94b5335340b1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageSysSettingsMenuItemClick;
		public ProcessFlowElement StartMessageSysSettingsMenuItemClick {
			get {
				return _startMessageSysSettingsMenuItemClick ?? (_startMessageSysSettingsMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageSysSettingsMenuItemClick",
					SchemaElementUId = new Guid("3287ab2a-376e-4814-b376-b107566aa68a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskSysSettingsMenuItemClick;
		public ProcessScriptTask ScriptTaskSysSettingsMenuItemClick {
			get {
				return _scriptTaskSysSettingsMenuItemClick ?? (_scriptTaskSysSettingsMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSysSettingsMenuItemClick",
					SchemaElementUId = new Guid("4fe5c619-e390-4b2b-a740-6edc8138d25f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSysSettingsMenuItemClickExecute,
				});
			}
		}

		private UserTaskSysSettingsMenuItemClickFlowElement _userTaskSysSettingsMenuItemClick;
		public UserTaskSysSettingsMenuItemClickFlowElement UserTaskSysSettingsMenuItemClick {
			get {
				return _userTaskSysSettingsMenuItemClick ?? (_userTaskSysSettingsMenuItemClick = new UserTaskSysSettingsMenuItemClickFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEventSysSettingsPageClosed;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEventSysSettingsPageClosed {
			get {
				return _intermediateCatchMessageEventSysSettingsPageClosed ?? (_intermediateCatchMessageEventSysSettingsPageClosed = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEventSysSettingsPageClosed",
					SchemaElementUId = new Guid("cd2c2e7c-7347-4339-bf4e-1b43f9cf7f1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysSettingsPageClosed",
				});
			}
		}

		private ProcessScriptTask _scriptTaskAddSysSettings;
		public ProcessScriptTask ScriptTaskAddSysSettings {
			get {
				return _scriptTaskAddSysSettings ?? (_scriptTaskAddSysSettings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskAddSysSettings",
					SchemaElementUId = new Guid("05d5ad74-b1ef-4c91-bb05-11735d568aec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskAddSysSettingsExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessSysVariableMenuItemClick;
		public ProcessFlowElement EventSubProcessSysVariableMenuItemClick {
			get {
				return _eventSubProcessSysVariableMenuItemClick ?? (_eventSubProcessSysVariableMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessSysVariableMenuItemClick",
					SchemaElementUId = new Guid("ff421d35-dec8-404a-aa2e-0abc47d3722b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageSysVariableMenuItemClick;
		public ProcessFlowElement StartMessageSysVariableMenuItemClick {
			get {
				return _startMessageSysVariableMenuItemClick ?? (_startMessageSysVariableMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageSysVariableMenuItemClick",
					SchemaElementUId = new Guid("477adc5f-affa-45bf-b847-09f1539fce84"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskSysVariableMenuItemClick;
		public ProcessScriptTask ScriptTaskSysVariableMenuItemClick {
			get {
				return _scriptTaskSysVariableMenuItemClick ?? (_scriptTaskSysVariableMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSysVariableMenuItemClick",
					SchemaElementUId = new Guid("5f58ca2c-fe46-47d3-9618-423843bf2dd7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSysVariableMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessLookupMenuItemClick;
		public ProcessFlowElement EventSubProcessLookupMenuItemClick {
			get {
				return _eventSubProcessLookupMenuItemClick ?? (_eventSubProcessLookupMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessLookupMenuItemClick",
					SchemaElementUId = new Guid("e0c0de73-0335-4251-999b-13e0a7c5b8f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageLookupMenuItemClick;
		public ProcessFlowElement StartMessageLookupMenuItemClick {
			get {
				return _startMessageLookupMenuItemClick ?? (_startMessageLookupMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageLookupMenuItemClick",
					SchemaElementUId = new Guid("7da5e975-7170-4a81-9015-1f75ed93199b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskLookupMenuItemClick;
		public ProcessScriptTask ScriptTaskLookupMenuItemClick {
			get {
				return _scriptTaskLookupMenuItemClick ?? (_scriptTaskLookupMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskLookupMenuItemClick",
					SchemaElementUId = new Guid("1f76f8d3-d062-4bd8-8e87-bf307d2e1711"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskLookupMenuItemClickExecute,
				});
			}
		}

		private UserTaskOpenLookupGridPageFlowElement _userTaskOpenLookupGridPage;
		public UserTaskOpenLookupGridPageFlowElement UserTaskOpenLookupGridPage {
			get {
				return _userTaskOpenLookupGridPage ?? (_userTaskOpenLookupGridPage = new UserTaskOpenLookupGridPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEventLookupGridPageClosed;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEventLookupGridPageClosed {
			get {
				return _intermediateCatchMessageEventLookupGridPageClosed ?? (_intermediateCatchMessageEventLookupGridPageClosed = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEventLookupGridPageClosed",
					SchemaElementUId = new Guid("0e3c5289-3f22-4ced-bb70-d9973aa40880"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _scriptTaskAddLookupValue;
		public ProcessScriptTask ScriptTaskAddLookupValue {
			get {
				return _scriptTaskAddLookupValue ?? (_scriptTaskAddLookupValue = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskAddLookupValue",
					SchemaElementUId = new Guid("c5818cdf-6967-42a2-bad4-ed170ac90d7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskAddLookupValueExecute,
				});
			}
		}

		private ProcessFlowElement _closeInsertParameterWindowEventSubProcess;
		public ProcessFlowElement CloseInsertParameterWindowEventSubProcess {
			get {
				return _closeInsertParameterWindowEventSubProcess ?? (_closeInsertParameterWindowEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CloseInsertParameterWindowEventSubProcess",
					SchemaElementUId = new Guid("888b4b1b-bba7-4d7a-b9a9-3b87f4c9b9be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageCloseInsertParameterWindow;
		public ProcessFlowElement StartMessageCloseInsertParameterWindow {
			get {
				return _startMessageCloseInsertParameterWindow ?? (_startMessageCloseInsertParameterWindow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageCloseInsertParameterWindow",
					SchemaElementUId = new Guid("e23aa58b-bd47-4f92-8e55-533c6571cdf0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _closeInsertParameterWindowScriptTask;
		public ProcessScriptTask CloseInsertParameterWindowScriptTask {
			get {
				return _closeInsertParameterWindowScriptTask ?? (_closeInsertParameterWindowScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CloseInsertParameterWindowScriptTask",
					SchemaElementUId = new Guid("5988d7a5-881b-4feb-964d-b4478ceb7576"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CloseInsertParameterWindowScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessSamplingColumnValueMenuItemClick;
		public ProcessFlowElement EventSubProcessSamplingColumnValueMenuItemClick {
			get {
				return _eventSubProcessSamplingColumnValueMenuItemClick ?? (_eventSubProcessSamplingColumnValueMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessSamplingColumnValueMenuItemClick",
					SchemaElementUId = new Guid("4ad52082-8546-4e7e-bc50-4ca6bdfb1eb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageSamplingColumnValueMenuItemClick;
		public ProcessFlowElement StartMessageSamplingColumnValueMenuItemClick {
			get {
				return _startMessageSamplingColumnValueMenuItemClick ?? (_startMessageSamplingColumnValueMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageSamplingColumnValueMenuItemClick",
					SchemaElementUId = new Guid("b0661ec0-addb-4f34-86ad-7151065f3fac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskSamplingColumnValueMenuItemClick;
		public ProcessScriptTask ScriptTaskSamplingColumnValueMenuItemClick {
			get {
				return _scriptTaskSamplingColumnValueMenuItemClick ?? (_scriptTaskSamplingColumnValueMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSamplingColumnValueMenuItemClick",
					SchemaElementUId = new Guid("c4091dc0-a79e-4ff9-af25-f9a2343e1568"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSamplingColumnValueMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessOpenDateTimeValueEditPage;
		public ProcessFlowElement EventSubProcessOpenDateTimeValueEditPage {
			get {
				return _eventSubProcessOpenDateTimeValueEditPage ?? (_eventSubProcessOpenDateTimeValueEditPage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessOpenDateTimeValueEditPage",
					SchemaElementUId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private UserTaskOpenDateTimeValueEditPageFlowElement _userTaskOpenDateTimeValueEditPage;
		public UserTaskOpenDateTimeValueEditPageFlowElement UserTaskOpenDateTimeValueEditPage {
			get {
				return _userTaskOpenDateTimeValueEditPage ?? (_userTaskOpenDateTimeValueEditPage = new UserTaskOpenDateTimeValueEditPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTaskOpenDateTimeValueEditPage;
		public ProcessScriptTask ScriptTaskOpenDateTimeValueEditPage {
			get {
				return _scriptTaskOpenDateTimeValueEditPage ?? (_scriptTaskOpenDateTimeValueEditPage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskOpenDateTimeValueEditPage",
					SchemaElementUId = new Guid("196b124e-fd4c-4cb0-9f15-801d74118448"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskOpenDateTimeValueEditPageExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDateTimeMenuItemClick;
		public ProcessScriptTask ScriptTaskDateTimeMenuItemClick {
			get {
				return _scriptTaskDateTimeMenuItemClick ?? (_scriptTaskDateTimeMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDateTimeMenuItemClick",
					SchemaElementUId = new Guid("71cdbdec-dc9d-4563-8fcd-99f4b8e211ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDateTimeMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageDateTimeMenuItemClick;
		public ProcessFlowElement StartMessageDateTimeMenuItemClick {
			get {
				return _startMessageDateTimeMenuItemClick ?? (_startMessageDateTimeMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDateTimeMenuItemClick",
					SchemaElementUId = new Guid("b826f712-3ef9-4957-8181-03990ea6b17b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDateMenuItemClick;
		public ProcessScriptTask ScriptTaskDateMenuItemClick {
			get {
				return _scriptTaskDateMenuItemClick ?? (_scriptTaskDateMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDateMenuItemClick",
					SchemaElementUId = new Guid("60d9f842-9b8d-4ce8-b370-dc8740814f25"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDateMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageDateMenuItemClick;
		public ProcessFlowElement StartMessageDateMenuItemClick {
			get {
				return _startMessageDateMenuItemClick ?? (_startMessageDateMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDateMenuItemClick",
					SchemaElementUId = new Guid("168eb6d2-8650-4210-b99b-0ffee7af4fd5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskTimeMenuItemClick;
		public ProcessScriptTask ScriptTaskTimeMenuItemClick {
			get {
				return _scriptTaskTimeMenuItemClick ?? (_scriptTaskTimeMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskTimeMenuItemClick",
					SchemaElementUId = new Guid("42643fea-9a45-4baf-a895-aa56f04b5419"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskTimeMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageTimeMenuItemClick;
		public ProcessFlowElement StartMessageTimeMenuItemClick {
			get {
				return _startMessageTimeMenuItemClick ?? (_startMessageTimeMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageTimeMenuItemClick",
					SchemaElementUId = new Guid("fcecbf64-39b0-40e8-9234-cb22499b7328"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDateTimeValueEditPageClosed;
		public ProcessFlowElement EventSubProcessDateTimeValueEditPageClosed {
			get {
				return _eventSubProcessDateTimeValueEditPageClosed ?? (_eventSubProcessDateTimeValueEditPageClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDateTimeValueEditPageClosed",
					SchemaElementUId = new Guid("5e4e5543-fed7-4df7-8793-e7bdbe6dfa56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDateTimeValueEditPageClosed;
		public ProcessFlowElement StartMessageDateTimeValueEditPageClosed {
			get {
				return _startMessageDateTimeValueEditPageClosed ?? (_startMessageDateTimeValueEditPageClosed = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDateTimeValueEditPageClosed",
					SchemaElementUId = new Guid("ef4c2fcf-183a-4e6c-b2df-a0264cb02157"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskDateTimeValueEditPageClosed;
		public ProcessScriptTask ScriptTaskDateTimeValueEditPageClosed {
			get {
				return _scriptTaskDateTimeValueEditPageClosed ?? (_scriptTaskDateTimeValueEditPageClosed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskDateTimeValueEditPageClosed",
					SchemaElementUId = new Guid("afbb57a4-374a-4091-bb5a-a906c7b7d500"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskDateTimeValueEditPageClosedExecute,
				});
			}
		}

		private LocalizableString _functionRoundUp;
		public LocalizableString FunctionRoundUp {
			get {
				return _functionRoundUp ?? (_functionRoundUp = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionRoundUp.Value"));
			}
		}

		private LocalizableString _functionRound;
		public LocalizableString FunctionRound {
			get {
				return _functionRound ?? (_functionRound = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionRound.Value"));
			}
		}

		private LocalizableString _functionRoundDown;
		public LocalizableString FunctionRoundDown {
			get {
				return _functionRoundDown ?? (_functionRoundDown = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionRoundDown.Value"));
			}
		}

		private LocalizableString _functionMod;
		public LocalizableString FunctionMod {
			get {
				return _functionMod ?? (_functionMod = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionMod.Value"));
			}
		}

		private LocalizableString _functionMin;
		public LocalizableString FunctionMin {
			get {
				return _functionMin ?? (_functionMin = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionMin.Value"));
			}
		}

		private LocalizableString _functionMax;
		public LocalizableString FunctionMax {
			get {
				return _functionMax ?? (_functionMax = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionMax.Value"));
			}
		}

		private LocalizableString _functionAbs;
		public LocalizableString FunctionAbs {
			get {
				return _functionAbs ?? (_functionAbs = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionAbs.Value"));
			}
		}

		private LocalizableString _functionAvg;
		public LocalizableString FunctionAvg {
			get {
				return _functionAvg ?? (_functionAvg = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionAvg.Value"));
			}
		}

		private LocalizableString _sysSettingsDisplayPrefix;
		public LocalizableString SysSettingsDisplayPrefix {
			get {
				return _sysSettingsDisplayPrefix ?? (_sysSettingsDisplayPrefix = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SysSettingsDisplayPrefix.Value"));
			}
		}

		private LocalizableString _sysVariableCaptionColumn;
		public LocalizableString SysVariableCaptionColumn {
			get {
				return _sysVariableCaptionColumn ?? (_sysVariableCaptionColumn = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SysVariableCaptionColumn.Value"));
			}
		}

		private LocalizableString _sysVariableLookupGridPageCaption;
		public LocalizableString SysVariableLookupGridPageCaption {
			get {
				return _sysVariableLookupGridPageCaption ?? (_sysVariableLookupGridPageCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SysVariableLookupGridPageCaption.Value"));
			}
		}

		private LocalizableString _sysVariableDisplayPrefix;
		public LocalizableString SysVariableDisplayPrefix {
			get {
				return _sysVariableDisplayPrefix ?? (_sysVariableDisplayPrefix = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SysVariableDisplayPrefix.Value"));
			}
		}

		private LocalizableString _parameterNotFound;
		public LocalizableString ParameterNotFound {
			get {
				return _parameterNotFound ?? (_parameterNotFound = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ParameterNotFound.Value"));
			}
		}

		private LocalizableString _functionDay;
		public LocalizableString FunctionDay {
			get {
				return _functionDay ?? (_functionDay = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionDay.Value"));
			}
		}

		private LocalizableString _functionMonth;
		public LocalizableString FunctionMonth {
			get {
				return _functionMonth ?? (_functionMonth = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionMonth.Value"));
			}
		}

		private LocalizableString _functionTime;
		public LocalizableString FunctionTime {
			get {
				return _functionTime ?? (_functionTime = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionTime.Value"));
			}
		}

		private LocalizableString _functionDayOfWeek;
		public LocalizableString FunctionDayOfWeek {
			get {
				return _functionDayOfWeek ?? (_functionDayOfWeek = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionDayOfWeek.Value"));
			}
		}

		private LocalizableString _functionDayInRange;
		public LocalizableString FunctionDayInRange {
			get {
				return _functionDayInRange ?? (_functionDayInRange = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FunctionDayInRange.Value"));
			}
		}

		private LocalizableString _lookupValueDisplayPrefix;
		public LocalizableString LookupValueDisplayPrefix {
			get {
				return _lookupValueDisplayPrefix ?? (_lookupValueDisplayPrefix = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LookupValueDisplayPrefix.Value"));
			}
		}

		private LocalizableString _samplingColumnValueDisplayPrefix;
		public LocalizableString SamplingColumnValueDisplayPrefix {
			get {
				return _samplingColumnValueDisplayPrefix ?? (_samplingColumnValueDisplayPrefix = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SamplingColumnValueDisplayPrefix.Value"));
			}
		}

		private LocalizableString _dateValueDisplayPrefix;
		public LocalizableString DateValueDisplayPrefix {
			get {
				return _dateValueDisplayPrefix ?? (_dateValueDisplayPrefix = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DateValueDisplayPrefix.Value"));
			}
		}

		private LocalizableString _timeValueDisplayPrefix;
		public LocalizableString TimeValueDisplayPrefix {
			get {
				return _timeValueDisplayPrefix ?? (_timeValueDisplayPrefix = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TimeValueDisplayPrefix.Value"));
			}
		}

		private LocalizableString _dateTimeValueDisplayPrefix;
		public LocalizableString DateTimeValueDisplayPrefix {
			get {
				return _dateTimeValueDisplayPrefix ?? (_dateTimeValueDisplayPrefix = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DateTimeValueDisplayPrefix.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessPlusMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPlusMenuItemClick };
			FlowElements[StartMessagePlusMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePlusMenuItemClick };
			FlowElements[ScriptTaskPlusMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPlusMenuItemClick };
			FlowElements[EventSubProcessParenthesesMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessParenthesesMenuItemClick };
			FlowElements[StartMessageParenthesesMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageParenthesesMenuItemClick };
			FlowElements[ScriptTaskParenthesesMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskParenthesesMenuItemClick };
			FlowElements[EventSubProcessMinusMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessMinusMenuItemClick };
			FlowElements[StartMessageMinusMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageMinusMenuItemClick };
			FlowElements[ScriptTaskMinusMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskMinusMenuItemClick };
			FlowElements[EventSubProcessMultiplyMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessMultiplyMenuItemClick };
			FlowElements[StartMessageMultiplyMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageMultiplyMenuItemClick };
			FlowElements[ScriptTaskMultiplyMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskMultiplyMenuItemClick };
			FlowElements[EventSubProcessDevideMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDevideMenuItemClick };
			FlowElements[StartMessageDevideMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDevideMenuItemClick };
			FlowElements[ScriptTaskDevideMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDevideMenuItemClick };
			FlowElements[EventSubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInit };
			FlowElements[ScriptTaskInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskInit };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[EventSubProcessPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPageLoadComplete };
			FlowElements[StartMessagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePageLoadComplete };
			FlowElements[ScriptTaskPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPageLoadComplete };
			FlowElements[AddParameterButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AddParameterButtonClickEventSubProcess };
			FlowElements[InsertParameterButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertParameterButtonClickStartMessage };
			FlowElements[InsertParameterButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertParameterButtonClickScriptTask };
			FlowElements[EventSubProcessRoundUpMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessRoundUpMenuItemClick };
			FlowElements[StartMessageRoundUpMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageRoundUpMenuItemClick };
			FlowElements[ScriptTaskRoundUpMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskRoundUpMenuItemClick };
			FlowElements[EventSubProcessRoundMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessRoundMenuItemClick };
			FlowElements[StartMessageRoundMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageRoundMenuItemClick };
			FlowElements[ScriptTaskRoundMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskRoundMenuItemClick };
			FlowElements[EventSubProcessRoundDownMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessRoundDownMenuItemClick };
			FlowElements[StartMessageRoundDownMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageRoundDownMenuItemClick };
			FlowElements[ScriptTaskRoundDownMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskRoundDownMenuItemClick };
			FlowElements[EventSubProcessModMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessModMenuItemClick };
			FlowElements[StartMessageModMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageModMenuItemClick };
			FlowElements[ScriptTaskModMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskModMenuItemClick };
			FlowElements[EventSubProcessMinMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessMinMenuItemClick };
			FlowElements[StartMessageMinMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageMinMenuItemClick };
			FlowElements[ScriptTaskMinMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskMinMenuItemClick };
			FlowElements[EventSubProcessMaxMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessMaxMenuItemClick };
			FlowElements[StartMessageMaxMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageMaxMenuItemClick };
			FlowElements[ScriptTaskMaxMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskMaxMenuItemClick };
			FlowElements[EventSubProcessAbsMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessAbsMenuItemClick };
			FlowElements[StartMessageAbsMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAbsMenuItemClick };
			FlowElements[ScriptTaskAbsMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskAbsMenuItemClick };
			FlowElements[EventSubProcessAvgMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessAvgMenuItemClick };
			FlowElements[StartMessageAvgMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAvgMenuItemClick };
			FlowElements[ScriptTaskAvgMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskAvgMenuItemClick };
			FlowElements[EventSubProcessDayItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDayItemClick };
			FlowElements[StartMessageDayItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDayItemClick };
			FlowElements[ScriptTaskDayItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDayItemClick };
			FlowElements[EventSubProcessMonthItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessMonthItemClick };
			FlowElements[StartMessageMonthItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageMonthItemClick };
			FlowElements[ScriptTaskMonthItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskMonthItemClick };
			FlowElements[EventSubProcessDayOfWeekItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDayOfWeekItemClick };
			FlowElements[StartMessageDayOfWeekItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDayOfWeekItemClick };
			FlowElements[ScriptTaskDayOfWeekItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDayOfWeekItemClick };
			FlowElements[EventSubProcessTimeItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessTimeItemClick };
			FlowElements[StartMessageTimeItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageTimeItemClick };
			FlowElements[ScriptTaskTimeItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskTimeItemClick };
			FlowElements[EventSubProcessDayInRangeItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDayInRangeItemClick };
			FlowElements[StartMessageDayInRangeItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDayInRangeItemClick };
			FlowElements[ScriptTaskDayInRangeItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDayInRangeItemClick };
			FlowElements[EventSubProcessSysSettingsMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessSysSettingsMenuItemClick };
			FlowElements[StartMessageSysSettingsMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageSysSettingsMenuItemClick };
			FlowElements[ScriptTaskSysSettingsMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSysSettingsMenuItemClick };
			FlowElements[UserTaskSysSettingsMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskSysSettingsMenuItemClick };
			FlowElements[IntermediateCatchMessageEventSysSettingsPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEventSysSettingsPageClosed };
			FlowElements[ScriptTaskAddSysSettings.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskAddSysSettings };
			FlowElements[EventSubProcessSysVariableMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessSysVariableMenuItemClick };
			FlowElements[StartMessageSysVariableMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageSysVariableMenuItemClick };
			FlowElements[ScriptTaskSysVariableMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSysVariableMenuItemClick };
			FlowElements[EventSubProcessLookupMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessLookupMenuItemClick };
			FlowElements[StartMessageLookupMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageLookupMenuItemClick };
			FlowElements[ScriptTaskLookupMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskLookupMenuItemClick };
			FlowElements[UserTaskOpenLookupGridPage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskOpenLookupGridPage };
			FlowElements[IntermediateCatchMessageEventLookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEventLookupGridPageClosed };
			FlowElements[ScriptTaskAddLookupValue.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskAddLookupValue };
			FlowElements[CloseInsertParameterWindowEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseInsertParameterWindowEventSubProcess };
			FlowElements[StartMessageCloseInsertParameterWindow.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageCloseInsertParameterWindow };
			FlowElements[CloseInsertParameterWindowScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseInsertParameterWindowScriptTask };
			FlowElements[EventSubProcessSamplingColumnValueMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessSamplingColumnValueMenuItemClick };
			FlowElements[StartMessageSamplingColumnValueMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageSamplingColumnValueMenuItemClick };
			FlowElements[ScriptTaskSamplingColumnValueMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSamplingColumnValueMenuItemClick };
			FlowElements[EventSubProcessOpenDateTimeValueEditPage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessOpenDateTimeValueEditPage };
			FlowElements[UserTaskOpenDateTimeValueEditPage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTaskOpenDateTimeValueEditPage };
			FlowElements[ScriptTaskOpenDateTimeValueEditPage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskOpenDateTimeValueEditPage };
			FlowElements[ScriptTaskDateTimeMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDateTimeMenuItemClick };
			FlowElements[StartMessageDateTimeMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDateTimeMenuItemClick };
			FlowElements[ScriptTaskDateMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDateMenuItemClick };
			FlowElements[StartMessageDateMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDateMenuItemClick };
			FlowElements[ScriptTaskTimeMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskTimeMenuItemClick };
			FlowElements[StartMessageTimeMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageTimeMenuItemClick };
			FlowElements[EventSubProcessDateTimeValueEditPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDateTimeValueEditPageClosed };
			FlowElements[StartMessageDateTimeValueEditPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDateTimeValueEditPageClosed };
			FlowElements[ScriptTaskDateTimeValueEditPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskDateTimeValueEditPageClosed };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessPlusMenuItemClick":
						break;
					case "StartMessagePlusMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskPlusMenuItemClick");
						break;
					case "ScriptTaskPlusMenuItemClick":
						break;
					case "EventSubProcessParenthesesMenuItemClick":
						break;
					case "StartMessageParenthesesMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskParenthesesMenuItemClick");
						break;
					case "ScriptTaskParenthesesMenuItemClick":
						break;
					case "EventSubProcessMinusMenuItemClick":
						break;
					case "StartMessageMinusMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskMinusMenuItemClick");
						break;
					case "ScriptTaskMinusMenuItemClick":
						break;
					case "EventSubProcessMultiplyMenuItemClick":
						break;
					case "StartMessageMultiplyMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskMultiplyMenuItemClick");
						break;
					case "ScriptTaskMultiplyMenuItemClick":
						break;
					case "EventSubProcessDevideMenuItemClick":
						break;
					case "StartMessageDevideMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskDevideMenuItemClick");
						break;
					case "ScriptTaskDevideMenuItemClick":
						break;
					case "EventSubProcessInit":
						break;
					case "ScriptTaskInit":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskInit");
						break;
					case "EventSubProcessPageLoadComplete":
						break;
					case "StartMessagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptTaskPageLoadComplete");
						break;
					case "ScriptTaskPageLoadComplete":
						break;
					case "AddParameterButtonClickEventSubProcess":
						break;
					case "InsertParameterButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("InsertParameterButtonClickScriptTask");
						break;
					case "InsertParameterButtonClickScriptTask":
						break;
					case "EventSubProcessRoundUpMenuItemClick":
						break;
					case "StartMessageRoundUpMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskRoundUpMenuItemClick");
						break;
					case "ScriptTaskRoundUpMenuItemClick":
						break;
					case "EventSubProcessRoundMenuItemClick":
						break;
					case "StartMessageRoundMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskRoundMenuItemClick");
						break;
					case "ScriptTaskRoundMenuItemClick":
						break;
					case "EventSubProcessRoundDownMenuItemClick":
						break;
					case "StartMessageRoundDownMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskRoundDownMenuItemClick");
						break;
					case "ScriptTaskRoundDownMenuItemClick":
						break;
					case "EventSubProcessModMenuItemClick":
						break;
					case "StartMessageModMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskModMenuItemClick");
						break;
					case "ScriptTaskModMenuItemClick":
						break;
					case "EventSubProcessMinMenuItemClick":
						break;
					case "StartMessageMinMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskMinMenuItemClick");
						break;
					case "ScriptTaskMinMenuItemClick":
						break;
					case "EventSubProcessMaxMenuItemClick":
						break;
					case "StartMessageMaxMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskMaxMenuItemClick");
						break;
					case "ScriptTaskMaxMenuItemClick":
						break;
					case "EventSubProcessAbsMenuItemClick":
						break;
					case "StartMessageAbsMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskAbsMenuItemClick");
						break;
					case "ScriptTaskAbsMenuItemClick":
						break;
					case "EventSubProcessAvgMenuItemClick":
						break;
					case "StartMessageAvgMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskAvgMenuItemClick");
						break;
					case "ScriptTaskAvgMenuItemClick":
						break;
					case "EventSubProcessDayItemClick":
						break;
					case "StartMessageDayItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskDayItemClick");
						break;
					case "ScriptTaskDayItemClick":
						break;
					case "EventSubProcessMonthItemClick":
						break;
					case "StartMessageMonthItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskMonthItemClick");
						break;
					case "ScriptTaskMonthItemClick":
						break;
					case "EventSubProcessDayOfWeekItemClick":
						break;
					case "StartMessageDayOfWeekItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskDayOfWeekItemClick");
						break;
					case "ScriptTaskDayOfWeekItemClick":
						break;
					case "EventSubProcessTimeItemClick":
						break;
					case "StartMessageTimeItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskTimeItemClick");
						break;
					case "ScriptTaskTimeItemClick":
						break;
					case "EventSubProcessDayInRangeItemClick":
						break;
					case "StartMessageDayInRangeItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskDayInRangeItemClick");
						break;
					case "ScriptTaskDayInRangeItemClick":
						break;
					case "EventSubProcessSysSettingsMenuItemClick":
						break;
					case "StartMessageSysSettingsMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskSysSettingsMenuItemClick");
						break;
					case "ScriptTaskSysSettingsMenuItemClick":
						e.Context.QueueTasks.Enqueue("UserTaskSysSettingsMenuItemClick");
						break;
					case "UserTaskSysSettingsMenuItemClick":
						ActivatedEventElements.Add("IntermediateCatchMessageEventSysSettingsPageClosed");
						break;
					case "IntermediateCatchMessageEventSysSettingsPageClosed":
						e.Context.QueueTasks.Enqueue("ScriptTaskAddSysSettings");
						break;
					case "ScriptTaskAddSysSettings":
						break;
					case "EventSubProcessSysVariableMenuItemClick":
						break;
					case "StartMessageSysVariableMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskSysVariableMenuItemClick");
						break;
					case "ScriptTaskSysVariableMenuItemClick":
						break;
					case "EventSubProcessLookupMenuItemClick":
						break;
					case "StartMessageLookupMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskLookupMenuItemClick");
						break;
					case "ScriptTaskLookupMenuItemClick":
						e.Context.QueueTasks.Enqueue("UserTaskOpenLookupGridPage");
						break;
					case "UserTaskOpenLookupGridPage":
						ActivatedEventElements.Add("IntermediateCatchMessageEventLookupGridPageClosed");
						break;
					case "IntermediateCatchMessageEventLookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("ScriptTaskAddLookupValue");
						break;
					case "ScriptTaskAddLookupValue":
						break;
					case "CloseInsertParameterWindowEventSubProcess":
						break;
					case "StartMessageCloseInsertParameterWindow":
						e.Context.QueueTasks.Enqueue("CloseInsertParameterWindowScriptTask");
						break;
					case "CloseInsertParameterWindowScriptTask":
						break;
					case "EventSubProcessSamplingColumnValueMenuItemClick":
						break;
					case "StartMessageSamplingColumnValueMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskSamplingColumnValueMenuItemClick");
						break;
					case "ScriptTaskSamplingColumnValueMenuItemClick":
						break;
					case "EventSubProcessOpenDateTimeValueEditPage":
						break;
					case "UserTaskOpenDateTimeValueEditPage":
						break;
					case "ScriptTaskOpenDateTimeValueEditPage":
						e.Context.QueueTasks.Enqueue("UserTaskOpenDateTimeValueEditPage");
						break;
					case "ScriptTaskDateTimeMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskOpenDateTimeValueEditPage");
						break;
					case "StartMessageDateTimeMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskDateTimeMenuItemClick");
						break;
					case "ScriptTaskDateMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskOpenDateTimeValueEditPage");
						break;
					case "StartMessageDateMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskDateMenuItemClick");
						break;
					case "ScriptTaskTimeMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskOpenDateTimeValueEditPage");
						break;
					case "StartMessageTimeMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskTimeMenuItemClick");
						break;
					case "EventSubProcessDateTimeValueEditPageClosed":
						break;
					case "StartMessageDateTimeValueEditPageClosed":
						e.Context.QueueTasks.Enqueue("ScriptTaskDateTimeValueEditPageClosed");
						break;
					case "ScriptTaskDateTimeValueEditPageClosed":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessagePlusMenuItemClick");
			ActivatedEventElements.Add("StartMessageParenthesesMenuItemClick");
			ActivatedEventElements.Add("StartMessageMinusMenuItemClick");
			ActivatedEventElements.Add("StartMessageMultiplyMenuItemClick");
			ActivatedEventElements.Add("StartMessageDevideMenuItemClick");
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("StartMessagePageLoadComplete");
			ActivatedEventElements.Add("InsertParameterButtonClickStartMessage");
			ActivatedEventElements.Add("StartMessageRoundUpMenuItemClick");
			ActivatedEventElements.Add("StartMessageRoundMenuItemClick");
			ActivatedEventElements.Add("StartMessageRoundDownMenuItemClick");
			ActivatedEventElements.Add("StartMessageModMenuItemClick");
			ActivatedEventElements.Add("StartMessageMinMenuItemClick");
			ActivatedEventElements.Add("StartMessageMaxMenuItemClick");
			ActivatedEventElements.Add("StartMessageAbsMenuItemClick");
			ActivatedEventElements.Add("StartMessageAvgMenuItemClick");
			ActivatedEventElements.Add("StartMessageDayItemClick");
			ActivatedEventElements.Add("StartMessageMonthItemClick");
			ActivatedEventElements.Add("StartMessageDayOfWeekItemClick");
			ActivatedEventElements.Add("StartMessageTimeItemClick");
			ActivatedEventElements.Add("StartMessageDayInRangeItemClick");
			ActivatedEventElements.Add("StartMessageSysSettingsMenuItemClick");
			ActivatedEventElements.Add("StartMessageSysVariableMenuItemClick");
			ActivatedEventElements.Add("StartMessageLookupMenuItemClick");
			ActivatedEventElements.Add("StartMessageCloseInsertParameterWindow");
			ActivatedEventElements.Add("StartMessageSamplingColumnValueMenuItemClick");
			ActivatedEventElements.Add("StartMessageDateTimeMenuItemClick");
			ActivatedEventElements.Add("StartMessageDateMenuItemClick");
			ActivatedEventElements.Add("StartMessageTimeMenuItemClick");
			ActivatedEventElements.Add("StartMessageDateTimeValueEditPageClosed");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessPlusMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessagePlusMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePlusMenuItemClick";
					result = StartMessagePlusMenuItemClick.Execute(context);
					break;
				case "ScriptTaskPlusMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPlusMenuItemClick";
					result = ScriptTaskPlusMenuItemClick.Execute(context, ScriptTaskPlusMenuItemClickExecute);
					break;
				case "EventSubProcessParenthesesMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageParenthesesMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageParenthesesMenuItemClick";
					result = StartMessageParenthesesMenuItemClick.Execute(context);
					break;
				case "ScriptTaskParenthesesMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskParenthesesMenuItemClick";
					result = ScriptTaskParenthesesMenuItemClick.Execute(context, ScriptTaskParenthesesMenuItemClickExecute);
					break;
				case "EventSubProcessMinusMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageMinusMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageMinusMenuItemClick";
					result = StartMessageMinusMenuItemClick.Execute(context);
					break;
				case "ScriptTaskMinusMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskMinusMenuItemClick";
					result = ScriptTaskMinusMenuItemClick.Execute(context, ScriptTaskMinusMenuItemClickExecute);
					break;
				case "EventSubProcessMultiplyMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageMultiplyMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageMultiplyMenuItemClick";
					result = StartMessageMultiplyMenuItemClick.Execute(context);
					break;
				case "ScriptTaskMultiplyMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskMultiplyMenuItemClick";
					result = ScriptTaskMultiplyMenuItemClick.Execute(context, ScriptTaskMultiplyMenuItemClickExecute);
					break;
				case "EventSubProcessDevideMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDevideMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDevideMenuItemClick";
					result = StartMessageDevideMenuItemClick.Execute(context);
					break;
				case "ScriptTaskDevideMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDevideMenuItemClick";
					result = ScriptTaskDevideMenuItemClick.Execute(context, ScriptTaskDevideMenuItemClickExecute);
					break;
				case "EventSubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTaskInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskInit";
					result = ScriptTaskInit.Execute(context, ScriptTaskInitExecute);
					break;
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
					break;
				case "EventSubProcessPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePageLoadComplete";
					result = StartMessagePageLoadComplete.Execute(context);
					break;
				case "ScriptTaskPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPageLoadComplete";
					result = ScriptTaskPageLoadComplete.Execute(context, ScriptTaskPageLoadCompleteExecute);
					break;
				case "AddParameterButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InsertParameterButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertParameterButtonClickStartMessage";
					result = InsertParameterButtonClickStartMessage.Execute(context);
					break;
				case "InsertParameterButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertParameterButtonClickScriptTask";
					result = InsertParameterButtonClickScriptTask.Execute(context, InsertParameterButtonClickScriptTaskExecute);
					break;
				case "EventSubProcessRoundUpMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageRoundUpMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageRoundUpMenuItemClick";
					result = StartMessageRoundUpMenuItemClick.Execute(context);
					break;
				case "ScriptTaskRoundUpMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskRoundUpMenuItemClick";
					result = ScriptTaskRoundUpMenuItemClick.Execute(context, ScriptTaskRoundUpMenuItemClickExecute);
					break;
				case "EventSubProcessRoundMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageRoundMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageRoundMenuItemClick";
					result = StartMessageRoundMenuItemClick.Execute(context);
					break;
				case "ScriptTaskRoundMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskRoundMenuItemClick";
					result = ScriptTaskRoundMenuItemClick.Execute(context, ScriptTaskRoundMenuItemClickExecute);
					break;
				case "EventSubProcessRoundDownMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageRoundDownMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageRoundDownMenuItemClick";
					result = StartMessageRoundDownMenuItemClick.Execute(context);
					break;
				case "ScriptTaskRoundDownMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskRoundDownMenuItemClick";
					result = ScriptTaskRoundDownMenuItemClick.Execute(context, ScriptTaskRoundDownMenuItemClickExecute);
					break;
				case "EventSubProcessModMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageModMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageModMenuItemClick";
					result = StartMessageModMenuItemClick.Execute(context);
					break;
				case "ScriptTaskModMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskModMenuItemClick";
					result = ScriptTaskModMenuItemClick.Execute(context, ScriptTaskModMenuItemClickExecute);
					break;
				case "EventSubProcessMinMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageMinMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageMinMenuItemClick";
					result = StartMessageMinMenuItemClick.Execute(context);
					break;
				case "ScriptTaskMinMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskMinMenuItemClick";
					result = ScriptTaskMinMenuItemClick.Execute(context, ScriptTaskMinMenuItemClickExecute);
					break;
				case "EventSubProcessMaxMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageMaxMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageMaxMenuItemClick";
					result = StartMessageMaxMenuItemClick.Execute(context);
					break;
				case "ScriptTaskMaxMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskMaxMenuItemClick";
					result = ScriptTaskMaxMenuItemClick.Execute(context, ScriptTaskMaxMenuItemClickExecute);
					break;
				case "EventSubProcessAbsMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAbsMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAbsMenuItemClick";
					result = StartMessageAbsMenuItemClick.Execute(context);
					break;
				case "ScriptTaskAbsMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskAbsMenuItemClick";
					result = ScriptTaskAbsMenuItemClick.Execute(context, ScriptTaskAbsMenuItemClickExecute);
					break;
				case "EventSubProcessAvgMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAvgMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAvgMenuItemClick";
					result = StartMessageAvgMenuItemClick.Execute(context);
					break;
				case "ScriptTaskAvgMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskAvgMenuItemClick";
					result = ScriptTaskAvgMenuItemClick.Execute(context, ScriptTaskAvgMenuItemClickExecute);
					break;
				case "EventSubProcessDayItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDayItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDayItemClick";
					result = StartMessageDayItemClick.Execute(context);
					break;
				case "ScriptTaskDayItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDayItemClick";
					result = ScriptTaskDayItemClick.Execute(context, ScriptTaskDayItemClickExecute);
					break;
				case "EventSubProcessMonthItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageMonthItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageMonthItemClick";
					result = StartMessageMonthItemClick.Execute(context);
					break;
				case "ScriptTaskMonthItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskMonthItemClick";
					result = ScriptTaskMonthItemClick.Execute(context, ScriptTaskMonthItemClickExecute);
					break;
				case "EventSubProcessDayOfWeekItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDayOfWeekItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDayOfWeekItemClick";
					result = StartMessageDayOfWeekItemClick.Execute(context);
					break;
				case "ScriptTaskDayOfWeekItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDayOfWeekItemClick";
					result = ScriptTaskDayOfWeekItemClick.Execute(context, ScriptTaskDayOfWeekItemClickExecute);
					break;
				case "EventSubProcessTimeItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageTimeItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageTimeItemClick";
					result = StartMessageTimeItemClick.Execute(context);
					break;
				case "ScriptTaskTimeItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskTimeItemClick";
					result = ScriptTaskTimeItemClick.Execute(context, ScriptTaskTimeItemClickExecute);
					break;
				case "EventSubProcessDayInRangeItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDayInRangeItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDayInRangeItemClick";
					result = StartMessageDayInRangeItemClick.Execute(context);
					break;
				case "ScriptTaskDayInRangeItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDayInRangeItemClick";
					result = ScriptTaskDayInRangeItemClick.Execute(context, ScriptTaskDayInRangeItemClickExecute);
					break;
				case "EventSubProcessSysSettingsMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageSysSettingsMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageSysSettingsMenuItemClick";
					result = StartMessageSysSettingsMenuItemClick.Execute(context);
					break;
				case "ScriptTaskSysSettingsMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSysSettingsMenuItemClick";
					result = ScriptTaskSysSettingsMenuItemClick.Execute(context, ScriptTaskSysSettingsMenuItemClickExecute);
					break;
				case "UserTaskSysSettingsMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskSysSettingsMenuItemClick";
					result = UserTaskSysSettingsMenuItemClick.Execute(context);
					break;
				case "IntermediateCatchMessageEventSysSettingsPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEventSysSettingsPageClosed";
					result = IntermediateCatchMessageEventSysSettingsPageClosed.Execute(context);
					break;
				case "ScriptTaskAddSysSettings":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskAddSysSettings";
					result = ScriptTaskAddSysSettings.Execute(context, ScriptTaskAddSysSettingsExecute);
					break;
				case "EventSubProcessSysVariableMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageSysVariableMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageSysVariableMenuItemClick";
					result = StartMessageSysVariableMenuItemClick.Execute(context);
					break;
				case "ScriptTaskSysVariableMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSysVariableMenuItemClick";
					result = ScriptTaskSysVariableMenuItemClick.Execute(context, ScriptTaskSysVariableMenuItemClickExecute);
					break;
				case "EventSubProcessLookupMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageLookupMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageLookupMenuItemClick";
					result = StartMessageLookupMenuItemClick.Execute(context);
					break;
				case "ScriptTaskLookupMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskLookupMenuItemClick";
					result = ScriptTaskLookupMenuItemClick.Execute(context, ScriptTaskLookupMenuItemClickExecute);
					break;
				case "UserTaskOpenLookupGridPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskOpenLookupGridPage";
					result = UserTaskOpenLookupGridPage.Execute(context);
					break;
				case "IntermediateCatchMessageEventLookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEventLookupGridPageClosed";
					result = IntermediateCatchMessageEventLookupGridPageClosed.Execute(context);
					break;
				case "ScriptTaskAddLookupValue":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskAddLookupValue";
					result = ScriptTaskAddLookupValue.Execute(context, ScriptTaskAddLookupValueExecute);
					break;
				case "CloseInsertParameterWindowEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageCloseInsertParameterWindow":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageCloseInsertParameterWindow";
					result = StartMessageCloseInsertParameterWindow.Execute(context);
					break;
				case "CloseInsertParameterWindowScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CloseInsertParameterWindowScriptTask";
					result = CloseInsertParameterWindowScriptTask.Execute(context, CloseInsertParameterWindowScriptTaskExecute);
					break;
				case "EventSubProcessSamplingColumnValueMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageSamplingColumnValueMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageSamplingColumnValueMenuItemClick";
					result = StartMessageSamplingColumnValueMenuItemClick.Execute(context);
					break;
				case "ScriptTaskSamplingColumnValueMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSamplingColumnValueMenuItemClick";
					result = ScriptTaskSamplingColumnValueMenuItemClick.Execute(context, ScriptTaskSamplingColumnValueMenuItemClickExecute);
					break;
				case "EventSubProcessOpenDateTimeValueEditPage":
					context.QueueTasks.Dequeue();
					break;
				case "UserTaskOpenDateTimeValueEditPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserTaskOpenDateTimeValueEditPage";
					result = UserTaskOpenDateTimeValueEditPage.Execute(context);
					break;
				case "ScriptTaskOpenDateTimeValueEditPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskOpenDateTimeValueEditPage";
					result = ScriptTaskOpenDateTimeValueEditPage.Execute(context, ScriptTaskOpenDateTimeValueEditPageExecute);
					break;
				case "ScriptTaskDateTimeMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDateTimeMenuItemClick";
					result = ScriptTaskDateTimeMenuItemClick.Execute(context, ScriptTaskDateTimeMenuItemClickExecute);
					break;
				case "StartMessageDateTimeMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDateTimeMenuItemClick";
					result = StartMessageDateTimeMenuItemClick.Execute(context);
					break;
				case "ScriptTaskDateMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDateMenuItemClick";
					result = ScriptTaskDateMenuItemClick.Execute(context, ScriptTaskDateMenuItemClickExecute);
					break;
				case "StartMessageDateMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDateMenuItemClick";
					result = StartMessageDateMenuItemClick.Execute(context);
					break;
				case "ScriptTaskTimeMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskTimeMenuItemClick";
					result = ScriptTaskTimeMenuItemClick.Execute(context, ScriptTaskTimeMenuItemClickExecute);
					break;
				case "StartMessageTimeMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageTimeMenuItemClick";
					result = StartMessageTimeMenuItemClick.Execute(context);
					break;
				case "EventSubProcessDateTimeValueEditPageClosed":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDateTimeValueEditPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDateTimeValueEditPageClosed";
					result = StartMessageDateTimeValueEditPageClosed.Execute(context);
					break;
				case "ScriptTaskDateTimeValueEditPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskDateTimeValueEditPageClosed";
					result = ScriptTaskDateTimeValueEditPageClosed.Execute(context, ScriptTaskDateTimeValueEditPageClosedExecute);
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
				case "MessagePanelClientId":
					MessagePanelClientId = reader.GetValue<System.String>();
				break;
				case "ReferenceSchemaUId":
					ReferenceSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "DateTimeKind":
					DateTimeKind = reader.GetValue<System.String>();
				break;
				case "IsColumnStructureExplorerCreated":
					IsColumnStructureExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "IsColumnStructureExplorerRegistered":
					IsColumnStructureExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "ColumnStructureExplorer":
					ColumnStructureExplorer = reader.GetSerializableObjectValue();
				break;
				case "SamplingSchemaColumnDataValueTypeUId":
					SamplingSchemaColumnDataValueTypeUId = reader.GetValue<System.Guid>();
				break;
				case "SamplingSchemaUId":
					SamplingSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "EditElementUId":
					EditElementUId = reader.GetValue<System.Guid>();
				break;
				case "SchemaExplorerRegistered":
					SchemaExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "SchemaExplorerCreated":
					SchemaExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "LookupValuePrefix":
					LookupValuePrefix = reader.GetValue<System.String>();
				break;
				case "BorderOfOperandPattern":
					BorderOfOperandPattern = reader.GetValue<System.String>();
				break;
				case "SysSettingsPrefix":
					SysSettingsPrefix = reader.GetValue<System.String>();
				break;
				case "SysVariablePrefix":
					SysVariablePrefix = reader.GetValue<System.String>();
				break;
				case "MetaParamsDictionary":
					MetaParamsDictionary = reader.GetSerializableObjectValue();
				break;
				case "RightMacrosBracket":
					RightMacrosBracket = reader.GetValue<System.String>();
				break;
				case "LeftMacrosBracket":
					LeftMacrosBracket = reader.GetValue<System.String>();
				break;
				case "EditSchemaManagerName":
					EditSchemaManagerName = reader.GetValue<System.String>();
				break;
				case "EditSchemaUId":
					EditSchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskPlusMenuItemClickExecute(ProcessExecutingContext context) {
			InsertTextIntoCursorPosition(" + ");
			return true;
		}

		public virtual bool ScriptTaskParenthesesMenuItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText("({0})");
			return true;
		}

		public virtual bool ScriptTaskMinusMenuItemClickExecute(ProcessExecutingContext context) {
			InsertTextIntoCursorPosition(" - ");
			return true;
		}

		public virtual bool ScriptTaskMultiplyMenuItemClickExecute(ProcessExecutingContext context) {
			InsertTextIntoCursorPosition(" * ");
			return true;
		}

		public virtual bool ScriptTaskDevideMenuItemClickExecute(ProcessExecutingContext context) {
			InsertTextIntoCursorPosition(" / ");
			return true;
		}

		public virtual bool ScriptTaskInitExecute(ProcessExecutingContext context) {
			if (Ext.IsAjaxRequest) {
				if (SchemaExplorerCreated) {
					InitializeSchemaExplorerWindow();
				}
				if (IsColumnStructureExplorerCreated) {
					CreateColumnStructureExplorer();
				}
			} else {
				FillSysVariableMenuItems();
				object queryStringValue = Page.Request.QueryString["SamplingSchemaUId"];
				if (queryStringValue != null) {
					SamplingSchemaUId = new Guid(queryStringValue.ToString());
				} 	
				Page.SamplingColumnValueMenuItem.Hidden = SamplingSchemaUId == Guid.Empty;
			}
			return true;
		}

		public virtual bool ScriptTaskPageLoadCompleteExecute(ProcessExecutingContext context) {
			MetaParamsDictionary = new Dictionary<string, string>();
			return true;
		}

		public virtual bool InsertParameterButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			InitializeSchemaExplorerWindow();
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			var processSchema = FindDesignedProcessSchema();
			string handler = string.Empty;
			string handlerReferenceName = string.Format("window.{0}_EditCompleteParameter", schemaExplorer.ClientID);
			var sb = new StringBuilder();
			sb.Append("function(columnInfo) {\n");
			sb.Append("var info = Ext.util.JSON.decode(columnInfo);");
			sb.AppendFormat("{0}.setValue(info.metaPath);", Page.HiddenInsertParameterTextEdit.ClientID);
			sb.AppendFormat("window.Terrasoft.AjaxMethods.ThrowClientEvent('{0}', '{1}');", InstanceUId,"CloseInsertParameterWindow");
			sb.Append("}");
			handler = sb.ToString();
			handler = string.Format(@"{0} = {1}", handlerReferenceName, handler);
			Page.ScriptManager.AddScript(string.Format("if ({2}) {{ {0}.un(\"{1}\",{2}); }}", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			Page.ScriptManager.AddScript(handler);
			Page.ScriptManager.AddScript(string.Format("{0}.on(\"{1}\",{2});", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			schemaExplorer.ManagerName = processSchema.Manager.Name;
			schemaExplorer.ShowEditWindow(processSchema.UId, string.Empty);
			return true;
		}

		public virtual bool ScriptTaskRoundUpMenuItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionRoundUp.ToString());
			return true;
		}

		public virtual bool ScriptTaskRoundMenuItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionRound.ToString());
			return true;
		}

		public virtual bool ScriptTaskRoundDownMenuItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionRoundDown.ToString());
			return true;
		}

		public virtual bool ScriptTaskModMenuItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionMod.ToString());
			return true;
		}

		public virtual bool ScriptTaskMinMenuItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionMin.ToString());
			return true;
		}

		public virtual bool ScriptTaskMaxMenuItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionMax.ToString());
			return true;
		}

		public virtual bool ScriptTaskAbsMenuItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionAbs.ToString());
			return true;
		}

		public virtual bool ScriptTaskAvgMenuItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionAvg.ToString());
			return true;
		}

		public virtual bool ScriptTaskDayItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionDay.ToString());
			return true;
		}

		public virtual bool ScriptTaskMonthItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionMonth.ToString());
			return true;
		}

		public virtual bool ScriptTaskDayOfWeekItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionDayOfWeek.ToString());
			return true;
		}

		public virtual bool ScriptTaskTimeItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionTime.ToString());
			return true;
		}

		public virtual bool ScriptTaskDayInRangeItemClickExecute(ProcessExecutingContext context) {
			EncloseSelectedText(FunctionDayInRange.ToString());
			return true;
		}

		public virtual bool ScriptTaskSysSettingsMenuItemClickExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			UserTaskSysSettingsMenuItemClick.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			UserTaskSysSettingsMenuItemClick.PageParameters = new Dictionary <string, object> {
				{ "schemaName", "SysSettings" },
				{ "customClosedEvent", "SysSettingsPageClosed" },
				{ "multiSelectMode", false }
			};
			return true;
		}

		public virtual bool ScriptTaskAddSysSettingsExecute(ProcessExecutingContext context) {
			Dictionary<string, object> selectedValues = UserTaskSysSettingsMenuItemClick.GetSelectedValues(UserConnection);
			if (selectedValues == null || selectedValues.Count == 0) {
				return true;
			}
			var enumerator = selectedValues.GetEnumerator();
			enumerator.MoveNext();
			var selectedValue = enumerator.Current;
			var sysSetting = new Terrasoft.Configuration.SysSettings(UserConnection);
			if (!sysSetting.FetchFromDB(new Guid(selectedValue.Key))) {
				return true;
			}
			InsertTextIntoCursorPosition(MakeSysSettingValueMacros(sysSetting.Name, sysSetting.Code));
			return true;
		}

		public virtual bool ScriptTaskSysVariableMenuItemClickExecute(ProcessExecutingContext context) {
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			var sysVariableName = extraParams["tag"].ToString();
			if (string.IsNullOrEmpty(sysVariableName)) {
				return true;
			}
			var sysVariable = UserConnection.SystemValueManager.GetInstanceByName(sysVariableName);
			string macros = MakeSysVariableMacros(sysVariable.Name, sysVariable.Caption);
			InsertTextIntoCursorPosition(macros);
			return true;
		}

		public virtual bool ScriptTaskLookupMenuItemClickExecute(ProcessExecutingContext context) {
			UserTaskOpenLookupGridPage.ProcessKey = context.Process.InstanceUId;
			var pageParameters = new Dictionary <string, object>();
			pageParameters.Add("hideButtons", true);
			var orderedCollection = GetReferenceSchemaList();
			pageParameters.Add("referenceSchemaList", Json.Serialize(orderedCollection));
			if (ReferenceSchemaUId == Guid.Empty) {
				pageParameters.Add("schemaUId", orderedCollection.First()["referenceSchemaUId"]);
			} else {
				pageParameters.Add("schemaUId", ReferenceSchemaUId);
			}
			UserTaskOpenLookupGridPage.PageParameters = pageParameters;
			return true;
		}

		public virtual bool ScriptTaskAddLookupValueExecute(ProcessExecutingContext context) {
			var selectedValues = (Dictionary<string, object>)(UserTaskOpenLookupGridPage.GetSelectedValues(UserConnection));
			if (selectedValues.Count == 0) {
				return true;
			}
			//JArray referenceSchemaList = GetReferenceSchemaList();
			var metaParamsDictionary = (Dictionary<string, string>)MetaParamsDictionary;
			foreach (KeyValuePair<string, object> selectedValue in selectedValues) {
				var values = (Dictionary<string,object>)selectedValue.Value;
				values.Add("selectedValue", selectedValue.Key);
				string macros;
				if (TryMakeLookupValueMacros(values, out macros)) {
					InsertTextIntoCursorPosition(macros);
				}
				return true;
			}
			return true;
		}

		public virtual bool CloseInsertParameterWindowScriptTaskExecute(ProcessExecutingContext context) {
			string serverMetaPath = GetPropertyServerMetaPathByClientMetaPath(Page.HiddenInsertParameterTextEdit.Text);
			string macros = MakeMacros(GetPropertyDisplayPathByServerMetaPath(serverMetaPath));
			var metaParamsDictionary = (Dictionary<string, string>)MetaParamsDictionary;
			if (!metaParamsDictionary.ContainsKey(macros)) {
				metaParamsDictionary.Add(macros, MakeMacros(serverMetaPath));
			}
			InsertTextIntoCursorPosition(macros);
			return true;
		}

		public virtual bool ScriptTaskSamplingColumnValueMenuItemClickExecute(ProcessExecutingContext context) {
			ShowColumnStructureExplorerEditWindow(SamplingSchemaUId, SamplingSchemaColumnDataValueTypeUId);
			return true;
		}

		public virtual bool ScriptTaskOpenDateTimeValueEditPageExecute(ProcessExecutingContext context) {
			UserTaskOpenDateTimeValueEditPage.OpenerInstanceId = InstanceUId;
			UserTaskOpenDateTimeValueEditPage.UseCurrentActivePage = true;
			UserTaskOpenDateTimeValueEditPage.PageUId = new Guid("D02C5D7D-E691-4000-901C-84BE8065FE10"); //DateTimeValueEditPageId;
			UserTaskOpenDateTimeValueEditPage.CloseMessage = "DateTimeValueEditPageClosed";
			var queryStringParameters = new Dictionary<string, string>() {
				{ "dateTimeKind", DateTimeKind },
				{ "contextKey", "DateTimeValueEditPageContextKey" }
			};
			UserTaskOpenDateTimeValueEditPage.PageParameters = queryStringParameters;
			return true;
		}

		public virtual bool ScriptTaskDateTimeMenuItemClickExecute(ProcessExecutingContext context) {
			DateTimeKind = "DateTime";
			return true;
		}

		public virtual bool ScriptTaskDateMenuItemClickExecute(ProcessExecutingContext context) {
			DateTimeKind = "Date";
			return true;
		}

		public virtual bool ScriptTaskTimeMenuItemClickExecute(ProcessExecutingContext context) {
			DateTimeKind = "Time";
			return true;
		}

		public virtual bool ScriptTaskDateTimeValueEditPageClosedExecute(ProcessExecutingContext context) {
			object dateTimeValue = UserConnection.SessionData["DateTimeValueEditPageContextKey"];
			if (dateTimeValue == null) {
				return true;
			}
			UserConnection.SessionData["DateTimeValueEditPageContextKey"] = null;
			var dateTime = (DateTime)dateTimeValue;
			InsertTextIntoCursorPosition(MakeDateTimeValueMacros(dateTime, DateTimeKind));
			return true;
		}

		public virtual string GetPropertyDisplayPathByServerMetaPath(string serverMetaPath) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var generator = new ProcessSchemaGeneratorNew(UserConnection, processSchema.ProcessSchemaManager.Namespace);
			return generator.GetPropertyPathByMetaPath(new ProcessSchemaParameter(processSchema), serverMetaPath, true);
		}

		public virtual void InsertTextIntoCursorPosition(string text) {
			Page.ScriptManager.AddScript(string.Format("{0}.insertTextFragment(\"{1}\");",
				Page.ValueMemoEdit.ClientID, text.Replace("\"", "\\\"")));
		}

		public virtual string MakeMacros(string item) {
			return string.Concat(LeftMacrosBracket, item, RightMacrosBracket);
		}

		public virtual void EncloseSelectedText(string pattern) {
			string leftPart = pattern.LeftOf("{0}");
			string rightPart = pattern.RightOf("{0}");
			Page.ScriptManager.AddScript(string.Format("{0}.encloseSelectedText(\"{1}\", \"{2}\");",
				Page.ValueMemoEdit.ClientID, leftPart, rightPart));
		}

		public virtual string ConvertDisplayCodeToFormulaTaskBody(string code) {
			if (string.IsNullOrEmpty(code)) {
				return code;
			}
			string body = code.Replace(TerrasoftCommonNamespace, "");
			body = ConvertFunctionMacroToCode(body, FunctionRoundUp, @"Math.Ceiling(");
			body = ConvertFunctionMacroToCode(body, FunctionRound, @"Math.Round(");
			body = ConvertFunctionMacroToCode(body, FunctionRoundDown, @"Math.Floor(");
			body = ConvertFunctionMacroToCode(body, FunctionAbs, @"Math.Abs(");
			Dictionary<string, string> functionNameMacrosMap = GetFunctionNameMacrosMap();
			foreach(var nameMacros in functionNameMacrosMap) {
				string typeName = nameMacros.Key + "(";
				body = ConvertFunctionMacroToCode(body, nameMacros.Value, typeName);
			}
			var metaParamsDictionary = (Dictionary<string, string>)MetaParamsDictionary;
			foreach (var metaParam in metaParamsDictionary) {
				body = Regex.Replace(body, Regex.Escape(metaParam.Key), metaParam.Value);
			}
			return body;
		}

		public virtual string ConvertFormulaTaskBodyToDisplayCode(string body) {
			if (string.IsNullOrEmpty(body)) {
				return body;
			}
			string code = body.Replace(TerrasoftCommonNamespace, "");
			code = ConvertFunctionCodeToMacro(code, FunctionRoundUp, @"Math\.Ceiling\(");
			code = ConvertFunctionCodeToMacro(code, FunctionRound, @"Math\.Round\(");
			code = ConvertFunctionCodeToMacro(code, FunctionRoundDown, @"Math\.Floor\(");
			code = ConvertFunctionCodeToMacro(code, FunctionAbs, @"Math\.Abs\(");
			Dictionary<string, string> functionNameMacrosMap = GetFunctionNameMacrosMap();
			foreach(var nameMacros in functionNameMacrosMap) {
				string typeName = nameMacros.Key.Replace(".", @"\.") + @"\(";
				code = ConvertFunctionCodeToMacro(code, nameMacros.Value, nameMacros.Key);
			}
			var metaParamsDictionary = (Dictionary<string, string>)MetaParamsDictionary;
			var rx = new Regex(Regex.Escape(LeftMacrosBracket) + "(.+?)" + Regex.Escape(RightMacrosBracket));
			foreach (Match match in rx.Matches(code))
			{
				if (match.Groups.Count != 2) {
					continue;
				}
				try {
					string macrosBody = match.Groups[1].Value;
					string macros = match.Value;
					string displayText = macros;
					if (macrosBody.StartsWith(SysVariablePrefix)) {
						string sysVariableName = macrosBody.Substring(SysVariablePrefix.Length);
						var sysVariable = UserConnection.SystemValueManager.GetInstanceByName(sysVariableName);
						displayText = MakeMacros(SysVariableDisplayPrefix.ToString() + sysVariable.Caption);
					} else if (macrosBody.StartsWith(SysSettingsPrefix)) {
						string sysSettingsCode = macrosBody.Substring(SysSettingsPrefix.Length);
						var sysSettings = new Terrasoft.Configuration.SysSettings(UserConnection);
						if (!sysSettings.FetchFromDB("Code", sysSettingsCode)) {
							continue;
						}
						displayText = MakeMacros(SysSettingsDisplayPrefix.ToString() + sysSettings.Name);
					} else if (macrosBody.StartsWith(LookupValuePrefix)) {
						string schemaUId = macrosBody.Substring(LookupValuePrefix.Length, 36);
						Guid lookupUId = new Guid(macrosBody.Substring(LookupValuePrefix.Length + 37));
						EntitySchema entitySchema = UserConnection.EntitySchemaManager.FindInstanceByUId(new Guid(schemaUId));
						if (entitySchema == null) {
							continue;
						}
						string schemaName = entitySchema.Caption;
						if (string.IsNullOrEmpty(schemaName)) {
							schemaName = entitySchema.Name;
						}
						Entity lookup = new Entity(UserConnection);
						lookup.UseAdminRights = false;
						lookup.Schema = entitySchema;
						if (!lookup.FetchFromDB(lookupUId)) {
							continue;
						}
						displayText = MakeMacros(string.Concat(LookupValueDisplayPrefix.ToString(), schemaName, ".", lookup.PrimaryDisplayColumnValue));
					} else if (macrosBody.StartsWith(SamplingColumnValuePrefix)) {
						string schemaColumnMetaPath = macrosBody.Substring(SamplingColumnValuePrefix.Length);
						EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SamplingSchemaUId);
						string schemaColumnPath = entitySchema.GetSchemaColumnPathByMetaPath(schemaColumnMetaPath);
						string schemaColumnFullCaption = entitySchema.GetSchemaColumnFullCaptionByPath(schemaColumnPath);
						displayText = MakeMacros(SamplingColumnValueDisplayPrefix.ToString() + schemaColumnFullCaption);
					} else if (macrosBody.StartsWith(DateValuePrefix)) {
						string date = macrosBody.Substring(DateValuePrefix.Length);
						displayText = MakeMacros(DateValueDisplayPrefix.ToString() + date);
					} else if (macrosBody.StartsWith(TimeValuePrefix)) {
						string time = macrosBody.Substring(TimeValuePrefix.Length);
						displayText = MakeMacros(TimeValueDisplayPrefix.ToString() + time);
					} else if (macrosBody.StartsWith(DateTimeValuePrefix)) {
						string dateTime = macrosBody.Substring(DateTimeValuePrefix.Length);
						displayText = MakeMacros(DateTimeValueDisplayPrefix.ToString() + dateTime);
					} else {
						displayText = MakeMacros(GetPropertyDisplayPathByServerMetaPath(macrosBody));
					}
					if (!metaParamsDictionary.ContainsKey(displayText)) {
						metaParamsDictionary.Add(displayText, macros);
					}
				} catch (Exception ex) {
					if (!string.IsNullOrEmpty(MessagePanelClientId)) {
						var mp = Terrasoft.UI.WebControls.Page.FindChildControlByClientId(Page.PageContainer.Parent.Parent, MessagePanelClientId)
							as MessagePanel;
						if (mp != null) {
							mp.AddMessage("ConvertFormulaTaskBodyToDisplayCode", ex.ToString(), MessageType.Warning);
						}
					}
				};
			}
			foreach (var metaParam in metaParamsDictionary) {
				code = code.Replace(metaParam.Value, metaParam.Key);
			}
			return code;
		}

		public virtual string ConvertFunctionCodeToMacro(string codeBody, LocalizableString functionMacro, string functionCode) {
			return Regex.Replace(codeBody, BorderOfOperandPattern + functionCode, "$1" + functionMacro.ToString().LeftOf("{0}"));
		}

		public virtual string ConvertFunctionMacroToCode(string body, LocalizableString functionMacro, string functionCode) {
			return Regex.Replace(body, BorderOfOperandPattern + Regex.Escape(functionMacro.ToString().LeftOf("{0}")), "$1" + functionCode);
		}

		public virtual string GetPropertyServerMetaPathByClientMetaPath(string clientMetaPath) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var generator = new ProcessSchemaGeneratorNew(UserConnection, processSchema.ProcessSchemaManager.Namespace);
			return generator.GetMetaPath(processSchema, clientMetaPath);
		}

		public virtual List<Dictionary<string, string>> GetSysVariableVDSStructure() {
			return new List<Dictionary<string, string>> {
				new Dictionary<string, string> {
					{ "Name", "Id" },
					{ "ValueColumnName", "Id" },
					{ "DisplayColumnName", "Id" },
					{ "DataValueTypeName", "Guid" },
					{ "Caption", "Id" },
					{ "IsVisible", "false" },
					{ "IsSortable", "false" },
					{ "IsPrimaryColumn", "true" }
				},
				new Dictionary<string, string> {
					{ "Name", "Caption" },
					{ "ValueColumnName", "Caption" },
					{ "DisplayColumnName", "Caption" },
					{ "DataValueTypeName", "Text" },
					{ "Caption", SysVariableCaptionColumn.ToString() },
					{ "IsVisible", "true" },
					{ "IsSortable", "true" },
					{ "IsPrimaryDisplayColumn", "true" }
				}
			};
		}

		public virtual void FillSysVariableMenuItems() {
			foreach(var systemValueItem in UserConnection.SystemValueManager.GetItems()) {
				var systemValue = UserConnection.SystemValueManager.GetInstanceByUId(systemValueItem.UId);
				Terrasoft.Configuration.DynamicMenuConstructor.ClientAppendMenuItem(
					Page, Page.AddSysVariableButton.ClientID,
					systemValue.Name, systemValue.Caption.ToString(),
					new ControlImage(), systemValue.Name, "SysVariableMenuItemClick");
			}
			Terrasoft.Configuration.DynamicMenuConstructor.SetComponentMenuItemClickSignal(Page, Page.AddSysVariableButton.ClientID, "SysVariableMenuItemClick");
		}

		public virtual ProcessSchema FindDesignedProcessSchema() {
			var schemaManager = UserConnection.GetSchemaManager(EditSchemaManagerName);
			if (schemaManager is PageSchemaManager) {
				return (schemaManager as PageSchemaManager).GetDesignInstance(UserConnection, EditSchemaUId).EventsProcessSchema;
			} else if (schemaManager is ProcessSchemaManager) {
				return (schemaManager as ProcessSchemaManager).GetDesignInstance(UserConnection, EditSchemaUId);
			} else {
				return null;
			}
		}

		public virtual void SetFormulaBody(string body) {
			if (!string.IsNullOrEmpty(body)) {
				Page.ValueMemoEdit.SetValue(ConvertFormulaTaskBodyToDisplayCode(body));
			}
		}

		public virtual string GetFormulaBody() {
			return ConvertDisplayCodeToFormulaTaskBody(HttpUtility.HtmlDecode(Page.ValueMemoEdit.Text));
		}

		public virtual JArray GetReferenceSchemaList() {
			Guid packageUId = GetPackageUId();
			Dictionary<Guid, string> referenceEntitySchemas = GetReferenceEntitySchemas(packageUId);
			var referenceSchemaList = new JArray();
			foreach(KeyValuePair<Guid, string> referenceEntitySchema in referenceEntitySchemas) {
				var element = new JObject();
				element.Add(new JProperty("referenceSchemaUId", referenceEntitySchema.Key.ToString()));
				element.Add(new JProperty("referenceSchemaCaption", referenceEntitySchema.Value));
				referenceSchemaList.Add(element);
			}
			return referenceSchemaList;
		}

		public virtual void InitializeSchemaExplorerWindow() {
			bool isNewSchemaExplorer = SchemaExplorer == null;
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			if (isNewSchemaExplorer) {
				schemaExplorer = new SchemaStructureExplorer(Page.ValueControlLayout, "schemaStructure", false, false);
			}
			if (isNewSchemaExplorer) {
				schemaExplorer.ManagerName = EditSchemaManagerName;
			} else {
				schemaExplorer.IncludedDataValueTypes.Clear();
			}
			schemaExplorer.IgnoredUserTaskSchemas.Clear();
			schemaExplorer.IsInputSchemaParameterMode = true;
			SchemaExplorerCreated = true;
			if (!SchemaExplorerRegistered) {
				schemaExplorer.Register();
				SchemaExplorerRegistered = true;
			}
			SchemaExplorer = schemaExplorer;
		}

		public virtual StructureExplorer CreateColumnStructureExplorer() {
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);
			var columnStructureExplorer = new StructureExplorer(Page.ValueControlLayout, "columnExplorer", false, false, string.Empty);
			columnStructureExplorer.ExcludeDataValueTypes = new string[] { "Binary", "File", "Image", "Color" };
			columnStructureExplorer.IsShowSystemColumns = true;
			columnStructureExplorer.IsShowOppositeReference = true;
			ComponentAjaxEvent editComplete = columnStructureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += ColumnStructureExplorer_EditComplete;
			editComplete.ExtraParameters.Add(param);
			columnStructureExplorer.Columns = new DataSourceStructureColumnCollection();
			IsColumnStructureExplorerCreated = true;
			if (!IsColumnStructureExplorerRegistered) {
				columnStructureExplorer.Register();
				IsColumnStructureExplorerRegistered = true;
			}
			ColumnStructureExplorer = columnStructureExplorer;
			return columnStructureExplorer;
		}

		public virtual void ColumnStructureExplorer_EditComplete(object sender, AjaxEventArgs e) {
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SamplingSchemaUId);
			var structureExplorerColumn = (JObject)Json.Deserialize(e.ExtraParameters["itemsInfo"]);
			var schemaColumnMetaPath = structureExplorerColumn["metaPath"].ToString();
			string schemaColumnPath = entitySchema.GetSchemaColumnPathByMetaPath(schemaColumnMetaPath);
			string schemaColumnFullCaption = entitySchema.GetSchemaColumnFullCaptionByPath(schemaColumnPath);
			string macros = MakeMacros(SamplingColumnValueDisplayPrefix.ToString() + schemaColumnFullCaption);
			var metaParamsDictionary = (Dictionary<string, string>)MetaParamsDictionary;
			if (!metaParamsDictionary.ContainsKey(macros)) {
				metaParamsDictionary.Add(macros, MakeMacros(SamplingColumnValuePrefix + schemaColumnMetaPath));
			}
			InsertTextIntoCursorPosition(macros);
		}

		public virtual void ShowColumnStructureExplorerEditWindow(Guid schemaUId, Guid parameterDataValueTypeUId) {
			if (schemaUId == Guid.Empty) {
				return;
			}
			StructureExplorer columnStructureExplorer;
			if (IsColumnStructureExplorerCreated) {
				columnStructureExplorer = (StructureExplorer)ColumnStructureExplorer;
			} else {
				columnStructureExplorer = CreateColumnStructureExplorer();
			}
			columnStructureExplorer.IncludedDataValueTypes.Clear();
			if (parameterDataValueTypeUId != Guid.Empty) {
				DataValueTypeManager dataValueTypeManager = UserConnection.DataValueTypeManager;
				string dataValueTypeGroupName = dataValueTypeManager.GetItemByUId(parameterDataValueTypeUId).GroupName;
				//Collection<DataValueType> dataValueTypes = dataValueTypeManager.GetDataValueTypesByGroupName(dataValueTypeGroupName);
				foreach(DataValueTypeManagerItem dataValueTypeItem in dataValueTypeManager.GetItems()) {
					if (dataValueTypeItem.GroupName == dataValueTypeGroupName) {
						columnStructureExplorer.IncludedDataValueTypes[dataValueTypeItem.UId] = Guid.NewGuid();
					}
				}
			}
			columnStructureExplorer.ShowEditWindow(schemaUId, null);
		}

		public virtual string MakeDateTimeValueMacros(DateTime dateTime, string dateTimeKind) {
			string dateTimeText;
			string valuePrefix;
			string valueDisplayPrefix;
			if (dateTimeKind == "Date") {
				valuePrefix = DateValuePrefix;
				valueDisplayPrefix = DateValueDisplayPrefix;
				dateTimeText = dateTime.ToString("dd.MM.yyyy");
			} else if (dateTimeKind == "Time") {
				valuePrefix = TimeValuePrefix;
				valueDisplayPrefix = TimeValueDisplayPrefix;
				dateTimeText = dateTime.ToString("HH:mm");
			} else {
				valuePrefix = DateTimeValuePrefix;
				valueDisplayPrefix = DateTimeValueDisplayPrefix;
				dateTimeText = dateTime.ToString("dd.MM.yyyy HH:mm");
			}
			string macros = MakeMacros(valueDisplayPrefix + dateTimeText);
			string value = MakeMacros(valuePrefix + dateTimeText);
			var metaParamsDictionary = (Dictionary<string, string>)MetaParamsDictionary;
			if (!metaParamsDictionary.ContainsKey(macros)) {
				metaParamsDictionary.Add(macros, value);
			} else {
				metaParamsDictionary[macros] = value;
			}
			return macros;
		}

		public virtual bool TryMakeLookupValueMacros(Dictionary<string,object> values, out string macros) {
			macros = null;
			if (values == null || values.Count == 0) {
				return false;
			}
			var metaParamsDictionary = (Dictionary<string, string>)MetaParamsDictionary;
			var schemaUId = values["schemaUId"].ToString();
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.FindInstanceByUId(new Guid(schemaUId));
			if (entitySchema == null) {
				return false;
			}
			string schemaName = entitySchema.Caption;
			if (string.IsNullOrEmpty(schemaName)) {
				schemaName = entitySchema.Name;
			}
			string schemaPrimaryDisplayColumnName = entitySchema.PrimaryDisplayColumn.Name;
			macros = MakeMacros(string.Concat(LookupValueDisplayPrefix.ToString(), schemaName, ".", values[schemaPrimaryDisplayColumnName]));
			if (!metaParamsDictionary.ContainsKey(macros)) {
				metaParamsDictionary.Add(macros, MakeMacros(
					string.Concat(LookupValuePrefix, schemaUId, ".", values["selectedValue"])));
			}
			return true;
		}

		public virtual string MakeSysVariableMacros(string name, string caption) {
			var metaParamsDictionary = (Dictionary<string, string>)MetaParamsDictionary;
			string macros = MakeMacros(SysVariableDisplayPrefix.ToString() + caption);
			if (!metaParamsDictionary.ContainsKey(macros)) {
				metaParamsDictionary.Add(macros, MakeMacros(SysVariablePrefix + name));
			}
			return macros;
		}

		public virtual string MakeSysSettingValueMacros(string name, string code) {
			var metaParamsDictionary = (Dictionary<string, string>)MetaParamsDictionary;
			string macros = MakeMacros(SysSettingsDisplayPrefix.ToString() + name);
			if (!metaParamsDictionary.ContainsKey(macros)) {
				metaParamsDictionary.Add(macros, MakeMacros(SysSettingsPrefix + code));
			}
			return macros;
		}

		public virtual Dictionary<Guid, string> GetReferenceEntitySchemas(Guid packageUId) {
			/*
			var sessionCache = UserConnection.SessionCache.WithLocalCaching();
			var referenceSchemaListKey = ReferenceSchemaListKey + "_" + packageUId.ToString();
			var entitySchemasValue = sessionCache[referenceSchemaListKey];
			if (entitySchemasValue != null) {
				return (Dictionary<Guid, string>)entitySchemasValue;
			}
			*/
			IEnumerable<Guid> packageIds = WorkspaceUtilities.GetPackageHierarchyIds(UserConnection, packageUId, UserConnection.Workspace.Id);
			var schemaSelect =
				(Select)new Select(UserConnection)
					.Column("UId")
					.Column("Caption")
				.From("SysSchema")
				.Where("ManagerName").IsEqual(Column.Parameter("EntitySchemaManager"))
				.And("ExtendParent").IsEqual(Column.Parameter(false))
				.And("SysPackageId").In(Column.Parameters(packageIds))
				.And().Not().Exists(
					new Select(UserConnection)
						.Column(Column.Const(1))
					.From("SysSchemaProperty")
					.Where("SysSchemaProperty", "SysSchemaId").IsEqual("SysSchema", "Id")
					.And("SysSchemaProperty", "Name").IsEqual(Column.Parameter("IsVirtual"))
					.And("SysSchemaProperty", "Value").IsEqual(Column.Parameter("True")) as Select)
				.OrderBy(OrderDirectionStrict.Ascending, "Caption");
			var entitySchemas = new Dictionary<Guid, string>();
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = schemaSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						entitySchemas.Add(reader.GetColumnValue<Guid>("UId"), reader.GetColumnValue<string>("Caption"));
					}
				}
			}
			//sessionCache[referenceSchemaListKey] = entitySchemas;
			return entitySchemas;
		}

		public virtual Guid GetPackageUId() {
			Guid packageUId;
			string processUserTaskSchemaManagerName = "ProcessUserTaskSchemaManager";
			if (EditSchemaManagerName != processUserTaskSchemaManagerName) {
				packageUId = FindDesignedProcessSchema().PackageUId;
			} else {
				var processUserTaskSchemaManager =
					(ProcessUserTaskSchemaManager)UserConnection.GetSchemaManager(processUserTaskSchemaManagerName);
				packageUId = processUserTaskSchemaManager.GetDesignInstance(UserConnection, EditSchemaUId).PackageUId;
			}
			return packageUId;
		}

		public virtual void ClearFormulaBody() {
			Page.ValueMemoEdit.SetValue(string.Empty);
		}

		public virtual Dictionary<string, string> GetFunctionNameMacrosMap() {
			return new Dictionary<string, string> {
				{"FormulaUtilities.Min", FunctionMin},
				{"FormulaUtilities.Max", FunctionAvg},
				{"FormulaUtilities.Avg", FunctionAvg},
				{"FormulaUtilities.Mod", FunctionMod},
				{"DateTimeUtilities.Day", FunctionDay},
				{"DateTimeUtilities.Month", FunctionMonth},
				{"DateTimeUtilities.Time", FunctionTime},
				{"DateTimeUtilities.DayOfWeek", FunctionDayOfWeek},
				{"DateTimeUtilities.DayInRange", FunctionDayInRange}
			};
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PlusMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessagePlusMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessagePlusMenuItemClick");
						}
						break;
					case "ParenthesesMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageParenthesesMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageParenthesesMenuItemClick");
						}
						break;
					case "MinusMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageMinusMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageMinusMenuItemClick");
						}
						break;
					case "MultiplyMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageMultiplyMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageMultiplyMenuItemClick");
						}
						break;
					case "DevideMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageDevideMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageDevideMenuItemClick");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessagePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessagePageLoadComplete");
						}
						break;
					case "InsertParameterButtonClick":
							if (ActivatedEventElements.Contains("InsertParameterButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("InsertParameterButtonClickStartMessage");
						}
						break;
					case "RoundUpMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageRoundUpMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageRoundUpMenuItemClick");
						}
						break;
					case "RoundMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageRoundMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageRoundMenuItemClick");
						}
						break;
					case "RoundDownMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageRoundDownMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageRoundDownMenuItemClick");
						}
						break;
					case "ModMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageModMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageModMenuItemClick");
						}
						break;
					case "MinMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageMinMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageMinMenuItemClick");
						}
						break;
					case "MaxMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageMaxMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageMaxMenuItemClick");
						}
						break;
					case "AbsMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageAbsMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageAbsMenuItemClick");
						}
						break;
					case "AvgMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageAvgMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageAvgMenuItemClick");
						}
						break;
					case "DayItemClick":
							if (ActivatedEventElements.Contains("StartMessageDayItemClick")) {
							context.QueueTasks.Enqueue("StartMessageDayItemClick");
						}
						break;
					case "MonthItemClick":
							if (ActivatedEventElements.Contains("StartMessageMonthItemClick")) {
							context.QueueTasks.Enqueue("StartMessageMonthItemClick");
						}
						break;
					case "DayOfWeekItemClick":
							if (ActivatedEventElements.Contains("StartMessageDayOfWeekItemClick")) {
							context.QueueTasks.Enqueue("StartMessageDayOfWeekItemClick");
						}
						break;
					case "TimeItemClick":
							if (ActivatedEventElements.Contains("StartMessageTimeItemClick")) {
							context.QueueTasks.Enqueue("StartMessageTimeItemClick");
						}
						break;
					case "DayInRangeItemClick":
							if (ActivatedEventElements.Contains("StartMessageDayInRangeItemClick")) {
							context.QueueTasks.Enqueue("StartMessageDayInRangeItemClick");
						}
						break;
					case "SysSettingsMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageSysSettingsMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageSysSettingsMenuItemClick");
						}
						break;
					case "SysSettingsPageClosed":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEventSysSettingsPageClosed")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEventSysSettingsPageClosed");
					}
					break;
					case "SysVariableMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageSysVariableMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageSysVariableMenuItemClick");
						}
						break;
					case "LookupMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageLookupMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageLookupMenuItemClick");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEventLookupGridPageClosed")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEventLookupGridPageClosed");
					}
					break;
					case "CloseInsertParameterWindow":
							if (ActivatedEventElements.Contains("StartMessageCloseInsertParameterWindow")) {
							context.QueueTasks.Enqueue("StartMessageCloseInsertParameterWindow");
						}
						break;
					case "SamplingColumnValueMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageSamplingColumnValueMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageSamplingColumnValueMenuItemClick");
						}
						break;
					case "DateTimeMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageDateTimeMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageDateTimeMenuItemClick");
						}
						break;
					case "DateMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageDateMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageDateMenuItemClick");
						}
						break;
					case "TimeMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessageTimeMenuItemClick")) {
							context.QueueTasks.Enqueue("StartMessageTimeMenuItemClick");
						}
						break;
					case "DateTimeValueEditPageClosed":
							if (ActivatedEventElements.Contains("StartMessageDateTimeValueEditPageClosed")) {
							context.QueueTasks.Enqueue("StartMessageDateTimeValueEditPageClosed");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("MessagePanelClientId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MessagePanelClientId", MessagePanelClientId, null);
			}
			if (!HasMapping("ReferenceSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ReferenceSchemaUId", ReferenceSchemaUId, Guid.Empty);
			}
			if (!HasMapping("DateTimeKind") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DateTimeKind", DateTimeKind, null);
			}
			if (!HasMapping("IsColumnStructureExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsColumnStructureExplorerCreated", IsColumnStructureExplorerCreated, false);
			}
			if (!HasMapping("IsColumnStructureExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsColumnStructureExplorerRegistered", IsColumnStructureExplorerRegistered, false);
			}
			if (ColumnStructureExplorer != null) {
				if (ColumnStructureExplorer.GetType().IsSerializable ||
					ColumnStructureExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnStructureExplorer", ColumnStructureExplorer, null);
				}
			}
			if (!HasMapping("SamplingSchemaColumnDataValueTypeUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SamplingSchemaColumnDataValueTypeUId", SamplingSchemaColumnDataValueTypeUId, Guid.Empty);
			}
			if (!HasMapping("SamplingSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SamplingSchemaUId", SamplingSchemaUId, Guid.Empty);
			}
			if (!HasMapping("EditElementUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditElementUId", EditElementUId, Guid.Empty);
			}
			if (!HasMapping("SchemaExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SchemaExplorerRegistered", SchemaExplorerRegistered, false);
			}
			if (!HasMapping("SchemaExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SchemaExplorerCreated", SchemaExplorerCreated, false);
			}
			if (!HasMapping("LookupValuePrefix") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LookupValuePrefix", LookupValuePrefix, null);
			}
			if (!HasMapping("BorderOfOperandPattern") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("BorderOfOperandPattern", BorderOfOperandPattern, null);
			}
			if (!HasMapping("SysSettingsPrefix") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysSettingsPrefix", SysSettingsPrefix, null);
			}
			if (!HasMapping("SysVariablePrefix") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysVariablePrefix", SysVariablePrefix, null);
			}
			if (MetaParamsDictionary != null) {
				if (MetaParamsDictionary.GetType().IsSerializable ||
					MetaParamsDictionary.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("MetaParamsDictionary", MetaParamsDictionary, null);
				}
			}
			if (!HasMapping("RightMacrosBracket") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RightMacrosBracket", RightMacrosBracket, null);
			}
			if (!HasMapping("LeftMacrosBracket") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LeftMacrosBracket", LeftMacrosBracket, null);
			}
			if (!HasMapping("EditSchemaManagerName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSchemaManagerName", EditSchemaManagerName, null);
			}
			if (!HasMapping("EditSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSchemaUId", EditSchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: FormulaEditPageEventsProcess

	/// <exclude/>
	public class FormulaEditPageEventsProcess : FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl>
	{

		public FormulaEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FormulaEditPageSchemaUserControl

	/// <exclude/>
	public partial class FormulaEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ValueControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ValueControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ValueToolBarControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ValueToolBarControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddOperatorButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddOperatorButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem PlusMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("PlusMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem MinusMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("MinusMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem MultiplyMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("MultiplyMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem DevideMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("DevideMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem ParenthesesMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("ParenthesesMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddFunctionButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddFunctionButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem RoundUpMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("RoundUpMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem RoundMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("RoundMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem RoundDownMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("RoundDownMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem ModMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("ModMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem MinMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("MinMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem MaxMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("MaxMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AbsMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AbsMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AvgMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AvgMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem DayItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("DayItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem MonthItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("MonthItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem DayOfWeekItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("DayOfWeekItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem TimeItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("TimeItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem DayInRangeItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("DayInRangeItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button InsertParameterButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("InsertParameterButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddSysVariableButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddSysVariableButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorDateTime {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuSeparator)PageContainer.FindPageControl("MenuSeparatorDateTime", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem DateMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("DateMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem TimeMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("TimeMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem DateTimeMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("DateTimeMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorSamplingColumnValue {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuSeparator)PageContainer.FindPageControl("MenuSeparatorSamplingColumnValue", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem SamplingColumnValueMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("SamplingColumnValueMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorSysSettings {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuSeparator)PageContainer.FindPageControl("MenuSeparatorSysSettings", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem SysSettingsMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("SysSettingsMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorLookup {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuSeparator)PageContainer.FindPageControl("MenuSeparatorLookup", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem LookupMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("LookupMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuSeparator MenuSeparatorSysVariable {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuSeparator)PageContainer.FindPageControl("MenuSeparatorSysVariable", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit ValueMemoEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("ValueMemoEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit HiddenInsertParameterTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("HiddenInsertParameterTextEdit", true);
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
			PlusMenuItem.AjaxEvents.Click.Event += PlusMenuItemClick;
			MinusMenuItem.AjaxEvents.Click.Event += MinusMenuItemClick;
			MultiplyMenuItem.AjaxEvents.Click.Event += MultiplyMenuItemClick;
			DevideMenuItem.AjaxEvents.Click.Event += DevideMenuItemClick;
			ParenthesesMenuItem.AjaxEvents.Click.Event += ParenthesesMenuItemClick;
			RoundUpMenuItem.AjaxEvents.Click.Event += RoundUpMenuItemClick;
			RoundMenuItem.AjaxEvents.Click.Event += RoundMenuItemClick;
			RoundDownMenuItem.AjaxEvents.Click.Event += RoundDownMenuItemClick;
			ModMenuItem.AjaxEvents.Click.Event += ModMenuItemClick;
			MinMenuItem.AjaxEvents.Click.Event += MinMenuItemClick;
			MaxMenuItem.AjaxEvents.Click.Event += MaxMenuItemClick;
			AbsMenuItem.AjaxEvents.Click.Event += AbsMenuItemClick;
			AvgMenuItem.AjaxEvents.Click.Event += AvgMenuItemClick;
			DayItem.AjaxEvents.Click.Event += DayItemClick;
			MonthItem.AjaxEvents.Click.Event += MonthItemClick;
			DayOfWeekItem.AjaxEvents.Click.Event += DayOfWeekItemClick;
			TimeItem.AjaxEvents.Click.Event += TimeItemClick;
			DayInRangeItem.AjaxEvents.Click.Event += DayInRangeItemClick;
			InsertParameterButton.AjaxEvents.Click.Event += InsertParameterButtonClick;
			DateMenuItem.AjaxEvents.Click.Event += DateMenuItemClick;
			TimeMenuItem.AjaxEvents.Click.Event += TimeMenuItemClick;
			DateTimeMenuItem.AjaxEvents.Click.Event += DateTimeMenuItemClick;
			SamplingColumnValueMenuItem.AjaxEvents.Click.Event += SamplingColumnValueMenuItemClick;
			SysSettingsMenuItem.AjaxEvents.Click.Event += SysSettingsMenuItemClick;
			LookupMenuItem.AjaxEvents.Click.Event += LookupMenuItemClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			PlusMenuItem.AjaxEvents.Click.Event -= PlusMenuItemClick;
			MinusMenuItem.AjaxEvents.Click.Event -= MinusMenuItemClick;
			MultiplyMenuItem.AjaxEvents.Click.Event -= MultiplyMenuItemClick;
			DevideMenuItem.AjaxEvents.Click.Event -= DevideMenuItemClick;
			ParenthesesMenuItem.AjaxEvents.Click.Event -= ParenthesesMenuItemClick;
			RoundUpMenuItem.AjaxEvents.Click.Event -= RoundUpMenuItemClick;
			RoundMenuItem.AjaxEvents.Click.Event -= RoundMenuItemClick;
			RoundDownMenuItem.AjaxEvents.Click.Event -= RoundDownMenuItemClick;
			ModMenuItem.AjaxEvents.Click.Event -= ModMenuItemClick;
			MinMenuItem.AjaxEvents.Click.Event -= MinMenuItemClick;
			MaxMenuItem.AjaxEvents.Click.Event -= MaxMenuItemClick;
			AbsMenuItem.AjaxEvents.Click.Event -= AbsMenuItemClick;
			AvgMenuItem.AjaxEvents.Click.Event -= AvgMenuItemClick;
			DayItem.AjaxEvents.Click.Event -= DayItemClick;
			MonthItem.AjaxEvents.Click.Event -= MonthItemClick;
			DayOfWeekItem.AjaxEvents.Click.Event -= DayOfWeekItemClick;
			TimeItem.AjaxEvents.Click.Event -= TimeItemClick;
			DayInRangeItem.AjaxEvents.Click.Event -= DayInRangeItemClick;
			InsertParameterButton.AjaxEvents.Click.Event -= InsertParameterButtonClick;
			DateMenuItem.AjaxEvents.Click.Event -= DateMenuItemClick;
			TimeMenuItem.AjaxEvents.Click.Event -= TimeMenuItemClick;
			DateTimeMenuItem.AjaxEvents.Click.Event -= DateTimeMenuItemClick;
			SamplingColumnValueMenuItem.AjaxEvents.Click.Event -= SamplingColumnValueMenuItemClick;
			SysSettingsMenuItem.AjaxEvents.Click.Event -= SysSettingsMenuItemClick;
			LookupMenuItem.AjaxEvents.Click.Event -= LookupMenuItemClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (FormulaEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new FormulaEditPageEventsProcess(UserConnection);
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

		public virtual void PlusMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("PlusMenuItemClick");
		}

		public virtual void MinusMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("MinusMenuItemClick");
		}

		public virtual void MultiplyMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("MultiplyMenuItemClick");
		}

		public virtual void DevideMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("DevideMenuItemClick");
		}

		public virtual void ParenthesesMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("ParenthesesMenuItemClick");
		}

		public virtual void RoundUpMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("RoundUpMenuItemClick");
		}

		public virtual void RoundMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("RoundMenuItemClick");
		}

		public virtual void RoundDownMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("RoundDownMenuItemClick");
		}

		public virtual void ModMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("ModMenuItemClick");
		}

		public virtual void MinMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("MinMenuItemClick");
		}

		public virtual void MaxMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("MaxMenuItemClick");
		}

		public virtual void AbsMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("AbsMenuItemClick");
		}

		public virtual void AvgMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("AvgMenuItemClick");
		}

		public virtual void DayItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("DayItemClick");
		}

		public virtual void MonthItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("MonthItemClick");
		}

		public virtual void DayOfWeekItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("DayOfWeekItemClick");
		}

		public virtual void TimeItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("TimeItemClick");
		}

		public virtual void DayInRangeItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("DayInRangeItemClick");
		}

		public virtual void InsertParameterButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("InsertParameterButtonClick");
		}

		public virtual void DateMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("DateMenuItemClick");
		}

		public virtual void TimeMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("TimeMenuItemClick");
		}

		public virtual void DateTimeMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("DateTimeMenuItemClick");
		}

		public virtual void SamplingColumnValueMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("SamplingColumnValueMenuItemClick");
		}

		public virtual void SysSettingsMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("SysSettingsMenuItemClick");
		}

		public virtual void LookupMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("LookupMenuItemClick");
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
			SchemaName = "FormulaEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: FormulaEditPageEventsProcessSchema

	/// <exclude/>
	public class FormulaEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public FormulaEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public FormulaEditPageEventsProcessSchema(FormulaEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "FormulaEditPageEventsProcess";
			UId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateEditSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9fb220ea-5cd8-47b7-b166-f882001613c4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EditSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditSchemaManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8a408a16-a6b5-49fe-9743-450f78caaadf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EditSchemaManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLeftMacrosBracketParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5b7e2833-cb95-4710-9879-65c39a8fe55d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LeftMacrosBracket",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateRightMacrosBracketParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a4fe08a9-b9b3-4697-ab6c-c009fd42d5aa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"RightMacrosBracket",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMetaParamsDictionaryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bcd8ca43-af4d-41ed-849d-f04d74c59ee3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"MetaParamsDictionary",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysVariablePrefixParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("332b98b2-8cad-45d9-aec1-4e5d271018b7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"SysVariablePrefix",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSysSettingsPrefixParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c471cf4a-63a5-46e5-aba8-3f813eae602a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"SysSettingsPrefix",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateBorderOfOperandPatternParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7e161b5e-4f73-48a0-a3a7-6863a1759822"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"BorderOfOperandPattern",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5dcbde06-ac89-4161-8f48-4b669010f557"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"SchemaExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupValuePrefixParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e1cfc529-56cc-42b6-8771-adbe7948653a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LookupValuePrefix",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8639798f-b9b2-494c-a854-c23d2ff7ac8a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"SchemaExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b23c1a7c-c013-4c49-96b4-05f78ae163c0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"SchemaExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditElementUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("78cbb193-0fe6-47f5-bdfb-d67e3476c963"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EditElementUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e5509cc3-bbf9-4488-ae3a-3704d65b86d0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"SamplingSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingSchemaColumnDataValueTypeUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7a424c34-3bde-4fa8-8a3c-8135605a6712"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"SamplingSchemaColumnDataValueTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b3d15208-85d2-47cc-b0b8-cf35cb726849"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ColumnStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsColumnStructureExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ffbf0bbf-589b-4edc-a58c-9608a27c71e0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"IsColumnStructureExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsColumnStructureExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("abb5cc7b-408a-4856-bd2d-670b2c9ef564"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"IsColumnStructureExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingColumnValuePrefixParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b75b8c64-ed88-495c-856e-6158f863f219"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"SamplingColumnValuePrefix",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateDateTimeKindParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5b8f2da7-e7d0-4198-a98e-a6435ec65d87"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"DateTimeKind",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDateValuePrefixParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7424dcc7-771c-4235-9c0d-fddafdaceb6f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"DateValuePrefix",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateTimeValuePrefixParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9e4cf086-6e01-4d0b-9c1b-10c44b8de980"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"TimeValuePrefix",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateDateTimeValuePrefixParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("11f1895d-d090-46c1-81c2-5b3d02f6ac53"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"DateTimeValuePrefix",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateReferenceSchemaListKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b55bdbe3-ac1c-4893-8148-5213e0a50267"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ReferenceSchemaListKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateReferenceSchemaListCountKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e3ddf947-35d1-47b4-bc58-7ff7fab53438"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ReferenceSchemaListCountKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateReferenceSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b7e0adab-55f5-4873-be91-166744e1b49e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ReferenceSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessagePanelClientIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2e64bc55-b5f1-4ea0-98b0-610432e0211d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"MessagePanelClientId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTerrasoftCommonNamespaceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6a9c29f0-29a0-4771-a05b-b607d4ec0f08"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"TerrasoftCommonNamespace",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEditSchemaUIdParameter());
			Parameters.Add(CreateEditSchemaManagerNameParameter());
			Parameters.Add(CreateLeftMacrosBracketParameter());
			Parameters.Add(CreateRightMacrosBracketParameter());
			Parameters.Add(CreateMetaParamsDictionaryParameter());
			Parameters.Add(CreateSysVariablePrefixParameter());
			Parameters.Add(CreateSysSettingsPrefixParameter());
			Parameters.Add(CreateBorderOfOperandPatternParameter());
			Parameters.Add(CreateSchemaExplorerParameter());
			Parameters.Add(CreateLookupValuePrefixParameter());
			Parameters.Add(CreateSchemaExplorerCreatedParameter());
			Parameters.Add(CreateSchemaExplorerRegisteredParameter());
			Parameters.Add(CreateEditElementUIdParameter());
			Parameters.Add(CreateSamplingSchemaUIdParameter());
			Parameters.Add(CreateSamplingSchemaColumnDataValueTypeUIdParameter());
			Parameters.Add(CreateColumnStructureExplorerParameter());
			Parameters.Add(CreateIsColumnStructureExplorerRegisteredParameter());
			Parameters.Add(CreateIsColumnStructureExplorerCreatedParameter());
			Parameters.Add(CreateSamplingColumnValuePrefixParameter());
			Parameters.Add(CreateDateTimeKindParameter());
			Parameters.Add(CreateDateValuePrefixParameter());
			Parameters.Add(CreateTimeValuePrefixParameter());
			Parameters.Add(CreateDateTimeValuePrefixParameter());
			Parameters.Add(CreateReferenceSchemaListKeyParameter());
			Parameters.Add(CreateReferenceSchemaListCountKeyParameter());
			Parameters.Add(CreateReferenceSchemaUIdParameter());
			Parameters.Add(CreateMessagePanelClientIdParameter());
			Parameters.Add(CreateTerrasoftCommonNamespaceParameter());
		}

		protected virtual void InitializeUserTaskSysSettingsMenuItemClickParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("03a8597d-7f47-4748-804a-5852cbcd8e1f"),
				ContainerUId = new Guid("106607bc-02df-4179-ba4a-e10938427966"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("fe6a891c-8750-4c51-9ece-cba24a61e8d6"),
				ContainerUId = new Guid("106607bc-02df-4179-ba4a-e10938427966"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
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
				UId = new Guid("b01941b4-bbbd-41f6-be65-e26c3efb864e"),
				ContainerUId = new Guid("106607bc-02df-4179-ba4a-e10938427966"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
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
				UId = new Guid("cafbc279-e0ce-40f6-a46c-177bd927da68"),
				ContainerUId = new Guid("106607bc-02df-4179-ba4a-e10938427966"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UseCurrentActivePage",
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

		protected virtual void InitializeUserTaskOpenLookupGridPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a3845ccc-5717-43b5-8c8a-cefe4134f319"),
				ContainerUId = new Guid("e26865e6-a67d-4778-8d9b-d571e3c42a95"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("3cbf884b-2b54-4628-b52c-9c7141c328c5"),
				ContainerUId = new Guid("e26865e6-a67d-4778-8d9b-d571e3c42a95"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
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
				UId = new Guid("9ac5eb33-7322-48d3-b727-4dda67f66c38"),
				ContainerUId = new Guid("e26865e6-a67d-4778-8d9b-d571e3c42a95"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
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
				UId = new Guid("00f0ef32-0579-49e1-8601-ec95bac5aed8"),
				ContainerUId = new Guid("e26865e6-a67d-4778-8d9b-d571e3c42a95"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UseCurrentActivePage",
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

		protected virtual void InitializeUserTaskOpenDateTimeValueEditPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a96a44ea-f7bb-43b3-9c1b-e664a9cd853d"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
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
				UId = new Guid("7b8a2d39-cc3e-4f37-8870-a493adc9c74e"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
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
				UId = new Guid("43d733e6-8316-45fa-b56b-42ee2f21b989"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
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
				UId = new Guid("98b0a883-b3df-42cf-a4a6-fbf18c054651"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b740ea2c-255e-4ca4-910e-e5382125a546"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("634d6aef-8739-4271-b0f7-dd0b5f5ff52b"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d79efb8a-8b96-4fe3-ba12-beb3db4958e5"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
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
				UId = new Guid("fc9a8b89-5384-4baa-9345-3d98e2752e3d"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("22bf874d-f08a-4d84-a8b4-96cdfcf1e69a"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
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
				UId = new Guid("7dd278c3-6a66-4741-9e72-51ff54dd774d"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1b5b11c9-393d-4b5a-86ae-b09bb5ec28db"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseCurrentActivePage",
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
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e875911e-b50e-4693-8e6c-8de827f40292"),
				ContainerUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLaneAddOperators = CreateLaneAddOperatorsLane();
			schemaLaneSet1.Lanes.Add(schemaLaneAddOperators);
			ProcessSchemaLane schemaLaneAddParentheses = CreateLaneAddParenthesesLane();
			schemaLaneSet1.Lanes.Add(schemaLaneAddParentheses);
			ProcessSchemaLane schemaLaneInit = CreateLaneInitLane();
			schemaLaneSet1.Lanes.Add(schemaLaneInit);
			ProcessSchemaLane schemaLanePageLoadComplete = CreateLanePageLoadCompleteLane();
			schemaLaneSet1.Lanes.Add(schemaLanePageLoadComplete);
			ProcessSchemaLane schemaAddParameterButtonClickLane = CreateAddParameterButtonClickLaneLane();
			schemaLaneSet1.Lanes.Add(schemaAddParameterButtonClickLane);
			ProcessSchemaLane schemaLaneFunction = CreateLaneFunctionLane();
			schemaLaneSet1.Lanes.Add(schemaLaneFunction);
			ProcessSchemaLane schemaLaneSysSettingsMenuItemClick = CreateLaneSysSettingsMenuItemClickLane();
			schemaLaneSet1.Lanes.Add(schemaLaneSysSettingsMenuItemClick);
			ProcessSchemaLane schemaLaneAddSysVariable = CreateLaneAddSysVariableLane();
			schemaLaneSet1.Lanes.Add(schemaLaneAddSysVariable);
			ProcessSchemaLane schemaLaneAddLookupValue = CreateLaneAddLookupValueLane();
			schemaLaneSet1.Lanes.Add(schemaLaneAddLookupValue);
			ProcessSchemaLane schemaLaneAddSamplingColumnValue = CreateLaneAddSamplingColumnValueLane();
			schemaLaneSet1.Lanes.Add(schemaLaneAddSamplingColumnValue);
			ProcessSchemaLane schemaLaneAddDateTimeValue = CreateLaneAddDateTimeValueLane();
			schemaLaneSet1.Lanes.Add(schemaLaneAddDateTimeValue);
			ProcessSchemaEventSubProcess eventsubprocessplusmenuitemclick = CreateEventSubProcessPlusMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessplusmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessparenthesesmenuitemclick = CreateEventSubProcessParenthesesMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessparenthesesmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessminusmenuitemclick = CreateEventSubProcessMinusMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessminusmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessmultiplymenuitemclick = CreateEventSubProcessMultiplyMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessmultiplymenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessdevidemenuitemclick = CreateEventSubProcessDevideMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessdevidemenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessinit = CreateEventSubProcessInitEventSubProcess();
			FlowElements.Add(eventsubprocessinit);
			ProcessSchemaEventSubProcess eventsubprocesspageloadcomplete = CreateEventSubProcessPageLoadCompleteEventSubProcess();
			FlowElements.Add(eventsubprocesspageloadcomplete);
			ProcessSchemaEventSubProcess addparameterbuttonclickeventsubprocess = CreateAddParameterButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(addparameterbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocessroundupmenuitemclick = CreateEventSubProcessRoundUpMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessroundupmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessroundmenuitemclick = CreateEventSubProcessRoundMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessroundmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessrounddownmenuitemclick = CreateEventSubProcessRoundDownMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessrounddownmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessmodmenuitemclick = CreateEventSubProcessModMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessmodmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessminmenuitemclick = CreateEventSubProcessMinMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessminmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessmaxmenuitemclick = CreateEventSubProcessMaxMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessmaxmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessabsmenuitemclick = CreateEventSubProcessAbsMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessabsmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessavgmenuitemclick = CreateEventSubProcessAvgMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessavgmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessdayitemclick = CreateEventSubProcessDayItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessdayitemclick);
			ProcessSchemaEventSubProcess eventsubprocessmonthitemclick = CreateEventSubProcessMonthItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessmonthitemclick);
			ProcessSchemaEventSubProcess eventsubprocessdayofweekitemclick = CreateEventSubProcessDayOfWeekItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessdayofweekitemclick);
			ProcessSchemaEventSubProcess eventsubprocesstimeitemclick = CreateEventSubProcessTimeItemClickEventSubProcess();
			FlowElements.Add(eventsubprocesstimeitemclick);
			ProcessSchemaEventSubProcess eventsubprocessdayinrangeitemclick = CreateEventSubProcessDayInRangeItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessdayinrangeitemclick);
			ProcessSchemaEventSubProcess eventsubprocesssyssettingsmenuitemclick = CreateEventSubProcessSysSettingsMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocesssyssettingsmenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocesssysvariablemenuitemclick = CreateEventSubProcessSysVariableMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocesssysvariablemenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocesslookupmenuitemclick = CreateEventSubProcessLookupMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocesslookupmenuitemclick);
			ProcessSchemaEventSubProcess closeinsertparameterwindoweventsubprocess = CreateCloseInsertParameterWindowEventSubProcessEventSubProcess();
			FlowElements.Add(closeinsertparameterwindoweventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocesssamplingcolumnvaluemenuitemclick = CreateEventSubProcessSamplingColumnValueMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocesssamplingcolumnvaluemenuitemclick);
			ProcessSchemaEventSubProcess eventsubprocessopendatetimevalueeditpage = CreateEventSubProcessOpenDateTimeValueEditPageEventSubProcess();
			FlowElements.Add(eventsubprocessopendatetimevalueeditpage);
			ProcessSchemaEventSubProcess eventsubprocessdatetimevalueeditpageclosed = CreateEventSubProcessDateTimeValueEditPageClosedEventSubProcess();
			FlowElements.Add(eventsubprocessdatetimevalueeditpageclosed);
			ProcessSchemaStartMessageEvent startmessageplusmenuitemclick = CreateStartMessagePlusMenuItemClickStartMessageEvent();
			eventsubprocessplusmenuitemclick.FlowElements.Add(startmessageplusmenuitemclick);
			ProcessSchemaScriptTask scripttaskplusmenuitemclick = CreateScriptTaskPlusMenuItemClickScriptTask();
			eventsubprocessplusmenuitemclick.FlowElements.Add(scripttaskplusmenuitemclick);
			ProcessSchemaStartMessageEvent startmessageparenthesesmenuitemclick = CreateStartMessageParenthesesMenuItemClickStartMessageEvent();
			eventsubprocessparenthesesmenuitemclick.FlowElements.Add(startmessageparenthesesmenuitemclick);
			ProcessSchemaScriptTask scripttaskparenthesesmenuitemclick = CreateScriptTaskParenthesesMenuItemClickScriptTask();
			eventsubprocessparenthesesmenuitemclick.FlowElements.Add(scripttaskparenthesesmenuitemclick);
			ProcessSchemaStartMessageEvent startmessageminusmenuitemclick = CreateStartMessageMinusMenuItemClickStartMessageEvent();
			eventsubprocessminusmenuitemclick.FlowElements.Add(startmessageminusmenuitemclick);
			ProcessSchemaScriptTask scripttaskminusmenuitemclick = CreateScriptTaskMinusMenuItemClickScriptTask();
			eventsubprocessminusmenuitemclick.FlowElements.Add(scripttaskminusmenuitemclick);
			ProcessSchemaStartMessageEvent startmessagemultiplymenuitemclick = CreateStartMessageMultiplyMenuItemClickStartMessageEvent();
			eventsubprocessmultiplymenuitemclick.FlowElements.Add(startmessagemultiplymenuitemclick);
			ProcessSchemaScriptTask scripttaskmultiplymenuitemclick = CreateScriptTaskMultiplyMenuItemClickScriptTask();
			eventsubprocessmultiplymenuitemclick.FlowElements.Add(scripttaskmultiplymenuitemclick);
			ProcessSchemaStartMessageEvent startmessagedevidemenuitemclick = CreateStartMessageDevideMenuItemClickStartMessageEvent();
			eventsubprocessdevidemenuitemclick.FlowElements.Add(startmessagedevidemenuitemclick);
			ProcessSchemaScriptTask scripttaskdevidemenuitemclick = CreateScriptTaskDevideMenuItemClickScriptTask();
			eventsubprocessdevidemenuitemclick.FlowElements.Add(scripttaskdevidemenuitemclick);
			ProcessSchemaScriptTask scripttaskinit = CreateScriptTaskInitScriptTask();
			eventsubprocessinit.FlowElements.Add(scripttaskinit);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocessinit.FlowElements.Add(initstartmessage);
			ProcessSchemaStartMessageEvent startmessagepageloadcomplete = CreateStartMessagePageLoadCompleteStartMessageEvent();
			eventsubprocesspageloadcomplete.FlowElements.Add(startmessagepageloadcomplete);
			ProcessSchemaScriptTask scripttaskpageloadcomplete = CreateScriptTaskPageLoadCompleteScriptTask();
			eventsubprocesspageloadcomplete.FlowElements.Add(scripttaskpageloadcomplete);
			ProcessSchemaStartMessageEvent insertparameterbuttonclickstartmessage = CreateInsertParameterButtonClickStartMessageStartMessageEvent();
			addparameterbuttonclickeventsubprocess.FlowElements.Add(insertparameterbuttonclickstartmessage);
			ProcessSchemaScriptTask insertparameterbuttonclickscripttask = CreateInsertParameterButtonClickScriptTaskScriptTask();
			addparameterbuttonclickeventsubprocess.FlowElements.Add(insertparameterbuttonclickscripttask);
			ProcessSchemaStartMessageEvent startmessageroundupmenuitemclick = CreateStartMessageRoundUpMenuItemClickStartMessageEvent();
			eventsubprocessroundupmenuitemclick.FlowElements.Add(startmessageroundupmenuitemclick);
			ProcessSchemaScriptTask scripttaskroundupmenuitemclick = CreateScriptTaskRoundUpMenuItemClickScriptTask();
			eventsubprocessroundupmenuitemclick.FlowElements.Add(scripttaskroundupmenuitemclick);
			ProcessSchemaStartMessageEvent startmessageroundmenuitemclick = CreateStartMessageRoundMenuItemClickStartMessageEvent();
			eventsubprocessroundmenuitemclick.FlowElements.Add(startmessageroundmenuitemclick);
			ProcessSchemaScriptTask scripttaskroundmenuitemclick = CreateScriptTaskRoundMenuItemClickScriptTask();
			eventsubprocessroundmenuitemclick.FlowElements.Add(scripttaskroundmenuitemclick);
			ProcessSchemaStartMessageEvent startmessagerounddownmenuitemclick = CreateStartMessageRoundDownMenuItemClickStartMessageEvent();
			eventsubprocessrounddownmenuitemclick.FlowElements.Add(startmessagerounddownmenuitemclick);
			ProcessSchemaScriptTask scripttaskrounddownmenuitemclick = CreateScriptTaskRoundDownMenuItemClickScriptTask();
			eventsubprocessrounddownmenuitemclick.FlowElements.Add(scripttaskrounddownmenuitemclick);
			ProcessSchemaStartMessageEvent startmessagemodmenuitemclick = CreateStartMessageModMenuItemClickStartMessageEvent();
			eventsubprocessmodmenuitemclick.FlowElements.Add(startmessagemodmenuitemclick);
			ProcessSchemaScriptTask scripttaskmodmenuitemclick = CreateScriptTaskModMenuItemClickScriptTask();
			eventsubprocessmodmenuitemclick.FlowElements.Add(scripttaskmodmenuitemclick);
			ProcessSchemaStartMessageEvent startmessageminmenuitemclick = CreateStartMessageMinMenuItemClickStartMessageEvent();
			eventsubprocessminmenuitemclick.FlowElements.Add(startmessageminmenuitemclick);
			ProcessSchemaScriptTask scripttaskminmenuitemclick = CreateScriptTaskMinMenuItemClickScriptTask();
			eventsubprocessminmenuitemclick.FlowElements.Add(scripttaskminmenuitemclick);
			ProcessSchemaStartMessageEvent startmessagemaxmenuitemclick = CreateStartMessageMaxMenuItemClickStartMessageEvent();
			eventsubprocessmaxmenuitemclick.FlowElements.Add(startmessagemaxmenuitemclick);
			ProcessSchemaScriptTask scripttaskmaxmenuitemclick = CreateScriptTaskMaxMenuItemClickScriptTask();
			eventsubprocessmaxmenuitemclick.FlowElements.Add(scripttaskmaxmenuitemclick);
			ProcessSchemaStartMessageEvent startmessageabsmenuitemclick = CreateStartMessageAbsMenuItemClickStartMessageEvent();
			eventsubprocessabsmenuitemclick.FlowElements.Add(startmessageabsmenuitemclick);
			ProcessSchemaScriptTask scripttaskabsmenuitemclick = CreateScriptTaskAbsMenuItemClickScriptTask();
			eventsubprocessabsmenuitemclick.FlowElements.Add(scripttaskabsmenuitemclick);
			ProcessSchemaStartMessageEvent startmessageavgmenuitemclick = CreateStartMessageAvgMenuItemClickStartMessageEvent();
			eventsubprocessavgmenuitemclick.FlowElements.Add(startmessageavgmenuitemclick);
			ProcessSchemaScriptTask scripttaskavgmenuitemclick = CreateScriptTaskAvgMenuItemClickScriptTask();
			eventsubprocessavgmenuitemclick.FlowElements.Add(scripttaskavgmenuitemclick);
			ProcessSchemaStartMessageEvent startmessagedayitemclick = CreateStartMessageDayItemClickStartMessageEvent();
			eventsubprocessdayitemclick.FlowElements.Add(startmessagedayitemclick);
			ProcessSchemaScriptTask scripttaskdayitemclick = CreateScriptTaskDayItemClickScriptTask();
			eventsubprocessdayitemclick.FlowElements.Add(scripttaskdayitemclick);
			ProcessSchemaStartMessageEvent startmessagemonthitemclick = CreateStartMessageMonthItemClickStartMessageEvent();
			eventsubprocessmonthitemclick.FlowElements.Add(startmessagemonthitemclick);
			ProcessSchemaScriptTask scripttaskmonthitemclick = CreateScriptTaskMonthItemClickScriptTask();
			eventsubprocessmonthitemclick.FlowElements.Add(scripttaskmonthitemclick);
			ProcessSchemaStartMessageEvent startmessagedayofweekitemclick = CreateStartMessageDayOfWeekItemClickStartMessageEvent();
			eventsubprocessdayofweekitemclick.FlowElements.Add(startmessagedayofweekitemclick);
			ProcessSchemaScriptTask scripttaskdayofweekitemclick = CreateScriptTaskDayOfWeekItemClickScriptTask();
			eventsubprocessdayofweekitemclick.FlowElements.Add(scripttaskdayofweekitemclick);
			ProcessSchemaStartMessageEvent startmessagetimeitemclick = CreateStartMessageTimeItemClickStartMessageEvent();
			eventsubprocesstimeitemclick.FlowElements.Add(startmessagetimeitemclick);
			ProcessSchemaScriptTask scripttasktimeitemclick = CreateScriptTaskTimeItemClickScriptTask();
			eventsubprocesstimeitemclick.FlowElements.Add(scripttasktimeitemclick);
			ProcessSchemaStartMessageEvent startmessagedayinrangeitemclick = CreateStartMessageDayInRangeItemClickStartMessageEvent();
			eventsubprocessdayinrangeitemclick.FlowElements.Add(startmessagedayinrangeitemclick);
			ProcessSchemaScriptTask scripttaskdayinrangeitemclick = CreateScriptTaskDayInRangeItemClickScriptTask();
			eventsubprocessdayinrangeitemclick.FlowElements.Add(scripttaskdayinrangeitemclick);
			ProcessSchemaStartMessageEvent startmessagesyssettingsmenuitemclick = CreateStartMessageSysSettingsMenuItemClickStartMessageEvent();
			eventsubprocesssyssettingsmenuitemclick.FlowElements.Add(startmessagesyssettingsmenuitemclick);
			ProcessSchemaScriptTask scripttasksyssettingsmenuitemclick = CreateScriptTaskSysSettingsMenuItemClickScriptTask();
			eventsubprocesssyssettingsmenuitemclick.FlowElements.Add(scripttasksyssettingsmenuitemclick);
			ProcessSchemaUserTask usertasksyssettingsmenuitemclick = CreateUserTaskSysSettingsMenuItemClickUserTask();
			eventsubprocesssyssettingsmenuitemclick.FlowElements.Add(usertasksyssettingsmenuitemclick);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageeventsyssettingspageclosed = CreateIntermediateCatchMessageEventSysSettingsPageClosedIntermediateCatchMessageEvent();
			eventsubprocesssyssettingsmenuitemclick.FlowElements.Add(intermediatecatchmessageeventsyssettingspageclosed);
			ProcessSchemaScriptTask scripttaskaddsyssettings = CreateScriptTaskAddSysSettingsScriptTask();
			eventsubprocesssyssettingsmenuitemclick.FlowElements.Add(scripttaskaddsyssettings);
			ProcessSchemaStartMessageEvent startmessagesysvariablemenuitemclick = CreateStartMessageSysVariableMenuItemClickStartMessageEvent();
			eventsubprocesssysvariablemenuitemclick.FlowElements.Add(startmessagesysvariablemenuitemclick);
			ProcessSchemaScriptTask scripttasksysvariablemenuitemclick = CreateScriptTaskSysVariableMenuItemClickScriptTask();
			eventsubprocesssysvariablemenuitemclick.FlowElements.Add(scripttasksysvariablemenuitemclick);
			ProcessSchemaStartMessageEvent startmessagelookupmenuitemclick = CreateStartMessageLookupMenuItemClickStartMessageEvent();
			eventsubprocesslookupmenuitemclick.FlowElements.Add(startmessagelookupmenuitemclick);
			ProcessSchemaScriptTask scripttasklookupmenuitemclick = CreateScriptTaskLookupMenuItemClickScriptTask();
			eventsubprocesslookupmenuitemclick.FlowElements.Add(scripttasklookupmenuitemclick);
			ProcessSchemaUserTask usertaskopenlookupgridpage = CreateUserTaskOpenLookupGridPageUserTask();
			eventsubprocesslookupmenuitemclick.FlowElements.Add(usertaskopenlookupgridpage);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageeventlookupgridpageclosed = CreateIntermediateCatchMessageEventLookupGridPageClosedIntermediateCatchMessageEvent();
			eventsubprocesslookupmenuitemclick.FlowElements.Add(intermediatecatchmessageeventlookupgridpageclosed);
			ProcessSchemaScriptTask scripttaskaddlookupvalue = CreateScriptTaskAddLookupValueScriptTask();
			eventsubprocesslookupmenuitemclick.FlowElements.Add(scripttaskaddlookupvalue);
			ProcessSchemaStartMessageEvent startmessagecloseinsertparameterwindow = CreateStartMessageCloseInsertParameterWindowStartMessageEvent();
			closeinsertparameterwindoweventsubprocess.FlowElements.Add(startmessagecloseinsertparameterwindow);
			ProcessSchemaScriptTask closeinsertparameterwindowscripttask = CreateCloseInsertParameterWindowScriptTaskScriptTask();
			closeinsertparameterwindoweventsubprocess.FlowElements.Add(closeinsertparameterwindowscripttask);
			ProcessSchemaStartMessageEvent startmessagesamplingcolumnvaluemenuitemclick = CreateStartMessageSamplingColumnValueMenuItemClickStartMessageEvent();
			eventsubprocesssamplingcolumnvaluemenuitemclick.FlowElements.Add(startmessagesamplingcolumnvaluemenuitemclick);
			ProcessSchemaScriptTask scripttasksamplingcolumnvaluemenuitemclick = CreateScriptTaskSamplingColumnValueMenuItemClickScriptTask();
			eventsubprocesssamplingcolumnvaluemenuitemclick.FlowElements.Add(scripttasksamplingcolumnvaluemenuitemclick);
			ProcessSchemaUserTask usertaskopendatetimevalueeditpage = CreateUserTaskOpenDateTimeValueEditPageUserTask();
			eventsubprocessopendatetimevalueeditpage.FlowElements.Add(usertaskopendatetimevalueeditpage);
			ProcessSchemaScriptTask scripttaskopendatetimevalueeditpage = CreateScriptTaskOpenDateTimeValueEditPageScriptTask();
			eventsubprocessopendatetimevalueeditpage.FlowElements.Add(scripttaskopendatetimevalueeditpage);
			ProcessSchemaScriptTask scripttaskdatetimemenuitemclick = CreateScriptTaskDateTimeMenuItemClickScriptTask();
			eventsubprocessopendatetimevalueeditpage.FlowElements.Add(scripttaskdatetimemenuitemclick);
			ProcessSchemaStartMessageEvent startmessagedatetimemenuitemclick = CreateStartMessageDateTimeMenuItemClickStartMessageEvent();
			eventsubprocessopendatetimevalueeditpage.FlowElements.Add(startmessagedatetimemenuitemclick);
			ProcessSchemaScriptTask scripttaskdatemenuitemclick = CreateScriptTaskDateMenuItemClickScriptTask();
			eventsubprocessopendatetimevalueeditpage.FlowElements.Add(scripttaskdatemenuitemclick);
			ProcessSchemaStartMessageEvent startmessagedatemenuitemclick = CreateStartMessageDateMenuItemClickStartMessageEvent();
			eventsubprocessopendatetimevalueeditpage.FlowElements.Add(startmessagedatemenuitemclick);
			ProcessSchemaScriptTask scripttasktimemenuitemclick = CreateScriptTaskTimeMenuItemClickScriptTask();
			eventsubprocessopendatetimevalueeditpage.FlowElements.Add(scripttasktimemenuitemclick);
			ProcessSchemaStartMessageEvent startmessagetimemenuitemclick = CreateStartMessageTimeMenuItemClickStartMessageEvent();
			eventsubprocessopendatetimevalueeditpage.FlowElements.Add(startmessagetimemenuitemclick);
			ProcessSchemaStartMessageEvent startmessagedatetimevalueeditpageclosed = CreateStartMessageDateTimeValueEditPageClosedStartMessageEvent();
			eventsubprocessdatetimevalueeditpageclosed.FlowElements.Add(startmessagedatetimevalueeditpageclosed);
			ProcessSchemaScriptTask scripttaskdatetimevalueeditpageclosed = CreateScriptTaskDateTimeValueEditPageClosedScriptTask();
			eventsubprocessdatetimevalueeditpageclosed.FlowElements.Add(scripttaskdatetimevalueeditpageclosed);
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
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29SequenceFlow());
			FlowElements.Add(CreateSequenceFlow30SequenceFlow());
			FlowElements.Add(CreateSequenceFlow31SequenceFlow());
			FlowElements.Add(CreateSequenceFlow32SequenceFlow());
			FlowElements.Add(CreateSequenceFlow33SequenceFlow());
			FlowElements.Add(CreateSequenceFlow34SequenceFlow());
			FlowElements.Add(CreateSequenceFlow35SequenceFlow());
			FlowElements.Add(CreateSequenceFlow37SequenceFlow());
			FlowElements.Add(CreateSequenceFlow36SequenceFlow());
			FlowElements.Add(CreateSequenceFlow38SequenceFlow());
			FlowElements.Add(CreateSequenceFlow39SequenceFlow());
			FlowElements.Add(CreateSequenceFlow40SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFunctionRoundUpLocalizableString());
			LocalizableStrings.Add(CreateFunctionRoundLocalizableString());
			LocalizableStrings.Add(CreateFunctionRoundDownLocalizableString());
			LocalizableStrings.Add(CreateFunctionModLocalizableString());
			LocalizableStrings.Add(CreateFunctionMinLocalizableString());
			LocalizableStrings.Add(CreateFunctionMaxLocalizableString());
			LocalizableStrings.Add(CreateFunctionAbsLocalizableString());
			LocalizableStrings.Add(CreateFunctionAvgLocalizableString());
			LocalizableStrings.Add(CreateSysSettingsDisplayPrefixLocalizableString());
			LocalizableStrings.Add(CreateSysVariableCaptionColumnLocalizableString());
			LocalizableStrings.Add(CreateSysVariableLookupGridPageCaptionLocalizableString());
			LocalizableStrings.Add(CreateSysVariableDisplayPrefixLocalizableString());
			LocalizableStrings.Add(CreateParameterNotFoundLocalizableString());
			LocalizableStrings.Add(CreateFunctionDayLocalizableString());
			LocalizableStrings.Add(CreateFunctionMonthLocalizableString());
			LocalizableStrings.Add(CreateFunctionTimeLocalizableString());
			LocalizableStrings.Add(CreateFunctionDayOfWeekLocalizableString());
			LocalizableStrings.Add(CreateFunctionDayInRangeLocalizableString());
			LocalizableStrings.Add(CreateLookupValueDisplayPrefixLocalizableString());
			LocalizableStrings.Add(CreateSamplingColumnValueDisplayPrefixLocalizableString());
			LocalizableStrings.Add(CreateDateValueDisplayPrefixLocalizableString());
			LocalizableStrings.Add(CreateTimeValueDisplayPrefixLocalizableString());
			LocalizableStrings.Add(CreateDateTimeValueDisplayPrefixLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFunctionRoundUpLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3d319db7-a6ae-4d4f-ae03-50a4f71febc0"),
				Name = "FunctionRoundUp",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionRoundLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("eab19e30-14c0-4d33-843d-5b1ebc951313"),
				Name = "FunctionRound",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionRoundDownLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f2863801-f186-4167-a3dd-ad6fa7e129bf"),
				Name = "FunctionRoundDown",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionModLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8551d735-cb0a-4c46-b66e-5c156d4fdd53"),
				Name = "FunctionMod",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionMinLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cc9d0314-9e7a-461d-bf6f-0d77124f2ed6"),
				Name = "FunctionMin",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionMaxLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("862b6409-45fc-40eb-9c6d-fb59bab5188a"),
				Name = "FunctionMax",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionAbsLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a3a5a5a3-bc2e-4c83-b27f-890b7561ee4e"),
				Name = "FunctionAbs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionAvgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9650e637-5211-41c5-9654-d3dd6fe9e767"),
				Name = "FunctionAvg",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSysSettingsDisplayPrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f183d3c2-f199-4ab0-a6d9-cfa466758bfc"),
				Name = "SysSettingsDisplayPrefix",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSysVariableCaptionColumnLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("83b82ccf-6aab-4f3a-96fa-f4fffa3d596e"),
				Name = "SysVariableCaptionColumn",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSysVariableLookupGridPageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("93c30ce9-05bf-4637-91a4-5a8421286158"),
				Name = "SysVariableLookupGridPageCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSysVariableDisplayPrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5d499f88-8ceb-4596-8460-600d8b40ff95"),
				Name = "SysVariableDisplayPrefix",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateParameterNotFoundLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("121a5939-bedf-4593-97e2-3442e20a53e3"),
				Name = "ParameterNotFound",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionDayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6c45d6c6-c7a1-43e7-af70-752b49ac91dd"),
				Name = "FunctionDay",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionMonthLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f0602192-fb90-4459-91af-c282d4c05258"),
				Name = "FunctionMonth",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionTimeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("53e23824-b8ee-40aa-91e8-599df6848120"),
				Name = "FunctionTime",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionDayOfWeekLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("31d5563b-af7f-47d4-bc2a-a1471853738d"),
				Name = "FunctionDayOfWeek",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFunctionDayInRangeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("64026d8c-c262-4f3f-8ef3-e7feea89881b"),
				Name = "FunctionDayInRange",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLookupValueDisplayPrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e5997d21-e027-4b70-8a51-34c316f72c6e"),
				Name = "LookupValueDisplayPrefix",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSamplingColumnValueDisplayPrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("595ce2c3-cc64-4210-bf76-a6ebf11603e2"),
				Name = "SamplingColumnValueDisplayPrefix",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateValueDisplayPrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("01680ffe-4dfa-49f8-83f4-889dfa9c7614"),
				Name = "DateValueDisplayPrefix",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTimeValueDisplayPrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c1d4a3ff-93b8-478f-9bd9-eb37786a4f19"),
				Name = "TimeValueDisplayPrefix",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateTimeValueDisplayPrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d91882fe-28a0-4930-ba18-b241783c2bd6"),
				Name = "DateTimeValueDisplayPrefix",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("7c39ad55-fbcd-4095-a417-806870474a21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7170a189-f16b-42af-95c5-7053732450f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97e05b5b-e119-4082-97f5-682c713362b5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("5f239c6f-3481-4e2c-8c4f-6d2ac02ac3db"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9a13f824-6df4-4291-b337-c248e23cd310"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7124fd00-95cf-4976-a05e-3eed82c308ec"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("a77728ce-3d5f-470f-97e0-eab3dd31c6d3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cb35ff3f-caaf-41a2-b99c-dfe106e093f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24899907-49c7-40c3-a7f0-e5c6773a272d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("b18ddd32-ae1e-473f-9177-bae9ff99d13a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8ce1b97d-ca5a-41cc-8a4e-0262dbdeacc0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d573162c-a01b-46dc-86d2-85453da8fef1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("2fc9fd68-cad1-4da7-9a9b-dae9e81afd17"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9697455b-7477-4c32-847f-27bff465e2c5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6ea38408-02ed-4788-9837-f72e6c329a8f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("6c371cf9-2393-442e-8de9-31299779930b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(178, 559),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2217f6a7-f22c-4d60-a750-f44a07577ab6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca348541-e13f-4e28-acd6-f7810dab8e9b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("4c40c94c-7eb4-4a78-a57e-e7dc28a6fa18"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(169, 722),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e65ae098-abe2-4b08-a38f-7284b59aece7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("975a8f09-6f48-412c-a4f7-c692a5e1853f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("106ddfd5-8135-4ac6-b4e9-947d9340705d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aa79ea3a-4d3d-4df9-8c9d-d1576063a196"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aafdfc6b-e9d7-4e81-8805-d3d34421915f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("ec245447-b996-4566-9fde-e0b75724cf68"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff4eb434-e5bc-40ae-af7c-ee0787bd0b37"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f3f11e06-54ab-4ad9-9996-364371e1946b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("14ce8382-6a3c-4507-bb53-32054450d7d9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f5227d1b-898c-4997-a840-685fb5900b71"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a044b7b8-3b76-4504-a69e-60855df9746a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("45d082b6-7da6-4e65-bf95-93bd34344812"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c234c060-a760-4f93-b347-e2c47073777a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b9d15d8-0a13-404d-9ec1-a16986d34798"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("1a591ffa-1837-4e00-ab6d-4a677675c92a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("70636e5b-525f-4a37-84f6-bf66a8cda0cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("354ae8c1-397b-4ca5-8776-11dc3881d01a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("6502bd8c-8895-4eac-964d-24c4aac2b43a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c1a1ea8b-6506-453c-bc5a-3fab97979239"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5709ee4b-1de2-45f5-bfd4-4996000bccf0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("df7546b2-d761-49d3-96bf-5b922839c462"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("37f8a883-b8b3-40cb-bcd6-2029769a9ea5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("19c002fe-9f8a-4cac-a572-bdd818394e7f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("6b4179e5-356c-4250-8b6e-795f36d68c9c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bc57e542-32f8-4b8e-8be1-25353a720232"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3dbdce4a-f8d0-4a6c-8c6b-d9434a6aaf2f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("2008ba5c-438b-4498-9787-e89711a5a91b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e6ff7e23-cb10-4576-9e3f-7522fcab5f42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7dd0d9e2-0d1c-4e7a-a4a4-2715fbd646d7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("25d84548-8254-424b-b3ce-0c17e16d78be"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd841e73-cef3-4db7-be8e-1902fe0246f2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e7f9b0df-9f89-447a-9281-4055d7f55f1c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("a32c087f-f4ea-4276-80db-b43187688b28"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("46bec8ad-5fb0-47db-8f1e-9585b298d11a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1fde018d-59ed-4cdb-b5d8-9283497a55d9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("13f121c2-341b-435f-be2a-f21677d317b3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("36aef9b3-89fd-4bf4-84ea-473c61dfa7af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("255ec44a-8563-4530-ae6a-a201a23da784"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("2d291197-b069-46ee-a404-eb742d2ff25f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f220011f-8312-430b-8322-3bd59fe8da3d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aad4d2af-7c89-4cca-a5d9-3d712d5af4b4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("1ead93fb-c71e-4efd-b7bb-33cf563d8026"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("23b4f3d4-94e1-4258-af01-28f38e14ff04"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eab49b20-41a6-4f92-8349-071af60ac682"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("f44b3714-b560-4174-8743-7525e1b12a38"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3287ab2a-376e-4814-b376-b107566aa68a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4fe5c619-e390-4b2b-a740-6edc8138d25f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("bb79e85b-af4a-4b35-b962-1ecbdab8a241"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(300, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4fe5c619-e390-4b2b-a740-6edc8138d25f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("106607bc-02df-4179-ba4a-e10938427966"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("59f08f8e-7fbb-40fc-be65-8c903fd3efe5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(430, 80),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("106607bc-02df-4179-ba4a-e10938427966"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd2c2e7c-7347-4339-bf4e-1b43f9cf7f1e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("06e52e10-bdc4-4321-b356-1efc3eb36155"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(526, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd2c2e7c-7347-4339-bf4e-1b43f9cf7f1e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("05d5ad74-b1ef-4c91-bb05-11735d568aec"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("7d4156cb-d7d9-4031-b615-383c772e30f4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(184, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("477adc5f-affa-45bf-b847-09f1539fce84"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5f58ca2c-fe46-47d3-9618-423843bf2dd7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow27",
				UId = new Guid("15d794a2-96af-4eab-a4e5-104fa1b470e9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7da5e975-7170-4a81-9015-1f75ed93199b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1f76f8d3-d062-4bd8-8e87-bf307d2e1711"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow28",
				UId = new Guid("5831472c-0f91-4a08-b11d-3866e0d83d45"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(300, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1f76f8d3-d062-4bd8-8e87-bf307d2e1711"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e26865e6-a67d-4778-8d9b-d571e3c42a95"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29",
				UId = new Guid("77f87c88-e86a-4380-8222-600eb8cc688b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(418, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e26865e6-a67d-4778-8d9b-d571e3c42a95"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0e3c5289-3f22-4ced-bb70-d9973aa40880"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow30SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow30",
				UId = new Guid("89f9f9f9-5baf-4bc7-8595-a19dbc4ee63e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(512, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0e3c5289-3f22-4ced-bb70-d9973aa40880"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c5818cdf-6967-42a2-bad4-ed170ac90d7c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow31SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow31",
				UId = new Guid("39c5aae1-e6e2-46be-8dab-9e91117662ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(448, 1352),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e23aa58b-bd47-4f92-8e55-533c6571cdf0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5988d7a5-881b-4feb-964d-b4478ceb7576"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow32SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow32",
				UId = new Guid("8ee00aa5-c4bb-4b30-b4ee-1b583cda5b7c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(173, 107),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0661ec0-addb-4f34-86ad-7151065f3fac"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c4091dc0-a79e-4ff9-af25-f9a2343e1568"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow33SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow33",
				UId = new Guid("d9714937-39e3-4ed7-b1d5-8716e2ffedf9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("168eb6d2-8650-4210-b99b-0ffee7af4fd5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60d9f842-9b8d-4ce8-b370-dc8740814f25"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow34SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow34",
				UId = new Guid("33506fa9-e043-4d76-a410-2274e685d0f9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fcecbf64-39b0-40e8-9234-cb22499b7328"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("42643fea-9a45-4baf-a895-aa56f04b5419"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow35SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow35",
				UId = new Guid("251a8090-2c87-41d3-b65e-c7081d9354dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b826f712-3ef9-4957-8181-03990ea6b17b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71cdbdec-dc9d-4563-8fcd-99f4b8e211ba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow37SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow37",
				UId = new Guid("266a260d-36e4-4521-8b07-9ed069303486"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(526, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("196b124e-fd4c-4cb0-9f15-801d74118448"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow36SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow36",
				UId = new Guid("d80548d3-94e4-4349-9d24-01e895dcfe78"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(439, 105),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71cdbdec-dc9d-4563-8fcd-99f4b8e211ba"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("196b124e-fd4c-4cb0-9f15-801d74118448"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow38SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow38",
				UId = new Guid("fdc53c95-38ad-42e9-b88e-2ebdb50a8ff6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(424, 162),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60d9f842-9b8d-4ce8-b370-dc8740814f25"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("196b124e-fd4c-4cb0-9f15-801d74118448"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow39SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow39",
				UId = new Guid("874e9c26-00ee-4176-88a1-91eb7640e0ce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(446, 226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42643fea-9a45-4baf-a895-aa56f04b5419"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("196b124e-fd4c-4cb0-9f15-801d74118448"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow40SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow40",
				UId = new Guid("666b1e0f-5584-40af-8610-3e8c85c7f92c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CurveCenterPosition = new Point(844, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef4c2fcf-183a-4e6c-b2df-a0264cb02157"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("afbb57a4-374a-4091-bb5a-a906c7b7d500"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1029, 1030),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLaneAddOperatorsLane() {
			ProcessSchemaLane schemaLaneAddOperators = new ProcessSchemaLane(this) {
				UId = new Guid("23acc5af-f6aa-4c7b-95f9-295aae7e00b0"),
				ContainerItemIndex = 9,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneAddOperators",
				Position = new Point(29, 816),
				Size = new Size(1000, 296),
				UseBackgroundMode = false
			};
			return schemaLaneAddOperators;
		}

		protected virtual ProcessSchemaLane CreateLaneAddParenthesesLane() {
			ProcessSchemaLane schemaLaneAddParentheses = new ProcessSchemaLane(this) {
				UId = new Guid("c3b71872-fc0b-46d2-8b55-7b993a717479"),
				ContainerItemIndex = 8,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneAddParentheses",
				Position = new Point(29, 787),
				Size = new Size(1000, 158),
				UseBackgroundMode = false
			};
			return schemaLaneAddParentheses;
		}

		protected virtual ProcessSchemaLane CreateLaneInitLane() {
			ProcessSchemaLane schemaLaneInit = new ProcessSchemaLane(this) {
				UId = new Guid("11f11a59-58ed-4196-9ae0-424f37129eb8"),
				ContainerItemIndex = 10,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 845),
				Size = new Size(1000, 160),
				UseBackgroundMode = false
			};
			return schemaLaneInit;
		}

		protected virtual ProcessSchemaLane CreateLanePageLoadCompleteLane() {
			ProcessSchemaLane schemaLanePageLoadComplete = new ProcessSchemaLane(this) {
				UId = new Guid("25080e39-97b3-42dd-93af-de5e485c7217"),
				ContainerItemIndex = 11,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LanePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 874),
				Size = new Size(1000, 156),
				UseBackgroundMode = false
			};
			return schemaLanePageLoadComplete;
		}

		protected virtual ProcessSchemaLane CreateAddParameterButtonClickLaneLane() {
			ProcessSchemaLane schemaAddParameterButtonClickLane = new ProcessSchemaLane(this) {
				UId = new Guid("f044712f-e692-4df2-84a9-0b1f0a830f36"),
				ContainerItemIndex = 7,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"AddParameterButtonClickLane",
				Position = new Point(29, 623),
				Size = new Size(1000, 159),
				UseBackgroundMode = false
			};
			return schemaAddParameterButtonClickLane;
		}

		protected virtual ProcessSchemaLane CreateLaneFunctionLane() {
			ProcessSchemaLane schemaLaneFunction = new ProcessSchemaLane(this) {
				UId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				ContainerItemIndex = 6,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneFunction",
				Position = new Point(29, 594),
				Size = new Size(1000, 738),
				UseBackgroundMode = false
			};
			return schemaLaneFunction;
		}

		protected virtual ProcessSchemaLane CreateLaneSysSettingsMenuItemClickLane() {
			ProcessSchemaLane schemaLaneSysSettingsMenuItemClick = new ProcessSchemaLane(this) {
				UId = new Guid("dca5e1a2-a59d-4c88-9e30-936b5eff777a"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneSysSettingsMenuItemClick",
				Position = new Point(29, 565),
				Size = new Size(1000, 171),
				UseBackgroundMode = false
			};
			return schemaLaneSysSettingsMenuItemClick;
		}

		protected virtual ProcessSchemaLane CreateLaneAddSysVariableLane() {
			ProcessSchemaLane schemaLaneAddSysVariable = new ProcessSchemaLane(this) {
				UId = new Guid("4aa7b7b0-b6d4-4839-b78a-c4b3fa0d8d2a"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneAddSysVariable",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 536),
				Size = new Size(1000, 172),
				UseBackgroundMode = false
			};
			return schemaLaneAddSysVariable;
		}

		protected virtual ProcessSchemaLane CreateLaneAddLookupValueLane() {
			ProcessSchemaLane schemaLaneAddLookupValue = new ProcessSchemaLane(this) {
				UId = new Guid("155ed40a-fa0e-4cb7-bc5d-169e9be99f97"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneAddLookupValue",
				Position = new Point(29, 507),
				Size = new Size(1000, 173),
				UseBackgroundMode = false
			};
			return schemaLaneAddLookupValue;
		}

		protected virtual ProcessSchemaLane CreateLaneAddSamplingColumnValueLane() {
			ProcessSchemaLane schemaLaneAddSamplingColumnValue = new ProcessSchemaLane(this) {
				UId = new Guid("c38b5923-8a38-4e0c-9402-a00a5b0ee8e0"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				IsExpanded = false,
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneAddSamplingColumnValue",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 478),
				Size = new Size(1000, 189),
				UseBackgroundMode = false
			};
			return schemaLaneAddSamplingColumnValue;
		}

		protected virtual ProcessSchemaLane CreateLaneAddDateTimeValueLane() {
			ProcessSchemaLane schemaLaneAddDateTimeValue = new ProcessSchemaLane(this) {
				UId = new Guid("336b063d-ee7f-4315-a2af-d6bd8e1776c2"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("1b8f45e0-9dbe-453b-86fe-eafe813240dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"LaneAddDateTimeValue",
				Position = new Point(29, 0),
				Size = new Size(1000, 473),
				UseBackgroundMode = false
			};
			return schemaLaneAddDateTimeValue;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPlusMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPlusMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0caf71d5-02fa-4130-a808-c1d07e65cd5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23acc5af-f6aa-4c7b-95f9-295aae7e00b0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessPlusMenuItemClick",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(250, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPlusMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePlusMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7170a189-f16b-42af-95c5-7053732450f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0caf71d5-02fa-4130-a808-c1d07e65cd5c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PlusMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessagePlusMenuItemClick",
				Position = new Point(36, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPlusMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("97e05b5b-e119-4082-97f5-682c713362b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0caf71d5-02fa-4130-a808-c1d07e65cd5c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskPlusMenuItemClick",
				Position = new Point(141, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,43,78,45,42,9,73,173,40,241,204,43,201,119,46,45,42,206,47,10,200,47,206,44,201,204,207,211,80,82,208,86,80,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,232,86,254,127,50,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessParenthesesMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessParenthesesMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eb7b022c-5caa-4ecb-99bc-daa5994a63f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c3b71872-fc0b-46d2-8b55-7b993a717479"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessParenthesesMenuItemClick",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(237, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessParenthesesMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageParenthesesMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9697455b-7477-4c32-847f-27bff465e2c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb7b022c-5caa-4ecb-99bc-daa5994a63f3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ParenthesesMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageParenthesesMenuItemClick",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskParenthesesMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6ea38408-02ed-4788-9837-f72e6c329a8f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eb7b022c-5caa-4ecb-99bc-daa5994a63f3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskParenthesesMenuItemClick",
				Position = new Point(141, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,80,210,168,54,168,213,84,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,215,17,244,165,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessMinusMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessMinusMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("aa64324b-d77d-4cda-a8f1-8fc0d723ec8e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23acc5af-f6aa-4c7b-95f9-295aae7e00b0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessMinusMenuItemClick",
				Position = new Point(294, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(248, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessMinusMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageMinusMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9a13f824-6df4-4291-b337-c248e23cd310"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa64324b-d77d-4cda-a8f1-8fc0d723ec8e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MinusMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageMinusMenuItemClick",
				Position = new Point(43, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskMinusMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7124fd00-95cf-4976-a05e-3eed82c308ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa64324b-d77d-4cda-a8f1-8fc0d723ec8e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskMinusMenuItemClick",
				Position = new Point(141, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,43,78,45,42,9,73,173,40,241,204,43,201,119,46,45,42,206,47,10,200,47,206,44,201,204,207,211,80,82,208,85,80,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,251,93,34,226,50,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessMultiplyMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessMultiplyMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("856b221b-c850-4b44-9886-e4d6cae316f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23acc5af-f6aa-4c7b-95f9-295aae7e00b0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessMultiplyMenuItemClick",
				Position = new Point(35, 147),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessMultiplyMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageMultiplyMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cb35ff3f-caaf-41a2-b99c-dfe106e093f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("856b221b-c850-4b44-9886-e4d6cae316f9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MultiplyMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageMultiplyMenuItemClick",
				Position = new Point(36, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskMultiplyMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("24899907-49c7-40c3-a7f0-e5c6773a272d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("856b221b-c850-4b44-9886-e4d6cae316f9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskMultiplyMenuItemClick",
				Position = new Point(141, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,43,78,45,42,9,73,173,40,241,204,43,201,119,46,45,42,206,47,10,200,47,206,44,201,204,207,211,80,82,208,82,80,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,176,214,28,168,50,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDevideMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDevideMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("64c00367-b08e-46a7-8f1b-dfe9b7a077fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23acc5af-f6aa-4c7b-95f9-295aae7e00b0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessDevideMenuItemClick",
				Position = new Point(294, 147),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(248, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDevideMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDevideMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8ce1b97d-ca5a-41cc-8a4e-0262dbdeacc0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64c00367-b08e-46a7-8f1b-dfe9b7a077fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DevideMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageDevideMenuItemClick",
				Position = new Point(43, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskDevideMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d573162c-a01b-46dc-86d2-85453da8fef1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64c00367-b08e-46a7-8f1b-dfe9b7a077fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskDevideMenuItemClick",
				Position = new Point(134, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,43,78,45,42,9,73,173,40,241,204,43,201,119,46,45,42,206,47,10,200,47,206,44,201,204,207,211,80,82,208,87,80,210,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,10,91,150,150,50,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b18d23b9-688c-4fd7-adc7-e4c9e17ccc9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11f11a59-58ed-4196-9ae0-424f37129eb8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 11),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(242, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInit;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ca348541-e13f-4e28-acd6-f7810dab8e9b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b18d23b9-688c-4fd7-adc7-e4c9e17ccc9e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,207,78,195,48,12,198,207,69,226,29,194,78,235,37,47,80,245,128,166,2,61,32,1,133,113,64,28,178,198,12,79,110,90,242,71,107,65,123,119,172,166,3,161,142,75,20,203,159,127,246,247,225,155,88,22,189,151,165,187,220,169,254,1,62,2,56,159,138,175,243,179,4,185,85,213,239,208,168,162,239,168,181,96,87,22,148,7,29,219,73,105,208,163,34,252,132,191,170,103,52,186,221,47,211,140,69,135,137,83,186,85,75,161,49,149,183,161,246,193,194,105,100,172,254,145,254,16,15,2,200,193,56,113,133,68,213,224,214,202,162,218,16,220,130,9,165,135,198,69,109,187,217,65,237,5,123,178,3,227,208,108,215,138,2,136,92,220,169,45,200,201,173,188,255,237,191,44,42,213,116,196,191,232,233,169,212,139,215,108,50,49,227,92,228,194,4,162,233,248,217,36,239,49,176,23,215,1,245,108,86,62,182,177,90,166,209,150,72,248,29,207,58,114,98,12,163,250,232,75,222,160,214,96,24,124,98,89,62,110,146,69,211,249,129,145,28,148,5,206,207,8,14,18,178,111,94,85,68,232,233,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2217f6a7-f22c-4d60-a750-f44a07577ab6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b18d23b9-688c-4fd7-adc7-e4c9e17ccc9e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b5f59f58-4b26-4f65-9cd8-f83d0bbb657e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("25080e39-97b3-42dd-93af-de5e485c7217"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e65ae098-abe2-4b08-a38f-7284b59aece7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5f59f58-4b26-4f65-9cd8-f83d0bbb657e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("975a8f09-6f48-412c-a4f7-c692a5e1853f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b5f59f58-4b26-4f65-9cd8-f83d0bbb657e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,73,12,72,44,74,204,45,118,201,76,46,201,204,207,75,44,170,84,176,85,200,75,45,87,64,8,216,20,151,20,101,230,165,235,40,64,104,59,13,77,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,67,72,147,16,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAddParameterButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAddParameterButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d4d95ba2-7a32-49ea-9d6b-c3d3ab38d5fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f044712f-e692-4df2-84a9-0b1f0a830f36"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"AddParameterButtonClickEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(251, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAddParameterButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInsertParameterButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("aa79ea3a-4d3d-4df9-8c9d-d1576063a196"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4d95ba2-7a32-49ea-9d6b-c3d3ab38d5fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"InsertParameterButtonClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"InsertParameterButtonClickStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInsertParameterButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aafdfc6b-e9d7-4e81-8805-d3d34421915f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4d95ba2-7a32-49ea-9d6b-c3d3ab38d5fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"InsertParameterButtonClickScriptTask",
				Position = new Point(141, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,139,219,48,16,189,23,250,31,132,47,113,192,136,182,215,80,104,154,205,210,20,118,27,234,108,123,9,44,138,53,142,85,108,201,72,227,77,90,227,255,222,145,237,164,177,179,75,161,244,98,240,124,188,121,239,105,164,149,86,168,68,174,126,65,156,100,80,136,229,177,204,141,5,251,93,105,105,14,225,116,246,250,213,147,176,204,13,146,236,61,27,86,51,225,250,72,140,182,74,176,178,112,74,245,0,165,53,9,56,215,21,81,255,45,225,223,128,83,123,13,114,125,153,107,71,58,180,74,239,89,38,180,204,219,113,93,128,47,139,18,127,94,229,191,66,10,22,116,2,247,162,128,63,197,183,198,22,2,195,224,208,74,225,245,155,230,113,41,21,46,76,81,230,128,176,22,150,202,17,108,16,141,228,241,69,174,64,227,234,230,172,126,71,168,26,14,44,110,145,63,86,42,151,96,59,166,59,62,47,75,208,50,12,210,74,39,168,140,14,19,147,87,133,94,233,212,76,89,189,213,193,168,206,35,42,74,18,230,242,136,188,66,149,243,207,241,151,123,46,33,49,18,46,219,103,195,222,147,34,146,194,29,224,55,145,87,16,122,40,78,66,196,90,96,70,29,17,91,139,61,240,79,74,74,32,20,7,22,207,82,55,112,68,239,193,64,225,21,124,111,216,6,172,21,206,164,200,231,63,196,241,14,48,51,210,241,77,102,205,161,107,95,62,209,39,156,16,155,73,196,38,245,219,102,210,142,167,153,40,232,52,30,86,50,10,22,185,113,48,98,209,237,214,216,150,166,13,92,28,249,142,111,76,103,120,56,202,12,206,247,131,183,131,162,52,159,134,63,183,18,231,168,135,105,205,137,19,171,74,188,19,154,126,44,159,75,217,5,194,209,230,168,148,133,245,187,134,78,177,102,222,243,74,135,219,128,230,108,131,200,135,103,172,105,94,94,158,136,5,64,86,39,253,186,189,192,109,250,87,78,255,200,221,243,53,35,190,255,133,236,8,161,39,210,95,189,193,53,63,229,184,79,94,119,198,153,57,248,101,236,159,154,97,171,95,158,193,173,247,163,45,208,203,162,25,61,49,48,251,13,61,58,162,153,185,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessRoundUpMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessRoundUpMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("512093bb-acb9-4741-9924-2dc841535b4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessRoundUpMenuItemClick",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessRoundUpMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageRoundUpMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ff4eb434-e5bc-40ae-af7c-ee0787bd0b37"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("512093bb-acb9-4741-9924-2dc841535b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RoundUpMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageRoundUpMenuItemClick",
				Position = new Point(21, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskRoundUpMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f3f11e06-54ab-4ad9-9996-364371e1946b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("512093bb-acb9-4741-9924-2dc841535b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskRoundUpMenuItemClick",
				Position = new Point(91, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,11,202,47,205,75,9,45,208,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,172,2,202,181,62,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessRoundMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessRoundMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c1b1f9bd-549c-4a53-bac8-632f2cbaf512"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessRoundMenuItemClick",
				Position = new Point(232, 13),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(206, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessRoundMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageRoundMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f5227d1b-898c-4997-a840-685fb5900b71"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1b1f9bd-549c-4a53-bac8-632f2cbaf512"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RoundMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageRoundMenuItemClick",
				Position = new Point(28, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskRoundMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a044b7b8-3b76-4504-a69e-60855df9746a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c1b1f9bd-549c-4a53-bac8-632f2cbaf512"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskRoundMenuItemClick",
				Position = new Point(105, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,11,202,47,205,75,209,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,126,249,201,137,60,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessRoundDownMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessRoundDownMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d455032b-8d09-433d-9903-ff5794604c4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessRoundDownMenuItemClick",
				Position = new Point(442, 13),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(199, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessRoundDownMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageRoundDownMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c234c060-a760-4f93-b347-e2c47073777a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d455032b-8d09-433d-9903-ff5794604c4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RoundDownMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageRoundDownMenuItemClick",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskRoundDownMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7b9d15d8-0a13-404d-9ec1-a16986d34798"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d455032b-8d09-433d-9903-ff5794604c4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskRoundDownMenuItemClick",
				Position = new Point(98, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,11,202,47,205,75,113,201,47,207,211,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,41,197,41,50,64,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessModMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessModMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6be7db61-749f-4c7f-b7c4-9a22bbf48771"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessModMenuItemClick",
				Position = new Point(36, 153),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(193, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessModMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageModMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("70636e5b-525f-4a37-84f6-bf66a8cda0cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6be7db61-749f-4c7f-b7c4-9a22bbf48771"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ModMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageModMenuItemClick",
				Position = new Point(21, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskModMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("354ae8c1-397b-4ca5-8776-11dc3881d01a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6be7db61-749f-4c7f-b7c4-9a22bbf48771"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskModMenuItemClick",
				Position = new Point(91, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,243,205,79,209,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,152,177,213,98,58,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessMinMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessMinMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9ebf3925-c6b5-45b9-b2d1-d9c35448a03e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessMinMenuItemClick",
				Position = new Point(231, 154),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(207, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessMinMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageMinMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c1a1ea8b-6506-453c-bc5a-3fab97979239"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ebf3925-c6b5-45b9-b2d1-d9c35448a03e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MinMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageMinMenuItemClick",
				Position = new Point(29, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskMinMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5709ee4b-1de2-45f5-bfd4-4996000bccf0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ebf3925-c6b5-45b9-b2d1-d9c35448a03e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskMinMenuItemClick",
				Position = new Point(106, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,243,205,204,211,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,211,115,112,253,58,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessMaxMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessMaxMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("72a41657-39ae-4b59-b5d6-948a0810ccaf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessMaxMenuItemClick",
				Position = new Point(441, 154),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(200, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessMaxMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageMaxMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("37f8a883-b8b3-40cb-bcd6-2029769a9ea5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("72a41657-39ae-4b59-b5d6-948a0810ccaf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MaxMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageMaxMenuItemClick",
				Position = new Point(29, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskMaxMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("19c002fe-9f8a-4cac-a572-bdd818394e7f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("72a41657-39ae-4b59-b5d6-948a0810ccaf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskMaxMenuItemClick",
				Position = new Point(99, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,243,77,172,208,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,239,105,79,77,58,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessAbsMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessAbsMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7b2d5546-a7c7-45a8-ad4e-c72451b9b089"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessAbsMenuItemClick",
				Position = new Point(35, 294),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(193, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessAbsMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAbsMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bc57e542-32f8-4b8e-8be1-25353a720232"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7b2d5546-a7c7-45a8-ad4e-c72451b9b089"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AbsMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageAbsMenuItemClick",
				Position = new Point(22, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskAbsMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3dbdce4a-f8d0-4a6c-8c6b-d9434a6aaf2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7b2d5546-a7c7-45a8-ad4e-c72451b9b089"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskAbsMenuItemClick",
				Position = new Point(92, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,115,76,42,214,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,109,127,195,46,58,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessAvgMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessAvgMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dd046fee-1dac-49b2-96b1-479472944fb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessAvgMenuItemClick",
				Position = new Point(232, 293),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(206, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessAvgMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAvgMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e6ff7e23-cb10-4576-9e3f-7522fcab5f42"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd046fee-1dac-49b2-96b1-479472944fb7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AvgMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageAvgMenuItemClick",
				Position = new Point(28, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskAvgMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7dd0d9e2-0d1c-4e7a-a4a4-2715fbd646d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd046fee-1dac-49b2-96b1-479472944fb7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskAvgMenuItemClick",
				Position = new Point(105, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,115,44,75,215,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,29,181,237,226,58,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDayItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDayItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4e639c74-1572-4eed-af7d-93628439fedb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessDayItemClick",
				Position = new Point(441, 294),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(200, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDayItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDayItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cd841e73-cef3-4db7-be8e-1902fe0246f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4e639c74-1572-4eed-af7d-93628439fedb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DayItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageDayItemClick",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskDayItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e7f9b0df-9f89-447a-9281-4055d7f55f1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4e639c74-1572-4eed-af7d-93628439fedb"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskDayItemClick",
				Position = new Point(99, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,115,73,172,212,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,251,105,236,72,58,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessMonthItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessMonthItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9c959d83-8e7a-475c-92d9-ad65f18297a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessMonthItemClick",
				Position = new Point(35, 434),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(193, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessMonthItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageMonthItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("46bec8ad-5fb0-47db-8f1e-9585b298d11a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9c959d83-8e7a-475c-92d9-ad65f18297a5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MonthItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageMonthItemClick",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskMonthItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1fde018d-59ed-4cdb-b5d8-9283497a55d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9c959d83-8e7a-475c-92d9-ad65f18297a5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskMonthItemClick",
				Position = new Point(92, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,243,205,207,43,201,208,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,62,80,73,38,60,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDayOfWeekItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDayOfWeekItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9ad3ef8c-fb4d-4a67-a383-6b84d113e6c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessDayOfWeekItemClick",
				Position = new Point(231, 434),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(207, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDayOfWeekItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDayOfWeekItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("36aef9b3-89fd-4bf4-84ea-473c61dfa7af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ad3ef8c-fb4d-4a67-a383-6b84d113e6c2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DayOfWeekItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageDayOfWeekItemClick",
				Position = new Point(22, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskDayOfWeekItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("255ec44a-8563-4530-ae6a-a201a23da784"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ad3ef8c-fb4d-4a67-a383-6b84d113e6c2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskDayOfWeekItemClick",
				Position = new Point(106, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,115,73,172,244,79,11,79,77,205,214,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,67,134,196,237,64,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessTimeItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessTimeItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("764ebf1b-85a2-4640-916e-56da921af811"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessTimeItemClick",
				Position = new Point(442, 433),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(199, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessTimeItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageTimeItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f220011f-8312-430b-8322-3bd59fe8da3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("764ebf1b-85a2-4640-916e-56da921af811"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TimeItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageTimeItemClick",
				Position = new Point(28, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskTimeItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aad4d2af-7c89-4cca-a5d9-3d712d5af4b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("764ebf1b-85a2-4640-916e-56da921af811"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskTimeItemClick",
				Position = new Point(98, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,11,201,204,77,213,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,56,233,7,161,59,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDayInRangeItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDayInRangeItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ff8b3527-e063-4ff5-8956-4e1eb3b6ffbf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b43c9ad-0fb6-4fb9-9f79-28e2aaeb2f3c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessDayInRangeItemClick",
				Position = new Point(35, 574),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(214, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDayInRangeItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDayInRangeItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("23b4f3d4-94e1-4258-af01-28f38e14ff04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff8b3527-e063-4ff5-8956-4e1eb3b6ffbf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DayInRangeItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageDayInRangeItemClick",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskDayInRangeItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eab49b20-41a6-4f92-8349-071af60ac682"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff8b3527-e063-4ff5-8956-4e1eb3b6ffbf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskDayInRangeItemClick",
				Position = new Point(106, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,206,201,47,78,13,78,205,73,77,46,73,77,9,73,173,40,209,112,43,205,75,46,201,204,207,115,73,172,244,204,11,74,204,75,79,213,11,201,15,46,41,202,204,75,215,208,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,111,193,244,234,65,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessSysSettingsMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessSysSettingsMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d06b181d-2be7-4f20-9df1-94b5335340b1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dca5e1a2-a59d-4c88-9e30-936b5eff777a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessSysSettingsMenuItemClick",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(598, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessSysSettingsMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageSysSettingsMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3287ab2a-376e-4814-b376-b107566aa68a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d06b181d-2be7-4f20-9df1-94b5335340b1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysSettingsMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageSysSettingsMenuItemClick",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSysSettingsMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4fe5c619-e390-4b2b-a740-6edc8138d25f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d06b181d-2be7-4f20-9df1-94b5335340b1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskSysSettingsMenuItemClick",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,193,74,196,48,16,134,207,22,250,14,67,79,93,44,121,129,85,65,118,61,20,89,41,180,197,115,54,157,93,227,182,137,206,76,148,178,244,221,77,43,232,226,201,203,64,146,249,191,239,15,11,89,119,4,235,88,180,51,88,118,112,11,121,222,32,145,102,127,16,213,150,234,25,247,27,239,132,124,207,170,210,71,92,205,67,221,243,219,114,80,229,79,84,53,190,94,112,249,106,157,38,45,35,53,154,79,245,200,53,138,196,107,222,161,11,165,224,176,233,173,57,169,138,188,65,230,71,28,163,243,162,192,53,44,130,121,204,94,109,29,146,106,157,125,15,88,110,255,5,142,201,74,147,30,80,144,56,194,29,126,194,214,26,177,222,105,26,225,134,151,150,5,248,253,43,26,185,131,115,154,92,157,33,99,243,130,131,126,138,185,172,128,236,2,159,193,84,124,175,152,192,226,163,198,51,118,15,31,232,228,207,230,82,122,121,253,205,12,161,23,91,99,31,85,59,223,205,236,131,238,25,97,74,147,41,126,135,80,2,57,16,10,184,254,2,185,9,3,19,142,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskSysSettingsMenuItemClickUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("106607bc-02df-4179-ba4a-e10938427966"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d06b181d-2be7-4f20-9df1-94b5335340b1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"UserTaskSysSettingsMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 37),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskSysSettingsMenuItemClickParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEventSysSettingsPageClosedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("cd2c2e7c-7347-4339-bf4e-1b43f9cf7f1e"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d06b181d-2be7-4f20-9df1-94b5335340b1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"SysSettingsPageClosed",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"IntermediateCatchMessageEventSysSettingsPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskAddSysSettingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("05d5ad74-b1ef-4c91-bb05-11735d568aec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d06b181d-2be7-4f20-9df1-94b5335340b1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskAddSysSettings",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(484, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,205,74,195,64,16,62,27,232,59,172,183,4,74,240,174,245,96,106,75,145,20,33,213,251,154,76,218,53,201,44,204,206,86,131,245,221,157,45,216,166,129,158,22,118,190,255,185,41,217,88,212,212,63,56,38,131,219,169,178,31,159,80,242,163,114,208,202,11,213,187,110,61,56,53,83,111,14,104,163,93,83,244,174,0,102,1,187,28,208,175,24,186,172,53,101,147,46,129,139,11,82,28,40,153,69,132,163,75,114,63,137,76,173,226,177,242,76,161,111,91,117,56,140,60,211,204,122,228,112,191,75,212,207,36,186,33,96,79,168,152,60,136,212,239,36,218,107,82,18,161,3,210,108,73,50,142,4,36,209,243,233,28,7,255,51,58,205,237,30,214,240,205,199,255,160,116,65,22,177,1,54,243,68,128,252,15,60,45,32,40,132,47,181,1,34,237,108,205,18,25,107,179,245,194,146,194,233,96,170,43,91,220,158,181,210,5,112,185,91,144,237,230,79,113,80,93,122,83,93,142,149,190,64,159,36,87,198,88,161,56,240,70,26,173,144,173,36,118,150,94,173,51,193,46,206,117,3,231,52,71,177,92,151,100,93,60,8,176,214,29,76,7,237,164,77,5,73,136,58,52,251,3,236,128,196,118,52,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessSysVariableMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessSysVariableMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ff421d35-dec8-404a-aa2e-0abc47d3722b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4aa7b7b0-b6d4-4839-b78a-c4b3fa0d8d2a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessSysVariableMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(251, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessSysVariableMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageSysVariableMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("477adc5f-affa-45bf-b847-09f1539fce84"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff421d35-dec8-404a-aa2e-0abc47d3722b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysVariableMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageSysVariableMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSysVariableMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5f58ca2c-fe46-47d3-9618-423843bf2dd7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff421d35-dec8-404a-aa2e-0abc47d3722b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskSysVariableMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,77,75,195,64,16,134,207,22,250,31,150,158,82,40,251,7,252,0,141,69,114,72,45,36,246,34,30,166,97,140,171,201,108,153,153,68,131,248,223,221,77,14,6,123,157,157,231,121,223,157,30,216,224,151,50,236,129,161,21,115,109,42,79,26,38,182,124,99,255,185,237,145,244,150,107,49,32,230,222,85,234,60,1,15,87,162,236,168,222,24,127,124,199,74,111,46,151,139,62,136,100,144,3,176,131,99,131,59,104,49,200,102,234,231,149,66,189,122,177,165,47,70,56,89,7,202,189,154,100,114,217,76,118,93,211,60,242,182,61,233,144,252,83,173,215,230,123,185,184,96,212,142,201,40,119,24,224,159,179,212,144,248,36,200,169,39,194,177,171,45,6,81,108,15,208,116,152,3,65,141,108,31,80,51,18,5,170,240,110,136,242,179,176,224,158,74,153,22,42,246,241,42,57,124,96,241,183,150,143,243,57,104,35,185,153,151,177,41,156,98,135,168,11,129,200,90,134,115,100,164,62,237,88,60,239,189,184,248,158,76,33,113,109,254,191,95,54,197,104,247,154,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessLookupMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessLookupMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e0c0de73-0335-4251-999b-13e0a7c5b8f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("155ed40a-fa0e-4cb7-bc5d-169e9be99f97"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessLookupMenuItemClick",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(569, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessLookupMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageLookupMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7da5e975-7170-4a81-9015-1f75ed93199b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0c0de73-0335-4251-999b-13e0a7c5b8f0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"LookupMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageLookupMenuItemClick",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskLookupMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1f76f8d3-d062-4bd8-8e87-bf307d2e1711"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0c0de73-0335-4251-999b-13e0a7c5b8f0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskLookupMenuItemClick",
				Position = new Point(119, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,221,74,195,64,16,133,175,13,228,29,150,94,37,80,242,2,181,130,191,165,90,48,88,115,37,94,172,187,167,237,218,100,55,204,78,212,40,190,187,155,98,47,154,168,120,59,204,119,190,51,76,225,65,247,210,111,111,107,216,133,115,219,166,158,145,209,185,92,35,203,201,41,120,127,131,86,76,133,114,150,241,198,251,97,54,183,158,165,85,40,230,122,18,71,47,146,68,29,152,92,146,172,192,32,31,16,139,87,113,97,20,27,103,37,181,226,216,51,25,187,30,11,247,244,12,197,39,73,26,192,67,40,59,213,58,25,109,140,198,89,195,236,172,31,141,5,83,131,244,91,225,72,131,160,207,93,89,98,151,27,44,51,240,29,86,97,28,202,44,213,6,149,92,24,207,191,134,211,112,55,72,174,189,179,217,18,100,100,105,222,145,12,60,105,23,103,86,34,233,169,194,245,98,26,58,52,70,103,151,85,205,109,42,62,226,232,232,39,177,223,3,65,55,200,207,174,12,117,165,31,250,253,186,253,199,78,254,41,80,122,252,43,125,216,113,23,16,71,197,31,191,238,63,239,80,18,120,2,55,100,119,239,152,124,1,156,57,129,141,53,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskOpenLookupGridPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e26865e6-a67d-4778-8d9b-d571e3c42a95"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0c0de73-0335-4251-999b-13e0a7c5b8f0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"UserTaskOpenLookupGridPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(245, 35),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskOpenLookupGridPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEventLookupGridPageClosedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("0e3c5289-3f22-4ced-bb70-d9973aa40880"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0c0de73-0335-4251-999b-13e0a7c5b8f0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"IntermediateCatchMessageEventLookupGridPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(371, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskAddLookupValueScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c5818cdf-6967-42a2-bad4-ed170ac90d7c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0c0de73-0335-4251-999b-13e0a7c5b8f0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskAddLookupValue",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(462, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,209,106,2,49,16,124,86,240,31,22,159,114,32,103,223,173,130,88,16,91,165,71,181,125,223,222,173,154,234,37,178,73,164,71,241,223,155,228,44,237,89,219,151,4,146,153,217,153,217,35,50,24,218,83,110,169,120,193,189,35,3,67,16,119,50,183,82,43,228,234,214,88,150,106,211,3,253,250,230,65,163,68,60,27,226,21,154,221,227,129,212,92,235,157,59,76,89,22,25,110,40,157,146,93,54,180,34,120,162,149,162,168,151,36,131,78,91,174,65,52,39,166,19,237,148,133,225,16,110,18,248,232,180,91,76,214,177,2,203,142,60,225,212,105,247,251,247,99,102,172,128,105,77,76,42,167,101,190,165,18,231,210,120,30,248,185,79,191,63,68,152,118,244,249,74,178,152,33,99,105,190,115,253,145,178,190,71,201,226,10,197,171,173,53,19,230,91,16,15,84,69,239,25,74,190,172,168,217,39,72,117,81,112,157,49,24,59,254,83,248,87,223,13,110,26,207,65,164,199,230,198,69,33,186,13,72,183,215,28,151,122,171,161,136,86,173,11,37,230,172,77,120,8,139,88,113,181,192,29,213,123,140,248,69,252,23,181,190,207,228,236,153,146,212,190,91,51,229,119,106,87,244,110,103,202,234,137,99,163,57,211,70,6,255,226,12,13,242,167,107,139,252,249,240,9,147,220,40,80,123,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCloseInsertParameterWindowEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCloseInsertParameterWindowEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("888b4b1b-bba7-4d7a-b9a9-3b87f4c9b9be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f044712f-e692-4df2-84a9-0b1f0a830f36"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"CloseInsertParameterWindowEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(294, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(279, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCloseInsertParameterWindowEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageCloseInsertParameterWindowStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e23aa58b-bd47-4f92-8e55-533c6571cdf0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("888b4b1b-bba7-4d7a-b9a9-3b87f4c9b9be"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CloseInsertParameterWindow",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageCloseInsertParameterWindow",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCloseInsertParameterWindowScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5988d7a5-881b-4feb-964d-b4478ceb7576"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("888b4b1b-bba7-4d7a-b9a9-3b87f4c9b9be"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"CloseInsertParameterWindowScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,209,74,3,49,16,69,159,93,216,127,136,111,9,148,253,129,170,160,91,177,165,44,4,244,7,134,102,172,131,221,164,76,102,139,65,252,119,179,141,197,46,236,83,114,39,55,247,204,76,20,38,191,87,17,249,132,220,161,128,5,249,80,247,234,5,197,114,56,34,75,122,157,188,61,165,246,64,232,229,162,181,133,61,54,107,114,14,253,198,231,28,177,192,208,163,32,191,225,151,60,59,146,102,188,152,101,93,197,2,235,97,199,33,102,72,7,159,216,157,133,190,226,173,40,30,15,144,10,108,10,215,211,62,205,24,122,2,86,253,185,144,177,113,69,59,161,224,129,83,206,215,255,234,174,176,23,170,156,15,166,155,249,146,211,232,93,233,219,185,184,166,13,94,128,124,220,98,210,101,2,99,212,119,93,221,204,186,31,157,251,115,45,174,199,156,233,255,167,174,202,222,198,45,109,188,132,118,224,24,216,134,72,99,216,133,149,157,140,50,176,87,194,3,46,127,1,236,246,210,240,184,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessSamplingColumnValueMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessSamplingColumnValueMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4ad52082-8546-4e7e-bc50-4ca6bdfb1eb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c38b5923-8a38-4e0c-9402-a00a5b0ee8e0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessSamplingColumnValueMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 161),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessSamplingColumnValueMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageSamplingColumnValueMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b0661ec0-addb-4f34-86ad-7151065f3fac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ad52082-8546-4e7e-bc50-4ca6bdfb1eb7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SamplingColumnValueMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageSamplingColumnValueMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSamplingColumnValueMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c4091dc0-a79e-4ff9-af25-f9a2343e1568"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ad52082-8546-4e7e-bc50-4ca6bdfb1eb7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskSamplingColumnValueMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,206,200,47,119,206,207,41,205,205,11,46,41,42,77,46,41,45,74,117,173,40,200,201,47,74,45,114,77,201,44,9,207,204,75,201,47,215,8,78,204,45,200,201,204,75,15,78,206,72,205,77,12,245,76,209,81,64,21,130,24,225,146,88,146,24,150,152,83,154,26,82,89,144,10,84,165,105,205,203,85,148,10,52,51,79,1,104,120,170,53,0,40,47,235,8,109,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessOpenDateTimeValueEditPageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessOpenDateTimeValueEditPage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("336b063d-ee7f-4315-a2af-d6bd8e1776c2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessOpenDateTimeValueEditPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(657, 312),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessOpenDateTimeValueEditPage;
		}

		protected virtual ProcessSchemaUserTask CreateUserTaskOpenDateTimeValueEditPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("50a7f0ba-6819-4d5d-ace4-79dbe45fd8f5"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"UserTaskOpenDateTimeValueEditPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(546, 119),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserTaskOpenDateTimeValueEditPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskOpenDateTimeValueEditPageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("196b124e-fd4c-4cb0-9f15-801d74118448"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskOpenDateTimeValueEditPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(399, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,111,75,195,48,16,198,95,91,232,119,8,121,181,65,235,82,217,230,198,84,208,166,74,25,226,192,213,247,161,57,70,112,75,245,146,78,203,232,119,95,255,76,84,168,216,55,9,119,249,229,185,231,238,18,3,184,22,230,245,233,13,52,23,22,214,106,7,47,98,155,67,36,149,93,137,13,156,215,47,128,177,54,86,232,20,98,73,174,201,87,144,196,114,225,58,201,191,18,21,17,230,136,160,237,109,106,213,30,234,100,37,99,49,135,94,255,235,35,105,42,107,248,32,15,185,146,3,202,217,69,56,225,151,220,143,166,243,192,31,51,198,252,57,11,66,127,54,190,139,102,108,58,185,143,2,70,135,11,50,26,117,106,246,116,30,110,51,3,143,96,76,235,152,118,82,13,36,105,37,184,23,72,222,115,192,226,217,162,210,155,149,64,177,3,11,104,78,214,185,170,250,207,180,192,226,202,52,132,71,218,251,102,48,36,7,215,57,59,16,42,79,37,150,74,75,234,17,254,35,36,165,215,50,105,166,45,124,218,37,20,21,241,135,169,111,132,148,174,83,246,30,244,47,211,157,205,84,82,8,54,71,221,110,240,8,81,105,81,168,67,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskDateTimeMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("71cdbdec-dc9d-4563-8fcd-99f4b8e211ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskDateTimeMenuItemClick",
				Position = new Point(232, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,44,73,13,201,204,77,245,206,204,75,81,176,85,80,114,129,242,149,172,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,205,215,74,196,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDateTimeMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b826f712-3ef9-4957-8181-03990ea6b17b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DateTimeMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageDateTimeMenuItemClick",
				Position = new Point(43, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskDateMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("60d9f842-9b8d-4ce8-b370-dc8740814f25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskDateMenuItemClick",
				Position = new Point(231, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,44,73,13,201,204,77,245,206,204,75,81,176,85,80,114,1,242,149,172,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,37,192,157,162,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDateMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("168eb6d2-8650-4210-b99b-0ffee7af4fd5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DateMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageDateMenuItemClick",
				Position = new Point(42, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskTimeMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("42643fea-9a45-4baf-a895-aa56f04b5419"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskTimeMenuItemClick",
				Position = new Point(232, 226),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,44,73,13,201,204,77,245,206,204,75,81,176,85,80,2,177,149,172,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,112,50,90,157,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageTimeMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fcecbf64-39b0-40e8-9234-cb22499b7328"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("feed8880-81c9-4147-98e3-1de1fb5662ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TimeMenuItemClick",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageTimeMenuItemClick",
				Position = new Point(43, 240),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDateTimeValueEditPageClosedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDateTimeValueEditPageClosed = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5e4e5543-fed7-4df7-8793-e7bdbe6dfa56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("336b063d-ee7f-4315-a2af-d6bd8e1776c2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"EventSubProcessDateTimeValueEditPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 329),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(258, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDateTimeValueEditPageClosed;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDateTimeValueEditPageClosedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ef4c2fcf-183a-4e6c-b2df-a0264cb02157"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5e4e5543-fed7-4df7-8793-e7bdbe6dfa56"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DateTimeValueEditPageClosed",
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"StartMessageDateTimeValueEditPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskDateTimeValueEditPageClosedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("afbb57a4-374a-4091-bb5a-a906c7b7d500"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5e4e5543-fed7-4df7-8793-e7bdbe6dfa56"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Name = @"ScriptTaskDateTimeValueEditPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,143,65,11,130,64,16,133,207,9,254,135,193,147,11,209,31,8,79,218,65,68,16,178,46,209,97,211,41,182,108,23,118,103,163,136,254,123,19,161,104,215,78,3,243,222,124,111,158,57,156,177,33,104,37,97,173,174,184,149,157,71,72,96,227,208,166,70,107,214,148,209,139,53,58,199,51,147,36,119,81,54,246,174,90,69,149,60,33,155,9,239,84,224,35,218,47,195,64,29,33,254,97,38,160,125,215,9,120,134,193,204,34,121,171,129,172,71,54,191,194,224,175,60,248,162,153,116,147,118,168,194,219,184,63,21,147,95,216,152,107,14,164,154,9,185,38,147,122,235,140,173,140,83,159,244,184,148,23,156,132,150,178,177,198,13,133,230,208,171,133,210,173,16,204,27,23,122,3,251,78,224,204,83,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetPropertyDisplayPathByServerMetaPathMethod());
			Methods.Add(CreateInsertTextIntoCursorPositionMethod());
			Methods.Add(CreateMakeMacrosMethod());
			Methods.Add(CreateEncloseSelectedTextMethod());
			Methods.Add(CreateConvertDisplayCodeToFormulaTaskBodyMethod());
			Methods.Add(CreateConvertFormulaTaskBodyToDisplayCodeMethod());
			Methods.Add(CreateConvertFunctionCodeToMacroMethod());
			Methods.Add(CreateConvertFunctionMacroToCodeMethod());
			Methods.Add(CreateGetPropertyServerMetaPathByClientMetaPathMethod());
			Methods.Add(CreateGetSysVariableVDSStructureMethod());
			Methods.Add(CreateFillSysVariableMenuItemsMethod());
			Methods.Add(CreateFindDesignedProcessSchemaMethod());
			Methods.Add(CreateSetFormulaBodyMethod());
			Methods.Add(CreateGetFormulaBodyMethod());
			Methods.Add(CreateGetReferenceSchemaListMethod());
			Methods.Add(CreateInitializeSchemaExplorerWindowMethod());
			Methods.Add(CreateCreateColumnStructureExplorerMethod());
			Methods.Add(CreateColumnStructureExplorer_EditCompleteMethod());
			Methods.Add(CreateShowColumnStructureExplorerEditWindowMethod());
			Methods.Add(CreateMakeDateTimeValueMacrosMethod());
			Methods.Add(CreateTryMakeLookupValueMacrosMethod());
			Methods.Add(CreateMakeSysVariableMacrosMethod());
			Methods.Add(CreateMakeSysSettingValueMacrosMethod());
			Methods.Add(CreateGetReferenceEntitySchemasMethod());
			Methods.Add(CreateGetPackageUIdMethod());
			Methods.Add(CreateClearFormulaBodyMethod());
			Methods.Add(CreateGetFunctionNameMacrosMapMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3787b44f-a0fd-42ce-8455-b244a473f502"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("df4ac943-13a5-4b85-9dc5-4feef1920016"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("727d8df2-63a4-48d8-bd77-1ad32ca4e068"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d79343b4-1a4d-416e-bc5a-f717157c18cf"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1e4c3ac1-4ebc-40dc-a596-7b249407a54d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6ad98208-9173-4452-b7d8-7ddf13f6ad00"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4cfeedc1-9960-4c7d-8696-b26e3d8742d9"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("faac8f82-ef37-48db-97c2-5358968aa521"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a3d1f853-8ee8-415d-bb53-6fb5b00ba2dc"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c719eac-f57d-4e18-9839-14be13b2d4f5"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3c0f4952-9098-4f9b-8e33-ac821f34737e"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("568a5dd3-ca8b-4c5e-baa6-5708bd17ad12")
			});
		}

		protected virtual SchemaMethod CreateGetPropertyDisplayPathByServerMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ce000ff4-72e9-4119-8700-8db7616c4e87"),
				Name = "GetPropertyDisplayPathByServerMetaPath",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0aa45c26-331b-409d-ba4c-f5d976652f49"),
				Name = "serverMetaPath",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,177,10,131,64,16,68,251,64,254,225,202,19,196,31,8,105,146,16,43,229,32,228,3,150,115,80,11,87,217,91,21,255,62,103,33,201,145,110,135,153,217,55,78,70,143,16,94,190,195,64,102,74,212,213,60,123,110,30,8,125,203,104,220,175,103,179,203,249,180,144,152,22,12,33,29,37,166,25,171,73,82,229,97,214,88,237,59,64,238,35,51,188,246,35,231,41,171,72,122,21,49,181,144,162,166,1,97,34,143,157,38,208,89,248,11,44,74,104,108,77,16,221,28,105,119,219,42,40,237,151,253,27,226,72,226,43,133,216,132,154,229,38,142,90,32,71,51,55,42,115,164,125,0,151,125,16,47,22,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInsertTextIntoCursorPositionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("110b6642-e00e-4bb8-99bd-32e511923db1"),
				Name = "InsertTextIntoCursorPosition",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f0efbb8f-1158-4dc3-baf4-7cd834a44fa4"),
				Name = "text",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,78,46,202,44,40,241,77,204,3,114,138,244,28,83,82,32,2,26,197,37,69,153,121,233,122,110,249,69,185,137,37,26,74,213,6,181,122,153,121,197,169,69,37,33,169,21,37,110,69,137,233,185,169,121,37,26,49,74,213,134,181,49,74,154,214,74,58,188,92,156,1,32,3,195,18,115,74,83,125,83,115,243,93,83,50,75,244,156,115,50,129,234,60,93,116,20,74,128,250,244,130,82,11,114,18,147,83,53,148,98,148,148,116,20,148,98,98,128,180,166,166,166,53,0,45,128,13,165,139,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMakeMacrosMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("69c3890b-22d0-4f7a-91a5-2d4fd438598c"),
				Name = "MakeMacros",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("90c7de33-4b15-4e93-b121-1806cadd8ebb"),
				Name = "item",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,206,207,75,78,44,209,240,73,77,43,241,77,76,46,202,47,118,42,74,76,206,78,45,209,81,200,44,73,205,213,81,8,202,76,207,64,149,209,180,6,0,73,15,160,20,66,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEncloseSelectedTextMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("df3993cb-2dd2-4e7e-8c25-2cc0b7684f8d"),
				Name = "EncloseSelectedText",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c467f973-0aa1-4c1d-b3ee-76e9189034ea"),
				Name = "pattern",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,203,10,194,48,16,69,215,246,43,66,86,13,132,160,110,139,11,241,1,130,197,98,197,149,155,208,76,107,32,77,203,116,4,161,244,223,141,45,168,184,187,115,56,115,153,233,8,173,175,152,131,146,50,141,196,86,172,213,68,128,94,29,3,58,149,49,239,231,3,23,73,212,77,34,218,234,254,111,158,223,236,71,205,116,5,42,47,208,182,148,106,31,6,84,107,99,38,16,79,61,106,223,96,173,105,92,81,224,11,215,116,144,131,131,130,192,92,224,73,241,141,247,139,225,198,37,11,97,25,130,72,184,140,102,99,243,85,187,7,164,80,55,59,99,73,109,156,5,79,135,173,252,252,32,191,71,10,145,188,0,138,76,230,155,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateConvertDisplayCodeToFormulaTaskBodyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2328ad29-dad4-463e-b07a-588b81968925"),
				Name = "ConvertDisplayCodeToFormulaTaskBody",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("269c368c-aba8-40e2-8dc2-3fa2a3a87984"),
				Name = "code",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,209,74,195,48,20,134,175,55,216,59,28,122,149,98,233,11,76,69,233,54,17,233,148,49,189,207,186,211,173,208,230,148,36,157,22,241,221,77,154,46,117,48,65,230,85,211,243,247,255,78,254,147,180,200,129,41,45,11,177,139,31,213,178,41,203,103,57,175,106,221,178,140,182,24,134,240,57,25,143,36,234,70,10,176,149,233,100,252,53,25,59,3,108,104,219,194,77,87,143,87,88,151,60,67,182,70,41,185,162,92,39,84,85,36,150,188,66,85,27,33,130,32,8,141,187,247,36,36,14,40,245,162,17,153,46,72,164,60,147,180,166,196,144,152,253,34,130,163,178,162,70,108,95,235,8,238,130,148,235,125,156,96,81,154,222,236,114,152,71,117,111,255,0,205,232,93,120,216,162,36,146,151,193,238,55,202,99,204,218,65,102,69,167,113,217,94,187,105,71,224,158,183,144,247,62,59,219,142,170,82,94,155,134,15,232,155,157,72,204,242,114,146,200,179,61,59,112,9,194,171,80,136,243,56,119,240,253,57,235,182,70,171,154,30,131,53,126,194,22,174,32,96,129,161,143,254,154,249,135,255,141,151,141,185,22,71,120,232,174,150,221,95,133,154,191,112,201,43,53,76,193,192,217,239,51,9,211,51,150,33,53,176,19,172,77,125,174,135,11,221,71,89,225,14,63,252,181,118,187,119,181,185,202,120,141,204,19,236,36,194,104,32,186,100,125,158,254,223,177,254,233,55,250,181,162,119,108,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateConvertFormulaTaskBodyToDisplayCodeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6516e00a-b633-40b8-adb2-e48e84abd2b1"),
				Name = "ConvertFormulaTaskBodyToDisplayCode",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e20d1e4b-9583-4786-9b67-3006755ed7f0"),
				Name = "body",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,88,77,111,219,56,16,61,39,64,254,3,227,19,133,26,2,118,11,108,15,217,110,55,118,226,32,216,184,107,196,78,115,104,246,192,88,180,77,68,34,5,146,106,109,20,249,239,59,252,144,68,217,146,146,166,23,59,38,103,222,204,188,153,33,57,97,43,132,149,150,140,175,227,107,245,185,72,211,127,229,101,150,235,29,126,20,201,46,138,208,143,147,227,35,73,117,33,57,50,43,103,39,199,207,39,199,78,1,45,69,66,209,71,187,30,223,210,60,37,75,138,23,84,74,162,196,74,143,69,150,9,254,153,100,84,229,176,49,68,131,65,4,218,94,103,44,248,55,42,245,164,224,75,205,4,31,195,234,66,76,201,82,10,108,36,134,168,220,185,21,5,79,238,242,33,250,123,48,37,122,243,16,143,41,75,193,248,3,126,59,92,13,102,127,254,10,212,133,248,206,107,184,73,42,132,124,35,220,249,163,170,129,224,135,135,185,96,118,151,200,221,159,142,245,33,114,223,127,161,149,215,52,28,91,68,53,37,57,152,188,162,149,185,198,22,54,120,43,33,41,89,110,240,55,34,17,175,118,17,227,237,112,174,0,124,190,245,46,167,102,23,108,212,170,241,63,180,206,254,32,30,152,32,30,226,65,132,222,153,63,240,0,108,30,189,150,139,0,245,11,73,139,230,10,216,137,92,249,25,223,51,170,201,140,72,146,169,154,33,48,129,187,249,138,166,45,42,103,14,77,110,77,76,244,59,186,165,107,186,197,246,51,190,84,75,146,83,124,67,87,218,185,48,146,100,249,68,181,9,109,128,227,119,159,162,1,252,213,144,189,101,235,205,158,112,64,58,194,144,93,248,202,236,39,80,46,183,177,93,161,202,18,16,69,39,199,134,110,6,61,105,101,226,43,41,138,92,197,99,40,53,141,78,63,162,223,93,62,128,80,174,25,47,168,33,23,8,57,210,16,188,221,240,153,202,156,11,208,152,16,87,8,245,245,183,255,28,181,103,7,210,149,228,193,126,194,20,164,119,183,160,91,109,133,140,180,221,119,142,150,166,226,185,38,82,171,123,166,55,120,190,83,95,136,100,228,49,165,51,73,87,108,235,143,146,10,83,213,2,190,164,66,160,226,209,137,29,226,196,55,148,175,245,38,178,246,143,76,238,2,36,64,185,83,84,66,157,113,106,51,28,131,190,166,153,141,104,74,56,89,83,25,67,123,92,115,165,9,95,210,209,206,216,198,123,190,120,236,102,212,83,242,228,11,49,244,233,194,201,120,215,22,98,238,188,54,21,18,128,198,99,146,27,111,28,240,51,162,169,162,168,151,187,57,213,144,223,181,234,228,174,20,24,187,206,234,226,174,137,211,202,93,41,226,27,160,58,191,161,232,248,138,173,11,73,74,34,75,73,220,228,216,195,153,120,78,3,188,120,66,161,152,38,82,100,23,35,60,48,126,194,209,176,231,121,21,88,163,160,143,108,73,247,39,160,68,233,79,64,229,75,157,214,23,217,191,17,226,169,200,109,197,116,176,15,253,154,145,187,235,164,139,247,3,4,207,251,16,189,255,195,147,117,85,176,4,165,86,206,1,25,234,205,34,254,41,68,136,242,253,135,200,99,94,2,131,122,55,183,222,33,26,254,56,232,138,80,180,108,139,9,227,73,221,23,224,21,174,124,170,34,142,130,92,55,45,64,4,240,118,232,77,103,131,62,223,243,33,72,217,37,181,137,214,119,73,173,95,87,79,55,166,89,11,157,112,145,123,234,61,239,110,173,189,170,157,96,12,123,231,73,198,184,61,223,77,171,172,8,84,81,67,164,226,58,180,31,180,134,23,11,187,162,42,128,55,246,129,231,7,156,94,18,29,22,73,87,87,12,3,246,225,65,102,46,107,239,214,76,178,12,174,67,175,56,22,105,145,113,11,21,189,246,208,34,89,110,222,101,129,106,95,251,56,49,119,35,67,29,119,157,96,93,160,205,147,236,23,43,191,113,33,152,194,47,205,206,171,186,63,235,138,192,123,223,168,57,192,155,239,137,140,118,101,168,184,45,254,110,252,9,84,190,239,139,23,204,4,146,163,221,129,165,192,74,247,177,122,200,118,223,241,218,110,251,149,229,114,65,52,237,41,146,4,182,187,138,98,79,181,89,10,157,193,85,90,61,33,25,171,175,244,127,193,178,62,255,53,235,126,210,236,169,190,210,255,74,171,199,127,99,245,39,248,127,33,134,196,139,244,229,225,109,177,52,52,95,200,199,98,63,166,31,253,216,208,21,51,41,114,24,51,202,195,204,245,223,156,74,152,61,170,46,172,35,42,15,184,242,61,123,218,54,89,152,51,86,19,198,21,12,33,56,176,93,113,214,170,116,158,36,161,240,208,243,88,27,124,70,75,59,10,224,203,237,146,186,38,167,91,15,233,222,83,109,55,224,148,42,5,7,215,140,112,154,142,83,6,135,66,112,131,216,217,200,220,108,245,67,238,238,58,190,167,143,38,2,41,82,21,207,64,215,222,246,227,13,75,19,191,60,218,149,72,216,238,155,15,31,51,156,144,16,25,236,249,175,33,106,117,192,221,95,68,53,118,235,251,15,124,58,221,123,36,100,185,97,200,139,155,39,162,155,14,133,204,138,148,44,136,122,50,233,89,136,234,78,178,47,72,218,188,207,188,246,2,38,211,248,158,72,14,203,81,112,119,90,146,221,208,88,205,96,141,233,209,76,97,109,185,115,78,250,185,213,124,85,35,110,37,93,142,168,245,66,61,161,250,255,152,24,197,179,255,1,15,115,26,97,98,17,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateConvertFunctionCodeToMacroMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("adea3118-2315-44f4-adae-5d8042b8318e"),
				Name = "ConvertFunctionCodeToMacro",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4bf526be-53c6-46c5-b770-6ba81eb8b739"),
				Name = "codeBody",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("705b1fbc-1af7-448d-9436-fbeae2a283d7"),
				Name = "functionMacro",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "LocalizableString",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e16ba317-25d0-40e1-9aaf-ef34c990f329"),
				Name = "functionCode",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,202,65,10,131,48,16,5,208,171,132,208,69,130,18,116,221,157,110,91,82,212,11,132,228,71,132,50,35,195,8,45,165,119,175,203,110,31,79,160,135,144,153,176,226,21,38,236,207,148,225,50,23,12,92,222,173,25,88,10,36,214,184,67,18,149,71,82,197,217,27,83,15,202,186,49,141,103,109,141,189,244,246,15,239,41,11,135,133,103,149,141,86,231,195,13,85,99,117,246,211,125,173,247,215,31,5,202,143,98,117,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateConvertFunctionMacroToCodeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c8c92e7a-2bc0-4664-8aaf-292cd7bc590b"),
				Name = "ConvertFunctionMacroToCode",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("26044bf3-cc1b-483e-b12e-3cc68e2590aa"),
				Name = "body",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("49bec26c-5e35-454d-af70-e5245e323fae"),
				Name = "functionMacro",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "LocalizableString",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1177df14-79c5-4337-973b-4eb2bbd10d30"),
				Name = "functionCode",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,53,203,65,10,194,48,16,5,208,171,132,224,34,193,18,116,237,78,113,103,137,84,47,48,38,63,165,32,153,48,78,65,17,239,110,23,186,127,79,160,179,84,51,96,196,51,12,104,119,74,112,55,206,175,206,236,89,50,36,150,216,32,84,243,153,84,177,208,245,15,31,31,137,26,92,153,107,210,137,107,79,73,56,92,249,162,50,213,209,249,112,66,209,88,156,125,111,62,214,251,206,216,213,214,46,249,239,15,156,225,119,95,99,177,112,4,127,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyServerMetaPathByClientMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("42322b33-6ec6-453b-96ea-37f5b5054d1e"),
				Name = "GetPropertyServerMetaPathByClientMetaPath",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aa6d2155-9303-4f89-938e-3d3ba29851c6"),
				Name = "clientMetaPath",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,205,10,194,48,16,132,239,130,239,144,99,10,37,47,80,60,41,246,212,18,16,31,96,73,135,52,96,55,101,179,218,215,87,15,254,228,56,124,51,243,121,201,1,165,92,194,140,133,204,90,165,131,57,39,158,78,40,41,50,38,255,207,108,211,237,119,15,18,19,193,16,210,44,175,54,99,51,85,171,255,192,17,155,189,22,200,49,51,35,104,202,220,214,46,87,237,6,98,138,16,55,210,130,178,82,192,219,38,208,187,240,79,232,122,232,0,37,79,58,219,234,172,53,225,150,192,95,218,116,79,219,231,45,131,230,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysVariableVDSStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("88cd0163-40d1-4da0-a2d8-42d32a38eb19"),
				Name = "GetSysVariableVDSStructure",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Dictionary<string, string>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,219,10,130,64,16,134,175,245,41,22,175,10,164,23,72,188,73,8,33,34,80,188,159,106,139,129,117,87,246,64,73,244,238,181,30,32,117,21,186,90,152,255,155,229,159,79,82,109,36,39,156,62,200,1,149,142,18,188,104,20,28,100,29,41,45,145,223,67,210,190,113,76,94,190,103,185,121,196,18,222,139,4,71,40,105,16,146,32,189,6,228,29,182,179,2,152,161,59,193,76,201,93,113,130,170,98,80,47,0,160,161,249,35,175,43,218,3,123,131,63,200,14,42,91,108,188,153,170,2,21,158,89,179,113,3,166,232,111,150,9,169,97,46,60,73,44,191,119,182,173,44,161,165,177,128,239,89,230,63,25,125,187,37,35,19,198,169,101,74,185,220,228,244,169,93,110,178,90,21,32,209,222,220,13,219,223,55,185,200,154,230,171,181,91,93,119,187,211,220,56,235,196,13,234,15,253,249,239,237,7,248,230,132,85,124,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillSysVariableMenuItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ae5c28fb-42d9-4d25-baa4-795224ae29b6"),
				Name = "FillSysVariableMenuItems",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,143,207,74,195,64,16,135,207,201,83,44,61,109,160,236,11,136,135,54,5,201,161,34,164,237,125,76,38,113,49,153,13,179,19,37,136,239,238,164,34,198,10,82,47,203,50,127,190,223,55,77,96,132,234,201,190,0,155,56,69,193,254,4,221,136,133,126,140,39,115,140,200,121,32,194,74,124,32,87,126,79,236,129,160,69,118,119,40,243,112,180,89,102,222,210,228,130,99,110,175,68,80,20,160,10,183,211,177,168,237,133,136,211,90,118,147,38,7,100,134,24,26,113,202,107,124,59,50,156,145,187,137,160,247,213,30,105,212,70,20,30,43,9,236,242,206,35,201,102,24,144,234,185,55,163,108,154,36,15,26,186,54,243,235,54,117,173,62,39,96,15,143,29,110,71,17,197,125,238,21,187,181,206,46,76,220,61,244,186,183,172,228,48,156,5,14,161,20,246,212,218,108,222,33,124,53,234,33,28,186,162,215,20,173,154,223,156,213,34,248,203,78,147,171,231,149,158,250,158,254,243,214,18,37,15,253,16,72,205,127,208,74,223,18,116,246,234,155,255,244,250,0,222,168,53,128,45,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindDesignedProcessSchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ae4c4d79-0843-49ce-ac53-c914a45db4c6"),
				Name = "FindDesignedProcessSchema",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "ProcessSchema"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,142,193,10,130,80,16,69,215,249,21,179,84,8,127,64,90,149,132,139,66,8,63,96,120,222,236,129,142,240,230,233,38,250,247,140,32,125,225,162,118,195,229,220,185,103,100,71,106,110,232,248,196,194,13,28,237,168,82,184,125,47,2,227,109,47,233,17,254,178,36,226,188,182,97,114,230,14,73,22,217,43,197,225,47,171,84,78,71,0,39,116,143,54,14,126,112,242,141,243,26,254,218,63,64,109,35,133,168,103,49,136,67,193,45,205,66,85,81,39,105,62,66,188,150,174,55,80,125,231,89,244,32,180,10,90,119,92,162,191,105,174,53,254,54,253,88,205,83,50,180,237,20,63,1,70,20,247,32,151,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetFormulaBodyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aca0c1fa-c625-4e75-b9dc-78aa53b4c2cb"),
				Name = "SetFormulaBody",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dd71ca40-9ac2-46c1-bc12-f7a940de3f29"),
				Name = "body",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,44,46,41,202,204,75,215,243,44,246,43,205,201,241,47,114,205,45,40,169,212,72,202,79,169,212,212,84,168,230,229,226,12,72,76,79,213,11,75,204,41,77,245,77,205,205,119,77,201,44,209,11,78,45,1,11,104,56,231,231,149,165,22,149,184,229,23,229,150,230,36,134,36,22,103,59,1,53,134,228,187,100,22,23,228,36,86,58,231,167,164,66,141,178,230,229,170,5,0,7,24,158,190,111,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFormulaBodyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6bad5b25-ffe4-4816-90ba-1601470b90ea"),
				Name = "GetFormulaBody",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,13,202,59,10,128,48,16,5,192,171,88,106,147,11,216,249,195,70,176,136,246,139,89,36,184,113,37,190,136,185,189,78,61,145,145,226,89,180,122,62,28,209,249,251,18,202,173,58,182,58,104,12,73,200,210,125,52,234,114,57,2,215,2,47,30,217,140,8,210,241,246,191,114,166,157,205,74,146,120,226,160,189,243,48,150,95,84,85,253,1,11,139,138,214,92,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetReferenceSchemaListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f2e6a8d3-ce9c-49f8-b932-ba8a97d9fa95"),
				Name = "GetReferenceSchemaList",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "JArray"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,221,74,195,64,16,133,175,27,200,59,44,189,218,64,201,11,180,10,69,75,240,7,12,86,189,31,55,167,237,214,118,19,38,147,202,34,190,187,201,166,180,32,41,232,229,114,134,239,124,123,178,198,22,170,34,243,65,107,188,222,21,234,74,101,144,252,244,214,201,52,142,110,173,17,91,58,98,63,203,218,243,137,170,133,173,91,95,43,198,10,12,103,176,112,98,197,47,205,6,123,170,123,198,243,96,166,207,85,29,249,64,124,134,244,39,143,182,150,150,224,240,169,238,231,204,228,131,194,170,100,144,217,232,7,248,55,218,53,200,201,242,95,100,148,117,23,44,19,245,21,71,163,78,0,59,236,225,78,165,79,239,91,24,9,173,163,99,148,206,139,66,135,48,231,178,2,139,215,227,95,218,237,135,198,147,225,170,180,149,78,95,202,101,240,212,73,242,79,242,13,85,221,250,23,233,97,143,30,58,48,101,40,56,150,117,55,223,113,196,144,134,221,208,238,211,31,151,151,38,46,14,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("85f15874-c160-4881-a267-610b12109534"),
				Name = "InitializeSchemaExplorerWindow",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,193,110,194,48,12,134,207,244,41,60,78,69,66,125,129,138,83,199,1,105,32,52,216,238,94,99,74,181,144,84,118,50,134,38,222,125,41,20,68,75,209,180,147,37,251,255,127,127,177,242,97,173,134,82,22,180,95,229,91,218,225,244,187,210,150,137,97,2,221,198,4,140,215,58,141,190,144,65,254,16,163,52,157,149,99,159,59,207,116,25,165,81,185,129,184,103,227,8,126,162,193,93,174,161,253,163,164,120,137,5,37,239,168,61,101,214,56,182,250,5,15,214,187,49,12,165,237,24,142,97,131,90,168,41,163,52,58,254,131,34,153,163,9,155,120,129,59,10,68,83,85,186,179,231,166,31,18,129,66,116,143,123,102,114,237,21,169,103,116,120,130,93,31,42,146,36,211,132,28,159,80,186,134,194,132,170,222,132,120,141,242,121,222,117,99,232,202,101,102,42,223,32,45,145,3,141,35,158,91,85,195,134,11,4,182,246,19,51,38,116,164,174,211,250,18,79,109,201,43,21,165,132,20,82,125,247,184,76,107,152,193,35,227,53,254,24,221,253,172,118,94,250,11,84,118,167,226,132,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("78241856-4864-46bb-909c-97816fd64a5f"),
				Name = "CreateColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "StructureExplorer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,221,78,131,48,20,190,30,79,81,185,194,104,250,2,203,46,38,98,66,162,113,25,83,47,140,49,21,14,19,83,90,114,90,54,200,178,119,183,29,91,157,209,78,111,232,105,249,126,78,191,211,21,67,210,48,100,53,153,16,1,107,178,0,68,166,100,169,233,67,74,159,224,45,150,66,163,228,138,186,98,102,209,160,1,163,176,210,80,171,84,148,50,188,36,223,54,14,115,39,11,160,115,182,62,31,7,43,227,148,75,222,214,34,211,216,230,186,69,72,186,134,75,4,220,123,255,56,143,102,108,9,244,145,241,22,246,246,183,172,151,173,54,110,131,210,1,104,44,75,198,21,184,69,105,172,196,146,38,117,163,123,227,237,241,165,73,151,243,182,128,107,166,217,206,101,209,55,160,246,221,12,18,207,47,100,67,194,171,74,48,236,237,45,111,42,14,118,77,107,211,154,45,98,105,164,66,178,245,155,164,42,123,151,235,172,87,38,160,120,135,177,22,6,6,127,113,238,155,70,42,147,235,28,74,64,16,57,56,94,44,235,70,10,16,122,250,193,186,100,101,10,2,69,165,237,49,55,185,27,156,79,217,17,20,77,142,24,227,224,152,79,7,201,139,9,137,127,151,121,61,197,237,52,50,247,2,20,157,22,69,180,123,98,39,6,241,149,139,141,222,206,35,147,45,230,224,144,3,192,124,57,228,186,146,34,50,98,169,242,116,23,35,48,13,133,75,171,42,73,116,230,69,207,97,89,153,217,32,20,231,100,19,140,124,45,30,96,214,121,244,15,49,231,190,13,60,88,255,148,198,1,130,217,11,239,255,79,121,179,147,177,183,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateColumnStructureExplorer_EditCompleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("107729e9-2868-4df3-b6b5-0165c468379a"),
				Name = "ColumnStructureExplorer_EditComplete",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6117f304-ba16-452a-bc68-b7edaa6b7e1c"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c7b8e21a-8d8c-4af5-84d0-a841eb53a3df"),
				Name = "e",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,193,110,130,64,16,134,207,229,41,40,39,72,13,47,96,219,164,42,109,180,33,53,65,123,49,30,166,56,234,182,203,46,153,93,26,104,211,119,239,226,162,69,139,241,4,187,252,252,223,252,51,19,9,205,116,149,164,91,204,192,197,246,225,206,157,43,164,161,20,2,83,205,164,8,163,214,215,24,4,108,144,194,39,212,99,161,52,136,20,7,213,124,188,242,19,200,114,206,196,198,202,204,77,208,119,62,129,92,165,169,72,117,65,24,149,57,151,84,27,243,34,19,134,226,79,94,222,222,13,34,152,40,3,25,161,129,50,224,236,11,125,12,163,82,19,76,129,32,67,141,164,22,30,211,152,169,177,88,75,111,185,55,222,129,172,91,140,218,168,245,214,184,158,225,45,188,172,209,120,203,112,38,19,77,166,86,223,88,169,221,219,145,91,227,212,110,74,157,55,57,145,12,170,61,214,239,170,165,219,251,177,224,124,8,121,221,215,11,136,150,114,80,253,163,28,19,50,72,73,42,99,24,195,7,198,187,195,97,32,86,255,10,188,192,17,83,57,135,106,74,184,102,101,171,11,238,205,185,26,155,94,219,222,153,105,168,17,219,237,4,80,85,79,240,239,116,107,43,233,185,246,121,31,196,29,191,244,29,182,118,253,235,46,183,208,236,155,6,38,212,51,86,190,141,19,4,238,183,115,213,41,126,88,173,26,81,239,66,100,155,245,36,224,97,68,38,222,143,99,246,24,73,207,176,52,27,173,229,176,32,37,105,42,21,171,97,251,82,250,191,111,84,30,63,47,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnStructureExplorerEditWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8274da4c-1050-4acc-9f31-8c7bba234a6f"),
				Name = "ShowColumnStructureExplorerEditWindow",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1d441803-26d0-4483-a7c1-790f20413412"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("17bd6cab-e6f4-4adb-9368-ac1ee9cca022"),
				Name = "parameterDataValueTypeUId",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,203,106,195,48,16,60,219,95,161,222,108,40,202,7,184,238,161,105,8,62,52,151,52,237,161,244,32,172,77,34,144,37,163,7,169,41,249,247,174,156,146,86,216,10,24,132,87,187,51,179,179,43,177,39,133,109,143,208,177,93,195,73,93,147,181,23,156,174,186,222,13,37,249,206,51,3,206,27,85,229,231,124,235,140,111,241,7,86,95,189,212,6,12,105,181,244,157,154,196,171,92,32,104,99,151,243,215,75,3,204,1,31,209,19,8,164,38,197,36,88,38,240,80,27,1,105,225,54,222,133,53,1,81,148,161,193,68,49,109,84,43,61,7,254,204,28,123,99,210,195,235,208,131,165,75,9,108,172,12,221,246,204,176,14,28,152,40,41,88,122,55,177,52,74,121,97,138,29,80,33,159,11,214,100,103,209,48,173,20,180,78,104,69,231,74,171,60,179,206,8,117,136,49,214,70,251,126,131,162,16,101,14,156,174,193,53,14,186,167,1,85,166,245,151,244,10,132,68,139,5,58,40,47,98,30,162,212,199,152,196,222,96,141,125,124,26,174,4,197,124,3,104,113,182,199,73,176,246,88,204,25,16,186,136,201,198,136,80,55,251,182,69,57,78,35,11,227,155,84,211,127,246,213,9,99,47,229,169,157,75,172,205,199,148,10,93,254,36,191,91,178,129,83,56,195,90,101,217,57,199,47,189,151,219,163,62,173,184,112,239,66,113,125,250,123,197,247,68,121,41,203,234,7,166,155,196,213,219,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMakeDateTimeValueMacrosMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("935ae797-2176-45f9-a0f8-016a8f91dd41"),
				Name = "MakeDateTimeValueMacros",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b8bd9644-fc09-44ce-853e-10a34492f7a1"),
				Name = "dateTime",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DateTime",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ed291d80-50ea-45eb-9bcb-384c25d704b5"),
				Name = "dateTimeKind",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,223,106,131,48,20,198,175,45,244,29,206,188,82,86,124,128,117,14,70,189,40,20,161,48,217,205,216,197,161,57,29,161,38,142,36,45,149,177,119,95,52,214,169,203,160,108,222,200,249,243,125,249,229,228,104,163,184,124,3,134,134,10,46,168,160,179,89,206,103,218,101,79,88,30,105,171,104,207,207,147,100,198,245,123,137,117,95,227,123,136,46,30,27,46,25,164,41,132,153,77,132,49,124,204,103,193,192,9,82,104,10,207,35,239,224,167,235,176,111,122,92,48,228,181,141,151,48,41,170,167,150,50,10,25,75,242,60,169,237,23,198,86,241,9,84,106,2,47,103,19,120,57,155,194,53,156,125,223,31,56,215,235,59,33,134,136,254,113,93,139,50,234,253,215,216,96,64,214,63,190,192,157,170,180,149,230,120,160,188,13,34,15,199,237,104,161,226,201,242,120,228,191,234,78,168,64,144,193,45,42,20,58,227,59,195,43,137,170,182,30,209,119,116,239,236,23,224,254,15,113,238,145,116,107,122,227,179,75,86,149,52,200,165,222,80,29,185,75,198,110,35,188,221,143,140,117,93,11,119,165,201,251,249,68,47,78,240,106,201,91,137,155,171,34,115,84,178,155,235,242,11,46,7,192,177,142,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateTryMakeLookupValueMacrosMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("79a28daa-30b4-4ad2-b120-0fdb740b8922"),
				Name = "TryMakeLookupValueMacros",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("94677321-732f-4968-aa7f-20657aac8f5e"),
				Name = "values",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string,object>",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("47313d83-8275-4833-98b9-69dc8caf1b20"),
				Name = "macros",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "out string",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,77,79,194,64,16,61,75,194,127,88,123,106,147,166,241,142,152,104,65,67,180,72,130,120,49,28,38,237,128,27,186,187,205,126,160,141,248,223,221,118,91,40,73,241,212,236,235,155,55,111,222,12,131,84,10,69,198,132,155,60,31,13,7,116,67,252,61,228,6,45,230,64,114,56,16,135,68,177,48,92,87,248,77,64,126,134,131,43,137,218,72,78,54,144,43,180,181,191,195,193,30,36,97,168,97,1,18,152,154,208,84,83,193,65,150,182,129,127,122,221,42,45,41,223,134,196,125,239,130,164,167,100,228,212,84,250,137,12,86,179,204,74,56,27,31,222,17,243,214,209,155,88,214,34,126,96,11,166,92,83,93,46,235,223,4,187,143,49,89,41,148,177,224,28,235,6,81,151,154,0,135,45,202,232,145,242,108,198,149,6,158,226,67,105,245,125,142,95,228,201,208,204,63,182,12,130,38,165,115,121,151,213,165,88,220,156,205,44,115,96,104,253,116,235,163,24,138,202,85,35,237,232,209,76,205,173,230,171,156,178,66,151,254,169,56,112,109,46,171,85,88,79,227,133,164,204,6,59,161,170,200,161,140,69,110,24,239,43,239,227,181,154,172,189,151,4,118,152,212,143,214,174,13,55,5,237,191,8,177,51,197,123,181,170,70,97,33,113,67,191,59,155,10,59,73,132,196,139,188,176,93,237,255,70,215,199,240,175,251,142,172,114,160,129,114,245,140,165,239,140,54,81,245,178,239,179,172,97,133,221,105,44,253,234,226,68,110,148,240,116,149,231,246,61,133,185,189,47,204,106,178,103,253,6,110,15,205,73,104,105,112,244,7,174,22,212,52,115,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMakeSysVariableMacrosMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("68cd5fca-ddf0-429a-8bfe-fc6a5381ec90"),
				Name = "MakeSysVariableMacros",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("340eaec5-3342-4ca9-8c0f-771c13a8b344"),
				Name = "name",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("65b3281d-ee0e-495b-aee2-1caae4031afc"),
				Name = "caption",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,79,205,10,130,64,16,62,39,248,14,211,109,151,196,23,176,130,200,91,8,130,209,125,210,53,150,220,93,153,221,162,37,122,247,212,21,186,216,105,248,152,239,247,137,4,74,56,44,145,80,217,92,214,78,26,141,228,97,7,236,135,182,214,145,212,183,4,194,221,243,98,65,146,197,81,120,131,194,154,140,29,44,10,188,139,98,2,172,242,246,130,36,241,218,137,92,218,190,67,95,146,104,229,43,61,155,106,82,49,14,27,168,177,31,221,248,224,37,91,96,235,165,106,233,209,104,135,82,219,147,240,44,68,113,14,239,56,90,45,178,15,77,51,179,146,63,125,66,145,33,93,163,18,124,204,254,196,17,9,247,32,61,79,201,190,224,28,81,172,39,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMakeSysSettingValueMacrosMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6e6f17a1-7d43-4ba8-ad10-0f01a4d004d6"),
				Name = "MakeSysSettingValueMacros",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a4e1669d-56ae-4621-b017-1f9594fa1543"),
				Name = "name",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1130b362-31ed-414d-88d8-1f00cbdcb2c0"),
				Name = "code",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,79,75,10,194,48,16,93,91,232,29,198,93,130,165,23,168,10,162,59,41,20,234,5,134,118,42,65,147,200,36,138,65,188,187,177,41,184,169,171,225,241,190,243,64,6,77,30,27,100,212,238,160,58,175,172,65,14,176,1,241,67,107,231,89,153,115,1,233,110,101,61,99,169,242,44,209,160,177,99,235,98,68,141,23,170,71,32,218,224,90,242,62,210,209,226,110,87,12,13,211,160,158,229,201,182,163,75,72,88,129,65,77,50,6,169,1,196,114,110,87,185,183,198,163,50,238,72,65,164,30,41,225,149,103,139,89,245,174,239,39,85,241,103,76,90,17,171,59,219,147,252,118,191,243,140,201,223,217,76,127,84,31,158,0,80,157,36,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetReferenceEntitySchemasMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4f361012-87d0-43a0-acd2-e7de02e09413"),
				Name = "GetReferenceEntitySchemas",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Dictionary<Guid, string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d012a56e-d2db-4d83-9a5a-55b641e1564b"),
				Name = "packageUId",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				ModifiedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,223,111,218,48,16,126,14,18,255,131,151,39,187,67,70,123,222,168,68,33,235,208,186,14,149,82,30,166,105,114,147,163,88,13,14,179,157,149,104,218,255,190,115,156,144,240,99,116,82,8,206,221,125,159,239,62,251,174,127,209,237,252,18,154,24,48,70,102,106,36,226,21,144,1,153,27,208,163,76,41,136,45,90,249,172,229,229,11,105,87,55,89,44,82,247,41,213,19,101,239,61,135,134,37,104,80,49,204,48,108,45,110,164,177,159,161,64,182,187,211,142,183,36,252,17,226,123,35,226,103,241,4,243,73,194,239,179,153,213,109,78,80,86,218,194,227,204,131,72,115,151,93,59,217,111,167,119,253,142,120,185,36,244,4,254,205,128,168,60,77,25,249,221,237,4,26,108,174,21,161,99,89,86,42,116,241,225,58,151,73,143,152,50,143,75,118,76,128,204,127,186,157,139,126,183,51,137,84,190,6,45,30,83,40,81,151,117,41,147,196,96,154,139,76,63,27,180,192,220,202,84,90,9,134,95,131,157,250,144,79,18,129,58,94,21,24,75,247,229,238,181,20,233,29,30,197,142,148,79,146,90,36,83,102,55,131,20,99,200,0,171,162,126,205,20,188,16,191,60,216,130,97,80,192,71,89,154,175,21,13,113,159,112,223,50,18,27,23,86,90,249,71,157,173,105,56,43,140,87,193,27,23,43,84,157,134,95,132,194,68,245,173,88,67,200,248,196,68,63,115,145,82,79,195,167,66,163,221,130,166,97,212,146,177,194,132,172,36,26,170,4,221,91,11,42,193,120,148,251,28,207,82,164,6,90,56,76,106,90,75,238,112,234,8,98,104,115,38,13,144,241,219,204,226,59,218,226,117,49,212,213,126,94,171,157,52,21,63,186,141,165,239,152,151,237,64,161,169,206,54,160,109,81,137,90,73,117,236,238,145,198,232,243,175,234,110,137,141,49,187,211,169,75,62,166,121,85,255,137,121,144,218,162,47,100,175,113,149,151,252,44,217,189,118,1,140,8,83,41,86,234,250,85,39,160,175,10,90,254,143,165,246,234,185,126,142,45,31,154,24,15,24,59,10,55,216,93,174,83,61,142,125,227,78,226,95,253,88,14,134,220,224,18,123,246,42,218,66,156,219,76,147,228,113,183,60,26,94,145,50,185,134,241,85,99,162,204,55,127,197,227,103,151,192,172,221,108,105,245,18,247,164,112,87,58,105,179,73,133,15,94,86,50,5,66,61,152,187,176,154,58,8,246,170,226,195,36,169,195,112,6,120,73,75,161,253,224,168,122,176,71,78,199,212,197,55,210,57,25,130,0,231,144,251,225,211,239,255,207,80,196,250,246,210,66,146,106,0,238,155,255,2,36,238,215,178,22,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPackageUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b7239792-4d56-48b6-9287-988a97d6ceae"),
				Name = "GetPackageUId",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,205,10,130,64,16,199,207,10,190,195,212,105,133,240,5,194,83,31,226,161,8,170,7,88,118,39,91,204,81,118,182,46,209,187,183,86,96,26,216,117,248,127,204,111,38,187,26,13,141,84,165,44,240,152,235,121,20,178,179,134,10,104,108,173,144,249,200,104,15,146,203,189,58,99,37,55,146,188,206,110,101,133,144,194,116,55,162,153,250,40,115,2,177,210,198,253,154,39,233,223,130,24,238,81,24,116,171,249,194,181,33,189,68,54,5,161,254,116,191,109,34,78,118,223,12,15,192,11,227,43,224,38,237,104,21,164,94,20,136,49,148,184,157,46,106,34,84,206,212,148,100,216,39,18,127,81,230,67,146,49,71,155,255,166,204,137,157,36,133,162,191,192,12,186,163,250,184,33,123,20,90,116,87,75,223,111,125,2,113,183,152,174,231,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearFormulaBodyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8058f42e-63cd-4429-8e00-b81eb48a220f"),
				Name = "ClearFormulaBody",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("f92f6bea-5f0b-420e-8adc-843ed74daca8"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,75,204,41,77,245,77,205,205,119,77,201,44,209,11,78,45,1,11,104,20,151,20,101,230,165,235,185,230,22,148,84,106,90,3,0,78,163,245,189,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFunctionNameMacrosMapMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("452a2868-e5c2-4d23-b0d3-d741b275a0d8"),
				Name = "GetFunctionNameMacrosMap",
				CreatedInSchemaUId = new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"),
				CreatedInPackageId = new Guid("60f20235-11d1-4adc-af5e-7a2fd0fc1d6c"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,206,193,10,130,64,16,6,224,115,130,239,176,120,150,94,160,8,2,17,58,136,16,69,231,37,39,27,210,89,88,103,43,17,223,189,53,133,214,195,74,167,229,159,253,254,221,209,192,70,147,32,120,137,4,175,140,138,164,110,183,13,107,164,50,22,227,185,19,93,24,172,186,40,85,186,54,149,60,51,86,200,8,205,58,67,138,98,145,26,250,22,109,234,99,15,148,111,7,238,159,165,15,218,171,255,96,166,10,247,107,85,76,48,145,12,39,172,225,39,19,217,58,210,38,175,204,20,241,125,246,170,205,94,61,36,7,15,113,105,135,252,118,1,120,204,55,25,103,75,173,3,29,37,149,48,175,77,195,62,12,250,205,7,204,133,198,151,192,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FormulaEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32c80eeb-7a9a-4bc8-8b76-b02045658a03"));
		}

		#endregion

	}

	#endregion

}

