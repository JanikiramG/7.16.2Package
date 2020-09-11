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

	#region Class: StructureExplorerAggregationColumnEditPageSchema

	/// <exclude/>
	public class StructureExplorerAggregationColumnEditPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return _mainControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainInfoControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainInfoControlLayout {
			get {
				return _mainInfoControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _columnPathEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnPathEdit {
			get {
				return _columnPathEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _defaultCaptionEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit DefaultCaptionEdit {
			get {
				return _defaultCaptionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _columnPathLabel;
		public Terrasoft.UI.WebControls.Controls.Label ColumnPathLabel {
			get {
				return _columnPathLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _aggregationTypeEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit AggregationTypeEdit {
			get {
				return _aggregationTypeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _formatEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit FormatEdit {
			get {
				return _formatEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _filterControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return _filterControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _filterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return _filterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _dataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return _dataSource;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonControlLayout {
			get {
				return _buttonControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _contextHelpSpacer;
		public Terrasoft.UI.WebControls.Controls.Spacer ContextHelpSpacer {
			get {
				return _contextHelpSpacer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _okButton;
		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return _okButton;
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

		public StructureExplorerAggregationColumnEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public StructureExplorerAggregationColumnEditPageSchema(StructureExplorerAggregationColumnEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			RealUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			Name = "StructureExplorerAggregationColumnEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ValidationMessagePanel = "InfoMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateStructureExplorerAggregationColumnEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateMainInfoControlLayout());
			MainInfoControlLayout.InsertItem(0, CreateColumnPathEdit());
			MainInfoControlLayout.InsertItem(1, CreateDefaultCaptionEdit());
			MainInfoControlLayout.InsertItem(2, CreateColumnPathLabel());
			MainInfoControlLayout.InsertItem(3, CreateCaptionEdit());
			MainInfoControlLayout.InsertItem(4, CreateAggregationTypeEdit());
			MainInfoControlLayout.InsertItem(5, CreateFormatEdit());
			MainControlLayout.InsertItem(1, CreateFilterControlLayout());
			FilterControlLayout.InsertItem(0, CreateFilterEdit());
			Controls.AddAt(1, CreateDataSource());
			UpdateDataSource();
			Controls.AddAt(2, CreateButtonControlLayout());
			ButtonControlLayout.InsertItem(0, CreateContextHelpButton());
			ButtonControlLayout.InsertItem(1, CreateContextHelpSpacer());
			ButtonControlLayout.InsertItem(2, CreateOkButton());
			ButtonControlLayout.InsertItem(3, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateStructureExplorerAggregationColumnEditPageEventsProcessSchema() {
			var schema = new StructureExplorerAggregationColumnEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateColumnPathEdit() {
			_columnPathEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_columnPathEdit.UId = new Guid("3110a298-f74c-4c93-893d-6061a9ee08b9");
			_columnPathEdit.Name = "ColumnPathEdit";
			_columnPathEdit.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_columnPathEdit.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_columnPathEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnPathEdit.Tag = "";
			_columnPathEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnPathEdit.Image = new ControlImage {};
			_columnPathEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnPathEdit.Enabled = false;
			_columnPathEdit.Required = true;
			return _columnPathEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateDefaultCaptionEdit() {
			_defaultCaptionEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_defaultCaptionEdit.UId = new Guid("290029c3-c388-4085-aa5c-fbc5c02671c4");
			_defaultCaptionEdit.Name = "DefaultCaptionEdit";
			_defaultCaptionEdit.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_defaultCaptionEdit.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_defaultCaptionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_defaultCaptionEdit.Tag = "";
			_defaultCaptionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_defaultCaptionEdit.Image = new ControlImage {};
			_defaultCaptionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_defaultCaptionEdit.Hidden = true;
			return _defaultCaptionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateColumnPathLabel() {
			_columnPathLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_columnPathLabel.UId = new Guid("8e4ae467-f7c1-4788-bf8e-9b323360e067");
			_columnPathLabel.Name = "ColumnPathLabel";
			_columnPathLabel.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_columnPathLabel.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_columnPathLabel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnPathLabel.Tag = "";
			_columnPathLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnPathLabel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnPathLabel.Hidden = true;
			return _columnPathLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_captionEdit.UId = new Guid("820109e3-2f59-421b-b93b-2ed5fac48663");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_captionEdit.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_captionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionEdit.Required = true;
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateAggregationTypeEdit() {
			_aggregationTypeEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_aggregationTypeEdit.UId = new Guid("61330587-aec2-4aba-bee7-63a2ee9099cd");
			_aggregationTypeEdit.Name = "AggregationTypeEdit";
			_aggregationTypeEdit.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_aggregationTypeEdit.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_aggregationTypeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_aggregationTypeEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_aggregationTypeEdit.Tag = "";
			_aggregationTypeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_aggregationTypeEdit.Image = new ControlImage {};
			_aggregationTypeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_aggregationTypeEdit.Required = true;
			return _aggregationTypeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateFormatEdit() {
			_formatEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_formatEdit.UId = new Guid("51ffebfb-5b3b-45e8-b164-07f138fc0669");
			_formatEdit.Name = "FormatEdit";
			_formatEdit.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_formatEdit.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_formatEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_formatEdit.Tag = "";
			_formatEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_formatEdit.Image = new ControlImage {};
			_formatEdit.Width = System.Web.UI.WebControls.Unit.Percentage(50);
			_formatEdit.Hidden = true;
			return _formatEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainInfoControlLayout() {
			_mainInfoControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainInfoControlLayout.UId = new Guid("468f385d-6aaa-44b2-b8fc-0a656cc4898c");
			_mainInfoControlLayout.Name = "MainInfoControlLayout";
			_mainInfoControlLayout.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_mainInfoControlLayout.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_mainInfoControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainInfoControlLayout.Tag = "";
			_mainInfoControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_mainInfoControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_mainInfoControlLayout.FitHeightByContent = true;
			_mainInfoControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainInfoControlLayout.StartNewAlignGroup = false;
			_mainInfoControlLayout.Image = new ControlImage {};
			_mainInfoControlLayout.Edges = "";
			_mainInfoControlLayout.MaxCaptionWidth = 80;
			return _mainInfoControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("8f0194a1-1df1-46cb-bbdb-d9622643e036");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_filterEdit.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "DataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFilterControlLayout() {
			_filterControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_filterControlLayout.UId = new Guid("548d9e61-612f-40c5-8e1b-d34d143b3e65");
			_filterControlLayout.Name = "FilterControlLayout";
			_filterControlLayout.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_filterControlLayout.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_filterControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterControlLayout.Tag = "";
			_filterControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_filterControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.Padding = "3 0 6 0";
			_filterControlLayout.StartNewAlignGroup = false;
			_filterControlLayout.Image = new ControlImage {};
			_filterControlLayout.Edges = "";
			return _filterControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("e4c907aa-eee2-4491-87b6-6976374e3ff5");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.DefaultMargins = "5 5 5 5";
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			return _mainControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateDataSource() {
			_dataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_dataSource.UId = new Guid("d2530a89-7e61-4ee8-82ea-e4aacada15c9");
			_dataSource.Name = "DataSource";
			_dataSource.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_dataSource.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_dataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataSource.Tag = "";
			_dataSource.EnableServerActiveRow = false;
			_dataSource.SchemaUId = Guid.Empty;
			_dataSource.HierarchicalDepth = 1;
			_dataSource.DefStructure.ID = "c" + _dataSource.DefStructure.UId.ToString("N");
			_dataSource.DefStructure.UId = new Guid("70fdba9e-74f1-4d5e-8065-280a5f22e539");
			_dataSource.DefStructure.Name = "DefStructure";
			_dataSource.DefStructure.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_dataSource.DefStructure.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			return _dataSource;
		}

		protected virtual void UpdateDataSource() {
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("92f8a5e1-5513-49d8-bdc2-73039ad57af4");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.HelpContextId = "424";
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateContextHelpSpacer() {
			_contextHelpSpacer = new Terrasoft.UI.WebControls.Controls.Spacer();
			_contextHelpSpacer.UId = new Guid("b5facc75-1ba1-4bbc-a70e-71c9ffbf21ac");
			_contextHelpSpacer.Name = "ContextHelpSpacer";
			_contextHelpSpacer.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_contextHelpSpacer.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_contextHelpSpacer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpSpacer.Tag = "";
			_contextHelpSpacer.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _contextHelpSpacer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("4ba908bc-ab2b-416d-a560-c2668598a05f");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_okButton.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_okButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("8e666335-7ff9-432b-89ee-438dae169914");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_cancelButton.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonControlLayout() {
			_buttonControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonControlLayout.UId = new Guid("3960de69-ea40-4c21-a44e-36882c0afc44");
			_buttonControlLayout.Name = "ButtonControlLayout";
			_buttonControlLayout.CreatedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_buttonControlLayout.ModifiedInSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			_buttonControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttonControlLayout.Tag = "";
			_buttonControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttonControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_buttonControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonControlLayout.StartNewAlignGroup = false;
			_buttonControlLayout.Image = new ControlImage {};
			_buttonControlLayout.Edges = "";
			return _buttonControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new StructureExplorerAggregationColumnEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new StructureExplorerAggregationColumnEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new StructureExplorerAggregationColumnEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: StructureExplorerAggregationColumnEditPageEventsProcess

	/// <exclude/>
	public class StructureExplorerAggregationColumnEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.StructureExplorerAggregationColumnEditPageSchemaUserControl
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

		public StructureExplorerAggregationColumnEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "StructureExplorerAggregationColumnEditPageEventsProcess";
			SchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c");
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

		public virtual Guid FiltersGroupUId {
			get;
			set;
		}

		private ProcessFlowElement _pageLoadEventSubProcess;
		public ProcessFlowElement PageLoadEventSubProcess {
			get {
				return _pageLoadEventSubProcess ?? (_pageLoadEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadEventSubProcess",
					SchemaElementUId = new Guid("8802f77d-a5dd-40cb-a3f2-a90caf4fb054"),
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
					SchemaElementUId = new Guid("63bb1667-adec-4d28-9b36-1815e0f53c3a"),
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
					SchemaElementUId = new Guid("94a17148-1f2b-439d-962c-6e57124c9735"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _okButtonEventSubProcess;
		public ProcessFlowElement OkButtonEventSubProcess {
			get {
				return _okButtonEventSubProcess ?? (_okButtonEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OkButtonEventSubProcess",
					SchemaElementUId = new Guid("989124c7-b998-4ce9-9ad7-73b458f02818"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickStartMessage;
		public ProcessFlowElement OkButtonClickStartMessage {
			get {
				return _okButtonClickStartMessage ?? (_okButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickStartMessage",
					SchemaElementUId = new Guid("d8be593a-e63e-406c-8f52-a0e54f1bdcb4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickScriptTask;
		public ProcessScriptTask OkButtonClickScriptTask {
			get {
				return _okButtonClickScriptTask ?? (_okButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickScriptTask",
					SchemaElementUId = new Guid("dbe26feb-eb9a-4aa5-91c3-5c8bdf258b00"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _cancelButtonEventSubProcess;
		public ProcessFlowElement CancelButtonEventSubProcess {
			get {
				return _cancelButtonEventSubProcess ?? (_cancelButtonEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CancelButtonEventSubProcess",
					SchemaElementUId = new Guid("0038132d-f8d8-4c67-9420-a76685c5553b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickStartMessage;
		public ProcessFlowElement CancelButtonClickStartMessage {
			get {
				return _cancelButtonClickStartMessage ?? (_cancelButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CancelButtonClickStartMessage",
					SchemaElementUId = new Guid("bcb6d493-b713-4e40-83cd-c5802dd978ef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _cancelButtonClickScriptTask;
		public ProcessScriptTask CancelButtonClickScriptTask {
			get {
				return _cancelButtonClickScriptTask ?? (_cancelButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CancelButtonClickScriptTask",
					SchemaElementUId = new Guid("04771cc0-28d5-4181-8386-87de5e2e5c57"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _aggregationTypeEditChangeEventSubProcess;
		public ProcessFlowElement AggregationTypeEditChangeEventSubProcess {
			get {
				return _aggregationTypeEditChangeEventSubProcess ?? (_aggregationTypeEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AggregationTypeEditChangeEventSubProcess",
					SchemaElementUId = new Guid("a55d5d22-1875-431d-8881-70f12e9da9a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _aggregationTypeEditChangeStartMessage;
		public ProcessFlowElement AggregationTypeEditChangeStartMessage {
			get {
				return _aggregationTypeEditChangeStartMessage ?? (_aggregationTypeEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AggregationTypeEditChangeStartMessage",
					SchemaElementUId = new Guid("eb15e60e-d47c-4094-88b8-39e37dd60646"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _aggregationTypeEditChangeScriptTask;
		public ProcessScriptTask AggregationTypeEditChangeScriptTask {
			get {
				return _aggregationTypeEditChangeScriptTask ?? (_aggregationTypeEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AggregationTypeEditChangeScriptTask",
					SchemaElementUId = new Guid("ab3ed600-09e1-4ed6-8055-d2d1bdc84b15"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AggregationTypeEditChangeScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PageLoadEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadEventSubProcess };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[OkButtonEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonEventSubProcess };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[OkButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScriptTask };
			FlowElements[CancelButtonEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonEventSubProcess };
			FlowElements[CancelButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage };
			FlowElements[CancelButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask };
			FlowElements[AggregationTypeEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AggregationTypeEditChangeEventSubProcess };
			FlowElements[AggregationTypeEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AggregationTypeEditChangeStartMessage };
			FlowElements[AggregationTypeEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AggregationTypeEditChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PageLoadEventSubProcess":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "OkButtonEventSubProcess":
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OkButtonClickScriptTask");
						break;
					case "OkButtonClickScriptTask":
						break;
					case "CancelButtonEventSubProcess":
						break;
					case "CancelButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask");
						break;
					case "CancelButtonClickScriptTask":
						break;
					case "AggregationTypeEditChangeEventSubProcess":
						break;
					case "AggregationTypeEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("AggregationTypeEditChangeScriptTask");
						break;
					case "AggregationTypeEditChangeScriptTask":
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
			ActivatedEventElements.Add("OkButtonClickStartMessage");
			ActivatedEventElements.Add("CancelButtonClickStartMessage");
			ActivatedEventElements.Add("AggregationTypeEditChangeStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PageLoadEventSubProcess":
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
				case "OkButtonEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage";
					result = OkButtonClickStartMessage.Execute(context);
					break;
				case "OkButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickScriptTask";
					result = OkButtonClickScriptTask.Execute(context, OkButtonClickScriptTaskExecute);
					break;
				case "CancelButtonEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickStartMessage";
					result = CancelButtonClickStartMessage.Execute(context);
					break;
				case "CancelButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickScriptTask";
					result = CancelButtonClickScriptTask.Execute(context, CancelButtonClickScriptTaskExecute);
					break;
				case "AggregationTypeEditChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AggregationTypeEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AggregationTypeEditChangeStartMessage";
					result = AggregationTypeEditChangeStartMessage.Execute(context);
					break;
				case "AggregationTypeEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AggregationTypeEditChangeScriptTask";
					result = AggregationTypeEditChangeScriptTask.Execute(context, AggregationTypeEditChangeScriptTaskExecute);
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
				case "FiltersGroupUId":
					FiltersGroupUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			Page.FilterEdit.AggregationEnable = false;
			Page.DataSource.SchemaUId = new Guid(Page.Request.QueryString["rootSchemaUId"].ToString());
			if (Page.DataSource.SchemaManager.FindInstanceByUId(Page.DataSource.SchemaUId) == null) {
				Page.DataSource.ManagerName = "SystemEntitySchemaManager";
			}
			EntityDataSourceUtilities.SynchronizeStructure(Page.DataSource);
			var filterEditGroup = Page.DataSource.FindFiltersGroupByName("FilterEdit");
			FiltersGroupUId = filterEditGroup.UId;
			
			var itemStoreKey = Page.Request.QueryString["itemStoreKey"].ToString();
			var serializedItem = UserConnection.SessionData[itemStoreKey].ToString();
			var item = (JObject)Json.Deserialize(serializedItem);
			var metaPath = item.Property("MetaPath").Value.ToString();
			bool isOppositeColumn = metaPath.Contains("[");
			var currentPrimaryColumnUId = metaPath.Substring(metaPath.LastIndexOf('.') + 1).ToLowerInvariant();
			var datasourcePrimaryColumnUId = Page.DataSource.Schema.PrimaryColumn.UId.ToString().ToLowerInvariant();
			bool isVirtual = isOppositeColumn && currentPrimaryColumnUId == datasourcePrimaryColumnUId;
			var dataValueType = item.Property("DataValueType").Value.ToString();
			
			var sb = new StringBuilder();
			string clientId = Page.AggregationTypeEdit.ClientID as string;
			string template = "this." + clientId + ".addItem('{0}','{1}');";
			string scrCount = string.Format(template, AggregationType.Count,
				new LocalizableString("Terrasoft.Core", "AggregationType.Count"));
			string scrMin = string.Format(template, AggregationType.Min,
				new LocalizableString("Terrasoft.Core", "AggregationType.Min"));
			string scrMax = string.Format(template, AggregationType.Max,
				new LocalizableString("Terrasoft.Core", "AggregationType.Max"));
			string scrSum = string.Format(template, AggregationType.Sum,
				new LocalizableString("Terrasoft.Core", "AggregationType.Sum"));
			string scrAvg = string.Format(template, AggregationType.Avg,
				new LocalizableString("Terrasoft.Core", "AggregationType.Avg"));
			if (isVirtual && dataValueType == "Integer") {
				sb.Append(scrCount);
				sb.Append("this." + clientId + ".setEnabled(false);");
			} else if (dataValueType == "DateTime" || dataValueType == "Date" || dataValueType == "Time") {
				sb.Append(scrMin);
				sb.Append(scrMax);
			} else if ((dataValueType == "Integer" && !isVirtual) ||dataValueType == "Money"
				|| dataValueType == "Float1" ||dataValueType == "Float2"
				|| dataValueType == "Float3" || dataValueType == "Float4") {
				sb.Append(scrSum);
				sb.Append(scrAvg);
				sb.Append(scrMin);
				sb.Append(scrMax);
			}
			Page.ScriptManager.AddScript(sb.ToString());
			Page.ColumnPathEdit.SetValue(item.Property("MetaPathCaption").Value.ToString());
			Page.CaptionEdit.SetValue(item.Property("Caption").Value.ToString());
			Page.DefaultCaptionEdit.SetValue(item.Property("Caption").Value.ToString());
			var aggrType = item.Property("AggregationType").Value.ToString();
			if (!string.IsNullOrEmpty(aggrType)) {
				Page.AggregationTypeEdit.SetValueAndText(aggrType, new LocalizableString("Terrasoft.Core", "AggregationType." + aggrType));
			}
			var serializedSubFilters = item.Property("SubFilters") != null ? item.Property("SubFilters").Value.ToString() : null;
			if (!string.IsNullOrEmpty(serializedSubFilters)) {
				serializedSubFilters = serializedSubFilters.Substring(1, serializedSubFilters.Length - 2);
				var ds = Page.DataSource;
				var converter = new DataSourceFiltersJsonConverter(UserConnection, ds);
				var subFilters = JsonConvert.DeserializeObject<DataSourceFilterCollection>(serializedSubFilters, converter);
				ds.CurrentStructure.Filters.Clear();
				ds.CurrentStructure.Filters.Add(subFilters);
			}
			if (!isOppositeColumn) {
				Page.AggregationTypeEdit.SetEnabled(false);
				Page.FormatEdit.SetVisible(false);
				Page.FilterEdit.SetEnabled(false);
			}
			Page.DataSource.LoadStructure();
			return true;
		}

		public virtual bool OkButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			var itemStoreKey = Page.Request.QueryString["itemStoreKey"].ToString();
			UserConnection.SessionData.Remove(itemStoreKey);
			var filterGroup = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			JsonConverter converter = new DataSourceFiltersJsonConverter(UserConnection, Page.DataSource); 
			string serializedFilter = Json.Serialize(filterGroup, converter); 
			serializedFilter = filterGroup.Count > 0 ? Json.Serialize(serializedFilter) : string.Empty;
			string script = @"var key = window.name; if (window.opener) {
				var columnPropertiesEditPageParams = window.opener.window.columnEditPageParams[key];
				var id = columnPropertiesEditPageParams['columnId'];
				var structureExplorer = window.opener[columnPropertiesEditPageParams.structureExplorerId];
				var dataSource = structureExplorer.selectedItemsGrid.dataSource;
				var row = dataSource.findRow(dataSource.getPrimaryColumnName(), id);
				row.setColumnValue('Caption','" + Page.CaptionEdit.Text + @"'); 
				if ("+Page.FilterEdit.ClientID+ @".enabled == true) { 
					row.setColumnValue('AggregationType','" + Page.AggregationTypeEdit.SelectedItem.Value + @"'); 
					row.setColumnValue('SubFilters','" + serializedFilter + @"'); 
				}
				dataSource.fireEvent('rowloaded', dataSource, [row.columns], {}); 
			}";
			Page.ScriptManager.AddScript(script);
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool CancelButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool AggregationTypeEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.CaptionEdit.Value.Equals(Page.DefaultCaptionEdit.Value)) {	
				Page.DefaultCaptionEdit.Value = Page.CaptionEdit.Value = string.Format("{0}({1})",Page.AggregationTypeEdit.SelectedItem.Text,Page.ColumnPathEdit.Value);
			}
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
			return true;
		}

		public virtual bool GetIsContextHelpEnabled() {
			return (bool)SysSettings.GetValue(UserConnection, "EnableContextHelp");
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CancelButtonClickStartMessage");
						}
						break;
					case "AggregationTypeEditChange":
							if (ActivatedEventElements.Contains("AggregationTypeEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("AggregationTypeEditChangeStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("FiltersGroupUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FiltersGroupUId", FiltersGroupUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: StructureExplorerAggregationColumnEditPageEventsProcess

	/// <exclude/>
	public class StructureExplorerAggregationColumnEditPageEventsProcess : StructureExplorerAggregationColumnEditPageEventsProcess<Terrasoft.WebApp.StructureExplorerAggregationColumnEditPageSchemaUserControl>
	{

		public StructureExplorerAggregationColumnEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: StructureExplorerAggregationColumnEditPageSchemaUserControl

	/// <exclude/>
	public partial class StructureExplorerAggregationColumnEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainInfoControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainInfoControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnPathEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ColumnPathEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit DefaultCaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("DefaultCaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label ColumnPathLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("ColumnPathLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit AggregationTypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("AggregationTypeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit FormatEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("FormatEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("FilterControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("FilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("DataSource", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer ContextHelpSpacer {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("ContextHelpSpacer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OkButton", true);
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
			AggregationTypeEdit.AjaxEvents.Change.Event += AggregationTypeEditChange;
			OkButton.AjaxEvents.Click.Event += OkButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AggregationTypeEdit.AjaxEvents.Change.Event -= AggregationTypeEditChange;
			OkButton.AjaxEvents.Click.Event -= OkButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (StructureExplorerAggregationColumnEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new StructureExplorerAggregationColumnEditPageEventsProcess(UserConnection);
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

		public virtual void AggregationTypeEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("AggregationTypeEditChange");
		}

		public virtual void OkButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OkButtonClick");
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
			SchemaName = "StructureExplorerAggregationColumnEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: StructureExplorerAggregationColumnEditPageEventsProcessSchema

	/// <exclude/>
	public class StructureExplorerAggregationColumnEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public StructureExplorerAggregationColumnEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public StructureExplorerAggregationColumnEditPageEventsProcessSchema(StructureExplorerAggregationColumnEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "StructureExplorerAggregationColumnEditPageEventsProcess";
			UId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec");
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

		protected virtual ProcessSchemaParameter CreateFiltersGroupUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("53aede04-3b8d-4103-9e73-81c13eeab4fc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"FiltersGroupUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFiltersGroupUIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet63 = CreateLaneSet63LaneSet();
			LaneSets.Add(schemaLaneSet63);
			ProcessSchemaLane schemaLane167 = CreateLane167Lane();
			schemaLaneSet63.Lanes.Add(schemaLane167);
			ProcessSchemaLane schemaLane168 = CreateLane168Lane();
			schemaLaneSet63.Lanes.Add(schemaLane168);
			ProcessSchemaEventSubProcess pageloadeventsubprocess = CreatePageLoadEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadeventsubprocess);
			ProcessSchemaEventSubProcess okbuttoneventsubprocess = CreateOkButtonEventSubProcessEventSubProcess();
			FlowElements.Add(okbuttoneventsubprocess);
			ProcessSchemaEventSubProcess cancelbuttoneventsubprocess = CreateCancelButtonEventSubProcessEventSubProcess();
			FlowElements.Add(cancelbuttoneventsubprocess);
			ProcessSchemaEventSubProcess aggregationtypeeditchangeeventsubprocess = CreateAggregationTypeEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(aggregationtypeeditchangeeventsubprocess);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			pageloadeventsubprocess.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageloadeventsubprocess.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			okbuttoneventsubprocess.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOkButtonClickScriptTaskScriptTask();
			okbuttoneventsubprocess.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage = CreateCancelButtonClickStartMessageStartMessageEvent();
			cancelbuttoneventsubprocess.FlowElements.Add(cancelbuttonclickstartmessage);
			ProcessSchemaScriptTask cancelbuttonclickscripttask = CreateCancelButtonClickScriptTaskScriptTask();
			cancelbuttoneventsubprocess.FlowElements.Add(cancelbuttonclickscripttask);
			ProcessSchemaStartMessageEvent aggregationtypeeditchangestartmessage = CreateAggregationTypeEditChangeStartMessageStartMessageEvent();
			aggregationtypeeditchangeeventsubprocess.FlowElements.Add(aggregationtypeeditchangestartmessage);
			ProcessSchemaScriptTask aggregationtypeeditchangescripttask = CreateAggregationTypeEditChangeScriptTaskScriptTask();
			aggregationtypeeditchangeeventsubprocess.FlowElements.Add(aggregationtypeeditchangescripttask);
			FlowElements.Add(CreateSequenceFlow543SequenceFlow());
			FlowElements.Add(CreateSequenceFlow544SequenceFlow());
			FlowElements.Add(CreateSequenceFlow545SequenceFlow());
			FlowElements.Add(CreateSequenceFlow546SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow543SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow543",
				UId = new Guid("461bc62d-7e4d-459c-b9c5-77db851164b3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				CurveCenterPosition = new Point(230, 99),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63bb1667-adec-4d28-9b36-1815e0f53c3a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("94a17148-1f2b-439d-962c-6e57124c9735"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow544SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow544",
				UId = new Guid("b310d8ac-ca6f-4956-a704-6bc5f8561b40"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8be593a-e63e-406c-8f52-a0e54f1bdcb4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dbe26feb-eb9a-4aa5-91c3-5c8bdf258b00"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow545SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow545",
				UId = new Guid("e311f024-0254-4094-81b6-27e48475a8e9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bcb6d493-b713-4e40-83cd-c5802dd978ef"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("04771cc0-28d5-4181-8386-87de5e2e5c57"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow546SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow546",
				UId = new Guid("eff6589b-aae6-44b7-be04-9ea9cfbb40a4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eb15e60e-d47c-4094-88b8-39e37dd60646"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab3ed600-09e1-4ed6-8055-d2d1bdc84b15"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet63LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet63 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("eec26f9a-1ba5-4c6a-890f-7e4e05605dc1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"LaneSet63",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1139, 528),
				UseBackgroundMode = false
			};
			return schemaLaneSet63;
		}

		protected virtual ProcessSchemaLane CreateLane167Lane() {
			ProcessSchemaLane schemaLane167 = new ProcessSchemaLane(this) {
				UId = new Guid("02904883-8ffc-4b11-b4fc-2f728a17b55f"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("eec26f9a-1ba5-4c6a-890f-7e4e05605dc1"),
				CreatedInOwnerSchemaUId = new Guid("77cc08f9-9a2b-4e25-b7d0-b0be761fc74c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"Lane167",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 343),
				Size = new Size(1110, 185),
				UseBackgroundMode = false
			};
			return schemaLane167;
		}

		protected virtual ProcessSchemaLane CreateLane168Lane() {
			ProcessSchemaLane schemaLane168 = new ProcessSchemaLane(this) {
				UId = new Guid("bb03e3d9-c5b3-4a74-bdbf-b287c5cb6b10"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("eec26f9a-1ba5-4c6a-890f-7e4e05605dc1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"Lane168",
				Position = new Point(29, 0),
				Size = new Size(1110, 338),
				UseBackgroundMode = false
			};
			return schemaLane168;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8802f77d-a5dd-40cb-a3f2-a90caf4fb054"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02904883-8ffc-4b11-b4fc-2f728a17b55f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"PageLoadEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(294, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("63bb1667-adec-4d28-9b36-1815e0f53c3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8802f77d-a5dd-40cb-a3f2-a90caf4fb054"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("94a17148-1f2b-439d-962c-6e57124c9735"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8802f77d-a5dd-40cb-a3f2-a90caf4fb054"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,87,223,83,227,54,16,126,46,51,252,15,194,15,23,123,46,245,148,235,61,149,210,14,4,184,201,21,142,180,14,247,194,244,65,177,55,65,29,71,114,37,153,75,202,241,191,223,74,242,175,56,74,90,202,19,65,250,246,219,111,87,187,210,122,66,23,16,95,177,92,131,188,204,152,142,207,22,11,9,11,170,153,224,151,156,206,114,32,167,100,78,115,5,39,135,7,19,131,189,160,154,38,162,148,41,196,73,250,0,75,122,55,206,16,195,225,11,249,80,178,44,180,160,63,224,239,18,148,142,127,47,65,174,19,45,25,95,220,7,82,8,221,152,4,127,198,83,225,118,194,40,66,114,54,39,161,223,193,13,229,184,46,81,37,207,198,92,105,202,83,56,95,35,199,14,60,238,68,228,20,37,149,121,30,145,167,195,131,239,250,184,138,241,19,93,154,240,130,100,173,52,44,47,185,102,122,189,225,50,64,93,207,135,7,110,167,181,191,211,44,103,154,129,138,147,53,79,31,164,224,236,31,192,88,202,84,151,18,250,170,76,112,143,84,146,121,147,228,15,82,148,5,58,238,203,50,1,186,163,80,22,114,190,54,10,195,160,61,158,192,144,117,33,46,249,61,234,24,87,17,231,220,50,12,45,209,66,194,111,176,174,125,122,143,167,11,220,56,157,74,191,2,201,104,142,145,102,99,68,34,213,29,174,140,4,231,144,154,106,137,19,80,10,255,154,120,238,187,92,30,42,230,8,194,143,183,179,191,208,58,250,168,208,254,2,26,15,225,166,175,218,108,9,154,78,168,126,64,83,195,16,79,164,40,64,234,117,24,220,84,59,65,20,127,166,121,9,155,46,103,66,228,132,169,219,162,16,10,13,71,34,47,151,28,73,106,190,24,163,208,148,113,21,6,247,65,237,44,45,165,4,174,39,146,45,169,92,59,27,151,237,198,44,41,103,202,121,105,150,174,169,210,99,158,193,234,118,30,14,226,65,68,222,146,227,8,213,92,139,47,32,199,28,137,25,229,186,73,68,134,201,82,246,240,61,126,252,213,29,111,32,205,81,119,130,245,123,170,226,255,204,164,46,105,110,178,215,207,197,155,55,187,227,61,221,163,178,19,134,205,251,116,93,192,246,233,92,116,183,253,71,84,149,216,172,186,73,220,206,121,201,242,12,164,5,184,68,147,52,103,40,178,77,79,231,186,50,228,246,10,27,57,204,5,161,138,56,179,214,30,133,21,57,213,182,237,245,3,83,113,128,39,212,144,190,37,65,76,51,91,115,225,224,233,135,231,193,112,240,116,252,60,136,78,130,150,65,165,88,244,37,215,200,224,86,226,43,33,151,84,135,53,245,144,244,68,197,22,63,196,123,200,132,118,45,82,83,217,230,106,173,226,15,166,32,37,38,120,142,210,177,101,130,33,9,188,12,65,20,109,200,184,97,252,5,34,16,253,42,9,104,191,37,128,174,94,34,128,174,94,39,128,174,250,2,146,114,249,2,1,136,126,149,0,180,239,11,56,123,92,188,64,0,162,95,37,0,237,131,230,173,108,251,25,155,183,215,128,88,220,99,174,193,188,96,238,1,84,179,248,172,40,128,103,97,93,190,134,166,179,188,163,25,20,104,55,5,100,161,29,2,176,19,140,225,51,1,252,135,24,25,219,158,177,219,97,202,150,16,144,175,95,61,194,204,246,142,45,107,229,17,140,165,215,147,235,138,175,39,197,163,165,206,130,201,209,81,147,177,8,221,111,99,111,4,199,135,15,221,120,181,93,229,130,234,227,192,107,105,247,222,237,55,253,113,71,204,118,243,189,47,106,44,183,237,168,177,4,60,169,216,151,159,106,108,75,82,201,10,93,143,82,103,89,230,22,66,180,217,156,195,44,218,93,240,230,69,179,55,106,2,218,170,14,119,60,187,35,90,152,34,245,92,237,45,163,131,236,165,251,15,52,23,48,167,101,174,95,207,102,158,27,138,253,229,127,177,122,157,231,127,179,76,205,29,85,189,63,86,159,112,218,188,149,151,203,2,237,107,226,168,51,126,250,94,170,90,250,25,207,166,176,210,141,221,144,252,239,59,194,180,112,235,222,21,192,230,244,134,83,75,53,65,110,199,221,238,97,69,30,185,17,154,252,186,15,181,149,24,242,147,181,218,155,31,159,152,42,87,59,116,250,150,59,243,215,241,208,143,184,6,190,192,121,241,123,242,206,54,136,157,85,212,246,104,85,239,165,130,63,98,136,32,171,49,164,69,84,132,102,80,29,213,160,112,115,0,30,34,117,227,69,117,197,119,172,186,83,174,27,126,127,238,59,193,222,203,29,227,47,222,68,13,91,153,214,93,166,226,145,155,221,154,79,144,184,142,127,148,3,117,243,211,94,24,94,7,97,171,184,170,26,123,124,253,73,241,223,11,186,247,94,212,104,247,56,54,85,207,20,67,212,22,168,253,14,245,49,61,111,127,130,94,11,154,181,95,94,6,36,1,127,114,130,107,112,242,13,63,230,246,31,221,14,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOkButtonEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOkButtonEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("989124c7-b998-4ce9-9ad7-73b458f02818"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb03e3d9-c5b3-4a74-bdbf-b287c5cb6b10"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"OkButtonEventSubProcess",
				Position = new Point(50, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(240, 148),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOkButtonEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d8be593a-e63e-406c-8f52-a0e54f1bdcb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("989124c7-b998-4ce9-9ad7-73b458f02818"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(28, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dbe26feb-eb9a-4aa5-91c3-5c8bdf258b00"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("989124c7-b998-4ce9-9ad7-73b458f02818"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"OkButtonClickScriptTask",
				Position = new Point(133, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,148,223,111,218,48,16,199,159,225,175,176,242,146,160,70,214,158,23,117,107,71,217,196,166,77,172,161,219,3,234,131,33,7,178,150,216,217,217,129,178,138,255,125,103,59,37,1,170,62,37,57,223,247,115,63,157,173,64,38,45,84,185,213,8,223,96,207,174,217,76,108,128,223,195,223,6,140,229,63,27,192,125,110,81,170,205,34,234,59,70,143,124,174,195,65,50,202,134,15,6,112,172,149,130,149,149,90,241,28,140,161,231,157,176,130,80,149,222,66,210,23,147,96,75,129,215,178,180,128,95,80,55,245,75,220,207,222,52,41,164,229,78,156,235,6,87,206,170,138,112,98,188,247,167,253,15,81,65,18,117,222,17,33,191,26,173,40,135,45,32,25,217,234,248,118,205,20,236,88,135,107,73,39,238,201,105,1,105,200,166,211,140,50,54,52,190,90,70,142,82,148,242,31,180,41,17,223,161,168,230,214,158,244,234,74,187,60,60,226,82,219,115,230,99,221,40,203,62,176,119,236,227,57,243,92,57,98,239,89,72,136,79,170,218,238,179,99,122,43,148,181,37,240,77,228,122,252,199,207,116,71,13,212,59,174,168,107,25,147,107,150,180,6,93,131,114,172,231,225,192,57,175,116,217,84,106,134,100,70,43,193,184,206,186,70,204,4,138,202,116,156,32,227,237,87,80,157,250,46,40,238,99,22,168,178,32,229,219,232,69,28,206,167,69,252,162,162,114,154,149,109,16,38,79,117,73,107,131,231,225,23,111,35,249,5,96,90,188,176,139,227,92,9,122,225,199,13,148,180,6,80,76,105,101,105,225,100,193,59,65,75,64,189,35,105,103,230,107,74,237,94,239,146,158,105,3,118,134,178,18,184,31,251,76,253,206,142,82,234,7,45,235,128,8,20,200,134,163,95,162,108,32,137,199,162,118,219,23,167,113,196,174,194,10,182,38,127,35,230,240,100,201,126,19,197,110,151,6,110,142,209,213,249,181,25,151,18,148,157,222,57,63,14,74,44,75,160,254,95,51,170,18,104,208,164,123,53,244,237,102,131,176,17,46,214,124,95,67,63,133,179,35,31,37,239,181,136,123,68,47,177,87,3,228,205,178,189,120,45,251,226,46,116,128,195,112,112,210,90,154,205,150,138,74,98,2,151,90,20,80,196,105,175,249,41,91,224,113,15,205,99,202,158,15,14,115,136,178,161,47,32,247,87,226,187,80,244,129,252,182,40,130,33,9,87,133,134,145,132,58,77,237,158,76,24,54,7,68,97,244,218,242,135,41,255,13,75,250,51,88,212,165,225,206,97,68,61,214,6,220,111,15,129,22,71,249,222,102,255,1,96,67,232,151,75,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCancelButtonEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCancelButtonEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0038132d-f8d8-4c67-9420-a76685c5553b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb03e3d9-c5b3-4a74-bdbf-b287c5cb6b10"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"CancelButtonEventSubProcess",
				Position = new Point(316, 13),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(220, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCancelButtonEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bcb6d493-b713-4e40-83cd-c5802dd978ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0038132d-f8d8-4c67-9420-a76685c5553b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"CancelButtonClickStartMessage",
				Position = new Point(21, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("04771cc0-28d5-4181-8386-87de5e2e5c57"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0038132d-f8d8-4c67-9420-a76685c5553b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"CancelButtonClickScriptTask",
				Position = new Point(119, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAggregationTypeEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAggregationTypeEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a55d5d22-1875-431d-8881-70f12e9da9a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb03e3d9-c5b3-4a74-bdbf-b287c5cb6b10"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"AggregationTypeEditChangeEventSubProcess",
				Position = new Point(50, 177),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAggregationTypeEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAggregationTypeEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("eb15e60e-d47c-4094-88b8-39e37dd60646"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a55d5d22-1875-431d-8881-70f12e9da9a5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AggregationTypeEditChange",
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"AggregationTypeEditChangeStartMessage",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAggregationTypeEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ab3ed600-09e1-4ed6-8055-d2d1bdc84b15"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a55d5d22-1875-431d-8881-70f12e9da9a5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				Name = @"AggregationTypeEditChangeScriptTask",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,205,10,130,64,20,70,215,250,20,131,43,133,24,106,45,45,194,12,218,9,73,251,75,94,167,129,249,177,235,29,40,100,222,189,210,77,80,180,62,231,240,125,186,23,121,3,10,101,5,3,107,239,234,78,179,60,131,9,40,235,91,0,51,46,116,143,61,4,195,95,82,81,136,41,73,147,191,142,216,138,223,11,47,48,50,105,167,228,193,147,5,206,179,105,29,243,105,19,139,108,53,23,59,165,8,21,188,171,246,49,224,92,158,208,224,133,177,59,50,90,217,226,157,23,181,242,38,88,215,0,95,63,206,149,105,76,9,57,144,19,76,1,203,39,148,27,22,42,237,0,0,0 }
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
				UId = new Guid("efc05df3-a43f-4da2-847e-98a8440a58e6"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b87f839a-4831-42a9-a121-33905cd5e24e"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("252de8e0-b2cc-4ac5-a820-00ecda122f5e"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b7c3ece2-d9b5-4345-9a68-c2c07012566c"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8a932710-a921-4b20-927f-65ce23192183"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,185,174,194,48,16,69,107,248,138,33,5,36,2,249,7,158,40,216,4,41,88,4,72,212,134,76,32,224,140,35,219,1,36,196,191,63,59,129,2,16,75,101,207,213,185,103,38,137,193,175,13,209,132,186,39,201,224,217,140,80,100,221,220,24,73,163,36,138,144,252,0,234,117,120,38,6,196,215,2,35,63,8,224,82,173,204,248,22,217,75,159,149,2,104,67,204,133,198,191,183,92,152,186,124,33,115,181,65,75,59,64,73,81,164,101,200,230,168,139,207,152,147,13,213,55,213,19,62,225,169,243,122,75,84,138,107,25,27,182,194,117,39,203,188,95,61,161,193,244,46,217,89,136,101,180,253,80,238,236,249,121,112,68,50,154,245,68,178,57,176,41,217,215,206,69,248,120,137,171,221,12,76,239,228,201,205,62,229,66,180,160,225,65,19,222,172,40,125,97,223,18,94,35,176,183,92,255,1,60,248,138,253,201,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5a4993ed-6da4-47e1-80b2-e659e4a97689"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b6201f36-bf1f-46fb-a0b1-3b64551a443d"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new StructureExplorerAggregationColumnEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b15cf2bb-0b53-4e95-8216-3770ac1594ec"));
		}

		#endregion

	}

	#endregion

}

