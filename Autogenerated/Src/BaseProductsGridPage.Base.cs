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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: BaseProductsGridPageSchema

	/// <exclude/>
	public class BaseProductsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _settingsButton;
		public Terrasoft.UI.WebControls.Controls.Button SettingsButton {
			get {
				return _settingsButton;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseProductsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseProductsGridPageSchema(BaseProductsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.IsMultilineMode = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
			RealUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
			Name = "BaseProductsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseProductsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.InsertItem(5, CreateSettingsButton());
			ButtonsControlLayout.MoveItem(6, ActionButton);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseProductsGridPageEventsProcessSchema() {
			var schema = new BaseProductsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSettingsButton() {
			_settingsButton = new Terrasoft.UI.WebControls.Controls.Button();
			_settingsButton.UId = new Guid("ff4f381c-1a64-446e-8397-f608e7b7ca7c");
			_settingsButton.Name = "SettingsButton";
			_settingsButton.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
			_settingsButton.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
			_settingsButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_settingsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_settingsButton.Tag = "";
			_settingsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9"),
				ImageHash = @"ac25c12b47d7251a7d950b0ae8213c0e"
			};
			_settingsButton.Width = System.Web.UI.WebControls.Unit.Pixel(25);
			_settingsButton.Enabled = false;
			_settingsButton.Hidden = true;
			return _settingsButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed");
			DataSource.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("2bdbebd7-0f9f-4f29-9b95-d8dc9fe24c18");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("0132916a-5938-49ee-a038-c7f505d8737e");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("1f7eade9-466f-44d1-8811-8837e8532fe1");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("821eb9ff-7f57-4bd4-961c-c58d3f47b4d5");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("1d5471a1-e09a-49fc-a388-ae8ee2946f0e");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae5ef7d5-1044-477f-affb-83bce9e65bbd");
			if (column != null) {
				column.UId = new Guid("af28fdce-ee8f-470e-a901-d7f57573c26b");
				column.Name = @"ProductSource";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
			column.Caption.SetResourceInfo("0d5c8079c1bf459588089b442cb9e2b9", "Controls.DataSource.DefStructure.Columns.ProductSource.Caption");
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e3040d2d-93ff-4528-a4b7-42603e08bdcf");
			if (column != null) {
				column.UId = new Guid("8b5a18e4-3d38-4c63-9b4c-b0ccbd81d97d");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.Width = 200;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2e1f4643-a44a-415e-8c4c-79283dc3d1d9");
			if (column != null) {
				column.UId = new Guid("415837fe-7113-44b5-b607-07ceb01273c4");
				column.Name = @"Code";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e485abc9-4cc0-48ba-a8e6-76a6dd2ea222");
			if (column != null) {
				column.UId = new Guid("6703123c-f457-4d0c-9272-a9f672278673");
				column.Name = @"Unit";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e241007b-18ad-4411-a6fb-caf56fdaa941");
			if (column != null) {
				column.UId = new Guid("709fd715-09aa-47d7-990e-1466b1c1fdb8");
				column.Name = @"Currency";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ab19483e-bd98-4b76-9565-56f7e309758b");
			if (column != null) {
				column.UId = new Guid("79866d65-5658-433f-a615-689f038f2248");
				column.Name = @"Price";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.Width = 70;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("51a20224-e62d-4198-b3e5-354d46e68af8");
			if (column != null) {
				column.UId = new Guid("b09530f7-9bda-4153-9451-9a7f3b4d5726");
				column.Name = @"Tax";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6cd88fbf-2355-45f8-8c8a-8e6308a77b96");
			if (column != null) {
				column.UId = new Guid("40b63460-005a-44c9-83d8-1c88a57711c5");
				column.Name = @"URL";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ac574603-a4db-410c-877d-e383c0a6c51a");
			if (column != null) {
				column.UId = new Guid("bcd023a3-4a8c-4c8b-a224-cbdc99c0f317");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b4687e9c-060d-4f9b-8367-b8ed66af0ada");
			if (column != null) {
				column.UId = new Guid("9affdba9-721f-4467-9fed-cda2b64f6d48");
				column.Name = @"Active";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("bced17a4-55ea-4281-8365-e489b5099535");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b2030ccd-1270-4bed-ac8b-4ebf4cfda0d1");
			if (column != null) {
				column.UId = new Guid("ff8efe6e-d3d6-46a8-90a3-06e2d0d63089");
				column.Name = @"Owner";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("75b2a101-2a27-4911-a5c0-d4f7c724914d");
			if (column != null) {
				column.UId = new Guid("75cbade8-1b7a-4035-8ce7-3aad4e08414b");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4c9ed783-148c-41eb-92dd-5975dcfbdcd1");
			if (column != null) {
				column.UId = new Guid("dae06db9-80a6-480d-af73-46c86cfd7025");
				column.Name = @"Notes";
				column.CreatedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.ModifiedInSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseProductsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseProductsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseProductsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductsGridPageEventsProcess

	/// <exclude/>
	public class BaseProductsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseProductsGridPageSchemaUserControl
	{

		public BaseProductsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseProductsGridPageEventsProcess";
			SchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9");
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

		public virtual bool IsEditMode {
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
					SchemaElementUId = new Guid("8bcc611c-6873-4209-b4bd-e86c44e10508"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _treeGridDblClickMessage;
		public ProcessFlowElement TreeGridDblClickMessage {
			get {
				return _treeGridDblClickMessage ?? (_treeGridDblClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "TreeGridDblClickMessage",
					SchemaElementUId = new Guid("cb5b4c2c-7e6e-4824-b95f-418dc6e2b44e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _treeGridDblClickScriptTask;
		public ProcessScriptTask TreeGridDblClickScriptTask {
			get {
				return _treeGridDblClickScriptTask ?? (_treeGridDblClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TreeGridDblClickScriptTask",
					SchemaElementUId = new Guid("b1a7ee93-d69b-4420-a13a-d679d6c9436f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TreeGridDblClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("9f6b08f9-bed5-410d-ae2d-d7cfe2ef1917"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadStartMessage;
		public ProcessFlowElement PageLoadStartMessage {
			get {
				return _pageLoadStartMessage ?? (_pageLoadStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadStartMessage",
					SchemaElementUId = new Guid("e6f07ba1-5113-4927-82a0-2d69933a1dd2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadScriptTask;
		public ProcessScriptTask PageLoadScriptTask {
			get {
				return _pageLoadScriptTask ?? (_pageLoadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadScriptTask",
					SchemaElementUId = new Guid("42ee6c02-2c04-46bc-933c-b4328aef247f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoadIntermediateThrowMessageEvent {
			get {
				return _pageLoadIntermediateThrowMessageEvent ?? (_pageLoadIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("988a763b-26d2-43e2-b287-33b9ec76503d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
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
					SchemaElementUId = new Guid("44db7322-d909-474a-8912-81aaabcab923"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _settingsButtonClickStartMessage;
		public ProcessFlowElement SettingsButtonClickStartMessage {
			get {
				return _settingsButtonClickStartMessage ?? (_settingsButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SettingsButtonClickStartMessage",
					SchemaElementUId = new Guid("fa566b3b-d1ef-4007-9799-787c427a7bb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _tuningModeChangedScriptTask;
		public ProcessScriptTask TuningModeChangedScriptTask {
			get {
				return _tuningModeChangedScriptTask ?? (_tuningModeChangedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "TuningModeChangedScriptTask",
					SchemaElementUId = new Guid("f058dd13-2925-48b5-8c65-d5b8b4f61ee6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = TuningModeChangedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[TreeGridDblClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickMessage };
			FlowElements[TreeGridDblClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { TreeGridDblClickScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[PageLoadStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadStartMessage };
			FlowElements[PageLoadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadScriptTask };
			FlowElements[PageLoadIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadIntermediateThrowMessageEvent };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[SettingsButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SettingsButtonClickStartMessage };
			FlowElements[TuningModeChangedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { TuningModeChangedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "TreeGridDblClickMessage":
						e.Context.QueueTasks.Enqueue("TreeGridDblClickScriptTask");
						break;
					case "TreeGridDblClickScriptTask":
						break;
					case "EventSubProcess8":
						break;
					case "PageLoadStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadScriptTask");
						break;
					case "PageLoadScriptTask":
						e.Context.QueueTasks.Enqueue("PageLoadIntermediateThrowMessageEvent");
						break;
					case "PageLoadIntermediateThrowMessageEvent":
						break;
					case "EventSubProcess9":
						break;
					case "SettingsButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("TuningModeChangedScriptTask");
						break;
					case "TuningModeChangedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("TreeGridDblClickMessage");
			ActivatedEventElements.Add("PageLoadStartMessage");
			ActivatedEventElements.Add("SettingsButtonClickStartMessage");
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
				case "TreeGridDblClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClickMessage";
					result = TreeGridDblClickMessage.Execute(context);
					break;
				case "TreeGridDblClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "TreeGridDblClickScriptTask";
					result = TreeGridDblClickScriptTask.Execute(context, TreeGridDblClickScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadStartMessage";
					result = PageLoadStartMessage.Execute(context);
					break;
				case "PageLoadScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadScriptTask";
					result = PageLoadScriptTask.Execute(context, PageLoadScriptTaskExecute);
					break;
				case "PageLoadIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = PageLoadIntermediateThrowMessageEvent.Execute(context);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "SettingsButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SettingsButtonClickStartMessage";
					result = SettingsButtonClickStartMessage.Execute(context);
					break;
				case "TuningModeChangedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "TuningModeChangedScriptTask";
					result = TuningModeChangedScriptTask.Execute(context, TuningModeChangedScriptTaskExecute);
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
				case "IsEditMode":
					IsEditMode = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool TreeGridDblClickScriptTaskExecute(ProcessExecutingContext context) {
			if(!IsEditMode) ListenerThrowEvent(ListenerPageProcessUId,"LookupRecordSelected");
			else {
			ProcessThrowMessageEvent _intermediateThrowMessage = new ProcessThrowMessageEvent() {
								UId = Guid.NewGuid(),
								Owner = this,
								Type = "ProcessSchemaIntermediateThrowMessageEvent",
								Name = "IntermediateThrowMessageEvent1",
								SchemaElementUId = new Guid("9e74f5c0-9569-4424-b4c2-b70ff91b0a56"),
								CreatedInSchemaUId = InternalSchemaUId,
								ExecutedEventHandler = OnExecuted,
								Message = "TreeGridDblClick",
								ThrowToBase = true,
							};
			_intermediateThrowMessage.Execute(context);
			}
			return true;
		}

		public virtual bool PageLoadScriptTaskExecute(ProcessExecutingContext context) {
			if (!Ext.IsAjaxRequest) {
				string editMode = (string)Page.GetParameterValue("editMode");
				IsEditMode = string.IsNullOrEmpty(editMode) ? false : Convert.ToBoolean(editMode);
			}
			return true;
		}

		public virtual bool TuningModeChangedScriptTaskExecute(ProcessExecutingContext context) {
			ListenerThrowEvent(ListenerPageProcessUId,"TuningModeChanged");
			return true;
		}

		public override List<Tuple<Guid, string, Guid, bool>> GetModuleProcessesInfo() {
			var moduleProcessInfoList = base.GetModuleProcessesInfo();
			if(moduleProcessInfoList.Count>0)
			{
				int i = 0;
				for (i = 0; i < moduleProcessInfoList.Count; i++) {
					if (moduleProcessInfoList[i].Item3.Equals(new Guid("FE482F04-3ECB-4916-ADE0-0DB6B2194882"))) {
						var newItem = new Tuple<Guid, string, Guid, bool>(
							moduleProcessInfoList[i].Item1,
							moduleProcessInfoList[i].Item2,
							moduleProcessInfoList[i].Item3,
							true
						);
						moduleProcessInfoList.Remove(moduleProcessInfoList[i]);
						moduleProcessInfoList.Insert(i, newItem);
					}
				}
				
			}
			return moduleProcessInfoList;
		}

		public override string GetRegisterTreeGridDblClickScript(string defaultScript) {
			if(IsEditMode) 
				return base.GetRegisterTreeGridDblClickScript(defaultScript);
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "TreeGridDblClick":
							if (ActivatedEventElements.Contains("TreeGridDblClickMessage")) {
							context.QueueTasks.Enqueue("TreeGridDblClickMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoadStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadStartMessage");
						}
						break;
					case "SettingsButtonClick":
							if (ActivatedEventElements.Contains("SettingsButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("SettingsButtonClickStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsEditMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEditMode", IsEditMode, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductsGridPageEventsProcess

	/// <exclude/>
	public class BaseProductsGridPageEventsProcess : BaseProductsGridPageEventsProcess<Terrasoft.WebApp.BaseProductsGridPageSchemaUserControl>
	{

		public BaseProductsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseProductsGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseProductsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.Button SettingsButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SettingsButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SettingsButton.AjaxEvents.Click.Event += SettingsButtonClick;
			TreeGrid.AjaxEvents.DblClick.Event += TreeGridDblClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SettingsButton.AjaxEvents.Click.Event -= SettingsButtonClick;
			TreeGrid.AjaxEvents.DblClick.Event -= TreeGridDblClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseProductsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseProductsGridPageEventsProcess(UserConnection);
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

		public virtual void SettingsButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SettingsButtonClick");
		}

		public virtual void TreeGridDblClick(object sender, EventArgs e) {
			object result = ThrowEvent("TreeGridDblClick");
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
			SchemaName = "BaseProductsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductsGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseProductsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseProductsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseProductsGridPageEventsProcessSchema(BaseProductsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseProductsGridPageEventsProcess";
			UId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateIsEditModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1af3cb39-4655-4a8c-b184-1e43328a00dc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"IsEditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsEditModeParameter());
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaStartMessageEvent treegriddblclickmessage = CreateTreeGridDblClickMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(treegriddblclickmessage);
			ProcessSchemaScriptTask treegriddblclickscripttask = CreateTreeGridDblClickScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(treegriddblclickscripttask);
			ProcessSchemaStartMessageEvent pageloadstartmessage = CreatePageLoadStartMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(pageloadstartmessage);
			ProcessSchemaScriptTask pageloadscripttask = CreatePageLoadScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(pageloadscripttask);
			ProcessSchemaIntermediateThrowMessageEvent pageloadintermediatethrowmessageevent = CreatePageLoadIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(pageloadintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent settingsbuttonclickstartmessage = CreateSettingsButtonClickStartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(settingsbuttonclickstartmessage);
			ProcessSchemaScriptTask tuningmodechangedscripttask = CreateTuningModeChangedScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(tuningmodechangedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9fc1ad25-ea8b-4e87-ab79-3afab75b1fc9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				CurveCenterPosition = new Point(168, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cb5b4c2c-7e6e-4824-b95f-418dc6e2b44e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b1a7ee93-d69b-4420-a13a-d679d6c9436f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0f28bbf4-d522-4ac1-8802-bbd0b2c7a802"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				CurveCenterPosition = new Point(180, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e6f07ba1-5113-4927-82a0-2d69933a1dd2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("42ee6c02-2c04-46bc-933c-b4328aef247f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("b760744d-a805-416f-9c0b-3a11a44aa084"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				CurveCenterPosition = new Point(331, 244),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42ee6c02-2c04-46bc-933c-b4328aef247f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("988a763b-26d2-43e2-b287-33b9ec76503d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("21d6f51c-de61-49e1-a0a1-0caf210eb087"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fa566b3b-d1ef-4007-9799-787c427a7bb7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f058dd13-2925-48b5-8c65-d5b8b4f61ee6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0d2d28a2-8611-4fe2-b266-3e5c1c505c97"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(793, 495),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("f70b75d6-56cd-4a17-a548-f43d7d7484a2"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("0d2d28a2-8611-4fe2-b266-3e5c1c505c97"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"Lane1",
				Position = new Point(29, 164),
				Size = new Size(764, 151),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("f9b7516f-249e-4b8c-aaf6-0f95ccc3be0e"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("0d2d28a2-8611-4fe2-b266-3e5c1c505c97"),
				CreatedInOwnerSchemaUId = new Guid("0d5c8079-c1bf-4595-8808-9b442cb9e2b9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 320),
				Size = new Size(764, 175),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("27806651-252a-4b8d-9335-562d03c3004a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("0d2d28a2-8611-4fe2-b266-3e5c1c505c97"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"Lane3",
				Position = new Point(29, 0),
				Size = new Size(764, 159),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8bcc611c-6873-4209-b4bd-e86c44e10508"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f70b75d6-56cd-4a17-a548-f43d7d7484a2"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(353, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateTreeGridDblClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cb5b4c2c-7e6e-4824-b95f-418dc6e2b44e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8bcc611c-6873-4209-b4bd-e86c44e10508"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TreeGridDblClick",
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"TreeGridDblClickMessage",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTreeGridDblClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b1a7ee93-d69b-4420-a13a-d679d6c9436f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8bcc611c-6873-4209-b4bd-e86c44e10508"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"TreeGridDblClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,93,111,130,48,20,134,175,103,226,127,96,92,65,34,70,13,106,136,217,205,28,113,36,126,101,178,235,165,180,135,217,8,173,105,203,112,89,252,239,150,242,177,221,56,110,32,231,125,207,115,222,211,66,83,231,49,146,33,161,106,195,9,184,214,154,74,5,12,68,124,20,188,12,191,128,41,167,45,237,209,39,236,5,199,32,229,123,68,6,246,154,243,83,113,126,3,204,5,57,64,6,88,1,177,221,69,191,7,153,4,235,167,223,107,204,6,181,209,31,186,223,16,173,15,202,20,136,28,8,69,10,254,202,214,147,197,160,180,238,53,58,110,133,125,168,30,157,64,155,87,5,37,195,45,148,213,219,113,7,141,182,43,117,90,173,170,35,149,109,45,254,62,87,116,187,65,31,240,17,114,20,221,137,97,134,217,109,235,22,229,166,245,95,247,184,179,215,232,48,131,92,151,235,152,213,78,38,162,29,192,220,79,167,120,228,5,211,89,224,249,254,196,247,18,31,79,188,100,62,74,211,96,156,140,208,116,102,119,139,44,5,232,89,36,98,53,179,134,153,24,12,101,93,173,117,135,23,192,133,182,155,60,175,136,145,204,156,194,142,181,66,107,252,61,108,59,22,0,43,65,201,75,146,45,51,138,79,221,22,102,193,152,63,35,89,249,148,40,160,81,174,250,130,239,222,223,176,25,229,96,174,29,23,85,253,13,215,126,79,128,42,4,51,148,197,13,123,113,97,191,113,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9f6b08f9-bed5-410d-ae2d-d7cfe2ef1917"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9b7516f-249e-4b8c-aaf6-0f95ccc3be0e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(333, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e6f07ba1-5113-4927-82a0-2d69933a1dd2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f6b08f9-bed5-410d-ae2d-d7cfe2ef1917"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"PageLoadStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("42ee6c02-2c04-46bc-933c-b4328aef247f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f6b08f9-bed5-410d-ae2d-d7cfe2ef1917"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"PageLoadScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,141,193,10,130,64,20,69,215,9,254,195,203,213,204,198,15,72,34,42,36,92,84,18,209,254,129,79,81,198,153,122,243,38,140,232,223,19,68,220,94,206,57,183,173,65,173,243,65,210,194,239,59,28,110,244,10,228,69,195,55,142,86,94,184,181,13,80,213,202,217,85,4,91,80,211,164,75,108,40,61,145,148,200,216,147,16,63,208,4,82,201,140,38,58,27,253,194,231,139,58,153,227,205,37,24,115,229,188,127,202,71,205,188,134,29,212,104,60,193,6,142,206,190,137,37,189,187,131,115,134,208,46,212,24,253,197,17,147,4,182,32,28,40,251,3,219,202,40,207,191,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("988a763b-26d2-43e2-b287-33b9ec76503d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f6b08f9-bed5-410d-ae2d-d7cfe2ef1917"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"PageLoadIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("44db7322-d909-474a-8912-81aaabcab923"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("27806651-252a-4b8d-9335-562d03c3004a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"EventSubProcess9",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(346, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSettingsButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fa566b3b-d1ef-4007-9799-787c427a7bb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("44db7322-d909-474a-8912-81aaabcab923"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SettingsButtonClick",
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"SettingsButtonClickStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateTuningModeChangedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f058dd13-2925-48b5-8c65-d5b8b4f61ee6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("44db7322-d909-474a-8912-81aaabcab923"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"),
				Name = @"TuningModeChangedScriptTask",
				Position = new Point(225, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,240,129,10,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,133,148,230,101,230,165,251,230,167,164,58,103,36,230,165,167,166,40,105,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,198,129,136,189,77,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateGetModuleProcessesInfoMethod() {
			SchemaMethod method = base.CreateGetModuleProcessesInfoMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,75,107,194,64,16,62,39,144,255,176,120,218,96,18,242,66,34,90,161,209,40,1,11,69,188,149,30,98,157,148,133,100,183,221,71,122,40,253,239,221,77,44,244,16,197,195,14,59,187,223,99,248,166,171,56,106,217,89,53,240,204,217,27,8,81,210,154,237,137,144,232,1,157,42,1,193,14,228,211,255,127,232,17,216,93,56,54,169,241,40,53,88,51,69,229,42,116,29,251,219,177,45,66,37,34,90,46,212,20,171,102,28,225,161,211,143,203,113,239,65,64,3,166,83,23,25,9,139,212,104,220,235,133,188,6,165,132,54,9,138,79,85,53,2,83,248,66,59,69,206,120,178,45,210,44,222,134,169,159,20,235,220,79,231,209,204,127,220,20,161,31,110,242,89,30,71,243,52,203,226,137,235,94,28,172,78,39,161,201,70,76,143,103,100,142,234,163,129,165,17,243,144,144,156,208,119,15,13,221,137,177,102,133,123,154,117,115,172,200,187,3,20,223,3,74,46,32,201,21,244,55,179,129,107,164,224,0,45,235,224,106,100,55,185,37,21,192,37,38,222,95,28,3,250,71,23,115,28,91,87,14,82,113,58,190,189,197,47,70,112,37,234,84,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterTreeGridDblClickScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterTreeGridDblClickScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,240,44,118,77,201,44,241,205,79,73,213,84,224,229,226,44,74,45,41,45,202,83,72,74,44,78,213,115,79,45,9,74,77,207,44,46,73,45,10,41,74,77,117,47,202,76,113,73,202,113,206,201,76,206,14,78,46,202,44,40,209,72,73,77,75,44,205,41,129,240,52,173,121,185,160,218,139,75,138,50,243,210,245,92,115,11,74,42,129,162,0,76,46,20,184,103,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseProductsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b2b7d96-6c5a-4e3b-8390-294e05dd9b1e"));
		}

		#endregion

	}

	#endregion

}

