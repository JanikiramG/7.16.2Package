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
	using System.Linq;
	using System.Text;
	using System.Threading;
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

	#region Class: ExcelImportLogGridPageSchema

	/// <exclude/>
	public class ExcelImportLogGridPageSchema : Terrasoft.WebApp.LookupGridPageSchema
	{

		#region Constructors: Public

		public ExcelImportLogGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ExcelImportLogGridPageSchema(ExcelImportLogGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateSchemaListEdit() {
			SchemaListEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SchemaListEdit.Image = new ControlImage {};
			SchemaListEdit.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateSearchComboBoxEdit() {
			SearchComboBoxEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SearchComboBoxEdit.Image = new ControlImage {};
			SearchComboBoxEdit.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateToolButtonClearSearch() {
			ToolButtonClearSearch.AjaxEvents.Click.IsProcessEventHandler = true;
			ToolButtonClearSearch.Image = new ControlImage {
				Source = ControlImageSource.ResourceManager,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ResourceManagerName = @"Terrasoft.UI.WebControls",
				ResourceItemName = @"toolbutton-close.gif",
				ImageHash = @"6936621ac4b4c164b51744b8634fe7a0"
			};
			ToolButtonClearSearch.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateSearchEdit() {
			SearchEdit.Image = new ControlImage {};
			SearchEdit.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateSearchButton() {
			SearchButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SearchButton.Image = new ControlImage {};
			SearchButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateSearchControlLayout() {
			SearchControlLayout.Image = new ControlImage {};
			SearchControlLayout.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.Hidden = true;
			AddButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.DblClick.ShowLoadMask = true;
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.ShowLoadMask = true;
		}

		private void UpdateAddSelectedRecordButton() {
			AddSelectedRecordButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddSelectedRecordButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ImageHash = @"f5fb6c4a8d5abab00bede0e49a38a6ff"
			};
			AddSelectedRecordButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateRemoveSelectedRecordButton() {
			RemoveSelectedRecordButton.AjaxEvents.Click.IsProcessEventHandler = true;
			RemoveSelectedRecordButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ImageHash = @"012f06e2ee1dc8d32d3959105560eacd"
			};
			RemoveSelectedRecordButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateSelectedRecordButtonsControlLayout() {
			SelectedRecordButtonsControlLayout.Image = new ControlImage {};
			SelectedRecordButtonsControlLayout.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateSelectedRecordsGridContolLayout() {
			SelectedRecordsGridContolLayout.Image = new ControlImage {};
			SelectedRecordsGridContolLayout.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateSelectedRowsControlLayout() {
			SelectedRowsControlLayout.Image = new ControlImage {};
			SelectedRowsControlLayout.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateCommonControlLayout() {
			CommonControlLayout.Image = new ControlImage {};
			CommonControlLayout.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		private void UpdateActionButtonsControlLayout() {
			ActionButtonsControlLayout.Image = new ControlImage {};
			ActionButtonsControlLayout.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
			RealUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
			Name = "ExcelImportLogGridPage";
			ParentSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateExcelImportLogGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateActionButtonsControlLayout();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateCommonControlLayout();
			UpdateSelectedRowsControlLayout();
			UpdateSelectedRecordsGridContolLayout();
			UpdateSelectedRecordButtonsControlLayout();
			UpdateRemoveSelectedRecordButton();
			UpdateAddSelectedRecordButton();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			UpdateSearchControlLayout();
			UpdateSearchButton();
			UpdateSearchEdit();
			UpdateToolButtonClearSearch();
			UpdateSearchComboBoxEdit();
			UpdateSchemaListEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, SearchControlLayout);
			SearchControlLayout.MoveItem(0, SchemaListEdit);
			SearchControlLayout.MoveItem(1, SearchComboBoxEdit);
			SearchControlLayout.MoveItem(2, SearchEdit);
			SearchEdit.MoveItem(0, ToolButtonClearSearch);
			SearchControlLayout.MoveItem(3, SearchButton);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerDeleteButton);
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			ButtonsControlLayout.MoveItem(8, ActionButton);
			TopLevelControl.MoveItem(3, CommonControlLayout);
			CommonControlLayout.MoveItem(0, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, CallMenuItem);
			TreeGrid.MoveItem(2, ShowChangelogMenuItem);
			CommonControlLayout.MoveItem(1, SelectedRowsControlLayout);
			SelectedRowsControlLayout.MoveItem(0, SelectedRecordButtonsControlLayout);
			SelectedRecordButtonsControlLayout.MoveItem(0, Spacer1);
			SelectedRecordButtonsControlLayout.MoveItem(1, AddSelectedRecordButton);
			SelectedRecordButtonsControlLayout.MoveItem(2, RemoveSelectedRecordButton);
			SelectedRecordButtonsControlLayout.MoveItem(3, Spacer2);
			SelectedRowsControlLayout.MoveItem(1, SelectedRecordsGridContolLayout);
			SelectedRecordsGridContolLayout.MoveItem(0, SelectedRecordsGrid);
			TopLevelControl.MoveItem(4, ActionButtonsControlLayout);
			ActionButtonsControlLayout.MoveItem(0, SpacerOKButton);
			ActionButtonsControlLayout.MoveItem(1, OKButton);
			ActionButtonsControlLayout.MoveItem(2, CancelButton);
			TopLevelControl.MoveItem(5, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateExcelImportLogGridPageEventsProcessSchema() {
			var schema = new ExcelImportLogGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0");
			DataSource.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("44fcd665-a56a-4e00-8a5f-6bccb100c87c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("c2523a13-ecc1-425e-9b8b-f0bb435904fd");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("18d94d63-e6b7-453e-80af-46e5bffe66c3");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("9b2b996b-ebfe-474b-971a-057227086dc5");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("a1058616-04ef-4b64-96b4-8cf008399504");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("008aa210-1706-4bb0-b5c9-ba9d4b7031f7");
			if (column != null) {
				column.UId = new Guid("9b652ffa-cd24-4581-b948-093a538564cd");
				column.Name = @"MessageText";
				column.CreatedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3db83ec2-10df-4784-9a2b-adb75c2b7ca2");
			if (column != null) {
				column.UId = new Guid("19bfd16a-aaec-4233-84a0-46a3a0635478");
				column.Name = @"ExcelImport";
				column.CreatedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("0d4cde64-a8ab-4d1f-bc1e-5b65fdd9b4b6");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("fac8913b-2251-4a13-b757-5faa0e73896f");
			if (column != null) {
				column.UId = new Guid("52b80f90-d5a6-438a-b22d-144fd5c4eb3d");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
				column.ModifiedInSchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
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
			return new ExcelImportLogGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new ExcelImportLogGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ExcelImportLogGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ExcelImportLogGridPageEventsProcess

	/// <exclude/>
	public class ExcelImportLogGridPageEventsProcess<TPage> : Terrasoft.WebApp.LookupGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ExcelImportLogGridPageSchemaUserControl
	{

		public ExcelImportLogGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ExcelImportLogGridPageEventsProcess";
			SchemaUId = new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b50a87bc-9bf2-4680-b497-462ab3f9b65d");
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

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
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

	#region Class: ExcelImportLogGridPageEventsProcess

	/// <exclude/>
	public class ExcelImportLogGridPageEventsProcess : ExcelImportLogGridPageEventsProcess<Terrasoft.WebApp.ExcelImportLogGridPageSchemaUserControl>
	{

		public ExcelImportLogGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ExcelImportLogGridPageSchemaUserControl

	/// <exclude/>
	public partial class ExcelImportLogGridPageSchemaUserControl : Terrasoft.WebApp.LookupGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ExcelImportLogGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ExcelImportLogGridPageEventsProcess(UserConnection);
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
			SchemaName = "ExcelImportLogGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: ExcelImportLogGridPageEventsProcessSchema

	/// <exclude/>
	public class ExcelImportLogGridPageEventsProcessSchema : Terrasoft.WebApp.LookupGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public ExcelImportLogGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ExcelImportLogGridPageEventsProcessSchema(ExcelImportLogGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ExcelImportLogGridPageEventsProcess";
			UId = new Guid("bc87e123-704c-4a0d-bb9b-8a8035540635");
			CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("041f8571-1e0d-4d76-9587-98645fd79cea"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dc00bb50-26d4-4608-809c-73585d9eebd9"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ExcelImportLogGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc87e123-704c-4a0d-bb9b-8a8035540635"));
		}

		#endregion

	}

	#endregion

}

