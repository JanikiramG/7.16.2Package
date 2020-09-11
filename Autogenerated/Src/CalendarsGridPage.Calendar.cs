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

	#region Class: CalendarsGridPageSchema

	/// <exclude/>
	public class CalendarsGridPageSchema : Terrasoft.WebApp.LookupGridPageSchema
	{

		#region Constructors: Public

		public CalendarsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CalendarsGridPageSchema(CalendarsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateSchemaListEdit() {
			SchemaListEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SchemaListEdit.Image = new ControlImage {};
			SchemaListEdit.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateSearchComboBoxEdit() {
			SearchComboBoxEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			SearchComboBoxEdit.Image = new ControlImage {};
			SearchComboBoxEdit.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
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
			ToolButtonClearSearch.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateSearchEdit() {
			SearchEdit.Image = new ControlImage {};
			SearchEdit.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateSearchButton() {
			SearchButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SearchButton.Image = new ControlImage {};
			SearchButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateSearchControlLayout() {
			SearchControlLayout.Image = new ControlImage {};
			SearchControlLayout.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
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
			AddSelectedRecordButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateRemoveSelectedRecordButton() {
			RemoveSelectedRecordButton.AjaxEvents.Click.IsProcessEventHandler = true;
			RemoveSelectedRecordButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ImageHash = @"012f06e2ee1dc8d32d3959105560eacd"
			};
			RemoveSelectedRecordButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateSelectedRecordButtonsControlLayout() {
			SelectedRecordButtonsControlLayout.Image = new ControlImage {};
			SelectedRecordButtonsControlLayout.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateSelectedRecordsGridContolLayout() {
			SelectedRecordsGridContolLayout.Image = new ControlImage {};
			SelectedRecordsGridContolLayout.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateSelectedRowsControlLayout() {
			SelectedRowsControlLayout.Image = new ControlImage {};
			SelectedRowsControlLayout.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateCommonControlLayout() {
			CommonControlLayout.Image = new ControlImage {};
			CommonControlLayout.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		private void UpdateActionButtonsControlLayout() {
			ActionButtonsControlLayout.Image = new ControlImage {};
			ActionButtonsControlLayout.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
			RealUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
			Name = "CalendarsGridPage";
			ParentSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCalendarsGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateCalendarsGridPageEventsProcessSchema() {
			var schema = new CalendarsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.EnableServerActiveRow = true;
			DataSource.SchemaUId = new Guid("3788dc9f-10e3-41a1-ac1b-bccc768afb64");
			DataSource.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("c2e428a9-32aa-43d4-b471-3edacec6f0bf");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("2a1f8b38-17ed-45c9-b61e-73e4522bc6bb");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("4fc6db5d-18bd-418f-81fa-0839c2a860d9");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("27e9e220-14e2-4bef-af0e-b33b4db5461e");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("26cd2b31-21d9-45fd-bf39-2dc3b979d233");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("287f06c1-a3fa-4fcb-89f2-d765d862bf0f");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("799461de-9f9b-4eea-95a4-f8f3ed449efb");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("527b9e4e-7dbf-4721-a112-72b423b3365a");
			if (column != null) {
				column.UId = new Guid("a75f4f09-e895-479d-a78c-f177d869e865");
				column.Name = @"Parent";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("7843485d-0000-429d-a602-70c3a3c54def");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b642ae94-288a-475c-8585-1e13a73beb4b");
			if (column != null) {
				column.UId = new Guid("a62af2cd-d5f5-417f-93c9-823fe82b3665");
				column.Name = @"TimeZone";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("81f7790d-dfee-4027-9a78-5025f58448b5");
			if (column != null) {
				column.UId = new Guid("29f4f7ec-95b7-41b3-ba89-5a0a8192c088");
				column.Name = @"Depth";
				column.CreatedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
				column.ModifiedInSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
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
			return new CalendarsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new CalendarsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CalendarsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CalendarsGridPageEventsProcess

	/// <exclude/>
	public class CalendarsGridPageEventsProcess<TPage> : Terrasoft.WebApp.LookupGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CalendarsGridPageSchemaUserControl
	{

		public CalendarsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CalendarsGridPageEventsProcess";
			SchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943");
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

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("f6f642a4-4f27-40a8-95cc-2afd7eae91bc"),
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
					SchemaElementUId = new Guid("8c944cff-2a59-4847-98e0-c02d9500c43d"),
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
					SchemaElementUId = new Guid("8a864452-b803-441b-b785-682affbdc57f"),
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
					SchemaElementUId = new Guid("3b910656-6ff2-499c-bfaf-c11df25e2cb5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitStartMessage");
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
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
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

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			Page.DataSource.EnableServerActiveRow = true;
			return true;
		}

		public override void GetDefValues() {
			base.GetDefValues();
			var activeRow = Page.DataSource.ActiveRow;
			if (activeRow == null) {
				return;
			}
			
			if (DefValuesId == Guid.Empty) {
				DefValuesId = Guid.NewGuid();
				Page.UserConnection.SessionData[DefValuesId.ToString()] = new Dictionary <string, object>();
			}
			
			var defaultValues = (Dictionary<string, object>)Page.UserConnection.SessionData[DefValuesId.ToString()];
			defaultValues.Remove("Parent");
			defaultValues.Add("Parent", activeRow.PrimaryColumnValue);
			defaultValues.Remove("TimeZone");
			defaultValues.Add("TimeZone", activeRow.GetTypedColumnValue<Guid>("TimeZoneId"));
			Page.UserConnection.SessionData[DefValuesId.ToString()] = defaultValues;
		}

		public override void ActivateButtons(bool activate) {
			base.ActivateButtons(activate);
			
			var activeRow = Page.DataSource.ActiveRow;
			if (activeRow != null) {
				var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Calendar");
				esq.AddColumn("Parent");
				var calendar = esq.GetEntity(UserConnection, activeRow.PrimaryColumnValue);
				Page.DeleteButton.Enabled = Page.DeleteButton.Enabled && calendar.GetColumnValue("ParentId") != null;
			}
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
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
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: CalendarsGridPageEventsProcess

	/// <exclude/>
	public class CalendarsGridPageEventsProcess : CalendarsGridPageEventsProcess<Terrasoft.WebApp.CalendarsGridPageSchemaUserControl>
	{

		public CalendarsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CalendarsGridPageSchemaUserControl

	/// <exclude/>
	public partial class CalendarsGridPageSchemaUserControl : Terrasoft.WebApp.LookupGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (CalendarsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CalendarsGridPageEventsProcess(UserConnection);
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

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
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
			SchemaName = "CalendarsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: CalendarsGridPageEventsProcessSchema

	/// <exclude/>
	public class CalendarsGridPageEventsProcessSchema : Terrasoft.WebApp.LookupGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public CalendarsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CalendarsGridPageEventsProcessSchema(CalendarsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CalendarsGridPageEventsProcess";
			UId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(initstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(initintermediatethrowmessageevent);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(initscripttask);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("ef8597a2-0b76-434d-90df-4e493865b712"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				CurveCenterPosition = new Point(170, 105),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8c944cff-2a59-4847-98e0-c02d9500c43d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8a864452-b803-441b-b785-682affbdc57f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("b8f502a9-45a0-4713-a0be-28cea097337a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				CurveCenterPosition = new Point(312, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8a864452-b803-441b-b785-682affbdc57f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b910656-6ff2-499c-bfaf-c11df25e2cb5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("dda5dc9d-f24c-49c6-aba3-3f4f33f2cc16"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1176, 186),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("4e037386-dda5-49d3-8cf1-09c8b1635b65"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("dda5dc9d-f24c-49c6-aba3-3f4f33f2cc16"),
				CreatedInOwnerSchemaUId = new Guid("e2ab7141-a916-4a2b-89fb-f95dbdd8e943"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1147, 186),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f6f642a4-4f27-40a8-95cc-2afd7eae91bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4e037386-dda5-49d3-8cf1-09c8b1635b65"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(389, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8c944cff-2a59-4847-98e0-c02d9500c43d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6f642a4-4f27-40a8-95cc-2afd7eae91bc"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("8a864452-b803-441b-b785-682affbdc57f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6f642a4-4f27-40a8-95cc-2afd7eae91bc"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
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
				UId = new Guid("3b910656-6ff2-499c-bfaf-c11df25e2cb5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6f642a4-4f27-40a8-95cc-2afd7eae91bc"),
				CreatedInOwnerSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				CreatedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(288, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,205,75,76,202,73,13,78,45,42,75,45,114,76,46,201,44,75,13,202,47,87,176,85,40,41,42,77,181,230,229,42,74,45,41,45,202,131,240,0,204,224,101,21,59,0,0,0 }
			};
			
			return ScriptTask;
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
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dc00bb50-26d4-4608-809c-73585d9eebd9"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
		}

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,205,106,195,48,16,132,207,209,83,8,159,44,8,122,1,39,129,16,151,144,75,49,177,219,67,75,15,74,180,14,42,182,20,244,99,99,74,223,189,146,67,28,59,37,151,156,246,48,51,223,142,88,29,152,1,186,5,155,66,249,206,42,7,38,38,9,106,152,198,236,104,69,3,123,213,226,37,206,216,9,104,202,44,203,149,211,71,160,235,171,150,32,81,226,120,100,93,98,233,170,138,224,31,52,211,96,157,150,9,250,69,189,105,88,176,227,193,182,117,130,211,151,250,108,187,222,60,81,47,226,43,180,97,134,62,179,190,192,155,1,189,81,82,130,95,167,36,205,193,24,63,67,173,207,81,156,22,42,183,90,200,83,76,190,60,74,66,139,83,209,39,152,238,240,194,244,218,28,171,195,183,231,172,2,221,23,12,15,230,80,50,87,217,11,199,39,227,91,236,62,69,158,236,147,160,201,18,186,135,90,53,16,71,25,211,32,109,68,238,245,53,231,131,56,191,93,132,102,90,212,190,214,70,85,174,150,189,247,95,244,138,46,68,13,31,74,194,3,248,32,143,241,254,59,20,221,25,248,136,191,8,167,88,221,252,59,30,17,79,124,254,46,147,46,201,31,234,179,162,187,134,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,205,74,195,64,16,62,103,159,98,205,161,36,80,246,5,66,15,53,138,120,16,162,69,239,211,236,168,129,205,44,78,102,91,130,248,238,238,54,73,91,196,227,240,253,207,30,6,52,219,86,186,3,8,222,6,17,79,67,1,243,93,86,74,29,128,245,233,198,23,127,212,27,221,192,7,154,59,16,216,249,192,237,172,77,88,165,186,119,93,92,168,55,27,77,193,185,82,127,171,44,153,224,240,21,229,132,71,125,79,210,201,184,107,63,177,135,231,128,60,22,175,3,114,237,137,48,170,61,153,107,194,19,80,76,228,181,206,107,112,72,22,56,143,181,178,232,102,182,214,214,222,133,158,138,188,1,70,146,19,146,178,218,153,26,3,19,241,1,101,178,252,19,180,190,44,51,13,119,61,240,56,25,190,129,11,105,125,54,173,69,135,203,115,98,55,216,59,180,231,79,252,135,173,86,231,6,41,251,202,115,105,250,104,243,114,249,80,165,126,126,1,147,6,119,255,134,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CalendarsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8170d085-916c-45df-89bd-46f226b0d9fa"));
		}

		#endregion

	}

	#endregion

}

