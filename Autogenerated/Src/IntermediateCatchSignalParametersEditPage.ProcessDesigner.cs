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
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using UIControls = Terrasoft.UI.WebControls.Controls;
	using VwSysEntitySchemaInWorkspace = Terrasoft.Configuration.VwSysEntitySchemaInWorkspace;

	#region Class: IntermediateCatchSignalParametersEditPageSchema

	/// <exclude/>
	public class IntermediateCatchSignalParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _entityDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return _entityDataSource;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _waitRandomSignalButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton WaitRandomSignalButton {
			get {
				return _waitRandomSignalButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout9;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return _controlLayout9;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _signalEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SignalEdit {
			get {
				return _signalEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _waitEntitySignalButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton WaitEntitySignalButton {
			get {
				return _waitEntitySignalButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout7;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return _controlLayout7;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _entitySchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaEdit {
			get {
				return _entitySchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _eventEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit EventEdit {
			get {
				return _eventEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _entityEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntityEdit {
			get {
				return _entityEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout8;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout8 {
			get {
				return _controlLayout8;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _hasFilterButton;
		public Terrasoft.UI.WebControls.Controls.CheckBox HasFilterButton {
			get {
				return _hasFilterButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _filter_ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout Filter_ControlLayout {
			get {
				return _filter_ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _filterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return _filterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout6;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return _controlLayout6;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _hasChangedAnyColumnButton;
		public Terrasoft.UI.WebControls.Controls.CheckBox HasChangedAnyColumnButton {
			get {
				return _hasChangedAnyColumnButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _columns_ControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout Columns_ControlLayout {
			get {
				return _columns_ControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addColumnButton;
		public Terrasoft.UI.WebControls.Controls.Button AddColumnButton {
			get {
				return _addColumnButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _removeColumnButton;
		public Terrasoft.UI.WebControls.Controls.Button RemoveColumnButton {
			get {
				return _removeColumnButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _entityChangedColumnGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid EntityChangedColumnGrid {
			get {
				return _entityChangedColumnGrid;
			}
		}

		#endregion

		#region Constructors: Public

		public IntermediateCatchSignalParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public IntermediateCatchSignalParametersEditPageSchema(IntermediateCatchSignalParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			RealUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			Name = "IntermediateCatchSignalParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 600;
			HelpContextId = "520";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateIntermediateCatchSignalParametersEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			Controls.AddAt(1, CreateEntityDataSource());
			UpdateEntityDataSource();
			TopLevelControl.MoveItem(2, TopControlLayout);
			TopControlLayout.InsertItem(0, CreateCaptionEdit());
			TopControlLayout.InsertItem(1, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateWaitRandomSignalButton());
			ControlLayout1.InsertItem(1, CreateControlLayout9());
			ControlLayout9.InsertItem(0, CreateSignalEdit());
			ControlLayout1.InsertItem(2, CreateWaitEntitySignalButton());
			ControlLayout1.InsertItem(3, CreateControlLayout7());
			ControlLayout7.InsertItem(0, CreateEntitySchemaEdit());
			ControlLayout7.InsertItem(1, CreateEventEdit());
			ControlLayout7.InsertItem(2, CreateEntityEdit());
			ControlLayout7.InsertItem(3, CreateControlLayout8());
			ControlLayout8.InsertItem(0, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateHasFilterButton());
			ControlLayout4.InsertItem(1, CreateFilter_ControlLayout());
			Filter_ControlLayout.InsertItem(0, CreateFilterEdit());
			ControlLayout8.InsertItem(1, CreateControlLayout6());
			ControlLayout6.InsertItem(0, CreateHasChangedAnyColumnButton());
			ControlLayout6.InsertItem(1, CreateColumns_ControlLayout());
			Columns_ControlLayout.InsertItem(0, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateAddColumnButton());
			ControlLayout3.InsertItem(1, CreateRemoveColumnButton());
			Columns_ControlLayout.InsertItem(1, CreateEntityChangedColumnGrid());
			TopLevelControl.MoveItem(3, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateIntermediateCatchSignalParametersEditPageEventsProcessSchema() {
			var schema = new IntermediateCatchSignalParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("bdebd790-8cf8-4cf2-a8e9-9bd46bb1539b");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_entityDataSource.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = true;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("549e04de-a74b-4d90-baf3-271750939b49");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			return _entityDataSource;
		}

		protected virtual void UpdateEntityDataSource() {
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_captionEdit.UId = new Guid("c3ce147c-fa5d-4d4e-9303-54260b1448b0");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_captionEdit.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_captionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionEdit.AlignedByCaption = false;
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateWaitRandomSignalButton() {
			_waitRandomSignalButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_waitRandomSignalButton.UId = new Guid("02e0a813-4875-4b67-9c74-77a87ff62afd");
			_waitRandomSignalButton.Name = "WaitRandomSignalButton";
			_waitRandomSignalButton.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_waitRandomSignalButton.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_waitRandomSignalButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_waitRandomSignalButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_waitRandomSignalButton.Tag = "";
			_waitRandomSignalButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_waitRandomSignalButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_waitRandomSignalButton.AlignedByCaption = false;
			_waitRandomSignalButton.GroupName = "Group";
			return _waitRandomSignalButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSignalEdit() {
			_signalEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_signalEdit.UId = new Guid("8bea1b53-8014-41e7-9a3f-33672d048d44");
			_signalEdit.Name = "SignalEdit";
			_signalEdit.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_signalEdit.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_signalEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_signalEdit.Tag = "";
			_signalEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_signalEdit.Image = new ControlImage {};
			_signalEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _signalEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout9() {
			_controlLayout9 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout9.UId = new Guid("4099f1f9-e10c-4214-9d02-44b8b68bc495");
			_controlLayout9.Name = "ControlLayout9";
			_controlLayout9.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout9.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout9.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout9.Tag = "";
			_controlLayout9.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout9.FitHeightByContent = true;
			_controlLayout9.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout9.Padding = "0 0 0 15";
			_controlLayout9.StartNewAlignGroup = false;
			_controlLayout9.Image = new ControlImage {};
			_controlLayout9.Edges = "";
			return _controlLayout9;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateWaitEntitySignalButton() {
			_waitEntitySignalButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_waitEntitySignalButton.UId = new Guid("3bb76c0e-972e-4844-b7d5-1d6ecece0476");
			_waitEntitySignalButton.Name = "WaitEntitySignalButton";
			_waitEntitySignalButton.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_waitEntitySignalButton.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_waitEntitySignalButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_waitEntitySignalButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_waitEntitySignalButton.Tag = "";
			_waitEntitySignalButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_waitEntitySignalButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_waitEntitySignalButton.AlignedByCaption = false;
			_waitEntitySignalButton.GroupName = "";
			return _waitEntitySignalButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateEntitySchemaEdit() {
			_entitySchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_entitySchemaEdit.UId = new Guid("b749b470-e66c-4d02-9533-bcfb162768b1");
			_entitySchemaEdit.Name = "EntitySchemaEdit";
			_entitySchemaEdit.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_entitySchemaEdit.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_entitySchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entitySchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_entitySchemaEdit.Tag = "";
			_entitySchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entitySchemaEdit.Image = new ControlImage {};
			_entitySchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entitySchemaEdit.LookupSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15");
			_entitySchemaEdit.LookupPageSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			return _entitySchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateEventEdit() {
			_eventEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_eventEdit.UId = new Guid("9a0aefb1-2325-4629-bfee-4cd41d3adaed");
			_eventEdit.Name = "EventEdit";
			_eventEdit.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_eventEdit.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_eventEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_eventEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_eventEdit.Tag = "";
			_eventEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_eventEdit.Image = new ControlImage {};
			_eventEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _eventEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateEntityEdit() {
			_entityEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_entityEdit.UId = new Guid("5cebf56e-c288-4c53-a49c-de52c0623742");
			_entityEdit.Name = "EntityEdit";
			_entityEdit.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_entityEdit.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_entityEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityEdit.Tag = "";
			_entityEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_entityEdit.Image = new ControlImage {};
			_entityEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _entityEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateHasFilterButton() {
			_hasFilterButton = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_hasFilterButton.UId = new Guid("4a43804d-bada-430a-b985-1ee5f71f3ca9");
			_hasFilterButton.Name = "HasFilterButton";
			_hasFilterButton.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_hasFilterButton.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_hasFilterButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_hasFilterButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_hasFilterButton.Tag = "";
			_hasFilterButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_hasFilterButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_hasFilterButton.AlignedByCaption = false;
			return _hasFilterButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("ceee26dc-c7cb-4e34-8671-50b67319794f");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_filterEdit.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "EntityDataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.HasSplitter = true;
			_filterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFilter_ControlLayout() {
			_filter_ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_filter_ControlLayout.UId = new Guid("84ad3082-923f-4853-89f5-5fe879d7db28");
			_filter_ControlLayout.Name = "Filter_ControlLayout";
			_filter_ControlLayout.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_filter_ControlLayout.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_filter_ControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filter_ControlLayout.Tag = "";
			_filter_ControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filter_ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filter_ControlLayout.Padding = "0 0 0 15";
			_filter_ControlLayout.StartNewAlignGroup = false;
			_filter_ControlLayout.Image = new ControlImage {};
			_filter_ControlLayout.Edges = "";
			return _filter_ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("2e80baeb-a59a-4bd9-b6be-acad780a4c07");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout4.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Percentage(50);
			_controlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateHasChangedAnyColumnButton() {
			_hasChangedAnyColumnButton = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_hasChangedAnyColumnButton.UId = new Guid("23ac8c6e-c2a3-4156-9f76-e1707d76a0d6");
			_hasChangedAnyColumnButton.Name = "HasChangedAnyColumnButton";
			_hasChangedAnyColumnButton.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_hasChangedAnyColumnButton.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_hasChangedAnyColumnButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_hasChangedAnyColumnButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_hasChangedAnyColumnButton.Tag = "";
			_hasChangedAnyColumnButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_hasChangedAnyColumnButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_hasChangedAnyColumnButton.AlignedByCaption = false;
			return _hasChangedAnyColumnButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddColumnButton() {
			_addColumnButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addColumnButton.UId = new Guid("7fe04f27-2541-4a75-9828-ad09a960ade6");
			_addColumnButton.Name = "AddColumnButton";
			_addColumnButton.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_addColumnButton.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_addColumnButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addColumnButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addColumnButton.Tag = "";
			_addColumnButton.Image = new ControlImage {};
			return _addColumnButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateRemoveColumnButton() {
			_removeColumnButton = new Terrasoft.UI.WebControls.Controls.Button();
			_removeColumnButton.UId = new Guid("f91ac015-a45b-4d4a-8764-8cb975588edb");
			_removeColumnButton.Name = "RemoveColumnButton";
			_removeColumnButton.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_removeColumnButton.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_removeColumnButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_removeColumnButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_removeColumnButton.Tag = "";
			_removeColumnButton.Image = new ControlImage {};
			return _removeColumnButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("9f075c78-3124-4702-ada1-981aa2d27553");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout3.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(25);
			_controlLayout3.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateEntityChangedColumnGrid() {
			_entityChangedColumnGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_entityChangedColumnGrid.UId = new Guid("6fbbea33-094c-447f-91ca-c1a646e6a93e");
			_entityChangedColumnGrid.Name = "EntityChangedColumnGrid";
			_entityChangedColumnGrid.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_entityChangedColumnGrid.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_entityChangedColumnGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityChangedColumnGrid.Tag = "";
			_entityChangedColumnGrid.Edges = "1 1 1 1";
			_entityChangedColumnGrid.IsColumnAutowidth = true;
			_entityChangedColumnGrid.FooterVisible = false;
			_entityChangedColumnGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityChangedColumnGrid.IsSummaryVisible = false;
			_entityChangedColumnGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityChangedColumnGrid.ToolbarVisible = false;
			_entityChangedColumnGrid.QuickFilterVisible = false;
			_entityChangedColumnGrid.HideHeaders = false;
			return _entityChangedColumnGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateColumns_ControlLayout() {
			_columns_ControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_columns_ControlLayout.UId = new Guid("a7c35d42-a4fb-4985-a56f-d2a0ffd8abdf");
			_columns_ControlLayout.Name = "Columns_ControlLayout";
			_columns_ControlLayout.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_columns_ControlLayout.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_columns_ControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columns_ControlLayout.Tag = "";
			_columns_ControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_columns_ControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_columns_ControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columns_ControlLayout.Padding = "0 0 0 15";
			_columns_ControlLayout.StartNewAlignGroup = false;
			_columns_ControlLayout.Image = new ControlImage {};
			_columns_ControlLayout.Edges = "";
			return _columns_ControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout6() {
			_controlLayout6 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout6.UId = new Guid("2039d347-bca3-40be-91ae-7291fe7227a2");
			_controlLayout6.Name = "ControlLayout6";
			_controlLayout6.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout6.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout6.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout6.Tag = "";
			_controlLayout6.Height = System.Web.UI.WebControls.Unit.Percentage(50);
			_controlLayout6.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout6.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout6.StartNewAlignGroup = false;
			_controlLayout6.Image = new ControlImage {};
			_controlLayout6.Edges = "";
			return _controlLayout6;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout8() {
			_controlLayout8 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout8.UId = new Guid("27afc0e0-9baa-475e-986c-4b111642a843");
			_controlLayout8.Name = "ControlLayout8";
			_controlLayout8.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout8.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout8.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout8.Tag = "";
			_controlLayout8.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout8.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout8.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout8.StartNewAlignGroup = false;
			_controlLayout8.Image = new ControlImage {};
			_controlLayout8.Edges = "";
			return _controlLayout8;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout7() {
			_controlLayout7 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout7.UId = new Guid("84a0ef99-07e4-42bb-bd88-ef4c1bd2c246");
			_controlLayout7.Name = "ControlLayout7";
			_controlLayout7.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout7.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout7.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout7.Tag = "";
			_controlLayout7.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout7.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout7.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout7.Padding = "0 0 0 15";
			_controlLayout7.StartNewAlignGroup = false;
			_controlLayout7.Image = new ControlImage {};
			_controlLayout7.Edges = "";
			return _controlLayout7;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("01aa86fc-9e02-46cd-9564-7b67e946f08d");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout1.ModifiedInSchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new IntermediateCatchSignalParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new IntermediateCatchSignalParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new IntermediateCatchSignalParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: IntermediateCatchSignalParametersEditPageEventsProcess

	/// <exclude/>
	public class IntermediateCatchSignalParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.IntermediateCatchSignalParametersEditPageSchemaUserControl
	{

		#region Class: ShowChangeEntitySchemaMessageUserTaskFlowElement

		/// <exclude/>
		public class ShowChangeEntitySchemaMessageUserTaskFlowElement : QuestionUserTask
		{

			public ShowChangeEntitySchemaMessageUserTaskFlowElement(UserConnection userConnection, IntermediateCatchSignalParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowChangeEntitySchemaMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowWarningEmptyFiltersUserTaskFlowElement

		/// <exclude/>
		public class ShowWarningEmptyFiltersUserTaskFlowElement : QuestionUserTask
		{

			public ShowWarningEmptyFiltersUserTaskFlowElement(UserConnection userConnection, IntermediateCatchSignalParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowWarningEmptyFiltersUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public IntermediateCatchSignalParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IntermediateCatchSignalParametersEditPageEventsProcess";
			SchemaUId = new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_isShowWarningEmptyFilter = () => {{ return false; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("969a791d-250a-417e-9de8-bc4faefd9ed4");
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

		public virtual bool EntitySchemaColumnExplorerCreated {
			get;
			set;
		}

		public virtual bool EntitySchemaColumnExplorerRegistered {
			get;
			set;
		}

		public virtual Object EntitySchemaColumnExplorer {
			get;
			set;
		}

		public virtual Object EntityChangedColumns {
			get;
			set;
		}

		public virtual Guid SelectedEntitySchemaId {
			get;
			set;
		}

		public virtual bool IsSchemaEntityChanged {
			get;
			set;
		}

		public virtual Guid SchemaId {
			get;
			set;
		}

		public virtual bool IsParameterExplorerCreated {
			get;
			set;
		}

		public virtual Object ParameterExplorer {
			get;
			set;
		}

		public virtual Object ParameterExplorerId {
			get;
			set;
		}

		public virtual Object EntityIdCollection {
			get;
			set;
		}

		public virtual bool IsProcessSchemaStartSignalEvent {
			get;
			set;
		}

		public virtual bool IsParametersValid {
			get;
			set;
		}

		private Func<bool> _isShowWarningEmptyFilter;
		public virtual bool isShowWarningEmptyFilter {
			get {
				return (_isShowWarningEmptyFilter ?? (_isShowWarningEmptyFilter = () => false)).Invoke();
			}
			set {
				_isShowWarningEmptyFilter = () => { return value; };
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
					SchemaElementUId = new Guid("fc484bc0-cbe0-4821-a759-4da80a846322"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entitySchemaEditChange_StartMessage;
		public ProcessFlowElement EntitySchemaEditChange_StartMessage {
			get {
				return _entitySchemaEditChange_StartMessage ?? (_entitySchemaEditChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntitySchemaEditChange_StartMessage",
					SchemaElementUId = new Guid("241d4d8a-a678-403e-804b-3570329b66e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ShowChangeEntitySchemaMessageUserTaskFlowElement _showChangeEntitySchemaMessageUserTask;
		public ShowChangeEntitySchemaMessageUserTaskFlowElement ShowChangeEntitySchemaMessageUserTask {
			get {
				return _showChangeEntitySchemaMessageUserTask ?? (_showChangeEntitySchemaMessageUserTask = new ShowChangeEntitySchemaMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _prepareQuestionPage_ScriptTask;
		public ProcessScriptTask PrepareQuestionPage_ScriptTask {
			get {
				return _prepareQuestionPage_ScriptTask ?? (_prepareQuestionPage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareQuestionPage_ScriptTask",
					SchemaElementUId = new Guid("8ad5cbc1-ba8c-4c8d-bf52-f762f26a862b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareQuestionPage_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("5f101257-14d5-4bf5-8d6f-127b436391cf"),
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

		private ProcessThrowMessageEvent _entitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent EntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent {
			get {
				return _entitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent ?? (_entitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "EntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("c58185e8-d4d8-480a-8897-622b86be5ecd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "YESEntitySchemaEditChange",
				});
			}
		}

		private ProcessScriptTask _getGuid_ScriptTask;
		public ProcessScriptTask GetGuid_ScriptTask {
			get {
				return _getGuid_ScriptTask ?? (_getGuid_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GetGuid_ScriptTask",
					SchemaElementUId = new Guid("bfc82440-2519-485c-a659-c9fbc4dda939"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = GetGuid_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("e2f8438a-6d2b-47ef-9c2f-ba0f752827fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _yESEntitySchemaEditChange_StartMessage;
		public ProcessFlowElement YESEntitySchemaEditChange_StartMessage {
			get {
				return _yESEntitySchemaEditChange_StartMessage ?? (_yESEntitySchemaEditChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "YESEntitySchemaEditChange_StartMessage",
					SchemaElementUId = new Guid("8f7c1962-1372-4899-812c-97f08065a90e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processYesAnswer_ScriptTask;
		public ProcessScriptTask ProcessYesAnswer_ScriptTask {
			get {
				return _processYesAnswer_ScriptTask ?? (_processYesAnswer_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessYesAnswer_ScriptTask",
					SchemaElementUId = new Guid("d3b65141-9787-44c9-aaa8-750deb4d1acf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessYesAnswer_ScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _yESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent YESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent {
			get {
				return _yESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent ?? (_yESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "YESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("d4456d99-5bae-4c96-aaa9-85c508c15f53"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "EventEditChange",
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
					SchemaElementUId = new Guid("ce09aa30-52fa-4ab1-9369-7fbe1b5f353d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _nOEntitySchemaEditChange_StartMessage;
		public ProcessFlowElement NOEntitySchemaEditChange_StartMessage {
			get {
				return _nOEntitySchemaEditChange_StartMessage ?? (_nOEntitySchemaEditChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "NOEntitySchemaEditChange_StartMessage",
					SchemaElementUId = new Guid("658b1ee4-29bc-4360-a7a1-15e95d38f90e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processNoAnswer_ScriptTask;
		public ProcessScriptTask ProcessNoAnswer_ScriptTask {
			get {
				return _processNoAnswer_ScriptTask ?? (_processNoAnswer_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessNoAnswer_ScriptTask",
					SchemaElementUId = new Guid("88a433ba-3a86-4dce-8d04-29ed08f07954"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessNoAnswer_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("969876b3-c399-4cdf-87fc-d88c6532b202"),
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
					SchemaElementUId = new Guid("1621defe-1572-45de-a5c9-187fcf480026"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processSave_ScriptTask;
		public ProcessScriptTask ProcessSave_ScriptTask {
			get {
				return _processSave_ScriptTask ?? (_processSave_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessSave_ScriptTask",
					SchemaElementUId = new Guid("abc47811-349e-4c53-a178-f2ceaec55c29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessSave_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("4bd80a5a-154e-48ba-a348-4a134408f743"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("75d0a5cc-4e4b-497c-b80c-459e33cbdf13"),
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

		private ProcessScriptTask _prepareQuestionPage_ScriptTask2;
		public ProcessScriptTask PrepareQuestionPage_ScriptTask2 {
			get {
				return _prepareQuestionPage_ScriptTask2 ?? (_prepareQuestionPage_ScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareQuestionPage_ScriptTask2",
					SchemaElementUId = new Guid("47a9ec00-bc65-4b7e-bb4d-19f759ed9702"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareQuestionPage_ScriptTask2Execute,
				});
			}
		}

		private ShowWarningEmptyFiltersUserTaskFlowElement _showWarningEmptyFiltersUserTask;
		public ShowWarningEmptyFiltersUserTaskFlowElement ShowWarningEmptyFiltersUserTask {
			get {
				return _showWarningEmptyFiltersUserTask ?? (_showWarningEmptyFiltersUserTask = new ShowWarningEmptyFiltersUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("1a9b8051-6673-4265-ae7a-b2a900c6224c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _yESCloseEditPage_StartMessage;
		public ProcessFlowElement YESCloseEditPage_StartMessage {
			get {
				return _yESCloseEditPage_StartMessage ?? (_yESCloseEditPage_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "YESCloseEditPage_StartMessage",
					SchemaElementUId = new Guid("47b39c63-2bc0-4055-887a-8b86449db167"),
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
					SchemaElementUId = new Guid("c1182e84-aa7b-4086-8e2f-38cb4d369de7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("169e1db4-ab15-44f8-9deb-e231f1cb37f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventEditChange_StartMessage;
		public ProcessFlowElement EventEditChange_StartMessage {
			get {
				return _eventEditChange_StartMessage ?? (_eventEditChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EventEditChange_StartMessage",
					SchemaElementUId = new Guid("09e44c43-ad07-468e-8917-1fa02cf5b5b3"),
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
					SchemaElementUId = new Guid("c8130b64-0246-4cec-9cf8-122ea3c3156d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask8Execute,
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
					SchemaElementUId = new Guid("c0f21f1d-d2bf-4ef0-b778-77849ef338b1"),
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
					SchemaElementUId = new Guid("3906abe7-b830-43ca-8c5e-90f5f43dfb0d"),
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
					SchemaElementUId = new Guid("303d5661-1ae6-46d4-804a-9fc21f7cf0aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask7Execute,
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
					SchemaElementUId = new Guid("4f2a4f2b-5bc6-4f3f-9395-4d15f0ff7536"),
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
					SchemaElementUId = new Guid("e213262f-dcb4-4182-b5aa-8c9f5c29e0ca"),
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
					SchemaElementUId = new Guid("6daf2ca8-60c6-4efe-8c60-5dad84e70f2d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask6Execute,
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
					SchemaElementUId = new Guid("0276f700-b858-4899-a007-cd0953b250d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _waitEntitySignalButtonCheck_StartMessage;
		public ProcessFlowElement WaitEntitySignalButtonCheck_StartMessage {
			get {
				return _waitEntitySignalButtonCheck_StartMessage ?? (_waitEntitySignalButtonCheck_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WaitEntitySignalButtonCheck_StartMessage",
					SchemaElementUId = new Guid("d32f4367-61c9-4040-b4cb-993a6fb5713f"),
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
					SchemaElementUId = new Guid("8b99b3c8-a2c9-49e9-95af-3687ff57b9bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
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
					SchemaElementUId = new Guid("1eff0811-7204-4a8c-95e5-b230c61566c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _waitRandomSignalButtonCheck_StartMessage;
		public ProcessFlowElement WaitRandomSignalButtonCheck_StartMessage {
			get {
				return _waitRandomSignalButtonCheck_StartMessage ?? (_waitRandomSignalButtonCheck_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "WaitRandomSignalButtonCheck_StartMessage",
					SchemaElementUId = new Guid("82bfcc94-e9d9-40eb-9cd7-b85df41475e4"),
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
					SchemaElementUId = new Guid("9c5a86da-ce68-4dd0-9340-aafc304736f6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
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
					SchemaElementUId = new Guid("2439fe10-c65f-4c97-9932-0f327da98e08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addColumnButtonClickStartMessage;
		public ProcessFlowElement AddColumnButtonClickStartMessage {
			get {
				return _addColumnButtonClickStartMessage ?? (_addColumnButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddColumnButtonClickStartMessage",
					SchemaElementUId = new Guid("6321e4b6-ae0d-4fe0-9ea5-095a626e7893"),
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
					SchemaElementUId = new Guid("edca4e15-5e49-4582-ade9-cd9ae5884c37"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("a7dc7c09-89c0-485c-ad8b-5b333fefddc3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _removeColumnButtonClickStartMessage;
		public ProcessFlowElement RemoveColumnButtonClickStartMessage {
			get {
				return _removeColumnButtonClickStartMessage ?? (_removeColumnButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RemoveColumnButtonClickStartMessage",
					SchemaElementUId = new Guid("c97e24f5-3586-4fb9-bff1-ad8f28b2882f"),
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
					SchemaElementUId = new Guid("a311af7c-412a-4f65-8cca-f37e79900150"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
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
					SchemaElementUId = new Guid("edf12666-2488-4bf2-9012-e25a2519434e"),
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
					SchemaElementUId = new Guid("22a24b80-a6be-4df4-94a4-0daacacebc34"),
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
					SchemaElementUId = new Guid("09653f3a-1ff7-49be-a9ef-cdec90980f30"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _init_ScriptTask;
		public ProcessScriptTask Init_ScriptTask {
			get {
				return _init_ScriptTask ?? (_init_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Init_ScriptTask",
					SchemaElementUId = new Guid("14cd49b3-3d4d-4753-8a70-778f50fc515c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Init_ScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _addFilterEntitySchema_ScriptTask;
		public ProcessScriptTask AddFilterEntitySchema_ScriptTask {
			get {
				return _addFilterEntitySchema_ScriptTask ?? (_addFilterEntitySchema_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddFilterEntitySchema_ScriptTask",
					SchemaElementUId = new Guid("b00e0e0f-3441-431b-a61e-edb09efdfa02"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddFilterEntitySchema_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("883a98d5-5d83-49bb-95b4-1281f114f01e"),
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
					SchemaElementUId = new Guid("a9ce2af7-d828-4cf2-8d24-d977189d51f2"),
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
					SchemaElementUId = new Guid("18af0fd4-a017-45c3-bfc6-0e7101c3fc67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _processPageLoadComplete_ScriptTask;
		public ProcessScriptTask ProcessPageLoadComplete_ScriptTask {
			get {
				return _processPageLoadComplete_ScriptTask ?? (_processPageLoadComplete_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessPageLoadComplete_ScriptTask",
					SchemaElementUId = new Guid("326b3b5f-6405-4a1f-9be1-4151cbd9bfbc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessPageLoadComplete_ScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _setPageCaption_ScriptTask;
		public ProcessScriptTask SetPageCaption_ScriptTask {
			get {
				return _setPageCaption_ScriptTask ?? (_setPageCaption_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetPageCaption_ScriptTask",
					SchemaElementUId = new Guid("92f0b8dc-2511-4368-9d33-e8fa64a6a3e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetPageCaption_ScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _subscribeClientEventsScriptTask;
		public ProcessScriptTask SubscribeClientEventsScriptTask {
			get {
				return _subscribeClientEventsScriptTask ?? (_subscribeClientEventsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SubscribeClientEventsScriptTask",
					SchemaElementUId = new Guid("712f844a-c347-457d-a94c-c1de62a9a2a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SubscribeClientEventsScriptTaskExecute,
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
					SchemaElementUId = new Guid("9287cfb8-0043-491d-b380-2571a5454071"),
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
					SchemaElementUId = new Guid("f6f22001-29c9-415d-ae81-899fa01fa988"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("3598e6ed-b7e0-41f3-97d0-5a5d87197843"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _insertedDataEventCaption;
		public LocalizableString InsertedDataEventCaption {
			get {
				return _insertedDataEventCaption ?? (_insertedDataEventCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.InsertedDataEventCaption.Value"));
			}
		}

		private LocalizableString _updatedDataEventCaption;
		public LocalizableString UpdatedDataEventCaption {
			get {
				return _updatedDataEventCaption ?? (_updatedDataEventCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UpdatedDataEventCaption.Value"));
			}
		}

		private LocalizableString _deletedDataEventCaption;
		public LocalizableString DeletedDataEventCaption {
			get {
				return _deletedDataEventCaption ?? (_deletedDataEventCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeletedDataEventCaption.Value"));
			}
		}

		private LocalizableString _changeSchemaEntityMessage;
		public LocalizableString ChangeSchemaEntityMessage {
			get {
				return _changeSchemaEntityMessage ?? (_changeSchemaEntityMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChangeSchemaEntityMessage.Value"));
			}
		}

		private LocalizableString _pageCaption;
		public LocalizableString PageCaption {
			get {
				return _pageCaption ?? (_pageCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PageCaption.Value"));
			}
		}

		private LocalizableString _warningChangeEntitySchemaOnSave;
		public LocalizableString WarningChangeEntitySchemaOnSave {
			get {
				return _warningChangeEntitySchemaOnSave ?? (_warningChangeEntitySchemaOnSave = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WarningChangeEntitySchemaOnSave.Value"));
			}
		}

		private LocalizableString _radioButtonCaption;
		public LocalizableString RadioButtonCaption {
			get {
				return _radioButtonCaption ?? (_radioButtonCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RadioButtonCaption.Value"));
			}
		}

		private LocalizableString _columnNameCaption;
		public LocalizableString ColumnNameCaption {
			get {
				return _columnNameCaption ?? (_columnNameCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ColumnNameCaption.Value"));
			}
		}

		private LocalizableString _validationMessageTextFilterParamsEmpty;
		public LocalizableString ValidationMessageTextFilterParamsEmpty {
			get {
				return _validationMessageTextFilterParamsEmpty ?? (_validationMessageTextFilterParamsEmpty = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTextFilterParamsEmpty.Value"));
			}
		}

		private LocalizableString _validationMessageTitle;
		public LocalizableString ValidationMessageTitle {
			get {
				return _validationMessageTitle ?? (_validationMessageTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTitle.Value"));
			}
		}

		private LocalizableString _warningEmptyFilters;
		public LocalizableString WarningEmptyFilters {
			get {
				return _warningEmptyFilters ?? (_warningEmptyFilters = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WarningEmptyFilters.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[EntitySchemaEditChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaEditChange_StartMessage };
			FlowElements[ShowChangeEntitySchemaMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowChangeEntitySchemaMessageUserTask };
			FlowElements[PrepareQuestionPage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareQuestionPage_ScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[EntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent };
			FlowElements[GetGuid_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GetGuid_ScriptTask };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[YESEntitySchemaEditChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { YESEntitySchemaEditChange_StartMessage };
			FlowElements[ProcessYesAnswer_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessYesAnswer_ScriptTask };
			FlowElements[YESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { YESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent };
			FlowElements[EventSubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess14 };
			FlowElements[NOEntitySchemaEditChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { NOEntitySchemaEditChange_StartMessage };
			FlowElements[ProcessNoAnswer_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessNoAnswer_ScriptTask };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[StartMessage8.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage8 };
			FlowElements[ProcessSave_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessSave_ScriptTask };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[PrepareQuestionPage_ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareQuestionPage_ScriptTask2 };
			FlowElements[ShowWarningEmptyFiltersUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowWarningEmptyFiltersUserTask };
			FlowElements[EventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess16 };
			FlowElements[YESCloseEditPage_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { YESCloseEditPage_StartMessage };
			FlowElements[IntermediateThrowMessageEvent5.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent5 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[EventEditChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventEditChange_StartMessage };
			FlowElements[ScriptTask8.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask8 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[ScriptTask7.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask7 };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[ScriptTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask6 };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[WaitEntitySignalButtonCheck_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { WaitEntitySignalButtonCheck_StartMessage };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[WaitRandomSignalButtonCheck_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { WaitRandomSignalButtonCheck_StartMessage };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[AddColumnButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddColumnButtonClickStartMessage };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[RemoveColumnButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RemoveColumnButtonClickStartMessage };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[Init_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Init_ScriptTask };
			FlowElements[AddFilterEntitySchema_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddFilterEntitySchema_ScriptTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage7 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[ProcessPageLoadComplete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessPageLoadComplete_ScriptTask };
			FlowElements[SetPageCaption_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetPageCaption_ScriptTask };
			FlowElements[SubscribeClientEventsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SubscribeClientEventsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess12":
						break;
					case "EntitySchemaEditChange_StartMessage":
						e.Context.QueueTasks.Enqueue("GetGuid_ScriptTask");
						break;
					case "ShowChangeEntitySchemaMessageUserTask":
						break;
					case "PrepareQuestionPage_ScriptTask":
						e.Context.QueueTasks.Enqueue("ShowChangeEntitySchemaMessageUserTask");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("EntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent");
							break;
						}
						e.Context.QueueTasks.Enqueue("PrepareQuestionPage_ScriptTask");
						break;
					case "EntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent":
						break;
					case "GetGuid_ScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "EventSubProcess13":
						break;
					case "YESEntitySchemaEditChange_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessYesAnswer_ScriptTask");
						break;
					case "ProcessYesAnswer_ScriptTask":
						e.Context.QueueTasks.Enqueue("YESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent");
						break;
					case "YESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent":
						break;
					case "EventSubProcess14":
						break;
					case "NOEntitySchemaEditChange_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessNoAnswer_ScriptTask");
						break;
					case "ProcessNoAnswer_ScriptTask":
						break;
					case "EventSubProcess11":
						break;
					case "StartMessage8":
						e.Context.QueueTasks.Enqueue("ProcessSave_ScriptTask");
						break;
					case "ProcessSave_ScriptTask":
						if (ConditionalFlow2ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
							break;
						}
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
							break;
						}
						e.Context.QueueTasks.Enqueue("PrepareQuestionPage_ScriptTask2");
						break;
					case "PrepareQuestionPage_ScriptTask2":
						e.Context.QueueTasks.Enqueue("ShowWarningEmptyFiltersUserTask");
						break;
					case "ShowWarningEmptyFiltersUserTask":
						break;
					case "EventSubProcess16":
						break;
					case "YESCloseEditPage_StartMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent5");
						break;
					case "IntermediateThrowMessageEvent5":
						break;
					case "EventSubProcess9":
						break;
					case "EventEditChange_StartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask8");
						break;
					case "ScriptTask8":
						break;
					case "EventSubProcess8":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("ScriptTask7");
						break;
					case "ScriptTask7":
						break;
					case "EventSubProcess7":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("ScriptTask6");
						break;
					case "ScriptTask6":
						break;
					case "EventSubProcess6":
						break;
					case "WaitEntitySignalButtonCheck_StartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
						break;
					case "EventSubProcess5":
						break;
					case "WaitRandomSignalButtonCheck_StartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
					case "EventSubProcess3":
						break;
					case "AddColumnButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "EventSubProcess4":
						break;
					case "RemoveColumnButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "ScriptTask3":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("Init_ScriptTask");
						break;
					case "Init_ScriptTask":
						e.Context.QueueTasks.Enqueue("AddFilterEntitySchema_ScriptTask");
						break;
					case "AddFilterEntitySchema_ScriptTask":
						break;
					case "EventSubProcess10":
						break;
					case "StartMessage7":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("ProcessPageLoadComplete_ScriptTask");
						break;
					case "ProcessPageLoadComplete_ScriptTask":
						e.Context.QueueTasks.Enqueue("SetPageCaption_ScriptTask");
						break;
					case "SetPageCaption_ScriptTask":
						e.Context.QueueTasks.Enqueue("SubscribeClientEventsScriptTask");
						break;
					case "SubscribeClientEventsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(Page.EntityDataSource.SchemaUId.Equals(Guid.Empty) || Page.EntityDataSource.SchemaUId.Equals(SelectedEntitySchemaId));
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(IsParametersValid);
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean(!isShowWarningEmptyFilter);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EntitySchemaEditChange_StartMessage");
			ActivatedEventElements.Add("YESEntitySchemaEditChange_StartMessage");
			ActivatedEventElements.Add("NOEntitySchemaEditChange_StartMessage");
			ActivatedEventElements.Add("StartMessage8");
			ActivatedEventElements.Add("YESCloseEditPage_StartMessage");
			ActivatedEventElements.Add("EventEditChange_StartMessage");
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("WaitEntitySignalButtonCheck_StartMessage");
			ActivatedEventElements.Add("WaitRandomSignalButtonCheck_StartMessage");
			ActivatedEventElements.Add("AddColumnButtonClickStartMessage");
			ActivatedEventElements.Add("RemoveColumnButtonClickStartMessage");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage7");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "EntitySchemaEditChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaEditChange_StartMessage";
					result = EntitySchemaEditChange_StartMessage.Execute(context);
					break;
				case "ShowChangeEntitySchemaMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowChangeEntitySchemaMessageUserTask";
					result = ShowChangeEntitySchemaMessageUserTask.Execute(context);
					break;
				case "PrepareQuestionPage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareQuestionPage_ScriptTask";
					result = PrepareQuestionPage_ScriptTask.Execute(context, PrepareQuestionPage_ScriptTaskExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "EntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = EntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "GetGuid_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GetGuid_ScriptTask";
					result = GetGuid_ScriptTask.Execute(context, GetGuid_ScriptTaskExecute);
					break;
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "YESEntitySchemaEditChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "YESEntitySchemaEditChange_StartMessage";
					result = YESEntitySchemaEditChange_StartMessage.Execute(context);
					break;
				case "ProcessYesAnswer_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessYesAnswer_ScriptTask";
					result = ProcessYesAnswer_ScriptTask.Execute(context, ProcessYesAnswer_ScriptTaskExecute);
					break;
				case "YESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = YESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "EventSubProcess14":
					context.QueueTasks.Dequeue();
					break;
				case "NOEntitySchemaEditChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "NOEntitySchemaEditChange_StartMessage";
					result = NOEntitySchemaEditChange_StartMessage.Execute(context);
					break;
				case "ProcessNoAnswer_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessNoAnswer_ScriptTask";
					result = ProcessNoAnswer_ScriptTask.Execute(context, ProcessNoAnswer_ScriptTaskExecute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage8":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage8";
					result = StartMessage8.Execute(context);
					break;
				case "ProcessSave_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessSave_ScriptTask";
					result = ProcessSave_ScriptTask.Execute(context, ProcessSave_ScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "PrepareQuestionPage_ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareQuestionPage_ScriptTask2";
					result = PrepareQuestionPage_ScriptTask2.Execute(context, PrepareQuestionPage_ScriptTask2Execute);
					break;
				case "ShowWarningEmptyFiltersUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowWarningEmptyFiltersUserTask";
					result = ShowWarningEmptyFiltersUserTask.Execute(context);
					break;
				case "EventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "YESCloseEditPage_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "YESCloseEditPage_StartMessage";
					result = YESCloseEditPage_StartMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent5":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent5.Execute(context);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "EventEditChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EventEditChange_StartMessage";
					result = EventEditChange_StartMessage.Execute(context);
					break;
				case "ScriptTask8":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask8";
					result = ScriptTask8.Execute(context, ScriptTask8Execute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "ScriptTask7":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask7";
					result = ScriptTask7.Execute(context, ScriptTask7Execute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "ScriptTask6":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask6";
					result = ScriptTask6.Execute(context, ScriptTask6Execute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "WaitEntitySignalButtonCheck_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "WaitEntitySignalButtonCheck_StartMessage";
					result = WaitEntitySignalButtonCheck_StartMessage.Execute(context);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "WaitRandomSignalButtonCheck_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "WaitRandomSignalButtonCheck_StartMessage";
					result = WaitRandomSignalButtonCheck_StartMessage.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "AddColumnButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddColumnButtonClickStartMessage";
					result = AddColumnButtonClickStartMessage.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "RemoveColumnButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemoveColumnButtonClickStartMessage";
					result = RemoveColumnButtonClickStartMessage.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "Init_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init_ScriptTask";
					result = Init_ScriptTask.Execute(context, Init_ScriptTaskExecute);
					break;
				case "AddFilterEntitySchema_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddFilterEntitySchema_ScriptTask";
					result = AddFilterEntitySchema_ScriptTask.Execute(context, AddFilterEntitySchema_ScriptTaskExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage7";
					result = StartMessage7.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ProcessPageLoadComplete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessPageLoadComplete_ScriptTask";
					result = ProcessPageLoadComplete_ScriptTask.Execute(context, ProcessPageLoadComplete_ScriptTaskExecute);
					break;
				case "SetPageCaption_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetPageCaption_ScriptTask";
					result = SetPageCaption_ScriptTask.Execute(context, SetPageCaption_ScriptTaskExecute);
					break;
				case "SubscribeClientEventsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SubscribeClientEventsScriptTask";
					result = SubscribeClientEventsScriptTask.Execute(context, SubscribeClientEventsScriptTaskExecute);
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
				case "IsParametersValid":
					IsParametersValid = reader.GetValue<System.Boolean>();
				break;
				case "IsProcessSchemaStartSignalEvent":
					IsProcessSchemaStartSignalEvent = reader.GetValue<System.Boolean>();
				break;
				case "EntityIdCollection":
					EntityIdCollection = reader.GetSerializableObjectValue();
				break;
				case "ParameterExplorerId":
					ParameterExplorerId = reader.GetSerializableObjectValue();
				break;
				case "ParameterExplorer":
					ParameterExplorer = reader.GetSerializableObjectValue();
				break;
				case "IsParameterExplorerCreated":
					IsParameterExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "SchemaId":
					SchemaId = reader.GetValue<System.Guid>();
				break;
				case "IsSchemaEntityChanged":
					IsSchemaEntityChanged = reader.GetValue<System.Boolean>();
				break;
				case "SelectedEntitySchemaId":
					SelectedEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "EntityChangedColumns":
					EntityChangedColumns = reader.GetSerializableObjectValue();
				break;
				case "EntitySchemaColumnExplorerRegistered":
					EntitySchemaColumnExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "EntitySchemaColumnExplorerCreated":
					EntitySchemaColumnExplorerCreated = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool PrepareQuestionPage_ScriptTaskExecute(ProcessExecutingContext context) {
			ShowChangeEntitySchemaMessageUserTask.Page = Page;
			ShowChangeEntitySchemaMessageUserTask.MessageText = ChangeSchemaEntityMessage;
			ShowChangeEntitySchemaMessageUserTask.Icon = "QUESTION";
			ShowChangeEntitySchemaMessageUserTask.Buttons = "YESNO";
			ShowChangeEntitySchemaMessageUserTask.ResponseMessages = new Dictionary<string, string> {
				{"yes", "YESEntitySchemaEditChange"},
				{"no", "NOEntitySchemaEditChange"},
			};
			return true;
		}

		public virtual bool GetGuid_ScriptTaskExecute(ProcessExecutingContext context) {
			SelectedEntitySchemaId = Guid.Empty;
			
			if (Page.EntitySchemaEdit.Value == null) { 
				return true;
			}
			// TODO #170738 
			var entitySchemaInWorkspace = GetVwSysEntitySchema("UId", (Guid)Page.EntitySchemaEdit.Value);
			if (entitySchemaInWorkspace != null) {
				SelectedEntitySchemaId = entitySchemaInWorkspace.UId;
			}
			return true;
		}

		public virtual bool ProcessYesAnswer_ScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.EntitySchemaEdit.Value == null || ((Guid)Page.EntitySchemaEdit.Value).Equals(Guid.Empty)) {
				Page.EntityDataSource.CurrentStructure.Clear();
				SchemaId = Guid.Empty;
				var lookupDvt = (DataValueType)UserConnection.DataValueTypeManager.GetItemByName("Lookup").Instance;
				var parameterValue = new ProcessSchemaParameterValue() {
					DataValueType = lookupDvt,
					ReferenceSchemaUId = SchemaId,
					SchemaUId = EditSchemaUId,
					SchemaManagerName = EditSchemaManagerName
				};
				Page.EntityEdit.ParameterValue = parameterValue;
				Page.EntityDataSource.SchemaUId = SchemaId;
				/*
				ProcessSchemaParameterValue entityEditValue = Page.EntityEdit.ParameterValue;
				entityEditValue.ReferenceSchemaUId = SchemaId;
				Page.EntityEdit.Value = entityEditValue;
				Page.AddScript(String.Format("{0}.setReferenceSchemaUId('{1}')", Page.EntityEdit.ClientID, SchemaId));
				*/
				Page.EntityDataSource.LoadStructure();
				EntityChangedColumns = null;
				DisplayEntityChangedColumns();
				return true;
			}
			var entitySchemaInWorkspace = GetVwSysEntitySchema("Id", (Guid)Page.EntitySchemaEdit.Value);
			if (entitySchemaInWorkspace != null) {
				Page.EntitySchemaEdit.SetValueAndText(entitySchemaInWorkspace.UId, entitySchemaInWorkspace.Caption);
				Page.EntityDataSource.CurrentStructure.Clear();	
				Page.EntityDataSource.SchemaUId = entitySchemaInWorkspace.UId;
				if (!IsProcessSchemaStartSignalEvent) {
					var lookupDvt = (DataValueType)UserConnection.DataValueTypeManager.GetItemByName("Lookup").Instance;
					Page.EntityEdit.ParameterValue = new ProcessSchemaParameterValue() {
						DataValueType = lookupDvt,
						ReferenceSchemaUId = entitySchemaInWorkspace.UId,
						SchemaUId = EditSchemaUId,
						SchemaManagerName = EditSchemaManagerName
					};
					//Page.AddScript(String.Format("{0}.setReferenceSchemaUId('{1}')", Page.EntityEdit.ClientID, entitySchemaInWorkspace.UId));
				}
				SchemaId = entitySchemaInWorkspace.UId;
			}
			InitializeFilterEdit();
			Page.EntityDataSource.LoadStructure();
			EntityChangedColumns = null;
			DisplayEntityChangedColumns();
			Page.HasFilterButton.Enabled = !Page.EntitySchemaEdit.Value.Equals(Guid.Empty);
			IsSchemaEntityChanged = true;
			return true;
		}

		public virtual bool ProcessNoAnswer_ScriptTaskExecute(ProcessExecutingContext context) {
			// TODO #170738 
				var entitySchemaInWorkspace = GetVwSysEntitySchema("UId", Page.EntityDataSource.SchemaUId);
			if (entitySchemaInWorkspace != null) {
				Page.EntitySchemaEdit.SetValueAndText(entitySchemaInWorkspace.UId, entitySchemaInWorkspace.Caption);
			}
				
			Page.HasChangedAnyColumnButton.Enabled = !Page.EntitySchemaEdit.Value.Equals(Guid.Empty);
			Page.HasFilterButton.Enabled = !Page.EntitySchemaEdit.Value.Equals(Guid.Empty);
				
				return true;
		}

		public virtual bool ProcessSave_ScriptTaskExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.CaptionEdit.Text;
			var schema = FindDesignedProcessSchema();
			var signal = (IProcessSchemaSignalEvent)schema.GetBaseElementByUId(EditElementUId);
			
			signal.Caption.Value = Page.CaptionEdit.Text;
			signal.WaitingRandomSignal = Page.WaitRandomSignalButton.Checked;
			signal.Signal = Page.SignalEdit.Text;
			signal.WaitingEntitySignal = Page.WaitEntitySignalButton.Checked;
			signal.EntitySchemaUId = Page.EntityDataSource.SchemaUId;
			EntityChangeType entitySignal;
			if (Enum.TryParse<EntityChangeType>(Page.EventEdit.SelectedItem.Value, out entitySignal)) { 
				signal.EntitySignal = entitySignal;
			}
			var intermediateCatchSignalEvent = signal as ProcessSchemaIntermediateCatchSignalEvent;
			if (intermediateCatchSignalEvent != null) {
				ProcessSchemaParameter recordId = intermediateCatchSignalEvent.Parameters.GetByName("RecordId");
				recordId.SourceValue = (ProcessSchemaParameterValue)Page.EntityEdit.Value;
				recordId.SourceValue.ModifiedInSchemaUId = schema.UId;
			}
			signal.HasEntityColumnChange = Page.HasChangedAnyColumnButton.Checked;
			signal.HasEntityFilters = Page.HasFilterButton.Checked;
			signal.EntityChangedColumns = (Collection<string>)EntityChangedColumns;
			var entityFilters = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			IsParametersValid = true;
			if (signal.HasEntityFilters) {
				IsParametersValid = entityFilters.Count != 0 && !entityFilters.IsAnyLeftExpressionNullOrEmpty();
			}
			if (!IsParametersValid) {
				Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessageTextFilterParamsEmpty, MessageType.Warning);
			}
			isShowWarningEmptyFilter = true;
			if (Page.HasFilterButton.Checked) {
				if (entityFilters.IsEnabled && IsEnabledAnyFilter(entityFilters)) {
					isShowWarningEmptyFilter = false;
				}
			}
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
			signal.EntityFilters =  Json.Serialize(entityFilters, jsonConverter);
			schema.SchemaManager.SaveDesignedItemInSessionData(UserConnection, schema, schema.UId);
			return true;
		}

		public virtual bool PrepareQuestionPage_ScriptTask2Execute(ProcessExecutingContext context) {
			ShowWarningEmptyFiltersUserTask.Page = Page;
			ShowWarningEmptyFiltersUserTask.MessageText = WarningEmptyFilters;
			ShowWarningEmptyFiltersUserTask.Icon = "QUESTION";
			ShowWarningEmptyFiltersUserTask.Buttons = "YESNO";
			ShowWarningEmptyFiltersUserTask.ResponseMessages = new Dictionary<string, string> {
				{"yes", "YESCloseEditPage"},
				{"no", "NOCloseEditPage"},
			};
			return true;
		}

		public virtual bool ScriptTask8Execute(ProcessExecutingContext context) {
			if (SchemaId.Equals(Guid.Empty)) {
				if (!IsProcessSchemaStartSignalEvent) {
					Page.EntityEdit.Required = false;
					Page.EntityEdit.Enabled = false;
				}
				Page.HasChangedAnyColumnButton.Checked = false;
				Page.HasChangedAnyColumnButton.Enabled = false;
				Page.HasFilterButton.Checked = false;
				Page.HasFilterButton.Enabled = false;
				Page.ControlLayout4.Enabled = false;
			}
			else {
				Page.ControlLayout4.Enabled = true;
				Page.HasFilterButton.Enabled = true;
				Page.FilterEdit.Enabled = Page.HasFilterButton.Checked;
				if (Page.EventEdit.SelectedItem.Value == EntityChangeType.Inserted.ToString() ||
						Page.EventEdit.SelectedItem.Value == EntityChangeType.Deleted.ToString()) {
					if (!IsProcessSchemaStartSignalEvent) {
						Page.EntityEdit.Required = true;
						Page.EntityEdit.Enabled = true;
					}
					Page.ControlLayout6.Enabled = false;
					Page.HasChangedAnyColumnButton.Checked = false;
					Page.HasChangedAnyColumnButton.Enabled = false;
				} else {
					if (!IsProcessSchemaStartSignalEvent) {
						Page.EntityEdit.Enabled = true;
						Page.EntityEdit.Required = true;
					}
					Page.HasChangedAnyColumnButton.Enabled = true;
					Page.ControlLayout6.Enabled = true;
				}
			}
			return true;
		}

		public virtual bool ScriptTask7Execute(ProcessExecutingContext context) {
			SetEntityChangedControls(Page.HasChangedAnyColumnButton.Checked);
			return true;
		}

		public virtual bool ScriptTask6Execute(ProcessExecutingContext context) {
			Page.FilterEdit.Enabled = Page.HasFilterButton.Checked;
			return true;
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			// Lagacy behavior can break smth if removed
			Page.WaitRandomSignalButton.Checked = !Page.WaitEntitySignalButton.Checked;
			
			Page.SignalEdit.Enabled = !Page.WaitEntitySignalButton.Checked;
			
			var schema = FindDesignedProcessSchema();
			var signal = schema.GetBaseElementByUId(EditElementUId);
			
			Page.EntitySchemaEdit.SetRequired(Page.WaitEntitySignalButton.Checked);
			
			if (!IsProcessSchemaStartSignalEvent) {
				Page.EventEdit.SetRequired(Page.WaitEntitySignalButton.Checked);
				Page.EntityEdit.SetRequired(Page.WaitEntitySignalButton.Checked);
			}
			
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			// Lagacy behavior can break smth if removed
			Page.WaitEntitySignalButton.Checked = !Page.WaitRandomSignalButton.Checked;
			
			Page.ControlLayout7.Enabled = !Page.WaitRandomSignalButton.Checked;
			
			Page.HasChangedAnyColumnButton.Enabled = !Page.EntitySchemaEdit.Value.Equals(Guid.Empty);
			Page.HasFilterButton.Enabled = !Page.EntitySchemaEdit.Value.Equals(Guid.Empty);
			SetEntityChangedControls(Page.HasChangedAnyColumnButton.Checked);
			Page.FilterEdit.Enabled = !Page.WaitRandomSignalButton.Checked && Page.HasFilterButton.Checked;
			Page.EntityChangedColumnGrid.Enabled = !Page.WaitRandomSignalButton.Checked && Page.HasChangedAnyColumnButton.Checked;
			
			Page.SignalEdit.SetRequired(Page.WaitRandomSignalButton.Checked);
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			if (!EntitySchemaColumnExplorerCreated) {
				CreateEntitySchemaColumnExplorer();
			}
			
			EntitySchemaKind schemaKind = Page.EntityDataSource.SchemaKind;
			
			var structureExplorer = EntitySchemaColumnExplorer as UIControls.StructureExplorer;
			
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(Page.EntityDataSource.Schema.UId);
			
			var columns = new DataSourceStructureColumnCollection();
			
			var entityChangedColumns = EntityChangedColumns as Collection<string>;
			
			if (entityChangedColumns != null) {
				foreach (var column in entityChangedColumns) {
					columns.Add(Page.EntityDataSource.DefStructure.CreateColumn(entitySchema, column));
				}
			}
			
			structureExplorer.Columns = columns;
			
			structureExplorer.ShowEditWindow(Page.EntityDataSource.SchemaUId, null, schemaKind);
			
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			
			var entityChangedColumns = EntityChangedColumns as Collection<string>;
			
			foreach (var node in Page.EntityChangedColumnGrid.SelectedNodes) {
				entityChangedColumns.Remove(node.Values["MetaPath"].ToString());
			}
			
			DisplayEntityChangedColumns();
			
			return true;
		}

		public virtual bool Init_ScriptTaskExecute(ProcessExecutingContext context) {
			IEnumerable<Guid> packageIds = Terrasoft.Core.Packages.WorkspaceUtilities.GetPackageHierarchyIds(UserConnection, FindDesignedProcessSchema().PackageUId,
				UserConnection.Workspace.Id);
			object[] objectPackageIds = packageIds.Cast<object>().ToArray();
			var packageIdFilter = new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.Equal},
				{"leftExpressionColumnPath", "SysPackage"},
				{"useDisplayValue", false},
				{"rightExpressionParameterValues", objectPackageIds}
			};
			var managerNameFilter = new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.Equal},
				{"leftExpressionColumnPath", "ManagerName"},
				{"useDisplayValue", false},
				{"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}
			};
			var extendParentFilter = new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.Equal},
				{"leftExpressionColumnPath", "ExtendParent"},
				{"useDisplayValue", false},
				{"rightExpressionParameterValues", new object[] {false}}
			};
			Page.EntitySchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(packageIdFilter);
				filters.Add(managerNameFilter);
				filters.Add(extendParentFilter);
			};
			CreateEntityChangedColumnVds();
			var schema = FindDesignedProcessSchema();
			var signal = (IProcessSchemaSignalEvent)schema.GetBaseElementByUId(EditElementUId);
			IsProcessSchemaStartSignalEvent = signal is ProcessSchemaStartSignalEvent;
			if (Ext.IsAjaxRequest && EntitySchemaColumnExplorerCreated) {
				CreateEntitySchemaColumnExplorer();
			}
			return true;
		}

		public virtual bool AddFilterEntitySchema_ScriptTaskExecute(ProcessExecutingContext context) {
			/*var packageUIdFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "SysPackageUId"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {FindDesignedProcessSchema().PackageUId}}};
			var workspaceUIdFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "SysWorkspace"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {UserConnection.Workspace.Id}}};
			var extendParentFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "ExtendParent"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {false}}};
			Page.EntitySchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(packageUIdFilter);
				filters.Add(workspaceUIdFilter);
				filters.Add(extendParentFilter);
			};*/
			return true;
		}

		public virtual bool ProcessPageLoadComplete_ScriptTaskExecute(ProcessExecutingContext context) {
			var schema = FindDesignedProcessSchema();
			var signal = (IProcessSchemaSignalEvent)schema.GetBaseElementByUId(EditElementUId);
			IsProcessSchemaStartSignalEvent = signal is ProcessSchemaStartSignalEvent;
			
			if (IsProcessSchemaStartSignalEvent) {
				Page.FilterEdit.AggregationEnable = false;
				Page.FilterEdit.IsColumnsExplorerRootMode = true;
			} else {
				Page.FilterEdit.SetProcessSchema(schema);
			}
			Page.CaptionEdit.Text = signal.Caption;
			Page.WaitRandomSignalButton.SetValue(signal.WaitingRandomSignal);
			Page.SignalEdit.Text = signal.Signal;
			Page.SignalEdit.Enabled = signal.WaitingRandomSignal;
			Page.WaitEntitySignalButton.SetValue(signal.WaitingEntitySignal);
			Page.HasChangedAnyColumnButton.SetValue(signal.HasEntityColumnChange);
			SetEntityChangedControls(signal.HasEntityColumnChange);
			Page.HasFilterButton.SetValue(signal.HasEntityFilters);
			Page.ControlLayout7.Enabled = signal.WaitingEntitySignal;
			var lookupDvt = (DataValueType)UserConnection.DataValueTypeManager.GetItemByName("Lookup").Instance;
			ProcessSchemaParameterValue entityEditValue = Page.EntityEdit.ParameterValue;
			entityEditValue.DataValueType = lookupDvt;
			entityEditValue.ReferenceSchemaUId = signal.EntitySchemaUId;
			entityEditValue.SchemaUId = EditSchemaUId;
			entityEditValue.SchemaManagerName = EditSchemaManagerName;
			Page.EntityEdit.Value = entityEditValue;
			if (!signal.EntitySchemaUId.IsEmpty()) {
				SchemaId = signal.EntitySchemaUId;
			
				// TODO #170738 
				var entitySchemaInWorkspace = GetVwSysEntitySchema("UId", signal.EntitySchemaUId);
				if (entitySchemaInWorkspace != null) {
					Page.EntitySchemaEdit.SetValueAndText(entitySchemaInWorkspace.UId, entitySchemaInWorkspace.Caption);
					Page.EntityDataSource.SchemaUId = entitySchemaInWorkspace.UId;
					var filters = signal.EntityFilters;
					if (!String.IsNullOrEmpty(filters)) {		
						var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
						var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;
						if (filterCollection != null) {
							var existingFilterCollection = Page.EntityDataSource.CurrentStructure.Filters.FindByName(filterCollection.Name) as DataSourceFilterCollection;
							if (existingFilterCollection != null) {
								existingFilterCollection.Clear();
								foreach (var filterItem in filterCollection) {
									existingFilterCollection.Add(filterItem);
								}
								existingFilterCollection.LogicalOperation = filterCollection.LogicalOperation;
								existingFilterCollection.IsEnabled = filterCollection.IsEnabled;
								existingFilterCollection.IsNot = filterCollection.IsNot;
							} else {
								Page.EntityDataSource.CurrentStructure.Filters.Add(filterCollection);
							}
						}
					}
					EntityDataSourceUtilities.InitializeAutoDefStructure(Page.EntityDataSource);
					InitializeFilterEdit();
					Page.EntityDataSource.LoadStructure();
				}
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(signal.EntitySchemaUId);
				var entity = new Entity(UserConnection) {
					Schema = entitySchema
				};
				var intermediateCatchSignalEvent = signal as ProcessSchemaIntermediateCatchSignalEvent;
				if (intermediateCatchSignalEvent != null) {
					ProcessSchemaParameter recordId = intermediateCatchSignalEvent.Parameters.GetByName("RecordId");
					var paramValue = recordId.SourceValue;
					paramValue.DataValueType = lookupDvt;
					paramValue.ReferenceSchemaUId = signal.EntitySchemaUId;
					paramValue.SchemaUId = EditSchemaUId;
					paramValue.SchemaManagerName = EditSchemaManagerName;
					Page.EntityEdit.ParameterValue = paramValue;
					if (!string.IsNullOrEmpty(paramValue.Value) && paramValue.Source == ProcessSchemaParameterValueSource.ConstValue) {
						if (new Guid(paramValue.Value) != Guid.Empty 
								&& entity.FetchFromDB(
									entitySchema.PrimaryColumn, 
									new Guid(paramValue.Value))) {
							var entityIdFilter = Page.EntityDataSource.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", entity.PrimaryColumnValue);
							entityIdFilter.Name = "Id";
							Page.EntityDataSource.DefStructure.Filters.Add(entityIdFilter);
							Page.EntityDataSource.LoadRows();
						}
					}
				}
			}
			if (IsProcessSchemaStartSignalEvent) {
				Page.EntityEdit.Visible = false;
				var insertEventItem = new UIControls.ListItem(InsertedDataEventCaption, EntityChangeType.Inserted.ToString());
				Page.EventEdit.Items.Add(insertEventItem);
			} else {
				Page.EntityEdit.Visible = true;
			}
			var updatedEventItem = new UIControls.ListItem(UpdatedDataEventCaption, EntityChangeType.Updated.ToString());
			var deletedEventItem = new UIControls.ListItem(DeletedDataEventCaption, EntityChangeType.Deleted.ToString());
			Page.EventEdit.Items.Add(updatedEventItem);
			Page.EventEdit.Items.Add(deletedEventItem);
			Page.EventEdit.SelectedItem.Value = signal.EntitySignal.ToString();
			Page.EventEdit.Visible = true;
			EntityChangedColumns = signal.EntityChangedColumns;
			DisplayEntityChangedColumns();
			if (signal.WaitingRandomSignal) {
				Page.ScriptManager.AddScript("Terrasoft.AjaxMethods.ThrowClientEvent('" + ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString() + Page.PageContainer.UniqueID + "', 'WaitRandomSignalButtonCheck');");
			}
			if (signal.WaitingEntitySignal) {
				Page.ScriptManager.AddScript("Terrasoft.AjaxMethods.ThrowClientEvent('" + ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString() + Page.PageContainer.UniqueID + "', 'WaitEntitySignalButtonCheck');");
				Page.ScriptManager.AddScript("Terrasoft.AjaxMethods.ThrowClientEvent('" + ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString() + Page.PageContainer.UniqueID + "', 'EventEditChange');");
			}
			return true;
		}

		public virtual bool SetPageCaption_ScriptTaskExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = PageCaption;
			
			return true;
		}

		public virtual bool SubscribeClientEventsScriptTaskExecute(ProcessExecutingContext context) {
			string onFocusScript = @"{0}.on('focus', function(s, e) {{
				if (!{1}.checked) {{
					{1}.setValue(true);
				}}
			}}, this);";
			
			// Random signal
			Page.AddScript(String.Format(onFocusScript,
				Page.SignalEdit.ClientID, Page.WaitRandomSignalButton.ClientID));
				
			// Entity signal
			Page.AddScript(String.Format(onFocusScript,
				Page.EntitySchemaEdit.ClientID, Page.WaitEntitySignalButton.ClientID));
			if (!IsProcessSchemaStartSignalEvent) {
				Page.AddScript(String.Format(onFocusScript,
					Page.EventEdit.ClientID, Page.WaitEntitySignalButton.ClientID));
				Page.AddScript(String.Format(onFocusScript,
					Page.EntityEdit.ClientID, Page.WaitEntitySignalButton.ClientID));
			}
			return true;
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.CaptionEdit.Text) ?
				string.Format("{0} ({1})", WindowCaption, NewRecord) : Page.CaptionEdit.Text;
		}

		public virtual void CreateEntitySchemaColumnExplorer() {
			var structureExplorer = new UIControls.StructureExplorer(Page.TopControlLayout, "columns", true, true, "22");
			EntitySchemaColumnExplorer = structureExplorer;
			var editComplete = structureExplorer.AjaxEvents.EditComplete;
			structureExplorer.ExcludeDataValueTypes = new string[] { "Guid", "Binary", "File", "Image", "Color" };
			editComplete.Event += new UIControls.AjaxEventHandler(HandleEditComplete);
			editComplete.ExtraParameters.Add(new UIControls.Parameter("columnsInfo", "itemsInfo", UIControls.ParameterMode.Raw));
			EntitySchemaColumnExplorerCreated = true;
			structureExplorer.IsShowSystemColumns = false;
			structureExplorer.IsShowOppositeReference = false;
			structureExplorer.IsShowSystemReference = false;
			if (!EntitySchemaColumnExplorerRegistered) {
				structureExplorer.Register();
				EntitySchemaColumnExplorerRegistered = true;
			}
		}

		public virtual void HandleEditComplete(object sender, AjaxEventArgs e) {
			var columns = Json.Deserialize(e.ExtraParameters["columnsInfo"]) as JArray;
			var entityChangedColumns = new Collection<string>();
			foreach(var column in columns) {
				entityChangedColumns.Add(column["metaPath"].ToString());
			}
			EntityChangedColumns = entityChangedColumns;
			DisplayEntityChangedColumns();
		}

		public virtual void InitializeFilterEdit() {
			EntityDataSource dataSource = Page.EntityDataSource;
			
			if (Guid.Empty.Equals(dataSource.SchemaUId)) {
				return;
			}
			var filterEditGroup = dataSource.FindFiltersGroupByName("FilterEdit");
			
			if (filterEditGroup == null) {
				filterEditGroup = dataSource.CreateFiltersGroup("FilterEdit");
				dataSource.CurrentStructure.Filters.Add(filterEditGroup);
			}
			
			Page.FilterEdit.SetDataSource(dataSource);
		}

		public virtual void DisplayEntityChangedColumns() {
			var vds = Page.PageContainer.FindControl("EntityChangedColumnVds") as VirtualDataSource;
			vds.Clear();
			var entityChangedColumns = EntityChangedColumns as Collection<string>;
			if (entityChangedColumns == null) {
				return;
			}
			if (SchemaId != Guid.Empty) {
				EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByUId(SchemaId);
				foreach (var columnMetaPath in entityChangedColumns) {
					Entity row = vds.CreateRow();
					row.SetColumnValue("Id", Guid.NewGuid());
					row.SetColumnValue("MetaPath", columnMetaPath);
					row.SetColumnValue("Name", schema.GetSchemaColumnByMetaPath(columnMetaPath).Caption);
					vds.Add(row);
				}
			}
			vds.LoadRows();
		}

		public virtual void CreateEntityChangedColumnVds() {
			var vds = new VirtualDataSource() {
				ID = "EntityChangedColumnVds"
			};
			
			Page.PageContainer.Controls.Add(vds);
			
			Page.EntityChangedColumnGrid.DataSourceId = vds.ID;
			
			var vdsStructure = vds.DefStructure;
			
			vdsStructure.PrimaryColumnName = "Id";
			
			vdsStructure.PrimaryDisplayColumnName = "Name";
			
			var guidDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Guid");
			var maxSizeTextDvt = UserConnection.DataValueTypeManager.GetInstanceByName("MaxSizeText");
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Id",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = guidDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "MetaPath",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Name",
				Caption = ColumnNameCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
		}

		public virtual void EntityEdit_ShowMappingWindow(object sender, AjaxEventArgs e) {
			ParameterDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("Lookup").UId;
			IsParameterLookup = true;
			ParameterReferenceSchemaUId = SchemaId;
			InitializeSchemaExplorerWindow();
			
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			string handler = string.Empty;
			string handlerReferenceName = string.Format("window.{0}_EditCompleteParameter",
				schemaExplorer.ClientID);
				var sb = new StringBuilder();
				sb.Append("function(columnInfo) {\n");
				sb.Append("var info = Ext.util.JSON.decode(columnInfo);");
				sb.Append("var value = {");
				sb.Append("source: 'Mapping'");
				sb.Append(",value: info.metaPath");
				sb.Append(",displayValue: info.caption");
				sb.Append(",fireEvent: true");
				sb.Append("};");
				//sb.Append("alert(Ext.util.JSON.encode(value));");
				sb.AppendFormat("{0}.setValue(value, true);", Page.EntityEdit.ClientID);//Ext.util.JSON.encode(value)
				//sb.Append("alert('OK!');");
				
				sb.AppendFormat("window.Terrasoft.AjaxMethods.ThrowClientEvent('{0}', 'CloseMappingWindow');", InstanceUId);
				sb.Append("}");
				handler = sb.ToString();
			
			handler = string.Format(@"{0} = {1}", handlerReferenceName, handler);
			Page.ScriptManager.AddScript(string.Format("if ({2}) {{ {0}.un(\"{1}\",{2}); }}", 
				schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			Page.ScriptManager.AddScript(handler);
			Page.ScriptManager.AddScript(string.Format("{0}.on(\"{1}\",{2});", 
				schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			schemaExplorer.ManagerName = EditSchemaManagerName;
			var parameterValue = (Terrasoft.Core.Process.ProcessSchemaParameterValue)Page.EntityEdit.Value;
			if (parameterValue.Source == ProcessSchemaParameterValueSource.Mapping){
				parameterValue.MetaPath = parameterValue.Value;
			}
			schemaExplorer.ShowEditWindow(EditSchemaUId, parameterValue.MetaPath, EditElementUId);
		}

		public virtual object[] GetEntityIdsWithOutPrcListenersColumn() {
			var manager = UserConnection.EntitySchemaManager;
			var columnName = UserConnection.IProcessEngine.ProcessListenersColumnName;
			var result = new List<object>();
			foreach (var schema in manager.GetItems()) {
				var entitySchema = manager.GetInstanceByUId(schema.UId);
				if(entitySchema.Columns.FindByName(columnName) == null) {
					result.Add(schema.UId);
				}
			}
			
			return result.ToArray();
		}

		public virtual object[] GetEntityIdCollection() {
			if (EntityIdCollection == null) {	
				EntityIdCollection = GetEntityIdsWithOutPrcListenersColumn();
			}
			
			return (object[])EntityIdCollection;
		}

		public virtual VwSysEntitySchemaInWorkspace GetVwSysEntitySchema(string columnName, Guid value) {
			// TODO #170738 Конфигурация: Реализовать функционал, который использует вид VwSysEntitySchemaInWorkspace, в схеме IntermediateCatchSignalParametersEditPage
			var result = new VwSysEntitySchemaInWorkspace(UserConnection);
			
			var esq = new EntitySchemaQuery(result.Schema);
			var columnId = esq.AddColumn("Id");
			var columnCaption = esq.AddColumn("Caption");
			var columnSysSchemaId = esq.AddColumn("UId");
			var filterId = esq.CreateFilterWithParameters(FilterComparisonType.Equal, 
				columnName, 
				value);
			var filterSysWorkspace = esq.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysWorkspace", 
				UserConnection.Workspace.Id);	
			esq.Filters.Add(filterId);
			esq.Filters.Add(filterSysWorkspace);  
			var list = esq.GetEntityCollection(UserConnection);
			if (list != null && list.Count > 0) {
				var item = list[0];
				result.SetColumnValue("Id", item.GetTypedColumnValue<Guid>(columnId.Name)); 
				result.SetColumnValue("Caption", item.GetTypedColumnValue<string>(columnCaption.Name)); 
				result.SetColumnValue("UId", item.GetTypedColumnValue<Guid>(columnSysSchemaId.Name)); 
			}
			else {
				result = null;
			}
			return result;
		}

		public virtual void SetEntityChangedControls(bool enabled) {
			Page.Columns_ControlLayout.Enabled = enabled;
			Page.AddColumnButton.Enabled = enabled;
			Page.RemoveColumnButton.Enabled = enabled;
			Page.EntityChangedColumnGrid.Enabled = enabled;
		}

		public virtual bool IsEnabledAnyFilter(DataSourceFilterCollection entityFilters) {
			foreach (var item in entityFilters) {
				if (!item.IsEnabled) {
					continue;
				}
				var filtersGroup = item as DataSourceFilterCollection;
				if (filtersGroup == null || IsEnabledAnyFilter(filtersGroup)) {
					return true;
				}
			}
			return false;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EntitySchemaEditChange":
							if (ActivatedEventElements.Contains("EntitySchemaEditChange_StartMessage")) {
							context.QueueTasks.Enqueue("EntitySchemaEditChange_StartMessage");
						}
						break;
					case "YESEntitySchemaEditChange":
							if (ActivatedEventElements.Contains("YESEntitySchemaEditChange_StartMessage")) {
							context.QueueTasks.Enqueue("YESEntitySchemaEditChange_StartMessage");
						}
						break;
					case "NOEntitySchemaEditChange":
							if (ActivatedEventElements.Contains("NOEntitySchemaEditChange_StartMessage")) {
							context.QueueTasks.Enqueue("NOEntitySchemaEditChange_StartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("StartMessage8")) {
							context.QueueTasks.Enqueue("StartMessage8");
							ProcessQueue(context);
							return;
						}
						break;
					case "YESCloseEditPage":
							if (ActivatedEventElements.Contains("YESCloseEditPage_StartMessage")) {
							context.QueueTasks.Enqueue("YESCloseEditPage_StartMessage");
						}
						break;
					case "EventEditChange":
							if (ActivatedEventElements.Contains("EventEditChange_StartMessage")) {
							context.QueueTasks.Enqueue("EventEditChange_StartMessage");
						}
						break;
					case "HasChangedAnyColumnButtonCheck":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
						}
						break;
					case "HasFilterButtonCheck":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
						}
						break;
					case "WaitEntitySignalButtonCheck":
							if (ActivatedEventElements.Contains("WaitEntitySignalButtonCheck_StartMessage")) {
							context.QueueTasks.Enqueue("WaitEntitySignalButtonCheck_StartMessage");
						}
						break;
					case "WaitRandomSignalButtonCheck":
							if (ActivatedEventElements.Contains("WaitRandomSignalButtonCheck_StartMessage")) {
							context.QueueTasks.Enqueue("WaitRandomSignalButtonCheck_StartMessage");
						}
						break;
					case "AddColumnButtonClick":
							if (ActivatedEventElements.Contains("AddColumnButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("AddColumnButtonClickStartMessage");
						}
						break;
					case "RemoveColumnButtonClick":
							if (ActivatedEventElements.Contains("RemoveColumnButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("RemoveColumnButtonClickStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage7")) {
							context.QueueTasks.Enqueue("StartMessage7");
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
			if (!HasMapping("IsParametersValid") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsParametersValid", IsParametersValid, false);
			}
			if (!HasMapping("IsProcessSchemaStartSignalEvent") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsProcessSchemaStartSignalEvent", IsProcessSchemaStartSignalEvent, false);
			}
			if (EntityIdCollection != null) {
				if (EntityIdCollection.GetType().IsSerializable ||
					EntityIdCollection.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EntityIdCollection", EntityIdCollection, null);
				}
			}
			if (ParameterExplorerId != null) {
				if (ParameterExplorerId.GetType().IsSerializable ||
					ParameterExplorerId.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ParameterExplorerId", ParameterExplorerId, null);
				}
			}
			if (ParameterExplorer != null) {
				if (ParameterExplorer.GetType().IsSerializable ||
					ParameterExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ParameterExplorer", ParameterExplorer, null);
				}
			}
			if (!HasMapping("IsParameterExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsParameterExplorerCreated", IsParameterExplorerCreated, false);
			}
			if (!HasMapping("SchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SchemaId", SchemaId, Guid.Empty);
			}
			if (!HasMapping("IsSchemaEntityChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSchemaEntityChanged", IsSchemaEntityChanged, false);
			}
			if (!HasMapping("SelectedEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedEntitySchemaId", SelectedEntitySchemaId, Guid.Empty);
			}
			if (EntityChangedColumns != null) {
				if (EntityChangedColumns.GetType().IsSerializable ||
					EntityChangedColumns.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EntityChangedColumns", EntityChangedColumns, null);
				}
			}
			if (!HasMapping("EntitySchemaColumnExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaColumnExplorerRegistered", EntitySchemaColumnExplorerRegistered, false);
			}
			if (!HasMapping("EntitySchemaColumnExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaColumnExplorerCreated", EntitySchemaColumnExplorerCreated, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: IntermediateCatchSignalParametersEditPageEventsProcess

	/// <exclude/>
	public class IntermediateCatchSignalParametersEditPageEventsProcess : IntermediateCatchSignalParametersEditPageEventsProcess<Terrasoft.WebApp.IntermediateCatchSignalParametersEditPageSchemaUserControl>
	{

		public IntermediateCatchSignalParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IntermediateCatchSignalParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class IntermediateCatchSignalParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("EntityDataSource", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton WaitRandomSignalButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("WaitRandomSignalButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout9", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SignalEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SignalEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton WaitEntitySignalButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("WaitEntitySignalButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout7", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("EntitySchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit EventEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("EventEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EntityEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("EntityEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout8 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout8", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox HasFilterButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("HasFilterButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout Filter_ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("Filter_ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("FilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout6", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox HasChangedAnyColumnButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("HasChangedAnyColumnButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout Columns_ControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("Columns_ControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddColumnButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddColumnButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button RemoveColumnButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("RemoveColumnButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid EntityChangedColumnGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("EntityChangedColumnGrid", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			WaitRandomSignalButton.AjaxEvents.Check.Event += WaitRandomSignalButtonCheck;
			WaitEntitySignalButton.AjaxEvents.Check.Event += WaitEntitySignalButtonCheck;
			EntitySchemaEdit.AjaxEvents.Change.Event += EntitySchemaEditChange;
			EventEdit.AjaxEvents.Change.Event += EventEditChange;
			HasFilterButton.AjaxEvents.Check.Event += HasFilterButtonCheck;
			HasChangedAnyColumnButton.AjaxEvents.Check.Event += HasChangedAnyColumnButtonCheck;
			AddColumnButton.AjaxEvents.Click.Event += AddColumnButtonClick;
			RemoveColumnButton.AjaxEvents.Click.Event += RemoveColumnButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			WaitRandomSignalButton.AjaxEvents.Check.Event -= WaitRandomSignalButtonCheck;
			WaitEntitySignalButton.AjaxEvents.Check.Event -= WaitEntitySignalButtonCheck;
			EntitySchemaEdit.AjaxEvents.Change.Event -= EntitySchemaEditChange;
			EventEdit.AjaxEvents.Change.Event -= EventEditChange;
			HasFilterButton.AjaxEvents.Check.Event -= HasFilterButtonCheck;
			HasChangedAnyColumnButton.AjaxEvents.Check.Event -= HasChangedAnyColumnButtonCheck;
			AddColumnButton.AjaxEvents.Click.Event -= AddColumnButtonClick;
			RemoveColumnButton.AjaxEvents.Click.Event -= RemoveColumnButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (IntermediateCatchSignalParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new IntermediateCatchSignalParametersEditPageEventsProcess(UserConnection);
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

		public virtual void WaitRandomSignalButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("WaitRandomSignalButtonCheck");
		}

		public virtual void WaitEntitySignalButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("WaitEntitySignalButtonCheck");
		}

		public virtual void EntitySchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("EntitySchemaEditChange");
		}

		public virtual void EventEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("EventEditChange");
		}

		public virtual void HasFilterButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("HasFilterButtonCheck");
		}

		public virtual void HasChangedAnyColumnButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("HasChangedAnyColumnButtonCheck");
		}

		public virtual void AddColumnButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddColumnButtonClick");
		}

		public virtual void RemoveColumnButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("RemoveColumnButtonClick");
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
			SchemaName = "IntermediateCatchSignalParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: IntermediateCatchSignalParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class IntermediateCatchSignalParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public IntermediateCatchSignalParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public IntermediateCatchSignalParametersEditPageEventsProcessSchema(IntermediateCatchSignalParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "IntermediateCatchSignalParametersEditPageEventsProcess";
			UId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreatePropertyDataSourceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e7fe8054-e33d-4fa1-add5-d1b1957d18b7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"PropertyDataSource",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaColumnExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0bbcc00b-542f-4bbc-887a-d3fe983ccd94"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EntitySchemaColumnExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaColumnExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fc08646b-bfc8-44b0-b99f-8ca2b2c17550"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EntitySchemaColumnExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaColumnExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b867bfb4-d9d7-4924-a0c6-0d449516b4c9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EntitySchemaColumnExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityChangedColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("aefbba11-3cb2-422a-a3d5-f003c839e065"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EntityChangedColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be29d35f-027b-4f38-a7d0-391ef2cee255"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"SelectedEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSchemaEntityChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("358b8efe-9524-490e-8fe3-d428c6574df3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"IsSchemaEntityChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("223acb8e-5d9c-40fd-9046-0094b41276e4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"SchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsParameterExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6246ca70-b0ea-41e6-a8b3-b84eb01f8ebd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"IsParameterExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParameterExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("652b6cba-099a-449c-a9ea-e2d4824eb67f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ParameterExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParameterExplorerIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1eb606dc-94e0-4dc7-a90c-22d5d056e90c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ParameterExplorerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityIdCollectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fb66e0c8-72a6-46f5-b325-e667b4848fa1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EntityIdCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsProcessSchemaStartSignalEventParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("87c0d752-c7b8-4cea-a8e7-379d286554b3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"IsProcessSchemaStartSignalEvent",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsParametersValidParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8827a9d6-3087-4eb1-ab16-8f9ee252fda6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"IsParametersValid",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateisShowWarningEmptyFilterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02de8faa-7f34-490c-ab2a-f3f0f190dfe3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"isShowWarningEmptyFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaColumnExplorerCreatedParameter());
			Parameters.Add(CreateEntitySchemaColumnExplorerRegisteredParameter());
			Parameters.Add(CreateEntitySchemaColumnExplorerParameter());
			Parameters.Add(CreateEntityChangedColumnsParameter());
			Parameters.Add(CreateSelectedEntitySchemaIdParameter());
			Parameters.Add(CreateIsSchemaEntityChangedParameter());
			Parameters.Add(CreateSchemaIdParameter());
			Parameters.Add(CreateIsParameterExplorerCreatedParameter());
			Parameters.Add(CreateParameterExplorerParameter());
			Parameters.Add(CreateParameterExplorerIdParameter());
			Parameters.Add(CreateEntityIdCollectionParameter());
			Parameters.Add(CreateIsProcessSchemaStartSignalEventParameter());
			Parameters.Add(CreateIsParametersValidParameter());
			Parameters.Add(CreateisShowWarningEmptyFilterParameter());
		}

		protected virtual void InitializeShowChangeEntitySchemaMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c29874e0-b875-4a5a-a5e7-eea677b5fe82"),
				ContainerUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
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
				UId = new Guid("06eeba88-96af-42c4-871a-1e99cf21f306"),
				ContainerUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
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
				UId = new Guid("0c44cd4b-ea43-40a8-b4fd-aa10be68f7de"),
				ContainerUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
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
				UId = new Guid("33b22c62-cfbd-4231-b588-3d036bb58970"),
				ContainerUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
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
				UId = new Guid("7c97d16a-8922-4b27-bf4b-ebfc853021d1"),
				ContainerUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
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
				UId = new Guid("29367bf8-bb3d-441b-8985-569975575058"),
				ContainerUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
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
				UId = new Guid("3eafdb42-03eb-45e0-a2cf-3f3da4384265"),
				ContainerUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
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
				UId = new Guid("fe8accdb-6948-49a9-94df-ed15864faf50"),
				ContainerUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
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

		protected virtual void InitializeShowWarningEmptyFiltersUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("269ff8e9-11bb-4803-9eb3-3f6b7bfef104"),
				ContainerUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
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
				UId = new Guid("f493cac7-676f-422f-88d8-1a06d572dba2"),
				ContainerUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
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
				UId = new Guid("23f92b49-b597-4e28-b677-c0d27b157a2d"),
				ContainerUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
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
				UId = new Guid("f6aff619-cdad-42e6-aac7-f8cd253c1299"),
				ContainerUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
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
				UId = new Guid("ece97e40-ffc7-4c15-aa37-af55bb96ee94"),
				ContainerUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
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
				UId = new Guid("d861a3aa-3123-4976-9828-f77c7282e6e2"),
				ContainerUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
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
				UId = new Guid("c5d816e9-04dd-4518-b8c4-abd46b726c3c"),
				ContainerUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
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
				UId = new Guid("34a361c9-92de-49a7-9df9-f5a693f6ba35"),
				ContainerUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
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
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess14 = CreateEventSubProcess14EventSubProcess();
			FlowElements.Add(eventsubprocess14);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess16 = CreateEventSubProcess16EventSubProcess();
			FlowElements.Add(eventsubprocess16);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaStartMessageEvent entityschemaeditchange_startmessage = CreateEntitySchemaEditChange_StartMessageStartMessageEvent();
			eventsubprocess12.FlowElements.Add(entityschemaeditchange_startmessage);
			ProcessSchemaUserTask showchangeentityschemamessageusertask = CreateShowChangeEntitySchemaMessageUserTaskUserTask();
			eventsubprocess12.FlowElements.Add(showchangeentityschemamessageusertask);
			ProcessSchemaScriptTask preparequestionpage_scripttask = CreatePrepareQuestionPage_ScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(preparequestionpage_scripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess12.FlowElements.Add(exclusivegateway1);
			ProcessSchemaIntermediateThrowMessageEvent entityschemaeditchange_yesentityschemaeditchange_intermediatethrowmessageevent = CreateEntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess12.FlowElements.Add(entityschemaeditchange_yesentityschemaeditchange_intermediatethrowmessageevent);
			ProcessSchemaScriptTask getguid_scripttask = CreateGetGuid_ScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(getguid_scripttask);
			ProcessSchemaStartMessageEvent yesentityschemaeditchange_startmessage = CreateYESEntitySchemaEditChange_StartMessageStartMessageEvent();
			eventsubprocess13.FlowElements.Add(yesentityschemaeditchange_startmessage);
			ProcessSchemaScriptTask processyesanswer_scripttask = CreateProcessYesAnswer_ScriptTaskScriptTask();
			eventsubprocess13.FlowElements.Add(processyesanswer_scripttask);
			ProcessSchemaIntermediateThrowMessageEvent yesentityschemaeditchange_eventeditchange_intermediatethrowmessageevent = CreateYESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess13.FlowElements.Add(yesentityschemaeditchange_eventeditchange_intermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent noentityschemaeditchange_startmessage = CreateNOEntitySchemaEditChange_StartMessageStartMessageEvent();
			eventsubprocess14.FlowElements.Add(noentityschemaeditchange_startmessage);
			ProcessSchemaScriptTask processnoanswer_scripttask = CreateProcessNoAnswer_ScriptTaskScriptTask();
			eventsubprocess14.FlowElements.Add(processnoanswer_scripttask);
			ProcessSchemaStartMessageEvent startmessage8 = CreateStartMessage8StartMessageEvent();
			eventsubprocess11.FlowElements.Add(startmessage8);
			ProcessSchemaScriptTask processsave_scripttask = CreateProcessSave_ScriptTaskScriptTask();
			eventsubprocess11.FlowElements.Add(processsave_scripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess11.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess11.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask preparequestionpage_scripttask2 = CreatePrepareQuestionPage_ScriptTask2ScriptTask();
			eventsubprocess11.FlowElements.Add(preparequestionpage_scripttask2);
			ProcessSchemaUserTask showwarningemptyfiltersusertask = CreateShowWarningEmptyFiltersUserTaskUserTask();
			eventsubprocess11.FlowElements.Add(showwarningemptyfiltersusertask);
			ProcessSchemaStartMessageEvent yescloseeditpage_startmessage = CreateYESCloseEditPage_StartMessageStartMessageEvent();
			eventsubprocess16.FlowElements.Add(yescloseeditpage_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent5 = CreateIntermediateThrowMessageEvent5IntermediateThrowMessageEvent();
			eventsubprocess16.FlowElements.Add(intermediatethrowmessageevent5);
			ProcessSchemaStartMessageEvent eventeditchange_startmessage = CreateEventEditChange_StartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(eventeditchange_startmessage);
			ProcessSchemaScriptTask scripttask8 = CreateScriptTask8ScriptTask();
			eventsubprocess9.FlowElements.Add(scripttask8);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess8.FlowElements.Add(startmessage5);
			ProcessSchemaScriptTask scripttask7 = CreateScriptTask7ScriptTask();
			eventsubprocess8.FlowElements.Add(scripttask7);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess7.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask scripttask6 = CreateScriptTask6ScriptTask();
			eventsubprocess7.FlowElements.Add(scripttask6);
			ProcessSchemaStartMessageEvent waitentitysignalbuttoncheck_startmessage = CreateWaitEntitySignalButtonCheck_StartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(waitentitysignalbuttoncheck_startmessage);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess6.FlowElements.Add(scripttask5);
			ProcessSchemaStartMessageEvent waitrandomsignalbuttoncheck_startmessage = CreateWaitRandomSignalButtonCheck_StartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(waitrandomsignalbuttoncheck_startmessage);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess5.FlowElements.Add(scripttask4);
			ProcessSchemaStartMessageEvent addcolumnbuttonclickstartmessage = CreateAddColumnButtonClickStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(addcolumnbuttonclickstartmessage);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess3.FlowElements.Add(scripttask2);
			ProcessSchemaStartMessageEvent removecolumnbuttonclickstartmessage = CreateRemoveColumnButtonClickStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(removecolumnbuttonclickstartmessage);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask init_scripttask = CreateInit_ScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(init_scripttask);
			ProcessSchemaScriptTask addfilterentityschema_scripttask = CreateAddFilterEntitySchema_ScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(addfilterentityschema_scripttask);
			ProcessSchemaStartMessageEvent startmessage7 = CreateStartMessage7StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage7);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess10.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask processpageloadcomplete_scripttask = CreateProcessPageLoadComplete_ScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(processpageloadcomplete_scripttask);
			ProcessSchemaScriptTask setpagecaption_scripttask = CreateSetPageCaption_ScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(setpagecaption_scripttask);
			ProcessSchemaScriptTask subscribeclienteventsscripttask = CreateSubscribeClientEventsScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(subscribeclienteventsscripttask);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateInsertedDataEventCaptionLocalizableString());
			LocalizableStrings.Add(CreateUpdatedDataEventCaptionLocalizableString());
			LocalizableStrings.Add(CreateDeletedDataEventCaptionLocalizableString());
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
			LocalizableStrings.Add(CreatePageCaptionLocalizableString());
			LocalizableStrings.Add(CreateWarningChangeEntitySchemaOnSaveLocalizableString());
			LocalizableStrings.Add(CreateRadioButtonCaptionLocalizableString());
			LocalizableStrings.Add(CreateColumnNameCaptionLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTextFilterParamsEmptyLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateWarningEmptyFiltersLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateInsertedDataEventCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3a4b9b13-9755-4c6a-80b5-95ad7c30ceb7"),
				Name = "InsertedDataEventCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUpdatedDataEventCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dc664dd9-80a8-4642-a002-24cbcfdd73aa"),
				Name = "UpdatedDataEventCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeletedDataEventCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c386503d-1562-4e0d-a2f3-ac39e3ebb722"),
				Name = "DeletedDataEventCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f82e8fe2-5958-4737-8a4e-48589cf59bb5"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("63d86325-7235-45ca-820f-aaf00caa1f51"),
				Name = "PageCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningChangeEntitySchemaOnSaveLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c5c0119d-0638-4363-b18a-57fa447d270e"),
				Name = "WarningChangeEntitySchemaOnSave",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRadioButtonCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b2c5c0b8-5d9a-478a-95da-e31a33ecb44c"),
				Name = "RadioButtonCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateColumnNameCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("58ab64f7-7b26-4e34-af16-fae96eee57f2"),
				Name = "ColumnNameCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTextFilterParamsEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("54ae6ee5-382b-47b7-a344-0f5f20652ab8"),
				Name = "ValidationMessageTextFilterParamsEmpty",
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("54a25c14-1e67-40cc-9082-3d8dee946098"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarningEmptyFiltersLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("68ddd194-a881-4273-a200-91193b22e3d4"),
				Name = "WarningEmptyFilters",
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("b5515ac9-a7a6-46bc-ad2f-d876121b68e0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6321e4b6-ae0d-4fe0-9ea5-095a626e7893"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("edca4e15-5e49-4582-ade9-cd9ae5884c37"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("dd89d11b-ea23-440a-b987-0298d2e6674a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c97e24f5-3586-4fb9-bff1-ad8f28b2882f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a311af7c-412a-4f65-8cca-f37e79900150"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("dd83ecfc-06f6-4cb3-85c0-079a80bb9edf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("82bfcc94-e9d9-40eb-9cd7-b85df41475e4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9c5a86da-ce68-4dd0-9340-aafc304736f6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("830b232b-6301-438f-8064-3854ddd260c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d32f4367-61c9-4040-b4cb-993a6fb5713f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b99b3c8-a2c9-49e9-95af-3687ff57b9bc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("5bd7d9a5-2510-4b41-9ab9-551c3c125874"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e213262f-dcb4-4182-b5aa-8c9f5c29e0ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6daf2ca8-60c6-4efe-8c60-5dad84e70f2d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("256c1a09-aa41-4039-b0f2-93b9db20fa5f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3906abe7-b830-43ca-8c5e-90f5f43dfb0d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("303d5661-1ae6-46d4-804a-9fc21f7cf0aa"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("5bd318c8-5573-466a-84a0-142e5d15d3fc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("09e44c43-ad07-468e-8917-1fa02cf5b5b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c8130b64-0246-4cec-9cf8-122ea3c3156d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("4f5d01f1-1ddf-409e-94de-1822745e63ce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(166, 480),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a9ce2af7-d828-4cf2-8d24-d977189d51f2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18af0fd4-a017-45c3-bfc6-0e7101c3fc67"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("7fee2d31-a3ec-441e-b057-e8edf8104e8f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(250, 480),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18af0fd4-a017-45c3-bfc6-0e7101c3fc67"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("326b3b5f-6405-4a1f-9be1-4151cbd9bfbc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("e5426aea-b0ee-4356-80aa-7f1ceb6bfdd2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(365, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8f7c1962-1372-4899-812c-97f08065a90e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3b65141-9787-44c9-aaa8-750deb4d1acf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("d185f159-f423-4a2e-8126-8e7da6b063d3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(147, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8ad5cbc1-ba8c-4c8d-bf52-f762f26a862b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("0d637a22-f6eb-4444-b037-925f54d61912"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(684, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("658b1ee4-29bc-4360-a7a1-15e95d38f90e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88a433ba-3a86-4dce-8d04-29ed08f07954"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("535e3454-bff3-4bda-adca-bc2e5e69ac4c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(281, 952),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("09653f3a-1ff7-49be-a9ef-cdec90980f30"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("14cd49b3-3d4d-4753-8a70-778f50fc515c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("c3d955f8-0cc4-460b-974d-62aad3099ceb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(366, 1104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("326b3b5f-6405-4a1f-9be1-4151cbd9bfbc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("92f0b8dc-2511-4368-9d33-e8fa64a6a3e6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("c863ff86-a3c2-4ac5-9d20-f6bfe0b0f09a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(167, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("241d4d8a-a678-403e-804b-3570329b66e6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bfc82440-2519-485c-a659-c9fbc4dda939"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("9287cfb8-0043-491d-b380-2571a5454071"),
				ConditionExpression = @"Page.EntityDataSource.SchemaUId.Equals(Guid.Empty) || Page.EntityDataSource.SchemaUId.Equals(SelectedEntitySchemaId)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(315, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f101257-14d5-4bf5-8d6f-127b436391cf"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c58185e8-d4d8-480a-8897-622b86be5ecd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow19",
				UId = new Guid("b46da7f0-4e4a-4be8-999b-a1efe9ed983d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(232, 146),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f101257-14d5-4bf5-8d6f-127b436391cf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8ad5cbc1-ba8c-4c8d-bf52-f762f26a862b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("7402d760-af75-4c2d-bbab-219c5d0f20bd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(167, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bfc82440-2519-485c-a659-c9fbc4dda939"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5f101257-14d5-4bf5-8d6f-127b436391cf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("907b6b77-42e2-433d-a0ee-3e869250d903"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(185, 1538),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("22a24b80-a6be-4df4-94a4-0daacacebc34"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("09653f3a-1ff7-49be-a9ef-cdec90980f30"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("c96e2a10-da96-4f6e-939c-0c26d47108cf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(313, 357),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d3b65141-9787-44c9-aaa8-750deb4d1acf"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d4456d99-5bae-4c96-aaa9-85c508c15f53"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("50f5ba77-86b0-49ea-9c1c-ab223dfcd960"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(404, 1508),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("14cd49b3-3d4d-4753-8a70-778f50fc515c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b00e0e0f-3441-431b-a61e-edb09efdfa02"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("483a1cc5-ed0f-4bdd-8221-74400e342ce9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(219, 539),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1621defe-1572-45de-a5c9-187fcf480026"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("abc47811-349e-4c53-a178-f2ceaec55c29"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("a811346f-973e-4371-a119-b15f4236a68b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(503, 412),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("92f0b8dc-2511-4368-9d33-e8fa64a6a3e6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("712f844a-c347-457d-a94c-c1de62a9a2a2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("f6f22001-29c9-415d-ae81-899fa01fa988"),
				ConditionExpression = @"IsParametersValid",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(351, 540),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("abc47811-349e-4c53-a178-f2ceaec55c29"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75d0a5cc-4e4b-497c-b80c-459e33cbdf13"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("3598e6ed-b7e0-41f3-97d0-5a5d87197843"),
				ConditionExpression = @"!isShowWarningEmptyFilter",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(351, 540),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75d0a5cc-4e4b-497c-b80c-459e33cbdf13"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4bd80a5a-154e-48ba-a348-4a134408f743"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow21",
				UId = new Guid("c79f8f64-5836-4877-9a04-f5cf43900677"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(372, 714),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75d0a5cc-4e4b-497c-b80c-459e33cbdf13"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("47a9ec00-bc65-4b7e-bb4d-19f759ed9702"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("a27945f3-ce64-4623-96b7-36ece181e7dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(452, 798),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("47a9ec00-bc65-4b7e-bb4d-19f759ed9702"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("4c722c1a-8ce6-4402-b815-7d313d5ebf28"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CurveCenterPosition = new Point(182, 966),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("47b39c63-2bc0-4055-887a-8b86449db167"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c1182e84-aa7b-4086-8e2f-38cb4d369de7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6714fb16-a596-4c91-9f2a-0efff0f2997b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1056, 1761),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6714fb16-a596-4c91-9f2a-0efff0f2997b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"Lane3",
				Position = new Point(29, 0),
				Size = new Size(1027, 457),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fc484bc0-cbe0-4821-a759-4da80a846322"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess12",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(496, 272),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntitySchemaEditChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("241d4d8a-a678-403e-804b-3570329b66e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc484bc0-cbe0-4821-a759-4da80a846322"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntitySchemaEditChange",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EntitySchemaEditChange_StartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateShowChangeEntitySchemaMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f7103f1d-53ad-4640-a2ba-31fdaa2eb1ab"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc484bc0-cbe0-4821-a759-4da80a846322"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ShowChangeEntitySchemaMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(385, 172),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowChangeEntitySchemaMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareQuestionPage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8ad5cbc1-ba8c-4c8d-bf52-f762f26a862b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc484bc0-cbe0-4821-a759-4da80a846322"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"PrepareQuestionPage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,141,177,14,130,48,16,134,103,121,138,166,51,241,5,80,7,149,129,65,80,11,131,99,131,23,104,140,87,211,30,65,66,120,119,91,203,224,98,194,116,249,239,190,239,63,209,234,254,208,74,108,32,69,82,52,136,186,133,167,60,129,181,178,129,202,130,41,165,125,172,207,46,176,45,243,35,137,196,34,101,206,37,188,201,153,129,15,100,176,230,251,210,186,172,214,232,122,248,165,74,69,153,21,57,95,42,238,59,34,141,214,187,183,84,228,197,98,241,10,246,229,68,152,247,190,1,161,103,71,85,147,210,40,205,176,177,100,20,54,49,11,115,199,198,104,53,242,1,44,143,191,191,126,203,211,187,162,240,146,79,177,199,80,123,42,47,254,67,83,18,25,160,206,32,35,211,65,242,1,202,71,22,231,169,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("5f101257-14d5-4bf5-8d6f-127b436391cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc484bc0-cbe0-4821-a759-4da80a846322"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateEntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c58185e8-d4d8-480a-8897-622b86be5ecd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc484bc0-cbe0-4821-a759-4da80a846322"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"YESEntitySchemaEditChange",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EntitySchemaEditChange_YESEntitySchemaEditChange_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(407, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateGetGuid_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bfc82440-2519-485c-a659-c9fbc4dda939"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fc484bc0-cbe0-4821-a759-4da80a846322"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"GetGuid_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,193,10,130,64,20,69,215,9,254,195,203,54,10,49,22,45,12,196,93,18,174,12,166,108,61,56,175,26,210,73,198,153,66,162,127,111,68,8,55,182,191,247,157,115,31,197,10,75,141,60,149,90,232,142,150,55,172,89,198,33,129,189,17,156,164,117,163,187,216,117,92,71,92,192,63,176,43,146,113,48,229,66,147,130,85,6,33,73,64,154,170,10,224,13,174,51,83,168,141,146,160,149,65,219,254,184,78,24,194,49,223,229,176,88,71,171,104,179,181,153,39,83,128,99,168,60,63,212,189,109,88,137,61,29,117,241,162,93,59,166,249,222,41,227,222,18,252,94,45,248,35,19,196,131,239,212,249,249,207,213,170,210,169,7,76,180,137,149,24,54,141,71,126,1,43,91,76,203,71,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e2f8438a-6d2b-47ef-9c2f-ba0f752827fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 287),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateYESEntitySchemaEditChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8f7c1962-1372-4899-812c-97f08065a90e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2f8438a-6d2b-47ef-9c2f-ba0f752827fc"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"YESEntitySchemaEditChange",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"YESEntitySchemaEditChange_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessYesAnswer_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d3b65141-9787-44c9-aaa8-750deb4d1acf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2f8438a-6d2b-47ef-9c2f-ba0f752827fc"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ProcessYesAnswer_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,193,114,218,48,16,61,147,153,252,131,224,18,57,195,136,246,204,112,72,140,147,122,38,237,48,117,146,158,85,123,67,52,145,101,87,146,73,221,132,127,175,100,129,107,3,54,244,208,30,241,238,190,183,111,181,251,96,79,8,47,232,18,72,32,52,211,101,20,63,67,74,131,132,105,242,72,121,1,104,54,67,162,224,28,189,191,35,140,111,11,150,120,61,217,30,9,126,20,148,171,42,145,4,105,174,75,207,67,111,231,103,131,70,209,156,106,26,101,133,140,129,248,133,148,32,116,164,101,17,235,66,154,15,28,168,196,222,212,84,56,236,48,65,51,244,7,205,6,86,84,34,158,101,47,69,62,95,105,19,197,22,176,162,191,47,115,240,30,20,72,63,19,2,98,205,50,65,90,193,207,84,152,62,36,185,5,29,106,72,175,203,47,52,5,60,186,171,208,70,30,9,133,210,84,196,176,165,201,169,52,9,26,228,102,22,72,192,43,90,200,44,6,165,92,127,139,86,6,118,98,7,45,82,83,86,183,59,182,209,175,240,4,70,118,12,14,226,161,210,184,149,91,101,52,3,118,186,245,239,70,116,163,197,42,104,101,53,190,155,228,245,180,61,252,234,173,22,187,178,218,58,167,157,239,117,168,97,155,61,185,180,37,221,115,65,80,147,111,41,251,123,178,160,59,53,164,119,108,135,100,110,169,118,128,234,212,171,36,137,98,201,114,141,205,2,50,177,36,55,153,76,169,198,163,183,15,107,162,64,239,19,226,139,183,143,235,11,111,52,222,107,223,231,204,208,132,243,113,221,145,87,109,241,229,164,115,152,119,25,77,234,205,119,59,239,114,252,103,42,150,144,248,25,47,82,161,144,59,64,27,158,51,149,115,90,30,202,114,245,18,12,150,64,6,212,170,92,159,159,217,37,134,198,169,134,226,91,38,95,84,78,99,59,24,115,6,143,175,81,169,154,199,140,71,97,98,244,29,63,117,67,192,140,119,116,161,15,93,219,123,215,223,192,137,192,61,200,149,72,238,225,167,238,130,34,118,239,187,84,16,159,230,246,206,189,238,165,237,52,153,193,73,123,222,211,149,229,180,51,24,134,170,181,252,145,166,82,71,108,41,40,15,86,166,126,227,10,255,201,184,142,159,251,137,46,118,196,198,14,251,88,223,35,86,85,253,222,246,87,230,230,220,109,48,153,252,195,115,238,209,227,46,124,221,254,175,234,95,23,147,28,10,166,25,229,236,23,220,48,110,70,110,249,170,235,61,213,37,250,77,226,152,71,84,44,159,168,114,228,215,133,214,102,215,2,65,191,115,176,237,15,123,78,254,192,159,187,1,12,55,59,212,98,52,72,27,19,106,90,210,111,17,17,63,79,108,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateYESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d4456d99-5bae-4c96-aaa9-85c508c15f53"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e2f8438a-6d2b-47ef-9c2f-ba0f752827fc"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"EventEditChange",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"YESEntitySchemaEditChange_EventEditChange_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ce09aa30-52fa-4ab1-9369-7fbe1b5f353d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess14",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(407, 289),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateNOEntitySchemaEditChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("658b1ee4-29bc-4360-a7a1-15e95d38f90e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce09aa30-52fa-4ab1-9369-7fbe1b5f353d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"NOEntitySchemaEditChange",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"NOEntitySchemaEditChange_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessNoAnswer_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("88a433ba-3a86-4dce-8d04-29ed08f07954"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce09aa30-52fa-4ab1-9369-7fbe1b5f353d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ProcessNoAnswer_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,143,65,79,194,64,16,70,207,52,233,127,24,240,82,18,178,104,60,64,66,56,96,169,200,9,147,162,158,135,238,8,27,183,187,117,59,171,54,198,255,238,66,67,194,193,222,60,207,151,247,222,140,199,176,221,44,55,112,117,51,185,158,220,78,33,142,122,31,232,128,12,43,110,242,226,64,37,174,205,139,117,111,117,133,5,193,28,86,196,207,159,121,83,103,23,139,100,240,180,150,131,17,60,226,158,68,123,88,34,99,110,189,43,72,180,155,176,24,206,226,72,189,66,210,5,239,207,193,120,173,135,240,29,42,46,88,237,50,147,138,69,30,236,168,61,45,140,220,210,23,119,161,68,176,141,186,158,16,41,86,172,172,57,230,252,4,83,28,157,92,15,88,167,7,52,123,146,11,211,164,86,251,210,220,121,102,107,66,5,238,52,201,240,124,255,239,170,83,146,200,222,61,234,58,89,121,37,69,86,86,220,28,5,103,244,189,210,76,238,31,128,33,183,231,136,189,51,192,206,211,236,23,37,173,202,123,193,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("969876b3-c399-4cdf-87fc-d88c6532b202"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess11",
				Position = new Point(36, 471),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(580, 270),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage8StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1621defe-1572-45de-a5c9-187fcf480026"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("969876b3-c399-4cdf-87fc-d88c6532b202"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"StartMessage8",
				Position = new Point(28, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessSave_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("abc47811-349e-4c53-a178-f2ceaec55c29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("969876b3-c399-4cdf-87fc-d88c6532b202"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ProcessSave_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,85,201,110,219,48,16,61,39,64,254,129,201,33,144,0,67,232,189,73,128,196,81,82,23,117,106,68,78,123,102,197,177,205,86,162,12,146,114,226,22,254,247,14,57,148,45,121,209,77,156,229,205,246,102,148,22,80,130,178,47,240,62,228,75,43,43,197,110,217,132,207,33,9,207,84,72,155,76,225,195,126,190,56,95,113,205,76,190,128,146,163,209,147,84,226,17,140,156,43,16,19,93,229,96,76,230,117,81,220,152,162,142,23,104,26,141,58,6,153,151,167,43,12,27,19,92,242,12,246,129,27,72,41,153,135,245,219,72,68,46,114,16,224,211,129,94,156,19,100,147,91,242,131,23,53,244,36,28,204,127,114,105,165,154,191,114,37,170,50,107,178,242,78,78,213,150,63,212,214,34,240,112,1,249,31,16,59,136,174,87,168,224,100,164,84,89,105,215,135,145,218,242,83,145,130,141,239,11,214,221,184,147,248,145,91,158,85,181,206,49,135,198,2,93,73,57,92,112,53,135,233,122,9,12,90,129,80,47,103,44,74,85,93,38,83,189,158,112,109,224,102,223,227,46,162,40,110,40,190,174,12,10,200,45,136,145,133,146,250,60,96,85,109,59,200,113,204,254,177,139,243,179,110,230,77,213,123,57,108,136,20,82,89,208,37,8,201,45,12,185,205,23,45,54,160,83,224,12,55,172,67,153,81,143,87,168,175,23,248,242,150,169,186,40,48,95,76,183,131,140,237,224,37,160,43,211,144,87,90,248,142,247,97,37,91,15,227,105,187,126,193,87,116,245,26,188,175,28,81,207,26,172,132,134,213,240,52,58,30,218,171,227,214,152,253,4,188,244,20,88,50,174,132,156,73,156,143,106,83,37,172,19,177,98,179,229,212,23,110,194,192,171,162,46,21,141,189,97,22,42,73,32,238,85,48,56,197,205,45,206,147,44,92,3,90,16,36,233,39,117,8,67,49,156,115,132,159,142,102,184,182,55,198,106,220,156,187,248,152,105,56,40,112,44,54,61,125,199,90,219,225,174,83,48,124,214,85,189,108,198,180,179,246,131,26,153,221,52,177,175,210,245,208,106,223,118,199,169,19,101,19,141,142,249,118,50,76,134,85,77,220,251,196,174,175,217,101,87,57,50,216,238,111,48,179,233,199,82,35,39,176,7,47,72,209,239,58,45,151,118,237,143,232,134,178,184,60,136,20,120,236,202,31,115,169,198,232,142,223,19,174,160,72,238,133,8,239,200,219,114,215,221,32,153,74,91,224,30,31,202,241,136,81,94,62,144,241,41,12,88,163,197,251,128,231,75,43,156,79,147,150,201,22,213,123,144,121,107,114,239,182,175,143,27,84,130,179,218,111,75,170,248,175,2,132,107,217,246,129,173,34,131,174,117,76,40,103,61,233,204,120,97,252,22,109,182,39,232,183,169,212,176,82,43,208,100,162,224,157,237,168,19,160,191,182,141,162,55,3,26,95,138,184,58,232,97,94,188,79,250,29,93,153,195,196,195,170,37,246,255,47,116,75,25,116,211,242,48,180,204,180,223,99,174,48,166,78,50,190,130,230,183,235,110,51,238,63,145,199,165,112,144,39,65,12,90,119,193,1,107,176,181,86,52,169,255,182,79,132,147,0,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4bd80a5a-154e-48ba-a348-4a134408f743"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("969876b3-c399-4cdf-87fc-d88c6532b202"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"IntermediateThrowMessageEvent3",
				Position = new Point(455, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("75d0a5cc-4e4b-497c-b80c-459e33cbdf13"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("969876b3-c399-4cdf-87fc-d88c6532b202"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareQuestionPage_ScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("47a9ec00-bc65-4b7e-bb4d-19f759ed9702"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("969876b3-c399-4cdf-87fc-d88c6532b202"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"PrepareQuestionPage_ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(266, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,208,177,14,130,48,16,6,224,89,18,222,161,233,76,124,1,212,65,197,132,65,80,129,24,71,130,23,108,196,150,244,142,32,33,188,187,45,186,105,34,211,13,255,255,181,151,75,110,170,61,231,90,10,89,6,143,154,186,157,168,8,52,102,8,58,205,241,62,63,228,37,176,37,179,195,119,157,228,79,123,15,136,166,153,194,147,12,250,209,156,240,70,88,40,105,48,63,102,65,146,134,113,196,39,152,117,67,164,36,90,118,9,146,40,158,98,78,128,181,49,240,217,217,98,9,45,219,138,130,132,146,185,238,22,72,218,96,143,189,231,138,245,174,51,235,121,7,200,189,241,159,77,165,16,130,171,32,123,29,62,120,99,44,149,77,163,248,59,28,204,82,26,168,209,146,145,110,192,127,1,43,105,75,5,123,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowWarningEmptyFiltersUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("13da44aa-db61-48da-9454-f41f870c39a8"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("969876b3-c399-4cdf-87fc-d88c6532b202"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ShowWarningEmptyFiltersUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(399, 161),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowWarningEmptyFiltersUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1a9b8051-6673-4265-ae7a-b2a900c6224c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess16",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 742),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateYESCloseEditPage_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("47b39c63-2bc0-4055-887a-8b86449db167"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a9b8051-6673-4265-ae7a-b2a900c6224c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"YESCloseEditPage",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"YESCloseEditPage_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 76),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent5IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c1182e84-aa7b-4086-8e2f-38cb4d369de7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a9b8051-6673-4265-ae7a-b2a900c6224c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"IntermediateThrowMessageEvent5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 76),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("169e1db4-ab15-44f8-9deb-e231f1cb37f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess9",
				Position = new Point(36, 925),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEventEditChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("09e44c43-ad07-468e-8917-1fa02cf5b5b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("169e1db4-ab15-44f8-9deb-e231f1cb37f9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EventEditChange",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventEditChange_StartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask8ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c8130b64-0246-4cec-9cf8-122ea3c3156d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("169e1db4-ab15-44f8-9deb-e231f1cb37f9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ScriptTask8",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,193,79,131,48,20,198,207,152,248,63,212,27,187,244,100,188,44,28,20,81,73,60,44,178,120,175,240,6,141,165,221,202,171,9,113,252,239,118,116,144,96,144,109,120,32,105,200,239,123,229,125,223,7,223,16,63,73,11,40,89,156,209,104,103,152,168,252,103,195,237,185,220,98,189,88,144,239,235,43,143,91,232,38,174,86,90,165,80,85,14,79,144,105,76,120,46,153,136,190,64,162,35,189,21,203,129,70,18,57,214,81,198,145,190,193,206,112,13,25,9,200,198,206,134,229,24,20,73,246,33,134,76,99,159,22,123,97,85,88,48,153,67,118,47,235,80,9,83,202,7,131,168,36,13,11,72,63,135,170,19,138,145,123,58,197,19,23,8,250,244,228,1,247,215,188,80,73,212,74,188,178,90,25,188,29,193,236,118,96,79,173,101,211,10,212,230,156,251,7,152,99,126,57,59,181,232,242,152,177,203,229,144,102,43,78,64,64,138,144,197,8,37,125,103,194,0,9,2,226,114,115,14,175,235,45,208,88,86,160,45,70,215,42,65,205,101,238,47,200,126,127,200,217,155,55,240,209,98,195,121,199,114,93,208,195,169,34,118,102,77,21,177,103,154,190,176,131,140,238,198,194,159,209,216,25,149,109,72,223,157,127,57,50,178,236,89,174,53,23,125,118,47,155,246,176,195,154,246,231,208,128,70,75,247,242,7,44,20,73,236,162,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c0f21f1d-d2bf-4ef0-b778-77849ef338b1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess8",
				Position = new Point(232, 924),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3906abe7-b830-43ca-8c5e-90f5f43dfb0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0f21f1d-d2bf-4ef0-b778-77849ef338b1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"HasChangedAnyColumnButtonCheck",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"StartMessage5",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask7ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("303d5661-1ae6-46d4-804a-9fc21f7cf0aa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0f21f1d-d2bf-4ef0-b778-77849ef338b1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ScriptTask7",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,205,43,201,44,169,116,206,72,204,75,79,77,113,206,207,43,41,202,207,41,214,8,72,76,79,213,243,72,44,134,138,59,230,85,58,231,231,148,230,230,57,149,150,148,228,231,233,57,103,164,38,103,167,166,104,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,194,229,184,247,79,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4f2a4f2b-5bc6-4f3f-9395-4d15f0ff7536"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess7",
				Position = new Point(449, 924),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e213262f-dcb4-4182-b5aa-8c9f5c29e0ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f2a4f2b-5bc6-4f3f-9395-4d15f0ff7536"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"HasFilterButtonCheck",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"StartMessage4",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask6ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6daf2ca8-60c6-4efe-8c60-5dad84e70f2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f2a4f2b-5bc6-4f3f-9395-4d15f0ff7536"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ScriptTask6",
				Position = new Point(84, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,203,204,41,73,45,114,77,201,44,209,115,205,75,76,202,73,77,81,176,85,8,0,201,120,36,22,67,36,157,74,75,74,242,243,244,156,51,82,147,179,83,83,172,185,138,82,75,74,139,242,20,74,138,74,83,173,1,157,133,129,135,68,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0276f700-b858-4899-a007-cd0953b250d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess6",
				Position = new Point(36, 1085),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWaitEntitySignalButtonCheck_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d32f4367-61c9-4040-b4cb-993a6fb5713f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0276f700-b858-4899-a007-cd0953b250d0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"WaitEntitySignalButtonCheck",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"WaitEntitySignalButtonCheck_StartMessage",
				Position = new Point(14, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8b99b3c8-a2c9-49e9-95af-3687ff57b9bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0276f700-b858-4899-a007-cd0953b250d0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ScriptTask5",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,205,106,132,48,16,199,207,43,248,14,179,55,189,184,15,32,189,216,218,178,208,195,178,82,122,30,147,169,134,53,9,77,70,65,74,223,189,81,67,63,160,135,118,143,51,243,255,248,49,135,3,60,98,135,98,134,150,122,156,148,117,32,208,64,235,8,47,224,53,247,160,94,192,145,182,19,201,52,57,97,71,197,51,42,62,163,145,86,55,170,51,56,84,35,179,53,197,109,79,226,66,18,110,96,255,41,171,13,43,158,127,147,149,105,18,227,182,107,45,21,23,181,193,118,248,95,196,132,14,188,232,73,99,112,221,43,35,239,200,7,45,201,147,179,130,188,111,214,91,150,151,81,186,230,4,233,230,41,30,136,43,244,84,15,164,201,112,53,63,29,101,182,160,196,69,24,243,47,210,136,178,58,87,222,134,248,76,175,163,114,36,179,63,0,111,81,225,159,217,254,232,127,240,53,140,142,227,35,166,208,155,195,91,154,236,182,210,101,190,182,109,247,141,251,218,140,247,5,218,17,143,206,0,187,145,202,15,23,58,142,8,51,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1eff0811-7204-4a8c-95e5-b230c61566c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess5",
				Position = new Point(232, 1092),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateWaitRandomSignalButtonCheck_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("82bfcc94-e9d9-40eb-9cd7-b85df41475e4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1eff0811-7204-4a8c-95e5-b230c61566c5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"WaitRandomSignalButtonCheck",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"WaitRandomSignalButtonCheck_StartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9c5a86da-ce68-4dd0-9340-aafc304736f6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1eff0811-7204-4a8c-95e5-b230c61566c5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ScriptTask4",
				Position = new Point(77, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,145,61,111,194,48,16,134,119,36,254,195,177,160,116,9,99,135,168,67,27,165,116,96,168,64,106,231,75,124,77,44,236,51,56,103,164,252,251,18,176,146,170,66,253,64,172,214,171,231,222,231,245,98,1,43,172,177,234,160,164,6,15,218,121,168,144,161,244,132,91,104,173,52,160,63,192,147,117,7,82,211,201,43,214,148,190,163,150,130,69,75,183,209,53,163,121,10,34,142,211,188,161,106,75,10,30,96,54,196,214,200,202,217,75,177,108,58,137,184,220,177,120,103,86,216,185,32,247,105,193,88,154,43,48,47,216,230,13,114,77,234,145,187,220,153,96,57,70,191,19,99,247,170,33,139,133,210,146,190,161,9,199,231,125,64,211,38,203,160,85,90,216,157,116,119,217,136,126,214,70,200,223,0,184,161,184,93,44,27,237,219,228,23,137,232,59,116,58,23,58,93,251,223,98,48,159,195,69,171,113,209,47,82,67,203,190,202,210,247,38,87,95,251,217,108,252,201,51,231,164,118,92,107,77,251,160,61,169,228,15,215,250,117,60,73,240,12,226,3,101,159,118,52,253,171,221,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2439fe10-c65f-4c97-9932-0f327da98e08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess3",
				Position = new Point(42, 1260),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(213, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddColumnButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6321e4b6-ae0d-4fe0-9ea5-095a626e7893"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2439fe10-c65f-4c97-9932-0f327da98e08"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddColumnButtonClick",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"AddColumnButtonClickStartMessage",
				Position = new Point(21, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("edca4e15-5e49-4582-ade9-cd9ae5884c37"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2439fe10-c65f-4c97-9932-0f327da98e08"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ScriptTask2",
				Position = new Point(98, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,219,106,131,64,16,125,142,224,63,108,222,20,194,254,128,109,161,53,82,164,20,10,34,125,94,214,73,92,48,179,97,119,173,13,37,255,222,137,107,85,82,147,23,81,57,115,46,115,70,237,88,180,206,208,41,119,42,100,13,7,145,234,166,61,96,246,125,108,180,1,147,26,16,14,170,152,253,132,193,202,127,220,6,71,113,18,6,231,48,8,131,57,230,77,97,197,236,244,250,200,62,196,30,184,135,108,133,19,133,110,141,4,62,161,147,11,197,151,48,204,58,211,74,215,26,248,83,160,225,219,242,76,88,86,230,169,70,103,116,99,121,113,61,60,210,194,140,130,24,75,75,57,53,34,72,167,52,242,185,192,187,64,242,106,248,43,184,28,173,19,40,225,229,84,230,85,116,47,2,39,64,60,138,201,222,163,37,29,132,142,77,224,209,158,15,65,207,198,27,136,226,43,163,105,45,112,15,85,58,18,101,75,191,41,252,196,241,64,155,83,184,127,234,153,20,85,188,200,180,38,79,109,211,248,114,119,180,34,33,107,22,77,166,153,194,69,11,126,96,53,36,227,207,213,173,125,108,97,55,198,228,254,122,60,69,52,175,96,51,200,197,151,224,171,243,112,66,255,186,231,211,2,6,229,100,25,87,212,186,203,42,229,62,233,148,116,119,183,42,106,106,211,239,96,51,187,80,191,127,3,68,138,140,216,33,249,5,56,51,136,105,37,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a7dc7c09-89c0-485c-ad8b-5b333fefddc3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess4",
				Position = new Point(274, 1263),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRemoveColumnButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c97e24f5-3586-4fb9-bff1-ad8f28b2882f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a7dc7c09-89c0-485c-ad8b-5b333fefddc3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RemoveColumnButtonClick",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"RemoveColumnButtonClickStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a311af7c-412a-4f65-8cca-f37e79900150"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a7dc7c09-89c0-485c-ad8b-5b333fefddc3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ScriptTask3",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,207,189,10,194,48,16,192,241,217,66,222,225,232,148,44,121,129,170,139,138,147,82,172,184,136,195,209,158,109,160,189,72,62,10,69,124,119,155,206,221,142,227,248,243,59,145,141,232,128,56,152,48,29,58,228,150,154,131,237,227,192,30,118,112,90,91,163,135,121,236,169,14,198,242,214,7,103,184,221,23,34,19,217,219,58,194,186,3,153,146,108,27,2,195,80,98,75,122,37,116,118,166,209,21,165,14,53,215,249,216,43,248,138,108,179,70,209,55,26,236,72,50,53,245,3,251,72,254,153,95,40,96,137,161,203,95,250,110,171,133,33,149,154,33,191,100,57,26,255,233,113,90,251,64,170,69,235,40,68,199,16,92,164,226,15,222,5,118,87,6,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("edf12666-2488-4bf2-9012-e25a2519434e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 1436),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(413, 153),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("22a24b80-a6be-4df4-94a4-0daacacebc34"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("edf12666-2488-4bf2-9012-e25a2519434e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("09653f3a-1ff7-49be-a9ef-cdec90980f30"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("edf12666-2488-4bf2-9012-e25a2519434e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInit_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("14cd49b3-3d4d-4753-8a70-778f50fc515c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("edf12666-2488-4bf2-9012-e25a2519434e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"Init_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,193,110,218,64,16,61,7,137,127,88,249,16,25,21,249,7,66,34,17,227,164,150,218,202,42,144,30,170,30,54,236,96,54,172,119,201,236,58,197,66,252,123,198,94,83,76,168,114,106,149,155,53,243,230,205,188,183,227,73,19,93,22,128,252,81,193,232,190,148,226,134,109,248,98,205,115,72,133,101,215,108,6,136,220,154,165,139,98,131,16,101,62,103,163,31,6,215,150,144,48,119,82,73,39,41,116,15,174,77,127,150,68,136,139,85,69,28,225,220,2,198,70,107,88,56,105,244,144,221,73,45,38,96,101,174,65,100,104,22,96,237,116,177,130,130,135,131,3,253,60,21,195,126,239,226,180,242,216,50,74,197,224,170,223,51,143,79,148,249,249,139,249,143,172,59,246,81,67,20,115,235,70,30,114,67,45,102,102,76,138,170,176,102,120,225,120,68,222,73,229,0,169,86,195,111,54,145,77,79,142,213,200,58,148,58,31,182,93,110,216,142,38,219,5,11,83,108,56,74,107,244,172,218,64,80,203,170,203,227,147,112,148,60,151,92,237,135,77,133,130,165,75,182,27,36,189,196,28,27,85,22,58,227,110,69,181,193,180,178,237,248,65,139,46,45,76,164,221,40,94,61,112,85,214,13,150,92,89,104,179,40,243,85,135,44,227,200,11,160,246,13,214,6,195,51,75,246,253,222,190,21,92,112,77,49,252,70,21,31,41,249,235,113,140,127,164,185,22,241,103,39,118,65,162,157,116,149,95,173,182,89,176,239,248,0,91,7,90,16,13,104,247,145,70,36,157,57,254,139,19,190,180,85,158,145,15,81,215,154,68,72,23,101,8,52,58,124,49,102,93,110,90,51,62,93,51,1,10,114,238,128,133,158,141,89,154,20,112,200,60,176,46,77,94,104,236,49,230,150,193,160,177,167,182,118,217,48,212,255,33,68,158,205,82,235,139,54,28,141,133,8,223,252,118,131,183,249,179,45,61,67,156,191,95,13,169,53,198,8,52,180,23,25,175,184,206,65,120,203,31,232,28,29,254,123,219,168,167,17,223,185,71,7,40,229,184,34,104,152,158,0,166,77,188,113,96,224,233,234,27,120,203,45,36,10,10,138,222,86,116,201,194,198,38,31,152,251,203,149,218,83,30,199,209,117,200,168,83,219,82,90,246,46,146,184,228,146,133,180,66,81,106,199,79,124,251,29,158,105,5,28,187,188,100,221,71,246,242,105,101,20,29,113,244,254,8,255,94,93,179,254,6,110,92,160,229,65,112,37,106,230,176,132,171,87,199,90,229,248,52,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateAddFilterEntitySchema_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b00e0e0f-3441-431b-a61e-edb09efdfa02"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("edf12666-2488-4bf2-9012-e25a2519434e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"AddFilterEntitySchema_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(309, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,147,193,110,194,48,16,68,207,32,241,15,86,78,64,35,243,1,148,74,8,130,84,169,135,72,148,246,80,245,224,198,75,112,113,236,212,235,0,17,202,191,215,137,129,82,56,163,246,234,204,204,206,62,59,131,254,134,25,146,179,100,205,82,88,60,242,153,144,22,12,25,17,5,91,50,21,137,21,90,49,83,222,163,53,66,165,33,209,31,159,144,216,7,178,239,180,91,173,125,144,232,44,103,70,160,86,207,101,14,65,72,188,127,242,235,152,70,95,5,147,85,232,45,18,150,54,218,229,6,16,93,246,68,203,34,83,49,179,43,103,14,230,37,198,167,42,193,209,81,32,76,5,230,146,149,47,76,22,245,148,37,147,8,199,207,70,164,171,179,196,152,25,150,129,43,209,136,209,169,235,85,124,239,183,119,178,159,9,197,167,128,34,85,192,99,163,19,231,154,39,43,200,88,183,71,127,134,87,85,53,236,180,107,54,91,109,214,232,0,253,11,58,175,199,50,55,130,179,192,186,158,82,208,172,70,79,227,232,57,17,216,89,80,220,69,129,178,127,75,36,58,107,114,35,34,222,219,236,30,187,167,65,35,101,133,45,253,139,137,184,176,52,54,224,186,195,147,214,235,34,63,224,184,27,17,14,18,82,102,129,116,125,22,65,215,20,76,72,188,176,182,70,27,87,123,108,82,36,208,107,0,213,112,151,77,2,58,162,64,125,26,186,209,173,195,49,29,115,222,189,252,91,123,151,130,235,39,123,37,185,190,195,90,82,13,251,131,78,219,128,45,140,34,214,20,48,252,6,58,87,107,75,32,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("883a98d5-5d83-49bb-95b4-1281f114f01e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b05d01d0-5bc7-44d8-9054-015e6ec24f9f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 1601),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(535, 146),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage7StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a9ce2af7-d828-4cf2-8d24-d977189d51f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("883a98d5-5d83-49bb-95b4-1281f114f01e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"StartMessage7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("18af0fd4-a017-45c3-bfc6-0e7101c3fc67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("883a98d5-5d83-49bb-95b4-1281f114f01e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessPageLoadComplete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("326b3b5f-6405-4a1f-9be1-4151cbd9bfbc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("883a98d5-5d83-49bb-95b4-1281f114f01e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"ProcessPageLoadComplete_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(217, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,88,223,111,219,54,16,126,118,128,252,15,172,7,52,18,102,168,27,246,144,1,89,6,56,182,211,105,72,155,32,142,155,103,214,58,219,108,101,209,37,169,36,94,144,255,125,199,31,146,40,89,86,156,199,230,193,129,196,239,190,251,238,72,222,81,124,160,130,200,249,10,214,148,156,147,75,150,37,99,144,108,153,65,114,35,248,28,164,156,154,177,32,60,59,62,122,208,80,28,163,41,66,131,184,6,152,154,247,147,7,200,84,104,233,162,143,160,46,168,132,73,10,107,124,123,177,157,197,73,48,73,152,114,47,240,81,147,198,178,206,163,168,80,30,25,122,114,46,153,36,157,72,228,58,62,98,11,20,214,205,24,146,231,227,163,222,13,93,66,116,201,82,5,66,107,138,134,203,165,128,37,85,140,103,147,140,126,77,1,29,47,104,42,225,172,5,28,203,17,79,243,117,38,39,79,155,148,11,16,183,156,171,79,60,209,70,74,228,218,230,133,0,26,183,186,154,130,170,231,214,230,75,39,227,229,248,200,160,71,116,99,148,104,248,29,60,85,89,40,70,206,28,240,158,50,117,75,179,132,175,109,132,23,185,82,60,211,46,190,208,52,135,192,89,105,24,203,150,62,50,44,40,92,106,118,93,217,129,22,152,77,80,82,33,91,232,125,129,147,76,49,181,61,68,160,143,44,5,254,67,229,104,69,179,37,36,195,108,107,19,191,135,5,145,150,193,162,172,149,230,65,160,27,176,68,35,158,41,193,83,249,170,97,33,192,78,223,107,110,45,74,150,134,206,205,21,221,242,92,157,238,205,155,31,181,219,102,41,231,223,243,205,248,65,79,71,48,166,138,26,135,119,219,13,132,51,9,2,137,51,152,235,133,16,213,6,63,209,12,253,10,189,245,98,5,235,139,237,103,186,134,160,127,101,216,250,97,20,103,82,209,108,174,23,104,109,9,222,80,129,64,212,110,152,8,24,65,122,174,237,243,57,49,225,76,202,215,81,221,0,233,26,38,117,89,72,80,6,212,130,189,133,5,8,64,89,86,12,22,134,42,69,46,55,197,64,139,181,111,164,223,190,142,117,89,210,185,169,217,120,239,139,25,244,66,46,82,209,224,60,179,69,231,93,187,94,44,21,147,245,70,109,131,208,150,29,59,208,29,32,194,62,124,32,119,215,227,107,242,203,239,167,191,157,254,241,39,193,87,122,85,128,135,141,179,123,46,190,203,13,157,107,81,56,225,95,30,167,91,233,179,5,125,228,235,15,246,56,210,139,180,167,149,239,35,125,119,78,178,60,77,173,238,158,151,13,11,45,74,153,73,194,48,75,116,237,216,199,21,161,191,193,62,245,69,73,51,130,124,63,122,9,77,121,46,230,245,57,238,240,97,24,116,162,22,118,35,54,179,236,246,167,129,153,73,155,42,129,251,15,39,233,51,70,122,45,236,84,57,99,61,99,189,158,134,26,202,111,146,103,184,237,30,64,224,32,18,103,240,72,42,133,142,249,95,31,20,212,119,234,128,52,27,65,101,110,99,247,164,99,29,74,173,25,186,210,172,17,182,101,16,140,166,236,63,40,20,14,136,194,205,197,23,65,83,71,101,29,14,140,208,43,38,213,95,53,113,127,147,231,70,72,47,33,161,114,39,164,138,202,74,212,105,219,145,88,95,42,54,14,120,66,159,152,220,38,77,189,152,120,115,60,202,5,22,1,133,83,146,207,85,46,138,76,201,72,31,74,92,37,107,122,142,244,219,131,116,219,165,190,79,83,51,128,222,62,100,52,74,129,138,192,205,87,175,183,192,238,79,231,43,18,84,83,167,11,47,97,217,206,68,86,228,251,217,135,73,18,84,44,165,151,151,215,84,93,241,37,155,211,244,122,3,130,186,36,239,164,170,137,57,123,141,20,75,87,217,176,118,216,202,193,3,104,62,115,213,78,129,3,206,220,59,46,233,191,55,174,144,42,109,94,186,11,102,243,207,252,154,159,38,235,76,177,20,187,48,72,108,142,248,223,108,176,97,174,248,24,22,165,163,160,85,143,245,80,89,85,59,59,232,170,101,87,156,38,21,179,65,190,180,212,119,204,88,163,211,251,213,215,111,244,174,167,219,3,118,71,177,175,60,184,242,101,65,141,50,229,150,105,41,194,215,164,165,22,76,44,195,96,215,144,48,170,96,68,213,124,213,122,104,167,141,67,123,220,97,85,52,164,78,230,70,87,106,61,196,16,1,115,46,18,211,45,186,200,170,83,140,52,31,43,238,180,116,235,172,251,97,217,79,54,26,88,28,0,10,246,200,78,104,113,10,232,245,42,84,231,241,167,6,124,219,217,167,102,218,117,240,105,1,30,118,234,169,173,218,150,163,30,154,86,204,85,35,149,109,141,212,147,96,126,67,242,254,61,241,117,153,252,145,243,115,210,113,24,45,246,62,199,101,238,88,158,203,78,164,87,241,199,156,37,45,174,112,161,232,145,200,72,33,174,174,160,127,187,158,163,75,192,181,112,41,248,122,124,17,148,101,217,203,119,116,35,216,154,10,247,65,48,40,8,122,251,61,134,245,246,103,184,226,196,22,133,253,77,15,219,135,114,149,227,158,169,85,181,34,131,162,144,174,209,19,195,78,173,87,82,52,249,145,211,116,64,250,230,96,231,66,169,41,181,90,92,237,171,139,136,220,212,107,99,7,104,23,229,151,190,90,141,173,243,133,157,36,186,204,221,242,71,89,244,202,178,2,191,152,207,220,183,125,168,251,199,112,38,89,227,243,220,150,35,172,98,202,216,153,6,108,43,220,44,46,190,244,34,125,4,210,35,65,108,144,144,104,173,6,239,206,159,3,226,127,34,154,108,23,208,232,142,219,147,34,30,227,203,251,0,99,107,175,3,144,214,38,168,161,34,108,185,8,104,13,165,184,52,176,31,127,249,38,193,69,145,28,18,204,204,66,15,136,197,33,27,161,104,119,9,164,112,160,187,177,133,30,224,206,33,27,238,246,38,174,25,114,39,184,41,184,5,60,5,125,12,128,68,15,151,95,110,245,178,106,31,42,125,187,36,59,243,211,184,67,48,87,64,77,222,250,40,26,141,153,220,164,116,219,54,106,156,234,157,208,113,77,83,173,156,233,92,176,141,42,58,63,38,194,190,8,250,119,32,4,149,124,161,162,225,55,250,244,9,212,138,39,50,186,91,9,254,56,74,153,142,70,135,20,156,244,201,175,36,8,42,244,44,142,238,225,107,57,203,218,73,104,60,13,229,198,60,148,247,5,177,63,145,200,98,80,250,71,27,83,150,161,158,89,198,126,228,16,143,113,180,127,50,32,39,237,55,83,163,21,204,191,159,132,103,125,119,219,181,27,124,237,10,232,103,14,126,247,214,171,22,252,207,24,86,185,53,236,50,246,230,81,0,54,139,204,238,147,255,1,98,130,239,148,82,22,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSetPageCaption_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("92f0b8dc-2511-4368-9d33-e8fa64a6a3e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("883a98d5-5d83-49bb-95b4-1281f114f01e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"SetPageCaption_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(329, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,137,5,37,153,249,121,10,182,10,32,62,148,103,205,197,85,148,90,82,90,148,167,80,82,84,154,106,13,0,80,53,157,18,84,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSubscribeClientEventsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("712f844a-c347-457d-a94c-c1de62a9a2a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("883a98d5-5d83-49bb-95b4-1281f114f01e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Name = @"SubscribeClientEventsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(441, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,65,75,196,48,16,133,207,91,232,127,24,247,178,45,148,172,158,139,160,171,187,176,183,197,128,158,67,154,118,195,182,137,36,19,65,74,254,187,105,82,5,15,11,82,175,47,111,222,124,121,140,69,35,85,7,90,29,52,119,150,114,35,223,17,238,225,97,61,222,122,162,85,177,105,39,125,83,65,235,20,71,25,20,91,129,40,97,28,243,108,37,91,40,110,198,59,79,248,89,240,139,104,102,121,53,73,86,224,43,235,157,40,208,56,81,214,65,246,62,207,188,175,0,207,210,150,245,58,72,121,182,221,194,11,83,141,30,192,202,78,177,62,207,78,172,19,228,177,105,18,74,65,35,31,57,104,51,48,44,126,97,86,33,51,186,105,28,221,55,18,201,83,47,133,194,227,115,5,241,229,141,73,76,249,201,179,115,136,90,253,184,202,200,21,41,246,10,37,126,254,135,34,37,208,80,197,192,174,177,204,158,171,44,177,208,163,61,25,205,133,181,41,139,34,51,56,127,241,35,88,67,201,223,43,255,12,56,19,78,227,75,209,150,109,140,161,75,87,134,123,49,2,157,81,48,221,80,253,5,237,99,245,244,171,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateEntitySchemaColumnExplorerMethod());
			Methods.Add(CreateHandleEditCompleteMethod());
			Methods.Add(CreateInitializeFilterEditMethod());
			Methods.Add(CreateDisplayEntityChangedColumnsMethod());
			Methods.Add(CreateCreateEntityChangedColumnVdsMethod());
			Methods.Add(CreateEntityEdit_ShowMappingWindowMethod());
			Methods.Add(CreateGetEntityIdsWithOutPrcListenersColumnMethod());
			Methods.Add(CreateGetEntityIdCollectionMethod());
			Methods.Add(CreateGetVwSysEntitySchemaMethod());
			Methods.Add(CreateSetEntityChangedControlsMethod());
			Methods.Add(CreateIsEnabledAnyFilterMethod());
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
				UId = new Guid("773df24f-34fc-4889-ad97-4b609bea4dfe"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("918fef11-f886-42a6-94c7-8921346a1c06"),
				Name = "Terrasoft.Configuration.VwSysEntitySchemaInWorkspace",
				Alias = "VwSysEntitySchemaInWorkspace",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("986e8003-e755-4905-a322-8adcb3037054"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d634329b-17b7-4b58-b00a-81dddef8b45d"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f909d548-ea0a-4163-99d5-5d01014acefb")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bbc768b1-7083-41f1-9495-8ee67cb6a58c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,204,65,11,130,64,16,134,225,115,253,138,193,211,46,200,80,215,34,34,196,192,139,69,24,158,183,92,101,65,119,100,118,194,66,252,239,97,120,236,244,93,158,239,85,87,211,88,60,133,126,94,48,1,10,203,108,2,213,130,247,12,75,251,72,200,11,83,27,112,6,26,19,211,139,35,15,7,8,194,206,55,152,133,252,213,182,23,78,187,94,62,234,87,91,76,90,57,193,194,190,69,195,113,189,90,248,153,184,51,162,162,113,51,129,26,183,147,142,98,40,157,175,104,88,94,49,228,118,184,217,39,113,165,97,7,127,131,251,47,155,216,91,105,182,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateEntitySchemaColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("079f04c9-3e9d-405e-89df-d84636faae8f"),
				Name = "CreateEntitySchemaColumnExplorer",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,77,79,194,48,24,62,67,226,127,168,59,141,72,118,224,106,60,232,156,186,68,35,97,232,197,120,120,179,190,131,154,174,93,218,14,88,8,255,221,119,192,112,97,72,184,244,35,125,158,247,249,232,2,12,179,206,148,169,43,13,70,171,66,106,131,134,221,49,133,75,246,17,135,90,57,163,165,13,146,99,136,63,134,25,6,83,93,236,33,175,80,233,210,13,153,151,106,89,230,202,122,67,70,20,108,86,111,52,242,6,183,87,253,72,57,225,170,36,157,99,14,225,22,217,210,236,248,32,194,130,252,33,23,46,212,121,33,209,225,41,88,112,255,3,171,104,129,202,217,32,106,97,137,222,197,70,171,84,150,28,31,193,193,39,200,18,167,85,129,118,31,152,208,66,205,190,190,217,154,121,207,165,224,20,194,123,16,10,76,85,159,158,132,196,122,143,115,138,94,31,40,128,54,30,219,144,78,219,98,176,181,194,110,58,37,30,108,190,128,226,146,58,220,237,109,203,131,206,172,149,51,48,6,3,57,221,12,205,224,220,63,26,123,120,245,155,242,99,149,233,218,160,112,152,55,151,83,132,55,205,49,152,192,114,112,254,107,66,131,224,144,83,73,245,103,158,108,53,182,201,92,47,147,202,146,226,142,92,119,154,129,180,231,240,239,69,161,45,153,156,96,134,6,85,138,23,112,118,26,167,24,34,99,254,245,255,41,38,56,19,68,53,200,7,108,125,213,239,117,5,26,132,95,215,209,187,100,210,95,37,155,95,195,243,141,141,73,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateHandleEditCompleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("df0af799-aa08-460a-b6e0-11618405e6bc"),
				Name = "HandleEditComplete",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9476a5be-0fac-491d-b2f3-8c5481e527c3"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1c1a7355-0ac6-4c19-985f-89037dfb3b96"),
				Name = "e",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,187,10,131,64,16,69,235,8,254,195,98,181,54,254,64,30,32,106,17,171,64,210,137,197,160,163,46,232,108,152,221,152,152,144,127,207,230,101,101,121,225,158,195,25,129,69,165,251,203,64,70,108,69,110,52,69,41,26,100,5,189,186,163,196,40,187,89,134,3,48,12,104,145,77,17,252,222,123,106,116,80,134,2,140,200,99,102,152,214,190,55,58,25,146,85,118,74,58,160,22,235,100,54,19,94,133,91,61,86,86,105,218,24,203,138,218,157,12,29,213,104,70,168,58,57,206,41,66,209,63,42,20,15,223,91,45,73,163,184,174,229,247,85,4,46,206,69,218,46,40,163,147,62,126,228,50,124,203,159,190,151,45,23,45,57,29,144,42,115,238,97,90,130,92,237,11,181,16,163,194,47,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cb85c747-a70a-4f01-af28-ae7bcf18974e"),
				Name = "InitializeFilterEdit",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,80,75,10,131,48,16,93,55,167,8,174,204,38,23,16,23,253,68,233,166,20,164,7,8,102,108,3,26,237,56,41,72,233,221,171,161,84,177,208,221,192,188,191,114,100,105,56,104,210,69,235,177,4,110,230,51,229,103,125,5,169,86,144,132,49,91,241,56,247,214,72,213,116,52,72,117,247,186,238,227,153,42,139,242,6,141,190,28,141,16,252,201,54,8,228,209,37,236,197,30,26,121,101,107,2,84,198,82,142,173,239,70,159,5,51,179,206,100,1,208,135,239,110,56,233,6,226,40,251,146,34,241,73,240,163,147,114,231,235,58,56,254,245,216,35,104,130,165,203,90,127,179,68,123,68,112,84,16,250,114,172,49,69,12,68,185,53,102,157,65,76,29,89,152,109,22,148,5,208,60,223,98,38,145,188,1,43,107,206,209,127,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisplayEntityChangedColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b8c5bc3d-a508-4e4a-bea5-62d5651d250c"),
				Name = "DisplayEntityChangedColumns",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,219,106,2,49,16,125,94,193,127,72,247,41,11,37,63,208,90,168,91,43,11,85,164,162,239,195,102,116,3,217,68,146,172,178,20,255,189,147,77,45,189,232,75,46,147,51,103,206,57,57,130,99,71,233,217,132,173,96,143,34,46,165,53,1,148,65,39,94,149,145,241,230,172,230,249,204,4,21,250,178,1,179,71,170,234,174,53,91,233,243,130,129,103,91,229,66,7,250,5,2,172,109,231,106,124,24,143,136,85,148,26,193,241,34,222,104,14,254,103,136,131,175,16,251,72,74,71,141,117,80,214,60,250,224,148,217,63,17,143,218,49,126,157,103,194,76,167,117,193,62,198,163,204,97,232,156,33,248,57,117,172,235,6,91,168,36,187,155,176,121,167,164,152,181,135,208,39,108,26,159,16,204,167,109,194,54,30,29,89,55,73,128,248,9,90,128,161,148,156,152,99,168,140,15,96,106,156,246,155,74,126,79,137,126,179,157,117,8,117,195,120,116,94,15,34,23,24,96,5,161,97,202,92,205,34,233,249,18,196,156,61,145,142,33,69,98,10,248,110,79,67,146,89,70,47,98,141,225,235,15,64,119,200,243,74,230,247,201,218,18,79,113,231,197,109,240,69,8,181,252,86,118,187,101,9,45,18,60,229,19,173,39,179,9,51,237,47,4,252,15,159,40,225,16,3,76,196,209,204,179,148,156,6,12,133,243,240,65,177,250,102,65,146,65,79,14,63,1,70,242,79,67,146,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateEntityChangedColumnVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("db5a1f0a-1680-42f2-bec9-4506948812bb"),
				Name = "CreateEntityChangedColumnVds",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,82,77,79,195,48,12,61,83,169,255,161,202,169,147,80,254,0,226,0,45,26,61,12,77,234,232,221,52,222,22,41,77,167,196,45,43,136,255,78,178,150,117,31,32,33,49,46,77,245,108,63,251,249,185,5,19,181,194,70,183,145,198,215,168,144,134,26,80,41,16,228,117,99,74,140,39,209,123,24,92,101,169,75,96,15,154,36,117,201,26,244,10,69,82,171,166,210,133,176,44,12,62,110,194,32,12,230,176,66,238,63,73,173,9,164,70,195,253,159,169,149,229,119,66,196,174,205,100,76,252,134,108,106,164,224,99,239,76,184,166,174,136,103,233,174,172,237,71,205,201,52,37,53,6,135,104,138,203,61,212,231,29,228,240,185,145,21,152,174,111,240,4,149,175,98,153,96,63,102,166,210,110,20,156,20,248,151,237,135,88,53,82,164,45,185,192,179,69,227,52,106,44,73,214,122,55,123,1,170,193,69,183,193,25,104,167,211,240,41,82,166,45,129,46,241,190,243,68,49,155,58,2,230,119,225,217,42,216,230,242,13,23,184,165,63,145,206,70,30,54,57,151,231,28,232,53,197,222,232,113,203,251,140,33,218,27,126,176,169,107,239,191,45,164,149,47,202,99,75,80,22,123,240,81,10,132,51,52,175,13,157,162,71,34,92,96,88,161,59,157,139,141,58,67,130,57,208,250,127,6,62,118,233,146,115,239,110,203,183,76,96,227,13,119,216,120,124,3,118,42,201,17,158,43,26,193,3,65,95,224,47,244,124,2,105,178,157,245,11,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEntityEdit_ShowMappingWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7354d9b6-3bf5-440b-9603-b018e2c77b10"),
				Name = "EntityEdit_ShowMappingWindow",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8d367158-f1ee-4234-80e6-f36f844fb690"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b41d9ef8-61b9-4e7c-882f-4f9e64f0056f"),
				Name = "e",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,193,110,219,48,12,61,183,64,255,65,243,197,54,96,40,219,142,13,10,172,77,179,33,219,210,6,75,218,93,10,12,170,205,52,218,108,201,144,228,166,89,144,127,31,37,217,105,98,167,29,48,236,148,128,164,30,31,249,72,122,194,20,43,192,128,186,100,134,221,178,188,130,217,170,132,155,81,70,206,200,141,6,53,144,66,64,106,184,20,116,47,98,204,4,123,0,69,63,129,25,25,40,46,86,87,8,19,5,95,165,252,85,149,65,76,17,161,127,114,60,210,147,6,223,123,16,213,168,10,208,181,117,124,131,57,40,16,41,76,211,5,20,204,167,246,255,61,134,224,134,179,156,255,174,3,134,79,101,46,21,168,239,92,100,114,25,197,24,114,114,252,200,20,209,123,238,45,200,214,192,116,109,153,34,133,212,84,10,26,23,66,104,163,184,120,32,11,38,178,220,61,246,6,58,44,74,179,234,248,183,156,109,213,207,193,31,165,42,152,137,130,165,163,70,215,111,55,63,134,25,55,3,89,148,57,150,186,45,57,72,78,142,143,246,233,210,65,206,65,152,209,165,173,231,200,149,115,143,192,2,150,100,234,192,47,42,158,103,160,92,189,71,250,158,158,151,37,136,44,10,230,149,112,242,68,169,204,171,66,140,196,92,198,100,125,39,130,118,160,197,228,232,69,212,225,147,161,149,225,57,253,60,189,190,162,25,164,50,131,221,247,253,131,143,31,173,246,248,122,221,241,106,89,169,20,78,73,56,102,101,137,92,195,78,68,226,30,159,58,2,20,123,192,38,204,44,186,81,25,215,101,206,86,183,59,193,41,43,109,121,221,216,57,71,1,31,177,103,167,110,164,58,1,155,186,138,94,111,199,200,80,60,19,237,215,143,58,218,250,29,195,184,83,123,163,41,138,73,53,24,71,205,199,38,46,47,62,72,200,4,119,129,14,133,225,102,101,5,223,17,179,215,123,37,217,97,118,225,245,151,55,97,195,227,16,149,122,188,102,160,20,211,114,110,232,249,79,246,52,6,179,144,153,166,179,133,146,75,159,223,117,39,10,145,121,152,144,112,144,75,13,181,64,126,119,66,199,125,36,180,97,56,202,184,120,157,22,122,14,59,75,113,79,103,210,207,99,189,120,157,133,169,73,126,176,13,179,195,242,110,131,57,14,173,205,214,26,187,107,128,13,156,166,138,151,166,185,44,231,89,230,13,81,107,187,248,156,68,235,247,27,156,242,53,177,170,84,34,186,11,48,207,93,144,88,115,159,108,108,202,151,55,44,33,1,160,72,105,189,149,47,208,139,255,74,235,31,233,91,202,178,69,249,127,241,109,33,212,92,234,35,101,39,211,31,192,29,123,223,223,206,178,57,77,183,245,146,71,207,211,53,64,44,58,81,50,5,173,155,95,143,51,217,123,21,183,183,192,89,49,129,21,108,63,1,157,186,139,65,206,206,200,43,128,62,136,214,51,27,175,177,69,45,152,113,125,73,144,112,203,211,228,222,116,154,50,93,200,165,165,87,127,63,158,187,130,11,144,180,97,154,4,137,235,222,48,135,2,37,113,155,242,7,238,243,57,78,57,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityIdsWithOutPrcListenersColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ed859a70-9da6-4587-9f51-9227250d6ccc"),
				Name = "GetEntityIdsWithOutPrcListenersColumn",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object[]"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,209,106,2,49,16,69,159,55,95,145,199,236,75,126,64,45,168,216,178,96,75,161,250,1,105,118,212,148,205,4,102,102,45,139,248,239,205,26,219,46,237,91,2,247,158,57,247,236,72,71,135,238,8,164,23,122,207,64,235,132,8,94,66,66,187,65,9,50,188,249,19,68,247,92,66,51,117,206,13,159,186,62,226,139,139,240,191,212,188,82,242,192,188,193,99,64,176,247,223,54,176,0,2,241,250,167,90,80,4,220,119,146,49,8,159,122,76,205,211,251,71,70,61,152,122,166,14,137,192,249,147,54,99,146,111,30,58,224,183,176,125,2,105,4,34,155,186,214,23,85,141,33,152,40,103,232,52,137,44,14,61,172,134,125,211,154,2,179,249,153,207,84,225,96,166,69,91,36,217,62,6,108,87,195,40,107,126,39,215,122,145,109,251,174,187,29,173,202,0,187,108,255,66,175,234,170,20,129,244,132,247,149,118,151,150,68,110,200,211,190,0,223,247,230,219,120,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityIdCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("82a88661-15cb-497f-9168-0c68a15fc574"),
				Name = "GetEntityIdCollection",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object[]"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,205,43,201,44,169,244,76,113,206,207,201,73,77,46,201,204,207,83,176,181,85,200,43,205,201,209,84,168,230,228,226,196,38,175,224,158,90,2,19,47,14,207,44,201,240,47,45,9,40,74,246,201,44,46,73,205,75,45,42,6,170,45,205,205,211,208,180,230,170,229,226,42,74,45,41,45,202,83,208,200,79,202,2,234,143,142,213,196,52,209,26,0,237,184,191,147,137,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVwSysEntitySchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("702a76aa-77fb-4a18-9852-c2f67c0a3f30"),
				Name = "GetVwSysEntitySchema",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VwSysEntitySchemaInWorkspace"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e627ad55-6f66-4f92-868e-cff2eb0e3e5c"),
				Name = "columnName",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2f9433e3-6745-4d52-a8d8-237bbb80179d"),
				Name = "value",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,110,211,64,16,61,39,82,254,97,8,82,101,75,145,27,196,161,136,64,37,100,66,149,11,45,74,211,30,16,135,85,188,77,86,172,215,233,122,221,42,66,72,109,90,184,80,137,59,39,62,161,42,68,13,45,45,191,176,251,71,204,218,78,234,64,168,42,113,200,33,243,230,189,55,251,102,188,188,12,155,235,207,215,225,254,131,149,250,202,195,71,160,191,232,107,125,101,142,245,68,127,51,71,230,64,159,154,143,122,98,62,63,6,253,85,143,245,169,190,68,228,28,123,206,16,25,153,19,48,199,230,72,95,233,11,219,102,169,182,165,6,250,66,95,155,17,254,14,204,39,253,3,80,225,80,255,66,248,210,156,232,115,36,140,205,8,80,98,162,191,195,214,126,123,24,55,133,98,106,216,238,246,105,72,90,98,59,146,111,227,1,233,82,20,58,3,115,104,62,160,245,79,61,134,150,80,84,134,52,96,68,81,159,168,110,191,205,122,130,240,13,34,73,72,17,138,155,1,83,27,164,71,43,229,61,34,65,210,56,225,10,158,130,160,251,183,250,56,157,152,74,63,18,130,118,21,139,132,219,168,148,51,5,26,239,230,244,34,243,85,66,229,208,201,212,189,172,100,41,150,208,141,120,18,138,86,128,44,228,122,207,130,192,79,43,78,181,21,84,231,155,124,50,176,102,127,119,230,192,31,237,56,125,62,247,2,241,78,65,125,135,113,140,98,214,229,75,138,105,189,72,139,219,76,245,111,194,114,178,162,31,133,3,34,89,28,137,205,225,128,122,205,221,132,240,26,84,202,165,204,247,37,118,167,127,247,8,79,232,188,9,206,52,203,240,191,237,170,69,181,106,90,154,95,139,55,67,189,86,224,54,74,149,178,53,204,84,99,155,134,51,125,186,157,114,49,86,244,112,27,0,217,107,56,139,85,62,255,26,85,217,170,49,90,158,249,46,184,14,182,3,78,74,186,135,215,145,112,14,75,75,169,136,231,71,137,80,176,10,117,23,222,165,153,73,96,138,134,40,110,225,215,245,55,72,46,77,47,135,170,108,127,91,54,217,244,66,106,105,183,29,194,134,19,20,224,39,107,9,11,86,157,233,125,121,118,45,46,190,224,223,114,211,51,186,69,51,86,146,137,222,84,53,39,220,65,186,115,247,81,11,103,91,16,126,143,251,225,49,77,51,186,249,74,49,200,70,138,73,170,18,41,242,239,23,75,191,1,211,20,230,59,166,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEntityChangedControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e78339f0-e825-41ac-ae0f-7b2f5f2a00d3"),
				Name = "SetEntityChangedControls",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("63d9a9f6-0ea4-4863-a47d-b450a00d0876"),
				Name = "enabled",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,206,207,41,205,205,43,142,119,206,207,43,41,202,207,241,73,172,204,47,45,209,115,205,75,76,202,73,77,81,176,85,72,133,176,172,185,2,64,170,29,83,82,32,26,156,74,75,74,242,243,112,170,11,74,205,205,47,75,37,74,169,107,94,73,102,73,165,115,70,98,94,122,42,212,112,247,162,204,20,108,234,1,188,94,146,128,177,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsEnabledAnyFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4af0a7f2-e7f4-482b-9ab9-c6f0edaed5ce"),
				Name = "IsEnabledAnyFilter",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("794f84a0-9bbd-406a-bdb9-7e562932ea9c"),
				Name = "entityFilters",
				CreatedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				ModifiedInSchemaUId = new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceFilterCollection",
				CreatedInPackageId = new Guid("130b2949-fea3-4ec6-a81c-917f23f9c24c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,78,205,10,194,48,12,62,79,240,29,226,109,187,248,2,99,7,241,15,207,62,65,173,41,22,98,42,105,42,136,243,221,237,104,25,12,146,67,242,253,186,32,104,236,3,218,183,17,240,138,79,240,12,200,234,245,115,242,164,40,177,131,239,122,213,120,7,237,102,194,183,151,120,100,115,35,188,23,160,177,33,179,57,97,159,143,95,222,201,200,21,233,89,66,122,193,80,124,77,132,131,81,115,13,73,44,22,239,125,32,66,171,62,112,95,35,150,194,1,56,17,193,56,194,28,186,227,218,107,65,237,106,23,65,77,194,160,50,215,201,83,159,206,80,196,254,15,136,54,130,22,240,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IntermediateCatchSignalParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f8cd5225-a0e4-4668-8cac-b95748eeda72"));
		}

		#endregion

	}

	#endregion

}

