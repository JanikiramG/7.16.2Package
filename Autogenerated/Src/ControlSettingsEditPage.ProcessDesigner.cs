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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: ControlSettingsEditPageSchema

	/// <exclude/>
	public class ControlSettingsEditPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _settingControlsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout SettingControlsControlLayout {
			get {
				return _settingControlsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _controlEditTypes;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ControlEditTypes {
			get {
				return _controlEditTypes;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _bookOfReferenceEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit BookOfReferenceEdit {
			get {
				return _bookOfReferenceEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _listEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ListEdit {
			get {
				return _listEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _textValueEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit TextValueEdit {
			get {
				return _textValueEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _generatedSignalEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit GeneratedSignalEdit {
			get {
				return _generatedSignalEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _dataFilterEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit DataFilterEdit {
			get {
				return _dataFilterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _checkBox1;
		public Terrasoft.UI.WebControls.Controls.CheckBox CheckBox1 {
			get {
				return _checkBox1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _checkBox2;
		public Terrasoft.UI.WebControls.Controls.CheckBox CheckBox2 {
			get {
				return _checkBox2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _utilsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout UtilsControlLayout {
			get {
				return _utilsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
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

		public ControlSettingsEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ControlSettingsEditPageSchema(ControlSettingsEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			RealUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			Name = "ControlSettingsEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			Width = 550;
			Height = 400;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateControlSettingsEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateSettingControlsControlLayout());
			SettingControlsControlLayout.InsertItem(0, CreateCaptionEdit());
			SettingControlsControlLayout.InsertItem(1, CreateNameEdit());
			SettingControlsControlLayout.InsertItem(2, CreateControlEditTypes());
			SettingControlsControlLayout.InsertItem(3, CreateBookOfReferenceEdit());
			SettingControlsControlLayout.InsertItem(4, CreateListEdit());
			SettingControlsControlLayout.InsertItem(5, CreateTextValueEdit());
			SettingControlsControlLayout.InsertItem(6, CreateGeneratedSignalEdit());
			SettingControlsControlLayout.InsertItem(7, CreateDataFilterEdit());
			SettingControlsControlLayout.InsertItem(8, CreateCheckBox1());
			SettingControlsControlLayout.InsertItem(9, CreateCheckBox2());
			Controls.AddAt(2, CreateUtilsControlLayout());
			UtilsControlLayout.InsertItem(0, CreateSpacer1());
			UtilsControlLayout.InsertItem(1, CreateOkButton());
			UtilsControlLayout.InsertItem(2, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateControlSettingsEditPageEventsProcessSchema() {
			var schema = new ControlSettingsEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("1bd3121a-5df6-426e-8816-a39c40b57b6d");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_baseMessagePanel.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_captionEdit.UId = new Guid("922ef0fd-2af7-4d26-86f7-dc0fe75bff17");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_captionEdit.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_captionEdit.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionEdit.Required = true;
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("adf1047c-ed2f-4b74-88bc-e3be126b61f8");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_nameEdit.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_nameEdit.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.Required = true;
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateControlEditTypes() {
			_controlEditTypes = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_controlEditTypes.UId = new Guid("8ace8866-c89b-419a-bad0-be24558d95b3");
			_controlEditTypes.Name = "ControlEditTypes";
			_controlEditTypes.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_controlEditTypes.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_controlEditTypes.CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4");
			_controlEditTypes.AjaxEvents.Change.IsProcessEventHandler = true;
			_controlEditTypes.Tag = "";
			_controlEditTypes.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_controlEditTypes.Image = new ControlImage {};
			_controlEditTypes.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlEditTypes.Required = true;
			return _controlEditTypes;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateBookOfReferenceEdit() {
			_bookOfReferenceEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_bookOfReferenceEdit.UId = new Guid("301c51d2-631f-46dd-be24-428229f455c9");
			_bookOfReferenceEdit.Name = "BookOfReferenceEdit";
			_bookOfReferenceEdit.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_bookOfReferenceEdit.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_bookOfReferenceEdit.CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4");
			_bookOfReferenceEdit.Tag = "";
			_bookOfReferenceEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_bookOfReferenceEdit.Image = new ControlImage {};
			_bookOfReferenceEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bookOfReferenceEdit.Required = true;
			_bookOfReferenceEdit.LookupSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111");
			return _bookOfReferenceEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateListEdit() {
			_listEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_listEdit.UId = new Guid("eba21ebc-2b8a-4388-8ede-782c13b10c94");
			_listEdit.Name = "ListEdit";
			_listEdit.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_listEdit.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_listEdit.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_listEdit.Tag = "";
			_listEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_listEdit.Image = new ControlImage {};
			_listEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_listEdit.Required = true;
			_listEdit.StrictedToItemsList = false;
			return _listEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateTextValueEdit() {
			_textValueEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_textValueEdit.UId = new Guid("bc1f7d8a-4071-453a-80f4-c576cbf1e206");
			_textValueEdit.Name = "TextValueEdit";
			_textValueEdit.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_textValueEdit.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_textValueEdit.CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4");
			_textValueEdit.Tag = "";
			_textValueEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_textValueEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _textValueEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateGeneratedSignalEdit() {
			_generatedSignalEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_generatedSignalEdit.UId = new Guid("c6e00e46-ff0b-4891-a365-392865261f36");
			_generatedSignalEdit.Name = "GeneratedSignalEdit";
			_generatedSignalEdit.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_generatedSignalEdit.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_generatedSignalEdit.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_generatedSignalEdit.Tag = "";
			_generatedSignalEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_generatedSignalEdit.Image = new ControlImage {};
			_generatedSignalEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _generatedSignalEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateDataFilterEdit() {
			_dataFilterEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_dataFilterEdit.UId = new Guid("2d30f043-9c85-4384-a2e6-9a20353d2dee");
			_dataFilterEdit.Name = "DataFilterEdit";
			_dataFilterEdit.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_dataFilterEdit.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_dataFilterEdit.CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4");
			_dataFilterEdit.Tag = "";
			_dataFilterEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_dataFilterEdit.Image = new ControlImage {};
			_dataFilterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _dataFilterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateCheckBox1() {
			_checkBox1 = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_checkBox1.UId = new Guid("c4ee2c73-84ec-4efe-86c9-6fa862209c21");
			_checkBox1.Name = "CheckBox1";
			_checkBox1.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_checkBox1.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_checkBox1.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_checkBox1.Tag = "";
			_checkBox1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkBox1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_checkBox1.AlignedByCaption = false;
			return _checkBox1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateCheckBox2() {
			_checkBox2 = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_checkBox2.UId = new Guid("9c1f4b8b-694d-4b87-bf15-4c47de1c7a2d");
			_checkBox2.Name = "CheckBox2";
			_checkBox2.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_checkBox2.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_checkBox2.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_checkBox2.Tag = "";
			_checkBox2.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkBox2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_checkBox2.AlignedByCaption = false;
			return _checkBox2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateSettingControlsControlLayout() {
			_settingControlsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_settingControlsControlLayout.UId = new Guid("d95f8c81-b334-45ef-9f3b-3cd962de8349");
			_settingControlsControlLayout.Name = "SettingControlsControlLayout";
			_settingControlsControlLayout.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_settingControlsControlLayout.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_settingControlsControlLayout.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_settingControlsControlLayout.Tag = "";
			_settingControlsControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_settingControlsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_settingControlsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_settingControlsControlLayout.Padding = "5 5 5 5";
			_settingControlsControlLayout.StartNewAlignGroup = false;
			_settingControlsControlLayout.Image = new ControlImage {};
			_settingControlsControlLayout.Edges = "";
			return _settingControlsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("ca907656-7a91-42e4-8fb7-315d32e24743");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_spacer1.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_spacer1.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("24d11d16-8571-48ff-9f22-7fdda0a343e0");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_okButton.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_okButton.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("c9bd9df4-4854-421d-af52-abf460f68b13");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_cancelButton.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_cancelButton.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateUtilsControlLayout() {
			_utilsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_utilsControlLayout.UId = new Guid("cf35406d-a5f5-43f3-885d-69421903282d");
			_utilsControlLayout.Name = "UtilsControlLayout";
			_utilsControlLayout.CreatedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_utilsControlLayout.ModifiedInSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			_utilsControlLayout.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_utilsControlLayout.Tag = "";
			_utilsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_utilsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_utilsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_utilsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_utilsControlLayout.StartNewAlignGroup = false;
			_utilsControlLayout.Image = new ControlImage {};
			_utilsControlLayout.Edges = "";
			return _utilsControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ControlSettingsEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ControlSettingsEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ControlSettingsEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ControlSettingsEditPageEventsProcess

	/// <exclude/>
	public class ControlSettingsEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.ControlSettingsEditPageSchemaUserControl
	{

		#region Class: OpenGroupOfElementsEditPageUserTaskFlowElement

		/// <exclude/>
		public class OpenGroupOfElementsEditPageUserTaskFlowElement : OpenPageUserTask
		{

			public OpenGroupOfElementsEditPageUserTaskFlowElement(UserConnection userConnection, ControlSettingsEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenGroupOfElementsEditPageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418");
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

		public ControlSettingsEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ControlSettingsEditPageEventsProcess";
			SchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea");
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

		public virtual string ItemId {
			get;
			set;
		}

		public virtual string ContextKey {
			get;
			set;
		}

		public virtual bool IsButtonSettings {
			get;
			set;
		}

		public virtual Guid EditSchemaUId {
			get;
			set;
		}

		public virtual bool IsValidData {
			get;
			set;
		}

		public virtual string Message {
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
					SchemaElementUId = new Guid("1a062eac-072c-42c0-9fc9-0c2043f9172b"),
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
					SchemaElementUId = new Guid("81e611cc-da10-4b2e-9c71-8b9acfec609a"),
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
					SchemaElementUId = new Guid("bb278bea-612a-4f79-b824-e5378e8fbd1a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("cf8e8e4e-f758-40e3-a076-b2b64b0164b1"),
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

		private ProcessScriptTask _getIsValidInputDataScriptTask;
		public ProcessScriptTask GetIsValidInputDataScriptTask {
			get {
				return _getIsValidInputDataScriptTask ?? (_getIsValidInputDataScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GetIsValidInputDataScriptTask",
					SchemaElementUId = new Guid("694c7282-ffd0-4c9e-9e03-dbb04353f246"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = GetIsValidInputDataScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _showMassageScriptTask;
		public ProcessScriptTask ShowMassageScriptTask {
			get {
				return _showMassageScriptTask ?? (_showMassageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowMassageScriptTask",
					SchemaElementUId = new Guid("1eef88ab-da2f-413b-b283-eb5923e2ae2b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowMassageScriptTaskExecute,
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
					SchemaElementUId = new Guid("dfa0cf54-0422-4b5d-bfb4-929ca15d8bf4"),
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
					SchemaElementUId = new Guid("5c3e0274-57d1-4484-a042-1af6ede9f8f8"),
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
					SchemaElementUId = new Guid("0ad0eaf5-c833-45fb-b2d9-a18c4e556fe3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("284d39c7-ad3f-4f36-b33a-7712dd3621e7"),
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
					SchemaElementUId = new Guid("dc61a001-7391-4a83-bd4b-33e7f6a0eec9"),
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
					SchemaElementUId = new Guid("bbea9236-285c-4b35-a503-dc8fa5175c47"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _initEventSubProcess;
		public ProcessFlowElement InitEventSubProcess {
			get {
				return _initEventSubProcess ?? (_initEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitEventSubProcess",
					SchemaElementUId = new Guid("1a8933d9-aca7-4d03-a27a-199692b7abcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("9877116e-4622-489d-a544-66d81f75cc64"),
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
					SchemaElementUId = new Guid("5be15d9e-9e9c-432a-92ac-b8d81821b1da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _controlEditTypesChangeEventSubProcess;
		public ProcessFlowElement ControlEditTypesChangeEventSubProcess {
			get {
				return _controlEditTypesChangeEventSubProcess ?? (_controlEditTypesChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ControlEditTypesChangeEventSubProcess",
					SchemaElementUId = new Guid("5d1ba57e-f9df-4346-b348-2003aada822a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _controlEditTypesChangeStartMessage;
		public ProcessFlowElement ControlEditTypesChangeStartMessage {
			get {
				return _controlEditTypesChangeStartMessage ?? (_controlEditTypesChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ControlEditTypesChangeStartMessage",
					SchemaElementUId = new Guid("9755cfa1-4f47-4893-ad0e-e151ba5be220"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _controlEditTypesChangeScriptTask;
		public ProcessScriptTask ControlEditTypesChangeScriptTask {
			get {
				return _controlEditTypesChangeScriptTask ?? (_controlEditTypesChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ControlEditTypesChangeScriptTask",
					SchemaElementUId = new Guid("432f9a4f-5fee-49a5-869f-988c5ff36764"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ControlEditTypesChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _elementsInGroupButtonClickEventSubProcess;
		public ProcessFlowElement ElementsInGroupButtonClickEventSubProcess {
			get {
				return _elementsInGroupButtonClickEventSubProcess ?? (_elementsInGroupButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ElementsInGroupButtonClickEventSubProcess",
					SchemaElementUId = new Guid("a5bdae7b-f9b4-44c0-9887-6abd4dcaf782"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _elementsInGroupButtonClickStartMessage;
		public ProcessFlowElement ElementsInGroupButtonClickStartMessage {
			get {
				return _elementsInGroupButtonClickStartMessage ?? (_elementsInGroupButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ElementsInGroupButtonClickStartMessage",
					SchemaElementUId = new Guid("931921c3-e22f-4814-8ccc-b8cf89230008"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _elementsInGroupButtonClickScriptTask;
		public ProcessScriptTask ElementsInGroupButtonClickScriptTask {
			get {
				return _elementsInGroupButtonClickScriptTask ?? (_elementsInGroupButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ElementsInGroupButtonClickScriptTask",
					SchemaElementUId = new Guid("f068311a-b84d-4fe5-aa89-2d21cb65c923"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ElementsInGroupButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenGroupOfElementsEditPageUserTaskFlowElement _openGroupOfElementsEditPageUserTask;
		public OpenGroupOfElementsEditPageUserTaskFlowElement OpenGroupOfElementsEditPageUserTask {
			get {
				return _openGroupOfElementsEditPageUserTask ?? (_openGroupOfElementsEditPageUserTask = new OpenGroupOfElementsEditPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _closedGroupOfElementsSettingsEditPageEventSubProcess;
		public ProcessFlowElement ClosedGroupOfElementsSettingsEditPageEventSubProcess {
			get {
				return _closedGroupOfElementsSettingsEditPageEventSubProcess ?? (_closedGroupOfElementsSettingsEditPageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ClosedGroupOfElementsSettingsEditPageEventSubProcess",
					SchemaElementUId = new Guid("548d2d71-1058-4e88-96c4-450c1ff8106e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _closedGroupOfElementsSettingsEditPageScriptTask;
		public ProcessScriptTask ClosedGroupOfElementsSettingsEditPageScriptTask {
			get {
				return _closedGroupOfElementsSettingsEditPageScriptTask ?? (_closedGroupOfElementsSettingsEditPageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClosedGroupOfElementsSettingsEditPageScriptTask",
					SchemaElementUId = new Guid("f2070451-dac4-4bb8-a626-4861bd7b2f04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ClosedGroupOfElementsSettingsEditPageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _closedGroupOfElementsSettingsEditPageStartMessage;
		public ProcessFlowElement ClosedGroupOfElementsSettingsEditPageStartMessage {
			get {
				return _closedGroupOfElementsSettingsEditPageStartMessage ?? (_closedGroupOfElementsSettingsEditPageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ClosedGroupOfElementsSettingsEditPageStartMessage",
					SchemaElementUId = new Guid("8588769d-072c-4e16-b0a5-2cfe2ebe96d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessConditionalFlow _isValidDataConditionalFlow;
		public ProcessConditionalFlow IsValidDataConditionalFlow {
			get {
				return _isValidDataConditionalFlow ?? (_isValidDataConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsValidDataConditionalFlow",
					SchemaElementUId = new Guid("af093931-a9c1-41fb-8c1c-62ad1eb89fa7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _commentsLocalizableString;
		public LocalizableString CommentsLocalizableString {
			get {
				return _commentsLocalizableString ?? (_commentsLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CommentsLocalizableString.Value"));
			}
		}

		private LocalizableString _groupOfElementsLocalizableString;
		public LocalizableString GroupOfElementsLocalizableString {
			get {
				return _groupOfElementsLocalizableString ?? (_groupOfElementsLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.GroupOfElementsLocalizableString.Value"));
			}
		}

		private LocalizableString _textFieldLocalizableString;
		public LocalizableString TextFieldLocalizableString {
			get {
				return _textFieldLocalizableString ?? (_textFieldLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TextFieldLocalizableString.Value"));
			}
		}

		private LocalizableString _selectionFieldLocalizableString;
		public LocalizableString SelectionFieldLocalizableString {
			get {
				return _selectionFieldLocalizableString ?? (_selectionFieldLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SelectionFieldLocalizableString.Value"));
			}
		}

		private LocalizableString _logicalFieldLocalizableString;
		public LocalizableString LogicalFieldLocalizableString {
			get {
				return _logicalFieldLocalizableString ?? (_logicalFieldLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LogicalFieldLocalizableString.Value"));
			}
		}

		private LocalizableString _dateTimeFieldLocalizableString;
		public LocalizableString DateTimeFieldLocalizableString {
			get {
				return _dateTimeFieldLocalizableString ?? (_dateTimeFieldLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DateTimeFieldLocalizableString.Value"));
			}
		}

		private LocalizableString _integerFieldLocalizableString;
		public LocalizableString IntegerFieldLocalizableString {
			get {
				return _integerFieldLocalizableString ?? (_integerFieldLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IntegerFieldLocalizableString.Value"));
			}
		}

		private LocalizableString _floatFieldLocalizableString;
		public LocalizableString FloatFieldLocalizableString {
			get {
				return _floatFieldLocalizableString ?? (_floatFieldLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FloatFieldLocalizableString.Value"));
			}
		}

		private LocalizableString _performValidationCaption;
		public LocalizableString PerformValidationCaption {
			get {
				return _performValidationCaption ?? (_performValidationCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PerformValidationCaption.Value"));
			}
		}

		private LocalizableString _isEnabledCaption;
		public LocalizableString IsEnabledCaption {
			get {
				return _isEnabledCaption ?? (_isEnabledCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IsEnabledCaption.Value"));
			}
		}

		private LocalizableString _isMultilineCaption;
		public LocalizableString IsMultilineCaption {
			get {
				return _isMultilineCaption ?? (_isMultilineCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IsMultilineCaption.Value"));
			}
		}

		private LocalizableString _isRquiredCaption;
		public LocalizableString IsRquiredCaption {
			get {
				return _isRquiredCaption ?? (_isRquiredCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IsRquiredCaption.Value"));
			}
		}

		private LocalizableString _canBeMinimizedCaption;
		public LocalizableString CanBeMinimizedCaption {
			get {
				return _canBeMinimizedCaption ?? (_canBeMinimizedCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CanBeMinimizedCaption.Value"));
			}
		}

		private LocalizableString _minimizedCaption;
		public LocalizableString MinimizedCaption {
			get {
				return _minimizedCaption ?? (_minimizedCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.MinimizedCaption.Value"));
			}
		}

		private LocalizableString _styleCaption;
		public LocalizableString StyleCaption {
			get {
				return _styleCaption ?? (_styleCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.StyleCaption.Value"));
			}
		}

		private LocalizableString _dateTimeFormatCaption;
		public LocalizableString DateTimeFormatCaption {
			get {
				return _dateTimeFormatCaption ?? (_dateTimeFormatCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DateTimeFormatCaption.Value"));
			}
		}

		private LocalizableString _precisionCaption;
		public LocalizableString PrecisionCaption {
			get {
				return _precisionCaption ?? (_precisionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PrecisionCaption.Value"));
			}
		}

		private LocalizableString _viewsCaption;
		public LocalizableString ViewsCaption {
			get {
				return _viewsCaption ?? (_viewsCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ViewsCaption.Value"));
			}
		}

		private LocalizableString _lookupSelectionCaption;
		public LocalizableString LookupSelectionCaption {
			get {
				return _lookupSelectionCaption ?? (_lookupSelectionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LookupSelectionCaption.Value"));
			}
		}

		private LocalizableString _listSelectionCaption;
		public LocalizableString ListSelectionCaption {
			get {
				return _listSelectionCaption ?? (_listSelectionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ListSelectionCaption.Value"));
			}
		}

		private LocalizableString _radioButtonsCollectionCaption;
		public LocalizableString RadioButtonsCollectionCaption {
			get {
				return _radioButtonsCollectionCaption ?? (_radioButtonsCollectionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RadioButtonsCollectionCaption.Value"));
			}
		}

		private LocalizableString _defaultButtonStyleCaption;
		public LocalizableString DefaultButtonStyleCaption {
			get {
				return _defaultButtonStyleCaption ?? (_defaultButtonStyleCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DefaultButtonStyleCaption.Value"));
			}
		}

		private LocalizableString _greenButtonStyleCaption;
		public LocalizableString GreenButtonStyleCaption {
			get {
				return _greenButtonStyleCaption ?? (_greenButtonStyleCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.GreenButtonStyleCaption.Value"));
			}
		}

		private LocalizableString _redButtonStyleCaption;
		public LocalizableString RedButtonStyleCaption {
			get {
				return _redButtonStyleCaption ?? (_redButtonStyleCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RedButtonStyleCaption.Value"));
			}
		}

		private LocalizableString _blueButtonStyleCaption;
		public LocalizableString BlueButtonStyleCaption {
			get {
				return _blueButtonStyleCaption ?? (_blueButtonStyleCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.BlueButtonStyleCaption.Value"));
			}
		}

		private LocalizableString _greyButtonStyleCaption;
		public LocalizableString GreyButtonStyleCaption {
			get {
				return _greyButtonStyleCaption ?? (_greyButtonStyleCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.GreyButtonStyleCaption.Value"));
			}
		}

		private LocalizableString _transparentButtonStyleCaption;
		public LocalizableString TransparentButtonStyleCaption {
			get {
				return _transparentButtonStyleCaption ?? (_transparentButtonStyleCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TransparentButtonStyleCaption.Value"));
			}
		}

		private LocalizableString _dateFormatCaption;
		public LocalizableString DateFormatCaption {
			get {
				return _dateFormatCaption ?? (_dateFormatCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DateFormatCaption.Value"));
			}
		}

		private LocalizableString _timeFormatCaption;
		public LocalizableString TimeFormatCaption {
			get {
				return _timeFormatCaption ?? (_timeFormatCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.TimeFormatCaption.Value"));
			}
		}

		private LocalizableString _dateTimeCaption;
		public LocalizableString DateTimeCaption {
			get {
				return _dateTimeCaption ?? (_dateTimeCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DateTimeCaption.Value"));
			}
		}

		private LocalizableString _validationMessageTitle;
		public LocalizableString ValidationMessageTitle {
			get {
				return _validationMessageTitle ?? (_validationMessageTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTitle.Value"));
			}
		}

		private LocalizableString _validationMessage;
		public LocalizableString ValidationMessage {
			get {
				return _validationMessage ?? (_validationMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[OkButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[GetIsValidInputDataScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GetIsValidInputDataScriptTask };
			FlowElements[ShowMassageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMassageScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[CancelButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage };
			FlowElements[CancelButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask };
			FlowElements[InitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[ControlEditTypesChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ControlEditTypesChangeEventSubProcess };
			FlowElements[ControlEditTypesChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ControlEditTypesChangeStartMessage };
			FlowElements[ControlEditTypesChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ControlEditTypesChangeScriptTask };
			FlowElements[ElementsInGroupButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ElementsInGroupButtonClickEventSubProcess };
			FlowElements[ElementsInGroupButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ElementsInGroupButtonClickStartMessage };
			FlowElements[ElementsInGroupButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ElementsInGroupButtonClickScriptTask };
			FlowElements[OpenGroupOfElementsEditPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenGroupOfElementsEditPageUserTask };
			FlowElements[ClosedGroupOfElementsSettingsEditPageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ClosedGroupOfElementsSettingsEditPageEventSubProcess };
			FlowElements[ClosedGroupOfElementsSettingsEditPageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ClosedGroupOfElementsSettingsEditPageScriptTask };
			FlowElements[ClosedGroupOfElementsSettingsEditPageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ClosedGroupOfElementsSettingsEditPageStartMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("GetIsValidInputDataScriptTask");
						break;
					case "OkButtonClickScriptTask":
						break;
					case "ExclusiveGateway1":
						if (IsValidDataConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OkButtonClickScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ShowMassageScriptTask");
						break;
					case "GetIsValidInputDataScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ShowMassageScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "CancelButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask");
						break;
					case "CancelButtonClickScriptTask":
						break;
					case "InitEventSubProcess":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "ControlEditTypesChangeEventSubProcess":
						break;
					case "ControlEditTypesChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ControlEditTypesChangeScriptTask");
						break;
					case "ControlEditTypesChangeScriptTask":
						break;
					case "ElementsInGroupButtonClickEventSubProcess":
						break;
					case "ElementsInGroupButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ElementsInGroupButtonClickScriptTask");
						break;
					case "ElementsInGroupButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenGroupOfElementsEditPageUserTask");
						break;
					case "OpenGroupOfElementsEditPageUserTask":
						break;
					case "ClosedGroupOfElementsSettingsEditPageEventSubProcess":
						break;
					case "ClosedGroupOfElementsSettingsEditPageScriptTask":
						break;
					case "ClosedGroupOfElementsSettingsEditPageStartMessage":
						e.Context.QueueTasks.Enqueue("ClosedGroupOfElementsSettingsEditPageScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool IsValidDataConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(IsValidData);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OkButtonClickStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("CancelButtonClickStartMessage");
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("ControlEditTypesChangeStartMessage");
			ActivatedEventElements.Add("ElementsInGroupButtonClickStartMessage");
			ActivatedEventElements.Add("ClosedGroupOfElementsSettingsEditPageStartMessage");
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
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "GetIsValidInputDataScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GetIsValidInputDataScriptTask";
					result = GetIsValidInputDataScriptTask.Execute(context, GetIsValidInputDataScriptTaskExecute);
					break;
				case "ShowMassageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMassageScriptTask";
					result = ShowMassageScriptTask.Execute(context, ShowMassageScriptTaskExecute);
					break;
				case "EventSubProcess2":
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
				case "EventSubProcess3":
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
				case "InitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "ControlEditTypesChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ControlEditTypesChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ControlEditTypesChangeStartMessage";
					result = ControlEditTypesChangeStartMessage.Execute(context);
					break;
				case "ControlEditTypesChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ControlEditTypesChangeScriptTask";
					result = ControlEditTypesChangeScriptTask.Execute(context, ControlEditTypesChangeScriptTaskExecute);
					break;
				case "ElementsInGroupButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ElementsInGroupButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ElementsInGroupButtonClickStartMessage";
					result = ElementsInGroupButtonClickStartMessage.Execute(context);
					break;
				case "ElementsInGroupButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ElementsInGroupButtonClickScriptTask";
					result = ElementsInGroupButtonClickScriptTask.Execute(context, ElementsInGroupButtonClickScriptTaskExecute);
					break;
				case "OpenGroupOfElementsEditPageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenGroupOfElementsEditPageUserTask";
					result = OpenGroupOfElementsEditPageUserTask.Execute(context);
					break;
				case "ClosedGroupOfElementsSettingsEditPageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ClosedGroupOfElementsSettingsEditPageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClosedGroupOfElementsSettingsEditPageScriptTask";
					result = ClosedGroupOfElementsSettingsEditPageScriptTask.Execute(context, ClosedGroupOfElementsSettingsEditPageScriptTaskExecute);
					break;
				case "ClosedGroupOfElementsSettingsEditPageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClosedGroupOfElementsSettingsEditPageStartMessage";
					result = ClosedGroupOfElementsSettingsEditPageStartMessage.Execute(context);
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
				case "Message":
					Message = reader.GetValue<System.String>();
				break;
				case "IsValidData":
					IsValidData = reader.GetValue<System.Boolean>();
				break;
				case "EditSchemaUId":
					EditSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "IsButtonSettings":
					IsButtonSettings = reader.GetValue<System.Boolean>();
				break;
				case "ContextKey":
					ContextKey = reader.GetValue<System.String>();
				break;
				case "ItemId":
					ItemId = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool OkButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			List<Dictionary<string, object>> items = GetEditedItems();
			Dictionary<string, object> item = null;
			bool isNewItem = string.IsNullOrEmpty(ItemId);
			if (isNewItem) {
				item = new Dictionary<string, object>();
				item.Add("Id", Guid.NewGuid().ToString());
				items.Add(item);
			} else {
				item = GetEditedItem(items);
				item.Clear();
				item.Add("Id", ItemId);
			}
			if (IsButtonSettings) {
				AssignButtonSettings(ref item);
			} else {
				switch (Page.ControlEditTypes.SelectedItem.Value) {
					case "1": //TextField
						AssignTextFieldSettings(ref item);
						break;
					case "12": //LogicalField
						AssignBooleanFieldSettings(ref item);
						break;
					case "4":
						AssignIntegerFieldSettings(ref item);
						break;
					case "5":
						AssignFractionalFieldSettings(ref item);
						break;
					case "CommentaryField":
						AssignCommentaryFieldSettings(ref item);
						break;
					case "2":
						AssignGroupOfElementsSettings(ref item);
						break;
					case "DateTimeField":
						AssignDateTimeFieldSettings(ref item);
						break;
					case "SelectionField":
						AssignSelectionFieldSettings(ref item);
						break;
				}
			}
			
			UserConnection.SessionData[ContextKey] = items;
			/*
			string serializedItem = Json.Serialize(new {
				Id = item["name"],
				Caption = item["caption"],
			});
			var sb = new StringBuilder(@"(function() {
				if (!window.opener) {
					return;
				}
				var treeGrid = window.opener.window.Ext.getCmp('");
			sb.Append(Page.GetParameterValue("treeGridId"));
			sb.Append(@"');
				if (!treeGrid) {
					return;
				}
				var dataSource = treeGrid.dataSource;
				if (dataSource) {");
			if (string.IsNullOrEmpty(ItemId)) {
				sb.Append(@"
					var row = dataSource.createRow(");
				sb.Append(serializedItem);	
				sb.Append(@");
					dataSource.rows.insert(0, row.getPrimaryColumnValue(), row);
					dataSource.setActiveRow(row);
					dataSource.fireEvent('inserted', dataSource, row, { });");
			} else {
				sb.Append(@"
					var columns = ");
				sb.Append(serializedItem);	
				sb.Append(@";
					var row = dataSource.getRow(columns[dataSource.getPrimaryColumnName()]);
					for (var columnName in columns) {
						row.setColumnValue(columnName, columns[columnName]);
					}
					dataSource.fireEvent('rowloaded', dataSource, [row.columns], { });");
			}
			sb.Append(@"
				}
			})();
			window.close();");
			Page.AddScript(sb.ToString());
			*/
			((Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool GetIsValidInputDataScriptTaskExecute(ProcessExecutingContext context) {
			const string TerrasoftWebAppCommon = "Terrasoft.WebApp.Common";
			string controlName = Page.NameEdit.Text;
			if (string.IsNullOrWhiteSpace(controlName)) {
				Message = new LocalizableString(TerrasoftWebAppCommon, "Message.NotValidName.Msg");
				IsValidData = false;
				return true;
			}
			if (!controlName.IsValidIdentifier()) {
				Message = new LocalizableString(TerrasoftWebAppCommon, "Message.NotValidName.Msg");
				IsValidData = false;
				return true;
			}
			if (GetIsExistsControlName(controlName)) {
				Message = string.Format(new LocalizableString(
					TerrasoftWebAppCommon, "Message.DesignDublicateNames.Msg"), controlName);
				IsValidData = false;
				return true;
			}
			var keyWords = new List<string> {
				"Accept",
				"Cancel"
			};
			foreach(string keyWord in keyWords) {
				if (string.Compare(controlName, keyWord, true) == 0) {
					IsValidData = false;
					Message = string.Format(ValidationMessage, controlName);
					return true;
				}
			}
			IsValidData = true;
			return true;
		}

		public virtual bool ShowMassageScriptTaskExecute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.AddMessage(ValidationMessageTitle, Message, MessageType.Warning);
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			Page.OkButton.AjaxEvents.Click.CausesValidation = true;
			ContextKey = Page.GetParameterValue("contextKey").ToString();
			object qsParameter = Page.GetParameterValue("itemId");
			ItemId = qsParameter == null ? string.Empty : qsParameter.ToString();
			qsParameter = Page.GetParameterValue("isButtonSettings");
			IsButtonSettings = Convert.ToBoolean(qsParameter);
			List<Dictionary<string, object>> items;
			Dictionary<string, object> editededItem;
			if (string.IsNullOrEmpty(ItemId)) {
				items = null;
				editededItem = null;
			} else {
				items = GetEditedItems();
				editededItem = GetEditedItem(items);
			}
			string controlEditType;
			if (IsButtonSettings) {
				controlEditType = "button";
			} else {
				Page.ControlEditTypes.Hidden = false;
				InitComboBoxEditControl(Page.ControlEditTypes, GetControlEditTypes(), false);
				if (editededItem != null) {
					controlEditType = (string)editededItem["controlEditType"];
				} else {
					Page.TextValueEdit.Hidden = true;
					Page.CheckBox1.Hidden = true;
					Page.CheckBox2.Hidden = true;
					Page.ListEdit.Hidden = true;
					Page.GeneratedSignalEdit.Hidden = true;
					Page.BookOfReferenceEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					return true;
				}
			}
			AssignControls(controlEditType, editededItem, false);
			return true;
		}

		public virtual bool CancelButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			((Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			EditSchemaUId = new Guid(Page.GetParameterValue("editSchemaUId").ToString());
			IEnumerable<Guid> packageIds = Terrasoft.Core.Packages.WorkspaceUtilities.GetPackageHierarchyIds(UserConnection, GetDesignedProcessSchema().PackageUId,
				UserConnection.Workspace.Id);
			object[] objectPackageIds = packageIds.Cast<object>().ToArray();
			var packageIdFilter = new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.Equal},
				{"leftExpressionColumnPath", "SysPackage"},
				{"useDisplayValue", false},
				{"rightExpressionParameterValues", objectPackageIds}};
			var extendParentFilter = new Dictionary<string, object> {
				{"comparisonType", FilterComparisonType.Equal},
				{"leftExpressionColumnPath", "ExtendParent"},
				{"useDisplayValue", false},
				{"rightExpressionParameterValues", new object[] {false}}};
			Page.BookOfReferenceEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(packageIdFilter);
				filters.Add(extendParentFilter);
			};
			return true;
		}

		public virtual bool ControlEditTypesChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (!string.IsNullOrEmpty(ItemId)) {
				RemoveItem();
			}
			AssignControls(Page.ControlEditTypes.SelectedItem.Value, null, true);
			return true;
		}

		public virtual bool ElementsInGroupButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			OpenGroupOfElementsEditPageUserTask.OpenerInstanceId = InstanceUId;
			OpenGroupOfElementsEditPageUserTask.UseCurrentActivePage = true;
			//OpenGroupOfElementsEditPageUserTask.CloseMessage = "ClosedGroupOfElementsSettingsEditPage";
			//// ElementsInGroupEditPage
			OpenGroupOfElementsEditPageUserTask.PageUId = new Guid("5B1EB0BB-9143-4978-B36C-5FD9750C3C2F");
			var parameters = new Dictionary<string, string>() {
				{ "contextKey",  ContextKey},
				{ "editSchemaUId", EditSchemaUId.ToString() },
				{ "groupId",  ItemId.ToString() }
			};
			OpenGroupOfElementsEditPageUserTask.PageParameters = parameters;
			return true;
		}

		public virtual bool ClosedGroupOfElementsSettingsEditPageScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual List<Dictionary<string, object>> GetEditedItems() {
			var items = UserConnection.SessionData[ContextKey] as List<Dictionary<string, object>>;
			if (items == null) {
				items = new List<Dictionary<string, object>>();
			}
			return items;
		}

		public virtual Dictionary<string, object> GetEditedItem(List<Dictionary<string, object>> items) {
			/*
			if (items == null || items.Count == 0) {
				return null;
			}
			*/
			foreach(Dictionary<string, object> item in items) {
				if ((string)item["Id"] == ItemId) {
					return item;
				}
			}
			return null;
		}

		public virtual void AssignButtonSettings(ref Dictionary<string, object> item) {
			item.Add("name", Page.NameEdit.Text);
			item.Add("caption", Page.CaptionEdit.Text);
			item.Add("style", Page.ListEdit.SelectedItem.Value);
			item.Add("performValidation", Page.CheckBox1.Checked);
			item.Add("isEnabled", Page.CheckBox2.Checked);
			item.Add("generateSignal", Page.GeneratedSignalEdit.Text);
		}

		public virtual Dictionary<string, string> GetButtonStyles() {
			return new Dictionary<string, string>() {
				{"default", DefaultButtonStyleCaption},
				{"green", GreenButtonStyleCaption},
				{"red", RedButtonStyleCaption},
				{"blue", BlueButtonStyleCaption},
				{"grey", GreyButtonStyleCaption},
				{"transparent", TransparentButtonStyleCaption}
			};
		}

		public virtual Dictionary<string, string> GetControlEditTypes() {
			var controlEditTypes = new Dictionary<string, string>() {
				{"CommentaryField", CommentsLocalizableString},
				{"2", GroupOfElementsLocalizableString},
				{"1", TextFieldLocalizableString},
				{"SelectionField", SelectionFieldLocalizableString},
				{"12", LogicalFieldLocalizableString},
				{"DateTimeField", DateTimeFieldLocalizableString},
				{"4", IntegerFieldLocalizableString},
				{"5", FloatFieldLocalizableString}
			};
			return controlEditTypes;
		}

		public virtual void AssignTextFieldSettings(ref Dictionary<string, object> item) {
			item.Add("name", Page.NameEdit.Text);
			item.Add("caption", Page.CaptionEdit.Text);
			item.Add("controlEditType", Page.ControlEditTypes.SelectedItem.Value);
			item.Add("isMultiline", Page.CheckBox1.Checked);
			item.Add("isRequired", Page.CheckBox2.Checked);
		}

		public virtual void SetControlValuesButtonSettings(Dictionary<string, object> item) {
			foreach(KeyValuePair<string, object> property in item) {
				switch(property.Key) {
					case "name":
						Page.NameEdit.Text = (string)property.Value;
						break;
					case "caption":
						Page.CaptionEdit.Text = (string)property.Value;
						break;
					case "style":
						Page.ListEdit.SelectItem((string)property.Value);
						break;
					case "performValidation":
						Page.CheckBox1.Checked = Convert.ToBoolean(property.Value);
						break;
					case "isEnabled":
						Page.CheckBox2.Checked = Convert.ToBoolean(property.Value);
						break;
					case "generateSignal":
						Page.GeneratedSignalEdit.Text = (string)property.Value;
						break;
				}
			}
		}

		public virtual void SetControlValuesTextFieldSettings(Dictionary<string, object> item) {
			foreach(KeyValuePair<string, object> property in item) {
				switch(property.Key) {
					case "name":
						Page.NameEdit.Text = (string)property.Value;
						break;
					case "caption":
						Page.CaptionEdit.Text = (string)property.Value;
						break;
					case "controlEditType":
						Page.ControlEditTypes.SelectItem((string)property.Value);
						break;
					case "isMultiline":
						Page.CheckBox1.Checked = Convert.ToBoolean(property.Value);
						break;
					case "isRequired":
						Page.CheckBox2.Checked = Convert.ToBoolean(property.Value);
						break;
				}
			}
		}

		public virtual void AssignControls(string controlEditType, Dictionary<string, object> item, bool shouldClear) {
			switch (controlEditType) {
				case "CommentaryField":
					Page.TextValueEdit.Hidden = false;
					Page.CheckBox1.Hidden = true;
					Page.CheckBox2.Hidden = true;
					Page.ListEdit.Hidden = true;
					Page.GeneratedSignalEdit.Hidden = true;
					Page.BookOfReferenceEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					if (item != null) {
						SetControlValuesCommentaryFieldSettings(item);
					} else {
						
					}
					break;
				case "2":
					Page.CheckBox1.Hidden = false;
					Page.CheckBox2.Hidden = false;
					Page.CheckBox1.Caption = CanBeMinimizedCaption;
					Page.CheckBox2.Caption = MinimizedCaption;
					Page.ListEdit.Hidden = true;
					Page.GeneratedSignalEdit.Hidden = true;
					Page.BookOfReferenceEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					Page.TextValueEdit.Hidden = true;
					if (item != null) {
						SetControlValuesGroupOfElementsSettings(item);
					} else {
						
					}
					break;
				case "1": //TextField
					Page.CheckBox1.Hidden = false;
					Page.CheckBox2.Hidden = false;
					Page.CheckBox1.Caption = IsMultilineCaption;
					Page.CheckBox2.Caption = IsRquiredCaption;
					Page.ListEdit.Hidden = true;
					Page.GeneratedSignalEdit.Hidden = true;
					Page.BookOfReferenceEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					Page.TextValueEdit.Hidden = true;
					if (item != null) {
						SetControlValuesTextFieldSettings(item);
					} else {
						
					}
					break;
				case "SelectionField":
					Page.ListEdit.Caption = ViewsCaption;
					Page.ListEdit.Hidden = false;
					Dictionary<string, string> dataValueTypes = GetSelectionFieldDataValueTypes();
					InitListEditControl(dataValueTypes, shouldClear);
					//Page.ListEdit.SelectItem("10");
					Page.BookOfReferenceEdit.Hidden = false;
					Page.CheckBox1.Hidden = false;
					Page.CheckBox1.Caption = IsRquiredCaption;
					Page.CheckBox2.Hidden = true;
					Page.GeneratedSignalEdit.Hidden = true;
					Page.TextValueEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					if (item != null) {
						SetControlValuesSelectionFieldSettings(item);
					} else {
						/*
						var defValue = "10";
						Page.ListEdit.SetValueAndText(defValue, dataValueTypes[defValue]);
						*/
					}
					break;
				case "12": //LogicalField
					Page.TextValueEdit.Hidden = true;
					Page.CheckBox1.Hidden = true;
					Page.CheckBox2.Hidden = true;
					Page.ListEdit.Hidden = true;
					Page.GeneratedSignalEdit.Hidden = true;
					Page.BookOfReferenceEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					if (item != null) {
						SetControlValuesBooleanFieldSettings(item);
					} else {
						
					}
					break;
				case "DateTimeField":
					Page.CheckBox1.Hidden = false;
					Page.ListEdit.Hidden = false;
					Page.ListEdit.Caption = DateTimeFormatCaption;
					Page.CheckBox1.Caption = IsRquiredCaption;
					InitListEditControl(GetDateTimeFormats(), shouldClear);
					Page.TextValueEdit.Hidden = true;
					Page.CheckBox2.Hidden = true;
					Page.GeneratedSignalEdit.Hidden = true;
					Page.BookOfReferenceEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					if (item != null) {
						SetControlValuesDateTimeFieldSettings(item);
					} else {
						
					}
					break;
				case "4": //IntegerField
					Page.CheckBox1.Hidden = false;
					Page.CheckBox1.Caption = IsRquiredCaption;
					Page.TextValueEdit.Hidden = true;
					Page.CheckBox2.Hidden = true;
					Page.ListEdit.Hidden = true;
					Page.GeneratedSignalEdit.Hidden = true;
					Page.BookOfReferenceEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					if (item != null) {
						SetControlValuesItegerFieldSettings(item);
					} else {
						
					}
					break;
				case "5": //FloatField
					Page.CheckBox1.Hidden = false;
					Page.CheckBox1.Caption = IsRquiredCaption;
					Page.ListEdit.Hidden = true;
					//InitListEditControl(GetPrecisions(), shouldClear);
					//Page.ListEdit.Caption = PrecisionCaption;
					Page.TextValueEdit.Hidden = true;
					Page.CheckBox2.Hidden = true;
					Page.GeneratedSignalEdit.Hidden = true;
					Page.BookOfReferenceEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					if (item != null) {
						SetControlValuesFractionalFieldSettings(item);
					} else {
						
					}
					break;
				case "button":
					Page.ListEdit.Hidden = false;
					Page.ListEdit.Caption = StyleCaption;
					Page.GeneratedSignalEdit.Hidden = false;
					Page.CheckBox1.Hidden = false;
					Page.CheckBox2.Hidden = false;
					Page.CheckBox1.Caption = PerformValidationCaption;
					Page.CheckBox2.Caption = IsEnabledCaption;
					Page.CheckBox1.Checked = true;
					Page.CheckBox2.Checked = true;
					InitListEditControl(GetButtonStyles(), false);
					Page.ListEdit.SelectItem("default");
					Page.ControlEditTypes.Hidden = true;
					Page.TextValueEdit.Hidden = true;
					Page.BookOfReferenceEdit.Hidden = true;
					Page.DataFilterEdit.Hidden = true;
					if (item != null) {
						SetControlValuesButtonSettings(item);
					} else {
						
					}
					break;
			}
		}

		public virtual void InitListEditControl(Dictionary<string, string> items, bool shouldClear) {
			InitComboBoxEditControl(Page.ListEdit, items, shouldClear);
		}

		public virtual Dictionary<string, string> GetDateTimeFormats() {
			return new Dictionary<string, string>() {
				{"7", DateTimeCaption},
				{"8", DateFormatCaption},
				{"9", TimeFormatCaption}
			};
		}

		public virtual Dictionary<string, string> GetPrecisions() {
			return null;
		}

		public virtual void InitComboBoxEditControl(ComboBoxEdit comboBoxEdit, Dictionary<string, string> items, bool shouldClear) {
			if (shouldClear) {
				comboBoxEdit.ClearItems();
			}
			foreach (KeyValuePair<string, string> item in items) {
				comboBoxEdit.AddItem(item.Key, item.Value);
			}
		}

		public virtual void SetControlValuesCommentaryFieldSettings(Dictionary<string, object> item) {
			foreach(KeyValuePair<string, object> property in item) {
				switch(property.Key) {
					case "name":
						Page.NameEdit.Text = (string)property.Value;
						break;
					case "caption":
						Page.CaptionEdit.Text = (string)property.Value;
						break;
					case "controlEditType":
						Page.ControlEditTypes.SelectItem((string)property.Value);
						break;
					case "text":
						Page.TextValueEdit.Text = (string)property.Value;
						break;
				}
			}
		}

		public virtual void SetControlValuesGroupOfElementsSettings(Dictionary<string, object> item) {
			foreach(KeyValuePair<string, object> property in item) {
				switch(property.Key) {
					case "name":
						Page.NameEdit.Text = (string)property.Value;
						break;
					case "caption":
						Page.CaptionEdit.Text = (string)property.Value;
						break;
					case "controlEditType":
						Page.ControlEditTypes.SelectItem((string)property.Value);
						break;
					case "canBeMinimized":
						Page.CheckBox1.Checked = (bool)property.Value;
						break;
					case "minimized":
						Page.CheckBox2.Checked = (bool)property.Value;
						break;
				}
			}
		}

		public virtual void SetControlValuesSelectionFieldSettings(Dictionary<string, object> item) {
			foreach(KeyValuePair<string, object> property in item) {
				switch(property.Key) {
					case "name":
						Page.NameEdit.Text = (string)property.Value;
						break;
					case "caption":
						Page.CaptionEdit.Text = (string)property.Value;
						break;
					case "controlEditType":
						Page.ControlEditTypes.SelectItem((string)property.Value);
						break;
					case "isRequired":
						Page.CheckBox1.Checked = Convert.ToBoolean(property.Value);
						break;
					case "dataSource":
						var entitySchemaUId = new Guid(property.Value.ToString());
						Guid entitySchemaId = GetSchemaIdByUId(entitySchemaUId);
						Page.BookOfReferenceEdit.SetValueAndText(entitySchemaId,
							UserConnection.EntitySchemaManager.GetItemByUId(entitySchemaUId).Caption);
						break;
					case "dataFilter":
						Page.DataFilterEdit.Text = (string)property.Value;
						break;
					case "controlDataValueType":
						Page.ListEdit.SelectItem((string)property.Value);
						break;
				}
			}
		}

		public virtual void SetControlValuesBooleanFieldSettings(Dictionary<string, object> item) {
			foreach(KeyValuePair<string, object> property in item) {
				switch(property.Key) {
					case "name":
						Page.NameEdit.Text = (string)property.Value;
						break;
					case "caption":
						Page.CaptionEdit.Text = (string)property.Value;
						break;
					case "controlEditType":
						Page.ControlEditTypes.SelectItem((string)property.Value);
						break;
				}
			}
		}

		public virtual void SetControlValuesItegerFieldSettings(Dictionary<string, object> item) {
			foreach(KeyValuePair<string, object> property in item) {
				switch(property.Key) {
					case "name":
						Page.NameEdit.Text = (string)property.Value;
						break;
					case "caption":
						Page.CaptionEdit.Text = (string)property.Value;
						break;
					case "controlEditType":
						Page.ControlEditTypes.SelectItem((string)property.Value);
						break;
					case "isRequired":
						Page.CheckBox1.Checked = Convert.ToBoolean(property.Value);
						break;
				}
			}
		}

		public virtual void SetControlValuesDateTimeFieldSettings(Dictionary<string, object> item) {
			foreach(KeyValuePair<string, object> property in item) {
				switch(property.Key) {
					case "name":
						Page.NameEdit.Text = (string)property.Value;
						break;
					case "caption":
						Page.CaptionEdit.Text = (string)property.Value;
						break;
					case "controlEditType":
						Page.ControlEditTypes.SelectItem((string)property.Value);
						break;
					case "isRequired":
						Page.CheckBox1.Checked = Convert.ToBoolean(property.Value);
						break;
					case "dateTimeFormat":
						Page.ListEdit.SelectItem((string)property.Value);
						break;
				}
			}
		}

		public virtual void SetControlValuesFractionalFieldSettings(Dictionary<string, object> item) {
			foreach(KeyValuePair<string, object> property in item) {
				switch(property.Key) {
					case "name":
						Page.NameEdit.Text = (string)property.Value;
						break;
					case "caption":
						Page.CaptionEdit.Text = (string)property.Value;
						break;
					case "controlEditType":
						Page.ControlEditTypes.SelectItem((string)property.Value);
						break;
					case "isRequired":
						Page.CheckBox1.Checked = Convert.ToBoolean(property.Value);
						break;
				}
			}
		}

		public virtual void RemoveItem() {
			List<Dictionary<string, object>> items = GetEditedItems();
			if (ItemId == null || items.Count == 0) {
				return;
			}
			int idx = 0;
			bool isNotFound = true;
			foreach (Dictionary<string, object> item in items) {
				if ((string)item["Id"] == ItemId) {
					break;
				}
				idx++;
				/*
				if (isNotFound) {
					if ((string)item["Id"] == ItemId) {
						if ((string)item["controlEditType"] != "2") {
							break;
						}
						isNotFound = false;
					} else {
						RemoveElementFromGroup(item, ItemId);
						idx++;
					}
					
				} else {
					RemoveElementFromGroup(item, ItemId);
				}
				*/
			}
			items.RemoveAt(idx);
			UserConnection.SessionData[ContextKey] = items;
			ItemId = null;
		}

		public virtual void AssignSelectionFieldSettings(ref Dictionary<string, object> item) {
			item.Add("name", Page.NameEdit.Text);
			item.Add("caption", Page.CaptionEdit.Text);
			item.Add("controlEditType", Page.ControlEditTypes.SelectedItem.Value);
			item.Add("isRequired", Page.CheckBox1.Checked);
			item.Add("dataFilter", Page.DataFilterEdit.Text);
			item.Add("controlDataValueType", Page.ListEdit.SelectedItem.Value);
			var entitySchemaId = (Guid)Page.BookOfReferenceEdit.Value;
			Guid entitySchemaUId = GetSchemaUIdById(entitySchemaId);
			item.Add("dataSource", entitySchemaUId.ToString());
		}

		public virtual Dictionary<string, string> GetSelectionFieldDataValueTypes() {
			var views = new Dictionary<string, string>() {
				{"10", LookupSelectionCaption},
				{"11", ListSelectionCaption}
				//{"2", RadioButtonsCollectionCaption}
			};
			return views;
		}

		public virtual void AssignCommentaryFieldSettings(ref Dictionary<string, object> item) {
			item.Add("name", Page.NameEdit.Text);
			item.Add("caption", Page.CaptionEdit.Text);
			item.Add("controlEditType", Page.ControlEditTypes.SelectedItem.Value);
			item.Add("text", Page.TextValueEdit.Text);
		}

		public virtual void AssignGroupOfElementsSettings(ref Dictionary<string, object> item) {
			item.Add("name", Page.NameEdit.Text);
			item.Add("caption", Page.CaptionEdit.Text);
			item.Add("controlEditType", Page.ControlEditTypes.SelectedItem.Value);
			item.Add("canBeMinimized", Page.CheckBox1.Checked);
			item.Add("minimized", Page.CheckBox2.Checked);
		}

		public virtual void AssignBooleanFieldSettings(ref Dictionary<string, object> item) {
			item.Add("name", Page.NameEdit.Text);
			item.Add("caption", Page.CaptionEdit.Text);
			item.Add("controlEditType", Page.ControlEditTypes.SelectedItem.Value);
		}

		public virtual void AssignDateTimeFieldSettings(ref Dictionary<string, object> item) {
			item.Add("name", Page.NameEdit.Text);
			item.Add("caption", Page.CaptionEdit.Text);
			item.Add("controlEditType", Page.ControlEditTypes.SelectedItem.Value);
			item.Add("isRequired", Page.CheckBox1.Checked);
			item.Add("dateTimeFormat", Page.ListEdit.SelectedItem.Value);
		}

		public virtual void AssignIntegerFieldSettings(ref Dictionary<string, object> item) {
			item.Add("name", Page.NameEdit.Text);
			item.Add("caption", Page.CaptionEdit.Text);
			item.Add("controlEditType", Page.ControlEditTypes.SelectedItem.Value);
			item.Add("isRequired", Page.CheckBox1.Checked);
		}

		public virtual void AssignFractionalFieldSettings(ref Dictionary<string, object> item) {
			item.Add("name", Page.NameEdit.Text);
			item.Add("caption", Page.CaptionEdit.Text);
			item.Add("controlEditType", Page.ControlEditTypes.SelectedItem.Value);
			item.Add("isRequired", Page.CheckBox1.Checked);
		}

		public virtual Guid GetSchemaUIdById(Guid schemaId) {
			return
				(new Select(UserConnection)
					.Column("UId")
				.From("SysSchema")
				.Where("Id")
				.IsEqual(Column.Parameter(schemaId)) as Select)
				.ExecuteScalar<Guid>();
		}

		public virtual Guid GetSchemaIdByUId(Guid schemaUId) {
			return
				(new Select(UserConnection)
					.Column("SysSchema", "Id")
				.From("SysSchema")
				.InnerJoin("SysPackage").On("SysPackage", "Id").IsEqual("SysSchema", "SysPackageId")
				.Where("SysSchema", "UId").IsEqual(Column.Parameter(schemaUId))
				.And("SysPackage", "SysWorkspaceId").IsEqual(Column.Parameter(UserConnection.Workspace.Id)) as Select)
				.ExecuteScalar<Guid>();
		}

		public virtual ProcessSchema GetDesignedProcessSchema() {
			return UserConnection.ProcessSchemaManager.GetDesignInstance(UserConnection, EditSchemaUId);
		}

		public virtual void RemoveElementFromGroup(Dictionary<string, object> item, string groupId) {
			object value;
			if ((string)item["controlEditType"] != "2"
					&& item.TryGetValue("groupId", out value) && value != null && (string)value == groupId) {
				item["groupId"] = null;
			}
		}

		public virtual bool GetIsExistsControlName(string controlName) {
			List<Dictionary<string, object>> items = GetEditedItems();
			if (items.Count == 0) {
				return false;
			}
			string existedItemId = null;
			foreach (Dictionary<string, object> item in items) {
				if ((string)item["name"] == controlName) {
					existedItemId = (string)item["Id"];
					break;
				}
			}
			if (existedItemId == null) {
				return false;
			}
			if (string.IsNullOrEmpty(ItemId)) {
				return true;
			}
			return existedItemId != ItemId;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CancelButtonClickStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
						}
						break;
					case "ControlEditTypesChange":
							if (ActivatedEventElements.Contains("ControlEditTypesChangeStartMessage")) {
							context.QueueTasks.Enqueue("ControlEditTypesChangeStartMessage");
						}
						break;
					case "ElementsInGroupButtonClick":
							if (ActivatedEventElements.Contains("ElementsInGroupButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("ElementsInGroupButtonClickStartMessage");
						}
						break;
					case "ClosedGroupOfElementsSettingsEditPage":
							if (ActivatedEventElements.Contains("ClosedGroupOfElementsSettingsEditPageStartMessage")) {
							context.QueueTasks.Enqueue("ClosedGroupOfElementsSettingsEditPageStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("Message") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("Message", Message, null);
			}
			if (!HasMapping("IsValidData") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsValidData", IsValidData, false);
			}
			if (!HasMapping("EditSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSchemaUId", EditSchemaUId, Guid.Empty);
			}
			if (!HasMapping("IsButtonSettings") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsButtonSettings", IsButtonSettings, false);
			}
			if (!HasMapping("ContextKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ContextKey", ContextKey, null);
			}
			if (!HasMapping("ItemId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ItemId", ItemId, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ControlSettingsEditPageEventsProcess

	/// <exclude/>
	public class ControlSettingsEditPageEventsProcess : ControlSettingsEditPageEventsProcess<Terrasoft.WebApp.ControlSettingsEditPageSchemaUserControl>
	{

		public ControlSettingsEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ControlSettingsEditPageSchemaUserControl

	/// <exclude/>
	public partial class ControlSettingsEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout SettingControlsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("SettingControlsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ControlEditTypes {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ControlEditTypes", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit BookOfReferenceEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("BookOfReferenceEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ListEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ListEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit TextValueEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("TextValueEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit GeneratedSignalEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("GeneratedSignalEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit DataFilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("DataFilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox CheckBox1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("CheckBox1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox CheckBox2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("CheckBox2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout UtilsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("UtilsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
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
			ControlEditTypes.AjaxEvents.Change.Event += ControlEditTypesChange;
			OkButton.AjaxEvents.Click.Event += OkButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ControlEditTypes.AjaxEvents.Change.Event -= ControlEditTypesChange;
			OkButton.AjaxEvents.Click.Event -= OkButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ControlSettingsEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ControlSettingsEditPageEventsProcess(UserConnection);
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

		public virtual void ControlEditTypesChange(object sender, EventArgs e) {
			object result = ThrowEvent("ControlEditTypesChange");
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
			SchemaName = "ControlSettingsEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ControlSettingsEditPageEventsProcessSchema

	/// <exclude/>
	public class ControlSettingsEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public ControlSettingsEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ControlSettingsEditPageEventsProcessSchema(ControlSettingsEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ControlSettingsEditPageEventsProcess";
			UId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a");
			CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
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

		protected virtual ProcessSchemaParameter CreateItemIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("66157174-3af3-4d37-97be-16e00926a568"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ItemId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("de05f6e1-476f-4419-b88b-e4ebf6f83893"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsButtonSettingsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3492d717-dec8-40f4-9c27-669ed0bdeec4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"IsButtonSettings",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("26e32b7e-7417-405c-9228-182de3d28e3b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"EditSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsValidDataParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("86400a6a-8df5-4ff7-982e-951ed383c3f9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"IsValidData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("99e22a17-bcef-4e16-a5bd-b8642ae39834"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"Message",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateItemIdParameter());
			Parameters.Add(CreateContextKeyParameter());
			Parameters.Add(CreateIsButtonSettingsParameter());
			Parameters.Add(CreateEditSchemaUIdParameter());
			Parameters.Add(CreateIsValidDataParameter());
			Parameters.Add(CreateMessageParameter());
		}

		protected virtual void InitializeOpenGroupOfElementsEditPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("37cd05dd-def2-4a78-87ec-ee70b5800ce9"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("6b2d97bd-c92e-43b9-a502-f509fcabb838"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("e7810254-1f2c-48da-9cb4-58f478d3cd9c"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("b33e52e8-38f9-4591-985e-199f500c6313"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("a92f425a-67e8-49fd-9f04-2475e8c524bf"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("f99f15b8-db39-4afa-b395-5e8262c82c22"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("a2249d42-0054-446f-ab13-cc41c819be45"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("9e1e635b-2cdb-4468-a8cd-5f8317fcd2e8"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("6026b039-4e54-40cf-b373-919193ec6a02"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("c3322258-f627-45ed-9db4-4d7c95d27848"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("33bd568f-6e0d-43d9-b51c-1b8323ca15aa"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
				UId = new Guid("fa8572de-f357-4a24-8d20-f3698a6ac52b"),
				ContainerUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
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
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess initeventsubprocess = CreateInitEventSubProcessEventSubProcess();
			FlowElements.Add(initeventsubprocess);
			ProcessSchemaEventSubProcess controledittypeschangeeventsubprocess = CreateControlEditTypesChangeEventSubProcessEventSubProcess();
			FlowElements.Add(controledittypeschangeeventsubprocess);
			ProcessSchemaEventSubProcess elementsingroupbuttonclickeventsubprocess = CreateElementsInGroupButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(elementsingroupbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess closedgroupofelementssettingseditpageeventsubprocess = CreateClosedGroupOfElementsSettingsEditPageEventSubProcessEventSubProcess();
			FlowElements.Add(closedgroupofelementssettingseditpageeventsubprocess);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOkButtonClickScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess1.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask getisvalidinputdatascripttask = CreateGetIsValidInputDataScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(getisvalidinputdatascripttask);
			ProcessSchemaScriptTask showmassagescripttask = CreateShowMassageScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(showmassagescripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage = CreateCancelButtonClickStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(cancelbuttonclickstartmessage);
			ProcessSchemaScriptTask cancelbuttonclickscripttask = CreateCancelButtonClickScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(cancelbuttonclickscripttask);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			initeventsubprocess.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			initeventsubprocess.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent controledittypeschangestartmessage = CreateControlEditTypesChangeStartMessageStartMessageEvent();
			controledittypeschangeeventsubprocess.FlowElements.Add(controledittypeschangestartmessage);
			ProcessSchemaScriptTask controledittypeschangescripttask = CreateControlEditTypesChangeScriptTaskScriptTask();
			controledittypeschangeeventsubprocess.FlowElements.Add(controledittypeschangescripttask);
			ProcessSchemaStartMessageEvent elementsingroupbuttonclickstartmessage = CreateElementsInGroupButtonClickStartMessageStartMessageEvent();
			elementsingroupbuttonclickeventsubprocess.FlowElements.Add(elementsingroupbuttonclickstartmessage);
			ProcessSchemaScriptTask elementsingroupbuttonclickscripttask = CreateElementsInGroupButtonClickScriptTaskScriptTask();
			elementsingroupbuttonclickeventsubprocess.FlowElements.Add(elementsingroupbuttonclickscripttask);
			ProcessSchemaUserTask opengroupofelementseditpageusertask = CreateOpenGroupOfElementsEditPageUserTaskUserTask();
			elementsingroupbuttonclickeventsubprocess.FlowElements.Add(opengroupofelementseditpageusertask);
			ProcessSchemaScriptTask closedgroupofelementssettingseditpagescripttask = CreateClosedGroupOfElementsSettingsEditPageScriptTaskScriptTask();
			closedgroupofelementssettingseditpageeventsubprocess.FlowElements.Add(closedgroupofelementssettingseditpagescripttask);
			ProcessSchemaStartMessageEvent closedgroupofelementssettingseditpagestartmessage = CreateClosedGroupOfElementsSettingsEditPageStartMessageStartMessageEvent();
			closedgroupofelementssettingseditpageeventsubprocess.FlowElements.Add(closedgroupofelementssettingseditpagestartmessage);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateIsValidDataConditionalFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCommentsLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateGroupOfElementsLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateTextFieldLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateSelectionFieldLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateLogicalFieldLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateDateTimeFieldLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateIntegerFieldLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateFloatFieldLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreatePerformValidationCaptionLocalizableString());
			LocalizableStrings.Add(CreateIsEnabledCaptionLocalizableString());
			LocalizableStrings.Add(CreateIsMultilineCaptionLocalizableString());
			LocalizableStrings.Add(CreateIsRquiredCaptionLocalizableString());
			LocalizableStrings.Add(CreateCanBeMinimizedCaptionLocalizableString());
			LocalizableStrings.Add(CreateMinimizedCaptionLocalizableString());
			LocalizableStrings.Add(CreateStyleCaptionLocalizableString());
			LocalizableStrings.Add(CreateDateTimeFormatCaptionLocalizableString());
			LocalizableStrings.Add(CreatePrecisionCaptionLocalizableString());
			LocalizableStrings.Add(CreateViewsCaptionLocalizableString());
			LocalizableStrings.Add(CreateLookupSelectionCaptionLocalizableString());
			LocalizableStrings.Add(CreateListSelectionCaptionLocalizableString());
			LocalizableStrings.Add(CreateRadioButtonsCollectionCaptionLocalizableString());
			LocalizableStrings.Add(CreateDefaultButtonStyleCaptionLocalizableString());
			LocalizableStrings.Add(CreateGreenButtonStyleCaptionLocalizableString());
			LocalizableStrings.Add(CreateRedButtonStyleCaptionLocalizableString());
			LocalizableStrings.Add(CreateBlueButtonStyleCaptionLocalizableString());
			LocalizableStrings.Add(CreateGreyButtonStyleCaptionLocalizableString());
			LocalizableStrings.Add(CreateTransparentButtonStyleCaptionLocalizableString());
			LocalizableStrings.Add(CreateDateFormatCaptionLocalizableString());
			LocalizableStrings.Add(CreateTimeFormatCaptionLocalizableString());
			LocalizableStrings.Add(CreateDateTimeCaptionLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCommentsLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1d6960bd-647a-4ee5-89b0-813c31e207a2"),
				Name = "CommentsLocalizableString",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateGroupOfElementsLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("804a4e83-3669-4a0c-81e2-9d7580baaa4e"),
				Name = "GroupOfElementsLocalizableString",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTextFieldLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("72922472-41bd-4852-bdd7-654df28209ef"),
				Name = "TextFieldLocalizableString",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSelectionFieldLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("273d76c2-0211-4b63-99cf-cb53d68a4db5"),
				Name = "SelectionFieldLocalizableString",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLogicalFieldLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3fca126c-e27c-4602-a2f2-470355d19217"),
				Name = "LogicalFieldLocalizableString",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateTimeFieldLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4d6e4874-6c2f-4650-bf84-d74606d3ad3d"),
				Name = "DateTimeFieldLocalizableString",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIntegerFieldLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8c719e0a-f05d-43be-aa92-d27252a84bb4"),
				Name = "IntegerFieldLocalizableString",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFloatFieldLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("81f24ff1-ad9f-416a-8061-8e443957db87"),
				Name = "FloatFieldLocalizableString",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePerformValidationCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a94bfb3c-bde7-465d-8a03-e4dde3e17a4d"),
				Name = "PerformValidationCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIsEnabledCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("558b5231-a931-4d28-8ea3-7499b6b58d7d"),
				Name = "IsEnabledCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIsMultilineCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e641537b-e591-45b1-bec6-e5255ce5729b"),
				Name = "IsMultilineCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIsRquiredCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f292d679-2506-454c-a0be-df5646d0e348"),
				Name = "IsRquiredCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanBeMinimizedCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fdf64d76-210e-4799-8434-2c2549e7608f"),
				Name = "CanBeMinimizedCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMinimizedCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c5a55f4b-f3a4-4207-89af-d13d85a7d834"),
				Name = "MinimizedCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStyleCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8d4223c5-a6ab-4148-a00a-fd433398f7c4"),
				Name = "StyleCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateTimeFormatCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("97b8b991-a3a1-4c98-99e2-ba75be18f739"),
				Name = "DateTimeFormatCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePrecisionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("049c4c05-7258-43a5-8469-c1f81ffa6e50"),
				Name = "PrecisionCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateViewsCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("555d7e37-551f-44fa-aec9-bb7e7676bf12"),
				Name = "ViewsCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLookupSelectionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("df3106da-68ab-4605-9da6-9ea30419db62"),
				Name = "LookupSelectionCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateListSelectionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f1335e8a-535d-4bae-be4d-fa0a765e4608"),
				Name = "ListSelectionCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRadioButtonsCollectionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("65ac1ecf-cdb1-4efc-9fae-c09304396e5b"),
				Name = "RadioButtonsCollectionCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDefaultButtonStyleCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("77b6ca0e-6190-4f33-8877-59a7681e30a7"),
				Name = "DefaultButtonStyleCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateGreenButtonStyleCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("51e4cccf-02e4-4571-9bb2-22a925f5f02d"),
				Name = "GreenButtonStyleCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRedButtonStyleCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5102f11c-b94e-481c-8c75-bf9aef37f637"),
				Name = "RedButtonStyleCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBlueButtonStyleCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f5cd7bb8-53aa-47b7-ae57-50db82e9909c"),
				Name = "BlueButtonStyleCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateGreyButtonStyleCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d7f5a4a8-2083-4196-838a-7f187cd3a04d"),
				Name = "GreyButtonStyleCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTransparentButtonStyleCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("13e29c3f-e8ce-4dc9-b330-fa2cf58b4b95"),
				Name = "TransparentButtonStyleCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateFormatCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("48b631cb-4707-4a57-8bde-5cea993c49db"),
				Name = "DateFormatCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTimeFormatCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7bc089a8-0af7-4d54-b4df-a6424e0c2d3e"),
				Name = "TimeFormatCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateTimeCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e6d8ae8f-6d86-45fc-bdb6-50a658c5b932"),
				Name = "DateTimeCaption",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("83cdffbb-a4be-47e3-88b2-bcd207ee4f18"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5c495e9f-c76c-49eb-87c1-7127cae3ef6b"),
				Name = "ValidationMessage",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("89c15619-c84b-4665-b241-38667ac4292e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(170, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c3e0274-57d1-4484-a042-1af6ede9f8f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0ad0eaf5-c833-45fb-b2d9-a18c4e556fe3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("dd7390db-ee48-4c69-8c42-2e413fb7012a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dc61a001-7391-4a83-bd4b-33e7f6a0eec9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bbea9236-285c-4b35-a503-dc8fa5175c47"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("0675a5ff-f46c-4e53-bd01-d4d2811f189e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(448, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9877116e-4622-489d-a544-66d81f75cc64"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5be15d9e-9e9c-432a-92ac-b8d81821b1da"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("99c862b0-6c1c-4718-88e6-e5ea08d9b791"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9755cfa1-4f47-4893-ad0e-e151ba5be220"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("432f9a4f-5fee-49a5-869f-988c5ff36764"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("7076bb87-4881-401d-8ed4-4f937c1228ed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(174, 148),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("81e611cc-da10-4b2e-9c71-8b9acfec609a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("694c7282-ffd0-4c9e-9e03-dbb04353f246"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("e8e4d353-3264-4c95-92fc-135db61d5a9c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(310, 147),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("694c7282-ffd0-4c9e-9e03-dbb04353f246"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf8e8e4e-f758-40e3-a076-b2b64b0164b1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow7",
				UId = new Guid("554bc7d8-52f0-42f8-aac5-95593a27efea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(409, 198),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf8e8e4e-f758-40e3-a076-b2b64b0164b1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1eef88ab-da2f-413b-b283-eb5923e2ae2b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsValidDataConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsValidDataConditionalFlow",
				UId = new Guid("af093931-a9c1-41fb-8c1c-62ad1eb89fa7"),
				ConditionExpression = @"IsValidData",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(410, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf8e8e4e-f758-40e3-a076-b2b64b0164b1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb278bea-612a-4f79-b824-e5378e8fbd1a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("8158e92a-11cb-4b86-b67a-3e41e2523d88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("931921c3-e22f-4814-8ccc-b8cf89230008"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f068311a-b84d-4fe5-aa89-2d21cb65c923"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("14ad624b-4693-45f8-a0fb-48d66831ce60"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(300, 370),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f068311a-b84d-4fe5-aa89-2d21cb65c923"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("70693574-f01e-4099-ada3-9f96cd220493"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CurveCenterPosition = new Point(576, 372),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8588769d-072c-4e16-b0a5-2cfe2ebe96d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f2070451-dac4-4bb8-a626-4861bd7b2f04"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e50885d2-e20b-4306-b26c-91fbc175b1c6"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(945, 665),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("f3f818dd-ae12-4ea2-a2de-c4dda90910d1"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e50885d2-e20b-4306-b26c-91fbc175b1c6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(916, 471),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("89a5e5c1-5f77-4cf5-a7dc-155e588a306d"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("e50885d2-e20b-4306-b26c-91fbc175b1c6"),
				CreatedInOwnerSchemaUId = new Guid("8abc19e2-903f-4f69-b4af-39e747dd33ea"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 476),
				Size = new Size(916, 189),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1a062eac-072c-42c0-9fc9-0c2043f9172b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3f818dd-ae12-4ea2-a2de-c4dda90910d1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(501, 277),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("81e611cc-da10-4b2e-9c71-8b9acfec609a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a062eac-072c-42c0-9fc9-0c2043f9172b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(36, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bb278bea-612a-4f79-b824-e5378e8fbd1a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a062eac-072c-42c0-9fc9-0c2043f9172b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"OkButtonClickScriptTask",
				Position = new Point(379, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,77,79,27,49,16,61,39,82,254,131,187,23,188,40,90,90,212,94,8,69,64,8,40,45,2,212,164,189,68,28,156,221,73,234,214,107,175,108,47,33,69,249,239,29,219,155,143,133,164,133,83,98,207,155,55,111,102,103,198,215,220,216,227,11,158,90,174,36,211,243,99,99,53,151,211,54,81,227,95,144,218,147,19,194,45,228,134,124,38,87,96,123,25,30,178,190,187,160,113,167,213,220,237,230,189,208,73,150,66,32,112,172,148,32,220,220,192,172,31,238,3,60,233,155,27,4,220,234,94,94,216,57,117,182,126,230,136,249,132,208,21,60,38,79,173,102,99,73,8,51,178,59,172,87,229,161,201,89,150,209,168,159,69,109,114,85,242,44,65,46,247,75,227,100,168,6,222,137,198,43,176,241,104,247,207,93,45,8,8,3,155,65,107,169,123,156,89,7,234,10,96,122,107,224,117,62,139,144,82,223,156,151,214,42,57,0,107,81,129,9,153,157,25,195,167,178,110,161,26,38,100,139,32,51,227,54,253,73,232,29,155,66,210,85,210,106,37,156,180,225,188,0,147,12,64,96,21,130,204,228,7,19,37,132,8,141,148,161,127,244,33,58,34,7,7,67,120,180,151,28,68,230,12,85,240,213,221,214,248,8,27,107,96,191,59,27,84,135,158,235,90,77,121,202,196,115,186,115,252,220,192,228,155,24,63,70,71,27,12,125,105,97,10,250,77,12,159,106,12,151,154,133,46,17,111,34,233,170,60,7,105,177,183,188,91,141,242,153,237,181,148,135,53,146,43,173,202,226,118,210,19,224,184,204,107,73,46,152,133,33,207,225,165,170,154,229,181,116,161,83,176,60,47,249,234,166,255,18,46,124,119,183,154,223,13,104,108,72,25,124,177,21,145,76,57,113,108,228,250,20,27,236,43,204,239,113,152,252,248,160,231,193,126,171,25,198,151,160,43,103,130,255,9,157,139,152,47,198,83,84,183,212,13,189,235,227,126,86,249,143,34,201,114,136,238,219,120,217,101,133,139,184,178,164,225,236,141,11,167,246,129,105,98,198,213,238,8,179,127,94,114,145,129,166,167,17,157,148,210,43,166,213,154,193,49,125,55,227,50,83,179,68,21,32,65,87,35,164,193,150,90,86,25,55,28,167,213,0,87,154,59,77,53,135,164,58,245,30,109,50,5,219,205,11,186,23,57,33,102,156,156,21,8,201,194,248,226,86,185,99,26,243,176,160,253,176,210,104,73,137,235,35,174,123,156,70,123,97,197,56,125,75,216,78,105,25,150,125,160,74,157,2,138,91,162,147,245,237,146,105,125,131,84,209,114,243,254,107,57,135,144,155,186,156,2,23,83,171,25,6,91,51,38,41,182,136,133,111,106,70,61,243,134,83,253,123,199,157,198,51,202,208,99,27,84,200,109,18,46,209,207,210,247,109,23,202,85,246,78,243,28,135,177,171,68,153,203,80,193,216,27,95,248,27,176,103,248,149,31,188,154,109,128,9,215,208,123,192,129,164,123,33,12,100,123,237,141,100,60,109,155,60,17,236,168,232,249,78,222,82,140,212,107,114,207,230,91,115,239,236,172,39,102,236,228,87,212,163,186,165,86,139,27,108,42,26,223,135,44,39,74,19,186,214,228,108,132,203,165,194,170,133,26,174,164,88,165,205,90,174,241,237,37,122,180,190,171,216,23,187,11,137,148,66,177,236,69,37,71,46,86,69,120,95,171,105,189,225,171,229,18,251,183,181,154,169,84,40,131,169,5,188,159,34,124,110,7,169,230,133,165,232,91,127,219,247,15,90,77,234,103,45,14,80,83,248,3,62,217,129,165,213,12,163,131,35,82,66,231,47,18,15,253,30,10,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("cf8e8e4e-f758-40e3-a076-b2b64b0164b1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a062eac-072c-42c0-9fc9-0c2043f9172b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateGetIsValidInputDataScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("694c7282-ffd0-4c9e-9e03-dbb04353f246"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a062eac-072c-42c0-9fc9-0c2043f9172b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"GetIsValidInputDataScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,82,209,78,194,48,20,125,134,196,127,168,123,218,146,165,241,93,49,33,128,102,137,160,9,68,158,75,119,55,26,187,118,105,239,20,53,252,187,221,58,112,40,104,124,243,173,235,61,231,244,156,179,203,181,178,72,44,26,161,114,178,0,99,152,213,25,46,97,53,44,203,145,46,10,173,200,128,4,251,1,245,19,234,71,193,229,89,191,165,114,173,208,104,57,99,5,56,194,3,203,129,214,231,73,42,144,46,96,131,14,41,50,18,122,52,77,236,172,146,242,222,44,215,2,97,94,50,14,97,71,32,138,200,251,89,191,55,5,107,157,142,147,83,240,66,238,52,103,82,188,177,149,132,121,35,18,30,117,27,147,160,229,209,153,198,71,71,73,107,73,58,181,121,16,57,19,189,196,54,151,99,134,204,41,103,76,90,168,175,13,96,101,20,65,83,213,159,91,239,246,188,99,138,182,196,36,5,133,34,19,96,194,127,227,243,22,48,177,147,141,176,104,71,159,142,127,172,180,253,17,55,218,20,12,195,227,198,29,161,247,155,249,49,88,145,171,113,181,146,130,51,132,250,45,235,67,196,221,157,248,83,164,103,102,200,19,188,46,181,73,237,174,85,151,237,202,123,190,110,146,4,67,206,161,196,32,174,207,35,166,56,200,192,145,157,64,166,13,48,190,110,87,109,39,68,132,218,107,250,46,58,235,232,82,149,204,28,20,22,239,208,113,99,44,34,131,1,185,240,196,83,57,78,182,219,160,25,10,173,90,196,247,106,190,148,208,219,54,69,28,62,212,206,186,200,15,105,6,181,161,190,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateShowMassageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1eef88ab-da2f-413b-b283-eb5923e2ae2b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a062eac-072c-42c0-9fc9-0c2043f9172b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ShowMassageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(379, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,74,44,78,245,77,45,46,6,178,3,18,243,82,115,244,28,83,82,160,124,141,176,196,156,204,148,196,146,204,252,60,168,72,72,102,73,78,170,142,2,148,7,103,132,84,22,164,234,133,39,22,229,101,230,165,107,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,223,246,132,139,101,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dfa0cf54-0422-4b5d-bfb4-929ca15d8bf4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89a5e5c1-5f77-4cf5-a7dc-155e588a306d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5c3e0274-57d1-4484-a042-1af6ede9f8f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dfa0cf54-0422-4b5d-bfb4-929ca15d8bf4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0ad0eaf5-c833-45fb-b2d9-a18c4e556fe3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dfa0cf54-0422-4b5d-bfb4-929ca15d8bf4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,65,111,219,48,12,133,207,13,144,255,160,249,36,3,129,129,237,184,181,29,90,55,235,130,13,75,176,4,187,12,59,40,54,147,169,113,164,78,162,139,4,67,254,123,73,201,72,109,163,201,118,179,133,239,81,143,143,212,76,173,33,155,110,110,107,68,107,178,155,7,181,27,63,129,65,159,229,149,46,54,89,174,106,15,254,135,170,116,169,80,91,35,174,4,186,26,62,12,7,185,53,8,59,252,2,123,58,155,113,149,123,192,153,114,106,11,8,142,20,53,200,164,56,66,73,154,45,236,28,157,54,107,153,146,220,46,31,160,64,241,199,31,37,103,202,104,132,237,164,76,88,55,9,159,196,118,148,87,194,212,85,37,62,10,31,110,200,198,219,71,220,139,247,109,168,123,253,127,222,235,99,46,115,64,36,165,143,14,122,135,164,167,44,158,192,33,93,113,107,109,5,202,200,86,125,214,124,213,30,47,239,116,193,17,42,183,191,140,54,71,34,166,112,125,45,184,67,79,224,105,70,64,73,80,9,37,39,64,164,94,9,217,116,59,241,223,168,251,169,11,93,203,152,80,154,138,191,195,193,69,168,43,98,60,36,186,104,23,121,57,62,8,168,60,116,4,148,198,56,176,76,250,144,89,95,220,65,100,16,50,118,24,14,162,47,193,211,119,182,98,104,177,127,132,198,116,63,191,104,180,199,82,249,100,25,176,164,235,47,140,42,239,194,62,251,172,203,18,120,57,87,138,64,246,58,49,26,115,187,93,210,68,118,204,53,18,249,170,126,196,189,244,15,101,58,138,229,66,239,236,188,211,255,155,152,94,116,255,138,253,102,56,105,91,244,51,233,113,201,47,174,221,106,47,246,183,160,55,19,86,144,185,151,230,154,151,215,64,249,111,40,54,212,221,219,127,1,239,78,1,188,149,231,110,184,7,3,78,145,251,185,94,27,85,157,67,105,239,55,211,213,119,88,129,3,83,156,245,125,167,80,125,210,21,189,140,19,148,3,172,157,57,254,31,194,74,221,120,79,38,154,25,121,217,203,113,212,121,29,173,185,181,107,61,3,166,72,52,147,235,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("284d39c7-ad3f-4f36-b33a-7712dd3621e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3f818dd-ae12-4ea2-a2de-c4dda90910d1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"EventSubProcess3",
				Position = new Point(575, 2),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dc61a001-7391-4a83-bd4b-33e7f6a0eec9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("284d39c7-ad3f-4f36-b33a-7712dd3621e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"CancelButtonClickStartMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bbea9236-285c-4b35-a503-dc8fa5175c47"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("284d39c7-ad3f-4f36-b33a-7712dd3621e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"CancelButtonClickScriptTask",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,72,76,79,213,4,17,122,142,197,5,96,142,158,115,78,126,113,170,134,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,160,144,205,48,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1a8933d9-aca7-4d03-a27a-199692b7abcf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89a5e5c1-5f77-4cf5-a7dc-155e588a306d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"InitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(301, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9877116e-4622-489d-a544-66d81f75cc64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a8933d9-aca7-4d03-a27a-199692b7abcf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5be15d9e-9e9c-432a-92ac-b8d81821b1da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1a8933d9-aca7-4d03-a27a-199692b7abcf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,83,65,110,219,48,16,60,39,64,254,64,232,36,33,2,63,16,199,128,43,171,169,129,2,21,106,187,57,20,57,48,226,74,102,77,145,234,146,74,35,24,254,123,151,146,90,219,201,181,64,111,2,119,102,118,102,72,229,82,249,117,185,131,70,108,87,146,221,51,3,191,216,67,167,100,92,136,26,248,3,248,66,160,104,192,3,126,19,186,131,56,130,115,66,148,240,141,93,123,84,166,142,147,228,238,230,122,149,155,174,1,20,207,26,102,65,102,206,90,81,238,73,106,37,29,169,111,0,81,56,91,121,158,89,4,94,140,51,199,31,45,238,29,33,97,235,149,86,94,209,209,176,122,24,127,82,36,136,229,174,39,141,120,235,0,51,107,12,148,94,89,147,50,130,45,193,169,218,128,44,208,150,224,220,104,46,78,254,168,147,205,244,230,250,234,146,120,218,200,87,50,24,183,207,63,104,242,253,137,141,31,197,185,235,83,4,158,9,231,103,35,100,30,135,240,11,10,212,199,65,225,69,224,9,249,81,105,170,108,234,115,169,134,157,2,251,153,27,186,74,167,45,115,118,32,103,135,168,180,77,43,80,57,107,54,125,11,81,202,70,122,118,113,204,243,159,157,208,199,116,96,104,168,124,254,218,34,229,37,229,204,234,174,49,133,240,59,226,70,235,222,77,246,163,9,221,57,88,42,215,106,209,15,151,72,160,74,104,7,211,20,85,189,59,19,187,188,112,23,165,239,42,57,30,167,184,240,234,193,72,34,128,241,255,51,113,126,230,227,31,101,14,41,254,190,137,195,72,29,114,15,255,197,7,107,247,95,170,175,80,1,173,44,33,167,127,130,23,8,228,29,62,211,168,107,167,54,110,239,153,4,13,181,240,192,226,81,142,57,178,10,152,178,17,24,168,249,11,249,94,96,237,24,36,67,63,161,219,106,80,8,207,15,248,168,230,104,251,213,116,204,23,82,198,111,94,91,242,118,254,254,122,2,36,132,64,240,29,26,230,177,131,187,223,28,88,12,80,2,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateControlEditTypesChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaControlEditTypesChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5d1ba57e-f9df-4346-b348-2003aada822a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3f818dd-ae12-4ea2-a2de-c4dda90910d1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ControlEditTypesChangeEventSubProcess",
				Position = new Point(574, 147),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(256, 125),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaControlEditTypesChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateControlEditTypesChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9755cfa1-4f47-4893-ad0e-e151ba5be220"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d1ba57e-f9df-4346-b348-2003aada822a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ControlEditTypesChange",
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ControlEditTypesChangeStartMessage",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateControlEditTypesChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("432f9a4f-5fee-49a5-869f-988c5ff36764"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d1ba57e-f9df-4346-b348-2003aada822a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ControlEditTypesChangeScriptTask",
				Position = new Point(147, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,141,187,10,2,49,16,69,107,3,249,135,216,37,176,228,7,182,18,217,34,141,138,138,253,98,198,16,200,99,153,153,8,139,248,239,26,177,60,23,206,61,241,161,244,150,24,99,9,214,209,161,165,116,196,41,47,188,106,199,144,157,55,70,189,164,216,156,33,215,39,244,73,155,81,138,183,20,59,162,24,202,190,22,198,154,72,159,230,0,246,79,147,143,124,93,23,32,123,129,4,119,6,223,69,123,155,83,131,65,149,111,99,80,140,13,250,19,2,55,44,63,28,63,215,227,29,16,140,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateElementsInGroupButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaElementsInGroupButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a5bdae7b-f9b4-44c0-9887-6abd4dcaf782"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3f818dd-ae12-4ea2-a2de-c4dda90910d1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ElementsInGroupButtonClickEventSubProcess",
				Position = new Point(36, 302),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(369, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaElementsInGroupButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateElementsInGroupButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("931921c3-e22f-4814-8ccc-b8cf89230008"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a5bdae7b-f9b4-44c0-9887-6abd4dcaf782"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ElementsInGroupButtonClick",
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ElementsInGroupButtonClickStartMessage",
				Position = new Point(42, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateElementsInGroupButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f068311a-b84d-4fe5-aa89-2d21cb65c923"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a5bdae7b-f9b4-44c0-9887-6abd4dcaf782"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ElementsInGroupButtonClickScriptTask",
				Position = new Point(133, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,221,110,130,64,16,133,175,107,226,59,108,184,210,68,68,171,214,146,254,36,5,209,144,166,193,4,125,128,13,76,45,169,44,102,118,176,53,198,119,119,128,98,141,87,92,237,158,156,51,223,204,236,6,59,80,11,204,242,93,240,233,109,33,5,69,218,139,19,90,202,13,172,53,224,74,234,239,126,192,25,64,95,105,146,42,2,63,22,47,162,22,107,63,126,106,183,130,6,16,190,184,57,34,123,111,17,37,123,40,76,6,17,230,192,4,203,106,194,112,183,153,134,15,208,186,170,53,74,29,223,84,133,64,148,168,205,165,218,40,241,150,37,234,128,95,245,169,253,102,227,151,162,92,93,193,143,88,228,73,220,49,38,206,208,115,6,142,99,218,195,241,200,28,219,211,71,211,25,61,184,230,100,62,179,167,147,129,59,114,239,231,70,151,219,239,37,138,157,68,153,2,1,234,63,198,44,225,119,200,148,196,195,179,38,228,137,123,162,58,95,59,93,113,108,183,238,142,194,136,50,69,240,75,239,112,48,122,66,184,23,117,234,85,62,240,152,97,244,5,169,228,217,56,226,93,235,254,42,11,75,32,243,234,130,77,177,102,25,21,62,65,122,19,106,183,78,13,127,179,16,203,235,141,254,215,99,2,2,229,168,170,191,61,3,141,189,113,174,97,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenGroupOfElementsEditPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4a8045aa-01a2-4170-80c1-5ebbabcdd418"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a5bdae7b-f9b4-44c0-9887-6abd4dcaf782"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"OpenGroupOfElementsEditPageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 36),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenGroupOfElementsEditPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateClosedGroupOfElementsSettingsEditPageEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaClosedGroupOfElementsSettingsEditPageEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("548d2d71-1058-4e88-96c4-450c1ff8106e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f3f818dd-ae12-4ea2-a2de-c4dda90910d1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ClosedGroupOfElementsSettingsEditPageEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(420, 301),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(273, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaClosedGroupOfElementsSettingsEditPageEventSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateClosedGroupOfElementsSettingsEditPageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f2070451-dac4-4bb8-a626-4861bd7b2f04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("548d2d71-1058-4e88-96c4-450c1ff8106e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ClosedGroupOfElementsSettingsEditPageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateClosedGroupOfElementsSettingsEditPageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8588769d-072c-4e16-b0a5-2cfe2ebe96d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("548d2d71-1058-4e88-96c4-450c1ff8106e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ClosedGroupOfElementsSettingsEditPage",
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Name = @"ClosedGroupOfElementsSettingsEditPageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetEditedItemsMethod());
			Methods.Add(CreateGetEditedItemMethod());
			Methods.Add(CreateAssignButtonSettingsMethod());
			Methods.Add(CreateGetButtonStylesMethod());
			Methods.Add(CreateGetControlEditTypesMethod());
			Methods.Add(CreateAssignTextFieldSettingsMethod());
			Methods.Add(CreateSetControlValuesButtonSettingsMethod());
			Methods.Add(CreateSetControlValuesTextFieldSettingsMethod());
			Methods.Add(CreateAssignControlsMethod());
			Methods.Add(CreateInitListEditControlMethod());
			Methods.Add(CreateGetDateTimeFormatsMethod());
			Methods.Add(CreateGetPrecisionsMethod());
			Methods.Add(CreateInitComboBoxEditControlMethod());
			Methods.Add(CreateSetControlValuesCommentaryFieldSettingsMethod());
			Methods.Add(CreateSetControlValuesGroupOfElementsSettingsMethod());
			Methods.Add(CreateSetControlValuesSelectionFieldSettingsMethod());
			Methods.Add(CreateSetControlValuesBooleanFieldSettingsMethod());
			Methods.Add(CreateSetControlValuesItegerFieldSettingsMethod());
			Methods.Add(CreateSetControlValuesDateTimeFieldSettingsMethod());
			Methods.Add(CreateSetControlValuesFractionalFieldSettingsMethod());
			Methods.Add(CreateRemoveItemMethod());
			Methods.Add(CreateAssignSelectionFieldSettingsMethod());
			Methods.Add(CreateGetSelectionFieldDataValueTypesMethod());
			Methods.Add(CreateAssignCommentaryFieldSettingsMethod());
			Methods.Add(CreateAssignGroupOfElementsSettingsMethod());
			Methods.Add(CreateAssignBooleanFieldSettingsMethod());
			Methods.Add(CreateAssignDateTimeFieldSettingsMethod());
			Methods.Add(CreateAssignIntegerFieldSettingsMethod());
			Methods.Add(CreateAssignFractionalFieldSettingsMethod());
			Methods.Add(CreateGetSchemaUIdByIdMethod());
			Methods.Add(CreateGetSchemaIdByUIdMethod());
			Methods.Add(CreateGetDesignedProcessSchemaMethod());
			Methods.Add(CreateRemoveElementFromGroupMethod());
			Methods.Add(CreateGetIsExistsControlNameMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1d834fce-4e73-4e39-bfb6-f44d45b7ad2a"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b4c3d123-994e-4e32-8a4f-838953e70cd1"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3b12be6e-9ad6-43b7-a13c-cd93bdd1cf19"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b5d5c3f7-fd50-4b1a-bc75-c16c1315e659"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
		}

		protected virtual SchemaMethod CreateGetEditedItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f4d7069a-8c7e-4584-9e65-28256af46d96"),
				Name = "GetEditedItems",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "List<Dictionary<string, object>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,44,73,205,45,86,176,85,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,78,45,46,6,210,46,137,37,137,209,64,225,146,212,138,18,239,212,202,88,133,196,98,5,159,204,226,18,27,151,76,176,186,196,162,74,155,226,146,162,204,188,116,29,133,252,164,44,160,102,59,59,107,94,174,204,52,5,13,168,193,182,10,121,165,57,57,154,10,213,188,92,156,48,187,242,82,203,9,154,162,161,9,52,167,150,151,171,40,181,164,180,40,15,226,76,107,0,56,230,14,164,177,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEditedItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("62b69b3c-e9e6-42fe-a120-63ea31afe38b"),
				Name = "GetEditedItem",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Dictionary<string, object>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3e408534-6257-4a48-96fe-e69117339234"),
				Name = "items",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Dictionary<string, object>>",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,65,14,130,48,16,69,215,204,41,38,172,10,49,226,30,113,163,155,158,193,184,192,82,116,12,76,147,50,93,24,225,238,210,18,19,151,255,231,229,189,170,4,234,81,145,216,113,194,166,65,14,195,128,243,140,233,216,159,93,96,137,247,161,192,15,100,222,74,240,156,152,26,22,40,43,232,157,183,173,121,170,11,25,33,199,173,127,31,39,241,196,143,29,186,251,203,26,57,37,19,18,111,198,164,137,65,181,97,69,124,175,185,238,242,91,204,232,117,233,46,65,191,88,4,106,200,150,181,247,159,255,2,119,37,235,227,184,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignButtonSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4536c011-d393-473d-bab7-a08de312611a"),
				Name = "AssignButtonSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f88dbbb8-4af0-4564-bcbc-ef0a8d017ed3"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<string, object>",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,193,10,194,64,12,68,239,126,133,244,164,32,5,189,122,82,41,34,136,8,21,239,113,51,214,224,238,182,108,35,212,191,183,90,91,172,244,54,153,188,201,16,81,184,120,197,60,137,60,57,68,179,241,145,50,196,135,90,39,44,26,159,80,233,116,57,146,142,50,84,168,228,190,5,55,205,56,204,150,250,180,221,201,189,148,250,193,82,88,24,5,239,222,220,153,236,3,189,80,129,112,205,131,171,23,194,212,171,186,193,220,215,121,53,111,20,184,23,147,50,241,116,177,224,127,124,49,136,103,240,8,164,72,37,243,100,219,204,246,235,114,99,255,124,245,2,139,73,218,61,39,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetButtonStylesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9266b162-e23e-4f7d-9a70-50c36905267d"),
				Name = "GetButtonStyles",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,206,193,10,194,48,12,6,224,179,131,189,67,217,73,161,111,48,241,48,7,222,213,23,136,54,142,66,201,70,150,34,101,236,221,215,218,131,23,235,233,79,224,251,73,24,197,51,41,194,183,234,237,83,236,72,192,225,56,11,91,26,180,202,121,218,31,212,82,87,187,165,49,248,2,239,164,209,170,207,83,231,69,70,186,73,112,120,134,41,213,87,253,145,3,35,82,116,151,148,69,197,104,162,185,162,41,138,135,243,24,73,23,227,223,173,144,79,133,162,17,6,154,39,96,164,244,253,253,187,253,104,212,213,218,110,126,52,151,88,24,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetControlEditTypesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("47210fce-b892-47e9-8b78-14d5e898ea3b"),
				Name = "GetControlEditTypes",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,193,10,130,64,16,134,207,9,190,195,226,169,192,75,81,39,171,75,106,4,66,7,125,129,205,38,89,88,119,101,29,43,19,223,189,109,203,131,196,122,26,102,230,251,127,254,97,238,84,145,92,10,84,146,71,87,134,89,91,65,77,118,68,192,131,132,44,71,38,5,85,237,182,70,197,68,225,147,111,221,207,23,164,115,157,89,231,29,100,89,130,64,141,196,12,248,213,243,201,111,82,39,50,167,156,189,232,133,67,106,68,189,111,20,43,205,28,149,108,170,243,45,226,48,137,46,53,154,193,19,141,181,13,74,129,131,137,57,4,24,15,172,222,159,28,137,44,152,94,79,130,33,69,200,88,9,131,253,168,183,137,214,26,60,9,132,2,212,36,183,209,92,204,37,181,157,232,58,125,224,58,10,176,81,226,239,75,193,27,158,77,133,215,187,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignTextFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("30259b9b-9b9d-40f1-a2da-4146de5bd4a4"),
				Name = "AssignTextFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("40cfccd3-71f3-484e-b367-40f322c84558"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,44,73,205,213,115,76,73,209,80,202,75,204,77,85,210,81,8,72,76,79,213,243,3,178,93,83,50,75,244,66,82,43,74,52,173,185,50,225,170,146,19,11,74,50,243,243,96,10,157,33,92,28,106,243,243,74,138,242,115,64,146,33,149,5,112,195,157,81,133,139,245,130,83,115,82,147,75,82,83,60,65,58,195,18,115,74,83,81,140,201,44,246,45,205,41,201,204,201,204,67,24,145,145,154,156,237,148,95,97,8,97,165,166,160,105,8,74,45,44,205,44,74,77,65,87,111,132,80,15,0,126,227,216,169,249,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlValuesButtonSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4a4db846-709e-44cf-9a1f-5fc4c38ff655"),
				Name = "SetControlValuesButtonSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cbf22f41-96a7-4836-b1db-d141361d5363"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,77,75,195,64,16,134,207,41,244,63,44,61,37,80,2,122,180,234,161,165,136,40,82,104,241,62,201,78,211,105,55,59,97,119,212,6,233,127,119,205,250,81,49,7,63,110,59,251,206,60,239,59,179,102,135,80,110,210,27,108,239,193,60,224,2,200,157,123,113,100,171,177,226,98,139,165,92,170,198,113,131,78,90,69,86,145,96,157,169,231,225,32,241,79,36,97,242,93,204,3,34,10,73,9,30,213,200,66,141,163,179,215,58,89,64,133,249,93,168,231,154,36,95,225,94,212,133,74,163,77,246,1,232,2,76,186,129,34,164,218,77,62,89,37,52,66,108,143,113,179,248,245,87,162,151,214,124,137,119,75,94,58,216,18,77,216,250,58,236,153,246,3,179,126,98,232,88,179,171,67,11,105,248,150,118,131,229,110,202,251,147,248,66,29,226,206,216,62,6,106,190,226,41,179,65,176,233,143,124,200,207,45,20,6,117,31,255,244,255,252,10,45,58,16,92,82,101,193,28,155,92,189,41,58,74,191,62,253,97,56,56,188,0,85,219,136,232,113,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlValuesTextFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2be52540-acf7-4157-a7ef-52f56bdffea6"),
				Name = "SetControlValuesTextFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eec3c6a9-cc6d-4287-9c81-e3e8f47a17dd"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,193,78,2,49,16,134,207,75,194,59,52,156,118,19,210,4,143,34,30,32,30,12,209,16,221,120,47,221,17,6,74,103,109,103,149,141,225,221,29,216,40,108,178,7,163,183,78,255,204,247,253,237,43,5,48,118,157,206,161,126,49,174,130,133,193,112,19,57,160,95,13,21,45,55,96,249,86,149,129,74,8,92,43,244,10,25,118,153,250,236,247,146,248,129,44,155,223,161,22,68,19,36,214,68,80,3,111,118,48,184,62,206,201,194,172,64,63,202,124,87,32,235,28,246,172,38,42,109,52,217,15,224,84,96,124,90,88,74,171,237,248,204,178,166,100,36,127,137,155,53,87,127,38,146,231,64,238,184,158,215,101,171,232,172,29,69,253,12,78,254,225,94,94,158,118,43,178,110,7,198,135,202,49,58,244,109,254,26,236,118,74,251,81,115,130,66,170,139,243,93,120,58,167,41,145,3,227,211,95,26,158,224,173,194,0,69,151,224,234,31,130,67,191,119,248,2,121,11,218,162,29,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("06a5b40c-79d5-417c-bc17-e3b0da6d1df0"),
				Name = "AssignControls",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b77d9608-038f-4e45-aa2b-afefe70763f2"),
				Name = "controlEditType",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d27eb719-6f2e-4747-84ae-5dd606a86f72"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d38e217b-7a6f-47f6-a26b-a9ca89a5149f"),
				Name = "shouldClear",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,88,209,110,218,48,20,125,102,210,254,193,227,41,84,85,25,104,123,105,215,73,35,64,135,212,170,168,160,190,76,123,48,201,13,88,24,155,217,206,90,58,245,223,231,56,16,72,150,132,36,165,106,167,190,0,138,175,125,237,115,206,61,185,70,222,17,229,204,144,229,112,166,4,167,61,151,168,241,106,9,13,244,231,253,187,154,131,37,160,186,205,23,11,96,10,139,85,159,0,117,235,167,122,164,54,196,83,56,25,195,189,186,197,212,135,96,218,201,119,226,186,192,208,57,242,48,149,112,22,69,217,51,112,230,29,126,223,218,70,40,225,167,4,180,179,2,46,137,84,241,20,241,241,11,96,32,176,2,119,68,166,12,211,188,208,14,231,243,107,239,6,60,16,192,28,200,11,237,98,133,251,132,42,16,25,81,196,67,22,81,176,64,31,206,17,243,41,13,65,171,213,70,160,236,16,78,3,142,76,0,168,135,21,97,83,105,230,54,204,74,143,8,52,100,235,233,230,65,240,49,17,128,231,103,17,15,237,29,228,83,48,205,64,189,93,128,23,27,47,21,225,65,136,141,89,7,174,8,35,11,242,0,238,250,121,218,162,219,41,217,209,175,148,182,60,233,150,230,246,66,112,127,121,237,245,40,4,20,203,170,220,182,234,167,168,217,12,54,101,36,242,236,60,15,228,149,79,21,161,132,65,33,146,7,242,230,151,79,196,27,37,57,226,165,42,189,35,160,224,4,184,37,29,52,66,111,11,245,45,129,59,89,0,230,45,203,93,98,214,214,254,242,69,42,161,247,119,140,194,239,175,200,213,56,153,51,4,166,46,245,172,11,80,241,205,116,99,17,86,120,168,1,35,106,147,113,141,132,21,95,74,167,152,113,159,186,54,5,44,194,73,205,102,124,167,97,158,129,70,202,170,183,62,214,27,5,137,222,255,246,40,164,239,44,189,238,125,217,148,16,236,62,125,29,246,53,18,231,109,159,20,155,71,230,235,55,22,200,5,207,172,160,147,6,68,152,216,90,146,171,240,32,223,152,27,28,202,218,76,57,78,40,232,199,102,224,103,152,178,118,212,204,180,180,182,241,180,75,62,37,14,166,113,91,43,4,220,155,239,27,116,78,93,93,197,232,206,98,65,111,6,198,100,1,73,227,217,95,86,121,142,147,229,93,81,54,46,22,88,101,214,222,222,74,77,243,31,237,92,241,229,181,89,165,184,80,121,125,29,194,9,94,66,30,49,106,171,234,227,147,41,210,1,83,48,5,81,181,247,40,230,188,135,33,229,63,175,233,193,22,232,170,148,125,54,148,245,41,199,149,155,197,98,132,229,64,29,72,38,181,68,135,2,28,34,245,50,233,213,153,236,17,182,219,136,38,62,147,110,94,185,46,250,2,135,77,28,125,146,54,38,190,82,156,165,53,152,37,92,124,164,86,244,223,107,65,46,128,149,155,182,114,215,150,33,8,79,123,191,134,140,232,190,36,77,44,233,151,151,30,195,19,154,211,12,182,194,95,224,230,232,42,37,34,163,6,58,134,4,131,162,169,2,115,176,70,10,228,187,29,178,110,172,176,190,146,237,182,201,118,252,63,25,249,164,54,244,69,26,152,16,136,178,90,126,252,11,84,115,208,232,149,18,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitListEditControlMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("34adf7ff-e7cc-4dd3-8a4c-31206bf074a6"),
				Name = "InitListEditControl",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d4a34aa2-341f-400c-8356-c046f799a655"),
				Name = "items",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("41ce04d3-752d-4431-af79-b1ffb95e69fa"),
				Name = "shouldClear",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,113,206,207,77,202,119,202,175,112,77,1,177,243,74,138,242,115,52,2,18,211,83,245,124,50,139,75,64,130,58,10,153,37,169,185,197,58,10,197,25,249,165,57,41,206,57,169,137,69,154,214,0,76,27,85,20,59,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDateTimeFormatsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c5ae8494-2316-4264-8acd-d2a0b5692e7d"),
				Name = "GetDateTimeFormats",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,128,208,118,26,154,10,213,92,156,213,74,230,74,58,10,46,137,37,169,33,153,185,169,206,137,5,32,213,181,58,32,9,11,168,132,91,126,81,110,98,9,138,148,37,80,10,164,30,85,138,171,214,26,0,174,19,34,163,122,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPrecisionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("71c7ac5c-1627-4a80-9bde-fb7bf7a323b2"),
				Name = "GetPrecisions",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,43,205,201,177,6,0,44,130,140,166,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitComboBoxEditControlMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("46dba581-b5cd-4b52-a323-8a1c5c60aa8f"),
				Name = "InitComboBoxEditControl",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("11f95a33-10cc-499c-848b-4212ccdf0349"),
				Name = "comboBoxEdit",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ComboBoxEdit",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("025db6eb-be71-4dea-a7d8-03fcc7d79bae"),
				Name = "items",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fca3973f-eb04-47ce-a010-7b5d1707646e"),
				Name = "shouldClear",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,40,206,200,47,205,73,113,206,73,77,44,210,84,168,230,226,76,206,207,77,202,119,202,175,112,77,201,44,209,3,11,123,150,164,230,22,107,104,90,115,213,114,165,229,23,165,38,38,103,40,104,120,167,86,134,37,230,148,166,6,36,102,22,217,20,151,20,101,230,165,235,40,64,104,59,133,76,160,6,133,204,60,48,93,140,105,168,99,74,10,200,72,13,144,180,30,208,32,29,176,66,61,176,121,32,91,0,149,107,59,97,150,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlValuesCommentaryFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4777a806-173c-40ef-929f-7123cd5b5762"),
				Name = "SetControlValuesCommentaryFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("17b45c26-1b28-4e2c-93d5-cd5a091c9179"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,143,65,11,130,64,16,133,207,250,43,22,79,10,177,63,32,171,139,116,136,32,132,164,251,186,77,182,165,187,203,58,81,18,254,247,70,37,49,232,82,199,153,121,239,123,111,78,198,129,144,231,112,11,205,65,148,55,72,133,114,139,26,157,210,197,140,153,252,2,18,87,204,58,99,193,97,195,148,102,10,161,138,216,211,247,234,187,66,50,190,111,156,8,253,222,147,162,6,22,104,81,65,48,167,209,75,69,1,124,71,227,250,168,144,103,240,64,182,100,225,144,17,141,246,62,61,238,244,57,53,186,198,35,72,10,139,202,232,9,43,25,54,127,226,140,70,103,202,206,156,53,118,90,49,249,188,212,124,15,37,189,191,161,135,195,239,252,232,91,0,82,163,9,181,43,216,139,127,172,219,250,237,11,133,132,75,77,156,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlValuesGroupOfElementsSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("36d1d660-4f96-423d-8f59-a56095b17c7b"),
				Name = "SetControlValuesGroupOfElementsSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5c51458d-5663-4ce8-ae58-3356819ebeca"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,143,77,11,194,48,12,134,207,243,87,148,157,54,144,129,30,253,58,40,30,68,148,129,226,189,235,162,70,183,102,116,17,157,226,127,183,115,40,19,68,212,91,147,244,125,242,100,77,6,164,218,122,83,40,86,50,57,64,40,209,244,114,54,168,55,77,65,209,14,20,15,68,102,40,3,195,133,64,45,144,33,245,197,165,225,228,71,100,27,124,204,2,75,184,247,29,37,115,16,174,150,41,184,29,91,58,161,220,64,48,183,229,56,70,14,150,112,98,209,23,94,181,195,127,198,239,219,187,229,255,200,26,237,187,79,144,146,25,35,233,26,107,84,117,254,196,145,102,67,73,25,94,22,89,93,113,244,58,201,131,5,36,246,252,137,61,216,123,207,247,223,251,234,33,204,80,99,138,103,136,235,252,45,168,253,144,78,173,234,5,113,233,29,17,37,95,88,167,31,120,237,95,120,215,198,245,6,214,206,122,212,243,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlValuesSelectionFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("77185bb0-5286-4a50-8b67-776b48dd122f"),
				Name = "SetControlValuesSelectionFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7f1f786e-2ef0-42c7-8231-3ac95280b459"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,203,110,194,48,16,69,215,65,226,31,44,86,137,132,34,117,91,218,74,133,82,132,250,66,36,116,111,156,1,92,130,157,58,19,32,170,248,247,78,28,66,9,66,85,31,59,191,238,185,215,51,51,211,6,184,88,184,15,144,191,242,56,131,17,151,230,42,69,35,213,188,205,244,244,13,4,222,176,196,232,4,12,230,76,42,38,17,86,30,251,104,54,156,116,35,145,148,213,165,79,136,242,194,17,60,5,214,82,124,5,173,203,98,239,140,248,28,252,103,218,247,35,137,126,8,91,100,215,204,45,109,188,3,192,6,232,88,193,148,82,45,59,95,44,193,19,148,90,29,227,122,229,209,159,137,90,161,209,113,33,15,243,164,22,180,87,191,74,253,0,98,170,195,144,126,238,158,183,240,206,123,200,116,12,239,153,52,16,213,240,11,16,203,174,222,94,148,43,136,40,57,89,174,9,231,135,186,171,117,12,92,185,63,50,136,56,242,64,103,70,84,249,215,220,48,80,40,49,15,196,2,86,124,50,44,232,10,54,108,144,201,232,4,74,110,129,253,141,235,237,249,197,163,154,222,202,7,128,213,174,155,19,209,61,113,216,139,237,231,40,254,242,101,54,134,25,24,80,162,236,119,0,104,253,110,85,84,52,202,173,27,180,173,216,153,164,96,168,10,138,10,77,93,245,251,71,111,158,184,34,180,241,41,71,209,131,243,25,170,121,248,166,82,247,50,70,48,199,173,184,59,156,254,115,140,10,144,125,117,58,75,143,50,197,125,17,126,57,67,187,102,99,247,9,173,89,118,156,158,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlValuesBooleanFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9669d623-d70a-4b2d-a13d-5339e49ac90c"),
				Name = "SetControlValuesBooleanFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fd4064a5-2e54-4701-ae86-d8cdd18ac3fc"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,143,65,11,130,64,16,133,207,250,43,6,79,10,177,63,32,171,139,116,136,32,132,164,251,106,147,109,233,238,178,59,81,18,254,247,86,37,81,232,212,113,230,205,251,222,155,139,50,200,139,107,184,199,230,196,171,7,166,92,152,149,37,35,100,185,0,149,223,176,160,13,104,163,52,26,106,64,72,16,132,117,4,111,223,179,79,65,206,248,213,152,35,244,123,175,224,22,33,144,188,198,96,233,70,47,229,37,178,131,27,183,103,65,44,195,23,193,26,194,33,35,26,237,125,122,220,221,231,174,209,61,30,65,5,215,36,148,156,176,146,97,243,39,78,73,50,170,234,204,89,163,167,21,147,185,98,217,17,43,247,254,206,61,28,254,230,71,179,128,214,111,63,74,254,197,218,78,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlValuesItegerFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ea24f831-eb21-412f-89c8-b235c20cdca8"),
				Name = "SetControlValuesItegerFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2763d880-d3d0-4734-af14-3f4745863be4"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,75,139,194,64,16,132,207,17,252,15,131,167,4,100,96,175,235,227,160,120,144,133,69,214,224,125,156,180,218,26,167,179,51,237,174,65,252,239,182,6,31,1,241,224,173,187,139,250,170,102,22,228,193,216,85,252,5,229,204,228,59,152,24,244,221,192,30,221,178,173,104,190,6,203,125,85,120,42,192,115,169,208,41,100,216,38,234,208,108,68,225,31,89,156,87,81,11,162,18,34,107,2,168,150,51,91,104,125,158,247,104,98,150,160,191,101,31,101,200,58,133,61,171,158,138,171,152,228,6,184,20,232,92,12,115,105,181,233,220,89,214,20,140,228,30,113,195,234,244,54,145,28,123,202,207,246,180,44,106,69,135,117,41,232,41,228,242,15,99,121,121,252,60,34,121,158,129,225,7,126,119,232,33,171,225,87,96,55,3,218,127,84,19,100,210,92,34,255,4,167,83,26,16,229,96,92,252,58,224,216,108,28,79,230,197,88,72,187,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlValuesDateTimeFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dab56642-2176-4ce3-8f0a-c92c0808e6bd"),
				Name = "SetControlValuesDateTimeFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("301a95c1-440a-4cc0-8798-283a3ce3c99e"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,65,75,195,64,16,133,207,41,244,63,44,61,37,32,11,94,173,122,104,169,32,138,20,13,222,167,155,177,157,54,217,137,187,83,109,144,254,119,167,9,106,3,61,168,183,157,125,188,239,189,153,23,14,8,110,149,222,97,243,12,229,22,231,64,225,50,74,32,191,60,51,188,88,163,147,107,83,7,174,49,72,99,200,27,18,172,50,243,49,28,36,241,157,68,157,95,162,85,68,39,36,14,34,154,145,135,10,71,23,135,57,153,195,18,237,131,206,179,130,196,230,184,19,115,101,210,46,38,251,6,180,5,198,173,97,161,173,54,227,31,150,131,90,136,253,49,110,218,125,253,155,200,94,2,151,7,123,222,212,189,162,211,190,20,237,19,150,122,135,91,221,60,61,29,145,157,206,160,248,136,175,91,10,88,244,240,43,116,155,9,239,206,187,23,22,218,92,35,223,20,103,115,158,48,151,8,62,253,85,64,1,130,57,85,120,195,161,2,57,14,185,167,40,237,105,254,220,125,63,28,236,63,1,28,2,144,41,22,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlValuesFractionalFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6e340340-7129-40c1-92c9-772d2fdcb850"),
				Name = "SetControlValuesFractionalFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("01c48a9b-2902-4faa-9d70-14170a456499"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,75,139,194,64,16,132,207,17,252,15,131,167,4,100,96,175,235,227,160,120,144,133,69,214,224,125,156,180,218,26,167,179,51,237,174,65,252,239,182,6,31,1,241,224,173,187,139,250,170,102,22,228,193,216,85,252,5,229,204,228,59,152,24,244,221,192,30,221,178,173,104,190,6,203,125,85,120,42,192,115,169,208,41,100,216,38,234,208,108,68,225,31,89,156,87,81,11,162,18,34,107,2,168,150,51,91,104,125,158,247,104,98,150,160,191,101,31,101,200,58,133,61,171,158,138,171,152,228,6,184,20,232,92,12,115,105,181,233,220,89,214,20,140,228,30,113,195,234,244,54,145,28,123,202,207,246,180,44,106,69,135,117,41,232,41,228,242,15,99,121,121,252,60,34,121,158,129,225,7,126,119,232,33,171,225,87,96,55,3,218,127,84,19,100,210,92,34,255,4,167,83,26,16,229,96,92,252,58,224,216,108,28,79,230,197,88,72,187,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRemoveItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("630df399-09f3-4953-9d29-1a58e222de34"),
				Name = "RemoveItem",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,77,111,194,48,12,134,207,69,226,63,120,61,149,15,1,218,21,138,52,241,37,180,105,135,141,157,208,14,165,53,91,182,54,70,137,59,129,6,255,125,78,3,131,195,38,113,106,99,251,125,252,198,206,131,178,60,24,171,148,21,233,196,236,6,150,141,210,111,109,160,213,7,166,60,28,130,98,44,44,196,48,67,158,100,114,200,230,46,16,53,250,245,154,90,67,228,78,243,12,226,24,116,153,231,176,223,123,65,103,68,165,102,23,238,53,224,187,94,11,12,114,105,180,136,14,162,147,140,202,182,2,237,73,96,69,148,131,178,143,196,83,209,8,10,216,148,40,137,53,25,76,210,119,136,254,183,87,53,3,165,125,83,223,201,185,138,124,93,195,133,151,225,60,11,95,157,21,239,213,87,5,43,129,127,74,151,224,224,52,217,182,213,114,135,110,243,72,56,27,58,214,95,137,253,163,46,37,205,134,114,55,189,197,110,131,34,186,137,33,188,13,79,138,179,149,160,50,35,140,203,105,172,147,220,98,149,61,0,202,239,81,245,132,5,125,225,36,199,2,53,79,13,21,51,67,229,38,114,45,219,39,75,158,249,123,57,79,119,87,190,0,93,203,113,218,102,215,239,175,218,176,23,222,113,36,124,87,241,98,209,140,72,107,172,150,213,121,70,107,229,59,78,56,89,74,152,113,203,247,184,147,129,249,93,137,224,244,116,170,151,211,255,1,102,80,246,80,137,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignSelectionFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c3114ed4-240e-4e65-849f-c9de7d1e1584"),
				Name = "AssignSelectionFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("63314c14-2939-4575-ae96-e30869ccd4f9"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,75,107,195,48,16,132,239,133,254,7,147,147,13,69,208,115,232,161,78,219,96,8,109,137,221,222,133,52,73,150,216,82,34,175,75,252,239,27,201,68,84,125,221,246,49,223,48,187,196,232,196,189,214,249,204,200,14,179,155,236,85,110,33,158,207,245,163,38,22,13,78,92,204,175,175,40,202,148,60,48,89,115,81,46,166,246,47,177,53,236,108,235,183,205,120,136,246,139,116,220,139,26,45,20,67,87,158,124,151,237,128,212,135,250,53,142,3,57,232,104,177,131,218,151,246,116,59,85,208,41,160,37,203,39,106,25,238,2,60,196,201,255,89,189,46,36,248,26,120,69,61,7,236,247,160,31,210,101,48,76,60,214,106,135,78,86,58,187,203,242,229,64,186,8,120,105,237,254,101,179,198,6,14,70,77,159,13,240,153,245,170,4,126,11,244,18,28,219,114,172,116,158,250,255,188,182,182,131,83,62,240,55,47,209,216,154,29,153,109,94,20,243,79,185,115,146,221,238,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSelectionFieldDataValueTypesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("930357d2-7720-4889-a590-ab704bfb29ce"),
				Name = "GetSelectionFieldDataValueTypes",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,203,76,45,47,86,176,85,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,128,208,118,26,154,10,213,188,92,156,213,74,134,6,74,58,10,62,249,249,217,165,5,193,169,57,169,96,245,206,137,5,32,170,86,7,162,194,16,164,34,179,184,4,67,30,40,173,175,95,173,100,4,148,15,74,76,201,204,119,42,45,41,201,207,43,118,206,207,193,80,88,107,205,203,85,148,90,82,90,148,7,113,160,53,0,202,204,90,188,171,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignCommentaryFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("602f07ce-5bcc-4663-8047-0d593a3e3ef7"),
				Name = "AssignCommentaryFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ee8a2865-2c4c-43f6-979b-cb698e5bafeb"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,44,73,205,213,115,76,73,209,80,202,75,204,77,85,210,81,8,72,76,79,213,243,3,178,93,83,50,75,244,66,82,43,74,52,173,185,50,225,170,146,19,11,74,50,243,243,96,10,157,33,92,28,106,243,243,74,138,242,115,64,146,33,149,5,112,195,157,81,133,139,245,130,83,115,82,147,75,82,83,60,65,58,195,18,115,74,83,81,140,41,1,154,11,211,11,178,3,172,2,201,70,0,73,125,131,166,195,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignGroupOfElementsSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1595bf72-97f6-4ecf-8779-3d40cef20bbc"),
				Name = "AssignGroupOfElementsSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("063b7ffc-1b51-4159-b317-2eb7b85236e6"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,44,73,205,213,115,76,73,209,80,202,75,204,77,85,210,81,8,72,76,79,213,243,3,178,93,83,50,75,244,66,82,43,74,52,173,185,50,225,170,146,19,11,74,50,243,243,96,10,157,33,92,28,106,243,243,74,138,242,115,64,146,33,149,5,112,195,157,81,133,139,245,130,83,115,82,147,75,82,83,60,65,58,195,18,115,74,83,209,172,204,115,74,245,205,204,203,204,205,172,74,77,129,155,146,145,154,156,237,148,95,97,8,97,165,166,160,232,201,197,165,220,8,161,28,0,190,89,123,210,251,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignBooleanFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ef90da18-bb61-4e6c-8724-4e1f0fb8c712"),
				Name = "AssignBooleanFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("51973840-0855-435d-b98b-efc0dc32fc32"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,44,73,205,213,115,76,73,209,80,202,75,204,77,85,210,81,8,72,76,79,213,243,3,178,93,83,50,75,244,66,82,43,74,52,173,185,50,225,170,146,19,11,74,50,243,243,96,10,157,33,92,28,106,243,243,74,138,242,115,64,146,33,149,5,112,195,157,81,133,139,245,130,83,115,82,147,75,82,83,60,65,58,195,18,115,74,83,53,173,1,184,93,26,244,152,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignDateTimeFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dfed1187-caec-476a-b4f4-894a7456bb81"),
				Name = "AssignDateTimeFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("05801b29-62b2-4cbc-9ef1-2f0e9a630d51"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,193,10,194,48,16,68,239,126,133,244,164,32,1,207,158,180,40,8,34,162,193,123,232,14,186,216,36,53,217,66,253,123,173,165,129,128,222,102,119,223,204,44,11,172,90,19,205,10,103,44,138,197,244,100,110,80,199,143,222,18,139,210,232,100,190,154,112,162,42,211,8,123,55,130,229,48,254,97,189,147,224,235,254,168,95,77,10,47,243,117,84,23,212,168,4,180,239,157,87,83,183,200,98,56,158,241,108,57,128,82,194,29,213,99,227,187,229,160,64,25,79,70,160,217,98,231,131,53,50,122,14,28,229,251,230,175,182,55,253,78,240,146,6,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignIntegerFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d8b42e8a-05ae-4ed6-bc5a-aee4e5240d9c"),
				Name = "AssignIntegerFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("49af0f6e-9707-4e09-9a44-1d56ffa3f6ed"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,44,73,205,213,115,76,73,209,80,202,75,204,77,85,210,81,8,72,76,79,213,243,3,178,93,83,50,75,244,66,82,43,74,52,173,185,50,225,170,146,19,11,74,50,243,243,96,10,157,33,92,28,106,243,243,74,138,242,115,64,146,33,149,5,112,195,157,81,133,139,245,130,83,115,82,147,75,82,83,60,65,58,195,18,115,74,83,81,140,201,44,14,74,45,44,205,44,74,77,129,155,144,145,154,156,237,148,95,97,8,97,165,166,104,90,3,0,207,204,157,251,200,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignFractionalFieldSettingsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("561d4c3d-f4b0-41dc-90ef-571c9fb5b84c"),
				Name = "AssignFractionalFieldSettings",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b94f1867-9b6d-4081-a722-bb20e1488017"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ref Dictionary<string, object>",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,44,73,205,213,115,76,73,209,80,202,75,204,77,85,210,81,8,72,76,79,213,243,3,178,93,83,50,75,244,66,82,43,74,52,173,185,50,225,170,146,19,11,74,50,243,243,96,10,157,33,92,28,106,243,243,74,138,242,115,64,146,33,149,5,112,195,157,81,133,139,245,130,83,115,82,147,75,82,83,60,65,58,195,18,115,74,83,81,140,201,44,14,74,45,44,205,44,74,77,129,155,144,145,154,156,237,148,95,97,8,97,165,166,104,90,3,0,207,204,157,251,200,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaUIdByIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("25c05b06-e47d-4614-aed4-1137a3496df9"),
				Name = "GetSchemaUIdById",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("267ae3a6-4167-447b-a0f0-62de66f94f69"),
				Name = "schemaId",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,141,65,10,194,48,16,69,215,233,41,74,86,147,77,47,160,184,41,85,178,19,66,113,61,36,3,45,36,19,156,36,168,183,183,214,238,62,143,255,120,66,181,9,119,10,152,94,189,163,72,190,194,92,72,198,204,188,237,53,179,233,148,26,198,28,91,98,208,179,13,122,3,195,85,114,2,237,62,197,249,133,18,238,236,177,144,16,232,227,97,203,244,108,24,225,111,14,119,20,76,84,73,160,236,134,13,198,244,88,142,228,79,152,222,228,91,37,231,49,162,156,111,109,13,23,48,167,47,186,157,117,19,160,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaIdByUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8a64c934-06fe-436a-8137-aed662be2e28"),
				Name = "GetSchemaIdByUId",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6e91f09b-1c96-4584-8df6-c75142c70e9c"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,207,10,130,64,16,198,207,250,20,178,167,21,98,95,160,8,66,44,236,146,32,226,121,88,135,148,214,221,154,117,169,222,190,53,165,210,67,183,249,243,125,191,111,24,194,222,145,14,3,174,241,30,21,168,80,246,188,180,72,137,209,218,215,173,209,113,24,4,34,49,202,117,154,179,226,105,11,217,96,7,108,21,177,172,102,126,41,246,100,186,223,205,48,203,188,155,142,166,29,45,57,200,11,156,145,197,226,52,31,76,16,145,217,244,230,64,45,248,95,225,148,84,53,72,184,16,149,51,192,120,167,200,129,160,195,30,137,219,183,208,139,226,1,176,211,245,50,223,119,149,161,139,189,130,196,255,168,249,91,196,199,37,6,120,4,118,122,223,144,147,62,80,186,30,11,9,10,104,115,112,109,189,229,241,250,5,24,135,200,119,108,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDesignedProcessSchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ab7d96f7-6602-4afa-b1ad-9246ea526c66"),
				Name = "GetDesignedProcessSchema",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("7663f358-75c0-464d-a7d1-6815c4cfa6e4"),
				ResultValueTypeName = "ProcessSchema"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,40,202,79,78,45,46,14,78,206,72,205,77,244,77,204,75,76,79,45,210,115,79,45,113,73,45,206,76,207,243,204,43,46,73,204,75,78,213,64,213,165,163,224,154,146,89,2,209,19,234,153,162,105,13,0,27,32,176,57,92,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRemoveElementFromGroupMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("27ea9357-0841-4251-8ed9-fca8d9de4cf1"),
				Name = "RemoveElementFromGroup",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d2785ebb-38ca-4b68-8a73-adbd7027e607"),
				Name = "item",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fa442abf-69c9-4f1f-b191-3881e96c70ee"),
				Name = "groupId",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,79,202,74,77,46,81,40,75,204,41,77,181,230,202,76,83,208,208,40,46,41,202,204,75,215,204,44,73,205,141,86,74,206,207,43,41,202,207,113,77,201,44,9,169,44,72,85,138,85,80,180,85,80,50,82,226,226,228,84,83,83,0,169,209,11,41,170,116,79,45,9,3,153,160,161,148,94,148,95,90,224,153,162,164,163,144,95,10,53,86,83,1,168,18,204,2,233,205,43,205,201,1,9,192,172,129,72,216,218,42,64,117,106,42,84,115,113,66,236,134,153,21,171,0,209,102,205,85,11,0,76,200,235,192,175,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsExistsControlNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("32cc1201-09d7-4e8d-9f04-0fed1bca4d5f"),
				Name = "GetIsExistsControlName",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fcf6f427-bca6-464f-9482-9e8ecf076329"),
				Name = "controlName",
				CreatedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				ModifiedInSchemaUId = new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,77,11,130,48,24,199,207,9,126,135,39,79,19,34,186,171,93,42,66,8,251,0,225,193,151,89,43,221,98,123,132,36,252,238,109,62,93,12,186,109,255,253,95,126,59,9,131,241,94,84,40,148,44,244,16,27,212,66,94,87,160,202,59,175,112,187,5,129,188,51,144,192,145,227,161,182,151,58,117,2,11,35,223,19,13,176,233,121,189,83,189,68,72,18,216,132,240,246,189,133,230,216,107,9,77,209,26,110,141,163,239,81,47,240,151,221,163,142,180,182,173,178,111,91,107,104,148,230,69,117,3,246,159,100,2,1,33,9,136,102,28,0,35,95,232,228,75,32,139,142,7,185,35,169,148,68,173,218,204,10,100,94,252,110,207,147,105,29,228,145,179,149,22,229,225,78,227,4,238,54,126,146,132,253,239,167,46,64,205,235,212,100,214,120,214,135,238,137,3,163,120,56,203,161,238,191,177,175,48,159,90,38,64,167,232,3,19,12,137,103,168,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ControlSettingsEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("609bc8ff-4f0b-468a-9cc7-3d7ffc1f886a"));
		}

		#endregion

	}

	#endregion

}

