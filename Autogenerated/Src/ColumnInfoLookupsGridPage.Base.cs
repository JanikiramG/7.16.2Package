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
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: ColumnInfoLookupsGridPageSchema

	/// <exclude/>
	public class ColumnInfoLookupsGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public ColumnInfoLookupsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ColumnInfoLookupsGridPageSchema(ColumnInfoLookupsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.Enabled = true;
			AddButton.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateDeleteButton() {
			DeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.FooterVisible = false;
			TreeGrid.ToolbarVisible = false;
			TreeGrid.QuickFilterVisible = false;
			TreeGrid.EnableDragDrop = false;
			TreeGrid.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
			RealUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
			Name = "ColumnInfoLookupsGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateColumnInfoLookupsGridPageEventsProcessSchema();
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
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateColumnInfoLookupsGridPageEventsProcessSchema() {
			var schema = new ColumnInfoLookupsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0");
			DataSource.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("e14375d9-2f2f-465e-a3ab-85a4a439fded");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("64d9a989-99a0-4b4b-a127-e3e023d00dd9");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("30e9f7c8-ac9e-4f69-a315-23186e4f7893");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("bc1631b1-8885-49a4-9644-a964f4c61db9");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("cbdb1d8c-c85d-49ca-9af4-6db6e4515332");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("e85afeff-e60e-4809-b636-aa8fade54d07");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("7597dc65-7a5e-4165-902d-20d5ce5849aa");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5d031a2d-53b8-4768-bead-6347cf929ec0");
			if (column != null) {
				column.UId = new Guid("8dee035a-4a68-4ae1-8271-729828034165");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c7227eee-1b80-4db9-9f3a-cfdaa562ae3d");
			if (column != null) {
				column.UId = new Guid("858d138a-f337-442c-8935-ddabc8fc16c8");
				column.Name = @"IsModule";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("356fed4d-7b90-41aa-9d61-2cfe1df9e9fc");
			if (column != null) {
				column.UId = new Guid("98207a56-4a27-4705-bc49-d4b91aabc8cf");
				column.Name = @"IsLookup";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("278b1727-05db-41b5-a80c-72fc962430ee");
			if (column != null) {
				column.UId = new Guid("c05b7713-cc36-4045-a185-bcb0527decd4");
				column.Name = @"AdministratedByRecords";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c449bd15-1392-4a02-b1d3-f3852c194ebf");
			if (column != null) {
				column.UId = new Guid("03c18c0d-eb57-481d-bcc0-80dc427908a1");
				column.Name = @"AdministratedByColumns";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b12eda60-9b6a-4295-a281-8bd1fd1c2d33");
			if (column != null) {
				column.UId = new Guid("5a086100-74a4-43a5-8b7a-3685670b2db1");
				column.Name = @"AdministratedByOperations";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b7a4479c-74c2-4491-bca8-a03c0c093458");
			if (column != null) {
				column.UId = new Guid("a0d3920f-a879-4583-a58d-c959f9d119f5");
				column.Name = @"SysWorkspace";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b076dce7-a486-4584-a06e-567972ab10c8");
			if (column != null) {
				column.UId = new Guid("5a15a328-1619-4aa8-ae23-08fdf6b2f717");
				column.Name = @"IsTrackChangesInDB";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("54f46144-c8f1-4247-be7f-9193eda1b2d9");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
				column.ModifiedInSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
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
			return new ColumnInfoLookupsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new ColumnInfoLookupsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ColumnInfoLookupsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ColumnInfoLookupsGridPageEventsProcess

	/// <exclude/>
	public class ColumnInfoLookupsGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ColumnInfoLookupsGridPageSchemaUserControl
	{

		#region Class: OpenLookupUserTaskChildFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskChildFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskChildFlowElement(UserConnection userConnection, ColumnInfoLookupsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTaskChild";
				IsLogging = false;
				SchemaElementUId = new Guid("612e3e3f-6f15-4936-ac1b-f70b82100fda");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public ColumnInfoLookupsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ColumnInfoLookupsGridPageEventsProcess";
			SchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099");
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

		private string _virtualDataSourceID;
		public virtual string VirtualDataSourceID {
			get {
				return _virtualDataSourceID ?? (_virtualDataSourceID = new LocalizableString(Storage, "d5c8dcdb13c14c62affeecc75522d099",
						 "EventsProcessSchema.Parameters.VirtualDataSourceID.Value"));
			}
			set {
				_virtualDataSourceID = value;
			}
		}

		public virtual Object EntitySchemaList {
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
					SchemaElementUId = new Guid("6e0f3ec0-ebe0-467e-b1b2-e0724544b9af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initChild;
		public ProcessFlowElement InitChild {
			get {
				return _initChild ?? (_initChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitChild",
					SchemaElementUId = new Guid("b7b621d7-b133-4c2f-b6e1-8d30c2142259"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwInitParent;
		public ProcessThrowMessageEvent ThrowInitParent {
			get {
				return _throwInitParent ?? (_throwInitParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowInitParent",
					SchemaElementUId = new Guid("299c4356-c22c-45ee-a48a-b9f159879941"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptInitChild;
		public ProcessScriptTask ScriptInitChild {
			get {
				return _scriptInitChild ?? (_scriptInitChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInitChild",
					SchemaElementUId = new Guid("2904b739-cba4-4991-886c-b5d6e7531497"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitChildExecute,
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
					SchemaElementUId = new Guid("0e12ff5b-8830-4314-82ec-a620c8106bc8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteButtonClickChild;
		public ProcessFlowElement DeleteButtonClickChild {
			get {
				return _deleteButtonClickChild ?? (_deleteButtonClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteButtonClickChild",
					SchemaElementUId = new Guid("c4b1c6df-6a87-4339-b1de-df5a5980e6d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDeleteButtonClickChild;
		public ProcessScriptTask ScriptDeleteButtonClickChild {
			get {
				return _scriptDeleteButtonClickChild ?? (_scriptDeleteButtonClickChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDeleteButtonClickChild",
					SchemaElementUId = new Guid("315bbf05-84a6-4e0c-b95b-edc9f573f248"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteButtonClickChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageCallChangeReferenceLookup2;
		public ProcessThrowMessageEvent IntermediateThrowMessageCallChangeReferenceLookup2 {
			get {
				return _intermediateThrowMessageCallChangeReferenceLookup2 ?? (_intermediateThrowMessageCallChangeReferenceLookup2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageCallChangeReferenceLookup2",
					SchemaElementUId = new Guid("06d3d36c-81f0-41cb-a4b5-9d5ed998a313"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeReferenceLookup",
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
					SchemaElementUId = new Guid("6c8a9054-449c-4c7e-ab4a-bc6d8918f42b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _openVwSysSchemaInSolutionChild;
		public ProcessFlowElement OpenVwSysSchemaInSolutionChild {
			get {
				return _openVwSysSchemaInSolutionChild ?? (_openVwSysSchemaInSolutionChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpenVwSysSchemaInSolutionChild",
					SchemaElementUId = new Guid("eb90796d-7b2e-4f6c-935f-a91fa4bb3402"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initOpenLookupUserTaskScriptChild;
		public ProcessScriptTask InitOpenLookupUserTaskScriptChild {
			get {
				return _initOpenLookupUserTaskScriptChild ?? (_initOpenLookupUserTaskScriptChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitOpenLookupUserTaskScriptChild",
					SchemaElementUId = new Guid("d1c43fea-8148-4d53-a5e5-4a9dc1ea7073"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitOpenLookupUserTaskScriptChildExecute,
				});
			}
		}

		private OpenLookupUserTaskChildFlowElement _openLookupUserTaskChild;
		public OpenLookupUserTaskChildFlowElement OpenLookupUserTaskChild {
			get {
				return _openLookupUserTaskChild ?? (_openLookupUserTaskChild = new OpenLookupUserTaskChildFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _lookupGridPageClosedChild;
		public ProcessIntermediateCatchMessageEvent LookupGridPageClosedChild {
			get {
				return _lookupGridPageClosedChild ?? (_lookupGridPageClosedChild = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "LookupGridPageClosedChild",
					SchemaElementUId = new Guid("5a95cf66-18fb-4b0e-8d03-4294a314f949"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _applyDataScriptChild;
		public ProcessScriptTask ApplyDataScriptChild {
			get {
				return _applyDataScriptChild ?? (_applyDataScriptChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ApplyDataScriptChild",
					SchemaElementUId = new Guid("86e9c094-7e8f-47f3-8b3b-2c4963b1f5cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ApplyDataScriptChildExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageChangeReferenceLookup;
		public ProcessThrowMessageEvent IntermediateThrowMessageChangeReferenceLookup {
			get {
				return _intermediateThrowMessageChangeReferenceLookup ?? (_intermediateThrowMessageChangeReferenceLookup = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageChangeReferenceLookup",
					SchemaElementUId = new Guid("297d80f1-0418-4626-983d-74d390882fc1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeReferenceLookup",
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeReferenceLookup;
		public ProcessFlowElement EventSubProcessChangeReferenceLookup {
			get {
				return _eventSubProcessChangeReferenceLookup ?? (_eventSubProcessChangeReferenceLookup = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeReferenceLookup",
					SchemaElementUId = new Guid("ecc57d6f-9aea-49df-a42f-e3b251ac7c9f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChangeReferenceLookup;
		public ProcessFlowElement StartMessageChangeReferenceLookup {
			get {
				return _startMessageChangeReferenceLookup ?? (_startMessageChangeReferenceLookup = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChangeReferenceLookup",
					SchemaElementUId = new Guid("45e2b6bc-a18b-47ae-ae56-89934c3765c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChangeReferenceLookup;
		public ProcessScriptTask ScriptChangeReferenceLookup {
			get {
				return _scriptChangeReferenceLookup ?? (_scriptChangeReferenceLookup = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChangeReferenceLookup",
					SchemaElementUId = new Guid("d961222c-aad8-441c-9fee-df41ccb04030"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChangeReferenceLookupExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessClearItems;
		public ProcessFlowElement EventSubProcessClearItems {
			get {
				return _eventSubProcessClearItems ?? (_eventSubProcessClearItems = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessClearItems",
					SchemaElementUId = new Guid("56f111ad-2d0a-49e1-af2c-8c2e36540581"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageClearItems;
		public ProcessFlowElement StartMessageClearItems {
			get {
				return _startMessageClearItems ?? (_startMessageClearItems = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageClearItems",
					SchemaElementUId = new Guid("1fc6f069-3e91-4ed3-ace5-520d00cd8258"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptClearAllItems;
		public ProcessScriptTask ScriptClearAllItems {
			get {
				return _scriptClearAllItems ?? (_scriptClearAllItems = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptClearAllItems",
					SchemaElementUId = new Guid("b3fd4e0a-b411-45fb-b5df-ca46316eb949"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptClearAllItemsExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessInitializeLookupList;
		public ProcessFlowElement EventSubProcessInitializeLookupList {
			get {
				return _eventSubProcessInitializeLookupList ?? (_eventSubProcessInitializeLookupList = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInitializeLookupList",
					SchemaElementUId = new Guid("64312632-1d0a-40f5-a625-4a585b125c60"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageInitializeLookupList;
		public ProcessFlowElement StartMessageInitializeLookupList {
			get {
				return _startMessageInitializeLookupList ?? (_startMessageInitializeLookupList = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageInitializeLookupList",
					SchemaElementUId = new Guid("be305c98-94b2-4496-951c-f61cb57776f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInitializeLookupList;
		public ProcessScriptTask ScriptInitializeLookupList {
			get {
				return _scriptInitializeLookupList ?? (_scriptInitializeLookupList = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInitializeLookupList",
					SchemaElementUId = new Guid("7dc38756-d41e-4f4e-b77c-64190e5b19d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitializeLookupListExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[InitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { InitChild };
			FlowElements[ThrowInitParent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowInitParent };
			FlowElements[ScriptInitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInitChild };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[DeleteButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickChild };
			FlowElements[ScriptDeleteButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteButtonClickChild };
			FlowElements[IntermediateThrowMessageCallChangeReferenceLookup2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageCallChangeReferenceLookup2 };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[OpenVwSysSchemaInSolutionChild.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenVwSysSchemaInSolutionChild };
			FlowElements[InitOpenLookupUserTaskScriptChild.SchemaElementUId] = new Collection<ProcessFlowElement> { InitOpenLookupUserTaskScriptChild };
			FlowElements[OpenLookupUserTaskChild.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTaskChild };
			FlowElements[LookupGridPageClosedChild.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosedChild };
			FlowElements[ApplyDataScriptChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ApplyDataScriptChild };
			FlowElements[IntermediateThrowMessageChangeReferenceLookup.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageChangeReferenceLookup };
			FlowElements[EventSubProcessChangeReferenceLookup.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeReferenceLookup };
			FlowElements[StartMessageChangeReferenceLookup.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChangeReferenceLookup };
			FlowElements[ScriptChangeReferenceLookup.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChangeReferenceLookup };
			FlowElements[EventSubProcessClearItems.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessClearItems };
			FlowElements[StartMessageClearItems.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageClearItems };
			FlowElements[ScriptClearAllItems.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptClearAllItems };
			FlowElements[EventSubProcessInitializeLookupList.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInitializeLookupList };
			FlowElements[StartMessageInitializeLookupList.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInitializeLookupList };
			FlowElements[ScriptInitializeLookupList.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInitializeLookupList };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess10":
						break;
					case "InitChild":
						e.Context.QueueTasks.Enqueue("ThrowInitParent");
						break;
					case "ThrowInitParent":
						e.Context.QueueTasks.Enqueue("ScriptInitChild");
						break;
					case "ScriptInitChild":
						break;
					case "EventSubProcess11":
						break;
					case "DeleteButtonClickChild":
						e.Context.QueueTasks.Enqueue("ScriptDeleteButtonClickChild");
						break;
					case "ScriptDeleteButtonClickChild":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageCallChangeReferenceLookup2");
						break;
					case "IntermediateThrowMessageCallChangeReferenceLookup2":
						break;
					case "EventSubProcess12":
						break;
					case "OpenVwSysSchemaInSolutionChild":
						e.Context.QueueTasks.Enqueue("InitOpenLookupUserTaskScriptChild");
						break;
					case "InitOpenLookupUserTaskScriptChild":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTaskChild");
						break;
					case "OpenLookupUserTaskChild":
						ActivatedEventElements.Add("LookupGridPageClosedChild");
						break;
					case "LookupGridPageClosedChild":
						e.Context.QueueTasks.Enqueue("ApplyDataScriptChild");
						break;
					case "ApplyDataScriptChild":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageChangeReferenceLookup");
						break;
					case "IntermediateThrowMessageChangeReferenceLookup":
						break;
					case "EventSubProcessChangeReferenceLookup":
						break;
					case "StartMessageChangeReferenceLookup":
						e.Context.QueueTasks.Enqueue("ScriptChangeReferenceLookup");
						break;
					case "ScriptChangeReferenceLookup":
						break;
					case "EventSubProcessClearItems":
						break;
					case "StartMessageClearItems":
						e.Context.QueueTasks.Enqueue("ScriptClearAllItems");
						break;
					case "ScriptClearAllItems":
						break;
					case "EventSubProcessInitializeLookupList":
						break;
					case "StartMessageInitializeLookupList":
						e.Context.QueueTasks.Enqueue("ScriptInitializeLookupList");
						break;
					case "ScriptInitializeLookupList":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitChild");
			ActivatedEventElements.Add("DeleteButtonClickChild");
			ActivatedEventElements.Add("OpenVwSysSchemaInSolutionChild");
			ActivatedEventElements.Add("StartMessageChangeReferenceLookup");
			ActivatedEventElements.Add("StartMessageClearItems");
			ActivatedEventElements.Add("StartMessageInitializeLookupList");
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
				case "InitChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitChild";
					result = InitChild.Execute(context);
					break;
				case "ThrowInitParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ThrowInitParent.Execute(context);
					break;
				case "ScriptInitChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInitChild";
					result = ScriptInitChild.Execute(context, ScriptInitChildExecute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickChild";
					result = DeleteButtonClickChild.Execute(context);
					break;
				case "ScriptDeleteButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDeleteButtonClickChild";
					result = ScriptDeleteButtonClickChild.Execute(context, ScriptDeleteButtonClickChildExecute);
					break;
				case "IntermediateThrowMessageCallChangeReferenceLookup2":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageCallChangeReferenceLookup2.Execute(context);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "OpenVwSysSchemaInSolutionChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenVwSysSchemaInSolutionChild";
					result = OpenVwSysSchemaInSolutionChild.Execute(context);
					break;
				case "InitOpenLookupUserTaskScriptChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitOpenLookupUserTaskScriptChild";
					result = InitOpenLookupUserTaskScriptChild.Execute(context, InitOpenLookupUserTaskScriptChildExecute);
					break;
				case "OpenLookupUserTaskChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTaskChild";
					result = OpenLookupUserTaskChild.Execute(context);
					break;
				case "LookupGridPageClosedChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupGridPageClosedChild";
					result = LookupGridPageClosedChild.Execute(context);
					break;
				case "ApplyDataScriptChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ApplyDataScriptChild";
					result = ApplyDataScriptChild.Execute(context, ApplyDataScriptChildExecute);
					break;
				case "IntermediateThrowMessageChangeReferenceLookup":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageChangeReferenceLookup.Execute(context);
					break;
				case "EventSubProcessChangeReferenceLookup":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChangeReferenceLookup":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChangeReferenceLookup";
					result = StartMessageChangeReferenceLookup.Execute(context);
					break;
				case "ScriptChangeReferenceLookup":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChangeReferenceLookup";
					result = ScriptChangeReferenceLookup.Execute(context, ScriptChangeReferenceLookupExecute);
					break;
				case "EventSubProcessClearItems":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageClearItems":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageClearItems";
					result = StartMessageClearItems.Execute(context);
					break;
				case "ScriptClearAllItems":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptClearAllItems";
					result = ScriptClearAllItems.Execute(context, ScriptClearAllItemsExecute);
					break;
				case "EventSubProcessInitializeLookupList":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageInitializeLookupList":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageInitializeLookupList";
					result = StartMessageInitializeLookupList.Execute(context);
					break;
				case "ScriptInitializeLookupList":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInitializeLookupList";
					result = ScriptInitializeLookupList.Execute(context, ScriptInitializeLookupListExecute);
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
				case "EntitySchemaList":
					EntitySchemaList = reader.GetSerializableObjectValue();
				break;
				case "VirtualDataSourceID":
					VirtualDataSourceID = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptInitChildExecute(ProcessExecutingContext context) {
			var virtualDataSource = new VirtualDataSource() {
				ID = VirtualDataSourceID
			};
			Page.AddButton.AjaxEvents.Click.SignalName = "OpenVwSysSchemaInSolution";
			Page.PageContainer.Controls.Add(virtualDataSource);
			var dataSource = Page.DataSource;
			var schema = dataSource.Schema;
			Page.TreeGrid.DataSourceId = virtualDataSource.ID; 
			DataSourceStructure defStructure = virtualDataSource.DefStructure;
			defStructure.Columns.Clear();
			defStructure.PrimaryColumnName = schema.PrimaryColumn.Name;
			if (schema.PrimaryDisplayColumn != null) {
				defStructure.PrimaryDisplayColumnName = schema.PrimaryDisplayColumn.Name;
			}
			var dataValueTypeManager = (DataValueTypeManager)
				Page.UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
			CreateVirtualDataSourceStructure(dataValueTypeManager, defStructure);
			virtualDataSource.LoadRows();
			return true;
		}

		public virtual bool ScriptDeleteButtonClickChildExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count == 1) {
				var primaryRecordValue = selectedNodes[0].Values[Page.DataSource.Schema.PrimaryColumn.Name].ToString();
				var virtualDataSource = GetVirtualDataSource();
				virtualDataSource.Remove(new Guid(primaryRecordValue));
				(EntitySchemaList as List<string>).Remove(primaryRecordValue);
				virtualDataSource.LoadRows();
				Page.DeleteButton.Enabled = ((EntitySchemaList as List<string>).Count > 0);
			}
			return true;
		}

		public virtual bool InitOpenLookupUserTaskScriptChildExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupUserTaskChild.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			//Код, который компилируется только в Workspace CR173850 VwSysSchemaInWorkspace "4FE60977-C711-48B2-8499-1CEBBECF7868"
			string schemaUId = "4FE60977-C711-48B2-8499-1CEBBECF7868";
			OpenLookupUserTaskChild.UserConnection = UserConnection;
			OpenLookupUserTaskChild.PageParameters = new Dictionary <string, object>();
			var pageParameters = (Dictionary <string, object>) OpenLookupUserTaskChild.PageParameters;
			pageParameters.Add("schemaUId", schemaUId);
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			//CR#172869
			filters.Add(new Dictionary<string, object> { 
					 {"comparisonType", FilterComparisonType.Equal},
					 {"leftExpressionColumnPath", "SysWorkspace"},
					 {"useDisplayValue", false }, 
					 {"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}});
			filters.Add(new Dictionary<string, object> { 
					 {"comparisonType", FilterComparisonType.Equal},
					 {"leftExpressionColumnPath", "ManagerName"},
					 {"useDisplayValue", false }, 
					 {"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}});
			
			pageParameters.Add("LookupFilters", filters);
			return true;
		}

		public virtual bool ApplyDataScriptChildExecute(ProcessExecutingContext context) {
			if (EntitySchemaList == null) {
				EntitySchemaList = new List<string>();
			}
			var values = (Dictionary <string, object>)OpenLookupUserTaskChild.GetSelectedValues(UserConnection);
			if (values == null) {
				return true;
			}
			var dataSource = GetVirtualDataSource();
			Entity newRow;
			Guid id;
			var manager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			foreach (var name in values) {
				id = Guid.NewGuid();
				newRow = dataSource.CreateRow();
				newRow.SetColumnValue("Name", (name.Value as Dictionary<string, object>)["Caption"]);
				newRow.SetColumnValue("Id", id);
				dataSource.Add(newRow);	
				var entitySchemaQuery = new EntitySchemaQuery(manager, "VwSysSchemaInWorkspace");
				var schemaIdColumnName = entitySchemaQuery.AddColumn("UId").Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, entitySchemaQuery.RootSchema.GetPrimaryColumnName(), name.Key));
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace", UserConnection.Workspace.Id));	
				var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entities.Count > 0) {
					(EntitySchemaList as List<string>).Add(entities[0].GetColumnValue(schemaIdColumnName).ToString());
				}
			}
			dataSource.LoadRows();
			Page.DeleteButton.Enabled = true;
			return true;
		}

		public virtual bool ScriptChangeReferenceLookupExecute(ProcessExecutingContext context) {
			ListenerThrowEvent(ListenerPageProcessUId, "ColumnInfoLookupsChanged");
			return true;
		}

		public virtual bool ScriptClearAllItemsExecute(ProcessExecutingContext context) {
			ClearItems();
			return true;
		}

		public virtual bool ScriptInitializeLookupListExecute(ProcessExecutingContext context) {
			var entitySchemaList = EntitySchemaList as List<string>;
			if (entitySchemaList == null) {
				return true;
			}
			if (entitySchemaList.Count == 0) {
				return true;
			}
			var values = new Dictionary <string, object>();
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			foreach (var entitySchemaId in entitySchemaList) {
				//CR#172715	
				values[entitySchemaId] = UserConnection.EntitySchemaManager.GetItemByUId(new Guid(entitySchemaId));	
			}
			var dataSource = GetVirtualDataSource();
			Entity newRow;
			Guid id;
			var manager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			foreach (var name in values) {
				id = Guid.NewGuid();
				newRow = dataSource.CreateRow();
				newRow.SetColumnValue("Name", name.Value.ToString());
				newRow.SetColumnValue("Id", id);
				dataSource.Add(newRow);
			}
			dataSource.LoadRows();
			Page.DeleteButton.Enabled = true;
			return true;
		}

		public virtual void CreateVirtualDataSourceStructure(DataValueTypeManager dataValueTypeManager, DataSourceStructure defStructure) {
			var dataSource = Page.DataSource;
			var schema = dataSource.Schema;
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var column = new DataSourceStructureColumn {
					Name = "Id",
					ValueColumnName = "Id",
					DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
					Caption = "Id",
					IsVisible = false,
					IsSortable = false
				};
				defStructure.AddColumn(column);
				column = new DataSourceStructureColumn {
					Name = "Name",
					ValueColumnName = "Name",
					DisplayColumnName = "Name",
					DataValueType = dataValueTypeManager.GetInstanceByName("MediumText"),
					Caption = schema.Columns.GetByName("Name").Caption,
					IsVisible = true,
					IsSortable = true
				};
				defStructure.AddColumn(column);
		}

		public virtual VirtualDataSource GetVirtualDataSource() {
			return Page.PageContainer.FindPageControl(VirtualDataSourceID) as VirtualDataSource;
		}

		public virtual void ClearItems() {
			var virtualDataSource = GetVirtualDataSource();
			var entitySchemaList = EntitySchemaList as List<string>;
			if (entitySchemaList != null) {
				foreach (var schemaId in entitySchemaList) {
					virtualDataSource.Remove(new Guid(schemaId));
				}
				entitySchemaList.Clear();
			}
			Page.TreeGrid.RefreshData();
			//virtualDataSource.LoadRows();
		}

		public override string GetRegisterQuestionScript() {
			return string.Empty;
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitChild")) {
							context.QueueTasks.Enqueue("InitChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteButtonClickChild")) {
							context.QueueTasks.Enqueue("DeleteButtonClickChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "OpenVwSysSchemaInSolution":
							if (ActivatedEventElements.Contains("OpenVwSysSchemaInSolutionChild")) {
							context.QueueTasks.Enqueue("OpenVwSysSchemaInSolutionChild");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("LookupGridPageClosedChild")) {
						context.QueueTasks.Enqueue("LookupGridPageClosedChild");
					}
					break;
					case "ChangeReferenceLookup":
							if (ActivatedEventElements.Contains("StartMessageChangeReferenceLookup")) {
							context.QueueTasks.Enqueue("StartMessageChangeReferenceLookup");
						}
						break;
					case "ClearAllItems":
							if (ActivatedEventElements.Contains("StartMessageClearItems")) {
							context.QueueTasks.Enqueue("StartMessageClearItems");
						}
						break;
					case "InitializeLookupList":
							if (ActivatedEventElements.Contains("StartMessageInitializeLookupList")) {
							context.QueueTasks.Enqueue("StartMessageInitializeLookupList");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (EntitySchemaList != null) {
				if (EntitySchemaList.GetType().IsSerializable ||
					EntitySchemaList.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("EntitySchemaList", EntitySchemaList, null);
				}
			}
			if (!HasMapping("VirtualDataSourceID") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("VirtualDataSourceID", VirtualDataSourceID, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ColumnInfoLookupsGridPageEventsProcess

	/// <exclude/>
	public class ColumnInfoLookupsGridPageEventsProcess : ColumnInfoLookupsGridPageEventsProcess<Terrasoft.WebApp.ColumnInfoLookupsGridPageSchemaUserControl>
	{

		public ColumnInfoLookupsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ColumnInfoLookupsGridPageSchemaUserControl

	/// <exclude/>
	public partial class ColumnInfoLookupsGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ColumnInfoLookupsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ColumnInfoLookupsGridPageEventsProcess(UserConnection);
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

		public virtual void DeleteButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteButtonClick");
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
			SchemaName = "ColumnInfoLookupsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: ColumnInfoLookupsGridPageEventsProcessSchema

	/// <exclude/>
	public class ColumnInfoLookupsGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public ColumnInfoLookupsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ColumnInfoLookupsGridPageEventsProcessSchema(ColumnInfoLookupsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ColumnInfoLookupsGridPageEventsProcess";
			UId = new Guid("4286b499-1575-4734-acb2-8000647e5473");
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

		protected virtual ProcessSchemaParameter CreateVirtualDataSourceIDParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("775af377-bba0-40a3-86e7-6df6a74fcafe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"VirtualDataSourceID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8bd00795-88da-4c49-b32d-8b1c1b450f5d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"EntitySchemaList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateVirtualDataSourceIDParameter());
			Parameters.Add(CreateEntitySchemaListParameter());
		}

		protected virtual void InitializeOpenLookupUserTaskChildParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("09ea8752-46bb-47bc-ab55-5b35e6d65cc1"),
				ContainerUId = new Guid("612e3e3f-6f15-4936-ac1b-f70b82100fda"),
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
				UId = new Guid("55cde16a-133f-404e-86a2-a5c492d00819"),
				ContainerUId = new Guid("612e3e3f-6f15-4936-ac1b-f70b82100fda"),
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
				UId = new Guid("6071be65-1330-4980-b3db-9d477ed9ae8a"),
				ContainerUId = new Guid("612e3e3f-6f15-4936-ac1b-f70b82100fda"),
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
				UId = new Guid("ce51b5b0-4eae-4e5d-93d9-d7ed9e1cb794"),
				ContainerUId = new Guid("612e3e3f-6f15-4936-ac1b-f70b82100fda"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet573 = CreateLaneSet573LaneSet();
			LaneSets.Add(schemaLaneSet573);
			ProcessSchemaLane schemaLane2012 = CreateLane2012Lane();
			schemaLaneSet573.Lanes.Add(schemaLane2012);
			ProcessSchemaLane schemaLane2013 = CreateLane2013Lane();
			schemaLaneSet573.Lanes.Add(schemaLane2013);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocesschangereferencelookup = CreateEventSubProcessChangeReferenceLookupEventSubProcess();
			FlowElements.Add(eventsubprocesschangereferencelookup);
			ProcessSchemaEventSubProcess eventsubprocessclearitems = CreateEventSubProcessClearItemsEventSubProcess();
			FlowElements.Add(eventsubprocessclearitems);
			ProcessSchemaEventSubProcess eventsubprocessinitializelookuplist = CreateEventSubProcessInitializeLookupListEventSubProcess();
			FlowElements.Add(eventsubprocessinitializelookuplist);
			ProcessSchemaStartMessageEvent initchild = CreateInitChildStartMessageEvent();
			eventsubprocess10.FlowElements.Add(initchild);
			ProcessSchemaIntermediateThrowMessageEvent throwinitparent = CreateThrowInitParentIntermediateThrowMessageEvent();
			eventsubprocess10.FlowElements.Add(throwinitparent);
			ProcessSchemaScriptTask scriptinitchild = CreateScriptInitChildScriptTask();
			eventsubprocess10.FlowElements.Add(scriptinitchild);
			ProcessSchemaStartMessageEvent deletebuttonclickchild = CreateDeleteButtonClickChildStartMessageEvent();
			eventsubprocess11.FlowElements.Add(deletebuttonclickchild);
			ProcessSchemaScriptTask scriptdeletebuttonclickchild = CreateScriptDeleteButtonClickChildScriptTask();
			eventsubprocess11.FlowElements.Add(scriptdeletebuttonclickchild);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessagecallchangereferencelookup2 = CreateIntermediateThrowMessageCallChangeReferenceLookup2IntermediateThrowMessageEvent();
			eventsubprocess11.FlowElements.Add(intermediatethrowmessagecallchangereferencelookup2);
			ProcessSchemaStartMessageEvent openvwsysschemainsolutionchild = CreateOpenVwSysSchemaInSolutionChildStartMessageEvent();
			eventsubprocess12.FlowElements.Add(openvwsysschemainsolutionchild);
			ProcessSchemaScriptTask initopenlookupusertaskscriptchild = CreateInitOpenLookupUserTaskScriptChildScriptTask();
			eventsubprocess12.FlowElements.Add(initopenlookupusertaskscriptchild);
			ProcessSchemaUserTask openlookupusertaskchild = CreateOpenLookupUserTaskChildUserTask();
			eventsubprocess12.FlowElements.Add(openlookupusertaskchild);
			ProcessSchemaIntermediateCatchMessageEvent lookupgridpageclosedchild = CreateLookupGridPageClosedChildIntermediateCatchMessageEvent();
			eventsubprocess12.FlowElements.Add(lookupgridpageclosedchild);
			ProcessSchemaScriptTask applydatascriptchild = CreateApplyDataScriptChildScriptTask();
			eventsubprocess12.FlowElements.Add(applydatascriptchild);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessagechangereferencelookup = CreateIntermediateThrowMessageChangeReferenceLookupIntermediateThrowMessageEvent();
			eventsubprocess12.FlowElements.Add(intermediatethrowmessagechangereferencelookup);
			ProcessSchemaStartMessageEvent startmessagechangereferencelookup = CreateStartMessageChangeReferenceLookupStartMessageEvent();
			eventsubprocesschangereferencelookup.FlowElements.Add(startmessagechangereferencelookup);
			ProcessSchemaScriptTask scriptchangereferencelookup = CreateScriptChangeReferenceLookupScriptTask();
			eventsubprocesschangereferencelookup.FlowElements.Add(scriptchangereferencelookup);
			ProcessSchemaStartMessageEvent startmessageclearitems = CreateStartMessageClearItemsStartMessageEvent();
			eventsubprocessclearitems.FlowElements.Add(startmessageclearitems);
			ProcessSchemaScriptTask scriptclearallitems = CreateScriptClearAllItemsScriptTask();
			eventsubprocessclearitems.FlowElements.Add(scriptclearallitems);
			ProcessSchemaStartMessageEvent startmessageinitializelookuplist = CreateStartMessageInitializeLookupListStartMessageEvent();
			eventsubprocessinitializelookuplist.FlowElements.Add(startmessageinitializelookuplist);
			ProcessSchemaScriptTask scriptinitializelookuplist = CreateScriptInitializeLookupListScriptTask();
			eventsubprocessinitializelookuplist.FlowElements.Add(scriptinitializelookuplist);
			FlowElements.Add(CreateSequenceFlow12412SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12413SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12414SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12415SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12416SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12417SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12418SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12419SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12420SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12421SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12422SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12423SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12412SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12412",
				UId = new Guid("430dfe5c-80dd-4ff6-9542-9acdb5f3e16c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(136, 83),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b7b621d7-b133-4c2f-b6e1-8d30c2142259"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("299c4356-c22c-45ee-a48a-b9f159879941"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12413SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12413",
				UId = new Guid("e0fa57bd-9232-4d4f-963f-ed93937119f4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(231, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("299c4356-c22c-45ee-a48a-b9f159879941"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2904b739-cba4-4991-886c-b5d6e7531497"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12414SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12414",
				UId = new Guid("92029a4c-2be5-4d20-816a-7f369e8af8a5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(393, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c4b1c6df-6a87-4339-b1de-df5a5980e6d6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("315bbf05-84a6-4e0c-b95b-edc9f573f248"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12415SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12415",
				UId = new Guid("0838daf1-be32-46c6-8d39-c535d588a8a6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(142, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eb90796d-7b2e-4f6c-935f-a91fa4bb3402"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d1c43fea-8148-4d53-a5e5-4a9dc1ea7073"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12416SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12416",
				UId = new Guid("3b3a9091-72a9-4772-a008-0ac06a2ac975"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(254, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d1c43fea-8148-4d53-a5e5-4a9dc1ea7073"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("612e3e3f-6f15-4936-ac1b-f70b82100fda"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12417SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12417",
				UId = new Guid("afeb6d18-b40f-4ffd-a3a5-d37e4388faba"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(540, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5a95cf66-18fb-4b0e-8d03-4294a314f949"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("86e9c094-7e8f-47f3-8b3b-2c4963b1f5cd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12418SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12418",
				UId = new Guid("ac15e5dd-def5-46f2-8736-89eefdebfbd0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(404, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("612e3e3f-6f15-4936-ac1b-f70b82100fda"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5a95cf66-18fb-4b0e-8d03-4294a314f949"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12419SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12419",
				UId = new Guid("25fab5e8-9d27-4bda-a822-c475fa15a627"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(678, 244),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("45e2b6bc-a18b-47ae-ae56-89934c3765c9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d961222c-aad8-441c-9fee-df41ccb04030"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12420SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12420",
				UId = new Guid("2ab5154a-ab68-4fee-be79-c2195884c5a3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(534, 251),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("86e9c094-7e8f-47f3-8b3b-2c4963b1f5cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("297d80f1-0418-4626-983d-74d390882fc1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12421SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12421",
				UId = new Guid("2df96d8b-77ee-4530-aa0a-8fb82051547c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(515, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("315bbf05-84a6-4e0c-b95b-edc9f573f248"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("06d3d36c-81f0-41cb-a4b5-9d5ed998a313"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12422SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12422",
				UId = new Guid("6f563052-79ff-495b-9bdb-dd62e6dbf60f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(718, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1fc6f069-3e91-4ed3-ace5-520d00cd8258"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b3fd4e0a-b411-45fb-b5df-ca46316eb949"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12423SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12423",
				UId = new Guid("3230acc7-e975-45bf-9c21-168446303ee4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CurveCenterPosition = new Point(172, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("be305c98-94b2-4496-951c-f61cb57776f1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7dc38756-d41e-4f4e-b77c-64190e5b19d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet573LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet573 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("74a16e41-97c5-4be3-9c2f-0147e4e4d17d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"LaneSet573",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(889, 520),
				UseBackgroundMode = false
			};
			return schemaLaneSet573;
		}

		protected virtual ProcessSchemaLane CreateLane2012Lane() {
			ProcessSchemaLane schemaLane2012 = new ProcessSchemaLane(this) {
				UId = new Guid("d744f524-0228-44db-87e6-2e6b9f0b73ac"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("74a16e41-97c5-4be3-9c2f-0147e4e4d17d"),
				CreatedInOwnerSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"Lane2012",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 182),
				Size = new Size(860, 338),
				UseBackgroundMode = false
			};
			return schemaLane2012;
		}

		protected virtual ProcessSchemaLane CreateLane2013Lane() {
			ProcessSchemaLane schemaLane2013 = new ProcessSchemaLane(this) {
				UId = new Guid("a3b2b6c5-6106-40fa-9f36-14f94b363516"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("74a16e41-97c5-4be3-9c2f-0147e4e4d17d"),
				CreatedInOwnerSchemaUId = new Guid("d5c8dcdb-13c1-4c62-affe-ecc75522d099"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"Lane2013",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(860, 177),
				UseBackgroundMode = false
			};
			return schemaLane2013;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6e0f3ec0-ebe0-467e-b1b2-e0724544b9af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d744f524-0228-44db-87e6-2e6b9f0b73ac"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(234, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b7b621d7-b133-4c2f-b6e1-8d30c2142259"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e0f3ec0-ebe0-467e-b1b2-e0724544b9af"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"InitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowInitParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("299c4356-c22c-45ee-a48a-b9f159879941"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e0f3ec0-ebe0-467e-b1b2-e0724544b9af"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"ThrowInitParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2904b739-cba4-4991-886c-b5d6e7531497"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e0f3ec0-ebe0-467e-b1b2-e0724544b9af"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"ScriptInitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,146,77,110,131,48,16,133,215,225,20,46,43,34,85,190,0,234,34,13,85,132,212,159,168,164,217,143,96,146,186,53,54,26,108,210,168,202,221,107,3,42,33,176,65,216,239,179,159,103,222,52,64,172,17,100,44,200,4,12,100,218,82,142,236,129,41,60,177,253,237,126,180,100,191,193,34,77,156,62,209,210,36,184,196,193,22,142,200,87,69,241,104,141,209,138,175,190,224,231,169,65,101,106,190,150,34,255,230,153,56,42,144,175,80,122,143,240,173,66,181,63,101,231,58,203,63,177,132,84,101,90,90,35,180,10,251,155,252,103,173,149,1,161,144,184,255,35,45,107,111,16,77,30,189,140,131,198,21,83,92,87,209,94,50,32,29,81,183,102,78,29,80,222,61,160,119,221,17,226,134,68,113,117,50,45,28,63,177,228,105,18,179,96,88,103,134,108,110,44,33,43,240,48,44,230,78,38,87,64,28,92,227,174,76,105,75,229,59,134,64,209,242,70,221,146,40,129,206,29,212,55,178,171,104,44,113,175,197,129,56,176,104,44,39,162,174,36,244,20,187,115,81,91,41,219,96,231,124,70,244,172,221,136,232,93,47,255,81,236,65,90,220,157,43,124,1,229,122,75,238,120,148,204,236,47,131,69,219,251,143,26,201,229,172,48,247,115,192,87,85,213,3,91,210,141,40,220,20,108,208,244,91,81,56,119,83,232,58,182,38,4,131,147,25,253,175,46,154,123,218,253,40,53,63,78,147,212,158,53,20,239,250,84,251,84,8,29,166,152,227,49,254,3,42,47,170,22,70,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0e12ff5b-8830-4314-82ec-a620c8106bc8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d744f524-0228-44db-87e6-2e6b9f0b73ac"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(314, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteButtonClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c4b1c6df-6a87-4339-b1de-df5a5980e6d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e12ff5b-8830-4314-82ec-a620c8106bc8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"DeleteButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteButtonClickChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("315bbf05-84a6-4e0c-b95b-edc9f573f248"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e12ff5b-8830-4314-82ec-a620c8106bc8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"ScriptDeleteButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(91, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,49,111,194,64,12,133,231,230,87,120,76,150,19,157,83,24,74,81,22,132,80,130,88,16,131,155,51,244,164,228,174,242,249,130,80,213,255,222,35,167,170,133,50,116,178,100,235,125,239,217,30,144,193,83,71,173,144,94,57,77,30,166,176,198,35,169,13,19,85,108,180,106,126,79,203,204,28,32,191,18,168,185,11,86,96,58,133,199,2,62,178,135,33,18,223,217,244,200,231,154,90,199,122,139,93,160,136,189,82,237,38,123,53,14,252,110,180,123,65,193,198,5,110,73,53,237,27,245,168,214,137,49,119,93,232,173,90,97,79,123,181,113,141,176,177,199,188,40,147,209,96,88,2,118,63,234,232,83,145,108,111,219,73,112,219,85,53,245,110,160,220,210,9,170,96,116,254,55,119,113,17,230,11,43,70,206,41,216,210,120,1,244,112,169,79,126,140,51,43,190,73,119,0,119,141,151,14,117,237,78,126,204,149,14,16,175,35,244,28,68,156,85,11,139,175,29,233,184,76,254,15,239,244,128,25,76,34,236,51,99,146,192,22,132,3,149,95,6,187,182,107,222,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageCallChangeReferenceLookup2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("06d3d36c-81f0-41cb-a4b5-9d5ed998a313"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e12ff5b-8830-4314-82ec-a620c8106bc8"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeReferenceLookup",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"IntermediateThrowMessageCallChangeReferenceLookup2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6c8a9054-449c-4c7e-ab4a-bc6d8918f42b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d744f524-0228-44db-87e6-2e6b9f0b73ac"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"EventSubProcess12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(552, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpenVwSysSchemaInSolutionChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("eb90796d-7b2e-4f6c-935f-a91fa4bb3402"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c8a9054-449c-4c7e-ab4a-bc6d8918f42b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OpenVwSysSchemaInSolution",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"OpenVwSysSchemaInSolutionChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitOpenLookupUserTaskScriptChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d1c43fea-8148-4d53-a5e5-4a9dc1ea7073"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c8a9054-449c-4c7e-ab4a-bc6d8918f42b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"InitOpenLookupUserTaskScriptChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,147,79,111,211,48,24,198,207,171,212,239,96,133,75,43,218,116,29,165,73,181,49,105,77,83,41,226,95,181,182,219,1,113,240,82,183,13,77,237,204,118,24,81,85,9,198,17,36,238,124,12,4,210,96,104,124,5,231,27,225,56,37,253,35,84,245,130,196,33,150,236,248,121,158,247,253,229,13,227,212,195,35,224,97,198,33,118,145,51,0,143,64,161,208,67,148,66,70,134,92,239,59,250,57,186,176,8,230,148,248,76,239,192,17,42,38,139,126,194,2,181,209,157,76,170,247,72,87,217,21,138,135,249,220,243,0,225,39,132,76,194,160,207,16,237,65,54,177,198,158,63,208,59,148,184,136,177,199,40,146,81,43,185,247,129,242,77,150,36,14,122,24,81,189,143,189,203,16,57,45,233,87,169,136,207,226,78,124,45,1,241,67,220,197,215,242,121,27,127,16,223,213,86,252,20,191,196,141,184,21,55,242,240,189,248,22,95,199,239,226,79,32,185,37,110,227,143,201,21,32,190,128,115,66,39,44,128,46,2,214,105,213,120,96,62,220,7,103,87,221,136,117,221,49,154,66,7,47,223,107,181,182,93,223,111,24,70,217,50,170,213,114,205,108,30,148,205,90,163,81,174,90,118,179,105,91,109,195,172,155,90,62,199,82,126,76,25,244,21,190,221,164,91,8,37,59,137,0,35,151,123,4,75,199,245,131,109,108,37,188,14,164,112,138,56,162,76,42,49,186,2,45,79,201,32,141,192,81,90,110,9,144,139,87,210,236,88,125,168,215,144,130,96,83,88,216,162,42,130,221,242,165,247,186,175,126,50,24,20,180,140,149,86,90,114,75,10,177,136,239,167,45,30,45,211,55,195,143,193,208,243,87,186,219,77,164,26,173,84,172,211,123,85,227,192,172,55,242,185,133,139,42,105,157,210,166,24,204,64,62,183,183,7,102,154,75,166,1,164,30,35,184,23,5,72,150,223,86,38,214,218,177,110,95,134,208,159,151,22,26,31,13,185,253,38,160,114,228,165,189,172,54,156,226,14,228,99,169,214,228,228,101,19,167,101,138,144,161,150,199,2,31,70,103,208,15,147,152,33,244,25,2,243,210,159,58,168,55,26,175,152,102,128,213,125,38,5,73,67,105,245,47,94,130,153,250,175,214,103,72,207,114,117,103,48,159,207,19,60,255,3,145,167,16,203,98,233,51,217,207,63,4,162,217,152,123,60,74,255,250,69,164,182,160,240,247,153,77,135,61,109,46,241,91,176,74,4,20,241,144,98,192,105,136,14,127,3,15,71,143,14,78,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskChildUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("612e3e3f-6f15-4936-ac1b-f70b82100fda"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c8a9054-449c-4c7e-ab4a-bc6d8918f42b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"OpenLookupUserTaskChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 51),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupUserTaskChildParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateLookupGridPageClosedChildIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("5a95cf66-18fb-4b0e-8d03-4294a314f949"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c8a9054-449c-4c7e-ab4a-bc6d8918f42b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"BoundaryEvent",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"LookupGridPageClosedChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(316, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateApplyDataScriptChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("86e9c094-7e8f-47f3-8b3b-2c4963b1f5cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c8a9054-449c-4c7e-ab4a-bc6d8918f42b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"ApplyDataScriptChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(378, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,193,110,219,48,12,61,39,64,254,65,240,73,2,12,163,247,172,1,54,39,43,130,101,93,86,167,233,161,232,65,181,217,70,139,45,121,178,212,32,24,250,239,165,36,183,246,226,96,199,157,226,144,212,227,227,211,19,197,19,161,11,105,132,57,102,249,14,42,190,18,141,33,151,151,68,218,178,100,228,207,100,60,26,102,137,132,3,113,159,159,26,163,133,124,158,81,54,157,140,95,39,227,23,174,201,11,47,45,52,88,68,231,34,55,66,73,174,143,164,45,140,137,122,252,5,185,153,177,31,53,200,149,82,123,91,223,54,160,55,188,217,167,59,81,22,201,21,152,12,74,44,129,98,235,129,168,203,167,74,74,240,96,174,145,64,202,239,93,250,68,53,24,171,37,49,218,66,71,167,224,134,103,202,234,28,144,18,162,111,133,54,150,151,243,143,176,231,30,102,116,115,221,168,3,254,191,178,162,32,162,152,6,140,138,75,254,12,26,1,254,38,227,217,122,93,190,135,10,26,245,197,106,131,17,35,188,33,103,18,136,254,164,52,240,124,231,230,209,68,242,10,136,144,173,130,97,38,164,129,180,145,77,114,13,7,247,235,233,142,2,81,76,117,227,37,41,66,25,192,112,191,36,201,192,164,170,180,149,244,114,210,232,26,155,68,49,161,174,89,226,99,142,93,119,85,131,155,186,143,82,94,187,100,244,240,47,220,101,129,168,162,240,37,61,82,159,139,130,134,19,108,58,194,148,155,19,122,82,252,180,128,246,8,142,90,156,198,105,43,124,76,162,237,33,59,54,33,181,148,119,74,239,155,154,231,16,249,118,14,179,9,169,34,112,114,67,34,232,160,145,163,19,42,104,116,139,140,89,226,42,29,198,176,244,171,40,13,232,198,79,48,204,6,177,67,205,157,48,187,53,215,136,228,14,208,16,76,85,85,115,45,26,37,55,199,26,146,197,111,52,93,124,134,209,141,82,173,135,156,155,214,90,84,120,9,221,20,148,197,222,23,201,55,56,50,246,31,153,70,168,119,167,115,124,234,252,143,84,178,44,216,201,213,10,255,252,135,76,112,190,112,197,56,94,25,112,206,188,238,145,123,222,239,56,73,170,172,52,100,70,46,194,115,24,13,119,21,186,183,191,138,88,39,3,158,191,191,120,112,109,251,78,29,58,133,37,27,149,249,211,52,72,252,234,183,71,207,197,43,197,11,180,112,227,95,214,26,45,153,204,113,73,25,248,98,141,65,49,22,146,63,150,224,94,106,187,123,250,155,232,13,104,11,24,169,97,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageChangeReferenceLookupIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("297d80f1-0418-4626-983d-74d390882fc1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c8a9054-449c-4c7e-ab4a-bc6d8918f42b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeReferenceLookup",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"IntermediateThrowMessageChangeReferenceLookup",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(484, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeReferenceLookupEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeReferenceLookup = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ecc57d6f-9aea-49df-a42f-e3b251ac7c9f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d744f524-0228-44db-87e6-2e6b9f0b73ac"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"EventSubProcessChangeReferenceLookup",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(582, 170),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeReferenceLookup;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChangeReferenceLookupStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("45e2b6bc-a18b-47ae-ae56-89934c3765c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ecc57d6f-9aea-49df-a42f-e3b251ac7c9f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeReferenceLookup",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"StartMessageChangeReferenceLookup",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChangeReferenceLookupScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d961222c-aad8-441c-9fee-df41ccb04030"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ecc57d6f-9aea-49df-a42f-e3b251ac7c9f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"ScriptChangeReferenceLookup",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,44,46,73,205,75,45,10,201,40,202,47,119,45,75,205,43,209,240,129,10,5,36,166,167,6,20,229,39,167,22,23,135,122,166,232,40,40,57,231,231,148,230,230,121,230,165,229,251,228,231,103,151,22,20,59,103,36,230,165,167,166,40,105,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,165,68,92,96,84,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessClearItemsEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessClearItems = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("56f111ad-2d0a-49e1-af2c-8c2e36540581"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d744f524-0228-44db-87e6-2e6b9f0b73ac"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"EventSubProcessClearItems",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(595, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessClearItems;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageClearItemsStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1fc6f069-3e91-4ed3-ace5-520d00cd8258"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("56f111ad-2d0a-49e1-af2c-8c2e36540581"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ClearAllItems",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"StartMessageClearItems",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptClearAllItemsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b3fd4e0a-b411-45fb-b5df-ca46316eb949"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("56f111ad-2d0a-49e1-af2c-8c2e36540581"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"ScriptClearAllItems",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,73,77,44,242,44,73,205,45,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,239,252,184,121,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInitializeLookupListEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInitializeLookupList = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("64312632-1d0a-40f5-a625-4a585b125c60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3b2b6c5-6106-40fa-9f36-14f94b363516"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"EventSubProcessInitializeLookupList",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(273, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInitializeLookupList;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitializeLookupListStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("be305c98-94b2-4496-951c-f61cb57776f1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64312632-1d0a-40f5-a625-4a585b125c60"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"InitializeLookupList",
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"StartMessageInitializeLookupList",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitializeLookupListScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7dc38756-d41e-4f4e-b77c-64190e5b19d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64312632-1d0a-40f5-a625-4a585b125c60"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Name = @"ScriptInitializeLookupList",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,77,75,3,49,16,61,87,232,127,8,245,178,11,18,173,32,61,212,22,116,43,165,80,69,218,234,69,60,164,155,169,70,118,19,200,78,90,138,248,223,157,36,165,110,63,20,79,33,51,243,102,222,123,147,44,133,101,160,81,225,122,154,191,67,41,198,170,66,214,99,119,251,33,81,49,127,94,87,104,149,126,235,119,155,39,106,193,146,67,100,143,105,87,20,41,251,108,158,52,44,160,179,154,161,117,64,245,95,199,33,60,51,78,7,224,197,47,168,37,81,92,138,194,65,69,196,52,172,216,64,229,168,140,22,118,205,54,124,206,152,153,127,64,142,253,36,237,70,64,125,204,189,208,226,13,44,161,31,233,228,49,200,119,114,143,214,44,149,4,203,135,128,155,80,210,186,59,236,209,74,189,19,51,176,86,84,102,225,201,91,224,161,78,65,197,143,0,136,206,130,106,68,254,206,146,125,94,35,201,148,62,112,63,186,112,126,158,77,78,219,157,203,78,251,170,65,215,168,255,101,23,253,74,138,158,42,176,153,209,26,130,37,199,24,120,73,35,132,242,118,253,52,146,137,247,111,232,148,76,118,91,165,105,183,177,53,91,10,20,83,227,108,14,52,128,208,207,202,162,19,197,96,27,14,46,199,81,126,33,19,179,162,187,239,202,148,220,248,95,110,61,223,99,72,253,118,232,253,97,243,63,236,212,162,4,111,98,244,39,90,71,52,122,65,35,127,128,85,208,234,233,54,34,81,74,253,200,227,25,181,66,160,112,189,132,79,1,51,83,184,82,63,251,174,73,235,129,134,180,206,194,44,30,66,124,102,166,225,221,37,233,95,184,145,36,148,146,161,164,54,244,70,134,53,16,34,141,15,188,150,27,27,33,41,81,5,62,225,181,14,160,0,132,91,135,24,214,43,230,5,120,125,155,239,81,255,44,223,164,237,146,72,203,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateVirtualDataSourceStructureMethod());
			Methods.Add(CreateGetVirtualDataSourceMethod());
			Methods.Add(CreateClearItemsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c7264d7d-f1be-4edb-87b6-2cabdf00e8a0"),
				Name = "Terrasoft.Core.Configuration",
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
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
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

		protected override SchemaMethod CreateGetRegisterQuestionScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterQuestionScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateVirtualDataSourceStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c3b1543f-017e-4c8e-9695-0bdb4efc4a3b"),
				Name = "CreateVirtualDataSourceStructure",
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cda88119-938f-4549-9300-238b52e4c796"),
				Name = "dataValueTypeManager",
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataValueTypeManager",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e15ea76d-ce25-4a24-9780-d3bb777c4e81"),
				Name = "defStructure",
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				ModifiedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceStructure",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,65,106,195,48,16,60,219,175,48,62,197,80,244,129,208,67,235,148,224,67,74,193,105,238,91,105,211,8,100,217,72,171,180,166,244,239,149,44,199,9,14,129,146,147,209,204,236,236,206,224,35,152,76,0,65,221,58,195,49,123,204,222,224,19,217,106,66,150,233,209,43,44,63,96,3,158,61,75,89,61,96,145,71,77,146,250,136,108,64,123,11,115,178,122,183,104,202,86,107,228,36,91,205,94,174,149,209,130,183,202,53,218,79,105,252,202,206,251,107,50,142,147,51,88,70,254,39,77,146,87,104,194,165,121,37,242,7,255,220,129,114,35,61,99,130,205,192,110,251,14,199,235,167,247,184,157,173,145,42,109,9,52,199,231,62,24,44,242,181,147,34,47,130,67,9,93,56,251,194,179,178,59,105,229,135,10,126,123,80,22,35,88,183,134,224,2,77,147,223,101,154,8,220,79,1,216,147,16,241,202,69,204,90,120,193,29,169,195,247,86,238,137,91,73,219,41,232,111,177,119,246,178,65,33,93,179,197,111,154,183,19,127,16,22,247,217,48,123,154,25,150,22,108,148,206,27,244,57,175,11,12,224,191,250,251,3,139,188,180,197,189,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a2d09c58-1353-4b68-9c75-7e8487a6cdca"),
				Name = "GetVirtualDataSource",
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,3,17,206,249,121,37,137,153,121,169,69,122,110,153,121,41,48,145,162,252,28,141,176,204,162,146,210,196,28,151,196,146,196,224,252,210,162,228,84,79,23,77,133,196,98,5,12,113,107,0,231,40,17,24,84,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8d887d96-4612-4164-9a02-3cdc58f6f500"),
				Name = "ClearItems",
				CreatedInSchemaUId = new Guid("4286b499-1575-4734-acb2-8000647e5473"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,205,10,194,48,16,132,207,205,83,172,183,244,210,62,128,63,23,149,34,244,32,42,222,151,102,219,6,218,4,54,105,69,196,119,55,41,120,105,78,11,179,223,206,204,206,200,48,107,246,19,14,39,244,120,183,19,55,4,123,168,200,63,215,178,204,183,98,14,60,25,175,253,251,222,244,52,98,173,157,15,248,121,45,161,131,56,119,206,179,54,221,97,43,116,11,50,57,220,236,193,76,195,144,195,71,100,173,101,194,166,7,25,35,220,194,92,20,104,147,196,45,116,150,148,46,110,52,218,153,164,161,23,84,147,86,242,239,145,135,218,217,87,100,107,159,226,56,16,114,124,234,43,174,216,81,241,96,162,138,181,10,78,45,147,235,163,119,92,151,101,26,86,91,84,55,251,114,97,255,3,28,71,5,15,67,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ColumnInfoLookupsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4286b499-1575-4734-acb2-8000647e5473"));
		}

		#endregion

	}

	#endregion

}

